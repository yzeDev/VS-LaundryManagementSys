Imports System.Data.OleDb
Imports System.Net.Http
Public Class DashboardControl
    Private lastTransactionCount As Integer = -1
    Private lastMachineCount As Integer = -1

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupDashboardTransactionTable()
        LoadDashboardCounters()
        LoadMachineCounters()
        LoadDashboardTransactions()
    End Sub

    Public Sub RefreshDashboard()
        CheckForTransactionUpdates()
        CheckForMachineUpdates()
    End Sub

    ' =======================
    ' TRANSACTION COUNTERS
    ' =======================
    Private Sub CheckForTransactionUpdates()
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"
        Dim totalCount As Integer = 0

        Try
            Using conn As New OleDbConnection(connString)
                conn.Open()
                Using cmd As New OleDbCommand("SELECT COUNT(*) FROM Transactions", conn)
                    totalCount = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using

            If totalCount <> lastTransactionCount Then
                lastTransactionCount = totalCount
                LoadDashboardCounters()
            End If

        Catch ex As Exception
            MessageBox.Show("Error checking transaction updates: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadDashboardCounters()
        Try
            Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"
            Using conn As New OleDbConnection(connString)
                conn.Open()

                Dim query As String = "
                    SELECT Status, COUNT(*) AS Total
                    FROM Transactions
                    GROUP BY Status;
                "

                Using cmd As New OleDbCommand(query, conn)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        ' Reset all counts
                        lblPendingOrders.Text = "0"
                        lblinProgress.Text = "0"
                        lblDelivery.Text = "0"
                        lblCompleted.Text = "0"

                        While reader.Read()
                            Dim status As String = reader("Status").ToString().ToLower()
                            Dim count As Integer = Convert.ToInt32(reader("Total"))

                            Select Case status
                                Case "pending"
                                    lblPendingOrders.Text = count.ToString()
                                Case "in-progress"
                                    lblinProgress.Text = count.ToString()
                                Case "for delivery", "out for delivery"
                                    lblDelivery.Text = count.ToString()
                                Case "completed"
                                    lblCompleted.Text = count.ToString()
                            End Select
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading transaction counters: " & ex.Message)
        End Try
    End Sub

    ' =======================
    ' MACHINE COUNTERS
    ' =======================
    Private Sub CheckForMachineUpdates()
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"
        Dim totalCount As Integer = 0

        Try
            Using conn As New OleDbConnection(connString)
                conn.Open()
                Using cmd As New OleDbCommand("SELECT COUNT(*) FROM UnitData", conn)
                    totalCount = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using

            If totalCount <> lastMachineCount Then
                lastMachineCount = totalCount
                LoadMachineCounters()
            End If

        Catch ex As Exception
            MessageBox.Show("Error checking machine updates: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadMachineCounters()
        Try
            Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"
            Using conn As New OleDbConnection(connString)
                conn.Open()

                Dim query As String = "
                    SELECT Status, COUNT(*) AS Total
                    FROM UnitData
                    GROUP BY Status;
                "

                Using cmd As New OleDbCommand(query, conn)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        lblAvailableMachines.Text = "0"
                        lblInUseMachines.Text = "0"
                        lblUnavailableMachines.Text = "0"

                        While reader.Read()
                            Dim status As String = reader("Status").ToString().ToLower()
                            Dim count As Integer = Convert.ToInt32(reader("Total"))

                            Select Case status
                                Case "available"
                                    lblAvailableMachines.Text = count.ToString()
                                Case "in-use"
                                    lblInUseMachines.Text = count.ToString()
                                Case "unavailable"
                                    lblUnavailableMachines.Text = count.ToString()
                            End Select
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading machine counters: " & ex.Message)
        End Try
    End Sub
    Private Sub LoadDashboardTransactions()
        Try
            dgvDashboardTransactions.Rows.Clear()

            Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"
            Using conn As New OleDbConnection(connString)
                conn.Open()

                Dim query As String = "
                SELECT TransactionID, CustomerName, ContactNumber, Status
                FROM Transactions
                WHERE Status IN ('For Pickup', 'For Delivery')
                ORDER BY TransactionID DESC;
            "

                Using cmd As New OleDbCommand(query, conn)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        Dim notifyIcon As Image = Image.FromFile("C:\Users\Eisen\OneDrive\Documents\Assets\bell.png")
                        Dim completeIcon As Image = Image.FromFile("C:\Users\Eisen\OneDrive\Documents\Assets\yes.png")

                        While reader.Read()
                            dgvDashboardTransactions.Rows.Add(
                                reader("TransactionID").ToString(),
                                reader("CustomerName").ToString(),
                                reader("ContactNumber").ToString(),
                                reader("Status").ToString(),
                                Nothing, ' waiting time column (blank for now)
                                notifyIcon,
                                completeIcon
                            )
                        End While

                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading dashboard transactions: " & ex.Message)
        End Try
    End Sub


    Private Sub HandleCheckClick(id As Integer)
        Dim confirm = MessageBox.Show($"Mark transaction #{id} as Completed?",
                                  "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm <> DialogResult.Yes Then Exit Sub

        Try
            Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"
            Using conn As New OleDbConnection(connString)
                conn.Open()
                Dim sql As String = "UPDATE Transactions SET Status = 'Completed' WHERE TransactionID = @id"
                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Transaction marked as Completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadDashboardTransactions()
            LoadDashboardCounters()

        Catch ex As Exception
            MessageBox.Show("Error updating transaction: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateDashboardCounters()
        LoadDashboardCounters()
        LoadMachineCounters()
        LoadDashboardTransactions()
    End Sub

    Private Sub SetupDashboardTransactionTable()
        With dgvDashboardTransactions
            ' === BASIC STYLE SETTINGS ===
            .ReadOnly = True
            .Font = New Font("Poppins", 11, FontStyle.Regular)
            .ColumnHeadersHeight = 35
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .Columns.Clear()
            .AutoGenerateColumns = False
            .AllowUserToAddRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AllowUserToResizeColumns = False
            .AllowUserToOrderColumns = False
            .BorderStyle = BorderStyle.None
            .BackgroundColor = Color.White
            .EnableHeadersVisualStyles = False
            .RowHeadersVisible = False
            .CellBorderStyle = DataGridViewCellBorderStyle.None
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .GridColor = Color.White

            ' === PURE WHITE HEADER DESIGN ===
            With .ColumnHeadersDefaultCellStyle
                .BackColor = Color.White
                .ForeColor = Color.Black
                .Font = New Font("Poppins", 12, FontStyle.Regular)
                .Alignment = DataGridViewContentAlignment.MiddleCenter
                .SelectionBackColor = Color.White
                .SelectionForeColor = Color.Black
            End With

            ' === THIN BOTTOM BORDER UNDER HEADER ===
            AddHandler .CellPainting, Sub(sender, e)
                                          If e.RowIndex = -1 Then
                                              e.PaintBackground(e.ClipBounds, True)
                                              Using pen As New Pen(Color.LightGray, 1)
                                                  e.Graphics.DrawLine(pen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1)
                                              End Using
                                              e.PaintContent(e.ClipBounds)
                                              e.Handled = True
                                          End If
                                      End Sub

            ' === ADD TEXT COLUMNS ===
            .Columns.Add("TransactionID", "ID")
            .Columns.Add("CustomerName", "Customer")
            .Columns.Add("ContactNumber", "Contact")
            .Columns.Add("Status", "Status")
            .Columns.Add("WaitingTime", "Waiting")

            ' === ADD IMAGE COLUMNS (ICON BUTTONS) — compact side by side ===
            Dim notifyIconCol As New DataGridViewImageColumn() With {
    .Name = "btnNotify",
    .HeaderText = "Actions",
    .ImageLayout = DataGridViewImageCellLayout.Zoom,
    .Width = 20
}

            Dim completeIconCol As New DataGridViewImageColumn() With {
    .Name = "btnComplete",
    .HeaderText = "",
    .ImageLayout = DataGridViewImageCellLayout.Zoom,
    .Width = 20
}

            .Columns.Add(notifyIconCol)
            .Columns.Add(completeIconCol)

            .Columns("btnNotify").DefaultCellStyle.Padding = New Padding(0, 0, -5, 0)
            .Columns("btnComplete").DefaultCellStyle.Padding = New Padding(-5, 0, 0, 0)


            ' === PREVENT SORTING (EXCEPT STATUS) ===
            For Each col As DataGridViewColumn In .Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next
            If .Columns.Contains("Status") Then
                .Columns("Status").SortMode = DataGridViewColumnSortMode.Automatic
            End If

            ' === CENTER ALIGN DATA CELLS ===
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        ' === LOAD ICON IMAGES SAFELY ===
        Dim notifyIcon As Image = Image.FromFile("C:\Users\Eisen\OneDrive\Documents\Assets\bell.png")
        Dim completeIcon As Image = Image.FromFile("C:\Users\Eisen\OneDrive\Documents\Assets\yes.png")

        ' Set default icons for the ImageColumns
        DirectCast(dgvDashboardTransactions.Columns("btnNotify"), DataGridViewImageColumn).Image = notifyIcon
        DirectCast(dgvDashboardTransactions.Columns("btnComplete"), DataGridViewImageColumn).Image = completeIcon
    End Sub




    Private Async Sub DgvDashboardTransactions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDashboardTransactions.CellContentClick
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

        Dim colName As String = dgvDashboardTransactions.Columns(e.ColumnIndex).Name
        Dim id As Integer = Convert.ToInt32(dgvDashboardTransactions.Rows(e.RowIndex).Cells("TransactionID").Value)
        Dim customerName As String = dgvDashboardTransactions.Rows(e.RowIndex).Cells("CustomerName").Value.ToString()
        Dim contactNumber As String = dgvDashboardTransactions.Rows(e.RowIndex).Cells("ContactNumber").Value.ToString()
        Dim status As String = dgvDashboardTransactions.Rows(e.RowIndex).Cells("Status").Value.ToString()

        Select Case colName
            Case "btnNotify"

            Case "btnComplete"
                HandleCheckClick(id)
        End Select
    End Sub

    Private Sub addOrderBtn_Click(sender As Object, e As EventArgs) Handles addOrderBtn.Click
        Dim optionsForm As New TransactionOption()
        optionsForm.StartPosition = FormStartPosition.CenterParent
        optionsForm.ShowDialog()
    End Sub
End Class

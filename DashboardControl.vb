Imports System.Data.OleDb
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text
Imports System.Threading.Tasks
Public Class DashboardControl
    Private lastTransactionCount As Integer = -1
    Private lastMachineCount As Integer = -1
    Private Shared ReadOnly httpClient As New HttpClient()

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup main dashboard transaction table
        SetupDashboardTransactionTable()


        ' Load counters
        LoadDashboardCounters()
        LoadMachineCounters()
        LoadDashboardTransactions()

        ' Make the pendingOrdersPanel clickable with hand cursor
        MakeGuna2PanelClickable(pendingOrdersPanel, Sub() ShowPendingOrders(Nothing, Nothing))

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
            .Font = New Font("Poppins", 12, FontStyle.Regular) ' Bigger font
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
                .Font = New Font("Poppins", 12, FontStyle.Regular) ' Bigger header font
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

            ' === ADJUST ROW HEIGHT TO FIT FONT ===
            .RowTemplate.Height = 30  ' Adjust this to fit your font nicely
            .RowTemplate.DefaultCellStyle.Font = New Font("Poppins", 11, FontStyle.Regular) ' row font

            ' === ADD COMBINED ACTION COLUMN ===
            Dim actionCol As New DataGridViewImageColumn() With {
            .Name = "btnActions",
            .HeaderText = "Actions",
            .ImageLayout = DataGridViewImageCellLayout.Normal,
            .Width = 50
        }
            .Columns.Add(actionCol)

            ' === CENTER ALIGN DATA CELLS ===
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ' === PREVENT SORTING (EXCEPT STATUS) ===
            For Each col As DataGridViewColumn In .Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next
            If .Columns.Contains("Status") Then
                .Columns("Status").SortMode = DataGridViewColumnSortMode.Automatic
            End If
        End With
    End Sub

    Private Sub addOrderBtn_Click(sender As Object, e As EventArgs) Handles addOrderBtn.Click
        Dim optionsForm As New TransactionOption()
        optionsForm.StartPosition = FormStartPosition.CenterParent
        optionsForm.ShowDialog()
    End Sub

    ' ====================== SMS FUNCTION ======================
    Private Async Function SendSmsGsm(phoneNumber As String, message As String) As Task(Of Boolean)
        Dim username As String = "yzekeil"
        Dim password As String = "laundry"
        Dim ip As String = "192.168.1.3"
        Dim port As String = "8093"
        'http://192.168.1.3:8093/SendSMS?username=yzekeil&password=laundry&phone=639918739459&message=test
        Dim url As String = $"http://{ip}:{port}/SendSMS?username={username}&password={password}&phone={phoneNumber}&message={Uri.EscapeDataString("BubbleFresh Laundry" & vbLf & vbLf & message)}"

        Using client As New HttpClient()
            ' Add Basic Authentication header
            Dim byteArray = System.Text.Encoding.ASCII.GetBytes($"{username}:{password}")
            client.DefaultRequestHeaders.Authorization = New System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray))

            Try
                Dim response As HttpResponseMessage = Await client.GetAsync(url)
                Dim result As String = Await response.Content.ReadAsStringAsync()

                ' Optional: Debug
                ' MessageBox.Show(result)

                Return response.IsSuccessStatusCode
            Catch ex As Exception
                MessageBox.Show($"Error sending SMS: {ex.Message}", "SMS Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function


    ' ====================== HANDLE BUTTON CLICK ======================
    Private Async Sub dgvDashboardTransactions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDashboardTransactions.CellContentClick
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

        Dim colName As String = dgvDashboardTransactions.Columns(e.ColumnIndex).Name
        Dim id As Integer = Convert.ToInt32(dgvDashboardTransactions.Rows(e.RowIndex).Cells("TransactionID").Value)
        Dim customerName As String = dgvDashboardTransactions.Rows(e.RowIndex).Cells("CustomerName").Value.ToString()
        Dim contactNumber As String = dgvDashboardTransactions.Rows(e.RowIndex).Cells("ContactNumber").Value.ToString()
        Dim status As String = dgvDashboardTransactions.Rows(e.RowIndex).Cells("Status").Value.ToString()

        If colName = "btnActions" Then
            Dim cellRect As Rectangle = dgvDashboardTransactions.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False)
            Dim clickX As Integer = dgvDashboardTransactions.PointToClient(Cursor.Position).X - cellRect.Left

            If clickX < 25 Then
                ' Notify icon clicked
                Dim smsMessage As String
                If status.Equals("For Pickup", StringComparison.OrdinalIgnoreCase) Then
                    smsMessage = $"Hi {customerName}, your laundry is ready for pickup. Thank you!"
                ElseIf status.Equals("For Delivery", StringComparison.OrdinalIgnoreCase) Then
                    smsMessage = $"Hi {customerName}, your laundry is out for delivery. It will arrive soon. Thank you!"
                Else
                    smsMessage = $"Hi {customerName}, your laundry update: {status}."
                End If

                Dim confirm = MessageBox.Show($"Send SMS to {customerName} ({contactNumber})?" & vbCrLf & vbCrLf & smsMessage,
                                         "Send Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirm = DialogResult.Yes Then
                    Dim success As Boolean = Await SendSmsGsm(contactNumber, smsMessage)
                    If success Then
                        MessageBox.Show("SMS sent successfully!", "Customer Notified", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to send SMS.", "Customer Notified", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            Else
                ' Complete icon clicked
                HandleCheckClick(id)
            End If
        End If
    End Sub


    Private Sub dgvDashboardTransactions_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvDashboardTransactions.CellPainting
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvDashboardTransactions.Columns("btnActions").Index Then
            e.PaintBackground(e.CellBounds, True)

            Dim notifyIcon As Image = Image.FromFile("C:\Users\Eisen\OneDrive\Documents\Assets\bell.png")
            Dim completeIcon As Image = Image.FromFile("C:\Users\Eisen\OneDrive\Documents\Assets\yes.png")

            Dim iconSize As Integer = 20
            Dim spacing As Integer = 5 ' gap between icons
            Dim totalWidth As Integer = iconSize * 2 + spacing

            ' Center X inside the cell
            Dim startX As Integer = e.CellBounds.Left + (e.CellBounds.Width - totalWidth) \ 2
            Dim startY As Integer = e.CellBounds.Top + (e.CellBounds.Height - iconSize) \ 2

            ' Draw notify icon on left
            Dim notifyRect As New Rectangle(startX, startY, iconSize, iconSize)
            e.Graphics.DrawImage(notifyIcon, notifyRect)

            ' Draw complete icon on right
            Dim completeRect As New Rectangle(startX + iconSize + spacing, startY, iconSize, iconSize)
            e.Graphics.DrawImage(completeIcon, completeRect)

            e.Handled = True
        End If
    End Sub



    '==========PENDING ORDERS CLICK==========
    ' Make Guna2Panel clickable, including children
    Private Sub SetupPendingOrdersTable(dgv As DataGridView)
        With dgv
            ' ===== BASIC SETTINGS =====
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .RowHeadersVisible = False
            .ColumnHeadersHeight = 35
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .AutoGenerateColumns = False
            .GridColor = Color.White
            .BackgroundColor = Color.White
            .BorderStyle = BorderStyle.None
            .CellBorderStyle = DataGridViewCellBorderStyle.None
            .EnableHeadersVisualStyles = False

            ' ===== CLEAR EXISTING COLUMNS =====
            .Columns.Clear()

            ' ===== ADD COLUMNS =====
            .Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "TransactionID", .HeaderText = "ID"})
            .Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "CustomerName", .HeaderText = "Customer"})
            .Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "ContactNumber", .HeaderText = "Contact"})
            .Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "ServiceType", .HeaderText = "Service"})
            .Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "WaitingTime", .HeaderText = "Waiting Time"})

            ' ===== HEADER STYLE =====
            With .ColumnHeadersDefaultCellStyle
                .BackColor = Color.White
                .ForeColor = Color.Black
                .Font = New Font("Poppins", 11, FontStyle.Regular)
                .Alignment = DataGridViewContentAlignment.MiddleCenter
                .SelectionBackColor = Color.White   ' prevent highlight
                .SelectionForeColor = Color.Black
            End With

            ' ===== ROW STYLE =====
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.Font = New Font("Poppins", 10, FontStyle.Regular)
            .DefaultCellStyle.SelectionBackColor = Color.White
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            ' ===== DISABLE SORTING =====
            For Each col As DataGridViewColumn In .Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            ' ===== DRAW ONLY BOTTOM LINE FOR HEADERS =====
            AddHandler .CellPainting, Sub(sender, e)
                                          If e.RowIndex = -1 Then
                                              ' Fill background
                                              Using backBrush As New SolidBrush(Color.White)
                                                  e.Graphics.FillRectangle(backBrush, e.CellBounds)
                                              End Using

                                              ' Draw bottom line
                                              Using pen As New Pen(Color.LightGray, 1)
                                                  e.Graphics.DrawLine(pen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1)
                                              End Using

                                              ' Draw header text
                                              TextRenderer.DrawText(e.Graphics, e.FormattedValue.ToString(),
                                                                e.CellStyle.Font,
                                                                e.CellBounds,
                                                                e.CellStyle.ForeColor,
                                                                TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)

                                              e.Handled = True
                                          End If
                                      End Sub

            ' ===== PREVENT ROW SELECTION ON CLICK =====
            AddHandler .CellMouseDown, Sub(s, e)
                                           If e.RowIndex >= 0 Then
                                               .ClearSelection()
                                           End If
                                       End Sub
        End With
    End Sub




    Private Sub MakeGuna2PanelClickable(panel As Guna.UI2.WinForms.Guna2Panel, clickAction As Action)

        panel.Cursor = Cursors.Hand
        AddHandler panel.Click, Sub() clickAction.Invoke()

        SetCursorAndClickForChildren(panel, clickAction)
    End Sub

    Private Sub SetCursorAndClickForChildren(ctrl As Control, clickAction As Action)
        For Each child As Control In ctrl.Controls
            child.Cursor = Cursors.Hand
            AddHandler child.Click, Sub() clickAction.Invoke()

            If child.Controls.Count > 0 Then
                SetCursorAndClickForChildren(child, clickAction)
            End If
        Next
    End Sub




    Private Sub ShowPendingOrders(sender As Object, e As EventArgs)
        ' Create a new form
        Dim pendingForm As New Form With {
        .Text = "Pending Orders",
        .Size = New Size(800, 500),
        .StartPosition = FormStartPosition.CenterParent
    }

        ' Create DataGridView
        Dim dgv As New DataGridView With {
        .Dock = DockStyle.Fill,
        .ReadOnly = True,
        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
        .SelectionMode = DataGridViewSelectionMode.FullRowSelect
    }

        pendingForm.Controls.Add(dgv)
        SetupPendingOrdersTable(dgv)
        LoadPendingOrders(dgv)


        pendingForm.ShowDialog()
    End Sub

    Private Sub LoadPendingOrders(dgv As DataGridView)
        dgv.Rows.Clear()
        dgv.Columns.Clear()

        ' Add columns
        dgv.Columns.Add("TransactionID", "Transaction ID")
        dgv.Columns.Add("CustomerName", "Customer Name")
        dgv.Columns.Add("ContactNumber", "Contact Number")
        dgv.Columns.Add("ServiceType", "Service Type")
        dgv.Columns.Add("WaitingTime", "Waiting Time")

        ' Database connection
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"

        Using conn As New OleDbConnection(connString)
            conn.Open()
            Dim query As String = "
            SELECT TransactionID, CustomerName, ContactNumber, ServiceType, TransactionDate
            FROM Transactions
            WHERE Status = 'Pending'
            ORDER BY TransactionDate ASC;
        "

            Using cmd As New OleDbCommand(query, conn)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim transactionTime As DateTime = Convert.ToDateTime(reader("TransactionDate"))
                        Dim waitingTime As TimeSpan = DateTime.Now - transactionTime

                        ' Build compact string, skipping zero values except seconds
                        Dim parts As New List(Of String)
                        If waitingTime.Days > 0 Then parts.Add($"{waitingTime.Days}d")
                        If waitingTime.Hours > 0 Then parts.Add($"{waitingTime.Hours}h")
                        If waitingTime.Minutes > 0 Then parts.Add($"{waitingTime.Minutes}m")
                        parts.Add($"{waitingTime.Seconds}s") ' Always show seconds

                        Dim waitingStr As String = String.Join(" ", parts)

                        dgv.Rows.Add(
                            reader("TransactionID").ToString(),
                            reader("CustomerName").ToString(),
                            reader("ContactNumber").ToString(),
                            reader("ServiceType").ToString(),
                            waitingStr
                        )
                    End While
                End Using
            End Using
        End Using
    End Sub


End Class

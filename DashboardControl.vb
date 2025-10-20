Imports System.Data.OleDb

Public Class DashboardControl
    Private lastTransactionCount As Integer = -1
    Private lastMachineCount As Integer = -1

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadDashboardCounters()
        LoadMachineCounters()
        LoadDashboardTransactions() ' ← ADD THIS
    End Sub


    ' 🔁 Call this whenever user navigates back to the dashboard
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

            ' Only reload if number of transactions changed
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

            ' Only reload if number of machines changed
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
                        ' Reset counts
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
            flpDashboardTransactions.SuspendLayout()
            flpDashboardTransactions.Controls.Clear()

            ' Add header
            Dim header As New DashboardTransactionRowHeader()
            flpDashboardTransactions.Controls.Add(header)

            Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"
            Using conn As New OleDbConnection(connString)
                conn.Open()

                ' Only load "For Pickup" and "For Delivery"
                Dim query As String =
                "SELECT TransactionID, CustomerName, ContactNumber, Status 
                 FROM Transactions
                 WHERE Status IN ('For Pickup', 'For Delivery')
                 ORDER BY TransactionID DESC"

                Using cmd As New OleDbCommand(query, conn)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim row As New DashboardTransactionRow()
                            row.SetData(
                            CInt(reader("TransactionID")),
                            reader("CustomerName").ToString(),
                            reader("ContactNumber").ToString(),
                            reader("Status").ToString()
                        )

                            ' Connect button events
                            AddHandler row.NotifyClicked, AddressOf HandleNotifyClick
                            AddHandler row.CheckClicked, AddressOf HandleCheckClick

                            flpDashboardTransactions.Controls.Add(row)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading dashboard transactions: " & ex.Message)
        Finally
            flpDashboardTransactions.ResumeLayout()
        End Try
    End Sub


    Private Sub HandleNotifyClick(ByVal sender As DashboardTransactionRow)
        Dim status As String = sender.CurrentStatus
        Dim message As String

        If status.Equals("For Pickup", StringComparison.OrdinalIgnoreCase) Then
            message = "The customer has been notified that their order is ready for pickup."
        ElseIf status.Equals("For Delivery", StringComparison.OrdinalIgnoreCase) Then
            message = "The customer has been notified that their order is ready for delivery."
        Else
            message = "Notification sent."
        End If

        MessageBox.Show(message, "Customer Notified", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub HandleCheckClick(ByVal sender As DashboardTransactionRow)
        Dim id As Integer = sender.TransactionID

        Dim confirm = MessageBox.Show(
            $"Mark transaction #{id} as Completed?",
            "Confirm Update",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If confirm = DialogResult.Yes Then
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

                ' Refresh both dashboard transactions and counters
                LoadDashboardTransactions()
                UpdateDashboardCounters()

            Catch ex As Exception
                MessageBox.Show("Error updating transaction: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub UpdateDashboardCounters()
        ' Refresh both transaction and machine counters + reload table
        LoadDashboardCounters()
        LoadMachineCounters()
        LoadDashboardTransactions()
    End Sub

    Private Sub addOrderBtn_Click(sender As Object, e As EventArgs) Handles addOrderBtn.Click
        Dim popup As New BasicServiceForm()
        popup.ShowDialog()
    End Sub
End Class

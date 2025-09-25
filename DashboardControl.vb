Imports System.Data.OleDb
Public Class DashboardControl
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrderCounts()
        LoadMachineCounts()
    End Sub
    Private Sub LoadOrderCounts()
        Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\laundryfiles\Resources\LaundryDatabase.accdb;"

        Using conn As New OleDbConnection(connStr)
            Try
                conn.Open()

                ' Query to count orders grouped by status
                Dim sql As String = "SELECT Status, COUNT(*) AS TotalCount FROM Transactions GROUP BY Status"
                Dim cmd As New OleDbCommand(sql, conn)

                Dim reader As OleDbDataReader = cmd.ExecuteReader()

                ' Reset counts to 0 before filling
                lblPendingOrdersValue.Text = "0"
                lblInProgressValue.Text = "0"
                lblOutForDeliveryValue.Text = "0"
                lblCompletedValue.Text = "0"

                ' Loop through results and set labels
                While reader.Read()
                    Dim status As String = reader("Status").ToString()
                    Dim count As Integer = Convert.ToInt32(reader("TotalCount"))

                    Select Case status.ToLower()
                        Case "pending"
                            lblPendingOrdersValue.Text = count.ToString()
                        Case "in-progress"
                            lblInProgressValue.Text = count.ToString()
                        Case "out for delivery"
                            lblOutForDeliveryValue.Text = count.ToString()
                        Case "completed"
                            lblCompletedValue.Text = count.ToString()
                    End Select
                End While

                reader.Close()

            Catch ex As Exception
                MessageBox.Show("Error loading order counts: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadMachineCounts()
        Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"

        Using conn As New OleDbConnection(connStr)
            Try
                conn.Open()

                ' Query to count machines grouped by status
                Dim sql As String = "SELECT Status, COUNT(*) AS TotalCount FROM UnitData GROUP BY Status"
                Dim cmd As New OleDbCommand(sql, conn)

                Dim reader As OleDbDataReader = cmd.ExecuteReader()

                ' Reset counts before filling
                lblAvailableValue.Text = "0"
                lblInUseValue.Text = "0"
                lblBrokenValue.Text = "0"

                ' Loop through results
                While reader.Read()
                    Dim status As String = reader("Status").ToString()
                    Dim count As Integer = Convert.ToInt32(reader("TotalCount"))

                    Select Case status.ToLower()
                        Case "available"
                            lblAvailableValue.Text = count.ToString()
                        Case "in-use"
                            lblInUseValue.Text = count.ToString()
                        Case "damaged", "broken", "maintenance"
                            lblBrokenValue.Text = count.ToString()
                    End Select
                End While

                reader.Close()

            Catch ex As Exception
                MessageBox.Show("Error loading machine counts: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnReloadDashboard_Click(sender As Object, e As EventArgs) Handles btnReloadDashboard.Click
        LoadOrderCounts()
        LoadMachineCounts()
    End Sub
End Class

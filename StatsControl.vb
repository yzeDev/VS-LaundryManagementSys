Imports System.Data.OleDb

Public Class StatsControl

    ' ⚙️ UPDATE THIS PATH to match your actual file location
    Private dbPath As String = "C:\Users\Eisen\source\repos\LaundryManagementSys\LaundryDatabase.accdb"
    Private connectionString As String

    Private Sub StatsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create the connection string for Access
        connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};"
        ' Add period options
        cmbPeriod.Items.AddRange({"Weekly", "Monthly", "Semi-Annually", "Annually"})
        cmbPeriod.SelectedIndex = 0 ' Default selection
    End Sub

    Private Sub cmbPeriod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPeriod.SelectedIndexChanged
        CalculateStats()
    End Sub

    Private Sub dtpEndDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndDate.ValueChanged
        CalculateStats()
    End Sub

    Private Sub CalculateStats()
        If cmbPeriod.SelectedItem Is Nothing Then Exit Sub

        Dim endDate As Date = dtpEndDate.Value.Date
        Dim startDate As Date

        ' 📅 Determine start date based on selected period
        Select Case cmbPeriod.SelectedItem.ToString()
            Case "Weekly"
                startDate = endDate.AddDays(-6)
            Case "Monthly"
                startDate = endDate.AddMonths(-1).AddDays(1)
            Case "Semi-Annually"
                startDate = endDate.AddMonths(-6).AddDays(1)
            Case "Annually"
                startDate = endDate.AddYears(-1).AddDays(1)
            Case Else
                Exit Sub
        End Select

        ' 🧮 Query to get totals from Transactions table
        Dim query As String =
            "SELECT SUM(TotalPayment) AS TotalRevenue, COUNT(*) AS TotalOrders " &
            "FROM Transactions " &
            "WHERE TransactionDate BETWEEN @startDate AND @endDate"

        Try
            Using conn As New OleDbConnection(connectionString)
                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@startDate", startDate)
                    cmd.Parameters.AddWithValue("@endDate", endDate)

                    conn.Open()
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim totalRevenue As Decimal = If(IsDBNull(reader("TotalRevenue")), 0, Convert.ToDecimal(reader("TotalRevenue")))
                            Dim totalOrders As Integer = If(IsDBNull(reader("TotalOrders")), 0, Convert.ToInt32(reader("TotalOrders")))
                            Dim avgOrderValue As Decimal = 0

                            If totalOrders > 0 Then
                                avgOrderValue = totalRevenue / totalOrders
                            End If

                            ' 💬 Display results in labels (now with Peso sign)
                            lblTotalRev.Text = "₱" & totalRevenue.ToString("N2")
                            lblTotalOrder.Text = totalOrders.ToString()
                            lblOrderValue.Text = "₱" & avgOrderValue.ToString("N2")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading statistics: " & ex.Message)
        End Try
    End Sub

End Class

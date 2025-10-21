Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting

Public Class StatsControl


    Private dbPath As String = "C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb"
    Private conString As String


    Private chartStats As Chart
    Private chartReady As Boolean = False  ' To avoid errors while chart is loading



    Private Sub StatsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};"

        ' Load combo box options
        cmbPeriod.Items.AddRange({"Weekly", "Monthly", "Semi-Annually", "Annually"})
        cmbPeriod.SelectedIndex = -1

        ' Setup chart
        SetupChart()
        chartReady = True

        ' Load data
        CalculateStats()
        UpdateChart()
    End Sub



    Private Sub cmbPeriod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPeriod.SelectedIndexChanged
        If chartReady Then
            CalculateStats()
            UpdateChart()
        End If
    End Sub

    Private Sub dtpEndDate_ValueChanged(sender As Object, e As EventArgs)
        If chartReady Then
            CalculateStats()
            UpdateChart()
        End If
    End Sub



    Private Sub SetupChart()
        chartStats = New Chart() With {
            .Dock = DockStyle.Fill,
            .BackColor = Color.White
        }

        ' Add chart to panel
        statspanel.Controls.Add(chartStats)

        ' Chart area
        Dim area As New ChartArea("MainArea")
        With area
            .AxisX.MajorGrid.Enabled = False
            .AxisY.MajorGrid.LineColor = Color.LightGray
            .AxisY2.MajorGrid.Enabled = False

            .AxisX.LabelStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
            .AxisY.LabelStyle.Font = New Font("Segoe UI", 9)
            .AxisY2.LabelStyle.Font = New Font("Segoe UI", 9)

            .AxisY.LabelStyle.Format = "₱#,##0"
            .AxisY2.LabelStyle.Format = "#,##0"

            ' Adjust right-side axis to prevent duplicate scaling
            .AxisY2.IsLabelAutoFit = True
            .AxisY2.IntervalAutoMode = IntervalAutoMode.VariableCount
            .AxisY2.Interval = 1
        End With
        chartStats.ChartAreas.Add(area)

        ' Legend
        Dim legend As New Legend("Legend") With {
            .Docking = Docking.Top,
            .Alignment = StringAlignment.Center
        }
        chartStats.Legends.Add(legend)

        ' Title
        chartStats.Titles.Add(New Title("Total Revenue and Total Orders",
                                        Docking.Top,
                                        New Font("Segoe UI", 11, FontStyle.Bold),
                                        Color.Black))

        ' Series for total revenue (bar)
        Dim s1 As New Series("Total Revenue") With {
            .ChartType = SeriesChartType.Column,
            .Color = Color.FromArgb(72, 201, 176),
            .YValueType = ChartValueType.Double
        }
        chartStats.Series.Add(s1)

        ' Series for total orders (line)
        Dim s2 As New Series("Total Orders") With {
            .ChartType = SeriesChartType.Spline,
            .Color = Color.Black,
            .BorderWidth = 3,
            .YAxisType = AxisType.Secondary,
            .MarkerStyle = MarkerStyle.Circle,
            .MarkerSize = 6
        }
        chartStats.Series.Add(s2)
    End Sub


    Private Sub UpdateChart()
        If Not chartReady OrElse cmbPeriod.SelectedItem Is Nothing Then Exit Sub
        If chartStats.Series.IndexOf("Total Revenue") = -1 OrElse chartStats.Series.IndexOf("Total Orders") = -1 Then Exit Sub

        Dim endDate As Date = dtpEndDate.Value.Date
        Dim startDate As Date
        Dim period As String = cmbPeriod.SelectedItem.ToString()

        ' Determine range based on selected period
        Select Case period
            Case "Weekly"
                startDate = endDate.AddDays(-6)
            Case "Monthly"
                startDate = endDate.AddMonths(-1).AddDays(1)
            Case "Semi-Annually"
                startDate = endDate.AddMonths(-6).AddDays(1)
            Case "Annually"
                startDate = endDate.AddYears(-1).AddDays(1)
        End Select

        ' SQL Query (exclude cancelled/refund)
        Dim query As String =
            "SELECT TransactionDate, TotalPayment FROM Transactions " &
            "WHERE TransactionDate BETWEEN @startDate AND @endDate " &
            "AND (Status <> 'Cancelled' AND Status <> 'Refunded')"

        ' Dictionaries for storing totals
        Dim revenue As New Dictionary(Of String, Decimal)
        Dim orders As New Dictionary(Of String, Integer)

        Try
            Using con As New OleDbConnection(conString)
                Using cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("@startDate", startDate)
                    cmd.Parameters.AddWithValue("@endDate", endDate)
                    con.Open()

                    Using rdr As OleDbDataReader = cmd.ExecuteReader()
                        While rdr.Read()
                            Dim tDate As Date = CDate(rdr("TransactionDate")).Date
                            Dim pay As Decimal = CDec(rdr("TotalPayment"))
                            Dim key As String

                            ' Group key based on selected period
                            If period = "Semi-Annually" OrElse period = "Annually" Then
                                key = tDate.ToString("MMM yyyy")  ' Group by month
                            Else
                                key = tDate.ToString("MMM d")      ' Group by day
                            End If

                            ' Initialize if not existing
                            If Not revenue.ContainsKey(key) Then
                                revenue(key) = 0
                                orders(key) = 0
                            End If

                            ' Add to totals
                            revenue(key) += pay
                            orders(key) += 1
                        End While
                    End Using
                End Using
            End Using

            ' Clear previous chart data
            chartStats.Series("Total Revenue").Points.Clear()
            chartStats.Series("Total Orders").Points.Clear()

            ' Plot sorted data
            For Each k In revenue.Keys.OrderBy(Function(x)
                                                   Dim dt As Date
                                                   If Date.TryParseExact(x, "MMM yyyy", Nothing, Globalization.DateTimeStyles.None, dt) Then
                                                       Return dt
                                                   ElseIf Date.TryParseExact(x, "MMM d", Nothing, Globalization.DateTimeStyles.None, dt) Then
                                                       Return dt
                                                   Else
                                                       Return Date.MinValue
                                                   End If
                                               End Function)
                chartStats.Series("Total Revenue").Points.AddXY(k, revenue(k))
                chartStats.Series("Total Orders").Points.AddXY(k, orders(k))
            Next

            chartStats.Invalidate()

        Catch ex As Exception
            MessageBox.Show("Error loading chart: " & ex.Message)
        End Try
    End Sub


    ' CALCULATE STATS
    Private Sub CalculateStats()
        If cmbPeriod.SelectedItem Is Nothing Then Exit Sub

        Dim endDate As Date = dtpEndDate.Value.Date
        Dim startDate As Date

        ' Determine range based on selected period
        Select Case cmbPeriod.SelectedItem.ToString()
            Case "Weekly"
                startDate = endDate.AddDays(-6)
            Case "Monthly"
                startDate = endDate.AddMonths(-1).AddDays(1)
            Case "Semi-Annually"
                startDate = endDate.AddMonths(-6).AddDays(1)
            Case "Annually"
                startDate = endDate.AddYears(-1).AddDays(1)
        End Select

        ' SQL Query (exclude cancelled/refund)
        Dim query As String =
            "SELECT SUM(TotalPayment) AS TotalRevenue, COUNT(*) AS TotalOrders " &
            "FROM Transactions " &
            "WHERE TransactionDate BETWEEN @startDate AND @endDate " &
            "AND (Status <> 'Cancelled' AND Status <> 'Refunded')"

        Try
            Using con As New OleDbConnection(conString)
                Using cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("@startDate", startDate)
                    cmd.Parameters.AddWithValue("@endDate", endDate)
                    con.Open()

                    Using rdr As OleDbDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then
                            Dim totalRev As Decimal = If(IsDBNull(rdr("TotalRevenue")), 0, CDec(rdr("TotalRevenue")))
                            Dim totalOrd As Integer = If(IsDBNull(rdr("TotalOrders")), 0, CInt(rdr("TotalOrders")))
                            Dim avgVal As Decimal = 0

                            If totalOrd > 0 Then
                                avgVal = totalRev / totalOrd
                            End If

                            ' Display results
                            lblTotalRev.Text = "₱" & totalRev.ToString("N2")
                            lblTotalOrder.Text = totalOrd.ToString()
                            lblOrderValue.Text = "₱" & avgVal.ToString("N2")
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading statistics: " & ex.Message)
        End Try
    End Sub



    Private Sub statspanel_Paint(sender As Object, e As PaintEventArgs) Handles statspanel.Paint
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TableLayoutPanel5_Paint_1(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel5.Paint

    End Sub

    Private Sub Label15_Click_1(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub
End Class

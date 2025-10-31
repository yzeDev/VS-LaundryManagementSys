Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Globalization

Public Class StatsControl

    ' Keep dbPath WITHOUT a trailing semicolon
    Private dbPath As String = "C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"
    Private conString As String

    Private chartStats As Chart
    Private chartReady As Boolean = False

    Private Sub StatsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};"

        ' Load combo box options
        cmbPeriod.Items.Clear()
        cmbPeriod.Items.AddRange({"Weekly", "Monthly", "Semi-Annually", "Annually"})
        cmbPeriod.SelectedIndex = 0


        ' Setup chart
        SetupChart()
        chartReady = True

        ' Initial load
        CalculateStats()
        UpdateChart()
    End Sub

    ' IMPORTANT: wire the events
    Private Sub cmbPeriod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPeriod.SelectedIndexChanged
        If chartReady Then
            CalculateStats()
            UpdateChart()
        End If
    End Sub

    Private Sub dtpEndDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndDate.ValueChanged
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
        statspanel.Controls.Clear()
        statspanel.Controls.Add(chartStats)

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

            .AxisY2.Enabled = AxisEnabled.True
        End With
        chartStats.ChartAreas.Clear()
        chartStats.ChartAreas.Add(area)

        chartStats.Legends.Clear()
        Dim legend As New Legend("Legend") With {
            .Docking = Docking.Top,
            .Alignment = StringAlignment.Center
        }
        chartStats.Legends.Add(legend)

        chartStats.Titles.Clear()
        chartStats.Titles.Add(New Title("Total Revenue and Total Orders",
                                        Docking.Top,
                                        New Font("Segoe UI", 11, FontStyle.Bold),
                                        Color.Black))

        chartStats.Series.Clear()

        Dim s1 As New Series("Total Revenue") With {
            .ChartType = SeriesChartType.Column,
            .Color = Color.FromArgb(72, 201, 176),
            .YValueType = ChartValueType.Double,
            .ChartArea = "MainArea"
        }
        chartStats.Series.Add(s1)

        Dim s2 As New Series("Total Orders") With {
            .ChartType = SeriesChartType.Spline,
            .Color = Color.Black,
            .BorderWidth = 3,
            .YAxisType = AxisType.Secondary,
            .MarkerStyle = MarkerStyle.Circle,
            .MarkerSize = 6,
            .ChartArea = "MainArea"
        }
        chartStats.Series.Add(s2)
    End Sub

    Private Sub UpdateChart()
        If Not chartReady OrElse cmbPeriod.SelectedItem Is Nothing Then Exit Sub
        If chartStats.Series.IndexOf("Total Revenue") = -1 OrElse chartStats.Series.IndexOf("Total Orders") = -1 Then Exit Sub

        Dim endDate As Date = dtpEndDate.Value.Date
        Dim startDate As Date
        Dim period As String = cmbPeriod.SelectedItem.ToString()

        ' Date range
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

        ' Use ? placeholders and bracket reserved names
        Dim sql As String =
            "SELECT [TransactionDate], [TotalPayment] " &
            "FROM [Transactions] " &
            "WHERE [TransactionDate] BETWEEN ? AND ? " &
            "AND ([Status] <> 'Cancelled' AND [Status] <> 'Refunded')"

        ' Group by real Date key (Day or MonthStart), format labels later
        Dim revByBucket As New Dictionary(Of Date, Decimal)
        Dim ordByBucket As New Dictionary(Of Date, Integer)

        Try
            Using con As New OleDbConnection(conString)
                Using cmd As New OleDbCommand(sql, con)
                    ' parameter order MUST match the ? order in SQL
                    cmd.Parameters.Add("?", OleDbType.Date).Value = startDate
                    cmd.Parameters.Add("?", OleDbType.Date).Value = endDate
                    con.Open()

                    Using rdr As OleDbDataReader = cmd.ExecuteReader()
                        While rdr.Read()
                            Dim tDate As Date = CDate(rdr("TransactionDate"))
                            Dim pay As Decimal = CDec(rdr("TotalPayment"))

                            Dim bucket As Date
                            If period = "Semi-Annually" OrElse period = "Annually" Then
                                ' bucket to first of month
                                bucket = New Date(tDate.Year, tDate.Month, 1)
                            Else
                                ' bucket to day (date only)
                                bucket = tDate.Date
                            End If

                            If Not revByBucket.ContainsKey(bucket) Then
                                revByBucket(bucket) = 0D
                                ordByBucket(bucket) = 0
                            End If

                            revByBucket(bucket) += pay
                            ordByBucket(bucket) += 1
                        End While
                    End Using
                End Using
            End Using

            ' Plot
            chartStats.Series("Total Revenue").Points.Clear()
            chartStats.Series("Total Orders").Points.Clear()

            Dim orderedBuckets = revByBucket.Keys.OrderBy(Function(d) d).ToList()
            For Each b In orderedBuckets
                Dim label As String =
                    If(period = "Semi-Annually" OrElse period = "Annually",
                       b.ToString("MMM yyyy", CultureInfo.InvariantCulture),
                       b.ToString("MMM d", CultureInfo.InvariantCulture))

                chartStats.Series("Total Revenue").Points.AddXY(label, revByBucket(b))
                chartStats.Series("Total Orders").Points.AddXY(label, ordByBucket(b))
            Next

            chartStats.Invalidate()

        Catch ex As Exception
            MessageBox.Show("Error loading chart: " & ex.Message)
        End Try
    End Sub

    Private Sub CalculateStats()
        If cmbPeriod.SelectedItem Is Nothing Then Exit Sub

        Dim endDate As Date = dtpEndDate.Value.Date
        Dim startDate As Date

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

        Dim sql As String =
            "SELECT SUM([TotalPayment]) AS TotalRevenue, COUNT(*) AS TotalOrders " &
            "FROM [Transactions] " &
            "WHERE [TransactionDate] BETWEEN ? AND ? " &
            "AND ([Status] <> 'Cancelled' AND [Status] <> 'Refunded')"

        Try
            Using con As New OleDbConnection(conString)
                Using cmd As New OleDbCommand(sql, con)
                    cmd.Parameters.Add("?", OleDbType.Date).Value = startDate
                    cmd.Parameters.Add("?", OleDbType.Date).Value = endDate
                    con.Open()

                    Using rdr As OleDbDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then
                            Dim totalRev As Decimal = If(IsDBNull(rdr("TotalRevenue")), 0D, CDec(rdr("TotalRevenue")))
                            Dim totalOrd As Integer = If(IsDBNull(rdr("TotalOrders")), 0, CInt(rdr("TotalOrders")))
                            Dim avgVal As Decimal = If(totalOrd > 0, totalRev / totalOrd, 0D)

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

End Class

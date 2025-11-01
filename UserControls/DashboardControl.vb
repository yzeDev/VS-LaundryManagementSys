Imports System.Data.OleDb
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text
Imports System.Threading.Tasks
Imports System.Reflection

Public Class DashboardControl
    Private lastTransactionCount As Integer = -1
    Private lastMachineCount As Integer = -1
    Private Shared ReadOnly httpClient As New HttpClient()

    Private notifyIconRects As New Dictionary(Of Integer, Rectangle)
    Private completeIconRects As New Dictionary(Of Integer, Rectangle)
    Private archiveIconRects As New Dictionary(Of Integer, Rectangle)

    Private dashboardCache As New List(Of TransactionItem)
    Private filteredView As New List(Of TransactionItem)

    Private Class TransactionItem
        Public Property TransactionID As Integer
        Public Property CustomerName As String
        Public Property ContactNumber As String
        Public Property Status As String
        Public Property TransactionDate As Nullable(Of DateTime)
    End Class


    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupDashboardTransactionTable()
        InitSortCombo()
        LoadDashboardCounters()
        LoadMachineCounters()
        LoadDashboardTransactions()
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
        Dim totalCount As Integer = 0

        Try
            Using conn As New OleDbConnection(Db.ConnectionString)
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
            Using conn As New OleDbConnection(Db.ConnectionString)
                conn.Open()

                ' --- Compute current week [Mon 00:00) .. [next Mon 00:00) ---
                Dim today As Date = Date.Now
                Dim weekStart As Date
                ' start week on Monday
                If today.DayOfWeek = DayOfWeek.Sunday Then
                    weekStart = today.Date.AddDays(-6)
                Else
                    weekStart = today.Date.AddDays(-CInt(today.DayOfWeek) + 1)
                End If
                Dim weekEnd As Date = weekStart.AddDays(7)

                Dim query As String = "
                SELECT [Status], COUNT(*) AS Total
                FROM [Transactions]
                WHERE [TransactionDate] >= ? AND [TransactionDate] < ?
                GROUP BY [Status];
            "

                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.Add("?", OleDbType.Date).Value = weekStart
                    cmd.Parameters.Add("?", OleDbType.Date).Value = weekEnd

                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        ' reset counters
                        lblPendingOrders.Text = "0"
                        lblinProgress.Text = "0"
                        lblDelivery.Text = "0"
                        lblCompleted.Text = "0"

                        While reader.Read()
                            Dim status As String = reader("Status").ToString().ToLowerInvariant()
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
        Dim totalCount As Integer = 0

        Try
            Using conn As New OleDbConnection(Db.ConnectionString)
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
            Using conn As New OleDbConnection(Db.ConnectionString)
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
            dashboardCache.Clear()

            Using conn As New OleDbConnection(Db.ConnectionString)
                conn.Open()

                Dim query As String = "
SELECT [TransactionID], [CustomerName], [ContactNumber], [Status], [TransactionDate]
FROM [Transactions]
WHERE [Status] IN ('For Pickup', 'For Delivery')
ORDER BY [TransactionDate] ASC, [TransactionID] ASC;"

                Using cmd As New OleDbCommand(query, conn)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim txDate As Nullable(Of DateTime) = Nothing
                            If Not reader.IsDBNull(reader.GetOrdinal("TransactionDate")) Then
                                txDate = Convert.ToDateTime(reader("TransactionDate"))
                            End If

                            dashboardCache.Add(New TransactionItem With {
                            .TransactionID = Convert.ToInt32(reader("TransactionID")),
                            .CustomerName = reader("CustomerName").ToString(),
                            .ContactNumber = reader("ContactNumber").ToString(),
                            .Status = reader("Status").ToString(),
                            .TransactionDate = txDate
                        })
                        End While
                    End Using
                End Using
            End Using

            RenderDashboardRows()

        Catch ex As Exception
            MessageBox.Show("Error loading dashboard transactions: " & ex.Message)
        End Try

        dgvDashboardTransactions.ClearSelection()
        dgvDashboardTransactions.CurrentCell = Nothing
    End Sub


    Private Sub RenderDashboardRows()
        ' Suspend painting to prevent flicker during update
        dgvDashboardTransactions.SuspendLayout()

        Try
            notifyIconRects.Clear()
            completeIconRects.Clear()
            archiveIconRects.Clear()

            dgvDashboardTransactions.Rows.Clear()

            Dim q As String = If(gtbSearch IsNot Nothing, gtbSearch.Text.Trim().ToLower(), "")
            Dim sortSel As String = If(gcbSort IsNot Nothing AndAlso gcbSort.SelectedItem IsNot Nothing,
                                   gcbSort.SelectedItem.ToString(), "")

            ' Filter
            Dim filtered = dashboardCache.Where(Function(t)
                                                    If q = "" Then Return True
                                                    Return t.TransactionID.ToString().Contains(q) _
                                                    OrElse (t.CustomerName?.ToLower().Contains(q)) _
                                                    OrElse (t.ContactNumber?.ToLower().Contains(q)) _
                                                    OrElse (t.Status?.ToLower().Contains(q))
                                                End Function)

            ' Add rows with numbering + computed waiting time
            Dim rowNum As Integer = 1
            For Each t In filtered
                Dim waitingStr As String = ""
                If t.TransactionDate.HasValue Then
                    Dim span = DateTime.Now - t.TransactionDate.Value
                    If span.TotalMinutes < 1 Then
                        waitingStr = "<1m"
                    ElseIf span.TotalDays >= 1 Then
                        waitingStr = $"{CInt(Math.Floor(span.TotalDays))}d {span.Hours}h"
                    ElseIf span.TotalHours >= 1 Then
                        waitingStr = $"{CInt(Math.Floor(span.TotalHours))}h {span.Minutes}m"
                    Else
                        waitingStr = $"{CInt(Math.Floor(span.TotalMinutes))}m"
                    End If
                End If

                dgvDashboardTransactions.Rows.Add(
                rowNum,
                t.TransactionID.ToString(),
                t.CustomerName,
                t.ContactNumber,
                t.Status,
                waitingStr,
                Nothing
            )
                rowNum += 1
            Next

        Finally
            ' Resume painting
            dgvDashboardTransactions.ResumeLayout(True)
            dgvDashboardTransactions.ClearSelection()
            dgvDashboardTransactions.CurrentCell = Nothing
        End Try
    End Sub


    Private Sub InitSortCombo()
        gcbSort.Items.Clear()
        gcbSort.Items.AddRange(New Object() {
        "Date (Oldest First)",
        "Date (Newest First)",
        "ID (Oldest First)",
        "ID (Newest First)",
        "Customer (A-Z)",
        "Customer (Z-A)",
        "Status (For Pickup first)",
        "Status (For Delivery first)"
    })
        gcbSort.SelectedIndex = 0 ' default: Date oldest first
    End Sub


    Private Sub gtbSearch_TextChanged(sender As Object, e As EventArgs) Handles gtbSearch.TextChanged
        ApplyFilterAndSort()
    End Sub

    Private Sub gcbSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcbSort.SelectedIndexChanged
        ApplyFilterAndSort()
    End Sub

    Private Sub dgvDashboardTransactions_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDashboardTransactions.ColumnHeaderMouseClick
        ' keep headers inert (no built-in sort); just re-apply view
        ApplyFilterAndSort()
    End Sub


    Private Sub ApplyFilterAndSort()
        Dim q As String = If(gtbSearch IsNot Nothing, gtbSearch.Text.Trim().ToLower(), "")
        Dim sortSel As String = If(gcbSort IsNot Nothing AndAlso gcbSort.SelectedItem IsNot Nothing,
                               gcbSort.SelectedItem.ToString(), "")

        ' --- FILTER (case-insensitive contains) ---
        filteredView = dashboardCache.Where(Function(t)
                                                If q = "" Then Return True

                                                Dim cust = If(t.CustomerName, "")
                                                Dim phone = If(t.ContactNumber, "")
                                                Dim stat = If(t.Status, "")

                                                Return t.TransactionID.ToString().IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0 _
        OrElse cust.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0 _
        OrElse phone.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0 _
        OrElse stat.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0
                                            End Function).ToList()


        ' --- SORT ---
        Select Case sortSel
            Case "Date (Newest First)"
                filteredView = filteredView _
                .OrderByDescending(Function(t) If(t.TransactionDate, Date.MinValue)) _
                .ThenByDescending(Function(t) t.TransactionID).ToList()

            Case "ID (Oldest First)"
                filteredView = filteredView.OrderBy(Function(t) t.TransactionID).ToList()

            Case "ID (Newest First)"
                filteredView = filteredView.OrderByDescending(Function(t) t.TransactionID).ToList()

            Case "Customer (A-Z)"
                filteredView = filteredView.OrderBy(Function(t) t.CustomerName).ToList()

            Case "Customer (Z-A)"
                filteredView = filteredView.OrderByDescending(Function(t) t.CustomerName).ToList()

            Case "Status (For Pickup first)"
                filteredView = filteredView _
                .OrderBy(Function(t) If(String.Equals(t.Status, "For Pickup", StringComparison.OrdinalIgnoreCase), 0, 1)) _
                .ThenBy(Function(t) If(t.TransactionDate, Date.MinValue)) _
                .ThenBy(Function(t) t.TransactionID).ToList()

            Case "Status (For Delivery first)"
                filteredView = filteredView _
                .OrderBy(Function(t) If(String.Equals(t.Status, "For Delivery", StringComparison.OrdinalIgnoreCase), 0, 1)) _
                .ThenBy(Function(t) If(t.TransactionDate, Date.MinValue)) _
                .ThenBy(Function(t) t.TransactionID).ToList()

            Case Else ' "Date (Oldest First)" or blank
                filteredView = filteredView _
                .OrderBy(Function(t) If(t.TransactionDate, Date.MaxValue)) _
                .ThenBy(Function(t) t.TransactionID).ToList()
        End Select

        RenderRows()
    End Sub


    Private Sub RenderRows()
        dgvDashboardTransactions.SuspendLayout()
        Try
            notifyIconRects.Clear()
            completeIconRects.Clear()
            archiveIconRects.Clear()
            dgvDashboardTransactions.Rows.Clear()

            Dim rowNum As Integer = 1
            For Each t In filteredView
                Dim waitingStr As String = ""
                If t.TransactionDate.HasValue Then
                    Dim span = DateTime.Now - t.TransactionDate.Value
                    If span.TotalMinutes < 1 Then
                        waitingStr = "<1m"
                    ElseIf span.TotalDays >= 1 Then
                        waitingStr = $"{CInt(Math.Floor(span.TotalDays))}d {span.Hours}h"
                    ElseIf span.TotalHours >= 1 Then
                        waitingStr = $"{CInt(Math.Floor(span.TotalHours))}h {span.Minutes}m"
                    Else
                        waitingStr = $"{CInt(Math.Floor(span.TotalMinutes))}m"
                    End If
                End If

                dgvDashboardTransactions.Rows.Add(
                rowNum,                 ' NumberColumn (no header)
                t.TransactionID,        ' hidden TransactionID
                t.CustomerName,
                t.ContactNumber,
                t.Status,
                waitingStr,             ' Waiting = Now - TransactionDate
                Nothing                 ' actions (painted)
            )
                rowNum += 1
            Next
        Finally
            dgvDashboardTransactions.ResumeLayout(True)
            dgvDashboardTransactions.ClearSelection()
            dgvDashboardTransactions.CurrentCell = Nothing
        End Try
    End Sub


    Private Sub HandleCheckClick(id As Integer)
        Dim confirm = MessageBox.Show($"Mark transaction #{id} as Completed?",
                                  "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm <> DialogResult.Yes Then Exit Sub

        Try

            Using conn As New OleDbConnection(Db.ConnectionString)
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
            .DefaultCellStyle.Font = New Font("Poppins", 12, FontStyle.Regular) ' font size for rows
            .RowTemplate.Height = 45 ' increase row height
            .ColumnHeadersDefaultCellStyle.Font = New Font("Poppins", 14, FontStyle.Bold)
            .ReadOnly = True
            .Font = New Font("Poppins", 14, FontStyle.Regular)
            .ColumnHeadersHeight = 45
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

            ' ====== CRITICAL FIX: Suspend layout during setup ======
            .SuspendLayout()

            With .ColumnHeadersDefaultCellStyle
                .BackColor = Color.White
                .ForeColor = Color.Black
                .Font = New Font("Poppins", 14, FontStyle.Regular)
                .Alignment = DataGridViewContentAlignment.MiddleCenter
                .SelectionBackColor = Color.White
                .SelectionForeColor = Color.Black
            End With


            AddHandler .CellPainting, AddressOf dgvDashboardTransactions_CellPainting
            AddHandler .ColumnHeaderMouseClick, AddressOf dgvDashboardTransactions_ColumnHeaderMouseClick

            ' Number column
            .Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "NumberColumn",
            .HeaderText = "",
            .ReadOnly = True,
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
            .Width = 50
        })

            ' Hidden TransactionID
            .Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "TransactionID",
            .HeaderText = "ID",
            .Visible = False
        })

            .Columns.Add("CustomerName", "Customer")
            .Columns.Add("ContactNumber", "Contact")
            .Columns.Add("Status", "Status")
            .Columns.Add("WaitingTime", "Waiting")

            .RowTemplate.Resizable = DataGridViewTriState.False
            .RowTemplate.DefaultCellStyle.Font = New Font("Poppins", 12, FontStyle.Regular)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dim actionCol As New DataGridViewImageColumn() With {
            .Name = "btnActions",
            .HeaderText = "Actions",
            .ImageLayout = DataGridViewImageCellLayout.Normal,
            .Width = 78
        }
            .Columns.Add(actionCol)

            For Each col As DataGridViewColumn In .Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next
            dgvDashboardTransactions.RowHeadersVisible = False
            dgvDashboardTransactions.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dgvDashboardTransactions.EnableHeadersVisualStyles = False
            dgvDashboardTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgvDashboardTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' Disable row virtualization to prevent flicker/ghosting
            dgvDashboardTransactions.RowTemplate.Resizable = DataGridViewTriState.False
            dgvDashboardTransactions.VirtualMode = False

            ' ====== Resume layout ======
            .ResumeLayout(False)
            .PerformLayout()
        End With

        ' Enhanced double buffering
        EnableDoubleBuffering(dgvDashboardTransactions)

        ' ====== REMOVE the Scroll handler that calls Invalidate() ======
        ' This is likely causing the flickering!
        ' Comment out or remove this line:
        ' AddHandler dgvDashboardTransactions.Scroll, Sub(_s, _e) dgvDashboardTransactions.Invalidate()
    End Sub




    ' ====================== HANDLE BUTTON CLICK ======================

    Private Sub addOrderBtn_Click(sender As Object, e As EventArgs) Handles addOrderBtn.Click
        Dim optionsForm As New TransactionOption()
        optionsForm.StartPosition = FormStartPosition.CenterParent
        optionsForm.ShowDialog()
    End Sub

    Private Async Sub dgvDashboardTransactions_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDashboardTransactions.CellMouseClick
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub
        If e.ColumnIndex <> dgvDashboardTransactions.Columns("btnActions").Index Then Exit Sub

        Dim id As Integer = CInt(dgvDashboardTransactions.Rows(e.RowIndex).Cells("TransactionID").Value)
        Dim customerName As String = dgvDashboardTransactions.Rows(e.RowIndex).Cells("CustomerName").Value.ToString()
        Dim contactNumber As String = dgvDashboardTransactions.Rows(e.RowIndex).Cells("ContactNumber").Value.ToString()
        Dim status As String = dgvDashboardTransactions.Rows(e.RowIndex).Cells("Status").Value.ToString()

        ' Mouse location in DataGridView client coords
        Dim clickPos As Point = dgvDashboardTransactions.PointToClient(Control.MousePosition)

        ' Ensure rectangles exist for this row (they’re created in CellPainting)
        If Not notifyIconRects.ContainsKey(e.RowIndex) _
       OrElse Not completeIconRects.ContainsKey(e.RowIndex) _
       OrElse Not archiveIconRects.ContainsKey(e.RowIndex) Then Exit Sub

        If notifyIconRects(e.RowIndex).Contains(clickPos) Then
            ' --- Notify ---
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
                MessageBox.Show(If(success, "SMS sent successfully!", "Failed to send SMS."),
                            "Customer Notified",
                            MessageBoxButtons.OK,
                            If(success, MessageBoxIcon.Information, MessageBoxIcon.Warning))
            End If

        ElseIf completeIconRects(e.RowIndex).Contains(clickPos) Then
            ' --- Complete ---
            HandleCheckClick(id)

        ElseIf archiveIconRects(e.RowIndex).Contains(clickPos) Then
            ' --- Archive ---
            HandleArchiveClick(id)
        End If
    End Sub


    Private Sub HandleArchiveClick(id As Integer)
        Dim confirm = MessageBox.Show($"Archive transaction #{id}? It will be removed from the dashboard view.",
                                  "Confirm Archive", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm <> DialogResult.Yes Then Exit Sub

        Try
            Using conn As New OleDbConnection(Db.ConnectionString)
                conn.Open()
                Dim sql As String = "UPDATE Transactions SET Status = 'Archived' WHERE TransactionID = @id"
                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Transaction archived.", "Archived", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Update cache and re-render fast (no full DB hit needed)
            Dim idx = dashboardCache.FindIndex(Function(t) t.TransactionID = id)
            If idx >= 0 Then dashboardCache.RemoveAt(idx)
            RenderDashboardRows()

            ' If you also maintain counters that exclude Archived:
            LoadDashboardCounters()

        Catch ex As Exception
            MessageBox.Show("Error archiving transaction: " & ex.Message)
        End Try
    End Sub


    Private Sub dgvDashboardTransactions_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvDashboardTransactions.CellPainting
        If e.RowIndex < 0 Then Return
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvDashboardTransactions.Columns("btnActions").Index Then
            e.PaintBackground(e.CellBounds, True)
            If e.RowIndex < 0 Then Return

            ' Load once (static)
            Static notifyIcon As Image = Image.FromFile("C:\Users\Eisen\OneDrive\Documents\Assets\send-mail.png")
            Static completeIcon As Image = Image.FromFile("C:\Users\Eisen\OneDrive\Documents\Assets\yes.png")
            Static archiveIcon As Image = Image.FromFile("C:\Users\Eisen\OneDrive\Documents\Assets\folder.png")

            Dim iconSize As Integer = 30
            Dim spacing As Integer = 8
            Dim totalWidth As Integer = (iconSize * 3) + (spacing * 2)

            Dim startX As Integer = e.CellBounds.Left + (e.CellBounds.Width - totalWidth) \ 2
            Dim startY As Integer = e.CellBounds.Top + (e.CellBounds.Height - iconSize) \ 2

            Dim notifyRect As New Rectangle(startX, startY, iconSize, iconSize)
            Dim completeRect As New Rectangle(startX + iconSize + spacing, startY, iconSize, iconSize)
            Dim archiveRect As New Rectangle(startX + (iconSize + spacing) * 2, startY, iconSize, iconSize)

            e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            e.Graphics.DrawImage(notifyIcon, notifyRect)
            e.Graphics.DrawImage(completeIcon, completeRect)
            e.Graphics.DrawImage(archiveIcon, archiveRect)

            ' store rectangles for hit testing
            notifyIconRects(e.RowIndex) = notifyRect
            completeIconRects(e.RowIndex) = completeRect
            archiveIconRects(e.RowIndex) = archiveRect

            e.Handled = True
        End If
    End Sub

    ' === Change cursor when hovering over action icons ===
    Private Sub dgvDashboardTransactions_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDashboardTransactions.CellMouseMove
        ' Reset cursor if outside bounds
        If e.RowIndex < 0 OrElse e.ColumnIndex <> dgvDashboardTransactions.Columns("btnActions").Index Then
            dgvDashboardTransactions.Cursor = Cursors.Default
            Exit Sub
        End If

        ' Get mouse position relative to the DataGridView
        Dim mousePos As Point = dgvDashboardTransactions.PointToClient(Control.MousePosition)

        ' Make sure we have valid icon rectangles for this row
        If notifyIconRects.ContainsKey(e.RowIndex) AndAlso
       completeIconRects.ContainsKey(e.RowIndex) AndAlso
       archiveIconRects.ContainsKey(e.RowIndex) Then

            ' Check if mouse is over any of the icons
            If notifyIconRects(e.RowIndex).Contains(mousePos) OrElse
           completeIconRects(e.RowIndex).Contains(mousePos) OrElse
           archiveIconRects(e.RowIndex).Contains(mousePos) Then

                dgvDashboardTransactions.Cursor = Cursors.Hand  ' 👈 Hand pointer to show interactivity
            Else
                dgvDashboardTransactions.Cursor = Cursors.Default
            End If
        Else
            dgvDashboardTransactions.Cursor = Cursors.Default
        End If
    End Sub

    ' === Reset cursor when leaving the cell ===
    Private Sub dgvDashboardTransactions_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDashboardTransactions.CellMouseLeave
        dgvDashboardTransactions.Cursor = Cursors.Default
    End Sub

    ' ====================== SMS FUNCTION ======================
    Private Async Function SendSmsGsm(phoneNumber As String, message As String) As Task(Of Boolean)
        Dim username As String = "yzekeil"
        Dim password As String = "laundry"
        Dim ip As String = "192.168.213.167"
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



            ' ===== PREVENT HEADER CLICKS FROM DOING ANYTHING =====
            ' ColumnHeaderMouseClick uses DataGridViewCellMouseEventArgs (no Handled property),
            ' so just clear selection or reset focus when a header is clicked.
            AddHandler .ColumnHeaderMouseClick, Sub(sender, ev)
                                                    ' Do nothing useful here so header clicks have no effect.
                                                    ' Optionally clear any selection or reselect nothing:
                                                    .ClearSelection()
                                                End Sub

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
            ' ===== DISABLE SORTING =====
            For Each col As DataGridViewColumn In .Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            AddHandler dgvDashboardTransactions.SelectionChanged, Sub(sender, e)
                                                                      dgvDashboardTransactions.ClearSelection()
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


        Using conn As New OleDbConnection(Db.ConnectionString)
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

    ' Disable selection and highlighting for any Guna2DataGridView
    Private Sub DisableGuna2Selection(dgv As Guna.UI2.WinForms.Guna2DataGridView)
        ' Clear selection whenever it changes
        AddHandler dgv.SelectionChanged, Sub(sender, e)
                                             dgv.ClearSelection()
                                         End Sub

        ' Prevent highlight when clicking cells
        AddHandler dgv.CellMouseDown, Sub(sender, e)
                                          dgv.ClearSelection()
                                      End Sub

        ' Prevent arrow-key or keyboard focus selection
        AddHandler dgv.KeyDown, Sub(sender, e)
                                    dgv.ClearSelection()
                                    e.Handled = True
                                End Sub

        ' Apply visual settings so no highlight shows
        dgv.DefaultCellStyle.SelectionBackColor = dgv.DefaultCellStyle.BackColor
        dgv.DefaultCellStyle.SelectionForeColor = dgv.DefaultCellStyle.ForeColor
        dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = dgv.AlternatingRowsDefaultCellStyle.BackColor
        dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = dgv.AlternatingRowsDefaultCellStyle.ForeColor

        ' Optional: disable the blue focus outline when clicked
        dgv.EnableHeadersVisualStyles = False
        dgv.CurrentCell = Nothing
    End Sub

    Private Sub EnableDoubleBuffering(dgv As DataGridView)
        ' Enable all double buffering properties
        Dim dgvType As Type = dgv.GetType()
        Dim pi As Reflection.PropertyInfo = dgvType.GetProperty("DoubleBuffered",
        Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
        pi.SetValue(dgv, True, Nothing)

        ' Additional optimization flags
        dgv.GetType().InvokeMember("DoubleBuffered",
        Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance Or Reflection.BindingFlags.SetProperty,
        Nothing, dgv, New Object() {True})
    End Sub
End Class
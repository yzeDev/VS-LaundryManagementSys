Imports System.Data.OleDb
Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class TransactionControl
    Private selectedRow As TransactionRow = Nothing
    ' Shared column widths for both header and row alignment
    Private ReadOnly columnWidths As Integer() = {60, 200, 120, 100, 120, 120, 100, 80}
    Private header As TransactionRow

    Private Sub EnableDoubleBuffering(ctrl As Control)
        Try
            Dim prop = ctrl.GetType().GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
            If prop IsNot Nothing Then
                prop.SetValue(ctrl, True, Nothing)
            End If
        Catch
            ' ignore if reflection fails
        End Try
    End Sub

    Private Sub flpTransactions_SizeChanged(sender As Object, e As EventArgs)
        ' Calculate the usable width inside the FlowLayoutPanel
        Dim usableWidth As Integer = flpTransactions.DisplayRectangle.Width

        ' Subtract scrollbar width if it’s visible
        If flpTransactions.VerticalScroll.Visible Then
            usableWidth -= SystemInformation.VerticalScrollBarWidth
        End If

        ' Subtract horizontal padding to avoid overflow
        usableWidth -= flpTransactions.Padding.Horizontal

        ' Apply width to each TransactionRow control
        For Each ctrl As Control In flpTransactions.Controls
            ctrl.Width = usableWidth
        Next
    End Sub



    ' -------------------------
    ' LOAD
    ' -------------------------
    Private Sub TransactionsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' --- FIX START ---
        Me.Scale(New SizeF(1.0F, 1.0F))
        Me.Dock = DockStyle.Fill
        ' --- FIX END ---
        toggleDate.Checked = True

        flpTransactions.FlowDirection = FlowDirection.TopDown
        flpTransactions.WrapContents = False
        flpTransactions.AutoScroll = True
        flpTransactions.Dock = DockStyle.Fill
        flpTransactions.Padding = New Padding(0)
        flpTransactions.Margin = New Padding(0)
        EnableDoubleBuffering(flpTransactions)

        ' ✅ Ensure all filter handlers are connected to actual control names
        AddHandler cmbStatus.SelectedIndexChanged, AddressOf ApplyFilters
        AddHandler tbSearch.TextChanged, AddressOf ApplyFilters
        AddHandler dtpDateFilter.ValueChanged, AddressOf ApplyFilters
        AddHandler toggleDate.CheckedChanged, AddressOf ApplyFilters
        AddHandler flpTransactions.SizeChanged, AddressOf flpTransactions_SizeChanged  ' ✅ RESTORED

        LoadTransactions()
    End Sub

    Private Sub AddHeaderRow()
        ' Prevent multiple headers
        For Each ctrl As Control In flpTransactions.Controls
            If TypeOf ctrl Is TransactionRow AndAlso DirectCast(ctrl, TransactionRow).IsHeader Then Return
        Next

        ' Create header instance first
        Dim headerRow As New TransactionRow()
        headerRow.IsHeader = True  ' mark as header before initializing

        ' Assign header text (column names)
        headerRow.lblTransactionID.Text = "ORDER ID"
        headerRow.lblCustomer.Text = "CUSTOMER"
        headerRow.lblServiceType.Text = "SERVICE"
        headerRow.lblStatus.Text = "STATUS"
        headerRow.lblMachine.Text = "MACHINE"
        headerRow.lblDate.Text = "DATE"
        headerRow.lblTotal.Text = "TOTAL"

        ' Disable selection highlight
        headerRow.SetSelected(False)

        ' Add header to top of list
        flpTransactions.Controls.Add(headerRow)
        flpTransactions.Controls.SetChildIndex(headerRow, 0)

        ' ✅ FIX: assign the field reference so header resizing works
        header = headerRow

        ' Force header initialization AFTER being added
        Dim method = headerRow.GetType().GetMethod("InitializeRow", Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
        If method IsNot Nothing Then method.Invoke(headerRow, Nothing)
    End Sub


    ' -------------------------
    ' ROW CLICK HANDLER
    ' -------------------------
    Private Sub TransactionRow_RowClicked(sender As TransactionRow)
        Dim clickedRow As TransactionRow = sender

        ' Unselect previous row
        If selectedRow IsNot Nothing AndAlso selectedRow IsNot clickedRow Then
            selectedRow.SetSelected(False)
        End If

        ' Toggle selection
        If selectedRow Is clickedRow Then
            clickedRow.SetSelected(False)
            selectedRow = Nothing
            'btnEdit.Enabled = False
            'btnRemove.Enabled = False
        Else
            clickedRow.SetSelected(True)
            selectedRow = clickedRow
            'btnEdit.Enabled = True
            'btnRemove.Enabled = True
        End If
    End Sub

    ' -------------------------
    ' LOAD TRANSACTIONS
    ' -------------------------
    Private Sub LoadTransactions()
        Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"

        flpTransactions.SuspendLayout()
        flpTransactions.Visible = False

        Try
            flpTransactions.Controls.Clear()
            selectedRow = Nothing

            ' Ensure toggle default (do this before filtering runs)
            toggleDate.Checked = True
            tbSearch.Text = "" ' ensure search empty
            If cmbStatus.Items.Count > 0 Then cmbStatus.SelectedIndex = 0

            AddHeaderRow()

            Dim newRows As New List(Of TransactionRow)()
            Dim statuses As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)

            Using conn As New OleDbConnection(connStr)
                conn.Open()
                'MessageBox.Show("Connected to: " & conn.DataSource, "Database Path")

                Dim sql As String = "SELECT TransactionID, CustomerName, ServiceType, Status, MachineUsed, TransactionDate, TotalPayment FROM Transactions"
                Using cmd As New OleDbCommand(sql, conn)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        Dim rowCount As Integer = 0

                        While reader.Read()
                            rowCount += 1

                            Dim tId = If(IsDBNull(reader("TransactionID")), 0, Convert.ToInt32(reader("TransactionID")))
                            Dim cust = If(IsDBNull(reader("CustomerName")), String.Empty, reader("CustomerName").ToString())
                            Dim svc = If(IsDBNull(reader("ServiceType")), String.Empty, reader("ServiceType").ToString())
                            Dim st = If(IsDBNull(reader("Status")), String.Empty, reader("Status").ToString())
                            Dim machine = If(IsDBNull(reader("MachineUsed")), String.Empty, reader("MachineUsed").ToString())
                            Dim tDate = If(IsDBNull(reader("TransactionDate")), Date.MinValue, Convert.ToDateTime(reader("TransactionDate")))
                            Dim total = If(IsDBNull(reader("TotalPayment")), 0D, Convert.ToDecimal(reader("TotalPayment")))

                            Dim row As New TransactionRow()
                            row.SuspendLayout()
                            row.SetData(tId, cust, svc, st, machine, tDate, total)
                            row.BackColor = Color.White

                            ' Force the row internal init (some logic lives in InitializeRow)
                            Dim initMethod = row.GetType().GetMethod("InitializeRow", Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
                            If initMethod IsNot Nothing Then initMethod.Invoke(row, Nothing)

                            row.ResumeLayout(False)

                            ' Attach handlers
                            AddHandler row.RowClicked, AddressOf TransactionRow_RowClicked
                            AddHandler row.RowDoubleClicked, AddressOf TransactionRow_RowDoubleClicked
                            AddHandler row.ViewButtonClicked, AddressOf TransactionRow_ViewButtonClicked

                            newRows.Add(row)
                            row.Enabled = True

                            If Not String.IsNullOrWhiteSpace(st) Then
                                statuses.Add(st)
                            End If
                        End While

                        'MessageBox.Show("Rows fetched: " & rowCount, "Debug Info")
                    End Using
                End Using
            End Using

            If newRows.Count > 0 Then
                flpTransactions.Controls.AddRange(newRows.ToArray())
                ' Ensure layout values are set immediately
                flpTransactions.PerformLayout()
                flpTransactions.Refresh()
            End If

            'MessageBox.Show("Rows added to FLP: " & newRows.Count, "Debug Info")

            ResizeHeader(Nothing, EventArgs.Empty)
            PopulateStatusFilter(statuses)

            ' Now run filters once (with debugging)
            ApplyFilters()

        Catch ex As Exception
            MessageBox.Show("Error loading transactions: " & ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            flpTransactions.Visible = True
            flpTransactions.ResumeLayout()
            flpTransactions.PerformLayout()

            flpTransactions.AutoScroll = False
            flpTransactions.AutoScroll = True
        End Try

        ' Keep header at index 0 (it should already be present)
        If header IsNot Nothing AndAlso Not flpTransactions.Controls.Contains(header) Then
            flpTransactions.Controls.Add(header)
            flpTransactions.Controls.SetChildIndex(header, 0)
        End If
    End Sub



    ' -------------------------
    ' DOUBLE CLICK HANDLER
    ' -------------------------
    Private Sub TransactionRow_RowDoubleClicked(sender As TransactionRow)
        Dim viewForm As New TransactionForm()
        viewForm.TransactionId = sender.TransactionID
        viewForm.Mode = "View"
        viewForm.ShowDialog()
    End Sub

    Private Sub ApplyFilters()
        Dim searchTerm As String = tbSearch.Text.Trim().ToLower()
        Dim statusSelected As String = If(cmbStatus.SelectedItem IsNot Nothing, cmbStatus.SelectedItem.ToString(), "All")
        Dim dateFiltering As Boolean = Not toggleDate.Checked
        Dim selectedDate As Date = Date.MinValue
        If dateFiltering Then selectedDate = dtpDateFilter.Value.Date

        Dim debugLines As New List(Of String)

        For Each ctrl As Control In flpTransactions.Controls
            If TypeOf ctrl Is TransactionRow Then
                Dim row As TransactionRow = DirectCast(ctrl, TransactionRow)

                ' Always keep header visible
                If row.IsHeader Then
                    row.Visible = True
                    debugLines.Add($"Header -> Visible=True")
                    Continue For
                End If

                Dim visible As Boolean = True
                debugLines.Add($"RowID={row.TransactionID} StartVisible={visible}")

                ' Status Filter
                If statusSelected IsNot Nothing AndAlso statusSelected <> "All" Then
                    If Not row.lblStatus.Text.Equals(statusSelected, StringComparison.OrdinalIgnoreCase) Then
                        visible = False
                        debugLines.Add($" -> Status filter failed (row='{row.lblStatus.Text}', filter='{statusSelected}')")
                    Else
                        debugLines.Add($" -> Status matched ('{row.lblStatus.Text}')")
                    End If
                Else
                    debugLines.Add(" -> Status filter skipped")
                End If

                ' Search Filter
                If visible AndAlso searchTerm <> "" Then
                    Dim match As Boolean =
                    row.lblCustomer.Text.ToLower().Contains(searchTerm) _
                    OrElse row.lblServiceType.Text.ToLower().Contains(searchTerm) _
                    OrElse row.lblMachine.Text.ToLower().Contains(searchTerm)
                    If Not match Then
                        visible = False
                        debugLines.Add($" -> Search failed (term='{searchTerm}')")
                    Else
                        debugLines.Add($" -> Search matched")
                    End If
                Else
                    debugLines.Add(" -> Search skipped/empty")
                End If

                ' Date Filter
                If visible AndAlso dateFiltering Then
                    Dim rowDate As Date
                    If Date.TryParse(row.lblDate.Text, rowDate) Then
                        If rowDate.Date <> selectedDate Then
                            visible = False
                            debugLines.Add($" -> Date filter failed (row='{rowDate.Date}', selected='{selectedDate}')")
                        Else
                            debugLines.Add($" -> Date matched ('{rowDate.Date}')")
                        End If
                    Else
                        debugLines.Add($" -> Date parse failed for '{row.lblDate.Text}'")
                        ' keep visible as-is (don't hide just because parse failed)
                    End If
                Else
                    debugLines.Add(" -> Date filter skipped")
                End If

                row.Visible = visible
                debugLines.Add($" -> FinalVisible={visible}")
            End If
        Next

        ' Show debug lines (collapse into single message)
        Dim debugMsg As String = String.Join(vbCrLf, debugLines)
        ' Very long debug message can be heavy; show only first 5000 chars to avoid dialog overflow
        If debugMsg.Length > 5000 Then debugMsg = debugMsg.Substring(0, 5000) & vbCrLf & "...(truncated)"
        'MessageBox.Show(debugMsg, "ApplyFilters Debug")

        ' Force a layout refresh after visibility changes
        flpTransactions.PerformLayout()
        flpTransactions.Refresh()
    End Sub



    ' -------------------------
    ' ✅ VIEW BUTTON HANDLER
    ' -------------------------
    Private Sub TransactionRow_ViewButtonClicked(sender As TransactionRow)
        ' Select the row for visual feedback (optional)
        TransactionRow_RowClicked(sender)

        ' Open view form
        Dim viewForm As New TransactionForm()
        viewForm.TransactionId = sender.TransactionID
        viewForm.Mode = "View"
        viewForm.ShowDialog()
    End Sub

    ' -------------------------
    ' FILTERS
    ' -------------------------
    Private Sub PopulateStatusFilter(collectedStatuses As IEnumerable(Of String))
        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("All")

        If collectedStatuses IsNot Nothing Then
            For Each s In collectedStatuses
                cmbStatus.Items.Add(s)
            Next
        End If

        cmbStatus.SelectedIndex = 0
    End Sub



    ' -------------------------
    ' BUTTONS
    ' -------------------------
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim popup As New TransactionOption()
        popup.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs)
        If selectedRow Is Nothing Then
            MessageBox.Show("Please select a transaction to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim form As New TransactionForm
        form.TransactionId = selectedRow.TransactionID
        form.Mode = "Edit"

        If form.ShowDialog = DialogResult.OK Then
            LoadTransactions()
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs)
        If selectedRow Is Nothing Then
            MessageBox.Show("Please select a transaction to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim transactionId = selectedRow.TransactionID
        Dim confirm = MessageBox.Show($"Are you sure you want to delete transaction #{transactionId}?",
                                  "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If confirm = DialogResult.Yes Then
            Try
                Dim connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"
                Using conn As New OleDbConnection(connStr)
                    conn.Open()
                    Dim sql = "DELETE FROM Transactions WHERE TransactionID = @id"
                    Using cmd As New OleDbCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@id", transactionId)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Transaction deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                flpTransactions.SuspendLayout()
                LoadTransactions()
                flpTransactions.ResumeLayout()
                flpTransactions.PerformLayout()
                flpTransactions.AutoScroll = False
                flpTransactions.AutoScroll = True

                'btnEdit.Enabled = False

                'btnRemove.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Error deleting transaction: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' -------------------------
    ' HEADER (Improved Alignment + Centered Columns)
    ' -------------------------
    Private ReadOnly columnSpacings As Integer() = {60, 10, 10, 10, 10, 10, 20, 5}

    Private Sub ResizeHeader(sender As Object, e As EventArgs)
        If flpTransactions Is Nothing OrElse header Is Nothing OrElse columnWidths Is Nothing Then Exit Sub
        If header.Controls.Count = 0 Then Exit Sub

        ' Full available width inside the flowpanel for content.
        ' Subtract a little margin and the vertical scrollbar width so things align exactly.
        Dim availWidth As Integer = Math.Max(0, flpTransactions.ClientSize.Width - 20 - SystemInformation.VerticalScrollBarWidth)
        header.Width = availWidth + 20 ' keep header width consistent (optional)

        ' Total logical width (columns + spacings)
        Dim logicalTotal As Integer = columnWidths.Sum() + columnSpacings.Sum()
        If logicalTotal = 0 Then Exit Sub

        ' Scale factor from logical units to available pixels
        Dim scale As Double = availWidth / CDbl(logicalTotal)

        ' Build arrays of scaled widths and scaled spacings (rounded to integers)
        Dim scaledWidths(columnWidths.Length - 1) As Integer
        For i As Integer = 0 To columnWidths.Length - 1
            scaledWidths(i) = CInt(Math.Max(1, Math.Round(columnWidths(i) * scale)))
        Next

        Dim scaledSpacings(columnSpacings.Length - 1) As Integer
        For i As Integer = 0 To columnSpacings.Length - 1
            scaledSpacings(i) = CInt(Math.Round(columnSpacings(i) * scale))
        Next

        ' Fix: if rounding left some extra pixels, distribute them to the last column
        Dim used As Integer = scaledWidths.Sum() + scaledSpacings.Sum()
        Dim diff As Integer = availWidth - used
        If diff <> 0 AndAlso scaledWidths.Length > 0 Then
            scaledWidths(scaledWidths.Length - 1) += diff
        End If

        ' Position header labels using the scaled widths/spacings
        Dim x As Integer = 10
        Dim labelIndex As Integer = 0
        For Each ctrl As Control In header.Controls
            Dim lbl As Label = TryCast(ctrl, Label)
            If lbl IsNot Nothing AndAlso labelIndex < scaledWidths.Length Then
                lbl.Left = x
                lbl.Width = scaledWidths(labelIndex)
                x += lbl.Width + CInt(If(labelIndex < scaledSpacings.Length, scaledSpacings(labelIndex), 10))
                labelIndex += 1
                lbl.AutoEllipsis = True
                lbl.Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right
            End If
        Next

        ' Pass the scaled widths & spacings to each TransactionRow so they compute positions the same way
        For Each ctrl As Control In flpTransactions.Controls
            If TypeOf ctrl Is TransactionRow Then
                DirectCast(ctrl, TransactionRow).AdjustColumnWidthsScaled(scaledWidths, scaledSpacings)
            End If
        Next
    End Sub


    Private Sub flpTransactions_Scroll(sender As Object, e As ScrollEventArgs) Handles flpTransactions.Scroll
        For Each ctrl As Control In flpTransactions.Controls
            If TypeOf ctrl Is TransactionRow AndAlso DirectCast(ctrl, TransactionRow).IsHeader Then
                ctrl.Top = flpTransactions.VerticalScroll.Value ' keep header anchored
                Exit For
            End If
        Next
    End Sub

End Class

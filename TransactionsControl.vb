Imports System.Data.OleDb
Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class TransactionsControl
    Private selectedRow As TransactionRow = Nothing
    ' Shared column widths for both header and row alignment
    Private ReadOnly columnWidths As Integer() = {60, 150, 120, 100, 120, 120, 100, 80}
    Private header As Panel

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
        For Each ctrl As Control In flpTransactions.Controls
            ctrl.Width = flpTransactions.ClientSize.Width - flpTransactions.Padding.Horizontal - SystemInformation.VerticalScrollBarWidth
        Next
    End Sub

    ' -------------------------
    ' LOAD
    ' -------------------------
    Private Sub TransactionsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' --- FIX START ---
        Me.AutoScaleMode = AutoScaleMode.None
        Me.Scale(New SizeF(1.0F, 1.0F))
        Me.Dock = DockStyle.Fill
        ' --- FIX END ---

        flpTransactions.FlowDirection = FlowDirection.TopDown
        flpTransactions.WrapContents = False
        flpTransactions.AutoScroll = True
        flpTransactions.Dock = DockStyle.Fill
        EnableDoubleBuffering(flpTransactions)

        AddHandler cmbStatus.SelectedIndexChanged, AddressOf ApplyFilters
        AddHandler tbSearch.TextChanged, AddressOf ApplyFilters
        AddHandler dtpDateFilter1.ValueChanged, AddressOf ApplyFilters
        AddHandler chkAllDates.CheckedChanged, AddressOf ApplyFilters
        AddHandler flpTransactions.SizeChanged, AddressOf flpTransactions_SizeChanged

        LoadTransactions()
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
            btnEdit.Enabled = False
            btnRemove.Enabled = False
        Else
            clickedRow.SetSelected(True)
            selectedRow = clickedRow
            btnEdit.Enabled = True
            btnRemove.Enabled = True
        End If
    End Sub

    ' -------------------------
    ' LOAD TRANSACTIONS
    ' -------------------------
    Private Sub LoadTransactions()
        Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\source\repos\LaundryManagementSys\LaundryDatabase.accdb;"

        flpTransactions.SuspendLayout()
        flpTransactions.Visible = False

        Try
            flpTransactions.Controls.Clear()
            btnEdit.Enabled = False
            btnRemove.Enabled = False
            selectedRow = Nothing

            AddHeaderRow()

            Dim newRows As New List(Of TransactionRow)()
            Dim statuses As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)

            Using conn As New OleDbConnection(connStr)
                conn.Open()
                Dim sql As String = "SELECT TransactionID, CustomerName, ServiceType, Status, MachineUsed, TransactionDate, TotalPayment FROM Transactions"
                Using cmd As New OleDbCommand(sql, conn)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim tId = If(IsDBNull(reader("TransactionID")), 0, Convert.ToInt32(reader("TransactionID")))
                            Dim cust = If(IsDBNull(reader("CustomerName")), String.Empty, reader("CustomerName").ToString())
                            Dim svc = If(IsDBNull(reader("ServiceType")), String.Empty, reader("ServiceType").ToString())
                            Dim st = If(IsDBNull(reader("Status")), String.Empty, reader("Status").ToString())
                            Dim machine = If(IsDBNull(reader("MachineUsed")), String.Empty, reader("MachineUsed").ToString())
                            Dim tDate = If(IsDBNull(reader("TransactionDate")), Date.MinValue, Convert.ToDateTime(reader("TransactionDate")))
                            Dim total = If(IsDBNull(reader("TotalPayment")), 0D, Convert.ToDecimal(reader("TotalPayment")))

                            ' Create row
                            Dim row As New TransactionRow()
                            row.SuspendLayout()
                            row.SetData(tId, cust, svc, st, machine, tDate, total)
                            row.BackColor = Color.White
                            row.ResumeLayout(False)

                            ' ✅ Attach handlers
                            AddHandler row.RowClicked, AddressOf TransactionRow_RowClicked
                            AddHandler row.RowDoubleClicked, AddressOf TransactionRow_RowDoubleClicked
                            AddHandler row.ViewButtonClicked, AddressOf TransactionRow_ViewButtonClicked ' ✅ View button event

                            newRows.Add(row)
                            row.Enabled = True

                            If Not String.IsNullOrWhiteSpace(st) Then
                                statuses.Add(st)
                            End If
                        End While
                    End Using
                End Using
            End Using

            ' Add all rows
            If newRows.Count > 0 Then
                flpTransactions.Controls.AddRange(newRows.ToArray())
            End If

            ResizeHeader(Nothing, EventArgs.Empty)
            PopulateStatusFilter(statuses)

        Catch ex As Exception
            MessageBox.Show("Error loading transactions: " & ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            flpTransactions.Visible = True
            flpTransactions.ResumeLayout()
            flpTransactions.PerformLayout()

            ' ✅ Fix layout gaps
            flpTransactions.AutoScroll = False
            flpTransactions.AutoScroll = True
        End Try

        ' ✅ Ensure header always visible
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

    Private Sub ApplyFilters()
        For Each ctrl As Control In flpTransactions.Controls
            If TypeOf ctrl Is TransactionRow Then
                Dim row As TransactionRow = DirectCast(ctrl, TransactionRow)
                Dim visible As Boolean = True

                ' Status Filter
                If cmbStatus.SelectedItem IsNot Nothing AndAlso cmbStatus.SelectedItem.ToString() <> "All" Then
                    If Not row.lblStatus.Text.Equals(cmbStatus.SelectedItem.ToString(), StringComparison.OrdinalIgnoreCase) Then
                        visible = False
                    End If
                End If

                ' Search Filter
                Dim searchTerm As String = tbSearch.Text.Trim().ToLower()
                If visible AndAlso searchTerm <> "" Then
                    Dim match As Boolean =
                        row.lblCustomer.Text.ToLower().Contains(searchTerm) _
                        OrElse row.lblServiceType.Text.ToLower().Contains(searchTerm) _
                        OrElse row.lblMachine.Text.ToLower().Contains(searchTerm)
                    visible = match
                End If

                ' Date Filter
                If visible AndAlso Not chkAllDates.Checked Then
                    Dim selectedDate As Date = dtpDateFilter1.Value.Date
                    Dim rowDate As Date = Date.Parse(row.lblDate.Text).Date
                    visible = (rowDate = selectedDate)
                End If

                row.Visible = visible
            End If
        Next
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

                btnEdit.Enabled = False
                btnRemove.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Error deleting transaction: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' -------------------------
    ' HEADER (Improved Alignment + Centered Columns)
    ' -------------------------
    Private ReadOnly columnSpacings As Integer() = {60, 10, 10, 10, 10, 10, 20, 5}

    Private Sub AddHeaderRow()
        ' Prevent multiple headers
        For Each ctrl As Control In flpTransactions.Controls
            If TypeOf ctrl Is TransactionRow AndAlso DirectCast(ctrl, TransactionRow).IsHeader Then Return
        Next

        ' Create header instance first
        Dim headerRow As New TransactionRow()
        headerRow.IsHeader = True  ' mark as header before initializing

        ' Assign header text (column names)
        headerRow.lblTransactionID.Text = "ID"
        headerRow.lblCustomer.Text = "Customer"
        headerRow.lblServiceType.Text = "Service"
        headerRow.lblStatus.Text = "Status"
        headerRow.lblMachine.Text = "Machine"
        headerRow.lblDate.Text = "Date"
        headerRow.lblTotal.Text = "Total"

        ' Disable selection highlight
        headerRow.SetSelected(False)

        ' Add header to top of list
        flpTransactions.Controls.Add(headerRow)
        flpTransactions.Controls.SetChildIndex(headerRow, 0)

        ' Force header initialization AFTER being added
        ' (ensures the internal InitializeRow runs and replaces the button with "Action")
        Dim method = headerRow.GetType().GetMethod("InitializeRow", Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
        If method IsNot Nothing Then method.Invoke(headerRow, Nothing)
    End Sub



    Private Sub ResizeHeader(sender As Object, e As EventArgs)
        If flpTransactions Is Nothing OrElse header Is Nothing OrElse columnWidths Is Nothing Then Exit Sub
        If header.Controls.Count = 0 Then Exit Sub

        header.Width = flpTransactions.ClientSize.Width

        Dim totalWidth As Integer = columnWidths.Sum() + columnSpacings.Sum()
        If totalWidth = 0 Then Exit Sub

        Dim scale As Double = (header.Width - 20) / totalWidth
        Dim x As Integer = 10

        For i As Integer = 0 To header.Controls.Count - 1
            Dim lbl As Label = TryCast(header.Controls(i), Label)
            If lbl IsNot Nothing AndAlso i < columnWidths.Length Then
                lbl.Width = CInt(columnWidths(i) * scale)
                lbl.Left = x
                x += lbl.Width + CInt(If(i < columnSpacings.Length, columnSpacings(i) * scale, 10))
            End If
        Next

        ' ✅ Sync TransactionRows for perfect alignment
        For Each ctrl As Control In flpTransactions.Controls
            If TypeOf ctrl Is TransactionRow Then
                DirectCast(ctrl, TransactionRow).AdjustColumnWidths(columnWidths)
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

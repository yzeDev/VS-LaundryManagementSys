Imports System.Data.OleDb
Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class TransactionControl
    Private selectedRow As TransactionRow = Nothing
    Private ReadOnly columnWidths As Integer() = {60, 200, 120, 100, 120, 120, 100, 80}
    Private header As TransactionRow
    Private Shared ReadOnly initMethodInfo As Reflection.MethodInfo =
        GetType(TransactionRow).GetMethod("InitializeRow", Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)

    ' -------------------------
    ' PERFORMANCE HELPERS
    ' -------------------------
    Private Sub EnableDoubleBuffering(ctrl As Control)
        Try
            Dim prop = GetType(Control).GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
            If prop IsNot Nothing Then prop.SetValue(ctrl, True, Nothing)
        Catch
        End Try
    End Sub

    Private Sub AdjustAllWidths()
        If flpTransactions Is Nothing Then Return
        Dim baseWidth As Integer = flpTransactions.ClientSize.Width
        Dim vscrollVisible As Boolean = flpTransactions.DisplayRectangle.Height > flpTransactions.ClientSize.Height
        Dim extra As Integer = If(vscrollVisible, SystemInformation.VerticalScrollBarWidth, 0)
        Dim usableWidth As Integer = Math.Max(0, baseWidth + extra - flpTransactions.Padding.Horizontal - 2)

        For Each ctrl As Control In flpTransactions.Controls
            ctrl.Width = usableWidth
        Next

        ResizeHeader(Nothing, EventArgs.Empty)
    End Sub

    ' -------------------------
    ' LOAD
    ' -------------------------
    Private Sub TransactionsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flpTransactions.Parent = flpContainerPanel
        flpTransactions.Dock = DockStyle.Fill
        flpTransactions.VerticalScroll.Visible = True
        flpTransactions.HorizontalScroll.Visible = False
        toggleDate.Checked = True

        flpTransactions.FlowDirection = FlowDirection.TopDown
        flpTransactions.WrapContents = False
        flpTransactions.AutoScroll = True
        flpTransactions.Padding = New Padding(0)
        flpTransactions.Margin = New Padding(0)
        EnableDoubleBuffering(flpTransactions)

        AddHandler cmbStatus.SelectedIndexChanged, AddressOf ApplyFilters
        AddHandler tbSearch.TextChanged, AddressOf ApplyFilters
        AddHandler dtpDateFilter.ValueChanged, AddressOf ApplyFilters
        AddHandler toggleDate.CheckedChanged, AddressOf ApplyFilters
        AddHandler flpTransactions.SizeChanged, AddressOf flpTransactions_SizeChanged

        LoadTransactions()
    End Sub

    Private Sub flpTransactions_SizeChanged(sender As Object, e As EventArgs)
        AdjustAllWidths()
    End Sub

    Private Sub AddHeaderRow()
        If header IsNot Nothing AndAlso flpTransactions.Controls.Contains(header) Then Return

        header = New TransactionRow With {.IsHeader = True}
        header.lblTransactionID.Text = "ORDER ID"
        header.lblCustomer.Text = "CUSTOMER"
        header.lblServiceType.Text = "SERVICE"
        header.lblStatus.Text = "STATUS"
        header.lblMachine.Text = "MACHINE"
        header.lblDate.Text = "DATE"
        header.lblTotal.Text = "TOTAL"
        header.SetSelected(False)

        flpTransactions.Controls.Add(header)
        flpTransactions.Controls.SetChildIndex(header, 0)
        initMethodInfo?.Invoke(header, Nothing)
    End Sub

    ' -------------------------
    ' ROW CLICK HANDLER
    ' -------------------------
    Private Sub TransactionRow_RowClicked(sender As TransactionRow)
        Dim clickedRow As TransactionRow = sender
        If selectedRow IsNot Nothing AndAlso selectedRow IsNot clickedRow Then selectedRow.SetSelected(False)

        If selectedRow Is clickedRow Then
            clickedRow.SetSelected(False)
            selectedRow = Nothing
        Else
            clickedRow.SetSelected(True)
            selectedRow = clickedRow
        End If
    End Sub

    ' -------------------------
    ' LOAD TRANSACTIONS (OPTIMIZED)
    ' -------------------------
    Private Sub LoadTransactions()
        Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"
        flpTransactions.SuspendLayout()
        flpTransactions.Visible = False
        Try
            flpTransactions.Controls.Clear()
            selectedRow = Nothing
            toggleDate.Checked = True
            tbSearch.Text = ""
            If cmbStatus.Items.Count > 0 Then cmbStatus.SelectedIndex = 0
            AddHeaderRow()

            Dim newRows As New List(Of TransactionRow)(256)
            Dim statuses As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)

            Using conn As New OleDbConnection(connStr)
                conn.Open()
                Using cmd As New OleDbCommand("SELECT TransactionID, CustomerName, ServiceType, Status, MachineUsed, TransactionDate, TotalPayment FROM Transactions", conn)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim row As New TransactionRow()
                            row.SuspendLayout()
                            row.SetData(
                                If(IsDBNull(reader("TransactionID")), 0, CInt(reader("TransactionID"))),
                                If(IsDBNull(reader("CustomerName")), "", reader("CustomerName").ToString()),
                                If(IsDBNull(reader("ServiceType")), "", reader("ServiceType").ToString()),
                                If(IsDBNull(reader("Status")), "", reader("Status").ToString()),
                                If(IsDBNull(reader("MachineUsed")), "", reader("MachineUsed").ToString()),
                                If(IsDBNull(reader("TransactionDate")), Date.MinValue, CDate(reader("TransactionDate"))),
                                If(IsDBNull(reader("TotalPayment")), 0D, CDec(reader("TotalPayment")))
                            )
                            initMethodInfo?.Invoke(row, Nothing)
                            row.ResumeLayout(False)

                            AddHandler row.RowClicked, AddressOf TransactionRow_RowClicked
                            AddHandler row.RowDoubleClicked, AddressOf TransactionRow_RowDoubleClicked
                            AddHandler row.ViewButtonClicked, AddressOf TransactionRow_ViewButtonClicked

                            newRows.Add(row)
                            If Not String.IsNullOrWhiteSpace(row.lblStatus.Text) Then statuses.Add(row.lblStatus.Text)
                        End While
                    End Using
                End Using
            End Using

            If newRows.Count > 0 Then
                flpTransactions.Controls.AddRange(newRows.ToArray())
            End If

            ResizeHeader(Nothing, EventArgs.Empty)
            PopulateStatusFilter(statuses)
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

        If header IsNot Nothing AndAlso Not flpTransactions.Controls.Contains(header) Then
            flpTransactions.Controls.Add(header)
            flpTransactions.Controls.SetChildIndex(header, 0)
        End If
    End Sub

    ' -------------------------
    ' DOUBLE CLICK HANDLER
    ' -------------------------
    Private Sub TransactionRow_RowDoubleClicked(sender As TransactionRow)
        Dim viewForm As New TransactionForm With {
            .TransactionId = sender.TransactionID,
            .Mode = "View"
        }
        viewForm.ShowDialog()
    End Sub

    ' -------------------------
    ' FILTERING
    ' -------------------------
    Private Sub ApplyFilters()
        Dim searchTerm As String = tbSearch.Text.Trim().ToLower()
        Dim statusSelected As String = If(cmbStatus.SelectedItem IsNot Nothing, cmbStatus.SelectedItem.ToString(), "All")
        Dim dateFiltering As Boolean = Not toggleDate.Checked
        Dim selectedDate As Date = If(dateFiltering, dtpDateFilter.Value.Date, Date.MinValue)

        flpTransactions.SuspendLayout()
        For Each ctrl As Control In flpTransactions.Controls
            If TypeOf ctrl Is TransactionRow Then
                Dim row = DirectCast(ctrl, TransactionRow)
                If row.IsHeader Then
                    row.Visible = True
                    Continue For
                End If

                Dim visible = True
                If statusSelected <> "All" AndAlso Not row.lblStatus.Text.Equals(statusSelected, StringComparison.OrdinalIgnoreCase) Then visible = False
                If visible AndAlso searchTerm <> "" AndAlso
                    Not (row.lblCustomer.Text.ToLower().Contains(searchTerm) OrElse
                         row.lblServiceType.Text.ToLower().Contains(searchTerm) OrElse
                         row.lblMachine.Text.ToLower().Contains(searchTerm)) Then visible = False
                If visible AndAlso dateFiltering Then
                    Dim rowDate As Date
                    If Date.TryParse(row.lblDate.Text, rowDate) Then
                        If rowDate.Date <> selectedDate Then visible = False
                    End If
                End If

                row.Visible = visible
            End If
        Next
        flpTransactions.ResumeLayout(False)
        ResizeHeader(Nothing, EventArgs.Empty)
    End Sub

    ' -------------------------
    ' VIEW BUTTON
    ' -------------------------
    Private Sub TransactionRow_ViewButtonClicked(sender As TransactionRow)
        TransactionRow_RowClicked(sender)
        Dim viewForm As New TransactionForm With {
            .TransactionId = sender.TransactionID,
            .Mode = "View"
        }
        viewForm.ShowDialog()
    End Sub

    ' -------------------------
    ' FILTERS
    ' -------------------------
    Private Sub PopulateStatusFilter(collectedStatuses As IEnumerable(Of String))
        cmbStatus.BeginUpdate()
        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("All")
        For Each s In collectedStatuses
            cmbStatus.Items.Add(s)
        Next
        cmbStatus.SelectedIndex = 0
        cmbStatus.EndUpdate()
    End Sub

    ' -------------------------
    ' HEADER LAYOUT
    ' -------------------------
    Private ReadOnly columnSpacings As Integer() = {60, 10, 10, 10, 10, 10, 20, 5}

    Private Sub ResizeHeader(sender As Object, e As EventArgs)
        If flpTransactions Is Nothing OrElse header Is Nothing OrElse header.Controls.Count = 0 Then Exit Sub

        Dim baseWidth As Integer = flpTransactions.ClientSize.Width
        Dim vscrollVisible As Boolean = (flpTransactions.DisplayRectangle.Height > flpTransactions.ClientSize.Height)
        Dim extra As Integer = If(vscrollVisible, SystemInformation.VerticalScrollBarWidth, 0)
        Dim availWidth As Integer = Math.Max(0, baseWidth + extra - 20)
        header.Width = availWidth + 20

        Dim logicalTotal As Integer = columnWidths.Sum() + columnSpacings.Sum()
        If logicalTotal = 0 Then Exit Sub
        Dim scale As Double = availWidth / CDbl(logicalTotal)

        Dim scaledWidths = columnWidths.Select(Function(w) CInt(Math.Max(1, Math.Round(w * scale)))).ToArray()
        Dim scaledSpacings = columnSpacings.Select(Function(s) CInt(Math.Round(s * scale))).ToArray()
        Dim used = scaledWidths.Sum() + scaledSpacings.Sum()
        Dim diff = availWidth - used
        If diff <> 0 AndAlso scaledWidths.Length > 0 Then scaledWidths(scaledWidths.Length - 1) += diff

        Dim hdrLabels = {header.lblTransactionID, header.lblCustomer, header.lblServiceType, header.lblStatus, header.lblMachine, header.lblDate, header.lblTotal}
        Dim x As Integer = 10
        For i As Integer = 0 To hdrLabels.Length - 1
            Dim lbl = hdrLabels(i)
            lbl.Left = x
            lbl.Width = scaledWidths(i)
            lbl.AutoEllipsis = True
            x += lbl.Width + If(i < scaledSpacings.Length, scaledSpacings(i), 10)
        Next

        For Each ctrl As Control In flpTransactions.Controls
            If TypeOf ctrl Is TransactionRow Then
                DirectCast(ctrl, TransactionRow).AdjustColumnWidthsScaled(scaledWidths, scaledSpacings, availWidth)
            End If
        Next
    End Sub
End Class

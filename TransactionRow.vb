Public Class TransactionRow
    Public Property TransactionID As Integer
    Public Property IsHeader As Boolean = False

    ' Keep original event signature (TransactionsControl expects this)
    Public Event RowClicked(ByVal sender As TransactionRow)
    Public Event RowDoubleClicked(ByVal sender As TransactionRow)
    Public Event ViewButtonClicked(ByVal sender As TransactionRow) ' ✅ new event

    Private isSelected As Boolean = False
    Private isInitialized As Boolean = False

    ' ✅ New: background color definitions
    Private defaultBackColor As Color = Color.White
    Private hoverBackColor As Color = Color.AliceBlue
    Private selectedBackColor As Color = Color.FromArgb(220, 235, 252)

    ' Optional: name of the control that should NOT cause selection (e.g. "btnView")
    Private ReadOnly viewButtonName As String = "btnView" ' change to actual name if different

    ' -------------------------
    ' INITIALIZATION
    ' -------------------------
    Private Sub InitializeRow()
        Me.Margin = New Padding(0)
        If isInitialized Then Return
        isInitialized = True

        ' ===============================
        ' HEADER ROW LOGIC
        ' ===============================
        If IsHeader Then
            Me.BackColor = Color.FromArgb(235, 235, 235)

            ' Bold & center all existing Labels
            For Each lbl As Label In Me.Controls.OfType(Of Label)()
                lbl.Font = New Font("Poppins", 9, FontStyle.Bold)
                lbl.TextAlign = ContentAlignment.MiddleLeft
                lbl.BackColor = Color.Transparent
            Next

            ' Find the existing "View" button
            Dim btnView As Button = TryCast(Me.Controls.Find(viewButtonName, True).FirstOrDefault(), Button)
            If btnView Is Nothing Then
                btnView = Me.Controls.OfType(Of Button)().FirstOrDefault()
            End If

            ' Hide the button completely but keep layout
            If btnView IsNot Nothing Then
                btnView.Visible = False
                btnView.Enabled = False
            End If

            ' Prevent header from being interactive
            Me.Cursor = Cursors.Default
            Return
        End If

        ' ===============================
        ' NON-HEADER (NORMAL ROW) LOGIC
        ' ===============================
        AttachHandlersRecursively(Me)
        AddHandler Me.Click, AddressOf ForwardClickToRow
        AddHandler Me.DoubleClick, AddressOf ForwardDoubleClickToRow

        Dim viewBtn = TryCast(Me.Controls.Find(viewButtonName, True).FirstOrDefault(), Button)
        If viewBtn Is Nothing Then
            viewBtn = Me.Controls.OfType(Of Button)().FirstOrDefault()
        End If

        If viewBtn IsNot Nothing Then
            RemoveHandler viewBtn.Click, AddressOf OnViewButtonClick
            AddHandler viewBtn.Click, AddressOf OnViewButtonClick
            viewBtn.Cursor = Cursors.Hand
            viewBtn.BringToFront()
        End If

        Me.Cursor = Cursors.Hand
        Me.BackColor = defaultBackColor
    End Sub


    Private Sub AttachHandlersRecursively(ctrl As Control)
        For Each c As Control In ctrl.Controls
            ' Skip attaching click forwarding to the view button
            If c.Name.Equals(viewButtonName, StringComparison.OrdinalIgnoreCase) Then
                c.Cursor = Cursors.Hand
            Else
                AddHandler c.Click, AddressOf ForwardClickToRow
                AddHandler c.DoubleClick, AddressOf ForwardDoubleClickToRow
                c.Cursor = Cursors.Hand
            End If

            ' Make the background transparent so the row's BackColor shows through
            c.BackColor = Color.Transparent

            ' Recurse into child controls
            If c.HasChildren Then AttachHandlersRecursively(c)
        Next
    End Sub

    ' -------------------------
    ' FORWARDERS
    ' -------------------------
    Private Sub ForwardClickToRow(sender As Object, e As EventArgs)
        RaiseEvent RowClicked(Me)
    End Sub

    Private Sub ForwardDoubleClickToRow(sender As Object, e As EventArgs)
        RaiseEvent RowDoubleClicked(Me)
    End Sub

    ' -------------------------
    ' VIEW BUTTON HANDLER
    ' -------------------------
    Private Sub OnViewButtonClick(sender As Object, e As EventArgs)
        ' Raise event so parent control can open form
        RaiseEvent ViewButtonClicked(Me)
    End Sub

    ' -------------------------
    ' SET DATA
    ' -------------------------
    Public Sub SetData(transactionId As Integer, customerName As String, serviceType As String,
                       status As String, machineUsed As String, transDate As Date, totalPayment As Decimal)

        Me.TransactionID = transactionId

        ' Update labels (assumes these labels exist on the UserControl)
        lblTransactionID.Text = transactionId.ToString()
        lblCustomer.Text = customerName
        lblServiceType.Text = serviceType
        lblStatus.Text = status
        lblMachine.Text = machineUsed
        lblDate.Text = transDate.ToShortDateString()
        lblTotal.Text = "₱" & totalPayment.ToString("N2")

        Select Case status.ToLower()
            Case "pending"
                lblStatus.ForeColor = Color.DarkGoldenrod
            Case "in-progress"
                lblStatus.ForeColor = Color.DodgerBlue
            Case "for pickup"
                lblStatus.ForeColor = Color.MediumSlateBlue
            Case "for delivery"
                lblStatus.ForeColor = Color.DarkOrange
            Case "completed"
                lblStatus.ForeColor = Color.ForestGreen
            Case "refunded"
                lblStatus.ForeColor = Color.Crimson
        End Select

        ' Ensure all handlers are attached
        InitializeRow()
    End Sub

    ' Call this from ResizeHeader with the scaled widths & spacings
    ' scaledWidths, scaledSpacings calculated by ResizeHeader
    Public Sub AdjustColumnWidthsScaled(scaledWidths As Integer(), scaledSpacings As Integer(), availWidth As Integer)
        Try
            ' Make row width match available width (account for scrollbar overlay)
            If Me.Parent IsNot Nothing Then
                Dim pl As FlowLayoutPanel = TryCast(Me.Parent, FlowLayoutPanel)
                If pl IsNot Nothing Then
                    Dim vscrollVisible As Boolean = (pl.DisplayRectangle.Height > pl.ClientSize.Height)
                    Dim extra As Integer = If(vscrollVisible, SystemInformation.VerticalScrollBarWidth, 0)
                    Me.Width = Math.Max(0, pl.ClientSize.Width + extra - pl.Padding.Horizontal - 2)
                End If
            End If

            Dim x As Integer = 10
            Dim labels = {lblTransactionID, lblCustomer, lblServiceType, lblStatus, lblMachine, lblDate, lblTotal}

            For i As Integer = 0 To Math.Min(labels.Length - 1, scaledWidths.Length - 1)
                Dim lbl = labels(i)
                lbl.AutoEllipsis = True
                lbl.Left = x
                lbl.Width = scaledWidths(i)
                lbl.Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right
                x += scaledWidths(i) + If(i < scaledSpacings.Length, scaledSpacings(i), 10)
            Next

            ' Give leftover pixels (if any) to the last label so nothing is cut off
            If labels.Length > 0 AndAlso x < Me.Width Then
                Dim lastLbl = labels(labels.Length - 1)
                lastLbl.Width += (Me.Width - x - 10)
            End If
        Catch
            ' ignore layout errors
        End Try
    End Sub


    Private Function flPHasVisibleVScroll(flP As FlowLayoutPanel) As Boolean
        Try
            ' This is the most consistent approach: compare DisplayRectangle height vs ClientSize height
            Return flP.DisplayRectangle.Height > flP.ClientSize.Height
        Catch
            Return flP.VerticalScroll.Visible
        End Try
    End Function




    ' -------------------------
    ' SELECTION HIGHLIGHT
    ' -------------------------
    Public Sub SetSelected(selected As Boolean)
        isSelected = selected
        If selected Then
            Me.BackColor = selectedBackColor
        Else
            Me.BackColor = defaultBackColor
        End If
    End Sub

    ' -------------------------
    ' HOVER EFFECT
    ' -------------------------
    Private Sub TransactionRow_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        If Not isSelected Then Me.BackColor = hoverBackColor
    End Sub

    Private Sub TransactionRow_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        If Not isSelected Then Me.BackColor = defaultBackColor
    End Sub

    ' -------------------------
    ' DYNAMIC WIDTH ADJUST
    ' -------------------------
    Public Sub AdjustColumnWidths(widths As Integer())
        Dim x As Integer = 10
        Dim labels = {lblTransactionID, lblCustomer, lblServiceType, lblStatus, lblMachine, lblDate, lblTotal}

        For i As Integer = 0 To Math.Min(labels.Length - 1, widths.Length - 1)
            labels(i).Width = widths(i)
            labels(i).Left = x
            x += widths(i)
        Next
    End Sub
End Class

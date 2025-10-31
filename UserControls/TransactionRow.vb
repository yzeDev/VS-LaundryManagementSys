Imports Guna.UI2.WinForms
Imports System.ComponentModel

Public Class TransactionRow
    Inherits UserControl

    ' ---------- Public state ----------
    <Browsable(False)>
    Public Property TransactionID As Integer

    <Browsable(False)>
    Public Property CustomerName As String = ""

    <Browsable(False)>
    Public Property ContactNumber As String = ""   ' optional: set by parent if you need it when clicking Notify

    Public Property IsHeader As Boolean = False

    ' ---------- Events ----------
    Public Event RowClicked(ByVal sender As TransactionRow)
    Public Event RowDoubleClicked(ByVal sender As TransactionRow)

    ' Button events (parent subscribes)
    Public Event NotifyClicked(ByVal sender As TransactionRow)
    Public Event CompleteClicked(ByVal sender As TransactionRow)
    Public Event ArchiveClicked(ByVal sender As TransactionRow)

    ' ---------- Private UI state ----------
    Private isSelected As Boolean = False
    Private isInitialized As Boolean = False

    Private defaultBackColor As Color = Color.White
    Private hoverBackColor As Color = Color.AliceBlue
    Private selectedBackColor As Color = Color.FromArgb(220, 235, 252)

    ' -------------------------
    ' INITIALIZATION
    ' -------------------------
    Private Sub InitializeRow()
        If isInitialized Then Return
        isInitialized = True

        Me.Margin = New Padding(0)
        Me.DoubleBuffered = True
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.UserPaint, True)

        If IsHeader Then
            ' ------- HEADER LOOK -------
            Me.BackColor = Color.FromArgb(235, 235, 235)

            For Each lbl As Label In Me.Controls.OfType(Of Label)()
                lbl.Font = New Font("Poppins", 9, FontStyle.Bold)
                lbl.TextAlign = ContentAlignment.MiddleLeft
                lbl.BackColor = Color.Transparent
            Next

            ' Hide buttons on header
            For Each b In New Control() {btnNotify, btnComplete, btnArchive}
                If b IsNot Nothing Then
                    b.Visible = False
                    b.Enabled = False
                End If
            Next

            Me.Cursor = Cursors.Default
            Return
        End If

        ' ------- NORMAL ROW -------
        Me.BackColor = defaultBackColor
        Me.Cursor = Cursors.Hand

        ' Labels generic setup
        For Each lbl As Label In {rowNum, lblCustomer, lblServiceType, lblStatus, lblWaiting}
            If lbl Is Nothing Then Continue For
            lbl.BackColor = Color.Transparent
            lbl.AutoEllipsis = True
            lbl.Cursor = Cursors.Hand
            AddHandler lbl.Click, AddressOf ForwardClickToRow
            AddHandler lbl.DoubleClick, AddressOf ForwardDoubleClickToRow
        Next

        AddHandler btnNotify.Click, Sub() RaiseEvent NotifyClicked(Me)
        AddHandler btnComplete.Click, Sub() RaiseEvent CompleteClicked(Me)
        AddHandler btnArchive.Click, Sub() RaiseEvent ArchiveClicked(Me)

        ' Forward clicks from row background, too
        AddHandler Me.Click, AddressOf ForwardClickToRow
        AddHandler Me.DoubleClick, AddressOf ForwardDoubleClickToRow
    End Sub

    Private Sub StyleGhostButton(b As Guna2Button, text As String, Optional icon As Image = Nothing)
        If b Is Nothing Then Exit Sub
        b.Text = text
        b.Image = icon
        b.ImageAlign = HorizontalAlignment.Left
        b.TextAlign = HorizontalAlignment.Left
        b.Padding = New Padding(8, 0, 0, 0)
        b.Cursor = Cursors.Hand

        b.UseTransparentBackground = True
        b.BackColor = Color.Transparent
        b.FillColor = Color.Transparent
        b.BorderThickness = 0
        b.BorderRadius = 10
        b.Font = New Font("Poppins", 10, FontStyle.Bold)
        b.ForeColor = Color.Black

        b.HoverState.FillColor = Color.FromArgb(245, 245, 245)
        b.HoverState.ForeColor = Color.Black
        b.PressedColor = Color.FromArgb(235, 235, 235)
        b.DisabledState.FillColor = Color.Transparent
        b.DisabledState.ForeColor = Color.Gray
    End Sub

    ' -------------------------
    ' SET DATA
    ' -------------------------
    ' Use this overload for your current layout (no machine/date columns)
    Public Sub SetData(transactionId As Integer,
                       rowNumber As Integer,
                       customerName As String,
                       serviceType As String,
                       status As String,
                       waitingText As String,
                       Optional contact As String = "")
        Me.TransactionID = transactionId
        Me.CustomerName = customerName
        Me.ContactNumber = contact

        rowNum.Text = rowNumber.ToString()
        lblCustomer.Text = customerName
        lblServiceType.Text = serviceType
        lblStatus.Text = status
        lblWaiting.Text = waitingText

        ' Status color
        Select Case status.Trim().ToLowerInvariant()
            Case "pending" : lblStatus.ForeColor = Color.DarkGoldenrod
            Case "in-progress" : lblStatus.ForeColor = Color.DodgerBlue
            Case "for pickup" : lblStatus.ForeColor = Color.MediumSlateBlue
            Case "for delivery" : lblStatus.ForeColor = Color.DarkOrange
            Case "completed" : lblStatus.ForeColor = Color.ForestGreen
            Case "refunded" : lblStatus.ForeColor = Color.Crimson
            Case Else : lblStatus.ForeColor = Color.Black
        End Select

        InitializeRow()
    End Sub

    ' -------------------------
    ' LAYOUT HELPERS
    ' -------------------------
    ' Replaces your old version: only the 5 labels remain
    Public Sub AdjustColumnWidthsScaled(scaledWidths As Integer(), scaledSpacings As Integer(), availWidth As Integer)
        Try
            Dim pl As FlowLayoutPanel = TryCast(Me.Parent, FlowLayoutPanel)
            Dim vscrollVisible As Boolean = False
            Dim scrollW As Integer = 0

            If pl IsNot Nothing Then
                vscrollVisible = (pl.DisplayRectangle.Height > pl.ClientSize.Height)
                scrollW = If(vscrollVisible, SystemInformation.VerticalScrollBarWidth, 0)

                ' SUBTRACT the scrollbar width and panel paddings
                Dim usable = Math.Max(0, pl.ClientSize.Width - pl.Padding.Horizontal - scrollW)
                Me.Width = usable
            Else
                ' Fallback if not in a panel yet
                Me.Width = Math.Max(0, availWidth - scrollW)
            End If

            ' ---- lay out the labels ----
            Dim x As Integer = 10
            Dim labels = {rowNum, lblCustomer, lblServiceType, lblStatus, lblWaiting}

            For i As Integer = 0 To Math.Min(labels.Length - 1, scaledWidths.Length - 1)
                Dim lbl = labels(i)
                lbl.AutoEllipsis = True
                lbl.Left = x
                lbl.Width = scaledWidths(i)
                lbl.Anchor = AnchorStyles.Left Or AnchorStyles.Top
                x += scaledWidths(i) + If(i < scaledSpacings.Length, scaledSpacings(i), 10)
            Next

            ' stretch the last label to consume any leftover pixels (removes gap)
            If labels.Length > 0 AndAlso x < Me.Width Then
                Dim lastLbl = labels(labels.Length - 1)
                lastLbl.Width = Math.Max(20, lastLbl.Width + (Me.Width - x - 10))
            End If
        Catch
            ' swallow layout hiccups safely
        End Try
    End Sub


    ' Simple fixed widths overload
    Public Sub AdjustColumnWidths(widths As Integer())
        Dim x As Integer = 10
        Dim labels = {rowNum, lblCustomer, lblServiceType, lblStatus, lblWaiting}
        For i As Integer = 0 To Math.Min(labels.Length - 1, widths.Length - 1)
            If labels(i) Is Nothing Then Continue For
            labels(i).Width = widths(i)
            labels(i).Left = x
            x += widths(i)
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
    ' SELECTION & HOVER
    ' -------------------------
    Public Sub SetSelected(selected As Boolean)
        isSelected = selected
        Me.BackColor = If(selected, selectedBackColor, defaultBackColor)
    End Sub

    Private Sub TransactionRow_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        If Not isSelected AndAlso Not IsHeader Then Me.BackColor = hoverBackColor
    End Sub

    Private Sub TransactionRow_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        If Not isSelected AndAlso Not IsHeader Then Me.BackColor = defaultBackColor
    End Sub
End Class

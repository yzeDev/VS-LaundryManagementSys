Public Class MainForm

    Private activeNavButton As Button = Nothing

    Private ReadOnly ActiveColor As Color = Color.FromArgb(5, 33, 90)
    Private ReadOnly HoverColor As Color = Color.FromArgb(5, 33, 90)
    Private ReadOnly NormalColor As Color = Color.Transparent

    '  WINDOW CONTROL BUTTONS 

    Private Sub minimizeBtn_Click(sender As Object, e As EventArgs) Handles minimizeBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub maximizeBtn_Click(sender As Object, e As EventArgs) Handles maximizeBtn.Click
        Me.WindowState = If(Me.WindowState = FormWindowState.Maximized, FormWindowState.Normal, FormWindowState.Maximized)
    End Sub

    Private Sub xBtn_Click(sender As Object, e As EventArgs) Handles xBtn.Click
        Dim exitPopup As New ExitConfirmForm()

        exitPopup.Left = (Me.ClientSize.Width - exitPopup.Width) \ 2
        exitPopup.Top = (Me.ClientSize.Height - exitPopup.Height) \ 2

        Me.Controls.Add(exitPopup)
        exitPopup.BringToFront()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        If Me.WindowState <> FormWindowState.Minimized Then MyBase.OnPaint(e)
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        If Me.WindowState <> FormWindowState.Minimized Then MyBase.OnResize(e)
    End Sub

    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
        If Me.WindowState <> FormWindowState.Minimized Then MyBase.OnPaintBackground(e)
    End Sub

    Private Sub LoadUserControls(titleBarUC As UserControl, contentUC As UserControl)
        ' Clear and load title bar
        titleBarPanel.Controls.Clear()
        titleBarUC.Dock = DockStyle.Fill
        titleBarPanel.Controls.Add(titleBarUC)

        ' Clear and load content
        contentSpacePanel.Controls.Clear()

        ' --- DPI / scaling fix ---
        ' Force consistent scaling regardless of monitor DPI
        contentUC.AutoScaleMode = AutoScaleMode.None
        contentUC.Scale(New SizeF(1.0F, 1.0F))
        contentUC.Dock = DockStyle.Fill
        ' --- end fix ---

        contentSpacePanel.Controls.Add(contentUC)
    End Sub



    Private Sub SetActiveButton(clickedButton As Button)
        If activeNavButton IsNot Nothing Then
            activeNavButton.BackColor = NormalColor
        End If

        clickedButton.BackColor = ActiveColor
        activeNavButton = clickedButton
    End Sub

    Private Sub NavButton_Hover(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        If btn IsNot activeNavButton Then
            If e.GetType Is GetType(MouseEventArgs) Then
                btn.BackColor = HoverColor
            Else
                btn.BackColor = NormalColor
            End If

        End If
    End Sub


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Attach the same handler to all navigation buttons
        AddHandler dashboardBtn.Click, AddressOf NavButton_Click
        AddHandler machinesBtn.Click, AddressOf NavButton_Click
        AddHandler transactionsBtn.Click, AddressOf NavButton_Click
        AddHandler statisticsBtn.Click, AddressOf NavButton_Click
        AddHandler settingsBtn.Click, AddressOf NavButton_Click

        ' Load default view
        LoadSection(dashboardBtn)
    End Sub

    Private Sub NavButton_Click(sender As Object, e As EventArgs)
        Dim clickedButton As Button = CType(sender, Button)
        LoadSection(clickedButton)
    End Sub

    Private Sub LoadSection(clickedButton As Button)
        Dim titleBar As UserControl = Nothing
        Dim content As UserControl = Nothing

        Select Case clickedButton.Name
            Case "dashboardBtn"
                titleBar = New dashboardTitleBarUser()
                content = New DashboardControl()
            Case "machinesBtn"
                titleBar = New machTitleBarUser()
                content = New MachinesControl()
            Case "transactionsBtn"
                titleBar = New transacTitleBarUser()
                content = New TransactionControl()
            Case "statisticsBtn"
                titleBar = New statsTitleBarUser()
                content = New StatsControl()
            Case "settingsBtn"
                titleBar = New settingsTitleBarUser()
                content = New OptionsControl()
            Case Else
                Return
        End Select

        LoadUserControls(titleBar, content)
        SetActiveButton(clickedButton)
    End Sub


    Private Sub contentSpacePanel_Resize(sender As Object, e As EventArgs) Handles contentSpacePanel.Resize
        If contentSpacePanel.Controls.Count > 0 Then
            Dim contentUC = contentSpacePanel.Controls(0)
            contentUC.Dock = DockStyle.Fill
        End If
    End Sub

End Class
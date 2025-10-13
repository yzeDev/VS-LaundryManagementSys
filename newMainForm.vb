Public Class newMainForm

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
        ' Load the new title bar control
        titleBarPanel.Controls.Clear()
        titleBarUC.Dock = DockStyle.Fill
        titleBarPanel.Controls.Add(titleBarUC)

        ' Load the new content control
        contentSpacePanel.Controls.Clear()
        contentUC.Dock = DockStyle.Fill
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


    ' NAVBAR BUTTON HANDLERS 
    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        LoadUserControls(New dashboardTitleBarUser(), New DashboardControl())
        SetActiveButton(dashboardBtn)
    End Sub

    Private Sub machinesBtn_Click(sender As Object, e As EventArgs) Handles machinesBtn.Click
        LoadUserControls(New machTitleBarUser(), New MachinesControl())
        SetActiveButton(machinesBtn)
    End Sub

    Private Sub transactionsBtn_Click(sender As Object, e As EventArgs) Handles transactionsBtn.Click
        LoadUserControls(New transacTitleBarUser(), New TransactionsControl())
        SetActiveButton(transactionsBtn)
    End Sub

    Private Sub statisticsBtn_Click(sender As Object, e As EventArgs) Handles statisticsBtn.Click
        LoadUserControls(New statsTitleBarUser(), New StatsControl())
        SetActiveButton(statisticsBtn)
    End Sub

    Private Sub settingsBtn_Click(sender As Object, e As EventArgs) Handles settingsBtn.Click
        LoadUserControls(New settingsTitleBarUser(), New OptionsControl())
        SetActiveButton(settingsBtn)
    End Sub

    Private Sub titleBarPanel_Paint(sender As Object, e As PaintEventArgs) Handles titleBarPanel.Paint
    End Sub
End Class
Imports Guna.UI2.WinForms
Imports TheArtOfDevHtmlRenderer.Adapters.Entities

Public Class AdminForm

    Public Property CurrentUserID As String
    Public Property UserRole As String

    Private activeNavButton As Guna2GradientButton = Nothing

    Private ReadOnly ActiveColor As Color = Color.FromArgb(5, 33, 90)
    Private ReadOnly HoverColor As Color = Color.FromArgb(5, 33, 90)

    Private ReadOnly FillColor2 As Color = Color.MediumSeaGreen

    Private ReadOnly NormalColor As Color = Color.Transparent
    Private originalClientSize As Size
    Private isMaximizedManually As Boolean = False

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Attach the same handler to all navigation buttons
        AddHandler dashboardBtn.Click, AddressOf NavButton_Click
        AddHandler machinesBtn.Click, AddressOf NavButton_Click
        AddHandler transactionsBtn.Click, AddressOf NavButton_Click
        AddHandler statisticsBtn.Click, AddressOf NavButton_Click
        AddHandler settingsBtn.Click, AddressOf NavButton_Click
        AddHandler logsBtn.Click, AddressOf NavButton_Click
        AddHandler manageUsersBtn.Click, AddressOf NavButton_Click

        lblEmployeeID.Text = CurrentUserID
        lblUserRole.Text = UserRole

        ' Load default view
        LoadSection(dashboardBtn)
    End Sub

    '  WINDOW CONTROL BUTTONS 

    Private Sub AdminForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ' Handle restore from maximized to normal
        If Me.WindowState = FormWindowState.Normal AndAlso isMaximizedManually Then
            isMaximizedManually = False

            If contentSpacePanel.Controls.Count > 0 Then
                Dim currentUC As UserControl = TryCast(contentSpacePanel.Controls(0), UserControl)
                If currentUC IsNot Nothing Then
                    ' 🔧 Reset scaling to original layout
                    currentUC.SuspendLayout()
                    currentUC.Dock = DockStyle.None

                    ' Force back to original bounds relative to panel
                    currentUC.Location = New Point(0, 0)
                    currentUC.Size = contentSpacePanel.ClientSize

                    ' Reset layout and scaling
                    currentUC.AutoScaleMode = AutoScaleMode.None
                    currentUC.PerformLayout()

                    ' Reapply DockStyle.Fill so it resizes correctly again
                    currentUC.Dock = DockStyle.Fill
                    currentUC.ResumeLayout(True)
                    currentUC.Refresh()
                End If
            End If
        End If
    End Sub


    Private Sub xBtn_Click(sender As Object, e As EventArgs) Handles xBtn.Click
        Dim exitPopup As New ExitConfirmForm

        exitPopup.Left = (ClientSize.Width - exitPopup.Width) \ 2
        exitPopup.Top = (ClientSize.Height - exitPopup.Height) \ 2

        Controls.Add(exitPopup)
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

        contentUC.AutoScaleMode = AutoScaleMode.None
        contentUC.Dock = DockStyle.Fill

        contentSpacePanel.Controls.Add(contentUC)
    End Sub



    Private Sub SetActiveButton(clickedButton As Guna2GradientButton)
        If activeNavButton IsNot Nothing Then
            activeNavButton.FillColor = NormalColor
            activeNavButton.FillColor2 = NormalColor
        End If

        clickedButton.FillColor2 = FillColor2
        activeNavButton = clickedButton
    End Sub

    Private Sub NavButton_Hover(sender As Object, e As EventArgs)
        Dim btn As Guna2GradientButton = CType(sender, Guna2GradientButton)
        If btn IsNot activeNavButton Then
            If e.GetType Is GetType(MouseEventArgs) Then
                btn.BackColor = HoverColor
            Else
                btn.BackColor = NormalColor
            End If

        End If
    End Sub


    Private Sub NavButton_Click(sender As Object, e As EventArgs)
        Dim clickedButton As Guna2GradientButton = CType(sender, Guna2GradientButton)
        LoadSection(clickedButton)
    End Sub

    Private Sub LoadSection(clickedButton As Guna2GradientButton)
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
                content = New TransactionsControl()
            Case "statisticsBtn"
                titleBar = New statsTitleBarUser()
                content = New StatsControl()
            Case "settingsBtn"
                titleBar = New settingsTitleBarUser()
                content = New OptionsControl()
            Case "logsBtn"
                titleBar = New logsTitleBarUser()
                content = New LogsControl()
            Case "manageUsersBtn"
                titleBar = New manageUsersTitleBarUser()
                content = New ManageUsersControl()
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

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Optional: confirm logout
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Show the login form centered
            Dim loginForm As New LoginForm()
            loginForm.StartPosition = FormStartPosition.CenterScreen
            loginForm.Show()

            ' Close the current main form
            Me.Close()
        End If
    End Sub
End Class
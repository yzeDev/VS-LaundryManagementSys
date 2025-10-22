Public Class OptionsControl

    ' Create instances of your user controls (only once)
    Private changePassControl As New ChangePasswordControl()
    Private priceSetControl As New PriceSettingsControl()
    Private currentControl As UserControl = Nothing

    Private Sub OptionsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize both controls
        changePassControl.Dock = DockStyle.Fill

        ' For PriceSettingsControl: custom width scaling only
        priceSetControl.Dock = DockStyle.None
        priceSetControl.Top = 0
        priceSetControl.Left = 0
        priceSetControl.Height = 500 ' Set a fixed height you prefer

        ' Add them both once
        panelDisplay.Controls.Add(changePassControl)
        panelDisplay.Controls.Add(priceSetControl)

        ' Default view
        ShowControl(changePassControl)
        HighlightButton(guna2BtnPassword, True)
        HighlightButton(guna2BtnPriceSettings, False)
    End Sub

    Private Sub guna2BtnPassword_Click(sender As Object, e As EventArgs) Handles guna2BtnPassword.Click
        ShowControl(changePassControl)
        HighlightButton(guna2BtnPassword, True)
        HighlightButton(guna2BtnPriceSettings, False)
    End Sub

    Private Sub guna2BtnPriceSettings_Click(sender As Object, e As EventArgs) Handles guna2BtnPriceSettings.Click
        ShowControl(priceSetControl)
        HighlightButton(guna2BtnPriceSettings, True)
        HighlightButton(guna2BtnPassword, False)
    End Sub

    Private Sub ShowControl(ctrl As UserControl)
        If ctrl Is Nothing Then Return

        ' Hide the previous control
        If currentControl IsNot Nothing Then
            currentControl.Visible = False
        End If

        ' Adjust layout for price settings control (only width)
        If ctrl Is priceSetControl Then
            priceSetControl.Width = panelDisplay.Width
            priceSetControl.Left = 0
            'priceSetControl.Top = (panelDisplay.Height - priceSetControl.Height) \ 2
        End If

        ' Show and bring to front
        ctrl.Visible = True
        ctrl.BringToFront()
        currentControl = ctrl
    End Sub

    Private Sub panelDisplay_Resize(sender As Object, e As EventArgs) Handles panelDisplay.Resize
        ' Auto-update width when resizing the parent panel
        If currentControl Is priceSetControl Then
            priceSetControl.Width = panelDisplay.Width
        End If
    End Sub

    Private Sub HighlightButton(btn As Guna.UI2.WinForms.Guna2Button, isActive As Boolean)
        If isActive Then
            btn.FillColor = Color.DimGray
            btn.ForeColor = Color.White
        Else
            btn.FillColor = Color.Transparent
            btn.ForeColor = Color.DimGray
        End If
    End Sub

End Class

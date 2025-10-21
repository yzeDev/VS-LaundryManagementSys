Public Class OptionsControl

    ' Create instances of your user controls
    Private changePassControl As New ChangePasswordControl()
    'Private priceSetControl As New PriceSettingsControl()

    Private Sub OptionsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        'ShowControl(priceSetControl)
        HighlightButton(guna2BtnPriceSettings, True)
        HighlightButton(guna2BtnPassword, False)
    End Sub

    Private Sub ShowControl(ctrl As UserControl)
        panelDisplay.Controls.Clear()
        ctrl.Dock = DockStyle.Fill
        panelDisplay.Controls.Add(ctrl)
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

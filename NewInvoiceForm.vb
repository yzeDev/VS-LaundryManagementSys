Imports System.Runtime.InteropServices
Imports System.Drawing
Imports Guna.UI2.WinForms

Public Class NewInvoiceForm

    <DllImport("user32.dll")>
    Private Shared Function HideCaret(ByVal hWnd As IntPtr) As Boolean
    End Function


    ' selected border 
    Private ReadOnly SelectedBorderColor As Color = Color.FromArgb(175, 213, 253)
    Private ReadOnly UnselectedBorderColor As Color = Color.FromArgb(195, 217, 240)

    Private ReadOnly BorderSize As Integer = 2
    Private ReadOnly DefaultBorderSize As Integer = 1

    Private Sub SetPaymentMethod(ByVal selectedButton As Guna.UI2.WinForms.Guna2Button)
        ' Reset all buttons to the UNSELECTED color and default thickness

        cashBtn.BorderColor = UnselectedBorderColor
        cashBtn.BorderThickness = DefaultBorderSize

        GCashBtn.BorderColor = UnselectedBorderColor
        GCashBtn.BorderThickness = DefaultBorderSize

        mayaBtn.BorderColor = UnselectedBorderColor
        mayaBtn.BorderThickness = DefaultBorderSize

        ' Set the border of the clicked button to the SELECTED color and thickness
        selectedButton.BorderColor = SelectedBorderColor
        selectedButton.BorderThickness = BorderSize

        ' Enable the Select button once a choice is made
        selectBtn.Enabled = True
    End Sub

    Private Sub NewInvoiceForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        addressBox.SelectionStart = 0
        addressBox.SelectionLength = 0
        CloseBtn.Focus()

        ' SET CASH AS DEFAULT SELECTED PAYMENT METHOD 
        SetPaymentMethod(cashBtn)
    End Sub

    Private Sub addressBox_GotFocus(sender As Object, e As EventArgs) Handles addressBox.GotFocus
        HideCaret(addressBox.Handle)
    End Sub

    Private Sub addressBox_MouseDown(sender As Object, e As MouseEventArgs) Handles addressBox.MouseDown
        Me.BeginInvoke(New Action(Sub() HideCaret(addressBox.Handle)))
    End Sub

    '  Payment Button Click Handlers
    Private Sub cashBtn_Click(sender As Object, e As EventArgs) Handles cashBtn.Click
        SetPaymentMethod(CType(sender, Guna.UI2.WinForms.Guna2Button))
    End Sub

    Private Sub GCashBtn_Click(sender As Object, e As EventArgs) Handles GCashBtn.Click
        SetPaymentMethod(CType(sender, Guna.UI2.WinForms.Guna2Button))
    End Sub

    Private Sub mayaBtn_Click(sender As Object, e As EventArgs) Handles mayaBtn.Click
        SetPaymentMethod(CType(sender, Guna.UI2.WinForms.Guna2Button))
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

End Class
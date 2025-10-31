Imports System.Data.OleDb

Public Class SelfServiceForm
    Private packageType As String

    Public Sub New()
        InitializeComponent()
        packageType = If(String.IsNullOrWhiteSpace(Guna2cmbService.Text), "Wash Only", Guna2cmbService.Text)
    End Sub

    ' Keep package type in sync
    Private Sub Guna2cmbService_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2cmbService.SelectedIndexChanged
        packageType = Guna2cmbService.Text
    End Sub

    ' Load: show latest rates + preview TransactionID
    Private Sub SelfServiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim wash = GetLatestPrice("Self-Service", "Wash Only")
        Dim dry = GetLatestPrice("Self-Service", "Dry Only")
        Dim both = GetLatestPrice("Self-Service", "Wash + Dry")

        lblRate.Text =
            $"• Wash Only: {wash.Peso()}/kg{Environment.NewLine}" &
            $"• Dry Only: {dry.Peso()}/kg{Environment.NewLine}" &
            $"• Wash + Dry: {both.Peso()}/kg"

        lblTransactionID.Text = GetNextTransactionIdEstimate().ToString("00000")
    End Sub

    ' Contact: numeric-only after "+63 "
    Private Sub Guna2txtboxContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2txtboxContact.KeyPress
        If Guna2txtboxContact.SelectionStart >= 4 Then
            If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Guna2txtboxContact_TextChanged(sender As Object, e As EventArgs) Handles Guna2txtboxContact.TextChanged
        Dim contact = Guna2txtboxContact.Text.Trim
        If Not contact.StartsWith("+63 ") Then
            Guna2txtboxContact.Text = "+63 "
            Guna2txtboxContact.SelectionStart = Guna2txtboxContact.Text.Length
            Exit Sub
        End If

        Dim numberPart = contact.Substring(4).Replace(" ", "")
        If numberPart.StartsWith("0") Then
            MessageBox.Show("Contact number should not start with 0 after +63.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Guna2txtboxContact.Text = "+63 "
            Guna2txtboxContact.SelectionStart = Guna2txtboxContact.Text.Length
            Exit Sub
        End If
        If numberPart.Length > 10 Then numberPart = numberPart.Substring(0, 10)

        Dim newText = "+63 " & numberPart
        If Guna2txtboxContact.Text <> newText Then
            Guna2txtboxContact.Text = newText
            Guna2txtboxContact.SelectionStart = Guna2txtboxContact.Text.Length
        End If
    End Sub

    ' Pickup/Delivery toggles
    Private Sub Guna2CheckBoxPickup_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxPickup.CheckedChanged
        If Guna2CheckBoxPickup.Checked Then
            Guna2CheckBoxDelivery.Checked = False
            txtboxAddress.Clear()
            txtboxAddress.Enabled = False
        Else
            txtboxAddress.Enabled = True
        End If
    End Sub

    Private Sub Guna2CheckBoxDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxDelivery.CheckedChanged
        If Guna2CheckBoxDelivery.Checked Then
            Guna2CheckBoxPickup.Checked = False
            txtboxAddress.Enabled = True
        End If
    End Sub

    ' Cancel
    Private Sub gbCancel_Click(sender As Object, e As EventArgs) Handles gbCancel.Click
        Dim confirmForm As New transacCancelConfirm()
        confirmForm.TopMost = True
        confirmForm.ShowDialog(Me)
        If confirmForm.UserConfirmed Then
            TransactionOption.Show()
            Me.Dispose()
        End If
    End Sub

    ' Continue → use helper to open invoice
    Private Sub gbContinue_Click(sender As Object, e As EventArgs) Handles gbContinue.Click
        Dim weightVal As Decimal
        If Not Decimal.TryParse(Guna2txtboxWeight.Text, weightVal) OrElse weightVal <= 0D Then
            MessageBox.Show("Enter a valid weight.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim rate = GetLatestPrice("Self-Service", packageType)

        OpenInvoiceModal(Me,
                         Guna2TxtboxName.Text,
                         Guna2txtboxContact.Text,
                         txtboxAddress.Text,
                         weightVal,
                         "Self-Service",
                         packageType,
                         rate,
                         Guna2CheckBoxDelivery.Checked)
    End Sub
End Class

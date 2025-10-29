Imports System.Data.OleDb
Imports Guna.UI2.WinForms

Public Class BasicServiceForm
    Private packageType As String = ""

    Public Sub New()
        InitializeComponent()
        If Guna2cmbServiceType.Items.Count > 0 Then
            Guna2cmbServiceType.SelectedIndex = 0
            packageType = Guna2cmbServiceType.SelectedItem.ToString()
        Else
            packageType = "Wash Only"
        End If
    End Sub

    ' Load: rates + preview ID
    Private Sub BasicServiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim wash = GetLatestPrice("Basic Service", "Wash Only")
        Dim dry = GetLatestPrice("Basic Service", "Dry Only")
        Dim both = GetLatestPrice("Basic Service", "Wash + Dry")

        lblRate.Text =
            $"• Wash Only: {wash.Peso()}/kg{Environment.NewLine}" &
            $"• Dry Only: {dry.Peso()}/kg{Environment.NewLine}" &
            $"• Wash + Dry: {both.Peso()}/kg"

        lblTransactionID.Text = GetNextTransactionIdEstimate().ToString("00000")
    End Sub

    ' Keep packageType in sync
    Private Sub Guna2cmbServiceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2cmbServiceType.SelectedIndexChanged
        If Guna2cmbServiceType.SelectedItem IsNot Nothing Then
            packageType = Guna2cmbServiceType.SelectedItem.ToString()
        End If
    End Sub

    ' Pickup / Delivery toggles
    Private Sub Guna2CheckBoxdelivery_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxdelivery.CheckedChanged
        If Guna2CheckBoxdelivery.Checked Then
            Guna2CheckBoxPickUp.Checked = False
            txtboxAddress.Enabled = True
        End If
    End Sub

    Private Sub Guna2CheckBoxPickUp_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxPickUp.CheckedChanged
        If Guna2CheckBoxPickUp.Checked Then
            Guna2CheckBoxdelivery.Checked = False
            txtboxAddress.Enabled = False
            txtboxAddress.Clear()
        Else
            txtboxAddress.Enabled = True
        End If
    End Sub

    ' Contact
    Private Sub Guna2txtboxContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2txtboxContact.KeyPress
        If Guna2txtboxContact.SelectionStart >= 4 Then
            If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Guna2txtboxContact_TextChanged(sender As Object, e As EventArgs) Handles Guna2txtboxContact.TextChanged
        Dim txt = Guna2txtboxContact.Text.Trim()
        If Not txt.StartsWith("+63 ") Then
            Guna2txtboxContact.Text = "+63 "
            Guna2txtboxContact.SelectionStart = Guna2txtboxContact.Text.Length
            Exit Sub
        End If

        Dim numberPart As String = ""
        If txt.Length > 4 Then
            numberPart = txt.Substring(4).Replace(" ", "")
            If numberPart.StartsWith("0") Then
                MessageBox.Show("Contact number cannot start with 0 after +63.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Guna2txtboxContact.Text = "+63 "
                Guna2txtboxContact.SelectionStart = Guna2txtboxContact.Text.Length
                Exit Sub
            End If
            If numberPart.Length > 10 Then numberPart = numberPart.Substring(0, 10)
        End If

        Dim newText = "+63 " & numberPart
        If Guna2txtboxContact.Text <> newText Then
            Guna2txtboxContact.Text = newText
            Guna2txtboxContact.SelectionStart = Guna2txtboxContact.Text.Length
        End If
    End Sub

    ' Weight input
    Private Sub Guna2txtboxWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2txtboxWeight.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub Guna2txtboxWeight_TextChanged(sender As Object, e As EventArgs) Handles Guna2txtboxWeight.TextChanged
        Dim weight As Double
        If Double.TryParse(Guna2txtboxWeight.Text, weight) Then
            If weight > 10 Then
                MessageBox.Show("Weight cannot exceed 10 kg.", "Invalid Weight", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Guna2txtboxWeight.Text = ""
            End If
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

    ' Continue → open invoice via helper
    Private Sub gbContinue_Click(sender As Object, e As EventArgs) Handles gbContinue.Click
        If String.IsNullOrWhiteSpace(Guna2txtboxName.Text) OrElse String.IsNullOrWhiteSpace(packageType) Then
            MessageBox.Show("Please fill out all fields properly.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim weightVal As Decimal
        If Not Decimal.TryParse(Guna2txtboxWeight.Text, weightVal) OrElse weightVal <= 0D Then
            MessageBox.Show("Enter a valid weight.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim rate = GetLatestPrice("Basic Service", packageType)

        OpenInvoiceModal(Me,
                         Guna2txtboxName.Text,
                         Guna2txtboxContact.Text,
                         txtboxAddress.Text,
                         weightVal,
                         "Basic Service",
                         packageType,
                         rate,
                         Guna2CheckBoxdelivery.Checked)
    End Sub

    ' Optional: preview ID refresh
    Private Sub BasicServiceForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        lblTransactionID.Text = GetNextTransactionIdEstimate().ToString("00000")
    End Sub
End Class

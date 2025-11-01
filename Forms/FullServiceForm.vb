Imports System.Data.OleDb

Public Class FullServiceForm
    Private latestPrice As Decimal = 0D

    ' Load: set rate + preview ID + default prefix
    Private Sub FullServiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        latestPrice = GetLatestPrice("Full Service", "Wash, Dry, and Fold")

        lblRate.Text = "• Wash, Dry, and Fold" & Environment.NewLine &
                       $"Rate: {latestPrice.Peso()}/kg"

        lblTransactionID.Text = GetNextTransactionIdEstimate().ToString("00000")

        If String.IsNullOrWhiteSpace(Guna2txtboxContact.Text) Then
            Guna2txtboxContact.Text = "+63 "
            Guna2txtboxContact.SelectionStart = Guna2txtboxContact.Text.Length
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
        Dim contact As String = Guna2txtboxContact.Text.Trim()
        If Not contact.StartsWith("+63 ") Then
            Guna2txtboxContact.Text = "+63 "
            Guna2txtboxContact.SelectionStart = Guna2txtboxContact.Text.Length
            Exit Sub
        End If
        Dim numberPart As String = ""
        If contact.Length > 4 Then
            numberPart = contact.Substring(4).Replace(" ", "")
            If numberPart.StartsWith("0") Then
                MessageBox.Show("Contact number should not start with 0 after +63.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then e.Handled = True
        If e.KeyChar = "."c AndAlso Guna2txtboxWeight.Text.Contains("."c) Then e.Handled = True
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

    ' Continue → open invoice via helper
    Private Sub gbContinue_Click(sender As Object, e As EventArgs) Handles gbContinue.Click
        ' Validate weight
        Dim weightVal As Decimal
        If Not Decimal.TryParse(Guna2txtboxWeight.Text, weightVal) OrElse weightVal <= 0D Then
            MessageBox.Show("Enter a valid weight.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Fixed values
        Dim serviceType As String = "Full Service"
        Dim packageType As String = "Wash, Dry, and Fold"
        Dim optionType As String = "Standard" ' 👈 since there’s no combo box, use a default name
        Dim isDelivery As Boolean = Guna2CheckBoxDelivery.Checked

        ' Open invoice modal with proper parameter order
        OpenInvoiceModal(Me,
                     Guna2txtboxName.Text,
                     Guna2txtboxContact.Text,
                     txtboxAddress.Text,
                     weightVal,
                     serviceType,
                     packageType,
                     optionType,
                     latestPrice,
                     isDelivery)
    End Sub


    ' Optional: refresh preview ID when re-activated
    Private Sub FullServiceForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        lblTransactionID.Text = GetNextTransactionIdEstimate().ToString("00000")
    End Sub
End Class

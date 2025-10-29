Imports System.Data.OleDb
Imports Guna.UI2.WinForms

Public Class DryCleaningForm

    ' Get latest price for Dry Cleaning subservice (Small/Medium/Large)
    Private Function GetLatestPrice_Dry(subService As String) As Decimal
        Return GetLatestPrice("Dry Cleaning", subService)
    End Function

    ' Load: show rates and (optional) preview ID if you have the label
    Private Sub DryCleaningForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pSmall = GetLatestPrice_Dry("Small")
        Dim pMedium = GetLatestPrice_Dry("Medium")
        Dim pLarge = GetLatestPrice_Dry("Large")

        lblRate.Text =
            $"• Small: {pSmall.Peso()} per piece{Environment.NewLine}" &
            $"• Medium: {pMedium.Peso()} per piece{Environment.NewLine}" &
            $"• Large: {pLarge.Peso()} per piece"

        ' If you added a preview TransactionID label on this form, uncomment:
        ' lblTransactionID.Text = GetNextTransactionIdEstimate().ToString("00000")
    End Sub

    ' Delivery toggles
    Private Sub Guna2CheckBoxdelivery_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxdelivery.CheckedChanged
        If Guna2CheckBoxdelivery.Checked Then
            Guna2CheckBoxPickup.Checked = False
            txtboxAddress.Enabled = True
        End If
    End Sub

    Private Sub Guna2CheckBoxPickup_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxPickup.CheckedChanged
        If Guna2CheckBoxPickup.Checked Then
            Guna2CheckBoxdelivery.Checked = False
            txtboxAddress.Text = ""
            txtboxAddress.Enabled = False
        Else
            txtboxAddress.Enabled = True
        End If
    End Sub

    ' Contact formatting
    Private Sub Guna2txtboxContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2txtboxContact.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then e.Handled = True
        Dim txt = Guna2txtboxContact.Text
        If txt.StartsWith("+63 ") Then
            Dim digitsAfterPrefix = txt.Length - 4
            If digitsAfterPrefix >= 10 AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
        End If
    End Sub

    Private Sub Guna2txtboxContact_TextChanged(sender As Object, e As EventArgs) Handles Guna2txtboxContact.TextChanged
        Dim txt = Guna2txtboxContact.Text
        If Not txt.StartsWith("+63 ") Then
            Guna2txtboxContact.Text = "+63 "
            Guna2txtboxContact.SelectionStart = Guna2txtboxContact.Text.Length
        End If

        If txt.Length > 4 Then
            Dim afterPrefix = txt.Substring(4)
            If afterPrefix.StartsWith("0") Then
                MessageBox.Show("Contact number cannot start with 0 after +63.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Guna2txtboxContact.Text = "+63 "
                Guna2txtboxContact.SelectionStart = Guna2txtboxContact.Text.Length
            End If
        End If
    End Sub

    ' Quantity (pieces)
    Private Sub Guna2txtboxQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2txtboxQuantity.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then e.Handled = True
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

    ' Continue → compute and open Invoice (manual, to use "per piece" and "pcs")
    Private Sub gbContinue_Click(sender As Object, e As EventArgs) Handles gbContinue.Click
        If String.IsNullOrWhiteSpace(Guna2txtboxName.Text) OrElse
           gcbClotheSize.SelectedItem Is Nothing OrElse
           String.IsNullOrWhiteSpace(Guna2txtboxQuantity.Text) Then

            MessageBox.Show("Please fill out all fields properly.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim packageType As String = gcbClotheSize.SelectedItem.ToString()
        Dim rate As Decimal = GetLatestPrice_Dry(packageType)

        Dim qty As Decimal
        If Not Decimal.TryParse(Guna2txtboxQuantity.Text, qty) OrElse qty <= 0D Then
            MessageBox.Show("Enter a valid quantity.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Use ComputeFees even if "weight" here is quantity; same math
        Dim isDelivery = Guna2CheckBoxdelivery.Checked
        Dim fees = ComputeFees(rate, qty, isDelivery)
        Dim deliveryMode = If(isDelivery, "Delivery", "Pickup")

        ' Build invoice manually so we can show "per piece" and "pcs"
        Using invoice As New NewInvoiceForm()
            invoice.PreviousForm = Me
            invoice.CustomerName = Guna2txtboxName.Text
            invoice.ContactNumber = NormalizeOptionalContact(Guna2txtboxContact.Text)
            invoice.Address = txtboxAddress.Text
            invoice.Weight = qty.ToString("F0") & " pcs"       ' <- show pieces
            invoice.ServiceType = "Dry Cleaning"
            invoice.PackageType = packageType
            invoice.Rate = rate.Peso() & " per piece"          ' <- unit text
            invoice.ServiceFee = fees.ServiceFee.Peso()
            invoice.DeliveryFee = fees.DeliveryFee.Peso()
            invoice.TotalAmount = fees.Total.Peso()
            invoice.DeliveryMode = deliveryMode

            Me.Hide()
            invoice.StartPosition = FormStartPosition.CenterParent
            invoice.ShowDialog(Me)
            Me.Show()
        End Using
    End Sub

End Class

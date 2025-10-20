Imports Guna.UI2.WinForms

Public Class DryCleaningForm
    Private Sub gbCancel_Click(sender As Object, e As EventArgs) Handles gbCancel.Click
        Me.Close()
    End Sub

    ' Variable para sa package type
    Private packageType As String = ""

    ' ===== PACKAGE SELECTION =====
    Private Sub gcbClotheSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcbClotheSize.SelectedIndexChanged
        packageType = gcbClotheSize.SelectedItem.ToString()
    End Sub

    ' ===== DELIVERY CHECKBOX =====
    Private Sub Guna2CheckBoxdelivery_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxdelivery.CheckedChanged
        If Guna2CheckBoxdelivery.Checked Then
            Guna2CheckBoxPickup.Checked = False
            txtboxAddress.Enabled = True    ' allow typing address
        End If
    End Sub

    ' ===== PICKUP CHECKBOX =====
    Private Sub Guna2CheckBoxpickup_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxPickup.CheckedChanged
        If Guna2CheckBoxPickup.Checked Then
            Guna2CheckBoxdelivery.Checked = False
            txtboxAddress.Enabled = False   ' disable address input
            txtboxAddress.Clear()
        End If
    End Sub

    ' CONTACT NUMBER (+63 format)
    Private Sub Guna2TxtboxContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2txtboxContact.KeyPress
        ' digits lang pwede (no letters or symbols)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            Return
        End If

        ' siguraduhin may +63 sa unahan
        If Not Guna2txtboxContact.Text.StartsWith("+63 ") Then
            Guna2txtboxContact.Text = "+63 "
            Guna2txtboxContact.SelectionStart = Guna2txtboxContact.Text.Length
        End If

        ' kunin digits lang after ng +63
        Dim digitsOnly As String = Guna2txtboxContact.Text.Replace("+63 ", "")

        ' bawal magsimula sa 0 (ex: +63 09xx → mali)
        If digitsOnly.Length = 0 AndAlso e.KeyChar = "0"c Then
            e.Handled = True
            Return
        End If

        ' hanggang 10 digits lang pwede after +63
        If digitsOnly.Length >= 10 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' para di matanggal yung +63 prefix
    Private Sub Guna2TxtboxContact_TextChanged(sender As Object, e As EventArgs) Handles Guna2txtboxContact.TextChanged
        If Not Guna2txtboxContact.Text.StartsWith("+63 ") Then
            Guna2txtboxContact.Text = "+63 "
            Guna2txtboxContact.SelectionStart = Guna2txtboxContact.Text.Length
        End If
    End Sub


    ' ===== CONTINUE BUTTON =====
    Private Sub gbContinue_Click(sender As Object, e As EventArgs) Handles gbContinue.Click
        ' validation
        If Guna2txtboxName.Text = "" Or Guna2txtboxContact.Text.Length < 14 Or Guna2txtboxQuantity.Text = "" Or packageType = "" Then
            MessageBox.Show("Please fill out all fields properly.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' package rates
        Dim rate As Decimal
        Select Case packageType
            Case "Small"
                rate = 80
            Case "Medium"
                rate = 100
            Case "Large"
                rate = 120
            Case Else
                rate = 0
        End Select

        ' compute total
        Dim weight As Decimal = Val(Guna2txtboxQuantity.Text)
        Dim total As Decimal = rate * weight
        Dim deliveryFee As Decimal = If(Guna2CheckBoxdelivery.Checked, total * 0.05D, 0)
        Dim totalAmount As Decimal = total + deliveryFee

        ' create invoice form
        Dim invoice As New InvoiceForm()
        invoice.PreviousForm = Me
        invoice.CustomerName = Guna2txtboxName.Text
        invoice.ContactNumber = Guna2txtboxContact.Text
        invoice.Address = txtboxAddress.Text
        invoice.Weight = weight
        invoice.ServiceType = "Dry Cleaning"
        invoice.PackageType = packageType
        invoice.Rate = "₱" & rate.ToString("N2")
        invoice.ServiceFee = "₱" & total.ToString("N2")
        invoice.DeliveryFee = "₱" & deliveryFee.ToString("N2")
        invoice.TotalAmount = "₱" & totalAmount.ToString("N2")
        invoice.DeliveryMode = If(Guna2CheckBoxdelivery.Checked, "Yes", "No")

        ' show invoice
        invoice.Show()
        Me.Hide()
    End Sub

End Class

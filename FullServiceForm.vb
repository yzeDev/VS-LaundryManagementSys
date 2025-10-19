Public Class FullServiceForm

    ' Cancel button
    Private Sub gbCancel_Click(sender As Object, e As EventArgs) Handles gbCancel.Click
        Me.Close()
    End Sub

    ' Kapag delivery ang pinili
    Private Sub Guna2CheckBoxdelivery_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxdelivery.CheckedChanged
        If Guna2CheckBoxdelivery.Checked Then
            Guna2CheckBoxpickup.Checked = False
            txtboxAddress.Enabled = True   ' pwede mag-type ng address
        End If
    End Sub

    ' Kapag pickup ang pinili
    Private Sub Guna2CheckBoxpickup_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxpickup.CheckedChanged
        If Guna2CheckBoxpickup.Checked Then
            Guna2CheckBoxdelivery.Checked = False
            txtboxAddress.Enabled = False  ' bawal mag-type ng address
            txtboxAddress.Clear()
        End If
    End Sub

    ' CONTACT NUMBER (+63 format)
    Private Sub Guna2TxtboxContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TxtboxContact.KeyPress
        ' digits lang pwede (no letters or symbols)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            Return
        End If

        ' siguraduhin may +63 sa unahan
        If Not Guna2TxtboxContact.Text.StartsWith("+63 ") Then
            Guna2TxtboxContact.Text = "+63 "
            Guna2TxtboxContact.SelectionStart = Guna2TxtboxContact.Text.Length
        End If

        ' kunin digits lang after ng +63
        Dim digitsOnly As String = Guna2TxtboxContact.Text.Replace("+63 ", "")

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
    Private Sub Guna2TxtboxContact_TextChanged(sender As Object, e As EventArgs) Handles Guna2TxtboxContact.TextChanged
        If Not Guna2TxtboxContact.Text.StartsWith("+63 ") Then
            Guna2TxtboxContact.Text = "+63 "
            Guna2TxtboxContact.SelectionStart = Guna2TxtboxContact.Text.Length
        End If
    End Sub

    ' WEIGHT (KG)
    Private Sub Guna2Txtboxkg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2Txtboxkg.KeyPress
        ' numbers lang pwede i-type
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' limit hanggang 10kg lang
    Private Sub Guna2Txtboxkg_TextChanged(sender As Object, e As EventArgs) Handles Guna2Txtboxkg.TextChanged
        If Guna2Txtboxkg.Text <> "" AndAlso Val(Guna2Txtboxkg.Text) > 10 Then
            MessageBox.Show("Maximum weight allowed is 10 kg.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Guna2Txtboxkg.Text = "10"
            Guna2Txtboxkg.SelectionStart = Guna2Txtboxkg.Text.Length
        End If
    End Sub

    ' Kapag continue, punta sa invoice form
    Private Sub gbContinue_Click(sender As Object, e As EventArgs) Handles gbContinue.Click
        Dim invoice As New InvoiceForm()

        ' para makabalik kapag nag-back
        invoice.PreviousForm = Me

        ' pasa data papunta sa invoice
        invoice.CustomerName = Guna2TxtboxName.Text
        invoice.ContactNumber = Guna2TxtboxContact.Text
        invoice.Address = txtboxAddress.Text
        invoice.Weight = Guna2Txtboxkg.Text
        invoice.ServiceType = "Full Service"
        invoice.PackageType = "Wash, Dry, Fold"
        invoice.Rate = "₱100/kg"

        ' --- COMPUTATION PART ---
        Dim weight As Double = Val(Guna2Txtboxkg.Text)
        Dim rate As Double = 100
        Dim serviceFee As Double = weight * rate

        ' kung delivery, may 5% fee
        Dim deliveryFee As Double = If(Guna2CheckBoxdelivery.Checked, serviceFee * 0.05, 0)
        Dim totalAmount As Double = serviceFee + deliveryFee

        ' ipasa lahat ng computed values
        invoice.ServiceFee = "₱" & serviceFee.ToString("N2")
        invoice.DeliveryFee = "₱" & deliveryFee.ToString("N2")
        invoice.TotalAmount = "₱" & totalAmount.ToString("N2")
        invoice.DeliveryMode = If(Guna2CheckBoxdelivery.Checked, "Yes", "No")

        ' open invoice form
        invoice.Show()
        Me.Hide()
    End Sub

End Class

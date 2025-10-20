Public Class BasicServiceForm

    ' para sa napiling package (Wash Only, Dry Only, etc.)
    Private packageType As String = ""

    ' kapag pinindot yung cancel button
    Private Sub gbCancel_Click(sender As Object, e As EventArgs) Handles gbCancel.Click
        Me.Close()
    End Sub

    ' kapag delivery ang pinili
    Private Sub Guna2CheckBoxdelivery_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxdelivery.CheckedChanged
        If Guna2CheckBoxdelivery.Checked Then
            Guna2CheckBoxPickUp.Checked = False
            txtboxAddress.Enabled = True   ' pwede maglagay ng address
        End If
    End Sub

    ' kapag pickup ang pinili
    Private Sub Guna2CheckBoxpickup_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxPickUp.CheckedChanged
        If Guna2CheckBoxPickUp.Checked Then
            Guna2CheckBoxdelivery.Checked = False
            txtboxAddress.Enabled = False  ' bawal maglagay ng address
            txtboxAddress.Clear()          ' linisin yung textbox
        End If
    End Sub

    ' para sa contact number na laging may +63 sa unahan
    Private Sub Guna2TxtboxContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2txtboxContact.KeyPress
        ' numbers lang pwede (no letters or symbols)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            Return
        End If

        ' siguraduhin may +63 prefix lagi
        If Not Guna2txtboxContact.Text.StartsWith("+63 ") Then
            Guna2txtboxContact.Text = "+63 "
            Guna2txtboxContact.SelectionStart = Guna2txtboxContact.Text.Length
        End If

        ' kuha lang yung numbers pagkatapos ng +63
        Dim digitsOnly As String = Guna2txtboxContact.Text.Replace("+63 ", "")

        ' bawal magsimula sa 0 (ex: +63 09xx → mali)
        If digitsOnly.Length = 0 AndAlso e.KeyChar = "0"c Then
            e.Handled = True
            Return
        End If

        ' hanggang 10 digits lang after +63
        If digitsOnly.Length >= 10 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' para hindi matanggal yung +63 prefix kahit i-backspace
    Private Sub Guna2TxtboxContact_TextChanged(sender As Object, e As EventArgs) Handles Guna2txtboxContact.TextChanged
        If Not Guna2txtboxContact.Text.StartsWith("+63 ") Then
            Guna2txtboxContact.Text = "+63 "
            Guna2txtboxContact.SelectionStart = Guna2txtboxContact.Text.Length
        End If
    End Sub

    ' para sa weight textbox - numbers lang pwede i-type
    Private Sub Guna2txtboxKg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2txtboxKg.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' limit hanggang 10kg lang
    Private Sub Guna2txtboxKg_TextChanged(sender As Object, e As EventArgs) Handles Guna2txtboxKg.TextChanged
        If Guna2txtboxKg.Text <> "" AndAlso Val(Guna2txtboxKg.Text) > 10 Then
            MessageBox.Show("Max weight is 10 kg lang.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Guna2txtboxKg.Text = "10"
            Guna2txtboxKg.SelectionStart = Guna2txtboxKg.Text.Length
        End If
    End Sub

    ' kapag pumili ng package sa combo box
    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        packageType = Guna2ComboBox1.SelectedItem.ToString()
    End Sub

    ' kapag pinindot yung continue button
    Private Sub gbContinue_Click(sender As Object, e As EventArgs) Handles gbContinue.Click
        ' check muna kung may laman lahat ng important fields
        If Guna2txtboxKg.Text = "" OrElse packageType = "" Then
            MessageBox.Show("Please fill up all fields muna.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' rate per kg depende sa package na pinili
        Dim rate As Decimal
        Select Case packageType
            Case "Wash Only"
                rate = 50
            Case "Dry Only"
                rate = 40
            Case "Wash & Dry"
                rate = 80
            Case Else
                rate = 0
        End Select

        ' compute ng service fee (rate * weight)
        Dim weight As Decimal = Convert.ToDecimal(Guna2txtboxKg.Text)
        Dim serviceFee As Decimal = rate * weight

        ' kung delivery ang pinili, may 5% na dagdag
        Dim deliveryFee As Decimal = If(Guna2CheckBoxdelivery.Checked, serviceFee * 0.05D, 0D)

        ' total = service fee + delivery fee (kung meron)
        Dim totalAmount As Decimal = serviceFee + deliveryFee

        ' ipasa lahat ng data papunta sa invoice form
        Dim invoice As New InvoiceForm()
        invoice.PreviousForm = Me
        invoice.CustomerName = Guna2txtboxName.Text
        invoice.ContactNumber = Guna2txtboxContact.Text
        invoice.Address = txtboxAddress.Text
        invoice.Weight = weight.ToString("F2")
        invoice.ServiceType = "Basic Service"
        invoice.PackageType = packageType
        invoice.Rate = rate.ToString("F2")
        invoice.ServiceFee = "₱" & serviceFee.ToString("N2")
        invoice.DeliveryFee = "₱" & deliveryFee.ToString("N2")
        invoice.TotalAmount = "₱" & totalAmount.ToString("N2")
        invoice.DeliveryMode = If(Guna2CheckBoxdelivery.Checked, "Delivery", "Pickup")

        ' open na yung invoice form
        invoice.Show()
        Me.Hide()
    End Sub
End Class

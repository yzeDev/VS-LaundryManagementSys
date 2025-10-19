Public Class SelfServiceForm

    ' Variable to store selected package type
    Private selectedPackage As String = ""

    ' CANCEL BUTTON
    Private Sub gbCancel_Click(sender As Object, e As EventArgs) Handles gbCancel.Click
        Me.Close()
    End Sub

    ' WEIGHT (KG) - numbers only
    Private Sub Guna2TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox4.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' WEIGHT limit hanggang 10kg lang
    Private Sub Guna2TextBox4_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox4.TextChanged
        If Guna2TextBox4.Text <> "" AndAlso Val(Guna2TextBox4.Text) > 10 Then
            MessageBox.Show("Maximum weight allowed is 10 kg.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Guna2TextBox4.Text = "10"
            Guna2TextBox4.SelectionStart = Guna2TextBox4.Text.Length
        End If
    End Sub

    ' PACKAGE TYPE selection
    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        Select Case Guna2ComboBox1.SelectedItem.ToString()
            Case "Wash Only"
                selectedPackage = "Wash Only"
            Case "Dry Only"
                selectedPackage = "Dry Only"
            Case "Wash & Dry"
                selectedPackage = "Wash & Dry"
            Case Else
                selectedPackage = ""
        End Select
    End Sub

    ' CONTINUE BUTTON - open InvoiceForm
    Private Sub gbContinue_Click(sender As Object, e As EventArgs) Handles gbContinue.Click
        ' Validate inputs
        If Guna2TextBox4.Text = "" Or selectedPackage = "" Then
            MessageBox.Show("Please fill in all required fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Determine rate per kg
        Dim ratePerKg As Decimal
        Select Case selectedPackage
            Case "Wash Only"
                ratePerKg = 40
            Case "Dry Only"
                ratePerKg = 30
            Case "Wash & Dry"
                ratePerKg = 65
            Case Else
                ratePerKg = 0
        End Select

        ' Compute weight, delivery fee, total
        Dim weight As Decimal = Convert.ToDecimal(Guna2TextBox4.Text)
        Dim subtotal As Decimal = ratePerKg * weight


        ' Create and pass data to InvoiceForm
        Dim invoice As New InvoiceForm()
        invoice.PreviousForm = Me
        invoice.CustomerName = Guna2TxtboxName.Text
        invoice.ContactNumber = ""
        invoice.Address = ""
        invoice.Weight = weight
        invoice.ServiceType = "Self Service"
        invoice.PackageType = selectedPackage
        invoice.Rate = ratePerKg

        invoice.TotalAmount = subtotal
        invoice.ServiceFee = "₱" & subtotal.ToString("N2")
        invoice.DeliveryFee = "₱0.00"


        ' Show InvoiceForm
        invoice.Show()
        Me.Hide()
    End Sub

End Class

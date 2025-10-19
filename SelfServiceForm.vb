Public Class SelfServiceForm

    ' Para sa napiling package
    Private packageType As String = ""


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles gbCancel.Click
        Me.Close()
    End Sub


    Private Sub txtWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox4.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Limit weight hanggang 10 kg
    Private Sub txtWeight_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox4.TextChanged
        If Guna2TextBox4.Text <> "" AndAlso Val(Guna2TextBox4.Text) > 10 Then
            MessageBox.Show("Max weight is 10 kg.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Guna2TextBox4.Text = "10"
            Guna2TextBox4.SelectionStart = Guna2TextBox4.Text.Length
        End If
    End Sub

    ' Package selection
    Private Sub cmbPackage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        packageType = Guna2ComboBox1.SelectedItem.ToString()
    End Sub

    ' CONTINUE button - open invoice
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles gbContinue.Click
        ' Check kung may laman weight at package
        If Guna2TextBox4.Text = "" Or packageType = "" Then
            MessageBox.Show("Please fill all fields first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Set rate per kg
        Dim rate As Decimal
        If packageType = "Wash Only" Then
            rate = 40
        ElseIf packageType = "Dry Only" Then
            rate = 30
        ElseIf packageType = "Wash & Dry" Then
            rate = 65
        Else
            rate = 0
        End If

        ' Compute total
        Dim weight As Decimal = Val(Guna2TextBox4.Text)
        Dim total As Decimal = rate * weight

        ' Pass data sa InvoiceForm
        Dim invoice As New InvoiceForm()
        invoice.PreviousForm = Me
        invoice.CustomerName = Guna2TxtboxName.Text
        invoice.Weight = weight
        invoice.ServiceType = "Self Service"
        invoice.PackageType = packageType
        invoice.Rate = rate
        invoice.TotalAmount = total
        invoice.ServiceFee = "₱" & total
        invoice.DeliveryFee = "₱0"

        ' Show invoice
        invoice.Show()
        Me.Hide()
    End Sub

End Class

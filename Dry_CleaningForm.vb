Public Class Dry_CleaningForm

    Private Sub Dry_CleaningForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initially disable the Address textbox and Finish button
        txtboxAddress.Enabled = False
        btnFinish.Enabled = False
    End Sub

    ' Cancel button
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        TransactionOption.Show()
        Me.Hide()
    End Sub

    ' Enable Address only if Delivery is checked
    Private Sub CheckBoxDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDelivery.CheckedChanged
        txtboxAddress.Enabled = CheckBoxDelivery.Checked
        UpdateFinishButton()
    End Sub

    ' Contact textbox - numeric only and max 12 digits
    Private Sub txtboxContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxContact.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtboxContact_TextChanged(sender As Object, e As EventArgs) Handles txtboxContact.TextChanged
        If txtboxContact.Text.Length > 12 Then
            MessageBox.Show("Contact number cannot exceed 12 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtboxContact.Text = txtboxContact.Text.Substring(0, 12)
            txtboxContact.SelectionStart = txtboxContact.Text.Length
        End If
        UpdateFinishButton()
    End Sub

    ' Quantity textbox - numeric only and max 99
    Private Sub txtboxQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxQuantity.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtboxQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtboxQuantity.TextChanged
        Dim value As Integer
        If Integer.TryParse(txtboxQuantity.Text, value) Then
            If value > 99 Then
                MessageBox.Show("Maximum quantity allowed is 99.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtboxQuantity.Text = "99"
                txtboxQuantity.SelectionStart = txtboxQuantity.Text.Length
            End If
        End If
        UpdateFinishButton()
    End Sub

    ' Validate all fields before enabling Finish button
    Private Function AllFieldsValid() As Boolean
        If String.IsNullOrWhiteSpace(txtboxCustomer.Text) Then Return False
        If String.IsNullOrWhiteSpace(txtboxContact.Text) Then Return False
        If String.IsNullOrWhiteSpace(txtboxQuantity.Text) Then Return False
        If ComboBox1.SelectedItem Is Nothing Then Return False
        If CheckBoxDelivery.Checked AndAlso String.IsNullOrWhiteSpace(txtboxAddress.Text) Then Return False
        Return True
    End Function

    ' Update Finish button state
    Private Sub UpdateFinishButton()
        btnFinish.Enabled = AllFieldsValid()
    End Sub

    ' Handle changes on all input fields to update Finish button
    Private Sub InputFields_Changed(sender As Object, e As EventArgs) Handles _
        txtboxCustomer.TextChanged, txtboxContact.TextChanged, txtboxQuantity.TextChanged,
        txtboxAddress.TextChanged, ComboBox1.SelectedIndexChanged
        UpdateFinishButton()
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        InvoiceForm.tbCustomerName.Text = txtboxCustomer.Text
        InvoiceForm.tbContactNumber.Text = txtboxContact.Text
        InvoiceForm.tbAddress.Text = txtboxAddress.Text
        InvoiceForm.Show()
        Me.Hide()

    End Sub
End Class

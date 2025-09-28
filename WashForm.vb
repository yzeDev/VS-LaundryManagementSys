Public Class WashForm

    ' Form Load
    Private Sub WashForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtboxContact.Enabled = False
        CheckBoxDelivery.Enabled = False
        txtboxAddress.Enabled = False

        cmbServiceType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbServiceType.Items.Clear()
        cmbServiceType.Items.Add("Full-Service")
        cmbServiceType.Items.Add("Self-Service")

        btnFinish.Enabled = False
    End Sub

    ' Service Type ComboBox
    Private Sub cmbServiceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServiceType.SelectedIndexChanged
        Dim selected As String = cmbServiceType.SelectedItem?.ToString()

        If selected = "Full-Service" Then
            txtboxContact.Enabled = True
            CheckBoxDelivery.Enabled = True
            txtboxAddress.Enabled = CheckBoxDelivery.Checked
        Else
            ' Self-Service → disable extra fields
            txtboxContact.Enabled = False
            CheckBoxDelivery.Enabled = False
            txtboxAddress.Enabled = False
        End If

        ValidateFinishButton()
    End Sub

    ' Delivery checkbox
    Private Sub CheckBoxDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDelivery.CheckedChanged
        txtboxAddress.Enabled = CheckBoxDelivery.Checked AndAlso (cmbServiceType.SelectedItem?.ToString() <> "Self-Service")
        ValidateFinishButton()
    End Sub

    ' TextBoxes change events - enable Finish button
    Private Sub txtboxCustomerName_TextChanged(sender As Object, e As EventArgs) Handles txtboxCustomerName.TextChanged
        ValidateFinishButton()
    End Sub

    Private Sub txtboxKG_TextChanged(sender As Object, e As EventArgs) Handles txtboxKG.TextChanged
        ' allow only numbers and max 10
        Dim value As Integer
        If Integer.TryParse(txtboxKG.Text, value) Then
            If value > 10 Then
                MessageBox.Show("Maximum KG allowed is 10.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtboxKG.Text = "10"
            End If
        ElseIf txtboxKG.Text <> "" Then
            MessageBox.Show("Please enter numbers only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtboxKG.Clear()
        End If

        ValidateFinishButton()
    End Sub

    ' Contact textbox - numeric only and max 12 digits
    Private Sub txtboxContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxContact.KeyPress
        ' Allow only digits and control keys (like Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtboxContact_TextChanged(sender As Object, e As EventArgs) Handles txtboxContact.TextChanged
        ' Limit to 12 digits
        If txtboxContact.Text.Length > 12 Then
            MessageBox.Show("Contact number cannot exceed 12 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtboxContact.Text = txtboxContact.Text.Substring(0, 12)
            txtboxContact.SelectionStart = txtboxContact.Text.Length
        End If

        ValidateFinishButton()
    End Sub

    Private Sub txtboxAddress_TextChanged(sender As Object, e As EventArgs) Handles txtboxAddress.TextChanged
        ValidateFinishButton()
    End Sub

    ' Enable/Disable Finish button based on required fields
    Private Sub ValidateFinishButton()
        Dim value As Integer
        Dim selected As String = cmbServiceType.SelectedItem?.ToString()

        Dim valid As Boolean = False

        If selected = "Full-Service" Then
            valid = Not String.IsNullOrWhiteSpace(txtboxCustomerName.Text) _
                    AndAlso Integer.TryParse(txtboxKG.Text, value) _
                    AndAlso value > 0 AndAlso value <= 10 _
                    AndAlso Not String.IsNullOrWhiteSpace(txtboxContact.Text) _
                    AndAlso Long.TryParse(txtboxContact.Text, Nothing) _
                    AndAlso (Not CheckBoxDelivery.Checked OrElse Not String.IsNullOrWhiteSpace(txtboxAddress.Text))
        ElseIf selected = "Self-Service" Then
            valid = Not String.IsNullOrWhiteSpace(txtboxCustomerName.Text) _
                    AndAlso Integer.TryParse(txtboxKG.Text, value) _
                    AndAlso value > 0 AndAlso value <= 10
        End If

        btnFinish.Enabled = valid
    End Sub

    Private Sub lblTransactionFormText_Click(sender As Object, e As EventArgs) Handles lblTransactionFormText.Click

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        TransactionOption.Show()
        Me.Hide()
    End Sub

    ' Fixed Finish Button
    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        Dim selected As String = cmbServiceType.SelectedItem?.ToString()
        Dim value As Integer

        If selected = "Full-Service" Then
            If String.IsNullOrWhiteSpace(txtboxCustomerName.Text) OrElse
               Not Integer.TryParse(txtboxKG.Text, value) OrElse value <= 0 OrElse value > 10 OrElse
               String.IsNullOrWhiteSpace(txtboxContact.Text) OrElse
               Not Long.TryParse(txtboxContact.Text, Nothing) OrElse
               (CheckBoxDelivery.Checked AndAlso String.IsNullOrWhiteSpace(txtboxAddress.Text)) Then
                MessageBox.Show("Please complete all required fields for Full-Service.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

        ElseIf selected = "Self-Service" Then
            If String.IsNullOrWhiteSpace(txtboxCustomerName.Text) OrElse
               Not Integer.TryParse(txtboxKG.Text, value) OrElse value <= 0 OrElse value > 10 Then
                MessageBox.Show("Please complete all required fields for Self-Service.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If

        ' If validation passes
        MessageBox.Show("Order submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


        InvoiceForm.tbCustomerName.Text = txtboxCustomerName.Text
        InvoiceForm.tbContactNumber.Text = txtboxContact.Text
        InvoiceForm.tbAddress.Text = txtboxAddress.Text

        InvoiceForm.Show()
        Me.Hide()
    End Sub
End Class

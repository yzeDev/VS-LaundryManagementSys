Public Class Transaction_Form

    ' Form Load
    Private Sub Transaction_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtboxContact.Enabled = False
        CheckBoxDelivery.Enabled = False
        CheckBoxPickup.Enabled = False
        txtboxAddress.Enabled = False


        cmbServiceType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbServiceType.Items.Clear()
        cmbServiceType.Items.Add("Full-Service")
        cmbServiceType.Items.Add("Self-Service")
        cmbServiceType.Items.Add("Dry Cleaning")


        btnFinish.Enabled = False
    End Sub

    ' Service Type ComboBox
    Private Sub cmbServiceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServiceType.SelectedIndexChanged
        Dim selected As String = cmbServiceType.SelectedItem?.ToString()

        If selected = "Full-Service" OrElse selected = "Dry Cleaning" Then
            txtboxContact.Enabled = True
            CheckBoxDelivery.Enabled = True
            CheckBoxPickup.Enabled = True
            txtboxAddress.Enabled = CheckBoxDelivery.Checked
        Else
            ' Self-Service or nothing selected → keep disabled
            txtboxContact.Enabled = False
            CheckBoxDelivery.Enabled = False
            CheckBoxPickup.Enabled = False
            txtboxAddress.Enabled = False
        End If

        ValidateFinishButton()
    End Sub

    ' Delivery checkbox
    Private Sub CheckBoxDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDelivery.CheckedChanged
        txtboxAddress.Enabled = CheckBoxDelivery.Checked AndAlso (cmbServiceType.SelectedItem?.ToString() <> "Self-Service")
        If CheckBoxDelivery.Checked Then CheckBoxPickup.Checked = False
        ValidateFinishButton()
    End Sub

    ' Pickup checkbox
    Private Sub CheckBoxPickup_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPickup.CheckedChanged
        If CheckBoxPickup.Checked Then
            txtboxAddress.Enabled = False
            CheckBoxDelivery.Checked = False
        End If
        ValidateFinishButton()
    End Sub

    ' TextBoxes change events - enable Finish button
    Private Sub txtboxCustomerName_TextChanged(sender As Object, e As EventArgs) Handles txtboxCustomerName.TextChanged
        ValidateFinishButton()
    End Sub

    Private Sub txtboxKG_TextChanged(sender As Object, e As EventArgs) Handles txtboxKG.TextChanged
        ValidateFinishButton()
    End Sub

    Private Sub txtboxContact_TextChanged(sender As Object, e As EventArgs) Handles txtboxContact.TextChanged
        ValidateFinishButton()
    End Sub

    Private Sub txtboxAddress_TextChanged(sender As Object, e As EventArgs) Handles txtboxAddress.TextChanged
        ValidateFinishButton()
    End Sub

    ' Enable/Disable Finish button based on required fields
    Private Sub ValidateFinishButton()
        Dim allFilled As Boolean = Not String.IsNullOrWhiteSpace(txtboxCustomerName.Text) _
                                   AndAlso Not String.IsNullOrWhiteSpace(txtboxKG.Text) _
                                   AndAlso Double.TryParse(txtboxKG.Text, Nothing) _
                                   AndAlso Not String.IsNullOrWhiteSpace(txtboxContact.Text) _
                                   AndAlso Long.TryParse(txtboxContact.Text, Nothing) _
                                   AndAlso (cmbServiceType.SelectedItem IsNot Nothing) _
                                   AndAlso (Not CheckBoxDelivery.Checked OrElse Not String.IsNullOrWhiteSpace(txtboxAddress.Text))

        btnFinish.Enabled = allFilled
    End Sub

End Class

Public Class ChangePasswordControl
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Dim confirmationForm As New passwordChangeConfirmation()

        ' Show the confirmation form
        confirmationForm.ShowDialog()

    End Sub
End Class

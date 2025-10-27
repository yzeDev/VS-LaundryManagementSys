Public Class ExitConfirmForm

    Private Sub exitFormCnclBtn_Click(sender As Object, e As EventArgs) Handles exitFormCnclBtn.Click
        Me.Hide()
        If Me.Parent IsNot Nothing Then
            Me.Parent.Controls.Remove(Me)
        End If
    End Sub

    Private Sub exitFormCloseBtn_Click(sender As Object, e As EventArgs) Handles exitFormCloseBtn.Click
        Application.Exit()
    End Sub

End Class

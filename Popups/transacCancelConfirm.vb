Public Class transacCancelConfirm

    Public Property UserConfirmed As Boolean = False
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        UserConfirmed = True
        Me.Close()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        UserConfirmed = False
        Me.Close()
    End Sub
End Class
Public Class gcashform
    Public Property TotalAmount As String

    Private Sub gcashform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display the total when the form loads
        totalPaymentLbl.Text = TotalAmount
    End Sub

    Private Sub cancelPayBtn_Click(sender As Object, e As EventArgs) Handles cancelPayBtn.Click
        Me.Close()
    End Sub

    Private Sub confirmPaymentBtn_Click(sender As Object, e As EventArgs) Handles confirmPaymentBtn.Click
        Dim confirmForm As New confirmpayment()
        confirmForm.ShowDialog()
    End Sub

End Class

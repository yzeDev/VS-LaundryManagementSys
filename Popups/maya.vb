Public Class maya
    Public Property TotalAmount As Decimal  ' set by caller

    Private Sub maya_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        lblTotalPayment.Text = "₱ " & TotalAmount.ToString("N2")  ' <- ensure you have this label
    End Sub

    Private Sub cancelPayBtn_Click(sender As Object, e As EventArgs) Handles cancelPayBtn.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub confirmPaymentBtn_Click(sender As Object, e As EventArgs) Handles confirmPaymentBtn.Click
        ' User confirms they scanned/paid → proceed to confirm dialog
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class

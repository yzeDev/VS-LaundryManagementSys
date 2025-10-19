Imports System.Transactions

Public Class TransactionOption

    Private Sub btnFullSelfServiceText_Click(sender As Object, e As EventArgs)
        Dim transactionForm As New WashForm
        transactionForm.Show()
        Hide()
    End Sub

    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click
        Close()
    End Sub

    Private Sub btnDryCleaning_Click(sender As Object, e As EventArgs)
        Dry_CleaningForm.Show
        Hide
    End Sub

    Private Sub TransactionOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selfServiceForm As New SelfServiceForm()
        selfServiceForm.ShowDialog()
        Me.Close()
    End Sub
End Class
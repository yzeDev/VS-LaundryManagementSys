Imports System.Transactions

Public Class TransactionOption

    Private Sub btnFullSelfServiceText_Click(sender As Object, e As EventArgs) Handles btnFullSelfServiceText.Click
        Dim transactionForm As New WashForm()


        transactionForm.Show()


        Me.Hide()
    End Sub

    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click

        Me.Hide()


    End Sub

    Private Sub btnDryCleaning_Click(sender As Object, e As EventArgs) Handles btnDryCleaning.Click
        Dry_CleaningForm.Show()
        Me.Hide()
    End Sub
End Class
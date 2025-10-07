Public Class TransactionRow
    Public Property TransactionID As Integer

    Public Sub SetData(transactionId As Integer, customerName As String, serviceType As String,
                       status As String, machineUsed As String, transDate As Date, totalPayment As Decimal)

        transactionId = transactionId
        lblTransactionID.Text = transactionId.ToString()
        lblCustomer.Text = customerName
        lblServiceType.Text = serviceType
        lblStatus.Text = status
        lblMachine.Text = machineUsed
        lblDate.Text = transDate.ToShortDateString()
        lblTotal.Text = "₱" & totalPayment.ToString("N2")

        ' Optional: color code based on status
        Select Case status.ToLower()
            Case "completed" : lblStatus.ForeColor = Color.ForestGreen
            Case "pending" : lblStatus.ForeColor = Color.Orange
            Case "cancelled" : lblStatus.ForeColor = Color.Red
            Case Else : lblStatus.ForeColor = Color.Gray
        End Select
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        ' Open the transaction details
        Dim details As New TransactionDetailsForm(TransactionID,
                                                  lblCustomer.Text,
                                                  lblServiceType.Text,
                                                  lblStatus.Text,
                                                  lblMachine.Text,
                                                  DateTime.Parse(lblDate.Text),
                                                  Decimal.Parse(lblTotal.Text.Replace("₱", "")))
        details.ShowDialog()
    End Sub
End Class

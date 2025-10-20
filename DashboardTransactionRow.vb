Public Class DashboardTransactionRow
    Public Property TransactionID As Integer
    Public Property CustomerName As String
    Public Property ContactNumber As String

    Public Property CurrentStatus As String
    Public Event NotifyClicked(ByVal sender As DashboardTransactionRow)
    Public Event CheckClicked(ByVal sender As DashboardTransactionRow)

    Private Sub btnNotify_Click(sender As Object, e As EventArgs) Handles btnNotify.Click
        RaiseEvent NotifyClicked(Me)
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        RaiseEvent CheckClicked(Me)
    End Sub

    Public Sub SetData(orderId As Integer, customerName As String, contactNo As String, status As String)
        lblOrderID.Text = orderId.ToString()
        lblCustomerName.Text = customerName
        lblContactNo.Text = contactNo
        lblStatus.Text = status
        TransactionID = orderId
        CurrentStatus = status

        btnCheck.Enabled = status.Equals("For Pickup", StringComparison.OrdinalIgnoreCase) OrElse
                           status.Equals("For Delivery", StringComparison.OrdinalIgnoreCase)
        btnCheck.Text = If(btnCheck.Enabled, "Mark Done", "✓")
    End Sub
End Class

Public Class TransactionDetailsForm
    Public Sub New(transactionId As Integer, customerName As String, serviceType As String, status As String, machineUsed As String, transDate As Date, totalPayment As Decimal)
        InitializeComponent()

        lblTransactionIDValue.Text = transactionId.ToString()
        lblCustomerNameValue.Text = customerName
        lblServiceTypeValue.Text = serviceType
        lblStatusValue.Text = status
        lblMachineUsedValue.Text = machineUsed
        lblDateValue.Text = transDate.ToShortDateString()
        lblTotalPaymentValue.Text = totalPayment.ToString("C2")
    End Sub
End Class

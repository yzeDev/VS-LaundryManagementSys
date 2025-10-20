Public Class InvoiceForm

    Public Property PreviousForm As Form

    ' Customer details
    Public Property CustomerName As String
    Public Property ContactNumber As String
    Public Property Address As String
    Public Property Weight As String
    Public Property ServiceType As String
    Public Property PackageType As String
    Public Property Rate As String
    Public Property ServiceFee As String
    Public Property DeliveryFee As String
    Public Property TotalAmount As String
    Public Property DeliveryMode As String

    Private Sub InvoiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display data on labels/textboxes
        customerNameLbl.Text = CustomerName
        contactNoLbl.Text = ContactNumber
        addressTxtBox.Text = Address
        weightLbl.Text = Weight
        serviceTypeLbl.Text = ServiceType
        packageTypeLbl.Text = PackageType
        rateLbl.Text = Rate
        serviceFeeLbl.Text = ServiceFee
        deliveryFeeLbl.Text = DeliveryFee
        totalAmountLbl.Text = TotalAmount
        deliveryIndicator.Text = DeliveryMode
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        ' If PreviousForm is already known, show it directly
        If PreviousForm IsNot Nothing Then
            PreviousForm.Show()
        Else
            ' Fallback: detect form based on service type
            Select Case serviceTypeLbl.Text
                Case "Full Service"
                    FullServiceForm.Show()
                Case "Self Service"
                    SelfServiceForm.Show()
                Case "Basic Service"
                    BasicServiceForm.Show()
                Case "Dry Cleaning"
                    DryCleaningForm.Show()
            End Select
        End If

        Me.Hide() ' hide instead of close to preserve data
    End Sub

    Private Sub packageTypeLbl_Click(sender As Object, e As EventArgs) Handles packageTypeLbl.Click

    End Sub


    ' para po sya sa payment method
    Private selectedPayment As String = ""

    Private Sub cashBtn_Click(sender As Object, e As EventArgs) Handles cashBtn.Click
        selectedPayment = "Cash"
    End Sub

    Private Sub GCashBtn_Click(sender As Object, e As EventArgs) Handles GCashBtn.Click
        selectedPayment = "GCash"
    End Sub

    Private Sub mayaBtn_Click(sender As Object, e As EventArgs) Handles mayaBtn.Click
        selectedPayment = "Maya"
    End Sub

    Private Sub confirmPayBtn_Click(sender As Object, e As EventArgs) Handles confirmPayBtn.Click
        If selectedPayment = "" Then
            MessageBox.Show("Pumili muna ng payment method bago mag-confirm.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Select Case selectedPayment
            Case "GCash"
                Dim gcashForm As New gcashform()
                gcashForm.ShowDialog()

            Case "Maya"
                Dim mayaForm As New maya()
                mayaForm.ShowDialog()

            Case "Cash"
                MessageBox.Show("Cash payment selected. Proceed ka na sa cashier.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
End Class

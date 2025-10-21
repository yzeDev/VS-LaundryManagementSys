Public Class InvoiceForm


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


End Class

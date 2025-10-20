Imports System.Data.SqlTypes

Public Class Receipt
    ' --- Public properties to receive data ---
    Public Property CustomerName As String
    Public Property ContactNumber As String
    Public Property Address As String
    Public Property ServiceType As String
    Public Property PackageType As String
    Public Property Rate As String
    Public Property Weight As String
    Public Property ServiceFee As String
    Public Property DeliveryFee As String
    Public Property TotalAmount As String
    Public Property PaymentMethod As String
    Public Property DeliveryMode As String

    Private Sub Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' --- Populate labels with data ---
        lblName.Text = CustomerName
        lblContact.Text = ContactNumber
        lblAddress.Text = Address
        lblServiceType.Text = ServiceType
        lblPackage.Text = PackageType
        lblRate.Text = Rate
        lblWeight.Text = Weight
        lblServiceFee.Text = ServiceFee
        lblDeliveryFee.Text = DeliveryFee
        lblTotalAmount.Text = TotalAmount
        lblPaymentMethod.Text = PaymentMethod

        ' --- Status logic ---
        If ServiceType = "Self Service" OrElse String.IsNullOrEmpty(DeliveryMode) Then
            lblStatus.Text = "N/A"
        Else
            lblStatus.Text = DeliveryMode
        End If


    End Sub
End Class

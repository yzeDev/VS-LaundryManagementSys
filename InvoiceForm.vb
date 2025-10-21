Public Class InvoiceForm
    ' Property to remember the previous form (the one that opened this Invoice)
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
        ' Initialization code here
    End Sub


End Class

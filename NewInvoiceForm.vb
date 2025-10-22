Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Security.Policy
Imports Guna.UI2.WinForms

Public Class NewInvoiceForm



    Public ReadOnly Property InvoiceCustomerName As String
        Get
            Return lblName.Text
        End Get
    End Property

    Public ReadOnly Property InvoiceContactNumber As String
        Get
            Return lblContact.Text
        End Get
    End Property

    Public ReadOnly Property InvoiceAddress As String
        Get
            Return addressBox.Text
        End Get
    End Property

    Public ReadOnly Property InvoiceWeight As String
        Get
            Return lblWeight.Text
        End Get
    End Property

    Public ReadOnly Property InvoiceServiceType As String
        Get
            Return lblServiceType.Text
        End Get
    End Property

    Public ReadOnly Property InvoicePackageType As String
        Get
            Return lblPackage.Text
        End Get
    End Property

    Public ReadOnly Property InvoiceRate As String
        Get
            Return lblRate.Text
        End Get
    End Property

    Public ReadOnly Property InvoiceServiceFee As String
        Get
            Return lblServiceFee.Text
        End Get
    End Property

    Public ReadOnly Property InvoiceDeliveryFee As String
        Get
            Return lblDeliveryFee.Text
        End Get
    End Property

    Public ReadOnly Property InvoiceTotalAmount As String
        Get
            Return lblTotal.Text
        End Get
    End Property

    Public ReadOnly Property InvoiceDeliveryMode As String
        Get
            Return lblDelivery.Text
        End Get
    End Property

    Public ReadOnly Property InvoicePaymentMethod As String
        Get
            Return selectedPayment
        End Get
    End Property



    ' === DLL for caret hiding ===
    <DllImport("user32.dll")>
    Private Shared Function HideCaret(ByVal hWnd As IntPtr) As Boolean
    End Function

    ' === BORDER COLORS ===
    Private ReadOnly SelectedBorderColor As Color = Color.FromArgb(175, 213, 253)
    Private ReadOnly UnselectedBorderColor As Color = Color.FromArgb(195, 217, 240)
    Private ReadOnly BorderSize As Integer = 2
    Private ReadOnly DefaultBorderSize As Integer = 1

    ' === PAYMENT METHOD VARIABLE ===
    Private selectedPayment As String = ""

    ' === RECEIVED DATA (from service forms) ===
    Public Property PreviousForm As Form
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



    ' === HIDE CARET EVENTS ===
    Private Sub addressBox_GotFocus(sender As Object, e As EventArgs) Handles addressBox.GotFocus
        HideCaret(addressBox.Handle)
    End Sub

    Private Sub addressBox_MouseDown(sender As Object, e As MouseEventArgs) Handles addressBox.MouseDown
        Me.BeginInvoke(New Action(Sub() HideCaret(addressBox.Handle)))
    End Sub

    ' === SELECTED BUTTON BORDER EFFECT ===
    Private Sub SetPaymentMethod(ByVal selectedButton As Guna2Button)
        ' Reset all buttons
        cashBtn.BorderColor = UnselectedBorderColor
        cashBtn.BorderThickness = DefaultBorderSize

        GCashBtn.BorderColor = UnselectedBorderColor
        GCashBtn.BorderThickness = DefaultBorderSize

        mayaBtn.BorderColor = UnselectedBorderColor
        mayaBtn.BorderThickness = DefaultBorderSize

        ' Highlight selected
        selectedButton.BorderColor = SelectedBorderColor
        selectedButton.BorderThickness = BorderSize

        ' Store payment name
        selectedPayment = selectedButton.Text

        ' Enable confirm button
        selectBtn.Enabled = True
    End Sub

    ' === FORM LOAD (Display received data + default setup) ===
    Private Sub NewInvoiceForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        addressBox.SelectionStart = 0
        addressBox.SelectionLength = 0
        CloseBtn.Focus()

        ' SET CASH AS DEFAULT SELECTED PAYMENT METHOD
        SetPaymentMethod(cashBtn)

        ' DISPLAY DATA RECEIVED FROM PREVIOUS FORM
        lblName.Text = CustomerName
        lblContact.Text = ContactNumber
        addressBox.Text = Address
        lblWeight.Text = Weight
        lblServiceType.Text = ServiceType
        lblPackage.Text = PackageType
        lblRate.Text = Rate
        lblServiceFee.Text = ServiceFee
        lblDeliveryFee.Text = DeliveryFee
        lblTotal.Text = TotalAmount
        lblDelivery.Text = DeliveryMode
    End Sub

    ' === PAYMENT BUTTONS ===


    Private Sub cashBtn_Click(sender As Object, e As EventArgs) Handles cashBtn.Click
        SetPaymentMethod(cashBtn)
    End Sub

    Private Sub GCashBtn_Click(sender As Object, e As EventArgs) Handles GCashBtn.Click
        SetPaymentMethod(GCashBtn)
    End Sub

    Private Sub mayaBtn_Click(sender As Object, e As EventArgs) Handles mayaBtn.Click
        SetPaymentMethod(mayaBtn)
    End Sub

    ' === CLOSE & BACK ===
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If PreviousForm IsNot Nothing Then
            PreviousForm.Show()
        Else
            ' fallback detection based on service type
            Select Case lblServiceType.Text
                Case "Full Service" : FullServiceForm.Show()
                Case "Self Service" : SelfServiceForm.Show()
                Case "Basic Service" : BasicServiceForm.Show()
                Case "Dry Cleaning" : DryCleaningForm.Show()
            End Select
        End If
        Me.Hide()
    End Sub

    ' === CONFIRM PAYMENT ===
    Private Sub selectBtn_Click(sender As Object, e As EventArgs) Handles selectBtn.Click
        If selectedPayment = "" Then
            MessageBox.Show("Please select a payment method first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' === Handle Payment Method Forms ===
        Select Case selectedPayment
            Case GCashBtn.Text
                Dim gcashForm As New gcashform()
                gcashForm.TotalAmount = lblTotal.Text
                gcashForm.ShowDialog()

            Case mayaBtn.Text
                Dim mayaForm As New maya()
                mayaForm.ShowDialog()

            Case "Cash"
                MessageBox.Show("Cash payment selected. Proceed to cashier.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select


        ' === CREATE RECEIPT AND PASS VALUES FROM THIS FORM ===
        Dim receipt As New Receipt()
        receipt.CustomerName = lblName.Text
        receipt.ContactNumber = Convert.ToInt64(lblContact.Text) ' Number type in DB
        receipt.Address = addressBox.Text
        receipt.Weight = Convert.ToDecimal(lblWeight.Text.Replace(" kg", "")) ' Number
        receipt.ServiceType = lblServiceType.Text
        receipt.PackageType = lblPackage.Text
        receipt.Rate = Convert.ToDecimal(lblRate.Text.Replace("₱", "").Replace("/kg", ""))
        receipt.ServiceFee = Convert.ToDecimal(lblServiceFee.Text.Replace("₱", ""))
        receipt.DeliveryFee = Convert.ToDecimal(lblDeliveryFee.Text.Replace("₱", ""))
        receipt.TotalAmount = Convert.ToDecimal(lblTotal.Text.Replace("₱", ""))
        receipt.PaymentMethod = selectedPayment
        receipt.DeliveryMode = lblDelivery.Text
        receipt.AmountReceived = 0D ' Set when actual payment is received
        receipt.Change = 0D

        ' === SAVE TO DATABASE ===
        receipt.SaveToDatabase()

        ' === SHOW RECEIPT FORM ===
        receipt.Show()
        Me.Hide()
    End Sub


End Class

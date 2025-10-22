Imports System.Runtime.InteropServices
Imports System.Drawing
Imports Guna.UI2.WinForms

Public Class NewInvoiceForm







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

        Select Case selectedPayment
            Case "GCash"
                Dim gcashForm As New gcashform()
                gcashForm.ShowDialog()

            Case "Maya"
                Dim mayaForm As New maya()
                mayaForm.ShowDialog()

            Case "Cash"
                MessageBox.Show("Cash payment selected. Proceed to cashier.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select

        ' === PASS DATA TO RECEIPT ===
        'Dim receipt As New Receipt()
        'Receipt.CustomerName = lblName.Text
        'receipt.ContactNumber = lblContact.Text
        'receipt.Address = addressBox.Text
        'receipt.Weight = lblWeight.Text
        'receipt.ServiceType = lblServiceType.Text
        'receipt.PackageType = lblPackage.Text
        'receipt.Rate = lblRate.Text
        'receipt.ServiceFee = lblServiceFee.Text
        'receipt.DeliveryFee = lblDeliveryFee.Text
        'receipt.TotalAmount = lblTotal.Text
        'receipt.PaymentMethod = selectedPayment

        '' delivery logic
        'If lblServiceType.Text = "Self Service" Then
        '    receipt.DeliveryMode = "N/A"
        'Else
        '    receipt.DeliveryMode = lblDelivery.Text
        'End If

        Receipt.Show()
        Me.Hide()
    End Sub

End Class

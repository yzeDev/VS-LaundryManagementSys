Imports System.Drawing
Imports System.Runtime.InteropServices
Imports Guna.UI2.WinForms

Public Class NewInvoiceForm
    Private _referenceNumber As String = ""
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


    <DllImport("user32.dll")> Private Shared Function HideCaret(ByVal hWnd As IntPtr) As Boolean
    End Function

    Private ReadOnly SelectedBorderColor As Color = Color.FromArgb(175, 213, 253)
    Private ReadOnly UnselectedBorderColor As Color = Color.FromArgb(195, 217, 240)
    Private ReadOnly BorderSize As Integer = 2
    Private ReadOnly DefaultBorderSize As Integer = 1

    Private selectedPayment As String = ""

    ' data from previous form
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

    Public Property OptionType As String

    ' caret hiding
    Private Sub addressBox_GotFocus(sender As Object, e As EventArgs) Handles addressBox.GotFocus
        HideCaret(addressBox.Handle)
    End Sub
    Private Sub addressBox_MouseDown(sender As Object, e As MouseEventArgs) Handles addressBox.MouseDown
        Me.BeginInvoke(New Action(Sub() HideCaret(addressBox.Handle)))
    End Sub

    ' select/highlight payment
    Private Sub SetPaymentMethod(ByVal selectedButton As Guna2Button)
        cashBtn.BorderColor = UnselectedBorderColor : cashBtn.BorderThickness = DefaultBorderSize
        GCashBtn.BorderColor = UnselectedBorderColor : GCashBtn.BorderThickness = DefaultBorderSize
        mayaBtn.BorderColor = UnselectedBorderColor : mayaBtn.BorderThickness = DefaultBorderSize

        selectedButton.BorderColor = SelectedBorderColor
        selectedButton.BorderThickness = BorderSize

        selectedPayment = selectedButton.Text
        selectBtn.Enabled = True
    End Sub

    ' load received data
    Private Sub NewInvoiceForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        addressBox.SelectionStart = 0
        addressBox.SelectionLength = 0
        CloseBtn.Focus()

        ' default payment: cash
        SetPaymentMethod(cashBtn)

        ' display received data
        lblName.Text = CustomerName
        lblContact.Text = ContactNumber
        addressBox.Text = Address
        lblWeight.Text = Weight
        lblServiceType.Text = ServiceType
        lblPackage.Text = PackageType
        'lblOptionType.Text = OptionType
        lblRate.Text = Rate
        lblServiceFee.Text = ServiceFee
        lblDeliveryFee.Text = DeliveryFee
        lblTotal.Text = TotalAmount
        lblDelivery.Text = DeliveryMode
    End Sub

    ' payment buttons
    Private Sub cashBtn_Click(sender As Object, e As EventArgs) Handles cashBtn.Click
        SetPaymentMethod(cashBtn)
    End Sub
    Private Sub GCashBtn_Click(sender As Object, e As EventArgs) Handles GCashBtn.Click
        SetPaymentMethod(GCashBtn)
    End Sub
    Private Sub mayaBtn_Click(sender As Object, e As EventArgs) Handles mayaBtn.Click
        SetPaymentMethod(mayaBtn)
    End Sub

    ' close X
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    ' ✅ Go Back: restore previous form (or owner), then close this dialog
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If PreviousForm IsNot Nothing AndAlso Not PreviousForm.IsDisposed Then
            PreviousForm.Show()
        ElseIf Me.Owner IsNot Nothing AndAlso Not Me.Owner.IsDisposed Then
            Me.Owner.Show()
        End If
        Me.Close()
    End Sub

    ' confirm payment → save → show receipt → close invoice
    Private Sub selectBtn_Click(sender As Object, e As EventArgs) Handles selectBtn.Click
        If String.IsNullOrWhiteSpace(selectedPayment) Then
            MessageBox.Show("Please select a payment method first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Parse total amount
        Dim totalDec As Decimal = 0D
        Decimal.TryParse(lblTotal.Text.Replace("₱", "").Trim(), totalDec)

        Dim refNo As String = ""
        Dim amountPaid As Decimal = 0D

        ' === DIGITAL PAYMENTS (GCash / Maya) ===
        If selectedPayment = GCashBtn.Text OrElse selectedPayment = mayaBtn.Text Then

            ' 1) Show QR form
            If selectedPayment = GCashBtn.Text Then
                Using qr As New gcashform()
                    qr.TotalAmount = totalDec
                    If qr.ShowDialog(Me) <> DialogResult.OK Then Exit Sub
                End Using
            Else
                Using qr As New maya()
                    qr.TotalAmount = totalDec
                    If qr.ShowDialog(Me) <> DialogResult.OK Then Exit Sub
                End Using
            End If

            ' 2) Confirm payment (reference + amount paid)
            Using dlg As New confirmpayment()
                dlg.PaymentMethod = selectedPayment
                dlg.TotalAmount = totalDec
                dlg.StartPosition = FormStartPosition.CenterParent

                ' Show form (Reference + Amount)
                If dlg.ShowDialog(Me) <> DialogResult.OK Then Exit Sub

                refNo = dlg.ReferenceNumber
                amountPaid = dlg.AmountPaid
            End Using

            ' 3) Payment successful popup
            Dim previewId As Long = GetNextTransactionIdEstimate()
            Using ps As New PaymentSuccessful()
                ps.PaymentMethod = selectedPayment
                ps.TransactionID = previewId
                ps.Timestamp = DateTime.Now
                ps.AmountPaid = amountPaid
                ps.StartPosition = FormStartPosition.CenterParent
                If ps.ShowDialog(Me) <> DialogResult.OK Then Exit Sub
            End Using

        ElseIf selectedPayment = cashBtn.Text Then
            ' === CASH PAYMENT ===
            ' Use the same ConfirmPayment form, but disable Reference textbox
            Using dlg As New confirmpayment()
                dlg.PaymentMethod = selectedPayment
                dlg.TotalAmount = totalDec
                dlg.StartPosition = FormStartPosition.CenterParent

                ' Disable Reference textbox for cash payments
                dlg.referencetb.Enabled = False
                dlg.referencetb.Text = "(N/A)"

                If dlg.ShowDialog(Me) <> DialogResult.OK Then Exit Sub

                ' Only capture amount paid
                refNo = ""
                amountPaid = dlg.AmountPaid
            End Using

            ' Payment successful popup (optional)
            Dim previewId As Long = GetNextTransactionIdEstimate()
            Using ps As New PaymentSuccessful()
                ps.PaymentMethod = selectedPayment
                ps.TransactionID = previewId
                ps.Timestamp = DateTime.Now
                ps.AmountPaid = amountPaid
                ps.StartPosition = FormStartPosition.CenterParent
                If ps.ShowDialog(Me) <> DialogResult.OK Then Exit Sub
            End Using
        End If

        ' === BUILD & SHOW RECEIPT ===
        Dim receiptForm As New Receipt()

        ' Customer info
        receiptForm.CustomerName = lblName.Text
        Dim rawContact As String = lblContact.Text.Trim()
        receiptForm.ContactNumber = If(rawContact = "+63" OrElse rawContact = "", "", rawContact)
        receiptForm.Address = addressBox.Text

        ' Service info
        receiptForm.Weight = Convert.ToDecimal(lblWeight.Text.Replace(" kg", ""))
        receiptForm.ServiceType = lblServiceType.Text
        receiptForm.PackageType = lblPackage.Text

        ' ✅ Include OptionType silently
        receiptForm.OptionType = Me.OptionType

        ' Pricing info
        receiptForm.Rate = Convert.ToDecimal(lblRate.Text.Replace("₱", "").Replace("/kg", ""))
        receiptForm.ServiceFee = Convert.ToDecimal(lblServiceFee.Text.Replace("₱", ""))
        receiptForm.DeliveryFee = Convert.ToDecimal(lblDeliveryFee.Text.Replace("₱", ""))
        receiptForm.TotalAmount = totalDec
        receiptForm.PaymentMethod = selectedPayment
        receiptForm.DeliveryMode = lblDelivery.Text

        ' Payment info
        receiptForm.ReferenceNumber = refNo
        receiptForm.AmountReceived = amountPaid
        receiptForm.ChangeAmount = Math.Max(0D, amountPaid - totalDec)

        ' Timestamp
        receiptForm.TransactionDate = DateTime.Now

        ' Show receipt (it will handle DB save)
        receiptForm.StartPosition = FormStartPosition.CenterParent
        receiptForm.ShowDialog(Me)

        ' Close invoice form
        Me.Close()
    End Sub



    ' Add inside NewInvoiceForm (or a shared utility module)
    Private Function GetNextTransactionIdEstimate() As Long
        Dim nextId As Long = 1
        'Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"
        Try
            Using cn As New OleDb.OleDbConnection(Db.ConnectionString)
                cn.Open()
                Using cmd As New OleDb.OleDbCommand("SELECT MAX(TransactionID) FROM Transactions", cn)
                    Dim v = cmd.ExecuteScalar()
                    If v IsNot Nothing AndAlso Not IsDBNull(v) Then nextId = Convert.ToInt64(v) + 1
                End Using
            End Using
        Catch
            nextId = 1
        End Try
        Return nextId
    End Function


End Class

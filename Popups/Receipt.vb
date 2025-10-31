Imports System.Data.OleDb

Public Class Receipt  ' <-- this is your Receipt FORM

    ' ===== Incoming values from NewInvoiceForm =====
    Public Property ReferenceNumber As String
    Public Property CustomerName As String
    Public Property ContactNumber As String
    Public Property Address As String
    Public Property Weight As Decimal
    Public Property ServiceType As String
    Public Property PackageType As String        ' (not saved to Transactions per your schema)
    Public Property Rate As Decimal              ' (not saved to Transactions per your schema)
    Public Property ServiceFee As Decimal        ' (not saved to Transactions per your schema)
    Public Property DeliveryFee As Decimal       ' (not saved to Transactions per your schema)
    Public Property TotalAmount As Decimal
    Public Property PaymentMethod As String
    Public Property DeliveryMode As String
    Public Property AmountReceived As Decimal
    Public Property ChangeAmount As Decimal      ' avoid conflict with reserved word "Change"
    Public Property TransactionDate As DateTime = DateTime.Now

    ' ===== Internal =====
    Private _transactionId As Long = 0
    Private _saved As Boolean = False

    ' Your Access connection string
    'Private ReadOnly connString As String =
    '   "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"

    ' ===== Form lifecycle =====
    Private Sub Receipt_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' 1) Display current date/time
        lblCurrentDate.Text = TransactionDate.ToString("MMMM dd, yyyy")
        lblCurrentTime.Text = TransactionDate.ToString("h:mm tt")

        ' 2) Display all passed data
        lblName.Text = If(String.IsNullOrWhiteSpace(CustomerName), "—", CustomerName)
        lblContact.Text = If(String.IsNullOrWhiteSpace(ContactNumber), "N/A", ContactNumber)
        lblAddress.Text = If(String.IsNullOrWhiteSpace(Address), "N/A", Address)

        lblServiceType.Text = If(String.IsNullOrWhiteSpace(ServiceType), "—", ServiceType)
        lblRate.Text = If(Rate <= 0, "—", "₱" & Rate.ToString("N2") & "/kg")
        lblWeight.Text = If(Weight > 0, Weight.ToString("F2") & " kg", "—")
        lblStatus.Text = If(String.IsNullOrWhiteSpace(DeliveryMode), "—", DeliveryMode)

        lblServiceFee.Text = "₱" & ServiceFee.ToString("N2")
        lblDeliveryFee.Text = "₱" & DeliveryFee.ToString("N2")
        lblPaymentMethod.Text = If(String.IsNullOrWhiteSpace(PaymentMethod), "—", PaymentMethod)
        lblTotalAmount.Text = "₱" & TotalAmount.ToString("N2")

        ' These may be filled later (e.g. after payment confirmation)
        lbltotalAmountPaid.Text = If(AmountReceived > 0, "₱" & AmountReceived.ToString("N2"), "₱0.00")
        lblChange.Text = If(ChangeAmount > 0, "₱" & ChangeAmount.ToString("N2"), "₱0.00")

        ' 3) Save once and get Transaction ID
        If Not _saved Then
            _transactionId = InsertTransactionAndReturnId()
            _saved = True
        End If

        ' 4) Display the generated Transaction ID
        lblTransactionID.Text = _transactionId.ToString("00000")
    End Sub

    ' ===== DB insert (uses explicit params, brackets reserved names) =====
    Private Function InsertTransactionAndReturnId() As Long
        Dim newId As Long = 0

        Dim sql As String =
            "INSERT INTO Transactions " &
            "(CustomerName, ServiceType, [Status], [TransactionDate], TotalPayment, ContactNumber, [Address], " &
            " PaymentMethod, AmountReceived, [Change], DeliverMethod, [Weight], ReferenceNum) " &
            "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"

        Using cn As New OleDbConnection(Db.ConnectionString)
            cn.Open()
            Using tx = cn.BeginTransaction()
                Using cmd As New OleDbCommand(sql, cn, tx)
                    ' 1 CustomerName (Short Text)
                    cmd.Parameters.Add("?", OleDbType.VarWChar, 255).Value = If(CustomerName, "")

                    ' 2 ServiceType (Short Text)
                    cmd.Parameters.Add("?", OleDbType.VarWChar, 100).Value = If(ServiceType, "")

                    ' 3 Status (Short Text) – choose your preferred status
                    cmd.Parameters.Add("?", OleDbType.VarWChar, 50).Value = "Pending"

                    ' 4 TransactionDate (Date/Time)
                    cmd.Parameters.Add("?", OleDbType.Date).Value = TransactionDate

                    ' 5 TotalPayment (Currency/Number)
                    cmd.Parameters.Add("?", OleDbType.Currency).Value = TotalAmount

                    ' 6 ContactNumber (Long Text in your schema) – send string
                    cmd.Parameters.Add("?", OleDbType.LongVarWChar).Value = If(String.IsNullOrWhiteSpace(ContactNumber), "", ContactNumber)

                    ' 7 Address (Short Text)
                    cmd.Parameters.Add("?", OleDbType.VarWChar, 255).Value = If(Address, "")

                    ' 8 PaymentMethod (Short Text)
                    cmd.Parameters.Add("?", OleDbType.VarWChar, 50).Value = If(PaymentMethod, "")

                    ' 9 AmountReceived (Currency/Number)
                    cmd.Parameters.Add("?", OleDbType.Currency).Value = AmountReceived

                    ' 10 [Change] (Currency/Number) – bracketed, reserved word
                    cmd.Parameters.Add("?", OleDbType.Currency).Value = ChangeAmount

                    ' 11 DeliverMethod (Short Text)
                    cmd.Parameters.Add("?", OleDbType.VarWChar, 50).Value = If(DeliveryMode, "").Trim()

                    ' 12 Weight (Number)
                    cmd.Parameters.Add("?", OleDbType.Double).Value = Convert.ToDouble(Weight)

                    ' 13 ReferenceNum – RECOMMENDED as Short Text in Access
                    cmd.Parameters.Add("?", OleDbType.VarWChar, 20).Value = If(ReferenceNumber, "")

                    cmd.ExecuteNonQuery()
                End Using

                ' Get AutoNumber generated on this connection/transaction
                Using idCmd As New OleDbCommand("SELECT @@IDENTITY", cn, tx)
                    Dim scalar = idCmd.ExecuteScalar()
                    If scalar IsNot Nothing AndAlso Not IsDBNull(scalar) Then
                        newId = Convert.ToInt64(scalar)
                    End If
                End Using

                tx.Commit()
            End Using
        End Using

        Return newId
    End Function

    ' ===== Optional: if you need a preview before saving (not used now) =====
    Private Function GetNextTransactionIdEstimate() As Long
        Dim nextId As Long = 1
        Using cn As New OleDbConnection(Db.ConnectionString)
            cn.Open()
            Using cmd As New OleDbCommand("SELECT MAX(TransactionID) FROM Transactions", cn)
                Dim val = cmd.ExecuteScalar()
                If val IsNot Nothing AndAlso Not IsDBNull(val) Then
                    nextId = Convert.ToInt64(val) + 1
                End If
            End Using
        End Using
        Return nextId
    End Function

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub
End Class

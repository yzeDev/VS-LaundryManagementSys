Imports System.Data.OleDb

Public Class Receipt
    Public Property CustomerName As String
    Public Property ContactNumber As Long
    Public Property Address As String
    Public Property Weight As Decimal
    Public Property ServiceType As String
    Public Property PackageType As String
    Public Property Rate As Decimal
    Public Property ServiceFee As Decimal
    Public Property DeliveryFee As Decimal
    Public Property TotalAmount As Decimal
    Public Property PaymentMethod As String
    Public Property DeliveryMode As String
    Public Property AmountReceived As Decimal
    Public Property Change As Decimal

    ' Save to database
    Public Sub SaveToDatabase()
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\laundryfiles\Resources\LaundryDatabase.accdb;"
        Using conn As New OleDbConnection(connString)
            conn.Open()
            Dim query As String = "INSERT INTO Transactions " &
                                  "(CustomerName, ServiceType, TransactionDate, TotalPayment, ContactNumber, Address, PaymentMethod, AmountReceived, Changed, DeliveryMethod, Weight) " &
                                  "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"


            Using cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("?", CustomerName)
                cmd.Parameters.AddWithValue("?", ServiceType)
                cmd.Parameters.AddWithValue("?", DateTime.Now) ' Real-time transaction
                cmd.Parameters.AddWithValue("?", TotalAmount)
                cmd.Parameters.AddWithValue("?", ContactNumber.ToString())
                cmd.Parameters.AddWithValue("?", Address)
                cmd.Parameters.AddWithValue("?", PaymentMethod)
                cmd.Parameters.AddWithValue("?", AmountReceived)
                cmd.Parameters.AddWithValue("?", Change)
                cmd.Parameters.AddWithValue("?", DeliveryMode)
                cmd.Parameters.AddWithValue("?", Weight)

                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class

Imports System.Data.OleDb

' Put this in a new file: LaundryHelpers.vb
Public Module LaundryHelpers

    ' === Currency formatting helper ===
    <Runtime.CompilerServices.Extension>
    Public Function Peso(amount As Decimal) As String
        Return "₱" & amount.ToString("N2")
    End Function

    ' === Get latest price for a service/subservice ===
    Public Function GetLatestPrice(serviceType As String, subService As String) As Decimal
        Dim price As Decimal = 0D
        Using cn As New OleDbConnection(Db.ConnectionString)
            cn.Open()
            Using cmd As New OleDbCommand("SELECT TOP 1 Price FROM PricingUpd WHERE ServiceType=? AND SubService=? ORDER BY LastUpdated DESC", cn)
                cmd.Parameters.AddWithValue("?", serviceType)
                cmd.Parameters.AddWithValue("?", subService)
                Dim v = cmd.ExecuteScalar()
                If v IsNot Nothing AndAlso Not IsDBNull(v) Then
                    price = Convert.ToDecimal(v)
                End If
            End Using
        End Using
        Return price
    End Function

    ' === Compute fees (returns tuple-like structure) ===
    Public Structure FeeBreakdown
        Public ServiceFee As Decimal
        Public DeliveryFee As Decimal
        Public Total As Decimal
    End Structure

    Public Function ComputeFees(ratePerKg As Decimal, weightKg As Decimal, isDelivery As Boolean) As FeeBreakdown
        Dim svc = ratePerKg * weightKg
        Dim del = If(isDelivery, svc * 0.05D, 0D)
        Return New FeeBreakdown With {.ServiceFee = svc, .DeliveryFee = del, .Total = svc + del}
    End Function

    ' === Optional contact normalizer (keeps string; blank allowed) ===
    Public Function NormalizeOptionalContact(raw As String) As String
        If String.IsNullOrWhiteSpace(raw) Then Return ""
        Dim t = raw.Trim()
        If t = "+63" OrElse t = "+63 " Then Return ""
        Return t ' keep as-is (you store as Long Text)
    End Function

    ' === Preview next Transaction ID (MAX + 1) ===
    Public Function GetNextTransactionIdEstimate() As Long
        Dim nextId As Long = 1
        Try
            Using cn As New OleDbConnection(Db.ConnectionString)
                cn.Open()
                Using cmd As New OleDbCommand("SELECT MAX(TransactionID) FROM Transactions", cn)
                    Dim v = cmd.ExecuteScalar()
                    If v IsNot Nothing AndAlso Not IsDBNull(v) Then nextId = Convert.ToInt64(v) + 1
                End Using
            End Using
        Catch
            nextId = 1
        End Try
        Return nextId
    End Function

    ' === Open the invoice consistently (modal) ===
    Public Sub OpenInvoiceModal(previousForm As Form,
                                customerName As String,
                                contact As String,
                                address As String,
                                weightKg As Decimal,
                                serviceType As String,
                                packageType As String,
                                ratePerKg As Decimal,
                                isDelivery As Boolean)
        Dim fees = ComputeFees(ratePerKg, weightKg, isDelivery)
        Dim deliveryMode = If(isDelivery, "Delivery", "Pickup")

        Using invoice As New NewInvoiceForm()
            invoice.PreviousForm = previousForm
            invoice.CustomerName = customerName
            invoice.ContactNumber = NormalizeOptionalContact(contact)
            invoice.Address = address
            invoice.Weight = weightKg.ToString("F2") & " kg"
            invoice.ServiceType = serviceType
            invoice.PackageType = packageType
            invoice.Rate = ratePerKg.Peso() & "/kg"
            invoice.ServiceFee = fees.ServiceFee.Peso()
            invoice.DeliveryFee = fees.DeliveryFee.Peso()
            invoice.TotalAmount = fees.Total.Peso()
            invoice.DeliveryMode = deliveryMode

            previousForm.Hide()
            invoice.StartPosition = FormStartPosition.CenterParent
            invoice.ShowDialog(previousForm)
            previousForm.Show()
        End Using
    End Sub

End Module

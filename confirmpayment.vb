Imports System.Data.OleDb

Public Class confirmpayment

    ' === LIMIT INPUT TO NUMERIC & MAX 13 DIGITS ===
    Private Sub referencetb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles referencetb.KeyPress
        ' Allow backspace
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        ' Limit to 13 digits
        If referencetb.Text.Length >= 13 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Optional: sanitize pasted input
    Private Sub referencetb_TextChanged(sender As Object, e As EventArgs) Handles referencetb.TextChanged
        Dim numericOnly As String = ""
        For Each c As Char In referencetb.Text
            If Char.IsDigit(c) Then
                numericOnly &= c
            End If
        Next
        If referencetb.Text <> numericOnly Then
            referencetb.Text = numericOnly
            referencetb.SelectionStart = referencetb.Text.Length
        End If
    End Sub

    ' === SAVE TO DATABASE ===
    Private Sub SaveReferenceNumber()
        If referencetb.Text = "" Then
            MessageBox.Show("Reference number is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\laundryfiles\Resources\LaundryDatabase.accdb;"
        Using conn As New OleDbConnection(connString)
            Try
                conn.Open()
                Dim query As String = "UPDATE Transactions SET ReferenceNum = ? WHERE TransactionID = ?" ' Or INSERT if new
                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("?", referencetb.Text)
                    cmd.Parameters.AddWithValue("?", 1) ' Replace 1 with the actual TransactionID
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Reference number saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error saving reference number: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        ' Save reference number first
        SaveReferenceNumber()

        ' Create receipt and copy data from invoice
        Dim receipt As New Receipt()

        ' Make sure the invoice form is still open
        Dim invoice As NewInvoiceForm = Nothing
        If Application.OpenForms().OfType(Of NewInvoiceForm).Any() Then
            invoice = Application.OpenForms().OfType(Of NewInvoiceForm).First()
        End If

        If invoice IsNot Nothing Then
            receipt.CustomerName = invoice.InvoiceCustomerName
            receipt.ContactNumber = invoice.InvoiceContactNumber
            receipt.Address = invoice.InvoiceAddress
            receipt.Weight = invoice.InvoiceWeight
            receipt.ServiceType = invoice.InvoiceServiceType
            receipt.PackageType = invoice.InvoicePackageType
            receipt.Rate = invoice.InvoiceRate
            receipt.ServiceFee = invoice.InvoiceServiceFee
            receipt.DeliveryFee = invoice.InvoiceDeliveryFee
            receipt.TotalAmount = invoice.InvoiceTotalAmount
            receipt.PaymentMethod = invoice.InvoicePaymentMethod
            receipt.DeliveryMode = invoice.InvoiceDeliveryMode
        End If

        ' Save receipt to database
        receipt.SaveToDatabase()

        ' Show receipt form
        receipt.Show()

        ' Close both ConfirmPayment and Invoice forms
        Me.Close()
        If invoice IsNot Nothing Then
            invoice.Close()
        End If
    End Sub




End Class

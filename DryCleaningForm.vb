Imports System.Data.OleDb
Imports Guna.UI2.WinForms

Public Class DryCleaningForm

    ' Get the latest price dynamically from database
    Private Function GetLatestPrice_Basic(subService As String) As Double
        Dim price As Double = 0
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"

        Using conn As New OleDbConnection(connString)
            conn.Open()
            ' ServiceType hardcoded as "Dry Cleaning"
            Dim query As String = "SELECT TOP 1 Price FROM PricingUpd WHERE ServiceType='Dry Cleaning' AND SubService=? ORDER BY LastUpdated DESC"

            Using cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("?", subService)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    price = Convert.ToDouble(result)
                End If
            End Using
        End Using
        Return price
    End Function

    ' ===== FORM LOAD =====
    Private Sub DryCleaningForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display latest rates on label
        Dim SmallPrice As Double = GetLatestPrice_Basic("Small")
        Dim MediumPrice As Double = GetLatestPrice_Basic("Medium")
        Dim LargePrice As Double = GetLatestPrice_Basic("Large")

        lblRate.Text = "• Small: ₱" & SmallPrice.ToString("F0") & " per piece" & Environment.NewLine &
                       "• Medium: ₱" & MediumPrice.ToString("F0") & " per piece" & Environment.NewLine &
                       "• Large: ₱" & LargePrice.ToString("F0") & " per piece"
    End Sub


    Private Sub Guna2CheckBoxdelivery_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxdelivery.CheckedChanged
        If Guna2CheckBoxdelivery.Checked Then
            Guna2CheckBoxPickup.Checked = False
            txtboxAddress.Enabled = True
        End If
    End Sub


    Private Sub Guna2CheckBoxPickup_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxPickup.CheckedChanged
        If Guna2CheckBoxPickup.Checked Then
            Guna2CheckBoxdelivery.Checked = False
            txtboxAddress.Text = ""
            txtboxAddress.Enabled = False
        Else
            txtboxAddress.Enabled = True
        End If
    End Sub


    Private Sub Guna2txtboxContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2txtboxContact.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then e.Handled = True
        Dim txt = Guna2txtboxContact.Text
        If txt.StartsWith("+63 ") Then
            Dim digitsAfterPrefix = txt.Length - 4
            If digitsAfterPrefix >= 10 AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
        End If
    End Sub

    Private Sub Guna2txtboxContact_TextChanged(sender As Object, e As EventArgs) Handles Guna2txtboxContact.TextChanged
        Dim txt = Guna2txtboxContact.Text
        If Not txt.StartsWith("+63 ") Then
            Guna2txtboxContact.Text = "+63 "
            Guna2txtboxContact.SelectionStart = Guna2txtboxContact.Text.Length
        End If

        If txt.Length > 4 Then
            Dim afterPrefix = txt.Substring(4)
            If afterPrefix.StartsWith("0") Then
                MessageBox.Show("Contact number cannot start with 0 after +63.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Guna2txtboxContact.Text = "+63 "
                Guna2txtboxContact.SelectionStart = Guna2txtboxContact.Text.Length
            End If
        End If
    End Sub


    Private Sub Guna2txtboxQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2txtboxQuantity.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub gbCancel_Click(sender As Object, e As EventArgs) Handles gbCancel.Click
        Dim confirmForm As New transacCancelConfirm()
        confirmForm.TopMost = True
        confirmForm.ShowDialog(Me)

        If confirmForm.UserConfirmed Then
            TransactionOption.Show()
            Me.Dispose()
        End If
    End Sub

    ' Continue button kung san nya sinesend sa invoice
    Private Sub gbContinue_Click(sender As Object, e As EventArgs) Handles gbContinue.Click

        If Guna2txtboxName.Text = "" OrElse
           Guna2txtboxContact.Text.Length < 14 OrElse
           Guna2txtboxQuantity.Text = "" OrElse
           gcbClotheSize.SelectedItem Is Nothing Then

            MessageBox.Show("Please fill out all fields properly.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim packageType As String = gcbClotheSize.SelectedItem.ToString()
        Dim rate As Double = GetLatestPrice_Basic(packageType) ' Dynamic rate from DB

        Dim qty As Double = Val(Guna2txtboxQuantity.Text)
        Dim serviceFee As Double = rate * qty
        Dim deliveryFee As Double = If(Guna2CheckBoxdelivery.Checked, serviceFee * 0.05, 0)
        Dim totalAmount As Double = serviceFee + deliveryFee

        ' Pass data to Invoice Form
        Dim invoice As New NewInvoiceForm()
        invoice.PreviousForm = Me
        invoice.ServiceType = "Dry Cleaning"
        invoice.PackageType = packageType
        invoice.CustomerName = Guna2txtboxName.Text
        invoice.ContactNumber = Guna2txtboxContact.Text
        invoice.Address = txtboxAddress.Text
        invoice.Weight = qty
        invoice.Rate = "₱" & rate.ToString("F2")
        invoice.ServiceFee = "₱" & serviceFee.ToString("F2")
        invoice.DeliveryFee = "₱" & deliveryFee.ToString("F2")
        invoice.TotalAmount = "₱" & totalAmount.ToString("F2")
        invoice.DeliveryMode = If(Guna2CheckBoxdelivery.Checked, "Yes", "No")

        invoice.Show()
        Me.Hide()
    End Sub

End Class

Imports System.Data.OleDb
Imports Guna.UI2.WinForms

Public Class BasicServiceForm
    Private packageType As String = ""

    ' Function to get latest price dynamically from DB
    Private Function GetLatestPrice_Basic(subService As String) As Double
        Dim price As Double = 0
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\laundryfiles\Resources\LaundryDatabase.accdb;"

        Using conn As New OleDbConnection(connString)
            conn.Open()
            Dim query As String = "SELECT TOP 1 Price FROM PricingUpd WHERE ServiceType='Basic Service' AND SubService=? ORDER BY LastUpdated DESC"

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


    Private Sub BasicServiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim washOnlyPrice As Double = GetLatestPrice_Basic("Wash Only")
        Dim dryOnlyPrice As Double = GetLatestPrice_Basic("Dry Only")
        Dim washAndDryPrice As Double = GetLatestPrice_Basic("Wash + Dry")

        lblRate.Text =
            "• Wash Only: ₱" & washOnlyPrice.ToString("F0") & "/kg" & Environment.NewLine &
            "• Dry Only: ₱" & dryOnlyPrice.ToString("F0") & "/kg" & Environment.NewLine &
            "• Wash + Dry: ₱" & washAndDryPrice.ToString("F0") & "/kg"
    End Sub



    Private Sub Guna2CheckBoxdelivery_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxdelivery.CheckedChanged
        If Guna2CheckBoxdelivery.Checked Then
            Guna2CheckBoxPickUp.Checked = False
            txtboxAddress.Enabled = True
        End If
    End Sub

    Private Sub Guna2CheckBoxPickUp_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxPickUp.CheckedChanged
        If Guna2CheckBoxPickUp.Checked Then
            Guna2CheckBoxdelivery.Checked = False
            txtboxAddress.Enabled = False
            txtboxAddress.Clear()
        Else
            txtboxAddress.Enabled = True
        End If
    End Sub



    Private Sub Guna2txtboxContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2txtboxContact.KeyPress
        If Guna2txtboxContact.SelectionStart >= 4 Then
            If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Guna2txtboxContact_TextChanged(sender As Object, e As EventArgs) Handles Guna2txtboxContact.TextChanged
        Dim txt = Guna2txtboxContact.Text

        If Not txt.StartsWith("+63 ") Then
            Guna2txtboxContact.Text = "+63 "
            Guna2txtboxContact.SelectionStart = Guna2txtboxContact.Text.Length
            Exit Sub
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



    Private Sub Guna2txtboxWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2txtboxWeight.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Guna2txtboxWeight_TextChanged(sender As Object, e As EventArgs) Handles Guna2txtboxWeight.TextChanged
        Dim weight As Double
        If Double.TryParse(Guna2txtboxWeight.Text, weight) Then
            If weight > 10 Then
                MessageBox.Show("Weight cannot exceed 10 kg.", "Invalid Weight", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Guna2txtboxWeight.Text = ""
            End If
        End If
    End Sub


    Private Sub Guna2cmbServiceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2cmbServiceType.SelectedIndexChanged
        packageType = Guna2cmbServiceType.SelectedItem.ToString()
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


    '  Continue button (Computation + Pass to Invoice)
    Private Sub gbContinue_Click(sender As Object, e As EventArgs) Handles gbContinue.Click

        If Guna2txtboxName.Text = "" OrElse packageType = "" OrElse Guna2txtboxWeight.Text = "" Then
            MessageBox.Show("Please fill out all fields properly.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Dim rate As Decimal = Convert.ToDecimal(GetLatestPrice_Basic(packageType))


        Dim weight As Decimal = Convert.ToDecimal(Guna2txtboxWeight.Text)
        Dim serviceFee As Decimal = rate * weight
        Dim deliveryFee As Decimal = If(Guna2CheckBoxdelivery.Checked, serviceFee * 0.05D, 0D)
        Dim totalAmount As Decimal = serviceFee + deliveryFee

        ' Pass to invoice
        Dim invoice As New NewInvoiceForm()
        invoice.PreviousForm = Me
        invoice.CustomerName = Guna2txtboxName.Text
        invoice.ContactNumber = Guna2txtboxContact.Text
        invoice.Address = txtboxAddress.Text
        invoice.Weight = weight.ToString("F2")
        invoice.ServiceType = "Basic Services"
        invoice.PackageType = packageType
        invoice.Rate = "₱" & rate.ToString("N2")
        invoice.ServiceFee = "₱" & serviceFee.ToString("N2")
        invoice.DeliveryFee = "₱" & deliveryFee.ToString("N2")
        invoice.TotalAmount = "₱" & totalAmount.ToString("N2")
        invoice.DeliveryMode = If(Guna2CheckBoxdelivery.Checked, "Yes", "No")

        ' Show invoice form
        invoice.Show()
        Me.Hide()
    End Sub
End Class

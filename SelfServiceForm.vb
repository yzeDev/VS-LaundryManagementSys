Imports System.Data.OleDb

Public Class SelfServiceForm

    ' Function to get the latest price ng bawat subservice
    Private Function GetLatestPrice(serviceType As String, subService As String) As Double
        Dim price As Double = 0
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\laundryfiles\Resources\LaundryDatabase.accdb;"

        Using conn As New OleDbConnection(connString)
            conn.Open()
            ' Kunin yung pinaka-latest price base sa LastUpdated column
            Dim query As String = "SELECT TOP 1 Price FROM PricingUpd WHERE ServiceType=? AND SubService=? ORDER BY LastUpdated DESC"

            Using cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("?", serviceType)
                cmd.Parameters.AddWithValue("?", subService)

                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    price = Convert.ToDouble(result)
                End If
            End Using
        End Using
        Return price
    End Function

    ' Load event ng form
    Private Sub SelfServiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Kunin ang latest price para sa bawat subservice
        Dim washOnlyPrice As Double = GetLatestPrice("Self Service", "Wash Only")
        Dim dryOnlyPrice As Double = GetLatestPrice("Self Service", "Dry Only")
        Dim washAndDryPrice As Double = GetLatestPrice("Self Service", "Wash + Dry")

        ' I-update ang label text
        lblRate.Text = "• Wash Only: ₱" & washOnlyPrice.ToString("F0") & "/kg" & Environment.NewLine &
                       "• Dry Only: ₱" & dryOnlyPrice.ToString("F0") & "/kg" & Environment.NewLine &
                       "• Wash + Dry: ₱" & washAndDryPrice.ToString("F0") & "/kg"
    End Sub


    ' 📱 Contact textbox: numeric lang after "+63 "
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
        Dim contact As String = Guna2txtboxContact.Text.Trim()

        If Not contact.StartsWith("+63 ") Then
            Guna2txtboxContact.Text = "+63 "
            Guna2txtboxContact.SelectionStart = Guna2txtboxContact.Text.Length
            Exit Sub
        End If

        Dim numberPart As String = contact.Substring(4).Replace(" ", "")
        If numberPart.StartsWith("0") Then
            MessageBox.Show("Contact number should not start with 0 after +63.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Guna2txtboxContact.Text = "+63 "
            Guna2txtboxContact.SelectionStart = Guna2txtboxContact.Text.Length
            Exit Sub
        End If

        If numberPart.Length > 10 Then
            MessageBox.Show("Contact number must have only 10 digits after +63.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            numberPart = numberPart.Substring(0, 10)
        End If

        Guna2txtboxContact.Text = "+63 " & numberPart
        Guna2txtboxContact.SelectionStart = Guna2txtboxContact.Text.Length
    End Sub



    Private Sub Guna2CheckBoxPickup_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxPickup.CheckedChanged
        If Guna2CheckBoxPickup.Checked Then
            Guna2CheckBoxDelivery.Checked = False
            txtboxAddress.Clear()
            txtboxAddress.Enabled = False
        Else
            txtboxAddress.Enabled = True
        End If
    End Sub

    Private Sub Guna2CheckBoxDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxDelivery.CheckedChanged
        If Guna2CheckBoxDelivery.Checked Then
            Guna2CheckBoxPickup.Checked = False
            txtboxAddress.Enabled = True
        End If
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



    Private Sub gbContinue_Click(sender As Object, e As EventArgs) Handles gbContinue.Click

        Dim customerName As String = Guna2TxtboxName.Text.Trim()
        Dim contactNumber As String = Guna2txtboxContact.Text.Trim()
        Dim address As String = txtboxAddress.Text.Trim()
        'Dim weight As String = Guna2txtboxWeight.Text.Trim()
        'Dim packageType As String = Guna2cmbService.Text.Trim()
        Dim serviceType As String = "Self Service"

        'Validate required fields
        If customerName = "" Or contactNumber.Length < 7 Or 'weight = "" Or packageType = "" Then
            MessageBox.Show("Please fill up all required fields correctly.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning) Then
            Return
        End If

        ' Compute service fee
        'Dim rate As Double = GetLatestPrice("Self-Service",) packageType)
        'Dim weightVal As Double = Convert.ToDouble(weight)
        'Dim serviceFee As Double = rate * weightVal
        Dim deliveryFee As Double = 0

        Dim deliveryMode As String = "Pickup"
        If Guna2CheckBoxDelivery.Checked Then
            deliveryFee = 'serviceFee * 0.05
            deliveryMode = "Delivery"
        End If

        'Dim total As Double = serviceFee + deliveryFee

        ' Create and show invoice
        Dim invoice As New NewInvoiceForm()
        invoice.PreviousForm = Me
        invoice.CustomerName = customerName
        invoice.ContactNumber = contactNumber
        invoice.Address = address
        'invoice.Weight = weightVal.ToString("F2") & " kg"
        invoice.ServiceType = serviceType
        invoice.PackageType = 'packageType
        invoice.Rate = "₱" & 'rate.ToString("F2") & "/kg"
        invoice.ServiceFee = "₱" & 'serviceFee.ToString("F2")
        invoice.DeliveryFee = "₱" & deliveryFee.ToString("F2")
        invoice.TotalAmount = "₱" & 'total.ToString("F2")
        invoice.DeliveryMode = deliveryMode

        invoice.Show()
        Me.Hide()
    End Sub

End Class

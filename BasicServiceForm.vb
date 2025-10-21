Imports System.Data.OleDb

Public Class BasicServiceForm

    Private Function GetLatestPrice_Basic(subService As String) As Double
        Dim price As Double = 0
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\laundryfiles\Resources\LaundryDatabase.accdb;"

        Using conn As New OleDbConnection(connString)
            conn.Open()
            ' ServiceType hardcoded as "Basic Services"
            Dim query As String = "SELECT TOP 1 Price FROM Pricing WHERE ServiceType='Basic Services' AND SubService=? ORDER BY LastUpdated DESC"

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
    Private Sub BasicServicesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Kunin ang latest price para sa bawat subservice
        Dim washOnlyPrice As Double = GetLatestPrice_Basic("Wash Only")
        Dim dryOnlyPrice As Double = GetLatestPrice_Basic("Dry Only")
        Dim washAndDryPrice As Double = GetLatestPrice_Basic("Wash + Dry")

        ' I-update ang label text
        lblRate.Text = "• Wash Only: ₱" & washOnlyPrice.ToString("F0") & "/kg" & Environment.NewLine &
                    "• Dry Only: ₱" & dryOnlyPrice.ToString("F0") & "/kg" & Environment.NewLine &
                    "• Wash + Dry: ₱" & washAndDryPrice.ToString("F0") & "/kg"
    End Sub

    Private Sub Guna2CheckBoxPickup_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxPickUp.CheckedChanged
        If Guna2CheckBoxPickUp.Checked Then
            Guna2CheckBoxdelivery.Checked = False ' Uncheck delivery if pickup is checked
            txtboxAddress.Clear()
            txtboxAddress.Enabled = False
        Else
            txtboxAddress.Enabled = True
        End If
    End Sub

    Private Sub Guna2CheckBoxDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxdelivery.CheckedChanged
        If Guna2CheckBoxdelivery.Checked Then
            Guna2CheckBoxPickUp.Checked = False ' Uncheck pickup if delivery is checked
            txtboxAddress.Enabled = True ' Allow address input for delivery
        End If
    End Sub

    'weight
    Private Sub Guna2txtboxWeight_TextChanged(sender As Object, e As EventArgs) Handles Guna2txtboxWeight.TextChanged
        Dim weight As Double
        If Double.TryParse(Guna2txtboxWeight.Text, weight) Then
            If weight > 10 Then
                MessageBox.Show("Weight cannot exceed 10 kg.", "Invalid Weight", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Guna2txtboxWeight.Text = ""
            End If
        ElseIf Guna2txtboxWeight.Text <> "" Then
            MessageBox.Show("Please enter a valid number for weight.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Guna2txtboxWeight.Text = ""
        End If
    End Sub

    Private Sub Guna2txtboxContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2txtboxContact.KeyPress
        ' Prevent typing non-numeric after "+63 "
        If Guna2txtboxContact.SelectionStart >= 4 Then
            If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        Else
            ' Block typing before "+63 "
            e.Handled = True
        End If
    End Sub

    Private Sub Guna2txtboxContact_TextChanged(sender As Object, e As EventArgs) Handles Guna2txtboxContact.TextChanged
        Dim contact As String = Guna2txtboxContact.Text.Trim()

        ' Ensure it starts with "+63 "
        If Not contact.StartsWith("+63 ") Then
            Guna2txtboxContact.Text = "+63 "
            Guna2txtboxContact.SelectionStart = Guna2txtboxContact.Text.Length
            Exit Sub
        End If

        ' Extract digits after "+63 "
        Dim numberPart As String = contact.Substring(4).Replace(" ", "")

        ' If starts with 0, reset
        If numberPart.StartsWith("0") Then
            MessageBox.Show("Contact number should not start with 0 after +63.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Guna2txtboxContact.Text = "+63 "
            Guna2txtboxContact.SelectionStart = Guna2txtboxContact.Text.Length
            Exit Sub
        End If

        ' Limit to 10 digits
        If numberPart.Length > 10 Then
            MessageBox.Show("Contact number must have only 10 digits after +63.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            numberPart = numberPart.Substring(0, 10)
        End If

        ' Rebuild textbox properly
        Guna2txtboxContact.Text = "+63 " & numberPart
        Guna2txtboxContact.SelectionStart = Guna2txtboxContact.Text.Length
    End Sub

    Private Sub gbCancel_Click(sender As Object, e As EventArgs) Handles gbCancel.Click
        Me.Hide()
        TransactionOption.Show()
    End Sub

    Private Sub lblRate_Click(sender As Object, e As EventArgs) Handles lblRate.Click

    End Sub
End Class

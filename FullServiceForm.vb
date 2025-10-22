Imports System.Data.OleDb

Public Class FullServiceForm

    ' Function to get the latest price ng isang service
    Private Function GetLatestPrice(serviceType As String, subService As String) As Double
        Dim price As Double = 0
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"

        Using conn As New OleDbConnection(connString)
            conn.Open()
            ' Kunin yung pinaka-latest price base sa LastUpdated column
            Dim query As String = "SELECT TOP 1 Price FROM Pricing WHERE ServiceType=? AND SubService=? ORDER BY LastUpdated DESC"

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
    Private Sub FullServiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display ang latest rate sa label
        Dim latestPrice As Double = GetLatestPrice("Full Service", "Wash, Dry, and Fold")
        lblRate.Text = "• Wash, Dry, and Fold" & Environment.NewLine & "Rate: ₱" & latestPrice.ToString("F0") & "/kg"
    End Sub


    Private Sub Guna2txtboxWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2txtboxWeight.KeyPress

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If


        If e.KeyChar = "."c AndAlso Guna2txtboxWeight.Text.Contains(".") Then
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
        ElseIf Guna2txtboxWeight.Text <> "" Then
            MessageBox.Show("Please enter a valid number for weight.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Guna2txtboxWeight.Text = ""
        End If
    End Sub

    ' Checkbox logic: pickup disables delivery and address
    Private Sub Guna2CheckBoxPickup_CheckedChanged(sender As Object, e As EventArgs)
        If Guna2CheckBoxPickup.Checked Then
            Guna2CheckBoxDelivery.Checked = False ' Uncheck delivery if pickup is checked
            txtboxAddress.Clear()
            txtboxAddress.Enabled = False
        Else
            txtboxAddress.Enabled = True
        End If
    End Sub

    ' Checkbox logic: delivery disables pickup
    Private Sub Guna2CheckBoxDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxDelivery.CheckedChanged
        If Guna2CheckBoxDelivery.Checked Then
            Guna2CheckBoxPickup.Checked = False ' Uncheck pickup if delivery is checked
            txtboxAddress.Enabled = True ' Allow address input for delivery
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


    Private Sub gbCancel_Click(sender As Object, e As EventArgs)
        Hide()
        TransactionOption.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub
End Class

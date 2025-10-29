Imports System.Data.OleDb

Public Class confirmpayment
    ' Context from caller
    Public Property PaymentMethod As String
    Public Property TotalAmount As Decimal

    ' Returned to caller
    Public ReadOnly Property ReferenceNumber As String
        Get
            Return referencetb.Text
        End Get
    End Property

    Public ReadOnly Property AmountPaid As Decimal
        Get
            Dim val As Decimal
            Decimal.TryParse(gtbAmountPaid.Text.Replace(",", "").Trim(), val)
            Return val
        End Get
    End Property

    ' --- Reference: digits only, max 13
    Private Sub referencetb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles referencetb.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then e.Handled = True
        If referencetb.Text.Length >= 13 AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub referencetb_TextChanged(sender As Object, e As EventArgs) Handles referencetb.TextChanged
        Dim numericOnly = New String(referencetb.Text.Where(AddressOf Char.IsDigit).ToArray())
        If numericOnly.Length > 13 Then numericOnly = numericOnly.Substring(0, 13)
        If referencetb.Text <> numericOnly Then
            referencetb.Text = numericOnly
            referencetb.SelectionStart = referencetb.Text.Length
        End If
    End Sub

    ' --- Amount Paid: numeric/currency only
    Private Sub gtbAmountPaid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gtbAmountPaid.KeyPress
        ' allow digits, one dot, and control keys
        If Char.IsControl(e.KeyChar) Then Return
        If Char.IsDigit(e.KeyChar) Then Return
        If e.KeyChar = "."c AndAlso Not gtbAmountPaid.Text.Contains("."c) Then Return
        e.Handled = True
    End Sub

    Private Sub gtbAmountPaid_Leave(sender As Object, e As EventArgs) Handles gtbAmountPaid.Leave
        Dim val As Decimal
        If Decimal.TryParse(gtbAmountPaid.Text.Replace(",", "").Trim(), val) Then
            gtbAmountPaid.Text = val.ToString("N2")
        Else
            gtbAmountPaid.Text = ""
        End If
    End Sub

    Private Sub confirmpayment_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Display payment context
        If lblAmountToPay IsNot Nothing Then
            lblAmountToPay.Text = "Amount to Pay: ₱ " & Math.Max(0D, TotalAmount).ToString("N2")
        End If

        ' Optional: if you have a label for method
        ' If lblPayMethod IsNot Nothing Then lblPayMethod.Text = PaymentMethod

        referencetb.Focus()
    End Sub

    ' SAVE (OK)
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Ref no. validation
        If String.IsNullOrWhiteSpace(referencetb.Text) OrElse referencetb.Text.Length <> 13 Then
            MessageBox.Show("Please enter a 13-digit reference number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Amount paid validation: require >= Total
        Dim paid As Decimal
        If Not Decimal.TryParse(gtbAmountPaid.Text.Replace(",", "").Trim(), paid) Then
            MessageBox.Show("Please enter a valid amount paid.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If paid < TotalAmount Then
            MessageBox.Show("Amount paid cannot be less than the total due.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Success → return OK
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class

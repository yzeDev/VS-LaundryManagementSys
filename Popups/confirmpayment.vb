Imports System.Data.OleDb

Public Class confirmpayment
    ' Context from caller
    Public Property PaymentMethod As String
    Public Property TotalAmount As Decimal

    ' Returned to caller
    Public ReadOnly Property ReferenceNumber As String
        Get
            Return referencetb.Text.Trim()
        End Get
    End Property

    Public ReadOnly Property AmountPaid As Decimal
        Get
            Dim val As Decimal
            Decimal.TryParse(gtbAmountPaid.Text.Replace(",", "").Trim(), val)
            Return val
        End Get
    End Property

    ' --- Reference: digits only, max 13 ---
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

    ' --- Amount Paid: numeric/currency only ---
    Private Sub gtbAmountPaid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gtbAmountPaid.KeyPress
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

    ' --- When form shows ---
    Private Sub confirmpayment_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Display payment context
        lblAmountToPay.Text = "Amount to Pay: ₱ " & Math.Max(0D, TotalAmount).ToString("N2")
        lblPayMethod.Text = "Payment Method: " & PaymentMethod

        ' Adjust reference box based on method
        If PaymentMethod.Trim.ToLower() = "cash" Then
            referencetb.Enabled = False
            referencetb.Text = ""
            lblReference.Text = "Reference Number (N/A for Cash)"
            lblReference.ForeColor = Color.Gray
        Else
            referencetb.Enabled = True
            lblReference.Text = "Reference Number (13 digits)"
            lblReference.ForeColor = Color.Black
        End If

        ' Focus on amount box
        gtbAmountPaid.Focus()
    End Sub

    ' --- SAVE / Confirm button ---
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' ========== VALIDATION SECTION ==========

        ' 1. Amount paid validation
        Dim paid As Decimal
        If Not Decimal.TryParse(gtbAmountPaid.Text.Replace(",", "").Trim(), paid) Then
            MessageBox.Show("Please enter a valid amount paid.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            gtbAmountPaid.Focus()
            Exit Sub
        End If

        If paid <= 0 Then
            MessageBox.Show("Amount paid must be greater than zero.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            gtbAmountPaid.Focus()
            Exit Sub
        End If

        If paid < TotalAmount Then
            MessageBox.Show("Amount paid cannot be less than the total due.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            gtbAmountPaid.Focus()
            Exit Sub
        End If

        ' 2. Reference validation (required only for GCash / Maya)
        Dim methodLower = PaymentMethod.Trim().ToLower()

        If methodLower.Contains("gcash") OrElse methodLower.Contains("maya") Then
            If String.IsNullOrWhiteSpace(referencetb.Text) OrElse referencetb.Text.Length <> 13 Then
                MessageBox.Show("Please enter a valid 13-digit reference number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                referencetb.Focus()
                Exit Sub
            End If
        End If

        ' For Cash, we skip the reference check

        ' ========== SUCCESS ==========
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    ' --- CANCEL button ---
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class

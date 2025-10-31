Imports System.Data.OleDb

Public Class TransactionForm

    Public Property Mode As String = "View" ' "View" or "Edit"
    Public Property TransactionId As Integer

    'Private connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\source\repos\LaundryManagementSys\LaundryDatabase.accdb;"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub TransactionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ✅ Always fill combo options first
        cbService.Items.Clear()
        cbService.Items.AddRange({"Self-Service", "Full-Service", "Dry Cleaning"})

        cbStatus.Items.Clear()
        cbStatus.Items.AddRange({"Completed", "Pending", "Refunded", "For Pickup", "For Delivery"})

        ' ✅ Show mode + transaction ID in subtitle
        lblMode.Text = $"{Mode} Mode"
        lblSubtitle.Text = $"Transaction #{TransactionId}"

        ' ✅ Load transaction data if available
        If TransactionId > 0 Then
            LoadTransactionData()
        End If

        ' ✅ Apply mode-based UI behavior
        Select Case Mode
            Case "View"
                ApplyReadOnlyMode(True)
                btnSave.Visible = False
                btnCancel.Text = "Close"

            Case "Edit"
                ApplyReadOnlyMode(False)
                btnSave.Visible = True
                btnCancel.Text = "Cancel"
        End Select
    End Sub

    ' ✅ Loads transaction info from database
    Private Sub LoadTransactionData()
        Using conn As New OleDbConnection(Db.ConnectionString)
            conn.Open()
            Dim sql As String = "SELECT * FROM Transactions WHERE TransactionID=@id"
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", TransactionId)
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        tbCustomerName.Text = reader("CustomerName").ToString()
                        cbService.Text = reader("ServiceType").ToString()
                        tbContactNum.Text = reader("ContactNumber").ToString()
                        tbAddress.Text = reader("Address").ToString()
                        cbStatus.Text = reader("Status").ToString()
                        tbMachineUsed.Text = reader("MachineUsed").ToString()
                        tbPaymentMethod.Text = reader("PaymentMethod").ToString()
                        tbTotal.Text = reader("TotalPayment").ToString()
                        tbAmountReceived.Text = reader("AmountReceived").ToString()
                        tbChange.Text = reader("Change").ToString()

                        ' ✅ Set transaction date label if it exists
                        If reader("TransactionDate") IsNot DBNull.Value Then
                            lblDate.Text = "Date: " & Convert.ToDateTime(reader("TransactionDate")).ToString("MMMM dd, yyyy")
                        Else
                            lblDate.Text = "Date: N/A"
                        End If
                    End If
                End Using
            End Using
        End Using
    End Sub


    ' -------------------------
    ' ApplyReadOnlyMode (updated — enforces always-readonly fields)
    ' -------------------------
    Private Sub ApplyReadOnlyMode(isReadOnly As Boolean)
        ' List of controls that should ALWAYS be non-editable (no caret, no focus)
        Dim alwaysReadOnly As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase) From {
        "tbMachineUsed",
        "tbPaymentMethod",
        "tbTotal",
        "tbChange",
        "tbAmountReceived"
    }

        For Each ctrl As Control In Me.Controls
            SetControlReadOnly(ctrl, isReadOnly, alwaysReadOnly)
        Next
    End Sub

    ' -------------------------
    ' Recursive helper
    ' -------------------------
    Private Sub SetControlReadOnly(ctrl As Control, isReadOnly As Boolean, alwaysReadOnly As HashSet(Of String))
        If ctrl Is Nothing Then Return

        ' If this control is in the always-readonly list, lock it regardless of mode
        Dim nameLower As String = If(ctrl.Name, "").ToLowerInvariant()
        Dim forceReadOnly As Boolean = alwaysReadOnly.Contains(ctrl.Name)

        Select Case True
            Case TypeOf ctrl Is TextBox
                Dim tb = CType(ctrl, TextBox)
                If forceReadOnly Then
                    tb.ReadOnly = True
                    tb.Enabled = False         ' remove caret and prevent focus
                    tb.BackColor = Color.WhiteSmoke
                    tb.Cursor = Cursors.Default
                Else
                    ' Normal behavior depending on isReadOnly
                    tb.ReadOnly = isReadOnly
                    tb.Enabled = Not isReadOnly
                    tb.BackColor = If(isReadOnly, Color.WhiteSmoke, Color.White)
                    tb.Cursor = If(isReadOnly, Cursors.Default, Cursors.IBeam)
                End If

            Case TypeOf ctrl Is ComboBox
                Dim cb = CType(ctrl, ComboBox)
                ' If combo is in alwaysReadOnly (unlikely) treat similarly; otherwise enable per mode
                If forceReadOnly Then
                    cb.Enabled = False
                    cb.Cursor = Cursors.Default
                Else
                    cb.Enabled = Not isReadOnly
                    cb.Cursor = If(isReadOnly, Cursors.Default, Cursors.Hand)
                End If

            Case TypeOf ctrl Is DateTimePicker
                Dim dtp = CType(ctrl, DateTimePicker)
                If forceReadOnly Then
                    dtp.Enabled = False
                Else
                    dtp.Enabled = Not isReadOnly
                End If

            Case TypeOf ctrl Is NumericUpDown
                Dim nud = CType(ctrl, NumericUpDown)
                If forceReadOnly Then
                    nud.Enabled = False
                Else
                    nud.Enabled = Not isReadOnly
                End If

            Case TypeOf ctrl Is CheckBox
                Dim chk = CType(ctrl, CheckBox)
                If forceReadOnly Then
                    chk.Enabled = False
                Else
                    chk.Enabled = Not isReadOnly
                End If

            Case TypeOf ctrl Is RadioButton
                Dim rb = CType(ctrl, RadioButton)
                If forceReadOnly Then
                    rb.Enabled = False
                Else
                    rb.Enabled = Not isReadOnly
                End If

            Case TypeOf ctrl Is Button
                Dim b = CType(ctrl, Button)
                Dim nm = b.Name.ToLowerInvariant()
                ' keep Cancel/Close enabled; disable Save/Update/Delete in view mode
                If nm.Contains("cancel") OrElse nm.Contains("close") Then
                    b.Enabled = True
                ElseIf nm.Contains("save") OrElse nm.Contains("update") OrElse nm.Contains("delete") Then
                    b.Enabled = Not isReadOnly
                Else
                    b.Enabled = Not isReadOnly
                End If
        End Select

        ' Recurse into children (panels, groupboxes, etc.)
        For Each child As Control In ctrl.Controls
            SetControlReadOnly(child, isReadOnly, alwaysReadOnly)
        Next
    End Sub



    ' ✅ Helper function to apply read-only recursively
    Private Sub ApplyReadOnlyRecursive(ctrl As Control, isReadOnly As Boolean)
        If TypeOf ctrl Is TextBox Then
            Dim tb = CType(ctrl, TextBox)
            tb.ReadOnly = isReadOnly
            tb.TabStop = Not isReadOnly
            tb.BackColor = Color.White
            tb.Cursor = If(isReadOnly, Cursors.Default, Cursors.IBeam)
        ElseIf TypeOf ctrl Is ComboBox Then
            Dim cb = CType(ctrl, ComboBox)
            cb.Enabled = Not isReadOnly
            cb.Cursor = If(isReadOnly, Cursors.Default, Cursors.Hand)
        End If

        ' Recurse for child controls
        For Each child As Control In ctrl.Controls
            ApplyReadOnlyRecursive(child, isReadOnly)
        Next
    End Sub



    ' ✅ Save changes to database
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not String.Equals(Mode, "Edit", StringComparison.OrdinalIgnoreCase) Then
            Return
        End If

        Try
            Using conn As New OleDb.OleDbConnection(Db.ConnectionString)
                conn.Open()

                Dim sql As String =
                "UPDATE [Transactions] " &
                "SET [CustomerName]=?, [ServiceType]=?, [ContactNumber]=?, [Address]=?, [Status]=?, [AmountReceived]=? " &
                "WHERE [TransactionID]=?"

                Using cmd As New OleDb.OleDbCommand(sql, conn)
                    ' order matters for OleDb:
                    cmd.Parameters.Add("?", OleDb.OleDbType.VarWChar).Value = tbCustomerName.Text
                    cmd.Parameters.Add("?", OleDb.OleDbType.VarWChar).Value = cbService.Text
                    cmd.Parameters.Add("?", OleDb.OleDbType.VarWChar).Value = tbContactNum.Text
                    cmd.Parameters.Add("?", OleDb.OleDbType.VarWChar).Value = tbAddress.Text
                    cmd.Parameters.Add("?", OleDb.OleDbType.VarWChar).Value = cbStatus.Text

                    Dim amtReceived As Decimal
                    If Not Decimal.TryParse(tbAmountReceived.Text, amtReceived) Then amtReceived = 0D
                    cmd.Parameters.Add("?", OleDb.OleDbType.Currency).Value = amtReceived

                    cmd.Parameters.Add("?", OleDb.OleDbType.Integer).Value = TransactionId

                    Dim affected = cmd.ExecuteNonQuery()
                    If affected = 0 Then
                        MessageBox.Show("No rows were updated. The transaction may have been changed or removed.",
                                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using
            End Using

            MessageBox.Show("Transaction updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Let the caller know to refresh
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error updating transaction: " & ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class

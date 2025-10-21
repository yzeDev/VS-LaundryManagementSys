Imports System.Data.OleDb

Module DatabaseHelper
    Public ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"
End Module

Public Class MachinesControl
    Private machineCardsCache As New Dictionary(Of Integer, MachineCard)()
    Private selectedMachine As MachineCard = Nothing

    Private Sub MachinesControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the status filter combobox
        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("All")
        cmbStatus.Items.Add("Available")
        cmbStatus.Items.Add("In-Use")
        cmbStatus.Items.Add("Unavailable")
        cmbStatus.Items.Add("Maintenance")
        cmbStatus.SelectedIndex = 0 ' Default to "All"

        LoadMachinesFromDB()
        btnRemoveMachine.Enabled = False
    End Sub

    Private Sub UpdateMachineInDB(machine As MachineCard)
        Using conn As New OleDbConnection(ConnectionString)
            conn.Open()
            Dim query As String = "UPDATE UnitData SET Capacity=@cap, Status=@status WHERE UnitNumber=@unit"
            Using cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@cap", CInt(machine.Capacity.Replace(" kg", "")))
                cmd.Parameters.AddWithValue("@status", machine.Status)
                cmd.Parameters.AddWithValue("@unit", machine.UnitNumber)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Attach click handlers to a control and non-interactive children
    Private Sub AttachClickHandlers(ctrl As Control, handler As EventHandler)
        ' Skip interactive controls — including Guna2 buttons
        If TypeOf ctrl Is ComboBox OrElse
       TypeOf ctrl Is TextBox OrElse
       TypeOf ctrl Is Button OrElse
       TypeOf ctrl Is NumericUpDown OrElse
       TypeOf ctrl Is CheckBox OrElse
       TypeOf ctrl Is LinkLabel OrElse
       ctrl.GetType().Name.Contains("Guna2Button") Then
            Return
        End If

        ' Attach click handler to non-interactive control
        AddHandler ctrl.Click, handler

        ' Recursively apply to children
        For Each child As Control In ctrl.Controls
            AttachClickHandlers(child, handler)
        Next
    End Sub


    Private Sub LoadMachinesFromDB()
        flpMachines.Controls.Clear()

        Using conn As New OleDbConnection(ConnectionString)
            conn.Open()
            Using cmd As New OleDbCommand("SELECT * FROM UnitData ORDER BY IIF(Status='Unavailable',1,0), UnitNumber", conn)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    Dim ordTransactionID As Integer = -1
                    Dim ordReason As Integer = -1

                    Try
                        ordTransactionID = reader.GetOrdinal("TransactionID")
                    Catch : End Try
                    Try
                        ordReason = reader.GetOrdinal("Reason")
                    Catch : End Try

                    While reader.Read()
                        Dim machineID As Integer = If(IsDBNull(reader("ID")), 0, CInt(reader("ID")))

                        ' Get or create the card
                        Dim card As MachineCard
                        If machineCardsCache.ContainsKey(machineID) Then
                            card = machineCardsCache(machineID)
                        Else
                            card = New MachineCard()
                            machineCardsCache(machineID) = card

                            ' Attach handlers once
                            AddHandler card.ProceedButton.Click, AddressOf HandleMachineProceed
                            AddHandler card.ViewDetailsButton.Click, AddressOf HandleViewDetails
                            AttachClickHandlers(card, AddressOf Machine_Click)
                        End If

                        ' --- RESET LAYOUT & SIZE TO FIX ENLARGEMENT ---
                        card.AutoSize = False
                        card.Size = New Size(400, 300)
                        card.Margin = New Padding(5)
                        card.Padding = New Padding(0)
                        card.picMachine.SizeMode = PictureBoxSizeMode.Zoom
                        card.lblTransactionID.AutoSize = False
                        card.lblServiceTime.AutoSize = False
                        card.lblTransactionID.MaximumSize = New Size(card.Width - 10, 20)
                        card.lblServiceTime.MaximumSize = New Size(card.Width - 10, 20)

                        ' --- UPDATE CARD DATA FROM DB ---
                        card.MachineID = machineID
                        card.UnitNumber = If(IsDBNull(reader("UnitNumber")), 0, CInt(reader("UnitNumber")))
                        card.Capacity = If(IsDBNull(reader("Capacity")), "0", reader("Capacity").ToString())
                        card.Status = If(IsDBNull(reader("Status")), "Available", reader("Status").ToString())
                        card.Reason = If(ordReason >= 0 AndAlso Not IsDBNull(reader(ordReason)), reader(ordReason).ToString(), "")
                        card.TransactionID = If(ordTransactionID >= 0 AndAlso Not IsDBNull(reader(ordTransactionID)), Convert.ToInt32(reader(ordTransactionID)), 0)

                        ' --- RESTORE UI ---
                        If card.TransactionID > 0 Then
                            ' Machine is in-use: fetch transaction details
                            Try
                                Using qcmd As New OleDbCommand("SELECT ServiceDuration, DeliverMethod FROM Transactions WHERE TransactionID=@tid", conn)
                                    qcmd.Parameters.AddWithValue("@tid", card.TransactionID)
                                    Using r2 As OleDbDataReader = qcmd.ExecuteReader()
                                        If r2.Read() Then
                                            card.lblServiceTime.Text = If(IsDBNull(r2("ServiceDuration")), DateTime.Now.ToShortTimeString(), r2("ServiceDuration").ToString())
                                            card.DeliverMethod = If(IsDBNull(r2("DeliverMethod")), "", r2("DeliverMethod").ToString())
                                        End If
                                    End Using
                                End Using
                            Catch : End Try

                            card.lblTransactionID.Text = "Transaction #" & card.TransactionID
                            card.lblTransactionID.Visible = True
                            card.lblServiceTime.Visible = True

                            card.ProceedButton.Text = "Complete"
                            card.ProceedButton.FillColor = Color.LightGreen
                            card.ProceedButton.Enabled = True

                            ' Set in-use GIF
                            Try
                                Dim imagePath As String = "C:\Users\Eisen\OneDrive\Documents\Assets\in-use.gif"
                                If System.IO.File.Exists(imagePath) Then
                                    card.MachineImage = Image.FromFile(imagePath)
                                    card.picMachine.Image = card.MachineImage
                                End If
                            Catch : End Try

                        Else
                            ' Available / other status
                            card.lblTransactionID.Visible = False
                            card.lblServiceTime.Visible = False
                            card.ProceedButton.Text = If(String.IsNullOrEmpty(card.originalProceedText), "Get Pending", card.originalProceedText)
                            card.ProceedButton.FillColor = If(card.originalProceedColor = Color.Empty, Color.FromArgb(94, 148, 255), card.originalProceedColor)
                            card.ProceedButton.Enabled = (card.Status = "Available")

                            ' Set default icon
                            If card.MachineImage Is Nothing Then
                                Try
                                    Dim imagePath As String = ""
                                    Select Case card.Status
                                        Case "Damaged"
                                            imagePath = "C:\Users\Eisen\OneDrive\Documents\Assets\damaged.png"
                                        Case "Unavailable"
                                            imagePath = "C:\Users\Eisen\OneDrive\Documents\Assets\unavailable.png"
                                        Case "Available"
                                            imagePath = "C:\Users\Eisen\OneDrive\Documents\Assets\available.png"
                                        Case Else
                                            imagePath = "C:\Users\Eisen\OneDrive\Documents\Assets\available.png"
                                    End Select
                                    If System.IO.File.Exists(imagePath) Then
                                        card.MachineImage = Image.FromFile(imagePath)
                                        card.picMachine.Image = card.MachineImage
                                    End If
                                Catch : End Try
                            End If
                        End If

                        ' Disable interaction for Damaged / Unavailable
                        card.Enabled = (card.Status <> "Damaged" AndAlso card.Status <> "Unavailable")

                        ' --- ADD CARD TO PANEL ---
                        flpMachines.Controls.Add(card)
                    End While
                End Using
            End Using
        End Using

        FilterMachinesByStatus()
    End Sub


    ' Handles the Get Pending / Complete flow (robust, with TransactionID column)
    Private Sub HandleMachineProceed(sender As Object, e As EventArgs)
        Dim btn = TryCast(sender, Guna.UI2.WinForms.Guna2Button)
        If btn Is Nothing Then Return

        ' Find parent MachineCard
        Dim parentCtrl As Control = btn
        While parentCtrl IsNot Nothing AndAlso Not TypeOf parentCtrl Is MachineCard
            parentCtrl = parentCtrl.Parent
        End While
        If parentCtrl Is Nothing Then Return
        Dim card As MachineCard = DirectCast(parentCtrl, MachineCard)

        ' --- ASSIGN PENDING TRANSACTION ---
        If card.TransactionID = 0 Then
            Dim transID As Integer = 0
            Dim deliverMethod As String = ""
            Dim serviceDuration As String = ""

            ' Get pending transaction
            Using conn As New OleDbConnection(ConnectionString)
                conn.Open()
                Using cmd As New OleDbCommand("SELECT TOP 1 TransactionID, DeliverMethod, ServiceDuration FROM Transactions WHERE Status='Pending' ORDER BY TransactionDate", conn)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            transID = Convert.ToInt32(reader("TransactionID"))
                            deliverMethod = If(IsDBNull(reader("DeliverMethod")), "", reader("DeliverMethod").ToString())
                            serviceDuration = If(IsDBNull(reader("ServiceDuration")), DateTime.Now.ToShortTimeString(), reader("ServiceDuration").ToString())
                        Else
                            MessageBox.Show("No pending transactions available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Return
                        End If
                    End Using
                End Using

                ' Assign transaction to machine (update UnitData)
                Using ucmd As New OleDbCommand("UPDATE UnitData SET Status='In-Use', TransactionID=@tid WHERE ID=@mid", conn)
                    ucmd.Parameters.AddWithValue("@tid", transID)
                    ucmd.Parameters.AddWithValue("@mid", card.MachineID)
                    ucmd.ExecuteNonQuery()
                End Using
            End Using

            ' Update UI
            card.TransactionID = transID
            card.DeliverMethod = deliverMethod
            card.Status = "In-Use"
            card.lblTransactionID.Text = "Transaction #" & transID
            card.lblTransactionID.Visible = True
            card.lblServiceTime.Text = serviceDuration
            card.lblServiceTime.Visible = True

            btn.Text = "Complete"
            btn.FillColor = Color.LightGreen
            btn.Enabled = True

            ' Set in-use icon
            Try
                Dim imagePath As String = "C:\Users\Eisen\OneDrive\Documents\Assets\in-use.gif"
                If System.IO.File.Exists(imagePath) Then
                    card.MachineImage = Image.FromFile(imagePath)
                    card.picMachine.Image = card.MachineImage
                    card.picMachine.SizeMode = PictureBoxSizeMode.Zoom
                End If
            Catch ex As Exception
                Debug.WriteLine("Error loading in-use image: " & ex.Message)
            End Try

            ' Optional: call AssignPendingTransaction
            Try
                card.AssignPendingTransaction(transID)
            Catch ex As Exception
                Debug.WriteLine("AssignPendingTransaction error: " & ex.Message)
            End Try

            card.Refresh()

        Else
            ' --- COMPLETE ASSIGNED TRANSACTION ---
            Dim transID As Integer = card.TransactionID
            If transID > 0 Then
                Dim deliverMethod As String = ""

                ' Get delivery method from Transactions
                Using conn As New OleDbConnection(ConnectionString)
                    conn.Open()
                    Using qcmd As New OleDbCommand("SELECT DeliverMethod FROM Transactions WHERE TransactionID=@id", conn)
                        qcmd.Parameters.AddWithValue("@id", transID)
                        Dim res = qcmd.ExecuteScalar()
                        If res IsNot Nothing AndAlso res IsNot DBNull.Value Then deliverMethod = res.ToString()
                    End Using

                    Dim newStatus As String = If(deliverMethod.Equals("Delivery", StringComparison.OrdinalIgnoreCase),
                                             "For Delivery", "For Pickup")

                    ' Update transaction status
                    Using ucmd As New OleDbCommand("UPDATE Transactions SET Status=@status WHERE TransactionID=@id", conn)
                        ucmd.Parameters.AddWithValue("@status", newStatus)
                        ucmd.Parameters.AddWithValue("@id", transID)
                        ucmd.ExecuteNonQuery()
                    End Using

                    ' Reset machine: Available, clear TransactionID
                    Using umc As New OleDbCommand("UPDATE UnitData SET Status='Available', TransactionID=NULL WHERE ID=@mid", conn)
                        umc.Parameters.AddWithValue("@mid", card.MachineID)
                        umc.ExecuteNonQuery()
                    End Using
                End Using

                ' Update UI
                card.TransactionID = 0
                card.DeliverMethod = ""
                card.Status = "Available"
                card.lblTransactionID.Text = ""
                card.lblTransactionID.Visible = False
                card.lblServiceTime.Text = ""
                card.lblServiceTime.Visible = False

                btn.Text = If(String.IsNullOrEmpty(card.originalProceedText), "Get Pending", card.originalProceedText)
                btn.FillColor = If(card.originalProceedColor = Color.Empty, Color.FromArgb(94, 148, 255), card.originalProceedColor)
                btn.Enabled = True

                ' Reset image
                Try
                    Dim imagePath As String = "C:\Users\Eisen\OneDrive\Documents\Assets\available.png"
                    If System.IO.File.Exists(imagePath) Then
                        card.MachineImage = Image.FromFile(imagePath)
                        card.picMachine.Image = card.MachineImage
                        card.picMachine.SizeMode = PictureBoxSizeMode.Zoom
                    End If
                Catch ex As Exception
                    Debug.WriteLine("Error loading available image: " & ex.Message)
                End Try

                card.Refresh()
            End If
        End If
    End Sub



    ' Add 
    Private Sub btnAddMachine_Click(sender As Object, e As EventArgs) Handles btnAddMachine.Click
        ' --- Ask the user for capacity ---
        Dim input = InputBox("Enter the maximum weight capacity (in kg):", "New Machine", "10")

        If String.IsNullOrWhiteSpace(input) Then
            MessageBox.Show("Machine not added. Capacity is required.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim capacityKg As Integer
        If Not Integer.TryParse(input, capacityKg) OrElse capacityKg <= 0 Then
            MessageBox.Show("Invalid capacity. Please enter a positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' --- Find the next available UnitNumber ---
        Dim nextUnitNumber = GetNextAvailableUnitNumber()

        ' --- Create machine card ---
        Dim newMachine As New MachineCard
        newMachine.UnitNumber = nextUnitNumber
        newMachine.Capacity = capacityKg.ToString & " kg"
        newMachine.Status = "Available"

        Try
            newMachine.MachineImage = Image.FromFile("C:\Users\Eisen\Downloads\available.png")
        Catch
            newMachine.MachineImage = Nothing
        End Try
        newMachine.picMachine.SizeMode = PictureBoxSizeMode.Zoom

        ' --- Save to DB and get new MachineID ---
        Dim newID = SaveMachineToDB(newMachine)
        newMachine.MachineID = newID
        newMachine.lblMachineIDText.Text = "Machine ID: " & newID.ToString

        ' --- Refresh UI from DB ---
        LoadMachinesFromDB()
    End Sub

    ' Remove
    Private Sub btnRemoveMachine_Click(sender As Object, e As EventArgs) Handles btnRemoveMachine.Click
        If selectedMachine Is Nothing Then Return

        ' Ask for reason
        Dim reason As String = InputBox("Enter the reason why this machine is unavailable:", "Mark as Unavailable", "")
        If String.IsNullOrWhiteSpace(reason) Then
            MessageBox.Show("No reason entered. Operation cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' Update database: Set UnitNumber to NULL and mark as Unavailable
        Using conn As New OleDbConnection(ConnectionString)
            conn.Open()
            Dim query As String = "UPDATE UnitData SET Status=@status, Reason=@reason, UnitNumber=NULL WHERE ID=@id"
            Using cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@status", "Unavailable")
                cmd.Parameters.AddWithValue("@reason", reason)
                cmd.Parameters.AddWithValue("@id", selectedMachine.MachineID)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        ' Now renumber all available machines to fill the gap
        RenumberAvailableMachines()

        ' Refresh everything from DB
        LoadMachinesFromDB()

        selectedMachine = Nothing
        btnRemoveMachine.Enabled = False
        btnConfigure.Enabled = False
    End Sub

    ' Re-assign unit numbers sequentially
    Private Sub RenumberMachines()
        Dim unitIndex As Integer = 1

        Using conn As New OleDbConnection(ConnectionString)
            conn.Open()

            For Each ctrl As Control In flpMachines.Controls
                If TypeOf ctrl Is MachineCard Then
                    Dim machine As MachineCard = DirectCast(ctrl, MachineCard)
                    machine.UnitNumber = unitIndex

                    ' Update DB with new number
                    Dim query As String = "UPDATE UnitData SET UnitNumber=@unit WHERE Capacity=@cap AND Status=@status"
                    Using cmd As New OleDbCommand(query, conn)
                        cmd.Parameters.AddWithValue("@unit", unitIndex)
                        cmd.Parameters.AddWithValue("@cap", CInt(machine.Capacity.Replace(" kg", "")))
                        cmd.Parameters.AddWithValue("@status", machine.Status)
                        cmd.ExecuteNonQuery()
                    End Using

                    unitIndex += 1
                End If
            Next
        End Using
    End Sub

    Private Function GetNextAvailableUnitNumber() As Integer
        ' Find the lowest available unit number (reusing gaps from unavailable machines)
        Dim usedNumbers As New List(Of Integer)

        Using conn As New OleDbConnection(ConnectionString)
            conn.Open()
            ' Get all unit numbers from AVAILABLE machines only
            Dim query As String = "SELECT UnitNumber FROM UnitData WHERE Status <> 'Unavailable' AND UnitNumber IS NOT NULL ORDER BY UnitNumber"
            Using cmd As New OleDbCommand(query, conn)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        If Not IsDBNull(reader("UnitNumber")) Then
                            usedNumbers.Add(Convert.ToInt32(reader("UnitNumber")))
                        End If
                    End While
                End Using
            End Using
        End Using

        ' Find the first gap in the sequence, or return the next number
        Dim nextNumber As Integer = 1
        For Each num In usedNumbers.OrderBy(Function(x) x)
            If num = nextNumber Then
                nextNumber += 1
            Else
                ' Found a gap, use it
                Return nextNumber
            End If
        Next

        ' No gaps found, return the next sequential number
        Return nextNumber
    End Function

    ' Configure machine
    Private Sub btnConfigure_Click(sender As Object, e As EventArgs) Handles btnConfigure.Click
        If selectedMachine Is Nothing Then Return

        Dim configForm As New ConfigureMachineForm()
        configForm.UnitNumber = selectedMachine.UnitNumber
        configForm.Capacity = CInt(selectedMachine.Capacity.Replace(" kg", ""))
        configForm.Status = selectedMachine.Status

        If configForm.ShowDialog() = DialogResult.OK Then
            ' Just reload everything from DB
            LoadMachinesFromDB()
        End If
    End Sub

    Private Sub ReAdjustUnitNumbers()
        Using conn As New OleDbConnection(ConnectionString)
            conn.Open()

            ' Only renumber AVAILABLE units (unavailable ones will stay 0)
            Dim sql As String = "SELECT ID FROM UnitData WHERE Status <> 'Unavailable' ORDER BY UnitNumber"
            Using cmd As New OleDbCommand(sql, conn)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    Dim counter As Integer = 1
                    While reader.Read()
                        Dim machineID As Integer = Convert.ToInt32(reader("ID"))

                        Dim updateSql As String = "UPDATE UnitData SET UnitNumber = @UnitNumber WHERE ID = @MachineID"
                        Using updateCmd As New OleDbCommand(updateSql, conn)
                            updateCmd.Parameters.AddWithValue("@UnitNumber", counter)
                            updateCmd.Parameters.AddWithValue("@MachineID", machineID)
                            updateCmd.ExecuteNonQuery()
                        End Using

                        counter += 1
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Function SaveMachineToDB(machine As MachineCard) As Integer
        Dim newID As Integer = -1
        Using conn As New OleDbConnection(ConnectionString)
            conn.Open()
            Dim query As String = "INSERT INTO UnitData (UnitNumber, Capacity, Status) VALUES (@unitnum, @cap, @status)"
            Using cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@unitnum", machine.UnitNumber)
                cmd.Parameters.AddWithValue("@cap", CInt(machine.Capacity.Replace(" kg", "")))
                cmd.Parameters.AddWithValue("@status", machine.Status)
                cmd.ExecuteNonQuery()
            End Using

            ' Get the last inserted ID
            Dim idCmd As New OleDbCommand("SELECT @@IDENTITY", conn)
            newID = Convert.ToInt32(idCmd.ExecuteScalar())
        End Using
        Return newID
    End Function

    Private Sub DisableAllClicks(ctrl As Control)
        For Each child As Control In ctrl.Controls
            RemoveHandler child.Click, AddressOf Machine_Click
            DisableAllClicks(child)
        Next
        RemoveHandler ctrl.Click, AddressOf Machine_Click
    End Sub

    Private Sub RearrangeMachines()
        Dim available As New List(Of Control)
        Dim unavailable As New List(Of Control)

        For Each ctrl As Control In flpMachines.Controls
            If TypeOf ctrl Is MachineCard Then
                Dim mc As MachineCard = DirectCast(ctrl, MachineCard)
                If mc.Status = "Unavailable" Then
                    unavailable.Add(mc)
                Else
                    available.Add(mc)
                End If
            End If
        Next

        flpMachines.Controls.Clear()
        For Each mc In available
            flpMachines.Controls.Add(mc)
        Next
        For Each mc In unavailable
            flpMachines.Controls.Add(mc)
        Next
    End Sub

    Private Sub Machine_Click(sender As Object, e As EventArgs)
        Dim orig As Control = DirectCast(sender, Control)

        If TypeOf orig Is ComboBox Or TypeOf orig Is TextBox Or TypeOf orig Is Button Or TypeOf orig Is NumericUpDown Or TypeOf orig Is CheckBox Then
            Return
        End If

        Dim ctrl As Control = orig
        While ctrl IsNot Nothing AndAlso Not TypeOf ctrl Is MachineCard
            ctrl = ctrl.Parent
        End While
        If ctrl Is Nothing Then Return

        Dim clicked As MachineCard = DirectCast(ctrl, MachineCard)
        If clicked.Status = "Unavailable" Then Return

        If selectedMachine Is clicked Then
            clicked.BorderStyle = BorderStyle.None
            clicked.BackColor = Color.White
            selectedMachine = Nothing
            btnRemoveMachine.Enabled = False
            btnConfigure.Enabled = False
            Return
        End If

        For Each mc As Control In flpMachines.Controls
            If TypeOf mc Is MachineCard Then
                DirectCast(mc, MachineCard).BorderStyle = BorderStyle.None
                mc.BackColor = Color.White
            End If
        Next

        selectedMachine = clicked
        selectedMachine.BorderStyle = BorderStyle.FixedSingle
        selectedMachine.BackColor = Color.LightBlue
        btnRemoveMachine.Enabled = True
        btnConfigure.Enabled = True
    End Sub



    Private Sub HandleViewDetails(sender As Object, e As EventArgs)
        Dim btn = TryCast(sender, Guna.UI2.WinForms.Guna2Button)
        If btn Is Nothing Then Return

        Dim parentCtrl As Control = btn
        While parentCtrl IsNot Nothing AndAlso Not TypeOf parentCtrl Is MachineCard
            parentCtrl = parentCtrl.Parent
        End While
        If parentCtrl Is Nothing Then Return
        Dim card As MachineCard = DirectCast(parentCtrl, MachineCard)

        Dim frm As New MachineDetailsForm()
        frm.LoadMachineDetails(card.MachineID)
        frm.ShowDialog()
    End Sub

    ' New method to renumber only available machines sequentially
    Private Sub RenumberAvailableMachines()
        Using conn As New OleDbConnection(ConnectionString)
            conn.Open()

            ' Get all available machines ordered by their current unit number
            Dim query As String = "SELECT ID FROM UnitData WHERE Status <> 'Unavailable' ORDER BY UnitNumber"
            Dim machineIDs As New List(Of Integer)

            Using cmd As New OleDbCommand(query, conn)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        machineIDs.Add(Convert.ToInt32(reader("ID")))
                    End While
                End Using
            End Using

            ' Renumber them sequentially starting from 1
            Dim newUnitNumber As Integer = 1
            For Each machineID In machineIDs
                Dim updateQuery As String = "UPDATE UnitData SET UnitNumber=@unit WHERE ID=@id"
                Using updateCmd As New OleDbCommand(updateQuery, conn)
                    updateCmd.Parameters.AddWithValue("@unit", newUnitNumber)
                    updateCmd.Parameters.AddWithValue("@id", machineID)
                    updateCmd.ExecuteNonQuery()
                End Using
                newUnitNumber += 1
            Next
        End Using
    End Sub

    ' Filtering
    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        FilterMachinesByStatus()
    End Sub

    Private Sub FilterMachinesByStatus()
        Dim selectedStatus As String = If(cmbStatus.SelectedItem IsNot Nothing, cmbStatus.SelectedItem.ToString(), "All")

        ' Show all machines if "All" is selected
        If selectedStatus = "All" Then
            For Each ctrl As Control In flpMachines.Controls
                If TypeOf ctrl Is MachineCard Then
                    ctrl.Visible = True
                End If
            Next
            Return
        End If

        ' Filter machines by selected status
        For Each ctrl As Control In flpMachines.Controls
            If TypeOf ctrl Is MachineCard Then
                Dim card As MachineCard = DirectCast(ctrl, MachineCard)
                card.Visible = (card.Status = selectedStatus)
            End If
        Next
    End Sub
End Class
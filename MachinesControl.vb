Imports System.Data.OleDb
Module DatabaseHelper
    Public ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"
End Module


Public Class MachinesControl
    Private selectedMachine As MachineCard = Nothing
    Private Sub MachinesControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    ' --- 1) Recursive helper: attach click handler to the root and all nested non-interactive children ---
    Private Sub AttachClickHandlers(ctrl As Control, handler As EventHandler)
        ' Always attach to the control itself if it's not an interactive input
        If Not (TypeOf ctrl Is ComboBox Or TypeOf ctrl Is TextBox Or TypeOf ctrl Is Button _
            Or TypeOf ctrl Is NumericUpDown Or TypeOf ctrl Is CheckBox Or TypeOf ctrl Is LinkLabel) Then
            AddHandler ctrl.Click, handler
        End If

        ' Recurse into children
        For Each child As Control In ctrl.Controls
            AttachClickHandlers(child, handler)
        Next
    End Sub

    ' --- 2) Robust Load from DB (use your ConnectionString & table/field names) ---
    Private Sub LoadMachinesFromDB()
        flpMachines.Controls.Clear()

        Using conn As New OleDbConnection(ConnectionString)
            conn.Open()
            Dim query As String = "SELECT ID, UnitNumber, Capacity, Status, Reason FROM UnitData ORDER BY IIF(Status='Unavailable',1,0), UnitNumber"
            Using cmd As New OleDbCommand(query, conn)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim card As New MachineCard()

                        ' ID and numeric unit number
                        card.MachineID = If(IsDBNull(reader("ID")), 0, CInt(reader("ID")))
                        Dim unitNum As Integer = If(IsDBNull(reader("UnitNumber")), 0, CInt(reader("UnitNumber")))
                        card.UnitNumber = unitNum

                        ' Capacity & Status
                        card.Capacity = If(IsDBNull(reader("Capacity")), "0", reader("Capacity").ToString())
                        card.Status = If(IsDBNull(reader("Status")), "Available", reader("Status").ToString())

                        ' Reason (may be empty)
                        Dim reason As String = If(IsDBNull(reader("Reason")), "", reader("Reason").ToString())
                        card.Reason = reason  ' MachineCard.Reason updates lblMachineIDText

                        ' Picture (keep your existing try/catch)
                        Try
                            ' change image paths as needed
                            Select Case card.Status
                                Case "Damaged"
                                    card.MachineImage = Image.FromFile("C:\Users\Eisen\OneDrive\Documents\Assets\damaged.png")
                                Case "Unavailable"
                                    card.MachineImage = Image.FromFile("C:\Users\Eisen\OneDrive\Documents\Assets\unavailable.png")
                                Case Else
                                    card.MachineImage = Image.FromFile("C:\Users\Eisen\OneDrive\Documents\Assets\available.png")
                            End Select
                        Catch
                            card.MachineImage = Nothing
                        End Try
                        card.picMachine.SizeMode = PictureBoxSizeMode.Zoom

                        ' === BUTTON & CLICK STATE HANDLING ===
                        ' Ensure the card exposes ProceedButton and ViewDetailsButton (Guna2Button)
                        Dim proceedBtn = card.ProceedButton
                        Dim viewBtn = card.ViewDetailsButton

                        ' Defensive: make sure the properties exist
                        If proceedBtn IsNot Nothing Then
                            ' Remove previous handlers to avoid duplicates
                            RemoveHandler proceedBtn.Click, AddressOf HandleMachineProceed
                            AddHandler proceedBtn.Click, AddressOf HandleMachineProceed
                        End If

                        If viewBtn IsNot Nothing Then
                            ' Remove previous handler to avoid duplicates
                            RemoveHandler viewBtn.Click, Nothing

                            ' Add inline handler for viewing machine details
                            AddHandler viewBtn.Click, Sub()
                                                          If card.TransactionID > 0 Then
                                                              Dim detailsForm As New MachineDetailsForm()
                                                              detailsForm.TransactionId = card.TransactionID
                                                              detailsForm.ShowDialog()
                                                          Else
                                                              MessageBox.Show("No active transaction for this machine.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                          End If
                                                      End Sub

                        End If


                        ' If Unavailable or Damaged -> disable interactions and style accordingly
                        If String.Equals(card.Status, "Unavailable", StringComparison.OrdinalIgnoreCase) OrElse
                       String.Equals(card.Status, "Damaged", StringComparison.OrdinalIgnoreCase) Then

                            ' Disable whole card except view details if you want it accessible
                            card.Enabled = False

                            ' Disable proceed button and style it grey (do not modify other default colors)
                            If proceedBtn IsNot Nothing Then
                                proceedBtn.Enabled = False
                                ' Guna2Button uses FillColor property
                                proceedBtn.FillColor = Color.Gray
                            End If

                            ' Optionally set special images handled above
                        Else
                            ' Available / In-Use: enable card
                            card.Enabled = True
                            If proceedBtn IsNot Nothing Then proceedBtn.Enabled = True
                        End If

                        flpMachines.Controls.Add(card)
                    End While
                End Using
            End Using
        End Using
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
            newMachine.MachineImage = Image.FromFile("C:\Users\Eisen\Downloads\laundry-unscreen.gif")
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

        ' Update the selected machine’s display
        selectedMachine.Status = "Unavailable"
        selectedMachine.lblUnit.Text = "Unavailable"
        selectedMachine.lblMachineIDText.Text = "Unavailable: " & reason
        selectedMachine.Enabled = False ' Make the card unclickable

        ' Update database: set UnitNumber = NULL so it's not counted in the sequence
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

        ' Reorder remaining machines in the UI (only available ones)
        RearrangeMachines()

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
        Dim maxUnit As Integer = 0

        ' Check existing machines in the UI (in case UI has unsaved ones)
        For Each ctrl As Control In flpMachines.Controls
            If TypeOf ctrl Is MachineCard Then
                Dim mc As MachineCard = DirectCast(ctrl, MachineCard)
                If mc.UnitNumber > maxUnit Then
                    maxUnit = mc.UnitNumber
                End If
            End If
        Next

        ' Check DB for highest UnitNumber
        Using conn As New OleDbConnection(ConnectionString)
            conn.Open()
            Dim query As String = "SELECT Max(UnitNumber) FROM UnitData"
            Using cmd As New OleDbCommand(query, conn)
                Dim result = cmd.ExecuteScalar()
                If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                    Dim dbMax As Integer = Convert.ToInt32(result)
                    If dbMax > maxUnit Then
                        maxUnit = dbMax
                    End If
                End If
            End Using
        End Using

        ' Return the next unused number
        Return maxUnit + 1
    End Function


    ' When a machine is clicked
    Private Sub Machine_Click(sender As Object, e As EventArgs)
        Dim orig As Control = DirectCast(sender, Control)

        ' Extra safety: if the click started on an interactive control, ignore it
        If TypeOf orig Is ComboBox Or TypeOf orig Is TextBox Or TypeOf orig Is Button Or TypeOf orig Is NumericUpDown Or TypeOf orig Is CheckBox Then
            Return
        End If


        ' Walk up to find the MachineCard parent
        Dim ctrl As Control = orig
        While ctrl IsNot Nothing AndAlso Not TypeOf ctrl Is MachineCard
            ctrl = ctrl.Parent
        End While
        If ctrl Is Nothing Then Return

        Dim clicked As MachineCard = DirectCast(ctrl, MachineCard)
        ' Ignore clicks on unavailable machines
        If clicked.Status = "Unavailable" Then
            Return
        End If

        ' Toggle selection (same logic you used before)
        If selectedMachine Is clicked Then
            clicked.BorderStyle = BorderStyle.None
            clicked.BackColor = Color.White
            selectedMachine = Nothing
            btnRemoveMachine.Enabled = False
            btnConfigure.Enabled = False
            Return
        End If

        ' Clear highlight from all machines
        For Each mc As Control In flpMachines.Controls
            If TypeOf mc Is MachineCard Then
                DirectCast(mc, MachineCard).BorderStyle = BorderStyle.None
                mc.BackColor = Color.White
            End If
        Next

        ' Highlight new selection
        selectedMachine = clicked
        selectedMachine.BorderStyle = BorderStyle.FixedSingle
        selectedMachine.BackColor = Color.LightBlue
        btnRemoveMachine.Enabled = True
        btnConfigure.Enabled = True
    End Sub
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

    ' Handles the Get Pending / Complete flow
    ' Handles the Get Pending / Complete flow
    Private Sub HandleMachineProceed(sender As Object, e As EventArgs)
        Dim btn = TryCast(sender, Guna.UI2.WinForms.Guna2Button)
        If btn Is Nothing Then Return

        ' Find parent MachineCard (walk up parents)
        Dim parentCtrl As Control = btn
        While parentCtrl IsNot Nothing AndAlso Not TypeOf parentCtrl Is MachineCard
            parentCtrl = parentCtrl.Parent
        End While
        If parentCtrl Is Nothing Then Return
        Dim card As MachineCard = DirectCast(parentCtrl, MachineCard)

        If btn.Text = "Get Pending" Then
            ' Grab one pending transaction and assign it to the machine
            Using conn As New OleDbConnection(ConnectionString)
                conn.Open()
                Dim query As String = "SELECT TOP 1 * FROM Transactions WHERE Status='Pending' ORDER BY TransactionDate"
                Using cmd As New OleDbCommand(query, conn)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim transID As Integer = If(IsDBNull(reader("TransactionID")), 0, Convert.ToInt32(reader("TransactionID")))
                            Dim deliverMethod As String = If(IsDBNull(reader("DeliverMethod")), "", reader("DeliverMethod").ToString())
                            Dim serviceDuration As String = If(IsDBNull(reader("ServiceDuration")), "", reader("ServiceDuration").ToString())

                            ' Update machine card UI
                            card.lblStatus.Text = "In-Use"
                            card.lblTransactionID.Text = "Transaction #" & transID.ToString()
                            card.lblServiceTime.Text = If(String.IsNullOrEmpty(serviceDuration), DateTime.Now.ToShortTimeString(), serviceDuration)

                            ' Update transaction to In-Progress
                            Using ucmd As New OleDbCommand("UPDATE Transactions SET Status='In-Progress' WHERE TransactionID=@id", conn)
                                ucmd.Parameters.AddWithValue("@id", transID)
                                ucmd.ExecuteNonQuery()
                            End Using

                            ' Change button to Complete stage (only change the button's FillColor now)
                            btn.Text = "Complete"
                            btn.FillColor = Color.LightGreen
                        Else
                            MessageBox.Show("No pending transactions available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using

        ElseIf btn.Text = "Complete" Then
            ' Complete current transaction assigned to this machine
            Dim transText = card.lblTransactionID.Text.Replace("Transaction #", "").Trim()
            Dim transID As Integer
            If Integer.TryParse(transText, transID) Then
                Using conn As New OleDbConnection(ConnectionString)
                    conn.Open()
                    ' find deliver method
                    Dim deliverMethod As String = ""
                    Using qcmd As New OleDbCommand("SELECT DeliverMethod FROM Transactions WHERE TransactionID=@id", conn)
                        qcmd.Parameters.AddWithValue("@id", transID)
                        Dim res = qcmd.ExecuteScalar()
                        If res IsNot Nothing AndAlso res IsNot DBNull.Value Then deliverMethod = res.ToString()
                    End Using

                    Dim newStatus As String = If(String.Equals(deliverMethod, "Delivery", StringComparison.OrdinalIgnoreCase), "For Delivery", "For Pickup")
                    Using ucmd As New OleDbCommand("UPDATE Transactions SET Status=@status WHERE TransactionID=@id", conn)
                        ucmd.Parameters.AddWithValue("@status", newStatus)
                        ucmd.Parameters.AddWithValue("@id", transID)
                        ucmd.ExecuteNonQuery()
                    End Using
                End Using
            End If

            ' Reset card visuals to available
            card.lblStatus.Text = "Available"
            card.lblTransactionID.Text = ""
            card.lblServiceTime.Text = ""
            btn.Text = "Get Pending"
            ' restore button FillColor — DO NOT assume a specific original color; reset to default by disabling override:
            btn.FillColor = btn.Parent.BackColor ' this ensures it doesn't forcibly change your theme (or set to a known color)
        End If
    End Sub

    ' Handles "View Details" button click
    Private Sub HandleViewDetails(sender As Object, e As EventArgs)
        Dim btn = TryCast(sender, Guna.UI2.WinForms.Guna2Button)
        If btn Is Nothing Then Return

        Dim parentCtrl As Control = btn
        While parentCtrl IsNot Nothing AndAlso Not TypeOf parentCtrl Is MachineCard
            parentCtrl = parentCtrl.Parent
        End While
        If parentCtrl Is Nothing Then Return
        Dim card As MachineCard = DirectCast(parentCtrl, MachineCard)

        ' open a machine details form or transaction form
        ' Example: open a MachineDetailsForm (you should implement it to accept machine id)
        Dim frm As New MachineDetailsForm()
        frm.LoadMachineDetails(card.MachineID) ' implement this method
        frm.ShowDialog()
    End Sub

End Class
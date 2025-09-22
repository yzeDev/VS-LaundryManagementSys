Imports System.Data.OleDb
Module DatabaseHelper
    Public ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb"
End Module


Public Class MachinesControl
    Private selectedMachine As MachineCard = Nothing
    Private Sub MachinesControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMachinesFromDB()
        btnRemoveMachine.Enabled = False
    End Sub


    Private Sub SaveMachineToDB(machine As MachineCard)
        Using conn As New OleDbConnection(ConnectionString)
            conn.Open()
            Dim query As String = "INSERT INTO UnitData (UnitNumber, Capacity, Status) VALUES (@unitnum, @cap, @status)"
            Using cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@unitnum", machine.UnitNumber)
                cmd.Parameters.AddWithValue("@cap", CInt(machine.Capacity.Replace(" kg", "")))
                cmd.Parameters.AddWithValue("@status", machine.Status)
                cmd.ExecuteNonQuery()
            End Using
        End Using
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
            Dim query As String = "SELECT ID, UnitNumber, Capacity, Status FROM UnitData ORDER BY UnitNumber"
            Using cmd As New OleDbCommand(query, conn)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim card As New MachineCard()

                        ' Assign DB fields (adjust conversions if your types differ)
                        card.MachineID = If(IsDBNull(reader("ID")), 0, CInt(reader("ID")))
                        card.UnitNumber = If(IsDBNull(reader("UnitNumber")), 0, CInt(reader("UnitNumber")))
                        ' store capacity as a number, MachineCard property can format with "kg" if you want
                        card.Capacity = If(IsDBNull(reader("Capacity")), "0", reader("Capacity").ToString())
                        card.Status = If(IsDBNull(reader("Status")), "Available", reader("Status").ToString())

                        ' Set picture if you have one (use My.Resources or fallback to file)
                        Try
                            ' Prefer resources: My.Resources.washing_machine_icon
                            'card.MachineImage = My.Resources.washing_machine_icon
                            card.MachineImage = Image.FromFile("C:\Users\Eisen\Downloads\washing-machine.png")
                        Catch ex As Exception
                            ' fallback to file (optional)
                            Try
                                card.MachineImage = Image.FromFile("C:\Users\Eisen\Downloads\washing-machine.png")
                            Catch
                                ' ignore if missing
                            End Try
                        End Try
                        card.picMachine.SizeMode = PictureBoxSizeMode.Zoom

                        ' Important: attach handler to the card and all allowed children
                        AttachClickHandlers(card, AddressOf Machine_Click)

                        ' Add to UI
                        flpMachines.Controls.Add(card)
                    End While
                End Using
            End Using
        End Using

        ' If you maintain UnitNumber in DB, no automatic renumber here.
        ' If you want UI ordering by UnitNumber ensured, you already ORDER BY UnitNumber in SQL.
    End Sub


    ' Add 
    Private Sub btnAddMachine_Click(sender As Object, e As EventArgs) Handles btnAddMachine.Click
        ' --- Find the next available UnitNumber ---
        Dim nextUnitNumber As Integer = GetNextAvailableUnitNumber()

        ' --- Create machine card ---
        Dim newMachine As New MachineCard()
        newMachine.UnitNumber = nextUnitNumber
        newMachine.Capacity = "10"
        newMachine.Status = "Available"

        Try
            newMachine.MachineImage = Image.FromFile("C:\Users\Eisen\Downloads\washing-machine.png")
        Catch
            ' Optional: fallback if image not found
            newMachine.MachineImage = Nothing
        End Try
        newMachine.picMachine.SizeMode = PictureBoxSizeMode.Zoom

        ' --- Save to DB with unique UnitNumber ---
        SaveMachineToDB(newMachine)

        ' --- Refresh UI from DB ---
        LoadMachinesFromDB()
    End Sub



    ' Remove
    Private Sub btnRemoveMachine_Click(sender As Object, e As EventArgs) Handles btnRemoveMachine.Click
        If selectedMachine Is Nothing Then Return

        ' --- Delete from database ---
        Using conn As New OleDbConnection(ConnectionString)
            conn.Open()
            Dim query As String = "DELETE FROM UnitData WHERE UnitNumber=@unit"
            Using cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@unit", selectedMachine.UnitNumber)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        ' Refresh UI (auto-renumber after delete)
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
            Dim query As String = "SELECT MAX(UnitNumber) FROM UnitData"
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

        ' Toggle selection (same logic you used before)
        If selectedMachine Is clicked Then
            clicked.BorderStyle = BorderStyle.None
            clicked.BackColor = SystemColors.Control
            selectedMachine = Nothing
            btnRemoveMachine.Enabled = False
            btnConfigure.Enabled = False
            Return
        End If

        ' Clear highlight from all machines
        For Each mc As Control In flpMachines.Controls
            If TypeOf mc Is MachineCard Then
                DirectCast(mc, MachineCard).BorderStyle = BorderStyle.None
                mc.BackColor = SystemColors.Control
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


End Class

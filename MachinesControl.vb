Public Class MachinesControl
    Private selectedMachine As MachineCard = Nothing

    ' Attach click handler to a control and all nested children
    ' --- Helper: Attach click handler to ctrl and children, but skip interactive controls ---
    Private Sub AttachClickHandlers(ctrl As Control, handler As EventHandler)
        ' Skip interactive controls so they can receive input without triggering selection
        If Not (TypeOf ctrl Is ComboBox Or TypeOf ctrl Is TextBox Or TypeOf ctrl Is Button Or TypeOf ctrl Is NumericUpDown Or TypeOf ctrl Is CheckBox Or TypeOf ctrl Is LinkLabel) Then
            AddHandler ctrl.Click, handler
        End If

        For Each child As Control In ctrl.Controls
            AttachClickHandlers(child, handler)
        Next
    End Sub



    Private Sub MachinesControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnRemoveMachine.Enabled = False
    End Sub

    'Add Machine
    Private Sub btnAddMachine_Click(sender As Object, e As EventArgs) Handles btnAddMachine.Click
        Dim newMachine As New MachineCard()
        newMachine.Capacity = "10"
        newMachine.Status = "Available"

        ' Example: Load a washing machine picture
        'newMachine.MachineImage = My.Resources.washing_machine_icon
        newMachine.MachineImage = Image.FromFile("C:\Users\Eisen\Downloads\washing-machine.png")
        newMachine.picMachine.SizeMode = PictureBoxSizeMode.Zoom

        AttachClickHandlers(newMachine, AddressOf Machine_Click)

        flpMachines.Controls.Add(newMachine)
        RenumberMachines()
    End Sub



    ' Remove machine
    Private Sub btnRemoveMachine_Click(sender As Object, e As EventArgs) Handles btnRemoveMachine.Click
        If selectedMachine IsNot Nothing Then
            flpMachines.Controls.Remove(selectedMachine)
            selectedMachine = Nothing
            btnRemoveMachine.Enabled = False
            RenumberMachines() ' 👈 renumber after removing
        End If
    End Sub


    ' Re-assign unit numbers sequentially
    Private Sub RenumberMachines()
        Dim unitIndex As Integer = 1
        For Each ctrl As Control In flpMachines.Controls
            If TypeOf ctrl Is MachineCard Then
                Dim machine As MachineCard = DirectCast(ctrl, MachineCard)
                machine.UnitNumber = unitIndex
                unitIndex += 1
            End If
        Next
    End Sub


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
End Class

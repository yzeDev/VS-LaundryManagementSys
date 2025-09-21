Public Class MachinesControl
    Private selectedMachine As MachineCard = Nothing

    ' Attach click handler to a control and all nested children
    Private Sub AttachClickHandlers(ctrl As Control, handler As EventHandler)
        AddHandler ctrl.Click, handler
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

        ' Attach click handler to the card and all its children
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
        Dim clicked As MachineCard = Nothing

        ' Make sure we always get the parent MachineCard, even if a child was clicked
        If TypeOf sender Is MachineCard Then
            clicked = DirectCast(sender, MachineCard)
        Else
            clicked = DirectCast(DirectCast(sender, Control).Parent, MachineCard)
        End If

        ' Toggle (deselect if clicked again)
        If selectedMachine Is clicked Then
            clicked.BorderStyle = BorderStyle.None
            clicked.BackColor = SystemColors.Control
            selectedMachine = Nothing
            btnRemoveMachine.Enabled = False
            btnConfigure.Enabled = False
            Return
        End If

        ' Clear highlight from all machines
        For Each ctrl As Control In flpMachines.Controls
            If TypeOf ctrl Is MachineCard Then
                DirectCast(ctrl, MachineCard).BorderStyle = BorderStyle.None
                ctrl.BackColor = SystemColors.Control
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

Imports System.Data.OleDb

Public Class MachineCard
    Public Property MachineID As Integer

    Public Property MachineImage As Image
        Get
            Return picMachine.Image
        End Get
        Set(value As Image)
            picMachine.Image = value
        End Set
    End Property

    Public Property UnitNumber As Integer
        Get
            Return CInt(lblUnit.Text.Replace("Unit ", ""))
        End Get
        Set(value As Integer)
            lblUnit.Text = "Unit " & value.ToString()
        End Set
    End Property
    Public Property Capacity As String
        Get
            Return lblWeight.Text
        End Get
        Set(value As String)
            lblWeight.Text = value & " kg"
        End Set
    End Property

    Public Property Status As String
        Get
            Return cmbStatus.SelectedItem?.ToString()
        End Get
        Set(value As String)
            cmbStatus.SelectedItem = value
        End Set
    End Property


End Class

Imports System.Data.OleDb

Public Class MachineCard
    Public Property MachineImage As Image
        Get
            Return picMachine.Image
        End Get
        Set(value As Image)
            picMachine.Image = value
        End Set
    End Property

    Private _machineID As Integer
    Private _unitNumber As Integer
    Private _reason As String

    Public Property MachineID As Integer
        Get
            Return _machineID
        End Get
        Set(value As Integer)
            _machineID = value
            ' Update display with or without reason
            If String.IsNullOrWhiteSpace(_reason) Then
                lblMachineIDText.Text = "Machine ID: " & _machineID.ToString()
            Else
                lblMachineIDText.Text = $"Machine ID: {_machineID} | Reason: {_reason}"
            End If
        End Set
    End Property

    Public Property UnitNumber As Integer
        Get
            Return _unitNumber
        End Get
        Set(value As Integer)
            _unitNumber = value
            ' Only change the label text — the numeric value is stored in _unitNumber
            If value <= 0 Then
                lblUnit.Text = "Unavailable"
            Else
                lblUnit.Text = "Unit " & value.ToString()
            End If
        End Set
    End Property

    Public Property Capacity As String
        Get
            Return lblWeightValue.Text
        End Get
        Set(value As String)
            lblWeightValue.Text = value & " kg"
        End Set
    End Property

    Public Property Status As String
        Get
            Return lblStatus.Text
        End Get
        Set(value As String)
            lblStatus.Text = value
        End Set
    End Property

    ' Keep reason as a backing field and update lblMachineIDText accordingly
    Public Property Reason As String
        Get
            Return _reason
        End Get
        Set(value As String)
            _reason = value
            If _machineID <> 0 Then
                If String.IsNullOrWhiteSpace(_reason) Then
                    lblMachineIDText.Text = "Machine ID: " & _machineID.ToString()
                Else
                    lblMachineIDText.Text = $"Machine ID: {_machineID} | Reason: {_reason}"
                End If
            End If
        End Set
    End Property

End Class

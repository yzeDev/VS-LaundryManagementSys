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
    Private _status As String

    Public ReadOnly Property ProceedButton As Button
        Get
            Return btnProceedMachine
        End Get
    End Property

    Public Property MachineID As Integer
        Get
            Return _machineID
        End Get
        Set(value As Integer)
            _machineID = value
            If String.IsNullOrWhiteSpace(_reason) Then
                lblMachineIDText.Text = "Machine ID: " & _machineID.ToString()
            Else
                lblTransactionID.Text = $"Reason: {_reason}"
            End If
        End Set
    End Property

    Public Property UnitNumber As Integer
        Get
            Return _unitNumber
        End Get
        Set(value As Integer)
            _unitNumber = value
            lblUnit.Text = If(value <= 0, "Unavailable", "Unit " & value.ToString())
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
            Return _status
        End Get
        Set(value As String)
            _status = value
            lblStatus.Text = value
            SetMachineVisuals() ' auto-update visuals when status changes
        End Set
    End Property

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
                    lblTransactionID.Text = $"Reason: {_reason}"
                End If
            End If
        End Set
    End Property

    Private Sub SetMachineVisuals()
        ' Reset defaults
        btnProceedMachine.Enabled = True
        btnProceedMachine.BackColor = Color.LightSkyBlue

        Select Case _status
            Case "Available"
                Try
                    picMachine.Image = Image.FromFile("C:\Users\Eisen\Downloads\laundry-unscreen.gif")
                Catch
                    picMachine.Image = Nothing
                End Try
                lblStatus.ForeColor = Color.Green

            Case "In-Use"
                lblStatus.ForeColor = Color.OrangeRed
                Try
                    picMachine.Image = Image.FromFile("C:\Users\Eisen\Downloads\laundry-working.gif")
                Catch
                    picMachine.Image = Nothing
                End Try
                btnProceedMachine.BackColor = Color.LightGreen
                btnProceedMachine.Text = "Complete"

            Case "Unavailable"
                lblStatus.ForeColor = Color.Gray
                Try
                    picMachine.Image = Image.FromFile("C:\Users\Eisen\Downloads\laundry-unavailable.png")
                Catch
                    picMachine.Image = Nothing
                End Try
                btnProceedMachine.Enabled = False
                btnProceedMachine.BackColor = Color.LightGray

            Case "Damaged"
                lblStatus.ForeColor = Color.Red
                Try
                    picMachine.Image = Image.FromFile("C:\Users\Eisen\Downloads\laundry-damaged.png")
                Catch
                    picMachine.Image = Nothing
                End Try
                btnProceedMachine.Enabled = False
                btnProceedMachine.BackColor = Color.LightGray
        End Select
    End Sub
End Class

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

    Public Property TransactionID As Integer = 0
    Public Property DeliverMethod As String = ""
    Public Property MachineUnit As String ' e.g. "Unit 1"

    Private _machineID As Integer
    Private _unitNumber As Integer
    Private _reason As String
    Private _status As String
    Public originalProceedColor As Color
    Public originalProceedText As String

    ' Change this to match your actual database path or connection setup
    Private ReadOnly connectionString As String =
        "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"

    Public ReadOnly Property ProceedButton As Guna.UI2.WinForms.Guna2Button
        Get
            Return Me.btnProceedMachine
        End Get
    End Property

    Public ReadOnly Property ViewDetailsButton As Guna.UI2.WinForms.Guna2Button
        Get
            Return Me.btnViewDetails
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
            ' Prevent double "kg"
            If value.Trim().EndsWith("kg") Then
                lblWeightValue.Text = value
            Else
                lblWeightValue.Text = value & " kg"
            End If
        End Set
    End Property

    Public Property Status As String
        Get
            Return _status
        End Get
        Set(value As String)
            _status = value
            lblStatus.Text = value
            SetMachineVisuals()
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
        ' Cache original color and text only once
        If originalProceedColor = Nothing OrElse String.IsNullOrEmpty(originalProceedText) Then
            Try
                originalProceedColor = btnProceedMachine.FillColor
                originalProceedText = btnProceedMachine.Text
            Catch
            End Try
        End If

        btnProceedMachine.Enabled = True

        Select Case _status
            Case "Available"
                Try
                    picMachine.Image = Image.FromFile("C:\Users\Eisen\OneDrive\Documents\Assets\available.png")
                Catch
                    picMachine.Image = Nothing
                End Try
                lblStatus.ForeColor = Color.Green
                btnProceedMachine.Text = originalProceedText
                btnProceedMachine.FillColor = originalProceedColor

            Case "In-Use"
                lblStatus.ForeColor = Color.OrangeRed
                Try
                    picMachine.Image = Image.FromFile("C:\Users\Eisen\OneDrive\Documents\Assets\in-use.gif")
                Catch
                    picMachine.Image = Nothing
                End Try
                btnProceedMachine.FillColor = Color.LightGreen
                btnProceedMachine.Text = "Complete"

            Case "Unavailable"
                lblStatus.ForeColor = Color.Gray
                Try
                    picMachine.Image = Image.FromFile("C:\Users\Eisen\OneDrive\Documents\Assets\unavailable.png")
                Catch
                    picMachine.Image = Nothing
                End Try
                btnProceedMachine.Enabled = False
                btnProceedMachine.FillColor = Color.LightGray

            Case "Damaged"
                lblStatus.ForeColor = Color.Red
                Try
                    picMachine.Image = Image.FromFile("C:\Users\Eisen\OneDrive\Documents\Assets\damaged.png")
                Catch
                    picMachine.Image = Nothing
                End Try
                btnProceedMachine.Enabled = False
                btnProceedMachine.FillColor = Color.LightGray
        End Select
    End Sub

    Public Sub LoadMachineDetails(machineID As Integer)
        Dim detailsForm As New MachineDetailsForm()
        detailsForm.TransactionId = Me.TransactionID

        If detailsForm.TransactionId > 0 Then
            detailsForm.ShowDialog()
        Else
            MessageBox.Show("No active transaction for this machine.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' 🔹 New: Assigns a pending transaction and updates DB to "In-Progress"
    Public Sub AssignPendingTransaction(transactionID As Integer)
        If transactionID <= 0 Then Exit Sub

        Me.TransactionID = transactionID ' ✅ Corrected line
        Dim unitLabel As String = $"Unit {UnitNumber}"

        Try
            Using con As New OleDbConnection(connectionString)
                con.Open()

                Dim query As String =
                    "UPDATE Transactions " &
                    "SET Status = 'In-Progress', MachineUsed = @MachineUsed " &
                    "WHERE TransactionID = @TransactionID AND Status = 'Pending'"

                Using cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("@MachineUsed", unitLabel)
                    cmd.Parameters.AddWithValue("@TransactionID", Me.TransactionID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Reflect visually on the machine card
            lblStatus.Text = "In-Progress"
            lblStatus.ForeColor = Color.Orange
            Status = "In-Use"

        Catch ex As Exception
            MessageBox.Show("Error updating transaction status: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class

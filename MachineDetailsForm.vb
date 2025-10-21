Imports System.Data.OleDb

Public Class MachineDetailsForm

    Public Property TransactionId As Integer

    Private connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"

    Private Sub MachineDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TransactionId > 0 Then
            LoadTransactionDetails()
        Else
            MessageBox.Show("No transaction data available for this machine.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    ' ✅ Loads all transaction details into your label controls
    Private Sub LoadTransactionDetails()
        Try
            Using conn As New OleDbConnection(connStr)
                conn.Open()

                Dim sql As String = "SELECT * FROM Transactions WHERE TransactionID = @id"
                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", TransactionId)

                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            lblMachineNum.Text = reader("MachineUsed").ToString()
                            lblServiceType.Text = reader("ServiceType").ToString()
                            lblCustomerName.Text = reader("CustomerName").ToString()
                            lblDeliverMethod.Text = reader("DeliverMethod").ToString()
                            lblContactNum.Text = reader("ContactNumber").ToString()
                            lblAddress.Text = reader("Address").ToString()
                            lblTransactionWeight.Text = reader("Weight").ToString() & " kg"
                            lblPaymentMethod.Text = reader("PaymentMethod").ToString()

                            ' ✅ Transaction Date (formatted)
                            If Not IsDBNull(reader("TransactionDate")) Then
                                lblDate.Text = "Date: " & Convert.ToDateTime(reader("TransactionDate")).ToString("MMMM dd, yyyy - hh:mm tt")
                            Else
                                lblDate.Text = "Date: N/A"
                            End If
                        Else
                            MessageBox.Show("Transaction not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Me.Close()
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading transaction details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ✅ Close button handler
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    ' Loads transaction details associated with a specific machine
    Public Sub LoadMachineDetails(machineId As Integer)
        Using conn As New OleDbConnection(connStr)
            conn.Open()

            ' Find the most recent active transaction for this machine
            Dim sql As String = "
            SELECT TOP 1 * 
            FROM Transactions 
            WHERE MachineUsed=@machineId 
              AND (Status='In-Progress' OR Status='Pending')
            ORDER BY TransactionDate DESC"

            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@machineId", machineId)

                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' ✅ Assign transaction info to your labels
                        lblMachineNum.Text = reader("MachineUsed").ToString()
                        lblServiceType.Text = reader("ServiceType").ToString()
                        lblCustomerName.Text = reader("CustomerName").ToString()
                        lblDeliverMethod.Text = reader("DeliverMethod").ToString()
                        lblContactNum.Text = reader("ContactNumber").ToString()
                        lblAddress.Text = reader("Address").ToString()
                        lblTransactionWeight.Text = reader("Weight").ToString() & " kg"
                        lblPaymentMethod.Text = reader("PaymentMethod").ToString()

                        ' Date label
                        If reader("TransactionDate") IsNot DBNull.Value Then
                            lblDate.Text = "Date: " & Convert.ToDateTime(reader("TransactionDate")).ToString("MMMM dd, yyyy")
                        Else
                            lblDate.Text = "Date: N/A"
                        End If

                        ' Store the transaction ID for reference
                        Me.TransactionId = Convert.ToInt32(reader("TransactionID"))
                    Else
                        MessageBox.Show("No active transaction found for this machine.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        End Using
    End Sub

    Public Sub LoadMachineDetailsByMachineID(machineID As Integer)
        Using conn As New OleDbConnection(connStr)
            conn.Open()

            ' Convert MachineID to UnitNumber string (as stored in MachineUsed)
            Dim unitNumber As String = ""
            Using cmd As New OleDbCommand("SELECT UnitNumber FROM UnitData WHERE ID=@mid", conn)
                cmd.Parameters.AddWithValue("@mid", machineID)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                    unitNumber = "Unit " & Convert.ToInt32(result).ToString()
                End If
            End Using

            If String.IsNullOrEmpty(unitNumber) Then
                MessageBox.Show("Machine not found in database.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' Get most recent active transaction for this machine
            Dim sql As String = "
            SELECT TOP 1 * 
            FROM Transactions 
            WHERE MachineUsed=@unitNumber 
              AND (Status='Pending' OR Status='In-Progress')
            ORDER BY TransactionDate DESC"

            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@unitNumber", unitNumber)
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Fill labels
                        lblMachineNum.Text = reader("MachineUsed").ToString()
                        lblServiceType.Text = reader("ServiceType").ToString()
                        lblCustomerName.Text = reader("CustomerName").ToString()
                        lblDeliverMethod.Text = reader("DeliverMethod").ToString()
                        lblContactNum.Text = reader("ContactNumber").ToString()
                        lblAddress.Text = reader("Address").ToString()
                        lblTransactionWeight.Text = reader("Weight").ToString() & " kg"
                        lblPaymentMethod.Text = reader("PaymentMethod").ToString()
                        lblDate.Text = If(reader("TransactionDate") IsNot DBNull.Value,
                                      "Date: " & Convert.ToDateTime(reader("TransactionDate")).ToString("MMMM dd, yyyy - hh:mm tt"),
                                      "Date: N/A")
                        Me.TransactionId = Convert.ToInt32(reader("TransactionID"))
                    Else
                        MessageBox.Show("No active transaction found for this machine.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ServiceType_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblPaymentMethod_Click(sender As Object, e As EventArgs) Handles lblPaymentMethod.Click

    End Sub

    Private Sub lblTitle_Click_1(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class

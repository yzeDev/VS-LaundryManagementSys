Imports System.Data.OleDb

Public Class ConfigureMachineForm
    Public Property UnitNumber As Integer
    Public Property Capacity As Integer
    Public Property Status As String

    Private Sub ConfigureMachineForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show($"Loaded Unit {UnitNumber}, Cap={Capacity}, Status={Status}")

        lblUnitNumber.Text = UnitNumber.ToString()
        nudCapacity.Minimum = 5
        nudCapacity.Maximum = 50
        nudCapacity.Value = Capacity

        cboStatus.Items.Clear()
        cboStatus.Items.AddRange(New String() {"Available", "Maintenance"})
        If Not String.IsNullOrEmpty(Status) Then
            cboStatus.SelectedItem = Status
        Else
            cboStatus.SelectedIndex = 0
        End If
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        Capacity = CInt(nudCapacity.Value)
        Status = cboStatus.SelectedItem.ToString

        Using conn As New OleDbConnection(Db.ConnectionString)
            conn.Open()
            Dim query = "UPDATE UnitData SET Capacity=@cap, Status=@status WHERE UnitNumber=@unit"
            Using cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@cap", Capacity)
                cmd.Parameters.AddWithValue("@status", Status)
                cmd.Parameters.AddWithValue("@unit", UnitNumber)

                Dim rows = cmd.ExecuteNonQuery
                MessageBox.Show($"Rows updated: {rows}")
            End Using
        End Using

        DialogResult = DialogResult.OK
        Close()
    End Sub

End Class

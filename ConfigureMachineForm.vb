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

        Using conn As New OleDbConnection(ConnectionString)
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

    Private Sub SplitContainer3_SplitterMoved(sender As Object, e As SplitterEventArgs)

    End Sub

    Private Sub SplitContainer3_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer3.Panel2.Paint

    End Sub

    Private Sub lblUnitNumber_Click(sender As Object, e As EventArgs) Handles lblUnitNumber.Click

    End Sub

    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub nudCapacity_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SplitContainer2_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer2.Panel1.Paint

    End Sub

    Private Sub nudCapacity_ValueChanged_1(sender As Object, e As EventArgs) Handles nudCapacity.ValueChanged

    End Sub
End Class

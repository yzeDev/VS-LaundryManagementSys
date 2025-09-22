Imports System.Data.OleDb

Public Class MainForm

    Private Sub ShowControl(ctrl As UserControl)
        MainPanel.Controls.Clear()
        ctrl.Dock = DockStyle.Fill  ' <- here we force it to resize and fill MainPanel
        MainPanel.Controls.Add(ctrl)

    End Sub

    ' Single event handler for all navigation buttons
    Private Sub Navigation_Click(sender As Object, e As EventArgs) Handles btnMachines.Click, btnTransactions.Click, btnStats.Click, btnOptions.Click
        Dim clickedButton As Button = DirectCast(sender, Button)
        Dim ctrl As UserControl = Nothing

        Select Case clickedButton.Name
            Case "btnMachines"
                ctrl = New MachinesControl()
            Case "btnTransactions"
                ctrl = New TransactionsControl()
            Case "btnStats"
                ctrl = New StatsControl()
            Case "btnOptions"
                ctrl = New OptionsControl()

        End Select

        If ctrl IsNot Nothing Then
            ShowControl(ctrl)
        End If
    End Sub

End Class

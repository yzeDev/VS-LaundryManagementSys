Public Class TransactionOption

    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click
        Me.Close()
    End Sub

    ' Shared event handler for all buttons (Guna or regular)
    Private Sub ServiceButton_Click(sender As Object, e As EventArgs) _
        Handles selfServBtn.Click, basicServBtn.Click, dryCleanBtn.Click, fullServBtn.Click

        ' Use the Control class to avoid casting issues
        Dim clickedControl As Control = DirectCast(sender, Control)
        Dim btnName As String = clickedControl.Name

        Dim selectedForm As Form = Nothing

        Select Case btnName
            Case "selfServBtn"
                selectedForm = New SelfServiceForm()
            Case "basicServBtn"
                selectedForm = New BasicServiceForm()
            Case "dryCleanBtn"
                selectedForm = New DryCleaningForm()
            Case "fullServBtn"
                selectedForm = New FullServiceForm()
            Case Else
                Exit Sub
        End Select

        ' Close this form
        Me.Close()

        ' Open the selected form
        selectedForm?.Show()
    End Sub

End Class

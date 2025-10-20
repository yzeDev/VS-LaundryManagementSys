Public Class TransactionOption

    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click
        Me.Close()
    End Sub

    ' Shared event handler for all service buttons
    Private Sub ServiceButton_Click(sender As Object, e As EventArgs) Handles selfServBtn.Click, basicServBtn.Click, dryCleanBtn.Click, fullServBtn.Click
        Dim selectedForm As Form = Nothing

        Select Case CType(sender, Button).Name
            Case "selfServBtn"
                selectedForm = New SelfServiceForm()
            Case "basicServBtn"
                selectedForm = New BasicServiceForm()
            Case "dryCleanBtn"
                selectedForm = New DryCleaningForm()
            Case "fullServBtn"
                selectedForm = New FullServiceForm()
        End Select

        ' Close this dialog before opening new one
        Me.Close()

        ' Show the corresponding form if found
        If selectedForm IsNot Nothing Then
            selectedForm.ShowDialog()
        End If
    End Sub

End Class

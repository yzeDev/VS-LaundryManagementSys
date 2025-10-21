Public Class PaymentSuccessful
    Private loadingTimer As Timer
    Private progressValue As Double = 0

    Private Sub PaymentSuccessful_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar.Value = 0
        ProgressBar.Minimum = 0
        ProgressBar.Maximum = 100

        StartLoadingAnimation()
    End Sub

    Private Sub StartLoadingAnimation()
        progressValue = 0
        ProgressBar.Value = 0

        loadingTimer = New Timer()
        loadingTimer.Interval = 30
        AddHandler loadingTimer.Tick, AddressOf LoadingTimer_Tick

        loadingTimer.Start()
    End Sub

    Private Sub LoadingTimer_Tick(sender As Object, e As EventArgs)
        progressValue += 1

        If progressValue <= 100 Then
            ProgressBar.Value = CInt(progressValue)
        End If

        If progressValue >= 100 Then
            loadingTimer.Stop()
            loadingTimer.Dispose()

            ' Open Receipt form
            Dim receiptForm As New Receipt()

            AddHandler receiptForm.FormClosed, Sub(s, args)
                                                   Application.Exit()
                                               End Sub

            receiptForm.Show()

        End If
    End Sub

    Private Sub ProgressBar_ValueChanged(sender As Object, e As EventArgs) Handles ProgressBar.ValueChanged

    End Sub
End Class
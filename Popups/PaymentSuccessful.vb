Public Class PaymentSuccessful
    Private loadingTimer As Timer
    Private progressValue As Double = 0

    ' === Properties to receive from caller ===
    Public Property PaymentMethod As String
    Public Property TransactionID As Long
    Public Property Timestamp As DateTime = DateTime.Now
    Public Property AmountPaid As Decimal

    ' === When form loads ===
    Private Sub PaymentSuccessful_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Bind label texts
        lblPaymentMethod.Text = If(String.IsNullOrWhiteSpace(PaymentMethod), "—", PaymentMethod)
        lblTransactionID.Text = If(TransactionID > 0, TransactionID.ToString("00000"), "—")
        lblDateTime.Text = Timestamp.ToString("MMMM dd, yyyy h:mm tt")
        lblAmountPaid.Text = "₱ " & AmountPaid.ToString("N2")

        ' Initialize progress bar
        ProgressBar.Value = 0
        ProgressBar.Minimum = 0
        ProgressBar.Maximum = 100

        StartLoadingAnimation()
    End Sub

    ' === Start the loading animation ===
    Private Sub StartLoadingAnimation()
        progressValue = 0
        ProgressBar.Value = 0

        loadingTimer = New Timer() With {.Interval = 30}
        AddHandler loadingTimer.Tick, AddressOf LoadingTimer_Tick
        loadingTimer.Start()
    End Sub

    ' === Loading animation logic ===
    Private Sub LoadingTimer_Tick(sender As Object, e As EventArgs)
        progressValue += 1

        If progressValue <= 100 Then
            ProgressBar.Value = CInt(progressValue)
        End If

        If progressValue >= 100 Then
            loadingTimer.Stop()
            loadingTimer.Dispose()

            ' Return control to caller (Invoice)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class

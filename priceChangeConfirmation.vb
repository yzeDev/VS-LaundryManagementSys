Public Class priceChangeConfirmation
    Private priceChanges As List(Of PriceChange)

    ' Constructor to receive changes
    Public Sub New(changes As List(Of PriceChange))
        InitializeComponent()
        Me.priceChanges = changes
    End Sub

    Private Sub priceChangeConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateChanges()
    End Sub

    Private Sub PopulateChanges()
        priceSummary.Controls.Clear()
        priceSummary.AutoScroll = True

        Dim yPos As Integer = 10

        ' Loop through changes and create labels
        For Each change In priceChanges
            ' Service: ₱oldPrice → ₱newPrice
            Dim lblChange As New Label()
            lblChange.Text = change.ServiceName & ": ₱" & change.OldPrice.ToString("0.00") & " → ₱" & change.NewPrice.ToString("0.00")
            lblChange.Location = New Point(10, yPos)
            lblChange.Size = New Size(priceSummary.Width - 30, 30)
            lblChange.BackColor = Color.White
            lblChange.BorderStyle = BorderStyle.None
            lblChange.Font = New Font("Poppins", 9)
            lblChange.ForeColor = ColorTranslator.FromHtml("#545454")
            lblChange.TextAlign = ContentAlignment.MiddleLeft
            lblChange.Padding = New Padding(10, 0, 10, 10)

            ' Add to panel
            priceSummary.Controls.Add(lblChange)

            ' Move down for next item
            yPos += 35
        Next


        If priceChanges.Count > 0 Then

            Dim lblSpacer As New Label()
            lblSpacer.Location = New Point(10, yPos)
            lblSpacer.Size = New Size(10, 10)
            lblSpacer.BackColor = Color.Transparent
            lblSpacer.Text = ""

            priceSummary.Controls.Add(lblSpacer)
        End If

    End Sub
End Class

Public Class PriceChange
    Public Property ServiceName As String
    Public Property OldPrice As Decimal
    Public Property NewPrice As Decimal
End Class
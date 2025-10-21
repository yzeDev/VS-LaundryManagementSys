Public Class PriceSettingsControl

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        ' Create list to store changes
        Dim changes As New List(Of PriceChange)

        ' SELF SERVICE
        If Not String.IsNullOrWhiteSpace(selfservice_new1.Text) Then
            Dim newPrice As Decimal
            If Decimal.TryParse(selfservice_new1.Text, newPrice) Then
                Dim oldPrice As Decimal
                Decimal.TryParse(selfservice_current1.Text.Replace("₱", "").Trim(), oldPrice)
                changes.Add(New PriceChange With {
                .ServiceName = "Self Service - Wash Only",
                .OldPrice = oldPrice,
                .NewPrice = newPrice
            })
            End If
        End If

        If Not String.IsNullOrWhiteSpace(selfservice_new2.Text) Then
            Dim newPrice As Decimal
            If Decimal.TryParse(selfservice_new2.Text, newPrice) Then
                Dim oldPrice As Decimal
                Decimal.TryParse(selfservice_current2.Text.Replace("₱", "").Trim(), oldPrice)
                changes.Add(New PriceChange With {
                .ServiceName = "Self Service - Dry Only",
                .OldPrice = oldPrice,
                .NewPrice = newPrice
            })
            End If
        End If

        If Not String.IsNullOrWhiteSpace(selfservice_new3.Text) Then
            Dim newPrice As Decimal
            If Decimal.TryParse(selfservice_new3.Text, newPrice) Then
                Dim oldPrice As Decimal
                Decimal.TryParse(selfservice_current3.Text.Replace("₱", "").Trim(), oldPrice)
                changes.Add(New PriceChange With {
                .ServiceName = "Self Service - Wash + Dry",
                .OldPrice = oldPrice,
                .NewPrice = newPrice
            })
            End If
        End If

        ' BASIC SERVICES
        If Not String.IsNullOrWhiteSpace(basicservice_new1.Text) Then
            Dim newPrice As Decimal
            If Decimal.TryParse(basicservice_new1.Text, newPrice) Then
                Dim oldPrice As Decimal
                Decimal.TryParse(basicservice_current1.Text.Replace("₱", "").Trim(), oldPrice)
                changes.Add(New PriceChange With {
                .ServiceName = "Basic Service - Wash Only",
                .OldPrice = oldPrice,
                .NewPrice = newPrice
            })
            End If
        End If

        If Not String.IsNullOrWhiteSpace(basicservice_new2.Text) Then
            Dim newPrice As Decimal
            If Decimal.TryParse(basicservice_new2.Text, newPrice) Then
                Dim oldPrice As Decimal
                Decimal.TryParse(basicservice_current2.Text.Replace("₱", "").Trim(), oldPrice)
                changes.Add(New PriceChange With {
                .ServiceName = "Basic Service - Dry Only",
                .OldPrice = oldPrice,
                .NewPrice = newPrice
            })
            End If
        End If

        If Not String.IsNullOrWhiteSpace(basicservice_new3.Text) Then
            Dim newPrice As Decimal
            If Decimal.TryParse(basicservice_new3.Text, newPrice) Then
                Dim oldPrice As Decimal
                Decimal.TryParse(basicservice_current3.Text.Replace("₱", "").Trim(), oldPrice)
                changes.Add(New PriceChange With {
                .ServiceName = "Basic Service - Wash + Dry",
                .OldPrice = oldPrice,
                .NewPrice = newPrice
            })
            End If
        End If

        ' FULL SERVICE
        If Not String.IsNullOrWhiteSpace(fullservice_new2.Text) Then
            Dim newPrice As Decimal
            If Decimal.TryParse(fullservice_new2.Text, newPrice) Then
                Dim oldPrice As Decimal
                Decimal.TryParse(fullservice_current2.Text.Replace("₱", "").Trim(), oldPrice)
                changes.Add(New PriceChange With {
                .ServiceName = "Full Service",
                .OldPrice = oldPrice,
                .NewPrice = newPrice
            })
            End If
        End If

        ' DRY CLEANING
        If Not String.IsNullOrWhiteSpace(dryclean_new1.Text) Then
            Dim newPrice As Decimal
            If Decimal.TryParse(dryclean_new1.Text, newPrice) Then
                Dim oldPrice As Decimal
                Decimal.TryParse(dryclean_current1.Text.Replace("₱", "").Trim(), oldPrice)
                changes.Add(New PriceChange With {
                .ServiceName = "Dry Cleaning - Small Item",
                .OldPrice = oldPrice,
                .NewPrice = newPrice
            })
            End If
        End If

        If Not String.IsNullOrWhiteSpace(dryclean_new2.Text) Then
            Dim newPrice As Decimal
            If Decimal.TryParse(dryclean_new2.Text, newPrice) Then
                Dim oldPrice As Decimal
                Decimal.TryParse(dryclean_current2.Text.Replace("₱", "").Trim(), oldPrice)
                changes.Add(New PriceChange With {
                .ServiceName = "Dry Cleaning - Medium Item",
                .OldPrice = oldPrice,
                .NewPrice = newPrice
            })
            End If
        End If

        If Not String.IsNullOrWhiteSpace(dryclean_new3.Text) Then
            Dim newPrice As Decimal
            If Decimal.TryParse(dryclean_new3.Text, newPrice) Then
                Dim oldPrice As Decimal
                Decimal.TryParse(dryclean_current3.Text.Replace("₱", "").Trim(), oldPrice)
                changes.Add(New PriceChange With {
                .ServiceName = "Dry Cleaning - Large Item",
                .OldPrice = oldPrice,
                .NewPrice = newPrice
            })
            End If
        End If

        ' Check if there are any changes
        If changes.Count = 0 Then
            MessageBox.Show("No price changes detected.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Open confirmation form
        Dim confirmForm As New priceChangeConfirmation(changes)
        confirmForm.ShowDialog()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PriceSettingsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Load

    End Sub

    Private Sub RightPanel_Paint(sender As Object, e As PaintEventArgs) Handles RightPanel.Paint

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs)

    End Sub


End Class

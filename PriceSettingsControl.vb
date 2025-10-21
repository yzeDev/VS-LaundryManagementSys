Imports System.Data.OleDb
Imports Guna.UI2.WinForms

Public Class PriceSettingsControl

    Private connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\laundryfiles\Resources\LaundryDatabase.accdb;"

    Private Sub PriceSettingsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCurrentPrices()

        '  Apply numeric-only restriction to all price input boxes
        AddHandler selfservice_newWash.KeyPress, AddressOf OnlyNumericInput
        AddHandler selfservice_newDry.KeyPress, AddressOf OnlyNumericInput
        AddHandler selfservice_newWashDry.KeyPress, AddressOf OnlyNumericInput

        AddHandler basicservice_newWash.KeyPress, AddressOf OnlyNumericInput
        AddHandler basicservice_newDry.KeyPress, AddressOf OnlyNumericInput
        AddHandler basicservice_newWashDry.KeyPress, AddressOf OnlyNumericInput

        AddHandler fullservice_new2.KeyPress, AddressOf OnlyNumericInput

        AddHandler dryclean_newSmall.KeyPress, AddressOf OnlyNumericInput
        AddHandler dryclean_newMedium.KeyPress, AddressOf OnlyNumericInput
        AddHandler dryclean_newLarge.KeyPress, AddressOf OnlyNumericInput
    End Sub

    '  Load latest prices from database (based on most recent lastUpdated)
    Private Sub LoadCurrentPrices()
        SetDefaultPrices()

        Using conn As New OleDbConnection(connString)
            conn.Open()

            Dim query As String = "
            SELECT P.ServiceType, P.SubService, P.Price
            FROM PricingUpd AS P
            INNER JOIN (
                     SELECT ServiceType, SubService, MAX(LastUpdated) AS MaxDate
                     FROM PricingUpd
                     GROUP BY ServiceType, SubService
            ) AS Latest
            ON P.ServiceType = Latest.ServiceType 
            AND P.SubService = Latest.SubService 
            AND P.LastUpdated = Latest.MaxDate"

            Dim cmd As New OleDbCommand(query, conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim serviceType As String = reader("ServiceType").ToString().Trim().ToLower()
                Dim subService As String = reader("SubService").ToString().Trim().ToLower()
                Dim price As Decimal = Convert.ToDecimal(reader("Price"))

                Select Case serviceType
                    Case "self service"
                        Select Case subService
                            Case "wash only"
                                selfservice_currentWash.Text = "₱" & price.ToString("0.00")
                            Case "dry only"
                                selfservice_currentDry.Text = "₱" & price.ToString("0.00")
                            Case "wash + dry"
                                selfservice_currentWashDry.Text = "₱" & price.ToString("0.00")
                        End Select

                    Case "basic service"
                        Select Case subService
                            Case "wash only"
                                basicservice_currentWash.Text = "₱" & price.ToString("0.00")
                            Case "dry only"
                                basicservice_currentDry.Text = "₱" & price.ToString("0.00")
                            Case "wash + dry"
                                basicservice_currentWashDry.Text = "₱" & price.ToString("0.00")
                        End Select

                    Case "full service"
                        If subService = "wash, dry, and fold" Then
                            fullservice_currentWash.Text = "₱" & price.ToString("0.00")
                        End If

                    Case "dry cleaning"
                        Select Case subService
                            Case "small"
                                dryclean_currentSmall.Text = "₱" & price.ToString("0.00")
                            Case "medium"
                                dryclean_currentMedium.Text = "₱" & price.ToString("0.00")
                            Case "large"
                                dryclean_currentLarge.Text = "₱" & price.ToString("0.00")
                        End Select
                End Select
            End While
        End Using
    End Sub

    '  Save button — checks for changes and opens confirmation form
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Dim changes As New List(Of PriceChange)

        ' Function to check and add change
        Dim addChange = Sub(serviceName As String, oldLabel As Label, newBox As Guna2TextBox)
                            If newBox.Text.Trim() <> "" Then
                                Dim oldValue As Decimal = Decimal.Parse(oldLabel.Text.Replace("₱", "").Trim())
                                Dim newValue As Decimal = Decimal.Parse(newBox.Text.Trim())
                                If oldValue <> newValue Then
                                    changes.Add(New PriceChange With {
                                        .ServiceName = serviceName,
                                        .OldPrice = oldValue,
                                        .NewPrice = newValue
                                    })
                                End If
                            End If
                        End Sub

        '  Check all services
        addChange("Self Service - Wash Only", selfservice_currentWash, selfservice_newWash)
        addChange("Self Service - Dry Only", selfservice_currentDry, selfservice_newDry)
        addChange("Self Service - Wash + Dry", selfservice_currentWashDry, selfservice_newWashDry)

        addChange("Basic Service - Wash Only", basicservice_currentWash, basicservice_newWash)
        addChange("Basic Service - Dry Only", basicservice_currentDry, basicservice_newDry)
        addChange("Basic Service - Wash + Dry", basicservice_currentWashDry, basicservice_newWashDry)

        addChange("Full Service - Wash, Dry, and Fold", fullservice_currentWash, fullservice_new2)

        addChange("Dry Cleaning - Small", dryclean_currentSmall, dryclean_newSmall)
        addChange("Dry Cleaning - Medium", dryclean_currentMedium, dryclean_newMedium)
        addChange("Dry Cleaning - Large", dryclean_currentLarge, dryclean_newLarge)

        '  If no changes
        If changes.Count = 0 Then
            MessageBox.Show("No price changes detected.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        '  Open confirmation form
        Dim confirmForm As New priceChangeConfirmation(changes)
        confirmForm.ShowDialog()

        ' Refresh after confirmation
        LoadCurrentPrices()
    End Sub

    ' Default ₱0.00 text
    Private Sub SetDefaultPrices()
        selfservice_currentWash.Text = "₱0.00"
        selfservice_currentDry.Text = "₱0.00"
        selfservice_currentWashDry.Text = "₱0.00"

        basicservice_currentWash.Text = "₱0.00"
        basicservice_currentDry.Text = "₱0.00"
        basicservice_currentWashDry.Text = "₱0.00"

        fullservice_currentWash.Text = "₱0.00"

        dryclean_currentSmall.Text = "₱0.00"
        dryclean_currentMedium.Text = "₱0.00"
        dryclean_currentLarge.Text = "₱0.00"
    End Sub
    '  Allow only numeric input and one decimal point
    Private Sub OnlyNumericInput(sender As Object, e As KeyPressEventArgs)
        Dim txt As Guna2TextBox = CType(sender, Guna2TextBox)

        ' Allow control keys (Backspace, Delete, etc.)
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        ' Allow digits
        If Char.IsDigit(e.KeyChar) Then
            Return
        End If

        ' Allow one decimal point only
        If e.KeyChar = "."c AndAlso Not txt.Text.Contains(".") Then
            Return
        End If

        ' Block all other characters
        e.Handled = True
    End Sub
End Class

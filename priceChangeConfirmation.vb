Imports System.Data.OleDb

Public Class priceChangeConfirmation
    Private priceChanges As List(Of PriceChange)
    Private connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\laundryfiles\Resources\LaundryDatabase.accdb;"

    ' Constructor
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
        For Each change In priceChanges
            Dim lblChange As New Label()
            lblChange.Text = $"{change.ServiceName}: ₱{change.OldPrice:0.00} → ₱{change.NewPrice:0.00}"
            lblChange.Location = New Point(10, yPos)
            lblChange.Size = New Size(priceSummary.Width - 30, 30)
            lblChange.Font = New Font("Poppins", 9)
            lblChange.ForeColor = ColorTranslator.FromHtml("#545454")
            lblChange.BackColor = Color.White
            lblChange.Padding = New Padding(10, 0, 10, 10)
            priceSummary.Controls.Add(lblChange)
            yPos += 35
        Next
    End Sub

    ' ✅ Confirm button → add new row for each price change (keep old rows)
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Using conn As New OleDbConnection(connString)
            Try
                conn.Open()

                For Each change In priceChanges
                    ' Split ServiceName into ServiceType and SubService
                    Dim parts = change.ServiceName.Split("-"c)
                    Dim serviceType As String = parts(0).Trim()
                    Dim subService As String = parts(1).Trim()

                    ' Determine unit
                    Dim unit As String = If(serviceType.ToLower().Contains("dry cleaning"), "per pc", "per kg")

                    ' Validate price
                    Dim newPrice As Double
                    If Not Double.TryParse(change.NewPrice.ToString(), newPrice) Then
                        MessageBox.Show($"Invalid price for {change.ServiceName}. Skipping this entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Continue For
                    End If

                    ' INSERT query to add a new row
                    Dim cmd As New OleDbCommand("
                        INSERT INTO PricingUpd (ServiceType, SubService, Price, Unit, LastUpdated)
                        VALUES (?, ?, ?, ?, ?)", conn)


                    cmd.Parameters.Add("ServiceType", OleDbType.VarWChar).Value = serviceType
                    cmd.Parameters.Add("SubService", OleDbType.VarWChar).Value = subService
                    cmd.Parameters.Add("Price", OleDbType.Double).Value = newPrice
                    cmd.Parameters.Add("Unit", OleDbType.VarWChar).Value = unit
                    cmd.Parameters.Add("LastUpdated", OleDbType.Date).Value = DateTime.Now

                    cmd.ExecuteNonQuery()
                Next

                MessageBox.Show("All price changes have been added successfully with updated timestamps and units!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()

            Catch ex As Exception
                MessageBox.Show("Error saving price changes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Me.Hide()
    End Sub
End Class

Public Class PriceChange
    Public Property ServiceName As String
    Public Property OldPrice As Decimal
    Public Property NewPrice As Decimal
End Class

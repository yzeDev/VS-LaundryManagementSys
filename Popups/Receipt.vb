Imports System.Data.OleDb
Imports System.Drawing.Imaging
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class Receipt

    ' ===== Incoming values from NewInvoiceForm =====
    Public Property ReferenceNumber As String
    Public Property CustomerName As String
    Public Property ContactNumber As String
    Public Property Address As String
    Public Property Weight As Decimal
    Public Property ServiceType As String
    Public Property PackageType As String
    Public Property Rate As Decimal
    Public Property ServiceFee As Decimal
    Public Property DeliveryFee As Decimal
    Public Property TotalAmount As Decimal
    Public Property PaymentMethod As String
    Public Property DeliveryMode As String
    Public Property AmountReceived As Decimal
    Public Property ChangeAmount As Decimal
    Public Property TransactionDate As DateTime = DateTime.Now

    Public Property OptionType As String

    ' ===== Internal =====
    Private _transactionId As Long = 0
    Private _saved As Boolean = False

    ' ===== Form lifecycle =====
    Private Sub Receipt_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Try
            ' 1) Display current date/time
            lblCurrentDate.Text = TransactionDate.ToString("MMMM dd, yyyy")
            lblCurrentTime.Text = TransactionDate.ToString("h:mm tt")

            ' 2) Display all passed data
            lblName.Text = If(String.IsNullOrWhiteSpace(CustomerName), "—", CustomerName)
            lblContact.Text = If(String.IsNullOrWhiteSpace(ContactNumber), "N/A", ContactNumber)
            lblAddress.Text = If(String.IsNullOrWhiteSpace(Address), "N/A", Address)

            lblServiceType.Text = If(String.IsNullOrWhiteSpace(ServiceType), "—", ServiceType)
            lblRate.Text = If(Rate <= 0, "—", "₱" & Rate.ToString("N2") & "/kg")
            lblWeight.Text = If(Weight > 0, Weight.ToString("F2") & " kg", "—")
            lblStatus.Text = If(String.IsNullOrWhiteSpace(DeliveryMode), "—", DeliveryMode)

            lblServiceFee.Text = "₱" & ServiceFee.ToString("N2")
            lblDeliveryFee.Text = "₱" & DeliveryFee.ToString("N2")
            lblPaymentMethod.Text = If(String.IsNullOrWhiteSpace(PaymentMethod), "—", PaymentMethod)
            lblTotalAmount.Text = "₱" & TotalAmount.ToString("N2")

            lbltotalAmountPaid.Text = If(AmountReceived > 0, "₱" & AmountReceived.ToString("N2"), "₱0.00")
            lblChange.Text = If(ChangeAmount > 0, "₱" & ChangeAmount.ToString("N2"), "₱0.00")

            ' 3) Save once and get Transaction ID
            If Not _saved Then
                _transactionId = InsertTransactionAndReturnId()
                _saved = True
            End If

            ' 4) Display the generated Transaction ID
            lblTransactionID.Text = _transactionId.ToString("00000")

        Catch ex As Exception
            MessageBox.Show("Error displaying receipt: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ===== Insert transaction into Access and return ID =====
    Private Function InsertTransactionAndReturnId() As Long
        Dim newId As Long = 0
        Dim sql As String =
            "INSERT INTO Transactions " &
            "(CustomerName, ServiceType, [Status], [TransactionDate], TotalPayment, ContactNumber, [Address], " &
            "PaymentMethod, AmountReceived, [Change], DeliverMethod, [Weight], ReferenceNum) " &
            "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"

        Try
            Using cn As New OleDbConnection(Db.ConnectionString)
                cn.Open()
                Using tx = cn.BeginTransaction()
                    Using cmd As New OleDbCommand(sql, cn, tx)
                        cmd.Parameters.Add("?", OleDbType.VarWChar, 255).Value = If(CustomerName, "")
                        cmd.Parameters.Add("?", OleDbType.VarWChar, 100).Value = If(ServiceType, "")
                        cmd.Parameters.Add("?", OleDbType.VarWChar, 50).Value = "Pending"
                        cmd.Parameters.Add("?", OleDbType.Date).Value = TransactionDate
                        cmd.Parameters.Add("?", OleDbType.Currency).Value = TotalAmount
                        cmd.Parameters.Add("?", OleDbType.LongVarWChar).Value = If(ContactNumber, "")
                        cmd.Parameters.Add("?", OleDbType.VarWChar, 255).Value = If(Address, "")
                        cmd.Parameters.Add("?", OleDbType.VarWChar, 50).Value = If(PaymentMethod, "")
                        cmd.Parameters.Add("?", OleDbType.Currency).Value = AmountReceived
                        cmd.Parameters.Add("?", OleDbType.Currency).Value = ChangeAmount
                        cmd.Parameters.Add("?", OleDbType.VarWChar, 50).Value = If(DeliveryMode, "")
                        cmd.Parameters.Add("?", OleDbType.Double).Value = Convert.ToDouble(Weight)
                        cmd.Parameters.Add("?", OleDbType.VarWChar, 20).Value = If(ReferenceNumber, "")
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Get new ID
                    Using idCmd As New OleDbCommand("SELECT @@IDENTITY", cn, tx)
                        Dim scalar = idCmd.ExecuteScalar()
                        If scalar IsNot Nothing AndAlso Not IsDBNull(scalar) Then
                            newId = Convert.ToInt64(scalar)
                        End If
                    End Using

                    tx.Commit()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving transaction: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return newId
    End Function

    ' ===== Close button =====
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    ' ===== Download Receipt (PDF) =====
    Private Sub btnDownloadReceipt_Click(sender As Object, e As EventArgs) Handles btnDownloadReceipt.Click
        Try
            Dim saveDialog As New SaveFileDialog With {
            .Filter = "PDF files (*.pdf)|*.pdf",
            .FileName = $"Receipt_{_transactionId:00000}.pdf"
        }
            If saveDialog.ShowDialog() <> DialogResult.OK Then Exit Sub

            ' Ensure form is visible and not minimized
            If Me.WindowState = FormWindowState.Minimized Then
                MessageBox.Show("Please restore the receipt window before downloading the PDF.", "Restore Window", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' Capture area size (use ClientSize if you want inner content only)
            Dim captureSize = Me.Size
            Dim bmp As New Bitmap(captureSize.Width, captureSize.Height)

            Try
                ' Attempt 1: DrawToBitmap (preferred)
                Me.DrawToBitmap(bmp, New System.Drawing.Rectangle(0, 0, captureSize.Width, captureSize.Height))

                ' Quick check: if bitmap is empty (all transparent/white) or some controls didn't render,
                ' you can detect and fallback below; but we'll also catch exceptions.
            Catch ex As Exception
                ' If DrawToBitmap throws (or fails), try screen capture fallback
                Using g As Graphics = Graphics.FromImage(bmp)
                    Dim screenPoint = Me.PointToScreen(System.Drawing.Point.Empty)
                    g.CopyFromScreen(screenPoint, System.Drawing.Point.Empty, captureSize)
                End Using
            End Try

            ' If DrawToBitmap produced a blank image (rare), fallback to CopyFromScreen
            Dim isBlank As Boolean = True
            Using testBmp As New Bitmap(bmp, New System.Drawing.Size(10, 10))
                For x = 0 To testBmp.Width - 1
                    For y = 0 To testBmp.Height - 1
                        If testBmp.GetPixel(x, y).ToArgb() <> Color.White.ToArgb() Then
                            isBlank = False
                            Exit For
                        End If
                    Next
                    If Not isBlank Then Exit For
                Next
            End Using
            If isBlank Then
                ' Fallback to screen capture (needs form visible on screen)
                Using g As Graphics = Graphics.FromImage(bmp)
                    Dim screenPoint = Me.PointToScreen(System.Drawing.Point.Empty)
                    g.CopyFromScreen(screenPoint, System.Drawing.Point.Empty, captureSize)
                End Using
            End If

            ' Save temp PNG
            Dim tempImgPath = Path.Combine(Path.GetTempPath(), $"receipt_capture_{Guid.NewGuid().ToString()}.png")
            bmp.Save(tempImgPath, ImageFormat.Png)

            ' Create PDF and embed the image
            Using fs As New FileStream(saveDialog.FileName, FileMode.Create, FileAccess.Write)
                Dim doc As New Document(PageSize.A5, 10, 10, 10, 10)
                Dim writer = PdfWriter.GetInstance(doc, fs)
                doc.Open()

                Dim img = iTextSharp.text.Image.GetInstance(tempImgPath)
                ' Scale to fit page while keeping aspect
                img.ScaleToFit(doc.PageSize.Width - 20, doc.PageSize.Height - 20)
                img.Alignment = Element.ALIGN_CENTER
                doc.Add(img)

                doc.Close()
            End Using

            ' Clean up
            If File.Exists(tempImgPath) Then
                Try : File.Delete(tempImgPath) : Catch : End Try
            End If

            MessageBox.Show("Receipt downloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error while saving receipt: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

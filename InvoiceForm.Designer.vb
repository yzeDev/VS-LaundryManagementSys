<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TableLayoutPanel1 = New TableLayoutPanel()
        lblLaundryText = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        tbAmount = New TextBox()
        tbAddress = New TextBox()
        tbContactNumber = New TextBox()
        tbCustomerName = New TextBox()
        lblAmountText = New Label()
        lblTransactionIDText = New Label()
        lblPaymentText = New Label()
        lblAddressText = New Label()
        lblContactNumberText = New Label()
        lblCustomerNameText = New Label()
        tbTransactionID = New TextBox()
        cmbPaymentMethod = New ComboBox()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(lblLaundryText, 0, 0)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 6.841339F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 36.5356636F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 31.4410477F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Size = New Size(717, 916)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' lblLaundryText
        ' 
        lblLaundryText.BackColor = Color.FromArgb(CByte(57), CByte(88), CByte(134))
        lblLaundryText.Dock = DockStyle.Fill
        lblLaundryText.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLaundryText.ForeColor = Color.White
        lblLaundryText.Location = New Point(3, 0)
        lblLaundryText.Name = "lblLaundryText"
        lblLaundryText.Size = New Size(711, 62)
        lblLaundryText.TabIndex = 2
        lblLaundryText.Text = "Laundry Management System"
        lblLaundryText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 27.5092945F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 72.49071F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 95F))
        TableLayoutPanel2.Controls.Add(tbAmount, 1, 5)
        TableLayoutPanel2.Controls.Add(tbAddress, 1, 3)
        TableLayoutPanel2.Controls.Add(tbContactNumber, 1, 2)
        TableLayoutPanel2.Controls.Add(tbCustomerName, 1, 1)
        TableLayoutPanel2.Controls.Add(lblAmountText, 0, 5)
        TableLayoutPanel2.Controls.Add(lblTransactionIDText, 0, 0)
        TableLayoutPanel2.Controls.Add(lblPaymentText, 0, 4)
        TableLayoutPanel2.Controls.Add(lblAddressText, 0, 3)
        TableLayoutPanel2.Controls.Add(lblContactNumberText, 0, 2)
        TableLayoutPanel2.Controls.Add(lblCustomerNameText, 0, 1)
        TableLayoutPanel2.Controls.Add(tbTransactionID, 1, 0)
        TableLayoutPanel2.Controls.Add(cmbPaymentMethod, 1, 4)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 66)
        TableLayoutPanel2.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 6
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel2.Size = New Size(711, 327)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' tbAmount
        ' 
        tbAmount.Dock = DockStyle.Fill
        tbAmount.Font = New Font("Microsoft Sans Serif", 15.75F)
        tbAmount.Location = New Point(172, 274)
        tbAmount.Margin = New Padding(3, 4, 3, 4)
        tbAmount.Name = "tbAmount"
        tbAmount.Size = New Size(440, 37)
        tbAmount.TabIndex = 16
        ' 
        ' tbAddress
        ' 
        tbAddress.Dock = DockStyle.Fill
        tbAddress.Enabled = False
        tbAddress.Font = New Font("Microsoft Sans Serif", 15.75F)
        tbAddress.Location = New Point(172, 166)
        tbAddress.Margin = New Padding(3, 4, 3, 4)
        tbAddress.Name = "tbAddress"
        tbAddress.ReadOnly = True
        tbAddress.Size = New Size(440, 37)
        tbAddress.TabIndex = 14
        ' 
        ' tbContactNumber
        ' 
        tbContactNumber.Dock = DockStyle.Fill
        tbContactNumber.Enabled = False
        tbContactNumber.Font = New Font("Microsoft Sans Serif", 15.75F)
        tbContactNumber.Location = New Point(172, 112)
        tbContactNumber.Margin = New Padding(3, 4, 3, 4)
        tbContactNumber.Name = "tbContactNumber"
        tbContactNumber.ReadOnly = True
        tbContactNumber.Size = New Size(440, 37)
        tbContactNumber.TabIndex = 13
        ' 
        ' tbCustomerName
        ' 
        tbCustomerName.Dock = DockStyle.Fill
        tbCustomerName.Enabled = False
        tbCustomerName.Font = New Font("Microsoft Sans Serif", 15.75F)
        tbCustomerName.Location = New Point(172, 58)
        tbCustomerName.Margin = New Padding(3, 4, 3, 4)
        tbCustomerName.Name = "tbCustomerName"
        tbCustomerName.ReadOnly = True
        tbCustomerName.Size = New Size(440, 37)
        tbCustomerName.TabIndex = 12
        ' 
        ' lblAmountText
        ' 
        lblAmountText.AutoSize = True
        lblAmountText.Dock = DockStyle.Fill
        lblAmountText.Font = New Font("Segoe UI", 11.25F)
        lblAmountText.Location = New Point(3, 270)
        lblAmountText.Name = "lblAmountText"
        lblAmountText.Size = New Size(163, 57)
        lblAmountText.TabIndex = 10
        lblAmountText.Text = "Amount Received: "
        lblAmountText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTransactionIDText
        ' 
        lblTransactionIDText.AutoSize = True
        lblTransactionIDText.Dock = DockStyle.Fill
        lblTransactionIDText.Font = New Font("Segoe UI", 11.25F)
        lblTransactionIDText.Location = New Point(3, 0)
        lblTransactionIDText.Name = "lblTransactionIDText"
        lblTransactionIDText.Size = New Size(163, 54)
        lblTransactionIDText.TabIndex = 0
        lblTransactionIDText.Text = "Transaction ID:"
        lblTransactionIDText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPaymentText
        ' 
        lblPaymentText.AutoSize = True
        lblPaymentText.Dock = DockStyle.Fill
        lblPaymentText.Font = New Font("Segoe UI", 11.25F)
        lblPaymentText.Location = New Point(3, 216)
        lblPaymentText.Name = "lblPaymentText"
        lblPaymentText.Size = New Size(163, 54)
        lblPaymentText.TabIndex = 8
        lblPaymentText.Text = "Payment Method:"
        lblPaymentText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblAddressText
        ' 
        lblAddressText.AutoSize = True
        lblAddressText.Dock = DockStyle.Fill
        lblAddressText.Font = New Font("Segoe UI", 11.25F)
        lblAddressText.Location = New Point(3, 162)
        lblAddressText.Name = "lblAddressText"
        lblAddressText.Size = New Size(163, 54)
        lblAddressText.TabIndex = 6
        lblAddressText.Text = "Address:"
        lblAddressText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblContactNumberText
        ' 
        lblContactNumberText.AutoSize = True
        lblContactNumberText.Dock = DockStyle.Fill
        lblContactNumberText.Font = New Font("Segoe UI", 11.25F)
        lblContactNumberText.Location = New Point(3, 108)
        lblContactNumberText.Name = "lblContactNumberText"
        lblContactNumberText.Size = New Size(163, 54)
        lblContactNumberText.TabIndex = 4
        lblContactNumberText.Text = "Contact Number: "
        lblContactNumberText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCustomerNameText
        ' 
        lblCustomerNameText.AutoSize = True
        lblCustomerNameText.Dock = DockStyle.Fill
        lblCustomerNameText.Font = New Font("Segoe UI", 11.25F)
        lblCustomerNameText.Location = New Point(3, 54)
        lblCustomerNameText.Name = "lblCustomerNameText"
        lblCustomerNameText.Size = New Size(163, 54)
        lblCustomerNameText.TabIndex = 2
        lblCustomerNameText.Text = "Customer Name: "
        lblCustomerNameText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' tbTransactionID
        ' 
        tbTransactionID.Dock = DockStyle.Fill
        tbTransactionID.Enabled = False
        tbTransactionID.Font = New Font("Microsoft Sans Serif", 15.75F)
        tbTransactionID.Location = New Point(172, 4)
        tbTransactionID.Margin = New Padding(3, 4, 3, 4)
        tbTransactionID.Name = "tbTransactionID"
        tbTransactionID.ReadOnly = True
        tbTransactionID.Size = New Size(440, 37)
        tbTransactionID.TabIndex = 11
        ' 
        ' cmbPaymentMethod
        ' 
        cmbPaymentMethod.Dock = DockStyle.Fill
        cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPaymentMethod.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbPaymentMethod.FormattingEnabled = True
        cmbPaymentMethod.Items.AddRange(New Object() {"Cash", "Card"})
        cmbPaymentMethod.Location = New Point(172, 220)
        cmbPaymentMethod.Margin = New Padding(3, 4, 3, 4)
        cmbPaymentMethod.Name = "cmbPaymentMethod"
        cmbPaymentMethod.Size = New Size(440, 40)
        cmbPaymentMethod.TabIndex = 17
        ' 
        ' InvoiceForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(717, 916)
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "InvoiceForm"
        Text = "InvoiceForm"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblLaundryText As Label
    Friend WithEvents lblAmountText As Label
    Friend WithEvents lblTransactionIDText As Label
    Friend WithEvents lblPaymentText As Label
    Friend WithEvents lblAddressText As Label
    Friend WithEvents lblContactNumberText As Label
    Friend WithEvents lblCustomerNameText As Label
    Friend WithEvents tbAmount As TextBox
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents tbContactNumber As TextBox
    Friend WithEvents tbCustomerName As TextBox
    Friend WithEvents tbTransactionID As TextBox
    Friend WithEvents cmbPaymentMethod As ComboBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransactionForm))
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel2 = New Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        lblCustomer = New Label()
        lblService = New Label()
        tbCustomerName = New TextBox()
        tbChange = New TextBox()
        lblChange = New Label()
        tbAmountReceived = New TextBox()
        lblAmountReceived = New Label()
        tbTotal = New TextBox()
        lblTotal = New Label()
        tbPaymentMethod = New TextBox()
        lblPaymentMethod = New Label()
        tbMachineUsed = New TextBox()
        lblMachineUsed = New Label()
        lblStatus = New Label()
        tbAddress = New TextBox()
        lblAddress = New Label()
        lblContactNumber = New Label()
        tbContactNum = New TextBox()
        cbService = New ComboBox()
        cbStatus = New ComboBox()
        btnSave = New Button()
        btnCancel = New Button()
        Panel1 = New Panel()
        lblTitle = New Label()
        lblSubTitle = New Label()
        lblDate = New Label()
        TableLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Panel2, 0, 2)
        TableLayoutPanel1.Controls.Add(btnSave, 0, 3)
        TableLayoutPanel1.Controls.Add(btnCancel, 1, 3)
        TableLayoutPanel1.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel1.Controls.Add(lblSubTitle, 0, 1)
        TableLayoutPanel1.Controls.Add(lblDate, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel1.Size = New Size(784, 461)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        TableLayoutPanel1.SetColumnSpan(Panel2, 2)
        Panel2.Controls.Add(TableLayoutPanel2)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(3, 103)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(778, 315)
        Panel2.TabIndex = 1
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(lblCustomer, 0, 0)
        TableLayoutPanel2.Controls.Add(lblService, 0, 2)
        TableLayoutPanel2.Controls.Add(tbCustomerName, 0, 1)
        TableLayoutPanel2.Controls.Add(tbChange, 1, 9)
        TableLayoutPanel2.Controls.Add(lblChange, 1, 8)
        TableLayoutPanel2.Controls.Add(tbAmountReceived, 1, 7)
        TableLayoutPanel2.Controls.Add(lblAmountReceived, 1, 6)
        TableLayoutPanel2.Controls.Add(tbTotal, 1, 5)
        TableLayoutPanel2.Controls.Add(lblTotal, 1, 4)
        TableLayoutPanel2.Controls.Add(tbPaymentMethod, 1, 3)
        TableLayoutPanel2.Controls.Add(lblPaymentMethod, 1, 2)
        TableLayoutPanel2.Controls.Add(tbMachineUsed, 1, 1)
        TableLayoutPanel2.Controls.Add(lblMachineUsed, 1, 0)
        TableLayoutPanel2.Controls.Add(lblStatus, 0, 8)
        TableLayoutPanel2.Controls.Add(tbAddress, 0, 7)
        TableLayoutPanel2.Controls.Add(lblAddress, 0, 6)
        TableLayoutPanel2.Controls.Add(lblContactNumber, 0, 4)
        TableLayoutPanel2.Controls.Add(tbContactNum, 0, 5)
        TableLayoutPanel2.Controls.Add(cbService, 0, 3)
        TableLayoutPanel2.Controls.Add(cbStatus, 0, 9)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 10
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel2.Size = New Size(778, 315)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' lblCustomer
        ' 
        lblCustomer.AutoSize = True
        lblCustomer.Dock = DockStyle.Fill
        lblCustomer.Font = New Font("Segoe UI", 14.25F)
        lblCustomer.Location = New Point(3, 0)
        lblCustomer.Name = "lblCustomer"
        lblCustomer.Size = New Size(383, 31)
        lblCustomer.TabIndex = 0
        lblCustomer.Text = "Customer Name:"
        lblCustomer.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblService
        ' 
        lblService.AutoSize = True
        lblService.Dock = DockStyle.Fill
        lblService.Font = New Font("Segoe UI", 14.25F)
        lblService.Location = New Point(3, 62)
        lblService.Name = "lblService"
        lblService.Size = New Size(383, 31)
        lblService.TabIndex = 1
        lblService.Text = "Service Type"
        lblService.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' tbCustomerName
        ' 
        tbCustomerName.Dock = DockStyle.Fill
        tbCustomerName.Font = New Font("Segoe UI", 14.25F)
        tbCustomerName.Location = New Point(3, 34)
        tbCustomerName.Name = "tbCustomerName"
        tbCustomerName.Size = New Size(383, 33)
        tbCustomerName.TabIndex = 9
        ' 
        ' tbChange
        ' 
        tbChange.Dock = DockStyle.Fill
        tbChange.Enabled = False
        tbChange.Font = New Font("Segoe UI", 14.25F)
        tbChange.Location = New Point(392, 282)
        tbChange.Name = "tbChange"
        tbChange.Size = New Size(383, 33)
        tbChange.TabIndex = 17
        ' 
        ' lblChange
        ' 
        lblChange.AutoSize = True
        lblChange.Dock = DockStyle.Fill
        lblChange.Font = New Font("Segoe UI", 14.25F)
        lblChange.Location = New Point(392, 248)
        lblChange.Name = "lblChange"
        lblChange.Size = New Size(383, 31)
        lblChange.TabIndex = 8
        lblChange.Text = "Change:"
        lblChange.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' tbAmountReceived
        ' 
        tbAmountReceived.Dock = DockStyle.Fill
        tbAmountReceived.Enabled = False
        tbAmountReceived.Font = New Font("Segoe UI", 14.25F)
        tbAmountReceived.Location = New Point(392, 220)
        tbAmountReceived.Name = "tbAmountReceived"
        tbAmountReceived.Size = New Size(383, 33)
        tbAmountReceived.TabIndex = 16
        ' 
        ' lblAmountReceived
        ' 
        lblAmountReceived.AutoSize = True
        lblAmountReceived.Dock = DockStyle.Fill
        lblAmountReceived.Font = New Font("Segoe UI", 14.25F)
        lblAmountReceived.Location = New Point(392, 186)
        lblAmountReceived.Name = "lblAmountReceived"
        lblAmountReceived.RightToLeft = RightToLeft.No
        lblAmountReceived.Size = New Size(383, 31)
        lblAmountReceived.TabIndex = 7
        lblAmountReceived.Text = "Amount Received:"
        lblAmountReceived.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' tbTotal
        ' 
        tbTotal.Dock = DockStyle.Fill
        tbTotal.Enabled = False
        tbTotal.Font = New Font("Segoe UI", 14.25F)
        tbTotal.Location = New Point(392, 158)
        tbTotal.Name = "tbTotal"
        tbTotal.Size = New Size(383, 33)
        tbTotal.TabIndex = 15
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Dock = DockStyle.Fill
        lblTotal.Font = New Font("Segoe UI", 14.25F)
        lblTotal.Location = New Point(392, 124)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(383, 31)
        lblTotal.TabIndex = 6
        lblTotal.Text = "Total:"
        lblTotal.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' tbPaymentMethod
        ' 
        tbPaymentMethod.Dock = DockStyle.Fill
        tbPaymentMethod.Enabled = False
        tbPaymentMethod.Font = New Font("Segoe UI", 14.25F)
        tbPaymentMethod.Location = New Point(392, 96)
        tbPaymentMethod.Name = "tbPaymentMethod"
        tbPaymentMethod.Size = New Size(383, 33)
        tbPaymentMethod.TabIndex = 14
        ' 
        ' lblPaymentMethod
        ' 
        lblPaymentMethod.AutoSize = True
        lblPaymentMethod.Dock = DockStyle.Fill
        lblPaymentMethod.Font = New Font("Segoe UI", 14.25F)
        lblPaymentMethod.Location = New Point(392, 62)
        lblPaymentMethod.Name = "lblPaymentMethod"
        lblPaymentMethod.Size = New Size(383, 31)
        lblPaymentMethod.TabIndex = 5
        lblPaymentMethod.Text = "Payment Method:"
        lblPaymentMethod.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' tbMachineUsed
        ' 
        tbMachineUsed.Dock = DockStyle.Fill
        tbMachineUsed.Font = New Font("Segoe UI", 14.25F)
        tbMachineUsed.Location = New Point(392, 34)
        tbMachineUsed.Name = "tbMachineUsed"
        tbMachineUsed.Size = New Size(383, 33)
        tbMachineUsed.TabIndex = 13
        ' 
        ' lblMachineUsed
        ' 
        lblMachineUsed.AutoSize = True
        lblMachineUsed.Dock = DockStyle.Fill
        lblMachineUsed.Font = New Font("Segoe UI", 14.25F)
        lblMachineUsed.Location = New Point(392, 0)
        lblMachineUsed.Name = "lblMachineUsed"
        lblMachineUsed.Size = New Size(383, 31)
        lblMachineUsed.TabIndex = 4
        lblMachineUsed.Text = "Machine Used:"
        lblMachineUsed.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Dock = DockStyle.Fill
        lblStatus.Font = New Font("Segoe UI", 14.25F)
        lblStatus.Location = New Point(3, 248)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(383, 31)
        lblStatus.TabIndex = 3
        lblStatus.Text = "Status:"
        lblStatus.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' tbAddress
        ' 
        tbAddress.Dock = DockStyle.Fill
        tbAddress.Font = New Font("Segoe UI", 14.25F)
        tbAddress.Location = New Point(3, 220)
        tbAddress.Name = "tbAddress"
        tbAddress.Size = New Size(383, 33)
        tbAddress.TabIndex = 11
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Dock = DockStyle.Fill
        lblAddress.Font = New Font("Segoe UI", 14.25F)
        lblAddress.Location = New Point(3, 186)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(383, 31)
        lblAddress.TabIndex = 2
        lblAddress.Text = "Address:"
        lblAddress.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblContactNumber
        ' 
        lblContactNumber.AutoSize = True
        lblContactNumber.Dock = DockStyle.Fill
        lblContactNumber.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblContactNumber.Location = New Point(3, 124)
        lblContactNumber.Name = "lblContactNumber"
        lblContactNumber.Size = New Size(383, 31)
        lblContactNumber.TabIndex = 18
        lblContactNumber.Text = "Contact Number:"
        lblContactNumber.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' tbContactNum
        ' 
        tbContactNum.Dock = DockStyle.Fill
        tbContactNum.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbContactNum.Location = New Point(3, 158)
        tbContactNum.Name = "tbContactNum"
        tbContactNum.Size = New Size(383, 33)
        tbContactNum.TabIndex = 19
        ' 
        ' cbService
        ' 
        cbService.Dock = DockStyle.Fill
        cbService.DropDownStyle = ComboBoxStyle.DropDownList
        cbService.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbService.FormattingEnabled = True
        cbService.Location = New Point(3, 96)
        cbService.Name = "cbService"
        cbService.Size = New Size(383, 33)
        cbService.TabIndex = 20
        ' 
        ' cbStatus
        ' 
        cbStatus.Dock = DockStyle.Fill
        cbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cbStatus.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbStatus.FormattingEnabled = True
        cbStatus.Location = New Point(3, 282)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(383, 33)
        cbStatus.TabIndex = 21
        ' 
        ' btnSave
        ' 
        btnSave.Dock = DockStyle.Right
        btnSave.Location = New Point(314, 424)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 34)
        btnSave.TabIndex = 2
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Dock = DockStyle.Left
        btnCancel.Location = New Point(395, 424)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 34)
        btnCancel.TabIndex = 3
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        TableLayoutPanel1.SetColumnSpan(Panel1, 2)
        Panel1.Controls.Add(lblTitle)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(778, 54)
        Panel1.TabIndex = 4
        ' 
        ' lblTitle
        ' 
        lblTitle.Dock = DockStyle.Fill
        lblTitle.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(0, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(778, 54)
        lblTitle.TabIndex = 0
        lblTitle.Text = "TRANSACTION FORM"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSubTitle
        ' 
        lblSubTitle.AutoSize = True
        lblSubTitle.Dock = DockStyle.Fill
        lblSubTitle.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSubTitle.Location = New Point(3, 60)
        lblSubTitle.Name = "lblSubTitle"
        lblSubTitle.Size = New Size(386, 40)
        lblSubTitle.TabIndex = 5
        lblSubTitle.Text = "Mode: (TransactionID)"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Dock = DockStyle.Fill
        lblDate.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDate.Location = New Point(395, 60)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(386, 40)
        lblDate.TabIndex = 6
        lblDate.Text = "Transaction Date:"
        ' 
        ' TransactionForm
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(784, 461)
        Controls.Add(TableLayoutPanel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(800, 500)
        MinimumSize = New Size(800, 500)
        Name = "TransactionForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Transaction Form"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        Panel2.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblCustomer As Label
    Friend WithEvents lblService As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblMachineUsed As Label
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblAmountReceived As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents tbCustomerName As TextBox
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents tbMachineUsed As TextBox
    Friend WithEvents tbPaymentMethod As TextBox
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents tbAmountReceived As TextBox
    Friend WithEvents tbChange As TextBox
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents tbContactNum As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents cbService As ComboBox
    Friend WithEvents cbStatus As ComboBox
End Class

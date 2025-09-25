<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionDetailsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransactionDetailsForm))
        TableLayoutPanel1 = New TableLayoutPanel()
        lblTransactionIDText = New Label()
        lblCustomerNameText = New Label()
        lblServiceTypeText = New Label()
        lblStatusText = New Label()
        lblMachineUsedText = New Label()
        lblDateText = New Label()
        lblTotalPaymentText = New Label()
        lblTransactionIDValue = New Label()
        lblCustomerNameValue = New Label()
        lblServiceTypeValue = New Label()
        lblStatusValue = New Label()
        lblMachineUsedValue = New Label()
        lblDateValue = New Label()
        lblTotalPaymentValue = New Label()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(lblTotalPaymentValue, 1, 6)
        TableLayoutPanel1.Controls.Add(lblDateValue, 1, 5)
        TableLayoutPanel1.Controls.Add(lblMachineUsedValue, 1, 4)
        TableLayoutPanel1.Controls.Add(lblStatusValue, 1, 3)
        TableLayoutPanel1.Controls.Add(lblServiceTypeValue, 1, 2)
        TableLayoutPanel1.Controls.Add(lblCustomerNameValue, 1, 1)
        TableLayoutPanel1.Controls.Add(lblTransactionIDValue, 1, 0)
        TableLayoutPanel1.Controls.Add(lblTransactionIDText, 0, 0)
        TableLayoutPanel1.Controls.Add(lblCustomerNameText, 0, 1)
        TableLayoutPanel1.Controls.Add(lblServiceTypeText, 0, 2)
        TableLayoutPanel1.Controls.Add(lblStatusText, 0, 3)
        TableLayoutPanel1.Controls.Add(lblMachineUsedText, 0, 4)
        TableLayoutPanel1.Controls.Add(lblDateText, 0, 5)
        TableLayoutPanel1.Controls.Add(lblTotalPaymentText, 0, 6)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 7
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.Size = New Size(484, 461)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' lblTransactionIDText
        ' 
        lblTransactionIDText.AutoSize = True
        lblTransactionIDText.Dock = DockStyle.Fill
        lblTransactionIDText.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblTransactionIDText.Location = New Point(3, 0)
        lblTransactionIDText.Name = "lblTransactionIDText"
        lblTransactionIDText.Size = New Size(236, 65)
        lblTransactionIDText.TabIndex = 0
        lblTransactionIDText.Text = "Transaction ID:"
        lblTransactionIDText.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblCustomerNameText
        ' 
        lblCustomerNameText.AutoSize = True
        lblCustomerNameText.Dock = DockStyle.Fill
        lblCustomerNameText.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblCustomerNameText.Location = New Point(3, 65)
        lblCustomerNameText.Name = "lblCustomerNameText"
        lblCustomerNameText.Size = New Size(236, 65)
        lblCustomerNameText.TabIndex = 1
        lblCustomerNameText.Text = "Customer Name:"
        lblCustomerNameText.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblServiceTypeText
        ' 
        lblServiceTypeText.AutoSize = True
        lblServiceTypeText.Dock = DockStyle.Fill
        lblServiceTypeText.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblServiceTypeText.Location = New Point(3, 130)
        lblServiceTypeText.Name = "lblServiceTypeText"
        lblServiceTypeText.Size = New Size(236, 65)
        lblServiceTypeText.TabIndex = 2
        lblServiceTypeText.Text = "Service Type:"
        lblServiceTypeText.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblStatusText
        ' 
        lblStatusText.AutoSize = True
        lblStatusText.Dock = DockStyle.Fill
        lblStatusText.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblStatusText.Location = New Point(3, 195)
        lblStatusText.Name = "lblStatusText"
        lblStatusText.Size = New Size(236, 65)
        lblStatusText.TabIndex = 3
        lblStatusText.Text = "Status:"
        lblStatusText.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblMachineUsedText
        ' 
        lblMachineUsedText.AutoSize = True
        lblMachineUsedText.Dock = DockStyle.Fill
        lblMachineUsedText.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblMachineUsedText.Location = New Point(3, 260)
        lblMachineUsedText.Name = "lblMachineUsedText"
        lblMachineUsedText.Size = New Size(236, 65)
        lblMachineUsedText.TabIndex = 4
        lblMachineUsedText.Text = "Machine Used:"
        lblMachineUsedText.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblDateText
        ' 
        lblDateText.AutoSize = True
        lblDateText.Dock = DockStyle.Fill
        lblDateText.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblDateText.Location = New Point(3, 325)
        lblDateText.Name = "lblDateText"
        lblDateText.Size = New Size(236, 65)
        lblDateText.TabIndex = 5
        lblDateText.Text = "Date:"
        lblDateText.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblTotalPaymentText
        ' 
        lblTotalPaymentText.AutoSize = True
        lblTotalPaymentText.Dock = DockStyle.Fill
        lblTotalPaymentText.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblTotalPaymentText.Location = New Point(3, 390)
        lblTotalPaymentText.Name = "lblTotalPaymentText"
        lblTotalPaymentText.Size = New Size(236, 71)
        lblTotalPaymentText.TabIndex = 6
        lblTotalPaymentText.Text = "Total Payment:"
        lblTotalPaymentText.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblTransactionIDValue
        ' 
        lblTransactionIDValue.AutoSize = True
        lblTransactionIDValue.Dock = DockStyle.Fill
        lblTransactionIDValue.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblTransactionIDValue.Location = New Point(245, 0)
        lblTransactionIDValue.Name = "lblTransactionIDValue"
        lblTransactionIDValue.Size = New Size(236, 65)
        lblTransactionIDValue.TabIndex = 7
        lblTransactionIDValue.Text = "Transaction ID:"
        lblTransactionIDValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblCustomerNameValue
        ' 
        lblCustomerNameValue.AutoSize = True
        lblCustomerNameValue.Dock = DockStyle.Fill
        lblCustomerNameValue.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblCustomerNameValue.Location = New Point(245, 65)
        lblCustomerNameValue.Name = "lblCustomerNameValue"
        lblCustomerNameValue.Size = New Size(236, 65)
        lblCustomerNameValue.TabIndex = 8
        lblCustomerNameValue.Text = "Customer Name:"
        lblCustomerNameValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblServiceTypeValue
        ' 
        lblServiceTypeValue.AutoSize = True
        lblServiceTypeValue.Dock = DockStyle.Fill
        lblServiceTypeValue.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblServiceTypeValue.Location = New Point(245, 130)
        lblServiceTypeValue.Name = "lblServiceTypeValue"
        lblServiceTypeValue.Size = New Size(236, 65)
        lblServiceTypeValue.TabIndex = 9
        lblServiceTypeValue.Text = "Service Type:"
        lblServiceTypeValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblStatusValue
        ' 
        lblStatusValue.AutoSize = True
        lblStatusValue.Dock = DockStyle.Fill
        lblStatusValue.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblStatusValue.Location = New Point(245, 195)
        lblStatusValue.Name = "lblStatusValue"
        lblStatusValue.Size = New Size(236, 65)
        lblStatusValue.TabIndex = 10
        lblStatusValue.Text = "Status:"
        lblStatusValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblMachineUsedValue
        ' 
        lblMachineUsedValue.AutoSize = True
        lblMachineUsedValue.Dock = DockStyle.Fill
        lblMachineUsedValue.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblMachineUsedValue.Location = New Point(245, 260)
        lblMachineUsedValue.Name = "lblMachineUsedValue"
        lblMachineUsedValue.Size = New Size(236, 65)
        lblMachineUsedValue.TabIndex = 11
        lblMachineUsedValue.Text = "Machine Used:"
        lblMachineUsedValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblDateValue
        ' 
        lblDateValue.AutoSize = True
        lblDateValue.Dock = DockStyle.Fill
        lblDateValue.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblDateValue.Location = New Point(245, 325)
        lblDateValue.Name = "lblDateValue"
        lblDateValue.Size = New Size(236, 65)
        lblDateValue.TabIndex = 12
        lblDateValue.Text = "Date:"
        lblDateValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTotalPaymentValue
        ' 
        lblTotalPaymentValue.AutoSize = True
        lblTotalPaymentValue.Dock = DockStyle.Fill
        lblTotalPaymentValue.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblTotalPaymentValue.Location = New Point(245, 390)
        lblTotalPaymentValue.Name = "lblTotalPaymentValue"
        lblTotalPaymentValue.Size = New Size(236, 71)
        lblTotalPaymentValue.TabIndex = 13
        lblTotalPaymentValue.Text = "Total Payment:"
        lblTotalPaymentValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TransactionDetailsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(484, 461)
        Controls.Add(TableLayoutPanel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "TransactionDetailsForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Transaction Details"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTransactionIDText As Label
    Friend WithEvents lblCustomerNameText As Label
    Friend WithEvents lblServiceTypeText As Label
    Friend WithEvents lblStatusText As Label
    Friend WithEvents lblMachineUsedText As Label
    Friend WithEvents lblDateText As Label
    Friend WithEvents lblTotalPaymentText As Label
    Friend WithEvents lblTotalPaymentValue As Label
    Friend WithEvents lblDateValue As Label
    Friend WithEvents lblMachineUsedValue As Label
    Friend WithEvents lblStatusValue As Label
    Friend WithEvents lblServiceTypeValue As Label
    Friend WithEvents lblCustomerNameValue As Label
    Friend WithEvents lblTransactionIDValue As Label
End Class

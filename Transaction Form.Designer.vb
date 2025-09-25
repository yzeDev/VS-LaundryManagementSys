<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaction_Form
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
        lblLaundryText = New Label()
        lblTransactionFormText = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        lblkgText = New Label()
        lblServiceTypeText = New Label()
        txtboxKG = New TextBox()
        lblContactText = New Label()
        txtboxContact = New TextBox()
        lblCustomerNameText = New Label()
        txtboxCustomerName = New TextBox()
        cmbServiceType = New ComboBox()
        Panel1 = New Panel()
        TableLayoutPanel4 = New TableLayoutPanel()
        CheckBoxDelivery = New CheckBox()
        CheckBoxPickup = New CheckBox()
        Panel2 = New Panel()
        txtboxAddress = New TextBox()
        lblAddressText = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        btnFinish = New Button()
        btnCancel = New Button()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        Panel1.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        Panel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblLaundryText
        ' 
        lblLaundryText.BackColor = Color.FromArgb(CByte(57), CByte(88), CByte(134))
        lblLaundryText.Dock = DockStyle.Top
        lblLaundryText.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLaundryText.ForeColor = Color.White
        lblLaundryText.Location = New Point(0, 0)
        lblLaundryText.Name = "lblLaundryText"
        lblLaundryText.Size = New Size(576, 56)
        lblLaundryText.TabIndex = 0
        lblLaundryText.Text = "Laundry Management System"
        lblLaundryText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTransactionFormText
        ' 
        lblTransactionFormText.Dock = DockStyle.Top
        lblTransactionFormText.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTransactionFormText.Location = New Point(0, 56)
        lblTransactionFormText.Name = "lblTransactionFormText"
        lblTransactionFormText.Size = New Size(576, 89)
        lblTransactionFormText.TabIndex = 1
        lblTransactionFormText.Text = "Transaction Form"
        lblTransactionFormText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 0)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel3, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 145)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 59.2437F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 40.7563F))
        TableLayoutPanel1.Size = New Size(576, 555)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 34.56141F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65.43859F))
        TableLayoutPanel2.Controls.Add(lblkgText, 0, 1)
        TableLayoutPanel2.Controls.Add(lblServiceTypeText, 0, 2)
        TableLayoutPanel2.Controls.Add(txtboxKG, 1, 1)
        TableLayoutPanel2.Controls.Add(lblContactText, 0, 3)
        TableLayoutPanel2.Controls.Add(txtboxContact, 1, 3)
        TableLayoutPanel2.Controls.Add(lblCustomerNameText, 0, 0)
        TableLayoutPanel2.Controls.Add(txtboxCustomerName, 1, 0)
        TableLayoutPanel2.Controls.Add(cmbServiceType, 1, 2)
        TableLayoutPanel2.Controls.Add(Panel1, 0, 4)
        TableLayoutPanel2.Controls.Add(Panel2, 0, 5)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 6
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.Size = New Size(570, 322)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' lblkgText
        ' 
        lblkgText.Anchor = AnchorStyles.Right
        lblkgText.AutoSize = True
        lblkgText.Font = New Font("Segoe UI", 14.25F)
        lblkgText.Location = New Point(159, 67)
        lblkgText.Name = "lblkgText"
        lblkgText.Size = New Size(35, 25)
        lblkgText.TabIndex = 2
        lblkgText.Text = "KG"
        ' 
        ' lblServiceTypeText
        ' 
        lblServiceTypeText.Anchor = AnchorStyles.Right
        lblServiceTypeText.AutoSize = True
        lblServiceTypeText.Font = New Font("Segoe UI", 14.25F)
        lblServiceTypeText.Location = New Point(78, 120)
        lblServiceTypeText.Name = "lblServiceTypeText"
        lblServiceTypeText.Size = New Size(116, 25)
        lblServiceTypeText.TabIndex = 0
        lblServiceTypeText.Text = "Service Type"
        ' 
        ' txtboxKG
        ' 
        txtboxKG.Anchor = AnchorStyles.Left
        txtboxKG.Font = New Font("Segoe UI", 18.0F)
        txtboxKG.Location = New Point(200, 60)
        txtboxKG.Name = "txtboxKG"
        txtboxKG.Size = New Size(300, 39)
        txtboxKG.TabIndex = 2
        ' 
        ' lblContactText
        ' 
        lblContactText.Anchor = AnchorStyles.Right
        lblContactText.AutoSize = True
        lblContactText.Font = New Font("Segoe UI", 14.25F)
        lblContactText.Location = New Point(83, 173)
        lblContactText.Name = "lblContactText"
        lblContactText.Size = New Size(111, 25)
        lblContactText.TabIndex = 8
        lblContactText.Text = "Contact No."
        ' 
        ' txtboxContact
        ' 
        txtboxContact.Anchor = AnchorStyles.Left
        txtboxContact.Font = New Font("Segoe UI", 18.0F)
        txtboxContact.Location = New Point(200, 166)
        txtboxContact.Name = "txtboxContact"
        txtboxContact.Size = New Size(300, 39)
        txtboxContact.TabIndex = 4
        ' 
        ' lblCustomerNameText
        ' 
        lblCustomerNameText.Anchor = AnchorStyles.Right
        lblCustomerNameText.AutoSize = True
        lblCustomerNameText.Font = New Font("Segoe UI", 14.25F)
        lblCustomerNameText.Location = New Point(46, 14)
        lblCustomerNameText.Name = "lblCustomerNameText"
        lblCustomerNameText.Size = New Size(148, 25)
        lblCustomerNameText.TabIndex = 6
        lblCustomerNameText.Text = "Customer Name"
        ' 
        ' txtboxCustomerName
        ' 
        txtboxCustomerName.Anchor = AnchorStyles.Left
        txtboxCustomerName.Font = New Font("Segoe UI", 18.0F)
        txtboxCustomerName.Location = New Point(200, 7)
        txtboxCustomerName.Name = "txtboxCustomerName"
        txtboxCustomerName.Size = New Size(300, 39)
        txtboxCustomerName.TabIndex = 1
        ' 
        ' cmbServiceType
        ' 
        cmbServiceType.Anchor = AnchorStyles.Left
        cmbServiceType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbServiceType.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbServiceType.FormattingEnabled = True
        cmbServiceType.Location = New Point(200, 112)
        cmbServiceType.Name = "cmbServiceType"
        cmbServiceType.Size = New Size(300, 40)
        cmbServiceType.TabIndex = 3
        ' 
        ' Panel1
        ' 
        TableLayoutPanel2.SetColumnSpan(Panel1, 2)
        Panel1.Controls.Add(TableLayoutPanel4)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 215)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(564, 47)
        Panel1.TabIndex = 15
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel4.Controls.Add(CheckBoxDelivery, 0, 0)
        TableLayoutPanel4.Controls.Add(CheckBoxPickup, 1, 0)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(0, 0)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel4.Size = New Size(564, 47)
        TableLayoutPanel4.TabIndex = 0
        ' 
        ' CheckBoxDelivery
        ' 
        CheckBoxDelivery.AutoSize = True
        CheckBoxDelivery.Dock = DockStyle.Right
        CheckBoxDelivery.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBoxDelivery.Location = New Point(121, 3)
        CheckBoxDelivery.Name = "CheckBoxDelivery"
        CheckBoxDelivery.Size = New Size(158, 41)
        CheckBoxDelivery.TabIndex = 5
        CheckBoxDelivery.Text = " Delivery ( +5 % total) "
        CheckBoxDelivery.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxPickup
        ' 
        CheckBoxPickup.Anchor = AnchorStyles.None
        CheckBoxPickup.AutoSize = True
        CheckBoxPickup.Location = New Point(390, 14)
        CheckBoxPickup.Name = "CheckBoxPickup"
        CheckBoxPickup.Size = New Size(65, 19)
        CheckBoxPickup.TabIndex = 6
        CheckBoxPickup.Text = "Pick up"
        CheckBoxPickup.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        TableLayoutPanel2.SetColumnSpan(Panel2, 2)
        Panel2.Controls.Add(txtboxAddress)
        Panel2.Controls.Add(lblAddressText)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(3, 268)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(564, 51)
        Panel2.TabIndex = 16
        ' 
        ' txtboxAddress
        ' 
        txtboxAddress.Anchor = AnchorStyles.Left
        txtboxAddress.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtboxAddress.Location = New Point(197, 9)
        txtboxAddress.Name = "txtboxAddress"
        txtboxAddress.Size = New Size(367, 29)
        txtboxAddress.TabIndex = 7
        ' 
        ' lblAddressText
        ' 
        lblAddressText.AutoSize = True
        lblAddressText.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAddressText.Location = New Point(118, 6)
        lblAddressText.Name = "lblAddressText"
        lblAddressText.Size = New Size(73, 21)
        lblAddressText.TabIndex = 0
        lblAddressText.Text = "Address: "
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel3.Controls.Add(btnFinish, 1, 0)
        TableLayoutPanel3.Controls.Add(btnCancel, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 331)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel3.Size = New Size(570, 221)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' btnFinish
        ' 
        btnFinish.Anchor = AnchorStyles.None
        btnFinish.BackColor = Color.FromArgb(CByte(57), CByte(88), CByte(134))
        btnFinish.FlatStyle = FlatStyle.Flat
        btnFinish.ForeColor = Color.White
        btnFinish.Location = New Point(354, 71)
        btnFinish.Name = "btnFinish"
        btnFinish.Size = New Size(146, 79)
        btnFinish.TabIndex = 9
        btnFinish.Text = "Finish Order"
        btnFinish.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.Anchor = AnchorStyles.None
        btnCancel.BackColor = Color.FromArgb(CByte(57), CByte(88), CByte(134))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(69, 71)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(146, 79)
        btnCancel.TabIndex = 8
        btnCancel.Text = "Cancel Order"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Transaction_Form
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(576, 700)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(lblTransactionFormText)
        Controls.Add(lblLaundryText)
        Name = "Transaction_Form"
        Text = "Transaction_Form"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        Panel1.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblLaundryText As Label
    Friend WithEvents lblTransactionFormText As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblContactText As Label
    Friend WithEvents lblCustomerNameText As Label
    Friend WithEvents lblkgText As Label
    Friend WithEvents lblServiceTypeText As Label
    Friend WithEvents txtboxContact As TextBox
    Friend WithEvents txtboxCustomerName As TextBox
    Friend WithEvents txtboxKG As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Private btnNext As Button

    Friend WithEvents btnCancel As Button
    Friend WithEvents cmbServiceType As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents CheckBoxDelivery As CheckBox
    Friend WithEvents CheckBoxPickup As CheckBox
    Friend WithEvents btnFinish As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtboxAddress As TextBox
    Friend WithEvents lblAddressText As Label
End Class

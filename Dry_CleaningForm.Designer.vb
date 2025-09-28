<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dry_CleaningForm
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
        lblDryCleaningForm = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        txtboxQuantity = New TextBox()
        txtboxAddress = New TextBox()
        txtboxContact = New TextBox()
        lblAddress = New Label()
        lblQuantityText = New Label()
        lblClothesSizeText = New Label()
        lblContactNumberText = New Label()
        lblCustomerNameText = New Label()
        txtboxCustomer = New TextBox()
        CheckBoxDelivery = New CheckBox()
        ComboBox1 = New ComboBox()
        TableLayoutPanel3 = New TableLayoutPanel()
        btnFinish = New Button()
        btnCancel = New Button()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblLaundryText
        ' 
        lblLaundryText.BackColor = Color.FromArgb(CByte(57), CByte(88), CByte(134))
        lblLaundryText.Dock = DockStyle.Top
        lblLaundryText.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLaundryText.ForeColor = Color.White
        lblLaundryText.Location = New Point(0, 0)
        lblLaundryText.Name = "lblLaundryText"
        lblLaundryText.Size = New Size(473, 37)
        lblLaundryText.TabIndex = 1
        lblLaundryText.Text = "Laundry Management System"
        lblLaundryText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDryCleaningForm
        ' 
        lblDryCleaningForm.Dock = DockStyle.Top
        lblDryCleaningForm.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDryCleaningForm.Location = New Point(0, 37)
        lblDryCleaningForm.Name = "lblDryCleaningForm"
        lblDryCleaningForm.Size = New Size(473, 89)
        lblDryCleaningForm.TabIndex = 2
        lblDryCleaningForm.Text = "Dry Cleaning Form"
        lblDryCleaningForm.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 0)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel3, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 126)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 65.4784241F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 34.5215759F))
        TableLayoutPanel1.Size = New Size(473, 552)
        TableLayoutPanel1.TabIndex = 3
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 41.50677F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 58.4932251F))
        TableLayoutPanel2.Controls.Add(txtboxQuantity, 1, 3)
        TableLayoutPanel2.Controls.Add(txtboxAddress, 1, 5)
        TableLayoutPanel2.Controls.Add(txtboxContact, 1, 1)
        TableLayoutPanel2.Controls.Add(lblAddress, 0, 5)
        TableLayoutPanel2.Controls.Add(lblQuantityText, 0, 3)
        TableLayoutPanel2.Controls.Add(lblClothesSizeText, 0, 2)
        TableLayoutPanel2.Controls.Add(lblContactNumberText, 0, 1)
        TableLayoutPanel2.Controls.Add(lblCustomerNameText, 0, 0)
        TableLayoutPanel2.Controls.Add(txtboxCustomer, 1, 0)
        TableLayoutPanel2.Controls.Add(CheckBoxDelivery, 1, 4)
        TableLayoutPanel2.Controls.Add(ComboBox1, 1, 2)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 6
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.68288F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.68288F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 14.5914412F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 18.6770439F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.68288F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.68288F))
        TableLayoutPanel2.Size = New Size(467, 355)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' txtboxQuantity
        ' 
        txtboxQuantity.Anchor = AnchorStyles.Left
        txtboxQuantity.Font = New Font("Segoe UI", 18.0F)
        txtboxQuantity.Location = New Point(196, 182)
        txtboxQuantity.Name = "txtboxQuantity"
        txtboxQuantity.Size = New Size(219, 39)
        txtboxQuantity.TabIndex = 18
        ' 
        ' txtboxAddress
        ' 
        txtboxAddress.Anchor = AnchorStyles.Left
        txtboxAddress.Font = New Font("Segoe UI", 18.0F)
        txtboxAddress.Location = New Point(196, 305)
        txtboxAddress.Name = "txtboxAddress"
        txtboxAddress.Size = New Size(268, 39)
        txtboxAddress.TabIndex = 17
        ' 
        ' txtboxContact
        ' 
        txtboxContact.Anchor = AnchorStyles.Left
        txtboxContact.Font = New Font("Segoe UI", 18.0F)
        txtboxContact.Location = New Point(196, 69)
        txtboxContact.Name = "txtboxContact"
        txtboxContact.Size = New Size(219, 39)
        txtboxContact.TabIndex = 13
        ' 
        ' lblAddress
        ' 
        lblAddress.Anchor = AnchorStyles.Right
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Segoe UI", 11.25F)
        lblAddress.Location = New Point(125, 314)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(65, 20)
        lblAddress.TabIndex = 10
        lblAddress.Text = "Address:"
        ' 
        ' lblQuantityText
        ' 
        lblQuantityText.Anchor = AnchorStyles.Right
        lblQuantityText.AutoSize = True
        lblQuantityText.Font = New Font("Segoe UI", 11.25F)
        lblQuantityText.Location = New Point(122, 192)
        lblQuantityText.Name = "lblQuantityText"
        lblQuantityText.Size = New Size(68, 20)
        lblQuantityText.TabIndex = 6
        lblQuantityText.Text = "Quantity:"
        ' 
        ' lblClothesSizeText
        ' 
        lblClothesSizeText.Anchor = AnchorStyles.Right
        lblClothesSizeText.AutoSize = True
        lblClothesSizeText.Font = New Font("Segoe UI", 11.25F)
        lblClothesSizeText.Location = New Point(98, 133)
        lblClothesSizeText.Name = "lblClothesSizeText"
        lblClothesSizeText.Size = New Size(92, 20)
        lblClothesSizeText.TabIndex = 4
        lblClothesSizeText.Text = "Clothes Size:"
        ' 
        ' lblContactNumberText
        ' 
        lblContactNumberText.Anchor = AnchorStyles.Right
        lblContactNumberText.AutoSize = True
        lblContactNumberText.Font = New Font("Segoe UI", 11.25F)
        lblContactNumberText.Location = New Point(69, 78)
        lblContactNumberText.Name = "lblContactNumberText"
        lblContactNumberText.Size = New Size(121, 20)
        lblContactNumberText.TabIndex = 2
        lblContactNumberText.Text = "Contact Number:"
        ' 
        ' lblCustomerNameText
        ' 
        lblCustomerNameText.Anchor = AnchorStyles.Right
        lblCustomerNameText.AutoSize = True
        lblCustomerNameText.Font = New Font("Segoe UI", 11.25F)
        lblCustomerNameText.Location = New Point(71, 19)
        lblCustomerNameText.Name = "lblCustomerNameText"
        lblCustomerNameText.Size = New Size(119, 20)
        lblCustomerNameText.TabIndex = 0
        lblCustomerNameText.Text = "Customer Name:"
        ' 
        ' txtboxCustomer
        ' 
        txtboxCustomer.Anchor = AnchorStyles.Left
        txtboxCustomer.Font = New Font("Segoe UI", 18.0F)
        txtboxCustomer.Location = New Point(196, 10)
        txtboxCustomer.Name = "txtboxCustomer"
        txtboxCustomer.Size = New Size(219, 39)
        txtboxCustomer.TabIndex = 12
        ' 
        ' CheckBoxDelivery
        ' 
        CheckBoxDelivery.Anchor = AnchorStyles.Left
        CheckBoxDelivery.AutoSize = True
        CheckBoxDelivery.Font = New Font("Segoe UI", 11.25F)
        CheckBoxDelivery.Location = New Point(196, 252)
        CheckBoxDelivery.Name = "CheckBoxDelivery"
        CheckBoxDelivery.Size = New Size(161, 24)
        CheckBoxDelivery.TabIndex = 11
        CheckBoxDelivery.Text = "Delivery (+5 %total)"
        CheckBoxDelivery.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Small", "Medium ", "Large"})
        ComboBox1.Location = New Point(196, 121)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(219, 38)
        ComboBox1.TabIndex = 15
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel3.Controls.Add(btnFinish, 1, 0)
        TableLayoutPanel3.Controls.Add(btnCancel, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 364)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel3.Size = New Size(467, 185)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' btnFinish
        ' 
        btnFinish.Anchor = AnchorStyles.None
        btnFinish.BackColor = Color.FromArgb(CByte(57), CByte(134), CByte(90))
        btnFinish.FlatStyle = FlatStyle.Flat
        btnFinish.ForeColor = Color.White
        btnFinish.Location = New Point(277, 53)
        btnFinish.Name = "btnFinish"
        btnFinish.Size = New Size(146, 79)
        btnFinish.TabIndex = 10
        btnFinish.Text = "Finish Order"
        btnFinish.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.Anchor = AnchorStyles.None
        btnCancel.BackColor = Color.FromArgb(CByte(134), CByte(57), CByte(57))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(43, 53)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(146, 79)
        btnCancel.TabIndex = 9
        btnCancel.Text = "Cancel Order"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Dry_CleaningForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(473, 678)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(lblDryCleaningForm)
        Controls.Add(lblLaundryText)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Dry_CleaningForm"
        Text = "Dry Cleaning Form"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblLaundryText As Label
    Friend WithEvents lblDryCleaningForm As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblQuantityText As Label
    Friend WithEvents lblClothesSizeText As Label
    Friend WithEvents lblContactNumberText As Label
    Friend WithEvents lblCustomerNameText As Label
    Friend WithEvents CheckBoxDelivery As CheckBox
    Friend WithEvents txtboxAddress As TextBox
    Friend WithEvents txtboxContact As TextBox
    Friend WithEvents txtboxCustomer As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnFinish As Button
    Friend WithEvents txtboxQuantity As TextBox
End Class

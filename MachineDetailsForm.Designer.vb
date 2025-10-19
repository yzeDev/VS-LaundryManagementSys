<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MachineDetailsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MachineDetailsForm))
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel2 = New Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        lblContactNum = New Label()
        lblDeliverMethod = New Label()
        lblPaymentMethod = New Label()
        lblCustomerName = New Label()
        lblTransactionWeight = New Label()
        lblServiceType = New Label()
        lblAddress = New Label()
        lblMachineNum = New Label()
        MachineNum = New Label()
        ServiceType = New Label()
        PaymentMethod = New Label()
        ClothesWeight = New Label()
        Address = New Label()
        ContactNum = New Label()
        DeliverMethod = New Label()
        CustomerName = New Label()
        btnClose = New Button()
        Panel1 = New Panel()
        lblTitle = New Label()
        lblTransactionID = New Label()
        lblDate = New Label()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        TableLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Controls.Add(Panel2, 0, 2)
        TableLayoutPanel1.Controls.Add(btnClose, 0, 3)
        TableLayoutPanel1.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel1.Controls.Add(lblTransactionID, 0, 1)
        TableLayoutPanel1.Controls.Add(lblDate, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 60.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 40.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 40.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0F))
        TableLayoutPanel1.Size = New Size(798, 494)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        TableLayoutPanel1.SetColumnSpan(Panel2, 2)
        Panel2.Controls.Add(TableLayoutPanel2)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(3, 103)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(792, 348)
        Panel2.TabIndex = 1
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel2.Controls.Add(lblContactNum, 0, 9)
        TableLayoutPanel2.Controls.Add(lblDeliverMethod, 0, 7)
        TableLayoutPanel2.Controls.Add(lblPaymentMethod, 1, 5)
        TableLayoutPanel2.Controls.Add(lblCustomerName, 0, 5)
        TableLayoutPanel2.Controls.Add(lblTransactionWeight, 1, 3)
        TableLayoutPanel2.Controls.Add(lblServiceType, 0, 3)
        TableLayoutPanel2.Controls.Add(lblAddress, 1, 1)
        TableLayoutPanel2.Controls.Add(lblMachineNum, 0, 1)
        TableLayoutPanel2.Controls.Add(MachineNum, 0, 0)
        TableLayoutPanel2.Controls.Add(ServiceType, 0, 2)
        TableLayoutPanel2.Controls.Add(PaymentMethod, 1, 4)
        TableLayoutPanel2.Controls.Add(ClothesWeight, 1, 2)
        TableLayoutPanel2.Controls.Add(Address, 1, 0)
        TableLayoutPanel2.Controls.Add(ContactNum, 0, 8)
        TableLayoutPanel2.Controls.Add(DeliverMethod, 0, 6)
        TableLayoutPanel2.Controls.Add(CustomerName, 0, 4)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 10
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel2.Size = New Size(792, 348)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' lblContactNum
        ' 
        lblContactNum.AutoSize = True
        lblContactNum.Dock = DockStyle.Fill
        lblContactNum.Font = New Font("Segoe UI", 14.25F)
        lblContactNum.Location = New Point(3, 306)
        lblContactNum.Name = "lblContactNum"
        lblContactNum.Size = New Size(390, 42)
        lblContactNum.TabIndex = 29
        lblContactNum.Text = "num"
        lblContactNum.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblDeliverMethod
        ' 
        lblDeliverMethod.AutoSize = True
        lblDeliverMethod.Dock = DockStyle.Fill
        lblDeliverMethod.Font = New Font("Segoe UI", 14.25F)
        lblDeliverMethod.Location = New Point(3, 238)
        lblDeliverMethod.Name = "lblDeliverMethod"
        lblDeliverMethod.Size = New Size(390, 34)
        lblDeliverMethod.TabIndex = 26
        lblDeliverMethod.Text = "pickup"
        lblDeliverMethod.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblPaymentMethod
        ' 
        lblPaymentMethod.AutoSize = True
        lblPaymentMethod.Dock = DockStyle.Fill
        lblPaymentMethod.Font = New Font("Segoe UI", 14.25F)
        lblPaymentMethod.Location = New Point(399, 170)
        lblPaymentMethod.Name = "lblPaymentMethod"
        lblPaymentMethod.Size = New Size(390, 34)
        lblPaymentMethod.TabIndex = 24
        lblPaymentMethod.Text = "cash / gcash / maya"
        lblPaymentMethod.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblCustomerName
        ' 
        lblCustomerName.AutoSize = True
        lblCustomerName.Dock = DockStyle.Fill
        lblCustomerName.Font = New Font("Segoe UI", 14.25F)
        lblCustomerName.Location = New Point(3, 170)
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Size = New Size(390, 34)
        lblCustomerName.TabIndex = 23
        lblCustomerName.Text = "name"
        lblCustomerName.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblTransactionWeight
        ' 
        lblTransactionWeight.AutoSize = True
        lblTransactionWeight.Dock = DockStyle.Fill
        lblTransactionWeight.Font = New Font("Segoe UI", 14.25F)
        lblTransactionWeight.Location = New Point(399, 102)
        lblTransactionWeight.Name = "lblTransactionWeight"
        lblTransactionWeight.Size = New Size(390, 34)
        lblTransactionWeight.TabIndex = 22
        lblTransactionWeight.Text = "weight"
        lblTransactionWeight.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblServiceType
        ' 
        lblServiceType.AutoSize = True
        lblServiceType.Dock = DockStyle.Fill
        lblServiceType.Font = New Font("Segoe UI", 14.25F)
        lblServiceType.Location = New Point(3, 102)
        lblServiceType.Name = "lblServiceType"
        lblServiceType.Size = New Size(390, 34)
        lblServiceType.TabIndex = 21
        lblServiceType.Text = "service"
        lblServiceType.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Dock = DockStyle.Fill
        lblAddress.Font = New Font("Segoe UI", 14.25F)
        lblAddress.Location = New Point(399, 34)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(390, 34)
        lblAddress.TabIndex = 20
        lblAddress.Text = "address"
        lblAddress.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblMachineNum
        ' 
        lblMachineNum.AutoSize = True
        lblMachineNum.Dock = DockStyle.Fill
        lblMachineNum.Font = New Font("Segoe UI", 14.25F)
        lblMachineNum.Location = New Point(3, 34)
        lblMachineNum.Name = "lblMachineNum"
        lblMachineNum.Size = New Size(390, 34)
        lblMachineNum.TabIndex = 19
        lblMachineNum.Text = "0"
        lblMachineNum.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' MachineNum
        ' 
        MachineNum.AutoSize = True
        MachineNum.Dock = DockStyle.Fill
        MachineNum.Font = New Font("Segoe UI", 14.25F)
        MachineNum.Location = New Point(3, 0)
        MachineNum.Name = "MachineNum"
        MachineNum.Size = New Size(390, 34)
        MachineNum.TabIndex = 0
        MachineNum.Text = "Machine Number:"
        MachineNum.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' ServiceType
        ' 
        ServiceType.AutoSize = True
        ServiceType.Dock = DockStyle.Fill
        ServiceType.Font = New Font("Segoe UI", 14.25F)
        ServiceType.Location = New Point(3, 68)
        ServiceType.Name = "ServiceType"
        ServiceType.Size = New Size(390, 34)
        ServiceType.TabIndex = 1
        ServiceType.Text = "Service Type"
        ServiceType.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' PaymentMethod
        ' 
        PaymentMethod.AutoSize = True
        PaymentMethod.Dock = DockStyle.Fill
        PaymentMethod.Font = New Font("Segoe UI", 14.25F)
        PaymentMethod.Location = New Point(399, 136)
        PaymentMethod.Name = "PaymentMethod"
        PaymentMethod.Size = New Size(390, 34)
        PaymentMethod.TabIndex = 6
        PaymentMethod.Text = "Payment Method:"
        PaymentMethod.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' ClothesWeight
        ' 
        ClothesWeight.AutoSize = True
        ClothesWeight.Dock = DockStyle.Fill
        ClothesWeight.Font = New Font("Segoe UI", 14.25F)
        ClothesWeight.Location = New Point(399, 68)
        ClothesWeight.Name = "ClothesWeight"
        ClothesWeight.Size = New Size(390, 34)
        ClothesWeight.TabIndex = 5
        ClothesWeight.Text = "Clothes Weight:"
        ClothesWeight.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Address
        ' 
        Address.AutoSize = True
        Address.Dock = DockStyle.Fill
        Address.Font = New Font("Segoe UI", 14.25F)
        Address.Location = New Point(399, 0)
        Address.Name = "Address"
        Address.Size = New Size(390, 34)
        Address.TabIndex = 4
        Address.Text = "Address:"
        Address.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' ContactNum
        ' 
        ContactNum.AutoSize = True
        ContactNum.Dock = DockStyle.Fill
        ContactNum.Font = New Font("Segoe UI", 14.25F)
        ContactNum.Location = New Point(3, 272)
        ContactNum.Name = "ContactNum"
        ContactNum.Size = New Size(390, 34)
        ContactNum.TabIndex = 3
        ContactNum.Text = "Contact Number:"
        ContactNum.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' DeliverMethod
        ' 
        DeliverMethod.AutoSize = True
        DeliverMethod.Dock = DockStyle.Fill
        DeliverMethod.Font = New Font("Segoe UI", 14.25F)
        DeliverMethod.Location = New Point(3, 204)
        DeliverMethod.Name = "DeliverMethod"
        DeliverMethod.Size = New Size(390, 34)
        DeliverMethod.TabIndex = 2
        DeliverMethod.Text = "Deliver Method:"
        DeliverMethod.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' CustomerName
        ' 
        CustomerName.AutoSize = True
        CustomerName.Dock = DockStyle.Fill
        CustomerName.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CustomerName.Location = New Point(3, 136)
        CustomerName.Name = "CustomerName"
        CustomerName.Size = New Size(390, 34)
        CustomerName.TabIndex = 18
        CustomerName.Text = "Customer Name:"
        CustomerName.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.None
        TableLayoutPanel1.SetColumnSpan(btnClose, 2)
        btnClose.Location = New Point(361, 457)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 34)
        btnClose.TabIndex = 3
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        TableLayoutPanel1.SetColumnSpan(Panel1, 2)
        Panel1.Controls.Add(lblTitle)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(792, 54)
        Panel1.TabIndex = 4
        ' 
        ' lblTitle
        ' 
        lblTitle.Dock = DockStyle.Fill
        lblTitle.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(0, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(792, 54)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Machine Details"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTransactionID
        ' 
        lblTransactionID.AutoSize = True
        lblTransactionID.Dock = DockStyle.Fill
        lblTransactionID.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTransactionID.Location = New Point(3, 60)
        lblTransactionID.Name = "lblTransactionID"
        lblTransactionID.Size = New Size(393, 40)
        lblTransactionID.TabIndex = 5
        lblTransactionID.Text = "Transaction ID:"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Dock = DockStyle.Fill
        lblDate.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDate.Location = New Point(402, 60)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(393, 40)
        lblDate.TabIndex = 6
        lblDate.Text = "Transaction Date:"
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' MachineDetailsForm
        ' 
        AutoScaleDimensions = New SizeF(96.0F, 96.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(798, 494)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(798, 494)
        MinimumSize = New Size(798, 494)
        Name = "MachineDetailsForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Machine Form"
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
    Friend WithEvents btnClose As Button
    Friend WithEvents MachineNum As Label
    Friend WithEvents ServiceType As Label
    Friend WithEvents DeliverMethod As Label
    Friend WithEvents ContactNum As Label
    Friend WithEvents Address As Label
    Friend WithEvents ClothesWeight As Label
    Friend WithEvents PaymentMethod As Label
    Friend WithEvents CustomerName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTransactionID As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblContactNum As Label
    Friend WithEvents lblDeliverMethod As Label
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblTransactionWeight As Label
    Friend WithEvents lblServiceType As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblMachineNum As Label
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
End Class

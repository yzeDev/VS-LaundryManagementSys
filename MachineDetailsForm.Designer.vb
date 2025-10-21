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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
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
        lblTransactionID = New Label()
        lblDate = New Label()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        lblTitle = New Label()
        Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        TableLayoutPanel5 = New TableLayoutPanel()
        Label1 = New Label()
        datelbl = New Label()
        Label2 = New Label()
        lblTotal = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        TableLayoutPanel6 = New TableLayoutPanel()
        TableLayoutPanel7 = New TableLayoutPanel()
        TableLayoutPanel8 = New TableLayoutPanel()
        TableLayoutPanel9 = New TableLayoutPanel()
        TableLayoutPanel10 = New TableLayoutPanel()
        TableLayoutPanel11 = New TableLayoutPanel()
        TableLayoutPanel12 = New TableLayoutPanel()
        TableLayoutPanel13 = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox9 = New PictureBox()
        TableLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        Panel1.SuspendLayout()
        Guna2GradientPanel1.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        TableLayoutPanel8.SuspendLayout()
        TableLayoutPanel9.SuspendLayout()
        TableLayoutPanel10.SuspendLayout()
        TableLayoutPanel11.SuspendLayout()
        TableLayoutPanel12.SuspendLayout()
        TableLayoutPanel13.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.1002F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.8998F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel5, 0, 1)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel4, 1, 1)
        TableLayoutPanel1.Controls.Add(Panel2, 0, 2)
        TableLayoutPanel1.Controls.Add(btnClose, 0, 3)
        TableLayoutPanel1.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(4, 4, 4, 4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 75F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(998, 618)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        TableLayoutPanel1.SetColumnSpan(Panel2, 2)
        Panel2.Controls.Add(TableLayoutPanel2)
        Panel2.Location = New Point(4, 129)
        Panel2.Margin = New Padding(4, 4, 4, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(990, 435)
        Panel2.TabIndex = 1
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel13, 1, 6)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel12, 1, 4)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel11, 1, 2)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel10, 1, 0)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel9, 0, 8)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel7, 0, 4)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel8, 0, 6)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel6, 0, 2)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 0)
        TableLayoutPanel2.Controls.Add(lblTotal, 1, 7)
        TableLayoutPanel2.Controls.Add(lblContactNum, 0, 9)
        TableLayoutPanel2.Controls.Add(lblDeliverMethod, 0, 7)
        TableLayoutPanel2.Controls.Add(lblPaymentMethod, 1, 5)
        TableLayoutPanel2.Controls.Add(lblCustomerName, 0, 5)
        TableLayoutPanel2.Controls.Add(lblTransactionWeight, 1, 3)
        TableLayoutPanel2.Controls.Add(lblServiceType, 0, 3)
        TableLayoutPanel2.Controls.Add(lblAddress, 1, 1)
        TableLayoutPanel2.Controls.Add(lblMachineNum, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Margin = New Padding(4, 4, 4, 4)
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
        TableLayoutPanel2.Size = New Size(990, 435)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' lblContactNum
        ' 
        lblContactNum.AutoSize = True
        lblContactNum.BackColor = Color.LightGray
        lblContactNum.Dock = DockStyle.Fill
        lblContactNum.Font = New Font("Poppins", 13.8F)
        lblContactNum.ForeColor = Color.FromArgb(CByte(76), CByte(76), CByte(76))
        lblContactNum.Location = New Point(4, 387)
        lblContactNum.Margin = New Padding(4, 0, 4, 0)
        lblContactNum.Name = "lblContactNum"
        lblContactNum.Size = New Size(487, 48)
        lblContactNum.TabIndex = 29
        lblContactNum.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblDeliverMethod
        ' 
        lblDeliverMethod.AutoSize = True
        lblDeliverMethod.BackColor = Color.LightGray
        lblDeliverMethod.Dock = DockStyle.Fill
        lblDeliverMethod.Font = New Font("Poppins", 13.8F)
        lblDeliverMethod.ForeColor = Color.FromArgb(CByte(76), CByte(76), CByte(76))
        lblDeliverMethod.Location = New Point(4, 301)
        lblDeliverMethod.Margin = New Padding(4, 0, 4, 0)
        lblDeliverMethod.Name = "lblDeliverMethod"
        lblDeliverMethod.Size = New Size(487, 43)
        lblDeliverMethod.TabIndex = 26
        lblDeliverMethod.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblPaymentMethod
        ' 
        lblPaymentMethod.AutoSize = True
        lblPaymentMethod.BackColor = Color.LightGray
        lblPaymentMethod.Dock = DockStyle.Fill
        lblPaymentMethod.Font = New Font("Poppins", 13.8F)
        lblPaymentMethod.ForeColor = Color.FromArgb(CByte(76), CByte(76), CByte(76))
        lblPaymentMethod.Location = New Point(499, 215)
        lblPaymentMethod.Margin = New Padding(4, 0, 4, 0)
        lblPaymentMethod.Name = "lblPaymentMethod"
        lblPaymentMethod.Size = New Size(487, 43)
        lblPaymentMethod.TabIndex = 24
        lblPaymentMethod.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblCustomerName
        ' 
        lblCustomerName.AutoSize = True
        lblCustomerName.BackColor = Color.LightGray
        lblCustomerName.Dock = DockStyle.Fill
        lblCustomerName.Font = New Font("Poppins", 13.8F)
        lblCustomerName.ForeColor = Color.FromArgb(CByte(76), CByte(76), CByte(76))
        lblCustomerName.Location = New Point(4, 215)
        lblCustomerName.Margin = New Padding(4, 0, 4, 0)
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Size = New Size(487, 43)
        lblCustomerName.TabIndex = 23
        lblCustomerName.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblTransactionWeight
        ' 
        lblTransactionWeight.AutoSize = True
        lblTransactionWeight.BackColor = Color.LightGray
        lblTransactionWeight.Dock = DockStyle.Fill
        lblTransactionWeight.Font = New Font("Poppins", 13.8F)
        lblTransactionWeight.ForeColor = Color.FromArgb(CByte(76), CByte(76), CByte(76))
        lblTransactionWeight.Location = New Point(499, 129)
        lblTransactionWeight.Margin = New Padding(4, 0, 4, 0)
        lblTransactionWeight.Name = "lblTransactionWeight"
        lblTransactionWeight.Size = New Size(487, 43)
        lblTransactionWeight.TabIndex = 22
        lblTransactionWeight.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblServiceType
        ' 
        lblServiceType.AutoSize = True
        lblServiceType.BackColor = Color.LightGray
        lblServiceType.Dock = DockStyle.Fill
        lblServiceType.Font = New Font("Poppins", 13.8F)
        lblServiceType.ForeColor = Color.FromArgb(CByte(76), CByte(76), CByte(76))
        lblServiceType.Location = New Point(4, 129)
        lblServiceType.Margin = New Padding(4, 0, 4, 0)
        lblServiceType.Name = "lblServiceType"
        lblServiceType.Size = New Size(487, 43)
        lblServiceType.TabIndex = 21
        lblServiceType.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.BackColor = Color.LightGray
        lblAddress.Dock = DockStyle.Fill
        lblAddress.Font = New Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAddress.ForeColor = Color.FromArgb(CByte(76), CByte(76), CByte(76))
        lblAddress.Location = New Point(499, 43)
        lblAddress.Margin = New Padding(4, 0, 4, 0)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(487, 43)
        lblAddress.TabIndex = 20
        lblAddress.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblMachineNum
        ' 
        lblMachineNum.AutoSize = True
        lblMachineNum.BackColor = Color.LightGray
        lblMachineNum.Dock = DockStyle.Fill
        lblMachineNum.Font = New Font("Poppins", 13.8F)
        lblMachineNum.ForeColor = Color.FromArgb(CByte(76), CByte(76), CByte(76))
        lblMachineNum.Location = New Point(4, 43)
        lblMachineNum.Margin = New Padding(4, 0, 4, 0)
        lblMachineNum.Name = "lblMachineNum"
        lblMachineNum.Size = New Size(487, 43)
        lblMachineNum.TabIndex = 19
        lblMachineNum.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' MachineNum
        ' 
        MachineNum.AutoSize = True
        MachineNum.Dock = DockStyle.Fill
        MachineNum.Font = New Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MachineNum.Location = New Point(38, 0)
        MachineNum.Margin = New Padding(4, 0, 4, 0)
        MachineNum.Name = "MachineNum"
        MachineNum.Size = New Size(447, 37)
        MachineNum.TabIndex = 0
        MachineNum.Text = "Machine Number:"
        MachineNum.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' ServiceType
        ' 
        ServiceType.AutoSize = True
        ServiceType.Dock = DockStyle.Fill
        ServiceType.Font = New Font("Poppins", 13.8F)
        ServiceType.Location = New Point(38, 0)
        ServiceType.Margin = New Padding(4, 0, 4, 0)
        ServiceType.Name = "ServiceType"
        ServiceType.Size = New Size(447, 37)
        ServiceType.TabIndex = 1
        ServiceType.Text = "Service Type:"
        ServiceType.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' PaymentMethod
        ' 
        PaymentMethod.AutoSize = True
        PaymentMethod.Dock = DockStyle.Fill
        PaymentMethod.Font = New Font("Poppins", 13.8F)
        PaymentMethod.Location = New Point(39, 0)
        PaymentMethod.Margin = New Padding(4, 0, 4, 0)
        PaymentMethod.Name = "PaymentMethod"
        PaymentMethod.Size = New Size(446, 37)
        PaymentMethod.TabIndex = 6
        PaymentMethod.Text = "Payment Method:"
        PaymentMethod.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' ClothesWeight
        ' 
        ClothesWeight.AutoSize = True
        ClothesWeight.Dock = DockStyle.Fill
        ClothesWeight.Font = New Font("Poppins", 13.8F)
        ClothesWeight.Location = New Point(39, 0)
        ClothesWeight.Margin = New Padding(4, 0, 4, 0)
        ClothesWeight.Name = "ClothesWeight"
        ClothesWeight.Size = New Size(446, 37)
        ClothesWeight.TabIndex = 5
        ClothesWeight.Text = "Clothes Weight:"
        ClothesWeight.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Address
        ' 
        Address.AutoSize = True
        Address.Dock = DockStyle.Fill
        Address.Font = New Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Address.Location = New Point(40, 0)
        Address.Margin = New Padding(4, 0, 4, 0)
        Address.Name = "Address"
        Address.Size = New Size(445, 37)
        Address.TabIndex = 4
        Address.Text = "Address:"
        Address.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' ContactNum
        ' 
        ContactNum.AutoSize = True
        ContactNum.Dock = DockStyle.Fill
        ContactNum.Font = New Font("Poppins", 13.8F)
        ContactNum.Location = New Point(39, 0)
        ContactNum.Margin = New Padding(4, 0, 4, 0)
        ContactNum.Name = "ContactNum"
        ContactNum.Size = New Size(446, 37)
        ContactNum.TabIndex = 3
        ContactNum.Text = "Contact Number:"
        ContactNum.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' DeliverMethod
        ' 
        DeliverMethod.AutoSize = True
        DeliverMethod.Dock = DockStyle.Fill
        DeliverMethod.Font = New Font("Poppins", 13.8F)
        DeliverMethod.Location = New Point(39, 0)
        DeliverMethod.Margin = New Padding(4, 0, 4, 0)
        DeliverMethod.Name = "DeliverMethod"
        DeliverMethod.Size = New Size(446, 37)
        DeliverMethod.TabIndex = 2
        DeliverMethod.Text = "Deliver Method:"
        DeliverMethod.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' CustomerName
        ' 
        CustomerName.AutoSize = True
        CustomerName.Dock = DockStyle.Fill
        CustomerName.Font = New Font("Poppins", 13.8F)
        CustomerName.Location = New Point(41, 0)
        CustomerName.Margin = New Padding(4, 0, 4, 0)
        CustomerName.Name = "CustomerName"
        CustomerName.Size = New Size(444, 37)
        CustomerName.TabIndex = 18
        CustomerName.Text = "Customer Name:"
        CustomerName.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.None
        TableLayoutPanel1.SetColumnSpan(btnClose, 2)
        btnClose.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(443, 572)
        btnClose.Margin = New Padding(4, 4, 4, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(112, 42)
        btnClose.TabIndex = 3
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        TableLayoutPanel1.SetColumnSpan(Panel1, 2)
        Panel1.Controls.Add(Guna2GradientPanel1)
        Panel1.Location = New Point(4, 4)
        Panel1.Margin = New Padding(4, 4, 4, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(990, 67)
        Panel1.TabIndex = 4
        ' 
        ' lblTransactionID
        ' 
        lblTransactionID.AutoSize = True
        lblTransactionID.Dock = DockStyle.Fill
        lblTransactionID.Font = New Font("Poppins", 13.8F)
        lblTransactionID.ForeColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        lblTransactionID.Location = New Point(4, 0)
        lblTransactionID.Margin = New Padding(4, 0, 4, 0)
        lblTransactionID.Name = "lblTransactionID"
        lblTransactionID.Size = New Size(194, 44)
        lblTransactionID.TabIndex = 5
        lblTransactionID.Text = "Transaction ID:"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Dock = DockStyle.Fill
        lblDate.Font = New Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDate.ForeColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        lblDate.Location = New Point(4, 0)
        lblDate.Margin = New Padding(4, 0, 4, 0)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(221, 44)
        lblDate.TabIndex = 6
        lblDate.Text = "Transaction Date:"
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = Color.Transparent
        lblTitle.Dock = DockStyle.Fill
        lblTitle.Font = New Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(0, 0)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(990, 67)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Machine Details"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Guna2GradientPanel1
        ' 
        Guna2GradientPanel1.Controls.Add(lblTitle)
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges3
        Guna2GradientPanel1.Dock = DockStyle.Fill
        Guna2GradientPanel1.FillColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        Guna2GradientPanel1.FillColor2 = Color.FromArgb(CByte(76), CByte(102), CByte(232))
        Guna2GradientPanel1.Location = New Point(0, 0)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2GradientPanel1.Size = New Size(990, 67)
        Guna2GradientPanel1.TabIndex = 1
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 46.6531448F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 53.3468552F))
        TableLayoutPanel4.Controls.Add(lblDate, 0, 0)
        TableLayoutPanel4.Controls.Add(datelbl, 1, 0)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Font = New Font("Poppins", 13.8F)
        TableLayoutPanel4.Location = New Point(503, 78)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(492, 44)
        TableLayoutPanel4.TabIndex = 1
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40.97363F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 59.02637F))
        TableLayoutPanel5.Controls.Add(Label1, 1, 0)
        TableLayoutPanel5.Controls.Add(lblTransactionID, 0, 0)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Location = New Point(3, 78)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Size = New Size(494, 44)
        TableLayoutPanel5.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 13.8F)
        Label1.ForeColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        Label1.Location = New Point(206, 0)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 40)
        Label1.TabIndex = 6
        Label1.Text = "#100011"
        ' 
        ' datelbl
        ' 
        datelbl.AutoSize = True
        datelbl.Dock = DockStyle.Fill
        datelbl.Font = New Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        datelbl.ForeColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        datelbl.Location = New Point(233, 0)
        datelbl.Margin = New Padding(4, 0, 4, 0)
        datelbl.Name = "datelbl"
        datelbl.Size = New Size(255, 44)
        datelbl.TabIndex = 7
        datelbl.Text = "10/22/2025"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Poppins", 13.8F)
        Label2.Location = New Point(39, 0)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(446, 37)
        Label2.TabIndex = 30
        Label2.Text = "Total:"
        Label2.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.BackColor = Color.LightGray
        lblTotal.Dock = DockStyle.Fill
        lblTotal.Font = New Font("Poppins", 13.8F)
        lblTotal.ForeColor = Color.FromArgb(CByte(76), CByte(76), CByte(76))
        lblTotal.Location = New Point(499, 301)
        lblTotal.Margin = New Padding(4, 0, 4, 0)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(487, 43)
        lblTotal.TabIndex = 31
        lblTotal.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 6.95296526F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 93.0470352F))
        TableLayoutPanel3.Controls.Add(PictureBox7, 0, 0)
        TableLayoutPanel3.Controls.Add(MachineNum, 1, 0)
        TableLayoutPanel3.Location = New Point(3, 3)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(489, 37)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.ColumnCount = 2
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 6.95296526F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 93.0470352F))
        TableLayoutPanel6.Controls.Add(ServiceType, 1, 0)
        TableLayoutPanel6.Controls.Add(PictureBox6, 0, 0)
        TableLayoutPanel6.Location = New Point(3, 89)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 1
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.Size = New Size(489, 37)
        TableLayoutPanel6.TabIndex = 2
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.ColumnCount = 2
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 7.566462F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 92.43354F))
        TableLayoutPanel7.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel7.Controls.Add(CustomerName, 1, 0)
        TableLayoutPanel7.Location = New Point(3, 175)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 1
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.Size = New Size(489, 37)
        TableLayoutPanel7.TabIndex = 3
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.ColumnCount = 2
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 7.157464F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 92.84254F))
        TableLayoutPanel8.Controls.Add(PictureBox9, 0, 0)
        TableLayoutPanel8.Controls.Add(DeliverMethod, 1, 0)
        TableLayoutPanel8.Location = New Point(3, 261)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.RowCount = 1
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.Size = New Size(489, 37)
        TableLayoutPanel8.TabIndex = 3
        ' 
        ' TableLayoutPanel9
        ' 
        TableLayoutPanel9.ColumnCount = 2
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 7.157464F))
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 92.84254F))
        TableLayoutPanel9.Controls.Add(PictureBox2, 0, 0)
        TableLayoutPanel9.Controls.Add(ContactNum, 1, 0)
        TableLayoutPanel9.Location = New Point(3, 347)
        TableLayoutPanel9.Name = "TableLayoutPanel9"
        TableLayoutPanel9.RowCount = 1
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel9.Size = New Size(489, 37)
        TableLayoutPanel9.TabIndex = 4
        ' 
        ' TableLayoutPanel10
        ' 
        TableLayoutPanel10.ColumnCount = 2
        TableLayoutPanel10.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 7.36196327F))
        TableLayoutPanel10.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 92.63804F))
        TableLayoutPanel10.Controls.Add(PictureBox3, 0, 0)
        TableLayoutPanel10.Controls.Add(Address, 1, 0)
        TableLayoutPanel10.Location = New Point(498, 3)
        TableLayoutPanel10.Name = "TableLayoutPanel10"
        TableLayoutPanel10.RowCount = 1
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel10.Size = New Size(489, 37)
        TableLayoutPanel10.TabIndex = 4
        ' 
        ' TableLayoutPanel11
        ' 
        TableLayoutPanel11.ColumnCount = 2
        TableLayoutPanel11.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 7.157464F))
        TableLayoutPanel11.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 92.84254F))
        TableLayoutPanel11.Controls.Add(PictureBox8, 0, 0)
        TableLayoutPanel11.Controls.Add(ClothesWeight, 1, 0)
        TableLayoutPanel11.Location = New Point(498, 89)
        TableLayoutPanel11.Name = "TableLayoutPanel11"
        TableLayoutPanel11.RowCount = 1
        TableLayoutPanel11.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel11.Size = New Size(489, 37)
        TableLayoutPanel11.TabIndex = 4
        ' 
        ' TableLayoutPanel12
        ' 
        TableLayoutPanel12.ColumnCount = 2
        TableLayoutPanel12.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 7.157464F))
        TableLayoutPanel12.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 92.84254F))
        TableLayoutPanel12.Controls.Add(PictureBox4, 0, 0)
        TableLayoutPanel12.Controls.Add(PaymentMethod, 1, 0)
        TableLayoutPanel12.Location = New Point(498, 175)
        TableLayoutPanel12.Name = "TableLayoutPanel12"
        TableLayoutPanel12.RowCount = 1
        TableLayoutPanel12.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel12.Size = New Size(489, 37)
        TableLayoutPanel12.TabIndex = 4
        ' 
        ' TableLayoutPanel13
        ' 
        TableLayoutPanel13.ColumnCount = 2
        TableLayoutPanel13.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 7.157464F))
        TableLayoutPanel13.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 92.84254F))
        TableLayoutPanel13.Controls.Add(PictureBox5, 0, 0)
        TableLayoutPanel13.Controls.Add(Label2, 1, 0)
        TableLayoutPanel13.Location = New Point(498, 261)
        TableLayoutPanel13.Name = "TableLayoutPanel13"
        TableLayoutPanel13.RowCount = 1
        TableLayoutPanel13.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel13.Size = New Size(489, 37)
        TableLayoutPanel13.TabIndex = 4
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.name
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(31, 31)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 33
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(29, 31)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 34
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(3, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(30, 31)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 34
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(3, 3)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(29, 31)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 34
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(3, 3)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(29, 31)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 35
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Dock = DockStyle.Fill
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(3, 3)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(28, 31)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 35
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Dock = DockStyle.Fill
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(3, 3)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(28, 31)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 36
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(3, 3)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(29, 31)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 35
        PictureBox8.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Dock = DockStyle.Fill
        PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), Image)
        PictureBox9.Location = New Point(3, 3)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(29, 31)
        PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox9.TabIndex = 36
        PictureBox9.TabStop = False
        ' 
        ' MachineDetailsForm
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(998, 618)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 4, 4, 4)
        MaximumSize = New Size(998, 618)
        MinimumSize = New Size(998, 618)
        Name = "MachineDetailsForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Machine Form"
        TableLayoutPanel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Guna2GradientPanel1.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        TableLayoutPanel7.ResumeLayout(False)
        TableLayoutPanel7.PerformLayout()
        TableLayoutPanel8.ResumeLayout(False)
        TableLayoutPanel8.PerformLayout()
        TableLayoutPanel9.ResumeLayout(False)
        TableLayoutPanel9.PerformLayout()
        TableLayoutPanel10.ResumeLayout(False)
        TableLayoutPanel10.PerformLayout()
        TableLayoutPanel11.ResumeLayout(False)
        TableLayoutPanel11.PerformLayout()
        TableLayoutPanel12.ResumeLayout(False)
        TableLayoutPanel12.PerformLayout()
        TableLayoutPanel13.ResumeLayout(False)
        TableLayoutPanel13.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblTitle As Label
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents datelbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
End Class

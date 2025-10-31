<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransactionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransactionForm))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        TableLayoutPanel1 = New TableLayoutPanel()
        tbMachineUsed = New TextBox()
        tbCustomerName = New TextBox()
        TableLayoutPanel12 = New TableLayoutPanel()
        Label10 = New Label()
        PictureBox6 = New PictureBox()
        TableLayoutPanel7 = New TableLayoutPanel()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        lblSubtitle = New Label()
        lblMode = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        lblDate = New Label()
        lblAddress = New TableLayoutPanel()
        Label6 = New Label()
        PictureBox4 = New PictureBox()
        TableLayoutPanel9 = New TableLayoutPanel()
        Label7 = New Label()
        PictureBox3 = New PictureBox()
        TableLayoutPanel11 = New TableLayoutPanel()
        Label9 = New Label()
        PictureBox5 = New PictureBox()
        cbStatus = New ComboBox()
        TableLayoutPanel15 = New TableLayoutPanel()
        PictureBox9 = New PictureBox()
        Label13 = New Label()
        TableLayoutPanel16 = New TableLayoutPanel()
        PictureBox10 = New PictureBox()
        Label14 = New Label()
        TableLayoutPanel17 = New TableLayoutPanel()
        cbService = New ComboBox()
        tbPaymentMethod = New TextBox()
        TableLayoutPanel21 = New TableLayoutPanel()
        PictureBox2 = New PictureBox()
        Label22 = New Label()
        TableLayoutPanel19 = New TableLayoutPanel()
        Label18 = New Label()
        PictureBox7 = New PictureBox()
        TableLayoutPanel20 = New TableLayoutPanel()
        tbTotal = New TextBox()
        TableLayoutPanel23 = New TableLayoutPanel()
        Label23 = New Label()
        PictureBox8 = New PictureBox()
        tbContactNum = New TextBox()
        TableLayoutPanel22 = New TableLayoutPanel()
        tbAmountReceived = New TextBox()
        tbAddress = New TextBox()
        TableLayoutPanel24 = New TableLayoutPanel()
        tbChange = New TextBox()
        btnSave = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        TableLayoutPanel8 = New TableLayoutPanel()
        btnCancel = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Label2 = New Label()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel7 = New Panel()
        Panel8 = New Panel()
        Panel10 = New Panel()
        Panel11 = New Panel()
        Panel12 = New Panel()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel12.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel7.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        lblAddress.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel9.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel11.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel15.SuspendLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel16.SuspendLayout()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel17.SuspendLayout()
        TableLayoutPanel21.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel19.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel20.SuspendLayout()
        TableLayoutPanel23.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel22.SuspendLayout()
        TableLayoutPanel24.SuspendLayout()
        TableLayoutPanel8.SuspendLayout()
        Guna2GradientPanel1.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        Panel10.SuspendLayout()
        Panel11.SuspendLayout()
        Panel12.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(tbMachineUsed, 1, 1)
        TableLayoutPanel1.Controls.Add(tbCustomerName, 0, 1)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel12, 1, 0)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel7, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(2)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(794, 61)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' tbMachineUsed
        ' 
        tbMachineUsed.BackColor = Color.LightGray
        tbMachineUsed.Dock = DockStyle.Fill
        tbMachineUsed.Font = New Font("Poppins", 12F)
        tbMachineUsed.Location = New Point(399, 32)
        tbMachineUsed.Margin = New Padding(2)
        tbMachineUsed.Name = "tbMachineUsed"
        tbMachineUsed.Size = New Size(393, 31)
        tbMachineUsed.TabIndex = 35
        ' 
        ' tbCustomerName
        ' 
        tbCustomerName.BackColor = Color.LightGray
        tbCustomerName.Dock = DockStyle.Fill
        tbCustomerName.Font = New Font("Poppins", 12F)
        tbCustomerName.Location = New Point(2, 32)
        tbCustomerName.Margin = New Padding(2)
        tbCustomerName.Name = "tbCustomerName"
        tbCustomerName.Size = New Size(393, 31)
        tbCustomerName.TabIndex = 33
        ' 
        ' TableLayoutPanel12
        ' 
        TableLayoutPanel12.ColumnCount = 2
        TableLayoutPanel12.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 40F))
        TableLayoutPanel12.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel12.Controls.Add(Label10, 1, 0)
        TableLayoutPanel12.Controls.Add(PictureBox6, 0, 0)
        TableLayoutPanel12.Dock = DockStyle.Fill
        TableLayoutPanel12.Location = New Point(399, 2)
        TableLayoutPanel12.Margin = New Padding(2)
        TableLayoutPanel12.Name = "TableLayoutPanel12"
        TableLayoutPanel12.RowCount = 1
        TableLayoutPanel12.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel12.Size = New Size(393, 26)
        TableLayoutPanel12.TabIndex = 17
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Dock = DockStyle.Fill
        Label10.Font = New Font("Poppins", 12F)
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(42, 0)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(349, 26)
        Label10.TabIndex = 6
        Label10.Text = "Machine Used:"
        Label10.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Dock = DockStyle.Fill
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(2, 2)
        PictureBox6.Margin = New Padding(2)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(36, 22)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 37
        PictureBox6.TabStop = False
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.ColumnCount = 2
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 40F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel7.Controls.Add(Label5, 1, 0)
        TableLayoutPanel7.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel7.Dock = DockStyle.Fill
        TableLayoutPanel7.Location = New Point(2, 2)
        TableLayoutPanel7.Margin = New Padding(2)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 1
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel7.Size = New Size(393, 26)
        TableLayoutPanel7.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Dock = DockStyle.Fill
        Label5.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.ImageAlign = ContentAlignment.BottomCenter
        Label5.Location = New Point(42, 0)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(349, 26)
        Label5.TabIndex = 6
        Label5.Text = "Customer Name:"
        Label5.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.name
        PictureBox1.Location = New Point(2, 2)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(36, 22)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 32
        PictureBox1.TabStop = False
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(lblSubtitle, 0, 1)
        TableLayoutPanel2.Controls.Add(lblMode, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Margin = New Padding(2)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(394, 61)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Dock = DockStyle.Fill
        lblSubtitle.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSubtitle.ForeColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        lblSubtitle.Location = New Point(2, 30)
        lblSubtitle.Margin = New Padding(2, 0, 2, 0)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(390, 31)
        lblSubtitle.TabIndex = 7
        lblSubtitle.Text = "Transaction ID:"
        ' 
        ' lblMode
        ' 
        lblMode.AutoSize = True
        lblMode.Font = New Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMode.ForeColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        lblMode.Location = New Point(2, 0)
        lblMode.Margin = New Padding(2, 0, 2, 0)
        lblMode.Name = "lblMode"
        lblMode.Size = New Size(111, 28)
        lblMode.TabIndex = 5
        lblMode.Text = "VIEW MODE: "
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(lblDate, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Margin = New Padding(2)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(394, 61)
        TableLayoutPanel3.TabIndex = 2
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Dock = DockStyle.Fill
        lblDate.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDate.ForeColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        lblDate.Location = New Point(2, 0)
        lblDate.Margin = New Padding(2, 0, 2, 0)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(390, 30)
        lblDate.TabIndex = 8
        lblDate.Text = "Date:"
        lblDate.TextAlign = ContentAlignment.TopRight
        ' 
        ' lblAddress
        ' 
        lblAddress.ColumnCount = 2
        lblAddress.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 40F))
        lblAddress.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        lblAddress.Controls.Add(Label6, 1, 0)
        lblAddress.Controls.Add(PictureBox4, 0, 0)
        lblAddress.Dock = DockStyle.Fill
        lblAddress.Location = New Point(2, 2)
        lblAddress.Margin = New Padding(2)
        lblAddress.Name = "lblAddress"
        lblAddress.RowCount = 1
        lblAddress.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        lblAddress.Size = New Size(393, 26)
        lblAddress.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Dock = DockStyle.Fill
        Label6.Font = New Font("Poppins", 12F)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(42, 0)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(349, 26)
        Label6.TabIndex = 6
        Label6.Text = "Address:"
        Label6.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Dock = DockStyle.Fill
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(2, 2)
        PictureBox4.Margin = New Padding(2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(36, 22)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 35
        PictureBox4.TabStop = False
        ' 
        ' TableLayoutPanel9
        ' 
        TableLayoutPanel9.ColumnCount = 2
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 40F))
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel9.Controls.Add(Label7, 1, 0)
        TableLayoutPanel9.Controls.Add(PictureBox3, 0, 0)
        TableLayoutPanel9.Dock = DockStyle.Fill
        TableLayoutPanel9.Location = New Point(2, 2)
        TableLayoutPanel9.Margin = New Padding(2)
        TableLayoutPanel9.Name = "TableLayoutPanel9"
        TableLayoutPanel9.RowCount = 1
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel9.Size = New Size(393, 26)
        TableLayoutPanel9.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Dock = DockStyle.Fill
        Label7.Font = New Font("Poppins", 12F)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(42, 0)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(349, 26)
        Label7.TabIndex = 6
        Label7.Text = "Contact Number:"
        Label7.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Dock = DockStyle.Fill
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(2, 2)
        PictureBox3.Margin = New Padding(2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(36, 22)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 34
        PictureBox3.TabStop = False
        ' 
        ' TableLayoutPanel11
        ' 
        TableLayoutPanel11.ColumnCount = 2
        TableLayoutPanel11.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 40F))
        TableLayoutPanel11.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel11.Controls.Add(Label9, 1, 0)
        TableLayoutPanel11.Controls.Add(PictureBox5, 0, 0)
        TableLayoutPanel11.Dock = DockStyle.Fill
        TableLayoutPanel11.Location = New Point(2, 2)
        TableLayoutPanel11.Margin = New Padding(2)
        TableLayoutPanel11.Name = "TableLayoutPanel11"
        TableLayoutPanel11.RowCount = 1
        TableLayoutPanel11.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel11.Size = New Size(393, 26)
        TableLayoutPanel11.TabIndex = 16
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Dock = DockStyle.Fill
        Label9.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(42, 0)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(349, 26)
        Label9.TabIndex = 6
        Label9.Text = "Status:"
        Label9.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Dock = DockStyle.Fill
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(2, 2)
        PictureBox5.Margin = New Padding(2)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(36, 22)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 36
        PictureBox5.TabStop = False
        ' 
        ' cbStatus
        ' 
        cbStatus.Dock = DockStyle.Fill
        cbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cbStatus.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbStatus.FormattingEnabled = True
        cbStatus.Location = New Point(2, 32)
        cbStatus.Margin = New Padding(2)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(393, 30)
        cbStatus.TabIndex = 34
        ' 
        ' TableLayoutPanel15
        ' 
        TableLayoutPanel15.ColumnCount = 2
        TableLayoutPanel15.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 40F))
        TableLayoutPanel15.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel15.Controls.Add(PictureBox9, 0, 0)
        TableLayoutPanel15.Controls.Add(Label13, 1, 0)
        TableLayoutPanel15.Dock = DockStyle.Fill
        TableLayoutPanel15.Location = New Point(399, 2)
        TableLayoutPanel15.Margin = New Padding(2)
        TableLayoutPanel15.Name = "TableLayoutPanel15"
        TableLayoutPanel15.RowCount = 1
        TableLayoutPanel15.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel15.Size = New Size(393, 26)
        TableLayoutPanel15.TabIndex = 20
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Dock = DockStyle.Fill
        PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), Image)
        PictureBox9.Location = New Point(2, 2)
        PictureBox9.Margin = New Padding(2)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(36, 22)
        PictureBox9.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox9.TabIndex = 40
        PictureBox9.TabStop = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Dock = DockStyle.Fill
        Label13.Font = New Font("Poppins", 12F)
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(42, 0)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(349, 26)
        Label13.TabIndex = 6
        Label13.Text = "Amount Received:"
        Label13.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' TableLayoutPanel16
        ' 
        TableLayoutPanel16.ColumnCount = 2
        TableLayoutPanel16.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 40F))
        TableLayoutPanel16.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel16.Controls.Add(PictureBox10, 0, 0)
        TableLayoutPanel16.Controls.Add(Label14, 1, 0)
        TableLayoutPanel16.Dock = DockStyle.Fill
        TableLayoutPanel16.Location = New Point(399, 2)
        TableLayoutPanel16.Margin = New Padding(2)
        TableLayoutPanel16.Name = "TableLayoutPanel16"
        TableLayoutPanel16.RowCount = 1
        TableLayoutPanel16.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel16.Size = New Size(393, 26)
        TableLayoutPanel16.TabIndex = 21
        ' 
        ' PictureBox10
        ' 
        PictureBox10.Dock = DockStyle.Fill
        PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), Image)
        PictureBox10.Location = New Point(2, 2)
        PictureBox10.Margin = New Padding(2)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(36, 22)
        PictureBox10.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox10.TabIndex = 39
        PictureBox10.TabStop = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Dock = DockStyle.Fill
        Label14.Font = New Font("Poppins", 12F)
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(42, 0)
        Label14.Margin = New Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(349, 26)
        Label14.TabIndex = 6
        Label14.Text = "Change:"
        Label14.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' TableLayoutPanel17
        ' 
        TableLayoutPanel17.ColumnCount = 2
        TableLayoutPanel17.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel17.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel17.Controls.Add(cbService, 0, 1)
        TableLayoutPanel17.Controls.Add(tbPaymentMethod, 1, 1)
        TableLayoutPanel17.Controls.Add(TableLayoutPanel21, 0, 0)
        TableLayoutPanel17.Controls.Add(TableLayoutPanel19, 1, 0)
        TableLayoutPanel17.Dock = DockStyle.Fill
        TableLayoutPanel17.Location = New Point(0, 0)
        TableLayoutPanel17.Margin = New Padding(2)
        TableLayoutPanel17.Name = "TableLayoutPanel17"
        TableLayoutPanel17.RowCount = 2
        TableLayoutPanel17.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel17.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel17.Size = New Size(794, 61)
        TableLayoutPanel17.TabIndex = 25
        ' 
        ' cbService
        ' 
        cbService.Dock = DockStyle.Fill
        cbService.DropDownStyle = ComboBoxStyle.DropDownList
        cbService.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbService.FormattingEnabled = True
        cbService.Location = New Point(2, 32)
        cbService.Margin = New Padding(2)
        cbService.Name = "cbService"
        cbService.Size = New Size(393, 31)
        cbService.TabIndex = 33
        ' 
        ' tbPaymentMethod
        ' 
        tbPaymentMethod.BackColor = Color.LightGray
        tbPaymentMethod.Dock = DockStyle.Fill
        tbPaymentMethod.Font = New Font("Poppins", 12F)
        tbPaymentMethod.Location = New Point(399, 32)
        tbPaymentMethod.Margin = New Padding(2)
        tbPaymentMethod.Name = "tbPaymentMethod"
        tbPaymentMethod.Size = New Size(393, 31)
        tbPaymentMethod.TabIndex = 35
        ' 
        ' TableLayoutPanel21
        ' 
        TableLayoutPanel21.ColumnCount = 2
        TableLayoutPanel21.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 40F))
        TableLayoutPanel21.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel21.Controls.Add(PictureBox2, 0, 0)
        TableLayoutPanel21.Controls.Add(Label22, 1, 0)
        TableLayoutPanel21.Dock = DockStyle.Fill
        TableLayoutPanel21.Location = New Point(2, 2)
        TableLayoutPanel21.Margin = New Padding(2)
        TableLayoutPanel21.Name = "TableLayoutPanel21"
        TableLayoutPanel21.RowCount = 1
        TableLayoutPanel21.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel21.Size = New Size(393, 26)
        TableLayoutPanel21.TabIndex = 28
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(2, 2)
        PictureBox2.Margin = New Padding(2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(36, 22)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 33
        PictureBox2.TabStop = False
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Dock = DockStyle.Fill
        Label22.Font = New Font("Poppins", 12F)
        Label22.ForeColor = Color.Black
        Label22.Location = New Point(42, 0)
        Label22.Margin = New Padding(2, 0, 2, 0)
        Label22.Name = "Label22"
        Label22.Size = New Size(349, 26)
        Label22.TabIndex = 6
        Label22.Text = "Service Type:"
        Label22.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' TableLayoutPanel19
        ' 
        TableLayoutPanel19.ColumnCount = 2
        TableLayoutPanel19.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 40F))
        TableLayoutPanel19.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel19.Controls.Add(Label18, 1, 0)
        TableLayoutPanel19.Controls.Add(PictureBox7, 0, 0)
        TableLayoutPanel19.Dock = DockStyle.Fill
        TableLayoutPanel19.Location = New Point(399, 2)
        TableLayoutPanel19.Margin = New Padding(2)
        TableLayoutPanel19.Name = "TableLayoutPanel19"
        TableLayoutPanel19.RowCount = 1
        TableLayoutPanel19.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel19.Size = New Size(393, 26)
        TableLayoutPanel19.TabIndex = 18
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Dock = DockStyle.Fill
        Label18.Font = New Font("Poppins", 12F)
        Label18.ForeColor = Color.Black
        Label18.Location = New Point(42, 0)
        Label18.Margin = New Padding(2, 0, 2, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(349, 26)
        Label18.TabIndex = 6
        Label18.Text = "Payment Method:"
        Label18.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Dock = DockStyle.Fill
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(2, 2)
        PictureBox7.Margin = New Padding(2)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(36, 22)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 38
        PictureBox7.TabStop = False
        ' 
        ' TableLayoutPanel20
        ' 
        TableLayoutPanel20.ColumnCount = 2
        TableLayoutPanel20.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel20.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel20.Controls.Add(tbTotal, 1, 1)
        TableLayoutPanel20.Controls.Add(TableLayoutPanel23, 1, 0)
        TableLayoutPanel20.Controls.Add(TableLayoutPanel9, 0, 0)
        TableLayoutPanel20.Controls.Add(tbContactNum, 0, 1)
        TableLayoutPanel20.Dock = DockStyle.Fill
        TableLayoutPanel20.Location = New Point(0, 0)
        TableLayoutPanel20.Margin = New Padding(2)
        TableLayoutPanel20.Name = "TableLayoutPanel20"
        TableLayoutPanel20.RowCount = 2
        TableLayoutPanel20.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel20.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel20.Size = New Size(794, 61)
        TableLayoutPanel20.TabIndex = 26
        ' 
        ' tbTotal
        ' 
        tbTotal.BackColor = Color.LightGray
        tbTotal.Dock = DockStyle.Fill
        tbTotal.Font = New Font("Poppins", 12F)
        tbTotal.Location = New Point(399, 32)
        tbTotal.Margin = New Padding(2)
        tbTotal.Name = "tbTotal"
        tbTotal.Size = New Size(393, 31)
        tbTotal.TabIndex = 35
        ' 
        ' TableLayoutPanel23
        ' 
        TableLayoutPanel23.ColumnCount = 2
        TableLayoutPanel23.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 40F))
        TableLayoutPanel23.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel23.Controls.Add(Label23, 1, 0)
        TableLayoutPanel23.Controls.Add(PictureBox8, 0, 0)
        TableLayoutPanel23.Dock = DockStyle.Fill
        TableLayoutPanel23.Location = New Point(399, 2)
        TableLayoutPanel23.Margin = New Padding(2)
        TableLayoutPanel23.Name = "TableLayoutPanel23"
        TableLayoutPanel23.RowCount = 1
        TableLayoutPanel23.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel23.Size = New Size(393, 26)
        TableLayoutPanel23.TabIndex = 30
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Dock = DockStyle.Fill
        Label23.Font = New Font("Poppins", 12F)
        Label23.ForeColor = Color.Black
        Label23.Location = New Point(42, 0)
        Label23.Margin = New Padding(2, 0, 2, 0)
        Label23.Name = "Label23"
        Label23.Size = New Size(349, 26)
        Label23.TabIndex = 6
        Label23.Text = "Total"
        Label23.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Dock = DockStyle.Fill
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(2, 2)
        PictureBox8.Margin = New Padding(2)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(36, 22)
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox8.TabIndex = 39
        PictureBox8.TabStop = False
        ' 
        ' tbContactNum
        ' 
        tbContactNum.BackColor = Color.LightGray
        tbContactNum.Dock = DockStyle.Fill
        tbContactNum.Font = New Font("Poppins", 12F)
        tbContactNum.Location = New Point(2, 32)
        tbContactNum.Margin = New Padding(2)
        tbContactNum.Name = "tbContactNum"
        tbContactNum.Size = New Size(393, 31)
        tbContactNum.TabIndex = 34
        ' 
        ' TableLayoutPanel22
        ' 
        TableLayoutPanel22.ColumnCount = 2
        TableLayoutPanel22.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel22.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel22.Controls.Add(tbAmountReceived, 1, 1)
        TableLayoutPanel22.Controls.Add(tbAddress, 0, 1)
        TableLayoutPanel22.Controls.Add(lblAddress, 0, 0)
        TableLayoutPanel22.Controls.Add(TableLayoutPanel15, 1, 0)
        TableLayoutPanel22.Dock = DockStyle.Fill
        TableLayoutPanel22.Location = New Point(0, 0)
        TableLayoutPanel22.Margin = New Padding(2)
        TableLayoutPanel22.Name = "TableLayoutPanel22"
        TableLayoutPanel22.RowCount = 2
        TableLayoutPanel22.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel22.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel22.Size = New Size(794, 61)
        TableLayoutPanel22.TabIndex = 28
        ' 
        ' tbAmountReceived
        ' 
        tbAmountReceived.BackColor = Color.LightGray
        tbAmountReceived.Dock = DockStyle.Fill
        tbAmountReceived.Font = New Font("Poppins", 12F)
        tbAmountReceived.Location = New Point(399, 32)
        tbAmountReceived.Margin = New Padding(2)
        tbAmountReceived.Name = "tbAmountReceived"
        tbAmountReceived.Size = New Size(393, 31)
        tbAmountReceived.TabIndex = 36
        ' 
        ' tbAddress
        ' 
        tbAddress.BackColor = Color.LightGray
        tbAddress.Dock = DockStyle.Fill
        tbAddress.Font = New Font("Poppins", 12F)
        tbAddress.Location = New Point(2, 32)
        tbAddress.Margin = New Padding(2)
        tbAddress.Name = "tbAddress"
        tbAddress.Size = New Size(393, 31)
        tbAddress.TabIndex = 35
        ' 
        ' TableLayoutPanel24
        ' 
        TableLayoutPanel24.ColumnCount = 2
        TableLayoutPanel24.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel24.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel24.Controls.Add(cbStatus, 0, 1)
        TableLayoutPanel24.Controls.Add(tbChange, 1, 1)
        TableLayoutPanel24.Controls.Add(TableLayoutPanel16, 1, 0)
        TableLayoutPanel24.Controls.Add(TableLayoutPanel11, 0, 0)
        TableLayoutPanel24.Dock = DockStyle.Fill
        TableLayoutPanel24.Location = New Point(0, 0)
        TableLayoutPanel24.Margin = New Padding(2)
        TableLayoutPanel24.Name = "TableLayoutPanel24"
        TableLayoutPanel24.RowCount = 2
        TableLayoutPanel24.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel24.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel24.Size = New Size(794, 61)
        TableLayoutPanel24.TabIndex = 30
        ' 
        ' tbChange
        ' 
        tbChange.BackColor = Color.LightGray
        tbChange.Dock = DockStyle.Fill
        tbChange.Font = New Font("Poppins", 12F)
        tbChange.Location = New Point(399, 32)
        tbChange.Margin = New Padding(2)
        tbChange.Name = "tbChange"
        tbChange.Size = New Size(393, 31)
        tbChange.TabIndex = 36
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.Left
        btnSave.BorderRadius = 5
        btnSave.CustomizableEdges = CustomizableEdges1
        btnSave.DisabledState.BorderColor = Color.DarkGray
        btnSave.DisabledState.CustomBorderColor = Color.DarkGray
        btnSave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSave.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSave.FillColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        btnSave.FillColor2 = Color.FromArgb(CByte(76), CByte(102), CByte(232))
        btnSave.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(402, 476)
        btnSave.Margin = New Padding(2)
        btnSave.Name = "btnSave"
        btnSave.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnSave.Size = New Size(100, 35)
        btnSave.TabIndex = 34
        btnSave.Text = "SAVE"
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.ColumnCount = 2
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.Controls.Add(btnCancel, 0, 7)
        TableLayoutPanel8.Controls.Add(Guna2GradientPanel1, 0, 0)
        TableLayoutPanel8.Controls.Add(btnSave, 1, 7)
        TableLayoutPanel8.Controls.Add(Panel5, 0, 1)
        TableLayoutPanel8.Controls.Add(Panel6, 1, 1)
        TableLayoutPanel8.Controls.Add(Panel7, 0, 2)
        TableLayoutPanel8.Controls.Add(Panel8, 0, 3)
        TableLayoutPanel8.Controls.Add(Panel10, 0, 4)
        TableLayoutPanel8.Controls.Add(Panel11, 0, 5)
        TableLayoutPanel8.Controls.Add(Panel12, 0, 6)
        TableLayoutPanel8.Location = New Point(0, 0)
        TableLayoutPanel8.Margin = New Padding(0)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.RowCount = 8
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857113F))
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857151F))
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857151F))
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857151F))
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857151F))
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857151F))
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857151F))
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel8.Size = New Size(800, 519)
        TableLayoutPanel8.TabIndex = 35
        ' 
        ' btnCancel
        ' 
        btnCancel.Anchor = AnchorStyles.Right
        btnCancel.BorderRadius = 5
        btnCancel.CustomizableEdges = CustomizableEdges3
        btnCancel.DisabledState.BorderColor = Color.DarkGray
        btnCancel.DisabledState.CustomBorderColor = Color.DarkGray
        btnCancel.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnCancel.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnCancel.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnCancel.FillColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        btnCancel.FillColor2 = Color.FromArgb(CByte(76), CByte(102), CByte(232))
        btnCancel.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(298, 476)
        btnCancel.Margin = New Padding(2)
        btnCancel.Name = "btnCancel"
        btnCancel.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnCancel.Size = New Size(100, 35)
        btnCancel.TabIndex = 36
        btnCancel.Text = "CANCEL"
        ' 
        ' Guna2GradientPanel1
        ' 
        TableLayoutPanel8.SetColumnSpan(Guna2GradientPanel1, 2)
        Guna2GradientPanel1.Controls.Add(Label2)
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges5
        Guna2GradientPanel1.Dock = DockStyle.Fill
        Guna2GradientPanel1.FillColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        Guna2GradientPanel1.FillColor2 = Color.FromArgb(CByte(76), CByte(102), CByte(232))
        Guna2GradientPanel1.GradientMode = Drawing2D.LinearGradientMode.Vertical
        Guna2GradientPanel1.Location = New Point(3, 3)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2GradientPanel1.Size = New Size(794, 60)
        Guna2GradientPanel1.TabIndex = 35
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Poppins", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(0, 0)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(794, 60)
        Label2.TabIndex = 6
        Label2.Text = "TRANSACTION FORM"
        Label2.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(TableLayoutPanel2)
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(3, 69)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(394, 61)
        Panel5.TabIndex = 2
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(TableLayoutPanel3)
        Panel6.Dock = DockStyle.Fill
        Panel6.Location = New Point(403, 69)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(394, 61)
        Panel6.TabIndex = 3
        ' 
        ' Panel7
        ' 
        TableLayoutPanel8.SetColumnSpan(Panel7, 2)
        Panel7.Controls.Add(TableLayoutPanel1)
        Panel7.Dock = DockStyle.Fill
        Panel7.Location = New Point(3, 136)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(794, 61)
        Panel7.TabIndex = 4
        ' 
        ' Panel8
        ' 
        TableLayoutPanel8.SetColumnSpan(Panel8, 2)
        Panel8.Controls.Add(TableLayoutPanel17)
        Panel8.Dock = DockStyle.Fill
        Panel8.Location = New Point(3, 203)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(794, 61)
        Panel8.TabIndex = 5
        ' 
        ' Panel10
        ' 
        TableLayoutPanel8.SetColumnSpan(Panel10, 2)
        Panel10.Controls.Add(TableLayoutPanel20)
        Panel10.Dock = DockStyle.Fill
        Panel10.Location = New Point(3, 270)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(794, 61)
        Panel10.TabIndex = 7
        ' 
        ' Panel11
        ' 
        TableLayoutPanel8.SetColumnSpan(Panel11, 2)
        Panel11.Controls.Add(TableLayoutPanel22)
        Panel11.Dock = DockStyle.Fill
        Panel11.Location = New Point(3, 337)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(794, 61)
        Panel11.TabIndex = 8
        ' 
        ' Panel12
        ' 
        TableLayoutPanel8.SetColumnSpan(Panel12, 2)
        Panel12.Controls.Add(TableLayoutPanel24)
        Panel12.Dock = DockStyle.Fill
        Panel12.Location = New Point(3, 404)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(794, 61)
        Panel12.TabIndex = 9
        ' 
        ' TransactionForm
        ' 
        AcceptButton = btnSave
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(800, 520)
        Controls.Add(TableLayoutPanel8)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2)
        MinimumSize = New Size(800, 500)
        Name = "TransactionForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Transaction Form"
        TopMost = True
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel12.ResumeLayout(False)
        TableLayoutPanel12.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel7.ResumeLayout(False)
        TableLayoutPanel7.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        lblAddress.ResumeLayout(False)
        lblAddress.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel9.ResumeLayout(False)
        TableLayoutPanel9.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel11.ResumeLayout(False)
        TableLayoutPanel11.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel15.ResumeLayout(False)
        TableLayoutPanel15.PerformLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel16.ResumeLayout(False)
        TableLayoutPanel16.PerformLayout()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel17.ResumeLayout(False)
        TableLayoutPanel17.PerformLayout()
        TableLayoutPanel21.ResumeLayout(False)
        TableLayoutPanel21.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel19.ResumeLayout(False)
        TableLayoutPanel19.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel20.ResumeLayout(False)
        TableLayoutPanel20.PerformLayout()
        TableLayoutPanel23.ResumeLayout(False)
        TableLayoutPanel23.PerformLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel22.ResumeLayout(False)
        TableLayoutPanel22.PerformLayout()
        TableLayoutPanel24.ResumeLayout(False)
        TableLayoutPanel24.PerformLayout()
        TableLayoutPanel8.ResumeLayout(False)
        Guna2GradientPanel1.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel10.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        Panel12.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMode As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents lblAddress As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents TableLayoutPanel15 As TableLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents TableLayoutPanel16 As TableLayoutPanel
    Friend WithEvents Label14 As Label
    Friend WithEvents TableLayoutPanel17 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel19 As TableLayoutPanel
    Friend WithEvents Label18 As Label
    Friend WithEvents TableLayoutPanel20 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel21 As TableLayoutPanel
    Friend WithEvents Label22 As Label
    Friend WithEvents TableLayoutPanel22 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel23 As TableLayoutPanel
    Friend WithEvents Label23 As Label
    Friend WithEvents TableLayoutPanel24 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents tbCustomerName As TextBox
    Friend WithEvents tbContactNum As TextBox
    Friend WithEvents tbMachineUsed As TextBox
    Friend WithEvents tbPaymentMethod As TextBox
    Friend WithEvents cbService As ComboBox
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents tbAmountReceived As TextBox
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents tbChange As TextBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2GradientButton
End Class

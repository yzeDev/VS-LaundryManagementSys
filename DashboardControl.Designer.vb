<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Panel1 = New Panel()
        TableLayoutPanel6 = New TableLayoutPanel()
        Button1 = New Button()
        Panel2 = New Panel()
        TableLayoutPanel7 = New TableLayoutPanel()
        TableLayoutPanel8 = New TableLayoutPanel()
        Label5 = New Label()
        TableLayoutPanel9 = New TableLayoutPanel()
        Panel8 = New Panel()
        lblAvailableValue = New Label()
        lblAvailableText = New Label()
        Panel9 = New Panel()
        lblInUseValue = New Label()
        lblInUseText = New Label()
        Panel10 = New Panel()
        lblBrokenValue = New Label()
        lblBrokenText = New Label()
        TableLayoutPanel10 = New TableLayoutPanel()
        Label6 = New Label()
        DataGridView1 = New DataGridView()
        Panel3 = New Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        lblPendingOrderText = New Label()
        PictureBox1 = New PictureBox()
        lblPendingOrdersValue = New Label()
        Panel4 = New Panel()
        TableLayoutPanel3 = New TableLayoutPanel()
        lblInProgressText = New Label()
        PictureBox2 = New PictureBox()
        lblInProgressValue = New Label()
        Panel5 = New Panel()
        TableLayoutPanel4 = New TableLayoutPanel()
        lblOutForDeliveryText = New Label()
        PictureBox3 = New PictureBox()
        lblOutForDeliveryValue = New Label()
        Panel6 = New Panel()
        TableLayoutPanel5 = New TableLayoutPanel()
        lblCompletedText = New Label()
        PictureBox4 = New PictureBox()
        lblCompletedValue = New Label()
        Panel7 = New Panel()
        Label7 = New Label()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        Panel2.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        TableLayoutPanel8.SuspendLayout()
        TableLayoutPanel9.SuspendLayout()
        Panel8.SuspendLayout()
        Panel9.SuspendLayout()
        Panel10.SuspendLayout()
        TableLayoutPanel10.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.ColumnCount = 5
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.Controls.Add(Panel1, 4, 1)
        TableLayoutPanel1.Controls.Add(Panel2, 0, 2)
        TableLayoutPanel1.Controls.Add(Panel3, 0, 1)
        TableLayoutPanel1.Controls.Add(Panel4, 1, 1)
        TableLayoutPanel1.Controls.Add(Panel5, 2, 1)
        TableLayoutPanel1.Controls.Add(Panel6, 3, 1)
        TableLayoutPanel1.Controls.Add(Panel7, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 70F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 30F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 70F))
        TableLayoutPanel1.Size = New Size(1100, 500)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TableLayoutPanel6)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(883, 73)
        Panel1.Name = "Panel1"
        TableLayoutPanel1.SetRowSpan(Panel1, 2)
        Panel1.Size = New Size(214, 424)
        Panel1.TabIndex = 0
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.ColumnCount = 1
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel6.Controls.Add(Button1, 0, 3)
        TableLayoutPanel6.Dock = DockStyle.Fill
        TableLayoutPanel6.Location = New Point(0, 0)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 4
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel6.Size = New Size(214, 424)
        TableLayoutPanel6.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Dock = DockStyle.Fill
        Button1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(3, 321)
        Button1.Name = "Button1"
        Button1.Size = New Size(208, 100)
        Button1.TabIndex = 0
        Button1.Text = "ADD ORDER" & vbCrLf & "(+)" & vbCrLf
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        TableLayoutPanel1.SetColumnSpan(Panel2, 4)
        Panel2.Controls.Add(TableLayoutPanel7)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(3, 202)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(874, 295)
        Panel2.TabIndex = 1
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.ColumnCount = 1
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel7.Controls.Add(TableLayoutPanel8, 0, 0)
        TableLayoutPanel7.Controls.Add(TableLayoutPanel10, 0, 1)
        TableLayoutPanel7.Dock = DockStyle.Fill
        TableLayoutPanel7.Location = New Point(0, 0)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 2
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.Size = New Size(874, 295)
        TableLayoutPanel7.TabIndex = 0
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.ColumnCount = 1
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel8.Controls.Add(Label5, 0, 0)
        TableLayoutPanel8.Controls.Add(TableLayoutPanel9, 0, 1)
        TableLayoutPanel8.Dock = DockStyle.Fill
        TableLayoutPanel8.Location = New Point(3, 3)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.RowCount = 2
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel8.RowStyles.Add(New RowStyle())
        TableLayoutPanel8.Size = New Size(868, 141)
        TableLayoutPanel8.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Dock = DockStyle.Fill
        Label5.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(862, 50)
        Label5.TabIndex = 0
        Label5.Text = "MACHINES"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel9
        ' 
        TableLayoutPanel9.ColumnCount = 3
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel9.Controls.Add(Panel8, 0, 0)
        TableLayoutPanel9.Controls.Add(Panel9, 1, 0)
        TableLayoutPanel9.Controls.Add(Panel10, 2, 0)
        TableLayoutPanel9.Dock = DockStyle.Fill
        TableLayoutPanel9.Location = New Point(3, 53)
        TableLayoutPanel9.Name = "TableLayoutPanel9"
        TableLayoutPanel9.RowCount = 1
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel9.Size = New Size(862, 110)
        TableLayoutPanel9.TabIndex = 1
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(lblAvailableValue)
        Panel8.Controls.Add(lblAvailableText)
        Panel8.Dock = DockStyle.Fill
        Panel8.Location = New Point(3, 3)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(281, 104)
        Panel8.TabIndex = 0
        ' 
        ' lblAvailableValue
        ' 
        lblAvailableValue.Dock = DockStyle.Top
        lblAvailableValue.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        lblAvailableValue.Location = New Point(0, 23)
        lblAvailableValue.Name = "lblAvailableValue"
        lblAvailableValue.Size = New Size(281, 47)
        lblAvailableValue.TabIndex = 1
        lblAvailableValue.Text = "0"
        lblAvailableValue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblAvailableText
        ' 
        lblAvailableText.Dock = DockStyle.Top
        lblAvailableText.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblAvailableText.Location = New Point(0, 0)
        lblAvailableText.Name = "lblAvailableText"
        lblAvailableText.Size = New Size(281, 23)
        lblAvailableText.TabIndex = 0
        lblAvailableText.Text = "AVAILABLE"
        lblAvailableText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(lblInUseValue)
        Panel9.Controls.Add(lblInUseText)
        Panel9.Dock = DockStyle.Fill
        Panel9.Location = New Point(290, 3)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(281, 104)
        Panel9.TabIndex = 1
        ' 
        ' lblInUseValue
        ' 
        lblInUseValue.Dock = DockStyle.Top
        lblInUseValue.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        lblInUseValue.Location = New Point(0, 23)
        lblInUseValue.Name = "lblInUseValue"
        lblInUseValue.Size = New Size(281, 39)
        lblInUseValue.TabIndex = 1
        lblInUseValue.Text = "0"
        lblInUseValue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblInUseText
        ' 
        lblInUseText.Dock = DockStyle.Top
        lblInUseText.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblInUseText.Location = New Point(0, 0)
        lblInUseText.Name = "lblInUseText"
        lblInUseText.Size = New Size(281, 23)
        lblInUseText.TabIndex = 0
        lblInUseText.Text = "IN-USE"
        lblInUseText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel10
        ' 
        Panel10.Controls.Add(lblBrokenValue)
        Panel10.Controls.Add(lblBrokenText)
        Panel10.Dock = DockStyle.Fill
        Panel10.Location = New Point(577, 3)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(282, 104)
        Panel10.TabIndex = 2
        ' 
        ' lblBrokenValue
        ' 
        lblBrokenValue.Dock = DockStyle.Top
        lblBrokenValue.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        lblBrokenValue.Location = New Point(0, 23)
        lblBrokenValue.Name = "lblBrokenValue"
        lblBrokenValue.Size = New Size(282, 39)
        lblBrokenValue.TabIndex = 1
        lblBrokenValue.Text = "0"
        lblBrokenValue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblBrokenText
        ' 
        lblBrokenText.Dock = DockStyle.Top
        lblBrokenText.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblBrokenText.Location = New Point(0, 0)
        lblBrokenText.Name = "lblBrokenText"
        lblBrokenText.Size = New Size(282, 23)
        lblBrokenText.TabIndex = 0
        lblBrokenText.Text = "BROKEN"
        lblBrokenText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel10
        ' 
        TableLayoutPanel10.ColumnCount = 1
        TableLayoutPanel10.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel10.Controls.Add(Label6, 0, 0)
        TableLayoutPanel10.Controls.Add(DataGridView1, 0, 1)
        TableLayoutPanel10.Dock = DockStyle.Fill
        TableLayoutPanel10.Location = New Point(3, 150)
        TableLayoutPanel10.Name = "TableLayoutPanel10"
        TableLayoutPanel10.RowCount = 2
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel10.RowStyles.Add(New RowStyle())
        TableLayoutPanel10.Size = New Size(868, 142)
        TableLayoutPanel10.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Dock = DockStyle.Fill
        Label6.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(3, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(862, 50)
        Label6.TabIndex = 0
        Label6.Text = "FOR PICK UP"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(3, 53)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(862, 150)
        DataGridView1.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(TableLayoutPanel2)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(3, 73)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(214, 123)
        Panel3.TabIndex = 2
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.AutoSize = True
        TableLayoutPanel2.BackColor = Color.FromArgb(CByte(98), CByte(142), CByte(203))
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(lblPendingOrderText, 0, 0)
        TableLayoutPanel2.Controls.Add(PictureBox1, 1, 1)
        TableLayoutPanel2.Controls.Add(lblPendingOrdersValue, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 27.7406521F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 72.259346F))
        TableLayoutPanel2.Size = New Size(214, 123)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' lblPendingOrderText
        ' 
        lblPendingOrderText.AutoSize = True
        TableLayoutPanel2.SetColumnSpan(lblPendingOrderText, 2)
        lblPendingOrderText.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblPendingOrderText.Location = New Point(3, 0)
        lblPendingOrderText.Name = "lblPendingOrderText"
        lblPendingOrderText.Size = New Size(123, 21)
        lblPendingOrderText.TabIndex = 0
        lblPendingOrderText.Text = "Pending Orders"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources._81
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(110, 37)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(101, 83)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' lblPendingOrdersValue
        ' 
        lblPendingOrdersValue.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblPendingOrdersValue.AutoSize = True
        lblPendingOrdersValue.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        lblPendingOrdersValue.Location = New Point(3, 34)
        lblPendingOrdersValue.Name = "lblPendingOrdersValue"
        lblPendingOrdersValue.Size = New Size(101, 89)
        lblPendingOrdersValue.TabIndex = 2
        lblPendingOrdersValue.Text = "0"
        lblPendingOrdersValue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(TableLayoutPanel3)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(223, 73)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(214, 123)
        Panel4.TabIndex = 3
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.AutoSize = True
        TableLayoutPanel3.BackColor = Color.FromArgb(CByte(98), CByte(142), CByte(203))
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(lblInProgressText, 0, 0)
        TableLayoutPanel3.Controls.Add(PictureBox2, 1, 1)
        TableLayoutPanel3.Controls.Add(lblInProgressValue, 0, 1)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 30.5583115F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 69.44168F))
        TableLayoutPanel3.Size = New Size(214, 123)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' lblInProgressText
        ' 
        lblInProgressText.AutoSize = True
        TableLayoutPanel3.SetColumnSpan(lblInProgressText, 2)
        lblInProgressText.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblInProgressText.Location = New Point(3, 0)
        lblInProgressText.Name = "lblInProgressText"
        lblInProgressText.Size = New Size(94, 21)
        lblInProgressText.TabIndex = 0
        lblInProgressText.Text = "In-Progress"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources._91
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Location = New Point(110, 40)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(101, 80)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' lblInProgressValue
        ' 
        lblInProgressValue.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblInProgressValue.AutoSize = True
        lblInProgressValue.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        lblInProgressValue.Location = New Point(3, 37)
        lblInProgressValue.Name = "lblInProgressValue"
        lblInProgressValue.Size = New Size(101, 86)
        lblInProgressValue.TabIndex = 2
        lblInProgressValue.Text = "0"
        lblInProgressValue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(TableLayoutPanel4)
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(443, 73)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(214, 123)
        Panel5.TabIndex = 4
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.AutoSize = True
        TableLayoutPanel4.BackColor = Color.FromArgb(CByte(98), CByte(142), CByte(203))
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(lblOutForDeliveryText, 0, 0)
        TableLayoutPanel4.Controls.Add(PictureBox3, 1, 1)
        TableLayoutPanel4.Controls.Add(lblOutForDeliveryValue, 0, 1)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(0, 0)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 28.977272F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 71.02273F))
        TableLayoutPanel4.Size = New Size(214, 123)
        TableLayoutPanel4.TabIndex = 0
        ' 
        ' lblOutForDeliveryText
        ' 
        lblOutForDeliveryText.AutoSize = True
        TableLayoutPanel4.SetColumnSpan(lblOutForDeliveryText, 2)
        lblOutForDeliveryText.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblOutForDeliveryText.Location = New Point(3, 0)
        lblOutForDeliveryText.Name = "lblOutForDeliveryText"
        lblOutForDeliveryText.Size = New Size(127, 21)
        lblOutForDeliveryText.TabIndex = 0
        lblOutForDeliveryText.Text = "Out for Delivery"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = My.Resources.Resources._101
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Dock = DockStyle.Fill
        PictureBox3.Location = New Point(110, 38)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(101, 82)
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
        ' 
        ' lblOutForDeliveryValue
        ' 
        lblOutForDeliveryValue.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblOutForDeliveryValue.AutoSize = True
        lblOutForDeliveryValue.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        lblOutForDeliveryValue.Location = New Point(3, 35)
        lblOutForDeliveryValue.Name = "lblOutForDeliveryValue"
        lblOutForDeliveryValue.Size = New Size(101, 88)
        lblOutForDeliveryValue.TabIndex = 2
        lblOutForDeliveryValue.Text = "0"
        lblOutForDeliveryValue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(TableLayoutPanel5)
        Panel6.Dock = DockStyle.Fill
        Panel6.Location = New Point(663, 73)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(214, 123)
        Panel6.TabIndex = 5
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.AutoSize = True
        TableLayoutPanel5.BackColor = Color.FromArgb(CByte(98), CByte(142), CByte(203))
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Controls.Add(lblCompletedText, 0, 0)
        TableLayoutPanel5.Controls.Add(PictureBox4, 1, 1)
        TableLayoutPanel5.Controls.Add(lblCompletedValue, 0, 1)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Location = New Point(0, 0)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 2
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 28.977272F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 71.02273F))
        TableLayoutPanel5.Size = New Size(214, 123)
        TableLayoutPanel5.TabIndex = 0
        ' 
        ' lblCompletedText
        ' 
        lblCompletedText.AutoSize = True
        TableLayoutPanel5.SetColumnSpan(lblCompletedText, 2)
        lblCompletedText.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblCompletedText.Location = New Point(3, 0)
        lblCompletedText.Name = "lblCompletedText"
        lblCompletedText.Size = New Size(92, 21)
        lblCompletedText.TabIndex = 0
        lblCompletedText.Text = "Completed"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = My.Resources.Resources._111
        PictureBox4.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox4.Dock = DockStyle.Fill
        PictureBox4.Location = New Point(110, 38)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(101, 82)
        PictureBox4.TabIndex = 1
        PictureBox4.TabStop = False
        ' 
        ' lblCompletedValue
        ' 
        lblCompletedValue.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblCompletedValue.AutoSize = True
        lblCompletedValue.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        lblCompletedValue.Location = New Point(3, 35)
        lblCompletedValue.Name = "lblCompletedValue"
        lblCompletedValue.Size = New Size(101, 88)
        lblCompletedValue.TabIndex = 2
        lblCompletedValue.Text = "0"
        lblCompletedValue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel7
        ' 
        TableLayoutPanel1.SetColumnSpan(Panel7, 5)
        Panel7.Controls.Add(Label7)
        Panel7.Dock = DockStyle.Fill
        Panel7.Location = New Point(3, 3)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(1094, 64)
        Panel7.TabIndex = 6
        ' 
        ' Label7
        ' 
        Label7.Dock = DockStyle.Fill
        Label7.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ImageAlign = ContentAlignment.MiddleLeft
        Label7.Location = New Point(0, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(1094, 64)
        Label7.TabIndex = 0
        Label7.Text = "WELCOME BACK, ADMIN!"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' DashboardControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(10)
        Name = "DashboardControl"
        Size = New Size(1100, 500)
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        TableLayoutPanel6.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        TableLayoutPanel7.ResumeLayout(False)
        TableLayoutPanel8.ResumeLayout(False)
        TableLayoutPanel8.PerformLayout()
        TableLayoutPanel9.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel10.ResumeLayout(False)
        TableLayoutPanel10.ResumeLayout(False)
        TableLayoutPanel10.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents lblPendingOrderText As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblInProgressText As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblOutForDeliveryText As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblCompletedText As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblPendingOrdersValue As Label
    Friend WithEvents lblInProgressValue As Label
    Friend WithEvents lblOutForDeliveryValue As Label
    Friend WithEvents lblCompletedValue As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblAvailableValue As Label
    Friend WithEvents lblAvailableText As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lblInUseValue As Label
    Friend WithEvents lblInUseText As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents lblBrokenValue As Label
    Friend WithEvents lblBrokenText As Label

End Class

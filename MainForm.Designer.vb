<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        navbarPanel = New Guna.UI2.WinForms.Guna2GradientPanel()
        navbarBtnPanel = New Panel()
        navBottomDivider = New Panel()
        settingsBtnPanel = New Panel()
        settingsBtn = New Button()
        adminPanel = New Panel()
        adminnNavTblPanel = New TableLayoutPanel()
        logoutBtn = New Button()
        administratorLbl = New Label()
        adminPicBox = New PictureBox()
        adminNameLbl = New Label()
        statsBtnPanel = New Panel()
        statisticsBtn = New Button()
        transacBtnPanel = New Panel()
        transactionsBtn = New Button()
        machineBtnPanel = New Panel()
        machinesBtn = New Button()
        dashBtnPanel = New Panel()
        dashboardBtn = New Button()
        logoTblPanel = New TableLayoutPanel()
        shopLabel = New Label()
        logoIcon = New PictureBox()
        controlsPanel = New Panel()
        controlsTblPanel = New TableLayoutPanel()
        xBtn = New Button()
        maximizeBtn = New Button()
        minimizeBtn = New Button()
        topDivider = New Panel()
        contentSpacePanel = New Panel()
        titleBarPanel = New Panel()
        navbarPanel.SuspendLayout()
        navbarBtnPanel.SuspendLayout()
        settingsBtnPanel.SuspendLayout()
        adminPanel.SuspendLayout()
        adminnNavTblPanel.SuspendLayout()
        CType(adminPicBox, ComponentModel.ISupportInitialize).BeginInit()
        statsBtnPanel.SuspendLayout()
        transacBtnPanel.SuspendLayout()
        machineBtnPanel.SuspendLayout()
        dashBtnPanel.SuspendLayout()
        logoTblPanel.SuspendLayout()
        CType(logoIcon, ComponentModel.ISupportInitialize).BeginInit()
        controlsPanel.SuspendLayout()
        controlsTblPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' navbarPanel
        ' 
        navbarPanel.Controls.Add(navbarBtnPanel)
        navbarPanel.Controls.Add(logoTblPanel)
        navbarPanel.CustomizableEdges = CustomizableEdges1
        navbarPanel.Dock = DockStyle.Left
        navbarPanel.FillColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        navbarPanel.FillColor2 = Color.FromArgb(CByte(76), CByte(102), CByte(232))
        navbarPanel.Location = New Point(0, 0)
        navbarPanel.Margin = New Padding(6, 7, 6, 7)
        navbarPanel.Name = "navbarPanel"
        navbarPanel.Padding = New Padding(0, 30, 0, 10)
        navbarPanel.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        navbarPanel.Size = New Size(220, 700)
        navbarPanel.TabIndex = 0
        ' 
        ' navbarBtnPanel
        ' 
        navbarBtnPanel.BackColor = Color.Transparent
        navbarBtnPanel.Controls.Add(navBottomDivider)
        navbarBtnPanel.Controls.Add(settingsBtnPanel)
        navbarBtnPanel.Controls.Add(adminPanel)
        navbarBtnPanel.Controls.Add(statsBtnPanel)
        navbarBtnPanel.Controls.Add(transacBtnPanel)
        navbarBtnPanel.Controls.Add(machineBtnPanel)
        navbarBtnPanel.Controls.Add(dashBtnPanel)
        navbarBtnPanel.Dock = DockStyle.Fill
        navbarBtnPanel.Location = New Point(0, 117)
        navbarBtnPanel.Name = "navbarBtnPanel"
        navbarBtnPanel.Padding = New Padding(7, 0, 7, 0)
        navbarBtnPanel.Size = New Size(220, 573)
        navbarBtnPanel.TabIndex = 1
        ' 
        ' navBottomDivider
        ' 
        navBottomDivider.BackColor = Color.White
        navBottomDivider.Dock = DockStyle.Bottom
        navBottomDivider.Location = New Point(7, 518)
        navBottomDivider.Name = "navBottomDivider"
        navBottomDivider.Size = New Size(206, 1)
        navBottomDivider.TabIndex = 1
        ' 
        ' settingsBtnPanel
        ' 
        settingsBtnPanel.BackColor = Color.Transparent
        settingsBtnPanel.Controls.Add(settingsBtn)
        settingsBtnPanel.Dock = DockStyle.Top
        settingsBtnPanel.Location = New Point(7, 176)
        settingsBtnPanel.Name = "settingsBtnPanel"
        settingsBtnPanel.Size = New Size(206, 44)
        settingsBtnPanel.TabIndex = 3
        ' 
        ' settingsBtn
        ' 
        settingsBtn.Dock = DockStyle.Fill
        settingsBtn.FlatAppearance.BorderSize = 0
        settingsBtn.FlatStyle = FlatStyle.Flat
        settingsBtn.Font = New Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        settingsBtn.ForeColor = Color.White
        settingsBtn.Image = CType(resources.GetObject("settingsBtn.Image"), Image)
        settingsBtn.ImageAlign = ContentAlignment.MiddleLeft
        settingsBtn.Location = New Point(0, 0)
        settingsBtn.Name = "settingsBtn"
        settingsBtn.Padding = New Padding(15, 4, 0, 4)
        settingsBtn.Size = New Size(206, 44)
        settingsBtn.TabIndex = 2
        settingsBtn.Text = "         Settings"
        settingsBtn.TextAlign = ContentAlignment.BottomLeft
        settingsBtn.UseVisualStyleBackColor = True
        ' 
        ' adminPanel
        ' 
        adminPanel.BackColor = Color.Transparent
        adminPanel.Controls.Add(adminnNavTblPanel)
        adminPanel.Dock = DockStyle.Bottom
        adminPanel.Location = New Point(7, 519)
        adminPanel.Name = "adminPanel"
        adminPanel.Size = New Size(206, 54)
        adminPanel.TabIndex = 1
        ' 
        ' adminnNavTblPanel
        ' 
        adminnNavTblPanel.BackColor = Color.Transparent
        adminnNavTblPanel.ColumnCount = 3
        adminnNavTblPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 29.0F))
        adminnNavTblPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 51.0F))
        adminnNavTblPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        adminnNavTblPanel.Controls.Add(logoutBtn, 2, 0)
        adminnNavTblPanel.Controls.Add(administratorLbl, 1, 1)
        adminnNavTblPanel.Controls.Add(adminPicBox, 0, 0)
        adminnNavTblPanel.Controls.Add(adminNameLbl, 1, 0)
        adminnNavTblPanel.Dock = DockStyle.Bottom
        adminnNavTblPanel.Location = New Point(0, 14)
        adminnNavTblPanel.Name = "adminnNavTblPanel"
        adminnNavTblPanel.RowCount = 2
        adminnNavTblPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        adminnNavTblPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        adminnNavTblPanel.Size = New Size(206, 40)
        adminnNavTblPanel.TabIndex = 2
        ' 
        ' logoutBtn
        ' 
        logoutBtn.BackColor = Color.Transparent
        logoutBtn.Dock = DockStyle.Left
        logoutBtn.FlatAppearance.BorderSize = 0
        logoutBtn.FlatStyle = FlatStyle.Flat
        logoutBtn.Image = CType(resources.GetObject("logoutBtn.Image"), Image)
        logoutBtn.Location = New Point(167, 3)
        logoutBtn.Name = "logoutBtn"
        logoutBtn.Padding = New Padding(0, 0, 5, 0)
        adminnNavTblPanel.SetRowSpan(logoutBtn, 2)
        logoutBtn.Size = New Size(36, 34)
        logoutBtn.TabIndex = 6
        logoutBtn.UseVisualStyleBackColor = False
        ' 
        ' administratorLbl
        ' 
        administratorLbl.AutoSize = True
        administratorLbl.Dock = DockStyle.Fill
        administratorLbl.Font = New Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        administratorLbl.ForeColor = Color.White
        administratorLbl.Location = New Point(62, 20)
        administratorLbl.Name = "administratorLbl"
        administratorLbl.Padding = New Padding(4, 0, 0, 0)
        administratorLbl.Size = New Size(99, 20)
        administratorLbl.TabIndex = 5
        administratorLbl.Text = "Administrator"
        administratorLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' adminPicBox
        ' 
        adminPicBox.Dock = DockStyle.Right
        adminPicBox.Image = CType(resources.GetObject("adminPicBox.Image"), Image)
        adminPicBox.Location = New Point(17, 3)
        adminPicBox.Name = "adminPicBox"
        adminnNavTblPanel.SetRowSpan(adminPicBox, 2)
        adminPicBox.Size = New Size(39, 34)
        adminPicBox.SizeMode = PictureBoxSizeMode.Zoom
        adminPicBox.TabIndex = 3
        adminPicBox.TabStop = False
        ' 
        ' adminNameLbl
        ' 
        adminNameLbl.AutoSize = True
        adminNameLbl.Dock = DockStyle.Fill
        adminNameLbl.Font = New Font("Poppins SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        adminNameLbl.ForeColor = Color.White
        adminNameLbl.Location = New Point(62, 0)
        adminNameLbl.Name = "adminNameLbl"
        adminNameLbl.Padding = New Padding(4, 0, 0, 0)
        adminNameLbl.Size = New Size(99, 20)
        adminNameLbl.TabIndex = 4
        adminNameLbl.Text = "Admin Name"
        adminNameLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' statsBtnPanel
        ' 
        statsBtnPanel.BackColor = Color.Transparent
        statsBtnPanel.Controls.Add(statisticsBtn)
        statsBtnPanel.Dock = DockStyle.Top
        statsBtnPanel.Location = New Point(7, 132)
        statsBtnPanel.Name = "statsBtnPanel"
        statsBtnPanel.Size = New Size(206, 44)
        statsBtnPanel.TabIndex = 2
        ' 
        ' statisticsBtn
        ' 
        statisticsBtn.Dock = DockStyle.Fill
        statisticsBtn.FlatAppearance.BorderSize = 0
        statisticsBtn.FlatStyle = FlatStyle.Flat
        statisticsBtn.Font = New Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        statisticsBtn.ForeColor = Color.White
        statisticsBtn.Image = CType(resources.GetObject("statisticsBtn.Image"), Image)
        statisticsBtn.ImageAlign = ContentAlignment.MiddleLeft
        statisticsBtn.Location = New Point(0, 0)
        statisticsBtn.Name = "statisticsBtn"
        statisticsBtn.Padding = New Padding(15, 4, 0, 4)
        statisticsBtn.Size = New Size(206, 44)
        statisticsBtn.TabIndex = 2
        statisticsBtn.Text = "         Statistics"
        statisticsBtn.TextAlign = ContentAlignment.BottomLeft
        statisticsBtn.UseVisualStyleBackColor = True
        ' 
        ' transacBtnPanel
        ' 
        transacBtnPanel.BackColor = Color.Transparent
        transacBtnPanel.Controls.Add(transactionsBtn)
        transacBtnPanel.Dock = DockStyle.Top
        transacBtnPanel.Location = New Point(7, 88)
        transacBtnPanel.Name = "transacBtnPanel"
        transacBtnPanel.Size = New Size(206, 44)
        transacBtnPanel.TabIndex = 2
        ' 
        ' transactionsBtn
        ' 
        transactionsBtn.Dock = DockStyle.Fill
        transactionsBtn.FlatAppearance.BorderSize = 0
        transactionsBtn.FlatStyle = FlatStyle.Flat
        transactionsBtn.Font = New Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        transactionsBtn.ForeColor = Color.White
        transactionsBtn.Image = CType(resources.GetObject("transactionsBtn.Image"), Image)
        transactionsBtn.ImageAlign = ContentAlignment.MiddleLeft
        transactionsBtn.Location = New Point(0, 0)
        transactionsBtn.Name = "transactionsBtn"
        transactionsBtn.Padding = New Padding(15, 4, 0, 4)
        transactionsBtn.Size = New Size(206, 44)
        transactionsBtn.TabIndex = 2
        transactionsBtn.Text = "         Transactions"
        transactionsBtn.TextAlign = ContentAlignment.BottomLeft
        transactionsBtn.UseVisualStyleBackColor = True
        ' 
        ' machineBtnPanel
        ' 
        machineBtnPanel.BackColor = Color.Transparent
        machineBtnPanel.Controls.Add(machinesBtn)
        machineBtnPanel.Dock = DockStyle.Top
        machineBtnPanel.Location = New Point(7, 44)
        machineBtnPanel.Name = "machineBtnPanel"
        machineBtnPanel.Size = New Size(206, 44)
        machineBtnPanel.TabIndex = 3
        ' 
        ' machinesBtn
        ' 
        machinesBtn.Dock = DockStyle.Fill
        machinesBtn.FlatAppearance.BorderSize = 0
        machinesBtn.FlatStyle = FlatStyle.Flat
        machinesBtn.Font = New Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        machinesBtn.ForeColor = Color.White
        machinesBtn.Image = CType(resources.GetObject("machinesBtn.Image"), Image)
        machinesBtn.ImageAlign = ContentAlignment.MiddleLeft
        machinesBtn.Location = New Point(0, 0)
        machinesBtn.Name = "machinesBtn"
        machinesBtn.Padding = New Padding(15, 4, 0, 4)
        machinesBtn.Size = New Size(206, 44)
        machinesBtn.TabIndex = 2
        machinesBtn.Text = "         Machines"
        machinesBtn.TextAlign = ContentAlignment.BottomLeft
        machinesBtn.UseVisualStyleBackColor = True
        ' 
        ' dashBtnPanel
        ' 
        dashBtnPanel.BackColor = Color.Transparent
        dashBtnPanel.Controls.Add(dashboardBtn)
        dashBtnPanel.Dock = DockStyle.Top
        dashBtnPanel.Location = New Point(7, 0)
        dashBtnPanel.Name = "dashBtnPanel"
        dashBtnPanel.Size = New Size(206, 44)
        dashBtnPanel.TabIndex = 3
        ' 
        ' dashboardBtn
        ' 
        dashboardBtn.Dock = DockStyle.Fill
        dashboardBtn.FlatAppearance.BorderSize = 0
        dashboardBtn.FlatStyle = FlatStyle.Flat
        dashboardBtn.Font = New Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dashboardBtn.ForeColor = Color.White
        dashboardBtn.Image = CType(resources.GetObject("dashboardBtn.Image"), Image)
        dashboardBtn.ImageAlign = ContentAlignment.MiddleLeft
        dashboardBtn.Location = New Point(0, 0)
        dashboardBtn.Name = "dashboardBtn"
        dashboardBtn.Padding = New Padding(15, 4, 0, 4)
        dashboardBtn.Size = New Size(206, 44)
        dashboardBtn.TabIndex = 2
        dashboardBtn.Text = "         Dashboard"
        dashboardBtn.TextAlign = ContentAlignment.BottomLeft
        dashboardBtn.UseVisualStyleBackColor = True
        ' 
        ' logoTblPanel
        ' 
        logoTblPanel.BackColor = Color.Transparent
        logoTblPanel.ColumnCount = 2
        logoTblPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 22.0F))
        logoTblPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 78.0F))
        logoTblPanel.Controls.Add(shopLabel, 1, 0)
        logoTblPanel.Controls.Add(logoIcon, 0, 0)
        logoTblPanel.Dock = DockStyle.Top
        logoTblPanel.ForeColor = Color.White
        logoTblPanel.Location = New Point(0, 30)
        logoTblPanel.Name = "logoTblPanel"
        logoTblPanel.Padding = New Padding(13, 0, 0, 40)
        logoTblPanel.RowCount = 1
        logoTblPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        logoTblPanel.Size = New Size(220, 87)
        logoTblPanel.TabIndex = 1
        ' 
        ' shopLabel
        ' 
        shopLabel.AutoSize = True
        shopLabel.Dock = DockStyle.Fill
        shopLabel.ForeColor = Color.White
        shopLabel.Location = New Point(61, 0)
        shopLabel.Name = "shopLabel"
        shopLabel.Size = New Size(156, 47)
        shopLabel.TabIndex = 2
        shopLabel.Text = "BubbleFresh"
        shopLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' logoIcon
        ' 
        logoIcon.Dock = DockStyle.Fill
        logoIcon.Image = CType(resources.GetObject("logoIcon.Image"), Image)
        logoIcon.Location = New Point(16, 3)
        logoIcon.Name = "logoIcon"
        logoIcon.Size = New Size(39, 41)
        logoIcon.SizeMode = PictureBoxSizeMode.Zoom
        logoIcon.TabIndex = 2
        logoIcon.TabStop = False
        ' 
        ' controlsPanel
        ' 
        controlsPanel.BackColor = Color.White
        controlsPanel.Controls.Add(controlsTblPanel)
        controlsPanel.Dock = DockStyle.Top
        controlsPanel.Location = New Point(220, 0)
        controlsPanel.Margin = New Padding(3, 0, 3, 0)
        controlsPanel.Name = "controlsPanel"
        controlsPanel.Padding = New Padding(0, 3, 0, 3)
        controlsPanel.Size = New Size(880, 25)
        controlsPanel.TabIndex = 1
        ' 
        ' controlsTblPanel
        ' 
        controlsTblPanel.ColumnCount = 3
        controlsTblPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        controlsTblPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        controlsTblPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        controlsTblPanel.Controls.Add(xBtn, 2, 0)
        controlsTblPanel.Controls.Add(maximizeBtn, 1, 0)
        controlsTblPanel.Controls.Add(minimizeBtn, 0, 0)
        controlsTblPanel.Dock = DockStyle.Right
        controlsTblPanel.Location = New Point(805, 3)
        controlsTblPanel.Name = "controlsTblPanel"
        controlsTblPanel.RowCount = 1
        controlsTblPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        controlsTblPanel.Size = New Size(75, 19)
        controlsTblPanel.TabIndex = 0
        ' 
        ' xBtn
        ' 
        xBtn.BackColor = Color.IndianRed
        xBtn.Dock = DockStyle.Fill
        xBtn.FlatAppearance.BorderSize = 0
        xBtn.FlatStyle = FlatStyle.Flat
        xBtn.Image = CType(resources.GetObject("xBtn.Image"), Image)
        xBtn.Location = New Point(49, 0)
        xBtn.Margin = New Padding(0)
        xBtn.Name = "xBtn"
        xBtn.Size = New Size(26, 19)
        xBtn.TabIndex = 3
        xBtn.UseVisualStyleBackColor = False
        ' 
        ' maximizeBtn
        ' 
        maximizeBtn.BackColor = Color.FromArgb(CByte(182), CByte(213), CByte(255))
        maximizeBtn.Dock = DockStyle.Fill
        maximizeBtn.FlatAppearance.BorderSize = 0
        maximizeBtn.FlatStyle = FlatStyle.Flat
        maximizeBtn.Image = CType(resources.GetObject("maximizeBtn.Image"), Image)
        maximizeBtn.Location = New Point(24, 0)
        maximizeBtn.Margin = New Padding(0)
        maximizeBtn.Name = "maximizeBtn"
        maximizeBtn.Size = New Size(25, 19)
        maximizeBtn.TabIndex = 2
        maximizeBtn.UseVisualStyleBackColor = False
        ' 
        ' minimizeBtn
        ' 
        minimizeBtn.BackColor = Color.FromArgb(CByte(152), CByte(169), CByte(192))
        minimizeBtn.Dock = DockStyle.Fill
        minimizeBtn.FlatAppearance.BorderSize = 0
        minimizeBtn.FlatStyle = FlatStyle.Flat
        minimizeBtn.ForeColor = Color.Transparent
        minimizeBtn.Location = New Point(0, 0)
        minimizeBtn.Margin = New Padding(0)
        minimizeBtn.Name = "minimizeBtn"
        minimizeBtn.Size = New Size(24, 19)
        minimizeBtn.TabIndex = 2
        minimizeBtn.TextAlign = ContentAlignment.TopCenter
        minimizeBtn.UseVisualStyleBackColor = False
        ' 
        ' topDivider
        ' 
        topDivider.BackColor = SystemColors.ActiveBorder
        topDivider.Dock = DockStyle.Top
        topDivider.Location = New Point(220, 25)
        topDivider.Name = "topDivider"
        topDivider.Size = New Size(880, 1)
        topDivider.TabIndex = 2
        ' 
        ' contentSpacePanel
        ' 
        contentSpacePanel.BackColor = Color.FromArgb(CByte(241), CByte(241), CByte(241))
        contentSpacePanel.Dock = DockStyle.Fill
        contentSpacePanel.Location = New Point(220, 77)
        contentSpacePanel.Margin = New Padding(0)
        contentSpacePanel.Name = "contentSpacePanel"
        contentSpacePanel.Size = New Size(880, 623)
        contentSpacePanel.TabIndex = 4
        ' 
        ' titleBarPanel
        ' 
        titleBarPanel.BackColor = Color.White
        titleBarPanel.Dock = DockStyle.Top
        titleBarPanel.Location = New Point(220, 26)
        titleBarPanel.Name = "titleBarPanel"
        titleBarPanel.Size = New Size(880, 51)
        titleBarPanel.TabIndex = 3
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 37.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(76), CByte(102), CByte(232))
        ClientSize = New Size(1100, 700)
        Controls.Add(contentSpacePanel)
        Controls.Add(titleBarPanel)
        Controls.Add(topDivider)
        Controls.Add(controlsPanel)
        Controls.Add(navbarPanel)
        Font = New Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(6, 7, 6, 7)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "newMainForm"
        navbarPanel.ResumeLayout(False)
        navbarBtnPanel.ResumeLayout(False)
        settingsBtnPanel.ResumeLayout(False)
        adminPanel.ResumeLayout(False)
        adminnNavTblPanel.ResumeLayout(False)
        adminnNavTblPanel.PerformLayout()
        CType(adminPicBox, ComponentModel.ISupportInitialize).EndInit()
        statsBtnPanel.ResumeLayout(False)
        transacBtnPanel.ResumeLayout(False)
        machineBtnPanel.ResumeLayout(False)
        dashBtnPanel.ResumeLayout(False)
        logoTblPanel.ResumeLayout(False)
        logoTblPanel.PerformLayout()
        CType(logoIcon, ComponentModel.ISupportInitialize).EndInit()
        controlsPanel.ResumeLayout(False)
        controlsTblPanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents navbarPanel As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents logoTblPanel As TableLayoutPanel
    Friend WithEvents shopLabel As Label
    Friend WithEvents logoIcon As PictureBox
    Friend WithEvents navbarBtnPanel As Panel
    Friend WithEvents settingsBtnPanel As Panel
    Friend WithEvents settingsBtn As Button
    Friend WithEvents statsBtnPanel As Panel
    Friend WithEvents statisticsBtn As Button
    Friend WithEvents transacBtnPanel As Panel
    Friend WithEvents transactionsBtn As Button
    Friend WithEvents machineBtnPanel As Panel
    Friend WithEvents machinesBtn As Button
    Friend WithEvents dashBtnPanel As Panel
    Friend WithEvents dashboardBtn As Button
    Friend WithEvents adminNameLbl As Label
    Friend WithEvents adminPicBox As PictureBox
    Friend WithEvents adminnNavTblPanel As TableLayoutPanel
    Friend WithEvents logoutBtn As Button
    Friend WithEvents administratorLbl As Label
    Friend WithEvents adminPanel As Panel
    Friend WithEvents navBottomDivider As Panel
    Friend WithEvents controlsPanel As Panel
    Friend WithEvents topDivider As Panel
    Friend WithEvents contentSpacePanel As Panel
    Friend WithEvents titleBarPanel As Panel
    Friend WithEvents controlsTblPanel As TableLayoutPanel
    Friend WithEvents xBtn As Button
    Friend WithEvents maximizeBtn As Button
    Friend WithEvents minimizeBtn As Button
End Class

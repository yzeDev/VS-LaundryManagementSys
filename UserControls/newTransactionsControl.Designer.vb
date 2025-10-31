<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class newTransactionsControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newTransactionsControl))
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        cmbStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        tbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        dtpDateFilter = New Guna.UI2.WinForms.Guna2DateTimePicker()
        flpContainerPanel = New Panel()
        dgvTransactions = New Guna.UI2.WinForms.Guna2DataGridView()
        Panel2 = New Panel()
        TableLayoutPanel5 = New TableLayoutPanel()
        Panel1 = New Panel()
        TableLayoutPanel4 = New TableLayoutPanel()
        btnAdd = New Guna.UI2.WinForms.Guna2Button()
        btnDelete = New Guna.UI2.WinForms.Guna2Button()
        btnEdit = New Guna.UI2.WinForms.Guna2Button()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label1 = New Label()
        toggleDate = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        TableLayoutPanel1.SuspendLayout()
        Guna2ShadowPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        flpContainerPanel.SuspendLayout()
        CType(dgvTransactions, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        Panel1.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Anchor = AnchorStyles.Right
        cmbStatus.BackColor = Color.Transparent
        cmbStatus.CustomizableEdges = CustomizableEdges1
        cmbStatus.DrawMode = DrawMode.OwnerDrawFixed
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.DropDownWidth = 137
        cmbStatus.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbStatus.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbStatus.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbStatus.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cmbStatus.ItemHeight = 30
        cmbStatus.Location = New Point(336, 9)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.RightToLeft = RightToLeft.Yes
        cmbStatus.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        cmbStatus.Size = New Size(225, 36)
        cmbStatus.TabIndex = 7
        cmbStatus.TabStop = False
        cmbStatus.Tag = ""
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 300F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Guna2ShadowPanel1, 0, 0)
        TableLayoutPanel1.Controls.Add(flpContainerPanel, 0, 2)
        TableLayoutPanel1.Controls.Add(Panel2, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(855, 604)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Guna2ShadowPanel1
        ' 
        Guna2ShadowPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.SetColumnSpan(Guna2ShadowPanel1, 3)
        Guna2ShadowPanel1.Controls.Add(TableLayoutPanel2)
        Guna2ShadowPanel1.Dock = DockStyle.Fill
        Guna2ShadowPanel1.FillColor = Color.White
        Guna2ShadowPanel1.Location = New Point(3, 3)
        Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Guna2ShadowPanel1.ShadowColor = Color.Black
        Guna2ShadowPanel1.ShadowDepth = 50
        Guna2ShadowPanel1.ShadowShift = 3
        Guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Guna2ShadowPanel1.Size = New Size(849, 54)
        Guna2ShadowPanel1.TabIndex = 8
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 39.2226143F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 27.20848F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.Controls.Add(cmbStatus, 1, 0)
        TableLayoutPanel2.Controls.Add(tbSearch, 0, 0)
        TableLayoutPanel2.Controls.Add(dtpDateFilter, 2, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(849, 54)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' tbSearch
        ' 
        tbSearch.CustomizableEdges = CustomizableEdges3
        tbSearch.DefaultText = ""
        tbSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbSearch.Dock = DockStyle.Left
        tbSearch.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbSearch.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbSearch.ForeColor = Color.Black
        tbSearch.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbSearch.IconLeft = CType(resources.GetObject("tbSearch.IconLeft"), Image)
        tbSearch.IconLeftOffset = New Point(10, 0)
        tbSearch.Location = New Point(6, 9)
        tbSearch.Margin = New Padding(6, 9, 6, 9)
        tbSearch.Name = "tbSearch"
        tbSearch.PlaceholderText = "Search"
        tbSearch.SelectedText = ""
        tbSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        tbSearch.Size = New Size(321, 36)
        tbSearch.TabIndex = 8
        tbSearch.TextOffset = New Point(10, 0)
        ' 
        ' dtpDateFilter
        ' 
        dtpDateFilter.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        dtpDateFilter.Checked = True
        dtpDateFilter.CheckedState.FillColor = Color.White
        dtpDateFilter.CustomizableEdges = CustomizableEdges5
        dtpDateFilter.FillColor = Color.White
        dtpDateFilter.FocusedColor = Color.White
        dtpDateFilter.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpDateFilter.Format = DateTimePickerFormat.Long
        dtpDateFilter.Location = New Point(570, 0)
        dtpDateFilter.Margin = New Padding(0)
        dtpDateFilter.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        dtpDateFilter.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        dtpDateFilter.Name = "dtpDateFilter"
        dtpDateFilter.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        dtpDateFilter.Size = New Size(279, 50)
        dtpDateFilter.TabIndex = 9
        dtpDateFilter.TabStop = False
        dtpDateFilter.Value = New Date(2025, 10, 31, 0, 0, 0, 0)
        ' 
        ' flpContainerPanel
        ' 
        TableLayoutPanel1.SetColumnSpan(flpContainerPanel, 3)
        flpContainerPanel.Controls.Add(dgvTransactions)
        flpContainerPanel.Dock = DockStyle.Fill
        flpContainerPanel.Location = New Point(0, 110)
        flpContainerPanel.Margin = New Padding(0)
        flpContainerPanel.Name = "flpContainerPanel"
        flpContainerPanel.Size = New Size(855, 494)
        flpContainerPanel.TabIndex = 12
        ' 
        ' dgvTransactions
        ' 
        dgvTransactions.AllowUserToAddRows = False
        dgvTransactions.AllowUserToDeleteRows = False
        dgvTransactions.AllowUserToResizeColumns = False
        dgvTransactions.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgvTransactions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvTransactions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvTransactions.ColumnHeadersHeight = 4
        dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvTransactions.DefaultCellStyle = DataGridViewCellStyle3
        dgvTransactions.Dock = DockStyle.Fill
        dgvTransactions.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvTransactions.Location = New Point(0, 0)
        dgvTransactions.Margin = New Padding(0)
        dgvTransactions.Name = "dgvTransactions"
        dgvTransactions.RowHeadersVisible = False
        dgvTransactions.Size = New Size(855, 494)
        dgvTransactions.TabIndex = 0
        dgvTransactions.TabStop = False
        dgvTransactions.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvTransactions.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvTransactions.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvTransactions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvTransactions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvTransactions.ThemeStyle.BackColor = Color.White
        dgvTransactions.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvTransactions.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgvTransactions.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvTransactions.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dgvTransactions.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvTransactions.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvTransactions.ThemeStyle.HeaderStyle.Height = 4
        dgvTransactions.ThemeStyle.ReadOnly = False
        dgvTransactions.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvTransactions.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvTransactions.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgvTransactions.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvTransactions.ThemeStyle.RowsStyle.Height = 25
        dgvTransactions.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvTransactions.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Panel2
        ' 
        TableLayoutPanel1.SetColumnSpan(Panel2, 3)
        Panel2.Controls.Add(TableLayoutPanel5)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 60)
        Panel2.Margin = New Padding(0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(855, 50)
        Panel2.TabIndex = 14
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel5.Controls.Add(TableLayoutPanel3, 1, 0)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Location = New Point(0, 0)
        TableLayoutPanel5.Margin = New Padding(0)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel5.Size = New Size(855, 50)
        TableLayoutPanel5.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TableLayoutPanel4)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(356, 50)
        Panel1.TabIndex = 13
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 3
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel4.Controls.Add(btnAdd, 0, 0)
        TableLayoutPanel4.Controls.Add(btnDelete, 2, 0)
        TableLayoutPanel4.Controls.Add(btnEdit, 1, 0)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(0, 0)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel4.Size = New Size(356, 50)
        TableLayoutPanel4.TabIndex = 0
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.None
        btnAdd.BorderRadius = 8
        btnAdd.CustomizableEdges = CustomizableEdges7
        btnAdd.DisabledState.BorderColor = Color.DarkGray
        btnAdd.DisabledState.CustomBorderColor = Color.DarkGray
        btnAdd.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAdd.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAdd.FillColor = Color.FromArgb(CByte(187), CByte(246), CByte(162))
        btnAdd.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.Black
        btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), Image)
        btnAdd.Location = New Point(5, 8)
        btnAdd.Margin = New Padding(5, 3, 3, 3)
        btnAdd.Name = "btnAdd"
        btnAdd.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnAdd.Size = New Size(110, 34)
        btnAdd.TabIndex = 11
        btnAdd.Text = "Add Order"
        btnAdd.TextOffset = New Point(0, 2)
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.None
        btnDelete.BorderRadius = 8
        btnDelete.CustomizableEdges = CustomizableEdges9
        btnDelete.DisabledState.BorderColor = Color.DarkGray
        btnDelete.DisabledState.CustomBorderColor = Color.DarkGray
        btnDelete.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnDelete.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnDelete.Enabled = False
        btnDelete.FillColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnDelete.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.Black
        btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), Image)
        btnDelete.Location = New Point(242, 8)
        btnDelete.Margin = New Padding(5, 3, 3, 3)
        btnDelete.Name = "btnDelete"
        btnDelete.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnDelete.Size = New Size(110, 34)
        btnDelete.TabIndex = 10
        btnDelete.Text = "Delete"
        btnDelete.TextOffset = New Point(0, 2)
        ' 
        ' btnEdit
        ' 
        btnEdit.Anchor = AnchorStyles.None
        btnEdit.BorderRadius = 8
        btnEdit.CustomizableEdges = CustomizableEdges11
        btnEdit.DisabledState.BorderColor = Color.DarkGray
        btnEdit.DisabledState.CustomBorderColor = Color.DarkGray
        btnEdit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEdit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnEdit.Enabled = False
        btnEdit.FillColor = Color.PowderBlue
        btnEdit.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEdit.ForeColor = Color.Black
        btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), Image)
        btnEdit.Location = New Point(123, 8)
        btnEdit.Margin = New Padding(5, 3, 3, 3)
        btnEdit.Name = "btnEdit"
        btnEdit.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        btnEdit.Size = New Size(109, 34)
        btnEdit.TabIndex = 12
        btnEdit.Text = "Edit"
        btnEdit.TextOffset = New Point(0, 2)
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 60F))
        TableLayoutPanel3.Controls.Add(Label1, 0, 0)
        TableLayoutPanel3.Controls.Add(toggleDate, 1, 0)
        TableLayoutPanel3.Dock = DockStyle.Right
        TableLayoutPanel3.Location = New Point(430, 0)
        TableLayoutPanel3.Margin = New Padding(0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(425, 50)
        TableLayoutPanel3.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Right
        Label1.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(245, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 50)
        Label1.TabIndex = 10
        Label1.Text = "Show All Dates"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' toggleDate
        ' 
        toggleDate.Anchor = AnchorStyles.None
        toggleDate.Checked = True
        toggleDate.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        toggleDate.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        toggleDate.CheckedState.InnerBorderColor = Color.White
        toggleDate.CheckedState.InnerColor = Color.White
        toggleDate.CustomizableEdges = CustomizableEdges13
        toggleDate.Location = New Point(376, 16)
        toggleDate.Name = "toggleDate"
        toggleDate.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        toggleDate.Size = New Size(37, 18)
        toggleDate.TabIndex = 11
        toggleDate.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        toggleDate.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        toggleDate.UncheckedState.InnerBorderColor = Color.White
        toggleDate.UncheckedState.InnerColor = Color.White
        ' 
        ' newTransactionsControl
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(10)
        Name = "newTransactionsControl"
        Size = New Size(855, 604)
        TableLayoutPanel1.ResumeLayout(False)
        Guna2ShadowPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        flpContainerPanel.ResumeLayout(False)
        CType(dgvTransactions, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        TableLayoutPanel5.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmbStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Guna2ToggleSwitch1 As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tbSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents toggleDate As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents dtpDateFilter As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents flpContainerPanel As Panel
    Friend WithEvents dgvTransactions As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel

End Class

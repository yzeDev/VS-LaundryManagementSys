<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransactionControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransactionControl))
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        cmbStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        tbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        dtpDateFilter = New Guna.UI2.WinForms.Guna2DateTimePicker()
        btnAdd = New Guna.UI2.WinForms.Guna2Button()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label1 = New Label()
        toggleDate = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        flpContainerPanel = New Panel()
        flpTransactions = New FlowLayoutPanel()
        TableLayoutPanel1.SuspendLayout()
        Guna2ShadowPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        flpContainerPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Anchor = AnchorStyles.None
        cmbStatus.BackColor = Color.Transparent
        cmbStatus.CustomizableEdges = CustomizableEdges1
        cmbStatus.DrawMode = DrawMode.OwnerDrawFixed
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.DropDownWidth = 137
        cmbStatus.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbStatus.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbStatus.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbStatus.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cmbStatus.ItemHeight = 30
        cmbStatus.Location = New Point(642, 23)
        cmbStatus.Margin = New Padding(4)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.RightToLeft = RightToLeft.Yes
        cmbStatus.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        cmbStatus.Size = New Size(307, 36)
        cmbStatus.TabIndex = 7
        cmbStatus.Tag = ""
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 225F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Guna2ShadowPanel1, 0, 0)
        TableLayoutPanel1.Controls.Add(btnAdd, 0, 1)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel3, 2, 1)
        TableLayoutPanel1.Controls.Add(flpContainerPanel, 0, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 90F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1282, 906)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Guna2ShadowPanel1
        ' 
        Guna2ShadowPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.SetColumnSpan(Guna2ShadowPanel1, 3)
        Guna2ShadowPanel1.Controls.Add(TableLayoutPanel2)
        Guna2ShadowPanel1.Dock = DockStyle.Fill
        Guna2ShadowPanel1.FillColor = Color.White
        Guna2ShadowPanel1.Location = New Point(4, 4)
        Guna2ShadowPanel1.Margin = New Padding(4)
        Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Guna2ShadowPanel1.ShadowColor = Color.Black
        Guna2ShadowPanel1.ShadowDepth = 50
        Guna2ShadowPanel1.ShadowShift = 3
        Guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Guna2ShadowPanel1.Size = New Size(1274, 82)
        Guna2ShadowPanel1.TabIndex = 8
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel2.Controls.Add(cmbStatus, 1, 0)
        TableLayoutPanel2.Controls.Add(tbSearch, 0, 0)
        TableLayoutPanel2.Controls.Add(dtpDateFilter, 2, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Margin = New Padding(4)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(1274, 82)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' tbSearch
        ' 
        tbSearch.CustomizableEdges = CustomizableEdges3
        tbSearch.DefaultText = "Search"
        tbSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbSearch.Dock = DockStyle.Fill
        tbSearch.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbSearch.Font = New Font("Segoe UI", 9F)
        tbSearch.ForeColor = Color.Black
        tbSearch.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbSearch.IconLeft = CType(resources.GetObject("tbSearch.IconLeft"), Image)
        tbSearch.Location = New Point(6, 8)
        tbSearch.Margin = New Padding(6, 8, 6, 8)
        tbSearch.Name = "tbSearch"
        tbSearch.PlaceholderText = ""
        tbSearch.SelectedText = ""
        tbSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        tbSearch.Size = New Size(625, 66)
        tbSearch.TabIndex = 8
        tbSearch.TextOffset = New Point(10, 0)
        ' 
        ' dtpDateFilter
        ' 
        dtpDateFilter.Checked = True
        dtpDateFilter.CheckedState.FillColor = Color.White
        dtpDateFilter.CustomizableEdges = CustomizableEdges5
        dtpDateFilter.Dock = DockStyle.Fill
        dtpDateFilter.FillColor = Color.White
        dtpDateFilter.FocusedColor = Color.White
        dtpDateFilter.Font = New Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpDateFilter.Format = DateTimePickerFormat.Long
        dtpDateFilter.Location = New Point(959, 4)
        dtpDateFilter.Margin = New Padding(4)
        dtpDateFilter.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        dtpDateFilter.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        dtpDateFilter.Name = "dtpDateFilter"
        dtpDateFilter.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        dtpDateFilter.Size = New Size(311, 74)
        dtpDateFilter.TabIndex = 9
        dtpDateFilter.Value = New Date(2025, 10, 14, 16, 9, 1, 495)
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.None
        btnAdd.AutoRoundedCorners = True
        btnAdd.CustomizableEdges = CustomizableEdges7
        btnAdd.DisabledState.BorderColor = Color.DarkGray
        btnAdd.DisabledState.CustomBorderColor = Color.DarkGray
        btnAdd.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAdd.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAdd.FillColor = Color.FromArgb(CByte(187), CByte(246), CByte(162))
        btnAdd.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.Black
        btnAdd.Location = New Point(8, 94)
        btnAdd.Margin = New Padding(8, 4, 4, 4)
        btnAdd.Name = "btnAdd"
        btnAdd.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnAdd.Size = New Size(213, 51)
        btnAdd.TabIndex = 10
        btnAdd.Text = "+ Add Order"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 90F))
        TableLayoutPanel3.Controls.Add(Label1, 0, 0)
        TableLayoutPanel3.Controls.Add(toggleDate, 1, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(757, 94)
        TableLayoutPanel3.Margin = New Padding(4)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(521, 52)
        TableLayoutPanel3.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Right
        Label1.Font = New Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(291, 0)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 52)
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
        toggleDate.CustomizableEdges = CustomizableEdges9
        toggleDate.Location = New Point(448, 12)
        toggleDate.Margin = New Padding(4)
        toggleDate.Name = "toggleDate"
        toggleDate.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        toggleDate.Size = New Size(56, 27)
        toggleDate.TabIndex = 11
        toggleDate.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        toggleDate.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        toggleDate.UncheckedState.InnerBorderColor = Color.White
        toggleDate.UncheckedState.InnerColor = Color.White
        ' 
        ' flpContainerPanel
        ' 
        TableLayoutPanel1.SetColumnSpan(flpContainerPanel, 3)
        flpContainerPanel.Controls.Add(flpTransactions)
        flpContainerPanel.Dock = DockStyle.Fill
        flpContainerPanel.Location = New Point(0, 150)
        flpContainerPanel.Margin = New Padding(0)
        flpContainerPanel.Name = "flpContainerPanel"
        flpContainerPanel.Size = New Size(1282, 756)
        flpContainerPanel.TabIndex = 12
        ' 
        ' flpTransactions
        ' 
        flpTransactions.AutoScroll = True
        flpTransactions.Dock = DockStyle.Fill
        flpTransactions.FlowDirection = FlowDirection.TopDown
        flpTransactions.Location = New Point(0, 0)
        flpTransactions.Margin = New Padding(0)
        flpTransactions.Name = "flpTransactions"
        flpTransactions.Size = New Size(1282, 756)
        flpTransactions.TabIndex = 0
        flpTransactions.WrapContents = False
        ' 
        ' TransactionControl
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(15)
        Name = "TransactionControl"
        Size = New Size(1282, 906)
        TableLayoutPanel1.ResumeLayout(False)
        Guna2ShadowPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        flpContainerPanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmbStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Guna2ToggleSwitch1 As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tbSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents toggleDate As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents dtpDateFilter As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents flpContainerPanel As Panel
    Friend WithEvents flpTransactions As FlowLayoutPanel

End Class

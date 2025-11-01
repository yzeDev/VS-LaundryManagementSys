<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MachinesControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MachinesControl))
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        cmbStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        flpMachines = New FlowLayoutPanel()
        Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        Panel1 = New Panel()
        TableLayoutPanel3 = New TableLayoutPanel()
        btnConfigure = New Guna.UI2.WinForms.Guna2Button()
        btnAddMachine = New Guna.UI2.WinForms.Guna2Button()
        btnRemoveMachine = New Guna.UI2.WinForms.Guna2Button()
        Panel2 = New Panel()
        TableLayoutPanel4 = New TableLayoutPanel()
        Label1 = New Label()
        TableLayoutPanel1.SuspendLayout()
        Guna2ShadowPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        Panel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        Panel2.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
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
        cmbStatus.Location = New Point(208, 0)
        cmbStatus.Margin = New Padding(0)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.RightToLeft = RightToLeft.Yes
        cmbStatus.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        cmbStatus.Size = New Size(209, 36)
        cmbStatus.TabIndex = 7
        cmbStatus.Tag = ""
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Controls.Add(flpMachines, 0, 1)
        TableLayoutPanel1.Controls.Add(Guna2ShadowPanel1, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.Padding = New Padding(5)
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(855, 604)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' flpMachines
        ' 
        flpMachines.AutoScroll = True
        flpMachines.BackColor = SystemColors.Control
        flpMachines.Dock = DockStyle.Fill
        flpMachines.Font = New Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        flpMachines.Location = New Point(5, 55)
        flpMachines.Margin = New Padding(0)
        flpMachines.Name = "flpMachines"
        flpMachines.Padding = New Padding(10)
        flpMachines.Size = New Size(845, 544)
        flpMachines.TabIndex = 4
        ' 
        ' Guna2ShadowPanel1
        ' 
        Guna2ShadowPanel1.BackColor = Color.Transparent
        Guna2ShadowPanel1.Controls.Add(TableLayoutPanel2)
        Guna2ShadowPanel1.Dock = DockStyle.Fill
        Guna2ShadowPanel1.FillColor = Color.White
        Guna2ShadowPanel1.Location = New Point(8, 8)
        Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Guna2ShadowPanel1.ShadowColor = Color.Black
        Guna2ShadowPanel1.ShadowDepth = 50
        Guna2ShadowPanel1.ShadowShift = 3
        Guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Guna2ShadowPanel1.Size = New Size(839, 44)
        Guna2ShadowPanel1.TabIndex = 8
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel2.Controls.Add(Panel2, 1, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.Padding = New Padding(2)
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(839, 44)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TableLayoutPanel3)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(2, 2)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(417, 40)
        Panel1.TabIndex = 14
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 3
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel3.Controls.Add(btnConfigure, 2, 0)
        TableLayoutPanel3.Controls.Add(btnAddMachine, 0, 0)
        TableLayoutPanel3.Controls.Add(btnRemoveMachine, 1, 0)
        TableLayoutPanel3.Dock = DockStyle.Left
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(422, 40)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' btnConfigure
        ' 
        btnConfigure.BorderRadius = 8
        btnConfigure.CustomizableEdges = CustomizableEdges3
        btnConfigure.DisabledState.BorderColor = Color.DarkGray
        btnConfigure.DisabledState.CustomBorderColor = Color.DarkGray
        btnConfigure.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnConfigure.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnConfigure.Enabled = False
        btnConfigure.FillColor = Color.Gainsboro
        btnConfigure.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnConfigure.ForeColor = Color.Black
        btnConfigure.Image = CType(resources.GetObject("btnConfigure.Image"), Image)
        btnConfigure.Location = New Point(290, 3)
        btnConfigure.Margin = New Padding(10, 3, 3, 3)
        btnConfigure.Name = "btnConfigure"
        btnConfigure.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnConfigure.Size = New Size(129, 34)
        btnConfigure.TabIndex = 13
        btnConfigure.Text = "Configure"
        ' 
        ' btnAddMachine
        ' 
        btnAddMachine.BorderRadius = 8
        btnAddMachine.CustomizableEdges = CustomizableEdges5
        btnAddMachine.DisabledState.BorderColor = Color.DarkGray
        btnAddMachine.DisabledState.CustomBorderColor = Color.DarkGray
        btnAddMachine.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAddMachine.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAddMachine.FillColor = Color.FromArgb(CByte(187), CByte(246), CByte(162))
        btnAddMachine.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddMachine.ForeColor = Color.Black
        btnAddMachine.Image = CType(resources.GetObject("btnAddMachine.Image"), Image)
        btnAddMachine.Location = New Point(10, 3)
        btnAddMachine.Margin = New Padding(10, 3, 3, 3)
        btnAddMachine.Name = "btnAddMachine"
        btnAddMachine.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnAddMachine.Size = New Size(127, 34)
        btnAddMachine.TabIndex = 10
        btnAddMachine.Text = "Add Unit"
        ' 
        ' btnRemoveMachine
        ' 
        btnRemoveMachine.BorderRadius = 8
        btnRemoveMachine.CustomizableEdges = CustomizableEdges7
        btnRemoveMachine.DisabledState.BorderColor = Color.DarkGray
        btnRemoveMachine.DisabledState.CustomBorderColor = Color.DarkGray
        btnRemoveMachine.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnRemoveMachine.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnRemoveMachine.Enabled = False
        btnRemoveMachine.FillColor = Color.LightCoral
        btnRemoveMachine.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRemoveMachine.ForeColor = Color.Black
        btnRemoveMachine.Image = CType(resources.GetObject("btnRemoveMachine.Image"), Image)
        btnRemoveMachine.Location = New Point(150, 3)
        btnRemoveMachine.Margin = New Padding(10, 3, 3, 3)
        btnRemoveMachine.Name = "btnRemoveMachine"
        btnRemoveMachine.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnRemoveMachine.Size = New Size(127, 34)
        btnRemoveMachine.TabIndex = 12
        btnRemoveMachine.Text = "Unavailable"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(TableLayoutPanel4)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(422, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(412, 34)
        Panel2.TabIndex = 15
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(Label1, 0, 0)
        TableLayoutPanel4.Controls.Add(cmbStatus, 1, 0)
        TableLayoutPanel4.Dock = DockStyle.Right
        TableLayoutPanel4.Location = New Point(-5, 0)
        TableLayoutPanel4.Margin = New Padding(0)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(417, 34)
        TableLayoutPanel4.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(202, 34)
        Label1.TabIndex = 11
        Label1.Text = "Sort by:"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' MachinesControl
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(10)
        Name = "MachinesControl"
        Size = New Size(855, 604)
        TableLayoutPanel1.ResumeLayout(False)
        Guna2ShadowPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmbStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Guna2ToggleSwitch1 As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents btnAddMachine As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConfigure As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRemoveMachine As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents flpMachines As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel

End Class

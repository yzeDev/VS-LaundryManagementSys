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
        btnConfigure = New Guna.UI2.WinForms.Guna2Button()
        btnRemoveMachine = New Guna.UI2.WinForms.Guna2Button()
        btnAddMachine = New Guna.UI2.WinForms.Guna2Button()
        Label1 = New Label()
        TableLayoutPanel1.SuspendLayout()
        Guna2ShadowPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmbStatus
        ' 
        cmbStatus.BackColor = Color.Transparent
        cmbStatus.CustomizableEdges = CustomizableEdges1
        cmbStatus.Dock = DockStyle.Fill
        cmbStatus.DrawMode = DrawMode.OwnerDrawFixed
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.DropDownWidth = 137
        cmbStatus.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbStatus.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbStatus.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbStatus.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cmbStatus.ItemHeight = 30
        cmbStatus.Location = New Point(750, 5)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.RightToLeft = RightToLeft.Yes
        cmbStatus.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        cmbStatus.Size = New Size(94, 36)
        cmbStatus.TabIndex = 7
        cmbStatus.Tag = ""
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 28.38284F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.8085823F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.8085823F))
        TableLayoutPanel1.Controls.Add(flpMachines, 0, 1)
        TableLayoutPanel1.Controls.Add(Guna2ShadowPanel1, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(855, 604)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' flpMachines
        ' 
        flpMachines.AutoScroll = True
        flpMachines.BackColor = SystemColors.Control
        TableLayoutPanel1.SetColumnSpan(flpMachines, 3)
        flpMachines.Dock = DockStyle.Fill
        flpMachines.Font = New Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        flpMachines.Location = New Point(40, 50)
        flpMachines.Margin = New Padding(40, 0, 0, 0)
        flpMachines.Name = "flpMachines"
        flpMachines.Padding = New Padding(4)
        flpMachines.Size = New Size(815, 554)
        flpMachines.TabIndex = 4
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
        Guna2ShadowPanel1.Size = New Size(849, 44)
        Guna2ShadowPanel1.TabIndex = 8
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 6
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 150F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 150F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 150F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100F))
        TableLayoutPanel2.Controls.Add(btnConfigure, 2, 0)
        TableLayoutPanel2.Controls.Add(btnRemoveMachine, 1, 0)
        TableLayoutPanel2.Controls.Add(cmbStatus, 5, 0)
        TableLayoutPanel2.Controls.Add(btnAddMachine, 0, 0)
        TableLayoutPanel2.Controls.Add(Label1, 4, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.Padding = New Padding(2)
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(849, 44)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' btnConfigure
        ' 
        btnConfigure.BorderRadius = 16
        btnConfigure.CustomizableEdges = CustomizableEdges3
        btnConfigure.DisabledState.BorderColor = Color.DarkGray
        btnConfigure.DisabledState.CustomBorderColor = Color.DarkGray
        btnConfigure.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnConfigure.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnConfigure.Dock = DockStyle.Fill
        btnConfigure.Enabled = False
        btnConfigure.FillColor = Color.Gainsboro
        btnConfigure.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnConfigure.ForeColor = Color.Black
        btnConfigure.Location = New Point(312, 5)
        btnConfigure.Margin = New Padding(10, 3, 3, 3)
        btnConfigure.Name = "btnConfigure"
        btnConfigure.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnConfigure.Size = New Size(137, 34)
        btnConfigure.TabIndex = 13
        btnConfigure.Text = "Configure"
        ' 
        ' btnRemoveMachine
        ' 
        btnRemoveMachine.BorderRadius = 16
        btnRemoveMachine.CustomizableEdges = CustomizableEdges5
        btnRemoveMachine.DisabledState.BorderColor = Color.DarkGray
        btnRemoveMachine.DisabledState.CustomBorderColor = Color.DarkGray
        btnRemoveMachine.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnRemoveMachine.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnRemoveMachine.Dock = DockStyle.Fill
        btnRemoveMachine.Enabled = False
        btnRemoveMachine.FillColor = Color.LightCoral
        btnRemoveMachine.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRemoveMachine.ForeColor = Color.Black
        btnRemoveMachine.Location = New Point(162, 5)
        btnRemoveMachine.Margin = New Padding(10, 3, 3, 3)
        btnRemoveMachine.Name = "btnRemoveMachine"
        btnRemoveMachine.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnRemoveMachine.Size = New Size(137, 34)
        btnRemoveMachine.TabIndex = 12
        btnRemoveMachine.Text = "Unavailable"
        ' 
        ' btnAddMachine
        ' 
        btnAddMachine.BorderRadius = 16
        btnAddMachine.CustomizableEdges = CustomizableEdges7
        btnAddMachine.DisabledState.BorderColor = Color.DarkGray
        btnAddMachine.DisabledState.CustomBorderColor = Color.DarkGray
        btnAddMachine.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAddMachine.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAddMachine.Dock = DockStyle.Fill
        btnAddMachine.FillColor = Color.FromArgb(CByte(187), CByte(246), CByte(162))
        btnAddMachine.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddMachine.ForeColor = Color.Black
        btnAddMachine.Location = New Point(12, 5)
        btnAddMachine.Margin = New Padding(10, 3, 3, 3)
        btnAddMachine.Name = "btnAddMachine"
        btnAddMachine.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnAddMachine.Size = New Size(137, 34)
        btnAddMachine.TabIndex = 10
        btnAddMachine.Text = "+ Add Unit"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(650, 2)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 40)
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
        TableLayoutPanel2.PerformLayout()
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

End Class

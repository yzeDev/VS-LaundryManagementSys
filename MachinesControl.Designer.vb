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
        flpMachines = New FlowLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
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
        cmbStatus.Location = New Point(1129, 15)
        cmbStatus.Margin = New Padding(4, 4, 4, 4)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.RightToLeft = RightToLeft.Yes
        cmbStatus.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        cmbStatus.Size = New Size(139, 36)
        cmbStatus.TabIndex = 7
        cmbStatus.Tag = ""
        ' 
        ' flpMachines
        ' 
        flpMachines.AutoScroll = True
        flpMachines.BackColor = SystemColors.Control
        TableLayoutPanel1.SetColumnSpan(flpMachines, 3)
        flpMachines.Dock = DockStyle.Fill
        flpMachines.Font = New Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        flpMachines.Location = New Point(3, 78)
        flpMachines.Name = "flpMachines"
        flpMachines.Size = New Size(1276, 825)
        flpMachines.TabIndex = 4
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
        TableLayoutPanel1.Margin = New Padding(4, 4, 4, 4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 75F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
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
        Guna2ShadowPanel1.Margin = New Padding(4, 4, 4, 4)
        Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Guna2ShadowPanel1.ShadowColor = Color.Black
        Guna2ShadowPanel1.ShadowDepth = 50
        Guna2ShadowPanel1.ShadowShift = 3
        Guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Guna2ShadowPanel1.Size = New Size(1274, 67)
        Guna2ShadowPanel1.TabIndex = 8
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 6
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 225F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 225F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 225F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 150F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 150F))
        TableLayoutPanel2.Controls.Add(btnConfigure, 2, 0)
        TableLayoutPanel2.Controls.Add(btnRemoveMachine, 1, 0)
        TableLayoutPanel2.Controls.Add(cmbStatus, 5, 0)
        TableLayoutPanel2.Controls.Add(btnAddMachine, 0, 0)
        TableLayoutPanel2.Controls.Add(Label1, 4, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Margin = New Padding(4, 4, 4, 4)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(1274, 67)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' btnConfigure
        ' 
        btnConfigure.Anchor = AnchorStyles.Left
        btnConfigure.BorderRadius = 5
        btnConfigure.BorderThickness = 1
        btnConfigure.CustomizableEdges = CustomizableEdges3
        btnConfigure.DisabledState.BorderColor = Color.DarkGray
        btnConfigure.DisabledState.CustomBorderColor = Color.DarkGray
        btnConfigure.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnConfigure.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnConfigure.Enabled = False
        btnConfigure.FillColor = Color.White
        btnConfigure.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnConfigure.ForeColor = Color.Black
        btnConfigure.Location = New Point(465, 15)
        btnConfigure.Margin = New Padding(15, 4, 4, 4)
        btnConfigure.Name = "btnConfigure"
        btnConfigure.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnConfigure.Size = New Size(200, 36)
        btnConfigure.TabIndex = 13
        btnConfigure.Text = "Configure"
        ' 
        ' btnRemoveMachine
        ' 
        btnRemoveMachine.Anchor = AnchorStyles.Left
        btnRemoveMachine.BorderRadius = 5
        btnRemoveMachine.BorderThickness = 1
        btnRemoveMachine.CustomizableEdges = CustomizableEdges5
        btnRemoveMachine.DisabledState.BorderColor = Color.DarkGray
        btnRemoveMachine.DisabledState.CustomBorderColor = Color.DarkGray
        btnRemoveMachine.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnRemoveMachine.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnRemoveMachine.Enabled = False
        btnRemoveMachine.FillColor = Color.White
        btnRemoveMachine.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRemoveMachine.ForeColor = Color.Black
        btnRemoveMachine.Location = New Point(240, 15)
        btnRemoveMachine.Margin = New Padding(15, 4, 4, 4)
        btnRemoveMachine.Name = "btnRemoveMachine"
        btnRemoveMachine.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnRemoveMachine.Size = New Size(200, 36)
        btnRemoveMachine.TabIndex = 12
        btnRemoveMachine.Text = "Unavailable"
        ' 
        ' btnAddMachine
        ' 
        btnAddMachine.Anchor = AnchorStyles.Left
        btnAddMachine.BorderRadius = 5
        btnAddMachine.BorderThickness = 1
        btnAddMachine.CustomizableEdges = CustomizableEdges7
        btnAddMachine.DisabledState.BorderColor = Color.DarkGray
        btnAddMachine.DisabledState.CustomBorderColor = Color.DarkGray
        btnAddMachine.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAddMachine.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAddMachine.FillColor = Color.White
        btnAddMachine.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddMachine.ForeColor = Color.Black
        btnAddMachine.Location = New Point(15, 15)
        btnAddMachine.Margin = New Padding(15, 4, 4, 4)
        btnAddMachine.Name = "btnAddMachine"
        btnAddMachine.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnAddMachine.Size = New Size(200, 36)
        btnAddMachine.TabIndex = 10
        btnAddMachine.Text = "+ Add Unit"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(978, 0)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 67)
        Label1.TabIndex = 11
        Label1.Text = "Sort by:"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' MachinesControl
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(15, 15, 15, 15)
        Name = "MachinesControl"
        Size = New Size(1282, 906)
        TableLayoutPanel1.ResumeLayout(False)
        Guna2ShadowPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmbStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents flpMachines As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Guna2ToggleSwitch1 As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents btnAddMachine As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConfigure As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRemoveMachine As Guna.UI2.WinForms.Guna2Button

End Class

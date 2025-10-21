<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigureMachineForm
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfigureMachineForm))
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        SplitContainer1 = New SplitContainer()
        lblUnitNumberText = New Label()
        lblUnitNumber = New Label()
        SplitContainer2 = New SplitContainer()
        lblWeightText = New Label()
        nudCapacity = New NumericUpDown()
        SplitContainer3 = New SplitContainer()
        Label1 = New Label()
        cboStatus = New ComboBox()
        Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Label2 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        btnsave = New Guna.UI2.WinForms.Guna2GradientButton()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.Panel2.SuspendLayout()
        SplitContainer2.SuspendLayout()
        CType(nudCapacity, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainer3, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer3.Panel1.SuspendLayout()
        SplitContainer3.Panel2.SuspendLayout()
        SplitContainer3.SuspendLayout()
        Guna2GradientPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Controls.Add(btnsave, 0, 3)
        TableLayoutPanel1.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel1.Controls.Add(SplitContainer2, 0, 1)
        TableLayoutPanel1.Controls.Add(SplitContainer3, 0, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 48)
        TableLayoutPanel1.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 26.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 22.4F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.8666649F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 17.0666676F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(319, 363)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(SplitContainer1)
        Panel1.Location = New Point(3, 4)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(313, 72)
        Panel1.TabIndex = 1
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.IsSplitterFixed = True
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Margin = New Padding(3, 4, 3, 4)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(lblUnitNumberText)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.BackColor = Color.Transparent
        SplitContainer1.Panel2.Controls.Add(lblUnitNumber)
        SplitContainer1.Size = New Size(313, 72)
        SplitContainer1.SplitterDistance = 148
        SplitContainer1.SplitterWidth = 5
        SplitContainer1.TabIndex = 0
        ' 
        ' lblUnitNumberText
        ' 
        lblUnitNumberText.BackColor = Color.Transparent
        lblUnitNumberText.Dock = DockStyle.Fill
        lblUnitNumberText.Font = New Font("Poppins", 9F)
        lblUnitNumberText.ForeColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        lblUnitNumberText.Location = New Point(0, 0)
        lblUnitNumberText.Name = "lblUnitNumberText"
        lblUnitNumberText.Size = New Size(148, 72)
        lblUnitNumberText.TabIndex = 0
        lblUnitNumberText.Text = "Unit #:"
        lblUnitNumberText.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblUnitNumber
        ' 
        lblUnitNumber.BackColor = Color.LightGray
        lblUnitNumber.Dock = DockStyle.Fill
        lblUnitNumber.Font = New Font("Poppins", 9F)
        lblUnitNumber.Location = New Point(0, 0)
        lblUnitNumber.Name = "lblUnitNumber"
        lblUnitNumber.Size = New Size(160, 72)
        lblUnitNumber.TabIndex = 0
        lblUnitNumber.Text = "Label2"
        lblUnitNumber.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' SplitContainer2
        ' 
        SplitContainer2.Dock = DockStyle.Fill
        SplitContainer2.IsSplitterFixed = True
        SplitContainer2.Location = New Point(3, 100)
        SplitContainer2.Margin = New Padding(3, 4, 3, 4)
        SplitContainer2.Name = "SplitContainer2"
        SplitContainer2.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer2.Panel1
        ' 
        SplitContainer2.Panel1.BackColor = Color.Transparent
        SplitContainer2.Panel1.Controls.Add(lblWeightText)
        ' 
        ' SplitContainer2.Panel2
        ' 
        SplitContainer2.Panel2.BackColor = Color.LightGray
        SplitContainer2.Panel2.Controls.Add(nudCapacity)
        SplitContainer2.Size = New Size(313, 73)
        SplitContainer2.SplitterDistance = 32
        SplitContainer2.SplitterWidth = 5
        SplitContainer2.TabIndex = 2
        ' 
        ' lblWeightText
        ' 
        lblWeightText.Anchor = AnchorStyles.Top
        lblWeightText.AutoSize = True
        lblWeightText.Font = New Font("Poppins", 9F)
        lblWeightText.Location = New Point(127, 0)
        lblWeightText.Name = "lblWeightText"
        lblWeightText.Size = New Size(65, 26)
        lblWeightText.TabIndex = 1
        lblWeightText.Text = "Weight"
        lblWeightText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' nudCapacity
        ' 
        nudCapacity.Anchor = AnchorStyles.None
        nudCapacity.Font = New Font("Poppins", 9F)
        nudCapacity.Location = New Point(113, 8)
        nudCapacity.Margin = New Padding(3, 4, 3, 4)
        nudCapacity.Name = "nudCapacity"
        nudCapacity.Size = New Size(96, 30)
        nudCapacity.TabIndex = 0
        ' 
        ' SplitContainer3
        ' 
        SplitContainer3.Dock = DockStyle.Fill
        SplitContainer3.IsSplitterFixed = True
        SplitContainer3.Location = New Point(3, 181)
        SplitContainer3.Margin = New Padding(3, 4, 3, 4)
        SplitContainer3.Name = "SplitContainer3"
        SplitContainer3.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer3.Panel1
        ' 
        SplitContainer3.Panel1.BackColor = Color.Transparent
        SplitContainer3.Panel1.Controls.Add(Label1)
        ' 
        ' SplitContainer3.Panel2
        ' 
        SplitContainer3.Panel2.BackColor = Color.LightGray
        SplitContainer3.Panel2.Controls.Add(cboStatus)
        SplitContainer3.Size = New Size(313, 114)
        SplitContainer3.SplitterDistance = 58
        SplitContainer3.SplitterWidth = 5
        SplitContainer3.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 9F)
        Label1.Location = New Point(133, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 26)
        Label1.TabIndex = 2
        Label1.Text = "Status"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' cboStatus
        ' 
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.FormattingEnabled = True
        cboStatus.Location = New Point(63, 4)
        cboStatus.Margin = New Padding(3, 4, 3, 4)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(192, 28)
        cboStatus.TabIndex = 0
        ' 
        ' Guna2GradientPanel1
        ' 
        Guna2GradientPanel1.BorderStyle = Drawing2D.DashStyle.Dash
        Guna2GradientPanel1.Controls.Add(Label2)
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges3
        Guna2GradientPanel1.FillColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        Guna2GradientPanel1.FillColor2 = Color.FromArgb(CByte(76), CByte(102), CByte(232))
        Guna2GradientPanel1.Location = New Point(3, 3)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2GradientPanel1.Size = New Size(319, 37)
        Guna2GradientPanel1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(66, 4)
        Label2.Name = "Label2"
        Label2.Size = New Size(209, 36)
        Label2.TabIndex = 5
        Label2.Text = "Configure Machine"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(Guna2GradientPanel1, 0, 0)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel1, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10.6024094F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 89.39759F))
        TableLayoutPanel2.Size = New Size(325, 415)
        TableLayoutPanel2.TabIndex = 6
        ' 
        ' btnsave
        ' 
        btnsave.Anchor = AnchorStyles.None
        btnsave.BorderRadius = 5
        btnsave.CustomizableEdges = CustomizableEdges1
        btnsave.DisabledState.BorderColor = Color.DarkGray
        btnsave.DisabledState.CustomBorderColor = Color.DarkGray
        btnsave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnsave.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnsave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnsave.FillColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        btnsave.FillColor2 = Color.FromArgb(CByte(76), CByte(102), CByte(232))
        btnsave.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnsave.ForeColor = Color.White
        btnsave.Location = New Point(112, 315)
        btnsave.Name = "btnsave"
        btnsave.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnsave.Size = New Size(94, 32)
        btnsave.TabIndex = 36
        btnsave.Text = "SAVE"
        ' 
        ' ConfigureMachineForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(325, 415)
        Controls.Add(TableLayoutPanel2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "ConfigureMachineForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Configure Form"
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel1.PerformLayout()
        SplitContainer2.Panel2.ResumeLayout(False)
        CType(SplitContainer2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.ResumeLayout(False)
        CType(nudCapacity, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer3.Panel1.ResumeLayout(False)
        SplitContainer3.Panel1.PerformLayout()
        SplitContainer3.Panel2.ResumeLayout(False)
        CType(SplitContainer3, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer3.ResumeLayout(False)
        Guna2GradientPanel1.ResumeLayout(False)
        Guna2GradientPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents lblUnitNumberText As Label
    Friend WithEvents lblUnitNumber As Label
    Friend WithEvents lblWeightText As Label
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents nudCapacity As NumericUpDown
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnsave As Guna.UI2.WinForms.Guna2GradientButton
End Class

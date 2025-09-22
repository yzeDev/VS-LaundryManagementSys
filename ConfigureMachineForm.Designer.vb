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
        TableLayoutPanel1 = New TableLayoutPanel()
        btnSave = New Button()
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
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(btnSave, 0, 3)
        TableLayoutPanel1.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel1.Controls.Add(SplitContainer2, 0, 1)
        TableLayoutPanel1.Controls.Add(SplitContainer3, 0, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Size = New Size(348, 322)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.None
        btnSave.Location = New Point(136, 269)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 1
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(SplitContainer1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(342, 74)
        Panel1.TabIndex = 1
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.IsSplitterFixed = True
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(lblUnitNumberText)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(lblUnitNumber)
        SplitContainer1.Size = New Size(342, 74)
        SplitContainer1.SplitterDistance = 170
        SplitContainer1.TabIndex = 0
        ' 
        ' lblUnitNumberText
        ' 
        lblUnitNumberText.AutoSize = True
        lblUnitNumberText.Location = New Point(130, 37)
        lblUnitNumberText.Name = "lblUnitNumberText"
        lblUnitNumberText.Size = New Size(42, 15)
        lblUnitNumberText.TabIndex = 0
        lblUnitNumberText.Text = "Unit #:"
        ' 
        ' lblUnitNumber
        ' 
        lblUnitNumber.AutoSize = True
        lblUnitNumber.Location = New Point(-1, 37)
        lblUnitNumber.Name = "lblUnitNumber"
        lblUnitNumber.Size = New Size(41, 15)
        lblUnitNumber.TabIndex = 0
        lblUnitNumber.Text = "Label2"
        ' 
        ' SplitContainer2
        ' 
        SplitContainer2.Dock = DockStyle.Fill
        SplitContainer2.IsSplitterFixed = True
        SplitContainer2.Location = New Point(3, 83)
        SplitContainer2.Name = "SplitContainer2"
        SplitContainer2.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer2.Panel1
        ' 
        SplitContainer2.Panel1.Controls.Add(lblWeightText)
        ' 
        ' SplitContainer2.Panel2
        ' 
        SplitContainer2.Panel2.Controls.Add(nudCapacity)
        SplitContainer2.Size = New Size(342, 74)
        SplitContainer2.SplitterDistance = 35
        SplitContainer2.TabIndex = 2
        ' 
        ' lblWeightText
        ' 
        lblWeightText.Anchor = AnchorStyles.None
        lblWeightText.AutoSize = True
        lblWeightText.Location = New Point(151, 20)
        lblWeightText.Name = "lblWeightText"
        lblWeightText.Size = New Size(45, 15)
        lblWeightText.TabIndex = 1
        lblWeightText.Text = "Weight"
        lblWeightText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' nudCapacity
        ' 
        nudCapacity.Anchor = AnchorStyles.None
        nudCapacity.Location = New Point(134, 9)
        nudCapacity.Name = "nudCapacity"
        nudCapacity.Size = New Size(84, 23)
        nudCapacity.TabIndex = 0
        ' 
        ' SplitContainer3
        ' 
        SplitContainer3.Dock = DockStyle.Fill
        SplitContainer3.IsSplitterFixed = True
        SplitContainer3.Location = New Point(3, 163)
        SplitContainer3.Name = "SplitContainer3"
        SplitContainer3.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer3.Panel1
        ' 
        SplitContainer3.Panel1.Controls.Add(Label1)
        ' 
        ' SplitContainer3.Panel2
        ' 
        SplitContainer3.Panel2.Controls.Add(cboStatus)
        SplitContainer3.Size = New Size(342, 74)
        SplitContainer3.SplitterDistance = 30
        SplitContainer3.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Location = New Point(151, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 2
        Label1.Text = "Status"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cboStatus
        ' 
        cboStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.FormattingEnabled = True
        cboStatus.Location = New Point(130, 14)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(84, 23)
        cboStatus.TabIndex = 0
        ' 
        ' ConfigureMachineForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(348, 322)
        Controls.Add(TableLayoutPanel1)
        Name = "ConfigureMachineForm"
        Text = "ConfigureMachineForm"
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
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
    Friend WithEvents btnSave As Button
End Class

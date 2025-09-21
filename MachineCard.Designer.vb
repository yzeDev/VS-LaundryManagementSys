<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MachineCard
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
        lblWeight = New Label()
        lblUnit = New Label()
        cmbStatus = New ComboBox()
        picMachine = New PictureBox()
        TableLayoutPanel1.SuspendLayout()
        CType(picMachine, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(lblWeight, 0, 2)
        TableLayoutPanel1.Controls.Add(lblUnit, 0, 1)
        TableLayoutPanel1.Controls.Add(cmbStatus, 0, 3)
        TableLayoutPanel1.Controls.Add(picMachine, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 62.6174049F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.460865F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.460865F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.460865F))
        TableLayoutPanel1.Size = New Size(198, 248)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' lblWeight
        ' 
        lblWeight.AutoSize = True
        lblWeight.Dock = DockStyle.Fill
        lblWeight.Location = New Point(3, 185)
        lblWeight.Name = "lblWeight"
        lblWeight.Size = New Size(192, 30)
        lblWeight.TabIndex = 2
        lblWeight.Text = "Weight:"
        lblWeight.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblUnit
        ' 
        lblUnit.AutoSize = True
        lblUnit.Dock = DockStyle.Fill
        lblUnit.Location = New Point(3, 155)
        lblUnit.Name = "lblUnit"
        lblUnit.Size = New Size(192, 30)
        lblUnit.TabIndex = 0
        lblUnit.Text = "Unit"
        lblUnit.TextAlign = ContentAlignment.TopCenter
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Available", "In-Use", "Damaged"})
        cmbStatus.Location = New Point(3, 218)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(192, 23)
        cmbStatus.TabIndex = 3
        ' 
        ' picMachine
        ' 
        picMachine.Dock = DockStyle.Fill
        picMachine.Location = New Point(3, 3)
        picMachine.Name = "picMachine"
        picMachine.Size = New Size(192, 149)
        picMachine.TabIndex = 4
        picMachine.TabStop = False
        ' 
        ' MachineCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BorderStyle = BorderStyle.FixedSingle
        Controls.Add(TableLayoutPanel1)
        Name = "MachineCard"
        Size = New Size(198, 248)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(picMachine, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblUnit As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents picMachine As PictureBox

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MachinesControl
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
        btnConfigure = New Button()
        btnRemoveMachine = New Button()
        btnAddMachine = New Button()
        Label1 = New Label()
        flpMachines = New FlowLayoutPanel()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 120F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel1.Controls.Add(flpMachines, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(500, 500)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnConfigure)
        Panel1.Controls.Add(btnRemoveMachine)
        Panel1.Controls.Add(btnAddMachine)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(114, 244)
        Panel1.TabIndex = 0
        ' 
        ' btnConfigure
        ' 
        btnConfigure.Enabled = False
        btnConfigure.Location = New Point(3, 91)
        btnConfigure.Name = "btnConfigure"
        btnConfigure.Size = New Size(108, 23)
        btnConfigure.TabIndex = 3
        btnConfigure.Text = "Configure"
        btnConfigure.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveMachine
        ' 
        btnRemoveMachine.Location = New Point(3, 62)
        btnRemoveMachine.Name = "btnRemoveMachine"
        btnRemoveMachine.Size = New Size(111, 23)
        btnRemoveMachine.TabIndex = 2
        btnRemoveMachine.Text = "- Remove Unit"
        btnRemoveMachine.UseVisualStyleBackColor = True
        ' 
        ' btnAddMachine
        ' 
        btnAddMachine.Location = New Point(3, 33)
        btnAddMachine.Name = "btnAddMachine"
        btnAddMachine.Size = New Size(108, 23)
        btnAddMachine.TabIndex = 1
        btnAddMachine.Text = "+ Add Unit"
        btnAddMachine.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 17)
        Label1.TabIndex = 0
        Label1.Text = "Machines: (#)"
        ' 
        ' flpMachines
        ' 
        flpMachines.AutoScroll = True
        flpMachines.Dock = DockStyle.Fill
        flpMachines.Location = New Point(123, 3)
        flpMachines.Name = "flpMachines"
        TableLayoutPanel1.SetRowSpan(flpMachines, 2)
        flpMachines.Size = New Size(374, 494)
        flpMachines.TabIndex = 1
        ' 
        ' MachinesControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "MachinesControl"
        Size = New Size(500, 500)
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConfigure As Button
    Friend WithEvents btnRemoveMachine As Button
    Friend WithEvents btnAddMachine As Button
    Friend WithEvents flpMachines As FlowLayoutPanel

End Class

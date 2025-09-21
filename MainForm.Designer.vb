<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        TableLayoutPanel1 = New TableLayoutPanel()
        lblTitle = New Label()
        btnMachines = New Button()
        btnTransactions = New Button()
        btnStats = New Button()
        btnOptions = New Button()
        MainPanel = New Panel()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 130F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.Controls.Add(lblTitle, 0, 0)
        TableLayoutPanel1.Controls.Add(btnMachines, 0, 1)
        TableLayoutPanel1.Controls.Add(btnTransactions, 0, 2)
        TableLayoutPanel1.Controls.Add(btnStats, 0, 3)
        TableLayoutPanel1.Controls.Add(btnOptions, 0, 4)
        TableLayoutPanel1.Controls.Add(MainPanel, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15.0657682F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 21.2335587F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 21.2335587F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 21.2335587F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 21.2335587F))
        TableLayoutPanel1.Size = New Size(800, 450)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(lblTitle, 2)
        lblTitle.Dock = DockStyle.Fill
        lblTitle.Location = New Point(3, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(794, 67)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Laundry Management System"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnMachines
        ' 
        btnMachines.Dock = DockStyle.Fill
        btnMachines.Location = New Point(3, 70)
        btnMachines.Name = "btnMachines"
        btnMachines.Size = New Size(124, 89)
        btnMachines.TabIndex = 1
        btnMachines.Text = "Machines"
        btnMachines.UseVisualStyleBackColor = True
        ' 
        ' btnTransactions
        ' 
        btnTransactions.Dock = DockStyle.Fill
        btnTransactions.Location = New Point(3, 165)
        btnTransactions.Name = "btnTransactions"
        btnTransactions.Size = New Size(124, 89)
        btnTransactions.TabIndex = 2
        btnTransactions.Text = "Transactions"
        btnTransactions.UseVisualStyleBackColor = True
        ' 
        ' btnStats
        ' 
        btnStats.Dock = DockStyle.Fill
        btnStats.Location = New Point(3, 260)
        btnStats.Name = "btnStats"
        btnStats.Size = New Size(124, 89)
        btnStats.TabIndex = 3
        btnStats.Text = "Statistics"
        btnStats.UseVisualStyleBackColor = True
        ' 
        ' btnOptions
        ' 
        btnOptions.Dock = DockStyle.Fill
        btnOptions.Location = New Point(3, 355)
        btnOptions.Name = "btnOptions"
        btnOptions.Size = New Size(124, 92)
        btnOptions.TabIndex = 4
        btnOptions.Text = "Options"
        btnOptions.UseVisualStyleBackColor = True
        ' 
        ' MainPanel
        ' 
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(133, 70)
        MainPanel.Name = "MainPanel"
        TableLayoutPanel1.SetRowSpan(MainPanel, 4)
        MainPanel.Size = New Size(664, 377)
        MainPanel.TabIndex = 5
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        Name = "MainForm"
        Text = "Laundry Management System"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnMachines As Button
    Friend WithEvents btnTransactions As Button
    Friend WithEvents btnStats As Button
    Friend WithEvents btnOptions As Button
    Friend WithEvents MainPanel As Panel

End Class

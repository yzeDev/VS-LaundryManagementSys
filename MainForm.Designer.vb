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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Panel2 = New Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        btnOptions = New Button()
        btnStats = New Button()
        btnTransactions = New Button()
        btnMachines = New Button()
        btnDashboard = New Button()
        MainPanel = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel2.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(57), CByte(88), CByte(134))
        Panel2.Controls.Add(TableLayoutPanel2)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(4, 4)
        Panel2.Margin = New Padding(4)
        Panel2.Name = "Panel2"
        TableLayoutPanel1.SetRowSpan(Panel2, 5)
        Panel2.Size = New Size(117, 693)
        Panel2.TabIndex = 7
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(btnOptions, 0, 4)
        TableLayoutPanel2.Controls.Add(btnStats, 0, 3)
        TableLayoutPanel2.Controls.Add(btnTransactions, 0, 2)
        TableLayoutPanel2.Controls.Add(btnMachines, 0, 1)
        TableLayoutPanel2.Controls.Add(btnDashboard, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Margin = New Padding(4)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 5
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.Size = New Size(117, 693)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' btnOptions
        ' 
        btnOptions.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnOptions.BackgroundImage = My.Resources.Resources.logos_5
        btnOptions.BackgroundImageLayout = ImageLayout.Zoom
        btnOptions.Dock = DockStyle.Fill
        btnOptions.FlatAppearance.BorderSize = 0
        btnOptions.FlatStyle = FlatStyle.Flat
        btnOptions.Location = New Point(4, 556)
        btnOptions.Margin = New Padding(4)
        btnOptions.Name = "btnOptions"
        btnOptions.Size = New Size(109, 133)
        btnOptions.TabIndex = 4
        btnOptions.TabStop = False
        btnOptions.UseVisualStyleBackColor = True
        ' 
        ' btnStats
        ' 
        btnStats.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnStats.BackgroundImage = My.Resources.Resources.logos_4
        btnStats.BackgroundImageLayout = ImageLayout.Zoom
        btnStats.Dock = DockStyle.Fill
        btnStats.FlatAppearance.BorderSize = 0
        btnStats.FlatStyle = FlatStyle.Flat
        btnStats.Location = New Point(4, 418)
        btnStats.Margin = New Padding(4)
        btnStats.Name = "btnStats"
        btnStats.Size = New Size(109, 130)
        btnStats.TabIndex = 3
        btnStats.TabStop = False
        btnStats.UseVisualStyleBackColor = True
        ' 
        ' btnTransactions
        ' 
        btnTransactions.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnTransactions.BackgroundImage = My.Resources.Resources.logos_3
        btnTransactions.BackgroundImageLayout = ImageLayout.Zoom
        btnTransactions.Dock = DockStyle.Fill
        btnTransactions.FlatAppearance.BorderSize = 0
        btnTransactions.FlatStyle = FlatStyle.Flat
        btnTransactions.Location = New Point(4, 280)
        btnTransactions.Margin = New Padding(4)
        btnTransactions.Name = "btnTransactions"
        btnTransactions.Size = New Size(109, 130)
        btnTransactions.TabIndex = 2
        btnTransactions.TabStop = False
        btnTransactions.UseVisualStyleBackColor = True
        ' 
        ' btnMachines
        ' 
        btnMachines.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnMachines.BackgroundImage = My.Resources.Resources.logos_2
        btnMachines.BackgroundImageLayout = ImageLayout.Zoom
        btnMachines.Dock = DockStyle.Fill
        btnMachines.FlatAppearance.BorderSize = 0
        btnMachines.FlatStyle = FlatStyle.Flat
        btnMachines.Location = New Point(4, 142)
        btnMachines.Margin = New Padding(4)
        btnMachines.Name = "btnMachines"
        btnMachines.Size = New Size(109, 130)
        btnMachines.TabIndex = 1
        btnMachines.TabStop = False
        btnMachines.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnDashboard.BackColor = Color.FromArgb(CByte(57), CByte(88), CByte(134))
        btnDashboard.BackgroundImage = My.Resources.Resources.logos_1
        btnDashboard.BackgroundImageLayout = ImageLayout.Zoom
        btnDashboard.Dock = DockStyle.Fill
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Location = New Point(4, 4)
        btnDashboard.Margin = New Padding(4)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(109, 130)
        btnDashboard.TabIndex = 5
        btnDashboard.TabStop = False
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' MainPanel
        ' 
        MainPanel.AutoScroll = True
        MainPanel.AutoSize = True
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(129, 4)
        MainPanel.Margin = New Padding(4)
        MainPanel.Name = "MainPanel"
        TableLayoutPanel1.SetRowSpan(MainPanel, 5)
        MainPanel.Size = New Size(1222, 693)
        MainPanel.TabIndex = 5
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 125F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.Controls.Add(MainPanel, 1, 0)
        TableLayoutPanel1.Controls.Add(Panel2, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15.0657663F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 21.2335587F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 21.2335587F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 21.2335587F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 21.2335587F))
        TableLayoutPanel1.Size = New Size(1355, 701)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1355, 701)
        Controls.Add(TableLayoutPanel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        MinimumSize = New Size(1120, 613)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Laundry Management System"
        Panel2.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnOptions As Button
    Friend WithEvents btnStats As Button
    Friend WithEvents btnTransactions As Button
    Friend WithEvents btnMachines As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MainPanel As Panel

End Class

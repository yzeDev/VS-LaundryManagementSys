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
        btnDashboard = New Button()
        btnOptions = New Button()
        btnStats = New Button()
        btnTransactions = New Button()
        btnMachines = New Button()
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
        Panel2.Location = New Point(3, 3)
        Panel2.Name = "Panel2"
        TableLayoutPanel1.SetRowSpan(Panel2, 5)
        Panel2.Size = New Size(94, 555)
        Panel2.TabIndex = 7
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(btnDashboard, 0, 0)
        TableLayoutPanel2.Controls.Add(btnOptions, 0, 4)
        TableLayoutPanel2.Controls.Add(btnStats, 0, 3)
        TableLayoutPanel2.Controls.Add(btnTransactions, 0, 2)
        TableLayoutPanel2.Controls.Add(btnMachines, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 5
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.Size = New Size(94, 555)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Anchor = AnchorStyles.None
        btnDashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnDashboard.BackgroundImage = My.Resources.Resources._1
        btnDashboard.BackgroundImageLayout = ImageLayout.Zoom
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Location = New Point(12, 20)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(70, 70)
        btnDashboard.TabIndex = 5
        btnDashboard.TabStop = False
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' btnOptions
        ' 
        btnOptions.Anchor = AnchorStyles.None
        btnOptions.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnOptions.BackgroundImage = My.Resources.Resources._5
        btnOptions.BackgroundImageLayout = ImageLayout.Zoom
        btnOptions.FlatAppearance.BorderSize = 0
        btnOptions.FlatStyle = FlatStyle.Flat
        btnOptions.Location = New Point(12, 464)
        btnOptions.Name = "btnOptions"
        btnOptions.Size = New Size(70, 70)
        btnOptions.TabIndex = 4
        btnOptions.TabStop = False
        btnOptions.UseVisualStyleBackColor = True
        ' 
        ' btnStats
        ' 
        btnStats.Anchor = AnchorStyles.None
        btnStats.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnStats.BackgroundImage = My.Resources.Resources._4
        btnStats.BackgroundImageLayout = ImageLayout.Zoom
        btnStats.FlatAppearance.BorderSize = 0
        btnStats.FlatStyle = FlatStyle.Flat
        btnStats.Location = New Point(12, 353)
        btnStats.Name = "btnStats"
        btnStats.Size = New Size(70, 70)
        btnStats.TabIndex = 3
        btnStats.TabStop = False
        btnStats.UseVisualStyleBackColor = True
        ' 
        ' btnTransactions
        ' 
        btnTransactions.Anchor = AnchorStyles.None
        btnTransactions.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnTransactions.BackgroundImage = My.Resources.Resources._3
        btnTransactions.BackgroundImageLayout = ImageLayout.Zoom
        btnTransactions.FlatAppearance.BorderSize = 0
        btnTransactions.FlatStyle = FlatStyle.Flat
        btnTransactions.Location = New Point(12, 242)
        btnTransactions.Name = "btnTransactions"
        btnTransactions.Size = New Size(70, 70)
        btnTransactions.TabIndex = 2
        btnTransactions.TabStop = False
        btnTransactions.UseVisualStyleBackColor = True
        ' 
        ' btnMachines
        ' 
        btnMachines.Anchor = AnchorStyles.None
        btnMachines.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnMachines.BackgroundImage = My.Resources.Resources._2
        btnMachines.BackgroundImageLayout = ImageLayout.Zoom
        btnMachines.FlatAppearance.BorderSize = 0
        btnMachines.FlatStyle = FlatStyle.Flat
        btnMachines.Location = New Point(12, 131)
        btnMachines.Name = "btnMachines"
        btnMachines.Size = New Size(70, 70)
        btnMachines.TabIndex = 1
        btnMachines.TabStop = False
        btnMachines.UseVisualStyleBackColor = True
        ' 
        ' MainPanel
        ' 
        MainPanel.AutoScroll = True
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(103, 3)
        MainPanel.Name = "MainPanel"
        TableLayoutPanel1.SetRowSpan(MainPanel, 5)
        MainPanel.Size = New Size(978, 555)
        MainPanel.TabIndex = 5
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.Controls.Add(MainPanel, 1, 0)
        TableLayoutPanel1.Controls.Add(Panel2, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15.0657663F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 21.2335587F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 21.2335587F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 21.2335587F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 21.2335587F))
        TableLayoutPanel1.Size = New Size(1084, 561)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1084, 561)
        Controls.Add(TableLayoutPanel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(900, 500)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Laundry Management System"
        Panel2.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
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

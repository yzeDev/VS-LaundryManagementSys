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
        btnOptions = New Button()
        btnStats = New Button()
        btnTransactions = New Button()
        btnMachines = New Button()
        btnDashboard = New Button()
        MainPanel = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnOptions
        ' 
        btnOptions.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnOptions.BackColor = Color.White
        btnOptions.BackgroundImageLayout = ImageLayout.Zoom
        btnOptions.FlatAppearance.BorderSize = 0
        btnOptions.FlatStyle = FlatStyle.Flat
        btnOptions.Location = New Point(0, 279)
        btnOptions.Margin = New Padding(5)
        btnOptions.Name = "btnOptions"
        btnOptions.Size = New Size(144, 60)
        btnOptions.TabIndex = 4
        btnOptions.TabStop = False
        btnOptions.Text = "Options"
        btnOptions.UseVisualStyleBackColor = False
        ' 
        ' btnStats
        ' 
        btnStats.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnStats.BackColor = Color.White
        btnStats.BackgroundImageLayout = ImageLayout.Zoom
        btnStats.FlatAppearance.BorderSize = 0
        btnStats.FlatStyle = FlatStyle.Flat
        btnStats.Location = New Point(0, 209)
        btnStats.Margin = New Padding(5)
        btnStats.Name = "btnStats"
        btnStats.Size = New Size(144, 60)
        btnStats.TabIndex = 3
        btnStats.TabStop = False
        btnStats.Text = "Statistics"
        btnStats.UseVisualStyleBackColor = False
        ' 
        ' btnTransactions
        ' 
        btnTransactions.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnTransactions.BackColor = Color.White
        btnTransactions.BackgroundImageLayout = ImageLayout.Zoom
        btnTransactions.FlatAppearance.BorderSize = 0
        btnTransactions.FlatStyle = FlatStyle.Flat
        btnTransactions.Location = New Point(0, 139)
        btnTransactions.Margin = New Padding(5)
        btnTransactions.Name = "btnTransactions"
        btnTransactions.Size = New Size(144, 60)
        btnTransactions.TabIndex = 2
        btnTransactions.TabStop = False
        btnTransactions.Text = "Transactions"
        btnTransactions.UseVisualStyleBackColor = False
        ' 
        ' btnMachines
        ' 
        btnMachines.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnMachines.BackColor = Color.White
        btnMachines.BackgroundImageLayout = ImageLayout.Zoom
        btnMachines.FlatAppearance.BorderSize = 0
        btnMachines.FlatStyle = FlatStyle.Flat
        btnMachines.Location = New Point(0, 69)
        btnMachines.Margin = New Padding(5)
        btnMachines.Name = "btnMachines"
        btnMachines.Size = New Size(144, 60)
        btnMachines.TabIndex = 1
        btnMachines.TabStop = False
        btnMachines.Text = "Machines"
        btnMachines.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnDashboard.BackColor = Color.White
        btnDashboard.BackgroundImageLayout = ImageLayout.Zoom
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Location = New Point(0, -1)
        btnDashboard.Margin = New Padding(5)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(144, 60)
        btnDashboard.TabIndex = 5
        btnDashboard.TabStop = False
        btnDashboard.Text = "Home"
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' MainPanel
        ' 
        MainPanel.AutoScroll = True
        MainPanel.AutoSize = True
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(155, 5)
        MainPanel.Margin = New Padding(5)
        MainPanel.Name = "MainPanel"
        TableLayoutPanel1.SetRowSpan(MainPanel, 2)
        MainPanel.Size = New Size(1466, 831)
        MainPanel.TabIndex = 5
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 150F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.Controls.Add(MainPanel, 1, 0)
        TableLayoutPanel1.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel2, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(5)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.92296F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 89.077034F))
        TableLayoutPanel1.Size = New Size(1626, 841)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(144, 85)
        Panel1.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 85)
        Label1.TabIndex = 0
        Label1.Text = "ADMIN"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnOptions)
        Panel2.Controls.Add(btnDashboard)
        Panel2.Controls.Add(btnStats)
        Panel2.Controls.Add(btnMachines)
        Panel2.Controls.Add(btnTransactions)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(3, 94)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(144, 744)
        Panel2.TabIndex = 9
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1626, 841)
        Controls.Add(TableLayoutPanel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5)
        MinimumSize = New Size(1340, 724)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Laundry Management System"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnOptions As Button
    Friend WithEvents btnStats As Button
    Friend WithEvents btnTransactions As Button
    Friend WithEvents btnMachines As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MainPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel

End Class

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
        TableLayoutPanel1 = New TableLayoutPanel()
        lblTitle = New Label()
        MainPanel = New Panel()
        Panel1 = New Panel()
        btnDashboard = New Button()
        btnMachines = New Button()
        btnStats = New Button()
        btnTransactions = New Button()
        btnOptions = New Button()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 130F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.Controls.Add(lblTitle, 0, 0)
        TableLayoutPanel1.Controls.Add(MainPanel, 1, 1)
        TableLayoutPanel1.Controls.Add(Panel1, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15.0657682F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 21.2335587F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 21.2335587F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 21.2335587F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 21.2335587F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(1084, 561)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(lblTitle, 2)
        lblTitle.Dock = DockStyle.Fill
        lblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(3, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(1078, 84)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Laundry Management System"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MainPanel
        ' 
        MainPanel.AutoScroll = True
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(133, 87)
        MainPanel.Name = "MainPanel"
        TableLayoutPanel1.SetRowSpan(MainPanel, 4)
        MainPanel.Size = New Size(948, 471)
        MainPanel.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnDashboard)
        Panel1.Controls.Add(btnMachines)
        Panel1.Controls.Add(btnStats)
        Panel1.Controls.Add(btnTransactions)
        Panel1.Controls.Add(btnOptions)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 87)
        Panel1.Name = "Panel1"
        TableLayoutPanel1.SetRowSpan(Panel1, 2)
        Panel1.Size = New Size(124, 232)
        Panel1.TabIndex = 6
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Location = New Point(3, 0)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(121, 36)
        btnDashboard.TabIndex = 5
        btnDashboard.TabStop = False
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' btnMachines
        ' 
        btnMachines.Location = New Point(3, 42)
        btnMachines.Name = "btnMachines"
        btnMachines.Size = New Size(121, 36)
        btnMachines.TabIndex = 1
        btnMachines.TabStop = False
        btnMachines.Text = "Machines"
        btnMachines.UseVisualStyleBackColor = True
        ' 
        ' btnStats
        ' 
        btnStats.Location = New Point(3, 122)
        btnStats.Name = "btnStats"
        btnStats.Size = New Size(121, 36)
        btnStats.TabIndex = 3
        btnStats.TabStop = False
        btnStats.Text = "Statistics"
        btnStats.UseVisualStyleBackColor = True
        ' 
        ' btnTransactions
        ' 
        btnTransactions.Location = New Point(3, 84)
        btnTransactions.Name = "btnTransactions"
        btnTransactions.Size = New Size(121, 36)
        btnTransactions.TabIndex = 2
        btnTransactions.TabStop = False
        btnTransactions.Text = "Transactions"
        btnTransactions.UseVisualStyleBackColor = True
        ' 
        ' btnOptions
        ' 
        btnOptions.Location = New Point(3, 164)
        btnOptions.Name = "btnOptions"
        btnOptions.Size = New Size(121, 36)
        btnOptions.TabIndex = 4
        btnOptions.TabStop = False
        btnOptions.Text = "Options"
        btnOptions.UseVisualStyleBackColor = True
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
        Text = "Laundry Management System"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnMachines As Button
    Friend WithEvents btnTransactions As Button
    Friend WithEvents btnStats As Button
    Friend WithEvents btnOptions As Button
    Friend WithEvents MainPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDashboard As Button

End Class

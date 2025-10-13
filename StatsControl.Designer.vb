<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatsControl
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
        Label1 = New Label()
        lblStatistics = New Label()
        Panel2 = New Panel()
        cmbPeriod = New ComboBox()
        Label2 = New Label()
        Panel3 = New Panel()
        dtpEndDate = New DateTimePicker()
        Label3 = New Label()
        Panel4 = New Panel()
        Label4 = New Label()
        Panel5 = New Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        Panel8 = New Panel()
        lblOrderValue = New Label()
        Label16 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Panel7 = New Panel()
        lblTotalRev = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label12 = New Label()
        Panel6 = New Panel()
        lblTotalOrder = New Label()
        Label7 = New Label()
        Label14 = New Label()
        Label8 = New Label()
        Panel9 = New Panel()
        TableLayoutPanel3 = New TableLayoutPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        Panel11 = New Panel()
        Panel10 = New Panel()
        TextBox1 = New TextBox()
        Label18 = New Label()
        Panel12 = New Panel()
        Label15 = New Label()
        Panel13 = New Panel()
        TextBox2 = New TextBox()
        Label19 = New Label()
        statspanel = New Panel()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        Panel8.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel9.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        Panel11.SuspendLayout()
        Panel10.SuspendLayout()
        Panel12.SuspendLayout()
        Panel13.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel2, 0, 1)
        TableLayoutPanel1.Controls.Add(Panel3, 1, 1)
        TableLayoutPanel1.Controls.Add(Panel4, 0, 2)
        TableLayoutPanel1.Controls.Add(Panel5, 0, 3)
        TableLayoutPanel1.Controls.Add(Panel9, 0, 4)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 17.9148312F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5.28634357F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 6.46108675F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 17.9148312F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 52.42291F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0F))
        TableLayoutPanel1.Size = New Size(900, 681)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        TableLayoutPanel1.SetColumnSpan(Panel1, 2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lblStatistics)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(894, 116)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(590, 21)
        Label1.TabIndex = 2
        Label1.Text = "View sales trends, order volumes, and revenue breakdowns across different periods."
        ' 
        ' lblStatistics
        ' 
        lblStatistics.AutoSize = True
        lblStatistics.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatistics.Location = New Point(-3, -3)
        lblStatistics.Name = "lblStatistics"
        lblStatistics.Size = New Size(151, 45)
        lblStatistics.TabIndex = 1
        lblStatistics.Text = "Statistics"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(cmbPeriod)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(3, 125)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(444, 29)
        Panel2.TabIndex = 1
        ' 
        ' cmbPeriod
        ' 
        cmbPeriod.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbPeriod.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbPeriod.FormattingEnabled = True
        cmbPeriod.Location = New Point(196, 2)
        cmbPeriod.Name = "cmbPeriod"
        cmbPeriod.Size = New Size(121, 21)
        cmbPeriod.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Location = New Point(146, 7)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 15)
        Label2.TabIndex = 0
        Label2.Text = "Period:"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(dtpEndDate)
        Panel3.Controls.Add(Label3)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(453, 125)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(444, 30)
        Panel3.TabIndex = 2
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Location = New Point(223, 0)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(218, 23)
        dtpEndDate.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(157, 5)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 0
        Label3.Text = "End Date: "
        ' 
        ' Panel4
        ' 
        TableLayoutPanel1.SetColumnSpan(Panel4, 2)
        Panel4.Controls.Add(Label4)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(3, 161)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(894, 38)
        Panel4.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(0, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 30)
        Label4.TabIndex = 0
        Label4.Text = "Overview"
        ' 
        ' Panel5
        ' 
        TableLayoutPanel1.SetColumnSpan(Panel5, 2)
        Panel5.Controls.Add(TableLayoutPanel2)
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(3, 205)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(894, 116)
        Panel5.TabIndex = 4
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.Controls.Add(Panel8, 2, 0)
        TableLayoutPanel2.Controls.Add(Panel7, 0, 0)
        TableLayoutPanel2.Controls.Add(Panel6, 1, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0F))
        TableLayoutPanel2.Size = New Size(894, 116)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' Panel8
        ' 
        Panel8.BorderStyle = BorderStyle.FixedSingle
        Panel8.Controls.Add(lblOrderValue)
        Panel8.Controls.Add(Label16)
        Panel8.Controls.Add(Label9)
        Panel8.Controls.Add(Label10)
        Panel8.Dock = DockStyle.Fill
        Panel8.Location = New Point(597, 3)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(294, 110)
        Panel8.TabIndex = 2
        ' 
        ' lblOrderValue
        ' 
        lblOrderValue.AutoSize = True
        lblOrderValue.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOrderValue.Location = New Point(-1, 33)
        lblOrderValue.Name = "lblOrderValue"
        lblOrderValue.Size = New Size(89, 37)
        lblOrderValue.TabIndex = 7
        lblOrderValue.Text = "₱ 100"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 8.25F)
        Label16.Location = New Point(-1, 71)
        Label16.Name = "Label16"
        Label16.Size = New Size(143, 13)
        Label16.TabIndex = 6
        Label16.Text = "Revenue Effieciency Metric"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        Label9.Location = New Point(-1, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(182, 20)
        Label9.TabIndex = 0
        Label9.Text = "AVERAGE ORDER VALUE"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 8.25F)
        Label10.Location = New Point(-1, 20)
        Label10.Name = "Label10"
        Label10.Size = New Size(129, 13)
        Label10.TabIndex = 1
        Label10.Text = "Per Transaction Average"
        ' 
        ' Panel7
        ' 
        Panel7.BorderStyle = BorderStyle.FixedSingle
        Panel7.Controls.Add(lblTotalRev)
        Panel7.Controls.Add(Label5)
        Panel7.Controls.Add(Label6)
        Panel7.Controls.Add(Label12)
        Panel7.Dock = DockStyle.Fill
        Panel7.Location = New Point(3, 3)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(291, 110)
        Panel7.TabIndex = 1
        ' 
        ' lblTotalRev
        ' 
        lblTotalRev.AutoSize = True
        lblTotalRev.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalRev.Location = New Point(-1, 34)
        lblTotalRev.Name = "lblTotalRev"
        lblTotalRev.Size = New Size(89, 37)
        lblTotalRev.TabIndex = 3
        lblTotalRev.Text = "₱ 100"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(-1, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(133, 21)
        Label5.TabIndex = 2
        Label5.Text = "TOTAL REVENUE"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 8.25F)
        Label6.Location = New Point(-1, 21)
        Label6.Name = "Label6"
        Label6.Size = New Size(122, 13)
        Label6.TabIndex = 1
        Label6.Text = "Service + Delivery Fees"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 8.25F)
        Label12.Location = New Point(-1, 71)
        Label12.Name = "Label12"
        Label12.Size = New Size(157, 13)
        Label12.TabIndex = 4
        Label12.Text = "All revenue for the past week"
        ' 
        ' Panel6
        ' 
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(lblTotalOrder)
        Panel6.Controls.Add(Label7)
        Panel6.Controls.Add(Label14)
        Panel6.Controls.Add(Label8)
        Panel6.Dock = DockStyle.Fill
        Panel6.Location = New Point(300, 3)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(291, 110)
        Panel6.TabIndex = 0
        ' 
        ' lblTotalOrder
        ' 
        lblTotalOrder.AutoSize = True
        lblTotalOrder.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalOrder.Location = New Point(-1, 33)
        lblTotalOrder.Name = "lblTotalOrder"
        lblTotalOrder.Size = New Size(89, 37)
        lblTotalOrder.TabIndex = 5
        lblTotalOrder.Text = "₱ 100"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        Label7.Location = New Point(-1, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(116, 20)
        Label7.TabIndex = 0
        Label7.Text = "TOTAL ORDERS"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 8.25F)
        Label14.Location = New Point(-1, 71)
        Label14.Name = "Label14"
        Label14.Size = New Size(118, 13)
        Label14.TabIndex = 5
        Label14.Text = "Business Activity Level"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 8.25F)
        Label8.Location = New Point(-1, 20)
        Label8.Name = "Label8"
        Label8.Size = New Size(130, 13)
        Label8.TabIndex = 1
        Label8.Text = "Completed Transactions"
        ' 
        ' Panel9
        ' 
        TableLayoutPanel1.SetColumnSpan(Panel9, 2)
        Panel9.Controls.Add(TableLayoutPanel3)
        Panel9.Dock = DockStyle.Fill
        Panel9.Location = New Point(3, 327)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(894, 351)
        Panel9.TabIndex = 5
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 66.6666641F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel3.Controls.Add(TableLayoutPanel4, 1, 0)
        TableLayoutPanel3.Controls.Add(statspanel, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel3.Size = New Size(894, 351)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel4.Controls.Add(Panel11, 0, 0)
        TableLayoutPanel4.Controls.Add(Panel13, 0, 2)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(598, 3)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 3
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel4.Size = New Size(293, 345)
        TableLayoutPanel4.TabIndex = 0
        ' 
        ' Panel11
        ' 
        Panel11.Controls.Add(Panel10)
        Panel11.Controls.Add(Panel12)
        Panel11.Dock = DockStyle.Fill
        Panel11.Location = New Point(3, 3)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(287, 156)
        Panel11.TabIndex = 1
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.FromArgb(CByte(102), CByte(204), CByte(153))
        Panel10.BorderStyle = BorderStyle.FixedSingle
        Panel10.Controls.Add(TextBox1)
        Panel10.Controls.Add(Label18)
        Panel10.Dock = DockStyle.Fill
        Panel10.Location = New Point(0, 22)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(287, 134)
        Panel10.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Dock = DockStyle.Bottom
        TextBox1.Enabled = False
        TextBox1.Location = New Point(0, 109)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(285, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label18
        ' 
        Label18.Anchor = AnchorStyles.Right
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.White
        Label18.Location = New Point(150, 66)
        Label18.Name = "Label18"
        Label18.Size = New Size(136, 21)
        Label18.TabIndex = 0
        Label18.Text = "Service Revenue"
        ' 
        ' Panel12
        ' 
        Panel12.Controls.Add(Label15)
        Panel12.Dock = DockStyle.Top
        Panel12.Location = New Point(0, 0)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(287, 22)
        Panel12.TabIndex = 0
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Dock = DockStyle.Top
        Label15.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(0, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(190, 21)
        Label15.TabIndex = 0
        Label15.Text = "REVENUE BREAKDOWN"
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.FromArgb(CByte(255), CByte(183), CByte(51))
        Panel13.BorderStyle = BorderStyle.FixedSingle
        Panel13.Controls.Add(TextBox2)
        Panel13.Controls.Add(Label19)
        Panel13.Dock = DockStyle.Fill
        Panel13.Location = New Point(3, 185)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(287, 157)
        Panel13.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Dock = DockStyle.Bottom
        TextBox2.Enabled = False
        TextBox2.Location = New Point(0, 132)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(285, 23)
        TextBox2.TabIndex = 3
        ' 
        ' Label19
        ' 
        Label19.Anchor = AnchorStyles.Right
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = Color.White
        Label19.Location = New Point(150, 93)
        Label19.Name = "Label19"
        Label19.Size = New Size(112, 21)
        Label19.TabIndex = 2
        Label19.Text = "Delivery Fees"
        ' 
        ' statspanel
        ' 
        statspanel.Dock = DockStyle.Fill
        statspanel.Location = New Point(3, 3)
        statspanel.Name = "statspanel"
        statspanel.Size = New Size(589, 345)
        statspanel.TabIndex = 1
        ' 
        ' StatsControl
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "StatsControl"
        Size = New Size(900, 681)
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel9.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel12.ResumeLayout(False)
        Panel12.PerformLayout()
        Panel13.ResumeLayout(False)
        Panel13.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblStatistics As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmbPeriod As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblTotalRev As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblTotalOrder As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblOrderValue As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents statspanel As Panel

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardControl
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
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        TableLayoutPanel5 = New TableLayoutPanel()
        lblPendingOrderText = New Label()
        lblInProgressText = New Label()
        lblOutForDeliveryText = New Label()
        lblCompletedText = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TableLayoutPanel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 5
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.Controls.Add(Panel1, 4, 0)
        TableLayoutPanel1.Controls.Add(Panel2, 0, 1)
        TableLayoutPanel1.Controls.Add(Panel3, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel4, 1, 0)
        TableLayoutPanel1.Controls.Add(Panel5, 2, 0)
        TableLayoutPanel1.Controls.Add(Panel6, 3, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 30F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 70F))
        TableLayoutPanel1.Size = New Size(800, 500)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(643, 3)
        Panel1.Name = "Panel1"
        TableLayoutPanel1.SetRowSpan(Panel1, 2)
        Panel1.Size = New Size(154, 494)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        TableLayoutPanel1.SetColumnSpan(Panel2, 4)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(3, 153)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(634, 344)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(TableLayoutPanel2)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(3, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(154, 144)
        Panel3.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(TableLayoutPanel3)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(163, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(154, 144)
        Panel4.TabIndex = 3
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(TableLayoutPanel4)
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(323, 3)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(154, 144)
        Panel5.TabIndex = 4
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(TableLayoutPanel5)
        Panel6.Dock = DockStyle.Fill
        Panel6.Location = New Point(483, 3)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(154, 144)
        Panel6.TabIndex = 5
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(lblPendingOrderText, 0, 0)
        TableLayoutPanel2.Controls.Add(PictureBox1, 1, 1)
        TableLayoutPanel2.Controls.Add(Label1, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(154, 144)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(lblInProgressText, 0, 0)
        TableLayoutPanel3.Controls.Add(PictureBox2, 1, 1)
        TableLayoutPanel3.Controls.Add(Label2, 0, 1)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(154, 144)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(lblOutForDeliveryText, 0, 0)
        TableLayoutPanel4.Controls.Add(PictureBox3, 1, 1)
        TableLayoutPanel4.Controls.Add(Label3, 0, 1)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(0, 0)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(154, 144)
        TableLayoutPanel4.TabIndex = 0
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Controls.Add(lblCompletedText, 0, 0)
        TableLayoutPanel5.Controls.Add(PictureBox4, 1, 1)
        TableLayoutPanel5.Controls.Add(Label4, 0, 1)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Location = New Point(0, 0)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 2
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Size = New Size(154, 144)
        TableLayoutPanel5.TabIndex = 0
        ' 
        ' lblPendingOrderText
        ' 
        lblPendingOrderText.Anchor = AnchorStyles.Left
        lblPendingOrderText.AutoSize = True
        TableLayoutPanel2.SetColumnSpan(lblPendingOrderText, 2)
        lblPendingOrderText.Location = New Point(3, 28)
        lblPendingOrderText.Name = "lblPendingOrderText"
        lblPendingOrderText.Size = New Size(89, 15)
        lblPendingOrderText.TabIndex = 0
        lblPendingOrderText.Text = "Pending Orders"
        ' 
        ' lblInProgressText
        ' 
        lblInProgressText.Anchor = AnchorStyles.Left
        lblInProgressText.AutoSize = True
        TableLayoutPanel3.SetColumnSpan(lblInProgressText, 2)
        lblInProgressText.Location = New Point(3, 28)
        lblInProgressText.Name = "lblInProgressText"
        lblInProgressText.Size = New Size(65, 15)
        lblInProgressText.TabIndex = 0
        lblInProgressText.Text = "In Progress"
        ' 
        ' lblOutForDeliveryText
        ' 
        lblOutForDeliveryText.Anchor = AnchorStyles.Left
        lblOutForDeliveryText.AutoSize = True
        TableLayoutPanel4.SetColumnSpan(lblOutForDeliveryText, 2)
        lblOutForDeliveryText.Location = New Point(3, 28)
        lblOutForDeliveryText.Name = "lblOutForDeliveryText"
        lblOutForDeliveryText.Size = New Size(90, 15)
        lblOutForDeliveryText.TabIndex = 0
        lblOutForDeliveryText.Text = "Out for Delivery"
        ' 
        ' lblCompletedText
        ' 
        lblCompletedText.Anchor = AnchorStyles.Left
        lblCompletedText.AutoSize = True
        TableLayoutPanel5.SetColumnSpan(lblCompletedText, 2)
        lblCompletedText.Location = New Point(3, 28)
        lblCompletedText.Name = "lblCompletedText"
        lblCompletedText.Size = New Size(66, 15)
        lblCompletedText.TabIndex = 0
        lblCompletedText.Text = "Completed"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(80, 75)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(71, 66)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Location = New Point(80, 75)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(71, 66)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Dock = DockStyle.Fill
        PictureBox3.Location = New Point(80, 75)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(71, 66)
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Dock = DockStyle.Fill
        PictureBox4.Location = New Point(80, 75)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(71, 66)
        PictureBox4.TabIndex = 1
        PictureBox4.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        Label1.Location = New Point(49, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(25, 30)
        Label1.TabIndex = 2
        Label1.Text = "0"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        Label2.Location = New Point(49, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(25, 30)
        Label2.TabIndex = 2
        Label2.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        Label3.Location = New Point(49, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(25, 30)
        Label3.TabIndex = 2
        Label3.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        Label4.Location = New Point(49, 93)
        Label4.Name = "Label4"
        Label4.Size = New Size(25, 30)
        Label4.TabIndex = 2
        Label4.Text = "0"
        ' 
        ' DashboardControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "DashboardControl"
        Size = New Size(800, 500)
        TableLayoutPanel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents lblPendingOrderText As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblInProgressText As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblOutForDeliveryText As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblCompletedText As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class

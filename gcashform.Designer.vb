<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gcashform
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
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gcashform))
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        cancelPayBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        totalPaymentLbl = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        TableLayoutPanel4 = New TableLayoutPanel()
        Label4 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        TableLayoutPanel5 = New TableLayoutPanel()
        Label5 = New Label()
        TableLayoutPanel6 = New TableLayoutPanel()
        Label7 = New Label()
        Label6 = New Label()
        confirmPaymentBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2GradientPanel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Guna2Panel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel4.SuspendLayout()
        Panel1.SuspendLayout()
        Guna2Panel2.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2GradientPanel1
        ' 
        Guna2GradientPanel1.Controls.Add(TableLayoutPanel1)
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges9
        Guna2GradientPanel1.Dock = DockStyle.Fill
        Guna2GradientPanel1.FillColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        Guna2GradientPanel1.FillColor2 = Color.FromArgb(CByte(76), CByte(102), CByte(232))
        Guna2GradientPanel1.GradientMode = Drawing2D.LinearGradientMode.Vertical
        Guna2GradientPanel1.Location = New Point(0, 0)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.Padding = New Padding(15)
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2GradientPanel1.Size = New Size(356, 618)
        Guna2GradientPanel1.TabIndex = 0
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel1.Controls.Add(cancelPayBtn, 0, 6)
        TableLayoutPanel1.Controls.Add(totalPaymentLbl, 0, 1)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 0)
        TableLayoutPanel1.Controls.Add(Guna2Panel1, 0, 2)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel4, 0, 3)
        TableLayoutPanel1.Controls.Add(Guna2Panel2, 0, 4)
        TableLayoutPanel1.Controls.Add(confirmPaymentBtn, 0, 5)
        TableLayoutPanel1.ForeColor = Color.White
        TableLayoutPanel1.Location = New Point(15, 15)
        TableLayoutPanel1.Margin = New Padding(0, 3, 0, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 7
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 40.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 7.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 7.0F))
        TableLayoutPanel1.Size = New Size(326, 588)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' cancelPayBtn
        ' 
        cancelPayBtn.BorderColor = Color.White
        cancelPayBtn.BorderRadius = 5
        cancelPayBtn.BorderThickness = 1
        cancelPayBtn.CustomizableEdges = CustomizableEdges1
        cancelPayBtn.DisabledState.BorderColor = Color.DarkGray
        cancelPayBtn.DisabledState.CustomBorderColor = Color.DarkGray
        cancelPayBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        cancelPayBtn.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        cancelPayBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        cancelPayBtn.Dock = DockStyle.Fill
        cancelPayBtn.FillColor = Color.DimGray
        cancelPayBtn.FillColor2 = Color.Gray
        cancelPayBtn.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cancelPayBtn.ForeColor = Color.White
        cancelPayBtn.GradientMode = Drawing2D.LinearGradientMode.Vertical
        cancelPayBtn.Location = New Point(3, 547)
        cancelPayBtn.Name = "cancelPayBtn"
        cancelPayBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        cancelPayBtn.Size = New Size(320, 38)
        cancelPayBtn.TabIndex = 7
        cancelPayBtn.Text = "CANCEL"
        ' 
        ' totalPaymentLbl
        ' 
        totalPaymentLbl.Dock = DockStyle.Fill
        totalPaymentLbl.Font = New Font("Microsoft Sans Serif", 21.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        totalPaymentLbl.Location = New Point(3, 61)
        totalPaymentLbl.Margin = New Padding(3)
        totalPaymentLbl.Name = "totalPaymentLbl"
        totalPaymentLbl.Size = New Size(320, 58)
        totalPaymentLbl.TabIndex = 2
        totalPaymentLbl.Text = "₱525.00"
        totalPaymentLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel2.Controls.Add(PictureBox1, 1, 0)
        TableLayoutPanel2.Controls.Add(Label1, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.Padding = New Padding(0, 4, 15, 4)
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel2.Size = New Size(320, 52)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(152, 7)
        PictureBox1.Margin = New Padding(0, 3, 3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 38)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Microsoft Sans Serif", 21.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 4)
        Label1.Margin = New Padding(3, 0, 0, 0)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(2, 0, 0, 0)
        Label1.Size = New Size(149, 44)
        Label1.TabIndex = 1
        Label1.Text = "Pay Via"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Guna2Panel1.BorderRadius = 10
        Guna2Panel1.Controls.Add(TableLayoutPanel3)
        Guna2Panel1.CustomizableEdges = CustomizableEdges3
        Guna2Panel1.FillColor = Color.White
        Guna2Panel1.Location = New Point(38, 125)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.Padding = New Padding(40, 3, 40, 3)
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Panel1.Size = New Size(250, 229)
        Guna2Panel1.TabIndex = 3
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel3.Controls.Add(Label3, 0, 0)
        TableLayoutPanel3.Controls.Add(PictureBox2, 0, 1)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(40, 3)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 80.0F))
        TableLayoutPanel3.Size = New Size(170, 223)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(164, 44)
        Label3.TabIndex = 4
        Label3.Text = "SCAN TO PAY"
        Label3.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 47)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(164, 173)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 3
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40.0F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40.0F))
        TableLayoutPanel4.Controls.Add(Label4, 1, 0)
        TableLayoutPanel4.Controls.Add(Panel1, 2, 0)
        TableLayoutPanel4.Controls.Add(Panel3, 0, 0)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(3, 360)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel4.Size = New Size(320, 52)
        TableLayoutPanel4.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(131, 3)
        Label4.Margin = New Padding(3)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 46)
        Label4.TabIndex = 5
        Label4.Text = "OR"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(195, 25)
        Panel1.Margin = New Padding(3, 25, 3, 25)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(122, 2)
        Panel1.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(122, 2)
        Panel2.TabIndex = 7
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(3, 25)
        Panel3.Margin = New Padding(3, 25, 3, 25)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(122, 2)
        Panel3.TabIndex = 5
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.BorderRadius = 10
        Guna2Panel2.Controls.Add(TableLayoutPanel5)
        Guna2Panel2.CustomizableEdges = CustomizableEdges5
        Guna2Panel2.Dock = DockStyle.Fill
        Guna2Panel2.FillColor = Color.White
        Guna2Panel2.Location = New Point(3, 418)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Panel2.Size = New Size(320, 82)
        Guna2Panel2.TabIndex = 5
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 1
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel5.Controls.Add(Label5, 0, 0)
        TableLayoutPanel5.Controls.Add(TableLayoutPanel6, 0, 1)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Location = New Point(0, 0)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 2
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel5.Size = New Size(320, 82)
        TableLayoutPanel5.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.Dock = DockStyle.Fill
        Label5.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(314, 41)
        Label5.TabIndex = 0
        Label5.Text = "  SEND MONEY MANUALLY"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.ColumnCount = 2
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel6.Controls.Add(Label7, 0, 0)
        TableLayoutPanel6.Controls.Add(Label6, 1, 0)
        TableLayoutPanel6.Dock = DockStyle.Fill
        TableLayoutPanel6.Location = New Point(3, 44)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 1
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel6.Size = New Size(314, 35)
        TableLayoutPanel6.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.Dock = DockStyle.Fill
        Label7.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(84), CByte(84), CByte(84))
        Label7.Location = New Point(3, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(151, 35)
        Label7.TabIndex = 1
        Label7.Text = "Send to:"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.Dock = DockStyle.Fill
        Label6.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(160, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(151, 35)
        Label6.TabIndex = 0
        Label6.Text = "+63 912 375 6779"
        Label6.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' confirmPaymentBtn
        ' 
        confirmPaymentBtn.BorderColor = Color.White
        confirmPaymentBtn.BorderRadius = 5
        confirmPaymentBtn.BorderThickness = 1
        confirmPaymentBtn.CustomizableEdges = CustomizableEdges7
        confirmPaymentBtn.DisabledState.BorderColor = Color.DarkGray
        confirmPaymentBtn.DisabledState.CustomBorderColor = Color.DarkGray
        confirmPaymentBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        confirmPaymentBtn.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        confirmPaymentBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        confirmPaymentBtn.Dock = DockStyle.Fill
        confirmPaymentBtn.FillColor = Color.Green
        confirmPaymentBtn.FillColor2 = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        confirmPaymentBtn.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        confirmPaymentBtn.ForeColor = Color.White
        confirmPaymentBtn.GradientMode = Drawing2D.LinearGradientMode.Vertical
        confirmPaymentBtn.Location = New Point(3, 506)
        confirmPaymentBtn.Name = "confirmPaymentBtn"
        confirmPaymentBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        confirmPaymentBtn.Size = New Size(320, 35)
        confirmPaymentBtn.TabIndex = 6
        confirmPaymentBtn.Text = "CONFIRM PAYMENT"
        ' 
        ' gcashform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(356, 618)
        Controls.Add(Guna2GradientPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "gcashform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "gcashform"
        Guna2GradientPanel1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Guna2Panel1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel4.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Guna2Panel2.ResumeLayout(False)
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel6.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents totalPaymentLbl As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents confirmPaymentBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents cancelPayBtn As Guna.UI2.WinForms.Guna2GradientButton
End Class

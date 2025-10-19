<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExitConfirmForm
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExitConfirmForm))
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label4 = New Label()
        Label3 = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        exitFormCnclBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        exitFormCloseBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2GradientPanel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2GradientPanel1
        ' 
        Guna2GradientPanel1.Controls.Add(TableLayoutPanel1)
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges7
        Guna2GradientPanel1.Dock = DockStyle.Top
        Guna2GradientPanel1.FillColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        Guna2GradientPanel1.FillColor2 = Color.FromArgb(CByte(76), CByte(102), CByte(232))
        Guna2GradientPanel1.Location = New Point(0, 0)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2GradientPanel1.Size = New Size(400, 100)
        Guna2GradientPanel1.TabIndex = 0
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel1.Controls.Add(Label1, 0, 1)
        TableLayoutPanel1.Controls.Add(Label2, 0, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 53.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 26.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(400, 100)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(394, 47)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(3, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(394, 26)
        Label1.TabIndex = 5
        Label1.Text = "BubbleFresh"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(3, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(394, 21)
        Label2.TabIndex = 6
        Label2.Text = "Professional Laundry Service"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackColor = Color.Transparent
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(Label4, 0, 1)
        TableLayoutPanel2.Controls.Add(Label3, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Top
        TableLayoutPanel2.Location = New Point(0, 100)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(400, 133)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(3, 66)
        Label4.Name = "Label4"
        Label4.Padding = New Padding(5, 0, 5, 0)
        Label4.Size = New Size(394, 67)
        Label4.TabIndex = 1
        Label4.Text = "Any unsaved progress, details, or data you entered will be lost."
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(394, 66)
        Label3.TabIndex = 0
        Label3.Text = "Confirm Exit?"
        Label3.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.BackColor = Color.Transparent
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(exitFormCnclBtn, 0, 0)
        TableLayoutPanel3.Controls.Add(exitFormCloseBtn, 1, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(0, 233)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.Padding = New Padding(30, 15, 30, 15)
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(400, 67)
        TableLayoutPanel3.TabIndex = 2
        ' 
        ' exitFormCnclBtn
        ' 
        exitFormCnclBtn.BorderRadius = 5
        exitFormCnclBtn.CustomizableEdges = CustomizableEdges9
        exitFormCnclBtn.DisabledState.BorderColor = Color.DarkGray
        exitFormCnclBtn.DisabledState.CustomBorderColor = Color.DarkGray
        exitFormCnclBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        exitFormCnclBtn.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        exitFormCnclBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        exitFormCnclBtn.FillColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        exitFormCnclBtn.FillColor2 = Color.DarkGray
        exitFormCnclBtn.Font = New Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        exitFormCnclBtn.ForeColor = Color.White
        exitFormCnclBtn.Location = New Point(33, 18)
        exitFormCnclBtn.Name = "exitFormCnclBtn"
        exitFormCnclBtn.PressedColor = Color.Transparent
        exitFormCnclBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        exitFormCnclBtn.Size = New Size(164, 31)
        exitFormCnclBtn.TabIndex = 2
        exitFormCnclBtn.Text = "Cancel"
        ' 
        ' exitFormCloseBtn
        ' 
        exitFormCloseBtn.BorderRadius = 5
        exitFormCloseBtn.CustomizableEdges = CustomizableEdges11
        exitFormCloseBtn.DisabledState.BorderColor = Color.DarkGray
        exitFormCloseBtn.DisabledState.CustomBorderColor = Color.DarkGray
        exitFormCloseBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        exitFormCloseBtn.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        exitFormCloseBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        exitFormCloseBtn.FillColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        exitFormCloseBtn.FillColor2 = Color.FromArgb(CByte(76), CByte(102), CByte(232))
        exitFormCloseBtn.Font = New Font("Poppins SemiBold", 12F, FontStyle.Bold)
        exitFormCloseBtn.ForeColor = Color.White
        exitFormCloseBtn.Location = New Point(203, 18)
        exitFormCloseBtn.Name = "exitFormCloseBtn"
        exitFormCloseBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        exitFormCloseBtn.Size = New Size(164, 31)
        exitFormCloseBtn.TabIndex = 3
        exitFormCloseBtn.Text = "Exit"
        ' 
        ' ExitConfirmForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(TableLayoutPanel3)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(Guna2GradientPanel1)
        Name = "ExitConfirmForm"
        Size = New Size(400, 300)
        Guna2GradientPanel1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents exitFormCnclBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents exitFormCloseBtn As Guna.UI2.WinForms.Guna2GradientButton

End Class

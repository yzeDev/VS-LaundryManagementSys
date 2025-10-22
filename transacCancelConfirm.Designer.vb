<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transacCancelConfirm
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transacCancelConfirm))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        btnNo = New Guna.UI2.WinForms.Guna2GradientButton()
        btnYes = New Guna.UI2.WinForms.Guna2GradientButton()
        Label2 = New Label()
        Panel1 = New Panel()
        Label1 = New Label()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel3, 0, 3)
        TableLayoutPanel1.Controls.Add(Label2, 0, 2)
        TableLayoutPanel1.Controls.Add(Panel1, 0, 1)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 23F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 1F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 53F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 23F))
        TableLayoutPanel1.Size = New Size(400, 220)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(btnNo, 0, 0)
        TableLayoutPanel3.Controls.Add(btnYes, 1, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(15, 168)
        TableLayoutPanel3.Margin = New Padding(15, 0, 15, 15)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(370, 37)
        TableLayoutPanel3.TabIndex = 10
        ' 
        ' btnNo
        ' 
        btnNo.BorderRadius = 5
        btnNo.CustomizableEdges = CustomizableEdges1
        btnNo.DisabledState.BorderColor = Color.DarkGray
        btnNo.DisabledState.CustomBorderColor = Color.DarkGray
        btnNo.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnNo.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnNo.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnNo.Dock = DockStyle.Left
        btnNo.FillColor = Color.DimGray
        btnNo.FillColor2 = Color.Gray
        btnNo.Font = New Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNo.ForeColor = Color.White
        btnNo.Image = CType(resources.GetObject("btnNo.Image"), Image)
        btnNo.ImageAlign = HorizontalAlignment.Left
        btnNo.ImageSize = New Size(15, 15)
        btnNo.Location = New Point(3, 3)
        btnNo.Margin = New Padding(3, 3, 7, 3)
        btnNo.Name = "btnNo"
        btnNo.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnNo.Size = New Size(153, 31)
        btnNo.TabIndex = 1
        btnNo.Text = "     No"
        ' 
        ' btnYes
        ' 
        btnYes.BorderRadius = 5
        btnYes.CustomizableEdges = CustomizableEdges3
        btnYes.DisabledState.BorderColor = Color.DarkGray
        btnYes.DisabledState.CustomBorderColor = Color.DarkGray
        btnYes.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnYes.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnYes.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnYes.Dock = DockStyle.Right
        btnYes.FillColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        btnYes.FillColor2 = Color.FromArgb(CByte(76), CByte(102), CByte(232))
        btnYes.Font = New Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnYes.ForeColor = Color.White
        btnYes.Image = CType(resources.GetObject("btnYes.Image"), Image)
        btnYes.ImageAlign = HorizontalAlignment.Left
        btnYes.ImageSize = New Size(14, 14)
        btnYes.Location = New Point(214, 3)
        btnYes.Margin = New Padding(7, 3, 3, 3)
        btnYes.Name = "btnYes"
        btnYes.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnYes.Size = New Size(153, 31)
        btnYes.TabIndex = 0
        btnYes.Text = "     Yes "
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(76), CByte(76), CByte(76))
        Label2.Location = New Point(15, 67)
        Label2.Margin = New Padding(15)
        Label2.Name = "Label2"
        Label2.Size = New Size(370, 86)
        Label2.TabIndex = 4
        Label2.Text = "Are you sure you want to cancel this transaction? All entered data will be lost."
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(15, 53)
        Panel1.Margin = New Padding(15, 3, 15, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(370, 1)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(15, 15)
        Label1.Margin = New Padding(15)
        Label1.Name = "Label1"
        Label1.Size = New Size(370, 20)
        Label1.TabIndex = 3
        Label1.Text = "Confirm Cancellation"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' transacCancelConfirm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(400, 220)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "transacCancelConfirm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "transacCancelConfirm"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnNo As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnYes As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class

Imports System.Data.OleDb

Public Class LoginForm



    ' Connection to your Access database
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"
    Private passwordVisible As Boolean = False  ' Tracks password visibility state

    ' --- LOGIN BUTTON CLICK ---
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim inputPassword As String = gtbPassword.Text.Trim()

        If String.IsNullOrEmpty(inputPassword) Then
            MessageBox.Show("Please enter a password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using con As New OleDbConnection(connectionString)
                con.Open()
                Dim query As String = "SELECT COUNT(*) FROM Account WHERE Password = @password"
                Using cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("@password", inputPassword)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Dim mainForm As New MainForm()
                        mainForm.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Incorrect password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' --- TOGGLE PASSWORD VISIBILITY ---
    Private Sub picEye_Click(sender As Object, e As EventArgs) Handles picEye.Click
        If passwordVisible Then
            ' Hide password
            gtbPassword.PasswordChar = "●"c
            picEye.Image = Image.FromFile("C:\Users\Eisen\OneDrive\Documents\Assets\open-eye.png")
            passwordVisible = False
        Else
            ' Show password
            gtbPassword.PasswordChar = ChrW(0)
            picEye.Image = Image.FromFile("C:\Users\Eisen\OneDrive\Documents\Assets\closed-eye.png")
            passwordVisible = True
        End If
    End Sub



    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize password box and eye icon
        gtbPassword.PasswordChar = "●"c
        picEye.Image = Image.FromFile("C:\Users\Eisen\OneDrive\Documents\Assets\closed-eye.png")

        ' --- Overlay the PictureBox over the textbox ---
        picEye.Parent = gtbPassword
        picEye.BackColor = Color.Transparent
        picEye.SizeMode = PictureBoxSizeMode.Zoom

        ' Scale it down slightly (e.g., 20x20 pixels)
        picEye.Width = 20
        picEye.Height = 20

        ' Position at the far right, vertically centered
        picEye.Location = New Point(gtbPassword.Width - picEye.Width - 8, (gtbPassword.Height - picEye.Height) \ 2)

        ' Make sure it’s visible above the textbox
        picEye.BringToFront()
    End Sub

    ' --- LOGIN WHEN ENTER IS PRESSED ---
    Private Sub gtbPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles gtbPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True  ' Prevent the ding sound
            btnLogin.PerformClick()    ' Trigger the login button click
        End If
    End Sub


End Class

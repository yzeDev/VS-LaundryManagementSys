Imports System.Data.OleDb

Public Class LoginForm

    Private passwordVisible As Boolean = False

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gtbPassword.PasswordChar = "●"c
        picEye.Image = Image.FromFile("C:\Users\Eisen\OneDrive\Documents\Assets\closed-eye.png")

        ' --- Overlay the PictureBox over the textbox ---
        picEye.Parent = gtbPassword
        picEye.BackColor = Color.Transparent
        picEye.SizeMode = PictureBoxSizeMode.Zoom

        picEye.Width = 20
        picEye.Height = 20


        picEye.Location = New Point(gtbPassword.Width - picEye.Width - 8, (gtbPassword.Height - picEye.Height) \ 2)

        picEye.BringToFront()
    End Sub

    ' --- LOGIN BUTTON CLICK ---
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim inputEmployeeID As String = gtbEmployeeID.Text.Trim()
        Dim inputPassword As String = gtbPassword.Text.Trim()

        ' === Basic validation ===
        If String.IsNullOrEmpty(inputEmployeeID) OrElse String.IsNullOrEmpty(inputPassword) Then
            MessageBox.Show("Please enter both Employee ID and Password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using con As New OleDbConnection(Db.ConnectionString)
                con.Open()

                ' === Get user details based on EmployeeID + Password ===
                Dim query As String = "SELECT userRole FROM Employees WHERE EmployeeID = @employeeID AND [Password] = @password"
                Using cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("@employeeID", inputEmployeeID)
                    cmd.Parameters.AddWithValue("@password", inputPassword)

                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing Then
                        Dim role As String = result.ToString().Trim()

                        MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' === Redirect based on userRole ===
                        If role.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then
                            Dim adminForm As New AdminForm()
                            adminForm.CurrentUserID = inputEmployeeID
                            adminForm.UserRole = role
                            adminForm.Show()
                            Me.Hide()
                        ElseIf role.Equals("Employee", StringComparison.OrdinalIgnoreCase) Then
                            Dim empForm As New EMPForm()
                            empForm.CurrentUserID = inputEmployeeID
                            empForm.UserRole = role
                            empForm.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Unknown user role detected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        MessageBox.Show("Invalid Employee ID or Password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    ' --- TOGGLE PASSWORD VISIBILITY ---
    Private Sub picEye_Click(sender As Object, e As EventArgs) Handles picEye.Click
        If passwordVisible Then
            gtbPassword.PasswordChar = "●"c
            picEye.Image = Image.FromFile("C:\Users\Eisen\OneDrive\Documents\Assets\open-eye.png")
            passwordVisible = False
        Else
            gtbPassword.PasswordChar = ChrW(0)
            picEye.Image = Image.FromFile("C:\Users\Eisen\OneDrive\Documents\Assets\closed-eye.png")
            passwordVisible = True
        End If
    End Sub

    ' --- LOGIN WHEN ENTER IS PRESSED ---
    Private Sub gtbPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles gtbPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnLogin.PerformClick()
        End If
    End Sub

    ' === EmployeeID KeyPress Event ===
    Private Sub gtbEmployeeID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gtbEmployeeID.KeyPress
        ValidateEmployeeIDInput(sender, e)
    End Sub

    ' === Validation Function ===
    Private Sub ValidateEmployeeIDInput(sender As Object, e As KeyPressEventArgs)
        Dim textBox As Guna.UI2.WinForms.Guna2TextBox = DirectCast(sender, Guna.UI2.WinForms.Guna2TextBox)

        ' Allow control keys (Backspace, Delete, etc.)
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        ' Block non-numeric characters
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            Return
        End If

        ' Limit to 6 digits
        If textBox.Text.Length >= 6 Then
            e.Handled = True
            Return
        End If
    End Sub


End Class

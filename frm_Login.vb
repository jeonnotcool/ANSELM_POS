Imports System.Data.OleDb
Imports System.Globalization ' Import if you're using CultureInfo for formatting

Public Class frm_Login

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        ' --- Input Validation: Check for empty fields ---
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Exit if fields are empty
        End If

        ' --- Get Trimmed Username and Password ---
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' --- Attempt Login and Get User Role ---
        Dim userRole As String = DBAccess.ValidateLogin(username, password) ' Call the DBAccess function

        If Not String.IsNullOrEmpty(userRole) Then
            ' --- Login Successful ---
            Dim currentDateTime As String = DateTime.Now.ToString("f") ' Consider using "F" for full date/time

            MessageBox.Show($"Welcome, {username}!" & vbCrLf & vbCrLf &
                            $"You have successfully signed in to Anselmara POS using your username and password on" & vbCrLf & $"{currentDateTime}." & vbCrLf & vbCrLf &
                            $"Your role is {userRole}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' --- Open the main POS form ---
            Dim mainForm As New MainForm()
            mainForm.LoggedInUser = username   ' Pass username
            mainForm.UserRole = userRole       ' Pass role

            mainForm.Show()
            Me.Hide() ' Hide the login form

        Else
            ' --- Login Failed ---
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Any initialization you need
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub frm_Login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit() ' Exit the application when the form is closed
    End Sub

End Class
Imports MySql.Data.MySqlClient
Imports Windows.Win32.System

Public Class Form1
    Private Sub txtPassword_Click(sender As Object, e As EventArgs) Handles lblPassword.Click

    End Sub
    Private Sub btnTestConnection_Click(sender As Object, e As EventArgs)
        Try
            OpenCon()   'Open database connection
            MessageBox.Show("Database connected successfully!",
                        "Connection Test",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
            CloseCon()  'Close database connection

        Catch ex As Exception
            MessageBox.Show("Connection failed: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        'Simple validation
        If txtUserName.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please enter username and password")
            Exit Sub
        End If

        Try
            OpenCon()

            Dim cmd As New MySqlCommand(
            "SELECT role FROM users WHERE username=@christina AND password=@123", con)

            cmd.Parameters.AddWithValue("@christina", txtUserName.Text)
            cmd.Parameters.AddWithValue("@123", txtPassword.Text)

            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                Dim userRole As String = dr("role").ToString()

                MessageBox.Show("Login successful")

                'Open dashboard
                Me.Show()
                Me.Hide()

            Else
                MessageBox.Show("Invalid username or password")
            End If

            dr.Close()
            CloseCon()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
End Class

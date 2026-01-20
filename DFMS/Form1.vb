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


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        Try
            OpenCon()

            Dim sql As String = "SELECT role FROM users WHERE username=@u AND password=@p"
            Dim cmd As New MySqlCommand(sql, con)

            cmd.Parameters.AddWithValue("@u", txtUserName.Text)
            cmd.Parameters.AddWithValue("@p", txtPassword.Text)

            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then


                Dashboard.Show()
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

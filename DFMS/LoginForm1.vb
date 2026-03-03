Imports MySql.Data.MySqlClient

Public Class LoginForm1

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUserName.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please enter username and password")
            Exit Sub
        End If

        Try
            OpenCon()

            Dim sql As String = "SELECT * FROM user WHERE username=@u AND password=@p"
            Dim cmd As New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@u", txtUserName.Text)
            cmd.Parameters.AddWithValue("@p", txtPassword.Text)

            ' Close any previous reader if still open
            If con.State = ConnectionState.Open Then
                cmd.Connection = con
            End If

            Using dr As MySqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    Dim frm As New Dashboard()

                    ' Send username to Dashboard
                    frm.LoggedInUser = dr("username").ToString()
                    frm.LoggedInRole = dr("role").ToString()
                    frm.LoggedInDepartment = dr("Department").ToString()

                    frm.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Wrong Username or Password")
                End If
            End Using   ' This automatically closes the reader

            CloseCon()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class
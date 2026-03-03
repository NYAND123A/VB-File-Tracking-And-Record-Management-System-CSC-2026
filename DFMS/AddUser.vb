Imports MySql.Data.MySqlClient


Public Class AddUser

    Private parentDash As Dashboard

    Public Sub New(dash As Dashboard)
        InitializeComponent()
        parentDash = dash
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblPassword.Click

    End Sub

    Private Sub txtUserID_TextChanged(sender As Object, e As EventArgs) Handles txtUserID.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click







        Dim conStr As String = "server=localhost;user id=root;password=;database=file_tracking;"



        ' Validate fields
        If txtUsername.Text = "" Or txtPassword.Text = "" Or cboRole.Text = "" Or txtDepartment.Text = "" Then
            MessageBox.Show("Please fill all fields!")
            Exit Sub
        End If



        Using con As New MySqlConnection(conStr)
            Try
                con.Open()

                Dim query As String = "INSERT INTO User (Username, Password, Role, Department) 
                                       VALUES (@username, @password, @role, @dept)"

                Dim cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@password", txtPassword.Text)
                cmd.Parameters.AddWithValue("@role", cboRole.Text)
                cmd.Parameters.AddWithValue("@dept", txtDepartment.Text)

                cmd.ExecuteNonQuery()

                MessageBox.Show("User registered successfully!")

                ' Clear fields
                txtUsername.Clear()
                txtPassword.Clear()
                cboRole.SelectedIndex = -1
                txtDepartment.Clear()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

    End Sub



    Private Sub btnTest_Click(sender As Object, e As EventArgs)


        Try
            OpenCon()
            MessageBox.Show("Connection Successful!")
            CloseCon()
        Catch ex As Exception
            MessageBox.Show("Connection Failed: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        parentDash.Show()
        Me.Close()
    End Sub
End Class



Imports MySql.Data.MySqlClient

Public Class FILE_REGISTRATION
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Basic validation
        If txtFileTitle.Text = "" Or cboDepartment.Text = "" Then
            MessageBox.Show("Please fill all required fields",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim priority As String
        If rdoUrgent.Checked Then
            priority = "Urgent"
        Else
            priority = "Normal"
        End If

        Try
            OpenCon()

            Dim sql As String =
                "INSERT INTO filess (file_ID, file_title, department, priority, description, date_created)
VALUES (@ID,@title, @dept, @priority, @desc, NOW())"

            Dim cmd As New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@ID", txtFileID.Text)
            cmd.Parameters.AddWithValue("@title", txtFileTitle.Text)
            cmd.Parameters.AddWithValue("@dept", cboDepartment.Text)
            cmd.Parameters.AddWithValue("@priority", priority)
            cmd.Parameters.AddWithValue("@desc", txtDescription.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("File registered successfully",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

            'ClearForm()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error")

        Finally
            CloseCon()
        End Try
    End Sub
End Class
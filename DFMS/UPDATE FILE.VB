Imports MySql.Data.MySqlClient

Public Class UPDATE_FILE

    Private parentDash As Dashboard
    Public Sub New(dash As Dashboard)
        InitializeComponent()
        parentDash = dash
    End Sub
    Public SelectedFileID As String
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If txtSearch.Text = "" Then
            MessageBox.Show("Enter File ID or Title")
            Exit Sub
        End If

        Try
            OpenCon()

            Dim sql As String = "SELECT * FROM file WHERE FileID=@search OR FileTitle=@search"
            Using cmd As New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@search", txtSearch.Text)

                Dim dr As MySqlDataReader = cmd.ExecuteReader()

                If dr.Read() Then
                    txtFileID.Text = dr("FileID").ToString()
                    txtFileTitle.Text = dr("FileTitle").ToString()
                    cboDepartment.Text = dr("department").ToString()
                    txtDescription.Text = dr("description").ToString()

                    'Priority
                    If dr("priority").ToString() = "Normal" Then
                        rdoNormal.Checked = True
                    Else
                        rdoUrgent.Checked = True
                    End If
                Else
                    MessageBox.Show("File not found")
                End If

                dr.Close()
            End Using

            CloseCon()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If txtFileID.Text = "" Then
            MessageBox.Show("Please search and select a file first")
            Exit Sub
        End If

        'Determine priority
        Dim priority As String
        If rdoNormal.Checked Then
            priority = "Normal"
        Else
            priority = "Urgent"
        End If

        Try
            OpenCon()

            Dim sql As String = "UPDATE file SET FileID=@id, FileTitle=@title, department=@dept, priority=@priority, description=@desc WHERE FileID=@id"
            Using cmd As New MySqlCommand(sql, con)

                cmd.Parameters.AddWithValue("@title", txtFileTitle.Text)
                cmd.Parameters.AddWithValue("@dept", cboDepartment.Text)
                cmd.Parameters.AddWithValue("@priority", priority)
                cmd.Parameters.AddWithValue("@desc", txtDescription.Text)
                cmd.Parameters.AddWithValue("@id", txtFileID.Text)

                Dim result As Integer = cmd.ExecuteNonQuery()

                If result > 0 Then
                    MessageBox.Show("File updated successfully")
                Else
                    MessageBox.Show("Update failed")
                End If
            End Using

            CloseCon()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' Clear textboxes
        txtSearch.Clear()
        txtFileID.Clear()
        txtFileTitle.Clear()
        txtDescription.Clear()

        ' Reset ComboBox
        cboDepartment.SelectedIndex = -1

        ' Uncheck RadioButtons
        rdoNormal.Checked = False
        rdoUrgent.Checked = False

        ' Set focus back to search box
        txtSearch.Focus()

    End Sub

    Private Sub UPDATE_FILE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If SelectedFileID = "" Then Exit Sub

        Try
            OpenCon()

            Dim sql As String = "SELECT * FROM file WHERE FileID = @id"
            Dim cmd As New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@id", SelectedFileID)

            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                txtFileID.Text = dr("FileID").ToString()
                txtFileTitle.Text = dr("FileTitle").ToString()
                cboDepartment.Text = dr("department").ToString()
                txtDescription.Text = dr("description").ToString()
                txtDescription.Text = dr("Status").ToString()
                If dr("priority").ToString() = "Normal" Then
                    rdoNormal.Checked = True
                Else
                    rdoUrgent.Checked = True
                End If
            End If

            dr.Close()
            CloseCon()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            CloseCon()
        End Try

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        parentDash.Show(Me)
        Me.Hide()

    End Sub
End Class

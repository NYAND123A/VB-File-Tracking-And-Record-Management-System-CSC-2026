Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FILE_REGISTRATION
    Private parentDash As Dashboard
    Public Sub New(dash As Dashboard)
        InitializeComponent()
        parentDash = dash
    End Sub

    Private Function IsInDesignMode() As Boolean
        Return System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode
    End Function

    Private Sub FILE_REGISTRATION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsInDesignMode() Then Return
    End Sub

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
                "INSERT INTO file (FileID, FileTitle, department, priority, description, FILE_STATUS, date_created) " &
                "VALUES (@ID,@title, @dept, @priority, @desc, @status, NOW())"

            Using cmd As New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@ID", txtFileID.Text)
                cmd.Parameters.AddWithValue("@title", txtFileTitle.Text)
                cmd.Parameters.AddWithValue("@dept", cboDepartment.Text)
                cmd.Parameters.AddWithValue("@priority", priority)
                cmd.Parameters.AddWithValue("@desc", txtDescription.Text)
                cmd.Parameters.AddWithValue("@status", cboStatus.Text)



                cmd.ExecuteNonQuery()
            End Using

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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        parentDash.Show(Me)
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear TextBoxes
        txtFileID.Clear()
        txtFileTitle.Clear()
        txtDescription.Clear()

        ' Reset ComboBoxes
        cboDepartment.SelectedIndex = -1
        cboStatus.SelectedIndex = -1



    End Sub
End Class
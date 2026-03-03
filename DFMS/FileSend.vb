Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FileSend
    Private parentDash As Dashboard
    Public Sub New(dash As Dashboard)
        InitializeComponent()
        parentDash = dash
    End Sub

    Private Function IsInDesignMode() As Boolean
        Return System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode
    End Function

    Private Sub FileSend_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsInDesignMode() Then Return
        ' runtime init if needed
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblFileID.Click
    End Sub

    Private Sub cboFileName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFileName.SelectedIndexChanged
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblReceiverOfficer.Click
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If IsInDesignMode() Then Return

        ' Basic validation
        If String.IsNullOrWhiteSpace(txtFileID.Text) OrElse String.IsNullOrWhiteSpace(cboFrom.Text) OrElse String.IsNullOrWhiteSpace(cboTo.Text) Then
            MessageBox.Show("Please fill File ID, From and To fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            OpenCon()

            Dim sql As String = "INSERT INTO filtracking (TrackingID, FileID, FromDepartment, ToDepartment, SentBy, DateSent, Remarks) " &
                                "VALUES (@Tid, @fid, @from, @to, @sentby, @date, @remarks)"

            Using cmd As New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@Tid", txtTrackingID.Text)
                cmd.Parameters.AddWithValue("@fid", txtFileID.Text)
                cmd.Parameters.AddWithValue("@from", cboFrom.Text)
                cmd.Parameters.AddWithValue("@to", cboTo.Text)
                cmd.Parameters.AddWithValue("@sentby", txtSent.Text)
                cmd.Parameters.AddWithValue("@date", dtpDate.Value)
                cmd.Parameters.AddWithValue("@remarks", txtRemark.Text)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("File Sent Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseCon()
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        parentDash.Show(Me)
        Me.Hide()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' Clear TextBoxes
        txtTrackingID.Clear()
        txtFileID.Clear()
        txtFileDescription.Clear()
        txtSent.Clear()
        txtRemark.Clear()

        ' Reset ComboBoxes
        cboFrom.SelectedIndex = -1
        cboTo.SelectedIndex = -1

        ' Reset DateTimePicker to today
        dtpDate.Value = DateTime.Now

        ' Set focus to FileID for convenience
        txtFileID.Focus()
    End Sub
End Class
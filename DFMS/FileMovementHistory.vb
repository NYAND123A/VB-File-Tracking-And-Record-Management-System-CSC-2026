Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FileMovementHistory
    Private parentDash As Dashboard
    Public Sub New(dash As Dashboard)
        InitializeComponent()
        parentDash = dash
    End Sub

    Private Sub btnViewHistory_Click(sender As Object, e As EventArgs) Handles btnViewHistory.Click
        Dim fileText As String = txtFileID.Text.Trim()
        If String.IsNullOrWhiteSpace(fileText) Then
            MessageBox.Show("Please enter File ID")
            Exit Sub
        End If

        Dim query As String = "SELECT TrackingID, FileID, FromDepartment, ToDepartment, SentBy, DateSent, Remarks FROM filtracking WHERE FileID = @FileID ORDER BY DateSent ASC"

        Try
            OpenCon()
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@FileID", fileText)

                Using da As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    da.Fill(table)
                    dgvHistory.DataSource = table
                    If table.Rows.Count = 0 Then
                        MessageBox.Show("No movement history found for File ID: " & fileText)
                    End If
                End Using
            End Using
            CloseCon()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        parentDash.Show(Me)
        Me.Hide()


    End Sub
End Class
Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class SearchFile

    Private parentDash As Dashboard
    Public Sub New(dash As Dashboard)
        InitializeComponent()
        parentDash = dash
    End Sub


    Private Function IsInDesignMode() As Boolean
        Return System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode
    End Function

    Private Sub SearchFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsInDesignMode() Then Return
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchText = txtSearch.Text.Trim()
        If searchText = String.Empty Then
            MessageBox.Show("Enter File ID or File Title")
            Return
        End If

        PopulateGrid(searchText)
    End Sub

    Private Sub PopulateGrid(searchText As String)
        Try
            OpenCon()

            Dim sql As String =
                "SELECT * FROM file WHERE FileID = @id"

            Using cmd As New MySqlCommand(sql, con)
                ' Use VarChar so this works whether file_id is numeric or text
                Dim idInt As Integer
                If Integer.TryParse(searchText, idInt) Then
                    cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = idInt
                Else
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = searchText
                End If
                cmd.Parameters.Add("@title", MySqlDbType.VarChar).Value = "%" & searchText & "%"

                Using da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    dgvFiless.DataSource = dt

                    If dt.Rows.Count = 0 Then
                        MessageBox.Show("No records found")
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CloseCon()
        End Try
    End Sub

    Private Sub dgvFiless_RowActivate(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFiless.CellContentClick, dgvFiless.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim fileIdColIndex As Integer = -1
        For Each col As DataGridViewColumn In dgvFiless.Columns
            If String.Equals(col.HeaderText, "File ID", StringComparison.OrdinalIgnoreCase) _
               OrElse String.Equals(col.Name, "File ID", StringComparison.OrdinalIgnoreCase) _
               OrElse String.Equals(col.DataPropertyName, "FileID", StringComparison.OrdinalIgnoreCase) Then
                fileIdColIndex = col.Index
                Exit For
            End If
        Next

        If fileIdColIndex = -1 Then
            MessageBox.Show("Could not find the 'File ID' column in the results. Verify the SQL aliases and DataGridView binding.")
            Return
        End If

        Dim fileIdValue = dgvFiless.Rows(e.RowIndex).Cells(fileIdColIndex).Value
        If fileIdValue Is Nothing OrElse Convert.IsDBNull(fileIdValue) Then
            MessageBox.Show("Selected row does not contain a valid File ID.")
            Return
        End If

        Dim fileID As String = fileIdValue.ToString()

        Try
            Dim frm As New UPDATE_FILE(Me)
            frm.SelectedFileID = fileID
            frm.ShowDialog()
            frm.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        parentDash.Show(Me)
        Me.Hide()
    End Sub
End Class
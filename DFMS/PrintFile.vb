Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.Text

Public Class PrintFile

    ' Holds the content to print
    Private printContent As String = ""

    ' ---------------------------
    ' 1. Load files from database
    ' ---------------------------
    Private Sub LoadFileList()
        ' MySQL connection string – update with your credentials

        Try
            ' SQL query to get files
            Dim sql As String = "SELECT FileID, FileTitle, Status, CreatedDate FROM File"

            ' Fill DataTable using DataAdapter

            Using cmd As New MySqlCommand(sql, con)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                ' Bind DataTable to DataGridView
                dgvFiles.DataSource = dt
            End Using


            ' Optional: hide FileID column
            If dgvFiles.Columns.Contains("FileID") Then
                dgvFiles.Columns("FileID").Visible = False
            End If

            ' Optional: auto-size columns to fit
            dgvFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MessageBox.Show("Error loading files: " & ex.Message)
        End Try
    End Sub

    ' ---------------------------
    ' 2. Form Load Event
    ' ---------------------------
    Private Sub PrintFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFileList() ' Load files when form opens
    End Sub

    ' ---------------------------
    ' 3. PrintDocument Event
    ' ---------------------------
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim printFont As New Font("Arial", 12)
        Dim leftMargin As Integer = e.MarginBounds.Left
        Dim topMargin As Integer = e.MarginBounds.Top

        e.Graphics.DrawString(printContent, printFont, Brushes.Black, leftMargin, topMargin)
    End Sub

    ' ---------------------------
    ' 4. Print Selected Files
    ' ---------------------------
    Private Sub btnPrintSelected_Click(sender As Object, e As EventArgs) Handles btnPrintSelected.Click
        Dim sb As New StringBuilder()

        For Each row As DataGridViewRow In dgvFiles.SelectedRows
            sb.AppendLine("File Title: " & row.Cells("FileTitle").Value)
            sb.AppendLine("Status: " & row.Cells("Status").Value)
            sb.AppendLine("Created Date: " & row.Cells("CreatedDate").Value)
            sb.AppendLine("------------------------")
        Next

        If sb.Length = 0 Then
            MessageBox.Show("Please select at least one file to print.")
            Return
        End If

        printContent = sb.ToString()
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    ' ---------------------------
    ' 5. Print All Files
    ' ---------------------------
    Private Sub btnPrintAll_Click(sender As Object, e As EventArgs) Handles btnPrintAll.Click
        Dim sb As New StringBuilder()
        For Each row As DataGridViewRow In dgvFiles.Rows
            If Not row.IsNewRow Then
                sb.AppendLine("File Title: " & row.Cells("FileTitle").Value)
                sb.AppendLine("Status: " & row.Cells("Status").Value)
                sb.AppendLine("Created Date: " & row.Cells("CreatedDate").Value)
                sb.AppendLine("------------------------")
            End If
        Next

        If sb.Length = 0 Then
            MessageBox.Show("No files available to print.")
            Return
        End If

        printContent = sb.ToString()
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    ' ---------------------------
    ' 6. Refresh Button
    ' ---------------------------
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadFileList() ' Reload the DataGridView
    End Sub

End Class
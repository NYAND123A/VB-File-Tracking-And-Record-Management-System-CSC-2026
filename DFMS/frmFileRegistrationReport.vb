Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient
Imports Mysqlx


Public Class frmFileRegistrationReport
    Private parentDash As Dashboard
    Public Sub New(dash As Dashboard)
        InitializeComponent()
        parentDash = dash
    End Sub

    Dim selectedRow As DataGridViewRow
    Dim rowIndex As Integer = 0
    Dim newPage As Boolean = True

    Dim conStr As String = "server=localhost;user id=root;password=;database=file_tracking;"
    Private txtUsername As Object

    Private Sub LoadAllFiles()

        Dim sql As String = "SELECT FileID, FileTitle, Department, FILE_STATUS, Date_Created FROM File ORDER BY Date_Created  DESC"

        Using cmd As New MySqlCommand(sql, con)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvFileReport.DataSource = dt
            lblTotal.Text = "Total Records: " & dt.Rows.Count
        End Using

    End Sub


    Private Sub frmFileRegistrationReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenCon()
        LoadAllFiles()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadAllFiles()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim sql As String = "SELECT FileID, FileTitle, Department, FILE_STATUS, Date_Created 
                         FROM File 
                         WHERE DATE(Date_Created) BETWEEN @from AND @to
                         ORDER BY Date_Created DESC"

        Using cmd As New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@from", dtpFrom.Value.Date)
            cmd.Parameters.AddWithValue("@to", dtpTo.Value.Date)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvFileReport.DataSource = dt
            lblTotal.Text = "Total Records: " & dt.Rows.Count
        End Using
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        If dgvFileReport.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a file to print.")
            Exit Sub
        End If

        selectedRow = dgvFileReport.SelectedRows(0)

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()


        If dgvFileReport.Rows.Count = 0 Then
            MessageBox.Show("No data to print.")
            Exit Sub
        End If

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim titleFont As New Font("Arial", 14, FontStyle.Bold)
        Dim font As New Font("Arial", 11)

        Dim y As Integer = 100

        ' Title
        e.Graphics.DrawString("FILE DETAILS REPORT", titleFont, Brushes.Black, 100, 50)

        ' Print each column and its value
        For i As Integer = 0 To selectedRow.Cells.Count - 1

            Dim columnName As String = dgvFileReport.Columns(i).HeaderText
            Dim value As String = selectedRow.Cells(i).Value.ToString()

            e.Graphics.DrawString(columnName & ": " & value, font, Brushes.Black, 100, y)

            y += 30
        Next

        e.HasMorePages = False
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        parentDash.Show()
        Me.Close()

    End Sub
End Class
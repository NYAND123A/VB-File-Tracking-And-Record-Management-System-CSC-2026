Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Dashboard

    ' Values provided by the caller (Form1) after successful login
    Public Property LoggedInUser As String
    Public Property LoggedInRole As String
    Public Property LoggedInDepartment As String

    Private Function IsInDesignMode() As Boolean
        Return System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime OrElse Me.DesignMode
    End Function

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Show menu items based on role
        Select Case LoggedInRole
            Case "Admin"
                mnuFile.Visible = True
                mnuTracking.Visible = True
                mnuReports.Visible = True
                mnuTools.Visible = True
                mnuUsers.Visible = True
                mnuHelp.Visible = True
                mnuAccount.Visible = True


            Case "User"
                mnuFile.Visible = True
                mnuTracking.Visible = False
                mnuReports.Visible = True
                mnuTools.Visible = False
                mnuUsers.Visible = False
                mnuHelp.Visible = True
                mnuAccount.Visible = True


            Case Else
                MessageBox.Show("Unknown role! Contact admin.")
        End Select

        If IsInDesignMode() Then Return

        lblWelcome.Text = "👤 Welcome, " & LoggedInUser
        lblRole.Text = "🛡 Role: " & LoggedInRole
        lblDepartment.Text = "Department: " & LoggedInDepartment



    End Sub

    ' Event handlers (no Handles clauses)
    Private Sub mnuNewFile_Click(sender As Object, e As EventArgs)
        Dim frm As New FILE_REGISTRATION(Me)
        frm.Show()
    End Sub

    Private Sub mnuUpdateFile_Click(sender As Object, e As EventArgs)
        Dim frm As New UPDATE_FILE(Me)
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub mnuSearchFile_Click(sender As Object, e As EventArgs)
        Dim frm As New SearchFile(Me)
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub SendFileToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New FileSend(Me)
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub FileMovementHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New FileMovementHistory(Me)
        frm.Show()
        Me.Hide()
    End Sub

    ' Logout: return to login form
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            Dim loginForm As New LoginForm1()
            loginForm.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Logout failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)
        ' no-op
    End Sub

    Private Sub lblLoggedInUser_Click(sender As Object, e As EventArgs)
        ' optional
    End Sub

    Private Sub mnuNewFile_Click_1(sender As Object, e As EventArgs) Handles mnuNewFile.Click
        Dim frm As New FILE_REGISTRATION(Me)
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub mnuUpdateFile_Click_1(sender As Object, e As EventArgs) Handles mnuUpdateFile.Click
        Dim frm As New UPDATE_FILE(Me)
        frm.Show()
        Me.Hide()
    End Sub
    Private Sub mnuSearchFile_Click_1(sender As Object, e As EventArgs) Handles mnuSearchFile.Click
        Dim frm As New SearchFile(Me)
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub SendFileToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SendFileToolStripMenuItem.Click
        Dim frm As New FileSend(Me)
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub FileMovementHistoryToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles FileMovementHistoryToolStripMenuItem.Click
        Dim frm As New FileMovementHistory(Me)
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub AddUserToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem1.Click
        Dim frm As New AddUser(Me)
        frm.Show()
        Me.Hide()
    End Sub

    Public Class Dashboard



    End Class

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy  hh:mm:ss tt")
    End Sub

    Private Sub dgvFiles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub mnuPrintFile_Click(sender As Object, e As EventArgs) Handles mnuSentFile.Click
        Dim frms As New PrintFile()
        frms.Show()
        Me.Hide()
    End Sub

    Private Sub AllFileToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RegisteredFileToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChangePasswordToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem1.Click

        Dim loginForm As New LoginForm1
        loginForm.Show()

        Me.Close()

    End Sub

    Private Sub DailyFileMovementReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyFileMovementReportsToolStripMenuItem.Click
        Dim frm As New frmFileRegistrationReport(Me)
        frm.Show()
        Me.Close()
    End Sub
End Class
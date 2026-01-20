Public Class Dashboard
    Private Sub AllFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllFileToolStripMenuItem.Click

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuTools.Click

    End Sub

    Private Sub mnuNewFile_Click(sender As Object, e As EventArgs) Handles mnuNewFile.Click
        Dim frm As New FILE_REGISTRATION
        FILE_REGISTRATION.Show()

    End Sub

    Private Sub mnuUpdateFile_Click(sender As Object, e As EventArgs) Handles mnuUpdateFile.Click
        Dim frm As New UPDATE_FILE

        UPDATE_FILE.Show()

    End Sub

    Private Sub ReceiveFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceiveFileToolStripMenuItem.Click

    End Sub
End Class
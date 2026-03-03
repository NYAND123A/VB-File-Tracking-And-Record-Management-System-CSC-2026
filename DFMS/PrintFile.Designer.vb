<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintFile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintFile))
        dgvFiles = New DataGridView()
        btnPrintAll = New Button()
        btnRefresh = New Button()
        btnPrintSelected = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        CType(dgvFiles, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvFiles
        ' 
        dgvFiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFiles.Location = New Point(44, 97)
        dgvFiles.Name = "dgvFiles"
        dgvFiles.RowHeadersWidth = 62
        dgvFiles.Size = New Size(744, 284)
        dgvFiles.TabIndex = 0
        ' 
        ' btnPrintAll
        ' 
        btnPrintAll.Location = New Point(72, 387)
        btnPrintAll.Name = "btnPrintAll"
        btnPrintAll.Size = New Size(112, 34)
        btnPrintAll.TabIndex = 1
        btnPrintAll.Text = "Print All"
        btnPrintAll.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(652, 387)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(112, 34)
        btnRefresh.TabIndex = 2
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnPrintSelected
        ' 
        btnPrintSelected.Location = New Point(344, 387)
        btnPrintSelected.Name = "btnPrintSelected"
        btnPrintSelected.Size = New Size(131, 34)
        btnPrintSelected.TabIndex = 3
        btnPrintSelected.Text = "Print Selected"
        btnPrintSelected.UseVisualStyleBackColor = True
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintFile
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnPrintSelected)
        Controls.Add(btnRefresh)
        Controls.Add(btnPrintAll)
        Controls.Add(dgvFiles)
        Name = "PrintFile"
        Text = "PrintFile"
        CType(dgvFiles, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvFiles As DataGridView
    Friend WithEvents btnPrintAll As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnPrintSelected As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class

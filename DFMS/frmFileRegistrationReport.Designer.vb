<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFileRegistrationReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFileRegistrationReport))
        dgvFileReport = New DataGridView()
        dtpFrom = New DateTimePicker()
        dtpTo = New DateTimePicker()
        lblFrom = New Label()
        lblTo = New Label()
        btnLoad = New Button()
        btnPrint = New Button()
        btnFilter = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        lblTotal = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDialog1 = New PrintDialog()
        btnBack = New Button()
        CType(dgvFileReport, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvFileReport
        ' 
        dgvFileReport.BackgroundColor = SystemColors.Control
        dgvFileReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFileReport.Location = New Point(61, 189)
        dgvFileReport.MultiSelect = False
        dgvFileReport.Name = "dgvFileReport"
        dgvFileReport.RowHeadersWidth = 62
        dgvFileReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvFileReport.Size = New Size(662, 203)
        dgvFileReport.TabIndex = 0
        ' 
        ' dtpFrom
        ' 
        dtpFrom.Location = New Point(61, 149)
        dtpFrom.Name = "dtpFrom"
        dtpFrom.Size = New Size(288, 31)
        dtpFrom.TabIndex = 1
        ' 
        ' dtpTo
        ' 
        dtpTo.Location = New Point(432, 150)
        dtpTo.Name = "dtpTo"
        dtpTo.Size = New Size(291, 31)
        dtpTo.TabIndex = 2
        ' 
        ' lblFrom
        ' 
        lblFrom.AutoSize = True
        lblFrom.Location = New Point(7, 152)
        lblFrom.Name = "lblFrom"
        lblFrom.Size = New Size(54, 25)
        lblFrom.TabIndex = 3
        lblFrom.Text = "From"
        ' 
        ' lblTo
        ' 
        lblTo.AutoSize = True
        lblTo.Location = New Point(396, 155)
        lblTo.Name = "lblTo"
        lblTo.Size = New Size(30, 25)
        lblTo.TabIndex = 4
        lblTo.Text = "To"
        ' 
        ' btnLoad
        ' 
        btnLoad.Location = New Point(61, 94)
        btnLoad.Name = "btnLoad"
        btnLoad.Size = New Size(79, 34)
        btnLoad.TabIndex = 5
        btnLoad.Text = "Refresh"
        btnLoad.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Location = New Point(636, 94)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(82, 34)
        btnPrint.TabIndex = 6
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' btnFilter
        ' 
        btnFilter.Location = New Point(165, 94)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(85, 34)
        btnFilter.TabIndex = 7
        btnFilter.Text = "Filter"
        btnFilter.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 66)
        Panel1.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(261, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(279, 28)
        Label1.TabIndex = 0
        Label1.Text = "FILE REGISTRATION REPORT"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(60, 395)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(117, 25)
        lblTotal.TabIndex = 11
        lblTotal.Text = "Total Records"
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
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(6, 22)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(69, 34)
        btnBack.TabIndex = 1
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' frmFileRegistrationReport
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(lblTotal)
        Controls.Add(Panel1)
        Controls.Add(btnFilter)
        Controls.Add(btnPrint)
        Controls.Add(btnLoad)
        Controls.Add(lblTo)
        Controls.Add(lblFrom)
        Controls.Add(dtpTo)
        Controls.Add(dtpFrom)
        Controls.Add(dgvFileReport)
        Name = "frmFileRegistrationReport"
        Text = "frmFileRegistrationReport"
        CType(dgvFileReport, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvFileReport As DataGridView
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents btnBack As Button
End Class

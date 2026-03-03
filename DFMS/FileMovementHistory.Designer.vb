<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileMovementHistory
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
        Panel1 = New Panel()
        btnBack = New Button()
        lblFileMovementHistory = New Label()
        Panel2 = New Panel()
        btnViewHistory = New Button()
        btnSearch = New Button()
        cboFileName = New ComboBox()
        txtFileID = New TextBox()
        lblFileName = New Label()
        lblFileID = New Label()
        lblSearchFile = New Label()
        dgvHistory = New DataGridView()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgvHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(lblFileMovementHistory)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 52)
        Panel1.TabIndex = 0
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(12, 9)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(63, 34)
        btnBack.TabIndex = 1
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' lblFileMovementHistory
        ' 
        lblFileMovementHistory.AutoSize = True
        lblFileMovementHistory.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFileMovementHistory.Location = New Point(274, 9)
        lblFileMovementHistory.Name = "lblFileMovementHistory"
        lblFileMovementHistory.Size = New Size(246, 25)
        lblFileMovementHistory.TabIndex = 0
        lblFileMovementHistory.Text = "FILE MOVEMENT HISTORY"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(btnViewHistory)
        Panel2.Controls.Add(btnSearch)
        Panel2.Controls.Add(cboFileName)
        Panel2.Controls.Add(txtFileID)
        Panel2.Controls.Add(lblFileName)
        Panel2.Controls.Add(lblFileID)
        Panel2.Controls.Add(lblSearchFile)
        Panel2.Location = New Point(1, 58)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(799, 138)
        Panel2.TabIndex = 1
        ' 
        ' btnViewHistory
        ' 
        btnViewHistory.Location = New Point(486, 91)
        btnViewHistory.Name = "btnViewHistory"
        btnViewHistory.Size = New Size(126, 34)
        btnViewHistory.TabIndex = 10
        btnViewHistory.Text = "View History"
        btnViewHistory.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(244, 91)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(126, 34)
        btnSearch.TabIndex = 9
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' cboFileName
        ' 
        cboFileName.FormattingEnabled = True
        cboFileName.Items.AddRange(New Object() {"Student Registration File", "Service Levy", "Farmers Registration File", "Entreprenourship Registration", "Research Proposal Submission File", "Student Admission Records", "Student Transcript Request", "Examination Results File", "Course Registration Forms", "Graduation Clearance File", "Scholarship Application File", "Student Disciplinary Case File", "Academic Staff Appointment File"})
        cboFileName.Location = New Point(486, 42)
        cboFileName.Name = "cboFileName"
        cboFileName.Size = New Size(238, 33)
        cboFileName.TabIndex = 8
        ' 
        ' txtFileID
        ' 
        txtFileID.Location = New Point(133, 44)
        txtFileID.Name = "txtFileID"
        txtFileID.Size = New Size(237, 31)
        txtFileID.TabIndex = 7
        ' 
        ' lblFileName
        ' 
        lblFileName.AutoSize = True
        lblFileName.Location = New Point(376, 47)
        lblFileName.Name = "lblFileName"
        lblFileName.Size = New Size(90, 25)
        lblFileName.TabIndex = 4
        lblFileName.Text = "File Name"
        ' 
        ' lblFileID
        ' 
        lblFileID.AutoSize = True
        lblFileID.Location = New Point(56, 47)
        lblFileID.Name = "lblFileID"
        lblFileID.Size = New Size(61, 25)
        lblFileID.TabIndex = 5
        lblFileID.Text = "File ID"
        ' 
        ' lblSearchFile
        ' 
        lblSearchFile.AutoSize = True
        lblSearchFile.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSearchFile.Location = New Point(56, 9)
        lblSearchFile.Name = "lblSearchFile"
        lblSearchFile.Size = New Size(107, 25)
        lblSearchFile.TabIndex = 6
        lblSearchFile.Text = "Search File"
        ' 
        ' dgvHistory
        ' 
        dgvHistory.BackgroundColor = Color.SteelBlue
        dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHistory.Dock = DockStyle.Bottom
        dgvHistory.GridColor = SystemColors.ActiveCaption
        dgvHistory.Location = New Point(0, 202)
        dgvHistory.Name = "dgvHistory"
        dgvHistory.RowHeadersWidth = 62
        dgvHistory.Size = New Size(800, 248)
        dgvHistory.TabIndex = 2
        ' 
        ' FileMovementHistory
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvHistory)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "FileMovementHistory"
        Text = "FileMovementHistory"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgvHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblFileMovementHistory As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblSearchFile As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblFileName As Label
    Friend WithEvents lblFileID As Label
    Friend WithEvents cboFileName As ComboBox
    Friend WithEvents txtFileID As TextBox
    Friend WithEvents btnViewHistory As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvHistory As DataGridView
    Friend WithEvents btnBack As Button
End Class

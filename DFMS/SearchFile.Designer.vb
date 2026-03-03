<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchFile
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        txtSearch = New TextBox()
        btnSearch = New Button()
        dgvFiless = New DataGridView()
        lblSearchbyFile = New Label()
        btnClose = New Button()
        btnBack = New Button()
        CType(dgvFiless, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(171, 57)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(371, 31)
        txtSearch.TabIndex = 0
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(570, 54)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(112, 34)
        btnSearch.TabIndex = 1
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' dgvFiless
        ' 
        dgvFiless.BackgroundColor = Color.PowderBlue
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvFiless.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvFiless.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFiless.Location = New Point(27, 136)
        dgvFiless.Name = "dgvFiless"
        dgvFiless.RowHeadersWidth = 62
        dgvFiless.Size = New Size(747, 239)
        dgvFiless.TabIndex = 2
        ' 
        ' lblSearchbyFile
        ' 
        lblSearchbyFile.AutoSize = True
        lblSearchbyFile.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSearchbyFile.Location = New Point(286, 9)
        lblSearchbyFile.Name = "lblSearchbyFile"
        lblSearchbyFile.Size = New Size(219, 25)
        lblSearchbyFile.TabIndex = 3
        lblSearchbyFile.Text = "Search by File ID or Title"
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(322, 398)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(112, 34)
        btnClose.TabIndex = 4
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.White
        btnBack.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = SystemColors.ActiveCaptionText
        btnBack.Location = New Point(12, 5)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(78, 34)
        btnBack.TabIndex = 19
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' SearchFile
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnBack)
        Controls.Add(btnClose)
        Controls.Add(lblSearchbyFile)
        Controls.Add(dgvFiless)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Name = "SearchFile"
        Text = "SearchFile"
        CType(dgvFiless, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvFiless As DataGridView
    Friend WithEvents lblSearchbyFile As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnBack As Button
End Class

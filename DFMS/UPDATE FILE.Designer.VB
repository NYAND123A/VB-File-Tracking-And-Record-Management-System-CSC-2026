<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UPDATE_FILE
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
        Label1 = New Label()
        lblFile = New Label()
        txtSearch = New TextBox()
        btnSearch = New Button()
        lblFileid = New Label()
        lblFileTitle = New Label()
        lblDepartment = New Label()
        lblPriority = New Label()
        lblDescription = New Label()
        btnClear = New Button()
        btnUpdate = New Button()
        txtFileID = New TextBox()
        txtFileTitle = New TextBox()
        cboDepartment = New ComboBox()
        rdoNormal = New RadioButton()
        rdoUrgent = New RadioButton()
        txtDescription = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(259, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(198, 25)
        Label1.TabIndex = 0
        Label1.Text = "UPDATE FILE RECORD"
        ' 
        ' lblFile
        ' 
        lblFile.AutoSize = True
        lblFile.Location = New Point(129, 109)
        lblFile.Name = "lblFile"
        lblFile.Size = New Size(100, 25)
        lblFile.TabIndex = 1
        lblFile.Text = "File ID/Title"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(262, 109)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(195, 31)
        txtSearch.TabIndex = 2
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(523, 109)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(112, 34)
        btnSearch.TabIndex = 3
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' lblFileid
        ' 
        lblFileid.AutoSize = True
        lblFileid.Location = New Point(139, 165)
        lblFileid.Name = "lblFileid"
        lblFileid.Size = New Size(61, 25)
        lblFileid.TabIndex = 4
        lblFileid.Text = "File ID"
        ' 
        ' lblFileTitle
        ' 
        lblFileTitle.AutoSize = True
        lblFileTitle.Location = New Point(139, 220)
        lblFileTitle.Name = "lblFileTitle"
        lblFileTitle.Size = New Size(75, 25)
        lblFileTitle.TabIndex = 5
        lblFileTitle.Text = "File Title"
        ' 
        ' lblDepartment
        ' 
        lblDepartment.AutoSize = True
        lblDepartment.Location = New Point(139, 285)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(107, 25)
        lblDepartment.TabIndex = 6
        lblDepartment.Text = "Department"
        ' 
        ' lblPriority
        ' 
        lblPriority.AutoSize = True
        lblPriority.Location = New Point(146, 353)
        lblPriority.Name = "lblPriority"
        lblPriority.Size = New Size(68, 25)
        lblPriority.TabIndex = 7
        lblPriority.Text = "Priority"
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.Location = New Point(139, 412)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(102, 25)
        lblDescription.TabIndex = 8
        lblDescription.Text = "Description"
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(259, 475)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 9
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(523, 475)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(112, 34)
        btnUpdate.TabIndex = 10
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' txtFileID
        ' 
        txtFileID.Location = New Point(262, 162)
        txtFileID.Name = "txtFileID"
        txtFileID.Size = New Size(373, 31)
        txtFileID.TabIndex = 11
        ' 
        ' txtFileTitle
        ' 
        txtFileTitle.Location = New Point(259, 227)
        txtFileTitle.Name = "txtFileTitle"
        txtFileTitle.Size = New Size(376, 31)
        txtFileTitle.TabIndex = 12
        ' 
        ' cboDepartment
        ' 
        cboDepartment.FormattingEnabled = True
        cboDepartment.Location = New Point(262, 285)
        cboDepartment.Name = "cboDepartment"
        cboDepartment.Size = New Size(373, 33)
        cboDepartment.TabIndex = 13
        ' 
        ' rdoNormal
        ' 
        rdoNormal.AutoSize = True
        rdoNormal.Location = New Point(262, 351)
        rdoNormal.Name = "rdoNormal"
        rdoNormal.Size = New Size(96, 29)
        rdoNormal.TabIndex = 14
        rdoNormal.TabStop = True
        rdoNormal.Text = "Normal"
        rdoNormal.UseVisualStyleBackColor = True
        ' 
        ' rdoUrgent
        ' 
        rdoUrgent.AutoSize = True
        rdoUrgent.Location = New Point(489, 353)
        rdoUrgent.Name = "rdoUrgent"
        rdoUrgent.Size = New Size(91, 29)
        rdoUrgent.TabIndex = 15
        rdoUrgent.TabStop = True
        rdoUrgent.Text = "Urgent"
        rdoUrgent.UseVisualStyleBackColor = True
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(262, 414)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(373, 31)
        txtDescription.TabIndex = 16
        ' 
        ' UPDATE_FILE
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 562)
        Controls.Add(txtDescription)
        Controls.Add(rdoUrgent)
        Controls.Add(rdoNormal)
        Controls.Add(cboDepartment)
        Controls.Add(txtFileTitle)
        Controls.Add(txtFileID)
        Controls.Add(btnUpdate)
        Controls.Add(btnClear)
        Controls.Add(lblDescription)
        Controls.Add(lblPriority)
        Controls.Add(lblDepartment)
        Controls.Add(lblFileTitle)
        Controls.Add(lblFileid)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(lblFile)
        Controls.Add(Label1)
        Name = "UPDATE_FILE"
        Text = "UPDATE_FILE"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblFile As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblFileid As Label
    Friend WithEvents lblFileTitle As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblPriority As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtFileID As TextBox
    Friend WithEvents txtFileTitle As TextBox
    Friend WithEvents cboDepartment As ComboBox
    Friend WithEvents rdoNormal As RadioButton
    Friend WithEvents rdoUrgent As RadioButton
    Friend WithEvents txtDescription As TextBox
End Class

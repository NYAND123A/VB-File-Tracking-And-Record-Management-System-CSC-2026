<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FILE_REGISTRATION
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
        lblTitle = New Label()
        lblFileID = New Label()
        lblFileTitle = New Label()
        lblDepartment = New Label()
        lblPriority = New Label()
        lblDescription = New Label()
        txtFileID = New TextBox()
        txtFileTitle = New TextBox()
        cboDepartment = New ComboBox()
        rdoNormal = New RadioButton()
        rdoUrgent = New RadioButton()
        txtDescription = New TextBox()
        btnClear = New Button()
        btnSave = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = SystemColors.InactiveCaption
        lblTitle.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.Black
        lblTitle.Location = New Point(249, 23)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(229, 25)
        lblTitle.TabIndex = 0
        lblTitle.Text = "NEW FILE REGISTRATION"
        ' 
        ' lblFileID
        ' 
        lblFileID.AutoSize = True
        lblFileID.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFileID.Location = New Point(84, 92)
        lblFileID.Name = "lblFileID"
        lblFileID.Size = New Size(65, 25)
        lblFileID.TabIndex = 1
        lblFileID.Text = "File ID"
        ' 
        ' lblFileTitle
        ' 
        lblFileTitle.AutoSize = True
        lblFileTitle.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFileTitle.Location = New Point(84, 142)
        lblFileTitle.Name = "lblFileTitle"
        lblFileTitle.Size = New Size(84, 25)
        lblFileTitle.TabIndex = 2
        lblFileTitle.Text = "File Title"
        ' 
        ' lblDepartment
        ' 
        lblDepartment.AutoSize = True
        lblDepartment.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDepartment.Location = New Point(84, 202)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(115, 25)
        lblDepartment.TabIndex = 3
        lblDepartment.Text = "Department"
        ' 
        ' lblPriority
        ' 
        lblPriority.AutoSize = True
        lblPriority.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPriority.Location = New Point(84, 267)
        lblPriority.Name = "lblPriority"
        lblPriority.Size = New Size(75, 25)
        lblPriority.TabIndex = 4
        lblPriority.Text = "Priority"
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDescription.Location = New Point(84, 345)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(109, 25)
        lblDescription.TabIndex = 5
        lblDescription.Text = "Description"
        ' 
        ' txtFileID
        ' 
        txtFileID.Location = New Point(249, 92)
        txtFileID.Name = "txtFileID"
        txtFileID.Size = New Size(351, 31)
        txtFileID.TabIndex = 6
        ' 
        ' txtFileTitle
        ' 
        txtFileTitle.Location = New Point(249, 142)
        txtFileTitle.Name = "txtFileTitle"
        txtFileTitle.Size = New Size(351, 31)
        txtFileTitle.TabIndex = 7
        ' 
        ' cboDepartment
        ' 
        cboDepartment.FormattingEnabled = True
        cboDepartment.Items.AddRange(New Object() {"HRO", "FINANCE", "LAW", "EDUCATION", "ENVIRONMENT", "AGRICULTURE AND FISHING", "BUSINESS"})
        cboDepartment.Location = New Point(249, 199)
        cboDepartment.Name = "cboDepartment"
        cboDepartment.Size = New Size(351, 33)
        cboDepartment.TabIndex = 8
        ' 
        ' rdoNormal
        ' 
        rdoNormal.AutoSize = True
        rdoNormal.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rdoNormal.Location = New Point(249, 265)
        rdoNormal.Name = "rdoNormal"
        rdoNormal.Size = New Size(99, 29)
        rdoNormal.TabIndex = 9
        rdoNormal.TabStop = True
        rdoNormal.Text = "Normal"
        rdoNormal.UseVisualStyleBackColor = True
        ' 
        ' rdoUrgent
        ' 
        rdoUrgent.AutoSize = True
        rdoUrgent.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rdoUrgent.Location = New Point(443, 265)
        rdoUrgent.Name = "rdoUrgent"
        rdoUrgent.Size = New Size(92, 29)
        rdoUrgent.TabIndex = 10
        rdoUrgent.TabStop = True
        rdoUrgent.Text = "Urgent"
        rdoUrgent.UseVisualStyleBackColor = True
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(249, 339)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(351, 31)
        txtDescription.TabIndex = 11
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(249, 424)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 12
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(488, 424)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(112, 34)
        btnSave.TabIndex = 13
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' FILE_REGISTRATION
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(800, 516)
        Controls.Add(btnSave)
        Controls.Add(btnClear)
        Controls.Add(txtDescription)
        Controls.Add(rdoUrgent)
        Controls.Add(rdoNormal)
        Controls.Add(cboDepartment)
        Controls.Add(txtFileTitle)
        Controls.Add(txtFileID)
        Controls.Add(lblDescription)
        Controls.Add(lblPriority)
        Controls.Add(lblDepartment)
        Controls.Add(lblFileTitle)
        Controls.Add(lblFileID)
        Controls.Add(lblTitle)
        Name = "FILE_REGISTRATION"
        Text = "FILE_REGISTRATION"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblFileID As Label
    Friend WithEvents lblFileTitle As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblPriority As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtFileID As TextBox
    Friend WithEvents txtFileTitle As TextBox
    Friend WithEvents cboDepartment As ComboBox
    Friend WithEvents rdoNormal As RadioButton
    Friend WithEvents rdoUrgent As RadioButton
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
End Class

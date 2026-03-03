<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
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
        Label1 = New Label()
        btnSave = New Button()
        lblUserID = New Label()
        lblUsername = New Label()
        lblPassword = New Label()
        lblRole = New Label()
        lblDepartment = New Label()
        txtUserID = New TextBox()
        txtDepartment = New TextBox()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        cboRole = New ComboBox()
        btnBack = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 56)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(297, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 28)
        Label1.TabIndex = 0
        Label1.Text = "REGISTER USERS"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(336, 287)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(112, 34)
        btnSave.TabIndex = 1
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' lblUserID
        ' 
        lblUserID.AutoSize = True
        lblUserID.Location = New Point(93, 70)
        lblUserID.Name = "lblUserID"
        lblUserID.Size = New Size(70, 25)
        lblUserID.TabIndex = 2
        lblUserID.Text = "User ID"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(93, 113)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(91, 25)
        lblUsername.TabIndex = 3
        lblUsername.Text = "Username"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(93, 153)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(87, 25)
        lblPassword.TabIndex = 4
        lblPassword.Text = "Password"
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Location = New Point(93, 191)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(46, 25)
        lblRole.TabIndex = 5
        lblRole.Text = "Role"
        ' 
        ' lblDepartment
        ' 
        lblDepartment.AutoSize = True
        lblDepartment.Location = New Point(93, 231)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(107, 25)
        lblDepartment.TabIndex = 6
        lblDepartment.Text = "Department"
        ' 
        ' txtUserID
        ' 
        txtUserID.Location = New Point(214, 67)
        txtUserID.Name = "txtUserID"
        txtUserID.Size = New Size(365, 31)
        txtUserID.TabIndex = 7
        ' 
        ' txtDepartment
        ' 
        txtDepartment.Location = New Point(213, 231)
        txtDepartment.Name = "txtDepartment"
        txtDepartment.Size = New Size(365, 31)
        txtDepartment.TabIndex = 8
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(214, 147)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(365, 31)
        txtPassword.TabIndex = 10
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(214, 110)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(365, 31)
        txtUsername.TabIndex = 11
        ' 
        ' cboRole
        ' 
        cboRole.FormattingEnabled = True
        cboRole.Items.AddRange(New Object() {"Admin", "Finance Officer", "Registry", "Education Officer", "Business Officer", "Agricultural Officer"})
        cboRole.Location = New Point(210, 188)
        cboRole.Name = "cboRole"
        cboRole.Size = New Size(368, 33)
        cboRole.TabIndex = 12
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(7, 6)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(57, 34)
        btnBack.TabIndex = 1
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' AddUser
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cboRole)
        Controls.Add(txtUsername)
        Controls.Add(txtPassword)
        Controls.Add(txtDepartment)
        Controls.Add(txtUserID)
        Controls.Add(lblDepartment)
        Controls.Add(lblRole)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(lblUserID)
        Controls.Add(btnSave)
        Controls.Add(Panel1)
        Name = "AddUser"
        Text = "AddUser"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents lblUserID As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents btnBack As Button
End Class

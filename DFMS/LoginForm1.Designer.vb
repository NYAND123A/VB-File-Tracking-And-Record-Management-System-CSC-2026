<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm1
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
        lblUserName = New Label()
        lblPassword = New Label()
        btnLogin = New Button()
        txtUserName = New TextBox()
        txtPassword = New TextBox()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(181, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(429, 25)
        Label1.TabIndex = 0
        Label1.Text = "DIGITAL FILE TRACKING MANAGEMENT SYSTEM"
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Location = New Point(189, 106)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(104, 25)
        lblUserName.TabIndex = 1
        lblUserName.Text = "USERNAME"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(194, 166)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(108, 25)
        lblPassword.TabIndex = 2
        lblPassword.Text = "PASSWORD"
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(402, 215)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 34)
        btnLogin.TabIndex = 3
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtUserName
        ' 
        txtUserName.Location = New Point(303, 101)
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(289, 31)
        txtUserName.TabIndex = 4
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(303, 163)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(289, 31)
        txtPassword.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 64)
        Panel1.TabIndex = 6
        ' 
        ' LoginForm1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(txtPassword)
        Controls.Add(txtUserName)
        Controls.Add(btnLogin)
        Controls.Add(lblPassword)
        Controls.Add(lblUserName)
        Name = "LoginForm1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Panel1 As Panel
End Class

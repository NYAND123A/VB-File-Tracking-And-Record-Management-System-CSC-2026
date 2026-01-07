<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        lblUserName = New Label()
        lblPassword = New Label()
        txtUserName = New TextBox()
        txtPassword = New TextBox()
        BtnLogin = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(156, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(491, 22)
        Label1.TabIndex = 0
        Label1.Text = "FILE TRACKING AND RECORD MANAGEMENT SYSTEM"
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Location = New Point(189, 115)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(109, 25)
        lblUserName.TabIndex = 1
        lblUserName.Text = "USER NAME"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(189, 165)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(108, 25)
        lblPassword.TabIndex = 2
        lblPassword.Text = "PASSWORD"
        ' 
        ' txtUserName
        ' 
        txtUserName.Location = New Point(316, 112)
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(249, 31)
        txtUserName.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(316, 162)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(249, 31)
        txtPassword.TabIndex = 4
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Location = New Point(392, 218)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(99, 32)
        BtnLogin.TabIndex = 5
        BtnLogin.Text = "LOGIN"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUserName)
        Controls.Add(lblPassword)
        Controls.Add(lblUserName)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents BtnLogin As Button

End Class

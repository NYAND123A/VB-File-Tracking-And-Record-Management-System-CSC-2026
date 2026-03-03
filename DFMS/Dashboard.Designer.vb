<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        MenuStrip1 = New MenuStrip()
        mnuFile = New ToolStripMenuItem()
        mnuNewFile = New ToolStripMenuItem()
        mnuUpdateFile = New ToolStripMenuItem()
        mnuSearchFile = New ToolStripMenuItem()
        mnuSentFile = New ToolStripMenuItem()
        mnuExit = New ToolStripMenuItem()
        mnuTracking = New ToolStripMenuItem()
        SendFileToolStripMenuItem = New ToolStripMenuItem()
        ReceiveFileToolStripMenuItem = New ToolStripMenuItem()
        FileMovementHistoryToolStripMenuItem = New ToolStripMenuItem()
        PendingFilesToolStripMenuItem = New ToolStripMenuItem()
        CompletedFilesToolStripMenuItem = New ToolStripMenuItem()
        mnuReports = New ToolStripMenuItem()
        DailyFileMovementReportsToolStripMenuItem = New ToolStripMenuItem()
        MonthlyReportToolStripMenuItem = New ToolStripMenuItem()
        DepartmentReportToolStripMenuItem = New ToolStripMenuItem()
        UserActivityReportToolStripMenuItem = New ToolStripMenuItem()
        ExportToPDFExcelToolStripMenuItem = New ToolStripMenuItem()
        mnuTools = New ToolStripMenuItem()
        SystemSettingToolStripMenuItem = New ToolStripMenuItem()
        ManageDepartmentToolStripMenuItem = New ToolStripMenuItem()
        DatabaseBackupToolStripMenuItem = New ToolStripMenuItem()
        RestorDatabaseToolStripMenuItem = New ToolStripMenuItem()
        AuditLogToolStripMenuItem = New ToolStripMenuItem()
        SystemActivityLogToolStripMenuItem = New ToolStripMenuItem()
        mnuUsers = New ToolStripMenuItem()
        AddUserToolStripMenuItem = New ToolStripMenuItem()
        AddUserToolStripMenuItem1 = New ToolStripMenuItem()
        RemoveUserToolStripMenuItem = New ToolStripMenuItem()
        EditUserToolStripMenuItem = New ToolStripMenuItem()
        DeactivateUserToolStripMenuItem = New ToolStripMenuItem()
        ChangePasswordToolStripMenuItem = New ToolStripMenuItem()
        UserRolesPermissionToolStripMenuItem = New ToolStripMenuItem()
        mnuHelp = New ToolStripMenuItem()
        UserManualToolStripMenuItem = New ToolStripMenuItem()
        HowToUseTheSystemToolStripMenuItem = New ToolStripMenuItem()
        ContactSupportToolStripMenuItem = New ToolStripMenuItem()
        mnuAccount = New ToolStripMenuItem()
        MyProfileToolStripMenuItem = New ToolStripMenuItem()
        ChangePasswordToolStripMenuItem1 = New ToolStripMenuItem()
        LogOutToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        Panel1 = New Panel()
        lblDepartment = New Label()
        lblRole = New Label()
        lblDateTime = New Label()
        lblWelcome = New Label()
        Panel2 = New Panel()
        FontDialog1 = New FontDialog()
        Timer1 = New Timer(components)
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.SteelBlue
        MenuStrip1.Font = New Font("Segoe UI", 9F)
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuFile, mnuTracking, mnuReports, mnuTools, mnuUsers, mnuHelp, mnuAccount, ToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1000, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuFile
        ' 
        mnuFile.DropDownItems.AddRange(New ToolStripItem() {mnuNewFile, mnuUpdateFile, mnuSearchFile, mnuSentFile, mnuExit})
        mnuFile.Name = "mnuFile"
        mnuFile.Size = New Size(54, 29)
        mnuFile.Text = "File"
        ' 
        ' mnuNewFile
        ' 
        mnuNewFile.BackColor = Color.White
        mnuNewFile.ForeColor = Color.Black
        mnuNewFile.Image = CType(resources.GetObject("mnuNewFile.Image"), Image)
        mnuNewFile.Name = "mnuNewFile"
        mnuNewFile.Size = New Size(270, 34)
        mnuNewFile.Text = "New File"
        ' 
        ' mnuUpdateFile
        ' 
        mnuUpdateFile.BackColor = Color.White
        mnuUpdateFile.Image = CType(resources.GetObject("mnuUpdateFile.Image"), Image)
        mnuUpdateFile.Name = "mnuUpdateFile"
        mnuUpdateFile.Size = New Size(270, 34)
        mnuUpdateFile.Text = "Update File"
        ' 
        ' mnuSearchFile
        ' 
        mnuSearchFile.BackColor = Color.White
        mnuSearchFile.Image = CType(resources.GetObject("mnuSearchFile.Image"), Image)
        mnuSearchFile.Name = "mnuSearchFile"
        mnuSearchFile.Size = New Size(270, 34)
        mnuSearchFile.Text = "Search File"
        ' 
        ' mnuSentFile
        ' 
        mnuSentFile.BackColor = Color.White
        mnuSentFile.Image = CType(resources.GetObject("mnuSentFile.Image"), Image)
        mnuSentFile.Name = "mnuSentFile"
        mnuSentFile.Size = New Size(270, 34)
        mnuSentFile.Text = "Print File"
        ' 
        ' mnuExit
        ' 
        mnuExit.BackColor = Color.White
        mnuExit.Image = CType(resources.GetObject("mnuExit.Image"), Image)
        mnuExit.Name = "mnuExit"
        mnuExit.Size = New Size(270, 34)
        mnuExit.Text = "Exit"
        ' 
        ' mnuTracking
        ' 
        mnuTracking.DropDownItems.AddRange(New ToolStripItem() {SendFileToolStripMenuItem, ReceiveFileToolStripMenuItem, FileMovementHistoryToolStripMenuItem, PendingFilesToolStripMenuItem, CompletedFilesToolStripMenuItem})
        mnuTracking.Name = "mnuTracking"
        mnuTracking.Size = New Size(92, 29)
        mnuTracking.Text = "Tracking"
        ' 
        ' SendFileToolStripMenuItem
        ' 
        SendFileToolStripMenuItem.BackColor = Color.White
        SendFileToolStripMenuItem.Image = CType(resources.GetObject("SendFileToolStripMenuItem.Image"), Image)
        SendFileToolStripMenuItem.Name = "SendFileToolStripMenuItem"
        SendFileToolStripMenuItem.Size = New Size(293, 34)
        SendFileToolStripMenuItem.Text = "Send File"
        ' 
        ' ReceiveFileToolStripMenuItem
        ' 
        ReceiveFileToolStripMenuItem.BackColor = Color.White
        ReceiveFileToolStripMenuItem.Image = CType(resources.GetObject("ReceiveFileToolStripMenuItem.Image"), Image)
        ReceiveFileToolStripMenuItem.Name = "ReceiveFileToolStripMenuItem"
        ReceiveFileToolStripMenuItem.Size = New Size(293, 34)
        ReceiveFileToolStripMenuItem.Text = "Receive File"
        ' 
        ' FileMovementHistoryToolStripMenuItem
        ' 
        FileMovementHistoryToolStripMenuItem.BackColor = Color.White
        FileMovementHistoryToolStripMenuItem.Image = CType(resources.GetObject("FileMovementHistoryToolStripMenuItem.Image"), Image)
        FileMovementHistoryToolStripMenuItem.Name = "FileMovementHistoryToolStripMenuItem"
        FileMovementHistoryToolStripMenuItem.Size = New Size(293, 34)
        FileMovementHistoryToolStripMenuItem.Text = "File Movement History"
        ' 
        ' PendingFilesToolStripMenuItem
        ' 
        PendingFilesToolStripMenuItem.BackColor = Color.White
        PendingFilesToolStripMenuItem.Image = CType(resources.GetObject("PendingFilesToolStripMenuItem.Image"), Image)
        PendingFilesToolStripMenuItem.Name = "PendingFilesToolStripMenuItem"
        PendingFilesToolStripMenuItem.Size = New Size(293, 34)
        PendingFilesToolStripMenuItem.Text = "Pending Files"
        ' 
        ' CompletedFilesToolStripMenuItem
        ' 
        CompletedFilesToolStripMenuItem.BackColor = Color.White
        CompletedFilesToolStripMenuItem.Image = CType(resources.GetObject("CompletedFilesToolStripMenuItem.Image"), Image)
        CompletedFilesToolStripMenuItem.Name = "CompletedFilesToolStripMenuItem"
        CompletedFilesToolStripMenuItem.Size = New Size(293, 34)
        CompletedFilesToolStripMenuItem.Text = "Completed Files"
        ' 
        ' mnuReports
        ' 
        mnuReports.DropDownItems.AddRange(New ToolStripItem() {DailyFileMovementReportsToolStripMenuItem, MonthlyReportToolStripMenuItem, DepartmentReportToolStripMenuItem, UserActivityReportToolStripMenuItem, ExportToPDFExcelToolStripMenuItem})
        mnuReports.Name = "mnuReports"
        mnuReports.Size = New Size(89, 29)
        mnuReports.Text = "Reports"
        ' 
        ' DailyFileMovementReportsToolStripMenuItem
        ' 
        DailyFileMovementReportsToolStripMenuItem.Name = "DailyFileMovementReportsToolStripMenuItem"
        DailyFileMovementReportsToolStripMenuItem.Size = New Size(305, 34)
        DailyFileMovementReportsToolStripMenuItem.Text = "File Registration Reports"
        ' 
        ' MonthlyReportToolStripMenuItem
        ' 
        MonthlyReportToolStripMenuItem.Name = "MonthlyReportToolStripMenuItem"
        MonthlyReportToolStripMenuItem.Size = New Size(305, 34)
        MonthlyReportToolStripMenuItem.Text = "File Movement Reports"
        ' 
        ' DepartmentReportToolStripMenuItem
        ' 
        DepartmentReportToolStripMenuItem.Name = "DepartmentReportToolStripMenuItem"
        DepartmentReportToolStripMenuItem.Size = New Size(305, 34)
        DepartmentReportToolStripMenuItem.Text = "Login User Reports"
        ' 
        ' UserActivityReportToolStripMenuItem
        ' 
        UserActivityReportToolStripMenuItem.Name = "UserActivityReportToolStripMenuItem"
        UserActivityReportToolStripMenuItem.Size = New Size(305, 34)
        ' 
        ' ExportToPDFExcelToolStripMenuItem
        ' 
        ExportToPDFExcelToolStripMenuItem.Name = "ExportToPDFExcelToolStripMenuItem"
        ExportToPDFExcelToolStripMenuItem.Size = New Size(305, 34)
        ' 
        ' mnuTools
        ' 
        mnuTools.DropDownItems.AddRange(New ToolStripItem() {SystemSettingToolStripMenuItem, ManageDepartmentToolStripMenuItem, DatabaseBackupToolStripMenuItem, RestorDatabaseToolStripMenuItem, AuditLogToolStripMenuItem, SystemActivityLogToolStripMenuItem})
        mnuTools.Name = "mnuTools"
        mnuTools.Size = New Size(69, 29)
        mnuTools.Text = "Tools"
        ' 
        ' SystemSettingToolStripMenuItem
        ' 
        SystemSettingToolStripMenuItem.Name = "SystemSettingToolStripMenuItem"
        SystemSettingToolStripMenuItem.Size = New Size(178, 34)
        SystemSettingToolStripMenuItem.Text = "Settings"
        ' 
        ' ManageDepartmentToolStripMenuItem
        ' 
        ManageDepartmentToolStripMenuItem.Name = "ManageDepartmentToolStripMenuItem"
        ManageDepartmentToolStripMenuItem.Size = New Size(178, 34)
        ' 
        ' DatabaseBackupToolStripMenuItem
        ' 
        DatabaseBackupToolStripMenuItem.Name = "DatabaseBackupToolStripMenuItem"
        DatabaseBackupToolStripMenuItem.Size = New Size(178, 34)
        ' 
        ' RestorDatabaseToolStripMenuItem
        ' 
        RestorDatabaseToolStripMenuItem.Name = "RestorDatabaseToolStripMenuItem"
        RestorDatabaseToolStripMenuItem.Size = New Size(178, 34)
        ' 
        ' AuditLogToolStripMenuItem
        ' 
        AuditLogToolStripMenuItem.Name = "AuditLogToolStripMenuItem"
        AuditLogToolStripMenuItem.Size = New Size(178, 34)
        ' 
        ' SystemActivityLogToolStripMenuItem
        ' 
        SystemActivityLogToolStripMenuItem.Name = "SystemActivityLogToolStripMenuItem"
        SystemActivityLogToolStripMenuItem.Size = New Size(178, 34)
        ' 
        ' mnuUsers
        ' 
        mnuUsers.DropDownItems.AddRange(New ToolStripItem() {AddUserToolStripMenuItem, EditUserToolStripMenuItem, DeactivateUserToolStripMenuItem, ChangePasswordToolStripMenuItem, UserRolesPermissionToolStripMenuItem})
        mnuUsers.Name = "mnuUsers"
        mnuUsers.Size = New Size(71, 29)
        mnuUsers.Text = "Users"
        ' 
        ' AddUserToolStripMenuItem
        ' 
        AddUserToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddUserToolStripMenuItem1, RemoveUserToolStripMenuItem})
        AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        AddUserToolStripMenuItem.Size = New Size(226, 34)
        AddUserToolStripMenuItem.Text = "Manage Users"
        ' 
        ' AddUserToolStripMenuItem1
        ' 
        AddUserToolStripMenuItem1.Name = "AddUserToolStripMenuItem1"
        AddUserToolStripMenuItem1.Size = New Size(218, 34)
        AddUserToolStripMenuItem1.Text = "Add User"
        ' 
        ' RemoveUserToolStripMenuItem
        ' 
        RemoveUserToolStripMenuItem.Name = "RemoveUserToolStripMenuItem"
        RemoveUserToolStripMenuItem.Size = New Size(218, 34)
        RemoveUserToolStripMenuItem.Text = "Remove User"
        ' 
        ' EditUserToolStripMenuItem
        ' 
        EditUserToolStripMenuItem.Name = "EditUserToolStripMenuItem"
        EditUserToolStripMenuItem.Size = New Size(226, 34)
        ' 
        ' DeactivateUserToolStripMenuItem
        ' 
        DeactivateUserToolStripMenuItem.Name = "DeactivateUserToolStripMenuItem"
        DeactivateUserToolStripMenuItem.Size = New Size(226, 34)
        ' 
        ' ChangePasswordToolStripMenuItem
        ' 
        ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        ChangePasswordToolStripMenuItem.Size = New Size(226, 34)
        ' 
        ' UserRolesPermissionToolStripMenuItem
        ' 
        UserRolesPermissionToolStripMenuItem.Name = "UserRolesPermissionToolStripMenuItem"
        UserRolesPermissionToolStripMenuItem.Size = New Size(226, 34)
        ' 
        ' mnuHelp
        ' 
        mnuHelp.DropDownItems.AddRange(New ToolStripItem() {UserManualToolStripMenuItem, HowToUseTheSystemToolStripMenuItem, ContactSupportToolStripMenuItem})
        mnuHelp.Name = "mnuHelp"
        mnuHelp.Size = New Size(65, 29)
        mnuHelp.Text = "Help"
        ' 
        ' UserManualToolStripMenuItem
        ' 
        UserManualToolStripMenuItem.Name = "UserManualToolStripMenuItem"
        UserManualToolStripMenuItem.Size = New Size(217, 34)
        UserManualToolStripMenuItem.Text = "User Manual "
        ' 
        ' HowToUseTheSystemToolStripMenuItem
        ' 
        HowToUseTheSystemToolStripMenuItem.Name = "HowToUseTheSystemToolStripMenuItem"
        HowToUseTheSystemToolStripMenuItem.Size = New Size(217, 34)
        ' 
        ' ContactSupportToolStripMenuItem
        ' 
        ContactSupportToolStripMenuItem.Name = "ContactSupportToolStripMenuItem"
        ContactSupportToolStripMenuItem.Size = New Size(217, 34)
        ' 
        ' mnuAccount
        ' 
        mnuAccount.DropDownItems.AddRange(New ToolStripItem() {MyProfileToolStripMenuItem, ChangePasswordToolStripMenuItem1, LogOutToolStripMenuItem})
        mnuAccount.Name = "mnuAccount"
        mnuAccount.Size = New Size(93, 29)
        mnuAccount.Text = "Account"
        ' 
        ' MyProfileToolStripMenuItem
        ' 
        MyProfileToolStripMenuItem.Name = "MyProfileToolStripMenuItem"
        MyProfileToolStripMenuItem.Size = New Size(254, 34)
        MyProfileToolStripMenuItem.Text = "Change Password"
        ' 
        ' ChangePasswordToolStripMenuItem1
        ' 
        ChangePasswordToolStripMenuItem1.Name = "ChangePasswordToolStripMenuItem1"
        ChangePasswordToolStripMenuItem1.Size = New Size(254, 34)
        ChangePasswordToolStripMenuItem1.Text = "Logout"
        ' 
        ' LogOutToolStripMenuItem
        ' 
        LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        LogOutToolStripMenuItem.Size = New Size(254, 34)
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(16, 29)
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(lblDepartment)
        Panel1.Controls.Add(lblRole)
        Panel1.Controls.Add(lblDateTime)
        Panel1.Controls.Add(lblWelcome)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 33)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1000, 80)
        Panel1.TabIndex = 1
        ' 
        ' lblDepartment
        ' 
        lblDepartment.AutoSize = True
        lblDepartment.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDepartment.ForeColor = SystemColors.ButtonHighlight
        lblDepartment.Location = New Point(0, 52)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(121, 28)
        lblDepartment.TabIndex = 3
        lblDepartment.Text = "Department:"
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRole.ForeColor = SystemColors.ButtonHighlight
        lblRole.Location = New Point(806, 48)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(50, 28)
        lblRole.TabIndex = 2
        lblRole.Text = "Role"
        ' 
        ' lblDateTime
        ' 
        lblDateTime.AutoSize = True
        lblDateTime.Location = New Point(461, 12)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(0, 25)
        lblDateTime.TabIndex = 1
        ' 
        ' lblWelcome
        ' 
        lblWelcome.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = Color.White
        lblWelcome.Location = New Point(800, 11)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(104, 28)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Welcome! "
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 113)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1000, 586)
        Panel2.TabIndex = 2
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1000, 620)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuNewFile As ToolStripMenuItem
    Friend WithEvents mnuUpdateFile As ToolStripMenuItem
    Friend WithEvents mnuSearchFile As ToolStripMenuItem
    Friend WithEvents mnuSentFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuTracking As ToolStripMenuItem
    Friend WithEvents SendFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReceiveFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileMovementHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PendingFilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompletedFilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuReports As ToolStripMenuItem
    Friend WithEvents DailyFileMovementReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonthlyReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartmentReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserActivityReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToPDFExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuTools As ToolStripMenuItem
    Friend WithEvents SystemSettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageDepartmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatabaseBackupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestorDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AuditLogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemActivityLogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuUsers As ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeactivateUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserRolesPermissionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents UserManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HowToUseTheSystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactSupportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAccount As ToolStripMenuItem
    Friend WithEvents MyProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents AddUserToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RemoveUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents lblDateTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblRole As Label
    Friend WithEvents lblDepartment As Label
End Class

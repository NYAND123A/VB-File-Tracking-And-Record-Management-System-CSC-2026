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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        MenuStrip1 = New MenuStrip()
        mnuFile = New ToolStripMenuItem()
        mnuNewFile = New ToolStripMenuItem()
        mnuUpdateFile = New ToolStripMenuItem()
        mnuSearchFile = New ToolStripMenuItem()
        mnuArchieveFile = New ToolStripMenuItem()
        mnuPrintFile = New ToolStripMenuItem()
        mnuExit = New ToolStripMenuItem()
        mnuTracking = New ToolStripMenuItem()
        SendFileToolStripMenuItem = New ToolStripMenuItem()
        ReceiveFileToolStripMenuItem = New ToolStripMenuItem()
        FileMovementHistoryToolStripMenuItem = New ToolStripMenuItem()
        PendingFilesToolStripMenuItem = New ToolStripMenuItem()
        CompletedFilesToolStripMenuItem = New ToolStripMenuItem()
        mnuRecords = New ToolStripMenuItem()
        AllFileToolStripMenuItem = New ToolStripMenuItem()
        FilesByDepartmentToolStripMenuItem = New ToolStripMenuItem()
        FileStatusReportToolStripMenuItem = New ToolStripMenuItem()
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
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.SteelBlue
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuFile, mnuTracking, mnuRecords, mnuReports, mnuTools, mnuUsers, mnuHelp, mnuAccount, ToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuFile
        ' 
        mnuFile.DropDownItems.AddRange(New ToolStripItem() {mnuNewFile, mnuUpdateFile, mnuSearchFile, mnuArchieveFile, mnuPrintFile, mnuExit})
        mnuFile.Name = "mnuFile"
        mnuFile.Size = New Size(54, 29)
        mnuFile.Text = "File"
        ' 
        ' mnuNewFile
        ' 
        mnuNewFile.BackColor = SystemColors.Control
        mnuNewFile.ForeColor = SystemColors.ActiveCaptionText
        mnuNewFile.Image = CType(resources.GetObject("mnuNewFile.Image"), Image)
        mnuNewFile.Name = "mnuNewFile"
        mnuNewFile.Size = New Size(270, 34)
        mnuNewFile.Text = "New File"
        ' 
        ' mnuUpdateFile
        ' 
        mnuUpdateFile.BackColor = SystemColors.Control
        mnuUpdateFile.Image = CType(resources.GetObject("mnuUpdateFile.Image"), Image)
        mnuUpdateFile.Name = "mnuUpdateFile"
        mnuUpdateFile.Size = New Size(270, 34)
        mnuUpdateFile.Text = "Update File"
        ' 
        ' mnuSearchFile
        ' 
        mnuSearchFile.BackColor = SystemColors.Control
        mnuSearchFile.Image = CType(resources.GetObject("mnuSearchFile.Image"), Image)
        mnuSearchFile.Name = "mnuSearchFile"
        mnuSearchFile.Size = New Size(270, 34)
        mnuSearchFile.Text = "Search File"
        ' 
        ' mnuArchieveFile
        ' 
        mnuArchieveFile.BackColor = SystemColors.Control
        mnuArchieveFile.Image = CType(resources.GetObject("mnuArchieveFile.Image"), Image)
        mnuArchieveFile.Name = "mnuArchieveFile"
        mnuArchieveFile.Size = New Size(270, 34)
        mnuArchieveFile.Text = "Archieve File"
        ' 
        ' mnuPrintFile
        ' 
        mnuPrintFile.BackColor = SystemColors.Control
        mnuPrintFile.Image = CType(resources.GetObject("mnuPrintFile.Image"), Image)
        mnuPrintFile.Name = "mnuPrintFile"
        mnuPrintFile.Size = New Size(270, 34)
        mnuPrintFile.Text = "Print File"
        ' 
        ' mnuExit
        ' 
        mnuExit.BackColor = SystemColors.Control
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
        SendFileToolStripMenuItem.BackColor = SystemColors.Control
        SendFileToolStripMenuItem.Image = CType(resources.GetObject("SendFileToolStripMenuItem.Image"), Image)
        SendFileToolStripMenuItem.Name = "SendFileToolStripMenuItem"
        SendFileToolStripMenuItem.Size = New Size(293, 34)
        SendFileToolStripMenuItem.Text = "Send File"
        ' 
        ' ReceiveFileToolStripMenuItem
        ' 
        ReceiveFileToolStripMenuItem.BackColor = SystemColors.Control
        ReceiveFileToolStripMenuItem.Image = CType(resources.GetObject("ReceiveFileToolStripMenuItem.Image"), Image)
        ReceiveFileToolStripMenuItem.Name = "ReceiveFileToolStripMenuItem"
        ReceiveFileToolStripMenuItem.Size = New Size(293, 34)
        ReceiveFileToolStripMenuItem.Text = "Receive File"
        ' 
        ' FileMovementHistoryToolStripMenuItem
        ' 
        FileMovementHistoryToolStripMenuItem.BackColor = SystemColors.Control
        FileMovementHistoryToolStripMenuItem.Image = CType(resources.GetObject("FileMovementHistoryToolStripMenuItem.Image"), Image)
        FileMovementHistoryToolStripMenuItem.Name = "FileMovementHistoryToolStripMenuItem"
        FileMovementHistoryToolStripMenuItem.Size = New Size(293, 34)
        FileMovementHistoryToolStripMenuItem.Text = "File Movement History"
        ' 
        ' PendingFilesToolStripMenuItem
        ' 
        PendingFilesToolStripMenuItem.BackColor = SystemColors.Control
        PendingFilesToolStripMenuItem.Image = CType(resources.GetObject("PendingFilesToolStripMenuItem.Image"), Image)
        PendingFilesToolStripMenuItem.Name = "PendingFilesToolStripMenuItem"
        PendingFilesToolStripMenuItem.Size = New Size(293, 34)
        PendingFilesToolStripMenuItem.Text = "Pending Files"
        ' 
        ' CompletedFilesToolStripMenuItem
        ' 
        CompletedFilesToolStripMenuItem.BackColor = SystemColors.Control
        CompletedFilesToolStripMenuItem.Image = CType(resources.GetObject("CompletedFilesToolStripMenuItem.Image"), Image)
        CompletedFilesToolStripMenuItem.Name = "CompletedFilesToolStripMenuItem"
        CompletedFilesToolStripMenuItem.Size = New Size(293, 34)
        CompletedFilesToolStripMenuItem.Text = "Completed Files"
        ' 
        ' mnuRecords
        ' 
        mnuRecords.DropDownItems.AddRange(New ToolStripItem() {AllFileToolStripMenuItem, FilesByDepartmentToolStripMenuItem, FileStatusReportToolStripMenuItem})
        mnuRecords.Name = "mnuRecords"
        mnuRecords.Size = New Size(91, 29)
        mnuRecords.Text = "Records"
        ' 
        ' AllFileToolStripMenuItem
        ' 
        AllFileToolStripMenuItem.BackColor = SystemColors.Control
        AllFileToolStripMenuItem.Name = "AllFileToolStripMenuItem"
        AllFileToolStripMenuItem.Size = New Size(270, 34)
        AllFileToolStripMenuItem.Text = "All Files"
        ' 
        ' FilesByDepartmentToolStripMenuItem
        ' 
        FilesByDepartmentToolStripMenuItem.BackColor = SystemColors.Control
        FilesByDepartmentToolStripMenuItem.Name = "FilesByDepartmentToolStripMenuItem"
        FilesByDepartmentToolStripMenuItem.Size = New Size(270, 34)
        FilesByDepartmentToolStripMenuItem.Text = "Achieved Records"
        ' 
        ' FileStatusReportToolStripMenuItem
        ' 
        FileStatusReportToolStripMenuItem.BackColor = SystemColors.Control
        FileStatusReportToolStripMenuItem.Name = "FileStatusReportToolStripMenuItem"
        FileStatusReportToolStripMenuItem.Size = New Size(270, 34)
        FileStatusReportToolStripMenuItem.Text = "File status Report"
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
        DailyFileMovementReportsToolStripMenuItem.BackColor = SystemColors.Control
        DailyFileMovementReportsToolStripMenuItem.Name = "DailyFileMovementReportsToolStripMenuItem"
        DailyFileMovementReportsToolStripMenuItem.Size = New Size(341, 34)
        DailyFileMovementReportsToolStripMenuItem.Text = "Daily File Movement Reports"
        ' 
        ' MonthlyReportToolStripMenuItem
        ' 
        MonthlyReportToolStripMenuItem.BackColor = SystemColors.Control
        MonthlyReportToolStripMenuItem.Name = "MonthlyReportToolStripMenuItem"
        MonthlyReportToolStripMenuItem.Size = New Size(341, 34)
        MonthlyReportToolStripMenuItem.Text = "Monthly Report"
        ' 
        ' DepartmentReportToolStripMenuItem
        ' 
        DepartmentReportToolStripMenuItem.BackColor = SystemColors.Control
        DepartmentReportToolStripMenuItem.Name = "DepartmentReportToolStripMenuItem"
        DepartmentReportToolStripMenuItem.Size = New Size(341, 34)
        DepartmentReportToolStripMenuItem.Text = "Department Report"
        ' 
        ' UserActivityReportToolStripMenuItem
        ' 
        UserActivityReportToolStripMenuItem.BackColor = SystemColors.Control
        UserActivityReportToolStripMenuItem.Name = "UserActivityReportToolStripMenuItem"
        UserActivityReportToolStripMenuItem.Size = New Size(341, 34)
        UserActivityReportToolStripMenuItem.Text = "user Activity Report"
        ' 
        ' ExportToPDFExcelToolStripMenuItem
        ' 
        ExportToPDFExcelToolStripMenuItem.BackColor = SystemColors.Control
        ExportToPDFExcelToolStripMenuItem.Name = "ExportToPDFExcelToolStripMenuItem"
        ExportToPDFExcelToolStripMenuItem.Size = New Size(341, 34)
        ExportToPDFExcelToolStripMenuItem.Text = "Export to PDF/Excel "
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
        SystemSettingToolStripMenuItem.BackColor = SystemColors.Control
        SystemSettingToolStripMenuItem.Name = "SystemSettingToolStripMenuItem"
        SystemSettingToolStripMenuItem.Size = New Size(278, 34)
        SystemSettingToolStripMenuItem.Text = "System Setting"
        ' 
        ' ManageDepartmentToolStripMenuItem
        ' 
        ManageDepartmentToolStripMenuItem.BackColor = SystemColors.Control
        ManageDepartmentToolStripMenuItem.Name = "ManageDepartmentToolStripMenuItem"
        ManageDepartmentToolStripMenuItem.Size = New Size(278, 34)
        ManageDepartmentToolStripMenuItem.Text = "Manage Department"
        ' 
        ' DatabaseBackupToolStripMenuItem
        ' 
        DatabaseBackupToolStripMenuItem.BackColor = SystemColors.Control
        DatabaseBackupToolStripMenuItem.Name = "DatabaseBackupToolStripMenuItem"
        DatabaseBackupToolStripMenuItem.Size = New Size(278, 34)
        DatabaseBackupToolStripMenuItem.Text = "Database Backup"
        ' 
        ' RestorDatabaseToolStripMenuItem
        ' 
        RestorDatabaseToolStripMenuItem.BackColor = SystemColors.Control
        RestorDatabaseToolStripMenuItem.Name = "RestorDatabaseToolStripMenuItem"
        RestorDatabaseToolStripMenuItem.Size = New Size(278, 34)
        RestorDatabaseToolStripMenuItem.Text = "Restor Database"
        ' 
        ' AuditLogToolStripMenuItem
        ' 
        AuditLogToolStripMenuItem.BackColor = SystemColors.Control
        AuditLogToolStripMenuItem.Name = "AuditLogToolStripMenuItem"
        AuditLogToolStripMenuItem.Size = New Size(278, 34)
        AuditLogToolStripMenuItem.Text = "Audit Log"
        ' 
        ' SystemActivityLogToolStripMenuItem
        ' 
        SystemActivityLogToolStripMenuItem.BackColor = SystemColors.Control
        SystemActivityLogToolStripMenuItem.Name = "SystemActivityLogToolStripMenuItem"
        SystemActivityLogToolStripMenuItem.Size = New Size(278, 34)
        SystemActivityLogToolStripMenuItem.Text = "System Activity Log"
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
        AddUserToolStripMenuItem.BackColor = SystemColors.Control
        AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        AddUserToolStripMenuItem.Size = New Size(288, 34)
        AddUserToolStripMenuItem.Text = "Add User"
        ' 
        ' EditUserToolStripMenuItem
        ' 
        EditUserToolStripMenuItem.BackColor = SystemColors.Control
        EditUserToolStripMenuItem.Name = "EditUserToolStripMenuItem"
        EditUserToolStripMenuItem.Size = New Size(288, 34)
        EditUserToolStripMenuItem.Text = "Edit User"
        ' 
        ' DeactivateUserToolStripMenuItem
        ' 
        DeactivateUserToolStripMenuItem.BackColor = SystemColors.Control
        DeactivateUserToolStripMenuItem.Name = "DeactivateUserToolStripMenuItem"
        DeactivateUserToolStripMenuItem.Size = New Size(288, 34)
        DeactivateUserToolStripMenuItem.Text = "Deactivate User"
        ' 
        ' ChangePasswordToolStripMenuItem
        ' 
        ChangePasswordToolStripMenuItem.BackColor = SystemColors.Control
        ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        ChangePasswordToolStripMenuItem.Size = New Size(288, 34)
        ChangePasswordToolStripMenuItem.Text = "Change Password"
        ' 
        ' UserRolesPermissionToolStripMenuItem
        ' 
        UserRolesPermissionToolStripMenuItem.BackColor = SystemColors.Control
        UserRolesPermissionToolStripMenuItem.Name = "UserRolesPermissionToolStripMenuItem"
        UserRolesPermissionToolStripMenuItem.Size = New Size(288, 34)
        UserRolesPermissionToolStripMenuItem.Text = "User Roles_Permission"
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
        UserManualToolStripMenuItem.BackColor = SystemColors.Control
        UserManualToolStripMenuItem.Name = "UserManualToolStripMenuItem"
        UserManualToolStripMenuItem.Size = New Size(299, 34)
        UserManualToolStripMenuItem.Text = "User Manual"
        ' 
        ' HowToUseTheSystemToolStripMenuItem
        ' 
        HowToUseTheSystemToolStripMenuItem.BackColor = SystemColors.Control
        HowToUseTheSystemToolStripMenuItem.Name = "HowToUseTheSystemToolStripMenuItem"
        HowToUseTheSystemToolStripMenuItem.Size = New Size(299, 34)
        HowToUseTheSystemToolStripMenuItem.Text = "How to Use the System"
        ' 
        ' ContactSupportToolStripMenuItem
        ' 
        ContactSupportToolStripMenuItem.BackColor = SystemColors.Control
        ContactSupportToolStripMenuItem.Name = "ContactSupportToolStripMenuItem"
        ContactSupportToolStripMenuItem.Size = New Size(299, 34)
        ContactSupportToolStripMenuItem.Text = "Contact Support"
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
        MyProfileToolStripMenuItem.BackColor = SystemColors.Control
        MyProfileToolStripMenuItem.Name = "MyProfileToolStripMenuItem"
        MyProfileToolStripMenuItem.Size = New Size(254, 34)
        MyProfileToolStripMenuItem.Text = "My Profile"
        ' 
        ' ChangePasswordToolStripMenuItem1
        ' 
        ChangePasswordToolStripMenuItem1.BackColor = SystemColors.Control
        ChangePasswordToolStripMenuItem1.Name = "ChangePasswordToolStripMenuItem1"
        ChangePasswordToolStripMenuItem1.Size = New Size(254, 34)
        ChangePasswordToolStripMenuItem1.Text = "Change Password"
        ' 
        ' LogOutToolStripMenuItem
        ' 
        LogOutToolStripMenuItem.BackColor = SystemColors.Control
        LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        LogOutToolStripMenuItem.Size = New Size(254, 34)
        LogOutToolStripMenuItem.Text = "LogOut"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(16, 29)
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Dashboard"
        Text = "Dashboard"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuNewFile As ToolStripMenuItem
    Friend WithEvents mnuUpdateFile As ToolStripMenuItem
    Friend WithEvents mnuSearchFile As ToolStripMenuItem
    Friend WithEvents mnuArchieveFile As ToolStripMenuItem
    Friend WithEvents mnuPrintFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuTracking As ToolStripMenuItem
    Friend WithEvents SendFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReceiveFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileMovementHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PendingFilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompletedFilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuRecords As ToolStripMenuItem
    Friend WithEvents AllFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilesByDepartmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileStatusReportToolStripMenuItem As ToolStripMenuItem
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
End Class

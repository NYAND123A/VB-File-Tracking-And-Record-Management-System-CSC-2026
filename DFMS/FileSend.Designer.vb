<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileSend
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
        lblFileInfo = New Label()
        Label2 = New Label()
        lblFileID = New Label()
        Panel1 = New Panel()
        btnBack = New Button()
        Panel2 = New Panel()
        lblDescription = New Label()
        txtFileDescription = New TextBox()
        txtFileID = New TextBox()
        cboFileName = New ComboBox()
        lblfileName = New Label()
        Panel3 = New Panel()
        dtpDate = New DateTimePicker()
        lblDate = New Label()
        txtSent = New TextBox()
        lblSent = New Label()
        cboFrom = New ComboBox()
        lblFrom = New Label()
        lblSenderDetails = New Label()
        Panel4 = New Panel()
        rdoUrgent = New RadioButton()
        rdoNormal = New RadioButton()
        cboReceiver = New ComboBox()
        cboTo = New ComboBox()
        lblReceiverOfficer = New Label()
        Label3 = New Label()
        lblToDepartment = New Label()
        lblReceiver = New Label()
        Panel5 = New Panel()
        btnExit = New Button()
        btnClear = New Button()
        btnSend = New Button()
        txtRemark = New TextBox()
        lblRemark = New Label()
        lblRemarks = New Label()
        TrackingID = New Label()
        txtTrackingID = New TextBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblFileInfo
        ' 
        lblFileInfo.AutoSize = True
        lblFileInfo.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFileInfo.Location = New Point(35, -8)
        lblFileInfo.Name = "lblFileInfo"
        lblFileInfo.Size = New Size(190, 25)
        lblFileInfo.TabIndex = 0
        lblFileInfo.Text = "A: File Informations"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(309, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 28)
        Label2.TabIndex = 1
        Label2.Text = "SEND FILE FORM"
        ' 
        ' lblFileID
        ' 
        lblFileID.AutoSize = True
        lblFileID.Location = New Point(35, 52)
        lblFileID.Name = "lblFileID"
        lblFileID.Size = New Size(61, 25)
        lblFileID.TabIndex = 2
        lblFileID.Text = "File ID"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btnBack)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 47)
        Panel1.TabIndex = 3
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(3, 7)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(69, 34)
        btnBack.TabIndex = 4
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(txtTrackingID)
        Panel2.Controls.Add(TrackingID)
        Panel2.Controls.Add(lblDescription)
        Panel2.Controls.Add(txtFileDescription)
        Panel2.Controls.Add(txtFileID)
        Panel2.Controls.Add(cboFileName)
        Panel2.Controls.Add(lblfileName)
        Panel2.Controls.Add(lblFileInfo)
        Panel2.Controls.Add(lblFileID)
        Panel2.Location = New Point(0, 47)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(800, 164)
        Panel2.TabIndex = 4
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.Location = New Point(35, 131)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(133, 25)
        lblDescription.TabIndex = 7
        lblDescription.Text = "File Description"
        ' 
        ' txtFileDescription
        ' 
        txtFileDescription.Location = New Point(195, 128)
        txtFileDescription.Name = "txtFileDescription"
        txtFileDescription.Size = New Size(411, 31)
        txtFileDescription.TabIndex = 6
        ' 
        ' txtFileID
        ' 
        txtFileID.Location = New Point(195, 52)
        txtFileID.Name = "txtFileID"
        txtFileID.Size = New Size(411, 31)
        txtFileID.TabIndex = 5
        ' 
        ' cboFileName
        ' 
        cboFileName.FormattingEnabled = True
        cboFileName.Items.AddRange(New Object() {"Student Registration File", "Service Levy", "Farmers Registration File", "Entreprenourship Registration", "Research Proposal Submission File", "Student Admission Records", "Student Transcript Request", "Examination Results File", "Course Registration Forms", "Graduation Clearance File", "Scholarship Application File", "Student Disciplinary Case File", "Academic Staff Appointment File"})
        cboFileName.Location = New Point(195, 89)
        cboFileName.Name = "cboFileName"
        cboFileName.Size = New Size(411, 33)
        cboFileName.TabIndex = 4
        ' 
        ' lblfileName
        ' 
        lblfileName.AutoSize = True
        lblfileName.Location = New Point(35, 91)
        lblfileName.Name = "lblfileName"
        lblfileName.Size = New Size(90, 25)
        lblfileName.TabIndex = 3
        lblfileName.Text = "File Name"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveCaption
        Panel3.Controls.Add(dtpDate)
        Panel3.Controls.Add(lblDate)
        Panel3.Controls.Add(txtSent)
        Panel3.Controls.Add(lblSent)
        Panel3.Controls.Add(cboFrom)
        Panel3.Controls.Add(lblFrom)
        Panel3.Controls.Add(lblSenderDetails)
        Panel3.Location = New Point(0, 217)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(800, 150)
        Panel3.TabIndex = 5
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(195, 101)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(411, 31)
        dtpDate.TabIndex = 9
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Location = New Point(36, 101)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(89, 25)
        lblDate.TabIndex = 8
        lblDate.Text = "Date Sent"
        ' 
        ' txtSent
        ' 
        txtSent.Location = New Point(195, 64)
        txtSent.Name = "txtSent"
        txtSent.Size = New Size(411, 31)
        txtSent.TabIndex = 7
        ' 
        ' lblSent
        ' 
        lblSent.AutoSize = True
        lblSent.Location = New Point(36, 67)
        lblSent.Name = "lblSent"
        lblSent.Size = New Size(71, 25)
        lblSent.TabIndex = 6
        lblSent.Text = "Sent By"
        ' 
        ' cboFrom
        ' 
        cboFrom.FormattingEnabled = True
        cboFrom.Items.AddRange(New Object() {"HRO", "FINANCE", "LAW", "EDUCATION", "ENVIRONMENT", "AGRICULTURE AND FISHING", "BUSINESS"})
        cboFrom.Location = New Point(195, 25)
        cboFrom.Name = "cboFrom"
        cboFrom.Size = New Size(411, 33)
        cboFrom.TabIndex = 5
        ' 
        ' lblFrom
        ' 
        lblFrom.AutoSize = True
        lblFrom.Location = New Point(35, 25)
        lblFrom.Name = "lblFrom"
        lblFrom.Size = New Size(154, 25)
        lblFrom.TabIndex = 1
        lblFrom.Text = "From Department"
        ' 
        ' lblSenderDetails
        ' 
        lblSenderDetails.AutoSize = True
        lblSenderDetails.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSenderDetails.Location = New Point(35, 0)
        lblSenderDetails.Name = "lblSenderDetails"
        lblSenderDetails.Size = New Size(164, 25)
        lblSenderDetails.TabIndex = 0
        lblSenderDetails.Text = "B: Sender Details"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveCaption
        Panel4.Controls.Add(rdoUrgent)
        Panel4.Controls.Add(rdoNormal)
        Panel4.Controls.Add(cboReceiver)
        Panel4.Controls.Add(cboTo)
        Panel4.Controls.Add(lblReceiverOfficer)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(lblToDepartment)
        Panel4.Controls.Add(lblReceiver)
        Panel4.Location = New Point(0, 373)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(800, 166)
        Panel4.TabIndex = 6
        ' 
        ' rdoUrgent
        ' 
        rdoUrgent.AutoSize = True
        rdoUrgent.Location = New Point(515, 125)
        rdoUrgent.Name = "rdoUrgent"
        rdoUrgent.Size = New Size(91, 29)
        rdoUrgent.TabIndex = 9
        rdoUrgent.TabStop = True
        rdoUrgent.Text = "Urgent"
        rdoUrgent.UseVisualStyleBackColor = True
        ' 
        ' rdoNormal
        ' 
        rdoNormal.AutoSize = True
        rdoNormal.Location = New Point(195, 125)
        rdoNormal.Name = "rdoNormal"
        rdoNormal.Size = New Size(96, 29)
        rdoNormal.TabIndex = 8
        rdoNormal.TabStop = True
        rdoNormal.Text = "Normal"
        rdoNormal.UseVisualStyleBackColor = True
        ' 
        ' cboReceiver
        ' 
        cboReceiver.FormattingEnabled = True
        cboReceiver.Location = New Point(195, 77)
        cboReceiver.Name = "cboReceiver"
        cboReceiver.Size = New Size(411, 33)
        cboReceiver.TabIndex = 7
        ' 
        ' cboTo
        ' 
        cboTo.FormattingEnabled = True
        cboTo.Items.AddRange(New Object() {"HRO", "FINANCE", "LAW", "EDUCATION", "ENVIRONMENT", "AGRICULTURE AND FISHING", "BUSINESS"})
        cboTo.Location = New Point(195, 38)
        cboTo.Name = "cboTo"
        cboTo.Size = New Size(411, 33)
        cboTo.TabIndex = 6
        ' 
        ' lblReceiverOfficer
        ' 
        lblReceiverOfficer.AutoSize = True
        lblReceiverOfficer.Location = New Point(36, 74)
        lblReceiverOfficer.Name = "lblReceiverOfficer"
        lblReceiverOfficer.Size = New Size(128, 25)
        lblReceiverOfficer.TabIndex = 3
        lblReceiverOfficer.Text = "Receive Officer"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(36, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 25)
        Label3.TabIndex = 2
        Label3.Text = "Priority Level"
        ' 
        ' lblToDepartment
        ' 
        lblToDepartment.AutoSize = True
        lblToDepartment.Location = New Point(35, 38)
        lblToDepartment.Name = "lblToDepartment"
        lblToDepartment.Size = New Size(130, 25)
        lblToDepartment.TabIndex = 1
        lblToDepartment.Text = "To Department"
        ' 
        ' lblReceiver
        ' 
        lblReceiver.AutoSize = True
        lblReceiver.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblReceiver.Location = New Point(35, 0)
        lblReceiver.Name = "lblReceiver"
        lblReceiver.Size = New Size(178, 25)
        lblReceiver.TabIndex = 0
        lblReceiver.Text = "C: Receiver Details"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ActiveCaption
        Panel5.Controls.Add(btnExit)
        Panel5.Controls.Add(btnClear)
        Panel5.Controls.Add(btnSend)
        Panel5.Controls.Add(txtRemark)
        Panel5.Controls.Add(lblRemark)
        Panel5.Controls.Add(lblRemarks)
        Panel5.Location = New Point(0, 545)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(800, 139)
        Panel5.TabIndex = 7
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(494, 84)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(112, 34)
        btnExit.TabIndex = 6
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(344, 84)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 5
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnSend
        ' 
        btnSend.Location = New Point(195, 84)
        btnSend.Name = "btnSend"
        btnSend.Size = New Size(116, 34)
        btnSend.TabIndex = 3
        btnSend.Text = "Send File"
        btnSend.UseVisualStyleBackColor = True
        ' 
        ' txtRemark
        ' 
        txtRemark.Location = New Point(195, 27)
        txtRemark.Name = "txtRemark"
        txtRemark.Size = New Size(411, 31)
        txtRemark.TabIndex = 2
        ' 
        ' lblRemark
        ' 
        lblRemark.AutoSize = True
        lblRemark.Location = New Point(36, 33)
        lblRemark.Name = "lblRemark"
        lblRemark.Size = New Size(79, 25)
        lblRemark.TabIndex = 1
        lblRemark.Text = "Remarks"
        ' 
        ' lblRemarks
        ' 
        lblRemarks.AutoSize = True
        lblRemarks.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRemarks.Location = New Point(36, -3)
        lblRemarks.Name = "lblRemarks"
        lblRemarks.Size = New Size(114, 25)
        lblRemarks.TabIndex = 0
        lblRemarks.Text = "D: Remarks"
        ' 
        ' TrackingID
        ' 
        TrackingID.AutoSize = True
        TrackingID.Location = New Point(33, 19)
        TrackingID.Name = "TrackingID"
        TrackingID.Size = New Size(99, 25)
        TrackingID.TabIndex = 8
        TrackingID.Text = "Tracking ID"
        ' 
        ' txtTrackingID
        ' 
        txtTrackingID.Location = New Point(195, 15)
        txtTrackingID.Name = "txtTrackingID"
        txtTrackingID.Size = New Size(411, 31)
        txtTrackingID.TabIndex = 9
        ' 
        ' FileSend
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(800, 721)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "FileSend"
        Text = "FileSend"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblFileInfo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFileID As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtFileID As TextBox
    Friend WithEvents cboFileName As ComboBox
    Friend WithEvents lblfileName As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtFileDescription As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cboFrom As ComboBox
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblSenderDetails As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblDate As Label
    Friend WithEvents txtSent As TextBox
    Friend WithEvents lblSent As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblReceiver As Label
    Friend WithEvents lblReceiverOfficer As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblToDepartment As Label
    Friend WithEvents cboTo As ComboBox
    Friend WithEvents cboReceiver As ComboBox
    Friend WithEvents rdoUrgent As RadioButton
    Friend WithEvents rdoNormal As RadioButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents lblRemark As Label
    Friend WithEvents lblRemarks As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSend As Button
    Friend WithEvents txtTrackingID As TextBox
    Friend WithEvents TrackingID As Label
End Class

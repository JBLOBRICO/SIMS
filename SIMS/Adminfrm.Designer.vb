<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Adminfrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    'UI Controls
    Private pnlSidebar As Panel
    Private pnlHeader As Panel
    Private pnlMain As Panel
    Private btnDashboard As Button
    Private btnUserMgmt As Button
    Private btnStudentInfo As Button
    Private btnCourseMgmt As Button
    Private btnSubjects As Button
    Private btnSchedules As Button
    Private btnAnnouncements As Button
    Private btnLogout As Button
    Private lblHeader As Label
    Private lblDashboardWelcome As Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAnnouncements = New System.Windows.Forms.Button()
        Me.btnSchedules = New System.Windows.Forms.Button()
        Me.btnSubjects = New System.Windows.Forms.Button()
        Me.btnCourseMgmt = New System.Windows.Forms.Button()
        Me.btnStudentInfo = New System.Windows.Forms.Button()
        Me.btnUserMgmt = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lblDashboardWelcome = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.btnAnnouncements)
        Me.pnlSidebar.Controls.Add(Me.btnSchedules)
        Me.pnlSidebar.Controls.Add(Me.btnSubjects)
        Me.pnlSidebar.Controls.Add(Me.btnCourseMgmt)
        Me.pnlSidebar.Controls.Add(Me.btnStudentInfo)
        Me.pnlSidebar.Controls.Add(Me.btnUserMgmt)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 738)
        Me.pnlSidebar.TabIndex = 2
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(0, 535)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(220, 76)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnAnnouncements
        '
        Me.btnAnnouncements.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAnnouncements.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAnnouncements.FlatAppearance.BorderSize = 0
        Me.btnAnnouncements.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnouncements.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAnnouncements.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAnnouncements.Location = New System.Drawing.Point(0, 448)
        Me.btnAnnouncements.Name = "btnAnnouncements"
        Me.btnAnnouncements.Size = New System.Drawing.Size(220, 87)
        Me.btnAnnouncements.TabIndex = 1
        Me.btnAnnouncements.Text = "Announcements"
        Me.btnAnnouncements.UseVisualStyleBackColor = False
        '
        'btnSchedules
        '
        Me.btnSchedules.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSchedules.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSchedules.FlatAppearance.BorderSize = 0
        Me.btnSchedules.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSchedules.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSchedules.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSchedules.Location = New System.Drawing.Point(0, 371)
        Me.btnSchedules.Name = "btnSchedules"
        Me.btnSchedules.Size = New System.Drawing.Size(220, 77)
        Me.btnSchedules.TabIndex = 2
        Me.btnSchedules.Text = "Schedules"
        Me.btnSchedules.UseVisualStyleBackColor = False
        '
        'btnSubjects
        '
        Me.btnSubjects.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSubjects.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSubjects.FlatAppearance.BorderSize = 0
        Me.btnSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubjects.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubjects.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSubjects.Location = New System.Drawing.Point(0, 288)
        Me.btnSubjects.Name = "btnSubjects"
        Me.btnSubjects.Size = New System.Drawing.Size(220, 83)
        Me.btnSubjects.TabIndex = 3
        Me.btnSubjects.Text = "Subjects"
        Me.btnSubjects.UseVisualStyleBackColor = False
        '
        'btnCourseMgmt
        '
        Me.btnCourseMgmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCourseMgmt.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCourseMgmt.FlatAppearance.BorderSize = 0
        Me.btnCourseMgmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCourseMgmt.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCourseMgmt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCourseMgmt.Location = New System.Drawing.Point(0, 209)
        Me.btnCourseMgmt.Name = "btnCourseMgmt"
        Me.btnCourseMgmt.Size = New System.Drawing.Size(220, 79)
        Me.btnCourseMgmt.TabIndex = 4
        Me.btnCourseMgmt.Text = "Courses"
        Me.btnCourseMgmt.UseVisualStyleBackColor = False
        '
        'btnStudentInfo
        '
        Me.btnStudentInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStudentInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudentInfo.FlatAppearance.BorderSize = 0
        Me.btnStudentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentInfo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnStudentInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnStudentInfo.Location = New System.Drawing.Point(0, 134)
        Me.btnStudentInfo.Name = "btnStudentInfo"
        Me.btnStudentInfo.Size = New System.Drawing.Size(220, 75)
        Me.btnStudentInfo.TabIndex = 5
        Me.btnStudentInfo.Text = "Student Info"
        Me.btnStudentInfo.UseVisualStyleBackColor = False
        '
        'btnUserMgmt
        '
        Me.btnUserMgmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserMgmt.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUserMgmt.FlatAppearance.BorderSize = 0
        Me.btnUserMgmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserMgmt.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnUserMgmt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnUserMgmt.Location = New System.Drawing.Point(0, 60)
        Me.btnUserMgmt.Name = "btnUserMgmt"
        Me.btnUserMgmt.Size = New System.Drawing.Size(220, 74)
        Me.btnUserMgmt.TabIndex = 6
        Me.btnUserMgmt.Text = "User Management"
        Me.btnUserMgmt.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(220, 60)
        Me.btnDashboard.TabIndex = 7
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(220, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1182, 60)
        Me.pnlHeader.TabIndex = 1
        '
        'lblHeader
        '
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblHeader.Size = New System.Drawing.Size(1182, 60)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Admin Dashboard"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.lblDashboardWelcome)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(220, 60)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1182, 678)
        Me.pnlMain.TabIndex = 0
        '
        'lblDashboardWelcome
        '
        Me.lblDashboardWelcome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDashboardWelcome.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblDashboardWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblDashboardWelcome.Location = New System.Drawing.Point(0, 0)
        Me.lblDashboardWelcome.Name = "lblDashboardWelcome"
        Me.lblDashboardWelcome.Size = New System.Drawing.Size(1182, 678)
        Me.lblDashboardWelcome.TabIndex = 0
        Me.lblDashboardWelcome.Text = "Welcome to the Admin Dashboard!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use the menu to access modules."
        Me.lblDashboardWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Adminfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1402, 738)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Name = "Adminfrm"
        Me.Text = "Admin Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
End Class
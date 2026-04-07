<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registrarfrm
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
    Private btnStudentInfo As Button
    Private btnEnrollment As Button
    Private btnEnrollmentList As Button
    Private btnEnrollmentReview As Button
    Private btnCourseList As Button
    Private btnSubjectList As Button
    Private btnScheduleList As Button
    Private btnLogout As Button
    Private lblHeader As Label
    Private lblWelcome As Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnScheduleList = New System.Windows.Forms.Button()
        Me.btnSubjectList = New System.Windows.Forms.Button()
        Me.btnCourseList = New System.Windows.Forms.Button()
        Me.btnEnrollmentReview = New System.Windows.Forms.Button()
        Me.btnEnrollmentList = New System.Windows.Forms.Button()
        Me.btnEnrollment = New System.Windows.Forms.Button()
        Me.btnStudentInfo = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.btnScheduleList)
        Me.pnlSidebar.Controls.Add(Me.btnSubjectList)
        Me.pnlSidebar.Controls.Add(Me.btnCourseList)
        Me.pnlSidebar.Controls.Add(Me.btnEnrollmentReview)
        Me.pnlSidebar.Controls.Add(Me.btnEnrollmentList)
        Me.pnlSidebar.Controls.Add(Me.btnEnrollment)
        Me.pnlSidebar.Controls.Add(Me.btnStudentInfo)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 700)
        Me.pnlSidebar.TabIndex = 2
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(0, 400)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(220, 50)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnScheduleList
        '
        Me.btnScheduleList.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnScheduleList.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnScheduleList.FlatAppearance.BorderSize = 0
        Me.btnScheduleList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScheduleList.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnScheduleList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnScheduleList.Location = New System.Drawing.Point(0, 350)
        Me.btnScheduleList.Name = "btnScheduleList"
        Me.btnScheduleList.Size = New System.Drawing.Size(220, 50)
        Me.btnScheduleList.TabIndex = 1
        Me.btnScheduleList.Text = "Schedule List"
        Me.btnScheduleList.UseVisualStyleBackColor = False
        '
        'btnSubjectList
        '
        Me.btnSubjectList.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSubjectList.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSubjectList.FlatAppearance.BorderSize = 0
        Me.btnSubjectList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubjectList.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubjectList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSubjectList.Location = New System.Drawing.Point(0, 300)
        Me.btnSubjectList.Name = "btnSubjectList"
        Me.btnSubjectList.Size = New System.Drawing.Size(220, 50)
        Me.btnSubjectList.TabIndex = 2
        Me.btnSubjectList.Text = "Subject List"
        Me.btnSubjectList.UseVisualStyleBackColor = False
        '
        'btnCourseList
        '
        Me.btnCourseList.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCourseList.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCourseList.FlatAppearance.BorderSize = 0
        Me.btnCourseList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCourseList.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCourseList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCourseList.Location = New System.Drawing.Point(0, 250)
        Me.btnCourseList.Name = "btnCourseList"
        Me.btnCourseList.Size = New System.Drawing.Size(220, 50)
        Me.btnCourseList.TabIndex = 3
        Me.btnCourseList.Text = "Course List"
        Me.btnCourseList.UseVisualStyleBackColor = False
        '
        'btnEnrollmentReview
        '
        Me.btnEnrollmentReview.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEnrollmentReview.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEnrollmentReview.FlatAppearance.BorderSize = 0
        Me.btnEnrollmentReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnrollmentReview.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnEnrollmentReview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEnrollmentReview.Location = New System.Drawing.Point(0, 200)
        Me.btnEnrollmentReview.Name = "btnEnrollmentReview"
        Me.btnEnrollmentReview.Size = New System.Drawing.Size(220, 50)
        Me.btnEnrollmentReview.TabIndex = 4
        Me.btnEnrollmentReview.Text = "Enrollment Review"
        Me.btnEnrollmentReview.UseVisualStyleBackColor = False
        '
        'btnEnrollmentList
        '
        Me.btnEnrollmentList.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEnrollmentList.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEnrollmentList.FlatAppearance.BorderSize = 0
        Me.btnEnrollmentList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnrollmentList.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnEnrollmentList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEnrollmentList.Location = New System.Drawing.Point(0, 150)
        Me.btnEnrollmentList.Name = "btnEnrollmentList"
        Me.btnEnrollmentList.Size = New System.Drawing.Size(220, 50)
        Me.btnEnrollmentList.TabIndex = 5
        Me.btnEnrollmentList.Text = "Enrollment List"
        Me.btnEnrollmentList.UseVisualStyleBackColor = False
        '
        'btnEnrollment
        '
        Me.btnEnrollment.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEnrollment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEnrollment.FlatAppearance.BorderSize = 0
        Me.btnEnrollment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnrollment.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnEnrollment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEnrollment.Location = New System.Drawing.Point(0, 100)
        Me.btnEnrollment.Name = "btnEnrollment"
        Me.btnEnrollment.Size = New System.Drawing.Size(220, 50)
        Me.btnEnrollment.TabIndex = 6
        Me.btnEnrollment.Text = "Enrollment"
        Me.btnEnrollment.UseVisualStyleBackColor = False
        '
        'btnStudentInfo
        '
        Me.btnStudentInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStudentInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudentInfo.FlatAppearance.BorderSize = 0
        Me.btnStudentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentInfo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnStudentInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnStudentInfo.Location = New System.Drawing.Point(0, 50)
        Me.btnStudentInfo.Name = "btnStudentInfo"
        Me.btnStudentInfo.Size = New System.Drawing.Size(220, 50)
        Me.btnStudentInfo.TabIndex = 7
        Me.btnStudentInfo.Text = "Student Info"
        Me.btnStudentInfo.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(220, 50)
        Me.btnDashboard.TabIndex = 8
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
        Me.pnlHeader.Size = New System.Drawing.Size(980, 60)
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
        Me.lblHeader.Size = New System.Drawing.Size(980, 60)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Registrar Dashboard"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.lblWelcome)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(220, 60)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(980, 640)
        Me.pnlMain.TabIndex = 0
        '
        'lblWelcome
        '
        Me.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblWelcome.Location = New System.Drawing.Point(0, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(980, 640)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome Registrar!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use the menu to manage students, enrollment, and courses."
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'registrarfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Name = "registrarfrm"
        Me.Text = "Registrar Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
End Class
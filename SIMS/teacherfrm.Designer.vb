<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class teacherfrm
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
    Private btnGradeEntry As Button
    Private btnGradeList As Button
    Private btnAnnouncements As Button
    Private btnLogout As Button
    Private lblHeader As Label
    Private lblWelcome As Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAnnouncements = New System.Windows.Forms.Button()
        Me.btnGradeList = New System.Windows.Forms.Button()
        Me.btnGradeEntry = New System.Windows.Forms.Button()
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
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.btnAnnouncements)
        Me.pnlSidebar.Controls.Add(Me.btnGradeList)
        Me.pnlSidebar.Controls.Add(Me.btnGradeEntry)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(200, 600)
        Me.pnlSidebar.TabIndex = 2
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(0, 200)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(200, 50)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnAnnouncements
        '
        Me.btnAnnouncements.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAnnouncements.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAnnouncements.FlatAppearance.BorderSize = 0
        Me.btnAnnouncements.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnouncements.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAnnouncements.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAnnouncements.Location = New System.Drawing.Point(0, 150)
        Me.btnAnnouncements.Name = "btnAnnouncements"
        Me.btnAnnouncements.Size = New System.Drawing.Size(200, 50)
        Me.btnAnnouncements.TabIndex = 1
        Me.btnAnnouncements.Text = "Announcements"
        Me.btnAnnouncements.UseVisualStyleBackColor = False
        '
        'btnGradeList
        '
        Me.btnGradeList.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGradeList.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGradeList.FlatAppearance.BorderSize = 0
        Me.btnGradeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGradeList.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnGradeList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGradeList.Location = New System.Drawing.Point(0, 100)
        Me.btnGradeList.Name = "btnGradeList"
        Me.btnGradeList.Size = New System.Drawing.Size(200, 50)
        Me.btnGradeList.TabIndex = 2
        Me.btnGradeList.Text = "Grade List"
        Me.btnGradeList.UseVisualStyleBackColor = False
        '
        'btnGradeEntry
        '
        Me.btnGradeEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGradeEntry.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGradeEntry.FlatAppearance.BorderSize = 0
        Me.btnGradeEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGradeEntry.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnGradeEntry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGradeEntry.Location = New System.Drawing.Point(0, 50)
        Me.btnGradeEntry.Name = "btnGradeEntry"
        Me.btnGradeEntry.Size = New System.Drawing.Size(200, 50)
        Me.btnGradeEntry.TabIndex = 3
        Me.btnGradeEntry.Text = "Grade Entry"
        Me.btnGradeEntry.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(200, 50)
        Me.btnDashboard.TabIndex = 4
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(200, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(800, 60)
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
        Me.lblHeader.Size = New System.Drawing.Size(800, 60)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Teacher Dashboard"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.lblWelcome)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(200, 60)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(800, 540)
        Me.pnlMain.TabIndex = 0
        '
        'lblWelcome
        '
        Me.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblWelcome.Location = New System.Drawing.Point(0, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(800, 540)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome Teacher!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use the menu to access Grades and Announcements."
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'teacherfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Name = "teacherfrm"
        Me.Text = "Teacher Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class enrollmentfrm
    Inherits System.Windows.Forms.Form

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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlSide = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblS1 = New System.Windows.Forms.Label()
        Me.cmbStudent = New System.Windows.Forms.ComboBox()
        Me.lblS2 = New System.Windows.Forms.Label()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.lblS3 = New System.Windows.Forms.Label()
        Me.txtSchoolYear = New System.Windows.Forms.TextBox()
        Me.lblS4 = New System.Windows.Forms.Label()
        Me.cmbSemester = New System.Windows.Forms.ComboBox()
        Me.btnConfirmEnroll = New System.Windows.Forms.Button()
        Me.dgvSchedules = New System.Windows.Forms.DataGridView()
        Me.pnlSide.SuspendLayout()
        CType(Me.dgvSchedules, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSide
        '
        Me.pnlSide.BackColor = System.Drawing.Color.White
        Me.pnlSide.Controls.Add(Me.lblHeader)
        Me.pnlSide.Controls.Add(Me.lblS1)
        Me.pnlSide.Controls.Add(Me.cmbStudent)
        Me.pnlSide.Controls.Add(Me.lblS2)
        Me.pnlSide.Controls.Add(Me.cmbCourse)
        Me.pnlSide.Controls.Add(Me.lblS3)
        Me.pnlSide.Controls.Add(Me.txtSchoolYear)
        Me.pnlSide.Controls.Add(Me.lblS4)
        Me.pnlSide.Controls.Add(Me.cmbSemester)
        Me.pnlSide.Controls.Add(Me.btnConfirmEnroll)
        Me.pnlSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSide.Location = New System.Drawing.Point(0, 0)
        Me.pnlSide.Name = "pnlSide"
        Me.pnlSide.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlSide.Size = New System.Drawing.Size(320, 600)
        Me.pnlSide.TabIndex = 1
        '
        'lblHeader
        '
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!)
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.lblHeader.Location = New System.Drawing.Point(20, 20)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(280, 40)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "New Enrollment"
        '
        'lblS1
        '
        Me.lblS1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblS1.ForeColor = System.Drawing.Color.Gray
        Me.lblS1.Location = New System.Drawing.Point(25, 80)
        Me.lblS1.Name = "lblS1"
        Me.lblS1.Size = New System.Drawing.Size(100, 23)
        Me.lblS1.TabIndex = 1
        Me.lblS1.Text = "SELECT STUDENT"
        '
        'cmbStudent
        '
        Me.cmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStudent.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cmbStudent.Location = New System.Drawing.Point(25, 100)
        Me.cmbStudent.Name = "cmbStudent"
        Me.cmbStudent.Size = New System.Drawing.Size(270, 27)
        Me.cmbStudent.TabIndex = 2
        '
        'lblS2
        '
        Me.lblS2.Font = Me.lblS1.Font
        Me.lblS2.ForeColor = System.Drawing.Color.Gray
        Me.lblS2.Location = New System.Drawing.Point(25, 150)
        Me.lblS2.Name = "lblS2"
        Me.lblS2.Size = New System.Drawing.Size(100, 23)
        Me.lblS2.TabIndex = 3
        Me.lblS2.Text = "SELECT COURSE"
        '
        'cmbCourse
        '
        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourse.Font = Me.cmbStudent.Font
        Me.cmbCourse.Location = New System.Drawing.Point(25, 170)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(270, 27)
        Me.cmbCourse.TabIndex = 4
        '
        'lblS3
        '
        Me.lblS3.Font = Me.lblS1.Font
        Me.lblS3.ForeColor = System.Drawing.Color.Gray
        Me.lblS3.Location = New System.Drawing.Point(25, 220)
        Me.lblS3.Name = "lblS3"
        Me.lblS3.Size = New System.Drawing.Size(100, 23)
        Me.lblS3.TabIndex = 5
        Me.lblS3.Text = "SCHOOL YEAR"
        '
        'txtSchoolYear
        '
        Me.txtSchoolYear.Font = Me.cmbStudent.Font
        Me.txtSchoolYear.Location = New System.Drawing.Point(25, 240)
        Me.txtSchoolYear.Name = "txtSchoolYear"
        Me.txtSchoolYear.Size = New System.Drawing.Size(270, 26)
        Me.txtSchoolYear.TabIndex = 6
        Me.txtSchoolYear.Text = "2025-2026"
        '
        'lblS4
        '
        Me.lblS4.Font = Me.lblS1.Font
        Me.lblS4.ForeColor = System.Drawing.Color.Gray
        Me.lblS4.Location = New System.Drawing.Point(25, 290)
        Me.lblS4.Name = "lblS4"
        Me.lblS4.Size = New System.Drawing.Size(100, 23)
        Me.lblS4.TabIndex = 7
        Me.lblS4.Text = "SEMESTER"
        '
        'cmbSemester
        '
        Me.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSemester.Font = Me.cmbStudent.Font
        Me.cmbSemester.Items.AddRange(New Object() {"1st Semester", "2nd Semester", "Summer"})
        Me.cmbSemester.Location = New System.Drawing.Point(25, 310)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.Size = New System.Drawing.Size(270, 27)
        Me.cmbSemester.TabIndex = 8
        '
        'btnConfirmEnroll
        '
        Me.btnConfirmEnroll.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnConfirmEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmEnroll.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnConfirmEnroll.ForeColor = System.Drawing.Color.White
        Me.btnConfirmEnroll.Location = New System.Drawing.Point(25, 520)
        Me.btnConfirmEnroll.Name = "btnConfirmEnroll"
        Me.btnConfirmEnroll.Size = New System.Drawing.Size(270, 45)
        Me.btnConfirmEnroll.TabIndex = 9
        Me.btnConfirmEnroll.Text = "Confirm Enrollment"
        Me.btnConfirmEnroll.UseVisualStyleBackColor = False
        '
        'dgvSchedules
        '
        Me.dgvSchedules.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dgvSchedules.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSchedules.ColumnHeadersHeight = 40
        Me.dgvSchedules.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSchedules.Location = New System.Drawing.Point(320, 0)
        Me.dgvSchedules.Name = "dgvSchedules"
        Me.dgvSchedules.RowTemplate.Height = 35
        Me.dgvSchedules.Size = New System.Drawing.Size(680, 600)
        Me.dgvSchedules.TabIndex = 0
        '
        'enrollmentfrm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.dgvSchedules)
        Me.Controls.Add(Me.pnlSide)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "enrollmentfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Enrollment System"
        Me.pnlSide.ResumeLayout(False)
        Me.pnlSide.PerformLayout()
        CType(Me.dgvSchedules, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSide As System.Windows.Forms.Panel
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents cmbStudent As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents txtSchoolYear As System.Windows.Forms.TextBox
    Friend WithEvents cmbSemester As System.Windows.Forms.ComboBox
    Friend WithEvents btnConfirmEnroll As System.Windows.Forms.Button
    Friend WithEvents dgvSchedules As System.Windows.Forms.DataGridView
    Friend WithEvents lblS1 As System.Windows.Forms.Label
    Friend WithEvents lblS2 As System.Windows.Forms.Label
    Friend WithEvents lblS3 As System.Windows.Forms.Label
    Friend WithEvents lblS4 As System.Windows.Forms.Label
End Class
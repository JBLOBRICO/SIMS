<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class schedulelist
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlInputs = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubj = New System.Windows.Forms.Label()
        Me.cmbSubjects = New System.Windows.Forms.ComboBox()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtRoom = New System.Windows.Forms.TextBox()
        Me.dgvSchedules = New System.Windows.Forms.DataGridView()
        Me.pnlInputs.SuspendLayout()
        CType(Me.dgvSchedules, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlInputs
        '
        Me.pnlInputs.BackColor = System.Drawing.Color.White
        Me.pnlInputs.Controls.Add(Me.lblTitle)
        Me.pnlInputs.Controls.Add(Me.lblSubj)
        Me.pnlInputs.Controls.Add(Me.cmbSubjects)
        Me.pnlInputs.Controls.Add(Me.txtSection)
        Me.pnlInputs.Controls.Add(Me.lblTime)
        Me.pnlInputs.Controls.Add(Me.txtDays)
        Me.pnlInputs.Controls.Add(Me.dtpStart)
        Me.pnlInputs.Controls.Add(Me.dtpEnd)
        Me.pnlInputs.Controls.Add(Me.btnSave)
        Me.pnlInputs.Controls.Add(Me.btnDelete)
        Me.pnlInputs.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlInputs.Location = New System.Drawing.Point(0, 0)
        Me.pnlInputs.Name = "pnlInputs"
        Me.pnlInputs.Padding = New System.Windows.Forms.Padding(30)
        Me.pnlInputs.Size = New System.Drawing.Size(360, 680)
        Me.pnlInputs.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(30, 35)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(200, 45)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Schedules"
        '
        'lblSubj
        '
        Me.lblSubj.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSubj.Location = New System.Drawing.Point(30, 100)
        Me.lblSubj.Name = "lblSubj"
        Me.lblSubj.Size = New System.Drawing.Size(100, 23)
        Me.lblSubj.TabIndex = 1
        Me.lblSubj.Text = "Subject & Section"
        '
        'cmbSubjects
        '
        Me.cmbSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSubjects.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbSubjects.Location = New System.Drawing.Point(30, 125)
        Me.cmbSubjects.Name = "cmbSubjects"
        Me.cmbSubjects.Size = New System.Drawing.Size(300, 28)
        Me.cmbSubjects.TabIndex = 2
        '
        'txtSection
        '
        Me.txtSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSection.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtSection.Location = New System.Drawing.Point(30, 170)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(300, 27)
        Me.txtSection.TabIndex = 3
        '
        'lblTime
        '
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(30, 230)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(100, 23)
        Me.lblTime.TabIndex = 4
        Me.lblTime.Text = "Schedule Details"
        '
        'txtDays
        '
        Me.txtDays.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtDays.Location = New System.Drawing.Point(30, 255)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(300, 27)
        Me.txtDays.TabIndex = 5
        '
        'dtpStart
        '
        Me.dtpStart.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStart.Location = New System.Drawing.Point(30, 300)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.ShowUpDown = True
        Me.dtpStart.Size = New System.Drawing.Size(145, 27)
        Me.dtpStart.TabIndex = 6
        '
        'dtpEnd
        '
        Me.dtpEnd.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEnd.Location = New System.Drawing.Point(185, 300)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.ShowUpDown = True
        Me.dtpEnd.Size = New System.Drawing.Size(145, 27)
        Me.dtpEnd.TabIndex = 7
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(30, 400)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(300, 45)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save Schedule"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(30, 460)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(300, 35)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete Selection"
        '
        'txtRoom
        '
        Me.txtRoom.Location = New System.Drawing.Point(0, 0)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(100, 20)
        Me.txtRoom.TabIndex = 0
        '
        'dgvSchedules
        '
        Me.dgvSchedules.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.dgvSchedules.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSchedules.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSchedules.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dgvSchedules.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSchedules.ColumnHeadersHeight = 50
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(81, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSchedules.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSchedules.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSchedules.EnableHeadersVisualStyles = False
        Me.dgvSchedules.GridColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.dgvSchedules.Location = New System.Drawing.Point(360, 0)
        Me.dgvSchedules.Name = "dgvSchedules"
        Me.dgvSchedules.RowTemplate.Height = 50
        Me.dgvSchedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSchedules.Size = New System.Drawing.Size(740, 680)
        Me.dgvSchedules.TabIndex = 0
        '
        'schedulelist
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 680)
        Me.Controls.Add(Me.dgvSchedules)
        Me.Controls.Add(Me.pnlInputs)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "schedulelist"
        Me.Text = "Schedule Management System"
        Me.pnlInputs.ResumeLayout(False)
        Me.pnlInputs.PerformLayout()
        CType(Me.dgvSchedules, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlInputs As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubj As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents cmbSubjects As ComboBox
    Friend WithEvents txtSection As TextBox
    Friend WithEvents txtDays As TextBox
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents txtRoom As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvSchedules As DataGridView
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class courselist
    Inherits System.Windows.Forms.Form

    ' Required designer variable.
    Private components As System.ComponentModel.IContainer

    ' Clean up any resources being used.
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlInputs = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvCourses = New System.Windows.Forms.DataGridView()
        Me.pnlInputs.SuspendLayout()
        CType(Me.dgvCourses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlInputs
        '
        Me.pnlInputs.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.pnlInputs.Controls.Add(Me.lblTitle)
        Me.pnlInputs.Controls.Add(Me.lblCode)
        Me.pnlInputs.Controls.Add(Me.txtCode)
        Me.pnlInputs.Controls.Add(Me.lblName)
        Me.pnlInputs.Controls.Add(Me.txtName)
        Me.pnlInputs.Controls.Add(Me.lblDesc)
        Me.pnlInputs.Controls.Add(Me.txtDescription)
        Me.pnlInputs.Controls.Add(Me.btnSave)
        Me.pnlInputs.Controls.Add(Me.btnDelete)
        Me.pnlInputs.Controls.Add(Me.btnClear)
        Me.pnlInputs.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlInputs.Location = New System.Drawing.Point(0, 0)
        Me.pnlInputs.Name = "pnlInputs"
        Me.pnlInputs.Size = New System.Drawing.Size(320, 500)
        Me.pnlInputs.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(232, 24)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "COURSE MANAGEMENT"
        '
        'lblCode
        '
        Me.lblCode.Location = New System.Drawing.Point(20, 70)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(100, 23)
        Me.lblCode.TabIndex = 1
        Me.lblCode.Text = "Course Code:"
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCode.Location = New System.Drawing.Point(20, 90)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(270, 25)
        Me.txtCode.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(20, 130)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(100, 23)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Course Name:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtName.Location = New System.Drawing.Point(20, 150)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(270, 25)
        Me.txtName.TabIndex = 4
        '
        'lblDesc
        '
        Me.lblDesc.Location = New System.Drawing.Point(20, 190)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(100, 23)
        Me.lblDesc.TabIndex = 5
        Me.lblDesc.Text = "Description:"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtDescription.Location = New System.Drawing.Point(20, 210)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(270, 80)
        Me.txtDescription.TabIndex = 6
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(20, 310)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(270, 35)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save Course"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(20, 355)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(130, 35)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(160, 355)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(130, 35)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        '
        'dgvCourses
        '
        Me.dgvCourses.AllowUserToAddRows = False
        Me.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCourses.BackgroundColor = System.Drawing.Color.White
        Me.dgvCourses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCourses.Location = New System.Drawing.Point(320, 0)
        Me.dgvCourses.Name = "dgvCourses"
        Me.dgvCourses.ReadOnly = True
        Me.dgvCourses.RowHeadersVisible = False
        Me.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCourses.Size = New System.Drawing.Size(580, 500)
        Me.dgvCourses.TabIndex = 0
        '
        'courselist
        '
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.Controls.Add(Me.dgvCourses)
        Me.Controls.Add(Me.pnlInputs)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "courselist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Course Management"
        Me.pnlInputs.ResumeLayout(False)
        Me.pnlInputs.PerformLayout()
        CType(Me.dgvCourses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlInputs As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents dgvCourses As System.Windows.Forms.DataGridView
End Class
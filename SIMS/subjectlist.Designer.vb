<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class subjectlist
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlInputs = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblSubjectTitle = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.numUnits = New System.Windows.Forms.NumericUpDown()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvSubjects = New System.Windows.Forms.DataGridView()
        Me.pnlInputs.SuspendLayout()
        CType(Me.numUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlInputs
        '
        Me.pnlInputs.BackColor = System.Drawing.Color.White
        Me.pnlInputs.Controls.Add(Me.lblTitle)
        Me.pnlInputs.Controls.Add(Me.lblCode)
        Me.pnlInputs.Controls.Add(Me.txtCode)
        Me.pnlInputs.Controls.Add(Me.lblSubjectTitle)
        Me.pnlInputs.Controls.Add(Me.txtTitle)
        Me.pnlInputs.Controls.Add(Me.lblUnits)
        Me.pnlInputs.Controls.Add(Me.numUnits)
        Me.pnlInputs.Controls.Add(Me.btnSave)
        Me.pnlInputs.Controls.Add(Me.btnDelete)
        Me.pnlInputs.Controls.Add(Me.btnClear)
        Me.pnlInputs.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlInputs.Location = New System.Drawing.Point(0, 0)
        Me.pnlInputs.Name = "pnlInputs"
        Me.pnlInputs.Padding = New System.Windows.Forms.Padding(25)
        Me.pnlInputs.Size = New System.Drawing.Size(340, 600)
        Me.pnlInputs.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(25, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(96, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Subjects"
        '
        'lblCode
        '
        Me.lblCode.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblCode.ForeColor = System.Drawing.Color.Gray
        Me.lblCode.Location = New System.Drawing.Point(25, 90)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(100, 23)
        Me.lblCode.TabIndex = 1
        Me.lblCode.Text = "SUBJECT CODE"
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCode.Location = New System.Drawing.Point(25, 115)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(280, 27)
        Me.txtCode.TabIndex = 2
        '
        'lblSubjectTitle
        '
        Me.lblSubjectTitle.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblSubjectTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblSubjectTitle.Location = New System.Drawing.Point(25, 170)
        Me.lblSubjectTitle.Name = "lblSubjectTitle"
        Me.lblSubjectTitle.Size = New System.Drawing.Size(100, 23)
        Me.lblSubjectTitle.TabIndex = 3
        Me.lblSubjectTitle.Text = "SUBJECT TITLE"
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtTitle.Location = New System.Drawing.Point(25, 195)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(280, 27)
        Me.txtTitle.TabIndex = 4
        '
        'lblUnits
        '
        Me.lblUnits.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblUnits.ForeColor = System.Drawing.Color.Gray
        Me.lblUnits.Location = New System.Drawing.Point(25, 250)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(100, 23)
        Me.lblUnits.TabIndex = 5
        Me.lblUnits.Text = "UNITS"
        '
        'numUnits
        '
        Me.numUnits.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.numUnits.Location = New System.Drawing.Point(25, 275)
        Me.numUnits.Name = "numUnits"
        Me.numUnits.Size = New System.Drawing.Size(100, 27)
        Me.numUnits.TabIndex = 6
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(25, 340)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(280, 45)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save Subject"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(25, 440)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(280, 30)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete Record"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Gray
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClear.Location = New System.Drawing.Point(25, 395)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(280, 35)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear Fields"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'dgvSubjects
        '
        Me.dgvSubjects.AllowUserToAddRows = False
        Me.dgvSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSubjects.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.dgvSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSubjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSubjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.dgvSubjects.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSubjects.ColumnHeadersHeight = 50
        Me.dgvSubjects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSubjects.EnableHeadersVisualStyles = False
        Me.dgvSubjects.GridColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.dgvSubjects.Location = New System.Drawing.Point(340, 0)
        Me.dgvSubjects.Name = "dgvSubjects"
        Me.dgvSubjects.ReadOnly = True
        Me.dgvSubjects.RowHeadersVisible = False
        Me.dgvSubjects.RowTemplate.Height = 45
        Me.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSubjects.Size = New System.Drawing.Size(660, 600)
        Me.dgvSubjects.TabIndex = 0
        '
        'subjectlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.dgvSubjects)
        Me.Controls.Add(Me.pnlInputs)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.Name = "subjectlist"
        Me.Text = "Subject Management"
        Me.pnlInputs.ResumeLayout(False)
        Me.pnlInputs.PerformLayout()
        CType(Me.numUnits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlInputs As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents numUnits As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents dgvSubjects As System.Windows.Forms.DataGridView
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents lblSubjectTitle As System.Windows.Forms.Label
    Friend WithEvents lblUnits As System.Windows.Forms.Label
End Class
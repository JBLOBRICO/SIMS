<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addnewstudent
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
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.lblFN = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblLN = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblBD = New System.Windows.Forms.Label()
        Me.dtpBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.lblAddr = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContainer
        '
        Me.pnlContainer.BackColor = System.Drawing.Color.White
        Me.pnlContainer.Controls.Add(Me.lblHeader)
        Me.pnlContainer.Controls.Add(Me.lblID)
        Me.pnlContainer.Controls.Add(Me.txtStudentID)
        Me.pnlContainer.Controls.Add(Me.lblFN)
        Me.pnlContainer.Controls.Add(Me.txtFirstName)
        Me.pnlContainer.Controls.Add(Me.lblLN)
        Me.pnlContainer.Controls.Add(Me.txtLastName)
        Me.pnlContainer.Controls.Add(Me.lblEmail)
        Me.pnlContainer.Controls.Add(Me.txtEmail)
        Me.pnlContainer.Controls.Add(Me.lblBD)
        Me.pnlContainer.Controls.Add(Me.dtpBirthdate)
        Me.pnlContainer.Controls.Add(Me.lblAddr)
        Me.pnlContainer.Controls.Add(Me.txtAddress)
        Me.pnlContainer.Controls.Add(Me.btnSave)
        Me.pnlContainer.Controls.Add(Me.btnCancel)
        Me.pnlContainer.Location = New System.Drawing.Point(40, 30)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(420, 580)
        Me.pnlContainer.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!)
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.lblHeader.Location = New System.Drawing.Point(30, 25)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(300, 40)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Student Registration"
        '
        'lblID
        '
        Me.lblID.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblID.ForeColor = System.Drawing.Color.Gray
        Me.lblID.Location = New System.Drawing.Point(35, 80)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(100, 23)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "STUDENT ID"
        '
        'txtStudentID
        '
        Me.txtStudentID.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtStudentID.Location = New System.Drawing.Point(35, 100)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(350, 27)
        Me.txtStudentID.TabIndex = 2
        '
        'lblFN
        '
        Me.lblFN.Font = Me.lblID.Font
        Me.lblFN.ForeColor = System.Drawing.Color.Gray
        Me.lblFN.Location = New System.Drawing.Point(35, 145)
        Me.lblFN.Name = "lblFN"
        Me.lblFN.Size = New System.Drawing.Size(100, 23)
        Me.lblFN.TabIndex = 3
        Me.lblFN.Text = "FIRST NAME"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = Me.txtStudentID.Font
        Me.txtFirstName.Location = New System.Drawing.Point(35, 165)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(350, 27)
        Me.txtFirstName.TabIndex = 4
        '
        'lblLN
        '
        Me.lblLN.Font = Me.lblID.Font
        Me.lblLN.ForeColor = System.Drawing.Color.Gray
        Me.lblLN.Location = New System.Drawing.Point(35, 210)
        Me.lblLN.Name = "lblLN"
        Me.lblLN.Size = New System.Drawing.Size(100, 23)
        Me.lblLN.TabIndex = 5
        Me.lblLN.Text = "LAST NAME"
        '
        'txtLastName
        '
        Me.txtLastName.Font = Me.txtStudentID.Font
        Me.txtLastName.Location = New System.Drawing.Point(35, 230)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(350, 27)
        Me.txtLastName.TabIndex = 6
        '
        'lblEmail
        '
        Me.lblEmail.Font = Me.lblID.Font
        Me.lblEmail.ForeColor = System.Drawing.Color.Gray
        Me.lblEmail.Location = New System.Drawing.Point(35, 275)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(100, 23)
        Me.lblEmail.TabIndex = 7
        Me.lblEmail.Text = "EMAIL ADDRESS"
        '
        'txtEmail
        '
        Me.txtEmail.Font = Me.txtStudentID.Font
        Me.txtEmail.Location = New System.Drawing.Point(35, 295)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(350, 27)
        Me.txtEmail.TabIndex = 8
        '
        'lblBD
        '
        Me.lblBD.Font = Me.lblID.Font
        Me.lblBD.ForeColor = System.Drawing.Color.Gray
        Me.lblBD.Location = New System.Drawing.Point(35, 340)
        Me.lblBD.Name = "lblBD"
        Me.lblBD.Size = New System.Drawing.Size(100, 23)
        Me.lblBD.TabIndex = 9
        Me.lblBD.Text = "BIRTH DATE"
        '
        'dtpBirthdate
        '
        Me.dtpBirthdate.Font = Me.txtStudentID.Font
        Me.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBirthdate.Location = New System.Drawing.Point(35, 360)
        Me.dtpBirthdate.Name = "dtpBirthdate"
        Me.dtpBirthdate.Size = New System.Drawing.Size(350, 27)
        Me.dtpBirthdate.TabIndex = 10
        '
        'lblAddr
        '
        Me.lblAddr.Font = Me.lblID.Font
        Me.lblAddr.ForeColor = System.Drawing.Color.Gray
        Me.lblAddr.Location = New System.Drawing.Point(35, 405)
        Me.lblAddr.Name = "lblAddr"
        Me.lblAddr.Size = New System.Drawing.Size(100, 23)
        Me.lblAddr.TabIndex = 11
        Me.lblAddr.Text = "COMPLETE ADDRESS"
        '
        'txtAddress
        '
        Me.txtAddress.Font = Me.txtStudentID.Font
        Me.txtAddress.Location = New System.Drawing.Point(35, 425)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(350, 60)
        Me.txtAddress.TabIndex = 12
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(235, 510)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 45)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save Record"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.DimGray
        Me.btnCancel.Location = New System.Drawing.Point(120, 510)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 45)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'addnewstudent
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 650)
        Me.Controls.Add(Me.pnlContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "addnewstudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Register New Student"
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContainer As System.Windows.Forms.Panel
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents txtStudentID As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents dtpBirthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblFN As System.Windows.Forms.Label
    Friend WithEvents lblLN As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblBD As System.Windows.Forms.Label
    Friend WithEvents lblAddr As System.Windows.Forms.Label
End Class
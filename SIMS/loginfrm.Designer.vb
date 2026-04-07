<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginfrm
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
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

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.pnlContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContainer
        '
        Me.pnlContainer.BackColor = System.Drawing.Color.White
        Me.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlContainer.Controls.Add(Me.CheckBox1)
        Me.pnlContainer.Controls.Add(Me.Button1)
        Me.pnlContainer.Controls.Add(Me.lblTitle)
        Me.pnlContainer.Controls.Add(Me.lblUser)
        Me.pnlContainer.Controls.Add(Me.txtUsername)
        Me.pnlContainer.Controls.Add(Me.lblPass)
        Me.pnlContainer.Controls.Add(Me.txtPassword)
        Me.pnlContainer.Controls.Add(Me.btnLogin)
        Me.pnlContainer.Location = New System.Drawing.Point(50, 40)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(300, 288)
        Me.pnlContainer.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(29, 183)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(102, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(159, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 39)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(115, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(70, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Login"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblUser.Location = New System.Drawing.Point(25, 70)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(71, 19)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtUsername.Location = New System.Drawing.Point(25, 90)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(250, 27)
        Me.txtUsername.TabIndex = 2
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblPass.Location = New System.Drawing.Point(25, 130)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(67, 19)
        Me.lblPass.TabIndex = 3
        Me.lblPass.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtPassword.Location = New System.Drawing.Point(25, 150)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(250, 27)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(25, 220)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(114, 39)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'loginfrm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 350)
        Me.Controls.Add(Me.pnlContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "loginfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    ' CRITICAL: These must have "WithEvents" for the Handles clause in your code to work!
    Friend WithEvents pnlContainer As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button

End Class
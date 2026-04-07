<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Financefrm
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
    Private btnBilling As Button
    Private btnPayments As Button
    Private btnReports As Button
    Private btnLogout As Button
    Private lblHeader As Label
    Private lblWelcome As Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnPayments = New System.Windows.Forms.Button()
        Me.btnBilling = New System.Windows.Forms.Button()
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
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.btnReports)
        Me.pnlSidebar.Controls.Add(Me.btnPayments)
        Me.pnlSidebar.Controls.Add(Me.btnBilling)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 700)
        Me.pnlSidebar.TabIndex = 2
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(0, 200)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(220, 50)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnReports.Location = New System.Drawing.Point(0, 150)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(220, 50)
        Me.btnReports.TabIndex = 1
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnPayments
        '
        Me.btnPayments.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPayments.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPayments.FlatAppearance.BorderSize = 0
        Me.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayments.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnPayments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnPayments.Location = New System.Drawing.Point(0, 100)
        Me.btnPayments.Name = "btnPayments"
        Me.btnPayments.Size = New System.Drawing.Size(220, 50)
        Me.btnPayments.TabIndex = 2
        Me.btnPayments.Text = "Payments"
        Me.btnPayments.UseVisualStyleBackColor = False
        '
        'btnBilling
        '
        Me.btnBilling.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBilling.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBilling.FlatAppearance.BorderSize = 0
        Me.btnBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBilling.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnBilling.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBilling.Location = New System.Drawing.Point(0, 50)
        Me.btnBilling.Name = "btnBilling"
        Me.btnBilling.Size = New System.Drawing.Size(220, 50)
        Me.btnBilling.TabIndex = 3
        Me.btnBilling.Text = "Billing"
        Me.btnBilling.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(220, 50)
        Me.btnDashboard.TabIndex = 4
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
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
        Me.lblHeader.Text = "Finance Dashboard"
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
        Me.lblWelcome.Text = "Welcome Finance Officer!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use the menu to manage Billing, Payments, and Reports."
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Financefrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Name = "Financefrm"
        Me.Text = "Finance Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
End Class
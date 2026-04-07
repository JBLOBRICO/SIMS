<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Billing
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

    Private components As System.ComponentModel.IContainer

    ' UI Elements
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvBilling As DataGridView
    Friend WithEvents pnlPaymentArea As Panel
    Friend WithEvents lblSelectedStudent As Label
    Friend WithEvents lblBalanceStatus As Label
    Friend WithEvents txtPaymentInput As TextBox
    Friend WithEvents btnPartialPay As Button
    Friend WithEvents btnFullPay As Button
    Friend WithEvents lblInstruction As Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvBilling = New System.Windows.Forms.DataGridView()
        Me.pnlPaymentArea = New System.Windows.Forms.Panel()
        Me.lblSelectedStudent = New System.Windows.Forms.Label()
        Me.lblBalanceStatus = New System.Windows.Forms.Label()
        Me.txtPaymentInput = New System.Windows.Forms.TextBox()
        Me.btnPartialPay = New System.Windows.Forms.Button()
        Me.btnFullPay = New System.Windows.Forms.Button()
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        CType(Me.dgvBilling, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPaymentArea.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Controls.Add(Me.txtSearch)
        Me.pnlHeader.Controls.Add(Me.btnSearch)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(934, 70)
        Me.pnlHeader.TabIndex = 0
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblHeaderTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(221, 24)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "BILLING MANAGEMENT"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(600, 25)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 23)
        Me.txtSearch.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(810, 23)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'dgvBilling
        '
        Me.dgvBilling.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvBilling.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvBilling.Location = New System.Drawing.Point(20, 90)
        Me.dgvBilling.Name = "dgvBilling"
        Me.dgvBilling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBilling.Size = New System.Drawing.Size(900, 300)
        Me.dgvBilling.TabIndex = 1
        '
        'pnlPaymentArea
        '
        Me.pnlPaymentArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlPaymentArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPaymentArea.Controls.Add(Me.lblSelectedStudent)
        Me.pnlPaymentArea.Controls.Add(Me.lblBalanceStatus)
        Me.pnlPaymentArea.Controls.Add(Me.txtPaymentInput)
        Me.pnlPaymentArea.Controls.Add(Me.btnPartialPay)
        Me.pnlPaymentArea.Controls.Add(Me.btnFullPay)
        Me.pnlPaymentArea.Location = New System.Drawing.Point(20, 410)
        Me.pnlPaymentArea.Name = "pnlPaymentArea"
        Me.pnlPaymentArea.Size = New System.Drawing.Size(900, 180)
        Me.pnlPaymentArea.TabIndex = 2
        '
        'lblSelectedStudent
        '
        Me.lblSelectedStudent.AutoSize = True
        Me.lblSelectedStudent.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!)
        Me.lblSelectedStudent.Location = New System.Drawing.Point(20, 20)
        Me.lblSelectedStudent.Name = "lblSelectedStudent"
        Me.lblSelectedStudent.Size = New System.Drawing.Size(107, 20)
        Me.lblSelectedStudent.TabIndex = 0
        Me.lblSelectedStudent.Text = "STUDENT: ----"
        '
        'lblBalanceStatus
        '
        Me.lblBalanceStatus.AutoSize = True
        Me.lblBalanceStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblBalanceStatus.ForeColor = System.Drawing.Color.Crimson
        Me.lblBalanceStatus.Location = New System.Drawing.Point(20, 50)
        Me.lblBalanceStatus.Name = "lblBalanceStatus"
        Me.lblBalanceStatus.Size = New System.Drawing.Size(138, 20)
        Me.lblBalanceStatus.TabIndex = 1
        Me.lblBalanceStatus.Text = "BALANCE: ₱ 0.00"
        '
        'txtPaymentInput
        '
        Me.txtPaymentInput.Location = New System.Drawing.Point(20, 120)
        Me.txtPaymentInput.Name = "txtPaymentInput"
        Me.txtPaymentInput.Size = New System.Drawing.Size(200, 23)
        Me.txtPaymentInput.TabIndex = 2
        '
        'btnPartialPay
        '
        Me.btnPartialPay.BackColor = System.Drawing.Color.Orange
        Me.btnPartialPay.Location = New System.Drawing.Point(240, 115)
        Me.btnPartialPay.Name = "btnPartialPay"
        Me.btnPartialPay.Size = New System.Drawing.Size(120, 40)
        Me.btnPartialPay.TabIndex = 3
        Me.btnPartialPay.Text = "PARTIAL"
        Me.btnPartialPay.UseVisualStyleBackColor = False
        '
        'btnFullPay
        '
        Me.btnFullPay.BackColor = System.Drawing.Color.SeaGreen
        Me.btnFullPay.Location = New System.Drawing.Point(370, 115)
        Me.btnFullPay.Name = "btnFullPay"
        Me.btnFullPay.Size = New System.Drawing.Size(120, 40)
        Me.btnFullPay.TabIndex = 4
        Me.btnFullPay.Text = "FULL"
        Me.btnFullPay.UseVisualStyleBackColor = False
        '
        'lblInstruction
        '
        Me.lblInstruction.Location = New System.Drawing.Point(0, 0)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(100, 23)
        Me.lblInstruction.TabIndex = 0
        '
        'Billing
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(934, 611)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.dgvBilling)
        Me.Controls.Add(Me.pnlPaymentArea)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "Billing"
        Me.Text = "SIMS - Billing & Collection"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.dgvBilling, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPaymentArea.ResumeLayout(False)
        Me.pnlPaymentArea.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
End Class
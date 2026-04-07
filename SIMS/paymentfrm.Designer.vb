<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class paymentfrm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    ' UI Controls
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtSearchStudent As TextBox
    Friend WithEvents btnFindBill As Button
    Friend WithEvents dgvBills As DataGridView
    Friend WithEvents grpPayment As GroupBox
    Friend WithEvents lblBillID As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblCurrentBalance As Label
    Friend WithEvents txtAmountToPay As TextBox
    Friend WithEvents txtReferenceNo As TextBox
    Friend WithEvents btnProcessPayment As Button
    Friend WithEvents lblRefLabel As Label
    Friend WithEvents lblAmtLabel As Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtSearchStudent = New System.Windows.Forms.TextBox()
        Me.btnFindBill = New System.Windows.Forms.Button()
        Me.dgvBills = New System.Windows.Forms.DataGridView()
        Me.grpPayment = New System.Windows.Forms.GroupBox()
        Me.lblBillID = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblCurrentBalance = New System.Windows.Forms.Label()
        Me.lblAmtLabel = New System.Windows.Forms.Label()
        Me.txtAmountToPay = New System.Windows.Forms.TextBox()
        Me.lblRefLabel = New System.Windows.Forms.Label()
        Me.txtReferenceNo = New System.Windows.Forms.TextBox()
        Me.btnProcessPayment = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        CType(Me.dgvBills, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(850, 60)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(202, 20)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "PAYMENT TRANSACTION"
        '
        'txtSearchStudent
        '
        Me.txtSearchStudent.Location = New System.Drawing.Point(20, 80)
        Me.txtSearchStudent.Name = "txtSearchStudent"
        Me.txtSearchStudent.Size = New System.Drawing.Size(250, 23)
        Me.txtSearchStudent.TabIndex = 1
        '
        'btnFindBill
        '
        Me.btnFindBill.Location = New System.Drawing.Point(280, 78)
        Me.btnFindBill.Name = "btnFindBill"
        Me.btnFindBill.Size = New System.Drawing.Size(100, 30)
        Me.btnFindBill.TabIndex = 2
        Me.btnFindBill.Text = "Search Bill"
        '
        'dgvBills
        '
        Me.dgvBills.AllowUserToAddRows = False
        Me.dgvBills.Location = New System.Drawing.Point(20, 120)
        Me.dgvBills.Name = "dgvBills"
        Me.dgvBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBills.Size = New System.Drawing.Size(810, 180)
        Me.dgvBills.TabIndex = 3
        '
        'grpPayment
        '
        Me.grpPayment.Controls.Add(Me.lblBillID)
        Me.grpPayment.Controls.Add(Me.lblStudentName)
        Me.grpPayment.Controls.Add(Me.lblCurrentBalance)
        Me.grpPayment.Controls.Add(Me.lblAmtLabel)
        Me.grpPayment.Controls.Add(Me.txtAmountToPay)
        Me.grpPayment.Controls.Add(Me.lblRefLabel)
        Me.grpPayment.Controls.Add(Me.txtReferenceNo)
        Me.grpPayment.Controls.Add(Me.btnProcessPayment)
        Me.grpPayment.Location = New System.Drawing.Point(20, 310)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Size = New System.Drawing.Size(810, 210)
        Me.grpPayment.TabIndex = 4
        Me.grpPayment.TabStop = False
        Me.grpPayment.Text = "Payment Details"
        '
        'lblBillID
        '
        Me.lblBillID.Location = New System.Drawing.Point(20, 35)
        Me.lblBillID.Name = "lblBillID"
        Me.lblBillID.Size = New System.Drawing.Size(100, 23)
        Me.lblBillID.TabIndex = 0
        Me.lblBillID.Text = "Billing ID: --"
        '
        'lblStudentName
        '
        Me.lblStudentName.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.lblStudentName.Location = New System.Drawing.Point(20, 60)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(100, 23)
        Me.lblStudentName.TabIndex = 1
        Me.lblStudentName.Text = "Student: --"
        '
        'lblCurrentBalance
        '
        Me.lblCurrentBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblCurrentBalance.ForeColor = System.Drawing.Color.Red
        Me.lblCurrentBalance.Location = New System.Drawing.Point(20, 90)
        Me.lblCurrentBalance.Name = "lblCurrentBalance"
        Me.lblCurrentBalance.Size = New System.Drawing.Size(100, 23)
        Me.lblCurrentBalance.TabIndex = 2
        Me.lblCurrentBalance.Text = "Current Balance: 0.00"
        '
        'lblAmtLabel
        '
        Me.lblAmtLabel.Location = New System.Drawing.Point(400, 35)
        Me.lblAmtLabel.Name = "lblAmtLabel"
        Me.lblAmtLabel.Size = New System.Drawing.Size(100, 23)
        Me.lblAmtLabel.TabIndex = 3
        Me.lblAmtLabel.Text = "Amount to Pay:"
        '
        'txtAmountToPay
        '
        Me.txtAmountToPay.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtAmountToPay.Location = New System.Drawing.Point(400, 55)
        Me.txtAmountToPay.Name = "txtAmountToPay"
        Me.txtAmountToPay.Size = New System.Drawing.Size(200, 29)
        Me.txtAmountToPay.TabIndex = 4
        '
        'lblRefLabel
        '
        Me.lblRefLabel.Location = New System.Drawing.Point(400, 100)
        Me.lblRefLabel.Name = "lblRefLabel"
        Me.lblRefLabel.Size = New System.Drawing.Size(100, 23)
        Me.lblRefLabel.TabIndex = 5
        Me.lblRefLabel.Text = "Reference No (OR#):"
        '
        'txtReferenceNo
        '
        Me.txtReferenceNo.Location = New System.Drawing.Point(400, 120)
        Me.txtReferenceNo.Name = "txtReferenceNo"
        Me.txtReferenceNo.Size = New System.Drawing.Size(200, 23)
        Me.txtReferenceNo.TabIndex = 6
        '
        'btnProcessPayment
        '
        Me.btnProcessPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnProcessPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcessPayment.ForeColor = System.Drawing.Color.White
        Me.btnProcessPayment.Location = New System.Drawing.Point(630, 55)
        Me.btnProcessPayment.Name = "btnProcessPayment"
        Me.btnProcessPayment.Size = New System.Drawing.Size(150, 100)
        Me.btnProcessPayment.TabIndex = 7
        Me.btnProcessPayment.Text = "CONFIRM PAYMENT"
        Me.btnProcessPayment.UseVisualStyleBackColor = False
        '
        'paymentfrm
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(850, 550)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.txtSearchStudent)
        Me.Controls.Add(Me.btnFindBill)
        Me.Controls.Add(Me.dgvBills)
        Me.Controls.Add(Me.grpPayment)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "paymentfrm"
        Me.Text = "SIMS - Process Payment"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.dgvBills, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPayment.ResumeLayout(False)
        Me.grpPayment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
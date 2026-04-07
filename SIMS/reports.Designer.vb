<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reports
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

    ' UI Elements
    Friend WithEvents pnlTopNav As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents dgvReportTable As DataGridView
    Friend WithEvents grpFilters As GroupBox
    Friend WithEvents cmbReportType As ComboBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents lblTotalCollections As Label
    Friend WithEvents lblPendingBalance As Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlTopNav = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTotalCollections = New System.Windows.Forms.Label()
        Me.lblPendingBalance = New System.Windows.Forms.Label()
        Me.dgvReportTable = New System.Windows.Forms.DataGridView()
        Me.grpFilters = New System.Windows.Forms.GroupBox()
        Me.cmbReportType = New System.Windows.Forms.ComboBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.pnlTopNav.SuspendLayout()
        CType(Me.dgvReportTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFilters.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTopNav
        '
        Me.pnlTopNav.BackColor = System.Drawing.Color.White
        Me.pnlTopNav.Controls.Add(Me.lblTitle)
        Me.pnlTopNav.Controls.Add(Me.lblTotalCollections)
        Me.pnlTopNav.Controls.Add(Me.lblPendingBalance)
        Me.pnlTopNav.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopNav.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopNav.Name = "pnlTopNav"
        Me.pnlTopNav.Size = New System.Drawing.Size(984, 70)
        Me.pnlTopNav.TabIndex = 2
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblTitle.Location = New System.Drawing.Point(25, 22)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(243, 24)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "MANAGEMENT REPORTS"
        '
        'lblTotalCollections
        '
        Me.lblTotalCollections.AutoSize = True
        Me.lblTotalCollections.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.lblTotalCollections.ForeColor = System.Drawing.Color.SeaGreen
        Me.lblTotalCollections.Location = New System.Drawing.Point(500, 25)
        Me.lblTotalCollections.Name = "lblTotalCollections"
        Me.lblTotalCollections.Size = New System.Drawing.Size(150, 19)
        Me.lblTotalCollections.TabIndex = 1
        Me.lblTotalCollections.Text = "Total Collected: ₱ 0.00"
        '
        'lblPendingBalance
        '
        Me.lblPendingBalance.AutoSize = True
        Me.lblPendingBalance.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.lblPendingBalance.ForeColor = System.Drawing.Color.Crimson
        Me.lblPendingBalance.Location = New System.Drawing.Point(750, 25)
        Me.lblPendingBalance.Name = "lblPendingBalance"
        Me.lblPendingBalance.Size = New System.Drawing.Size(164, 19)
        Me.lblPendingBalance.TabIndex = 2
        Me.lblPendingBalance.Text = "Total Receivables: ₱ 0.00"
        '
        'dgvReportTable
        '
        Me.dgvReportTable.BackgroundColor = System.Drawing.Color.White
        Me.dgvReportTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReportTable.Location = New System.Drawing.Point(25, 195)
        Me.dgvReportTable.Name = "dgvReportTable"
        Me.dgvReportTable.ReadOnly = True
        Me.dgvReportTable.Size = New System.Drawing.Size(935, 400)
        Me.dgvReportTable.TabIndex = 0
        '
        'grpFilters
        '
        Me.grpFilters.BackColor = System.Drawing.Color.White
        Me.grpFilters.Controls.Add(Me.cmbReportType)
        Me.grpFilters.Controls.Add(Me.btnGenerate)
        Me.grpFilters.Location = New System.Drawing.Point(25, 90)
        Me.grpFilters.Name = "grpFilters"
        Me.grpFilters.Size = New System.Drawing.Size(935, 85)
        Me.grpFilters.TabIndex = 1
        Me.grpFilters.TabStop = False
        Me.grpFilters.Text = "Report Settings"
        '
        'cmbReportType
        '
        Me.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReportType.Items.AddRange(New Object() {"Daily Collection Report", "Students with Unpaid Balance", "Enrollment by Course"})
        Me.cmbReportType.Location = New System.Drawing.Point(20, 35)
        Me.cmbReportType.Name = "cmbReportType"
        Me.cmbReportType.Size = New System.Drawing.Size(280, 23)
        Me.cmbReportType.TabIndex = 0
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.ForeColor = System.Drawing.Color.White
        Me.btnGenerate.Location = New System.Drawing.Point(320, 32)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(150, 35)
        Me.btnGenerate.TabIndex = 1
        Me.btnGenerate.Text = "GENERATE REPORT"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'reports
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 611)
        Me.Controls.Add(Me.dgvReportTable)
        Me.Controls.Add(Me.grpFilters)
        Me.Controls.Add(Me.pnlTopNav)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "reports"
        Me.Text = "SIMS - Reports Dashboard"
        Me.pnlTopNav.ResumeLayout(False)
        Me.pnlTopNav.PerformLayout()
        CType(Me.dgvReportTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFilters.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
End Class
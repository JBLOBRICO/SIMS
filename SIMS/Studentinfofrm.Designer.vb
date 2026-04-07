<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Studentinfofrm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
    Private lblHeader As Label
    Private lblSearch As Label
    Private txtSearch As TextBox
    Private dgvStudents As DataGridView

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblHeader = New Label()
        Me.lblSearch = New Label()
        Me.txtSearch = New TextBox()
        Me.dgvStudents = New DataGridView()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' lblHeader
        '
        Me.lblHeader.Top = 10
        Me.lblHeader.Left = 10
        Me.lblHeader.Width = 1000
        Me.lblHeader.Height = 40
        Me.lblHeader.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        Me.lblHeader.Text = "Student Information"
        Me.lblHeader.TextAlign = ContentAlignment.MiddleLeft
        '
        ' lblSearch
        '
        Me.lblSearch.Top = 60
        Me.lblSearch.Left = 10
        Me.lblSearch.Width = 120
        Me.lblSearch.Height = 25
        Me.lblSearch.Font = New Font("Segoe UI", 10)
        Me.lblSearch.Text = "Search Students:"
        '
        ' txtSearch
        '
        Me.txtSearch.Top = 60
        Me.txtSearch.Left = 135
        Me.txtSearch.Width = 250
        Me.txtSearch.Height = 25
        Me.txtSearch.Font = New Font("Segoe UI", 10)
        '
        ' dgvStudents
        '
        Me.dgvStudents.Top = 100
        Me.dgvStudents.Left = 10
        Me.dgvStudents.Width = 760
        Me.dgvStudents.Height = 340
        Me.dgvStudents.BackgroundColor = Color.White
        Me.dgvStudents.BorderStyle = BorderStyle.None
        Me.dgvStudents.EnableHeadersVisualStyles = False
        Me.dgvStudents.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(180, 225, 250)
        Me.dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 30)
        Me.dgvStudents.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.dgvStudents.RowTemplate.Height = 40
        Me.dgvStudents.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 240, 255)
        Me.dgvStudents.DefaultCellStyle.SelectionForeColor = Color.Black
        Me.dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStudents.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Me.dgvStudents.ReadOnly = True
        Me.dgvStudents.MultiSelect = False
        Me.dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        '
        ' Studentinfofrm
        '
        Me.ClientSize = New Size(800, 450)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvStudents)
        Me.Text = "Student Information"
        Me.WindowState = FormWindowState.Maximized
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
End Class
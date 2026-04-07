<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Usermngmtfrm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
    Private lblHeader As Label
    Private lblSearch As Label
    Private txtSearch As TextBox
    Private dgvUsers As DataGridView
    Private btnAdd As Button
    Private btnEdit As Button
    Private btnApprove As Button
    Private btnDelete As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblHeader = New Label()
        Me.lblSearch = New Label()
        Me.txtSearch = New TextBox()
        Me.dgvUsers = New DataGridView()
        Me.btnAdd = New Button()
        Me.btnEdit = New Button()
        Me.btnApprove = New Button()
        Me.btnDelete = New Button()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' lblHeader
        '
        Me.lblHeader.Top = 10
        Me.lblHeader.Left = 10
        Me.lblHeader.Width = 1000
        Me.lblHeader.Height = 40
        Me.lblHeader.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        Me.lblHeader.Text = "User Management"
        Me.lblHeader.TextAlign = ContentAlignment.MiddleLeft
        '
        ' lblSearch
        '
        Me.lblSearch.Top = 60
        Me.lblSearch.Left = 10
        Me.lblSearch.Width = 100
        Me.lblSearch.Height = 25
        Me.lblSearch.Font = New Font("Segoe UI", 10)
        Me.lblSearch.Text = "Search Users:"
        '
        ' txtSearch
        '
        Me.txtSearch.Top = 60
        Me.txtSearch.Left = 115
        Me.txtSearch.Width = 250
        Me.txtSearch.Height = 25
        Me.txtSearch.Font = New Font("Segoe UI", 10)
        '
        ' Buttons
        '
        Me.btnAdd.Top = 60
        Me.btnAdd.Left = 400
        Me.btnAdd.Width = 100
        Me.btnAdd.Height = 30
        Me.btnAdd.Text = "Add"
        Me.btnAdd.BackColor = Color.FromArgb(100, 180, 250)
        Me.btnAdd.ForeColor = Color.White
        Me.btnAdd.FlatStyle = FlatStyle.Flat
        Me.btnAdd.Font = New Font("Segoe UI", 10, FontStyle.Bold)

        Me.btnEdit.Top = 60
        Me.btnEdit.Left = 510
        Me.btnEdit.Width = 100
        Me.btnEdit.Height = 30
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.BackColor = Color.FromArgb(100, 180, 250)
        Me.btnEdit.ForeColor = Color.White
        Me.btnEdit.FlatStyle = FlatStyle.Flat
        Me.btnEdit.Font = New Font("Segoe UI", 10, FontStyle.Bold)

        Me.btnApprove.Top = 60
        Me.btnApprove.Left = 620
        Me.btnApprove.Width = 120
        Me.btnApprove.Height = 30
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.BackColor = Color.FromArgb(100, 180, 250)
        Me.btnApprove.ForeColor = Color.White
        Me.btnApprove.FlatStyle = FlatStyle.Flat
        Me.btnApprove.Font = New Font("Segoe UI", 10, FontStyle.Bold)

        Me.btnDelete.Top = 60
        Me.btnDelete.Left = 750
        Me.btnDelete.Width = 100
        Me.btnDelete.Height = 30
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.BackColor = Color.FromArgb(220, 70, 70)
        Me.btnDelete.ForeColor = Color.White
        Me.btnDelete.FlatStyle = FlatStyle.Flat
        Me.btnDelete.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        '
        ' dgvUsers
        '
        Me.dgvUsers.Top = 100
        Me.dgvUsers.Left = 10
        Me.dgvUsers.Width = 1000
        Me.dgvUsers.Height = 500
        Me.dgvUsers.BackgroundColor = Color.White
        Me.dgvUsers.BorderStyle = BorderStyle.None
        Me.dgvUsers.EnableHeadersVisualStyles = False
        Me.dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(180, 225, 250)
        Me.dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 30)
        Me.dgvUsers.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.dgvUsers.RowTemplate.Height = 40
        Me.dgvUsers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 240, 255)
        Me.dgvUsers.DefaultCellStyle.SelectionForeColor = Color.Black
        '
        ' Usermngmtfrm
        '
        Me.ClientSize = New Size(1200, 700)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.dgvUsers)
        Me.Text = "User Management"
        Me.WindowState = FormWindowState.Maximized
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
End Class
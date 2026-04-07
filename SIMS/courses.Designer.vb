<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class courses
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
    Private lblHeader As Label
    Private lblSearch As Label
    Private txtSearch As TextBox
    Private dgvCourses As DataGridView
    Private lblCourseID As Label
    Private lblCourseName As Label
    Private txtCourseID As TextBox
    Private txtCourseName As TextBox
    Private btnAdd As Button
    Private btnEdit As Button
    Private btnDelete As Button
    Private btnClear As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblHeader = New Label()
        Me.lblSearch = New Label()
        Me.txtSearch = New TextBox()
        Me.dgvCourses = New DataGridView()
        Me.lblCourseID = New Label()
        Me.lblCourseName = New Label()
        Me.txtCourseID = New TextBox()
        Me.txtCourseName = New TextBox()
        Me.btnAdd = New Button()
        Me.btnEdit = New Button()
        Me.btnDelete = New Button()
        Me.btnClear = New Button()
        CType(Me.dgvCourses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' lblHeader
        '
        Me.lblHeader.Top = 10
        Me.lblHeader.Left = 10
        Me.lblHeader.Width = 1000
        Me.lblHeader.Height = 40
        Me.lblHeader.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        Me.lblHeader.Text = "Courses Management"
        Me.lblHeader.TextAlign = ContentAlignment.MiddleLeft
        '
        ' lblSearch
        '
        Me.lblSearch.Top = 60
        Me.lblSearch.Left = 10
        Me.lblSearch.Width = 120
        Me.lblSearch.Height = 25
        Me.lblSearch.Font = New Font("Segoe UI", 10)
        Me.lblSearch.Text = "Search Courses:"
        '
        ' txtSearch
        '
        Me.txtSearch.Top = 60
        Me.txtSearch.Left = 135
        Me.txtSearch.Width = 250
        Me.txtSearch.Height = 25
        Me.txtSearch.Font = New Font("Segoe UI", 10)
        '
        ' lblCourseID
        '
        Me.lblCourseID.Top = 100
        Me.lblCourseID.Left = 10
        Me.lblCourseID.Width = 100
        Me.lblCourseID.Height = 25
        Me.lblCourseID.Font = New Font("Segoe UI", 10)
        Me.lblCourseID.Text = "Course ID:"
        '
        ' txtCourseID
        '
        Me.txtCourseID.Top = 100
        Me.txtCourseID.Left = 120
        Me.txtCourseID.Width = 200
        Me.txtCourseID.Height = 25
        Me.txtCourseID.Font = New Font("Segoe UI", 10)
        '
        ' lblCourseName
        '
        Me.lblCourseName.Top = 140
        Me.lblCourseName.Left = 10
        Me.lblCourseName.Width = 100
        Me.lblCourseName.Height = 25
        Me.lblCourseName.Font = New Font("Segoe UI", 10)
        Me.lblCourseName.Text = "Course Name:"
        '
        ' txtCourseName
        '
        Me.txtCourseName.Top = 140
        Me.txtCourseName.Left = 120
        Me.txtCourseName.Width = 200
        Me.txtCourseName.Height = 25
        Me.txtCourseName.Font = New Font("Segoe UI", 10)
        '
        ' dgvCourses
        '
        Me.dgvCourses.Top = 180
        Me.dgvCourses.Left = 10
        Me.dgvCourses.Width = 760
        Me.dgvCourses.Height = 250
        Me.dgvCourses.BackgroundColor = Color.White
        Me.dgvCourses.BorderStyle = BorderStyle.None
        Me.dgvCourses.EnableHeadersVisualStyles = False
        Me.dgvCourses.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(180, 225, 250)
        Me.dgvCourses.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 30)
        Me.dgvCourses.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.dgvCourses.RowTemplate.Height = 40
        Me.dgvCourses.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 240, 255)
        Me.dgvCourses.DefaultCellStyle.SelectionForeColor = Color.Black
        Me.dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCourses.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Me.dgvCourses.ReadOnly = True
        Me.dgvCourses.MultiSelect = False
        Me.dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        '
        ' btnAdd
        '
        Me.btnAdd.Top = 440
        Me.btnAdd.Left = 10
        Me.btnAdd.Width = 90
        Me.btnAdd.Height = 35
        Me.btnAdd.Text = "Add"
        Me.btnAdd.BackColor = Color.FromArgb(100, 180, 250)
        Me.btnAdd.ForeColor = Color.White
        Me.btnAdd.FlatStyle = FlatStyle.Flat
        Me.btnAdd.FlatAppearance.BorderSize = 0
        '
        ' btnEdit
        '
        Me.btnEdit.Top = 440
        Me.btnEdit.Left = 110
        Me.btnEdit.Width = 90
        Me.btnEdit.Height = 35
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.BackColor = Color.FromArgb(100, 180, 250)
        Me.btnEdit.ForeColor = Color.White
        Me.btnEdit.FlatStyle = FlatStyle.Flat
        Me.btnEdit.FlatAppearance.BorderSize = 0
        '
        ' btnDelete
        '
        Me.btnDelete.Top = 440
        Me.btnDelete.Left = 210
        Me.btnDelete.Width = 90
        Me.btnDelete.Height = 35
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.BackColor = Color.FromArgb(100, 180, 250)
        Me.btnDelete.ForeColor = Color.White
        Me.btnDelete.FlatStyle = FlatStyle.Flat
        Me.btnDelete.FlatAppearance.BorderSize = 0
        '
        ' btnClear
        '
        Me.btnClear.Top = 440
        Me.btnClear.Left = 310
        Me.btnClear.Width = 90
        Me.btnClear.Height = 35
        Me.btnClear.Text = "Clear"
        Me.btnClear.BackColor = Color.FromArgb(100, 180, 250)
        Me.btnClear.ForeColor = Color.White
        Me.btnClear.FlatStyle = FlatStyle.Flat
        Me.btnClear.FlatAppearance.BorderSize = 0
        '
        ' courses
        '
        Me.ClientSize = New Size(800, 500)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblCourseID)
        Me.Controls.Add(Me.txtCourseID)
        Me.Controls.Add(Me.lblCourseName)
        Me.Controls.Add(Me.txtCourseName)
        Me.Controls.Add(Me.dgvCourses)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Text = "Courses Management"
        Me.WindowState = FormWindowState.Maximized
        CType(Me.dgvCourses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
End Class
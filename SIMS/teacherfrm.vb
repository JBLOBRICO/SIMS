Public Class teacherfrm
    ' Variable para subaybayan ang kasalukuyang active form
    Private currentChildForm As Form = Nothing

    ''' <summary>
    ''' Load Event: Dito natin itatakda ang dashboardteacher bilang default.
    ''' </summary>
    Private Sub teacherfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Pagkabukas ng portal, i-load agad ang dashboard module
        OpenChildForm(New dashboardteacher())
        lblHeader.Text = "Teacher Dashboard / Home"
    End Sub

    ''' <summary>
    ''' Function para sa pagpapalit-palit ng form sa loob ng pnlMain.
    ''' </summary>
    Private Sub OpenChildForm(childForm As Form)
        ' 1. Isara muna ang lumang form para iwas overlap at memory leak
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
            currentChildForm.Dispose()
        End If

        ' 2. Linisin ang pnlMain (Siguradong tanggal ang Welcome label dito)
        Me.pnlMain.Controls.Clear()

        ' 3. I-configure ang bagong form
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        ' 4. I-display sa main panel
        Me.pnlMain.Controls.Add(childForm)
        Me.pnlMain.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    ' --- Sidebar Navigation ---

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ' Kahit i-click ulit, ire-refresh nito ang dashboardteacher
        OpenChildForm(New dashboardteacher())
        lblHeader.Text = "Teacher Dashboard / Home"
    End Sub

    Private Sub btnGradeEntry_Click(sender As Object, e As EventArgs) Handles btnGradeEntry.Click
        OpenChildForm(New gradeentryform())
        lblHeader.Text = "Teacher Dashboard / Grade Entry"
    End Sub

    Private Sub btnGradeList_Click(sender As Object, e As EventArgs) Handles btnGradeList.Click
        OpenChildForm(New gradeslistfrm())
        lblHeader.Text = "Teacher Dashboard / Master Grades List"
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim res = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = DialogResult.Yes Then
            loginfrm.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub btnAnnouncements_Click(sender As Object, e As EventArgs) Handles btnAnnouncements.Click
        OpenChildForm(New announcementform())
        lblHeader.Text = "Teacher Dashboard / Master Grades List"
    End Sub
End Class
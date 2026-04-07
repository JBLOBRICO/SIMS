Public Class registrarfrm

    ' 1. INITIALIZATION: Pag-link ng buttons sa code
    Private Sub registrarfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' AddHandler setup para sa malinis na event management
        AddHandler btnDashboard.Click, AddressOf btnDashboard_Click
        AddHandler btnStudentInfo.Click, AddressOf btnStudentInforeg_Click
        AddHandler btnEnrollment.Click, AddressOf btnEnrollment_Click
        AddHandler btnEnrollmentList.Click, AddressOf btnEnrollmentList_Click
        AddHandler btnEnrollmentReview.Click, AddressOf btnEnrollmentReview_Click
        AddHandler btnCourseList.Click, AddressOf btnCourseList_Click
        AddHandler btnSubjectList.Click, AddressOf btnSubjectList_Click
        AddHandler btnScheduleList.Click, AddressOf btnScheduleList_Click
        AddHandler btnLogout.Click, AddressOf btnLogout_Click
    End Sub

    ' 2. THE ENGINE: Ang tagapalt ng mga forms sa loob ng pnlMain
    Private Sub OpenRegistrarChild(ByVal childForm As Form)
        ' STEP A: Linisin ang panel at i-dispose ang lumang form
        ' Gumagamit tayo ng ToArray() para maiwasan ang error habang nagbabago ang collection
        For Each ctrl As Control In pnlMain.Controls.Cast(Of Control)().ToArray()
            If TypeOf ctrl Is Form Then
                Dim oldForm As Form = DirectCast(ctrl, Form)
                oldForm.Close()
                oldForm.Dispose()
            Else
                ' Itago ang ibang controls gaya ng lblWelcome sa halip na i-delete
                ctrl.Visible = False
            End If
        Next

        ' Siguraduhin na tanggal lahat ng controls na Form type
        pnlMain.Controls.Clear()

        ' STEP B: I-setup ang bagong form
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        ' STEP C: Ilagay sa panel at ipakita
        pnlMain.Controls.Add(childForm)
        pnlMain.Tag = childForm
        childForm.Show()

        ' Update ang Header text
        lblHeader.Text = "Registrar - " & childForm.Text
    End Sub

    ' 3. BUTTON ACTIONS

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs)
        ' Linisin ang panel mula sa anumang nakabukas na child form
        For Each ctrl As Control In pnlMain.Controls.Cast(Of Control)().ToArray()
            If TypeOf ctrl Is Form Then
                DirectCast(ctrl, Form).Close()
                DirectCast(ctrl, Form).Dispose()
            End If
        Next

        pnlMain.Controls.Clear()

        ' Ibalik ang Welcome Label at gawing visible
        pnlMain.Controls.Add(lblWelcome)
        lblWelcome.Visible = True
        lblWelcome.Dock = DockStyle.Fill

        lblHeader.Text = "Registrar Dashboard"
    End Sub

    Private Sub btnStudentInforeg_Click(sender As Object, e As EventArgs)
        OpenRegistrarChild(New Studentinforeg())
    End Sub

    Private Sub btnEnrollment_Click(sender As Object, e As EventArgs)
        OpenRegistrarChild(New enrollmentfrm())
    End Sub

    Private Sub btnEnrollmentList_Click(sender As Object, e As EventArgs)
        OpenRegistrarChild(New enrollmentslist())
    End Sub

    Private Sub btnEnrollmentReview_Click(sender As Object, e As EventArgs)
        OpenRegistrarChild(New enrollmentreview())
    End Sub

    Private Sub btnCourseList_Click(sender As Object, e As EventArgs)
        OpenRegistrarChild(New courselist())
    End Sub

    Private Sub btnSubjectList_Click(sender As Object, e As EventArgs)
        OpenRegistrarChild(New subjectlist())
    End Sub

    Private Sub btnScheduleList_Click(sender As Object, e As EventArgs)
        OpenRegistrarChild(New ScheduleFrm())
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            loginfrm.Show()
            Me.Close() ' Mas mainam ang Close() kaysa Dispose() para sa main forms para ma-trigger ang FormClosing events
        End If
    End Sub

End Class
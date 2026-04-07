Imports MySql.Data.MySqlClient

Public Class enrollmentreview
    ' This variable must be set by the calling form (enrollmentlist)
    Public SelectedEnrollID As Integer

    Private Sub enrollmentreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SelectedEnrollID > 0 Then
            LoadEnrollmentHeader()
            LoadSubjectDetails()
        Else
            MsgBox("No enrollment record selected.", MsgBoxStyle.Exclamation)
            Me.Close()
        End If
    End Sub

    ' 1. Fetch Student and Course Summary
    Private Sub LoadEnrollmentHeader()
        Try
            openConn()
            ' Joins enrollments with students and courses for a complete header
            Dim query As String = "SELECT CONCAT(s.last_name, ', ', s.first_name) as fullname, " &
                                 "c.course_name, e.school_year, e.semester, e.status " &
                                 "FROM enrollments e " &
                                 "JOIN students s ON e.student_id = s.student_id " &
                                 "JOIN courses c ON e.course_id = c.course_id " &
                                 "WHERE e.enrollment_id = @eid"

            Dim mysqlCmd As MySqlCommand = cmd(query)
            mysqlCmd.Parameters.AddWithValue("@eid", SelectedEnrollID)

            dr = mysqlCmd.ExecuteReader()
            If dr.Read() Then
                lblStudentName.Text = "STUDENT: " & dr("fullname").ToString().ToUpper()
                lblCourseInfo.Text = String.Format("COURSE: {0}  |  S.Y. {1}  |  {2}",
                                     dr("course_name"), dr("school_year"), dr("semester"))
                lblStatus.Text = "STATUS: " & dr("status").ToString().ToUpper()

                ' Visual cue for status
                If dr("status").ToString().ToLower() = "enrolled" Then
                    lblStatus.ForeColor = Color.Green
                Else
                    lblStatus.ForeColor = Color.Red
                End If
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Header Error: " & ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    ' 2. Fetch the List of Subjects for this specific Enrollment
    Private Sub LoadSubjectDetails()
        Try
            openConn()
            ' Joins enrollment_details with schedules and subjects
            Dim query As String = "SELECT sub.subject_code AS 'Code', " &
                                 "sub.subject_title AS 'Subject Title', " &
                                 "sub.units AS 'Units', " &
                                 "sch.section AS 'Section', " &
                                 "sch.days AS 'Schedule', " &
                                 "TIME_FORMAT(sch.time_start, '%h:%i %p') AS 'Starts', " &
                                 "TIME_FORMAT(sch.time_end, '%h:%i %p') AS 'Ends' " &
                                 "FROM enrollment_details ed " &
                                 "JOIN schedules sch ON ed.schedule_id = sch.schedule_id " &
                                 "JOIN subjects sub ON sch.subject_id = sub.subject_id " &
                                 "WHERE ed.enrollment_id = @eid"

            Dim mysqlCmd As MySqlCommand = cmd(query)
            mysqlCmd.Parameters.AddWithValue("@eid", SelectedEnrollID)

            Dim da As New MySqlDataAdapter(mysqlCmd)
            Dim dt As New DataTable
            da.Fill(dt)
            dgvDetails.DataSource = dt

            ' Calculate Total Units dynamically from the grid
            Dim totalUnits As Integer = 0
            For Each row As DataRow In dt.Rows
                totalUnits += Convert.ToInt32(row("Units"))
            Next
            lblTotalUnits.Text = "TOTAL UNITS: " & totalUnits

        Catch ex As Exception
            MsgBox("Subject List Error: " & ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
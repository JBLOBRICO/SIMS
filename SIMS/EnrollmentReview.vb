Imports MySql.Data.MySqlClient

Public Class enrollmentreview
    ' Variable set by the calling form
    Public SelectedEnrollID As Integer

    Private Sub enrollmentreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' FIX: Check if the ID is valid before proceeding
        If SelectedEnrollID > 0 Then
            LoadEnrollmentHeader()
            LoadSubjectDetails()
        Else
            MsgBox("No enrollment record selected.", MsgBoxStyle.Exclamation)

            ' DO NOT USE Me.Close() HERE. 
            ' Instead, we just stop the data loading and show an empty state.
            lblStudentName.Text = "STUDENT: NO RECORD SELECTED"
            lblStatus.Text = "STATUS: N/A"
            lblStatus.ForeColor = Color.Gray
            Return
        End If
    End Sub

    ' 1. Fetch Student and Course Summary
    Private Sub LoadEnrollmentHeader()
        Try
            openConn()
            Dim query As String = "SELECT CONCAT(s.last_name, ', ', s.first_name) as fullname, " &
                                 "c.course_name, e.school_year, e.semester, e.status " &
                                 "FROM enrollments e " &
                                 "JOIN students s ON e.student_id = s.student_id " &
                                 "JOIN courses c ON e.course_id = c.course_id " &
                                 "WHERE e.enrollment_id = @eid"

            ' Assuming cmd() is your global helper function
            Dim mysqlCmd As MySqlCommand = cmd(query)
            mysqlCmd.Parameters.AddWithValue("@eid", SelectedEnrollID)

            ' Assuming dr is your global MySqlDataReader
            dr = mysqlCmd.ExecuteReader()
            If dr.Read() Then
                lblStudentName.Text = "STUDENT: " & dr("fullname").ToString().ToUpper()
                lblCourseInfo.Text = String.Format("COURSE: {0}  |  S.Y. {1}  |  {2}",
                                     dr("course_name"), dr("school_year"), dr("semester"))
                lblStatus.Text = "STATUS: " & dr("status").ToString().ToUpper()

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

    ' 2. Fetch the List of Subjects
    Private Sub LoadSubjectDetails()
        Try
            openConn()
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

            ' Calculate Total Units
            Dim totalUnits As Integer = 0
            For Each row As DataRow In dt.Rows
                ' Added a safety check for null/DBNull
                If Not IsDBNull(row("Units")) Then
                    totalUnits += Convert.ToInt32(row("Units"))
                End If
            Next
            lblTotalUnits.Text = "TOTAL UNITS: " & totalUnits

        Catch ex As Exception
            MsgBox("Subject List Error: " & ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' This is fine here because it's triggered by a user click, not during Load
        Me.Close()
    End Sub
End Class
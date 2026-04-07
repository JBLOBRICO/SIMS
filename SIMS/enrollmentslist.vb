Imports MySql.Data.MySqlClient

Public Class enrollmentslist

    Private Sub enrollmentslist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEnrollmentRecords()
    End Sub

    ' Main function para i-load ang data
    Public Sub LoadEnrollmentRecords(Optional searchTerm As String = "")
        Try
            openConn()

            ' SQL Query with JOINs para readable ang list
            Dim query As String = "SELECT e.enrollment_id AS 'ID', " &
                                 "e.student_id AS 'Student ID', " &
                                 "CONCAT(s.last_name, ', ', s.first_name) AS 'Student Name', " &
                                 "c.course_name AS 'Course', " &
                                 "e.school_year AS 'S.Y.', " &
                                 "e.semester AS 'Sem', " &
                                 "e.status AS 'Status' " &
                                 "FROM enrollments e " &
                                 "JOIN students s ON e.student_id = s.student_id " &
                                 "JOIN courses c ON e.course_id = c.course_id "

            ' Dagdag na filter kung may sine-search
            If Not String.IsNullOrWhiteSpace(searchTerm) Then
                query &= " WHERE s.last_name LIKE @search OR s.first_name LIKE @search OR e.student_id LIKE @search"
            End If

            query &= " ORDER BY e.enrollment_id DESC"

            Dim mysqlCmd As MySqlCommand = cmd(query)
            mysqlCmd.Parameters.AddWithValue("@search", "%" & searchTerm & "%")

            Dim da As New MySqlDataAdapter(mysqlCmd)
            Dim dt As New DataTable
            da.Fill(dt)

            dgvEnrollments.DataSource = dt

        Catch ex As Exception
            MsgBox("Error loading list: " & ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    ' Auto-search habang nagta-type
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadEnrollmentRecords(txtSearch.Text.Trim())
    End Sub

End Class
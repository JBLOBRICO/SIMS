Imports MySql.Data.MySqlClient

Public Class enrollmentfrm

    Private Sub enrollmentfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the form data
        LoadStudents()
        LoadCourses()
        LoadSchedules()
    End Sub

    ' --- FETCH DATA FROM DB ---

    Private Sub LoadStudents()
        Try
            openConn()
            Dim da As New MySqlDataAdapter(cmd("SELECT student_id, CONCAT(last_name, ', ', first_name) AS name FROM students"))
            Dim dt As New DataTable
            da.Fill(dt)
            cmbStudent.DataSource = dt
            cmbStudent.DisplayMember = "name"
            cmbStudent.ValueMember = "student_id"
        Catch ex As Exception
            MsgBox("Error loading students: " & ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub LoadCourses()
        Try
            openConn()
            Dim da As New MySqlDataAdapter(cmd("SELECT course_id, course_name FROM courses"))
            Dim dt As New DataTable
            da.Fill(dt)
            cmbCourse.DataSource = dt
            cmbCourse.DisplayMember = "course_name"
            cmbCourse.ValueMember = "course_id"
        Catch ex As Exception
            MsgBox("Error loading courses: " & ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub LoadSchedules()
        Try
            openConn()
            ' Join schedules with subjects to show the actual title and units
            Dim query As String = "SELECT s.schedule_id, b.subject_code, b.subject_title, b.units, s.section, s.days, s.time_start, s.time_end " &
                                 "FROM schedules s JOIN subjects b ON s.subject_id = b.subject_id"
            Dim da As New MySqlDataAdapter(cmd(query))
            Dim dt As New DataTable
            da.Fill(dt)
            dgvSchedules.DataSource = dt

            ' Ensure the checkbox column exists if not done in designer
            If dgvSchedules.Columns("select_col") Is Nothing Then
                Dim chk As New DataGridViewCheckBoxColumn()
                chk.Name = "select_col"
                chk.HeaderText = "Select"
                dgvSchedules.Columns.Insert(0, chk)
            End If
        Catch ex As Exception
            MsgBox("Error loading schedules: " & ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    ' --- SAVE ENROLLMENT TRANSACTION ---

    Private Sub btnConfirmEnroll_Click(sender As Object, e As EventArgs) Handles btnConfirmEnroll.Click
        ' 1. Basic Validation
        If cmbStudent.SelectedIndex = -1 Or cmbCourse.SelectedIndex = -1 Then
            MsgBox("Please select a Student and a Course.")
            Exit Sub
        End If

        Try
            openConn()
            Dim checkQuery As String = "SELECT COUNT(*) FROM enrollments WHERE student_id = @sid AND school_year = @sy AND semester = @sem"
            Dim checkCmd As MySqlCommand = cmd(checkQuery)
            checkCmd.Parameters.AddWithValue("@sid", cmbStudent.SelectedValue)
            checkCmd.Parameters.AddWithValue("@sy", txtSchoolYear.Text)
            checkCmd.Parameters.AddWithValue("@sem", cmbSemester.Text)

            Dim existingCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If existingCount > 0 Then
                MsgBox("This student is already enrolled for the selected school year and semester.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim transaction As MySqlTransaction = conn.BeginTransaction()

            ' 2. Insert into 'enrollments'
            Dim enrollQuery As String = "INSERT INTO enrollments (student_id, course_id, school_year, semester, enrollment_date, status) " &
                                       "VALUES (@sid, @cid, @sy, @sem, CURDATE(), 'enrolled'); SELECT LAST_INSERT_ID();"

            Dim enrollCmd As MySqlCommand = cmd(enrollQuery)
            enrollCmd.Transaction = transaction
            enrollCmd.Parameters.AddWithValue("@sid", cmbStudent.SelectedValue)
            enrollCmd.Parameters.AddWithValue("@cid", cmbCourse.SelectedValue)
            enrollCmd.Parameters.AddWithValue("@sy", txtSchoolYear.Text)
            enrollCmd.Parameters.AddWithValue("@sem", cmbSemester.Text)

            ' Get the new enrollment_id
            Dim newEnrollID As Integer = Convert.ToInt32(enrollCmd.ExecuteScalar())

            ' 3. Loop through DataGridView to save 'enrollment_details' and calculate tuition
            Dim totalUnits As Integer = 0
            Dim subjectCount As Integer = 0

            For Each row As DataGridViewRow In dgvSchedules.Rows
                If Convert.ToBoolean(row.Cells("select_col").Value) = True Then
                    ' Save Subject Detail
                    Dim detailQuery As String = "INSERT INTO enrollment_details (enrollment_id, schedule_id) VALUES (@eid, @sid)"
                    Dim detailCmd As MySqlCommand = cmd(detailQuery)
                    detailCmd.Transaction = transaction
                    detailCmd.Parameters.AddWithValue("@eid", newEnrollID)
                    detailCmd.Parameters.AddWithValue("@sid", row.Cells("schedule_id").Value)
                    detailCmd.ExecuteNonQuery()

                    totalUnits += Convert.ToInt32(row.Cells("units").Value)
                    subjectCount += 1
                End If
            Next

            If subjectCount = 0 Then
                MsgBox("No subjects selected. Enrollment cancelled.")
                transaction.Rollback()
                Exit Sub
            End If

            ' 4. Create Billing record (Example: 500 pesos per unit)
            Dim tuitionPerUnit As Decimal = 500.0
            Dim totalAmount As Decimal = totalUnits * tuitionPerUnit

            Dim billQuery As String = "INSERT INTO billing (enrollment_id, total_amount, paid_amount, due_date) " &
                                     "VALUES (@eid, @amt, 0.00, DATE_ADD(CURDATE(), INTERVAL 30 DAY))"
            Dim billCmd As MySqlCommand = cmd(billQuery)
            billCmd.Transaction = transaction
            billCmd.Parameters.AddWithValue("@eid", newEnrollID)
            billCmd.Parameters.AddWithValue("@amt", totalAmount)
            billCmd.ExecuteNonQuery()

            ' Finalize the entire process
            transaction.Commit()
            MsgBox("Enrollment Successful! Total Units: " & totalUnits & " | Total Bill: ₱" & totalAmount.ToString("N2"))
            Me.Close()

        Catch ex As Exception
            MsgBox("Enrollment failed. Database error: " & ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

End Class
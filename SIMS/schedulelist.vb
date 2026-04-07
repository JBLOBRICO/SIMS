Imports MySql.Data.MySqlClient

Public Class schedulelist
    ' Dictionary to map Subject Titles to their IDs for database insertion
    Private subjectDict As New Dictionary(Of String, Integer)

    Private Sub schedulelist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubjects()
        DisplaySchedules()
    End Sub

    ' --- DATABASE LOGIC: LOAD SUBJECTS INTO COMBOBOX ---
    Private Sub LoadSubjects()
        Try
            openConn()
            Using cmdSubj As New MySqlCommand("SELECT subject_id, subject_title FROM subjects", conn)
                dr = cmdSubj.ExecuteReader()
                cmbSubjects.Items.Clear()
                subjectDict.Clear()

                While dr.Read()
                    Dim id As Integer = dr.GetInt32("subject_id")
                    Dim title As String = dr.GetString("subject_title")

                    cmbSubjects.Items.Add(title)
                    subjectDict.Add(title, id) ' Store the ID for later
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading subjects: " & ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    ' --- DATABASE LOGIC: DISPLAY SCHEDULES IN GRID ---
    Private Sub DisplaySchedules()
        Try
            openConn()
            ' INNER JOIN allows us to show the subject title from the subjects table
            Dim query As String = "SELECT s.schedule_id, b.subject_title, s.section, s.days, " &
                                 "TIME_FORMAT(s.time_start, '%h:%i %p') as 'Start', " &
                                 "TIME_FORMAT(s.time_end, '%h:%i %p') as 'End', s.room " &
                                 "FROM schedules s " &
                                 "INNER JOIN subjects b ON s.subject_id = b.subject_id"

            Using cmdSched As New MySqlCommand(query, conn)
                Dim dt As New DataTable()
                Using adapter As New MySqlDataAdapter(cmdSched)
                    adapter.Fill(dt)
                    dgvSchedules.DataSource = dt
                End Using
            End Using

            ' Hide the ID column but keep it in the data for deletion
            If dgvSchedules.Columns.Contains("schedule_id") Then
                dgvSchedules.Columns("schedule_id").Visible = False
            End If

            ' Web-like Fill: Stretch the Title and Section columns
            dgvSchedules.Columns("subject_title").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Catch ex As Exception
            MessageBox.Show("Error displaying schedules: " & ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    ' --- DATABASE LOGIC: SAVE NEW SCHEDULE ---
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Simple Validation
        If cmbSubjects.SelectedIndex = -1 Or String.IsNullOrWhiteSpace(txtSection.Text) Then
            MessageBox.Show("Please select a subject and enter a section.")
            Return
        End If

        Try
            openConn()
            Dim query As String = "INSERT INTO schedules (subject_id, section, days, time_start, time_end, room) " &
                                 "VALUES (@sid, @sec, @days, @tstart, @tend, @room)"

            Using cmdSave As New MySqlCommand(query, conn)
                ' Parameters prevent SQL Injection
                cmdSave.Parameters.AddWithValue("@sid", subjectDict(cmbSubjects.SelectedItem.ToString()))
                cmdSave.Parameters.AddWithValue("@sec", txtSection.Text)
                cmdSave.Parameters.AddWithValue("@days", txtDays.Text)
                cmdSave.Parameters.AddWithValue("@tstart", dtpStart.Value.ToString("HH:mm:ss"))
                cmdSave.Parameters.AddWithValue("@tend", dtpEnd.Value.ToString("HH:mm:ss"))
                cmdSave.Parameters.AddWithValue("@room", txtRoom.Text)

                cmdSave.ExecuteNonQuery()
                MessageBox.Show("Schedule saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

            ' Refresh UI
            ClearInputs()
            DisplaySchedules()

        Catch ex As Exception
            MessageBox.Show("Failed to save: " & ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    ' --- DATABASE LOGIC: DELETE SELECTED SCHEDULE ---
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvSchedules.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a schedule to delete.")
            Return
        End If

        ' Confirm before delete (Standard Web Behavior)
        Dim res = MessageBox.Show("Are you sure you want to delete this schedule?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res <> DialogResult.Yes Then Return

        Try
            Dim scheduleId As Integer = Convert.ToInt32(dgvSchedules.SelectedRows(0).Cells("schedule_id").Value)

            openConn()
            Using cmdDel As New MySqlCommand("DELETE FROM schedules WHERE schedule_id = @id", conn)
                cmdDel.Parameters.AddWithValue("@id", scheduleId)
                cmdDel.ExecuteNonQuery()
            End Using

            DisplaySchedules() ' Refresh the grid

        Catch ex As Exception
            MessageBox.Show("Error deleting record: " & ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub ClearInputs()
        cmbSubjects.SelectedIndex = -1
        txtSection.Clear()
        txtDays.Clear()
        txtRoom.Clear()
        dtpStart.Value = DateTime.Now
        dtpEnd.Value = DateTime.Now
    End Sub

End Class
Imports MySql.Data.MySqlClient

Public Class subjectlist
    ' Magsisilbing indicator kung NEW record (0) o UPDATE (>0)
    Dim selectedID As Integer = 0

    Private Sub subjectlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubjects()
    End Sub

    ' 1. READ: Hatakin ang lahat ng subjects mula sa DB
    Private Sub LoadSubjects()
        Try
            openConn()
            ' Ang query ay naka-align sa columns ng subjects table mo
            Dim query As String = "SELECT subject_id AS 'ID', subject_code AS 'Code', " &
                                 "subject_title AS 'Title', units AS 'Units' " &
                                 "FROM subjects ORDER BY subject_code ASC"

            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            dgvSubjects.DataSource = dt

            ' Itago ang primary key (ID) para hindi magulo sa user
            If dgvSubjects.Columns.Contains("ID") Then
                dgvSubjects.Columns("ID").Visible = False
            End If
        Catch ex As Exception
            MsgBox("Error loading subjects: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            closeConn()
        End Try
    End Sub

    ' 2. CREATE & UPDATE: Isang logic para sa pag-save
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Basic Validation
        If String.IsNullOrWhiteSpace(txtCode.Text) Or String.IsNullOrWhiteSpace(txtTitle.Text) Then
            MsgBox("Please provide both Subject Code and Title.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            openConn()
            Dim query As String = ""

            If selectedID = 0 Then
                ' Mode: Add New
                query = "INSERT INTO subjects (subject_code, subject_title, units) " &
                        "VALUES (@code, @title, @units)"
            Else
                ' Mode: Update Existing
                query = "UPDATE subjects SET subject_code=@code, subject_title=@title, " &
                        "units=@units WHERE subject_id=@id"
            End If

            Dim mysqlCmd As MySqlCommand = cmd(query)
            mysqlCmd.Parameters.AddWithValue("@code", txtCode.Text.Trim())
            mysqlCmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim())
            mysqlCmd.Parameters.AddWithValue("@units", numUnits.Value)

            If selectedID <> 0 Then
                mysqlCmd.Parameters.AddWithValue("@id", selectedID)
            End If

            mysqlCmd.ExecuteNonQuery()
            MsgBox("Subject successfully saved!", MsgBoxStyle.Information)

            ClearFields()
            LoadSubjects()
        Catch ex As Exception
            ' Maaring mag-error dito kung ang subject_code ay duplicate (Unique Constraint)
            MsgBox("Error saving subject: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            closeConn()
        End Try
    End Sub

    ' 3. DELETE: Pagtanggal ng subject
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedID = 0 Then
            MsgBox("Please select a subject to delete.", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim result As DialogResult = MsgBox("Are you sure you want to delete this subject?",
                                          MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        If result = DialogResult.Yes Then
            Try
                openConn()
                Dim mysqlCmd As MySqlCommand = cmd("DELETE FROM subjects WHERE subject_id=@id")
                mysqlCmd.Parameters.AddWithValue("@id", selectedID)
                mysqlCmd.ExecuteNonQuery()

                MsgBox("Subject deleted.", MsgBoxStyle.Information)
                ClearFields()
                LoadSubjects()
            Catch ex As Exception
                ' Error handling para sa Foreign Key constraints (e.g., used in schedules)
                MsgBox("Cannot delete subject. It might be linked to existing schedules or grades.", MsgBoxStyle.Critical)
            Finally
                closeConn()
            End Try
        End If
    End Sub

    ' 4. SELECTION: Pag-load ng data mula grid pabalik sa inputs
    Private Sub dgvSubjects_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubjects.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSubjects.Rows(e.RowIndex)

            selectedID = Convert.ToInt32(row.Cells("ID").Value)
            txtCode.Text = row.Cells("Code").Value.ToString()
            txtTitle.Text = row.Cells("Title").Value.ToString()
            numUnits.Value = Convert.ToDecimal(row.Cells("Units").Value)

            btnSave.Text = "Update Subject"
        End If
    End Sub

    ' 5. HELPERS: Form Reset
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        selectedID = 0
        txtCode.Clear()
        txtTitle.Clear()
        numUnits.Value = 3 ' Default units
        btnSave.Text = "Save Subject"
        txtCode.Focus()
    End Sub
End Class
Imports MySql.Data.MySqlClient

Public Class addnewstudent

    ' 1. Clear fields when the form loads
    Private Sub addnewstudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearFields()
    End Sub

    ' 2. Save Button Logic
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validation: Siguraduhin na may laman ang mga importanteng fields
        If String.IsNullOrWhiteSpace(txtStudentID.Text) OrElse
           String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
           String.IsNullOrWhiteSpace(txtLastName.Text) Then

            MsgBox("Please fill in the Student ID, First Name, and Last Name.", MsgBoxStyle.Exclamation, "Required Fields")
            Exit Sub
        End If

        Try
            ' Buksan ang connection gamit ang iyong module
            openConn()

            ' SQL Query base sa schema ng 'students' table mo
            ' Note: Ang user_id ay NULL muna dahil wala pa tayong account creation dito
            Dim query As String = "INSERT INTO students (student_id, first_name, last_name, email, birthdate, address) " &
                                 "VALUES (@sid, @fname, @lname, @email, @bday, @addr)"

            Dim mysqlCmd As MySqlCommand = cmd(query)

            ' I-bind ang mga values mula sa UI
            mysqlCmd.Parameters.AddWithValue("@sid", txtStudentID.Text.Trim())
            mysqlCmd.Parameters.AddWithValue("@fname", txtFirstName.Text.Trim())
            mysqlCmd.Parameters.AddWithValue("@lname", txtLastName.Text.Trim())
            mysqlCmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
            mysqlCmd.Parameters.AddWithValue("@bday", dtpBirthdate.Value.ToString("yyyy-MM-dd"))
            mysqlCmd.Parameters.AddWithValue("@addr", txtAddress.Text.Trim())

            ' I-execute ang insert
            mysqlCmd.ExecuteNonQuery()

            MsgBox("Student successfully registered!", MsgBoxStyle.Information, "Success")

            ' I-refresh ang DataGridView sa main form kung ito ay nakabukas
            If Application.OpenForms().OfType(Of Studentinforeg).Any Then
                Studentinforeg.LoadStudentData()
            End If

            Me.Close() ' Isara ang form pagkatapos mag-save

        Catch ex As MySqlException When ex.Number = 1062
            MsgBox("Error: Student ID or Email already exists in the database.", MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            closeConn()
        End Try
    End Sub

    ' 3. Cancel Button Logic
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ' Helper method para linisin ang form
    Private Sub ClearFields()
        txtStudentID.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtEmail.Clear()
        txtAddress.Clear()
        dtpBirthdate.Value = DateTime.Now
    End Sub

End Class
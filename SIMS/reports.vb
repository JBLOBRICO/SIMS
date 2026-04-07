Imports MySql.Data.MySqlClient

Public Class reports

    Private Sub reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbReportType.SelectedIndex = 0
        RefreshMetrics()
    End Sub

    ' Update the Dashboard Totals
    Private Sub RefreshMetrics()
        Try
            openConn()

            ' Sum of all payments made
            Dim cmdCol As New MySqlCommand("SELECT SUM(amount_paid) FROM payments", conn)
            Dim totalCol = cmdCol.ExecuteScalar()
            lblTotalCollections.Text = "Total Collected: ₱ " & If(IsDBNull(totalCol), "0.00", FormatNumber(totalCol, 2))

            ' Sum of all virtual balances
            Dim cmdBal As New MySqlCommand("SELECT SUM(balance) FROM billing", conn)
            Dim totalBal = cmdBal.ExecuteScalar()
            lblPendingBalance.Text = "Total Receivables: ₱ " & If(IsDBNull(totalBal), "0.00", FormatNumber(totalBal, 2))

        Catch ex As Exception
            MsgBox("Error updating metrics: " & ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    ' Logic to generate different report types
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim sql As String = ""

        Select Case cmbReportType.SelectedIndex
            Case 0 ' Daily Collection
                sql = "SELECT p.payment_date, s.student_id, CONCAT(s.last_name, ', ', s.first_name) as 'Student Name', " &
                      "p.amount_paid as 'Paid Amount', p.reference_no as 'OR Number' " &
                      "FROM payments p " &
                      "JOIN billing b ON p.billing_id = b.billing_id " &
                      "JOIN enrollments e ON b.enrollment_id = e.enrollment_id " &
                      "JOIN students s ON e.student_id = s.student_id " &
                      "ORDER BY p.payment_date DESC"

            Case 1 ' Unpaid Balances
                sql = "SELECT s.student_id, s.last_name, b.total_amount, b.paid_amount, b.balance " &
                      "FROM billing b " &
                      "JOIN enrollments e ON b.enrollment_id = e.enrollment_id " &
                      "JOIN students s ON e.student_id = s.student_id " &
                      "WHERE b.balance > 0"

            Case 2 ' Enrollment by Course
                sql = "SELECT c.course_name, COUNT(e.enrollment_id) as 'Enrolled Students' " &
                      "FROM enrollments e " &
                      "JOIN courses c ON e.course_id = c.course_id " &
                      "GROUP BY c.course_name"
        End Select

        Try
            openConn()
            Dim adapter As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvReportTable.DataSource = dt

            ' Format Currency Columns automatically
            For Each col As DataGridViewColumn In dgvReportTable.Columns
                If col.Name.Contains("amount") Or col.Name.Contains("balance") Then
                    col.DefaultCellStyle.Format = "N2"
                End If
            Next

            RefreshMetrics() ' Update metrics every time a report is run
        Catch ex As Exception
            MsgBox("Query error: " & ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

End Class
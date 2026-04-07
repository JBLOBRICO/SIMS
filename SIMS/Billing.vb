Imports MySql.Data.MySqlClient

Public Class Billing
    ' Variable to store the currently selected Billing ID
    Private selectedBillingID As Integer = 0

    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBillingData()
    End Sub

    ' 1. LOAD DATA: Join billing, enrollments, and students
    Public Sub LoadBillingData(Optional searchKeyword As String = "")
        Try
            openConn()
            Dim query As String = "SELECT b.billing_id, s.student_id, " &
                                 "CONCAT(s.first_name, ' ', s.last_name) AS student_name, " &
                                 "b.total_amount, b.paid_amount, b.balance, b.due_date " &
                                 "FROM billing b " &
                                 "JOIN enrollments e ON b.enrollment_id = e.enrollment_id " &
                                 "JOIN students s ON e.student_id = s.student_id "

            If Not String.IsNullOrEmpty(searchKeyword) Then
                query &= " WHERE s.student_id LIKE @search OR s.last_name LIKE @search"
            End If

            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@search", "%" & searchKeyword & "%")

            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvBilling.DataSource = dt
        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    ' 2. SEARCH FUNCTION
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadBillingData(txtSearch.Text)
    End Sub

    ' 3. SELECTION LOGIC: When user clicks a row in the DataGridView
    Private Sub dgvBilling_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBilling.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvBilling.Rows(e.RowIndex)
            selectedBillingID = Convert.ToInt32(row.Cells("billing_id").Value)
            lblSelectedStudent.Text = "STUDENT: " & row.Cells("student_name").Value.ToString()
            lblBalanceStatus.Text = "BALANCE: ₱ " & FormatNumber(row.Cells("balance").Value, 2)

            ' Clear input for fresh entry
            txtPaymentInput.Clear()
        End If
    End Sub

    ' 4. FULL PAYMENT LOGIC
    Private Sub btnFullPay_Click(sender As Object, e As EventArgs) Handles btnFullPay.Click
        If selectedBillingID = 0 Then
            MsgBox("Please select a student record first.")
            Return
        End If

        Dim currentBalance As Decimal = CDec(dgvBilling.SelectedRows(0).Cells("balance").Value)
        If currentBalance <= 0 Then
            MsgBox("This account is already fully paid.")
            Return
        End If

        txtPaymentInput.Text = currentBalance.ToString("F2")
        ProcessPayment(currentBalance, "Full Payment")
    End Sub

    ' 5. PARTIAL PAYMENT LOGIC
    Private Sub btnPartialPay_Click(sender As Object, e As EventArgs) Handles btnPartialPay.Click
        Dim amount As Decimal
        If Decimal.TryParse(txtPaymentInput.Text, amount) AndAlso amount > 0 Then
            Dim currentBalance As Decimal = CDec(dgvBilling.SelectedRows(0).Cells("balance").Value)

            If amount > currentBalance Then
                MsgBox("Partial payment cannot be greater than the remaining balance!")
                Return
            End If

            ProcessPayment(amount, "Partial Payment")
        Else
            MsgBox("Please enter a valid payment amount.")
        End If
    End Sub

    ' 6. SHARED CORE PROCESSOR: Updates billing and inserts into payments table
    Private Sub ProcessPayment(payAmount As Decimal, type As String)
        Try
            openConn()
            ' Start a Transaction to ensure both tables update or none do
            Dim transaction = conn.BeginTransaction()

            Try
                ' Update Billing Table: Increment paid_amount
                Dim updateQuery As String = "UPDATE billing SET paid_amount = paid_amount + @amt WHERE billing_id = @bid"
                Dim updateCmd = New MySqlCommand(updateQuery, conn, transaction)
                updateCmd.Parameters.AddWithValue("@amt", payAmount)
                updateCmd.Parameters.AddWithValue("@bid", selectedBillingID)
                updateCmd.ExecuteNonQuery()

                ' Insert into Payments Table for Audit Trail
                Dim insertQuery As String = "INSERT INTO payments (billing_id, amount_paid, payment_date, reference_no) " &
                                          "VALUES (@bid, @amt, NOW(), @ref)"
                Dim insertCmd = New MySqlCommand(insertQuery, conn, transaction)
                insertCmd.Parameters.AddWithValue("@bid", selectedBillingID)
                insertCmd.Parameters.AddWithValue("@amt", payAmount)
                insertCmd.Parameters.AddWithValue("@ref", "REF-" & DateTime.Now.ToString("yyyyMMddHHmmss"))
                insertCmd.ExecuteNonQuery()

                transaction.Commit()
                MsgBox(type & " processed successfully!", MsgBoxStyle.Information)

                ' Refresh UI
                LoadBillingData()
                txtPaymentInput.Clear()
            Catch ex As Exception
                transaction.Rollback()
                MsgBox("Transaction failed: " & ex.Message)
            End Try

        Catch ex As Exception
            MsgBox("Connection error: " & ex.Message)
        Finally
            closeConn()
        End Try
    End Sub
End Class
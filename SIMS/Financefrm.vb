Public Class Financefrm

    ' 1. INITIALIZATION & WIRING
    Private Sub Financefrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' I-link ang mga buttons manually base sa iyong Designer names
        AddHandler btnDashboard.Click, AddressOf btnDashboard_Click
        AddHandler btnBilling.Click, AddressOf btnBilling_Click
        AddHandler btnPayments.Click, AddressOf btnPayments_Click
        AddHandler btnReports.Click, AddressOf btnReports_Click
        AddHandler btnLogout.Click, AddressOf btnLogout_Click
    End Sub

    ' 2. THE ENGINE: SWAPPING FORMS
    ' Gagamitin natin ang "pnlMain" dahil iyan ang nasa Designer mo.
    Private Sub OpenFinanceChild(ByVal childForm As Form)
        ' Siguraduhin na malinis ang panel bago maglagay ng bago
        If pnlMain.Controls.Count > 0 Then
            For Each ctrl As Control In pnlMain.Controls
                If TypeOf ctrl Is Form Then
                    DirectCast(ctrl, Form).Close()
                    ctrl.Dispose()
                End If
            Next
            pnlMain.Controls.Clear()
        End If

        ' Setup the child form as a sub-control
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        ' Add to your main panel
        pnlMain.Controls.Add(childForm)
        pnlMain.Tag = childForm
        childForm.Show()

        ' Update the Header label based on the form name (Optional)
        lblHeader.Text = "Finance - " & childForm.Text
    End Sub

    ' 3. BUTTON ACTIONS

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs)
        ' I-clear ang panel para bumalik sa Welcome Message (lblWelcome)
        pnlMain.Controls.Clear()
        pnlMain.Controls.Add(lblWelcome)
        lblHeader.Text = "Finance Dashboard"
    End Sub

    Private Sub btnBilling_Click(sender As Object, e As EventArgs)
        ' Siguraduhin na may form ka na "Billing" ang pangalan
        OpenFinanceChild(New Billing())
    End Sub

    Private Sub btnPayments_Click(sender As Object, e As EventArgs)
        ' Siguraduhin na may form ka na "paymentfrm" ang pangalan
        OpenFinanceChild(New paymentfrm())
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs)
        ' Siguraduhin na may form ka na "reports" ang pangalan
        OpenFinanceChild(New reports())
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            loginfrm.Show()
            Me.Close()
        End If
    End Sub

End Class
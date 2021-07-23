Public Class frmMain
    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles tsMenuLogout.Click
        menuoptionvisible()
        PictureBox2.Visible = False
        panelLogin.Visible = True
        MenuStrip1.Enabled = False
        lblDescLogin.Visible = False
        connect(condbPOS)
        mycommand = mysqlconn.CreateCommand
        mycommand.CommandText = "UPDATE Logs set Out='" & Format(DateAndTime.Now) & "' where ID ='" & Trim(lblLogsID.Text) & "'"
        mycommand.ExecuteNonQuery()
    End Sub
    Sub menuoptionvisible()
        tsMenuProfile.Visible = True
        tsMenuAdmission.Visible = True
        tsMenuExpenses.Visible = True
        tsMenuFees.Visible = True
        tsMenuTransaction.Visible = True
        tsMenuSetting.Visible = True
        tsMenuUsers.Visible = True

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        mylogin.VerifyUser()
        getMenu()
    End Sub
    Private Sub gettime()
        Dim zdate As DateTime = Date.Now
        lbltime.Text = "Today is :" & Space(1) & Now.ToString("F")
        'lbldate.Text = Format(DateTime.Now, "MM/dd/yyyy").ToString
        'lblstime.Text = Now.ToString("T")
        PictureBox2.Location = New Point((Me.Width / 2) - (PictureBox2.Width / 2), (Me.Height / 2) - (PictureBox2.Height / 2))
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        gettime()
    End Sub

    Private Sub closeme()
        Dim response As MsgBoxResult
        response = MsgBox("Are you sure you want to close this application?",
                          vbYesNo + vbExclamation + vbApplicationModal +
                          vbDefaultButton2, "Close confirmation")
        If response = MsgBoxResult.Yes Then
            Me.Visible = False
            Me.Dispose()
            Me.Close()
            End
        ElseIf response = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        closeme()
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        frmStudent.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        frmSchoolExpenses.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        frmUser.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        getSchoolearID()
        If SchoolYearID <> "" Then
            frmPayments.ShowDialog()
        Else
            MsgBox("No School Year Activated in the Settings", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        frmSchoolFees.ShowDialog()

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        getSchoolearID()
        If SchoolYearID <> "" Then
            frmAdmission.ShowDialog()
        Else
            MsgBox("No School Year Activated in the Settings", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub UserLogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserLogsToolStripMenuItem.Click
        frmLogs.ShowDialog()
    End Sub

    Private Sub UserManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserManagementToolStripMenuItem.Click
        frmSchoolYear.ShowDialog()
    End Sub

    Private Sub ManageGradeLevelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageGradeLevelToolStripMenuItem.Click
        frmGradeLevel.ShowDialog()
    End Sub

    Private Sub ManageSectionToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        frmReportLedger.ShowDialog()
    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            mylogin.VerifyUser()
            getMenu()
        End If

    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        frmReportAdmissionList.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        frmReportSchoolFeesList.ShowDialog()
    End Sub

    Private Sub SchoolExpensesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchoolExpensesToolStripMenuItem.Click
        frmReportExpensesList.ShowDialog()
    End Sub

    Private Sub PaymentListToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PaymentListToolStripMenuItem1.Click
        frmReportPaymentList.ShowDialog()
    End Sub

    Private Sub VoidedTransactractionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoidedTransactractionsToolStripMenuItem.Click
        frmReportVoidedPaymentList.ShowDialog()
    End Sub

    Private Sub YearlyChartToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmChart.ShowDialog()
    End Sub

    Private Sub DecisionSupportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecisionSupportToolStripMenuItem.Click
        frmChart.ShowDialog()
    End Sub
End Class

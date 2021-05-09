Public Class frmMain
    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles tsMenuLogout.Click
        panelLogin.Visible = True
        MenuStrip1.Enabled = False
        lblDescLogin.Visible = False
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
        frmPayments.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        frmSchoolFees.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        frmSelectSYAdmission.ShowDialog()
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
        frmSelectSYAdmission.ShowDialog()
    End Sub
End Class

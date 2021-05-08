Public Class frmMain
    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles tsMenuLogout.Click
        Me.Close()
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

    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem15.Click
        frmStudent.ShowDialog()
    End Sub
End Class

Public Class frmReportLedger
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        StudentviewFocus = "Student Ledger"
        loadstudentenrolled = True
        frmStudentSearch.ShowDialog()
    End Sub

    Private Sub frmReportLedger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtStudentCode.Text <> "" Then
            myledger.loadSY()
        End If
    End Sub
End Class
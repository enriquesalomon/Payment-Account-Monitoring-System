Public Class frmReportExpensesList
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmReportExpensesList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myschoolexpenses.loaddtgReport()
        myschoolexpenses.LoadListReport()

    End Sub
End Class
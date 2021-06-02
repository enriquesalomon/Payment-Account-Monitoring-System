Public Class frmReportExpensesList
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmReportExpensesList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myschoolexpenses.loaddtgReport()
        myschoolexpenses.loadSYReport()

    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        If cmbSY.Text <> Nothing Then
            myschoolexpenses.LoadListReport()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If dtgList.Rows.Count <> 0 Then
            printDoc = "School Expense List"
            'Report.ShowDialog()
        End If
    End Sub
End Class
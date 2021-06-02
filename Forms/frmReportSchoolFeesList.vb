Public Class frmReportSchoolFeesList
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmReportSchoolFeesList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myschoolfees.loaddtgReport()
        myschoolfees.loadSYReport()
    End Sub

    Private Sub dtgList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgList.CellClick
        If dtgList.Rows.Count > 0 Then
            lblrecordcount.Text = "Showing " & (dtgList.CurrentRow.Index) + 1 & Space(1) & "entries" & Space(1) & " of " & dtgList.Rows.Count

        End If
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        If cmbSY.Text <> Nothing Then
            myschoolfees.LoadListReport()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If dtgList.Rows.Count <> 0 Then
            printDoc = "School Fees List"
            'Report.ShowDialog()
        End If
    End Sub
End Class
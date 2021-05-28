Public Class frmReportAdmissionList
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmReportAdmissionList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myschoolexpenses.loadSYAdmissionReport()

    End Sub

    Private Sub cmbSY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSY.SelectedIndexChanged

    End Sub

End Class
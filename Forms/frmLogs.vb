Public Class frmLogs
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mylogs.loaddtg()
        mylogs.LoadList()
    End Sub
End Class
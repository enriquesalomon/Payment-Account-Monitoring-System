Public Class frmStudentSearch
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        txtsearch.Clear()
        Me.Close()
    End Sub

    Private Sub frmStudentSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myadmission.LoadStudentList()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        searching = True
        myadmission.LoadStudentList()
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        searching = False
        txtsearch.Clear()
        myadmission.LoadStudentList()
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            searching = True
            myadmission.LoadStudentList()
        End If
    End Sub
End Class
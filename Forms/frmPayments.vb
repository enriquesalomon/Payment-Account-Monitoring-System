Public Class frmPayments
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBrowseStudent_Click(sender As Object, e As EventArgs) Handles btnBrowseStudent.Click
        StudentviewFocus = "Payment Entry"
        frmStudentSearch.ShowDialog()
    End Sub
End Class
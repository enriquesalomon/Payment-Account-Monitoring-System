Public Class frmAdmission
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StudentviewFocus = "Admission Entry"
        frmStudentSearch.ShowDialog()
    End Sub

    Private Sub frmAdmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSchoolYear.Text = SchoolYearVar
    End Sub
End Class
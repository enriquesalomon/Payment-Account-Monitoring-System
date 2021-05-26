Public Class frmPayments
    Public Sub cleartx()
        txtAccountID.Clear()
        txtStudentCode.Clear()
        txtStudentFullname.Clear()
        txtgender.Clear()
        txtYrSection.Clear()
        dtgSchoolFee.Rows.Clear()
        txtTotalpayable.Text = "0.00"

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        cleartx()
        panelPayment.Visible = False
        Me.Close()
    End Sub

    Private Sub frmPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBrowseStudent_Click(sender As Object, e As EventArgs) Handles btnBrowseStudent.Click
        StudentviewFocus = "Payment Entry"
        frmStudentSearch.ShowDialog()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        panelPayment.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cleartx()
        panelPayment.Visible = False
    End Sub
End Class
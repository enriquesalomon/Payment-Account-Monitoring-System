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
    Private Sub ButtonClick(ByVal ckey As String)
        Select Case ckey
            Case "New"
                cleartx()
                panelPayment.Visible = True
                txtStudentCode.Focus()
                lsaving = True
                'btnEdit.Enabled = False
                'btnDelete.Enabled = False
                dtgSales.Enabled = False
                btnSave.Enabled = True


            Case "Edit"

                panelPayment.Visible = True
                lsaving = False
                btnNew.Enabled = False
                'btnDelete.Enabled = False
                dtgSales.Enabled = False
                btnSave.Enabled = True


            Case "Save"
                mypayments.SaveEditRecords()
            Case "Delete"
                'mypayments.delete()

        End Select
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
        ButtonClick("New")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cleartx()
        panelPayment.Visible = False
    End Sub

    Private Sub txtAmountPaid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmountPaid.KeyPress

        Try
            If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
                MsgBox("Input Only Number Value", MsgBoxStyle.Information)
                e.Handled = True
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ButtonClick("Save")
    End Sub
End Class
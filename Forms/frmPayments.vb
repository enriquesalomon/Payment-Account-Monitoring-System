Public Class frmPayments
    Public Sub cleartx()
        txtAccountID.Clear()
        txtStudentCode.Clear()
        txtStudentFullname.Clear()
        txtgender.Clear()
        txtGradeSection.Clear()
        dtgSchoolFee.Rows.Clear()
        txtTotalpayable.Text = "0.00"
        txttotalPayment.Text = "0.00"
        txtbalance.Text = "0.00"
        txtAmountPaid.Text = "0.00"

    End Sub
    Public Sub ButtonClick(ByVal ckey As String)
        Select Case ckey
            Case "New"
                cleartx()
                panelPayment.Visible = True
                txtStudentCode.Focus()
                lsaving = True
                btnSave.Enabled = True


            Case "Edit"
                lsaving = False
                frmVoidTransactionConfirmation.ShowDialog()
            Case "Save"
                mypayments.SaveEditRecords()
            Case "Delete"


        End Select
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        cleartx()
        panelPayment.Visible = False
        Me.Close()
    End Sub

    Private Sub frmPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mypayments.loaddtgSchoolFees()
        mypayments.loaddtgTransactions()
        mypayments.LoadListTransaction()
    End Sub

    Private Sub btnBrowseStudent_Click(sender As Object, e As EventArgs) Handles btnBrowseStudent.Click
        StudentviewFocus = "Payment Entry"
        frmStudentSearch.ShowDialog()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ButtonClick("New")
        getTransID(txtTransID.Text)
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

    Private Sub txtAccountID_TextChanged(sender As Object, e As EventArgs) Handles txtAccountID.TextChanged

    End Sub

    Private Sub txtStudentCode_TextChanged(sender As Object, e As EventArgs) Handles txtStudentCode.TextChanged

    End Sub

    Private Sub panelPayment_Paint(sender As Object, e As PaintEventArgs) Handles panelPayment.Paint

    End Sub

    Private Sub txtAmountPaid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAmountPaid.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonClick("Save")
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtsearch.Text <> "" Then
            searching = True
            mypayments.LoadListTransaction()
        End If
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        txtsearch.Clear()
        searching = False
        mypayments.LoadListTransaction()
    End Sub

    Private Sub DeleteMenuStrip_Click(sender As Object, e As EventArgs) Handles DeleteMenuStrip.Click
        ButtonClick("Edit")

    End Sub
End Class
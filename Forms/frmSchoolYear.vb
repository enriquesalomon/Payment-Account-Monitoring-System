Public Class frmSchoolYear
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Public Sub ClearMe()
        lblCode.Text = ""
        cmbFrom.Text = ""
        cmbTo.Text = ""
        cmbStatus.Text = Nothing
    End Sub
    Private Sub ClosePanel()
        panelSchoolYear.Visible = False
        btnDelete.Enabled = True
        btnNew.Enabled = True
        btnEdit.Enabled = True
        dtgSYList.Enabled = True
        btnSave.Enabled = False
        ClearMe()
    End Sub

    Private Sub ButtonClick(ByVal ckey As String)
        Select Case ckey
            Case "New"
                ClearMe()
                panelSchoolYear.Visible = True
                cmbFrom.Focus()
                lsaving = True
                btnEdit.Enabled = False
                btnDelete.Enabled = False
                dtgSYList.Enabled = False
                btnSave.Enabled = True


            Case "Edit"

                panelSchoolYear.Visible = True
                lsaving = False
                btnNew.Enabled = False
                btnDelete.Enabled = False
                dtgSYList.Enabled = False
                btnSave.Enabled = True


            Case "Save"
                myschoolyear.SaveEditRecords()
            Case "Delete"
                myschoolyear.delete()

        End Select
    End Sub
    Private Sub frmSchoolYear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myschoolyear.loaddtg()
        myschoolyear.LoadSYList()
    End Sub

    Private Sub btnClosePanel_Click(sender As Object, e As EventArgs) Handles btnClosePanel.Click
        ClosePanel()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ButtonClick("New")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ButtonClick("Save")
    End Sub

    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        ClosePanel()
    End Sub

    Private Sub dtgSYList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgSYList.CellClick
        If dtgSYList.Rows.Count > 0 Then
            myschoolyear.LoadSYData()
            btnEdit.Enabled = True
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lblCode.Text <> Nothing Then
            ButtonClick("Edit")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ButtonClick("Delete")
    End Sub

    Private Sub cmbFrom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbFrom.KeyPress
        Try
            If Not (Char.IsDigit(e.KeyChar)) And Not Char.IsControl(e.KeyChar) Then
                MsgBox("Input Only Number Value", MsgBoxStyle.Information)
                e.Handled = True
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbTo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbTo.KeyPress
        Try
            If Not (Char.IsDigit(e.KeyChar)) And Not Char.IsControl(e.KeyChar) Then
                MsgBox("Input Only Number Value", MsgBoxStyle.Information)
                e.Handled = True
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class
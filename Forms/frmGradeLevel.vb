﻿Public Class frmGradeLevel
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Public Sub ClearMe()
        lblCode.Text = ""
        txtGradeSection.Text = ""
    End Sub
    Private Sub ClosePanel()
        panel.Visible = False
        btnDelete.Enabled = True
        btnNew.Enabled = True
        btnEdit.Enabled = True
        dtgList.Enabled = True
        btnSave.Enabled = False
        ClearMe()
    End Sub

    Private Sub ButtonClick(ByVal ckey As String)
        Select Case ckey
            Case "New"
                ClearMe()
                panel.Visible = True
                txtGradeSection.Focus()
                lsaving = True
                btnEdit.Enabled = False
                btnDelete.Enabled = False
                dtgList.Enabled = False
                btnSave.Enabled = True


            Case "Edit"

                panel.Visible = True
                lsaving = False
                btnNew.Enabled = False
                btnDelete.Enabled = False
                dtgList.Enabled = False
                btnSave.Enabled = True


            Case "Save"
                mygradesection.SaveEditRecords()
            Case "Delete"
                mygradesection.delete()

        End Select
    End Sub

    Private Sub dtgList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgList.CellClick
        If dtgList.Rows.Count > 0 Then
            mygradesection.LoadData()
            btnEdit.Enabled = True
        End If

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ButtonClick("New")
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lblCode.Text <> Nothing Then
            ButtonClick("Edit")
        End If
    End Sub

    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        ClosePanel()
    End Sub

    Private Sub btnClosePanel_Click(sender As Object, e As EventArgs) Handles btnClosePanel.Click
        ClosePanel()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ButtonClick("Delete")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ButtonClick("Save")
    End Sub

    Private Sub frmGradeLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mygradesection.loaddtg()
        mygradesection.LoadList()
    End Sub
End Class
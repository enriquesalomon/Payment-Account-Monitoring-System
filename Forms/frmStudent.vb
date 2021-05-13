Public Class frmStudent
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Public Sub ClearMe()
        txtStudentCode.Clear()
        txtLname.Clear()
        txtFname.Clear()
        txtMname.Clear()
        cboGender.Text = Nothing
        dtBirthdate.Text = Nothing
        txtcontactno.Clear()

        txtFullnameICE.Clear()
        txtContactNoICE.Clear()
        txtBaranggay.Clear()
        txtMunCity.Clear()
        txtProvince.Clear()

    End Sub
    Private Sub ClosePanel()
        panelStudent.Visible = False
        btnDelete.Enabled = True
        btnNew.Enabled = True
        btnEdit.Enabled = True
        dtgStudent.Enabled = True
        btnSave.Enabled = False
        ClearMe()
    End Sub
    Private Sub btnClosePanel_Click(sender As Object, e As EventArgs) Handles btnClosePanel.Click
        ClosePanel()
    End Sub

    Private Sub ButtonClick(ByVal ckey As String)
        Select Case ckey
            Case "New"
                ClearMe()
                panelStudent.Visible = True
                txtLname.Focus()
                lbldesc.Text = "Add New Record"
                lsaving = True
                btnEdit.Enabled = False
                btnDelete.Enabled = False
                dtgStudent.Enabled = False
                btnSave.Enabled = True


            Case "Edit"

                panelStudent.Visible = True
                lsaving = False
                lbldesc.Text = "Modify Record"
                btnNew.Enabled = False
                btnDelete.Enabled = False
                dtgStudent.Enabled = False
                btnSave.Enabled = True


            Case "Save"
                mystudent.SaveEditRecords()
            Case "Delete"
                mystudent.delete()

        End Select
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ButtonClick("New")
    End Sub

    Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mystudent.loaddtg()
        mystudent.LoadStudentList()
    End Sub

    Private Sub dtgStudent_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgStudent.CellClick
        If dtgStudent.Rows.Count > 0 Then
            mystudent.LoadStudentData()
            lblrecordcount.Text = "Showing " & (dtgStudent.CurrentRow.Index) + 1 & Space(1) & "entries" & Space(1) & " of " & dtgStudent.Rows.Count
            btnEdit.Enabled = True
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtStudentCode.Text <> Nothing Then
            ButtonClick("Edit")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ButtonClick("Save")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ButtonClick("Delete")
    End Sub
    Dim age = 0
    Private Sub dtBirthdate_ValueChanged(sender As Object, e As EventArgs) Handles dtBirthdate.ValueChanged
        With dtBirthdate.Value
            Dim datenow As DateTime = New DateTime(Now.Year, .Month, .Day)
            age = Now.Year - .Year
            If datenow > Now Then age -= 1
            txtage.Text = age
        End With
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtsearch.Text <> "" Then
            searching = True
            mystudent.LoadStudentList()
        End If
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        txtsearch.Clear()
        searching = False
        mystudent.LoadStudentList()
    End Sub
End Class
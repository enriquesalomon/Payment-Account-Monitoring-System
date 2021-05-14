Public Class frmAdmission
    Public gradesectionID As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBrowseStudent.Click
        StudentviewFocus = "Admission Entry"
        frmStudentSearch.ShowDialog()
    End Sub

    Private Sub frmAdmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSchoolYear.Text = SchoolYearVar
        myadmission.LoadGradeSection()
        DisablerControls()
        ClearMe()
        myadmission.loadlist()
    End Sub

    Private Sub cmbGradeSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGradeSection.SelectedIndexChanged
        Call connect(condbPOS)
        mycommand = mysqlconn.CreateCommand
        mycommand.CommandText = "Select * from GradeSection WHERE GradeSection='" & cmbGradeSection.Text & "'"
        myadapter.SelectCommand = mycommand
        myadapter.Fill(mydataset, "GradeSection")
        mydataTable = mydataset.Tables("GradeSection")
        mysqlreader = mycommand.ExecuteReader
        If mydataTable.Rows.Count > 0 Then
            While mysqlreader.Read()
                gradesectionID = mysqlreader("ID").ToString
            End While
        Else
        End If
        mysqlreader.Close()
        mysqlconn.Close()
    End Sub

    Private Sub ButtonClick(ByVal ckey As String)
        Select Case ckey

            Case "New"
                lsaving = True
                txtFirstname.Focus()
                btnEdit.Enabled = False
                EnablerControls()
                ClearMe()
            Case "Edit"
                lsaving = False
                btnNew.Enabled = False
                EnablerControls()
            Case "Save"
                myadmission.SaveEditRecords()
            Case "Delete"
                myadmission.delete()
            Case "Cancel"
                btnEdit.Enabled = False
                'btnDelete.Enabled = True
                btnNew.Enabled = True
                DisablerControls()
                ClearMe()
        End Select
    End Sub
    Public Sub ClearMe()
        txtFirstname.Clear()
        txtMiddlename.Clear()
        txtLastname.Clear()
        txtGender.Clear()
        txtStudID.Clear()
        txtControlNumber.Clear()
        cmbGradeSection.Text = Nothing
    End Sub
    Public Sub DisablerControls()
        txtFirstname.Enabled = False
        txtMiddlename.Enabled = False
        txtLastname.Enabled = False
        txtGender.Enabled = False
        txtStudID.Enabled = False
        txtControlNumber.Enabled = False
        cmbGradeSection.Enabled = False
        btnBrowseStudent.Enabled = False
    End Sub
    Public Sub EnablerControls()
        btnSave.Enabled = True
        txtFirstname.Enabled = True
        txtMiddlename.Enabled = True
        txtLastname.Enabled = True
        txtGender.Enabled = True
        txtStudID.Enabled = True
        txtControlNumber.Enabled = True
        cmbGradeSection.Enabled = True
        btnBrowseStudent.Enabled = True
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ButtonClick("Edit")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ButtonClick("Save")
    End Sub

    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        ButtonClick("Cancel")
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ButtonClick("New")
    End Sub
End Class
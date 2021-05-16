Public Class frmAdmission
    Public gradesectionID As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        DisablerControls()
        ClearMe()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

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

    Private Sub dtgList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgList.CellClick

        Dim GridRow As DataGridViewRow = dtgList.CurrentRow
        For Each datagrd As DataGridViewRow In dtgList.SelectedRows

            txtControlNumber.Text = (CStr(GridRow.Cells.Item("controlno").Value))
            Dim gradesectionid As String = ""
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            'mycommand.CommandText = "Select * from Admission WHERE ID ='" & Trim((CStr(GridRow.Cells.Item("controlno").Value))) & "'"
            mycommand.CommandText = "Select * from (Admission inner join Student on Student.ID = Admission.StudID)  WHERE Admission.ID='" & CStr(GridRow.Cells.Item("controlno").Value) & "'"

            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "Admission")
            mydataTable = mydataset.Tables("Admission")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                While mysqlreader.Read()
                    txtStudID.Text = (mysqlreader("Student.ID").ToString)
                    txtFirstname.Text = (mysqlreader("Fname").ToString)
                    txtMiddlename.Text = (mysqlreader("Mname").ToString)
                    txtLastname.Text = (mysqlreader("Lname").ToString)
                    txtGender.Text = (mysqlreader("Gender").ToString)
                    gradesectionid = (mysqlreader("GradeSectionID").ToString)
                End While
                xtable.Rows.Clear()
                xdataset.Clear()
                mycommand = mysqlconn.CreateCommand
                mycommand.CommandText = " Select * from GradeSection where ID  ='" & gradesectionid & "'"
                myadapter.SelectCommand = mycommand
                myadapter.Fill(xdataset, "GradeSection")
                xtable = xdataset.Tables("GradeSection")
                If xtable.Rows.Count > 0 Then
                    For Each str As DataRow In xtable.Rows
                        cmbGradeSection.Text = str("GradeSection").ToString
                    Next
                End If
                xtable.Rows.Clear()
                xdataset.Clear()
            Else
            End If
            mysqlreader.Close()
            mysqlconn.Close()

        Next datagrd
        If txtControlNumber.Text <> Nothing Then
            btnEdit.Enabled = True
            btnSave.Enabled = False
            'btnDelete.Enabled = True
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnBrowseStudent.Click
        StudentviewFocus = "Admission Entry"
        frmStudentSearch.ShowDialog()
    End Sub

    Private Sub DeleteMenuStrip_Click(sender As Object, e As EventArgs) Handles DeleteMenuStrip.Click
        If txtControlNumber.Text = "" Then
            MsgBox("No record selected!", MsgBoxStyle.Information)
            Exit Sub
        End If
        ButtonClick("Delete")
    End Sub

    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtsearch.Text <> "" Then
            searching = True
            myadmission.loadlist()
        End If
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        txtsearch.Clear()
        searching = False
        myadmission.loadlist()

    End Sub
End Class
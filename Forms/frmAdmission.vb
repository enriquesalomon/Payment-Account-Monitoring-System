Public Class frmAdmission
    Public gradesectionID As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StudentviewFocus = "Admission Entry"
        frmStudentSearch.ShowDialog()
    End Sub

    Private Sub frmAdmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSchoolYear.Text = SchoolYearVar
        myadmission.LoadGradeSection()
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
End Class
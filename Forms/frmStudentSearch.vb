Public Class frmStudentSearch
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        txtsearch.Clear()
        Me.Close()
    End Sub

    Private Sub frmStudentSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myadmission.LoadStudentList()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        searching = True
        myadmission.LoadStudentList()
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        searching = False
        txtsearch.Clear()
        myadmission.LoadStudentList()
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            searching = True
            myadmission.LoadStudentList()
        End If
    End Sub


    Private Sub dtgStudentList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgStudentList.CellDoubleClick
        frmPayments.cleartx()
        If dtgStudentList.Rows.Count = 0 Then
            Exit Sub
        End If

        If StudentviewFocus = "Admission Entry" Then

            Dim GridRow As DataGridViewRow = dtgStudentList.CurrentRow
            For Each RW As DataGridViewRow In frmAdmission.dtgList.Rows
                If RW.Cells(2).Value = CStr(GridRow.Cells.Item("id").Value) Then
                    MsgBox("Student is already registered, Please choose another", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Next
            For Each datagrd As DataGridViewRow In dtgStudentList.SelectedRows

                Call connect(condbPOS)
                mycommand = mysqlconn.CreateCommand
                mycommand.CommandText = "Select * from  Student  WHERE ID='" & CStr(GridRow.Cells.Item("id").Value) & "'"
                'mycommand.CommandText = "Select * from (Admission inner join Student on Student.ID = Admission.StudID)  WHERE Admission.ID='" & CStr(GridRow.Cells.Item("id").Value) & "'"
                myadapter.SelectCommand = mycommand
                myadapter.Fill(mydataset, "Student")
                mydataTable = mydataset.Tables("Student")
                mysqlreader = mycommand.ExecuteReader
                If mydataTable.Rows.Count > 0 Then
                    While mysqlreader.Read()
                        frmAdmission.txtLastname.Text = mysqlreader("Lname").ToString
                        frmAdmission.txtFirstname.Text = mysqlreader("Fname").ToString
                        frmAdmission.txtMiddlename.Text = mysqlreader("Mname").ToString
                        frmAdmission.txtGender.Text = mysqlreader("Gender").ToString
                        frmAdmission.txtStudID.Text = mysqlreader("ID").ToString
                        'frmAdmission.cmbGradeSection.Text = mysqlreader("SchoolYearID").ToString
                    End While
                Else
                End If
                mysqlreader.Close()
                mysqlconn.Close()
            Next datagrd

            Me.Close()

        ElseIf StudentviewFocus = "Payment Entry" Then
            Dim GridRow As DataGridViewRow = dtgStudentList.CurrentRow
            For Each datagrd As DataGridViewRow In dtgStudentList.SelectedRows

                Call connect(condbPOS)
                mycommand = mysqlconn.CreateCommand
                mycommand.CommandText = "Select * from  Student  WHERE ID='" & CStr(GridRow.Cells.Item("id").Value) & "'"
                'mycommand.CommandText = "Select * from (Admission inner join Student on Student.ID = Admission.StudID)  WHERE Admission.ID='" & CStr(GridRow.Cells.Item("id").Value) & "'"
                myadapter.SelectCommand = mycommand
                myadapter.Fill(mydataset, "Student")
                mydataTable = mydataset.Tables("Student")
                mysqlreader = mycommand.ExecuteReader
                If mydataTable.Rows.Count > 0 Then
                    While mysqlreader.Read()
                        frmPayments.txtStudentFullname.Text = mysqlreader("Fname").ToString + " " + mysqlreader("Mname").ToString + " " + mysqlreader("Lname").ToString
                        frmPayments.txtgender.Text = mysqlreader("Gender").ToString
                        frmPayments.txtgender.Text = mysqlreader("Gender").ToString
                        frmPayments.txtStudentCode.Text = mysqlreader("ID").ToString
                        'frmAdmission.cmbGradeSection.Text = mysqlreader("SchoolYearID").ToString
                    End While
                Else
                End If
                mysqlreader.Close()
                mysqlconn.Close()

                Dim admissionID As String = ""
                Call connect(condbPOS)
                mycommand = mysqlconn.CreateCommand
                mycommand.CommandText = "Select * from  Admission  WHERE SchoolYearID='" & SchoolYearID & "' AND StudID='" & CStr(GridRow.Cells.Item("id").Value) & "'"
                myadapter.SelectCommand = mycommand
                myadapter.Fill(mydataset, "Admission")
                mydataTable = mydataset.Tables("Admission")
                mysqlreader = mycommand.ExecuteReader
                If mydataTable.Rows.Count > 0 Then
                    While mysqlreader.Read()
                        frmPayments.txtGradeSection.Text = mysqlreader("GradeSectionID").ToString
                        admissionID = mysqlreader("ID").ToString
                    End While
                Else
                End If
                mysqlreader.Close()
                mysqlconn.Close()

                Call connect(condbPOS)
                mycommand = mysqlconn.CreateCommand
                mycommand.CommandText = "Select * from  StudentAccount  WHERE AdmissionID='" & admissionID & "'"
                myadapter.SelectCommand = mycommand
                myadapter.Fill(mydataset, "StudentAccount")
                mydataTable = mydataset.Tables("StudentAccount")
                mysqlreader = mycommand.ExecuteReader
                If mydataTable.Rows.Count > 0 Then
                    While mysqlreader.Read()
                        frmPayments.txtAccountID.Text = mysqlreader("ID").ToString
                    End While
                Else
                End If
                mysqlreader.Close()
                mysqlconn.Close()
            Next datagrd

            mypayments.LoadListSchoolFees()

            If frmPayments.txtAccountID.Text = "" Then
                frmPayments.cleartx()
            End If



            Me.Close()

        End If


    End Sub
End Class
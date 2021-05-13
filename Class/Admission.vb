Public Class Admission
    Sub LoadStudentList()
        Try
            frmStudentSearch.dtgStudentList.Rows.Clear()
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            If searching = True Then
                mycommand.CommandText = "Select * from Student where Fname Like '%" & frmStudentSearch.txtsearch.Text & "%' OR Lname Like '%" & frmStudentSearch.txtsearch.Text & "%'ORDER BY Fname ASC"
            Else
                mycommand.CommandText = "Select * from Student ORDER BY Fname ASC"
            End If

            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "Student")
            mydataTable = mydataset.Tables("Student")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                frmStudentSearch.dtgStudentList.ColumnCount = 3

                frmStudentSearch.dtgStudentList.Columns(0).HeaderText = "STUDENT ID"
                frmStudentSearch.dtgStudentList.Columns(0).Width = 100
                frmStudentSearch.dtgStudentList.Columns(0).Name = "id"
                frmStudentSearch.dtgStudentList.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

                frmStudentSearch.dtgStudentList.Columns(1).HeaderText = "STUDENT NAME"
                frmStudentSearch.dtgStudentList.Columns(1).Width = 250
                frmStudentSearch.dtgStudentList.Columns(1).Name = "fullname"
                frmStudentSearch.dtgStudentList.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

                frmStudentSearch.dtgStudentList.Columns(2).HeaderText = "GENDER"
                frmStudentSearch.dtgStudentList.Columns(2).Width = 100
                frmStudentSearch.dtgStudentList.Columns(2).Name = "gender"
                frmStudentSearch.dtgStudentList.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

                While mysqlreader.Read
                    Dim nrow As String() = New String() {mysqlreader("ID").ToString, mysqlreader("Fname").ToString + " " + mysqlreader("Mname").ToString + " " + mysqlreader("Lname").ToString, mysqlreader("Gender").ToString}
                    frmStudentSearch.dtgStudentList.Rows.Add(nrow)
                End While

            End If

            mysqlreader.Close()
            mydataTable.Rows.Clear()
            mydataset.Clear()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub

    Sub LoadGradeSection()
        Try
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select * from GradeSection"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "GradeSection")
            mydataTable = mydataset.Tables("GradeSection")
            mysqlreader = mycommand.ExecuteReader()
            While mysqlreader.Read()
                frmAdmission.cmbGradeSection.Items.Add(mysqlreader("GradeSection"))
            End While
            mysqlreader.Close()
            mysqlconn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")

        End Try
    End Sub
End Class

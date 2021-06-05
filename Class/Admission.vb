Public Class Admission

    Sub LoadStudentList()
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


        If loadstudentenrolled = True Then
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
                    While mysqlreader.Read
                        Dim found As Boolean = False
                        xtable.Rows.Clear()
                        xdataset.Clear()
                        mycommand = mysqlconn.CreateCommand
                        mycommand.CommandText = "Select * from Admission where StudID  ='" & mysqlreader("ID").ToString & "'"
                        Dim fname As String = ""
                        Dim gender As String = ""
                        myadapter.SelectCommand = mycommand
                        myadapter.Fill(xdataset, "Admission")
                        xtable = xdataset.Tables("Admission")
                        If xtable.Rows.Count > 0 Then
                            found = True
                        Else
                            found = False
                        End If
                        xtable.Rows.Clear()
                        xdataset.Clear()

                        If found = True Then
                            Dim nrow As String() = New String() {mysqlreader("ID").ToString, mysqlreader("Fname").ToString + " " + mysqlreader("Mname").ToString + " " + mysqlreader("Lname").ToString, mysqlreader("Gender").ToString}
                            frmStudentSearch.dtgStudentList.Rows.Add(nrow)
                        End If

                    End While

                End If

                mysqlreader.Close()
                mydataTable.Rows.Clear()
                mydataset.Clear()
            Catch ex As Exception
                MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
            End Try
        Else
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
        End If

    End Sub

    Sub LoadGradeSection()
        Try
            frmAdmission.cmbGradeSection.Items.Clear()
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

    Sub loadlist()
        Try
            frmAdmission.dtgList.Rows.Clear()
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand

            If searching = True Then
                mycommand.CommandText = "Select * from (Admission inner join Student on Student.ID = Admission.StudID) where Admission.SchoolYearID  ='" & SchoolYearID & "' AND Fname Like '%" & frmAdmission.txtsearch.Text & "%' OR Lname Like '%" & frmAdmission.txtsearch.Text & "%'"
            Else
                mycommand.CommandText = "Select * from (Admission inner join Student on Student.ID = Admission.StudID) where Admission.SchoolYearID  ='" & SchoolYearID & "'"
            End If

            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "Admission")
            mydataTable = mydataset.Tables("Admission")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                frmAdmission.dtgList.ColumnCount = 8

                frmAdmission.dtgList.Columns(0).HeaderText = "NO."
                frmAdmission.dtgList.Columns(0).Width = 50
                frmAdmission.dtgList.Columns(0).Name = "num"
                frmAdmission.dtgList.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter


                frmAdmission.dtgList.Columns(1).HeaderText = "CONTROL#"
                frmAdmission.dtgList.Columns(1).Width = 100
                frmAdmission.dtgList.Columns(1).Name = "controlno"
                frmAdmission.dtgList.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

                frmAdmission.dtgList.Columns(2).HeaderText = "STUDENT ID"
                frmAdmission.dtgList.Columns(2).Width = 100
                frmAdmission.dtgList.Columns(2).Name = "studid"
                frmAdmission.dtgList.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

                frmAdmission.dtgList.Columns(3).HeaderText = "STUDENT"
                frmAdmission.dtgList.Columns(3).Width = 200
                frmAdmission.dtgList.Columns(3).Name = "name"
                frmAdmission.dtgList.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

                frmAdmission.dtgList.Columns(4).HeaderText = "GENDER"
                frmAdmission.dtgList.Columns(4).Width = 100
                frmAdmission.dtgList.Columns(4).Name = "gender"
                frmAdmission.dtgList.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

                frmAdmission.dtgList.Columns(5).HeaderText = "GRADE/SECTION"
                frmAdmission.dtgList.Columns(5).Width = 150
                frmAdmission.dtgList.Columns(5).Name = "section"
                frmAdmission.dtgList.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

                frmAdmission.dtgList.Columns(6).HeaderText = "ADDED BY"
                frmAdmission.dtgList.Columns(6).Width = 100
                frmAdmission.dtgList.Columns(6).Name = "addedby"
                frmAdmission.dtgList.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

                frmAdmission.dtgList.Columns(7).HeaderText = "DATE ADDED"
                frmAdmission.dtgList.Columns(7).Width = 80
                frmAdmission.dtgList.Columns(7).Name = "dateadded"
                frmAdmission.dtgList.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

                Dim num As Integer = 0
                Dim gradesection As String = ""
                While mysqlreader.Read

                    xtable.Rows.Clear()
                    xdataset.Clear()
                    mycommand = mysqlconn.CreateCommand
                    mycommand.CommandText = " Select * from GradeSection where ID  ='" & mysqlreader("GradeSectionID").ToString & "'"
                    myadapter.SelectCommand = mycommand
                    myadapter.Fill(xdataset, "GradeSection")
                    xtable = xdataset.Tables("GradeSection")
                    If xtable.Rows.Count > 0 Then
                        For Each str As DataRow In xtable.Rows
                            gradesection = str("GradeSection").ToString

                        Next
                    End If
                    xtable.Rows.Clear()
                    xdataset.Clear()
                    If mysqlreader("SchoolYearID").ToString = SchoolYearID Then
                        num += 1
                        Dim nrow As String() = New String() {num.ToString, mysqlreader("Admission.ID").ToString, mysqlreader("StudID").ToString, mysqlreader("Fname").ToString + " " + mysqlreader("Mname").ToString + " " + mysqlreader("Lname").ToString, mysqlreader("Gender").ToString, gradesection.ToString, mysqlreader("AddedBy").ToString, mysqlreader("DateInserted").ToString}
                        frmAdmission.dtgList.Rows.Add(nrow)
                    End If


                End While
                frmAdmission.lblrecordcount.Text = "Record Count: " & num
            End If

            mysqlreader.Close()
            mydataTable.Rows.Clear()
            mydataset.Clear()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub




    Public studentAccountID As String = ""
    Sub SaveEditRecords()
        If frmAdmission.txtStudID.Text = "" Then
            MsgBox("Student ID is Required")
            Exit Sub
        End If
        If frmAdmission.cmbGradeSection.Text = Nothing Then
            MsgBox("Grade/Section is Required")
            Exit Sub
        End If

        If lsaving Then
            getAdmissiontID(frmAdmission.txtControlNumber.Text)
            If MessageBox.Show("Add this New Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                ' getClientNo(txtclientNo.Text)
                connect(condbPOS)
                mycommand = mysqlconn.CreateCommand
                mycommand.CommandText = "INSERT INTO Admission VALUES ('" & frmAdmission.txtControlNumber.Text & "','" & frmAdmission.txtStudID.Text & "','" & Trim(frmAdmission.gradesectionID) & "','" & Trim(SchoolYearID) & "','" & Trim(UserID) & "','" & Format(DateAndTime.Now, "Short Date") & "','" & Format(DateAndTime.Now, "Short Date") & "')"
                mycommand.ExecuteNonQuery()
                getStudentAccountID(studentAccountID)
                connect(condbPOS)
                mycommand = mysqlconn.CreateCommand
                mycommand.CommandText = "INSERT INTO StudentAccount VALUES ('" & studentAccountID & "','" & frmAdmission.txtControlNumber.Text & "')"
                mycommand.ExecuteNonQuery()
                MsgBox("New data has been successfully added!", MsgBoxStyle.Information)

                frmAdmission.ClearMe()
                loadlist()
                frmAdmission.DisablerControls()
            End If
        Else
            If frmAdmission.txtControlNumber.Text = Nothing Then
                Exit Sub
            End If

            If MessageBox.Show("Are you sure you want to Update this Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    connect(condbPOS)
                    mycommand = mysqlconn.CreateCommand
                    mycommand.CommandText = "UPDATE Admission set StudID='" & frmAdmission.txtStudID.Text & "',GradeSectionID='" & frmAdmission.gradesectionID & "',DateModified='" & Format(DateAndTime.Now, "Short Date") & "' where ID ='" & frmAdmission.txtControlNumber.Text & "'"
                    mycommand.ExecuteNonQuery()
                    MsgBox("Record was Successfully Updated!", MsgBoxStyle.Information)
                    frmAdmission.ClearMe()
                    loadlist()
                    frmAdmission.DisablerControls()
                    frmAdmission.btnNew.Enabled = True
                    frmAdmission.btnEdit.Enabled = False
                    frmAdmission.btnSave.Enabled = False
                Catch ex As Exception
                    MsgBox("ERROR:" & ex.Message & ex.Source)

                End Try
            End If

        End If

    End Sub

    Sub delete()

        If ValidateExistingTXNAdmission() Then
            MsgBox("Record Cannot be Deleted! Found Existing Transaction", MsgBoxStyle.Information)
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to delete this Record  " & vbNewLine & " " & vbNewLine & "", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Try
                connect(condbPOS)
                mycommand = mysqlconn.CreateCommand
                mycommand.CommandText = "DELETE from Admission where ID ='" & frmAdmission.txtControlNumber.Text & "'"
                mycommand.ExecuteNonQuery()
                MsgBox("Data was Successfully Deleted!", MsgBoxStyle.Information)
                frmAdmission.ClearMe()
                loadlist()
                frmAdmission.DisablerControls()
            Catch ex As Exception
                MsgBox("ERROR:" & ex.Message & ex.Source)
                frmAdmission.ClearMe()
            End Try

        End If
    End Sub

    Sub loadSY()

        frmReportAdmissionList.cmbSY.Items.Clear()
        Call connect(condbPOS)
        mycommand = mysqlconn.CreateCommand
        mycommand.CommandText = "Select * from SchoolYear"
        myadapter.SelectCommand = mycommand
        myadapter.Fill(mydataset, "SchoolYear")
        mydataTable = mydataset.Tables("SchoolYear")
        mysqlreader = mycommand.ExecuteReader()
        While mysqlreader.Read()
            frmReportAdmissionList.cmbSY.Items.Add(mysqlreader("SYFrom").ToString + "-" + mysqlreader("SYTo").ToString)

        End While
        mysqlreader.Close()
        mysqlconn.Close()
    End Sub
    Sub loaddtgAdmissionReport()
        frmReportAdmissionList.dtgList.ColumnCount = 8

        frmReportAdmissionList.dtgList.Columns(0).HeaderText = "NO."
        frmReportAdmissionList.dtgList.Columns(0).Width = 50
        frmReportAdmissionList.dtgList.Columns(0).Name = "num"
        frmReportAdmissionList.dtgList.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter


        frmReportAdmissionList.dtgList.Columns(1).HeaderText = "CONTROL#"
        frmReportAdmissionList.dtgList.Columns(1).Width = 100
        frmReportAdmissionList.dtgList.Columns(1).Name = "controlno"
        frmReportAdmissionList.dtgList.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportAdmissionList.dtgList.Columns(2).HeaderText = "STUDENT ID"
        frmReportAdmissionList.dtgList.Columns(2).Width = 100
        frmReportAdmissionList.dtgList.Columns(2).Name = "studid"
        frmReportAdmissionList.dtgList.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportAdmissionList.dtgList.Columns(3).HeaderText = "STUDENT"
        frmReportAdmissionList.dtgList.Columns(3).Width = 200
        frmReportAdmissionList.dtgList.Columns(3).Name = "name"
        frmReportAdmissionList.dtgList.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportAdmissionList.dtgList.Columns(4).HeaderText = "GENDER"
        frmReportAdmissionList.dtgList.Columns(4).Width = 100
        frmReportAdmissionList.dtgList.Columns(4).Name = "gender"
        frmReportAdmissionList.dtgList.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportAdmissionList.dtgList.Columns(5).HeaderText = "GRADE/SECTION"
        frmReportAdmissionList.dtgList.Columns(5).Width = 150
        frmReportAdmissionList.dtgList.Columns(5).Name = "section"
        frmReportAdmissionList.dtgList.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportAdmissionList.dtgList.Columns(6).HeaderText = "ADDED BY"
        frmReportAdmissionList.dtgList.Columns(6).Width = 100
        frmReportAdmissionList.dtgList.Columns(6).Name = "addedby"
        frmReportAdmissionList.dtgList.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportAdmissionList.dtgList.Columns(7).HeaderText = "DATE ADDED"
        frmReportAdmissionList.dtgList.Columns(7).Width = 150
        frmReportAdmissionList.dtgList.Columns(7).Name = "dateadded"
        frmReportAdmissionList.dtgList.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

    End Sub

    Sub loadSYAdmissionReport()

        Try
            frmReportAdmissionList.SchoolYearIDFilter = ""
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select * from SchoolYear where SYFrom ='" & frmReportAdmissionList.SYFrom & "' AND SYTo ='" & frmReportAdmissionList.SYTo & "' "
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "SchoolYear")
            mydataTable = mydataset.Tables("SchoolYear")
            mysqlreader = mycommand.ExecuteReader()
            While mysqlreader.Read()
                frmReportAdmissionList.SchoolYearIDFilter = mysqlreader("ID").ToString

            End While
            mysqlreader.Close()
            mysqlconn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")

        End Try

        Try
            frmReportAdmissionList.dtgList.Rows.Clear()
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand

            'If searching = True Then
            'mycommand.CommandText = "Select * from (Admission inner join Student on Student.ID = Admission.StudID) where Admission.SchoolYearID  ='" & SchoolYearID & "' AND Fname Like '%" & frmAdmission.txtsearch.Text & "%' OR Lname Like '%" & frmAdmission.txtsearch.Text & "%'"
            'Else
            mycommand.CommandText = "Select * from (Admission inner join Student on Student.ID = Admission.StudID) where Admission.SchoolYearID  ='" & frmReportAdmissionList.SchoolYearIDFilter & "'"
            'End If

            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "Admission")
            mydataTable = mydataset.Tables("Admission")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then

                Dim num As Integer = 0
                Dim gradesection As String = ""
                While mysqlreader.Read

                    xtable.Rows.Clear()
                    xdataset.Clear()
                    mycommand = mysqlconn.CreateCommand
                    mycommand.CommandText = " Select * from GradeSection where ID  ='" & mysqlreader("GradeSectionID").ToString & "'"
                    myadapter.SelectCommand = mycommand
                    myadapter.Fill(xdataset, "GradeSection")
                    xtable = xdataset.Tables("GradeSection")
                    If xtable.Rows.Count > 0 Then
                        For Each str As DataRow In xtable.Rows
                            gradesection = str("GradeSection").ToString

                        Next
                    End If
                    xtable.Rows.Clear()
                    xdataset.Clear()
                    If mysqlreader("SchoolYearID").ToString = frmReportAdmissionList.SchoolYearIDFilter Then
                        num += 1
                        Dim nrow As String() = New String() {num.ToString, mysqlreader("Admission.ID").ToString, mysqlreader("StudID").ToString, mysqlreader("Fname").ToString + " " + mysqlreader("Mname").ToString + " " + mysqlreader("Lname").ToString, mysqlreader("Gender").ToString, gradesection.ToString, mysqlreader("AddedBy").ToString, mysqlreader("DateInserted").ToString}
                        frmReportAdmissionList.dtgList.Rows.Add(nrow)
                    End If


                End While
                frmReportAdmissionList.lblrecordcount.Text = "Record Count: " & num
            End If
            Dim no As Integer = 0
            For Each RW As DataGridViewRow In frmReportAdmissionList.dtgList.Rows
                no += 1
            Next
            frmReportAdmissionList.lblrecordcount.Text = "Record Count: " & no

            mysqlreader.Close()
            mydataTable.Rows.Clear()
            mydataset.Clear()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try

    End Sub

End Class

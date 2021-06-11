Public Class Student
    Sub SaveEditRecords()
        If frmStudent.txtLname.Text = "" Then
            MessageBox.Show("Please enter Student Last Name!", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If frmStudent.txtFname.Text = "" Then
            MessageBox.Show("Please enter Student First Name!", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If frmStudent.txtMname.Text = "" Then
            MessageBox.Show("Please enter Student Middle Name!", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If frmStudent.cboGender.Text = "" Then
            MessageBox.Show("Please select Student Gender!", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If frmStudent.txtage.Text = "" Then
            MessageBox.Show("Please Select Student DOB!", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If frmStudent.txtage.Text = "0" Then
            MessageBox.Show("Please Select Student DOB!", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If frmStudent.txtBaranggay.Text = "" Then
            MessageBox.Show("Please enter Student Baranggat/blk.number/St. Address!", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If frmStudent.txtMunCity.Text = "" Then
            MessageBox.Show("Please select Student City Address!", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If frmStudent.txtProvince.Text = "" Then
            MessageBox.Show("Please select Student Province Address!", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If frmStudent.txtcontactno.Text = "" Then
            MessageBox.Show("Please enter  Student Contact Number!", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If frmStudent.txtMother.Text = "" Then
            MessageBox.Show("Please enter  Mother's name", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If frmStudent.txtFather.Text = "" Then
            MessageBox.Show("Please enter   Father's name!", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If lsaving Then


            If MessageBox.Show("Add this new Data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                getStudentID(frmStudent.txtStudentCode.Text)
                connect(condbPOS)
                mycommand = mysqlconn.CreateCommand
                mycommand.CommandText = "INSERT INTO Student VALUES ('" & frmStudent.txtStudentCode.Text & "','" & frmStudent.txtLname.Text & "','" & Trim(frmStudent.txtFname.Text) & "','" & Trim(frmStudent.txtMname.Text) & "','" & Trim(frmStudent.cboGender.Text) & "','" & Trim(frmStudent.dtBirthdate.Text) & "','" & Trim(frmStudent.txtcontactno.Text) & "','" & Trim(frmStudent.txtBaranggay.Text) & "','" & Trim(frmStudent.txtMunCity.Text) & "','" & Trim(frmStudent.txtProvince.Text) & "','" & Trim(frmStudent.txtFullnameICE.Text) & "','" & Trim(frmStudent.txtContactNoICE.Text) & "','" & Format(DateAndTime.Now, "Short Date") & "','" & Format(DateAndTime.Now, "Short Date") & "','" & Trim(frmStudent.txtMother.Text) & "','" & Trim(frmStudent.txtFather.Text) & "','" & Trim(frmStudent.txtFb.Text) & "','" & Trim(frmStudent.txtEmailadd.Text) & "')"
                mycommand.ExecuteNonQuery()
                LoadStudentList()
                frmStudent.ClearMe()
                frmStudent.txtLname.Focus()
                frmStudent.panelStudent.Visible = False
                frmStudent.dtgStudent.Enabled = True
                frmStudent.btnSave.Enabled = False
                MsgBox("New Student has been successfully Saved ", MsgBoxStyle.OkOnly, "Message")
                lsaving = False
                frmStudent.btnDelete.Enabled = True
            End If
            lsaving = False

        Else

            If MessageBox.Show("Are you sure you want to Update this Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    connect(condbPOS)
                    mycommand = mysqlconn.CreateCommand
                    mycommand.CommandText = "UPDATE Student set Lname='" & frmStudent.txtLname.Text & "',Fname='" & frmStudent.txtFname.Text & "',Mname='" & frmStudent.txtMname.Text & "',Gender='" & frmStudent.cboGender.Text & "',Birthdate='" & frmStudent.dtBirthdate.Text & "',ContactNo='" & frmStudent.txtcontactno.Text & "',Barangay='" & frmStudent.txtBaranggay.Text & "',City='" & frmStudent.txtMunCity.Text & "',Province='" & frmStudent.txtProvince.Text & "',FullnameInCaseEmerg='" & frmStudent.txtFullnameICE.Text & "',ContactInCaseEmerg='" & frmStudent.txtContactNoICE.Text & "',DateModified='" & Format(DateAndTime.Now, "Short Date") & "',MothersName='" & frmStudent.txtMother.Text & "',FathersName='" & frmStudent.txtFather.Text & "',FB='" & frmStudent.txtFb.Text & "',Email='" & frmStudent.txtEmailadd.Text & "' where ID ='" & frmStudent.txtStudentCode.Text & "'"
                    mycommand.ExecuteNonQuery()
                    LoadStudentList()
                    frmStudent.ClearMe()
                    frmStudent.txtLname.Focus()
                    frmStudent.panelStudent.Visible = False
                    frmStudent.btnNew.Enabled = True
                    frmStudent.dtgStudent.Enabled = True
                    frmStudent.btnDelete.Enabled = True
                    frmStudent.btnSave.Enabled = False
                    MsgBox("Student Record has been successfully updated ", MsgBoxStyle.OkOnly, "Message")
                Catch ex As Exception
                    MsgBox("ERROR:" & ex.Message & ex.Source)

                End Try
            End If
        End If

    End Sub

    Sub delete()
        If ValidateExistingTXN() Then
            MsgBox("Record Cannot be Deleted! Found Existing Transaction", MsgBoxStyle.Information)
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to delete this Record  " & vbNewLine & " " & vbNewLine & "  ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Try
                connect(condbPOS)
                mycommand = mysqlconn.CreateCommand
                mycommand.CommandText = "DELETE from Student where ID ='" & frmStudent.txtStudentCode.Text & "'"
                mycommand.ExecuteNonQuery()
                MsgBox("Data was Successfully Deleted!", MsgBoxStyle.Information)
                LoadStudentList()
                frmStudent.ClearMe()

            Catch ex As Exception
                MsgBox("ERROR:" & ex.Message & ex.Source)
                '///  frmUserManagement.ClearMe()
            End Try

        End If
    End Sub
    Sub loaddtg()
        frmStudent.dtgStudent.ColumnCount = 7

        frmStudent.dtgStudent.Columns(0).HeaderText = "NO."
        frmStudent.dtgStudent.Columns(0).Width = 50
        frmStudent.dtgStudent.Columns(0).Name = "no"
        frmStudent.dtgStudent.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmStudent.dtgStudent.Columns(1).HeaderText = "STUDENT ID"
        frmStudent.dtgStudent.Columns(1).Width = 100
        frmStudent.dtgStudent.Columns(1).Name = "id"
        frmStudent.dtgStudent.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmStudent.dtgStudent.Columns(2).HeaderText = "STUDENT NAME"
        frmStudent.dtgStudent.Columns(2).Width = 250
        frmStudent.dtgStudent.Columns(2).Name = "fullname"
        frmStudent.dtgStudent.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmStudent.dtgStudent.Columns(3).HeaderText = "GENDER"
        frmStudent.dtgStudent.Columns(3).Width = 100
        frmStudent.dtgStudent.Columns(3).Name = "gender"
        frmStudent.dtgStudent.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmStudent.dtgStudent.Columns(4).HeaderText = "CONTACT #"
        frmStudent.dtgStudent.Columns(4).Width = 100
        frmStudent.dtgStudent.Columns(4).Name = "contactno"
        frmStudent.dtgStudent.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter


        frmStudent.dtgStudent.Columns(5).HeaderText = "ADDRESS"
        frmStudent.dtgStudent.Columns(5).Width = 300
        frmStudent.dtgStudent.Columns(5).Name = "address"
        frmStudent.dtgStudent.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmStudent.dtgStudent.Columns(6).HeaderText = "DATE ADDED"
        frmStudent.dtgStudent.Columns(6).Width = 100
        frmStudent.dtgStudent.Columns(6).Name = "datamodified"
        frmStudent.dtgStudent.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

    End Sub

    Sub LoadStudentList()
        Try
            frmStudent.dtgStudent.Rows.Clear()
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            If searching = True Then
                mycommand.CommandText = "Select * from Student where Fname Like '%" & frmStudent.txtsearch.Text & "%' OR Lname Like '%" & frmStudent.txtsearch.Text & "%'"
            Else
                mycommand.CommandText = "Select * from Student"
            End If

            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "Student")
            mydataTable = mydataset.Tables("Student")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                Dim nos As Integer = 0
                While mysqlreader.Read
                    nos += 1
                    Dim nrow As String() = New String() {nos.ToString, mysqlreader("ID").ToString, mysqlreader("Fname").ToString + " " + mysqlreader("Mname").ToString + " " + mysqlreader("Lname").ToString, mysqlreader("Gender").ToString, mysqlreader("ContactNo").ToString, mysqlreader("Barangay").ToString + " " + mysqlreader("City").ToString + ", " + mysqlreader("Province").ToString, mysqlreader("DateAdded").ToString}
                    frmStudent.dtgStudent.Rows.Add(nrow)
                End While

            End If
            Dim no As Integer = 0
            For Each RW As DataGridViewRow In frmStudent.dtgStudent.Rows
                no += 1
            Next
            frmStudent.lblrecordcount.Text = "Record Count: " & no
            mysqlreader.Close()
            mydataTable.Rows.Clear()
            mydataset.Clear()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub


    Public Sub LoadStudentData()
        Dim GridRow As DataGridViewRow = frmStudent.dtgStudent.CurrentRow

        For Each datagrd As DataGridViewRow In frmStudent.dtgStudent.SelectedRows
            frmStudent.txtStudentCode.Text = CStr(GridRow.Cells.Item("id").Value)
        Next datagrd
        Try

            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select * from Student where ID='" & frmStudent.txtStudentCode.Text & "'"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "Student")
            mydataTable = mydataset.Tables("Student")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                For Each xrow As DataRow In mydataTable.Rows
                    frmStudent.txtStudentCode.Text = xrow("ID").ToString
                    frmStudent.txtLname.Text = xrow("Lname").ToString
                    frmStudent.txtFname.Text = xrow("Fname").ToString
                    frmStudent.txtMname.Text = xrow("Mname").ToString
                    frmStudent.cboGender.Text = xrow("Gender").ToString
                    frmStudent.dtBirthdate.Text = xrow("Birthdate").ToString
                    frmStudent.txtcontactno.Text = xrow("ContactNo").ToString
                    frmStudent.txtBaranggay.Text = xrow("Barangay").ToString
                    frmStudent.txtMunCity.Text = xrow("City").ToString
                    frmStudent.txtProvince.Text = xrow("Province").ToString
                    frmStudent.txtFullnameICE.Text = xrow("FullnameInCaseEmerg").ToString
                    frmStudent.txtContactNoICE.Text = xrow("ContactInCaseEmerg").ToString
                    frmStudent.txtMother.Text = xrow("MothersName").ToString
                    frmStudent.txtFather.Text = xrow("FathersName").ToString
                    Dim age = 0
                    With frmStudent.dtBirthdate.Value
                        Dim datenow As DateTime = New DateTime(Now.Year, .Month, .Day)
                        age = Now.Year - .Year
                        If datenow > Now Then age -= 1
                        frmStudent.txtage.Text = age
                    End With

                Next
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub

End Class

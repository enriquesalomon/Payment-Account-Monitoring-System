Public Class UserAccount
    Sub userlist()
        Try
            frmUser.dtgUserList.Rows.Clear()
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select * from UserAccount where RestrictionLevel <> 'Super Administrator' order by ID DESC"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "UserAccount")
            mydataTable = mydataset.Tables("UserAccount")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                frmUser.dtgUserList.ColumnCount = 9

                frmUser.dtgUserList.Columns(0).HeaderText = "USER ID"
                frmUser.dtgUserList.Columns(0).Width = 100
                frmUser.dtgUserList.Columns(0).Name = "userid"
                frmUser.dtgUserList.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

                frmUser.dtgUserList.Columns(1).HeaderText = "FULLNAME"
                frmUser.dtgUserList.Columns(1).Width = 150
                frmUser.dtgUserList.Columns(1).Name = "fullname"
                frmUser.dtgUserList.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

                frmUser.dtgUserList.Columns(2).HeaderText = "ADDRESS"
                frmUser.dtgUserList.Columns(2).Width = 150
                frmUser.dtgUserList.Columns(2).Name = "address"
                frmUser.dtgUserList.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

                frmUser.dtgUserList.Columns(3).HeaderText = "CONTACT NO"
                frmUser.dtgUserList.Columns(3).Width = 100
                frmUser.dtgUserList.Columns(3).Name = "contactno"
                frmUser.dtgUserList.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

                frmUser.dtgUserList.Columns(4).HeaderText = "USER LEVEL"
                frmUser.dtgUserList.Columns(4).Width = 100
                frmUser.dtgUserList.Columns(4).Name = "userlevel"
                frmUser.dtgUserList.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

                frmUser.dtgUserList.Columns(5).HeaderText = "USERNAME"
                frmUser.dtgUserList.Columns(5).Width = 80
                frmUser.dtgUserList.Columns(5).Name = "username"
                frmUser.dtgUserList.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter


                frmUser.dtgUserList.Columns(6).HeaderText = "PASSWORD"
                frmUser.dtgUserList.Columns(6).Width = 80
                frmUser.dtgUserList.Columns(6).Name = "password"
                frmUser.dtgUserList.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter


                frmUser.dtgUserList.Columns(7).HeaderText = "DATE ADDED"
                frmUser.dtgUserList.Columns(7).Width = 80
                frmUser.dtgUserList.Columns(7).Name = "dateadded"
                frmUser.dtgUserList.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

                frmUser.dtgUserList.Columns(8).HeaderText = "DATE MODIFIED"
                frmUser.dtgUserList.Columns(8).Width = 80
                frmUser.dtgUserList.Columns(8).Name = "datamodified"
                frmUser.dtgUserList.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                Dim num As Integer = 0
                While mysqlreader.Read
                    num += 1
                    Dim nrow As String() = New String() {mysqlreader("ID").ToString, mysqlreader("Firstname").ToString + " " + mysqlreader("Middlename").ToString + " " + mysqlreader("Lastname").ToString, mysqlreader("address").ToString, mysqlreader("contactno").ToString, mysqlreader("restrictionlevel").ToString, mysqlreader("UserName").ToString, mysqlreader("UserPassword").ToString, mysqlreader("DateInserted").ToString, mysqlreader("DateModified").ToString}
                    frmUser.dtgUserList.Rows.Add(nrow)
                End While
                frmUser.lblrecordcount.Text = "Record Count: " & num
            End If

            mysqlreader.Close()
            mydataTable.Rows.Clear()
            mydataset.Clear()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub


    Sub SaveEditRecords()
        If frmUser.txtFirstname.Text = "" Then
            MsgBox("Firstname is Required")
            Exit Sub
        End If
        If frmUser.txtLastname.Text = "" Then
            MsgBox("Lastname is Required")
            Exit Sub
        End If
        If frmUser.cmbUserlevel.Text = Nothing Then
            MsgBox("User Level is Required")
            Exit Sub
        End If
        If frmUser.txtUsername.Text = Nothing Then
            MsgBox("User Name is Required")
            Exit Sub
        End If
        If frmUser.txtPassword.Text = Nothing Then
            MsgBox("Password is Required")
            Exit Sub
        End If
        If lsaving Then
            getUserrID(frmUser.txtCode.Text)
            If MessageBox.Show("Add this New Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                ' getClientNo(txtclientNo.Text)
                connect(condbPOS)
                mycommand = mysqlconn.CreateCommand
                mycommand.CommandText = "INSERT INTO UserAccount VALUES ('" & frmUser.txtCode.Text & "','" & frmUser.txtFirstname.Text & "','" & Trim(frmUser.txtMiddlename.Text) & "','" & Trim(frmUser.txtLastname.Text) & "','" & Trim(frmUser.txtUsername.Text) & "','" & Trim(frmUser.txtPassword.Text) & "','" & Trim(frmUser.cmbUserlevel.Text) & "','" & Trim(frmUser.txtAddress.Text) & "','" & Trim(frmUser.txtContactNo.Text) & "','" & Format(DateAndTime.Now, "Short Date") & "','" & Format(DateAndTime.Now, "Short Date") & "')"
                mycommand.ExecuteNonQuery()
                MsgBox("New User has been successfully added!", MsgBoxStyle.Information)

                frmUser.ClearMe()
                userlist()
                frmUser.DisablerControls()
            End If
        Else
            If frmUser.txtCode.Text = Nothing Then
                Exit Sub
            End If

            If MessageBox.Show("Are you sure you want to Update this Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    connect(condbPOS)
                    mycommand = mysqlconn.CreateCommand
                    mycommand.CommandText = "UPDATE UserAccount set Firstname='" & frmUser.txtFirstname.Text & "',Middlename='" & frmUser.txtMiddlename.Text & "',Lastname='" & frmUser.txtLastname.Text & "',UserName='" & frmUser.txtUsername.Text & "',UserPassword='" & frmUser.txtPassword.Text & "',RestrictionLevel='" & frmUser.cmbUserlevel.Text & "',Address='" & frmUser.txtAddress.Text & "',ContactNo='" & frmUser.txtContactNo.Text & "',DateModified='" & Format(DateAndTime.Now, "Short Date") & "' where ID ='" & frmUser.txtCode.Text & "'"
                    mycommand.ExecuteNonQuery()
                    MsgBox("Record was Successfully Updated!", MsgBoxStyle.Information)
                    frmUser.ClearMe()
                    userlist()
                    frmUser.DisablerControls()
                    frmUser.btnNew.Enabled = True
                    frmUser.btnEdit.Enabled = False
                    frmUser.btnSave.Enabled = False
                Catch ex As Exception
                    MsgBox("ERROR:" & ex.Message & ex.Source)

                End Try
            End If

        End If

    End Sub
    Sub delete()
        If MessageBox.Show("Are you sure you want to delete this Record  " & vbNewLine & " " & vbNewLine & "", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Try
                connect(condbPOS)
                mycommand = mysqlconn.CreateCommand
                mycommand.CommandText = "DELETE from UserAccount where ID ='" & frmUser.txtCode.Text & "'"
                mycommand.ExecuteNonQuery()
                MsgBox("Data was Successfully Deleted!", MsgBoxStyle.Information)
                frmUser.ClearMe()
                userlist()
                frmUser.DisablerControls()
            Catch ex As Exception
                MsgBox("ERROR:" & ex.Message & ex.Source)
                frmUser.ClearMe()
            End Try

        End If
    End Sub
End Class

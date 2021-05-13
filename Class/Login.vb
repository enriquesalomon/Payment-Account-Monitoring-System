Public Class Login
    Sub VerifyUser()
        Try
            If frmMain.txtpassword.Text = "" And frmMain.txtusername.Text = "" Then
                MessageBox.Show("Please enter username or password", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "SELECT * FROM UserAccount where UserName='" & Trim(frmMain.txtusername.Text) & "' and UserPassword='" & Trim(frmMain.txtpassword.Text) & "'"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "UserAccount")
            mydataTable = mydataset.Tables("UserAccount")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                While mysqlreader.Read()
                    Username = mysqlreader("UserName").ToString
                    password = mysqlreader("UserPassword").ToString
                    Restrictionlevel = mysqlreader("RestrictionLevel").ToString
                    UserID = mysqlreader("ID").ToString
                    UserFullname = mysqlreader("Firstname").ToString + " " + mysqlreader("Lastname").ToString
                    frmMain.ToolStripMenuItem6.Text = "Logged In: " + UserFullname
                End While
            Else
                password = password
                'frmMain.lblusername.Text = Username
            End If
            If Trim(password) = Trim(frmMain.txtpassword.Text) And frmMain.txtusername.Text = Trim(Username) Then
                MessageBox.Show("Access successfully Granted", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                frmMain.txtpassword.Text = ""
                frmMain.txtusername.Text = ""
                frmMain.panelLogin.Visible = False
                frmMain.MenuStrip1.Enabled = True
                frmMain.lblDescLogin.Visible = True
                frmMain.lblDescLogin.Text = "Welcome" & Space(1) & Username & ","
            Else
                MessageBox.Show("Access denied! Invalid username or password", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                frmMain.txtpassword.Focus()
            End If

            mysqlreader.Close()
            mysqlconn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, " Error !!")
        End Try
    End Sub
End Class

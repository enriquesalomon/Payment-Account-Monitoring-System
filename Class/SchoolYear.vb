Public Class SchoolYear
    Sub SaveEditRecords()
        If frmSchoolYear.cmbFrom.Text = "" Then
            MessageBox.Show("Please enter Year From!", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If frmSchoolYear.cmbTo.Text = "" Then
            MessageBox.Show("Please enter Year To!", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If frmSchoolYear.cmbStatus.Text = "" Then
            MessageBox.Show("Please enter School YEar Status!", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If CDbl(frmSchoolYear.cmbFrom.Text) >= CDbl(frmSchoolYear.cmbTo.Text) Then
            MessageBox.Show("Invalid School Year Range To!", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If lsaving Then


            If MessageBox.Show("Add this new Data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                getSYID(frmSchoolYear.lblCode.Text)
                connect(condbPOS)
                mycommand = mysqlconn.CreateCommand
                mycommand.CommandText = "INSERT INTO SchoolYear VALUES ('" & frmSchoolYear.lblCode.Text & "','" & frmSchoolYear.cmbFrom.Text & "','" & frmSchoolYear.cmbTo.Text & "','" & Format(DateAndTime.Now, "Short Date") & "','" & Format(DateAndTime.Now, "Short Date") & "','" & frmSchoolYear.cmbStatus.Text & "')"
                mycommand.ExecuteNonQuery()
                LoadSYList()
                frmSchoolYear.ClearMe()
                frmSchoolYear.cmbFrom.Focus()
                frmSchoolYear.panelSchoolYear.Visible = False
                frmSchoolYear.dtgSYList.Enabled = True
                frmSchoolYear.btnSave.Enabled = False
                MsgBox("New School Year has been successfully Saved ", MsgBoxStyle.OkOnly, "Message")
                lsaving = False
                frmSchoolYear.btnDelete.Enabled = True
            End If
            lsaving = False

        Else

            If MessageBox.Show("Are you sure you want to Update this Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Try
                    connect(condbPOS)
                    mycommand = mysqlconn.CreateCommand
                    mycommand.CommandText = "UPDATE SchoolYear set SYFrom='" & frmSchoolYear.cmbFrom.Text & "',SYTo='" & frmSchoolYear.cmbTo.Text & "',DateModified='" & Format(DateAndTime.Now, "Short Date") & "',Status='" & frmSchoolYear.cmbStatus.Text & "' where ID ='" & frmSchoolYear.lblCode.Text & "'"
                    mycommand.ExecuteNonQuery()
                    LoadSYList()
                    frmSchoolYear.ClearMe()
                    frmSchoolYear.cmbFrom.Focus()
                    frmSchoolYear.panelSchoolYear.Visible = False
                    frmSchoolYear.btnNew.Enabled = True
                    frmSchoolYear.dtgSYList.Enabled = True
                    frmSchoolYear.btnDelete.Enabled = True
                    frmSchoolYear.btnSave.Enabled = False
                    MsgBox("Student Record has been successfully updated ", MsgBoxStyle.OkOnly, "Message")
                Catch ex As Exception
                    MsgBox("ERROR:" & ex.Message & ex.Source)

                End Try
            End If


        End If

    End Sub

    Sub delete()
        If MessageBox.Show("Are you sure you want to delete this Record  " & vbNewLine & " " & vbNewLine & "  ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Try
                connect(condbPOS)
                mycommand = mysqlconn.CreateCommand
                mycommand.CommandText = "DELETE from SchoolYear where ID ='" & frmSchoolYear.lblCode.Text & "'"
                mycommand.ExecuteNonQuery()
                MsgBox("Data was Successfully Deleted!", MsgBoxStyle.Information)
                LoadSYList()
                frmSchoolYear.ClearMe()

            Catch ex As Exception
                MsgBox("ERROR:" & ex.Message & ex.Source)
                '///  frmUserManagement.ClearMe()
            End Try

        End If
    End Sub
    Sub loaddtg()
        frmSchoolYear.dtgSYList.ColumnCount = 4

        frmSchoolYear.dtgSYList.Columns(0).HeaderText = "NO."
        frmSchoolYear.dtgSYList.Columns(0).Width = 50
        frmSchoolYear.dtgSYList.Columns(0).Name = "no"
        frmSchoolYear.dtgSYList.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmSchoolYear.dtgSYList.Columns(1).HeaderText = "SY ID"
        frmSchoolYear.dtgSYList.Columns(1).Width = 100
        frmSchoolYear.dtgSYList.Columns(1).Name = "id"
        frmSchoolYear.dtgSYList.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmSchoolYear.dtgSYList.Columns(2).HeaderText = "SY From-To"
        frmSchoolYear.dtgSYList.Columns(2).Width = 150
        frmSchoolYear.dtgSYList.Columns(2).Name = "from"
        frmSchoolYear.dtgSYList.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmSchoolYear.dtgSYList.Columns(3).HeaderText = "Status"
        frmSchoolYear.dtgSYList.Columns(3).Width = 100
        frmSchoolYear.dtgSYList.Columns(3).Name = "status"
        frmSchoolYear.dtgSYList.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter


    End Sub

    Sub LoadSYList()
        Try
            frmSchoolYear.dtgSYList.Rows.Clear()
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            If searching = True Then
            Else
                mycommand.CommandText = "Select * from SchoolYear"
            End If

            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "SchoolYear")
            mydataTable = mydataset.Tables("SchoolYear")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                Dim nos As Integer = 0
                While mysqlreader.Read
                    nos += 1
                    Dim nrow As String() = New String() {nos.ToString, mysqlreader("ID").ToString, mysqlreader("SYFrom").ToString + " - " + mysqlreader("SYTo").ToString, mysqlreader("Status").ToString}
                    frmSchoolYear.dtgSYList.Rows.Add(nrow)
                End While

            End If
            Dim no As Integer = 0
            For Each RW As DataGridViewRow In frmSchoolYear.dtgSYList.Rows
                no += 1
            Next
            mysqlreader.Close()
            mydataTable.Rows.Clear()
            mydataset.Clear()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub



    Public Sub LoadSYData()
        Dim GridRow As DataGridViewRow = frmSchoolYear.dtgSYList.CurrentRow

        For Each datagrd As DataGridViewRow In frmSchoolYear.dtgSYList.SelectedRows
            frmSchoolYear.lblCode.Text = CStr(GridRow.Cells.Item("id").Value)
        Next datagrd
        Try

            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select * from SchoolYear where ID='" & frmSchoolYear.lblCode.Text & "'"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "SchoolYear")
            mydataTable = mydataset.Tables("SchoolYear")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                For Each xrow As DataRow In mydataTable.Rows
                    frmSchoolYear.lblCode.Text = xrow("ID").ToString
                    frmSchoolYear.cmbFrom.Text = xrow("SYFrom").ToString
                    frmSchoolYear.cmbTo.Text = xrow("SYTo").ToString
                    frmSchoolYear.cmbStatus.Text = xrow("Status").ToString
                Next
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub

End Class

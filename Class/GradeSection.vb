Public Class GradeSection
    Sub SaveEditRecords()
        If frmGradeLevel.txtGradeSection.Text = "" Then
            MessageBox.Show("Please enter Grade and Section!", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If lsaving Then


            If MessageBox.Show("Add this new Data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                getGradeSectionID(frmGradeLevel.lblCode.Text)
                connect(condbPOS)
                mycommand = mysqlconn.CreateCommand
                mycommand.CommandText = "INSERT INTO GradeSection VALUES ('" & frmGradeLevel.lblCode.Text & "','" & frmGradeLevel.txtGradeSection.Text & "','" & Format(DateAndTime.Now, "Short Date") & "','" & Format(DateAndTime.Now, "Short Date") & "')"
                mycommand.ExecuteNonQuery()
                LoadList()
                frmGradeLevel.ClearMe()
                frmGradeLevel.txtGradeSection.Focus()
                frmGradeLevel.panel.Visible = False
                frmGradeLevel.dtgList.Enabled = True
                frmGradeLevel.btnSave.Enabled = False
                MsgBox("New Record has been successfully Saved ", MsgBoxStyle.OkOnly, "Message")
                lsaving = False
                frmGradeLevel.btnDelete.Enabled = True
            End If
            lsaving = False

        Else

            If MessageBox.Show("Are you sure you want to Update this Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Try
                    connect(condbPOS)
                    mycommand = mysqlconn.CreateCommand
                    mycommand.CommandText = "UPDATE GradeSection set GradeSection='" & frmGradeLevel.txtGradeSection.Text & "',DateModified='" & Format(DateAndTime.Now, "Short Date") & "' where ID ='" & frmGradeLevel.lblCode.Text & "'"
                    mycommand.ExecuteNonQuery()
                    LoadList()
                    frmGradeLevel.ClearMe()
                    frmGradeLevel.txtGradeSection.Focus()
                    frmGradeLevel.panel.Visible = False
                    frmGradeLevel.btnNew.Enabled = True
                    frmGradeLevel.dtgList.Enabled = True
                    frmGradeLevel.btnDelete.Enabled = True
                    frmGradeLevel.btnSave.Enabled = False
                    MsgBox("Record has been successfully updated ", MsgBoxStyle.OkOnly, "Message")
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
                mycommand.CommandText = "DELETE from GradeSection where ID ='" & frmGradeLevel.lblCode.Text & "'"
                mycommand.ExecuteNonQuery()
                MsgBox("Data was Successfully Deleted!", MsgBoxStyle.Information)
                LoadList()
                frmGradeLevel.ClearMe()

            Catch ex As Exception
                MsgBox("ERROR:" & ex.Message & ex.Source)
                '///  frmUserManagement.ClearMe()
            End Try

        End If
    End Sub

    Sub loaddtg()
        frmGradeLevel.dtgList.ColumnCount = 3

        frmGradeLevel.dtgList.Columns(0).HeaderText = "NO."
        frmGradeLevel.dtgList.Columns(0).Width = 50
        frmGradeLevel.dtgList.Columns(0).Name = "no"
        frmGradeLevel.dtgList.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmGradeLevel.dtgList.Columns(1).HeaderText = "SY ID"
        frmGradeLevel.dtgList.Columns(1).Width = 100
        frmGradeLevel.dtgList.Columns(1).Name = "id"
        frmGradeLevel.dtgList.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmGradeLevel.dtgList.Columns(2).HeaderText = "Grade & Section"
        frmGradeLevel.dtgList.Columns(2).Width = 150
        frmGradeLevel.dtgList.Columns(2).Name = "from"
        frmGradeLevel.dtgList.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter



    End Sub

    Sub LoadList()
        Try
            frmGradeLevel.dtgList.Rows.Clear()
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            If searching = True Then
            Else
                mycommand.CommandText = "Select * from GradeSection"
            End If

            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "GradeSection")
            mydataTable = mydataset.Tables("GradeSection")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                Dim nos As Integer = 0
                While mysqlreader.Read
                    nos += 1
                    Dim nrow As String() = New String() {nos.ToString, mysqlreader("ID").ToString, mysqlreader("GradeSection").ToString}
                    frmGradeLevel.dtgList.Rows.Add(nrow)
                End While

            End If
            Dim no As Integer = 0
            For Each RW As DataGridViewRow In frmGradeLevel.dtgList.Rows
                no += 1
            Next
            mysqlreader.Close()
            mydataTable.Rows.Clear()
            mydataset.Clear()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub



    Public Sub LoadData()
        Dim GridRow As DataGridViewRow = frmGradeLevel.dtgList.CurrentRow

        For Each datagrd As DataGridViewRow In frmGradeLevel.dtgList.SelectedRows
            frmGradeLevel.lblCode.Text = CStr(GridRow.Cells.Item("id").Value)
        Next datagrd
        Try

            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select * from GradeSection where ID='" & frmGradeLevel.lblCode.Text & "'"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "SchoolYear")
            mydataTable = mydataset.Tables("SchoolYear")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                For Each xrow As DataRow In mydataTable.Rows
                    frmGradeLevel.lblCode.Text = xrow("ID").ToString
                    frmGradeLevel.txtGradeSection.Text = xrow("GradeSection").ToString
                Next
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub
End Class

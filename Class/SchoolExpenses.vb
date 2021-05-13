Public Class SchoolExpenses
    Sub SaveEditRecords()
        If frmSchoolExpenses.txtParticular.Text = "" Then
            MessageBox.Show("Please enter Particular!", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If frmSchoolExpenses.cmbCategory.Text = "" Then
            MessageBox.Show("Please select Category!", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If frmSchoolExpenses.txtAmount.Text = "" Then
            MessageBox.Show("Please enter Amount!", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If frmSchoolExpenses.cmbSY.Text = "" Then
            MessageBox.Show("Please select Shool Year", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If lsaving Then


            If MessageBox.Show("Add this new Data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                getSchoolExpenseID(frmSchoolExpenses.lblCode.Text)
                connect(condbPOS)
                mycommand = mysqlconn.CreateCommand
                mycommand.CommandText = "INSERT INTO SchoolExpenses VALUES ('" & frmSchoolExpenses.lblCode.Text & "','" & frmSchoolExpenses.txtParticular.Text & "','" & frmSchoolExpenses.cmbCategory.Text & "','" & frmSchoolExpenses.txtAmount.Text & "','" & frmSchoolExpenses.cmbSY.Text & "','" & Format(DateAndTime.Now, "Short Date") & "','" & Format(DateAndTime.Now, "Short Date") & "')"
                mycommand.ExecuteNonQuery()
                LoadList()
                frmSchoolExpenses.ClearMe()
                frmSchoolExpenses.txtParticular.Focus()
                frmSchoolExpenses.panelExpenses.Visible = False
                frmSchoolExpenses.dtgList.Enabled = True
                frmSchoolExpenses.btnSave.Enabled = False
                MsgBox("New Record has been successfully Saved ", MsgBoxStyle.OkOnly, "Message")
                lsaving = False
                frmSchoolExpenses.btnDelete.Enabled = True
            End If
            lsaving = False

        Else

            If MessageBox.Show("Are you sure you want to Update this Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Try
                    connect(condbPOS)
                    mycommand = mysqlconn.CreateCommand
                    mycommand.CommandText = "UPDATE SchoolExpenses set Particular='" & frmSchoolExpenses.txtParticular.Text & "',Category='" & frmSchoolExpenses.cmbCategory.Text & "',Amount='" & frmSchoolExpenses.txtAmount.Text & "',SY='" & frmSchoolExpenses.cmbCategory.Text & "',DateModified='" & Format(DateAndTime.Now, "Short Date") & "' where ID ='" & frmSchoolExpenses.lblCode.Text & "'"
                    mycommand.ExecuteNonQuery()
                    LoadList()
                    frmSchoolExpenses.ClearMe()
                    frmSchoolExpenses.txtParticular.Focus()
                    frmSchoolExpenses.panelExpenses.Visible = False
                    frmSchoolExpenses.btnNew.Enabled = True
                    frmSchoolExpenses.dtgList.Enabled = True
                    frmSchoolExpenses.btnDelete.Enabled = True
                    frmSchoolExpenses.btnSave.Enabled = False
                    MsgBox("Record has been successfully updated ", MsgBoxStyle.OkOnly, "Message")
                Catch ex As Exception
                    MsgBox("ERROR:" & ex.Message & ex.Source)

                End Try
            End If


        End If

    End Sub

    Sub loadSY()
        Try
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select * from SchoolYear"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "SchoolYear")
            mydataTable = mydataset.Tables("SchoolYear")
            mysqlreader = mycommand.ExecuteReader()
            While mysqlreader.Read()
                frmSchoolExpenses.cmbSY.Items.Add(mysqlreader("SYFrom").ToString + "-" + mysqlreader("SYFrom").ToString)
            End While
            mysqlreader.Close()
            mysqlconn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")

        End Try

    End Sub
    Sub delete()
        If MessageBox.Show("Are you sure you want to delete this Record  " & vbNewLine & " " & vbNewLine & "  ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Try
                connect(condbPOS)
                mycommand = mysqlconn.CreateCommand
                mycommand.CommandText = "DELETE from SchoolExpenses where ID ='" & frmSchoolExpenses.lblCode.Text & "'"
                mycommand.ExecuteNonQuery()
                MsgBox("Data was Successfully Deleted!", MsgBoxStyle.Information)
                LoadList()
                frmSchoolExpenses.ClearMe()

            Catch ex As Exception
                MsgBox("ERROR:" & ex.Message & ex.Source)
                '///  frmUserManagement.ClearMe()
            End Try

        End If
    End Sub
    Sub loaddtg()
        frmSchoolExpenses.dtgList.ColumnCount = 6

        frmSchoolExpenses.dtgList.Columns(0).HeaderText = "NO."
        frmSchoolExpenses.dtgList.Columns(0).Width = 50
        frmSchoolExpenses.dtgList.Columns(0).Name = "no"
        frmSchoolExpenses.dtgList.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmSchoolExpenses.dtgList.Columns(1).HeaderText = "ID"
        frmSchoolExpenses.dtgList.Columns(1).Width = 100
        frmSchoolExpenses.dtgList.Columns(1).Name = "id"
        frmSchoolExpenses.dtgList.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmSchoolExpenses.dtgList.Columns(2).HeaderText = "Particular"
        frmSchoolExpenses.dtgList.Columns(2).Width = 300
        frmSchoolExpenses.dtgList.Columns(2).Name = "particular"
        frmSchoolExpenses.dtgList.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmSchoolExpenses.dtgList.Columns(3).HeaderText = "Category"
        frmSchoolExpenses.dtgList.Columns(3).Width = 200
        frmSchoolExpenses.dtgList.Columns(3).Name = "category"
        frmSchoolExpenses.dtgList.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmSchoolExpenses.dtgList.Columns(4).HeaderText = "Amount"
        frmSchoolExpenses.dtgList.Columns(4).Width = 100
        frmSchoolExpenses.dtgList.Columns(4).Name = "amount"
        frmSchoolExpenses.dtgList.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmSchoolExpenses.dtgList.Columns(5).HeaderText = "School Year"
        frmSchoolExpenses.dtgList.Columns(5).Width = 100
        frmSchoolExpenses.dtgList.Columns(5).Name = "schoolyear"
        frmSchoolExpenses.dtgList.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter


    End Sub

    Sub LoadList()
        Try
            frmSchoolExpenses.dtgList.Rows.Clear()
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            If searching = True Then
            Else
                mycommand.CommandText = "Select * from SchoolExpenses"
            End If

            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "SchoolExpenses")
            mydataTable = mydataset.Tables("SchoolExpenses")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                Dim nos As Integer = 0
                While mysqlreader.Read
                    nos += 1
                    Dim nrow As String() = New String() {nos.ToString, mysqlreader("ID").ToString, mysqlreader("Particular").ToString, mysqlreader("Category").ToString, mysqlreader("Amount").ToString, mysqlreader("SY").ToString}
                    frmSchoolExpenses.dtgList.Rows.Add(nrow)
                End While

            End If
            Dim no As Integer = 0
            For Each RW As DataGridViewRow In frmSchoolExpenses.dtgList.Rows
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
        Dim GridRow As DataGridViewRow = frmSchoolExpenses.dtgList.CurrentRow

        For Each datagrd As DataGridViewRow In frmSchoolExpenses.dtgList.SelectedRows
            frmSchoolExpenses.lblCode.Text = CStr(GridRow.Cells.Item("id").Value)
        Next datagrd
        Try

            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select * from SchoolExpenses where ID='" & frmSchoolExpenses.lblCode.Text & "'"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "SchoolExpenses")
            mydataTable = mydataset.Tables("SchoolExpenses")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                For Each xrow As DataRow In mydataTable.Rows
                    frmSchoolExpenses.lblCode.Text = xrow("ID").ToString
                    frmSchoolExpenses.txtParticular.Text = xrow("Particular").ToString
                    frmSchoolExpenses.cmbCategory.Text = xrow("Category").ToString
                    frmSchoolExpenses.txtAmount.Text = xrow("Amount").ToString
                    frmSchoolExpenses.cmbSY.Text = xrow("SY").ToString
                Next
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub
End Class

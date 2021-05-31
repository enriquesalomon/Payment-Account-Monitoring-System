Public Class SchoolFees
    Sub SaveEditRecords()
        If frmSchoolFees.txtParticular.Text = "" Then
            MessageBox.Show("Please enter Particular!", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If frmSchoolFees.txtDescription.Text = "" Then
            MessageBox.Show("Please enter Description!", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If frmSchoolFees.txtAmount.Text = "" Then
            MessageBox.Show("Please enter Amount!", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If frmSchoolFees.cmbSY.Text = "" Then
            MessageBox.Show("Please select Shool Year", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If frmSchoolFees.lblCode.Text = "code" Then
            Exit Sub
        End If


        If lsaving Then


            If MessageBox.Show("Add this new Data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                getSchoolFeesID(frmSchoolFees.lblCode.Text)
                connect(condbPOS)
                mycommand = mysqlconn.CreateCommand
                mycommand.CommandText = "INSERT INTO SchoolFees VALUES ('" & frmSchoolFees.lblCode.Text & "','" & frmSchoolFees.txtParticular.Text & "','" & frmSchoolFees.txtDescription.Text & "','" & frmSchoolFees.txtAmount.Text & "','" & frmSchoolFees.cmbSY.Text & "','" & Format(DateAndTime.Now, "Short Date") & "','" & Format(DateAndTime.Now, "Short Date") & "')"
                mycommand.ExecuteNonQuery()
                LoadList()
                frmSchoolFees.ClearMe()
                frmSchoolFees.txtParticular.Focus()
                frmSchoolFees.panelFee.Visible = False
                frmSchoolFees.dtgList.Enabled = True
                frmSchoolFees.btnSave.Enabled = False
                MsgBox("New Record has been successfully Saved ", MsgBoxStyle.OkOnly, "Message")
                lsaving = False
                frmSchoolFees.btnDelete.Enabled = True
            End If
            lsaving = False

        Else

            If MessageBox.Show("Are you sure you want to Update this Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Try
                    connect(condbPOS)
                    mycommand = mysqlconn.CreateCommand
                    mycommand.CommandText = "UPDATE SchoolFees set Particular='" & frmSchoolFees.txtParticular.Text & "',Description='" & frmSchoolFees.txtDescription.Text & "',Amount='" & frmSchoolFees.txtAmount.Text & "',SY='" & frmSchoolFees.cmbSY.Text & "',DateModified='" & Format(DateAndTime.Now, "Short Date") & "' where ID ='" & frmSchoolFees.lblCode.Text & "'"
                    mycommand.ExecuteNonQuery()
                    LoadList()
                    frmSchoolFees.ClearMe()
                    frmSchoolFees.txtParticular.Focus()
                    frmSchoolFees.panelFee.Visible = False
                    frmSchoolFees.btnNew.Enabled = True
                    frmSchoolFees.dtgList.Enabled = True
                    frmSchoolFees.btnDelete.Enabled = True
                    frmSchoolFees.btnSave.Enabled = False
                    MsgBox("Record has been successfully updated ", MsgBoxStyle.OkOnly, "Message")
                Catch ex As Exception
                    MsgBox("ERROR:" & ex.Message & ex.Source)

                End Try
            End If


        End If

    End Sub

    Sub loadSY()
        Try
            frmSchoolFees.cmbSY.Items.Clear()
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select * from SchoolYear"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "SchoolYear")
            mydataTable = mydataset.Tables("SchoolYear")
            mysqlreader = mycommand.ExecuteReader()
            While mysqlreader.Read()
                frmSchoolFees.cmbSY.Items.Add(mysqlreader("SYFrom").ToString + "-" + mysqlreader("SYTo").ToString)
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
                mycommand.CommandText = "DELETE from SchoolFees where ID ='" & frmSchoolFees.lblCode.Text & "'"
                mycommand.ExecuteNonQuery()
                MsgBox("Data was Successfully Deleted!", MsgBoxStyle.Information)
                LoadList()
                frmSchoolFees.ClearMe()

            Catch ex As Exception
                MsgBox("ERROR:" & ex.Message & ex.Source)
                '///  frmUserManagement.ClearMe()
            End Try

        End If
    End Sub
    Sub loaddtg()
        frmSchoolFees.dtgList.ColumnCount = 6

        frmSchoolFees.dtgList.Columns(0).HeaderText = "NO."
        frmSchoolFees.dtgList.Columns(0).Width = 50
        frmSchoolFees.dtgList.Columns(0).Name = "no"
        frmSchoolFees.dtgList.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmSchoolFees.dtgList.Columns(1).HeaderText = "ID"
        frmSchoolFees.dtgList.Columns(1).Width = 100
        frmSchoolFees.dtgList.Columns(1).Name = "id"
        frmSchoolFees.dtgList.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmSchoolFees.dtgList.Columns(2).HeaderText = "Particular"
        frmSchoolFees.dtgList.Columns(2).Width = 300
        frmSchoolFees.dtgList.Columns(2).Name = "particular"
        frmSchoolFees.dtgList.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmSchoolFees.dtgList.Columns(3).HeaderText = "Description"
        frmSchoolFees.dtgList.Columns(3).Width = 200
        frmSchoolFees.dtgList.Columns(3).Name = "decription"
        frmSchoolFees.dtgList.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmSchoolFees.dtgList.Columns(4).HeaderText = "Amount"
        frmSchoolFees.dtgList.Columns(4).Width = 100
        frmSchoolFees.dtgList.Columns(4).Name = "amount"
        frmSchoolFees.dtgList.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmSchoolFees.dtgList.Columns(5).HeaderText = "School Year"
        frmSchoolFees.dtgList.Columns(5).Width = 100
        frmSchoolFees.dtgList.Columns(5).Name = "schoolyear"
        frmSchoolFees.dtgList.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter


    End Sub

    Sub LoadList()
        Try
            frmSchoolFees.dtgList.Rows.Clear()
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            If searching = True Then
            Else
                mycommand.CommandText = "Select * from SchoolFees"
            End If

            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "SchoolFees")
            mydataTable = mydataset.Tables("SchoolFees")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                Dim nos As Integer = 0
                While mysqlreader.Read
                    nos += 1
                    Dim nrow As String() = New String() {nos.ToString, mysqlreader("ID").ToString, mysqlreader("Particular").ToString, mysqlreader("Description").ToString, mysqlreader("Amount").ToString, mysqlreader("SY").ToString}
                    frmSchoolFees.dtgList.Rows.Add(nrow)
                End While

            End If
            Dim no As Integer = 0
            For Each RW As DataGridViewRow In frmSchoolFees.dtgList.Rows
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
        Dim GridRow As DataGridViewRow = frmSchoolFees.dtgList.CurrentRow

        For Each datagrd As DataGridViewRow In frmSchoolFees.dtgList.SelectedRows
            frmSchoolFees.lblCode.Text = CStr(GridRow.Cells.Item("id").Value)
        Next datagrd
        Try

            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select * from SchoolFees where ID='" & frmSchoolFees.lblCode.Text & "'"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "SchoolFees")
            mydataTable = mydataset.Tables("SchoolFees")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                For Each xrow As DataRow In mydataTable.Rows
                    frmSchoolFees.lblCode.Text = xrow("ID").ToString
                    frmSchoolFees.txtParticular.Text = xrow("Particular").ToString
                    frmSchoolFees.txtDescription.Text = xrow("Description").ToString
                    frmSchoolFees.txtAmount.Text = xrow("Amount").ToString
                    frmSchoolFees.cmbSY.Text = xrow("SY").ToString
                Next
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub

    Sub loaddtgReport()
        frmReportSchoolFeesList.dtgList.ColumnCount = 6

        frmReportSchoolFeesList.dtgList.Columns(0).HeaderText = "NO."
        frmReportSchoolFeesList.dtgList.Columns(0).Width = 50
        frmReportSchoolFeesList.dtgList.Columns(0).Name = "no"
        frmReportSchoolFeesList.dtgList.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportSchoolFeesList.dtgList.Columns(1).HeaderText = "ID"
        frmReportSchoolFeesList.dtgList.Columns(1).Width = 100
        frmReportSchoolFeesList.dtgList.Columns(1).Name = "id"
        frmReportSchoolFeesList.dtgList.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportSchoolFeesList.dtgList.Columns(2).HeaderText = "Particular"
        frmReportSchoolFeesList.dtgList.Columns(2).Width = 250
        frmReportSchoolFeesList.dtgList.Columns(2).Name = "particular"
        frmReportSchoolFeesList.dtgList.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportSchoolFeesList.dtgList.Columns(3).HeaderText = "Description"
        frmReportSchoolFeesList.dtgList.Columns(3).Width = 200
        frmReportSchoolFeesList.dtgList.Columns(3).Name = "decription"
        frmReportSchoolFeesList.dtgList.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportSchoolFeesList.dtgList.Columns(4).HeaderText = "Amount"
        frmReportSchoolFeesList.dtgList.Columns(4).Width = 100
        frmReportSchoolFeesList.dtgList.Columns(4).Name = "amount"
        frmReportSchoolFeesList.dtgList.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportSchoolFeesList.dtgList.Columns(5).HeaderText = "School Year"
        frmReportSchoolFeesList.dtgList.Columns(5).Width = 100
        frmReportSchoolFeesList.dtgList.Columns(5).Name = "schoolyear"
        frmReportSchoolFeesList.dtgList.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter


    End Sub

    Sub LoadListReport()

        Try
            frmReportSchoolFeesList.dtgList.Rows.Clear()
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            If searching = True Then
            Else
                mycommand.CommandText = "Select * from SchoolFees where SY= '" & Trim(frmReportSchoolFeesList.cmbSY.Text) & "'"
            End If

            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "SchoolFees")
            mydataTable = mydataset.Tables("SchoolFees")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                Dim nos As Integer = 0
                While mysqlreader.Read
                    nos += 1
                    Dim nrow As String() = New String() {nos.ToString, mysqlreader("ID").ToString, mysqlreader("Particular").ToString, mysqlreader("Description").ToString, mysqlreader("Amount").ToString, mysqlreader("SY").ToString}
                    frmReportSchoolFeesList.dtgList.Rows.Add(nrow)
                End While

            End If
            Dim no As Integer = 0
            For Each RW As DataGridViewRow In frmReportSchoolFeesList.dtgList.Rows
                no += 1
            Next
            frmReportSchoolFeesList.lblrecordcount.Text = "Record Count: " & no
            mysqlreader.Close()
            mydataTable.Rows.Clear()
            mydataset.Clear()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub



    Sub loadSYReport()

        frmReportSchoolFeesList.cmbSY.Items.Clear()
        Call connect(condbPOS)
        mycommand = mysqlconn.CreateCommand
        mycommand.CommandText = "Select * from SchoolYear"
        myadapter.SelectCommand = mycommand
        myadapter.Fill(mydataset, "SchoolYear")
        mydataTable = mydataset.Tables("SchoolYear")
        mysqlreader = mycommand.ExecuteReader()
        While mysqlreader.Read()
            frmReportSchoolFeesList.cmbSY.Items.Add(mysqlreader("SYFrom").ToString + "-" + mysqlreader("SYTo").ToString)

        End While
        mysqlreader.Close()
        mysqlconn.Close()
    End Sub
End Class

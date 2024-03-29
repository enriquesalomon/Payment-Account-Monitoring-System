﻿Public Class SchoolExpenses
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
            MessageBox.Show("Please select School Year", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If frmSchoolExpenses.dtExpenseDate.Text = "" Then
            MessageBox.Show("Please select Date of Expense", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If lsaving Then


            If MessageBox.Show("Add this new Data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                getSchoolExpenseID(frmSchoolExpenses.lblCode.Text)
                connect(condbPOS)
                mycommand = mysqlconn.CreateCommand
                mycommand.CommandText = "INSERT INTO SchoolExpenses VALUES ('" & frmSchoolExpenses.lblCode.Text & "','" & frmSchoolExpenses.txtParticular.Text & "','" & frmSchoolExpenses.cmbCategory.Text & "','" & frmSchoolExpenses.txtAmount.Text & "','" & frmSchoolExpenses.cmbSY.Text & "','" & Format(DateAndTime.Now, "Short Date") & "','" & Format(DateAndTime.Now, "Short Date") & "','" & frmSchoolExpenses.dtExpenseDate.Text & "')"
                mycommand.ExecuteNonQuery()

                saveSalesMonthly()
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
                    mycommand.CommandText = "UPDATE SchoolExpenses set Particular='" & frmSchoolExpenses.txtParticular.Text & "',Category='" & frmSchoolExpenses.cmbCategory.Text & "',Amount='" & frmSchoolExpenses.txtAmount.Text & "',SY='" & frmSchoolExpenses.cmbSY.Text & "',DateModified='" & Format(DateAndTime.Now, "Short Date") & "',ExpenseDate='" & frmSchoolExpenses.dtExpenseDate.Text & "' where ID ='" & frmSchoolExpenses.lblCode.Text & "'"
                    mycommand.ExecuteNonQuery()
                    saveSalesMonthly()
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
            frmSchoolExpenses.cmbSY.Items.Clear()
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select * from SchoolYear"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "SchoolYear")
            mydataTable = mydataset.Tables("SchoolYear")
            mysqlreader = mycommand.ExecuteReader()
            While mysqlreader.Read()
                frmSchoolExpenses.cmbSY.Items.Add(mysqlreader("SYFrom").ToString + "-" + mysqlreader("SYTo").ToString)
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


    Sub saveSalesMonthly()
        'Dim year, monthdt As Int32
        'year = frmSchoolExpenses.dtExpenseDate.Value.Year
        'monthdt = frmSchoolExpenses.dtExpenseDate.Value.Month
        'MsgBox(year)
        'MsgBox(monthdt)
        'Dim query As String = ""
        'connect(condbPOS) : mycommand = mysqlconn.CreateCommand
        'mycommand.CommandText = "SELECT * FROM ExpenseSummary where Month ='" & month(monthdt) & "' and  Year ='" & (year).ToString & "'  "
        'mycommand.ExecuteNonQuery()
        'myadapter.SelectCommand = mycommand
        'mysqlreader = mycommand.ExecuteReader
        'If mydataTable.Rows.Count > 0 Then
        '    Dim sales As Double
        '    If mysqlreader.Read Then
        '        sales = mysqlreader("Total")
        '    End If
        '    query = "UPDATE ExpenseSummary set Total ='" & sales + CDbl(frmSchoolExpenses.txtAmount.Text) & "'  where Month ='" & month(monthdt) & "'  and  Year ='" & (Now.Year).ToString & "'"
        'Else
        '    query = "INSERT INTO ExpenseSummary VALUES('" & month(monthdt) & "','" & (year).ToString & "','" & frmSchoolExpenses.txtAmount.Text & "')"

        'End If

        ''If mysqlreader.Read Then
        ''    Dim sales As Double = mysqlreader("Total")
        ''    query = "UPDATE ExpenseSummary set TotalSales ='" & sales + CDbl(frmSchoolExpenses.txtAmount.Text) & "'  where Month ='" & month(monthdt) & "'  and  Year ='" & (Now.Year).ToString & "'"
        ''Else
        ''    query = "INSERT INTO ExpenseSummary VALUES('" & month(monthdt) & "','" & (year).ToString & "','" & frmSchoolExpenses.txtAmount.Text & "')"

        ''End If
        'connect(condbPOS)
        'mycommand = mysqlconn.CreateCommand
        'mycommand.CommandText = query
        'mycommand.ExecuteNonQuery()


        Dim year, monthdt As Int32
        year = frmSchoolExpenses.dtExpenseDate.Value.Year
        monthdt = frmSchoolExpenses.dtExpenseDate.Value.Month
        Dim query As String = ""

        connect(condbPOS)
        mycommand = mysqlconn.CreateCommand
        mycommand.CommandText = "SELECT * FROM ExpenseSummary where Month ='" & month(monthdt) & "' and  Year ='" & (year).ToString & "'  "
        mycommand.ExecuteNonQuery()
        myadapter.SelectCommand = mycommand
        mysqlreader = mycommand.ExecuteReader

        If mysqlreader.Read Then
            Dim sales As Double = mysqlreader("Total")
            query = "UPDATE ExpenseSummary set Total ='" & sales + CDbl(frmSchoolExpenses.txtAmount.Text) & "'  where Month ='" & month(monthdt) & "'  and  Year ='" & (Now.Year).ToString & "'"
        Else
            'query = "UPDATE ExpenseSummary set Total ='" & CDbl(frmSchoolExpenses.txtAmount.Text) & "'  where Month ='" & month(monthdt) & "'  and  Year ='" & (Now.Year).ToString & "'"

            query = "INSERT INTO ExpenseSummary VALUES('" & month(monthdt) & "','" & (year).ToString & "','" & frmSchoolExpenses.txtAmount.Text & "')"

        End If
        connect(condbPOS)
        mycommand = mysqlconn.CreateCommand
        mycommand.CommandText = query
        mycommand.ExecuteNonQuery()
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

        frmSchoolExpenses.dtgList.Columns(5).HeaderText = "Expense Date"
        frmSchoolExpenses.dtgList.Columns(5).Width = 70
        frmSchoolExpenses.dtgList.Columns(5).Name = "dateexpense"
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
                    Dim nrow As String() = New String() {nos.ToString, mysqlreader("ID").ToString, mysqlreader("Particular").ToString, mysqlreader("Category").ToString, mysqlreader("Amount").ToString, mysqlreader("ExpenseDate").ToString}
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
                    'frmSchoolExpenses.cmbSY.Text = xrow("SY").ToString
                    frmSchoolExpenses.dtExpenseDate.Text = xrow("ExpenseDate").ToString
                Next
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub


    Sub loaddtgReport()
        frmReportExpensesList.dtgList.ColumnCount = 7

        frmReportExpensesList.dtgList.Columns(0).HeaderText = "NO."
        frmReportExpensesList.dtgList.Columns(0).Width = 50
        frmReportExpensesList.dtgList.Columns(0).Name = "no"
        frmReportExpensesList.dtgList.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportExpensesList.dtgList.Columns(1).HeaderText = "ID"
        frmReportExpensesList.dtgList.Columns(1).Width = 100
        frmReportExpensesList.dtgList.Columns(1).Name = "id"
        frmReportExpensesList.dtgList.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportExpensesList.dtgList.Columns(2).HeaderText = "Particular"
        frmReportExpensesList.dtgList.Columns(2).Width = 300
        frmReportExpensesList.dtgList.Columns(2).Name = "particular"
        frmReportExpensesList.dtgList.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportExpensesList.dtgList.Columns(3).HeaderText = "Category"
        frmReportExpensesList.dtgList.Columns(3).Width = 200
        frmReportExpensesList.dtgList.Columns(3).Name = "category"
        frmReportExpensesList.dtgList.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportExpensesList.dtgList.Columns(4).HeaderText = "Amount"
        frmReportExpensesList.dtgList.Columns(4).Width = 100
        frmReportExpensesList.dtgList.Columns(4).Name = "amount"
        frmReportExpensesList.dtgList.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportExpensesList.dtgList.Columns(5).HeaderText = "School Year"
        frmReportExpensesList.dtgList.Columns(5).Width = 100
        frmReportExpensesList.dtgList.Columns(5).Name = "schoolyear"
        frmReportExpensesList.dtgList.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportExpensesList.dtgList.Columns(6).HeaderText = "Date of Expense"
        frmReportExpensesList.dtgList.Columns(6).Width = 100
        frmReportExpensesList.dtgList.Columns(6).Name = "dateexpense"
        frmReportExpensesList.dtgList.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter


    End Sub

    Sub LoadListReport()
        Try
            frmReportExpensesList.dtgList.Rows.Clear()
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            If searching = True Then
            Else
                mycommand.CommandText = "Select * from SchoolExpenses  where SY= '" & Trim(frmReportExpensesList.cmbSY.Text) & "'"
            End If

            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "SchoolExpenses")
            mydataTable = mydataset.Tables("SchoolExpenses")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                Dim nos As Integer = 0
                While mysqlreader.Read
                    nos += 1
                    Dim nrow As String() = New String() {nos.ToString, mysqlreader("ID").ToString, mysqlreader("Particular").ToString, mysqlreader("Category").ToString, mysqlreader("Amount").ToString, mysqlreader("SY").ToString, mysqlreader("ExpenseDate").ToString}
                    frmReportExpensesList.dtgList.Rows.Add(nrow)
                End While

            End If
            Dim no As Integer = 0
            For Each RW As DataGridViewRow In frmReportExpensesList.dtgList.Rows
                no += 1
            Next
            frmReportExpensesList.lblrecordcount.Text = "Record Count: " & no
            mysqlreader.Close()
            mydataTable.Rows.Clear()
            mydataset.Clear()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub

    Sub loadSYReport()

        frmReportExpensesList.cmbSY.Items.Clear()
        Call connect(condbPOS)
        mycommand = mysqlconn.CreateCommand
        mycommand.CommandText = "Select * from SchoolYear"
        myadapter.SelectCommand = mycommand
        myadapter.Fill(mydataset, "SchoolYear")
        mydataTable = mydataset.Tables("SchoolYear")
        mysqlreader = mycommand.ExecuteReader()
        While mysqlreader.Read()
            frmReportExpensesList.cmbSY.Items.Add(mysqlreader("SYFrom").ToString + "-" + mysqlreader("SYTo").ToString)

        End While
        mysqlreader.Close()
        mysqlconn.Close()
    End Sub
End Class

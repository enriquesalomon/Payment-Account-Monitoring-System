Public Class Payments
    Sub loaddtgTransactions()
        frmPayments.dtgSales.ColumnCount = 9

        frmPayments.dtgSales.Columns(0).HeaderText = "NO."
        frmPayments.dtgSales.Columns(0).Width = 50
        frmPayments.dtgSales.Columns(0).Name = "no"
        frmPayments.dtgSales.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmPayments.dtgSales.Columns(1).HeaderText = "TXN#"
        frmPayments.dtgSales.Columns(1).Width = 100
        frmPayments.dtgSales.Columns(1).Name = "txn"
        frmPayments.dtgSales.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmPayments.dtgSales.Columns(2).HeaderText = "ACCT#"
        frmPayments.dtgSales.Columns(2).Width = 100
        frmPayments.dtgSales.Columns(2).Name = "acctno"
        frmPayments.dtgSales.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmPayments.dtgSales.Columns(3).HeaderText = "STUDENT ID"
        frmPayments.dtgSales.Columns(3).Width = 100
        frmPayments.dtgSales.Columns(3).Name = "studId"
        frmPayments.dtgSales.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmPayments.dtgSales.Columns(4).HeaderText = "STUDENT NAME"
        frmPayments.dtgSales.Columns(4).Width = 250
        frmPayments.dtgSales.Columns(4).Name = "fullname"
        frmPayments.dtgSales.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmPayments.dtgSales.Columns(5).HeaderText = "GENDER"
        frmPayments.dtgSales.Columns(5).Width = 100
        frmPayments.dtgSales.Columns(5).Name = "gender"
        frmPayments.dtgSales.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter


        frmPayments.dtgSales.Columns(6).HeaderText = "GRADE-SECTION"
        frmPayments.dtgSales.Columns(6).Width = 150
        frmPayments.dtgSales.Columns(6).Name = "gradesection"
        frmPayments.dtgSales.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmPayments.dtgSales.Columns(7).HeaderText = "AMOUNT"
        frmPayments.dtgSales.Columns(7).Width = 100
        frmPayments.dtgSales.Columns(7).Name = "amountpaid"
        frmPayments.dtgSales.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmPayments.dtgSales.Columns(8).HeaderText = "DATE OF PAYMENT"
        frmPayments.dtgSales.Columns(8).Width = 150
        frmPayments.dtgSales.Columns(8).Name = "dateofpayment"
        frmPayments.dtgSales.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

    End Sub
    Sub LoadListTransaction()
        Try
            frmPayments.dtgSales.Rows.Clear()
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            If searching = True Then
                mycommand.CommandText = "Select * from Transactions where ID Like '%" & frmPayments.txtsearch.Text & "%' OR StudentAccountID Like '%" & frmPayments.txtsearch.Text & "%' AND Void='NULL'"
            Else
                mycommand.CommandText = "Select * from Transactions where SchoolYearID= '" & SchoolYearID & "' AND Void='NULL'"
            End If

            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "Transactions")
            mydataTable = mydataset.Tables("Transactions")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                Dim nos As Integer = 0
                While mysqlreader.Read


                    xtable.Rows.Clear()
                    xdataset.Clear()
                    mycommand = mysqlconn.CreateCommand
                    mycommand.CommandText = "Select * from (Transactions inner join Student on Student.ID = Transactions.StudentID) where Transactions.StudentID  ='" & mysqlreader("StudentID").ToString & "'"
                    Dim fname As String = ""
                    Dim gender As String = ""
                    myadapter.SelectCommand = mycommand
                    myadapter.Fill(xdataset, "Transactions")
                    xtable = xdataset.Tables("Transactions")
                    If xtable.Rows.Count > 0 Then
                        For Each str As DataRow In xtable.Rows
                            fname = str("Fname") + " " + str("Mname") + " " + str("Lname")
                            gender = str("Gender")
                        Next
                    End If
                    xtable.Rows.Clear()
                    xdataset.Clear()

                    nos += 1
                    Dim nrow As String() = New String() {nos.ToString, mysqlreader("ID").ToString, mysqlreader("StudentAccountID").ToString, mysqlreader("StudentID").ToString, fname, gender, mysqlreader("GradeSection").ToString, mysqlreader("AmountPaid").ToString, mysqlreader("PaymentDate").ToString}
                    frmPayments.dtgSales.Rows.Add(nrow)
                End While

            End If
            'Dim no As Integer = 0
            'Dim totalpayable As Double = 0
            'For Each RW As DataGridViewRow In frmPayments.dtgSchoolFee.Rows
            '    no += 1
            '    totalpayable += CDbl(RW.Cells(2).Value)
            'Next
            'frmPayments.txtTotalpayable.Text = totalpayable

            mysqlreader.Close()
            mydataTable.Rows.Clear()
            mydataset.Clear()
            mypayments.getTotalPayment()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub

    Sub loaddtgSchoolFees()
        frmPayments.dtgSchoolFee.ColumnCount = 3

        frmPayments.dtgSchoolFee.Columns(0).HeaderText = "NO."
        frmPayments.dtgSchoolFee.Columns(0).Width = 50
        frmPayments.dtgSchoolFee.Columns(0).Name = "no"
        frmPayments.dtgSchoolFee.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmPayments.dtgSchoolFee.Columns(1).HeaderText = "Particular"
        frmPayments.dtgSchoolFee.Columns(1).Width = 250
        frmPayments.dtgSchoolFee.Columns(1).Name = "particular"
        frmPayments.dtgSchoolFee.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmPayments.dtgSchoolFee.Columns(2).HeaderText = "Amount"
        frmPayments.dtgSchoolFee.Columns(2).Width = 50
        frmPayments.dtgSchoolFee.Columns(2).Name = "amount"
        frmPayments.dtgSchoolFee.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter



    End Sub

    Sub LoadListSchoolFees()
        Try
            frmPayments.dtgSchoolFee.Rows.Clear()
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            If searching = True Then
            Else
                mycommand.CommandText = "Select * from SchoolFees where SY= '" & SchoolYearData & "'"
            End If

            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "SchoolFees")
            mydataTable = mydataset.Tables("SchoolFees")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                Dim nos As Integer = 0
                While mysqlreader.Read
                    nos += 1
                    Dim nrow As String() = New String() {nos.ToString, mysqlreader("Particular").ToString, mysqlreader("Amount").ToString}
                    frmPayments.dtgSchoolFee.Rows.Add(nrow)
                End While

            End If
            Dim no As Integer = 0
            Dim totalpayable As Double = 0
            For Each RW As DataGridViewRow In frmPayments.dtgSchoolFee.Rows
                no += 1
                totalpayable += CDbl(RW.Cells(2).Value)
            Next
            frmPayments.txtTotalpayable.Text = totalpayable

            mysqlreader.Close()
            mydataTable.Rows.Clear()
            mydataset.Clear()
            mypayments.getTotalPayment()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub

    Sub SaveEditRecords()


        If lsaving Then

            If frmPayments.txtAmountPaid.Text = "" Then
                Exit Sub
            End If
            If frmPayments.txtAccountID.Text = "" Then
                Exit Sub
            End If

            If CDbl(frmPayments.txtbalance.Text) = 0 Then
                Exit Sub
            End If
            If CDbl(frmPayments.txtAmountPaid.Text) = 0 Then
                Exit Sub
            End If
            If CDbl(frmPayments.txtAmountPaid.Text) > CDbl(frmPayments.txtbalance.Text) Then
                MessageBox.Show("Amount to Pay should not be greater than the Balance", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim balance As Double = 0
            Dim amountpay As Double = 0
            Dim newbalance As Double = 0
            balance = CDbl(frmPayments.txtbalance.Text)
            amountpay = CDbl(frmPayments.txtAmountPaid.Text)
            newbalance = balance - amountpay


            If MessageBox.Show("Accept this Payment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                connect(condbPOS)
                mycommand = mysqlconn.CreateCommand
                mycommand.CommandText = "INSERT INTO Transactions VALUES ('" & frmPayments.txtTransID.Text & "','" & frmPayments.txtAccountID.Text & "','" & frmPayments.txtStudentCode.Text & "','" & SchoolYearID & "','" & frmPayments.txtGradeSection.Text & "','" & frmPayments.txtTotalpayable.Text & "','" & frmPayments.txtbalance.Text & "','" & frmPayments.dtpaymentDate.Text & "','" & frmPayments.txtAmountPaid.Text & "','" & UserID & "','" & Format(DateAndTime.Now, "Short Date") & "','Null')"
                mycommand.ExecuteNonQuery()
                LoadListTransaction()
                frmPayments.cleartx()
                frmPayments.panelPayment.Visible = False
                MsgBox("Transaction has been successfully Saved ", MsgBoxStyle.OkOnly, "Message")
                lsaving = False

            End If
            lsaving = False

        Else
            If frmVoidTransactionConfirmation.txtTxnNo.Text = Nothing Then
                Exit Sub
            End If

            If MessageBox.Show("Are you sure you want to Void this Transaction?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    connect(condbPOS)
                    mycommand = mysqlconn.CreateCommand
                    mycommand.CommandText = "UPDATE Transactions set Void='Yes' where ID ='" & frmVoidTransactionConfirmation.txtTxnNo.Text & "'"

                    mycommand.ExecuteNonQuery()
                    MsgBox("Transaction record was successfully Voided!", MsgBoxStyle.Information)
                    frmVoidTransactionConfirmation.txtTxnNo.Clear()
                    frmVoidTransactionConfirmation.Close()
                    LoadListTransaction()
                Catch ex As Exception
                    MsgBox("ERROR:" & ex.Message & ex.Source)

                End Try
            End If

        End If

    End Sub

    Sub getTotalPayment()
        Try

            Dim totalpaid As String
            totalpaid = ""


            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = " Select SUM (AmountPaid) as totalpayment from Transactions where StudentAccountID  ='" & frmPayments.txtAccountID.Text & "' AND  SchoolYearID  ='" & SchoolYearID & "' AND Void='NULL'"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "Transactions")
            mydataTable = mydataset.Tables("Transactions")
            mysqlreader = mycommand.ExecuteReader()
            While mysqlreader.Read()
                totalpaid = mysqlreader("totalpayment").ToString
            End While
            If totalpaid = Nothing Then
                totalpaid = 0
            End If

            frmPayments.txttotalPayment.Text = CDbl(totalpaid)
            frmPayments.txtbalance.Text = CDbl(frmPayments.txtTotalpayable.Text) - CDbl(totalpaid)
            mysqlreader.Close()
            mysqlconn.Close()


        Catch ex As Exception

        End Try
    End Sub

    Sub loadSY()

        frmReportPaymentList.cmbSY.Items.Clear()
        Call connect(condbPOS)
        mycommand = mysqlconn.CreateCommand
        mycommand.CommandText = "Select * from SchoolYear"
        myadapter.SelectCommand = mycommand
        myadapter.Fill(mydataset, "SchoolYear")
        mydataTable = mydataset.Tables("SchoolYear")
        mysqlreader = mycommand.ExecuteReader()
        While mysqlreader.Read()
            frmReportPaymentList.cmbSY.Items.Add(mysqlreader("SYFrom").ToString + "-" + mysqlreader("SYTo").ToString)

        End While
        mysqlreader.Close()
        mysqlconn.Close()
    End Sub
    Sub loaddtgPaymentsReport()
        frmReportPaymentList.dtgSales.ColumnCount = 9

        frmReportPaymentList.dtgSales.Columns(0).HeaderText = "NO."
        frmReportPaymentList.dtgSales.Columns(0).Width = 50
        frmReportPaymentList.dtgSales.Columns(0).Name = "no"
        frmReportPaymentList.dtgSales.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportPaymentList.dtgSales.Columns(1).HeaderText = "TXN#"
        frmReportPaymentList.dtgSales.Columns(1).Width = 100
        frmReportPaymentList.dtgSales.Columns(1).Name = "txn"
        frmReportPaymentList.dtgSales.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportPaymentList.dtgSales.Columns(2).HeaderText = "ACCT#"
        frmReportPaymentList.dtgSales.Columns(2).Width = 100
        frmReportPaymentList.dtgSales.Columns(2).Name = "acctno"
        frmReportPaymentList.dtgSales.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportPaymentList.dtgSales.Columns(3).HeaderText = "STUDENT ID"
        frmReportPaymentList.dtgSales.Columns(3).Width = 100
        frmReportPaymentList.dtgSales.Columns(3).Name = "studId"
        frmReportPaymentList.dtgSales.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportPaymentList.dtgSales.Columns(4).HeaderText = "STUDENT NAME"
        frmReportPaymentList.dtgSales.Columns(4).Width = 250
        frmReportPaymentList.dtgSales.Columns(4).Name = "fullname"
        frmReportPaymentList.dtgSales.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportPaymentList.dtgSales.Columns(5).HeaderText = "GENDER"
        frmReportPaymentList.dtgSales.Columns(5).Width = 100
        frmReportPaymentList.dtgSales.Columns(5).Name = "gender"
        frmReportPaymentList.dtgSales.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter


        frmReportPaymentList.dtgSales.Columns(6).HeaderText = "GRADE-SECTION"
        frmReportPaymentList.dtgSales.Columns(6).Width = 150
        frmReportPaymentList.dtgSales.Columns(6).Name = "gradesection"
        frmReportPaymentList.dtgSales.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportPaymentList.dtgSales.Columns(7).HeaderText = "AMOUNT"
        frmReportPaymentList.dtgSales.Columns(7).Width = 100
        frmReportPaymentList.dtgSales.Columns(7).Name = "amountpaid"
        frmReportPaymentList.dtgSales.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportPaymentList.dtgSales.Columns(8).HeaderText = "DATE OF PAYMENT"
        frmReportPaymentList.dtgSales.Columns(8).Width = 150
        frmReportPaymentList.dtgSales.Columns(8).Name = "dateofpayment"
        frmReportPaymentList.dtgSales.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

    End Sub

    Sub loadPaymentsReport()

        Try
            frmReportPaymentList.SchoolYearIDFilter = ""
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select * from SchoolYear where SYFrom ='" & frmReportPaymentList.SYFrom & "' AND SYTo ='" & frmReportPaymentList.SYTo & "' "
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "SchoolYear")
            mydataTable = mydataset.Tables("SchoolYear")
            mysqlreader = mycommand.ExecuteReader()
            While mysqlreader.Read()
                frmReportPaymentList.SchoolYearIDFilter = mysqlreader("ID").ToString

            End While
            mysqlreader.Close()
            mysqlconn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")

        End Try

        Try
            frmReportPaymentList.dtgSales.Rows.Clear()
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            'If searching = True Then
            '    mycommand.CommandText = "Select * from Transactions where ID Like '%" & frmPayments.txtsearch.Text & "%' OR StudentAccountID Like '%" & frmPayments.txtsearch.Text & "%' AND Void='NULL'"
            'Else
            mycommand.CommandText = "Select * from Transactions where SchoolYearID= '" & frmReportPaymentList.SchoolYearIDFilter & "' AND Void='NULL'"
            'End If

            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "Transactions")
            mydataTable = mydataset.Tables("Transactions")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                Dim nos As Integer = 0
                While mysqlreader.Read


                    xtable.Rows.Clear()
                    xdataset.Clear()
                    mycommand = mysqlconn.CreateCommand
                    mycommand.CommandText = "Select * from (Transactions inner join Student on Student.ID = Transactions.StudentID) where Transactions.StudentID  ='" & mysqlreader("StudentID").ToString & "'"
                    Dim fname As String = ""
                    Dim gender As String = ""
                    myadapter.SelectCommand = mycommand
                    myadapter.Fill(xdataset, "Transactions")
                    xtable = xdataset.Tables("Transactions")
                    If xtable.Rows.Count > 0 Then
                        For Each str As DataRow In xtable.Rows
                            fname = str("Fname") + " " + str("Mname") + " " + str("Lname")
                            gender = str("Gender")
                        Next
                    End If
                    xtable.Rows.Clear()
                    xdataset.Clear()

                    nos += 1
                    Dim nrow As String() = New String() {nos.ToString, mysqlreader("ID").ToString, mysqlreader("StudentAccountID").ToString, mysqlreader("StudentID").ToString, fname, gender, mysqlreader("GradeSection").ToString, mysqlreader("AmountPaid").ToString, mysqlreader("PaymentDate").ToString}
                    frmReportPaymentList.dtgSales.Rows.Add(nrow)
                End While

            End If
            Dim no As Integer = 0
            For Each RW As DataGridViewRow In frmReportPaymentList.dtgSales.Rows
                no += 1
            Next
            frmReportPaymentList.lblrecordcount.Text = "Record Count: " & no

            mysqlreader.Close()
            mydataTable.Rows.Clear()
            mydataset.Clear()
            mypayments.getTotalPayment()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try

    End Sub
















    Sub loadSYVoided()

        frmReportVoidedPaymentList.cmbSY.Items.Clear()
        Call connect(condbPOS)
        mycommand = mysqlconn.CreateCommand
        mycommand.CommandText = "Select * from SchoolYear"
        myadapter.SelectCommand = mycommand
        myadapter.Fill(mydataset, "SchoolYear")
        mydataTable = mydataset.Tables("SchoolYear")
        mysqlreader = mycommand.ExecuteReader()
        While mysqlreader.Read()
            frmReportVoidedPaymentList.cmbSY.Items.Add(mysqlreader("SYFrom").ToString + "-" + mysqlreader("SYTo").ToString)

        End While
        mysqlreader.Close()
        mysqlconn.Close()
    End Sub
    Sub loaddtgVoidedPaymentsReport()
        frmReportVoidedPaymentList.dtgSales.ColumnCount = 8

        frmReportVoidedPaymentList.dtgSales.Columns(0).HeaderText = "NO."
        frmReportVoidedPaymentList.dtgSales.Columns(0).Width = 50
        frmReportVoidedPaymentList.dtgSales.Columns(0).Name = "no"
        frmReportVoidedPaymentList.dtgSales.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportVoidedPaymentList.dtgSales.Columns(1).HeaderText = "TXN#"
        frmReportVoidedPaymentList.dtgSales.Columns(1).Width = 100
        frmReportVoidedPaymentList.dtgSales.Columns(1).Name = "txn"
        frmReportVoidedPaymentList.dtgSales.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportVoidedPaymentList.dtgSales.Columns(2).HeaderText = "ACCT#"
        frmReportVoidedPaymentList.dtgSales.Columns(2).Width = 100
        frmReportVoidedPaymentList.dtgSales.Columns(2).Name = "acctno"
        frmReportVoidedPaymentList.dtgSales.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportVoidedPaymentList.dtgSales.Columns(3).HeaderText = "STUDENT ID"
        frmReportVoidedPaymentList.dtgSales.Columns(3).Width = 100
        frmReportVoidedPaymentList.dtgSales.Columns(3).Name = "studId"
        frmReportVoidedPaymentList.dtgSales.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportVoidedPaymentList.dtgSales.Columns(4).HeaderText = "STUDENT NAME"
        frmReportVoidedPaymentList.dtgSales.Columns(4).Width = 250
        frmReportVoidedPaymentList.dtgSales.Columns(4).Name = "fullname"
        frmReportVoidedPaymentList.dtgSales.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportVoidedPaymentList.dtgSales.Columns(5).HeaderText = "GENDER"
        frmReportVoidedPaymentList.dtgSales.Columns(5).Width = 100
        frmReportVoidedPaymentList.dtgSales.Columns(5).Name = "gender"
        frmReportVoidedPaymentList.dtgSales.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter


        frmReportVoidedPaymentList.dtgSales.Columns(6).HeaderText = "GRADE-SECTION"
        frmReportVoidedPaymentList.dtgSales.Columns(6).Width = 150
        frmReportVoidedPaymentList.dtgSales.Columns(6).Name = "gradesection"
        frmReportVoidedPaymentList.dtgSales.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportVoidedPaymentList.dtgSales.Columns(7).HeaderText = "AMOUNT"
        frmReportVoidedPaymentList.dtgSales.Columns(7).Width = 100
        frmReportVoidedPaymentList.dtgSales.Columns(7).Name = "amountpaid"
        frmReportVoidedPaymentList.dtgSales.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

    End Sub

    Sub loadVoidedPaymentReport()

        Try
            frmReportPaymentList.SchoolYearIDFilter = ""
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select * from SchoolYear where SYFrom ='" & frmReportVoidedPaymentList.SYFrom & "' AND SYTo ='" & frmReportVoidedPaymentList.SYTo & "' "
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "SchoolYear")
            mydataTable = mydataset.Tables("SchoolYear")
            mysqlreader = mycommand.ExecuteReader()
            While mysqlreader.Read()
                frmReportVoidedPaymentList.SchoolYearIDFilter = mysqlreader("ID").ToString

            End While
            mysqlreader.Close()
            mysqlconn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")

        End Try

        Try
            frmReportVoidedPaymentList.dtgSales.Rows.Clear()
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            'If searching = True Then
            '    mycommand.CommandText = "Select * from Transactions where ID Like '%" & frmPayments.txtsearch.Text & "%' OR StudentAccountID Like '%" & frmPayments.txtsearch.Text & "%' AND Void='NULL'"
            'Else
            mycommand.CommandText = "Select * from Transactions where SchoolYearID= '" & frmReportVoidedPaymentList.SchoolYearIDFilter & "' AND Void='Yes'"
            'End If

            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "Transactions")
            mydataTable = mydataset.Tables("Transactions")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                Dim nos As Integer = 0
                While mysqlreader.Read


                    xtable.Rows.Clear()
                    xdataset.Clear()
                    mycommand = mysqlconn.CreateCommand
                    mycommand.CommandText = "Select * from (Transactions inner join Student on Student.ID = Transactions.StudentID) where Transactions.StudentID  ='" & mysqlreader("StudentID").ToString & "'"
                    Dim fname As String = ""
                    Dim gender As String = ""
                    myadapter.SelectCommand = mycommand
                    myadapter.Fill(xdataset, "Transactions")
                    xtable = xdataset.Tables("Transactions")
                    If xtable.Rows.Count > 0 Then
                        For Each str As DataRow In xtable.Rows
                            fname = str("Fname") + " " + str("Mname") + " " + str("Lname")
                            gender = str("Gender")
                        Next
                    End If
                    xtable.Rows.Clear()
                    xdataset.Clear()

                    nos += 1
                    Dim nrow As String() = New String() {nos.ToString, mysqlreader("ID").ToString, mysqlreader("StudentAccountID").ToString, mysqlreader("StudentID").ToString, fname, gender, mysqlreader("GradeSection").ToString, mysqlreader("AmountPaid").ToString, mysqlreader("PaymentDate").ToString}
                    frmReportVoidedPaymentList.dtgSales.Rows.Add(nrow)
                End While

            End If

            Dim no As Integer = 0
            For Each RW As DataGridViewRow In frmReportVoidedPaymentList.dtgSales.Rows
                no += 1
            Next
            frmReportVoidedPaymentList.lblrecordcount.Text = "Record Count: " & no

            mysqlreader.Close()
            mydataTable.Rows.Clear()
            mydataset.Clear()
            mypayments.getTotalPayment()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try

    End Sub
End Class

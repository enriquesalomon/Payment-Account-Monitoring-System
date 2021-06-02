Public Class Ledger

    Sub loadSY()

        frmReportLedger.cmbSY.Items.Clear()
        Call connect(condbPOS)
        mycommand = mysqlconn.CreateCommand
        mycommand.CommandText = "Select * from SchoolYear"
        myadapter.SelectCommand = mycommand
        myadapter.Fill(mydataset, "SchoolYear")
        mydataTable = mydataset.Tables("SchoolYear")
        mysqlreader = mycommand.ExecuteReader()
        While mysqlreader.Read()
            frmReportLedger.cmbSY.Items.Add(mysqlreader("SYFrom").ToString + "-" + mysqlreader("SYTo").ToString)

        End While
        mysqlreader.Close()
        mysqlconn.Close()
    End Sub

    Sub getSchoolFees()
        Try
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            If searching = True Then
            Else
                mycommand.CommandText = "Select * from SchoolFees where SY= '" & frmReportLedger.cmbSY.Text & "'"
            End If

            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "SchoolFees")
            mydataTable = mydataset.Tables("SchoolFees")
            mysqlreader = mycommand.ExecuteReader

            Dim totalfeesamount As Double = 0
            If mydataTable.Rows.Count > 0 Then
                While mysqlreader.Read
                    totalfeesamount += CDbl(mysqlreader("Amount"))
                End While
            End If
            frmReportLedger.txtTotalPayableAmount.Text = Format(CDbl(totalfeesamount), "###,###,###.#0")
            mysqlreader.Close()
            mydataTable.Rows.Clear()
            mydataset.Clear()

        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub
    Sub getTotalPayment()
        Try

            Dim totalpaid As String
            totalpaid = ""


            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = " Select SUM (AmountPaid) as totalpayment from Transactions where StudentAccountID  ='" & frmReportLedger.txtAccountNumber.Text & "' AND  SchoolYearID  ='" & frmReportLedger.SchoolYearIDFilter & "' AND Void='NULL'"
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

            frmReportLedger.txtTotalPaid.Text = Format(CDbl(totalpaid), "###,###,###.#0")
            frmReportLedger.txtRunningBalance.Text = Format(CDbl(frmReportLedger.txtTotalPayableAmount.Text) - CDbl(totalpaid), "###,###,###.#0")
            mysqlreader.Close()
            mysqlconn.Close()


        Catch ex As Exception

        End Try
    End Sub
    Sub getAccountNumber()
        xtable.Rows.Clear()
        xdataset.Clear()
        mycommand = mysqlconn.CreateCommand
        mycommand.CommandText = "Select * from (Admission inner join StudentAccount on Admission.ID = StudentAccount.AdmissionID) where Admission.SchoolYearID  ='" & frmReportLedger.SchoolYearIDFilter & "' AND Admission.StudID='" & frmReportLedger.txtStudentCode.Text & "'"
        myadapter.SelectCommand = mycommand
        myadapter.Fill(xdataset, "StudentAccount")
        xtable = xdataset.Tables("StudentAccount")
        Dim accountno As String = ""
        If xtable.Rows.Count > 0 Then
            For Each str As DataRow In xtable.Rows
                accountno = str("StudentAccount.ID").ToString
            Next
        End If
        frmReportLedger.txtAccountNumber.Text = accountno
        xtable.Rows.Clear()
        xdataset.Clear()
    End Sub


    Sub loaddtgTransactions()
        frmReportLedger.dtgList.ColumnCount = 6

        frmReportLedger.dtgList.Columns(0).HeaderText = "TXN#"
        frmReportLedger.dtgList.Columns(0).Width = 100
        frmReportLedger.dtgList.Columns(0).Name = "txn"
        frmReportLedger.dtgList.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportLedger.dtgList.Columns(1).HeaderText = "DATE"
        frmReportLedger.dtgList.Columns(1).Width = 150
        frmReportLedger.dtgList.Columns(1).Name = "dateofpayment"
        frmReportLedger.dtgList.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportLedger.dtgList.Columns(2).HeaderText = "PARTICULAR"
        frmReportLedger.dtgList.Columns(2).Width = 150
        frmReportLedger.dtgList.Columns(2).Name = "particular"
        frmReportLedger.dtgList.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportLedger.dtgList.Columns(3).HeaderText = "CURRENT BAL"
        frmReportLedger.dtgList.Columns(3).Width = 100
        frmReportLedger.dtgList.Columns(3).Name = "currentbal"
        frmReportLedger.dtgList.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportLedger.dtgList.Columns(4).HeaderText = "AMOUNT PAID"
        frmReportLedger.dtgList.Columns(4).Width = 100
        frmReportLedger.dtgList.Columns(4).Name = "amount"
        frmReportLedger.dtgList.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmReportLedger.dtgList.Columns(5).HeaderText = "REMAINING BAL"
        frmReportLedger.dtgList.Columns(5).Width = 100
        frmReportLedger.dtgList.Columns(5).Name = "remainbal"
        frmReportLedger.dtgList.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

    End Sub

    Sub LoadListTransaction()
        Try
            frmReportLedger.dtgList.Rows.Clear()
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select * from Transactions where StudentAccountID='" & frmReportLedger.txtAccountNumber.Text & "' AND SchoolYearID= '" & frmReportLedger.SchoolYearIDFilter & "' AND Void='NULL'"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "Transactions")
            mydataTable = mydataset.Tables("Transactions")
            mysqlreader = mycommand.ExecuteReader
            Dim totalpaid As Double = 0
            If mydataTable.Rows.Count > 0 Then
                Dim loopint As Integer = 0
                Dim remainbal As Double = 0
                Dim balance As Double = 0
                While mysqlreader.Read
                    totalpaid += CDbl(mysqlreader("AmountPaid"))
                    If loopint = 0 Then
                        balance = CDbl(frmReportLedger.txtTotalPayableAmount.Text)
                        remainbal = CDbl(balance) - CDbl(mysqlreader("AmountPaid"))
                    Else
                        balance = remainbal
                        remainbal = CDbl(balance) - CDbl(mysqlreader("AmountPaid"))
                    End If
                    loopint += 1
                    Dim nrow As String() = New String() {mysqlreader("ID").ToString, mysqlreader("PaymentDate").ToString, "Payment", Format(CDbl(balance), "###,###,###.#0"), Format(CDbl(mysqlreader("AmountPaid")), "###,###,###.#0"), Format(CDbl(remainbal), "###,###,###.#0")}
                    frmReportLedger.dtgList.Rows.Add(nrow)
                End While

            End If
            Dim nrowx As String() = New String() {"", "", "", " Total Paid:", Format(totalpaid, "###,###,###.#0"), ""}
            frmReportLedger.dtgList.Rows.Add(nrowx)
            mysqlreader.Close()
            mydataTable.Rows.Clear()
            mydataset.Clear()
            mypayments.getTotalPayment()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub

End Class

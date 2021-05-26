Public Class Payments

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
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub
    Sub LoadListPayments()

    End Sub

    Sub SaveEditRecords()
        If frmPayments.txtAccountID.Text = "" Then
            Exit Sub
        End If

        If CDbl(frmPayments.txtbalance.Text) = 0 Then
            Exit Sub
        End If
        If CDbl(frmPayments.txtAmountPaid.Text) > CDbl(frmPayments.txtbalance.Text) Then
            MessageBox.Show("Amount to Pay should not be greater than the Balance", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If lsaving Then
            Dim balance As Double = 0
            Dim amountpay As Double = 0
            Dim newbalance As Double = 0
            balance = CDbl(frmPayments.txtbalance.Text)
            amountpay = CDbl(frmPayments.txtAmountPaid.Text)
            newbalance = balance - amountpay


            If MessageBox.Show("Accept this Payment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                getTransID(frmPayments.lbltransID.Text)
                connect(condbPOS)
                mycommand = mysqlconn.CreateCommand
                mycommand.CommandText = "INSERT INTO Transactions VALUES ('" & frmPayments.lbltransID.Text & "','" & frmPayments.txtStudentCode.Text & "','" & SchoolYearID & "','" & frmPayments.txtTotalpayable.Text & "','" & frmPayments.txttotalPayment.Text & "','" & frmPayments.txtbalance.Text & "','" & frmPayments.dtpaymentDate.Text & "','" & frmPayments.txtAmountPaid.Text & "','" & UserID & "','" & Format(DateAndTime.Now, "Short Date") & "')"
                mycommand.ExecuteNonQuery()
                LoadListPayments()
                frmPayments.cleartx()
                frmPayments.panelPayment.Visible = False
                MsgBox("Transaction has been successfully Saved ", MsgBoxStyle.OkOnly, "Message")
                lsaving = False

            End If
            lsaving = False

        Else

        End If

    End Sub
    Sub getTotalPayment()
        Try

            Dim totalpaid As String
            totalpaid = ""


            Call connect(condbPOS)
        mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = " Select SUM (AmountPaid) as totalpayment,SUM(Penalty) as penaltypaid from Transactions where StudentAccountID  ='" & frmPayments.txtAccountID.Text & "'"
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
            MsgBox(CDbl(frmPayments.txtTotalpayable.Text) - CDbl(totalpaid))
            mysqlreader.Close()
            mysqlconn.Close()


        Catch ex As Exception

        End Try
    End Sub
End Class

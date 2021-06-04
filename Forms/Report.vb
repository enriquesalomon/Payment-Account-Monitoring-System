Option Explicit On
Imports CrystalDecisions.CrystalReports.Engine
Public Class Report
    Dim spath As String


    Dim rptAdmissionList, rptSchoolFeesList, rptSchoolExpenseList, rptPaymentList, rptPaymentVoidedList, rptLedger As New ReportDocument

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintMe()
    End Sub
    Private Sub PrintMe()


        Dim dtAdmissionList, dtSchoolFeesList, dtSchoolExpenseList, dtPaymentList, dtPaymentVoidedList, dtStudentsLedger As New DataTable

        If printDoc = "Admission List" Then

            Try
                spath = "" & reportpath & "\CrysAdmissionList.rpt"
                rptAdmissionList.Load(spath)

                With dtAdmissionList
                    .Columns.Add("No")
                    .Columns.Add("ControlNo")
                    .Columns.Add("StudentID")
                    .Columns.Add("Student")
                    .Columns.Add("Gender")
                    .Columns.Add("GradeSection")
                    .Columns.Add("Addedby")
                    .Columns.Add("DateAdded")

                End With

                For Each dr As DataGridViewRow In frmReportAdmissionList.dtgList.Rows
                    dtAdmissionList.Rows.Add(dr.Cells("num").Value, dr.Cells("controlno").Value, dr.Cells("studid").Value, dr.Cells("name").Value, dr.Cells("gender").Value, dr.Cells("section").Value, dr.Cells("addedby").Value, dr.Cells("dateadded").Value)
                Next
                CrystalReportViewer1.Refresh()
                rptAdmissionList.SetDataSource(dtAdmissionList)
                CrystalReportViewer1.ReportSource = rptAdmissionList
                dtAdmissionList.Clear()
                CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Data Error !!")
            End Try
        ElseIf printDoc = "School Fees List" Then

            'Try
            spath = "" & reportpath & "\CrysSchoolFeesList.rpt"
            rptSchoolFeesList.Load(spath)

            With dtSchoolFeesList
                .Columns.Add("No")
                .Columns.Add("ID")
                .Columns.Add("Particular")
                .Columns.Add("Amount")
                .Columns.Add("SchoolYear")

            End With

            For Each dr As DataGridViewRow In frmReportSchoolFeesList.dtgList.Rows
                dtSchoolFeesList.Rows.Add(dr.Cells("no").Value, dr.Cells("id").Value, dr.Cells("particular").Value, dr.Cells("amount").Value, dr.Cells("schoolyear").Value)
            Next
            CrystalReportViewer1.Refresh()
            rptSchoolFeesList.SetDataSource(dtSchoolFeesList)
            CrystalReportViewer1.ReportSource = rptSchoolFeesList
            dtSchoolFeesList.Clear()
            CrystalReportViewer1.Refresh()

        ElseIf printDoc = "School Expense List" Then

            'Try
            spath = "" & reportpath & "\CrysSchoolExpenseList.rpt"
            rptSchoolExpenseList.Load(spath)

            With dtSchoolExpenseList
                .Columns.Add("No")
                .Columns.Add("ID")
                .Columns.Add("Particular")
                .Columns.Add("Category")
                .Columns.Add("Amount")
                .Columns.Add("SchoolYear")

            End With

            For Each dr As DataGridViewRow In frmReportExpensesList.dtgList.Rows
                dtSchoolExpenseList.Rows.Add(dr.Cells("no").Value, dr.Cells("id").Value, dr.Cells("particular").Value, dr.Cells("category").Value, dr.Cells("amount").Value, dr.Cells("schoolyear").Value)
            Next
            CrystalReportViewer1.Refresh()
            rptSchoolExpenseList.SetDataSource(dtSchoolExpenseList)
            CrystalReportViewer1.ReportSource = rptSchoolExpenseList
            dtSchoolExpenseList.Clear()
            CrystalReportViewer1.Refresh()

        ElseIf printDoc = "Payment List" Then

            'Try
            spath = "" & reportpath & "\CrysPaymentList.rpt"
            rptPaymentList.Load(spath)

            With dtPaymentList
                .Columns.Add("No")
                .Columns.Add("Txn")
                .Columns.Add("AcctNo")
                .Columns.Add("StudID")
                .Columns.Add("Name")
                .Columns.Add("Gender")
                .Columns.Add("GradeSection")
                .Columns.Add("Amount")

            End With

            For Each dr As DataGridViewRow In frmReportPaymentList.dtgSales.Rows
                dtPaymentList.Rows.Add(dr.Cells("no").Value, dr.Cells("txn").Value, dr.Cells("acctno").Value, dr.Cells("studID").Value, dr.Cells("fullname").Value, dr.Cells("gender").Value, dr.Cells("gradesection").Value, dr.Cells("amountpaid").Value)
            Next
            CrystalReportViewer1.Refresh()
            rptPaymentList.SetDataSource(dtPaymentList)
            CrystalReportViewer1.ReportSource = rptPaymentList
            dtPaymentList.Clear()
            CrystalReportViewer1.Refresh()

        ElseIf printDoc = "Payment Voided List" Then

            'Try
            spath = "" & reportpath & "\CrysPaymentVoidedList.rpt"
            rptPaymentVoidedList.Load(spath)

            With dtPaymentVoidedList
                .Columns.Add("No")
                .Columns.Add("Txn")
                .Columns.Add("AcctNo")
                .Columns.Add("StudID")
                .Columns.Add("Name")
                .Columns.Add("Gender")
                .Columns.Add("GradeSection")
                .Columns.Add("Amount")

            End With

            For Each dr As DataGridViewRow In frmReportVoidedPaymentList.dtgSales.Rows
                dtPaymentVoidedList.Rows.Add(dr.Cells("no").Value, dr.Cells("txn").Value, dr.Cells("acctno").Value, dr.Cells("studID").Value, dr.Cells("fullname").Value, dr.Cells("gender").Value, dr.Cells("gradesection").Value, dr.Cells("amountpaid").Value)
            Next
            CrystalReportViewer1.Refresh()
            rptPaymentVoidedList.SetDataSource(dtPaymentVoidedList)
            CrystalReportViewer1.ReportSource = rptPaymentVoidedList
            dtPaymentVoidedList.Clear()
            CrystalReportViewer1.Refresh()


        ElseIf printDoc = "Ledger" Then

            'Try
            spath = "" & reportpath & "\CrysLedgerList.rpt"
            rptLedger.Load(spath)

            With dtStudentsLedger
                .Columns.Add("No")
                .Columns.Add("Txn")
                .Columns.Add("AcctNo")
                .Columns.Add("StudID")
                .Columns.Add("Name")
                .Columns.Add("Gender")
                .Columns.Add("GradeSection")
                .Columns.Add("Amount")

            End With

            For Each dr As DataGridViewRow In frmReportLedger.dtgList.Rows
                dtStudentsLedger.Rows.Add(dr.Cells("txn").Value, dr.Cells("dateofpayment").Value, dr.Cells("particular").Value, dr.Cells("currentbal").Value, dr.Cells("amount").Value, dr.Cells("remainbal").Value)
            Next
            CrystalReportViewer1.Refresh()
            rptLedger.SetDataSource(dtStudentsLedger)
            CrystalReportViewer1.ReportSource = rptLedger
            dtStudentsLedger.Clear()
            CrystalReportViewer1.Refresh()
            'Catch ex As Exception
            '    MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Data Error !!")
            'End Try


            'ElseIf printDoc = "Client Ledger" Then
            '    Dim ledgerinstallmentnotx, ledgerclientcodetx, ledgerclientnametx, ledgertotalplanamounttx, ledgerbalancetx, ledgerremainnumpaymenttx As CrystalDecisions.CrystalReports.Engine.TextObject

            '    Try
            '        spath = "" & reportpath & "\CrysClientLedger.rpt"
            '        rptClientLedger.Load(spath)

            '        ledgerinstallmentnotx = rptClientLedger.ReportDefinition.Sections(1).ReportObjects("txtClientCode")
            '        ledgerinstallmentnotx.Text = frmClientLedger.txtInstallmentNo.Text

            '        ledgerclientcodetx = rptClientLedger.ReportDefinition.Sections(1).ReportObjects("txtInstallmentNo")
            '        ledgerclientcodetx.Text = frmClientLedger.txtClientCode.Text

            '        ledgerclientnametx = rptClientLedger.ReportDefinition.Sections(1).ReportObjects("txtClientName")
            '        ledgerclientnametx.Text = frmClientLedger.txtPlanholdername.Text

            '        ledgertotalplanamounttx = rptClientLedger.ReportDefinition.Sections(1).ReportObjects("txtTotalPlanAmount")
            '        ledgertotalplanamounttx.Text = frmClientLedger.txtTotalPlanAmount.Text

            '        ledgerbalancetx = rptClientLedger.ReportDefinition.Sections(1).ReportObjects("txtBalance")
            '        ledgerbalancetx.Text = frmClientLedger.txtRunningBalance.Text

            '        ledgerremainnumpaymenttx = rptClientLedger.ReportDefinition.Sections(1).ReportObjects("txtRemainNumPayment")
            '        ledgerremainnumpaymenttx.Text = frmClientLedger.txtRemaingNumPayment.Text


            '        With dtClientLedger
            '            .Columns.Add("PaymentNo")
            '            .Columns.Add("DatePaid")
            '            .Columns.Add("Particular")
            '            .Columns.Add("CurrentBalance")
            '            .Columns.Add("PastDueAmount")
            '            .Columns.Add("Penalty")
            '            .Columns.Add("AmortPayable")
            '            .Columns.Add("AmountPaid")
            '            .Columns.Add("RemainingBalance")

            '        End With

            '        For Each dr As DataGridViewRow In frmClientLedger.dtgClientLedger.Rows
            '            dtClientLedger.Rows.Add(dr.Cells("id").Value, dr.Cells("datepaid").Value, dr.Cells("particular").Value, dr.Cells("currentbal").Value, dr.Cells("pastdue").Value, dr.Cells("penalty").Value, dr.Cells("amort").Value, dr.Cells("amountpaid").Value, dr.Cells("remainbal").Value)
            '        Next


            '        CrystalReportViewer1.Refresh()
            '        rptClientLedger.SetDataSource(dtClientLedger)
            '        CrystalReportViewer1.ReportSource = rptClientLedger
            '        dtClientLedger.Clear()
            '        CrystalReportViewer1.Refresh()
            '    Catch ex As Exception
            '        MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Data Error !!")
            '    End Try


            'ElseIf printDoc = "Installment List" Then
            '    Try

            '        spath = "" & reportpath & "\CrysInstallmentList.rpt"
            '        rptInstallmentList.Load(spath)

            '        With dtInstallmentList
            '            .Columns.Add("InstallmentNo")
            '            .Columns.Add("ClientCode")
            '            .Columns.Add("ClientName")
            '            .Columns.Add("ItemCode")
            '            .Columns.Add("ItemDescription")
            '            .Columns.Add("InstallmentAmount")
            '            .Columns.Add("PlanDescription")
            '            .Columns.Add("DateApplication")
            '        End With

            '        For Each dr As DataGridViewRow In frmInstallmentApplication.dtgInstallmentApplication.Rows
            '            dtInstallmentList.Rows.Add(dr.Cells("id").Value, dr.Cells("clientcode").Value, dr.Cells("clientname").Value, dr.Cells("itemcode").Value, dr.Cells("itemdescription").Value, dr.Cells("itemprice").Value, dr.Cells("plandescription").Value, dr.Cells("dateaddeds").Value)
            '        Next
            '        CrystalReportViewer1.Refresh()
            '        rptInstallmentList.SetDataSource(dtInstallmentList)
            '        CrystalReportViewer1.ReportSource = rptInstallmentList
            '        dtInstallmentList.Clear()
            '        CrystalReportViewer1.Refresh()
            '    Catch ex As Exception
            '        MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Data Error !!")
            '    End Try

            'ElseIf printDoc = "Account Overdue List" Then
            '    Try

            '        spath = "" & reportpath & "\CrysAccountOverdueList.rpt"
            '        rptAccountOverdueList.Load(spath)

            '        With dtAccountOverdueList
            '            .Columns.Add("No")
            '            .Columns.Add("ClientCode")
            '            .Columns.Add("Fullname")
            '            .Columns.Add("Gender")
            '            .Columns.Add("ContactNo")
            '            .Columns.Add("FBAccount")
            '            .Columns.Add("InstallmentNo")
            '            .Columns.Add("Lapses")
            '            .Columns.Add("Penalty")
            '            .Columns.Add("TotalCollectibles")
            '        End With
            '        Dim num As Integer = 0
            '        For Each dr As DataGridViewRow In frmClientOverdue.dtgClient.Rows
            '            num += 1
            '            dtAccountOverdueList.Rows.Add(num.ToString, dr.Cells("id").Value, dr.Cells("fullname").Value, dr.Cells("gender").Value, dr.Cells("contactno").Value, dr.Cells("fbaccount").Value, dr.Cells("installmentno").Value, dr.Cells("lapses").Value, dr.Cells("penalty").Value, dr.Cells("collectibles").Value)
            '        Next
            '        CrystalReportViewer1.Refresh()
            '        rptAccountOverdueList.SetDataSource(dtAccountOverdueList)
            '        CrystalReportViewer1.ReportSource = rptAccountOverdueList
            '        dtAccountOverdueList.Clear()
            '        CrystalReportViewer1.Refresh()
            '    Catch ex As Exception
            '        MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Data Error !!")
            '    End Try

            'ElseIf printDoc = "Item List" Then

            '    Try


            '        spath = "" & reportpath & "\CrysItemList.rpt"
            '        rptItemList.Load(spath)

            '        With dtItemList
            '            .Columns.Add("No")
            '            .Columns.Add("ItemCode")
            '            .Columns.Add("Category")
            '            .Columns.Add("Description")
            '            .Columns.Add("Model")
            '            .Columns.Add("SupplierPrice")
            '            .Columns.Add("OnCashPrice")
            '            .Columns.Add("InstallmentPrice")
            '            .Columns.Add("DownPaymentPrice")

            '        End With
            '        Dim num As Integer = 0
            '        For Each dr As DataGridViewRow In frmItem.dtgItemList.Rows
            '            num += 1
            '            dtItemList.Rows.Add(num.ToString, dr.Cells("Itemid").Value, dr.Cells("category").Value, dr.Cells("description").Value, dr.Cells("brand").Value, dr.Cells("supprice").Value, dr.Cells("cashprice").Value, dr.Cells("installmentprice").Value, dr.Cells("downpayment").Value)
            '        Next
            '        CrystalReportViewer1.Refresh()
            '        rptItemList.SetDataSource(dtItemList)
            '        CrystalReportViewer1.ReportSource = rptItemList
            '        dtItemList.Clear()
            '        CrystalReportViewer1.Refresh()
            '    Catch ex As Exception
            '        MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Data Error !!")
            '    End Try

            'ElseIf printDoc = "Stock Inventory List" Then

            '    Try


            '        spath = "" & reportpath & "\CrysStockInventoryList.rpt"
            '        rptStockInventoryList.Load(spath)

            '        With dtStockInventoryList
            '            .Columns.Add("No")
            '            .Columns.Add("ItemCode")
            '            .Columns.Add("Category")
            '            .Columns.Add("Description")
            '            .Columns.Add("TotalQuantity")
            '            .Columns.Add("QtyOnHand")
            '            .Columns.Add("QtySold")


            '        End With
            '        Dim num As Integer = 0
            '        For Each dr As DataGridViewRow In frmStockInventory.dtgItemList.Rows
            '            num += 1
            '            dtStockInventoryList.Rows.Add(num.ToString, dr.Cells("Itemid").Value, dr.Cells("category").Value, dr.Cells("description").Value, dr.Cells("totalqty").Value, dr.Cells("qtyonhand").Value, dr.Cells("totalsold").Value)
            '        Next
            '        CrystalReportViewer1.Refresh()
            '        rptStockInventoryList.SetDataSource(dtStockInventoryList)
            '        CrystalReportViewer1.ReportSource = rptStockInventoryList
            '        dtStockInventoryList.Clear()
            '        CrystalReportViewer1.Refresh()
            '    Catch ex As Exception
            '        MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Data Error !!")
            '    End Try

            'ElseIf printDoc = "Item Receiving Entry List" Then

            '    Try


            '        spath = "" & reportpath & "\CrysItemReceivingEntryList.rpt"
            '        rptItemReceivingEntryList.Load(spath)

            '        With dtItemReceivingEntryList
            '            .Columns.Add("No")
            '            .Columns.Add("SupplierID")
            '            .Columns.Add("ItemCode")
            '            .Columns.Add("Description")
            '            .Columns.Add("Category")
            '            .Columns.Add("Quantity")
            '            .Columns.Add("DateAdded")
            '        End With
            '        Dim num As Integer = 0
            '        For Each dr As DataGridViewRow In frmItemReceivingEntry.dtgItemList.Rows
            '            num += 1
            '            dtItemReceivingEntryList.Rows.Add(num.ToString, dr.Cells("supplierid").Value, dr.Cells("itemid").Value, dr.Cells("description").Value, dr.Cells("category").Value, dr.Cells("quantity").Value, dr.Cells("dateadded").Value)
            '        Next
            '        CrystalReportViewer1.Refresh()
            '        rptItemReceivingEntryList.SetDataSource(dtItemReceivingEntryList)
            '        CrystalReportViewer1.ReportSource = rptItemReceivingEntryList
            '        dtItemReceivingEntryList.Clear()
            '        CrystalReportViewer1.Refresh()
            '    Catch ex As Exception
            '        MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Data Error !!")
            '    End Try

            'ElseIf printDoc = "Item Adjustment List" Then

            '    Try


            '        spath = "" & reportpath & "\CrysItemAdjustmentList.rpt"
            '        rptItemAdjustmentList.Load(spath)

            '        With dtItemAdjustmentList
            '            .Columns.Add("No")
            '            .Columns.Add("ItemCode")
            '            .Columns.Add("Description")
            '            .Columns.Add("Category")
            '            .Columns.Add("Quantity")
            '            .Columns.Add("Action")
            '            .Columns.Add("Reason")
            '            .Columns.Add("DateAdded")
            '        End With
            '        Dim num As Integer = 0
            '        For Each dr As DataGridViewRow In frmItemAdjustmentEntry.dtgItemList.Rows
            '            num += 1
            '            dtItemAdjustmentList.Rows.Add(num.ToString, dr.Cells("Itemid").Value, dr.Cells("description").Value, dr.Cells("category").Value, dr.Cells("qty").Value, dr.Cells("action").Value, dr.Cells("reason").Value, dr.Cells("date").Value)
            '        Next
            '        CrystalReportViewer1.Refresh()
            '        rptItemAdjustmentList.SetDataSource(dtItemAdjustmentList)
            '        CrystalReportViewer1.ReportSource = rptItemAdjustmentList
            '        dtItemAdjustmentList.Clear()
            '        CrystalReportViewer1.Refresh()
            '    Catch ex As Exception
            '        MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Data Error !!")
            '    End Try


            'ElseIf printDoc = "Installment Payment List" Then
            '    Try
            '        spath = "" & reportpath & "\CrysInstallmentPayment.rpt"
            '        rptInstallmentPaymentList.Load(spath)

            '        With dtInstallmentPaymentList
            '            .Columns.Add("PayID")
            '            .Columns.Add("InstallmentNo")
            '            .Columns.Add("ClientCode")
            '            .Columns.Add("ClientName")
            '            .Columns.Add("ItemCode")
            '            .Columns.Add("Particular")
            '            .Columns.Add("AmountPaid")
            '            .Columns.Add("DatePaid")
            '        End With

            '        For Each dr As DataGridViewRow In frmSalesEntry.dtgSales.Rows
            '            dtInstallmentPaymentList.Rows.Add(dr.Cells("id").Value, dr.Cells("installmentno").Value, dr.Cells("clientcode").Value, dr.Cells("clientname").Value, dr.Cells("itemcode").Value, dr.Cells("particular").Value, dr.Cells("amounttendered").Value, dr.Cells("dateofpayment").Value)
            '        Next
            '        CrystalReportViewer1.Refresh()
            '        rptInstallmentPaymentList.SetDataSource(dtInstallmentPaymentList)
            '        CrystalReportViewer1.ReportSource = rptInstallmentPaymentList
            '        dtInstallmentPaymentList.Clear()
            '        CrystalReportViewer1.Refresh()
            '    Catch ex As Exception
            '        MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Data Error !!")
            '    End Try



            'ElseIf printDoc = "Payment Installment Receipt" Then
            '    Dim payorpayid, payorname, payorclientcode, payorparticular, payorinstallmentno, payoraddress, payordatepaid, payoramountdue, payortotalamountdue, payorpenalty, payoramountpaid, payorbalance As String
            '    payorpayid = "" : payorname = "" : payorclientcode = "" : payorparticular = "" : payorinstallmentno = "" : payoraddress = "" : payordatepaid = "" : payoramountdue = "" : payortotalamountdue = "" : payorpenalty = "" : payoramountpaid = "" : payorbalance = ""

            '    Dim currentbalance As Double = 0
            '    Try
            '        If receiptfocus = "installment payment due" Then
            '            Call connect(condbPOS)
            '            mycommand = mysqlconn.CreateCommand
            '            mycommand.CommandText = "Select * from (Installment_Payments inner join Client on Client.ID = Installment_Payments.ClientCode) where PayID='" & frmSalesEntry.payid & "'"
            '            myadapter.SelectCommand = mycommand
            '            myadapter.Fill(mydataset, "Installment_Payments")
            '            mydataTable = mydataset.Tables("Installment_Payments")
            '            mysqlreader = mycommand.ExecuteReader
            '            If mydataTable.Rows.Count > 0 Then
            '                For Each xrow As DataRow In mydataTable.Rows
            '                    payorpayid = xrow("PayID").ToString
            '                    payorinstallmentno = xrow("InstallmentNo").ToString
            '                    payorclientcode = xrow("ClientCode").ToString
            '                    payorname = xrow("Fname").ToString + " " + xrow("Mname").ToString + " " + xrow("Lname").ToString
            '                    payoraddress = xrow("Barangay").ToString + " " + xrow("City").ToString + " " + xrow("Province").ToString
            '                    payordatepaid = xrow("DatePaid").ToString
            '                    payorparticular = "Installment Payment"
            '                    payorpenalty = xrow("Penalty").ToString
            '                    payoramountpaid = xrow("AmountPaid").ToString
            '                    currentbalance = xrow("CurrentBalance").ToString
            '                Next
            '            End If
            '            payorbalance = CDbl(currentbalance) - (CDbl(payoramountpaid) - CDbl(payorpenalty))
            '        ElseIf receiptfocus = "installment payment downpayment" Then
            '            Call connect(condbPOS)
            '            mycommand = mysqlconn.CreateCommand
            '            mycommand.CommandText = "Select * from (Installment_DownPayment inner join Client on Client.ID = Installment_DownPayment.ClientCode) where InstallmentNo='" & frmInstallmentDownpayment.installnodp & "'"
            '            myadapter.SelectCommand = mycommand
            '            myadapter.Fill(mydataset, "Installment_Payments")
            '            mydataTable = mydataset.Tables("Installment_Payments")
            '            mysqlreader = mycommand.ExecuteReader
            '            If mydataTable.Rows.Count > 0 Then
            '                For Each xrow As DataRow In mydataTable.Rows
            '                    payorpayid = xrow("InstallmentNo").ToString
            '                    payorclientcode = xrow("ClientCode").ToString
            '                    payorname = xrow("Fname").ToString + " " + xrow("Mname").ToString + " " + xrow("Lname").ToString
            '                    payoraddress = xrow("Barangay").ToString + " " + xrow("City").ToString + " " + xrow("Province").ToString
            '                    payordatepaid = xrow("DatePaid").ToString
            '                    payorparticular = "Installment Down Payment"
            '                    payorpenalty = ""
            '                    payoramountpaid = xrow("Amount").ToString
            '                Next
            '            End If
            '            Call connect(condbPOS)
            '            mycommand = mysqlconn.CreateCommand
            '            mycommand.CommandText = "Select * from InstallmentPlan where InstallmentNo='" & frmInstallmentDownpayment.installnodp & "'"
            '            myadapter.SelectCommand = mycommand
            '            myadapter.Fill(mydataset, "InstallmentPlan")
            '            mydataTable = mydataset.Tables("InstallmentPlan")
            '            mysqlreader = mycommand.ExecuteReader
            '            If mydataTable.Rows.Count > 0 Then
            '                For Each xrow As DataRow In mydataTable.Rows
            '                    currentbalance = xrow("ItemInstallmentPrice").ToString
            '                Next
            '            End If
            '            payorbalance = CDbl(currentbalance) - CDbl(payoramountpaid)
            '        End If

            '        spath = "" & reportpath & "\CrysPaymentInstallmentReceipt.rpt"
            '        rptinstallmentreceipt.Load(spath)
            '        payorpayidtx = rptinstallmentreceipt.ReportDefinition.Sections(3).ReportObjects("txtReferenceNo")
            '        payorpayidtx.Text = payorpayid
            '        payorinstallmentnotx = rptinstallmentreceipt.ReportDefinition.Sections(2).ReportObjects("txtInstallmentNo")
            '        payorinstallmentnotx.Text = payorinstallmentno
            '        payornametx = rptinstallmentreceipt.ReportDefinition.Sections(2).ReportObjects("txtPayorName")
            '        payornametx.Text = payorname
            '        payoraddresstx = rptinstallmentreceipt.ReportDefinition.Sections(2).ReportObjects("txtPayorAddress")
            '        payoraddresstx.Text = payoraddress
            '        payordatepaidtx = rptinstallmentreceipt.ReportDefinition.Sections(2).ReportObjects("txtPayDate")
            '        payordatepaidtx.Text = payordatepaid
            '        payorparticulartx = rptinstallmentreceipt.ReportDefinition.Sections(3).ReportObjects("txtParticular")
            '        payorparticulartx.Text = payorparticular
            '        payorpenaltytx = rptinstallmentreceipt.ReportDefinition.Sections(3).ReportObjects("txtPenalty")
            '        payorpenaltytx.Text = payorpenalty
            '        payoramountpaidtx = rptinstallmentreceipt.ReportDefinition.Sections(3).ReportObjects("txtTotalPayment")
            '        payoramountpaidtx.Text = payoramountpaid
            '        payorbalancetx = rptinstallmentreceipt.ReportDefinition.Sections(3).ReportObjects("txtBalance")
            '        payorbalancetx.Text = payorbalance
            '        CrystalReportViewer1.Refresh()
            '        'rptinstallmentreceipt.SetDataSource(dtinstallmentreceipt)
            '        CrystalReportViewer1.ReportSource = rptinstallmentreceipt
            '        dtinstallmentreceipt.Clear()
            '        CrystalReportViewer1.Refresh()
            '    Catch ex As Exception
            '        MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Data Error !!")
            '    End Try

            'ElseIf printDoc = "Item Sold in POS List" Then

            '    Try


            '        spath = "" & reportpath & "\CrysItemSoldPOS.rpt"
            '        rptitemsoldposlist.Load(spath)

            '        With dtitemsoldposlist
            '            .Columns.Add("No")
            '            .Columns.Add("ItemCode")
            '            .Columns.Add("Category")
            '            .Columns.Add("Description")
            '            .Columns.Add("brand")
            '            .Columns.Add("Quantity")
            '            .Columns.Add("DateSold")

            '        End With

            '        For Each dr As DataGridViewRow In frmSoldStock_POS.dtgItemList.Rows
            '            dtitemsoldposlist.Rows.Add(dr.Cells("no").Value, dr.Cells("Itemid").Value, dr.Cells("category").Value, dr.Cells("description").Value, dr.Cells("brand").Value, dr.Cells("quantity").Value, dr.Cells("datesold").Value)
            '        Next
            '        CrystalReportViewer1.Refresh()
            '        rptitemsoldposlist.SetDataSource(dtitemsoldposlist)
            '        CrystalReportViewer1.ReportSource = rptitemsoldposlist
            '        dtitemsoldposlist.Clear()
            '        CrystalReportViewer1.Refresh()
            '    Catch ex As Exception
            '        MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Data Error !!")
            '    End Try

            'ElseIf printDoc = "Item Sold in Installment List" Then

            '    Try


            '        spath = "" & reportpath & "\CrysItemSoldInstallment.rpt"
            '        rptitemsoldinstallmentlist.Load(spath)

            '        With dtitemsoldinstallmentlist
            '            .Columns.Add("No")
            '            .Columns.Add("ItemCode")
            '            .Columns.Add("Category")
            '            .Columns.Add("Description")
            '            .Columns.Add("brand")
            '            .Columns.Add("DateSold")

            '        End With

            '        For Each dr As DataGridViewRow In frmSoldStock_Installment.dtgItemList.Rows
            '            dtitemsoldinstallmentlist.Rows.Add(dr.Cells("no").Value, dr.Cells("Itemid").Value, dr.Cells("category").Value, dr.Cells("description").Value, dr.Cells("brand").Value, dr.Cells("datesold").Value)
            '        Next
            '        CrystalReportViewer1.Refresh()
            '        rptitemsoldinstallmentlist.SetDataSource(dtitemsoldinstallmentlist)
            '        CrystalReportViewer1.ReportSource = rptitemsoldinstallmentlist
            '        dtitemsoldinstallmentlist.Clear()
            '        CrystalReportViewer1.Refresh()
            '    Catch ex As Exception
            '        MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Data Error !!")
            '    End Try

            'ElseIf printDoc = "Installment Plan Summary List" Then
            '    Dim totamountcollectedtx, totremaincollectiblestx As CrystalDecisions.CrystalReports.Engine.TextObject

            '    Try


            '        spath = "" & reportpath & "\CrysInstallmentPlanSummaryList.rpt"
            '        rptinstallmentplansummarylist.Load(spath)

            '        totamountcollectedtx = rptinstallmentplansummarylist.ReportDefinition.Sections(3).ReportObjects("txtTotCollected")
            '        totamountcollectedtx.Text = frmClientInstallmentPlanSummary.lblTotalCollected.Text
            '        totremaincollectiblestx = rptinstallmentplansummarylist.ReportDefinition.Sections(3).ReportObjects("txtTotCollectibles")
            '        totremaincollectiblestx.Text = frmClientInstallmentPlanSummary.lblTotalCollectibles.Text

            '        With dtinstallmentplansummarylist
            '            .Columns.Add("ID")
            '            .Columns.Add("Fullname")
            '            .Columns.Add("Gender")
            '            .Columns.Add("InstallmentNo")
            '            .Columns.Add("TotPlanAmount")
            '            .Columns.Add("TotalPaid")
            '            .Columns.Add("RemainPayment")
            '            .Columns.Add("RemainBalance")

            '        End With
            '        For Each dr As DataGridViewRow In frmClientInstallmentPlanSummary.dtgClient.Rows

            '            dtinstallmentplansummarylist.Rows.Add(dr.Cells("id").Value, dr.Cells("fullname").Value, dr.Cells("gender").Value, dr.Cells("installmentno").Value, dr.Cells("totplanamount").Value, dr.Cells("totalpaid").Value, dr.Cells("remainpayment").Value, dr.Cells("remainbalance").Value)
            '        Next

            '        CrystalReportViewer1.Refresh()
            '        rptinstallmentplansummarylist.SetDataSource(dtinstallmentplansummarylist)
            '        CrystalReportViewer1.ReportSource = rptinstallmentplansummarylist
            '        dtinstallmentplansummarylist.Clear()
            '        CrystalReportViewer1.Refresh()
            '    Catch ex As Exception
            '        MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Data Error !!")
            '    End Try

            'ElseIf printDoc = "POS Transactions List" Then

            '    Try


            '        spath = "" & reportpath & "\CrysTransactionPOS.rpt"
            '        rpttansactionsposlist.Load(spath)

            '        With dttansactionsposlist
            '            .Columns.Add("No")
            '            .Columns.Add("TxnNo")
            '            .Columns.Add("TotAmount")
            '            .Columns.Add("DiscPercent")
            '            .Columns.Add("Less")
            '            .Columns.Add("NetSales")
            '            .Columns.Add("AmountTendered")
            '            .Columns.Add("Change")
            '            .Columns.Add("TxnDate")
            '            .Columns.Add("User")

            '        End With
            '        Dim netsales As Double = 0
            '        For Each dr As DataGridViewRow In frmTransactions_in_POS.dtgTransaction.Rows
            '            netsales += CDbl(dr.Cells("netsales").Value)
            '            dttansactionsposlist.Rows.Add(dr.Cells("no").Value, dr.Cells("txnno").Value, dr.Cells("totamount").Value, dr.Cells("discperc").Value, dr.Cells("less").Value, dr.Cells("netsales").Value, dr.Cells("amountendered").Value, dr.Cells("change").Value, dr.Cells("txndate").Value, dr.Cells("user").Value)
            '        Next
            '        dttansactionsposlist.Rows.Add("", "", "", "", "    Total:", Format(netsales, "###,###,###.#0"), "", "", "", "")

            '        CrystalReportViewer1.Refresh()
            '        rpttansactionsposlist.SetDataSource(dttansactionsposlist)
            '        CrystalReportViewer1.ReportSource = rpttansactionsposlist
            '        dttansactionsposlist.Clear()
            '        CrystalReportViewer1.Refresh()
            '    Catch ex As Exception
            '        MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Data Error !!")
            '    End Try
        End If

    End Sub
End Class
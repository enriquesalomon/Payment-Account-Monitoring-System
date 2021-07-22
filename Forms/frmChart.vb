

Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmChart
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub frmChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generateGraphYearly()
        generateGraphMonthly()
    End Sub
    Sub generateGraphMonthly()
        '        UTILITY BILL
        'EQUIPMENT REPAIR
        'SCHOOL SUPPLIES
        'SCHOOL IMPROVEMENTS
        'EVENTS


        Dim Months As New List(Of String)
        Dim UTILITYBILLtotal As New List(Of Double)
        Dim EQUIPtotal As New List(Of Double)
        Dim SCHOOLSUPtotal As New List(Of Double)
        Dim SCHOOLIMPtotal As New List(Of Double)
        Dim EVENTStotal As New List(Of Double)


        Call connect(condbPOS)
        mycommand = mysqlconn.CreateCommand
        mycommand.CommandText = "SELECT MONTH(ExpenseDate) as months,SUM(Amount) as Total FROM SchoolExpenses Group By MONTH(ExpenseDate) "
        myadapter.SelectCommand = mycommand
        myadapter.Fill(mydataset, "ExpenseSummary")
        mydataTable = mydataset.Tables("ExpenseSummary")
        mysqlreader = mycommand.ExecuteReader()
        While mysqlreader.Read
            'Months.AddRange(New String() {month(mysqlreader("months"))})
            Months.AddRange(New String() {mysqlreader("months")})
        End While
        mysqlreader.Close()
        mysqlconn.Close()



        For i = 0 To Months.Count - 1

            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "SELECT SUM(Amount) as Total FROM SchoolExpenses WHERE MONTH(ExpenseDate)  ='" & Months(i).ToString & "' AND category ='UTILITY BILL' "
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "ExpenseSummary")
            mydataTable = mydataset.Tables("ExpenseSummary")
            mysqlreader = mycommand.ExecuteReader()
            While mysqlreader.Read
                Dim tot As Double
                If mysqlreader("Total").ToString = "" Then
                    tot = 0.00
                Else
                    tot = mysqlreader("Total")
                End If
                UTILITYBILLtotal.AddRange(New Double() {tot})
            End While
            mysqlreader.Close()
            mysqlconn.Close()

            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "SELECT SUM(Amount) as Total FROM SchoolExpenses WHERE MONTH(ExpenseDate)  ='" & Months(i).ToString & "' AND category ='EQUIPMENT REPAIR' "
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "ExpenseSummary")
            mydataTable = mydataset.Tables("ExpenseSummary")
            mysqlreader = mycommand.ExecuteReader()
            While mysqlreader.Read
                Dim tot As Double
                If mysqlreader("Total").ToString = "" Then
                    tot = 0.00
                Else
                    tot = mysqlreader("Total")
                End If
                EQUIPtotal.AddRange(New Double() {tot})
            End While
            mysqlreader.Close()
            mysqlconn.Close()


            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "SELECT SUM(Amount) as Total FROM SchoolExpenses WHERE MONTH(ExpenseDate)  ='" & Months(i).ToString & "' AND category ='SCHOOL SUPPLIES' "
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "ExpenseSummary")
            mydataTable = mydataset.Tables("ExpenseSummary")
            mysqlreader = mycommand.ExecuteReader()
            While mysqlreader.Read
                Dim tot As Double
                If mysqlreader("Total").ToString = "" Then
                    tot = 0.00
                Else
                    tot = mysqlreader("Total")
                End If
                SCHOOLSUPtotal.AddRange(New Double() {tot})
            End While
            mysqlreader.Close()
            mysqlconn.Close()

            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "SELECT SUM(Amount) as Total FROM SchoolExpenses WHERE MONTH(ExpenseDate)  ='" & Months(i).ToString & "' AND category ='SCHOOL IMPROVEMENTS' "
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "ExpenseSummary")
            mydataTable = mydataset.Tables("ExpenseSummary")
            mysqlreader = mycommand.ExecuteReader()
            While mysqlreader.Read
                Dim tot As Double
                If mysqlreader("Total").ToString = "" Then
                    tot = 0.00
                Else
                    tot = mysqlreader("Total")
                End If
                SCHOOLIMPtotal.AddRange(New Double() {tot})
            End While
            mysqlreader.Close()
            mysqlconn.Close()

            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "SELECT SUM(Amount) as Total FROM SchoolExpenses WHERE MONTH(ExpenseDate)  ='" & Months(i).ToString & "' AND category ='EVENTS' "
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "ExpenseSummary")
            mydataTable = mydataset.Tables("ExpenseSummary")
            mysqlreader = mycommand.ExecuteReader()
            While mysqlreader.Read
                Dim tot As Double
                If mysqlreader("Total").ToString = "" Then
                    tot = 0.00
                Else
                    tot = mysqlreader("Total")
                End If
                EVENTStotal.AddRange(New Double() {tot})
            End While
            mysqlreader.Close()
            mysqlconn.Close()
        Next


        'For i = 0 To Year.Count - 1

        'Next

        'Months.AddRange(New String() {month(mysqlreader("months"))})


        Chart2.Series.Clear()

        Chart2.Series.Add("UTILITY BILL")
        For i = 0 To Months.Count - 1
            Chart2.Series("UTILITY BILL").Points.AddXY(month(Months(i)), UTILITYBILLtotal(i))
        Next

        Chart2.Series.Add("EVENTS")
        For i = 0 To Months.Count - 1
            Chart2.Series("EVENTS").Points.AddXY(month(Months(i)), EVENTStotal(i))
        Next

        Chart2.Series.Add("EQUIPMENT REPAIR")
        For i = 0 To Months.Count - 1
            Chart2.Series("EQUIPMENT REPAIR").Points.AddXY(month(Months(i)), EQUIPtotal(i))
        Next

        Chart2.Series.Add("SCHOOL SUPPLIES")
        For i = 0 To Months.Count - 1
            Chart2.Series("SCHOOL SUPPLIES").Points.AddXY(month(Months(i)), SCHOOLSUPtotal(i))
        Next

        Chart2.Series.Add("SCHOOL IMPROVEMENTS")
        For i = 0 To Months.Count - 1
            Chart2.Series("SCHOOL IMPROVEMENTS").Points.AddXY(month(Months(i)), SCHOOLIMPtotal(i))
        Next
        '        UTILITY BILL
        'EQUIPMENT REPAIR
        'SCHOOL SUPPLIES
        'SCHOOL IMPROVEMENTS
        'Events
        Chart2.Titles.Clear()
        Chart2.Titles.Add("YEARLY SCHOOL EXPENSES")

    End Sub

    Sub generateGraphYearly()
        '        UTILITY BILL
        'EQUIPMENT REPAIR
        'SCHOOL SUPPLIES
        'SCHOOL IMPROVEMENTS
        'EVENTS


        Dim Year As New List(Of String)
        Dim UTILITYBILLtotal As New List(Of Double)
        Dim EQUIPtotal As New List(Of Double)
        Dim SCHOOLSUPtotal As New List(Of Double)
        Dim SCHOOLIMPtotal As New List(Of Double)
        Dim EVENTStotal As New List(Of Double)


        Call connect(condbPOS)
        mycommand = mysqlconn.CreateCommand
        mycommand.CommandText = "SELECT Year(ExpenseDate) as years,SUM(Amount) as Total FROM SchoolExpenses Group By Year(ExpenseDate) "
        myadapter.SelectCommand = mycommand
        myadapter.Fill(mydataset, "ExpenseSummary")
        mydataTable = mydataset.Tables("ExpenseSummary")
        mysqlreader = mycommand.ExecuteReader()
        While mysqlreader.Read
            Year.AddRange(New String() {mysqlreader("years")})
        End While
        mysqlreader.Close()
        mysqlconn.Close()



        For i = 0 To Year.Count - 1

            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "SELECT SUM(Amount) as Total FROM SchoolExpenses WHERE YEAR(ExpenseDate)  ='" & Year(i).ToString & "' AND category ='UTILITY BILL' "
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "ExpenseSummary")
            mydataTable = mydataset.Tables("ExpenseSummary")
            mysqlreader = mycommand.ExecuteReader()
            While mysqlreader.Read
                Dim tot As Double
                If mysqlreader("Total").ToString = "" Then
                    tot = 0.00
                Else
                    tot = mysqlreader("Total")
                End If
                UTILITYBILLtotal.AddRange(New Double() {tot})
            End While
            mysqlreader.Close()
            mysqlconn.Close()

            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "SELECT SUM(Amount) as Total FROM SchoolExpenses WHERE YEAR(ExpenseDate)  ='" & Year(i).ToString & "' AND category ='EQUIPMENT REPAIR' "
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "ExpenseSummary")
            mydataTable = mydataset.Tables("ExpenseSummary")
            mysqlreader = mycommand.ExecuteReader()
            While mysqlreader.Read
                Dim tot As Double
                If mysqlreader("Total").ToString = "" Then
                    tot = 0.00
                Else
                    tot = mysqlreader("Total")
                End If
                EQUIPtotal.AddRange(New Double() {tot})
            End While
            mysqlreader.Close()
            mysqlconn.Close()


            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "SELECT SUM(Amount) as Total FROM SchoolExpenses WHERE YEAR(ExpenseDate)  ='" & Year(i).ToString & "' AND category ='SCHOOL SUPPLIES' "
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "ExpenseSummary")
            mydataTable = mydataset.Tables("ExpenseSummary")
            mysqlreader = mycommand.ExecuteReader()
            While mysqlreader.Read
                Dim tot As Double
                If mysqlreader("Total").ToString = "" Then
                    tot = 0.00
                Else
                    tot = mysqlreader("Total")
                End If
                SCHOOLSUPtotal.AddRange(New Double() {tot})
            End While
            mysqlreader.Close()
            mysqlconn.Close()

            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "SELECT SUM(Amount) as Total FROM SchoolExpenses WHERE YEAR(ExpenseDate)  ='" & Year(i).ToString & "' AND category ='SCHOOL IMPROVEMENTS' "
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "ExpenseSummary")
            mydataTable = mydataset.Tables("ExpenseSummary")
            mysqlreader = mycommand.ExecuteReader()
            While mysqlreader.Read
                Dim tot As Double
                If mysqlreader("Total").ToString = "" Then
                    tot = 0.00
                Else
                    tot = mysqlreader("Total")
                End If
                SCHOOLIMPtotal.AddRange(New Double() {tot})
            End While
            mysqlreader.Close()
            mysqlconn.Close()

            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "SELECT SUM(Amount) as Total FROM SchoolExpenses WHERE YEAR(ExpenseDate)  ='" & Year(i).ToString & "' AND category ='EVENTS' "
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "ExpenseSummary")
            mydataTable = mydataset.Tables("ExpenseSummary")
            mysqlreader = mycommand.ExecuteReader()
            While mysqlreader.Read
                Dim tot As Double
                If mysqlreader("Total").ToString = "" Then
                    tot = 0.00
                Else
                    tot = mysqlreader("Total")
                End If
                EVENTStotal.AddRange(New Double() {tot})
            End While
            mysqlreader.Close()
            mysqlconn.Close()
        Next


        'For i = 0 To Year.Count - 1

        'Next




        Chart1.Series.Clear()

        Chart1.Series.Add("UTILITY BILL")
        For i = 0 To Year.Count - 1
            Chart1.Series("UTILITY BILL").Points.AddXY(Year(i), UTILITYBILLtotal(i))
        Next

        Chart1.Series.Add("EVENTS")
        For i = 0 To Year.Count - 1
            Chart1.Series("EVENTS").Points.AddXY(Year(i), EVENTStotal(i))
        Next

        Chart1.Series.Add("EQUIPMENT REPAIR")
        For i = 0 To Year.Count - 1
            Chart1.Series("EQUIPMENT REPAIR").Points.AddXY(Year(i), EQUIPtotal(i))
        Next

        Chart1.Series.Add("SCHOOL SUPPLIES")
        For i = 0 To Year.Count - 1
            Chart1.Series("SCHOOL SUPPLIES").Points.AddXY(Year(i), SCHOOLSUPtotal(i))
        Next

        Chart1.Series.Add("SCHOOL IMPROVEMENTS")
        For i = 0 To Year.Count - 1
            Chart1.Series("SCHOOL IMPROVEMENTS").Points.AddXY(Year(i), SCHOOLIMPtotal(i))
        Next
        '        UTILITY BILL
        'EQUIPMENT REPAIR
        'SCHOOL SUPPLIES
        'SCHOOL IMPROVEMENTS
        'Events
        Chart1.Titles.Clear()
        Chart1.Titles.Add("YEARLY SCHOOL EXPENSES")

    End Sub
    Sub generateGraphSale2()
        'Chart1.Series(0).Points.AddXY("A", 60)
        'Chart1.Series(0).Points.AddXY("B", 50)
        'Chart1.Series(0).Points.AddXY("C", 20)
        'Chart1.Series(0).Points.AddXY("D", 35)
        'Chart1.Series(0).Points.AddXY("E", 70)
        'Chart1.Series(1).Points.AddXY("E", 70)


        Call connect(condbPOS)
        mycommand = mysqlconn.CreateCommand
        mycommand.CommandText = "SELECT * from ExpenseSummary"
        myadapter.SelectCommand = mycommand
        myadapter.Fill(mydataset, "ExpenseSummary")
        mydataTable = mydataset.Tables("ExpenseSummary")
        mysqlreader = mycommand.ExecuteReader()
        While mysqlreader.Read
            Chart1.Series(0).Points.AddXY(mysqlreader("Month"), mysqlreader("Total"))
            'Chart1.Series(1).Points.AddXY(mysqlreader("Month"), mysqlreader("Total"))

        End While
        mysqlreader.Close()
        mysqlconn.Close()





    End Sub
    Sub generateGraphSale()


        'Call connect(condbPOS)
        'mycommand = mysqlconn.CreateCommand
        'mycommand.CommandText = "Select Top 1  * from StudentAccount order by ID DESC"
        'myadapter.SelectCommand = mycommand
        'myadapter.Fill(mydataset, "StudentAccount")
        'mydataTable = mydataset.Tables("StudentAccount")
        'mysqlreader = mycommand.ExecuteReader()
        'While mysqlreader.Read
        '    Me.Chart1.Series("Series1").Points.AddXY(("Profit of the Day").ToString, mysqlreader("TotalNetAmount"))
        '    Me.Chart1.Series("Series1").Points.AddXY(("Discounted of the Day").ToString, mysqlreader("TotalDiscAmount"))
        'End While
        'mysqlreader.Close()
        'mysqlconn.Close()

        'Call connect(condbPOS)
        'mycommand = mysqlconn.CreateCommand
        ''mycommand.CommandText = "Select DatePart(yyyy,[ExpenseDate]) As Year,Category from SchoolExpenses Group By Category,DatePart(yyyy,[ExpenseDate])"
        'mycommand.CommandText = "SELECT Year(ExpenseDate) as years,Category,Amount FROM SchoolExpenses Group By Category,Year(ExpenseDate),Amount"


        'myadapter.SelectCommand = mycommand
        'myadapter.Fill(mydataset, "SchoolExpenses")
        'mydataTable = mydataset.Tables("SchoolExpenses")
        'mysqlreader = mycommand.ExecuteReader()
        'While mysqlreader.Read
        '    MsgBox(mysqlreader("years").ToString + " " + mysqlreader("category").ToString)
        '    Me.Chart1.Series("Series1").Points.AddXY(("Sales").ToString, mysqlreader("Amount"))
        '    Me.Chart1.Series("Series1").Points.AddXY(("Discounted of the Day").ToString, mysqlreader("years"))
        'End While
        'mysqlreader.Close()
        'mysqlconn.Close()

        Dim da As New OleDbDataAdapter("SELECT Year(ExpenseDate) as years,Category,SUM(Amount) as Total FROM SchoolExpenses WHERE category='WATER' Group By Category,Year(ExpenseDate) ", condbPOS)
        Dim ds As New DataSet

        da.Fill(ds, "SchoolExpenses")
        Chart1.DataSource = ds.Tables("SchoolExpenses")
        Dim series1 As Series = Chart1.Series("Series1")
        'series1.ChartType = SeriesChartType.Pie
        'series1.Name = "CATEGORY"

        With Chart1
            .Series(series1.Name).XValueMember = "Years"
            .Series(series1.Name).YValueMembers = "Total"
        End With






        'Try : conn.Open()
        '    mycommand = conn.CreateCommand
        '    mycommand.CommandText = "SELECT    SUM(SoldItem.DiscountAmount) as TotalDiscAmount,   SUM(SoldItem.NetAmount) as TotalNetAmount FROM Transactions INNER JOIN (Item INNER JOIN SoldItem ON Item.Barcode = SoldItem.Barcode) ON Transactions.TransID = SoldItem.TransID WHERE ((Transactions.TransDate Like '%" & Format(Date.Now, "Short Date") & "%' )) " '"
        '    myadapter.SelectCommand = mycommand
        '    mysqlreader = mycommand.ExecuteReader
        '    While mysqlreader.Read
        '        frmAdmin.Chart1.Series("Series1").Points.AddXY(("Profit of the Day").ToString, mysqlreader("TotalNetAmount"))
        '        frmAdmin.Chart1.Series("Series1").Points.AddXY(("Discounted of the Day").ToString, mysqlreader("TotalDiscAmount"))
        '    End While : conn.Close()
        '    conn.Open() : mycommand = conn.CreateCommand
        '    mycommand.CommandText = "SELECT * FROM Sales where Month ='" & Month(Now.Month) & "' and  Year ='" & (Now.Year).ToString & "'  "
        '    myadapter.SelectCommand = mycommand
        '    mysqlreader = mycommand.ExecuteReader
        '    While mysqlreader.Read
        '        frmAdmin.Chart1.Series("Series1").Points.AddXY(("Month of " & Month(Now.Month)).ToString, mysqlreader("TotalSales").ToString)
        '    End While : conn.Close()
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
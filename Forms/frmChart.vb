

Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmChart
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generateGraphSale()
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

        Dim da As New OleDbDataAdapter("SELECT Year(ExpenseDate) as years,Category,Amount FROM SchoolExpenses Group By Category,Year(ExpenseDate),Amount", condbPOS)
        Dim ds As New DataSet


        da.Fill(ds, "Category")
        Chart1.DataSource = ds.Tables("Category")
        Dim series1 As Series = Chart1.Series("Series1")
        series1.ChartType = SeriesChartType.Pie
        series1.Name = "CATEGORY"

        With Chart1
            .Series(series1.Name).XValueMember = "Years"
            .Series(series1.Name).YValueMembers = "Amount"
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
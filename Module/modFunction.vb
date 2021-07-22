Imports System.Configuration
Imports System.Data.OleDb
Module modFunction
    Public mylogin As New Login
    Public mystudent As New Student
    Public myschoolyear As New SchoolYear
    Public myadmission As New Admission
    Public mygradesection As New GradeSection
    Public myschoolexpenses As New SchoolExpenses
    Public myschoolfees As New SchoolFees
    Public myuseraccount As New UserAccount
    Public mylogs As New Logs
    Public mypayments As New Payments
    Public myledger As New Ledger



    Public mysqlconn As New OleDb.OleDbConnection
    Public mycommand As New OleDbCommand
    Public mysqlreader As OleDbDataReader
    Public mydataset As New DataSet
    Public mydataTable As New DataTable
    Public myadapter As New OleDbDataAdapter
    Public condbPOS As String = DBpath()
    Public Databasename As String

    Public adataset, ndataset, xdataset, pdataset, cdataset As New DataSet
    Public xtable, atable, ntable, pdatatable, cdatable As New DataTable

    Public password As String
    Public Username As String
    Public SchoolYearID As String
    Public SchoolYearVar As String
    Public SchoolYearData As String
    Public Restrictionlevel As String
    Public strvar As String
    Public lsaving As Boolean
    Public searching As Boolean
    Public StudentviewFocus As String
    Public loadstudentenrolled As Boolean
    Public UserID As String
    Public LogsID As String
    Public UserFullname As String
    Public tofullypaid As Boolean

    Public printDoc, Str, receiptfocus As String


    Public reportpath As String = "C:\Users\1IPAY PAYMENT CENTER\Desktop\Payment System\Report"

    Public Function DBpath() As String
        Databasename = Application.StartupPath & "\PAMS_DB" & ".accdb"
        DBpath = "provider=microsoft.ace.oledb.12.0;" & "data source=" & Databasename & ";Jet OLEDB:Database Password="
    End Function

    Public Sub connect(ByVal lconString As String)
        Try

            With mysqlconn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = lconString
                .Open()
            End With
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Public Sub getSchoolearID()
        Try
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select Top 1  * from SchoolYear WHERE Status ='Active'"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "SchoolYear")
            mydataTable = mydataset.Tables("SchoolYear")
            mysqlreader = mycommand.ExecuteReader()
            While mysqlreader.Read()
                SchoolYearID = mysqlreader("ID").ToString
                SchoolYearData = mysqlreader("SYFrom").ToString + "-" + mysqlreader("SYTo").ToString
                SchoolYearVar = "School Year " + mysqlreader("SYFrom").ToString + "-" + mysqlreader("SYTo").ToString
            End While
            If mydataTable.Rows.Count = 0 Then
                SchoolYearID = ""
                SchoolYearVar = ""
                SchoolYearData = ""

            End If
            mysqlreader.Close()
            mysqlconn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")

        End Try
    End Sub

    Public Function getUserrID(ByVal ID As String) As Boolean
        strvar = "USR-"
        Try
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select Top 1  * from UserAccount order by ID DESC"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "UserAccount")
            mydataTable = mydataset.Tables("UserAccount")
            mysqlreader = mycommand.ExecuteReader()

            While mysqlreader.Read()
                ID = String.Format("{0:0000}", mysqlreader("ID"))
            End While
            If mydataTable.Rows.Count = 0 Then
                ID = strvar & "0001"


            Else
                ID = strvar & String.Format("{0:0000}", Mid(Trim(ID), 5, 8) + 1)
            End If
            frmUser.txtCode.Text = Trim(ID)
            mysqlreader.Close()
            mysqlconn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")

        End Try
    End Function

    Public Function getMenu()
        If Restrictionlevel = "Secretary" Then
            frmMain.tsMenuProfile.Visible = True
            frmMain.tsMenuAdmission.Visible = True
            frmMain.tsMenuExpenses.Visible = True
            frmMain.tsMenuFees.Visible = True
            frmMain.tsMenuTransaction.Visible = False
            frmMain.tsMenuUsers.Visible = False
            frmMain.tsmenuReports.Visible = True
            frmMain.tsMenuSetting.Visible = True

            frmMain.ToolStripMenuItem8.Visible = True
            frmMain.ToolStripMenuItem10.Visible = True
            frmMain.ToolStripMenuItem11.Visible = True
            frmMain.SchoolExpensesToolStripMenuItem.Visible = True

        ElseIf Restrictionlevel = "Administrator" Then
            frmMain.tsMenuProfile.Visible = False
            frmMain.tsMenuAdmission.Visible = False
            frmMain.tsMenuExpenses.Visible = False
            frmMain.tsMenuFees.Visible = False
            frmMain.tsMenuTransaction.Visible = False
            frmMain.tsMenuUsers.Visible = True
            frmMain.tsmenuReports.Visible = True
            frmMain.tsMenuSetting.Visible = False

            frmMain.ToolStripMenuItem8.Visible = True
            frmMain.ToolStripMenuItem10.Visible = True
            frmMain.ToolStripMenuItem11.Visible = True
            frmMain.SchoolExpensesToolStripMenuItem.Visible = True

        ElseIf Restrictionlevel = "Cashier" Then
            frmMain.tsMenuProfile.Visible = False
            frmMain.tsMenuAdmission.Visible = False
            frmMain.tsMenuExpenses.Visible = False
            frmMain.tsMenuFees.Visible = False
            frmMain.tsMenuTransaction.Visible = True
            frmMain.tsMenuUsers.Visible = False
            frmMain.tsmenuReports.Visible = True
            frmMain.tsMenuSetting.Visible = False

            frmMain.ToolStripMenuItem8.Visible = False
            frmMain.ToolStripMenuItem10.Visible = False
            frmMain.ToolStripMenuItem11.Visible = False
            frmMain.SchoolExpensesToolStripMenuItem.Visible = False
        End If
    End Function
    Public Function getStudentID(ByVal ID As String) As Boolean
        strvar = "STUD-"
        Try
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select Top 1  * from Student order by ID DESC"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "Student")
            mydataTable = mydataset.Tables("Student")
            mysqlreader = mycommand.ExecuteReader()

            While mysqlreader.Read()
                ID = String.Format("{0:0000}", mysqlreader("ID"))
            End While
            If mydataTable.Rows.Count = 0 Then
                ID = strvar & "0001"
            Else
                ID = strvar & String.Format("{0:0000}", Mid(Trim(ID), 6, 8) + 1)
            End If
            frmStudent.txtStudentCode.Text = Trim(ID)
            mysqlreader.Close()
            mysqlconn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")

        End Try
    End Function
    Public Function getSYID(ByVal ID As String) As Boolean
        strvar = "SY-"
        Try
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select Top 1  * from SchoolYEar order by ID DESC"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "SchoolYEar")
            mydataTable = mydataset.Tables("SchoolYEar")
            mysqlreader = mycommand.ExecuteReader()

            While mysqlreader.Read()
                ID = String.Format("{0:0000}", mysqlreader("ID"))
            End While
            If mydataTable.Rows.Count = 0 Then
                ID = strvar & "0001"
            Else
                ID = strvar & String.Format("{0:0000}", Mid(Trim(ID), 4, 8) + 1)
            End If
            frmSchoolYear.lblCode.Text = Trim(ID)
            mysqlreader.Close()
            mysqlconn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")

        End Try
    End Function
    Public Function getLogsID(ByVal ID As String) As Boolean
        Try
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select * from Logs"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "Logs")
            mydataTable = mydataset.Tables("Logs")
            mysqlreader = mycommand.ExecuteReader()

            While mysqlreader.Read()
                ID = mysqlreader("ID").ToString
            End While
            If mydataTable.Rows.Count = 0 Then
                ID = 1
            Else
                ID = CDbl(ID) + 1
            End If
            frmMain.lblLogsID.Text = ID
            mysqlreader.Close()
            mysqlconn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")

        End Try
    End Function
    Public Function getGradeSectionID(ByVal ID As String) As Boolean
        strvar = "GS-"
        Try
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select Top 1  * from GradeSection order by ID DESC"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "GradeSection")
            mydataTable = mydataset.Tables("GradeSection")
            mysqlreader = mycommand.ExecuteReader()

            While mysqlreader.Read()
                ID = String.Format("{0:0000}", mysqlreader("ID"))
            End While
            If mydataTable.Rows.Count = 0 Then
                ID = strvar & "0001"
            Else
                ID = strvar & String.Format("{0:0000}", Mid(Trim(ID), 4, 8) + 1)
            End If
            frmGradeLevel.lblCode.Text = Trim(ID)
            mysqlreader.Close()
            mysqlconn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")

        End Try
    End Function
    Public Function getSchoolExpenseID(ByVal ID As String) As Boolean
        strvar = "EXP-"
        Try
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select Top 1  * from SchoolExpenses order by ID DESC"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "SchoolExpenses")
            mydataTable = mydataset.Tables("SchoolExpenses")
            mysqlreader = mycommand.ExecuteReader()

            While mysqlreader.Read()
                ID = String.Format("{0:0000}", mysqlreader("ID"))
            End While
            If mydataTable.Rows.Count = 0 Then
                ID = strvar & "0001"
            Else
                ID = strvar & String.Format("{0:0000}", Mid(Trim(ID), 5, 8) + 1)
            End If
            frmSchoolExpenses.lblCode.Text = Trim(ID)
            mysqlreader.Close()
            mysqlconn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")

        End Try
    End Function
    Public Function getSchoolFeesID(ByVal ID As String) As Boolean
        strvar = "FEE-"
        Try
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select Top 1  * from SchoolFees order by ID DESC"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "SchoolFees")
            mydataTable = mydataset.Tables("SchoolFees")
            mysqlreader = mycommand.ExecuteReader()

            While mysqlreader.Read()
                ID = String.Format("{0:0000}", mysqlreader("ID"))
            End While
            If mydataTable.Rows.Count = 0 Then
                ID = strvar & "0001"
            Else
                ID = strvar & String.Format("{0:0000}", Mid(Trim(ID), 5, 8) + 1)
            End If
            frmSchoolFees.lblCode.Text = Trim(ID)
            mysqlreader.Close()
            mysqlconn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")

        End Try
    End Function
    Public Function getAdmissiontID(ByVal ID As String) As Boolean
        strvar = "CTRL-"
        Try
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select Top 1  * from Admission order by ID DESC"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "Admission")
            mydataTable = mydataset.Tables("Admission")
            mysqlreader = mycommand.ExecuteReader()

            While mysqlreader.Read()
                ID = String.Format("{0:0000}", mysqlreader("ID"))
            End While
            If mydataTable.Rows.Count = 0 Then
                ID = strvar & "0001"
            Else
                ID = strvar & String.Format("{0:0000}", Mid(Trim(ID), 6, 8) + 1)
            End If
            frmAdmission.txtControlNumber.Text = Trim(ID)
            mysqlreader.Close()
            mysqlconn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")

        End Try
    End Function
    Public Function getStudentAccountID(ByVal ID As String) As Boolean
        strvar = "ACCT-"
        Try
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select Top 1  * from StudentAccount order by ID DESC"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "StudentAccount")
            mydataTable = mydataset.Tables("StudentAccount")
            mysqlreader = mycommand.ExecuteReader()

            While mysqlreader.Read()
                ID = String.Format("{0:0000}", mysqlreader("ID"))
            End While
            If mydataTable.Rows.Count = 0 Then
                ID = strvar & "0001"
            Else
                ID = strvar & String.Format("{0:0000}", Mid(Trim(ID), 6, 8) + 1)
            End If
            myadmission.studentAccountID = Trim(ID)
            mysqlreader.Close()
            mysqlconn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")

        End Try
    End Function
    Public Function getTransID(ByVal ID As String) As Boolean
        strvar = "TXN-"
        Try
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select Top 1  * from Transactions order by ID DESC"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "Transactions")
            mydataTable = mydataset.Tables("Transactions")
            mysqlreader = mycommand.ExecuteReader()

            While mysqlreader.Read()
                ID = String.Format("{0:0000}", mysqlreader("ID"))
            End While
            If ID = "" Then
                ID = strvar & "0001"
            Else
                ID = strvar & String.Format("{0:0000}", Mid(Trim(ID), 5, 8) + 1)
            End If
            frmPayments.txtTransID.Text = Trim(ID)
            mysqlreader.Close()
            mysqlconn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")

        End Try
    End Function

    Public Function getORNumber(ByVal ID As String) As Boolean
        strvar = "OR-"
        Try
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select Top 1  * from Transactions order by ID DESC"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "Transactions")
            mydataTable = mydataset.Tables("Transactions")
            mysqlreader = mycommand.ExecuteReader()

            While mysqlreader.Read()
                ID = String.Format("{0:0000}", mysqlreader("ORNumber"))
            End While
            If ID = "ORNUMBER" Then
                ID = strvar & "0001"
            Else
                ID = strvar & String.Format("{0:0000}", Mid(Trim(ID), 4, 8) + 1)
            End If
            frmPayments.lblOrNumber.Text = Trim(ID)
            mysqlreader.Close()
            mysqlconn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")

        End Try
    End Function
    Public Function ValidateVoidTXN() As Boolean
        Try
            Dim found As Boolean
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select * from Transactions where ID='" & Trim(frmVoidTransactionConfirmation.txtTxnNo.Text) & "' AND Void='Null'"

            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "Transactions")
            mydataTable = mydataset.Tables("Transactions")
            mysqlreader = mycommand.ExecuteReader()
            If mysqlreader.Read() Then
                found = True
            Else
                found = False
            End If
            If found = True Then
                ValidateVoidTXN = True
            Else
                ValidateVoidTXN = False
            End If

            mysqlreader.Close()
            mysqlconn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")

        End Try

    End Function

    Public Function ValidateExistingTXN() As Boolean
        Try
            Dim found As Boolean
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select * from Transactions where StudentID='" & Trim(frmStudent.txtStudentCode.Text) & "'"

            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "Transactions")
            mydataTable = mydataset.Tables("Transactions")
            mysqlreader = mycommand.ExecuteReader()
            If mysqlreader.Read() Then
                found = True
            Else
                found = False
            End If
            If found = True Then
                ValidateExistingTXN = True
            Else
                ValidateExistingTXN = False
            End If

            mysqlreader.Close()
            mysqlconn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")

        End Try

    End Function


    Public Function ValidateExistingTXNAdmission() As Boolean
        Try
            Dim found As Boolean
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select * from Transactions where StudentID='" & Trim(frmAdmission.txtStudID.Text) & "'"

            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "Transactions")
            mydataTable = mydataset.Tables("Transactions")
            mysqlreader = mycommand.ExecuteReader()
            If mysqlreader.Read() Then
                found = True
            Else
                found = False
            End If
            If found = True Then
                ValidateExistingTXNAdmission = True
            Else
                ValidateExistingTXNAdmission = False
            End If

            mysqlreader.Close()
            mysqlconn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")

        End Try

    End Function


    Public Function month(ByVal a As String) As String
        If a = 1 Then Return "January"
        If a = 2 Then Return "February"
        If a = 3 Then Return "March"
        If a = 4 Then Return "April"
        If a = 5 Then Return "May"
        If a = 6 Then Return "June"
        If a = 7 Then Return "July"
        If a = 8 Then Return "August"
        If a = 9 Then Return "September"
        If a = 10 Then Return "August"
        If a = 11 Then Return "November"
        If a = 12 Then Return "December"
    End Function



End Module

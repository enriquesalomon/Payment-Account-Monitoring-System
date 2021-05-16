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
    Public Restrictionlevel As String
    Public strvar As String
    Public lsaving As Boolean
    Public searching As Boolean
    Public StudentviewFocus As String
    Public UserID As String
    Public LogsID As String
    Public UserFullname As String
    Public tofullypaid As Boolean

    Public printDoc, Str, receiptfocus As String

    Public reportpath As String = "C:\AB GADGETS BETA TESTING\REPORTS"
    'Public reportpath As String = "C:\Users\Home\Documents\Visual Studio 2013\Projects\INSTALLMENT MANAGEMENT SYSTEM\INSTALLMENT MANAGEMENT SYSTEM\Reports"

    Public Function DBpath() As String
        Databasename = Application.StartupPath & "\PAMS_DB" & ".accdb"
        'Databasename = "C:\AB GADGETS BETA TESTING\DB\POSIS_DB" & ".accdb"
        DBpath = "provider=microsoft.ace.oledb.12.0;" & "data source=" & Databasename & ";Jet OLEDB:Database Password="

        'DBpath = "provider=microsoft.ace.oledb.12.0;" & "data source=" & Databasename & ";Jet OLEDB:Database Password=abgadgets.pos"
        'LENDINGpath = "provider=microsoft.ace.oledb.12.0;Persist Security Info=False;Data Source=" & Trim(LENDINGDatabasename) & ";Jet OLEDB:Database Password=12345"
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
            frmMain.tsMenuExpenses.Visible = False
            frmMain.tsMenuFees.Visible = False
            frmMain.tsMenuTransaction.Visible = False
            frmMain.tsMenuUsers.Visible = False
            frmMain.tsmenuReports.Visible = True
            frmMain.tsMenuSetting.Visible = True
        ElseIf Restrictionlevel = "Administrator" Then
            frmMain.tsMenuProfile.Visible = False
            frmMain.tsMenuAdmission.Visible = False
            frmMain.tsMenuExpenses.Visible = False
            frmMain.tsMenuFees.Visible = False
            frmMain.tsMenuTransaction.Visible = False
            frmMain.tsMenuUsers.Visible = True
            frmMain.tsmenuReports.Visible = True
            frmMain.tsMenuSetting.Visible = True
        ElseIf Restrictionlevel = "Cashier" Then
            frmMain.tsMenuProfile.Visible = True
            frmMain.tsMenuAdmission.Visible = True
            frmMain.tsMenuExpenses.Visible = False
            frmMain.tsMenuFees.Visible = True
            frmMain.tsMenuTransaction.Visible = True
            frmMain.tsMenuUsers.Visible = False
            frmMain.tsmenuReports.Visible = True
            frmMain.tsMenuSetting.Visible = False
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
End Module

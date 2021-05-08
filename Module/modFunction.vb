﻿Imports System.Configuration
Imports System.Data.OleDb
Module modFunction
    Public mylogin As New Login


    Public mysqlconn As New OleDb.OleDbConnection
    Public mycommand As New OleDbCommand
    Public mysqlreader As OleDbDataReader
    Public mydataset As New DataSet
    Public mydataTable As New DataTable
    Public myadapter As New OleDbDataAdapter
    Public condbPOS As String = DBpath()
    Public Databasename As String

    Public password As String
    Public Username As String
    Public Restrictionlevel As String
    Public strvar As String
    Public lsaving As Boolean
    Public searching As Boolean
    Public SupplierviewFocus As String
    Public ClientviewFocus As String
    Public ItemviewFocus As String
    Public POSFormFocus As String
    Public UserID As String
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
            'frmUserManagement.txtCode.Text = Trim(ID)
            mysqlreader.Close()
            mysqlconn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")

        End Try
    End Function

    Public Function getMenu()
        If Restrictionlevel = "Secretary" Then
            frmMain.tsMenuProfile.Visible = True
        ElseIf Restrictionlevel = "Administrator" Then
            frmMain.tsMenuProfile.Visible = True
        ElseIf Restrictionlevel = "Principal" Then


        End If
    End Function
End Module
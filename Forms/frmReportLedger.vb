Imports System.Text.RegularExpressions

Public Class frmReportLedger
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Sub clrtx()
        txtStudentCode.Clear()
        txtStudentName.Clear()
        txtGender.Clear()
        dtgList.Rows.Clear()

        txtAccountNumber.Text = "ACCT-****"
        txtTotalPayableAmount.Text = "0.00"
        txtTotalPaid.Text = "0.00"
        txtRunningBalance.Text = "0.00"
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        clrtx()
        StudentviewFocus = "Student Ledger"
        loadstudentenrolled = True
        frmStudentSearch.ShowDialog()
    End Sub

    Private Sub frmReportLedger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myledger.loaddtgTransactions()
        myledger.loadSY()
    End Sub
    Public SYFrom, SYTo, SchoolYearIDFilter As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dtgList.Rows.Count <> 0 Then
            printDoc = "Ledger"
            Report.ShowDialog()
        End If
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        If txtAccountNumber.Text = "" Then
            Exit Sub
        End If
        myledger.getAccountNumber()
        myledger.getSchoolFees()
        myledger.getTotalPayment()
        myledger.LoadListTransaction()
    End Sub



    Private Sub cmbSY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSY.SelectedIndexChanged
        SYFrom = ""
        SYTo = ""
        'lblID.Text = cmbSY.SelectedItem
        Dim input As String = cmbSY.SelectedItem.ToString
        Dim result As String() = Regex.Split(input, "-")
        Dim i = 0
        For Each s As String In result
            If i = 0 Then
                SYFrom = s
                i += 1
            Else
                SYTo = s
            End If

        Next
        Try
            frmReportAdmissionList.SchoolYearIDFilter = ""
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select * from SchoolYear where SYFrom ='" & SYFrom & "' AND SYTo ='" & SYTo & "' "
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "SchoolYear")
            mydataTable = mydataset.Tables("SchoolYear")
            mysqlreader = mycommand.ExecuteReader()
            While mysqlreader.Read()
                SchoolYearIDFilter = mysqlreader("ID").ToString

            End While
            mysqlreader.Close()
            mysqlconn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")

        End Try
    End Sub
End Class
Imports System.Text.RegularExpressions

Public Class frmReportVoidedPaymentList
    Public SYFrom, SYTo, SchoolYearIDFilter As String
    Private Sub frmReportVoidedPaymentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mypayments.loaddtgVoidedPaymentsReport()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dtgSales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgSales.CellClick
        If dtgSales.Rows.Count > 0 Then
            lblrecordcount.Text = "Showing " & (dtgSales.CurrentRow.Index) + 1 & Space(1) & "entries" & Space(1) & " of " & dtgSales.Rows.Count

        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If dtgSales.Rows.Count <> 0 Then
            printDoc = "Payment Voided List"
            Report.ShowDialog()
        End If
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click

        mypayments.loadVoidedPaymentReport()
    End Sub


End Class
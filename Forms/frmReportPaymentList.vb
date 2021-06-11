Imports System.Text.RegularExpressions

Public Class frmReportPaymentList
    Private Sub frmReportPaymentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mypayments.loaddtgPaymentsReport()
    End Sub

    Private Sub dtgSales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgSales.CellClick
        If dtgSales.Rows.Count > 0 Then
            lblrecordcount.Text = "Showing " & (dtgSales.CurrentRow.Index) + 1 & Space(1) & "entries" & Space(1) & " of " & dtgSales.Rows.Count

        End If
    End Sub
    Public SYFrom, SYTo, SchoolYearIDFilter As String

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If dtgSales.Rows.Count <> 0 Then
            printDoc = "Payment List"
            Report.ShowDialog()
        End If
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click

        'If cmbSY.Text <> Nothing Then
        mypayments.loadPaymentsReport()
        'End If
    End Sub


End Class
Imports System.Text.RegularExpressions

Public Class frmReportVoidedPaymentList
    Public SYFrom, SYTo, SchoolYearIDFilter As String
    Private Sub frmReportVoidedPaymentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mypayments.loaddtgVoidedPaymentsReport()
        mypayments.loadSYVoided()
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
            'Report.ShowDialog()
        End If
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click

        If cmbSY.Text <> Nothing Then
            mypayments.loadVoidedPaymentReport()
        End If
    End Sub

    Private Sub cmbSY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSY.SelectedIndexChanged
        SYFrom = ""
        SYTo = ""
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
    End Sub
End Class
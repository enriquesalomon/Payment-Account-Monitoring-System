Imports System.Text.RegularExpressions

Public Class frmReportPaymentList
    Private Sub frmReportPaymentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mypayments.loaddtgPaymentsReport()
        mypayments.loadSY()
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

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click

        If cmbSY.Text <> Nothing Then
            mypayments.loadSYAdmissionReport()
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
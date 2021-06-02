
Imports System.Text.RegularExpressions

Public Class frmReportAdmissionList
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmReportAdmissionList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myadmission.loaddtgAdmissionReport()
        myadmission.loadSY()
    End Sub
    Public SYFrom, SYTo, SchoolYearIDFilter As String

    Private Sub dtgList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgList.CellClick
        If dtgList.Rows.Count > 0 Then
            lblrecordcount.Text = "Showing " & (dtgList.CurrentRow.Index) + 1 & Space(1) & "entries" & Space(1) & " of " & dtgList.Rows.Count

        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If dtgList.Rows.Count <> 0 Then
            printDoc = "Admission List"
            'Report.ShowDialog()
        End If
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
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        If cmbSY.Text <> Nothing Then
            myadmission.loadSYAdmissionReport()
        End If
    End Sub
End Class
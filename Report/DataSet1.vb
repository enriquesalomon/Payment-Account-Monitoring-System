﻿

Partial Public Class DataSet1
    Partial Public Class dtStudentLedgerDataTable
        Private Sub dtStudentLedgerDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.DataColumn1Column.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class

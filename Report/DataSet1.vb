

Partial Public Class DataSet1
    Partial Public Class dtPaymentListDataTable
        Private Sub dtPaymentListDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.NoColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class dtLedgerDataTable
        Private Sub dtLedgerDataTable_dtLedgerRowChanging(sender As Object, e As dtLedgerRowChangeEvent) Handles Me.dtLedgerRowChanging

        End Sub

    End Class

    Partial Public Class dtVoidedPaymentListDataTable
        Private Sub dtVoidedPaymentListDataTable_dtVoidedPaymentListRowChanging(sender As Object, e As dtVoidedPaymentListRowChangeEvent) Handles Me.dtVoidedPaymentListRowChanging

        End Sub

    End Class

    Partial Public Class dtSchoolExpenseListDataTable
        Private Sub dtSchoolExpenseListDataTable_dtSchoolExpenseListRowChanging(sender As Object, e As dtSchoolExpenseListRowChangeEvent) Handles Me.dtSchoolExpenseListRowChanging

        End Sub

    End Class

End Class

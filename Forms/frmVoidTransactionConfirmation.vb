Public Class frmVoidTransactionConfirmation
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        txtTxnNo.Clear()
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtTxnNo.Text = "" Then
            Exit Sub
        End If
        frmPayments.ButtonClick("Save")


    End Sub
End Class
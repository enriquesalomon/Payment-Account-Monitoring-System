Public Class frmVoidTransactionConfirmation
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        txtTxnNo.Clear()
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnVoid.Click
        If txtTxnNo.Text = "" Then
            Exit Sub
        End If
        If ValidateVoidTXN() Then
            frmPayments.ButtonClick("Save")
        Else
            MsgBox("TXN # is not found", MsgBoxStyle.Information)
        End If



    End Sub
End Class
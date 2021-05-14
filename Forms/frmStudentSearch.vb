Public Class frmStudentSearch
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        txtsearch.Clear()
        Me.Close()
    End Sub

    Private Sub frmStudentSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myadmission.LoadStudentList()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        searching = True
        myadmission.LoadStudentList()
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        searching = False
        txtsearch.Clear()
        myadmission.LoadStudentList()
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            searching = True
            myadmission.LoadStudentList()
        End If
    End Sub

    Private Sub dtgStudentList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgStudentList.CellDoubleClick
        'If dtgStudentList.Rows.Count = 0 Then
        '    Exit Sub
        'End If
        'Dim GridRow As DataGridViewRow = dtgStudentList.CurrentRow
        'For Each datagrd As DataGridViewRow In dtgStudentList.SelectedRows
        '    frmAdmission.txtControlNumber.Text = CStr(GridRow.Cells.Item("controlno").Value)
        '    dtgStudentList.txtClientCode.Text = CStr(GridRow.Cells.Item("ClientCode").Value)
        '    dtgStudentList.txtPlanholdername.Text = CStr(GridRow.Cells.Item("fullname").Value)



        '    Call connect(condbPOS)
        '    mycommand = mysqlconn.CreateCommand

        '    mycommand.CommandText = "Select * from  (InstallmentPlan inner join Client on Client.ID = InstallmentPlan.ClientCode)  WHERE InstallmentPlan.InstallmentNo='" & CStr(GridRow.Cells.Item("id").Value) & "'"
        '    myadapter.SelectCommand = mycommand
        '    myadapter.Fill(mydataset, "InstallmentPlan")
        '    mydataTable = mydataset.Tables("InstallmentPlan")
        '    mysqlreader = mycommand.ExecuteReader
        '    If mydataTable.Rows.Count > 0 Then
        '        While mysqlreader.Read()
        '            installmentno = mysqlreader("InstallmentNo").ToString
        '            frmClientLedger.txtInstallmentNo.Text = mysqlreader("InstallmentNo").ToString
        '            frmClientLedger.txtTotalPlanAmount.Text = Format(CDbl(mysqlreader("ItemInstallmentPrice")), "###,###.#0")
        '            amortpayable = mysqlreader("AmortPayable").ToString
        '        End While
        '    Else
        '    End If
        '    mysqlreader.Close()
        '    mysqlconn.Close()
        'Next datagrd

        'Me.Close()
    End Sub
End Class
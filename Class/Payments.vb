Public Class Payments

    Sub loaddtgSchoolFees()
        frmPayments.dtgSchoolFee.ColumnCount = 3

        frmPayments.dtgSchoolFee.Columns(0).HeaderText = "NO."
        frmPayments.dtgSchoolFee.Columns(0).Width = 50
        frmPayments.dtgSchoolFee.Columns(0).Name = "no"
        frmPayments.dtgSchoolFee.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmPayments.dtgSchoolFee.Columns(1).HeaderText = "Particular"
        frmPayments.dtgSchoolFee.Columns(1).Width = 250
        frmPayments.dtgSchoolFee.Columns(1).Name = "particular"
        frmPayments.dtgSchoolFee.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmPayments.dtgSchoolFee.Columns(2).HeaderText = "Amount"
        frmPayments.dtgSchoolFee.Columns(2).Width = 50
        frmPayments.dtgSchoolFee.Columns(2).Name = "amount"
        frmPayments.dtgSchoolFee.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter



    End Sub

    Sub LoadListSchoolFees()
        Try
            frmPayments.dtgSchoolFee.Rows.Clear()
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            If searching = True Then
            Else
                mycommand.CommandText = "Select * from SchoolFees where SY= '" & SchoolYearData & "'"
            End If

            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "SchoolFees")
            mydataTable = mydataset.Tables("SchoolFees")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                Dim nos As Integer = 0
                While mysqlreader.Read
                    nos += 1
                    Dim nrow As String() = New String() {nos.ToString, mysqlreader("Particular").ToString, mysqlreader("Amount").ToString}
                    frmPayments.dtgSchoolFee.Rows.Add(nrow)
                End While

            End If
            Dim no As Integer = 0
            Dim totalpayable As Double = 0
            For Each RW As DataGridViewRow In frmPayments.dtgSchoolFee.Rows
                no += 1
                totalpayable += CDbl(RW.Cells(2).Value)
            Next
            frmPayments.txtTotalpayable.Text = totalpayable

            mysqlreader.Close()
            mydataTable.Rows.Clear()
            mydataset.Clear()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub
End Class

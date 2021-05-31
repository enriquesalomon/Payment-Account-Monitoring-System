Public Class Ledger

    Sub loadSY()

        frmReportLedger.cmbSY.Items.Clear()
        Call connect(condbPOS)
        mycommand = mysqlconn.CreateCommand
        mycommand.CommandText = "Select * from SchoolYear"
        myadapter.SelectCommand = mycommand
        myadapter.Fill(mydataset, "SchoolYear")
        mydataTable = mydataset.Tables("SchoolYear")
        mysqlreader = mycommand.ExecuteReader()
        While mysqlreader.Read()
            frmReportLedger.cmbSY.Items.Add(mysqlreader("SYFrom").ToString + "-" + mysqlreader("SYTo").ToString)

        End While
        mysqlreader.Close()
        mysqlconn.Close()
    End Sub

End Class

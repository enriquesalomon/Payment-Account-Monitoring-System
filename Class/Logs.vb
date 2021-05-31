Public Class Logs
    Sub loaddtg()
        frmLogs.dtgList.ColumnCount = 6

        frmLogs.dtgList.Columns(0).HeaderText = "NO."
        frmLogs.dtgList.Columns(0).Width = 50
        frmLogs.dtgList.Columns(0).Name = "no"
        frmLogs.dtgList.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmLogs.dtgList.Columns(1).HeaderText = "User ID"
        frmLogs.dtgList.Columns(1).Width = 100
        frmLogs.dtgList.Columns(1).Name = "id"
        frmLogs.dtgList.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmLogs.dtgList.Columns(2).HeaderText = "Fullname"
        frmLogs.dtgList.Columns(2).Width = 200
        frmLogs.dtgList.Columns(2).Name = "fullname"
        frmLogs.dtgList.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmLogs.dtgList.Columns(3).HeaderText = "Access Level"
        frmLogs.dtgList.Columns(3).Width = 150
        frmLogs.dtgList.Columns(3).Name = "position"
        frmLogs.dtgList.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmLogs.dtgList.Columns(4).HeaderText = "In"
        frmLogs.dtgList.Columns(4).Width = 200
        frmLogs.dtgList.Columns(4).Name = "amount"
        frmLogs.dtgList.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        frmLogs.dtgList.Columns(5).HeaderText = "Out"
        frmLogs.dtgList.Columns(5).Width = 200
        frmLogs.dtgList.Columns(5).Name = "out"
        frmLogs.dtgList.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter


    End Sub

    Sub LoadList()
        Try
            frmLogs.dtgList.Rows.Clear()
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            If searching = True Then
            Else
                mycommand.CommandText = "Select * from (Logs inner join UserAccount on UserAccount.ID = Logs.UserID) ORDER BY Logs.ID ASC"

            End If

            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "Logs")
            mydataTable = mydataset.Tables("Logs")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                Dim nos As Integer = 0
                While mysqlreader.Read
                    nos += 1
                    Dim nrow As String() = New String() {nos.ToString, mysqlreader("UserID").ToString, mysqlreader("Firstname").ToString + " " + mysqlreader("Lastname").ToString, mysqlreader("RestrictionLevel").ToString, mysqlreader("In").ToString, mysqlreader("Out").ToString}
                    frmLogs.dtgList.Rows.Add(nrow)
                End While

            End If
            Dim no As Integer = 0
            For Each RW As DataGridViewRow In frmLogs.dtgList.Rows
                no += 1
            Next
            mysqlreader.Close()
            mydataTable.Rows.Clear()
            mydataset.Clear()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub
End Class

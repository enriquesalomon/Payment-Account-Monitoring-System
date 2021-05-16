Public Class frmUser
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisablerControls()
        ClearMe()
        myuseraccount.userlist()
    End Sub
    Private Sub ButtonClick(ByVal ckey As String)
        Select Case ckey

            Case "New"
                lsaving = True
                txtFirstname.Focus()
                btnEdit.Enabled = False
                btnDelete.Enabled = False
                EnablerControls()
                ClearMe()
            Case "Edit"
                lsaving = False
                btnNew.Enabled = False
                btnDelete.Enabled = False
                EnablerControls()
            Case "Save"
                myuseraccount.SaveEditRecords()
            Case "Delete"
                myuseraccount.delete()
            Case "Cancel"
                btnEdit.Enabled = False
                btnDelete.Enabled = True
                btnNew.Enabled = True
                DisablerControls()
                ClearMe()
        End Select
    End Sub
    Public Sub ClearMe()
        txtFirstname.Clear()
        txtMiddlename.Clear()
        txtLastname.Clear()
        txtAddress.Clear()
        txtContactNo.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        cmbUserlevel.Text = Nothing
    End Sub
    Public Sub DisablerControls()
        txtFirstname.Enabled = False
        txtMiddlename.Enabled = False
        txtLastname.Enabled = False
        txtAddress.Enabled = False
        txtContactNo.Enabled = False
        txtUsername.Enabled = False
        txtPassword.Enabled = False
        cmbUserlevel.Enabled = False
    End Sub
    Public Sub EnablerControls()
        btnSave.Enabled = True
        txtFirstname.Enabled = True
        txtMiddlename.Enabled = True
        txtLastname.Enabled = True
        txtAddress.Enabled = True
        txtContactNo.Enabled = True
        txtUsername.Enabled = True
        txtPassword.Enabled = True
        cmbUserlevel.Enabled = True
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ButtonClick("New")
    End Sub

    Private Sub dtgUserList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgUserList.CellClick

        Dim GridRow As DataGridViewRow = dtgUserList.CurrentRow
        For Each datagrd As DataGridViewRow In dtgUserList.SelectedRows

            txtCode.Text = (CStr(GridRow.Cells.Item("userid").Value))
            Call connect(condbPOS)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select * from UserAccount WHERE ID ='" & Trim((CStr(GridRow.Cells.Item("userid").Value))) & "'"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "UserAccount")
            mydataTable = mydataset.Tables("UserAccount")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                While mysqlreader.Read()
                    txtFirstname.Text = (mysqlreader("Firstname").ToString)
                    txtMiddlename.Text = (mysqlreader("Middlename").ToString)
                    txtLastname.Text = (mysqlreader("Lastname").ToString)

                End While
            Else
            End If
            mysqlreader.Close()
            mysqlconn.Close()
            'UserFullname = (CStr(GridRow.Cells.Item("fullname").Value))
            txtAddress.Text = (CStr(GridRow.Cells.Item("address").Value))
            txtContactNo.Text = (CStr(GridRow.Cells.Item("contactno").Value))
            cmbUserlevel.Text = (CStr(GridRow.Cells.Item("userlevel").Value))
            txtUsername.Text = (CStr(GridRow.Cells.Item("username").Value))
            txtPassword.Text = (CStr(GridRow.Cells.Item("password").Value))


        Next datagrd
        If txtCode.Text <> Nothing Then
            btnEdit.Enabled = True
            btnDelete.Enabled = True
        End If
    End Sub

    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        ButtonClick("Cancel")
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ButtonClick("Edit")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        For Each RW As DataGridViewRow In dtgUserList.Rows
            If RW.Cells(0).Value <> txtCode.Text Then
                If RW.Cells(5).Value = Trim(txtUsername.Text) Then
                    MsgBox("New Username is already taken, Please choose another", MsgBoxStyle.Information)
                    txtUsername.Clear()
                    Exit Sub
                End If
            End If
        Next
        ButtonClick("Save")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        For Each RW As DataGridViewRow In dtgUserList.Rows
            If RW.Cells(4).Value = "Super Administrator" Then
                MsgBox("Action Denied. Account cannot be deleted, Please contact the system administor", MsgBoxStyle.Information)
                Exit Sub
            End If

        Next
        ButtonClick("Delete")
    End Sub
End Class
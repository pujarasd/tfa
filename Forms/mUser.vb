Imports System.Windows.Forms
Public Class mUser
    Friend mode As enEntry
    Friend id As Integer
    Friend formtype As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If txtUser.Text = "" Then
            MsgBox("Invaild User Name", MsgBoxStyle.Exclamation)
            txtUser.Focus()
            Exit Sub
        End If
        Dim strqry As String = ""
        Dim tblName As String = "mUsers"
        Dim fldid As String = "UserName,Password,IsMasterAdd,IsMasterEdit,IsMasterView,IsMasterDelete,IsVoucherAdd,IsVoucherEdit,IsVoucherView,IsVoucherDelete,IsBalanceSheet,IsPl,IsTrial,IsAdmin,IsActive"
        If mode = enEntry.Add Then
            strqry = "Select Id FROM mUsers where username = '" & txtUser.Text.Trim & "'"
            If nz(dbValue(strqry), 0) > 0 Then
                MsgBox("User Name Already Exist ", MsgBoxStyle.Exclamation)
                txtUser.Focus()
                Exit Sub
            End If
            strqry = "insert into " & tblName & " (" & fldid & ") values ('"
            strqry &= proper(txtUser.Text) & "','"
            strqry &= txtPwd.Text & "','"
            strqry &= chkMasterAdd.Checked & "','"
            strqry &= chkMasterEdit.Checked & "','"
            strqry &= chkMasterView.Checked & "','"
            strqry &= chkMasterDelete.Checked & "','"
            strqry &= chkVoucherAdd.Checked & "','"
            strqry &= chkVoucherEdit.Checked & "','"
            strqry &= chkVoucherView.Checked & "','"
            strqry &= chkVoucherDelete.Checked & "','"
            strqry &= chkBs.Checked & "','"
            strqry &= chkPL.Checked & "','"
            strqry &= chkTb.Checked & "','"
            strqry &= chkIsAdmin.Checked & "','True')"

        ElseIf mode = enEntry.Edit Then
            strqry = "Select Id FROM " & tblName & " where Username = '" & proper(txtUser.Text.Trim) & "' and id <>" & id
            If nz(dbValue(strqry), 0) > 0 Then
                MsgBox("User Name Already Exist ", MsgBoxStyle.Exclamation)
                txtUser.Focus()
                Exit Sub
            End If
            strqry = "update " & tblName & " set "
            strqry &= " username = '" & proper(txtUser.Text) & "',"
            strqry &= " password = '" & txtPwd.Text & "',"
            strqry &= " ismasteradd = '" & chkMasterAdd.Checked & "',"
            strqry &= " ismasteredit = '" & chkMasterEdit.Checked & "',"
            strqry &= " ismasterdelete = '" & chkMasterDelete.Checked & "',"
            strqry &= " ismasterview = '" & chkMasterView.Checked & "',"
            strqry &= " isvoucheradd = '" & chkVoucherAdd.Checked & "',"
            strqry &= " isvoucheredit = '" & chkVoucherEdit.Checked & "',"
            strqry &= " isvoucherdelete = '" & chkVoucherDelete.Checked & "',"
            strqry &= " isvoucherview = '" & chkVoucherView.Checked & "',"
            strqry &= " isbalancesheet = '" & chkBs.Checked & "',"
            strqry &= " ispl = '" & chkPL.Checked & "',"
            strqry &= " istrial = '" & chkTb.Checked & "',"
            strqry &= " isAdmin = '" & chkIsAdmin.Checked & "'"
            strqry &= " where id = " & id
        ElseIf mode = enEntry.Delete Then
            If MsgBox("Are you sure?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                strqry = "delete " & tblName & " "
                strqry &= " where " & fldid & " = " & id
            End If
        End If
        If dbUpdate(New String() {strqry}) = True Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Not saved", Me.Text)
        End If
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub mUser_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Main.miUser.Enabled = True
    End Sub
    Private Sub mUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
    Private Sub mUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Main.miUser.Enabled = False
        If mode <> enEntry.Add Then
            Dim dt As DataTable
            dt = dbTable("select * from mUsers where id = " & id)
            If dt.Rows.Count > 0 Then
                txtUser.Text = dt.Rows(0).Item("username")
                txtPwd.Text = dt.Rows(0).Item("password")
                chkMasterAdd.Checked = dt.Rows(0).Item("ismasteradd")
                chkMasterEdit.Checked = dt.Rows(0).Item("ismasteredit")
                chkMasterDelete.Checked = dt.Rows(0).Item("ismasterdelete")
                chkMasterView.Checked = dt.Rows(0).Item("ismasterview")
                chkVoucherAdd.Checked = dt.Rows(0).Item("isvoucheradd")
                chkVoucherEdit.Checked = dt.Rows(0).Item("isvoucheredit")
                chkVoucherDelete.Checked = dt.Rows(0).Item("isvoucherdelete")
                chkVoucherView.Checked = dt.Rows(0).Item("isvoucherview")
                chkBs.Checked = dt.Rows(0).Item("isbalancesheet")
                chkPL.Checked = dt.Rows(0).Item("ispl")
                chkTb.Checked = dt.Rows(0).Item("istrial")
                chkIsAdmin.Checked = dt.Rows(0).Item("isAdmin")
            End If
        End If
        If mode = enEntry.Delete Or mode = enEntry.View Then
        End If
        If mode = enEntry.Delete Then cmdOk.Text = "&Delete"
        If mode = enEntry.View Then
            cmdCancel.Text = "Ok"
            cmdOk.Visible = False
        End If
        Me.Text = StrConv(formtype, VbStrConv.ProperCase) & " Creation "
    End Sub
    '   update mUsers set ismasteradd = 1,ismasterEdit = 1,ismasterview = 1 ,ismasterdelete = 1, 
    'isVoucheradd = 1,isVoucherEdit = 1,isVoucherview = 1 ,isVoucherdelete = 1, 
    'isBalancesheet = 1, isPl = 1, isTrial = 1, IsAdmin =1 , isActive = 1 where id = 1

    Private Sub txtUser_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUser.LostFocus
        txtUser.Text = StrConv(txtUser.Text, VbStrConv.ProperCase)
    End Sub
End Class

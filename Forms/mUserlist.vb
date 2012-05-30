Public Class Userlist
    Dim dt As DataTable
    Dim dv As DataView
    Private Sub stateList_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Main.miuser.Enabled = True
    End Sub
    Private Sub statelist_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Main.miuser.Enabled = False
        dgvdefault(dgv)
        dgv.Width = 417
        dgv.Columns.Add("id", "id")
        dgv.Columns.Add("User", "User")
        With dgv.Columns("id")
            .Visible = False
            .DataPropertyName = "id"
        End With
        With dgv.Columns("User")
            .DataPropertyName = "User"
            .Width = 300
        End With
        filldgv()
        cmbSearchType.Items.Add("Start with")
        cmbSearchType.Items.Add("Containing")
        cmbSearchType.SelectedIndex = 0
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            dv.RowFilter = ""
            Exit Sub
        End If
        If cmbSearchType.SelectedIndex = 0 Then
            dv.RowFilter = "User" & " like '" & txtSearch.Text.ToLower & "%'"
        Else
            dv.RowFilter = "User" & " like '%" & txtSearch.Text.ToLower & "%'"
        End If
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtSearch.Text = ""
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim ofrm As New mUser
        ofrm.Owner = Me
        ofrm.id = 0
        ofrm.formtype = "User"
        ofrm.mode = enDatamode.Add
        ofrm.ShowDialog()
        filldgv()
        dgv.Rows(dgv.RowCount - 1).Selected = True
        ofrm = Nothing
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If dgv.SelectedRows.Count = 0 Then
            MsgBox("Please, select User to edit", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim ofrm As New mUser
        ofrm.Owner = Me
        ofrm.formtype = "User"
        ofrm.id = dgv.SelectedRows(0).Cells(0).Value
        ofrm.mode = enDatamode.Edit
        ofrm.ShowDialog()
        filldgv()
        For i = 1 To dgv.Rows.Count() - 1
            If dgv.Rows(i).Cells(0).Value = ofrm.id Then
                dgv.Rows(i).Selected = True
                dgv.FirstDisplayedScrollingRowIndex = i
                Exit For
            End If
        Next
        ofrm = Nothing
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If dgv.SelectedRows.Count = 0 Then
            MsgBox("No record Select", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim ofrm As New mUser
        ofrm.Owner = Me
        ofrm.formtype = "User"
        ofrm.id = dgv.SelectedRows(0).Cells(0).Value
        ofrm.mode = enDatamode.Delete
        ofrm.ShowDialog()
        filldgv()
    End Sub
    Private Sub filldgv()
        Dim query As String = _
    <string>
              select Id,Username as [User] from mUsers order by UserName
            </string>
        dt = dbTable(query)
        dv = dt.DefaultView
        dgv.DataSource = dv
    End Sub
End Class
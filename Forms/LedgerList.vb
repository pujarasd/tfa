Public Class LedgerList
    Dim dt As DataTable
    Dim dv As DataView

    Private Sub LedgerList_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Main.miLedger.Enabled = True
    End Sub
    Private Sub LedgerList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Main.miLedger.Enabled = False
        dgvdefault(dgv)
        dgv.Width = 600
        dgv.Columns.Add("id", "id")
        dgv.Columns.Add("ledger", "Ledger")
        dgv.Columns.Add("group", "Group")
        With dgv.Columns("id")
            .Visible = False
            .DataPropertyName = "Id"
        End With
        With dgv.Columns("ledger")
            .DataPropertyName = "Ledger"
            .Width = 300
        End With
        With dgv.Columns("group")
            .DataPropertyName = "GroupName"
            .Width = 300
        End With

        '  End If
        getData()
        cmbColumn.Items.Add("Ledger")
        cmbColumn.Items.Add("Group")
        cmbSearchType.Items.Add("Start with")
        cmbSearchType.Items.Add("Containing")
        cmbColumn.SelectedIndex = 0
        cmbSearchType.SelectedIndex = 0
    End Sub
    Private Sub getData()
        Dim query As String = _
          <string>
              select a.id,a.ledger,b.groupname from mledger a
              inner join mLedgerGroup b on a.groupid = b.id 
              order by ledger
            </string>
        dt = dbTable(query)
        Dim dc As DataColumn = dt.Columns("Id")
        dt.PrimaryKey = New DataColumn() {dc}
        'If dt.Rows.Count > 0 Then
        dv = dt.DefaultView
        dgv.DataSource = dv

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
            dv.RowFilter = cmbColumn.SelectedItem & " like '" & txtSearch.Text.ToLower & "%'"
        Else
            dv.RowFilter = cmbColumn.SelectedItem & " like '%" & txtSearch.Text.ToLower & "%'"
        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtSearch.Text = ""
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim ofrm As New LedgerEntry
        ofrm.Owner = Me
        ofrm.id = 0
        ofrm.mode = enDatamode.Add
        ofrm.ShowDialog()
        getData()
        If dgv.RowCount > 0 Then dgv.Rows(dgv.RowCount - 1).Selected = True
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If dgv.SelectedRows.Count = 0 Then
            MsgBox("Please, select Ledger to edit", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim ofrm As New LedgerEntry
        ofrm.Owner = Me
        ofrm.id = dgv.SelectedRows(0).Cells(0).Value
        ofrm.mode = enDatamode.Edit
        ofrm.ShowDialog()
        getData()
        '  dgv.FirstDisplayedScrollingRowIndex = dv.Find(ofrm.id)
        ofrm = Nothing

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If dgv.SelectedRows.Count = 0 Then
            MsgBox("No record Select", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim ofrm As New LedgerEntry
        ofrm.Owner = Me
        ofrm.id = dgv.SelectedRows(0).Cells(0).Value
        ofrm.mode = enDatamode.Delete
        ofrm.ShowDialog()
        getData()
        ofrm = Nothing

    End Sub
End Class
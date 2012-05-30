Public Class Transportlist
    Dim dt As DataTable
    Dim dv As DataView
    Private Sub stateList_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Main.miTransport.Enabled = True
    End Sub
    Private Sub statelist_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Main.miTransport.Enabled = False
        dgvdefault(dgv)
        dgv.Width = 417
        dgv.Columns.Add("id", "id")
        dgv.Columns.Add("Transport", "Transport")
        With dgv.Columns("id")
            .Visible = False
            .DataPropertyName = "id"
        End With
        With dgv.Columns("Transport")
            .DataPropertyName = "Transport"
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
            dv.RowFilter = "Transport" & " like '" & txtSearch.Text.ToLower & "%'"
        Else
            dv.RowFilter = "Transport" & " like '%" & txtSearch.Text.ToLower & "%'"
        End If
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtSearch.Text = ""
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim ofrm As New mTransport
        ofrm.Owner = Me
        ofrm.id = 0
        ofrm.formtype = "Transport"
        ofrm.mode = enDatamode.Add
        ofrm.ShowDialog()
        filldgv()
        If dgv.RowCount > 0 Then dgv.Rows(dgv.RowCount - 1).Selected = True
        ofrm = Nothing
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If dgv.SelectedRows.Count = 0 Then
            MsgBox("Please, select Transport to edit", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim ofrm As New mTransport
        ofrm.Owner = Me
        ofrm.formtype = "Transport"
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
        Dim ofrm As New mTransport
        ofrm.Owner = Me
        ofrm.formtype = "Transport"
        ofrm.id = dgv.SelectedRows(0).Cells(0).Value
        ofrm.mode = enDatamode.Delete
        ofrm.ShowDialog()
        filldgv()
    End Sub
    Private Sub filldgv()
        Dim query As String = _
    <string>
              select Id,Transport from mTransport order by Transport
            </string>
        dt = dbTable(query)
        dv = dt.DefaultView
        dgv.DataSource = dv
    End Sub
End Class
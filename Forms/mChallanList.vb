Public Class ChallanList
    Dim dt As DataTable
    Dim dv As DataView
    Private Sub cityList_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Main.miBooks.Enabled = True
    End Sub
    Private Sub cityList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Main.miBooks.Enabled = False
        dgvdefault(dgv)
        dgv.Width = 350
        dgv.Columns.Add("id", "id")
        dgv.Columns.Add("Challan", "Challan")
        'dgv.Columns.Add("Party", "Party")
        With dgv.Columns("id")
            .DataPropertyName = "id"
            .Visible = False
        End With
        With dgv.Columns("Challan")
            .DataPropertyName = "Challan"
            .Width = 300
        End With
        'With dgv.Columns("Party")
        '    .DataPropertyName = "Party"
        '    .Width = 300
        'End With
        getData()
        'cmbColumn.Items.Add("Challan")
        'cmbColumn.Items.Add("Party")
        'cmbColumn.SelectedIndex = 0

        cmbSearchType.Items.Add("Start with")
        cmbSearchType.Items.Add("Containing")
        cmbSearchType.SelectedIndex = 0
    End Sub
    Private Sub getData()
        Dim query As String = _
           <string>
            select id,Challanname as challan From mChallanname where coid = <%= gCoId %> Order by Challanname
        </string>
        ''   '           select a.id,a.Challanname,b.ledger from mChallanname a   inner join mLedger b on a.Id = b.id order by Challanname

        dt = dbTable(query)
        'If dt.Rows.Count > 0 Then
        dv = dt.DefaultView
        dgv.DataSource = dv
        '  End If
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
            dv.RowFilter = "Challan" & " like '" & txtSearch.Text.ToLower & "%'"
        Else
            dv.RowFilter = "Challan" & " like '%" & txtSearch.Text.ToLower & "%'"
        End If

    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtSearch.Text = ""
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim ofrm As New mChallanname
        ofrm.Owner = Me
        ofrm.formtype = "challanname"
        ofrm.id = 0
        ofrm.mode = enDatamode.Add
        ofrm.ShowDialog()
        If ofrm.DialogResult = Windows.Forms.DialogResult.OK Then
            getData()

            If dgv.RowCount > 0 Then dgv.Rows(dgv.RowCount - 1).Selected = True
        End If

        ofrm = Nothing
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If dgv.SelectedRows.Count = 0 Then
            MsgBox("No record Select", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim ofrm As New mChallanname
        ofrm.Owner = Me
        ofrm.formtype = "challanname"
        ofrm.id = dgv.SelectedRows(0).Cells(0).Value
        ofrm.mode = enDatamode.Edit
        ofrm.ShowDialog()
        getData()
        For i = 1 To dgv.Rows.Count() - 1
            If dgv.Rows(i).Cells(0).Value = ofrm.id Then
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
        Dim ofrm As New mChallanname
        ofrm.Owner = Me
        ofrm.formtype = "challanname"
        ofrm.id = dgv.SelectedRows(0).Cells(0).Value
        ofrm.mode = enDatamode.Delete
        ofrm.ShowDialog()
        getData()
    End Sub
End Class
Public Class CityList
    Dim dt As DataTable
    Dim dv As DataView
    Dim citytype As String = "From"
    Private Sub cityList_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Main.miCity.Enabled = True
    End Sub
    Private Sub cityList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Main.miCity.Enabled = False
        dgvdefault(dgv)
        dgv.Width = 600
        dgv.Columns.Add("id", "id")
        dgv.Columns.Add("city", "City")
        dgv.Columns.Add("state", "State")
        With dgv.Columns("id")
            .DataPropertyName = "id"
            .Visible = False
        End With
        With dgv.Columns("city")
            .DataPropertyName = "city"
            .Width = 300
        End With
        With dgv.Columns("state")
            .DataPropertyName = "state"
            .Width = 300
        End With
        getData()
        cmbColumn.Items.Add("City")
        cmbColumn.Items.Add("State")
        cmbSearchType.Items.Add("Start with")
        cmbSearchType.Items.Add("Containing")
        cmbColumn.SelectedIndex = 0
        cmbSearchType.SelectedIndex = 0
    End Sub
    Private Sub getData()
        Dim query As String = _
           <string>
              select a.id,a.city,b.state from mcity a
              inner join mstate b on a.stateid = b.id 
              where ctype='<%= citytype %>'
              order by city 
            </string>
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
            dv.RowFilter = cmbColumn.SelectedItem & " like '" & txtSearch.Text.ToLower & "%'"
        Else
            dv.RowFilter = cmbColumn.SelectedItem & " like '%" & txtSearch.Text.ToLower & "%'"
        End If

    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtSearch.Text = ""
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim ofrm As New mCity
        ofrm.Owner = Me
        ofrm.formtype = "city"
        ofrm.id = 0
        ofrm.mode = enDatamode.Add
        ofrm.CityType = citytype
        ofrm.ShowDialog()
        getData()
        If dgv.RowCount > 0 Then dgv.Rows(dgv.RowCount - 1).Selected = True
        ofrm = Nothing
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If dgv.SelectedRows.Count = 0 Then
            MsgBox("No record Select", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim ofrm As New mCity
        ofrm.Owner = Me
        ofrm.formtype = "city"
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
        Dim ofrm As New mCity
        ofrm.Owner = Me
        ofrm.formtype = "city"
        ofrm.id = dgv.SelectedRows(0).Cells(0).Value
        ofrm.mode = enDatamode.Delete
        ofrm.ShowDialog()
        getData()
    End Sub
    Private Sub rbFrom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbFrom.Click
        citytype = "From"
        getData()
    End Sub

    Private Sub rbPayableAt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbPayableAt.Click
        citytype = "PayableAt"
        getData()
    End Sub

    Private Sub rbTo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbTo.Click
        citytype = "To"
        getData()
    End Sub
End Class
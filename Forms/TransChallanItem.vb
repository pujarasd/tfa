Imports System.Windows.Forms

Public Class TransChallanItem
    Friend id As Integer
    Friend mode As enEntry
    Friend challan As frmChallan

    Private Sub TransChallanItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If mode = enEntry.Edit Or mode = enEntry.Delete Or mode = enEntry.View Then
            Dim row As DataGridViewRow = challan.dgv.SelectedRows(0)
            txtRemark.Text = row.Cells("Remark").Value
            txtContent.Text = row.Cells("Description").Value
            ntxtbags.value = row.Cells("bags").Value
            ntxtRate.value = row.Cells("rate").Value
            ntxtRdiff.value = row.Cells("RateDiff").Value
            ntxtWdiff.value = row.Cells("WeightDiff").Value
            ntxtWeight.value = row.Cells("Weight").Value
            ntxtAmount.value = row.Cells("Amount").Value
            ntxtAdiff.value = (ntxtRdiff.value * ntxtWdiff.value)

        End If

    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If mode = enEntry.Edit Then
            Dim row As DataGridViewRow = challan.dgv.SelectedRows(0)
            row.Cells("Description").Value = txtContent.Text
            row.Cells("Remark").Value = txtRemark.Text
            row.Cells("bags").Value = ntxtbags.value
            row.Cells("rate").Value = ntxtRate.value
            row.Cells("RateDiff").Value = ntxtRdiff.value
            row.Cells("WeightDiff").Value = ntxtWdiff.value
            row.Cells("Weight").Value = ntxtWeight.value
            row.Cells("Amount").Value = ntxtRate.value * ntxtWeight.value

        ElseIf mode = enEntry.Add Then
        
            With challan.dgv
                Dim dv As DataView = CType(.DataSource, DataView)
                dv.AddNew()
                dv(dv.Count - 1)("challanid") = challan.id

            End With

            Dim row As DataGridViewRow = challan.dgv.Rows(challan.dgv.Rows.Count - 1)
            ''challan.dgv.Rows(challan.dgv.RowCount - 1)
            row.Cells("Description").Value = txtContent.Text
            row.Cells("Remark").Value = txtRemark.Text
            row.Cells("bags").Value = ntxtbags.value
            row.Cells("rate").Value = ntxtRate.value
            row.Cells("RateDiff").Value = ntxtRdiff.value
            row.Cells("WeightDiff").Value = ntxtWdiff.value
            row.Cells("Weight").Value = ntxtWeight.value
            row.Cells("Amount").Value = ntxtRate.value * ntxtWeight.value

            'Dim row As DataRow = challan.dtchdetail.NewRow

            'row("Description") = txtContent.Text
            'row("Remark") = txtRemark.Text
            'row("bags") = CInt(ntxtbags.value)
            'row("rate") = ntxtRate.value
            'row("RateDiff") = ntxtRdiff.value
            'row("WeightDiff") = ntxtWdiff.value
            'row("Weight") = ntxtWeight.value
            'row("challanid") = challan.id
            'challan.dtchdetail.Rows.Add(row)
        End If


        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        challan.dgv.Refresh()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub



End Class

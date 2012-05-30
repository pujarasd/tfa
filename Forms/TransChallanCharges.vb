Imports System.Windows.Forms

Public Class ttranschallancharges

    Friend id As Integer
    Friend mode As enEntry
    Friend challan As frmChallan
    Dim dv As DataView
    Dim isLoading As Boolean
    Private Sub TransChallanItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        isLoading = True
        Dim dt As DataTable = dbTable("Select mcharges.*,mledger.ledger from mcharges left join mledger on mledger.id = mcharges.acid order by Charge ")
        For Each row In dt.Rows
            cmbCharges.Items.Add(New cbItem(row("id"), row("charge")))
            cmbCharges.DisplayMember = "display"
            cmbCharges.ValueMember = "value"
        Next
        'cmbCharges.DataSource = dt
        'cmbCharges.ValueMember = "Id"
        'cmbCharges.DisplayMember = "Charge"
        dv = dt.DefaultView

        If mode = enEntry.Edit Or mode = enEntry.Delete Or mode = enEntry.View Then
            Dim row As DataGridViewRow = challan.dgvCharges.SelectedRows(0)
            For i = 0 To cmbCharges.Items.Count - 1
                If cmbCharges.Items(i).display = row.Cells("Charge").Value Then
                    cmbCharges.SelectedIndex = i
                    Exit For
                End If
            Next
            If cmbCharges.SelectedIndex > -1 Then
                dv.RowFilter = "Id = " & cmbCharges.SelectedItem.value
                txtrateOn.Text = enRateOn.GetNames(GetType(enRateOn))(dv(0)("RateOn"))
                txtrateOn.Tag = dv(0)("RateOn")
                lblAddLess.Text = IIf(dv(0)("addless"), "-", "+")
                ntxtRate.value = row.Cells("rate").Value
                ntxtAmtOn.value = row.Cells("AmountOn").Value
                ntxtAmount.value = row.Cells("Amount").Value
                txtAccount.Text = row.Cells("Account").Value
                dv.RowFilter = ""
            End If

        End If
        isLoading = False
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If cmbCharges.SelectedIndex = -1 Then
            cmbCharges.Focus()
            MessageBox.Show("Please select charges", Me.Text)
            Exit Sub
        End If

        If mode = enEntry.Edit Then
            Dim row As DataGridViewRow = challan.dgvCharges.SelectedRows(0)
            row.Cells("ChargeId").Value = cmbCharges.SelectedItem.value
            row.Cells("Charge").Value = cmbCharges.SelectedItem.display
            row.Cells("AmountOn").Value = ntxtAmtOn.value
            row.Cells("RateOn").Value = txtrateOn.Text
            row.Cells("RateOnid").Value = txtrateOn.Tag
            row.Cells("Rate").Value = ntxtRate.value
            row.Cells("Amount").Value = ntxtAmount.value * IIf(lblAddLess.Text = "+", 1, -1)
            row.Cells("Account").Value = txtAccount.Text

        ElseIf mode = enEntry.Add Then
            With challan.dgvCharges
                Dim dv As DataView = CType(.DataSource, DataView)
                dv.AddNew()
                dv(dv.Count - 1)("challanid") = challan.id
            End With
            '     challan.dgvCharges.Rows.Add()

            Dim row As DataGridViewRow = challan.dgvCharges.Rows(challan.dgvCharges.RowCount - 1)
            row.Cells("ChargeId").Value = cmbCharges.SelectedItem.value
            row.Cells("Charge").Value = cmbCharges.SelectedItem.display
            row.Cells("AmountOn").Value = ntxtAmtOn.value
            row.Cells("RateOn").Value = txtrateOn.Text
            row.Cells("RateOnid").Value = txtrateOn.Tag
            row.Cells("Rate").Value = ntxtRate.value
            row.Cells("Amount").Value = ntxtAmount.value * IIf(lblAddLess.Text = "+", 1, -1)
            row.Cells("Account").Value = txtAccount.Text
        End If


        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        challan.dgvCharges.Refresh()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub





    Private Sub cmbCharges_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCharges.SelectedValueChanged

        If Not isLoading Then
            With challan.dgvCharges

                dv.RowFilter = "Id = " & cmbCharges.SelectedItem.value
                txtrateOn.Text = enRateOn.GetNames(GetType(enRateOn))(dv(0)("RateOn"))
                lblAddLess.Text = IIf(dv(0)("addless"), "-", "+")
                txtAccount.Text = dv(0)("Ledger") & ""
                ntxtRate.value = dv(0)("RATE")
                Dim rateon As enRateOn = dv(0)("rateon")
                txtrateOn.Tag = rateon
                Select Case rateon
                    Case enRateOn.Actual
                    Case enRateOn.None
                    Case enRateOn.Previous
                        If challan.dgv.RowCount = 1 Then
                            MsgBox("You can not select charge on previous value here", , Me.Text)
                            cmbCharges.Focus()
                            Exit Sub
                        End If
                        ntxtAmtOn.value = .Rows(.SelectedRows(0).Index - 1).Cells("Amount").Value
                        ntxtAmount.value = ntxtAmtOn.value * ntxtRate.value / 100
                        ntxtAmount.value *= IIf(lblAddLess.Text = "+", 1, -1)

                    Case enRateOn.SubTotal
                        If challan.dgv.RowCount = 1 Then
                            MsgBox("You can not select charge on sub-total here", , Me.Text)
                            cmbCharges.Focus()
                            Exit Sub
                        End If
                        Dim amt As Double = challan.ntxtGrossAmt.value
                        For i = 0 To .SelectedRows(0).Index
                            amt += .Rows(i).Cells("Amount").Value
                        Next
                        ntxtAmount.value = amt
                        ntxtAmount.value *= IIf(lblAddLess.Text = "+", 1, -1)
                    Case enRateOn.Value
                        ntxtAmtOn.value = challan.ntxtGrossAmt.value
                        ntxtAmount.value = challan.ntxtGrossAmt.value * ntxtRate.value / 100
                        ntxtAmount.value *= IIf(lblAddLess.Text = "+", 1, -1)




                End Select

            End With
            dv.RowFilter = ""

        End If
    End Sub
End Class

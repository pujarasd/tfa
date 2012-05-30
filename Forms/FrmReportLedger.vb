Imports System.Windows.Forms
Public Class FrmReportLedger
    Private Sub FrmReportLedger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Party Ledger "
        Dim qry As String = "select mLedger.id,mledger.ledger +' ~ '+mledgergroup.groupname as Party,mledger.ledger,mledgergroup.groupname from mLedger,mledgergroup WHERE mledger.groupId = mLedgerGroup.Id order by mLedger.ledger"
        Dim dt As DataTable
        dt = dbTable(qry)
        With cboSelect
            .DataSource = dt
            .DisplayMember = "Party"
            .ValueMember = "id"
        End With
    End Sub
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim oCfrm As New sledger(cboSelect.SelectedItem(0), cboSelect.SelectedItem(2), dtpFrom.Value, dtpTo.Value, cboSelect.SelectedItem(3))
        oCfrm.ShowDialog()

        oCfrm = Nothing
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub cboSelect_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboSelect.Validating
        If Me.ActiveControl.Name <> "btnCancel" Then
            If cboSelect.SelectedIndex < 0 Then
                MsgBox("Please Select Proper Value")
                e.Cancel = True
            End If
        End If
    End Sub
End Class

Public Class FrmReport
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub rbDatewise_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDatewise.CheckedChanged
        ''        cboSelect.DataSource = Nothing
        If rbDatewise.Checked = True Then
            fillcombo(cboSelect, "mLedger", "Ledger")
        End If
    End Sub
    Private Sub rbPartywise_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPartywise.CheckedChanged
        If rbPartywise.Checked = True Then
            fillcombo(cboSelect, "mLedger", "Ledger")
        End If
    End Sub
    Private Sub rbTransportwise_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTransportwise.CheckedChanged
        If rbTransportwise.Checked = True Then
            fillcombo(cboSelect, "mLedger", "Ledger")
        End If
    End Sub
    Private Sub rbChallanwise_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbChallanwise.CheckedChanged
        If rbChallanwise.Checked = True Then
            txtNofrom.Visible = True
            txtNoto.Visible = True
            txtNofrom.value = 0
            txtNoto.value = 0
            lblnoFrom.Visible = True
            lblnoto.Visible = True
            lbldtfrom.Visible = False
            lbldateto.Visible = False
            dtpFrom.Visible = False
            dtpTo.Visible = False
            fillcombo(cboSelect, "mLedger", "Ledger")
        Else
            txtNofrom.Visible = False
            txtNoto.Visible = False
            txtNofrom.value = 0
            txtNoto.value = 0
            lblnoFrom.Visible = False
            lblnoto.Visible = False
            lbldtfrom.Visible = True
            lbldateto.Visible = True
            dtpFrom.Visible = True
            dtpTo.Visible = True
        End If
    End Sub
    'Public Sub FillAutocomplete(ByVal ctrlname As Object, ByVal tblname As String, ByVal fldname As String, Optional ByVal catid As Integer = 0)
    '    ''''Code by Gaurav on dt 18/02/2012 
    '    Dim cSql As String = "SELECT DISTINCT  " & fldname & " FROM " & tblname   ''& " Where catid =  " & catid
    '    Dim cmd As New OleDbCommand(cSql)
    '    Dim dt As New DataTable
    '    Dim da As New OleDbDataAdapter(cmd)
    '    da.Fill(dt) '' list can be any name u want
    '    Dim col As New AutoCompleteStringCollection
    '    Dim i As Integer
    '    For i = 0 To dt.Rows.Count - 1
    '        col.Add(dt.Rows(i)(0).ToString()) ''columnname same as in query
    '    Next
    '    ctrlname.AutoCompleteCustomSource = col
    '    ctrlname.AutoCompleteMode = AutoCompleteMode.Suggest
    '    ctrlname.AutoCompleteSource = AutoCompleteSource.CustomSource
    '    dt = Nothing
    '    da = Nothing
    '    cmd = Nothing
    '    ''Till here Code by Gaurav on dt 18/02/2012 
    'End Sub

    Private Sub FrmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdbDetail.Checked = True
    End Sub
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim qry As String = ""
        Dim dtsum As String = ""
        Dim criteria As String = ""
        Try
            If rdbDetail.Checked Then
                dtsum = rdbDetail.Text
                qry = <string>
                select ttchallan.ID, ttchallan.BookId, ttchallan.Challan, ttchallan.Date,
                mLedger.Ledger, mLedger1.Ledger as Transport, mCity.city as cityfrom ,mCity1.city as Cityto,
                ttChallan.tWeight, round(ttchallan.GrossAmount/ttchallan.tWeight,10,2) as rate ,
                ttchallan.GrossAmount,ttchallan.commission,ttchallan.advance+ttchallan.dasti+ttchallan.Labour as tAdvance,
                ttchallan.tds_rate,ttchallan.tds_rate
                FROM ttchallan INNER JOIN
                mLedger ON mLedger.Id = ttchallan.CustId INNER JOIN
                mCity on mCity.id = ttchallan.cityFrom INNER JOIN
                mCity as mCity1 on mCity1.id = ttchallan.cityto INNER JOIN
                mLedger as mLedger1 ON mLedger1.Id = ttchallan.TransportId where 
               </string>
            ElseIf rdbSummary.Checked Then
                dtsum = rdbSummary.Text
                qry = <string>
                select ttchallan.ID, ttchallan.BookId, ttchallan.Challan, ttchallan.Date,
                mLedger.Ledger, mLedger1.Ledger as Transport, mCity.city as cityfrom ,mCity1.city as Cityto,
                ttChallan.tWeight, round(ttchallan.GrossAmount/ttchallan.tWeight,10,2) as rate ,
                ttchallan.GrossAmount,ttchallan.commission,ttchallan.advance+ttchallan.dasti+ttchallan.Labour as tAdvance,
                ttchallan.tds_rate,ttchallan.tds_rate
                FROM ttchallan INNER JOIN
                mLedger ON mLedger.Id = ttchallan.CustId INNER JOIN
                mCity on mCity.id = ttchallan.cityFrom INNER JOIN
                mCity as mCity1 on mCity1.id = ttchallan.cityto INNER JOIN
                mLedger as mLedger1 ON mLedger1.Id = ttchallan.TransportId where 
               </string>
            End If

            If Not chkConsole.Checked Then qry = qry & " ttchallan.coId = " & gCoId & " and "
            If rbDatewise.Checked Then
                If cboSelect.SelectedIndex > 0 Then qry = qry & " mLedger.id = " & cboSelect.SelectedItem(0) & " and "
                criteria = dtsum & " Register Date Wise From Date " & dtpFrom.Text & " to " & dtpTo.Text & " :" & cboSelect.SelectedItem(1)
                qry = qry & " ttchallan.Date >= '" & sqldate(dtpFrom.Value) & "' and ttchallan.date <= '" & sqldate(dtpTo.Value) _
                & "' Order by ttchallan.Date "
            ElseIf rbPartywise.Checked Then
                If cboSelect.SelectedIndex > 0 Then qry = qry & " mLedger.id = " & cboSelect.SelectedItem(0) & " and "
                criteria = dtsum & " Register Customer Wise From Date " & dtpFrom.Text & " to " & dtpTo.Text & " :" & cboSelect.SelectedItem(1)
                qry = qry & " ttchallan.Date >= '" & sqldate(dtpFrom.Value) & "' and ttchallan.date <= '" & sqldate(dtpTo.Value) _
                & "' Order by mLedger.ledger "
            ElseIf rbTransportwise.Checked Then
                If cboSelect.SelectedIndex > 0 Then qry = qry & " mLedger1.id = " & cboSelect.SelectedItem(0) & " and "
                criteria = dtsum & " Register Transport Wise From Date " & dtpFrom.Text & " to " & dtpTo.Text & " :" & cboSelect.SelectedItem(1)
                qry = qry & " ttchallan.Date >= '" & sqldate(dtpFrom.Value) & "' and ttchallan.date <= '" & sqldate(dtpTo.Value) _
                & "' Order by mLedger1.Ledger,ttchallan.Challan "
            ElseIf rbChallanwise.Checked Then
                If cboSelect.SelectedIndex > 0 Then qry = qry & " mLedger.id = " & cboSelect.SelectedItem(0) & " and "
                criteria = dtsum & " Register Challan Wise From Challan " & txtNofrom.value & " to " & txtNoto.value & " :" & cboSelect.SelectedItem(1)
                qry = qry & " ttchallan.challan >= '" & txtNofrom.value & "' and ttchallan.challan  <= '" & txtNoto.value _
                & "' Order by ttchallan.challan  "
            End If
        Catch ex As Exception
            Me.Close()
        End Try
        Dim oo As New ReportViewer
        oo.rQuery = qry
        If rdbSummary.Checked Then
            oo.reportname = "RptRegisterSummary"
        Else
            oo.reportname = "RptRegisterDetails"
        End If
        oo.rCriteria = criteria
        oo.ShowDialog()
        oo = Nothing
    End Sub
    Private Sub fillcombo(ByVal ctrlname As Object, ByVal tblname As String, ByVal fldname As String)
        ''
        Try
            cboSelect.Items.Clear()
        Catch
            cboSelect.DataSource = Nothing
        End Try
        Dim qry As String = ""
        If rbTransportwise.Checked Then
            qry = " with cte as  " & _
            "(select * from mledgergroup where groupid = " & enLedger.Creditors & _
            " union all " & _
            " select t.* from cte inner join mledgergroup t on t.groupid = cte.id) " & _
            " select mledger.id,mledger.ledger+' ~ '+cte.groupname as ledger from cte inner join mledger on mledger.groupid = cte.id order by ledger "
        Else
            qry = " with cte as  " & _
            "(select * from mledgergroup where groupid = " & enLedger.Debtors & _
            " union all " & _
            " select t.* from cte inner join mledgergroup t on t.groupid = cte.id) " & _
            " select mledger.id,mledger.ledger +' ~ '+cte.groupname as ledger from cte inner join mledger on mledger.groupid = cte.id order by ledger "
        End If
        ''
        Dim dt As DataTable
        Dim row As DataRow
        dt = dbTable(qry)
        If dt.Rows.Count > 0 Then
            row = dt.NewRow
            row("ledger") = "(All)"
            row("id") = -1
            dt.Rows.InsertAt(row, 0)
        End If
        cboSelect.DataSource = dt
        cboSelect.ValueMember = "Ledger"
        cboSelect.ValueMember = "id"
        cboSelect.SelectedIndex = 0

        dt = Nothing
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
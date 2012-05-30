Imports System.Data.OleDb
Public Class FrmReport1
    Friend Reportname As String = ""
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub rbDatewise_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDatewise.CheckedChanged
        If rbDatewise.Checked = True Then
            fillcombo(cboSelect, "mLedger", "Ledger")
        End If
    End Sub
    Private Sub rbPartywise_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPartywise.CheckedChanged
        If rbPartywise.Checked = True Then
            fillcombo(cboSelect, "mLedger", "Ledger")
        End If
    End Sub
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Dim qry As String = ""
        Dim criteria As String = ""
        ''
        Select Case Reportname
            Case "RptFreightMargin"
                qry = _
                <string>
                    SELECT ttchallan.ID, ttchallan.BookId, ttchallan.Challan, ttchallan.Date, ttchallan.CustId, 
                    ttchallan.TransportId, ttchallan.GrossAmount, ttchallan.Commission, 
                    ttchallan.CommPercent, mLedger.Ledger, mLedger1.Ledger as Transport
                    FROM            ttchallan INNER JOIN
                    mLedger ON mLedger.Id = ttchallan.CustId INNER JOIN
                    mLedger as mLedger1 ON mLedger1.Id = ttchallan.TransportId
                </string>
                ''WHERE        (ttchallan.Commission  != 0) and 
                If chkAmount.Checked Then
                    qry = qry & " WHERE (ttchallan.Commission >=  " & NumTextBox1.value & " ) and (ttchallan.Commission <= " & NumTextBox2.value & " ) and   "
                Else
                    qry = qry & " WHERE (ttchallan.Commpercent >=  " & NumTextBox1.value & " ) and (ttchallan.Commpercent <= " & NumTextBox2.value & " ) and   "
                End If
                If Not chkConsole.Checked Then qry = qry & " ttchallan.coId = " & gCoId & " and "
                If cboSelect.SelectedIndex > 0 Then qry = qry & " mLedger.id = " & cboSelect.SelectedItem(0) & " and "
                If rbDatewise.Checked Then
                    criteria = "Freight Margin Statement Date Wise From " & dtpFrom.Text & " to " & dtpTo.Text & " :" & cboSelect.SelectedItem(1)
                    qry = qry & " ttchallan.Date >= '" & sqldate(dtpFrom.Value) & "' and ttchallan.date <= '" & sqldate(dtpTo.Value) _
                    & "' Order by ttchallan.Date "
                ElseIf rbPartywise.Checked Then
                    criteria = "Freight Margin Statement Party Wise From " & dtpFrom.Text & " to " & dtpTo.Text & " :" & cboSelect.SelectedItem(1)
                    qry = qry & " ttchallan.Date >= '" & sqldate(dtpFrom.Value) & "' and ttchallan.date <= '" & sqldate(dtpTo.Value) _
                    & "' Order by mLedger.Ledger,ttchallan.Date "
                End If
            Case "RptStaxstatment"
                qry = _
                <string>select ttchallan.ID, ttchallan.BookId, ttchallan.Challan, ttchallan.Date,
                mLedger.Ledger, mLedger1.Ledger as Transport, mCity.city as cityfrom ,mCity1.city as Cityto,
                ttChallan.tWeight, round(ttchallan.GrossAmount/ttchallan.tWeight,10,3) as rate ,
                ttchallan.GrossAmount,ttchallan.StaxPercent,ttchallan.Stax
                FROM ttchallan INNER JOIN
                mLedger ON mLedger.Id = ttchallan.CustId INNER JOIN
                mCity on mCity.id = ttchallan.cityFrom INNER JOIN
                mCity as mCity1 on mCity1.id = ttchallan.cityto INNER JOIN
                mLedger as mLedger1 ON mLedger1.Id = ttchallan.TransportId 
                </string>
                If chkAmount.Checked Then
                    qry = qry & " WHERE (ttchallan.stax >=  " & NumTextBox1.value & " ) and (ttchallan.stax <= " & NumTextBox2.value & " ) and   "
                Else
                    qry = qry & " WHERE (ttchallan.Staxpercent >=  " & NumTextBox1.value & " ) and (ttchallan.Staxpercent <= " & NumTextBox2.value & " ) and   "
                End If
                If Not chkConsole.Checked Then qry = qry & " ttchallan.coId = " & gCoId & " and "

                If cboSelect.SelectedIndex > 0 Then qry = qry & " mLedger.id = " & cboSelect.SelectedItem(0) & " and "
                If rbDatewise.Checked Then
                    criteria = "Service Tax Statement Date Wise From " & dtpFrom.Text & " to " & dtpTo.Text & " :" & cboSelect.SelectedItem(1)
                    qry = qry & " ttchallan.Date >= '" & sqldate(dtpFrom.Value) & "' and ttchallan.date <= '" & sqldate(dtpTo.Value) _
                    & "' Order by ttchallan.Date "
                ElseIf rbPartywise.Checked Then
                    criteria = "Service Tax Statement Party Wise From " & dtpFrom.Text & " to " & dtpTo.Text & " :" & cboSelect.SelectedItem(1)
                    qry = qry & " ttchallan.Date >= '" & sqldate(dtpFrom.Value) & "' and ttchallan.date <= '" & sqldate(dtpTo.Value) _
                    & "' Order by mLedger.Ledger,ttchallan.Date "
                End If
            Case "RptTdsStatment"
                qry = _
                <string>
                    SELECT ttchallan.ID, ttchallan.BookId, ttchallan.LRNo, ttchallan.Challan, ttchallan.Date, ttchallan.CustId, ttchallan.TransportId, ttchallan.Tds_rate, ttchallan.Tds_amount, 
                    mLedger.Ledger, mLedger1.ledger as Transport
                    FROM            ttchallan INNER JOIN
                    mLedger ON mLedger.Id = ttchallan.CustId INNER JOIN
                    mLedger as mLedger1 ON mLedger1.Id = ttchallan.TransportId
                      </string>
                If chkAmount.Checked Then
                    qry = qry & " WHERE (ttchallan.tds_amount >=  " & NumTextBox1.value & " ) and (ttchallan.tds_amount <= " & NumTextBox2.value & " ) and   "
                Else
                    qry = qry & " WHERE (ttchallan.tds_rate >=  " & NumTextBox1.value & " ) and (ttchallan.tds_rate  <= " & NumTextBox2.value & " ) and   "
                End If
                If Not chkConsole.Checked Then qry = qry & " ttchallan.coId = " & gCoId & " and "
                If cboSelect.SelectedIndex > 0 Then qry = qry & " mLedger.id = " & cboSelect.SelectedItem(0) & " and "
                If rbDatewise.Checked Then
                    criteria = "TDS Statement Date Wise From " & dtpFrom.Text & " to " & dtpTo.Text & " :" & cboSelect.SelectedItem(1)
                    qry = qry & " ttchallan.Date >= '" & sqldate(dtpFrom.Value) & "' and ttchallan.date <= '" & sqldate(dtpTo.Value) _
                    & "' Order by ttchallan.Date "
                ElseIf rbPartywise.Checked Then
                    criteria = "TDS Statement Party Wise From " & dtpFrom.Text & " to " & dtpTo.Text & " :" & cboSelect.SelectedItem(1)
                    qry = qry & " ttchallan.Date >= '" & sqldate(dtpFrom.Value) & "' and ttchallan.date <= '" & sqldate(dtpTo.Value) _
                    & "' Order by mLedger.Ledger,ttchallan.Date "
                End If

            Case "RptMarginStatment"
                qry = _
                <string>
                  SELECT ttchallan.ID, ttchallan.BookId, ttchallan.Challan, ttchallan.Date, ttchallan.CustId, 
                    ttchallan.TransportId, ttchallan.GrossAmount, ttchallan.VarGrossAmt, 
                    ttchallan.VarMargin, mLedger.Ledger, mLedger1.ledger as Transport
                    FROM            ttchallan INNER JOIN
                    mLedger ON mLedger.Id = ttchallan.CustId INNER JOIN
                    mLedger as mLedger1 ON mLedger1.Id = ttchallan.TransportId
                    WHERE        (ttchallan.VarMargin  != 0) and 
               </string>
                If Not chkConsole.Checked Then qry = qry & " ttchallan.coId = " & gCoId & " and "
                If cboSelect.SelectedIndex > 0 Then qry = qry & " mLedger.id = " & cboSelect.SelectedItem(0) & " and "
                If rbDatewise.Checked Then
                    criteria = "Margin Statement(RV) Date Wise From " & dtpFrom.Text & " to " & dtpTo.Text & " :" & cboSelect.SelectedItem(1)
                    qry = qry & " ttchallan.Date >= '" & sqldate(dtpFrom.Value) & "' and ttchallan.date <= '" & sqldate(dtpTo.Value) _
                    & "' Order by ttchallan.Date "
                ElseIf rbPartywise.Checked Then
                    criteria = "Margin Statement(RV) Party Wise From " & dtpFrom.Text & " to " & dtpTo.Text & " :" & cboSelect.SelectedItem(1)
                    qry = qry & " ttchallan.Date >= '" & sqldate(dtpFrom.Value) & "' and ttchallan.date <= '" & sqldate(dtpTo.Value) _
                    & "' Order by mLedger.Ledger,ttchallan.Date "
                End If
        End Select

        ''
        Dim oo As New ReportViewer
        oo.rQuery = qry
        oo.reportname = Reportname
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
        qry = " with cte as  " & _
            "(select * from mledgergroup where groupid = " & enLedger.Debtors & _
            " union all " & _
            " select t.* from cte inner join mledgergroup t on t.groupid = cte.id) " & _
            " select mledger.id,mledger.ledger +' ~ '+cte.groupname as ledger from cte inner join mledger on mledger.groupid = cte.id order by ledger "
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

    Private Sub FrmReport1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Reportname = "RptMarginStatment" Then
            Me.Text = "Freight Margin(RV) Statement"
            chkAmount.Checked = True
        ElseIf Reportname = "RptStaxstatment" Then
            Me.Text = "Service Tax Statement"
        ElseIf Reportname = "RptTdsStatment" Then
            Me.Text = "Tds Statement"
        ElseIf Reportname = "RptFreightMargin" Then
            Me.Text = "Margin Statement"
        End If
        rdbDetail.Checked = True
    End Sub
    Private Sub chkAmount_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAmount.CheckedChanged
        If chkAmount.Checked Then
            lblnoFrom.Text = "Amt. From"
            lblnoto.Text = "Amt. To"
        Else
            lblnoFrom.Text = "% From"
            lblnoto.Text = "% To"
        End If

        If Reportname = "RptMarginStatment" Then
            chkAmount.Checked = True
            NumTextBox1.Focus()
            Exit Sub
        End If
        NumTextBox1.Focus()
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
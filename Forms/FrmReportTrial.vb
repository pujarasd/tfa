Imports Microsoft.Reporting.WinForms
Imports System.Windows.Forms
Public Class FrmReportTrial
    Private aQry As String = ""
    Private Sub FrmReportTrial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillDgv()
    End Sub
    Sub fillDgv()
        Dim qry As String
        If Not chkConsole.Checked Then
            qry = <string> 
            select  coid,accid,ledger,groupname,  sum(debit) as debit, sum(credit) as credit, sum(debit-credit) as balance from 
            (select a.coid,a.accid,c.groupname,b.ledger,
            (case type when 'Dr' then amount else 0 end) as debit, 
            (case type when 'Cr' then amount else 0 end) as credit
            from tdatamain a inner join mledger b on b.id=a.accid 
            inner join mledgergroup c on  c.id = b.groupid 
            where coid = <%= gCoId %>  and voucher like '%bank%' or voucher like '%cash%' and date &lt;='<%= sqldate(dtpFrom.Value.Date) %>' ) 
            as a group by coid,accid ,ledger,groupname
            union
            select  coid,accid,ledger,groupname,  sum(debit) as debit, sum(credit) as credit, sum(debit-credit) as balance  from 
            (select coid,a.accid,c.groupname,b.ledger,
            (case type when 'Dr' then amount else 0 end) as debit, 
            (case type when 'Cr' then amount else 0 end) as credit
             from tdatadetails a inner join mledger b on b.id=a.accid 
            inner join mledgergroup c on  c.id = b.groupid where coid = <%= gCoId %>  and date &lt;='<%= sqldate(dtpFrom.Value.Date) %>' ) 
            as a 
            group by coid,accid ,ledger,groupname order by Ledger  
            </string>
        Else
            qry = <string> 
            select  accid,ledger,groupname,  sum(debit) as debit, sum(credit) as credit, sum(debit-credit) as balance from 
            (select a.accid,c.groupname,b.ledger,
            (case type when 'Dr' then amount else 0 end) as debit, 
            (case type when 'Cr' then amount else 0 end) as credit
            from tdatamain a inner join mledger b on b.id=a.accid 
            inner join mledgergroup c on  c.id = b.groupid 
            where voucher like '%bank%' or voucher like '%cash%'  and date &lt;='<%= dtpFrom.Value %>' ) 
            as a group by accid ,ledger,groupname
            union
            select  accid,ledger,groupname,  sum(debit) as debit, sum(credit) as credit, sum(debit-credit) as balance  from 
            (select a.accid,c.groupname,b.ledger,
            (case type when 'Dr' then amount else 0 end) as debit, 
            (case type when 'Cr' then amount else 0 end) as credit
             from tdatadetails a inner join mledger b on b.id=a.accid 
            inner join mledgergroup c on  c.id = b.groupid   where date &lt;='<%= dtpFrom.Value %>' ) 
            as a 
            group by accid ,ledger,groupname order by Ledger  
            </string>
            ''        If Not chkConsole.Checked Then qry &= " where coid = " & gCoId
        End If

        Dim drTotal As Double
        Dim crTotal As Double
        Dim dt As DataTable
        aQry = qry  ''Line Added by Gaurav on dt 20-05-2012
        dt = dbTable(qry)
        dgv.Rows.Clear()
        dgv.Columns.Clear()
        dgv.Columns.Add("Account", "Account Name")
        dgv.Columns.Add("debit", "Debit")
        dgv.Columns.Add("credit", "Credit")
        dgv.Columns.Add("Balance", "Balance")
        dgv.Columns.Add("DC", "Dr/Cr")
        dgv.Columns.Add("Acgroup", "Groupname")
        For i = 0 To dt.Rows.Count - 1
            dgv.Rows.Add()
            dgv.Rows(i).Cells("account").Value = dt.Rows(i).Item("Ledger")
            dgv.Rows(i).Cells("Debit").Value = dt.Rows(i).Item("Debit")
            dgv.Rows(i).Cells("Credit").Value = dt.Rows(i).Item("Credit")
            dgv.Rows(i).Cells("Balance").Value = Math.Abs(dt.Rows(i).Item("Balance"))
            dgv.Rows(i).Cells("DC").Value = IIf(dt.Rows(i).Item("Balance") > 0, "Dr", "Cr")
            dgv.Rows(i).Cells("acgroup").Value = dt.Rows(i).Item("Groupname")
            drTotal = drTotal + dt.Rows(i).Item("Debit")
            crTotal = crTotal + dt.Rows(i).Item("Credit")
        Next
        numDebit.value = drTotal
        numCredit.value = crTotal
        numBal.value = Math.Abs(drTotal - crTotal)

        dgvdefault(dgv)
        With dgv.Columns("acgroup")
            .Visible = False
        End With
        With dgv.Columns("Account")
            .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Width = 250
        End With
        With dgv.Columns("Debit")
            ''          .CellTemplate.Style.Format = "f2"
            .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            .Width = 100
        End With
        With dgv.Columns("Credit")
            ''        .CellTemplate.Style.Format = "f2"
            .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            .Width = 100
        End With
        With dgv.Columns("Balance")
            ''            .CellTemplate.Style.Format = "f2"
            .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            .Width = 100
        End With
        With dgv.Columns("DC")
            .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Width = 40
        End With
    End Sub
    Private Sub dgv_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.RowEnter
        lblAccount.Text = dgv.Rows(e.RowIndex).Cells("acgroup").Value
    End Sub
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        fillDgv()
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim orpt As New ReportViewer
        orpt.rCriteria = "Trial Balance " & Label1.Text & " " & dtpFrom.Value.Date
        orpt.reportname = "rptTrial"
        orpt.rQuery = aQry
        orpt.ShowDialog()
        ' ''Dim datasetname As String = "AccountsDataSet_" & "DataTableTrial"
        ' ''Dim rCriteria As String = 
        ' ''With ReportViewer1
        ' ''    .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ' ''    With .LocalReport
        ' ''        .ReportPath = Application.StartupPath & "\reports\rptTrial.rdlc"
        ' ''        .DataSources.Clear()
        ' ''        If .GetParameters.Count > 0 Then
        ' ''            Dim para As New ReportParameter("Company", gCompany)
        ' ''            Dim para1 As New ReportParameter("Criteria", rCriteria)
        ' ''            Dim paralist As New List(Of ReportParameter)
        ' ''            paralist.Add(para)
        ' ''            paralist.Add(para1)
        ' ''            .SetParameters(paralist)

        ' ''        End If
        ' ''        ''                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource(datasetname, ds1.Tables(0)))
        ' ''        .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource(datasetname, dt))
        ' ''    End With
        ' ''    Me.ReportViewer1.Visible = True
        ' ''    .RefreshReport()
        ' ''End With
    End Sub

    Private Sub chkConsole_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkConsole.CheckedChanged
        btnOk_Click(sender, e)
    End Sub
End Class

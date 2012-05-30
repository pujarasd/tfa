Public Class sledger
    Dim _accid As Integer
    Dim _fromdate As Date
    Dim _todate As Date
    Dim _Account As String
    Dim _groupname As String
    Private Sub Account_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '        _accid = 30
        '       _fromdate = CDate("01-Apr-2012")
        '      _todate = CDate("31-Mar-2013")
        '     _Account = "3005-RJ-22-GA"
        Me.Text = "Ledger of A/c. " & _Account ''& " From " & _fromdate & " to " & _todate
        lblAccount.Text = _Account
        lblFrom.Text = Format(_fromdate, "dd-MM-yyyy")
        lblTo.Text = Format(_todate, "dd-MM-yyyy")
        Dim qstr As String = ""
        qstr = _
        <string>
            select b.ledger,a.lineid,
            c.voucherno,c.voucherprefix,c.vouchersuffix,
            a.date,a.Amount,a.narration,a.chqno,a.chqdate,a.bank,a.branch,a.type,c.accid,c.voucher,c.id ,c.coid,c.period
            from tdatadetails a 
            inner join tdatamain c on c.id = a.voucherid
            inner join mledger b on b.id=c.accid
            where a.accid = <%= _accid %> and a.date between '<%= sqldate(_fromdate) %>' and '<%= sqldate(_todate) %>'
            and a.coid = <%= gCoId %>




        </string>

        Dim qstr1 As String = ""
        If _groupname.ToLower.Contains("cash") Or _groupname.ToLower.Contains("bank") Then
            qstr1 = _
            <string>
        union
        select c.ledger, 0 as lineid, 
        a.voucherno,a.voucherprefix, a.vouchersuffix,
        a.date, a.amount, a.narration,a.chqno,a.chqdate,
        a.bank,a.branch,a.type,a.accid, a.voucher, a.id, a.coid, a.period
        from tdatamain a 
        inner join tdatadetails b on b.voucherid = a.id
        inner join mledger c on c.id=b.accid 
        where a.accid = <%= _accid %> and a.date between '<%= sqldate(_fromdate) %>' and '<%= sqldate(_todate) %>'
        and a.coid = <%= gCoId %>

            </string>
        End If

        '  If _accid = 8 Then
        qstr &= qstr1
        '    End If
        qstr &= "            order by ledger,date,id,lineid"

        'union()

        'select c.ledger, 0 as lineid, 
        'a.voucherno,a.voucherprefix, a.vouchersuffix,
        'a.date, a.amount, a.narration,a.chqno,a.chqdate,
        'a.bank,a.branch,a.type,a.accid, a.voucher, a.id, a.coid, a.period
        'from tdatamain a 
        'inner join tdatadetails b on b.voucherid = a.id
        'inner join mledger c on c.id=b.accid 
        'where a.accid = <%= _accid %> and a.date between '<%= sqldate(_fromdate) %>' and '<%= sqldate(_todate) %>'
        'and a.coid = <%= gCoId %>



        'select b.ledger,a.lineid,
        'c.voucherno,c.voucherprefix,c.vouchersuffix,
        'a.date,a.Amount,a.narration,a.chqno,a.chqdate,a.bank,a.branch,a.type,c.accid,c.voucher,c.id ,c.coid,c.period
        'from tdatadetails a 
        'inner join tdatamain c on c.id = a.voucherid
        'inner join mledger b on b.id=a.accid
        'where C.accid = <%= _accid %> and a.date between '<%= sqldate(_fromdate) %>' and '<%= sqldate(_todate) %>'
        Dim dt As DataTable = dbTable(qstr)
        modData.SetDefaultClearNull(dt)
        qstr = _
        <string>
        select sum(a.amount) from (
        select a.ledgerid as accid,sum(case type when 'Dr' then a.amount else -a.amount end) as amount from mledgeropbal a  where a.ledgerid = <%= _accid %> and opdate &lt;='<%= sqldate(_fromdate) %>'  group by ledgerid 
        union 
        select accid,sum(case type when 'Dr' then a.amount else -a.amount end) as amount from tdatadetails a  where accid = <%= _accid %> and date&lt;='<%= sqldate(_fromdate) %>' group by accid ) as a
        </string>
        Dim opbal As Double = nz(dbValue(qstr), 0)
        If opbal <> 0 Then
            Dim row As DataRow = dt.NewRow
            row("voucher") = "OpBal"
            row("Amount") = Math.Abs(opbal)
            row("Type") = IIf(opbal > 0, "Dr", "Cr")
            row("ledger") = ""
            row("lineid") = 0
            row("Voucherno") = 0
            row("VoucherPrefix") = ""
            row("vouchersuffix") = ""
            row("Date") = _fromdate.AddDays(-1)
            row("coid") = gCoId
            ' 
            dt.Rows.Add(row)
        End If
        ''Line added by Gaurav on dt 29/04/2012
        '' '' '' ''If dt.Rows.Count <= 0 Then
        '' '' '' ''    MsgBox("Nothing to Show")
        '' '' '' ''    Return
        '' '' '' ''    Exit Sub
        '' '' '' ''End If
        ''Till here 29/04/2012

        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        dgv.Columns.Add("Date", "Date")
        dgv.Columns.Add("Voucher", "Voucher")
        dgv.Columns.Add("details", "Particulars")
        dgv.Columns.Add("Debit", "Debit Amount")
        dgv.Columns.Add("Credit", "Credit Amount")
        dgv.Columns.Add("Balance", "Balance")
        dgv.Columns.Add("Narration", "Narration")
        dgv.Columns("narration").Visible = False
        With dgv.Columns("Date")
            .CellTemplate.Style.Format = "d"
            .Width = 80
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        With dgv.Columns("Voucher")
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        With dgv.Columns("details")
            .Width = 300
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        With dgv.Columns("Debit")
            .CellTemplate.Style.Format = "f2"
            .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            .Width = 100
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        With dgv.Columns("Credit")
            .CellTemplate.Style.Format = "f2"
            .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            .Width = 100
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        With dgv.Columns("Balance")
            .CellTemplate.Style.Format = "f2"
            .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            .Width = 100
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        dgvdefault(dgv)

        dgv.AllowUserToResizeColumns = False
        Dim bal As Double = 0
        Dim dtotal As Double = 0
        Dim ctotal As Double = 0
        Dim dv As DataView = dt.DefaultView

        dv.Sort = "date"
        For Each row As DataRowView In dv
            dgv.Rows.Add()
            Dim drow As DataGridViewRow = dgv.Rows(dgv.RowCount - 1)
            drow.Cells("Date").Value = IIf(row("voucher") = "OpBal", CDate(row("Date")).AddDays(1), row("date"))
            drow.Cells("Voucher").Value = row("VoucherPrefix") & row("VoucherNo") & row("VoucherSuffix")
            drow.Cells("Details").Value = row("Voucher") & " / " & IIf(row("ledger") <> _Account, row("ledger"), "")

            drow.Cells("narration").Value = "(" & row("narration") & " )"
            drow.Cells("narration").Value &= " " & row("ChqNo") & " " & row("Date") & IIf(row("Bank") <> "", row("bank"), "") & " " & IIf(row("Branch") <> "", row("branch"), "")
            drow.Cells("Debit").Value = IIf(row("type") = "Dr", row("Amount"), 0)
            drow.Cells("Credit").Value = IIf(row("type") = "Cr", row("Amount"), 0)
            bal = bal + drow.Cells("Debit").Value - drow.Cells("Credit").Value
            dtotal += drow.Cells("Debit").Value
            ctotal += drow.Cells("Credit").Value
            drow.Cells("Balance").Value = Math.Abs(bal).ToString("f2") & IIf(bal < 0, " Cr", " Dr")
        Next
        numDebit.value = dtotal
        numCredit.value = ctotal
        numBal.value = Math.Abs(bal)
        lblType.Text = IIf(bal > 0, "Dr", "Cr")
        '   dgv.AllowUserToResizeColumns = False
        Try
            dgv.Rows(0).Selected = True
            lblNarration.Text = dgv.Rows(0).Cells("narration").Value
            dgv.AutoResizeColumns()
        Catch ex As Exception
            Exit Sub
        End Try
        ''''''''''''
        ' '' ''With ReportViewer1
        ' '' ''    .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ' '' ''    With .LocalReport
        ' '' ''        .ReportPath = Application.StartupPath & "\reports\" & reportname & ".rdlc"
        ' '' ''        .DataSources.Clear()
        ' '' ''        If .GetParameters.Count > 0 Then
        ' '' ''            Dim para As New ReportParameter("Company", gCompany)
        ' '' ''            Dim para1 As New ReportParameter("Criteria", rCriteria)

        ' '' ''            Dim paralist As New List(Of ReportParameter)
        ' '' ''            paralist.Add(para)
        ' '' ''            paralist.Add(para1)
        ' '' ''            .SetParameters(paralist)

        ' '' ''        End If
        ' '' ''        .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource(datasetname, ds1.Tables(0)))
        ' '' ''    End With
        ' '' ''    .RefreshReport()
        ' '' ''End With
        ''''''''''''
    End Sub
    Public Sub New(ByVal accid As Integer, ByVal account As String, ByVal fromdate As Date, ByVal todate As Date, ByVal groupname As String)
        _accid = accid
        _fromdate = fromdate
        _todate = todate
        _Account = account
        _groupname = groupname
        InitializeComponent()
    End Sub
    Private Sub dgv_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.RowEnter
        lblNarration.Text = dgv.Rows(e.RowIndex).Cells("narration").Value
    End Sub
End Class
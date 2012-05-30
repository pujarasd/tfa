Public Class sTrial
    Dim _accid As Integer
    Dim _fromdate As Date
    Dim _todate As Date
    Dim _Account As String
    Private Sub Account_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = "Trial Balance as on Dated " & _Account ''& " From " & _fromdate & " to " & _todate
        lblAccount.Text = _Account
        lblFrom.Text = Format(Today.Date, "dd-MM-yyyy")
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
            where a.accid = <%= _accid %> and a.date &lt;='<%= sqldate(_fromdate) %>' 
            order by ledger,date,id,lineid
        </string>

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
        If dt.Rows.Count <= 0 Then
            MsgBox("Nothing to Show")
            Return
            Me.Close()
        End If
        dgv.Rows(0).Selected = True
        dgv.AutoResizeColumns()
    End Sub
    Public Sub New(ByVal accid As Integer, ByVal account As String, ByVal fromdate As Date, ByVal todate As Date)
        _accid = accid
        _fromdate = fromdate
        _todate = todate
        _Account = account
        InitializeComponent()
    End Sub
End Class
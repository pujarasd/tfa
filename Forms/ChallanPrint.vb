Imports Microsoft.Reporting.WinForms
Public Class ChallanPrint

    Private Sub ChallanPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dschallan.Items' table. You can move, or remove it, as needed.
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        'TODO: This line of code loads data into the 'dschallan.Challan' table. You can move, or remove it, as needed.
        Dim qry As String = ""
        qry = <string>
                  SELECT     ch.ID, chn.ChallanName, chn.Prefix, ch.Challan, ch.Date, ch.GrossAmount, ch.Mode, [from].City AS cityfrom, [to].City AS CityTo, ch.LRNo, 
                      mCompany.Company, mCompany.Address, mCompany.City, mCompany.State, mCompany.Country, mCompany.Pin, mCompany.Phone, 
                      mCompany.Fax, mCompany.Mobile, mCompany.PAN, mCompany.MAIN_SIGN_NAME, mCompany.MAIN_SIGN_DESG, mCompany.AUTH_SIGN_NAME, 
                      mCompany.AUTH_SIGN_DESG, ch.Commission, ch.LabourPercent, ch.Labour, ch.Tds_rate, ch.Tds_amount, ch.Advance, ch.Amount, ch.Payable, 
                      t.Ledger AS lorry, mLedgerGroup.GroupName AS transporter, ch.Owner, ch.Driver, Payat.City AS PayableAt, ttcItems.ChallanId, ttcItems.Bags, 
                      ttcItems.Weight, ttcItems.Rate, ttcItems.Amount AS Value, ttcItems.Description,0.00 as custadvance,cust.ledger as customer,'' as amtinword
FROM ttchallan AS ch LEFT OUTER JOIN
                      mChallanName AS chn ON ch.BookId = chn.Id INNER JOIN
                      mLedger AS t ON ch.TransportId = t.Id INNER JOIN
                      mCity AS [to] ON ch.CityTo = [to].Id INNER JOIN
                      mCity AS [from] ON ch.CityFrom = [from].Id INNER JOIN
                      mLedger AS cust ON ch.CustId = cust.Id INNER JOIN
                      mCompany ON ch.CoId = mCompany.id INNER JOIN
                      mLedgerGroup ON t.GroupId = mLedgerGroup.Id INNER JOIN
                      ttcItems ON ch.ID = ttcItems.ChallanId INNER JOIN
                      mCity AS Payat ON ch.PayableAt = Payat.Id
              </string>
        Dim dt As DataTable = dbTable(qry)
        dt.Columns("custadvance").ReadOnly = False
        dt.Columns("amtinword").ReadOnly = False
        dt.Columns("amtinword").MaxLength = 500
        For Each row As DataRow In dt.Rows
            qry = <string>select sum(case r.type when 'Dr' then -r.amount else r.amount end ) 
                    from trefdata r where refno = (select refno from trefdata 
                    inner join tdatamain d on d.id = r.dataid 
                    inner join ttchallan c on c.id = d.challanid 
                    where(c.id = <%= row("Id") %>))</string>
            row("custadvance") = nz(dbValue(qry), 0)
            Dim n2w As New Num2Word
            n2w.Number = row("Amount") - row("custadvance")
            Dim mcurr As String

            mcurr = n2w.getPrimaryIndian()
            
            Dim munit As String = n2w.getSecondary()
            row("amtinword") = "Rupees" & " " & mcurr & IIf(munit = "", "", " and " & "Paise" & " " & munit) & " only"
        Next
        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dschallan_Challan", dt))


        Dim para As New ReportParameter("challanid", 3)
        Dim apara As New List(Of ReportParameter)
        apara.Add(para)
        Me.ReportViewer1.ProcessingMode = ProcessingMode.Local
        Me.ReportViewer1.LocalReport.SetParameters(apara)
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
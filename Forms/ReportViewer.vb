Imports System.IO
Imports Microsoft.Reporting.WinForms
Public Class ReportViewer
    Friend rCriteria As String = ""
    Friend rQuery As String = ""
    Friend reportname As String = ""
    Private Sub ReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Report "
        ShowReport()
    End Sub
    Private Sub ShowReport()
        Dim ds1 As DataSet = New DataSet()
        Dim qry As String = ""
        Dim datasetname As String = ""
        '' Dim reportname As String = "" '' TextBox1.Text
        Select Case reportname
            Case "RptFreightMargin"
                qry = rQuery
                datasetname = "AccountsDataSet_" & "DataTableFreightMargin"
            Case "RptStaxstatment"
                qry = rQuery
                datasetname = "AccountsDataSet_" & "DataTablestax"
            Case "RptTdsStatment"
                qry = rQuery
                datasetname = "AccountsDataSet_" & "DataTableTds"
            Case "RptMarginStatment"
                qry = rQuery
                datasetname = "AccountsDataSet_" & "DataTableRVMargin"
            Case "RptRegisterDetails"
                qry = rQuery
                datasetname = "AccountsDataSet_" & "DataTableDetails"
            Case "RptRegisterSummary"
                qry = rQuery
                datasetname = "AccountsDataSet_" & "DataTableDetails"
                '''''''''''''''''''''\\\\\\Accounts Reports 
            Case "rptTrial"
                qry = rQuery
                datasetname = "AccountsDataSet_" & "DataTableTrial"
        End Select

        ds1.Tables.Add(dbTable(qry))

        With ReportViewer1
            .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            With .LocalReport
                .ReportPath = Application.StartupPath & "\reports\" & reportname & ".rdlc"
                .DataSources.Clear()
                If .GetParameters.Count > 0 Then
                    Dim para As New ReportParameter("Company", gCompany)
                    Dim para1 As New ReportParameter("Criteria", rCriteria)

                    Dim paralist As New List(Of ReportParameter)
                    paralist.Add(para)
                    paralist.Add(para1)
                    .SetParameters(paralist)

                End If
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource(datasetname, ds1.Tables(0)))
            End With
            .RefreshReport()
        End With

    End Sub
    Private Sub TextBox1_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
        ShowReport()
    End Sub
End Class
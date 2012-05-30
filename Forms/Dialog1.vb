Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms
Public Class Dialog1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim greportpath As String = Application.ExecutablePath.Replace("\bin\Debug\Account.EXE", "")
        ReportViewer1.ProcessingMode = ProcessingMode.Local
        Dim title = ""
        '' set report
        ReportViewer1.LocalReport.ReportPath = addbs(greportpath) & "report1.rdlc"
        ReportViewer1.LocalReport.EnableExternalImages = True
        ReportViewer1.LocalReport.EnableHyperlinks = True
        '' set data
        '' Get Parameters

       
        'Dim parameters As New List(Of ReportParameter)

        'parameters.Clear()
        'parameters.Add(New ReportParameter("CompanyName", gCompany))
        'parameters.Add(New ReportParameter("ReportTitle", title))


        'Try
        '    ReportViewer1.LocalReport.SetParameters(parameters)

        'Catch ex As Exception

        'End Try


        For i As Short = 0 To ReportViewer1.LocalReport.DataSources.Count - 1
            ReportViewer1.LocalReport.DataSources.RemoveAt(0)
        Next
        Dim dtcompany As DataTable = dbTable("Select * from mcompany")
        'Dim dtcr As DataTable
        'Dim dtCustomer As DataTable
        'If Not dtcompany Is Nothing Then
        '    If dtcompany.Rows.Count > 0 And dtCr.Rows.Count > 0 Then
        '        Dim rcount As Integer = dtDr.Rows.Count - dtCr.Rows.Count
        '        If rcount > 0 Then
        '            For i As Integer = 1 To rcount
        '                dtCr.Rows.Add(dtCr.NewRow)
        '            Next
        '        Else
        '            For i As Integer = 1 To rcount Step -1
        '                dtDr.Rows.Add(dtDr.NewRow)
        '            Next
        '        End If
        '    End If
        'End If
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("AccountsDataSet_mCompany", dtcompany))
        'ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Billing_LedgerCr", dtCr))
        'ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Billing_ConsigneeMast", dtcustomer))



        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ShowExportButton = True

        '' render report
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class

Imports System.Configuration
Public Class Main
    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mnuMain.Visible = False
        Dim img As Image = Image.FromFile(addbs(Application.StartupPath) & "Warehouse.png")
        Me.BackgroundImage = img
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackColor = Color.LightSkyBlue
        Me.Text = "Account (c) 2012 SG Solutions"
        Dim chkreg As Boolean = False
        Dim exetype As String = ""
        Dim conf As Configuration
        conf = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath)

        Try
            exetype = conf.AppSettings.Settings("ExeType").Value
        Catch ex As Exception

        End Try
        gIsClient = (exetype <> "server")
        If gIsClient Then
            gDataPath = conf.AppSettings.Settings("serverpath").Value
            If gDataPath.Length > 0 Then
                If IO.Directory.Exists(gDataPath) Then

                    gReportPath = addbs(gDataPath) & "reports\"
                    gDataPath = addbs(gDataPath)
                Else
                    If MsgBox(gDataPath & " Not found, either moved or network error. " & vbCrLf & " Do you want to define new path?", MsgBoxStyle.YesNo) = vbYes Then
                        Dim ofrmpath As New ServerPath
                        ofrmpath.ShowDialog()
                        ofrmpath = Nothing
                    Else
                        Application.Exit()
                        Exit Sub

                    End If

                End If
            Else

                Dim ofrmpath As New ServerPath
                ofrmpath.ShowDialog()
                ofrmpath = Nothing
            End If
        End If
        Dim osplash As New splash

        osplash.Show()
        osplash.Refresh()
        chkreg = checkreg()
        Application.DoEvents()
        osplash.Close()
        osplash = Nothing

        If Not chkreg Then

            Dim ofrm As New Register
            Application.DoEvents()
            ofrm.ShowDialog()

            If ofrm.DialogResult = Windows.Forms.DialogResult.Cancel Then
                ofrm = Nothing
                Me.Close()
                Exit Sub
            End If
            ofrm = Nothing


        End If
    End Sub







    Private Sub mnuMain_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles mnuMain.ItemClicked
        Select Case e.ClickedItem.Name


            Case "miCompany"
                Dim ofrm As New CompanyList
                ofrm.Owner = Me
                ofrm.StartPosition = FormStartPosition.CenterScreen

                ofrm.ShowDialog()
                AddChallans()
                AddVouchers()

            Case "miVoucher"
                Dim ofrm As New Dialog1
                ofrm.ShowDialog()
            Case "miLogout"
                mnuMain.Visible = False
                mnuLogin.Visible = True

            Case Else




        End Select
    End Sub

    Private Sub miLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles miLogin.Click
        Dim ofrm As New Login

        ofrm.ShowDialog()

        If ofrm.DialogResult = Windows.Forms.DialogResult.OK Then
            mnuLogin.Visible = False
            mnuMain.Visible = True


        End If
    End Sub

    Private Sub Main_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        slblPeriod.Text = "Period:" & Format(gFinStartDate, "dd/MMM/yyyy") & " - " & Format(gFinEndDate, "dd/MMM/yyyy")
        Dim ofrm As New Login

        ofrm.ShowDialog()

        If ofrm.DialogResult = Windows.Forms.DialogResult.OK Then
            slblUser.Text = "User Name: " & gUserName
            mnuLogin.Visible = False
            mnuMain.Visible = True
            Dim ofrm1 As New CompanyList
            ofrm1.Owner = Me
            ofrm1.StartPosition = FormStartPosition.CenterScreen

            ofrm1.ShowDialog()
            slblCompany.Text = "Company Name: " & gCompany
            AddChallans()
            AddVouchers()


        End If
    End Sub

    Private Sub AddChallans()
        Dim dt As DataTable = dbTable("select * from mchallanname where coid = " & gCoId & " order by ChallanName")
        If dt.Rows.Count = 0 Then
            dbUpdate(New String() {"insert into mchallanname (ChallanName,CoId,Prefix) values ('Main'," & gCoId & ",'DC')"})
            dt = dbTable("select * from mchallanname where coid = " & gCoId & " order by ChallanName")
        End If
        Dim tmain As ToolStripMenuItem = mnuMain.Items("miInventory")
        tmain = tmain.DropDownItems("miChallan")
        If tmain.DropDownItems.Count > 0 Then
            tmain.DropDownItems.Clear()
        End If
        For Each row As DataRow In dt.Rows
            Dim ti As New ToolStripMenuItem
            ti.Name = row("Prefix")
            ti.Text = row("ChallanName")
            ti.Tag = row("Id")
            'AddHandler ti.Click, AddressOf Challan_Clicked
            tmain.DropDown.Items.Insert(0, ti)
        Next
    End Sub
    Private Sub AddVouchers()
        Dim dt As DataTable = dbTable("select * from mvoucher where coid = " & gCoId & " order by Voucher Desc")
        If dt.Rows.Count = 0 Then
            Dim aqstr(10) As String
            aqstr(0) = "insert into mvoucher (Voucher,Type,Prefix,CoId) values (" & "'Bank Withdrawal','Payment Bank','BP'," & gCoId & ")"
            aqstr(1) = "insert into mvoucher (Voucher,Type,Prefix,CoId) values (" & "'Bank Deposit','Receipt Bank','BR'," & gCoId & ")"
            aqstr(2) = "insert into mvoucher (Voucher,Type,Prefix,CoId) values (" & "'Cash Payment','Payment Cash','CP'," & gCoId & ")"
            aqstr(3) = "insert into mvoucher (Voucher,Type,Prefix,CoId) values (" & "'Cash Receipt','Receipt Cash','CR'," & gCoId & ")"
            aqstr(4) = "insert into mvoucher (Voucher,Type,Prefix,CoId) values (" & "'Sales','Sales','SL'," & gCoId & ")"
            aqstr(5) = "insert into mvoucher (Voucher,Type,Prefix,CoId) values (" & "'Purchase','Purchase','PU'," & gCoId & ")"
            aqstr(6) = "insert into mvoucher (Voucher,Type,Prefix,CoId) values (" & "'Sales Return','Purchase','SR'," & gCoId & ")"
            aqstr(7) = "insert into mvoucher (Voucher,Type,Prefix,CoId) values (" & "'Purchase Return','Sales','PR'," & gCoId & ")"
            aqstr(8) = "insert into mvoucher (Voucher,Type,Prefix,CoId) values (" & "'Journal','Journal','JR'," & gCoId & ")"
            aqstr(9) = "insert into mvoucher (Voucher,Type,Prefix,CoId) values (" & "'Debit Note','Debit Note','DN'," & gCoId & ")"
            aqstr(10) = "insert into mvoucher (Voucher,Type,Prefix,CoId) values (" & "'Credit Note','Credit Note','CN'," & gCoId & ")"
            dbUpdate(aqstr)
            dt = dbTable("select * from mvoucher where coid = " & gCoId & " or coid=0 order by Voucher Desc")
        End If
        Dim tmain As ToolStripMenuItem = mnuMain.Items("miVoucherMain")
        '  tmain = tmain.DropDownItems("miChallan")
        If tmain.DropDownItems.Count > 0 Then
            tmain.DropDownItems.Clear()
        End If
        For Each row As DataRow In dt.Rows
            Dim ti As New ToolStripMenuItem
            ti.Name = row("Prefix") & "~" & row("Suffix") & "~" & row("AutoNo") & "~" & row("AutoStart")
            ti.Text = row("Voucher")
            ti.Tag = row("Type")
            'AddHandler ti.Click, AddressOf Challan_Clicked
            tmain.DropDown.Items.Insert(0, ti)
        Next
    End Sub
    Sub Challan_Clicked(ByVal sender As Object, ByVal e As EventArgs)
    End Sub
    Private Sub miMasters_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles miMasters.DropDownItemClicked
        Select Case e.ClickedItem.Name
            Case "miBooks"
                Dim ofrm As New ChallanList
                ofrm.MdiParent = Me
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.Show()
            Case "miCharges"
                Dim ofrm As New ChargesList
                ofrm.MdiParent = Me
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.Show()
            Case "miCity"
                Dim ofrm As New CityList
                ofrm.MdiParent = Me
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.Show()
            Case "miCountry "
            Case "miItem"
            Case "miItemGroup"
                Dim ofrm As New LedgerGroup
                ofrm.MdiParent = Me
                ofrm.StartPosition = FormStartPosition.CenterScreen

                ofrm.Show()

            Case "miLedger"
                Dim ofrm As New LedgerList
                ofrm.MdiParent = Me
                ofrm.StartPosition = FormStartPosition.CenterScreen

                ofrm.Show()

            Case "miLedgerGroup"


            Case "miState"
                Dim ofrm As New StateList
                ofrm.MdiParent = Me
                ofrm.Show()
            Case "miTransport"
                Dim ofrm As New Transportlist
                ofrm.MdiParent = Me
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.Show()
            Case "miAgent"
                Dim ofrm As New Agentlist
                ofrm.MdiParent = Me
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.Show()
            Case Else
        End Select
    End Sub

    Private Sub miChallan_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles miChallan.DropDownItemClicked
        Dim ofrm As New TransChallan2
        ofrm.MdiParent = Me
        '  Dim mi As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        ofrm.bookid = e.ClickedItem.Tag
        ofrm.bookname = e.ClickedItem.Text
        ofrm.bookext = e.ClickedItem.Name
        ofrm.StartPosition = FormStartPosition.CenterScreen
        ' ofrm.Owner = Me
        ofrm.Show()
    End Sub

    Private Sub miVoucherMain_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles miVoucherMain.DropDownItemClicked
        Dim ofrm As New Voucher(e.ClickedItem.Name, e.ClickedItem.Text, e.ClickedItem.Tag)
        ofrm.MdiParent = Me
        ofrm.StartPosition = FormStartPosition.CenterScreen
        ofrm.Show()
    End Sub

    Private Sub miReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miReport.Click
        'Dim ofrm As New ReportViewer
        'ofrm.reportname = "RptFreightMargin"
        'ofrm.ShowDialog()

    End Sub

    Private Sub miPeriod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miPeriod.Click
        Dim ofrm As New Period
        ofrm.ShowDialog()
        slblPeriod.Text = "Period:" & Format(gFinStartDate, "dd/MMM/yyyy") & " - " & Format(gFinEndDate, "dd/MMM/yyyy")
        ofrm = Nothing
    End Sub
    Private Sub FreightMarginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FreightMarginToolStripMenuItem.Click
        Dim oo As New FrmReport1
        oo.Reportname = "RptFreightMargin"
        oo.Show()
        oo = Nothing
    End Sub
    Private Sub ServiceTaxStatementToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiceTaxStatementToolStripMenuItem1.Click
        Dim ofrm As New FrmReport1
        ofrm.Reportname = "RptStaxstatment"
        ofrm.Show()
        ofrm = Nothing
        '        Dim oo As New ReportViewer
        '       oo.reportname = "RptStaxstatment"
        '      oo.ShowDialog()
        'oo = Nothing
    End Sub
    Private Sub TdsStatmentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TdsStatmentToolStripMenuItem1.Click
        Dim ofrm As New FrmReport1
        ofrm.Reportname = "RptTdsStatment"
        ofrm.Show()
        ofrm = Nothing
    End Sub
    Private Sub FreightMarginRVToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FreightMarginRVToolStripMenuItem.Click
        Dim ofrm As New FrmReport1
        ofrm.Reportname = "RptMarginStatment"
        ofrm.Show()
        ofrm = Nothing
    End Sub
    Private Sub RegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterToolStripMenuItem.Click
        Dim ofrm As New FrmReport
        ofrm.Show()
    End Sub
    Private Sub LorryChallanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LorryChallanToolStripMenuItem.Click
        Dim ofrm As New ChallanPrint
        ofrm.ShowDialog()
        ofrm = Nothing
    End Sub
    Private Sub miUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miUser.Click
        Dim ofrm As New Userlist
        ofrm.Show()
    End Sub

    Private Sub miInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miInvoice.Click
        Dim ofrm As New TransInvoice
        ofrm.Show()
        ofrm = Nothing
    End Sub
    Private Sub PartyLedgerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartyLedgerToolStripMenuItem.Click
        Dim ofrm As New FrmReportLedger
        ofrm.Show()
        ofrm = Nothing
    End Sub
    Private Sub GroupLedgerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Under Development")
    End Sub
    Private Sub TrialBalanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrialBalanceToolStripMenuItem.Click
        Dim ofrm As New FrmReportTrial
        ofrm.Show()
        ofrm = Nothing
    End Sub
    Private Sub InvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceToolStripMenuItem.Click
        MsgBox("Under Development")
    End Sub
End Class

Public Class TransChallan2
    Friend mode As enDatamode
    Friend id As Integer
    Friend navmode As enNavMode = enNavMode.LastRec
    Friend dtchdetail As DataTable
    Friend dtChChgs As DataTable
    Friend bookid As Integer
    Friend bookname As String
    Friend bookext As String
    Dim dtchallan As DataTable

    Dim dtplace As DataTable
    Dim dtLorry As DataTable
    Dim dtCustomer As DataTable
    Dim dtCityfrom As DataTable
    Dim dtcityto As DataTable
    Dim dtpayableat As DataTable
    Dim dvLorry As DataView
    Dim rowindex As Integer = 0
    Dim isLoading As Boolean
    Dim custid As Integer
    Dim itementrymode As enEntry
    Dim calculating As Boolean
    Dim bd As New BindingSource
    Private Enum enChargeColumns
        Id
        Charge
        Rate
        RateOn
        AmountOn
        Amount
        Account
        ChargeId
        RateOnId
    End Enum
    Private Enum enItemColumns
        Content
        Bags
        Weight
        Rate
        WeightDiff
        RateDiff
        Amount
        Remark
    End Enum

#Region "form_events"

    Private Sub TransChallan2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Main.miPeriod.Enabled = True
    End Sub

    Private Sub TransChallan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar

            Case ChrW(Keys.Enter)
                If TypeOf Me.ActiveControl Is NumTextBox Then Exit Sub
                If TypeOf Me.ActiveControl Is TextBox Then
                    If CType(Me.ActiveControl, TextBox).Multiline Then

                        Exit Sub
                    End If
                ElseIf TypeOf Me.ActiveControl Is Button Then

                    Exit Sub

                End If
                SendKeys.Send("{TAB}")
        End Select

    End Sub

    Private Sub Challan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Main.miPeriod.Enabled = False
        isLoading = True
        Me.Height = 525
        Me.Width = 900
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        Grid_Create()

        Me.Text = "Challan : " & bookname
        lblPrefix.Text = bookext
        pnlMain.Visible = False
        pnlsave.Visible = False

        dtChallanDate.MaxDate = gFinEndDate
        dtChallanDate.MinDate = gFinStartDate
        'Dim thisTextBox As New ToolStripComboBox
        'thisTextBox = CType(tbNav.Items("tscBook"), ToolStripComboBox)
        'thisTextBox.Focus()
        'tbNav.Items("tscBook").Select()
        'tscBook.Select()
        ' tscBook.ComboBox.Select()
        '  ActiveControl = tscBook.ComboBox
        tbEdit.Enabled = False
        tstChallan.Enabled = False
        ' SendKeys.Send("{F4}")
        '       If Not isLoading Then
        mode = enDatamode.none
        navmode = enNavMode.LastRec

        pnlMain.Visible = True
        pnlsave.Visible = True
        tbEdit.Enabled = True
        tsbFirst.Enabled = True
        tsbLast.Enabled = True
        tsbNew.Enabled = True
        tsbNext.Enabled = True
        tsbPrevious.Enabled = True
        tstChallan.Enabled = True


        Fill_Combo()
        Fill_Challan()

        pnlMain.Visible = True
        pnlsave.Visible = True
        If ntxtChallan.value = 0 Then
            tsbNew_Click(Nothing, Nothing)
        Else
            tbEdit.Focus()
            tbEdit.Items(0).Select()
        End If

        ' Dim ledgerid As Integer = tscBook.SelectedItem(1).ToString.Split("~")(2)
        '
        '  cmbCustomer.SelectedIndex = 0
        ' End If

        '  lblPrefix.Text = tscBook.SelectedItem(1).ToString.Split("~")(1)
        '      End If
        isLoading = False

    End Sub

#End Region
#Region "Procedures"

    Sub Fill_Combo(Optional ByVal cmb As ComboBox = Nothing)
        '' transporter
        Dim qry As String
        If cmb Is Nothing Then
            qry = " with cte as  " & _
                    "(select * from mledgergroup where groupid = " & enLedger.Creditors & _
                    " union all " & _
                    " select t.* from cte inner join mledgergroup t on t.groupid = cte.id) " & _
                    " select mledger.id,mledger.ledger+' ~ '+cte.groupname as ledger,mledger.ledger as party from cte inner join mledger on mledger.groupid = cte.id order by ledger "

            fill_combocommon(cmbTransporter, qry, "ledger", "Id")
            qry = " with cte as  " & _
                     "(select * from mledgergroup where groupid = " & enLedger.Debtors & _
                     " union all " & _
                     " select t.* from cte inner join mledgergroup t on t.groupid = cte.id) " & _
                     " select mledger.id,mledger.ledger +' ~ '+cte.groupname as ledger from cte inner join mledger on mledger.groupid = cte.id order by ledger "

            fill_combocommon(cmbCustomer, qry, "ledger", "id")
            fill_combocommon(cmbFrom, "Select id,city from mcity where ctype= 'From' order by city", "city", "id")
            fill_combocommon(cmbTo, "Select id,city from mcity where ctype= 'To' order by city", "city", "id")
            fill_combocommon(cmbPayableAt, "Select id,city from mcity where  ctype= 'PayableAt' order by city", "city", "id")
        Else
            Select Case cmb.Name
                Case "cmbCustomer"
                    qry = " with cte as  " & _
                    "(select * from mledgergroup where groupid = " & enLedger.Debtors & _
                    " union all " & _
                    " select t.* from cte inner join mledgergroup t on t.groupid = cte.id) " & _
                    " select  mledger.id,mledger.ledger+' ~ '+cte.groupname as ledger from cte inner join mledger on mledger.groupid = cte.id order by ledger "

                    fill_combocommon(cmbCustomer, qry, "ledger", "id")

                Case "cmbFrom"
                    fill_combocommon(cmbFrom, "Select id,city from mcity where ctype= 'From' order by city", "city", "id")
                Case "cmbTo"
                    fill_combocommon(cmbTo, "Select id,city from mcity where ctype= 'To' order by city", "city", "id")

                Case "cmbPayableAt"
                    fill_combocommon(cmbPayableAt, "Select id,city from mcity where ctype= 'PayableAt' order by city", "city", "id")

                Case "cmbTransporter"
                    qry = " with cte as  " & _
                 "(select * from mledgergroup where groupid = " & enLedger.Creditors & _
                 " union all " & _
                 " select t.* from cte inner join mledgergroup t on t.groupid = cte.id) " & _
                 " select  mledger.id,mledger.ledger+' ~ '+cte.groupname as ledger from cte inner join mledger on mledger.groupid = cte.id order by ledger "
                    fill_combocommon(cmbTransporter, qry, "ledger", "Id")
            End Select
        End If
    End Sub
    Sub Fill_Challan()
        isLoading = True
        Dim qstr As String = _
         <string>
          Select a.*,b.ledger from ttchallan a 
          inner join mledger b on b.id = a.custid 
          where bookid= <%= bookid %>   and coid = <%= gCoId %>
          and date&gt;='<%= sqldate(gFinStartDate) %>' and date&lt;='<%= sqldate(gFinEndDate) %>'
          order by challan

           </string>
        dtchallan = dbTable(qstr)
        SetDefaultClearNull(dtchallan)
        qstr = _
        <string>
            Select a.* from ttcItems a 
            order by a.challanid
          </string>

        dtchdetail = dbTable(qstr)
        SetDefaultClearNull(dtchdetail)
        If dtchdetail.Rows.Count = 0 Then
            Dim row As DataRow = dtchdetail.NewRow
            dtchdetail.Rows.Add(row)
        End If
        '        qstr = _
        '        <String>
        '            Select a.*,c.*,o.chargeon,l.ledger account  from ttcCharges a 
        '            inner join mCharges c on c.id = a.chargeid
        '            inner join mChargeOn o on o.ctId=c.rateon
        'inner join mledger l on l.id = c.acid
        '        </String>
        '        dtChChgs = dbTable(qstr)
        '        SetDefaultClearNull(dtChChgs)

        bd.DataSource = dtchdetail
        dgv.DataSource = bd
        dgv.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
        dgv.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2


        If dtchallan.Rows.Count = 0 Then
            tsbNew_Click(Nothing, Nothing)
        Else
            navmode = enNavMode.LastRec
            Fill_Controls()
        End If
        isLoading = False
    End Sub
    Sub Fill_Controls(Optional ByVal ROW As DataRowView = Nothing)
        Select Case navmode
            Case enNavMode.FirstRec
                rowindex = 0
                tsbPrevious.Enabled = False
                tsbNext.Enabled = True
                tsbLast.Enabled = True
            Case enNavMode.LastRec
                rowindex = dtchallan.Rows.Count - 1
                tsbPrevious.Enabled = True
                tsbNext.Enabled = False
                tsbFirst.Enabled = True
            Case enNavMode.NextRec
                If rowindex < dtchallan.Rows.Count - 1 Then
                    rowindex += 1
                    If rowindex > 0 Then tsbPrevious.Enabled = True
                Else
                    tsbNext.Enabled = False
                    Exit Sub
                End If

            Case enNavMode.PrevRec
                If rowindex > 0 Then
                    rowindex -= 1
                Else
                    tsbPrevious.Enabled = False
                    Exit Sub
                End If
                'Case Else
                '    rowindex = 0
        End Select
        If ROW Is Nothing And dtchallan.Rows.Count > 0 Then
            dtchallan.DefaultView.RowFilter = ""
            ROW = dtchallan.DefaultView(rowindex)
        ElseIf ROW Is Nothing Then
            Exit Sub
        End If
        id = ROW("id")
        ntxtChallan.value = ROW("Challan")

        dtChallanDate.Value = ROW("Date")
        cmbTransporter.SelectedValue = ROW("TransportId")
        ntxtGrossAmt.value = ROW("GrossAmount")
        ntxtVarGross.value = ROW("VarGrossAmt")
        ntxtNetAmt.value = ROW("Payable")
        cmbCustomer.SelectedValue = ROW("CustId")
        txtDriver.Text = ROW("Driver")
        txtLorryno.Text = cmbTransporter.SelectedItem(2) ''  ROW("LorryId")
        txtLrNo.Text = ROW("Lrno")
        txtDiNo.Text = ROW("DIno")
        txtInv.Text = ROW("Inv")
        txtOwner.Text = ROW("owner")
        txtShip.Text = ROW("Shipno")
        cmbFrom.SelectedValue = ROW("cityfrom")
        cmbTo.SelectedValue = ROW("cityto")
        cmbPayableAt.SelectedValue = ROW("payableat")
        cmbTransporter.SelectedValue = ROW("transportid")
        txtNarration.Text = ROW("Narration")
        ntxtAdvance.value = ROW("Advance")
        ntxtCash2Drv.value = ROW("AdvCash")
        ntxtCash2DrvByTrans.value = ROW("AdvContra")
        ntxtDasti.value = ROW("Dasti")
        ntxtFrMargin.value = ROW("Commission")
        ntxtFrMarginPer.value = ROW("CommPercent")
        ntxtLabour.value = ROW("Labour")
        ntxtLabPerc.value = ROW("LabourPercent")
        ntxtOther1.value = ROW("other1")
        ntxtOther2.value = ROW("Other2")
        ntxtStax.value = ROW("STAX")
        ntxtSTRate.value = ROW("staxPercent")
        cmbSTon.SelectedItem = ROW("staxon")
        ntxtFrMarginRV.value = ROW("VarMargin")
        ntxtTDS.value = ROW("TDS_amount")
        ntxtTDSRate.value = ROW("TDS_Rate")
        ntxtTotAdv.value = ROW("Advance")
        NumTbags.value = ROW("tbags")
        numTWeight.value = ROW("tweight")

        bd.Filter = "Challanid=" & id
        If bd.Count = 0 Then
            Dim nrow As DataRow = dtchdetail.NewRow
            nrow("ChallanId") = id
            dtchdetail.Rows.Add(nrow)
            bd.DataSource = dtchdetail
        End If
        'End If
        If mode = enDatamode.none Then disableEntry()
        If mode = enDatamode.Add Or mode = enDatamode.Edit Then
            enableEntry()
        End If

    End Sub
    Sub Grid_Create()
        dgvdefault(dgv)
        With dgv
            .Columns.Clear()
            With .Columns
                .Add("Description", "Content")
                .Add("Bags", "Package")
                .Add("Weight", "Weight")
                .Add("Rate", "Rate")
                .Add("WeightDiff", "RV Weight")
                .Add("RateDiff", "RV Rate")
                .Add("Amount", "Amount")
                .Add("Remark", "Remark")
            End With
            With .Columns("Bags")
                .DataPropertyName = "Bags"
                .Width = 30
                .CellTemplate.Style.Format = "n2"
                .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            End With
            With .Columns("Description")
                .DataPropertyName = "Description"
                .Width = 100
                .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            End With
            With .Columns("Weight")
                .DataPropertyName = "Weight"
                .Width = 40
                .CellTemplate.Style.Format = "n3"
                .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            End With
            With .Columns("Rate")
                .DataPropertyName = "Rate"
                .Width = 50
                .CellTemplate.Style.Format = "n2"
                .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            End With
            With .Columns("WeightDiff")
                .DataPropertyName = "WeightDiff"
                .Width = 40
                .CellTemplate.Style.Format = "n3"
                .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            End With
            With .Columns("RateDiff")
                .DataPropertyName = "RateDiff"
                .Width = 50
                .CellTemplate.Style.Format = "n2"
                .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            End With
            With .Columns("Amount")
                .DataPropertyName = "Amount"
                .Width = 60
                .CellTemplate.Style.Format = "n2"
                .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            End With

            With .Columns("Remark")
                .DataPropertyName = "Remark"
                .Width = 100
            End With
            .SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
            .EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
            ' .AllowUserToAddRows = True
            .AllowUserToDeleteRows = True
            .RowHeadersVisible = True
        End With
    End Sub
    Sub disableEntry()
        pnlMain.Enabled = False
        pnlsave.Enabled = False
        tbEdit.Enabled = True
        tbNav.Enabled = True
    End Sub
    Sub enableEntry()
        tbEdit.Enabled = False
        tbNav.Enabled = False
        pnlMain.Enabled = True
        pnlsave.Enabled = True
    End Sub

    Sub calc()
        Dim tamount As Double = 0
        Dim tvaramt As Double = 0
        Dim tbags As Integer = 0
        Dim tweight As Decimal = 0
        For I = 0 To bd.Count - 1
            bd(I)("Amount") = dgv(enItemColumns.Weight, I).Value * dgv(enItemColumns.Rate, I).Value
            '  bd.EndEdit()
            tamount += "0" & bd(I)("Amount")
            tvaramt += (("0" & dgv(enItemColumns.RateDiff, I).Value) * ("0" & dgv(enItemColumns.WeightDiff, I).Value))
            tbags += ("0" & dgv(enItemColumns.Bags, I).Value)
            tweight += ("0" & dgv(enItemColumns.Weight, I).Value)
        Next
        dgv.Refresh()
        NumTbags.value = tbags
        numTWeight.value = tweight
        ntxtVarGross.value = tvaramt
        ntxtGrossAmt.value = tamount
        ntxtFrMarginRV.value = ntxtVarGross.value - ntxtGrossAmt.value
        If ntxtFrMarginPer.value > 0 Then
            ntxtFrMargin.value = Math.Ceiling(ntxtGrossAmt.value * ntxtFrMarginPer.value / 1000) * 10
            ntxtFrMargin.ReadOnly = True
        End If
        If ntxtLabPerc.value > 0 Then
            ntxtLabour.value = Math.Ceiling(ntxtLabPerc.value * ntxtGrossAmt.value / 1000) * 10
            ntxtLabour.ReadOnly = True
        End If
        If ntxtSTRate.value > 0 Then
            ntxtStax.value = Math.Ceiling(ntxtGrossAmt.value * ntxtSTRate.value / 100)
            ntxtStax.ReadOnly = True
        End If
        If ntxtTDSRate.value > 0 Then
            ntxtTDS.value = Math.Ceiling(ntxtGrossAmt.value * ntxtTDSRate.value / 100)
            ntxtTDS.ReadOnly = True
        End If
        CalcCharges()
    End Sub
    Sub clear_controls()
        ''   Fill_Combo()
        txtDiNo.Text = ""
        txtDriver.Text = ""
        txtInv.Text = ""
        txtLrNo.Text = ""
        txtNarration.Text = ""
        txtOwner.Text = ""
        txtShip.Text = ""
        ntxtChallan.value = 0
        ntxtGrossAmt.value = 0
        ntxtNetAmt.value = 0
        ntxtVarGross.value = 0
        ntxtAdvance.value = 0
        ntxtCash2Drv.value = 0
        ntxtCash2DrvByTrans.value = 0
        ntxtDasti.value = 0
        ntxtLabPerc.value = 0
        ntxtLabour.value = 0
        ntxtOther1.value = 0
        ntxtOther2.value = 0
        ntxtFrMargin.value = 0

        ntxtFrMarginRV.value = 0
        ntxtStax.value = 0

        ntxtTDS.value = 0
        ntxtTDSRate.value = 0
        ntxtTotAdv.value = 0
        ntxtVarGross.value = 0


        id = 0
        bd.Filter = "Challanid=" & id
        If bd.Count = 0 Then
            dtchdetail.Rows.Add(dtchdetail.NewRow)

        End If
        'Dim dv As DataView = dtchdetail.DefaultView
        'dv.RowFilter = "challanid = " & id
        'dgve.DataSource = dv
        'dtchdetail.Rows.Clear()

    End Sub
#End Region

#Region "Combo"


#End Region
#Region "Buttons"

    Private Sub tsbRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbRefresh.Click
        If Not isLoading Then Fill_Challan()
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If id = 0 And dtchallan.Rows.Count = 0 Then
            Me.Close()
            Exit Sub
        Else
            Fill_Challan()
            Fill_Controls()
            disableEntry()

        End If
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ntxtNetAmt.value = 0 Then
            MsgBox("Net Amount should not be Zero ")
            Exit Sub
        End If
        Dim qstr As String = ""
        Dim aqstr As New List(Of String)
        If mode = enDatamode.Add Then
            qstr = _
            <string>INSERT INTO [ttchallan]
            (BookId
            ,Challan
            ,Date
            ,CustId
            ,TransportId
            ,Mode
            ,Narration 
            ,GrossAmount
            ,tbags
            ,tweight
            ,VarGrossAmt
            ,Commission
            ,LabourPercent
            ,Labour
            ,Tds_rate
            ,Tds_amount
            ,Shortage
            ,Advance
            ,Amount
            ,Payable
            ,LorryId
            ,ShipNo
            ,EgpNo
            ,DIno
            ,Driver
            ,Owner
            ,PayableAt
            ,CityFrom
            ,CityTo
            ,LRNo
            ,LRDate
            ,Inv
            ,AdvContra
            ,AdvCash
            ,Other1
            ,Other2
            ,Dasti
            ,CommPercent
            ,VarMargin
            ,StaxOn
            ,Stax 
            ,StaxPercent
            ,CoId,period,createby)
            VALUES(
            <%= bookid %> 
            ,<%= ntxtChallan.value %>
            ,'<%= sqldate(dtChallanDate.Value.Date.ToString) %>'
            ,<%= cmbCustomer.SelectedValue %>
            ,<%= cmbTransporter.SelectedValue %>
            ,'B'
            ,'<%= txtNarration.Text %>' 
            ,<%= ntxtGrossAmt.value %>
            ,<%= NumTbags.value %> 
            ,<%= numTWeight.value %> 
            ,<%= ntxtVarGross.value %> 
            ,<%= ntxtFrMargin.value %>
            , <%= ntxtLabPerc.value %>
            , <%= ntxtLabour.value %>
            ,<%= ntxtTDSRate.value %>
            , <%= ntxtTDS.value %>
            ,0
            ,<%= ntxtAdvance.value %>
            ,<%= ntxtGrossAmt.value %>
            ,<%= ntxtNetAmt.value %>
            ,<%= 0 %> 
            ,'<%= txtShip.Text %>'
            ,'<%= "" %>'
            ,'<%= txtDiNo.Text %>'
            ,'<%= txtDriver.Text %>'
            ,'<%= txtOwner.Text %>'
            ,<%= cmbPayableAt.SelectedValue %>
            ,<%= cmbFrom.SelectedValue %>
            ,<%= cmbTo.SelectedValue %>
            ,'<%= txtLrNo.Text %>'
            ,'<%= sqldate(dtLrDate.Value.Date.ToString) %>'
            ,'<%= txtInv.Text %>'
            ,<%= ntxtCash2Drv.value %>
            , <%= ntxtCash2DrvByTrans.value %>
            ,<%= ntxtOther1.value %>
            , <%= ntxtOther2.value %>
            ,<%= ntxtDasti.value %>
            , <%= ntxtFrMarginPer.value %>
            ,<%= ntxtFrMarginRV.value %>
            ,'<%= cmbSTon.SelectedItem %>'
            ,<%= ntxtStax.value %>
            , <%= ntxtSTRate.value %>
            ,<%= gCoId %>,'<%= gPeriod %>','<%= gUserName %>')
            </string>
            aqstr.Add(qstr)
            Dim DV As DataView = dtchdetail.DefaultView
            DV.RowFilter = "CHALLANID = " & id

            For Each row As DataRowView In DV
                qstr = _
                 <sting>
            INSERT INTO [ttcItems]
           ([ChallanId]
           ,[Weight]
           ,[Rate]
           ,[Amount]
           ,[RateDiff]
           ,[weightdiff]
           ,[Description]
           ,[Bags]
            ,[Remark],[CoId])
            VALUES
           (IDENT_CURRENT('ttchallan')
           ,<%= row("Weight") %>
           ,<%= row("Rate") %>
           ,<%= row("Amount") %>
           ,<%= row("RateDiff") %>
           ,<%= row("WeightDiff") %>
           ,'<%= row("Description") %>'
           ,<%= row("Bags") %>
           ,'<%= row("Remark") %>',<%= gCoId %>
            )


        </sting>
                aqstr.Add(qstr)
            Next




        ElseIf mode = enDatamode.Edit Then
            qstr = _
           <string>Update [ttchallan] Set
            [BookId]=<%= bookid %>
            ,[Challan]=<%= ntxtChallan.value %>
            ,[Date]='<%= sqldate(dtChallanDate.Value) %>'
            ,[CustId]=<%= cmbCustomer.SelectedValue %>
            ,[TransportId]=<%= cmbTransporter.SelectedValue %>
            ,[Mode]='B'
            ,[Narration]='<%= txtNarration.Text %>'
            ,[GrossAmount]=<%= ntxtGrossAmt.value %>
            ,[tbags]=<%= NumTbags.value %>
            ,[tWeight]=<%= numTWeight.value %>
            ,[Commission] = <%= ntxtFrMargin.value %>
            ,[LabourPercent] =<%= ntxtLabPerc.value %>
            ,[Labour] = <%= ntxtLabour.value %>
            ,[Tds_rate] = <%= ntxtTDSRate.value %>
            ,[Tds_amount] = <%= ntxtTDS.value %>
            ,[Shortage] = <%= 0 %>
            ,[Advance] = <%= ntxtAdvance.value %>
            ,[Amount] = <%= ntxtGrossAmt.value %>
            ,[Payable]=<%= ntxtNetAmt.value %>
            ,[varGrossAmt]=<%= ntxtVarGross.value %>
            ,[LorryId] =<%= 0 %>
            ,[ShipNo]='<%= txtShip.Text %>'
            ,[EgpNo] = '<%= "" %>'
            ,[DIno]='<%= txtDiNo.Text %>'
            ,[driver]='<%= txtDriver.Text %>'
            ,[owner]='<%= txtOwner.Text %>'
            ,[payableat]=<%= cmbPayableAt.SelectedValue %>
            ,[cityfrom]=<%= cmbFrom.SelectedValue %>
            ,[cityto]=<%= cmbTo.SelectedValue %>
            ,[lrno]='<%= txtLrNo.Text %>'
            ,[lrdate]='<%= sqldate(dtLrDate.Value) %>'
            ,[inv]='<%= txtInv.Text %>'
            ,[AdvContra] = <%= ntxtCash2DrvByTrans.value %>
            ,[AdvCash] = <%= ntxtCash2Drv.value %>
            ,[Other1] = <%= ntxtOther1.value %>
            ,[Other2] = <%= ntxtOther2.value %>
            ,[Dasti] = <%= ntxtDasti.value %>
            ,[CommPercent] = <%= ntxtFrMarginPer.value %>
            ,[VarMargin] = <%= ntxtFrMarginRV.value %>
            ,[StaxOn] =  '<%= cmbSTon.SelectedItem %>'
            ,[Stax] = <%= ntxtStax.value %>
            ,[StaxPercent] = <%= ntxtSTRate.value %>
            ,[CoId] = <%= gCoId %>
               ,[ModifyBy] = '<%= gUserName %>'
            where id= <%= id %>
           </string>
            aqstr.Add(qstr)
            aqstr.Add("Delete from ttcItems where challanid = " & id)
            bd.MoveFirst()
            For I = 0 To bd.List.Count - 1
                Dim ROW As DataRowView = bd(I)
                qstr = _
                 <sting>
            INSERT INTO [ttcItems]
           ([ChallanId]
           ,[Weight]
           ,[Rate]
           ,[Amount]
           ,[RateDiff]
           ,[weightdiff]
           ,[Description]
           ,[Bags]
            ,[Remark],[CoId])
            VALUES
           (<%= id %>           
            ,<%= ROW("Weight") %>
           ,<%= ROW("Rate") %>
           ,<%= ROW("Amount") %>
           ,<%= ROW("RateDiff") %>
           ,<%= ROW("WeightDiff") %>
           ,'<%= ROW("Description") %>'
           ,<%= ROW("Bags") %>
           ,'<%= ROW("Remark") %>',<%= gCoId %>
            )
        </sting>
                aqstr.Add(qstr)
            Next
        End If
        If dbUpdate(aqstr.ToArray) Then
            save_acct()
            Fill_Challan()
            Fill_Controls()
            disableEntry()

        End If
    End Sub

    Private Sub tsbPrevious_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbPrevious.Click
        navmode = enNavMode.PrevRec
        mode = enDatamode.none
        Fill_Controls()
    End Sub

    Private Sub tsbEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbEdit.Click
        mode = enDatamode.Edit
        navmode = enNavMode.none
        ntxtChallan.Enabled = False
        '   Fill_Controls(dtchallan.DefaultView(rowindex))
        Fill_Controls()
        dtChallanDate.Focus()
    End Sub

    Private Sub tsbNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbNext.Click
        navmode = enNavMode.NextRec
        mode = enDatamode.none
        Fill_Controls()

    End Sub

    Private Sub tsbFirst_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbFirst.Click
        navmode = enNavMode.FirstRec
        mode = enDatamode.none
        Fill_Controls()
    End Sub

    Private Sub tsbLast_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbLast.Click
        navmode = enNavMode.LastRec
        mode = enDatamode.none
        Fill_Controls()
    End Sub
    Private Sub tsbNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbNew.Click
        mode = enDatamode.Add
        navmode = enNavMode.none
        ntxtChallan.Enabled = True
        ntxtChallan.Focus()
        id = 0
        clear_controls()
        ntxtChallan.value = nz(dbValue("select max(challan) from ttchallan  where bookid=" & bookid), 0) + 1
        enableEntry()
    End Sub

    Private Sub tsbSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSearch.Click
        Dim ofrm As New TransChallanSearch
        ofrm.Owner = Me
        ofrm.id = id
        ofrm.bookid = bookid
        ofrm.ShowDialog()
        If ofrm.id > 0 Then
            id = ofrm.id
            mode = enDatamode.none
            navmode = enNavMode.none

            Dim row As DataRowView
            Dim dv As DataView = dtchallan.DefaultView
            'For Each row As datrowview In dtchallan.DefaultView
            For i = 0 To dv.Count - 1
                row = dv(i)
                If row("id") = id Then
                    Fill_Controls(row)
                    rowindex = i
                    Exit For

                End If
            Next


        End If
    End Sub
#End Region
#Region "dgve"

    Private Sub dgve_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        Select Case e.ColumnIndex
            Case enItemColumns.Rate
                If dgv(enItemColumns.Rate, dgv.CurrentRow.Index).Value > 0 Then
                    dgv(enItemColumns.RateDiff, dgv.CurrentRow.Index).Value = dgv(enItemColumns.Rate, dgv.CurrentRow.Index).Value
                End If
                calc()
            Case enItemColumns.RateDiff
                calc()
            Case enItemColumns.Weight
                'If dgv(enItemColumns.Weight, dgv.CurrentRow.Index).Value > 0 Then

                '    Dim ing As Int16 = Mid(dgv(enItemColumns.Weight, dgv.CurrentRow.Index).Value, Len(Trim(dgv(enItemColumns.Weight, dgv.CurrentRow.Index).Value)) - 1, 2)
                '    If Mid(ing, 1, 1) <> 0 Then
                '        Dim ing1 As Double = Math.Round(ing / 1000, 3)
                '        dgv(enItemColumns.WeightDiff, dgv.CurrentRow.Index).Value = dgv(enItemColumns.Weight, dgv.CurrentRow.Index).Value
                '        dgv(enItemColumns.Weight, dgv.CurrentRow.Index).Value = dgv(enItemColumns.Weight, dgv.CurrentRow.Index).Value - ing1
                '    End If
                'End If
                If dgv(enItemColumns.Weight, dgv.CurrentRow.Index).Value > 0 Then
                    dgv(enItemColumns.WeightDiff, dgv.CurrentRow.Index).Value = dgv(enItemColumns.Weight, dgv.CurrentRow.Index).Value
                    '    dgv(enItemColumns.Weight, dgv.CurrentRow.Index).Value = Math.Ceiling(Math.Round(dgv(enItemColumns.Weight, dgv.CurrentRow.Index).Value, 2))
                    ' dgv(enItemColumns.Weight, dgv.CurrentRow.Index).Value = Math.Sign(dgv(enItemColumns.Weight, dgv.CurrentRow.Index).Value) * Math.Floor(Math.Abs(dgv(enItemColumns.Weight, dgv.CurrentRow.Index).Value) * 100) / 1000.0
                    Dim w As Double = dgv(enItemColumns.Weight, dgv.CurrentRow.Index).Value
                    Dim sw As String = Math.Floor(w)
                    Dim swd As String = (w - sw) * 1000
                    sw = sw & "." & swd.Substring(0, 1)
                    dgv(enItemColumns.Weight, dgv.CurrentRow.Index).Value = sw
                End If

                calc()
            Case enItemColumns.WeightDiff
                calc()

        End Select

    End Sub
    Private Sub dgve_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv.KeyDown
        Select Case e.KeyCode
            Case Keys.Insert
                DirectCast(dgv.DataSource, BindingSource).AddNew()

                dgv.CurrentCell = dgv.Rows(dgv.RowCount - 1).Cells(0)
                calc()
            Case Keys.Delete
                If MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Delete Item") = vbYes Then
                    dgv.Rows.Remove(dgv.SelectedRows(0))
                End If
                calc()
            Case Keys.Enter

                calc()

        End Select
    End Sub

    Private Sub CalcCharges()
        'If Not calculating Then
        '    calculating = True
        '    Dim dblRate As Double = 0
        '    ntxtGrossAmt.value = "0" & ntxtGrossAmt.Text.Replace(",", "")
        '    Dim tamount As Double = ntxtGrossAmt.value

        '    ntxtNetAmt.value = tamount
        '    calculating = False
        'End If
        ntxtAdvance.value = ntxtCash2Drv.value + ntxtCash2DrvByTrans.value + ntxtDasti.value + ntxtLabour.value + ntxtFrMargin.value
        ntxtTotAdv.value = ntxtAdvance.value
        ntxtNetAmt.value = ntxtGrossAmt.value - ntxtAdvance.value + ntxtOther1.value + ntxtOther2.value
    End Sub
#End Region
#Region "TextBox"
    Private Sub txtChallan_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not isLoading Then
            dtchallan.DefaultView.RowFilter = "challan = " & ntxtChallan.value
            Dim dr As DataRowView
            If dtchallan.DefaultView.Count > 0 Then
                dr = dtchallan.DefaultView(0)
                dtchallan.DefaultView.RowFilter = ""
                navmode = enNavMode.none
                mode = enDatamode.View
                Fill_Controls(dr)
            End If
            e.Cancel = False
        End If

    End Sub
    Private Sub dtChallanDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtChallanDate.Validating
        If ActiveControl.Name <> "btnCancel" Then
            dtchallan.DefaultView.RowFilter = "Challan = " & (ntxtChallan.value) - 1
            ''''Code commented not needed as per client requirment on dt 23/03/2012
            ''If dtchallan.DefaultView.Count > 0 Then
            ''    If dtChallanDate.Value < dtchallan.DefaultView(0)("Date") Then
            ''        ErrorProvider1.SetError(dtChallanDate, "Challan Date can not be greater than previous challan date")
            ''        e.Cancel = True
            ''    End If
            ''End If
            ''''Till here 
        End If

    End Sub
    Private Sub txtTdsAmt_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        calc()
    End Sub
#End Region
    Private Sub tsbGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGo.Click
        If tstChallan.Text = String.Empty Then
            Exit Sub
        End If
        tstChallan.Text = digitonly(tstChallan.Text)
        Dim dvgoto As DataView = dtchallan.DefaultView
        Dim dvr As DataRowView

        For i = 0 To dvgoto.Count - 1
            dvr = dvgoto(i)
            If dvr("challan") = tstChallan.Text Then
                navmode = enNavMode.none
                mode = enDatamode.none
                rowindex = i
                Fill_Controls(dvr)
                Exit Sub
            End If
        Next
    End Sub

    Private Sub frmChallan_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Dim dtChallanname As DataTable = modData.dbTable("Select id,Challanname+'~'+ prefix+ '~'+cast(accountid as varchar(10)) as challanname from mChallanName order by challanname")
        'If dtChallanname.Rows.Count = 0 Then
        '    MessageBox.Show("Please create challan books first", "Challan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Me.Close()
        '    Exit Sub
        'End If
        'Dim row As DataRow = dtChallanname.NewRow
        'row("Id") = 0
        'row("ChallanName") = "(Select)"

        'dtChallanname.Rows.InsertAt(row, 0)

    End Sub

#Region "CalcTextBoxEvents"
    Private Sub ntxtCash2Drv_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ntxtCash2Drv.Validating
        CalcCharges()
    End Sub
    Private Sub ntxtCash2DrvByTrans_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ntxtCash2DrvByTrans.Validating
        CalcCharges()
    End Sub
    Private Sub ntxtDasti_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ntxtDasti.Validating
        CalcCharges()
    End Sub
    Private Sub ntxtFrMargin_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ntxtFrMargin.Validating
        CalcCharges()
    End Sub
    Private Sub ntxtFrMarginPer_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ntxtFrMarginPer.Validating
        If ntxtFrMarginPer.value > 0 Then
            ntxtFrMargin.value = Math.Ceiling(ntxtGrossAmt.value * ntxtFrMarginPer.value / 1000) * 10
            ntxtFrMargin.ReadOnly = True
            ntxtCash2Drv.Focus()
        Else
            ntxtFrMargin.ReadOnly = False
            ntxtFrMargin.Focus()
        End If
        CalcCharges()
    End Sub

    Private Sub ntxtLabour_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ntxtLabour.Validating
        CalcCharges()
    End Sub
    Private Sub ntxtLabPerc_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ntxtLabPerc.Validating
        If ntxtLabPerc.value > 0 Then
            ntxtLabour.value = Math.Ceiling(ntxtLabPerc.value * ntxtGrossAmt.value / 1000) * 10
            ntxtLabour.ReadOnly = True
            ntxtFrMarginPer.Focus()
        Else
            ntxtLabour.ReadOnly = False
            ntxtLabour.Focus()
        End If

        CalcCharges()
    End Sub

    Private Sub ntxtOther1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ntxtOther1.Validating
        CalcCharges()
    End Sub

    Private Sub ntxtOther2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ntxtOther2.Validating
        CalcCharges()
    End Sub

    Private Sub ntxtStax_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ntxtStax.Validating
        CalcCharges()
    End Sub

    Private Sub ntxtSTRate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ntxtSTRate.Validating
        If ntxtSTRate.value > 0 Then
            ntxtStax.value = Math.Ceiling(ntxtGrossAmt.value * ntxtSTRate.value / 100)
            ntxtStax.ReadOnly = True
            btnSave.Focus()
        Else
            ntxtStax.ReadOnly = False
            ntxtStax.Focus()
        End If
        CalcCharges()
    End Sub

    Private Sub ntxtTDS_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ntxtTDS.Validating
        CalcCharges()
    End Sub

    Private Sub ntxtTDSRate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ntxtTDSRate.Validating
        If ntxtTDSRate.value > 0 Then
            ntxtTDS.value = Math.Ceiling(ntxtGrossAmt.value * ntxtTDSRate.value / 100)
            ntxtTDS.ReadOnly = True
            ntxtOther1.Focus()
        Else
            ntxtTDS.ReadOnly = False
            ntxtTDS.Focus()
        End If
        CalcCharges()
    End Sub
#End Region
    Private Sub dgv_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgv.RowsAdded
        If id > 0 Then
            If bd.List(bd.List.Count - 1)("ChallanId") = 0 Then
                bd.List(bd.List.Count - 1)("ChallanId") = id
            End If
        End If

    End Sub
    Private Sub save_acct()
        Dim enno As Short = 1
        Dim qstr As String = ""
        Dim voucher As String = bookname
        Dim aqstr As New List(Of String)
        Dim fmrvid As Integer = dbValue("Select id from sysaccounts where account ='Freight Margin (RV)'") ' freight margin id
        Dim fmid As Integer = dbValue("Select id from sysaccounts where account ='Freight Margin'") ' freight margin 
        Dim cashid As Integer = dbValue("Select id from sysaccounts where account ='Cash'") ' Cash Account Id
        Dim labourid As Integer = dbValue("Select id from sysaccounts where account ='Labour'") ' Labour Account Id
        Dim tdsid As Integer = dbValue("Select id from sysaccounts where account ='TDS'") ' TDS Account Id
        Dim StaxId As Integer = dbValue("Select id from sysaccounts where account ='Service Tax'") ' Service Tax Account Id


        Dim vid As Integer = 0

        If mode = enDatamode.Add Then
            qstr = "insert into tdatamain (voucherno,voucherprefix,vouchersuffix,date,amount,narration,accid,voucher,singlenarration,coid,type) values ("
            qstr &= ntxtChallan.value & ",'" & lblPrefix.Text & "','','" & sqldate(dtChallanDate.Value) & "',"
            qstr &= ntxtGrossAmt.value & ",'" & txtNarration.Text & "'," & cmbCustomer.SelectedValue & ", '" & voucher & "',1," & gCoId & ",'DR')"
            dbUpdate(New String() {qstr})
            qstr = "select id from tdatamain where voucher='" & voucher & "' and voucherno=" & ntxtChallan.value & " and coid = " & gCoId
            vid = nz(dbValue(qstr), 0)

        ElseIf mode = enDatamode.Delete Then
            qstr = "delete from tdatamain where id=" & vid
            aqstr.Add(qstr)
            qstr = "delete from tdatadetails where voucherid =" & vid
            aqstr.Add(qstr)
        End If
        If mode = enDatamode.Edit Then
            qstr = "select id from tdatamain where voucher='" & voucher & "' and voucherno=" & ntxtChallan.value & " and coid = " & gCoId
            vid = nz(dbValue(qstr), 0)
            If vid = 0 Then
                qstr = "insert into tdatamain (voucherno,voucherprefix,vouchersuffix,date,amount,narration,accid,voucher,singlenarration,coid,type) values ("
                qstr &= ntxtChallan.value & ",'" & lblPrefix.Text & "','','" & sqldate(dtChallanDate.Value) & "',"
                qstr &= ntxtGrossAmt.value & ",'" & txtNarration.Text & "'," & cmbCustomer.SelectedValue & ", '" & voucher & "',1," & gCoId & ",'DR')"
                dbUpdate(New String() {qstr})
                qstr = "select id from tdatamain where voucher='" & voucher & "' and voucherno=" & ntxtChallan.value & " and coid = " & gCoId
                vid = nz(dbValue(qstr), 0)
            End If
            qstr = "delete from tdatadetails where voucherid =" & vid
            aqstr.Add(qstr)
        End If
        enno = 1
        ''-- insert customer to transporter
        qstr = "insert into tdatadetails (voucherid,lineid,accid,amount,date,coid,type)"
        qstr &= "values (" & vid & "," & enno & "," & cmbCustomer.SelectedValue & "," & _
                ntxtGrossAmt.value + ntxtFrMarginRV.value & ",'" & sqldate(dtChallanDate.Value) & "', " & _
                gCoId & ",'" & "Dr" & "')"
        aqstr.Add(qstr)
        enno += 1
        qstr = "insert into tdatadetails (voucherid,lineid,accid,amount,date,coid,type)"
        qstr &= "values (" & vid & "," & enno & "," & cmbTransporter.SelectedValue & "," & _
                ntxtGrossAmt.value & ",'" & sqldate(dtChallanDate.Value) & "', " & _
                gCoId & ",'" & "Cr" & "')"
        aqstr.Add(qstr)
        enno += 1
        ''-- if freight margin (rv) > 0 
        If ntxtFrMarginRV.value > 0 Then
            qstr = "insert into tdatadetails (voucherid,lineid,accid,amount,date,coid,type)"
            qstr &= "values (" & vid & "," & enno & "," & fmrvid & "," & _
                    ntxtFrMarginRV.value & ",'" & sqldate(dtChallanDate.Value) & "', " & _
                    gCoId & ",'" & "Cr" & "')"
            aqstr.Add(qstr)
            enno += 1
        End If

        ''-- if freight margin (rv) < 0 
        If ntxtFrMarginRV.value < 0 Then
            qstr = "insert into tdatadetails (voucherid,lineid,accid,amount,date,coid,type)"
            qstr &= "values (" & vid & "," & enno & "," & fmrvid & "," & _
                    Math.Abs(ntxtFrMarginRV.value) & ",'" & sqldate(dtChallanDate.Value) & "', " & _
                    gCoId & ",'" & "Dr" & "')"
            enno += 1
            aqstr.Add(qstr)
        End If

        ''-- if cashadv1 >0
        If ntxtCash2Drv.value > 0 Then
            qstr = "insert into tdatadetails (voucherid,lineid,accid,amount,date,coid,type)"
            qstr &= "values (" & vid & "," & enno & "," & cmbTransporter.SelectedValue & "," & _
                    ntxtCash2Drv.value & ",'" & sqldate(dtChallanDate.Value) & "', " & _
                    gCoId & ",'" & "Dr" & "')"
            aqstr.Add(qstr)
            enno += 1

            qstr = "insert into tdatadetails (voucherid,lineid,accid,amount,date,coid,type)"
            qstr &= "values (" & vid & "," & enno & "," & cashid & "," & _
                    ntxtCash2Drv.value & ",'" & sqldate(dtChallanDate.Value) & "', " & _
                    gCoId & ",'" & "Cr" & "')"
            aqstr.Add(qstr)
            enno += 1
        End If
        If ntxtCash2DrvByTrans.value > 0 Then
            ''-- if cashadv2 >0
            Dim cash2date As Date = dtChallanDate.Value.AddDays(1)
            If cash2date.Day = 31 And cash2date.Month = 3 Then
                cash2date = dtChallanDate.Value
            End If
            qstr = "insert into tdatadetails (voucherid,lineid,accid,amount,date,coid,type)"
            qstr &= "values (" & vid & "," & enno & "," & cmbTransporter.SelectedValue & "," & _
                    ntxtCash2DrvByTrans.value & ",'" & sqldate(cash2date) & "', " & _
                    gCoId & ",'" & "Dr" & "')"
            aqstr.Add(qstr)
            enno += 1


            qstr = "insert into tdatadetails (voucherid,lineid,accid,amount,date,coid,type)"
            qstr &= "values (" & vid & "," & enno & "," & cashid & "," & _
                    ntxtCash2DrvByTrans.value & ",'" & sqldate(cash2date) & "', " & _
                    gCoId & ",'" & "Cr" & "')"
            aqstr.Add(qstr)
            enno += 1
        End If

        ''-- here add query for cash recd from transporter for cashadv2
        ''enno += 2
        ''-- if freight margin  > 0 
        If ntxtFrMargin.value > 0 Then
            qstr = "insert into tdatadetails (voucherid,lineid,accid,amount,date,coid,type)"
            qstr &= "values (" & vid & "," & enno & "," & cmbTransporter.SelectedValue & "," & _
                    ntxtFrMargin.value & ",'" & sqldate(dtChallanDate.Value) & "', " & _
                    gCoId & ",'" & "Dr" & "')"
            aqstr.Add(qstr)
            enno += 1
            qstr = "insert into tdatadetails (voucherid,lineid,accid,amount,date,coid,type)"
            qstr &= "values (" & vid & "," & enno & "," & fmid & "," & _
                    ntxtFrMargin.value & ",'" & sqldate(dtChallanDate.Value) & "', " & _
                    gCoId & ",'" & "Cr" & "')"
            aqstr.Add(qstr)
            enno += 1
        End If
        If ntxtLabour.value > 0 Then
            ''-- if labour  > 0 
            qstr = "insert into tdatadetails (voucherid,lineid,accid,amount,date,coid,type)"
            qstr &= "values (" & vid & "," & enno & "," & cmbTransporter.SelectedValue & "," & _
                    ntxtLabour.value & ",'" & sqldate(dtChallanDate.Value) & "', " & _
                    gCoId & ",'" & "Dr" & "')"
            aqstr.Add(qstr)
            enno += 1
            qstr = "insert into tdatadetails (voucherid,lineid,accid,amount,date,coid,type)"
            qstr &= "values (" & vid & "," & enno & "," & labourid & "," & _
                    ntxtLabour.value & ",'" & sqldate(dtChallanDate.Value) & "', " & _
                    gCoId & ",'" & "Cr" & "')"
            aqstr.Add(qstr)
            enno += 1
        End If
        ''-- if tds  > 0 
        If ntxtTDS.value > 0 Then
            qstr = "insert into tdatadetails (voucherid,lineid,accid,amount,date,coid,type)"
            qstr &= "values (" & vid & "," & enno & "," & cmbTransporter.SelectedValue & "," & _
                    ntxtTDS.value & ",'" & sqldate(dtChallanDate.Value) & "', " & _
                    gCoId & ",'" & "Dr" & "')"
            aqstr.Add(qstr)
            enno += 1
            qstr = "insert into tdatadetails (voucherid,lineid,accid,amount,date,coid,type)"
            qstr &= "values (" & vid & "," & enno & "," & tdsid & "," & _
                    ntxtTDS.value & ",'" & sqldate(dtChallanDate.Value) & "', " & _
                    gCoId & ",'" & "Cr" & "')"
            aqstr.Add(qstr)
            enno += 1
        End If

        ''-- if stax > 0 
        If ntxtStax.value > 0 Then
            qstr = "insert into tdatadetails (voucherid,lineid,accid,amount,date,coid,type)"
            qstr &= "values (" & vid & "," & enno & "," & cmbTransporter.SelectedValue & "," & _
                    ntxtStax.value & ",'" & sqldate(dtChallanDate.Value) & "', " & _
                    gCoId & ",'" & "Dr" & "')"
            aqstr.Add(qstr)
            enno += 1
            qstr = "insert into tdatadetails (voucherid,lineid,accid,amount,date,coid,type)"
            qstr &= "values (" & vid & "," & enno & "," & StaxId & "," & _
                    ntxtStax.value & ",'" & sqldate(dtChallanDate.Value) & "', " & _
                    gCoId & ",'" & "Cr" & "')"
            aqstr.Add(qstr)
            enno += 1
        End If

        ''-- if other1>0
        If ntxtOther1.value > 0 Then
            qstr = "insert into tdatadetails (voucherid,lineid,accid,amount,date,coid,type)"
            qstr &= "values (" & vid & "," & enno & "," & cmbCustomer.SelectedValue & "," & _
                    ntxtOther1.value & ",'" & sqldate(dtChallanDate.Value) & "', " & _
                    gCoId & ",'" & "Dr" & "')"
            aqstr.Add(qstr)
            enno += 1
            qstr = "insert into tdatadetails (voucherid,lineid,accid,amount,date,coid,type)"
            qstr &= "values (" & vid & "," & enno & "," & cmbTransporter.SelectedValue & "," & _
                    ntxtOther1.value & ",'" & sqldate(dtChallanDate.Value) & "', " & _
                    gCoId & ",'" & "Cr" & "')"
            aqstr.Add(qstr)
            enno += 1
        End If
        If ntxtOther2.value <> 0 Then
            ''-- if other2>0
            qstr = "insert into tdatadetails (voucherid,lineid,accid,amount,date,coid,type)"
            qstr &= "values (" & vid & "," & enno & "," & cmbCustomer.SelectedValue & "," & _
                   Math.Abs(ntxtOther2.value) & ",'" & sqldate(dtChallanDate.Value) & "', " & _
                    gCoId & ",'" & IIf(ntxtOther2.value > 0, "Dr", "Cr") & "')"

            aqstr.Add(qstr)
            enno += 1
            qstr = "insert into tdatadetails (voucherid,lineid,accid,amount,date,coid,type)"
            qstr &= "values (" & vid & "," & enno & "," & cmbTransporter.SelectedValue & "," & _
                Math.Abs(ntxtOther2.value) & ",'" & sqldate(dtChallanDate.Value) & "', " & _
                    gCoId & ",'" & IIf(ntxtOther2.value < 0, "Dr", "Cr") & "')"

            aqstr.Add(qstr)
        End If

        dbUpdate(aqstr.ToArray)
        aqstr.Clear()

        qstr = "Select count(dataid) from trefdata where refno = '" & lblPrefix.Text & ntxtChallan.value & "' and accid = " & cmbCustomer.SelectedValue & " and period = '" & gPeriod & "'"
        If nz(dbValue(qstr), 0) = 0 Then
            qstr = "Insert into trefdata (dataid,lineid,accid,Refno,Amount,Type,RefDate,RefType,Period,coid) values (" & _
                       vid & ",0," & cmbCustomer.SelectedValue & "," & _
                       "'" & lblPrefix.Text & ntxtChallan.value & "'," & _
                       ntxtGrossAmt.value + ntxtFrMarginRV.value & ",'Dr'," & _
                       "'" & sqldate(dtChallanDate.Value) & "'," & _
                       "'New','" & gPeriod & "'," & gCoId & ")"
            aqstr.Add(qstr)
        Else
            qstr = "Update trefdata set dataid = " & vid & _
                    ",lineid = 0, " & _
                    "accid = " & cmbCustomer.SelectedValue & "," & _
                    "Refno = '" & lblPrefix.Text & ntxtChallan.value & "'," & _
                    "Amount = " & ntxtGrossAmt.value + ntxtFrMarginRV.value & "," & _
                    "Type = 'Dr' ," & _
                    "RefDate ='" & sqldate(dtChallanDate.Value) & "'," & _
                    "RefType = 'New'," & _
                    "Period = '" & gPeriod & "'," & _
                    "CoId = " & gCoId & _
                    " where refno = '" & lblPrefix.Text & ntxtChallan.value & "' and accid = " & cmbCustomer.SelectedValue & " and period = '" & gPeriod & "'"
            aqstr.Add(qstr)

        End If
        qstr = "Select count(dataid) from trefdata where refno = '" & lblPrefix.Text & ntxtChallan.value & "' and accid = " & cmbTransporter.SelectedValue & " and period = '" & gPeriod & "'"
        If nz(dbValue(qstr), 0) = 0 Then
            qstr = "Insert into trefdata (dataid,lineid,accid,Refno,Amount,Type,RefDate,RefType,Period,coid) values (" & _
                       vid & ",0," & cmbTransporter.SelectedValue & "," & _
                       "'" & lblPrefix.Text & ntxtChallan.value & "'," & _
                      Math.Abs(ntxtNetAmt.value) & ",'" & IIf(ntxtNetAmt.value < 0, "Dr", "Cr") & "'," & _
                                   "'" & sqldate(dtChallanDate.Value) & "'," & _
                       "'New','" & gPeriod & "'," & gCoId & ")"
            aqstr.Add(qstr)
        Else
            qstr = "Update trefdata set dataid = " & vid & _
                  ",lineid = 0, " & _
                  "accid = " & cmbTransporter.SelectedValue & "," & _
                  "Refno = '" & lblPrefix.Text & ntxtChallan.value & "'," & _
                  "Amount = " & Math.Abs(ntxtNetAmt.value) & "," & _
                  "Type = '" & IIf(ntxtNetAmt.value < 0, "Dr", "Cr") & "' ," & _
                              "RefDate ='" & sqldate(dtChallanDate.Value) & "'," & _
                  "RefType = 'New'," & _
                  "Period = '" & gPeriod & "'," & _
                   "CoId = " & gCoId & _
                  " where refno = '" & lblPrefix.Text & ntxtChallan.value & "' and accid = " & cmbTransporter.SelectedValue & " and period = '" & gPeriod & "'"
            aqstr.Add(qstr)
        End If
        dbUpdate(aqstr.ToArray)
    End Sub
    Private Sub dtChallanDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtChallanDate.ValueChanged
        dtLrDate.Value = dtChallanDate.Value
    End Sub
    Private Sub cmbTo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTo.SelectedIndexChanged
        'If cmbFrom.SelectedIndex = 1 Then
        '    Dim ofrm As New mCity
        '    ofrm.formtype = "city"
        '    ofrm.id = 0
        '    ofrm.mode = enDatamode.Add
        '    ofrm.CityType = "To"
        '    ofrm.ShowDialog()
        '    If ofrm.DialogResult = Windows.Forms.DialogResult.OK Then
        '        fill_combocommon(cmbFrom, "Select * from mCity where cType = 'To' order by City", "City", "id")
        '        cmbFrom.SelectedValue = ofrm.id
        '    End If
        'End If


    End Sub
    'Private Sub cmbPayableAt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPayableAt.SelectedIndexChanged
    '    If cmbFrom.SelectedIndex = 1 Then
    '        Dim ofrm As New mCity
    '        ofrm.formtype = "city"
    '        ofrm.id = 0
    '        ofrm.mode = enDatamode.Add
    '        ofrm.CityType = "PayableAt"
    '        ofrm.ShowDialog()
    '        If ofrm.DialogResult = Windows.Forms.DialogResult.OK Then
    '            fill_combocommon(cmbFrom, "Select * from mCity where cType = 'PayableAt' order by City", "City", "id")
    '            cmbFrom.SelectedValue = ofrm.id
    '        End If
    '    End If
    'End Sub
    Private Sub ntxtChallan_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ntxtChallan.Validating
        If Not isLoading Then
            dtchallan.DefaultView.RowFilter = "challan = " & ntxtChallan.value & " and period = '" & gPeriod & "'"
            Dim dr As DataRowView
            If dtchallan.DefaultView.Count > 0 Then
                dr = dtchallan.DefaultView(0)
                dtchallan.DefaultView.RowFilter = ""
                navmode = enNavMode.none
                mode = enDatamode.View
                Fill_Controls(dr)
            End If
            e.Cancel = False
        End If
    End Sub

    Private Sub cmbCustomer_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbCustomer.Validating
        If Not isLoading Then
            If Me.ActiveControl.Name <> "btnCancel" Then
                If cmbCustomer.SelectedIndex = 1 Then
                    Dim ofrm As New LedgerEntry
                    ofrm.id = 0
                    ofrm.mode = enDatamode.Add
                    ofrm.ShowDialog()
                    If ofrm.DialogResult = Windows.Forms.DialogResult.OK Then
                        Fill_Combo(cmbCustomer)
                        cmbCustomer.SelectedValue = ofrm.id
                        e.Cancel = False
                    Else
                        e.Cancel = True
                    End If
                ElseIf cmbCustomer.SelectedIndex <= 0 Then
                    MsgBox("Please Select Customer")
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub cmbTransporter_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbTransporter.Validating
        If Not isLoading Then
            If Me.ActiveControl.Name <> "btnCancel" Then
                If cmbTransporter.SelectedIndex = 1 Then
                    Dim ofrm As New LedgerEntry
                    ofrm.id = 0
                    ofrm.mode = enDatamode.Add
                    ofrm.ShowDialog()
                    If ofrm.DialogResult = Windows.Forms.DialogResult.OK Then
                        Fill_Combo(cmbTransporter)
                        cmbTransporter.SelectedValue = ofrm.id
                        e.Cancel = False
                    Else
                        e.Cancel = True
                    End If
                ElseIf cmbTransporter.SelectedIndex <= 0 Then
                    MsgBox("Please Select Transport")
                    e.Cancel = True
                End If
                If cmbTransporter.SelectedValue > 0 Then
                    Dim dt As DataTable = dbTable("select mLedger.ledger,mLedgerdetails.owner from mLedger,mLedgerdetails where mLedgerdetails.Ledgerid =mledger.id and mledger.id = " & cmbTransporter.SelectedValue)
                    txtOwner.Text = dt.Rows(0).Item("owner")
                    txtLorryno.Text = dt.Rows(0).Item("Ledger")


                End If
            End If
        End If

    End Sub

    Private Sub cmbFrom_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbFrom.Validating
        If Not isLoading Then
            If Me.ActiveControl.Name <> "btnCancel" Then
                If cmbFrom.SelectedIndex = 1 Then
                    Dim ofrm As New mCity
                    ofrm.formtype = "city"
                    ofrm.id = 0
                    ofrm.mode = enDatamode.Add
                    ofrm.CityType = "From"
                    ofrm.ShowDialog()
                    If ofrm.DialogResult = Windows.Forms.DialogResult.OK Then
                        fill_combocommon(cmbFrom, "Select * from mCity where cType = 'From' order by City", "City", "id")
                        cmbFrom.SelectedValue = ofrm.id
                        e.Cancel = False
                    Else
                        e.Cancel = True
                    End If
                ElseIf cmbFrom.SelectedIndex <= 0 Then
                    MsgBox("Please Select City From")
                    e.Cancel = True
                End If
            End If
        End If
    End Sub
    Private Sub cmbTo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbTo.Validating
        If Not isLoading Then


            If Me.ActiveControl.Name <> "btnCancel" Then
                If cmbTo.SelectedIndex = 1 Then

                    Dim ofrm As New mCity
                    ofrm.formtype = "city"
                    ofrm.id = 0
                    ofrm.mode = enDatamode.Add
                    ofrm.CityType = "To"

                    ofrm.ShowDialog()
                    If ofrm.DialogResult = Windows.Forms.DialogResult.OK Then
                        fill_combocommon(cmbTo, "Select * from mCity where cType = 'To' order by City", "City", "id")
                        cmbTo.SelectedValue = ofrm.id
                        e.Cancel = False


                    Else
                        e.Cancel = True
                    End If
                ElseIf cmbTo.SelectedIndex <= 0 Then
                    MsgBox("Please Select City to ")


                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub cmbPayableAt_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbPayableAt.Validating

        If Not isLoading Then
            If Me.ActiveControl.Name <> "btnCancel" Then
                If cmbPayableAt.SelectedIndex = 1 Then

                    Dim ofrm As New mCity
                    ofrm.formtype = "city"
                    ofrm.id = 0
                    ofrm.mode = enDatamode.Add
                    ofrm.CityType = "PayableAt"

                    ofrm.ShowDialog()
                    If ofrm.DialogResult = Windows.Forms.DialogResult.OK Then
                        fill_combocommon(cmbPayableAt, "Select * from mCity where cType = 'PayableAt' order by City", "City", "id")
                        cmbPayableAt.SelectedValue = ofrm.id
                        e.Cancel = False


                    Else
                        e.Cancel = True
                    End If
                ElseIf cmbPayableAt.SelectedIndex <= 0 Then
                    MsgBox("Please Select City Payable At ")


                    e.Cancel = True
                End If
            End If
        End If
    End Sub
End Class
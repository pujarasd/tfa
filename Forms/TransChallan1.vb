Public Class frmChallan
    Friend mode As enDatamode
    Friend id As Integer
    Friend navmode As enNavMode = enNavMode.LastRec
    Dim dtchallan As DataTable
    Friend dtchdetail As DataTable
    Friend dtChChgs As DataTable
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
        Id
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
        isLoading = True
        Me.Height = 600
        Me.Width = 900
        Grid_Create()


        pnlmain.Visible = False
        pnlsave.Visible = False

        dtChallanDate.MaxDate = gFinEndDate
        dtChallanDate.MinDate = gFinStartDate
        'Dim thisTextBox As New ToolStripComboBox
        'thisTextBox = CType(tbNav.Items("tscBook"), ToolStripComboBox)
        'thisTextBox.Focus()
        'tbNav.Items("tscBook").Select()
        'tscBook.Select()
        ' tscBook.ComboBox.Select()
        ActiveControl = tscBook.ComboBox
        tbEdit.Enabled = False
        tstChallan.Enabled = False
        ' SendKeys.Send("{F4}")
        isLoading = False

    End Sub

#End Region
#Region "Procedures"

    Sub Fill_Combo(Optional ByVal cmb As ComboBox = Nothing)
        '' transporter
        If cmb Is Nothing Then
            fill_combocommon(cmbTransporter, "Select id,Ledger from mledger where groupid=" & enLedger.Creditors & " order by ledger", "ledger", "Id")
            fill_combocommon(cmbLorry, "select id,acid,lorryno from mtransdetails order by lorryno", "lorryno", "id")
            fill_combocommon(cmbCustomer, "Select id,ledger from mledger where groupid = " & enLedger.Debtors & " order by ledger", "ledger", "id")
            fill_combocommon(cmbFrom, "Select id,city from mcity where ctype= " & enCityType.FromCity & " order by city", "city", "id")
            fill_combocommon(cmbTo, "Select id,city from mcity where ctype= " & enCityType.ToCity & " order by city", "city", "id")
            fill_combocommon(cmbPayableAt, "Select id,city from mcity where ctype= " & enCityType.PayableAtCity & " order by city", "city", "id")
        Else
            Select Case cmb.Name
                Case "cmbCustomer"
                    fill_combocommon(cmbCustomer, "Select id,ledger from mledger where groupid = " & enLedger.Debtors & " order by ledger", "ledger", "id")
                Case "cmbLorry"
                    fill_combocommon(cmbLorry, "select id,acid,lorryno from mtransdetails order by lorryno", "lorryno", "id")
                Case "cmbFrom"
                    fill_combocommon(cmbFrom, "Select id,city from mcity where ctype= " & enCityType.FromCity & " order by city", "city", "id")
                Case "cmbTo"
                    fill_combocommon(cmbTo, "Select id,city from mcity where ctype= " & enCityType.ToCity & " order by city", "city", "id")

                Case "cmbPayableAt"
                    fill_combocommon(cmbPayableAt, "Select id,city from mcity where ctype= " & enCityType.PayableAtCity & " order by city", "city", "id")

                Case "cmbTransporter"
                    fill_combocommon(cmbTransporter, "Select id,Ledger from mledger where groupid=" & enLedger.Creditors & " order by ledger", "ledger", "Id")
            End Select
        End If



    End Sub
    Sub Fill_Challan()
        Dim qstr As String = _
         <string>
          Select a.*,b.ledger from ttranschallan a 
          inner join mledger b on b.id = a.custid 
          where bookid= <%= tscBook.ComboBox.SelectedValue %>  order by challan
           </string>
        dtchallan = dbTable(qstr)
        SetDefaultClearNull(dtchallan)
        qstr = _
        <string>
            Select a.* from ttranschallandetails a 
            order by a.challanid
          </string>

        dtchdetail = dbTable(qstr)
        SetDefaultClearNull(dtchdetail)
        qstr = _
        <String>
            Select a.*,c.*,o.chargeon,l.ledger account  from ttranschallancharge a 
            inner join mCharges c on c.id = a.chargeid
            inner join mChargeOn o on o.ctId=c.rateon
inner join mledger l on l.id = c.acid
        </String>
        dtChChgs = dbTable(qstr)
        SetDefaultClearNull(dtChChgs)

        If dtchallan.Rows.Count = 0 Then
            clear_controls()
        Else
            Fill_Controls()
        End If
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
        ntxtGrossAmt.Text = ROW("GrossAmount")
        ntxtNetAmt.value = ROW("Payable")
        cmbCustomer.SelectedValue = ROW("CustId")
        txtDriver.Text = ROW("Driver")
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


        'End If


        Dim dv As DataView = dtchdetail.DefaultView
        dv.RowFilter = "challanid = " & id
        dgv.DataSource = dv
        Dim dvchgs As DataView = dtChChgs.DefaultView
        dvchgs.RowFilter = "challanid = " & id
        dgvCharges.DataSource = dvchgs

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
                .Add("Id", "Id")
                .Add("Description", "Content")
                .Add("Bags", "Package")
                .Add("Weight", "Weight")
                .Add("Rate", "Rate")
                .Add("WeightDiff", "RV Weight")
                .Add("RateDiff", "RV Rate")
                .Add("Amount", "Amount")
                .Add("Remark", "Remark")
            End With
            With .Columns("Id")
                .Visible = False
            End With
            With .Columns("Description")
                .DataPropertyName = "Description"
                .Width = 100
                .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            End With
            With .Columns("Bags")
                .DataPropertyName = "Bags"
                .Width = 30
                .CellTemplate.Style.Format = "n2"
                .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight

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
                .DataPropertyName = "ChargeAmt"
                .Width = 60
                .CellTemplate.Style.Format = "n2"
                .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight

            End With

            With .Columns("Remark")
                .DataPropertyName = "Remark"
                .Width = 100
            End With

        End With

        dgvdefault(dgvCharges)
        With dgvCharges

            .Columns.Clear()
            With .Columns
                .Add("Id", "Id")
                .Add("Charge", "Charge")
                .Add("Rate", "Rate")
                .Add("RateOn", "Rate On")
                .Add("AmountOn", "Amount On")
                .Add("Amount", "Amount")
                .Add("Account", "Account")
                .Add("ChargeId", "Chargeid")
                .Add("RateOnid", "RateOnid")
            End With
            With .Columns("Id")
                .Visible = False
            End With
            With .Columns("Chargeid")
                .DataPropertyName = "ChargeId"
                .Visible = False
            End With
            With .Columns("RateOnid")
                .DataPropertyName = "RateOn"
                .Visible = False
            End With
            With .Columns("Charge")
                .DataPropertyName = "Charge"
                .Width = 100
                .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            End With
            With .Columns("Rate")
                .DataPropertyName = "Rate"
                .Width = 30
                .CellTemplate.Style.Format = "N3"
                .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight

            End With
            With .Columns("RateOn")
                .DataPropertyName = "ChargeOn"
                .Width = 40
                ' .ReadOnly = True
                .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleLeft

            End With
            With .Columns("AmountOn")
                .DataPropertyName = "AmountOn"
                .Width = 50
                '  .ReadOnly = True
                .CellTemplate.Style.Format = "n2"
                .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight

            End With
            With .Columns("Amount")
                .DataPropertyName = "ChargeAmt"
                .Width = 50
                .CellTemplate.Style.Format = "n2"
                .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight

            End With


            With .Columns("Account")
                .DataPropertyName = "Account"
                .Width = 150
            End With

        End With

    End Sub



    Sub disableEntry()
        pnlmain.Enabled = False
        pnlsave.Enabled = False
    End Sub
    Sub enableEntry()
        pnlmain.Enabled = True
        pnlsave.Enabled = True
    End Sub

    Sub calc()
        Dim tamount As Double = 0
        Dim tvaramt As Double = 0
        For i = 0 To dgv.RowCount - 1
            tamount += "0" & dgv(enItemColumns.Amount, i).Value
            tvaramt += (("0" & dgv(enItemColumns.RateDiff, i).Value) * ("0" & dgv(enItemColumns.WeightDiff, i).Value))
        Next
        ntxtVarGross.value = tvaramt
        ntxtGrossAmt.Text = tamount
        CalcCharges()

    End Sub
    Sub clear_controls()
        Fill_Combo()
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
        dtChallanDate.Value = Today
        dtLrDate.Value = Today
        Dim dv As DataView = dtchdetail.DefaultView
        dv.RowFilter = "challanid = " & id
        dgv.DataSource = dv
        Dim dvchgs As DataView = dtChChgs.DefaultView
        dvchgs.RowFilter = "challanid = " & id
        dgvCharges.DataSource = dvchgs
        dtchdetail.Rows.Clear()
        dtChChgs.Rows.Clear()
    End Sub
#End Region

#Region "Combo"
    Private Sub tscBook_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tscBook.SelectedIndexChanged
        If Not isLoading Then
            mode = enDatamode.none
            navmode = enNavMode.LastRec
            If tscBook.SelectedIndex = 0 Then
                pnlmain.Visible = False
                pnlsave.Visible = False
                tbEdit.Enabled = False
                tsbFirst.Enabled = False
                tsbLast.Enabled = False
                tsbNew.Enabled = False
                tsbNext.Enabled = False
                tsbPrevious.Enabled = False
                tstChallan.Enabled = False


                Exit Sub
            Else
                pnlmain.Visible = True
                pnlsave.Visible = True
                tbEdit.Enabled = True
                tsbFirst.Enabled = True
                tsbLast.Enabled = True
                tsbNew.Enabled = True
                tsbNext.Enabled = True
                tsbPrevious.Enabled = True
                tstChallan.Enabled = True

            End If
            Fill_Combo()
            Fill_Challan()

            pnlmain.Visible = True
            pnlsave.Visible = True
            If ntxtChallan.value = 0 Then
                tsbNew_Click(Nothing, Nothing)
            Else
                tbEdit.Focus()
                tbEdit.Items(0).Select()
            End If
            Dim ledgerid As Integer = tscBook.SelectedItem(1).ToString.Split("~")(2)
            If ledgerid > 0 Then
                cmbCustomer.SelectedValue = nz(dbValue("SELECT Id FROM mLEDGER WHERE id=" & tscBook.SelectedItem(1).ToString.Split("~")(2)), 0)
            Else
                cmbCustomer.SelectedIndex = 0
            End If

            lblPrefix.Text = tscBook.SelectedItem(1).ToString.Split("~")(1)
        End If
    End Sub

#End Region
#Region "Buttons"

    Private Sub tsbRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbRefresh.Click
        If Not isLoading Then Fill_Challan()
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If id = 0 And dtchallan.Rows.Count = 0 Then
            tscBook.SelectedIndex = 0
            tscBook.Enabled = True
            Exit Sub
        Else
            Fill_Challan()
            Fill_Controls()
            disableEntry()
            tscBook.Enabled = True
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim qstr As String = ""
        Dim aqstr As New List(Of String)
        If mode = enDatamode.Add Then
            qstr = _
            <string>INSERT INTO [ttranschallan]
           ([BookId]
           ,[Challan]
           ,[Date]
           ,[CustId]
           ,[TransportId]
           ,[Narration]
           ,[GrossAmount]
           ,vargrossamt
           ,[Payable]
            ,lorryid
            ,shipno
            ,DIno
            ,driver
            ,owner
            ,payableat
            ,cityfrom
            ,cityto
            ,lrno
            ,lrdate
            ,inv)       
            VALUES(
           <%= tscBook.ComboBox.SelectedValue %>
           ,<%= ntxtChallan.value %>
           ,'<%= sqldate(dtChallanDate.Value.Date.ToString) %>'
           ,<%= cmbCustomer.SelectedValue %>
           ,<%= cmbTransporter.SelectedValue %>
           ,'<%= txtNarration.Text %>'     
           ,<%= ntxtGrossAmt.value %>
           ,<%= ntxtVarGross.value %>
           ,<%= ntxtNetAmt.value %>
           ,<%= cmbLorry.SelectedValue %>  
           ,'<%= txtShip.Text %>'
           ,'<%= txtDiNo.Text %>'
           ,'<%= txtDriver.Text %>'
           ,'<%= txtOwner.Text %>'
           ,<%= cmbPayableAt.SelectedValue %>
           ,<%= cmbFrom.SelectedValue %>
           ,<%= cmbTo.SelectedValue %>
           ,'<%= txtLrNo.Text %>'
           ,'<%= sqldate(dtLrDate.Value.Date.ToString) %>'
           ,'<%= txtInv.Text %>')
            </string>
            aqstr.Add(qstr)
            Dim DV As DataView = dtchdetail.DefaultView
            DV.RowFilter = "CHALLANID = " & id

            For Each row As DataRowView In DV
                qstr = _
                 <sting>
            INSERT INTO [ttranschallanDetails]
           ([ChallanId]
           ,[Weight]
           ,[Rate]
           ,[Amount]
           ,[RateDiff]
           ,[weightdiff]
           ,[Description]
           ,[Bags]
            ,[Remark])
            VALUES
           (IDENT_CURRENT('ttranschallan')
           ,<%= row("Weight") %>
           ,<%= row("Rate") %>
           ,<%= row("Amount") %>
           ,<%= row("RateDiff") %>
           ,<%= row("WeightDiff") %>
           ,'<%= row("Description") %>'
           ,<%= row("Bags") %>
           ,'<%= row("Remark") %>'
            )


        </sting>
                aqstr.Add(qstr)
            Next
            DV = dtChChgs.DefaultView
            DV.RowFilter = "CHALLANID=" & id
            For Each row As DataRowView In DV
                qstr = _
                <string>
                    insert into ttranschallancharge (
                    challanid,
                    ChargeId,
                    ChargeAmt) Values (
                    IDENT_CURRENT('ttranschallan'),
                    <%= row("ChargeId") %>,
                    <%= row("chargeAmt") %>
                    )
                </string>
                aqstr.Add(qstr)
            Next


        ElseIf mode = enDatamode.Edit Then
            qstr = _
           <string>Update [ttranschallan] Set
            [BookId]=<%= tscBook.ComboBox.SelectedValue %>
            ,[Challan]=<%= ntxtChallan.value %>
            ,[Date]='<%= sqldate(dtChallanDate.Value) %>'
            ,[CustId]=<%= cmbCustomer.SelectedValue %>
            ,[TransportId]=<%= cmbTransporter.SelectedValue %>
            ,[Mode]='B'
            ,[Narration]='<%= txtNarration.Text %>'
            ,[GrossAmount]=<%= ntxtGrossAmt.value %>
            ,[Payable]=<%= ntxtNetAmt.value %>
            ,[varGrossAmt]=<%= ntxtVarGross.value %>
            ,[LorryId] =<%= cmbLorry.SelectedValue %>
            ,[ShipNo]='<%= txtShip.Text %>'
            ,[DIno]='<%= txtDiNo.Text %>'
            ,[driver]='<%= txtDriver.Text %>'
            ,[owner]='<%= txtOwner.Text %>'
            ,[payableat]=<%= cmbPayableAt.SelectedValue %>
            ,[cityfrom]=<%= cmbFrom.SelectedValue %>
            ,[cityto]=<%= cmbTo.SelectedValue %>
            ,[lrno]='<%= txtLrNo.Text %>'
            ,[lrdate]='<%= sqldate(dtLrDate.Value) %>'
            ,[inv]='<%= txtInv.Text %>'
            where id= <%= id %>
           </string>
            aqstr.Add(qstr)
            aqstr.Add("Delete from ttranschallanDetails where challanid = " & id)
            Dim DV As DataView = dtchdetail.DefaultView
            DV.RowFilter = "CHALLANID = " & id

            For Each row As DataRowView In DV
                qstr = _
                 <sting>
            INSERT INTO [ttranschallanDetails]
           ([ChallanId]
           ,[Weight]
           ,[Rate]
           ,[Amount]
           ,[RateDiff]
           ,[weightdiff]
           ,[Description]
           ,[Bags]
            ,[Remark])
            VALUES
           (<%= id %>           
            ,<%= row("Weight") %>
           ,<%= row("Rate") %>
           ,<%= row("Amount") %>
           ,<%= row("RateDiff") %>
           ,<%= row("WeightDiff") %>
           ,'<%= row("Description") %>'
           ,<%= row("Bags") %>
           ,'<%= row("Remark") %>'
            )


        </sting>
                aqstr.Add(qstr)
            Next
            aqstr.Add("Delete from ttranschallancharge where challanid = " & id)
            DV = dtChChgs.DefaultView
            DV.RowFilter = "CHALLANID=" & id
            For Each row As DataRowView In DV
                qstr = _
                <string>
                    insert into ttranschallancharge (
                    challanid,
                    ChargeId,
                    ChargeAmt) Values (
                    <%= id %>    ,
                    <%= row("ChargeId") %>,
                    <%= row("chargeAmt") %>
                    )
                </string>
                aqstr.Add(qstr)
            Next

        End If
        If dbUpdate(aqstr.ToArray) Then
            Fill_Challan()
            Fill_Controls()
            disableEntry()
            tscBook.Enabled = True

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
        tscBook.Enabled = False
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
        tscBook.Enabled = False
        ntxtChallan.Enabled = True
        ntxtChallan.Focus()
        id = 0
        clear_controls()
        ntxtChallan.value = nz(dbValue("select max(challan) from ttranschallan  where bookid=" & tscBook.SelectedItem(0)), 0) + 1
        enableEntry()
    End Sub

    Private Sub tsbSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSearch.Click
        Dim ofrm As New TransChallanSearch
        ofrm.Owner = Me
        ofrm.id = id
        ofrm.bookid = tscBook.SelectedItem(0)
        ofrm.ShowDialog()
        If ofrm.id > 0 Then
            id = ofrm.id
            mode = enDatamode.none
            navmode = enNavMode.none
            For Each row In dtchallan.DefaultView
                If row("id") = id Then
                    Fill_Controls(row)
                    Exit For

                End If
            Next


        End If
    End Sub
#End Region
#Region "DGV"


    Private Sub dgv_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv.GotFocus
        If dgv.RowCount = 0 Then
            Dim ofrm As New TransChallanItem
            ofrm.mode = enEntry.Add
            ofrm.challan = Me
            ofrm.ShowDialog()

            calc()
        End If
    End Sub
    Private Sub dgv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv.KeyDown
        Select Case e.KeyCode
            Case Keys.Insert
                Dim ofrm As New TransChallanItem
                ofrm.mode = enEntry.Add
                ofrm.challan = Me
                ofrm.ShowDialog()
                calc()
            Case Keys.Delete
                If MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Delete Item") = vbYes Then
                    dgv.Rows.Remove(dgv.SelectedRows(0))
                End If
                calc()
            Case Keys.Enter
                Dim ofrm As New TransChallanItem
                ofrm.challan = Me
                ofrm.mode = enEntry.Edit
                ofrm.ShowDialog()
                calc()

        End Select
    End Sub

    Private Sub CalcCharges()
        If Not calculating Then
            calculating = True
            Dim dblRate As Double = 0
            ntxtGrossAmt.value = "0" & ntxtGrossAmt.Text.Replace(",", "")
            Dim tamount As Double = ntxtGrossAmt.value
            For i = 0 To dgvCharges.RowCount - 1

                tamount += dgvCharges(enChargeColumns.Amount, i).Value

            Next
            ntxtNetAmt.value = tamount
            calculating = False
        End If

    End Sub






    Private Sub dgvCharges_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvCharges.GotFocus

        If dgvCharges.RowCount = 0 Then
            Dim ofrm As New ttranschallancharges
            ofrm.mode = enEntry.Add
            ofrm.challan = Me
            ofrm.ShowDialog()
            calc()
        End If
    End Sub

    Private Sub dgvCharges_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvCharges.KeyDown
        'If e.KeyCode = Keys.Insert Then
        '    SetDefaultClearNull(dtChChgs)
        '    dtChChgs.Rows.Add(dtChChgs.NewRow)
        '    dgvCharges.DataSource = dtChChgs
        'End If
        Select Case e.KeyCode
            Case Keys.Insert
                Dim ofrm As New ttranschallancharges
                ofrm.mode = enEntry.Add
                ofrm.challan = Me
                ofrm.ShowDialog()
                CalcCharges()
            Case Keys.Delete
                If MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Delete Charges") = vbYes Then
                    dgvCharges.Rows.Remove(dgvCharges.SelectedRows(0))
                End If
                CalcCharges()
            Case Keys.Enter
                Dim ofrm As New ttranschallancharges
                ofrm.challan = Me
                ofrm.mode = enEntry.Edit
                ofrm.ShowDialog()
                CalcCharges()

        End Select
    End Sub



    Private Sub dgv_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgv.MouseDoubleClick
        Dim hi = dgv.HitTest(e.X, e.Y)
        If hi.Type = DataGridViewHitTestType.Cell Then
            Dim ofrm As New TransChallanItem
            ofrm.challan = Me
            ofrm.mode = enEntry.Edit
            ofrm.ShowDialog()
            calc()
        End If

    End Sub

    Private Sub dgvCharges_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvCharges.MouseDoubleClick
        Dim hi = dgvCharges.HitTest(e.X, e.Y)
        If hi.Type = DataGridViewHitTestType.Cell Then
            Dim ofrm As New ttranschallancharges
            ofrm.challan = Me
            ofrm.mode = enEntry.Edit
            ofrm.ShowDialog()
            CalcCharges()
        End If
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
            If dtchallan.DefaultView.Count > 0 Then
                If dtChallanDate.Value < dtchallan.DefaultView(0)("Date") Then
                    ErrorProvider1.SetError(dtChallanDate, "Challan Date can not be greater than previous challan date")
                    e.Cancel = True
                End If
            End If
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
        For Each row In dtchallan.DefaultView
            If row("challan") = tstChallan.Text Then
                navmode = enNavMode.none
                mode = enDatamode.none
                Fill_Controls(row)
                Exit Sub
            End If
        Next
    End Sub

    Private Sub frmChallan_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim dtChallanname As DataTable = modData.dbTable("Select id,Challanname+'~'+ prefix+ '~'+cast(accountid as varchar(10)) as challanname from mChallanName order by challanname")
        If dtChallanname.Rows.Count = 0 Then
            MessageBox.Show("Please create challan books first", "Challan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Exit Sub
        End If
        Dim row As DataRow = dtChallanname.NewRow
        row("Id") = 0
        row("ChallanName") = "(Select)"

        dtChallanname.Rows.InsertAt(row, 0)
        tscBook.ComboBox.DataSource = dtChallanname
        tscBook.ComboBox.ValueMember = "Id"
        tscBook.ComboBox.DisplayMember = "ChallanName"
        tscBook.SelectedIndex = 0
    End Sub

    Private Sub cmbCustomer_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCustomer.SelectedIndexChanged
        If Not isLoading Then
            If cmbCustomer.SelectedIndex = 1 Then
                Dim ofrm As New LedgerEntry
                ofrm.id = 0
                ofrm.mode = enDatamode.Add
                ofrm.ShowDialog()
                If ofrm.DialogResult = Windows.Forms.DialogResult.OK Then
                    Fill_Combo(cmbCustomer)
                    cmbCustomer.SelectedValue = ofrm.id
                End If
            End If
        End If

    End Sub


End Class
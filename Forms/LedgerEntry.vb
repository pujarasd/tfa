Public Class LedgerEntry
    Friend mode As enDatamode
    Friend id As Integer
    Dim isLoading As Boolean = True
    Dim arefqstr As New List(Of String)
    Dim reflist As New ArrayList
    Private Sub LedgerEntry_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Back)
            Case ChrW(Keys.Enter)
                If TypeOf Me.ActiveControl Is TextBox Then
                    If CType(Me.ActiveControl, TextBox).Multiline = True Then
                        Exit Sub
                    End If
                ElseIf TypeOf Me.ActiveControl Is Button Then
                    Exit Sub
                End If
                SendKeys.Send("{Tab}")
        End Select
    End Sub
    Private Sub LedgerEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fill_combo()
        Select Case mode
            Case enDatamode.Edit, enDatamode.View, enDatamode.Delete
                Fill_Controls()
        End Select
        isLoading = False
    End Sub
    Sub fill_combo()
        fill_combocommon(cmbAgent, "Select * from mAgent order by id", "agent", "id")
        fill_combocommon(cmbTransporter, "Select * from mTransport order by id", "Transport", "id")
        fill_combocommon(cmbCity, "Select * from mCity where cType = 'To' order by City", "City", "id")
        fill_combocommon(cmbGroup, "Select * from mLedgerGroup where id<>groupid order by id ", "GroupName", "id")

        'Dim dt As DataTable = dbTable("Select * from mAgent order by id")
        'cmbAgent.DataSource = dt

        'cmbAgent.ValueMember = "id"
        'cmbAgent.DisplayMember = "Agent"
        ' ''----
        'cmbTransporter.DataSource = dbTable("Select * from mTransport order by id")
        'cmbTransporter.ValueMember = "id"
        'cmbTransporter.DisplayMember = "Transport"
        ' ''---
        'cmbCity.DataSource = dbTable("Select * from mCity order by id")
        'cmbCity.ValueMember = "id"
        'cmbCity.DisplayMember = "City"
        ''---
        'cmbGroup.DataSource = dbTable("Select * from mLedgerGroup where id<>groupid order by id ")
        'cmbGroup.ValueMember = "id"
        'cmbGroup.DisplayMember = "GroupName"
        '----
    End Sub
    Sub Fill_Controls()
        Dim dt As DataTable = dbTable("Select * from mledger where id = " & id)
        Dim dt1 As DataTable = dbTable("select * from mledgerdetails where ledgerid = " & id)
        Dim dt2 As DataTable = dbTable("Select * from mledgeropbal where ledgerid = " & id & " and coid = " & gCoId)
        Dim row As DataRow = dt.Rows(0)
        Dim row1 As DataRow
        If (dt1.Rows.Count > 0) Then
            row1 = dt1.Rows(0)
        Else
            row1 = dt1.NewRow()
        End If
        Dim row2 As DataRow
        If (dt2.Rows.Count > 0) Then
            row2 = dt2.Rows(0)
        Else
            row2 = dt2.NewRow()
        End If


        txtAddress.Text = row1("Address") & ""
        txtCreditamt.value = nz(row1("CreditAmount"), 0)
        txtCreditDays.value = nz(row1("CreditDays"), 0)
        txtCST.Text = row1("CST") & ""
        txtDiscountrate.value = nz(row1("DiscountRate"), 0)
        txtEmail.Text = row1("Email") & ""
        txtFax.Text = row1("Fax") & ""
        txtLedger.Text = row("Ledger") & ""
        txtMobile.Text = row1("Mobile") & ""
        txtOpbal.value = nz(row2("Amount"), 0)
        txtOwner.Text = row1("Owner") & ""
        txtPAN.Text = row1("Pan") & ""
        txtPin.Text = row1("Pin") & ""
        txtSidedays.value = nz(row1("Sidedays"), 0)
        txtST.Text = row1("LST") & ""
        txtTdsrate.value = nz(row1("TDSRate"), 0)
        txtTdsRate2.value = nz(row1("TDSRate2"), 0)
        txtTelephone.Text = row1("Telephone") & ""
        dtReg.Value = nz(row1("reg_date"), curyearstartdate)
        If nz(row2("OPDate"), curyearstartdate) > curyearstartdate() Then
            dtOpDate.Text = curyearstartdate()
        Else
            dtOpDate.Text = nz(row2("OPDate"), curyearstartdate)
        End If

        dtEffcFrom.Text = nz(row1("eff_date"), curyearstartdate)

        cmbAdjust.SelectedIndex = IIf(nz(row("BBB"), 0) = True, 1, 0)
        cmbAgent.SelectedValue = nz(row1("AgentId"), 0)
        cmbCity.SelectedValue = nz(row1("CityId"), 0)
        cmbDrCr.SelectedItem = nz(row2("Type"), "Dr")
        cmbGroup.SelectedValue = nz(row("GroupId"), 0)
        cmbTransporter.SelectedValue = nz(row1("TransportId"), 0)
        chkInventory.Checked = nz(row("Stock"), 0)
        If cmbAdjust.SelectedIndex < 0 Then cmbAdjust.SelectedIndex = 0
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim chk As Boolean = chk_combo()
        If chk = False Then
            Exit Sub
        End If
        Dim qstr As String = ""
        Dim aqstr(2) As String
        If txtLedger.Text = "" Then
            MessageBox.Show("Please select Account", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtLedger.Focus()
            Exit Sub
        End If
        If cmbGroup.SelectedValue = 0 Or cmbCity.SelectedValue = 0 Then
            MessageBox.Show("Please select Group", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbGroup.Focus()
            Exit Sub
        End If
        If cmbAdjust.SelectedIndex = -1 Then cmbAdjust.SelectedIndex = 0

        Select Case mode
            Case enDatamode.Add
                qstr = _
                <string>
                    insert into mledger (
                    ledger,bbb,stock,groupid)
                    values (
                    '<%= txtLedger.Text & "" %>',
                     <%= cmbAdjust.SelectedIndex %>,
                    <%= CInt(chkInventory.Checked) %>,
                    <%= cmbGroup.SelectedValue %>)
                </string>
                aqstr(0) = qstr
                qstr = ""
                qstr = _
                <string>
                    insert into mledgerdetails (
                    ledgerid,
                    owner,
                    address,
                    cityid,
                    telephone,
                    fax,
                    mobile,
                    email,
                    lst,
                    cst,
                    pan,
                    creditdays,
                    sidedays,
                    tdsrate,
                    discountrate,
                    agentid,
                    transportid,
                    creditamount,
                    Reg_Date,
                    Eff_Date)
                    values (
                     IDENT_CURRENT('MLEDGER'),
                    '<%= txtOwner.Text & "" %>',
                    '<%= txtAddress.Text & "" %>',
                    <%= nz(cmbCity.SelectedValue, 0) %>,
                    '<%= txtTelephone.Text & "" %>',
                    '<%= txtFax.Text & "" %>',
                    '<%= txtMobile.Text & "" %>',
                    '<%= txtEmail.Text & "" %>',
                    '<%= txtST.Text & "" %>',
                    '<%= txtCST.Text & "" %>',
                    '<%= txtPAN.Text & "" %>',
                    <%= nz(txtCreditDays.value, 0) %>,
                    <%= nz(txtSidedays.value, 0) %>,
                    <%= nz(txtTdsrate.value, 0) %>,
                    <%= nz(txtDiscountrate.value, 0) %>,
                    <%= nz(cmbAgent.SelectedValue, 0) %>,
                    <%= nz(cmbTransporter.SelectedValue, 0) %>,
                    <%= nz(txtCreditamt.value, 0) %>,
                    '<%= sqldate(dtReg.Value) %>',
                    '<%= sqldate(dtEffcFrom.Value) %>')
                </string>
                aqstr(1) = qstr
                qstr = "Insert into mLedgerOpBal (LedgerId,CoId,Amount,type,OpDate) values ("
                qstr &= " IDENT_CURRENT('MLEDGER')," & gCoId & "," & txtOpbal.value & ",'" & cmbDrCr.SelectedItem & "','" & sqldate(dtOpDate.Value) & "')"
                aqstr(2) = qstr
            Case enDatamode.Edit
                qstr = _
              <string>
                    update mledger set
                    ledger='<%= txtLedger.Text & "" %>',
                     bbb=<%= cmbAdjust.SelectedIndex %>,
                    stock=<%= CInt(chkInventory.Checked) %>,
                    groupid=<%= cmbGroup.SelectedValue %>
                    where id = <%= id %>
              </string>
                aqstr(0) = qstr
                qstr = ""
                If nz(dbValue("Select count(*) from mledgerdetails where ledgerid = " & id), 0) = 0 Then
                    qstr = _
         <string>
                    insert into mledgerdetails (
                    ledgerid,
                    owner,
                    address,
                    cityid,
                    telephone,
                    fax,
                    mobile,
                    email,
                    lst,
                    cst,
                    pan,
                    creditdays,
                    sidedays,
                    tdsrate,
                    discountrate,
                    agentid,
                    transportid,
                    creditamount,
                    Reg_Date,
                    Eff_Date)
                    values (
                     <%= id %>,
                    '<%= txtOwner.Text & "" %>',
                    '<%= txtAddress.Text & "" %>',
                    <%= nz(cmbCity.SelectedValue, 0) %>,
                    '<%= txtTelephone.Text & "" %>',
                    '<%= txtFax.Text & "" %>',
                    '<%= txtMobile.Text & "" %>',
                    '<%= txtEmail.Text & "" %>',
                    '<%= txtST.Text & "" %>',
                    '<%= txtCST.Text & "" %>',
                    '<%= txtPAN.Text & "" %>',
                    <%= nz(txtCreditDays.value, 0) %>,
                    <%= nz(txtSidedays.value, 0) %>,
                    <%= nz(txtTdsrate.value, 0) %>,
                    <%= nz(txtDiscountrate.value, 0) %>,
                    <%= nz(cmbAgent.SelectedValue, 0) %>,
                    <%= nz(cmbTransporter.SelectedValue, 0) %>,
                    <%= nz(txtCreditamt.value, 0) %>,
                    '<%= sqldate(dtReg.Value) %>',
                    '<%= sqldate(dtEffcFrom.Value) %>')
                </string>
                    aqstr(1) = qstr
                Else
                    qstr = _
                    <string>
                    update mledgerdetails set
                    owner='<%= txtOwner.Text & "" %>',
                    address= '<%= txtAddress.Text & "" %>',
                    cityid= <%= nz(cmbCity.SelectedValue, 0) %>,
                    telephone='<%= txtTelephone.Text & "" %>',
                    fax= '<%= txtFax.Text & "" %>',
                    mobile= '<%= txtMobile.Text & "" %>',
                    email= '<%= txtEmail.Text & "" %>',
                    lst= '<%= txtST.Text & "" %>',
                    cst= '<%= txtCST.Text & "" %>',
                    pan= '<%= txtPAN.Text & "" %>',
                    creditdays=<%= nz(txtCreditDays.value, 0) %>,
                    sidedays=   <%= nz(txtSidedays.value, 0) %>,
                    tdsrate= <%= nz(txtTdsrate.value, 0) %>,
                    tdsrate2= <%= nz(txtTdsRate2.value, 0) %>,
                    discountrate= <%= nz(txtDiscountrate.value, 0) %>,
                    agentid=  <%= nz(cmbAgent.SelectedValue, 0) %>,
                    transportid= <%= nz(cmbTransporter.SelectedValue, 0) %>,
                    creditamount= <%= nz(txtCreditamt.value, 0) %>,
                    Reg_date = '<%= sqldate(dtReg.Value) %>',
                    Eff_date = '<%= sqldate(dtEffcFrom.Value) %>' 
                    where ledgerid=<%= id %>
                    </string>
                    aqstr(1) = qstr
                End If
                If nz(dbValue("Select * from mledgeropbal where ledgerid = " & id & " and coid = " & gCoId), 0) = 0 Then
                    qstr = "Insert into mLedgerOpBal (LedgerId,CoId,Amount,type,OpDate) values ( "
                    qstr &= id & " ," & gCoId & "," & txtOpbal.value & ",'" & cmbDrCr.SelectedItem & "','" & sqldate(dtOpDate.Value) & "')"
                    aqstr(2) = qstr
                Else

                    qstr = "Update mLedgerOpBal set CoId = " & gCoId & ","
                    qstr &= "Amount=" & txtOpbal.value & ",type = '" & cmbDrCr.SelectedItem & "',"
                    qstr &= "OpDate='" & sqldate(dtOpDate.Value) & "'"
                    qstr &= " Where LedgerId = " & id & " and coid = " & gCoId

                    aqstr(2) = qstr
                End If
        End Select
        If dbupdate(aqstr) Then
            save_ref()
            If mode = enDatamode.Add Then id = dbValue("select max(id) from mledger")

            DialogResult = Windows.Forms.DialogResult.OK
            Exit Sub
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Exit Sub
    End Sub
    ''Code Added by Gaurav on dt 08-03-2012
    Private Sub cmbGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGroup.SelectedIndexChanged
    End Sub  ''Till Here 
    Private Sub txtOpBal_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
        If cmbAdjust.SelectedIndex = 1 And txtOpbal.value <> 0 Then
            Dim ofrm As New RefEntry
            ofrm.accId = 0
            ofrm.lineid = 1
            ofrm.dataid = 0
            ofrm.adj_amt = txtOpbal.value  ''Val(txtOpbal.Text)
            ofrm.ShowDialog()
        End If
    End Sub
    Private Function chk_combo()
        If cmbGroup.SelectedIndex <= 0 Then
            MessageBox.Show("Please select Group", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbGroup.Focus()
            Return False
        End If
        If cmbCity.SelectedIndex <= 0 Then
            MessageBox.Show("Please select City", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbCity.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub cmbCity_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbCity.Validating
        If Not isLoading Then
            If Me.ActiveControl.Name <> "btnCancel" Then
                If cmbCity.SelectedIndex = 1 Then
                    Dim ofrm As New mCity
                    ofrm.formtype = "city"
                    ofrm.id = 0
                    ofrm.mode = enDatamode.Add
                    ofrm.CityType = "To"
                    ofrm.ShowDialog()
                    If ofrm.DialogResult = Windows.Forms.DialogResult.OK Then
                        fill_combocommon(cmbCity, "Select * from mCity where cType = 'To' order by Id", "City", "id")
                        cmbCity.SelectedValue = ofrm.id
                        e.Cancel = False
                    Else
                        e.Cancel = True
                    End If
                ElseIf cmbCity.SelectedIndex <= 0 Then
                    MsgBox("Please Select City ")
                    e.Cancel = True
                End If
            If cmbCity.SelectedIndex > 0 Then
                Dim dt As DataTable = dbTable("select State,'India' as country  from mstate where id = " & cmbCity.SelectedItem(3))
                If dt.Rows.Count > 0 Then
                    lblState.Text = dt.Rows(0)(0).ToString
                    lblCountry.Text = dt.Rows(0)(1).ToString
                End If
                dt = Nothing
                End If
            End If
        End If
    End Sub

    Private Sub cmbGroup_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbGroup.Validating
        If Not isLoading Then
            If Me.ActiveControl.Name <> "btnCancel" Then
                If cmbGroup.SelectedIndex = 1 Then
                    Dim ofrm As New LedgerGroup
                    ofrm.id = 0
                    ofrm.mode = enDatamode.Add
                    ofrm.ShowDialog()
                    If ofrm.DialogResult = Windows.Forms.DialogResult.OK Then
                        fill_combocommon(cmbGroup, "Select * from mLedgerGroup where id<>groupid order by Groupname ", "GroupName", "id")
                        cmbGroup.SelectedValue = ofrm.id
                        e.Cancel = False
                    Else
                        e.Cancel = True
                    End If
                ElseIf cmbGroup.SelectedIndex <= 0 Then
                    MsgBox("Please Select Group")
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    
    Function save_ref() As Boolean
        Dim qstr As String
        '' create query for ref update
        Dim refno As String = ""
        Dim refdate As Date = Now.Date
        Dim refamt As Decimal = 0.0
        Dim reftype As String = ""
        Dim type As String = ""
        Dim period As String = ""
        Dim lineid As Int16 = 0
        Dim accid As Integer = 0
        arefqstr.Clear()
        dbupdate("Delete from trefdata where dataid = " & -id)
        For i = 0 To reflist.Count - 1
            refno = reflist(i)(0)
            refdate = reflist(i)(1)
            refamt = reflist(i)(2)
            type = reflist(i)(3)
            reftype = reflist(i)(4)
            lineid = reflist(i)(5)
            accid = reflist(i)(6)
            period = reflist(i)(7)
           
            qstr = "insert into trefdata (Amount,Refno,Refdate,type,reftype,dataid,lineid,accid,coid,period) " & _
                     "values (" & Math.Abs(refamt) & "," & _
                     "'" & refno & "', " & _
                    "'" & sqldate(refdate) & "', " & _
                    "'" & type & "', " & _
                     "'" & reftype & "', " & _
                    "" & -id & ", " & _
                    "" & lineid & "," & _
                    "" & accid & "," & gCoId & "," & _
                    "'" & period & "')"
            Dim isdup As Boolean = False
            For Each str1 In arefqstr
                If str1 = qstr Then
                    isdup = True
                    Exit For
                End If
            Next
            If Not isdup Then arefqstr.Add(qstr)
            '   End If
        Next
        reflist.Clear()
        Return dbupdate(arefqstr.ToArray)
    End Function

    Private Sub cmbDrCr_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbDrCr.Validating
        If cmbAdjust.SelectedIndex = 1 Then
            Dim ofrm As New Reference2
            With ofrm
                .dataid = -id
                .lineid = -1
                .refamt = txtOpbal.value
                .refno = 0
                .refDate = dtOpDate.Value
                .adjAmt = txtOpbal.value
                .adjType = cmbDrCr.SelectedItem
                .AccId = id
                .account = txtLedger.Text
                .voucher = 0
                .vdate = dtOpDate.Value
            End With
            ofrm.ShowDialog()
            Dim refno As String = ""
            Dim refdate As Date = Now.Date
            Dim refamt As Decimal = 0.0
            Dim reftype As String = ""
            Dim type As String = ""
            Dim qstr As String = ""
            Dim period As String = ""
            Dim accid As Integer
            ' Dim aqstr As New List(Of String)

            For Each row As DataGridViewRow In ofrm.dgv.Rows
                refno = row.Cells("Refno").Value
                refdate = row.Cells("RefDate").Value
                refamt = row.Cells("RefAmt").Value
                type = row.Cells("type").Value
                reftype = row.Cells("reftype").Value
                accid = ofrm.AccId
                period = row.Cells("Period").Value
                Dim astr(7) As String
                astr(0) = refno
                astr(1) = refdate
                astr(2) = refamt
                astr(3) = type
                astr(4) = reftype
                astr(5) = ofrm.lineid
                astr(6) = ofrm.AccId
                astr(7) = period
                If reflist.Count > 0 Then
                    For i = reflist.Count - 1 To 0 Step -1
                        ' If ofrm.lineid 
                        If reflist(i)(5) = ofrm.lineid And reflist(i)(0) = refno Then
                            reflist.RemoveAt(i)
                            Exit For
                        End If
                    Next
                End If
                reflist.Add(astr)


            Next
            'End If
        End If
    End Sub
End Class
Public Class VoucherOld
    Dim vPrefix As String
    Dim vSuffix As String
    Dim vName As String
    Dim vType As String
    Dim vDrCr As String
    Dim dtv As DataTable
    Dim dtvd As DataTable
    Dim isAuto As Boolean
    Dim numStart As Integer

    Dim rowid As Integer
    Dim navmode As enNavMode
    Dim mode As enEntry
    Dim groupfilter As String
    Dim isLoading As Boolean
    Public Sub New(ByVal VoucherPrefix As String, ByVal VoucherName As String, ByVal VoucherType As String)

        ' This call is required by the Windows Form Designer.
        isLoading = True
        InitializeComponent()
        isLoading = False
        Dim avtype() As String = VoucherPrefix.Split(New Char() {"~"})
        vPrefix = avtype(0)
        vSuffix = avtype(1)
        isAuto = avtype(2)
        numStart = avtype(3)
        vName = VoucherName
        vType = VoucherType
        Dim acccmbquery As String = ""
        If vType.Contains("Credit") Then
            vDrCr = "Cr"
            groupfilter = " ( groupid = " & enLedger.Debtors & " or groupid = " & enLedger.Creditors & ") "
        ElseIf vType.Contains("Debit") Then
            vDrCr = "Dr"
            groupfilter = " ( groupid =  " & enLedger.Debtors & " or groupid = " & enLedger.Creditors & ") "
        ElseIf vType.Contains("Receipt") Then
            vDrCr = "Dr"
            groupfilter = " ( groupid = " & enLedger.CashBank & ") "
        ElseIf vType.Contains("Payment") Then
            vDrCr = "Cr"
            groupfilter = " ( groupid = " & enLedger.CashBank & ") "
        ElseIf vType.Contains("Sale") Then
            vDrCr = "Cr"
            groupfilter = " ( groupid = " & enLedger.Debtors & ") "
        ElseIf vType.Contains("Purchase") Then
            vDrCr = "Dr"
            groupfilter = " ( groupid = " & enLedger.Creditors & ") "
        Else
            vDrCr = "DC"
            groupfilter = "1=1"
        End If

        dgvdefault(dgv)
        dgv.RowHeadersVisible = True
        dgv.AllowUserToDeleteRows = True
        dgv.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
        dgv.AutoGenerateColumns = False
        dgv.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        Dim cmbcol As New DataGridViewComboBoxColumn
        Dim dt As DataTable = dbTable("Select id,ledger from mledger order by ledger")
        Dim row As DataRow = dt.NewRow
        row("id") = -1
        row("ledger") = "(Add New)"
        dt.Rows.InsertAt(row, 0)
        row = dt.NewRow
        row("id") = 0
        row("ledger") = "(Select)"
        dt.Rows.InsertAt(row, 0)
        cmbcol.DataSource = dt
        cmbcol.DisplayMember = "Ledger"
        cmbcol.ValueMember = "Id"
        cmbcol.HeaderText = "Account"
        cmbcol.Name = "Account"
        cmbcol.AutoComplete = True
        cmbcol.Width = 200
        ''Column 0
        Dim cmbcoltype As New DataGridViewComboBoxColumn
        cmbcoltype.Items.AddRange(New String() {"Dr", "Cr", "To", "By"})
        cmbcoltype.AutoComplete = True
        cmbcoltype.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
        cmbcoltype.HeaderText = "Type"
        cmbcoltype.Name = "Type"
        cmbcoltype.Width = 50


        dgv.Columns.Add(cmbcoltype)
        dgv.Columns("Type").DataPropertyName = "type"
        dgv.Columns("Type").Width = 50
        ''Column 1
        dgv.Columns.Add(cmbcol)
        dgv.Columns("Account").Width = 200
        dgv.Columns("Account").DataPropertyName = "AccId"

        ''Column 2
        dgv.Columns.Add("Debit", "Debit Amount")
        dgv.Columns("Debit").DataPropertyName = "Debit"
        dgv.Columns("Debit").Width = 100
        dgv.Columns("Debit").CellTemplate.Style.Format = "F2"
        dgv.Columns("Debit").CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        ''Column 3
        dgv.Columns.Add("Credit", "Credit Amount")
        dgv.Columns("Credit").DataPropertyName = "Credit"
        dgv.Columns("Credit").Width = 100
        dgv.Columns("Credit").CellTemplate.Style.Format = "F2"
        dgv.Columns("Credit").CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        ''Column 4
        dgv.Columns.Add("Narration", "Narration")
        dgv.Columns("Narration").Width = 100
        dgv.Columns("Narration").CellTemplate.Style.WrapMode = DataGridViewTriState.True
        dgv.Columns("Narration").DataPropertyName = "Narration"
        ''Column 5
        dgv.Columns.Add("ChqNo", "ChqNo")
        dgv.Columns("ChqNo").DataPropertyName = "ChqNo"
        ''Column 6
        dgv.Columns.Add("ChqDate", "ChqDate")
        dgv.Columns("chqdate").CellTemplate.Style.Format = "d"
        dgv.Columns("ChqDate").DataPropertyName = "ChqDate"
        ''Column 7
        dgv.Columns.Add("Bank", "Bank")
        dgv.Columns("Bank").DataPropertyName = "Bank"
        ''Column 8
        dgv.Columns.Add("Branch", "Branch")
        dgv.Columns("Branch").DataPropertyName = "Branch"
        ''Column 9
        dgv.Columns.Add("x", "")
        dgv.Columns("x").Width = 1

        dgv.AutoResizeColumns()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Voucher_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblPrefix.Text = vPrefix
        lblSuffix.Text = vSuffix
        If isAuto Then numVoucherNo.Enabled = False

        Text = vName
        If vType = "Journal" Or vType = "Challan" Then
            cmbAccount.Visible = False
            lblAccount.Visible = False
        End If
        ' rowid = dtv.Rows.Count - 1
        Load_Data()
    End Sub
    Sub Load_Data()
        dtv = dbTable("Select * from tdatamain where coid = " & gCoId & " and voucher = '" & vName & "'")
        If dtv.Rows.Count = 0 Then
            SetDefaultClearNull(dtv)
            Dim dr As DataRow = dtv.NewRow
            dr("coid") = gCoId
            dr("Voucher") = vName
            dr("VoucherNo") = numStart
            dr("VoucherPrefix") = vPrefix
            dr("Date") = Now.Date
            dr("Type") = vDrCr
            mode = enEntry.Add

            dtv.Rows.Add(dr)

            navmode = enNavMode.none
        Else
            mode = enEntry.View
            navmode = enNavMode.LastRec
        End If

        bs.DataSource = dtv
        Fill_Combo()
        chkNarration.DataBindings.Add("Checked", bs, "SingleNarration")
        cmbAccount.DataBindings.Add("SelectedValue", bs, "accid")
        dtpDate.DataBindings.Add("Value", bs, "date")
        dtpchq.DataBindings.Add("Value", bs, "ChqDate")
        'numCredit.DataBindings.Add("Value",bs,"
        'numDebit 
        numNet.DataBindings.Add("Value", bs, "Amount")
        numVoucherNo.DataBindings.Add("Value", bs, "VoucherNo")
        txtBank.DataBindings.Add("text", bs, "Bank")
        txtBranch.DataBindings.Add("text", bs, "Branch")
        txtchq.DataBindings.Add("text", bs, "chqno")
        txtNarration.DataBindings.Add("text", bs, "narration")
        lblDrCr.DataBindings.Add("text", bs, "type")
        txtId.DataBindings.Add("text", bs, "Id")
        Nav_Data()

    End Sub

    Sub Nav_Data()
        If mode = enEntry.Add Then

            ' bs.AddNew()
            '  bs(0)(0) = 0
            '  bs.EndEdit()
            Fill_Controls()
        Else

            Select Case navmode
                Case enNavMode.FirstRec
                    bs.MoveFirst()
                Case enNavMode.LastRec
                    bs.MoveLast()
                Case enNavMode.NextRec
                    bs.MoveNext()
                Case enNavMode.PrevRec
                    bs.MovePrevious()
            End Select
            Fill_Controls()
        End If
        If mode = enEntry.Edit Or mode = enEntry.Add Then
            enableControls(True)
            pnlSave.Visible = True
            btnSave.Text = "Save"
        ElseIf mode = enEntry.Delete Then
            enableControls(False)
            pnlSave.Visible = True
            btnSave.Text = "Delete"
        ElseIf mode = enEntry.View Then
            enableControls(False)
            pnlSave.Visible = False

        End If
        chkNarration_CheckStateChanged(Nothing, Nothing)
    End Sub
    Sub Fill_Combo()
        Dim qry As String
        If vType = "Journal" Or vType = "Challan" Then
            qry = "Select * from mledger where " & groupfilter
        Else
            qry = " with cte as  " & _
          "(select * from mledgergroup where " & groupfilter & _
          " union all " & _
          " select t.* from cte inner join mledgergroup t on t.groupid = cte.id) " & _
          " select mledger.id,mledger.ledger+' ~ '+cte.groupname as ledger from cte inner join mledger on mledger.groupid = cte.id order by ledger "
        End If

        fill_combocommon(cmbAccount, qry, "Ledger", "Id")
    End Sub
    Sub Fill_Controls()


        If Not chkNarration.Checked And dgv.Height = 294 Then
            dgv.Height = dgv.Height + pnlNarration.Height + pnlBank.Height
            dgv.Top = pnlBank.Top
        End If
        ''Details 
        dtvd = dbTable("Select tdatadetails.*,0.0 as debit,0.0 as credit  from tdatadetails where voucherid=" & txtId.Text & "  order by lineid")
        dtvd.Columns("Debit").ReadOnly = False
        dtvd.Columns("Credit").ReadOnly = False
        If dtvd.Rows.Count = 0 Then
            SetDefaultClearNull(dtvd)
            Dim dr As DataRow = dtvd.NewRow

            dr("voucherid") = numVoucherNo.value
            dr("LineId") = 1
            dr("AccId") = 0
            dr("Amount") = 0
            dr("Debit") = 0.0
            dr("Credit") = 0.0
            dr("Narration") = ""
            dr("date") = dtpDate.Value
            dr("ChqNo") = ""
            dr("chqdate") = dtpDate.Value
            dr("Bank") = ""
            dr("Branch") = ""
            dr("CoId") = gCoId
            dr("Type") = IIf(vDrCr = "Dr", "Cr", "Dr")


            dtvd.Rows.Add(dr)

        Else
            SetDefaultClearNull(dtvd)
            For Each row In dtvd.Rows
                If row("Type") = "Dr" Then
                    row("Debit") = row("Amount")
                    row("Credit") = 0
                Else
                    row("Credit") = row("Amount")
                    row("Debit") = 0

                End If
            Next
        End If

        bsd.DataSource = dtvd
        dgv.DataSource = bsd

    End Sub
    Sub enableControls(ByVal enable As Boolean)
        pnlvoucher.Enabled = enable
        pnlBank.Enabled = enable
        pnlNarration.Enabled = enable
        dgv.ReadOnly = Not enable
        pnlSave.Visible = enable
        tbEdit.Enabled = Not enable
        tbNav.Enabled = Not enable
        chkNarration.Enabled = enable
        pnlNarration.Visible = chkNarration.Checked
        pnlBank.Visible = chkNarration.Checked And vType.Contains("Bank")

    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If dtv.Rows.Count = 1 And mode = enEntry.Add And dtv.Rows(0)("Amount") = 0 Then
            Me.Close()
            Exit Sub
        End If
        If mode = enEntry.Add Or mode = enEntry.Delete Then
            navmode = enNavMode.LastRec
            mode = enEntry.View

            Fill_Controls()
            enableControls(False)
        ElseIf mode = enEntry.Edit Then
            navmode = enNavMode.none
            mode = enEntry.View
            Fill_Controls()
            enableControls(False)
        ElseIf mode = enEntry.View Then

        End If
    End Sub

    Private Sub chkNarration_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNarration.CheckStateChanged
        If Not isLoading Then
            If chkNarration.CheckState = CheckState.Checked Then

                pnlBank.Visible = IIf(vType.Contains("Bank"), True, False)
                pnlNarration.Visible = True
                dgv.Height = 294
                dgv.Top = pnlNarration.Top + pnlNarration.Height + 1

                dgv.Columns("Narration").Visible = False
                dgv.Columns("Bank").Visible = False
                dgv.Columns("Branch").Visible = False
                dgv.Columns("ChqNo").Visible = False
                dgv.Columns("ChqDate").Visible = False

            Else

                pnlBank.Visible = IIf(vType.Contains("Bank"), True, False)
                pnlNarration.Visible = False
                dgv.Height = dgv.Height + pnlNarration.Height + pnlBank.Height
                dgv.Top = pnlBank.Top
                dgv.Columns("Narration").Visible = True
                dgv.Columns("Bank").Visible = IIf(vType.Contains("Bank"), True, False)
                dgv.Columns("Branch").Visible = IIf(vType.Contains("Bank"), True, False)
                dgv.Columns("ChqNo").Visible = IIf(vType.Contains("Bank"), True, False)
                dgv.Columns("ChqDate").Visible = IIf(vType.Contains("Bank"), True, False)


            End If
        End If

    End Sub








    Private Sub dgv_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        If e.ColumnIndex = 0 Then
            If dgv.Rows(e.RowIndex).Cells(0).Value = "Dr" Then
                dgv.Rows(e.RowIndex).Cells("Debit").ReadOnly = False
                dgv.Rows(e.RowIndex).Cells("Credit").ReadOnly = True
                If dgv.Rows(e.RowIndex).Cells("Debit").Value = 0 Then
                    dgv.Rows(e.RowIndex).Cells("Debit").Value = dgv.Rows(e.RowIndex).Cells("Credit").Value
                End If
                dgv.Rows(e.RowIndex).Cells("Credit").Value = 0
            Else
                dgv.Rows(e.RowIndex).Cells("Debit").ReadOnly = True
                dgv.Rows(e.RowIndex).Cells("Credit").ReadOnly = False
                If dgv.Rows(e.RowIndex).Cells("Credit").Value = 0 Then
                    dgv.Rows(e.RowIndex).Cells("Credit").Value = dgv.Rows(e.RowIndex).Cells("Debit").Value
                End If
                dgv.Rows(e.RowIndex).Cells("Debit").Value = 0

            End If
        ElseIf e.ColumnIndex = 2 Or e.ColumnIndex = 3 Then
            If vType.Contains("Cash") Or vType.Contains("Bank") Or vType.Contains("Journal") Then

                Dim accid As Integer = dgv(1, e.RowIndex).Value
                If nz(dbValue("Select BBB from mledger where id = " & accid), False) Then

                    Dim ofrm As New RefEntry
                    ofrm.dtref = dbTable("Select * from trefdata where accid = " & bsd.Current("AccId") & " and dataid = " & bsd.Current("VoucherId") & " and lineid =" & bsd.Current("LineId"))

                    ofrm.accId = accid
                    ofrm.adj_amt = dgv(e.ColumnIndex, e.RowIndex).Value
                    ofrm.dataid = 0
                    ofrm.lineid = dgv.CurrentRow.Index
                    ofrm.ShowDialog()

                End If
            End If

        End If
    End Sub

    Private Sub dgv_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv.DataError

    End Sub

    Private Sub dgv_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgv.RowsAdded
        If nz(dgv.Rows(e.RowIndex).Cells(0).Value, "") = "" Then
            dgv.Rows(e.RowIndex).Cells(0).Value = IIf(vDrCr = "Dr", "Cr", "Dr")
        End If
        If dgv.Rows(e.RowIndex).Cells(0).Value = "Dr" Then
            dgv.Rows(e.RowIndex).Cells("Debit").ReadOnly = False
            dgv.Rows(e.RowIndex).Cells("Credit").ReadOnly = True
        Else
            dgv.Rows(e.RowIndex).Cells("Debit").ReadOnly = True
            dgv.Rows(e.RowIndex).Cells("Credit").ReadOnly = False
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If validate_entry() Then
            If save_entry() Then
                enableControls(False)
                mode = enEntry.View
                navmode = enNavMode.none
            End If
        End If
    End Sub

    Function validate_entry() As Boolean
        If (vType <> "Journal" And vType <> "Challan") Then
            If cmbAccount.SelectedIndex <= 0 Then
                ep.SetError(cmbAccount, "Please select account")
                cmbAccount.Focus()
                Return False
            Else
                ep.SetError(cmbAccount, "")
            End If
            If numNet.value = 0 Then
                MessageBox.Show("Net Total can not be Zero", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgv.Focus()
                Return False
            End If

        Else

            If numNet.value <> 0 Then
                MessageBox.Show("Net Total Should be Zero", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgv.Focus()
                Return False
            End If


        End If

        Return True
    End Function
    Function save_entry() As Boolean
        bsd.EndEdit()
        Dim qry As String = ""
        If mode = enEntry.Add Then
            qry = <string>
             INSERT INTO tDataMain
            (VoucherNo,VoucherPrefix ,VoucherSuffix
            ,Date      ,Amount
            ,Narration           ,ChqNo           ,ChqDate
            ,Bank           ,Branch
            ,AccId           ,Voucher           ,SingleNarration
            ,CoId           ,Type)
            VALUES
            (<%= numVoucherNo.value %>
            ,'<%= lblPrefix.Text %>' 
            ,'<%= lblSuffix.Text %>'
            ,'<%= sqldate(dtpDate.Value) %>'
            ,<%= numNet.value %>
            ,'<%= txtNarration.Text %>'
            ,'<%= txtchq.Text %>'
            ,'<%= sqldate(dtpchq.Value) %>'
            ,'<%= txtBank.Text %>'
            ,'<%= txtBranch.Text %>'
            ,<%= cmbAccount.SelectedValue %>
            ,'<%= vType %>'
            ,<%= IIf(chkNarration.Checked, 1, 0) %> 
            ,<%= gCoId %>
            ,'<%= vDrCr %>' )
            </string>
            Dim id As Integer = nz(dbValue(qry & ";Select SCOPE_IDENTITY()"), 0)
            If id > 0 Then
                bsd.MoveFirst()
                Dim AQRY(bsd.Count - 1) As String
                While bsd.Position <= bsd.Count - 1
                    qry = <string>
                          INSERT INTO [tdataDetails]
                        ([VoucherId]
                        ,[LineId]
                        ,[AccId]
                        ,[Amount]
                        ,[Narration]
                        ,[Date]
                        ,[ChqNo]
                        ,[ChqDate]
                        ,[Bank]
                        ,[Branch]
                        ,[CoId]
                        ,[Type]) values (
                        <%= id %>,<%= bsd.Position + 1 %>,<%= bsd.Current("AccId") %>,
                        <%= bsd.Current("Debit") + bsd.Current("Credit") %>,
                        '<%= bsd.Current("Narration") %>','<%= sqldate(bsd.Current("Date")) %>',
                        '<%= bsd.Current("ChqNo") %>', '<%= sqldate(bsd.Current("ChqDate")) %>',
                        '<%= bsd.Current("Bank") %>','<%= bsd.Current("Branch") %>',
                         <%= bsd.Current("CoId") %>,'<%= bsd.Current("Type") %>')
                         </string>
                    AQRY(bsd.Position) = qry
                    If bsd.Position = bsd.Count - 1 Then
                        Exit While
                    Else
                        bsd.MoveNext()
                    End If

                End While
                If Not dbUpdate(AQRY) Then
                    dbUpdate(New String() {"DELETE tDataMain where id = " & id})
                    Return False
                Else
                    If vType.Contains("Sale") Or vType.Contains("Purchase") Or vType.Contains("Note") Then
                        qry = "Insert into trefdata (dataid,lineid,accid,Refno,Amount,Type,RefDate,RefType,Period,coid) values (" & _
                       id & ",0," & cmbAccount.SelectedValue & "," & _
                       "'" & lblPrefix.Text & numVoucherNo.value & lblSuffix.Text & "," & _
                       numNet.value & ",'" & lblDrCr.Text & "'," & _
                       "'" & sqldate(dtpDate.Value) & "'," & _
                       "'New','" & gPeriod & "'," & gCoId & ")"
                        dbUpdate(New String() {qry})
                    End If

                    Return True
                End If

            Else
                Return False
            End If


        ElseIf mode = enEntry.Edit Then
            qry = <string>
             update tDataMain set
                VoucherNo= <%= numVoucherNo.value %>
                ,VoucherPrefix='<%= lblPrefix.Text %>' 
                ,VoucherSuffix='<%= lblSuffix.Text %>'
            ,Date  = '<%= sqldate(dtpDate.Value) %>'   ,Amount=<%= numNet.value %>
            ,Narration  ='<%= txtNarration.Text %>'         ,ChqNo   ='<%= txtchq.Text %>'        ,ChqDate='<%= sqldate(dtpchq.Value) %>'
            ,Bank =  '<%= txtBank.Text %>'        ,Branch='<%= txtBranch.Text %>'
            ,AccId  =  <%= cmbAccount.SelectedValue %>       ,Voucher  = '<%= vType %>'        ,SingleNarration=<%= IIf(chkNarration.Checked, 1, 0) %> 
            ,CoId =  <%= gCoId %>        ,Type='<%= vDrCr %>'
           where id = <%= txtId.Text %>
                  </string>
            Dim AQRY As New List(Of String)
            AQRY.Add(qry)
            AQRY.Add("Delete tdataDetails where voucherid = " & txtId.Text)
            bsd.MoveFirst()
            While bsd.Position <= bsd.Count - 1
                qry = <string>
                          INSERT INTO [tdataDetails]
                        ([VoucherId]
                        ,[LineId]
                        ,[AccId]
                        ,[Amount]
                        ,[Narration]
                        ,[Date]
                        ,[ChqNo]
                        ,[ChqDate]
                        ,[Bank]
                        ,[Branch]
                        ,[CoId]
                        ,[Type]) values (
                        <%= txtId.Text %>,<%= bsd.Position + 1 %>,<%= bsd.Current("AccId") %>,
                        <%= bsd.Current("Debit") + bsd.Current("Credit") %>,
                        '<%= bsd.Current("Narration") %>','<%= sqldate(bsd.Current("Date")) %>',
                        '<%= bsd.Current("ChqNo") %>', '<%= sqldate(bsd.Current("ChqDate")) %>',
                        '<%= bsd.Current("Bank") %>','<%= bsd.Current("Branch") %>',
                         <%= bsd.Current("CoId") %>,'<%= bsd.Current("Type") %>')
                         </string>
                AQRY.Add(qry)
                If bsd.Position = bsd.Count - 1 Then
                    Exit While
                Else
                    bsd.MoveNext()
                End If

            End While
            If dbUpdate(AQRY.ToArray) Then
                If vType.Contains("Sale") Or vType.Contains("Purchase") Or vType.Contains("Note") Then
                    qry = _
                    <string>
                        Update trefdata set 
                        accid = <%= cmbAccount.SelectedValue %>,
                        Refno = <%= lblPrefix.Text & numVoucherNo.value & lblSuffix.Text %>',
                        Amount=<%= numNet.value %>,
                        Type = <%= lblDrCr.Text %>' ,
                        RefDate = '<%= sqldate(dtpDate.Value) %>',
                        RefType 'New',
                        Period = '<%= gPeriod %>')
                        Where dataid =<%= txtId.Text %> and lineid = 0 and coid = <%= gCoId %>


                    </string>

                    dbUpdate(New String() {qry})
                End If
                Return True

            Else
                Return False
            End If


        ElseIf mode = enEntry.Delete Then
            qry = <string> delete tdatadetail where voucherid =  <%= txtId.Text %></string>
            qry = <string> delete tdatamain where id = <%= txtId.Text %></string>

        End If

        Return True
    End Function

    Private Sub dgv_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.RowValidated
        Dim debit As Double, credit As Double
        For Each row As DataGridViewRow In dgv.Rows
            debit += nz(row.Cells("Debit").Value, 0)
            credit += nz(row.Cells("Credit").Value, 0)
        Next
        numDebit.value = debit
        numCredit.value = credit
        numNet.value = Math.Abs(debit - credit)
        lblDrCr.Text = IIf(debit - credit >= 0, "Dr", "Cr")


    End Sub

    Private Sub tsbNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbNew.Click
        mode = enEntry.Add
        bs.AddNew()
        Nav_Data()
    End Sub

    Private Sub tsbEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEdit.Click
        mode = enEntry.Edit
        Nav_Data()
    End Sub




    Private Sub chkNarration_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles chkNarration.MouseClick
        If chkNarration.CheckState = CheckState.Checked Then
            bsd.EndEdit()
            For Each row As DataGridViewRow In dgv.Rows
                If (row.Cells("Narration").Value & row.Cells("ChqNO").Value & row.Cells("Branch").Value).ToString.Trim <> "" Then
                    chkNarration.CheckState = CheckState.Unchecked
                    Exit Sub
                End If
            Next
        Else
            If (txtBank.Text & txtchq.Text & txtBranch.Text & txtNarration.Text).Trim <> "" Then
                chkNarration.CheckState = CheckState.Checked

            End If
        End If
    End Sub
End Class
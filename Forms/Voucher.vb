Public Class Voucher
    ' Dim defadrcr As String = "Dr"
    Dim vPrefix As String
    Dim vSuffix As String
    Dim vName As String
    Dim vType As String
    Dim vDrCr As String
    Dim isAuto As Boolean
    Dim numStart As Integer
    Dim dtref As DataTable

    Dim rowid As Integer
    Dim navmode As enNavMode
    Dim mode As enEntry
    Dim groupfilter As String
    Dim isLoading As Boolean
    Dim isFromDgv As Boolean
    Dim id As Integer
    Dim arefqstr As New List(Of String)
    Dim reflist As New ArrayList
    Dim rowremoved As Boolean = True

#Region "form_methods"
    Public Sub New(ByVal VoucherPrefix As String, ByVal VoucherName As String, ByVal VoucherType As String)
        isLoading = True
        InitializeComponent()
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
            'groupfilter = " ( groupid = " & enLedger.Debtors & " or groupid = " & enLedger.Creditors & ") "
            groupfilter = " " & enLedger.Debtors & "," & enLedger.Creditors & ""
        ElseIf vType.Contains("Debit") Then
            vDrCr = "Dr"
            ' groupfilter = " ( groupid =  " & enLedger.Debtors & " or groupid = " & enLedger.Creditors & ") "
            groupfilter = " " & enLedger.Debtors & "," & enLedger.Creditors & ""
        ElseIf vType.Contains("Payment") Then
            vDrCr = "Dr"
            If vType.Contains("Cash") Then
                groupfilter = enLedger.Cash
            Else
                groupfilter = enLedger.Bank
            End If


            ' groupfilter = " ( groupid = " & enLedger.Cash & ") "

        ElseIf vType.Contains("Receipt") Then
            vDrCr = "Cr"
            'groupfilter = " ( groupid = " & enLedger.Bank & ") "
            If vType.Contains("Cash") Then
                groupfilter = enLedger.Cash
            Else
                groupfilter = enLedger.Bank
            End If

        ElseIf vType.Contains("Sale") Then
            vDrCr = "Cr"
            ' groupfilter = " ( groupid = " & enLedger.Debtors & ") "
            groupfilter = enLedger.Debtors & "," & enLedger.Creditors

        ElseIf vType.Contains("Purchase") Then
            vDrCr = "Dr"
            'groupfilter = " ( groupid = " & enLedger.Creditors & ") "
            groupfilter = enLedger.Debtors & "," & enLedger.Creditors

        Else
            vDrCr = "Dr"
            groupfilter = "1=1"
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        rowremoved = False
        Me.Text = "Entry of " & vName & " (" & vType & ") "
        dgv.EditMode = DataGridViewEditMode.EditOnEnter
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.AllowUserToOrderColumns = False
        dgv.AllowUserToResizeRows = False
        With dgv.Columns("Debit").HeaderCell.Style
            .ForeColor = Color.Red
            .Font = New Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Pixel)
            ' Dim fnt = New Font("Arial", FontStyle.Bold)
            ' .Font = fnt
        End With
        With dgv.Columns("Credit").HeaderCell.Style
            .ForeColor = Color.Blue

            .Font = New Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Pixel)
        End With
        numDebit.ReadOnly = False
        numCredit.ReadOnly = False
        Dim al As New ArrayList
        al.Add(New String() {"Account", "lb"})

        dgv.attachlist = al

        For i = dgv.RowCount To 100
            dgv.Rows.Add()
            dgv.Rows(i).Cells("Sr").Value = i + 1
            dgv.Rows(i).Cells("DC").Value = vDrCr
            dgv.Rows(i).Cells("Debit").Value = 0
            dgv.Rows(i).Cells("Credit").Value = 0
        Next
        dgv.RefreshEdit()
        dgv.Refresh()
        mode = enEntry.Add
        numVoucherNo.value = Math.Max(nz(dbValue("select max(voucherNo) from tdatamain where coid=" & gCoId & " and date>= '" & sqldate(gFinStartDate) & "' and date<='" & sqldate(gFinEndDate) & "' and voucher = '" & vName & "'"), 0) + 1, numStart)
        lblVoucher.Text = vPrefix & " / " & numVoucherNo.value & " / " & vSuffix
        narration_option()
        If vType.Contains("Journal") Or vType.Contains("Challan") Then
            txtAccount.Visible = False
            lblAccount.Visible = False
        Else
            txtAccount.Visible = True
            lblAccount.Visible = True
        End If


        rowremoved = True
        isLoading = False
    End Sub
    Sub narration_option()
        If chkNarration.CheckState = CheckState.Checked Then
            pnlNarration.Visible = True
            Me.Height = 520
            Me.Width = 640
            Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
            Me.dgv.Width = 595
            dgv.Columns("Narration").Visible = False
            If vType.Contains("Contra") Or vType.Contains("Bank") Then
                pnlBank.Visible = True
                If vType.Contains("Receipt") Then
                    txtBank.Visible = True
                    txtBranch.Visible = True
                    lblBank.Visible = True
                    lblBranch.Visible = True
                Else
                    lblBank.Visible = False
                    lblBranch.Visible = False
                    txtBank.Visible = False
                    txtBranch.Visible = False

                End If
                dgv.Columns("Chq").Visible = False
                dgv.Columns("ChqDate").Visible = False
                dgv.Columns("Bank").Visible = False
                dgv.Columns("Branch").Visible = False
            Else
                pnlBank.Visible = False
                dgv.Columns("Chq").Visible = False
                dgv.Columns("ChqDate").Visible = False
                dgv.Columns("Bank").Visible = False
                dgv.Columns("Branch").Visible = False
            End If
        Else
            pnlNarration.Visible = False
            pnlBank.Visible = False
            Me.Height = 440
            Me.Width = 960
            Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
            dgv.Width = 920
            dgv.Columns("Narration").Visible = True
            If vName.Contains("Contra") Or vName.Contains("Bank") Then
                dgv.Columns("Chq").Visible = True
                dgv.Columns("ChqDate").Visible = True
                If vName.Contains("Receipt") Then
                    dgv.Columns("Bank").Visible = True
                    dgv.Columns("Branch").Visible = True
                Else
                    dgv.Columns("Bank").Visible = False
                    dgv.Columns("Branch").Visible = False

                End If

                dgv.Columns("Narration").Width = 150
            Else
                dgv.Columns("Chq").Visible = False
                dgv.Columns("ChqDate").Visible = False
                dgv.Columns("Bank").Visible = False
                dgv.Columns("Branch").Visible = False
                dgv.Columns("Narration").Width = 450
            End If
        End If
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

            Dim strgroup As String = groupfilter & ","
            For i = 1 To 5
                qry = "select id from mledgergroup where groupid in (" & strgroup.Substring(0, strgroup.Length - 1) & ")"
                Dim dt As DataTable = dbTable(qry)
                If dt.Rows.Count = 0 Then Exit For
                For Each row As DataRow In dt.Rows
                    If Not strgroup.Contains(row("id")) Then
                        strgroup &= row("Id") & ","
                    End If

                Next
            Next
            qry = "Select a.id,(a.ledger +'~' +b.groupname) as ledger  from mledger a inner join mledgergroup b on b.id = a.groupid where a.groupid in (" & strgroup.Substring(0, strgroup.Length - 1) & ")"




        End If
        lb.DataSource = Nothing
        lb.DataSource = dbTable(qry)
        lb.ValueMember = "id"
        lb.DisplayMember = "Ledger"


    End Sub
#End Region

#Region "dgv"
    Private Sub dgv_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEndEdit

        If ActiveControl.Name <> "btnCancel" Then
            If e.ColumnIndex = dgv.Columns("Account").Index Then
                Dim c As DataGridViewCell = dgv(e.ColumnIndex, e.RowIndex)
                If c.Value = "" Then
                    If lb.Visible Then
                        If lb.SelectedIndex >= 0 Then
                            c.Value = lb.Text
                            c.Tag = lb.SelectedValue
                            lb.Visible = False
                        Else
                            lb.Focus()
                        End If
                    Else
                        c.ErrorText = "Account can not be blank"
                    End If


                Else
                    c.ErrorText = ""
                    If ActiveControl IsNot lb Then


                        If lb.FindString(c.Value) < 0 Then
                            MsgBox("Please Select the Account")
                        Else
                            c.Value = lb.Text
                            c.Tag = lb.SelectedValue
                            lb.Visible = False
                        End If

                    End If

                End If

            ElseIf e.ColumnIndex = dgv.ColumnCount - 1 And e.RowIndex = dgv.RowCount - 1 Then
                dgv.CurrentCell.Value = ""
                Dim sr As Integer = dgv.Rows.Add()
                dgv(dgv.Columns("SR").Index, sr).Value = sr + 1
            ElseIf e.ColumnIndex = dgv.Columns("Debit").Index Or e.ColumnIndex = dgv.Columns("Credit").Index Then
                If mode = enEntry.Add And dgv.Rows(e.RowIndex).Cells("Debit").Value - dgv.Rows(e.RowIndex).Cells("Credit").Value = 0 Then
                Else
                    If Not vType.Contains("Challan") Then
                        Dim bbb As Boolean = dbValue("select bbb from mledger where id = " & dgv.CurrentRow.Cells("Account").Tag)
                        If bbb Then
                            Dim ofrm As New Reference2
                            With ofrm
                                .dataid = id
                                .lineid = dgv.CurrentRow.Cells("Sr").Value
                                .refamt = dgv.CurrentRow.Cells("Debit").Value - dgv.CurrentRow.Cells("Credit").Value
                                .refno = numVoucherNo.value
                                .refDate = dtpDate.Value
                                .adjAmt = dgv.CurrentRow.Cells("Debit").Value - dgv.CurrentRow.Cells("Credit").Value
                                .adjType = dgv.CurrentRow.Cells("DC").Value
                                .AccId = dgv.CurrentRow.Cells("Account").Tag
                                .account = dgv.CurrentRow.Cells("Account").Value
                                .voucher = numVoucherNo.value
                                .vdate = dtpDate.Value
                            End With
                            ofrm.ShowDialog()
                            'If (ofrm.DialogResult = Windows.Forms.DialogResult.OK) Or (mode = enEntry.Add) Then
                            '' create query for ref update
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
                                        If reflist(i)(5) = ofrm.lineid Then
                                            reflist.RemoveAt(i)
                                            Exit For
                                        End If
                                    Next
                                End If
                                reflist.Add(astr)


                            Next
                            'End If
                        End If
                    End If
                End If

                    ''----------------
                    'If Not dbUpdate(aqstr.ToArray) Then
                    '    MessageBox.Show("Update failed! Try again")
                    '    Exit Sub
                    'End If

            End If
        End If
        dgv.RefreshEdit()
        dgv.Refresh()
    End Sub

    Private Sub dgv_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEnter
        If Not "ACCOUNT_SR_DC".Contains(dgv.Columns(e.ColumnIndex).Name.ToUpper) Then
            If dgv.Rows(e.RowIndex).Cells("Account").Value & "" = "" Then
                ' If dgv.Rows(e.RowIndex).Cells("Debit").Value + dgv.Rows(e.RowIndex).Cells("Debit").Value = 0 Then
                ' Else
                dgv.Rows(e.RowIndex).Cells("Account").ErrorText = "Account in Detail List not entered"
                'End If

            End If
        End If

        If nz(dgv(dgv.Columns("DC").Index, e.RowIndex).Value, "") = "" Then
            dgv(dgv.Columns("DC").Index, e.RowIndex).Value = vDrCr
            dgv.RefreshEdit()
        End If

        Dim drcr As String = dgv(dgv.Columns("DC").Index, e.RowIndex).Value

        If drcr.ToUpper = "DR" Then
            If nz(dgv.Rows(e.RowIndex).Cells("Debit").Value, 0) = 0 Then
                dgv.Rows(e.RowIndex).Cells("Debit").Value = nz(dgv.Rows(e.RowIndex).Cells("Credit").Value, 0)
            End If

            dgv.Rows(e.RowIndex).Cells("Credit").Value = 0
            dgv.Rows(e.RowIndex).Cells("Credit").ReadOnly = True
            dgv.Rows(e.RowIndex).Cells("Debit").ReadOnly = False
        Else
            If nz(dgv.Rows(e.RowIndex).Cells("Credit").Value, 0) = 0 Then
                dgv.Rows(e.RowIndex).Cells("Credit").Value = nz(dgv.Rows(e.RowIndex).Cells("Debit").Value, 0)
            End If

            dgv.Rows(e.RowIndex).Cells("Debit").Value = 0
            dgv.Rows(e.RowIndex).Cells("Debit").ReadOnly = True
            dgv.Rows(e.RowIndex).Cells("Credit").ReadOnly = False
        End If

        dgv.RefreshEdit()



        'ElseIf e.ColumnIndex = dgv.ColumnCount - 1 And e.RowIndex = dgv.RowCount - 1 Then





        '    SendKeys.SendWait(" ")

        '    SendKeys.SendWait("{ENTER}")
        If e.ColumnIndex = dgv.Columns("SR").Index Then
            If dgv.Rows(e.RowIndex).Cells("SR").Value Is Nothing Then
                dgv.Rows(e.RowIndex).Cells("SR").Value = e.RowIndex + 1
            End If
        End If

    End Sub



    Private Sub dgv_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellValidated
        If e.ColumnIndex = dgv.Columns("Debit").Index Or e.ColumnIndex = dgv.Columns("Credit").Index Then
            dgv.CurrentCell.ValueType = GetType(System.Decimal)
            dgv.CurrentCell.Value = CDec("0" & dgv.CurrentCell.Value)
            Calc()
        End If

    End Sub
    Private Sub Calc()
        Dim debit As Decimal = 0, credit As Decimal = 0, net As Decimal = 0
        For Each row As DataGridViewRow In dgv.Rows
            ' If row.Cells("Debit").Value + row.Cells("Credit").Value = 0 And String.IsNullOrEmpty(row.Cells("Account").Value) Then
            '   Else

            If row.Index + 1 <> row.Cells("Sr").Value Then
                dbupdate(New String() {"Update trefdata set dataid = " & id & ", lineid = " & row.Index + 1 & " where dataid = " & id & " and lineid = " & row.Cells("Sr").Value})
                row.Cells("Sr").Value = row.Index + 1
            End If

            debit += row.Cells("Debit").FormattedValue
            credit += row.Cells("Credit").FormattedValue
            '  End If

        Next
        net = debit - credit
        numDebit.value = debit
        numCredit.value = credit
        numNet.value = Math.Abs(net)
        '' shailesh 22/05/2012 11:39am - reversed effect
        ''lbldrcr.Text = IIf(net > 0, "Dr", "Cr")
        lbldrcr.Text = IIf(net > 0, "Cr", "Dr")
        ''---
        numNet.ForeColor = IIf(net > 0, Color.Red, Color.Blue)
    End Sub
    Private Sub dgv_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgv.CellValidating
        If e.ColumnIndex = dgv.Columns("Account").Index Then
            If lb.Visible = False Then
                If dgv.CurrentCell.Value = "" Then
                    dgv.CurrentCell.ErrorText = "Please enter the account in detail list"
                    e.Cancel = True
                    Exit Sub
                End If
            Else
                'If lb.SelectedIndex < 0 Then
                '    e.Cancel = True
                'Else
                '    If dgv.CurrentCell.Value <> lb.Text Then
                '        dgv.CurrentCell.Value = lb.Text
                '        dgv.CurrentCell.Tag = lb.SelectedValue
                '        dgv.RefreshEdit()

                '    End If
                'lb.Focus()
            End If




            'If lb.SelectedIndex < 0 Then
            '    e.Cancel = True
            'Else
            '    If dgv.CurrentCell.Value <> lb.Text Then
            '        dgv.CurrentCell.Value = lb.Text
            '        dgv.CurrentCell.Tag = lb.SelectedValue
            '        dgv.RefreshEdit()

            '    End If
            'End If


        ElseIf e.ColumnIndex = dgv.Columns("DC").Index Then
            Dim drcr = nz(e.FormattedValue, "").ToString.Trim.ToUpper
            If drcr <> "DR" And drcr <> "CR" Then
                '  dgv.CurrentCell.Value = defadrcr
                drcr = vDrCr
            End If

            dgv.CurrentCell.Value = StrConv(drcr.ToString.Trim, VbStrConv.ProperCase)
            If drcr = "DR" Then
                If nz(dgv.Rows(e.RowIndex).Cells("Debit").Value, 0) = 0 Then
                    dgv.Rows(e.RowIndex).Cells("Debit").Value = nz(dgv.Rows(e.RowIndex).Cells("Credit").Value, 0)
                End If

                dgv.Rows(e.RowIndex).Cells("Credit").Value = 0
                dgv.Rows(e.RowIndex).Cells("Credit").ReadOnly = True
                dgv.Rows(e.RowIndex).Cells("Debit").ReadOnly = False
            Else
                If nz(dgv.Rows(e.RowIndex).Cells("Credit").Value, 0) = 0 Then
                    dgv.Rows(e.RowIndex).Cells("Credit").Value = nz(dgv.Rows(e.RowIndex).Cells("Debit").Value, 0)
                End If

                dgv.Rows(e.RowIndex).Cells("Debit").Value = 0
                dgv.Rows(e.RowIndex).Cells("Debit").ReadOnly = True
                dgv.Rows(e.RowIndex).Cells("Credit").ReadOnly = False
            End If

            dgv.RefreshEdit()




        End If

    End Sub

    Private Sub dgv_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgv.EditingControlShowing
        If dgv.CurrentCell.ColumnIndex = dgv.Columns("Account").Index Then

            Dim tb As TextBox = dgv.EditingControl
            AddHandler tb.TextChanged, AddressOf getaccount
            '  AddHandler tb.KeyDown, AddressOf accountkeydown
            lb.DataSource = Nothing
            lb.DataSource = dbTable("Select id,ledger from mledger order by ledger")
            lb.ValueMember = "id"
            lb.DisplayMember = "Ledger"
            lb.Visible = True
            If dgv.CurrentCell.Value IsNot Nothing Then
                lb.SelectedIndex = lb.FindStringExact(dgv.CurrentCell.Value)
            End If
        ElseIf dgv.CurrentCell.ColumnIndex = dgv.Columns("DC").Index Then
            Dim tb As TextBox = dgv.EditingControl
            tb.AutoCompleteCustomSource.Add("Dr")
            tb.AutoCompleteCustomSource.Add("Cr")
            tb.AutoCompleteCustomSource.Add(" Dr")
            tb.AutoCompleteCustomSource.Add(" Cr")
            tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            tb.AutoCompleteSource = AutoCompleteSource.CustomSource



        Else
            CType(dgv.EditingControl, TextBox).AutoCompleteCustomSource.Clear()
        End If
    End Sub



#End Region

#Region "ListBox"
    Private Sub lb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lb.Click
        If isFromDgv Then
            dgv.Rows(dgv.CurrentCell.RowIndex).Cells("Account").Value = lb.Text
            dgv.Rows(dgv.CurrentCell.RowIndex).Cells("Account").Tag = lb.SelectedValue
            dgv.Focus()
        Else
            txtAccount.Text = lb.Text
            txtAccount.Tag = lb.SelectedValue
            txtAccount.Focus()
        End If

        lb.Hide()
    End Sub

    Private Sub lb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lb.KeyDown
        If e.KeyCode = Keys.Enter Then
            lb_Click(sender, e)

        End If
    End Sub
#End Region

    Private Sub txtAccount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccount.KeyDown
        If e.KeyCode = Keys.Down Then
            lb.Focus()
        ElseIf e.KeyCode = Keys.Enter Then
            If lb.SelectedIndex < 0 Then
                MsgBox("Please, select proper account")
            Else
                txtAccount.Text = lb.Text
                txtAccount.Tag = lb.SelectedValue
                lb.Visible = False


                dgv.Focus()
                If dgv.CurrentCell.ColumnIndex = dgv.Columns("Account").Index Then
                    If nz(dgv.CurrentCell.Value, "") <> "" Then
                        dgv.CurrentCell = dgv(dgv.Columns("DC").Index, 0)
                    End If
                Else
                    dgv.CurrentCell = dgv(dgv.Columns("DC").Index, 0)
                End If





            End If
        End If
    End Sub


    Private Sub getaccount(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccount.TextChanged
        If CType(sender, Control).Name = "txtAccount" Then

            isFromDgv = False
        ElseIf sender.GetType.Name = "DataGridViewTextBoxEditingControl" Then

            isFromDgv = True
        End If

        lb.SelectedIndex = lb.FindString(DirectCast(sender, TextBox).Text)
        lb.SelectionMode = SelectionMode.One
        lb.TopIndex = lb.SelectedIndex

    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Fill_Blank()


    End Sub

    Private Function Validate_Form() As Boolean
        If dtpDate.Value.Date > gFinEndDate Then
            MsgBox("Date can not be greater than " & gFinEndDate)
            dtpDate.Focus()
            Return False
        ElseIf dtpDate.Value.Date < gFinStartDate Then
            MsgBox("Date can not be lower than " & gFinStartDate)
            dtpDate.Focus()
            Return False
        End If
        If txtAccount.Visible Then
            If String.IsNullOrEmpty(txtAccount.Text) Then
                MsgBox("Please select account")
                txtAccount.Focus()
                Return False
            End If
        Else
            If numNet.value <> 0 Then
                MsgBox("Debit / Credit Not Tally")
                dgv.Focus()
                Return False
            End If
        End If
        If dgv.RowCount = 0 Then
            MsgBox("Incomplete voucher")
            dgv.Focus()
            Exit Function
        End If
        If dgv.RowCount = 1 And String.IsNullOrEmpty(dgv.Rows(0).Cells("Account").Value) Then
            MsgBox("Incomplete voucher")
            dgv.Focus()
            Exit Function
        End If

        For Each row As DataGridViewRow In dgv.Rows
            If String.IsNullOrEmpty(row.Cells("DC").Value) Then
                MsgBox("Please select Type")
                dgv.CurrentCell = row.Cells("DC")
                dgv.Focus()
                Return False
            End If
            If String.IsNullOrEmpty(row.Cells("Account").Value) Then
                If row.Cells("Debit").Value + row.Cells("Credit").Value = 0 Then
                    dgv.Rows.Remove(row)
                Else
                    MsgBox("Please select account")
                    dgv.CurrentCell = row.Cells("Account")
                    dgv.Focus()
                    Return False
                End If
              
            End If

        Next
        If vDrCr.Contains("Receipt") And lbldrcr.Text <> "Dr" Then
            MsgBox("Negative Receipt")
            Return False
        ElseIf vDrCr.Contains("Payment") And lbldrcr.Text <> "Cr" Then
            MsgBox("Negative Payment")
            Return False
        End If
        Return True
    End Function
    Private Sub txtAccount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAccount.GotFocus
        isFromDgv = False
        Fill_Combo()
        lb.Visible = True
        If txtAccount.Text <> String.Empty Then
            lb.SelectedIndex = lb.FindString(txtAccount.Text)
        End If

    End Sub


    Private Sub txtAccount_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAccount.Validating
        ' lb.SelectedIndex = lb.FindStringExact(txtAccount.Text)
        If lb.SelectedIndex < 0 Then
            e.Cancel = True
            MsgBox("Please, enter valid account")
        Else

            txtAccount.Text = lb.Text
            txtAccount.Tag = lb.SelectedValue
            If Not ActiveControl Is lb Then
                lb.Visible = False
            End If

        End If
    End Sub

    Private Sub txtchq_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtchq.KeyDown
        If e.KeyCode = Keys.Enter Then dtpchq.Focus()

    End Sub
    Private Sub dtpchq_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpchq.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtBank.Focus()
        End If
    End Sub

    Private Sub txtNarration_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNarration.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    'dgv.Focus()
        '    'If dgv.CurrentCell.ColumnIndex = dgv.Columns("Account").Index Then
        '    '    If nz(dgv.CurrentCell.Value, "") <> "" Then
        '    '        dgv.CurrentCell = dgv(dgv.Columns("DC").Index, 0)
        '    '    End If
        '    'Else
        '    '    dgv.CurrentCell = dgv(dgv.Columns("DC").Index, 0)
        '    'End If
        '    btnSave.Focus()
        'End If
    End Sub

    Private Sub txtBranch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBranch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If pnlNarration.Visible Then
                txtNarration.Focus()
            Else
                dgv.Focus()
                If dgv.CurrentCell.ColumnIndex = dgv.Columns("Account").Index Then
                    If nz(dgv.CurrentCell.Value, "") <> "" Then
                        dgv.CurrentCell = dgv(dgv.Columns("DC").Index, 0)
                    End If
                Else
                    dgv.CurrentCell = dgv(dgv.Columns("DC").Index, 0)
                End If

            End If

        End If
    End Sub


    Private Sub dtpchq_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpchq.ValueChanged
        txtBank.Focus()
    End Sub

    Private Sub dtpDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            'If dtpDate.Value > gFinEndDate Or dtpDate.Value < gFinStartDate Then
            '    MsgBox("Date is out of range")
            '    e.Handled = True
            '    Exit Sub
            'End If
            chkNarration.Focus()
        End If
    End Sub

    Private Sub dtpDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpDate.Validating
        If ActiveControl IsNot btnCancel Then
            If dtpDate.Value.Date > gFinEndDate Or dtpDate.Value.Date < gFinStartDate Then
                MsgBox("Date must be between " & gFinStartDate & " and " & gFinEndDate)
                e.Cancel = True
                Exit Sub
            End If
        End If

    End Sub

    Private Sub dtpDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDate.ValueChanged
        'If dtpDate.Value > gFinEndDate Or dtpDate.Value < gFinStartDate Then
        '    MsgBox("Date is out of range")
        '    dtpDate.Focus()
        '    Exit Sub
        'End If
        'chkNarration.Focus()
    End Sub

    Private Sub chkNarration_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNarration.CheckStateChanged
        If Not isLoading Then
            narration_option()
        End If

    End Sub

    Private Sub chkNarration_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkNarration.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAccount.Focus()
            'ElseIf e.KeyCode = Keys.Space Then
            '    txtAccount.Focus()
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtBank_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBank.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtBranch.Focus()
        End If
    End Sub

    Private Sub dgv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv.KeyDown
        If e.KeyCode = Keys.Delete Then
            If dgv.Rows.Count > 1 Then
                If Not dgv.CurrentCell.IsInEditMode Then
                    If MsgBox("Are you sure?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        dgv.Rows.Remove(dgv.CurrentRow)
                        Calc()
                    End If

                End If
            Else
                MsgBox("You can not delete all rows.")
            End If

        End If
    End Sub

    Private Sub dgv_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv.LostFocus
        'If pnlBank.Visible Then
        '    txtchq.Focus()
        'ElseIf pnlNarration.Visible = True Then
        '    txtNarration.Focus()
        'End If
    End Sub

    Private Sub dgv_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.RowEnter
        If dgv(dgv.Columns("DC").Index, e.RowIndex).Value = "Dr" Then
            dgv.Rows(e.RowIndex).Cells("Credit").ReadOnly = True
            dgv.Rows(e.RowIndex).Cells("Debit").ReadOnly = False
        Else
            dgv.Rows(e.RowIndex).Cells("Debit").ReadOnly = True
            dgv.Rows(e.RowIndex).Cells("Credit").ReadOnly = False

        End If
    End Sub

    Private Sub dgv_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgv.RowsAdded
        'If e.RowIndex >= 0 Then
        '    If dgv.Rows(e.RowIndex).Cells("DC").Value = "Dr" Then
        '        dgv.Rows(e.RowIndex).Cells("Credit").ReadOnly = True
        '    Else
        '        dgv.Rows(e.RowIndex).Cells("Debit").ReadOnly = True
        '    End If
        '    numDebit.value += nz(dgv.Rows(e.RowIndex).Cells("Debit").Value, 0)
        '    numCredit.value += nz(dgv.Rows(e.RowIndex).Cells("Credit").Value, 0)
        '    numNet.value = numDebit.value - numCredit.value

        'End If
    End Sub

    Private Sub dgv_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgv.RowsRemoved
        If rowremoved Then
            Calc()
        End If

    End Sub

    Private Sub numVoucherNo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles numVoucherNo.Validating
        If Not ActiveControl Is btnCancel Then
            id = nz(dbValue("Select id from tdatamain where voucherno = " & numVoucherNo.value & " and coid=" & gCoId & " and date>= '" & sqldate(gFinStartDate) & "' and date<='" & sqldate(gFinEndDate) & "' and voucher = '" & vName & "'"), 0)
            If id <> 0 Then
                mode = enEntry.Edit
                'btnDelete.Visible = True
                btnDelete.Text = "Delet&e"
                Dim dt As DataTable = dbTable("Select a.*,b.ledger from tdatamain a left join mledger b on  b.id=a.accid where a.id = " & id)
                If dt.Rows.Count > 0 Then
                    Dim dt1 As DataTable = dbTable("Select a.*,b.ledger from tdatadetails a inner join mledger b on  b.id=a.accid where voucherid=" & id)
                    chkNarration.Checked = dt.Rows(0)("SingleNarration")
                    numNet.value = dt.Rows(0)("Amount")
                    lbldrcr.Text = dt.Rows(0)("type")
                    lblVoucher.Text = vPrefix & " / " & numVoucherNo.value & " / " & vSuffix
                    dtpDate.Value = dt.Rows(0)("Date")
                    txtAccount.Text = dt.Rows(0)("ledger") & ""
                    txtAccount.Tag = "0" & dt.Rows(0)("accid")
                    rowremoved = False

                    Try
                        dgv.Rows.Clear()
                    Catch ex As Exception
                        rowremoved = False
                        For i = 0 To dgv.Rows.Count - 1
                            dgv.Rows.RemoveAt(0)
                        Next
                    End Try
                    rowremoved = True


                    For Each row As DataRow In dt1.Rows
                        dgv.Rows.Add()
                        With dgv.Rows(dgv.RowCount - 1)
                            .Cells("Sr").Value = row("LineId")
                            .Cells("DC").Value = row("Type")
                            .Cells("Account").Value = row("Ledger")
                            .Cells("Account").Tag = row("Accid")
                            .Cells("Debit").Value = IIf(row("type") = "Dr", row("Amount"), 0)
                            .Cells("Credit").Value = IIf(row("type") = "Cr", row("Amount"), 0)
                            .Cells("chqdate").Value = row("chqdate")
                            .Cells("Bank").Value = row("Bank")
                            .Cells("Branch").Value = row("Branch")
                            .Cells("Chq").Value = row("ChqNo")
                        End With
                    Next
                    narration_option()
                End If
            Else
                '                btnDelete.Visible = False
                btnDelete.Text = "Clos&e"
                mode = enEntry.Add
            End If
        End If
        For i = dgv.RowCount To 100
            dgv.Rows.Add()
            dgv.Rows(i).Cells("Sr").Value = i + 1
            dgv.Rows(i).Cells("DC").Value = vDrCr
            dgv.Rows(i).Cells("Debit").Value = 0
            dgv.Rows(i).Cells("Credit").Value = 0
        Next
        dgv.RefreshEdit()
        dgv.Refresh()
        reflist.Clear()

        arefqstr.Clear()
        '' shailesh 22/05/2012 11:39am - forgot to update voucher amt
        Calc()
        ''---
    End Sub

    Private Sub dgv_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.RowValidated
        'Dim ofrm As New Reference2
        'With ofrm
        '    .dataid = id
        '    .lineid = dgv.CurrentRow.Cells("Sr").Value
        '    .refamt = dgv.CurrentRow.Cells("Debit").Value - dgv.CurrentRow.Cells("Credit").Value
        '    .refno = numVoucherNo.value
        '    .refDate = dtpDate.Value
        '    .adjAmt = dgv.CurrentRow.Cells("Debit").Value - dgv.CurrentRow.Cells("Credit").Value
        '    .adjType = dgv.CurrentRow.Cells("DC").Value
        '    .AccId = dgv.CurrentRow.Cells("Account").Tag
        '    .account = dgv.CurrentRow.Cells("Account").Value
        '    .voucher = numVoucherNo.value
        '    .vdate = dtpDate.Value
        'End With
        'ofrm.ShowDialog()
        'If ofrm.DialogResult = Windows.Forms.DialogResult.OK Then
        '    '' create query for ref update
        '    Dim refno As String = ""
        '    Dim refdate As Date = Now.Date
        '    Dim refamt As Decimal = 0.0
        '    Dim reftype As String = ""
        '    Dim type As String = ""
        '    Dim qstr As String = ""
        '    Dim period As String = ""
        '    ' Dim aqstr As New List(Of String)

        '    For Each row As DataGridViewRow In ofrm.dgv.Rows
        '        refno = row.Cells("Refno").Value
        '        refdate = row.Cells("RefDate").Value
        '        refamt = row.Cells("RefAmt").Value
        '        type = row.Cells("type").Value
        '        reftype = row.Cells("reftype").Value

        '        period = row.Cells("Period").Value
        '        If dbValue("select count(*) from trefdata where " & _
        '                    "Refno ='" & refno & "' and " & _
        '                    "period ='" & period & "' and " & _
        '                    "Refdate='" & sqldate(refdate) & "' and " & _
        '                    "type='" & reftype & "' and " & _
        '                    "dataid = " & ofrm.dataid & " and " & _
        '                    "lineid = " & ofrm.lineid & "") > 0 Then
        '            qstr = "Update trefdata set " & _
        '                     "Amount = " & refamt & " where " & _
        '                     "Refno ='" & refno & "' and " & _
        '                     "period ='" & period & "' and " & _
        '                    "Refdate='" & sqldate(refdate) & "' and " & _
        '                    "type='" & type & "' and " & _
        '                    "reftype='" & reftype & "' and " & _
        '                    "dataid = " & ofrm.dataid & " and " & _
        '                    "lineid = " & ofrm.lineid & ""
        '            arefqstr.Add(qstr)
        '        Else
        '            qstr = "insert into trefdata (Amount,Refno,Refdate,type,reftype,dataid,lineid,period) " & _
        '                     "values (" & refamt & "," & _
        '                     "'" & refno & "', " & _
        '                    "'" & sqldate(refdate) & "', " & _
        '                    "'" & type & "', " & _
        '                     "'" & reftype & "', " & _
        '                    "" & ofrm.dataid & ", " & _
        '                    "" & ofrm.lineid & "," & _
        '                    "'" & period & "') "
        '            Dim isdup As Boolean
        '            For Each str1 In arefqstr
        '                If str1 = qstr Then
        '                    isdup = True
        '                    Exit For
        '                End If
        '            Next
        '            If Not isdup Then arefqstr.Add(qstr)
        '        End If
        '    Next
        'End If

        ' ''----------------
        ''If Not dbUpdate(aqstr.ToArray) Then
        ''    MessageBox.Show("Update failed! Try again")
        ''    Exit Sub
        ''End If
    End Sub


    Private Sub dgv_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgv.RowValidating





        If e.ColumnIndex <> dgv.ColumnCount - 1 Then

            If nz(dgv.Rows(e.RowIndex).Cells("Account").Value, "") = "" Then
                If dgv.Rows(e.RowIndex).Cells("Debit").Value + dgv.Rows(e.RowIndex).Cells("Credit").Value = 0 Then
                    'dgv.Rows.RemoveAt(e.RowIndex)
                    Exit Sub
                End If
                MsgBox("Account in Detail List not entered")
                dgv.CurrentCell.Selected = True
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Validate_Form() Then
            If Save_Record() Then

                Fill_blank()
            End If

        End If
    End Sub
    Private Sub Fill_Blank()
        mode = enEntry.Add
        numVoucherNo.value = Math.Max(nz(dbValue("select max(voucherNo) from tdatamain where coid=" & gCoId & " and date>= '" & sqldate(gFinStartDate) & "' and date<='" & sqldate(gFinEndDate) & "' and voucher = '" & vName & "'"), 0) + 1, numStart)
        lblVoucher.Text = vPrefix & " / " & numVoucherNo.value & " / " & vSuffix
        rowremoved = False
        dgv.Rows.Clear()
        rowremoved = True
        dtpDate.Value = Now.Date
        dtpchq.Value = Now.Date
        txtAccount.Text = ""
        txtNarration.Text = ""
        txtBank.Text = ""
        txtBranch.Text = ""
        txtchq.Text = ""
        numNet.value = 0
        chkNarration.CheckState = CheckState.Checked
        narration_option()
        btnDelete.Text = "Clos&e"
        For i = dgv.RowCount To 100
            dgv.Rows.Add()
            dgv.Rows(i).Cells("Sr").Value = i + 1
            dgv.Rows(i).Cells("DC").Value = vDrCr
            dgv.Rows(i).Cells("Debit").Value = 0
            dgv.Rows(i).Cells("Credit").Value = 0
        Next
        dgv.RefreshEdit()
        dgv.Refresh()
        numVoucherNo.Focus()
    End Sub
    Private Function Save_Record() As Boolean
        Dim aqstr As New List(Of String)
        Dim qstr As String = ""
        If mode = enEntry.Add Then
            qstr = _
            <string>
            INSERT INTO [tDataMain]
           ([VoucherNo],[VoucherPrefix],[VoucherSuffix]
           ,[Date],[Amount]
           ,[Narration]
           ,[ChqNo],[ChqDate]
           ,[Bank],[Branch]
           ,[AccId],[Voucher]
           ,[SingleNarration]
           ,[CoId],[Type]
           ,[ChallanId],[period]
           ,[createby],[modifyby])
            VALUES   ( 
            <%= numVoucherNo.value %>,'<%= vPrefix %>','<%= vSuffix %>',
            '<%= sqldate(dtpDate.Value) %>',<%= "0" & numNet.value %>,
            '<%= txtNarration.Text & "" %>',
            '<%= txtchq.Text & "" %>','<%= sqldate(dtpchq.Value) & "" %>',
            '<%= txtBank.Text & "" %>','<%= txtBranch.Text & "" %>',
            <%= "0" & txtAccount.Tag %>,'<%= vName & "" %>',
            <%= "0" & chkNarration.CheckState %>,
            <%= gCoId %>,'<%= lbldrcr.Text & "" %>',
            0,'<%= gPeriod %>',
            '<%= gUserName %>','<%= gUserName %>');Select SCOPE_IDENTITY(); 
            </string>

            '     Dim id As Integer = nz(dbValue("Select * from tdatamain where voucherno = " & numVoucherNo.value & " and voucher = '" & vName & "' and coid = " & gCoId & " and period = '" & gPeriod & "'"), 0)
            id = nz(dbValue(qstr), 0)

            If id > 0 Then
                aqstr.Clear()
                aqstr.Add("Delete from tdataDetails where voucherid= " & id)
                For Each row As DataGridViewRow In dgv.Rows
                    If "" & row.Cells("Account").Value = "" And "0" & row.Cells("Debit").Value = 0 And "0" & row.Cells("Credit").Value = 0 Then
                    Else
                        If row.Cells("Account").Tag Is Nothing Then
                            row.Cells("Account").Tag = dbValue("select id from mledger where ledger = '" & row.Cells("Account").Value & "'")
                        End If


                        qstr = <string>
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
                        <%= id %>,<%= "0" & row.Cells("SR").Value %>,<%= row.Cells("Account").Tag & "" %>,
                        <%= Val("0" & row.Cells("Debit").Value) + Val(row.Cells("Credit").Value) %>,
                        '<%= row.Cells("Narration").Value & "" %>','<%= sqldate(dtpDate.Value) %>',
                        '<%= row.Cells("Chq").Value & "" %>', '<%= sqldate(row.Cells("ChqDate").Value) %>',
                        '<%= row.Cells("Bank").Value & "" %>','<%= row.Cells("Branch").Value & "" %>',
                         <%= gCoId %>,'<%= row.Cells("DC").Value & "" %>')
                         </string>
                        aqstr.Add(qstr)
                    End If
                Next
                If dbupdate(aqstr.ToArray) Then
                    If save_ref() Then
                        Return True
                    Else
                        MsgBox("Outstanding data not updated; try again")

                    End If
                    Return True
                Else
                    MsgBox("Record not added; Please try again")
                    dbupdate(New String() {"Delete from tdatamain where id = " & id})
                    Return False
                End If
            End If
        ElseIf mode = enEntry.Edit Then
            qstr = <string>
             update tDataMain set
                VoucherNo= <%= "0" & numVoucherNo.value %>
                ,VoucherPrefix='<%= vPrefix %>' 
                ,VoucherSuffix='<%= vSuffix %>'
            ,Date  = '<%= sqldate(dtpDate.Value) %>'   ,Amount=<%= "0" & numNet.value %>
            ,Narration  ='<%= txtNarration.Text & "" %>'         ,ChqNo   ='<%= txtchq.Text & "" %>'        ,ChqDate='<%= sqldate(dtpchq.Value) %>'
            ,Bank =  '<%= txtBank.Text & "" %>'        ,Branch='<%= txtBranch.Text & "" %>'
            ,AccId  =  <%= "0" & txtAccount.Tag %>       ,Voucher  = '<%= vName %>'        ,SingleNarration=<%= Val("0" & chkNarration.CheckState) %> 
            ,CoId =  <%= gCoId %>        ,Type='<%= lbldrcr.Text & "" %>', period = '<%= gPeriod %>',modifyby='<%= gUserName %>' 
           where id = <%= id %>
                   </string>
            If dbupdate(qstr) Then
                aqstr.Clear()
                aqstr.Add("Delete from tdataDetails where voucherid= " & id)
                For Each row As DataGridViewRow In dgv.Rows
                    If row.Cells("Debit").Value + row.Cells("Credit").Value = 0 And String.IsNullOrEmpty(row.Cells("Account").Value) Then
                    Else


                        qstr = <string>
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
                        <%= id %>,<%= "0" & row.Cells("SR").Value %>,<%= row.Cells("Account").Tag & "" %>,
                        <%= Val("0" & row.Cells("Debit").Value) + Val(row.Cells("Credit").Value) %>,
                        '<%= row.Cells("Narration").Value & "" %>','<%= sqldate(dtpDate.Value) %>',
                        '<%= row.Cells("Chq").Value & "" %>', '<%= sqldate(row.Cells("ChqDate").Value) %>',
                        '<%= row.Cells("Bank").Value & "" %>','<%= row.Cells("Branch").Value & "" %>',
                         <%= gCoId %>,'<%= row.Cells("DC").Value & "" %>')
                         </string>
                        aqstr.Add(qstr)
                    End If
                Next
                dbupdate(aqstr.ToArray)

                If save_ref() Then
                    Return True
                Else
                    MsgBox("Outstanding data not updated; try again")

                End If
                Return True
            End If

        End If

    End Function
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
        dbupdate("Delete from trefdata where dataid = " & id)
        For i = 0 To reflist.Count - 1
            refno = reflist(i)(0)
            refdate = reflist(i)(1)
            refamt = reflist(i)(2)
            type = reflist(i)(3)
            reftype = reflist(i)(4)
            lineid = reflist(i)(5)
            accid = reflist(i)(6)
            period = reflist(i)(7)
            '  Dim id As Integer = nz(dbValue("Select * from tdatamain where voucherno = " & numVoucherNo.value & " and voucher = '" & vName & "' and coid = " & gCoId & " and period = '" & gPeriod & "'"), 0)
            'id = nz(dbValue(qstr), 0)

            'If dbValue("select count(*) from trefdata where " & _
            '                                "accid = " & accid & " and " & _
            '                              "Refno ='" & refno & "' and " & _
            '                              "period ='" & period & "' and " & _
            '                              "Refdate='" & sqldate(refdate) & "' and " & _
            '                              "type='" & reftype & "' and " & _
            '                              "dataid = " & id & " and " & _
            '                              "lineid = " & lineid & "") > 0 Then
            '    qstr = "Update trefdata set " & _
            '             "Amount = " & refamt & " where " & _
            '               "accid = " & accid & " and " & _
            '             "Refno ='" & refno & "' and " & _
            '             "period ='" & period & "' and " & _
            '            "Refdate='" & sqldate(refdate) & "' and " & _
            '            "type='" & type & "' and " & _
            '            "reftype='" & reftype & "' and " & _
            '            "dataid = " & id & " and " & _
            '            "lineid = " & lineid & ""
            '    arefqstr.Add(qstr)
            'Else
            qstr = "insert into trefdata (Amount,Refno,Refdate,type,reftype,dataid,lineid,accid,coid,period) " & _
                     "values (" & Math.Abs(refamt) & "," & _
                     "'" & refno & "', " & _
                    "'" & sqldate(refdate) & "', " & _
                    "'" & type & "', " & _
                     "'" & reftype & "', " & _
                    "" & id & ", " & _
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

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "Clos&e" Then
            Me.Close()
            Exit Sub
        End If
        If MsgBox("Are you sure?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim aqstr As New List(Of String)
            Dim qstr As String = ""
            aqstr.Add("delete from trefdata where dataid = " & id)
            aqstr.Add("delete from tdatadetails where voucherid = " & id)
            aqstr.Add("delete from tdatamain where id = " & id)
            If dbupdate(aqstr.ToArray) Then
                Fill_Blank()
            Else
                MsgBox("Not deleted.")
            End If
        End If
    End Sub
End Class
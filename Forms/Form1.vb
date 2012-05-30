Public Class Form1
    Dim defadrcr As String = "Dr"
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
        ElseIf vType.Contains("Cash") Then
            vDrCr = "Dr"
            ' groupfilter = " ( groupid = " & enLedger.Cash & ") "
            groupfilter = enLedger.Cash
        ElseIf vType.Contains("Bank") Then
            vDrCr = "Cr"
            'groupfilter = " ( groupid = " & enLedger.Bank & ") "
            groupfilter = enLedger.Bank
        ElseIf vType.Contains("Sale") Then
            vDrCr = "Cr"
            ' groupfilter = " ( groupid = " & enLedger.Debtors & ") "
            groupfilter = enLedger.Debtors & "," & enLedger.Creditors

        ElseIf vType.Contains("Purchase") Then
            vDrCr = "Dr"
            'groupfilter = " ( groupid = " & enLedger.Creditors & ") "
            groupfilter = enLedger.Debtors & "," & enLedger.Creditors

        Else
            vDrCr = "DC"
            groupfilter = "1=1"
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ''------
        'Dim VoucherPrefix As String = "BR~~True~1"
        'Dim VoucherName As String = "Bank Deposit"
        'Dim VoucherType As String = "Receipt Bank"
        'Dim avtype() As String = VoucherPrefix.Split(New Char() {"~"})
        'vPrefix = avtype(0)
        'vSuffix = avtype(1)
        'isAuto = avtype(2)
        'numStart = avtype(3)
        'vName = VoucherName
        'vType = VoucherType
        'Dim acccmbquery As String = ""
        'If vType.Contains("Credit") Then
        '    vDrCr = "Cr"
        '    'groupfilter = " ( groupid = " & enLedger.Debtors & " or groupid = " & enLedger.Creditors & ") "
        '    groupfilter = " " & enLedger.Debtors & "," & enLedger.Creditors & ""
        'ElseIf vType.Contains("Debit") Then
        '    vDrCr = "Dr"
        '    ' groupfilter = " ( groupid =  " & enLedger.Debtors & " or groupid = " & enLedger.Creditors & ") "
        '    groupfilter = " " & enLedger.Debtors & "," & enLedger.Creditors & ""
        'ElseIf vType.Contains("Cash") Then
        '    vDrCr = "Dr"
        '    ' groupfilter = " ( groupid = " & enLedger.Cash & ") "
        '    groupfilter = enLedger.Cash
        'ElseIf vType.Contains("Bank") Then
        '    vDrCr = "Cr"
        '    'groupfilter = " ( groupid = " & enLedger.Bank & ") "
        '    groupfilter = enLedger.Bank
        'ElseIf vType.Contains("Sale") Then
        '    vDrCr = "Cr"
        '    ' groupfilter = " ( groupid = " & enLedger.Debtors & ") "
        '    groupfilter = enLedger.Debtors & "," & enLedger.Creditors

        'ElseIf vType.Contains("Purchase") Then
        '    vDrCr = "Dr"
        '    'groupfilter = " ( groupid = " & enLedger.Creditors & ") "
        '    groupfilter = enLedger.Debtors & "," & enLedger.Creditors

        'Else
        '    vDrCr = "DC"
        '    groupfilter = "1=1"
        'End If
        ''-------



        dgv.AllowUserToAddRows = False
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

        If dgv.RowCount = 0 Then
            dgv.Rows.Add()
            dgv.Rows(0).Cells("Sr").Value = 1
            dgv.RefreshEdit()
            dgv.Refresh()
        End If
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
            If vName.Contains("Contra") Or vName.Contains("Bank") Then
                pnlBank.Visible = True
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
                dgv.Columns("Bank").Visible = True
                dgv.Columns("Branch").Visible = True
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
                    MsgBox("Account can not be blank")

                Else
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


            End If
        End If
        dgv.RefreshEdit()
        dgv.Refresh()
    End Sub

    Private Sub dgv_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEnter
        If e.ColumnIndex = dgv.ColumnCount - 1 Then
            If nz(dgv.Rows(e.RowIndex).Cells("Account").Value, "") = "" Then
                MsgBox("Account not entered")
            End If
        End If
        '  If e.ColumnIndex = dgv.Columns("DC").Index Then
        If nz(dgv(dgv.Columns("DC").Index, e.RowIndex).Value, "") = "" Then
            dgv(dgv.Columns("DC").Index, e.RowIndex).Value = defadrcr
            Dim drcr = defadrcr
            dgv.RefreshEdit()
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
            dgv.CurrentCell.Value = CDec(dgv.CurrentCell.Value)
            Calc()
        End If

    End Sub
    Private Sub Calc()
        Dim debit As Decimal = 0, credit As Decimal = 0, net As Decimal = 0
        For Each row As DataGridViewRow In dgv.Rows

            If row.Index + 1 <> row.Cells("Sr").Value Then
                dbUpdate(New String() {"Update trefdate set id = " & id & ", lineid = " & row.Index + 1 & " where id = " & id & " lineid = " & row.Cells("Sr").Value})
                row.Cells("Sr").Value = row.Index + 1
            End If

            debit += row.Cells("Debit").FormattedValue
            credit += row.Cells("Credit").FormattedValue
        Next
        net = debit - credit
        numDebit.value = debit
        numCredit.value = credit
        numNet.value = Math.Abs(net)
        lbldrcr.Text = IIf(net > 0, "Dr", "Cr")
        numNet.ForeColor = IIf(net > 0, Color.Red, Color.Blue)
    End Sub
    Private Sub dgv_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgv.CellValidating
        If e.ColumnIndex = dgv.Columns("Account").Index Then
            If lb.Visible = False Then
                If dgv.CurrentCell.Value = "" Then
                    MsgBox("Please enter the account")
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
                drcr = defadrcr
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
        Else
            isFromDgv = True
        End If

        lb.SelectedIndex = lb.FindString(DirectCast(sender, TextBox).Text)
        lb.SelectionMode = SelectionMode.One
        lb.TopIndex = lb.SelectedIndex

    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click, btnSave.Click
        If Validate_Form() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub
    Private Function Validate_Form() As Boolean
        If dtpDate.Value > gFinEndDate Then
            MsgBox("Date can not be greater than " & gFinEndDate)
            dtpDate.Focus()
            Return False
        ElseIf dtpDate.Value < gFinEndDate Then
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
        For Each row As DataGridViewRow In dgv.Rows
            If String.IsNullOrEmpty(row.Cells("DC").Value) Then
                MsgBox("Please select Type")
                dgv.CurrentCell = row.Cells("DC")
                dgv.Focus()
                Return False
            End If
            If String.IsNullOrEmpty(row.Cells("Account").Value) Then
                MsgBox("Please select account")
                dgv.CurrentCell = row.Cells("Account")
                dgv.Focus()
                Return False
            End If

        Next
        Return True
    End Function
    Private Sub txtAccount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAccount.GotFocus
        isFromDgv = False
        Fill_Combo()
        lb.Visible = True
        If txtAccount.Text <> String.Empty Then
            lb.SelectedIndex = lb.FindStringExact(txtAccount.Text)
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
            chkNarration.Focus()
        End If
    End Sub

    Private Sub dtpDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDate.ValueChanged
        chkNarration.Focus()
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
        Calc()
    End Sub

    Private Sub numVoucherNo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles numVoucherNo.Validating
        If Not ActiveControl Is btnCancel Then
            id = nz(dbValue("Select id from tdatamain where voucherno = " & numVoucherNo.value & " and coid=" & gCoId & " and date>= '" & sqldate(gFinStartDate) & "' and date<='" & sqldate(gFinEndDate) & "' and voucher = '" & vName & "'"), 0)
            If id <> 0 Then
                Dim dt As DataTable = dbTable("Select a.*,b.ledger from tdatamain a inner join mledger b on  b.id=a.accid where a.id = " & id)
                If dt.Rows.Count > 0 Then
                    Dim dt1 As DataTable = dbTable("Select a.*,b.ledger from tdatadetails a inner join mledger b on  b.id=a.accid where voucherid=" & id)
                    chkNarration.CheckState = dt.Rows(0)("SingleNarration") = 1

                    lblVoucher.Text = vPrefix & " / " & numVoucherNo.value & " / " & vSuffix
                    dtpDate.Value = dt.Rows(0)("Date")
                    txtAccount.Text = dt.Rows(0)("ledger")
                    txtAccount.Tag = dt.Rows(0)("accid")



                    dgv.Rows.Clear()
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
            End If
        End If
    End Sub

  
    Private Sub dgv_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgv.RowValidating
        If dgv.CurrentCell.ColumnIndex <> dgv.ColumnCount - 1 Then
            If nz(dgv.Rows(e.RowIndex).Cells("Account").Value, "") = "" Then
                MsgBox("Account not entered")
                e.Cancel = True
            End If
        End If

    End Sub
End Class
Imports System.Windows.Forms
Imports System.Net.Mail
Public Class Reference2
    Friend dataid As Integer = 1
    Friend lineid As Integer = 1
    Friend refamt As Double = 0.0
    Friend refno As String = "12"
    Friend refDate As Date = Now.Date
    Friend adjAmt As Double = 90000.0
    Friend adjType As String = "Cr"
    Friend AccId As Integer = 14
    Friend account As String = "Abc & Co."
    Friend voucher As Integer = 5
    Friend vdate As Date = Now.Date
    Dim adjusted As Double = 0.0
    Dim refdt As New DataTable
    Dim dt As DataTable
    Dim isFillingRef As Boolean


    Private Sub Reference_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim mm As New MailMessage
        'Dim sc As New SmtpClient
        'sc.Host = "mail.stardimensionsindia.com"
        'sc.Port = 25
        'sc.EnableSsl = False
        'Dim cr As New Net.NetworkCredential("admin@stardimensionsindia.com", "sp@1964")
        '' Dim cr As New Net.NetworkCredential("pujara.sd@gmail.com", "ketk1ketk")
        'sc.Credentials = cr
        'mm.Subject = "Test"
        'mm.Body = "Test"
        'mm.To.Add("stardconf@gmail.com")
        '' mm.To.Add("manish_1111@rediffmail.com")
        ''mm.From = New MailAddress("admin@stardimensionsindia.com")
        'mm.From = New MailAddress("admin@stardimensionsindia.com")
        'Try

        '    sc.Send(mm)
        'Catch ex As SmtpException
        '    MsgBox(ex.Message)
        'End Try
        'Application.Exit()

        If adjType = "Cr" Then adjAmt *= -1

        cmbRefNo.Font = New Font("Courier New", 8, FontStyle.Regular, GraphicsUnit.Point)
        lblAccountName.Text = account
        lblamt.Text = Format(adjAmt, "n2") & " " & adjType
        '  If adjType = "Cr" Then adjAmt *= -1
        Grid_Create()
        refdt.Columns.Add("RefDisp")
        refdt.Columns.Add("Refno")
        refdt.Columns.Add("Period")
        refdt.Columns.Add("RefAmt")
        refdt.Columns.Add("Type")
        refdt.Columns.Add("RefDate")
        refdt.Columns.Add("DueDate")

        Dim cnt As Integer = dbValue("Select count(*) from trefdata where accid = " & AccId)
        If cnt > 0 Then '' there are entries of the account
            cnt = dbValue("Select count(*) from trefdata where accid = " & AccId & " and dataid =" & dataid & " and lineid = " & lineid)
            If cnt = 0 Then '' there are entries of account but not of the current entry
                numAmount.value = adjAmt
                cmbType.SelectedItem = adjType
            Else '' there are entries of the current entry
                dt = dbTable("Select * from trefdata where accid = " & AccId & " and dataid =" & dataid & " and lineid = " & lineid)
                For Each row In dt.Rows
                    Dim rowid As Integer = dgv.Rows.Add()
                    Dim drow As DataGridViewRow = dgv.Rows(rowid)
                    drow.Cells("Refno").Value = row("RefNo")
                    drow.Cells("Period").Value = row("Period")
                    drow.Cells("RefDate").Value = row("RefDate")
                    drow.Cells("RefDue").Value = row("DueDate")
                    drow.Cells("RefAmt").Value = row("Amount")
                    drow.Cells("Type").Value = row("Type")
                    drow.Cells("RefType").Value = row("RefType")
                    drow.Cells("Sr").Value = rowid + 1
                    If adjType = "Dr" Then
                        adjusted += IIf(row("type") = "Dr", row("amount"), -row("amount"))
                    Else
                        adjusted += IIf(row("type") = "Dr", -row("amount"), row("amount"))
                    End If
                Next
            End If
        Else '' there is no entries of the account at all.
            cmbRefType.SelectedItem = "OnAccount"
            cmbRefNo.Text = voucher
            dtpDate.Value = vdate
            dtpDueDate.Value = vdate
            numAmount.value = adjAmt
            numAmount.Tag = adjAmt
            cmbType.SelectedItem = adjType

        End If

        btnSave.Text = "&Add"
        cmbRefType.SelectedItem = "OnAccount"
        If dgv.Rows.Count = 0 Then pnlSave.Enabled = False
        lblAdjstedAmt.Text = adjusted.ToString("##,##,##,##0.00")
        lblToadj.Text = (adjAmt - adjusted).ToString("##,##,##,##0.00")
        cmbType.SelectedItem = adjType
        dgv.ReadOnly = True
        If adjAmt - adjusted = 0 Then
            pnlSave.Enabled = True
            Cancel_Button.Enabled = True

            OK_Button.Enabled = False
            pnlEntry.Enabled = False
            Cancel_Button.Focus()
        End If

    End Sub
#Region "Save_Entries"
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'Dim refno As String = ""
        'Dim refdate As Date = Now.Date
        'Dim refamt As Decimal = 0.0
        'Dim reftype As String = ""
        'Dim type As String = ""
        'Dim qstr As String = ""
        'Dim period As String = ""
        'Dim aqstr As New List(Of String)
        'For Each row As DataGridViewRow In dgv.Rows
        '    refno = row.Cells("Refno").Value
        '    refdate = row.Cells("RefDate").Value
        '    refamt = row.Cells("RefAmt").Value
        '    type = row.Cells("type").Value
        '    reftype = row.Cells("reftype").Value

        '    period = row.Cells("Period").Value
        '    If dbValue("select count(*) from trefdata where " & _
        '                "Refno ='" & refno & "' and " & _
        '                "period ='" & period & "' and " & _
        '                "Refdate='" & sqldate(refdate) & "' and " & _
        '                "type='" & reftype & "' and " & _
        '                "dataid = " & dataid & " and " & _
        '                "lineid = " & lineid & "") > 0 Then
        '        qstr = "Update trefdata set " & _
        '                 "Amount = " & refamt & " where " & _
        '                 "Refno ='" & refno & "' and " & _
        '                 "period ='" & period & "' and " & _
        '                "Refdate='" & sqldate(refdate) & "' and " & _
        '                "type='" & type & "' and " & _
        '                "reftype='" & reftype & "' and " & _
        '                "dataid = " & dataid & " and " & _
        '                "lineid = " & lineid & ""
        '        aqstr.Add(qstr)
        '    Else
        '        qstr = "insert into trefdata (Amount,Refno,Refdate,type,reftype,dataid,lineid,period) " & _
        '                 "values (" & refamt & "," & _
        '                 "'" & refno & "', " & _
        '                "'" & sqldate(refdate) & "', " & _
        '                "'" & type & "', " & _
        '                 "'" & reftype & "', " & _
        '                "" & dataid & ", " & _
        '                "" & lineid & "," & _
        '                "'" & period & "') "
        '        aqstr.Add(qstr)
        '    End If
        'Next
        'If Not dbUpdate(aqstr.ToArray) Then
        '    MessageBox.Show("Update failed! Try again")
        '    Exit Sub
        'End If


        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
#End Region

#Region "Grid_Proc"
    Private Sub Grid_Create()
        With dgv
            dgvdefault(dgv)
            dgv.Columns.Add("Sr", "Sr.No.")
            dgv.Columns.Add("RefType", "Ref. Type")
            dgv.Columns.Add("RefNo", "Ref. No.")
            dgv.Columns.Add("Period", "Period")
            dgv.Columns.Add("RefDate", "Date")
            dgv.Columns.Add("RefDue", "Due Date")
            dgv.Columns.Add("RefAmt", "Amount")
            dgv.Columns.Add("Type", "Type")
            dgv.Columns("RefDate").CellTemplate.Style.Format = "d"
            dgv.Columns("RefDue").CellTemplate.Style.Format = "d"
            dgv.Columns("RefAmt").CellTemplate.Style.Format = "f2"
            dgv.Columns("RefAmt").CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight

        End With
    End Sub

    Private Sub dgv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv.KeyDown
        '      If Not dgv.ReadOnly Then
        If e.KeyCode = Keys.Delete Then
            If dgv.Rows.Count = 1 Then
                MsgBox("You can not delete all rows")
                Exit Sub
            End If
            If dgv.SelectedRows.Count = 0 Then
                MsgBox("Please select row to delete")
            Else
                dgv.Rows.Remove(dgv.SelectedRows(0))
                adjusted = 0
                For Each row As DataGridViewRow In dgv.Rows
                    If adjType = "Dr" Then
                        adjusted += IIf(row.Cells("type").Value = "Dr", row.Cells("refamt").Value, -row.Cells("refamt").Value)
                    Else
                        adjusted += IIf(row.Cells("type").Value = "Dr", -row.Cells("refamt").Value, row.Cells("refamt").Value)
                    End If
                Next




                numAmount.value = 0
                btnSave.Text = "&Add"
                If adjusted < adjAmt Then
                    pnlEntry.Enabled = True
                    numAmount.value = adjAmt - adjusted
                    pnlSave.Enabled = False
                Else
                    pnlEntry.Enabled = False
                    pnlSave.Enabled = True
                End If
                dgv.Refresh()
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            If dgv.SelectedRows.Count = 0 Then
                MsgBox("Please select row to delete")
            Else
                dgv_MouseDoubleClick(dgv, New MouseEventArgs(Windows.Forms.MouseButtons.Left, 2, 0, 0, 0))
            End If
        End If
        lblAdjstedAmt.Text = adjusted.ToString("##,##,##,##0.00")
        lblToadj.Text = (adjAmt - adjusted).ToString("##,##,##,##0.00")
        '      Else
        '     e.Handled = True
        '     End If
    End Sub

    Private Sub dgv_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgv.MouseDoubleClick
        If dgv.CurrentRow.Index >= 0 Then
            btnSave.Text = "&Save"
            btnSave.Enabled = True
            btnCancel.Enabled = True
            pnlEntry.Enabled = True
            pnlSave.Enabled = False
            With dgv.CurrentRow
                cmbRefType.SelectedItem = .Cells("RefType").Value
                If cmbRefNo.Items.Count > 0 Then
                    cmbRefNo.SelectedItem = .Cells("RefNo").Value
                Else
                    cmbRefNo.Text = .Cells("RefNo").Value
                End If
                dtpDate.Value = .Cells("RefDAte").Value
                dtpDueDate.Value = .Cells("Refdue").Value
                If cmbRefType.SelectedItem = "Against" Then
                    numAmount.value = .Cells("RefAmt").Value
                    numAmount.Tag = .Cells("RefAmt").Value
                Else
                    numAmount.value = .Cells("RefAmt").Value + Val(lblToadj.Text.Replace(",", ""))
                    numAmount.Tag = .Cells("RefAmt").Value + Val(lblToadj.Text.Replace(",", ""))
                End If


                cmbType.SelectedItem = .Cells("Type").Value
                lblSr.Text = .Cells("Sr").Value


            End With
        End If
    End Sub
#End Region

#Region "Save_Entry"
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If numAmount.value = 0 Then
            MsgBox("Please enter amount")
            numAmount.Focus()
            Exit Sub
        End If
        If cmbRefType.SelectedItem = "Against" And cmbRefNo.SelectedIndex = -1 Then
            MsgBox("Invalid Ref.No.")
            cmbRefNo.Focus()
            Exit Sub
        End If

        If cmbRefType.SelectedItem <> "Against" And cmbRefNo.Text = "" Then
            MsgBox("Invalid Ref.No.")
            cmbRefNo.Focus()
            Exit Sub
        End If
        If cmbType.SelectedIndex = -1 Then
            MsgBox("Please select Dr/Cr")
            cmbType.Focus()
            Exit Sub
        End If
        Dim refno As String = ""
        Dim refperiod As String = gPeriod
        If cmbRefNo.SelectedIndex < 0 Then
            refno = cmbRefNo.Text
        Else
            refno = cmbRefNo.SelectedValue
            refperiod = cmbRefNo.SelectedItem()(2)


        End If
        'Dim dt As DataTable = DirectCast(cmbRefNo.DataSource, DataTable)
        'dt.DefaultView.RowFilter = "refno = '" & refno & "'"
        'refperiod = dt.DefaultView(0)("period")
        'dt = Nothing

        If cmbRefType.SelectedItem = "Against" Then
            Dim chkrefamt As Double = cmbRefNo.SelectedItem()(3)
            If chkrefamt < numAmount.value Then
                If numAmount.value <= (adjAmt - adjusted) + chkrefamt Then
                Else
                    numAmount.value = chkrefamt
                End If

            End If
        End If

        If btnSave.Text = "&Add" Then
            For Each row As DataGridViewRow In dgv.Rows

                If Not "Against_New".Contains(row.Cells("RefType").Value) Then
                    If row.Cells("RefType").Value = cmbRefType.SelectedItem Then
                        MsgBox("You can add multiple entry of (Against-Reference) only. Please, edit the existing entry to change amount.")
                        Exit Sub
                    End If
                Else
                    If row.Cells("RefNo").Value = refno And row.Cells("Period").Value = refperiod Then
                        MsgBox("Can not add same Ref. No. twice")
                        Exit Sub
                    End If
                End If
            Next
            adjusted += numAmount.value
        Else
            adjusted = adjusted + numAmount.value - numAmount.Tag
        End If
        If adjAmt - adjusted < 0 Then
            MsgBox("You can not adjust more than " & Format(adjAmt, "f2"))
            numAmount.Focus()
            adjusted = adjusted - numAmount.value + numAmount.Tag
            Exit Sub
        End If



        If btnSave.Text = "&Add" Then

            dgv.Rows.Add(New String() {dgv.RowCount + 1, cmbRefType.SelectedItem, refno, refperiod, dtpDate.Value.Date, dtpDueDate.Value.Date, numAmount.value, cmbType.SelectedItem})
        Else
            For Each row As DataGridViewRow In dgv.Rows
                If row.Cells("sr").Value = lblSr.Text Then
                    row.Cells("RefType").Value = cmbRefType.SelectedItem
                    row.Cells("RefNo").Value = refno
                    row.Cells("Period").Value = refperiod
                    row.Cells("RefDate").Value = dtpDate.Value.Date
                    row.Cells("RefDue").Value = dtpDueDate.Value.Date
                    row.Cells("RefAmt").Value = numAmount.value
                    row.Cells("type").Value = cmbType.SelectedItem
                End If
            Next
        End If
        adjusted = 0
        For Each row As DataGridViewRow In dgv.Rows
            If adjType = "Dr" Then
                adjusted += IIf(row.Cells("type").Value = "Dr", row.Cells("refamt").Value, -row.Cells("refamt").Value)
            Else
                adjusted += IIf(row.Cells("type").Value = "Dr", -row.Cells("refamt").Value, row.Cells("refamt").Value)
            End If
        Next




        numAmount.value = 0
        btnSave.Text = "&Add"
        If adjusted < adjAmt Then
            pnlEntry.Enabled = True
            numAmount.value = adjAmt - adjusted
            pnlSave.Enabled = False
        Else
            pnlEntry.Enabled = False
            pnlSave.Enabled = True
        End If
        lblAdjstedAmt.Text = adjusted.ToString("##,##,##,##0.00")
        lblToadj.Text = (adjAmt - adjusted).ToString("##,##,##,##0.00")



    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        numAmount.value = 0
        btnSave.Text = "&Add"
        If adjusted < adjAmt Then
            pnlEntry.Enabled = True
            numAmount.value = adjAmt - adjusted
            cmbRefType.SelectedItem = "OnAccount"
            pnlSave.Enabled = False
        Else
            pnlEntry.Enabled = False
            pnlSave.Enabled = True
        End If
        lblAdjstedAmt.Text = adjusted.ToString("##,##,##,##0.00")
        lblToadj.Text = (adjAmt - adjusted).ToString("##,##,##,##0.00")

    End Sub


#End Region

#Region "Combos"



    Private Function Fill_RefNo()
        isFillingRef = True

        Dim locRefno As String = ""
        Dim locRefamt As Double = 0
        Dim locRefperiod As String = ""
        Dim locRefdate As Date
        Dim locDuedate As Date

        refdt.Rows.Clear()
        Dim ROW As DataRow
        If btnSave.Text = "&Save" Then
            locRefno = dgv.SelectedRows(0).Cells("refno").Value
            locRefamt = dgv.SelectedRows(0).Cells("refamt").Value
            locRefperiod = dgv.SelectedRows(0).Cells("period").Value
            locRefdate = dgv.SelectedRows(0).Cells("refdate").Value
            locDuedate = dgv.SelectedRows(0).Cells("RefDue").Value
            Dim rrow As DataRow = refdt.NewRow
            rrow("RefDisp") = locRefno & " : " & locRefperiod & " | " & Math.Abs(locRefamt).ToString("##,##,##0.00").PadLeft(12) & " | " & dgv.SelectedRows(0).Cells("type").Value
            rrow("refno") = locRefno
            rrow("refamt") = Math.Abs(locRefamt)
            rrow("period") = locRefperiod
            rrow("type") = dgv.SelectedRows(0).Cells("type").Value
            rrow("refdate") = locRefdate
            rrow("duedate") = locDuedate
            refdt.Rows.Add(rrow)
        Else
            If dt Is Nothing Then
                dt = dbTable("Select * from trefdata where accid = " & AccId & " and coid =" & gCoId & " and refdate <='" & sqldate(refDate) & "' order by refno,period ")
            End If

            For i = 0 To dt.Rows.Count - 1
                ROW = dt.Rows(i)
                If locRefno & locRefperiod <> ROW("refno") & ROW("period") Then

                    If locRefno <> "" And locRefamt <> 0 Then
                        Dim rrow As DataRow = refdt.NewRow
                        rrow("RefDisp") = locRefno & " : " & locRefperiod & " | " & Math.Abs(locRefamt).ToString("##,##,##0.00").PadLeft(12) & " | " & IIf(locRefamt < 0, "Cr", "Dr")
                        rrow("refno") = locRefno
                        rrow("period") = locRefperiod
                        rrow("refamt") = Math.Abs(locRefamt)
                        rrow("type") = IIf(locRefamt < 0, "Cr", "Dr")
                        rrow("refdate") = locRefdate
                        rrow("duedate") = locDuedate

                        refdt.Rows.Add(rrow)

                    End If
                    locRefno = ROW("refno")
                    locRefperiod = ROW("period")
                    locRefdate = ROW("refdate")
                    locDuedate = ROW("duedate")
                End If
                If ROW("refno") = locRefno And locRefperiod = ROW("period") Then
                    locRefamt = IIf(ROW("type") = "Dr", ROW("Amount"), -ROW("Amount"))
                End If
            Next
        End If

        If locRefamt > 0 Then
            Dim rrow As DataRow = refdt.NewRow
            rrow("RefDisp") = locRefno & " : " & locRefperiod & " | " & Math.Abs(locRefamt).ToString("##,##,##0.00").PadLeft(12) & " | " & IIf(locRefamt < 0, "Cr", "Dr")
            rrow("refno") = locRefno
            rrow("refamt") = Math.Abs(locRefamt)
            rrow("period") = locRefperiod
            rrow("type") = IIf(locRefamt < 0, "Cr", "Dr")
            rrow("refdate") = locRefdate
            rrow("duedate") = locDuedate
            refdt.Rows.Add(rrow)
        End If



        If refdt.Rows.Count > 0 Then
            cmbRefNo.DataSource = refdt
            cmbRefNo.DisplayMember = "RefDisp"
            cmbRefNo.ValueMember = "refno"
            If btnSave.Text = "&Add" Then
                cmbRefNo.SelectedIndex = -1
            Else
                cmbRefNo.SelectedIndex = 0
            End If
            isFillingRef = False
            Return True
        Else
            isFillingRef = False
            Return False
        End If


    End Function

    Private Sub cmbRefType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRefType.SelectedIndexChanged
        cmbRefNo.SelectedIndex = -1
        If cmbRefType.SelectedItem = "Against" Then
            If Fill_RefNo() Then
                dtpDate.Enabled = True
                dtpDueDate.Enabled = True
                numAmount.Enabled = True
                cmbType.Enabled = True
            Else
                cmbRefType.SelectedIndex = cmbRefType.FindStringExact("OnAccount")
            End If

        ElseIf cmbRefType.SelectedItem = "OnAccount" Then
            cmbRefNo.Text = voucher
            dtpDate.Enabled = False
            dtpDueDate.Enabled = False
            numAmount.Enabled = False
            cmbType.Enabled = False

        ElseIf cmbRefType.SelectedItem = "New" Then
            cmbRefNo.Text = voucher
            dtpDate.Enabled = True
            dtpDueDate.Enabled = True
            numAmount.Enabled = True
            cmbType.Enabled = True
        ElseIf cmbRefNo.SelectedItem = "Advance" Then
            cmbRefNo.Text = voucher
            dtpDate.Enabled = False
            dtpDueDate.Enabled = False
            numAmount.Enabled = False
            cmbType.Enabled = False

        End If
        '   


    End Sub

    Private Sub cmbRefNo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbRefNo.SelectedIndexChanged
        If Not isFillingRef Then
            If cmbRefType.SelectedItem = "Against" Then
                If cmbRefNo.SelectedIndex <> -1 Then
                    Dim refamt As Double = cmbRefNo.SelectedItem()(3)
                    Dim Type As String = cmbRefNo.SelectedItem()(4)
                    If Type <> cmbType.Text And refamt > numAmount.value Then
                        Exit Sub
                    End If
                    numAmount.value = refamt
                    cmbType.SelectedItem = Type
                    dtpDate.Value = cmbRefNo.SelectedItem()("RefDate")
                    dtpDueDate.Value = cmbRefNo.SelectedItem()("DueDate")
                End If
            End If
        End If

    End Sub



    Private Sub cmbRefNo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbRefNo.Validating
        If ActiveControl.Name = "btnCancel" Then Exit Sub
        If cmbRefType.SelectedItem = "Against" And cmbRefNo.SelectedIndex = -1 Then
            MsgBox("Invalid Ref.No.")
            e.Cancel = True
            Exit Sub
        End If
        If cmbRefType.SelectedItem <> "Against" And cmbRefNo.Text = "" Then
            MsgBox("Invalid Ref.No.")
            e.Cancel = True
            Exit Sub
        End If
    End Sub
#End Region

End Class

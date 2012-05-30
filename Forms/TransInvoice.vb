Imports System.IO
Public Class TransInvoice
    Private isloading As Boolean = True
    Private mode As String = ""

    Private Sub TransInvoice_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Main.miInvoice.Enabled = True
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If dgv.Rows.Count = 0 Then
            MsgBox("No Record to saved", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim aqstr As New List(Of String)
        Select Case mode

            Case "Add"
                'Dim strqry As String = "Select Invoice_no FROM ttInvoice where Invoice_No =  " & txtInvoiceno.Text
                'If nz(dbValue(strqry), 0) > 0 Then
                '    Ep1.SetError(txtInvoiceno, "Duplicate!")
                '    Exit Sub
                'Else
                '    Ep1.SetError(txtInvoiceno, "")
                'End If
                Dim tblname As String = "ttInvoice"
                Dim strqry As String = ""
                Dim fldtext = "Invoice_No,Invoice_Date,CustId,ChallanNo,[Desc],Weight,Rate,Amount,Advance,NetAmount"
                For i As Integer = 0 To dgv.Rows.Count - 1
                    ''
                    Dim fldvalue As String = ""
                    fldvalue = fldvalue & txtInvoiceno.Text & "', '" & sqldate(dtpInvoiceDate.Value.Date.ToString) & "','"
                    fldvalue = fldvalue & cmbCustomer.SelectedValue & "','" & dgv.Rows(i).Cells(0).Value.ToString & "','"
                    fldvalue = fldvalue & dgv.Rows(i).Cells(1).Value.ToString & "','" & dgv.Rows(i).Cells(2).Value.ToString & "','"
                    fldvalue = fldvalue & dgv.Rows(i).Cells(3).Value.ToString & "','" & dgv.Rows(i).Cells(4).Value.ToString & "','"
                    fldvalue = fldvalue & "0.00" & "',' " & NumNetAmt.value
                    strqry = "insert into " & tblname & " (" & fldtext & ") values ('" & fldvalue & "')"
                    aqstr.Add(strqry)
                    Dim updQry As String = "Update ttChallan set inv = '" & txtInvoiceno.Text & "' where challan = " & dgv.Rows(i).Cells(0).Value.ToString
                    aqstr.Add(updQry)
                    dbUpdate(aqstr.ToArray)
                    fldvalue = ""
                Next
            Case "Edit"

            Case "Delete"

        End Select
        MsgBox("Ok")
        Me.Close()
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Main.miInvoice.Enabled = False
        mode = "Add"
        txtInvoiceno.Text = nz(dbValue("select max(invoice_no) from ttInvoice"), 0) + 1
        fillcombo()
        Filldgv()
        isloading = False
    End Sub
    Private Sub fillcombo()
        Dim qry As String = ""
        qry = " with cte as  " & _
        "(select * from mledgergroup where groupid = " & enLedger.Debtors & _
        " union all " & _
        " select t.* from cte inner join mledgergroup t on t.groupid = cte.id) " & _
        " select  mledger.id,mledger.ledger+' ~ '+cte.groupname as ledger from cte inner join mledger on mledger.groupid = cte.id order by ledger "
        fill_combocommon(cmbCustomer, qry, "ledger", "id")
    End Sub
    Private Sub Filldgv()
        dgvdefault()
    End Sub
    Private Sub dgvdefault()
        dgv.AllowUserToDeleteRows = False
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.AllowUserToAddRows = False
        dgv.RowHeadersVisible = False
        dgv.BorderStyle = BorderStyle.Fixed3D
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
        dgv.Enabled = False
    End Sub
    Private Sub txtInvoiceno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInvoiceno.KeyPress
        If Not Char.IsDigit(e.KeyChar) = True Then
            If Asc(e.KeyChar) <> 13 Then
                Ep1.SetError(txtInvoiceno, "Please Enter Numeric value only !! ")
            End If
            e.Handled = True
        Else
            Ep1.SetError(txtInvoiceno, "")
            e.Handled = False
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GroupBox1.Visible = False
        Dim txtamt As Integer = 0
        Dim dt1 As New DataTable
        Dim row1 As DataRow
        dt1.Columns.Add("Challan")
        dt1.Columns.Add("Description")
        dt1.Columns.Add("Weight")
        dt1.Columns.Add("Rate")
        dt1.Columns.Add("Amount")
        dt1.Columns.Add("Advance")
        dt1.Columns.Add("Remarks")
        For i As Integer = 0 To dgvChallanList.RowCount - 1
            If dgvChallanList.Rows(i).Cells(0).Value = True Then
                row1 = dt1.NewRow()
                row1.Item("Challan") = dgvChallanList.Rows(i).Cells(1).Value.ToString
                row1.Item("Description") = dgvChallanList.Rows(i).Cells(2).Value.ToString
                row1.Item("Weight") = dgvChallanList.Rows(i).Cells(3).Value.ToString
                row1.Item("Rate") = dgvChallanList.Rows(i).Cells(4).Value.ToString
                row1.Item("Amount") = dgvChallanList.Rows(i).Cells(5).Value.ToString
                txtamt = txtamt + dgvChallanList.Rows(i).Cells(5).Value
                dt1.Rows.Add(row1)
            End If
        Next
        NumNetAmt.value = txtamt
        dgv.DataSource = dt1
    End Sub
    Private Sub dgvChallanList_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvChallanList.Click
        If dgvChallanList.CurrentRow.Cells(0).Value = False Then
            dgvChallanList.CurrentRow.Cells(0).Value = True
        Else
            dgvChallanList.CurrentRow.Cells(0).Value = False
        End If
    End Sub
    Private Sub txtInvoiceno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInvoiceno.Validated
        'Dim dt As DataTable = dbTable("select ttInvoice.*,mLedger.ledger from ttInvoice,mledger  where mledger.id = ttInvoice.custid and invoice_no = " & txtInvoiceno.Text)
        Dim dt As DataTable = dbTable("select * from ttInvoice where invoice_no = " & txtInvoiceno.Text)
        If dt.Rows.Count > 0 Then
            mode = "Edit"
            dtpInvoiceDate.Value = dt.Rows(0).Item("Invoice_date")
            '            Dim sid As Integer = dt.Rows(0).Item("custid")
            cmbCustomer.SelectedValue = dt.Rows(0).Item("custid")
            Dim txtamt As Integer = 0
            Dim dt1 As New DataTable
            Dim row1 As DataRow
            dt1.Columns.Add("Challan")
            dt1.Columns.Add("Description")
            dt1.Columns.Add("Weight")
            dt1.Columns.Add("Rate")
            dt1.Columns.Add("Amount")
            dt1.Columns.Add("Advance")
            dt1.Columns.Add("Remarks")
            'Invoice_No,Invoice_Date,CustId,ChallanNo,[Desc],Weight,Rate,Amount,Advance,NetAmount
            For i = 0 To dt.Rows.Count - 1
                row1 = dt1.NewRow()
                row1.Item("Challan") = dt.Rows(0).Item("ChallanNo")
                row1.Item("Description") = dt.Rows(0).Item("Desc")
                row1.Item("Weight") = dt.Rows(0).Item("Weight")
                row1.Item("Rate") = dt.Rows(0).Item("Rate")
                row1.Item("Amount") = dt.Rows(0).Item("Amount")
                row1.Item("Advance") = dt.Rows(0).Item("Advance")
                txtamt = txtamt + dt.Rows(0).Item("Amount")
                dt1.Rows.Add(row1)
            Next
            dgv.DataSource = dt1
            NumNetAmt.value = txtamt
        End If
    End Sub
    Private Sub cmbCustomer_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbCustomer.Validating
        ''
        If Not isloading Then
            If Me.ActiveControl.Name <> "btnCancel" Then
                If cmbCustomer.SelectedIndex = 1 Then
                    Dim ofrm As New LedgerEntry
                    ofrm.id = 0
                    ofrm.mode = enDatamode.Add
                    ofrm.ShowDialog()
                    If ofrm.DialogResult = Windows.Forms.DialogResult.OK Then
                        fill_combo()
                        cmbCustomer.SelectedValue = ofrm.id
                        e.Cancel = False
                    Else
                        e.Cancel = True
                    End If
                ElseIf cmbCustomer.SelectedIndex <= 0 Then
                    MsgBox("Please Select Customer")
                    e.Cancel = True
                ElseIf cmbCustomer.SelectedIndex > 1 Then
                    If mode = "Add" Then
                        dgvChallanList.DataSource = Nothing
                        dgvChallanList.Refresh()
                        Dim dt As New DataTable
                        '            "select ttcitems.Challanid as Challan,ttcitems.weight,ttcitems.rate,ttcitems.Ratediff from ttcitems,ttchallan where ttcitems.challanid = ttChallan.id and ttChallan.custid = " & cmbCustomer.SelectedItem(0)
                        Dim cQry As String = "select ttcitems.Challanid as Challan,ttcitems.description,ttcitems.weight,ttcitems.rate,ttcitems.amount from ttcitems,ttchallan where ttcitems.challanid = ttChallan.id  and ttChallan.custid = " & cmbCustomer.SelectedItem(0) & " and inv =  0 "
                        dt = dbTable(cQry)
                        If dt.Rows.Count > 0 Then
                            GroupBox1.Visible = True
                            dgvChallanList.Columns(0).Width = 40
                            dgvChallanList.Columns(0).HeaderText = "Select"
                            dgvChallanList.Columns(0).Visible = True
                            dgvChallanList.DataSource = dt
                        Else
                            MsgBox("Challan Does not Exist")
                            txtInvoiceno.Focus()
                        End If
                    End If
                    End If
                    ''
            End If
        End If
        ''
    End Sub
    Private Sub fill_combo()
        Dim qry As String = ""
        qry = " with cte as  " & _
        "(select * from mledgergroup where groupid = " & enLedger.Debtors & _
        " union all " & _
        " select t.* from cte inner join mledgergroup t on t.groupid = cte.id) " & _
        " select  mledger.id,mledger.ledger+' ~ '+cte.groupname as ledger from cte inner join mledger on mledger.groupid = cte.id order by ledger "
        fill_combocommon(cmbCustomer, qry, "ledger", "id")
    End Sub
    Private Sub cmbCustomer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCustomer.SelectedIndexChanged

    End Sub
End Class

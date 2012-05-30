Imports System.Windows.Forms
Public Class mChallanname
    Friend mode As enEntry
    Friend id As Integer
    Friend formtype As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If txtChallanname.Text = "" Then
            Ep1.SetError(txtChallanname, "Please enter " & formtype)
            Exit Sub
        Else
            Ep1.SetError(txtChallanname, "")
        End If
        If txtChallanname.Text = txtChallanname.Tag Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
        Dim ACCID As Integer
        If cmbCompany.Items.Count > 2 Then
            ACCID = cmbCompany.SelectedValue
        End If
        Dim fldid As String = ""
        Dim fldtext As String = ""
        Dim tblname As String = ""
        Select Case formtype
            Case "challanname"
                fldid = "id"
                fldtext = "challanname"
                tblname = "mChallanname"
        End Select
        Dim strqry As String = ""

        If mode = enEntry.Add Then
            strqry = "Select " & fldid & " FROM " & tblname & " where " & fldtext & " = '" & txtChallanname.Text.Trim & "' and coid=" & gCoId
            If nz(dbValue(strqry), 0) > 0 Then
                EP1.SetError(txtChallanname, "Duplicate!")
                Exit Sub
            Else
                EP1.SetError(txtChallanname, "")
            End If
            If formtype = "challanname" Then
                '' strqry = "insert into " & tblname & " (" & fldtext & ",Prefix,AccountId) values ('" & proper(txtChallanname.Text.Replace("'", "''")) & "','" & txtPrefix.Text & "'," & ACCID & ")"
                strqry = "insert into " & tblname & " (" & fldtext & ",Prefix,CoId) values ('" & proper(txtChallanname.Text.Replace("'", "''")) & "','" & txtPrefix.Text & "'," & ACCID & ")"
            End If
        ElseIf mode = enEntry.Edit Then
            strqry = "Select " & fldid & " FROM " & tblname & " where " & fldtext & " = '" & txtChallanname.Text.Trim & "' and " & fldid & "<>" & id & " and coid =" & gCoId
            If nz(dbValue(strqry), 0) > 0 Then
                EP1.SetError(txtChallanname, "Duplicate!")
                Exit Sub
            Else
                EP1.SetError(txtChallanname, "")
            End If
            strqry = "update " & tblname & " set " & fldtext & " ='" & proper(txtChallanname.Text.Replace("'", "''")) & "'"
            strqry &= " where " & fldid & "= " & id
        ElseIf mode = enEntry.Delete Then
            If MsgBox("Are you sure?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                strqry = "delete " & tblname & " "
                strqry &= " where " & fldid & " = " & id
            End If
        Else
        End If
        If dbUpdate(New String() {strqry}) = True Then
    

            '   If txtChallanname.Text = txtChallanname.Tag Then
            'strqry = _
            '<string>

            '            Update mVoucher set
            '            prefix = '<%= txtPrefix.Text %>'
            '            where voucher = '<%= txtChallanname.Text %>' and coid =<%= gCoId %> ;
            '            select @@ROWCOUNT

            '        </string>
            'Else
            '    strqry = _
            '    <string>
            '                Update mVoucher set
            '                prefix = '<%= txtPrefix.Text %>'
            '                voucher = '<%= txtChallanname.Text %>'
            '                where voucher = '<%= txtChallanname.Tag %>'   and coid =<%= gCoId %>           ;
            '                select @@ROWCOUNT

            '            </string>
            'End If
            '  If dbValue(strqry) = 0 Then
            strqry = _
            <string>
                INSERT INTO[mVoucher]
               ([Voucher]
               ,[type]
               ,[Prefix]
               ,[suffix]
               ,[AutoNo]
               ,[AutoStart]
               ,[CoId]) Values (
                '<%= txtChallanname.Text %>',
                '<%= "Challan" %>',
                '<%= txtPrefix.Text %>',
                '',0,1,<%= gCoId %>)
                </string>
            dbupdate(strqry)
            'End If

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Not saved", Me.Text)
        End If
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub mChallanname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
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
    Private Sub mChallanname_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fill_combocommon(cmbCompany, "Select * from mCompany  order by Company ", "Company", "id")
        If mode <> enEntry.Add Then
            Select Case formtype
                Case "challanname"
                    Dim dt As DataTable = dbTable("Select * from mchallanname where id = " & id)
                    txtChallanname.Text = dt.Rows(0)("Challanname") & ""

                    'dbValue("select Challanname from mChallanname where id=" & id)
                    txtPrefix.Text = dt.Rows(0)("Prefix")  'dbValue("select Prefix from mChallanname where id=" & id)
                    cmbCompany.SelectedValue = dt.Rows(0)("coid")
                    cmbCompany.TabIndex = Nothing
            End Select
            txtChallanname.Tag = txtChallanname.Text
            txtPrefix.Tag = txtPrefix.Text
            cmbCompany.Tag = cmbCompany.SelectedValue
        End If
        If mode = enEntry.Delete Or mode = enEntry.View Then
            txtChallanname.Enabled = False
            txtPrefix.Enabled = False
        End If
        If mode = enEntry.Delete Then cmdOk.Text = "&Delete"
        If mode = enEntry.View Then
            cmdCancel.Text = "Ok"
            cmdOk.Visible = False
        End If
        lblChallanname.Text = StrConv(formtype, VbStrConv.ProperCase)
        lblPrefix.Text = "Prefix"   '' StrConv(formtype, VbStrConv.ProperCase)

        Me.Text = StrConv(formtype, VbStrConv.ProperCase) & " Creation "
        cmbCompany.SelectedValue = gCoId
        cmbCompany.Enabled = False
        txtChallanname.Focus()
    End Sub
    Private Sub txtChallanname_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtChallanname.LostFocus
        txtChallanname.Text = proper(txtChallanname.Text)
    End Sub

    Private Sub cmbCompany_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCompany.Enter
        If mode > enEntry.Add Then
            If mode = 3 Then
                cmdCancel.Focus()
            Else
                cmdOk.Focus()
            End If
        End If
    End Sub
End Class

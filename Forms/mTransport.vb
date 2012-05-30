Imports System.Windows.Forms
Public Class mTransport
    Friend mode As enEntry
    Friend id As Integer
    Friend formtype As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If txtState.Text = "" Then
            Ep1.SetError(txtState, "Please enter " & formtype)
            Exit Sub
        Else
            Ep1.SetError(txtState, "")
        End If
        If txtState.Text = txtState.Tag Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
        Dim fldid As String = ""
        Dim fldtext As String = ""
        Dim tblname As String = ""
        Select Case formtype
            Case "Transport"
                fldid = "id"
                fldtext = "transport"
                tblname = "mtransport"
            Case "Agent"
                fldid = "id"
                fldtext = "agent"
                tblname = "magent"

        End Select
        Dim strqry As String = ""
        If mode = enEntry.Add Then
            strqry = "Select " & fldid & " FROM " & tblname & " where " & fldtext & " = '" & txtState.Text.Trim & "'"
            If nz(dbValue(strqry), 0) > 0 Then
                Ep1.SetError(txtState, "Duplicate!")
                Exit Sub
            Else
                Ep1.SetError(txtState, "")
            End If
            strqry = "insert into " & tblname & " (" & fldtext & ") values ('" & proper(txtState.Text.Replace("'", "''")) & "')"
        ElseIf mode = enEntry.Edit Then
            strqry = "Select " & fldid & " FROM " & tblname & " where " & fldtext & " = '" & txtState.Text.Trim & "' and " & fldid & "<>" & id
            If nz(dbValue(strqry), 0) > 0 Then
                Ep1.SetError(txtState, "Duplicate!")
                Exit Sub
            Else
                Ep1.SetError(txtState, "")
            End If
            strqry = "update " & tblname & " set " & fldtext & " ='" & proper(txtState.Text.Replace("'", "''")) & "'"
            strqry &= " where " & fldid & "= " & id
        ElseIf mode = enEntry.Delete Then
            If MsgBox("Are you sure?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                strqry = "delete " & tblname & " "
                strqry &= " where " & fldid & " = " & id
            End If
        Else
        End If
        If dbUpdate(New String() {strqry}) = True Then
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
    Private Sub mState_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If mode <> enEntry.Add Then
            Select Case formtype
                Case "Transport"
                    txtState.Text = dbValue("select Transport from mTransport where id=" & id)
                    txtState.Tag = txtState.Text
                Case "Agent"
                    txtState.Text = dbValue("select Agent from mAgent where id=" & id)
                    txtState.Tag = txtState.Text
            End Select
        End If
        If mode = enEntry.Delete Or mode = enEntry.View Then
            txtState.Enabled = False
        End If
        If mode = enEntry.Delete Then cmdOk.Text = "&Delete"
        If mode = enEntry.View Then
            cmdCancel.Text = "Ok"
            cmdOk.Visible = False
        End If
        lblState.Text = StrConv(formtype, VbStrConv.ProperCase)
        Me.Text = StrConv(formtype, VbStrConv.ProperCase) & " Creation "
        txtState.Focus()
    End Sub
    Private Sub txtState_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtState.LostFocus
        txtState.Text = proper(txtState.Text)
    End Sub
End Class

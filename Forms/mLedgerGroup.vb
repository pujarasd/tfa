Imports System.Windows.Forms
Imports system.Data.SqlClient
Imports System.Configuration
Public Class LedgerGroup
    Friend mode As enEntry
    Friend id As Integer
    Friend formtype As String = "Ledger Group"
    Private _grouplevel As Integer = 0
    Private _maxId As Integer = 0
    Private Sub mLedgerGroup_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Main.miLedgerGroup.Enabled = True
    End Sub
    Private Sub LedgerGroup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Back)
            Case ChrW(Keys.Enter)
                If TypeOf (Me.ActiveControl) Is TextBox Then
                    If CType(Me.ActiveControl, TextBox).Multiline Then
                        Exit Sub
                    End If
                ElseIf TypeOf (Me.ActiveControl) Is Button Then
                    Exit Sub
                End If
                SendKeys.Send("{Tab}")
        End Select
    End Sub
    Private Sub mCity_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Main.miLedgerGroup.Enabled = False
        Me.Text = StrConv(formtype, VbStrConv.ProperCase)
        fillcombo()
        txtCity.Focus()
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If txtCity.Text = "" Then
            Ep1.SetError(txtCity, "Please enter " & formtype)
            Exit Sub
        Else
            Ep1.SetError(txtCity, "")
        End If
        If txtCity.Text = txtCity.Tag Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
        Dim fldid As String = ""
        Dim fldtext As String = ""
        Dim tblname As String = ""
        fldid = "id"
        fldtext = "Groupname"
        tblname = "mLedgerGroup"
        Dim strqry As String = ""
        strqry = "Select " & fldid & " FROM " & tblname & " where " & fldtext & " = '" & txtCity.Text.Trim & "'"
        If nz(dbValue(strqry), 0) > 0 Then
            Ep1.SetError(txtCity, "Duplicate!")
            Exit Sub
        Else
            Ep1.SetError(txtCity, "")
            Dim strqry1 As String = "select Grouplevel from " & tblname & " Where id = " & cboState.SelectedValue
            _grouplevel = dbValue(strqry1) + 1
            Dim strqry2 As String = "select Max(Id)+1  from " & tblname
            _maxId = dbValue(strqry2)
            strqry = "insert into " & tblname & " (" & fldid & "," & fldtext & ",GroupId,GroupLevel ) values ( " & _maxId & ""
            strqry &= ",'" & proper(txtCity.Text.Replace("'", "''")) & "'"
            strqry &= " ," & cboState.SelectedValue & " ," & _grouplevel & ")"
        End If
        If dbUpdate(New String() {strqry}) = True Then
            id = _maxId
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
    Public Sub fillcombo()
        Dim dt As DataTable = dbTable("select Id,Groupname from mLedgerGroup order by Groupname  ")
        With cboState
            .DataSource = dt
            .DisplayMember = "Groupname"
            .ValueMember = "id"
        End With
    End Sub
End Class

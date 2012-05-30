Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Configuration
Public Class mCharges
    Friend mode As enEntry
    Friend id As Integer
    Friend formtype As String
    Public sId As Integer = 0
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If txtCharges.Text = "" Then
            Ep1.SetError(txtCharges, "Please enter " & formtype)
            Exit Sub
        Else
            Ep1.SetError(txtCharges, "")
        End If
        If txtCharges.Text = txtCharges.Tag Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
        Dim strqry As String = ""
        If mode = enEntry.Add Then
            strqry = "Select Id FROM mCharges where Charge = '" & txtCharges.Text.Trim & "'"
            If nz(dbValue(strqry), 0) > 0 Then
                Ep1.SetError(txtCharges, "Duplicate!")
                Exit Sub
            Else
                Ep1.SetError(txtCharges, "")
                strqry = "insert into mCharges (Charge,Acid,Rate,Rateon) values ('" & proper(txtCharges.Text.Replace("'", "''")) & "'," & cboLedger.SelectedValue & "," & txtRate.Text & ",'" & cboRateon.Text & "')"
            End If
        ElseIf mode = enEntry.Edit Then
            strqry = "Select Id FROM mCharges where Charge = '" & txtCharges.Text.Trim & "' And id<>" & id
            If nz(dbValue(strqry), 0) > 0 Then
                Ep1.SetError(txtCharges, "Duplicate!")
                Exit Sub
            Else
                Ep1.SetError(txtCharges, "")
            End If
            strqry = "update mCharges set Charge ='" & proper(txtCharges.Text.Replace("'", "''")) & "'"
            strqry &= " ,Acid = " & cboLedger.SelectedValue & ""
            strqry &= " ,Rate = " & txtRate.Text & ""
            strqry &= " ,Rateon = '" & cboRateon.Text & "'"
            strqry &= " where Id = " & id
        ElseIf mode = enEntry.Delete Then
            If MsgBox("Are you sure?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                strqry = "delete mCharges where Id  = " & id
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
    Private Sub mCharges_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Back)
            Case ChrW(Keys.Enter)
                If TypeOf Me.ActiveControl Is TextBox Then
                    If CType(Me.ActiveControl, TextBox).Multiline Then
                        Exit Sub
                    End If
                ElseIf TypeOf Me.ActiveControl Is Button Then
                    Exit Sub
                End If
                SendKeys.Send("{Tab}")
        End Select
    End Sub
    Private Sub mCharges_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mode <> enEntry.Add Then
            Dim dt As New DataTable
            dt = dbTable("select charge,Acid,Rate,Rateon from mCharges where id=" & id)
            txtCharges.Text = dt.Rows(0)(0).ToString
            sId = dt.Rows(0)(1).ToString
            txtRate.Text = dt.Rows(0)(2).ToString
            cboRateon.Text = dt.Rows(0)(3).ToString
        End If
        If mode = enEntry.Delete Or mode = enEntry.View Then
            txtCharges.Enabled = False
        End If
        If mode = enEntry.Delete Then cmdOk.Text = "&Delete"
        If mode = enEntry.View Then
            cmdCancel.Text = "Ok"
            cmdOk.Visible = False
        End If
        fillcombo()
        Me.Text = StrConv(formtype, VbStrConv.ProperCase)
        txtCharges.Focus()
    End Sub
    Public Sub fillcombo()
        Dim dt As DataTable = dbTable("select Id,Ledger from mLedger order by Ledger")
        With cboLedger
            .DataSource = dt
            .DisplayMember = "Ledger"
            .ValueMember = "id"
        End With
        If mode <> enEntry.Add Then
            For i1 = 1 To dt.Rows.Count() - 1
                If dt.Rows(i1).Item(0).ToString = sId.ToString Then
                    cboLedger.SelectedIndex = i1
                    Exit For
                End If
            Next
            Select Case cboRateon.Text
                Case Is = "1"
                    cboRateon.SelectedIndex = 0
                Case Is = "2"
                    cboRateon.SelectedIndex = 1
                Case Is = "3"
                    cboRateon.SelectedIndex = 2
                Case Is = "4"
                    cboRateon.SelectedIndex = 3
            End Select
        Else
            cboLedger.SelectedIndex = 0
        End If
    End Sub
End Class

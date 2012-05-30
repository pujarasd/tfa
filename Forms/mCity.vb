Imports System.Windows.Forms
Imports system.Data.SqlClient
Imports System.Configuration
Public Class mCity
    Friend mode As enEntry
    Friend id As Integer
    Friend formtype As String
    Friend CityType As String
    Public sId As Integer = 0
    Private Sub mCity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
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
        If mode <> enEntry.Add Then
            Select Case formtype
                Case "city"
                    Dim dt As DataTable
                    dt = dbTable("select city,StateId,cType from mcity where id=" & id)
                    txtCity.Text = dt.Rows(0)(0).ToString
                    sId = dt.Rows(0)(1).ToString
                   
                    'txtCity.Text = dbValue("select city from mcity where id=" & id)
                    'sId = dbValue("select Stateid from mcity where id=" & id)
            End Select
            txtCity.Tag = txtCity.Text
            cboState.Tag = cboState.Text
        End If
        If mode = enEntry.Delete Or mode = enEntry.View Then
            txtCity.Enabled = False
        End If
        If mode = enEntry.Delete Then cmdOk.Text = "&Delete"
        If mode = enEntry.View Then
            cmdCancel.Text = "Ok"
            cmdOk.Visible = False
        End If
        lblCity.Text = StrConv(formtype, VbStrConv.ProperCase)
        Me.Text = StrConv(formtype & " " & CityType, VbStrConv.ProperCase)
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
        Select Case formtype
            Case "city"
                fldid = "id"
                fldtext = "city"
                tblname = "mcity"
        End Select
        Dim strqry As String = ""
        If mode = enEntry.Add Then
            strqry = "Select " & fldid & " FROM " & tblname & " where " & fldtext & " = '" & txtCity.Text.Trim & "' and ctype='" & citytype & "'"
            If nz(dbvalue(strqry), 0) > 0 Then
                Ep1.SetError(txtCity, "Duplicate!")
                Exit Sub
            Else
                Ep1.SetError(txtCity, "")
                strqry = "insert into " & tblname & " (" & fldtext & ",Stateid,IsActive,CountryId,cType ) values ('" & proper(txtCity.Text.Replace("'", "''")) & "'," & cboState.SelectedValue & ", " & 1 & "," & 0 & ",'" & CityType & "' )"
            End If
        ElseIf mode = enEntry.Edit Then
            strqry = "Select " & fldid & " FROM " & tblname & " where " & fldtext & " = '" & txtCity.Text.Trim & "' and cType = '" & CityType & " ' And id<>" & id
            If nz(dbValue(strqry), 0) > 0 Then
                Ep1.SetError(txtCity, "Duplicate!")
                Exit Sub
            Else
                Ep1.SetError(txtCity, "")
            End If
            strqry = "update " & tblname & " set " & fldtext & " ='" & proper(txtCity.Text.Replace("'", "''")) & "'"
            strqry &= " ,Stateid = " & cboState.SelectedValue & ""
            strqry &= " ,cType = '" & CityType & "'"
            strqry &= " where " & fldid & "= " & id
        ElseIf mode = enEntry.Delete Then
            If MsgBox("Are you sure?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                strqry = "delete " & tblname & " "
                strqry &= " where " & fldid & " = " & id
            End If
        Else
        End If
        If dbUpdate(New String() {strqry}) = True Then
            If mode = enEntry.Add Then id = dbValue("select Max(id) from mcity")
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
        Dim dt As DataTable = dbTable("select Id,State from mState where isactive = 1 order by State  ")
        With cboState
            .DataSource = dt
            .DisplayMember = "State"
            .ValueMember = "id"
        End With
     

        If mode <> enEntry.Add Then
            For i1 = 1 To dt.Rows.Count() - 1
                If dt.Rows(i1).Item(0).ToString = sId.ToString Then
                    cboState.SelectedIndex = i1
                    Exit For
                End If
            Next
          
            'Select Case cboType.Text
            '    Case Is = "To"
            '        cboType.SelectedIndex = enCityType.ToCity
            '    Case Is = "From"
            '        cboType.SelectedIndex = enCityType.FromCity
            '    Case Is = "Payable At"
            '        cboType.SelectedIndex = enCityType.PayableAtCity
            'End Select
        Else
            cboState.SelectedIndex = 0
        End If

    End Sub
End Class

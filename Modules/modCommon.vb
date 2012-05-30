Imports System.Text.RegularExpressions

Module modCommon
    Public Function digitonly(ByVal strIn As String) As String
        Return Regex.Replace(strIn, "\D", "")
    End Function
    Public Function CleanInput(ByVal strIn As String) As String
        ' Replace invalid characters with empty strings.
        Return Regex.Replace(strIn, "[^\w\.@-]", "")
    End Function
    Public Function MDYToDMY(ByVal input As String) As String
        Return Regex.Replace(input, _
            "\b(?<month>\d{1,2})/(?<day>\d{1,2})/(?<year>\d{2,4})\b", _
            "${day}-${month}-${year}")
    End Function
    Public Function DMYToMDY(ByVal input As String) As String
        Return Regex.Replace(input, _
            "\b(?<day>\d{1,2})/(?<month>\d{1,2})/(?<year>\d{2,4})\b", _
            "${month}-${day}-${year}")
    End Function
    Public Function sqldate(ByVal input As String) As String
        Dim returnstring As String = input
        Try
            returnstring = String.Format("{0:yyyy/MMM/dd}", DateTime.Parse(input))
        Catch
        End Try
        Return returnstring
    End Function
    Public Function addbs(ByVal foldername As String) As String
        If foldername.EndsWith("\") Then Return foldername
        Return foldername & "\"

    End Function

    Public Sub dgvdefault(ByVal dgv As DataGridView)
        With dgv
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .AutoGenerateColumns = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .MultiSelect = False
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .EditMode = DataGridViewEditMode.EditProgrammatically
        End With
    End Sub
    Public Function proper(ByVal str) As String
        Return StrConv(str, VbStrConv.ProperCase)
    End Function
    Public Function nz(ByVal source As Object, ByVal retvalue As Object) As Object
        If source Is Nothing Then Return retvalue
        If IsDBNull(source) Then Return retvalue
        If source.ToString = String.Empty Then Return retvalue
        Return source
    End Function
    Public Function curyearstartdate() As Date
        Dim y As Int16 = Now.Year
        Dim m As Int16 = Now.Month
        If m > 4 Then y = y Else y = y - 1
        Return CDate(y & "-" & "April-01")
    End Function
    Public Sub fill_combocommon(ByVal combo As ComboBox, ByVal qry As String, ByVal display As String, ByVal value As String)
        Try
            combo.Items.Clear()
        Catch
            combo.DataSource = Nothing
        End Try

        Dim dt As DataTable
        Dim row As DataRow
        dt = dbTable(qry)
        SetDefaultClearNull(dt)
        If dt.Rows.Count > 0 Then
            row = dt.NewRow
            row(display) = "(Add New)"
            row(value) = -1
            dt.Rows.InsertAt(row, 0)
            row = dt.NewRow
            row(display) = "(Select)"
            row(value) = 0
            dt.Rows.InsertAt(row, 0)
            combo.DataSource = dt
            combo.DisplayMember = display
            combo.ValueMember = value
            combo.SelectedIndex = 0

        Else
            combo.Items.Add(New cbItem(0, "(Select)"))
            combo.Items.Add(New cbItem(-1, "(Add New)"))

            combo.DisplayMember = "display"
            combo.ValueMember = "value"
            combo.SelectedIndex = 0
        End If

    End Sub

    Function getcombo(ByVal frm As Form, Optional ByVal ctl As Control = Nothing) As Boolean
        If ctl Is Nothing Then
            For Each ctl1 As Control In frm.Controls
                If TypeOf ctl1 Is ContainerControl Then
                    getcombo(frm, ctl1)
                ElseIf TypeOf ctl1 Is ComboBox Then
                    Dim cmb As ComboBox = ctl1
                    If cmb.Items(0) = "(new)" Then
                        Return True
                    Else
                        Return False

                    End If

                End If
            Next
        Else
            For Each ctl1 As Control In ctl.Controls
                If TypeOf ctl1 Is ContainerControl Then
                    getcombo(frm, ctl1)
                ElseIf TypeOf ctl1 Is ComboBox Then
                    Dim cmb As ComboBox = ctl1
                    If cmb.Items(0) = "(new)" Then
                        Return True
                    Else
                        Return False

                    End If

                End If
            Next
        End If
    End Function
End Module

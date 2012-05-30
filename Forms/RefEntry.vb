Imports System.Windows.Forms

Public Class RefEntryold
    Friend accId As Integer = 0
    Friend dataid As Integer = 0
    Friend lineid As Integer = 0
    Friend adj_amt As Double = 0
    Friend refdate As Date
    Friend type As String
    Friend RefNo As String
    Friend dtref As DataTable

    Dim to_be_adj As Double = 0
    Dim adjusted As Double = 0
    Dim dtref1 As DataTable
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel

        Me.Close()
    End Sub

    Private Sub RefEntry_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetDefaultClearNull(dtref)
        NumAdjAmt.value = adj_amt
        numAdjusted.value = adjusted
        NumUnAdjusted.value = adj_amt - adjusted
        lblAdjDrcr.Text = type
        dgvdefault(dgv)
        With dgv
            .AutoGenerateColumns = False
            .Columns.Add("RefType", "Ref.Type") '' column 0
            .Columns.Add("RefNo", "Ref.No.") '' column 1
            .Columns.Add("Period", "Period") '' column 2
            .Columns.Add("RefDate", "Ref.Date") '' column 3
            .Columns.Add("Amount", "Amount") '' column 4
            .Columns.Add("type", "") '' column 5
            .Columns.Add("DataId", "") '' column 6
            .Columns.Add("LineId", "") '' column 7
            .Columns.Add("AccId", "") '' column 8

            With .Columns("Type")
                .Width = 50
            End With
            With .Columns("RefType")
                .Width = 50

            End With
            With .Columns("Refno")
                .Width = 100

            End With
            With .Columns("RefDate")
                .Width = 80

                .DefaultCellStyle.Format = "d"
            End With
            With .Columns("Amount")
                .Width = 100

                .DefaultCellStyle.Format = "f2"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End With
            With .Columns("Period")

                .Width = 50
            End With
            With .Columns("DataId")

                .Visible = False
            End With
            With .Columns("LineId")

                .Visible = False
            End With
            With .Columns("AccId")

                .Visible = False
            End With
        End With
        Dim drow As DataGridViewRow
        If dtref.Rows.Count > 0 Then

            For Each row As DataRow In dtref.Rows
                drow = New DataGridViewRow
                drow.Cells("RefType").Value = row("Reftype")
                drow.Cells("Refno").Value = row("Refno")
                drow.Cells("Period").Value = row("Period")
                drow.Cells("RefDate").Value = row("RefDate")
                drow.Cells("Amount").Value = row("Amount")
                drow.Cells("DataId").Value = row("DataId")
                drow.Cells("LineId").Value = row("LineId")
                drow.Cells("AccId").Value = row("AccId")
                dgv.Rows.Add(drow)
            Next
        Else
            dtref1 = dbTable("Select refno,period,sum(case [type] when 'Dr' then -amount else amount end ) from trefdata  where accid =" & accId & " And COID = " & gCoId & "group by refno,period")
            If dtref1.Rows.Count = 0 Then
                cmbRefType.SelectedItem = "New"
                txtRefNo.Text = RefNo
                NumAmount.value = adj_amt
                cmbType.SelectedItem = type
            Else
                cmbRefNo.DataSource = dtref1
                cmbRefNo.ValueMember = "refno"
                cmbRefNo.DisplayMember = "refno & Period"
                cmbRefType.SelectedValue = "Against"
            End If



        End If
        If cmbRefType.SelectedItem = "Against" Then
            cmbRefNo.Visible = True
            txtRefNo.Visible = False
        Else
            cmbRefNo.Visible = False
            txtRefNo.Visible = True
        End If
        'Bs.DataSource = dtref
        'With dgv
        '    
        '    .RowHeadersVisible = True
        '    .RowHeadersWidth = 30
        '    .EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
        '    .SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
        '    .AutoGenerateColumns = False

        '    '' column 0
        '    Dim cb As New DataGridViewComboBoxColumn
        '    With cb
        '        .Name = "Reftype"
        '        .HeaderText = "Ref.Type"
        '        .Items.Add("Against")
        '        .Items.Add("New")
        '        .Items.Add("OnAcc")
        '        .Items.Add("Advance")
        '    End With
        '    .Columns.Add(cb)


        '    .Columns.Add("RefNo", "RefNo") '' column 1
        '    .Columns.Add("Period", "Period") '' column 2
        '    .Columns.Add("RefDate", "Ref.Date") '' column 3
        '    .Columns.Add("Amount", "Amount") '' column 4
        '    .Columns.Add("DataId", "") '' column 5
        '    .Columns.Add("LineId", "") '' column 6
        '    .Columns.Add("AccId", "") '' column 7

        '    cb = New DataGridViewComboBoxColumn
        '    With cb
        '        .Name = "Type"
        '        .HeaderText = ""
        '        .Items.Add("Dr")
        '        .Items.Add("Cr")
        '    End With
        '    .Columns.Add(cb)
        '    With .Columns("Type")
        '        .DataPropertyName = "type"
        '    End With
        '    With .Columns("RefType")
        '        .Width = 100
        '        .DataPropertyName = "Reftype"

        '    End With
        '    With .Columns("Refno")
        '        .Width = 100
        '        .DataPropertyName = "Refno"


        '    End With
        '    With .Columns("RefDate")
        '        .Width = 80
        '        .DataPropertyName = "RefDate"
        '        .DefaultCellStyle.Format = "d"
        '    End With
        '    With .Columns("Amount")
        '        .Width = 100
        '        .DataPropertyName = "Amount"
        '        .DefaultCellStyle.Format = "f2"
        '        .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '    End With
        '    With .Columns("Period")
        '        .DataPropertyName = "Period"
        '        .Width = 10
        '    End With
        '    With .Columns("DataId")
        '        .DataPropertyName = "DataId"
        '        .Visible = False
        '    End With
        '    With .Columns("LineId")
        '        .DataPropertyName = "LineId"
        '        .Visible = False
        '    End With
        '    With .Columns("AccId")
        '        .DataPropertyName = "AccId"
        '        .Visible = False
        '    End With
        'End With
        'If Bs.Count = 0 Then
        '    dtref1 = dbTable("Select * from trefdata where accid = " & accId & " And COID = " & gCoId)
        '    If dtref1.Rows.Count = 0 Then
        '        Bs.AddNew()
        '        Bs.Current("AccId") = accId
        '        Bs.Current("DataId") = dataid
        '        Bs.Current("LineId") = lineid

        '        Bs.Current("RefNo") = RefNo
        '        Bs.Current("RefType") = "New"
        '        Bs.Current("RefDate") = refdate
        '        Bs.Current("Amount") = adj_amt
        '        Bs.Current("Type") = type
        '        Bs.Current("Period") = gPeriod
        '        Bs.Current("CoId") = gCoId
        '        Bs.EndEdit()
        '        adjusted = adj_amt
        '    Else
        '        Bs.AddNew()
        '        Bs.Current("AccId") = accId
        '        Bs.Current("DataId") = dataid
        '        Bs.Current("LineId") = lineid

        '        Bs.Current("RefNo") = "" 'RefNo
        '        Bs.Current("RefType") = "" '"New"
        '        Bs.Current("RefDate") = Now.Date  'refdate
        '        Bs.Current("Amount") = 0 'adj_amt
        '        Bs.Current("Type") = IIf(type = "Dr", "Cr", "Dr") 'type
        '        Bs.Current("Period") = gPeriod
        '        Bs.Current("CoId") = gCoId
        '        Bs.EndEdit()
        '        'adjusted = adj_amt
        '    End If

        'End If
        'dgv.DataSource = Bs
        'dgv.AutoResizeColumns()
        '' If type = "Dr" Then adj_amt = -adj_amt


    End Sub



    'Private Sub dgv_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEndEdit
    '    If e.ColumnIndex = 0 Then

    '        If dgv(0, e.RowIndex).Value = "Against" Then

    '        End If
    '    ElseIf e.ColumnIndex = 1 Then
    '        If dgv(0, e.RowIndex).Value = "Against" And dgv(1, e.RowIndex).Value = "" Then

    '        End If
    '    End If
    'End Sub

    'Private Sub dgv_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgv.DefaultValuesNeeded
    '    e.Row.Cells("LineId").Value = lineid
    '    e.Row.Cells("DataId").Value = dataid
    '    e.Row.Cells("Accid").Value = accId
    '    e.Row.Cells("RefNo").Value = ""
    '    e.Row.Cells("Period").Value = gPeriod
    '    e.Row.Cells("Amount").Value = 0
    '    CType(e.Row.Cells("Type"), DataGridViewComboBoxCell).Value = "Dr"

    'End Sub

    'Private Sub dgv_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgv.CellValidating
    '    If e.ColumnIndex = 0 Then

    '    End If
    'End Sub

    'Private Sub dgv_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgv.EditingControlShowing
    '    If dgv.CurrentCell.ColumnIndex = 1 Then
    '        If dgv(0, dgv.CurrentCell.RowIndex).Value = "Against" Then
    '            Dim tb As TextBox = e.Control
    '            tb.AutoCompleteSource = AutoCompleteSource.CustomSource
    '            tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    '            If dtref1.Rows.Count > 0 Then
    '                Dim autostr As New List(Of String)

    '                For Each row In dtref1.Rows
    '                    autostr.Add(" " & row("RefNo") & " | " & row("RefDate") & " | " & row("Amount"))
    '                Next
    '                tb.AutoCompleteCustomSource.AddRange(autostr.ToArray)
    '            End If
    '        End If

    '    End If
    'End Sub




    'Private Sub dgv_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.RowValidated
    '    Dim amt As Double
    '    For Each row As DataGridViewRow In dgv.Rows
    '        If type = "Dr" Then
    '            amt = amt + IIf((row.Cells("Type").Value = "Dr"), row.Cells("Amount").Value, -row.Cells("Amount").Value)
    '        Else
    '            amt = amt + IIf((row.Cells("Type").Value = "Dr"), -row.Cells("Amount").Value, row.Cells("Amount").Value)
    '        End If

    '    Next
    '    adjusted = amt
    '    NumAdjAmt.value = adjusted
    '    NumUnAdjusted.value = adj_amt - adjusted



    'End Sub


    Private Sub cmbRefType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbRefType.SelectedIndexChanged
        Select Case cmbRefType.SelectedItem
            Case "Against"
                cmbRefNo.Visible = True
                txtRefNo.Visible = False
                cmbRefNo.DataSource = dtref1
                cmbRefNo.ValueMember = "refno"
                cmbRefNo.DisplayMember = "refno & Period"

            Case "New", "Advance"
                cmbRefNo.Visible = False
                txtRefNo.Visible = True

                txtRefNo.Text = RefNo
                NumAmount.value = adj_amt
                cmbType.SelectedItem = type
            Case Else
                cmbRefNo.Visible = False
                txtRefNo.Visible = False
                NumAmount.value = adj_amt
                cmbType.SelectedItem = type
        End Select

    End Sub
End Class

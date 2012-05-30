Imports System.Windows.Forms

Public Class RefEntry
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

                'NumAmount.value = adj_amt
                'cmbType.SelectedItem = type
            Else
                'cmbRefNo.DataSource = dtref1
                'cmbRefNo.ValueMember = "refno"
                'cmbRefNo.DisplayMember = "refno & Period"
                cmbRefType.SelectedItem = "Against"
            End If



        End If
      
        


    End Sub
    Private Sub cmbRefType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbRefType.SelectedValueChanged
        Select Case cmbRefType.SelectedItem
            Case "Against"
                cmbRefNo.Visible = True

                cmbRefNo.DataSource = dtref1
                cmbRefNo.ValueMember = "refno"
                cmbRefNo.DisplayMember = "refno & Period"

            Case "New", "Advance"
                cmbRefNo.Text = RefNo
                NumAmount.value = adj_amt
                cmbType.SelectedItem = type
            Case Else

                NumAmount.value = adj_amt
                cmbType.SelectedItem = type
        End Select
    End Sub

    Private Sub cmbRefType_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbRefType.Validating
       

    End Sub

    Private Sub cmbRefNo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbRefNo.Validating
        If ActiveControl.Name <> "btnCancel" Then
            If cmbRefType.SelectedItem = "Against" Then
                If cmbRefNo.SelectedIndex = -1 Then
                    MsgBox("Please Select Ref.No.")
                    e.Cancel = True

                End If
            End If
        End If

    End Sub
End Class

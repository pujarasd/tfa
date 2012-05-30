Imports System.Windows.Forms

Public Class Period

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If dtpTo.Value < dtpFrom.Value Then
            MessageBox.Show("To Date can not be less than from date", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.dtpTo.Focus()
            Exit Sub
        End If
        gFinEndDate = dtpTo.Value
        gFinStartDate = dtpFrom.Value
        gPeriod = Year(gFinStartDate) & "-" & Year(gFinEndDate)

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

  
    Private Sub Period_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.dtpFrom.Value = gFinStartDate
        Me.dtpTo.Value = gFinEndDate
    End Sub

  

    Private Sub dtpFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFrom.ValueChanged
        With dtpFrom
            If .Value.Month > 3 Then
                'dtpTo.MaxDate = CDate("31/03/" & dtpFrom.Value.Year + 1)
                'dtpTo.MinDate = CDate("31/03/" & dtpFrom.Value.Year + 1)

                dtpTo.Value = CDate("31/03/" & dtpFrom.Value.Year + 1)

            Else
                'dtpTo.MinDate = CDate("31/03/" & dtpFrom.Value.Year)
                'dtpTo.MaxDate = CDate("31/03/" & dtpFrom.Value.Year)

                dtpTo.Value = CDate("31/03/" & dtpFrom.Value.Year)
            End If
          
        End With
    End Sub

   
End Class

Imports System.Windows.Forms
Imports System.Data.OleDb
Public Class Register

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Register_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.BringToFront()
        Me.Focus()
        lblSrNo.Text = getsrno()
        Dim dt As DataTable = getactrecord()
        Dim row As DataRow
        If dt.Rows.Count > 0 Then
            row = dt.Rows(0)
            If IsDBNull(row("startdate")) Then
                updateactstartdate(Now.Date)
                dt.Rows(0)("startdate") = Now.Date
            End If
            Dim days As TimeSpan
            '      If IsDBNull(row("todate")) Then updateacttodate()
            If nz(row("todate"), Now.Date) > Now.Date Then
                MsgBox("Application can not run in backdate", 0, "System Date Changed")
                OK_Button.Enabled = False

            Else
                days = (Now.Date - DateTime.Parse(row("startdate")))
                If Not days.Days <= 30 Then
                    MsgBox("Evaluation Period Over", 0, Text)

                End If
                updateacttodate()
            End If

            lblevaluation.Text = 30 - days.Days - 1 & " Days Left"

        End If
        dt = Nothing
    End Sub


    Private Sub btnActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivate.Click
        If txtActivation.Text = "" Then
            msgErr.SetError(txtActivation, "Enter Activation Number")
            Exit Sub
        Else
            msgErr.SetError(txtActivation, "")
        End If
        If Not checkreg(txtActivation.Text) Then
            msgErr.SetError(txtActivation, "Activation Number not match")

            Exit Sub
        Else
            OK_Button_Click(sender, e)
        End If
    End Sub
End Class

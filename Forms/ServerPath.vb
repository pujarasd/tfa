Imports System.Windows.Forms
Imports System.Configuration
Public Class ServerPath

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Not IO.File.Exists(addbs(lblServerPath.Text) & "Accounts.mdf") Then
            MsgBox("Invalid Folder")
            Exit Sub
        End If
        Dim conf As Configuration
        conf = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath)
        If lblServerPath.Text.Trim = "" Then
            MsgBox("Please select valid server path")
            Exit Sub
        End If
        gDataPath = addbs(lblServerPath.Text)
        gReportPath = addbs(lblServerPath.Text) & "Report\"
        conf.AppSettings.Settings.Item("serverpath").Value = lblServerPath.Text

        conf.Save(ConfigurationSaveMode.Modified)

        Application.Restart()


        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ServerPath_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim conf As Configuration
        conf = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath)

        Dim serverpath As String = ""
        Try
            serverpath = conf.AppSettings.Settings("ServerPath").Value
        Catch ex As Exception

        End Try


        If serverpath = "" Then
            btnBrowse_Click(sender, e)
        Else
            Me.lblServerPath.Text = serverpath
        End If

    End Sub

    Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Fbd.ShowDialog()
        If IO.Directory.Exists(Fbd.SelectedPath) Then
            Dim ServerPath As String = addbs(Fbd.SelectedPath)
            ServerPath = addbs(ServerPath)
            If Not IO.File.Exists(ServerPath & "Accounts.mdf") Then
                MsgBox("Invalid Folder")
                Exit Sub
            End If
            lblServerPath.Text = ServerPath
        End If
    End Sub

End Class

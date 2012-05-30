Imports System.Windows.Forms
''Imports Account.AccountsDataSetTableAdapters
Imports System.Configuration
Public Class Login
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try

            ep.SetError(txtpassword, "")
            ep.SetError(txtuser, "")
            If txtuser.Text.Trim.Length = 0 Then
                ep.SetError(txtuser, "Please enter User Name")
            End If
            If txtpassword.Text.Trim.Length = 0 Then
                ep.SetError(txtpassword, "Please, enter password")

            End If

            Dim dt As DataTable = dbTable("select * from musers where username = '" & txtuser.Text & "'")

            If dt.Rows.Count > 0 Then
                Dim dr As DataRow = dt.Rows(0)
                If Not dr("IsActive") Then
                    ep.SetError(txtuser, "User not active! Contact Administrator.")
                    Exit Sub
                End If
                If txtpassword.Text.ToLower = dr("Password").ToString.ToLower Then
                    gUserId = dr("id")
                    gUserName = dr("UserName")
                    gAdmin = dr("IsAdmin")
                    gMasterAdd = dr("ismasteradd")
                    gMasterEdit = dr("ismasteredit")
                    gMasterDelete = dr("ismasterdelete")
                    gMasterView = dr("ismasterview")
                    gVoucherAdd = dr("isvoucheradd")
                    gVoucherEdit = dr("isvoucheredit")
                    gVoucherDelete = dr("isvoucherdelete")
                    gVoucherView = dr("isvoucherview")
                    gBs = dr("isbalancesheet")
                    gPL = dr("ispl")
                    gTb = dr("istrial")
                Else
                    ep.SetError(txtpassword, "Password not match!")
                    Exit Sub
                End If

            Else
                ep.SetError(txtuser, "User Not Exist!")
                Exit Sub
            End If

            '' Open App.Config of executable
            If ConfigurationManager.AppSettings("") = txtuser.Text And ConfigurationManager.AppSettings("") = txtpassword.Text Then
            Else
                Dim myconfig As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(addbs(My.Application.Info.DirectoryPath) & My.Application.Info.AssemblyName & ".exe.config")

                '' Add an Application Setting.

                '   myconfig.AppSettings.Settings.Remove("LastUserName")
                If chkRememberMe.Checked Then
                    If chkRememberMe.Checked Then
                        myconfig.AppSettings.Settings("LastUserName").Value = txtuser.Text
                        myconfig.AppSettings.Settings("LastPassword").Value = txtpassword.Text
                    Else
                        myconfig.AppSettings.Settings("LastUserName").Value = ""
                        myconfig.AppSettings.Settings("LastPassword").Value = ""
                    End If



                    '' Save the configuration file.

                    myconfig.Save(ConfigurationSaveMode.Modified)
                    myconfig.Save()
                    '' Force a reload of a changed section.

                    ConfigurationManager.RefreshSection("appSettings")

                End If


            End If



            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If ConfigurationManager.AppSettings("LastUserName") IsNot Nothing Then
            txtuser.Text = ConfigurationManager.AppSettings("LastUserName")
        End If
        If ConfigurationManager.AppSettings("LastPassword") IsNot Nothing Then
            txtpassword.Text = ConfigurationManager.AppSettings("LastPassword")
        End If
    End Sub
    Private Sub txtuser_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuser.LostFocus
        txtuser.Text = StrConv(txtuser.Text, VbStrConv.ProperCase)
    End Sub
End Class

Imports Account.AccountsDataSetTableAdapters
Public Class CompanyData
    Friend mode As enDatamode
    Friend id As Integer
    '   Dim da As New mCompanyTableAdapter
    Dim dt As DataTable
    Dim dr As DataRow

    Private Sub CompanyData_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Back)
            Case ChrW(Keys.Enter)
                If TypeOf Me.ActiveControl Is TextBox Then
                    If CType(Me.ActiveControl, TextBox).Multiline = True Then
                        Exit Sub
                    End If
                ElseIf TypeOf Me.ActiveControl Is Button Then
                    Exit Sub
                End If
                SendKeys.Send("{Tab}")
        End Select
    End Sub
    Private Sub CompanyData_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Select Case mode
            Case enDatamode.Add
                Fill_Blank()
            Case enDatamode.Edit, enDatamode.Delete
                Fill_Controls()
        End Select

    End Sub

    Private Sub Fill_Blank()
        For Each ctl As Control In Me.Controls
            If ctl Is Container Then
                Fill_Child_Blank(ctl)
            Else
                If TypeOf ctl Is TextBox Then
                    ctl.Text = ""
                ElseIf TypeOf ctl Is ComboBox Then
                    CType(ctl, ComboBox).SelectedIndex = 0
                ElseIf TypeOf ctl Is DateTimePicker Then
                    CType(ctl, DateTimePicker).Value = Now().Date
                End If
            End If
        Next
        FY_StartDateTimePicker.Text = "01/04/" & IIf(Now.Month > 4, Now.Year, Now.Year - 1)
        Book_StartDateTimePicker.Value = FY_StartDateTimePicker.Value
    End Sub
    Private Sub Fill_Child_Blank(ByVal ctl As Control)
        For Each ctl1 As Control In ctl.Controls
            If ctl1 Is Container Then
                Fill_Child_Blank(ctl1)
            Else
                If TypeOf ctl1 Is TextBox Then
                    ctl1.Text = ""
                ElseIf TypeOf ctl1 Is ComboBox Then
                    CType(ctl1, ComboBox).SelectedIndex = 0
                ElseIf TypeOf ctl Is DateTimePicker Then
                    CType(ctl1, DateTimePicker).Value = Now().Date
                End If
            End If
        Next
    End Sub
    Private Sub Fill_Controls()
        'dt = da.GetDataById(id)
        dt = dbTable("select * from mcompany where id = " & id)
        If dt.Rows.Count = 0 Then
            MessageBox.Show("No Company Exist!!", Me.Text)
        End If
        dr = dt.Rows(0)
        With dr
            Me.IdTextBox.Text = .Item("id")
            Me.CompanyTextBox.Text = .Item("Company")
            Me.FY_StartDateTimePicker.Value = .Item("FY_Start")
            Me.Book_StartDateTimePicker.Value = .Item("Book_Start")
            Me.AddressTextBox.Text = .Item("Address")
            Me.CountryTextBox.Text = .Item("Country")
            Me.PinTextBox.Text = .Item("Pin")
            Me.PhoneTextBox.Text = .Item("Phone")
            Me.FaxTextBox.Text = .Item("Fax")
            Me.MobileTextBox.Text = .Item("Mobile")
            Me.PANTextBox.Text = .Item("PAN")
            Me.TANTextBox.Text = .Item("TAN")
            Me.TINTextBox.Text = .Item("TIN")
            Me.MINTextBox.Text = .Item("MIN")
            Me.VATTextBox.Text = .Item("VAT")
            Me.LSTTextBox.Text = .Item("LST")
            Me.CSTTextBox.Text = .Item("CST")
            Me.EXCISETextBox.Text = .Item("EXCISE")
            Me.SERVICETAXTextBox.Text = .Item("SERVICETAX")
            Me.PROFTAXTextBox.Text = .Item("PROFTAX")
            Me.PF_NOTextBox.Text = .Item("PF_NO")
            Me.ESIC_NOTextBox.Text = .Item("ESIC_NO")
            Me.MAIN_SIGN_NAMETextBox.Text = .Item("MAIN_SIGN_NAME")
            Me.MAIN_SIGN_DESGTextBox.Text = .Item("MAIN_SIGN_DESG")
            Me.AUTH_SIGN_NAMETextBox.Text = .Item("AUTH_SIGN_NAME")
            Me.AUTH_SIGN_DESGTextBox.Text = .Item("AUTH_SIGN_DESG")
            Me.StateTextBox.Text = .Item("State")
            Me.CityTextBox.Text = .Item("City")
            Me.BankDetailTextbox.Text = .Item("BankDetail")
        End With
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim qstr As String = ""
        If mode = enDatamode.Add Then
            qstr = <string>
insert into mcompany values(
          '<%= Me.CompanyTextBox.Text %>' ,
          '<%= sqldate(Me.FY_StartDateTimePicker.Value) %>' ,
          '<%= sqldate(Me.Book_StartDateTimePicker.Value) %>' ,
           '<%= Me.AddressTextBox.Text %>' ,
           '<%= Me.CityTextBox.Text %>' ,
           '<%= Me.StateTextBox.Text %>' ,
          '<%= Me.CountryTextBox.Text %>' ,
           '<%= Me.PinTextBox.Text %>' ,
           '<%= Me.PhoneTextBox.Text %>' ,
            '<%= Me.FaxTextBox.Text %>' ,
         '<%= Me.MobileTextBox.Text %>' ,
          '<%= Me.PANTextBox.Text %>' ,
           '<%= Me.TANTextBox.Text %>' ,
           '<%= Me.TINTextBox.Text %>' ,
           '<%= Me.MINTextBox.Text %>' ,
       '<%= Me.VATTextBox.Text %>' ,
           '<%= Me.LSTTextBox.Text %>' ,
         '<%= Me.CSTTextBox.Text %>' ,
          '<%= Me.EXCISETextBox.Text %>' ,
         '<%= Me.SERVICETAXTextBox.Text %>' ,
        '<%= Me.PROFTAXTextBox.Text %>' ,
        '<%= Me.PF_NOTextBox.Text %>' ,
       '<%= Me.ESIC_NOTextBox.Text %>' ,
        '<%= Me.MAIN_SIGN_NAMETextBox.Text %>' ,
         '<%= Me.MAIN_SIGN_DESGTextBox.Text %>' ,
          '<%= Me.AUTH_SIGN_NAMETextBox.Text %>' ,
          '<%= Me.AUTH_SIGN_DESGTextBox.Text %>',
          '<%= Me.BankDetailTextbox.Text %>')</string>
        ElseIf mode = enDatamode.Edit Then
            qstr = <String> update mcompany set 
            Company = '<%= Me.CompanyTextBox.Text %>',
            FY_Start = '<%= Me.FY_StartDateTimePicker.Value %>',
            Book_Start = '<%= Me.Book_StartDateTimePicker.Value %>',
            Address = '<%= Me.AddressTextBox.Text %>',
            Country = '<%= Me.CountryTextBox.Text %>',
            Pin = '<%= Me.PinTextBox.Text %>',
            Phone = '<%= Me.PhoneTextBox.Text %>',
            Fax = '<%= Me.FaxTextBox.Text %>',
            Mobile = '<%= Me.MobileTextBox.Text %>',
            PAN = '<%= Me.PANTextBox.Text %>',
            TAN = '<%= Me.TANTextBox.Text %>',
            TIN = '<%= Me.TINTextBox.Text %>',
            MIN = '<%= Me.MINTextBox.Text %>',
            VAT = '<%= Me.VATTextBox.Text %>',
            LST = '<%= Me.LSTTextBox.Text %>',
            CST = '<%= Me.CSTTextBox.Text %>',
            EXCISE = '<%= Me.EXCISETextBox.Text %>',
            SERVICETAX = '<%= Me.SERVICETAXTextBox.Text %>',
            PROFTAX = '<%= Me.PROFTAXTextBox.Text %>',
            PF_NO = '<%= Me.PF_NOTextBox.Text %>',
            ESIC_NO = '<%= Me.ESIC_NOTextBox.Text %>',
            MAIN_SIGN_NAME = '<%= Me.MAIN_SIGN_NAMETextBox.Text %>',
            MAIN_SIGN_DESG = '<%= Me.MAIN_SIGN_DESGTextBox.Text %>',
            AUTH_SIGN_NAME = '<%= Me.AUTH_SIGN_NAMETextBox.Text %>',
            AUTH_SIGN_DESG = '<%= Me.AUTH_SIGN_DESGTextBox.Text %>',
            State = '<%= Me.StateTextBox.Text %>',
            City = '<%= Me.CityTextBox.Text %>',
            BankDetail = '<%= Me.BankDetailTextbox.Text %>'
            where id = <%= Me.IdTextBox.Text %></String>
        ElseIf mode = enDatamode.Delete Then
            qstr = <string>delete mcompany where id = 
            <%= Me.IdTextBox.Text %></string>
        End If
        If dbUpdate(New String() {qstr}) Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub
    Private Sub CompanyTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CompanyTextBox.LostFocus
        CompanyTextBox.Text = StrConv(CompanyTextBox.Text, VbStrConv.ProperCase)
    End Sub

End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompanyData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim IdLabel As System.Windows.Forms.Label
        Dim CompanyLabel As System.Windows.Forms.Label
        Dim FY_StartLabel As System.Windows.Forms.Label
        Dim Book_StartLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim PinLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim MobileLabel As System.Windows.Forms.Label
        Dim PANLabel As System.Windows.Forms.Label
        Dim TANLabel As System.Windows.Forms.Label
        Dim TINLabel As System.Windows.Forms.Label
        Dim MINLabel As System.Windows.Forms.Label
        Dim VATLabel As System.Windows.Forms.Label
        Dim LSTLabel As System.Windows.Forms.Label
        Dim CSTLabel As System.Windows.Forms.Label
        Dim EXCISELabel As System.Windows.Forms.Label
        Dim SERVICETAXLabel As System.Windows.Forms.Label
        Dim PROFTAXLabel As System.Windows.Forms.Label
        Dim PF_NOLabel As System.Windows.Forms.Label
        Dim ESIC_NOLabel As System.Windows.Forms.Label
        Dim MAIN_SIGN_NAMELabel As System.Windows.Forms.Label
        Dim MAIN_SIGN_DESGLabel As System.Windows.Forms.Label
        Dim AUTH_SIGN_NAMELabel As System.Windows.Forms.Label
        Dim AUTH_SIGN_DESGLabel As System.Windows.Forms.Label
        Dim BankDetailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompanyData))
        Me.IdTextBox = New System.Windows.Forms.TextBox
        Me.CompanyTextBox = New System.Windows.Forms.TextBox
        Me.FY_StartDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Book_StartDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.AddressTextBox = New System.Windows.Forms.TextBox
        Me.CountryTextBox = New System.Windows.Forms.TextBox
        Me.PinTextBox = New System.Windows.Forms.TextBox
        Me.PhoneTextBox = New System.Windows.Forms.TextBox
        Me.FaxTextBox = New System.Windows.Forms.TextBox
        Me.MobileTextBox = New System.Windows.Forms.TextBox
        Me.PANTextBox = New System.Windows.Forms.TextBox
        Me.TANTextBox = New System.Windows.Forms.TextBox
        Me.TINTextBox = New System.Windows.Forms.TextBox
        Me.MINTextBox = New System.Windows.Forms.TextBox
        Me.VATTextBox = New System.Windows.Forms.TextBox
        Me.LSTTextBox = New System.Windows.Forms.TextBox
        Me.CSTTextBox = New System.Windows.Forms.TextBox
        Me.EXCISETextBox = New System.Windows.Forms.TextBox
        Me.SERVICETAXTextBox = New System.Windows.Forms.TextBox
        Me.PROFTAXTextBox = New System.Windows.Forms.TextBox
        Me.PF_NOTextBox = New System.Windows.Forms.TextBox
        Me.ESIC_NOTextBox = New System.Windows.Forms.TextBox
        Me.MAIN_SIGN_NAMETextBox = New System.Windows.Forms.TextBox
        Me.MAIN_SIGN_DESGTextBox = New System.Windows.Forms.TextBox
        Me.AUTH_SIGN_NAMETextBox = New System.Windows.Forms.TextBox
        Me.gpMainSign = New System.Windows.Forms.GroupBox
        Me.gpAuthSign = New System.Windows.Forms.GroupBox
        Me.AUTH_SIGN_DESGTextBox = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.StateTextBox = New System.Windows.Forms.TextBox
        Me.CityTextBox = New System.Windows.Forms.TextBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.BankDetailTextbox = New System.Windows.Forms.TextBox
        IdLabel = New System.Windows.Forms.Label
        CompanyLabel = New System.Windows.Forms.Label
        FY_StartLabel = New System.Windows.Forms.Label
        Book_StartLabel = New System.Windows.Forms.Label
        AddressLabel = New System.Windows.Forms.Label
        CityLabel = New System.Windows.Forms.Label
        StateLabel = New System.Windows.Forms.Label
        CountryLabel = New System.Windows.Forms.Label
        PinLabel = New System.Windows.Forms.Label
        PhoneLabel = New System.Windows.Forms.Label
        FaxLabel = New System.Windows.Forms.Label
        MobileLabel = New System.Windows.Forms.Label
        PANLabel = New System.Windows.Forms.Label
        TANLabel = New System.Windows.Forms.Label
        TINLabel = New System.Windows.Forms.Label
        MINLabel = New System.Windows.Forms.Label
        VATLabel = New System.Windows.Forms.Label
        LSTLabel = New System.Windows.Forms.Label
        CSTLabel = New System.Windows.Forms.Label
        EXCISELabel = New System.Windows.Forms.Label
        SERVICETAXLabel = New System.Windows.Forms.Label
        PROFTAXLabel = New System.Windows.Forms.Label
        PF_NOLabel = New System.Windows.Forms.Label
        ESIC_NOLabel = New System.Windows.Forms.Label
        MAIN_SIGN_NAMELabel = New System.Windows.Forms.Label
        MAIN_SIGN_DESGLabel = New System.Windows.Forms.Label
        AUTH_SIGN_NAMELabel = New System.Windows.Forms.Label
        AUTH_SIGN_DESGLabel = New System.Windows.Forms.Label
        BankDetailLabel = New System.Windows.Forms.Label
        Me.gpMainSign.SuspendLayout()
        Me.gpAuthSign.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(327, 364)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        IdLabel.Visible = False
        '
        'CompanyLabel
        '
        CompanyLabel.Location = New System.Drawing.Point(12, 15)
        CompanyLabel.Name = "CompanyLabel"
        CompanyLabel.Size = New System.Drawing.Size(55, 13)
        CompanyLabel.TabIndex = 3
        CompanyLabel.Text = "Company:"
        CompanyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FY_StartLabel
        '
        FY_StartLabel.Location = New System.Drawing.Point(12, 42)
        FY_StartLabel.Name = "FY_StartLabel"
        FY_StartLabel.Size = New System.Drawing.Size(55, 13)
        FY_StartLabel.TabIndex = 5
        FY_StartLabel.Text = "FY Start:"
        FY_StartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Book_StartLabel
        '
        Book_StartLabel.AutoSize = True
        Book_StartLabel.Location = New System.Drawing.Point(183, 41)
        Book_StartLabel.Name = "Book_StartLabel"
        Book_StartLabel.Size = New System.Drawing.Size(60, 13)
        Book_StartLabel.TabIndex = 7
        Book_StartLabel.Text = "Book Start:"
        '
        'AddressLabel
        '
        AddressLabel.Location = New System.Drawing.Point(12, 66)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(55, 13)
        AddressLabel.TabIndex = 9
        AddressLabel.Text = "Address:"
        AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CityLabel
        '
        CityLabel.Location = New System.Drawing.Point(12, 139)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(55, 13)
        CityLabel.TabIndex = 11
        CityLabel.Text = "City:"
        CityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(300, 139)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(35, 13)
        StateLabel.TabIndex = 13
        StateLabel.Text = "State:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(428, 139)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(46, 13)
        CountryLabel.TabIndex = 15
        CountryLabel.Text = "Country:"
        '
        'PinLabel
        '
        PinLabel.AutoSize = True
        PinLabel.Location = New System.Drawing.Point(179, 139)
        PinLabel.Name = "PinLabel"
        PinLabel.Size = New System.Drawing.Size(25, 13)
        PinLabel.TabIndex = 17
        PinLabel.Text = "Pin:"
        '
        'PhoneLabel
        '
        PhoneLabel.Location = New System.Drawing.Point(319, 66)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 19
        PhoneLabel.Text = "Phone:"
        '
        'FaxLabel
        '
        FaxLabel.Location = New System.Drawing.Point(319, 86)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(41, 13)
        FaxLabel.TabIndex = 21
        FaxLabel.Text = "Fax:"
        '
        'MobileLabel
        '
        MobileLabel.Location = New System.Drawing.Point(319, 106)
        MobileLabel.Name = "MobileLabel"
        MobileLabel.Size = New System.Drawing.Size(41, 13)
        MobileLabel.TabIndex = 23
        MobileLabel.Text = "Mobile:"
        '
        'PANLabel
        '
        PANLabel.Location = New System.Drawing.Point(12, 165)
        PANLabel.Name = "PANLabel"
        PANLabel.Size = New System.Drawing.Size(55, 13)
        PANLabel.TabIndex = 25
        PANLabel.Text = "PAN:"
        PANLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TANLabel
        '
        TANLabel.Location = New System.Drawing.Point(12, 187)
        TANLabel.Name = "TANLabel"
        TANLabel.Size = New System.Drawing.Size(55, 13)
        TANLabel.TabIndex = 27
        TANLabel.Text = "TAN:"
        TANLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TINLabel
        '
        TINLabel.Location = New System.Drawing.Point(12, 209)
        TINLabel.Name = "TINLabel"
        TINLabel.Size = New System.Drawing.Size(55, 13)
        TINLabel.TabIndex = 29
        TINLabel.Text = "TIN:"
        TINLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MINLabel
        '
        MINLabel.Location = New System.Drawing.Point(302, 273)
        MINLabel.Name = "MINLabel"
        MINLabel.Size = New System.Drawing.Size(67, 13)
        MINLabel.TabIndex = 31
        MINLabel.Text = "MIN:"
        '
        'VATLabel
        '
        VATLabel.Location = New System.Drawing.Point(12, 231)
        VATLabel.Name = "VATLabel"
        VATLabel.Size = New System.Drawing.Size(55, 13)
        VATLabel.TabIndex = 33
        VATLabel.Text = "VAT:"
        VATLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LSTLabel
        '
        LSTLabel.Location = New System.Drawing.Point(12, 253)
        LSTLabel.Name = "LSTLabel"
        LSTLabel.Size = New System.Drawing.Size(55, 13)
        LSTLabel.TabIndex = 35
        LSTLabel.Text = "LST:"
        LSTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CSTLabel
        '
        CSTLabel.Location = New System.Drawing.Point(12, 275)
        CSTLabel.Name = "CSTLabel"
        CSTLabel.Size = New System.Drawing.Size(55, 13)
        CSTLabel.TabIndex = 37
        CSTLabel.Text = "CST:"
        CSTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EXCISELabel
        '
        EXCISELabel.Location = New System.Drawing.Point(300, 166)
        EXCISELabel.Name = "EXCISELabel"
        EXCISELabel.Size = New System.Drawing.Size(67, 13)
        EXCISELabel.TabIndex = 39
        EXCISELabel.Text = "Excise:"
        '
        'SERVICETAXLabel
        '
        SERVICETAXLabel.Location = New System.Drawing.Point(302, 191)
        SERVICETAXLabel.Name = "SERVICETAXLabel"
        SERVICETAXLabel.Size = New System.Drawing.Size(67, 13)
        SERVICETAXLabel.TabIndex = 41
        SERVICETAXLabel.Text = "Service Tax:"
        '
        'PROFTAXLabel
        '
        PROFTAXLabel.Location = New System.Drawing.Point(302, 212)
        PROFTAXLabel.Name = "PROFTAXLabel"
        PROFTAXLabel.Size = New System.Drawing.Size(67, 13)
        PROFTAXLabel.TabIndex = 43
        PROFTAXLabel.Text = "Prof. Tax::"
        '
        'PF_NOLabel
        '
        PF_NOLabel.Location = New System.Drawing.Point(302, 232)
        PF_NOLabel.Name = "PF_NOLabel"
        PF_NOLabel.Size = New System.Drawing.Size(67, 13)
        PF_NOLabel.TabIndex = 45
        PF_NOLabel.Text = "Pf No."
        '
        'ESIC_NOLabel
        '
        ESIC_NOLabel.Location = New System.Drawing.Point(302, 253)
        ESIC_NOLabel.Name = "ESIC_NOLabel"
        ESIC_NOLabel.Size = New System.Drawing.Size(67, 13)
        ESIC_NOLabel.TabIndex = 47
        ESIC_NOLabel.Text = "Esic No:"
        '
        'MAIN_SIGN_NAMELabel
        '
        MAIN_SIGN_NAMELabel.Location = New System.Drawing.Point(7, 15)
        MAIN_SIGN_NAMELabel.Name = "MAIN_SIGN_NAMELabel"
        MAIN_SIGN_NAMELabel.Size = New System.Drawing.Size(63, 14)
        MAIN_SIGN_NAMELabel.TabIndex = 49
        MAIN_SIGN_NAMELabel.Text = "Name:"
        '
        'MAIN_SIGN_DESGLabel
        '
        MAIN_SIGN_DESGLabel.AutoSize = True
        MAIN_SIGN_DESGLabel.Location = New System.Drawing.Point(7, 35)
        MAIN_SIGN_DESGLabel.Name = "MAIN_SIGN_DESGLabel"
        MAIN_SIGN_DESGLabel.Size = New System.Drawing.Size(66, 13)
        MAIN_SIGN_DESGLabel.TabIndex = 51
        MAIN_SIGN_DESGLabel.Text = "Designation:"
        '
        'AUTH_SIGN_NAMELabel
        '
        AUTH_SIGN_NAMELabel.AutoSize = True
        AUTH_SIGN_NAMELabel.Location = New System.Drawing.Point(6, 16)
        AUTH_SIGN_NAMELabel.Name = "AUTH_SIGN_NAMELabel"
        AUTH_SIGN_NAMELabel.Size = New System.Drawing.Size(38, 13)
        AUTH_SIGN_NAMELabel.TabIndex = 53
        AUTH_SIGN_NAMELabel.Text = "Name:"
        '
        'AUTH_SIGN_DESGLabel
        '
        AUTH_SIGN_DESGLabel.AutoSize = True
        AUTH_SIGN_DESGLabel.Location = New System.Drawing.Point(6, 36)
        AUTH_SIGN_DESGLabel.Name = "AUTH_SIGN_DESGLabel"
        AUTH_SIGN_DESGLabel.Size = New System.Drawing.Size(66, 13)
        AUTH_SIGN_DESGLabel.TabIndex = 54
        AUTH_SIGN_DESGLabel.Text = "Designation:"
        '
        'BankDetailLabel
        '
        BankDetailLabel.Location = New System.Drawing.Point(11, 301)
        BankDetailLabel.Name = "BankDetailLabel"
        BankDetailLabel.Size = New System.Drawing.Size(71, 13)
        BankDetailLabel.TabIndex = 48
        BankDetailLabel.Text = "Bank Detail"
        BankDetailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IdTextBox
        '
        Me.IdTextBox.Location = New System.Drawing.Point(322, 376)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 25
        Me.IdTextBox.Visible = False
        '
        'CompanyTextBox
        '
        Me.CompanyTextBox.Location = New System.Drawing.Point(73, 12)
        Me.CompanyTextBox.Name = "CompanyTextBox"
        Me.CompanyTextBox.Size = New System.Drawing.Size(504, 20)
        Me.CompanyTextBox.TabIndex = 0
        '
        'FY_StartDateTimePicker
        '
        Me.FY_StartDateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.FY_StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FY_StartDateTimePicker.Location = New System.Drawing.Point(73, 38)
        Me.FY_StartDateTimePicker.Name = "FY_StartDateTimePicker"
        Me.FY_StartDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.FY_StartDateTimePicker.TabIndex = 1
        '
        'Book_StartDateTimePicker
        '
        Me.Book_StartDateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.Book_StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Book_StartDateTimePicker.Location = New System.Drawing.Point(249, 37)
        Me.Book_StartDateTimePicker.Name = "Book_StartDateTimePicker"
        Me.Book_StartDateTimePicker.Size = New System.Drawing.Size(89, 20)
        Me.Book_StartDateTimePicker.TabIndex = 2
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(73, 63)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(240, 60)
        Me.AddressTextBox.TabIndex = 3
        '
        'CountryTextBox
        '
        Me.CountryTextBox.Location = New System.Drawing.Point(477, 135)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CountryTextBox.TabIndex = 10
        '
        'PinTextBox
        '
        Me.PinTextBox.Location = New System.Drawing.Point(210, 135)
        Me.PinTextBox.Name = "PinTextBox"
        Me.PinTextBox.Size = New System.Drawing.Size(80, 20)
        Me.PinTextBox.TabIndex = 8
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(366, 63)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(211, 20)
        Me.PhoneTextBox.TabIndex = 4
        '
        'FaxTextBox
        '
        Me.FaxTextBox.Location = New System.Drawing.Point(366, 83)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.Size = New System.Drawing.Size(211, 20)
        Me.FaxTextBox.TabIndex = 5
        '
        'MobileTextBox
        '
        Me.MobileTextBox.Location = New System.Drawing.Point(366, 103)
        Me.MobileTextBox.Name = "MobileTextBox"
        Me.MobileTextBox.Size = New System.Drawing.Size(211, 20)
        Me.MobileTextBox.TabIndex = 6
        '
        'PANTextBox
        '
        Me.PANTextBox.Location = New System.Drawing.Point(75, 162)
        Me.PANTextBox.Name = "PANTextBox"
        Me.PANTextBox.Size = New System.Drawing.Size(217, 20)
        Me.PANTextBox.TabIndex = 11
        '
        'TANTextBox
        '
        Me.TANTextBox.Location = New System.Drawing.Point(73, 184)
        Me.TANTextBox.Name = "TANTextBox"
        Me.TANTextBox.Size = New System.Drawing.Size(217, 20)
        Me.TANTextBox.TabIndex = 12
        '
        'TINTextBox
        '
        Me.TINTextBox.Location = New System.Drawing.Point(73, 206)
        Me.TINTextBox.Name = "TINTextBox"
        Me.TINTextBox.Size = New System.Drawing.Size(217, 20)
        Me.TINTextBox.TabIndex = 13
        '
        'MINTextBox
        '
        Me.MINTextBox.Location = New System.Drawing.Point(376, 271)
        Me.MINTextBox.Name = "MINTextBox"
        Me.MINTextBox.Size = New System.Drawing.Size(201, 20)
        Me.MINTextBox.TabIndex = 22
        '
        'VATTextBox
        '
        Me.VATTextBox.Location = New System.Drawing.Point(73, 228)
        Me.VATTextBox.Name = "VATTextBox"
        Me.VATTextBox.Size = New System.Drawing.Size(217, 20)
        Me.VATTextBox.TabIndex = 14
        '
        'LSTTextBox
        '
        Me.LSTTextBox.Location = New System.Drawing.Point(73, 250)
        Me.LSTTextBox.Name = "LSTTextBox"
        Me.LSTTextBox.Size = New System.Drawing.Size(217, 20)
        Me.LSTTextBox.TabIndex = 15
        '
        'CSTTextBox
        '
        Me.CSTTextBox.Location = New System.Drawing.Point(73, 272)
        Me.CSTTextBox.Name = "CSTTextBox"
        Me.CSTTextBox.Size = New System.Drawing.Size(217, 20)
        Me.CSTTextBox.TabIndex = 16
        '
        'EXCISETextBox
        '
        Me.EXCISETextBox.Location = New System.Drawing.Point(376, 163)
        Me.EXCISETextBox.Name = "EXCISETextBox"
        Me.EXCISETextBox.Size = New System.Drawing.Size(199, 20)
        Me.EXCISETextBox.TabIndex = 17
        '
        'SERVICETAXTextBox
        '
        Me.SERVICETAXTextBox.Location = New System.Drawing.Point(376, 187)
        Me.SERVICETAXTextBox.Name = "SERVICETAXTextBox"
        Me.SERVICETAXTextBox.Size = New System.Drawing.Size(201, 20)
        Me.SERVICETAXTextBox.TabIndex = 18
        '
        'PROFTAXTextBox
        '
        Me.PROFTAXTextBox.Location = New System.Drawing.Point(376, 208)
        Me.PROFTAXTextBox.Name = "PROFTAXTextBox"
        Me.PROFTAXTextBox.Size = New System.Drawing.Size(201, 20)
        Me.PROFTAXTextBox.TabIndex = 19
        '
        'PF_NOTextBox
        '
        Me.PF_NOTextBox.Location = New System.Drawing.Point(376, 229)
        Me.PF_NOTextBox.Name = "PF_NOTextBox"
        Me.PF_NOTextBox.Size = New System.Drawing.Size(201, 20)
        Me.PF_NOTextBox.TabIndex = 20
        '
        'ESIC_NOTextBox
        '
        Me.ESIC_NOTextBox.Location = New System.Drawing.Point(376, 250)
        Me.ESIC_NOTextBox.Name = "ESIC_NOTextBox"
        Me.ESIC_NOTextBox.Size = New System.Drawing.Size(201, 20)
        Me.ESIC_NOTextBox.TabIndex = 21
        '
        'MAIN_SIGN_NAMETextBox
        '
        Me.MAIN_SIGN_NAMETextBox.Location = New System.Drawing.Point(79, 12)
        Me.MAIN_SIGN_NAMETextBox.Name = "MAIN_SIGN_NAMETextBox"
        Me.MAIN_SIGN_NAMETextBox.Size = New System.Drawing.Size(196, 20)
        Me.MAIN_SIGN_NAMETextBox.TabIndex = 0
        '
        'MAIN_SIGN_DESGTextBox
        '
        Me.MAIN_SIGN_DESGTextBox.Location = New System.Drawing.Point(79, 32)
        Me.MAIN_SIGN_DESGTextBox.Name = "MAIN_SIGN_DESGTextBox"
        Me.MAIN_SIGN_DESGTextBox.Size = New System.Drawing.Size(196, 20)
        Me.MAIN_SIGN_DESGTextBox.TabIndex = 1
        '
        'AUTH_SIGN_NAMETextBox
        '
        Me.AUTH_SIGN_NAMETextBox.Location = New System.Drawing.Point(77, 13)
        Me.AUTH_SIGN_NAMETextBox.Name = "AUTH_SIGN_NAMETextBox"
        Me.AUTH_SIGN_NAMETextBox.Size = New System.Drawing.Size(187, 20)
        Me.AUTH_SIGN_NAMETextBox.TabIndex = 24
        '
        'gpMainSign
        '
        Me.gpMainSign.Controls.Add(MAIN_SIGN_NAMELabel)
        Me.gpMainSign.Controls.Add(Me.MAIN_SIGN_NAMETextBox)
        Me.gpMainSign.Controls.Add(MAIN_SIGN_DESGLabel)
        Me.gpMainSign.Controls.Add(Me.MAIN_SIGN_DESGTextBox)
        Me.gpMainSign.Location = New System.Drawing.Point(12, 350)
        Me.gpMainSign.Name = "gpMainSign"
        Me.gpMainSign.Size = New System.Drawing.Size(289, 47)
        Me.gpMainSign.TabIndex = 23
        Me.gpMainSign.TabStop = False
        Me.gpMainSign.Text = "Main Signatory"
        Me.gpMainSign.Visible = False
        '
        'gpAuthSign
        '
        Me.gpAuthSign.Controls.Add(AUTH_SIGN_DESGLabel)
        Me.gpAuthSign.Controls.Add(Me.AUTH_SIGN_DESGTextBox)
        Me.gpAuthSign.Controls.Add(Me.AUTH_SIGN_NAMETextBox)
        Me.gpAuthSign.Controls.Add(AUTH_SIGN_NAMELabel)
        Me.gpAuthSign.Location = New System.Drawing.Point(308, 293)
        Me.gpAuthSign.Name = "gpAuthSign"
        Me.gpAuthSign.Size = New System.Drawing.Size(272, 61)
        Me.gpAuthSign.TabIndex = 24
        Me.gpAuthSign.TabStop = False
        Me.gpAuthSign.Text = "Auth. Signatory"
        '
        'AUTH_SIGN_DESGTextBox
        '
        Me.AUTH_SIGN_DESGTextBox.Location = New System.Drawing.Point(77, 33)
        Me.AUTH_SIGN_DESGTextBox.Name = "AUTH_SIGN_DESGTextBox"
        Me.AUTH_SIGN_DESGTextBox.Size = New System.Drawing.Size(187, 20)
        Me.AUTH_SIGN_DESGTextBox.TabIndex = 25
        '
        'btnSave
        '
        Me.btnSave.Image = Global.Account.My.Resources.Resources.Save
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(421, 361)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 38)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.Account.My.Resources.Resources.Back
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancel.Location = New System.Drawing.Point(502, 361)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 38)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(338, 135)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(89, 20)
        Me.StateTextBox.TabIndex = 9
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(73, 135)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CityTextBox.TabIndex = 7
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BankDetailTextbox
        '
        Me.BankDetailTextbox.Location = New System.Drawing.Point(75, 298)
        Me.BankDetailTextbox.Multiline = True
        Me.BankDetailTextbox.Name = "BankDetailTextbox"
        Me.BankDetailTextbox.Size = New System.Drawing.Size(217, 50)
        Me.BankDetailTextbox.TabIndex = 23
        '
        'CompanyData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 403)
        Me.Controls.Add(Me.BankDetailTextbox)
        Me.Controls.Add(BankDetailLabel)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gpMainSign)
        Me.Controls.Add(Me.gpAuthSign)
        Me.Controls.Add(ESIC_NOLabel)
        Me.Controls.Add(Me.ESIC_NOTextBox)
        Me.Controls.Add(PF_NOLabel)
        Me.Controls.Add(Me.PF_NOTextBox)
        Me.Controls.Add(PROFTAXLabel)
        Me.Controls.Add(Me.PROFTAXTextBox)
        Me.Controls.Add(SERVICETAXLabel)
        Me.Controls.Add(Me.SERVICETAXTextBox)
        Me.Controls.Add(EXCISELabel)
        Me.Controls.Add(Me.EXCISETextBox)
        Me.Controls.Add(CSTLabel)
        Me.Controls.Add(Me.CSTTextBox)
        Me.Controls.Add(LSTLabel)
        Me.Controls.Add(Me.LSTTextBox)
        Me.Controls.Add(VATLabel)
        Me.Controls.Add(Me.VATTextBox)
        Me.Controls.Add(MINLabel)
        Me.Controls.Add(Me.MINTextBox)
        Me.Controls.Add(TINLabel)
        Me.Controls.Add(Me.TINTextBox)
        Me.Controls.Add(TANLabel)
        Me.Controls.Add(Me.TANTextBox)
        Me.Controls.Add(PANLabel)
        Me.Controls.Add(Me.PANTextBox)
        Me.Controls.Add(MobileLabel)
        Me.Controls.Add(Me.MobileTextBox)
        Me.Controls.Add(FaxLabel)
        Me.Controls.Add(Me.FaxTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(PinLabel)
        Me.Controls.Add(Me.PinTextBox)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Book_StartLabel)
        Me.Controls.Add(Me.Book_StartDateTimePicker)
        Me.Controls.Add(FY_StartLabel)
        Me.Controls.Add(Me.FY_StartDateTimePicker)
        Me.Controls.Add(CompanyLabel)
        Me.Controls.Add(Me.CompanyTextBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "CompanyData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company Information"
        Me.gpMainSign.ResumeLayout(False)
        Me.gpMainSign.PerformLayout()
        Me.gpAuthSign.ResumeLayout(False)
        Me.gpAuthSign.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompanyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FY_StartDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Book_StartDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PinTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MobileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PANTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TANTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TINTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MINTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LSTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CSTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EXCISETextBox As System.Windows.Forms.TextBox
    Friend WithEvents SERVICETAXTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PROFTAXTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PF_NOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ESIC_NOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MAIN_SIGN_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents MAIN_SIGN_DESGTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AUTH_SIGN_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents gpMainSign As System.Windows.Forms.GroupBox
    Friend WithEvents gpAuthSign As System.Windows.Forms.GroupBox
    Friend WithEvents AUTH_SIGN_DESGTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BankDetailTextbox As System.Windows.Forms.TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LedgerEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LedgerEntry))
        Me.lblLedger = New System.Windows.Forms.Label
        Me.txtLedger = New System.Windows.Forms.TextBox
        Me.lblGroup = New System.Windows.Forms.Label
        Me.cmbGroup = New System.Windows.Forms.ComboBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lblOpBal = New System.Windows.Forms.Label
        Me.cmbDrCr = New System.Windows.Forms.ComboBox
        Me.dtOpDate = New System.Windows.Forms.DateTimePicker
        Me.chkInventory = New System.Windows.Forms.CheckBox
        Me.cmbAdjust = New System.Windows.Forms.ComboBox
        Me.lblAdj = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dtReg = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtEffcFrom = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTdsRate2 = New Account.NumTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTdsrate = New Account.NumTextBox
        Me.txtDiscountrate = New Account.NumTextBox
        Me.txtSidedays = New Account.NumTextBox
        Me.txtCreditDays = New Account.NumTextBox
        Me.txtCreditamt = New Account.NumTextBox
        Me.txtOpbal = New Account.NumTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblDiscount = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblTDS = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblCountry = New System.Windows.Forms.Label
        Me.lblState = New System.Windows.Forms.Label
        Me.lblTransporter = New System.Windows.Forms.Label
        Me.lblAgent = New System.Windows.Forms.Label
        Me.lblCity = New System.Windows.Forms.Label
        Me.cmbTransporter = New System.Windows.Forms.ComboBox
        Me.cmbAgent = New System.Windows.Forms.ComboBox
        Me.cmbCity = New System.Windows.Forms.ComboBox
        Me.txtPin = New System.Windows.Forms.TextBox
        Me.lblPin = New System.Windows.Forms.Label
        Me.lblSide = New System.Windows.Forms.Label
        Me.txtPAN = New System.Windows.Forms.TextBox
        Me.lblCredit = New System.Windows.Forms.Label
        Me.lblPAN = New System.Windows.Forms.Label
        Me.txtCST = New System.Windows.Forms.TextBox
        Me.lblCST = New System.Windows.Forms.Label
        Me.txtST = New System.Windows.Forms.TextBox
        Me.lblST = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.lblEmail = New System.Windows.Forms.Label
        Me.txtMobile = New System.Windows.Forms.TextBox
        Me.lblMobile = New System.Windows.Forms.Label
        Me.txtFax = New System.Windows.Forms.TextBox
        Me.lblFax = New System.Windows.Forms.Label
        Me.txtTelephone = New System.Windows.Forms.TextBox
        Me.lblTelephone = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.lblAddress = New System.Windows.Forms.Label
        Me.txtOwner = New System.Windows.Forms.TextBox
        Me.lblOwner = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLedger
        '
        Me.lblLedger.AutoSize = True
        Me.lblLedger.Location = New System.Drawing.Point(14, 15)
        Me.lblLedger.Name = "lblLedger"
        Me.lblLedger.Size = New System.Drawing.Size(40, 13)
        Me.lblLedger.TabIndex = 0
        Me.lblLedger.Text = "Ledger"
        '
        'txtLedger
        '
        Me.txtLedger.Location = New System.Drawing.Point(74, 12)
        Me.txtLedger.Name = "txtLedger"
        Me.txtLedger.Size = New System.Drawing.Size(312, 20)
        Me.txtLedger.TabIndex = 0
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Location = New System.Drawing.Point(393, 16)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(36, 13)
        Me.lblGroup.TabIndex = 2
        Me.lblGroup.Text = "Group"
        '
        'cmbGroup
        '
        Me.cmbGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbGroup.FormattingEnabled = True
        Me.cmbGroup.Location = New System.Drawing.Point(442, 13)
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Size = New System.Drawing.Size(262, 21)
        Me.cmbGroup.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Image = Global.Account.My.Resources.Resources.Save
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(550, 353)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 38)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Image = Global.Account.My.Resources.Resources.cancel
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancel.Location = New System.Drawing.Point(637, 353)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 38)
        Me.btnCancel.TabIndex = 29
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblOpBal
        '
        Me.lblOpBal.AutoSize = True
        Me.lblOpBal.Location = New System.Drawing.Point(385, 13)
        Me.lblOpBal.Name = "lblOpBal"
        Me.lblOpBal.Size = New System.Drawing.Size(39, 13)
        Me.lblOpBal.TabIndex = 4
        Me.lblOpBal.Text = "Op.Bal"
        '
        'cmbDrCr
        '
        Me.cmbDrCr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDrCr.FormattingEnabled = True
        Me.cmbDrCr.Items.AddRange(New Object() {"Dr", "Cr"})
        Me.cmbDrCr.Location = New System.Drawing.Point(559, 10)
        Me.cmbDrCr.Name = "cmbDrCr"
        Me.cmbDrCr.Size = New System.Drawing.Size(34, 21)
        Me.cmbDrCr.TabIndex = 3
        '
        'dtOpDate
        '
        Me.dtOpDate.CustomFormat = "dd/MM/yyyy"
        Me.dtOpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtOpDate.Location = New System.Drawing.Point(599, 11)
        Me.dtOpDate.Name = "dtOpDate"
        Me.dtOpDate.Size = New System.Drawing.Size(89, 20)
        Me.dtOpDate.TabIndex = 4
        '
        'chkInventory
        '
        Me.chkInventory.AutoSize = True
        Me.chkInventory.Location = New System.Drawing.Point(248, 11)
        Me.chkInventory.Name = "chkInventory"
        Me.chkInventory.Size = New System.Drawing.Size(106, 17)
        Me.chkInventory.TabIndex = 1
        Me.chkInventory.Text = "Affects Inventory"
        Me.chkInventory.UseVisualStyleBackColor = True
        '
        'cmbAdjust
        '
        Me.cmbAdjust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAdjust.FormattingEnabled = True
        Me.cmbAdjust.Items.AddRange(New Object() {"On Account", "Bill by Bill"})
        Me.cmbAdjust.Location = New System.Drawing.Point(128, 9)
        Me.cmbAdjust.Name = "cmbAdjust"
        Me.cmbAdjust.Size = New System.Drawing.Size(87, 21)
        Me.cmbAdjust.TabIndex = 0
        '
        'lblAdj
        '
        Me.lblAdj.AutoSize = True
        Me.lblAdj.Location = New System.Drawing.Point(6, 13)
        Me.lblAdj.Name = "lblAdj"
        Me.lblAdj.Size = New System.Drawing.Size(119, 13)
        Me.lblAdj.TabIndex = 0
        Me.lblAdj.Text = "Outstanding Adjustment"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.dtReg)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.dtEffcFrom)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtTdsRate2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtTdsrate)
        Me.Panel1.Controls.Add(Me.txtDiscountrate)
        Me.Panel1.Controls.Add(Me.txtSidedays)
        Me.Panel1.Controls.Add(Me.txtCreditDays)
        Me.Panel1.Controls.Add(Me.txtCreditamt)
        Me.Panel1.Controls.Add(Me.txtOpbal)
        Me.Panel1.Controls.Add(Me.chkInventory)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtOpDate)
        Me.Panel1.Controls.Add(Me.cmbDrCr)
        Me.Panel1.Controls.Add(Me.lblDiscount)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblTDS)
        Me.Panel1.Controls.Add(Me.lblOpBal)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblCountry)
        Me.Panel1.Controls.Add(Me.lblState)
        Me.Panel1.Controls.Add(Me.lblTransporter)
        Me.Panel1.Controls.Add(Me.lblAgent)
        Me.Panel1.Controls.Add(Me.lblCity)
        Me.Panel1.Controls.Add(Me.cmbTransporter)
        Me.Panel1.Controls.Add(Me.cmbAgent)
        Me.Panel1.Controls.Add(Me.cmbCity)
        Me.Panel1.Controls.Add(Me.txtPin)
        Me.Panel1.Controls.Add(Me.lblPin)
        Me.Panel1.Controls.Add(Me.lblSide)
        Me.Panel1.Controls.Add(Me.txtPAN)
        Me.Panel1.Controls.Add(Me.lblCredit)
        Me.Panel1.Controls.Add(Me.lblPAN)
        Me.Panel1.Controls.Add(Me.txtCST)
        Me.Panel1.Controls.Add(Me.lblCST)
        Me.Panel1.Controls.Add(Me.txtST)
        Me.Panel1.Controls.Add(Me.lblST)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.txtMobile)
        Me.Panel1.Controls.Add(Me.lblMobile)
        Me.Panel1.Controls.Add(Me.txtFax)
        Me.Panel1.Controls.Add(Me.lblFax)
        Me.Panel1.Controls.Add(Me.txtTelephone)
        Me.Panel1.Controls.Add(Me.lblTelephone)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.lblAddress)
        Me.Panel1.Controls.Add(Me.txtOwner)
        Me.Panel1.Controls.Add(Me.lblOwner)
        Me.Panel1.Controls.Add(Me.lblAdj)
        Me.Panel1.Controls.Add(Me.cmbAdjust)
        Me.Panel1.Location = New System.Drawing.Point(6, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(706, 305)
        Me.Panel1.TabIndex = 10
        '
        'dtReg
        '
        Me.dtReg.CustomFormat = "dd/MM/yyyy"
        Me.dtReg.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtReg.Location = New System.Drawing.Point(129, 210)
        Me.dtReg.Name = "dtReg"
        Me.dtReg.Size = New System.Drawing.Size(89, 20)
        Me.dtReg.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Reg. Certificate Date"
        '
        'dtEffcFrom
        '
        Me.dtEffcFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtEffcFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtEffcFrom.Location = New System.Drawing.Point(601, 212)
        Me.dtEffcFrom.Name = "dtEffcFrom"
        Me.dtEffcFrom.Size = New System.Drawing.Size(89, 20)
        Me.dtEffcFrom.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(539, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Effc. From"
        '
        'txtTdsRate2
        '
        Me.txtTdsRate2.dec = CType(4, Short)
        Me.txtTdsRate2.format = Nothing
        Me.txtTdsRate2.Location = New System.Drawing.Point(463, 212)
        Me.txtTdsRate2.Name = "txtTdsRate2"
        Me.txtTdsRate2.Size = New System.Drawing.Size(56, 20)
        Me.txtTdsRate2.TabIndex = 20
        Me.txtTdsRate2.Text = "0.0000"
        Me.txtTdsRate2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTdsRate2.value = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(385, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "TDS 2 @"
        '
        'txtTdsrate
        '
        Me.txtTdsrate.dec = CType(4, Short)
        Me.txtTdsrate.format = Nothing
        Me.txtTdsrate.Location = New System.Drawing.Point(322, 212)
        Me.txtTdsrate.Name = "txtTdsrate"
        Me.txtTdsrate.Size = New System.Drawing.Size(56, 20)
        Me.txtTdsrate.TabIndex = 19
        Me.txtTdsrate.Text = "0.0000"
        Me.txtTdsrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTdsrate.value = 0
        '
        'txtDiscountrate
        '
        Me.txtDiscountrate.dec = CType(2, Short)
        Me.txtDiscountrate.format = Nothing
        Me.txtDiscountrate.Location = New System.Drawing.Point(609, 241)
        Me.txtDiscountrate.Name = "txtDiscountrate"
        Me.txtDiscountrate.Size = New System.Drawing.Size(56, 20)
        Me.txtDiscountrate.TabIndex = 25
        Me.txtDiscountrate.Text = "0.00"
        Me.txtDiscountrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDiscountrate.value = 0
        '
        'txtSidedays
        '
        Me.txtSidedays.dec = CType(0, Short)
        Me.txtSidedays.format = Nothing
        Me.txtSidedays.Location = New System.Drawing.Point(447, 241)
        Me.txtSidedays.Name = "txtSidedays"
        Me.txtSidedays.Size = New System.Drawing.Size(74, 20)
        Me.txtSidedays.TabIndex = 24
        Me.txtSidedays.Text = "0"
        Me.txtSidedays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSidedays.value = 0
        '
        'txtCreditDays
        '
        Me.txtCreditDays.dec = CType(0, Short)
        Me.txtCreditDays.format = Nothing
        Me.txtCreditDays.Location = New System.Drawing.Point(296, 240)
        Me.txtCreditDays.Name = "txtCreditDays"
        Me.txtCreditDays.Size = New System.Drawing.Size(81, 20)
        Me.txtCreditDays.TabIndex = 23
        Me.txtCreditDays.Text = "0"
        Me.txtCreditDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCreditDays.value = 0
        '
        'txtCreditamt
        '
        Me.txtCreditamt.dec = CType(2, Short)
        Me.txtCreditamt.format = Nothing
        Me.txtCreditamt.Location = New System.Drawing.Point(129, 240)
        Me.txtCreditamt.Name = "txtCreditamt"
        Me.txtCreditamt.Size = New System.Drawing.Size(100, 20)
        Me.txtCreditamt.TabIndex = 22
        Me.txtCreditamt.Text = "0.00"
        Me.txtCreditamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCreditamt.value = 0
        '
        'txtOpbal
        '
        Me.txtOpbal.dec = CType(2, Short)
        Me.txtOpbal.format = Nothing
        Me.txtOpbal.Location = New System.Drawing.Point(445, 10)
        Me.txtOpbal.Name = "txtOpbal"
        Me.txtOpbal.Size = New System.Drawing.Size(100, 20)
        Me.txtOpbal.TabIndex = 2
        Me.txtOpbal.Text = "0.00"
        Me.txtOpbal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtOpbal.value = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(678, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "%"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(539, 244)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(66, 13)
        Me.lblDiscount.TabIndex = 22
        Me.lblDiscount.Text = "Discount  @"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(259, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Days"
        '
        'lblTDS
        '
        Me.lblTDS.AutoSize = True
        Me.lblTDS.Location = New System.Drawing.Point(260, 215)
        Me.lblTDS.Name = "lblTDS"
        Me.lblTDS.Size = New System.Drawing.Size(52, 13)
        Me.lblTDS.TabIndex = 24
        Me.lblTDS.Text = "TDS 1 @"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(539, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 37
        '
        'lblCountry
        '
        Me.lblCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCountry.Location = New System.Drawing.Point(560, 149)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(132, 20)
        Me.lblCountry.TabIndex = 14
        Me.lblCountry.Text = "Country"
        Me.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblState
        '
        Me.lblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblState.Location = New System.Drawing.Point(388, 149)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(151, 20)
        Me.lblState.TabIndex = 13
        Me.lblState.Text = "State"
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTransporter
        '
        Me.lblTransporter.AutoSize = True
        Me.lblTransporter.Location = New System.Drawing.Point(385, 271)
        Me.lblTransporter.Name = "lblTransporter"
        Me.lblTransporter.Size = New System.Drawing.Size(61, 13)
        Me.lblTransporter.TabIndex = 34
        Me.lblTransporter.Text = "Transporter"
        '
        'lblAgent
        '
        Me.lblAgent.AutoSize = True
        Me.lblAgent.Location = New System.Drawing.Point(6, 271)
        Me.lblAgent.Name = "lblAgent"
        Me.lblAgent.Size = New System.Drawing.Size(35, 13)
        Me.lblAgent.TabIndex = 32
        Me.lblAgent.Text = "Agent"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(6, 152)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(24, 13)
        Me.lblCity.TabIndex = 6
        Me.lblCity.Text = "City"
        '
        'cmbTransporter
        '
        Me.cmbTransporter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTransporter.FormattingEnabled = True
        Me.cmbTransporter.Location = New System.Drawing.Point(446, 267)
        Me.cmbTransporter.Name = "cmbTransporter"
        Me.cmbTransporter.Size = New System.Drawing.Size(250, 21)
        Me.cmbTransporter.TabIndex = 27
        '
        'cmbAgent
        '
        Me.cmbAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAgent.FormattingEnabled = True
        Me.cmbAgent.Location = New System.Drawing.Point(128, 267)
        Me.cmbAgent.Name = "cmbAgent"
        Me.cmbAgent.Size = New System.Drawing.Size(250, 21)
        Me.cmbAgent.TabIndex = 26
        '
        'cmbCity
        '
        Me.cmbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCity.FormattingEnabled = True
        Me.cmbCity.Location = New System.Drawing.Point(128, 148)
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.Size = New System.Drawing.Size(121, 21)
        Me.cmbCity.TabIndex = 11
        '
        'txtPin
        '
        Me.txtPin.Location = New System.Drawing.Point(287, 148)
        Me.txtPin.Name = "txtPin"
        Me.txtPin.Size = New System.Drawing.Size(91, 20)
        Me.txtPin.TabIndex = 12
        '
        'lblPin
        '
        Me.lblPin.AutoSize = True
        Me.lblPin.Location = New System.Drawing.Point(258, 151)
        Me.lblPin.Name = "lblPin"
        Me.lblPin.Size = New System.Drawing.Size(22, 13)
        Me.lblPin.TabIndex = 8
        Me.lblPin.Text = "Pin"
        '
        'lblSide
        '
        Me.lblSide.AutoSize = True
        Me.lblSide.Location = New System.Drawing.Point(385, 244)
        Me.lblSide.Name = "lblSide"
        Me.lblSide.Size = New System.Drawing.Size(55, 13)
        Me.lblSide.TabIndex = 30
        Me.lblSide.Text = "Side Days"
        '
        'txtPAN
        '
        Me.txtPAN.Location = New System.Drawing.Point(558, 180)
        Me.txtPAN.Name = "txtPAN"
        Me.txtPAN.Size = New System.Drawing.Size(132, 20)
        Me.txtPAN.TabIndex = 17
        '
        'lblCredit
        '
        Me.lblCredit.AutoSize = True
        Me.lblCredit.Location = New System.Drawing.Point(6, 241)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(97, 13)
        Me.lblCredit.TabIndex = 26
        Me.lblCredit.Text = "Credit Limit Amount"
        '
        'lblPAN
        '
        Me.lblPAN.AutoSize = True
        Me.lblPAN.Location = New System.Drawing.Point(514, 184)
        Me.lblPAN.Name = "lblPAN"
        Me.lblPAN.Size = New System.Drawing.Size(29, 13)
        Me.lblPAN.TabIndex = 22
        Me.lblPAN.Text = "PAN"
        '
        'txtCST
        '
        Me.txtCST.Location = New System.Drawing.Point(344, 181)
        Me.txtCST.Name = "txtCST"
        Me.txtCST.Size = New System.Drawing.Size(158, 20)
        Me.txtCST.TabIndex = 16
        '
        'lblCST
        '
        Me.lblCST.AutoSize = True
        Me.lblCST.Location = New System.Drawing.Point(291, 184)
        Me.lblCST.Name = "lblCST"
        Me.lblCST.Size = New System.Drawing.Size(48, 13)
        Me.lblCST.TabIndex = 20
        Me.lblCST.Text = "CST No."
        '
        'txtST
        '
        Me.txtST.Location = New System.Drawing.Point(128, 180)
        Me.txtST.Name = "txtST"
        Me.txtST.Size = New System.Drawing.Size(152, 20)
        Me.txtST.TabIndex = 15
        '
        'lblST
        '
        Me.lblST.AutoSize = True
        Me.lblST.Location = New System.Drawing.Point(6, 184)
        Me.lblST.Name = "lblST"
        Me.lblST.Size = New System.Drawing.Size(67, 13)
        Me.lblST.TabIndex = 18
        Me.lblST.Text = "S T/TIN No."
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(445, 116)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(250, 20)
        Me.txtEmail.TabIndex = 10
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(384, 119)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 16
        Me.lblEmail.Text = "Email"
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(445, 91)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(250, 20)
        Me.txtMobile.TabIndex = 9
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(384, 94)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(38, 13)
        Me.lblMobile.TabIndex = 14
        Me.lblMobile.Text = "Mobile"
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(445, 67)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(250, 20)
        Me.txtFax.TabIndex = 8
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.Location = New System.Drawing.Point(384, 70)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(24, 13)
        Me.lblFax.TabIndex = 12
        Me.lblFax.Text = "Fax"
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(445, 39)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(250, 20)
        Me.txtTelephone.TabIndex = 7
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(384, 42)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(58, 13)
        Me.lblTelephone.TabIndex = 10
        Me.lblTelephone.Text = "Telephone"
        '
        'txtAddress
        '
        Me.txtAddress.AllowDrop = True
        Me.txtAddress.Location = New System.Drawing.Point(128, 67)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(250, 69)
        Me.txtAddress.TabIndex = 6
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(6, 67)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "Address"
        '
        'txtOwner
        '
        Me.txtOwner.Location = New System.Drawing.Point(128, 39)
        Me.txtOwner.Name = "txtOwner"
        Me.txtOwner.Size = New System.Drawing.Size(250, 20)
        Me.txtOwner.TabIndex = 5
        '
        'lblOwner
        '
        Me.lblOwner.AutoSize = True
        Me.lblOwner.Location = New System.Drawing.Point(6, 42)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(38, 13)
        Me.lblOwner.TabIndex = 2
        Me.lblOwner.Text = "Owner"
        '
        'LedgerEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 394)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbGroup)
        Me.Controls.Add(Me.txtLedger)
        Me.Controls.Add(Me.lblGroup)
        Me.Controls.Add(Me.lblLedger)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "LedgerEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ledger Entry"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLedger As System.Windows.Forms.Label
    Friend WithEvents txtLedger As System.Windows.Forms.TextBox
    Friend WithEvents lblGroup As System.Windows.Forms.Label
    Friend WithEvents cmbGroup As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblOpBal As System.Windows.Forms.Label
    Friend WithEvents cmbDrCr As System.Windows.Forms.ComboBox
    Friend WithEvents dtOpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkInventory As System.Windows.Forms.CheckBox
    Friend WithEvents cmbAdjust As System.Windows.Forms.ComboBox
    Friend WithEvents lblAdj As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtCST As System.Windows.Forms.TextBox
    Friend WithEvents lblCST As System.Windows.Forms.Label
    Friend WithEvents txtST As System.Windows.Forms.TextBox
    Friend WithEvents lblST As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents lblMobile As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents lblFax As System.Windows.Forms.Label
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents lblTelephone As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtOwner As System.Windows.Forms.TextBox
    Friend WithEvents lblOwner As System.Windows.Forms.Label
    Friend WithEvents lblSide As System.Windows.Forms.Label
    Friend WithEvents txtPAN As System.Windows.Forms.TextBox
    Friend WithEvents lblPAN As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents cmbCity As System.Windows.Forms.ComboBox
    Friend WithEvents txtPin As System.Windows.Forms.TextBox
    Friend WithEvents lblPin As System.Windows.Forms.Label
    Friend WithEvents lblTDS As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCredit As System.Windows.Forms.Label
    Friend WithEvents lblTransporter As System.Windows.Forms.Label
    Friend WithEvents lblAgent As System.Windows.Forms.Label
    Friend WithEvents cmbTransporter As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAgent As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents txtOpbal As Account.NumTextBox
    Friend WithEvents txtDiscountrate As Account.NumTextBox
    Friend WithEvents txtSidedays As Account.NumTextBox
    Friend WithEvents txtCreditDays As Account.NumTextBox
    Friend WithEvents txtCreditamt As Account.NumTextBox
    Friend WithEvents txtTdsrate As Account.NumTextBox
    Friend WithEvents txtTdsRate2 As Account.NumTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtEffcFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtReg As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class

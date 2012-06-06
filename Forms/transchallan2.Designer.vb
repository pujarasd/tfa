<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransChallan2
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransChallan2))
        Me.tbEdit = New System.Windows.Forms.ToolStrip
        Me.tsbNew = New System.Windows.Forms.ToolStripButton
        Me.tsbEdit = New System.Windows.Forms.ToolStripButton
        Me.tsbDelete = New System.Windows.Forms.ToolStripButton
        Me.tsbPrint = New System.Windows.Forms.ToolStripButton
        Me.lblChallanNo = New System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label
        Me.dtChallanDate = New System.Windows.Forms.DateTimePicker
        Me.lblTransporter = New System.Windows.Forms.Label
        Me.cmbTransporter = New System.Windows.Forms.ComboBox
        Me.lblCustomer = New System.Windows.Forms.Label
        Me.lblNet = New System.Windows.Forms.Label
        Me.lblGross = New System.Windows.Forms.Label
        Me.lblVarGross = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtLorryno = New System.Windows.Forms.TextBox
        Me.ntxtChallan = New Account.NumTextBox
        Me.txtOwner = New System.Windows.Forms.TextBox
        Me.lblOwner = New System.Windows.Forms.Label
        Me.txtDriver = New System.Windows.Forms.TextBox
        Me.lblDriver = New System.Windows.Forms.Label
        Me.txtDiNo = New System.Windows.Forms.TextBox
        Me.lblDiNo = New System.Windows.Forms.Label
        Me.dtLrDate = New System.Windows.Forms.DateTimePicker
        Me.cmbTo = New System.Windows.Forms.ComboBox
        Me.lblTo = New System.Windows.Forms.Label
        Me.lblLorryNo = New System.Windows.Forms.Label
        Me.lblShip = New System.Windows.Forms.Label
        Me.cmbCustomer = New System.Windows.Forms.ComboBox
        Me.txtInv = New System.Windows.Forms.TextBox
        Me.txtShip = New System.Windows.Forms.TextBox
        Me.lblPrefix = New System.Windows.Forms.Label
        Me.lblLRDate = New System.Windows.Forms.Label
        Me.txtLrNo = New System.Windows.Forms.TextBox
        Me.lblLR = New System.Windows.Forms.Label
        Me.cmbPayableAt = New System.Windows.Forms.ComboBox
        Me.lblPayableAt = New System.Windows.Forms.Label
        Me.cmbFrom = New System.Windows.Forms.ComboBox
        Me.lblFrom = New System.Windows.Forms.Label
        Me.pnlcalc = New System.Windows.Forms.Panel
        Me.cmbSTon = New System.Windows.Forms.ComboBox
        Me.lblOther2 = New System.Windows.Forms.Label
        Me.ntxtOther2 = New Account.NumTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ntxtOther1 = New Account.NumTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblTDS = New System.Windows.Forms.Label
        Me.ntxtTDSRate = New Account.NumTextBox
        Me.ntxtTDS = New Account.NumTextBox
        Me.lblAdvance = New System.Windows.Forms.Label
        Me.ntxtAdvance = New Account.NumTextBox
        Me.lblStax = New System.Windows.Forms.Label
        Me.ntxtStax = New Account.NumTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ntxtSTRate = New Account.NumTextBox
        Me.pnlAdv = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblfrmargin = New System.Windows.Forms.Label
        Me.ntxtFrMarginPer = New Account.NumTextBox
        Me.ntxtFrMargin = New Account.NumTextBox
        Me.lblcash2 = New System.Windows.Forms.Label
        Me.ntxtCash2DrvByTrans = New Account.NumTextBox
        Me.lblcash1 = New System.Windows.Forms.Label
        Me.ntxtCash2Drv = New Account.NumTextBox
        Me.lbllabPer = New System.Windows.Forms.Label
        Me.lblLabour = New System.Windows.Forms.Label
        Me.ntxtLabPerc = New Account.NumTextBox
        Me.ntxtLabour = New Account.NumTextBox
        Me.lblDasti = New System.Windows.Forms.Label
        Me.ntxtDasti = New Account.NumTextBox
        Me.pnlTotal = New System.Windows.Forms.Panel
        Me.ntxtFrMarginRV = New Account.NumTextBox
        Me.lblRvFrMargin = New System.Windows.Forms.Label
        Me.ntxtTotAdv = New Account.NumTextBox
        Me.lblTotAdv = New System.Windows.Forms.Label
        Me.ntxtNetAmt = New Account.NumTextBox
        Me.dgv = New Account.DataGridViewEnter
        Me.ntxtVarGross = New Account.NumTextBox
        Me.ntxtGrossAmt = New Account.NumTextBox
        Me.txtNarration = New System.Windows.Forms.TextBox
        Me.lblNarration = New System.Windows.Forms.Label
        Me.pnlsave = New System.Windows.Forms.Panel
        Me.tbNav = New System.Windows.Forms.ToolStrip
        Me.tsbFirst = New System.Windows.Forms.ToolStripButton
        Me.tsbPrevious = New System.Windows.Forms.ToolStripButton
        Me.tsbNext = New System.Windows.Forms.ToolStripButton
        Me.tsbLast = New System.Windows.Forms.ToolStripButton
        Me.tsbSearch = New System.Windows.Forms.ToolStripButton
        Me.tsbRefresh = New System.Windows.Forms.ToolStripButton
        Me.tslGoto = New System.Windows.Forms.ToolStripLabel
        Me.tstChallan = New System.Windows.Forms.ToolStripTextBox
        Me.tsbGo = New System.Windows.Forms.ToolStripButton
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.numTWeight = New Account.NumTextBox
        Me.NumTbags = New Account.NumTextBox
        Me.tbEdit.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlcalc.SuspendLayout()
        Me.pnlAdv.SuspendLayout()
        Me.pnlTotal.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlsave.SuspendLayout()
        Me.tbNav.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbEdit
        '
        Me.tbEdit.AutoSize = False
        Me.tbEdit.Dock = System.Windows.Forms.DockStyle.None
        Me.tbEdit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNew, Me.tsbEdit, Me.tsbDelete, Me.tsbPrint})
        Me.tbEdit.Location = New System.Drawing.Point(9, 0)
        Me.tbEdit.Name = "tbEdit"
        Me.tbEdit.Size = New System.Drawing.Size(124, 25)
        Me.tbEdit.TabIndex = 0
        Me.tbEdit.Text = "ToolStrip1"
        '
        'tsbNew
        '
        Me.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNew.Image = CType(resources.GetObject("tsbNew.Image"), System.Drawing.Image)
        Me.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNew.Name = "tsbNew"
        Me.tsbNew.Size = New System.Drawing.Size(23, 22)
        Me.tsbNew.Text = "New"
        '
        'tsbEdit
        '
        Me.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEdit.Image = CType(resources.GetObject("tsbEdit.Image"), System.Drawing.Image)
        Me.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEdit.Name = "tsbEdit"
        Me.tsbEdit.Size = New System.Drawing.Size(23, 22)
        Me.tsbEdit.Text = "Edit"
        '
        'tsbDelete
        '
        Me.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbDelete.Image = CType(resources.GetObject("tsbDelete.Image"), System.Drawing.Image)
        Me.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDelete.Name = "tsbDelete"
        Me.tsbDelete.Size = New System.Drawing.Size(23, 22)
        Me.tsbDelete.Text = "Delete"
        '
        'tsbPrint
        '
        Me.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbPrint.Image = CType(resources.GetObject("tsbPrint.Image"), System.Drawing.Image)
        Me.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPrint.Name = "tsbPrint"
        Me.tsbPrint.Size = New System.Drawing.Size(23, 22)
        Me.tsbPrint.Text = "ToolStripButton1"
        '
        'lblChallanNo
        '
        Me.lblChallanNo.AutoSize = True
        Me.lblChallanNo.Location = New System.Drawing.Point(4, 8)
        Me.lblChallanNo.Name = "lblChallanNo"
        Me.lblChallanNo.Size = New System.Drawing.Size(62, 13)
        Me.lblChallanNo.TabIndex = 0
        Me.lblChallanNo.Text = "Challan No."
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(281, 7)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date"
        '
        'dtChallanDate
        '
        Me.dtChallanDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtChallanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtChallanDate.Location = New System.Drawing.Point(320, 3)
        Me.dtChallanDate.Name = "dtChallanDate"
        Me.dtChallanDate.Size = New System.Drawing.Size(90, 20)
        Me.dtChallanDate.TabIndex = 4
        '
        'lblTransporter
        '
        Me.lblTransporter.AutoSize = True
        Me.lblTransporter.Location = New System.Drawing.Point(4, 31)
        Me.lblTransporter.Name = "lblTransporter"
        Me.lblTransporter.Size = New System.Drawing.Size(61, 13)
        Me.lblTransporter.TabIndex = 7
        Me.lblTransporter.Text = "Transporter"
        '
        'cmbTransporter
        '
        Me.cmbTransporter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTransporter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTransporter.FormattingEnabled = True
        Me.cmbTransporter.Location = New System.Drawing.Point(63, 27)
        Me.cmbTransporter.Name = "cmbTransporter"
        Me.cmbTransporter.Size = New System.Drawing.Size(347, 21)
        Me.cmbTransporter.TabIndex = 8
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(416, 8)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(51, 13)
        Me.lblCustomer.TabIndex = 5
        Me.lblCustomer.Text = "Customer"
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.Location = New System.Drawing.Point(415, 10)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(104, 13)
        Me.lblNet.TabIndex = 4
        Me.lblNet.Text = "Net Amount Payable"
        '
        'lblGross
        '
        Me.lblGross.AutoSize = True
        Me.lblGross.Location = New System.Drawing.Point(688, 243)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(30, 13)
        Me.lblGross.TabIndex = 5
        Me.lblGross.Text = "Lorry"
        '
        'lblVarGross
        '
        Me.lblVarGross.AutoSize = True
        Me.lblVarGross.Location = New System.Drawing.Point(159, 243)
        Me.lblVarGross.Name = "lblVarGross"
        Me.lblVarGross.Size = New System.Drawing.Size(54, 13)
        Me.lblVarGross.TabIndex = 3
        Me.lblVarGross.Text = "Lorry (RV)"
        '
        'btnSave
        '
        Me.btnSave.Image = Global.Account.My.Resources.Resources.Save
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(59, 25)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.Account.My.Resources.Resources.cancel
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(65, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(61, 25)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'pnlMain
        '
        Me.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlMain.Controls.Add(Me.Panel1)
        Me.pnlMain.Controls.Add(Me.pnlcalc)
        Me.pnlMain.Controls.Add(Me.pnlAdv)
        Me.pnlMain.Controls.Add(Me.pnlTotal)
        Me.pnlMain.Controls.Add(Me.dgv)
        Me.pnlMain.Controls.Add(Me.ntxtVarGross)
        Me.pnlMain.Controls.Add(Me.ntxtGrossAmt)
        Me.pnlMain.Controls.Add(Me.txtNarration)
        Me.pnlMain.Controls.Add(Me.lblNarration)
        Me.pnlMain.Controls.Add(Me.lblVarGross)
        Me.pnlMain.Controls.Add(Me.lblGross)
        Me.pnlMain.Location = New System.Drawing.Point(8, 28)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(872, 425)
        Me.pnlMain.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtLorryno)
        Me.Panel1.Controls.Add(Me.ntxtChallan)
        Me.Panel1.Controls.Add(Me.txtOwner)
        Me.Panel1.Controls.Add(Me.lblOwner)
        Me.Panel1.Controls.Add(Me.txtDriver)
        Me.Panel1.Controls.Add(Me.lblDriver)
        Me.Panel1.Controls.Add(Me.txtDiNo)
        Me.Panel1.Controls.Add(Me.lblDiNo)
        Me.Panel1.Controls.Add(Me.dtLrDate)
        Me.Panel1.Controls.Add(Me.cmbTo)
        Me.Panel1.Controls.Add(Me.lblTo)
        Me.Panel1.Controls.Add(Me.lblLorryNo)
        Me.Panel1.Controls.Add(Me.lblShip)
        Me.Panel1.Controls.Add(Me.cmbCustomer)
        Me.Panel1.Controls.Add(Me.txtInv)
        Me.Panel1.Controls.Add(Me.txtShip)
        Me.Panel1.Controls.Add(Me.lblPrefix)
        Me.Panel1.Controls.Add(Me.lblLRDate)
        Me.Panel1.Controls.Add(Me.lblCustomer)
        Me.Panel1.Controls.Add(Me.dtChallanDate)
        Me.Panel1.Controls.Add(Me.txtLrNo)
        Me.Panel1.Controls.Add(Me.lblLR)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.cmbTransporter)
        Me.Panel1.Controls.Add(Me.lblTransporter)
        Me.Panel1.Controls.Add(Me.cmbPayableAt)
        Me.Panel1.Controls.Add(Me.lblPayableAt)
        Me.Panel1.Controls.Add(Me.cmbFrom)
        Me.Panel1.Controls.Add(Me.lblFrom)
        Me.Panel1.Controls.Add(Me.lblChallanNo)
        Me.Panel1.Location = New System.Drawing.Point(4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(860, 105)
        Me.Panel1.TabIndex = 1
        '
        'txtLorryno
        '
        Me.txtLorryno.Location = New System.Drawing.Point(489, 27)
        Me.txtLorryno.Name = "txtLorryno"
        Me.txtLorryno.Size = New System.Drawing.Size(94, 20)
        Me.txtLorryno.TabIndex = 29
        '
        'ntxtChallan
        '
        Me.ntxtChallan.dec = CType(0, Short)
        Me.ntxtChallan.format = "{0:F0}"
        Me.ntxtChallan.Location = New System.Drawing.Point(97, 4)
        Me.ntxtChallan.Name = "ntxtChallan"
        Me.ntxtChallan.Size = New System.Drawing.Size(100, 20)
        Me.ntxtChallan.TabIndex = 2
        Me.ntxtChallan.Text = "0"
        Me.ntxtChallan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtChallan.value = 0
        '
        'txtOwner
        '
        Me.txtOwner.Location = New System.Drawing.Point(256, 77)
        Me.txtOwner.Name = "txtOwner"
        Me.txtOwner.Size = New System.Drawing.Size(154, 20)
        Me.txtOwner.TabIndex = 16
        '
        'lblOwner
        '
        Me.lblOwner.AutoSize = True
        Me.lblOwner.Location = New System.Drawing.Point(201, 80)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(38, 13)
        Me.lblOwner.TabIndex = 15
        Me.lblOwner.Text = "Owner"
        '
        'txtDriver
        '
        Me.txtDriver.Location = New System.Drawing.Point(63, 75)
        Me.txtDriver.Name = "txtDriver"
        Me.txtDriver.Size = New System.Drawing.Size(134, 20)
        Me.txtDriver.TabIndex = 14
        '
        'lblDriver
        '
        Me.lblDriver.AutoSize = True
        Me.lblDriver.Location = New System.Drawing.Point(4, 80)
        Me.lblDriver.Name = "lblDriver"
        Me.lblDriver.Size = New System.Drawing.Size(35, 13)
        Me.lblDriver.TabIndex = 13
        Me.lblDriver.Text = "Driver"
        '
        'txtDiNo
        '
        Me.txtDiNo.Location = New System.Drawing.Point(489, 51)
        Me.txtDiNo.Name = "txtDiNo"
        Me.txtDiNo.Size = New System.Drawing.Size(136, 20)
        Me.txtDiNo.TabIndex = 20
        '
        'lblDiNo
        '
        Me.lblDiNo.AutoSize = True
        Me.lblDiNo.Location = New System.Drawing.Point(416, 56)
        Me.lblDiNo.Name = "lblDiNo"
        Me.lblDiNo.Size = New System.Drawing.Size(38, 13)
        Me.lblDiNo.TabIndex = 19
        Me.lblDiNo.Text = "DI No."
        '
        'dtLrDate
        '
        Me.dtLrDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtLrDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtLrDate.Location = New System.Drawing.Point(257, 52)
        Me.dtLrDate.Name = "dtLrDate"
        Me.dtLrDate.Size = New System.Drawing.Size(153, 20)
        Me.dtLrDate.TabIndex = 12
        '
        'cmbTo
        '
        Me.cmbTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTo.FormattingEnabled = True
        Me.cmbTo.Location = New System.Drawing.Point(706, 52)
        Me.cmbTo.Name = "cmbTo"
        Me.cmbTo.Size = New System.Drawing.Size(144, 21)
        Me.cmbTo.TabIndex = 26
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(647, 55)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(20, 13)
        Me.lblTo.TabIndex = 25
        Me.lblTo.Text = "To"
        '
        'lblLorryNo
        '
        Me.lblLorryNo.AutoSize = True
        Me.lblLorryNo.Location = New System.Drawing.Point(416, 31)
        Me.lblLorryNo.Name = "lblLorryNo"
        Me.lblLorryNo.Size = New System.Drawing.Size(50, 13)
        Me.lblLorryNo.TabIndex = 17
        Me.lblLorryNo.Text = "Lorry No."
        '
        'lblShip
        '
        Me.lblShip.AutoSize = True
        Me.lblShip.Location = New System.Drawing.Point(416, 81)
        Me.lblShip.Name = "lblShip"
        Me.lblShip.Size = New System.Drawing.Size(71, 13)
        Me.lblShip.TabIndex = 21
        Me.lblShip.Text = "Shipment No."
        '
        'cmbCustomer
        '
        Me.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCustomer.FormattingEnabled = True
        Me.cmbCustomer.Location = New System.Drawing.Point(489, 4)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(364, 21)
        Me.cmbCustomer.TabIndex = 6
        '
        'txtInv
        '
        Me.txtInv.Enabled = False
        Me.txtInv.Location = New System.Drawing.Point(589, 28)
        Me.txtInv.Name = "txtInv"
        Me.txtInv.Size = New System.Drawing.Size(39, 20)
        Me.txtInv.TabIndex = 18
        '
        'txtShip
        '
        Me.txtShip.Location = New System.Drawing.Point(489, 77)
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(138, 20)
        Me.txtShip.TabIndex = 22
        '
        'lblPrefix
        '
        Me.lblPrefix.AutoSize = True
        Me.lblPrefix.BackColor = System.Drawing.Color.White
        Me.lblPrefix.Location = New System.Drawing.Point(72, 8)
        Me.lblPrefix.Name = "lblPrefix"
        Me.lblPrefix.Size = New System.Drawing.Size(19, 13)
        Me.lblPrefix.TabIndex = 1
        Me.lblPrefix.Text = "----"
        Me.lblPrefix.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLRDate
        '
        Me.lblLRDate.AutoSize = True
        Me.lblLRDate.Location = New System.Drawing.Point(201, 54)
        Me.lblLRDate.Name = "lblLRDate"
        Me.lblLRDate.Size = New System.Drawing.Size(50, 13)
        Me.lblLRDate.TabIndex = 11
        Me.lblLRDate.Text = "L R Date"
        '
        'txtLrNo
        '
        Me.txtLrNo.Location = New System.Drawing.Point(63, 52)
        Me.txtLrNo.Name = "txtLrNo"
        Me.txtLrNo.Size = New System.Drawing.Size(134, 20)
        Me.txtLrNo.TabIndex = 10
        '
        'lblLR
        '
        Me.lblLR.AutoSize = True
        Me.lblLR.Location = New System.Drawing.Point(4, 56)
        Me.lblLR.Name = "lblLR"
        Me.lblLR.Size = New System.Drawing.Size(44, 13)
        Me.lblLR.TabIndex = 9
        Me.lblLR.Text = "L R No."
        '
        'cmbPayableAt
        '
        Me.cmbPayableAt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPayableAt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPayableAt.FormattingEnabled = True
        Me.cmbPayableAt.Location = New System.Drawing.Point(706, 77)
        Me.cmbPayableAt.Name = "cmbPayableAt"
        Me.cmbPayableAt.Size = New System.Drawing.Size(142, 21)
        Me.cmbPayableAt.TabIndex = 28
        '
        'lblPayableAt
        '
        Me.lblPayableAt.AutoSize = True
        Me.lblPayableAt.Location = New System.Drawing.Point(647, 80)
        Me.lblPayableAt.Name = "lblPayableAt"
        Me.lblPayableAt.Size = New System.Drawing.Size(58, 13)
        Me.lblPayableAt.TabIndex = 27
        Me.lblPayableAt.Text = "Payable At"
        '
        'cmbFrom
        '
        Me.cmbFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFrom.FormattingEnabled = True
        Me.cmbFrom.Location = New System.Drawing.Point(706, 28)
        Me.cmbFrom.Name = "cmbFrom"
        Me.cmbFrom.Size = New System.Drawing.Size(144, 21)
        Me.cmbFrom.TabIndex = 24
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(647, 31)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblFrom.TabIndex = 23
        Me.lblFrom.Text = "From"
        '
        'pnlcalc
        '
        Me.pnlcalc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlcalc.Controls.Add(Me.cmbSTon)
        Me.pnlcalc.Controls.Add(Me.lblOther2)
        Me.pnlcalc.Controls.Add(Me.ntxtOther2)
        Me.pnlcalc.Controls.Add(Me.Label2)
        Me.pnlcalc.Controls.Add(Me.ntxtOther1)
        Me.pnlcalc.Controls.Add(Me.Label1)
        Me.pnlcalc.Controls.Add(Me.lblTDS)
        Me.pnlcalc.Controls.Add(Me.ntxtTDSRate)
        Me.pnlcalc.Controls.Add(Me.ntxtTDS)
        Me.pnlcalc.Controls.Add(Me.lblAdvance)
        Me.pnlcalc.Controls.Add(Me.ntxtAdvance)
        Me.pnlcalc.Controls.Add(Me.lblStax)
        Me.pnlcalc.Controls.Add(Me.ntxtStax)
        Me.pnlcalc.Controls.Add(Me.Label3)
        Me.pnlcalc.Controls.Add(Me.ntxtSTRate)
        Me.pnlcalc.Location = New System.Drawing.Point(505, 262)
        Me.pnlcalc.Name = "pnlcalc"
        Me.pnlcalc.Size = New System.Drawing.Size(354, 112)
        Me.pnlcalc.TabIndex = 9
        '
        'cmbSTon
        '
        Me.cmbSTon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSTon.FormattingEnabled = True
        Me.cmbSTon.Items.AddRange(New Object() {"Lorry", "Consignee"})
        Me.cmbSTon.Location = New System.Drawing.Point(88, 82)
        Me.cmbSTon.Name = "cmbSTon"
        Me.cmbSTon.Size = New System.Drawing.Size(78, 21)
        Me.cmbSTon.TabIndex = 11
        '
        'lblOther2
        '
        Me.lblOther2.AutoSize = True
        Me.lblOther2.Location = New System.Drawing.Point(85, 66)
        Me.lblOther2.Name = "lblOther2"
        Me.lblOther2.Size = New System.Drawing.Size(48, 13)
        Me.lblOther2.TabIndex = 8
        Me.lblOther2.Text = "Other - 2"
        '
        'ntxtOther2
        '
        Me.ntxtOther2.AllowNegative = True
        Me.ntxtOther2.dec = CType(2, Short)
        Me.ntxtOther2.format = Nothing
        Me.ntxtOther2.Location = New System.Drawing.Point(249, 63)
        Me.ntxtOther2.Name = "ntxtOther2"
        Me.ntxtOther2.Size = New System.Drawing.Size(100, 20)
        Me.ntxtOther2.TabIndex = 9
        Me.ntxtOther2.Text = "0.00"
        Me.ntxtOther2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtOther2.value = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Other - 1"
        '
        'ntxtOther1
        '
        Me.ntxtOther1.dec = CType(2, Short)
        Me.ntxtOther1.format = Nothing
        Me.ntxtOther1.Location = New System.Drawing.Point(249, 43)
        Me.ntxtOther1.Name = "ntxtOther1"
        Me.ntxtOther1.Size = New System.Drawing.Size(100, 20)
        Me.ntxtOther1.TabIndex = 7
        Me.ntxtOther1.Text = "0.00"
        Me.ntxtOther1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtOther1.value = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(221, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "%"
        '
        'lblTDS
        '
        Me.lblTDS.AutoSize = True
        Me.lblTDS.Location = New System.Drawing.Point(85, 29)
        Me.lblTDS.Name = "lblTDS"
        Me.lblTDS.Size = New System.Drawing.Size(70, 13)
        Me.lblTDS.TabIndex = 2
        Me.lblTDS.Text = "TDS on Lorry"
        '
        'ntxtTDSRate
        '
        Me.ntxtTDSRate.dec = CType(2, Short)
        Me.ntxtTDSRate.format = Nothing
        Me.ntxtTDSRate.Location = New System.Drawing.Point(176, 23)
        Me.ntxtTDSRate.Name = "ntxtTDSRate"
        Me.ntxtTDSRate.Size = New System.Drawing.Size(39, 20)
        Me.ntxtTDSRate.TabIndex = 3
        Me.ntxtTDSRate.Text = "0.00"
        Me.ntxtTDSRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtTDSRate.value = 0
        '
        'ntxtTDS
        '
        Me.ntxtTDS.dec = CType(2, Short)
        Me.ntxtTDS.format = Nothing
        Me.ntxtTDS.Location = New System.Drawing.Point(249, 23)
        Me.ntxtTDS.Name = "ntxtTDS"
        Me.ntxtTDS.Size = New System.Drawing.Size(100, 20)
        Me.ntxtTDS.TabIndex = 5
        Me.ntxtTDS.Text = "0.00"
        Me.ntxtTDS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtTDS.value = 0
        '
        'lblAdvance
        '
        Me.lblAdvance.AutoSize = True
        Me.lblAdvance.Location = New System.Drawing.Point(85, 6)
        Me.lblAdvance.Name = "lblAdvance"
        Me.lblAdvance.Size = New System.Drawing.Size(119, 13)
        Me.lblAdvance.TabIndex = 0
        Me.lblAdvance.Text = "Advance to Transporter"
        '
        'ntxtAdvance
        '
        Me.ntxtAdvance.dec = CType(2, Short)
        Me.ntxtAdvance.format = Nothing
        Me.ntxtAdvance.Location = New System.Drawing.Point(249, 3)
        Me.ntxtAdvance.Name = "ntxtAdvance"
        Me.ntxtAdvance.ReadOnly = True
        Me.ntxtAdvance.Size = New System.Drawing.Size(100, 20)
        Me.ntxtAdvance.TabIndex = 1
        Me.ntxtAdvance.TabStop = False
        Me.ntxtAdvance.Text = "0.00"
        Me.ntxtAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtAdvance.value = 0
        '
        'lblStax
        '
        Me.lblStax.AutoSize = True
        Me.lblStax.Location = New System.Drawing.Point(3, 86)
        Me.lblStax.Name = "lblStax"
        Me.lblStax.Size = New System.Drawing.Size(79, 13)
        Me.lblStax.TabIndex = 10
        Me.lblStax.Text = "Service Tax on"
        '
        'ntxtStax
        '
        Me.ntxtStax.dec = CType(2, Short)
        Me.ntxtStax.format = Nothing
        Me.ntxtStax.Location = New System.Drawing.Point(249, 83)
        Me.ntxtStax.Name = "ntxtStax"
        Me.ntxtStax.Size = New System.Drawing.Size(100, 20)
        Me.ntxtStax.TabIndex = 14
        Me.ntxtStax.Text = "0.00"
        Me.ntxtStax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtStax.value = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "%"
        '
        'ntxtSTRate
        '
        Me.ntxtSTRate.dec = CType(2, Short)
        Me.ntxtSTRate.format = Nothing
        Me.ntxtSTRate.Location = New System.Drawing.Point(176, 84)
        Me.ntxtSTRate.Name = "ntxtSTRate"
        Me.ntxtSTRate.Size = New System.Drawing.Size(39, 20)
        Me.ntxtSTRate.TabIndex = 12
        Me.ntxtSTRate.Text = "0.00"
        Me.ntxtSTRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtSTRate.value = 0
        '
        'pnlAdv
        '
        Me.pnlAdv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlAdv.Controls.Add(Me.Label4)
        Me.pnlAdv.Controls.Add(Me.lblfrmargin)
        Me.pnlAdv.Controls.Add(Me.ntxtFrMarginPer)
        Me.pnlAdv.Controls.Add(Me.ntxtFrMargin)
        Me.pnlAdv.Controls.Add(Me.lblcash2)
        Me.pnlAdv.Controls.Add(Me.ntxtCash2DrvByTrans)
        Me.pnlAdv.Controls.Add(Me.lblcash1)
        Me.pnlAdv.Controls.Add(Me.ntxtCash2Drv)
        Me.pnlAdv.Controls.Add(Me.lbllabPer)
        Me.pnlAdv.Controls.Add(Me.lblLabour)
        Me.pnlAdv.Controls.Add(Me.ntxtLabPerc)
        Me.pnlAdv.Controls.Add(Me.ntxtLabour)
        Me.pnlAdv.Controls.Add(Me.lblDasti)
        Me.pnlAdv.Controls.Add(Me.ntxtDasti)
        Me.pnlAdv.Location = New System.Drawing.Point(224, 262)
        Me.pnlAdv.Name = "pnlAdv"
        Me.pnlAdv.Size = New System.Drawing.Size(275, 112)
        Me.pnlAdv.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "%"
        '
        'lblfrmargin
        '
        Me.lblfrmargin.AutoSize = True
        Me.lblfrmargin.Location = New System.Drawing.Point(0, 48)
        Me.lblfrmargin.Name = "lblfrmargin"
        Me.lblfrmargin.Size = New System.Drawing.Size(74, 13)
        Me.lblfrmargin.TabIndex = 6
        Me.lblfrmargin.Text = "Freight Margin"
        '
        'ntxtFrMarginPer
        '
        Me.ntxtFrMarginPer.dec = CType(2, Short)
        Me.ntxtFrMarginPer.format = Nothing
        Me.ntxtFrMarginPer.Location = New System.Drawing.Point(88, 45)
        Me.ntxtFrMarginPer.Name = "ntxtFrMarginPer"
        Me.ntxtFrMarginPer.Size = New System.Drawing.Size(39, 20)
        Me.ntxtFrMarginPer.TabIndex = 7
        Me.ntxtFrMarginPer.Text = "0.00"
        Me.ntxtFrMarginPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtFrMarginPer.value = 0
        '
        'ntxtFrMargin
        '
        Me.ntxtFrMargin.dec = CType(2, Short)
        Me.ntxtFrMargin.format = Nothing
        Me.ntxtFrMargin.Location = New System.Drawing.Point(152, 43)
        Me.ntxtFrMargin.Name = "ntxtFrMargin"
        Me.ntxtFrMargin.Size = New System.Drawing.Size(100, 20)
        Me.ntxtFrMargin.TabIndex = 9
        Me.ntxtFrMargin.Text = "0.00"
        Me.ntxtFrMargin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtFrMargin.value = 0
        '
        'lblcash2
        '
        Me.lblcash2.AutoSize = True
        Me.lblcash2.Location = New System.Drawing.Point(0, 86)
        Me.lblcash2.Name = "lblcash2"
        Me.lblcash2.Size = New System.Drawing.Size(56, 13)
        Me.lblcash2.TabIndex = 12
        Me.lblcash2.Text = "Cash Next"
        '
        'ntxtCash2DrvByTrans
        '
        Me.ntxtCash2DrvByTrans.dec = CType(2, Short)
        Me.ntxtCash2DrvByTrans.format = Nothing
        Me.ntxtCash2DrvByTrans.Location = New System.Drawing.Point(152, 83)
        Me.ntxtCash2DrvByTrans.Name = "ntxtCash2DrvByTrans"
        Me.ntxtCash2DrvByTrans.Size = New System.Drawing.Size(100, 20)
        Me.ntxtCash2DrvByTrans.TabIndex = 13
        Me.ntxtCash2DrvByTrans.Text = "0.00"
        Me.ntxtCash2DrvByTrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtCash2DrvByTrans.value = 0
        '
        'lblcash1
        '
        Me.lblcash1.AutoSize = True
        Me.lblcash1.Location = New System.Drawing.Point(0, 66)
        Me.lblcash1.Name = "lblcash1"
        Me.lblcash1.Size = New System.Drawing.Size(74, 13)
        Me.lblcash1.TabIndex = 10
        Me.lblcash1.Text = "Cash to Driver"
        '
        'ntxtCash2Drv
        '
        Me.ntxtCash2Drv.dec = CType(2, Short)
        Me.ntxtCash2Drv.format = Nothing
        Me.ntxtCash2Drv.Location = New System.Drawing.Point(152, 63)
        Me.ntxtCash2Drv.Name = "ntxtCash2Drv"
        Me.ntxtCash2Drv.Size = New System.Drawing.Size(100, 20)
        Me.ntxtCash2Drv.TabIndex = 11
        Me.ntxtCash2Drv.Text = "0.00"
        Me.ntxtCash2Drv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtCash2Drv.value = 0
        '
        'lbllabPer
        '
        Me.lbllabPer.AutoSize = True
        Me.lbllabPer.Location = New System.Drawing.Point(127, 28)
        Me.lbllabPer.Name = "lbllabPer"
        Me.lbllabPer.Size = New System.Drawing.Size(15, 13)
        Me.lbllabPer.TabIndex = 4
        Me.lbllabPer.Text = "%"
        '
        'lblLabour
        '
        Me.lblLabour.AutoSize = True
        Me.lblLabour.Location = New System.Drawing.Point(0, 28)
        Me.lblLabour.Name = "lblLabour"
        Me.lblLabour.Size = New System.Drawing.Size(40, 13)
        Me.lblLabour.TabIndex = 2
        Me.lblLabour.Text = "Labour"
        '
        'ntxtLabPerc
        '
        Me.ntxtLabPerc.dec = CType(2, Short)
        Me.ntxtLabPerc.format = Nothing
        Me.ntxtLabPerc.Location = New System.Drawing.Point(88, 25)
        Me.ntxtLabPerc.Name = "ntxtLabPerc"
        Me.ntxtLabPerc.Size = New System.Drawing.Size(39, 20)
        Me.ntxtLabPerc.TabIndex = 3
        Me.ntxtLabPerc.Text = "0.00"
        Me.ntxtLabPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtLabPerc.value = 0
        '
        'ntxtLabour
        '
        Me.ntxtLabour.dec = CType(2, Short)
        Me.ntxtLabour.format = Nothing
        Me.ntxtLabour.Location = New System.Drawing.Point(152, 23)
        Me.ntxtLabour.Name = "ntxtLabour"
        Me.ntxtLabour.Size = New System.Drawing.Size(100, 20)
        Me.ntxtLabour.TabIndex = 5
        Me.ntxtLabour.Text = "0.00"
        Me.ntxtLabour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtLabour.value = 0
        '
        'lblDasti
        '
        Me.lblDasti.AutoSize = True
        Me.lblDasti.Location = New System.Drawing.Point(0, 6)
        Me.lblDasti.Name = "lblDasti"
        Me.lblDasti.Size = New System.Drawing.Size(31, 13)
        Me.lblDasti.TabIndex = 0
        Me.lblDasti.Text = "Dasti"
        '
        'ntxtDasti
        '
        Me.ntxtDasti.dec = CType(2, Short)
        Me.ntxtDasti.format = Nothing
        Me.ntxtDasti.Location = New System.Drawing.Point(152, 3)
        Me.ntxtDasti.Name = "ntxtDasti"
        Me.ntxtDasti.Size = New System.Drawing.Size(100, 20)
        Me.ntxtDasti.TabIndex = 1
        Me.ntxtDasti.Text = "0.00"
        Me.ntxtDasti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtDasti.value = 0
        '
        'pnlTotal
        '
        Me.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlTotal.Controls.Add(Me.ntxtFrMarginRV)
        Me.pnlTotal.Controls.Add(Me.lblRvFrMargin)
        Me.pnlTotal.Controls.Add(Me.ntxtTotAdv)
        Me.pnlTotal.Controls.Add(Me.lblTotAdv)
        Me.pnlTotal.Controls.Add(Me.ntxtNetAmt)
        Me.pnlTotal.Controls.Add(Me.lblNet)
        Me.pnlTotal.Location = New System.Drawing.Point(224, 377)
        Me.pnlTotal.Name = "pnlTotal"
        Me.pnlTotal.Size = New System.Drawing.Size(641, 37)
        Me.pnlTotal.TabIndex = 10
        '
        'ntxtFrMarginRV
        '
        Me.ntxtFrMarginRV.dec = CType(2, Short)
        Me.ntxtFrMarginRV.format = Nothing
        Me.ntxtFrMarginRV.Location = New System.Drawing.Point(114, 6)
        Me.ntxtFrMarginRV.Name = "ntxtFrMarginRV"
        Me.ntxtFrMarginRV.ReadOnly = True
        Me.ntxtFrMarginRV.Size = New System.Drawing.Size(100, 20)
        Me.ntxtFrMarginRV.TabIndex = 1
        Me.ntxtFrMarginRV.TabStop = False
        Me.ntxtFrMarginRV.Text = "0.00"
        Me.ntxtFrMarginRV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtFrMarginRV.value = 0
        '
        'lblRvFrMargin
        '
        Me.lblRvFrMargin.AutoSize = True
        Me.lblRvFrMargin.Location = New System.Drawing.Point(9, 10)
        Me.lblRvFrMargin.Name = "lblRvFrMargin"
        Me.lblRvFrMargin.Size = New System.Drawing.Size(98, 13)
        Me.lblRvFrMargin.TabIndex = 0
        Me.lblRvFrMargin.Text = "Freight Margin (RV)"
        '
        'ntxtTotAdv
        '
        Me.ntxtTotAdv.dec = CType(2, Short)
        Me.ntxtTotAdv.format = Nothing
        Me.ntxtTotAdv.Location = New System.Drawing.Point(301, 6)
        Me.ntxtTotAdv.Name = "ntxtTotAdv"
        Me.ntxtTotAdv.ReadOnly = True
        Me.ntxtTotAdv.Size = New System.Drawing.Size(100, 20)
        Me.ntxtTotAdv.TabIndex = 3
        Me.ntxtTotAdv.TabStop = False
        Me.ntxtTotAdv.Text = "0.00"
        Me.ntxtTotAdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtTotAdv.value = 0
        '
        'lblTotAdv
        '
        Me.lblTotAdv.AutoSize = True
        Me.lblTotAdv.Location = New System.Drawing.Point(218, 10)
        Me.lblTotAdv.Name = "lblTotAdv"
        Me.lblTotAdv.Size = New System.Drawing.Size(77, 13)
        Me.lblTotAdv.TabIndex = 2
        Me.lblTotAdv.Text = "Total Advance"
        '
        'ntxtNetAmt
        '
        Me.ntxtNetAmt.dec = CType(2, Short)
        Me.ntxtNetAmt.format = Nothing
        Me.ntxtNetAmt.Location = New System.Drawing.Point(530, 6)
        Me.ntxtNetAmt.Name = "ntxtNetAmt"
        Me.ntxtNetAmt.ReadOnly = True
        Me.ntxtNetAmt.Size = New System.Drawing.Size(100, 20)
        Me.ntxtNetAmt.TabIndex = 5
        Me.ntxtNetAmt.TabStop = False
        Me.ntxtNetAmt.Text = "0.00"
        Me.ntxtNetAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtNetAmt.value = 0
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(8, 114)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(848, 123)
        Me.dgv.TabIndex = 1
        '
        'ntxtVarGross
        '
        Me.ntxtVarGross.dec = CType(2, Short)
        Me.ntxtVarGross.format = Nothing
        Me.ntxtVarGross.Location = New System.Drawing.Point(311, 240)
        Me.ntxtVarGross.Name = "ntxtVarGross"
        Me.ntxtVarGross.ReadOnly = True
        Me.ntxtVarGross.Size = New System.Drawing.Size(100, 20)
        Me.ntxtVarGross.TabIndex = 4
        Me.ntxtVarGross.TabStop = False
        Me.ntxtVarGross.Text = "0.00"
        Me.ntxtVarGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtVarGross.value = 0
        '
        'ntxtGrossAmt
        '
        Me.ntxtGrossAmt.dec = CType(2, Short)
        Me.ntxtGrossAmt.format = Nothing
        Me.ntxtGrossAmt.Location = New System.Drawing.Point(754, 240)
        Me.ntxtGrossAmt.Name = "ntxtGrossAmt"
        Me.ntxtGrossAmt.ReadOnly = True
        Me.ntxtGrossAmt.Size = New System.Drawing.Size(100, 20)
        Me.ntxtGrossAmt.TabIndex = 6
        Me.ntxtGrossAmt.TabStop = False
        Me.ntxtGrossAmt.Text = "0.00"
        Me.ntxtGrossAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtGrossAmt.value = 0
        '
        'txtNarration
        '
        Me.txtNarration.Location = New System.Drawing.Point(11, 262)
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.Size = New System.Drawing.Size(209, 152)
        Me.txtNarration.TabIndex = 7
        '
        'lblNarration
        '
        Me.lblNarration.AutoSize = True
        Me.lblNarration.Location = New System.Drawing.Point(9, 243)
        Me.lblNarration.Name = "lblNarration"
        Me.lblNarration.Size = New System.Drawing.Size(50, 13)
        Me.lblNarration.TabIndex = 2
        Me.lblNarration.Text = "Narration"
        '
        'pnlsave
        '
        Me.pnlsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlsave.Controls.Add(Me.btnCancel)
        Me.pnlsave.Controls.Add(Me.btnSave)
        Me.pnlsave.Location = New System.Drawing.Point(747, 457)
        Me.pnlsave.Name = "pnlsave"
        Me.pnlsave.Size = New System.Drawing.Size(128, 30)
        Me.pnlsave.TabIndex = 3
        '
        'tbNav
        '
        Me.tbNav.AutoSize = False
        Me.tbNav.Dock = System.Windows.Forms.DockStyle.None
        Me.tbNav.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbFirst, Me.tsbPrevious, Me.tsbNext, Me.tsbLast, Me.tsbSearch, Me.tsbRefresh, Me.tslGoto, Me.tstChallan, Me.tsbGo})
        Me.tbNav.Location = New System.Drawing.Point(152, 0)
        Me.tbNav.Name = "tbNav"
        Me.tbNav.Size = New System.Drawing.Size(523, 25)
        Me.tbNav.TabIndex = 1
        Me.tbNav.Text = "ToolStrip1"
        '
        'tsbFirst
        '
        Me.tsbFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbFirst.Image = CType(resources.GetObject("tsbFirst.Image"), System.Drawing.Image)
        Me.tsbFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbFirst.Name = "tsbFirst"
        Me.tsbFirst.Size = New System.Drawing.Size(23, 22)
        Me.tsbFirst.Text = "First Record"
        '
        'tsbPrevious
        '
        Me.tsbPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbPrevious.Image = CType(resources.GetObject("tsbPrevious.Image"), System.Drawing.Image)
        Me.tsbPrevious.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPrevious.Name = "tsbPrevious"
        Me.tsbPrevious.Size = New System.Drawing.Size(23, 22)
        Me.tsbPrevious.Text = "Previous Record"
        '
        'tsbNext
        '
        Me.tsbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNext.Image = CType(resources.GetObject("tsbNext.Image"), System.Drawing.Image)
        Me.tsbNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNext.Name = "tsbNext"
        Me.tsbNext.Size = New System.Drawing.Size(23, 22)
        Me.tsbNext.Text = "Next Record"
        '
        'tsbLast
        '
        Me.tsbLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbLast.Image = CType(resources.GetObject("tsbLast.Image"), System.Drawing.Image)
        Me.tsbLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLast.Name = "tsbLast"
        Me.tsbLast.Size = New System.Drawing.Size(23, 22)
        Me.tsbLast.Text = "Last Record"
        '
        'tsbSearch
        '
        Me.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSearch.Image = CType(resources.GetObject("tsbSearch.Image"), System.Drawing.Image)
        Me.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSearch.Name = "tsbSearch"
        Me.tsbSearch.Size = New System.Drawing.Size(23, 22)
        Me.tsbSearch.Text = "Search"
        '
        'tsbRefresh
        '
        Me.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRefresh.Image = CType(resources.GetObject("tsbRefresh.Image"), System.Drawing.Image)
        Me.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefresh.Name = "tsbRefresh"
        Me.tsbRefresh.Size = New System.Drawing.Size(23, 22)
        Me.tsbRefresh.Text = "Refresh"
        '
        'tslGoto
        '
        Me.tslGoto.Name = "tslGoto"
        Me.tslGoto.Size = New System.Drawing.Size(69, 22)
        Me.tslGoto.Text = "Challan No."
        '
        'tstChallan
        '
        Me.tstChallan.Name = "tstChallan"
        Me.tstChallan.Size = New System.Drawing.Size(50, 25)
        '
        'tsbGo
        '
        Me.tsbGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbGo.Image = CType(resources.GetObject("tsbGo.Image"), System.Drawing.Image)
        Me.tsbGo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGo.Name = "tsbGo"
        Me.tsbGo.Size = New System.Drawing.Size(26, 22)
        Me.tsbGo.Text = "&Go"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'numTWeight
        '
        Me.numTWeight.dec = CType(2, Short)
        Me.numTWeight.format = Nothing
        Me.numTWeight.Location = New System.Drawing.Point(152, 457)
        Me.numTWeight.Name = "numTWeight"
        Me.numTWeight.Size = New System.Drawing.Size(100, 20)
        Me.numTWeight.TabIndex = 4
        Me.numTWeight.Text = "0.00"
        Me.numTWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numTWeight.value = 0
        Me.numTWeight.Visible = False
        '
        'NumTbags
        '
        Me.NumTbags.dec = CType(2, Short)
        Me.NumTbags.format = Nothing
        Me.NumTbags.Location = New System.Drawing.Point(32, 457)
        Me.NumTbags.Name = "NumTbags"
        Me.NumTbags.Size = New System.Drawing.Size(100, 20)
        Me.NumTbags.TabIndex = 4
        Me.NumTbags.Text = "0.00"
        Me.NumTbags.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumTbags.value = 0
        Me.NumTbags.Visible = False
        '
        'TransChallan2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 489)
        Me.Controls.Add(Me.numTWeight)
        Me.Controls.Add(Me.NumTbags)
        Me.Controls.Add(Me.tbNav)
        Me.Controls.Add(Me.pnlsave)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.tbEdit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "TransChallan2"
        Me.Text = "Challan"
        Me.tbEdit.ResumeLayout(False)
        Me.tbEdit.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlcalc.ResumeLayout(False)
        Me.pnlcalc.PerformLayout()
        Me.pnlAdv.ResumeLayout(False)
        Me.pnlAdv.PerformLayout()
        Me.pnlTotal.ResumeLayout(False)
        Me.pnlTotal.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlsave.ResumeLayout(False)
        Me.tbNav.ResumeLayout(False)
        Me.tbNav.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbEdit As System.Windows.Forms.ToolStrip
    Friend WithEvents lblChallanNo As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents dtChallanDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTransporter As System.Windows.Forms.Label
    Friend WithEvents cmbTransporter As System.Windows.Forms.ComboBox
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents lblNet As System.Windows.Forms.Label
    Friend WithEvents lblGross As System.Windows.Forms.Label
    Friend WithEvents lblVarGross As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlsave As System.Windows.Forms.Panel
    Friend WithEvents tbNav As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbPrevious As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtLrNo As System.Windows.Forms.TextBox
    Friend WithEvents lblLR As System.Windows.Forms.Label
    Friend WithEvents cmbFrom As System.Windows.Forms.ComboBox
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents dtLrDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDiNo As System.Windows.Forms.TextBox
    Friend WithEvents lblDiNo As System.Windows.Forms.Label
    Friend WithEvents lblShip As System.Windows.Forms.Label
    Friend WithEvents lblLRDate As System.Windows.Forms.Label
    Friend WithEvents txtShip As System.Windows.Forms.TextBox
    Friend WithEvents lblPrefix As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTo As System.Windows.Forms.ComboBox
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents cmbPayableAt As System.Windows.Forms.ComboBox
    Friend WithEvents lblPayableAt As System.Windows.Forms.Label
    Friend WithEvents lblLorryNo As System.Windows.Forms.Label
    Friend WithEvents txtInv As System.Windows.Forms.TextBox
    Friend WithEvents txtOwner As System.Windows.Forms.TextBox
    Friend WithEvents lblOwner As System.Windows.Forms.Label
    Friend WithEvents txtDriver As System.Windows.Forms.TextBox
    Friend WithEvents lblDriver As System.Windows.Forms.Label
    Friend WithEvents ntxtGrossAmt As Account.NumTextBox
    Friend WithEvents ntxtChallan As Account.NumTextBox
    Friend WithEvents ntxtNetAmt As Account.NumTextBox
    Friend WithEvents ntxtVarGross As Account.NumTextBox
    Friend WithEvents txtNarration As System.Windows.Forms.TextBox
    Friend WithEvents lblNarration As System.Windows.Forms.Label
    Friend WithEvents tslGoto As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstChallan As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbGo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblDasti As System.Windows.Forms.Label
    Friend WithEvents ntxtDasti As Account.NumTextBox
    Friend WithEvents lbllabPer As System.Windows.Forms.Label
    Friend WithEvents lblLabour As System.Windows.Forms.Label
    Friend WithEvents ntxtLabPerc As Account.NumTextBox
    Friend WithEvents ntxtLabour As Account.NumTextBox
    Friend WithEvents lblAdvance As System.Windows.Forms.Label
    Friend WithEvents ntxtAdvance As Account.NumTextBox
    Friend WithEvents lblStax As System.Windows.Forms.Label
    Friend WithEvents ntxtStax As Account.NumTextBox
    Friend WithEvents lblcash2 As System.Windows.Forms.Label
    Friend WithEvents ntxtCash2DrvByTrans As Account.NumTextBox
    Friend WithEvents lblcash1 As System.Windows.Forms.Label
    Friend WithEvents ntxtCash2Drv As Account.NumTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTDS As System.Windows.Forms.Label
    Friend WithEvents ntxtTDSRate As Account.NumTextBox
    Friend WithEvents ntxtTDS As Account.NumTextBox
    Friend WithEvents lblOther2 As System.Windows.Forms.Label
    Friend WithEvents ntxtOther2 As Account.NumTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ntxtOther1 As Account.NumTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ntxtSTRate As Account.NumTextBox
    Friend WithEvents dgv As Account.DataGridViewEnter
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblfrmargin As System.Windows.Forms.Label
    Friend WithEvents ntxtFrMarginPer As Account.NumTextBox
    Friend WithEvents ntxtFrMargin As Account.NumTextBox
    Friend WithEvents ntxtTotAdv As Account.NumTextBox
    Friend WithEvents lblTotAdv As System.Windows.Forms.Label
    Friend WithEvents ntxtFrMarginRV As Account.NumTextBox
    Friend WithEvents lblRvFrMargin As System.Windows.Forms.Label
    Friend WithEvents pnlAdv As System.Windows.Forms.Panel
    Friend WithEvents pnlTotal As System.Windows.Forms.Panel
    Friend WithEvents cmbSTon As System.Windows.Forms.ComboBox
    Friend WithEvents pnlcalc As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtLorryno As System.Windows.Forms.TextBox
    Friend WithEvents numTWeight As Account.NumTextBox
    Friend WithEvents NumTbags As Account.NumTextBox
End Class

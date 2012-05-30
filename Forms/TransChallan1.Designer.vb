<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChallan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChallan))
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
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.lblNet = New System.Windows.Forms.Label
        Me.lblGross = New System.Windows.Forms.Label
        Me.lblVarGross = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.pnlmain = New System.Windows.Forms.Panel
        Me.txtOwner = New System.Windows.Forms.TextBox
        Me.lblOwner = New System.Windows.Forms.Label
        Me.txtDriver = New System.Windows.Forms.TextBox
        Me.lblDriver = New System.Windows.Forms.Label
        Me.txtDiNo = New System.Windows.Forms.TextBox
        Me.lblDiNo = New System.Windows.Forms.Label
        Me.dtLrDate = New System.Windows.Forms.DateTimePicker
        Me.cmbTo = New System.Windows.Forms.ComboBox
        Me.dgvCharges = New System.Windows.Forms.DataGridView
        Me.lblTo = New System.Windows.Forms.Label
        Me.lblinv = New System.Windows.Forms.Label
        Me.lblShip = New System.Windows.Forms.Label
        Me.cmbCustomer = New System.Windows.Forms.ComboBox
        Me.txtInv = New System.Windows.Forms.TextBox
        Me.txtShip = New System.Windows.Forms.TextBox
        Me.lblGridMessage = New System.Windows.Forms.Label
        Me.lblPrefix = New System.Windows.Forms.Label
        Me.cmbLorry = New System.Windows.Forms.ComboBox
        Me.lblLorry = New System.Windows.Forms.Label
        Me.lblLRDate = New System.Windows.Forms.Label
        Me.txtNarration = New System.Windows.Forms.TextBox
        Me.lblNarration = New System.Windows.Forms.Label
        Me.txtLrNo = New System.Windows.Forms.TextBox
        Me.lblLR = New System.Windows.Forms.Label
        Me.cmbPayableAt = New System.Windows.Forms.ComboBox
        Me.lblPayableAt = New System.Windows.Forms.Label
        Me.cmbFrom = New System.Windows.Forms.ComboBox
        Me.lblFrom = New System.Windows.Forms.Label
        Me.pnlsave = New System.Windows.Forms.Panel
        Me.tbNav = New System.Windows.Forms.ToolStrip
        Me.tsbFirst = New System.Windows.Forms.ToolStripButton
        Me.tsbPrevious = New System.Windows.Forms.ToolStripButton
        Me.tsbNext = New System.Windows.Forms.ToolStripButton
        Me.tsbLast = New System.Windows.Forms.ToolStripButton
        Me.tsbSearch = New System.Windows.Forms.ToolStripButton
        Me.tsbRefresh = New System.Windows.Forms.ToolStripButton
        Me.tscBook = New System.Windows.Forms.ToolStripComboBox
        Me.tslGoto = New System.Windows.Forms.ToolStripLabel
        Me.tstChallan = New System.Windows.Forms.ToolStripTextBox
        Me.tsbGo = New System.Windows.Forms.ToolStripButton
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ntxtNetAmt = New Account.NumTextBox
        Me.ntxtVarGross = New Account.NumTextBox
        Me.ntxtChallan = New Account.NumTextBox
        Me.ntxtGrossAmt = New Account.NumTextBox
        Me.tbEdit.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlmain.SuspendLayout()
        CType(Me.dgvCharges, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblChallanNo.Location = New System.Drawing.Point(8, 8)
        Me.lblChallanNo.Name = "lblChallanNo"
        Me.lblChallanNo.Size = New System.Drawing.Size(62, 13)
        Me.lblChallanNo.TabIndex = 0
        Me.lblChallanNo.Text = "Challan No."
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(202, 8)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date"
        '
        'dtChallanDate
        '
        Me.dtChallanDate.CustomFormat = "dd/MM/yyyy"
        Me.dtChallanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtChallanDate.Location = New System.Drawing.Point(241, 4)
        Me.dtChallanDate.Name = "dtChallanDate"
        Me.dtChallanDate.Size = New System.Drawing.Size(86, 20)
        Me.dtChallanDate.TabIndex = 4
        '
        'lblTransporter
        '
        Me.lblTransporter.AutoSize = True
        Me.lblTransporter.Location = New System.Drawing.Point(8, 35)
        Me.lblTransporter.Name = "lblTransporter"
        Me.lblTransporter.Size = New System.Drawing.Size(61, 13)
        Me.lblTransporter.TabIndex = 7
        Me.lblTransporter.Text = "Transporter"
        '
        'cmbTransporter
        '
        Me.cmbTransporter.FormattingEnabled = True
        Me.cmbTransporter.Location = New System.Drawing.Point(76, 31)
        Me.cmbTransporter.Name = "cmbTransporter"
        Me.cmbTransporter.Size = New System.Drawing.Size(219, 21)
        Me.cmbTransporter.TabIndex = 8
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(331, 8)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(51, 13)
        Me.lblCustomer.TabIndex = 5
        Me.lblCustomer.Text = "Customer"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(10, 159)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(848, 124)
        Me.dgv.TabIndex = 32
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.Location = New System.Drawing.Point(644, 470)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(104, 13)
        Me.lblNet.TabIndex = 38
        Me.lblNet.Text = "Net Amount Payable"
        '
        'lblGross
        '
        Me.lblGross.AutoSize = True
        Me.lblGross.Location = New System.Drawing.Point(690, 301)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(58, 13)
        Me.lblGross.TabIndex = 35
        Me.lblGross.Text = "Gross Amt."
        '
        'lblVarGross
        '
        Me.lblVarGross.AutoSize = True
        Me.lblVarGross.Location = New System.Drawing.Point(8, 304)
        Me.lblVarGross.Name = "lblVarGross"
        Me.lblVarGross.Size = New System.Drawing.Size(96, 13)
        Me.lblVarGross.TabIndex = 33
        Me.lblVarGross.Text = "Variable Gross Amt"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(13, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(90, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'pnlmain
        '
        Me.pnlmain.Controls.Add(Me.ntxtNetAmt)
        Me.pnlmain.Controls.Add(Me.ntxtVarGross)
        Me.pnlmain.Controls.Add(Me.ntxtChallan)
        Me.pnlmain.Controls.Add(Me.ntxtGrossAmt)
        Me.pnlmain.Controls.Add(Me.txtOwner)
        Me.pnlmain.Controls.Add(Me.lblOwner)
        Me.pnlmain.Controls.Add(Me.txtDriver)
        Me.pnlmain.Controls.Add(Me.lblDriver)
        Me.pnlmain.Controls.Add(Me.txtDiNo)
        Me.pnlmain.Controls.Add(Me.lblDiNo)
        Me.pnlmain.Controls.Add(Me.dtLrDate)
        Me.pnlmain.Controls.Add(Me.cmbTo)
        Me.pnlmain.Controls.Add(Me.dgvCharges)
        Me.pnlmain.Controls.Add(Me.lblTo)
        Me.pnlmain.Controls.Add(Me.lblinv)
        Me.pnlmain.Controls.Add(Me.lblShip)
        Me.pnlmain.Controls.Add(Me.cmbCustomer)
        Me.pnlmain.Controls.Add(Me.txtInv)
        Me.pnlmain.Controls.Add(Me.txtShip)
        Me.pnlmain.Controls.Add(Me.lblGridMessage)
        Me.pnlmain.Controls.Add(Me.lblPrefix)
        Me.pnlmain.Controls.Add(Me.cmbLorry)
        Me.pnlmain.Controls.Add(Me.lblLorry)
        Me.pnlmain.Controls.Add(Me.lblLRDate)
        Me.pnlmain.Controls.Add(Me.dgv)
        Me.pnlmain.Controls.Add(Me.lblCustomer)
        Me.pnlmain.Controls.Add(Me.dtChallanDate)
        Me.pnlmain.Controls.Add(Me.txtNarration)
        Me.pnlmain.Controls.Add(Me.lblNarration)
        Me.pnlmain.Controls.Add(Me.txtLrNo)
        Me.pnlmain.Controls.Add(Me.lblLR)
        Me.pnlmain.Controls.Add(Me.lblDate)
        Me.pnlmain.Controls.Add(Me.cmbTransporter)
        Me.pnlmain.Controls.Add(Me.lblTransporter)
        Me.pnlmain.Controls.Add(Me.lblNet)
        Me.pnlmain.Controls.Add(Me.lblVarGross)
        Me.pnlmain.Controls.Add(Me.lblGross)
        Me.pnlmain.Controls.Add(Me.cmbPayableAt)
        Me.pnlmain.Controls.Add(Me.lblPayableAt)
        Me.pnlmain.Controls.Add(Me.cmbFrom)
        Me.pnlmain.Controls.Add(Me.lblFrom)
        Me.pnlmain.Controls.Add(Me.lblChallanNo)
        Me.pnlmain.Location = New System.Drawing.Point(8, 28)
        Me.pnlmain.Name = "pnlmain"
        Me.pnlmain.Size = New System.Drawing.Size(872, 495)
        Me.pnlmain.TabIndex = 2
        '
        'txtOwner
        '
        Me.txtOwner.Location = New System.Drawing.Point(724, 30)
        Me.txtOwner.Name = "txtOwner"
        Me.txtOwner.Size = New System.Drawing.Size(134, 20)
        Me.txtOwner.TabIndex = 14
        '
        'lblOwner
        '
        Me.lblOwner.AutoSize = True
        Me.lblOwner.Location = New System.Drawing.Point(680, 35)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(38, 13)
        Me.lblOwner.TabIndex = 13
        Me.lblOwner.Text = "Owner"
        '
        'txtDriver
        '
        Me.txtDriver.Location = New System.Drawing.Point(542, 31)
        Me.txtDriver.Name = "txtDriver"
        Me.txtDriver.Size = New System.Drawing.Size(132, 20)
        Me.txtDriver.TabIndex = 12
        '
        'lblDriver
        '
        Me.lblDriver.AutoSize = True
        Me.lblDriver.Location = New System.Drawing.Point(489, 35)
        Me.lblDriver.Name = "lblDriver"
        Me.lblDriver.Size = New System.Drawing.Size(35, 13)
        Me.lblDriver.TabIndex = 11
        Me.lblDriver.Text = "Driver"
        '
        'txtDiNo
        '
        Me.txtDiNo.Location = New System.Drawing.Point(76, 84)
        Me.txtDiNo.Name = "txtDiNo"
        Me.txtDiNo.Size = New System.Drawing.Size(152, 20)
        Me.txtDiNo.TabIndex = 24
        '
        'lblDiNo
        '
        Me.lblDiNo.AutoSize = True
        Me.lblDiNo.Location = New System.Drawing.Point(8, 87)
        Me.lblDiNo.Name = "lblDiNo"
        Me.lblDiNo.Size = New System.Drawing.Size(38, 13)
        Me.lblDiNo.TabIndex = 23
        Me.lblDiNo.Text = "DI No."
        '
        'dtLrDate
        '
        Me.dtLrDate.CustomFormat = "dd/MM/yyyy"
        Me.dtLrDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtLrDate.Location = New System.Drawing.Point(315, 60)
        Me.dtLrDate.Name = "dtLrDate"
        Me.dtLrDate.Size = New System.Drawing.Size(86, 20)
        Me.dtLrDate.TabIndex = 18
        '
        'cmbTo
        '
        Me.cmbTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTo.FormattingEnabled = True
        Me.cmbTo.Location = New System.Drawing.Point(724, 91)
        Me.cmbTo.Name = "cmbTo"
        Me.cmbTo.Size = New System.Drawing.Size(134, 21)
        Me.cmbTo.TabIndex = 30
        '
        'dgvCharges
        '
        Me.dgvCharges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCharges.Location = New System.Drawing.Point(9, 324)
        Me.dgvCharges.Name = "dgvCharges"
        Me.dgvCharges.Size = New System.Drawing.Size(849, 133)
        Me.dgvCharges.TabIndex = 37
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(647, 94)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(20, 13)
        Me.lblTo.TabIndex = 29
        Me.lblTo.Text = "To"
        '
        'lblinv
        '
        Me.lblinv.AutoSize = True
        Me.lblinv.Location = New System.Drawing.Point(423, 63)
        Me.lblinv.Name = "lblinv"
        Me.lblinv.Size = New System.Drawing.Size(45, 13)
        Me.lblinv.TabIndex = 19
        Me.lblinv.Text = "Inv. No."
        '
        'lblShip
        '
        Me.lblShip.AutoSize = True
        Me.lblShip.Location = New System.Drawing.Point(647, 64)
        Me.lblShip.Name = "lblShip"
        Me.lblShip.Size = New System.Drawing.Size(71, 13)
        Me.lblShip.TabIndex = 21
        Me.lblShip.Text = "Shipment No."
        '
        'cmbCustomer
        '
        Me.cmbCustomer.FormattingEnabled = True
        Me.cmbCustomer.Location = New System.Drawing.Point(390, 4)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(269, 21)
        Me.cmbCustomer.TabIndex = 6
        '
        'txtInv
        '
        Me.txtInv.Location = New System.Drawing.Point(474, 59)
        Me.txtInv.Name = "txtInv"
        Me.txtInv.Size = New System.Drawing.Size(144, 20)
        Me.txtInv.TabIndex = 20
        '
        'txtShip
        '
        Me.txtShip.Location = New System.Drawing.Point(724, 61)
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(134, 20)
        Me.txtShip.TabIndex = 22
        '
        'lblGridMessage
        '
        Me.lblGridMessage.AutoSize = True
        Me.lblGridMessage.Location = New System.Drawing.Point(8, 132)
        Me.lblGridMessage.Name = "lblGridMessage"
        Me.lblGridMessage.Size = New System.Drawing.Size(361, 13)
        Me.lblGridMessage.TabIndex = 31
        Me.lblGridMessage.Text = "Press <Insert> key to Add <Enter> key to Edit <Delete> key to Delete Items"
        '
        'lblPrefix
        '
        Me.lblPrefix.AutoSize = True
        Me.lblPrefix.BackColor = System.Drawing.Color.White
        Me.lblPrefix.Location = New System.Drawing.Point(76, 8)
        Me.lblPrefix.Name = "lblPrefix"
        Me.lblPrefix.Size = New System.Drawing.Size(19, 13)
        Me.lblPrefix.TabIndex = 1
        Me.lblPrefix.Text = "----"
        Me.lblPrefix.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLorry
        '
        Me.cmbLorry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbLorry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbLorry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLorry.FormattingEnabled = True
        Me.cmbLorry.Location = New System.Drawing.Point(334, 30)
        Me.cmbLorry.Name = "cmbLorry"
        Me.cmbLorry.Size = New System.Drawing.Size(149, 21)
        Me.cmbLorry.TabIndex = 10
        '
        'lblLorry
        '
        Me.lblLorry.AutoSize = True
        Me.lblLorry.Location = New System.Drawing.Point(301, 35)
        Me.lblLorry.Name = "lblLorry"
        Me.lblLorry.Size = New System.Drawing.Size(30, 13)
        Me.lblLorry.TabIndex = 9
        Me.lblLorry.Text = "Lorry"
        '
        'lblLRDate
        '
        Me.lblLRDate.AutoSize = True
        Me.lblLRDate.Location = New System.Drawing.Point(257, 64)
        Me.lblLRDate.Name = "lblLRDate"
        Me.lblLRDate.Size = New System.Drawing.Size(50, 13)
        Me.lblLRDate.TabIndex = 17
        Me.lblLRDate.Text = "L R Date"
        '
        'txtNarration
        '
        Me.txtNarration.Location = New System.Drawing.Point(64, 464)
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.Size = New System.Drawing.Size(574, 20)
        Me.txtNarration.TabIndex = 16
        '
        'lblNarration
        '
        Me.lblNarration.AutoSize = True
        Me.lblNarration.Location = New System.Drawing.Point(8, 467)
        Me.lblNarration.Name = "lblNarration"
        Me.lblNarration.Size = New System.Drawing.Size(50, 13)
        Me.lblNarration.TabIndex = 15
        Me.lblNarration.Text = "Narration"
        '
        'txtLrNo
        '
        Me.txtLrNo.Location = New System.Drawing.Point(76, 58)
        Me.txtLrNo.Name = "txtLrNo"
        Me.txtLrNo.Size = New System.Drawing.Size(152, 20)
        Me.txtLrNo.TabIndex = 16
        '
        'lblLR
        '
        Me.lblLR.AutoSize = True
        Me.lblLR.Location = New System.Drawing.Point(8, 62)
        Me.lblLR.Name = "lblLR"
        Me.lblLR.Size = New System.Drawing.Size(41, 13)
        Me.lblLR.TabIndex = 15
        Me.lblLR.Text = "L RNo."
        '
        'cmbPayableAt
        '
        Me.cmbPayableAt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPayableAt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPayableAt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayableAt.FormattingEnabled = True
        Me.cmbPayableAt.Location = New System.Drawing.Point(334, 88)
        Me.cmbPayableAt.Name = "cmbPayableAt"
        Me.cmbPayableAt.Size = New System.Drawing.Size(118, 21)
        Me.cmbPayableAt.TabIndex = 26
        '
        'lblPayableAt
        '
        Me.lblPayableAt.AutoSize = True
        Me.lblPayableAt.Location = New System.Drawing.Point(257, 91)
        Me.lblPayableAt.Name = "lblPayableAt"
        Me.lblPayableAt.Size = New System.Drawing.Size(58, 13)
        Me.lblPayableAt.TabIndex = 25
        Me.lblPayableAt.Text = "Payable At"
        '
        'cmbFrom
        '
        Me.cmbFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFrom.FormattingEnabled = True
        Me.cmbFrom.Location = New System.Drawing.Point(500, 88)
        Me.cmbFrom.Name = "cmbFrom"
        Me.cmbFrom.Size = New System.Drawing.Size(118, 21)
        Me.cmbFrom.TabIndex = 28
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(458, 91)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblFrom.TabIndex = 27
        Me.lblFrom.Text = "From"
        '
        'pnlsave
        '
        Me.pnlsave.Controls.Add(Me.btnCancel)
        Me.pnlsave.Controls.Add(Me.btnSave)
        Me.pnlsave.Location = New System.Drawing.Point(701, 527)
        Me.pnlsave.Name = "pnlsave"
        Me.pnlsave.Size = New System.Drawing.Size(179, 27)
        Me.pnlsave.TabIndex = 3
        '
        'tbNav
        '
        Me.tbNav.AutoSize = False
        Me.tbNav.Dock = System.Windows.Forms.DockStyle.None
        Me.tbNav.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbFirst, Me.tsbPrevious, Me.tsbNext, Me.tsbLast, Me.tsbSearch, Me.tsbRefresh, Me.tscBook, Me.tslGoto, Me.tstChallan, Me.tsbGo})
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
        'tscBook
        '
        Me.tscBook.Name = "tscBook"
        Me.tscBook.Size = New System.Drawing.Size(121, 25)
        '
        'tslGoto
        '
        Me.tslGoto.Name = "tslGoto"
        Me.tslGoto.Size = New System.Drawing.Size(62, 22)
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
        Me.tsbGo.Size = New System.Drawing.Size(24, 22)
        Me.tsbGo.Text = "&Go"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ntxtNetAmt
        '
        Me.ntxtNetAmt.dec = CType(2, Short)
        Me.ntxtNetAmt.Location = New System.Drawing.Point(754, 464)
        Me.ntxtNetAmt.Name = "ntxtNetAmt"
        Me.ntxtNetAmt.ReadOnly = True
        Me.ntxtNetAmt.Size = New System.Drawing.Size(100, 20)
        Me.ntxtNetAmt.TabIndex = 41
        Me.ntxtNetAmt.TabStop = False
        Me.ntxtNetAmt.Text = "0.00"
        Me.ntxtNetAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtNetAmt.value = 0
        '
        'ntxtVarGross
        '
        Me.ntxtVarGross.dec = CType(2, Short)
        Me.ntxtVarGross.Location = New System.Drawing.Point(111, 296)
        Me.ntxtVarGross.Name = "ntxtVarGross"
        Me.ntxtVarGross.ReadOnly = True
        Me.ntxtVarGross.Size = New System.Drawing.Size(100, 20)
        Me.ntxtVarGross.TabIndex = 40
        Me.ntxtVarGross.TabStop = False
        Me.ntxtVarGross.Text = "0.00"
        Me.ntxtVarGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtVarGross.value = 0
        '
        'ntxtChallan
        '
        Me.ntxtChallan.dec = CType(0, Short)
        Me.ntxtChallan.Location = New System.Drawing.Point(101, 4)
        Me.ntxtChallan.Name = "ntxtChallan"
        Me.ntxtChallan.Size = New System.Drawing.Size(100, 20)
        Me.ntxtChallan.TabIndex = 2
        Me.ntxtChallan.Text = "0"
        Me.ntxtChallan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtChallan.value = 0
        '
        'ntxtGrossAmt
        '
        Me.ntxtGrossAmt.dec = CType(2, Short)
        Me.ntxtGrossAmt.Location = New System.Drawing.Point(754, 298)
        Me.ntxtGrossAmt.Name = "ntxtGrossAmt"
        Me.ntxtGrossAmt.ReadOnly = True
        Me.ntxtGrossAmt.Size = New System.Drawing.Size(100, 20)
        Me.ntxtGrossAmt.TabIndex = 36
        Me.ntxtGrossAmt.TabStop = False
        Me.ntxtGrossAmt.Text = "0.00"
        Me.ntxtGrossAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtGrossAmt.value = 0
        '
        'frmChallan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 566)
        Me.Controls.Add(Me.tbNav)
        Me.Controls.Add(Me.pnlsave)
        Me.Controls.Add(Me.pnlmain)
        Me.Controls.Add(Me.tbEdit)
        Me.KeyPreview = True
        Me.Name = "frmChallan"
        Me.Text = "Challan"
        Me.tbEdit.ResumeLayout(False)
        Me.tbEdit.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlmain.ResumeLayout(False)
        Me.pnlmain.PerformLayout()
        CType(Me.dgvCharges, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlsave.ResumeLayout(False)
        Me.tbNav.ResumeLayout(False)
        Me.tbNav.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbEdit As System.Windows.Forms.ToolStrip
    Friend WithEvents lblChallanNo As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents dtChallanDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTransporter As System.Windows.Forms.Label
    Friend WithEvents cmbTransporter As System.Windows.Forms.ComboBox
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents lblNet As System.Windows.Forms.Label
    Friend WithEvents lblGross As System.Windows.Forms.Label
    Friend WithEvents lblVarGross As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents pnlmain As System.Windows.Forms.Panel
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
    Friend WithEvents tscBook As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents txtLrNo As System.Windows.Forms.TextBox
    Friend WithEvents lblLR As System.Windows.Forms.Label
    Friend WithEvents cmbLorry As System.Windows.Forms.ComboBox
    Friend WithEvents lblLorry As System.Windows.Forms.Label
    Friend WithEvents cmbFrom As System.Windows.Forms.ComboBox
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents dtLrDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDiNo As System.Windows.Forms.TextBox
    Friend WithEvents lblDiNo As System.Windows.Forms.Label
    Friend WithEvents lblShip As System.Windows.Forms.Label
    Friend WithEvents lblLRDate As System.Windows.Forms.Label
    Friend WithEvents txtShip As System.Windows.Forms.TextBox
    Friend WithEvents lblPrefix As System.Windows.Forms.Label
    Friend WithEvents lblGridMessage As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents dgvCharges As System.Windows.Forms.DataGridView
    Friend WithEvents cmbTo As System.Windows.Forms.ComboBox
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents cmbPayableAt As System.Windows.Forms.ComboBox
    Friend WithEvents lblPayableAt As System.Windows.Forms.Label
    Friend WithEvents lblinv As System.Windows.Forms.Label
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
End Class

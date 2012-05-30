<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransChallan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransChallan))
        Me.tbEdit = New System.Windows.Forms.ToolStrip
        Me.tsbNew = New System.Windows.Forms.ToolStripButton
        Me.tsbEdit = New System.Windows.Forms.ToolStripButton
        Me.tsbDelete = New System.Windows.Forms.ToolStripButton
        Me.lblChallanNo = New System.Windows.Forms.Label
        Me.txtChallan = New System.Windows.Forms.TextBox
        Me.lblDate = New System.Windows.Forms.Label
        Me.dtChallanDate = New System.Windows.Forms.DateTimePicker
        Me.rbBPP = New System.Windows.Forms.RadioButton
        Me.rbTP = New System.Windows.Forms.RadioButton
        Me.lblTransporter = New System.Windows.Forms.Label
        Me.cmbTransporter = New System.Windows.Forms.ComboBox
        Me.lblCustomer = New System.Windows.Forms.Label
        Me.lblCustName = New System.Windows.Forms.Label
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.lblFreight = New System.Windows.Forms.Label
        Me.txtFreight = New System.Windows.Forms.TextBox
        Me.lblLabour = New System.Windows.Forms.Label
        Me.txtLabour = New System.Windows.Forms.TextBox
        Me.lblCommission = New System.Windows.Forms.Label
        Me.txtCommission = New System.Windows.Forms.TextBox
        Me.lblTdsPer = New System.Windows.Forms.Label
        Me.txtTdsAmt = New System.Windows.Forms.TextBox
        Me.lblPayable = New System.Windows.Forms.Label
        Me.txtPayable = New System.Windows.Forms.TextBox
        Me.lblTDS = New System.Windows.Forms.Label
        Me.txtTDSRate = New System.Windows.Forms.TextBox
        Me.lblShortage = New System.Windows.Forms.Label
        Me.txtShortage = New System.Windows.Forms.TextBox
        Me.lblAdvance = New System.Windows.Forms.Label
        Me.txtAdv = New System.Windows.Forms.TextBox
        Me.lblNet = New System.Windows.Forms.Label
        Me.txtNetAmt = New System.Windows.Forms.TextBox
        Me.lblGross = New System.Windows.Forms.Label
        Me.txtGrossamt = New System.Windows.Forms.TextBox
        Me.lblTdsAmt = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtTdsOn = New System.Windows.Forms.TextBox
        Me.lblNarration = New System.Windows.Forms.Label
        Me.txtNarration = New System.Windows.Forms.TextBox
        Me.pnlmain = New System.Windows.Forms.Panel
        Me.lblGridMessage = New System.Windows.Forms.Label
        Me.lblPrefix = New System.Windows.Forms.Label
        Me.pnlItems = New System.Windows.Forms.GroupBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnICancel = New System.Windows.Forms.Button
        Me.btnISave = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.txtEgp = New System.Windows.Forms.TextBox
        Me.txtGrade = New System.Windows.Forms.TextBox
        Me.txtAmt = New System.Windows.Forms.TextBox
        Me.txtShort = New System.Windows.Forms.TextBox
        Me.txtILabour = New System.Windows.Forms.TextBox
        Me.txtRateDiff = New System.Windows.Forms.TextBox
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.lblShort = New System.Windows.Forms.Label
        Me.txtWeight = New System.Windows.Forms.TextBox
        Me.lblILabour = New System.Windows.Forms.Label
        Me.lblAmount = New System.Windows.Forms.Label
        Me.lblRateDiff = New System.Windows.Forms.Label
        Me.txtBags = New System.Windows.Forms.TextBox
        Me.lblRate = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.lblWeight = New System.Windows.Forms.Label
        Me.lblGrade = New System.Windows.Forms.Label
        Me.lblBags = New System.Windows.Forms.Label
        Me.lblegp = New System.Windows.Forms.Label
        Me.lblDiNo = New System.Windows.Forms.Label
        Me.lblShip = New System.Windows.Forms.Label
        Me.lblGRDate = New System.Windows.Forms.Label
        Me.txtShip = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtGrNo = New System.Windows.Forms.TextBox
        Me.lblGr = New System.Windows.Forms.Label
        Me.cmbLorry = New System.Windows.Forms.ComboBox
        Me.lblLorry = New System.Windows.Forms.Label
        Me.cmbPlace = New System.Windows.Forms.ComboBox
        Me.lblPlace = New System.Windows.Forms.Label
        Me.pnlsave = New System.Windows.Forms.Panel
        Me.tbNav = New System.Windows.Forms.ToolStrip
        Me.tsbFirst = New System.Windows.Forms.ToolStripButton
        Me.tsbPrevious = New System.Windows.Forms.ToolStripButton
        Me.tsbNext = New System.Windows.Forms.ToolStripButton
        Me.tsbLast = New System.Windows.Forms.ToolStripButton
        Me.tsbSearch = New System.Windows.Forms.ToolStripButton
        Me.tsbRefresh = New System.Windows.Forms.ToolStripButton
        Me.tscBook = New System.Windows.Forms.ToolStripComboBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tbEdit.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlmain.SuspendLayout()
        Me.pnlItems.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlsave.SuspendLayout()
        Me.tbNav.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbEdit
        '
        Me.tbEdit.AutoSize = False
        Me.tbEdit.Dock = System.Windows.Forms.DockStyle.None
        Me.tbEdit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNew, Me.tsbEdit, Me.tsbDelete})
        Me.tbEdit.Location = New System.Drawing.Point(9, 0)
        Me.tbEdit.Name = "tbEdit"
        Me.tbEdit.Size = New System.Drawing.Size(111, 25)
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
        'lblChallanNo
        '
        Me.lblChallanNo.AutoSize = True
        Me.lblChallanNo.Location = New System.Drawing.Point(2, 9)
        Me.lblChallanNo.Name = "lblChallanNo"
        Me.lblChallanNo.Size = New System.Drawing.Size(62, 13)
        Me.lblChallanNo.TabIndex = 0
        Me.lblChallanNo.Text = "Challan No."
        '
        'txtChallan
        '
        Me.txtChallan.Location = New System.Drawing.Point(130, 5)
        Me.txtChallan.Name = "txtChallan"
        Me.txtChallan.Size = New System.Drawing.Size(61, 20)
        Me.txtChallan.TabIndex = 1
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(236, 9)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date"
        '
        'dtChallanDate
        '
        Me.dtChallanDate.CustomFormat = "dd/MM/yyyy"
        Me.dtChallanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtChallanDate.Location = New System.Drawing.Point(272, 5)
        Me.dtChallanDate.Name = "dtChallanDate"
        Me.dtChallanDate.Size = New System.Drawing.Size(86, 20)
        Me.dtChallanDate.TabIndex = 3
        '
        'rbBPP
        '
        Me.rbBPP.AutoSize = True
        Me.rbBPP.Checked = True
        Me.rbBPP.Location = New System.Drawing.Point(403, 9)
        Me.rbBPP.Name = "rbBPP"
        Me.rbBPP.Size = New System.Drawing.Size(55, 17)
        Me.rbBPP.TabIndex = 4
        Me.rbBPP.TabStop = True
        Me.rbBPP.Text = "B.P.P."
        Me.rbBPP.UseVisualStyleBackColor = True
        '
        'rbTP
        '
        Me.rbTP.AutoSize = True
        Me.rbTP.Location = New System.Drawing.Point(464, 9)
        Me.rbTP.Name = "rbTP"
        Me.rbTP.Size = New System.Drawing.Size(59, 17)
        Me.rbTP.TabIndex = 5
        Me.rbTP.Text = "To Pay"
        Me.rbTP.UseVisualStyleBackColor = True
        '
        'lblTransporter
        '
        Me.lblTransporter.AutoSize = True
        Me.lblTransporter.Location = New System.Drawing.Point(3, 35)
        Me.lblTransporter.Name = "lblTransporter"
        Me.lblTransporter.Size = New System.Drawing.Size(61, 13)
        Me.lblTransporter.TabIndex = 6
        Me.lblTransporter.Text = "Transporter"
        '
        'cmbTransporter
        '
        Me.cmbTransporter.FormattingEnabled = True
        Me.cmbTransporter.Location = New System.Drawing.Point(70, 31)
        Me.cmbTransporter.Name = "cmbTransporter"
        Me.cmbTransporter.Size = New System.Drawing.Size(237, 21)
        Me.cmbTransporter.TabIndex = 7
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(323, 35)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(51, 13)
        Me.lblCustomer.TabIndex = 8
        Me.lblCustomer.Text = "Customer"
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustName.Location = New System.Drawing.Point(380, 35)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(59, 13)
        Me.lblCustName.TabIndex = 9
        Me.lblCustName.Text = "Customer"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(7, 80)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(650, 162)
        Me.dgv.TabIndex = 11
        '
        'lblFreight
        '
        Me.lblFreight.AutoSize = True
        Me.lblFreight.Location = New System.Drawing.Point(2, 251)
        Me.lblFreight.Name = "lblFreight"
        Me.lblFreight.Size = New System.Drawing.Size(39, 13)
        Me.lblFreight.TabIndex = 12
        Me.lblFreight.Text = "Freight"
        '
        'txtFreight
        '
        Me.txtFreight.Location = New System.Drawing.Point(45, 247)
        Me.txtFreight.Name = "txtFreight"
        Me.txtFreight.ReadOnly = True
        Me.txtFreight.Size = New System.Drawing.Size(100, 20)
        Me.txtFreight.TabIndex = 13
        Me.txtFreight.TabStop = False
        Me.txtFreight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblLabour
        '
        Me.lblLabour.AutoSize = True
        Me.lblLabour.Location = New System.Drawing.Point(151, 251)
        Me.lblLabour.Name = "lblLabour"
        Me.lblLabour.Size = New System.Drawing.Size(40, 13)
        Me.lblLabour.TabIndex = 14
        Me.lblLabour.Text = "Labour"
        '
        'txtLabour
        '
        Me.txtLabour.Location = New System.Drawing.Point(197, 245)
        Me.txtLabour.Name = "txtLabour"
        Me.txtLabour.Size = New System.Drawing.Size(100, 20)
        Me.txtLabour.TabIndex = 15
        Me.txtLabour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCommission
        '
        Me.lblCommission.AutoSize = True
        Me.lblCommission.Location = New System.Drawing.Point(303, 250)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(62, 13)
        Me.lblCommission.TabIndex = 16
        Me.lblCommission.Text = "Commission"
        '
        'txtCommission
        '
        Me.txtCommission.Location = New System.Drawing.Point(371, 247)
        Me.txtCommission.Name = "txtCommission"
        Me.txtCommission.Size = New System.Drawing.Size(100, 20)
        Me.txtCommission.TabIndex = 17
        Me.txtCommission.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTdsPer
        '
        Me.lblTdsPer.AutoSize = True
        Me.lblTdsPer.Location = New System.Drawing.Point(248, 276)
        Me.lblTdsPer.Name = "lblTdsPer"
        Me.lblTdsPer.Size = New System.Drawing.Size(30, 13)
        Me.lblTdsPer.TabIndex = 22
        Me.lblTdsPer.Text = "% on"
        '
        'txtTdsAmt
        '
        Me.txtTdsAmt.Location = New System.Drawing.Point(557, 272)
        Me.txtTdsAmt.Name = "txtTdsAmt"
        Me.txtTdsAmt.ReadOnly = True
        Me.txtTdsAmt.Size = New System.Drawing.Size(100, 20)
        Me.txtTdsAmt.TabIndex = 25
        Me.txtTdsAmt.TabStop = False
        Me.txtTdsAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPayable
        '
        Me.lblPayable.AutoSize = True
        Me.lblPayable.Location = New System.Drawing.Point(502, 298)
        Me.lblPayable.Name = "lblPayable"
        Me.lblPayable.Size = New System.Drawing.Size(45, 13)
        Me.lblPayable.TabIndex = 26
        Me.lblPayable.Text = "Payable"
        '
        'txtPayable
        '
        Me.txtPayable.Location = New System.Drawing.Point(557, 295)
        Me.txtPayable.Name = "txtPayable"
        Me.txtPayable.ReadOnly = True
        Me.txtPayable.Size = New System.Drawing.Size(100, 20)
        Me.txtPayable.TabIndex = 27
        Me.txtPayable.TabStop = False
        Me.txtPayable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTDS
        '
        Me.lblTDS.AutoSize = True
        Me.lblTDS.Location = New System.Drawing.Point(148, 279)
        Me.lblTDS.Name = "lblTDS"
        Me.lblTDS.Size = New System.Drawing.Size(43, 13)
        Me.lblTDS.TabIndex = 20
        Me.lblTDS.Text = "TDS @"
        '
        'txtTDSRate
        '
        Me.txtTDSRate.Location = New System.Drawing.Point(197, 272)
        Me.txtTDSRate.Name = "txtTDSRate"
        Me.txtTDSRate.Size = New System.Drawing.Size(45, 20)
        Me.txtTDSRate.TabIndex = 21
        Me.txtTDSRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblShortage
        '
        Me.lblShortage.AutoSize = True
        Me.lblShortage.Location = New System.Drawing.Point(473, 324)
        Me.lblShortage.Name = "lblShortage"
        Me.lblShortage.Size = New System.Drawing.Size(78, 13)
        Me.lblShortage.TabIndex = 28
        Me.lblShortage.Text = "Less: Shortage"
        '
        'txtShortage
        '
        Me.txtShortage.Location = New System.Drawing.Point(557, 321)
        Me.txtShortage.Name = "txtShortage"
        Me.txtShortage.Size = New System.Drawing.Size(100, 20)
        Me.txtShortage.TabIndex = 29
        Me.txtShortage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAdvance
        '
        Me.lblAdvance.AutoSize = True
        Me.lblAdvance.Location = New System.Drawing.Point(446, 350)
        Me.lblAdvance.Name = "lblAdvance"
        Me.lblAdvance.Size = New System.Drawing.Size(105, 13)
        Me.lblAdvance.TabIndex = 30
        Me.lblAdvance.Text = "Less: Cash Advance"
        '
        'txtAdv
        '
        Me.txtAdv.Location = New System.Drawing.Point(557, 347)
        Me.txtAdv.Name = "txtAdv"
        Me.txtAdv.Size = New System.Drawing.Size(100, 20)
        Me.txtAdv.TabIndex = 31
        Me.txtAdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.Location = New System.Drawing.Point(443, 380)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(104, 13)
        Me.lblNet.TabIndex = 32
        Me.lblNet.Text = "Net Amount Payable"
        '
        'txtNetAmt
        '
        Me.txtNetAmt.Location = New System.Drawing.Point(557, 373)
        Me.txtNetAmt.Name = "txtNetAmt"
        Me.txtNetAmt.ReadOnly = True
        Me.txtNetAmt.Size = New System.Drawing.Size(100, 20)
        Me.txtNetAmt.TabIndex = 33
        Me.txtNetAmt.TabStop = False
        Me.txtNetAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblGross
        '
        Me.lblGross.AutoSize = True
        Me.lblGross.Location = New System.Drawing.Point(489, 250)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(58, 13)
        Me.lblGross.TabIndex = 18
        Me.lblGross.Text = "Gross Amt."
        '
        'txtGrossamt
        '
        Me.txtGrossamt.Location = New System.Drawing.Point(557, 248)
        Me.txtGrossamt.Name = "txtGrossamt"
        Me.txtGrossamt.ReadOnly = True
        Me.txtGrossamt.Size = New System.Drawing.Size(100, 20)
        Me.txtGrossamt.TabIndex = 19
        Me.txtGrossamt.TabStop = False
        Me.txtGrossamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTdsAmt
        '
        Me.lblTdsAmt.AutoSize = True
        Me.lblTdsAmt.Location = New System.Drawing.Point(470, 275)
        Me.lblTdsAmt.Name = "lblTdsAmt"
        Me.lblTdsAmt.Size = New System.Drawing.Size(81, 13)
        Me.lblTdsAmt.TabIndex = 24
        Me.lblTdsAmt.Text = "Less: TDS Amt."
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(13, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(90, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtTdsOn
        '
        Me.txtTdsOn.Location = New System.Drawing.Point(284, 273)
        Me.txtTdsOn.Name = "txtTdsOn"
        Me.txtTdsOn.ReadOnly = True
        Me.txtTdsOn.Size = New System.Drawing.Size(100, 20)
        Me.txtTdsOn.TabIndex = 23
        Me.txtTdsOn.TabStop = False
        Me.txtTdsOn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblNarration
        '
        Me.lblNarration.AutoSize = True
        Me.lblNarration.Location = New System.Drawing.Point(2, 302)
        Me.lblNarration.Name = "lblNarration"
        Me.lblNarration.Size = New System.Drawing.Size(50, 13)
        Me.lblNarration.TabIndex = 34
        Me.lblNarration.Text = "Narration"
        '
        'txtNarration
        '
        Me.txtNarration.Location = New System.Drawing.Point(58, 302)
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.Size = New System.Drawing.Size(358, 91)
        Me.txtNarration.TabIndex = 35
        '
        'pnlmain
        '
        Me.pnlmain.Controls.Add(Me.lblGridMessage)
        Me.pnlmain.Controls.Add(Me.lblPrefix)
        Me.pnlmain.Controls.Add(Me.dgv)
        Me.pnlmain.Controls.Add(Me.lblCustName)
        Me.pnlmain.Controls.Add(Me.lblCustomer)
        Me.pnlmain.Controls.Add(Me.rbTP)
        Me.pnlmain.Controls.Add(Me.rbBPP)
        Me.pnlmain.Controls.Add(Me.dtChallanDate)
        Me.pnlmain.Controls.Add(Me.lblDate)
        Me.pnlmain.Controls.Add(Me.cmbTransporter)
        Me.pnlmain.Controls.Add(Me.lblTransporter)
        Me.pnlmain.Controls.Add(Me.txtNetAmt)
        Me.pnlmain.Controls.Add(Me.lblNet)
        Me.pnlmain.Controls.Add(Me.txtAdv)
        Me.pnlmain.Controls.Add(Me.lblAdvance)
        Me.pnlmain.Controls.Add(Me.txtShortage)
        Me.pnlmain.Controls.Add(Me.lblShortage)
        Me.pnlmain.Controls.Add(Me.txtPayable)
        Me.pnlmain.Controls.Add(Me.lblTdsAmt)
        Me.pnlmain.Controls.Add(Me.lblPayable)
        Me.pnlmain.Controls.Add(Me.txtTDSRate)
        Me.pnlmain.Controls.Add(Me.lblTDS)
        Me.pnlmain.Controls.Add(Me.txtTdsAmt)
        Me.pnlmain.Controls.Add(Me.lblTdsPer)
        Me.pnlmain.Controls.Add(Me.txtGrossamt)
        Me.pnlmain.Controls.Add(Me.lblGross)
        Me.pnlmain.Controls.Add(Me.txtCommission)
        Me.pnlmain.Controls.Add(Me.lblCommission)
        Me.pnlmain.Controls.Add(Me.txtLabour)
        Me.pnlmain.Controls.Add(Me.lblLabour)
        Me.pnlmain.Controls.Add(Me.txtTdsOn)
        Me.pnlmain.Controls.Add(Me.txtFreight)
        Me.pnlmain.Controls.Add(Me.lblFreight)
        Me.pnlmain.Controls.Add(Me.txtNarration)
        Me.pnlmain.Controls.Add(Me.lblNarration)
        Me.pnlmain.Controls.Add(Me.txtChallan)
        Me.pnlmain.Controls.Add(Me.lblChallanNo)
        Me.pnlmain.Location = New System.Drawing.Point(8, 28)
        Me.pnlmain.Name = "pnlmain"
        Me.pnlmain.Size = New System.Drawing.Size(669, 403)
        Me.pnlmain.TabIndex = 2
        '
        'lblGridMessage
        '
        Me.lblGridMessage.AutoSize = True
        Me.lblGridMessage.Location = New System.Drawing.Point(5, 61)
        Me.lblGridMessage.Name = "lblGridMessage"
        Me.lblGridMessage.Size = New System.Drawing.Size(361, 13)
        Me.lblGridMessage.TabIndex = 37
        Me.lblGridMessage.Text = "Press <Insert> key to Add <Enter> key to Edit <Delete> key to Delete Items"
        '
        'lblPrefix
        '
        Me.lblPrefix.AutoSize = True
        Me.lblPrefix.BackColor = System.Drawing.Color.White
        Me.lblPrefix.Location = New System.Drawing.Point(70, 9)
        Me.lblPrefix.Name = "lblPrefix"
        Me.lblPrefix.Size = New System.Drawing.Size(0, 13)
        Me.lblPrefix.TabIndex = 36
        Me.lblPrefix.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlItems
        '
        Me.pnlItems.Controls.Add(Me.Panel3)
        Me.pnlItems.Controls.Add(Me.DateTimePicker1)
        Me.pnlItems.Controls.Add(Me.txtEgp)
        Me.pnlItems.Controls.Add(Me.txtGrade)
        Me.pnlItems.Controls.Add(Me.txtAmt)
        Me.pnlItems.Controls.Add(Me.txtShort)
        Me.pnlItems.Controls.Add(Me.txtILabour)
        Me.pnlItems.Controls.Add(Me.txtRateDiff)
        Me.pnlItems.Controls.Add(Me.txtRate)
        Me.pnlItems.Controls.Add(Me.lblShort)
        Me.pnlItems.Controls.Add(Me.txtWeight)
        Me.pnlItems.Controls.Add(Me.lblILabour)
        Me.pnlItems.Controls.Add(Me.lblAmount)
        Me.pnlItems.Controls.Add(Me.lblRateDiff)
        Me.pnlItems.Controls.Add(Me.txtBags)
        Me.pnlItems.Controls.Add(Me.lblRate)
        Me.pnlItems.Controls.Add(Me.TextBox1)
        Me.pnlItems.Controls.Add(Me.lblWeight)
        Me.pnlItems.Controls.Add(Me.lblGrade)
        Me.pnlItems.Controls.Add(Me.lblBags)
        Me.pnlItems.Controls.Add(Me.lblegp)
        Me.pnlItems.Controls.Add(Me.lblDiNo)
        Me.pnlItems.Controls.Add(Me.lblShip)
        Me.pnlItems.Controls.Add(Me.lblGRDate)
        Me.pnlItems.Controls.Add(Me.txtShip)
        Me.pnlItems.Controls.Add(Me.Label1)
        Me.pnlItems.Controls.Add(Me.Label2)
        Me.pnlItems.Controls.Add(Me.txtGrNo)
        Me.pnlItems.Controls.Add(Me.lblGr)
        Me.pnlItems.Controls.Add(Me.cmbLorry)
        Me.pnlItems.Controls.Add(Me.lblLorry)
        Me.pnlItems.Controls.Add(Me.cmbPlace)
        Me.pnlItems.Controls.Add(Me.lblPlace)
        Me.pnlItems.Location = New System.Drawing.Point(15, 462)
        Me.pnlItems.Name = "pnlItems"
        Me.pnlItems.Size = New System.Drawing.Size(656, 213)
        Me.pnlItems.TabIndex = 36
        Me.pnlItems.TabStop = False
        Me.pnlItems.Text = "Item Details"
        Me.pnlItems.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnICancel)
        Me.Panel3.Controls.Add(Me.btnISave)
        Me.Panel3.Location = New System.Drawing.Point(323, 171)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(169, 38)
        Me.Panel3.TabIndex = 30
        '
        'btnICancel
        '
        Me.btnICancel.Image = Global.Account.My.Resources.Resources.delete
        Me.btnICancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnICancel.Location = New System.Drawing.Point(88, 9)
        Me.btnICancel.Name = "btnICancel"
        Me.btnICancel.Size = New System.Drawing.Size(75, 23)
        Me.btnICancel.TabIndex = 11
        Me.btnICancel.Text = "&Cancel"
        Me.btnICancel.UseVisualStyleBackColor = True
        '
        'btnISave
        '
        Me.btnISave.Image = CType(resources.GetObject("btnISave.Image"), System.Drawing.Image)
        Me.btnISave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnISave.Location = New System.Drawing.Point(7, 9)
        Me.btnISave.Name = "btnISave"
        Me.btnISave.Size = New System.Drawing.Size(75, 23)
        Me.btnISave.TabIndex = 10
        Me.btnISave.Text = "&Ok"
        Me.btnISave.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(323, 46)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(86, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'txtEgp
        '
        Me.txtEgp.Location = New System.Drawing.Point(323, 73)
        Me.txtEgp.Name = "txtEgp"
        Me.txtEgp.Size = New System.Drawing.Size(174, 20)
        Me.txtEgp.TabIndex = 11
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(323, 96)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(174, 20)
        Me.txtGrade.TabIndex = 15
        '
        'txtAmt
        '
        Me.txtAmt.Location = New System.Drawing.Point(379, 122)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.Size = New System.Drawing.Size(118, 20)
        Me.txtAmt.TabIndex = 23
        Me.txtAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtShort
        '
        Me.txtShort.Location = New System.Drawing.Point(379, 147)
        Me.txtShort.Name = "txtShort"
        Me.txtShort.Size = New System.Drawing.Size(90, 20)
        Me.txtShort.TabIndex = 29
        Me.txtShort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtILabour
        '
        Me.txtILabour.Location = New System.Drawing.Point(214, 148)
        Me.txtILabour.Name = "txtILabour"
        Me.txtILabour.Size = New System.Drawing.Size(90, 20)
        Me.txtILabour.TabIndex = 27
        Me.txtILabour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRateDiff
        '
        Me.txtRateDiff.Location = New System.Drawing.Point(81, 148)
        Me.txtRateDiff.Name = "txtRateDiff"
        Me.txtRateDiff.Size = New System.Drawing.Size(68, 20)
        Me.txtRateDiff.TabIndex = 25
        Me.txtRateDiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(266, 122)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(68, 20)
        Me.txtRate.TabIndex = 21
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblShort
        '
        Me.lblShort.AutoSize = True
        Me.lblShort.Location = New System.Drawing.Point(327, 152)
        Me.lblShort.Name = "lblShort"
        Me.lblShort.Size = New System.Drawing.Size(50, 13)
        Me.lblShort.TabIndex = 28
        Me.lblShort.Text = "Shortage"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(170, 122)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(66, 20)
        Me.txtWeight.TabIndex = 19
        Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblILabour
        '
        Me.lblILabour.AutoSize = True
        Me.lblILabour.Location = New System.Drawing.Point(167, 151)
        Me.lblILabour.Name = "lblILabour"
        Me.lblILabour.Size = New System.Drawing.Size(40, 13)
        Me.lblILabour.TabIndex = 26
        Me.lblILabour.Text = "Labour"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(344, 126)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(25, 13)
        Me.lblAmount.TabIndex = 22
        Me.lblAmount.Text = "Amt"
        '
        'lblRateDiff
        '
        Me.lblRateDiff.AutoSize = True
        Me.lblRateDiff.Location = New System.Drawing.Point(8, 150)
        Me.lblRateDiff.Name = "lblRateDiff"
        Me.lblRateDiff.Size = New System.Drawing.Size(52, 13)
        Me.lblRateDiff.TabIndex = 24
        Me.lblRateDiff.Text = "Rate Diff."
        '
        'txtBags
        '
        Me.txtBags.Location = New System.Drawing.Point(81, 122)
        Me.txtBags.Name = "txtBags"
        Me.txtBags.Size = New System.Drawing.Size(52, 20)
        Me.txtBags.TabIndex = 17
        Me.txtBags.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(242, 126)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(18, 13)
        Me.lblRate.TabIndex = 20
        Me.lblRate.Text = "@"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(81, 99)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(178, 20)
        Me.TextBox1.TabIndex = 13
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(140, 125)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(24, 13)
        Me.lblWeight.TabIndex = 18
        Me.lblWeight.Text = "Wt."
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Location = New System.Drawing.Point(265, 99)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(36, 13)
        Me.lblGrade.TabIndex = 14
        Me.lblGrade.Text = "Grade"
        '
        'lblBags
        '
        Me.lblBags.AutoSize = True
        Me.lblBags.Location = New System.Drawing.Point(8, 126)
        Me.lblBags.Name = "lblBags"
        Me.lblBags.Size = New System.Drawing.Size(31, 13)
        Me.lblBags.TabIndex = 16
        Me.lblBags.Text = "Bags"
        '
        'lblegp
        '
        Me.lblegp.AutoSize = True
        Me.lblegp.Location = New System.Drawing.Point(265, 76)
        Me.lblegp.Name = "lblegp"
        Me.lblegp.Size = New System.Drawing.Size(52, 13)
        Me.lblegp.TabIndex = 10
        Me.lblegp.Text = "EGP  No."
        '
        'lblDiNo
        '
        Me.lblDiNo.AutoSize = True
        Me.lblDiNo.Location = New System.Drawing.Point(8, 99)
        Me.lblDiNo.Name = "lblDiNo"
        Me.lblDiNo.Size = New System.Drawing.Size(38, 13)
        Me.lblDiNo.TabIndex = 12
        Me.lblDiNo.Text = "DI No."
        '
        'lblShip
        '
        Me.lblShip.AutoSize = True
        Me.lblShip.Location = New System.Drawing.Point(6, 76)
        Me.lblShip.Name = "lblShip"
        Me.lblShip.Size = New System.Drawing.Size(71, 13)
        Me.lblShip.TabIndex = 8
        Me.lblShip.Text = "Shipment No."
        '
        'lblGRDate
        '
        Me.lblGRDate.AutoSize = True
        Me.lblGRDate.Location = New System.Drawing.Point(265, 51)
        Me.lblGRDate.Name = "lblGRDate"
        Me.lblGRDate.Size = New System.Drawing.Size(52, 13)
        Me.lblGRDate.TabIndex = 6
        Me.lblGRDate.Text = "G R Date"
        '
        'txtShip
        '
        Me.txtShip.Location = New System.Drawing.Point(81, 76)
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(178, 20)
        Me.txtShip.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "G R No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "G R No."
        '
        'txtGrNo
        '
        Me.txtGrNo.Location = New System.Drawing.Point(81, 49)
        Me.txtGrNo.Name = "txtGrNo"
        Me.txtGrNo.Size = New System.Drawing.Size(178, 20)
        Me.txtGrNo.TabIndex = 5
        '
        'lblGr
        '
        Me.lblGr.AutoSize = True
        Me.lblGr.Location = New System.Drawing.Point(6, 50)
        Me.lblGr.Name = "lblGr"
        Me.lblGr.Size = New System.Drawing.Size(46, 13)
        Me.lblGr.TabIndex = 4
        Me.lblGr.Text = "G R No."
        '
        'cmbLorry
        '
        Me.cmbLorry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbLorry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbLorry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLorry.FormattingEnabled = True
        Me.cmbLorry.Location = New System.Drawing.Point(323, 19)
        Me.cmbLorry.Name = "cmbLorry"
        Me.cmbLorry.Size = New System.Drawing.Size(174, 21)
        Me.cmbLorry.TabIndex = 3
        '
        'lblLorry
        '
        Me.lblLorry.AutoSize = True
        Me.lblLorry.Location = New System.Drawing.Point(265, 23)
        Me.lblLorry.Name = "lblLorry"
        Me.lblLorry.Size = New System.Drawing.Size(30, 13)
        Me.lblLorry.TabIndex = 2
        Me.lblLorry.Text = "Lorry"
        '
        'cmbPlace
        '
        Me.cmbPlace.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPlace.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlace.FormattingEnabled = True
        Me.cmbPlace.Location = New System.Drawing.Point(81, 23)
        Me.cmbPlace.Name = "cmbPlace"
        Me.cmbPlace.Size = New System.Drawing.Size(178, 21)
        Me.cmbPlace.TabIndex = 1
        '
        'lblPlace
        '
        Me.lblPlace.AutoSize = True
        Me.lblPlace.Location = New System.Drawing.Point(8, 27)
        Me.lblPlace.Name = "lblPlace"
        Me.lblPlace.Size = New System.Drawing.Size(34, 13)
        Me.lblPlace.TabIndex = 0
        Me.lblPlace.Text = "Place"
        '
        'pnlsave
        '
        Me.pnlsave.Controls.Add(Me.btnCancel)
        Me.pnlsave.Controls.Add(Me.btnSave)
        Me.pnlsave.Location = New System.Drawing.Point(497, 431)
        Me.pnlsave.Name = "pnlsave"
        Me.pnlsave.Size = New System.Drawing.Size(179, 27)
        Me.pnlsave.TabIndex = 3
        '
        'tbNav
        '
        Me.tbNav.AutoSize = False
        Me.tbNav.Dock = System.Windows.Forms.DockStyle.None
        Me.tbNav.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbFirst, Me.tsbPrevious, Me.tsbNext, Me.tsbLast, Me.tsbSearch, Me.tsbRefresh, Me.tscBook})
        Me.tbNav.Location = New System.Drawing.Point(129, 0)
        Me.tbNav.Name = "tbNav"
        Me.tbNav.Size = New System.Drawing.Size(326, 25)
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TransChallan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 689)
        Me.Controls.Add(Me.pnlItems)
        Me.Controls.Add(Me.tbNav)
        Me.Controls.Add(Me.pnlsave)
        Me.Controls.Add(Me.pnlmain)
        Me.Controls.Add(Me.tbEdit)
        Me.KeyPreview = True
        Me.Name = "TransChallan"
        Me.Text = "Old Challan"
        Me.tbEdit.ResumeLayout(False)
        Me.tbEdit.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlmain.ResumeLayout(False)
        Me.pnlmain.PerformLayout()
        Me.pnlItems.ResumeLayout(False)
        Me.pnlItems.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.pnlsave.ResumeLayout(False)
        Me.tbNav.ResumeLayout(False)
        Me.tbNav.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbEdit As System.Windows.Forms.ToolStrip
    Friend WithEvents lblChallanNo As System.Windows.Forms.Label
    Friend WithEvents txtChallan As System.Windows.Forms.TextBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents dtChallanDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbBPP As System.Windows.Forms.RadioButton
    Friend WithEvents rbTP As System.Windows.Forms.RadioButton
    Friend WithEvents lblTransporter As System.Windows.Forms.Label
    Friend WithEvents cmbTransporter As System.Windows.Forms.ComboBox
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents lblCustName As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents lblFreight As System.Windows.Forms.Label
    Friend WithEvents txtFreight As System.Windows.Forms.TextBox
    Friend WithEvents lblLabour As System.Windows.Forms.Label
    Friend WithEvents txtLabour As System.Windows.Forms.TextBox
    Friend WithEvents lblCommission As System.Windows.Forms.Label
    Friend WithEvents txtCommission As System.Windows.Forms.TextBox
    Friend WithEvents lblTdsPer As System.Windows.Forms.Label
    Friend WithEvents txtTdsAmt As System.Windows.Forms.TextBox
    Friend WithEvents lblPayable As System.Windows.Forms.Label
    Friend WithEvents txtPayable As System.Windows.Forms.TextBox
    Friend WithEvents lblTDS As System.Windows.Forms.Label
    Friend WithEvents txtTDSRate As System.Windows.Forms.TextBox
    Friend WithEvents lblShortage As System.Windows.Forms.Label
    Friend WithEvents txtShortage As System.Windows.Forms.TextBox
    Friend WithEvents lblAdvance As System.Windows.Forms.Label
    Friend WithEvents txtAdv As System.Windows.Forms.TextBox
    Friend WithEvents lblNet As System.Windows.Forms.Label
    Friend WithEvents txtNetAmt As System.Windows.Forms.TextBox
    Friend WithEvents lblGross As System.Windows.Forms.Label
    Friend WithEvents txtGrossamt As System.Windows.Forms.TextBox
    Friend WithEvents lblTdsAmt As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtTdsOn As System.Windows.Forms.TextBox
    Friend WithEvents lblNarration As System.Windows.Forms.Label
    Friend WithEvents txtNarration As System.Windows.Forms.TextBox
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
    Friend WithEvents pnlItems As System.Windows.Forms.GroupBox
    Friend WithEvents txtGrNo As System.Windows.Forms.TextBox
    Friend WithEvents lblGr As System.Windows.Forms.Label
    Friend WithEvents cmbLorry As System.Windows.Forms.ComboBox
    Friend WithEvents lblLorry As System.Windows.Forms.Label
    Friend WithEvents cmbPlace As System.Windows.Forms.ComboBox
    Friend WithEvents lblPlace As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtEgp As System.Windows.Forms.TextBox
    Friend WithEvents txtGrade As System.Windows.Forms.TextBox
    Friend WithEvents txtBags As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents lblBags As System.Windows.Forms.Label
    Friend WithEvents lblegp As System.Windows.Forms.Label
    Friend WithEvents lblDiNo As System.Windows.Forms.Label
    Friend WithEvents lblShip As System.Windows.Forms.Label
    Friend WithEvents lblGRDate As System.Windows.Forms.Label
    Friend WithEvents txtShip As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents txtAmt As System.Windows.Forms.TextBox
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents txtShort As System.Windows.Forms.TextBox
    Friend WithEvents txtILabour As System.Windows.Forms.TextBox
    Friend WithEvents txtRateDiff As System.Windows.Forms.TextBox
    Friend WithEvents lblShort As System.Windows.Forms.Label
    Friend WithEvents lblILabour As System.Windows.Forms.Label
    Friend WithEvents lblRateDiff As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnICancel As System.Windows.Forms.Button
    Friend WithEvents btnISave As System.Windows.Forms.Button
    Friend WithEvents lblPrefix As System.Windows.Forms.Label
    Friend WithEvents lblGridMessage As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class

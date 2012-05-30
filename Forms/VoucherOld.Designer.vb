<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VoucherOld
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VoucherOld))
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
        Me.tbEdit = New System.Windows.Forms.ToolStrip
        Me.tsbNew = New System.Windows.Forms.ToolStripButton
        Me.tsbEdit = New System.Windows.Forms.ToolStripButton
        Me.tsbDelete = New System.Windows.Forms.ToolStripButton
        Me.tsbPrint = New System.Windows.Forms.ToolStripButton
        Me.lblVoucherNo = New System.Windows.Forms.Label
        Me.lblPrefix = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.lblDate = New System.Windows.Forms.Label
        Me.cmbAccount = New System.Windows.Forms.ComboBox
        Me.lblAccount = New System.Windows.Forms.Label
        Me.pnlBank = New System.Windows.Forms.Panel
        Me.dtpchq = New System.Windows.Forms.DateTimePicker
        Me.lblChqDate = New System.Windows.Forms.Label
        Me.txtBranch = New System.Windows.Forms.TextBox
        Me.Branch = New System.Windows.Forms.Label
        Me.txtBank = New System.Windows.Forms.TextBox
        Me.lblBank = New System.Windows.Forms.Label
        Me.txtchq = New System.Windows.Forms.TextBox
        Me.lblChq = New System.Windows.Forms.Label
        Me.txtNarration = New System.Windows.Forms.TextBox
        Me.lblNarration = New System.Windows.Forms.Label
        Me.pnlNarration = New System.Windows.Forms.Panel
        Me.lblDr = New System.Windows.Forms.Label
        Me.lblCredit = New System.Windows.Forms.Label
        Me.Net = New System.Windows.Forms.Label
        Me.lblDrCr = New System.Windows.Forms.Label
        Me.pnltotal = New System.Windows.Forms.Panel
        Me.pnlSave = New System.Windows.Forms.Panel
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlvoucher = New System.Windows.Forms.Panel
        Me.chkNarration = New System.Windows.Forms.CheckBox
        Me.lblSuffix = New System.Windows.Forms.Label
        Me.bsd = New System.Windows.Forms.BindingSource(Me.components)
        Me.ep = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtId = New System.Windows.Forms.TextBox
        Me.numVoucherNo = New Account.NumTextBox
        Me.numNet = New Account.NumTextBox
        Me.numCredit = New Account.NumTextBox
        Me.numDebit = New Account.NumTextBox
        Me.dgv = New Account.DataGridViewEnter
        Me.tbNav.SuspendLayout()
        Me.tbEdit.SuspendLayout()
        Me.pnlBank.SuspendLayout()
        Me.pnlNarration.SuspendLayout()
        Me.pnltotal.SuspendLayout()
        Me.pnlSave.SuspendLayout()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlvoucher.SuspendLayout()
        CType(Me.bsd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbNav
        '
        Me.tbNav.AutoSize = False
        Me.tbNav.Dock = System.Windows.Forms.DockStyle.None
        Me.tbNav.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbFirst, Me.tsbPrevious, Me.tsbNext, Me.tsbLast, Me.tsbSearch, Me.tsbRefresh, Me.tslGoto, Me.tstChallan, Me.tsbGo})
        Me.tbNav.Location = New System.Drawing.Point(130, 2)
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
        Me.tslGoto.Size = New System.Drawing.Size(66, 22)
        Me.tslGoto.Text = "Voucher No."
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
        'tbEdit
        '
        Me.tbEdit.AutoSize = False
        Me.tbEdit.Dock = System.Windows.Forms.DockStyle.None
        Me.tbEdit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNew, Me.tsbEdit, Me.tsbDelete, Me.tsbPrint})
        Me.tbEdit.Location = New System.Drawing.Point(3, 2)
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
        'lblVoucherNo
        '
        Me.lblVoucherNo.AutoSize = True
        Me.lblVoucherNo.Location = New System.Drawing.Point(4, 25)
        Me.lblVoucherNo.Name = "lblVoucherNo"
        Me.lblVoucherNo.Size = New System.Drawing.Size(67, 13)
        Me.lblVoucherNo.TabIndex = 0
        Me.lblVoucherNo.Text = "Voucher No."
        '
        'lblPrefix
        '
        Me.lblPrefix.AutoSize = True
        Me.lblPrefix.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPrefix.Location = New System.Drawing.Point(77, 6)
        Me.lblPrefix.Name = "lblPrefix"
        Me.lblPrefix.Size = New System.Drawing.Size(10, 13)
        Me.lblPrefix.TabIndex = 1
        Me.lblPrefix.Text = "."
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(185, 22)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(101, 20)
        Me.dtpDate.TabIndex = 5
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(150, 26)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Date"
        '
        'cmbAccount
        '
        Me.cmbAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAccount.FormattingEnabled = True
        Me.cmbAccount.Location = New System.Drawing.Point(345, 23)
        Me.cmbAccount.Name = "cmbAccount"
        Me.cmbAccount.Size = New System.Drawing.Size(419, 21)
        Me.cmbAccount.TabIndex = 7
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Location = New System.Drawing.Point(292, 26)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(47, 13)
        Me.lblAccount.TabIndex = 6
        Me.lblAccount.Text = "Account"
        '
        'pnlBank
        '
        Me.pnlBank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBank.Controls.Add(Me.dtpchq)
        Me.pnlBank.Controls.Add(Me.lblChqDate)
        Me.pnlBank.Controls.Add(Me.txtBranch)
        Me.pnlBank.Controls.Add(Me.Branch)
        Me.pnlBank.Controls.Add(Me.txtBank)
        Me.pnlBank.Controls.Add(Me.lblBank)
        Me.pnlBank.Controls.Add(Me.txtchq)
        Me.pnlBank.Controls.Add(Me.lblChq)
        Me.pnlBank.Location = New System.Drawing.Point(6, 96)
        Me.pnlBank.Name = "pnlBank"
        Me.pnlBank.Size = New System.Drawing.Size(881, 35)
        Me.pnlBank.TabIndex = 3
        '
        'dtpchq
        '
        Me.dtpchq.CustomFormat = "dd/MMM/yyyy"
        Me.dtpchq.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpchq.Location = New System.Drawing.Point(201, 7)
        Me.dtpchq.Name = "dtpchq"
        Me.dtpchq.Size = New System.Drawing.Size(101, 20)
        Me.dtpchq.TabIndex = 3
        '
        'lblChqDate
        '
        Me.lblChqDate.AutoSize = True
        Me.lblChqDate.Location = New System.Drawing.Point(166, 11)
        Me.lblChqDate.Name = "lblChqDate"
        Me.lblChqDate.Size = New System.Drawing.Size(30, 13)
        Me.lblChqDate.TabIndex = 2
        Me.lblChqDate.Text = "Date"
        '
        'txtBranch
        '
        Me.txtBranch.Location = New System.Drawing.Point(734, 8)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Size = New System.Drawing.Size(138, 20)
        Me.txtBranch.TabIndex = 7
        '
        'Branch
        '
        Me.Branch.AutoSize = True
        Me.Branch.Location = New System.Drawing.Point(687, 12)
        Me.Branch.Name = "Branch"
        Me.Branch.Size = New System.Drawing.Size(41, 13)
        Me.Branch.TabIndex = 6
        Me.Branch.Text = "Branch"
        '
        'txtBank
        '
        Me.txtBank.Location = New System.Drawing.Point(352, 7)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.Size = New System.Drawing.Size(329, 20)
        Me.txtBank.TabIndex = 5
        '
        'lblBank
        '
        Me.lblBank.AutoSize = True
        Me.lblBank.Location = New System.Drawing.Point(314, 11)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(32, 13)
        Me.lblBank.TabIndex = 4
        Me.lblBank.Text = "Bank"
        '
        'txtchq
        '
        Me.txtchq.Location = New System.Drawing.Point(55, 7)
        Me.txtchq.Name = "txtchq"
        Me.txtchq.Size = New System.Drawing.Size(100, 20)
        Me.txtchq.TabIndex = 1
        '
        'lblChq
        '
        Me.lblChq.AutoSize = True
        Me.lblChq.Location = New System.Drawing.Point(3, 12)
        Me.lblChq.Name = "lblChq"
        Me.lblChq.Size = New System.Drawing.Size(46, 13)
        Me.lblChq.TabIndex = 0
        Me.lblChq.Text = "Chq No."
        '
        'txtNarration
        '
        Me.txtNarration.Location = New System.Drawing.Point(55, 3)
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.Size = New System.Drawing.Size(817, 53)
        Me.txtNarration.TabIndex = 1
        '
        'lblNarration
        '
        Me.lblNarration.AutoSize = True
        Me.lblNarration.Location = New System.Drawing.Point(3, 3)
        Me.lblNarration.Name = "lblNarration"
        Me.lblNarration.Size = New System.Drawing.Size(50, 13)
        Me.lblNarration.TabIndex = 0
        Me.lblNarration.Text = "Narration"
        '
        'pnlNarration
        '
        Me.pnlNarration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNarration.Controls.Add(Me.txtNarration)
        Me.pnlNarration.Controls.Add(Me.lblNarration)
        Me.pnlNarration.Location = New System.Drawing.Point(6, 131)
        Me.pnlNarration.Name = "pnlNarration"
        Me.pnlNarration.Size = New System.Drawing.Size(881, 63)
        Me.pnlNarration.TabIndex = 4
        '
        'lblDr
        '
        Me.lblDr.AutoSize = True
        Me.lblDr.Location = New System.Drawing.Point(3, 9)
        Me.lblDr.Name = "lblDr"
        Me.lblDr.Size = New System.Drawing.Size(32, 13)
        Me.lblDr.TabIndex = 0
        Me.lblDr.Text = "Debit"
        '
        'lblCredit
        '
        Me.lblCredit.AutoSize = True
        Me.lblCredit.Location = New System.Drawing.Point(218, 9)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(34, 13)
        Me.lblCredit.TabIndex = 2
        Me.lblCredit.Text = "Credit"
        '
        'Net
        '
        Me.Net.AutoSize = True
        Me.Net.Location = New System.Drawing.Point(582, 9)
        Me.Net.Name = "Net"
        Me.Net.Size = New System.Drawing.Size(24, 13)
        Me.Net.TabIndex = 4
        Me.Net.Text = "Net"
        '
        'lblDrCr
        '
        Me.lblDrCr.AutoSize = True
        Me.lblDrCr.Location = New System.Drawing.Point(743, 9)
        Me.lblDrCr.Name = "lblDrCr"
        Me.lblDrCr.Size = New System.Drawing.Size(21, 13)
        Me.lblDrCr.TabIndex = 6
        Me.lblDrCr.Text = "Dr."
        '
        'pnltotal
        '
        Me.pnltotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnltotal.Controls.Add(Me.numNet)
        Me.pnltotal.Controls.Add(Me.lblDrCr)
        Me.pnltotal.Controls.Add(Me.Net)
        Me.pnltotal.Controls.Add(Me.numCredit)
        Me.pnltotal.Controls.Add(Me.lblCredit)
        Me.pnltotal.Controls.Add(Me.numDebit)
        Me.pnltotal.Controls.Add(Me.lblDr)
        Me.pnltotal.Location = New System.Drawing.Point(6, 496)
        Me.pnltotal.Name = "pnltotal"
        Me.pnltotal.Size = New System.Drawing.Size(881, 34)
        Me.pnltotal.TabIndex = 6
        '
        'pnlSave
        '
        Me.pnlSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSave.Controls.Add(Me.btnCancel)
        Me.pnlSave.Controls.Add(Me.btnSave)
        Me.pnlSave.Location = New System.Drawing.Point(720, 533)
        Me.pnlSave.Name = "pnlSave"
        Me.pnlSave.Size = New System.Drawing.Size(167, 31)
        Me.pnlSave.TabIndex = 7
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(86, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(5, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'pnlvoucher
        '
        Me.pnlvoucher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlvoucher.Controls.Add(Me.chkNarration)
        Me.pnlvoucher.Controls.Add(Me.lblSuffix)
        Me.pnlvoucher.Controls.Add(Me.lblAccount)
        Me.pnlvoucher.Controls.Add(Me.cmbAccount)
        Me.pnlvoucher.Controls.Add(Me.dtpDate)
        Me.pnlvoucher.Controls.Add(Me.lblPrefix)
        Me.pnlvoucher.Controls.Add(Me.numVoucherNo)
        Me.pnlvoucher.Controls.Add(Me.lblDate)
        Me.pnlvoucher.Controls.Add(Me.lblVoucherNo)
        Me.pnlvoucher.Location = New System.Drawing.Point(6, 33)
        Me.pnlvoucher.Name = "pnlvoucher"
        Me.pnlvoucher.Size = New System.Drawing.Size(881, 64)
        Me.pnlvoucher.TabIndex = 2
        '
        'chkNarration
        '
        Me.chkNarration.AutoSize = True
        Me.chkNarration.Checked = True
        Me.chkNarration.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNarration.Location = New System.Drawing.Point(771, 24)
        Me.chkNarration.Name = "chkNarration"
        Me.chkNarration.Size = New System.Drawing.Size(101, 17)
        Me.chkNarration.TabIndex = 9
        Me.chkNarration.Text = "Single Narration"
        Me.chkNarration.UseVisualStyleBackColor = True
        '
        'lblSuffix
        '
        Me.lblSuffix.AutoSize = True
        Me.lblSuffix.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSuffix.Location = New System.Drawing.Point(77, 47)
        Me.lblSuffix.Name = "lblSuffix"
        Me.lblSuffix.Size = New System.Drawing.Size(10, 13)
        Me.lblSuffix.TabIndex = 3
        Me.lblSuffix.Text = "."
        '
        'ep
        '
        Me.ep.ContainerControl = Me
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(6, 541)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 8
        '
        'numVoucherNo
        '
        Me.numVoucherNo.dec = CType(0, Short)
        Me.numVoucherNo.format = "{0:f0}"
        Me.numVoucherNo.Location = New System.Drawing.Point(77, 22)
        Me.numVoucherNo.Name = "numVoucherNo"
        Me.numVoucherNo.Size = New System.Drawing.Size(67, 20)
        Me.numVoucherNo.TabIndex = 2
        Me.numVoucherNo.Text = "0"
        Me.numVoucherNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numVoucherNo.value = 0
        '
        'numNet
        '
        Me.numNet.dec = CType(2, Short)
        Me.numNet.format = "{0:N2}"
        Me.numNet.Location = New System.Drawing.Point(612, 5)
        Me.numNet.Name = "numNet"
        Me.numNet.ReadOnly = True
        Me.numNet.Size = New System.Drawing.Size(125, 20)
        Me.numNet.TabIndex = 5
        Me.numNet.TabStop = False
        Me.numNet.Text = "0.00"
        Me.numNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numNet.value = 0
        '
        'numCredit
        '
        Me.numCredit.dec = CType(2, Short)
        Me.numCredit.format = "{0:N2}"
        Me.numCredit.Location = New System.Drawing.Point(291, 5)
        Me.numCredit.Name = "numCredit"
        Me.numCredit.ReadOnly = True
        Me.numCredit.Size = New System.Drawing.Size(125, 20)
        Me.numCredit.TabIndex = 3
        Me.numCredit.TabStop = False
        Me.numCredit.Text = "0.00"
        Me.numCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numCredit.value = 0
        '
        'numDebit
        '
        Me.numDebit.dec = CType(2, Short)
        Me.numDebit.format = "{0:N2}"
        Me.numDebit.Location = New System.Drawing.Point(76, 5)
        Me.numDebit.Name = "numDebit"
        Me.numDebit.ReadOnly = True
        Me.numDebit.Size = New System.Drawing.Size(125, 20)
        Me.numDebit.TabIndex = 1
        Me.numDebit.TabStop = False
        Me.numDebit.Text = "0.00"
        Me.numDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numDebit.value = 0
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(6, 196)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(881, 294)
        Me.dgv.TabIndex = 5
        '
        'Voucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 566)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.pnlvoucher)
        Me.Controls.Add(Me.pnlSave)
        Me.Controls.Add(Me.pnltotal)
        Me.Controls.Add(Me.pnlNarration)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.pnlBank)
        Me.Controls.Add(Me.tbNav)
        Me.Controls.Add(Me.tbEdit)
        Me.Name = "Voucher"
        Me.Text = "Voucher"
        Me.tbNav.ResumeLayout(False)
        Me.tbNav.PerformLayout()
        Me.tbEdit.ResumeLayout(False)
        Me.tbEdit.PerformLayout()
        Me.pnlBank.ResumeLayout(False)
        Me.pnlBank.PerformLayout()
        Me.pnlNarration.ResumeLayout(False)
        Me.pnlNarration.PerformLayout()
        Me.pnltotal.ResumeLayout(False)
        Me.pnltotal.PerformLayout()
        Me.pnlSave.ResumeLayout(False)
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlvoucher.ResumeLayout(False)
        Me.pnlvoucher.PerformLayout()
        CType(Me.bsd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbNav As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbPrevious As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents tslGoto As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstChallan As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbGo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbEdit As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblVoucherNo As System.Windows.Forms.Label
    Friend WithEvents numVoucherNo As Account.NumTextBox
    Friend WithEvents lblPrefix As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents cmbAccount As System.Windows.Forms.ComboBox
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents pnlBank As System.Windows.Forms.Panel
    Friend WithEvents lblChq As System.Windows.Forms.Label
    Friend WithEvents txtchq As System.Windows.Forms.TextBox
    Friend WithEvents dtpchq As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblChqDate As System.Windows.Forms.Label
    Friend WithEvents txtBranch As System.Windows.Forms.TextBox
    Friend WithEvents Branch As System.Windows.Forms.Label
    Friend WithEvents txtBank As System.Windows.Forms.TextBox
    Friend WithEvents lblBank As System.Windows.Forms.Label
    Friend WithEvents txtNarration As System.Windows.Forms.TextBox
    Friend WithEvents lblNarration As System.Windows.Forms.Label
    Friend WithEvents dgv As Account.DataGridViewEnter
    Friend WithEvents pnlNarration As System.Windows.Forms.Panel
    Friend WithEvents numDebit As Account.NumTextBox
    Friend WithEvents lblDr As System.Windows.Forms.Label
    Friend WithEvents numCredit As Account.NumTextBox
    Friend WithEvents lblCredit As System.Windows.Forms.Label
    Friend WithEvents numNet As Account.NumTextBox
    Friend WithEvents Net As System.Windows.Forms.Label
    Friend WithEvents lblDrCr As System.Windows.Forms.Label
    Friend WithEvents pnltotal As System.Windows.Forms.Panel
    Friend WithEvents pnlSave As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents bs As System.Windows.Forms.BindingSource
    Friend WithEvents pnlvoucher As System.Windows.Forms.Panel
    Friend WithEvents lblSuffix As System.Windows.Forms.Label
    Friend WithEvents bsd As System.Windows.Forms.BindingSource
    Friend WithEvents ep As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents chkNarration As System.Windows.Forms.CheckBox
End Class

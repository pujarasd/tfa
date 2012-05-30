<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lb = New System.Windows.Forms.ListBox
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.lblVoucher = New System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label
        Me.lblVoucherNo = New System.Windows.Forms.Label
        Me.txtAccount = New System.Windows.Forms.TextBox
        Me.lblAccount = New System.Windows.Forms.Label
        Me.chkNarration = New System.Windows.Forms.CheckBox
        Me.pnlNarration = New System.Windows.Forms.Panel
        Me.txtNarration = New System.Windows.Forms.TextBox
        Me.lblNarration = New System.Windows.Forms.Label
        Me.pnlBank = New System.Windows.Forms.Panel
        Me.dtpchq = New System.Windows.Forms.DateTimePicker
        Me.lblChqDate = New System.Windows.Forms.Label
        Me.txtBranch = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBank = New System.Windows.Forms.TextBox
        Me.lblBank = New System.Windows.Forms.Label
        Me.txtchq = New System.Windows.Forms.TextBox
        Me.lblChq = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbldrcr = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.numNet = New Account.NumTextBox
        Me.numCredit = New Account.NumTextBox
        Me.numDebit = New Account.NumTextBox
        Me.numVoucherNo = New Account.NumTextBox
        Me.dgv = New Account.DataGridViewEnter
        Me.Sr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Account = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Debit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Credit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chq = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChqDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Bank = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Branch = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Narration = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nxt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnlNarration.SuspendLayout()
        Me.pnlBank.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(537, 456)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lb
        '
        Me.lb.FormattingEnabled = True
        Me.lb.Items.AddRange(New Object() {"One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten"})
        Me.lb.Location = New System.Drawing.Point(250, 61)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(362, 277)
        Me.lb.TabIndex = 9
        Me.lb.Visible = False
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(375, 6)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(113, 20)
        Me.dtpDate.TabIndex = 4
        '
        'lblVoucher
        '
        Me.lblVoucher.AutoSize = True
        Me.lblVoucher.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblVoucher.Location = New System.Drawing.Point(180, 13)
        Me.lblVoucher.Name = "lblVoucher"
        Me.lblVoucher.Size = New System.Drawing.Size(10, 13)
        Me.lblVoucher.TabIndex = 2
        Me.lblVoucher.Text = "."
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(340, 10)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date"
        '
        'lblVoucherNo
        '
        Me.lblVoucherNo.AutoSize = True
        Me.lblVoucherNo.Location = New System.Drawing.Point(17, 11)
        Me.lblVoucherNo.Name = "lblVoucherNo"
        Me.lblVoucherNo.Size = New System.Drawing.Size(67, 13)
        Me.lblVoucherNo.TabIndex = 0
        Me.lblVoucherNo.Text = "Voucher No."
        '
        'txtAccount
        '
        Me.txtAccount.Location = New System.Drawing.Point(90, 34)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(391, 20)
        Me.txtAccount.TabIndex = 7
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Location = New System.Drawing.Point(17, 37)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(47, 13)
        Me.lblAccount.TabIndex = 6
        Me.lblAccount.Text = "Account"
        '
        'chkNarration
        '
        Me.chkNarration.AutoSize = True
        Me.chkNarration.Checked = True
        Me.chkNarration.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNarration.Location = New System.Drawing.Point(500, 9)
        Me.chkNarration.Name = "chkNarration"
        Me.chkNarration.Size = New System.Drawing.Size(101, 17)
        Me.chkNarration.TabIndex = 5
        Me.chkNarration.Text = "Narration Single"
        Me.chkNarration.UseVisualStyleBackColor = True
        '
        'pnlNarration
        '
        Me.pnlNarration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNarration.Controls.Add(Me.txtNarration)
        Me.pnlNarration.Controls.Add(Me.lblNarration)
        Me.pnlNarration.Location = New System.Drawing.Point(334, 370)
        Me.pnlNarration.Name = "pnlNarration"
        Me.pnlNarration.Size = New System.Drawing.Size(286, 78)
        Me.pnlNarration.TabIndex = 11
        '
        'txtNarration
        '
        Me.txtNarration.Location = New System.Drawing.Point(55, 3)
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.Size = New System.Drawing.Size(221, 65)
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
        'pnlBank
        '
        Me.pnlBank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBank.Controls.Add(Me.dtpchq)
        Me.pnlBank.Controls.Add(Me.lblChqDate)
        Me.pnlBank.Controls.Add(Me.txtBranch)
        Me.pnlBank.Controls.Add(Me.Label1)
        Me.pnlBank.Controls.Add(Me.txtBank)
        Me.pnlBank.Controls.Add(Me.lblBank)
        Me.pnlBank.Controls.Add(Me.txtchq)
        Me.pnlBank.Controls.Add(Me.lblChq)
        Me.pnlBank.Location = New System.Drawing.Point(20, 370)
        Me.pnlBank.Name = "pnlBank"
        Me.pnlBank.Size = New System.Drawing.Size(308, 78)
        Me.pnlBank.TabIndex = 10
        '
        'dtpchq
        '
        Me.dtpchq.CustomFormat = "dd/MMM/yyyy"
        Me.dtpchq.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpchq.Location = New System.Drawing.Point(178, 7)
        Me.dtpchq.Name = "dtpchq"
        Me.dtpchq.Size = New System.Drawing.Size(119, 20)
        Me.dtpchq.TabIndex = 3
        '
        'lblChqDate
        '
        Me.lblChqDate.AutoSize = True
        Me.lblChqDate.Location = New System.Drawing.Point(143, 11)
        Me.lblChqDate.Name = "lblChqDate"
        Me.lblChqDate.Size = New System.Drawing.Size(30, 13)
        Me.lblChqDate.TabIndex = 2
        Me.lblChqDate.Text = "Date"
        '
        'txtBranch
        '
        Me.txtBranch.Location = New System.Drawing.Point(55, 49)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Size = New System.Drawing.Size(242, 20)
        Me.txtBranch.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Branch"
        '
        'txtBank
        '
        Me.txtBank.Location = New System.Drawing.Point(55, 28)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.Size = New System.Drawing.Size(242, 20)
        Me.txtBank.TabIndex = 5
        '
        'lblBank
        '
        Me.lblBank.AutoSize = True
        Me.lblBank.Location = New System.Drawing.Point(4, 32)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(32, 13)
        Me.lblBank.TabIndex = 4
        Me.lblBank.Text = "Bank"
        '
        'txtchq
        '
        Me.txtchq.Location = New System.Drawing.Point(55, 7)
        Me.txtchq.Name = "txtchq"
        Me.txtchq.Size = New System.Drawing.Size(80, 20)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 347)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Debit"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 348)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Credit"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(587, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Net"
        Me.Label4.Visible = False
        '
        'lbldrcr
        '
        Me.lbldrcr.AutoSize = True
        Me.lbldrcr.Location = New System.Drawing.Point(593, 38)
        Me.lbldrcr.Name = "lbldrcr"
        Me.lbldrcr.Size = New System.Drawing.Size(18, 13)
        Me.lbldrcr.TabIndex = 19
        Me.lbldrcr.Text = "Dr"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(456, 456)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'numNet
        '
        Me.numNet.dec = CType(2, Short)
        Me.numNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numNet.format = Nothing
        Me.numNet.Location = New System.Drawing.Point(487, 34)
        Me.numNet.Name = "numNet"
        Me.numNet.Size = New System.Drawing.Size(100, 20)
        Me.numNet.TabIndex = 18
        Me.numNet.TabStop = False
        Me.numNet.Text = "0.00"
        Me.numNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numNet.value = 0
        '
        'numCredit
        '
        Me.numCredit.dec = CType(2, Short)
        Me.numCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCredit.ForeColor = System.Drawing.Color.Blue
        Me.numCredit.format = Nothing
        Me.numCredit.Location = New System.Drawing.Point(350, 344)
        Me.numCredit.Name = "numCredit"
        Me.numCredit.Size = New System.Drawing.Size(100, 20)
        Me.numCredit.TabIndex = 16
        Me.numCredit.TabStop = False
        Me.numCredit.Text = "0.00"
        Me.numCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numCredit.value = 0
        '
        'numDebit
        '
        Me.numDebit.dec = CType(2, Short)
        Me.numDebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numDebit.ForeColor = System.Drawing.Color.Red
        Me.numDebit.format = Nothing
        Me.numDebit.Location = New System.Drawing.Point(250, 344)
        Me.numDebit.Name = "numDebit"
        Me.numDebit.Size = New System.Drawing.Size(100, 20)
        Me.numDebit.TabIndex = 14
        Me.numDebit.TabStop = False
        Me.numDebit.Text = "0.00"
        Me.numDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numDebit.value = 0
        '
        'numVoucherNo
        '
        Me.numVoucherNo.dec = CType(0, Short)
        Me.numVoucherNo.format = "{0:f0}"
        Me.numVoucherNo.Location = New System.Drawing.Point(90, 8)
        Me.numVoucherNo.Name = "numVoucherNo"
        Me.numVoucherNo.Size = New System.Drawing.Size(67, 20)
        Me.numVoucherNo.TabIndex = 1
        Me.numVoucherNo.Text = "0"
        Me.numVoucherNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numVoucherNo.value = 0
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sr, Me.DC, Me.Account, Me.Debit, Me.Credit, Me.Chq, Me.ChqDate, Me.Bank, Me.Branch, Me.Narration, Me.nxt})
        Me.dgv.EnableHeadersVisualStyles = False
        Me.dgv.Location = New System.Drawing.Point(20, 60)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 30
        Me.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv.Size = New System.Drawing.Size(595, 280)
        Me.dgv.TabIndex = 8
        '
        'Sr
        '
        Me.Sr.HeaderText = "Sr"
        Me.Sr.Name = "Sr"
        Me.Sr.ReadOnly = True
        Me.Sr.Width = 20
        '
        'DC
        '
        Me.DC.HeaderText = "DC"
        Me.DC.Name = "DC"
        Me.DC.Width = 30
        '
        'Account
        '
        Me.Account.HeaderText = "Account"
        Me.Account.Name = "Account"
        Me.Account.Width = 150
        '
        'Debit
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.Debit.DefaultCellStyle = DataGridViewCellStyle1
        Me.Debit.HeaderText = "Debit Amount"
        Me.Debit.MaxInputLength = 15
        Me.Debit.Name = "Debit"
        '
        'Credit
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.Credit.DefaultCellStyle = DataGridViewCellStyle2
        Me.Credit.HeaderText = "Credit Amount"
        Me.Credit.MaxInputLength = 15
        Me.Credit.Name = "Credit"
        '
        'Chq
        '
        Me.Chq.HeaderText = "Chq"
        Me.Chq.MaxInputLength = 10
        Me.Chq.Name = "Chq"
        Me.Chq.Width = 80
        '
        'ChqDate
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ChqDate.DefaultCellStyle = DataGridViewCellStyle3
        Me.ChqDate.HeaderText = "Chq Date"
        Me.ChqDate.MaxInputLength = 12
        Me.ChqDate.Name = "ChqDate"
        Me.ChqDate.Width = 80
        '
        'Bank
        '
        Me.Bank.HeaderText = "Bank"
        Me.Bank.MaxInputLength = 50
        Me.Bank.Name = "Bank"
        '
        'Branch
        '
        Me.Branch.HeaderText = "Branch"
        Me.Branch.MaxInputLength = 50
        Me.Branch.Name = "Branch"
        Me.Branch.Width = 50
        '
        'Narration
        '
        Me.Narration.HeaderText = "Narration"
        Me.Narration.MaxInputLength = 2000
        Me.Narration.Name = "Narration"
        Me.Narration.Width = 150
        '
        'nxt
        '
        Me.nxt.HeaderText = "Next"
        Me.nxt.Name = "nxt"
        Me.nxt.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nxt.Width = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 482)
        Me.Controls.Add(Me.numNet)
        Me.Controls.Add(Me.numCredit)
        Me.Controls.Add(Me.numDebit)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.pnlNarration)
        Me.Controls.Add(Me.pnlBank)
        Me.Controls.Add(Me.chkNarration)
        Me.Controls.Add(Me.lblAccount)
        Me.Controls.Add(Me.txtAccount)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.lblVoucher)
        Me.Controls.Add(Me.numVoucherNo)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lbldrcr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblVoucherNo)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.dgv)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pnlNarration.ResumeLayout(False)
        Me.pnlNarration.PerformLayout()
        Me.pnlBank.ResumeLayout(False)
        Me.pnlBank.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As Account.DataGridViewEnter
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lb As System.Windows.Forms.ListBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblVoucher As System.Windows.Forms.Label
    Friend WithEvents numVoucherNo As Account.NumTextBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblVoucherNo As System.Windows.Forms.Label
    Friend WithEvents txtAccount As System.Windows.Forms.TextBox
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents chkNarration As System.Windows.Forms.CheckBox
    Friend WithEvents pnlNarration As System.Windows.Forms.Panel
    Friend WithEvents txtNarration As System.Windows.Forms.TextBox
    Friend WithEvents lblNarration As System.Windows.Forms.Label
    Friend WithEvents pnlBank As System.Windows.Forms.Panel
    Friend WithEvents dtpchq As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblChqDate As System.Windows.Forms.Label
    Friend WithEvents txtBranch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBank As System.Windows.Forms.TextBox
    Friend WithEvents lblBank As System.Windows.Forms.Label
    Friend WithEvents txtchq As System.Windows.Forms.TextBox
    Friend WithEvents lblChq As System.Windows.Forms.Label
    Friend WithEvents numDebit As Account.NumTextBox
    Friend WithEvents numCredit As Account.NumTextBox
    Friend WithEvents numNet As Account.NumTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbldrcr As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Sr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Account As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Debit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Credit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chq As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChqDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bank As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Branch As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Narration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nxt As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

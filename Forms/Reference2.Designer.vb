<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reference2
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
        Me.pnlSave = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.lblAccount = New System.Windows.Forms.Label
        Me.lblAmount = New System.Windows.Forms.Label
        Me.lblAccountName = New System.Windows.Forms.Label
        Me.lblamt = New System.Windows.Forms.Label
        Me.cmbRefType = New System.Windows.Forms.ComboBox
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.cmbRefNo = New System.Windows.Forms.ComboBox
        Me.lblSr = New System.Windows.Forms.Label
        Me.pnlEntry = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.numAmount = New Account.NumTextBox
        Me.lbltobeAdjust = New System.Windows.Forms.Label
        Me.lblToadj = New System.Windows.Forms.Label
        Me.lblAdjusted = New System.Windows.Forms.Label
        Me.lblAdjstedAmt = New System.Windows.Forms.Label
        Me.dgv = New Account.DataGridViewEnter
        Me.pnlSave.SuspendLayout()
        Me.pnlEntry.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSave
        '
        Me.pnlSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSave.ColumnCount = 2
        Me.pnlSave.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlSave.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlSave.Controls.Add(Me.OK_Button, 0, 0)
        Me.pnlSave.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.pnlSave.Location = New System.Drawing.Point(495, 274)
        Me.pnlSave.Name = "pnlSave"
        Me.pnlSave.RowCount = 1
        Me.pnlSave.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlSave.Size = New System.Drawing.Size(146, 29)
        Me.pnlSave.TabIndex = 9
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Location = New System.Drawing.Point(3, 4)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(50, 13)
        Me.lblAccount.TabIndex = 0
        Me.lblAccount.Text = "Account:"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(3, 28)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(98, 13)
        Me.lblAmount.TabIndex = 2
        Me.lblAmount.Text = "Adjustment Amount"
        '
        'lblAccountName
        '
        Me.lblAccountName.AutoSize = True
        Me.lblAccountName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountName.Location = New System.Drawing.Point(56, 4)
        Me.lblAccountName.Name = "lblAccountName"
        Me.lblAccountName.Size = New System.Drawing.Size(54, 13)
        Me.lblAccountName.TabIndex = 1
        Me.lblAccountName.Text = "Account"
        '
        'lblamt
        '
        Me.lblamt.AutoSize = True
        Me.lblamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamt.Location = New System.Drawing.Point(107, 28)
        Me.lblamt.Name = "lblamt"
        Me.lblamt.Size = New System.Drawing.Size(115, 13)
        Me.lblamt.TabIndex = 3
        Me.lblamt.Text = "Adjustment Amount"
        '
        'cmbRefType
        '
        Me.cmbRefType.FormattingEnabled = True
        Me.cmbRefType.Items.AddRange(New Object() {"OnAccount", "Advance", "Against", "New"})
        Me.cmbRefType.Location = New System.Drawing.Point(9, 26)
        Me.cmbRefType.Name = "cmbRefType"
        Me.cmbRefType.Size = New System.Drawing.Size(87, 21)
        Me.cmbRefType.TabIndex = 5
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(279, 27)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(92, 20)
        Me.dtpDate.TabIndex = 7
        '
        'dtpDueDate
        '
        Me.dtpDueDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDueDate.Location = New System.Drawing.Point(375, 26)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(94, 20)
        Me.dtpDueDate.TabIndex = 8
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Dr", "Cr"})
        Me.cmbType.Location = New System.Drawing.Point(596, 26)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(44, 21)
        Me.cmbType.TabIndex = 10
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(484, 53)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(565, 53)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cmbRefNo
        '
        Me.cmbRefNo.DropDownWidth = 300
        Me.cmbRefNo.FormattingEnabled = True
        Me.cmbRefNo.Location = New System.Drawing.Point(102, 26)
        Me.cmbRefNo.Name = "cmbRefNo"
        Me.cmbRefNo.Size = New System.Drawing.Size(171, 21)
        Me.cmbRefNo.TabIndex = 6
        '
        'lblSr
        '
        Me.lblSr.AutoSize = True
        Me.lblSr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSr.Location = New System.Drawing.Point(64, 53)
        Me.lblSr.Name = "lblSr"
        Me.lblSr.Size = New System.Drawing.Size(15, 15)
        Me.lblSr.TabIndex = 12
        Me.lblSr.Text = "0"
        '
        'pnlEntry
        '
        Me.pnlEntry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlEntry.Controls.Add(Me.Label5)
        Me.pnlEntry.Controls.Add(Me.Label4)
        Me.pnlEntry.Controls.Add(Me.Label3)
        Me.pnlEntry.Controls.Add(Me.Label2)
        Me.pnlEntry.Controls.Add(Me.Label1)
        Me.pnlEntry.Controls.Add(Me.Label6)
        Me.pnlEntry.Controls.Add(Me.lblSr)
        Me.pnlEntry.Controls.Add(Me.numAmount)
        Me.pnlEntry.Controls.Add(Me.btnCancel)
        Me.pnlEntry.Controls.Add(Me.btnSave)
        Me.pnlEntry.Controls.Add(Me.dtpDueDate)
        Me.pnlEntry.Controls.Add(Me.dtpDate)
        Me.pnlEntry.Controls.Add(Me.cmbType)
        Me.pnlEntry.Controls.Add(Me.cmbRefNo)
        Me.pnlEntry.Controls.Add(Me.cmbRefType)
        Me.pnlEntry.Location = New System.Drawing.Point(3, 42)
        Me.pnlEntry.Name = "pnlEntry"
        Me.pnlEntry.Size = New System.Drawing.Size(645, 87)
        Me.pnlEntry.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(522, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Amount (Rs.)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(384, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Due Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(269, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ref. Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(159, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ref. No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ref.Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Sr.No."
        '
        'numAmount
        '
        Me.numAmount.dec = CType(2, Short)
        Me.numAmount.format = Nothing
        Me.numAmount.Location = New System.Drawing.Point(473, 26)
        Me.numAmount.Name = "numAmount"
        Me.numAmount.Size = New System.Drawing.Size(120, 20)
        Me.numAmount.TabIndex = 9
        Me.numAmount.Text = "0.00"
        Me.numAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numAmount.value = 0
        '
        'lbltobeAdjust
        '
        Me.lbltobeAdjust.AutoSize = True
        Me.lbltobeAdjust.Location = New System.Drawing.Point(429, 26)
        Me.lbltobeAdjust.Name = "lbltobeAdjust"
        Me.lbltobeAdjust.Size = New System.Drawing.Size(90, 13)
        Me.lbltobeAdjust.TabIndex = 4
        Me.lbltobeAdjust.Text = "Balance to Adjust"
        '
        'lblToadj
        '
        Me.lblToadj.AutoSize = True
        Me.lblToadj.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToadj.ForeColor = System.Drawing.Color.Red
        Me.lblToadj.Location = New System.Drawing.Point(533, 26)
        Me.lblToadj.Name = "lblToadj"
        Me.lblToadj.Size = New System.Drawing.Size(0, 13)
        Me.lblToadj.TabIndex = 5
        '
        'lblAdjusted
        '
        Me.lblAdjusted.AutoSize = True
        Me.lblAdjusted.Location = New System.Drawing.Point(3, 274)
        Me.lblAdjusted.Name = "lblAdjusted"
        Me.lblAdjusted.Size = New System.Drawing.Size(87, 13)
        Me.lblAdjusted.TabIndex = 7
        Me.lblAdjusted.Text = "Amount Adjusted"
        '
        'lblAdjstedAmt
        '
        Me.lblAdjstedAmt.AutoSize = True
        Me.lblAdjstedAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdjstedAmt.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblAdjstedAmt.Location = New System.Drawing.Point(107, 274)
        Me.lblAdjstedAmt.Name = "lblAdjstedAmt"
        Me.lblAdjstedAmt.Size = New System.Drawing.Size(0, 13)
        Me.lblAdjstedAmt.TabIndex = 8
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(3, 129)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(645, 139)
        Me.dgv.TabIndex = 10
        '
        'Reference2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 315)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.pnlEntry)
        Me.Controls.Add(Me.lblAdjstedAmt)
        Me.Controls.Add(Me.lblToadj)
        Me.Controls.Add(Me.lblAdjusted)
        Me.Controls.Add(Me.lbltobeAdjust)
        Me.Controls.Add(Me.lblamt)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblAccountName)
        Me.Controls.Add(Me.lblAccount)
        Me.Controls.Add(Me.pnlSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reference2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reference"
        Me.pnlSave.ResumeLayout(False)
        Me.pnlEntry.ResumeLayout(False)
        Me.pnlEntry.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlSave As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents dgv As Account.DataGridViewEnter
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lblAccountName As System.Windows.Forms.Label
    Friend WithEvents lblamt As System.Windows.Forms.Label
    Friend WithEvents cmbRefType As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cmbRefNo As System.Windows.Forms.ComboBox
    Friend WithEvents numAmount As Account.NumTextBox
    Friend WithEvents lblSr As System.Windows.Forms.Label
    Friend WithEvents pnlEntry As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltobeAdjust As System.Windows.Forms.Label
    Friend WithEvents lblToadj As System.Windows.Forms.Label
    Friend WithEvents lblAdjusted As System.Windows.Forms.Label
    Friend WithEvents lblAdjstedAmt As System.Windows.Forms.Label

End Class

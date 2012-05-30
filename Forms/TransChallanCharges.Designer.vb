<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ttranschallancharges
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lblRate = New System.Windows.Forms.Label
        Me.lblRateOn = New System.Windows.Forms.Label
        Me.lblAmtOn = New System.Windows.Forms.Label
        Me.lblAmount = New System.Windows.Forms.Label
        Me.lblCharges = New System.Windows.Forms.Label
        Me.cmbCharges = New System.Windows.Forms.ComboBox
        Me.lblAddLess = New System.Windows.Forms.Label
        Me.txtrateOn = New System.Windows.Forms.TextBox
        Me.txtAccount = New System.Windows.Forms.TextBox
        Me.lblAccount = New System.Windows.Forms.Label
        Me.ntxtRate = New Account.NumTextBox
        Me.ntxtAmount = New Account.NumTextBox
        Me.ntxtAmtOn = New Account.NumTextBox
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(440, 86)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 18
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Location = New System.Drawing.Point(3, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(67, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(76, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(67, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(369, 26)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(30, 13)
        Me.lblRate.TabIndex = 6
        Me.lblRate.Text = "Rate"
        '
        'lblRateOn
        '
        Me.lblRateOn.AutoSize = True
        Me.lblRateOn.Location = New System.Drawing.Point(16, 55)
        Me.lblRateOn.Name = "lblRateOn"
        Me.lblRateOn.Size = New System.Drawing.Size(47, 13)
        Me.lblRateOn.TabIndex = 4
        Me.lblRateOn.Text = "Rate On"
        '
        'lblAmtOn
        '
        Me.lblAmtOn.AutoSize = True
        Me.lblAmtOn.Location = New System.Drawing.Point(198, 54)
        Me.lblAmtOn.Name = "lblAmtOn"
        Me.lblAmtOn.Size = New System.Drawing.Size(60, 13)
        Me.lblAmtOn.TabIndex = 8
        Me.lblAmtOn.Text = "Amount On"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(369, 55)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(46, 13)
        Me.lblAmount.TabIndex = 14
        Me.lblAmount.Text = "Amount "
        '
        'lblCharges
        '
        Me.lblCharges.AutoSize = True
        Me.lblCharges.Location = New System.Drawing.Point(16, 26)
        Me.lblCharges.Name = "lblCharges"
        Me.lblCharges.Size = New System.Drawing.Size(46, 13)
        Me.lblCharges.TabIndex = 0
        Me.lblCharges.Text = "Charges"
        '
        'cmbCharges
        '
        Me.cmbCharges.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCharges.FormattingEnabled = True
        Me.cmbCharges.Location = New System.Drawing.Point(94, 23)
        Me.cmbCharges.Name = "cmbCharges"
        Me.cmbCharges.Size = New System.Drawing.Size(269, 21)
        Me.cmbCharges.TabIndex = 19
        '
        'lblAddLess
        '
        Me.lblAddLess.AutoSize = True
        Me.lblAddLess.Location = New System.Drawing.Point(553, 53)
        Me.lblAddLess.Name = "lblAddLess"
        Me.lblAddLess.Size = New System.Drawing.Size(13, 13)
        Me.lblAddLess.TabIndex = 20
        Me.lblAddLess.Text = "+"
        '
        'txtrateOn
        '
        Me.txtrateOn.Location = New System.Drawing.Point(94, 50)
        Me.txtrateOn.Name = "txtrateOn"
        Me.txtrateOn.Size = New System.Drawing.Size(100, 20)
        Me.txtrateOn.TabIndex = 21
        '
        'txtAccount
        '
        Me.txtAccount.Location = New System.Drawing.Point(94, 86)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.ReadOnly = True
        Me.txtAccount.Size = New System.Drawing.Size(270, 20)
        Me.txtAccount.TabIndex = 22
        Me.txtAccount.TabStop = False
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Location = New System.Drawing.Point(17, 89)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(47, 13)
        Me.lblAccount.TabIndex = 0
        Me.lblAccount.Text = "Account"
        '
        'ntxtRate
        '
        Me.ntxtRate.dec = CType(2, Short)
        Me.ntxtRate.Location = New System.Drawing.Point(446, 23)
        Me.ntxtRate.Name = "ntxtRate"
        Me.ntxtRate.ReadOnly = True
        Me.ntxtRate.Size = New System.Drawing.Size(100, 20)
        Me.ntxtRate.TabIndex = 7
        Me.ntxtRate.TabStop = False
        Me.ntxtRate.Text = "0.00"
        Me.ntxtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtRate.value = 0
        '
        'ntxtAmount
        '
        Me.ntxtAmount.dec = CType(2, Short)
        Me.ntxtAmount.Location = New System.Drawing.Point(446, 51)
        Me.ntxtAmount.Name = "ntxtAmount"
        Me.ntxtAmount.Size = New System.Drawing.Size(100, 20)
        Me.ntxtAmount.TabIndex = 15
        Me.ntxtAmount.Text = "0.00"
        Me.ntxtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtAmount.value = 0
        '
        'ntxtAmtOn
        '
        Me.ntxtAmtOn.dec = CType(2, Short)
        Me.ntxtAmtOn.Location = New System.Drawing.Point(264, 50)
        Me.ntxtAmtOn.Name = "ntxtAmtOn"
        Me.ntxtAmtOn.ReadOnly = True
        Me.ntxtAmtOn.Size = New System.Drawing.Size(100, 20)
        Me.ntxtAmtOn.TabIndex = 9
        Me.ntxtAmtOn.TabStop = False
        Me.ntxtAmtOn.Text = "0.00"
        Me.ntxtAmtOn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtAmtOn.value = 0
        '
        'ttranschallancharges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 127)
        Me.Controls.Add(Me.txtAccount)
        Me.Controls.Add(Me.txtrateOn)
        Me.Controls.Add(Me.lblAddLess)
        Me.Controls.Add(Me.cmbCharges)
        Me.Controls.Add(Me.ntxtRate)
        Me.Controls.Add(Me.ntxtAmount)
        Me.Controls.Add(Me.ntxtAmtOn)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblAmtOn)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblRateOn)
        Me.Controls.Add(Me.lblAccount)
        Me.Controls.Add(Me.lblCharges)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ttranschallancharges"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Charges"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents ntxtAmtOn As Account.NumTextBox
    Friend WithEvents ntxtRate As Account.NumTextBox
    Friend WithEvents lblRateOn As System.Windows.Forms.Label
    Friend WithEvents lblAmtOn As System.Windows.Forms.Label
    Friend WithEvents ntxtAmount As Account.NumTextBox
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lblCharges As System.Windows.Forms.Label
    Friend WithEvents cmbCharges As System.Windows.Forms.ComboBox
    Friend WithEvents lblAddLess As System.Windows.Forms.Label
    Friend WithEvents txtrateOn As System.Windows.Forms.TextBox
    Friend WithEvents txtAccount As System.Windows.Forms.TextBox
    Friend WithEvents lblAccount As System.Windows.Forms.Label

End Class

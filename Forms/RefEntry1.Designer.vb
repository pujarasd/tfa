<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RefEntry
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.lblAdjAmt = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblAdjDrcr = New System.Windows.Forms.Label
        Me.cmbRefType = New System.Windows.Forms.ComboBox
        Me.cmbRefNo = New System.Windows.Forms.ComboBox
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.pnlEntry = New System.Windows.Forms.Panel
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.lblType = New System.Windows.Forms.Label
        Me.lblAmount = New System.Windows.Forms.Label
        Me.lblRefNo = New System.Windows.Forms.Label
        Me.lblRefType = New System.Windows.Forms.Label
        Me.NumAmount = New Account.NumTextBox
        Me.NumUnAdjusted = New Account.NumTextBox
        Me.numAdjusted = New Account.NumTextBox
        Me.NumAdjAmt = New Account.NumTextBox
        Me.dgv = New Account.DataGridViewEnter
        Me.Bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlEntry.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(565, 274)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
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
        'lblAdjAmt
        '
        Me.lblAdjAmt.AutoSize = True
        Me.lblAdjAmt.Location = New System.Drawing.Point(12, 7)
        Me.lblAdjAmt.Name = "lblAdjAmt"
        Me.lblAdjAmt.Size = New System.Drawing.Size(106, 13)
        Me.lblAdjAmt.TabIndex = 3
        Me.lblAdjAmt.Text = "Amount To be Adjust"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 283)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Amount Adjusted"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(283, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "UnAdjusted Amount"
        '
        'lblAdjDrcr
        '
        Me.lblAdjDrcr.AutoSize = True
        Me.lblAdjDrcr.Location = New System.Drawing.Point(230, 7)
        Me.lblAdjDrcr.Name = "lblAdjDrcr"
        Me.lblAdjDrcr.Size = New System.Drawing.Size(18, 13)
        Me.lblAdjDrcr.TabIndex = 8
        Me.lblAdjDrcr.Text = "Dr"
        '
        'cmbRefType
        '
        Me.cmbRefType.FormattingEnabled = True
        Me.cmbRefType.Items.AddRange(New Object() {"Against", "New", "Advance", "OnAcct"})
        Me.cmbRefType.Location = New System.Drawing.Point(3, 29)
        Me.cmbRefType.Name = "cmbRefType"
        Me.cmbRefType.Size = New System.Drawing.Size(89, 21)
        Me.cmbRefType.TabIndex = 9
        '
        'cmbRefNo
        '
        Me.cmbRefNo.FormattingEnabled = True
        Me.cmbRefNo.Location = New System.Drawing.Point(100, 29)
        Me.cmbRefNo.Name = "cmbRefNo"
        Me.cmbRefNo.Size = New System.Drawing.Size(367, 21)
        Me.cmbRefNo.TabIndex = 10
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Dr", "Cr"})
        Me.cmbType.Location = New System.Drawing.Point(579, 29)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(54, 21)
        Me.cmbType.TabIndex = 9
        '
        'pnlEntry
        '
        Me.pnlEntry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlEntry.Controls.Add(Me.btnCancel)
        Me.pnlEntry.Controls.Add(Me.btnSave)
        Me.pnlEntry.Controls.Add(Me.lblType)
        Me.pnlEntry.Controls.Add(Me.lblAmount)
        Me.pnlEntry.Controls.Add(Me.lblRefNo)
        Me.pnlEntry.Controls.Add(Me.lblRefType)
        Me.pnlEntry.Controls.Add(Me.NumAmount)
        Me.pnlEntry.Controls.Add(Me.cmbRefNo)
        Me.pnlEntry.Controls.Add(Me.cmbType)
        Me.pnlEntry.Controls.Add(Me.cmbRefType)
        Me.pnlEntry.Location = New System.Drawing.Point(9, 30)
        Me.pnlEntry.Name = "pnlEntry"
        Me.pnlEntry.Size = New System.Drawing.Size(701, 57)
        Me.pnlEntry.TabIndex = 12
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(643, 29)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(51, 23)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(642, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 23)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "&Add"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(584, 10)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(33, 13)
        Me.lblType.TabIndex = 12
        Me.lblType.Text = "Dr/Cr"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(500, 10)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(43, 13)
        Me.lblAmount.TabIndex = 12
        Me.lblAmount.Text = "Amount"
        '
        'lblRefNo
        '
        Me.lblRefNo.AutoSize = True
        Me.lblRefNo.Location = New System.Drawing.Point(221, 10)
        Me.lblRefNo.Name = "lblRefNo"
        Me.lblRefNo.Size = New System.Drawing.Size(47, 13)
        Me.lblRefNo.TabIndex = 12
        Me.lblRefNo.Text = "Ref. No."
        '
        'lblRefType
        '
        Me.lblRefType.AutoSize = True
        Me.lblRefType.Location = New System.Drawing.Point(15, 10)
        Me.lblRefType.Name = "lblRefType"
        Me.lblRefType.Size = New System.Drawing.Size(54, 13)
        Me.lblRefType.TabIndex = 12
        Me.lblRefType.Text = "Ref. Type"
        '
        'NumAmount
        '
        Me.NumAmount.dec = CType(2, Short)
        Me.NumAmount.format = Nothing
        Me.NumAmount.Location = New System.Drawing.Point(473, 30)
        Me.NumAmount.Name = "NumAmount"
        Me.NumAmount.Size = New System.Drawing.Size(100, 20)
        Me.NumAmount.TabIndex = 11
        Me.NumAmount.Text = "0.00"
        Me.NumAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumAmount.value = 0
        '
        'NumUnAdjusted
        '
        Me.NumUnAdjusted.dec = CType(2, Short)
        Me.NumUnAdjusted.format = "{0:N2}"
        Me.NumUnAdjusted.Location = New System.Drawing.Point(395, 280)
        Me.NumUnAdjusted.Name = "NumUnAdjusted"
        Me.NumUnAdjusted.ReadOnly = True
        Me.NumUnAdjusted.Size = New System.Drawing.Size(100, 20)
        Me.NumUnAdjusted.TabIndex = 6
        Me.NumUnAdjusted.TabStop = False
        Me.NumUnAdjusted.Text = "0.00"
        Me.NumUnAdjusted.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumUnAdjusted.value = 0
        '
        'numAdjusted
        '
        Me.numAdjusted.dec = CType(2, Short)
        Me.numAdjusted.format = "{0:N2}"
        Me.numAdjusted.Location = New System.Drawing.Point(123, 280)
        Me.numAdjusted.Name = "numAdjusted"
        Me.numAdjusted.ReadOnly = True
        Me.numAdjusted.Size = New System.Drawing.Size(100, 20)
        Me.numAdjusted.TabIndex = 4
        Me.numAdjusted.TabStop = False
        Me.numAdjusted.Text = "0.00"
        Me.numAdjusted.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numAdjusted.value = 0
        '
        'NumAdjAmt
        '
        Me.NumAdjAmt.dec = CType(2, Short)
        Me.NumAdjAmt.format = "{0:N2}"
        Me.NumAdjAmt.Location = New System.Drawing.Point(124, 4)
        Me.NumAdjAmt.Name = "NumAdjAmt"
        Me.NumAdjAmt.ReadOnly = True
        Me.NumAdjAmt.Size = New System.Drawing.Size(100, 20)
        Me.NumAdjAmt.TabIndex = 2
        Me.NumAdjAmt.TabStop = False
        Me.NumAdjAmt.Text = "0.00"
        Me.NumAdjAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumAdjAmt.value = 0
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 93)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(699, 178)
        Me.dgv.TabIndex = 1
        '
        'RefEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 315)
        Me.Controls.Add(Me.pnlEntry)
        Me.Controls.Add(Me.lblAdjDrcr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumUnAdjusted)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numAdjusted)
        Me.Controls.Add(Me.lblAdjAmt)
        Me.Controls.Add(Me.NumAdjAmt)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RefEntry"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RefEntry"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pnlEntry.ResumeLayout(False)
        Me.pnlEntry.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents dgv As Account.DataGridViewEnter
    Friend WithEvents Bs As System.Windows.Forms.BindingSource
    Friend WithEvents NumAdjAmt As Account.NumTextBox
    Friend WithEvents lblAdjAmt As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents numAdjusted As Account.NumTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumUnAdjusted As Account.NumTextBox
    Friend WithEvents lblAdjDrcr As System.Windows.Forms.Label
    Friend WithEvents cmbRefType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRefNo As System.Windows.Forms.ComboBox
    Friend WithEvents NumAmount As Account.NumTextBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents pnlEntry As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lblRefNo As System.Windows.Forms.Label
    Friend WithEvents lblRefType As System.Windows.Forms.Label

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransChallanItem
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
        Me.txtContent = New System.Windows.Forms.TextBox
        Me.lblContent = New System.Windows.Forms.Label
        Me.lblBags = New System.Windows.Forms.Label
        Me.lblRemark = New System.Windows.Forms.Label
        Me.txtRemark = New System.Windows.Forms.TextBox
        Me.lblRate = New System.Windows.Forms.Label
        Me.lblWDiff = New System.Windows.Forms.Label
        Me.lblweight = New System.Windows.Forms.Label
        Me.lblAmt = New System.Windows.Forms.Label
        Me.lblRdiff = New System.Windows.Forms.Label
        Me.lblAdiff = New System.Windows.Forms.Label
        Me.ntxtWdiff = New Account.NumTextBox
        Me.ntxtRdiff = New Account.NumTextBox
        Me.ntxtRate = New Account.NumTextBox
        Me.ntxtAdiff = New Account.NumTextBox
        Me.ntxtAmount = New Account.NumTextBox
        Me.ntxtWeight = New Account.NumTextBox
        Me.ntxtbags = New Account.NumTextBox
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(403, 132)
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
        'txtContent
        '
        Me.txtContent.Location = New System.Drawing.Point(94, 23)
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(269, 20)
        Me.txtContent.TabIndex = 1
        '
        'lblContent
        '
        Me.lblContent.AutoSize = True
        Me.lblContent.Location = New System.Drawing.Point(16, 26)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Size = New System.Drawing.Size(44, 13)
        Me.lblContent.TabIndex = 0
        Me.lblContent.Text = "Content"
        '
        'lblBags
        '
        Me.lblBags.AutoSize = True
        Me.lblBags.Location = New System.Drawing.Point(369, 26)
        Me.lblBags.Name = "lblBags"
        Me.lblBags.Size = New System.Drawing.Size(50, 13)
        Me.lblBags.TabIndex = 2
        Me.lblBags.Text = "Package"
        '
        'lblRemark
        '
        Me.lblRemark.AutoSize = True
        Me.lblRemark.Location = New System.Drawing.Point(16, 106)
        Me.lblRemark.Name = "lblRemark"
        Me.lblRemark.Size = New System.Drawing.Size(44, 13)
        Me.lblRemark.TabIndex = 16
        Me.lblRemark.Text = "Remark"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(94, 103)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(452, 20)
        Me.txtRemark.TabIndex = 17
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(205, 56)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(30, 13)
        Me.lblRate.TabIndex = 6
        Me.lblRate.Text = "Rate"
        '
        'lblWDiff
        '
        Me.lblWDiff.AutoSize = True
        Me.lblWDiff.Location = New System.Drawing.Point(16, 81)
        Me.lblWDiff.Name = "lblWDiff"
        Me.lblWDiff.Size = New System.Drawing.Size(62, 13)
        Me.lblWDiff.TabIndex = 10
        Me.lblWDiff.Text = "RV Weight "
        '
        'lblweight
        '
        Me.lblweight.AutoSize = True
        Me.lblweight.Location = New System.Drawing.Point(16, 55)
        Me.lblweight.Name = "lblweight"
        Me.lblweight.Size = New System.Drawing.Size(41, 13)
        Me.lblweight.TabIndex = 4
        Me.lblweight.Text = "Weight"
        '
        'lblAmt
        '
        Me.lblAmt.AutoSize = True
        Me.lblAmt.Location = New System.Drawing.Point(369, 56)
        Me.lblAmt.Name = "lblAmt"
        Me.lblAmt.Size = New System.Drawing.Size(43, 13)
        Me.lblAmt.TabIndex = 8
        Me.lblAmt.Text = "Amount"
        '
        'lblRdiff
        '
        Me.lblRdiff.AutoSize = True
        Me.lblRdiff.Location = New System.Drawing.Point(205, 84)
        Me.lblRdiff.Name = "lblRdiff"
        Me.lblRdiff.Size = New System.Drawing.Size(51, 13)
        Me.lblRdiff.TabIndex = 12
        Me.lblRdiff.Text = "RV Rate "
        '
        'lblAdiff
        '
        Me.lblAdiff.AutoSize = True
        Me.lblAdiff.Location = New System.Drawing.Point(369, 80)
        Me.lblAdiff.Name = "lblAdiff"
        Me.lblAdiff.Size = New System.Drawing.Size(64, 13)
        Me.lblAdiff.TabIndex = 14
        Me.lblAdiff.Text = "RV Amount "
        '
        'ntxtWdiff
        '
        Me.ntxtWdiff.dec = CType(2, Short)
        Me.ntxtWdiff.Location = New System.Drawing.Point(94, 78)
        Me.ntxtWdiff.Name = "ntxtWdiff"
        Me.ntxtWdiff.Size = New System.Drawing.Size(100, 20)
        Me.ntxtWdiff.TabIndex = 11
        Me.ntxtWdiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtWdiff.value = 0
        '
        'ntxtRdiff
        '
        Me.ntxtRdiff.dec = CType(2, Short)
        Me.ntxtRdiff.Location = New System.Drawing.Point(263, 78)
        Me.ntxtRdiff.Name = "ntxtRdiff"
        Me.ntxtRdiff.Size = New System.Drawing.Size(100, 20)
        Me.ntxtRdiff.TabIndex = 13
        Me.ntxtRdiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtRdiff.value = 0
        '
        'ntxtRate
        '
        Me.ntxtRate.dec = CType(2, Short)
        Me.ntxtRate.Location = New System.Drawing.Point(263, 52)
        Me.ntxtRate.Name = "ntxtRate"
        Me.ntxtRate.Size = New System.Drawing.Size(100, 20)
        Me.ntxtRate.TabIndex = 7
        Me.ntxtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtRate.value = 0
        '
        'ntxtAdiff
        '
        Me.ntxtAdiff.dec = CType(2, Short)
        Me.ntxtAdiff.Location = New System.Drawing.Point(446, 80)
        Me.ntxtAdiff.Name = "ntxtAdiff"
        Me.ntxtAdiff.ReadOnly = True
        Me.ntxtAdiff.Size = New System.Drawing.Size(100, 20)
        Me.ntxtAdiff.TabIndex = 15
        Me.ntxtAdiff.TabStop = False
        Me.ntxtAdiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtAdiff.value = 0
        '
        'ntxtAmount
        '
        Me.ntxtAmount.dec = CType(2, Short)
        Me.ntxtAmount.Location = New System.Drawing.Point(446, 52)
        Me.ntxtAmount.Name = "ntxtAmount"
        Me.ntxtAmount.ReadOnly = True
        Me.ntxtAmount.Size = New System.Drawing.Size(100, 20)
        Me.ntxtAmount.TabIndex = 9
        Me.ntxtAmount.TabStop = False
        Me.ntxtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtAmount.value = 0
        '
        'ntxtWeight
        '
        Me.ntxtWeight.dec = CType(2, Short)
        Me.ntxtWeight.Location = New System.Drawing.Point(94, 52)
        Me.ntxtWeight.Name = "ntxtWeight"
        Me.ntxtWeight.Size = New System.Drawing.Size(100, 20)
        Me.ntxtWeight.TabIndex = 5
        Me.ntxtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtWeight.value = 0
        '
        'ntxtbags
        '
        Me.ntxtbags.dec = CType(0, Short)
        Me.ntxtbags.Location = New System.Drawing.Point(446, 23)
        Me.ntxtbags.Name = "ntxtbags"
        Me.ntxtbags.Size = New System.Drawing.Size(100, 20)
        Me.ntxtbags.TabIndex = 3
        Me.ntxtbags.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ntxtbags.value = 0
        '
        'TransChallanItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 173)
        Me.Controls.Add(Me.ntxtWdiff)
        Me.Controls.Add(Me.ntxtRdiff)
        Me.Controls.Add(Me.ntxtRate)
        Me.Controls.Add(Me.ntxtAdiff)
        Me.Controls.Add(Me.ntxtAmount)
        Me.Controls.Add(Me.lblWDiff)
        Me.Controls.Add(Me.ntxtWeight)
        Me.Controls.Add(Me.lblAdiff)
        Me.Controls.Add(Me.lblAmt)
        Me.Controls.Add(Me.lblRdiff)
        Me.Controls.Add(Me.ntxtbags)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblweight)
        Me.Controls.Add(Me.lblBags)
        Me.Controls.Add(Me.lblContent)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.lblRemark)
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TransChallanItem"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Items"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents lblContent As System.Windows.Forms.Label
    Friend WithEvents ntxtbags As Account.NumTextBox
    Friend WithEvents lblBags As System.Windows.Forms.Label
    Friend WithEvents lblRemark As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents ntxtAmount As Account.NumTextBox
    Friend WithEvents ntxtRate As Account.NumTextBox
    Friend WithEvents lblWDiff As System.Windows.Forms.Label
    Friend WithEvents ntxtWdiff As Account.NumTextBox
    Friend WithEvents lblweight As System.Windows.Forms.Label
    Friend WithEvents lblAmt As System.Windows.Forms.Label
    Friend WithEvents ntxtWeight As Account.NumTextBox
    Friend WithEvents ntxtAdiff As Account.NumTextBox
    Friend WithEvents ntxtRdiff As Account.NumTextBox
    Friend WithEvents lblRdiff As System.Windows.Forms.Label
    Friend WithEvents lblAdiff As System.Windows.Forms.Label

End Class

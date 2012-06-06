<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportLedger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportLedger))
        Me.chkConsole = New System.Windows.Forms.CheckBox
        Me.cboSelect = New System.Windows.Forms.ComboBox
        Me.btnOk = New System.Windows.Forms.Button
        Me.dtpTo = New System.Windows.Forms.DateTimePicker
        Me.btnCancel = New System.Windows.Forms.Button
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker
        Me.lbldtfrom = New System.Windows.Forms.Label
        Me.lbldateto = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'chkConsole
        '
        Me.chkConsole.AutoSize = True
        Me.chkConsole.ForeColor = System.Drawing.Color.Blue
        Me.chkConsole.Location = New System.Drawing.Point(9, 94)
        Me.chkConsole.Name = "chkConsole"
        Me.chkConsole.Size = New System.Drawing.Size(87, 17)
        Me.chkConsole.TabIndex = 4
        Me.chkConsole.Text = "Consolidated"
        Me.chkConsole.UseVisualStyleBackColor = True
        '
        'cboSelect
        '
        Me.cboSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSelect.FormattingEnabled = True
        Me.cboSelect.ItemHeight = 13
        Me.cboSelect.Location = New System.Drawing.Point(9, 26)
        Me.cboSelect.Name = "cboSelect"
        Me.cboSelect.Size = New System.Drawing.Size(269, 21)
        Me.cboSelect.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.Image = Global.Account.My.Resources.Resources.OK
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOk.Location = New System.Drawing.Point(131, 94)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(70, 38)
        Me.btnOk.TabIndex = 5
        Me.btnOk.Text = "&OK"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(199, 60)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(78, 20)
        Me.dtpTo.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.Account.My.Resources.Resources.cancel
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancel.Location = New System.Drawing.Point(207, 94)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(70, 38)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(63, 60)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(78, 20)
        Me.dtpFrom.TabIndex = 2
        '
        'lbldtfrom
        '
        Me.lbldtfrom.Location = New System.Drawing.Point(6, 62)
        Me.lbldtfrom.Name = "lbldtfrom"
        Me.lbldtfrom.Size = New System.Drawing.Size(56, 13)
        Me.lbldtfrom.TabIndex = 9
        Me.lbldtfrom.Text = "Date From"
        '
        'lbldateto
        '
        Me.lbldateto.AutoSize = True
        Me.lbldateto.Location = New System.Drawing.Point(147, 63)
        Me.lbldateto.Name = "lbldateto"
        Me.lbldateto.Size = New System.Drawing.Size(46, 13)
        Me.lbldateto.TabIndex = 10
        Me.lbldateto.Text = "Date To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Select Ledger "
        '
        'FrmReportLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 138)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkConsole)
        Me.Controls.Add(Me.cboSelect)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.lbldtfrom)
        Me.Controls.Add(Me.lbldateto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReportLedger"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmReportLedger"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkConsole As System.Windows.Forms.CheckBox
    Friend WithEvents cboSelect As System.Windows.Forms.ComboBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldtfrom As System.Windows.Forms.Label
    Friend WithEvents lbldateto As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReport))
        Me.grpReportwise = New System.Windows.Forms.GroupBox
        Me.rbChallanwise = New System.Windows.Forms.RadioButton
        Me.rbTransportwise = New System.Windows.Forms.RadioButton
        Me.rbPartywise = New System.Windows.Forms.RadioButton
        Me.rbDatewise = New System.Windows.Forms.RadioButton
        Me.grpDetailSummary = New System.Windows.Forms.GroupBox
        Me.rdbSummary = New System.Windows.Forms.RadioButton
        Me.rdbDetail = New System.Windows.Forms.RadioButton
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.grpRange = New System.Windows.Forms.GroupBox
        Me.dtpTo = New System.Windows.Forms.DateTimePicker
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker
        Me.lbldtfrom = New System.Windows.Forms.Label
        Me.lbldateto = New System.Windows.Forms.Label
        Me.lblnoFrom = New System.Windows.Forms.Label
        Me.lblnoto = New System.Windows.Forms.Label
        Me.cboSelect = New System.Windows.Forms.ComboBox
        Me.chkConsole = New System.Windows.Forms.CheckBox
        Me.txtNoto = New Account.NumTextBox
        Me.txtNofrom = New Account.NumTextBox
        Me.grpReportwise.SuspendLayout()
        Me.grpDetailSummary.SuspendLayout()
        Me.grpRange.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpReportwise
        '
        Me.grpReportwise.Controls.Add(Me.rbChallanwise)
        Me.grpReportwise.Controls.Add(Me.rbTransportwise)
        Me.grpReportwise.Controls.Add(Me.rbPartywise)
        Me.grpReportwise.Controls.Add(Me.rbDatewise)
        Me.grpReportwise.Location = New System.Drawing.Point(4, 0)
        Me.grpReportwise.Name = "grpReportwise"
        Me.grpReportwise.Size = New System.Drawing.Size(121, 136)
        Me.grpReportwise.TabIndex = 0
        Me.grpReportwise.TabStop = False
        '
        'rbChallanwise
        '
        Me.rbChallanwise.AutoSize = True
        Me.rbChallanwise.Location = New System.Drawing.Point(6, 108)
        Me.rbChallanwise.Name = "rbChallanwise"
        Me.rbChallanwise.Size = New System.Drawing.Size(107, 17)
        Me.rbChallanwise.TabIndex = 3
        Me.rbChallanwise.TabStop = True
        Me.rbChallanwise.Text = "Challan No. Wise"
        Me.rbChallanwise.UseVisualStyleBackColor = True
        '
        'rbTransportwise
        '
        Me.rbTransportwise.AutoSize = True
        Me.rbTransportwise.Location = New System.Drawing.Point(6, 76)
        Me.rbTransportwise.Name = "rbTransportwise"
        Me.rbTransportwise.Size = New System.Drawing.Size(106, 17)
        Me.rbTransportwise.TabIndex = 2
        Me.rbTransportwise.TabStop = True
        Me.rbTransportwise.Text = "Transporter Wise"
        Me.rbTransportwise.UseVisualStyleBackColor = True
        '
        'rbPartywise
        '
        Me.rbPartywise.AutoSize = True
        Me.rbPartywise.Location = New System.Drawing.Point(6, 44)
        Me.rbPartywise.Name = "rbPartywise"
        Me.rbPartywise.Size = New System.Drawing.Size(96, 17)
        Me.rbPartywise.TabIndex = 1
        Me.rbPartywise.TabStop = True
        Me.rbPartywise.Text = "Customer Wise"
        Me.rbPartywise.UseVisualStyleBackColor = True
        '
        'rbDatewise
        '
        Me.rbDatewise.AutoSize = True
        Me.rbDatewise.Location = New System.Drawing.Point(6, 12)
        Me.rbDatewise.Name = "rbDatewise"
        Me.rbDatewise.Size = New System.Drawing.Size(75, 17)
        Me.rbDatewise.TabIndex = 0
        Me.rbDatewise.TabStop = True
        Me.rbDatewise.Text = "Date Wise"
        Me.rbDatewise.UseVisualStyleBackColor = True
        '
        'grpDetailSummary
        '
        Me.grpDetailSummary.Controls.Add(Me.rdbSummary)
        Me.grpDetailSummary.Controls.Add(Me.rdbDetail)
        Me.grpDetailSummary.Location = New System.Drawing.Point(127, 70)
        Me.grpDetailSummary.Name = "grpDetailSummary"
        Me.grpDetailSummary.Size = New System.Drawing.Size(104, 68)
        Me.grpDetailSummary.TabIndex = 1
        Me.grpDetailSummary.TabStop = False
        '
        'rdbSummary
        '
        Me.rdbSummary.AutoSize = True
        Me.rdbSummary.Location = New System.Drawing.Point(4, 37)
        Me.rdbSummary.Name = "rdbSummary"
        Me.rdbSummary.Size = New System.Drawing.Size(68, 17)
        Me.rdbSummary.TabIndex = 1
        Me.rdbSummary.TabStop = True
        Me.rdbSummary.Text = "Summary"
        Me.rdbSummary.UseVisualStyleBackColor = True
        '
        'rdbDetail
        '
        Me.rdbDetail.AutoSize = True
        Me.rdbDetail.Location = New System.Drawing.Point(4, 11)
        Me.rdbDetail.Name = "rdbDetail"
        Me.rdbDetail.Size = New System.Drawing.Size(57, 17)
        Me.rdbDetail.TabIndex = 0
        Me.rdbDetail.TabStop = True
        Me.rdbDetail.Text = "Details"
        Me.rdbDetail.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Image = Global.Account.My.Resources.Resources.OK
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOk.Location = New System.Drawing.Point(247, 98)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(70, 38)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "&OK"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.Account.My.Resources.Resources.Back
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancel.Location = New System.Drawing.Point(322, 98)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(70, 38)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'grpRange
        '
        Me.grpRange.Controls.Add(Me.txtNoto)
        Me.grpRange.Controls.Add(Me.txtNofrom)
        Me.grpRange.Controls.Add(Me.dtpTo)
        Me.grpRange.Controls.Add(Me.dtpFrom)
        Me.grpRange.Controls.Add(Me.lbldtfrom)
        Me.grpRange.Controls.Add(Me.lbldateto)
        Me.grpRange.Controls.Add(Me.lblnoFrom)
        Me.grpRange.Controls.Add(Me.lblnoto)
        Me.grpRange.Location = New System.Drawing.Point(127, 1)
        Me.grpRange.Name = "grpRange"
        Me.grpRange.Size = New System.Drawing.Size(265, 40)
        Me.grpRange.TabIndex = 4
        Me.grpRange.TabStop = False
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(181, 12)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(78, 20)
        Me.dtpTo.TabIndex = 3
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(57, 12)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(78, 20)
        Me.dtpFrom.TabIndex = 2
        '
        'lbldtfrom
        '
        Me.lbldtfrom.AutoSize = True
        Me.lbldtfrom.Location = New System.Drawing.Point(1, 14)
        Me.lbldtfrom.Name = "lbldtfrom"
        Me.lbldtfrom.Size = New System.Drawing.Size(56, 13)
        Me.lbldtfrom.TabIndex = 0
        Me.lbldtfrom.Text = "Date From"
        '
        'lbldateto
        '
        Me.lbldateto.AutoSize = True
        Me.lbldateto.Location = New System.Drawing.Point(135, 15)
        Me.lbldateto.Name = "lbldateto"
        Me.lbldateto.Size = New System.Drawing.Size(46, 13)
        Me.lbldateto.TabIndex = 1
        Me.lbldateto.Text = "Date To"
        '
        'lblnoFrom
        '
        Me.lblnoFrom.AutoSize = True
        Me.lblnoFrom.Location = New System.Drawing.Point(4, 15)
        Me.lblnoFrom.Name = "lblnoFrom"
        Me.lblnoFrom.Size = New System.Drawing.Size(50, 13)
        Me.lblnoFrom.TabIndex = 4
        Me.lblnoFrom.Text = "No. From"
        Me.lblnoFrom.Visible = False
        '
        'lblnoto
        '
        Me.lblnoto.AutoSize = True
        Me.lblnoto.Location = New System.Drawing.Point(137, 15)
        Me.lblnoto.Name = "lblnoto"
        Me.lblnoto.Size = New System.Drawing.Size(40, 13)
        Me.lblnoto.TabIndex = 5
        Me.lblnoto.Text = "No. To"
        Me.lblnoto.Visible = False
        '
        'cboSelect
        '
        Me.cboSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSelect.FormattingEnabled = True
        Me.cboSelect.Location = New System.Drawing.Point(127, 49)
        Me.cboSelect.Name = "cboSelect"
        Me.cboSelect.Size = New System.Drawing.Size(265, 21)
        Me.cboSelect.TabIndex = 5
        '
        'chkConsole
        '
        Me.chkConsole.AutoSize = True
        Me.chkConsole.ForeColor = System.Drawing.Color.Blue
        Me.chkConsole.Location = New System.Drawing.Point(247, 76)
        Me.chkConsole.Name = "chkConsole"
        Me.chkConsole.Size = New System.Drawing.Size(87, 17)
        Me.chkConsole.TabIndex = 8
        Me.chkConsole.Text = "Consolidated"
        Me.chkConsole.UseVisualStyleBackColor = True
        '
        'txtNoto
        '
        Me.txtNoto.dec = CType(0, Short)
        Me.txtNoto.format = Nothing
        Me.txtNoto.Location = New System.Drawing.Point(182, 11)
        Me.txtNoto.Name = "txtNoto"
        Me.txtNoto.Size = New System.Drawing.Size(45, 20)
        Me.txtNoto.TabIndex = 8
        Me.txtNoto.Text = "0"
        Me.txtNoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNoto.value = 0
        Me.txtNoto.Visible = False
        '
        'txtNofrom
        '
        Me.txtNofrom.dec = CType(0, Short)
        Me.txtNofrom.format = Nothing
        Me.txtNofrom.Location = New System.Drawing.Point(59, 12)
        Me.txtNofrom.Name = "txtNofrom"
        Me.txtNofrom.Size = New System.Drawing.Size(45, 20)
        Me.txtNofrom.TabIndex = 6
        Me.txtNofrom.Text = "0"
        Me.txtNofrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNofrom.value = 0
        Me.txtNofrom.Visible = False
        '
        'FrmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 149)
        Me.Controls.Add(Me.chkConsole)
        Me.Controls.Add(Me.cboSelect)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.grpDetailSummary)
        Me.Controls.Add(Me.grpReportwise)
        Me.Controls.Add(Me.grpRange)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.grpReportwise.ResumeLayout(False)
        Me.grpReportwise.PerformLayout()
        Me.grpDetailSummary.ResumeLayout(False)
        Me.grpDetailSummary.PerformLayout()
        Me.grpRange.ResumeLayout(False)
        Me.grpRange.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpReportwise As System.Windows.Forms.GroupBox
    Friend WithEvents grpDetailSummary As System.Windows.Forms.GroupBox
    Friend WithEvents rbChallanwise As System.Windows.Forms.RadioButton
    Friend WithEvents rbTransportwise As System.Windows.Forms.RadioButton
    Friend WithEvents rbPartywise As System.Windows.Forms.RadioButton
    Friend WithEvents rbDatewise As System.Windows.Forms.RadioButton
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents rdbSummary As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDetail As System.Windows.Forms.RadioButton
    Friend WithEvents grpRange As System.Windows.Forms.GroupBox
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldateto As System.Windows.Forms.Label
    Friend WithEvents lbldtfrom As System.Windows.Forms.Label
    Friend WithEvents lblnoto As System.Windows.Forms.Label
    Friend WithEvents lblnoFrom As System.Windows.Forms.Label
    Friend WithEvents cboSelect As System.Windows.Forms.ComboBox
    Friend WithEvents txtNoto As Account.NumTextBox
    Friend WithEvents txtNofrom As Account.NumTextBox
    Friend WithEvents chkConsole As System.Windows.Forms.CheckBox
End Class

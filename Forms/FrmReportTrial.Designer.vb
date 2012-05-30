<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportTrial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportTrial))
        Me.lblAccount = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkConsole = New System.Windows.Forms.CheckBox
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.numBal = New Account.NumTextBox
        Me.numCredit = New Account.NumTextBox
        Me.numDebit = New Account.NumTextBox
        Me.dgv = New Account.DataGridViewEnter
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccount.Location = New System.Drawing.Point(9, 354)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(45, 13)
        Me.lblAccount.TabIndex = 3
        Me.lblAccount.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "As on Dated"
        '
        'chkConsole
        '
        Me.chkConsole.AutoSize = True
        Me.chkConsole.ForeColor = System.Drawing.Color.Blue
        Me.chkConsole.Location = New System.Drawing.Point(180, 9)
        Me.chkConsole.Name = "chkConsole"
        Me.chkConsole.Size = New System.Drawing.Size(87, 17)
        Me.chkConsole.TabIndex = 7
        Me.chkConsole.Text = "Consolidated"
        Me.chkConsole.UseVisualStyleBackColor = True
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(96, 7)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(78, 20)
        Me.dtpFrom.TabIndex = 6
        '
        'btnOk
        '
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOk.Location = New System.Drawing.Point(273, 6)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(64, 22)
        Me.btnOk.TabIndex = 11
        Me.btnOk.Text = "&Show"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(534, 6)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(64, 22)
        Me.btnPrint.TabIndex = 12
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'numBal
        '
        Me.numBal.dec = CType(2, Short)
        Me.numBal.format = Nothing
        Me.numBal.Location = New System.Drawing.Point(473, 351)
        Me.numBal.Name = "numBal"
        Me.numBal.ReadOnly = True
        Me.numBal.Size = New System.Drawing.Size(100, 20)
        Me.numBal.TabIndex = 10
        Me.numBal.TabStop = False
        Me.numBal.Text = "0.00"
        Me.numBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numBal.value = 0
        '
        'numCredit
        '
        Me.numCredit.dec = CType(2, Short)
        Me.numCredit.format = Nothing
        Me.numCredit.Location = New System.Drawing.Point(358, 351)
        Me.numCredit.Name = "numCredit"
        Me.numCredit.ReadOnly = True
        Me.numCredit.Size = New System.Drawing.Size(100, 20)
        Me.numCredit.TabIndex = 9
        Me.numCredit.TabStop = False
        Me.numCredit.Text = "0.00"
        Me.numCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numCredit.value = 0
        '
        'numDebit
        '
        Me.numDebit.dec = CType(2, Short)
        Me.numDebit.format = Nothing
        Me.numDebit.Location = New System.Drawing.Point(252, 351)
        Me.numDebit.Name = "numDebit"
        Me.numDebit.ReadOnly = True
        Me.numDebit.Size = New System.Drawing.Size(100, 20)
        Me.numDebit.TabIndex = 8
        Me.numDebit.TabStop = False
        Me.numDebit.Text = "0.00"
        Me.numDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numDebit.value = 0
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(6, 37)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(592, 304)
        Me.dgv.TabIndex = 2
        '
        'FrmReportTrial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 385)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.numBal)
        Me.Controls.Add(Me.numCredit)
        Me.Controls.Add(Me.numDebit)
        Me.Controls.Add(Me.chkConsole)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAccount)
        Me.Controls.Add(Me.dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReportTrial"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trial Balance"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As Account.DataGridViewEnter
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkConsole As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents numBal As Account.NumTextBox
    Friend WithEvents numCredit As Account.NumTextBox
    Friend WithEvents numDebit As Account.NumTextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button

End Class

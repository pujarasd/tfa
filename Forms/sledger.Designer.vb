<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sledger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sledger))
        Me.lblAccount = New System.Windows.Forms.Label
        Me.lblNarration = New System.Windows.Forms.Label
        Me.lblFrom = New System.Windows.Forms.Label
        Me.lblTo = New System.Windows.Forms.Label
        Me.lblacc = New System.Windows.Forms.Label
        Me.lblf = New System.Windows.Forms.Label
        Me.lblt = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblType = New System.Windows.Forms.Label
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
        Me.lblAccount.Location = New System.Drawing.Point(69, 9)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(45, 13)
        Me.lblAccount.TabIndex = 1
        Me.lblAccount.Text = "Label1"
        '
        'lblNarration
        '
        Me.lblNarration.AutoSize = True
        Me.lblNarration.Location = New System.Drawing.Point(9, 409)
        Me.lblNarration.Name = "lblNarration"
        Me.lblNarration.Size = New System.Drawing.Size(39, 13)
        Me.lblNarration.TabIndex = 1
        Me.lblNarration.Text = "Label1"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.Location = New System.Drawing.Point(69, 37)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(89, 13)
        Me.lblFrom.TabIndex = 1
        Me.lblFrom.Text = "DD/MM/YYYY"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.Location = New System.Drawing.Point(200, 37)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(89, 13)
        Me.lblTo.TabIndex = 1
        Me.lblTo.Text = "DD/MM/YYYY"
        '
        'lblacc
        '
        Me.lblacc.AutoSize = True
        Me.lblacc.Location = New System.Drawing.Point(13, 9)
        Me.lblacc.Name = "lblacc"
        Me.lblacc.Size = New System.Drawing.Size(50, 13)
        Me.lblacc.TabIndex = 1
        Me.lblacc.Text = "Account:"
        '
        'lblf
        '
        Me.lblf.AutoSize = True
        Me.lblf.Location = New System.Drawing.Point(13, 37)
        Me.lblf.Name = "lblf"
        Me.lblf.Size = New System.Drawing.Size(33, 13)
        Me.lblf.TabIndex = 1
        Me.lblf.Text = "From:"
        '
        'lblt
        '
        Me.lblt.AutoSize = True
        Me.lblt.Location = New System.Drawing.Point(154, 37)
        Me.lblt.Name = "lblt"
        Me.lblt.Size = New System.Drawing.Size(23, 13)
        Me.lblt.TabIndex = 1
        Me.lblt.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 377)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Debit Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 377)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Credit Total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(453, 377)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Balance"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(637, 377)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(21, 13)
        Me.lblType.TabIndex = 1
        Me.lblType.Text = "Dr."
        '
        'numBal
        '
        Me.numBal.dec = CType(2, Short)
        Me.numBal.format = Nothing
        Me.numBal.Location = New System.Drawing.Point(531, 374)
        Me.numBal.Name = "numBal"
        Me.numBal.ReadOnly = True
        Me.numBal.Size = New System.Drawing.Size(100, 20)
        Me.numBal.TabIndex = 2
        Me.numBal.TabStop = False
        Me.numBal.Text = "0.00"
        Me.numBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numBal.value = 0
        '
        'numCredit
        '
        Me.numCredit.dec = CType(2, Short)
        Me.numCredit.format = Nothing
        Me.numCredit.Location = New System.Drawing.Point(306, 374)
        Me.numCredit.Name = "numCredit"
        Me.numCredit.ReadOnly = True
        Me.numCredit.Size = New System.Drawing.Size(100, 20)
        Me.numCredit.TabIndex = 2
        Me.numCredit.TabStop = False
        Me.numCredit.Text = "0.00"
        Me.numCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numCredit.value = 0
        '
        'numDebit
        '
        Me.numDebit.dec = CType(2, Short)
        Me.numDebit.format = Nothing
        Me.numDebit.Location = New System.Drawing.Point(86, 374)
        Me.numDebit.Name = "numDebit"
        Me.numDebit.ReadOnly = True
        Me.numDebit.Size = New System.Drawing.Size(100, 20)
        Me.numDebit.TabIndex = 2
        Me.numDebit.TabStop = False
        Me.numDebit.Text = "0.00"
        Me.numDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numDebit.value = 0
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 55)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(650, 315)
        Me.dgv.TabIndex = 0
        '
        'sledger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 431)
        Me.Controls.Add(Me.numBal)
        Me.Controls.Add(Me.numCredit)
        Me.Controls.Add(Me.numDebit)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNarration)
        Me.Controls.Add(Me.lblt)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblf)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.lblacc)
        Me.Controls.Add(Me.lblAccount)
        Me.Controls.Add(Me.dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sledger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As Account.DataGridViewEnter
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents lblNarration As System.Windows.Forms.Label
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents lblacc As System.Windows.Forms.Label
    Friend WithEvents lblf As System.Windows.Forms.Label
    Friend WithEvents lblt As System.Windows.Forms.Label
    Friend WithEvents numDebit As Account.NumTextBox
    Friend WithEvents numCredit As Account.NumTextBox
    Friend WithEvents numBal As Account.NumTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
End Class

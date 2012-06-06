<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mCharges
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mCharges))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.lblRateon = New System.Windows.Forms.Label
        Me.lblLedger = New System.Windows.Forms.Label
        Me.lblCharge = New System.Windows.Forms.Label
        Me.cboRateon = New System.Windows.Forms.ComboBox
        Me.cboLedger = New System.Windows.Forms.ComboBox
        Me.txtCharges = New System.Windows.Forms.TextBox
        Me.lblRate = New System.Windows.Forms.Label
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.Ep1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Ep1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmdOk, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdCancel, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(155, 104)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 32)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdOk.Image = Global.Account.My.Resources.Resources.Save
        Me.cmdOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdOk.Location = New System.Drawing.Point(3, 3)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(67, 26)
        Me.cmdOk.TabIndex = 0
        Me.cmdOk.Text = "&Save"
        Me.cmdOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Image = Global.Account.My.Resources.Resources.cancel
        Me.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancel.Location = New System.Drawing.Point(76, 3)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(67, 26)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRateon
        '
        Me.lblRateon.AutoSize = True
        Me.lblRateon.Location = New System.Drawing.Point(4, 78)
        Me.lblRateon.Name = "lblRateon"
        Me.lblRateon.Size = New System.Drawing.Size(45, 13)
        Me.lblRateon.TabIndex = 11
        Me.lblRateon.Text = "Rate on"
        '
        'lblLedger
        '
        Me.lblLedger.AutoSize = True
        Me.lblLedger.Location = New System.Drawing.Point(4, 47)
        Me.lblLedger.Name = "lblLedger"
        Me.lblLedger.Size = New System.Drawing.Size(61, 13)
        Me.lblLedger.TabIndex = 10
        Me.lblLedger.Text = "Ledger A/c"
        '
        'lblCharge
        '
        Me.lblCharge.AutoSize = True
        Me.lblCharge.Location = New System.Drawing.Point(4, 14)
        Me.lblCharge.Name = "lblCharge"
        Me.lblCharge.Size = New System.Drawing.Size(41, 13)
        Me.lblCharge.TabIndex = 9
        Me.lblCharge.Text = "Charge"
        '
        'cboRateon
        '
        Me.cboRateon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRateon.FormattingEnabled = True
        Me.cboRateon.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cboRateon.Location = New System.Drawing.Point(70, 75)
        Me.cboRateon.Name = "cboRateon"
        Me.cboRateon.Size = New System.Drawing.Size(102, 21)
        Me.cboRateon.TabIndex = 5
        '
        'cboLedger
        '
        Me.cboLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLedger.FormattingEnabled = True
        Me.cboLedger.Location = New System.Drawing.Point(69, 44)
        Me.cboLedger.Name = "cboLedger"
        Me.cboLedger.Size = New System.Drawing.Size(233, 21)
        Me.cboLedger.TabIndex = 4
        '
        'txtCharges
        '
        Me.txtCharges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCharges.Location = New System.Drawing.Point(70, 11)
        Me.txtCharges.Name = "txtCharges"
        Me.txtCharges.Size = New System.Drawing.Size(231, 20)
        Me.txtCharges.TabIndex = 3
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(179, 78)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(30, 13)
        Me.lblRate.TabIndex = 15
        Me.lblRate.Text = "Rate"
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(213, 75)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(88, 20)
        Me.txtRate.TabIndex = 6
        '
        'Ep1
        '
        Me.Ep1.ContainerControl = Me
        '
        'mCharges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 139)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.cboRateon)
        Me.Controls.Add(Me.cboLedger)
        Me.Controls.Add(Me.txtCharges)
        Me.Controls.Add(Me.lblRateon)
        Me.Controls.Add(Me.lblLedger)
        Me.Controls.Add(Me.lblCharge)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mCharges"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Charges Master"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Ep1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents lblRateon As System.Windows.Forms.Label
    Friend WithEvents lblLedger As System.Windows.Forms.Label
    Friend WithEvents lblCharge As System.Windows.Forms.Label
    Friend WithEvents cboRateon As System.Windows.Forms.ComboBox
    Friend WithEvents cboLedger As System.Windows.Forms.ComboBox
    Friend WithEvents txtCharges As System.Windows.Forms.TextBox
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents Ep1 As System.Windows.Forms.ErrorProvider

End Class

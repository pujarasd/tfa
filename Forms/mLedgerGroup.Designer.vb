<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LedgerGroup
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LedgerGroup))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.lblGroup = New System.Windows.Forms.Label
        Me.Ep1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblUnderGroup = New System.Windows.Forms.Label
        Me.cboState = New System.Windows.Forms.ComboBox
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(165, 73)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 37)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdOk.Image = Global.Account.My.Resources.Resources.Save
        Me.cmdOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdOk.Location = New System.Drawing.Point(3, 6)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(67, 25)
        Me.cmdOk.TabIndex = 3
        Me.cmdOk.Text = "&Save"
        Me.cmdOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Image = Global.Account.My.Resources.Resources.cancel
        Me.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancel.Location = New System.Drawing.Point(76, 6)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(67, 25)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(80, 12)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(229, 20)
        Me.txtCity.TabIndex = 1
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Location = New System.Drawing.Point(6, 15)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(36, 13)
        Me.lblGroup.TabIndex = 4
        Me.lblGroup.Text = "Group"
        '
        'Ep1
        '
        Me.Ep1.ContainerControl = Me
        '
        'lblUnderGroup
        '
        Me.lblUnderGroup.AutoSize = True
        Me.lblUnderGroup.Location = New System.Drawing.Point(6, 48)
        Me.lblUnderGroup.Name = "lblUnderGroup"
        Me.lblUnderGroup.Size = New System.Drawing.Size(68, 13)
        Me.lblUnderGroup.TabIndex = 6
        Me.lblUnderGroup.Text = "Under Group"
        '
        'cboState
        '
        Me.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboState.FormattingEnabled = True
        Me.cboState.Location = New System.Drawing.Point(80, 45)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(229, 21)
        Me.cboState.TabIndex = 2
        '
        'LedgerGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 122)
        Me.Controls.Add(Me.cboState)
        Me.Controls.Add(Me.lblUnderGroup)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.lblGroup)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LedgerGroup"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ledger Group Creation"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Ep1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents lblGroup As System.Windows.Forms.Label
    Friend WithEvents Ep1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cboState As System.Windows.Forms.ComboBox
    Friend WithEvents lblUnderGroup As System.Windows.Forms.Label

End Class

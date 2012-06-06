<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mChallanname
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mChallanname))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.txtChallanname = New System.Windows.Forms.TextBox
        Me.lblChallanname = New System.Windows.Forms.Label
        Me.txtPrefix = New System.Windows.Forms.TextBox
        Me.lblPrefix = New System.Windows.Forms.Label
        Me.EP1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmbCompany = New System.Windows.Forms.ComboBox
        Me.lblCompany = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.EP1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(144, 107)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 34)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdOk.Image = Global.Account.My.Resources.Resources.Save
        Me.cmdOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdOk.Location = New System.Drawing.Point(3, 4)
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
        Me.cmdCancel.Location = New System.Drawing.Point(76, 5)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(67, 23)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtChallanname
        '
        Me.txtChallanname.Location = New System.Drawing.Point(67, 17)
        Me.txtChallanname.Name = "txtChallanname"
        Me.txtChallanname.Size = New System.Drawing.Size(229, 20)
        Me.txtChallanname.TabIndex = 2
        '
        'lblChallanname
        '
        Me.lblChallanname.AutoSize = True
        Me.lblChallanname.Location = New System.Drawing.Point(12, 20)
        Me.lblChallanname.Name = "lblChallanname"
        Me.lblChallanname.Size = New System.Drawing.Size(32, 13)
        Me.lblChallanname.TabIndex = 6
        Me.lblChallanname.Text = "State"
        '
        'txtPrefix
        '
        Me.txtPrefix.Location = New System.Drawing.Point(68, 48)
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.Size = New System.Drawing.Size(83, 20)
        Me.txtPrefix.TabIndex = 3
        '
        'lblPrefix
        '
        Me.lblPrefix.AutoSize = True
        Me.lblPrefix.Location = New System.Drawing.Point(13, 51)
        Me.lblPrefix.Name = "lblPrefix"
        Me.lblPrefix.Size = New System.Drawing.Size(32, 13)
        Me.lblPrefix.TabIndex = 8
        Me.lblPrefix.Text = "State"
        '
        'EP1
        '
        Me.EP1.ContainerControl = Me
        '
        'cmbCompany
        '
        Me.cmbCompany.FormattingEnabled = True
        Me.cmbCompany.Location = New System.Drawing.Point(67, 75)
        Me.cmbCompany.Name = "cmbCompany"
        Me.cmbCompany.Size = New System.Drawing.Size(229, 21)
        Me.cmbCompany.TabIndex = 9
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Location = New System.Drawing.Point(13, 78)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(51, 13)
        Me.lblCompany.TabIndex = 8
        Me.lblCompany.Text = "Company"
        '
        'mChallanname
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 145)
        Me.Controls.Add(Me.cmbCompany)
        Me.Controls.Add(Me.txtPrefix)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.lblPrefix)
        Me.Controls.Add(Me.txtChallanname)
        Me.Controls.Add(Me.lblChallanname)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mChallanname"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.EP1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents txtChallanname As System.Windows.Forms.TextBox
    Friend WithEvents lblChallanname As System.Windows.Forms.Label
    Friend WithEvents txtPrefix As System.Windows.Forms.TextBox
    Friend WithEvents lblPrefix As System.Windows.Forms.Label
    Friend WithEvents EP1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbCompany As System.Windows.Forms.ComboBox
    Friend WithEvents lblCompany As System.Windows.Forms.Label

End Class

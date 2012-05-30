<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mUser))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.txtPwd = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkIsAdmin = New System.Windows.Forms.CheckBox
        Me.chkTb = New System.Windows.Forms.CheckBox
        Me.chkPL = New System.Windows.Forms.CheckBox
        Me.chkVoucherView = New System.Windows.Forms.CheckBox
        Me.chkVoucherDelete = New System.Windows.Forms.CheckBox
        Me.chkVoucherEdit = New System.Windows.Forms.CheckBox
        Me.chkVoucherAdd = New System.Windows.Forms.CheckBox
        Me.chkMasterView = New System.Windows.Forms.CheckBox
        Me.chkMasterDelete = New System.Windows.Forms.CheckBox
        Me.chkMasterEdit = New System.Windows.Forms.CheckBox
        Me.chkBs = New System.Windows.Forms.CheckBox
        Me.chkMasterAdd = New System.Windows.Forms.CheckBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(200, 167)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 45)
        Me.TableLayoutPanel1.TabIndex = 16
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdOk.Image = CType(resources.GetObject("cmdOk.Image"), System.Drawing.Image)
        Me.cmdOk.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdOk.Location = New System.Drawing.Point(3, 3)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(67, 38)
        Me.cmdOk.TabIndex = 14
        Me.cmdOk.Text = "OK"
        Me.cmdOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Image = Global.Account.My.Resources.Resources.Back
        Me.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCancel.Location = New System.Drawing.Point(76, 3)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(67, 38)
        Me.cmdCancel.TabIndex = 15
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(41, 9)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(135, 20)
        Me.txtUser.TabIndex = 0
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(241, 9)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(104, 20)
        Me.txtPwd.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkIsAdmin)
        Me.GroupBox1.Controls.Add(Me.chkTb)
        Me.GroupBox1.Controls.Add(Me.chkPL)
        Me.GroupBox1.Controls.Add(Me.chkVoucherView)
        Me.GroupBox1.Controls.Add(Me.chkVoucherDelete)
        Me.GroupBox1.Controls.Add(Me.chkVoucherEdit)
        Me.GroupBox1.Controls.Add(Me.chkVoucherAdd)
        Me.GroupBox1.Controls.Add(Me.chkMasterView)
        Me.GroupBox1.Controls.Add(Me.chkMasterDelete)
        Me.GroupBox1.Controls.Add(Me.chkMasterEdit)
        Me.GroupBox1.Controls.Add(Me.chkBs)
        Me.GroupBox1.Controls.Add(Me.chkMasterAdd)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 129)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Rights"
        '
        'chkIsAdmin
        '
        Me.chkIsAdmin.AutoSize = True
        Me.chkIsAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIsAdmin.ForeColor = System.Drawing.Color.Blue
        Me.chkIsAdmin.Location = New System.Drawing.Point(13, 20)
        Me.chkIsAdmin.Name = "chkIsAdmin"
        Me.chkIsAdmin.Size = New System.Drawing.Size(55, 17)
        Me.chkIsAdmin.TabIndex = 2
        Me.chkIsAdmin.Text = "Admin"
        Me.chkIsAdmin.UseVisualStyleBackColor = True
        '
        'chkTb
        '
        Me.chkTb.AutoSize = True
        Me.chkTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTb.Location = New System.Drawing.Point(241, 102)
        Me.chkTb.Name = "chkTb"
        Me.chkTb.Size = New System.Drawing.Size(88, 17)
        Me.chkTb.TabIndex = 13
        Me.chkTb.Text = "Trial Balance"
        Me.chkTb.UseVisualStyleBackColor = True
        '
        'chkPL
        '
        Me.chkPL.AutoSize = True
        Me.chkPL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPL.Location = New System.Drawing.Point(130, 102)
        Me.chkPL.Name = "chkPL"
        Me.chkPL.Size = New System.Drawing.Size(84, 17)
        Me.chkPL.TabIndex = 12
        Me.chkPL.Text = "Profit && Loss"
        Me.chkPL.UseVisualStyleBackColor = True
        '
        'chkVoucherView
        '
        Me.chkVoucherView.AutoSize = True
        Me.chkVoucherView.Location = New System.Drawing.Point(290, 70)
        Me.chkVoucherView.Name = "chkVoucherView"
        Me.chkVoucherView.Size = New System.Drawing.Size(15, 14)
        Me.chkVoucherView.TabIndex = 10
        Me.chkVoucherView.UseVisualStyleBackColor = True
        '
        'chkVoucherDelete
        '
        Me.chkVoucherDelete.AutoSize = True
        Me.chkVoucherDelete.Location = New System.Drawing.Point(241, 70)
        Me.chkVoucherDelete.Name = "chkVoucherDelete"
        Me.chkVoucherDelete.Size = New System.Drawing.Size(15, 14)
        Me.chkVoucherDelete.TabIndex = 9
        Me.chkVoucherDelete.UseVisualStyleBackColor = True
        '
        'chkVoucherEdit
        '
        Me.chkVoucherEdit.AutoSize = True
        Me.chkVoucherEdit.Location = New System.Drawing.Point(188, 70)
        Me.chkVoucherEdit.Name = "chkVoucherEdit"
        Me.chkVoucherEdit.Size = New System.Drawing.Size(15, 14)
        Me.chkVoucherEdit.TabIndex = 8
        Me.chkVoucherEdit.UseVisualStyleBackColor = True
        '
        'chkVoucherAdd
        '
        Me.chkVoucherAdd.AutoSize = True
        Me.chkVoucherAdd.Location = New System.Drawing.Point(130, 70)
        Me.chkVoucherAdd.Name = "chkVoucherAdd"
        Me.chkVoucherAdd.Size = New System.Drawing.Size(15, 14)
        Me.chkVoucherAdd.TabIndex = 7
        Me.chkVoucherAdd.UseVisualStyleBackColor = True
        '
        'chkMasterView
        '
        Me.chkMasterView.AutoSize = True
        Me.chkMasterView.Location = New System.Drawing.Point(290, 46)
        Me.chkMasterView.Name = "chkMasterView"
        Me.chkMasterView.Size = New System.Drawing.Size(15, 14)
        Me.chkMasterView.TabIndex = 6
        Me.chkMasterView.UseVisualStyleBackColor = True
        '
        'chkMasterDelete
        '
        Me.chkMasterDelete.AutoSize = True
        Me.chkMasterDelete.Location = New System.Drawing.Point(241, 46)
        Me.chkMasterDelete.Name = "chkMasterDelete"
        Me.chkMasterDelete.Size = New System.Drawing.Size(15, 14)
        Me.chkMasterDelete.TabIndex = 5
        Me.chkMasterDelete.UseVisualStyleBackColor = True
        '
        'chkMasterEdit
        '
        Me.chkMasterEdit.AutoSize = True
        Me.chkMasterEdit.Location = New System.Drawing.Point(188, 46)
        Me.chkMasterEdit.Name = "chkMasterEdit"
        Me.chkMasterEdit.Size = New System.Drawing.Size(15, 14)
        Me.chkMasterEdit.TabIndex = 4
        Me.chkMasterEdit.UseVisualStyleBackColor = True
        '
        'chkBs
        '
        Me.chkBs.AutoSize = True
        Me.chkBs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBs.Location = New System.Drawing.Point(13, 102)
        Me.chkBs.Name = "chkBs"
        Me.chkBs.Size = New System.Drawing.Size(96, 17)
        Me.chkBs.TabIndex = 11
        Me.chkBs.Text = "Balance Sheet"
        Me.chkBs.UseVisualStyleBackColor = True
        '
        'chkMasterAdd
        '
        Me.chkMasterAdd.AutoSize = True
        Me.chkMasterAdd.Location = New System.Drawing.Point(130, 46)
        Me.chkMasterAdd.Name = "chkMasterAdd"
        Me.chkMasterAdd.Size = New System.Drawing.Size(15, 14)
        Me.chkMasterAdd.TabIndex = 3
        Me.chkMasterAdd.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Voucher"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Master"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(282, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "View"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(228, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Delete"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(181, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Edit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(124, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Add"
        '
        'mUser
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(352, 215)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mUser"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User Creation"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkIsAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents chkTb As System.Windows.Forms.CheckBox
    Friend WithEvents chkPL As System.Windows.Forms.CheckBox
    Friend WithEvents chkVoucherView As System.Windows.Forms.CheckBox
    Friend WithEvents chkVoucherDelete As System.Windows.Forms.CheckBox
    Friend WithEvents chkVoucherEdit As System.Windows.Forms.CheckBox
    Friend WithEvents chkVoucherAdd As System.Windows.Forms.CheckBox
    Friend WithEvents chkMasterView As System.Windows.Forms.CheckBox
    Friend WithEvents chkMasterDelete As System.Windows.Forms.CheckBox
    Friend WithEvents chkMasterEdit As System.Windows.Forms.CheckBox
    Friend WithEvents chkBs As System.Windows.Forms.CheckBox
    Friend WithEvents chkMasterAdd As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class

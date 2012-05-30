<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.btnEmail = New System.Windows.Forms.Button
        Me.lblSr = New System.Windows.Forms.Label
        Me.lblSrNo = New System.Windows.Forms.Label
        Me.lblActivation = New System.Windows.Forms.Label
        Me.txtActivation = New System.Windows.Forms.TextBox
        Me.btnActivate = New System.Windows.Forms.Button
        Me.msgErr = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblevaluation = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.msgErr, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(158, 153)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(157, 40)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Image = CType(resources.GetObject("OK_Button.Image"), System.Drawing.Image)
        Me.OK_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OK_Button.Location = New System.Drawing.Point(3, 5)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(72, 30)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "&Evaluate"
        Me.OK_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Image = CType(resources.GetObject("Cancel_Button.Image"), System.Drawing.Image)
        Me.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancel_Button.Location = New System.Drawing.Point(81, 5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(72, 30)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "E&xit"
        Me.Cancel_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnEmail
        '
        Me.btnEmail.Image = CType(resources.GetObject("btnEmail.Image"), System.Drawing.Image)
        Me.btnEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmail.Location = New System.Drawing.Point(121, 90)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(194, 25)
        Me.btnEmail.TabIndex = 1
        Me.btnEmail.Text = "&Request Activation Key by Email"
        Me.btnEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEmail.UseVisualStyleBackColor = True
        '
        'lblSr
        '
        Me.lblSr.AutoSize = True
        Me.lblSr.Location = New System.Drawing.Point(25, 29)
        Me.lblSr.Name = "lblSr"
        Me.lblSr.Size = New System.Drawing.Size(73, 13)
        Me.lblSr.TabIndex = 2
        Me.lblSr.Text = "Serial Number"
        '
        'lblSrNo
        '
        Me.lblSrNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSrNo.Location = New System.Drawing.Point(121, 28)
        Me.lblSrNo.Name = "lblSrNo"
        Me.lblSrNo.Size = New System.Drawing.Size(194, 23)
        Me.lblSrNo.TabIndex = 3
        '
        'lblActivation
        '
        Me.lblActivation.AutoSize = True
        Me.lblActivation.Location = New System.Drawing.Point(25, 67)
        Me.lblActivation.Name = "lblActivation"
        Me.lblActivation.Size = New System.Drawing.Size(75, 13)
        Me.lblActivation.TabIndex = 4
        Me.lblActivation.Text = "Activation Key"
        '
        'txtActivation
        '
        Me.txtActivation.Location = New System.Drawing.Point(121, 64)
        Me.txtActivation.Name = "txtActivation"
        Me.txtActivation.Size = New System.Drawing.Size(194, 20)
        Me.txtActivation.TabIndex = 5
        '
        'btnActivate
        '
        Me.btnActivate.Image = CType(resources.GetObject("btnActivate.Image"), System.Drawing.Image)
        Me.btnActivate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActivate.Location = New System.Drawing.Point(121, 119)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(194, 25)
        Me.btnActivate.TabIndex = 6
        Me.btnActivate.Text = "Enter key and Activate &Now"
        Me.btnActivate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActivate.UseVisualStyleBackColor = True
        '
        'msgErr
        '
        Me.msgErr.ContainerControl = Me
        '
        'lblevaluation
        '
        Me.lblevaluation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblevaluation.ForeColor = System.Drawing.Color.Red
        Me.lblevaluation.Image = CType(resources.GetObject("lblevaluation.Image"), System.Drawing.Image)
        Me.lblevaluation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblevaluation.Location = New System.Drawing.Point(12, 163)
        Me.lblevaluation.Name = "lblevaluation"
        Me.lblevaluation.Size = New System.Drawing.Size(104, 20)
        Me.lblevaluation.TabIndex = 7
        Me.lblevaluation.Text = "30 Days Left"
        Me.lblevaluation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(327, 198)
        Me.Controls.Add(Me.lblevaluation)
        Me.Controls.Add(Me.btnActivate)
        Me.Controls.Add(Me.txtActivation)
        Me.Controls.Add(Me.lblActivation)
        Me.Controls.Add(Me.lblSrNo)
        Me.Controls.Add(Me.lblSr)
        Me.Controls.Add(Me.btnEmail)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Register"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.msgErr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents btnEmail As System.Windows.Forms.Button
    Friend WithEvents lblSr As System.Windows.Forms.Label
    Friend WithEvents lblSrNo As System.Windows.Forms.Label
    Friend WithEvents lblActivation As System.Windows.Forms.Label
    Friend WithEvents txtActivation As System.Windows.Forms.TextBox
    Friend WithEvents btnActivate As System.Windows.Forms.Button
    Friend WithEvents msgErr As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblevaluation As System.Windows.Forms.Label

End Class

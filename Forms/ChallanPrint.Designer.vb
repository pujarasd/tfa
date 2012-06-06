<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChallanPrint
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChallanPrint))
        Me.ChallanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dschallan = New Account.dschallan
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Challan = New Account.dschallanTableAdapters.Challan
        CType(Me.ChallanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dschallan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChallanBindingSource
        '
        Me.ChallanBindingSource.DataMember = "Challan"
        Me.ChallanBindingSource.DataSource = Me.dschallan
        '
        'dschallan
        '
        Me.dschallan.DataSetName = "dschallan"
        Me.dschallan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "dschallan_Challan"
        ReportDataSource1.Value = Me.ChallanBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Account.ChallanPrint.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 37)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(992, 580)
        Me.ReportViewer1.TabIndex = 0
        '
        'Challan
        '
        Me.Challan.ClearBeforeFill = True
        '
        'ChallanPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 616)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ChallanPrint"
        Me.Text = "ChallanPrint"
        CType(Me.ChallanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dschallan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ChallanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dschallan As Account.dschallan
    Friend WithEvents Challan As Account.dschallanTableAdapters.Challan
End Class

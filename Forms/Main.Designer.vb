<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.mnuLogin = New System.Windows.Forms.MenuStrip
        Me.miLogin = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.slblUser = New System.Windows.Forms.ToolStripStatusLabel
        Me.slblPeriod = New System.Windows.Forms.ToolStripStatusLabel
        Me.slblCompany = New System.Windows.Forms.ToolStripStatusLabel
        Me.mnuMain = New System.Windows.Forms.MenuStrip
        Me.miCompany = New System.Windows.Forms.ToolStripMenuItem
        Me.miPeriod = New System.Windows.Forms.ToolStripMenuItem
        Me.miMasters = New System.Windows.Forms.ToolStripMenuItem
        Me.miLedger = New System.Windows.Forms.ToolStripMenuItem
        Me.miAgent = New System.Windows.Forms.ToolStripMenuItem
        Me.miLedgerGroup = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.miItem = New System.Windows.Forms.ToolStripMenuItem
        Me.miItemGroup = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.miCity = New System.Windows.Forms.ToolStripMenuItem
        Me.miState = New System.Windows.Forms.ToolStripMenuItem
        Me.miCountry = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.miCharges = New System.Windows.Forms.ToolStripMenuItem
        Me.miBooks = New System.Windows.Forms.ToolStripMenuItem
        Me.miTransport = New System.Windows.Forms.ToolStripMenuItem
        Me.miUser = New System.Windows.Forms.ToolStripMenuItem
        Me.miVoucherMain = New System.Windows.Forms.ToolStripMenuItem
        Me.miInventory = New System.Windows.Forms.ToolStripMenuItem
        Me.miChallan = New System.Windows.Forms.ToolStripMenuItem
        Me.miInvoice = New System.Windows.Forms.ToolStripMenuItem
        Me.miReport = New System.Windows.Forms.ToolStripMenuItem
        Me.LorryChallanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.RegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.StatementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ServiceTaxStatementToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.TdsStatmentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.FreightMarginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FreightMarginRVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FAReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PartyLedgerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TrialBalanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.miTools = New System.Windows.Forms.ToolStripMenuItem
        Me.Help = New System.Windows.Forms.ToolStripMenuItem
        Me.miWindow = New System.Windows.Forms.ToolStripMenuItem
        Me.miLogout = New System.Windows.Forms.ToolStripMenuItem
        Me.miChallanPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuLogin.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuLogin
        '
        Me.mnuLogin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miLogin})
        Me.mnuLogin.Location = New System.Drawing.Point(0, 24)
        Me.mnuLogin.Name = "mnuLogin"
        Me.mnuLogin.Size = New System.Drawing.Size(771, 24)
        Me.mnuLogin.TabIndex = 1
        Me.mnuLogin.Text = "Main Menu"
        '
        'miLogin
        '
        Me.miLogin.Name = "miLogin"
        Me.miLogin.Size = New System.Drawing.Size(49, 20)
        Me.miLogin.Text = "Login"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblUser, Me.slblPeriod, Me.slblCompany})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 554)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(771, 24)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'slblUser
        '
        Me.slblUser.BackColor = System.Drawing.Color.Transparent
        Me.slblUser.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.slblUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.slblUser.Name = "slblUser"
        Me.slblUser.Size = New System.Drawing.Size(69, 19)
        Me.slblUser.Text = "User Name"
        '
        'slblPeriod
        '
        Me.slblPeriod.BackColor = System.Drawing.Color.Transparent
        Me.slblPeriod.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.slblPeriod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.slblPeriod.Name = "slblPeriod"
        Me.slblPeriod.Size = New System.Drawing.Size(45, 19)
        Me.slblPeriod.Text = "Period"
        '
        'slblCompany
        '
        Me.slblCompany.BackColor = System.Drawing.Color.Transparent
        Me.slblCompany.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.slblCompany.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.slblCompany.Name = "slblCompany"
        Me.slblCompany.Size = New System.Drawing.Size(98, 19)
        Me.slblCompany.Text = "Company Name"
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miCompany, Me.miPeriod, Me.miMasters, Me.miVoucherMain, Me.miInventory, Me.miReport, Me.miTools, Me.Help, Me.miWindow, Me.miLogout})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(771, 24)
        Me.mnuMain.TabIndex = 4
        Me.mnuMain.Text = "Main Menu"
        '
        'miCompany
        '
        Me.miCompany.Name = "miCompany"
        Me.miCompany.Size = New System.Drawing.Size(71, 20)
        Me.miCompany.Text = "Company"
        '
        'miPeriod
        '
        Me.miPeriod.Name = "miPeriod"
        Me.miPeriod.Size = New System.Drawing.Size(53, 20)
        Me.miPeriod.Text = "Period"
        '
        'miMasters
        '
        Me.miMasters.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miLedger, Me.miAgent, Me.miLedgerGroup, Me.ToolStripSeparator1, Me.miItem, Me.miItemGroup, Me.ToolStripSeparator2, Me.miCity, Me.miState, Me.miCountry, Me.ToolStripSeparator3, Me.miCharges, Me.miBooks, Me.miTransport, Me.miUser})
        Me.miMasters.Name = "miMasters"
        Me.miMasters.Size = New System.Drawing.Size(60, 20)
        Me.miMasters.Text = "Masters"
        '
        'miLedger
        '
        Me.miLedger.Name = "miLedger"
        Me.miLedger.Size = New System.Drawing.Size(152, 22)
        Me.miLedger.Text = "Ledger"
        '
        'miAgent
        '
        Me.miAgent.Name = "miAgent"
        Me.miAgent.Size = New System.Drawing.Size(152, 22)
        Me.miAgent.Text = "Agent"
        '
        'miLedgerGroup
        '
        Me.miLedgerGroup.Name = "miLedgerGroup"
        Me.miLedgerGroup.Size = New System.Drawing.Size(152, 22)
        Me.miLedgerGroup.Text = "Ledger Group"
        Me.miLedgerGroup.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'miItem
        '
        Me.miItem.Name = "miItem"
        Me.miItem.Size = New System.Drawing.Size(152, 22)
        Me.miItem.Text = "Item"
        Me.miItem.Visible = False
        '
        'miItemGroup
        '
        Me.miItemGroup.Name = "miItemGroup"
        Me.miItemGroup.Size = New System.Drawing.Size(152, 22)
        Me.miItemGroup.Text = "Item Group"
        Me.miItemGroup.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        Me.ToolStripSeparator2.Visible = False
        '
        'miCity
        '
        Me.miCity.Name = "miCity"
        Me.miCity.Size = New System.Drawing.Size(152, 22)
        Me.miCity.Text = "City"
        '
        'miState
        '
        Me.miState.Name = "miState"
        Me.miState.Size = New System.Drawing.Size(152, 22)
        Me.miState.Text = "State"
        '
        'miCountry
        '
        Me.miCountry.Name = "miCountry"
        Me.miCountry.Size = New System.Drawing.Size(152, 22)
        Me.miCountry.Text = "Country"
        Me.miCountry.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'miCharges
        '
        Me.miCharges.Name = "miCharges"
        Me.miCharges.Size = New System.Drawing.Size(152, 22)
        Me.miCharges.Text = "Charges "
        '
        'miBooks
        '
        Me.miBooks.Name = "miBooks"
        Me.miBooks.Size = New System.Drawing.Size(152, 22)
        Me.miBooks.Text = "Books"
        '
        'miTransport
        '
        Me.miTransport.Name = "miTransport"
        Me.miTransport.Size = New System.Drawing.Size(152, 22)
        Me.miTransport.Text = "Transport"
        '
        'miUser
        '
        Me.miUser.Name = "miUser"
        Me.miUser.Size = New System.Drawing.Size(152, 22)
        Me.miUser.Text = "Users"
        '
        'miVoucherMain
        '
        Me.miVoucherMain.Name = "miVoucherMain"
        Me.miVoucherMain.Size = New System.Drawing.Size(63, 20)
        Me.miVoucherMain.Text = "Voucher"
        '
        'miInventory
        '
        Me.miInventory.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miChallan, Me.miInvoice})
        Me.miInventory.Name = "miInventory"
        Me.miInventory.Size = New System.Drawing.Size(69, 20)
        Me.miInventory.Text = "Inventory"
        '
        'miChallan
        '
        Me.miChallan.Name = "miChallan"
        Me.miChallan.Size = New System.Drawing.Size(152, 22)
        Me.miChallan.Text = "Challan"
        '
        'miInvoice
        '
        Me.miInvoice.Name = "miInvoice"
        Me.miInvoice.Size = New System.Drawing.Size(152, 22)
        Me.miInvoice.Text = "Invoice"
        '
        'miReport
        '
        Me.miReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LorryChallanToolStripMenuItem, Me.InvoiceToolStripMenuItem, Me.ToolStripSeparator4, Me.RegisterToolStripMenuItem, Me.ToolStripSeparator5, Me.StatementsToolStripMenuItem, Me.FAReportsToolStripMenuItem})
        Me.miReport.Name = "miReport"
        Me.miReport.Size = New System.Drawing.Size(59, 20)
        Me.miReport.Text = "Reports"
        '
        'LorryChallanToolStripMenuItem
        '
        Me.LorryChallanToolStripMenuItem.Name = "LorryChallanToolStripMenuItem"
        Me.LorryChallanToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LorryChallanToolStripMenuItem.Text = "Lorry &Challan"
        '
        'InvoiceToolStripMenuItem
        '
        Me.InvoiceToolStripMenuItem.Name = "InvoiceToolStripMenuItem"
        Me.InvoiceToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InvoiceToolStripMenuItem.Text = "&Invoice"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(149, 6)
        '
        'RegisterToolStripMenuItem
        '
        Me.RegisterToolStripMenuItem.Name = "RegisterToolStripMenuItem"
        Me.RegisterToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RegisterToolStripMenuItem.Text = "&Register"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(149, 6)
        '
        'StatementsToolStripMenuItem
        '
        Me.StatementsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServiceTaxStatementToolStripMenuItem1, Me.TdsStatmentToolStripMenuItem1, Me.FreightMarginToolStripMenuItem, Me.FreightMarginRVToolStripMenuItem})
        Me.StatementsToolStripMenuItem.Name = "StatementsToolStripMenuItem"
        Me.StatementsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StatementsToolStripMenuItem.Text = "Statements"
        '
        'ServiceTaxStatementToolStripMenuItem1
        '
        Me.ServiceTaxStatementToolStripMenuItem1.Name = "ServiceTaxStatementToolStripMenuItem1"
        Me.ServiceTaxStatementToolStripMenuItem1.Size = New System.Drawing.Size(169, 22)
        Me.ServiceTaxStatementToolStripMenuItem1.Text = "&Service tax"
        '
        'TdsStatmentToolStripMenuItem1
        '
        Me.TdsStatmentToolStripMenuItem1.Name = "TdsStatmentToolStripMenuItem1"
        Me.TdsStatmentToolStripMenuItem1.Size = New System.Drawing.Size(169, 22)
        Me.TdsStatmentToolStripMenuItem1.Text = "&Tds"
        '
        'FreightMarginToolStripMenuItem
        '
        Me.FreightMarginToolStripMenuItem.Name = "FreightMarginToolStripMenuItem"
        Me.FreightMarginToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.FreightMarginToolStripMenuItem.Text = "&Freight Margin"
        '
        'FreightMarginRVToolStripMenuItem
        '
        Me.FreightMarginRVToolStripMenuItem.Name = "FreightMarginRVToolStripMenuItem"
        Me.FreightMarginRVToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.FreightMarginRVToolStripMenuItem.Text = "Freight Margin &RV"
        '
        'FAReportsToolStripMenuItem
        '
        Me.FAReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PartyLedgerToolStripMenuItem, Me.TrialBalanceToolStripMenuItem})
        Me.FAReportsToolStripMenuItem.Name = "FAReportsToolStripMenuItem"
        Me.FAReportsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FAReportsToolStripMenuItem.Text = "FA Reports"
        '
        'PartyLedgerToolStripMenuItem
        '
        Me.PartyLedgerToolStripMenuItem.Name = "PartyLedgerToolStripMenuItem"
        Me.PartyLedgerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PartyLedgerToolStripMenuItem.Text = "Party &Ledger"
        '
        'TrialBalanceToolStripMenuItem
        '
        Me.TrialBalanceToolStripMenuItem.Name = "TrialBalanceToolStripMenuItem"
        Me.TrialBalanceToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TrialBalanceToolStripMenuItem.Text = "Trial Balance"
        '
        'miTools
        '
        Me.miTools.Name = "miTools"
        Me.miTools.Size = New System.Drawing.Size(48, 20)
        Me.miTools.Text = "Tools"
        '
        'Help
        '
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(44, 20)
        Me.Help.Text = "Help"
        '
        'miWindow
        '
        Me.miWindow.Name = "miWindow"
        Me.miWindow.Size = New System.Drawing.Size(68, 20)
        Me.miWindow.Text = "Windows"
        '
        'miLogout
        '
        Me.miLogout.Name = "miLogout"
        Me.miLogout.Size = New System.Drawing.Size(57, 20)
        Me.miLogout.Text = "Logout"
        '
        'miChallanPrint
        '
        Me.miChallanPrint.Name = "miChallanPrint"
        Me.miChallanPrint.Size = New System.Drawing.Size(152, 22)
        Me.miChallanPrint.Text = "Challan Print"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 578)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.mnuLogin)
        Me.Controls.Add(Me.mnuMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuLogin
        Me.Name = "Main"
        Me.Text = "Accounts"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuLogin.ResumeLayout(False)
        Me.mnuLogin.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuLogin As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents miLogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents miCompany As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miMasters As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miLedger As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miLedgerGroup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents miItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miItemGroup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents miCity As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miState As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miCountry As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miVoucherMain As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents miCharges As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miBooks As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miTransport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miInventory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miChallan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miPeriod As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miWindow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents slblUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblPeriod As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblCompany As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RegisterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatementsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServiceTaxStatementToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miChallanPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FreightMarginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FreightMarginRVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miAgent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LorryChallanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvoiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TdsStatmentToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miInvoice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FAReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PartyLedgerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrialBalanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

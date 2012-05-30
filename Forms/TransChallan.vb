Public Class TransChallan
    Friend mode As enDatamode
    Friend id As Integer
    Friend navmode As enNavMode = enNavMode.LastRec
    Dim dtchallan As DataTable
    Dim dtchdetail As DataTable
    Dim dtplace As DataTable
    Dim dtLorry As DataTable
    Dim dvLorry As DataView
    Dim rowindex As Integer = 0
    Dim isLoading As Boolean
    Dim custid As Integer
    Dim itementrymode As enEntry

#Region "form_events"

    Private Sub TransChallan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Back)
            Case ChrW(Keys.Enter)
                If TypeOf Me.ActiveControl Is TextBox Then
                    If CType(Me.ActiveControl, TextBox).Multiline Then

                        Exit Sub
                    End If
                ElseIf TypeOf Me.ActiveControl Is Button Then

                    Exit Sub

                End If
                SendKeys.Send("{TAB}")
            Case Else
                If Not "txtEgp_txtGrade_txtNarration_txtShip".Contains(ActiveControl.Name) Then
                    If Not (Char.IsDigit(e.KeyChar)) And (e.KeyChar <> ".") Then
                        e.Handled = True
                    Else

                        If e.KeyChar = "." And ActiveControl.Text.Contains(".") Then
                            e.Handled = True

                        End If
                    End If
                End If


        End Select

    End Sub

    Private Sub Challan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isLoading = True
        Me.Height = 500
        Me.Width = 700
        Grid_Create()
        Dim dtChallanname As DataTable = modData.dbTable("Select id,Challanname+'~'+ prefix+ '~'+cast(accountid as varchar(10)) as challanname from mChallanName order by challanname")
        Dim row As DataRow = dtChallanname.NewRow
        row("Id") = 0
        row("ChallanName") = "(Select)"

        dtChallanname.Rows.InsertAt(row, 0)
        tscBook.ComboBox.DataSource = dtChallanname
        tscBook.ComboBox.ValueMember = "Id"
        tscBook.ComboBox.DisplayMember = "ChallanName"
        tscBook.SelectedIndex = 0

        pnlmain.Visible = False
        pnlsave.Visible = False

        dtChallanDate.MaxDate = gFinEndDate
        dtChallanDate.MinDate = gFinStartDate
        'Dim thisTextBox As New ToolStripComboBox
        'thisTextBox = CType(tbNav.Items("tscBook"), ToolStripComboBox)
        'thisTextBox.Focus()
        'tbNav.Items("tscBook").Select()
        'tscBook.Select()
        ' tscBook.ComboBox.Select()
        ActiveControl = tscBook.ComboBox

        SendKeys.Send("{F4}")
        isLoading = False

    End Sub

#End Region
#Region "Procedures"

    Sub Fill_Combo()



        Dim row As DataRow
        Dim dtTransporter As DataTable = modData.dbTable("Select id,Ledger from mledger where groupid=31 order by ledger")
        row = dtTransporter.NewRow
        row("id") = -1
        row("Ledger") = "(Create New)"
        dtTransporter.Rows.InsertAt(row, 0)
        row = dtTransporter.NewRow
        row("id") = 0
        row("Ledger") = "(Select)"
        dtTransporter.Rows.InsertAt(row, 0)
        cmbTransporter.DataSource = dtTransporter
        cmbTransporter.ValueMember = "id"
        cmbTransporter.DisplayMember = "Ledger"

        dtplace = dbTable("SELECT [Id],[Place],[Rate],[CityId] FROM mTransRate order by place")
        cmbPlace.DataSource = dtplace
        cmbPlace.ValueMember = "id"
        cmbPlace.DisplayMember = "Place"

        dtLorry = dbTable("select id,acid,lorryno from mtransdetails order by lorryno")
        dvLorry = dtLorry.DefaultView
        cmbLorry.DataSource = dvLorry
        cmbLorry.ValueMember = "id"
        cmbLorry.DisplayMember = "LorryNo"



    End Sub
    Sub Fill_Challan()
        Dim qstr As String = _
         <string>
          Select a.*,b.ledger from ttranschallan a 
          inner join mledger b on b.id = a.custid 
          where bookid= <%= tscBook.ComboBox.SelectedValue %>  order by challan
           </string>
        dtchallan = dbTable(qstr)
        qstr = _
        <string>
            Select a.*,p.place,p.rate as stdrate,c.city , l.lorryno from ttranschallandetails a 
            inner join mtransrate p on p.id = a.placeid 
            inner join mcity c on c.id=p.cityid 
            inner join mtransdetails l on l.id=a.lorryid
            order by a.challanid,a.id
          </string>
        dtchdetail = dbTable(qstr)

        Fill_Controls()
    End Sub
    Sub Fill_Controls(Optional ByVal ROW As DataRowView = Nothing)
        If mode = enDatamode.Add Then
            Exit Sub
        End If
        If dtchallan.Rows.Count = 0 Then
            disableEntry()
            Exit Sub

        End If
        Select Case navmode
            Case enNavMode.FirstRec
                rowindex = 0
            Case enNavMode.LastRec
                rowindex = dtchallan.Rows.Count - 1
            Case enNavMode.NextRec
                If rowindex < dtchallan.Rows.Count - 1 Then
                    rowindex += 1
                    If rowindex > 0 Then tsbPrevious.Enabled = True
                Else
                    tsbNext.Enabled = False
                    Exit Sub
                End If

            Case enNavMode.PrevRec
                If rowindex > 0 Then
                    rowindex -= 1
                Else
                    tsbPrevious.Enabled = False
                    Exit Sub
                End If
        End Select
        If ROW Is Nothing Then ROW = dtchallan.DefaultView(rowindex)

        txtChallan.Text = ROW("Challan")
        dtChallanDate.Value = ROW("Date")
        lblCustName.Text = ROW("ledger")
        cmbTransporter.SelectedValue = ROW("TransportId")
        If ROW("Mode") = "B" Then rbBPP.Checked = True
        txtNarration.Text = ROW("Narration")
        txtGrossamt.Text = ROW("GrossAmount")
        txtCommission.Text = ROW("Commission")
        txtLabour.Text = ROW("Labour")
        txtTDSRate.Text = ROW("tds_rate")
        txtTdsOn.Text = ROW("GrossAmount")
        txtShortage.Text = ROW("Shortage")
        txtAdv.Text = ROW("Advance")
        txtNetAmt.Text = ROW("Amount")
        txtPayable.Text = ROW("Payable")
        custid = ROW("CustId")
        Dim dv As DataView = dtchdetail.DefaultView
        dv.RowFilter = "challanid = " & ROW("Id")
        dgv.DataSource = dv
        disableEntry()

    End Sub

    Private Sub ItemEdit()
        pnlItems.Visible = True
        pnlItems.Top = dgv.Top
        pnlItems.Left = dgv.Left
        pnlItems.Width = 520
        pnlItems.Height = 220

        pnlsave.Enabled = False
        pnlmain.Enabled = False

    End Sub
    Sub Grid_Create()
        dgvdefault(dgv)
        With dgv
            With .Columns
                .Add("Id", "Id")


                .Add("Place", "Place")
                .Add("Station", "Station")
                .Add("Lorry", "Lorry")
                .Add("Bags", "Bags")
                .Add("Weight", "Weight")
                .Add("Rate", "Rate")
                .Add("RateDiff", "Rate Diff.")
                .Add("Amount", "Amount")
                .Add("Labour", "Labour")
                .Add("Shortage", "Shortage")
                .Add("Grno", "GR No.")
                .Add("GrDate", "GR Date")
                .Add("ShipNo", "Ship. No.")
                .Add("EgpNo", "Egp. No.")
                .Add("DiNo", "Di. No.")
                .Add("Grade", "Grade")
                .Add("ShipNo", "Ship.No.")
            End With
            With .Columns("Id")
                .Visible = False
            End With
            With .Columns("Place")
                .DataPropertyName = "Place"
                .Width = 100
            End With
            With .Columns("Station")
                .DataPropertyName = "Station"
                .Width = 100
            End With
            With .Columns("Lorry")
                .DataPropertyName = "Lorry"
                .Width = 100
            End With
            With .Columns("Bags")
                .DataPropertyName = "Bags"
                .Width = 50
                .CellTemplate.Style.Format = "{0:N2}"
                .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight

            End With
            With .Columns("Weight")
                .DataPropertyName = "Weight"
                .Width = 50
                .CellTemplate.Style.Format = "{0:N3}"
                .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight

            End With
            With .Columns("Rate")
                .DataPropertyName = "Rate"
                .Width = 75
                .CellTemplate.Style.Format = "{0:N2}"
                .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight

            End With
            With .Columns("RateDiff")
                .DataPropertyName = "RateDiff"
                .Width = 75
                .CellTemplate.Style.Format = "{0:N2}"
                .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight

            End With
            With .Columns("Amount")
                .DataPropertyName = "Amount"
                .Width = 100
                .CellTemplate.Style.Format = "{0:N2}"
                .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight

            End With
            With .Columns("Labour")
                .DataPropertyName = "Labour"
                .Width = 75
                .CellTemplate.Style.Format = "{0:N2}"
                .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight

            End With
            With .Columns("Shortage")
                .DataPropertyName = "Shortage"
                .Width = 75
                .CellTemplate.Style.Format = "{0:N2}"
                .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight

            End With
            With .Columns("Grno")
                .DataPropertyName = "Grno"
                .Width = 50
            End With
            With .Columns("GrDate")
                .DataPropertyName = "GrDate"
                .Width = 75
                .CellTemplate.Style.Format = "{0:dd/MM/yyyy}"
                .CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight

            End With
            With .Columns("ShipNo")
                .DataPropertyName = "ShipNo"
                .Width = 75
            End With
            With .Columns("EgpNo")
                .DataPropertyName = "EgpNo"
                .Width = 75
            End With
            With .Columns("DiNo")
                .DataPropertyName = "DiNo"
                .Width = 75
            End With
            With .Columns("Grade")
                .DataPropertyName = "Grade"
                .Width = 75
            End With
            With .Columns("ShipNo")
                .DataPropertyName = "ShipNo"
                .Width = 75
            End With
        End With

    End Sub



    Sub disableEntry()
        pnlmain.Enabled = False
        pnlsave.Enabled = False
    End Sub
    Sub enableEntry()
        pnlmain.Enabled = True
        pnlsave.Enabled = True
    End Sub

    Sub calc()
        txtAmt.Text = Val(txtRate.Text) * Val(txtWeight.Text)

    End Sub
#End Region

#Region "Combo"
    Private Sub tscBook_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tscBook.SelectedIndexChanged
        If Not isLoading Then
            If tscBook.SelectedIndex = 0 Then
                pnlmain.Visible = False
                pnlsave.Visible = False
                Exit Sub
            End If
            Fill_Combo()
            Fill_Challan()
            lblCustName.Text = nz(dbValue("SELECT LEDGER FROM mLEDGER WHERE id=" & tscBook.SelectedItem(1).ToString.Split("~")(2)), "")
            lblPrefix.Text = tscBook.SelectedItem(1).ToString.Split("~")(1)
            pnlmain.Visible = True
            pnlsave.Visible = True
            If txtChallan.Text = "" Then
                btnNew_Click(Nothing, Nothing)
            End If
        End If
    End Sub
    Private Sub cmbPlace_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPlace.SelectedIndexChanged
        txtRate.Text = dtplace.Select("id=" & cmbPlace.SelectedItem(0))(0)("Rate")
        calc()
    End Sub
#End Region
#Region "Buttons"

    Private Sub tsbRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbRefresh.Click
        If Not isLoading Then Fill_Challan()
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim qstr As String = ""
        Dim aqstr As New List(Of String)
        If mode = enDatamode.Add Then
            qstr = _
            <string>INSERT INTO [ttranschallan]
           ([BookId]
           ,[Challan]
           ,[Date]
           ,[CustId]
           ,[TrasnportId]
           ,[Mode]
           ,[Narration]
           ,[GrossAmount]
           ,[Commission]
           ,[Labour]
           ,[Tds_rate]
           ,[Tds_amount]
           ,[Shortage]
           ,[Advance]
           ,[Amount]
           ,[Payable])
            VALUES(
           (<%= tscBook.ComboBox.SelectedValue %>
           ,<%= txtChallan.Text %>
           ,'<%= dtChallanDate.Value %>'
           ,<%= custid %>
           ,<%= cmbTransporter.SelectedValue %>
           ,'<%= IIf(rbBPP.Checked, "B", "P") %>'
           ,'<%= txtNarration.Text %>'
           ,<%= txtGrossamt.Text %>
           ,<%= txtCommission.Text %>
           ,<%= txtLabour.Text %>
           ,<%= txtTDSRate.Text %>
           ,<%= txtTdsAmt.Text %>
           ,<%= txtShortage.Text %>
           ,<%= txtAdv.Text %>
           ,<%= txtNetAmt.Text %>
           ,<%= txtPayable.Text %>)
            </string>
            aqstr.Add(qstr)
            For Each row As DataRow In dtchdetail.Rows
                qstr = _
                 <sting>
            INSERT INTO [ttranschallanDetails]
           ([ChallanId]
           ,[PlaceId]
           ,[LorryId]
           ,[GrNo]
           ,[GrDate]
           ,[ShipNo]
           ,[EgpNo]
           ,[DiNo]
           ,[Grade]
           ,[Bags]
           ,[Weight]
           ,[Rate]
           ,[Amount]
           ,[RateDiff]
           ,[Labour]
           ,[Shortage])
            VALUES()
           (SCOPE_IDENTITY(),
           ,<%= row("PlaceId") %>
           ,<%= row("LorryId") %>
           ,<%= row("GrNo") %>
           ,<%= row("GrDate") %>
           ,<%= row("ShipNo") %>
           ,<%= row("EgpNo") %>
           ,<%= row("DiNo") %>
           ,<%= row("Grade") %>
           ,<%= row("Bags") %>
           ,<%= row("Weight") %>
           ,<%= row("Rate") %>
           ,<%= row("Amount") %>
           ,<%= row("RateDiff") %>
           ,<%= row("Labour") %>
           ,<%= row("Shortage") %>)
        </sting>
                aqstr.Add(qstr)
            Next
        End If
    End Sub
    Private Sub btnICancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnICancel.Click
        pnlItems.Visible = False
        pnlsave.Enabled = True
        pnlmain.Enabled = True
    End Sub
    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        mode = enDatamode.Add
        Fill_Controls()
        enableEntry()
        If dtchallan.Rows.Count = 0 Then
            txtChallan.Text = 1
        Else
            txtChallan.Text = dtchallan.Rows(dtchallan.Rows.Count - 1)("Challan") + 1
        End If





        txtChallan.Focus()

    End Sub
#End Region
#Region "DGV"
    Private Sub dgv_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv.GotFocus
        If dgv.RowCount = 0 Then
            itementrymode = enEntry.Add
            ItemEdit()
        End If
    End Sub
    Private Sub dgv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv.KeyDown
        Select Case e.KeyCode
            Case Keys.Insert
                itementrymode = enEntry.Add
                ItemEdit()
            Case Keys.Delete
                itementrymode = enEntry.Delete
            Case Keys.Enter
                itementrymode = enEntry.Edit
            Case Keys.F3
                itementrymode = enEntry.View
        End Select
    End Sub
#End Region



#Region "TextBox"
    Private Sub txtChallan_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtChallan.Validating
        dtchallan.DefaultView.RowFilter = "challan = " & txtChallan.Text
        Dim dr As DataRowView
        If dtchallan.DefaultView.Count > 0 Then
            dr = dtchallan.DefaultView(0)
            dtchallan.DefaultView.RowFilter = ""
            navmode = enNavMode.none
            mode = enDatamode.View
            Fill_Controls(dr)
        End If
        e.Cancel = False
    End Sub
    Private Sub dtChallanDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtChallanDate.Validating
        If ActiveControl.Name <> "btnCancel" Then
            dtchallan.DefaultView.RowFilter = "Challan = " & (txtChallan.Text) - 1
            If dtchallan.DefaultView.Count > 0 Then
                If dtChallanDate.Value < dtchallan.DefaultView(0)("ChallanDate") Then
                    ErrorProvider1.SetError(dtChallanDate, "Challan Date can not be greater than previous challan date")
                    e.Cancel = True
                End If
            End If
        End If

    End Sub
    Private Sub txtCommission_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCommission.Validating
        txtCommission.Text = Format(Val(txtCommission.Text), "{0:f2}")
    End Sub

    Private Sub txtFreight_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtFreight.Validating
        txtFreight.Text = Format(Val(txtFreight.Text), "{0:f2}")
    End Sub

    Private Sub txtWeight_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtWeight.Validating
        txtWeight.Text = String.Format("{0:f3}", Val(txtWeight.Text))
        calc()
    End Sub
   
    Private Sub txtGrossamt_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtGrossamt.Validating
        txtGrossamt.Text = String.Format("{0:f2}", Val(txtGrossamt.Text))

    End Sub
    Private Sub txtILabour_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtILabour.Validating
        txtILabour.Text = String.Format("{0:f2}", Val(txtILabour.Text))
        calc()
    End Sub
    Private Sub txtLabour_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtLabour.Validating
        txtLabour.Text = String.Format("{0:f2}", Val(txtLabour.Text))
        calc()
    End Sub
    Private Sub txtNetAmt_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNetAmt.Validating
        txtNetAmt.Text = String.Format("{0:f2}", Val(txtNetAmt.Text))
    End Sub
    Private Sub txtPayable_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPayable.Validating
        txtPayable.Text = String.Format("{0:f2}", Val(txtPayable.Text))
    End Sub

    Private Sub txtRate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRate.Validating
        txtRate.Text = String.Format("{0:f2}", Val(txtRate.Text))
        calc()

    End Sub
    Private Sub txtRateDiff_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRateDiff.Validating
        txtRateDiff.Text = String.Format("{0:f2}", Val(txtRateDiff.Text))
        calc()

    End Sub
    Private Sub txtShort_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtShort.Validating
        txtShort.Text = String.Format("{0:f2}", Val(txtShort.Text))
        calc()

    End Sub
    Private Sub txtShortage_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtShortage.Validating
        txtShortage.Text = String.Format("{0:f2}", Val(txtShortage.Text))
        calc()

    End Sub

    Private Sub txtTdsAmt_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTdsAmt.Validating
        txtTdsAmt.Text = String.Format("{0:f2}", Val(txtTdsAmt.Text))
        calc()

    End Sub
    Private Sub txtTdsOn_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTdsOn.Validating
        txtTdsOn.Text = String.Format("{0:f2}", Val(txtTdsOn.Text))
        calc()
    End Sub
    Private Sub txtTDSRate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTDSRate.Validating
        txtTDSRate.Text = String.Format("{0:f2}", Val(txtTDSRate.Text))
        calc()
    End Sub


#End Region





   
    Private Sub btnISave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnISave.Click

    End Sub
End Class
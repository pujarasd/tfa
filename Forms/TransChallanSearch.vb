Public Class TransChallanSearch
    Friend id As Integer
    Friend bookid As Integer
    Dim dtchallan As DataTable
    Dim dvchallan As DataView
    Private Sub TransChallanSearch_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Width = Me.Owner.Width
        Me.Height = Me.Owner.Height
        Me.Left = Owner.Left
        Me.Top = Owner.Top
        Me.dgv.Width = Me.Width - 10 - Me.dgv.Left
        Me.dgv.Height = Me.Height - 50 - btnClose.Height - dgv.Top

        Dim qstr As String = _
       <string>
            Select b.ledger customer,
            c.city cityfrom, 
            d.city cityto,
            p.city payableat,
           
            t.ledger transporter, 
            a.* from ttchallan a 
            inner join mledger b on b.id = a.custid 
		    inner join mcity c on c.id = a.cityfrom 
		    inner join mcity d on d.id = a.cityto
            inner join mcity p on p.id = a.payableat
            
            inner join mledger t on t.id = a.transportid 
          where bookid= <%= bookid %>  and coid = <%= gCoId %>
            and date&gt;='<%= sqldate(gFinStartDate) %>' and date&lt;='<%= sqldate(gFinEndDate) %>'
           order by challan
           </string>
        dtchallan = dbTable(qstr)
        dvchallan = dtchallan.DefaultView
        dgvdefault(dgv)

        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        With dgv.Columns
            .Add("Id", "Id")
            .Add("Challan", "Challan No.")
            .Add("Date", "Date")
            .Add("Customer", "Customer")
            .Add("GrossAmt", "Gross Amount")
            .Add("payable", "Payable Amount")
            .Add("Transporter", "Transporter")

            .Add("Driver", "Driver")
            .Add("Owner", "Owner")
            .Add("Invno", "Inv.No.")
            .Add("Shipno", "Ship No")
            .Add("dino", "DI No.")
            .Add("PayableAt", "PayableAt")
            .Add("From", "From")
            .Add("To", "To")

        End With
        With dgv
            With .Columns("ID")
                .DataPropertyName = "ID"
                .Visible = False
            End With

            With .Columns("Challan")
                .DataPropertyName = "Challan"
            End With
            With .Columns("Date")
                .DataPropertyName = "Date"
                .CellTemplate.Style.Format = "dd/MMM/yyyy"
            End With
            With .Columns("Customer")
                .DataPropertyName = "Customer"
                .Width = 300
            End With
            With .Columns("GrossAmt")
                .DataPropertyName = "GrossAmount"
                .Width = 80
                .CellTemplate.Style.Format = "n2"
            End With
            With .Columns("payable")
                .DataPropertyName = "payable"
                .Width = 80
                .CellTemplate.Style.Format = "n2"
            End With
            With .Columns("Transporter")
                .DataPropertyName = "Transporter"
                .Width = 300
            End With
           
            With .Columns("Driver")
                .DataPropertyName = "Driver"
                .Width = 100
            End With
            With .Columns("Shipno")
                .DataPropertyName = "Shipno"
                .Width = 100
            End With
            With .Columns("PayableAt")
                .DataPropertyName = "PayableAt"
                .Width = 100

            End With
            With .Columns("From")
                .DataPropertyName = "cityfrom"
                .Width = 100
            End With
            With .Columns("To")
                .DataPropertyName = "cityto"
                .Width = 100
            End With

        End With

        dgv.DataSource = dvchallan
        cmbSearchType.Items.Add(New cbItem(-1, "(Select Column)"))
        For Each COL As DataGridViewColumn In dgv.Columns
            cmbSearchType.Items.Add(New cbItem(COL.Index, COL.HeaderText))
        Next
        cmbSearchType.DisplayMember = "display"
        cmbSearchType.ValueMember = "value"
    End Sub

    

    Private Sub dgv_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        id = dgv.SelectedRows(0).Cells("Id").Value
        Me.Close()
    End Sub

    Private Sub btnAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAll.Click
        dvchallan.RowFilter = ""

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If txtSearch.Text = String.Empty Then
            dvchallan.RowFilter = ""
            Exit Sub
        End If
        If cmbSearchType.SelectedValue = -1 Then
            MsgBox("Select column")
        End If
        Dim searchcol As String = dgv.Columns(cmbSearchType.SelectedItem.value).DataPropertyName
        Dim strfilter As String = searchcol
        If dvchallan.Table.Columns(searchcol).DataType.Name.Contains("Int") Then
            strfilter &= " = " & txtSearch.Text

        ElseIf dvchallan.Table.Columns(searchcol).DataType.Name.Contains("String") Then
            strfilter &= " like '%" & txtSearch.Text & "%'"
        ElseIf dvchallan.Table.Columns(searchcol).DataType.Name.Contains("Date") Then
            Dim sdate As Date
            If Date.TryParse(txtSearch.Text, sdate) Then

                strfilter = "Convert(" & searchcol & ", 'System.DateTime') = '" & sdate & "'"
                ''strfilter = String.Format("Convert(" & searchcol & ", 'System.DateTime') = {0:M/dd/yyyy}", sdate)
            Else

                Exit Sub
            End If

        ElseIf dvchallan.Table.Columns(searchcol).DataType.Name.Contains("Decimal") Then
            strfilter &= " = " & txtSearch.Text
        ElseIf dvchallan.Table.Columns(searchcol).DataType.Name.Contains("Double") Then
            strfilter &= " = " & txtSearch.Text

        ElseIf TypeOf dvchallan(0)(searchcol) Is Boolean Then

        End If
        dvchallan.RowFilter = strfilter

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
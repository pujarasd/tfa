Public Class CompanyList
    ' Friend list As Boolean
    Private Sub CompanyList_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If gCoId = 0 Then
            If MessageBox.Show("You have not selected any company. Do you want to close the application?", "Select Company", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Application.Exit()
                Exit Sub
            Else
                e.Cancel = True
                Exit Sub
            End If

        End If
        Main.miCompany.Enabled = True
    End Sub

    Private Sub Company_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AccountsDataSet.mCompany' table. You can move, or remove it, as needed.
        dgvdefault(dgv)
        dgv.AutoGenerateColumns = True
        fill_dgv()
        Main.miCompany.Enabled = False
        '    If list Then
        btnClose.Text = "&Select"
        ' Else
        '  btnClose.Text = "&Close"
        '  End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim ofrm As New CompanyData
        ofrm.id = 0
        ofrm.mode = enDatamode.Add
        ofrm.ShowDialog()
        fill_dgv()

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If dgv.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select company", Me.Text)
            Exit Sub
        End If
        Dim ofrm As New CompanyData

        ofrm.id = dgv.SelectedRows(0).Cells(0).Value
        ofrm.mode = enDatamode.Edit
        ofrm.ShowDialog()
        fill_dgv()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        With Application.OpenForms
            If .Count > 2 Then
                Dim openformlist As String = ""
                For i = 0 To Application.OpenForms.Count - 1
                    If Not ("main_login_companylist".Contains(.Item(i).Name.ToLower)) Then
                        openformlist &= .Item(i).Name & vbCrLf

                    End If
                Next
                If openformlist <> "" Then
                    MessageBox.Show("Please close forms " & openformlist, "Select Company", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
        End With
        '   If list Then
        With dgv.SelectedRows
            If .Count = 0 Then
                MessageBox.Show("Please select company", Me.Text)
                Exit Sub
            End If
            With .Item(0)
                gCoId = .Cells("Id").Value
                gCompany = .Cells("Company").Value
                gBookStart = .Cells("book_start").Value
                gFYStart = .Cells("fy_start").Value
            End With
        End With
        '   End If
        Me.Close()

    End Sub

    Private Sub fill_dgv()
        dgv.DataSource = dbTable("select id,company,book_start,fy_start from mcompany order by company")
        dgv.Columns("Id").Visible = False
        dgv.Columns(1).HeaderText = "Company"
        dgv.Columns(1).Width = 300
        dgv.Columns(2).HeaderText = "Book Start"
        dgv.Columns(3).HeaderText = "FY Start"

    End Sub
End Class
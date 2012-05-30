Public Class DataGridViewEnter
    Inherits DataGridView
    'This override causes the DataGridView to use the enter key in a similar way as
    'the tab key
    Private _attachlist As ArrayList

    Public WriteOnly Property attachlist() As ArrayList
        Set(ByVal value As ArrayList)
            _attachlist = value
        End Set
    End Property
    Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
        Dim key As Keys = (keyData And Keys.KeyCode)

        If key = Keys.Enter Then
            Return Me.ProcessRightKey(keyData)
        End If
        Return MyBase.ProcessDialogKey(keyData)
    End Function


    Public Shadows Function ProcessRightKey(ByVal keyData As Keys) As Boolean
        Dim key As Keys = (keyData And Keys.KeyCode)

        If key = Keys.Down Then
            '    If MyBase.CurrentCell.ColumnIndex = MyBase.Columns("Account").Index Then
            If MyBase.CurrentCell.IsInEditMode Then
                If _attachlist IsNot Nothing Then
                    Dim _isListFound As Boolean
                    For i = 0 To _attachlist.Count - 1
                        If _attachlist(i)(0).ToString.ToUpper = MyBase.Columns(MyBase.CurrentCell.ColumnIndex).Name.ToUpper Then
                            '  MyBase.EndEdit()
                            Dim ctl As Control = MyBase.Parent.Controls(_attachlist(i)(1).ToString)
                            ctl.Visible = True
                            ctl.Focus()
                            _isListFound = True
                        End If
                    Next
                    If _isListFound Then Return True
                    Return MyBase.ProcessDownKey(keyData)
                Else
                    Return MyBase.ProcessDownKey(keyData)
                End If
            Else
                Return MyBase.ProcessDownKey(keyData)
            End If
        End If

        '  
        '      End If
        If key = Keys.Enter Then
            If (MyBase.CurrentCell.ColumnIndex = (MyBase.ColumnCount - 1)) AndAlso (MyBase.CurrentCell.RowIndex = (MyBase.RowCount - 1) AndAlso MyBase.ReadOnly = False) Then

                'This causes the last cell to be checked for errors
                MyBase.EndEdit()
                If MyBase.DataSource IsNot Nothing Then
                    DirectCast(MyBase.DataSource, BindingSource).AddNew()
                Else
                    MyBase.Rows.Add()
                End If

                MyBase.CurrentCell = MyBase.Rows(MyBase.RowCount - 1).Cells(0)
                Return True
            End If

            If (MyBase.CurrentCell.ColumnIndex = (MyBase.ColumnCount - 1)) AndAlso (MyBase.CurrentCell.RowIndex + 1 <> MyBase.NewRowIndex AndAlso MyBase.ReadOnly = False) Then
                MyBase.CurrentCell = MyBase.Rows(MyBase.CurrentCell.RowIndex + 1).Cells(0)
                Return True
            End If
            Return MyBase.ProcessRightKey(keyData)
        End If
        Return MyBase.ProcessRightKey(keyData)
    End Function


    Protected Overrides Function ProcessDataGridViewKey(ByVal e As KeyEventArgs) As Boolean

        If e.KeyCode = Keys.Enter Then
            Return Me.ProcessRightKey(e.KeyData)
        ElseIf e.KeyCode = Keys.Down Then
            Return Me.ProcessRightKey(e.KeyData)
        End If

        Return MyBase.ProcessDataGridViewKey(e)
    End Function


End Class

Public Class DataGridViewEnter
    Inherits DataGridView
    'This override causes the DataGridView to use the enter key in a similar way as
    'the tab key


    Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
        Dim key As Keys = (keyData And Keys.KeyCode)

        If key = Keys.Enter Then
            Return Me.ProcessRightKey(keyData)
        End If
        Return MyBase.ProcessDialogKey(keyData)
    End Function


    Public Shadows Function ProcessRightKey(ByVal keyData As Keys) As Boolean
        Dim key As Keys = (keyData And Keys.KeyCode)

            If key = Keys.Enter Then
            If (MyBase.CurrentCell.ColumnIndex = (MyBase.ColumnCount - 1)) AndAlso (MyBase.CurrentCell.RowIndex = (MyBase.RowCount - 1) AndAlso MyBase.ReadOnly = False) Then

                'This causes the last cell to be checked for errors
                MyBase.EndEdit()
                DirectCast(MyBase.DataSource, BindingSource).AddNew()

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
        End If
        Return MyBase.ProcessDataGridViewKey(e)
    End Function


End Class

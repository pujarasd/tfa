Public Class cbItem
    Private _value As Integer
    Private _display As String
    Public Sub New(ByVal value, ByVal display)
        Me.value = value
        Me.display = display
    End Sub

    Public Property value() As Integer
        Get
            Return _value
        End Get
        Set(ByVal value As Integer)
            _value = value
        End Set
    End Property
    Public Property display() As String
        Get
            Return _display
        End Get
        Set(ByVal value As String)
            _display = value
        End Set
    End Property
End Class

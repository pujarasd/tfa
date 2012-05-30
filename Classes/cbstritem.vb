Public Class cbstritem

    Private mdisplay As String
    Private mvalue As String

    Public Property display() As String
        Get
            Return mdisplay
        End Get
        Set(ByVal value As String)
            mdisplay = value
        End Set
    End Property

    Public Property value() As String
        Get
            Return mvalue
        End Get
        Set(ByVal value As String)
            mvalue = value
        End Set
    End Property

    Public Sub New(ByVal display, ByVal value)
        Me.display = display & ""
        Me.value = value & ""
    End Sub

End Class



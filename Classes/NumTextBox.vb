Imports System.ComponentModel
Public Class NumTextBox
    Inherits TextBox
    Dim _dec As Short
    Dim _value As Double
    Dim _format As String
    Dim _AllowNegative As Boolean
    <NotifyParentProperty(True)> _
    <Browsable(True), DefaultValue(0)> _
    Property value() As Double
        Get
            Return _value
        End Get
        Set(ByVal value As Double)
            _value = value
            Text = String.Format(IIf(_format Is Nothing, "{0:N" & _dec & "}", _format), value)
        End Set
    End Property
    Sub New()
        MyBase.TextAlign = HorizontalAlignment.Right
        dec = 2
    End Sub
    <Browsable(True), DefaultValue("{0:N2")> _
    <Description("Numeric format eg. {0:N2}")> _
        Public Property format() As String
        Get
            Return _format
        End Get
        Set(ByVal value As String)
            _format = value
            Text = String.Format(IIf(format Is Nothing, "{0:N" & _dec & "}", format), _value)
        End Set
    End Property
    <Browsable(True), DefaultValue(False)> _
      Public Property AllowNegative() As Boolean
        Get
            Return _allownegative
        End Get
        Set(ByVal value As Boolean)
            _allownegative = value
        End Set
    End Property

    <Browsable(True), DefaultValue(2)> _
    Public Property dec() As Short
        Get
            Return _dec
        End Get
        Set(ByVal value As Short)
            _dec = value
        End Set
    End Property

   
    Private Sub NumTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Back)
            Case ChrW(Keys.Enter)
                If Me.Multiline Then
                    Exit Sub
                End If
                SendKeys.Send("{TAB}")
            Case Else

                If Not (Char.IsDigit(e.KeyChar)) And (e.KeyChar <> ".") Then
                    If e.KeyChar = "-" Then
                        If Not AllowNegative Then
                            e.Handled = True
                        End If
                    Else
                        e.Handled = True
                    End If

                Else
                    If e.KeyChar = "." And Me.Text.Contains(".") Then
                        e.Handled = True
                    End If
                End If

        End Select

    End Sub

   



    Private Sub NumTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Validating
        value = Val(Me.Text.Replace(",", ""))
        Me.Text = String.Format(IIf(_format Is Nothing, "{0:N" & _dec & "}", _format), value)

    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'NumTextBox
        '
        Me.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ResumeLayout(False)

    End Sub
End Class

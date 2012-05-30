Imports Microsoft.VisualBasic



Public Class Num2Word
    Private Num As Decimal
    Public Property Number() As Decimal
        Get
            Return Num
        End Get
        Set(ByVal value As Decimal)
            Num = value
        End Set
    End Property

    Public Function getSecondary() As String
        Dim amt As String = String.Format("{0:0.00}", Number)
        Dim unit As String = amt.Split(".")(1)
        amt = amt.Split(".")(0)
        unit = num2word(unit)
        Return unit
    End Function
    Public Function getPrimaryIndian() As String
        Dim Minus As Boolean
        If Number < 0 Then
            Minus = True
            Number = Math.Abs(Number)
        End If
        Dim amt As String = String.Format("{0:0.00}", Number)
        Dim unit As String = amt.Split(".")(1)
        amt = amt.Split(".")(0)
        amt = Right("000000000" & amt, 9)
        Dim crore As String = num2word(amt.Substring(0, 2))
        Dim lac As String = num2word(amt.Substring(2, 2))
        Dim thousand As String = num2word(amt.Substring(4, 2))
        Dim hundred As String = num2word("0" & amt.Substring(6, 1))
        Dim num As String = num2word(amt.Substring(7, 2))
        amt = IIf(crore.Trim.Length > 0, crore & " Crore ", "")
        amt &= IIf(lac.Trim.Length > 0, lac & " lac ", "")
        amt &= IIf(thousand.Trim.Length > 0, thousand & " thousand ", "")
        amt &= IIf(hundred.Trim.Length > 0, hundred & " hundred ", "")
        amt &= IIf(num.Trim.Length > 0, num, "")
        If Minus Then amt = "(-) " & amt
        Return amt

    End Function
    Public Function getPrimaryAmerican() As String
        Dim amt As String = String.Format("{0:0.00}", Number)
        Dim unit As String = amt.Split(".")(1)
        amt = amt.Split(".")(0)
        amt = Right("0000000000" & amt, 10)
        Dim Billion As String = num2word(amt.Substring(0, 2))
        Dim Million As String = num2word(amt.Substring(2, 2))
        Dim thousandHundred As String = num2word(amt.Substring(4, 1))
        Dim Thousand As String = num2word(amt.Substring(5, 2))
        Dim hundred As String = num2word("0" & amt.Substring(7, 1))
        Dim num As String = num2word(amt.Substring(8, 2))
        amt = IIf(Billion.Trim.Length > 0, Billion & " Billion ", "")
        amt &= IIf(Million.Trim.Length > 0, Million & " Million ", "")
        amt &= IIf(thousandHundred.Trim.Length > 0, thousandHundred & " Hundred ", "")
        amt &= IIf(Thousand.Trim.Length > 0, Thousand & " Thousand ", "")
        amt &= IIf(hundred.Trim.Length > 0, hundred & " hundred ", "")
        amt &= IIf(num.Trim.Length > 0, num, "")
        Return amt

    End Function

    Protected Function num2word(ByVal stramt As String) As String
        If stramt.Length = 1 Then
            stramt = retWord(CDbl(stramt))
        Else
            If stramt.Substring(0, 1) = "1" Or stramt.Substring(1, 1) = "0" Then
                stramt = retWord(CDbl(stramt))
            Else
                stramt = retWord(CDbl(stramt.Substring(0, 1)) * 10) & retWord(CDbl(stramt.Substring(1, 1)))
            End If
        End If

        Return stramt
    End Function
    Protected Function retWord(ByVal Num As Decimal) As String
        'This two dimensional array store the primary word convertion of number.
        retWord = ""
        Dim ArrWordList(,) As Object = {{0, ""}, {1, "One"}, {2, "Two"}, {3, "Three"}, {4, "Four"}, _
                                        {5, "Five"}, {6, "Six"}, {7, "Seven"}, {8, "Eight"}, {9, "Nine"}, _
                                        {10, "Ten"}, {11, "Eleven"}, {12, "Twelve"}, {13, "Thirteen"}, {14, "Fourteen"}, _
                                        {15, "Fifteen"}, {16, "Sixteen"}, {17, "Seventeen"}, {18, "Eighteen"}, {19, "Nineteen"}, _
                                        {20, "Twenty"}, {30, "Thirty"}, {40, "Forty"}, {50, "Fifty"}, {60, "Sixty"}, _
                                        {70, "Seventy"}, {80, "Eighty"}, {90, "Ninety"}, {100, "Hundred"}, {1000, "Thousand"}, _
                                        {100000, "Lakh"}, {10000000, "Crore"}}

        Dim i As Integer
        For i = 0 To UBound(ArrWordList)
            If Num = ArrWordList(i, 0) Then
                retWord = ArrWordList(i, 1)
                Exit For
            End If
        Next
        Return retWord
    End Function
End Class



Module modGlobal
    Public gUserName As String = ""
    Public gUserId As Integer = 0
    Public gAdmin As Boolean = False
    Public gCompany As String = ""
    Public gCoId As Integer = 0
    Public gDbName As String = ""
    Public gBookStart As Date
    Public gFYStart As Date
    Public gServerpath As String = Configuration.ConfigurationManager.AppSettings("serverpath")
    Public gDataPath As String = addbs(gServerpath)
    Public gReportPath As String = addbs(gServerpath) & "reports\"
    Public gIsClient As Boolean = False
    ''Code done by Gaurav on dt 23/03/2012  --- user rights
    Public gMasteradd As Boolean = False
    Public gMasterEdit As Boolean = False
    Public gMasterDelete As Boolean = False
    Public gMasterView As Boolean = False
    Public gVoucheradd As Boolean = False
    Public gVoucherEdit As Boolean = False
    Public gVoucherDelete As Boolean = False
    Public gVoucherview As Boolean = False
    Public gBs As Boolean = False
    Public gPl As Boolean = False
    Public gtb As Boolean = False

    ''Till Here
 
    Public Enum enDatamode
        none
        Add
        Edit
        View
        Delete
        Print
        Report
    End Enum
    Public Enum enEntry
        none
        Add
        Edit
        View
        Delete
        Print
        Report
    End Enum
    Public Enum enNavMode
        none
        FirstRec
        PrevRec
        NextRec
        LastRec

    End Enum
    'Public Enum enChargeOn
    '    Actual
    '    Value
    '    PreviousAmount
    '    SubTotal
    'End Enum

    Public gFinStartDate As Date = CDate("01-April-" & IIf(Month(Now.Date) < 4, Year(Now.Date) - 1, Year(Now.Date)))
    Public gFinEndDate As Date = CDate("31-March-" & IIf(Month(Now.Date) < 4, Year(Now.Date), Year(Now.Date) + 1))
    Public gPeriod As String = Year(gFinStartDate) & "-" & Year(gFinEndDate)

    Public Enum enLedger
        Debtors = 17
        Creditors = 16
        Cash = 38
        Bank = 39
        Sale = 21
        Purchase = 25
        CashBank = 19
    End Enum
    Public Enum enRateOn
        None
        Actual
        Previous
        SubTotal
        Value
    End Enum
    Public Enum enCityType
        ToCity
        FromCity
        PayableAtCity
    End Enum
End Module

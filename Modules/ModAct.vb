Imports System.Data.OleDb
Imports System.Data

Module ModAct

    Public Function checkreg(Optional ByVal akey As Long = 0) As Boolean
        Dim sr As String = getsrno()
        Dim num1 As Short = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".IndexOf(sr.Substring(0, 1))
        Dim num2 As Long = CLng(sr.Substring(1, Len(sr) - 1))
        Dim dt As New DataTable
        Dim secconn As New OleDbConnection
        If Not IO.File.Exists(gdatapath & "WinSecure.mdb") Then
            MsgBox("Wrong Data Path", 0)
            Return False
        End If
        secconn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & gDataPath & "WinSecure.mdb;Jet OLEDB:Database Password=gaupuja;"
        secconn.Open()
        Dim comm As New OleDbCommand
        comm.Connection = secconn
        comm.CommandText = "Select * from Activation"
        dt.Load(comm.ExecuteReader)
        If dt.Rows(0)("rkey") <> sr Then
            comm.CommandText = "Update Activation set rkey='" & sr & "',akey=" & 0 & ",users=1"
        End If
        If akey = 0 Then
            akey = nz(dt.Rows(0)("akey"), 0)
        End If
        Dim dtakey As Double = nz(dt.Rows(0)("akey"), 0)
        Dim users = dt.Rows(0)("users")
        dt.Clear()
        dt = Nothing
        If ((num2 * num1) + num1) + users = akey Then
            If dtakey <> CDbl(akey) Then
                comm.CommandText = "Update Activation set akey=" & akey & " where rkey='" & sr & "'"
                comm.ExecuteNonQuery()
            End If
            Return True
        Else
            comm.CommandText = "Update Activation set akey=" & 0 & " where rkey='" & sr & "'"
            comm.ExecuteNonQuery()
            Return False
        End If
    End Function
    Function NoOfUsers() As Integer
        Dim secconn As New OleDbConnection
        secconn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & gDataPath & "\WinSecure.mdb;Jet OLEDB:Database Password=gaupuja;"
        secconn.Open()
        Dim comm As New OleDbCommand
        comm.Connection = secconn
        comm.CommandText = "Select users from Activation"
        Return nz(comm.ExecuteScalar(), 1)
    End Function
    Function getsrno() As String

        Dim minfo As New ComputerInfo
        Dim P As String = minfo.GetProcessorId()
        Dim M As String = minfo.GetMotherBoardID()
        Dim N As String = minfo.GetMACAddress()
        Dim v As String = minfo.GetVolumeSerial
        Dim sr As String = ""
        If P.Length > 0 Then
            sr = "P" & calcsr(P)
        ElseIf M.Length > 0 Then
            sr = "M" & calcsr(M)
        ElseIf N.Length > 0 Then
            sr = "N" & calcsr(N)
        ElseIf v.Length > 0 Then
            sr = "N" & calcsr(v)
        Else
            sr = "T" & Now().Year & Now().Month & Now().Day & Now.Hour & Now.Minute & Now.Second & Now.Millisecond
        End If
        Return sr
    End Function
    Private Function calcsr(ByVal y As String) As Long
        Dim ay As Char() = y.ToCharArray()
        Dim x As String = ""
        For i = 0 To UBound(ay)
            If Char.IsLetter(ay(i)) Then
                x &= "ABCDEFGHIJKLMNOPQRSTUVWXYZ".IndexOf(Char.ToUpper(ay(i)))
            ElseIf ay(i) = "0" Then
                x &= ""
            Else

                x &= ay(i)
            End If
        Next
        Return CLng(x)
    End Function

    Function updatenoofusers(ByVal num As Integer) As Boolean
        Dim secconn As New OleDbConnection
        secconn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & gDataPath & "\WinSecure.mdb;Jet OLEDB:Database Password=gaupuja;"
        secconn.Open()
        Dim comm As New OleDbCommand
        comm.Connection = secconn
        comm.CommandText = "Update activation set users =" & num
        If comm.ExecuteNonQuery() > 0 Then Return True
        Return False

    End Function
    Function getactrecord() As DataTable
        Dim dt As New DataTable
        Dim secconn As New OleDbConnection
        secconn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & gDataPath & "\WinSecure.mdb;Jet OLEDB:Database Password=gaupuja;"
        secconn.Open()
        Dim comm As New OleDbCommand
        comm.Connection = secconn
        comm.CommandText = "Select * from activation"
        dt.Load(comm.ExecuteReader(CommandBehavior.CloseConnection))
        Return dt
    End Function
    Function updateactstartdate(ByVal startdate As DateTime)
        Try

            Dim secconn As New OleDbConnection
            secconn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & gDataPath & "\WinSecure.mdb;Jet OLEDB:Database Password=gaupuja;"
            secconn.Open()
            Dim comm As New OleDbCommand
            comm.Connection = secconn
            comm.CommandText = "update activation set startdate=#" & sqldate(startdate) & "#"
            comm.ExecuteNonQuery()
            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function
    Function updateacttodate() As Boolean
        Try
            Dim secconn As New OleDbConnection

            secconn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & gDataPath & "\WinSecure.mdb;Jet OLEDB:Database Password=gaupuja;"
            secconn.Open()
            Dim comm As New OleDbCommand
            comm.Connection = secconn
            comm.CommandText = "update activation set todate = #" & sqldate(Now.Date) & "#"
            comm.ExecuteNonQuery()
            Return True

        Catch ex As Exception

        End Try
        Return False

    End Function

End Module

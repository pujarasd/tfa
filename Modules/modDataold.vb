Imports System.Data.SqlClient
Imports System.Configuration
Imports Microsoft.SqlServer.Management

Module modData
 
    Dim conn As SqlConnection
    Function dbconnect(ByVal company As Boolean) As Boolean
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Account").ToString  '' My.Settings.AccountsConnectionString.ToString
        If company Then
            connstr = connstr.Replace("Accounts", "AccCommon")
        Else
            connstr = connstr.Replace("Accounts", gDbName)
        End If
        Try

            If conn Is Nothing Then
                conn = New SqlConnection
            Else
                If conn.State <> ConnectionState.Open Then
                    conn.Close()
                End If
                conn = Nothing
                conn = New SqlConnection
            End If
            conn.ConnectionString = connstr
            conn.Open()
            Return True
        Catch ex As Exception
            MsgBox("Data connection failed!!!" & vbCrLf & ex.ToString)
            Return False
        End Try

    End Function

    Function dbTable(ByVal query As String, Optional ByVal company As Boolean = False) As DataTable
        Dim dt As New DataTable
        Dim cmd As New SqlCommand
        Try

            If dbconnect(company) Then
                cmd.Connection = conn
                cmd.CommandText = query
                dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection))
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd = Nothing
            conn.Close()
        End Try
        Return dt
    End Function
    Function dbUpdate(ByVal query() As String, Optional ByVal company As Boolean = False) As Boolean
        Dim cmd As New SqlCommand

        Dim trans As SqlTransaction = Nothing

        Try

            If dbconnect(company) Then

                cmd.Connection = conn
                trans = conn.BeginTransaction()
                cmd.Transaction = trans
                For i As Int16 = 0 To query.Length - 1
                    cmd.CommandText = query(i)
                    cmd.ExecuteNonQuery()
                Next
                trans.Commit()
                Return True
            End If

        Catch ex As Exception
            MessageBox.Show("Update failed" & vbCrLf & ex.ToString)
            If trans Is Nothing Then
            Else
                trans.Rollback()
            End If

            Return False
        Finally
            trans = Nothing
            cmd = Nothing
            conn.Close()
        End Try

    End Function
    Function dbValue(ByVal query As String, Optional ByVal company As Boolean = False) As Object
        Dim cmd As New SqlCommand
        Dim retval As Object = Nothing
        Try

            If dbconnect(company) Then

                cmd.Connection = conn

                cmd.CommandText = query
                retval = cmd.ExecuteScalar()

            End If

        Catch ex As Exception
            MessageBox.Show(vbCrLf & ex.ToString)

        Finally
            cmd = Nothing
            conn.Close()
        End Try
        Return retval
    End Function
    Public Sub SetDefaultClearNull(ByRef p_DBTable As DataTable)
        If p_DBTable Is Nothing Then Exit Sub

        Try
            ' --- Section 1 - Set default value for new record.
            ' --- If we don't want to set default value, just delete or comment this section.
            For j As Integer = 0 To p_DBTable.Columns.Count - 1
                If (p_DBTable.Columns.Item(j).DataType.Name = "String") _
                Or (p_DBTable.Columns.Item(j).DataType.Name = "Char") Then
                    p_DBTable.Columns.Item(j).DefaultValue = ""
                ElseIf (p_DBTable.Columns.Item(j).DataType.Name = "Decimal") _
                    Or (p_DBTable.Columns.Item(j).DataType.Name = "Int32") _
                            Or (p_DBTable.Columns.Item(j).DataType.Name = "Int64") _
                            Or (p_DBTable.Columns.Item(j).DataType.Name = "Byte") _
                            Or (p_DBTable.Columns.Item(j).DataType.Name = "Double") _
                            Or (p_DBTable.Columns.Item(j).DataType.Name = "Int16") _
                            Or (p_DBTable.Columns.Item(j).DataType.Name = "Single") Then
                    Try
                        p_DBTable.Columns.Item(j).DefaultValue = 0
                    Catch
                    End Try
                ElseIf (p_DBTable.Columns.Item(j).DataType.Name = "DateTime") Then
                        p_DBTable.Columns.Item(j).DefaultValue = Now
                ElseIf (p_DBTable.Columns.Item(j).DataType.Name = "Boolean") Then
                        p_DBTable.Columns.Item(j).DefaultValue = False
                End If
            Next j

            ' --- Section 2 - Clear null in Data Table to desirable value.
            For i As Long = 0 To p_DBTable.Rows.Count - 1
                For j As Integer = 0 To p_DBTable.Columns.Count - 1
                    If (p_DBTable.Columns.Item(j).DataType.Name = "String") _
                    Or (p_DBTable.Columns.Item(j).DataType.Name = "Char") Then
                        If IsDBNull(p_DBTable.Rows(i)(j)) Then
                            p_DBTable.Rows(i)(j) = ""
                        Else
                            p_DBTable.Rows(i)(j) = Trim(p_DBTable.Rows(i)(j))
                        End If
                    ElseIf (p_DBTable.Columns.Item(j).DataType.Name = "Decimal") _
                        Or (p_DBTable.Columns.Item(j).DataType.Name = "Int32") _
                        Or (p_DBTable.Columns.Item(j).DataType.Name = "Int64") _
                        Or (p_DBTable.Columns.Item(j).DataType.Name = "Byte") _
                        Or (p_DBTable.Columns.Item(j).DataType.Name = "Double") _
                        Or (p_DBTable.Columns.Item(j).DataType.Name = "Int16") _
                        Or (p_DBTable.Columns.Item(j).DataType.Name = "Single") Then
                        If IsDBNull(p_DBTable.Rows(i)(j)) Then
                            p_DBTable.Rows(i)(j) = 0
                        End If
                    ElseIf (p_DBTable.Columns.Item(j).DataType.Name = "DateTime") Then
                        If IsDBNull(p_DBTable.Rows(i)(j)) Then
                            p_DBTable.Rows(i)(j) = Now
                        End If
                    ElseIf (p_DBTable.Columns.Item(j).DataType.Name = "Boolean") Then
                        If IsDBNull(p_DBTable.Rows(i)(j)) Then
                            p_DBTable.Rows(i)(j) = False
                        End If
                    End If
                Next j
            Next i
        Catch ex As Exception
            ' --- Some column type such as computation column or some column hasn't real data.
            ' --- Maybe it has error for this operation. 
            ' --- Although, if we use try...catch, it will be OK. I use this function with my projects. 
        End Try

    End Sub

    Function CreateCompanyDatabase() As Boolean
        Try

            Dim qstr As String = ""
            qstr = "select * from [master].dbo.sysdatabases where name = '" & gDbName & "'"
            If nz(dbValue(qstr, True), "") = "" Then
                qstr = <string>
            USE [master];
            CREATE DATABASE <%= gDbName %> ON  PRIMARY 
            ( NAME = N'<%= gDbName %>', FILENAME = N'<%= addbs(gServerpath) & gDbName %>.mdF' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
            LOG ON 
            ( NAME = N'Accounts_log', FILENAME = N'<%= addbs(gServerpath) & gDbName %>_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
            COLLATE SQL_Latin1_General_CP1_CI_AS;
            EXEC dbo.sp_dbcmptlevel @dbname=N'Accounts', @new_cmptlevel=90;
            select * from [master].dbo.sysdatabases where name = '<%= gDbName %>'
            </string>
                If Not IO.Directory.Exists(gServerpath) Then
                    IO.Directory.CreateDirectory(gServerpath)

                End If
                dbValue(qstr, True)

            End If
            qstr = "select name from [master].dbo.sysdatabases where name = '" & gDbName & "'"
            If nz(dbValue(qstr), "") <> "" Then
                If nz(dbValue("use " & gDbName & ";select count(name) from sys.tables where type='u'"), 0) = 0 Then


                    qstr = IO.File.ReadAllText("BLANKDATABASE.TXT")
                    Dim aqstr As String() = qstr.Split(New String() {"~"}, StringSplitOptions.RemoveEmptyEntries)
                    If Not dbUpdate(aqstr) Then
                        MessageBox.Show("Error Creating Tables in Company Database", "Create Company Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                    qstr = IO.File.ReadAllText("InsertRecord.TXT")
                    aqstr = qstr.Split(New String() {"~"}, StringSplitOptions.RemoveEmptyEntries)
                    If Not dbUpdate(aqstr) Then
                        MessageBox.Show("Error Creating Master Records in Company Database", "Create Company Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                    qstr = "Insert into mledger (Ledger,date,Amount,groupid) values ('Cash','" & sqldate(gFYStart) & "',0,19)"
                    If Not dbUpdate(New String() {qstr}) Then
                        MessageBox.Show("Error Creating Master Records in Company Database", "Create Company Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False

                    End If
                End If
            Else
                MessageBox.Show("Error Creating Tables in Company Database", "Create Company Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show("Error Creating New Company Database" & vbCrLf & ex.Message, "Create Company Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function
End Module

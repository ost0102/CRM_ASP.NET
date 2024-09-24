Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Exception
Imports System.Collections.Generic
Imports System.Data.OracleClient
Imports YJIT.Data

Namespace YJIT.BIZ

    Public Class dbCommon

        'Private _isMidTrans As Boolean = False
        'Private _strConn As String
        'Private IP As String
        'Private port As String
        'Private SID As String
        'Private userID As String
        'Private password As String


        'Private _orclConn As OracleConnection
        'Private _orclAdoCmd As OracleCommand
        'Private _orclTrans As OracleTransaction
        'Private _orclAdapter As OracleDataAdapter





        'Public Sub SetConnection(ByVal pIP As String, ByVal pPort As String, ByVal pSID As String, ByVal pUserID As String, ByVal pPassword As String)

        '    IP = pIP
        '    port = pPort
        '    SID = pSID
        '    userID = pUserID
        '    password = pPassword

        'End Sub

        'Public Function connString() As String

        '    Dim conn As String =
        '        "Data Source=" &
        '            "(DESCRIPTION=(CID=GTU_APP)" &
        '                "(ADDRESS_LIST=" &
        '                        "(ADDRESS=" &
        '                                "(PROTOCOL=TCP)(HOST=" & IP & ")(PORT=" & port & ")" &
        '                        ")" &
        '                ")(CONNECT_DATA=(SERVICE_NAME=" & SID & ")(SERVER=DEDICATED))" &
        '            ");User Id=" & userID & ";Password=" & password & ";"
        '    Return conn
        'End Function


        'Public Sub conOpen()

        '    If _orclConn Is Nothing Then
        '        _strConn = connString()

        '        _orclConn = New OracleConnection()
        '        _orclConn.ConnectionString = _strConn
        '        _orclConn.Open()
        '    End If

        '    If _orclConn.State = ConnectionState.Closed Or _orclConn.State = ConnectionState.Broken Then
        '        _orclConn.Close()
        '        _orclConn.Dispose()

        '        _orclConn = New OracleConnection()
        '        _orclConn.ConnectionString = _strConn
        '        _orclConn.Open()
        '    End If

        'End Sub

        'Public Sub conClose()
        '    If Not _isMidTrans Then
        '        If _orclConn.State <> ConnectionState.Closed Then
        '            _orclConn.Close()
        '        End If
        '    End If
        'End Sub

        'Public Sub conEndClose()
        '    If _orclConn.State <> ConnectionState.Closed Then
        '        _orclConn.Close()
        '    End If
        '    _orclConn.Dispose()
        'End Sub

        'Public Sub BeginTransaction()
        '    conOpen()

        '    _orclTrans = _orclConn.BeginTransaction()
        '    _isMidTrans = True
        'End Sub

        'Public Sub Commit()
        '    If _isMidTrans Then
        '        _orclTrans.Commit()
        '    End If
        'End Sub

        'Public Sub Rollback()
        '    If _isMidTrans Then
        '        _orclTrans.Rollback()
        '    End If
        'End Sub

        'Public Sub EndTransaction()
        '    If _isMidTrans Then
        '        _orclTrans.Dispose()
        '    End If

        '    conEndClose()
        'End Sub

        'Public Function DBConnect_Check() As Boolean

        '    Dim orclConn As New OracleConnection()
        '    Dim returnValue As Boolean = False

        '    Try
        '        Dim strConn = connString()
        '        orclConn.ConnectionString = strConn
        '        orclConn.Open()

        '        If orclConn.State.ToString = "Open" Then
        '            returnValue = True
        '        End If
        '        orclConn.Close()
        '        orclConn.Dispose()
        '    Catch ex As Exception
        '        orclConn.Close()
        '        orclConn.Dispose()
        '        Throw New Exception(ex.ToString())
        '    End Try

        '    Return returnValue

        'End Function

        'Public Function SqlGet(ByVal strQuery As String) As DataTable



        '    Dim ds = New DataSet()
        '    Dim dt = New DataTable()

        '    Try
        '        conOpen()
        '        _orclAdapter = New OracleDataAdapter(strQuery, _orclConn)
        '        _orclAdapter.Fill(ds, "resultTable")

        '        dt = ds.Tables("resultTable")

        '    Catch ex As Exception
        '        Throw New Exception(ex.ToString())
        '    Finally
        '        conClose()
        '    End Try

        '    EndTransaction()

        '    Return dt

        'End Function

        'Public Function SqlSet(ByVal strQuery As String) As Integer

        '    Dim setCount As Integer = 0


        '    Try
        '        conOpen()
        '        _orclAdoCmd = New OracleCommand(strQuery, _orclConn)
        '        _orclAdoCmd.Transaction = _orclTrans

        '        setCount = _orclAdoCmd.ExecuteNonQuery()

        '    Catch ex As Exception

        '        Throw New Exception(ex.ToString())

        '    Finally
        '        conClose()
        '    End Try

        '    Return setCount

        'End Function

    End Class


End Namespace

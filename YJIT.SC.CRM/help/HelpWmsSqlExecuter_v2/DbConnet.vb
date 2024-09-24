Imports System.Data.OracleClient
Imports System.Data.SqlClient 
'C:\Program Files(x86)\Microsoft Visual Studio 10.0\Visual Studio Tools for Office\PIA\Common\adodb.dll
Public Class DbConnet
    Public oConn As OracleClient.OracleConnection '컨넥션 개체
    Public oCmd As New OracleClient.OracleCommand '커맨드 개체

    Dim _Ip As String
    Dim _Port As String
    Dim _Sid As String
    Dim _UserID As String
    Dim _Password As String

    Private SqlParamDic As Dictionary(Of String, String)

    Public Property SqlParam(ByVal Param As String) As String
        Get

        End Get
        Set(ByVal value As String)
            SqlParamDic(Param) = value
        End Set
    End Property



    Public Sub New(ByVal ip As String, ByVal port As String, ByVal Sid As String, ByVal UserID As String, ByVal Password As String)
        _Ip = ip
        _Port = port
        _Sid = Sid
        _UserID = UserID
        _Password = Password

        If SqlParamDic Is Nothing Then SqlParamDic = New Dictionary(Of String, String)
    End Sub

    Public Function DbConnect() As Boolean
        Dim oraStr As String

        oraStr = "Data Source= (DESCRIPTION = "
        oraStr += " (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = " & _Ip & ")(PORT = " & _Port & ")))"
        oraStr += " (CONNECT_DATA = (SID = " & _Sid & ")(SERVER = DEDICATED))) ; "
        oraStr += "User id= " & _UserID & ";"
        oraStr += "Password= " & _Password & ";"

        oConn = New OracleClient.OracleConnection(oraStr)

        Try
            oConn.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function SetSql(ByVal SqlID As String, ByVal SqlText As String) As DataTable
        Dim xDS As New DataSet
        Dim SqlDA As OracleDataAdapter = Nothing
        Dim SqlCmd As OracleCommand = Nothing
        Dim dt As New DataTable
        Dim SqlCmdText As String = ""
        If SqlText = "" Then
            SqlCmdText = HelpCommon.GetSql(SqlID)
        Else
            SqlCmdText = SqlText
        End If

        Try

            For Each KEY In SqlParamDic.Keys
                Dim Val As String = SqlParamDic(KEY)

                SqlCmdText = SqlCmdText.Replace("'@" & KEY & "'", "'" & Val & "'")
                SqlCmdText = SqlCmdText.Replace("@" & KEY & "", "" & Val & "")

            Next
            SqlCmd = New OracleCommand(SqlCmdText, oConn)
            With SqlCmd
                .CommandType = CommandType.Text
            End With
            SqlDA = New OracleDataAdapter(SqlCmd)
            SqlDA.Fill(xDS)

            If xDS.Tables.Count > 0 Then
                dt = xDS.Tables(0)
            End If
        Catch ex As Exception
            dt.TableName = "ErrorInfo"
            dt.Columns.Add("MSG")
            dt.Rows.Add(ex.Message)

            xDS.Tables.Add(dt)
        Finally
            If (Not SqlDA Is Nothing) Then SqlDA.Dispose()
            If (Not xDS Is Nothing) Then xDS.Dispose()
            SqlCmd.Dispose()
        End Try
        DbDisConnect()
        Return dt
    End Function



    Public Sub DbDisConnect()
        Try
            oConn.Close()
            oConn.Dispose()
        Catch ex As Exception

        End Try

    End Sub
End Class




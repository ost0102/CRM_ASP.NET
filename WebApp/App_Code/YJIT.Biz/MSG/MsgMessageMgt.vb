Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports YJIT.Biz.Common
Imports System.Collections.Generic

Namespace YJIT.Biz
    Public Class MsgMessageMgt

        Public Shared Function Search(ByVal userid As String, ByVal read As String, ByVal date_from As String, ByVal date_to As String, ByVal rcvsenttype As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            Try
                Dim sql = New SqlBox("MsgMessageMgt@Search")
                sql.Params("DATE_FROM") = date_from
                sql.Params("DATE_TO") = date_to & "Z"

                If rcvsenttype = "SENT" Then
                    sql.Params("SENDER") = userid
                    sql.Blocks("SENDER") = True
                    sql.Blocks("SEND_DATE") = True
                    sql.Blocks("SELECT_SENT") = True
                Else
                    sql.Params("RECEIVER") = userid
                    sql.Blocks("RECEIVER") = True
                    sql.Params("READ_YN") = read
                    If read = "N" Then
                        sql.Blocks("NOT NULL") = True
                    Else
                        sql.Blocks("ISNULL") = True
                        sql.Blocks("SEND_DATE") = True
                    End If
                    sql.Blocks("SELECT_RECEIVED") = True
                End If

                Dim dt As DataTable = db.SqlGet(sql.Text, False)
                dt.TableName = "WG_RCV"
                resultDs.Tables.Add(dt)

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = resultDs

                'No Row에 대한 메시지는 전달하지 않음
                'If dt.Rows.Count = 0 Then
                '    ThrowMsg(ErrorOccur, "Data not found!")
                'End If

            Catch ex As Exception
                If ErrorOccur Then
                    resultSet("TrxCode") = "E"
                Else
                    resultSet("TrxCode") = "N"
                End If
                resultSet("TrxMsg") = ex.Message
            End Try

            Return resultSet
        End Function

        Public Shared Function SearchRead(ByVal msgid As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            Try
                Dim sql = New SqlBox("MsgMessageMgt@SearchDetail")
                sql.Params("MSG_ID") = msgid

                Dim dt As DataTable = db.SqlGet(sql.Text, False)
                dt.TableName = "WG_READ"
                resultDs.Tables.Add(dt)

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = resultDs

            Catch ex As Exception
                If ErrorOccur Then
                    resultSet("TrxCode") = "E"
                Else
                    resultSet("TrxCode") = "N"
                End If
                resultSet("TrxMsg") = ex.Message
            End Try

            Return resultSet
        End Function

        'Public Shared Function SearchSent(ByVal userid As String, ByVal read As String, ByVal date_from As String, ByVal date_to As String) As Dictionary(Of String, Object)
        '    Dim resultSet As New Dictionary(Of String, Object)
        '    Dim resultDs As DataSet = New DataSet
        '    Dim db As DBA = New DBA()
        '    Dim ErrorOccur As Boolean = True

        '    Try
        '        Dim sql = New SqlBox("MsgMessageMgt@SearchSent")
        '        sql.Params("SENDER") = userid
        '        sql.Params("DATE_FROM") = date_from
        '        sql.Params("DATE_TO") = date_to & "Z"

        '        Dim dt As DataTable = db.SqlGet(sql.Text, False)
        '        dt.TableName = "WG_RCV"
        '        resultDs.Tables.Add(dt)

        '        resultSet("TrxCode") = "Y"
        '        resultSet("TrxMsg") = "Success"
        '        resultSet("Data") = resultDs

        '        'No Row에 대한 메시지는 전달하지 않음
        '        'If dt.Rows.Count = 0 Then
        '        '    ThrowMsg(ErrorOccur, "Data not found!")
        '        'End If

        '    Catch ex As Exception
        '        If ErrorOccur Then
        '            resultSet("TrxCode") = "E"
        '        Else
        '            resultSet("TrxCode") = "N"
        '        End If
        '        resultSet("TrxMsg") = ex.Message
        '    End Try

        '    Return resultSet
        'End Function

        Public Shared Function GetNoReadMessageCount(ByVal userid As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            Try
                Dim sql = New SqlBox("MsgMessageMgt@GetNoReadMessageCount")
                sql.Params("RECEIVER") = userid
                sql.Params("READ_YN") = "N"
                Dim dt As DataTable = db.SqlGet(sql.Text, False)

                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If

                resultSet("MSG_CNT") = dt.Rows(0)("MSG_CNT").ToString
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"

            Catch ex As Exception
                If ErrorOccur Then
                    resultSet("TrxCode") = "E"
                Else
                    resultSet("TrxCode") = "N"
                End If
                resultSet("TrxMsg") = ex.Message
            End Try

            Return resultSet
        End Function

        Public Shared Function GetNoReadMessage(ByVal userid As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            Try
                Dim sql = New SqlBox("MsgMessageMgt@GetNoReadMessage")
                sql.Params("RECEIVER") = userid
                sql.Params("READ_YN") = "N"
                Dim dtMsg As DataTable = db.SqlGet(sql.Text, False)
                dtMsg.TableName = "RCVMSG"
                resultDs.Tables.Add(dtMsg)

                resultSet("Data") = resultDs
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"

            Catch ex As Exception
                If ErrorOccur Then
                    resultSet("TrxCode") = "E"
                Else
                    resultSet("TrxCode") = "N"
                End If
                resultSet("TrxMsg") = ex.Message
            End Try

            Return resultSet
        End Function

        Public Shared Function GetNoReadChattingList(ByVal userid As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            resultSet("TrxCode") = "E"
            resultSet("TrxMsg") = "Error"
            resultSet("Data") = resultDs

            Try
                Dim sql = New SqlBox("MsgMessageMgt@GetNoReadChattingList")
                sql.Params("RECEIVER") = userid
                sql.Params("READ_YN") = "N"
                Dim dtMsg As DataTable = db.SqlGet(sql.Text, False)
                dtMsg.TableName = "WG_CHAT_LIST"
                resultDs.Tables.Add(dtMsg)

                resultSet("Data") = resultDs
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
            Catch ex As Exception
                If ErrorOccur Then
                    resultSet("TrxCode") = "E"
                Else
                    resultSet("TrxCode") = "N"
                End If
                resultSet("TrxMsg") = ex.Message
            End Try

            Return resultSet
        End Function


        Public Shared Function GetNoReadChatting(ByVal FirstMsgID As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            Try
                Dim sql = New SqlBox("MsgMessageMgt@GetNoReadChatting")
                sql.Params("FIRST_MSG_ID") = FirstMsgID
                Dim dtMsg As DataTable = db.SqlGet(sql.Text, False)
                dtMsg.TableName = "WG_CHAT"
                resultDs.Tables.Add(dtMsg)

                resultSet("Data") = resultDs
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
            Catch ex As Exception
                If ErrorOccur Then
                    resultSet("TrxCode") = "E"
                Else
                    resultSet("TrxCode") = "N"
                End If
                resultSet("TrxMsg") = ex.Message
            End Try

            Return resultSet
        End Function

        Public Shared Function SaveMessage(ByVal domain As String, ByVal sender As String, ByVal receiver As String, ByVal systype As String, ByVal msgtype As String, ByVal jobtype As String, _
                                   ByVal msg As String, _
                                   ByVal fMsgid As String, _
                                   ByVal pMsgid As String, _
                                   ByVal key1 As String, _
                                   ByVal key2 As String, _
                                   ByVal key3 As String, _
                                   ByVal key4 As String, _
                                   ByVal key5 As String, _
                                   ByVal firstChatYN As String) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True

            db.BeginTransaction()
            Try
                Dim sql As SqlBox = Nothing

                If firstChatYN = "Y" Then
                    '최초 회신 담당자외에 DTL자료 삭제
                    sql = New SqlBox("MsgMessageMgt@DeleteChatDtl")
                    sql.Params("RECEIVER") = sender
                    sql.Params("FIRST_MSG_ID") = fMsgid
                    db.SqlSet(sql.Text)
                End If

                'Get Message Key
                Dim msgid As String = String.Empty
                sql = New SqlBox("MsgMessageMgt@GetMessageKey")
                dt = db.SqlGet(sql.Text, False)
                msgid = dt.Rows(0)("MSG_ID").ToString()
                If msgtype = "C" And String.IsNullOrEmpty(fMsgid) Then
                    fMsgid = msgid
                End If

                'Message Master
                sql = New SqlBox("MsgMessageMgt@Save")
                sql.Params("MSG_ID") = msgid
                sql.Params("DOMAIN") = domain
                sql.Params("SENDER") = sender
                sql.Params("SYS_TYPE") = systype
                sql.Params("MSG_TYPE") = msgtype
                sql.Params("JOB_TYPE") = jobtype
                sql.Params("MSG") = msg
                sql.Params("FIRST_MSG_ID") = fMsgid
                sql.Params("PARENT_MSG_ID") = pMsgid
                sql.Params("KEY1") = key1
                sql.Params("KEY2") = key2
                sql.Params("KEY3") = key3
                sql.Params("KEY4") = key4
                sql.Params("KEY5") = key5
                db.SqlSet(sql.Text)


                If receiver = "ALL" Then
                    receiver = ""
                    sql = New SqlBox("MsgMessageMgt@SearchUser")
                    dt = db.SqlGet(sql.Text, False)
                    For Each dr As DataRow In dt.Rows
                        If Not String.IsNullOrEmpty(receiver) Then receiver &= ";"
                        receiver &= dr("EMAIL").ToString
                    Next
                End If

                'Message Detail
                Dim arrRec() As String = receiver.Split(";")

                For i = 0 To arrRec.Length - 1
                    sql = New SqlBox("MsgMessageMgt@SaveDetail")
                    sql.Params("MSG_ID") = msgid
                    sql.Params("READ_YN") = "N"
                    sql.Params("READ_DATE") = ""

                    If arrRec(i) = "" Then Continue For
                    sql.Params("RECEIVER") = arrRec(i)
                    db.SqlSet(sql.Text)
                Next
                '==============================================================
                ResultSet("TrxCode") = "Y"
                '성공 유무의 메세지는 생략.
                ResultSet("TrxMsg") = "Success"
                ResultSet("FIRST_MSG_ID") = fMsgid

                db.Commit()
            Catch ex As Exception
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
                db.Rollback()
            Finally
                db.EndTransaction()
            End Try
            Return ResultSet
        End Function

        Public Shared Function SaveComplete(ByVal UserID As String, ByVal MsgID As String) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True

            db.BeginTransaction()
            Try
                Dim sql As SqlBox = Nothing

                sql = New SqlBox("MsgMessageMgt@SaveComplete")
                sql.Params("MSG_ID") = MsgID
                db.SqlSet(sql.Text)

                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
                db.Commit()
            Catch ex As Exception
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
                db.Rollback()
            Finally
                db.EndTransaction()
            End Try

            If ResultSet("TrxCode") = "Y" Then
                ResultSet("Data") = GetNoReadChattingList(UserID)("Data")
            End If

            Return ResultSet
        End Function

        Public Shared Function UpdateNoReadMessageCount(ByVal userid As String, ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True
            Dim sql As SqlBox

            db.BeginTransaction()
            Try
                Dim dtRcv As DataTable = ds.Tables("WG_RCV")
                Dim read As String = String.Empty

                For Each dr As DataRow In dtRcv.Rows
                    If dr("_INSFLAG").ToString = "U" Then
                        sql = New SqlBox("MsgMessageMgt@UpdateNoReadMessageCount")
                        sql.Params("MSG_ID") = dr("MSG_ID")
                        sql.Params("RECEIVER") = userid
                        read = dr("READ_YN").ToString
                        sql.Params("READ_YN") = read
                        If read = "N" Then
                            sql.Blocks("NOT NULL") = True
                        Else
                            sql.Blocks("ISNULL") = True
                        End If

                        db.SqlSet(sql.Text)
                    End If
                Next

                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
                db.Commit()
            Catch ex As Exception
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
                db.Rollback()
            Finally
                db.EndTransaction()
            End Try
            Return ResultSet
        End Function

        Public Shared Function UpdateAlert(ByVal userid As String, ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True
            Dim sql As SqlBox

            db.BeginTransaction()
            Try
                Dim dtRcv As DataTable = ds.Tables("WG_RCV")
                Dim read As String = String.Empty

                For Each dr As DataRow In dtRcv.Rows
                    If dr("_INSFLAG").ToString = "U" Then
                        sql = New SqlBox("MsgMessageMgt@UpdateAlert")
                        sql.Params("MSG_ID") = dr("MSG_ID")
                        sql.Params("RECEIVER") = userid

                        db.SqlSet(sql.Text)
                    End If
                Next

                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
                db.Commit()
            Catch ex As Exception
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
                db.Rollback()
            Finally
                db.EndTransaction()
            End Try
            Return ResultSet
        End Function

        'Public Shared Function SearchAuth(ByVal userid As String) As Dictionary(Of String, Object)
        '    Dim ResultSet As New Dictionary(Of String, Object)
        '    Dim ResultDs As DataSet = New DataSet
        '    Dim db As DBA = New DBA()
        '    Dim ErrorOccur As Boolean = True

        '    Try
        '        Dim sql = New SqlBox("MsgMessageMgt@SearchAuth")
        '        sql.Params("USR_ID") = userid

        '        Dim dt As DataTable
        '        dt = db.SqlGet(sql.Text, False)
        '        dt.TableName = "WG_AUTH1"
        '        ResultDs.Tables.Add(dt)

        '        ResultSet("TrxCode") = "Y"
        '        ResultSet("TrxMsg") = "Success"
        '        ResultSet("Data") = ResultDs
        '    Catch ex As Exception
        '        If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
        '        ResultSet("TrxMsg") = ex.Message
        '    End Try

        '    Return ResultSet
        'End Function

        Public Shared Function SearchUser() As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            Try
                Dim sql As New SqlBox("MsgMessageMgt@SearchUser")
                Dim dtUser As DataTable = db.SqlGet(sql.Text, False)

                'If dtUser.Rows.Count = 0 Then
                '    ThrowMsg(ErrorOccur, "Data not found!")
                'End If

                dtUser.TableName = "WG_USER"
                resultDs.Tables.Add(dtUser)

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = resultDs

            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            End Try

            Return resultSet
        End Function

        'Public Shared Function SaveAuthMsg(ByVal ds As DataSet) As Dictionary(Of String, Object)
        '    Dim resultSet As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
        '    Dim ResultDs As DataSet = New DataSet

        '    Dim db As DBA = New DBA()
        '    Dim dt As DataTable = Nothing
        '    Dim dtResult As DataTable = Nothing
        '    Dim sql As SqlBox = Nothing
        '    Dim dr As DataRow

        '    resultSet("TrxCode") = "N"
        '    resultSet("TrxMsg") = "Operation did not complete successfully."

        '    Try
        '        db.BeginTransaction()

        '        For i As Integer = 0 To ds.Tables("WG_AUTH1").Rows.Count - 1
        '            dr = ds.Tables("WG_AUTH1").Rows(i)

        '            Select Case dr("_INSFLAG")
        '                Case "I"
        '                    sql = New SqlBox("MsgMessageMgt@SearchAuthCheck")
        '                    With sql
        '                        .Params("GRP_CD") = dr("GRP_CD")
        '                        .Params("CD_NM") = dr("CD_NM")
        '                        .Params("OPT_ITEM1") = dr("OPT_ITEM1")
        '                        .Params("OPT_ITEM2") = dr("OPT_ITEM2")
        '                    End With
        '                    dt = db.SqlGet(sql.Text, False)
        '                    If dt.Rows.Count > 0 Then
        '                        resultSet("TrxCode") = "N"
        '                        resultSet("TrxMsg") = dr("CD_NM") & " Existed auth.(" & dt.Rows(0).Item("OPT_ITEM1").ToString & " : " & dt.Rows(0).Item("OPT_ITEM2").ToString & ")"
        '                        Return resultSet
        '                        Exit Function
        '                    End If

        '                    sql = New SqlBox("MsgMessageMgt@SaveAuth")
        '                Case "U"
        '                    sql = New SqlBox("MsgMessageMgt@UpdateAuth")
        '                Case "D"
        '                    sql = New SqlBox("MsgMessageMgt@DeleteAuth")
        '            End Select

        '            With sql
        '                .Params("GRP_CD") = dr("GRP_CD")
        '                .Params("COMN_CD") = dr("COMN_CD")
        '                .Params("CD_NM") = dr("CD_NM")
        '                .Params("OPT_ITEM1") = dr("OPT_ITEM1")
        '                .Params("OPT_ITEM2") = dr("OPT_ITEM2")
        '                .Params("USR_ID") = SessionInfo.UserID
        '            End With
        '            db.SqlSet(sql.Text)
        '        Next

        '        db.Commit()

        '        resultSet("TrxCode") = "Y"
        '        resultSet("TrxMsg") = "Success"
        '        resultSet("Data") = ResultDs
        '    Catch ex As Exception
        '        db.Rollback()

        '        resultSet("TrxCode") = "N"
        '        resultSet("TrxMsg") = ex.Message
        '    Finally
        '        db.EndTransaction()
        '    End Try

        '    Return resultSet
        'End Function


    End Class
End Namespace
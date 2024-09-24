Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Data.OracleClient

Namespace YJIT.Biz
    Public Class SysWcfLog

        Public Shared Function Save(ByVal WcfId As String, ByVal Params() As Object, ByVal StartYmdhm As DateTime, ByVal EndYmdhm As DateTime, ByVal RtnCd As String, ByVal RtnMsg As String, ByVal RtnData As Object, ByVal UserCode As String, ByVal OfficeCode As String) As String
            'Dim db As New DBA
            Dim ErrorOccur As Boolean = True
            Dim sql As SqlBox

            Dim paramsDS As String = String.Empty
            Dim paramsSTR As String = String.Empty
            Dim paramsRtnData As String = String.Empty


            sql = New SqlBox("SysWcfLog@Insert")


            'sql.Params("WCF_ID") = WcfId.ToString

            For Each param As Object In Params
                If TypeOf param Is DataSet Then
                    paramsDS = paramsDS & CType(param, DataSet).GetXml
                Else
                    If paramsSTR <> "" Then paramsSTR = paramsSTR & ","

                    paramsSTR = paramsSTR & param.ToString
                End If
            Next
            'paramsSTR = Mid(paramsSTR, 1, 4000)

            'sql.Params("PARAMS_DS") = paramsDS
            'sql.Params("PARAMS_STR") = paramsSTR
            'sql.Params("START_YMDHM") = StartYmdhm.ToString("yyyy-MM-dd HH:mm:ss.ffffzzz")
            'sql.Params("END_YMDHM") = EndYmdhm.ToString("yyyy-MM-dd HH:mm:ss.ffffzzz")
            'sql.Params("RES_HM") = (EndYmdhm - StartYmdhm).TotalSeconds
            'sql.Params("RTN_CD") = RtnCd
            'sql.Params("RTN_MSG") = RtnMsg
            If TypeOf RtnData Is DataSet Then
                paramsRtnData = CType(RtnData, DataSet).GetXml
            Else
                paramsRtnData = RtnData
            End If
            'sql.Params("RTN_DATA") = paramsRtnData
            'sql.Params("OFFICE_CD") = OfficeCode
            'sql.Params("INS_USR") = UserCode



            Try
                Dim confStr As String = DbConfiguration.ActiveSessionDBConnStr
                Dim CN = New OracleConnection(confStr)

                'Dim sqlStr As New StringBuilder
                'sqlStr.AppendLine(sql.Text)

                'Dim ArrQuery() As String = sql.Text.Split(vbCrLf)
                'For Each query As String In ArrQuery
                '    sqlStr.AppendLine(query)
                'Next

                ''sqlStr.AppendLine("UPDATE CRM_CUST_MST ")
                ''sqlStr.AppendLine("	  SET RMK = :RMK")
                ''sqlStr.AppendLine(" WHERE CUST_CD = :CUST_CD")

                'sqlStr.AppendLine(" INSERT INTO SYS_WCF_LOG ( ")
                'sqlStr.AppendLine("     WCF_ID")
                'sqlStr.AppendLine("    ,PARAMS_DS")
                'sqlStr.AppendLine("    ,PARAMS_STR")
                'sqlStr.AppendLine("    ,START_YMDHM")
                'sqlStr.AppendLine("    ,END_YMDHM")
                'sqlStr.AppendLine("    ,RES_HM")
                'sqlStr.AppendLine("    ,RTN_CD")
                'sqlStr.AppendLine("    ,RTN_MSG")
                'sqlStr.AppendLine("    ,RTN_DATA")
                'sqlStr.AppendLine("    ,OFFICE_CD")
                'sqlStr.AppendLine("    ,INS_USR")
                'sqlStr.AppendLine(" ) VALUES ( ")
                'sqlStr.AppendLine("     :WCF_ID ")
                'sqlStr.AppendLine("    ,:PARAMS_DS ")
                'sqlStr.AppendLine("    ,SUBSTR(:PARAMS_STR,1,4000) ")
                'sqlStr.AppendLine("    ,:START_YMDHM ")
                'sqlStr.AppendLine("    ,:END_YMDHM ")
                'sqlStr.AppendLine("    ,:RES_HM ")
                'sqlStr.AppendLine("    ,:RTN_CD ")
                'sqlStr.AppendLine("    ,:RTN_MSG ")
                'sqlStr.AppendLine("    ,:RTN_DATA ")
                'sqlStr.AppendLine("    ,:OFFICE_CD ")
                'sqlStr.AppendLine("    ,:INS_USR) ")


                If String.IsNullOrEmpty(paramsDS) Then paramsDS = "EMPTY_BLOB()"
                If String.IsNullOrEmpty(paramsSTR) Then paramsSTR = ""
                If String.IsNullOrEmpty(RtnCd) Then RtnCd = ""
                If String.IsNullOrEmpty(RtnMsg) Then RtnMsg = ""
                If String.IsNullOrEmpty(paramsRtnData) Then paramsRtnData = "EMPTY_BLOB()"
                If String.IsNullOrEmpty(OfficeCode) Then OfficeCode = ""
                If String.IsNullOrEmpty(UserCode) Then UserCode = ""


                Dim SqlCom As New OracleCommand(sql.Text, CN)
                SqlCom.Parameters.Add(New OracleParameter(":WCF_ID", WcfId.ToString))
                SqlCom.Parameters.Add(New OracleParameter(":PARAMS_DS", paramsDS))
                SqlCom.Parameters.Add(New OracleParameter(":PARAMS_STR", paramsSTR))
                SqlCom.Parameters.Add(New OracleParameter(":START_YMDHM", StartYmdhm.ToString("yyyy-MM-dd HH:mm:ss.ffffzzz")))
                SqlCom.Parameters.Add(New OracleParameter(":END_YMDHM", EndYmdhm.ToString("yyyy-MM-dd HH:mm:ss.ffffzzz")))
                SqlCom.Parameters.Add(New OracleParameter(":RES_HM", (EndYmdhm - StartYmdhm).TotalSeconds))
                SqlCom.Parameters.Add(New OracleParameter(":RTN_CD", RtnCd))
                SqlCom.Parameters.Add(New OracleParameter(":RTN_MSG", RtnMsg))
                SqlCom.Parameters.Add(New OracleParameter(":RTN_DATA", paramsRtnData))
                SqlCom.Parameters.Add(New OracleParameter(":OFFICE_CD", OfficeCode))
                SqlCom.Parameters.Add(New OracleParameter(":INS_USR", UserCode))

                CN.Open()
                SqlCom.ExecuteNonQuery()
                CN.Close()
                SqlCom.Dispose()

                Return "Y"
            Catch ex As Exception
                Return ex.Message
            End Try

        End Function


    End Class
End Namespace

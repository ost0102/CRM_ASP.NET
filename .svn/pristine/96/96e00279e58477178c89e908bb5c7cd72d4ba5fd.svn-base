Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Exception
Imports System.Collections.Generic
Imports YJIT.Data
Imports YJIT.Biz.Common

Namespace YJIT.Biz
    Public Class EchUpload
        Public Shared Function SaveData(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDS As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            Dim drHeader As DataRow = Nothing
            Dim dt As DataTable
            Dim sql As SqlBox = Nothing
            Dim retCount As Integer = 0
            Dim i As Integer = 0

            If Not ds.Tables.Contains("MAIN") Then
                ThrowMsg(ErrorOccur, "Data info missing.")
            End If
            drHeader = ds.Tables("MAIN").Rows(0)

            ' == Transaction 시작 =================================================
            db.BeginTransaction()
            Try

                dt = ds.Tables("WG1")
                For Each dr As DataRow In dt.Rows
                    If dr("CUSTOMS_CD").ToString <> "" Then


                        sql = New SqlBox("EchUpload@InsertB2B")

                        sql.Params("CUST_CD") = dr("CUSTOMS_CD").ToString.Trim
                        sql.Params("CUST_NM") = dr("CUST_NM").ToString.Trim
                        'AIR
                        If dr("KTNET_AIR").ToString.Trim <> "" Or dr("KLNET_AIR").ToString.Trim <> "" Then
                            If dr("KTNET_AIR").ToString.Trim <> "" Then
                                sql.Params("ID") = dr("KTNET_AIR").ToString.Trim
                                sql.Params("REV") = "57"
                                sql.Params("TESTINDICATOR") = "1"
                                sql.Params("REPLYFLAG") = "1"
                                sql.Params("STANDARD") = "KTAEDIFACT"
                            End If

                            If dr("KLNET_AIR").ToString.Trim <> "" Then
                                sql.Params("ID") = dr("KLNET_AIR").ToString.Trim
                                sql.Params("REV") = "KL"
                                sql.Params("TESTINDICATOR") = ""
                                sql.Params("REPLYFLAG") = ""
                                sql.Params("STANDARD") = "KLAEDIFACT"
                            End If

                            sql.Blocks("AIR") = True
                        End If

                        'SEA
                        If dr("KTNET_SEA").ToString.Trim <> "" Or dr("KLNET_SEA").ToString.Trim <> "" Then
                            If dr("KTNET_SEA").ToString.Trim <> "" Then
                                sql.Params("ID_S") = dr("KTNET_SEA").ToString.Trim
                                sql.Params("REV_S") = "57"
                                sql.Params("TESTINDICATOR_S") = "1"
                                sql.Params("REPLYFLAG_S") = "1"
                                sql.Params("STANDARD_S") = "KTSEDIFACT"
                            End If

                            If dr("KLNET_SEA").ToString.Trim <> "" Then
                                sql.Params("ID_S") = dr("KLNET_SEA").ToString.Trim
                                sql.Params("REV_S") = "KL"
                                sql.Params("TESTINDICATOR_S") = ""
                                sql.Params("REPLYFLAG_S") = ""
                                sql.Params("STANDARD_S") = "KLSEDIFACT"
                            End If

                            sql.Blocks("SEA") = True
                        End If
                        'KCNET
                        If dr("FWB_PIMA").ToString.Trim <> "" And dr("AMS_PIMA").ToString.Trim <> "" Then
                            sql.Params("FWB_PIMA") = dr("FWB_PIMA").ToString.Trim
                            sql.Params("AMS_PIMA") = dr("AMS_PIMA").ToString.Trim
                            sql.Blocks("KCNET") = True
                        End If
                        'AFR
                        If dr("NACCS_ID").ToString.Trim <> "" And dr("NACCS_PW").ToString.Trim <> "" And dr("NACCS_CODE").ToString.Trim <> "" Then
                            sql.Blocks("NACCS") = True
                        End If

                        db.SqlSet(sql.Text)

                        'CHAIN UPLOAD
                        sql = New SqlBox("EchUpload@InsertChain")

                        sql.Params("CUSTOMS_CD") = dr("CUSTOMS_CD").ToString.Trim
                        sql.Params("FTP_ID") = dr("FTP_ID").ToString.Trim
                        sql.Params("FTP_PW") = dr("FTP_PW").ToString.Trim

                        'KTNET
                        If dr("FTP_ID").ToString.Trim <> "" And dr("FTP_PW").ToString.Trim <> "" Then
                            If dr("KTNET_AIR").ToString.Trim <> "" Then
                                sql.Blocks("KTNET_AIR") = True
                            End If

                            If dr("KTNET_SEA").ToString.Trim <> "" Then
                                sql.Blocks("KTNET_SEA") = True
                            End If

                        End If

                        'KLNET
                        If dr("KLNET_AIR").ToString.Trim <> "" Or dr("KLNET_SEA").ToString.Trim <> "" Then
                            If dr("KLNET_AIR").ToString.Trim <> "" Then
                                sql.Blocks("KLNET_AIR") = True
                            End If

                            If dr("KLNET_SEA").ToString.Trim <> "" Then
                                sql.Blocks("KLNET_SEA") = True
                            End If
                        End If

                        'KCNET
                        If dr("FWB_PIMA").ToString.Trim <> "" And dr("AMS_PIMA").ToString.Trim <> "" Then
                            sql.Params("FWB_PIMA") = dr("FWB_PIMA").ToString.Trim
                            sql.Params("AMS_PIMA") = dr("AMS_PIMA").ToString.Trim
                            sql.Params("6CODE") = dr("6CODE").ToString.Trim
                            sql.Blocks("KCNET") = True
                        End If
                        'AFR
                        If dr("NACCS_ID").ToString.Trim <> "" And dr("NACCS_PW").ToString.Trim <> "" And dr("NACCS_CODE").ToString.Trim <> "" Then
                            sql.Params("NACCS_ID") = dr("NACCS_ID").ToString.Trim
                            sql.Params("NACCS_PW") = dr("NACCS_PW").ToString.Trim
                            sql.Params("NACCS_CODE") = dr("NACCS_CODE").ToString.Trim
                            sql.Params("NACCS_EMAIL") = dr("NACCS_EMAIL").ToString.Trim
                            sql.Blocks("NACCS") = True
                        End If

                        db.SqlSet(sql.Text)

                        'CHAIN ID/PW UPDATE
                        sql = New SqlBox("EchUpload@UpdateChainIDPW")

                        sql.Params("CUSTOMS_CD") = dr("CUSTOMS_CD").ToString.Trim
                        sql.Params("CUST_CD") = dr("CUST_CD").ToString.Trim

                        '2018.11.06 CHAIN 등록일자 관리추가.
                        If dr("CHAIN_START_YMD").ToString.Trim <> "" Then
                            sql.Params("CHAIN_START_YMD") = dr("CHAIN_START_YMD").ToString.Replace("-", "")
                        Else
                            sql.Params("CHAIN_START_YMD") = Format(Now, "yyyymmdd")
                        End If

                        db.SqlSet(sql.Text)

                    End If
                Next

                db.Commit()

                'ResultSet("Data") = Search()("Data")
                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"

            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            Return ResultSet

        End Function

    End Class

End Namespace

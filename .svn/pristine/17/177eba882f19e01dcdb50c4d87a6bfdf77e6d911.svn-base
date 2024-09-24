Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports YJIT.Biz.Common
Namespace YJIT.Biz

    Public Class MdmMappingMgt
        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)

            Dim resultSet As New Dictionary(Of String, Object)
            Dim resDs As DataSet = New DataSet
            Dim drHeader As DataRow
            Dim db As DBA = New DBA()

            resultSet("TrxCode") = "E"
            resultSet("TrxMsg") = "Error"
            resultSet("Data") = resDs

            Try
                drHeader = ds.Tables("MAIN").Rows(0)
            Catch ex As Exception
                resultSet("TrxMsg") = "Page main data is missing!"
                Return resultSet
            End Try

            Try
                Dim sql As SqlBox
                Dim dt As DataTable

                sql = New SqlBox("MdmMappingMgt@Search")
                With sql
                    If drHeader("S_COMN_CD").ToString <> "" Then
                        .Params("COMN_CD") = drHeader("S_COMN_CD").ToString
                        .Blocks("COMN_CD") = True
                    End If
                    If drHeader("S_RMK").ToString <> "" Then
                        .Params("RMK") = drHeader("S_RMK").ToString
                        .Blocks("RMK") = True
                    End If

                    If drHeader("S_FM_CD").ToString <> "" Then
                        .Params("FM_CD") = drHeader("S_FM_CD").ToString
                        .Blocks("FM_CD") = True
                    End If

                    If drHeader("S_TO_CD").ToString <> "" Then
                        .Params("TO_CD") = drHeader("S_TO_CD").ToString
                        .Blocks("TO_CD") = True
                    End If
                End With

                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG1"
                resDs.Tables.Add(dt)

                If dt.Rows.Count = 0 Then
                    resultSet("TrxCode") = "N"
                    Throw New Exception("Data not found!")
                End If

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
            Catch ex As Exception
                resultSet("TrxMsg") = ex.Message
            End Try
            Return resultSet
        End Function


        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim drHeader As DataRow
            Dim db As DBA = New DBA()
            Dim dt1 As DataTable
            Dim sql As SqlBox
            Dim ErrorOccur As Boolean = True

            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                dt1 = ds.Tables("WG1")

                For Each dr As DataRow In dt1.Rows
                    Select Case dr("_INSFLAG")
                        Case "I"
                            'Look for the PK

                            sql = New SqlBox("MdmMappingMgt@Search")
                            With sql
                                If drHeader("S_COMN_CD").ToString <> "" Then
                                    .Params("COMN_CD") = drHeader("S_COMN_CD").ToString
                                    .Blocks("COMN_CD") = True
                                End If
                                If drHeader("S_RMK").ToString <> "" Then
                                    .Params("RMK") = drHeader("S_RMK").ToString
                                    .Blocks("RMK") = True
                                End If

                                If drHeader("S_FM_CD").ToString <> "" Then
                                    .Params("FM_CD") = drHeader("S_FM_CD").ToString
                                    .Blocks("FM_CD") = True
                                End If

                                If drHeader("S_TO_CD").ToString <> "" Then
                                    .Params("TO_CD") = drHeader("S_TO_CD").ToString
                                    .Blocks("TO_CD") = True
                                End If
                            End With

                            Dim dt As DataTable = db.SqlGet(sql.Text, False)
                            If dt.Rows.Count > 0 Then
                                resultSet("TrxCode") = "N"
                                resultSet("TrxMsg") = "Mapping code is duplicated!"
                                ErrorOccur = False
                            End If

                            sql = New SqlBox("MdmMappingMgt@Insert")
                            sql.Params("TO_NM") = dr("TO_NM").ToString()
                            sql.Params("RMK") = dr("RMK").ToString()
                            sql.Params("INS_USR") = YJIT.SessionInfo.UserID
                            sql.Params("TO_CD") = dr("TO_CD").ToString()

                        Case "U"
                            sql = New SqlBox("MdmMappingMgt@Update")
                            sql.Params("TO_NM") = dr("TO_NM").ToString()
                            sql.Params("RMK") = dr("RMK").ToString()
                            sql.Params("UPD_USR") = YJIT.SessionInfo.UserID
                            sql.Params("TO_CD") = dr("TO_CD").ToString()

                            ' UPDATE KEY
                            sql.Params("PK_TABLE_ID") = dr("PK_TABLE_ID").ToString()
                            sql.Params("PK_FM_TYPE") = dr("PK_FM_TYPE").ToString()
                            sql.Params("PK_FM_CD") = dr("PK_FM_CD").ToString()
                            sql.Params("PK_TO_CD") = dr("PK_TO_CD").ToString()

                        Case "D"
                            sql = New SqlBox("MdmMappingMgt@Delete")
                            If dr("TO_CD").ToString <> "" Then
                                sql.Params("TO_CD") = dr("TO_CD").ToString()
                                sql.Blocks("TO_CD") = True
                            End If
                        Case Else
                            Continue For
                    End Select

                    sql.Params("OFFICE_CD") = YJIT.SessionInfo.OfficeCode
                    sql.Params("TABLE_ID") = dr("TABLE_ID").ToString()
                    sql.Params("FM_CD") = dr("FM_CD").ToString()
                    sql.Params("FM_TYPE") = dr("FM_TYPE").ToString()  'FM_TYPE
                    sql.Params("FIELD_ID") = dr("FIELD_ID").ToString()
                    sql.Params("FIELD_TYPE") = dr("FIELD_TYPE").ToString()
                    sql.Params("UPPER_FM_CD") = dr("UPPER_FM_CD").ToString()

                    db.SqlSet(sql.Text)

                Next

                db.Commit()
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            If resultSet("TrxCode") = "Y" Then
                resultSet("Data") = Search(ds)("Data")
            End If

            Return resultSet

        End Function
    End Class

End Namespace

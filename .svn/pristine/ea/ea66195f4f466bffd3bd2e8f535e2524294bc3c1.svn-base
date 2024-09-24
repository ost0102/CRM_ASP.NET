Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Exception
Imports System.Collections.Generic

Imports YJIT.Data

Namespace YJIT.Biz

    Public Class Common
        '====================================================================================
        ' 서버시간 조회
        '====================================================================================
        Public Shared Function checkServerTime() As String

            Return DateTimeOffset.Now().ToString()

        End Function
        '====================================================================================
        ' 선적자동화(범한판토스 세금계산서) 특수문자를 ' '로 대체합니다. 
        '====================================================================================
        Public Shared Function ReplaceSpecialCharVatDec(ByVal str As String) As String

            Dim rstr As String
            rstr = str
            rstr = Replace(rstr, Chr(0), Space(0))              'null
            rstr = Replace(rstr, Chr(33), Space(1))             '!
            rstr = Replace(rstr, Chr(34), Space(1))             '"
            rstr = Replace(rstr, Chr(35), Space(1))             '#
            rstr = Replace(rstr, Chr(36), Space(1))             '$
            rstr = Replace(rstr, Chr(37), Space(1))             '%
            rstr = Replace(rstr, Chr(38), Space(1))             '&
            rstr = Replace(rstr, Chr(39), Space(1))             ''
            rstr = Replace(rstr, Chr(40), Space(1))             '(
            rstr = Replace(rstr, Chr(41), Space(1))             ')
            rstr = Replace(rstr, Chr(45), Space(0))             '-
            rstr = Replace(rstr, Chr(47), Space(1))             '?
            rstr = Replace(rstr, Chr(58), Space(1))             '?
            rstr = Replace(rstr, Chr(59), Space(1))             '?
            rstr = Replace(rstr, Chr(63), Space(1))             '?
            rstr = Replace(rstr, Chr(64), Space(1))             '@
            rstr = Replace(rstr, Chr(91), Space(1))             '[
            rstr = Replace(rstr, Chr(92), Space(1))             '\
            rstr = Replace(rstr, Chr(93), Space(1))             ']
            rstr = Replace(rstr, Chr(94), Space(1))             '^
            rstr = Replace(rstr, Chr(95), Space(1))             '_
            rstr = Replace(rstr, Chr(96), Space(1))             '`
            rstr = Replace(rstr, Chr(123), Space(1))            '{
            rstr = Replace(rstr, Chr(124), Space(1))            '|
            rstr = Replace(rstr, Chr(125), Space(1))            '}
            rstr = Replace(rstr, Chr(126), Space(1))            '~
            rstr = Replace(rstr, Chr(13) & Chr(10), Space(1))      'Enter
            rstr = Replace(rstr, Chr(13), Space(1))      'Enter

            Return rstr

        End Function
        '====================================================================================
        ' 특수문자를 ' '로 대체합니다. / 일반 EDI 전송시 문자 대체기능
        '====================================================================================
        Public Shared Function ReplaceSpecialCharacter(ByVal str As String, ByVal index As String) As String

            Dim rstr As String
            rstr = str

            If Not (index.Contains("HSHAD") OrElse index.Contains("HCNAD") OrElse index.Contains("HNFAD")) Then
                rstr = Replace(rstr, Chr(45), Space(0))                    '-
            End If
           
            rstr = Replace(rstr, Chr(0), Space(0))              'null
            rstr = Replace(rstr, Chr(33), Space(1))             '!
            rstr = Replace(rstr, Chr(34), Space(1))             '"
            rstr = Replace(rstr, Chr(35), Space(1))             '#
            rstr = Replace(rstr, Chr(36), Space(1))             '$
            rstr = Replace(rstr, Chr(37), Space(1))             '%
            rstr = Replace(rstr, Chr(38), Space(1))             '&
            rstr = Replace(rstr, Chr(39), Space(1))             ''
            rstr = Replace(rstr, Chr(40), Space(1))             '(
            rstr = Replace(rstr, Chr(41), Space(1))             ')
            rstr = Replace(rstr, Chr(47), Space(1))             '?
            rstr = Replace(rstr, Chr(58), Space(1))             '?
            rstr = Replace(rstr, Chr(59), Space(1))             '?
            rstr = Replace(rstr, Chr(63), Space(1))             '?
            rstr = Replace(rstr, Chr(64), Space(1))             '@
            rstr = Replace(rstr, Chr(91), Space(1))             '[
            rstr = Replace(rstr, Chr(92), Space(1))             '\
            rstr = Replace(rstr, Chr(93), Space(1))             ']
            rstr = Replace(rstr, Chr(94), Space(1))             '^
            rstr = Replace(rstr, Chr(95), Space(1))             '_
            rstr = Replace(rstr, Chr(96), Space(1))             '`
            rstr = Replace(rstr, Chr(123), Space(1))            '{
            rstr = Replace(rstr, Chr(124), Space(1))            '|
            rstr = Replace(rstr, Chr(125), Space(1))            '}
            rstr = Replace(rstr, Chr(126), Space(1))            '~
            rstr = Replace(rstr, Chr(44), Space(1))            ',
            rstr = Replace(rstr, Chr(13) & Chr(10), Space(1))      'Enter
            rstr = Replace(rstr, Chr(13), Space(1))      'Enter

            Dim NewStr As String = ""
            For Each index In rstr.ToArray

                Dim ddd() As Byte = System.Text.Encoding.Default.GetBytes(index)
                If ddd.Length = 1 Then
                    NewStr &= index
                End If
            Next

            Return NewStr

        End Function

        '====================================================================================
        ' 특수문자를 ' '로 대체합니다. / 일반 EDI 전송시 문자 대체기능
        '====================================================================================
        Public Shared Function ReplaceSpecialCharacter(ByVal str As String) As String

            Dim rstr As String
            rstr = str
            rstr = Replace(rstr, Chr(0), Space(0))              'null
            rstr = Replace(rstr, Chr(33), Space(1))             '!
            rstr = Replace(rstr, Chr(34), Space(1))             '"
            rstr = Replace(rstr, Chr(35), Space(1))             '#
            rstr = Replace(rstr, Chr(36), Space(1))             '$
            rstr = Replace(rstr, Chr(37), Space(1))             '%
            rstr = Replace(rstr, Chr(38), Space(1))             '&
            rstr = Replace(rstr, Chr(39), Space(1))             ''
            rstr = Replace(rstr, Chr(40), Space(1))             '(
            rstr = Replace(rstr, Chr(41), Space(1))             ')
            rstr = Replace(rstr, Chr(45), Space(0))             '-
            rstr = Replace(rstr, Chr(47), Space(1))             '?
            rstr = Replace(rstr, Chr(58), Space(1))             '?
            rstr = Replace(rstr, Chr(59), Space(1))             '?
            rstr = Replace(rstr, Chr(63), Space(1))             '?
            rstr = Replace(rstr, Chr(64), Space(1))             '@
            rstr = Replace(rstr, Chr(91), Space(1))             '[
            rstr = Replace(rstr, Chr(92), Space(1))             '\
            rstr = Replace(rstr, Chr(93), Space(1))             ']
            rstr = Replace(rstr, Chr(94), Space(1))             '^
            rstr = Replace(rstr, Chr(95), Space(1))             '_
            rstr = Replace(rstr, Chr(96), Space(1))             '`
            rstr = Replace(rstr, Chr(123), Space(1))            '{
            rstr = Replace(rstr, Chr(124), Space(1))            '|
            rstr = Replace(rstr, Chr(125), Space(1))            '}
            rstr = Replace(rstr, Chr(126), Space(1))            '~
            rstr = Replace(rstr, Chr(44), Space(1))            ',
            rstr = Replace(rstr, Chr(13) & Chr(10), Space(1))      'Enter
            rstr = Replace(rstr, Chr(13), Space(1))      'Enter

            Dim NewStr As String = ""
            For Each index In rstr.ToArray

                Dim ddd() As Byte = System.Text.Encoding.Default.GetBytes(index)
                If ddd.Length = 1 Then
                    NewStr &= index
                End If
            Next

            Return NewStr

        End Function

        Public Shared Function ReplaceSpecialCharXml(ByVal str As String) As String

            Dim rstr As String
            rstr = str.ToString
            rstr = Replace(rstr, Chr(0), Space(0))              'null
            rstr = Replace(rstr, Chr(33), Space(1))             '!
            rstr = Replace(rstr, Chr(35), Space(1))             '#
            rstr = Replace(rstr, Chr(36), Space(1))             '$
            rstr = Replace(rstr, Chr(37), Space(1))             '%
            rstr = Replace(rstr, Chr(38), Space(1))             '&
            rstr = Replace(rstr, Chr(39), Space(1))             ''
            rstr = Replace(rstr, Chr(40), Space(1))             '(
            rstr = Replace(rstr, Chr(41), Space(1))             ')
            rstr = Replace(rstr, Chr(60), Space(1))             '<
            rstr = Replace(rstr, Chr(62), Space(1))             '>
            rstr = Replace(rstr, Chr(64), Space(1))             '@
            rstr = Replace(rstr, Chr(91), Space(1))             '[
            rstr = Replace(rstr, Chr(92), Space(1))             '\
            rstr = Replace(rstr, Chr(93), Space(1))             ']
            rstr = Replace(rstr, Chr(94), Space(1))             '^
            rstr = Replace(rstr, Chr(95), Space(1))             '_
            rstr = Replace(rstr, Chr(96), Space(1))             '`
            rstr = Replace(rstr, Chr(123), Space(1))            '{
            rstr = Replace(rstr, Chr(124), Space(1))            '|
            rstr = Replace(rstr, Chr(125), Space(1))            '}
            rstr = Replace(rstr, Chr(126), Space(1))            '~

            Dim NewStr As String = ""

            If Not rstr Is Nothing Then
                For Each index In rstr.ToArray
                    Dim ddd() As Byte = System.Text.Encoding.Default.GetBytes(index)
                    If ddd.Length = 1 Then
                        NewStr &= index
                    End If
                Next
            End If

            Return NewStr

        End Function
        '=====================================================================
        '        Air Carrier Booking (CN)전송 전용 
        '======================================================================

        Public Shared Function ReplaceSpecialCharXml2(ByVal str As String) As String

            Dim rstr As String
            rstr = str.ToString
            rstr = Replace(rstr, Chr(0), Space(0))              'null
            rstr = Replace(rstr, Chr(33), Space(1))             '!
            rstr = Replace(rstr, Chr(35), Space(1))             '#
            rstr = Replace(rstr, Chr(36), Space(1))             '$
            rstr = Replace(rstr, Chr(37), Space(1))             '%
            rstr = Replace(rstr, Chr(38), Space(1))             '&
            rstr = Replace(rstr, Chr(39), Space(1))             ''
            rstr = Replace(rstr, Chr(40), Space(1))             '(
            rstr = Replace(rstr, Chr(41), Space(1))             ')
            rstr = Replace(rstr, Chr(60), Space(1))             '<
            rstr = Replace(rstr, Chr(62), Space(1))             '>
            rstr = Replace(rstr, Chr(64), Space(1))             '@
            rstr = Replace(rstr, Chr(91), Space(1))             '[
            rstr = Replace(rstr, Chr(92), Space(1))             '\
            rstr = Replace(rstr, Chr(93), Space(1))             ']
            rstr = Replace(rstr, Chr(94), Space(1))             '^
            rstr = Replace(rstr, Chr(95), Space(1))             '_
            rstr = Replace(rstr, Chr(96), Space(1))             '`
            rstr = Replace(rstr, Chr(123), Space(1))            '{
            rstr = Replace(rstr, Chr(124), Space(1))            '|
            rstr = Replace(rstr, Chr(125), Space(1))            '}
            rstr = Replace(rstr, Chr(126), Space(1))            '~
            rstr = Replace(rstr, Chr(44), Space(1))             ',
            rstr = Replace(rstr, Chr(45), Space(1))             '-
            rstr = Replace(rstr, Chr(46), Space(1))             '.
            rstr = Replace(rstr, Chr(58), Space(1))             ';
            rstr = Replace(rstr, Chr(59), Space(1))             ';

            Dim NewStr As String = ""

            If Not rstr Is Nothing Then
                For Each index In rstr.ToArray
                    Dim ddd() As Byte = System.Text.Encoding.Default.GetBytes(index)
                    If ddd.Length = 1 Then
                        NewStr &= index
                    End If
                Next
            End If

            Return NewStr

        End Function

        
        '====================================================================================
        ' 엔터를 ' '로 대체합니다. / 일반 EDI 전송시 문자 대체기능
        '====================================================================================
        Public Shared Function ReplaceSpecialCharacter2(ByVal str As String) As String

            Dim rstr As String = ""
            rstr = str
            rstr = Replace(rstr, Chr(13), Space(1))                   'Enter
            rstr = Replace(rstr, Chr(10), Space(1))                   'Enter
            Return rstr
        End Function
        '====================================================================================
        ' Value 값을 원하는 문자를 채워서 리턴함   
        '====================================================================================
        Public Shared Function Lpad(ByVal MyValue$, ByVal MyPadCharacter$, ByVal MyPaddedLength%) As String
            Dim Padlength As Integer = 0
            Dim PadString As String = ""
            Dim X As Integer = 0
            Dim rtnString As String

            Padlength = MyPaddedLength - Len(MyValue)
            For X = 1 To Padlength
                PadString = PadString & MyPadCharacter
            Next

            rtnString = PadString + MyValue

            Return rtnString

        End Function
        '====================================================================================
        ' Office별 필수항목 체크 
        '====================================================================================
        Public Shared Function GetOfficeMandatory(ByVal FormName As String) As Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ErrorOccur As Boolean = False
            Try
                Dim sql As New SqlBox("Common@GetOfficeMandatory")
                Dim ResultDs As New DataSet
                sql.Params("OFFICE_CD") = SessionInfo.OfficeCode
                sql.Params("PGM_ID") = FormName
                Dim dt As DataTable
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "MandatoryList"
                ResultDs.Tables.Add(dt)
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = ResultDs
            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxCode") = ex.Message
            End Try
            Return resultSet
        End Function

        'FreightCommon에서 호출
        'OFFICE_CD : 사업장 코드
        'BASE_CURR : 기준통화 코드
        'CURR_CD   : 통화코드
        'SVC_TYPE  : AE(항공수출),AI(항공수입),SE(해운수출),SI(해운수입),WMS(WMS)
        'SELL_BUY_TYPE : L(국내매출),B(국내매입),F(해외)
        Public Shared Function GetExRate(ByVal OFFICE_CD As String, _
                                         ByVal BASE_CURR As String, _
                                         ByVal CURR_CD As String, _
                                         ByVal EXRT_YMD As String, _
                                         ByVal SVC_TYPE As String, _
                                         ByVal SELL_BUY_TYPE As String) As Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ErrorOccur As Boolean = False
            Dim ExrateClass As String = ""

            Try

                Dim ds As New DataSet
                Dim sql As SqlBox = Nothing
                Dim ExRate As Double = 0
                Dim CurrUnit As Double = 0
                Dim dt As DataTable


                sql = New SqlBox("Common@GetExRateClass")
                sql.Params("OFFICE_CD") = OFFICE_CD
                sql.Params("SVC_TYPE") = SVC_TYPE
                sql.Params("SELL_BUY_TYPE") = SELL_BUY_TYPE
                dt = db.SqlGet(sql.Text, False)
                If dt.Rows.Count > 0 Then
                    ExrateClass = dt.Rows(0)("EXRATE_CLASS")
                Else
                    ExrateClass = "A"
                End If

                sql = New SqlBox("Common@GetExRate")
                sql.Params("OFFICE_CD") = OFFICE_CD
                sql.Params("BASE_CURR") = BASE_CURR
                sql.Params("CURR_CD") = CURR_CD
                sql.Params("EXRT_YMD") = EXRT_YMD
                dt = db.SqlGet(sql.Text, False)

                dt.TableName = "ExRate"
                ds.Tables.Add(dt)

                If dt.Rows.Count > 0 Then

                    Dim FiledName As String = ""
                    Select Case ExrateClass
                        Case "A"
                            FiledName = "EXCH_BASERT"
                        Case "B"
                            FiledName = "CASH_BUYRT"
                        Case "C"
                            FiledName = "CASH_SELLRT"
                        Case "D"
                            FiledName = "WIRE_SEND_EXRT"
                        Case "E"
                            FiledName = "WIRE_RECV_EXRT"
                        Case Else
                            FiledName = "EXCH_BASERT"
                    End Select
                    ExRate = dt.Rows(0)(FiledName)
                    CurrUnit = dt.Rows(0)("CURR_UNIT")
                End If

                If ExRate = 0 Then ExRate = 1

                resultSet("EXRATE") = ExRate
                resultSet("CURR_UNIT") = CurrUnit
                resultSet("EXRATE_CLASS") = ExrateClass
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = ds

            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxCode") = ex.Message
                resultSet("EXRATE") = 1
                resultSet("CURR_UNIT") = 1
                resultSet("EXRATE_CLASS") = ExrateClass
            End Try
            Return resultSet

        End Function

        'FreightCommon에서 호출
        'CUST_CD   : 환율 적용 거래처 정보
        'BASE_CURR : 기준통화 코드
        'CURR_CD   : 통화코드
        'SVC_TYPE  : AE(항공수출),AI(항공수입),SE(해운수출),SI(해운수입),WMS(WMS)
        'SELL_BUY_TYPE : L(국내매출),B(국내매입),F(해외)
        Public Shared Function GetCustExRate(ByVal CUST_CD As String, _
                                         ByVal BASE_CURR As String, _
                                         ByVal CURR_CD As String, _
                                         ByVal EXRT_YMD As String, _
                                         ByVal SVC_TYPE As String, _
                                         ByVal SELL_BUY_TYPE As String) As Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ErrorOccur As Boolean = False
            Dim ExrateClass As String = ""

            Try

                Dim ds As New DataSet
                Dim sql As SqlBox = Nothing
                Dim ExRate As Double = 0
                Dim CurrUnit As Double = 0
                Dim dt As DataTable

                sql = New SqlBox("Common@GetExRateClass")
                sql.Params("OFFICE_CD") = YJIT.SessionInfo.OfficeCode
                sql.Params("SVC_TYPE") = SVC_TYPE
                sql.Params("SELL_BUY_TYPE") = SELL_BUY_TYPE
                dt = db.SqlGet(sql.Text, False)
                If dt.Rows.Count > 0 Then
                    ExrateClass = dt.Rows(0)("EXRATE_CLASS")
                Else
                    ExrateClass = "A"
                End If

                sql = New SqlBox("Common@GetCustExRate")
                sql.Params("OFFICE_CD") = YJIT.SessionInfo.OfficeCode
                sql.Params("BASE_CURR") = BASE_CURR
                sql.Params("CUST_CD") = CUST_CD
                sql.Params("CURR_CD") = CURR_CD
                sql.Params("EXRT_YMD") = EXRT_YMD
                dt = db.SqlGet(sql.Text, False)

                dt.TableName = "ExRate"
                ds.Tables.Add(dt)

                If dt.Rows.Count > 0 Then

                    Dim FiledName As String = ""
                    Select Case ExrateClass
                        Case "A"
                            FiledName = "EXCH_BASERT"
                        Case "B"
                            FiledName = "CASH_BUYRT"
                        Case "C"
                            FiledName = "CASH_SELLRT"
                        Case "D"
                            FiledName = "WIRE_SEND_EXRT"
                        Case "E"
                            FiledName = "WIRE_RECV_EXRT"
                        Case Else
                            FiledName = "EXCH_BASERT"
                    End Select
                    ExRate = dt.Rows(0)(FiledName)
                    CurrUnit = dt.Rows(0)("CURR_UNIT")
                End If

                If ExRate = 0 Then ExRate = 1

                resultSet("EXRATE") = ExRate
                resultSet("CURR_UNIT") = CurrUnit
                resultSet("EXRATE_CLASS") = ExrateClass
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = ds

            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxCode") = ex.Message
                resultSet("EXRATE") = 1
                resultSet("CURR_UNIT") = 1
                resultSet("EXRATE_CLASS") = ExrateClass
            End Try
            Return resultSet

        End Function

        'FreightCommon에서 호출 
        Public Shared Function GetCurrUnit(ByVal OFFICE_CD As String, ByVal BASE_CURR As String, ByVal CURR_CD As String) As Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ErrorOccur As Boolean = False
            Try
                Dim ds As New DataSet
                Dim sql As New SqlBox("Common@GetCurrUnit")
                Dim CURR_UNIT As Double = 1
                sql.Params("OFFICE_CD") = OFFICE_CD
                sql.Params("BASE_CURR") = BASE_CURR
                sql.Params("CURR_CD") = CURR_CD
                Dim dt As DataTable
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "CURR_UNIT"
                ds.Tables.Add(dt)
                If dt.Rows.Count > 0 Then
                    CURR_UNIT = dt.Rows(0)("CURR_UNIT")
                End If
                resultSet("CURR_UNIT") = CURR_UNIT
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = ds
            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxCode") = ex.Message
                resultSet("CURR_UNIT") = 1
            End Try
            Return resultSet
        End Function

        ' ================        GetBound    ================
        'OFFICE_CD       :   회사코드  ""
        'LocCtryCD       :   국가 코드
        'REF_NO          :   비엘 번호
        'BlType          :   "M",H
        'PolCd           :   포트코드
        'PodCd           :   포트코드
        'ValueType       :   BOUND(E,I),AUTH("DESC,ORIN..)
        Public Shared Function GetBound(ByVal OFFICE_CD As String, ByVal LocCtryCD As String, ByVal REF_NO As String, ByVal BlType As String, ByVal PolCd As String, ByVal PodCd As String) As Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ErrorOccur As Boolean = False
            Dim Bound As String = ""
            Dim Auth As String = ""
            Dim dt As DataTable = Nothing
            Try
                Dim ds As New DataSet
                Dim sql As New SqlBox("Common@GetBound")
                sql.Params("P_CTRY_CD") = LocCtryCD
                sql.Params("P_REF_NO") = REF_NO
                sql.Params("P_MH_TYPE") = BlType
                sql.Params("P_POL") = PolCd
                sql.Params("P_POD") = PodCd
                sql.Params("P_OFFICE") = OFFICE_CD
                dt = db.SqlGet(sql.Text, False)

                Bound = dt.Rows(0)("BOUND").ToString
                Auth = dt.Rows(0)("AUTH").ToString
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxCode") = ex.Message
            End Try
            resultSet("BOUND") = Bound
            resultSet("AUTH") = Auth
            Return resultSet

        End Function

        Public Shared Function GroupCustInfo(ByVal GroupCustCd As String) As Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ErrorOccur As Boolean = False
            Dim BOUND As String = ""
            Dim dt As DataTable = Nothing
            Try
                Dim ds As New DataSet
                Dim sql As New SqlBox("Common@GetGroupCustomersInfo")
                sql.Params("CUST_GRP_CD") = GroupCustCd
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "CustomersInfo"
                resultSet("Data") = dt
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxCode") = ex.Message
            End Try
            resultSet("BOUND") = BOUND
            Return resultSet
        End Function

        Public Shared Function CustPicInfo(ByVal CustCode As String, ByVal DeptCode As String) As Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ErrorOccur As Boolean = False
            Dim dt As DataTable = Nothing
            Try
                Dim ds As New DataSet
                Dim sql As New SqlBox("Common@GetCustPicInfo")
                sql.Params("OFFICE_CD") = YJIT.SessionInfo.OfficeCode
                sql.Params("CUST_CD") = CustCode
                sql.Params("DEPT_CD") = DeptCode
                If DeptCode <> "" Then
                    sql.Blocks("DEPT_CD") = True
                End If
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "CustPicInfo"
                resultSet("Data") = dt
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxCode") = ex.Message
            End Try
            Return resultSet

        End Function


        Public Shared Sub ThrowMsg(ByRef ErrorOccur As Boolean, ByVal Msg As String)
            ErrorOccur = False
            Throw New Exception(Msg)
        End Sub

        Public Shared Function SplitForClob(ByVal DataString As String) As String()
            '받은 문자열 짤라서 넣기 위한 함수
            Dim STR As String = DataString

            Dim MaxLength As Integer = STR.Length
            Dim LastLength As Object = (MaxLength) Mod 1500
            Dim Section As Integer = (MaxLength - LastLength) / 1500
            If LastLength > 0 Then Section += 1
            Dim RtnStr(Section - 1) As String

            For i = 0 To Section - 1
                Dim postion As Integer = 1500
                If i = Section - 1 Then postion = LastLength
                Dim param As String = STR.Substring(i * 1500, postion)
                RtnStr(i) = param
            Next

            Return RtnStr
        End Function

        Public Shared Function GetLayoutList(ByVal OfficeCd As String, ByVal FormId As String) As Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ErrorOccur As Boolean = False
            Dim dt As DataTable = Nothing
            Try
                Dim ds As New DataSet
                Dim sql As New SqlBox("Common@GetLayoutList")
                sql.Params("OFFICE_CD") = OfficeCd
                sql.Params("FORM_ID") = FormId

                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "List"
                resultSet("Data") = dt
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxCode") = ex.Message
            End Try
            Return resultSet
        End Function

        Public Shared Function GetLayout(ByVal OfficeCd As String, ByVal FormId As String, ByVal Layout As String) As Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ErrorOccur As Boolean = False
            Dim dt As DataTable = Nothing
            Dim ds As New DataSet
            Try

                Dim sql As New SqlBox("Common@GetLayout")
                sql.Params("OFFICE_CD") = OfficeCd
                sql.Params("FORM_ID") = FormId
                sql.Params("LAYOUT_NM") = Layout
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "LAYOUT"
                ds.Tables.Add(dt)

                sql = New SqlBox("Common@GetLayoutFormula")
                sql.Params("OFFICE_CD") = OfficeCd
                sql.Params("FORM_ID") = FormId
                sql.Params("LAYOUT_NM") = Layout
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "FORMULA"
                ds.Tables.Add(dt)

                resultSet("Data") = ds
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxCode") = ex.Message
            End Try
            Return resultSet
        End Function

        Public Shared Function SaveLayout(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim dt As DataTable
            Dim CRM_LAYOUT_MST As DataTable
            Dim ErrorOccur As Boolean = True
            Dim FormId As String = ""
            Dim LAYOUT_NM As String = ""
            db.BeginTransaction()
            Try
                '
                If Not ds.Tables.Contains("CRM_LAYOUT_MST") Then
                    ThrowMsg(ErrorOccur, "Data Table missing. (CRM_LAYOUT_MST)")
                End If
                If Not ds.Tables.Contains("CRM_LAYOUT_DTL") Then
                    ThrowMsg(ErrorOccur, "Data Table missing. (CRM_LAYOUT_DTL)")
                End If
                CRM_LAYOUT_MST = ds.Tables("CRM_LAYOUT_MST")

                FormId = CRM_LAYOUT_MST.Rows(0)("FORM_ID").ToString
                LAYOUT_NM = CRM_LAYOUT_MST.Rows(0)("LAYOUT_NM").ToString



                Dim sql As New SqlBox("Common@CheckLayout")

                sql.Params("OFFICE_CD") = SessionInfo.OfficeCode
                sql.Params("FORM_ID") = FormId
                sql.Params("LAYOUT_NM") = LAYOUT_NM
                dt = db.SqlGet(sql.Text, False)

                If dt.Rows.Count = 0 Then
                    sql = New SqlBox("Common@InsertLayout")
                Else
                    sql = New SqlBox("Common@UpdatetLayout")
                End If
                '=================== MAIN    =================================== 

                sql.Params("OFFICE_CD") = SessionInfo.OfficeCode
                sql.Params("FORM_ID") = FormId
                sql.Params("LAYOUT_NM") = LAYOUT_NM
                sql.Params("INS_USR") = YJIT.SessionInfo.UserID
                sql.Params("UPD_USR") = YJIT.SessionInfo.UserID
                db.SqlSet(sql.Text)

                '데이터가 한번에 안들가서 조각조각 내서 넣음
                Dim Layout() As String = SplitForClob(CRM_LAYOUT_MST.Rows(0)("LAYOUT").ToString)
                For i = 0 To Layout.Length - 1
                    sql = New SqlBox("Common@SplitUpdateLayout")
                    sql.Params("OFFICE_CD") = SessionInfo.OfficeCode
                    sql.Params("LAYOUT") = Layout(i)
                    sql.Params("FORM_ID") = FormId
                    sql.Params("LAYOUT_NM") = LAYOUT_NM
                    db.SqlSet(sql.Text)
                Next

                '=================== DETAIL =================================== 
                sql = New SqlBox("Common@DeleteLayoutFromula")
                sql.Params("OFFICE_CD") = SessionInfo.OfficeCode
                sql.Params("FORM_ID") = FormId
                sql.Params("LAYOUT_NM") = LAYOUT_NM
                db.SqlSet(sql.Text)

                dt = ds.Tables("CRM_LAYOUT_DTL")
                For Each dr In dt.Rows
                    sql = New SqlBox("Common@InsertLayoutFormula")
                    sql.Params("OFFICE_CD") = SessionInfo.OfficeCode
                    sql.Params("FORM_ID") = FormId
                    sql.Params("LAYOUT_NM") = LAYOUT_NM
                    sql.Params("CONTROL") = dr("CONTROL")
                    sql.Params("FORMULA") = dr("FORMULA")
                    sql.Params("INS_USR") = YJIT.SessionInfo.UserID
                    db.SqlSet(sql.Text)
                Next
                '==============================================================
                ResultSet("TrxCode") = "Y"
                '성공 유무의 메세지는 생략.
                ResultSet("TrxMsg") = "Success"
                db.Commit()
            Catch ex As Exception
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
                db.Rollback()
            Finally
                db.EndTransaction()
            End Try
            ResultSet("Data") = GetLayoutList(SessionInfo.OfficeCode, FormId)("Data")
            Return ResultSet
        End Function

        Public Shared Function DeleteLayout(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim CRM_LAYOUT_MST As DataTable
            Dim ErrorOccur As Boolean = True
            Dim FormId As String = ""
            Dim LAYOUT_NM As String = ""
            db.BeginTransaction()
            Try
                '
                If Not ds.Tables.Contains("CRM_LAYOUT_MST") Then
                    ThrowMsg(ErrorOccur, "Data Table missing. (CRM_LAYOUT_MST)")
                End If
                CRM_LAYOUT_MST = ds.Tables("CRM_LAYOUT_MST")
                FormId = CRM_LAYOUT_MST.Rows(0)("FORM_ID").ToString
                LAYOUT_NM = CRM_LAYOUT_MST.Rows(0)("LAYOUT_NM").ToString

                '=================== DETAIL =================================== 

                Dim sql As New SqlBox("Common@DeleteLayout")
                sql.Params("OFFICE_CD") = SessionInfo.OfficeCode
                sql.Params("FORM_ID") = FormId
                sql.Params("LAYOUT_NM") = LAYOUT_NM
                db.SqlSet(sql.Text)

                sql = New SqlBox("Common@DeleteLayoutFromula")
                sql.Params("OFFICE_CD") = SessionInfo.OfficeCode
                sql.Params("FORM_ID") = FormId
                sql.Params("LAYOUT_NM") = LAYOUT_NM
                db.SqlSet(sql.Text)

                '==============================================================
                ResultSet("TrxCode") = "Y"
                '성공 유무의 메세지는 생략.
                ResultSet("TrxMsg") = "Success"
                db.Commit()
            Catch ex As Exception
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
                db.Rollback()
            Finally
                db.EndTransaction()
            End Try
            ResultSet("Data") = GetLayoutList(SessionInfo.OfficeCode, FormId)("Data")
            Return ResultSet
        End Function

        '====================================================================================
        ' Key 채번 
        ' KeyType : Key Type
        ' ReqSvc  : Request Service
        ' ExImType : Export, Import
        ' yyymmdd  : Create Date
        ' OptItem1~3 : option
        '====================================================================================
        Public Shared Function GenerationKeyNo(ByVal KeyType As String, _
                                        ByVal ReqSvc As String, _
                                        ByVal ExImType As String, _
                                        ByVal yyymmdd As String, _
                                        ByVal OptItem1 As String, _
                                        ByVal OptItem2 As String, _
                                        ByVal OptItem3 As String) As Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ErrorOccur As Boolean = True
            Dim sql As SqlBox = Nothing
            Dim dt As DataTable = Nothing
            Dim preFix1 As String = ""
            Dim preFix2 As String = ""
            Dim preFix3 As String = ""
            Dim RuleCode As String = ""
            Dim KeyNo As String = ""

            Try

                Dim param As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
                param("P_OFFICE_CD") = "YJIT"
                param("P_KEY_TYPE") = KeyType
                param("P_REQ_SVC") = ReqSvc
                param("P_PREFIX") = "Y"
                param("P_EX_IM_TYPE") = ExImType
                param("P_KEY_YMD") = yyymmdd
                param("P_OPT_ITEM1") = OptItem1
                param("P_OPT_ITEM2") = OptItem2
                param("P_OPT_ITEM3") = OptItem3
                param("R_PRE_FIX1") = ""
                param("R_PRE_FIX2") = ""
                param("R_PRE_FIX3") = ""
                param("R_RULE_CD") = ""
                param("R_RTNCD") = ""
                param("R_RTNMSG") = ""
                db.ExecuteProcedure("USP_KEYNO_PREFIX", param)
                If ("" & param("R_RTNCD").ToString) = "E" Then
                    ThrowMsg(ErrorOccur, param("R_RTNMSG").ToString)
                End If
                preFix1 = param("R_PRE_FIX1").ToString
                preFix2 = param("R_PRE_FIX2").ToString
                preFix3 = param("R_PRE_FIX3").ToString
                RuleCode = param("R_RULE_CD").ToString


                Dim paramKeyNo As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
                paramKeyNo("P_OFFICE_CD") = "YJIT"
                paramKeyNo("P_KEY_TYPE") = KeyType
                paramKeyNo("P_RULE_CD") = RuleCode
                paramKeyNo("P_PRE_FIX1") = preFix1
                paramKeyNo("P_PRE_FIX2") = preFix2
                paramKeyNo("P_PRE_FIX3") = preFix3
                paramKeyNo("R_RTNCD") = ""
                paramKeyNo("R_RTNMSG") = ""

                db.ExecuteProcedure("USP_KEYNO_CREATE", paramKeyNo)

                If ("" & paramKeyNo("R_RTNCD").ToString) = "E" Then
                    ThrowMsg(ErrorOccur, paramKeyNo("R_RTNMSG").ToString)
                End If

                KeyNo = paramKeyNo("R_RTNCD").ToString
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"

            Catch ex As Exception
                resultSet("TrxCode") = "E"
                resultSet("TrxMsg") = ex.Message
            End Try
            resultSet("KEY_NO") = KeyNo

            Return resultSet

        End Function

        Public Shared Function GetOfficeConfig(ByVal OfficeCd As String, ByVal Item As String) As Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ErrorOccur As Boolean = False
            Dim dt As DataTable = Nothing

            'Item

            Try
                Dim ds As New DataSet
                Dim sql As New SqlBox("Common@GetOfficeConfig")
                sql.Params("OFFICE_CD") = OfficeCd

                Select Case Item
                    Case "AutoInvoice"
                        sql.Params("ITEM_CD") = ""
                End Select
                dt = db.SqlGet(sql.Text, False)

                resultSet("KEY_CD") = dt.Rows(0)("KEY_CD")
                resultSet("KEY_VAL") = dt.Rows(0)("KEY_VAL")
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"

            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxCode") = ex.Message
            End Try

            Return resultSet

        End Function


        Public Shared Function TryGetRowValue(ByVal Row As DataRow, ByVal ColumnName As String) As String

            Dim RetrunString As String = ""
            Try
                RetrunString = Row(ColumnName)
            Catch ex As Exception
                RetrunString = ""
            End Try

            Return RetrunString
        End Function

        '====================================================================================
        ' 문자열 자르기
        '====================================================================================
        Public Shared Function yjitSubstr(ByVal tStr As String, ByVal nS As Integer, ByVal nL As Integer) As String
            Dim rtnStr As String = tStr & Space(500)

            Try
                rtnStr = rtnStr.Substring(nS, nL).Trim
            Catch ex As Exception
                rtnStr = tStr.Trim
            End Try

            Return rtnStr

        End Function

        Public Shared Function SearchOfficeView() As Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ErrorOccur As Boolean = False
            Try
                Dim sql As New SqlBox("Common@SearchOfficeView")
                Dim ResultDs As New DataSet
                sql.Params("OFFICE_CD") = SessionInfo.OfficeCode
                Dim dt As DataTable
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "OfficeView"
                ResultDs.Tables.Add(dt)
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = ResultDs
            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxCode") = ex.Message
            End Try
            Return resultSet
        End Function

        'db 연결 
        Public Shared Function GetConnectionString(ByVal pIP As String, ByVal pPort As String, ByVal pSID As String, ByVal pUserID As String, ByVal pPassword As String) As String
            Dim conntionString As String =
                "Data Source=" &
                    "(DESCRIPTION=(CID=GTU_APP)" &
                        "(ADDRESS_LIST=" &
                                "(ADDRESS=" &
                                        "(PROTOCOL=TCP)(HOST=" & pIP & ")(PORT=" & pPort & ")" &
                                ")" &
                        ")(CONNECT_DATA=(SERVICE_NAME=" & pSID & ")(SERVER=DEDICATED))" &
                    ");User Id=" & pUserID & ";Password=" & pPassword & ";"

            Return conntionString
        End Function


    End Class


End Namespace

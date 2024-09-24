Imports YJIT.SC.UI
Imports YJIT.SC.App.FreightCommon
Imports YJIT.SC.App.Common
Imports System.Net.Mail
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Text.RegularExpressions

Public Class CrmBigAprMgt
    Dim SelectAllYn As Boolean = False
#Region "=================GetConvertToDataSet Function==========="
    Private Function GetConvertToDataSet(ByVal SearchType As String, Optional ByVal dtWG1 As DataTable = Nothing) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)

        Select Case SearchType.ToUpper
            Case "Search".ToUpper
                YJSql.SqlBox("WG1", "CrmBigAprMgt@Search",, False)
                YJSql.Params("APV_YN", drMAIN("S_APV_YN").ToString)
                YJSql.Params("OFFICE_NM", drMAIN("S_OFFICE_NM").ToString)
                YJSql.Params("EMAIL", drMAIN("S_EMAIL").ToString)
                YJSql.Params("CRN", drMAIN("S_CRN").ToString)
            Case "SearchEmail".ToUpper
                Dim emailList As String = String.Empty
                For Each row As DataRow In dtWG1.Rows
                    If Not String.IsNullOrEmpty(emailList) Then emailList &= "','"
                    emailList &= row("EMAIL").ToString
                Next
                YJSql.SqlBox("WG1", "CrmBigAprMgt@SearchEmail", True)
                YJSql.Params("EMAIL", emailList)
        End Select

        Return YJSql.DataSet
    End Function
    'Private Function GetConvertToDataSet_ChkDup() As DataSet
    '    Dim YJSql As New YJQuery
    '    Dim IsSingleSearch As Boolean = False

    '    Try
    '        YJSql.SqlBox("WG1", "CrmBigAprMgt@SearchDuplicate", , False)
    '        YJSql.Params("EMAIL", GV1.GetRowCellValue(GV1.FocusedRowHandle, "EMAIL").ToString)
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try

    '    Return YJSql.DataSet
    'End Function
#End Region
#Region "=================Data logic actions==========="
    'Search
    Private Sub SearchData()
        If SearchValidate() = False Then Exit Sub
        Dim dsret As DataSet = GetConvertToDataSet("Search")
        dsret = MethodCallEx(Me, "YJIT.Biz.CrmBigAprMgt", "Search", {dsret})
        Dim drpairs As DataRow = dsret.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case drpairs("TrxCode")
            Case "Y"
                Me.BindToDataset(dsret, "Data")
                Me.DataState = UI.DataStates.Retrieved
                If GV1.RowCount = 0 Then
                    MsgBoxLocalized("Data not found!")
                End If

                Me.DataState = UI.DataStates.Retrieved
            Case "N"
                MsgBoxLocalized(drpairs("TrxMsg"))
                Call ClearView(AppliedRangeTypes.Only, {WG1})
                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(drpairs("trxMsg"))
        End Select
    End Sub
    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Try
            If Not String.IsNullOrEmpty(ErrMsg) Then
                If Not ErrControl Is Nothing Then ErrControl.Focus()
                Throw New Exception(ErrMsg)
            End If
            Return True
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
    End Function
    'Save
    Private Sub SaveData()
        If MandatoryGridValue("GV1") Then Exit Sub

        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then Exit Sub

        '실제 수정된것만 서버에가게 수정
        Dim dtEmail As DataTable = CType(WG1.DataSource, DataTable).Clone
        dtEmail.TableName = "WG1"
        For i = 0 To CType(WG1.DataSource, DataTable).Rows.Count - 1
            If GV1.GetDataRow(i).RowState = DataRowState.Added Then
                If GV1.GetDataRow(i)("APV_YN").ToString <> GV1.GetDataRow(i)("DB_APV_YN").ToString _
                             AndAlso GV1.GetDataRow(i)("APV_YN").ToString <> "N" Then
                    dtEmail.ImportRow(GV1.GetDataRow(i))
                End If
                Continue For '신규자료건은 제외
            End If
            GV1.GetDataRow(i).AcceptChanges()

            '저장+메일 진행
            If GV1.GetDataRow(i)("APV_YN").ToString <> GV1.GetDataRow(i)("DB_APV_YN").ToString Then
                GV1.GetDataRow(i).SetModified()
                If GV1.GetDataRow(i)("APV_YN").ToString <> GV1.GetDataRow(i)("DB_APV_YN").ToString _
                             AndAlso GV1.GetDataRow(i)("APV_YN").ToString <> "N" Then
                    dtEmail.ImportRow(GV1.GetDataRow(i))
                End If
            ElseIf GV1.GetDataRow(i)("EMAIL_MSG").ToString <> GV1.GetDataRow(i)("DB_EMAIL_MSG").ToString Then
                GV1.GetDataRow(i).SetModified()
                If GV1.GetDataRow(i)("APV_YN").ToString <> GV1.GetDataRow(i)("DB_APV_YN").ToString _
                             AndAlso GV1.GetDataRow(i)("APV_YN").ToString <> "N" Then
                    dtEmail.ImportRow(GV1.GetDataRow(i))
                End If
            End If

            '저장만 진행
            If GV1.GetDataRow(i)("CRM_CD").ToString <> GV1.GetDataRow(i)("DB_CRM_CD").ToString Then
                GV1.GetDataRow(i).AcceptChanges()
                GV1.GetDataRow(i).SetModified()
            ElseIf GV1.GetDataRow(i)("COL_LAT").ToString <> GV1.GetDataRow(i)("DB_COL_LAT").ToString Then
                GV1.GetDataRow(i).AcceptChanges()
                GV1.GetDataRow(i).SetModified()
            ElseIf GV1.GetDataRow(i)("COL_SCH").ToString <> GV1.GetDataRow(i)("DB_COL_SCH").ToString Then
                GV1.GetDataRow(i).AcceptChanges()
                GV1.GetDataRow(i).SetModified()
            ElseIf GV1.GetDataRow(i)("COL_SFI").ToString <> GV1.GetDataRow(i)("DB_COL_SFI").ToString Then
                GV1.GetDataRow(i).AcceptChanges()
                GV1.GetDataRow(i).SetModified()
            ElseIf GV1.GetDataRow(i)("COL_TER").ToString <> GV1.GetDataRow(i)("DB_COL_TER").ToString Then
                GV1.GetDataRow(i).AcceptChanges()
                GV1.GetDataRow(i).SetModified()
            ElseIf GV1.GetDataRow(i)("COL_TRK").ToString <> GV1.GetDataRow(i)("DB_COL_TRK").ToString Then
                GV1.GetDataRow(i).AcceptChanges()
                GV1.GetDataRow(i).SetModified()
            ElseIf GV1.GetDataRow(i)("COL_UNI").ToString <> GV1.GetDataRow(i)("DB_COL_UNI").ToString Then
                GV1.GetDataRow(i).AcceptChanges()
                GV1.GetDataRow(i).SetModified()
            End If
        Next

        Dim ds As DataSet = Me.ConvertToDataset
        Dim SearchDs As DataSet = GetConvertToDataSet("Search")
        ds.Merge(SearchDs)

        If ds.Tables("WG1").Rows.Count = 0 Then
            MsgBoxLocalized("Data Is empty!")
            Exit Sub
        End If

        If SaveValidate(ds) = False Then Exit Sub

        Try
            Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", "자료 저장중 입니다. 잠시만 기다려 주세요.")
                ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmBigAprMgt", "Save", {ds})
            End Using
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        '메일 메시지에 대한 변수
        ' Dim Msg As String = String.Empty

        Select Case dr("TrxCode")
            Case "Y"
                '오른쪽은 구분자로서 임시패스워드 메일인지 상태값의 메일인지 구분하기위해 던짐 S = status / P = password
                If dtEmail.Rows.Count > 0 Then
                    Dim dsEmail As DataSet = GetConvertToDataSet("SearchEmail", dtEmail)
                    Try
                        dsEmail = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmBigAprMgt", "Search", {dsEmail})
                    Catch ex As Exception
                        MsgBoxLocalized(ex.Message)
                        Exit Sub
                    End Try
                    Dim drEmail As DataRow = dsEmail.Tables("KEY_VALUE_PAIRS").Rows(0)

                    Select Case drEmail("TrxCode").ToString
                        Case "Y"
                            Call MailSend(dsEmail.Tables("Data.WG1").Copy)
                        Case Else
                            MsgBoxLocalized(String.Format("저장은 완료되었으며, 메일전송에 실패했습니다.{0}({1})", vbNewLine, drEmail("TrxMsg").ToString))
                            Exit Sub
                    End Select
                Else
                    MsgBoxLocalized(dr("TrxMsg"))
                End If

                If IsNothing(ds.Tables("Data.WG1")) OrElse ds.Tables("Data.WG1").Rows.Count <= 0 Then
                    MsgBoxLocalized("Data Not found!")
                    ClearView(AppliedRangeTypes.Only, {WG1})
                Else
                    Me.BindToDataset(ds, "Data")
                End If
                Me.DataState = UI.DataStates.Retrieved
            Case "Q"
                MsgBoxLocalized(dr("TrxMsg"))
            Case Else
                MsgBoxLocalized(dr("TrxMsg"))
        End Select
    End Sub
    Public Function SaveValidate(ByVal ds As DataSet)
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrGrid As Object = Nothing
        Dim ErrGridRow As Integer = Nothing
        Dim ErrGridCol As Object = Nothing
        Dim dt As DataTable = ds.Tables("WG1").Copy
        Try
            Try
                For i = 0 To dt.Rows.Count - 1
                    If dt(i)("APV_YN").ToString = "Y" AndAlso dt(i)("CRM_CD").ToString = "" Then
                        ErrMsg &= Me.Localizer1.GetLocalizedString("CRM 코드는 필수입니다!") & vbNewLine
                        If ErrGrid Is Nothing Then
                            ErrGrid = GV1
                            ErrGridRow = i
                            ErrGridCol = CType(GV1, DevExpress.XtraGrid.Views.Grid.GridView).Columns("CRM_CD")
                        End If
                        Exit Try
                    End If
                Next
            Catch ex As Exception
                MsgBoxLocalized(ex.Message)
            End Try

            Try
                For i = 0 To dt.Rows.Count - 1
                    If dt(i)("APV_YN").ToString = "D" AndAlso dt(i)("EMAIL_MSG").ToString = "" Then
                        ErrMsg &= Me.Localizer1.GetLocalizedString("거절 사유는 필수입니다!") & vbNewLine
                        If ErrGrid Is Nothing Then
                            ErrGrid = GV1
                            ErrGridRow = i
                            ErrGridCol = CType(GV1, DevExpress.XtraGrid.Views.Grid.GridView).Columns("EMAIL_MSG")
                        End If
                        Exit Try
                    End If
                Next
            Catch ex As Exception
                MsgBoxLocalized(ex.Message)
            End Try

            If Not String.IsNullOrEmpty(ErrMsg) Then
                If Not ErrControl Is Nothing Then
                    ErrControl.Focus()
                Else
                    If Not ErrGrid Is Nothing Then
                        ErrGrid.FocusedRowHandle = ErrGridRow
                        ErrGrid.FocusedColumn = ErrGridCol
                    End If
                End If
                Throw New Exception(ErrMsg)
            End If

        Catch ex As Exception
            MsgBoxLocalized(Me.Localizer1.GetLocalizedString("Please check the contents below and correct them.") & vbNewLine & vbNewLine & ex.Message)
            Return False
        End Try

        Return True
    End Function
    Public Function MandatoryGridValue(ByVal gridView As String) As Boolean
        Dim Param As New Dictionary(Of String, Object)
        Dim checkNull() As String = Nothing

        Select Case gridView
            Case "GV1"
                ' checkNull = {"EMAIL", "CUST_CD", "DEF_OFFICE_CD"}
                ' Param("CUST_CD") = GV1_CUST_CD.Caption
                ' Param("DEF_OFFICE_CD") = GV1_DEF_OFFICE_CD.Caption
                Return ValidateGridValue(GV1, Param, checkNull)
        End Select
        Return False
    End Function
    Private Function MailSend(ByVal dtEmail As DataTable, Optional ByVal ChkErr As Boolean = False)
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim ds As DataSet = New DataSet
            ds.Tables.Add(dtEmail)
            dtEmail.TableName = "WG1"

            Dim dt As DataTable = New DataTable

            '이메일 전송을 위한 작업
            dt.TableName = "EMAIL_INFO"

            Dim Mailinfo() As String = {"MNGT_NO", "CUST_PIC_MAIL", "PKGE_TYPE", "TITLE", "SUB_TITLE", "BTN_NM", "BTN_URL", "JOB_TYPE", "Flag", "DOMAIN", "REF1"}
            Dim MailContent() As String = {"MNGT_NO", "COLUMN", "DATA", "COLUMN2", "DATA2"}
            Dim MailSummary() As String = {"MNGT_NO", "TYPE", "TITLE", "COLUMN", "DATA"}


            '이메일 컬럼 추가
            For i As Integer = 0 To Mailinfo.Length - 1
                dt.Columns.Add(Mailinfo(i), GetType(String))
            Next

            For i As Integer = 0 To ds.Tables("WG1").Rows.Count - 1
                If ds.Tables("WG1")(i)("APV_YN").ToString = "Y" Then
                    dt.Rows.Add()
                    dt(i)("MNGT_NO") = ds.Tables("WG1")(i)("EMAIL").ToString 'EMAIL
                    dt(i)("CUST_PIC_MAIL") = ds.Tables("WG1")(i)("EMAIL").ToString
                    dt(i)("TITLE") = "[엘비스빅]" & " 서비스신청 " & ds.Tables("WG1")(i)("APV_YN_NM").ToString & " 안내의 건" '메일제목
                    dt(i)("SUB_TITLE") = "엘비스빅 사용" & ds.Tables("WG1")(i)("APV_YN_NM").ToString & " 안내드립니다."
                    dt(i)("PKGE_TYPE") = "QUO" '견적서 폼으로 가기위해 조작.
                    dt(dt.Rows.Count - 1)("SUB_TITLE") = "서비스 가입에 감사 드립니다." & vbNewLine & vbNewLine & "추가 문의사항이 있으실 경우 온라인톡(yjit.co.kr)을 이용해 주시기 바랍니다." '메일상단에 들어가는 내용
                Else
                    dt.Rows.Add()
                    dt(i)("MNGT_NO") = ds.Tables("WG1")(i)("EMAIL").ToString 'EMAIL
                    dt(i)("CUST_PIC_MAIL") = ds.Tables("WG1")(i)("EMAIL").ToString
                    dt(i)("TITLE") = "[엘비스빅]" & " 서비스신청 " & ds.Tables("WG1")(i)("APV_YN_NM").ToString & " 안내의 건" '메일제목
                    dt(i)("SUB_TITLE") = "서비스 " & ds.Tables("WG1")(i)("APV_YN_NM").ToString & " 안내드립니다."
                    dt(i)("PKGE_TYPE") = "QUO" '견적서 폼으로 가기위해 조작.
                    dt(dt.Rows.Count - 1)("SUB_TITLE") = "서비스 가입이 불가함을 안내드립니다." & vbNewLine & vbNewLine & "추가 문의사항이 있으실 경우 온라인톡(yjit.co.kr)을 이용해 주시기 바랍니다." '메일상단에 들어가는 내용
                End If

            Next

            ds.Tables.Add(dt)

            dt = New DataTable
            dt.TableName = "EMAIL_CONTENT" '실제 메일나가는 부분

            For i As Integer = 0 To MailContent.Length - 1
                dt.Columns.Add(MailContent(i), GetType(String))
            Next

            For i As Integer = 0 To ds.Tables("WG1").Rows.Count - 1
                If ds.Tables("WG1")(i)("APV_YN").ToString = "Y" Then
                    dt.Rows.Add()
                    dt(dt.Rows.Count - 1)("MNGT_NO") = ds.Tables("WG1")(i)("EMAIL").ToString 'EMAIL
                    dt(dt.Rows.Count - 1)("COLUMN") = "아이디"
                    dt(dt.Rows.Count - 1)("DATA") = ds.Tables("WG1")(i)("EMAIL").ToString
                    dt(dt.Rows.Count - 1)("COLUMN2") = "포워더 사업자번호"
                    dt(dt.Rows.Count - 1)("DATA2") = String.Format("{0}-{1}-{2}", Mid(ds.Tables("WG1")(i)("FOR_CRN").ToString, 1, 3), Mid(ds.Tables("WG1")(i)("FOR_CRN").ToString, 4, 2), Mid(ds.Tables("WG1")(i)("FOR_CRN").ToString, 6))
                    'dt(dt.Rows.Count - 1)("COLUMN") = "도메인"
                    'dt(dt.Rows.Count - 1)("DATA") = ds.Tables("WG1")(i)("DOMAIN").ToString
                    'dt(dt.Rows.Count - 1)("COLUMN2") = "아이디/비밀번호"
                    'dt(dt.Rows.Count - 1)("DATA2") = ds.Tables("WG1")(i)("ELVIS_USR_ID").ToString & " / " & ds.Tables("WG1")(i)("ELVIS_PSWD").ToString
                    'dt.Rows.Add()
                    'dt(dt.Rows.Count - 1)("MNGT_NO") = ds.Tables("WG1")(i)("EMAIL").ToString 'EMAIL
                    'dt(dt.Rows.Count - 1)("COLUMN") = "설치 주소"
                    'dt(dt.Rows.Count - 1)("DATA") = ds.Tables("WG1")(i)("SETUP_URL").ToString '& vbNewLine & vbNewLine& & "* 위 URL 접속 후 도메인 입력란에 해당 도메인을 입력하신 후" & vbNewLine & "파일이 다운로드되면 실행하셔서 Install 버튼을 눌러 진행해 주시면 됩니다."
                End If
            Next
            ds.Tables.Add(dt)

            dt = New DataTable
            dt.TableName = "EMAIL_CONTENT_SUMMARY1"

            For j As Integer = 0 To MailSummary.Length - 1
                dt.Columns.Add(MailSummary(j), GetType(String))
            Next

            For i As Integer = 0 To ds.Tables("WG1").Rows.Count - 1
                If ds.Tables("WG1")(i)("APV_YN").ToString = "Y" Then
                    dt.Rows.Add()
                    dt(dt.Rows.Count - 1)("MNGT_NO") = ds.Tables("WG1")(i)("EMAIL").ToString 'EMAIL
                    'dt(dt.Rows.Count - 1)("TYPE") = ChkLoad
                    dt(dt.Rows.Count - 1)("TITLE") = "서비스 안내"
                    dt(dt.Rows.Count - 1)("COLUMN") = "업체명"
                    dt(dt.Rows.Count - 1)("DATA") = ds.Tables("WG1")(i)("CUST_NM").ToString '도메인에 맞는 업체명
                    'dt.Rows.Add()
                    'dt(dt.Rows.Count - 1)("MNGT_NO") = ds.Tables("WG1")(i)("EMAIL").ToString 'EMAIL
                    ''dt(dt.Rows.Count - 1)("TYPE") = ChkLoad
                    'dt(dt.Rows.Count - 1)("COLUMN") = "신청 서비스"
                    'dt(dt.Rows.Count - 1)("DATA") = ds.Tables("WG1")(i)("SVC_LIST").ToString
                    'dt.Rows.Add()
                    'dt(dt.Rows.Count - 1)("MNGT_NO") = ds.Tables("WG1")(i)("EMAIL").ToString 'EMAIL
                    ''dt(dt.Rows.Count - 1)("TYPE") = ChkLoad
                    'dt(dt.Rows.Count - 1)("COLUMN") = "서비스 금액"
                    'dt(dt.Rows.Count - 1)("DATA") = "KRW " & ds.Tables("WG1")(i)("SVC_TOT_AMT").ToString
                    'dt.Rows.Add()
                    'dt(dt.Rows.Count - 1)("MNGT_NO") = ds.Tables("WG1")(i)("EMAIL").ToString 'EMAIL
                    ''dt(dt.Rows.Count - 1)("TYPE") = ChkLoad
                    'dt(dt.Rows.Count - 1)("COLUMN") = "가입일시"
                    'dt(dt.Rows.Count - 1)("DATA") = ds.Tables("WG1")(i)("REG_DATE").ToString
                    dt.Rows.Add()
                    dt(dt.Rows.Count - 1)("MNGT_NO") = ds.Tables("WG1")(i)("EMAIL").ToString 'EMAIL
                    'dt(dt.Rows.Count - 1)("TYPE") = ChkLoad
                    dt(dt.Rows.Count - 1)("COLUMN") = "비고"
                    dt(dt.Rows.Count - 1)("DATA") = ds.Tables("WG1")(i)("RMK").ToString
                Else
                    dt.Rows.Add()
                    dt(dt.Rows.Count - 1)("MNGT_NO") = ds.Tables("WG1")(i)("EMAIL").ToString 'EMAIL
                    'dt(dt.Rows.Count - 1)("TYPE") = ChkLoad
                    dt(dt.Rows.Count - 1)("TITLE") = "안내"
                    dt(dt.Rows.Count - 1)("COLUMN") = "업체명"
                    dt(dt.Rows.Count - 1)("DATA") = ds.Tables("WG1")(i)("CUST_NM").ToString '도메인에 맞는 업체명
                    'dt.Rows.Add()
                    'dt(dt.Rows.Count - 1)("MNGT_NO") = ds.Tables("WG1")(i)("EMAIL").ToString 'EMAIL
                    ''dt(dt.Rows.Count - 1)("TYPE") = ChkLoad
                    'dt(dt.Rows.Count - 1)("COLUMN") = "신청 서비스"
                    'dt(dt.Rows.Count - 1)("DATA") = ds.Tables("WG1")(i)("SVC_LIST").ToString
                    dt.Rows.Add()
                    dt(dt.Rows.Count - 1)("MNGT_NO") = ds.Tables("WG1")(i)("EMAIL").ToString 'EMAIL
                    'dt(dt.Rows.Count - 1)("TYPE") = ChkLoad
                    dt(dt.Rows.Count - 1)("COLUMN") = "거절 사유"
                    dt(dt.Rows.Count - 1)("DATA") = ds.Tables("WG1")(i)("EMAIL_MSG").ToString
                End If
            Next
            ds.Tables.Add(dt)

            Dim drResult As DataRow

            Try
                Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", "메일 전송중 입니다. 잠시만 기다려 주세요.")
                    ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmBigAprMgt", "SendMail", {ds})
                End Using
                drResult = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

                Select Case drResult("trxCode").ToString
                    Case "Y"
                        If ChkErr = False Then
                            MsgBoxLocalized(drResult("trxMsg"))
                        Else
                            Return ""
                        End If
                    Case "N1"
                        MsgBoxLocalized(drResult("trxMsg"))
                    Case Else
                        If ChkErr = False Then
                            Throw New Exception(Func.Msg(Me, "{0} error has occurred, so we excluded it!", drResult("TrxStr").ToString))
                        Else
                            Return drResult("TrxStr").ToString
                        End If

                End Select
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBoxLocalized(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try


        Return ""
    End Function
    Private Sub SetApplyType()
        Dim dt As New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")

        For i As Integer = 0 To GV1.Columns.Count - 1
            If GV1.Columns(i).Visible = True AndAlso GV1.Columns(i).ReadOnly = False AndAlso GV1.Columns(i).FieldName <> "CHK" AndAlso GV1.Columns(i).FieldName <> "CRM_CD" Then
                dt.Rows.Add()
                dt(dt.Rows.Count - 1)("CODE") = GV1.Columns(i).FieldName
                dt(dt.Rows.Count - 1)("NAME") = GV1.Columns(i).Caption
            End If
        Next

        Apply_Type.DataSource = dt
        Apply_Type.DefVal = "APV_YN"
        Apply_Type.SelectedValue = "APV_YN"
    End Sub
#End Region
#Region "=================Client Function==========="
    Public Sub PopUpOnAfterClick(ByVal dr As DataRow)
        Dim Key As String = dr("Key")

        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing
        Select Case dr("Sender").ToString
            Case "WG1"
                If fTarget IsNot Nothing Then
                    For i As Integer = 0 To GV1.RowCount - 1
                        If GV1.GetRowCellValue(i, "CHK").ToString = "Y" Then
                            GV1.GetDataRow(i).AcceptChanges()
                            GV1.GetDataRow(i).SetAdded()
                        Else
                            GV1.GetDataRow(i).AcceptChanges()
                        End If
                    Next

                    Dim dt As DataTable = Me.ConvertToDataset.Tables("WG1")
                    For Each dr In dt.Rows
                        If dr("CHK").ToString = "N" Then
                            dt.Rows.Remove(dr)
                        End If
                    Next
                    fTarget.ClearView()
                    fTarget.showDialog()
                End If

                Select Case Key
                    Case "GV1_SelectAll"
                        Call SelectAll()
                End Select
        End Select
    End Sub
    Private Sub SelectAll()
        Dim checkYn As String = GV1.GetRowCellValue(0, "CHK").ToString
        SelectAllYn = True
        For i As Integer = 0 To GV1.RowCount - 1
            If checkYn = "Y" Then
                GV1.SetRowCellValue(i, "CHK", "N")
            Else
                GV1.SetRowCellValue(i, "CHK", "Y")
            End If
        Next
    End Sub
    Public Sub PopUpInit()
        Dim PopUp As New PopupBase
        PopUp.ItemAdd(Action.Other, "Selectdata", "Select identical data")
        PopUp.ItemAdd(Action.EventKey, "GV1_SelectAll", "&Select All")
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", "&Export Excel", True)
        PopUp.PopUpInit(Me, WG1)

        Call SetApplyType()
    End Sub
    Private Sub InitGrid()
        Call DrawRowIndicator({GV1})

        Dim editorCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        'Dim searchParams As Dictionary(Of String, Object)
        'Dim dataParams As Dictionary(Of String, Object)

        'editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        'editorCombo.ValueMember = "CODE"
        'editorCombo.DisplayMember = "NAME"
        'editorCombo.NullText = ""
        'searchParams = New Dictionary(Of String, Object)
        'dataParams = New Dictionary(Of String, Object)
        'dataParams.Add("GroupCode", "R06")
        'dataParams.Add("NameType", "A")
        'editorCombo.ShowHeader = False
        'editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        'editorCombo.ForceInitialize() : editorCombo.PopulateColumns()
        'editorCombo.Columns("CODE").Visible = False
        'GV1.Columns("APV_YN").ColumnEdit = editorCombo
        'AddHandler editorCombo.EditValueChanged, AddressOf SetEditValueChanged


        editorCombo = GridFunc.GetRepositoryItemLookUpEdit("CommonCode", "GroupCode:'R06',NameType:'A'")
        GV1.Columns("APV_YN").ColumnEdit = editorCombo
        AddHandler editorCombo.EditValueChanged, AddressOf SetEditValueChanged

        GV1.Columns("CRM_CD").ColumnEdit = GridFunc.GetRepositoryItemCodeBoxEdit("Customer", "Type:''", "Code:#CRM_CD", "KEY:#CRM_CD")

        'editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        'editorCombo = GridFunc.GetRepositoryItemLookUpEdit({"Y:Yes", "N:No"})
        'editorCombo.ForceInitialize() : editorCombo.PopulateColumns()
        'editorCombo.Columns("CODE").Visible = False
        'GV1.Columns("COL_LAT").ColumnEdit = editorCombo
        'GV1.Columns("COL_SCH").ColumnEdit = editorCombo
        'GV1.Columns("COL_SFI").ColumnEdit = editorCombo
        'GV1.Columns("COL_TER").ColumnEdit = editorCombo
        'GV1.Columns("COL_TRK").ColumnEdit = editorCombo
        'GV1.Columns("COL_UNI").ColumnEdit = editorCombo

    End Sub
    Private Sub SetEditValueChanged(sender As Object, e As System.EventArgs)
        Dim iFocusedRowHandle As Integer = GV1.FocusedRowHandle
        GV1.FocusedRowHandle = -1
        GV1.FocusedRowHandle = iFocusedRowHandle
    End Sub
    '엑셀 출력
    Private Sub GridToExcel(ByVal obj As YJIT.SC.UI.SCControls.WebGrid)
        Common.ExportToExcel(obj)
    End Sub
    'Private Function validateEmail(emailAddress) As Boolean

    '    Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
    '    If email.IsMatch(emailAddress) Then
    '        '통과
    '        Return True
    '    Else
    '        MsgBoxLocalized("Please enter it in email format!") '이메일형식으로 입력해주세요!
    '        GV1.SetRowCellValue(GV1.FocusedRowHandle, "CHK_DUP", "Y")
    '        GV1.FocusedColumn = GV1.Columns("EMAIL")
    '        Return False
    '        Exit Function
    '    End If

    'End Function
#End Region
#Region "=================Control Events==========="
    'Client Function : 클라이언트 동작 함수
    Private Sub CrmBigAprMgt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClearView()
        Call SetMandatoryLine(Me)
    End Sub
    Private Sub CrmBigAprMgt_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Call PopUpInit()
        Call InitGrid()

        Call SearchData()

        S_APV_YN.Focus()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub
    Private Sub btnExpFwg1_Click(sender As Object, e As EventArgs) Handles btnExpFwg1.Click
        Call GridToExcel(WG1)
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call ClearView()
        Apply_Type.SelectedValue = "APV_YN"
        Apply_Type.DefVal = "APV_YN"
        Apply_YN.SelectedValue = "Y"
        Apply_YN.DefVal = "Y"
    End Sub
    Public Sub SearchFromMsg(ByVal key1 As String, ByVal key2 As String, ByVal key3 As String, ByVal key4 As String, ByVal key5 As String)
        S_EMAIL.Text = key1
        Call SearchData()
    End Sub
    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Dim chk As String = "N"
        For i As Integer = 0 To GV1.RowCount - 1
            If GV1.GetRowCellValue(i, "CHK").ToString = "Y" Then
                chk = "Y"
                Exit For
            End If
        Next

        If chk = "Y" Then
            For i As Integer = 0 To GV1.RowCount - 1
                If GV1.GetRowCellValue(i, "CHK").ToString = "Y" Then
                    GV1.FocusedRowHandle = i

                    Select Case Apply_Type.SelectedValue.ToString
                        Case "APV_YN"
                            GV1.SetRowCellValue(i, Apply_Type.SelectedValue.ToString, Apply_Status.SelectedValue.ToString)
                        Case "EMAIL_MSG"
                            If GV1.GetRowCellValue(i, "APV_YN").ToString = "D" Or GV1.GetRowCellValue(i, "APV_YN").ToString = "S" Then
                                GV1.SetRowCellValue(i, Apply_Type.SelectedValue.ToString, Apply_Text.Text)
                            End If
                        Case Else
                            GV1.SetRowCellValue(i, Apply_Type.SelectedValue.ToString, Apply_YN.SelectedValue.ToString)
                    End Select
                End If
            Next
            GV1.RefreshData()
        Else
            MsgBoxLocalized("Nothing is selected. Select and reapply.")
        End If
    End Sub

    Private Sub GV1_ShownEditor(sender As Object, e As EventArgs) Handles GV1.ShownEditor
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)

        Select Case GV1.FocusedColumn.FieldName
            Case "APV_YN"
                Dim edit As DevExpress.XtraEditors.LookUpEdit
                Dim table As DataTable
                Dim clone As DataView
                Dim row As DataRow
                edit = CType(view.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
                table = CType(edit.Properties.DataSource, DataTable)
                clone = New DataView(table)
                row = view.GetDataRow(view.FocusedRowHandle)
                clone.RowFilter = "[CODE] <> 'N' "
                edit.Properties.DataSource = clone
        End Select
    End Sub
    Private Sub GV1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV1.CellValueChanged
        Select Case e.Column.FieldName
            Case "APV_YN"
                If GV1.GetRowCellValue(GV1.FocusedRowHandle, "APV_YN").ToString <> "D" Then GV1.SetRowCellValue(GV1.FocusedRowHandle, "EMAIL_MSG", "")
        End Select
    End Sub
    Private Sub SetGridEmainMsgAllowEdit()
        If GV1.RowCount <= 0 Then Exit Sub

        Select Case GV1.FocusedColumn.FieldName
            Case "EMAIL_MSG"
                If GV1.GetRowCellValue(GV1.FocusedRowHandle, "APV_YN").ToString = "D" Then '거절
                    GV1.FocusedColumn.OptionsColumn.AllowEdit = True
                    GV1.FocusedColumn.OptionsColumn.ReadOnly = False
                Else
                    GV1.FocusedColumn.OptionsColumn.AllowEdit = False
                    GV1.FocusedColumn.OptionsColumn.ReadOnly = True
                End If
        End Select
    End Sub
    Private Sub GV1_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GV1.ShowingEditor
        Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = sender
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView
        view = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim dr As DataRow = GV1.GetDataRow(GV1.FocusedRowHandle)

        Select Case gv.FocusedColumn.FieldName
            Case "EMAIL_MSG"
                If gv.GetRowCellValue(gv.FocusedRowHandle, "APV_YN").ToString = "D" Or gv.GetRowCellValue(gv.FocusedRowHandle, "APV_YN").ToString = "S" Then
                    '입력가능. 
                Else
                    e.Cancel = True
                End If
        End Select
    End Sub
    Private Sub GV1_RowClick(sender As Object, e As RowClickEventArgs) Handles GV1.RowClick
        Try
            If GV1.FocusedColumn.FieldName = "CHK" Then
                If GV1.GetRowCellValue(GV1.FocusedRowHandle, "CHK").ToString = "N" Then
                    GV1.SetRowCellValue(e.RowHandle, "CHK", "Y")
                Else
                    GV1.SetRowCellValue(e.RowHandle, "CHK", "N")
                End If
            End If
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Sub Apply_Type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Apply_Type.SelectedIndexChanged
        If Apply_Type.SelectedIndex < 0 Then Exit Sub

        Select Case Apply_Type.SelectedValue.ToString

            Case "APV_YN"
                Apply_Status.SelectedValue = "Y"

                Dim DT As DataTable = Apply_Status.DataSource
                If DT Is Nothing Then Exit Sub

                If DT.Rows.Count > 0 Then
                    For I = DT.Rows.Count - 1 To 0 Step -1
                        If DT.Rows(I)("CODE") = "N" Or DT.Rows(I)("CODE") = "" Then
                            DT.Rows.RemoveAt(I)
                        End If
                    Next
                End If

                Combo_Panel.Visible = True
                Combo_Panel2.Visible = False
                Text_Panel.Visible = False

                Me.Combo_Panel.Location = New System.Drawing.Point(180, 3)
                Me.btnApply.Left = Combo_Panel.Left + Combo_Panel.Width

                Apply_Type.NextFocus = "Apply_Status"
                Apply_Status.NextFocus = "btnApply"
                Apply_Text.NextFocus = ""
                Apply_YN.NextFocus = ""
            Case "EMAIL_MSG"
                Apply_Text.Text = ""

                Combo_Panel.Visible = False
                Combo_Panel2.Visible = False
                Text_Panel.Visible = True

                Me.Text_Panel.Location = New System.Drawing.Point(180, 3)

                Me.btnApply.Left = Text_Panel.Left + Text_Panel.Width

                Apply_Type.NextFocus = "Apply_Text"
                Apply_Status.NextFocus = ""
                Apply_Text.NextFocus = "btnApply"
                Apply_YN.NextFocus = ""
            Case Else
                'Apply_YN.SelectedValue = "Y"

                Combo_Panel.Visible = False
                Combo_Panel2.Visible = True
                Text_Panel.Visible = False

                Me.Combo_Panel2.Location = New System.Drawing.Point(180, 3)

                Me.btnApply.Left = Combo_Panel2.Left + Combo_Panel2.Width

                Apply_Type.NextFocus = "Apply_YN"
                Apply_Status.NextFocus = ""
                Apply_Text.NextFocus = ""
                Apply_YN.NextFocus = "btnApply"
        End Select
    End Sub
    Private Sub GV1_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles GV1.RowCellStyle
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        If GV1.GetRowCellValue(e.RowHandle, "APV_YN").ToString <> GV1.GetRowCellValue(e.RowHandle, "DB_APV_YN").ToString Then
            e.Appearance.BackColor = System.Drawing.Color.LightSalmon
        End If
        If view.GetRowCellValue(e.RowHandle, "APV_YN").ToString = "N" Then
            e.Appearance.BackColor = System.Drawing.Color.LightGray
        ElseIf view.GetRowCellValue(e.RowHandle, "APV_YN").ToString = "D" Then
            e.Appearance.BackColor = System.Drawing.Color.DarkSalmon
        End If
    End Sub

#End Region
End Class
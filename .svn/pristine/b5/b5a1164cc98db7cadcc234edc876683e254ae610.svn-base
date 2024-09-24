Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Columns
Imports System.Drawing
Imports YJIT.SC.UI
Imports YJIT.SC.UI.SCControls
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports System.IO

Public Class CrmWBSMgt
    Dim bShowDateBoxEdit As Boolean = True '자동 팝업시 날짜 입력 불가능 
    Dim sShowG1 As String = Nothing '저장 후 GV1 커서 바꾸기 위해 
    Dim vFlag As String = "N" '날짜 검사하기 위한 부호 

#Region "=================GetConvertToDataset Function==========="
    Private Function GetConvertToDataSet(ByVal SearchType As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)

            Select Case SearchType.ToString.ToUpper
                Case "Search".ToUpper
                    YJSql.SqlBox("WG1", "CrmWBSMgt@Search", , False)
                    YJSql.Params("DATE_TYPE_" & S_DATE_TYPE.SelectedValue, True)
                    YJSql.Params("DATE_FM", drMAIN("S_DATE_FM").ToString)
                    YJSql.Params("DATE_TO", drMAIN("S_DATE_TO").ToString)
                    YJSql.Params("SEARCH_TYPE_" & S_SEARCH_TYPE.SelectedValue, True)
                    YJSql.Params("SEARCH_KEY", drMAIN("S_SEARCH_KEY").ToString)
                    YJSql.Params("DEPT_TYPE_" & S_DEPT_TYPE.SelectedValue, True)
                    YJSql.Params("DEPT_CD", drMAIN("S_DEPT_CD").ToString)
                    'YJSql.Params("COM_" & S_COM_YN.SelectedValue, True)
                Case "SearchDetail".ToUpper
                    YJSql.SqlBox("WG2", "CrmWBSMgt@SearchDetail", , False)
                    YJSql.Params("MNGT_NO", GV1.GetFocusedRowCellValue("MNGT_NO").ToString)
                Case "DefaultSetting".ToUpper
                    YJSql.SqlBox("DEFAULT", "CrmWBSMgt@SearchDetail", , False)
                    YJSql.Params("MNGT_NO", "0000000")
                Case "SearchYMD".ToUpper
                    YJSql.SqlBox("YMD", "CrmWBSMgt@SearchYMD", , False)
                    YJSql.Params("MNGT_NO", GV1.GetFocusedRowCellValue("MNGT_NO").ToString)
                Case Else
                    Throw New Exception("No match type found. (GetConvertToDataSet)")
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function

#End Region

#Region "=================Client Function==========="
    Public Sub PopUpInit()
        Dim itemCaption = {"&Add Row", "&Delete Row", "&Export Excel"}

        Dim WG1PopUp As New PopupBase
        WG1PopUp.ItemAdd(Action.Excel, "WG1_Excel", itemCaption(2))
        WG1PopUp.ItemAdd(Action.NavigateTo, "WBSProjectMgt", "WBS Project &Management", True)
        WG1PopUp.PopUpInit(Me, WG1)

        Dim WG2PopUp As New PopupBase
        WG2PopUp.ItemAdd(Action.Addrow, "WG2_ADDROW", itemCaption(0))
        WG2PopUp.ItemAdd("InsertRow", "&Insert Row", BarIcon.AddRow)
        WG2PopUp.ItemAdd(Action.DeleteRow, "WG2_DELETEROW", itemCaption(1))
        WG2PopUp.ItemAdd(Action.Excel, "WG2_Excel", itemCaption(2))
        WG2PopUp.ItemAdd(Action.Other, "WG2_SelectAll", "Select All", True)
        WG2PopUp.ItemAdd("DefaultSetting", "기본 값 세팅", BarIcon.AddRow, True)
        WG2PopUp.PopUpInit(Me, WG2, btnQuickFwg1, "ACT_CD", "RMK")

    End Sub

    Private Sub SetAddRowDefault()
        GV2.SetFocusedRowCellValue("MNGT_NO", GV1.GetFocusedRowCellValue("MNGT_NO").ToString)

        'GV2.SetFocusedRowCellValue("GRP_CD", GV2.GetRowCellValue(Gv.FocusedRowHandle + 1, "GRP_CD").ToString())
        '기본 데이터가 없으면 01 생성
        If GV2.RowCount = 1 Then
            GV2.SetFocusedRowCellValue("GRP_CD", "01")
        Else
            GV2.SetFocusedRowCellValue("GRP_CD", GV2.GetRowCellValue(GV2.FocusedRowHandle - 1, "GRP_CD").ToString)
            GV2.SetFocusedRowCellValue("ACT_CD", GV2.GetRowCellValue(GV2.FocusedRowHandle - 1, "ACT_CD").ToString)
            GV2.SetFocusedRowCellValue("ACT_NM", GV2.GetRowCellValue(GV2.FocusedRowHandle - 1, "ACT_NM").ToString)
            GV2.SetFocusedRowCellValue("LOC_CD", GV2.GetRowCellValue(GV2.FocusedRowHandle - 1, "LOC_CD").ToString)
            GV2.SetFocusedRowCellValue("DEPT_CD", GV2.GetRowCellValue(GV2.FocusedRowHandle - 1, "DEPT_CD").ToString)
            GV2.SetFocusedRowCellValue("DEPT_PIC_NM", GV2.GetRowCellValue(GV2.FocusedRowHandle - 1, "DEPT_PIC_NM").ToString)
        End If
        GV2.SetFocusedRowCellValue("PROC_RATE", "0")
        GV2.SetFocusedRowCellValue("CHK", "N")

        If GV2.FocusedRowHandle < GV2.TopRowIndex Then
            GV2.TopRowIndex = GV2.FocusedRowHandle - 1
        End If
    End Sub
    Private Sub SetGridFilterClear()
        GV2.ApplyFindFilter("")
        GV2.ClearSorting()
        GV2.ActiveFilterString = String.Empty
    End Sub
    Public Sub PopUpOnBeforeClick(ByVal dr As DataRow)
        Dim Key As String = dr("KEY")
        Dim Sender As String = ""
        If Not dr("Sender") Is System.DBNull.Value Then Sender = dr("Sender")

        Try
            Select Case Key
                Case "WG2_ADDROW"
                    Call SetGridFilterClear()
                Case "InsertRow"
                    Call SetGridFilterClear()
                Case "DefaultSetting"
                    Call SetGridFilterClear()
                Case Else
                    Select Case dr("Action")
                        Case Action.Addrow, Action.EventKey
                            Select Case dr("Sender").ToString
                                Case "WG2"
                                    Call SetGridFilterClear()
                            End Select
                    End Select
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message, MessageBoxButtons.OK, "Process failed!", MessageBoxIcon.Error)
            dr("Cancel") = True
        End Try

    End Sub
    Public Sub PopUpOnAfterClick(ByVal dr As DataRow)
        Dim key As String = dr("Key").ToString
        'Dim Grp As String = Nothing
        Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
        Dim fTarget As Object = Nothing

        Select Case key
            Case "WG2_ADDROW"
                ''행추가시 자동으로 해당 관리번호 삽입
                'GV2.SetFocusedRowCellValue("MNGT_NO", GV1.GetFocusedRowCellValue("MNGT_NO").ToString())
                'GV2.SetFocusedRowCellValue("CHK", "N")
                'GV2.SetFocusedRowCellValue("PROC_RATE", "0")
                ''기본 데이터가 없으면 01 생성
                'If GV2.RowCount = 1 Then
                '    GV2.SetFocusedRowCellValue("GRP_CD", "01")
                'Else
                '    GV2.SetFocusedRowCellValue("GRP_CD", GV2.GetRowCellValue(GV2.FocusedRowHandle - 1, "GRP_CD").ToString)
                'End If
                Call SetAddRowDefault()
            Case "InsertRow"
                Call InsertGridRow(WG2)
                Call SetGridSortSeq(GV2)
            Case "DefaultSetting"
                Call DefaultGridRow(WG2)
                Call SetGridSortSeq(GV2)
            Case "WBSProjectMgt"
                fTarget = frmMain.NavigateTo(key, NavigatedWindowModes.Dialog, False)
                If Not IsNothing(fTarget) Then
                    If GV1.GetFocusedRowCellValue("MNGT_NO") <> "" Then
                        fTarget.MNGT_NO.Text = GV1.GetFocusedRowCellValue("MNGT_NO").ToString
                        fTarget.PROJECT_NM.Text = GV1.GetFocusedRowCellValue("PROJECT_NM").ToString
                        fTarget.init = False
                    End If
                    fTarget.ShowDialog()
                    sShowG1 = fTarget.MNGT_NO.Text
                    Call SearchData()
                End If
            Case "WG2_SelectAll"
                If GV2.GetRowCellValue(0, "CHK").ToString = "N" Then
                    For i = 0 To GV2.RowCount - 1
                        GV2.SetRowCellValue(i, "CHK", "Y")
                    Next
                Else
                    For i = 0 To GV2.RowCount - 1
                        GV2.SetRowCellValue(i, "CHK", "N")
                    Next
                End If
            Case Else
                Select Case dr("Action")
                    Case Action.Addrow, Action.EventKey
                        Select Case dr("Sender").ToString
                            Case "WG2"
                                Call SetAddRowDefault()
                        End Select
                End Select
        End Select
    End Sub

    Public Sub MenuListBeforeShow(ByRef param As Dictionary(Of String, Boolean))
        '초기 검색전 우클릭 메뉴 비활성화 
        If GV1.RowCount = 0 Then

            '--GV2
            param("WG2_ADDROW") = False
            param("WG2_DELETEROW") = False
            param("InsertRow") = False
            param("DefaultSetting") = False
            param("WG2_Excel") = False
            param("WG2_SelectAll") = False
            '--GV1
            param("WG1_Excel") = False
        Else
            If GV2.RowCount = 0 Then
                '--GV2
                param("WG2_DELETEROW") = False
                param("InsertRow") = False
                param("WG2_Excel") = False
                param("WG2_SelectAll") = False
            Else
                '--GV2
                param("WG2_ADDROW") = True
                param("WG2_DELETEROW") = True
                param("WG2_Excel") = True
                param("InsertRow") = True
                param("DefaultSetting") = True
                param("WG2_SelectAll") = True
            End If
            '--GV1
            param("WG1_Excel") = True
        End If
    End Sub

    Private Sub InsertGridRow(ByVal Wg As YJIT.SC.UI.SCControls.WebGrid)
        Dim Gv As DevExpress.XtraGrid.Views.Grid.GridView = Wg.MainView

        If Gv.RowCount > 0 Then
            Dim insRowIndex As Integer = Gv.FocusedRowHandle
            Dim dt As DataTable = CType(Wg.DataSource, DataTable)
            Dim dr2 As DataRow = dt.NewRow
            CType(Wg.DataSource, DataTable).Rows.InsertAt(dr2, insRowIndex)
            Call SetGridSortSeq(Gv)
            Gv.FocusedRowHandle = Gv.FocusedRowHandle - 1

            'GV2.SetFocusedRowCellValue("MNGT_NO", GV1.GetFocusedRowCellValue("MNGT_NO").ToString())
            'GV2.SetFocusedRowCellValue("GRP_CD", GV2.GetRowCellValue(Gv.FocusedRowHandle + 1, "GRP_CD").ToString())
            'GV2.SetFocusedRowCellValue("PROC_RATE", "0")
            'GV2.SetFocusedRowCellValue("CHK", "N")
            Call SetAddRowDefault()
        End If
    End Sub

    Private Sub PageInit()
        S_DATE_TYPE.SelectedValue = "FT"
        S_SEARCH_TYPE.SelectedValue = "A"
        S_COM_YN.SelectedValue = "N"

        S_DEPT_TYPE.SelectedValue = "I"
        S_DEPT_CD.SelectedValue = ClientSessionInfo.OrganizationCode

        S_DATE_FM.Text = DateAdd(DateInterval.Day, -7, Now).ToString("yyyyMMdd")
        S_DATE_TO.Text = Now.ToString("yyyyMMdd")
        S_DATE_TYPE.Focus()
    End Sub

    Private Sub ClearData()
        Call ClearView(AppliedRangeTypes.All)
        Call PageInit()
    End Sub

    Private Sub GridInit()
        '구분
        GV2.Columns("GRP_CD").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit("CommonCode", "GroupCode:'W01',NameType:''")
        '장소
        GV2.Columns("LOC_CD").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit("CommonCode", "GroupCode:'W02',NameType:''")
        '담당부서 
        GV2.Columns("DEPT_CD").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit("CommonCode", "GroupCode:'C03',NameType:''")
        '진척률
        GV2.Columns("PROC_RATE").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit({"100:100%", "90:90%", "80:80%", "70:70%", "60:60%", "50:50%", "40:40%", "30:30%", "20:20%", "10:10%"})
    End Sub

    Public Function MandatoryGridValue(ByVal gridView As String) As Boolean
        Dim Param As New Dictionary(Of String, Object)
        Dim checkNull() As String = Nothing

        Select Case gridView
            Case "GV2"
                checkNull = {"ACT_CD", "JOB_NM"}
                Param("ACT_CD") = GV2_ACT_CD.Caption
                Param("JOB_NM") = GV2_JOB_NM.Caption

                Return ValidateGridValue(GV2, Param, checkNull)
        End Select

        Return False

    End Function
#End Region

#Region "=================Data logic actions================="
    Private Sub SearchData()
        Try
            If SearchValidate() = False Then Exit Sub

            Dim dsRet As DataSet = GetConvertToDataSet("Search")

            dsRet = MethodCallEx(Me, "YJIT.Biz.CrmWBSMgt", "Search", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Call ClearView(AppliedRangeTypes.Only, {WG1, WG2})
                    Me.BindToDataset(dsRet, "Data")
                    Me.DataState = UI.DataStates.Retrieved
                    If sShowG1 <> "" Then
                        For index = 0 To dsRet.Tables("Data.WG1").Rows.Count - 1
                            Dim drWG1 As DataRow = dsRet.Tables("Data.WG1").Rows(index)
                            If drWG1("MNGT_NO").ToString = sShowG1 Then
                                GV1.FocusedRowHandle = index
                            End If
                        Next
                        sShowG1 = Nothing
                        Call SearchDetailData()
                    End If
                Case "N"
                    Call ClearView(AppliedRangeTypes.Only, {WG1, WG2})
                    MsgBoxLocalized(drPairs("TrxMsg"))
                    Me.DataState = UI.DataStates.Retrieved
                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

        Try
            If String.IsNullOrEmpty(S_DATE_FM.Text.ToString) Then
                If ErrControl Is Nothing Then ErrControl = S_DATE_TYPE
                ErrMsg &= "Please input the [" & S_DATE_TYPE.SelectedValue & "]" & vbNewLine
            ElseIf String.IsNullOrEmpty(S_DATE_TO.Text.ToString) Then
                If ErrControl Is Nothing Then ErrControl = S_DATE_TYPE
                ErrMsg &= "Please input the [" & S_DATE_TYPE.SelectedValue & "]" & vbNewLine
            End If

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

    Public Sub SearchDetailData()
        Try

            Dim dsRet As DataSet = GetConvertToDataSet("SearchDetail")

            dsRet = MethodCallEx(Me, "YJIT.Biz.CrmWBSMgt", "Search", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y", "N"
                    Call ClearView(AppliedRangeTypes.Only, {WG2})
                    Me.BindToDataset(dsRet, "Data")
                    Me.DataState = UI.DataStates.Retrieved
                    'Case "N"
                    '    Call ClearView(AppliedRangeTypes.Only, {WG2})
                    '    MsgBoxLocalized(drPairs("TrxMsg"))
                    '    Me.DataState = UI.DataStates.Retrieved
                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Public Sub SaveData()
        Dim ErrMsg As String = String.Empty

        Try
            '그냥 SAVE 누를 때 오류 창 
            If GV1.RowCount = 0 Then
                ErrMsg &= "저장할 데이터가 없습니다."
                Throw New Exception(ErrMsg)
            End If

            '200323 / 커서 잡기 위해 
            sShowG1 = GV1.GetFocusedRowCellValue("MNGT_NO").ToString

            Dim dsRet As DataSet = GetConvertToDataSet("SearchDetail")
            dsRet.Tables.Add(Me.ConvertToDataset.Tables("WG2").Copy)

            If dsRet.Tables("WG2").Rows.Count = 0 Then
                ErrMsg &= "저장할 데이터가 없습니다."
                Throw New Exception(ErrMsg)
            End If

            If SaveValidate(dsRet) = False Then Exit Sub

            If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then Exit Sub

            For Each row As DataRow In dsRet.Tables("WG2").Rows
                If String.IsNullOrEmpty(row("PLAN_TO_YMD").ToString) Then
                    row("PLAN_TO_YMD") = row("PLAN_FM_YMD").ToString
                End If
            Next

            dsRet = MethodCallEx(Me, "YJIT.Biz.CrmWBSMgt", "Save", {dsRet})

            Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") = "Y" Then
                Call ClearView(AppliedRangeTypes.Only, {WG2})
                Me.BindToDataset(dsRet, "Data")
                Me.DataState = UI.DataStates.Retrieved
            End If

            MsgBoxLocalized(dr("TrxMsg"))

            Call SearchData()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Function SaveValidate(ByVal ds As DataSet)
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrGrid As Object = Nothing
        Dim ErrGridRow As Integer = Nothing
        Dim ErrGridCol As Object = Nothing
        Dim dt As DataTable = ds.Tables("WG2").Copy

        Try

            If MandatoryGridValue("GV2") Then Return True

            ''실제프로젝트 날짜
            'Try
            '    For i = 0 To dt.Rows.Count - 1
            '        If dt.Rows(i)("_INSFLAG").ToString <> "D" And String.IsNullOrEmpty(dt(i)("PROC_FM_YMD").ToString) And String.IsNullOrEmpty(dt(i)("PROC_TO_YMD").ToString) Then
            '            Dim procTo As String = String.Empty

            '            procTo = dt(i)("PROC_TO_YMD").ToString

            '            If String.IsNullOrEmpty(dt(i)("PROC_FM_YMD").ToString) Then Continue For


            '            Dim procFm As String = dt(i)("PROC_FM_YMD").ToString
            '            If procTo < procFm Then
            '                ErrMsg &= Me.Localizer1.GetLocalizedString("Plan End Date is faster than Plan Start Date") & vbNewLine
            '                If ErrGrid Is Nothing Then
            '                    ErrGrid = GV2
            '                    ErrGridRow = i
            '                    ErrGridCol = CType(GV2, DevExpress.XtraGrid.Views.Grid.GridView).Columns("PROC_TO_YMD")
            '                End If
            '                Exit Try
            '            End If
            '        End If
            '    Next
            'Catch ex As Exception
            '    MsgBoxLocalized(ex.Message)

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

    Private Sub SetGridSortSeq(ByVal GridView As DevExpress.XtraGrid.Views.Grid.GridView)
        For i As Integer = 0 To GridView.RowCount - 1
            GridView.SetRowCellValue(i, "SORT_SEQ", i + 1)
        Next
    End Sub

    Public Sub YMDValidate()
        Dim ErrMsg As String = String.Empty
        Try
            Dim dsRet As DataSet = GetConvertToDataSet("SearchYMD")

            dsRet = MethodCallEx(Me, "YJIT.Biz.CrmWBSMgt", "Search", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Dim drYMD As DataRow = dsRet.Tables("Data.YMD").Rows(0)

                    Select Case vFlag
                        Case "PLF"
                            If GV2.GetFocusedRowCellValue("PLAN_FM_YMD").ToString < drYMD("FM_YMD").ToString Then
                                ErrMsg &= "프로젝트시작일보다 계획시작일이 작습니다." & vbCrLf
                                ErrMsg &= "해당 프로젝트 기간 : " & drYMD("FM_YMD").ToString & " ~ " & drYMD("TO_YMD").ToString & vbCrLf
                                ErrMsg &= "계획시작일을 변경하세요."
                            End If
                            vFlag = "N"
                        Case "PRF"
                            If GV2.GetFocusedRowCellValue("PROC_FM_YMD").ToString < drYMD("FM_YMD").ToString Then
                                ErrMsg &= "프로젝트시작일보다 실제시작일이 작습니다." & vbCrLf
                                ErrMsg &= "해당 프로젝트 기간 : " & drYMD("FM_YMD").ToString & " ~ " & drYMD("TO_YMD").ToString & vbCrLf
                                ErrMsg &= "실제시작일을 변경하세요."
                            End If
                            vFlag = "N"
                        Case "TEF"
                            If GV2.GetFocusedRowCellValue("TEST_FM_YMD").ToString < drYMD("FM_YMD") Then
                                ErrMsg &= "프로젝트시작일보다 테스트시작일이 작습니다." & vbCrLf
                                ErrMsg &= "해당 프로젝트 기간 : " & drYMD("FM_YMD").ToString & " ~ " & drYMD("TO_YMD").ToString & vbCrLf
                                ErrMsg &= "테스트시작일을 변경하세요."
                            End If
                            vFlag = "N"
                        Case "PLT"
                            If GV2.GetFocusedRowCellValue("PLAN_TO_YMD").ToString > drYMD("TO_YMD").ToString Then
                                ErrMsg &= "프로젝트종료일보다 계획종료일이 큽니다." & vbCrLf
                                ErrMsg &= "해당 프로젝트 기간 : " & drYMD("FM_YMD").ToString & " ~ " & drYMD("TO_YMD").ToString & vbCrLf
                                ErrMsg &= "계획종료일을 변경하세요."
                            End If
                            vFlag = "N"
                        Case "PRT"
                            If GV2.GetFocusedRowCellValue("PROC_TO_YMD").ToString > drYMD("TO_YMD").ToString Then
                                ErrMsg &= "프로젝트종료일보다 실제종료일이 큽니다." & vbCrLf
                                ErrMsg &= "해당 프로젝트 기간 : " & drYMD("FM_YMD").ToString & " ~ " & drYMD("TO_YMD").ToString & vbCrLf
                                ErrMsg &= "실제종료일을 변경하세요."
                            End If
                            vFlag = "N"
                        Case "TET"
                            If GV2.GetFocusedRowCellValue("TEST_TO_YMD").ToString > drYMD("TO_YMD").ToString Then
                                ErrMsg &= "프로젝트종료일보다 테스트종료일이 큽니다."
                                ErrMsg &= "해당 프로젝트 기간 : " & drYMD("FM_YMD").ToString & " ~ " & drYMD("TO_YMD").ToString & vbCrLf
                                ErrMsg &= "테스트종료일을 변경하세요."
                            End If
                            vFlag = "N"
                        Case Else
                                vFlag = "N"
                                Exit Sub
                    End Select
                    If Not String.IsNullOrEmpty(ErrMsg) Then
                        Throw New Exception(ErrMsg)
                    End If
                Case Else
            End Select

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
#End Region

#Region "=================Control Events================="
    Private Sub CrmWBSMgt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GridInit()
        Call PageInit()
    End Sub

    Private Sub CrmWBSMgt_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Call PopUpInit()
        'Call DrawRowIndicator({GV1})
        Call SearchData()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call ClearData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub

    Private Sub S_DEPT_CD_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles S_DEPT_CD.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.DroppedDown = True
        End If
    End Sub

    Dim bGV1_FocusedRowChanged As Boolean = False
    Private Sub GV1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV1.FocusedRowChanged
        Try
            If sender.RowCount = 0 Then Exit Sub
            If sender.IsValidRowHandle(e.FocusedRowHandle) = False Then Exit Sub

            If e.PrevFocusedRowHandle >= 0 Then bGV1_FocusedRowChanged = True

            If sShowG1 = "" Then
                Call SearchDetailData()
            End If

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Sub GV2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV2.CellValueChanged

        '실제 프로젝트 기간 바로 계산 
        If e.Column.FieldName = "PROC_TO_YMD" Or e.Column.FieldName = "PROC_FM_YMD" Then
            If GV2.GetFocusedRowCellValue("PROC_TO_YMD").ToString <> "" And GV2.GetFocusedRowCellValue("PROC_FM_YMD").ToString <> "" Then
                If GV2.GetFocusedRowCellValue("PROC_FM_YMD").ToString <= GV2.GetFocusedRowCellValue("PROC_TO_YMD").ToString Then
                    Dim toDate As DateTime = DateTime.Parse(GV2.GetFocusedRowCellValue("PROC_TO_YMD").ToString.Substring(0, 4) + "-" + GV2.GetFocusedRowCellValue("PROC_TO_YMD").ToString.Substring(4, 2) + "-" + GV2.GetFocusedRowCellValue("PROC_TO_YMD").ToString.Substring(6, 2))
                    Dim fmDate As DateTime = DateTime.Parse(GV2.GetFocusedRowCellValue("PROC_FM_YMD").ToString.Substring(0, 4) + "-" + GV2.GetFocusedRowCellValue("PROC_FM_YMD").ToString.Substring(4, 2) + "-" + GV2.GetFocusedRowCellValue("PROC_FM_YMD").ToString.Substring(6, 2))
                    Dim Diffticks As TimeSpan = toDate - fmDate
                    GV2.SetRowCellValue(e.RowHandle, "WORK_RATE", Diffticks.Days)
                Else
                    MsgBoxLocalized("실제 프로젝트 종료일이 시작일보다 작습니다.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                    GV2.SetRowCellValue(e.RowHandle, "PROC_TO_YMD", "")
                End If
            End If

            '프로젝트 기간 유효성검사
            If e.Column.FieldName = "PROC_TO_YMD" Then
                vFlag = "PRT"
                Call YMDValidate()
            Else
                vFlag = "PRF"
                Call YMDValidate()
            End If
        End If

        '계획 기간 
        If e.Column.FieldName = "PLAN_TO_YMD" Or e.Column.FieldName = "PLAN_FM_YMD" Then
            If GV2.GetFocusedRowCellValue("PLAN_TO_YMD").ToString <> "" And GV2.GetFocusedRowCellValue("PLAN_FM_YMD").ToString <> "" Then
                If GV2.GetFocusedRowCellValue("PLAN_FM_YMD").ToString > GV2.GetFocusedRowCellValue("PLAN_TO_YMD").ToString Then
                    MsgBoxLocalized("계획 종료일이 시작일보다 작습니다.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                    GV2.SetRowCellValue(e.RowHandle, "PLAN_TO_YMD", "")
                End If
            End If

            '프로젝트 기간 유효성검사
            If e.Column.FieldName = "PLAN_TO_YMD" Then
                vFlag = "PLT"
                Call YMDValidate()
            Else
                vFlag = "PLF"
                Call YMDValidate()
            End If
        End If

        '테스트 기간 
        If e.Column.FieldName = "TEST_TO_YMD" Or e.Column.FieldName = "TEST_FM_YMD" Then
            If GV2.GetFocusedRowCellValue("TEST_TO_YMD").ToString <> "" And GV2.GetFocusedRowCellValue("TEST_FM_YMD").ToString <> "" Then
                If GV2.GetFocusedRowCellValue("TEST_FM_YMD").ToString > GV2.GetFocusedRowCellValue("TEST_TO_YMD").ToString Then
                    MsgBoxLocalized("테스트 종료일이 시작일보다 작습니다.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                    GV2.SetRowCellValue(e.RowHandle, "TEST_TO_YMD", "")
                End If
            End If

            '프로젝트 기간 유효성검사
            If e.Column.FieldName = "TEST_TO_YMD" Then
                vFlag = "TET"
                Call YMDValidate()
            Else
                vFlag = "TEF"
                Call YMDValidate()
            End If
        End If
    End Sub

    '코드 네임이 존재하면 대신 보여주는 로직
    Private Sub GV2_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GV2.CustomColumnDisplayText
        '코드+코드명 컨트롤 조작
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = TryCast(sender, DevExpress.XtraGrid.Views.Base.ColumnView)

        If e.Column.FieldName = "ACT_CD" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
            If Not String.IsNullOrEmpty(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "ACT_NM").ToString) Then
                e.DisplayText = view.GetListSourceRowCellValue(e.ListSourceRowIndex, "ACT_NM").ToString
            End If
        End If

    End Sub

    Private Sub GV1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV1.DoubleClick
        Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
        Dim fTarget As Object = Nothing

        Select Case GV1.FocusedColumn.FieldName
            Case "USR_ID", "PROJECT_NM"
                fTarget = frmMain.NavigateTo("WBSProjectMgt", NavigatedWindowModes.Dialog, False)
                If Not IsNothing(fTarget) Then
                    fTarget.MNGT_NO.Text = GV1.GetFocusedRowCellValue("MNGT_NO").ToString
                    fTarget.PROJECT_NM.Text = GV1.GetFocusedRowCellValue("PROJECT_NM").ToString
                    fTarget.init = False
                    fTarget.ShowDialog()
                End If
                sShowG1 = fTarget.MNGT_NO.Text
                Call SearchData()
        End Select
    End Sub

    Private Sub GV2_RowClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GV2.RowClick
        Try
            If GV2.FocusedColumn.FieldName = "CHK" Then
                If GV2.GetRowCellValue(GV2.FocusedRowHandle, "CHK").ToString = "N" Then
                    GV2.SetRowCellValue(e.RowHandle, "CHK", "Y")
                Else
                    GV2.SetRowCellValue(e.RowHandle, "CHK", "N")
                End If
            End If
        Catch ex As Exception
            'MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Sub GV2_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV2.ShownEditor
        Dim view As GridView = TryCast(sender, GridView)

        'Select Case view.FocusedColumn.FieldName
        '    Case "PLAN_TO_YMD", "PLAN_FM_YMD", "PROC_TO_YMD", "PROC_FM_YMD", "TEST_FM_YMD", "TEST_TO_YMD"
        '        Dim te As TextEdit = CType(view.ActiveEditor, TextEdit)
        '        If Not String.IsNullOrEmpty(te.EditValue) Then

        '            te.SelectionStart = te.Text.Length - 5 '":"포함해서 -5처리
        '            te.SelectionLength = 5
        '        End If

        'End Select

        Select Case view.ActiveEditor.EditorTypeName
            Case "DateBoxEdit"
                '20210205 김성은 입력시 불편함
                'If bShowDateBoxEdit = False Then Exit Sub
                'Dim edit As DateBoxEdit = CType(view.ActiveEditor, DateBoxEdit)
                'edit.ShowDatePicker()
                'bShowDateBoxEdit = False
            Case Else
                view.GridControl.BeginInvoke(New MethodInvoker(Sub()
                                                                   Dim edit As PopupBaseEdit = TryCast(view.ActiveEditor, PopupBaseEdit)
                                                                   If edit Is Nothing Then
                                                                       Return
                                                                   End If
                                                                   edit.ShowPopup()
                                                                   edit.SelectionStart = edit.Text.Length
                                                                   edit.SelectionLength = 0
                                                               End Sub))
        End Select
    End Sub

    Private Sub GV2_FocusedColumnChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles GV2.FocusedColumnChanged
        bShowDateBoxEdit = True
    End Sub

#End Region

#Region "=================Quick Button Events==========="

    Private Sub btnAddFwg1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFwg1.Click
        Call AddGridRow(WG2)
    End Sub
    Private Sub btnDelFwg1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelFwg1.Click
        Call SetGridRowDel(WG2)
    End Sub
    Private Sub btnExpFwg1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpFwg1.Click
        Call GridToExcel(WG2)
    End Sub
    Private Sub AddGridRow(ByVal obj As YJIT.SC.UI.SCControls.WebGrid)
        Dim GvAddRow As New DataTable
        Dim dr As DataRow

        If obj.Visible = False And obj.Enabled = False Then Exit Sub

        GvAddRow.Columns.Add("Key")
        GvAddRow.Columns.Add("Sender")
        GvAddRow.Columns.Add("Action", GetType(Action))
        GvAddRow.Rows.Add()

        dr = GvAddRow.Rows(0)
        dr("Sender") = obj.Name
        dr("Key") = obj.Name + "_ADDROW"
        dr("Action") = Action.Addrow

        PopUpOnBeforeClick(GvAddRow.Rows(0))

        obj.AddRow()

        PopUpOnAfterClick(GvAddRow.Rows(0))
    End Sub

    Private Sub DefaultGridRow(ByVal obj As YJIT.SC.UI.SCControls.WebGrid)

        Try
            Dim dsRet As DataSet = GetConvertToDataSet("DefaultSetting")

            dsRet = MethodCallEx(Me, "YJIT.Biz.CrmWBSMgt", "Search", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Dim dt As DataTable = CType(WG2.DataSource, DataTable)
                    For index = 0 To dsRet.Tables("Data.DEFAULT").Rows.Count() - 1
                        Dim dr As DataRow = dsRet.Tables("Data.DEFAULT").Rows(index)
                        dr("MNGT_NO") = GV1.GetFocusedRowCellValue("MNGT_NO")
                    Next
                    dsRet.Tables("Data.DEFAULT").Columns.Remove("SEQ")
                    dt.Merge(dsRet.Tables("Data.DEFAULT"), True)
                    Me.DataState = UI.DataStates.Retrieved
                Case "N"
                    MsgBoxLocalized(drPairs("TrxMsg"))
                    Me.DataState = UI.DataStates.Retrieved
                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    '맨 마지막 행 지우는 로직 
    Private Sub DelGridRow(ByVal obj As YJIT.SC.UI.SCControls.WebGrid)
        Dim GvDelRow As New DataTable
        Dim dr As DataRow

        If obj.Visible = False And obj.Enabled = False Then Exit Sub
        GvDelRow.Columns.Add("Key")
        GvDelRow.Columns.Add("Sender")
        GvDelRow.Columns.Add("Action", GetType(Action))
        GvDelRow.Rows.Add()
        dr = GvDelRow.Rows(0)
        dr("Sender") = obj.Name
        dr("Key") = obj.Name + "_DeleteRow"
        dr("Action") = Action.DeleteRow
        obj.DeleteRow()

        PopUpOnAfterClick(GvDelRow.Rows(0))

    End Sub
    Private Sub SetGridRowDel(ByVal obj As YJIT.SC.UI.SCControls.WebGrid)

        Dim chk As String = "N"

        For i = 0 To GV2.RowCount - 1
            If GV2.GetRowCellValue(i, "CHK").ToString = "Y" Then
                chk = "Y"
                Exit For
            End If
        Next

        Dim dt As DataTable = CType(WG2.DataSource, DataTable)

        If chk = "Y" Then
            For i = GV2.RowCount - 1 To 0 Step -1
                If GV2.GetRowCellValue(i, "CHK").ToString = "Y" Then
                    GV2.DeleteRow(i)
                End If
            Next
        Else
            GV2.DeleteRow(GV2.FocusedRowHandle)
            SetGridSortSeq(GV2)
        End If

    End Sub
    Private Sub GridToExcel(ByVal obj As YJIT.SC.UI.SCControls.WebGrid)
        Common.ExportToExcel(obj)
    End Sub
#End Region
End Class
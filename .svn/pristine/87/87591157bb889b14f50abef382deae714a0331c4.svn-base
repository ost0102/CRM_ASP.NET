'****************************************************************************
' 작 성 자  : 유명재
' 작 성 일  : 2020-05-21
' 파일설명  : 운송료 요율 관리 화면
' 파 일 명  : TmsTrfMgt.vb
' 특이사항  : 

' 수 정 일 / 수정자 / 요청업체 / 수정내용 
'****************************************************************************
' 20200521 / 유명재 / 은산프로젝트 / 신규개발

'****************************************************************************

Imports System.Drawing
Imports YJIT.SC.App.Common
Imports YJIT.SC.App.FreightCommon
Imports YJIT.SC.UI
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraEditors.Repository

Public Class TmsTrfMgt
    Private MenuDt As DataTable

#Region "=================Data logic actions==========="

    Public Sub GridInit()

        Call DrawRowIndicator({GV1})

        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)
        Dim editorCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim editor As YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        'Dim selectAll As YJIT.SC.UI.GridCheckMarksSelection

        '== WG1 Grid
        '구간
        Dim dtLookup As DataTable = New DataTable()
        dtLookup.Columns.AddRange({New DataColumn("CODE"), New DataColumn("NAME")})
        dtLookup.Rows.Add(New Object() {"거리", "거리"})
        dtLookup.Rows.Add(New Object() {"왕복", "왕복"})
        dtLookup.Rows.Add(New Object() {"편도", "편도"})
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.DataSource = dtLookup.DefaultView
        editorCombo.NullText = ""
        GV1.Columns("TRF_TYPE").ColumnEdit = editorCombo

    End Sub

    Private Sub AddNewRow(ByVal dt As DataTable, ByVal Code As String, ByVal Name As String)
        dt.Rows.Add()
        dt.Rows(dt.Rows.Count - 1)("CODE") = Code
        dt.Rows(dt.Rows.Count - 1)("NAME") = Name
    End Sub

    Public Sub PageInit()

        Me.DataState = DataStates.New

        '필수값 라인 그려주는 함수
        Call SetMandatoryLine(Me)

        '국가별 금액 소수점 표시 (Default 15,2)
        If ClientSessionOfficeInfo.CurrencyCode = "KRW" Then
            Call GridFunc.SetGridColumnLocAmt(WG1, {"AMT_40F", "AMT_40F_CSM", "AMT_20F", "AMT_20F_CSM"})
        Else
            'Default
        End If

    End Sub

    Public Sub OfficeConfig()

    End Sub

    Public Sub PoupInit()

        Dim PopUp As New PopupBase
        'PopUp.ItemAdd(Action.NavigateTo, "EpsPurList", "자재구매 리스트", BarIcon.PageLink)
        'PopUp.ItemAdd(Action.NavigateTo, "EpsStlMgt", "지출결의서 관리", BarIcon.COST, True)
        'PopUp.ItemAdd(Action.NavigateTo, "EpsCostPrint", "지출결의서 출력", BarIcon.Print)

        'PopUp.PopUpInit(Me, btnQuickMenu)

        'If ClientSessionInfo.UseQuickMenu = "Y" Then
        '    QuickMenu.Visible = True
        '    Call CreateRightMenu(Me, PopUp.m_DataSource)
        'Else
        'End If

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG1_AddRow", "&Add Row", BarIcon.AddRow)
        PopUp.ItemAdd(Action.DeleteRow, "WG1_DelRow", "&Delete Row", BarIcon.DeleteRow)
        PopUp.ItemAdd(Action.Excel, "TmsTrfMgt", "&Export Excel", BarIcon.Excel, True)
        PopUp.PopUpInit(Me, WG1, btnQuickWg1, "TRF_TYPE", "AMT_40F_CSM")

    End Sub

    Public Sub SearchDataWG1()

        Dim params() As Object = {TRF_TYPE.SelectedValue, FR_PORT.Text, ONEWAY_DEPOT.Text, CITY.Text, STREET.Text, FR_DISTANCE.Text, TO_DISTANCE.Text}

        Dim dsRet As DataSet

        '////////WCF Service Call/////////
        Try
            'dsRet = MethodCallEx(Me, "YJIT.Biz.TmsTrfMgt", "SearchWG1", params)
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.TmsTrfMgt", "SearchWG1", params)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        '//////Parsing WCF returned data///////
        Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        ClearView(UI.AppliedRangeTypes.Only, {WG1})

        If dr("TrxCode") = "Y" Then
            Me.BindToDataset(dsRet, "Data") 'Re-display again the retrieve result
        Else
            'MsgBox(drPairs("StatusMessage"))
            MsgBoxLocalized(dr("trxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If

        '/////Set post datastate/////////
        Me.DataState = UI.DataStates.Retrieved
    End Sub

    Public Sub NewData()

        ClearView(UI.AppliedRangeTypes.All)
        Call PageInit()
        Me.TRF_TYPE.Focus()

        Me.DataState = DataStates.New

    End Sub

    Public Sub SaveDataWG1()
        If GV1.RowCount = 0 Then
            MsgBoxLocalized("저장할 운전운임제 요율이 없습니다. 처리불가!", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If

        If ValidateOfficeValue(Me) Then Exit Sub
        If ValidateMasterWG1() Then Exit Sub

        Dim dsRet As New DataSet
        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.YesNo, "Confirm", MessageBoxIcon.Question) = MsgBoxResult.No Then Exit Sub

        Try
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.TmsTrfMgt", "SaveWG1", Me.ConvertToDataset)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
        Else
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Confirm", MessageBoxIcon.Information)
            Call SearchDataWG1()
        End If

    End Sub

    Private Function ValidateMasterWG1() As Boolean

        Dim valChk As Boolean = False
        Dim valStr As String = ""

        ' Grid DeleteRow Check
        If MandatoryGridValue("GV1") Then Return True

        For i = GV1.RowCount - 1 To 0 Step -1
            If Trim(GV1.GetRowCellValue(i, "DISTANCE").ToString) = "" Then
                GV1.SetRowCellValue(i, "DISTANCE", 0)
            End If
            If Trim(GV1.GetRowCellValue(i, "AMT_40F").ToString) = "" Then
                GV1.SetRowCellValue(i, "AMT_40F", 0)
            End If
            If Trim(GV1.GetRowCellValue(i, "AMT_40F_CSM").ToString) = "" Then
                GV1.SetRowCellValue(i, "AMT_40F_CSM", 0)
            End If
            If Trim(GV1.GetRowCellValue(i, "AMT_20F").ToString) = "" Then
                GV1.SetRowCellValue(i, "AMT_20F", 0)
            End If
            If Trim(GV1.GetRowCellValue(i, "AMT_20F_CSM").ToString) = "" Then
                GV1.SetRowCellValue(i, "AMT_20F_CSM", 0)
            End If

            If Trim(GV1.GetRowCellValue(i, "TRF_TYPE").ToString & "") = "" Then
                valChk = True
                valStr = valStr & Localizer1.GetLocalizedString("적용유형 입력은 필수입니다!") & vbCrLf
            End If

            '원화금액에 소숫점 존재여부 체크 
            Dim FareLocAmt As Double = 0
            Dim ChkAmt As Double = 0
            If ClientSessionOfficeInfo.CountryCode = "KR" Then
                FareLocAmt = CDbl(GV1.GetRowCellValue(i, "AMT_40F"))
                ChkAmt += FareLocAmt
                If InStr(FareLocAmt.ToString, ".") > 0 Then
                    valChk = True
                    valStr = valStr & Localizer1.GetLocalizedString("안전운임(40')은 잘못된 원화금액입니다!.(소숫점 존재)!") & vbCrLf
                End If
                FareLocAmt = CDbl(GV1.GetRowCellValue(i, "AMT_40F_CSM"))
                ChkAmt += FareLocAmt
                If InStr(FareLocAmt.ToString, ".") > 0 Then
                    valChk = True
                    valStr = valStr & Localizer1.GetLocalizedString("위탁운임(40')은 잘못된 원화금액입니다!.(소숫점 존재)!") & vbCrLf
                End If
                FareLocAmt = CDbl(GV1.GetRowCellValue(i, "AMT_20F"))
                ChkAmt += FareLocAmt
                If InStr(FareLocAmt.ToString, ".") > 0 Then
                    valChk = True
                    valStr = valStr & Localizer1.GetLocalizedString("안전운임(20')은 잘못된 원화금액입니다!.(소숫점 존재)!") & vbCrLf
                End If
                FareLocAmt = CDbl(GV1.GetRowCellValue(i, "AMT_20F_CSM"))
                ChkAmt += FareLocAmt
                If InStr(FareLocAmt.ToString, ".") > 0 Then
                    valChk = True
                    valStr = valStr & Localizer1.GetLocalizedString("위탁운임(20')은 잘못된 원화금액입니다!.(소숫점 존재)!") & vbCrLf
                End If
            End If

            If ChkAmt = 0 Then
                valChk = True
                valStr = valStr & Localizer1.GetLocalizedString("요율 금액이 등록된 내역이 없습니다!") & vbCrLf
            End If

        Next

        If valChk Then
            MsgBoxLocalized(valStr, MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
        End If

        Return valChk

    End Function

    Public Function MandatoryGridValue(ByVal gridView As String) As Boolean
        Dim Param As New Dictionary(Of String, Object)
        Dim checkNull() As String = Nothing

        Select Case gridView
            Case "GV1"
                checkNull = {"TRF_TYPE"}
                Param("TRF_TYPE") = GV1_TRF_TYPE.Caption
                Return ValidateGridValue(GV1, Param, checkNull)
        End Select

        Return False

    End Function

#End Region

#Region "=================Control Events==========="

    Private Sub TmsTrfMgt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call GridInit()
        Call PageInit()
        Call OfficeConfig()
        Call SetMandatoryLine(Me)

    End Sub

    Private Sub TmsTrfMgt_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Call PoupInit()
        'Call SaveControlValues(Me, {PUR_TYPE})
        TRF_TYPE.Select()

    End Sub

    Public Sub MenuListBeforeShow(ByRef DataDic As Dictionary(Of String, Boolean))
        Try

        Catch ex As Exception

        End Try
    End Sub

    Public Sub PopUpOnBeforeClick(ByRef DataRow As DataRow)

    End Sub

    Public Sub PopUpOnAfterClick(ByVal Dr As DataRow)
        Dim Key As String = Dr("Key")
        Dim Sender As String = Dr("Sender")
        Dim Id As String = ""

        If Key = "Enter" Then Id = Dr("ID")

        'Navigato 사용할떄
        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing
        Dim rowIndex As Integer = 0

        Select Case Dr("Action")
            Case Action.NavigateTo
                frmMain = Me.MdiParent
                Select Case Key
                    'Case "EpsPurList"
                    '    fTarget = frmMain.NavigateTo(Key)
                    '    If Not IsNothing(fTarget) Then
                    '        fTarget.OFFICE_CD.SelectedValue = OFFICE_CD.SelectedValue
                    '        fTarget.GridInit()
                    '    End If

                    'Case "EpsStlMgt"    '지출결의서 관리
                    '    If GV1.RowCount = 0 Then
                    '        MsgBoxLocalized("생성된 매입금액이 없습니다. 처리불가!", MessageBoxButtons.OK, "Information", MessageBoxIcon.Information)
                    '        Exit Sub
                    '    End If

                    '    fTarget = frmMain.NavigateTo(Key)
                    '    If Not IsNothing(fTarget) Then
                    '        fTarget.GridInit()
                    '        fTarget.OFFICE_CD.SelectedValue = OFFICE_CD.SelectedValue
                    '        fTarget.INV_GB.SelectedValue = "B"
                    '        fTarget.DATE_GB.SelectedValue = "I"
                    '        'fTarget.FR_DATE.Text = PUR_YMD.Text
                    '        'fTarget.TO_DATE.Text = PUR_YMD.Text
                    '        fTarget.CUST_CD.Text = CUST_CD.Text
                    '        fTarget.CUST_NM.Text = CUST_NM.Text
                    '        fTarget.SearchData()
                    '    End If

                    'Case "EpsCostPrint"     '지출결의서 출력
                    '    Call PrintData()

                End Select
            Case Action.Addrow, Action.EventKey
                Select Case Sender
                    Case "WG1"
                        With GV1
                            Dim RowNum As Decimal = .FocusedRowHandle
                            .SetRowCellValue(RowNum, "TRF_TYPE", TRF_TYPE.SelectedValue)
                            .SetRowCellValue(RowNum, "FR_PORT", FR_PORT.Text)
                            .SetRowCellValue(RowNum, "ONEWAY_DEPOT", ONEWAY_DEPOT.Text)
                            .SetRowCellValue(RowNum, "CITY", CITY.Text)
                            .SetRowCellValue(RowNum, "STREET", STREET.Text)
                            .SetRowCellValue(RowNum, "AMT_2OF", 0)
                            .SetRowCellValue(RowNum, "AMT_40F", 0)
                            .SetRowCellValue(RowNum, "AMT_20F_CSM", 0)
                            .SetRowCellValue(RowNum, "AMT_40F_CSM", 0)
                            .FocusedColumn = .Columns("TRF_TYPE")
                            .ShowEditor()
                        End With
                End Select
            Case Action.DeleteRow
                Select Case Key
                    Case "WG1_DelRow"

                End Select
            Case Action.Other
                Select Case Key
                    Case ""

                End Select
        End Select

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
        dr("Key") = obj.Name + "_AddRow"
        dr("Action") = Action.Addrow
        obj.AddRow()

        PopUpOnAfterClick(GvAddRow.Rows(0))

    End Sub

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

    Private Sub GridToExcel(ByVal obj As YJIT.SC.UI.SCControls.WebGrid)
        Common.ExportToExcel(obj)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        '== 안전운임제 요율
        Call SearchDataWG1()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call NewData()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        '== 안전운임제 요율
        Call SaveDataWG1()
    End Sub

#Region "WG1 Event ---------------------------------"

    Private Sub btnAddWg1_Click(sender As Object, e As EventArgs) Handles btnAddWg1.Click
        Call AddGridRow(WG1)
    End Sub

    Private Sub btnDelWg1_Click(sender As Object, e As EventArgs) Handles btnDelWg1.Click
        Call DelGridRow(WG1)
    End Sub

    Private Sub btnExpWg1_Click(sender As Object, e As EventArgs) Handles btnExpWg1.Click
        Call GridToExcel(WG1)
    End Sub

#End Region

#End Region

End Class
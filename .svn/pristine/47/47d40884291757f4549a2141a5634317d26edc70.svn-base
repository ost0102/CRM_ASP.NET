Imports YJIT.SC.UI
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Windows
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Utils
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Commands
Imports DevExpress.XtraGrid.Views.Grid


Public Class EdmMainMgt


    Private Structure EDM_DOC_MST
        Dim RCVD_DTTM As String
        Dim RCVD_FILENAME As String
        Dim RCVD_PATH As String
        Dim RCVD_FAXNO As String
        Dim RCVD_SENDER As String
        Dim STATUS As String
        Dim EDM_NAME As String
        Dim EDM_CLS As String
        Dim EDM_TYP As String
        Dim EDM_NO As String
        Dim EDM_SEQ As String
        Dim EDM_RMK As String
        Dim EDM_TEAM As String
        Dim EDM_TPIC As String
        Dim USR_ID As String
    End Structure




    '    'Dim CustomTypeCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    '    'Dim GV_Flag As Boolean = False
    '    'Private tempRoot As String = Application.StartupPath & "\TMP_OUTPUT"
    '    'Protected filePath As String = String.Empty
    '    Private HotTrackRowValue As Integer = DevExpress.XtraGrid.GridControl.InvalidRowHandle
    '    Dim second As Integer = 0
    '    Dim MaxInterval As Integer = 0
    '    Dim Gv1PopUp As New PopupBase

#Region "=================Client Function==========="



    'Client Function : 클라이언트 동작 함수
    Private Sub SET_VSG_STANDBY_LINK()
        Try
            With VSG_STANDBY
                If .RowCount > 1 Then
                    VSG_EDM_NAME.Text = .GetFocusedRowCellValue("EDM_NAME").ToString
                    VSG_EDM_TEAM.SelectedValue = .GetFocusedRowCellValue("RCVD_FAXNO").ToString
                    VSG_EDM_TPIC.SelectedValue = .GetFocusedRowCellValue("EDM_TPIC").ToString
                    VSG_EDM_RMK.Text = .GetFocusedRowCellValue("EDM_RMK").ToString
                End If
            End With
        Catch ex As Exception
            MsgBoxLocalized(ex.Message, MessageBoxButtons.OK, "StandtyLink", MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "=================Data logic actions==========="


    Public Sub SearchRefreshData()
        Dim ds As DataSet
        Dim dr As DataRow

        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.EdmMainMgt", "SearchRefresh", {Me.ConvertToDataset})
        Catch ex As Exception
            MsgBoxLocalized(ex.Message, MessageBoxButtons.OK, "Search", MessageBoxIcon.Error)
            Exit Sub
        End Try

        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Search", MessageBoxIcon.Error)
            Me.ClearView(AppliedRangeTypes.Only, {WG_STANDBY})
            Exit Sub
        End If


        '자료 재조회시 기존 선택된 ROW 유지하기 위해서 추가
        Dim sRCVD_DTTM As String
        Dim sRCVD_FILENAME As String
        Dim iTOPROW As Integer

        sRCVD_DTTM = ""
        sRCVD_FILENAME = ""

        With VSG_STANDBY
            If .RowCount > 1 Then
                sRCVD_DTTM = .GetFocusedRowCellValue("RCVD_DTTM").ToString
                sRCVD_FILENAME = .GetFocusedRowCellValue("RCVD_FILENAME").ToString
                iTOPROW = .TopRowIndex
            End If
        End With
        '===================================================



        Me.BindToDataset(ds, "Data")


        '자료 재조회시 기존 선택된 ROW 유지하기 위해서 추가
        With VSG_STANDBY
            If .RowCount > 1 Then
                '해당 변수에 값이 있는 경우만 기존에 선택된 ROW 선택처리
                If Trim(sRCVD_DTTM) <> "" And Trim(sRCVD_DTTM) <> "" Then
                    For i = 0 To .RowCount - 1
                        If sRCVD_DTTM = .GetFocusedRowCellValue("RCVD_DTTM").ToString AndAlso sRCVD_FILENAME = .GetFocusedRowCellValue("RCVD_FILENAME").ToString Then
                            .FocusedRowHandle = i
                            .TopRowIndex = iTOPROW
                            Exit For
                        End If
                    Next
                End If
            End If
        End With
        '===================================================


        'click, focusrowchange 이벤트에 추가
        '하단 변경자료 연동하기 위해서 추가
        Call SET_VSG_STANDBY_LINK()


        'click, focusrowchange 이벤트에 추가
        With VSG_STANDBY
            With VSG_STANDBY
                If SET_TIF_VIEW(ImgEdit1, .GetFocusedRowCellValue("RCVD_PATH").ToString, .GetFocusedRowCellValue("RCVD_FILENAME").ToString, PAGE, btnPages, Zooms, ImgThumbnail1) = False Then
                    'FocusedRowChanged 특성상 파일 다운로드 실패시 계속 함수 호출됨
                    'Call SearchRefreshData()
                End If
            End With
        End With


        Me.DataState = UI.DataStates.Retrieved
    End Sub








    'Private Sub InitData()

    '    Dim dtCol As DataTable = New DataTable
    '    dtCol.Columns.Add(New DataColumn("CODE"))
    '    dtCol.Columns.Add(New DataColumn("NAME"))

    '    dtCol.Rows.Add()
    '    dtCol.Rows(0)("CODE") = "0"
    '    dtCol.Rows(0)("NAME") = "미확인"

    '    dtCol.Rows.Add()
    '    dtCol.Rows(1)("CODE") = "1"
    '    dtCol.Rows(1)("NAME") = "완료"

    '    dtCol.Rows.Add()
    '    dtCol.Rows(2)("CODE") = "2"
    '    dtCol.Rows(2)("NAME") = "즉시처리"

    '    dtCol.Rows.Add()
    '    dtCol.Rows(3)("CODE") = "3"
    '    dtCol.Rows(3)("NAME") = "재발신예정"

    '    dtCol.Rows.Add()
    '    dtCol.Rows(4)("CODE") = "4"
    '    dtCol.Rows(4)("NAME") = "재발신"

    '    dtCol.Rows.Add()
    '    dtCol.Rows(5)("CODE") = "5"
    '    dtCol.Rows(5)("NAME") = "수정요청"

    '    dtCol.Rows.Add()
    '    dtCol.Rows(6)("CODE") = "6"
    '    dtCol.Rows(6)("NAME") = "추가요청"

    '    dtCol.Rows.Add()
    '    dtCol.Rows(7)("CODE") = "7"
    '    dtCol.Rows(7)("NAME") = "처리중"

    '    dtCol.Rows.Add()
    '    dtCol.Rows(8)("CODE") = "8"
    '    dtCol.Rows(8)("NAME") = "보류"

    '    dtCol.TableName = "ProcType"

    '    Dim bindingSourceProduct = New BindingSource()
    '    bindingSourceProduct.DataSource = dtCol
    '    S_PROC_TYPE.Properties.DataSource = bindingSourceProduct.DataSource
    '    S_PROC_TYPE.Properties.ValueMember = "CODE"
    '    S_PROC_TYPE.Properties.DisplayMember = "NAME"
    '    S_PROC_TYPE.Properties.NullText = String.Empty
    '    S_PROC_TYPE.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
    '    S_PROC_TYPE.Properties.SeparatorChar = ";"


    '    dtCol = New DataTable
    '    dtCol.Columns.Add(New DataColumn("CODE"))
    '    dtCol.Columns.Add(New DataColumn("NAME"))

    '    dtCol.Rows.Add()
    '    dtCol.Rows(0)("CODE") = "E"
    '    dtCol.Rows(0)("NAME") = "ELVIS"

    '    dtCol.Rows.Add()
    '    dtCol.Rows(1)("CODE") = "V"
    '    dtCol.Rows(1)("NAME") = "일반"

    '    dtCol.Rows.Add()
    '    dtCol.Rows(2)("CODE") = "T"
    '    dtCol.Rows(2)("NAME") = "T/S"

    '    dtCol.Rows.Add()
    '    dtCol.Rows(3)("CODE") = "M"
    '    dtCol.Rows(3)("NAME") = "적하목록"

    '    dtCol.Rows.Add()
    '    dtCol.Rows(4)("CODE") = "Z"
    '    dtCol.Rows(4)("NAME") = "기타"

    '    bindingSourceProduct = New BindingSource()
    '    bindingSourceProduct.DataSource = dtCol
    '    S_SVC_CD.Properties.DataSource = bindingSourceProduct.DataSource
    '    S_SVC_CD.Properties.ValueMember = "CODE"
    '    S_SVC_CD.Properties.DisplayMember = "NAME"
    '    S_SVC_CD.Properties.NullText = String.Empty
    '    S_SVC_CD.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
    '    S_SVC_CD.Properties.SeparatorChar = ";"


    '    Timer1.Interval = 1000
    '    Timer1.Stop()

    'End Sub
    'Private Property HotTrackRow() As Integer
    '    Get
    '        Return HotTrackRowValue
    '    End Get

    '    Set(ByVal Value As Integer)
    '        If HotTrackRowValue <> Value Then
    '            Dim PrevHotTrackRow As Integer
    '            PrevHotTrackRow = HotTrackRowValue
    '            HotTrackRowValue = Value
    '            VSG_STANDBY.RefreshRow(PrevHotTrackRow)
    '            VSG_STANDBY.RefreshRow(HotTrackRowValue)
    '        End If
    '    End Set

    'End Property


    'Private Sub DeleteData()
    '    Dim ds As DataSet
    '    Dim dr As DataRow
    '    Dim insFlag As String = ""

    '    Try
    '        If MsgBoxLocalized("Do you want to delete?", MessageBoxButtons.YesNo, "Delete", MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.No Then Exit Sub
    '        ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgt", "Delete", Me.ConvertToDataset)

    '    Catch ex As Exception
    '        MsgBoxLocalized(ex.Message, MessageBoxButtons.OK, "Delete", MessageBoxIcon.Error)
    '        Exit Sub
    '    End Try

    '    dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

    '    If dr("TrxCode") <> "Y" Then
    '        MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Delete", MessageBoxIcon.Error)
    '        Exit Sub
    '    End If
    '    Me.BindToDataset(ds, "Data")
    '    Me.DataState = UI.DataStates.Retrieved


    'End Sub

    'Public Sub PopUpOnBeforeClick(ByVal dr As DataRow)
    '    Dim Key As String = dr("KEY")
    '    Dim Sender As String = ""
    '    If Not dr("Sender") Is System.DBNull.Value Then Sender = dr("Sender")

    '    Try
    '        Select Case dr("Action")
    '            Case Action.Addrow, Action.EventKey
    '                Select Case Key
    '                    Case "WG1_ADDROW"
    '                        If POPUP_INPUT.Checked = True Then
    '                            dr("Cancel") = True
    '                            Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
    '                            Dim fTarget As Object = Nothing
    '                            frmMain = Me.MdiParent
    '                            fTarget = frmMain.NavigateTo("CrmAsInput", NavigatedWindowModes.Dialog, False)
    '                            If Not IsNothing(fTarget) Then
    '                                fTarget.frmMain = frmMain
    '                                fTarget.NewData()
    '                                fTarget.ShowDialog()
    '                            End If
    '                        End If

    '                End Select

    '        End Select

    '    Catch ex As Exception
    '        MsgBoxLocalized(ex.Message, MessageBoxButtons.OK, "Process failed!", MessageBoxIcon.Error)
    '        dr("Cancel") = True
    '    End Try

    'End Sub

    'Public Sub PopUpOnAfterClick(ByVal Dr As DataRow)
    '    Dim Key As String = Dr("Key")
    '    Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
    '    Dim fTarget As Object = Nothing
    '    Dim rowIndex As Integer = 0
    '    Select Case Dr("Action")
    '        Case Action.NavigateTo
    '            frmMain = Me.MdiParent
    '            Select Case Key
    '                Case "ComDocumentMgt"
    '                    fTarget = frmMain.NavigateTo(Key, NavigatedWindowModes.Dialog, False)
    '                    If Not IsNothing(fTarget) Then
    '                        fTarget.ParentWindow = Me
    '                        fTarget.S_MNGT_NO.text = VSG_STANDBY.GetFocusedRowCellValue("MNGT_NO").ToString
    '                        fTarget.SCREEN.Text = "사이트 지원 등록"
    '                        fTarget.DirList.Text = "CrmAsMgt"
    '                        fTarget.SearchData()
    '                        fTarget.ShowDialog()
    '                        Call SetDocType()
    '                    End If
    '            End Select
    '        Case Action.Addrow
    '            Select Case Key
    '                Case "WG1_ADDROW"
    '                    VSG_STANDBY.SetRowCellValue(VSG_STANDBY.FocusedRowHandle, "REQ_YMD", DateTime.Now.ToString("yyyyMMdd"))
    '                    VSG_STANDBY.SetRowCellValue(VSG_STANDBY.FocusedRowHandle, "REQ_HM", DateTime.Now.ToString("yyyyMMddhhmmss").Substring(8, 4))
    '                    VSG_STANDBY.OptionsBehavior.Editable = True

    '            End Select
    '        Case Action.CheckBox
    '            Select Case Key
    '                Case "RegPopup"
    '                    POPUP_INPUT.Checked = Gv1PopUp.CheckBoxValue("RegPopup")
    '            End Select
    '        Case Action.Other
    '            Select Case Key
    '                Case "Complete"
    '                    VSG_STANDBY.SetRowCellValue(VSG_STANDBY.FocusedRowHandle, "PROC_TYPE", "1")
    '            End Select
    '    End Select

    'End Sub

    'Public Sub SearchData(ByVal MngtNo As String)

    '    Dim ds As DataSet = Me.ConvertToDataset

    '    Dim params() As Object = {ds}
    '    ds.Tables("MAIN").Columns.Add("S_PROC_TYPE")
    '    ds.Tables("MAIN").Rows(0)("S_PROC_TYPE") = S_PROC_TYPE.EditValue
    '    ds.Tables("MAIN").Columns.Add("S_MNGT_NO")
    '    ds.Tables("MAIN").Rows(0)("S_MNGT_NO") = MngtNo
    '    ds.Tables("MAIN").Columns.Add("S_SVC_CD")
    '    ds.Tables("MAIN").Rows(0)("S_SVC_CD") = S_SVC_CD.EditValue

    '    Try
    '        YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.CrmAsMgt", "Search", params, AddressOf SearchOnComplete)

    '    Catch ex As Exception
    '        MsgBoxLocalized(ex.Message)
    '    End Try
    'End Sub

    'Private Sub SearchOnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
    '    Try
    '        If IsNothing(e.Result) Then
    '            Throw New Exception("Try Again !")
    '        End If

    '        Dim ds As DataSet = e.Result
    '        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

    '        Me.ClearView(UI.AppliedRangeTypes.Except, {SEARCH_KEY, FM_YMD, TO_YMD, POPUP_INPUT, S_ROW_BEST, REF_TIME, S_PRIORITY, S_SEARCH_PR})

    '        If dr("TrxCode") <> "Y" Then
    '            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Search", MessageBoxIcon.Warning)
    '            Exit Sub
    '        End If
    '        Me.BindToDataset(ds, "Data")
    '        Me.DataState = UI.DataStates.Retrieved

    '        VSG_STANDBY.OptionsBehavior.Editable = False
    '        If POPUP_INPUT.Checked = True Then
    '            VSG_STANDBY.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Default
    '            VSG_STANDBY.OptionsBehavior.Editable = False
    '        Else
    '            VSG_STANDBY.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
    '            VSG_STANDBY.OptionsBehavior.Editable = True
    '        End If

    '    Catch ex As Exception
    '        MsgBoxLocalized(ex.Message)
    '    End Try

    'End Sub



    'Private Sub NewData()

    '    ClearView(UI.AppliedRangeTypes.Except, {WG1, SEARCH_KEY, S_ROW_BEST, S_PROC_TYPE, POPUP_INPUT, REF_TIME, S_PRIORITY, S_SEARCH_PR})

    'End Sub

    'Public Sub SaveData()

    '    If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.YesNo) = MsgBoxResult.No Then Exit Sub


    '    Dim dsResult As DataSet
    '    Try
    '        dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgt", "Save", Me.ConvertToDataset)
    '    Catch ex As Exception
    '        MsgBoxLocalized(ex.Message)
    '        Exit Sub
    '    End Try

    '    Dim dr As DataRow
    '    dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
    '    If dr("TrxCode") = "Y" Then
    '        Call SearchData("")
    '    Else
    '        MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
    '        Exit Sub
    '    End If

    'End Sub

    Public Sub GridInit()
        Call SetEdmGridStyle({VSG_STANDBY, VSG_SEARCH, VSG_BLNO, VSG_EDMDOC})

    End Sub

    'Private Function GetCustomerInfo() As DataTable
    '    /////////// 거래처정보 ///////////'
    '    Dim dt As New DataTable
    '    dt.Columns.Add(New DataColumn("CODE", GetType(String)))
    '    dt.Columns.Add(New DataColumn("NAME", GetType(String)))

    '    AddNewRow(dt, "01", "ETC")

    '    Return dt
    'End Function
    'Private Sub AddNewRow(ByVal dt As DataTable, ByVal Code As String, ByVal Name As String)
    '    dt.Rows.Add()
    '    dt.Rows(dt.Rows.Count - 1)("CODE") = Code
    '    dt.Rows(dt.Rows.Count - 1)("NAME") = Name
    'End Sub

#End Region
#Region "=================Control Events==========="
    Private Sub EdmMainMgt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'FM_YMD.Text = Now.AddMonths(-1).ToString("yyyyMMdd")
        'TO_YMD.Text = Now.AddMonths(1).ToString("yyyyMMdd")

        'Call InitData()

        ''MOUSE WHELL Hook Form & Control to be ignored
        'Call WheelHook(Me.hWnd)








    End Sub



    Private Sub EdmMainMgt_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        Call GridInit()

        SplitCtrlImgEdit.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2


        'SaveControlValues(Me, {WG1, POPUP_INPUT, FM_YMD, S_ROW_BEST, S_SEARCH_PR, S_PRIORITY, S_PROC_TYPE, REF_TIME})

        'Gv1PopUp.CheckBoxValue("RegPopup") = POPUP_INPUT.Checked

        'If REF_TIME.SelectedValue = "0" Then
        '    Timer1.Stop()
        'Else
        '    MaxInterval = 60 * CDbl(REF_TIME.SelectedValue)
        '    Timer1.Start()
        'End If

    End Sub
    Private Sub CMD_VSG_REFRESH_Click(sender As System.Object, e As System.EventArgs) Handles CMD_VSG_REFRESH.Click
        Call SearchRefreshData()
    End Sub

    'Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_FIND.Click, CMD_CANCEL.Click
    '    SearchData("")
    'End Sub

    'Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_SAVE.Click, CMD_EDITER.Click, CMD_MERGE.Click
    '    SaveData()
    'End Sub


    'Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs)
    '    Call DeleteData()
    'End Sub

    'Private Sub SEARCH_KEY_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles SEARCH_KEY.PreviewKeyDown, EDM_NAME.PreviewKeyDown, WORKNM.PreviewKeyDown, VSG_EDM_NAME.PreviewKeyDown, VSG_EDM_RMK.PreviewKeyDown, PAGE.PreviewKeyDown, Zooms.PreviewKeyDown
    '    If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) Then
    '        Call SearchData("")
    '    End If
    'End Sub

    'Private Sub GV1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VSG_STANDBY.CellValueChanged, VSG_EDMDOC.CellValueChanged, VSG_BLNO.CellValueChanged, VSG_SEARCH.CellValueChanged
    '    Try
    '        CUST_CD.Text = GV1.GetRowCellValue(GV1.FocusedRowHandle, "CUST_CD").ToString
    '        'Select Case e.Column.FieldName
    '        '    Case "PROC_TYPE"
    '        '        If GV1.GetRowCellValue(GV1.FocusedRowHandle, "PROC_TYPE").ToString = "1" Or GV1.GetRowCellValue(GV1.FocusedRowHandle, "PROC_TYPE").ToString = "2" Then
    '        '            GV1.SetRowCellValue(GV1.FocusedRowHandle, "CMPT_YMD", Now.ToString("yyyyMMdd"))
    '        '        Else
    '        '            GV1.SetRowCellValue(GV1.FocusedRowHandle, "CMPT_YMD", "")
    '        '        End If

    '        '        If GV1.GetRowCellValue(GV1.FocusedRowHandle, "PROC_TYPE").ToString = "1" Or
    '        '            GV1.GetRowCellValue(GV1.FocusedRowHandle, "PROC_TYPE").ToString = "2" Or
    '        '            GV1.GetRowCellValue(GV1.FocusedRowHandle, "PROC_TYPE").ToString = "7" Or
    '        '            GV1.GetRowCellValue(GV1.FocusedRowHandle, "PROC_TYPE").ToString = "8" Then

    '        '            GV1.SetRowCellValue(GV1.FocusedRowHandle, "WORK_USR", ClientSessionInfo.LocalName)
    '        '        Else
    '        '            GV1.SetRowCellValue(GV1.FocusedRowHandle, "WORK_USR", "")
    '        '        End If
    '        'End Select
    '    Catch ex As Exception
    '        MsgBoxLocalized(ex.Message)
    '        Exit Sub
    '    End Try
    'End Sub


    'Private Sub GV1_FocusedColumnChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles VSG_STANDBY.FocusedColumnChanged, VSG_EDMDOC.FocusedColumnChanged, VSG_BLNO.FocusedColumnChanged, VSG_SEARCH.FocusedColumnChanged
    '    Try
    '        CUST_CD.Text = GV1.GetRowCellValue(GV1.FocusedRowHandle, "CUST_CD").ToString
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub GV1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles VSG_STANDBY.DoubleClick, VSG_EDMDOC.DoubleClick, VSG_BLNO.DoubleClick, VSG_SEARCH.DoubleClick
    '    Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
    '    Dim fTarget As Object = Nothing

    '    If POPUP_INPUT.Checked = True Then
    '        frmMain = Me.MdiParent
    '        fTarget = frmMain.NavigateTo("CrmAsInput", NavigatedWindowModes.Dialog, False)
    '        If Not IsNothing(fTarget) Then
    '            fTarget.frmMain = frmMain
    '            fTarget.MNGT_NO.Text = VSG_STANDBY.GetRowCellValue(VSG_STANDBY.FocusedRowHandle, "MNGT_NO").ToString
    '            fTarget.SearchData()
    '            fTarget.ShowDialog()
    '        End If
    '    Else
    '        ' GV1.OptionsBehavior.Editable = True
    '    End If


    'End Sub

    'Private Sub GV1_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles VSG_STANDBY.RowCellStyle, VSG_EDMDOC.RowCellStyle, VSG_BLNO.RowCellStyle, VSG_SEARCH.RowCellStyle
    '    If e.RowHandle = HotTrackRow Then
    '        e.Appearance.BackColor = Color.PaleGoldenrod
    '    End If
    'End Sub
    'Private Sub S_ROW_BEST_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles S_ROW_BEST.SelectedIndexChanged, EDM_TEAM.SelectedIndexChanged, EDM_TPIC.SelectedIndexChanged, EDM_PART.SelectedIndexChanged, VSG_EDM_TEAM.SelectedIndexChanged, VSG_EDM_TPIC.SelectedIndexChanged
    '    If S_ROW_BEST.SelectedValue = "Y" Then
    '        VSG_STANDBY.OptionsView.RowAutoHeight = True
    '    Else
    '        VSG_STANDBY.OptionsView.RowAutoHeight = False
    '    End If
    'End Sub

    'Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

    '    second = second + 1
    '    If second >= MaxInterval Then
    '        second = 0
    '        SearchData("")
    '    End If

    'End Sub

    'Private Sub REF_TIME_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles REF_TIME.SelectedValueChanged
    '    If REF_TIME.SelectedValue = "0" Then
    '        Timer1.Stop()
    '    Else
    '        MaxInterval = 60 * CDbl(REF_TIME.SelectedValue)
    '        Timer1.Start()
    '    End If

    'End Sub


    'Private Sub POPUP_INPUT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POPUP_INPUT.CheckedChanged
    '    If POPUP_INPUT.Checked = True Then
    '        VSG_STANDBY.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Default
    '        VSG_STANDBY.OptionsBehavior.Editable = False
    '    Else
    '        VSG_STANDBY.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
    '        VSG_STANDBY.OptionsBehavior.Editable = True
    '    End If
    'End Sub
#End Region




    '    'Private Sub GV1_ShownEditor(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GV1.ShownEditor
    '    '    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)

    '    '    'TPSZ 컬럼에 들어오면 드롭다운 박스를 펼침
    '    '    If (view.FocusedColumn.FieldName = "REQ_SVC") Or (view.FocusedColumn.FieldName = "PROC_TYPE") Or (view.FocusedColumn.FieldName = "PRIORITY") Then
    '    '        Dim edit As DevExpress.XtraEditors.LookUpEdit = CType(view.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
    '    '        Dim ViewInfo As DevExpress.XtraEditors.ViewInfo.ButtonEditViewInfo = edit.GetViewInfo()

    '    '        Dim hi As DevExpress.XtraEditors.ViewInfo.EditHitInfo = ViewInfo.CalcHitInfo(edit.PointToClient(MousePosition))
    '    '        BeginInvoke(New Action(Of DevExpress.XtraEditors.LookUpEdit)(Sub(ed) ed.ShowPopup()), edit)
    '    '    End If
    '    'End Sub


    Private Sub VSG_STANDBY_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VSG_STANDBY.FocusedRowChanged
        'Click 이벤트도 조건 추가해야함

        'Call SET_GRID_CHECKBOX("Click", VSG_STANDBY)

        Call SET_VSG_STANDBY_LINK()


        With VSG_STANDBY
            If SET_TIF_VIEW(ImgEdit1, .GetFocusedRowCellValue("RCVD_PATH").ToString, .GetFocusedRowCellValue("RCVD_FILENAME").ToString, PAGE, btnPages, Zooms, ImgThumbnail1) = False Then
                'FocusedRowChanged 특성상 파일 다운로드 실패시 계속 함수 호출됨
                'Call SearchRefreshData()
            End If
        End With

    End Sub









    Private Sub palAutoButton_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles palAutoButton.Paint
        CMD_VSG_REFRESH.Enabled = True
        CMD_VSG_MERGE.Enabled = True
        CMD_VSG_DEL.Enabled = True
        CMD_VSG_UPLOAD.Enabled = True

    End Sub

    Private Sub CMD_VSG_MERGE_Click(sender As System.Object, e As System.EventArgs) Handles CMD_VSG_MERGE.Click
        Dim E_NEW As EDM_DOC_MST
        Dim iCNT As Integer

        Try
            'Merge 폴더에 필요한 파일 복사
            '폴더에 모든 파일 병합
            '서버에 새로 추가


            '정상적으로 처리완료된 문서는 병합후 삭제로 STATUS 변경


            '체크된 자료 있는지 확인
            iCNT = GetEdmGridCheckCount(VSG_STANDBY)
            If iCNT = 0 Then
                MsgBoxLocalized("자료를 선택하세요." & vbCrLf & vbCrLf & EdmErrMsg.MSG15, MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Error)
                Exit Sub
            ElseIf iCNT = 1 Then
                MsgBoxLocalized("한개 이상 자료를 선택하세요." & vbCrLf & vbCrLf & EdmErrMsg.MSG15, MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Error)
                Exit Sub
            End If

            Call SetEdmDirectoryClear(EdmPath.Merge)

            With VSG_STANDBY
                For i = 0 To .RowCount - 1
                    If .GetRowCellValue(i, "CHK").ToString = "Y" Then
                        Dim retD As New Dictionary(Of String, String)
                        retD = EdmDownLoad(VSG_STANDBY.GetRowCellValue(i, "RCVD_FILENAME").ToString, _
                                 VSG_STANDBY.GetRowCellValue(i, "RCVD_PATH").ToString, _
                                 EdmPath.Merge & VSG_STANDBY.GetRowCellValue(i, "RCVD_FILENAME").ToString)
                        If retD("TrxCode").ToString <> "Y" Then
                            MsgBoxLocalized(retD("TrxMsg").ToString, MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If
                Next
            End With


            E_NEW.RCVD_PATH = "/EDM/" & Now.ToString("yyyy") & "/" & Now.ToString("MM") & "/" & Now.ToString("dd")
            E_NEW.RCVD_FILENAME = GetEdmFolderMerge(EdmPath.Merge)
            If Trim(E_NEW.RCVD_FILENAME) = "" Then
                MsgBoxLocalized("파일 병합에 실패했습니다. " & EdmErrMsg.MSG15, MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Error)
                Exit Sub
            End If


            If Not EdmUpload(EdmPath.Merge & E_NEW.RCVD_FILENAME, E_NEW.RCVD_FILENAME, E_NEW.RCVD_PATH & "/") Then
                Throw New Exception("파일 병합후 서버전송시 오류가 발생했습니다. ")
            End If


            E_NEW.EDM_NAME = Format(Now, "yyyy-MM-dd hh:mm")
            E_NEW.EDM_RMK = E_NEW.RCVD_FILENAME
            E_NEW.EDM_TPIC = VSG_EDM_TPIC.SelectedValue
            E_NEW.RCVD_FAXNO = VSG_EDM_TEAM.SelectedValue
            E_NEW.USR_ID = ClientSessionInfo.UserID
            E_NEW.RCVD_DTTM = Now.ToString("yyyyMMddhhmmss") '20120601143512



            Dim ds As DataSet
            Dim dr As DataRow

            Try
                Dim params() As Object = {E_NEW.RCVD_DTTM.ToString _
                                        , E_NEW.RCVD_FILENAME.ToString _
                                        , E_NEW.RCVD_PATH.ToString _
                                        , E_NEW.RCVD_FAXNO.ToString _
                                        , E_NEW.EDM_NAME.ToString _
                                        , E_NEW.EDM_RMK.ToString _
                                        , E_NEW.EDM_TPIC.ToString _
                                        , E_NEW.USR_ID.ToString}
                ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.EdmMainMgt", "SaveStandby", params)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") <> "Y" Then
                Throw New Exception(dr("TrxMsg"))
            End If


            '기존등록자료 병합후 삭제로 STATUS 변경
            With VSG_STANDBY
                For i = 0 To .RowCount - 1
                    If .GetRowCellValue(i, "CHK") = "Y" Then
                        Try
                            Dim params() As Object = {.GetRowCellValue(i, "RCVD_DTTM").ToString, .GetRowCellValue(i, "RCVD_FILENAME").ToString, ClientSessionInfo.UserID}
                            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.EdmMainMgt", "DeleteStandbyMerge", params)
                        Catch ex As Exception
                            Throw New Exception(ex.Message)
                        End Try

                        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

                        If dr("TrxCode") <> "Y" Then
                            Throw New Exception(dr("TrxMsg"))
                        End If

                    End If
                Next
            End With
            '========================================================


            If SET_TIF_VIEW(ImgEdit1, E_NEW.RCVD_PATH, E_NEW.RCVD_FILENAME, PAGE, btnPages, Zooms, ImgThumbnail1) = True Then
                Call SearchRefreshData()
            Else
                MsgBoxLocalized("파일 병합에 실패했습니다. " & EdmErrMsg.MSG15)
                Exit Sub
            End If

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub

    Private Sub CMD_VSG_DEL_Click(sender As System.Object, e As System.EventArgs) Handles CMD_VSG_DEL.Click

        Dim iCNT As Integer

        Dim sRCVD_DTTM As String
        Dim sRCVD_FILENAME As String
        Dim sUSR_ID As String

        Try
            '체크된 자료 있는지 확인
            iCNT = GetEdmGridCheckCount(VSG_STANDBY)
            If iCNT = 0 Then
                If MsgBoxLocalized("자료를 삭제하시겠습니까?", MessageBoxButtons.YesNo) = MsgBoxResult.No Then
                    MsgBoxLocalized(EdmErrMsg.MSG15, vbInformation, EdmErrMsg.MSG20)
                    Exit Sub
                End If

                '선택된 자료 체크박스 처리
                VSG_STANDBY.SetRowCellValue(VSG_STANDBY.FocusedRowHandle, "CHK", "Y")
            Else
                If MsgBoxLocalized(iCNT & " 건이 선택되었습니다. 모두 삭제하시겠습니까?", MessageBoxButtons.YesNo) = MsgBoxResult.No Then
                    MsgBoxLocalized(EdmErrMsg.MSG15, vbInformation, EdmErrMsg.MSG20)
                    Exit Sub
                End If
            End If

            iCNT = 0

            With VSG_STANDBY
                WG_STANDBY.BeginUpdate()
                'RemoveItem 을 사용하기 위해서 뒤에서 부터 루핑처리
                For i = .RowCount - 1 To 0 Step -1
                    If .GetRowCellValue(i, "CHK") = "Y" Then
                        sRCVD_DTTM = .GetRowCellValue(i, "RCVD_DTTM").ToString
                        sRCVD_FILENAME = .GetRowCellValue(i, "RCVD_FILENAME").ToString
                        sUSR_ID = ClientSessionInfo.UserID

                        Dim ds As DataSet
                        Dim dr As DataRow
                        Try
                            Dim params() As Object = {sRCVD_DTTM, sRCVD_FILENAME, sUSR_ID}
                            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.EdmMainMgt", "DeleteStandby", params)
                        Catch ex As Exception
                            Throw New Exception(ex.Message)
                        End Try

                        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

                        If dr("TrxCode") <> "Y" Then
                            Throw New Exception(dr("TrxMsg"))
                        End If


                        .DeleteRow(i)

                        iCNT = iCNT + 1

                        If .RowCount > 1 Then
                            If i = 1 Then
                                .FocusedRowHandle = i
                            Else
                                .FocusedRowHandle = i - 1
                            End If
                        End If
                    End If
                Next
                WG_STANDBY.EndUpdate()
            End With

            Call SearchRefreshData()

            MsgBoxLocalized(iCNT & " 건 삭제되었습니다", MessageBoxButtons.OK, EdmErrMsg.MSG20)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message, MessageBoxButtons.OK, EdmErrMsg.MSG20)
        End Try
    End Sub


    Private Sub CMD_VSG_UPLOAD_Click(sender As System.Object, e As System.EventArgs) Handles CMD_VSG_UPLOAD.Click



        Dim E_NEW As EDM_DOC_MST

        Dim sTEMP_FILEPATH As String
        Dim sTEMP_FILENAME As String
        'Dim sTEMP_FAXPATH As String
        'Dim sTEMP_FAXNAME As String
        Dim sTEMP_NETFAXNAME As String = String.Empty

        Dim sFilter As String
        Dim arrFILES As Object
        'Dim I As Double
        Dim sErrorFile As String


        sTEMP_FILENAME = ""

        Dim ofd As OpenFileDialog = New OpenFileDialog()
        ofd.AddExtension = True

        sFilter = "모든파일|*.*"
        sFilter = sFilter & "|PDF file(*.PDF)|*.PDF"
        sFilter = sFilter & "|Text file(*.txt)|*.txt"
        sFilter = sFilter & "|Excel file(*.xls;*.xlsx)|*.xls;*.xlsx"
        sFilter = sFilter & "|Word file(*.doc;*.docx)|*.doc;*.docx"
        sFilter = sFilter & "|PowerPoint file(*.ppt;*.pptx)|*.ppt;*.pptx"
        sFilter = sFilter & "|Tif file(*.tif;*.tiff)|*.tif;*.tiff"
        sFilter = sFilter & "|Image file|*.png;*.jpg;*.gif;*.bmp"
        sFilter = sFilter & "|HWP file(*.hwp)|*.hwp"
        ofd.Filter = sFilter
        ofd.DefaultExt = "*.*"

        ofd.Multiselect = True
        ofd.FileName = ""

        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            arrFILES = ofd.FileNames
            'arrFILES = Split(.FileName, Chr(0))

            ''단일파일 선택이라 특수문자없음
            'If UBound(arrFILES) = 0 Then
            '    ReDim arrFILES(1)
            '    '0번은 폴더
            '    '1번부터 파일명
            '    arrFILES(0) = Mid(.FileName, 1, InStrRev(.FileName, "\"))   '\포함
            '    arrFILES(1) = Mid(.FileName, InStrRev(.FileName, "\") + 1)
            'End If
            ''==============================
        Else
            Exit Sub
        End If


        sErrorFile = ""
        sTEMP_FILENAME = ""
        sTEMP_FILEPATH = EdmPath.Upload & Now.ToString("yyyy") & "/" & Now.ToString("MM") & "/" & Now.ToString("dd")


        '중요안내를 한번만 띄우도록 별도로 처리
        Dim bImgFile As Boolean
        Dim bPdfFile As Boolean
        bImgFile = False
        bPdfFile = False
        For I = 1 To UBound(arrFILES)
            If InStr(".JPG .GIF .BMP .PNG", Microsoft.VisualBasic.Right(arrFILES(I), 4).ToUpper) <> 0 Then
                bImgFile = True
            ElseIf InStr(".PDF", Microsoft.VisualBasic.Right(arrFILES(I), 4).ToUpper) <> 0 Then
                bPdfFile = True
            End If
        Next
        If bImgFile = True And bPdfFile = True Then
            sErrorFile = ""
            sErrorFile = sErrorFile & "[IMG] 이미지 출력시 출력화면에서 ITFAX Printer Driver로 선택후 출력하시기 바랍니다."
            sErrorFile = sErrorFile & vbCrLf & vbCrLf
            sErrorFile = sErrorFile & "[PDF] PDF파일은 인쇄시 실행된 Adobe Reader를 종료하셔야 완료됩니다."
            sErrorFile = sErrorFile & vbCrLf & vbCrLf & vbCrLf
            sErrorFile = sErrorFile & "이미지와 PDF파일이 포함되어있습니다. 직접출력버튼 누르고 Adobe Reader를 꼭 종료하시기 바랍니다."
            MsgBoxLocalized(sErrorFile, MessageBoxButtons.OK, EdmErrMsg.MSG20)
        ElseIf bImgFile = True Then
            MsgBoxLocalized("이미지 출력시 출력화면에서 ITFAX Printer Driver로 선택후 출력하시기 바랍니다.", MessageBoxButtons.OK, EdmErrMsg.MSG20)
        ElseIf bPdfFile = True Then
            MsgBoxLocalized("PDF파일은 인쇄시 실행된 Adobe Reader를 종료하셔야 완료됩니다.", MessageBoxButtons.OK, EdmErrMsg.MSG20)
        End If
        '======================================


        sErrorFile = ""
        Dim tempFile As IO.FileInfo = Nothing

        For i = 0 To UBound(arrFILES) '20151109 김성은 단일파일이 아닌경우 누락될수 있어서 수정 / 'i가 1부터라 - 1 은 제거

            tempFile = New System.IO.FileInfo(arrFILES(i))
            'sTEMP_FAXPATH = arrFILES(0)
            'sTEMP_FAXNAME = arrFILES(i)

            'Select Case Microsoft.VisualBasic.Right(sTEMP_FAXNAME, 4).ToUpper
            Select Case tempFile.Extension.ToString.ToUpper
                Case ".TIF", ".TIFF"
                    '무조건 파일명 재생성해서 등록
                    sTEMP_FILENAME = GetEdmFileName(ClientSessionOfficeInfo.HqOfficeCode, "EDM")

                    '이미지 재생성 없이 그대로 등록 / 아직까지 문제없었음 / 형식에 문제가 되는 경우가 있으면 재생성 로직 추가 예정
                    'If EDMS_Ftp_Upload(GB_COMKEY, EDMS_FTP_SERVER, EDMS_FTP_USER, EDMS_FTP_PassW, EDMS_Ftp_PORT, sTEMP_FILEPATH, sTEMP_FILENAME, sTEMP_FAXPATH, sTEMP_FAXNAME) = True Then

                    If EdmUpload(tempFile.FullName, sTEMP_FILENAME, sTEMP_FILEPATH) Then

                        E_NEW.RCVD_DTTM = Format(Now, "yyyyMMddhhmmss")
                        E_NEW.RCVD_FILENAME = sTEMP_FILENAME
                        E_NEW.RCVD_PATH = sTEMP_FILEPATH
                        E_NEW.RCVD_FAXNO = EDM_TEAM.SelectedValue
                        E_NEW.RCVD_SENDER = ClientSessionInfo.UserID
                        E_NEW.STATUS = "1" '대기문서
                        E_NEW.EDM_NAME = tempFile.Name 'sTEMP_FAXNAME
                        E_NEW.EDM_CLS = ""
                        E_NEW.EDM_TYP = ""
                        E_NEW.EDM_NO = ""
                        E_NEW.EDM_SEQ = ""
                        E_NEW.EDM_RMK = ""
                        E_NEW.EDM_TEAM = EDM_TEAM.SelectedText
                        E_NEW.EDM_TPIC = EDM_TPIC.SelectedValue
                        E_NEW.USR_ID = ClientSessionInfo.UserID



                        Dim ds As DataSet
                        Dim dr As DataRow

                        Try
                            Dim params() As Object = {E_NEW.RCVD_DTTM.ToString _
                                                    , E_NEW.RCVD_FILENAME.ToString _
                                                    , E_NEW.RCVD_PATH.ToString _
                                                    , E_NEW.RCVD_FAXNO.ToString _
                                                    , E_NEW.RCVD_SENDER.ToString _
                                                    , E_NEW.STATUS.ToString _
                                                    , E_NEW.EDM_NAME.ToString _
                                                    , E_NEW.EDM_CLS.ToString _
                                                    , E_NEW.EDM_TYP.ToString _
                                                    , E_NEW.EDM_NO.ToString _
                                                    , E_NEW.EDM_SEQ.ToString _
                                                    , E_NEW.EDM_RMK.ToString _
                                                    , E_NEW.EDM_TEAM.ToString _
                                                    , E_NEW.EDM_TPIC.ToString _
                                                    , E_NEW.USR_ID.ToString}
                            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.EdmMainMgt", "SaveDocument", params)
                        Catch ex As Exception
                            Throw New Exception(ex.Message)
                        End Try

                        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

                        If dr("TrxCode") <> "Y" Then
                            Throw New Exception(dr("TrxMsg"))
                        End If


                        Call SET_TIF_VIEW(ImgEdit1, E_NEW.RCVD_PATH, E_NEW.RCVD_FILENAME, PAGE, btnPages, Zooms, ImgThumbnail1)
                    Else
                        If Trim(sErrorFile) <> "" Then sErrorFile = sErrorFile & vbCrLf
                        sErrorFile = sErrorFile & "[이미지등록]" & tempFile.Name 'sTEMP_FAXNAME
                    End If

                Case ".PDF", ".TXT", ".DOC", ".DOCX", ".XLS", ".XLSX", ".PPT", ".PPTX", ".HTM", ".HTML", ".JPG", ".GIF", ".BMP", ".PNG", ".HWP" ', ".GUL"

                    'If SetFileToImage(sTEMP_FAXPATH, sTEMP_FAXNAME, sTEMP_NETFAXNAME) = False Then
                    If SetFileToImage(tempFile.DirectoryName, tempFile.Name, sTEMP_NETFAXNAME) = False Then
                        If Trim(sErrorFile) <> "" Then sErrorFile = sErrorFile & vbCrLf
                        sErrorFile = sErrorFile & "[이미지생성]" & tempFile.Name 'sTEMP_FAXNAME
                    Else
                        sTEMP_FILENAME = GetEdmFileName(ClientSessionOfficeInfo.HqOfficeCode, "EDM")

                        'If EDMS_Ftp_Upload(GB_COMKEY, EDMS_FTP_SERVER, EDMS_FTP_USER, EDMS_FTP_PassW, EDMS_Ftp_PORT, sTEMP_FILEPATH, sTEMP_FILENAME, EdmFaxPath & "IT\", sTEMP_NETFAXNAME) = True Then
                        'If EdmUpload(sTEMP_FAXPATH & sTEMP_FAXNAME, sTEMP_FILEPATH & sTEMP_FILENAME) Then
                        'If EdmUpload(tempFile.FullName, sTEMP_FILENAME, sTEMP_FILEPATH) Then

                        Dim convertFileFullName As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\YJIT\YjImgData0", "DirName", "C:\NETFAX\IT") & "\" & My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\YJIT\YjImgData0", "ImgName", Format(Now, "yyyyMMdd") & ".TIF")
                        If EdmUpload(convertFileFullName, sTEMP_FILENAME, sTEMP_FILEPATH) Then
                            E_NEW.RCVD_DTTM = Format(Now, "yyyyMMddhhmmss")
                            E_NEW.RCVD_FILENAME = sTEMP_FILENAME
                            E_NEW.RCVD_PATH = sTEMP_FILEPATH
                            E_NEW.RCVD_FAXNO = EDM_TEAM.SelectedValue
                            E_NEW.RCVD_SENDER = ClientSessionInfo.UserID
                            E_NEW.STATUS = "1" '대기문서
                            E_NEW.EDM_NAME = tempFile.Name 'sTEMP_FAXNAME
                            E_NEW.EDM_CLS = ""
                            E_NEW.EDM_TYP = ""
                            E_NEW.EDM_NO = ""
                            E_NEW.EDM_SEQ = ""
                            E_NEW.EDM_RMK = ""
                            E_NEW.EDM_TEAM = EDM_TEAM.SelectedText
                            E_NEW.EDM_TPIC = EDM_TPIC.SelectedValue
                            E_NEW.USR_ID = ClientSessionInfo.UserID

                            Dim ds As DataSet
                            Dim dr As DataRow

                            Try
                                Dim params() As Object = {E_NEW.RCVD_DTTM.ToString _
                                                        , E_NEW.RCVD_FILENAME.ToString _
                                                        , E_NEW.RCVD_PATH.ToString _
                                                        , E_NEW.RCVD_FAXNO.ToString _
                                                        , E_NEW.RCVD_SENDER.ToString _
                                                        , E_NEW.STATUS.ToString _
                                                        , E_NEW.EDM_NAME.ToString _
                                                        , E_NEW.EDM_CLS.ToString _
                                                        , E_NEW.EDM_TYP.ToString _
                                                        , E_NEW.EDM_NO.ToString _
                                                        , E_NEW.EDM_SEQ.ToString _
                                                        , E_NEW.EDM_RMK.ToString _
                                                        , E_NEW.EDM_TEAM.ToString _
                                                        , E_NEW.EDM_TPIC.ToString _
                                                        , E_NEW.USR_ID.ToString}
                                ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.EdmMainMgt", "SaveDocument", params)
                            Catch ex As Exception
                                Throw New Exception(ex.Message)
                            End Try

                            dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

                            If dr("TrxCode") <> "Y" Then
                                Throw New Exception(dr("TrxMsg"))
                            End If


                            Call SET_TIF_VIEW(ImgEdit1, E_NEW.RCVD_PATH, E_NEW.RCVD_FILENAME, PAGE, btnPages, Zooms, ImgThumbnail1)
                        Else
                            If Trim(sErrorFile) <> "" Then sErrorFile = sErrorFile & vbCrLf
                            sErrorFile = sErrorFile & "[이미지등록]" & tempFile.Name 'sTEMP_FAXNAME
                        End If
                    End If

                Case Else
                    MsgBox("인쇄파일이 아닙니다. 작업이 취소되었습니다.", vbInformation)
                    CMD_VSG_UPLOAD.Enabled = True
                    Exit Sub
            End Select
        Next

        If Trim(sErrorFile) <> "" Then
            MsgBoxLocalized(sErrorFile & vbCrLf & vbCrLf & "처리시 오류가 발생했습니다. 재등록시도하시기 바랍니다.")
        End If


        Call SearchRefreshData()


        Exit Sub

    End Sub


    Private Sub btnForntBack0_Click(sender As System.Object, e As System.EventArgs) Handles btnForntBack0.Click
        Call SET_TIF_FRONT_BACK(ImgEdit1, "FRONT", PAGE)
    End Sub

    Private Sub btnForntBack1_Click(sender As System.Object, e As System.EventArgs) Handles btnForntBack1.Click
        Call SET_TIF_FRONT_BACK(ImgEdit1, "BACK", PAGE)
    End Sub

    Private Sub btnWidthHeightFit0_Click(sender As System.Object, e As System.EventArgs) Handles btnWidthHeightFit0.Click
        Call SET_TIF_WIDTH_HEIGHT_FIT(ImgEdit1, "WIDTH", Zooms)
    End Sub

    Private Sub btnWidthHeightFit1_Click(sender As System.Object, e As System.EventArgs) Handles btnWidthHeightFit1.Click
        Call SET_TIF_WIDTH_HEIGHT_FIT(ImgEdit1, "HEIGHT", Zooms)
    End Sub

    Private Sub btnWidthHeightFit2_Click(sender As System.Object, e As System.EventArgs) Handles btnWidthHeightFit2.Click
        Call SET_TIF_WIDTH_HEIGHT_FIT(ImgEdit1, "WIDTH_HEIGHT", Zooms)
    End Sub

    Private Sub btnLeftRightRotate0_Click(sender As System.Object, e As System.EventArgs) Handles btnLeftRightRotate0.Click
        Try
            Dim fFILEPATH As String = String.Empty

            'ROTATE 후에 서버에 적용하기 위해서 서버 경로 체크
            If VSG_STANDBY.GetFocusedRowCellValue("RCVD_FILENAME").ToString.ToUpper.Trim = Trim(UCase(Mid(ImgEdit1.Image, InStrRev(ImgEdit1.Image, "\") + 1))) Then
                fFILEPATH = VSG_STANDBY.GetFocusedRowCellValue("RCVD_PATH").ToString.ToUpper.Trim
            ElseIf VSG_EDMDOC.GetFocusedRowCellValue("FILENAME").ToString.ToUpper.Trim = Trim(UCase(Mid(ImgEdit1.Image, InStrRev(ImgEdit1.Image, "\") + 1))) Then
                fFILEPATH = VSG_EDMDOC.GetFocusedRowCellValue("FILEPATH").ToString.ToUpper.Trim
            End If
            '=================================================


            If String.IsNullOrEmpty(fFILEPATH) Then
                MsgBox("No image Selected.")
                Exit Sub
            End If

            Call SET_TIF_LEFT_RIGHT_ROTATE(ImgEdit1, "LEFT", fFILEPATH)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnLeftRightRotate1_Click(sender As System.Object, e As System.EventArgs) Handles btnLeftRightRotate1.Click
        Try
            Dim fFILEPATH As String = String.Empty

            'ROTATE 후에 서버에 적용하기 위해서 서버 경로 체크
            If VSG_STANDBY.GetFocusedRowCellValue("RCVD_FILENAME").ToString.ToUpper.Trim = Trim(UCase(Mid(ImgEdit1.Image, InStrRev(ImgEdit1.Image, "\") + 1))) Then
                fFILEPATH = VSG_STANDBY.GetFocusedRowCellValue("RCVD_PATH").ToString.ToUpper.Trim
            ElseIf VSG_EDMDOC.GetFocusedRowCellValue("FILENAME").ToString.ToUpper.Trim = Trim(UCase(Mid(ImgEdit1.Image, InStrRev(ImgEdit1.Image, "\") + 1))) Then
                fFILEPATH = VSG_EDMDOC.GetFocusedRowCellValue("FILEPATH").ToString.ToUpper.Trim
            End If
            '=================================================


            If String.IsNullOrEmpty(fFILEPATH) Then
                MsgBox("No image Selected.")
                Exit Sub
            End If

            Call SET_TIF_LEFT_RIGHT_ROTATE(ImgEdit1, "RIGHT", fFILEPATH)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub PAGE_EditValueChanged(oldValue As Object, newValue As Object) Handles PAGE.EditValueChanged
        Call SET_TIF_FRONT_BACK(ImgEdit1, "PAGE", PAGE)
    End Sub
    Private Sub PAGE_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles PAGE.KeyDown
        'If e.Modifiers = Keys.Control Then
        If e.KeyCode = Keys.Enter Then
            Call SET_TIF_FRONT_BACK(ImgEdit1, "PAGE", PAGE)
        End If
        'End If
    End Sub

    Private Sub Zooms_EditValueChanged(oldValue As Object, newValue As Object) Handles Zooms.EditValueChanged
        Call SET_TIF_ZOOMS(ImgEdit1, Zooms.Text, Zooms)
    End Sub
    Private Sub Zooms_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Zooms.KeyDown
        'If e.Modifiers = Keys.Control Then
        If e.KeyCode = Keys.Enter Then
            Call SET_TIF_ZOOMS(ImgEdit1, Zooms.Text, Zooms)
        End If
        'End If
    End Sub

    Private Sub btnZoomInOut0_Click(sender As System.Object, e As System.EventArgs) Handles btnZoomInOut0.Click
        Call SET_TIF_ZOOM_IN_OUT(ImgEdit1, "OUT", Zooms)
    End Sub

    Private Sub btnZoomInOut1_Click(sender As System.Object, e As System.EventArgs) Handles btnZoomInOut1.Click
        Call SET_TIF_ZOOM_IN_OUT(ImgEdit1, "IN", Zooms)
    End Sub

    Private Sub btnTifPcSave_Click(sender As System.Object, e As System.EventArgs) Handles btnTifPcSave.Click
        Call SET_TIF_PC_SAVE(ImgEdit1)
    End Sub

    Private Sub btnTifPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnTifPrint.Click
        Call SET_TIF_PRINT(ImgEdit1)
    End Sub

    Private Sub btnTifEmail_Click(sender As System.Object, e As System.EventArgs) Handles btnTifEmail.Click
        Try
            Dim sCUSTCD As String = String.Empty
            Dim sCUST_ATTNCD As String = String.Empty
            Dim sTITLE As String = String.Empty

            '20101119 김성은    팩스번호 검색 조건 추가
            If VSG_EDMDOC.RowCount > 0 AndAlso VSG_EDMDOC.GetFocusedRowCellValue("FILENAME").ToString.ToUpper.Trim = Mid(ImgEdit1.Image, InStrRev(ImgEdit1.Image, "\") + 1).ToString.ToUpper.Trim Then
                MsgBox("확인 - 조회 쿼리 확인해야함")
                'With VSG_BLNO
                '    If .GetFocusedRowCellValue("BLGB").ToString = "MBL" Then
                '        Code_Res = Code_Find("SE", "HHAGENT, HHAGENTATTN", "OC_HBLH", "HHCSNO IN (SELECT MHNO FROM OC_MBLH WHERE MHNO = '" & .TextMatrix(.Row, .ColIndex("DOCNO")) & "' GROUP BY MHNO)", 2)
                '    Else
                '        Code_Res = Code_Find("SE", "HHACTCUST, HHACTATTN", "OC_HBLH", "HHBLNO = '" & .TextMatrix(.Row, .ColIndex("BLNO")) & "'", 2)
                '    End If
                'End With

                'If Code_Res = True Then
                '    sCUSTCD = Trim(GB_RTN(0))
                '    sCUST_ATTNCD = Trim(GB_RTN(1))
                sTITLE = VSG_EDMDOC.GetFocusedRowCellValue("EDOCNM").ToString
                'End If
            ElseIf VSG_STANDBY.RowCount > 0 AndAlso VSG_STANDBY.GetFocusedRowCellValue("RCVD_FILENAME").ToString.ToUpper.Trim = Mid(ImgEdit1.Image, InStrRev(ImgEdit1.Image, "\") + 1).ToString.ToUpper.Trim Then
                sTITLE = VSG_STANDBY.GetFocusedRowCellValue("EDM_RMK").ToString
            End If
            '==========================================


            Call SET_TIF_EMAIL(ImgEdit1, sTITLE, sCUSTCD, sCUST_ATTNCD)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnTifEdit0_Click(sender As System.Object, e As System.EventArgs) Handles btnTifEdit0.Click
        Try
            '0 No Tool
            '1 Selection
            '2 Freehand Line
            '3 Highlighter
            '4 Straight Line
            '5 Hollow Rectangle
            '6 Filled Rectangle
            '7 Text
            '8 Attach -A - Note
            '9 Text From File
            '10 Text Stamp

            ImgEdit1.MousePointer = 0

            '선택기능
            ImgEdit1.SelectTool(1)
            ImgEdit1.MousePointer = 23

            'If e.Index = 0 Then
            '    '선택기능
            '    ImgEdit1.SelectTool(1)
            '    ImgEdit1.MousePointer = 23
            'ElseIf Index = 1 Then
            '    '글자입력
            '    ImgEdit1.SelectTool(7)
            'ElseIf Index = 2 Then
            '    ImgEdit1.SelectTool(2)
            'ElseIf Index = 3 Then
            '    ImgEdit1.DeleteSelectedAnnotations()
            'ElseIf Index = 4 Then
            '    '편집도구창
            '    If btnTifEdit(Index).ButtonType = Normal Then
            '        ImgEdit1.ShowAnnotationToolPalette()
            '        btnTifEdit(Index).ButtonType = DropDown
            '    Else
            '        ImgEdit1.HideAnnotationToolPalette()
            '        btnTifEdit(Index).ButtonType = Normal
            '    End If
            'ElseIf Index = 5 Then 'SAVE
            '    'If fIMGEDIT.ImageModified Then   '수정여부
            '    RES = MsgBox("이미지를 서버에 적용하시겠습니까?", vbYesNo, MSG20)
            '    If RES = vbYes Then
            '        ImgEdit1.Save()
            '        Call EDMS_Ftp_Upload(GB_COMKEY, EDMS_FTP_SERVER, EDMS_FTP_USER, EDMS_FTP_PassW, EDMS_Ftp_PORT, ImgEdit1.Tag, Mid(ImgEdit1.Image, InStrRev(ImgEdit1.Image, "\") + 1), FileDownPath, Mid(ImgEdit1.Image, InStrRev(ImgEdit1.Image, "\") + 1))
            '    End If
            '    'End If
            'ElseIf Index = 6 Then 'THUMBNAIL
            '    If Frame_ImgEdit.Left = ImgEdit1.Left Then
            '        ImgEdit1.Left = Frame_ImgEdit.Left + Frame_ImgEdit.Width '+ 5955
            '        ImgEdit1.Width = ImgEdit1.Width - Frame_ImgEdit.Width '- 10
            '    Else
            '        ImgEdit1.Left = Frame_ImgEdit.Left
            '        ImgEdit1.Width = ImgEdit1.Width + Frame_ImgEdit.Width '+ 10
            '    End If
            '    ImgEdit1.ZOrder()

            'End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnTifEdit1_Click(sender As System.Object, e As System.EventArgs) Handles btnTifEdit1.Click
        ImgEdit1.MousePointer = 0
        '글자입력
        ImgEdit1.SelectTool(7)
    End Sub

    Private Sub btnTifEdit2_Click(sender As System.Object, e As System.EventArgs) Handles btnTifEdit2.Click
        ImgEdit1.SelectTool(2)
    End Sub

    Private Sub btnTifEdit3_Click(sender As System.Object, e As System.EventArgs) Handles btnTifEdit3.Click
        ImgEdit1.DeleteSelectedAnnotations()
    End Sub

    Private Sub btnTifEdit4_Click(sender As System.Object, e As System.EventArgs) Handles btnTifEdit4.Click
        '편집도구창
        If btnTifEdit4.Tag = "HideAnnotationToolPalette" Then
            ImgEdit1.ShowAnnotationToolPalette()
        Else
            ImgEdit1.HideAnnotationToolPalette()
        End If
    End Sub

    Private Sub btnTifEdit5_Click(sender As System.Object, e As System.EventArgs) Handles btnTifEdit5.Click
        If MsgBox("이미지를 서버에 적용하시겠습니까?", vbYesNo, EdmErrMsg.MSG20) = vbYes Then
            ImgEdit1.Save()
            'Call EDMS_Ftp_Upload(GB_COMKEY, EDMS_FTP_SERVER, EDMS_FTP_USER, EDMS_FTP_PassW, EDMS_Ftp_PORT, ImgEdit1.Tag, Mid(ImgEdit1.Image, InStrRev(ImgEdit1.Image, "\") + 1), FileDownPath, Mid(ImgEdit1.Image, InStrRev(ImgEdit1.Image, "\") + 1))
            If Not EdmUpload(EdmPath.Download & Mid(ImgEdit1.Image, InStrRev(ImgEdit1.Image, "\") + 1), Mid(ImgEdit1.Image, InStrRev(ImgEdit1.Image, "\") + 1), ImgEdit1.Tag) Then
                Throw New Exception("서버전송시 오류가 발생했습니다. ")
            End If
        End If
    End Sub

    Private Sub btnTifEdit6_Click(sender As System.Object, e As System.EventArgs) Handles btnTifEdit6.Click
        If SplitCtrlImgEdit.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2 Then
            SplitCtrlImgEdit.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
        Else
            SplitCtrlImgEdit.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        End If
    End Sub

    Private Sub ImgEdit1_DblClick(sender As System.Object, e As System.EventArgs) Handles ImgEdit1.DblClick
        If ImgEdit1.Image = "" Then
            Exit Sub
        End If

        'Start Teamviewer quicksuport instance
        Dim process As System.Diagnostics.Process = New System.Diagnostics.Process()
        process.StartInfo.FileName = ImgEdit1.Image
        process.StartInfo.Verb = "Open"
        process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
        process.Start()
    End Sub


    Dim iMouseDown_X As Integer
    Dim iMouseDown_Y As Integer
    Dim bMarkSelect As Boolean
    Dim bMarkMove As Boolean
    Private Sub ImgEdit1_MarkMove(sender As Object, e As AxImgeditLibCtl._DImgEditEvents_MarkMoveEvent) Handles ImgEdit1.MarkMove
        '완료후 MarkSelect Event 처리됨
        bMarkMove = True
    End Sub

    Private Sub ImgEdit1_MarkSelect(sender As Object, e As AxImgeditLibCtl._DImgEditEvents_MarkSelectEvent) Handles ImgEdit1.MarkSelect
        If bMarkMove = False Then
            bMarkSelect = True
        Else
            bMarkSelect = False
        End If
    End Sub

    Private Sub ImgEdit1_MouseDownEvent(sender As Object, e As AxImgeditLibCtl._DImgEditEvents_MouseDownEvent) Handles ImgEdit1.MouseDownEvent
        iMouseDown_X = e.x
        iMouseDown_Y = e.y
    End Sub

    Private Sub ImgEdit1_MouseMoveEvent(sender As Object, e As AxImgeditLibCtl._DImgEditEvents_MouseMoveEvent) Handles ImgEdit1.MouseMoveEvent
        If bMarkMove = False And bMarkSelect = False Then
        ElseIf bMarkMove = True And bMarkSelect = False Then
        Else
            Exit Sub
        End If

        If e.button = 1 And ImgEdit1.MousePointer = 23 Then
            If e.shift = 2 Then 'CNTL + 왼쪽마우스
                'DOWN에서 처리
            Else
                'ImgEdit1.SelectionRectangle = False
                '0 .Down
                '1 .Up
                '2 .Right
                '3 .Left

                ''마우스로 이미지 이동 시키기 위해서 추가
                'ImgEdit1.SelectionRectangle = False
                'ImgEdit1.ZoomToSelection

                'If bMarkMove = True Then
                '편집된 이미지가 선택되지 않음
                bMarkMove = False
                'Else
                '    ImgEdit1.DrawSelectionRect 0, 0, 0, 0
                'End If

                '상하좌우를 정밀하게 이동할수 없어서 일정범위를 지정하여 상하좌우를 컨트롤하도록 적용
                If e.y > iMouseDown_Y + 200 Then
                    ImgEdit1.ScrollImage(1, 100)
                    iMouseDown_Y = e.y
                ElseIf e.y < iMouseDown_Y - 200 Then
                    ImgEdit1.ScrollImage(0, 100)
                    iMouseDown_Y = e.y
                End If

                If e.x > iMouseDown_X + 200 Then
                    ImgEdit1.ScrollImage(3, 100)
                    iMouseDown_X = e.x
                ElseIf e.x < iMouseDown_X - 200 Then
                    ImgEdit1.ScrollImage(2, 100)
                    iMouseDown_X = e.x
                End If
            End If
        End If
    End Sub


    Private Sub ImgThumbnail1_MouseUpEvent(sender As System.Object, e As AxThumbnailLibCtl._DImgThumbnailEvents_MouseUpEvent) Handles ImgThumbnail1.MouseUpEvent
        If e.thumbNumber < 1 Then Exit Sub
        If e.button = 2 Then
            If ImgThumbnail1.get_ThumbSelected(e.thumbNumber) = True Then
                ImgThumbnail1.set_ThumbSelected(e.thumbNumber, False)
            Else
                ImgThumbnail1.set_ThumbSelected(e.thumbNumber, True)
            End If
        Else
            ImgThumbnail1.DeselectAllThumbs()
            ImgThumbnail1.set_ThumbSelected(e.thumbNumber, True)
        End If

        ImgEdit1.Page = e.thumbNumber
        ImgEdit1.Refresh()
        ImgEdit1.Display()
        PAGE.Text = e.thumbNumber
    End Sub

    Private Sub btnThumbnailEdit0_Click(sender As System.Object, e As System.EventArgs) Handles btnThumbnailEdit0.Click

        Dim fFILEPATH As String

        'ROTATE 후에 서버에 적용하기 위해서 서버 경로 체크
        If Trim(UCase(VSG_STANDBY.GetFocusedRowCellValue("RCVD_FILENAME"))) = Trim(UCase(Mid(ImgEdit1.Image, InStrRev(ImgEdit1.Image, "\") + 1))) Then
            fFILEPATH = Trim(UCase(VSG_STANDBY.GetFocusedRowCellValue("RCVD_PATH")))
        ElseIf Trim(UCase(VSG_EDMDOC.GetFocusedRowCellValue("FILENAME"))) = Trim(UCase(Mid(ImgEdit1.Image, InStrRev(ImgEdit1.Image, "\") + 1))) Then
            fFILEPATH = Trim(UCase(VSG_EDMDOC.GetFocusedRowCellValue("FILEPATH")))
        End If
        '=================================================


        'Select Case Index
        '    Case 3
        '        Call SET_TIF_INSERT_DELETE_SPLIT_CHANGE(ImgThumbnail1, ImgEdit1, "DELETE", fFILEPATH, PAGE, btnPages, Zooms)
        '    Case 2
        '        Call SET_TIF_INSERT_DELETE_SPLIT_CHANGE(ImgThumbnail1, ImgEdit1, "INSERT", fFILEPATH, PAGE, btnPages, Zooms)
        '    Case 1
        '        Call SET_TIF_INSERT_DELETE_SPLIT_CHANGE(ImgThumbnail1, ImgEdit1, "CHANGE", fFILEPATH, PAGE, btnPages, Zooms)
        '    Case 0
        Call SET_TIF_INSERT_DELETE_SPLIT_CHANGE(ImgThumbnail1, ImgEdit1, "SPLIT", fFILEPATH, PAGE, btnPages, Zooms)
        '    Case Else
        '        MsgBox("등록된 작업이 없습니다. 작업이 취소되었습니다.", vbInformation, MSG20)
        'End Select

    End Sub

    Private Sub btnThumbnailEdit1_Click(sender As System.Object, e As System.EventArgs) Handles btnThumbnailEdit1.Click

        Dim fFILEPATH As String

        'ROTATE 후에 서버에 적용하기 위해서 서버 경로 체크
        If Trim(UCase(VSG_STANDBY.GetFocusedRowCellValue("RCVD_FILENAME"))) = Trim(UCase(Mid(ImgEdit1.Image, InStrRev(ImgEdit1.Image, "\") + 1))) Then
            fFILEPATH = Trim(UCase(VSG_STANDBY.GetFocusedRowCellValue("RCVD_PATH")))
        ElseIf Trim(UCase(VSG_EDMDOC.GetFocusedRowCellValue("FILENAME"))) = Trim(UCase(Mid(ImgEdit1.Image, InStrRev(ImgEdit1.Image, "\") + 1))) Then
            fFILEPATH = Trim(UCase(VSG_EDMDOC.GetFocusedRowCellValue("FILEPATH")))
        End If
        '=================================================


        'Select Case Index
        '    Case 3
        '        Call SET_TIF_INSERT_DELETE_SPLIT_CHANGE(ImgThumbnail1, ImgEdit1, "DELETE", fFILEPATH, PAGE, btnPages, Zooms)
        '    Case 2
        '        Call SET_TIF_INSERT_DELETE_SPLIT_CHANGE(ImgThumbnail1, ImgEdit1, "INSERT", fFILEPATH, PAGE, btnPages, Zooms)
        '    Case 1
        Call SET_TIF_INSERT_DELETE_SPLIT_CHANGE(ImgThumbnail1, ImgEdit1, "CHANGE", fFILEPATH, PAGE, btnPages, Zooms)
        '    Case 0
        'Call SET_TIF_INSERT_DELETE_SPLIT_CHANGE(ImgThumbnail1, ImgEdit1, "SPLIT", fFILEPATH, PAGE, btnPages, Zooms)
        '    Case Else
        '        MsgBox("등록된 작업이 없습니다. 작업이 취소되었습니다.", vbInformation, MSG20)
        'End Select

    End Sub

    Private Sub btnThumbnailEdit2_Click(sender As System.Object, e As System.EventArgs) Handles btnThumbnailEdit2.Click

        Dim fFILEPATH As String

        'ROTATE 후에 서버에 적용하기 위해서 서버 경로 체크
        If Trim(UCase(VSG_STANDBY.GetFocusedRowCellValue("RCVD_FILENAME"))) = Trim(UCase(Mid(ImgEdit1.Image, InStrRev(ImgEdit1.Image, "\") + 1))) Then
            fFILEPATH = Trim(UCase(VSG_STANDBY.GetFocusedRowCellValue("RCVD_PATH")))
        ElseIf Trim(UCase(VSG_EDMDOC.GetFocusedRowCellValue("FILENAME"))) = Trim(UCase(Mid(ImgEdit1.Image, InStrRev(ImgEdit1.Image, "\") + 1))) Then
            fFILEPATH = Trim(UCase(VSG_EDMDOC.GetFocusedRowCellValue("FILEPATH")))
        End If
        '=================================================


        'Select Case Index
        '    Case 3
        '        Call SET_TIF_INSERT_DELETE_SPLIT_CHANGE(ImgThumbnail1, ImgEdit1, "DELETE", fFILEPATH, PAGE, btnPages, Zooms)
        '    Case 2
        Call SET_TIF_INSERT_DELETE_SPLIT_CHANGE(ImgThumbnail1, ImgEdit1, "INSERT", fFILEPATH, PAGE, btnPages, Zooms)
        '    Case 1
        '        Call SET_TIF_INSERT_DELETE_SPLIT_CHANGE(ImgThumbnail1, ImgEdit1, "CHANGE", fFILEPATH, PAGE, btnPages, Zooms)
        '    Case 0
        'Call SET_TIF_INSERT_DELETE_SPLIT_CHANGE(ImgThumbnail1, ImgEdit1, "SPLIT", fFILEPATH, PAGE, btnPages, Zooms)
        '    Case Else
        '        MsgBox("등록된 작업이 없습니다. 작업이 취소되었습니다.", vbInformation, MSG20)
        'End Select

    End Sub

    Private Sub btnThumbnailEdit3_Click(sender As System.Object, e As System.EventArgs) Handles btnThumbnailEdit3.Click

        Dim fFILEPATH As String

        'ROTATE 후에 서버에 적용하기 위해서 서버 경로 체크
        If Trim(UCase(VSG_STANDBY.GetFocusedRowCellValue("RCVD_FILENAME"))) = Trim(UCase(Mid(ImgEdit1.Image, InStrRev(ImgEdit1.Image, "\") + 1))) Then
            fFILEPATH = Trim(UCase(VSG_STANDBY.GetFocusedRowCellValue("RCVD_PATH")))
        ElseIf Trim(UCase(VSG_EDMDOC.GetFocusedRowCellValue("FILENAME"))) = Trim(UCase(Mid(ImgEdit1.Image, InStrRev(ImgEdit1.Image, "\") + 1))) Then
            fFILEPATH = Trim(UCase(VSG_EDMDOC.GetFocusedRowCellValue("FILEPATH")))
        End If
        '=================================================


        'Select Case Index
        '    Case 3
        Call SET_TIF_INSERT_DELETE_SPLIT_CHANGE(ImgThumbnail1, ImgEdit1, "DELETE", fFILEPATH, PAGE, btnPages, Zooms)
        '    Case 2
        '        Call SET_TIF_INSERT_DELETE_SPLIT_CHANGE(ImgThumbnail1, ImgEdit1, "INSERT", fFILEPATH, PAGE, btnPages, Zooms)
        '    Case 1
        '        Call SET_TIF_INSERT_DELETE_SPLIT_CHANGE(ImgThumbnail1, ImgEdit1, "CHANGE", fFILEPATH, PAGE, btnPages, Zooms)
        '    Case 0
        'Call SET_TIF_INSERT_DELETE_SPLIT_CHANGE(ImgThumbnail1, ImgEdit1, "SPLIT", fFILEPATH, PAGE, btnPages, Zooms)
        '    Case Else
        '        MsgBox("등록된 작업이 없습니다. 작업이 취소되었습니다.", vbInformation, MSG20)
        'End Select

    End Sub

End Class






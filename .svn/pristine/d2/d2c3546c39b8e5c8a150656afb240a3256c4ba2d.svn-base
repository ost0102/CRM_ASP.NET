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

Public Class CrmAsMgt_v3
    'Dim CustomTypeCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    'Dim GV_Flag As Boolean = False
    'Private tempRoot As String = Application.StartupPath & "\TMP_OUTPUT"
    'Protected filePath As String = String.Empty
    Private HotTrackRowValue As Integer = DevExpress.XtraGrid.GridControl.InvalidRowHandle
    Dim second As Integer = 0
    Dim MaxInterval As Integer = 0
    Dim Gv1PopUp As New PopupBase
#Region "=================Data logic actions==========="
    Private Function GetConvertToDataSet() As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
            YJSql.SqlBox("WG1", "CrmAsMgt_v2@Search", True)
            YJSql.Params("FM_YMD", drMAIN("FM_YMD").ToString.Trim, True)
            YJSql.Params("TO_YMD", drMAIN("TO_YMD").ToString.Trim, True)
            YJSql.Params("S_PROC_TYPE", S_PROC_TYPE.EditValue.ToString.Replace(";", "','").Replace(" ", ""), True)
            YJSql.Params("S_SVC_CD", S_SVC_CD.EditValue.ToString.Replace(";", "','").Replace(" ", ""), True)
            'YJSql.Params("S_MNGT_NO", drMAIN("S_MNGT_NO").ToString.Trim, True)
            YJSql.Params("SEARCH_KEY", drMAIN("SEARCH_KEY").ToString.Trim, True)
            YJSql.Params("WORK_USR", drMAIN("S_WORK_USR").ToString.Trim, True)

            If drMAIN("S_PRIORITY").ToString.Trim <> "" Then
                If drMAIN("S_PRIORITY").ToString.Trim = "Y" Then
                    YJSql.Blocks("PRIORITY", drMAIN("S_PRIORITY").ToString.Trim, True)
                End If
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function


    Private Sub InitData()

        Dim dtCol As DataTable = New DataTable
        dtCol.Columns.Add(New DataColumn("CODE"))
        dtCol.Columns.Add(New DataColumn("NAME"))

        dtCol.Rows.Add()
        dtCol.Rows(0)("CODE") = "0"
        dtCol.Rows(0)("NAME") = "미확인"

        dtCol.Rows.Add()
        dtCol.Rows(1)("CODE") = "1"
        dtCol.Rows(1)("NAME") = "완료"

        dtCol.Rows.Add()
        dtCol.Rows(2)("CODE") = "2"
        dtCol.Rows(2)("NAME") = "즉시처리"

        dtCol.Rows.Add()
        dtCol.Rows(3)("CODE") = "3"
        dtCol.Rows(3)("NAME") = "재발신예정"

        dtCol.Rows.Add()
        dtCol.Rows(4)("CODE") = "4"
        dtCol.Rows(4)("NAME") = "재발신"

        dtCol.Rows.Add()
        dtCol.Rows(5)("CODE") = "5"
        dtCol.Rows(5)("NAME") = "수정요청"

        dtCol.Rows.Add()
        dtCol.Rows(6)("CODE") = "6"
        dtCol.Rows(6)("NAME") = "추가요청"

        dtCol.Rows.Add()
        dtCol.Rows(7)("CODE") = "7"
        dtCol.Rows(7)("NAME") = "처리중"

        dtCol.Rows.Add()
        dtCol.Rows(8)("CODE") = "8"
        dtCol.Rows(8)("NAME") = "보류"

        dtCol.TableName = "ProcType"

        Dim bindingSourceProduct = New BindingSource()
        bindingSourceProduct.DataSource = dtCol
        S_PROC_TYPE.Properties.DataSource = bindingSourceProduct.DataSource
        S_PROC_TYPE.Properties.ValueMember = "CODE"
        S_PROC_TYPE.Properties.DisplayMember = "NAME"
        S_PROC_TYPE.Properties.NullText = String.Empty
        S_PROC_TYPE.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
        S_PROC_TYPE.Properties.SeparatorChar = ";"


        dtCol = New DataTable
        dtCol.Columns.Add(New DataColumn("CODE"))
        dtCol.Columns.Add(New DataColumn("NAME"))

        dtCol.Rows.Add()
        dtCol.Rows(0)("CODE") = "E"
        dtCol.Rows(0)("NAME") = "ELVIS"

        dtCol.Rows.Add()
        dtCol.Rows(1)("CODE") = "O"
        dtCol.Rows(1)("NAME") = "ELVIS(Etc)"

        dtCol.Rows.Add()
        dtCol.Rows(2)("CODE") = "V"
        dtCol.Rows(2)("NAME") = "일반"

        dtCol.Rows.Add()
        dtCol.Rows(3)("CODE") = "W"
        dtCol.Rows(3)("NAME") = "WMS"

        dtCol.Rows.Add()
        dtCol.Rows(4)("CODE") = "L"
        dtCol.Rows(4)("NAME") = "운송"

        dtCol.Rows.Add()
        dtCol.Rows(5)("CODE") = "H"
        dtCol.Rows(5)("NAME") = "인사급여"

        dtCol.Rows.Add()
        dtCol.Rows(6)("CODE") = "A"
        dtCol.Rows(6)("NAME") = "대리점"

        dtCol.Rows.Add()
        dtCol.Rows(7)("CODE") = "B"
        dtCol.Rows(7)("NAME") = "보세"

        dtCol.Rows.Add()
        dtCol.Rows(8)("CODE") = "C"
        dtCol.Rows(8)("NAME") = "쿠리어"

        dtCol.Rows.Add()
        dtCol.Rows(9)("CODE") = "M"
        dtCol.Rows(9)("NAME") = "적하목록"

        dtCol.Rows.Add()
        dtCol.Rows(10)("CODE") = "T"
        dtCol.Rows(10)("NAME") = "T/S"

        dtCol.Rows.Add()
        dtCol.Rows(11)("CODE") = "Z"
        dtCol.Rows(11)("NAME") = "기타"

        bindingSourceProduct = New BindingSource()
        bindingSourceProduct.DataSource = dtCol
        S_SVC_CD.Properties.DataSource = bindingSourceProduct.DataSource
        S_SVC_CD.Properties.ValueMember = "CODE"
        S_SVC_CD.Properties.DisplayMember = "NAME"
        S_SVC_CD.Properties.NullText = String.Empty
        S_SVC_CD.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
        S_SVC_CD.Properties.SeparatorChar = ";"


        Timer1.Interval = 1000
        Timer1.Stop()

    End Sub
    Private Property HotTrackRow() As Integer
        Get
            Return HotTrackRowValue
        End Get

        Set(ByVal Value As Integer)
            If HotTrackRowValue <> Value Then
                Dim PrevHotTrackRow As Integer
                PrevHotTrackRow = HotTrackRowValue
                HotTrackRowValue = Value
                GV1.RefreshRow(PrevHotTrackRow)
                GV1.RefreshRow(HotTrackRowValue)
            End If
        End Set

    End Property


    Private Sub DeleteData()
        Dim ds As DataSet
        Dim dr As DataRow
        Dim insFlag As String = ""

        Try
            If MsgBoxLocalized("Do you want to delete?", MessageBoxButtons.YesNo, "Delete", MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.No Then Exit Sub
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgt_v2", "Delete", Me.ConvertToDataset)

        Catch ex As Exception
            MsgBoxLocalized(ex.Message, MessageBoxButtons.OK, "Delete", MessageBoxIcon.Error)
            Exit Sub
        End Try

        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Delete", MessageBoxIcon.Error)
            Exit Sub
        End If
        Me.BindToDataset(ds, "Data")
        Me.DataState = UI.DataStates.Retrieved


    End Sub

    Public Sub PopUpOnBeforeClick(ByVal dr As DataRow)
        Dim Key As String = dr("KEY")
        Dim Sender As String = ""
        If Not dr("Sender") Is System.DBNull.Value Then Sender = dr("Sender")

        Try
            Select Case dr("Action")
                Case Action.Addrow, Action.EventKey
                    Select Case Key
                        Case "WG1_ADDROW"
                            If POPUP_INPUT.Checked = True Then
                                dr("Cancel") = True
                                Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
                                Dim fTarget As Object = Nothing
                                frmMain = Me.MdiParent
                                'If NEW_POPUP_INPUT.YesNo = "Y" Then
                                '    fTarget = frmMain.NavigateTo("CrmAsInput_v1", NavigatedWindowModes.Dialog, False)
                                '    If Not IsNothing(fTarget) Then
                                '        fTarget.frmMain = frmMain
                                '        fTarget.NewData()
                                '        fTarget.ShowDialog()
                                '    End If
                                'Else
                                '    fTarget = frmMain.NavigateTo("CrmAsInput", NavigatedWindowModes.Dialog, False)
                                '    If Not IsNothing(fTarget) Then
                                '        fTarget.frmMain = frmMain
                                '        fTarget.NewData()
                                '        fTarget.ShowDialog()
                                '    End If
                                'End If
                            End If

                    End Select

            End Select

        Catch ex As Exception
            MsgBoxLocalized(ex.Message, MessageBoxButtons.OK, "Process failed!", MessageBoxIcon.Error)
            dr("Cancel") = True
        End Try

    End Sub

    Public Sub PopUpOnAfterClick(ByVal Dr As DataRow)
        Dim Key As String = Dr("Key")
        Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
        Dim fTarget As Object = Nothing
        Dim rowIndex As Integer = 0
        Select Case Dr("Action")
            Case Action.NavigateTo
                Select Case Key
                    Case "ComDocumentMgt"
                        fTarget = frmMain.NavigateTo(Key, NavigatedWindowModes.Dialog, False)
                        If fTarget IsNot Nothing Then
                            fTarget.S_MNGT_NO.text = GV1.GetFocusedRowCellValue("MNGT_NO").ToString
                            fTarget.SCREEN.Text = "사이트 지원 등록"
                            fTarget.DirList.Text = "CrmAsMgt_v2"
                            fTarget.SearchData()
                            fTarget.ShowDialog()
                        End If
                    Case "CrmCustomerMgt"
                        fTarget = frmMain.NavigateTo(Key)
                        If fTarget IsNot Nothing Then
                            fTarget.SEARCH_KEY.Text = GV1.GetFocusedRowCellValue("CUST_CD").ToString
                            fTarget.SearchData()
                        End If
                End Select
            Case Action.Addrow
                Select Case Key
                    Case "WG1_ADDROW"
                        GV1.SetRowCellValue(GV1.FocusedRowHandle, "REQ_YMD", DateTime.Now.ToString("yyyyMMdd"))
                        GV1.SetRowCellValue(GV1.FocusedRowHandle, "REQ_HM", DateTime.Now.ToString("yyyyMMddHHmmss").Substring(8, 4))
                        GV1.OptionsBehavior.Editable = True

                End Select
            Case Action.CheckBox
                Select Case Key
                    Case "RegPopup"
                        POPUP_INPUT.Checked = Gv1PopUp.CheckBoxValue("RegPopup")
                End Select
            Case Action.Other
                Select Case Key
                    Case "Complete"
                        GV1.SetRowCellValue(GV1.FocusedRowHandle, "PROC_TYPE", "1")
                End Select
        End Select

    End Sub

    Public Sub SearchDataOld(ByVal MngtNo As String)

        Dim ds As DataSet = Me.ConvertToDataset

        Dim params() As Object = {ds}
        ds.Tables("MAIN").Columns.Add("S_PROC_TYPE")
        ds.Tables("MAIN").Rows(0)("S_PROC_TYPE") = S_PROC_TYPE.EditValue
        ds.Tables("MAIN").Columns.Add("S_MNGT_NO")
        ds.Tables("MAIN").Rows(0)("S_MNGT_NO") = MngtNo
        ds.Tables("MAIN").Columns.Add("S_SVC_CD")
        ds.Tables("MAIN").Rows(0)("S_SVC_CD") = S_SVC_CD.EditValue

        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.CrmAsMgt_v2", "SearchOld", params, AddressOf SearchOnComplete)

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Sub SearchOnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Try
            If IsNothing(e.Result) Then
                Throw New Exception("Try Again !")
            End If

            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

            Me.ClearView(UI.AppliedRangeTypes.Except, {SEARCH_KEY, FM_YMD, TO_YMD, POPUP_INPUT, REF_TIME, S_PRIORITY, S_WORK_USR})

            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Search", MessageBoxIcon.Warning)
                Exit Sub
            End If
            Me.BindToDataset(ds, "Data")
            Me.DataState = UI.DataStates.Retrieved

            GV1.OptionsBehavior.Editable = False
            If POPUP_INPUT.Checked = True Then
                GV1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Default
                GV1.OptionsBehavior.Editable = False
            Else
                GV1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
                GV1.OptionsBehavior.Editable = True
            End If

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub

    Public Sub SearchData()
        If SearchValidate() = False Then Exit Sub

        Dim dsRet As DataSet = GetConvertToDataSet()

        dsRet = MethodCallEx(Me, "YJIT.Biz.CrmAsMgt_v2", "Search", {dsRet})
        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case drPairs("TrxCode")
            Case "Y"
                Me.ClearView(UI.AppliedRangeTypes.Except, {SEARCH_KEY, FM_YMD, TO_YMD, POPUP_INPUT, REF_TIME, S_PRIORITY, S_WORK_USR})
                Me.BindToDataset(dsRet, "Data")

                Me.DataState = UI.DataStates.Retrieved
            Case "N"
                Me.ClearView(UI.AppliedRangeTypes.Except, {SEARCH_KEY, FM_YMD, TO_YMD, POPUP_INPUT, REF_TIME, S_PRIORITY, S_WORK_USR})
                MsgBoxLocalized(drPairs("TrxMsg"))

                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(drPairs("TrxMsg"))
        End Select

        GV1.OptionsBehavior.Editable = False
        If POPUP_INPUT.Checked = True Then
            GV1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Default
            GV1.OptionsBehavior.Editable = False
        Else
            GV1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
            GV1.OptionsBehavior.Editable = True
        End If
    End Sub
    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing

        Try
            'If String.IsNullOrEmpty(S_COMN_CD.SelectedValue.ToString) Then
            '    If ErrControl Is Nothing Then ErrControl = S_COMN_CD
            '    ErrMsg &= "Please input the [Mapping Type]" & vbNewLine
            'End If


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


    Private Sub NewData()

        ClearView(UI.AppliedRangeTypes.Except, {WG1, SEARCH_KEY, S_PROC_TYPE, POPUP_INPUT, REF_TIME, S_PRIORITY, S_WORK_USR})

    End Sub

    Public Sub SaveData()

        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.YesNo) = MsgBoxResult.No Then Exit Sub


        Dim dsResult As DataSet
        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgt_v2", "Save", Me.ConvertToDataset)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow
        dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") = "Y" Then
            Call SearchData()
        Else
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub

    Public Sub GridInit()

        Dim editorCombo As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim editor As New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)


        Gv1PopUp = New PopupBase
        Gv1PopUp.ItemAdd(Action.Addrow, "WG1_ADDROW", "Add row")
        Gv1PopUp.ItemAdd(Action.DeleteRow, "WG1_DELETEROW", "Delete row")
        Gv1PopUp.ItemAdd(Action.NavigateTo, "ComDocumentMgt", "Document", True)
        Gv1PopUp.ItemAdd(Action.NavigateTo, "CrmCustomerMgt", "Customer Management")
        Gv1PopUp.ItemAdd(Action.GroupHeader, "OPTION", "설정", True)
        Gv1PopUp.ItemAdd(Action.CheckBox, "RegPopup", "Popup 등록", "OPTION")
        Gv1PopUp.ItemAdd(Action.Other, "Complete", "완료처리")
        Gv1PopUp.ItemAdd(Action.Excel, "WG1_EXCEL", "Excel Export", True)
        Gv1PopUp.PopUpInit(Me, WG1, "REQ_SVC", "CMPT_YMD")

        Dim dt As DataTable = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        AddNewRow(dt, "A", "설치업무")
        AddNewRow(dt, "B", "공통업무")
        AddNewRow(dt, "C", "ACCOUNT")
        AddNewRow(dt, "D", "AIR")
        AddNewRow(dt, "E", "OCEAN")
        AddNewRow(dt, "F", "인사급여")
        AddNewRow(dt, "G", "쿠리어")
        AddNewRow(dt, "H", "통관업무")
        AddNewRow(dt, "I", "운송업무")
        AddNewRow(dt, "J", "대리점")
        AddNewRow(dt, "K", "CFS")
        AddNewRow(dt, "L", "EDMS")
        AddNewRow(dt, "M", "WMS")
        AddNewRow(dt, "N", "영업")
        AddNewRow(dt, "O", "SCM")
        AddNewRow(dt, "Z", "ETC")

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV1.Columns("REQ_SVC").ColumnEdit = editorCombo

        '비용 내역 항목
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "T05")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV1.Columns("REQ_TYPE").ColumnEdit = editorCombo


        editor = New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        editor.CodeType = "YJIT.CodeService.Customer"
        editor.DisplayParams = "Code:#CUST_CD,CUST_LOCNM:#CUST_NM"
        editor.ValidateKeys = "KEY:#CUST_CD"
        editor.DataParams = "Type:''"
        editor.KeepIntegrity = True
        editor.AutoSuggestion = False
        editor.MaxLength = "10"
        editor.SearchPopup = "CustomerMaster"
        editor.CharacterCasing = CharacterCasing.Upper
        GV1.Columns("CUST_CD").ColumnEdit = editor


        editor = New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        editor.CodeType = "YJIT.CodeService.CustomerPic"
        editor.DisplayParams = "Code:#REQ_USR,Name:#TEL_NO"
        editor.ValidateKeys = "KEY:#REQ_USR"
        editor.DataParams = "Customer:@CUST_CD"
        editor.KeepIntegrity = False
        editor.AutoSuggestion = False
        editor.MaxLength = "10"
        editor.SearchPopup = "CodeMaster"
        editor.CharacterCasing = CharacterCasing.Normal
        GV1.Columns("REQ_USR").ColumnEdit = editor

        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        AddNewRow(dt, "0", "미확인")
        AddNewRow(dt, "7", "처리중")
        AddNewRow(dt, "1", "완료")
        AddNewRow(dt, "2", "즉시처리")
        AddNewRow(dt, "3", "재발신예정")
        AddNewRow(dt, "4", "재발신")
        AddNewRow(dt, "5", "수정요청")
        AddNewRow(dt, "6", "추가요청")
        AddNewRow(dt, "8", "보류")

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV1.Columns("PROC_TYPE").ColumnEdit = editorCombo

        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        AddNewRow(dt, "0", "매우급함")
        AddNewRow(dt, "1", "급함")
        AddNewRow(dt, "2", "당일처리")
        AddNewRow(dt, "3", "내일처리")
        AddNewRow(dt, "4", "일주일")

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV1.Columns("PRIORITY").ColumnEdit = editorCombo

        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        AddNewRow(dt, "Y", "무상")
        AddNewRow(dt, "N", "유상")

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV1.Columns("FREE_YN").ColumnEdit = editorCombo

        'Dim dt2 As New DataTable
        'dt2.Columns.Add(New DataColumn("CODE", GetType(String)))
        'dt2.Columns.Add(New DataColumn("NAME", GetType(String)))

        'AddNewRow(dt2, "E", "ELVIS")
        'AddNewRow(dt2, "O", "ELVIS(Etc)")
        'AddNewRow(dt2, "V", "일반")
        'AddNewRow(dt2, "T", "T/S")
        'AddNewRow(dt2, "M", "적하목록")
        'AddNewRow(dt2, "Z", "기타")

        'editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        'editorCombo.DisplayMember = "NAME"
        'editorCombo.ValueMember = "CODE"
        'editorCombo.NullText = ""
        'editorCombo.DataSource = dt2.Copy
        'GV1.Columns("SVC_CD").ColumnEdit = editorCombo

        Common.DrawRowIndicator(GV1)


    End Sub

    Private Function GetCustomerInfo() As DataTable
        '/////////// 거래처정보 ///////////'
        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        AddNewRow(dt, "01", "ETC")

        Return dt
    End Function

#End Region
#Region "=================Control Events==========="
    Private Sub CrmAsMgt_v2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'FM_YMD.Text = Now.AddMonths(-1).ToString("yyyyMMdd")
        'TO_YMD.Text = Now.AddMonths(1).ToString("yyyyMMdd")

        Call InitData()


    End Sub

    Private Sub CrmAsMgt_v2_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        Call GridInit()

        SaveControlValues(Me, {WG1, POPUP_INPUT, FM_YMD, TO_YMD, S_WORK_USR, S_PRIORITY, S_PROC_TYPE, REF_TIME})

        Gv1PopUp.CheckBoxValue("RegPopup") = POPUP_INPUT.Checked

        If REF_TIME.SelectedValue = "0" Then
            Timer1.Stop()
        Else
            MaxInterval = 60 * CDbl(REF_TIME.SelectedValue)
            Timer1.Start()
        End If

    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveData()
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call DeleteData()
    End Sub

    Private Sub SEARCH_KEY_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles SEARCH_KEY.PreviewKeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) Then
            Call SearchData()
        End If
    End Sub

    Private Sub GV1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV1.CellValueChanged
        Try
            CUST_CD.Text = GV1.GetRowCellValue(GV1.FocusedRowHandle, "CUST_CD").ToString
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
    End Sub


    Private Sub GV1_FocusedColumnChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles GV1.FocusedColumnChanged
        Try
            CUST_CD.Text = GV1.GetRowCellValue(GV1.FocusedRowHandle, "CUST_CD").ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GV1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GV1.DoubleClick
        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing

        If POPUP_INPUT.Checked = True Then
            frmMain = Me.MdiParent
            'If NEW_POPUP_INPUT.YesNo = "Y" Then
            '    fTarget = frmMain.NavigateTo("CrmAsInput_v1", NavigatedWindowModes.Dialog, False)
            '    If Not IsNothing(fTarget) Then
            '        fTarget.frmMain = frmMain
            '        fTarget.MNGT_NO.Text = GV1.GetRowCellValue(GV1.FocusedRowHandle, "MNGT_NO").ToString
            '        fTarget.SearchData()
            '        fTarget.ShowDialog()
            '    End If
            'Else
            '    fTarget = frmMain.NavigateTo("CrmAsInput", NavigatedWindowModes.Dialog, False)
            '    If Not IsNothing(fTarget) Then
            '        fTarget.frmMain = frmMain
            '        fTarget.MNGT_NO.Text = GV1.GetRowCellValue(GV1.FocusedRowHandle, "MNGT_NO").ToString
            '        fTarget.SearchData()
            '        fTarget.ShowDialog()
            '    End If
            'End If
        Else
            ' GV1.OptionsBehavior.Editable = True
        End If
    End Sub
    Private Sub AddNewRow(ByVal dt As DataTable, ByVal Code As String, ByVal Name As String)
        dt.Rows.Add()
        dt.Rows(dt.Rows.Count - 1)("CODE") = Code
        dt.Rows(dt.Rows.Count - 1)("NAME") = Name
    End Sub

    Private Sub GV1_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GV1.RowCellStyle
        If e.RowHandle = HotTrackRow Then
            e.Appearance.BackColor = Color.PaleGoldenrod
        End If

        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            If e.RowHandle < 0 Then Exit Sub

            Select Case e.Column.FieldName
                Case "PROC_TYPE"
                    If view.GetRowCellValue(e.RowHandle, "PROC_TYPE").ToString = "0" Then
                        e.Appearance.BackColor = System.Drawing.Color.Salmon
                    End If
                Case "CUST_NM"
                    If view.GetRowCellValue(e.RowHandle, "SYS_ID").ToString = "ELVIS" Then
                        e.Appearance.BackColor = System.Drawing.Color.Red
                    End If
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub S_ROW_BEST_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If S_ROW_BEST.SelectedValue = "Y" Then
        '    GV1.OptionsView.RowAutoHeight = True
        'Else
        '    GV1.OptionsView.RowAutoHeight = False
        'End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        second = second + 1
        If second >= MaxInterval Then
            second = 0
            SearchData()
        End If

    End Sub

    Private Sub REF_TIME_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REF_TIME.SelectedValueChanged
        If REF_TIME.SelectedValue = "0" Then
            Timer1.Stop()
        Else
            MaxInterval = 60 * CDbl(REF_TIME.SelectedValue)
            Timer1.Start()
        End If

    End Sub


    Private Sub POPUP_INPUT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POPUP_INPUT.CheckedChanged
        If POPUP_INPUT.Checked = True Then
            GV1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Default
            GV1.OptionsBehavior.Editable = False
        Else
            GV1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
            GV1.OptionsBehavior.Editable = True
        End If
    End Sub
#End Region
End Class
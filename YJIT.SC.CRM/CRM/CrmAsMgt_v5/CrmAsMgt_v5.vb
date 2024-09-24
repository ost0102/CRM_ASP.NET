Imports System.Drawing
Imports System.Drawing.Icon
Imports YJIT.SC.UI
Imports Microsoft.VisualBasic
Imports System.IO
Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Collections.Specialized
Imports DevExpress.XtraGrid.Views.Base

Public Class CrmAsMgt_v5
    Private HotTrackRowValue As Integer = DevExpress.XtraGrid.GridControl.InvalidRowHandle

    Public frmMain As YJIT.SC.UI.IMainForm = Nothing
    Dim BindPic As String = ""
    Dim BindTel As String = ""
    Private bSortEnable As Boolean = True
    Private KeyDownYn As Boolean = False
    Dim UserInfoDt As DataTable = Nothing

    Dim ShownFlag As Boolean = True
    Dim SearchFlag As Boolean = False

    Dim frm As Object = Me

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

#Region "=================GetConvertToDataset Function==========="
    Private Function GetConvertToDataSet(ByVal SearchType As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim IsSingleSearch As Boolean = False

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)

            Select Case SearchType.ToString.ToUpper
                Case "Search".ToUpper
                    YJSql.SqlBox("WG1", "CrmAsList@Search", True)
                    YJSql.Params("FM_YMD", drMAIN("S_FM_YMD").ToString)
                    YJSql.Params("TO_YMD", drMAIN("S_TO_YMD").ToString)
                    If drMAIN("S_DATE_TYPE").ToString = "R" Then
                        YJSql.Blocks("REQ_YMD", "TRUE")
                    ElseIf drMAIN("S_DATE_TYPE").ToString = "C" Then
                        YJSql.Blocks("CMPT_YMD", "TRUE")
                    Else
                        YJSql.Blocks("REQ_YMD", "TRUE")
                    End If
                    YJSql.Blocks("DEPT_TYPE_" & drMAIN("S_DEPT_TYPE").ToString, "TRUE")
                    YJSql.Params("DEPT_CD", drMAIN("S_DEPT_CD").ToString)
                    YJSql.Params("DEPT_AUTH", drMAIN("S_DEPT_AUTH").ToString)
                    YJSql.Params("CUST_CD", drMAIN("S_CUST_CD").ToString)
                    If drMAIN("S_WORK_TYPE").ToString = "W" Then
                        YJSql.Blocks("WORK_TYPE_" & drMAIN("S_WORK_TYPE").ToString, "TRUE")
                    ElseIf drMAIN("S_WORK_TYPE").ToString = "I" Then
                        YJSql.Blocks("WORK_TYPE_" & drMAIN("S_WORK_TYPE").ToString, "TRUE")
                    End If
                    YJSql.Params("WORK_USR", drMAIN("S_WORK_USR").ToString)
                    YJSql.Params("SEARCH_KEY", drMAIN("SEARCH_KEY").ToString)
                    YJSql.Params("REQ_SVC", drMAIN("S_REQ_SVC").ToString)
                    YJSql.Params("REQ_SVC2", drMAIN("S_REQ_SVC2").ToString)
                    YJSql.Params("REQ_TYPE2", drMAIN("S_REQ_TYPE2").ToString)
                    YJSql.Params("PROC_TYPE", S_PROC_TYPE.EditValue.ToString.Replace(";", "','").Replace(" ", ""))
                    'YJSql.Params("EX_IM_TYPE", drMAIN("S_EX_IM_TYPE").ToString)
                    If drMAIN("S_FIRST_DATA_YN").ToString = "Y" Then
                        YJSql.Blocks("FIRST_DATA_Y", "TRUE")
                    End If
                    YJSql.Params("PROJECT_CD", drMAIN("S_PROJECT_CD").ToString)
                    '20211123 정지수 자체처리 건 조회조건 추가 YJITS2021110396
                    If drMAIN("S_SELF_PROC_YN").ToString = "Y" Then
                        '자체처리 건
                        YJSql.Blocks("SELF_PROC_Y", True)
                    ElseIf drMAIN("S_SELF_PROC_YN").ToString = "N" Then
                        '일반 건
                        YJSql.Blocks("SELF_PROC_N", True)
                    Else
                        '전체
                    End If
                Case "CrmUserInfo".ToUpper
                    YJSql.SqlBox("CrmUserInfo", "CrmAsMgtDev@CrmUserInfo", True)
                Case "REQ_SVC2".ToUpper
                    YJSql.SqlBox("REQ_SVC2", "CrmAsMgt_v3@GetReqSvc2List", True)
                Case Else
                    Throw New Exception("No match type found. (GetConvertToDataSet)")
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function
#End Region

#Region "=================Data logic actions==========="
    Private Sub SetUserList(ByVal sender As Object, ByVal Dept_Cd As String)
        sender.EditValue = String.Empty

        Dim dt As New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        Try
            Dim Drs() As DataRow


            Select Case sender.Name.ToString.ToUpper
                Case "WORK_USR2"
                    If Dept_Cd = "ALL" Then
                        Drs = UserInfoDt.Select("WORK_USR2_YN = 'Y'", "DEPT_CD ASC,SORT ASC ,LOC_NM ASC")
                    Else
                        Drs = UserInfoDt.Select("DEPT_CD ='" & Dept_Cd & "' AND WORK_USR2_YN = 'Y'", "SORT ASC ,LOC_NM ASC")
                    End If
                    If Drs.Length > 0 Then
                        dt = Drs.CopyToDataTable
                        'dt.Columns("DEPT_CD").ColumnName = "CODE"
                        dt.Columns("USR_ID").ColumnName = "CODE"
                        dt.Columns("LOC_NM").ColumnName = "NAME"
                        For i = 0 To dt.Rows.Count - 1
                            dt.Rows(i)("CODE") = dt.Rows(i)("NAME").ToString
                            dt.Rows(i)("NAME") = (i + 1).ToString & "." & dt.Rows(i)("NAME").ToString
                        Next
                    End If
                Case Else
                    If Dept_Cd = "ALL" Then
                        Drs = UserInfoDt.Select("1=1", "DEPT_CD ASC,SORT ASC ,LOC_NM ASC")
                    Else
                        Drs = UserInfoDt.Select("DEPT_CD ='" & Dept_Cd & "'", "SORT ASC ,LOC_NM ASC")
                    End If
                    If Drs.Length > 0 Then
                        dt = Drs.CopyToDataTable
                        'dt.Columns("DEPT_CD").ColumnName = "CODE"
                        dt.Columns("USR_ID").ColumnName = "CODE"
                        dt.Columns("LOC_NM").ColumnName = "NAME"
                        For i = 0 To dt.Rows.Count - 1
                            dt.Rows(i)("NAME") = (i + 1).ToString & "." & dt.Rows(i)("NAME").ToString
                        Next
                    End If
            End Select



            Dim bindingSourceProduct As BindingSource
            bindingSourceProduct = New BindingSource()
            bindingSourceProduct.DataSource = dt
            sender.Properties.DataSource = bindingSourceProduct.DataSource
            sender.Properties.ValueMember = "CODE"
            sender.Properties.DisplayMember = "NAME"
            sender.Properties.NullText = String.Empty
            sender.DataBindings.CLEAR()
            sender.DataBindings.Add("EditValue", dt, "NAME")
            'sender.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
            sender.Properties.SeparatorChar = ";"
            'sender.EditValue = String.Empty
            sender.Properties.PopupFormMinSize = New Size(80, dt.Rows.Count * 22)


            Select Case sender.Name.ToString.ToUpper
                Case "WORK_USR2"
                    sender.EditValue = ""
                Case Else
                    sender.EditValue = ClientSessionInfo.UserID
            End Select
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SetReqsvc2(ByVal Grp_Cd As String)
        Try
            Dim DRS() As DataRow = REQ_SVC2_dt.Select("GRP_CD = '" & Grp_Cd & "'", "SORT ASC")
            Dim dt As New DataTable
            dt.Columns.Add("CODE")
            dt.Columns.Add("NAME")
            If DRS.Length > 0 Then
                dt = DRS.CopyToDataTable
                Dim dr As DataRow = dt.NewRow
                dr("CODE") = ""
                dr("NAME") = "--Select--"
                dt.Rows.InsertAt(dr, 0)
            Else
                dt.Rows.Add({"", "--Select--"})
            End If
            S_REQ_SVC2.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SetDept(ByVal sender As Object, Optional ByVal ExceptDept As String = "")

        Dim dt As New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")

        Try
            For i = 0 To DeptDt.Rows.Count - 1
                If ExceptDept <> DeptDt.Rows(i)("CODE").ToString Then
                    dt.ImportRow(DeptDt.Rows(i))
                    dt.Rows(dt.Rows.Count - 1)("NAME") = (i + 1).ToString & "." & dt.Rows(dt.Rows.Count - 1)("NAME").ToString
                    '       a = a + 1
                End If
            Next

            Dim bindingSourceProduct As BindingSource
            bindingSourceProduct = New BindingSource()
            bindingSourceProduct.DataSource = dt
            sender.Properties.DataSource = bindingSourceProduct.DataSource
            sender.Properties.ValueMember = "CODE"
            sender.Properties.DisplayMember = "NAME"
            sender.Properties.NullText = String.Empty
            sender.DataBindings.CLEAR()
            sender.DataBindings.Add("EditValue", dt, "NAME")
            'sender.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
            sender.Properties.SeparatorChar = ";"
            sender.EditValue = String.Empty
        Catch EX As Exception

        End Try
    End Sub
    Dim DeptDt As DataTable
    Dim REQ_SVC2_dt As DataTable
    Private Sub InitData()

        Dim searchParams = New Dictionary(Of String, Object)
        Dim dataParams = New Dictionary(Of String, Object)

        dataParams.Add("GroupCode", "C03")
        dataParams.Add("NameType", "")
        DeptDt = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)


        Try
            Dim ds As DataSet = GetConvertToDataSet("CrmUserInfo")
            Try
                ds = MethodCallEx(Me, "YJIT.Biz.CrmAsList", "Search", {ds})
            Catch ex As Exception
                MsgBoxLocalized(ex.Message)
            End Try
            ds = AdaptDataSourceForReport(ds)
            If ds.Tables.Contains("CrmUserInfo") Then
                UserInfoDt = ds.Tables("CrmUserInfo")
            End If


            ds = GetConvertToDataSet("REQ_SVC2")
            Try
                ds = MethodCallEx(Me, "YJIT.Biz.CrmAsList", "Search", {ds})
            Catch ex As Exception
                MsgBoxLocalized(ex.Message)
            End Try
            ds = AdaptDataSourceForReport(ds)
            If ds.Tables.Contains("REQ_SVC2") Then
                REQ_SVC2_dt = ds.Tables("REQ_SVC2")
            End If
        Catch ex As Exception

        End Try



        'Dim dtCol As DataTable = New DataTable
        'dtCol.Columns.Add(New DataColumn("CODE"))
        'dtCol.Columns.Add(New DataColumn("NAME"))

        'dtCol.Rows.Add()
        'dtCol.Rows(0)("CODE") = "0"
        'dtCol.Rows(0)("NAME") = "미확인"

        'dtCol.Rows.Add()
        'dtCol.Rows(1)("CODE") = "1"
        'dtCol.Rows(1)("NAME") = "완료"

        'dtCol.Rows.Add()
        'dtCol.Rows(2)("CODE") = "2"
        'dtCol.Rows(2)("NAME") = "즉시처리"

        'dtCol.Rows.Add()
        'dtCol.Rows(3)("CODE") = "3"
        'dtCol.Rows(3)("NAME") = "재발신예정"

        'dtCol.Rows.Add()
        'dtCol.Rows(4)("CODE") = "4"
        'dtCol.Rows(4)("NAME") = "재발신"

        'dtCol.Rows.Add()
        'dtCol.Rows(5)("CODE") = "5"
        'dtCol.Rows(5)("NAME") = "수정요청"

        'dtCol.Rows.Add()
        'dtCol.Rows(6)("CODE") = "6"
        'dtCol.Rows(6)("NAME") = "추가요청"

        'dtCol.Rows.Add()
        'dtCol.Rows(7)("CODE") = "7"
        'dtCol.Rows(7)("NAME") = "처리중"

        'dtCol.Rows.Add()
        'dtCol.Rows(8)("CODE") = "8"
        'dtCol.Rows(8)("NAME") = "보류"

        'dtCol.TableName = "ProcType"

        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "T03")
        dataParams.Add("NameType", "")

        Dim bindingSourceProduct As New BindingSource
        bindingSourceProduct.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        S_PROC_TYPE.Properties.DataSource = bindingSourceProduct.DataSource
        S_PROC_TYPE.Properties.ValueMember = "CODE"
        S_PROC_TYPE.Properties.DisplayMember = "NAME"
        S_PROC_TYPE.Properties.NullText = String.Empty
        S_PROC_TYPE.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
        S_PROC_TYPE.Properties.SeparatorChar = ";"



    End Sub

    Public Sub GridInit()
        Dim editorCombo As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim editor As New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)
        Dim dt As DataTable = New DataTable

        Common.DrawRowIndicator({GV1})

        'Dim editorDate As YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
        'editorDate = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
        GV1.Columns("REQ_YMD").ColumnEdit = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
        GV1.Columns("PRAR_YMD").ColumnEdit = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
        GV1.Columns("CMPT_YMD").ColumnEdit = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit


        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("Type", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("User", searchParams, dataParams)
        GV1.Columns("INS_USR").ColumnEdit = editorCombo
        GV1.Columns("WORK_USR").ColumnEdit = editorCombo



        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "T02")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV1.Columns("REQ_SVC").ColumnEdit = editorCombo

        '업무2
        If Not REQ_SVC2_dt Is Nothing Then
            dt = New DataTable
            dt.Columns.Add("CODE")
            dt.Columns.Add("NAME")
            dt = REQ_SVC2_dt.Copy

            Dim drAdd As DataRow = dt.NewRow
            drAdd("CODE") = ""
            drAdd("NAME") = " "
            dt.Rows.InsertAt(drAdd, 0)

            editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            editorCombo.DisplayMember = "NAME"
            editorCombo.ValueMember = "CODE"
            editorCombo.NullText = ""
            editorCombo.DataSource = dt.Copy
            editorCombo.ForceInitialize()
            editorCombo.PopulateColumns()
            editorCombo.Columns("CODE").Visible = False
            editorCombo.ShowHeader = False
            GV1.Columns("REQ_SVC2").ColumnEdit = editorCombo
        End If



        '요청상세
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "T09")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV1.Columns("REQ_TYPE2").ColumnEdit = editorCombo

        'editor = New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        'editor.CodeType = "YJIT.CodeService.Customer"
        'editor.DisplayParams = "Code:#CUST_CD,CUST_LOCNM:#CUST_NM"
        'editor.ValidateKeys = "KEY:#CUST_CD"
        'editor.DataParams = "Type:''"
        'editor.KeepIntegrity = True
        'editor.AutoSuggestion = False
        'editor.MaxLength = "10"
        'editor.SearchPopup = "CustomerMaster"
        'editor.CharacterCasing = CharacterCasing.Upper
        'GV1.Columns("CUST_CD").ColumnEdit = editor

        'editor = New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        'editor.CodeType = "YJIT.CodeService.CustomerPic"
        'editor.DisplayParams = "Code:#REQ_USR,Name:#TEL_NO"
        'editor.ValidateKeys = "KEY:#REQ_USR"
        'editor.DataParams = "Customer:@CUST_CD"
        'editor.KeepIntegrity = False
        'editor.AutoSuggestion = False
        'editor.MaxLength = "10"
        'editor.SearchPopup = "CodeMaster"
        'editor.CharacterCasing = CharacterCasing.Normal
        'GV1.Columns("REQ_USR").ColumnEdit = editor

        dt = New DataTable
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "T03")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
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

        dt = New DataTable
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "T12")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV1.Columns("EDU_LV").ColumnEdit = editorCombo

        'ELVIS-BILL
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo = GridFunc.GetRepositoryItemLookUpEdit({"Y:Yes", "N:No"})
        GV1.Columns("ELVIS_BILL_YN").ColumnEdit = editorCombo
        editorCombo.ForceInitialize() : editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False

        '자체처리
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo = GridFunc.GetRepositoryItemLookUpEdit({"P:자체처리", "X:일반"})
        GV1.Columns("SELF_PROC_YN").ColumnEdit = editorCombo
        editorCombo.ForceInitialize() : editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
    End Sub

    Public Sub PopUpInit()
        Dim PopUp As New PopupBase
        PopUp.ItemAdd(Action.NavigateTo, "WG1_CrmAsMgt_v4", "고객지원 등록")
        PopUp.ItemAdd(Action.NavigateTo, "WG1_CrmCustomerMgt", "거래처관리")
        PopUp.ItemAdd(Action.NavigateTo, "WG1_ComDocumentMgt", "문서관리")
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", "&Excel Export")
        PopUp.PopUpInit(Me, WG1)
    End Sub
    Public Sub PopUpOnAfterClick(ByVal dr As DataRow)
        Dim key As String = dr("Key").ToString

        Select Case key
            Case "WG1_CrmAsMgt_v4"
                Call NavigetToCrmAsMgt()
            Case "WG1_CrmCustomerMgt"
                Call NavigetToCustomer()
            Case "WG1_ComDocumentMgt"
                Call NavigetToDocument()
        End Select
    End Sub





#End Region

#Region "=================Control Events==========="
    Private Sub CrmAsList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CrmAsList_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Try
            InitData()

            S_FM_YMD.Text = DateAdd(DateInterval.Month, -1, Now).ToString("yyyyMMdd")
            S_FM_YMD.DefVal = S_FM_YMD.Text
            S_TO_YMD.Text = Now.ToString("yyyyMMdd")
            S_TO_YMD.DefVal = S_TO_YMD.Text


            Call PopUpInit()
            Call GridInit()


            GV1.OptionsBehavior.Editable = False
            GV1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
            GV1.OptionsBehavior.Editable = True


            '20180521 김성은 그리드 저장기능 추가
            Dim dt As DataTable = GetLayoutList(ClientSessionInfo.OfficeCode, Me.Name)
            LayOutList.DataSource = dt
            LoadFlag = False

            SaveControlValues(Me, {WG1, S_DEPT_TYPE, S_DEPT_TYPE, S_DEPT_CD, S_WORK_TYPE, S_WORK_USR, S_WORK_USR_NM, S_PROC_TYPE, LayOutList})
            SetMandatoryLine(Me)

            If GetForm("CrmAsMgt_v4") Is Nothing Then Exit Sub
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        Finally
            ShownFlag = False
        End Try
    End Sub

    Private Function GetForm(ByVal sMenuName As String)
        'Dim frm As Object = Me
        Dim assContainer As Reflection.Assembly = Nothing
        'Open the selected form as a new child
        Dim assExecuting As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        'In that case, focus to opened form

        'Check if current assembly contains module definition
        If assExecuting.GetType(Common.APP_ROOT_NAMESPACE & "." & Me.Name) IsNot Nothing Then
            assContainer = assExecuting
        Else
            'Lookup through the Modules folder to locate module container
            If Common.ModuleManifest.ContainsKey(Common.APP_ROOT_NAMESPACE & "." & sMenuName) Then
                'assContainer = Common.ModuleManifest(sID)
                assContainer = Reflection.Assembly.Load(System.IO.File.ReadAllBytes(Common.ModuleManifest(Common.APP_ROOT_NAMESPACE & "." & sMenuName)))       'This will reload assembly without locking it
                'Update loaded module manifest
                Common.ModuleLoadedManifest(Common.APP_ROOT_NAMESPACE & "." & sMenuName) = assContainer
            End If
        End If

        Try

            Dim types() As System.Type = assContainer.GetTypes()

            Dim exist As Boolean = False

            For Each _type In types
                If sMenuName = _type.Name Then
                    exist = True
                End If
            Next

            If Not exist Then
                If Common.ModuleManifest.ContainsKey(Common.APP_ROOT_NAMESPACE & "." & sMenuName.ToUpper) Then
                    'assContainer = Common.ModuleManifest(sID)
                    Dim strContainer As String = Common.ModuleManifest(Common.APP_ROOT_NAMESPACE & "." & sMenuName.ToUpper())
                    assContainer = Reflection.Assembly.Load(System.IO.File.ReadAllBytes(strContainer))       'This will reload assembly without locking it
                    'Update loaded module manifest
                    Common.ModuleLoadedManifest(Common.APP_ROOT_NAMESPACE & "." & sMenuName.ToUpper()) = assContainer
                End If
            End If

            frm = Nothing
            frm = assContainer.CreateInstance(Common.APP_ROOT_NAMESPACE & "." & sMenuName, True)

        Catch ex As Exception
            While (ex.InnerException IsNot Nothing)
                ex = ex.InnerException
            End While
        End Try

        Try
            GetMainPanel(frm)
        Catch ex As Exception
            Return Nothing
        End Try

        Return frm

    End Function

    Private Sub GetMainPanel(ByVal form As Object)

        If frm Is Nothing Then
            'tabMAIN.SelectedTabPage.Controls.Clear()
        Else
            Try
                form.TopLevel = False
                form.Left = 0
                form.Top = 0
                form.Width = SplitMain.Panel2.Width
                form.Height = SplitMain.Panel2.Height
                Dim ctrl As Control = form

                If Not SplitMain.Panel2.Controls.ContainsKey(ctrl.Name) Then
                    SplitMain.Panel2.Controls.Add(ctrl)

                    frm.CustomerPanel.top = frm.CustomerPanel.top - (frm.xtcMain.Top - frm.palAutoButton.Top)
                    frm.SplitMain.top = frm.SplitMain.top - (frm.xtcMain.Top - frm.palAutoButton.Top)
                    frm.SplitMain.Height = frm.SplitMain.Height + (frm.xtcMain.Top - frm.palAutoButton.Top)
                    form.xtcMain.Top = form.palAutoButton.Top
                    form.palAutoButton.Visible = False
                End If
                form.Dock = DockStyle.Fill
                form.FormShown(Me)
                form.show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub


#End Region
    '===================================================================================================================
    '함수이동
    '===================================================================================================================

    Private Sub AddNewRow(ByVal dt As DataTable, ByVal Code As String, ByVal Name As String)
        dt.Rows.Add()
        dt.Rows(dt.Rows.Count - 1)("CODE") = Code
        dt.Rows(dt.Rows.Count - 1)("NAME") = Name
    End Sub

    'Private Function GetConvertToDataSet(ByVal KEY As String) As DataSet
    '    Dim YJSql As New YJQuery
    '    Dim ds As DataSet = Me.ConvertToDataset

    '    Try
    '        Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
    '        Select Case KEY
    '            Case "CrmUserInfo"
    '                YJSql.SqlBox("CrmUserInfo", "CrmAsMgtDev@CrmUserInfo", True)
    '            Case "REQ_SVC2"
    '                YJSql.SqlBox("REQ_SVC2", "CrmAsMgt_v3@GetReqSvc2List", True)
    '        End Select
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try

    '    Return YJSql.DataSet
    'End Function

    'Public Function YJQuerySearch(ByVal key As String) As DataSet

    '    Dim ParamDsRet As DataSet = GetConvertToDataSet(key)
    '    Dim dsRet As DataSet = Nothing
    '    Try
    '        dsRet = MethodCallEx(Me, "YJIT.Biz.YJQuery", "Search", {ParamDsRet})
    '    Catch ex As Exception

    '    End Try
    '    Return dsRet
    'End Function

    Private Sub SearchHistory()

        Dim ds As DataSet = Nothing
        Dim dr As DataRow = Nothing

        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgt_v3", "SearchHistory", Me.ConvertToDataset)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode").ToString <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg").ToString, MessageBoxButtons.OK, "Warning", MessageBoxIcon.Warning)
        End If
        Me.BindToDataset(ds, "Data")

    End Sub


    Public Sub SearchData()
        Try
            If SearchFlag = True Then Exit Sub
            SearchFlag = True

            If SearchValidate() = False Then Exit Sub

            Dim dsRet As DataSet = GetConvertToDataSet("Search")

            dsRet = MethodCallEx(Me, "YJIT.Biz.CrmAsList", "Search", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Me.BindToDataset(dsRet, "Data")

                    If Not IsNothing(frm) Then
                        If Not String.IsNullOrEmpty(frm.MNGT_NO.Text) Then
                            frm.SearchData()
                        End If
                    End If
                Case "N"
                    Call ClearView(AppliedRangeTypes.Only, {WG1})
                    MsgBoxLocalized(drPairs("TrxMsg"))
                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select

            GV1.FocusedRowHandle = 0
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        Finally
            SearchFlag = False
        End Try
    End Sub
    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

        Try
            If String.IsNullOrEmpty(S_FM_YMD.Text.ToString) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = S_FM_YMD
                ErrMsg &= S_DATE_TYPE.Text & " 시작일은 필수 입니다." & vbNewLine
            End If

            Dim FmYmd As String = S_FM_YMD.Text
            Dim ToYmd As String = Now.ToString("yyyyMMdd")
            If Not String.IsNullOrEmpty(S_TO_YMD.Text.ToString) Then ToYmd = S_TO_YMD.Text
            If FmYmd.Count < 8 Then
                If ErrControl Is Nothing Then ErrControl = S_FM_YMD
                ErrMsg &= S_DATE_TYPE.Text & " 시작일이 잘못되었습니다." & vbNewLine
            End If
            If ToYmd.Count < 8 Then
                If ErrControl Is Nothing Then ErrControl = S_TO_YMD
                ErrMsg &= S_DATE_TYPE.Text & " 종료일이 잘못되었습니다." & vbNewLine
            End If
            Dim Mondths As Long = DateDiff(DateInterval.Month, CDate(String.Format("{0}-{1}-{2}", FmYmd.Substring(0, 4), FmYmd.Substring(4, 2), FmYmd.Substring(6, 2))), CDate(String.Format("{0}-{1}-{2}", ToYmd.Substring(0, 4), ToYmd.Substring(4, 2), ToYmd.Substring(6, 2))))
            If Mondths + 1 > 6 Then
                If ErrControl Is Nothing Then ErrControl = S_FM_YMD
                ErrMsg &= S_DATE_TYPE.Text & " 기간은 최대 6개월까지 조회 가능합니다." & vbNewLine
            End If

            If Not String.IsNullOrEmpty(ErrMsg) Then
                'If Not ErrTabPage Is Nothing Then xtcMAIN.SelectedTabPage = ErrTabPage
                If Not ErrControl Is Nothing Then ErrControl.Focus()
                Throw New Exception(ErrMsg)
            End If

            Return True
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
    End Function

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchData()
    End Sub

    Private Sub S_PROC_TYPE_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles S_PROC_TYPE.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            btnSearch.Focus()
        End If
    End Sub

    Private Sub GV1_Click(sender As Object, e As MouseEventArgs) Handles GV1.Click
        Dim View As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim hitInfo As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = GV1.CalcHitInfo(e.Location)
        If (hitInfo.InRowCell) Then
            If GV1.RowCount = 0 Then Exit Sub

            If Not IsNothing(frm) Then
                'frm.NewData() 사용하면 안됨
                frm.LEFTFORM_TAB.Text = Me.Name
                frm.MNGT_NO.Text = GV1.GetFocusedRowCellValue("MNGT_NO").ToString
                If GV1.GetFocusedRowCellValue("DEV_CMPT_YN").ToString = "Y" Then
                    frm.SearchNewData()
                Else
                    frm.SearchData()
                End If
            End If
        Else
            'HEADER 클릭시 자료조회 로직 제외
        End If
    End Sub

    Private Sub GV1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GV1.DoubleClick
        'If GV1.FocusedColumn.FieldName = "CUST_CD" OrElse GV1.FocusedColumn.FieldName = "CUST_NM" Then
        '    Call NavigetToCustomer()
        'Else
        If GV1.FocusedColumn.FieldName = "FILE_YN" AndAlso GV1.GetFocusedRowCellValue("FILE_YN").ToString = "Y" Then
            Call NavigetToDocument()
        Else
            Call NavigetToCrmAsMgt()
        End If
    End Sub

    Private Sub NavigetToCustomer()
        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing

        frmMain = Me.MdiParent
        fTarget = frmMain.NavigateTo("CrmCustomerMgt")
        If Not IsNothing(fTarget) Then
            Dim SearchType As String = fTarget.SEARCH_TYPE.SelectedValue.ToString
            fTarget.SEARCH_TYPE.SelectedValue = "CUST_CD"
            fTarget.SEARCH_KEY.Text = GV1.GetFocusedRowCellValue("CUST_CD").ToString
            fTarget.SearchData()
            fTarget.SEARCH_TYPE.SelectedValue = SearchType
        End If
    End Sub

    Private Sub NavigetToCrmAsMgt()
        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing

        frmMain = Me.MdiParent
        fTarget = frmMain.NavigateTo("CrmAsMgt_v4")
        If Not IsNothing(fTarget) Then
            fTarget.MNGT_NO.Text = GV1.GetFocusedRowCellValue("MNGT_NO").ToString
            fTarget.SearchData()
        End If
    End Sub

    Private Sub NavigetToDocument()
        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing

        frmMain = Me.MdiParent
        fTarget = frmMain.NavigateTo("ComDocumentMgt", NavigatedWindowModes.Dialog, False)
        If Not IsNothing(fTarget) Then
            fTarget.ParentWindow = Me
            fTarget.S_MNGT_NO.text = GV1.GetFocusedRowCellValue("MNGT_NO").ToString
            fTarget.SCREEN.Text = "고객지원 작업현황"
            fTarget.DirList.Text = "CrmAsList"
            fTarget.SearchData()
            fTarget.ShowDialog()
        End If
    End Sub

    '화면 플레그 사용
    Dim LoadFlag As Boolean = True

    Private Sub btnSaveCol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveCol.Click
        SaveLayout()
    End Sub

    Private Sub LayOutList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LayOutList.SelectedIndexChanged
        If LoadFlag Then Exit Sub

        Try
            If LayOutList.SelectedValue.ToString <> "" Then
                Dim ds As DataSet = GetLayout(ClientSessionInfo.OfficeCode, Me.Name, LayOutList.SelectedValue)
                Dim LayoutDt As DataTable = ds.Tables("LAYOUT")
                Dim FormulaDt As DataTable = ds.Tables("FORMULA")
                If LayoutDt.Rows.Count = 0 Then
                    'GetColumnList()
                    Exit Sub
                End If
                LoadLayout(GV1, LayoutDt.Rows(0)("LAYOUT"))

                For i = 0 To GV1.Columns.Count - 1
                    If Not GV1.Columns(i).ShowUnboundExpressionMenu Then Continue For

                    Dim dr() As DataRow = FormulaDt.Select("CONTROL ='" & GV1.Columns(i).FieldName & "'")
                    If dr.Length = 0 Then
                        GV1.Columns(i).UnboundExpression = ""
                    Else
                        GV1.Columns(i).UnboundExpression = dr(0)("FORMULA").ToString
                    End If
                Next
            Else
                'GetColumnList()
            End If

        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnDeleteCol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteCol.Click
        DeleteLayout()
    End Sub
    Private Sub btnSearchCol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchCol.Click
        LayOutList.DataSource = GetLayoutList(ClientSessionInfo.OfficeCode, Me.Name)
    End Sub

    Public Sub SaveLayout()
        If LayOutList.Text.Replace(" ", "") = "--New--" Then
            MsgBoxLocalized("Can not be saved with the default name.")
            Exit Sub
        End If
        If MsgBoxLocalized("Are you sure Save?", MessageBoxButtons.YesNo) = MsgBoxResult.No Then Exit Sub
        Dim param As DataSet = Me.ConvertToDataset
        Dim LAYOUT_NM As String = LayOutList.Text
        Dim LAYOUT As String = GetGirdLayout(GV1)
        Dim dt As DataTable = GetSaveLayoutDatble()

        dt.Rows.Add(Me.Name, LAYOUT_NM, LAYOUT)
        dt.TableName = "CRM_LAYOUT_MST"
        param.Tables.Add(dt.Copy)

        dt.Rows.Clear()
        For i = 0 To GV1.Columns.Count - 1
            If GV1.Columns(i).ShowUnboundExpressionMenu Then
                dt.Rows.Add(Me.Name, LAYOUT_NM, GV1.Name, GV1.Columns(i).FieldName, GV1.Columns(i).UnboundExpression)
            End If
        Next
        dt.TableName = "CRM_LAYOUT_DTL"
        param.Tables.Add(dt)
        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.Common", "SaveLayout", param, AddressOf SaveLayoutOnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Public Sub SaveLayoutOnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Dim LayoutText As String = LayOutList.Text
        Try
            If IsNothing(e.Result) Then
                Throw New Exception("Try Again !")
            End If

            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
            MsgBoxLocalized(dr("TrxMsg"))
            If dr("TrxCode") = "Y" Then
                LoadFlag = True
                LayOutList.DataSource = ds.Tables("Data.List").Copy
                LayOutList.Text = LayoutText
                LoadFlag = False
            Else
                Exit Try
            End If
        Catch ex As Exception

        End Try

    End Sub
    Public Function GetGirdLayout(ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView) As String
        Dim sStream As Stream
        sStream = New System.IO.MemoryStream()
        gv.SaveLayoutToStream(sStream)

        sStream.Position = 0
        Dim rStreamReader As New IO.StreamReader(sStream)
        Dim strLayout As String = rStreamReader.ReadToEnd()
        Return strLayout
    End Function

    Public Function LoadLayout(ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView, ByVal Layout As String) As String
        Dim strLayout As String = Layout
        Dim sStream As New MemoryStream()
        Dim wStreamWirter As New StreamWriter(sStream)
        wStreamWirter.AutoFlush = True
        wStreamWirter.Write(strLayout)
        sStream.Position = 0
        Try
            gv.RestoreLayoutFromStream(sStream)
        Catch ex As Exception
            Return "Wrong data format"
        End Try
        Return ""
    End Function
    Public Function GetSaveLayoutDatble()
        Dim dt As New DataTable
        dt.Columns.Add("FORM_ID")
        dt.Columns.Add("LAYOUT_NM")
        dt.Columns.Add("LAYOUT")
        dt.Columns.Add("CONTROL")
        dt.Columns.Add("FORMULA")
        Return dt
    End Function
    Public Sub DeleteLayout()
        If MsgBoxLocalized("Are you sure Delete?", MessageBoxButtons.YesNo) = MsgBoxResult.No Then Exit Sub
        Dim param As DataSet = Me.ConvertToDataset
        Dim LAYOUT_NM As String = LayOutList.Text
        Dim dt As DataTable = GetSaveLayoutDatble()

        dt.Rows.Add(Me.Name, LAYOUT_NM, "")
        dt.TableName = "CRM_LAYOUT_MST"
        param.Tables.Add(dt.Copy)
        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.Common", "DeleteLayout", param, AddressOf DeleteLayoutOnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Public Sub DeleteLayoutOnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Dim LayoutText As String = LayOutList.Text
        Try
            If IsNothing(e.Result) Then
                Throw New Exception("Try Again !")
            End If

            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
            MsgBoxLocalized(dr("TrxMsg"))
            If dr("TrxCode") = "Y" Then
                LoadFlag = True
                LayOutList.DataSource = ds.Tables("Data.List").Copy
                LoadFlag = False
            Else

                Exit Try
            End If

        Catch ex As Exception

        End Try

    End Sub


    Private Sub S_PROC_TYPE_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnSearch.Focus()
    End Sub

    'Dim DeptFlag As String = False
    'Private Sub S_DEPT_CD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_DEPT_CD.SelectedIndexChanged
    '    If ShownFlag = True Then Exit Sub

    '    Try
    '        DeptFlag = True
    '        Dim searchParams = New Dictionary(Of String, Object)
    '        Dim dataParams = New Dictionary(Of String, Object)

    '        If String.IsNullOrEmpty(S_DEPT_CD.SelectedValue) Then
    '            Dim dt As DataTable = New DataTable
    '            dt.Columns.Add("CODE", GetType(String))
    '            dt.Columns.Add("NAME", GetType(String))
    '            Call AddNewRow(dt, "", "--Select--")
    '            S_REQ_SVC.DataSource = dt.Copy
    '            S_REQ_SVC2.DataSource = dt.Copy
    '        Else
    '            Select Case S_DEPT_CD.SelectedValue
    '                Case "02", "05"
    '                    dataParams.Add("GroupCode", "Z01")
    '                Case Else
    '                    dataParams.Add("GroupCode", "T02")
    '            End Select
    '            dataParams.Add("NameType", "")
    '            Dim dt As DataTable = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
    '            Dim dr As DataRow = dt.NewRow
    '            dr("CODE") = ""
    '            dr("NAME") = "--Select--"
    '            dt.Rows.InsertAt(dr, 0)
    '            S_REQ_SVC.DataSource = dt
    '        End If
    '    Catch ex As Exception
    '        MsgBoxLocalized(ex.Message)
    '    Finally
    '        DeptFlag = False
    '    End Try
    'End Sub



    Private Sub S_DEPT_CD_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles S_DEPT_CD.KeyDown, S_REQ_SVC.KeyDown, S_REQ_SVC2.KeyDown, S_DEPT_AUTH.KeyDown, S_REQ_TYPE2.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.DroppedDown = True
        End If
    End Sub

    Private Sub S_DATE_TYPE_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles S_DATE_TYPE.KeyDown, S_WORK_TYPE.KeyDown, S_DEPT_TYPE.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.DroppedDown = True
        End If
    End Sub



    Private Sub S_REQ_SVC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_REQ_SVC.SelectedIndexChanged
        If ShownFlag = True Then Exit Sub

        SetReqsvc2(S_REQ_SVC.SelectedValue)

        ''If S_FM_YMD.Text <> "" AndAlso S_REQ_SVC.SelectedValue <> "" Then SearchData()
        'If S_FM_YMD.Text <> "" Then Call SearchData()
    End Sub

    'Private Sub S_DATE_TYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_DATE_TYPE.SelectedIndexChanged, _
    '                                                                                                                 S_DEPT_AUTH.SelectedIndexChanged, _
    '                                                                                                                 S_REQ_SVC2.SelectedIndexChanged, _
    '                                                                                                                 S_DEPT_CD.SelectedIndexChanged
    '    If ShownFlag = True Then Exit Sub

    '    If S_FM_YMD.Text <> "" Then SearchData()
    'End Sub


    'Private Sub S_DEPT_TYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_DEPT_TYPE.SelectedIndexChanged
    '    If ShownFlag = True Then Exit Sub

    '    If S_FM_YMD.Text <> "" AndAlso Not String.IsNullOrEmpty(S_DEPT_CD.SelectedValue) Then SearchData()
    'End Sub

    'Private Sub S_WORK_TYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_WORK_TYPE.SelectedIndexChanged
    '    If ShownFlag = True Then Exit Sub

    '    If S_FM_YMD.Text <> "" AndAlso Not String.IsNullOrEmpty(S_WORK_USR.Text) Then SearchData()
    'End Sub

    'Private Sub S_FM_YMD_EditValueChanged(ByVal oldValue As System.Object, ByVal newValue As System.Object) Handles S_FM_YMD.EditValueChanged, _
    '                                                                                                                S_TO_YMD.EditValueChanged, _
    '                                                                                                                S_PROC_TYPE.EditValueChanged, _
    '                                                                                                                SEARCH_KEY.EditValueChanged, _
    '                                                                                                                S_CUST_CD.EditValueChanged, _
    '                                                                                                                S_WORK_USR.EditValueChanged
    '    If ShownFlag = True Then Exit Sub

    '    If S_FM_YMD.Text <> "" Then Call SearchData()
    'End Sub

    'Private Sub S_FM_YMD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles S_FM_YMD.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If S_FM_YMD.Text <> "" Then SearchData()
    '    End If
    'End Sub
    'Private Sub S_TO_YMD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles S_TO_YMD.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If S_FM_YMD.Text <> "" AndAlso S_TO_YMD.Text <> "" Then SearchData()
    '    End If
    'End Sub

    'Private Sub S_CUST_NM_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles S_CUST_NM.TextChanged, S_WORK_USR_NM.TextChanged
    '    If ShownFlag = True Then Exit Sub

    '    If S_FM_YMD.Text <> "" AndAlso sender.Text <> "" Then SearchData()
    'End Sub

    'Private Sub S_DEPT_AUTH_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles S_DEPT_AUTH.SelectedIndexChanged, S_REQ_SVC2.SelectedIndexChanged, S_DEPT_CD.SelectedIndexChanged
    '    If ShownFlag = True Then Exit Sub

    '    If S_FM_YMD.Text <> "" AndAlso sender.SelectedValue <> "" Then SearchData()
    'End Sub

    'Private Sub S_REQ_SVC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_REQ_SVC.SelectedIndexChanged
    '    If ShownFlag = True Then Exit Sub

    '    SetReqsvc2(S_REQ_SVC.SelectedValue)

    '    If S_FM_YMD.Text <> "" AndAlso S_REQ_SVC.SelectedValue <> "" Then SearchData()
    'End Sub

    'Private Sub S_DATE_TYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_DATE_TYPE.SelectedIndexChanged
    '    If ShownFlag = True Then Exit Sub

    '    If S_FM_YMD.Text <> "" Then SearchData()
    'End Sub

    'Private Sub S_DEPT_TYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_DEPT_TYPE.SelectedIndexChanged
    '    If ShownFlag = True Then Exit Sub

    '    If S_FM_YMD.Text <> "" AndAlso S_DEPT_CD.SelectedValue <> "" Then SearchData()
    'End Sub

    'Private Sub S_WORK_TYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_WORK_TYPE.SelectedIndexChanged
    '    If ShownFlag = True Then Exit Sub

    '    If S_FM_YMD.Text <> "" AndAlso S_WORK_USR.Text.ToString.Trim <> "" Then SearchData()
    'End Sub

    'Private Sub S_PROC_TYPE_EditValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_PROC_TYPE.EditValueChanged
    '    If ShownFlag = True Then Exit Sub

    '    If S_FM_YMD.Text <> "" AndAlso S_PROC_TYPE.EditValue <> "" Then SearchData()
    'End Sub


    'Private Sub SEARCH_KEY_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles SEARCH_KEY.PreviewKeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If S_FM_YMD.Text <> "" AndAlso SEARCH_KEY.Text.ToString.Trim <> "" Then SearchData()
    '    End If
    'End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        '조회조건 초기화를 넣는 경우 신규자료 입력후 재조회시 문제가 됨
        frm.NewData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If frm.ONLINE_YN.Text = "Y" Then
            frm.ONLINE_YN.Text = "A"
        End If
        frm.SaveData()
    End Sub

    Private Sub btnSaveLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveLeft.Click
        'If frm.ONLINE_YN.Text = "A" Then
        '    If MsgBoxLocalized("온라인접수로 재등록하시겠습니까?" & "(상태가 미확인으로 변경됩니다.)", MessageBoxButtons.YesNo, , , MessageBoxDefaultButton.Button2) = MsgBoxResult.No Then
        '        Exit Sub
        '    End If
        'End If
        'frm.ONLINE_YN.Text = "Y"
        'frm.PROC_TYPE.SelectedValue = 0
        'Call frm.SaveData()
        Call frm.SaveOnlineData
    End Sub

    Private Sub btnList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnList.Click
        frm.NavigetToCrmAsList()
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
                    If view.GetRowCellValue(e.RowHandle, "DEV_CMPT_YN").ToString = "Y" Then
                        e.Appearance.BackColor = Color.LightBlue
                    ElseIf view.GetRowCellValue(e.RowHandle, "PROC_TYPE").ToString = "0" Then
                        e.Appearance.BackColor = System.Drawing.Color.Salmon
                    End If
                Case "CONTENT"
                    If view.GetRowCellValue(e.RowHandle, "RETURN_YN").ToString = "반려" Then
                        e.Appearance.BackColor = Color.OrangeRed
                    End If
                Case "SYS_NM", "CUST_NM"
                    Select Case view.GetRowCellValue(e.RowHandle, "SYS_ID").ToString
                        Case "CRM", "MAIL"
                            '기본값
                        Case Else '"ELVIS", "HELP"
                            e.Appearance.BackColor = System.Drawing.Color.LightPink
                    End Select
                Case "WORK_USR"
                    If e.CellValue.ToString.Contains(ClientSessionInfo.LocalName) Then
                        e.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
                    End If
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnCopy_Click(sender As System.Object, e As System.EventArgs) Handles btnCopy.Click
        frm.CopyData()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        frm.PrintData()
    End Sub
End Class
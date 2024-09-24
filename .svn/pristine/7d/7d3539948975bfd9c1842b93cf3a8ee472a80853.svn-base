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


Enum SendMailType
    SettingELVIS = 0
    JoinSR = 1
End Enum

Public Class CrmCustomerMgt
    Dim CustomTypeCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Dim GV_Flag As Boolean = False
    Private tempRoot As String = Application.StartupPath & "\TMP_OUTPUT"
    Protected filePath As String = String.Empty
    Private DefaultFontFamily As String = "맑은 고딕"
    Private DefaultFontSize As Integer = 9
    Dim DeptDt As DataTable
    Dim REQ_SVC2_dt As DataTable
    Dim UserInfoDt As DataTable = Nothing

#Region "=================Client Function==========="
    'Client Function : 클라이언트 동작 함수

    Private Function GetConvertToDataSet() As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
            YJSql.SqlBox("WG1", "CrmCustomerMgt@SearchMain")
            YJSql.Params("SEARCH_TYPE_" & drMAIN("SEARCH_TYPE").ToString.Trim, drMAIN("SEARCH_TYPE").ToString.Trim)
            YJSql.Params("SEARCH_KEY", drMAIN("SEARCH_KEY").ToString.Trim)
            YJSql.Params("SVC_CD", drMAIN("S_SVC_CD").ToString.Trim)
            YJSql.Params("USE_YN", drMAIN("S_USE_YN").ToString.Trim)
            YJSql.Params("CUST_TYPE", drMAIN("S_CUST_TYPE").ToString.Trim)

            If drMAIN("S_INFO_YN").ToString.Trim = "Y" Then
                Select Case drMAIN("S_INFO_TYPE").ToString.Trim
                    Case "INFO_YN"
                        YJSql.Blocks("INFO_Y", drMAIN("S_INFO_TYPE").ToString.Trim)
                    Case "STOP_YN"
                        YJSql.Blocks("STOP_Y", drMAIN("S_INFO_TYPE").ToString.Trim)
                End Select
            ElseIf drMAIN("S_INFO_YN").ToString.Trim = "N" Then
                Select Case drMAIN("S_INFO_TYPE").ToString.Trim
                    Case "INFO_YN"
                        YJSql.Blocks("INFO_N", drMAIN("S_INFO_TYPE").ToString.Trim)
                    Case "STOP_YN"
                        YJSql.Blocks("STOP_N", drMAIN("S_INFO_TYPE").ToString.Trim)
                End Select
            End If


        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function

    Public Function YJQuerySearch(ByVal key As String) As DataSet

        Dim ParamDsRet As DataSet = GetConvertToDataSet(key)
        Dim dsRet As DataSet = Nothing
        Try
            dsRet = MethodCallEx(Me, "YJIT.Biz.YJQuery", "Search", {ParamDsRet})
        Catch ex As Exception

        End Try
        Return dsRet
    End Function

    Private Function GetConvertToDataSet(ByVal KEY As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
            Select Case KEY
                Case "CrmUserInfo"
                    YJSql.SqlBox("CrmUserInfo", "CrmAsMgtDev@CrmUserInfo", True)
                Case "REQ_SVC2"
                    YJSql.SqlBox("REQ_SVC2", "CrmAsMgt_v2@GetReqSvc2List", True)
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function
    Public Sub SetDefault()
        Try
            Try
                Dim ds As DataSet = YJQuerySearch("CrmUserInfo")
                ds = AdaptDataSourceForReport(ds)
                If ds.Tables.Contains("CrmUserInfo") Then
                    UserInfoDt = ds.Tables("CrmUserInfo")
                End If

                ds = YJQuerySearch("REQ_SVC2")
                ds = AdaptDataSourceForReport(ds)
                If ds.Tables.Contains("REQ_SVC2") Then
                    REQ_SVC2_dt = ds.Tables("REQ_SVC2")
                End If
            Catch ex As Exception
            Finally
                Me.Cursor = Cursors.Default
            End Try

            Dim cp As CharacterProperties = RMK.Document.BeginUpdateCharacters(RMK.Document.Range)
            cp.FontName = DefaultFontFamily
            cp.AllCaps = False
            cp.FontSize = DefaultFontSize
            RMK.Document.EndUpdateCharacters(cp)

            CTRY_CD.SelectedValue = "KR"
            LANG_CD.SelectedValue = "ko-KR"
            USE_YN.SelectedValue = "Y"
            MATN_YN.SelectedValue = "Y"
            TBL_CHG_YN.SelectedValue = "Y"
            CREDIT_DAYS.Text = 3
            CUST_TYPE.SelectedValue = "C"
            CTRT_CD.SelectedValue = "P"
            BILG_CD.SelectedValue = "KR"
            BANK_TYPE.SelectedValue = "A"
            BANK_DAY.SelectedValue = "25"
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Public Sub PopupInit()
        Dim PopUp As New PopupBase

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.NavigateTo, "ComDocumentMgt", "Document")
        PopUp.ItemAdd(Action.NavigateTo, "ComLogMgt", "Log Management")
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", Me.Localizer.GetLocalizedString("&Export Excel"), True)
        PopUp.PopUpInit(Me, WG1)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG2_ADDROW", "Add row", True)
        PopUp.ItemAdd(Action.DeleteRow, "WG2_DELETEROW", "Delete row")
        PopUp.ItemAdd(Action.Other, "WG2_Default", "Default 국내", True)
        PopUp.ItemAdd(Action.Other, "WG2_Default2", "Default 해외")
        PopUp.ItemAdd(Action.Other, "WG2_Default3", "Default 중국")
        PopUp.ItemAdd(Action.Excel, "WG2_Excel", Me.Localizer.GetLocalizedString("&Export Excel"), True)
        PopUp.PopUpInit(Me, WG2, "GV2_NAME", "GV2_SVR_TYPE")

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.NavigateTo, "WG3_ComDocumentMgt", "Document", True)
        PopUp.PopUpInit(Me, WG3)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG4_ADDROW", "Add row")
        PopUp.ItemAdd(Action.DeleteRow, "WG4_DELETEROW", "Delete row")
        PopUp.ItemAdd(Action.Excel, "WG4_Excel", Me.Localizer.GetLocalizedString("&Export Excel"), True)
        PopUp.PopUpInit(Me, WG4, "GV4_CODE", "GV4_NAME")  '거래처정보 GRID

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG5_ADDROW", "Add row", True)
        PopUp.ItemAdd(Action.DeleteRow, "WG5_DELETEROW", "Delete row")
        PopUp.ItemAdd(Action.Excel, "WG5_Excel", Me.Localizer.GetLocalizedString("&Export Excel"), True)
        PopUp.PopUpInit(Me, WG5, "PIC_NM", "RMK")  '담당자정보 GRID

        'EDI Information
        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG6_AddRow", Me.Localizer.GetLocalizedString("&Add Row"))
        PopUp.ItemAdd(Action.DeleteRow, "WG6_DeleteRow", Me.Localizer.GetLocalizedString("&Delete Row"))
        PopUp.ItemAdd(Action.Excel, "WG6_Excel", Me.Localizer.GetLocalizedString("&Export Excel"), True)
        PopUp.PopUpInit(Me, WG6, "EDI_SYS_CD", "MAIL_BOX_ID")

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG7_ADDROW", "Add row", True)
        PopUp.ItemAdd(Action.DeleteRow, "WG7_DELETEROW", "Delete row")
        PopUp.ItemAdd(Action.Excel, "WG7_Excel", Me.Localizer.GetLocalizedString("&Export Excel"), True)
        PopUp.PopUpInit(Me, WG7, "SVC_CD", "SVC_CD")

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG8_ADDROW", "Add row", True)
        PopUp.ItemAdd(Action.DeleteRow, "WG8_DELETEROW", "Delete row")
        PopUp.ItemAdd(Action.Excel, "WG8_Excel", Me.Localizer.GetLocalizedString("&Export Excel"), True)
        PopUp.PopUpInit(Me, WG8, "RMK", "RMK")

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG9_ADDROW", "Add row", True)
        PopUp.ItemAdd(Action.DeleteRow, "WG9_DELETEROW", "Delete row")
        PopUp.ItemAdd(Action.Excel, "WG9_Excel", Me.Localizer.GetLocalizedString("&Export Excel"), True)
        PopUp.PopUpInit(Me, WG9, "SVC_TYPE", "RMK")

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG11_ADDROW", "Add row", True)
        PopUp.ItemAdd(Action.DeleteRow, "WG11_DELETEROW", "Delete row")
        PopUp.ItemAdd(Action.Other, "WG11_SEND_VENDER", "Send Mail To Vender")
        PopUp.ItemAdd(Action.Excel, "WG11_Excel", Me.Localizer.GetLocalizedString("&Export Excel"), True)
        PopUp.PopUpInit(Me, WG11, "SVC_TYPE", "RMK")

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG_RPA_ADDROW", "Add row", True)
        PopUp.ItemAdd(Action.DeleteRow, "WG_RPA_DELETEROW", "Delete row")
        PopUp.ItemAdd(Action.Excel, "WG_RPA_Excel", Me.Localizer.GetLocalizedString("&Export Excel"), True)
        PopUp.PopUpInit(Me, WG_RPA, "AUTH_KEY")

        '20240530 김정현 Remark(사업부 탭 추가)
        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG12_ADDROW", "Add row", True)
        PopUp.ItemAdd(Action.DeleteRow, "WG12_DELETEROW", "Delete row")
        PopUp.ItemAdd(Action.Excel, "WG12_Excel", Me.Localizer.GetLocalizedString("&Export Excel"), True)
        PopUp.PopUpInit(Me, WG12, "RMK", "RMK")

    End Sub
    Public Sub GridInit()
        Dim editorCombo As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim editor As New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)
        Dim dt As DataTable = Nothing

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "T02")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV3.Columns("REQ_SVC").ColumnEdit = editorCombo

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
            GV3.Columns("REQ_SVC2").ColumnEdit = editorCombo
        End If



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
        GV3.Columns("REQ_TYPE").ColumnEdit = editorCombo


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
        GV3.Columns("REQ_TYPE2").ColumnEdit = editorCombo


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
        GV3.Columns("CUST_CD").ColumnEdit = editor


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
        GV3.Columns("REQ_USR").ColumnEdit = editor

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
        GV3.Columns("PROC_TYPE").ColumnEdit = editorCombo

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
        GV3.Columns("PRIORITY").ColumnEdit = editorCombo

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
        GV3.Columns("FREE_YN").ColumnEdit = editorCombo

        '/////////// 거래처정보 ///////////'
        'Dim dt As DataTable
        dt = GetCustomerInfo()
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        editorCombo.ShowHeader = False
        GV4.Columns("ITEM_CD").ColumnEdit = editorCombo


        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))


        AddNewRow(dt, "A", "일반")
        AddNewRow(dt, "B", "T/S")
        AddNewRow(dt, "C", "적하목록")
        AddNewRow(dt, "D", "사용종료")
        AddNewRow(dt, "E", "폐업")
        AddNewRow(dt, "F", "기타")


        CustomTypeCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        CustomTypeCombo.DisplayMember = "NAME"
        CustomTypeCombo.ValueMember = "NAME"
        CustomTypeCombo.NullText = ""
        CustomTypeCombo.DataSource = dt.Copy
        CustomTypeCombo.ShowHeader = False


        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        AddNewRow(dt, "C", "고객사")
        AddNewRow(dt, "A", "협력사")

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        GV1.Columns("CUST_TYPE").ColumnEdit = editorCombo


        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "C13")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV1.Columns("CTRT_CD").ColumnEdit = editorCombo


        '---------------------------------------------------------------
        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))
        AddNewRow(dt, "Y", "Y")
        AddNewRow(dt, "N", "N")
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV2.Columns("MAIN_YN").ColumnEdit = editorCombo

        '---------------------------------------------------------------
        'dt = New DataTable
        'dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        'dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        'AddNewRow(dt, "A", "사장")
        'AddNewRow(dt, "B", "전무")
        'AddNewRow(dt, "C", "상무")
        'AddNewRow(dt, "D", "이사")
        'AddNewRow(dt, "E", "부장")
        'AddNewRow(dt, "F", "차장")
        'AddNewRow(dt, "G", "과장")
        'AddNewRow(dt, "H", "대리")
        'AddNewRow(dt, "I", "계장")
        'AddNewRow(dt, "J", "주임")
        'AddNewRow(dt, "K", "사원")
        'AddNewRow(dt, "L", "책임")
        'AddNewRow(dt, "M", "선임")

        'editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        'editorCombo.DisplayMember = "NAME"
        'editorCombo.ValueMember = "CODE"
        'editorCombo.NullText = ""
        'editorCombo.DataSource = dt.Copy
        'editorCombo.ForceInitialize()
        'editorCombo.PopulateColumns()
        'editorCombo.Columns("CODE").Visible = False
        'editorCombo.ShowHeader = False
        'GV5.Columns("RANK").ColumnEdit = editorCombo

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "C10")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False

        GV5.Columns("RANK").ColumnEdit = editorCombo

        '---------------------------------------------------------------
        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))
        AddNewRow(dt, "Y", "Y")
        AddNewRow(dt, "N", "N")
        AddNewRow(dt, "A", "A")
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV5.Columns("MAIN_YN").ColumnEdit = editorCombo

        '---------------------------------------------------------------
        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))
        AddNewRow(dt, "A", "APP")
        AddNewRow(dt, "D", "DB")
        AddNewRow(dt, "F", "FILE")
        AddNewRow(dt, "E", "ETC")
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV2.Columns("SVR_TYPE").ColumnEdit = editorCombo

        'dt2 = New DataTable
        'dt2.Columns.Add(New DataColumn("CODE", GetType(String)))
        'dt2.Columns.Add(New DataColumn("NAME", GetType(String)))
        'AddNewRow(dt2, "A", "11g")
        'AddNewRow(dt2, "B", "10g")
        'AddNewRow(dt2, "C", "9i")
        'editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        'editorCombo.DisplayMember = "NAME"
        'editorCombo.ValueMember = "CODE"
        'editorCombo.NullText = ""
        'editorCombo.DataSource = dt2.Copy
        'editorCombo.ForceInitialize()
        'editorCombo.PopulateColumns()
        'editorCombo.Columns("CODE").Visible = False
        'editorCombo.ShowHeader = False
        'GV2.Columns("ORA_VER").ColumnEdit = editorCombo



        'EDI System Code
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = "--Select--"
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "M42")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV6.Columns("EDI_SYS_CD").ColumnEdit = editorCombo




        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = "--Select--"
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "C01")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV7.Columns("SVC_CD").ColumnEdit = editorCombo

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = "--Select--"
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "C03")
        dataParams.Add("NameType", "")
        dataParams.Add("Valid", "V")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV7.Columns("DEPT_CD").ColumnEdit = editorCombo



        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = "--Select--"
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "C05")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV8.Columns("RMK_TYPE").ColumnEdit = editorCombo


        Dim editorDate As YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
        editorDate = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
        GV1.Columns("INFO_YMD").ColumnEdit = editorDate
        GV1.Columns("STOP_YMD").ColumnEdit = editorDate
        GV8.Columns("RMK_YMD").ColumnEdit = editorDate
        GV7.Columns("CTRT_STRT_YMD").ColumnEdit = editorDate
        GV7.Columns("CTRT_END_YMD").ColumnEdit = editorDate
        GV7.Columns("TAX_START_YMD").ColumnEdit = editorDate
        GV12.Columns("RMK_YMD").ColumnEdit = editorDate



        '## 기타청구(Fax)
        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))
        AddNewRow(dt, "B", "Balsong")
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        GV9.Columns("VENDER_CD").ColumnEdit = editorCombo


        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))
        AddNewRow(dt, "R", "Receive Fax")
        AddNewRow(dt, "S", "Send Fax")
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        GV9.Columns("SVC_TYPE").ColumnEdit = editorCombo
        GV10.Columns("SVC_TYPE").ColumnEdit = editorCombo

        GV9.Columns("START_YMD").ColumnEdit = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
        GV9.Columns("END_YMD").ColumnEdit = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit


        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        AddNewRow(dt, "10000", "10,000(발신,수신)")
        AddNewRow(dt, "15000", "15,000(수신)")
        AddNewRow(dt, "5000", "5,000(수신)")

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        GV9.Columns("BASE_RATE_AMT").ColumnEdit = editorCombo

        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        AddNewRow(dt, "30", "30(발신)")
        AddNewRow(dt, "20", "20(수신)")

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        GV9.Columns("RATE_AMT").ColumnEdit = editorCombo


        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        AddNewRow(dt, "0", "0(발신)")
        AddNewRow(dt, "2000", "2,000(수신)")
        AddNewRow(dt, "1000", "1,000(수신)")
        AddNewRow(dt, "300", "300(수신)")

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        GV9.Columns("FREE_CNT").ColumnEdit = editorCombo


        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = "--Select--"
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "C09")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV11.Columns("VENDER_CD").ColumnEdit = editorCombo

        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))
        AddNewRow(dt, "SR", "S/R")
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = "--Select--"
        editorCombo.DataSource = dt.Copy
        GV11.Columns("SVC_TYPE").ColumnEdit = editorCombo

        GV11.Columns("SEND_YMD").ColumnEdit = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
        GV11.Columns("START_YMD").ColumnEdit = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
        GV11.Columns("END_YMD").ColumnEdit = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit


        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "C03")
        dataParams.Add("NameType", "")
        dataParams.Add("SearchType", "Sales")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV1.Columns("DEPT_CD").ColumnEdit = editorCombo


        GV_RPA.Columns("FM_YMD").ColumnEdit = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
        GV_RPA.Columns("TO_YMD").ColumnEdit = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
        GV_RPA.Columns("USE_YN").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit({"Y:Yes", "N:No"})

        Common.DrawRowIndicator({GV1, GV9, GV10, GV11, GV_RPA})

        '20240530 김정현 Remark(사업부) 추가
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = "--Select--"
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "C16")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV12.Columns("RMK_TYPE").ColumnEdit = editorCombo

    End Sub

    Public Sub PopUpOnAfterClick(ByVal Dr As DataRow)
        Dim r As Integer = 0
        Dim Key As String = Dr("Key")
        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing
        Select Case Dr("Action")
            Case Action.Other
                Select Case Key
                    Case "WG11_SEND_VENDER"
                        Call SendMail(SendMailType.JoinSR)
                    Case "WG2_Default"

                        Call Gv2AddRow()

                        r = GV2.FocusedRowHandle
                        GV2.SetRowCellValue(r, "SVR_TYPE", "A")
                        GV2.SetRowCellValue(r, "SVR_IP", "222.231.27.206")
                        GV2.SetRowCellValue(r, "MAIN_YN", "Y")

                        Call Gv2AddRow()
                        r = GV2.FocusedRowHandle
                        GV2.SetRowCellValue(r, "SVR_TYPE", "D")
                        GV2.SetRowCellValue(r, "SVR_IP", "222.231.28.237")
                        GV2.SetRowCellValue(r, "MAIN_YN", "Y")

                    Case "WG2_Default2"

                        Call Gv2AddRow()

                        r = GV2.FocusedRowHandle
                        GV2.SetRowCellValue(r, "SVR_TYPE", "A")
                        GV2.SetRowCellValue(r, "SVR_IP", "222.231.28.136")
                        GV2.SetRowCellValue(r, "MAIN_YN", "Y")

                        Call Gv2AddRow()
                        r = GV2.FocusedRowHandle
                        GV2.SetRowCellValue(r, "SVR_TYPE", "D")
                        GV2.SetRowCellValue(r, "SVR_IP", "222.231.28.237")
                        GV2.SetRowCellValue(r, "MAIN_YN", "Y")

                    Case "WG2_Default3"

                        Call Gv2AddRow()

                        r = GV2.FocusedRowHandle
                        GV2.SetRowCellValue(r, "SVR_TYPE", "A")
                        GV2.SetRowCellValue(r, "SVR_IP", "122.144.132.5")
                        GV2.SetRowCellValue(r, "MAIN_YN", "Y")

                        Call Gv2AddRow()
                        r = GV2.FocusedRowHandle
                        GV2.SetRowCellValue(r, "SVR_TYPE", "D")
                        GV2.SetRowCellValue(r, "SVR_IP", "122.144.132.12")
                        GV2.SetRowCellValue(r, "MAIN_YN", "Y")

                End Select
            Case Action.Addrow
                Select Case Key
                    Case "WG11_ADDROW"
                        GV11.SetFocusedRowCellValue("CUST_CD", CUST_CD.Text)
                        GV11.SetFocusedRowCellValue("SVC_TYPE", "SR")
                    Case "WG9_ADDROW"
                        GV9.SetFocusedRowCellValue("SVC_TYPE", "S")
                        GV9.SetFocusedRowCellValue("VENDER_CD", "B")
                        GV9.SetFocusedRowCellValue("START_YMD", Now.ToString("yyyyMMdd"))
                        GV9.SetFocusedRowCellValue("BASE_RATE_AMT", "10000")
                        GV9.SetFocusedRowCellValue("RATE_AMT", "30")
                    Case "WG8_ADDROW"
                        GV8.SetFocusedRowCellValue("RMK_YMD", Now.ToString("yyyyMMdd"))
                        GV8.SetFocusedRowCellValue("RMK_TYPE", "99")
                    Case "WG5_ADDROW"
                        GV5.OptionsBehavior.Editable = True
                    Case "WG2_ADDROW"
                        GV2.OptionsBehavior.Editable = True
                        '20230921 김성은,이지선 MAIN 기본값 "Y" 추가
                        GV2.SetFocusedRowCellValue("MAIN_YN", "Y")
                    Case "WG7_ADDROW"
                        GV7.SetFocusedRowCellValue("SVC_CD", "E")
                        GV7.SetFocusedRowCellValue("DEPT_CD", ClientSessionInfo.OrganizationCode)
                        GV7.SetFocusedRowCellValue("SALES_NM", ClientSessionInfo.LocalName)
                    Case "WG_RPA_ADDROW"
                        Dim mngtNo As String = String.Format("{0}{1}{2}", Format(Now, "yyyyMMddHHmmss"), Now.Millisecond.ToString.PadLeft(3, "0"), CInt(Int((99 * Rnd()) + 1)).ToString.PadLeft(3, "0"))
                        GV_RPA.SetFocusedRowCellValue("MNGT_NO", mngtNo)
                        GV_RPA.SetFocusedRowCellValue("CUST_CD", CUST_CD.Text)
                        GV_RPA.SetFocusedRowCellValue("CRN", CRN.Text)
                        GV_RPA.SetFocusedRowCellValue("CUSTOMS_CD", CUSTOMS_CD.Text)
                        GV_RPA.SetFocusedRowCellValue("FM_YMD", "")
                        GV_RPA.SetFocusedRowCellValue("TO_YMD", "")
                        GV_RPA.SetFocusedRowCellValue("AUTH_KEY", Func.encryptAES256_RPA(String.Format("{0}|{1}|{2}|{3}|{4}|{5}", mngtNo, CUST_CD.Text, CRN.Text, CUSTOMS_CD.Text, GV_RPA.GetFocusedRowCellValue("FM_YMD").ToString, GV_RPA.GetFocusedRowCellValue("TO_YMD").ToString)))
                        GV_RPA.SetFocusedRowCellValue("USE_YN", "Y")
                    Case "WG12_ADDROW" '20240530 김정현 Remark(사업부) 추가
                        GV12.SetFocusedRowCellValue("RMK_YMD", Now.ToString("yyyyMMdd"))
                        GV12.SetFocusedRowCellValue("RMK_TYPE", "99")
                End Select
            Case Action.NavigateTo
                frmMain = Me.MdiParent
                Select Case Key
                    Case "WG3_ComDocumentMgt"
                        fTarget = frmMain.NavigateTo("ComDocumentMgt", NavigatedWindowModes.Dialog, False)
                        If fTarget IsNot Nothing Then
                            fTarget.S_MNGT_NO.text = GV3.GetFocusedRowCellValue("MNGT_NO").ToString
                            fTarget.SCREEN.Text = "사이트 지원 등록"
                            fTarget.DirList.Text = "CrmAsMgt"
                            fTarget.SearchData()
                            fTarget.ShowDialog()
                        End If
                    Case "ComDocumentMgt"
                        fTarget = frmMain.NavigateTo(Key, NavigatedWindowModes.Dialog, False)
                        If Not IsNothing(fTarget) Then
                            fTarget.ParentWindow = Me
                            fTarget.S_MNGT_NO.text = GV1.GetFocusedRowCellValue("CUST_CD").ToString
                            fTarget.SCREEN.Text = "거래처관리"
                            fTarget.DirList.Text = "CrmCustomerMgt"
                            fTarget.SearchData()
                            fTarget.ShowDialog()
                            ' Call SetDocType()
                        End If
                    Case "CrmAsInput"
                        frmMain = Me.MdiParent
                        fTarget = frmMain.NavigateTo("CrmAsInput", NavigatedWindowModes.Dialog, False)
                        If Not IsNothing(fTarget) Then
                            fTarget.frmMain = frmMain
                            fTarget.REQ_YMD.Text = Now.ToString("yyyyMMdd")
                            fTarget.REQ_HM.Text = Now.ToString("HHmm")
                            fTarget.MNGT_NO.Text = ""
                            fTarget.CUST_CD.text = GV1.GetFocusedRowCellValue("CUST_CD").ToString
                            fTarget.CUST_NM.text = GV1.GetFocusedRowCellValue("CUST_NM").ToString

                            If GV5.RowCount > 0 Then
                                fTarget.OLD_CUST_CD.text = GV1.GetFocusedRowCellValue("CUST_CD").ToString
                                fTarget.OLD_REQ_USR.text = GV5.GetFocusedRowCellValue("PIC_NM").ToString
                                fTarget.REQ_USR.text = GV5.GetFocusedRowCellValue("PIC_NM").ToString
                                fTarget.TEL_NO.text = GV5.GetFocusedRowCellValue("TEL_NO").ToString
                            End If
                            fTarget.REQ_USR.Select()
                            ' fTarget.SearchData()
                            fTarget.ShowDialog()
                        End If
                    Case "ComLogMgt"
                        frmMain = Me.MdiParent
                        fTarget = frmMain.NavigateTo("ComLogMgt", NavigatedWindowModes.Dialog, False)
                        If Not IsNothing(fTarget) Then
                            'fTarget.frmMain = frmMain
                            fTarget.HBL_NO.text = GV1.GetFocusedRowCellValue("CUST_CD").ToString
                            fTarget.HBL_NO.text = GV1.GetFocusedRowCellValue("CUST_CD").ToString
                            fTarget.SearchData()
                            fTarget.ShowDialog()
                        End If
                End Select
        End Select

        GV5.OptionsBehavior.Editable = True
    End Sub

    Public Sub PopUpOnBeforeClick(ByVal dr As DataRow)
        Dim Key As String = dr("KEY")
        Dim Sender As String = ""
        If Not dr("Sender") Is System.DBNull.Value Then Sender = dr("Sender")

        Try
            'Select Case dr("Action")
            '    Case Action.NavigateTo

            'End Select
            Select Case Key
                Case "WG_RPA_ADDROW"
                    If String.IsNullOrEmpty(CUST_CD.Text) _
                               OrElse String.IsNullOrEmpty(CUSTOMS_CD.Text) _
                               OrElse String.IsNullOrEmpty(CRN.Text) Then
                        MsgBoxLocalized("거래처코드, 세관코드, 사업자번호는 필수로 입력해야 합니다.")
                        dr("Cancel") = True
                    End If
                Case "WG_RPA_DELETEROW"
                    If GV_RPA.RowCount = 0 Then
                        dr("Cancel") = True
                        Exit Sub
                    End If

                    Dim row As DataRow = GV_RPA.GetFocusedDataRow
                    If row.RowState <> DataRowState.Added Then
                        MsgBoxLocalized("추가된 행만 삭제가능 합니다.")
                        dr("Cancel") = True
                    End If
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message, MessageBoxButtons.OK, "Process failed!", MessageBoxIcon.Error)
            dr("Cancel") = True
        End Try

    End Sub

    Public Sub MenuListBeforeShow(ByVal Param As Dictionary(Of String, Boolean))
        If GV1.RowCount > 0 Then
            If GV1.GetFocusedRowCellValue("CUST_CD").ToString <> CUST_CD.Text Then
                SearchDetail(GV1.GetFocusedRowCellValue("CUST_CD").ToString)
            End If
        End If

    End Sub

    Private Sub AddNewRow(ByVal dt As DataTable, ByVal Code As String, ByVal Name As String)
        dt.Rows.Add()
        dt.Rows(dt.Rows.Count - 1)("CODE") = Code
        dt.Rows(dt.Rows.Count - 1)("NAME") = Name
    End Sub

    Public Sub Gv2AddRow()
        Dim Gv2dt As New DataTable
        Gv2dt.Columns.Add("Key")
        Gv2dt.Columns.Add("Sender")
        Gv2dt.Columns.Add("Action", GetType(Action))
        Gv2dt.Rows.Add("WG2_ADDROW", "WG2", Action.Addrow)
        WG2.AddRow()
        PopUpOnAfterClick(Gv2dt.Rows(0))
    End Sub

    Public Sub Gv7AddRow()
        Dim Gv7dt As New DataTable
        Gv7dt.Columns.Add("Key")
        Gv7dt.Columns.Add("Sender")
        Gv7dt.Columns.Add("Action", GetType(Action))
        Gv7dt.Rows.Add("WG7_ADDROW", "WG7", Action.Addrow)
        WG7.AddRow()
        PopUpOnAfterClick(Gv7dt.Rows(0))
    End Sub

    Private Function SaveFile() As Boolean

        Try
            '1. clear all temp file, to make sure same generated image index
            Dim sTempPath As String = tempRoot & "\CRM_" & CUST_CD.Text & "_files"
            If IO.Directory.Exists(sTempPath) Then IO.Directory.Delete(sTempPath, True)

            '2. Save document to HTML format, images will be saved into node_id_images
            filePath = tempRoot & "\CRM_" & CUST_CD.Text & ".html"
            RMK.SaveDocument(filePath, DocumentFormat.Html)

        Catch ex As Exception
            MsgBoxSC("Error while saving file!" & ex.Message)
            Return False
        End Try

        Return True
    End Function

    Public Function GetCurrentRange() As DocumentRange
        Dim range As DocumentRange = RMK.Document.Selection
        If RMK.Document.Selection.Start = RMK.Document.Selection.End Then
            range = RMK.Document.CreateRange(RMK.Document.Selection.Start, 1)
        End If
        Return range
    End Function

    Public Sub clearRTF()

        RMK.CreateNewDocument()

    End Sub

    Private Sub DefineAbstractList(ByVal doc As Document)
        doc.BeginUpdate()
        'Describe the pattern used for the numbered list.
        'Specify parameters used to represent each list level.

        Dim list As AbstractNumberingList = RMK.Document.AbstractNumberingLists.Add()
        list.NumberingType = NumberingType.Bullet

        Dim level As ListLevel = list.Levels(0)
        level.ParagraphProperties.LeftIndent = 0
        level.DisplayFormatString = ""

        level = list.Levels(1)
        level.ParagraphProperties.LeftIndent = 75
        level.Start = 1
        level.NumberingFormat = NumberingFormat.Decimal
        level.DisplayFormatString = "{1}"

        level = list.Levels(2)
        level.ParagraphProperties.LeftIndent = 75
        level.CharacterProperties.FontName = "Symbol"
        level.DisplayFormatString = New String(ChrW(&HB7), 1)

        doc.EndUpdate()
    End Sub

    Private Sub AddBulletedListToDocument()
        Dim doc As Document = RMK.Document
        ' Define an abstract numbered list and add it to the document.
        DefineAbstractList(doc)
        ' Create a numbering list. It is based on a previously defined abstract list with ID = 0.
        doc.NumberingLists.Add(0)
    End Sub

    Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Me.ActiveControl Is RMK Then
            Exit Sub
        Else
            MyBase.OnKeyPress(e)
        End If
    End Sub

    Private Function GetCustomerInfo() As DataTable
        '/////////// 거래처정보 ///////////'
        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        AddNewRow(dt, "01", "ACCOUNT")
        AddNewRow(dt, "02", "AIR")
        AddNewRow(dt, "03", "SEA")
        AddNewRow(dt, "04", "인사급여")
        AddNewRow(dt, "05", "쿠리어")
        AddNewRow(dt, "06", "AEO인증업체")
        AddNewRow(dt, "07", "ETC")

        Return dt
    End Function

    Public Sub SetCustomerInfo()

        Exit Sub

        Dim dt As DataTable = GetCustomerInfo()

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim Code As String = dt.Rows(i)("CODE")
            Dim Exist As Boolean = False
            For j As Integer = 0 To GV4.RowCount - 1

                If GV4.GetRowCellValue(j, "ITEM_CD") = Code Then
                    Exist = True
                    Exit For
                End If
            Next
            If Exist = False Then
                WG4.AddRow()
                GV4.SetFocusedRowCellValue("ITEM_CD", Code)
            End If
        Next
        GV4.Columns("ITEM_CD").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
    End Sub

    Private Function GetSettlementDayInfo() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        AddNewRow(dt, "", "--Select--")
        AddNewRow(dt, "7일", "7일")
        AddNewRow(dt, "30일", "30일")
        AddNewRow(dt, "45일", "45일")
        AddNewRow(dt, "60일", "60일")
        AddNewRow(dt, "기타", "기타")

        Return dt
    End Function


    Public Function MandatoryGridValue(ByVal gridView As String) As Boolean
        Dim Param As New Dictionary(Of String, Object)
        Dim checkNull() As String = Nothing

        Select Case gridView
            Case "GV2"
                checkNull = {"SVR_TYPE"}
                Param("SVR_TYPE") = GV2_SVR_TYPE.Caption
                Param("SVR_IP") = GV2_SVR_IP.Caption
                'Param("SVR_DESC") = GV2_SVR_DESC.Caption

                Return ValidateGridValue(GV2, Param, checkNull)
            Case "GV4"
                checkNull = {"ITEM_CD"}
                Param("ITEM_CD") = GV4_ITEM_CD.Caption
                Param("CUST_CD") = GV4_ITEM_CD.Caption

                Return ValidateGridValue(GV4, Param, checkNull)
            Case "GV5"
                checkNull = {"PIC_NM"}
                Param("PIC_NM") = GV5_PIC_NM.Caption
                'Param("TEL_NO") = GV5_PIC_NM.Caption
                'Param("EMAIL") = GV5_PIC_NM.Caption

                Return ValidateGridValue(GV5, Param, checkNull)
            Case "GV6"
                checkNull = {"EDI_SYS_CD"}
                Param("EDI_SYS_CD") = GV6_EDI_SYS_CD.Caption
                'Param("ID") = GV6_ID.Caption

                Return ValidateGridValue(GV6, Param, checkNull)
            Case "GV7"
                checkNull = {""}
                Param("SVC_CD") = GV7_SVC_CD.Caption

                Return ValidateGridValue(GV7, Param, checkNull)
            Case "GV8"
                checkNull = {"RMK"}
                Param("RMK") = GV8_RMK.Caption

                Return ValidateGridValue(GV8, Param, checkNull)
            Case "GV12" '20240530 김정현 Remark(사업부) 추가
                checkNull = {"RMK"}
                Param("RMK") = GV12_RMK.Caption

                Return ValidateGridValue(GV12, Param, checkNull)
        End Select

        Return True

    End Function

#End Region

#Region "=================Data logic actions==========="

    Private Sub NewData()

        'ClearView(UI.AppliedRangeTypes.Except, {SEARCH_KEY, S_SVC_CD, S_USE_YN, S_CUST_TYPE, S_CUST_TYPE, S_INFO_TYPE, S_INFO_YN})
        ResetView(UI.AppliedRangeTypes.Except, {SEARCH_TYPE, SEARCH_KEY, S_SVC_CD, S_USE_YN, S_CUST_TYPE, S_CUST_TYPE, S_INFO_TYPE, S_INFO_YN})

        Call clearRTF()
        Call SetDefault()

        'CTRY_CD.SelectedValue = "KR"
        'LANG_CD.SelectedValue = "ko-KR"
        'USE_YN.SelectedValue = "Y"
        'MATN_YN.SelectedValue = "Y"
        'TBL_CHG_YN.SelectedValue = "Y"
        'CREDIT_DAYS.Text = 3
        'CUST_TYPE.SelectedValue = "C"
        'CTRT_CD.SelectedValue = "P"
        'BILG_CD.SelectedValue = "KR"
        'BANK_TYPE.SelectedValue = "A"
        'BANK_DAY.SelectedValue = "25"

        'CUST_CD.ReadOnly = False

        Call Gv7AddRow()

        CUST_LOC_NM.Select()

    End Sub

    Public Sub SearchData()
        If SearchValidate() = False Then Exit Sub

        Dim dsRet As DataSet = GetConvertToDataSet()

        dsRet = MethodCallEx(Me, "YJIT.Biz.CrmAsMgt", "Search", {dsRet})
        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case drPairs("TrxCode")
            Case "Y"
                'Me.ClearView(UI.AppliedRangeTypes.Except, {SEARCH_KEY, S_SVC_CD, S_USE_YN, S_CUST_TYPE, S_INFO_TYPE, S_INFO_YN})
                Me.ResetView(UI.AppliedRangeTypes.Except, {SEARCH_TYPE, SEARCH_KEY, S_SVC_CD, S_USE_YN, S_CUST_TYPE, S_INFO_TYPE, S_INFO_YN})
                RMK.CreateNewDocument()
                Me.BindToDataset(dsRet, "Data")

                GV1.BestFitColumns()
                'If GV1.FocusedRowHandle > 0 Then
                If GV1.RowCount > 0 Then Call SearchDetail(GV1.GetFocusedRowCellValue("CUST_CD").ToString)
                'End If
                Me.DataState = UI.DataStates.Retrieved

            Case "N"
                'Me.ClearView(UI.AppliedRangeTypes.Except, {SEARCH_KEY, S_SVC_CD, S_USE_YN, S_CUST_TYPE, S_INFO_TYPE, S_INFO_YN})
                Me.ResetView(UI.AppliedRangeTypes.Except, {SEARCH_TYPE, SEARCH_KEY, S_SVC_CD, S_USE_YN, S_CUST_TYPE, S_INFO_TYPE, S_INFO_YN})
                RMK.CreateNewDocument()
                MsgBoxLocalized(drPairs("TrxMsg"))
                'Call ClearView(AppliedRangeTypes.Only, {WG1})
                Call ResetView(AppliedRangeTypes.Only, {WG1})

                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(drPairs("TrxMsg"))
        End Select

    End Sub
    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

        Try
            'If String.IsNullOrEmpty(S_COMN_CD.SelectedValue.ToString) Then
            '    If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
            '    If ErrControl Is Nothing Then ErrControl = S_COMN_CD
            '    ErrMsg &= "Please input the [Mapping Type]" & vbNewLine
            'End If

            If Not String.IsNullOrEmpty(ErrMsg) Then
                If Not ErrTabPage Is Nothing Then xtcMAIN.SelectedTabPage = ErrTabPage
                If Not ErrControl Is Nothing Then ErrControl.Focus()
                Throw New Exception(ErrMsg)
            End If

            Return True
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
    End Function

    Public Sub SearchDetail(ByVal CustCode As String)
        Try
            If GV1.RowCount = 0 Then Exit Sub

            'ClearView(UI.AppliedRangeTypes.Except, {WG1, SEARCH_KEY, S_SVC_CD, S_USE_YN, S_CUST_TYPE, CUST_CD, S_CUST_TYPE, S_INFO_TYPE, S_INFO_YN})
            ResetView(UI.AppliedRangeTypes.Except, {WG1, SEARCH_TYPE, SEARCH_KEY, S_SVC_CD, S_USE_YN, S_CUST_TYPE, CUST_CD, S_CUST_TYPE, S_INFO_TYPE, S_INFO_YN})

            filePath = tempRoot & "\CRM_" & CUST_CD.Text & ".html"

            Dim params() As Object = {CustCode}
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.CrmCustomerMgt", "SearchDetail", params, AddressOf SearchOnComplete2)

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Sub SearchOnComplete2(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)

        Try
            If IsNothing(e.Result) Then
                Throw New Exception("Try Again!")
            End If
            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Search", MessageBoxIcon.Warning)
                Exit Sub
            End If
            Me.BindToDataset(ds, "Data")

            WG_RPA.Enabled = False

            GV2.BestFitColumns()
            GV4.BestFitColumns()
            GV5.BestFitColumns()

            Dim dt As DataTable = ds.Tables("Data.Main")

            IO.File.WriteAllText(filePath, dt.Rows(0)("RMK") & "")

            '2. check if the local _files not exists, download from server
            Dim sLocalPath As String = tempRoot & "\CRM_" & CUST_CD.Text & "_files\"
            If Not IO.Directory.Exists(sLocalPath) Then
                'Create local path
                IO.Directory.CreateDirectory(sLocalPath)
            End If

            'Download all files from corresponding path on server
            Dim sSmartHelpHome As String = YJIT.SC.WCF.WCFBiz.Instance.WCFHomeUrl & "CRM/"

            Dim wc As New System.Net.WebClient
            Dim sResult As String = wc.DownloadString(sSmartHelpHome & "FolderManifest.aspx?FolderURI=" & "Data/CRM_" & CUST_CD.Text & "_files/")

            If sResult.StartsWith("OK") Then
                Dim files() As String = sResult.Split(vbCrLf)
                For i As Integer = 1 To files.Count - 1  'first line is "OK"
                    If files(i).Trim = "" Then Continue For
                    Try
                        If files(i).Trim <> "Thumbs.db" Then
                            wc.DownloadFile(sSmartHelpHome & "Data/CRM_" & CUST_CD.Text & "_files/" & files(i).Trim, sLocalPath & files(i).Trim)
                        End If
                    Catch ex As Exception
                        MsgBoxSC("Download failed!" & sSmartHelpHome & "Data/CRM_" & CUST_CD.Text & "_files/" & files(i).Trim)
                    End Try
                Next
            End If

            '3. Load content to editor
            RMK.LoadDocument(filePath, DocumentFormat.Html)
            RMK.ReadOnly = False

            'CUST_CD.ReadOnly = True

            Me.DataState = UI.DataStates.Retrieved

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub

    Public Sub SaveData()
        If SaveValidate() = False Then Exit Sub

        If MandatoryGridValue("GV2") Then
            xtcSUB.SelectedTabPage = xtpServer
            Exit Sub
        End If
        If MandatoryGridValue("GV4") Then
            xtcSUB.SelectedTabPage = xtpItem
            Exit Sub
        End If
        If MandatoryGridValue("GV5") Then
            xtcMAIN.SelectedTabPage = xtpPIC
            Exit Sub
        End If
        If MandatoryGridValue("GV6") Then
            xtcSUB.SelectedTabPage = xtpEDI
            Exit Sub
        End If
        If MandatoryGridValue("GV7") Then
            xtcMAIN.SelectedTabPage = xtpCustomer
            Exit Sub
        End If
        If MandatoryGridValue("GV8") Then
            xtcMEMO.SelectedTabPage = xtpRmkList
            Exit Sub
        End If
        '김정현 REMARK(사업부) 탭 추가
        If MandatoryGridValue("GV12") Then
            xtcMEMO.SelectedTabPage = xtpRmkSales
            Exit Sub
        End If

        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.YesNo) = MsgBoxResult.No Then Exit Sub


        If SaveFile() = False Then Exit Sub

        Dim ds As DataSet = New DataSet
        ds = Me.ConvertToDataset
        ds.Tables("MAIN").Columns.Add("RMK")
        ds.Tables("MAIN").Rows(0)("RMK") = IO.File.ReadAllText(filePath)

        Dim params() As Object = {ds}

        Dim dsResult As DataSet
        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmCustomerMgt", "Save", params)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow
        dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") = "Y" Then
            Me.BindToDataset(dsResult, "Data")
            Me.DataState = UI.DataStates.Retrieved
        Else
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If

        '3. Preparlist of upload file==================================
        Dim arlUploadClient As New ArrayList
        'Image files are stored in NODE_ID_files
        Dim sUpdPath As String = tempRoot & "\CRM_" & CUST_CD.Text & "_files\"
        If IO.Directory.Exists(sUpdPath) Then
            Try
                'For directory, we list all file within that directory
                Dim files() As String = Directory.GetFiles(sUpdPath, "*.*", SearchOption.AllDirectories)
                For Each sFile As String In files
                    arlUploadClient.Add(sFile)
                Next
            Catch ex As Exception
                MsgBoxSC("Error while preparing file list!" & vbCrLf & ex.StackTrace)
                Exit Sub
            End Try

            Dim dlg As New CrmCustomerUpload
            dlg.ArlClientFiles = arlUploadClient
            dlg.BoardId = CUST_CD.Text

            dlg.ShowDialog()
        End If
        MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Confirm", MessageBoxIcon.Information)


        For i As Integer = 0 To GV1.RowCount - 1
            If GV1.GetRowCellValue(i, "CUST_CD").ToString = CUST_CD.Text Then
                GV1.FocusedRowHandle = i
            End If
        Next

    End Sub
    Private Function SaveValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing
        Dim ErrGrid As Object = Nothing
        Dim ErrGridRow As Integer = Nothing
        Dim ErrGridColName As String = String.Empty

        Try
            If CREDIT_DAYS.Text = 0 Then CREDIT_DAYS.Text = 3

            'If String.IsNullOrEmpty(CUST_CD.Text.ToString) Then
            '    If ErrTabPage Is Nothing Then ErrTabPage = xtpCustomer
            '    If ErrControl Is Nothing Then ErrControl = CUST_CD
            '    ErrMsg &= "Please input the [" & lbl_CUST_CD.Text & "]" & vbNewLine
            'End If

            If String.IsNullOrEmpty(CUST_LOC_NM.Text.ToString) Then
                If ErrTabPage Is Nothing Then ErrTabPage = xtpCustomer
                If ErrControl Is Nothing Then ErrControl = CUST_LOC_NM
                'ErrMsg &= "Please input the [" & lbl_CUST_LOC_NM.Text & "]" & vbNewLine
                ErrMsg &= "[" & lbl_CUST_LOC_NM.Text & "] 자료를 입력해주세요." & vbNewLine
            End If

            If String.IsNullOrEmpty(CEO.Text) Then
                'ErrMsg &= "Please input the [CEO]" & vbNewLine
                ErrMsg &= "[" & lbl_CEO.Text & "] 자료를 입력해주세요." & vbNewLine
            End If

            If String.IsNullOrEmpty(E_MAIL.Text) Then
                'ErrMsg &= "Please input the [E_MAIL]" & vbNewLine
                ErrMsg &= "[" & lbl_E_MAIL.Text & "] 자료를 입력해주세요." & vbNewLine
            End If

            If String.IsNullOrEmpty(USE_YN.SelectedValue) Then
                ErrMsg &= "[사용] 여부를 선택해주세요." & vbNewLine
            End If

            If String.IsNullOrEmpty(MATN_YN.SelectedValue) Then
                ErrMsg &= "[유지] 여부를 선택해주세요." & vbNewLine
            End If

            If String.IsNullOrEmpty(CUST_TYPE.SelectedValue) Then
                ErrMsg &= "[" & lbl_CUST_TYPE.Text & "] 을 선택해주세요." & vbNewLine
            End If

            If String.IsNullOrEmpty(CTRY_CD.SelectedValue) Then
                ErrMsg &= "[" & lbl_CTRY_CD.Text & "] 을 선택해주세요." & vbNewLine
            End If

            If CTRY_CD.SelectedValue = "KR" Then
                If String.IsNullOrEmpty(CRN.Text.ToString) Then
                    If ErrTabPage Is Nothing Then ErrTabPage = xtpCustomer
                    If ErrControl Is Nothing Then ErrControl = CRN
                    'ErrMsg &= "Please input the [" & lbl_CRN.Text & "]" & vbNewLine
                    ErrMsg &= "[" & lbl_CRN.Text & "] 자료를 입력해주세요." & vbNewLine
                End If
            End If

            If GV7.RowCount = 0 Then
                If ErrTabPage Is Nothing Then ErrTabPage = xtpCustomer
                If ErrControl Is Nothing Then ErrControl = WG7
                ErrMsg &= "[시스템] 자료를 입력해주세요." & vbNewLine
            End If


            Dim ds As DataSet = Me.ConvertToDataset

            For Each dr As DataRow In ds.Tables("WG9").Rows
                If dr("SVC_TYPE").ToString = "R" Then
                    If Mid(dr("START_YMD").ToString, 7, 2) <> "01" Then
                        For i = 0 To GV9.RowCount - 1
                            If GV9.GetRowCellValue(i, "FAX_NO").ToString = dr("FAX_NO").ToString AndAlso Not String.IsNullOrEmpty(GV9.GetRowCellValue(i, "END_YMD").ToString) Then
                                ErrMsg &= "수신요금제 변경시 익월 1일 기준으로만 변경가능합니다. 시작일자 변경후 저장하세요." & vbNewLine
                                If ErrTabPage Is Nothing Then ErrTabPage = xtpFax
                                If ErrGrid Is Nothing Then
                                    ErrGrid = GV9
                                    For j = 0 To GV9.RowCount - 1
                                        If GV9.GetRowCellValue(j, "SEQ").ToString = dr("SEQ").ToString Then
                                            ErrGridRow = j
                                            Exit For
                                        End If
                                    Next
                                    ErrGridColName = "START_YMD"
                                End If
                                If Not ErrGrid Is Nothing Then Exit For
                            End If
                        Next
                        If Not ErrGrid Is Nothing Then Exit For
                    End If
                End If
            Next



            If Not String.IsNullOrEmpty(ErrMsg) Then
                If Not ErrTabPage Is Nothing Then xtcMAIN.SelectedTabPage = ErrTabPage
                If Not ErrControl Is Nothing Then
                    ErrControl.Focus()
                Else
                    If Not ErrGrid Is Nothing Then
                        ErrGrid.FocusedRowHandle = ErrGridRow
                        ErrGrid.FocusedColumn = ErrGrid.Columns(ErrGridColName)
                        ErrGrid.ShowEditor()
                    End If
                End If
                Throw New Exception(ErrMsg)
            End If

            Return True
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
    End Function

    Private Sub DeleteData()
        Dim ds As DataSet
        Dim dr As DataRow
        Dim insFlag As String = ""

        Try
            If MsgBoxLocalized("Do you want to delete?", MessageBoxButtons.YesNo, "Delete", MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.No Then Exit Sub
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmCustomerMgt", "Delete", Me.ConvertToDataset)

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

    Public Sub PrintData()

        If CUST_CD.Text = "" Then Exit Sub

        If MsgBoxLocalized("Do you want to print?", MessageBoxButtons.YesNo, "Confirm", MessageBoxIcon.Question) = MsgBoxResult.No Then Exit Sub

        Dim dt As DataTable = Nothing
        Dim FileName As String = ""
        Dim ds As DataSet = Nothing

        Dim params() As Object = {CUST_CD.Text}

        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.CrmCustomerMgt", "Print", params, AddressOf PrintOnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub
    Private Sub PrintOnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)

        Dim dsRet As DataSet = e.Result
        Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        Dim rpt As DevExpress.XtraReports.UI.XtraReport
        Dim FileName As String = ""
        Dim RptParameters As New Dictionary(Of String, Object)

        If dr("TrxCode") <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Print", MessageBoxIcon.Error)
        End If

        Try
            FileName = "ElvisJoinForm.repx"

            rpt = RptBaseSetting("CRM", FileName, dsRet, RptParameters)

            If rpt IsNot Nothing Then
                ReportPrintTool(rpt)
            End If
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub

    Public Sub Execute()
        If ExecuteValidate() = False Then Exit Sub

        Dim ds As DataSet = Me.ConvertToDataset
        '20220721 정지수 DB LINK ELVIS_PLUS 추가 YJITS2022070292
        ds.Tables("MAIN").Columns.Add("SVC_CD")
        ds.Tables("MAIN").Rows(0)("SVC_CD") = GV7.GetRowCellValue(0, "SVC_CD").ToString

        Dim dsResult As DataSet

        If MsgBoxLocalized("Do you want to execute queries?", MessageBoxButtons.YesNo) = MsgBoxResult.No Then Exit Sub

        Try
            dsResult = Common.MethodCallEx(Me, "YJIT.Biz.CrmCustomerMgt", "Execute", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow
        dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)

        MsgBoxLocalized(dr("TrxMsg"))

    End Sub
    Private Function ExecuteValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

        Try
            If String.IsNullOrEmpty(DOMAIN.Text.ToString) Then
                If ErrControl Is Nothing Then ErrControl = DOMAIN
                ErrMsg &= "Please input the [" & lbl_DOMAIN.Text & "]" & vbNewLine
            End If

            If String.IsNullOrEmpty(ELVIS_OFFICE_CD.Text.ToString) Then
                If ErrControl Is Nothing Then ErrControl = DOMAIN
                ErrMsg &= "Please input the [" & lbl_ELVIS_OFFICE_CD.Text & "]" & vbNewLine
            End If

            If Not String.IsNullOrEmpty(ErrMsg) Then
                If Not ErrTabPage Is Nothing Then xtcMAIN.SelectedTabPage = ErrTabPage
                If Not ErrControl Is Nothing Then ErrControl.Focus()
                Throw New Exception(ErrMsg)
            End If

            Return True
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
    End Function

    Private Sub PrintCertificate(ByVal vKind As String)
        Dim ds As DataSet = Me.ConvertToDataset
        Dim MsgRtn As Object = Nothing

        MsgRtn = MsgBoxLocalized("Print Preview?", MessageBoxButtons.YesNoCancel, "Comfirm", MessageBoxIcon.Question)
        If MsgRtn = MsgBoxResult.Cancel Then
            Exit Sub
        End If

        Dim rpt As DevExpress.XtraReports.UI.XtraReport = Nothing

        '2018.10.16 허진욱 vKind 인자추가. WMS,TMS 레포트 추가.
        Select Case vKind
            Case "F" : rpt = RptBaseSetting("STL", "Certificate.repx", ds)
            Case "T" : rpt = RptBaseSetting("STL", "CertificateTMS.repx", ds)
            Case "W" : rpt = RptBaseSetting("STL", "CertificateWMS.repx", ds)
        End Select

        ReportPrintTool(rpt)
    End Sub
    '20240425 김정현 미수금액 갱신 로직 추가
    Private Sub RefreshRecAmt(ByVal CRN As String, ByVal CustCd As String)
        Dim ds As DataSet = New DataSet
        Dim params() As Object = {CRN, CustCd}

        If MsgBoxLocalized("Do you want to refresh outstandings?", MessageBoxButtons.YesNo) = MsgBoxResult.No Then Exit Sub

        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmCustomerMgt", "RefreshRecAmt", params)

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow
        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") = "Y" Then
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK)
        Else
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
        End If
        SearchDetail(GV1.GetFocusedRowCellValue("CUST_CD").ToString)
    End Sub

#End Region

#Region "=================Control Events==========="
    Private Sub CrmCustomerMgt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case ClientSessionInfo.OrganizationCode
            Case "04", "06", "08"
                CREDIT_DAYS.Enabled = True
                CREDIT_DAYS.ReadOnly = False
                CREDIT_AMT.Enabled = True
                CREDIT_AMT.ReadOnly = False
                CREDIT_YMD.Enabled = True
                CREDIT_YMD.ReadOnly = False
                CREDIT_PIC_NM.Enabled = True
                CREDIT_PIC_NM.ReadOnly = False
            Case Else
                CREDIT_DAYS.Enabled = False
                CREDIT_DAYS.ReadOnly = True
                CREDIT_AMT.Enabled = False
                CREDIT_AMT.ReadOnly = True
                CREDIT_YMD.Enabled = False
                CREDIT_YMD.ReadOnly = True
                CREDIT_PIC_NM.Enabled = False
                CREDIT_PIC_NM.ReadOnly = True
        End Select

        '팩스셋팅 / 솔루션운영팀, 솔루션사업팀만 활성
        Select Case ClientSessionInfo.OrganizationCode
            Case "01", "04", "08"
                GV9.OptionsBehavior.Editable = True
                GV9.OptionsBehavior.ReadOnly = False
            Case Else
                GV9.OptionsBehavior.Editable = False
                GV9.OptionsBehavior.ReadOnly = True
        End Select

        Select Case ClientSessionInfo.OrganizationCode
            Case "01", "04", "08"
                USER_QTY.Enabled = True
                USER_QTY.ReadOnly = False
                btnUpdateElvis.Enabled = True
            Case Else
                USER_QTY.Enabled = False
                USER_QTY.ReadOnly = True
                btnUpdateElvis.Enabled = False
        End Select

        If Not IO.Directory.Exists(tempRoot) Then IO.Directory.CreateDirectory(tempRoot)

    End Sub
    Private Sub CrmCustomerMgt_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Call SetDefault()
        Call GridInit()

        AddBulletedListToDocument()

        'STLE_YMD.DataSource = GetSettlementDayInfo()
        Call PopupInit()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Call NewData()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Call PrintData()
    End Sub

    Private Sub btnUpdateElvis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateElvis.Click
        Call Execute()
    End Sub

    Private Sub btnClipboardElvisSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Clipboard.SetText("Elvis 설치정보" & vbCrLf & "설치 URL : " & SETUP_URL.Text & vbCrLf & "도메인 : " & DOMAIN.Text)
    End Sub

    Private Sub btnMailElvisSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMailElvisSetting.Click
        Call SendMail(SendMailType.SettingELVIS)
    End Sub

    Private Sub btnExecuteElvis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExecuteElvis.Click
        Call ExecuteElvis(DOMAIN.Text)
    End Sub

    Private Sub btnSetupKey_Click(sender As System.Object, e As System.EventArgs) Handles btnSetupKey.Click
        Dim csSetupKey As String = String.Empty
        Dim randomNum As Integer

        Randomize()
        randomNum = Int(Rnd() * 26) + 1
        csSetupKey &= Chr(64 + randomNum)

        Randomize()
        randomNum = Int(Rnd() * 26) + 1
        csSetupKey &= Chr(64 + randomNum)

        Randomize()
        randomNum = Int(Rnd() * 26) + 1
        csSetupKey &= Chr(64 + randomNum)

        Randomize()
        randomNum = Int(Rnd() * 100) + 1
        csSetupKey &= randomNum.ToString.PadLeft(3, "0")

        CS_SETUP_KEY.Text = csSetupKey.ToUpper
        CS_SETUP_CNT.Text = USER_QTY.Text
    End Sub
    Private Sub btnSearchRPA_Click(sender As Object, e As EventArgs) Handles btnSearchRPA.Click
        Try
            If GV1.RowCount = 0 Then Exit Sub
            ResetView(UI.AppliedRangeTypes.Only, {WG_RPA})
            Dim params() As Object = {CUST_CD.Text}
            Dim ds As DataSet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmCustomerMgt", "SearchDetailRPA", params)
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
            Me.BindToDataset(ds, "Data")
            WG_RPA.Enabled = True
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Sub ExecuteElvis(ByVal Domain As String)
        Dim SavedAppPath As String = String.Empty
        Dim drAPP() As DataRow = CType(WG2.DataSource, DataTable).Select("SVR_TYPE = 'A' AND DB_TNS = '" & Domain & "'")

        For Each dr As DataRow In drAPP
            SavedAppPath = "HTTP://" & dr("SVR_IP").ToString & ":" & dr("DB_PORT").ToString & "/wcf/client/" & dr("DB_SID").ToString & ".application#" & dr("DB_SID").ToString & ".application"
            Call ExecuteElvisEx(dr("DB_TNS").ToString, dr("DB_ID").ToString, dr("DB_PWD").ToString, dr("DB_SID").ToString, SavedAppPath)
        Next
    End Sub

    Private Sub ExecuteElvisEx(ByVal Domain As String, ByVal SavedUserID As String, ByVal SavedUserPwd As String, ByVal AssemblyName As String, ByVal SavedAppPath As String)
        Dim FileName As String = String.Empty

        SetDomain(AssemblyName, "SavedSessionDomain", Domain)
        SetDomain(AssemblyName, "SavedUserID", SavedUserID)
        SetDomain(AssemblyName, "SavedUserPwd", SavedUserPwd)
        FileName = AssemblyName & ".appref-ms"

        Dim CreateFilePath As String = Application.StartupPath & "\Temp\"
        If Not FileIO.FileSystem.DirectoryExists(CreateFilePath) Then
            FileIO.FileSystem.CreateDirectory(CreateFilePath)
        End If
        FileIO.FileSystem.WriteAllText(CreateFilePath & FileName, SavedAppPath, False)

        Try
            Dim proc As New System.Diagnostics.Process()
            proc = Process.Start(CreateFilePath & FileName, "")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '레지값에 셋팅
    Public Shared Sub SetDomain(ByVal AssemblyName As String, Optional ByVal Key As String = "", Optional ByVal value As String = "")
        Dim sAppRootPath As String = ""
        sAppRootPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        If Not sAppRootPath.EndsWith("\") Then sAppRootPath &= "\"
        sAppRootPath &= "YJIT.SC Home\" & AssemblyName & "\"
        SaveUserSetting(Key, value, sAppRootPath)
    End Sub

    Public Shared Sub SaveUserSetting(ByVal sKey As String, ByVal sValue As String, ByVal sAppRootPath As String)
        Dim regKey As Microsoft.Win32.RegistryKey
        regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE", True)
        regKey.CreateSubKey("YJIT.SC.Home\" & sAppRootPath)
        regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\YJIT.SC.Home\" & sAppRootPath, True)
        Try
            regKey.SetValue(sKey, sValue)
        Catch ex As Exception
            'Unable to save user preference
        Finally
            regKey.Close()
        End Try
    End Sub


    Private Sub SendMail(ByVal SendType As SendMailType)
        If SendMailValidate(SendType) = False Then Exit Sub

        Select Case SendType
            Case SendMailType.SettingELVIS
                Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
                Dim fTarget As Object = Nothing
                frmMain = Me.MdiParent
                fTarget = frmMain.NavigateTo("ComSendMail", NavigatedWindowModes.Dialog, False)
                If Not IsNothing(fTarget) Then
                    fTarget.S_CUST_CD.TEXT = CUST_CD.Text
                    fTarget.S_MSG_TYPE.Text = "001" '설치안내
                    fTarget.S_MSG_TYPE2.Text = "001"
                    fTarget.ShowDialog()
                End If
            Case SendMailType.JoinSR
                Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
                Dim fTarget As Object = Nothing
                frmMain = Me.MdiParent
                fTarget = frmMain.NavigateTo("ComSendMail", NavigatedWindowModes.Dialog, False)
                If Not IsNothing(fTarget) Then
                    fTarget.S_CUST_CD.TEXT = CUST_CD.Text
                    fTarget.S_MSG_TYPE.Text = "010" 'S/R신청요청
                    fTarget.S_MSG_TYPE2.Text = "010" '기본요청
                    fTarget.ShowDialog()
                End If
        End Select
    End Sub

    Private Function SendMailValidate(ByVal SendType As SendMailType) As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

        Try
            If String.IsNullOrEmpty(CUST_CD.Text) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = CUST_CD
                ErrMsg &= "Please input the [" & lbl_CUST_CD.Text & "]" & vbNewLine
            End If

            Select Case SendType
                Case SendMailType.SettingELVIS
                    If String.IsNullOrEmpty(SETUP_URL.Text) Then
                        'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                        If ErrControl Is Nothing Then ErrControl = SETUP_URL
                        ErrMsg &= "Please input the [" & lbl_SETUP_URL.Text & "]" & vbNewLine
                    End If
                Case SendMailType.JoinSR
                    If GV11.RowCount = 0 Then
                        If ErrTabPage Is Nothing Then ErrTabPage = xtpJoin
                        If ErrControl Is Nothing Then ErrControl = WG11
                        ErrMsg &= "Please input the [" & xtpJoin.Text & "]" & vbNewLine
                    End If
            End Select


            If Not String.IsNullOrEmpty(ErrMsg) Then
                If Not ErrTabPage Is Nothing Then xtcMAIN.SelectedTabPage = ErrTabPage
                If Not ErrControl Is Nothing Then ErrControl.Focus()
                Throw New Exception(ErrMsg)
            End If

            Return True
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
    End Function

    Private Sub SEARCH_KEY_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles SEARCH_KEY.PreviewKeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) Then
            Call SearchData()
        End If
    End Sub

    Private Sub CUST_CD_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CUST_CD.PreviewKeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And CUST_CD.Text <> "" Then
            Call SearchDetail(CUST_CD.Text)
        End If
    End Sub

    Private Sub xtcMAIN_TabIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xtcMAIN.TabIndexChanged
        If xtcMAIN.SelectedTabPage Is xtpBank Then
            BANK_YN.Focus()
        ElseIf xtcMAIN.SelectedTabPage Is xtpContract Then
            CTRT_CD.Focus()
        ElseIf xtcMAIN.SelectedTabPage Is xtpPIC Then
            '
        ElseIf xtcMAIN.SelectedTabPage Is xtpCustomer Then
            CUST_CD.Focus()
        ElseIf xtcMAIN.SelectedTabPage Is xtpJoin Then

        End If
    End Sub

    Private Sub SET_URL_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SET_URL.SelectedValueChanged
        If SET_URL.SelectedValue = "" Then Exit Sub

        SETUP_URL.Text = SET_URL.Text
    End Sub

    Private Sub CREDIT_YMD_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CREDIT_YMD.Validating
        If DB_CREDIT_YMD.Text = "29990101" And CREDIT_YMD.Text = "29990101" Then Exit Sub
        If ClientSessionInfo.OrganizationCode = "06" Then Exit Sub '20171018 김성은 경영기획에서는 기간상관없이 일자 입력할수 있도록 수정 수정


        If Not String.IsNullOrEmpty(CREDIT_YMD.Text) Then
            Dim CreditYmd As String = Mid(CREDIT_YMD.Text, 1, 4) & "-" & Mid(CREDIT_YMD.Text, 5, 2) & "-" & Mid(CREDIT_YMD.Text, 7, 2)
            Dim StopYmd As String = Mid(STOP_YMD.Text, 1, 4) & "-" & Mid(STOP_YMD.Text, 5, 2) & "-" & Mid(STOP_YMD.Text, 7, 2)
            If IsDate(CreditYmd) Then
                Dim CreditMaxYmd As String = String.Empty
                If IsDate(StopYmd) AndAlso Now.ToString("yyyyMMdd") >= "20170213" Then
                    CreditMaxYmd = CDate(DateAdd(DateInterval.Day, 30, CDate(StopYmd))) '중지일자 기준으로 적용
                Else
                    CreditMaxYmd = CDate(DateAdd(DateInterval.Day, 30, Now)) '한시적으로 현재 일자기준으로 30일 이내 입력 제한
                End If
                If CDate(CreditYmd) > CDate(CreditMaxYmd) Then
                    Dim ErrMsg As String = String.Format("중지일자({0}) 기준 최대 30일까지 입력가능합니다. 보류일자를 {1}로 변경하시겠습니까?", StopYmd, Format(CDate(CreditMaxYmd), "yyyy-MM-dd"))
                    If MsgBoxLocalized(ErrMsg, MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
                        CREDIT_YMD.Text = Format(CDate(CreditMaxYmd), "yyyyMMdd")
                    Else
                        e.Cancel = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub CREDIT_DAYS_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CREDIT_DAYS.Validating
        If Not String.IsNullOrEmpty(CREDIT_DAYS.Value) Then
            If CDec(CREDIT_DAYS.Value) = CDec(0) Then
                If MsgBoxLocalized("0개월은 입력 불가합니다. 기본 3개월로 변경하시겠습니까?", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
                    CREDIT_DAYS.Text = 3
                Else
                    e.Cancel = True
                End If
            ElseIf CDec(CREDIT_DAYS.Value) > CDec(6) Then
                If MsgBoxLocalized("최대 6개월까지만 입력가능합니다. 6개월로 변경하시겠습니까?", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
                    CREDIT_DAYS.Text = 6
                Else
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    'Private Sub WG1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WG1.Click
    '    If GV1.RowCount = 0 Then Exit Sub
    '    SearchDetail(GV1.GetFocusedRowCellValue("CUST_CD").ToString)
    'End Sub

    '20240530 김정현 WG 클릭이벤트 -> GV 이벤트로 변경, 우클릭일시에는 재검색 x
    Private Sub GV1_MouseUp(sender As Object, e As MouseEventArgs) Handles GV1.MouseUp
        If GV1.RowCount = 0 Then Exit Sub
        If GV1.FocusedRowHandle < 0 Then Exit Sub
        If e.Button = MouseButtons.Left Then
            SearchDetail(GV1.GetFocusedRowCellValue("CUST_CD").ToString)
        End If
    End Sub
    Private Sub WG1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles WG1.KeyUp
        If GV1.RowCount = 0 Then Exit Sub
        Select Case e.KeyCode
            Case Keys.Down, Keys.Up, Keys.PageUp, Keys.PageDown
                SearchDetail(GV1.GetFocusedRowCellValue("CUST_CD").ToString)
        End Select
    End Sub

    Private Sub GV1_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GV1.RowCellStyle
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            If e.RowHandle < 0 Then Exit Sub

            Select Case e.Column.FieldName
                Case "USE_YN"
                    If view.GetRowCellValue(e.RowHandle, "USE_YN").ToString = "N" Then
                        e.Appearance.BackColor = System.Drawing.Color.LightPink
                    End If
                Case "INFO_YN", "INFO_YMD"
                    If view.GetRowCellValue(e.RowHandle, "INFO_YN").ToString = "Y" AndAlso view.GetRowCellValue(e.RowHandle, "CHECK_YN").ToString = "Y" Then
                        e.Appearance.BackColor = System.Drawing.Color.Red
                    End If
                Case "STOP_YN", "STOP_YMD"
                    If view.GetRowCellValue(e.RowHandle, "STOP_YN").ToString = "Y" AndAlso view.GetRowCellValue(e.RowHandle, "CHECK_YN").ToString = "Y" Then
                        e.Appearance.BackColor = System.Drawing.Color.Red
                    End If
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub GV4_CustomRowCellEdit(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles GV4.CustomRowCellEdit
        If e.RowHandle < 0 Or e.Column.FieldName <> "ITEM_VAL" Then
            Exit Sub
        End If

        Dim st As String = GV4.GetRowCellValue(e.RowHandle, "ITEM_CD").ToString

        Dim Gv As GridView = sender

        Select Case (st)
            Case "20"
                e.RepositoryItem = CustomTypeCombo

        End Select
    End Sub

    Private Sub GV4_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV4.FocusedRowChanged
        If GV_Flag = True Or GV4.FocusedColumn Is Nothing Then Exit Sub

        'If e.FocusedRowHandle >= 0 And GV4.RowCount - 1 >= e.FocusedRowHandle Then
        '    If GV4.GetRowCellValue(e.FocusedRowHandle, "DOMAIN").ToString <> "" Then
        '        If GV4.FocusedColumn.FieldName = "ITEM_CD" Then
        '            GV4.FocusedColumn.OptionsColumn.AllowEdit = False

        '        End If
        '    Else
        '        GV4.FocusedColumn.OptionsColumn.AllowEdit = True
        '    End If
        'End If

    End Sub

    Private Sub GV9_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV9.CellValueChanged
        Dim gv As GridView = sender
        Select Case e.Column.FieldName
            Case "SVC_TYPE", "VENDER_CD"
                Select Case gv.GetRowCellValue(e.RowHandle, "VENDER_CD").ToString
                    Case "B"
                        Select Case gv.GetRowCellValue(e.RowHandle, "SVC_TYPE").ToString
                            Case "S"
                                gv.SetRowCellValue(e.RowHandle, "BASE_RATE_AMT", "10000")
                                gv.SetRowCellValue(e.RowHandle, "RATE_AMT", "30")
                            Case "R"
                                gv.SetRowCellValue(e.RowHandle, "BASE_RATE_AMT", "5000")
                                gv.SetRowCellValue(e.RowHandle, "RATE_AMT", "30")
                        End Select
                End Select
        End Select
    End Sub

    Private Sub btnCertificate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCertificate.Click
        Call PrintCertificate("F")
    End Sub

    Private Sub btnCertificateTMS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCertificateTMS.Click
        Call PrintCertificate("T")
    End Sub

    Private Sub btnCertificateWMS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCertificateWMS.Click
        Call PrintCertificate("W")
    End Sub

    ' 20230718 / 김태룡, 김성은 /  중계사 타입 추가 / CRM YJITS2023030532
    Private Sub TAX_TRANS_TYPE_SelectedValueChanged(sender As Object, e As EventArgs) Handles TAX_TRANS_TYPE.SelectedValueChanged
        If TAX_TRANS_TYPE.SelectedValue = "YJIT" OrElse TAX_TRANS_TYPE.SelectedValue = "" Then
            TAX_ID.ReadOnly = True
            TAX_PWD.ReadOnly = True
        Else
            TAX_ID.ReadOnly = False
            TAX_PWD.ReadOnly = False
        End If
    End Sub
    '20240425 김정현 미수금액 갱신 로직 추가
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If GV1.RowCount = 0 Then
            MsgBoxLocalized("거래처를 선택해주세요")
            Exit Sub
        End If
        Dim CRN As String = GV1.GetFocusedRowCellValue("CRN").ToString
        Dim CustCd As String = GV1.GetFocusedRowCellValue("CUST_CD").ToString
        Call RefreshRecAmt(CRN, CustCd)
    End Sub



#End Region



End Class
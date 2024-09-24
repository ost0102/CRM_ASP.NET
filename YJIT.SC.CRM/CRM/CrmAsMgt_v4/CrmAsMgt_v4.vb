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
Imports DevExpress.XtraRichEdit

Public Class CrmAsMgt_v4
    Public frmMain As YJIT.SC.UI.IMainForm = Nothing
    Dim BindPic As String = ""
    Dim BindTel As String = ""
    Private bSortEnable As Boolean = True
    Private comdoc As ComDoc
    Private KeyDownYn As Boolean = False
    Dim UserInfoDt As DataTable = Nothing

    Dim LoadFlag As Boolean = True
    Dim ShownFlag As Boolean = True
    Dim bBindingFlag As Boolean = False
    Public bSearchFlag As Boolean = False

    'Dim WORK_USR_FONT_BOLD As New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
    'Dim WORK_USR_FONT_ORG As New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)

    Public mainForm As Object = Nothing


#Region "=================Data logic actions==========="

    Private Property btnCancel As Object

    Dim DeptDt As DataTable
    Dim REQ_SVC2_dt As DataTable
    Private Sub InitData()

        Dim searchParams = New Dictionary(Of String, Object)
        Dim dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "C03")
        dataParams.Add("NameType", "")
        DeptDt = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)

        Dim dt As DataTable = DeptDt.Copy
        For i = 0 To dt.Rows.Count - 1
            dt.Rows(i)("NAME") = i + 1 & "." & dt.Rows(i)("NAME").ToString
        Next
        DEPT_CD.DataSource = dt.Copy


        'Try
        '    Dim ds As DataSet = GetConvertToDataSet("CrmUserInfo")
        '    'Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", "잠시만 기다려주세요. 자료처리중입니다.")
        '    ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgt_v4", "Save", {ds, comdoc.getUploadPath})
        '    'End Using
        '    ds = AdaptDataSourceForReport(ds)
        '    If ds.Tables.Contains("CrmUserInfo") Then
        '        UserInfoDt = ds.Tables("CrmUserInfo")
        '    End If
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub SetReqSvc()
        Dim dt As New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        dt.Rows.Add({"", "--Select--"})

        If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
                AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_COM_CODE") Then
            Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD='T02' AND OPT_ITEM4 LIKE '%" & ClientSessionInfo.OrganizationCode & "%'", "SORT ASC")
            If drMdm.Count > 0 Then
                For Each drRow As DataRow In drMdm
                    Dim dr As DataRow = dt.NewRow
                    dr("CODE") = drRow("COMN_CD").ToString
                    dr("NAME") = drRow("CD_NM").ToString
                    dt.Rows.Add(dr)
                Next
            End If
        End If
        REQ_SVC.DataSource = dt
        '20240214 김정현 디폴트값 고정하였으므로 주석처리 함
        'Select Case ClientSessionInfo.OrganizationCode
        '    Case "02"
        '        REQ_SVC.SelectedValue = "E"
        '    Case "05"
        '        REQ_SVC.SelectedValue = "C"
        '    Case "07"
        '        REQ_SVC.SelectedValue = "M"
        '    Case Else
        '        REQ_SVC.SelectedValue = "B"
        'End Select
    End Sub

    Private Sub SetReqSvc2(ByVal GrpCd As String)
        Dim dt As New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        dt.Rows.Add({"", "--Select--"})

        If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
                AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_COM_CODE") Then

            Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD='T10' AND OPT_ITEM1 = '" & GrpCd & "'", "SORT ASC")
            If drMdm.Count > 0 Then
                For Each drRow As DataRow In drMdm
                    Dim dr As DataRow = dt.NewRow
                    dr("CODE") = drRow("COMN_CD").ToString
                    dr("NAME") = drRow("CD_NM").ToString
                    dt.Rows.Add(dr)
                Next
            End If
        End If
        REQ_SVC2.DataSource = dt
    End Sub

    Private Sub SetReqSvc3()
        Dim dt As New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        dt.Rows.Add({"", "--Select--"})

        If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
                AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_COM_CODE") Then
            '20190214 김성은 / 로그인사용자 기준으로 적용
            'Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD='T09' AND OPT_ITEM4 LIKE '%" & DEPT_CD.SelectedValue & "%'", "SORT ASC")
            Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD='T09' AND OPT_ITEM4 LIKE '%" & ClientSessionInfo.OrganizationCode & "%'", "SORT ASC")
            If drMdm.Count > 0 Then
                For Each drRow As DataRow In drMdm
                    Dim dr As DataRow = dt.NewRow
                    dr("CODE") = drRow("COMN_CD").ToString
                    dr("NAME") = drRow("CD_NM").ToString
                    dt.Rows.Add(dr)
                Next
            End If
        End If
        REQ_TYPE2.DataSource = dt
        '20240214 김정현 초기값을 해운으로 고정함에 따라 주석처리
        'Select Case DEPT_CD.SelectedValue
        '    Case "02"
        '        REQ_SVC.SelectedValue = "E"
        '    Case "05"
        '        REQ_SVC.SelectedValue = "C"
        '    Case "07"
        '        REQ_SVC.SelectedValue = "M"
        '    Case Else
        '        REQ_SVC.SelectedValue = "B"
        'End Select
    End Sub

    Public Sub CopyData()
        '## 파일다운로드 ##
        'For Each EachFileName In IO.Directory.GetFiles(comdoc.getTempFolder)
        '    Dim fInfo As IO.FileInfo = New IO.FileInfo(EachFileName)
        '    Try
        '        System.IO.File.Delete(Path.Combine(comdoc.getTempFolder, EachFileName))
        '    Catch ex As Exception
        '    End Try
        'Next


        Try
            For Each fname In IO.Directory.GetFiles(comdoc.getTempFolder)
                System.IO.File.Delete(Path.Combine(comdoc.getTempFolder, fname))
            Next
        Catch ex As Exception

        End Try



        Dim arrFileList As New ArrayList
        For i As Integer = 0 To GV2.RowCount - 1
            Dim retD As New Dictionary(Of String, String)
            If GV2.GetFocusedRowCellValue("FORM_ID").ToString <> "OnlineHelp" Then
                retD = comdoc.DownLoadFile(GV2.GetRowCellValue(i, "MNGT_NO").ToString & "_" & GV2.GetRowCellValue(i, "SEQ").ToString,
                       GV2.GetRowCellValue(i, "FILE_NM").ToString,
                       GV2.GetRowCellValue(i, "FILE_PATH").ToString,
                       comdoc.getTempFolder & "\" & GV2.GetRowCellValue(i, "FILE_NM").ToString)
            Else
                retD = comdoc.DownLoadFileOnline(GV2.GetRowCellValue(i, "FILE_NM").ToString,
                       GV2.GetRowCellValue(i, "FILE_PATH").ToString,
                       comdoc.getTempFolder & "\" & GV2.GetRowCellValue(i, "FILE_NM").ToString)
            End If

            If retD("TrxCode").ToString = "Y" Then
                arrFileList.Add(comdoc.getTempFolder & "\" & GV2.GetRowCellValue(i, "FILE_NM").ToString)
            Else
                MsgBoxLocalized(retD("TrxMsg").ToString, MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Error)
            End If
        Next


        '## 초기화 ##
        If REQ_SVC.SelectedValue = "UA" AndAlso REQ_SVC2.SelectedValue = "UA003" Then
            Me.ClearView(UI.AppliedRangeTypes.Only, {MNGT_NO, WG2, WG3, PRAR_YMD, CMPT_YMD, CMPT_HM, WORK_USR_CHK, DB_MNGT_NO, ORGN_MNGT_NO, UPPER_MNGT_NO, DEPT_AUTH_LIST})
        Else
            Me.ClearView(UI.AppliedRangeTypes.Only, {MNGT_NO, WG2, WG3, PRAR_YMD, CMPT_YMD, CMPT_HM, RMK, CMPT_RMK, WORK_USR_CHK, DB_MNGT_NO, ORGN_MNGT_NO, UPPER_MNGT_NO, DEPT_AUTH_LIST})
        End If

        CUST_RMK.CreateNewDocument()
        DEPT_CD.SelectedValue = ClientSessionInfo.OrganizationCode
        PROC_TYPE.SelectedValue = 0
        SYS_ID.SelectedValue = "CRM"
        'xtcRemark.SelectedTabPageIndex = 0
        RETURN_YN.YesNo = "N"
        SHARE_YN.YesNo = "N"

        INS_YMD.Text = Now.ToString("yyyyMMdd")
        INS_HM.Text = Now.ToString("HHmmss")
        REQ_YMD.Text = Now.ToString("yyyyMMdd")
        REQ_HM.Text = Now.ToString("HHmmss")
        '20240227 김정현 접수일자 현재시간으로 초기화
        TAKE_YMD.Text = Now.ToString("yyyyMMdd")
        TAKE_HM.Text = Now.ToString("HHmmss")
        WORK_USR_CHK.Text = ""
        WORK_USR.SelectedValue = ClientSessionInfo.UserID

        ONLINE_YN.Text = "N"
        MODIFY_YN.Text = "N"


        Dim tmpDEV_AUTH As String = DEV_AUTH.SelectedValue
        Call ClearView(AppliedRangeTypes.Only, {DEV_AUTH})
        DEV_AUTH.SelectedValue = tmpDEV_AUTH
        DB_DEV_AUTH.Text = ""


        '## 파일 추가 ##
        For Each EachFileName In arrFileList 'IO.Directory.GetFiles(comdoc.getTempFolder)
            WG2.AddRow()
            comdoc.InsertFile(ComDoc.FileUploadType.FileChoose, GV2.RowCount - 1, {EachFileName}, DBNull.Value)
        Next

        CONTENT.Focus()

    End Sub

    Public Sub NewData()
        Try
            If MODIFY_YN.Text = "Y" Then
                If MsgBoxLocalized("기존 자료가 수정되었습니다. 진행하시겠습니까?", MessageBoxButtons.YesNo, , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

            LoadFlag = True

            '20200213 김성은 모르고 잘못 입력되는 경우가 많아서 제거
            'If Not String.IsNullOrEmpty(PROJECT_CD.Text.ToString) Then
            '    '프로젝트 코드가 있는 경우 프로젝트코드, 거래처코드,담당자,연락처 정보는 유지하도록 적용
            '    Me.ClearView(UI.AppliedRangeTypes.Except, {SCREEN, DirList, CUST_CD, CUST_NM, REQ_USR, RANK_NM, TEL_NO, REQ_EMAIL, PROJECT_CD, PROJECT_NM})
            'Else
            '    Me.ClearView(UI.AppliedRangeTypes.Except, {SCREEN, DirList})
            'End If
            Me.ClearView(UI.AppliedRangeTypes.Except, {SCREEN, DirList})

            CUST_RMK.CreateNewDocument()

            SYS_ID.SelectedValue = "CRM"
            CONTENT.ReadOnly = False
            SYS_ID.Enabled = True
            '20240227 김정현 접수일자 추가
            TAKE_YMD.Enabled = True
            TAKE_HM.Enabled = True

            INS_YMD.Text = Now.ToString("yyyyMMdd")
            INS_HM.Text = Now.ToString("HHmmss")
            REQ_YMD.Text = Now.ToString("yyyyMMdd")
            REQ_HM.Text = Now.ToString("HHmmss")
            '20240227 김정현 접수일자 추가
            TAKE_YMD.Text = Now.ToString("yyyyMMdd")
            TAKE_HM.Text = Now.ToString("HHmmss")

            '20240214 김정현 디폴트값 변경
            'REQ_SVC.SelectedValue = "B"
            REQ_SVC.SelectedValue = "E"
            PROC_TYPE.SelectedValue = 0
            WORK_USR_CHK.Text = ""
            'SetUserList(WORK_USR_LIST, "01")
            'SetDept(DEPT_AUTH_LIST2, ClientSessionInfo.OrganizationCode)
            SetReqSvc2(REQ_SVC.SelectedValue)
            PRIORITY.SelectedValue = 2
            FREE_YN.SelectedValue = "Y"
            SHARE_YN.YesNo = "N"
            EX_IM_TYPE.SelectedValue = "I"
            RANK.SelectedValue = "C"
            ONLINE_YN.Text = "N"
            LEFTFORM_TAB.Text = ""

            'DEPT_CD.Select()

            DEPT_CD.DefVal = ClientSessionInfo.OrganizationCode
            DEPT_CD.SelectedValue = ClientSessionInfo.OrganizationCode

            WORK_USR.SelectedValue = ClientSessionInfo.UserID


            'MainPanel.Enabled = True
            CustomerPanel.Enabled = True
            CONTENT.Enabled = True
            RMK.Enabled = True
            CMPT_RMK.Enabled = True

            Select Case ClientSessionInfo.OrganizationCode
                Case "04", "08"
                    EX_IM_TYPE.SelectedValue = "E"
                Case Else
                    EX_IM_TYPE.SelectedValue = "I"
            End Select

            Call SetPaymentView()

            'Call SetControlEnabled()

            'CUST_CD.Focus()

            MODIFY_YN.Text = "N"
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        Finally
            LoadFlag = False
        End Try

    End Sub

    'Private Sub SetControlEnabled()
    '    'Select Case EventName
    '    '    Case "btnNewLeft"
    '    '        WORK_USR.Text = ""
    '    '        DEPT_CD.DefVal = "01"
    '    '        DEPT_CD.SelectedValue = "01"
    '    '        WORK_USR.Enabled = False
    '    '        DEPT_AUTH_LIST.Enabled = False
    '    '        PROC_TYPE.NextFocus = "PRAR_YMD"
    '    '    Case "btnNew", "Load"
    '    WORK_USR.Text = ClientSessionInfo.LocalName
    '    DEPT_CD.DefVal = ClientSessionInfo.OrganizationCode
    '    DEPT_CD.SelectedValue = ClientSessionInfo.OrganizationCode
    '    'WORK_USR.Enabled = True
    '    'DEPT_AUTH_LIST.Enabled = True
    '    'PROC_TYPE.NextFocus = "DEPT_AUTH_LIST"
    '    'End Select

    '    'If EventName = "btnNewLeft" AndAlso ClientSessionInfo.OrganizationCode <> "01" Then
    '    '    WORK_USR.Enabled = False
    '    '    DEPT_AUTH_LIST.Enabled = False
    '    '    PROC_TYPE.NextFocus = "PRAR_YMD"
    '    'Else
    '    'WORK_USR.Enabled = True
    '    'DEPT_AUTH_LIST.Enabled = True
    '    'PROC_TYPE.NextFocus = "DEPT_AUTH_LIST"
    '    'End If
    'End Sub



    Public Sub GridInit()

        Dim editorCombo As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim editor As New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)

        Dim editorImgCombo As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox = comdoc.getImageComboBox()
        editorImgCombo.SmallImages = comdoc.getIcons()
        GV2.Columns("FILE_ICON").ColumnEdit = editorImgCombo
        GV2.Columns("SUCCESS").ColumnEdit = editorImgCombo

        Dim dt As DataTable = New DataTable

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "T02")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV41.Columns("REQ_SVC").ColumnEdit = editorCombo

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
            GV41.Columns("REQ_SVC2").ColumnEdit = editorCombo
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
        GV41.Columns("REQ_TYPE").ColumnEdit = editorCombo

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
        GV41.Columns("REQ_TYPE2").ColumnEdit = editorCombo

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
        GV41.Columns("CUST_CD").ColumnEdit = editor


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
        GV41.Columns("REQ_USR").ColumnEdit = editor



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
        GV41.Columns("PRIORITY").ColumnEdit = editorCombo

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
        GV41.Columns("FREE_YN").ColumnEdit = editorCombo

        Common.DrawRowIndicator({GV3})


        '------------------------------------------GV3
        'Dim Drs() As DataRow
        'Drs = UserInfoDt.Select("DEPT_CD ='" & "02" & "'", "SORT ASC ,LOC_NM ASC")
        'If Drs.Length > 0 Then
        '    dt = Drs.CopyToDataTable
        '    dt.Columns("USR_ID").ColumnName = "CODE"
        '    dt.Columns("LOC_NM").ColumnName = "NAME"
        '    For I = 0 To dt.Rows.Count - 1
        '        dt.Rows(I)("NAME") = (I + 1).ToString & "." & dt.Rows(I)("NAME").ToString
        '    Next
        '    For I = dt.Columns.Count - 1 To 0 Step -1
        '        If dt.Columns(I).ColumnName <> "CODE" And dt.Columns(I).ColumnName <> "NAME" Then
        '            dt.Columns.RemoveAt(I)
        '        End If
        '    Next
        'End If

        'Dim dr As DataRow = dt.NewRow
        'dr("CODE") = ""
        'dr("NAME") = "--Select--"
        'dt.Rows.InsertAt(dr, 0)

        'dt = UserInfoDt.Copy
        'dt.Columns("USR_ID").ColumnName = "CODE"
        'dt.Columns("LOC_NM").ColumnName = "NAME"
        'REQ_SVC.DataSource = dt

        dt = New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        dt.Rows.Add({"", "--Select--"})
        If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
                AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("CRM_USR_MST") Then
            Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("CRM_USR_MST").Select("1=1", "LOC_NM")
            If drMdm.Count > 0 Then
                For Each drRow As DataRow In drMdm
                    Dim dr As DataRow = dt.NewRow
                    dr("CODE") = drRow("USR_ID").ToString
                    dr("NAME") = drRow("LOC_NM").ToString
                    dt.Rows.Add(dr)
                Next
            End If
        End If
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV3.Columns("USR_ID").ColumnEdit = editorCombo


        'searchParams = New Dictionary(Of String, Object)
        'dataParams = New Dictionary(Of String, Object)
        'dataParams.Add("GroupCode", "T07")
        'dataParams.Add("NameType", "")
        'Dim T07 As DataTable = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)

        dt = New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        dt.Rows.Add({"", "--Select--"})
        If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
        AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_COM_CODE") Then
            Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD = 'T07'", "SORT, COMN_CD")
            If drMdm.Count > 0 Then
                For Each drRow As DataRow In drMdm
                    Dim dr As DataRow = dt.NewRow
                    dr("CODE") = drRow("COMN_CD").ToString
                    dr("NAME") = drRow("CD_NM").ToString
                    dt.Rows.Add(dr)
                Next
            End If
        End If
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        'editorCombo.DataSource = T07
        editorCombo.DataSource = dt
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV3.Columns("PROC_TYPE").ColumnEdit = editorCombo

        'searchParams = New Dictionary(Of String, Object)
        'dataParams = New Dictionary(Of String, Object)
        'dataParams.Add("GroupCode", "T08")
        'dataParams.Add("NameType", "")
        'Dim T08 As DataTable = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        dt = New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        dt.Rows.Add({"", "--Select--"})
        If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
        AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_COM_CODE") Then
            Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD = 'T07'", "SORT, COMN_CD")
            If drMdm.Count > 0 Then
                For Each drRow As DataRow In drMdm
                    Dim dr As DataRow = dt.NewRow
                    dr("CODE") = drRow("COMN_CD").ToString
                    dr("NAME") = drRow("CD_NM").ToString
                    dt.Rows.Add(dr)
                Next
            End If
        End If
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        'editorCombo.DataSource = T08
        editorCombo.DataSource = dt
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV3.Columns("TEST_RESULT").ColumnEdit = editorCombo


        '==================Grid4============================

        dt = New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        dt.Rows.Add({"", "--Select--"})
        If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
        AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_COM_CODE") Then
            Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD = 'T03'", "SORT, COMN_CD")
            If drMdm.Count > 0 Then
                For Each drRow As DataRow In drMdm
                    Dim dr As DataRow = dt.NewRow
                    dr("CODE") = drRow("COMN_CD").ToString
                    dr("NAME") = drRow("CD_NM").ToString
                    dt.Rows.Add(dr)
                Next
            End If
        End If
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        'editorCombo.DataSource = T07
        editorCombo.DataSource = dt
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV41.Columns("PROC_TYPE").ColumnEdit = editorCombo

        'dt = New DataTable
        'dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        'dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        'AddNewRow(dt, "A", "설치업무")
        'AddNewRow(dt, "B", "공통업무")
        'AddNewRow(dt, "C", "ACCOUNT")
        'AddNewRow(dt, "D", "AIR")
        'AddNewRow(dt, "E", "OCEAN")
        'AddNewRow(dt, "F", "인사급여")
        'AddNewRow(dt, "G", "쿠리어")
        'AddNewRow(dt, "H", "통관업무")
        'AddNewRow(dt, "I", "운송업무")
        'AddNewRow(dt, "J", "대리점")
        'AddNewRow(dt, "K", "CFS")
        'AddNewRow(dt, "L", "EDMS")
        'AddNewRow(dt, "M", "WMS")
        'AddNewRow(dt, "N", "영업")
        'AddNewRow(dt, "O", "SCM")
        'AddNewRow(dt, "Z", "ETC")
        dt = New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        dt.Rows.Add({"", "--Select--"})
        If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
        AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_COM_CODE") Then
            Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD = 'T02'", "SORT, COMN_CD")
            If drMdm.Count > 0 Then
                For Each drRow As DataRow In drMdm
                    Dim dr As DataRow = dt.NewRow
                    dr("CODE") = drRow("COMN_CD").ToString
                    dr("NAME") = drRow("CD_NM").ToString
                    dt.Rows.Add(dr)
                Next
            End If
        End If
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        'editorCombo.DataSource = dt.Copy
        editorCombo.DataSource = dt
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV41.Columns("REQ_SVC").ColumnEdit = editorCombo

        '비용 내역 항목
        'searchParams = New Dictionary(Of String, Object)
        'dataParams = New Dictionary(Of String, Object)
        'dataParams.Add("GroupCode", "T05")
        'dataParams.Add("NameType", "")
        dt = New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        dt.Rows.Add({"", "--Select--"})
        If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
        AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_COM_CODE") Then
            Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD = 'T02'", "SORT, COMN_CD")
            If drMdm.Count > 0 Then
                For Each drRow As DataRow In drMdm
                    Dim dr As DataRow = dt.NewRow
                    dr("CODE") = drRow("COMN_CD").ToString
                    dr("NAME") = drRow("CD_NM").ToString
                    dt.Rows.Add(dr)
                Next
            End If
        End If
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        'editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        editorCombo.DataSource = dt
        GV41.Columns("REQ_TYPE").ColumnEdit = editorCombo


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
        GV41.Columns("REQ_USR").ColumnEdit = editor

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
        GV41.Columns("FREE_YN").ColumnEdit = editorCombo



    End Sub

    Private Sub AddNewRow(ByVal dt As DataTable, ByVal Code As String, ByVal Name As String)
        dt.Rows.Add()
        dt.Rows(dt.Rows.Count - 1)("CODE") = Code
        dt.Rows(dt.Rows.Count - 1)("NAME") = Name
    End Sub

    Private Sub InitIcons()
        For i = 0 To GV2.RowCount - 1
            If Not comdoc.IsContainExtension(GV2.GetRowCellValue(i, "FILE_ICON").ToString) And GV2.GetRowCellValue(i, "FILE_NM").ToString <> "" Then
                GV2.SetRowCellValue(i, "FILE_ICON", "dft")
            End If
            GV2.SetRowCellValue(i, "UPLOAD", "UPLOAD")
        Next
        Me.DataState = DataStates.Retrieved
    End Sub


    Public Sub MenuListBeforeShow(ByRef param As Dictionary(Of String, Boolean))
        Try
            If Not String.IsNullOrEmpty(MNGT_NO.Text) AndAlso (SYS_ID.SelectedValue = "CRM" OrElse SYS_ID.SelectedValue = "MAIL") Then
                param("Copy") = True
            Else
                param("Copy") = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub PopUpOnBeforeClick(ByVal dr As DataRow)
        'Dim Key As String = dr("KEY")
        'Dim Sender As String = dr("Sender")

        'Select Case dr("Action")
        '    Case Action.Other
        '        Select Case Key
        '            Case "Copy"
        '                If SYS_ID.Text.ToUpper = "CRM" _
        '                        OrElse DEPT_CD.SelectedValue <> ClientSessionInfo.OrganizationCode Then
        '                    dr("Cancel") = True
        '                End If
        '        End Select
        'End Select
    End Sub

    Public Sub PopUpOnAfterClick(ByVal dr As DataRow)
        Dim key As String = dr("Key").ToString

        Select Case key
            Case "Copy"
                Call CopyData()
            Case "WG2_Download"
                If GV2.FocusedRowHandle >= 0 < GV2.RowCount AndAlso GV2.GetFocusedRowCellValue("SUCCESS").ToString() <> "N" Then
                    If GV2.GetFocusedRowCellValue("FILE_NM").ToString.Trim <> "" Then
                        SaveFileDialog1.FileName = GV2.GetFocusedRowCellValue("FILE_NM").ToString
                        SaveFileDialog1.Filter = "All files (*.*)|*.*"
                        SaveFileDialog1.ValidateNames = True
                        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK And SaveFileDialog1.FileName <> "" Then
                            Dim retD As New Dictionary(Of String, String)
                            If GV2.GetFocusedRowCellValue("FORM_ID").ToString <> "OnlineHelp" Then
                                retD = comdoc.DownLoadFile(GV2.GetFocusedRowCellValue("MNGT_NO").ToString & "_" & GV2.GetFocusedRowCellValue("SEQ").ToString,
                                  GV2.GetFocusedRowCellValue("FILE_NM").ToString,
                                  GV2.GetFocusedRowCellValue("FILE_PATH").ToString,
                                  SaveFileDialog1.FileName)
                            Else
                                retD = comdoc.DownLoadFileOnline(GV2.GetFocusedRowCellValue("FILE_NM").ToString,
                                  GV2.GetFocusedRowCellValue("FILE_PATH").ToString,
                                  SaveFileDialog1.FileName)
                            End If

                            If retD("TrxCode").ToString <> "Y" Then
                                MsgBoxLocalized(retD("TrxMsg").ToString, MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Error)
                            End If
                        End If
                    End If
                Else
                    MsgBoxLocalized("File is not selected or file size is exceeded.", MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Warning)
                End If
        End Select
    End Sub

    Public Sub PopUpInit()
        Dim PopUp As New PopupBase
        'PopUp.ItemAdd(Action.Other, "Copy", "Copy")
        'PopUp.PopUpInit(Me)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG2_AddRow", "&Add Row")
        PopUp.ItemAdd(Action.DeleteRow, "WG2_DeleteRow", "&Delete Row")
        PopUp.ItemAdd(Action.Other, "WG2_Download", "Download", True)
        PopUp.PopUpInit(Me, WG2, "DOC_TYPE", "DOC_NO")

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG3_AddRow", "&Add Row")
        PopUp.ItemAdd(Action.DeleteRow, "WG3_DeleteRow", "&Delete Row")
        PopUp.PopUpInit(Me, WG3, "USR_ID", "CONTENT")

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Other, "WG4_Excel", "공유사항 Export")
        PopUp.PopUpInit(Me, WG41)
    End Sub

    Private Sub SearchCustomerPic()

        Dim ds As DataSet = Nothing
        Dim dr As DataRow = Nothing

        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgt_v4", "SearchCustomerPic", Me.ConvertToDataset)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") = "M" Then

            Call SetCustPicByList(ds)
            Exit Sub
        End If
        If dr("TrxCode").ToString <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg").ToString, MessageBoxButtons.OK, "Warning", MessageBoxIcon.Warning)
            'REQ_USR.NextFocus = "TEL_NO"
            '   Exit Sub
        Else
            REQ_USR.Text = dr("PIC_NM").ToString
            RANK_NM.Text = dr("RANK_NM").ToString
            REQ_EMAIL.Text = dr("EMAIL").ToString
            TEL_NO.Text = dr("TEL_NO").ToString

            '' 담당자의 전화번호가 없는 경우 포커스는 이동하되 빈 값으로 넘어가지 않도록 수정
            'If dr("TEL_NO").ToString <> "" Then
            '    TEL_NO.Text = dr("TEL_NO").ToString
            '    REQ_USR.NextFocus = "CONTENT"
            'Else
            '    REQ_USR.NextFocus = "TEL_NO"
            'End If

        End If

    End Sub


    Private Sub SetCustPicByList(ByVal ds As DataSet)

        CustomerPanel.Controls.Add(CUST_PIC_LIST)
        CUST_PIC_LIST.Location = New Size(REQ_USR.Location.X, REQ_USR.Location.Y + 1)

        REQ_USR.BringToFront()

        CUST_PIC_LIST.EditValue = ""
        CUST_PIC_LIST.DataBindings.Clear()
        CUST_PIC_LIST.Properties.DataSource = Nothing

        CUST_PIC_LIST.Properties.DataSource = ds.Tables("Data.CUST_PIC_LIST")
        CUST_PIC_LIST.Properties.DisplayMember = "TEL_NO"
        CUST_PIC_LIST.Properties.ValueMember = "PIC_NM"
        If ds.Tables.Contains("Data.CUST_PIC_LIST") Then
            If ds.Tables("Data.CUST_PIC_LIST").Rows.Count > 0 Then
                CUST_PIC_LIST.EditValue = ds.Tables("Data.CUST_PIC_LIST").Rows(0)("PIC_NM").ToString
            Else
                CUST_PIC_LIST.EditValue = Nothing
            End If
        End If
        CUST_PIC_LIST.ShowPopup()
        CUST_PIC_LIST.Focus()

    End Sub


    Public Sub SaveData()


        If MandatoryGridValue("GV2") Then Exit Sub

        If ORGN_SAVE_YN.Text.ToString = "Y" Then
            MsgBoxLocalized("이미 공유완료후 신규등록된 자료가 있습니다. 저장이 취소되었습니다.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If

        If CUST_CD.Text.ToString = "" Then
            MsgBoxLocalized("거래처을 입력해주세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            CUST_CD.Focus()
            Exit Sub
        End If

        If WORK_USR.SelectedValue.ToString = "" Then
            MsgBoxLocalized("작업자를 입력해주세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            WORK_USR.Focus()
            Exit Sub
        End If

        If MNGT_NO.Text.ToString.Trim <> DB_MNGT_NO.Text.ToString.Trim Then
            MsgBoxLocalized(String.Format("{0} (조회번호:{1}, 현재번호:{2})", "관리번호가 변경되었습니다. 재조회후 저장해주세요." & vbCrLf, DB_MNGT_NO.Text, MNGT_NO.Text), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            WORK_USR.Focus()
            Exit Sub
        End If


        If SYS_ID.Enabled = True Then
            Select Case SYS_ID.SelectedValue
                Case "CRM", "MAIL"
                Case Else
                    MsgBoxLocalized("CRM, MAIL 중에 선택해주세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                    SYS_ID.Focus()
                    Exit Sub
            End Select
        End If

        If (PROC_TYPE.SelectedValue = "1" OrElse PROC_TYPE.SelectedValue = "2") Then
            'If REQ_TYPE.SelectedValue.ToString = "" Then
            '    MsgBoxLocalized("요청사항 구분을 선택하세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            '    REQ_TYPE.Focus()
            '    Exit Sub
            'End If

            If REQ_TYPE2.SelectedIndex = -1 OrElse REQ_TYPE2.SelectedIndex = 0 Then
                MsgBoxLocalized("업무구분3을 선택하세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                REQ_TYPE2.Focus()
                Exit Sub
            End If


            If String.IsNullOrEmpty(RMK.Text) Then
                'xtcRemark.SelectedTabPage = xtpRMK
                MsgBoxLocalized("조치사항 입력후 저장하세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                RMK.Focus()
                Exit Sub
            End If

            If SYS_ID.SelectedValue <> "CRM" _
                        AndAlso SYS_ID.SelectedValue <> "MAIL" _
                        AndAlso String.IsNullOrEmpty(CMPT_RMK.Text) Then
                'xtcRemark.SelectedTabPage = xtpCMPT_RMK
                MsgBoxLocalized("답변 입력후 저장하세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                CMPT_RMK.Focus()
                Exit Sub
            End If

            'If InStr(WORK_USR_LIST.EditValue.ToString, ";") > 0 Then
            '    MsgBoxLocalized("작업자를 한명만 선택하세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            '    WORK_USR_LIST.Focus()
            '    Exit Sub
            'End If

            If String.IsNullOrEmpty(WORK_USR.SelectedValue) Then
                MsgBoxLocalized("작업자를 선택하세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                WORK_USR.Focus()
                Exit Sub
            End If
        End If

        Dim byteUploadFiles As Dictionary(Of String, Object) = comdoc.byteUploadFiles
        Dim tempFolder As String = comdoc.getTempFolder
        Dim strFileName As String = ""

        Dim dsResult As DataSet

        Dim ds As DataSet = Nothing
        Try
            For i As Integer = 0 To GV2.RowCount - 1
                If String.IsNullOrEmpty(GV2.GetRowCellValue(i, "MNGT_NO").ToString) Then
                    GV2.SetRowCellValue(i, "SEQ", comdoc.GetSeq(i, MNGT_NO.Text))
                Else
                    GV2.SetRowCellValue(i, "SEQ", comdoc.GetSeq(i, GV2.GetRowCellValue(i, "MNGT_NO").ToString))
                End If

            Next
            comdoc.SetUploadPath(Split(DirList.Text, "/"))

            ds = Me.ConvertToDataset 'GetConvertToDataSet() 'GetConvertToDataSet("Search") 

            Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", "잠시만 기다려주세요. 자료처리중입니다.")
                dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgt_v4", "Save", {ds, comdoc.getUploadPath})
            End Using
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow
        dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") = "Y" Then
            Dim dt As DataTable = dsResult.Tables("Data.WG2")

            For Each dr In dt.Rows
                MNGT_NO.Text = dr("MNGT_NO").ToString
                Dim strSeq As String = dr("SEQ").ToString
                strFileName = tempFolder & "\" & comdoc.removeSpecialChars(MNGT_NO.Text) & "_" & strSeq & "_" & dr("FILE_NM").ToString

                Try
                    Dim rowNumber As Integer = Integer.Parse(dr("SEQ"))

                    'if directory doesn't exist
                    If Not Directory.Exists(tempFolder) Then
                        Directory.CreateDirectory(tempFolder)
                    End If

                    'if the file is changed, following actions can be done
                    If comdoc.byteUploadFiles.ContainsKey(dr("FILE_NM").ToString) AndAlso dr("SUCCESS").ToString() = "Y" Then
                        File.WriteAllBytes(strFileName, byteUploadFiles(dr("FILE_NM").ToString))

                        If Not FileUpload(strFileName, dr("FILE_PATH").ToString()) Then Throw New Exception("Couldn't upload file!")

                        If System.IO.File.Exists(strFileName) Then System.IO.File.Delete(strFileName)
                    End If
                Catch ex As Exception
                    dr("TrxMsg") = ex.ToString
                    Dim dsDocDel As DataSet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.ComDocumentMgt", "Delete", {MNGT_NO.Text, strSeq})
                End Try
            Next

            Dim bSendMsgType As String = String.Empty
            Try
                bBindingFlag = True


                'DB_DEV_AUTH
                'If Not String.IsNullOrEmpty(DEV_AUTH.SelectedValue) _
                '            AndAlso String.IsNullOrEmpty(DB_MNGT_NO.Text) Then
                '    bSendMsgType = "PIC"
                'ElseIf String.IsNullOrEmpty(DEV_AUTH.SelectedValue) _
                '            AndAlso Not String.IsNullOrEmpty(DEPT_AUTH_LIST.SelectedValue) _
                '            AndAlso String.IsNullOrEmpty(DB_MNGT_NO.Text) Then
                '    bSendMsgType = "TEAM"
                'ElseIf String.IsNullOrEmpty(DEV_AUTH.SelectedValue) _
                '            AndAlso String.IsNullOrEmpty(DEPT_AUTH_LIST.SelectedValue) _
                '            AndAlso Not String.IsNullOrEmpty(PRIORITY.SelectedValue) Then
                'Select Case PRIORITY.SelectedValue
                '    Case "0", "1"
                '        bSendMsgType = "EMERGENCY"
                'End Select
                'End If
                If Not String.IsNullOrEmpty(DEV_AUTH.SelectedValue) Then
                    bSendMsgType = "PIC"
                    ''업무별 공유기능이 필요해서 일단 주석 처리
                    'ElseIf String.IsNullOrEmpty(DEV_AUTH.SelectedValue) _
                    '            AndAlso Not String.IsNullOrEmpty(DEPT_AUTH_LIST.SelectedValue) Then
                    '    bSendMsgType = "TEAM"
                ElseIf String.IsNullOrEmpty(DEV_AUTH.SelectedValue) _
                            AndAlso String.IsNullOrEmpty(DEPT_AUTH_LIST.SelectedValue) _
                            AndAlso Not String.IsNullOrEmpty(PRIORITY.SelectedValue) Then
                    Select Case PRIORITY.SelectedValue
                        Case "0", "1"
                            bSendMsgType = "EMERGENCY"
                    End Select
                End If

                Me.BindToDataset(dsResult, "Data")
            Catch ex As Exception
                MsgBoxLocalized(ex.Message)
            Finally
                bBindingFlag = False

                If Not String.IsNullOrEmpty(bSendMsgType) Then
                    '부서공유시 배정필요
                    Dim msg As String = String.Empty
                    Dim rcv As String = String.Empty

                    If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
                    AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("CRM_USR_MST") Then
                        Dim drMdm() As DataRow = Nothing
                        Select Case bSendMsgType
                            Case "PIC"
                                drMdm = YJIT.SC.UI.SCView.PreloadedCodeListData("CRM_USR_MST").Select("USR_ID ='" & DEV_USR_ID.Text & "' AND RECVMSG_YN = 'Y'")
                                msg = String.Format("[{0}]{1}", PRIORITY.GetItemText(PRIORITY.SelectedItem).ToString, "개발요청건이 배정되었습니다.")
                                msg &= vbCrLf & CONTENT.Text
                            Case "TEAM"
                                drMdm = YJIT.SC.UI.SCView.PreloadedCodeListData("CRM_USR_MST").Select("DEPT_CD ='" & DEPT_AUTH_LIST.SelectedValue & "' AND RECVMSG_YN = 'Y'")
                                msg = String.Format("[{0}]{1}", PRIORITY.GetItemText(PRIORITY.SelectedItem).ToString, "미배정 요청건입니다.")
                                msg &= vbCrLf & CONTENT.Text
                            Case "EMERGENCY"
                                drMdm = YJIT.SC.UI.SCView.PreloadedCodeListData("CRM_USR_MST").Select("DEPT_CD ='" & DEPT_AUTH_LIST.SelectedValue & "' AND RECVMSG_YN = 'Y'")
                                msg = String.Format("[{0}]{1}", PRIORITY.GetItemText(PRIORITY.SelectedItem).ToString, "미배정 요청건입니다.")
                                msg &= vbCrLf & CONTENT.Text
                        End Select
                        For i = 0 To drMdm.Count - 1
                            If Not String.IsNullOrEmpty(rcv) Then rcv &= ","
                            rcv &= drMdm(i)("USR_ID").ToString
                        Next
                    End If
                    '20200705 김성은 로직점검 필요
                    'If Not String.IsNullOrEmpty(rcv) Then Common.SendMessageHub(SavedSessionDomain, ClientSessionInfo.UserID, rcv.Split(","), "EE", "P", "CRM_DEV_REQ", msg, "", "", DB_MNGT_NO.Text, bSendMsgType, "", "", "", "N", "N")
                End If
            End Try

            'DEPT_AUTH_LIST2.EditValue = dsResult.Tables("Data.MAIN").Rows(0)("DEPT_AUTH_LIST").ToString()

            MODIFY_YN.Text = "N"
            'Call SetControlEnabled()
        Else
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            '작업지원현황 자동 조회
            For Each frm As Object In Me.ParentForm.Controls
                Debug.Print(frm.GetType.Name & "   /   " & frm.Name)
                If frm.GetType.Name = "DockPanel" AndAlso frm.Name = "LeftPanel" Then
                    Call SearchLeftForm(frm)
                    Exit For
                End If
            Next
            '메세지 미표시 처리후 활성화 가능 / CrmAsMgt_v5 폼에서 저장시 재조회 가능 적용안됨
            ''고객지원관리
            'For Each frm As Object In Me.ParentForm.MdiChildren
            '    If String.Equals(frm.GetType.Name, "CrmAsMgt_v5", StringComparison.InvariantCultureIgnoreCase) Then
            '        frm.SearchData()
            '        Exit For
            '    End If
            'Next
        Catch ex As Exception

        End Try

    End Sub


    Public Sub SearchData(Optional ByVal SearchType As String = "")
        Dim iTOPROW As Integer = -1
        'Dim sMNGT_NO As String = String.Empty

        If MODIFY_YN.Text = "Y" Then
            If MsgBoxLocalized("기존 자료가 수정되었습니다. 자료조회를 진행하시겠습니까?", MessageBoxButtons.YesNo, , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = MsgBoxResult.No Then
                MNGT_NO.Text = DB_MNGT_NO.Text
                Exit Sub
            End If
        End If


        Select Case SearchType.ToUpper
            Case "SearchTop".ToUpper
                iTOPROW = GV41.TopRowIndex

                MNGT_NO.Text = GV41.GetFocusedRowCellValue("MNGT_NO").ToString
                Call ClearView(AppliedRangeTypes.Except, {MNGT_NO})
            Case Else
                If String.IsNullOrEmpty(MNGT_NO.Text) Then Exit Sub
                Call ClearView(AppliedRangeTypes.Except, {MNGT_NO, LEFTFORM_TAB})
        End Select




        Dim retDs As DataSet = Me.ConvertToDataset
        Try
            Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", "잠시만 기다려주세요. 조회중입니다.")
                retDs = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgt_v4", "Search", retDs)
            End Using
        Catch ex As Exception
            MsgBoxLocalized(ex.Message, MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End Try

        Try
            Dim dr As DataRow = retDs.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                Exit Sub
            End If
            If dr("TrxCode") <> "Y" Then
                Me.ClearView(AppliedRangeTypes.Only, {WG2})
                If KeyDownYn = False Then
                    MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Information)
                Else
                    Call Wg2AddRow()
                End If
                KeyDownYn = False
                Exit Sub
            End If
            '20240214 김정현 SetReqSvc() / SetReqSvc3() 주석
            'Call SetReqSvc() - 이미 load 에서 수행
            Call SetReqSvc2(retDs.Tables("Data.MAIN").Rows(0)("REQ_SVC").ToString())
            'Call SetReqSvc3()

            'SetUserList(WORK_USR_LIST, "01") '고객지원으로 고정
            'SetDept(DEPT_AUTH_LIST, retDs.Tables("Data.MAIN").Rows(0)("DEPT_CD").ToString())
            Try
                bBindingFlag = True
                TAKE_YMD.Enabled = True
                TAKE_HM.Enabled = True
                Me.BindToDataset(retDs, "Data")
                '20240227 김정현 최초접수일 경우 접수일자 자동 생성, 개발자가 이미 배정받은 건 이거나 접수자가 즉시 완료 처리한 건은 수정 불가하도록 설정
                If String.IsNullOrEmpty(retDs.Tables("DATA.MAIN").Rows(0)("WORK_USR").ToString()) And String.IsNullOrEmpty(TAKE_YMD.Text) And String.IsNullOrEmpty(TAKE_HM.Text) Then
                    TAKE_YMD.Text = Now.ToString("yyyyMMdd")
                    TAKE_HM.Text = Now.ToString("HHmmss")
                Else
                    If Not String.IsNullOrEmpty(ORGN_MNGT_NO.Text) Then
                        TAKE_YMD.Enabled = False
                        TAKE_HM.Enabled = False
                    Else
                        If CNT_ORGN_MNGT.Text <> "0" Or PROC_TYPE.Value = "1" Or PROC_TYPE.Value = "2" Then
                            TAKE_YMD.Enabled = False
                            TAKE_HM.Enabled = False
                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBoxLocalized(ex.Message)
            Finally
                bBindingFlag = False
            End Try


            'retDs = AdaptDataSourceForReport(retDs)
            'DEPT_AUTH_LIST2.EditValue = retDs.Tables("Data.MAIN").Rows(0)("DEPT_AUTH_LIST").ToString()
            Call GetCustomerRmk(retDs.Tables("Data.MAIN").Rows(0)("CUST_RMK").ToString())

            Call SetPaymentView()

            If LEFTFORM_TAB.Text = "xtpNonAssign" Then
                LEFTFORM_TAB.Text = "" '작업현황에서 연동시 메세지 표시되는 오류 수정

                If PROC_TYPE.SelectedValue = 0 Then
                    WORK_USR.SelectedValue = ClientSessionInfo.UserID
                    'MainPanel.Enabled = True
                    CustomerPanel.Enabled = True
                    CONTENT.Enabled = True
                    RMK.Enabled = True
                    CMPT_RMK.Enabled = True

                    PRIORITY.SelectedValue = "2"
                Else
                    'MainPanel.Enabled = False
                    CustomerPanel.Enabled = False
                    CONTENT.Enabled = False
                    RMK.Enabled = False
                    CMPT_RMK.Enabled = False
                    MsgBoxLocalized("작업자가 배정되었습니다.")
                End If
            ElseIf LEFTFORM_TAB.Text = "CrmAsMgt_v5" Then
                If String.IsNullOrEmpty(WORK_USR.SelectedValue) Then
                    WORK_USR.SelectedValue = ClientSessionInfo.UserID
                End If
            ElseIf LEFTFORM_TAB.Text = "xtpTeam" Then
                If String.IsNullOrEmpty(WORK_USR.SelectedValue) Then WORK_USR.SelectedValue = ClientSessionInfo.UserID
            Else
                'MainPanel.Enabled = True
                CustomerPanel.Enabled = True
                CONTENT.Enabled = True
                RMK.Enabled = True
                CMPT_RMK.Enabled = True
            End If




            'Call SetControlEnabled()


            Select Case SYS_ID.SelectedValue
                Case "CRM", "MAIL"
                    CONTENT.ReadOnly = False
                    SYS_ID.Enabled = True
                Case Else
                    CONTENT.ReadOnly = True
                    SYS_ID.Enabled = False
            End Select

            '20180205 김성은 파일다운로드시 메모리 참조하는 부분이 있어서 초기화 처리
            'For i = 0 To comdoc.byteUploadFiles.Count - 1
            '    comdoc.byteUploadFiles(i) = Nothing
            'Next
            comdoc.ClearFiles()

            Call InitIcons()


            Select Case SearchType.ToUpper
                Case "SearchTop".ToUpper
                    If GV41.RowCount > 1 Then
                        '해당 변수에 값이 있는 경우만 기존에 선택된 ROW 선택처리
                        If Not String.IsNullOrEmpty(MNGT_NO.Text.Trim) Then
                            For i = 0 To GV41.RowCount - 1
                                If MNGT_NO.Text.Trim = GV41.GetRowCellValue(i, "MNGT_NO").ToString.Trim Then
                                    GV41.FocusedRowHandle = i
                                    GV41.TopRowIndex = iTOPROW
                                    Exit For
                                End If
                            Next
                        End If
                    End If
            End Select

            If LEFTFORM_TAB.Text = "CrmAsMgt_v5" Then
                LEFTFORM_TAB.Text = ""
            Else
                CUST_CD.Focus()
            End If

            MODIFY_YN.Text = "N"
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Public Sub SearchNewData()
        If String.IsNullOrEmpty(MNGT_NO.Text) Then Exit Sub

        If MODIFY_YN.Text = "Y" Then
            If MsgBoxLocalized("기존 자료가 수정되었습니다. 자료조회를 진행하시겠습니까?", MessageBoxButtons.YesNo, , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = MsgBoxResult.No Then
                MNGT_NO.Text = DB_MNGT_NO.Text
                Exit Sub
            End If
        End If

        Call ClearView(AppliedRangeTypes.Except, {MNGT_NO, UPPER_MNGT_NO, LEFTFORM_TAB})

        Dim retDs As DataSet = Nothing
        Try
            Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", "잠시만 기다려주세요. 조회중입니다.")
                retDs = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgt_v4", "SearchNew", Me.ConvertToDataset)
            End Using
        Catch ex As Exception
            MsgBoxLocalized(ex.Message, MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End Try

        Try
            Dim dr As DataRow = retDs.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                Exit Sub
            End If
            If dr("TrxCode") <> "Y" Then
                Me.ClearView(AppliedRangeTypes.Only, {WG2})
                If KeyDownYn = False Then
                    MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Information)
                Else
                    Call Wg2AddRow()
                End If
                KeyDownYn = False
                Exit Sub
            End If
            '20240214 김정현 SetReqSvc() / SetReqSvc3() 주석
            'Call SetReqSvc()
            Call SetReqSvc2(retDs.Tables("Data.MAIN").Rows(0)("REQ_SVC").ToString())
            'Call SetReqSvc3()
            'SetUserList(WORK_USR_LIST, "01") '고객지원으로 고정
            'SetDept(DEPT_AUTH_LIST, retDs.Tables("Data.MAIN").Rows(0)("DEPT_CD").ToString())

            Try
                bBindingFlag = True
                Me.BindToDataset(retDs, "Data")
                '20240227 김정현 개발자 처리 완료된 건에 대한 로직이므로 접수일자 수정 불가능하도록 비활성화
                TAKE_YMD.Enabled = False
                TAKE_HM.Enabled = False
            Catch ex As Exception
                MsgBoxLocalized(ex.Message)
            Finally
                bBindingFlag = False
            End Try


            'retDs = AdaptDataSourceForReport(retDs)
            'DEPT_AUTH_LIST2.EditValue = retDs.Tables("Data.MAIN").Rows(0)("DEPT_AUTH_LIST").ToString()



            If LEFTFORM_TAB.Text = "xtpNonAssign" Then
                LEFTFORM_TAB.Text = "" '작업현황에서 연동시 메세지 표시되는 오류 수정

                'If PROC_TYPE.SelectedValue = 0 Then
                '    'WORK_USR.SelectedValue = ClientSessionInfo.UserID
                '    MainPanel.Enabled = True
                '    CustomerPanel.Enabled = True
                '    CONTENT.Enabled = True
                '    RMK.Enabled = True
                '    CMPT_RMK.Enabled = True
                'Else
                '    MainPanel.Enabled = False
                '    CustomerPanel.Enabled = False
                '    CONTENT.Enabled = False
                '    RMK.Enabled = False
                '    CMPT_RMK.Enabled = False
                '    MsgBoxLocalized("작업자가 배정되었습니다.")
                'End If

                Call GetCustomerRmk(retDs.Tables("Data.MAIN").Rows(0)("CUST_RMK").ToString())
            End If

            If ORGN_SAVE_YN.Text = "Y" Then
                'MainPanel.Enabled = False
                CustomerPanel.Enabled = False
                CONTENT.Enabled = False
                RMK.Enabled = False
                CMPT_RMK.Enabled = False
                MsgBoxLocalized("이미 공유완료후 신규등록된 자료가 있습니다.")
            Else
                'MainPanel.Enabled = True
                CustomerPanel.Enabled = True
                CONTENT.Enabled = True
                RMK.Enabled = True
                CMPT_RMK.Enabled = True
            End If



            'Call SetControlEnabled()


            Select Case SYS_ID.SelectedValue
                Case "CRM", "MAIL"
                    CONTENT.ReadOnly = False
                    SYS_ID.Enabled = True
                Case Else
                    CONTENT.ReadOnly = True
                    SYS_ID.Enabled = False
            End Select

            '20180205 김성은 파일다운로드시 메모리 참조하는 부분이 있어서 초기화 처리
            'For i = 0 To comdoc.byteUploadFiles.Count - 1
            '    comdoc.byteUploadFiles(i) = Nothing
            'Next
            comdoc.ClearFiles()

            Call InitIcons()

            If LEFTFORM_TAB.Text = "CrmAsMgt_v5" Then
                LEFTFORM_TAB.Text = ""
            Else
                CUST_CD.Focus()
            End If

            MODIFY_YN.Text = "N"

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub


    Public Sub PrintData()
        Try
            If PrintValidate() = False Then Exit Sub

            Dim frmMain As YJIT.SC.UI.IMainForm = IMainForm
            Dim fTarget As Object = frmMain.NavigateTo("CrmAsPrint", UI.NavigatedWindowModes.Dialog, False)
            fTarget.S_MNGT_NO.Text = MNGT_NO.Text
            fTarget.ShowDialog()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Function PrintValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        'Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

        Try
            If String.IsNullOrEmpty(MNGT_NO.Text) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = CUST_CD
                ErrMsg &= "자료를 검색후 출력하세요." & vbNewLine
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


    Private Function SendMailValidate(ByVal SendType As SendMailType) As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        'Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

        Try
            If String.IsNullOrEmpty(MNGT_NO.Text) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = CUST_CD
                ErrMsg &= "자료를 검색후 전송하세요." & vbNewLine
            End If

            If String.IsNullOrEmpty(REQ_EMAIL.Text) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = REQ_EMAIL
                ErrMsg &= "이메일을 입력해주세요." & vbNewLine
            End If

            Select Case PROC_TYPE.SelectedValue
                Case "1", "2"
                    '완료건만 전송가능
                Case Else
                    If ErrControl Is Nothing Then ErrControl = CUST_CD
                    ErrMsg &= "완료,즉시처리건만 메일전송이 가능합니다." & vbNewLine
            End Select

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

    Private Sub PaymentData()
        Try
            Dim frmMain As YJIT.SC.UI.IMainForm = IMainForm
            Dim fTarget As Object = frmMain.NavigateTo("CrmAsPayment", UI.NavigatedWindowModes.Dialog, False)
            If Not fTarget Is Nothing Then
                fTarget.WG_PAY.DataSource = CType(WG_PAY.DataSource, DataTable).Copy
                fTarget.ShowDialog()
                If fTarget.SaveYN = "Y" Then
                    WG_PAY.DataSource = CType(fTarget.WG_PAY.DataSource, DataTable).Copy
                    Call SetPaymentView()
                    If Not String.IsNullOrEmpty(MNGT_NO.Text) Then
                        Call SaveData()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Sub SendMail(ByVal SendType As SendMailType)
        If SendMailValidate(SendType) = False Then Exit Sub

        Select Case SendType
            Case SendMailType.CompleteMail
                Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
                Dim fTarget As Object = Nothing
                frmMain = IMainForm
                fTarget = frmMain.NavigateTo("ComSendMail", NavigatedWindowModes.Dialog, False)
                If Not IsNothing(fTarget) Then
                    fTarget.RECEIVER.TEXT = REQ_EMAIL.Text
                    fTarget.S_MNGT_NO.TEXT = MNGT_NO.Text
                    fTarget.S_CUST_CD.TEXT = CUST_CD.Text
                    fTarget.S_MSG_TYPE.Text = "100" '완료메일
                    fTarget.S_MSG_TYPE2.Text = "100"
                    fTarget.ShowDialog()
                End If
        End Select
    End Sub

    Public Sub NavigetToCrmAsList()
        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing

        frmMain = IMainForm
        fTarget = frmMain.NavigateTo("CrmAsList")
        If Not IsNothing(fTarget) Then

        End If
    End Sub

    Private Sub SearchLeftForm(ByVal ctrlContainer As Object)
        For Each ctrl As Object In ctrlContainer.Controls
            Debug.Print(ctrl.GetType.Name & "   /   " & ctrl.Name)
            If String.Equals(ctrl.GetType.Name, "CrmLeftForm", StringComparison.InvariantCultureIgnoreCase) Then
                ctrl.SearchData("")
                MODIFY_YN.Text = "N"
                Exit For
            End If

            ' If the control has children, 
            ' recursively call this function 
            If ctrl.HasChildren Then
                SearchLeftForm(ctrl)
            End If
        Next
    End Sub

    Private Sub GetCustomerRmk(ByVal custRemark As String)

        Dim filePath As String = Application.StartupPath & "\TMP_OUTPUT" & "\CRM_" & CUST_CD.Text & ".html"
        If Not IO.Directory.Exists(Application.StartupPath & "\TMP_OUTPUT") Then
            'Create local path
            IO.Directory.CreateDirectory(Application.StartupPath & "\TMP_OUTPUT")
        End If
        IO.File.WriteAllText(filePath, custRemark)

        '2. check if the local _files not exists, download from server
        Dim sLocalPath As String = Application.StartupPath & "\TMP_OUTPUT" & "\CRM_" & CUST_CD.Text & "_files\"
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
        CUST_RMK.LoadDocument(filePath, DocumentFormat.Html)
    End Sub


    Private Sub setGridAddRow(ByVal obj As YJIT.SC.UI.SCControls.WebGrid)
        Dim GvAddRow As New DataTable
        Dim dr As DataRow
        GvAddRow.Columns.Add("Key")
        GvAddRow.Columns.Add("Sender")
        GvAddRow.Columns.Add("Action", GetType(Action))
        GvAddRow.Rows.Add()
        dr = GvAddRow.Rows(0)

        dr("Sender") = obj.Name
        dr("Key") = obj.Name + "_AddRow"
        dr("Action") = Action.Addrow
        obj.AddRow()

        'PopUpOnAfterClick(GvAddRow.Rows(0))

    End Sub
    Private Sub Wg2AddRow()

        If GV2.RowCount = 0 Then Call setGridAddRow(WG2)
        WG2.Focus()
        GV2.ShowEditor()
        GV2.FocusedColumn = GV2.Columns("DOC_TYPE")

    End Sub

    Public Function MandatoryGridValue(ByVal gridView As String) As Boolean
        Dim Param As New Dictionary(Of String, Object)
        Dim checkNull() As String = Nothing

        Select Case gridView
            Case "GV2"
                checkNull = {"FILE_NM"}
                'Param("FILE_NM") = GV2_FILE_NM.Caption

                Return ValidateGridValue(GV2, Param, checkNull)
        End Select

        Return True

    End Function

    Private Sub SearchHistory()

        Dim ds As DataSet = Nothing
        Dim dr As DataRow = Nothing

        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgt_v4", "SearchHistory", Me.ConvertToDataset)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode").ToString <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg").ToString, MessageBoxButtons.OK, "Warning", MessageBoxIcon.Warning)
        End If

        Try
            bBindingFlag = True
            Me.BindToDataset(ds, "Data")
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        Finally
            bBindingFlag = False
        End Try

    End Sub

    Private Sub SetPaymentView()
        btnPayment.Text = GV_PAY.RowCount & "건"
        If CDec(btnPayment.Text.Replace("건", "")) = 0 Then
            If EX_IM_TYPE.SelectedValue = "E" Then
                btnPayment.Visible = btnPayment.Enabled
            Else
                btnPayment.Visible = False
            End If
        Else
            btnPayment.Visible = btnPayment.Enabled
        End If
    End Sub
#End Region

#Region "=================Control Events==========="
    Private Sub CrmAsInput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            comdoc = New ComDoc(WG2)
            InitData()
            Call PopUpInit()
            Call GridInit()
            '20240214 김정현 SHOWN에 있던 REQ_SVC 관련 함수들 위치 변경
            Call SetReqSvc()
            Call NewData()
            'Call SetReqSvc2(REQ_SVC.SelectedValue) 'NewData와 중복수행으로 주석처리 
            Call SetReqSvc3()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message & " (FormLoad)")
        Finally
            LoadFlag = False
        End Try
    End Sub

    Public Sub CrmAsInput_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Try
            SetMandatoryLine(Me)

            MODIFY_YN.Text = "N"
            '240214 김정현 Load 이벤트로 옮김
            'Call SetReqSvc()
            'Call SetReqSvc2(REQ_SVC.SelectedValue)
            'Call SetReqSvc3()

            CUST_CD.Focus()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message & " (FormShown)")
        Finally
            SplitMain.Size = New System.Drawing.Size(SplitMain.Size.Width - 20, SplitMain.Size.Height - 35)
            palAutoButton.Size = New System.Drawing.Size(palAutoButton.Size.Width - 20, palAutoButton.Height)
            xtcMain.Size = New System.Drawing.Size(xtcMain.Size.Width - 20, xtcMain.Height)
            'CustomerPanel.Size = New System.Drawing.Size(CustomerPanel.Size.Width - 20, CustomerPanel.Height)
            CustomerPanel.Location = New System.Drawing.Point(CustomerPanel.Location.X, WORK_USR.Location.Y + WORK_USR.Height + 2)
            ShownFlag = False
        End Try
    End Sub

    'CrmAsMgt_v5 에서 사용하기 위해서 추가
    Public Sub FormShown(Optional ByVal form As Object = Nothing)
        'Dim obj As Object
        'If form Is Nothing Then obj = Me

        'AddDic(WG1.Name) = PopUp
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        mainForm = form

    End Sub

    Private Sub CONTENT_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONTENT.Enter
        CONTENT.SelectionStart = Len(CONTENT.Text)
    End Sub

    Private Sub RMK_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RMK.Enter
        RMK.SelectionStart = Len(RMK.Text)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ONLINE_YN.Text = "Y" Then
            ONLINE_YN.Text = "A"
        End If
        SaveData()
    End Sub

    Private Sub btnList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnList.Click
        Call NavigetToCrmAsList()
    End Sub

    Private Sub REQ_USR_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles REQ_USR.PreviewKeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And (REQ_USR.Text <> OLD_REQ_USR.Text) Then
            Call SearchCustomerPic()
            'ElseIf (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) Then
            '    REQ_USR.NextFocus = "TEL_NO"
        End If
    End Sub

    Private Sub PIC_LIST_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUST_PIC_LIST.EditValueChanged
        If CUST_PIC_LIST.EditValue = "" Then Exit Sub
        REQ_USR.Text = CUST_PIC_LIST.EditValue
        'Dim dr As DataRowView = CUST_PIC_LIST.GetSelectedDataRow
        'Dim STR As String = CUST_PIC_LIST.SelectedText
        TEL_NO.Text = CUST_PIC_LIST.GetColumnValue("TEL_NO")

        'Call SearchCustomerPic()
        TEL_NO.Select()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Call NewData()
        CUST_CD.Focus()
    End Sub

    '20190820 김성은 마우스클릭스 자동으로 닫기는 오류가 있어서 사용안함
    'Private Sub DROPPEDDOWN_GotFocus(sender As Object, e As System.EventArgs) Handles PROC_TYPE.GotFocus, DEPT_AUTH_LIST.GotFocus, PRIORITY.GotFocus, WORK_USR.GotFocus, REQ_SVC.GotFocus, REQ_SVC2.GotFocus, REQ_TYPE2.GotFocus, EX_IM_TYPE.GotFocus, RANK.GotFocus
    '    sender.DroppedDown = True
    'End Sub

    Private Sub PROC_TYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PROC_TYPE.SelectedIndexChanged
        If LoadFlag = True Then Exit Sub
        If ShownFlag = True Then Exit Sub
        If bBindingFlag = True Then Exit Sub
        If bSearchFlag = True Then Exit Sub


        If PROC_TYPE.SelectedValue = "0" Then
            If Not String.IsNullOrEmpty(WORK_USR_CHK.Text) Then
                If WORK_USR_CHK.Text = "NULL" Then
                    WORK_USR.SelectedValue = ""
                Else
                    If String.IsNullOrEmpty(MNGT_NO.Text) Then
                        WORK_USR.SelectedValue = WORK_USR_CHK.Text
                    End If
                End If

                WORK_USR_CHK.Text = ""
            Else
                WORK_USR.SelectedValue = ClientSessionInfo.UserID
            End If
        Else
            If WORK_USR.SelectedValue = ClientSessionInfo.UserID Then
                '미처리
            Else
                If String.IsNullOrEmpty(WORK_USR.SelectedValue) Then
                    WORK_USR_CHK.Text = "NULL"
                Else
                    WORK_USR_CHK.Text = WORK_USR.SelectedValue
                End If
                '20181021 김성은 필요없는 조건으로 판단됨
                'WORK_USR.SelectedValue = ClientSessionInfo.UserID
            End If
        End If


        'If ClientSessionInfo.OrganizationCode = DEPT_CD.SelectedValue Then
        '    If PROC_TYPE.SelectedValue = "1" Or PROC_TYPE.SelectedValue = "2" Or PROC_TYPE.SelectedValue = "7" Or PROC_TYPE.SelectedValue = "8" Then
        '        WORK_USR.SelectedValue = ClientSessionInfo.UserID
        '    ElseIf PROC_TYPE.SelectedValue = "7" Then
        '        CMPT_YMD.Text = ""
        '        CMPT_HM.Text = ""
        '    Else
        '        CMPT_YMD.Text = ""
        '        CMPT_HM.Text = ""
        '        WORK_USR.SelectedValue = ""
        '    End If
        'End If
        Select Case PROC_TYPE.SelectedValue
            Case "1", "2"
                CMPT_YMD.Text = Now.ToString("yyyyMMdd")
                CMPT_HM.Text = Now.ToString("HHmmss")
            Case "7"
                If Not String.IsNullOrEmpty(DEV_AUTH.SelectedValue) Then
                    CMPT_YMD.Text = Now.ToString("yyyyMMdd")
                    CMPT_HM.Text = Now.ToString("HHmmss")
                End If
        End Select
    End Sub
    Private Sub PRIORITY_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRIORITY.SelectedIndexChanged
        If LoadFlag = True Then Exit Sub
        If ShownFlag = True Then Exit Sub
        If bBindingFlag = True Then Exit Sub
        If bSearchFlag = True Then Exit Sub

        '3일때 내일처리, 4일때 일주일
        Select Case PRIORITY.SelectedValue
            Case "3"
                PRAR_YMD.Text = Now.AddDays(1).ToString("yyyyMMdd")
            Case "4"
                PRAR_YMD.Text = Now.AddDays(7).ToString("yyyyMMdd")
            Case Else
                PRAR_YMD.Text = ""
        End Select
    End Sub

    Private Sub PROC_TYPE_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles PROC_TYPE.PreviewKeyDown
        If e.KeyCode = Keys.Space Then
            PROC_TYPE.DroppedDown = True
        End If
    End Sub
    Private Sub GV2_CustomColumnDisplayText(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GV2.CustomColumnDisplayText
        Dim view As ColumnView = TryCast(sender, ColumnView)
        If e.Column.FieldName = "FILE_SIZE" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
            If String.IsNullOrEmpty(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "FILE_SIZE").ToString) Then
                e.DisplayText = "0KB"
            Else
                Dim fileSize As Decimal = CDec(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "FILE_SIZE"))
                e.DisplayText = String.Format("{0:N0}KB", fileSize / 1024)
            End If
        End If
    End Sub
    ''Slip List (Summary) Band Header 에 Sort Image 넣기
    'Private Sub GV2_CustomDrawBandHeader(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.BandedGrid.BandHeaderCustomDrawEventArgs) Handles GV2.CustomDrawBandHeader
    '    Dim skin As DevExpress.Skins.Skin = DevExpress.Skins.GridSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default)
    '    Dim element As DevExpress.Skins.SkinElement = skin(DevExpress.Skins.GridSkins.SkinSortShape)
    '    GV2.Images = element.Image.GetImages()
    'End Sub
    ''Slip List (Summary) MouseDown (Sort)
    'Private Sub GV2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GV2.MouseDown
    '    Dim gv As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView = GV2
    '    Dim hitInfo As DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitInfo = gv.CalcHitInfo(e.Location)

    '    If hitInfo.InBandPanel Then
    '        If hitInfo.HitTest = DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitTest.BandEdge Then  '경계선 클릭시 Sort를 무효화 한다.
    '            bSortEnable = False
    '        Else
    '            bSortEnable = True
    '        End If
    '    End If
    'End Sub    'Slip List (Summary) MouseUp (Sort)
    'Private Sub GV2_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GV2.MouseUp
    '    If bSortEnable = False Then Exit Sub 'MouseDown Event에서 경계선을 클릭한 경우 Sort를 하지 않음

    '    'Band Click시 해당 컬럼 Sort (상위밴드 클릭시에는 Sort하지 않는다)
    '    Dim gv As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView = GV2

    '    Dim hitInfo As DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitInfo = gv.CalcHitInfo(e.Location)
    '    Dim sortFlag As Integer

    '    If hitInfo.InBandPanel Then
    '        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
    '        If hitInfo.HitTest = DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitTest.BandEdge Then Exit Sub
    '        If hitInfo.Band Is Nothing Then Exit Sub
    '        If hitInfo.Band.Columns.VisibleColumnCount <= 0 Then Exit Sub

    '        sortFlag = hitInfo.Band.Columns(0).SortOrder
    '        gv.ClearSorting()   'Sort Clear.

    '        '해당 스킨의 이미지를 가져온다
    '        Dim skin As DevExpress.Skins.Skin = DevExpress.Skins.GridSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default)
    '        Dim element As DevExpress.Skins.SkinElement = skin(DevExpress.Skins.GridSkins.SkinSortShape)
    '        gv.Images = element.Image.GetImages()

    '        'Sort Image 초기화(기존에 그려진 Sort 화살표를 없앤다)
    '        For Each band As DevExpress.XtraGrid.Views.BandedGrid.GridBand In gv.Bands
    '            band.ImageIndex = -1

    '            'Band Children Sort Image 초기화
    '            If band.Children.Count > 0 Then
    '                For i As Integer = 0 To band.Children.Count - 1
    '                    band.Children(i).ImageIndex = -1
    '                Next
    '            End If
    '        Next

    '        If sortFlag = DevExpress.Data.ColumnSortOrder.Ascending Then
    '            hitInfo.Band.ImageIndex = 0
    '            hitInfo.Band.ImageAlignment = System.Drawing.StringAlignment.Far    'Image 오른쪽 정렬
    '            hitInfo.Band.Columns(0).SortOrder = DevExpress.Data.ColumnSortOrder.Descending
    '        Else
    '            hitInfo.Band.ImageIndex = 1
    '            hitInfo.Band.ImageAlignment = System.Drawing.StringAlignment.Far    'Image 오른쪽 정렬
    '            hitInfo.Band.Columns(0).SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
    '        End If

    '    End If
    'End Sub
#End Region

    '===================================================================================================================
    '함수이동
    '===================================================================================================================

    'Private Function GetConvertToDataSet(ByVal KEY As String) As DataSet
    '    Dim YJSql As New YJQuery
    '    Dim ds As DataSet = Me.ConvertToDataset

    '    Try
    '        Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
    '        Select Case KEY
    '            Case "CrmUserInfo"
    '                YJSql.SqlBox("CrmUserInfo", "Common@CrmUserInfo", True)
    '        End Select
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try

    '    Return YJSql.DataSet
    'End Function

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData("")
    End Sub

    Private Sub btnCmptMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCmptMail.Click
        Call SendMail(SendMailType.CompleteMail)
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        Call PaymentData()
    End Sub

    Private Sub CUST_CD_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUST_CD.Validated
        Call SearchHistory()
    End Sub

    'Private Sub DEPT_CD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DEPT_CD.SelectedIndexChanged
    '    If ShownFlag = True Then
    '        Exit Sub
    '    End If

    '    Call SetReqSvc()
    '    Call SetReqSvc2(REQ_SVC.SelectedValue)
    '    Call SetReqSvc3()

    '    'SetUserList(WORK_USR_LIST, DEPT_CD.SelectedValue)
    '    'SetDept(DEPT_AUTH_LIST, DEPT_CD.SelectedValue)
    'End Sub

    'Private Sub DEPT_AUTH_LIST_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DEPT_AUTH_LIST2.KeyDown
    '    If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
    '        REQ_SVC.Focus()
    '        'If WORK_USR.Enabled = False Then
    '        '    PRAR_YMD.Focus()
    '        'Else
    '        '    WORK_USR.Focus()
    '        'End If
    '    End If
    'End Sub

    'Private Sub DEPT_AUTH_LIST_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DEPT_AUTH_LIST2.KeyUp
    '    If e.KeyCode = Keys.Space Then
    '        sender.ShowPopup()
    '    End If
    'End Sub

    Private Sub DEPT_CD_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles REQ_TYPE2.KeyDown, REQ_TYPE.KeyDown, REQ_SVC2.KeyDown, REQ_SVC.KeyDown, PROC_TYPE.KeyDown, PRIORITY.KeyDown, FREE_YN.KeyDown, DEPT_CD.KeyDown, EX_IM_TYPE.KeyDown, WORK_USR.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.DroppedDown = True
        End If
    End Sub

    Private Sub REQ_SVC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REQ_SVC.SelectedIndexChanged
        If LoadFlag = True Then Exit Sub
        If ShownFlag = True Then Exit Sub
        If bBindingFlag = True Then Exit Sub
        If bSearchFlag = True Then Exit Sub

        Call SetReqSvc2(REQ_SVC.SelectedValue)
        Call SetReqSvc3()

        Select Case REQ_SVC.SelectedValue
            Case "A"
                REQ_TYPE.SelectedValue = "08"
                REQ_TYPE2.SelectedValue = "99"
            Case "Q"
                REQ_TYPE.SelectedValue = "11"
                REQ_TYPE2.SelectedValue = "99"
            Case "CS"
                DEV_AUTH.SelectedValue = "04"

        End Select
    End Sub

    Private Sub GV3_CustomRowCellEdit(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles GV3.CustomRowCellEdit
        If e.Column Is Nothing Then Exit Sub
        If e.RowHandle < 0 Then Exit Sub
        If e.Column.FieldName = GV3.FocusedColumn.FieldName And e.RowHandle = GV3.FocusedRowHandle Then
            Select Case e.Column.FieldName
                Case "DEV_CONTENT"
                    e.RepositoryItem = RepositoryItemMemoExEdit2
                Case "CONTENT"
                    e.RepositoryItem = RepositoryItemMemoExEdit2
                Case Else
                    '  e.RepositoryItem = Nothing
            End Select
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing

        frmMain = IMainForm
        fTarget = frmMain.NavigateTo("DetailView", NavigatedWindowModes.Dialog, False)
        If Not IsNothing(fTarget) Then
            fTarget.RMK.Text = CONTENT.Text
            fTarget.ShowDialog()
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing


        frmMain = IMainForm
        fTarget = frmMain.NavigateTo("DetailView", NavigatedWindowModes.Dialog, False)
        If Not IsNothing(fTarget) Then
            fTarget.RMK.Text = RMK.Text
            fTarget.ShowDialog()
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If CUST_CD.Text = "" Then Exit Sub

        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing
        frmMain = IMainForm
        fTarget = frmMain.NavigateTo("CrmCustomerMgt")
        If Not IsNothing(fTarget) Then
            Dim SearchType As String = fTarget.SEARCH_TYPE.SelectedValue.ToString
            fTarget.SEARCH_TYPE.SelectedValue = "CUST_CD"
            fTarget.SEARCH_KEY.Text = CUST_CD.Text
            fTarget.SearchData()
            fTarget.SEARCH_TYPE.SelectedValue = SearchType
        End If

    End Sub

    Private Sub GV4_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GV41.DoubleClick
        If GV41.RowCount = 0 Then Exit Sub

        ''Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        ''Dim fTarget As Object = Nothing

        ''frmMain = IMainForm
        ''fTarget = frmMain.NavigateTo("CrmAsView", NavigatedWindowModes.Dialog, False)
        ''If Not IsNothing(fTarget) Then
        ''    fTarget.frmMain = frmMain
        ''    fTarget.sMngtNo = GV41.GetRowCellValue(GV41.FocusedRowHandle, "MNGT_NO").ToString
        ''    'fTarget.SearchData()
        ''    fTarget.ShowDialog()
        ''End If

        Call SearchData("SearchTop")
    End Sub

    Private Sub OUTSTAND_AMT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OUTSTAND_AMT.TextChanged
        lbl_OUTSTAND_AMT.Text = "미수: " & OUTSTAND_AMT.Text
    End Sub
    Private Sub STOP_YMD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STOP_YMD.TextChanged
        If String.IsNullOrEmpty(STOP_YMD.Text) Then
            ' 20230719 / 김태룡, 김성은 / 공간확보를 위해 년도 2자리로 변경 / CRM YJITS2023030532
            'lbl_STOP_YMD.Text = "중지예정일: 0000-00-00"
            lbl_STOP_YMD.Text = "중지예정일: 00-00-00"
        Else
            ' 20230719 / 김태룡, 김성은 / 공간확보를 위해 년도 2자리로 변경 / CRM YJITS2023030532
            'lbl_STOP_YMD.Text = "중지예정일: " & Mid(STOP_YMD.Text, 1, 4) & "-" & Mid(STOP_YMD.Text, 5, 2) & "-" & Mid(STOP_YMD.Text, 7, 2)
            lbl_STOP_YMD.Text = "중지예정일: " & Mid(STOP_YMD.Text, 3, 2) & "-" & Mid(STOP_YMD.Text, 5, 2) & "-" & Mid(STOP_YMD.Text, 7, 2)
        End If
    End Sub
    Private Sub BANK_YN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BANK_YN.TextChanged
        If String.IsNullOrEmpty(BANK_YN.Text) Then
            lbl_BANK_YN.Text = "자동이체 :"
        Else
            lbl_BANK_YN.Text = "자동이체: " & BANK_YN.Text
        End If
        If BANK_YN.Text = "N" Then
            lbl_BANK_YN.BackColor = System.Drawing.Color.Red
        Else
            lbl_BANK_YN.BackColor = System.Drawing.Color.Transparent
        End If
    End Sub
    Private Sub STOP_CHECK_YN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STOP_YN.TextChanged, CHECK_YN.TextChanged
        If STOP_YN.Text = "Y" AndAlso CHECK_YN.Text = "Y" Then
            lbl_STOP_YMD.BackColor = System.Drawing.Color.Red
        Else
            lbl_STOP_YMD.BackColor = System.Drawing.Color.Transparent
        End If
    End Sub

    ' 20230719 / 김태룡, 김성은 / 전자세금계산서 중계사 라벨표현 / CRM YJITS2023030532
    Private Sub TAX_TRANS_TYPE_TextChanged(sender As Object, e As EventArgs) Handles TAX_TRANS_TYPE.TextChanged
        If String.IsNullOrEmpty(TAX_TRANS_TYPE.Text) Then
            lbl_TAX_TRANS_TYPE.Text = "계산서중계사"
        Else
            lbl_TAX_TRANS_TYPE.Text = TAX_TRANS_TYPE.Text
        End If
    End Sub


    'Private Sub SYS_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If String.IsNullOrEmpty(SYS_ID.Text) OrElse SYS_ID.Text = "CRM" Then
    '        lbl_SYS_ID.Font = New System.Drawing.Font("Segoe UI Symbol", 9)
    '        SYS_ID.BackColor = Nothing
    '    Else
    '        lbl_SYS_ID.Font = New System.Drawing.Font("Segoe UI Symbol", 9, System.Drawing.FontStyle.Bold)
    '        SYS_ID.BackColor = System.Drawing.Color.LightPink
    '    End If
    'End Sub

    Private Sub WORK_USR_CHK_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WORK_USR_CHK.TextChanged
        If WORK_USR_CHK.Text <> "" Then
            lbl_WORK_USR.Font = New System.Drawing.Font("Segoe UI Symbol", 9, System.Drawing.FontStyle.Bold)
            WORK_USR.BackColor = System.Drawing.Color.LightPink
            WORK_USR.Font = New System.Drawing.Font("Segoe UI Symbol", 9, System.Drawing.FontStyle.Bold)
        Else
            lbl_WORK_USR.Font = New System.Drawing.Font("Segoe UI Symbol", 9)
            WORK_USR.Font = New System.Drawing.Font("Segoe UI Symbol", 9)
        End If
    End Sub

    Private Sub btnSaveLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveLeft.Click
        Call SaveOnlineData()
    End Sub

    Public Sub SaveOnlineData()
        ONLINE_YN.Text = "Y"

        '신규자료, 온라인접수 처리시 고객지원팀으로 자동공유처리
        Select Case ClientSessionInfo.OrganizationCode
            Case "01"
                '고객지원팀은 불필요
            Case Else
                '20210826 김성은 저장 이후 재공유시 온라인접수건이 왼쪽 패널에 표시안되는 부분이 있어서 변경
                DEPT_CD.SelectedValue = "01"
                PROC_TYPE.SelectedValue = "0"
                Call ClearView(AppliedRangeTypes.Only, {DEV_AUTH, DEPT_AUTH_LIST})

                'If String.IsNullOrEmpty(MNGT_NO.Text) Then
                '    '20200722 김성은 온라인접수, 요청완료건 분리하기 위해서 수정
                '    DEPT_CD.SelectedValue = "01"
                '    'DEPT_AUTH_LIST.SelectedValue = "01"
                '    'PROC_TYPE.SelectedValue = "1"
                '    'REQ_TYPE2.SelectedValue = "99"
                '    'RMK.Text = "온라인접수 등록완료"
                'End If
        End Select

        Call SaveData()
    End Sub


    Private Sub SYS_ID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYS_ID.SelectedIndexChanged
        If LoadFlag = True Then Exit Sub
        If ShownFlag = True Then Exit Sub
        If bBindingFlag = True Then Exit Sub
        If bSearchFlag = True Then Exit Sub

        Select Case SYS_ID.SelectedValue
            Case "CRM", "MAIL"
                'lbl_SYS_ID.Font = New System.Drawing.Font("Segoe UI Symbol", 9)
                SYS_ID.Font = New System.Drawing.Font("Segoe UI Symbol", 9)
            Case Else
                'lbl_SYS_ID.Font = New System.Drawing.Font("Segoe UI Symbol", 9, System.Drawing.FontStyle.Bold)
                SYS_ID.BackColor = System.Drawing.Color.LightPink
                SYS_ID.Font = New System.Drawing.Font("Segoe UI Symbol", 9, System.Drawing.FontStyle.Bold)
        End Select
    End Sub

    Private Sub REQ_YMD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REQ_YMD.TextChanged, REQ_HM.TextChanged, TEL_NO.TextChanged, REQ_USR.TextChanged, CONTENT.TextChanged, PRAR_YMD.TextChanged, CMPT_YMD.TextChanged, CMPT_HM.TextChanged, RMK.TextChanged, CUST_CD.TextChanged
        If LoadFlag = True Then Exit Sub
        If ShownFlag = True Then Exit Sub
        If bBindingFlag = True Then Exit Sub
        If bSearchFlag = True Then Exit Sub

        If MODIFY_YN.Text = "N" Then
            MODIFY_YN.Text = "Y"
        End If
    End Sub

    Private Sub WORK_USR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WORK_USR.SelectedIndexChanged, REQ_TYPE2.SelectedIndexChanged, REQ_TYPE.SelectedIndexChanged, REQ_SVC2.SelectedIndexChanged, REQ_SVC.SelectedIndexChanged, PROC_TYPE.SelectedIndexChanged, PRIORITY.SelectedIndexChanged, FREE_YN.SelectedIndexChanged, EX_IM_TYPE.SelectedIndexChanged
        If LoadFlag = True Then Exit Sub
        If ShownFlag = True Then Exit Sub
        If bBindingFlag = True Then Exit Sub
        If bSearchFlag = True Then Exit Sub

        If MODIFY_YN.Text = "N" Then
            MODIFY_YN.Text = "Y"
        End If

        Select Case sender.Name.ToUpper
            Case REQ_SVC2.Name.ToUpper
                If REQ_SVC2.GetItemText(REQ_SVC2.SelectedItem).ToString = "회의" Then
                    '20200921 김성은 김영숙대표님 지시로 제거 / 형식 구애받지않고 담당자가 알아서 작성하도록 수정 
                    'If CONTENT.Text.ToString.IndexOf("① 회의 목적") = -1 _
                    '             AndAlso CONTENT.Text.ToString.IndexOf("② 회의 내용") = -1 Then
                    '    If Not String.IsNullOrEmpty(CONTENT.Text.ToString) AndAlso Not CONTENT.Text.ToString.LastIndexOf(vbCrLf) Then CONTENT.Text &= vbCrLf
                    '    CONTENT.Text &= "① 회의 목적 " & vbCrLf
                    '    CONTENT.Text &= "    1) " & vbCrLf
                    '    CONTENT.Text &= "② 회의 내용" & vbCrLf
                    '    CONTENT.Text &= "    1) "
                    'End If

                    'If RMK.Text.ToString.IndexOf("③ 조치 방안") = -1 Then
                    '    If Not String.IsNullOrEmpty(RMK.Text.ToString) AndAlso Not RMK.Text.ToString.LastIndexOf(vbCrLf) Then RMK.Text &= vbCrLf
                    '    RMK.Text &= "③ 조치 방안 " & vbCrLf
                    '    RMK.Text &= "    1) " & vbCrLf
                    'End If

                    If CMPT_RMK.Text.ToString.IndexOf("#회의제목#") = -1 _
                                 AndAlso CMPT_RMK.Text.ToString.IndexOf("#회의장소#") = -1 _
                                 AndAlso CMPT_RMK.Text.ToString.IndexOf("#참석인원외부#") = -1 _
                                 AndAlso CMPT_RMK.Text.ToString.IndexOf("#참석인원내부#") = -1 Then
                        If Not String.IsNullOrEmpty(CMPT_RMK.Text.ToString) AndAlso Not CMPT_RMK.Text.ToString.LastIndexOf(vbCrLf) Then CMPT_RMK.Text &= vbCrLf
                        CMPT_RMK.Text &= "#회의제목# " & vbCrLf
                        CMPT_RMK.Text &= "#회의장소# " & vbCrLf
                        CMPT_RMK.Text &= "#참석인원외부# " & vbCrLf
                        CMPT_RMK.Text &= "#참석인원내부# "
                    End If
                End If
            Case EX_IM_TYPE.Name.ToUpper
                Call SetPaymentView()
        End Select
    End Sub

    Private Sub DEPT_AUTH_LIST_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DEPT_AUTH_LIST.SelectedIndexChanged
        If LoadFlag = True Then Exit Sub
        If ShownFlag = True Then Exit Sub
        If bBindingFlag = True Then Exit Sub
        If bSearchFlag = True Then Exit Sub

        If String.IsNullOrEmpty(DEPT_AUTH_LIST.SelectedValue.ToString) Then
            lbl_DEPT_AUTH_LIST.Font = New System.Drawing.Font("Segoe UI Symbol", 9)
            'DEPT_AUTH_LIST.Font = New System.Drawing.Font("Segoe UI Symbol", 9)
        Else
            lbl_DEPT_AUTH_LIST.Font = New System.Drawing.Font("Segoe UI Symbol", 9, System.Drawing.FontStyle.Bold)
            '20190820 김성은 / 키보드로 이동시 팝업창이 종료되는 버그가 있어서 주석
            'DEPT_AUTH_LIST.BackColor = System.Drawing.Color.LightPink
            'DEPT_AUTH_LIST.Font = New System.Drawing.Font("Segoe UI Symbol", 9, System.Drawing.FontStyle.Bold)
        End If

        If LoadFlag = True Then Exit Sub
        If ShownFlag = True Then Exit Sub
        If bBindingFlag = True Then Exit Sub
        If bSearchFlag = True Then Exit Sub

        If MODIFY_YN.Text = "N" Then
            MODIFY_YN.Text = "Y"
        End If

        If Not String.IsNullOrEmpty(DEPT_AUTH_LIST.SelectedValue) AndAlso (String.IsNullOrEmpty(PROC_TYPE.SelectedValue) OrElse PROC_TYPE.SelectedValue = 0) Then
            PROC_TYPE.SelectedValue = "7"
        End If

        If Not String.IsNullOrEmpty(DEPT_AUTH_LIST.SelectedValue) AndAlso PROC_TYPE.SelectedValue = "7" Then
            CMPT_YMD.Text = Now.ToString("yyyyMMdd")
            CMPT_HM.Text = Now.ToString("HHmmss")
        End If

        If String.IsNullOrEmpty(DEPT_AUTH_LIST.SelectedValue) Then
            DEV_AUTH.SelectedValue = ""
        End If
    End Sub

    Private Sub DEV_AUTH_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DEV_AUTH.SelectedIndexChanged
        If LoadFlag = True Then Exit Sub
        If ShownFlag = True Then Exit Sub
        If bBindingFlag = True Then Exit Sub
        If bSearchFlag = True Then Exit Sub

        If String.IsNullOrEmpty(DEV_AUTH.SelectedValue.ToString) Then
            lbl_DEPT_AUTH_LIST.Font = New System.Drawing.Font("Segoe UI Symbol", 9)
            'DEPT_AUTH_LIST.Font = New System.Drawing.Font("Segoe UI Symbol", 9)
        Else
            lbl_DEPT_AUTH_LIST.Font = New System.Drawing.Font("Segoe UI Symbol", 9, System.Drawing.FontStyle.Bold)
            '20190820 김성은 / 키보드로 이동시 팝업창이 종료되는 버그가 있어서 주석
            'DEPT_AUTH_LIST.BackColor = System.Drawing.Color.LightPink
            'DEPT_AUTH_LIST.Font = New System.Drawing.Font("Segoe UI Symbol", 9, System.Drawing.FontStyle.Bold)
        End If

        If LoadFlag = True Then Exit Sub
        If ShownFlag = True Then Exit Sub
        If bBindingFlag = True Then Exit Sub
        If bSearchFlag = True Then Exit Sub

        If MODIFY_YN.Text = "N" Then
            MODIFY_YN.Text = "Y"
        End If

        If Not String.IsNullOrEmpty(DEV_AUTH.SelectedValue) AndAlso PROC_TYPE.SelectedValue = "7" Then
            CMPT_YMD.Text = Now.ToString("yyyyMMdd")
            CMPT_HM.Text = Now.ToString("HHmmss")
        End If

        If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
                AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_COM_CODE") Then
            Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD='C11' AND COMN_CD = '" & DEV_AUTH.SelectedValue & "'", "SORT ASC")
            If drMdm.Count > 0 Then
                For Each drRow As DataRow In drMdm
                    DEV_USR_ID.Text = drRow("OPT_ITEM1").ToString
                    DEPT_AUTH_LIST.SelectedValue = drRow("OPT_ITEM2").ToString
                    Exit For
                Next
            Else
                DEV_USR_ID.Text = ""
                DEPT_AUTH_LIST.SelectedValue = ""
            End If
        End If

    End Sub

    Private Sub SEND_MAIL_YN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEND_MAIL_YN.TextChanged
        If SEND_MAIL_YN.Text = "Y" Then
            REQ_EMAIL.BackColor = System.Drawing.Color.LightPink
            Me.ToolTipController1.SetToolTip(Me.REQ_EMAIL, "메일회신완료")
        Else
            REQ_EMAIL.BackColor = Nothing
            Me.ToolTipController1.SetToolTip(Me.REQ_EMAIL, "")
        End If
    End Sub

    Private Sub answer_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles answer.SelectedValueChanged
        If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
                AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_COM_CODE") Then
            Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD='C12' AND COMN_CD = '" & answer.SelectedValue & "'", "SORT ASC")
            If drMdm.Count > 0 Then
                For Each drRow As DataRow In drMdm
                    CMPT_RMK.Text = drRow("RMK").ToString.Replace("#작업자#", WORK_USR.GetItemText(WORK_USR.SelectedItem).ToString)
                    Exit For
                Next
            End If
        End If


        'If answer.SelectedValue = "A" Then
        '    CMPT_RMK.Text = "안녕하세요, 고객지원팀입니다." & vbCrLf & "유선상으로 안내드렸습니다." & vbCrLf & "감사합니다."
        'ElseIf answer.SelectedValue = "B" Then
        '    CMPT_RMK.Text = "안녕하세요, 고객지원팀입니다." & vbCrLf & "요청하신 부분 확인 후 연락드리겠습니다." & vbCrLf & "감사합니다."
        'ElseIf answer.SelectedValue = "C" Then
        '    CMPT_RMK.Text = "안녕하세요, 고객지원팀입니다." & vbCrLf & "요청하신 부분 수정되었으니 확인하시면 됩니다. " & vbCrLf & "감사합니다."
        'End If
    End Sub


    Private Sub btnCopy_Click(sender As System.Object, e As System.EventArgs) Handles btnCopy.Click
        Call CopyData()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Call PrintData()
    End Sub
    Private Sub GV_PAY_DataSourceChanged(sender As Object, e As EventArgs)
        btnPayment.Text = GV_PAY.RowCount
    End Sub
    Private Sub xtcMain_SelectedPageChanged(sender As System.Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtcMain.SelectedPageChanged
        If xtcMain.SelectedTabPage.Name = xtpEtc.Name Then
            PRAR_YMD.Focus()
        Else
            REQ_YMD.Focus()
        End If
    End Sub

    Private Sub btnPayment_EnabledChanged(sender As Object, e As EventArgs) Handles btnPayment.EnabledChanged
        Call SetPaymentView()
    End Sub

    Private Sub PROJECT_CD_Validated(sender As Object, e As EventArgs) Handles PROJECT_CD.Validated
        If Not String.IsNullOrEmpty(PROJECT_CUST_CD.Text) Then
            CUST_CD.Text = PROJECT_CUST_CD.Text
            CUST_CD.ValidateCode()
        End If
        If Not String.IsNullOrEmpty(PROJECT_CD.Text) Then
            REQ_SVC.SelectedValue = "YB"
        End If
    End Sub

    Private Sub CRN_TextChanged(sender As Object, e As EventArgs) Handles CRN.TextChanged
        Dim ds As DataSet = Nothing
        Dim dr As DataRow = Nothing
        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgt_v4", "SearchAccount", {CRN.Text, CUST_CD.Text})
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        Call ClearView(AppliedRangeTypes.Only, {CHECK_YN, STOP_YN, OUTSTAND_AMT, STOP_YMD})
        If dr("TrxCode") = "Y" Then
            Me.BindToDataset(ds, "Data")
        End If
    End Sub
    Private Sub MNGT_NO_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles MNGT_NO.PreviewKeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) Then
            Call SearchData()
        End If
    End Sub
    Private Sub MNGT_NO_KeyDown(sender As Object, e As KeyEventArgs) Handles MNGT_NO.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch.Focus()
        End If
    End Sub

End Class
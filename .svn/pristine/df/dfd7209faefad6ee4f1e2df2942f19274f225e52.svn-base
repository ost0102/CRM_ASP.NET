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

Public Class CrmAsView
    Public frmMain As YJIT.SC.UI.IMainForm = Nothing
    Public sMngtNo As String = Nothing
    Dim BindPic As String = ""
    Dim BindTel As String = ""
    Private bSortEnable As Boolean = True
    Private comdoc As ComDoc
    Private KeyDownYn As Boolean = False
    Dim UserInfoDt As DataTable = Nothing

    Dim LoadFlag As Boolean = True
    Dim ShownFlag As Boolean = True
    Dim bBindingFlag As Boolean = False

    Dim WORK_USR_FONT_BOLD As New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
    Dim WORK_USR_FONT_ORG As New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)



#Region "=================Data logic actions==========="

    Private Property btnCancel As Object

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
            REQ_SVC2.DataSource = dt

        Catch ex As Exception

        End Try
    End Sub
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
            sender.EditValue = ""
        Catch ex As Exception

        End Try
    End Sub


    Private Sub SetDept(ByVal sender As Object, Optional ByVal ExceptDept As String = "")

        Dim dt As New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")

        Try
            For i = 0 To DeptDt.Rows.Count - 1
                dt.ImportRow(DeptDt.Rows(i))
                dt.Rows(dt.Rows.Count - 1)("NAME") = (i + 1).ToString & "." & dt.Rows(dt.Rows.Count - 1)("NAME").ToString
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

        Dim dt As DataTable = DeptDt.Copy
        For i = 0 To dt.Rows.Count - 1
            dt.Rows(i)("NAME") = i + 1 & "." & dt.Rows(i)("NAME").ToString
        Next
        DEPT_CD.DataSource = dt.Copy

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

        End Try
    End Sub

    Private Sub CopyData()
        '## 파일다운로드 ##
        For Each EachFileName In IO.Directory.GetFiles(comdoc.getTempFolder)
            Dim fInfo As IO.FileInfo = New IO.FileInfo(EachFileName)
            Try
                System.IO.File.Delete(Path.Combine(comdoc.getTempFolder, EachFileName))
            Catch ex As Exception
            End Try
        Next
        For i As Integer = 0 To GV2.RowCount - 1
            Dim retD As New Dictionary(Of String, String)
            If GV2_FORM_ID.ToString <> "OnlineHelp" Then
                retD = comdoc.DownLoadFile(GV2.GetFocusedRowCellValue("MNGT_NO").ToString & "_" & GV2.GetFocusedRowCellValue("SEQ").ToString, _
                       GV2.GetFocusedRowCellValue("FILE_NM").ToString, _
                       GV2.GetFocusedRowCellValue("FILE_PATH").ToString, _
                       comdoc.getTempFolder & "\" & GV2.GetFocusedRowCellValue("FILE_NM").ToString)
            Else
                retD = comdoc.DownLoadFileOnline(GV2.GetFocusedRowCellValue("FILE_NM").ToString, _
                       GV2.GetFocusedRowCellValue("FILE_PATH").ToString, _
                       comdoc.getTempFolder & "\" & GV2.GetFocusedRowCellValue("FILE_NM").ToString)
            End If

            If retD("TrxCode").ToString <> "Y" Then
                MsgBoxLocalized(retD("TrxMsg").ToString, MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Error)
            End If
        Next


        '## 초기화 ##
        Me.ClearView(UI.AppliedRangeTypes.Only, {MNGT_NO, WG2, WG3, PRAR_YMD, CMPT_YMD, CMPT_HM, RMK, CMPT_RMK, WORK_USR_CHK})
        CUST_RMK.CreateNewDocument()

        PROC_TYPE.SelectedValue = 0
        'xtcRemark.SelectedTabPageIndex = 0
        RETURN_YN.YesNo = "N"
        SHARE_YN.YesNo = "N"


        '## 파일 추가 ##
        For Each EachFileName In IO.Directory.GetFiles(comdoc.getTempFolder)
            WG2.AddRow()
            comdoc.InsertFile(comdoc.FileUploadType.FileChoose, GV2.RowCount - 1, {EachFileName}, DBNull.Value)
        Next

    End Sub

    Public Sub NewData()
        Me.ClearView(UI.AppliedRangeTypes.Except, {SCREEN, DirList})
        CUST_RMK.CreateNewDocument()

        SYS_ID.Text = "CRM"
        CONTENT.ReadOnly = False

        INS_YMD.Text = Now.ToString("yyyyMMdd")
        INS_HM.Text = Now.ToString("HHmmss")
        REQ_YMD.Text = Now.ToString("yyyyMMdd")
        REQ_HM.Text = Now.ToString("HHmmss")

        REQ_SVC.SelectedValue = "B"
        PROC_TYPE.SelectedValue = 0
        WORK_USR_CHK.Text = ""
        'SetUserList(WORK_USR_LIST, "01")
        SetDept(DEPT_AUTH_LIST, ClientSessionInfo.OrganizationCode)
        SetReqsvc2(REQ_SVC.SelectedValue)
        PRIORITY.SelectedValue = 2
        FREE_YN.SelectedValue = "Y"
        SHARE_YN.YesNo = "N"
        EX_IM_TYPE.SelectedValue = "I"
        ONLINE_YN.Text = "N"

        'DEPT_CD.Select()

        DEPT_CD.DefVal = ClientSessionInfo.OrganizationCode
        DEPT_CD.SelectedValue = ClientSessionInfo.OrganizationCode

        WORK_USR.SelectedValue = ClientSessionInfo.UserID

        'Call SetControlEnabled()

        CUST_CD.Focus()
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
        GV4.Columns("REQ_SVC").ColumnEdit = editorCombo

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
            GV4.Columns("REQ_SVC2").ColumnEdit = editorCombo
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
        GV4.Columns("REQ_TYPE").ColumnEdit = editorCombo

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
        GV4.Columns("REQ_TYPE2").ColumnEdit = editorCombo

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
        GV4.Columns("CUST_CD").ColumnEdit = editor


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
        GV4.Columns("REQ_USR").ColumnEdit = editor

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
        GV4.Columns("PROC_TYPE").ColumnEdit = editorCombo

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
        GV4.Columns("PRIORITY").ColumnEdit = editorCombo

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
        GV4.Columns("FREE_YN").ColumnEdit = editorCombo

        Common.DrawRowIndicator({GV3})


        Dim editorImgCombo As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox = comdoc.getImageComboBox()
        editorImgCombo.SmallImages = comdoc.getIcons()
        GV2.Columns("FILE_ICON").ColumnEdit = editorImgCombo
        GV2.Columns("SUCCESS").ColumnEdit = editorImgCombo



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

        dt = UserInfoDt.Copy
        dt.Columns("USR_ID").ColumnName = "CODE"
        dt.Columns("LOC_NM").ColumnName = "NAME"

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

        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "T07")
        dataParams.Add("NameType", "")
        Dim T07 As DataTable = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = T07
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV3.Columns("PROC_TYPE").ColumnEdit = editorCombo

        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "T08")
        dataParams.Add("NameType", "")
        Dim T08 As DataTable = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = T08
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV3.Columns("TEST_RESULT").ColumnEdit = editorCombo


        '==================Grid4============================
        dt = New DataTable
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
        GV4.Columns("REQ_SVC").ColumnEdit = editorCombo

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
        GV4.Columns("REQ_TYPE").ColumnEdit = editorCombo


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
        GV4.Columns("REQ_USR").ColumnEdit = editor

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
        GV4.Columns("PROC_TYPE").ColumnEdit = editorCombo

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
        GV4.Columns("FREE_YN").ColumnEdit = editorCombo



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
            If SYS_ID.Text.ToUpper <> "CRM" OrElse String.IsNullOrEmpty(MNGT_NO.Text) Then
                param("Copy") = False
            Else
                If DEPT_CD.SelectedValue <> ClientSessionInfo.OrganizationCode Then
                    param("Copy") = False
                Else
                    param("Copy") = True
                End If
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
                            If GV2_FORM_ID.ToString <> "OnlineHelp" Then
                                retD = comdoc.DownLoadFile(GV2.GetFocusedRowCellValue("MNGT_NO").ToString & "_" & GV2.GetFocusedRowCellValue("SEQ").ToString, _
                                  GV2.GetFocusedRowCellValue("FILE_NM").ToString, _
                                  GV2.GetFocusedRowCellValue("FILE_PATH").ToString, _
                                  SaveFileDialog1.FileName)
                            Else
                                retD = comdoc.DownLoadFileOnline(GV2.GetFocusedRowCellValue("FILE_NM").ToString, _
                                  GV2.GetFocusedRowCellValue("FILE_PATH").ToString, _
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
        PopUp.ItemAdd(Action.Other, "Copy", "Copy")
        PopUp.PopUpInit(Me)

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
        PopUp.PopUpInit(Me, WG4)
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
            REQ_USR.NextFocus = "TEL_NO"
            '   Exit Sub
        Else
            REQ_USR.Text = dr("PIC_NM").ToString
            RANK_NM.Text = dr("RANK_NM").ToString
            REQ_EMAIL.Text = dr("EMAIL").ToString

            ' 담당자의 전화번호가 없는 경우 포커스는 이동하되 빈 값으로 넘어가지 않도록 수정
            If dr("TEL_NO").ToString <> "" Then
                TEL_NO.Text = dr("TEL_NO").ToString
                REQ_USR.NextFocus = "CONTENT"
            Else
                REQ_USR.NextFocus = "TEL_NO"
            End If

        End If

    End Sub


    Private Sub SetCustPicByList(ByVal ds As DataSet)

        MainPanel.Controls.Add(CUST_PIC_LIST)
        CUST_PIC_LIST.Location = New Size(REQ_USR.Location.X, REQ_USR.Location.Y + 1)
        REQ_USR.BringToFront()

        CUST_PIC_LIST.EditValue = ""
        CUST_PIC_LIST.DataBindings.Clear()
        CUST_PIC_LIST.Properties.DataSource = Nothing

        CUST_PIC_LIST.Properties.DataSource = ds.Tables("Data.CUST_PIC_LIST")
        CUST_PIC_LIST.Properties.DisplayMember = "TEL_NO"
        CUST_PIC_LIST.Properties.ValueMember = "PIC_NM"
        CUST_PIC_LIST.EditValue = Nothing
        CUST_PIC_LIST.ShowPopup()
        CUST_PIC_LIST.Focus()

    End Sub


    Public Sub SaveData()
        Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", "잠시만 기다려주세요. 자료처리중입니다.")

            If MandatoryGridValue("GV2") Then Exit Sub

            If CUST_CD.Text.ToString = "" Then
                MsgBoxLocalized("거래처을 입력해주세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                CUST_CD.Focus()
                Exit Sub
            End If

            If (PROC_TYPE.SelectedValue = "1" OrElse PROC_TYPE.SelectedValue = "2") Then
                'If REQ_TYPE.SelectedValue.ToString = "" Then
                '    MsgBoxLocalized("요청사항 구분을 선택하세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                '    REQ_TYPE.Focus()
                '    Exit Sub
                'End If

                If REQ_TYPE2.SelectedValue.ToString = "" Then
                    MsgBoxLocalized("요청상세을 선택하세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                    REQ_TYPE2.Focus()
                    Exit Sub
                End If

                If String.IsNullOrEmpty(RMK.Text) Then
                    'xtcRemark.SelectedTabPage = xtpRMK
                    MsgBoxLocalized("조치사항 입력후 저장하세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                    RMK.Focus()
                    Exit Sub
                End If

                If SYS_ID.Text.ToUpper <> "CRM" _
                           AndAlso String.IsNullOrEmpty(CMPT_RMK.Text) Then
                    'xtcRemark.SelectedTabPage = xtpCMPT_RMK
                    MsgBoxLocalized("답변 입력후 저장하세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                    CMPT_RMK.Focus()
                    Exit Sub
                End If

                'If InStr(WORK_USR_LIST.EditValue.ToString, ";") > 0 Then
                '    MsgBoxLocalized("상담사를 한명만 선택하세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                '    WORK_USR_LIST.Focus()
                '    Exit Sub
                'End If

                If String.IsNullOrEmpty(WORK_USR.SelectedValue) Then
                    MsgBoxLocalized("상담사를 선택하세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                    WORK_USR.Focus()
                    Exit Sub
                End If
            End If

            Dim byteUploadFiles As Dictionary(Of String, Object) = comdoc.byteUploadFiles
            Dim tempFolder As String = comdoc.getTempFolder
            Dim strFileName As String = ""

            Dim dsResult As DataSet

            Dim DS As DataSet = GetConvertToDataSet() 'GetConvertToDataSet("Search") 
            Try
                For i As Integer = 0 To GV2.RowCount - 1
                    GV2.SetRowCellValue(i, "SEQ", comdoc.GetSeq(i, MNGT_NO.Text))
                Next
                comdoc.SetUploadPath(Split(DirList.Text, "/"))

                dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgt_v4", "SaveInput", {DS, comdoc.getUploadPath})
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
                Me.BindToDataset(dsResult, "Data")
                DEPT_AUTH_LIST.EditValue = dsResult.Tables("Data.MAIN").Rows(0)("DEPT_AUTH_LIST").ToString()

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
            Catch ex As Exception

            End Try
        End Using
    End Sub

    Public Sub SearchData()
        If String.IsNullOrEmpty(MNGT_NO.Text) Then Exit Sub

        Dim retDs As DataSet = Nothing
        Try
            Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", "잠시만 기다려주세요. 조회중입니다.")
                retDs = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgt_v4", "Search", Me.ConvertToDataset)
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
            SetReqsvc2(retDs.Tables("Data.MAIN").Rows(0)("REQ_SVC").ToString())
            'SetUserList(WORK_USR_LIST, "01") '고객지원으로 고정
            'SetDept(DEPT_AUTH_LIST, retDs.Tables("Data.MAIN").Rows(0)("DEPT_CD").ToString())

            Try
                bBindingFlag = True
                Me.BindToDataset(retDs, "Data")
            Catch ex As Exception
                MsgBoxLocalized(ex.Message)
            Finally
                bBindingFlag = False
            End Try


            'retDs = AdaptDataSourceForReport(retDs)
            DEPT_AUTH_LIST.EditValue = retDs.Tables("Data.MAIN").Rows(0)("DEPT_AUTH_LIST").ToString()



            'If LEFTFORM_TAB.Text = "xtpNonAssign" Then
            '    LEFTFORM_TAB.Text = "" '작업현황에서 연동시 메세지 표시되는 오류 수정

            '    If PROC_TYPE.SelectedValue = 0 Then
            '        'WORK_USR.SelectedValue = ClientSessionInfo.UserID
            '        MainPanel.Enabled = True
            '        CustomerPanel.Enabled = True
            '        CONTENT.Enabled = True
            '        RMK.Enabled = True
            '        CMPT_RMK.Enabled = True
            '    Else
            '        MainPanel.Enabled = False
            '        CustomerPanel.Enabled = False
            '        CONTENT.Enabled = False
            '        RMK.Enabled = False
            '        CMPT_RMK.Enabled = False
            '        MsgBoxLocalized("작업자가 배정되었습니다.")
            '    End If

            '    Call GetCustomerRmk(retDs.Tables("Data.MAIN").Rows(0)("CUST_RMK").ToString())
            'End If



            'Call SetControlEnabled()


            If SYS_ID.Text.ToUpper = "CRM" Then
                CONTENT.ReadOnly = False
            Else
                CONTENT.ReadOnly = True
            End If

            '20180205 김성은 파일다운로드시 메모리 참조하는 부분이 있어서 초기화 처리
            'For i = 0 To comdoc.byteUploadFiles.Count - 1
            '    comdoc.byteUploadFiles(i) = Nothing
            'Next
            comdoc.ClearFiles()

            Call InitIcons()

            CUST_CD.Focus()

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Sub NavigetToCrmAsList()
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
                ctrl.SearchData()
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
        Me.BindToDataset(ds, "Data")

    End Sub

#End Region

#Region "=================Control Events==========="
    Private Sub CrmAsInput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            comdoc = New ComDoc(WG2)
            InitData()
            Call PopUpInit()
            Call GridInit()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message & " (FormLoad)")
        Finally
            LoadFlag = False
        End Try
    End Sub

    Private Sub CrmAsInput_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Try
            SetMandatoryLine(Me)
            Call NewData()

            If Not String.IsNullOrEmpty(sMngtNo) Then
                MNGT_NO.Text = sMngtNo
                Call SearchData()
            End If

            CUST_CD.Focus()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message & " (FormShown)")
        Finally
            ShownFlag = False
        End Try
    End Sub

    Private Sub CONTENT_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONTENT.Enter
        CONTENT.SelectionStart = Len(CONTENT.Text)
    End Sub

    Private Sub RMK_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RMK.Enter
        RMK.SelectionStart = Len(RMK.Text)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ONLINE_YN.Text = "Y" Then
            ONLINE_YN.Text = "A"
        End If
        SaveData()
    End Sub

    Private Sub btnList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call NewData()
    End Sub

    Private Sub PROC_TYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PROC_TYPE.SelectedIndexChanged
        If LoadFlag = True Then Exit Sub
        If ShownFlag = True Then Exit Sub
        If bBindingFlag = True Then Exit Sub


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
                WORK_USR.SelectedValue = ClientSessionInfo.UserID
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
        If PROC_TYPE.SelectedValue = "1" Then
            CMPT_YMD.Text = Now.ToString("yyyyMMdd")
            CMPT_HM.Text = Now.ToString("HHmmss")
        End If
        If PROC_TYPE.SelectedValue = "2" Then
            CMPT_YMD.Text = Now.ToString("yyyyMMdd")
            CMPT_HM.Text = Now.ToString("HHmmss")
        End If
    End Sub
    Private Sub PRIORITY_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRIORITY.SelectedIndexChanged
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
    'Slip List (Summary) Band Header 에 Sort Image 넣기
    Private Sub GV2_CustomDrawBandHeader(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.BandedGrid.BandHeaderCustomDrawEventArgs) Handles GV2.CustomDrawBandHeader
        Dim skin As DevExpress.Skins.Skin = DevExpress.Skins.GridSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default)
        Dim element As DevExpress.Skins.SkinElement = skin(DevExpress.Skins.GridSkins.SkinSortShape)
        GV2.Images = element.Image.GetImages()
    End Sub
    'Slip List (Summary) MouseDown (Sort)
    Private Sub GV2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GV2.MouseDown
        Dim gv As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView = GV2
        Dim hitInfo As DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitInfo = gv.CalcHitInfo(e.Location)

        If hitInfo.InBandPanel Then
            If hitInfo.HitTest = DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitTest.BandEdge Then  '경계선 클릭시 Sort를 무효화 한다.
                bSortEnable = False
            Else
                bSortEnable = True
            End If
        End If
    End Sub    'Slip List (Summary) MouseUp (Sort)
    Private Sub GV2_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GV2.MouseUp
        If bSortEnable = False Then Exit Sub 'MouseDown Event에서 경계선을 클릭한 경우 Sort를 하지 않음

        'Band Click시 해당 컬럼 Sort (상위밴드 클릭시에는 Sort하지 않는다)
        Dim gv As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView = GV2

        Dim hitInfo As DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitInfo = gv.CalcHitInfo(e.Location)
        Dim sortFlag As Integer

        If hitInfo.InBandPanel Then
            If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
            If hitInfo.HitTest = DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitTest.BandEdge Then Exit Sub
            If hitInfo.Band Is Nothing Then Exit Sub
            If hitInfo.Band.Columns.VisibleColumnCount <= 0 Then Exit Sub

            sortFlag = hitInfo.Band.Columns(0).SortOrder
            gv.ClearSorting()   'Sort Clear.

            '해당 스킨의 이미지를 가져온다
            Dim skin As DevExpress.Skins.Skin = DevExpress.Skins.GridSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default)
            Dim element As DevExpress.Skins.SkinElement = skin(DevExpress.Skins.GridSkins.SkinSortShape)
            gv.Images = element.Image.GetImages()

            'Sort Image 초기화(기존에 그려진 Sort 화살표를 없앤다)
            For Each band As DevExpress.XtraGrid.Views.BandedGrid.GridBand In gv.Bands
                band.ImageIndex = -1

                'Band Children Sort Image 초기화
                If band.Children.Count > 0 Then
                    For i As Integer = 0 To band.Children.Count - 1
                        band.Children(i).ImageIndex = -1
                    Next
                End If
            Next

            If sortFlag = DevExpress.Data.ColumnSortOrder.Ascending Then
                hitInfo.Band.ImageIndex = 0
                hitInfo.Band.ImageAlignment = System.Drawing.StringAlignment.Far    'Image 오른쪽 정렬
                hitInfo.Band.Columns(0).SortOrder = DevExpress.Data.ColumnSortOrder.Descending
            Else
                hitInfo.Band.ImageIndex = 1
                hitInfo.Band.ImageAlignment = System.Drawing.StringAlignment.Far    'Image 오른쪽 정렬
                hitInfo.Band.Columns(0).SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            End If

        End If
    End Sub
#End Region

    '===================================================================================================================
    '함수이동
    '===================================================================================================================

    Private Function GetConvertToDataSet(ByVal KEY As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
            Select Case KEY
                Case "CrmUserInfo"
                    YJSql.SqlBox("CrmUserInfo", "CrmAsMgtDev@CrmUserInfo", True)
                Case "REQ_SVC2"
                    YJSql.SqlBox("REQ_SVC2", "CrmAsMgt_v4@GetReqSvc2List", True)
            End Select
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

    Private Function GetConvertToDataSet() As DataSet
        Dim dsResult As DataSet = Me.ConvertToDataset
        Try
            dsResult.Tables("MAIN").Columns.Add("DEPT_AUTH_LIST")
            dsResult.Tables("MAIN").Rows(0)("DEPT_AUTH_LIST") = DEPT_AUTH_LIST.EditValue.ToString.Replace(" ", "")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return dsResult
    End Function

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub

    Private Sub CUST_CD_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUST_CD.Validated
        Call SearchHistory()
    End Sub

    Private Sub DEPT_CD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DEPT_CD.SelectedIndexChanged
        If ShownFlag = True Then
            Exit Sub
        End If
        'SetUserList(WORK_USR_LIST, DEPT_CD.SelectedValue)
        'SetDept(DEPT_AUTH_LIST, DEPT_CD.SelectedValue)
    End Sub

    Private Sub DEPT_AUTH_LIST_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DEPT_AUTH_LIST.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            REQ_SVC.Focus()
            'If WORK_USR.Enabled = False Then
            '    PRAR_YMD.Focus()
            'Else
            '    WORK_USR.Focus()
            'End If
        End If
    End Sub

    Private Sub DEPT_AUTH_LIST_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DEPT_AUTH_LIST.KeyUp
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub

    Private Sub DEPT_CD_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles REQ_TYPE2.KeyDown, REQ_TYPE.KeyDown, REQ_SVC2.KeyDown, REQ_SVC.KeyDown, PROC_TYPE.KeyDown, PRIORITY.KeyDown, FREE_YN.KeyDown, DEPT_CD.KeyDown, EX_IM_TYPE.KeyDown, WORK_USR.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.DroppedDown = True
        End If
    End Sub

    Private Sub REQ_SVC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REQ_SVC.SelectedIndexChanged
        If ShownFlag = True Then
            Exit Sub
        End If
        SetReqsvc2(REQ_SVC.SelectedValue)
        Select Case REQ_SVC.SelectedValue
            Case "A"
                REQ_TYPE.SelectedValue = "08"
                REQ_TYPE2.SelectedValue = "14"
            Case "Q"
                REQ_TYPE.SelectedValue = "11"
                REQ_TYPE2.SelectedValue = "99"
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

    Private Sub GV4_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GV4.DoubleClick
        MNGT_NO.Text = GV4.GetRowCellValue(GV4.FocusedRowHandle, "MNGT_NO").ToString
        Call SearchData()
        'Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        'Dim fTarget As Object = Nothing

        'frmMain = IMainForm
        'fTarget = frmMain.NavigateTo("CrmAsView", NavigatedWindowModes.Dialog, False)
        'If Not IsNothing(fTarget) Then
        '    fTarget.frmMain = frmMain
        '    fTarget.MNGT_NO.Text = GV4.GetRowCellValue(GV4.FocusedRowHandle, "MNGT_NO").ToString
        '    fTarget.SearchData()
        '    fTarget.ShowDialog()
        'End If
    End Sub

    Private Sub OUTSTAND_AMT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OUTSTAND_AMT.TextChanged
        lbl_OUTSTAND_AMT.Text = OUTSTAND_AMT.Text
    End Sub

    Private Sub STOP_YMD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STOP_YMD.TextChanged
        If String.IsNullOrEmpty(STOP_YMD.Text) Then
            lbl_STOP_YMD.Text = "0000-00-00"
        Else
            lbl_STOP_YMD.Text = Mid(STOP_YMD.Text, 1, 4) & "-" & Mid(STOP_YMD.Text, 5, 2) & "-" & Mid(STOP_YMD.Text, 7, 2)
        End If

    End Sub


    Private Sub DEPT_AUTH_LIST_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DEPT_AUTH_LIST.EditValueChanged
        If String.IsNullOrEmpty(DEPT_AUTH_LIST.EditValue) Then
            lbl_DEPT_AUTH.Font = New System.Drawing.Font("Tahoma", 9.0!)
            DEPT_AUTH_LIST.BackColor = Nothing
        Else
            lbl_DEPT_AUTH.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            DEPT_AUTH_LIST.BackColor = System.Drawing.Color.LightPink
        End If
    End Sub

    Private Sub SYS_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYS_ID.TextChanged
        If String.IsNullOrEmpty(SYS_ID.Text) OrElse SYS_ID.Text = "CRM" Then
            lbl_SYS_ID.Font = New System.Drawing.Font("Tahoma", 9.0!)
            SYS_ID.BackColor = Nothing
        Else
            lbl_SYS_ID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            SYS_ID.BackColor = System.Drawing.Color.LightPink
        End If
    End Sub

    Private Sub WORK_USR_CHK_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WORK_USR_CHK.TextChanged
        If WORK_USR_CHK.Text <> "" Then
            lbl_WORK_USR.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            WORK_USR.BackColor = System.Drawing.Color.LightPink
            WORK_USR.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Else
            lbl_WORK_USR.Font = New System.Drawing.Font("Tahoma", 9.0!)
            WORK_USR.Font = New System.Drawing.Font("Tahoma", 9.0!)
        End If
    End Sub

    Private Sub btnSaveLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ONLINE_YN.Text = "A" Then
            If MsgBoxLocalized("온라인접수로 재등록하시겠습니까?", MessageBoxButtons.YesNo, , , MessageBoxDefaultButton.Button2) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        ONLINE_YN.Text = "Y"
        Call SaveData()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
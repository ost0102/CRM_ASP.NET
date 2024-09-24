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

Public Class CrmAsMgt_v3
    Private HotTrackRowValue As Integer = DevExpress.XtraGrid.GridControl.InvalidRowHandle
     
    Public frmMain As YJIT.SC.UI.IMainForm = Nothing
    Dim BindPic As String = ""
    Dim BindTel As String = ""
    Private bSortEnable As Boolean = True
    Private comdoc As ComDoc
    Private KeyDownYn As Boolean = False
    Dim UserInfoDt As DataTable = Nothing

    Dim ShownFlag As Boolean = True

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

#Region "=================Data logic actions==========="
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
                    Select Case Dept_Cd.ToUpper
                        Case "ALL"
                            Drs = UserInfoDt.Select("WORK_USR2_YN = 'Y'", "DEPT_CD ASC,SORT ASC ,LOC_NM ASC")
                        Case "01", "05"
                            Drs = UserInfoDt.Select("DEPT_CD IN ('01','05') AND WORK_USR2_YN = 'Y'", "SORT ASC ,LOC_NM ASC")
                        Case Else
                            Drs = UserInfoDt.Select("DEPT_CD ='" & Dept_Cd & "' AND WORK_USR2_YN = 'Y'", "SORT ASC ,LOC_NM ASC")
                    End Select
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
                    Select Case Dept_Cd.ToUpper
                        Case "ALL"
                            Drs = UserInfoDt.Select("1=1", "DEPT_CD ASC,SORT ASC ,LOC_NM ASC")
                        Case "01", "05"
                            Drs = UserInfoDt.Select("DEPT_CD IN ('01','05')", "SORT ASC ,LOC_NM ASC")
                        Case Else
                            Drs = UserInfoDt.Select("DEPT_CD ='" & Dept_Cd & "'", "SORT ASC ,LOC_NM ASC")
                    End Select
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


    Private Sub SetDept(ByVal sender As Object, Optional ByVal ExceptDept As String = "")

        Dim dt As New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")

        Try
            For i = 0 To DeptDt.Rows.Count - 1
                'If ExceptDept <> DeptDt.Rows(i)("CODE").ToString Then
                dt.ImportRow(DeptDt.Rows(i))
                dt.Rows(dt.Rows.Count - 1)("NAME") = (i + 1).ToString & "." & dt.Rows(dt.Rows.Count - 1)("NAME").ToString
                '       a = a + 1
                'End If
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


        'If DEPT_AUTH_LIST_Dt Is Nothing Then
        '    DEPT_AUTH_LIST_Dt = DeptDt.Copy
        '    Dim bindingSourceProduct As BindingSource = Nothing
        '    bindingSourceProduct = New BindingSource()
        '    bindingSourceProduct.DataSource = DEPT_AUTH_LIST_Dt
        '    sender.Properties.DataSource = bindingSourceProduct.DataSource
        '    sender.DataBindings.add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
        '    sender.Properties.ValueMember = "CODE"
        '    sender.Properties.DisplayMember = "NAME"
        '    sender.Properties.NullText = String.Empty
        '    sender.Properties.SeparatorChar = ";"
        'Else 
        '    DEPT_AUTH_LIST.EditValue = String.Empty
        '    DEPT_AUTH_LIST.SetEditValue(String.Empty)
        '    DEPT_AUTH_LIST_Dt.Rows.Clear()
        'End If
        ''DEPT_AUTH_LIST.Properties.Items.Clear()



        'sender.Refresh()


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

        Dim bindingSourceProduct As BindingSource
        'bindingSourceProduct = New BindingSource()
        'bindingSourceProduct.DataSource = DeptDt.Copy
        'DEPT_AUTH_LIST.Properties.DataSource = bindingSourceProduct.DataSource
        'DEPT_AUTH_LIST.Properties.ValueMember = "CODE"
        'DEPT_AUTH_LIST.Properties.DisplayMember = "NAME"
        'DEPT_AUTH_LIST.Properties.NullText = String.Empty
        'DEPT_AUTH_LIST.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
        'DEPT_AUTH_LIST.Properties.SeparatorChar = ";"
        'FORM_OPTION

        Dim OptionDt As New DataTable
        OptionDt.Columns.Add("CODE")
        OptionDt.Columns.Add("NAME")
        OptionDt.Rows.Add("A", "Row Best Fit")
        'OptionDt.Rows.Add("B", "Refesh(5분)")

        bindingSourceProduct = New BindingSource()
        bindingSourceProduct.DataSource = OptionDt
        FORM_OPTION.Properties.DataSource = bindingSourceProduct.DataSource
        FORM_OPTION.Properties.ValueMember = "CODE"
        FORM_OPTION.Properties.DisplayMember = "NAME"
        FORM_OPTION.Properties.NullText = String.Empty
        FORM_OPTION.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
        FORM_OPTION.Properties.SeparatorChar = ";"


        bindingSourceProduct = New BindingSource()
        bindingSourceProduct.DataSource = DeptDt.Copy
        S_DEPT_CD.Properties.DataSource = bindingSourceProduct.DataSource
        S_DEPT_CD.Properties.ValueMember = "CODE"
        S_DEPT_CD.Properties.DisplayMember = "NAME"
        S_DEPT_CD.Properties.NullText = String.Empty
        S_DEPT_CD.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
        S_DEPT_CD.Properties.SeparatorChar = ";"

        bindingSourceProduct = New BindingSource()
        bindingSourceProduct.DataSource = DeptDt.Copy
        S_DEPT_AUTH_LIST.Properties.DataSource = bindingSourceProduct.DataSource
        S_DEPT_AUTH_LIST.Properties.ValueMember = "CODE"
        S_DEPT_AUTH_LIST.Properties.DisplayMember = "NAME"
        S_DEPT_AUTH_LIST.Properties.NullText = String.Empty
        S_DEPT_AUTH_LIST.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
        S_DEPT_AUTH_LIST.Properties.SeparatorChar = ";"


        'For I = DeptDt.Rows.Count - 1 To 0 Step -1
        '    If DeptDt.Rows(I)("CODE") <> ClientSessionInfo.OrganizationCode Then
        '        DeptDt.Rows.RemoveAt(I)
        '    End If
        'Next
        'DeptDt.Rows.Add("ETC", "타부서 요청사항")

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

        bindingSourceProduct = New BindingSource()
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



        'SetUserList(DEV_WORK_USR, "02")
        'SetUserList(WORK_USR_LIST, ClientSessionInfo.OrganizationCode)
        'DEV_WORK_USR
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
        Me.ClearView(UI.AppliedRangeTypes.Only, {MNGT_NO, WG2, WG3, AS_TEST_CHK_YMD, AS_TEST_CMPT_YMD, AS_TEST_RESULT, AS_TEST_USR, PRAR_YMD, CMPT_YMD, CMPT_HM, RMK, CMPT_RMK})
        REQ_YMD.Text = Now.ToString("yyyyMMdd")
        REQ_HM.Text = Now.ToString("HHmm")
        PROC_TYPE.SelectedValue = 0
        xtcRemark.SelectedTabPageIndex = 0
        RETURN_YN.YesNo = "N"
        SHARE_YN.YesNo = "N"
        EX_IM_TYPE.SelectedValue = "I"
        S_DEPT_TYPE.SelectedValue = "W"
        ONLINE_YN.Text = "N"
        MODIFY_YN.Text = "N"
        WORK_USR.SelectedValue = ClientSessionInfo.UserID

        '## 파일 추가 ##
        For Each EachFileName In IO.Directory.GetFiles(comdoc.getTempFolder)
            WG2.AddRow()
            comdoc.InsertFile(comdoc.FileUploadType.FileChoose, GV2.RowCount - 1, {EachFileName}, DBNull.Value)
        Next

    End Sub

    Public Sub NewData()
        '20180205 김성은 초기화 누락컬럼 있어서 수정
        'Me.ClearView(UI.AppliedRangeTypes.Except, {WG1, S_DATE_TYPE, SEARCH_KEY, TO_YMD, FM_YMD, S_DEPT_CD, S_DEPT_AUTH_LIST, REQ_SVC, PROC_TYPE, PRIORITY, SCREEN, DirList, S_WORK_USR})
        Me.ClearView(UI.AppliedRangeTypes.Except, {WG1, S_DATE_TYPE, SEARCH_KEY, TO_YMD, FM_YMD, S_DEPT_TYPE, S_DEPT_CD, S_DEPT_AUTH_LIST, SCREEN, DirList, S_WORK_USR, LayOutList, S_REQ_SVC})

        SYS_ID.Text = "CRM"
        CONTENT.ReadOnly = False
        SYS_ID.Enabled = True

        REQ_SVC.SelectedValue = "B"
        REQ_YMD.Text = Now.ToString("yyyyMMdd")
        REQ_HM.Text = Now.ToString("HHmm")
        WORK_USR.SelectedValue = ClientSessionInfo.UserID
        DEPT_CD.DefVal = ClientSessionInfo.OrganizationCode
        DEPT_CD.SelectedValue = ClientSessionInfo.OrganizationCode
        PROC_TYPE.SelectedValue = 0
        SetUserList(WORK_USR2, ClientSessionInfo.OrganizationCode)
        SetDept(DEPT_AUTH_LIST, ClientSessionInfo.OrganizationCode)
        SetReqsvc2(REQ_SVC.SelectedValue)
        'DEPT_AUTH_LIST.EditValue = ""
        'WORK_USR_LIST.EditValue = ""
        xtcRemark.SelectedTabPageIndex = 0
        PRIORITY.SelectedValue = 2
        FREE_YN.SelectedValue = "Y"
        SHARE_YN.YesNo = "N"
        EX_IM_TYPE.SelectedValue = "I"
        S_DEPT_TYPE.SelectedValue = "W"
        ONLINE_YN.Text = "N"
        MODIFY_YN.Text = "N"

        DEPT_CD.Select()

        CUST_CD.Focus()
    End Sub

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
        GV1.Columns("REQ_SVC").ColumnEdit = editorCombo
        GV4.Columns("REQ_SVC").ColumnEdit = editorCombo

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("Type", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("User", searchParams, dataParams)
        GV1.Columns("WORK_USR").ColumnEdit = editorCombo

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
        GV1.Columns("REQ_TYPE").ColumnEdit = editorCombo
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
        GV1.Columns("REQ_TYPE2").ColumnEdit = editorCombo
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
        GV1.Columns("CUST_CD").ColumnEdit = editor
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
        GV1.Columns("REQ_USR").ColumnEdit = editor
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
        GV1.Columns("PROC_TYPE").ColumnEdit = editorCombo
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
        GV1.Columns("PRIORITY").ColumnEdit = editorCombo
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
        GV1.Columns("FREE_YN").ColumnEdit = editorCombo
        GV4.Columns("FREE_YN").ColumnEdit = editorCombo

        Common.DrawRowIndicator({GV1, GV3})


        Dim editorImgCombo As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox = comdoc.getImageComboBox()
        editorImgCombo.SmallImages = comdoc.getIcons()
        GV2.Columns("FILE_ICON").ColumnEdit = editorImgCombo
        GV2.Columns("SUCCESS").ColumnEdit = editorImgCombo



        '------------------------------------------GV3
        Dim Drs() As DataRow
        Drs = UserInfoDt.Select("DEPT_CD IN ('" & "02','05" & "')", "SORT ASC ,LOC_NM ASC")
        If Drs.Length > 0 Then
            dt = Drs.CopyToDataTable
            dt.Columns("USR_ID").ColumnName = "CODE"
            dt.Columns("LOC_NM").ColumnName = "NAME"
            For I = 0 To dt.Rows.Count - 1
                dt.Rows(I)("NAME") = (I + 1).ToString & "." & dt.Rows(I)("NAME").ToString
            Next
            For I = dt.Columns.Count - 1 To 0 Step -1
                If dt.Columns(I).ColumnName <> "CODE" And dt.Columns(I).ColumnName <> "NAME" Then
                    dt.Columns.RemoveAt(I)
                End If
            Next

        End If

        Dim dr As DataRow = dt.NewRow
        dr("CODE") = ""
        dr("NAME") = "--Select--"
        dt.Rows.InsertAt(dr, 0)

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
            If SYS_ID.Text.ToUpper <> "CRM" OrElse SYS_ID.Text.ToUpper <> "MAIL" OrElse String.IsNullOrEmpty(MNGT_NO.Text) Then
                param("Copy") = False
            Else
                'If DEPT_CD.SelectedValue <> ClientSessionInfo.OrganizationCode Then
                '    param("Copy") = False
                'Else
                '    param("Copy") = True
                'End If
                param("Copy") = True
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
            Case "WG3_AddRow"
                GV3.SetRowCellValue(GV3.RowCount - 1, "", "1")
                GV3.SetRowCellValue(GV3.RowCount - 1, "", "1")
            Case "WG4_Excel"
                Try
                    Dim dr4() As DataRow = WG4.DataSource.Select("SHARE_YN = 'Y'")
                    Dim dt4 As DataTable = dr4.CopyToDataTable
                    WG42.DataSource = dt4

                    GV42.ExportToXlsx(CUST_CD.Text & "_공유사항.xlsx")
                    Dim process As System.Diagnostics.Process = New System.Diagnostics.Process()
                    process.StartInfo.FileName = CUST_CD.Text & "_공유사항.xlsx"
                    process.StartInfo.Verb = "Open"
                    process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
                    process.Start()
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try
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
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", "&Excel Export")
        PopUp.PopUpInit(Me, WG1)

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

        PanelControl3.Controls.Add(CUST_PIC_LIST)
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

        If MandatoryGridValue("GV2") Then Exit Sub

        If CUST_CD.Text.ToString.Trim = "" Then
            MsgBoxLocalized("거래처을 입력해주세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            CUST_CD.Focus()
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

            If REQ_TYPE2.SelectedValue.ToString = "" Then
                MsgBoxLocalized("요청상세을 선택하세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                REQ_TYPE2.Focus()
                Exit Sub
            End If

            If String.IsNullOrEmpty(RMK.Text) Then
                xtcRemark.SelectedTabPage = xtpRMK
                MsgBoxLocalized("조치사항 입력후 저장하세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                RMK.Focus()
                Exit Sub
            End If

            If SYS_ID.Text.ToUpper <> "CRM" _
                       AndAlso SYS_ID.Text.ToUpper <> "MAIL" _
                       AndAlso String.IsNullOrEmpty(CMPT_RMK.Text) Then
                xtcRemark.SelectedTabPage = xtpCMPT_RMK
                MsgBoxLocalized("답변 입력후 저장하세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                CMPT_RMK.Focus()
                Exit Sub
            End If

            If String.IsNullOrEmpty(WORK_USR2.EditValue.ToString) Then
                WORK_USR2.EditValue = ClientSessionInfo.LocalName
            End If
            If String.IsNullOrEmpty(CMPT_YMD2.Text) Then
                CMPT_YMD2.Text = Now.ToString("yyyyMMdd")
            End If
        End If



        Dim byteUploadFiles As Dictionary(Of String, Object) = comdoc.byteUploadFiles
        Dim tempFolder As String = comdoc.getTempFolder
        Dim strFileName As String = ""

        Dim dsResult As DataSet

        Dim ds As DataSet = Nothing
        'DS.Tables("MAIN").Columns.Add("DEPT_AUTH_LIST")
        'DS.Tables("MAIN").Rows(0)("DEPT_AUTH_LIST") = DEPT_AUTH_LIST.EditValue.ToString.Replace(" ", "")
        ''WORK_USR_LIST 
        'DS.Tables("MAIN").Columns.Add("WORK_USR_LIST")
        'DS.Tables("MAIN").Rows(0)("WORK_USR_LIST") = WORK_USR_LIST.EditValue.ToString.Replace(" ", "")

        Try
            For i As Integer = 0 To GV2.RowCount - 1
                GV2.SetRowCellValue(i, "SEQ", comdoc.GetSeq(i, MNGT_NO.Text))
            Next
            comdoc.SetUploadPath(Split(DirList.Text, "/"))

            ds = GetConvertToDataSet() 'GetConvertToDataSet("Search") 

            Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", "잠시만 기다려주세요. 저장중입니다.")
                dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgt_v3", "SaveInput", {ds, comdoc.getUploadPath})
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
            Me.BindToDataset(dsResult, "Data")
            DEPT_AUTH_LIST.EditValue = dsResult.Tables("Data.MAIN").Rows(0)("DEPT_AUTH_LIST").ToString()
            WORK_USR2.EditValue = dsResult.Tables("Data.MAIN").Rows(0)("WORK_USR2").ToString()

            If GV3.VisibleColumns.Contains(GV3.Columns("MNGT_NO")) Then
                For I = 0 To GV3.RowCount - 1
                    If GV3.GetRowCellValue(I, "MNGT_NO").ToString = MNGT_NO.Text Then
                        GV3.FocusedRowHandle = I
                        Exit Sub
                    End If
                Next
            End If
            'Me.DataState = UI.DataStates.Retrieved
            'MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Success", MessageBoxIcon.Information)

            MODIFY_YN.Text = "N"
        Else
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub

    Public Sub SearchDetailData()
        If GV1.RowCount = 0 Then Exit Sub
        If GV1.IsGroupRow(GV1.FocusedRowHandle) Then Exit Sub
        If MODIFY_YN.Text = "Y" Then
            If MsgBoxLocalized("기존 자료가 수정되었습니다. 자료조회를 진행하시겠습니까?", MessageBoxButtons.YesNo, , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        MNGT_NO.Text = GV1.GetFocusedRowCellValue("MNGT_NO").ToString

        Dim retDs As DataSet = Nothing
        Try
            retDs = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgt_v3", "SearchInput", Me.ConvertToDataset)
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
            SetUserList(WORK_USR2, retDs.Tables("Data.MAIN").Rows(0)("DEPT_CD").ToString())
            SetDept(DEPT_AUTH_LIST, retDs.Tables("Data.MAIN").Rows(0)("DEPT_CD").ToString())

            Me.BindToDataset(retDs, "Data")
            'retDs = AdaptDataSourceForReport(retDs)
            DEPT_AUTH_LIST.EditValue = retDs.Tables("Data.MAIN").Rows(0)("DEPT_AUTH_LIST").ToString()
            WORK_USR2.EditValue = retDs.Tables("Data.MAIN").Rows(0)("WORK_USR2").ToString()
            'If DEPT_CD.SelectedValue = ClientSessionInfo.OrganizationCode Then
            '    DEPT_CD.Enabled = True
            'Else
            '    DEPT_CD.Enabled = False
            'End If
            'SetDept(DEPT_AUTH_LIST, DEPT_CD.SelectedValue) 

            Select Case SYS_ID.Text.ToUpper
                Case "CRM", "MAIL"
                    CONTENT.ReadOnly = False
                    SYS_ID.Enabled = True
                Case Else
                    CONTENT.ReadOnly = True
                    SYS_ID.Enabled = False
            End Select

            '20180205 김성은 파일다운로드시 메모리 참조하는 부분이 있어서 초기화 처리
            comdoc.ClearFiles()

            Call InitIcons()

            GV1.Focus()

            MODIFY_YN.Text = "N"
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
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
#End Region

#Region "=================Control Events==========="
    Private Sub CrmAsInput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call NewData() 

    End Sub

    Private Sub CrmAsInput_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown

        comdoc = New ComDoc(WG2)
        InitData()
        Call PopUpInit()
        Call GridInit()
        NewData()
        GV1.OptionsBehavior.Editable = False
        GV1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        GV1.OptionsBehavior.Editable = True


        '20180521 김성은 그리드 저장기능 추가
        Dim dt As DataTable = GetLayoutList(ClientSessionInfo.OfficeCode, Me.Name)
        LayOutList.DataSource = dt
        LoadFlag = False


        SaveControlValues(Me, {WG1, FM_YMD, TO_YMD, S_WORK_USR, S_PRIORITY, S_PROC_TYPE, S_DEPT_TYPE, S_DEPT_CD, S_SVC_CD, S_DEPT_AUTH_LIST, LayOutList})
        SetMandatoryLine(Me)

        ReloadSetting()
        ShownFlag = False




    End Sub

    Private Sub ReloadSetting()

        For I = 0 To My.Settings.controlLocations.Count - 1
            Dim KEY As String = My.Settings.controlLocations(I)
            Dim KeySplt() As String = KEY.Split("!")
            Select Case KeySplt(0)
                Case SplitContainerControl2.Name
                    SplitContainerControl2.SplitterPosition = KeySplt(1)
                Case SplitContainerControl3.Name
                    SplitContainerControl3.SplitterPosition = KeySplt(1)
            End Select
        Next
    End Sub
    Private Sub CONTENT_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONTENT.Enter
        CONTENT.SelectionStart = Len(CONTENT.Text)
    End Sub

    Private Sub RMK_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RMK.Enter
        RMK.SelectionStart = Len(RMK.Text)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveData()
    End Sub

    Private Sub REQ_USR_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles REQ_USR.PreviewKeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And (REQ_USR.Text <> OLD_REQ_USR.Text) Then
            Call SearchCustomerPic()
        ElseIf (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) Then
            REQ_USR.NextFocus = "TEL_NO"
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
        NewData()
    End Sub

    Private Sub PROC_TYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PROC_TYPE.SelectedIndexChanged

        If ClientSessionInfo.OrganizationCode = DEPT_CD.SelectedValue Then
            If PROC_TYPE.SelectedValue = "1" Or PROC_TYPE.SelectedValue = "2" Or PROC_TYPE.SelectedValue = "7" Or PROC_TYPE.SelectedValue = "8" Then
                '20180521 김성은 처리자 항목이 추가되어 주석 처리
                'WORK_USR_LIST.EditValue = ClientSessionInfo.UserID
            ElseIf PROC_TYPE.SelectedValue = "7" Then
                CMPT_YMD.Text = ""
                CMPT_HM.Text = ""
            Else
                CMPT_YMD.Text = ""
                CMPT_HM.Text = ""
                WORK_USR.Text = ""
            End If
        End If
        If PROC_TYPE.SelectedValue = "1" Then
            CMPT_YMD.Text = Now.ToString("yyyyMMdd")
            CMPT_HM.Text = Now.ToString("HHmmss")
        End If
        If PROC_TYPE.SelectedValue = "2" Then
            CMPT_YMD.Text = Now.ToString("yyyyMMdd")
            CMPT_HM.Text = Now.ToString("HHmmss")
        End If
    End Sub
    Private Sub PRIORITY_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
                    YJSql.SqlBox("REQ_SVC2", "CrmAsMgt_v3@GetReqSvc2List", True)
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
            '    Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
            '    YJSql.SqlBox("WG1", "CrmAsMgt_v3@Search", True)
            '    YJSql.Params("FM_YMD", drMAIN("FM_YMD").ToString.Trim, True)
            '    YJSql.Params("TO_YMD", drMAIN("TO_YMD").ToString.Trim, True)
            '    YJSql.Params("S_PROC_TYPE", S_PROC_TYPE.EditValue.ToString.Replace(";", "','").Replace(" ", ""), True)
            '    YJSql.Params("S_SVC_CD", S_SVC_CD.EditValue.ToString.Replace(";", "','").Replace(" ", ""), True)
            '    'YJSql.Params("S_MNGT_NO", drMAIN("S_MNGT_NO").ToString.Trim, True)
            '    YJSql.Params("SEARCH_KEY", drMAIN("SEARCH_KEY").ToString.Trim, True)
            '    YJSql.Params("WORK_USR", drMAIN("S_WORK_USR").ToString.Trim, True)
            '    YJSql.Params("S_DEPT_CD", S_DEPT_CD.EditValue.ToString.Replace(";", "','").Replace(" ", ""), True)
            '    YJSql.Params("S_DEPT_AUTH_LIST", S_DEPT_AUTH_LIST.EditValue.ToString.Replace(";", "','").Replace(" ", ""), True)
            '    YJSql.Params("DEPT_CD", ClientSessionInfo.OrganizationCode)
            '    If drMAIN("S_PRIORITY").ToString.Trim <> "" Then
            '        If drMAIN("S_PRIORITY").ToString.Trim = "Y" Then
            '            YJSql.Blocks("PRIORITY", drMAIN("S_PRIORITY").ToString.Trim, True)
            '        End If
            '    End If 
            dsResult.Tables("MAIN").Columns.Add("S_PROC_TYPE")
            dsResult.Tables("MAIN").Columns.Add("S_SVC_CD")
            dsResult.Tables("MAIN").Columns.Add("S_DEPT_CD")
            dsResult.Tables("MAIN").Columns.Add("S_DEPT_AUTH_LIST")
            dsResult.Tables("MAIN").Columns.Add("DEPT_AUTH_LIST")
            dsResult.Tables("MAIN").Columns.Add("WORK_USR_LIST")
            dsResult.Tables("MAIN").Columns.Add("WORK_USR2")
            dsResult.Tables("MAIN").Rows(0)("DEPT_AUTH_LIST") = DEPT_AUTH_LIST.EditValue.ToString.Replace(" ", "")
            dsResult.Tables("MAIN").Rows(0)("WORK_USR2") = WORK_USR2.EditValue.ToString.Replace(" ", "")
            dsResult.Tables("MAIN").Rows(0)("S_PROC_TYPE") = S_PROC_TYPE.EditValue.ToString.Replace(";", "','").Replace(" ", "")
            dsResult.Tables("MAIN").Rows(0)("S_SVC_CD") = S_SVC_CD.EditValue.ToString.Replace(";", "','").Replace(" ", "")
            dsResult.Tables("MAIN").Rows(0)("S_DEPT_CD") = S_DEPT_CD.EditValue.ToString.Replace(";", "','").Replace(" ", "")
            dsResult.Tables("MAIN").Rows(0)("S_DEPT_AUTH_LIST") = S_DEPT_AUTH_LIST.EditValue.ToString.Replace(";", "','").Replace(" ", "")

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return dsResult
    End Function

    Public Sub SearchData(Optional ByVal Clear As Boolean = True)
        If FM_YMD.Text = "" And Clear = True Then
            FM_YMD.Focus()
            MsgBoxLocalized("등록일자 시작일은 필수 입니다.")
            Exit Sub
        Else
            If FM_YMD.Text = "" Then
                FM_YMD.Text = Now.ToString("yyyyMMdd")
            End If
        End If

        If Clear = True Then
            Me.ClearView(AppliedRangeTypes.Except, {S_DATE_TYPE, FM_YMD, TO_YMD, S_DEPT_TYPE, S_DEPT_CD, S_DEPT_AUTH_LIST, SEARCH_KEY, S_PROC_TYPE, S_WORK_USR, LayOutList, S_REQ_SVC})
            NewData()
        End If
        Dim dsRet As DataSet = GetConvertToDataSet()
        Try
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgt_v3", "Search", dsRet)
        Catch ex As Exception

        End Try

        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        If drPairs("TrxCode").ToString = "Y" Then
            Me.BindToDataset(dsRet, "Data")
        ElseIf drPairs("TrxCode").ToString = "N" Then
            Me.ClearView(UI.AppliedRangeTypes.Only, {WG1})
            Call NewData()
            MsgBoxLocalized(drPairs("TrxMsg"))
        Else
            MsgBoxLocalized(drPairs("TrxMsg"))
            Exit Sub
        End If

        GV1.FocusedRowHandle = 0
        SearchDetailData()

    End Sub


    Private Sub AddNewRow(ByVal dt As DataTable, ByVal Code As String, ByVal Name As String)
        dt.Rows.Add()
        dt.Rows(dt.Rows.Count - 1)("CODE") = Code
        dt.Rows(dt.Rows.Count - 1)("NAME") = Name
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchData(False)
    End Sub

    Private Sub TO_YMD_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TO_YMD.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            S_DEPT_CD.Focus()
        End If
    End Sub

    Private Sub S_DEPT_CD_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles S_DEPT_CD.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            e.Handled = True
            S_DEPT_AUTH_LIST.Focus()
        End If
        'DEPT_AUTH_LIST
    End Sub

    Private Sub S_DEPT_AUTH_LIST_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles S_DEPT_AUTH_LIST.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            e.Handled = True
            SEARCH_KEY.Focus()
        End If
    End Sub


    Private Sub S_PROC_TYPE_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles S_PROC_TYPE.KeyDown, FORM_OPTION.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            S_WORK_USR.Focus()
        End If
    End Sub

    Private Sub S_SVC_CD_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles S_SVC_CD.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            S_PROC_TYPE.Focus()
        End If
    End Sub
    Private Sub DEPT_CD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DEPT_CD.SelectedIndexChanged
        If ShownFlag = True Then
            Exit Sub
        End If

        SetUserList(WORK_USR2, DEPT_CD.SelectedValue)
        SetDept(DEPT_AUTH_LIST, DEPT_CD.SelectedValue)
    End Sub

    Private Sub DEPT_AUTH_LIST_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DEPT_AUTH_LIST.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            e.Handled = True
            PRAR_YMD.Focus()
        End If
    End Sub

    Private Sub S_DEPT_CD_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles S_SVC_CD.KeyUp, S_DEPT_CD.KeyUp, DEPT_AUTH_LIST.KeyUp, S_DEPT_AUTH_LIST.KeyUp, WORK_USR2.KeyUp
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub

    Private Sub DEPT_CD_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles REQ_TYPE2.KeyDown, REQ_TYPE.KeyDown, REQ_SVC.KeyDown, PROC_TYPE.KeyDown, PRIORITY.KeyDown, FREE_YN.KeyDown, DEPT_CD.KeyDown, S_DATE_TYPE.KeyDown, WORK_USR.KeyDown, REQ_SVC2.KeyDown, EX_IM_TYPE.KeyDown
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

    Private Sub WORK_USR_LIST_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            DEPT_AUTH_LIST.Focus()
        End If '   WORK_USR_LIST
    End Sub

    Private Sub WORK_USR2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles WORK_USR2.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            CMPT_YMD2.Focus()
        End If '   WORK_USR_LIST
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

    Dim WORK_USR_FONT_BOLD As New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
    Dim WORK_USR_FONT_ORG As New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)


    Private Sub GV1_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GV1.RowCellStyle
        If e.RowHandle = HotTrackRow Then
            e.Appearance.BackColor = Color.PaleGoldenrod
        End If

        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            If e.RowHandle < 0 Then Exit Sub

            Select Case e.Column.FieldName
                Case "PROC_TYPE"
                    If view.GetRowCellValue(e.RowHandle, "DEV_CMPT_YN").ToString = "Yes" Then
                        e.Appearance.BackColor = Color.LightBlue
                    ElseIf Not String.IsNullOrEmpty(view.GetRowCellValue(e.RowHandle, "CMPT_YMD2").ToString) Then
                        Select Case view.GetRowCellValue(e.RowHandle, "PROC_TYPE").ToString
                            Case "1", "2" '완료, 즉시처리
                                '완료, 즉시처리 배경색 없음
                            Case Else
                                e.Appearance.BackColor = Color.Orange
                        End Select
                    ElseIf view.GetRowCellValue(e.RowHandle, "PROC_TYPE").ToString = "0" Then
                        e.Appearance.BackColor = System.Drawing.Color.Salmon
                    End If
                Case "CONTENT"
                    If view.GetRowCellValue(e.RowHandle, "RETURN_YN").ToString = "반려" Then
                        e.Appearance.BackColor = Color.OrangeRed
                    End If
                Case "SYS_NM"
                    Select Case view.GetRowCellValue(e.RowHandle, "SYS_ID").ToString
                        Case "CRM", "MAIL"
                            '기본값
                        Case Else '"ELVIS", "HELP"
                            e.Appearance.BackColor = System.Drawing.Color.LightPink
                    End Select
                Case "WORK_USR", "WORK_USR2"
                    If e.CellValue.ToString.Contains(ClientSessionInfo.LocalName) Then
                        e.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
                    End If
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
    End Sub


    Private Sub FORM_OPTION_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FORM_OPTION.EditValueChanged
        If FORM_OPTION.EditValue.ToString.Contains("A") Then
            GV1.OptionsView.RowAutoHeight = True
            WG1.Refresh()
        Else
            GV1.OptionsView.RowAutoHeight = False
            WG1.Refresh()
        End If


        'If FORM_OPTION.EditValue.ToString.Contains("B") Then
        '    MaxInterval = 60 * CDbl(5)
        '    Timer1.Start()
        'Else
        '    Timer1.Stop()
        'End If
    End Sub
    'Dim second As Integer = 0
    'Dim MaxInterval As Integer = 0
    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    second = second + 1
    '    If second >= MaxInterval Then
    '        second = 0
    '        SearchData(False)
    '    End If
    'End Sub

    Private Sub CrmAsMgtDev_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'My.Settings.Reset()
        'For Each Control As Control In {FORM_OPTION, S_DEPT_AUTH_LIST}
        '    Select Case Control.Name
        '        Case FORM_OPTION.Name
        '            My.Settings.controlLocations.Add(Control.Name & "!" & CType(Control, DevExpress.XtraEditors.CheckedComboBoxEdit).EditValue)
        '    End Select
        'Next
        'My.Settings.Save()
    End Sub


    '20180404 김성은    EnableAppearanceEvenRow 속성 들어가면서 색깔 표시가 안됨 / GV1_RowCellStyle 이벤트로 이관
    'Private Sub GV1_RowStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GV1.RowStyle
    '    If GV1.RowCount = 0 Then
    '        Exit Sub
    '    End If
    '    If e.RowHandle < 0 Then
    '        Exit Sub
    '    End If
    '    If GV1.GetRowCellValue(e.RowHandle, "DEV_CMPT_YN").ToString = "Yes" Then
    '        e.Appearance.BackColor = Color.LightBlue
    '    End If

    '    If GV1.GetRowCellValue(e.RowHandle, "RETURN_YN").ToString = "반려" Then
    '        e.Appearance.BackColor = Color.OrangeRed 
    '    End If 
    '    '
    'End Sub

    Private Sub GV1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GV1.DoubleClick
        If GV1.FocusedColumn.FieldName = "CUST_CD" Or GV1.FocusedColumn.FieldName = "CUST_NM" Then
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
                'fTarget.SearchDetail(GV1.GetFocusedRowCellValue("CUST_CD").ToString)
            End If

        End If
    End Sub


    Private Sub SEARCH_KEY_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles SEARCH_KEY.PreviewKeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) Then
            Call SearchData()
        End If
    End Sub

    Private Sub CrmAsMgt_v3_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Reset()
        For Each Control As Control In {SplitContainerControl3, SplitContainerControl2}
            My.Settings.controlLocations.Add(Control.Name & "!" & CType(Control, DevExpress.XtraEditors.SplitContainerControl).SplitterPosition)
        Next
        My.Settings.Save()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ReloadSetting()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing

        frmMain = Me.MdiParent
        fTarget = frmMain.NavigateTo("DetailView", NavigatedWindowModes.Dialog, False)
        If Not IsNothing(fTarget) Then
            fTarget.RMK.Text = CONTENT.Text
            fTarget.ShowDialog()
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing


        frmMain = Me.MdiParent
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
        frmMain = Me.MdiParent
        fTarget = frmMain.NavigateTo("CrmCustomerMgt")
        If Not IsNothing(fTarget) Then
            Dim SearchType As String = fTarget.SEARCH_TYPE.SelectedValue.ToString
            fTarget.SEARCH_TYPE.SelectedValue = "CUST_CD"
            fTarget.SEARCH_KEY.Text = CUST_CD.Text
            fTarget.SearchData()
            fTarget.SEARCH_TYPE.SelectedValue = SearchType
        End If

    End Sub

    Private Sub CMPT_YMD2_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMPT_YMD2.Validated
        If Not String.IsNullOrEmpty(CMPT_YMD2.Text) Then
            WORK_USR2.EditValue = ClientSessionInfo.LocalName
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

    'Private Sub GV1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV1.FocusedRowChanged
    '    WG3_DEV_CONTENT.Text = ""
    '    If GV1.RowCount > 0 Then
    '        SearchDetailData()
    '    End If


    '    'If GV1.RowCount > 0 Then
    '    '    Dim P As Point = GV1.GridControl.PointToClient(MousePosition)
    '    '    Dim info As GridHitInfo = GV1.CalcHitInfo(P)
    '    '    If info.InRow = True Then
    '    '        SearchDetailData()
    '    '    End If

    '    'End If
    'End Sub

    Private Sub GV1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV1.Click
        WG3_DEV_CONTENT.Text = ""
        If GV1.RowCount > 0 Then
            SearchDetailData()
        End If
    End Sub

    Private Sub GV1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV1.KeyDown
        If (e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.PageUp Or e.KeyCode = Keys.PageDown) Then
            WG3_DEV_CONTENT.Text = ""
            If GV1.RowCount > 0 Then
                SearchDetailData()
            End If
        End If
    End Sub


    Private Sub GV4_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GV4.DoubleClick
        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing

        frmMain = Me.MdiParent
        fTarget = frmMain.NavigateTo("CrmAsView", NavigatedWindowModes.Dialog, False)
        If Not IsNothing(fTarget) Then
            fTarget.frmMain = frmMain
            'fTarget.MNGT_NO.Text = GV4.GetRowCellValue(GV4.FocusedRowHandle, "MNGT_NO").ToString
            fTarget.sMngtNo = GV4.GetRowCellValue(GV4.FocusedRowHandle, "MNGT_NO").ToString
            'fTarget.SearchData()
            fTarget.ShowDialog()
        End If
    End Sub

    Private Sub CUST_CD_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUST_CD.Validated
        Call SearchHistory()
    End Sub

    Private Sub REQ_YMD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REQ_YMD.TextChanged, REQ_HM.TextChanged, TEL_NO.TextChanged, REQ_USR.TextChanged, CONTENT.TextChanged, PRAR_YMD.TextChanged, CUST_CD.TextChanged, CMPT_YMD.TextChanged, CMPT_HM.TextChanged, xtcRemark.TextChanged, RMK.TextChanged
        If MODIFY_YN.Text = "Y" Then Exit Sub
        MODIFY_YN.Text = "Y"
    End Sub

    Private Sub WORK_USR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WORK_USR.SelectedIndexChanged, REQ_TYPE2.SelectedIndexChanged, REQ_TYPE.SelectedIndexChanged, REQ_SVC2.SelectedIndexChanged, REQ_SVC.SelectedIndexChanged, PROC_TYPE.SelectedIndexChanged, PRIORITY.SelectedIndexChanged, FREE_YN.SelectedIndexChanged, EX_IM_TYPE.SelectedIndexChanged
        If MODIFY_YN.Text = "Y" Then Exit Sub
        MODIFY_YN.Text = "Y"
    End Sub

    Private Sub DEPT_AUTH_LIST_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DEPT_AUTH_LIST.EditValueChanged
        If MODIFY_YN.Text = "Y" Then Exit Sub
        MODIFY_YN.Text = "Y"
    End Sub
End Class

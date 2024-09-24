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


Public Class CrmTwmsMgt

    Private bBindToDataset As Boolean = False
    Private SearchFlag As Boolean = False
    Private bFormLoding As Boolean = False
    Private tempRoot As String = Application.StartupPath & "\TMP_OUTPUT"


#Region "=================Data logic actions==========="

    Private Function GetConvertToDataSet() As DataSet


        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
            YJSql.SqlBox("WG1", "CrmTwmsMgt@Search")
            YJSql.Params("SEARCH_KEY", drMAIN("SEARCH_KEY").ToString.Trim, True)
            YJSql.Blocks("SEARCH_KEY", drMAIN("SEARCH_KEY").ToString.Trim, True)
            YJSql.Params("SVC_CD", drMAIN("S_SVC_CD").ToString.Trim, True)
            YJSql.Blocks("SVC_CD", drMAIN("S_SVC_CD").ToString.Trim, True)
            YJSql.Params("USE_YN", drMAIN("S_USE_YN").ToString.Trim, True)
            YJSql.Blocks("USE_YN", drMAIN("S_USE_YN").ToString.Trim, True)
            YJSql.Params("GBUN", drMAIN("S_GBUN").ToString.Trim, True)
            YJSql.Blocks("GBUN", drMAIN("S_GBUN").ToString.Trim, True)

            If drMAIN("UNIPASS_YN").ToString <> "A" Then
                YJSql.Params("UNIPASS_YN", drMAIN("UNIPASS_YN").ToString.Trim, True)
                YJSql.Blocks("UNIPASS_YN", drMAIN("UNIPASS_YN").ToString.Trim, True)
            End If

            'If drMAIN("S_SAVE_YN").ToString.Trim <> "" Then
            '    If drMAIN("S_SAVE_YN").ToString.Trim = "Y" Then
            '        YJSql.Blocks("SAVE_Y", drMAIN("S_SAVE_YN").ToString.Trim, True)
            '    Else
            '        YJSql.Blocks("SAVE_N", drMAIN("S_SAVE_YN").ToString.Trim, True)
            '    End If
            'End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function
    Private Function GetConvertToDataSet2(ByVal CUST_CD As String) As DataSet


        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
            YJSql.SqlBox("WG1", "CrmTwmsMgt@CUST_CHK")
            YJSql.Params("SEARCH_KEY", CUST_CD, True)

            'If drMAIN("S_SAVE_YN").ToString.Trim <> "" Then
            '    If drMAIN("S_SAVE_YN").ToString.Trim = "Y" Then
            '        YJSql.Blocks("SAVE_Y", drMAIN("S_SAVE_YN").ToString.Trim, True)
            '    Else
            '        YJSql.Blocks("SAVE_N", drMAIN("S_SAVE_YN").ToString.Trim, True)
            '    End If
            'End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function

    Private Function GetWG2(ByVal CUST_CD As String) As DataSet


        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
            YJSql.SqlBox("WG2", "CrmTwmsMgt@Search")
            YJSql.Params("SEARCH_KEY", drMAIN("SEARCH_KEY").ToString.Trim, True)
            YJSql.Blocks("SEARCH_KEY", drMAIN("SEARCH_KEY").ToString.Trim, True)
            YJSql.Params("SVC_CD", drMAIN("S_SVC_CD").ToString.Trim, True)
            YJSql.Blocks("SVC_CD", drMAIN("S_SVC_CD").ToString.Trim, True)
            YJSql.Params("USE_YN", drMAIN("S_USE_YN").ToString.Trim, True)
            YJSql.Blocks("USE_YN", drMAIN("S_USE_YN").ToString.Trim, True)
            YJSql.Params("GBUN", drMAIN("S_GBUN").ToString.Trim, True)
            YJSql.Blocks("GBUN", drMAIN("S_GBUN").ToString.Trim, True)

            If drMAIN("UNIPASS_YN").ToString <> "A" Then
                YJSql.Params("UNIPASS_YN", drMAIN("UNIPASS_YN").ToString.Trim, True)
                YJSql.Blocks("UNIPASS_YN", drMAIN("UNIPASS_YN").ToString.Trim, True)
            End If

            YJSql.Params("CUST_CD", CUST_CD, True)
            YJSql.Blocks("CUST_CD", CUST_CD, True)

            'If drMAIN("S_SAVE_YN").ToString.Trim <> "" Then
            '    If drMAIN("S_SAVE_YN").ToString.Trim = "Y" Then
            '        YJSql.Blocks("SAVE_Y", drMAIN("S_SAVE_YN").ToString.Trim, True)
            '    Else
            '        YJSql.Blocks("SAVE_N", drMAIN("S_SAVE_YN").ToString.Trim, True)
            '    End If
            'End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function
    'Private Function GetConvertToDataSet(ByVal KEY As String) As DataSet
    '    Dim YJSql As New YJQuery
    '    Dim ds As DataSet = Me.ConvertToDataset

    '    Try
    '        Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
    '        Select Case KEY
    '            Case "CrmUserInfo"
    '                YJSql.SqlBox("CrmUserInfo", "CrmAsMgtDev@CrmUserInfo", True)
    '            Case "REQ_SVC2"
    '                YJSql.SqlBox("REQ_SVC2", "CrmAsMgt_v2@GetReqSvc2List", True)
    '        End Select
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try

    '    Return YJSql.DataSet
    'End Function

    Public Sub SearchData()
        If SearchValidate() = False Then Exit Sub

        Dim dsRet As DataSet = GetConvertToDataSet()

        dsRet = MethodCallEx(Me, "YJIT.Biz.CrmTwmsMgt", "Search", {dsRet})
        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case drPairs("TrxCode")
            Case "Y"
                Me.BindToDataset(dsRet, "Data")

                Me.DataState = UI.DataStates.Retrieved
            Case "N"
                MsgBoxLocalized(drPairs("TrxMsg"))
                Call ClearView(AppliedRangeTypes.Only, {WG1})

                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(drPairs("TrxMsg"))
        End Select
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
    Public Sub search_OnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Try
            If IsNothing(e.Result) Then
                Throw New Exception("Try Again!")
            End If
            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
            'If dr("TrxCode") <> "Y" Then
            '    If dr("TrxCode") = "N" Then
            '        ClearView(AppliedRangeTypes.Only, {WG1})
            '        S_EXRT_YMD.Focus()
            '    End If
            '    If dr("TrxCode") = "E" Then
            '        MsgBoxLocalized(dr("TrxMsg"))
            '        S_EXRT_YMD.Focus()
            '    End If
            '    Exit Sub
            'End If
            Me.BindToDataset(ds, "Data")

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Sub AddNewRow(ByVal dt As DataTable, ByVal Code As String, ByVal Name As String)
        dt.Rows.Add()
        dt.Rows(dt.Rows.Count - 1)("CODE") = Code
        dt.Rows(dt.Rows.Count - 1)("NAME") = Name
    End Sub

    Private Sub GridInit()
        Dim editorCombo As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim editor As New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)
        Dim dt As DataTable = Nothing
        Dim editorDate As YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit

        Common.DrawRowIndicator({GV1})
        'Call SetGridUserID()

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


        editorDate = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
        GV1.Columns("INP_DT").ColumnEdit = editorDate
        GV2.Columns("INP_DT").ColumnEdit = editorDate

        editorDate = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
        GV1.Columns("UPD_DT").ColumnEdit = editorDate
        GV2.Columns("UPD_DT").ColumnEdit = editorDate

        'dt = New DataTable
        'dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        'dt.Columns.Add(New DataColumn("NAME", GetType(String)))
        'AddNewRow(dt, "Y", "Y")
        'AddNewRow(dt, "N", "N")

        'editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        'editorCombo.DisplayMember = "NAME"
        'editorCombo.ValueMember = "CODE"
        'editorCombo.NullText = ""
        'editorCombo.DataSource = dt.Copy
        'editorCombo.ForceInitialize()
        'editorCombo.PopulateColumns()
        'editorCombo.Columns("CODE").Visible = False
        'editorCombo.ShowHeader = False
        'GV1.Columns("USE_YN").ColumnEdit = editorCombo
        'GV1.Columns("SERVER").ColumnEdit = editorCombo
        'GV1.Columns("TAX_YN").ColumnEdit = editorCombo

        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))
        AddNewRow(dt, "1", "BOSS소스")
        AddNewRow(dt, "2", "ELVIS소스")
        AddNewRow(dt, "3", "ELVIS21소스")
        AddNewRow(dt, "4", "업체분리소스")

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV1.Columns("VERSION").ColumnEdit = editorCombo
        GV2.Columns("VERSION").ColumnEdit = editorCombo


        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "TW01")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV1.Columns("GBUN").ColumnEdit = editorCombo
        GV2.Columns("GBUN").ColumnEdit = editorCombo

        'GV1.Columns("CTRT_YMD").ColumnEdit = editorDate

        'editor = New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        'editor.CodeType = "YJIT.CodeService.Customer"
        'editor.DisplayParams = "Code:#CUST_CD,CUST_LOCNM:#CUST_NM"
        'editor.ValidateKeys = "KEY:#CUST_CD"
        'editor.DataParams = "Type:''"
        'editor.KeepIntegrity = False '거래처명 별도 관리
        'editor.AutoSuggestion = False
        'editor.MaxLength = "10"
        'editor.SearchPopup = "CustomerMaster"
        'editor.CharacterCasing = CharacterCasing.Upper
        'GV1.Columns("CUST_CD").ColumnEdit = editor


        'editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        'editorCombo.ValueMember = "CODE"
        'editorCombo.DisplayMember = "NAME"
        'editorCombo.NullText = ""
        'searchParams = New Dictionary(Of String, Object)
        'dataParams = New Dictionary(Of String, Object)
        'dataParams.Add("GroupCode", "P06")
        'dataParams.Add("NameType", "")
        'editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        'editorCombo.ForceInitialize()
        'editorCombo.PopulateColumns()
        'editorCombo.Columns("CODE").Visible = False
        'editorCombo.ShowHeader = False
        'GV1.Columns("JOIN_TYPE").ColumnEdit = editorCombo

        'editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        'editorCombo.ValueMember = "CODE"
        'editorCombo.DisplayMember = "NAME"
        'editorCombo.NullText = ""
        'searchParams = New Dictionary(Of String, Object)
        'dataParams = New Dictionary(Of String, Object)
        'dataParams.Add("GroupCode", "P07")
        'dataParams.Add("NameType", "")
        'editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        'editorCombo.ForceInitialize()
        'editorCombo.PopulateColumns()
        'editorCombo.Columns("CODE").Visible = False
        'editorCombo.ShowHeader = False
        'GV1.Columns("JOIN_ROUTE").ColumnEdit = editorCombo

    End Sub
    Private Sub GV1_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV1.CellValueChanged
        If GV1.RowCount > 0 Then


            Select Case e.Column.FieldName

                Case "CUST_CD"  '거래처 코드 입력시 CRM에 등록된 서버 정보들 가지고옴
                    If GV1.GetRowCellValue(GV1.FocusedRowHandle, "CUST_CD").ToString & "" <> "" Then
                        If GV1.RowCount = 0 Then Exit Sub

                        Dim dsRet As DataSet
                        Try
                            dsRet = MethodCallEx(Me, "YJIT.Biz.CrmTwmsMgt", "CUST_CHK", {GV1.GetRowCellValue(GV1.FocusedRowHandle, "CUST_CD").ToString & ""})
                        Catch ex As Exception
                            MsgBoxLocalized(ex.Message)
                            Exit Sub
                        End Try

                        Dim dt As New DataTable
                        dt = dsRet.Tables("DATA.CUST_CHK")
                        If dt.Rows.Count > 0 Then
                            Throw New Exception("이미 등록된 거래처 입니다")
                            Exit Sub
                        End If
                        Dim dsRet2 As DataSet
                        dsRet2 = MethodCallEx(Me, "YJIT.Biz.CrmTwmsMgt", "Search_detail", {GV1.GetFocusedRowCellValue("CUST_CD").ToString})

                        Dim drPairs2 As DataRow = dsRet2.Tables("KEY_VALUE_PAIRS").Rows(0)

                        If drPairs2("Status") <> "SUCCESS" Then
                            Exit Sub
                        Else
                            'Me.BindToDataset(dsRet, "Data")
                            'Me.DataState = UI.DataStates.None
                            Dim dt2 As New DataTable
                            dt2 = dsRet2.Tables("DATA.WG1")
                            GV1.SetRowCellValue(GV1.FocusedRowHandle, "IP_ADDRESS", dt2.Rows(0)("IP_ADDRESS"))
                            GV1.SetRowCellValue(GV1.FocusedRowHandle, "WEB_IP", dt2.Rows(0)("WEB_IP"))
                            GV1.SetRowCellValue(GV1.FocusedRowHandle, "PORT_NO", dt2.Rows(0)("PORT_NO"))
                            GV1.SetRowCellValue(GV1.FocusedRowHandle, "SID_NAME", dt2.Rows(0)("SID_NAME"))
                            GV1.SetRowCellValue(GV1.FocusedRowHandle, "SCHEMA_ID", dt2.Rows(0)("SCHEMA_ID"))
                            GV1.SetRowCellValue(GV1.FocusedRowHandle, "SCHEMA_PW", dt2.Rows(0)("SCHEMA_PW"))
                        End If
                    End If

            End Select
            'GV1.RefreshData()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchData()
    End Sub

    Private Sub CrmTwmsMgt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IO.Directory.Exists(tempRoot) Then IO.Directory.CreateDirectory(tempRoot)
    End Sub

    Private Sub CrmTwmsMgt_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Call GridInit()
        Call PopupInit()
        'Call SearchData()
    End Sub


    Public Sub PopupInit()
        Dim PopUp As New PopupBase

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG1_ADDROW", "Add row", True)
        PopUp.ItemAdd(Action.DeleteRow, "WG1_DELETEROW", "Delete row")
        PopUp.ItemAdd(Action.Other, "WG1_COPY", "선택 행 복사", BarIcon.AddRow)
        PopUp.ItemAdd(Action.NavigateTo, "ComDocumentMgt", "Document")
        PopUp.ItemAdd(Action.NavigateTo, "CrmCustomerMgt", "거래처관리")
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", Me.Localizer.GetLocalizedString("&Export Excel"), True)
        PopUp.PopUpInit(Me, WG1, "CUST_CD", "TAX_YN")

    End Sub
    Public Sub PopUpOnAfterClick(ByVal Dr As DataRow)
        Dim r As Integer = 0
        Dim Key As String = Dr("Key")
        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing

        Select Case Dr("Action")
            Case Action.Other
                Select Case Key
                    Case "WG1_COPY"
                        '복사할 행의 수를 저장한다.
                        Dim z As Integer = GV1.FocusedRowHandle

                        '행 추가
                        WG1.AddRow()
                        With GV1
                            Dim j As Integer = GV1.FocusedRowHandle
                            If j <> 0 Then
                                .SetRowCellValue(j, "IP_ADDRESS", .GetRowCellValue(z, "IP_ADDRESS").ToString & "")
                                .SetRowCellValue(j, "PORT_NO", .GetRowCellValue(z, "PORT_NO").ToString & "")
                                .SetRowCellValue(j, "SID_NAME", .GetRowCellValue(z, "SID_NAME").ToString & "")
                                .SetRowCellValue(j, "SCHEMA_ID", .GetRowCellValue(z, "SCHEMA_ID").ToString & "")
                                .SetRowCellValue(j, "SCHEMA_PW", .GetRowCellValue(z, "SCHEMA_PW").ToString & "")
                                .SetRowCellValue(j, "VERSION", .GetRowCellValue(z, "VERSION").ToString & "")
                                .SetRowCellValue(j, "INS_ID", .GetRowCellValue(z, "INS_ID").ToString & "")
                                .SetRowCellValue(j, "INS_PW", .GetRowCellValue(z, "INS_PW").ToString & "")
                                .SetRowCellValue(j, "SCHEMA", .GetRowCellValue(z, "SCHEMA").ToString & "")
                                .SetRowCellValue(j, "WEBIP", .GetRowCellValue(z, "WEBIP").ToString & "")
                                .SetRowCellValue(j, "EDI_USERID", .GetRowCellValue(z, "EDI_USERID").ToString & "")
                                .SetRowCellValue(j, "EDI_USERPW", .GetRowCellValue(z, "EDI_USERPW").ToString & "")
                                .SetRowCellValue(j, "NPKI_PW", .GetRowCellValue(z, "NPKI_PW").ToString & "")
                                .SetRowCellValue(j, "RMK", .GetRowCellValue(z, "RMK").ToString & "")
                                .SetRowCellValue(j, "MAIL_BOX_ID", .GetRowCellValue(z, "MAIL_BOX_ID").ToString & "")
                                .SetRowCellValue(j, "REG_NO", .GetRowCellValue(z, "REG_NO").ToString & "")
                                .SetRowCellValue(j, "WH_CODE", .GetRowCellValue(z, "WH_CODE").ToString & "")
                                .SetRowCellValue(j, "GBUN", .GetRowCellValue(z, "GBUN").ToString & "")
                                .SetRowCellValue(j, "SERVER", .GetRowCellValue(z, "SERVER").ToString & "")
                                .SetRowCellValue(j, "USE_YN", .GetRowCellValue(z, "USE_YN").ToString & "")
                                .SetRowCellValue(j, "TAX_YN", .GetRowCellValue(z, "TAX_YN").ToString & "")
                                .SetRowCellValue(j, "VPN_ID", .GetRowCellValue(z, "VPN_ID").ToString & "")
                                .SetRowCellValue(j, "VPN_PW", .GetRowCellValue(z, "VPN_PW").ToString & "")
                            End If
                        End With
                End Select
            Case Action.Addrow
                Select Case Key
                    Case "WG1_ADDROW"
                        'GV1.SetFocusedRowCellValue("CUST_CD", CUST_CD.Text)
                        GV1.SetFocusedRowCellValue("USE_YN", "Y")
                        GV1.SetFocusedRowCellValue("GBUN", "W")
                        GV1.SetFocusedRowCellValue("SERVER", "N")
                        GV1.SetFocusedRowCellValue("PORT_NO", "1521")
                        GV1.SetFocusedRowCellValue("SID_NAME", "ORCL")
                        GV1.SetFocusedRowCellValue("VERSION", "2")
                        GV1.SetFocusedRowCellValue("GBUN", "W")
                        GV1.SetFocusedRowCellValue("TAX_YN", "N")
                        'GV1.Focus()
                        GV1.FocusedColumn = GV1.Columns("CUST_CD")
                        GV1.ShowEditor()

                End Select
            Case Action.NavigateTo
                Select Case Key
                    Case "CrmCustomerMgt"
                        If GV1.GetRowCellValue(GV1.FocusedRowHandle, "CUST_CD").ToString <> "" Then
                            frmMain = Me.MdiParent
                            fTarget = frmMain.NavigateTo("CrmCustomerMgt")
                            If Not IsNothing(fTarget) Then
                                fTarget.SEARCH_TYPE.SelectedValue = "CUST_CD"
                                fTarget.SEARCH_KEY.Text = GV1.GetRowCellValue(GV1.FocusedRowHandle, "CUST_CD").ToString
                                fTarget.SearchData()
                            End If

                        End If
                    Case "ComDocumentMgt"
                        'fTarget = frmMain.NavigateTo(Key, NavigatedWindowModes.Dialog, False)
                        'If Not IsNothing(fTarget) Then
                        '    fTarget.ParentWindow = Me
                        '    fTarget.S_MNGT_NO.text = GV1.GetFocusedRowCellValue("CUST_CD").ToString
                        '    fTarget.SCREEN.Text = "거래처관리"
                        '    fTarget.DirList.Text = "CrmCustomerMgt"
                        '    fTarget.SearchData()
                        '    fTarget.ShowDialog()
                        ' Call SetDocType()
                        frmMain = Me.MdiParent
                        fTarget = frmMain.NavigateTo("ComDocumentMgt")
                        If Not IsNothing(fTarget) Then
                            fTarget.ParentWindow = Me
                            fTarget.S_MNGT_NO.text = GV1.GetRowCellValue(GV1.FocusedRowHandle, "CUST_CD").ToString
                            fTarget.SCREEN.Text = "거래처관리"
                            fTarget.DirList.Text = "CrmCustomerMgt"
                            fTarget.SearchData()
                            'fTarget.ShowDialog()
                        End If


                End Select

                'frmMain = Me.MdiParent
                'Select Case Key
                '    Case "WG3_ComDocumentMgt"
                '        fTarget = frmMain.NavigateTo("ComDocumentMgt", NavigatedWindowModes.Dialog, False)
                '        If fTarget IsNot Nothing Then
                '            fTarget.S_MNGT_NO.text = GV3.GetFocusedRowCellValue("MNGT_NO").ToString
                '            fTarget.SCREEN.Text = "사이트 지원 등록"
                '            fTarget.DirList.Text = "CrmAsMgt"
                '            fTarget.SearchData()
                '            fTarget.ShowDialog()
                '        End If
                '    Case "ComDocumentMgt"
                '        fTarget = frmMain.NavigateTo(Key, NavigatedWindowModes.Dialog, False)
                '        If Not IsNothing(fTarget) Then
                '            fTarget.ParentWindow = Me
                '            fTarget.S_MNGT_NO.text = GV1.GetFocusedRowCellValue("CUST_CD").ToString
                '            fTarget.SCREEN.Text = "거래처관리"
                '            fTarget.DirList.Text = "CrmCustomerMgt"
                '            fTarget.SearchData()
                '            fTarget.ShowDialog()
                '            ' Call SetDocType()
                '        End If
                '    Case "CrmAsInput"
                '        frmMain = Me.MdiParent
                '        fTarget = frmMain.NavigateTo("CrmAsInput", NavigatedWindowModes.Dialog, False)
                '        If Not IsNothing(fTarget) Then
                '            fTarget.frmMain = frmMain
                '            fTarget.REQ_YMD.Text = Now.ToString("yyyyMMdd")
                '            fTarget.REQ_HM.Text = Now.ToString("HHmm")
                '            fTarget.MNGT_NO.Text = ""
                '            fTarget.CUST_CD.text = GV1.GetFocusedRowCellValue("CUST_CD").ToString
                '            fTarget.CUST_NM.text = GV1.GetFocusedRowCellValue("CUST_NM").ToString

                '            If GV5.RowCount > 0 Then
                '                fTarget.OLD_CUST_CD.text = GV1.GetFocusedRowCellValue("CUST_CD").ToString
                '                fTarget.OLD_REQ_USR.text = GV5.GetFocusedRowCellValue("PIC_NM").ToString
                '                fTarget.REQ_USR.text = GV5.GetFocusedRowCellValue("PIC_NM").ToString
                '                fTarget.TEL_NO.text = GV5.GetFocusedRowCellValue("TEL_NO").ToString
                '            End If
                '            fTarget.REQ_USR.Select()
                '            ' fTarget.SearchData()
                '            fTarget.ShowDialog()
                '        End If
                '    Case "ComLogMgt"
                '        frmMain = Me.MdiParent
                '        fTarget = frmMain.NavigateTo("ComLogMgt", NavigatedWindowModes.Dialog, False)
                '        If Not IsNothing(fTarget) Then
                '            'fTarget.frmMain = frmMain
                '            fTarget.HBL_NO.text = GV1.GetFocusedRowCellValue("CUST_CD").ToString
                '            fTarget.HBL_NO.text = GV1.GetFocusedRowCellValue("CUST_CD").ToString
                '            fTarget.SearchData()
                '            fTarget.ShowDialog()
                '        End If
                'End Select
        End Select

    End Sub

    Public Sub PopUpOnBeforeClick(ByVal dr As DataRow)
        Dim Key As String = dr("KEY")
        Dim Sender As String = ""
        If Not dr("Sender") Is System.DBNull.Value Then Sender = dr("Sender")

        Try
            'Select Case dr("Action")
            '    Case Action.NavigateTo

            'End Select
            'Select Case Key
            '    Case "WG_RPA_ADDROW"
            '        If String.IsNullOrEmpty(CUST_CD.Text) _
            '                   OrElse String.IsNullOrEmpty(CUSTOMS_CD.Text) _
            '                   OrElse String.IsNullOrEmpty(CRN.Text) Then
            '            MsgBoxLocalized("거래처코드, 세관코드, 사업자번호는 필수로 입력해야 합니다.")
            '            dr("Cancel") = True
            '        End If
            '    Case "WG_RPA_DELETEROW"
            '        If GV_RPA.RowCount = 0 Then
            '            dr("Cancel") = True
            '            Exit Sub
            '        End If

            '        Dim row As DataRow = GV_RPA.GetFocusedDataRow
            '        If row.RowState <> DataRowState.Added Then
            '            MsgBoxLocalized("추가된 행만 삭제가능 합니다.")
            '            dr("Cancel") = True
            '        End If
            'End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message, MessageBoxButtons.OK, "Process failed!", MessageBoxIcon.Error)
            dr("Cancel") = True
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call SaveData()
        SearchData()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)

    End Sub

    Private Function MandatoryGridValue(ByVal gridView As String) As Boolean
        Dim Param As New Dictionary(Of String, Object)
        Dim checkNull() As String = Nothing
        Select Case gridView
            Case "GV1"
                checkNull = {"CUST_CD", "CUST_NM", "USE_YN"}
                Param("CUST_CD") = GV1_CUST_CD.Caption()
                Param("CUST_NM") = GV1_CUST_NM.Caption()
                Param("USE_YN") = GV1_USE_YN.Caption()
                Return ValidateGridValue(GV1, Param, checkNull)
        End Select
        Return False
    End Function

    Private Function GetConvertToDataSet(ByVal SearchType As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim IsSingleSearch As Boolean = False

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)

            Select Case SearchType.ToString.ToUpper
                Case "Search".ToUpper
                    YJSql.SqlBox("WG1", "CrmTwmsMgt@Search", True)
                    YJSql.Params("FM_YMD", drMAIN("SEARCH_KEY").ToString)
                    YJSql.Params("TO_YMD", drMAIN("S_SVC_CD").ToString)
                    YJSql.Params("DEPT_CD", drMAIN("S_USE_YN").ToString)

                Case Else
                    Throw New Exception("No match type found. (GetConvertToDataSet)")
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function

    Public Sub SaveData()
        'If SaveValidate() = False Then Exit Sub

        If MandatoryGridValue("GV1") Then Exit Sub

        Try
            Dim ds As DataSet = Me.ConvertToDataset
            If ds.Tables("WG1").Rows.Count = 0 Then
                If ds.Tables("WG2").Rows.Count = 0 Then
                    MsgBoxLocalized("Save Data not found!")
                    Exit Sub
                End If

            End If



            For Each dt As DataTable In GetConvertToDataSet("Search").Tables
                ds.Tables.Add(dt.Copy)
            Next
            Try
                ds = MethodCallEx(Me, "YJIT.Biz.CrmTwmsMgt", "Save", ds)
            Catch ex As Exception
                MsgBoxLocalized(ex.Message)
                Exit Sub
            End Try

            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") = "Y" Then
                bBindToDataset = True
                Call ClearView(AppliedRangeTypes.Only, {WG1, WG2})
                Me.BindToDataset(ds, "Data")
                bBindToDataset = False
                Me.DataState = UI.DataStates.Retrieved
            End If

            MsgBoxLocalized(dr("TrxMsg"))
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GV1_Click(sender As Object, e As EventArgs) Handles GV1.Click
        If GV1.RowCount = 0 Then
            Exit Sub
        End If
        Dim CUST_CD As String

        If IsDBNull(GV1.GetRowCellValue(GV1.FocusedRowHandle, "CUST_CD")) Then
            CUST_CD = ""
        Else

            With sender
                Dim i As String = .FocusedRowHandle

                CUST_CD = .GetRowCellValue(i, "CUST_CD")
                Dim dsRet As DataSet = GetWG2(CUST_CD)

                dsRet = MethodCallEx(Me, "YJIT.Biz.CrmTwmsMgt", "Search", {dsRet})
                Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

                Select Case drPairs("TrxCode")
                    Case "Y"
                        Me.BindToDataset(dsRet, "Data")

                        Me.DataState = UI.DataStates.Retrieved
                    Case "N"
                        MsgBoxLocalized(drPairs("TrxMsg"))
                        Call ClearView(AppliedRangeTypes.Only, {WG1, WG2})

                        Me.DataState = UI.DataStates.Retrieved
                    Case Else
                        MsgBoxLocalized(drPairs("TrxMsg"))
                End Select
            End With

        End If
    End Sub


    Private Sub GV1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV1.FocusedRowChanged
        If GV1.RowCount = 0 Then
            Exit Sub
        End If
        Dim CUST_CD As String

        If IsDBNull(GV1.GetRowCellValue(GV1.FocusedRowHandle, "CUST_CD")) Then
            CUST_CD = ""
        Else

            With sender
                Dim i As String = .FocusedRowHandle

                CUST_CD = .GetRowCellValue(i, "CUST_CD")
                Dim dsRet As DataSet = GetWG2(CUST_CD)

                dsRet = MethodCallEx(Me, "YJIT.Biz.CrmTwmsMgt", "Search", {dsRet})
                Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

                Select Case drPairs("TrxCode")
                    Case "Y"
                        Me.BindToDataset(dsRet, "Data")

                        Me.DataState = UI.DataStates.Retrieved
                    Case "N"
                        MsgBoxLocalized(drPairs("TrxMsg"))
                        Call ClearView(AppliedRangeTypes.Only, {WG1, WG2})

                        Me.DataState = UI.DataStates.Retrieved
                    Case Else
                        MsgBoxLocalized(drPairs("TrxMsg"))
                End Select
            End With

        End If
    End Sub

#End Region




End Class
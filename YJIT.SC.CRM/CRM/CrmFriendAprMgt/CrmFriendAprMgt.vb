Imports YJIT.SC.UI
Imports YJIT.SC.App.FreightCommon
Imports YJIT.SC.App.Common
Imports System.Net.Mail
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Text.RegularExpressions

Public Class CrmFriendAprMgt
    Dim comdoc As ComDoc = New ComDoc()
    Dim SelectAllYn As Boolean = False
    Private tempFolder As String = Application.StartupPath & "\TMP_OUTPUT"
#Region "=================GetConvertToDataSet Function==========="
    Private Function GetConvertToDataSet(ByVal SearchType As String, Optional ByVal dtWG1 As DataTable = Nothing) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)

        Select Case SearchType.ToUpper
            Case "Search".ToUpper
                YJSql.SqlBox("WG1", "CrmFriendAprMgt@Search",, False)
                YJSql.Params("S_APV_YN", drMAIN("S_APV_YN").ToString)
                YJSql.Params("S_USR_ID", drMAIN("S_USR_ID").ToString)
                YJSql.Params("S_USR_NM", drMAIN("S_USR_NM").ToString)
                YJSql.Params("S_LOC_NM", drMAIN("S_LOC_NM").ToString)
            Case "SearchEmail".ToUpper
                Dim mngtList As String = String.Empty
                For Each row As DataRow In dtWG1.Rows
                    If Not String.IsNullOrEmpty(mngtList) Then mngtList &= "','"
                    mngtList &= row("MNGT_NO").ToString
                Next
                YJSql.SqlBox("WG1", "CrmFriendAprMgt@SearchEmail", True)
                YJSql.Params("MNGT_NO", mngtList)
                'Case "SearchCrm".ToUpper
                '    YJSql.SqlBox("CRM", "CrmFriendAprMgt@SearchCrm", True)
                '    YJSql.Params("CRM_CD", drMAIN("CRM_CD").ToString)
        End Select

        Return YJSql.DataSet
    End Function
    'Private Function GetConvertToDataSet_ChkDup() As DataSet
    '    Dim YJSql As New YJQuery
    '    Dim IsSingleSearch As Boolean = False

    '    Try
    '        YJSql.SqlBox("WG1", "CrmFriendAprMgt@SearchDuplicate", , False)
    '        YJSql.Params("EMAIL", GV1.GetRowCellValue(GV1.FocusedRowHandle, "EMAIL").ToString)
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try

    '    Return YJSql.DataSet
    'End Function
#End Region
#Region "=================Data logic actions==========="
    'Search
    Private Sub SearchData()
        If SearchValidate() = False Then Exit Sub
        Dim dsret As DataSet = GetConvertToDataSet("Search")
        dsret = MethodCallEx(Me, "YJIT.Biz.CrmFriendAprMgt", "Search", {dsret})
        Dim drpairs As DataRow = dsret.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case drpairs("TrxCode")
            Case "Y"
                Me.BindToDataset(dsret, "Data")
                Me.DataState = UI.DataStates.Retrieved
                If GV1.RowCount = 0 Then
                    MsgBoxLocalized("Data not found!")
                End If

                Me.DataState = UI.DataStates.Retrieved
            Case "N"
                MsgBoxLocalized(drpairs("TrxMsg"))
                Call ClearView(AppliedRangeTypes.Only, {WG1})
                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(drpairs("trxMsg"))
        End Select
    End Sub
    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Try
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
    'Save
    Private Sub SaveData()
        If MandatoryGridValue("GV1") Then Exit Sub

        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then Exit Sub

        '실제 수정된것만 서버에가게 수정
        Dim dtEmail As DataTable = CType(WG1.DataSource, DataTable).Clone
        dtEmail.TableName = "WG1"
        For i = 0 To CType(WG1.DataSource, DataTable).Rows.Count - 1
            GV1.GetDataRow(i).AcceptChanges()
            If GV1.GetDataRow(i)("APV_YN").ToString <> GV1.GetDataRow(i)("DB_APV_YN").ToString Then
                GV1.GetDataRow(i).SetModified()
                If GV1.GetDataRow(i)("APV_YN").ToString <> GV1.GetDataRow(i)("DB_APV_YN").ToString _
                             AndAlso GV1.GetDataRow(i)("APV_YN").ToString <> "N" Then
                    dtEmail.ImportRow(GV1.GetDataRow(i))
                End If
            End If
        Next

        Dim ds As DataSet = Me.ConvertToDataset
        'Dim SearchDs As DataSet = GetConvertToDataSet("Search")
        'ds.Merge(SearchDs)

        If ds.Tables("WG1").Rows.Count = 0 Then
            MsgBoxLocalized("Data Is empty!")
            Exit Sub
        End If

        'If SaveValidate(ds) = False Then Exit Sub

        Try
            Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", "자료 저장중 입니다. 잠시만 기다려 주세요.")
                ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmFriendAprMgt", "Save", {ds})
            End Using
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        '메일 메시지에 대한 변수
        ' Dim Msg As String = String.Empty

        Select Case dr("TrxCode")
            Case "Y"
                If dtEmail.Rows.Count > 0 Then
                    Dim dsEmail As DataSet = GetConvertToDataSet("SearchEmail", dtEmail)
                    Try
                        dsEmail = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmFriendAprMgt", "Search", {dsEmail})
                    Catch ex As Exception
                        MsgBoxLocalized(ex.Message)
                        Exit Sub
                    End Try
                    Dim drEmail As DataRow = dsEmail.Tables("KEY_VALUE_PAIRS").Rows(0)

                    Select Case drEmail("TrxCode").ToString
                        Case "Y"
                            Call MailSend(dsEmail.Tables("Data.WG1").Copy)
                        Case Else
                            MsgBoxLocalized("저장은 완료되었으며, 메일전송에 실패했습니다.")
                            Exit Sub
                    End Select
                Else
                    MsgBoxLocalized(dr("TrxMsg"))
                End If

                'If IsNothing(ds.Tables("Data.WG1")) OrElse ds.Tables("Data.WG1").Rows.Count <= 0 Then
                '    MsgBoxLocalized("Data Not found!")
                '    ClearView(AppliedRangeTypes.Only, {WG1})
                'Else
                '    Me.BindToDataset(ds, "Data")
                'End If
                Call SearchData()
                Me.DataState = UI.DataStates.Retrieved
            Case "Q"
                MsgBoxLocalized(dr("TrxMsg"))
            Case Else
                MsgBoxLocalized(dr("TrxMsg"))
        End Select
    End Sub
    Public Function MandatoryGridValue(ByVal gridView As String) As Boolean
        Dim Param As New Dictionary(Of String, Object)
        Dim checkNull() As String = Nothing

        Select Case gridView
            Case "GV1"
                ' checkNull = {"EMAIL", "CUST_CD", "DEF_OFFICE_CD"}
                ' Param("CUST_CD") = GV1_CUST_CD.Caption
                ' Param("DEF_OFFICE_CD") = GV1_DEF_OFFICE_CD.Caption
                Return ValidateGridValue(GV1, Param, checkNull)
        End Select
        Return False
    End Function
    Private Function MailSend(ByVal dtEmail As DataTable, Optional ByVal ChkErr As Boolean = False)
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim ds As DataSet = New DataSet
            ds.Tables.Add(dtEmail)
            dtEmail.TableName = "WG1"

            Dim dt As DataTable = New DataTable

            '이메일 전송을 위한 작업
            dt.TableName = "EMAIL_INFO"

            Dim Mailinfo() As String = {"MNGT_NO", "CUST_PIC_MAIL", "PKGE_TYPE", "TITLE", "SUB_TITLE", "BTN_NM", "BTN_URL", "JOB_TYPE", "Flag", "DOMAIN", "REF1"}
            Dim MailContent() As String = {"MNGT_NO", "COLUMN", "DATA"}
            Dim MailSummary() As String = {"MNGT_NO", "TYPE", "TITLE", "COLUMN", "DATA"}


            '이메일 컬럼 추가
            For i As Integer = 0 To Mailinfo.Length - 1
                dt.Columns.Add(Mailinfo(i), GetType(String))
            Next
            Dim OfficeName As String = ClientSessionOfficeInfo.LocalName


            For i As Integer = 0 To ds.Tables("WG1").Rows.Count - 1
                dt.Rows.Add()
                dt(i)("MNGT_NO") = ds.Tables("WG1")(i)("CRN").ToString 'CRN
                dt(i)("CUST_PIC_MAIL") = ds.Tables("WG1")(i)("USR_ID").ToString
                If ds.Tables("WG1")(i)("APV_YN").ToString = "D" Then
                    dt(i)("TITLE") = "[양재아이티]" & "FRIEND 승인거절 안내"
                    dt(i)("SUB_TITLE") = "FRIEND 승인 거절건 안내드립니다."

                    dt(i)("PKGE_TYPE") = "USR_D"
                    dt(i)("BTN_NM") = ""
                    dt(i)("BTN_URL") = ""
                Else
                    dt(i)("TITLE") = "[양재아이티]" & " FRIEND 회원가입 승인 안내"
                    dt(i)("SUB_TITLE") = "FRIEND 회원가입 승인 안내드립니다."

                    dt(i)("PKGE_TYPE") = "USR"
                    dt(i)("BTN_NM") = "로그인 하기"
                    dt(i)("BTN_URL") = """" & "http://friend.yjit.co.kr" & """"
                End If

            Next

            ds.Tables.Add(dt)

            dt = New DataTable
            dt.TableName = "EMAIL_CONTENT" '실제 메일나가는 부분

            For i As Integer = 0 To MailContent.Length - 1
                dt.Columns.Add(MailContent(i), GetType(String))
            Next

            For i As Integer = 0 To ds.Tables("WG1").Rows.Count - 1
                dt.Rows.Add()
                dt(dt.Rows.Count - 1)("MNGT_NO") = ds.Tables("WG1")(i)("CRN").ToString 'CRN
                dt(dt.Rows.Count - 1)("COLUMN") = "아이디"
                dt(dt.Rows.Count - 1)("DATA") = ds.Tables("WG1")(i)("USR_ID").ToString
                dt.Rows.Add()
                dt(dt.Rows.Count - 1)("MNGT_NO") = ds.Tables("WG1")(i)("CRN").ToString
                dt(dt.Rows.Count - 1)("COLUMN") = "이름"
                dt(dt.Rows.Count - 1)("DATA") = ds.Tables("WG1")(i)("USR_NM").ToString
            Next
            ds.Tables.Add(dt)

            Dim drResult As DataRow

            Try
                Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", "메일 전송중 입니다. 잠시만 기다려 주세요.")
                    ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmFriendAprMgt", "SendMail", {ds})
                End Using
                drResult = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

                Select Case drResult("trxCode").ToString
                    Case "Y"
                        If ChkErr = False Then
                            MsgBoxLocalized(drResult("trxMsg"))
                        Else
                            Return ""
                        End If
                    Case "N1"
                        MsgBoxLocalized(drResult("trxMsg"))
                    Case Else
                        If ChkErr = False Then
                            Throw New Exception(Func.Msg(Me, "{0} error has occurred, so we excluded it!", drResult("TrxStr").ToString))
                        Else
                            Return drResult("TrxStr").ToString
                        End If

                End Select
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBoxLocalized(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try


        Return ""
    End Function
    Private Sub SetApplyType()
        Dim dt As New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")

        For i As Integer = 0 To GV1.Columns.Count - 1
            If GV1.Columns(i).Visible = True AndAlso GV1.Columns(i).ReadOnly = False AndAlso GV1.Columns(i).FieldName <> "CHK" AndAlso GV1.Columns(i).FieldName <> "CRM_CD" AndAlso GV1.Columns(i).FieldName <> "DOMAIN" Then
                dt.Rows.Add()
                dt(dt.Rows.Count - 1)("CODE") = GV1.Columns(i).FieldName
                dt(dt.Rows.Count - 1)("NAME") = GV1.Columns(i).Caption
            End If
        Next

        Apply_Type.DataSource = dt
        Apply_Type.DefVal = "APV_YN"
        Apply_Type.SelectedValue = "APV_YN"
    End Sub
#End Region
#Region "=================Client Function==========="
    Public Sub PopUpOnAfterClick(ByVal dr As DataRow)
        Dim Key As String = dr("Key")

        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing
        Select Case dr("Sender").ToString
            Case "WG1"
                If fTarget IsNot Nothing Then
                    For i As Integer = 0 To GV1.RowCount - 1
                        If GV1.GetRowCellValue(i, "CHK").ToString = "Y" Then
                            GV1.GetDataRow(i).AcceptChanges()
                            GV1.GetDataRow(i).SetAdded()
                        Else
                            GV1.GetDataRow(i).AcceptChanges()
                        End If
                    Next

                    Dim dt As DataTable = Me.ConvertToDataset.Tables("WG1")
                    For Each dr In dt.Rows
                        If dr("CHK").ToString = "N" Then
                            dt.Rows.Remove(dr)
                        End If
                    Next
                    fTarget.ClearView()
                    fTarget.showDialog()
                End If

                Select Case Key
                    Case "GV1_SelectAll"
                        Call SelectAll()
                End Select
        End Select
    End Sub
    Private Sub SelectAll()
        Dim checkYn As String = GV1.GetRowCellValue(0, "CHK").ToString
        SelectAllYn = True
        For i As Integer = 0 To GV1.RowCount - 1
            If checkYn = "Y" Then
                GV1.SetRowCellValue(i, "CHK", "N")
            Else
                GV1.SetRowCellValue(i, "CHK", "Y")
            End If
        Next
    End Sub
    Public Sub PopUpInit()
        Dim PopUp As New PopupBase
        PopUp.ItemAdd(Action.Other, "Selectdata", "Select identical data")
        PopUp.ItemAdd(Action.EventKey, "GV1_SelectAll", "&Select All")
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", "&Export Excel", True)
        PopUp.PopUpInit(Me, WG1)

        Call SetApplyType()
    End Sub
    Private Sub InitGrid()
        Call DrawRowIndicator({GV1})

        Dim editorCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "R06")
        dataParams.Add("NameType", "A")
        editorCombo.ShowHeader = False
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        editorCombo.ForceInitialize() : editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        GV1.Columns("APV_YN").ColumnEdit = editorCombo
        AddHandler editorCombo.EditValueChanged, AddressOf SetEditValueChanged

        GV1.Columns("CRM_CD").ColumnEdit = GridFunc.GetRepositoryItemCodeBoxEdit("Customer", "Type:''", "Code:#CRM_CD,DOMAIN:#DOMAIN", "KEY:#CRM_CD")
    End Sub
    Private Sub SetEditValueChanged(sender As Object, e As System.EventArgs)
        Dim iFocusedRowHandle As Integer = GV1.FocusedRowHandle
        GV1.FocusedRowHandle = -1
        GV1.FocusedRowHandle = iFocusedRowHandle
    End Sub
    '엑셀 출력
    Private Sub GridToExcel(ByVal obj As YJIT.SC.UI.SCControls.WebGrid)
        Common.ExportToExcel(obj)
    End Sub
    'Private Function validateEmail(emailAddress) As Boolean

    '    Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
    '    If email.IsMatch(emailAddress) Then
    '        '통과
    '        Return True
    '    Else
    '        MsgBoxLocalized("Please enter it in email format!") '이메일형식으로 입력해주세요!
    '        GV1.SetRowCellValue(GV1.FocusedRowHandle, "CHK_DUP", "Y")
    '        GV1.FocusedColumn = GV1.Columns("EMAIL")
    '        Return False
    '        Exit Function
    '    End If

    'End Function
#End Region
#Region "=================Control Events==========="
    'Client Function : 클라이언트 동작 함수
    Private Sub CrmFriendAprMgt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClearView()
        Call SetMandatoryLine(Me)
        Call SearchData()
    End Sub
    Private Sub CrmFriendAprMgt_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Call PopUpInit()
        Call InitGrid()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Call DownloadFile()
    End Sub
    Private Sub btnExpFwg1_Click(sender As Object, e As EventArgs) Handles btnExpFwg1.Click
        Call GridToExcel(WG1)
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call ClearView()
    End Sub
    Public Sub SearchFromMsg(ByVal key1 As String, ByVal key2 As String, ByVal key3 As String, ByVal key4 As String, ByVal key5 As String)
        S_USR_NM.Text = key1
        Call SearchData()
    End Sub
    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Dim chk As String = "N"
        For i As Integer = 0 To GV1.RowCount - 1
            If GV1.GetRowCellValue(i, "CHK").ToString = "Y" Then
                chk = "Y"
                Exit For
            End If
        Next

        If chk = "Y" Then
            For i As Integer = 0 To GV1.RowCount - 1
                If GV1.GetRowCellValue(i, "CHK").ToString = "Y" Then
                    GV1.FocusedRowHandle = i

                    Select Case Apply_Type.SelectedValue.ToString
                        Case "APV_YN"
                            GV1.SetRowCellValue(i, Apply_Type.SelectedValue.ToString, Apply_Status.SelectedValue.ToString)
                        Case "EMAIL_MSG"
                            If GV1.GetRowCellValue(i, "APV_YN").ToString = "D" Or GV1.GetRowCellValue(i, "APV_YN").ToString = "S" Then
                                GV1.SetRowCellValue(i, Apply_Type.SelectedValue.ToString, Apply_Text.Text)
                            End If
                    End Select
                End If
            Next
            GV1.RefreshData()
        Else
            MsgBoxLocalized("Nothing is selected. Select and reapply.")
        End If
    End Sub

    Private Sub GV1_ShownEditor(sender As Object, e As EventArgs) Handles GV1.ShownEditor
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)

        Select Case GV1.FocusedColumn.FieldName
            Case "APV_YN"
                Dim edit As DevExpress.XtraEditors.LookUpEdit
                Dim table As DataTable
                Dim clone As DataView
                Dim row As DataRow
                edit = CType(view.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
                table = CType(edit.Properties.DataSource, DataTable)
                clone = New DataView(table)
                row = view.GetDataRow(view.FocusedRowHandle)
                clone.RowFilter = "[CODE] <> 'N' "
                edit.Properties.DataSource = clone
        End Select
    End Sub
    Private Sub GV1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV1.CellValueChanged
        Select Case e.Column.FieldName
            Case "APV_YN"
                If GV1.GetRowCellValue(GV1.FocusedRowHandle, "APV_YN").ToString <> "D" Then GV1.SetRowCellValue(GV1.FocusedRowHandle, "EMAIL_MSG", "")
                If GV1.GetRowCellValue(GV1.FocusedRowHandle, "APV_YN").ToString = "Y" And GV1.GetRowCellValue(GV1.FocusedRowHandle, "APV_YN").ToString <> GV1.GetRowCellValue(GV1.FocusedRowHandle, "DB_APV_YN").ToString Then GV1.SetRowCellValue(GV1.FocusedRowHandle, "AUTH_KEY",
                Func.encryptAES256_FRND(String.Format("{0}|{1}|{2}|{3}|{4}", GV1.GetRowCellValue(GV1.FocusedRowHandle, "MNGT_NO").ToString, GV1.GetRowCellValue(GV1.FocusedRowHandle, "USR_ID").ToString,
                                       GV1.GetRowCellValue(GV1.FocusedRowHandle, "CRN").ToString, GV1.GetRowCellValue(GV1.FocusedRowHandle, "AUTH_STRT_YMD").ToString, GV1.GetRowCellValue(GV1.FocusedRowHandle, "AUTH_END_YMD").ToString)))

        End Select
    End Sub
    Private Sub SetGridEmainMsgAllowEdit()
        If GV1.RowCount <= 0 Then Exit Sub

        Select Case GV1.FocusedColumn.FieldName
            Case "EMAIL_MSG"
                If GV1.GetRowCellValue(GV1.FocusedRowHandle, "APV_YN").ToString = "D" Then '거절
                    GV1.FocusedColumn.OptionsColumn.AllowEdit = True
                    GV1.FocusedColumn.OptionsColumn.ReadOnly = False
                Else
                    GV1.FocusedColumn.OptionsColumn.AllowEdit = False
                    GV1.FocusedColumn.OptionsColumn.ReadOnly = True
                End If
        End Select
    End Sub
    Private Sub GV1_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GV1.ShowingEditor
        Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = sender
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView
        view = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim dr As DataRow = GV1.GetDataRow(GV1.FocusedRowHandle)

        Select Case gv.FocusedColumn.FieldName
            Case "EMAIL_MSG"
                If gv.GetRowCellValue(gv.FocusedRowHandle, "APV_YN").ToString = "D" Or gv.GetRowCellValue(gv.FocusedRowHandle, "APV_YN").ToString = "S" Then
                    '입력가능. 
                Else
                    e.Cancel = True
                End If
        End Select
    End Sub
    Private Sub GV1_RowClick(sender As Object, e As RowClickEventArgs) Handles GV1.RowClick
        Try
            If GV1.FocusedColumn.FieldName = "CHK" Then
                If GV1.GetRowCellValue(GV1.FocusedRowHandle, "CHK").ToString = "N" Then
                    GV1.SetRowCellValue(e.RowHandle, "CHK", "Y")
                Else
                    GV1.SetRowCellValue(e.RowHandle, "CHK", "N")
                End If
            End If
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Sub Apply_Type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Apply_Type.SelectedIndexChanged
        If Apply_Type.SelectedIndex < 0 Then Exit Sub

        Select Case Apply_Type.SelectedValue.ToString

            Case "APV_YN"
                Apply_Status.SelectedValue = "Y"

                Dim DT As DataTable = Apply_Status.DataSource
                If DT Is Nothing Then Exit Sub

                If DT.Rows.Count > 0 Then
                    For I = DT.Rows.Count - 1 To 0 Step -1
                        If DT.Rows(I)("CODE") = "N" Or DT.Rows(I)("CODE") = "" Then
                            DT.Rows.RemoveAt(I)
                        End If
                    Next
                End If

                Combo_Panel.Visible = True
                Text_Panel.Visible = False

                Me.Combo_Panel.Location = New System.Drawing.Point(180, 3)
                Me.btnApply.Left = Combo_Panel.Left + Combo_Panel.Width

            Case "EMAIL_MSG"
                Apply_Text.Text = ""

                Combo_Panel.Visible = False
                Text_Panel.Visible = True

                Me.Text_Panel.Location = New System.Drawing.Point(180, 3)

                Me.btnApply.Left = Text_Panel.Left + Text_Panel.Width
        End Select
    End Sub
    Private Sub GV1_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles GV1.RowCellStyle
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        If GV1.GetRowCellValue(e.RowHandle, "APV_YN").ToString <> GV1.GetRowCellValue(e.RowHandle, "DB_APV_YN").ToString Then
            e.Appearance.BackColor = System.Drawing.Color.LightSalmon
        End If
        If view.GetRowCellValue(e.RowHandle, "APV_YN").ToString = "N" Then
            e.Appearance.BackColor = System.Drawing.Color.LightGray
        ElseIf view.GetRowCellValue(e.RowHandle, "APV_YN").ToString = "D" Then
            e.Appearance.BackColor = System.Drawing.Color.DarkSalmon
        End If

        ''이메일 형식 잘못되었거나, 중복된것을 빨간색
        'If view.GetRowCellValue(e.RowHandle, "CHK_DUP").ToString = "Y" Then
        '    e.Appearance.BackColor = System.Drawing.Color.OrangeRed
        'End If
    End Sub

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs)
        Call CreateUserData()
    End Sub

    Private Sub CreateUserData()
        '엘비스계정명 변경자료만 서버로 전송
        Dim dtSave As DataTable = CType(WG1.DataSource, DataTable).Clone
        dtSave.TableName = "WG1"
        For i = 0 To CType(WG1.DataSource, DataTable).Rows.Count - 1
            If GV1.GetDataRow(i)("ELVIS_ID").ToString.ToUpper <> GV1.GetDataRow(i)("DB_ELVIS_ID").ToString.ToUpper Then
                dtSave.ImportRow(GV1.GetDataRow(i))
            End If
        Next
        If dtSave.Rows.Count = 0 Then
            MsgBoxLocalized("엘비스계정명이 수정된 자료가 없습니다. ")
            Exit Sub
        End If

        If MsgBoxLocalized("엘비스 계정을 생성하시겠습니까?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then Exit Sub

        Dim ds As DataSet = New DataSet
        ds.Tables.Add(dtSave)
        Dim SearchDs As DataSet = GetConvertToDataSet("Search")
        ds.Merge(SearchDs)
        Try
            Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", "엘비스 계정 생성중 입니다. 잠시만 기다려 주세요.")
                ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmFriendAprMgt", "CreateUser", {ds})
            End Using
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        Select Case dr("TrxCode").ToString
            Case "Y"
                MsgBoxLocalized(dr("TrxMsg"))
                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(dr("TrxMsg"))
        End Select
    End Sub
    Private Sub DownloadFile()
        Dim ds As DataSet = New DataSet

        For i As Integer = 0 To GV1.RowCount - 1
            If GV1.GetRowCellValue(i, "CHK") = "Y" Then
                If GV1.GetRowCellValue(i, "APV_YN").ToString = "N" Then
                    If MsgBoxLocalized("승인 후, 출력해주세요.", MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Warning) Then
                        Exit Sub
                    End If
                End If
            End If
        Next

        Try
            Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", "파일 다운로드 중 입니다. 잠시만 기다려 주세요.")
                ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmFriendAprMgt", "FileDownload", {GV1.GetFocusedRowCellValue("MNGT_NO").ToString, GV1.GetFocusedRowCellValue("USR_ID").ToString, GV1.GetFocusedRowCellValue("AUTH_KEY").ToString})
            End Using
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        Select Case dr("TrxCode").ToString
            Case "Y"
                If ds.Tables("data.Table1").Rows.Count = 0 Then MsgBoxLocalized(dr("TrxMsg"))

                Dim retD As New Dictionary(Of String, String)
                If Not String.IsNullOrEmpty(ds.Tables("data.Table1").Rows(0)("FILE_PATH").ToString) Then
                    Dim downloadurl As String = "http://apifriend.yjit.co.kr" & ds.Tables("data.Table1").Rows(0)("FILE_PATH").ToString
                    Dim FileName() As String = ds.Tables("data.Table1").Rows(0)("FILE_PATH").ToString.Split("/")
                    Dim targetfile As String = tempFolder & "\" & FileName(FileName.Count - 1)

                    If Not IO.Directory.Exists(tempFolder) Then
                        IO.Directory.CreateDirectory(tempFolder)
                    End If

                    If IO.File.Exists(targetfile) Then
                        IO.File.Delete(targetfile)
                    End If

                    My.Computer.Network.DownloadFile(downloadurl, targetfile)

                    Microsoft.VisualBasic.Shell("explorer " & targetfile, AppWinStyle.NormalFocus)
                    Me.DataState = UI.DataStates.Retrieved

                End If
            Case Else
                MsgBoxLocalized(dr("TrxMsg"))
        End Select
    End Sub
#End Region
End Class
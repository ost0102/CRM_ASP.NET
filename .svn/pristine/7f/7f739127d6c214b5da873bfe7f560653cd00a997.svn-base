Imports YJIT.SC.UI


Public Class CrmAsEvent
#Region "=================GetConvertToDataset Function==========="
    Private Function GetConvertToDataSet(ByVal SearchType As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim IsSingleSearch As Boolean = False

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)

            Select Case SearchType.ToString.ToUpper
                Case "Search".ToUpper
                    YJSql.SqlBox("WG1", "CrmAsEvent@Search", True)
                    If drMAIN("S_DATE_TYPE").ToString = "R" Then
                        YJSql.Blocks("REQ_YMD", "TRUE")
                    ElseIf drMAIN("S_DATE_TYPE").ToString = "C" Then
                        YJSql.Blocks("CMPT_YMD", "TRUE")
                    Else
                        YJSql.Blocks("REQ_YMD", "TRUE")
                    End If '요청일자 / 완료일자 비교

                    YJSql.Params("FM_YMD", drMAIN("S_FM_YMD").ToString)
                    YJSql.Params("TO_YMD", drMAIN("S_TO_YMD").ToString)
                    YJSql.Params("TO_YMD", drMAIN("S_TO_YMD").ToString)
                    YJSql.Params("PROC_TYPE", S_PROC_TYPE.EditValue.ToString.Replace(";", "','").Replace(" ", "")) '상태
                    YJSql.Params("REQ_SVC", REQ_SVC.SelectedValue.ToString) '업무구분1
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
    Private Sub SearchData()
        Try
            If SearchValidate() = False Then Exit Sub

            Dim dsRet As DataSet = GetConvertToDataSet("Search")

            dsRet = MethodCallEx(Me, "YJIT.Biz.CrmAsEvent", "Search", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Call ClearView(AppliedRangeTypes.Only, {WG1})
                    Me.BindToDataset(dsRet, "Data")
                    Me.DataState = UI.DataStates.Retrieved

                Case "N"
                    Call ClearView(AppliedRangeTypes.Only, {WG1})
                    MsgBoxLocalized(drPairs("TrxMsg"))
                    Me.DataState = UI.DataStates.Retrieved
                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
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
                ErrMsg &= "등록일자 시작일은 필수 입니다." & vbNewLine
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
    Private Sub ApplyData()
        Try
            For Each row As DataRow In CType(WG1.DataSource, DataTable).Rows
                If row("CHK").ToString = "Y" Then
                    If RMK.Text <> "" Then
                        row("RMK") = RMK.Text
                    End If
                    If CMPT_RMK.Text <> "" Then
                        row("CMPT_RMK") = CMPT_RMK.Text
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Public Sub SaveData()
        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then Exit Sub

        '상태가 체크된 것만 서버로 가게 수정
        Dim dt As DataTable = CType(WG1.DataSource, DataTable)

        For i As Integer = 0 To dt.Rows.Count - 1
            dt(i).AcceptChanges()
            If dt(i)("CHK").ToString = "Y" Then
                dt(i).SetModified()
            End If
        Next

        Dim ds As DataSet = Me.ConvertToDataset
        If ds.Tables("WG1").Rows.Count = 0 Then
            MsgBoxLocalized("Data is empty!")
            Exit Sub
        End If

        Try
            ds = MethodCallEx(Me, "YJIT.Biz.CrmAsEvent", "Save", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") = "Y" Then
            Me.BindToDataset(ds, "Data")
            '20210805 정지수 일괄적용 후 저장 시 초기화되지 않도록 수정 YJITS2021080124
            'Call ClearView(AppliedRangeTypes.Only, {RMK, CMPT_RMK})
            Me.DataState = UI.DataStates.Retrieved
        End If

        MsgBoxLocalized(dr("TrxMsg"))
    End Sub
    Private Sub InitData()
        Dim searchParams = New Dictionary(Of String, Object)
        Dim dataParams = New Dictionary(Of String, Object)
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

        Common.DrawRowIndicator({GV1})

        Dim editorCombo As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim editor As New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)
        Dim dt As DataTable = New DataTable
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
    End Sub
    Public Sub PopUpInit()
        Dim PopUp As New PopupBase
        PopUp.ItemAdd(Action.Other, "SelectAll", "&Select All", True)
        PopUp.PopUpInit(Me, WG1)
    End Sub
    Public Sub PopUpOnAfterClick(ByVal Dr As DataRow)
        Dim Key As String = Dr("Key")
        Dim Sender As String = ""

        Select Case Dr("Action")
            Case Action.Other
                Select Case Key
                    Case "SelectAll"
                        If GV1.GetRowCellValue(0, "CHK").ToString = "N" Then
                            For i As Integer = 0 To GV1.RowCount - 1
                                GV1.SetRowCellValue(i, "CHK", "Y")
                            Next
                        Else
                            For i As Integer = 0 To GV1.RowCount - 1
                                GV1.SetRowCellValue(i, "CHK", "N")
                            Next
                        End If
                End Select
        End Select
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

        Select Case ClientSessionInfo.OrganizationCode
            Case "02"
                REQ_SVC.SelectedValue = "E"
            Case "05"
                REQ_SVC.SelectedValue = "C"
            Case "07"
                REQ_SVC.SelectedValue = "M"
            Case Else
                REQ_SVC.SelectedValue = "B"
        End Select
    End Sub
#End Region

#Region "=================Control Events==========="
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchData()
    End Sub
    Private Sub CrmAsEvent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitData()
        Call GridInit()
        'MsgBox(Now)
        'MsgBox(Now.ToString("yyyyMMdd"))
        'MsgBox(DateAdd(DateInterval.Day, -7, Now).ToString("yyyyMMdd"))

        S_FM_YMD.Text = DateAdd(DateInterval.Day, -7, Now).ToString("yyyyMMdd")
        S_FM_YMD.Focus()
    End Sub
    Private Sub CrmAsEvent_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Call PopUpInit()
        '상태값 미확인, 처리중 체크 되게 수정
        S_PROC_TYPE.EditValue = "0;7"

        Call SetReqSvc()

    End Sub
    Private Sub S_PROC_TYPE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles S_PROC_TYPE.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            e.KeyChar = String.Empty
            btnSearch.Focus()
        End If
    End Sub
    Private Sub SaveEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveEvent.Click
        ApplyData()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SaveData()
    End Sub
#End Region


End Class
Public Class MdmCommonMgt

#Region "=================Data logic actions==========="

    Dim SearchFlag As Boolean = False

    Public Sub SearchData()
        ClearView(AppliedRangeTypes.Only, {WG1, WG2, WG3})

        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.MdmCommonMgt", "Search", Me.ConvertToDataset, AddressOf Search_OnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub

    Public Sub Search_OnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Try
            If IsNothing(e.Result) Then
                Throw New Exception("Try Again!")
            End If
            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg"))
                ClearView(AppliedRangeTypes.Only, {WG2, WG3})
                Exit Sub
            End If
            Me.BindToDataset(ds, "Data")
            Me.DataState = UI.DataStates.Retrieved

            SearchFlag = False
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Public Sub SearchCommonCode()

        Dim GRP_CD As String = ""

        If IsDBNull(GV1.GetRowCellValue(GV1.FocusedRowHandle, "GRP_CD")) Then
            GRP_CD = ""
        Else
            GRP_CD = Trim(GV1.GetRowCellValue(GV1.FocusedRowHandle, "GRP_CD"))
        End If


        Dim param() As Object = {GRP_CD}
        Try
            SearchFlag = True
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.MdmCommonMgt", "SearchCommonCode", param, AddressOf SearchCommonCode_OnComplete)
        Catch ex As Exception
            SearchFlag = False
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Public Sub SearchCommonCode_OnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Try
            If IsNothing(e.Result) Then
                Throw New Exception("Try Again!")
            End If
            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg"))
                ClearView(AppliedRangeTypes.Only, {WG2, WG3})
                Exit Sub
            End If
            Me.BindToDataset(ds, "Data")
            Me.DataState = UI.DataStates.Retrieved

            GV2.BestFitColumns()

            If ds.Tables("Data.WG2").Rows.Count = 0 Then
                ClearView(AppliedRangeTypes.Only, {WG3})
            End If
            SearchFlag = False
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Public Sub SearchLocalLanguage()
        Dim REQ_CD As String = ""
        Dim ITEM_CD As String = ""
        If IsDBNull(GV2.GetRowCellValue(GV2.FocusedRowHandle, "COMN_CD")) Then
            REQ_CD = ""
        Else
            REQ_CD = Trim(GV2.GetRowCellValue(GV2.FocusedRowHandle, "COMN_CD"))
        End If
        If IsDBNull(GV2.GetRowCellValue(GV2.FocusedRowHandle, "GRP_CD")) Then
            ITEM_CD = ""
        Else
            ITEM_CD = Trim(GV2.GetRowCellValue(GV2.FocusedRowHandle, "GRP_CD"))
        End If
        Dim params() As Object = {REQ_CD, ITEM_CD}
        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.MdmCommonMgt", "SearchLocalLanguage", params, AddressOf SearchLocalLanguage_OnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Public Sub SearchLocalLanguage_OnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Try
            If IsNothing(e.Result) Then
                Throw New Exception("Try Again!")
            End If
            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg"))
                ClearView(AppliedRangeTypes.Only, {WG2, WG3})
                Exit Sub
            End If
            Me.BindToDataset(ds, "Data")
            Me.DataState = UI.DataStates.Retrieved
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Public Sub SaveData()
        If MandatoryGridValue("GV2") Then Exit Sub
        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then Exit Sub
        Dim ds As DataSet = Me.ConvertToDataset()
        For i As Integer = 0 To ds.Tables("WG1").Rows.Count - 1
            If ds.Tables("WG1").Rows(i)("_INSFLAG") <> "D" Then
                If ds.Tables("WG1").Rows(i)("GRP_CD") & "" = "" Then
                    MsgBoxLocalized("Please input Group Code.")
                    GV1.FocusedRowHandle = i
                    GV1.FocusedColumn = GV1.Columns("GRP_CD")
                    GV1.ShowEditor()
                    Exit Sub
                End If
            End If
        Next
        For i As Integer = 0 To ds.Tables("WG2").Rows.Count - 1
            If ds.Tables("WG2").Rows(i)("_INSFLAG") <> "D" Then
                If ds.Tables("WG2").Rows(i)("GRP_CD") & "" = "" Then
                    MsgBoxLocalized("Please input Group Code.")
                    GV2.FocusedRowHandle = i
                    GV2.FocusedColumn = GV2.Columns("GRP_CD")
                    GV2.ShowEditor()
                End If
                If ds.Tables("WG2").Rows(i)("COMN_CD") & "" = "" Then
                    MsgBoxLocalized("Please input Code.")
                    GV2.FocusedRowHandle = i
                    GV2.FocusedColumn = GV2.Columns("COMN_CD")
                    GV2.ShowEditor()
                End If
            End If
        Next
        For i As Integer = 0 To ds.Tables("WG3").Rows.Count - 1
            If ds.Tables("WG3").Rows(i)("_INSFLAG") <> "D" Then
                If ds.Tables("WG3").Rows(i)("LANG_CD") & "" = "" Then
                    MsgBoxLocalized("Please input Language.")
                    GV3.FocusedRowHandle = i
                    GV3.FocusedColumn = GV3.Columns("LANG_CD")
                    GV3.ShowEditor()
                    Exit Sub
                End If
            End If
        Next
        Dim dsRet As DataSet
        Try
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MdmCommonMgt", "Save", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
        Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") <> "Y" Then
            Select Case dr("TrxCode")
                Case "N"
                Case "E"
                    Me.BindToDataset(dsRet, "Data")
                    Me.DataState = UI.DataStates.Retrieved
            End Select
            MsgBoxLocalized(dr("TrxMsg"))
        Else
            Me.BindToDataset(dsRet, "Data")
            MsgBoxLocalized(dr("TrxMsg"))
        End If
        Me.DataState = UI.DataStates.Retrieved
        Call SearchData()
    End Sub

#End Region

#Region "=================Control Events==========="
    Private Sub MdmCommonMgt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call DrawRowIndicator({GV1, GV2, GV3})
        Call InitGrid()
        Call SearchData()
    End Sub
    Private Sub MdmCommonMgt_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Call PopupInit()
    End Sub
    Public Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub
    Private Sub GV1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV1.FocusedRowChanged


        If GV1.GetFocusedDataSourceRowIndex() >= 0 Then
            If Not IsNothing(GV1.GetFocusedDataRow().RowState) Then
                If GV1.GetFocusedDataRow().RowState = DataRowState.Added Then
                    Me.GV1_GRP_CD.OptionsColumn.AllowEdit = True
                    Me.GV1_GRP_CD.OptionsColumn.ReadOnly = False
                Else
                    Me.GV1_GRP_CD.OptionsColumn.AllowEdit = False
                    Me.GV1_GRP_CD.OptionsColumn.ReadOnly = True
                End If
            End If
        End If

        If GV1.GetRowCellValue(GV1.FocusedRowHandle, "NAME_TITLE") & "" = "" Then
            GV2.Columns("CD_NM").Caption = "Code Title"
        Else
            GV2.Columns("CD_NM").Caption = GV1.GetRowCellValue(GV1.FocusedRowHandle, "NAME_TITLE") & ""
        End If
        If GV1.GetRowCellValue(GV1.FocusedRowHandle, "TITLE1") & "" = "" Then
            GV2.Columns("OPT_ITEM1").Caption = "Title1"
        Else
            GV2.Columns("OPT_ITEM1").Caption = GV1.GetRowCellValue(GV1.FocusedRowHandle, "TITLE1") & ""
        End If
        If GV1.GetRowCellValue(GV1.FocusedRowHandle, "TITLE2") & "" = "" Then
            GV2.Columns("OPT_ITEM2").Caption = "Title2"
        Else
            GV2.Columns("OPT_ITEM2").Caption = GV1.GetRowCellValue(GV1.FocusedRowHandle, "TITLE2") & ""
        End If
        If GV1.GetRowCellValue(GV1.FocusedRowHandle, "TITLE3") & "" = "" Then
            GV2.Columns("OPT_ITEM3").Caption = "Title3"
        Else
            GV2.Columns("OPT_ITEM3").Caption = GV1.GetRowCellValue(GV1.FocusedRowHandle, "TITLE3") & ""
        End If
        If GV1.GetRowCellValue(GV1.FocusedRowHandle, "TITLE4") & "" = "" Then
            GV2.Columns("OPT_ITEM4").Caption = "Title4"
        Else
            GV2.Columns("OPT_ITEM4").Caption = GV1.GetRowCellValue(GV1.FocusedRowHandle, "TITLE4") & ""
        End If
        If GV1.GetRowCellValue(GV1.FocusedRowHandle, "TITLE5") & "" = "" Then
            GV2.Columns("OPT_ITEM5").Caption = "Title5"
        Else
            GV2.Columns("OPT_ITEM5").Caption = GV1.GetRowCellValue(GV1.FocusedRowHandle, "TITLE5") & ""
        End If
        If GV1.GetRowCellValue(GV1.FocusedRowHandle, "TITLE6") & "" = "" Then
            GV2.Columns("OPT_ITEM6").Caption = "Title6"
        Else
            GV2.Columns("OPT_ITEM6").Caption = GV1.GetRowCellValue(GV1.FocusedRowHandle, "TITLE6") & ""
        End If
        If GV1.GetRowCellValue(GV1.FocusedRowHandle, "TITLE7") & "" = "" Then
            GV2.Columns("OPT_ITEM7").Caption = "Title7"
        Else
            GV2.Columns("OPT_ITEM7").Caption = GV1.GetRowCellValue(GV1.FocusedRowHandle, "TITLE7") & ""
        End If
        If GV1.GetRowCellValue(GV1.FocusedRowHandle, "TITLE8") & "" = "" Then
            GV2.Columns("OPT_ITEM8").Caption = "Title8"
        Else
            GV2.Columns("OPT_ITEM8").Caption = GV1.GetRowCellValue(GV1.FocusedRowHandle, "TITLE8") & ""
        End If
        If GV1.GetRowCellValue(GV1.FocusedRowHandle, "TITLE9") & "" = "" Then
            GV2.Columns("OPT_ITEM9").Caption = "Title9"
        Else
            GV2.Columns("OPT_ITEM9").Caption = GV1.GetRowCellValue(GV1.FocusedRowHandle, "TITLE9") & ""
        End If
        If GV1.GetRowCellValue(GV1.FocusedRowHandle, "TITLE10") & "" = "" Then
            GV2.Columns("OPT_ITEM10").Caption = "Title10"
        Else
            GV2.Columns("OPT_ITEM10").Caption = GV1.GetRowCellValue(GV1.FocusedRowHandle, "TITLE10") & ""
        End If


        Call SearchCommonCode()
    End Sub
    Private Sub GV2_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV2.FocusedRowChanged
        If GV2.GetFocusedDataSourceRowIndex() >= 0 Then
            If Not IsNothing(GV2.GetFocusedDataRow().RowState) Then
                If GV2.GetFocusedDataRow().RowState = DataRowState.Added Then
                    Me.GV2_COMN_CD.OptionsColumn.AllowEdit = True
                    Me.GV2_COMN_CD.OptionsColumn.ReadOnly = False
                Else
                    Me.GV2_COMN_CD.OptionsColumn.AllowEdit = False
                    Me.GV2_COMN_CD.OptionsColumn.ReadOnly = True
                End If
            End If
        End If
        If SearchFlag = True Then
            Exit Sub
        End If
        Call SearchLocalLanguage()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub
    Public Sub PopupInit()
        Dim itemCaption() = {"&Add Row", "&Delete Row", "&Export Excel"}
        'Group List
        Dim PopUp As New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG1_AddRow", itemCaption(0))
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", itemCaption(2))
        PopUp.PopUpInit(Me, WG1, "GRP_CD", "TITLE10")
        'Common Code
        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG2_AddRow", itemCaption(0))
        PopUp.ItemAdd(Action.DeleteRow, "WG2_DelRow", itemCaption(1))
        PopUp.ItemAdd(Action.Other, "WG2_SaveRow", "&Save Row")
        PopUp.ItemAdd(Action.Excel, "WG2_Excel", itemCaption(2), True)
        PopUp.PopUpInit(Me, WG2, "GRP_CD", "OPT_ITEM10")
        'Local Language
        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG3_AddRow", itemCaption(0))
        PopUp.ItemAdd(Action.DeleteRow, "WG3_DelRow", itemCaption(1))
        PopUp.ItemAdd(Action.Other, "WG3_SaveRow", "&Save Row")
        PopUp.ItemAdd(Action.Excel, "WG3_Excel", itemCaption(2), True)
        PopUp.PopUpInit(Me, WG3, "ITEM_CD", "LOC_NM")
    End Sub
    Public Sub PopUpOnAfterClick(ByVal dr As DataRow)
        Dim Key As String = dr("Key")
        Dim Sender As String = ""
        If Not dr("Sender") Is System.DBNull.Value Then Sender = dr("Sender")
        '화면 내에 여러 이벤트가 있을경우 case 문으로 Action 분계

        Select Case dr("Action")
            Case Action.Addrow, Action.EventKey
                Select Case Sender
                    Case "WG2"
                        GV2.SetRowCellValue(GV2.FocusedRowHandle, "GRP_CD", GV1.GetRowCellValue(GV1.FocusedRowHandle, "GRP_CD").ToString)
                        GV2.ShowEditor()
                    Case "WG3"
                        GV3.SetRowCellValue(GV3.FocusedRowHandle, "ITEM_CD", GV2.GetRowCellValue(GV2.FocusedRowHandle, "GRP_CD").ToString)
                        GV3.SetRowCellValue(GV3.FocusedRowHandle, "REQ_CD", GV2.GetRowCellValue(GV2.FocusedRowHandle, "COMN_CD").ToString)
                        GV3.ShowEditor()
                End Select
            Case Action.Other
                Select Case Key
                    Case "WG2_SaveRow"
                        Call SaveCodeDetail()
                    Case "WG3_SaveRow"
                        Call SaveCodeLanguage()
                End Select
        End Select
    End Sub
    Public Function MandatoryGridValue(ByVal gridView As String) As Boolean
        Dim Param As New Dictionary(Of String, Object)
        Dim checkNull() As String = Nothing

        Select Case gridView
            Case "GV2"
                checkNull = {"COMN_CD"}
                Param("COMN_CD") = GV2_COMN_CD.Caption

                Return ValidateGridValue(GV2, Param, checkNull)
            Case "GV3"
                checkNull = {"LOC_NM"}
                Param("LANG_CD") = GV3_LANG_CD.Caption
                Param("LOC_NM") = GV3_LOC_NM.Caption

                Return ValidateGridValue(GV3, Param, checkNull)
        End Select

        Return True

    End Function
    Private Sub SaveCodeDetail()

        If MandatoryGridValue("GV2") Then Exit Sub

        Dim ds As DataSet = Me.ConvertToDataset()

        Dim dsRet As DataSet
        Try
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MdmCommonMgt", "SaveCodeDetail", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
        Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") <> "Y" Then
            Select Case dr("TrxCode")
                Case "N"
                Case "E"
                    Me.DataState = UI.DataStates.Retrieved
            End Select
            MsgBoxLocalized(dr("TrxMsg"))
        Else
            MsgBoxLocalized(dr("TrxMsg"))

            Call SearchCommonCode()
        End If
        Me.DataState = UI.DataStates.Retrieved
    End Sub
    Private Sub SaveCodeLanguage()

        If MandatoryGridValue("GV3") Then Exit Sub

        Dim ds As DataSet = Me.ConvertToDataset()

        Dim dsRet As DataSet
        Try
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MdmCommonMgt", "SaveCodeLanguage", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
        Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") <> "Y" Then
            Select Case dr("TrxCode")
                Case "N"
                Case "E"
                    Me.DataState = UI.DataStates.Retrieved
            End Select
            MsgBoxLocalized(dr("TrxMsg"))
        Else
            MsgBoxLocalized(dr("TrxMsg"))
            Call SearchLocalLanguage()

        End If
        Me.DataState = UI.DataStates.Retrieved
    End Sub

    Private Sub InitGrid()
        If ClientSessionInfo.AuthorizationType <> "0" Then
            GV1_MNGT_AUTH_LVL.Visible = False
        End If

        Dim editorCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim LookUp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim dt As New DataTable

        'Admin LookUpEdit
        dt = New DataTable
        dt.Columns.Add("YorN")
        dt.Rows.Add("Y")
        dt.Rows.Add("N")
        LookUp = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        LookUp.DisplayMember = "YorN"
        LookUp.ValueMember = "YorN"
        LookUp.NullText = "--Select--"
        LookUp.ShowHeader = False
        LookUp.ReadOnly = False
        LookUp.DataSource = dt
        GV1.Columns("MNGT_AUTH_LVL").ColumnEdit = LookUp

        ' Use 여부
        dt = New DataTable : dt.Columns.Add("CODE", GetType(String)) : dt.Columns.Add("NAME", GetType(String))
        dt.Rows.Add("Y", "Yes")
        dt.Rows.Add("N", "No")
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DataSource = dt
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        editorCombo.ShowHeader = False
        GV2.Columns("USE_YN").ColumnEdit = editorCombo

        'Language LookUpEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)
        LookUp = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        LookUp.DisplayMember = "NAME"
        LookUp.ValueMember = "CODE"
        LookUp.NullText = "--Select--"
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "S11")
        dataParams.Add("NameType", "")
        LookUp.ShowHeader = False
        LookUp.ReadOnly = False
        LookUp.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV3.Columns("LANG_CD").ColumnEdit = LookUp



    End Sub

    Private Sub Form_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        '181011/길윤성/예일글로벌 화면 닫을 때 저장여부 확인 메시지 표기
        If ClientSessionOfficeInfo.HqOfficeCode = "YLGLHQ" Then
            If MsgBoxLocalized("Do you want to close without saving changes?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

#End Region

#Region "=================Quick Button Events==========="
    Private Sub btnAddWg1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddWg1.Click
        Call AddGridRow(WG1)
    End Sub
    Private Sub btnExpWg1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpWg1.Click
        Call GridToExcel(WG1)
    End Sub
    Private Sub btnAddWg2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddWg2.Click
        Call AddGridRow(WG2)
    End Sub
    Private Sub btnDelWg2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelWg2.Click
        Call DelGridRow(WG2)
    End Sub
    Private Sub btnExpWg2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpWg2.Click
        Call GridToExcel(WG2)
    End Sub
    Private Sub btnAddWg3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddWg3.Click
        Call AddGridRow(WG3)
    End Sub
    Private Sub btnDelWg3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelWg3.Click
        Call DelGridRow(WG3)
    End Sub
    Private Sub btnExpWg3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpWg3.Click
        Call GridToExcel(WG3)
    End Sub
    Private Sub AddGridRow(ByVal obj As YJIT.SC.UI.SCControls.WebGrid)
        Dim GvAddRow As New DataTable
        Dim dr As DataRow

        If obj.Visible = False And obj.Enabled = False Then Exit Sub
        GvAddRow.Columns.Add("Key")
        GvAddRow.Columns.Add("Sender")
        GvAddRow.Columns.Add("Action", GetType(Action))
        GvAddRow.Rows.Add()
        dr = GvAddRow.Rows(0)
        dr("Sender") = obj.Name
        dr("Key") = obj.Name + "_AddRow"
        dr("Action") = Action.Addrow
        obj.AddRow()

        PopUpOnAfterClick(GvAddRow.Rows(0))

    End Sub


    Private Sub DelGridRow(ByVal obj As YJIT.SC.UI.SCControls.WebGrid)
        Dim GvDelRow As New DataTable
        Dim dr As DataRow

        If obj.Visible = False And obj.Enabled = False Then Exit Sub
        GvDelRow.Columns.Add("Key")
        GvDelRow.Columns.Add("Sender")
        GvDelRow.Columns.Add("Action", GetType(Action))
        GvDelRow.Rows.Add()
        dr = GvDelRow.Rows(0)
        dr("Sender") = obj.Name
        dr("Key") = obj.Name + "_DeleteRow"
        dr("Action") = Action.DeleteRow
        obj.DeleteRow()

        PopUpOnAfterClick(GvDelRow.Rows(0))

    End Sub

    Private Sub GridToExcel(ByVal obj As YJIT.SC.UI.SCControls.WebGrid)
        Common.ExportToExcel(obj)
    End Sub
#End Region
    
End Class
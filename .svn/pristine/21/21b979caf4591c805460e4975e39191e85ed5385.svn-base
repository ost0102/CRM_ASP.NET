Imports YJIT.SC.UI
Imports DevExpress.XtraGrid.Views.Base

Public Class CrmAsWeekly
    Dim SearchFlag As Boolean = False

#Region "=================GetConvertToDataset Function==========="
    Private Function GetConvertToDataSet(ByVal SearchType As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim IsSingleSearch As Boolean = False

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)

            Select Case SearchType.ToString.ToUpper
                Case "Search".ToUpper
                    Select Case xtcAnalysis.SelectedTabPage.Name
                        Case xtpHelp.Name
                            YJSql.SqlBox("WG01_PGC", "CrmAsWeekly@Search", True)
                            YJSql.Params("FM_YMD", drMAIN("S_FM_YMD").ToString)
                            YJSql.Params("TO_YMD", drMAIN("S_TO_YMD").ToString)
                            YJSql.Params("FM_YMD_PREV", drMAIN("S_FM_YMD_PREV").ToString)
                            YJSql.Params("TO_YMD_PREV", drMAIN("S_TO_YMD_PREV").ToString)
                            YJSql.Params("FM_YMD_NEXT", drMAIN("S_FM_YMD_NEXT").ToString)
                            YJSql.Params("TO_YMD_NEXT", drMAIN("S_TO_YMD_NEXT").ToString)
                            YJSql.Params("DEPT_CD", drMAIN("S_DEPT_CD").ToString)
                            YJSql.Params("PROJECT_CD", drMAIN("S_PROJECT_CD").ToString)
                            YJSql.Blocks("THIS_WEEK", "TRUE")
                        Case xtpDev.Name
                            YJSql.SqlBox("WG02", "CrmAsWeekly@SearchDev", True)
                            YJSql.Params("FM_YMD", drMAIN("S_FM_YMD").ToString)
                            YJSql.Params("TO_YMD", drMAIN("S_TO_YMD").ToString)
                            YJSql.Params("FM_YMD_NEXT", drMAIN("S_FM_YMD_NEXT").ToString)
                            YJSql.Params("TO_YMD_NEXT", drMAIN("S_TO_YMD_NEXT").ToString)
                            YJSql.Params("DEPT_CD", drMAIN("S_DEPT_CD").ToString)
                            YJSql.Params("PROJECT_CD", drMAIN("S_PROJECT_CD").ToString)
                            YJSql.Params("DEV_PIC_CD", S_DEV_PIC_LIST.EditValue.ToString.Replace(" ", "").Replace(";", "','"))

                            YJSql.SqlBox("WG02_CMPT_ALL", "CrmAsWeekly@SearchDevDetail", True)
                            YJSql.Params("FM_YMD", drMAIN("S_FM_YMD").ToString)
                            YJSql.Params("TO_YMD", drMAIN("S_TO_YMD").ToString)
                            YJSql.Params("FM_YMD_NEXT", drMAIN("S_FM_YMD_NEXT").ToString)
                            YJSql.Params("TO_YMD_NEXT", drMAIN("S_TO_YMD_NEXT").ToString)
                            YJSql.Params("DEPT_CD", drMAIN("S_DEPT_CD").ToString)
                            YJSql.Params("PROJECT_CD", drMAIN("S_PROJECT_CD").ToString)
                            YJSql.Blocks("CMPT_YMD", True)

                            YJSql.SqlBox("WG02_PRAR_ALL", "CrmAsWeekly@SearchDevDetail", True)
                            YJSql.Params("FM_YMD", drMAIN("S_FM_YMD").ToString)
                            YJSql.Params("TO_YMD", drMAIN("S_TO_YMD").ToString)
                            YJSql.Params("FM_YMD_NEXT", drMAIN("S_FM_YMD_NEXT").ToString)
                            YJSql.Params("TO_YMD_NEXT", drMAIN("S_TO_YMD_NEXT").ToString)
                            YJSql.Params("DEPT_CD", drMAIN("S_DEPT_CD").ToString)
                            YJSql.Params("PROJECT_CD", drMAIN("S_PROJECT_CD").ToString)
                            YJSql.Blocks("PRAR_YMD", True)
                        Case xtpSales.Name
                            '## 솔루션사업팀 자료
                            YJSql.SqlBox("WG04A", "CrmProjectMgt@SearchUserCnt", True)
                            YJSql.Params("FM_YMD", drMAIN("S_FM_YMD").ToString)
                            YJSql.Params("TO_YMD", drMAIN("S_TO_YMD").ToString)
                            YJSql.Params("DEPT_CD", drMAIN("S_DEPT_CD").ToString)

                            YJSql.SqlBox("WG04B", "CrmProjectMgt@SearchProcessCnt", True)
                            YJSql.Params("FM_YMD", drMAIN("S_FM_YMD").ToString)
                            YJSql.Params("TO_YMD", drMAIN("S_TO_YMD").ToString)
                            YJSql.Params("DEPT_CD", drMAIN("S_DEPT_CD").ToString)

                            YJSql.SqlBox("WG04C", "CrmProjectMgt@Search", True)
                            YJSql.Params("FM_YMD", drMAIN("S_FM_YMD").ToString)
                            YJSql.Params("TO_YMD", drMAIN("S_TO_YMD").ToString)
                            YJSql.Params("DEPT_CD", drMAIN("S_DEPT_CD").ToString)
                    End Select
                Case "CrmUserInfo".ToUpper
                    YJSql.SqlBox("CrmUserInfo", "CrmAsMgtDev@CrmUserInfo", True)
                Case Else
                    Throw New Exception("No match type found. (GetConvertToDataSet)")
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function
#End Region


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchData()
    End Sub

    Public Sub SearchData()
        Try
            If SearchFlag = True Then Exit Sub
            SearchFlag = True

            If SearchValidate() = False Then Exit Sub

            Dim dsRet As DataSet = GetConvertToDataSet("Search")

            dsRet = MethodCallEx(Me, "YJIT.Biz.CrmAsWeekly", "Search", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Call ClearView(AppliedRangeTypes.Only, {WG02, WG02_CMPT, WG02_CMPT_ALL, WG02_PRAR, WG02_PRAR_ALL, WG01_PGC})
                    Me.BindToDataset(dsRet, "Data")

                    '## 고객지원팀 자료
                    WG01_PGC.DataSource = dsRet.Tables("Data.WG01_PGC")
                    WG01_PGC.BestFit()
                    '==================
                    Me.DataState = UI.DataStates.Retrieved
                Case "N"
                    Call ClearView(AppliedRangeTypes.Only, {WG02, WG02_CMPT, WG02_CMPT_ALL, WG02_PRAR, WG02_PRAR_ALL, WG01_PGC})
                    MsgBoxLocalized(drPairs("TrxMsg"))
                    Me.DataState = UI.DataStates.Retrieved
                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select
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


    Public Sub GridInit()
        Common.DrawRowIndicator({GV02, GV02_EDI, GV02_CMPT, GV02_PRAR})

        Dim rpPROC_TYPE As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit = GridFunc.GetRepositoryItemLookUpEditEx("CommonCode", "GroupCode:'T07',NameType:''")
        GV02_CMPT.Columns("PROC_TYPE").ColumnEdit = rpPROC_TYPE
        GV02_PRAR.Columns("PROC_TYPE").ColumnEdit = rpPROC_TYPE

        Dim rpPRIORITY As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit = GridFunc.GetRepositoryItemLookUpEditEx({"0:매우급함", "1:급함", "2:당일처리", "3:내일처리", "4:일주일"})
        GV02_CMPT.Columns("PRIORITY").ColumnEdit = rpPRIORITY
        GV02_PRAR.Columns("PRIORITY").ColumnEdit = rpPRIORITY

        Dim rpREQ_SVC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit = GridFunc.GetRepositoryItemLookUpEditEx("CommonCode", "GroupCode:'Z01',NameType:''")
        GV02_CMPT.Columns("REQ_SVC").ColumnEdit = rpREQ_SVC
        GV02_PRAR.Columns("REQ_SVC").ColumnEdit = rpREQ_SVC

        Dim rpREQ_SVC2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit = GridFunc.GetRepositoryItemLookUpEditEx("CommonCode", "GroupCode:'Z02',NameType:''")
        GV02_CMPT.Columns("REQ_SVC2").ColumnEdit = rpREQ_SVC2
        GV02_PRAR.Columns("REQ_SVC2").ColumnEdit = rpREQ_SVC2

        Dim rpREQ_SVC3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit = GridFunc.GetRepositoryItemLookUpEditEx("CommonCode", "GroupCode:'Z03',NameType:''")
        GV02_CMPT.Columns("REQ_SVC3").ColumnEdit = rpREQ_SVC3
        GV02_PRAR.Columns("REQ_SVC3").ColumnEdit = rpREQ_SVC3
    End Sub


    Public Sub PopUpInit()
        Dim PopUp As New PopupBase
        PopUp.ItemAdd(Action.NavigateTo, "CrmAsMgt_v4", "고객지원 등록")
        PopUp.PopUpInit(Me)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Excel, "PGC1_Excel", "&Excel Export", True)
        PopUp.PopUpInit(Me, WG01_PGC)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Excel, "WG02_Excel", "&Excel Export", True)
        PopUp.PopUpInit(Me, WG02)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Other, "WG02_CMPT_CrmAsMgt", "고객지원등록 바로가기", True)
        PopUp.ItemAdd(Action.NavigateTo, "WG02_CMPT_ComDocumentMgt", "Document", True)
        PopUp.ItemAdd(Action.Excel, "WG02_CMPT_Excel", "&Excel Export", True)
        PopUp.PopUpInit(Me, WG02_CMPT)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Other, "WG02_PRAR_CrmAsMgt", "고객지원등록 바로가기", True)
        PopUp.ItemAdd(Action.NavigateTo, "WG02_PRAR_ComDocumentMgt", "Document", True)
        PopUp.ItemAdd(Action.Excel, "WG02_PRAR_Excel", "&Excel Export", True)
        PopUp.PopUpInit(Me, WG02_PRAR)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Excel, "WG02_EDI_Excel", "&Excel Export", True)
        PopUp.PopUpInit(Me, WG02_EDI)
    End Sub
    Public Sub PopUpOnAfterClick(ByVal dr As DataRow)
        Dim key As String = dr("Key").ToString
        Select Case key
            Case "CrmAsMgt_v4"
                Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
                Dim fTarget As Object = frmMain.NavigateTo("CrmAsMgt_v4")
            Case "CrmAsScore"
                Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
                Dim fTarget As Object = frmMain.NavigateTo("CrmAsScore")
            Case "WG02_CMPT_ComDocumentMgt"
                Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
                Dim fTarget As Object = frmMain.NavigateTo("ComDocumentMgt", NavigatedWindowModes.Dialog, False)
                If fTarget IsNot Nothing Then
                    fTarget.S_MNGT_NO.text = GV02_CMPT.GetFocusedRowCellValue("MNGT_NO").ToString
                    fTarget.SCREEN.Text = "주간업무 보고"
                    fTarget.DirList.Text = "CrmAsWeekly"
                    fTarget.SearchData()
                    fTarget.ShowDialog()
                End If
            Case "WG02_PRAR_ComDocumentMgt"
                Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
                Dim fTarget As Object = frmMain.NavigateTo("ComDocumentMgt", NavigatedWindowModes.Dialog, False)
                If fTarget IsNot Nothing Then
                    fTarget.S_MNGT_NO.text = GV02_PRAR.GetFocusedRowCellValue("MNGT_NO").ToString
                    fTarget.SCREEN.Text = "주간업무 보고"
                    fTarget.DirList.Text = "CrmAsWeekly"
                    fTarget.SearchData()
                    fTarget.ShowDialog()
                End If
            Case "WG02_CMPT_CrmAsMgt"
                Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
                Dim fTarget As Object = frmMain.NavigateTo("CrmAsMgt_v4", NavigatedWindowModes.MDIWindow, True)
                If fTarget IsNot Nothing Then
                    fTarget.MNGT_NO.Text = GV02_CMPT.GetFocusedRowCellValue("MNGT_NO").ToString
                    fTarget.SearchData()
                End If
            Case "WG02_PRAR_CrmAsMgt"
                Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
                Dim fTarget As Object = frmMain.NavigateTo("CrmAsMgt_v4", NavigatedWindowModes.MDIWindow, True)
                If fTarget IsNot Nothing Then
                    fTarget.MNGT_NO.Text = GV02_PRAR.GetFocusedRowCellValue("MNGT_NO").ToString
                    fTarget.SearchData()
                End If
        End Select
    End Sub

    Private Sub NavigetToCrmAsMgt(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing

        frmMain = Me.MdiParent
        fTarget = frmMain.NavigateTo("CrmAsMgt_v4")
        If Not IsNothing(fTarget) Then
            fTarget.MNGT_NO.Text = view.GetFocusedRowCellValue("MNGT_NO").ToString
            fTarget.SearchData()
        End If
    End Sub

    Private Sub NavigetToDocument(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing

        frmMain = Me.MdiParent
        fTarget = frmMain.NavigateTo("ComDocumentMgt", NavigatedWindowModes.Dialog, False)
        If Not IsNothing(fTarget) Then
            fTarget.ParentWindow = Me
            fTarget.S_MNGT_NO.text = view.GetFocusedRowCellValue("MNGT_NO").ToString
            fTarget.SCREEN.Text = "고객지원 작업현황"
            fTarget.DirList.Text = "CrmAsList"
            fTarget.SearchData()
            fTarget.ShowDialog()
        End If
    End Sub

    Private Sub SetDefault()
        Dim thisWeekDay As Integer = Weekday(Now)
        Dim toDate As Date = DateAdd(DateInterval.Day, 5 - thisWeekDay, Now)
        S_FM_YMD.Text = DateAdd(DateInterval.Day, -6, toDate).ToString("yyyyMMdd")
        S_TO_YMD.Text = toDate.ToString("yyyyMMdd")
        S_DEPT_CD.SelectedValue = ClientSessionInfo.OrganizationCode

        Call SetFmYmdPrevNext()
        Call SetToYmdPrevNext()
    End Sub
    Private Sub CrmAsWeekly_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call GridInit()
        Call SetDevPicList()
        Call SetDefault()
    End Sub
    Private Sub CrmAsWeekly_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call PopUpInit()
        SaveControlValues(Me, {S_DEPT_CD, S_DEV_PIC_LIST})
    End Sub
    Private Sub SetDevPicList()
        Dim dt As New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        Dim bindingSourceProduct = New BindingSource()
        bindingSourceProduct = New BindingSource()
        bindingSourceProduct.DataSource = dt.Copy
        S_DEV_PIC_LIST.Properties.DataSource = bindingSourceProduct.DataSource
        S_DEV_PIC_LIST.Properties.ValueMember = "CODE"
        S_DEV_PIC_LIST.Properties.DisplayMember = "NAME"
        S_DEV_PIC_LIST.Properties.NullText = String.Empty
        S_DEV_PIC_LIST.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
        S_DEV_PIC_LIST.Properties.SeparatorChar = ";"
    End Sub


    Private Sub S_FM_YMD_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_FM_YMD.Validated
        Call SetFmYmdPrevNext()
    End Sub

    Private Sub SetFmYmdPrevNext()
        If S_FM_YMD.Text.Length < 8 Then Exit Sub
        If IsDate(String.Format("{0}-{1}-{2}", S_FM_YMD.Text.Substring(0, 4), S_FM_YMD.Text.Substring(4, 2), S_FM_YMD.Text.Substring(6, 2))) Then
            S_FM_YMD_PREV.Text = DateAdd(DateInterval.Day, -7, CDate(String.Format("{0}-{1}-{2}", S_FM_YMD.Text.Substring(0, 4), S_FM_YMD.Text.Substring(4, 2), S_FM_YMD.Text.Substring(6, 2)))).ToString("yyyyMMdd")
            S_FM_YMD_NEXT.Text = DateAdd(DateInterval.Day, 7, CDate(String.Format("{0}-{1}-{2}", S_FM_YMD.Text.Substring(0, 4), S_FM_YMD.Text.Substring(4, 2), S_FM_YMD.Text.Substring(6, 2)))).ToString("yyyyMMdd")
        End If
    End Sub

    Private Sub S_TO_YMD_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_TO_YMD.Validated
        Call SetToYmdPrevNext()
    End Sub

    Private Sub SetToYmdPrevNext()
        If S_TO_YMD.Text.Length < 8 Then Exit Sub
        If IsDate(String.Format("{0}-{1}-{2}", S_TO_YMD.Text.Substring(0, 4), S_TO_YMD.Text.Substring(4, 2), S_TO_YMD.Text.Substring(6, 2))) Then
            S_TO_YMD_PREV.Text = DateAdd(DateInterval.Day, -7, CDate(String.Format("{0}-{1}-{2}", S_TO_YMD.Text.Substring(0, 4), S_TO_YMD.Text.Substring(4, 2), S_TO_YMD.Text.Substring(6, 2)))).ToString("yyyyMMdd")
            S_TO_YMD_NEXT.Text = DateAdd(DateInterval.Day, 7, CDate(String.Format("{0}-{1}-{2}", S_TO_YMD.Text.Substring(0, 4), S_TO_YMD.Text.Substring(4, 2), S_TO_YMD.Text.Substring(6, 2)))).ToString("yyyyMMdd")
        End If
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        If S_FM_YMD.Text.Length = 8 Then
            If IsDate(String.Format("{0}-{1}-{2}", S_FM_YMD.Text.Substring(0, 4), S_FM_YMD.Text.Substring(4, 2), S_FM_YMD.Text.Substring(6, 2))) Then
                S_FM_YMD.Text = DateAdd(DateInterval.Day, -7, CDate(String.Format("{0}-{1}-{2}", S_FM_YMD.Text.Substring(0, 4), S_FM_YMD.Text.Substring(4, 2), S_FM_YMD.Text.Substring(6, 2)))).ToString("yyyyMMdd")
                Call SetFmYmdPrevNext()
            End If
        End If
        If S_TO_YMD.Text.Length = 8 Then
            If IsDate(String.Format("{0}-{1}-{2}", S_TO_YMD.Text.Substring(0, 4), S_TO_YMD.Text.Substring(4, 2), S_TO_YMD.Text.Substring(6, 2))) Then
                S_TO_YMD.Text = DateAdd(DateInterval.Day, -7, CDate(String.Format("{0}-{1}-{2}", S_TO_YMD.Text.Substring(0, 4), S_TO_YMD.Text.Substring(4, 2), S_TO_YMD.Text.Substring(6, 2)))).ToString("yyyyMMdd")
                Call SetToYmdPrevNext()
            End If
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If S_FM_YMD.Text.Length = 8 Then
            If IsDate(String.Format("{0}-{1}-{2}", S_FM_YMD.Text.Substring(0, 4), S_FM_YMD.Text.Substring(4, 2), S_FM_YMD.Text.Substring(6, 2))) Then
                S_FM_YMD.Text = DateAdd(DateInterval.Day, 7, CDate(String.Format("{0}-{1}-{2}", S_FM_YMD.Text.Substring(0, 4), S_FM_YMD.Text.Substring(4, 2), S_FM_YMD.Text.Substring(6, 2)))).ToString("yyyyMMdd")
                Call SetFmYmdPrevNext()
            End If
        End If
        If S_TO_YMD.Text.Length = 8 Then
            If IsDate(String.Format("{0}-{1}-{2}", S_TO_YMD.Text.Substring(0, 4), S_TO_YMD.Text.Substring(4, 2), S_TO_YMD.Text.Substring(6, 2))) Then
                S_TO_YMD.Text = DateAdd(DateInterval.Day, 7, CDate(String.Format("{0}-{1}-{2}", S_TO_YMD.Text.Substring(0, 4), S_TO_YMD.Text.Substring(4, 2), S_TO_YMD.Text.Substring(6, 2)))).ToString("yyyyMMdd")
                Call SetToYmdPrevNext()
            End If
        End If
    End Sub

    Private Sub S_DEPT_CD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_DEPT_CD.SelectedIndexChanged
        Select Case S_DEPT_CD.SelectedValue
            Case "02", "07" '개발팀
                xtcAnalysis.SelectedTabPage = xtpDev
            Case "04", "08" '솔루션사업팀
                xtcAnalysis.SelectedTabPage = xtpSales
            Case "06" '관리팀
                xtcAnalysis.SelectedTabPage = xtpAccount
            Case "01" '고객지원팀
                xtcAnalysis.SelectedTabPage = xtpHelp
        End Select

        Call SetDevPicList(S_DEV_PIC_LIST, S_DEPT_CD.SelectedValue)
    End Sub
    Dim dtCrmUserInfo As DataTable = Nothing
    Private Sub SetDevPicList(ByVal sender As Object, ByVal Dept_Cd As String)
        If IsNothing(dtCrmUserInfo) Then
            Dim dsRet As DataSet = GetConvertToDataSet("CrmUserInfo")
            Try
                dsRet = MethodCallEx(Me, "YJIT.Biz.YJQuery", "Search", {dsRet})
            Catch ex As Exception
                MsgBoxLocalized(ex.Message & " (SetDevPicList)")
            End Try
            If dsRet.Tables.Contains("Data.CrmUserInfo") Then
                dtCrmUserInfo = dsRet.Tables("Data.CrmUserInfo").Copy
            End If
        End If
        If IsNothing(dtCrmUserInfo) Then Exit Sub
        If String.IsNullOrEmpty(Dept_Cd) Then Exit Sub


        Dim dt As New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        Try
            Dim Drs() As DataRow
            If Dept_Cd = "ALL" Then
                Drs = dtCrmUserInfo.Select("1=1", "DEPT_CD ASC,LOC_NM ASC")
            Else
                If Dept_Cd.Contains(";") Then
                    Drs = dtCrmUserInfo.Select("DEPT_CD IN ('" & Dept_Cd.Replace(" ", "").Replace(";", "','") & "')", "LOC_NM ASC")
                Else
                    Drs = dtCrmUserInfo.Select("DEPT_CD = '" & Dept_Cd & "'", "LOC_NM ASC")
                End If
            End If
            If Drs.Length > 0 Then
                dt = Drs.CopyToDataTable
                dt.Columns("USR_ID").ColumnName = "CODE"
                dt.Columns("LOC_NM").ColumnName = "NAME"
            End If

            If TypeName(sender) = "CheckedComboBoxEdit" Then
                sender.Properties.DataSource = dt.Copy

                S_DEV_PIC_LIST.EditValue = String.Empty
            Else
                Dim dr As DataRow = dt.NewRow
                dr("CODE") = ""
                dr("NAME") = ""
                dt.Rows.InsertAt(dr, 0)
                sender.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GV02_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GV02.FocusedRowChanged
        If GV02.RowCount <= 0 Then Exit Sub

        If GV02_CMPT_ALL.RowCount > 0 Then
            Dim drCmptList() As DataRow
            If String.IsNullOrEmpty(GV02.GetFocusedRowCellValue("PROJECT_CD").ToString) Then
                drCmptList = CType(WG02_CMPT_ALL.DataSource, DataTable).Select("WORK_USR_NM = '" & GV02.GetFocusedRowCellValue("USR_NM").ToString & "' AND PROJECT_CD IS NULL")
            Else
                drCmptList = CType(WG02_CMPT_ALL.DataSource, DataTable).Select("WORK_USR_NM = '" & GV02.GetFocusedRowCellValue("USR_NM").ToString & "' AND PROJECT_CD = '" & GV02.GetFocusedRowCellValue("PROJECT_CD").ToString & "'")
            End If
            If drCmptList.Count > 0 Then
                WG02_CMPT.DataSource = drCmptList.CopyToDataTable
            Else
                Call ClearView(AppliedRangeTypes.Only, {WG02_CMPT})
            End If
        End If

        If GV02_PRAR_ALL.RowCount > 0 Then
            Dim drPrarList() As DataRow
            If String.IsNullOrEmpty(GV02.GetFocusedRowCellValue("PROJECT_CD").ToString) Then
                drPrarList = CType(WG02_PRAR_ALL.DataSource, DataTable).Select("WORK_USR_NM = '" & GV02.GetFocusedRowCellValue("USR_NM").ToString & "' AND PROJECT_CD IS NULL")
            Else
                drPrarList = CType(WG02_PRAR_ALL.DataSource, DataTable).Select("WORK_USR_NM = '" & GV02.GetFocusedRowCellValue("USR_NM").ToString & "' AND PROJECT_CD = '" & GV02.GetFocusedRowCellValue("PROJECT_CD").ToString & "'")
            End If
            If drPrarList.Count > 0 Then
                WG02_PRAR.DataSource = drPrarList.CopyToDataTable
            Else
                Call ClearView(AppliedRangeTypes.Only, {WG02_PRAR})
            End If
        End If
    End Sub
End Class
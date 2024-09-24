Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing
Imports YJIT.SC.UI

Public Class AraAcctNoMgt
    Public _insFlag As String = "I"
    Public _searchFlag As Boolean = True

#Region "=================Client Function==========="

    Public Sub TxtFileRead()
        If GV1.GetFocusedRowCellValue("FI_CD") Is Nothing Then
            MsgBoxLocalized("왼쪽 그리드에서 항목을 선택해주세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If
        If String.IsNullOrEmpty(GV1.GetFocusedRowCellValue("FI_CD").ToString) Then
            MsgBoxLocalized("금융기관 코드가 없습니다.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If
        Using VaBankCDtxtFile As New OpenFileDialog()
            Dim ds As New DataSet
            Dim dt As New DataTable
            Dim dt2 As New DataTable
            Dim msg_str As String = ""
            Dim i As Integer = 0
            VaBankCDtxtFile.Filter = "Text file(*.txt)|*.txt"
            VaBankCDtxtFile.Title = "가상계좌번호 파일 선택"
            VaBankCDtxtFile.FileName = ""
            If VaBankCDtxtFile.ShowDialog = DialogResult.OK Then
                Dim _file = FileIO.FileSystem.ReadAllText(VaBankCDtxtFile.FileName.ToString)
                Dim _txt_str As String() = _file.Split(ControlChars.CrLf.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                dt.Columns.Add("FI_CD", GetType(String))
                dt.Columns.Add("VA_ACCNT_NO", GetType(String))
                dt.TableName = "Data.WG2"
                For Each row As String In _txt_str
                    If String.IsNullOrEmpty(row.Replace(" ", "")) Or
                        row.Replace(" ", "").Length > 17 Or
                        row.Replace(" ", "").Length < 10 Or
                        Not IsNumeric(row.Replace(" ", "")) Or
                        CheckVAAccntNo(GV1.GetFocusedRowCellValue("FI_CD").ToString(), row.Replace(" ", "")) = False Then
                        msg_str += "업로드실패 계좌번호 : " & row.Replace(vbLf, "") & vbCrLf
                        Continue For
                    End If
                    dt.Rows.Add(dt.NewRow())
                    dt.Rows(i)("FI_CD") = GV1.GetFocusedRowCellValue("FI_CD").ToString()
                    dt.Rows(i)("VA_ACCNT_NO") = row.Replace(" ", "")
                    i += 1
                Next
                msg_str = (_txt_str.Length).ToString & "개의 가상계좌번호 중 " & (i.ToString) & "개가 업로드되었습니다." & vbCrLf & vbCrLf & msg_str
                MsgBoxLocalized(msg_str, MessageBoxButtons.OK, "", MessageBoxIcon.Information)
                If i > 0 Then
                    btnSave.Enabled = True
                    btnSave.Focus()
                Else
                    btnVABankCDFile.Focus()
                End If
                ds.Tables.Add(dt)
                Me.BindToDataset(ds, "Data")
                Me.DataState = UI.DataStates.New
            End If
        End Using
    End Sub

#End Region

#Region "=================Data logic actions==========="

    Public Sub NewData()
        ClearView(UI.AppliedRangeTypes.All)
        Me.DataState = DataStates.New
        Call SearchData()
    End Sub

    Public Sub RefreshData()
        btnSave.Enabled = False
        USE_YN.Focus()
        Call SearchData()
    End Sub

    Public Sub SearchData()
        Dim ds As DataSet = Me.ConvertToDataset
        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.AraAcctNoMgt", "Search", ds, AddressOf Search_Complete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Public Sub Search_Complete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Try
            If IsNothing(e.Result) Then
                MsgBoxLocalized("Data is nothing!")
                Exit Sub
            End If
            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
            Me.ClearView(AppliedRangeTypes.Only, {WG1, WG2})

            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Search", MessageBoxIcon.Warning)
                btnRefresh.Focus()
                Exit Sub
            End If
            _searchFlag = False
            Me.BindToDataset(ds, "Data")
            Me.DataState = UI.DataStates.Retrieved
            Me.GV1.BestFitColumns()
            USE_YN.Focus()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message, MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SearchDetail()
        If (GV1.RowCount = 0) Then Exit Sub
        If GV1.GetFocusedRowCellValue("FI_CD") Is Nothing Then Exit Sub
        Dim ds As DataSet = Me.ConvertToDataset
        ds.Tables("MAIN").Columns.Add("FI_CD", GetType(String))
        ds.Tables("MAIN").Rows(0)("FI_CD") = GV1.GetFocusedRowCellValue("FI_CD").ToString
        Try
            _searchFlag = True
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.AraAcctNoMgt", "SearchDetail", ds, AddressOf SearchDetail_Complete)
        Catch ex As Exception
            _searchFlag = False
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Public Sub SearchDetail_Complete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Try
            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

            Me.ClearView(AppliedRangeTypes.Only, {WG2})
            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Information)
                Exit Sub
            End If
            Me.BindToDataset(ds, "Data")
            Me.DataState = UI.DataStates.Retrieved
            Me.GV2.BestFitColumns()
            USE_YN.Focus()
            _searchFlag = False
        Catch ex As Exception
            MsgBoxLocalized(ex.Message, MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SaveData()
        If GV1.RowCount = 0 AndAlso GV1.GetFocusedRowCellValue("FI_CD") Is Nothing Then
            MsgBoxLocalized("금융기관코드는 필수항목입니다.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If

        If GV2.RowCount = 0 Then
            MsgBoxLocalized("가상계좌번호는 필수항목입니다.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim ds As DataSet = Me.ConvertToDataset
        ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.BIZ.AraAcctNoMgt", "Save", {_insFlag, ds})
        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        Else
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Confirm", MessageBoxIcon.Information)
        End If
        Call SearchData()
    End Sub

    Private Sub PopupInit()
        Dim QuickMenu_Popup As New PopupBase
        QuickMenu_Popup.ItemAdd(Action.NavigateTo, "AraMemberMgt", "AraMember Management", BarIcon.PageLink)
        QuickMenu_Popup.PopUpInit(Me, btnQuickMenu)

        Dim WG1_PopUp As New PopupBase
        WG1_PopUp.ItemAdd(Action.Addrow, "WG1_AddRow", "&Add Row", True)
        WG1_PopUp.ItemAdd(Action.Excel, "WG1_ExcelExport", "&Export Excel", True)
        WG1_PopUp.PopUpInit(Me, WG1)

        Dim WG2_PopUp As New PopupBase
        WG2_PopUp.ItemAdd(Action.Excel, "WG2_ExcelExport", "&Export Excel", True)
        WG2_PopUp.PopUpInit(Me, WG2)
    End Sub

    Public Sub PopUpOnAfterClick(ByVal Dr As DataRow)
        Dim Key As String = Dr("KEY")
        Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
        Dim fTarget As Object = Nothing

        Select Case Dr("Action")
            Case Action.NavigateTo
                Select Case Key
                    Case "AraMemberMgt"
                        fTarget = frmMain.NavigateTo(Key)
                End Select
            Case Action.Addrow
                Select Case Key
                    Case "WG1_AddRow"
                        GV1.SetRowCellValue(GV1.FocusedRowHandle, "FI_CD", "")
                        GV1.SetRowCellValue(GV1.FocusedRowHandle, "BANK_NM", "")
                        GV1.SetRowCellValue(GV1.FocusedRowHandle, "REMAIN_NO", "")
                        GV1.OptionsBehavior.Editable = True
                        Me.ClearView(AppliedRangeTypes.Only, {WG2})
                        _insFlag = "I"
                End Select
        End Select
    End Sub

    Public Sub GridInit()
        Dim editorCode = New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit With {
            .CodeType = "YJIT.CodeService.CommonCode",
            .DataParams = "GroupCode:'N25',NameType:''",
            .DisplayParams = "CODE:#FI_CD,NAME:#BANK_NM",
            .ValidateKeys = "KEY:#FI_CD",
            .KeepIntegrity = True,
            .AutoSuggestion = True,
            .CharacterCasing = CharacterCasing.Upper
        }
        GV1.Columns("FI_CD").ColumnEdit = editorCode

        Call DrawRowIndicator({GV1, GV2})
    End Sub

    Public Function CheckVAAccntNo(ByVal _FI_CD As String, ByVal _VA_BANK_CD As String) As Boolean
        Dim ds As New DataSet
        Dim dt As New DataTable
        dt.Columns.Add("FI_CD", GetType(String))
        dt.Columns.Add("VA_BANK_CD", GetType(String))
        dt.Rows.Add(dt.NewRow())
        dt.Rows(0)("FI_CD") = _FI_CD
        dt.Rows(0)("VA_BANK_CD") = _VA_BANK_CD
        dt.TableName = "MAIN"
        ds.Tables.Add(dt)
        If ds IsNot Nothing Then
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.BIZ.AraAcctNoMgt", "CheckVAAccntNo", ds)
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
            If dr("TrxCode") <> "Y" Then
                Return False
            Else
                If ds.Tables("Data.Table").Rows(0)("CNT") <> 0 Then
                    Return False
                Else
                    Return True
                End If
            End If
        End If
        Return False
    End Function

#End Region

#Region "=================Control Events==========="

    Private Sub AraAcctNoMgt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GridInit()
        Call PopupInit()
    End Sub

    Private Sub AraAcctNoMgt_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        SearchData()
    End Sub

    Private Sub btnSearch_click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        Call SearchDetail()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call RefreshData()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call NewData()
    End Sub

    Private Sub btnVABankCDFile_Click(sender As Object, e As EventArgs) Handles btnVABankCDFile.Click
        Call TxtFileRead()
    End Sub

    Private Sub WG1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV1.FocusedRowChanged
        If GV1.GetFocusedDataSourceRowIndex() >= 0 Then
            If Not IsNothing(GV1.GetFocusedDataRow()) Then
                If GV1.GetFocusedDataRow().RowState = DataRowState.Added Then
                    Me.GV1_FI_CD.OptionsColumn.AllowEdit = True
                    Me.GV1_FI_CD.OptionsColumn.ReadOnly = False
                    Me.GV1_BANK_NM.OptionsColumn.AllowEdit = True
                    Me.GV1_BANK_NM.OptionsColumn.ReadOnly = False
                    Me.ClearView(AppliedRangeTypes.Only, {WG2})
                    _searchFlag = True
                    btnSave.Enabled = True
                Else
                    Me.GV1_FI_CD.OptionsColumn.AllowEdit = False
                    Me.GV1_FI_CD.OptionsColumn.ReadOnly = True
                    Me.GV1_BANK_NM.OptionsColumn.AllowEdit = False
                    Me.GV1_BANK_NM.OptionsColumn.ReadOnly = True
                    _searchFlag = False
                    btnSave.Enabled = False
                End If
            End If
        End If
        If _searchFlag = True Then Exit Sub
        Call SearchDetail()
    End Sub

#End Region

End Class
Public Class YjediManageList
    Dim WG1_PopUp As New PopupBase

#Region "=================GetConvertToDataSet Function==========="
    Private Function GetConvertToDataSet() As DataSet
        Dim YJSql As New YJQuery
        Dim IsSingleSearch As Boolean = False

        Try
            YJSql.SqlBox("WG1", "YjediManageList@Search", False, True)
            YJSql.Params("OFFICE_CD", ClientSessionInfo.OfficeCode)
            YJSql.Params("EDI_ID", EDI_ID.Text.Trim)
            If FM_YMD.Text.Trim IsNot "" Then
                YJSql.Params("FM_YMD", FM_YMD.Text.Trim & "000000")
            End If
            If TO_YMD.Text.Trim IsNot "" Then
                YJSql.Params("TO_YMD", TO_YMD.Text.Trim & "999999")
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function
#End Region
#Region "=================Client Function=============="
    Private Sub InitGrid()
        GridFunc.SetGridViewStyle(GV1)
        Call DrawRowIndicator(GV1)

        '## WG1 ##
        GV1.Columns("CUSTOMS_CD").ColumnEdit = GridFunc.GetRepositoryItemLookUpEditEx({"NEXN:넥센", "N:NO"})
        GV1.Columns("SYS_ID").ColumnEdit = GridFunc.GetRepositoryItemLookUpEditEx({"ESVC:E-Service", "N:NO"})
        GV1.Columns("IS_CONFIRMED").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit({"Y:YES", "N:NO"})
        GV1.Columns("IS_VALID").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit({"Y:YES", "N:NO"})
    End Sub
#End Region
#Region "=================Data logic actions==========="
    'Data Logic Action : Server 함수 호출 부분 및 메인 버튼 동작 함수 모음
    Public Sub SearchData()

        If SearchValidate() = False Then Exit Sub

        Dim ds As DataSet = GetConvertToDataSet()
        ds = Func.MethodCall(Me, "YJIT.Biz.YjediManageList", "Search", {ds})
        Dim drPairs As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case drPairs("trxCode")
            Case "Y"
                Try
                    ClearView(UI.AppliedRangeTypes.Only, {WG1})

                    Me.BindToDataset(ds, "Data")
                Catch ex As Exception
                    MsgBoxLocalized(ex.Message & " (BindToDataset)")
                End Try

                Me.DataState = UI.DataStates.Retrieved
            Case "N"
                MsgBoxLocalized(drPairs("trxMsg"))
                ClearView(UI.AppliedRangeTypes.Only, {WG1})

                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(drPairs("trxMsg"))
        End Select
    End Sub
    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing

        Try
            If String.IsNullOrEmpty(FM_YMD.Text) Then
                If ErrControl Is Nothing Then ErrControl = FM_YMD
                'ErrMsg &= "Please input the [" & S_CUST_TYPE.SelectedText & "]" & vbNewLine
                '다국어 지원
                ErrMsg &= "[" & LBL_INS_YMD.Text & "]를 입력해주세요." & vbNewLine
            ElseIf String.IsNullOrEmpty(TO_YMD.Text) Then
                If ErrControl Is Nothing Then ErrControl = TO_YMD
                ErrMsg &= "[" & LBL_INS_YMD.Text & "]를 입력해주세요." & vbNewLine
            End If

            If Not String.IsNullOrEmpty(ErrMsg) Then
                If Not ErrControl Is Nothing Then ErrControl.Focus()
                Throw New Exception(ErrMsg)
            End If

            Return True
        Catch ex As Exception
            MsgBoxLocalized("전체 필수항목입니다." & vbCrLf & vbCrLf & ex.Message)
            Return False
        End Try
    End Function

#End Region
#Region "=================Control Events==========="

    Private Sub YjediSpecDetailMgt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call InitGrid()

        FM_YMD.Text = DateAdd(DateInterval.Day, -7, Now).ToString("yyyyMMdd")
        TO_YMD.Text = Now.ToString("yyyyMMdd")
    End Sub

    Private Sub YjediSpecDetailMgt_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        FM_YMD.Focus()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call ClearView()
        EDI_ID.Focus()
    End Sub

    Private Sub GV1_DoubleClick(sender As Object, e As EventArgs) Handles GV1.DoubleClick
        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing
        frmMain = SCView.MainFormInstance
        fTarget = frmMain.NavigateTo("YjediFactDetailList", NavigatedWindowModes.Dialog, False)
        If Not IsNothing(fTarget) Then
            fTarget.EDI_ID.TEXT = GV1.GetFocusedRowCellValue("EDI_ID").ToString
            fTarget.SearchData
            fTarget.ShowDialog()
        End If
    End Sub
#End Region
End Class
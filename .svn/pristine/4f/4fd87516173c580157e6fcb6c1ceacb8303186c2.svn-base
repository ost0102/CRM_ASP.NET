Imports Microsoft.VisualBasic
Imports System
Imports YJIT.SC.UI

Public Class MdmMappingMgt

#Region "=================Data logic actions==========="
    Public Sub NewData()
        Me.ClearView(UI.AppliedRangeTypes.All)
        Call SetDefault()
    End Sub

    Public Sub SearchData()
        If SearchValidate() = False Then Exit Sub

        Dim dsRet As DataSet = Me.ConvertToDataset

        dsRet = MethodCallEx(Me, "YJIT.Biz.MdmMappingMgt", "Search", {dsRet})
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

    Public Sub SaveData()

        If MandatoryGridValue("GV1") Then Exit Sub
        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then Exit Sub

        Dim ds As DataSet = Me.ConvertToDataset
        If ds.Tables("WG1").Rows.Count = 0 Then
            MsgBoxLocalized("Data is empty!")
            Exit Sub
        End If

        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MdmMappingMgt", "Save", Me.ConvertToDataset)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") = "Y" Then
            Me.BindToDataset(ds, "Data")
            Me.DataState = UI.DataStates.Retrieved
        End If

        MsgBoxLocalized(dr("TrxMsg"))

    End Sub


    Public Function MandatoryGridValue(ByVal gridView As String) As Boolean
        Dim Param As New Dictionary(Of String, Object)
        Dim checkNull() As String = Nothing
        Select Case gridView
            Case "GV1"
                checkNull = {}
                Param("FM_CD") = GV1_FM_CD.Caption()
                Param("TO_CD") = GV1_TO_CD.Caption()
                Return ValidateGridValue(GV1, Param, checkNull)
        End Select
        Return False
    End Function

#End Region


#Region "=================Control Events==========="
    Private Sub ComDelLogMgt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call SetDefault()
        Call DrawRowIndicator({GV1})

        Call InitGrid()
    End Sub

    Private Sub ComDelLogMgt_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Call PopupInit()
        'SetMandatoryLine(Me)
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Call NewData()
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub

#End Region

#Region "=================Client Function==========="
    'Client Function : 클라이언트 동작 함수
    Private Sub SetDefault()
        'S_FM_YMD.Text = Now.ToString("yyyyMMdd")
        'S_TO_YMD.Text = Now.ToString("yyyyMMdd")

        'Me.ResetView(AppliedRangeTypes.Only, {S_DATE_TYPE, S_REQ_SVC, S_EX_IM_TYPE, S_INV_TYPE})
    End Sub

    Private Sub PopupInit()
        Dim PopUp As New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG1_AddRow", "&Add Row")
        PopUp.ItemAdd(Action.DeleteRow, "WG1_DelRow", "&Delete Row")
        PopUp.ItemAdd(Action.Excel, "WG1_ExcelExport", "&Export Excel", True)
        PopUp.PopUpInit(Me, WG1, "TABLE_ID", "RMK")
    End Sub

    '# PopUpOnAfterClick
    Public Sub PopUpOnAfterClick(ByVal Dr As DataRow)
        Dim Key As String = Dr("Key")
        Dim Sender As String = ""
        If Not Dr("Sender") Is System.DBNull.Value Then Sender = Dr("Sender")

        Dim Id As String = ""
        If Key = "Enter" Then Id = Dr("ID")

        'Navigato 사용할떄
        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing
        Dim rowIndex As Integer = 0

        Select Dr("Action")
            Case Action.NavigateTo
                frmMain = Me.MdiParent
                Select Key
                    Case ""
                        fTarget = frmMain.NavigateTo(Key, NavigatedWindowModes.Dialog, False)
                        If Not IsNothing(fTarget) Then
                            fTarget.SearchData()
                        End If
                End Select

            Case Action.Addrow, Action.EventKey
                Select Sender
                    Case "WG1"
                        rowIndex = GV1.FocusedRowHandle
                        If rowIndex > 0 Then
                            GV1.SetRowCellValue(rowIndex, "TABLE_ID", GV1.GetRowCellValue(rowIndex - 1, "TABLE_ID").ToString)
                            GV1.SetRowCellValue(rowIndex, "FM_TYPE", GV1.GetRowCellValue(rowIndex - 1, "FM_TYPE").ToString)
                            GV1.SetRowCellValue(rowIndex, "FIELD_ID", GV1.GetRowCellValue(rowIndex - 1, "FIELD_ID").ToString)
                        Else
                            GV1.SetFocusedRowCellValue("TABLE_ID", "")
                            GV1.SetFocusedRowCellValue("FM_TYPE", "")
                            GV1.SetFocusedRowCellValue("FIELD_ID", "")
                        End If
                End Select
            Case Action.Other
                Select Key
                    Case ""
                End Select
            Case Action.Excel
                If Key = "WG1_ExportExcel" Then
                    GV1.OptionsView.ShowViewCaption = True
                End If
        End Select

    End Sub

    Public Sub InitGrid()

        Dim editorCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)

        Select Case ClientSessionOfficeInfo.CountryCode
            Case "KR"
                Select Case ClientSessionOfficeInfo.HqOfficeCode
                    Case "ECOHQ", "LPGLHQ"
                        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
                        editorCombo.DisplayMember = "NAME"
                        editorCombo.ValueMember = "CODE"
                        editorCombo.NullText = "--Select--"
                        editorCombo.ShowHeader = False
                        editorCombo.ReadOnly = False
                        searchParams = New Dictionary(Of String, Object)
                        dataParams = New Dictionary(Of String, Object)
                        dataParams.Add("GroupCode", "E11")
                        dataParams.Add("NameType", "")
                        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
                        GV1.Columns("FM_TYPE").ColumnEdit = editorCombo


                        lbMappingType.Visible = True

                    Case Else

                End Select
            Case Else
        End Select

    End Sub

    Private Sub GV1_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV1.FocusedRowChanged
        If GV1.GetFocusedDataSourceRowIndex() >= 0 Then
            If Not IsNothing(GV1.GetFocusedDataRow().RowState) Then
                If GV1.GetFocusedDataRow().RowState = DataRowState.Added Then
                    Me.GV1_TABLE_ID.OptionsColumn.AllowEdit = True
                    Me.GV1_TABLE_ID.OptionsColumn.ReadOnly = False
                Else
                    Me.GV1_TABLE_ID.OptionsColumn.AllowEdit = False
                    Me.GV1_TABLE_ID.OptionsColumn.ReadOnly = True
                End If
            End If
        End If
    End Sub


#End Region




End Class
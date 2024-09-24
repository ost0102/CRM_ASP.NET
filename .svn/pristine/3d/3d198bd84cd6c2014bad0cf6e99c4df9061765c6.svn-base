Imports YJIT.SC.UI
Imports YJIT.SC.App.FreightCommon
Imports YJIT.SC.App.Common
Imports System.Net.Mail
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Text.RegularExpressions

Public Class FrndDocumentMgt
    Dim SelectAllYn As Boolean = False
    Private tempFolder As String = Application.StartupPath & "\TMP_OUTPUT"
#Region "=================GetConvertToDataSet Function==========="
    'Private Function GetConvertToDataSet(ByVal SearchType As String, Optional ByVal dtWG1 As DataTable = Nothing) As DataSet
    '    Dim YJSql As New YJQuery
    '    Dim ds As DataSet = Me.ConvertToDataset
    '    Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)

    '    Select Case SearchType.ToUpper
    '        Case "Search".ToUpper
    '            YJSql.SqlBox("WG1", "FrndDocumentMgt@Search",, False)
    '            YJSql.Params("S_STATUS", drMAIN("S_STATUS").ToString)
    '            YJSql.Params("S_FM_YMD", drMAIN("S_FM_YMD").ToString)
    '            YJSql.Params("S_TO_YMD", drMAIN("S_TO_YMD").ToString)
    '            YJSql.Params("S_DOC_TYPE", drMAIN("S_DOC_TYPE").ToString)
    '            YJSql.Params("S_DOC_NM", drMAIN("S_DOC_NM").ToString)
    '            'Case "SearchEmail".ToUpper
    '            '    Dim mngtList As String = String.Empty
    '            '    For Each row As DataRow In dtWG1.Rows
    '            '        If Not String.IsNullOrEmpty(mngtList) Then mngtList &= "','"
    '            '        mngtList &= row("MNGT_NO").ToString
    '            '    Next
    '            '    YJSql.SqlBox("WG1", "FrndDocumentMgt@SearchEmail", True)
    '            '    YJSql.Params("MNGT_NO", mngtList)
    '    End Select

    '    Return YJSql.DataSet
    'End Function
#End Region
#Region "=================Data logic actions==========="
    'Search
    Private Sub SearchData()
        If SearchValidate() = False Then Exit Sub
        Dim ds As DataSet = New DataSet
        Dim dt As DataTable = New DataTable

        dt.Columns.Add("S_APV_YN", GetType(String))
        dt.Columns.Add("S_FM_YMD", GetType(String))
        dt.Columns.Add("S_TO_YMD", GetType(String))
        dt.Columns.Add("S_TMPLT_TYPE", GetType(String))
        dt.Columns.Add("S_TMPLT_NM", GetType(String))
        dt.Rows.Add()
        dt.Rows(0)("S_APV_YN") = S_APV_YN.SelectedValue
        dt.Rows(0)("S_FM_YMD") = S_FM_YMD.Text
        dt.Rows(0)("S_TO_YMD") = S_TO_YMD.Text
        dt.Rows(0)("S_TMPLT_TYPE") = S_TMPLT_TYPE.SelectedValue
        dt.Rows(0)("S_TMPLT_NM") = S_TMPLT_NM.Text
        dt.TableName = "MAIN"
        ds.Tables.Add(dt)

        Try
            Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", "자료 검색중입니다. 잠시만 기다려 주세요.")
                ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.FrndDocumentMgt", "Search", {ds})
            End Using
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        Select Case dr("TrxCode").ToString
            Case "Y"
                Me.BindToDataset(ds, "Data")
                Me.DataState = UI.DataStates.Retrieved
            Case Else
                ClearView(AppliedRangeTypes.Only, {WG1})
                MsgBoxLocalized(dr("TrxMsg"))
        End Select
    End Sub
    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Try
            If String.IsNullOrEmpty(S_FM_YMD.Text) Then
                If ErrControl Is Nothing Then ErrControl = S_FM_YMD
                ErrMsg &= "Please input the [조회 시작 일자]" & vbNewLine
            End If

            If String.IsNullOrEmpty(S_TO_YMD.Text) Then
                If ErrControl Is Nothing Then ErrControl = S_TO_YMD
                ErrMsg &= "Please input the [조회 종료 일자]" & vbNewLine
            End If

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
        If SaveValidate() = False Then Exit Sub

        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then Exit Sub

        Dim ds As DataSet = Me.ConvertToDataset
        If ds.Tables("WG1").Rows.Count = 0 Then
            MsgBoxLocalized("Data Is empty!")
            Exit Sub
        End If

        'If SaveValidate(ds) = False Then Exit Sub

        Try
            Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", "자료 저장중 입니다. 잠시만 기다려 주세요.")
                ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.FrndDocumentMgt", "Save", {ds})
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
                Call SearchData()
                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(dr("TrxMsg"))
        End Select
    End Sub
    Private Function SaveValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim cnt As Integer = 0
        Try

            For index = GV1.RowCount - 1 To 0 Step -1
                If Trim(GV1.GetRowCellValue(index, "APV_YN").ToString) <> Trim(GV1.GetRowCellValue(index, "DB_APV_YN").ToString) Then
                    If Trim(GV1.GetRowCellValue(index, "APV_YN").ToString) = "Y" Then
                        If String.IsNullOrEmpty(Trim(GV1.GetRowCellValue(index, "NC_OCR_ID").ToString)) Then ErrMsg &= "승인된 [" & index + 1 & "] 행의 네이버 문서 ID는 필수입니다. " & vbNewLine
                    End If
                    cnt += 1
                End If
            Next

            If cnt = 0 Then
                ErrMsg = "수정된 자료가 없습니다. "
            End If

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
        'PopUp.ItemAdd(Action.EventKey, "GV1_SelectAll", "&Select All")
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", "&Export Excel", True)
        PopUp.PopUpInit(Me, WG1)
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
        dataParams.Add("GroupCode", "FRND02")
        dataParams.Add("NameType", "")
        editorCombo.ShowHeader = False
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        editorCombo.ForceInitialize() : editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        GV1.Columns("APV_YN").ColumnEdit = editorCombo
        AddHandler editorCombo.EditValueChanged, AddressOf SetEditValueChanged
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
    Private Sub DownloadFile()
        Dim ds As DataSet = New DataSet

        Try
            Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", "파일 다운로드 중 입니다. 잠시만 기다려 주세요.")
                ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.FrndDocumentMgt", "FileDownload", {GV1.GetFocusedRowCellValue("TMPLT_ID").ToString})
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
                    Dim downloadurl As String = "http://apimeta.yjit.co.kr" & ds.Tables("data.Table1").Rows(0)("FILE_PATH").ToString & "/" & ds.Tables("data.Table1").Rows(0)("FILE_NAME").ToString
                    'Dim FileName() As String = ds.Tables("data.Table1").Rows(0)("FILE_PATH").ToString.Split("/")
                    Dim targetfile As String = tempFolder & "\" & ds.Tables("data.Table1").Rows(0)("FILE_NAME").ToString

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
#Region "=================Control Events==========="
    'Client Function : 클라이언트 동작 함수
    Private Sub FrndDocumentMgtt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClearView()
        Call SetMandatoryLine(Me)
        S_FM_YMD.Text = Mid(Now.ToString("yyyyMMdd"), 1, 6) + "01"
        S_TO_YMD.Text = Now.ToString("yyyyMMdd")
    End Sub
    Private Sub FrndDocumentMgtt_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Call PopUpInit()
        Call InitGrid()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub
    Private Sub btnExpFwg1_Click(sender As Object, e As EventArgs) Handles btnExpFwg1.Click
        Call GridToExcel(WG1)
    End Sub
    Public Sub SearchFromMsg(ByVal key1 As String, ByVal key2 As String, ByVal key3 As String, ByVal key4 As String, ByVal key5 As String)
        Call SearchData()
    End Sub

    Private Sub GV1_ShownEditor(sender As Object, e As EventArgs) Handles GV1.ShownEditor
    End Sub
    Private Sub GV1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV1.CellValueChanged
        Select Case e.Column.FieldName
            Case "DOC_ID"
                If GV1.GetFocusedRowCellValue("DOC_ID").ToString = GV1.GetFocusedRowCellValue("DB_DOC_ID").ToString Then Exit Sub
                '네이버 ID 기입시 자동 체크 
                GV1.SetFocusedRowCellValue("CHK", "Y")
            Case "APV_YN"
                Select Case GV1.GetFocusedRowCellValue("APV_YN").ToString
                    Case "C", "N"
                        '취소, 미승인 경우 
                        GV1.SetFocusedRowCellValue("NC_OCR_ID", String.Empty)
                End Select
        End Select
    End Sub
    Private Sub SetGridEmainMsgAllowEdit()
        If GV1.RowCount <= 0 Then Exit Sub

        'Select Case GV1.FocusedColumn.FieldName
        '    Case "EMAIL_MSG"
        '        If GV1.GetRowCellValue(GV1.FocusedRowHandle, "APV_YN").ToString = "D" Then '거절
        '            GV1.FocusedColumn.OptionsColumn.AllowEdit = True
        '            GV1.FocusedColumn.OptionsColumn.ReadOnly = False
        '        Else
        '            GV1.FocusedColumn.OptionsColumn.AllowEdit = False
        '            GV1.FocusedColumn.OptionsColumn.ReadOnly = True
        '        End If
        'End Select
    End Sub
    Private Sub GV1_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GV1.ShowingEditor
        Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = sender
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView
        view = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim dr As DataRow = GV1.GetDataRow(GV1.FocusedRowHandle)

        'Select Case gv.FocusedColumn.FieldName
        '    Case "EMAIL_MSG"
        '        If gv.GetRowCellValue(gv.FocusedRowHandle, "APV_YN").ToString = "D" Or gv.GetRowCellValue(gv.FocusedRowHandle, "APV_YN").ToString = "S" Then
        '            '입력가능. 
        '        Else
        '            e.Cancel = True
        '        End If
        'End Select
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
    Private Sub GV1_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles GV1.RowCellStyle
    End Sub

    Private Sub GV1_DoubleClick(sender As Object, e As EventArgs) Handles GV1.DoubleClick
        Select Case GV1.FocusedColumn.FieldName
            Case "FILE_YN"
                Call DownloadFile()
        End Select
    End Sub
#End Region
End Class
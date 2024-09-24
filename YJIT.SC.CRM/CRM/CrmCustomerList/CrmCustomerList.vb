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

Public Class CrmCustomerList

#Region "=================Data logic actions==========="
    Private Function GetConvertToDataSet() As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
            YJSql.SqlBox("WG1", "CrmCustomerList@Search")
            YJSql.Params("SEARCH_KEY", drMAIN("S_SEARCH_KEY").ToString.Trim, True)
            YJSql.Blocks("SEARCH_KEY", drMAIN("S_SEARCH_KEY").ToString.Trim, True)
            YJSql.Params("SVC_CD", drMAIN("S_SVC_CD").ToString.Trim, True)
            YJSql.Blocks("SVC_CD", drMAIN("S_SVC_CD").ToString.Trim, True)
            YJSql.Params("USE_YN", drMAIN("S_USE_YN").ToString.Trim, True)
            YJSql.Blocks("USE_YN", drMAIN("S_USE_YN").ToString.Trim, True)
            
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

    Public Sub SearchData()
        If SearchValidate() = False Then Exit Sub

        Dim dsRet As DataSet = GetConvertToDataSet()

        dsRet = MethodCallEx(Me, "YJIT.Biz.CrmCustomerList", "Search", {dsRet})
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

    'Public Sub SearchData()
    '    Try
    '        YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.CrmCustomerList", "Search", GetConvertToDataSet(), AddressOf SearchOnComplete)
    '    Catch ex As Exception
    '        MsgBoxLocalized(ex.Message)
    '    End Try

    '    'Try
    '    '    YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.CrmCustomerList", "Search", Me.ConvertToDataset, AddressOf SearchOnComplete)
    '    'Catch ex As Exception
    '    '    MsgBoxLocalized(ex.Message)
    '    'End Try
    'End Sub

    'Private Sub SearchOnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
    '    Try
    '        If IsNothing(e.Result) Then
    '            Throw New Exception("Try Again !")
    '        End If

    '        Dim ds As DataSet = e.Result
    '        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

    '        If dr("TrxCode") <> "Y" Then
    '            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Search", MessageBoxIcon.Warning)
    '            Exit Sub
    '        End If
    '        Me.BindToDataset(ds, "Data")

    '        GV1.BestFitColumns()

    '        Me.DataState = UI.DataStates.Retrieved
    '    Catch ex As Exception
    '        MsgBoxLocalized(ex.Message)
    '    End Try

    'End Sub

    Public Sub GridInit()
        Dim PopUp As PopupBase
        Dim editorCombo As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Excel, "WG1_EXCEL", "Export Excel", True)
        PopUp.PopUpInit(Me, WG1)

        '20240424 김정현 - 해당 소스로 인해 시스템이 출력되지 않아 주석처리함
        'Dim dt2 As New DataTable
        'dt2.Columns.Add(New DataColumn("CODE", GetType(String)))
        'dt2.Columns.Add(New DataColumn("NAME", GetType(String)))

        'AddNewRow(dt2, "E", "ELVIS")
        'AddNewRow(dt2, "O", "ELVIS(Etc)")
        'AddNewRow(dt2, "V", "일반")
        'AddNewRow(dt2, "T", "T/S")
        'AddNewRow(dt2, "M", "적하목록")
        'AddNewRow(dt2, "Z", "기타")
        'AddNewRow(dt2, "L", "운송")
        'AddNewRow(dt2, "W", "WMS")
        'AddNewRow(dt2, "B", "보세")
        'AddNewRow(dt2, "C", "쿠리어")
        'AddNewRow(dt2, "A", "대리점")
        'AddNewRow(dt2, "H", "인사급여")

        'editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        'editorCombo.DisplayMember = "NAME"
        'editorCombo.ValueMember = "CODE"
        'editorCombo.NullText = ""
        'editorCombo.DataSource = dt2.Copy
        'GV1.Columns("SVC_CD").ColumnEdit = editorCombo


        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = " "
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "C03")
        dataParams.Add("NameType", "")
        dataParams.Add("Valid", "V")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV1.Columns("DEPT_CD").ColumnEdit = editorCombo
    End Sub

    Private Sub AddNewRow(ByVal dt As DataTable, ByVal Code As String, ByVal Name As String)
        dt.Rows.Add()
        dt.Rows(dt.Rows.Count - 1)("CODE") = Code
        dt.Rows(dt.Rows.Count - 1)("NAME") = Name
    End Sub

#End Region
#Region "=================Control Events==========="
    Private Sub SEARCH_KEY_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles S_SEARCH_KEY.PreviewKeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) Then
            Call SearchData()
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub

    Private Sub CrmMaintenanceMgt_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Call GridInit()
        Common.DrawRowIndicator(GV1)
    End Sub
#End Region


End Class
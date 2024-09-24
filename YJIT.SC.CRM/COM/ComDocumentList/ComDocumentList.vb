Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing
Imports YJIT.SC.UI
Imports DevExpress.XtraGrid.Views.Base

Public Class ComDocumentList
    Dim comdoc As ComDoc = New ComDoc()

#Region "=================GetConvertToDataset Function==========="
    Private Function GetConvertToDataSet(ByVal SearchType As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim IsSingleSearch As Boolean = False

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)

            Select Case SearchType.ToString.ToUpper
                Case "Search".ToString.ToUpper
                    YJSql.SqlBox("WG1", "ComDocumentList@Search")
                    YJSql.Params("DATE_FM", drMAIN("S_DATE_FM").ToString)
                    YJSql.Params("DATE_TO", drMAIN("S_DATE_TO").ToString)

                    YJSql.Params("DOC_TYPE", drMAIN("S_DOC_TYPE").ToString)
                    YJSql.Params("SEARCH_KEY_" & drMAIN("S_SEARCH_TYPE").ToString, drMAIN("S_SEARCH_TYPE").ToString)
                    YJSql.Params("SEARCH_KEY", drMAIN("S_SEARCH_KEY").ToString)
                    YJSql.Params("SCREEN", drMAIN("S_SCREEN").ToString)
                Case Else
                    Throw New Exception("No match type found. (GetConvertToDataSet)")
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function
#End Region

#Region "=================Client Function==========="
    Public Sub PopUpInit()
        Dim PopUp As New PopupBase
        PopUp.ItemAdd(Action.Other, "WG1_Download", "Download")
        PopUp.ItemAdd(Action.DeleteRow, "WG1_Delete", "Delete")
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", "&Export Excel")
        PopUp.PopUpInit(Me, WG1)
    End Sub

    Public Sub PopUpOnAfterClick(ByVal dr As DataRow)
        Dim key As String = dr("Key").ToString
        Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
        Dim fTarget As Object = Nothing
        'Dim svcType As String = GV1.GetFocusedRowCellValue("REQ_SVC").ToString.Substring(0, 1)
        Dim svcType As String = ""
        Dim hblNo As String = GV1.GetFocusedRowCellValue("HBL_NO").ToString
        Dim mblNo As String = GV1.GetFocusedRowCellValue("MBL_NO").ToString
        If GV1.GetFocusedRowCellValue("REQ_SVC").ToString = "" Then
            svcType = ""
        Else
            svcType = GV1.GetFocusedRowCellValue("REQ_SVC").ToString.Substring(0, 1)
        End If
        Select Case key
            Case "WG1_Download"
                If GV1.FocusedRowHandle >= 0 < GV1.RowCount Then
                    If GV1.GetFocusedRowCellValue("FILE_NM").ToString.Trim <> "" Then
                        Dim SaveFileDialog1 As SaveFileDialog = New SaveFileDialog()
                        SaveFileDialog1.FileName = GV1.GetFocusedRowCellValue("FILE_NM").ToString
                        SaveFileDialog1.Filter = "All files (*.*)|*.*"
                        SaveFileDialog1.ValidateNames = True
                        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK And SaveFileDialog1.FileName <> "" Then
                            Dim retD As New Dictionary(Of String, String)
                            retD = comdoc.DownLoadFile(GV1.GetFocusedRowCellValue("MNGT_NO").ToString & "_" & GV1.GetFocusedRowCellValue("SEQ").ToString, _
                                         GV1.GetFocusedRowCellValue("FILE_NM").ToString, _
                                         GV1.GetFocusedRowCellValue("FILE_PATH").ToString, _
                                         SaveFileDialog1.FileName)
                            If retD("TrxCode").ToString <> "Y" Then
                                MsgBoxLocalized(retD("TrxMsg").ToString, MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Error)
                            End If
                        End If
                    End If
                Else
                    MsgBoxLocalized("Please select the file to download.", MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Warning)
                End If
                'Case "SeaHouseMgt"
                '    fTarget = frmMain.NavigateTo("SeaHouseMgt")

                '    If fTarget IsNot Nothing Then
                '        fTarget.HBL_NO.Text = hblNo
                '        fTarget.SearchData()
                '    End If
        End Select
    End Sub

    Public Sub MenuListBeforeShow(ByRef param As Dictionary(Of String, Boolean))
        'If GV1.GetFocusedRowCellValue("REQ_SVC").ToString <> "" Then
        '    param("SeaHouseMgt") = True
        '    param("SeaMasterMgt") = True
        'Else
        '    param("SeaHouseMgt") = False
        '    param("SeaMasterMgt") = False
        'End If
    End Sub
#End Region

#Region "=================Data logic actions================="
    Public Sub SearchData()
        Try
            If SearchValidate() = False Then Exit Sub

            Dim dsRet As DataSet = GetConvertToDataSet("Search")

            dsRet = MethodCallEx(Me, "YJIT.Biz.ComDocumentList", "Search", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Call ClearView(AppliedRangeTypes.Only, {WG1})
                    Me.BindToDataset(dsRet, "Data")
                    Me.DataState = UI.DataStates.None
                Case "N"
                    Call ClearView(AppliedRangeTypes.Only, {WG1})
                    MsgBoxLocalized(drPairs("TrxMsg"))
                    Me.DataState = UI.DataStates.None
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
            If String.IsNullOrEmpty(S_DATE_FM.Text.ToString) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = S_DATE_TYPE
                ErrMsg &= "Please input the [" & S_DATE_TYPE.SelectedValue & "]" & vbNewLine
            ElseIf String.IsNullOrEmpty(S_DATE_TO.Text.ToString) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = S_DATE_TYPE
                ErrMsg &= "Please input the [" & S_DATE_TYPE.SelectedValue & "]" & vbNewLine
            End If


            'If String.IsNullOrEmpty(S_CUST_CD.Text.ToString) Then
            '    'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
            '    If ErrControl Is Nothing Then ErrControl = S_CUST_CD
            '    ErrMsg &= "Please input the [" & lbl_S_CUST_CD.Text & "]" & vbNewLine
            'End If


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


    Public Sub DeleteData()

        If DeleteValidate() = False Then Exit Sub

        If MsgBoxLocalized("Do you want to delete?", MessageBoxButtons.YesNo, "Confirm", MessageBoxIcon.Question) = MsgBoxResult.No Then Exit Sub

        Dim dsRet As DataSet = GetConvertToDataSet("Search")
        dsRet.Tables.Add(Me.ConvertToDataset.Tables("MAIN").Copy)
        dsRet.Tables("MAIN").Columns.Add("UploadPath")
        dsRet.Tables("MAIN").Rows(0)("UploadPath") = comdoc.getUploadPath()
        dsRet.Tables.Add(Me.ConvertToDataset.Tables("WG1").Copy)

        dsRet = MethodCallEx(Me, "YJIT.Biz.ComDocumentList", "Delete", dsRet)

        Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") = "Y" Then
            Call ClearView(AppliedRangeTypes.Only, {WG1})
            Me.BindToDataset(dsRet, "Data")
            Me.DataState = UI.DataStates.Retrieved
        End If

        MsgBoxLocalized(dr("TrxMsg"))

    End Sub
    Private Function DeleteValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

        Try
            'If String.IsNullOrEmpty(COMN_CD.Text.ToString) Then
            '    'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
            '    If ErrControl Is Nothing Then ErrControl = COMN_CD
            '    ErrMsg &= "Please input the [" & lbl_COMN_CD.Text & "]" & vbNewLine
            'End If


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
#End Region

#Region "=================Control Events================="
    Private Sub ComDocumentList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComDocumentList_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Call initDefault()
        Call PopUpInit()
        Call DrawRowIndicator({GV1})
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearView(UI.AppliedRangeTypes.All)
        Call initDefault()
    End Sub

    Private Sub initDefault()
        S_INS_USR.DataParams = "Type:'',Office:'" & ClientSessionInfo.OfficeCode & "'"
        S_DATE_TYPE.SelectedValue = "REG"
        S_DATE_FM.Text = DateAdd(DateInterval.Day, -7, Now).ToString("yyyyMMdd")
        S_DATE_TO.Text = Now.ToString("yyyyMMdd")
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Call DeleteData()
    End Sub

    Private Sub GV1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GV1.DoubleClick
        Dim strMessage As String = ""

        If GV1.FocusedRowHandle < 0 Then
            Exit Sub
        End If

        Try
            If (GV1.FocusedColumn.FieldName = "FILE_NM" Or GV1.FocusedColumn.FieldName = "FILE_ICON") And GV1.RowCount > 0 Then
                Dim retD As New Dictionary(Of String, String)
                If GV1.GetFocusedRowCellValue("FILE_NM").ToString.Trim <> "" Then
                    retD = comdoc.DownLoadFile(GV1.GetFocusedRowCellValue("MNGT_NO").ToString & "_" & GV1.GetFocusedRowCellValue("SEQ").ToString, _
                                        GV1.GetFocusedRowCellValue("FILE_NM").ToString, _
                                        GV1.GetFocusedRowCellValue("FILE_PATH").ToString, "")
                    If retD("TrxCode").ToString = "Y" Then
                        'Microsoft.VisualBasic.Shell("explorer " & retD("FullName").ToString, AppWinStyle.NormalFocus)
                        Dim p As New System.Diagnostics.Process
                        Dim s As New System.Diagnostics.ProcessStartInfo(retD("FullName").ToString)
                        s.UseShellExecute = True
                        s.WindowStyle = ProcessWindowStyle.Normal
                        p.StartInfo = s
                        p.Start()
                    Else
                        MsgBoxLocalized(retD("TrxMsg"), MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Error)
                    End If
                End If
            End If
        Catch ex As Exception
            'MsgBoxLocalized(strMessage & " " & ex.Message, MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GV1_CustomColumnDisplayText(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GV1.CustomColumnDisplayText
        Dim view As ColumnView = TryCast(sender, ColumnView)
        If e.Column.FieldName = "FILE_SIZE" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
            If String.IsNullOrEmpty(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "FILE_SIZE").ToString) Then
                e.DisplayText = "0KB"
            Else
                Dim fileSize As Decimal = CDec(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "FILE_SIZE"))
                e.DisplayText = String.Format("{0:N0}KB", fileSize / 1024)
            End If
        End If
    End Sub
#End Region


End Class
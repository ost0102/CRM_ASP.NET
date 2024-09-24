Imports System.Drawing
Imports System.Drawing.Icon
Imports YJIT.SC.UI
Imports Microsoft.VisualBasic
Imports System.IO
Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Collections.Specialized
Imports DevExpress.XtraGrid.Views.Base

Public Class CrmAsInputDev

    Public frmMain As YJIT.SC.UI.IMainForm = Nothing
    Dim BindPic As String = ""
    Dim BindTel As String = ""
    Private bSortEnable As Boolean = True
    Private comdoc As ComDoc
    Private KeyDownYn As Boolean = False

    Dim UserInfoDt As DataTable = Nothing

    Dim ShownFlag As Boolean = False 

#Region "=================Data logic actions==========="
    Private Function GetConvertToDataSet(ByVal KEY As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
            Select Case KEY 
                Case "CrmUserInfo"
                    YJSql.SqlBox("CrmUserInfo", "CrmAsMgtDev@CrmUserInfo", True)
            End Select 
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function

    Public Function YJQuerySearch(ByVal key As String) As DataSet

        Dim ParamDsRet As DataSet = GetConvertToDataSet(key)
        Dim dsRet As DataSet = Nothing
        Try
            dsRet = MethodCallEx(Me, "YJIT.Biz.YJQuery", "Search", {ParamDsRet}) 
        Catch ex As Exception

        End Try
        Return dsRet
    End Function


    Public Sub NewData()
        Me.ClearView(UI.AppliedRangeTypes.Except, {PROC_TYPE, PRIORITY, SCREEN, DirList, WORK_USR, AS_WORK_USR})
        REQ_YMD.Text = Now.ToString("yyyyMMdd")
        REQ_HM.Text = Now.ToString("HHmm")
        'REQ_YMD.Text = "신규" 
        SetView("02")
        DEPT_CD.SelectedValue = ClientSessionInfo.OrganizationCode
        DEPT_CD.Focus()
    End Sub
    Private Sub InitGrid()
        Dim editorCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)
        SetMandatoryLine(Me) 
        Dim editorImgCombo As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox = comdoc.getImageComboBox()
        editorImgCombo.SmallImages = comdoc.getIcons()
        GV2.Columns("FILE_ICON").ColumnEdit = editorImgCombo

        GV2.Columns("SUCCESS").ColumnEdit = editorImgCombo

    End Sub
    Private Sub InitIcons()
        For i = 0 To GV2.RowCount - 1
            If Not comdoc.IsContainExtension(GV2.GetRowCellValue(i, "FILE_ICON").ToString) And GV2.GetRowCellValue(i, "FILE_NM").ToString <> "" Then
                GV2.SetRowCellValue(i, "FILE_ICON", "dft")
            End If
            GV2.SetRowCellValue(i, "UPLOAD", "UPLOAD")
        Next
        'Me.DataState = DataStates.Retrieve
    End Sub
    Public Sub PopUpOnAfterClick(ByVal dr As DataRow)
        Dim key As String = dr("Key").ToString
        Select Case key
            Case "WG2_Download"
                If GV2.FocusedRowHandle >= 0 < GV2.RowCount AndAlso GV2.GetFocusedRowCellValue("SUCCESS").ToString() <> "N" Then
                    If GV2.GetFocusedRowCellValue("FILE_NM").ToString.Trim <> "" Then
                        SaveFileDialog1.FileName = GV2.GetFocusedRowCellValue("FILE_NM").ToString
                        SaveFileDialog1.Filter = "All files (*.*)|*.*"
                        SaveFileDialog1.ValidateNames = True
                        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK And SaveFileDialog1.FileName <> "" Then
                            Dim retD As New Dictionary(Of String, String)
                            retD = comdoc.DownLoadFile(GV2.GetFocusedRowCellValue("MNGT_NO").ToString & "_" & GV2.GetFocusedRowCellValue("SEQ").ToString, _
                                         GV2.GetFocusedRowCellValue("FILE_NM").ToString, _
                                         GV2.GetFocusedRowCellValue("FILE_PATH").ToString, _
                                         SaveFileDialog1.FileName)
                            If retD("TrxCode").ToString <> "Y" Then
                                MsgBoxLocalized(retD("TrxMsg").ToString, MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Error)
                            End If
                        End If
                    End If
                Else
                    MsgBoxLocalized("File is not selected or file size is exceeded.", MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Warning)
                End If


        End Select
    End Sub
    Public Sub PopUpInit()
        Dim PopUp As New PopupBase

        PopUp.ItemAdd(Action.Addrow, "WG2_AddRow", "&Add Row")
        PopUp.ItemAdd(Action.DeleteRow, "WG2_DeleteRow", "&Delete Row")
        PopUp.ItemAdd(Action.Other, "WG2_Download", "Download", True)
        PopUp.PopUpInit(Me, WG2, "DOC_TYPE", "DOC_NO")

    End Sub

    Private Sub SetUserList(ByVal sender As Object, ByVal Dept_Cd As String)
        Dim dt As New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        Try
            Dim Drs() As DataRow = UserInfoDt.Select("DEPT_CD ='" & DEPT_CD & "'")
            If Drs.Length > 0 Then
                dt = Drs.CopyToDataTable
                dt.Columns("DEPT_CD").ColumnName = "CODE"
                dt.Columns("LOC_NM").ColumnName = "NAME"
            End If
            Dim bindingSourceProduct As BindingSource
            bindingSourceProduct = New BindingSource()
            bindingSourceProduct.DataSource = dt
            sender.Properties.DataSource = bindingSourceProduct.DataSource
            sender.Properties.ValueMember = "CODE"
            sender.Properties.DisplayMember = "NAME"
            sender.Properties.NullText = String.Empty
            sender.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
            sender.Properties.SeparatorChar = ";"

        Catch ex As Exception

        End Try
    End Sub
    Private Sub InitData()

        Dim searchParams = New Dictionary(Of String, Object)
        Dim dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "C03")
        dataParams.Add("NameType", "")
        DEPT_CD.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        DEPT_CD.DefVal = ClientSessionInfo.OrganizationCode

        Try
            Dim ds As DataSet = YJQuerySearch("CrmUserInfo")
            ds = AdaptDataSourceForReport(ds)
            If ds.Tables.Contains("CrmUserInfo") Then
                UserInfoDt = ds.Tables("CrmUserInfo")
            End If
        Catch ex As Exception

        End Try 

    End Sub
    Private Sub SearchCustomer()

        CUST_NM.Text = ""
        REQ_USR.Text = ""
        TEL_NO.Text = ""

        Dim ds As DataSet = Nothing
        Dim dr As DataRow = Nothing

        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgt", "SearchCustomer", Me.ConvertToDataset)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") = "M" Then
            Call SetCustByList(ds)
            Exit Sub
        End If

        If dr("TrxCode").ToString <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg").ToString, MessageBoxButtons.OK, "Warning", MessageBoxIcon.Warning)
            Exit Sub
        Else
            CUST_CD.Text = dr("CUST_CD").ToString
            CUST_NM.Text = dr("CUST_NM").ToString
            TEL_NO.Text = dr("TEL_NO").ToString
        End If

    End Sub

    Public Sub SaveData()

        If MandatoryGridValue("GV2") Then Exit Sub

        If REQ_TYPE.SelectedValue.ToString = "" Then
            MsgBoxLocalized("요청사항 구분을 선택하세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            REQ_TYPE.Focus()
            Exit Sub
        End If

        Dim byteUploadFiles()() As Byte = comdoc.byteUploadFiles
        Dim tempFolder As String = comdoc.getTempFolder
        Dim strFileName As String = ""

        Dim dsResult As DataSet
        Try
            For i As Integer = 0 To GV2.RowCount - 1
                GV2.SetRowCellValue(i, "SEQ", comdoc.GetSeq(i, AS_MNGT_NO.Text))
            Next
            comdoc.SetUploadPath(Split(DirList.Text, "/"))

            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgt", "SaveInput", {Me.ConvertToDataset, comdoc.getUploadPath})
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow
        dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") = "Y" Then
            Dim dt As DataTable = dsResult.Tables("Data.WG2")

            For i As Integer = 0 To dt.Rows.Count - 1
                AS_MNGT_NO.Text = dt.Rows(i)("MNGT_NO").ToString

                Dim strSeq As String = dt.Rows(i)("SEQ").ToString
                strFileName = tempFolder & "\" & comdoc.removeSpecialChars(AS_MNGT_NO.Text) & "_" & strSeq & "_" & dt.Rows(i)("FILE_NM").ToString

                Try
                    Dim rowNumber As Integer = Integer.Parse(dt.Rows(i)("SEQ"))

                    'if directory doesn't exist
                    If Not Directory.Exists(tempFolder) Then
                        Directory.CreateDirectory(tempFolder)
                    End If

                    'if the file is changed, following actions can be done
                    If byteUploadFiles(rowNumber) IsNot Nothing AndAlso dt.Rows(i)("SUCCESS").ToString() = "Y" Then
                        File.WriteAllBytes(strFileName, byteUploadFiles(rowNumber))
                        If Not FileUpload(strFileName, dt.Rows(i)("FILE_PATH").ToString()) Then
                            Throw New Exception("Couldn't upload file!")
                        End If
                        If System.IO.File.Exists(strFileName) Then
                            System.IO.File.Delete(strFileName)
                        End If
                    End If
                Catch ex As Exception
                    dr("TrxMsg") = ex.ToString
                    dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.ComDocumentMgt", "Delete", {AS_MNGT_NO.Text, strSeq})
                End Try
            Next
            'Me.DataState = UI.DataStates.Retrieved

            'Dim fTarget As Object = frmMain.NavigateTo("CrmAsMgt")
            'If Not IsNothing(fTarget) Then
            '    fTarget.SearchDataOld(MNGT_NO.Text)

            '    If dsResult.Tables.Contains("Data.UserList") Then
            '        dt = dsResult.Tables("Data.UserList")
            '        For i = 0 To dt.Rows.Count - 1

            '            If dt.Rows(i)("USR_ID").ToString.Contains("LBH") Or dt.Rows(i)("USR_ID").ToString.Contains("SWCHO") Then
            '                If dt.Rows(i)("FLAG").ToString = "I" Then
            '                    ' MsgBoxLocalized("전송 시도합니다.   " & dt.Rows(i)("USR_ID").ToString)
            '                    frmClient.PushToUserMsg(dt.Rows(i)("USR_ID").ToString, "", dt.Rows(i)("USR_ID").ToString & "님 앞으로 새글이 등록 되었습니다.", Nothing)
            '                ElseIf dt.Rows(i)("FLAG").ToString = "U" Then
            '                    'frmClient.PushToUserMsg(dt.Rows(i)("USR_ID").ToString, "", dt.Rows(i)("USR_ID").ToString & "님 앞으로 새글이 등록 되었습니다.", Nothing)
            '                ElseIf dt.Rows(i)("FLAG").ToString = "D" Then

            '                End If
            '            End If
            '        Next
            '    End If

            '    Me.Close()
            'End If
        Else
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub

    Public Sub SetView(ByVal Dept_Type As String)
        If Dept_Type = "02" Then
            DevDeptListPanel.Visible = True
            OhterDeptListPanel.Visible = False 
        Else
            DevDeptListPanel.Visible = False
            OhterDeptListPanel.Visible = True
        End If
    End Sub
    Public Sub SearchData()
        Dim ds As DataSet = Me.ConvertToDataset

        YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.CrmAsMgtDev", "SearchInput", Me.ConvertToDataset, AddressOf SearchOnComplete)
    End Sub

    Private Sub SearchOnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Try
            If IsNothing(e.Result) Then
                Throw New Exception("Try Again!")
            End If

            Dim retDs As DataSet = e.Result
            Dim dr As DataRow = retDs.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                Exit Sub
            End If
            If dr("TrxCode") <> "Y" Then
                Me.ClearView(AppliedRangeTypes.Only, {WG2})
                If KeyDownYn = False Then
                    MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Information)
                Else
                    Call Wg2AddRow()
                End If
                KeyDownYn = False
                Exit Sub
            End If
            Me.BindToDataset(retDs, "Data")
            SetView(DEPT_CD.SelectedValue)
            Call InitIcons()
            AS_REQ_USR.Select()
             
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Sub setGridAddRow(ByVal obj As YJIT.SC.UI.SCControls.WebGrid)
        Dim GvAddRow As New DataTable
        Dim dr As DataRow
        GvAddRow.Columns.Add("Key")
        GvAddRow.Columns.Add("Sender")
        GvAddRow.Columns.Add("Action", GetType(Action))
        GvAddRow.Rows.Add()
        dr = GvAddRow.Rows(0)

        dr("Sender") = obj.Name
        dr("Key") = obj.Name + "_AddRow"
        dr("Action") = Action.Addrow
        obj.AddRow()

        'PopUpOnAfterClick(GvAddRow.Rows(0))

    End Sub
    Private Sub Wg2AddRow()

        If GV2.RowCount = 0 Then Call setGridAddRow(WG2)
        WG2.Focus()
        GV2.ShowEditor()
        GV2.FocusedColumn = GV2.Columns("DOC_TYPE")

    End Sub

    Public Function MandatoryGridValue(ByVal gridView As String) As Boolean
        Dim Param As New Dictionary(Of String, Object)
        Dim checkNull() As String = Nothing

        Select Case gridView
            Case "GV2"
                checkNull = {"FILE_NM"}
                'Param("FILE_NM") = GV2_FILE_NM.Caption

                Return ValidateGridValue(GV2, Param, checkNull)
        End Select

        Return True

    End Function


    Private Sub SetCustByList(ByVal ds As DataSet)

        PanelControl2.Controls.Add(CUST_LIST)
        CUST_LIST.Location = New Size(CUST_CD.Location.X, CUST_CD.Location.Y + 1)
        CUST_CD.BringToFront()

        CUST_LIST.EditValue = ""
        CUST_LIST.DataBindings.Clear()
        CUST_LIST.Properties.DataSource = Nothing

        CUST_LIST.Properties.DataSource = ds.Tables("Data.CUST_LIST")
        CUST_LIST.Properties.DisplayMember = "CUST_LOC_NM"
        CUST_LIST.Properties.ValueMember = "CUST_CD"
        CUST_LIST.EditValue = Nothing
        CUST_LIST.ShowPopup()
        CUST_LIST.Focus()

    End Sub
#End Region

#Region "=================Control Events==========="
    Private Sub CrmAsInput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call NewData()
    End Sub

    Private Sub CrmAsInput_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Call PopUpInit()
        InitData()
        comdoc = New ComDoc(WG2)
        'AddHandler ttc.GetActiveObjectInfo, New DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(AddressOf ttc_GetActiveObjectInfo)
        Call InitGrid()
        SplitContainerControl1_SplitterPositionChanged(Nothing, Nothing)
        ShownFlag = False
        SetUserList(WORK_USR, "02")
        SetUserList(AS_WORK_USR, "02")
        WG2.AddRow() 
    End Sub

    Private Sub CONTENT_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AS_CONTENT.Enter
        AS_CONTENT.SelectionStart = Len(AS_CONTENT.Text)
    End Sub



    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveData()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub ClosePreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs)
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        NewData()
    End Sub

    Private Sub PROC_TYPE_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs)
        If e.KeyCode = Keys.Space Then
            PROC_TYPE.DroppedDown = True
        End If
    End Sub
    Private Sub GV2_CustomColumnDisplayText(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GV2.CustomColumnDisplayText
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
    'Slip List (Summary) Band Header 에 Sort Image 넣기
    Private Sub GV2_CustomDrawBandHeader(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.BandedGrid.BandHeaderCustomDrawEventArgs) Handles GV2.CustomDrawBandHeader
        Dim skin As DevExpress.Skins.Skin = DevExpress.Skins.GridSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default)
        Dim element As DevExpress.Skins.SkinElement = skin(DevExpress.Skins.GridSkins.SkinSortShape)
        GV2.Images = element.Image.GetImages()
    End Sub
    'Slip List (Summary) MouseDown (Sort)
    Private Sub GV2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GV2.MouseDown
        Dim gv As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView = GV2
        Dim hitInfo As DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitInfo = gv.CalcHitInfo(e.Location)

        If hitInfo.InBandPanel Then
            If hitInfo.HitTest = DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitTest.BandEdge Then  '경계선 클릭시 Sort를 무효화 한다.
                bSortEnable = False
            Else
                bSortEnable = True
            End If
        End If
    End Sub    'Slip List (Summary) MouseUp (Sort)
    Private Sub GV2_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GV2.MouseUp
        If bSortEnable = False Then Exit Sub 'MouseDown Event에서 경계선을 클릭한 경우 Sort를 하지 않음

        'Band Click시 해당 컬럼 Sort (상위밴드 클릭시에는 Sort하지 않는다)
        Dim gv As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView = GV2

        Dim hitInfo As DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitInfo = gv.CalcHitInfo(e.Location)
        Dim sortFlag As Integer

        If hitInfo.InBandPanel Then
            If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
            If hitInfo.HitTest = DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitTest.BandEdge Then Exit Sub
            If hitInfo.Band Is Nothing Then Exit Sub
            If hitInfo.Band.Columns.VisibleColumnCount <= 0 Then Exit Sub

            sortFlag = hitInfo.Band.Columns(0).SortOrder
            gv.ClearSorting()   'Sort Clear.

            '해당 스킨의 이미지를 가져온다
            Dim skin As DevExpress.Skins.Skin = DevExpress.Skins.GridSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default)
            Dim element As DevExpress.Skins.SkinElement = skin(DevExpress.Skins.GridSkins.SkinSortShape)
            gv.Images = element.Image.GetImages()

            'Sort Image 초기화(기존에 그려진 Sort 화살표를 없앤다)
            For Each band As DevExpress.XtraGrid.Views.BandedGrid.GridBand In gv.Bands
                band.ImageIndex = -1

                'Band Children Sort Image 초기화
                If band.Children.Count > 0 Then
                    For i As Integer = 0 To band.Children.Count - 1
                        band.Children(i).ImageIndex = -1
                    Next
                End If
            Next

            If sortFlag = DevExpress.Data.ColumnSortOrder.Ascending Then
                hitInfo.Band.ImageIndex = 0
                hitInfo.Band.ImageAlignment = System.Drawing.StringAlignment.Far    'Image 오른쪽 정렬
                hitInfo.Band.Columns(0).SortOrder = DevExpress.Data.ColumnSortOrder.Descending
            Else
                hitInfo.Band.ImageIndex = 1
                hitInfo.Band.ImageAlignment = System.Drawing.StringAlignment.Far    'Image 오른쪽 정렬
                hitInfo.Band.Columns(0).SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            End If

        End If
    End Sub
#End Region

    Private Sub PIC_LIST_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUST_PIC_LIST.EditValueChanged
        If CUST_PIC_LIST.EditValue = "" Then Exit Sub
        REQ_USR.Text = CUST_PIC_LIST.EditValue
        TEL_NO.Text = CUST_PIC_LIST.GetColumnValue("TEL_NO")
        TEL_NO.Select()
    End Sub

    Private Sub SetCustPicByList(ByVal ds As DataSet)

        DevDeptListPanel.Controls.Add(CUST_PIC_LIST)
        CUST_PIC_LIST.Location = New Size(REQ_USR.Location.X, REQ_USR.Location.Y + 1)
        REQ_USR.BringToFront()

        CUST_PIC_LIST.EditValue = ""
        CUST_PIC_LIST.DataBindings.Clear()
        CUST_PIC_LIST.Properties.DataSource = Nothing

        CUST_PIC_LIST.Properties.DataSource = ds.Tables("Data.CUST_PIC_LIST")
        CUST_PIC_LIST.Properties.DisplayMember = "TEL_NO"
        CUST_PIC_LIST.Properties.ValueMember = "PIC_NM"
        CUST_PIC_LIST.EditValue = Nothing
        CUST_PIC_LIST.ShowPopup()
        CUST_PIC_LIST.Focus()

    End Sub

    Private Sub SearchCustomerPic()

        Dim ds As DataSet = Nothing
        Dim dr As DataRow = Nothing

        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgt", "SearchCustomerPic", Me.ConvertToDataset)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") = "M" Then

            Call SetCustPicByList(ds)
            Exit Sub
        End If
        If dr("TrxCode").ToString <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg").ToString, MessageBoxButtons.OK, "Warning", MessageBoxIcon.Warning)
            REQ_USR.NextFocus = "TEL_NO"
            '   Exit Sub
        Else
            REQ_USR.Text = dr("PIC_NM").ToString
            ' 담당자의 전화번호가 없는 경우 포커스는 이동하되 빈 값으로 넘어가지 않도록 수정
            If dr("TEL_NO").ToString <> "" Then
                TEL_NO.Text = dr("TEL_NO").ToString
                REQ_USR.NextFocus = "CONTENT"
            Else
                REQ_USR.NextFocus = "TEL_NO"
            End If

        End If

    End Sub


    Private Sub REQ_USR_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles REQ_USR.PreviewKeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And (REQ_USR.Text <> OLD_REQ_USR.Text) Then
            Call SearchCustomerPic()

        ElseIf (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) Then
            REQ_USR.NextFocus = "TEL_NO"
        End If
    End Sub


    Private Sub PRIORITY_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles REQ_TYPE.KeyUp, PROC_TYPE.KeyUp, PRIORITY.KeyUp
        If ShownFlag = True Then
            Exit Sub
        End If
        Dim dt As DataTable = sender.DataSource
        If dt Is Nothing Then Exit Sub

        Dim t As String = sender.Text
        If t.Contains(".") Then
            Dim k As String = t.ToString.Substring(0, t.IndexOf("."))
            Dim dr() As DataRow = dt.Select("code = '" & k & "'")
            If dr.Length > 0 Then
                sender.SelectedValue = dr(0)("CODE").ToString
            End If 
        End If 
    End Sub

    Private Sub REQ_TYPE_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REQ_TYPE.Leave, PROC_TYPE.Leave, PRIORITY.Leave
        If ShownFlag = True Then
            Exit Sub
        End If
        Dim dt As DataTable = sender.DataSource
        If dt Is Nothing Then Exit Sub
        Dim t As String = sender.Text
        If t.Contains(".") = False Then  
            Dim dr() As DataRow = dt.Select("code = '" & sender.Text & "'")
            If dr.Length > 0 Then
                sender.SelectedValue = dr(0)("CODE").ToString
            End If
        End If
    End Sub


    Private Sub CUST_CD_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CUST_CD.PreviewKeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And (CUST_CD.Text <> OLD_CUST_CD.Text) Then
            Call SearchCustomer()
        End If
    End Sub
     
    Private Sub CUST_LIST_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SplitContainerControl1_SplitterPositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SplitContainerControl1.SplitterPositionChanged
        If SplitContainerControl1.SplitterPosition <= 328 Then
            REQ_YMD.NextFocus = "CUST_CD"
        Else
            REQ_YMD.NextFocus = "REQ_HM"
        End If
    End Sub
End Class
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

#Region "=================Data logic actions==========="
    Public Sub NewData()
        Me.ClearView(UI.AppliedRangeTypes.Except, {REQ_SVC, PROC_TYPE, PRIORITY, SCREEN, DirList})

        SYS_ID.Text = "CRM"
        CONTENT.ReadOnly = False

        REQ_YMD.Text = Now.ToString("yyyyMMdd")
        REQ_HM.Text = Now.ToString("HHmm")
        ' WORK_USR.Text = ClientSessionInfo.LocalName
        REQ_YMD.Select()


    End Sub
    Private Sub InitGrid()
        Dim editorCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)
        SetMandatoryLine(Me)

        '==================Grid1============================
        'editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        'editorCombo.DisplayMember = "NAME"
        'editorCombo.ValueMember = "CODE"
        'editorCombo.NullText = "--Select--"
        'searchParams = New Dictionary(Of String, Object)
        'dataParams = New Dictionary(Of String, Object)
        'dataParams.Add("GroupCode", "M33")
        'dataParams.Add("NameType", "")
        'editorCombo.ShowHeader = False
        'editorCombo.ReadOnly = False
        'editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        'GV2.Columns("DOC_TYPE").ColumnEdit = editorCombo

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
        Me.DataState = DataStates.Retrieved
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
        'REQ_USR.Select()


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

    Private Sub SetCustPicByList(ByVal ds As DataSet)

        PanelControl2.Controls.Add(CUST_PIC_LIST)
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


    Public Sub SaveData()

        If MandatoryGridValue("GV2") Then Exit Sub

        If REQ_TYPE.SelectedValue.ToString = "" Then
            MsgBoxLocalized("요청사항 구분을 선택하세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            REQ_TYPE.Focus()
            Exit Sub
        End If


        If (PROC_TYPE.SelectedValue = "1" OrElse PROC_TYPE.SelectedValue = "2") Then
            If SYS_ID.Text.ToUpper <> "CRM" _
                       AndAlso String.IsNullOrEmpty(CMPT_RMK.Text) Then
                xtcRemark.SelectedTabPage = xtpCMPT_RMK
                MsgBoxLocalized("답변 입력후 저장하세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                CMPT_RMK.Focus()
                Exit Sub
            End If
        End If


        Dim byteUploadFiles()() As Byte = comdoc.byteUploadFiles
        Dim tempFolder As String = comdoc.getTempFolder
        Dim strFileName As String = ""

        Dim dsResult As DataSet
        Try
            For i As Integer = 0 To GV2.RowCount - 1
                GV2.SetRowCellValue(i, "SEQ", comdoc.GetSeq(i, MNGT_NO.Text))
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
                MNGT_NO.Text = dt.Rows(i)("MNGT_NO").ToString

                Dim strSeq As String = dt.Rows(i)("SEQ").ToString
                strFileName = tempFolder & "\" & comdoc.removeSpecialChars(MNGT_NO.Text) & "_" & strSeq & "_" & dt.Rows(i)("FILE_NM").ToString

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
                    dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.ComDocumentMgt", "Delete", {MNGT_NO.Text, strSeq})
                End Try
            Next
            Me.DataState = UI.DataStates.Retrieved

            Dim fTarget As Object = frmMain.NavigateTo("CrmAsMgt")
            If Not IsNothing(fTarget) Then
                fTarget.SearchDataOld(MNGT_NO.Text)

                If dsResult.Tables.Contains("Data.UserList") Then
                    dt = dsResult.Tables("Data.UserList")
                    For i = 0 To dt.Rows.Count - 1

                        If dt.Rows(i)("USR_ID").ToString.Contains("LBH") Or dt.Rows(i)("USR_ID").ToString.Contains("SWCHO") Then
                            If dt.Rows(i)("FLAG").ToString = "I" Then
                                ' MsgBoxLocalized("전송 시도합니다.   " & dt.Rows(i)("USR_ID").ToString)
                                frmClient.PushToUserMsg(dt.Rows(i)("USR_ID").ToString, "", dt.Rows(i)("USR_ID").ToString & "님 앞으로 새글이 등록 되었습니다.", Nothing)
                            ElseIf dt.Rows(i)("FLAG").ToString = "U" Then
                                'frmClient.PushToUserMsg(dt.Rows(i)("USR_ID").ToString, "", dt.Rows(i)("USR_ID").ToString & "님 앞으로 새글이 등록 되었습니다.", Nothing)
                            ElseIf dt.Rows(i)("FLAG").ToString = "D" Then

                            End If
                        End If
                    Next
                End If

                Me.Close()
            End If
        Else
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub

    Public Sub SearchData()
        YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.CrmAsMgt", "SearchInput", Me.ConvertToDataset, AddressOf SearchOnComplete)
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

            If SYS_ID.Text.ToUpper = "CRM" Then
                CONTENT.ReadOnly = False
            Else
                CONTENT.ReadOnly = True
            End If

            Call InitIcons()
            REQ_USR.Select()

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
#End Region

#Region "=================Control Events==========="
   
    Private Sub CONTENT_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONTENT.Enter
        CONTENT.SelectionStart = Len(CONTENT.Text)
    End Sub

    'Private Sub CONTENT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CONTENT.KeyPress

    '    If (Split(sender.Text.Substring(0, sender.SelectionStart), vbNewLine).Length > 3) And AscW(e.KeyChar) = Keys.Enter Then
    '        e.KeyChar = String.Empty
    '        PROC_TYPE.Focus()
    '    End If

    'End Sub

    Private Sub RMK_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RMK.Enter
        RMK.SelectionStart = Len(RMK.Text)
    End Sub

    'Private Sub RMK_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RMK.KeyPress
    '    If (Split(sender.Text.Substring(0, sender.SelectionStart), vbNewLine).Length > 3) And AscW(e.KeyChar) = Keys.Enter Then
    '        e.KeyChar = String.Empty
    '        btnSave.Focus()
    '    End If

    'End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveData()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub CUST_CD_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CUST_CD.PreviewKeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And (CUST_CD.Text <> OLD_CUST_CD.Text) Then
            Call SearchCustomer()
        End If
    End Sub
    Private Sub REQ_USR_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles REQ_USR.PreviewKeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And (REQ_USR.Text <> OLD_REQ_USR.Text) Then
            Call SearchCustomerPic()

        ElseIf (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) Then
            REQ_USR.NextFocus = "TEL_NO"
        End If
    End Sub

    Private Sub CUST_LIST_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUST_LIST.EditValueChanged
        If CUST_LIST.EditValue = "" Then Exit Sub
        CUST_CD.Text = CUST_LIST.EditValue
        Call SearchCustomer()
        REQ_USR.Select()
    End Sub

    Private Sub PIC_LIST_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUST_PIC_LIST.EditValueChanged
        If CUST_PIC_LIST.EditValue = "" Then Exit Sub
        REQ_USR.Text = CUST_PIC_LIST.EditValue
        'Dim dr As DataRowView = CUST_PIC_LIST.GetSelectedDataRow
        'Dim STR As String = CUST_PIC_LIST.SelectedText
        TEL_NO.Text = CUST_PIC_LIST.GetColumnValue("TEL_NO")

        'Call SearchCustomerPic()
        TEL_NO.Select()
    End Sub



    Private Sub AddhandlerFormClose()

        'AddHandler Panel1.PreviewKeyDown, AddressOf ClosePreviewKeyDown

        'For Each cntr In Panel1.Controls
        '    If cntr.GetType.FullName.Contains("YJIT.SC.UI.SCControls.TextBox") Then
        '        AddHandler CType(cntr, YJIT.SC.UI.SCControls.TextBox).PreviewKeyDown, AddressOf ClosePreviewKeyDown
        '    End If
        '    If cntr.GetType.FullName.Contains("YJIT.SC.UI.SCControls.ComboBox") Then
        '        AddHandler CType(cntr, YJIT.SC.UI.SCControls.ComboBox).PreviewKeyDown, AddressOf ClosePreviewKeyDown
        '    End If
        '    If cntr.GetType.FullName.Contains("YJIT.SC.UI.SCControls.DateBox") Then
        '        AddHandler CType(cntr, YJIT.SC.UI.SCControls.DateBox).PreviewKeyDown, AddressOf ClosePreviewKeyDown
        '    End If
        '    If cntr.GetType.FullName.Contains("YJIT.SC.UI.SCControls.MaskedTextBox") Then
        '        AddHandler CType(cntr, YJIT.SC.UI.SCControls.MaskedTextBox).PreviewKeyDown, AddressOf ClosePreviewKeyDown
        '    End If
        'Next
    End Sub

    Private Sub ClosePreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs)
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        NewData()
    End Sub

    Private Sub PROC_TYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PROC_TYPE.SelectedIndexChanged
        If PROC_TYPE.SelectedValue = "1" Or PROC_TYPE.SelectedValue = "2" Or PROC_TYPE.SelectedValue = "7" Or PROC_TYPE.SelectedValue = "8" Then
            WORK_USR.Text = ClientSessionInfo.LocalName
        ElseIf PROC_TYPE.SelectedValue = "7" Then
            CMPT_YMD.Text = ""
        Else
            CMPT_YMD.Text = ""
            WORK_USR.Text = ""
        End If
        If PROC_TYPE.SelectedValue = "1" Then
            CMPT_YMD.Text = Now.ToString("yyyyMMdd")
        End If
        If PROC_TYPE.SelectedValue = "2" Then
            CMPT_YMD.Text = Now.ToString("yyyyMMdd")
        End If
    End Sub
    Private Sub PRIORITY_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRIORITY.SelectedIndexChanged
        '3일때 내일처리, 4일때 일주일
        Select Case PRIORITY.SelectedValue
            Case "3"
                PRAR_YMD.Text = Now.AddDays(1).ToString("yyyyMMdd")
            Case "4"
                PRAR_YMD.Text = Now.AddDays(7).ToString("yyyyMMdd")
            Case Else
                PRAR_YMD.Text = ""
        End Select
    End Sub
    Private Sub REQ_SVC_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles REQ_SVC.PreviewKeyDown
        If e.KeyCode = Keys.Space Then
            REQ_SVC.DroppedDown = True
        End If
    End Sub

    Private Sub PROC_TYPE_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles PROC_TYPE.PreviewKeyDown
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
    Private Sub CrmAsInputDev_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Call PopUpInit()
        comdoc = New ComDoc(WG2)
        'AddHandler ttc.GetActiveObjectInfo, New DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(AddressOf ttc_GetActiveObjectInfo)
        Call InitGrid()

        AddhandlerFormClose()

        WG2.AddRow()

        SetEvent()

    End Sub

    Private Sub CrmAsInputDev_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call NewData()

    End Sub
     
    Private Sub SetEvent() 
        Try 
            SetEvent(Me.Controls)
        Catch ex As Exception

        End Try

        'For Each v In dic.Values
        '    Try 
        '        AddHandler CType(v, Control).MouseDown, AddressOf startDrag
        '        AddHandler CType(v, Control).MouseMove, AddressOf whileDragging
        '            AddHandler CType(v, Control).MouseUp, AddressOf endDrag 
        '    Catch ex As Exception

        '    End Try
        'Next
    End Sub
    Private Sub SetEvent(ByVal obj As Object)

        For Each cntr In obj
            Try
                ' dic(cntr.name) = cntr

                AddHandler CType(cntr, Control).MouseDown, AddressOf startDrag
                AddHandler CType(cntr, Control).MouseMove, AddressOf whileDragging
                AddHandler CType(cntr, Control).MouseUp, AddressOf endDrag

                Try
                    ''cntr.ReadOnly = True
                    'cntr.MaxDropDownItems = 0
                    'cntr.PopulateComboItems()
                    'cntr.ListCode()
                    ''cntr.Enabled = False
                Catch ex As Exception

                End Try
            Catch ex As Exception

            End Try

            Try
                SetEvent(cntr.Controls)
            Catch ex As Exception

            End Try
        Next
    End Sub
    Dim dragging As Boolean
    Dim startX As Integer
    Dim startY As Integer
    Private Sub startDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        dragging = True
        startX = e.X
        startY = e.Y
    End Sub
    Private Sub whileDragging(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If dragging = True Then
            sender.Location = New Point(sender.Location.X + e.X - startX, sender.Location.Y + e.Y - startY)
            Me.Refresh()
        End If
    End Sub
    Private Sub endDrag(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dragging = False
        My.Settings.controlLocations.Clear()
        For Each Control As Control In Me.Controls
            My.Settings.controlLocations.Add(Control.Name & "!" & Control.Location.X & "!" & Control.Location.Y)
        Next
        My.Settings.Save()
        My.Settings.Reset()
    End Sub


End Class
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

Public Class CrmAsInput_v1
    Private HotTrackRowValue As Integer = DevExpress.XtraGrid.GridControl.InvalidRowHandle
    Public frmMain As YJIT.SC.UI.IMainForm = Nothing
    Dim BindPic As String = ""
    Dim BindTel As String = ""
    Private bSortEnable As Boolean = True
    Private comdoc As ComDoc
    Private KeyDownYn As Boolean = False
    'Dim UserInfoDt As DataTable = Nothing
    Dim DeptDt As DataTable
    'Dim REQ_SVC2_dt As DataTable
    Dim ShownFlag As Boolean = True
    Dim SearchFlag As Boolean = False
#Region "=================Client Function==========="
    'Client Function : 클라이언트 동작 함수
    Private Sub AddNewRow(ByVal dt As DataTable, ByVal Code As String, ByVal Name As String)
        dt.Rows.Add()
        dt.Rows(dt.Rows.Count - 1)("CODE") = Code
        dt.Rows(dt.Rows.Count - 1)("NAME") = Name
    End Sub

    Private Sub InitGrid()
        Dim editorCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim editor As New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)
        Dim dt As DataTable
        Dim editorDate As YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit

        SetMandatoryLine(Me)

        '==================Grid1============================
        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        AddNewRow(dt, "C", "고객사")
        AddNewRow(dt, "A", "협력사")

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        GV1.Columns("CUST_TYPE").ColumnEdit = editorCombo


        editorDate = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
        GV1.Columns("INFO_YMD").ColumnEdit = editorDate
        GV1.Columns("STOP_YMD").ColumnEdit = editorDate


        '==================Grid2============================
        Dim editorImgCombo As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox = comdoc.getImageComboBox()
        editorImgCombo.SmallImages = comdoc.getIcons()
        GV2.Columns("FILE_ICON").ColumnEdit = editorImgCombo

        GV2.Columns("SUCCESS").ColumnEdit = editorImgCombo



        '==================Grid3============================
        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        AddNewRow(dt, "A", "설치업무")
        AddNewRow(dt, "B", "공통업무")
        AddNewRow(dt, "C", "ACCOUNT")
        AddNewRow(dt, "D", "AIR")
        AddNewRow(dt, "E", "OCEAN")
        AddNewRow(dt, "F", "인사급여")
        AddNewRow(dt, "G", "쿠리어")
        AddNewRow(dt, "H", "통관업무")
        AddNewRow(dt, "I", "운송업무")
        AddNewRow(dt, "J", "대리점")
        AddNewRow(dt, "K", "CFS")
        AddNewRow(dt, "L", "EDMS")
        AddNewRow(dt, "M", "WMS")
        AddNewRow(dt, "N", "영업")
        AddNewRow(dt, "O", "SCM")
        AddNewRow(dt, "Z", "ETC")

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV3.Columns("REQ_SVC").ColumnEdit = editorCombo

        '비용 내역 항목
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "T05")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV3.Columns("REQ_TYPE").ColumnEdit = editorCombo


        editor = New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        editor.CodeType = "YJIT.CodeService.Customer"
        editor.DisplayParams = "Code:#CUST_CD,CUST_LOCNM:#CUST_NM"
        editor.ValidateKeys = "KEY:#CUST_CD"
        editor.DataParams = "Type:''"
        editor.KeepIntegrity = True
        editor.AutoSuggestion = False
        editor.MaxLength = "10"
        editor.SearchPopup = "CustomerMaster"
        editor.CharacterCasing = CharacterCasing.Upper
        GV3.Columns("CUST_CD").ColumnEdit = editor


        editor = New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        editor.CodeType = "YJIT.CodeService.CustomerPic"
        editor.DisplayParams = "Code:#REQ_USR,Name:#TEL_NO"
        editor.ValidateKeys = "KEY:#REQ_USR"
        editor.DataParams = "Customer:@CUST_CD"
        editor.KeepIntegrity = False
        editor.AutoSuggestion = False
        editor.MaxLength = "10"
        editor.SearchPopup = "CodeMaster"
        editor.CharacterCasing = CharacterCasing.Normal
        GV3.Columns("REQ_USR").ColumnEdit = editor

        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        AddNewRow(dt, "0", "미확인")
        AddNewRow(dt, "7", "처리중")
        AddNewRow(dt, "1", "완료")
        AddNewRow(dt, "2", "즉시처리")
        AddNewRow(dt, "3", "재발신예정")
        AddNewRow(dt, "4", "재발신")
        AddNewRow(dt, "5", "수정요청")
        AddNewRow(dt, "6", "추가요청")
        AddNewRow(dt, "8", "보류")

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV3.Columns("PROC_TYPE").ColumnEdit = editorCombo

        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        AddNewRow(dt, "0", "매우급함")
        AddNewRow(dt, "1", "급함")
        AddNewRow(dt, "2", "당일처리")
        AddNewRow(dt, "3", "내일처리")
        AddNewRow(dt, "4", "일주일")

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV3.Columns("PRIORITY").ColumnEdit = editorCombo

        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        AddNewRow(dt, "Y", "무상")
        AddNewRow(dt, "N", "유상")

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV3.Columns("FREE_YN").ColumnEdit = editorCombo



        'GV4
        Dim dr As DataRow = Nothing
        dt = New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
                            AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("CRM_USR_MST") Then

            Dim drUser() As DataRow = Nothing
            drUser = YJIT.SC.UI.SCView.PreloadedCodeListData("CRM_USR_MST").Select("DEPT_CD ='02'", "SORT ASC ,LOC_NM ASC")
            For Each drRow As DataRow In drUser
                dr = dt.NewRow
                dr("CODE") = drRow("USR_ID").ToString
                dr("NAME") = dt.Rows.Count + 1 & "." & drRow("LOC_NM").ToString
                dt.Rows.Add(dr)
            Next
        End If

        dr = dt.NewRow
        dr("CODE") = ""
        dr("NAME") = "--Select--"
        dt.Rows.InsertAt(dr, 0)

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV4.Columns("USR_ID").ColumnEdit = editorCombo

        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "T07")
        dataParams.Add("NameType", "")
        Dim T07 As DataTable = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)

        'dr = T07.NewRow
        'dr("CODE") = ""
        'dr("NAME") = "--Select--"
        'T07.Rows.InsertAt(dr, 0)
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = T07
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV4.Columns("PROC_TYPE").ColumnEdit = editorCombo

        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "T08")
        dataParams.Add("NameType", "")
        Dim T08 As DataTable = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)

        'dr = T08.NewRow
        'dr("CODE") = ""
        'dr("NAME") = "--Select--"
        'T08.Rows.InsertAt(dr, 0)
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = T08
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV4.Columns("TEST_RESULT").ColumnEdit = editorCombo





        Common.DrawRowIndicator({GV3})
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

    Private Property HotTrackRow() As Integer
        Get
            Return HotTrackRowValue
        End Get

        Set(ByVal Value As Integer)
            If HotTrackRowValue <> Value Then
                Dim PrevHotTrackRow As Integer
                PrevHotTrackRow = HotTrackRowValue
                HotTrackRowValue = Value
                GV1.RefreshRow(PrevHotTrackRow)
                GV1.RefreshRow(HotTrackRowValue)
            End If
        End Set

    End Property

    Private Sub SetReqsvc2(ByVal Grp_Cd As String)
        Dim dt As New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        dt.Rows.Add({"", "--Select--"})

        If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
                AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_COM_CODE") Then

            Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD='T10' AND OPT_ITEM1 = '" & Grp_Cd & "'", "SORT ASC")
            If drMdm.Count > 0 Then
                For Each drRow As DataRow In drMdm
                    Dim dr As DataRow = dt.NewRow
                    dr("CODE") = drRow("COMN_CD").ToString
                    dr("NAME") = drRow("CD_NM").ToString
                    dt.Rows.Add(dr)
                Next
            End If
        End If
        REQ_SVC2.DataSource = dt
    End Sub
    Private Sub SetUserList(ByVal sender As Object, ByVal Dept_Cd As String)
        sender.EditValue = String.Empty

        Dim dt As New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        Try
            If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
                                AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("CRM_USR_MST") Then

                Dim drUser() As DataRow = Nothing
                If Dept_Cd = "ALL" Then
                    drUser = YJIT.SC.UI.SCView.PreloadedCodeListData("CRM_USR_MST").Select("1=1", "DEPT_CD ASC,SORT ASC ,LOC_NM ASC")
                Else
                    drUser = YJIT.SC.UI.SCView.PreloadedCodeListData("CRM_USR_MST").Select("DEPT_CD ='" & Dept_Cd & "'", "SORT ASC ,LOC_NM ASC")
                End If

                For Each drRow As DataRow In drUser
                    Dim dr As DataRow = dt.NewRow
                    dr("CODE") = drRow("USR_ID").ToString
                    dr("NAME") = dt.Rows.Count + 1 & "." & drRow("LOC_NM").ToString
                    dt.Rows.Add(dr)
                Next
            End If

            Dim bindingSourceProduct As BindingSource
            bindingSourceProduct = New BindingSource()
            bindingSourceProduct.DataSource = dt
            sender.Properties.DataSource = bindingSourceProduct.DataSource
            sender.Properties.ValueMember = "CODE"
            sender.Properties.DisplayMember = "NAME"
            sender.Properties.NullText = String.Empty
            sender.DataBindings.CLEAR()
            sender.DataBindings.Add("EditValue", dt, "NAME")
            'sender.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
            sender.Properties.SeparatorChar = ";"
            sender.EditValue = ClientSessionInfo.UserID
            sender.Properties.PopupFormMinSize = New Size(80, dt.Rows.Count * 22)

        Catch ex As Exception

        End Try
    End Sub


    Private Sub SetDept(ByVal sender As Object, Optional ByVal ExceptDept As String = "")

        Dim dt As New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")

        Try
            'For i = 0 To DeptDt.Rows.Count - 1
            '    If ExceptDept <> DeptDt.Rows(i)("CODE").ToString Then
            '        dt.ImportRow(DeptDt.Rows(i))
            '        dt.Rows(dt.Rows.Count - 1)("NAME") = (i + 1).ToString & "." & dt.Rows(dt.Rows.Count - 1)("NAME").ToString
            '        '       a = a + 1
            '    End If
            'Next
            If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
                    AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_COM_CODE") Then

                Dim drMdm() As DataRow = Nothing
                drMdm = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD ='C03'", "SORT ASC ,COMN_CD ASC")

                For i = 0 To drMdm.Count - 1
                    If ExceptDept <> drMdm(i)("COMN_CD").ToString Then
                        Dim dr As DataRow = dt.NewRow
                        dr("CODE") = drMdm(i)("COMN_CD").ToString
                        dr("NAME") = i & "." & drMdm(i)("CD_NM").ToString
                        dt.Rows.Add(dr)
                    End If
                Next
            End If
            Dim bindingSourceProduct As BindingSource
            bindingSourceProduct = New BindingSource()
            bindingSourceProduct.DataSource = dt
            sender.Properties.DataSource = bindingSourceProduct.DataSource
            sender.Properties.ValueMember = "CODE"
            sender.Properties.DisplayMember = "NAME"
            sender.Properties.NullText = String.Empty
            sender.DataBindings.CLEAR()
            sender.DataBindings.Add("EditValue", dt, "NAME")
            'sender.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
            sender.Properties.SeparatorChar = ";"
            sender.EditValue = String.Empty
        Catch EX As Exception

        End Try


        'If DEPT_AUTH_LIST_Dt Is Nothing Then
        '    DEPT_AUTH_LIST_Dt = DeptDt.Copy
        '    Dim bindingSourceProduct As BindingSource = Nothing
        '    bindingSourceProduct = New BindingSource()
        '    bindingSourceProduct.DataSource = DEPT_AUTH_LIST_Dt
        '    sender.Properties.DataSource = bindingSourceProduct.DataSource
        '    sender.DataBindings.add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
        '    sender.Properties.ValueMember = "CODE"
        '    sender.Properties.DisplayMember = "NAME"
        '    sender.Properties.NullText = String.Empty
        '    sender.Properties.SeparatorChar = ";"
        'Else 
        '    DEPT_AUTH_LIST.EditValue = String.Empty
        '    DEPT_AUTH_LIST.SetEditValue(String.Empty)
        '    DEPT_AUTH_LIST_Dt.Rows.Clear()
        'End If
        ''DEPT_AUTH_LIST.Properties.Items.Clear()



        'sender.Refresh()


    End Sub

    Private Sub SetDept(ByVal cmbDept As YJIT.SC.UI.SCControls.ComboBox)

        Dim dt As New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")

        Try
            If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
                    AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_COM_CODE") Then

                Dim drMdm() As DataRow = Nothing
                drMdm = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD ='C03'", "SORT ASC ,COMN_CD ASC")

                For i = 0 To drMdm.Count - 1
                    Dim dr As DataRow = dt.NewRow
                    dr("CODE") = drMdm(i)("COMN_CD").ToString
                    dr("NAME") = i & "." & drMdm(i)("CD_NM").ToString
                    dt.Rows.Add(dr)
                Next
            End If
            cmbDept.DataSource = dt
            cmbDept.SelectedValue = ClientSessionInfo.OrganizationCode
        Catch EX As Exception

        End Try

    End Sub

#End Region


#Region "=================Data logic actions==========="
    Public Sub NewData()
        Me.ClearView(UI.AppliedRangeTypes.Except, {REQ_SVC, PROC_TYPE, PRIORITY, SCREEN, DirList})

        SYS_ID.Text = "CRM"
        CONTENT.ReadOnly = False

        REQ_YMD.Text = Now.ToString("yyyyMMdd")
        REQ_HM.Text = Now.ToString("HHmm")
        ' WORK_USR.Text = ClientSessionInfo.LocalName

        SetUserList(WORK_USR_LIST, ClientSessionInfo.OrganizationCode)
        SetDept(DEPT_AUTH_LIST, ClientSessionInfo.OrganizationCode)
        SetDept(DEPT_CD)

        SetReqsvc2(REQ_SVC.SelectedValue)

        CUST_CD.Select()


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

            Me.BindToDataset(ds, "Data")
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
                RANK_NM.Text = dr("RANK_NM").ToString
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

        If REQ_TYPE2.SelectedValue.ToString = "" Then
            MsgBoxLocalized("요청상세을 선택하세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            REQ_TYPE2.Focus()
            Exit Sub
        End If

        If (PROC_TYPE.SelectedValue = "1" OrElse PROC_TYPE.SelectedValue = "2") Then
            If SYS_ID.Text.ToUpper <> "CRM" _
                       AndAlso String.IsNullOrEmpty(CMPT_RMK.Text) Then
                'xtcRemark.SelectedTabPage = xtpCMPT_RMK
                MsgBoxLocalized("답변 입력후 저장하세요.", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                CMPT_RMK.Focus()
                Exit Sub
            End If
        End If


        Dim byteUploadFiles As Dictionary(Of String, Object) = comdoc.byteUploadFiles
        Dim tempFolder As String = comdoc.getTempFolder
        Dim strFileName As String = ""

        Dim dsResult As DataSet
        Dim ds As DataSet = Nothing

        Try
            For i As Integer = 0 To GV2.RowCount - 1
                GV2.SetRowCellValue(i, "SEQ", comdoc.GetSeq(i, MNGT_NO.Text))
            Next
            comdoc.SetUploadPath(Split(DirList.Text, "/"))

            ds = Me.ConvertToDataset
            ds.Tables("MAIN").Columns.Add("DEPT_AUTH_LIST")
            ds.Tables("MAIN").Rows(0)("DEPT_AUTH_LIST") = DEPT_AUTH_LIST.EditValue.ToString.Replace(" ", "")
            'WORK_USR_LIST 
            ds.Tables("MAIN").Columns.Add("WORK_USR_LIST")
            ds.Tables("MAIN").Rows(0)("WORK_USR_LIST") = WORK_USR_LIST.EditValue.ToString.Replace(" ", "")
            If Not String.IsNullOrEmpty(ds.Tables("MAIN").Rows(0)("WORK_USR_LIST")) Then
                ds.Tables("MAIN").Rows(0)("WORK_USR") = ""
            End If

            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgt", "SaveInput", {ds, comdoc.getUploadPath})
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow
        dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") = "Y" Then
            Dim dt As DataTable = dsResult.Tables("Data.WG2")

            For Each dr In dt.Rows
                MNGT_NO.Text = dr("MNGT_NO").ToString

                strFileName = tempFolder & "\" & comdoc.removeSpecialChars(MNGT_NO.Text) & "_" & dr("SEQ").ToString & "_" & dr("FILE_NM").ToString

                Try
                    'if directory doesn't exist
                    If Not Directory.Exists(tempFolder) Then
                        Directory.CreateDirectory(tempFolder)
                    End If

                    'if the file is changed, following actions can be done
                    If comdoc.byteUploadFiles.ContainsKey(dr("FILE_NM").ToString) AndAlso dr("SUCCESS").ToString() = "Y" Then
                        File.WriteAllBytes(strFileName, byteUploadFiles(dr("FILE_NM").ToString))

                        If Not FileUpload(strFileName, dr("FILE_PATH").ToString()) Then Throw New Exception("Couldn't upload file!")

                        If System.IO.File.Exists(strFileName) Then System.IO.File.Delete(strFileName)
                    End If
                Catch ex As Exception
                    dr("TrxMsg") = ex.ToString
                    dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.ComDocumentMgt", "Delete", {MNGT_NO.Text, dr("SEQ").ToString})
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
        SearchFlag = True
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

            SetReqsvc2(retDs.Tables("Data.MAIN").Rows(0)("REQ_SVC").ToString())
            SetUserList(WORK_USR_LIST, retDs.Tables("Data.MAIN").Rows(0)("DEPT_CD").ToString())
            SetDept(DEPT_AUTH_LIST, retDs.Tables("Data.MAIN").Rows(0)("DEPT_CD").ToString())

            Me.BindToDataset(retDs, "Data")

            DEPT_AUTH_LIST.EditValue = retDs.Tables("Data.MAIN").Rows(0)("DEPT_AUTH_LIST").ToString()
            WORK_USR_LIST.EditValue = retDs.Tables("Data.MAIN").Rows(0)("WORK_USR_LIST").ToString()

            If SYS_ID.Text.ToUpper = "CRM" Then
                CONTENT.ReadOnly = False
            Else
                CONTENT.ReadOnly = True
            End If

            Call InitIcons()
            REQ_USR.Select()

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        Finally
            SearchFlag = False
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

    'Public Function YJQuerySearch(ByVal key As String) As DataSet

    '    Dim ParamDsRet As DataSet = GetConvertToDataSet(key)
    '    Dim dsRet As DataSet = Nothing
    '    Try
    '        dsRet = MethodCallEx(Me, "YJIT.Biz.YJQuery", "Search", {ParamDsRet})
    '    Catch ex As Exception

    '    End Try
    '    Return dsRet
    'End Function

    'Private Function GetConvertToDataSet(ByVal KEY As String) As DataSet
    '    Dim YJSql As New YJQuery
    '    Dim ds As DataSet = Me.ConvertToDataset

    '    Try
    '        Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
    '        Select Case KEY
    '            Case "CrmUserInfo"
    '                YJSql.SqlBox("CrmUserInfo", "CrmAsMgtDev@CrmUserInfo", True)
    '            Case "REQ_SVC2"
    '                YJSql.SqlBox("REQ_SVC2", "CrmAsMgt_v2@GetReqSvc2List", True)
    '        End Select
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try

    '    Return YJSql.DataSet
    'End Function

#End Region

#Region "=================Control Events==========="
    Private Sub CrmAsInput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Try
        '    Dim ds As DataSet = YJQuerySearch("CrmUserInfo")
        '    ds = AdaptDataSourceForReport(ds)
        '    If ds.Tables.Contains("CrmUserInfo") Then
        '        UserInfoDt = ds.Tables("CrmUserInfo")
        '    End If

        '    ds = YJQuerySearch("REQ_SVC2")
        '    ds = AdaptDataSourceForReport(ds)
        '    If ds.Tables.Contains("REQ_SVC2") Then
        '        REQ_SVC2_dt = ds.Tables("REQ_SVC2")
        '    End If

        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub CrmAsInput_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown

        Call PopUpInit()
        comdoc = New ComDoc(WG2)

        'AddHandler ttc.GetActiveObjectInfo, New DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(AddressOf ttc_GetActiveObjectInfo)
        Call InitGrid()
        Call NewData()
        AddhandlerFormClose()

        WG2.AddRow()
        ShownFlag = False
    End Sub
    
    Private Sub CONTENT_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CONTENT.SelectionStart = Len(CONTENT.Text)
    End Sub

    'Private Sub CONTENT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CONTENT.KeyPress

    '    If (Split(sender.Text.Substring(0, sender.SelectionStart), vbNewLine).Length > 3) And AscW(e.KeyChar) = Keys.Enter Then
    '        e.KeyChar = String.Empty
    '        PROC_TYPE.Focus()
    '    End If

    'End Sub

    Private Sub RMK_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

        AddHandler Panel1.PreviewKeyDown, AddressOf ClosePreviewKeyDown

        For Each cntr In Panel1.Controls
            If cntr.GetType.FullName.Contains("YJIT.SC.UI.SCControls.TextBox") Then
                AddHandler CType(cntr, YJIT.SC.UI.SCControls.TextBox).PreviewKeyDown, AddressOf ClosePreviewKeyDown
            End If
            If cntr.GetType.FullName.Contains("YJIT.SC.UI.SCControls.ComboBox") Then
                AddHandler CType(cntr, YJIT.SC.UI.SCControls.ComboBox).PreviewKeyDown, AddressOf ClosePreviewKeyDown
            End If
            If cntr.GetType.FullName.Contains("YJIT.SC.UI.SCControls.DateBox") Then
                AddHandler CType(cntr, YJIT.SC.UI.SCControls.DateBox).PreviewKeyDown, AddressOf ClosePreviewKeyDown
            End If
            If cntr.GetType.FullName.Contains("YJIT.SC.UI.SCControls.MaskedTextBox") Then
                AddHandler CType(cntr, YJIT.SC.UI.SCControls.MaskedTextBox).PreviewKeyDown, AddressOf ClosePreviewKeyDown
            End If
        Next
    End Sub

    Private Sub ClosePreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs)
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        NewData()
    End Sub

    Private Sub PROC_TYPE_SelectedIndexChanged(ByVal sender1 As System.Object, ByVal e As System.EventArgs) Handles PROC_TYPE.SelectedIndexChanged
        If SearchFlag = True Then Exit Sub

        If PROC_TYPE.SelectedValue = "1" Or PROC_TYPE.SelectedValue = "2" Or PROC_TYPE.SelectedValue = "7" Or PROC_TYPE.SelectedValue = "8" Then
            WORK_USR_LIST.EditValue = ClientSessionInfo.UserID
        ElseIf PROC_TYPE.SelectedValue = "7" Then
            CMPT_YMD.Text = ""
            'Else
            '    CMPT_YMD.Text = ""
            '    WORK_USR.Text = ""
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

    Private Sub WORK_USR_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles WORK_USR.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            DEPT_AUTH_LIST.Focus()
        End If
    End Sub

    Private Sub DEPT_CD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DEPT_CD.SelectedIndexChanged
        If ShownFlag = True Then
            Exit Sub
        End If


        SetUserList(WORK_USR_LIST, DEPT_CD.SelectedValue)
        SetDept(DEPT_AUTH_LIST, DEPT_CD.SelectedValue)
    End Sub

    Private Sub DEPT_AUTH_LIST_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DEPT_AUTH_LIST.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            PRAR_YMD.Focus()
        End If
    End Sub

    Private Sub DEPT_CD_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles REQ_TYPE2.KeyDown, REQ_TYPE.KeyDown, REQ_SVC2.KeyDown, REQ_SVC.KeyDown, PROC_TYPE.KeyDown, PRIORITY.KeyDown, FREE_YN.KeyDown, DEPT_CD.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.DroppedDown = True
        End If
    End Sub

    Private Sub REQ_SVC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REQ_SVC.SelectedIndexChanged
        If ShownFlag = True Then
            Exit Sub
        End If
        SetReqSvc2(REQ_SVC.SelectedValue)
    End Sub

    Private Sub WORK_USR_LIST_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles WORK_USR_LIST.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            PROC_TYPE.Focus()
        End If '   WORK_USR_LIST
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

    Private Sub GV1_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GV1.RowCellStyle
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            If e.RowHandle < 0 Then Exit Sub

            Select Case e.Column.FieldName
                Case "USE_YN"
                    If view.GetRowCellValue(e.RowHandle, "USE_YN").ToString = "N" Then
                        e.Appearance.BackColor = System.Drawing.Color.LightPink
                    End If
                Case "INFO_YN", "INFO_YMD"
                    If view.GetRowCellValue(e.RowHandle, "INFO_YN").ToString = "Y" AndAlso view.GetRowCellValue(e.RowHandle, "CHECK_YN").ToString = "Y" Then
                        e.Appearance.BackColor = System.Drawing.Color.Red
                    End If
                Case "STOP_YN", "STOP_YMD"
                    If view.GetRowCellValue(e.RowHandle, "STOP_YN").ToString = "Y" AndAlso view.GetRowCellValue(e.RowHandle, "CHECK_YN").ToString = "Y" Then
                        e.Appearance.BackColor = System.Drawing.Color.Red
                    End If
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub GV3_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GV3.RowCellStyle
        If e.RowHandle = HotTrackRow Then
            e.Appearance.BackColor = Color.PaleGoldenrod
        End If

        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            If e.RowHandle < 0 Then Exit Sub

            Select Case e.Column.FieldName
                Case "PROC_TYPE"
                    If view.GetRowCellValue(e.RowHandle, "PROC_TYPE").ToString = "0" Then
                        e.Appearance.BackColor = System.Drawing.Color.Salmon
                    End If
                Case "CUST_NM"
                    If view.GetRowCellValue(e.RowHandle, "SYS_ID").ToString = "ELVIS" Then
                        e.Appearance.BackColor = System.Drawing.Color.Red
                    End If
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
    End Sub
#End Region

End Class
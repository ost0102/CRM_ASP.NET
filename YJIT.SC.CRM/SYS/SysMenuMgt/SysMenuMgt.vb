Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class SysMenuMgt

#Region "=================Data logic actions==========="

    Public Sub SearchData()

        '////////Validation Check///////////
        If Me.ValidateActionDataLogic(UI.ActionTypes.LoadData) = False Then Exit Sub
        If Me.ValidateRequiredData({S_SYS_ID}) = False Then Exit Sub

        '////////WCF Service Call/////////
        'Build up the parameter (array type)
        Dim params() As Object = {Me.S_SYS_ID.SelectedValue, S_PGM_GRP.Text, S_PGM_ID.Text}

        Dim dsRet As DataSet
        Dim drPairs As DataRow

        Try
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.SysMenuMgt", "Search", params)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        '//////Parsing WCF returned data///////
        drPairs = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        If drPairs("TrxCode") = "SUCCESS" Then
            Me.BindToDataset(dsRet, "Data")
        ElseIf drPairs("TrxCode") = "NODATA" Then
            Me.BindToDataset(dsRet, "Data")
            MsgBox(drPairs("TrxMsg"))
            Exit Sub
        End If


        '/////Set post datastate/////////
        Me.DataState = UI.DataStates.None
    End Sub

    Public Sub SaveData()

        If OFFICE_CD.Text = "" Then
            MsgBox("Office HQ is mandatory.")
            OFFICE_CD.Text = ClientSessionOfficeInfo.HqOfficeCode
        End If

        '////////Validation Check///////////
        If Me.ValidateActionDataLogic(UI.ActionTypes.UpdateData) = False Then Exit Sub
        'If Me.ValidateRequiredData({S_SYS_ID}) = False Then Exit Sub

        '////////WCF Service Call/////////
        Dim localPath As String = Nothing
        Dim args() As String = Environment.GetCommandLineArgs
        If args.Contains("-Deployed") Then
            localPath = "Server"
        Else
            localPath = Application.StartupPath
        End If

        Dim dtMenu As DataTable = MenuTree.DataSource.Copy
        dtMenu.TableName = "MenuTree"
        Dim dsParam As New DataSet
        dsParam.Tables.Add(dtMenu)

        Dim params() As Object = {OFFICE_CD.Text, dsParam, localPath}

        Dim dsResult As DataSet
        Dim drPairs As DataRow

        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.SysMenuMgt", "Save", params)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        '//////Exploring the returned information///////
        drPairs = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
        MsgBoxLocalized(drPairs("TrxMsg"))

        '/////Set post datastate/////////
        Me.DataState = UI.DataStates.Retrieved
    End Sub

    'Search Menu Tree Data
    Private Sub SearchMenuTree()

        If OFFICE_CD.Text = "" Then
            OFFICE_CD.Text = ClientSessionOfficeInfo.HqOfficeCode
        End If

        Dim ds As DataSet
        Dim dr As DataRow

        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.SysMenuMgt", "SearchMenuTree", {OFFICE_CD.Text})
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg"))
            ClearView(AppliedRangeTypes.Only, {MenuTree})
            Exit Sub
        Else
            Try
                If ds.Tables("Data.MenuTree").Rows.Count = 0 Then MsgBoxLocalized(dr("TrxMsg"))

                'Key Field 및 ParentField 지정
                MenuTree.ParentFieldName = "UPPER_MENU_CD"
                MenuTree.KeyFieldName = "MENU_CD"
                MenuTree.DataSource = ds.Tables("Data.MenuTree").Copy '.DefaultView

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    ' GridInit()
    Public Sub TreeInit()
        Dim editorCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        'P/C 구분
        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        AddNewRow(dt, "F", "Form")
        AddNewRow(dt, "P", "Popup")
        AddNewRow(dt, "H", "Hidden")

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        MenuTree.Columns("FORM_TAG").ColumnEdit = editorCombo

    End Sub

    Private Sub AddNewRow(ByVal dt As DataTable, ByVal Code As String, ByVal Name As String)
        dt.Rows.Add()
        dt.Rows(dt.Rows.Count - 1)("CODE") = Code
        dt.Rows(dt.Rows.Count - 1)("NAME") = Name
    End Sub

#End Region

#Region "============Control events============"

    Private Sub SysMenuMgt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OFFICE_CD.Text = ClientSessionOfficeInfo.HqOfficeCode

        SplitContainer.SplitterPosition = 567

        Call TreeInit()
    End Sub

    Private Sub SysMenuMgt_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Me.S_OFFICE_CD.SelectedValue = ClientSessionInfo.OfficeCode
        SearchMenuTree()    'Search MenuTree
        PopupInit()

        'MenuTree 입력시 대문자만 입력되어서 추가함
        Me.TextCasing = TextCasings.Normal
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub

    Private Sub GV1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GV1.CustomDrawRowIndicator
        Dim rowIndex As Integer = e.RowHandle
        If rowIndex >= 0 Then
            rowIndex += 1
            e.Info.DisplayText = rowIndex.ToString()
        End If

        e.Info.ImageIndex = -1
    End Sub

    Private Sub btnSearchMenu_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchMenu.Click
        Call SearchMenuTree()
    End Sub

#End Region

#Region "============Client Function & Procedure============"
    'Popup Setting
    Private Sub PopupInit()
        '그리드 마우스 오른쪽 클릭 팝업 메뉴 설정
        Dim PopUp As New PopupBase

        '일반 팝업용
        PopUp.ItemAdd("RefreshTree", "&Refresh List")
        PopUp.ItemAdd("AddNode", "&Add Menu", True)
        PopUp.ItemAdd("DelNode", "&Delete Menu")
        PopUp.ItemAdd("CollapseAll", "&Collapse All", True)
        PopUp.ItemAdd("ExpandAll", "&Expand All")
        'PopUp.ItemAdd(Action.Excel, "StlEtcInvoiceMgt", "&Export Excel", True)
        PopUp.PopUpInit(Me, MenuTree)

        '일반 팝업용
        PopUp = New PopupBase
        PopUp.ItemAdd("WG1_Refresh", "&Refresh List")
        PopUp.ItemAdd("WG1_CollapseAll", "&Collapse All", True)
        PopUp.ItemAdd("WG1_ExpandAll", "Expand All")
        PopUp.ItemAdd(Action.Excel, "SysMenuMgt", "&Export Excel", True)
        PopUp.PopUpInit(Me, WG1)

    End Sub

    'PopUp After Click
    Public Sub PopUpOnAfterClick(ByVal dr As DataRow)
        Dim Key As String = dr("KEY")
        Dim Sender As String = ""

        If Not dr("Sender") Is System.DBNull.Value Then Sender = dr("Sender")

        Try
            Select Case Key
                Case "AddNode"
                    Dim parentNode As TreeListNode = Nothing
                    Dim childNode As TreeListNode = Nothing

                    If MenuTree.DataSource Is Nothing Then Exit Sub

                    'Move row to MenuTree
                    Dim dtMenu As DataTable = MenuTree.DataSource

                    '마우스 커서가 위치한 Tree의 정보
                    Dim info As TreeListHitInfo = MenuTree.CalcHitInfo(MenuTree.PointToClient(New Point(MousePosition.X, MousePosition.Y)))

                    Dim drParentTL1 As DataRow = dtMenu.NewRow
                    parentNode = MenuTree.Selection(0) ' info.Node ' MenuTree.Selection(0)

                    If parentNode Is Nothing Then    '새로운 메뉴
                        'Create new parent node
                        drParentTL1("UPPER_MENU_CD") = ""
                        drParentTL1("NEW_UPPER") = ""
                    Else
                        'Create new child node
                        '상위 메뉴가 서브메뉴가 아니면 에러
                        If parentNode.Item("FORM_ID").ToString <> "" Then
                            MsgBoxLocalized("Form ID is exist. Can't make sub menu.")
                            Exit Sub
                        End If

                        drParentTL1("UPPER_MENU_CD") = parentNode("MENU_CD")
                        drParentTL1("NEW_UPPER") = parentNode("MENU_CD")
                    End If

                    drParentTL1("FORM_ID") = ""
                    drParentTL1("FORM_NM") = ""
                    drParentTL1("GRP_TAG") = "F"
                    drParentTL1("FORM_TAG") = "F"

                    dtMenu.Rows.Add(drParentTL1)

                    '메뉴코드를 새로 생성한다
                    SetMenuCd(MenuTree.Nodes, 0, False)
                Case "DelNode"
                    If MsgBoxLocalized("Do you want to delete?", MessageBoxButtons.YesNo, "Delete", MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.No Then Exit Sub
                    MenuTree.DeleteNode(MenuTree.Selection(0))
                    '메뉴코드를 새로 생성한다
                    SetMenuCd(MenuTree.Nodes, 0, False)
                Case "CollapseAll"
                    MenuTree.CollapseAll()
                Case "ExpandAll"
                    MenuTree.ExpandAll()
                Case "RefreshTree"
                    Call SearchMenuTree()
                Case "WG1_Refresh"
                    Call SearchData()
                Case "WG1_CollapseAll"
                    GV1.CollapseAllGroups()
                Case "WG1_ExpandAll"
                    GV1.ExpandAllGroups()

            End Select

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
#End Region

#Region "============Drag & Drop Part============"
    Private dragStartGridInfo As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = Nothing

    '==========================================================================================
    ' WG1(GV1) Event Start
    '==========================================================================================
    Private Sub WG1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles WG1.MouseDown
        If e.Button = MouseButtons.Left AndAlso Control.ModifierKeys = Keys.None Then
            dragStartGridInfo = GV1.CalcHitInfo(New Point(e.X, e.Y))
        End If
    End Sub

    Private Sub WG1_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles WG1.MouseMove
        If e.Button = MouseButtons.Left AndAlso dragStartGridInfo IsNot Nothing Then
            Dim dragRect As Rectangle = _
            New Rectangle(New Point(dragStartGridInfo.HitPoint.X - SystemInformation.DragSize.Width / 2, _
            dragStartGridInfo.HitPoint.Y - SystemInformation.DragSize.Height / 2), SystemInformation.DragSize)

            If GV1.IsGroupRow(GV1.FocusedRowHandle) Then 'Group row는 이동할 수 없음
                MsgBox("Can't Drag group row.")
                Exit Sub
            End If

            If (Not dragRect.Contains(New Point(e.X, e.Y))) Then
                Dim datarow() As DataRow = GetDragData(GV1) '여러 줄이 선택될 수 있으므로 현재 Drag되는 데이터를 DataRow 배열로 가져온다
                If datarow IsNot Nothing Then
                    WG1.DoDragDrop(datarow, DragDropEffects.Copy)
                End If
            End If
        End If
    End Sub
    '==========================================================================================
    ' WG1(GV1) Event End
    '==========================================================================================

    '==========================================================================================
    ' MenuTree Event Start
    '==========================================================================================
    Private Sub MenuTree_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles MenuTree.MouseDown
        Dim tree As TreeList = TryCast(sender, TreeList)
        Dim hitinfo As TreeListHitInfo = tree.CalcHitInfo(e.Location)


        If hitinfo.HitInfoType <> HitInfoType.Cell Then
            tree.Selection.Clear()
        Else
            '오른쪽 버튼을 클릭하면 현재 Node를 선택한다(Add,Delete 팝업메뉴 처리에서 사용)
            If e.Button = Windows.Forms.MouseButtons.Right AndAlso Control.ModifierKeys = Keys.None Then
                hitinfo.Node.Selected = True
            End If
        End If
    End Sub

    Private Sub MenuTree_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles MenuTree.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub MenuTree_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles MenuTree.DragDrop
        Dim parentNode As TreeListNode = Nothing
        Dim childNode As TreeListNode = Nothing

        If MenuTree.DataSource Is Nothing Then Exit Sub

        Dim targetNode As TreeListNode
        '마우스 커서가 위치한 Tree의 정보
        targetNode = MenuTree.CalcHitInfo(MenuTree.PointToClient(New Point(e.X, e.Y))).Node
        '상위 메뉴가 서브메뉴가 아니면 에러 - 현재 제대로 동작하지 않음 (2014.04.09 msKang)
        'If targetNode.Item("FORM_ID").ToString <> "" Then
        '    MsgBoxLocalized("Form ID is exist. Can't make sub menu. " & targetNode.Item("FORM_ID").ToString)
        '    Exit Sub
        'End If

        '그리드에서 가져온게 아니면 빠져나감(MenuTree 내부 이동은 MenuTree_AfterDragNode에서 처리)
        If TryCast(e.Data.GetData(GetType(DataRow())), DataRow()) Is Nothing Then
            Exit Sub
        End If

        'WG1_MouseMove 에서 저장한 DataRow 배열을 받아온다
        Dim drSource As DataRow() = CType(e.Data.GetData(GetType(DataRow())), DataRow())

        'Create MenuTree
        Dim dtMenu As DataTable = MenuTree.DataSource

        For i = 0 To drSource.Count() - 1
            Dim drParentTL1 As DataRow = dtMenu.NewRow

            If targetNode Is Nothing Then    '새로운 메뉴
                'Create new parent node
                drParentTL1("UPPER_MENU_CD") = ""
                drParentTL1("NEW_UPPER") = ""
            Else
                'Create new child node
                drParentTL1("UPPER_MENU_CD") = targetNode.Item("MENU_CD")
                drParentTL1("NEW_UPPER") = targetNode.Item("MENU_CD")
            End If

            drParentTL1("FORM_ID") = drSource(i)("PGM_ID")
            drParentTL1("FORM_NM") = drSource(i)("PGM_NM")
            drParentTL1("GRP_TAG") = "F"
            drParentTL1("FORM_TAG") = "F"

            dtMenu.Rows.Add(drParentTL1)

            'MenuTree를 재 구성한다
            SetMenuCd(MenuTree.Nodes, 0, False)
        Next

    End Sub

    Private Sub MenuTree_AfterDragNode(sender As System.Object, e As DevExpress.XtraTreeList.NodeEventArgs) Handles MenuTree.AfterDragNode
        SetMenuCd(MenuTree.Nodes, 0, False)
    End Sub
    '==========================================================================================
    ' MenuTree Event End
    '==========================================================================================

    '==========================================================================================
    ' Helper Function & Procedure Start
    '==========================================================================================
    'Menu Code setting
    Private Sub SetMenuCd(ByVal nodes As DevExpress.XtraTreeList.Nodes.TreeListNodes, ByRef Seq As Integer, ByVal flagChild As Boolean)
        Dim UpperMenuCD As Integer = Seq
        Dim dtMenu As DataTable = MenuTree.DataSource.copy

        MenuTree.BeginUpdate()
        '메뉴코드를 새로 생성한다
        For Each drNode As TreeListNode In nodes
            'Child Node인 경우 Upper Menu Code 부여
            If flagChild AndAlso UpperMenuCD <> 0 Then
                drNode.SetValue("NEW_UPPER", UpperMenuCD.ToString("00000") & "0")
            Else
                drNode.SetValue("NEW_UPPER", "")
            End If

            '새 메뉴코드 생성
            Seq = Seq + 1
            drNode.SetValue("NEW_MENU", Seq.ToString("00000") & "0")
            '임시 새 메뉴코드 생성
            If drNode.GetValue("MENU_CD").ToString() = "" Then
                drNode.SetValue("MENU_CD", "1" & drNode.GetValue("NEW_UPPER") & (Seq + 1).ToString("00000") & "0")
            End If

            'Child Node가 있으면 자신을 재 호출해서 Child Node에 대한 메뉴코드를 생성한다.
            If drNode.HasChildren Then
                SetMenuCd(drNode.Nodes, Seq, True)
            End If
        Next

        '정렬 -> Data Source에 반영 -> 정렬 해제 -> Client Update
        MenuTree.Columns("NEW_MENU").SortOrder = SortOrder.Ascending
        MenuTree.RefreshDataSource()    ' 데이터 소스 업데이트
        MenuTree.Columns("NEW_MENU").SortOrder = SortOrder.None
        MenuTree.EndUpdate()
    End Sub

    ' 선택된 row에 대한 데이터를 반환한다(Multi Row Select).
    Private Function GetDragData(ByVal view As GridView) As DataRow()
        Dim selection() As Integer = view.GetSelectedRows()
        If selection Is Nothing Then
            Return Nothing
        End If

        Dim count As Integer = selection.Length
        Dim result(count - 1) As DataRow
        For i As Integer = 0 To count - 1
            result(i) = view.GetDataRow(selection(i))
        Next i

        Return result
    End Function
    '==========================================================================================
    ' Helper Function & Procedure End
    '==========================================================================================
#End Region




End Class
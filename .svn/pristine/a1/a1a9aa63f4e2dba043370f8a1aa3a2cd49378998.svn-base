Imports System.Data
Imports System.Reflection
Imports DevExpress.XtraReports.UI
Imports System.Collections.Specialized
Imports System.Runtime.Serialization
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Enum Action As Integer
    Addrow = 1
    DeleteRow = 2
    DeleteSelectRows = 3
    NavigateTo = 4
    Excel = 5
    MeClose = 6
    EventKey = 7
    GroupHeader = 8
    TextBox = 9
    TextBoxDate = 10
    TextBoxTime = 11
    Other = 0
End Enum

Public Enum BarIcon As Integer
    None = -1
    AddRow = 0
    DeleteRow = 1
    Excel = 2
    Print = 3
    CheckAll = 4
    CopyData = 5
    Settlement = 6
    PopupLink = 7
    PageLink = 8
    HyperLink = 9
    FileUpload = 10
    UpdateContents = 11
    Master = 12
    House = 13
    Slip = 14
    INV = 15
    DC = 16
    COST = 17
    InsertRow = 18
    ExcelUpload = 19
End Enum

Public Class PopupBase


    Public Sub New()
        m_DataSource = PopupDt()
        m_OnlyControl = Nothing
    End Sub

    '13.06.13 이병호
    Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Private m_Me As Object

    'bar manager 이벤트, 포커스 찾기용
    Dim RepositoryItemTextEdit_Nomal As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit = Nothing
    Dim RepositoryItemTextEdit_Date As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit = Nothing
    Dim RepositoryItemTextEdit_Time As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit = Nothing

    Dim BarItemFocusedName As String = ""
    Dim EnterKeyPress As Boolean = False

    Private ViewExpandAllDetails As Boolean = False
    '저장될자료정보
    Private m_Contols As Dictionary(Of String, Object)
    Property Contols As Dictionary(Of String, Object)
        Set(value As Dictionary(Of String, Object))

        End Set
        Get
            Return m_Contols
        End Get
    End Property

    Private m_OnlyControl As Object = Nothing

    '받아올 자료 정보
    Public m_DataSource As DataTable
    Property DataSource As DataTable
        Set(ByVal value As DataTable)
            m_DataSource = value
        End Set
        Get
            Return m_DataSource
        End Get
    End Property
    Private m_SelectedIndex As Integer = -1
    Property SelectedIndex As String
        Set(ByVal value As String)

        End Set
        Get
            Return m_SelectedIndex
        End Get
    End Property

    Private m_MsgString As String
    Property MsgString As String
        Set(ByVal value As String)
            m_MsgString = value
        End Set
        Get
            Return m_MsgString
        End Get
    End Property

    Private m_AddFirstFocusColumn As String
    Property AddFirstFocusColumn As String
        Set(ByVal value As String)
            m_AddFirstFocusColumn = value
        End Set
        Get
            Return m_AddFirstFocusColumn
        End Get
    End Property
    Private m_AddEnterFocusColumn As String
    Property EnterFocusColumn As String
        Set(ByVal value As String)
            m_AddEnterFocusColumn = value
        End Set
        Get
            Return m_AddEnterFocusColumn
        End Get
    End Property
    Dim m_GroupIndex As Integer = 0

    Dim m_GruopItemUse As Boolean = True

    Property SetItemCaption(ByVal Key As String) As String
        Get
            Dim dr() As DataRow = m_DataSource.Select("Key = '" & Key & "'")
            If dr.Length = 0 Then
                Return Nothing
            Else
                Return dr(0)("Caption")
            End If
        End Get
        Set(ByVal value As String)
            For i = 0 To m_DataSource.Rows.Count - 1
                If m_DataSource.Rows(i)("KEY") = Key Then
                    m_DataSource.Rows(i)("Caption") = value
                    Exit Property
                End If
            Next
        End Set
    End Property
    Property GruopItemUse As Boolean
        Set(ByVal value As Boolean)
            m_GruopItemUse = value
        End Set
        Get
            Return m_GruopItemUse
        End Get
    End Property

#Region "== 내부 데이터 테이블 관리 =="
    '아이템추가
    Public Sub ItemAdd(ByVal Action As Action, ByVal Key As String, ByVal Caption As String, Optional ByVal GroupLine As Boolean = False)
        m_DataSource.Rows.Add(Action, Key, Caption, GroupLine, BarIcon.None)
    End Sub
    Public Sub ItemAdd(ByVal Action As Action, ByVal Key As String, ByVal Caption As String, ByVal BarIcon As BarIcon, Optional ByVal GroupLine As Boolean = False)
        m_DataSource.Rows.Add(Action, Key, Caption, GroupLine, BarIcon)
    End Sub
    Public Sub ItemAdd(ByVal Action As Action, ByVal Key As String, ByVal Caption As String, ByVal UpperKey As String, Optional ByVal GroupLine As Boolean = False)
        m_DataSource.Rows.Add(Action, Key)
        Dim rowIndex As Integer = m_DataSource.Rows.Count - 1
        m_DataSource.Rows(rowIndex)("Action") = Action
        m_DataSource.Rows(rowIndex)("Key") = Key
        m_DataSource.Rows(rowIndex)("Caption") = Caption
        m_DataSource.Rows(rowIndex)("GroupLine") = GroupLine
        m_DataSource.Rows(rowIndex)("BarIcon") = BarIcon.None
        m_DataSource.Rows(rowIndex)("UpperKey") = UpperKey
    End Sub
    Public Sub ItemAdd(ByVal Action As Action, ByVal Key As String, ByVal Caption As String, ByVal UpperKey As String, ByVal BarIcon As BarIcon, Optional ByVal GroupLine As Boolean = False)
        m_DataSource.Rows.Add(Action, Key)
        Dim rowIndex As Integer = m_DataSource.Rows.Count - 1
        m_DataSource.Rows(rowIndex)("Action") = Action
        m_DataSource.Rows(rowIndex)("Key") = Key
        m_DataSource.Rows(rowIndex)("Caption") = Caption
        m_DataSource.Rows(rowIndex)("GroupLine") = GroupLine
        m_DataSource.Rows(rowIndex)("BarIcon") = BarIcon
        m_DataSource.Rows(rowIndex)("UpperKey") = UpperKey
    End Sub

    Public Sub ItemAdd(ByVal Key As String, ByVal Caption As String, Optional ByVal GroupLine As Boolean = False)
        m_DataSource.Rows.Add(Action.Other, Key, Caption, GroupLine, BarIcon.None)
    End Sub
    Public Sub ItemAdd(ByVal Key As String, ByVal Caption As String, ByVal BarIcon As BarIcon, Optional ByVal GroupLine As Boolean = False)
        m_DataSource.Rows.Add(Action.Other, Key, Caption, GroupLine, BarIcon)
    End Sub

    Public Sub ItemAdd(ByVal Key As String, ByVal Caption As String, ByVal UpperKey As String, Optional ByVal GroupLine As Boolean = False)
        m_DataSource.Rows.Add(Action.Other, Key)
        Dim rowIndex As Integer = m_DataSource.Rows.Count - 1
        m_DataSource.Rows(rowIndex)("Action") = Action.Other
        m_DataSource.Rows(rowIndex)("Key") = Key
        m_DataSource.Rows(rowIndex)("Caption") = Caption
        m_DataSource.Rows(rowIndex)("GroupLine") = GroupLine
        m_DataSource.Rows(rowIndex)("BarIcon") = BarIcon.None
        m_DataSource.Rows(rowIndex)("UpperKey") = UpperKey
    End Sub
    Public Sub ItemAdd(ByVal Key As String, ByVal Caption As String, ByVal UpperKey As String, ByVal BarIcon As BarIcon, Optional ByVal GroupLine As Boolean = False)
        m_DataSource.Rows.Add(Action.Other, Key)
        Dim rowIndex As Integer = m_DataSource.Rows.Count - 1
        m_DataSource.Rows(rowIndex)("Action") = Action.Other
        m_DataSource.Rows(rowIndex)("Key") = Key
        m_DataSource.Rows(rowIndex)("Caption") = Caption
        m_DataSource.Rows(rowIndex)("GroupLine") = GroupLine
        m_DataSource.Rows(rowIndex)("BarIcon") = BarIcon
        m_DataSource.Rows(rowIndex)("UpperKey") = UpperKey
    End Sub

    '아이템 클리어
    Public Sub ItemClear()
        m_DataSource.Rows.Clear()
    End Sub
    '신규 데이터 테이블 리턴값
    Public Function PopupDt()
        Dim dt As New DataTable
        Try
            dt.Columns.Add("Action", GetType(Action))
            dt.Columns.Add("Key", GetType(String))
            dt.Columns.Add("Caption", GetType(String))
            dt.Columns.Add("GroupLine", GetType(Boolean))
            dt.Columns.Add("BarIcon", GetType(BarIcon))
            dt.Columns.Add("ID") '버튼 ID
            dt.Columns.Add("Sender", GetType(String)) ' 센더(그리드일 경우 구별하기위해), 컨트롤의 네임
            dt.Columns.Add("TrxCode", GetType(String)) ' 내부적으로 처리할 때 리턴받는 성공유무 코드. 
            dt.Columns.Add("Enabled", GetType(Boolean)) '  팝업 사용유무 보여질지 안보여질지
            dt.Columns.Add("Cancel", GetType(Boolean)) '   이벤트
            dt.Columns.Add("UpperKey", GetType(String)) '   
            dt.PrimaryKey = {dt.Columns("Key")}
        Catch ex As Exception
            dt = Nothing
        End Try

        Return dt
    End Function
#End Region

#Region "== 컨트롤 체크  =="
    '화면 판넬 컨트롤을 다 가져옴 
    Private Function BindControlCheck(ByVal control As Control)
        Dim ReturnValue As Boolean = False
        Dim FullName As String = control.GetType.FullName
        '개별 리스트를 사용하기 귀해서 나눔
        If Not IsNothing(m_OnlyControl) Then
            Select Case FullName
                Case "YJIT.SC.UI.SCControls.WebGrid", _
                     "DevExpress.XtraTreeList.TreeList"
                    If control.Name = m_OnlyControl.Name Then
                        ReturnValue = True
                    End If
                Case Else
                    If control.Name = m_OnlyControl.Name Then
                        ReturnValue = True
                    End If
            End Select
        Else
            Select Case FullName
                Case "DevExpress.XtraEditors.PanelControl", _
                     "DevExpress.XtraEditors.PanelControl", _
                     "System.Windows.Forms.Panel", _
                     "System.Windows.Forms.TableLayoutPanel", _
                     "DevExpress.XtraEditors.GroupControl", _
                     "DevExpress.XtraTab.XtraTabControl", _
                     "YJIT.SC.UI.SCControls.Label"

                    ReturnValue = True
            End Select
        End If
        Return ReturnValue
    End Function
    Private Sub GetControlList(ByVal controls As Control.ControlCollection)
        For Each Control In controls
            Dim cntr As Control = CType(Control, Control)
            If BindControlCheck(Control) Then
                If Not m_Contols.ContainsValue(cntr) Then
                    m_Contols(cntr.Name) = cntr
                End If
            End If
            Try
                GetControlList(cntr.Controls)
            Catch ex As Exception

            End Try
        Next
    End Sub
    Private Sub GetControlList()
        Try
            Dim controlList As Control.ControlCollection = CType(m_Me.controls, Control.ControlCollection)
            GetControlList(controlList)
        Catch ex As Exception
            m_Contols = Nothing
        End Try
    End Sub

    Public Sub ChkAddControl(ByRef VisibleIndex As Integer)
        ' Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = m_OnlyControl.MainView
        Dim gv As Object = m_OnlyControl.MainView
        For i = 0 To gv.Columns.Count - 1
            If gv.Columns(i).VisibleIndex = VisibleIndex Then
                Dim obj As Object = gv.Columns(i).ColumnEdit
                If Not obj Is Nothing Then
                    If obj.GetType.FullName.Contains("GridCheckMarksSelection") Then
                        ChkAddControl(VisibleIndex + 1)
                    ElseIf gv.Columns(i).OptionsColumn.AllowEdit = False Or gv.Columns(i).OptionsColumn.ReadOnly = True Then
                        ChkAddControl(VisibleIndex + 1)
                    Else
                        Exit Sub
                    End If
                End If
            End If
        Next
    End Sub
    '바인딩이 된 컨트롤이 그리드 인지 체크
    Private Function WebGridCheck() As Boolean
        If m_OnlyControl.GetType.FullName = "YJIT.SC.UI.SCControls.WebGrid" Then
            Return True
        End If
        Return False
    End Function
#End Region

#Region "== 팝업 생성 =="

    '파업 생성 관련 함수
    Public Sub PopUpInit(ByVal form As Object, ByVal onlyGrid As YJIT.SC.UI.SCControls.WebGrid, ByVal btnQuick As Object, Optional ByVal AddFirstFocusColumn As String = "", Optional ByVal AddEnterFocusColumn As String = "")
        CreatePopup(form, onlyGrid, AddFirstFocusColumn, AddEnterFocusColumn, btnQuick)
    End Sub
    Public Sub PopUpInit(ByVal form As Object, ByVal onlyGrid As YJIT.SC.UI.SCControls.WebGrid, Optional ByVal AddFirstFocusColumn As String = "", Optional ByVal AddEnterFocusColumn As String = "")
        CreatePopup(form, onlyGrid, AddFirstFocusColumn, AddEnterFocusColumn)
    End Sub
    Public Sub PopUpInit(ByVal form As Object, ByVal Cntr As Object)
        CreatePopup(form, Cntr)
    End Sub

    Public Sub PopUpInit(ByVal form As Object, ByVal Tree As DevExpress.XtraTreeList.TreeList)
        CreatePopup(form, Tree)
    End Sub
    Public Sub PopUpInit(ByVal form As Object)
        CreatePopup(form)
    End Sub
    '이벤트 지워주는 함수
    'Resources 생성 
    Private Function CreateImage() As DevExpress.Utils.ImageCollection
        'Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim resources As New System.ComponentModel.ComponentResourceManager(YJIT.SC.UI.SCView.MainFormInstance.GetType)
        Dim PopupBaseImage As New DevExpress.Utils.ImageCollection()
        PopupBaseImage.ImageStream = CType(resources.GetObject("PopupBaseImage.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        PopupBaseImage.Images.SetKeyName(0, "plus-circle.png")
        PopupBaseImage.Images.SetKeyName(1, "minus-octagon.png")
        PopupBaseImage.Images.SetKeyName(2, "export_excel.png")
        Return PopupBaseImage
    End Function
    '파업 생성
    Private Sub CreatePopup(ByVal form As Object, Optional ByVal OnlyControl As Object = Nothing, Optional ByVal AddFirstFocusFieldName As String = "", Optional ByVal AddEnterFocusColumn As String = "", Optional ByVal btnQuick As Object = Nothing)
        m_Me = form
        m_AddFirstFocusColumn = AddFirstFocusFieldName
        m_AddEnterFocusColumn = AddEnterFocusColumn
        m_Contols = New Dictionary(Of String, Object)

        If Not OnlyControl Is Nothing Then
            If OnlyControl.name <> "btnQuickMenu" Then
                m_OnlyControl = OnlyControl
            End If
        End If

        ' 판넬 ,그리드 리스트 가져옴 data는 m_Contols에 저장
        GetControlList()
        If m_Contols Is Nothing Then Exit Sub ' 없으면 종료

        '=========================================================================
        Dim barDockControlTop As New DevExpress.XtraBars.BarDockControl()
        Dim barDockControlBottom As New DevExpress.XtraBars.BarDockControl()
        Dim barDockControlLeft As New DevExpress.XtraBars.BarDockControl()
        Dim barDockControlRight As New DevExpress.XtraBars.BarDockControl()

        BarManager = New DevExpress.XtraBars.BarManager
        PopupMenu = New DevExpress.XtraBars.PopupMenu()

        CType(PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(m_Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        form.SuspendLayout()
        barDockControlTop.CausesValidation = False
        barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        barDockControlTop.Location = New System.Drawing.Point(0, 0)
        barDockControlTop.Size = New System.Drawing.Size(1262, 0)

        barDockControlBottom.CausesValidation = False
        barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        barDockControlBottom.Location = New System.Drawing.Point(0, 655)
        barDockControlBottom.Size = New System.Drawing.Size(1262, 0)

        barDockControlLeft.CausesValidation = False
        barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        barDockControlLeft.Size = New System.Drawing.Size(0, 655)

        barDockControlRight.CausesValidation = False
        barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        barDockControlRight.Location = New System.Drawing.Point(1262, 0)
        barDockControlRight.Size = New System.Drawing.Size(0, 655)
        '=========================================================================

        Dim maxCnt As Integer = 0
        Dim GroupEvent As Boolean = False
        Dim MultiSelect As Boolean = False
        Dim PopupBaseImage As DevExpress.Utils.ImageCollection = CreateImage()
        Dim GroupHeaderDic As New Dictionary(Of String, Object) ' 그룹 해더 정보 임시로 담아둠

        'Localizer 일괄 처리 
        For i = 0 To m_DataSource.Rows.Count - 1
            m_DataSource.Rows(i)("Caption") = m_Me.Localizer1.GetLocalizedString(m_DataSource.Rows(i)("Caption"))
        Next
        '======================================================================'
        ' 그룹 아이템 생성, 아이템 리스트 생성
        '======================================================================'
        For i = 0 To m_DataSource.Rows.Count - 1
            Dim BarBtnMng As Object = Nothing
            Dim BarButtonItem As DevExpress.XtraBars.BarButtonItem = Nothing
            Dim BarCheckItem As DevExpress.XtraBars.BarCheckItem = Nothing
            Dim BarTextBox As DevExpress.XtraBars.BarEditItem = Nothing

            Dim Caption As String = m_DataSource.Rows(i)("Caption")
            Dim ActionType As Action = m_DataSource.Rows(i)("Action")
            Dim GroupLine As Boolean = m_DataSource.Rows(i)("GroupLine")
            Dim BarIcon As Integer = m_DataSource.Rows(i)("BarIcon")
            Dim Key As String = m_DataSource.Rows(i)("Key")
            Dim UpperKey As String = m_DataSource.Rows(i)("UpperKey").ToString
            'GroupItem 이면  나중에 넣어줌
            If UpperKey <> "" Then
                If Action.GroupHeader = ActionType Then
                    '순서 대로 생성하기 위해 미리 만들지 않음.
                    'GROUP ITEM 생성
                    'CreateGroupItem(GroupHeaderDic, Caption, maxCnt, Key, GroupLine, True, UpperKey)
                    Continue For
                Else
                    Continue For
                End If

            ElseIf Action.GroupHeader = ActionType Then
                'GROUP ITEM 생성
                CreateGroupItem(GroupHeaderDic, Caption, maxCnt, Key, GroupLine, BarIcon, False)
            Else
                If ActionType <> Action.TextBox _
                    And ActionType <> Action.TextBoxDate _
                    And ActionType <> Action.TextBoxTime Then
                    '그 외 아이템 생성
                    BarButtonItem = New DevExpress.XtraBars.BarButtonItem
                    BarManager.Images = PopupBaseImage
                    AddHandler BarButtonItem.ItemClick, AddressOf BtnBarItem_ItemClick
                    BarBtnMng = BarButtonItem
                    BarManager.Items.Add(BarBtnMng)
                    PopupMenu.LinksPersistInfo.Add(New DevExpress.XtraBars.LinkPersistInfo(BarBtnMng, GroupLine))

                    Select Case ActionType
                        Case Action.Addrow
                            BarButtonItem.ImageIndex = 0
                        Case Action.DeleteRow
                            BarButtonItem.ImageIndex = 1
                        Case Action.DeleteSelectRows
                            BarButtonItem.ImageIndex = 1
                            MultiSelect = True
                        Case Action.Excel
                            BarButtonItem.ImageIndex = 2
                        Case Else
                            BarButtonItem.ImageIndex = BarIcon
                    End Select

                    BarBtnMng.Caption = Caption
                    m_Me.Localizer1.SetWordID(BarBtnMng, Caption)
                Else
                    'text box 컨트롤 추가
                    BarTextBox = New DevExpress.XtraBars.BarEditItem
                    '==========================================================
                    'Textbox에 들어갈 Repository아이템을 만들어줌
                    CreateRepositoryItemTextEdit(ActionType)
                    Select Case ActionType
                        Case Action.TextBox
                            BarTextBox.Edit = RepositoryItemTextEdit_Nomal
                        Case Action.TextBoxDate
                            BarTextBox.Edit = RepositoryItemTextEdit_Date
                        Case Action.TextBoxTime
                            BarTextBox.Edit = RepositoryItemTextEdit_Time
                    End Select
                    '==========================================================

                    BarBtnMng = BarTextBox
                    Dim BarGroupItem As DevExpress.XtraBars.BarSubItem = Nothing

                    GroupHeaderDic.TryGetValue(UpperKey, BarGroupItem)
                    If BarGroupItem Is Nothing Then
                        BarManager.Items.Add(BarBtnMng)
                        PopupMenu.LinksPersistInfo.Add(New DevExpress.XtraBars.LinkPersistInfo(BarBtnMng, GroupLine))
                    Else
                        BarGroupItem.AddItem(BarTextBox)
                    End If

                    'text box 포커스 찾기위한 이벤트 추가 
                    AddHandler BarTextBox.EditValueChanged, AddressOf BarTextBoxEditValueChanged
                End If
                BarBtnMng.Caption = Caption
                BarBtnMng.Id = maxCnt
                BarBtnMng.Name = Key
                m_DataSource.Rows(i)("ID") = maxCnt

                maxCnt += 1
            End If

        Next
        '======================================================================'
        ' 그룹 서브 아이템 생성 
        '======================================================================'
        For i = 0 To m_DataSource.Rows.Count - 1
            Dim BarBtnMng As Object = Nothing
            Dim BarButtonItem As DevExpress.XtraBars.BarButtonItem = Nothing
            Dim BarTextBox As DevExpress.XtraBars.BarEditItem = Nothing

            Dim Caption As String = m_DataSource.Rows(i)("Caption")
            Dim ActionType As Action = m_DataSource.Rows(i)("Action")
            Dim GroupLine As Boolean = m_DataSource.Rows(i)("GroupLine")
            Dim BarIcon As Integer = m_DataSource.Rows(i)("BarIcon")
            Dim Key As String = m_DataSource.Rows(i)("Key")
            Dim UpperKey As String = m_DataSource.Rows(i)("UpperKey").ToString
            'GroupItem 이면  나중에 넣어줌
            If UpperKey <> "" Then
                If ActionType = Action.GroupHeader Then
                    'GROUP ITEM 생성 
                    CreateGroupItem(GroupHeaderDic, Caption, maxCnt, Key, GroupLine, BarIcon, True, UpperKey)
                Else
                    'text box 아닌것
                    If ActionType <> Action.TextBox _
                     And ActionType <> Action.TextBoxDate _
                     And ActionType <> Action.TextBoxTime Then
                        BarButtonItem = New DevExpress.XtraBars.BarButtonItem
                        BarManager.Images = PopupBaseImage
                        BarBtnMng = BarButtonItem
                        AddHandler BarButtonItem.ItemClick, AddressOf BtnBarItem_ItemClick

                        Dim BarGroupItem As DevExpress.XtraBars.BarSubItem = Nothing
                        GroupHeaderDic.TryGetValue(UpperKey, BarGroupItem)
                        If BarGroupItem Is Nothing Then
                            BarManager.Items.Add(BarBtnMng)
                            PopupMenu.LinksPersistInfo.Add(New DevExpress.XtraBars.LinkPersistInfo(BarBtnMng, GroupLine))
                        Else
                            ' Hjkim : 20150507 : GroupLine 표시 되게 설정
                            'BarGroupItem.AddItem(BarButtonItem)
                            BarManager.Items.Add(BarButtonItem)
                            BarGroupItem.LinksPersistInfo.Add(New DevExpress.XtraBars.LinkPersistInfo(BarButtonItem, GroupLine))
                        End If

                        Select Case ActionType
                            Case Action.Addrow
                                BarButtonItem.ImageIndex = 0
                            Case Action.DeleteRow
                                BarButtonItem.ImageIndex = 1
                            Case Action.DeleteSelectRows
                                BarButtonItem.ImageIndex = 1
                                MultiSelect = True
                            Case Action.Excel
                                BarButtonItem.ImageIndex = 2
                            Case Else
                                BarButtonItem.ImageIndex = BarIcon
                        End Select
                    Else
                        'text box 컨트롤 추가
                        BarTextBox = New DevExpress.XtraBars.BarEditItem

                        '==========================================================
                        'Textbox에 들어갈 Repository아이템을 만들어줌
                        CreateRepositoryItemTextEdit(ActionType)
                        Select Case ActionType
                            Case Action.TextBox
                                BarTextBox.Edit = RepositoryItemTextEdit_Nomal
                            Case Action.TextBoxDate
                                BarTextBox.Edit = RepositoryItemTextEdit_Date
                            Case Action.TextBoxTime
                                BarTextBox.Edit = RepositoryItemTextEdit_Time
                        End Select
                        '==========================================================
                        BarBtnMng = BarTextBox
                        Dim BarGroupItem As DevExpress.XtraBars.BarSubItem = Nothing

                        GroupHeaderDic.TryGetValue(UpperKey, BarGroupItem)
                        If BarGroupItem Is Nothing Then
                            BarManager.Items.Add(BarBtnMng)
                            PopupMenu.LinksPersistInfo.Add(New DevExpress.XtraBars.LinkPersistInfo(BarBtnMng, GroupLine))
                        Else
                            BarGroupItem.AddItem(BarTextBox)
                        End If
                        AddHandler BarTextBox.EditValueChanged, AddressOf BarTextBoxEditValueChanged
                    End If
                    BarBtnMng.Caption = Caption
                    m_Me.Localizer1.SetWordID(BarBtnMng, Caption)
                    BarBtnMng.Id = maxCnt
                    BarBtnMng.Name = m_DataSource.Rows(i)("Key")
                    m_DataSource.Rows(i)("ID") = maxCnt
                    maxCnt += 1
                End If
            Else
                Continue For
            End If
        Next

        BarManager.DockControls.Add(barDockControlTop)
        BarManager.DockControls.Add(barDockControlBottom)
        BarManager.DockControls.Add(barDockControlLeft)
        BarManager.DockControls.Add(barDockControlRight)
        BarManager.Form = form
        BarManager.MaxItemId = maxCnt

        PopupMenu.Manager = BarManager
        PopupMenu.Name = "PopupMenu"
        form.Controls.Add(barDockControlTop)
        form.Controls.Add(barDockControlBottom)
        form.Controls.Add(barDockControlLeft)
        form.Controls.Add(barDockControlRight)

        For Each Keys In m_Contols.Keys
            Dim cntr As Control = CType(m_Contols(Keys), Control)
            AddHandler cntr.MouseClick, AddressOf Control_MouseClick
        Next

        If Not m_OnlyControl Is Nothing Then
            Dim Control As Object = Nothing
            Select Case m_OnlyControl.GetType.FullName
                Case "YJIT.SC.UI.SCControls.WebGrid"
                    Control = m_OnlyControl.MainView
                    Dim Gv As DevExpress.XtraGrid.Views.Grid.GridView = Nothing
                    Dim Bgv As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView = Nothing
                    Dim Agv As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView = Nothing
                    If MultiSelect Then
                        Control.OptionsSelection.MultiSelect = True
                    End If
                    Select Case Control.GetType.FullName
                        Case "DevExpress.XtraGrid.Views.Grid.GridView"
                            Gv = Control
                            AddHandler Gv.KeyDown, AddressOf GV_KeyDown
                            If GroupEvent Then AddHandler Gv.EndGrouping, AddressOf GV_EndGrouping
                        Case "DevExpress.XtraGrid.Views.BandedGrid.BandedGridView"
                            Bgv = Control
                            AddHandler Bgv.KeyDown, AddressOf GV_KeyDown
                            If GroupEvent Then AddHandler Bgv.EndGrouping, AddressOf GV_EndGrouping
                        Case "DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView"
                            Agv = Control
                            AddHandler Agv.KeyDown, AddressOf GV_KeyDown
                            If GroupEvent Then AddHandler Agv.EndGrouping, AddressOf GV_EndGrouping
                    End Select
                    Dim WG As YJIT.SC.UI.SCControls.WebGrid = m_OnlyControl
                    AddHandler WG.EditorKeyUp, AddressOf WG_EditorKeyUp
                    AddHandler WG.KeyUp, AddressOf WG_EditorKeyUp

                    If Not IsNothing(btnQuick) Then
                        Dim cntr As Control = CType(btnQuick, Control)
                        AddHandler cntr.Click, AddressOf btnQuickMenuClick
                    End If
                Case "DevExpress.XtraTreeList.TreeList"
                    Dim TreeList As DevExpress.XtraTreeList.TreeList = CType(m_OnlyControl, DevExpress.XtraTreeList.TreeList)
            End Select

        End If

        'BarManager key Event 추가 
        AddHandler BarManager.EditorKeyDown, AddressOf BarManagerKeyPressEventArgs

        Try
            If OnlyControl IsNot Nothing AndAlso OnlyControl.name = "btnQuickMenu" Then
                Dim cntr As Control = CType(OnlyControl, Control)
                AddHandler cntr.Click, AddressOf btnQuickMenuClick
            End If
        Catch ex As Exception
        End Try


        CType(PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(m_Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        form.ResumeLayout()
    End Sub

    ' CretaePopUp 시 그룹 아이템 생성해줌
    Private Sub CreateGroupItem(ByRef GroupHeaderDic As Dictionary(Of String, Object) _
                                , ByVal Caption As String _
                                , ByRef maxCnt As Integer _
                                , ByVal Key As String _
                                , ByVal GroupLine As Boolean _
                                 , ByVal BarIcon As Integer _
                                , ByVal Child As Boolean _
                                , Optional ByVal UpperKey As String = "")
        '그룹 해더 생성 
        Dim BarGroupItem As New DevExpress.XtraBars.BarSubItem
        BarGroupItem.Caption = Caption
        m_Me.Localizer1.SetWordID(BarGroupItem, Caption)
        BarGroupItem.Id = maxCnt
        BarGroupItem.Name = Key
        If Child = False Then
            BarManager.Items.Add(BarGroupItem)
            PopupMenu.LinksPersistInfo.Add(New DevExpress.XtraBars.LinkPersistInfo(BarGroupItem, GroupLine))
        Else
            Dim MotherGroup As DevExpress.XtraBars.BarSubItem = Nothing
            GroupHeaderDic.TryGetValue(UpperKey, MotherGroup)

            If MotherGroup Is Nothing Then
                BarManager.Items.Add(BarGroupItem)
                PopupMenu.LinksPersistInfo.Add(New DevExpress.XtraBars.LinkPersistInfo(BarGroupItem, GroupLine))
            Else
                MotherGroup.AddItem(BarGroupItem)
            End If
        End If

        ' Hjkim : 2017-11-02 : 서브그룹에 이미지 적용
        BarGroupItem.ImageIndex = BarIcon

        GroupHeaderDic(Key) = BarGroupItem
        maxCnt += 1
    End Sub

    Private Sub CreateRepositoryItemTextEdit(ByVal param As Action)
        ' nomal text box
        If param = Action.TextBox Then
            If RepositoryItemTextEdit_Nomal Is Nothing Then
                RepositoryItemTextEdit_Nomal = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
                RepositoryItemTextEdit_Nomal.AutoHeight = False
                RepositoryItemTextEdit_Nomal.Name = "RepositoryItemTextEdit_Nomal"
            End If
        End If

        If param = Action.TextBoxDate Then
            If RepositoryItemTextEdit_Date Is Nothing Then
                RepositoryItemTextEdit_Date = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
                RepositoryItemTextEdit_Date.AutoHeight = False
                RepositoryItemTextEdit_Date.Name = "RepositoryItemTextEdit_Date"
                RepositoryItemTextEdit_Date.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None
                RepositoryItemTextEdit_Date.Mask.EditMask = "0000-00-00"
                RepositoryItemTextEdit_Date.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
                RepositoryItemTextEdit_Date.Mask.UseMaskAsDisplayFormat = True
            End If
        End If

        If param = Action.TextBoxTime Then
            If RepositoryItemTextEdit_Time Is Nothing Then
                RepositoryItemTextEdit_Time = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
                RepositoryItemTextEdit_Time.AutoHeight = False
                RepositoryItemTextEdit_Time.Name = "RepositoryItemTextEdit_time"
                RepositoryItemTextEdit_Time.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None
                RepositoryItemTextEdit_Time.Mask.EditMask = "00:00"
                RepositoryItemTextEdit_Time.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
                RepositoryItemTextEdit_Time.Mask.UseMaskAsDisplayFormat = True
            End If
        End If
    End Sub
#End Region

#Region " == 컨트롤 이벤트 =="
    '이벤트 리무브
    Private Sub RemoveEventHandler()

        If m_Contols Is Nothing Then Exit Sub ' 없으면 종료
        For Each Keys In m_Contols.Keys
            Dim cntr As Control = CType(m_Contols(Keys), Control)
            RemoveHandler cntr.MouseClick, AddressOf Control_MouseClick
            If WebGridCheck() Then
                RemoveHandler CType(m_OnlyControl, YJIT.SC.UI.SCControls.WebGrid).EditorKeyUp, AddressOf WG_EditorKeyUp
                RemoveHandler CType(m_OnlyControl, YJIT.SC.UI.SCControls.WebGrid).KeyUp, AddressOf WG_EditorKeyUp
            End If
        Next
    End Sub

    Public Sub RemoveEvent()
        RemoveEventHandler()
    End Sub
    '아이템 클릭시
    Private Sub BtnBarItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Dic As New Dictionary(Of Object, String)
        Dim frmMain As YJIT.SC.UI.IMainForm = m_Me.MdiParent
        Dim Key As String = e.Item.Name
        Dim dr() As DataRow = m_DataSource.Select("Key = '" & Key & "'")


        Try
            Dim chkDr() As DataRow = m_DataSource.Select("ID = '" & e.Item.Id & "'")
            If Not m_OnlyControl Is Nothing Then
                chkDr(0)("Sender") = m_OnlyControl.Name
            Else
                chkDr(0)("Sender") = ""
            End If
            chkDr(0)("Cancel") = False
            PopUpOnBeforeClick(chkDr(0))
            If chkDr(0)("Cancel") = False Then
                Select Case chkDr(0)("Action")
                    Case Action.Addrow
                        AddRow(chkDr(0))
                    Case Action.DeleteRow
                        DeleteRow(chkDr(0))
                    Case Action.DeleteSelectRows
                        DeleteSelectRows(chkDr(0))
                    Case Action.Excel
                        ExcelExport(chkDr(0))
                    Case Else
                        PopUpOnAfterClick(chkDr(0))
                End Select
            End If
        Catch ex As Exception

        End Try


    End Sub
    '메뉴 리스트 열리는 이벤트 판넬 이벤트(추가용), 개별 이벤트용
    Private Sub Control_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                Dim DataDic As Dictionary(Of String, Boolean) = MenuListBeforeShow()
                For i = 0 To BarManager.Items.Count - 1
                    Dim ItemName As String = BarManager.Items(i).Name
                    If DataDic.ContainsKey(ItemName) Then
                        If DataDic(ItemName) Then
                            BarManager.Items(i).Enabled = True
                        Else
                            BarManager.Items(i).Enabled = False
                        End If

                        Dim dr() As DataRow = m_DataSource.Select("Key = '" & ItemName & "'")
                        If dr.Length > 0 Then
                            BarManager.Items(i).Caption = dr(0)("Caption")
                        End If
                    End If
                Next

                PopupMenu.ShowPopup(BarManager, Control.MousePosition)
            End If
        Catch ex As Exception

        End Try
    End Sub

    'GV_EndGrouping
    Private Sub GV_EndGrouping(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BarCheckReSetting()
    End Sub

    'GV_KeyDown
    Overridable Sub GV_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ' Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = m_OnlyControl.MainView
            Dim gv As Object = m_OnlyControl.MainView
            Dim dt As DataTable = PopupDt()
            dt.Rows.Add(Action.EventKey, "Enter", "Enter", False, BarIcon.None, "99", m_OnlyControl.Name, "")
            If gv.FocusedColumn.FieldName = m_AddEnterFocusColumn Then
                If gv.FocusedRowHandle = gv.RowCount - 1 Then
                    dt.Rows(0)("Cancel") = False
                    PopUpOnBeforeClick(dt.Rows(0))
                    If dt.Rows(0)("Cancel") = False Then
                        AddRow(dt.Rows(0))
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub
    'WG_EditorKeyUp
    Private Sub WG_EditorKeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F12 Then
            Dim info As GridViewInfo = CType(sender.MainView.GetViewInfo(), GridViewInfo)
            Dim cellInfo As GridCellInfo = info.GetGridCellInfo(sender.MainView.FocusedRowHandle, sender.MainView.FocusedColumn)
            Dim position As Point
            Dim CellWidth As Integer
            Dim CellHeight As Integer
            If cellInfo Is Nothing Then
                position = New Point(0, 0)
            Else
                CellWidth = cellInfo.Bounds.Width - 5
                CellHeight = cellInfo.Bounds.Height / 2
                Dim SubPoint As New Point(CellWidth, CellHeight)
                position = cellInfo.Bounds.Location + SubPoint
            End If
            Dim WgRowPosition As Point = CType(m_Me, Windows.Forms.Form).PointToScreen(PointToForm(sender) + position)
            Try
                PopupMenu.ShowPopup(BarManager, WgRowPosition)
            Catch ex As Exception

            End Try


        End If

    End Sub
    'Textbox에서 Enter key 쳤을때 이벤트
    Private Sub BarManagerKeyPressEventArgs(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            EnterKeyPress = True
        End If
    End Sub
    'text box 포커스찾기 위한 함수( text box에서만 사용 )
    'Private Sub BarManagerShownEditor(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
    '    BarItemFocusedName = e.Item.Name 
    'End Sub

    'EditValueChanged enter 이벤트 잡기 힘들어서
    'BarManagerKeyPressEventArgs -> Enter시 포커스 잃으면서 
    'BarTextBoxEditValueChanged 를 타게 됨
    '메뉴를 열때  MenuListBeforeShow에서 EnterKeyPress값을 false로 해줌 
    'text box EditValueChanged
    Private Sub BarTextBoxEditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If EnterKeyPress = True Then
            If CType(sender, DevExpress.XtraBars.BarEditItem).EditValue <> "" Then
                Dim ItemName As String = CType(sender, DevExpress.XtraBars.BarEditItem).Name
                Try
                    Dim DataRows() As DataRow = m_DataSource.Select("Key = '" & ItemName & "'")
                    If DataRows.Length > 0 Then

                        DataRows(0)("Caption") = CType(sender, DevExpress.XtraBars.BarEditItem).EditValue
                        DataRows(0)("Cancel") = False
                        PopUpOnBeforeClick(DataRows(0))
                        If DataRows(0)("Cancel") = False Then
                            PopUpOnAfterClick(DataRows(0))
                        End If
                    End If
                Catch ex As Exception

                End Try
            End If
        End If

        EnterKeyPress = False
    End Sub

#End Region

#Region " == 클릭 관련 이벤트 함수 =="
    'AddRow
    Public Sub AddRow(Optional ByRef Datarow As DataRow = Nothing)
        If Not WebGridCheck() Then Exit Sub
        Dim gview As Object = m_OnlyControl.MainView
        Dim Gv As DevExpress.XtraGrid.Views.Grid.GridView = Nothing
        Dim Bgv As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView = Nothing
        Dim Agv As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView = Nothing
        m_OnlyControl.AddRow()

        PopUpOnAfterClick(Datarow)
        Try
            Select Case gview.GetType.FullName
                Case "DevExpress.XtraGrid.Views.Grid.GridView"
                    Gv = m_OnlyControl.MainView
                    Gv.FocusedColumn = Gv.Columns(m_AddFirstFocusColumn)
                Case "DevExpress.XtraGrid.Views.BandedGrid.BandedGridView"
                    Bgv = m_OnlyControl.MainView
                    Bgv.FocusedColumn = Bgv.Columns(m_AddFirstFocusColumn)
                Case "DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView"
                    Agv = m_OnlyControl.MainView
                    Agv.FocusedColumn = Agv.Columns(m_AddFirstFocusColumn)
            End Select
        Catch ex As Exception
            If ClientSessionInfo.UserID = "ADMIN" Then DevExpress.XtraEditors.XtraMessageBox.Show("그리드에서 줄 추가후 포커스 이동 중에 에러가 발생했습니다.")
        End Try
        gview.ShowEditor()

    End Sub
    'DeleteRow
    Public Sub DeleteRow(Optional ByRef Datarow As DataRow = Nothing)
        If Not WebGridCheck() Then Exit Sub

        m_OnlyControl.DeleteRow()
        PopUpOnAfterClick(Datarow)
    End Sub
    'DeleteSelectRows
    Private Sub DeleteSelectRows(Optional ByRef Datarow As DataRow = Nothing)
        If Not WebGridCheck() Then Exit Sub
        Dim Gv As DevExpress.XtraGrid.Views.Grid.GridView = Nothing
        Dim Bgv As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView = Nothing
        Dim Agv As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView = Nothing


        Dim tempBollean As Boolean = m_OnlyControl.DeleteRowConfirmation
        Dim MainView As Object = m_OnlyControl.MainView
        If MainView.RowCount <> 0 Then
            Dim RowHandles() As Integer = MainView.GetSelectedRows


            For i = RowHandles.Length - 1 To 0 Step -1
                If tempBollean = True AndAlso i = RowHandles.Length - 1 Then
                    m_OnlyControl.DeleteRowConfirmation = True
                Else
                    m_OnlyControl.DeleteRowConfirmation = False
                End If
                MainView.FocusedRowHandle = RowHandles(i)
                m_OnlyControl.DeleteRow()
            Next

        Else
            m_OnlyControl.DeleteRowConfirmation = tempBollean
            PopUpOnAfterClick(Datarow)
        End If


    End Sub
    Private Sub ExcelExport(ByRef Datarow As DataRow)
        Datarow("TrxCode") = "N"
        Dim dlgSaveExcel = New System.Windows.Forms.SaveFileDialog()
        dlgSaveExcel.Filter = "Excel File (*.xlsx)|*.xlsx|Excel File (*.xls)|*.xls|All Files (*.*)|*.*"

        If WebGridCheck() Then
            ExportExcelGrid(Datarow, dlgSaveExcel)
        Else
            If Not m_OnlyControl Is Nothing Then
                Select Case m_OnlyControl.GetType.FullName
                    Case "DevExpress.XtraPivotGrid.PivotGridControl"
                        ExportExcelPivot(Datarow, dlgSaveExcel)
                    Case "DevExpress.XtraTreeList.TreeList"
                        ExportExcelTree(Datarow, dlgSaveExcel)
                End Select
            End If
        End If

        If Datarow("TrxCode") = "Y" Then
            If MsgBoxSC("Do you want open this file?", MessageBoxButtons.YesNo, "Open", MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim process As System.Diagnostics.Process = New System.Diagnostics.Process()
                process.StartInfo.FileName = dlgSaveExcel.FileName
                process.StartInfo.Verb = "Open"
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
                process.Start()
            End If
        End If
        PopUpOnAfterClick(Datarow)
    End Sub
    'Grrd
    Private Sub ExportExcelGrid(ByRef Datarow As DataRow, ByRef dlgSaveExcel As System.Windows.Forms.SaveFileDialog)
        Dim View As Object = m_OnlyControl.MainView ' nothing  CType(m_OnlyControl.MainView, DevExpress.XtraGrid.Views.Grid.GridView) 
        ' Dim View As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView = CType(WG1.MainView, DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView)
        If Not View Is Nothing Then

            If dlgSaveExcel.ShowDialog() = DialogResult.OK Then
                Dim currentCursor As Cursor = Cursor.Current
                Try
                    Cursor.Current = Cursors.WaitCursor
                    'View.OptionsPrint.ExpandAllDetails = True
                    View.OptionsPrint.ExpandAllGroups = False
                    'View.ExportToXls(dlgSaveExcel.FileName)
                    '180315 / LBH / EXPORT EXCEL 시 xlsx, xls 선택가능하도록 / CRM : YJITS2018031326 
                    If UCase(Right(dlgSaveExcel.FileName, 4)) = UCase(".xls") Then
                        View.ExportToXls(dlgSaveExcel.FileName)
                    Else
                        View.ExportToXlsx(dlgSaveExcel.FileName)
                    End If

                    'File Open  
                    Datarow("TrxCode") = "Y"
                Catch ex As Exception
                    Datarow("TrxCode") = "E"
                End Try
                Cursor.Current = currentCursor
            End If
        End If
        View.OptionsPrint.ExpandAllDetails = ViewExpandAllDetails
    End Sub
    'DevExpress.XtraPivotGrid.PivotGridControl
    Private Sub ExportExcelPivot(ByRef Datarow As DataRow, ByRef dlgSaveExcel As System.Windows.Forms.SaveFileDialog)
        If dlgSaveExcel.ShowDialog() = DialogResult.OK Then
            Dim currentCursor As Cursor = Cursor.Current
            Try
                Cursor.Current = Cursors.WaitCursor
                Dim Pivot As DevExpress.XtraPivotGrid.PivotGridControl = CType(m_OnlyControl, DevExpress.XtraPivotGrid.PivotGridControl)
                '180315 / LBH / EXPORT EXCEL 시 xlsx, xls 선택가능하도록 / CRM : YJITS2018031326
                'Pivot.ExportToXls(dlgSaveExcel.FileName)
                If UCase(Right(dlgSaveExcel.FileName, 4)) = UCase(".xls") Then
                    Pivot.ExportToXls(dlgSaveExcel.FileName)
                Else
                    Pivot.ExportToXlsx(dlgSaveExcel.FileName)
                End If
                Datarow("TrxCode") = "Y"
            Catch ex As Exception
                Datarow("TrxCode") = "E"
            End Try
            Cursor.Current = currentCursor
        End If
    End Sub
    'DevExpress.XtraTreeList.TreeList
    Private Sub ExportExcelTree(ByRef Datarow As DataRow, ByRef dlgSaveExcel As System.Windows.Forms.SaveFileDialog)
        If dlgSaveExcel.ShowDialog() = DialogResult.OK Then
            Dim currentCursor As Cursor = Cursor.Current
            Try
                Cursor.Current = Cursors.WaitCursor
                Dim Tree As DevExpress.XtraTreeList.TreeList = CType(m_OnlyControl, DevExpress.XtraTreeList.TreeList)
                'Tree.ExportToXls(dlgSaveExcel.FileName)
                '180315 / LBH / EXPORT EXCEL 시 xlsx, xls 선택가능하도록 / CRM : YJITS2018031326
                If UCase(Right(dlgSaveExcel.FileName, 4)) = UCase(".xls") Then
                    Tree.ExportToXls(dlgSaveExcel.FileName)
                Else
                    Tree.ExportToXlsx(dlgSaveExcel.FileName)
                End If
                Datarow("TrxCode") = "Y"
            Catch ex As Exception
                Datarow("TrxCode") = "E"
            End Try
            Cursor.Current = currentCursor
        End If
    End Sub
    '=====================================================================================================================

    'Check ITem은 그룹버튼으로 사용한다.
    Public Sub Grouping(ByVal sender As System.Object, ByRef Datarow As DataRow)
        Try
            Dim key As String = Datarow("KEY")
            Dim Caption As String = Datarow("Caption")
            Dim BarCheckItem As DevExpress.XtraBars.BarCheckItem = CType(sender, DevExpress.XtraBars.BarCheckItem)
            Dim GroupIndex As Integer = -1

            If BarCheckItem.Checked = True Then
                GroupIndex = m_GroupIndex
                m_GroupIndex += 1
            Else
                m_GroupIndex -= 1
                If m_GroupIndex < -1 Then m_GroupIndex = -1
            End If
            BarCheckItem.Caption = Caption

            Dim gview As Object = m_OnlyControl.MainView
            Dim Gv As DevExpress.XtraGrid.Views.Grid.GridView = Nothing
            Dim Bgv As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView = Nothing
            Dim Agv As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView = Nothing


            Select Case gview.GetType.FullName
                Case "DevExpress.XtraGrid.Views.Grid.GridView"
                    Gv = m_OnlyControl.MainView
                    Gv.Columns(key).GroupIndex = GroupIndex
                Case "DevExpress.XtraGrid.Views.BandedGrid.BandedGridView"
                    Bgv = m_OnlyControl.MainView
                    Bgv.Columns(key).GroupIndex = GroupIndex
                Case "DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView"
                    Agv = m_OnlyControl.MainView
                    Agv.Columns(key).GroupIndex = GroupIndex
            End Select
            gview.ExpandAllGroups()
            PopUpOnAfterClick(Datarow)
        Catch ex As Exception
            If ClientSessionInfo.UserID = "ADMIN" Then DevExpress.XtraEditors.XtraMessageBox.Show("그리드에서 Grouping 중에 에러가 발생했습니다.")
        End Try

    End Sub
    'TreeGroup

    Property CheckBoxValue(ByVal Key As String) As Boolean
        Get
            For i = 0 To BarManager.Items.Count - 1
                Dim BarCheckItem As DevExpress.XtraBars.BarCheckItem = Nothing
                Select Case BarManager.Items(i).GetType.FullName
                    Case "DevExpress.XtraBars.BarCheckItem"
                        BarCheckItem = BarManager.Items(i)
                        If Key = BarCheckItem.Name Then
                            Return BarCheckItem.Checked
                        End If
                    Case Else
                        Continue For
                End Select
            Next
            Return Nothing
        End Get
        Set(value As Boolean)
            For i = 0 To BarManager.Items.Count - 1
                Dim BarCheckItem As DevExpress.XtraBars.BarCheckItem = Nothing
                Select Case BarManager.Items(i).GetType.FullName
                    Case "DevExpress.XtraBars.BarCheckItem"
                        BarCheckItem = BarManager.Items(i)
                        If Key = BarCheckItem.Name Then
                            BarCheckItem.Checked = value
                        End If
                    Case Else
                        Continue For
                End Select
            Next
        End Set
    End Property
    Private Sub TreeGroup(ByVal sender As System.Object, ByRef DataRow As DataRow)
        Dim Key As String = sender.name
        For i = 0 To BarManager.Items.Count - 1
            Dim BarCheckItem As DevExpress.XtraBars.BarCheckItem = Nothing
            Select Case BarManager.Items(i).GetType.FullName
                Case "DevExpress.XtraBars.BarCheckItem"
                    BarCheckItem = BarManager.Items(i)
                    If Key <> BarCheckItem.Name Then
                        BarCheckItem.Checked = False
                    End If
                Case Else
                    Continue For
            End Select
        Next
        If sender.Checked Then
            DataRow("TrxCode") = "T"
        Else
            DataRow("TrxCode") = "F"
        End If

        PopUpOnAfterClick(DataRow)
    End Sub
    'PopUpOnClick
    Private Sub PopUpOnAfterClick(ByVal DataRow As DataRow)
        Try
            m_Me.PopUpOnAfterClick(DataRow)
        Catch ex As Exception

        End Try
    End Sub
    'PopUpOnBeforeClick
    Private Sub PopUpOnBeforeClick(ByRef DataRow As DataRow)
        Try
            m_Me.PopUpOnBeforeClick(DataRow)
        Catch ex As Exception

        End Try
    End Sub
    'MenuListBeforeShow
    Private Function MenuListBeforeShow() As Dictionary(Of String, Boolean)
        Dim DataDic As New Dictionary(Of String, Boolean)
        Dim dt As DataTable = m_DataSource.DefaultView.ToTable(True, {"Action", "Key", "ID", "Sender", "Enabled"})
        For i = 0 To dt.Rows.Count - 1
            DataDic(dt.Rows(i)("Key")) = True
        Next

        For i = 0 To BarManager.Items.Count - 1
            Dim ItemName As String = BarManager.Items(i).GetType.FullName
            If ItemName = "DevExpress.XtraBars.BarEditItem" Then
                CType(BarManager.Items(i), DevExpress.XtraBars.BarEditItem).EditValue = ""
            End If
        Next
        EnterKeyPress = False
        Try
            m_Me.MenuListBeforeShow(DataDic)
        Catch ex As Exception

        End Try
        Return DataDic
    End Function
#End Region

#Region " == 바 아이템 함수 =="
    '컨트롤의 체크 상태를 변경
    Private Sub ChageCheckState(ByVal BarCheckItem As DevExpress.XtraBars.BarCheckItem)
        If WebGridCheck() Then
            GridCheckState(BarCheckItem)
        Else
            TreeCheckState(BarCheckItem)
        End If
    End Sub
    Private Sub TreeCheckState(ByVal BarCheckItem As DevExpress.XtraBars.BarCheckItem)

    End Sub
    Private Sub GridCheckState(ByVal BarCheckItem As DevExpress.XtraBars.BarCheckItem)
        Dim gview As Object = m_OnlyControl.MainView
        Dim Gv As DevExpress.XtraGrid.Views.Grid.GridView = Nothing
        Dim Bgv As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView = Nothing
        Dim Agv As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView = Nothing
        Dim FieldName As String = BarCheckItem.Name
        Dim GroupIndex As Integer = -1
        Select Case gview.GetType.FullName
            Case "DevExpress.XtraGrid.Views.Grid.GridView"
                Gv = m_OnlyControl.MainView
                GroupIndex = Gv.Columns(FieldName).GroupIndex
            Case "DevExpress.XtraGrid.Views.BandedGrid.BandedGridView"
                Bgv = m_OnlyControl.MainView
                GroupIndex = Bgv.Columns(FieldName).GroupIndex
            Case "DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView"
                Agv = m_OnlyControl.MainView
                GroupIndex = Agv.Columns(FieldName).GroupIndex
        End Select
        If GroupIndex = -1 Then
            BarCheckItem.Checked = False
        Else
            BarCheckItem.Checked = True
        End If
    End Sub
    'Gird용
    Private Sub BarCheckReSetting()
        Try
            For i = 0 To BarManager.Items.Count - 1
                Dim BarCheckItem As DevExpress.XtraBars.BarCheckItem = Nothing
                Select Case BarManager.Items(i).GetType.FullName
                    Case "DevExpress.XtraBars.BarCheckItem"
                        BarCheckItem = BarManager.Items(i)
                    Case Else
                        Continue For
                End Select
                ChageCheckState(BarCheckItem)
            Next
        Catch ex As Exception
            If ClientSessionInfo.UserID = "ADMIN" Then DevExpress.XtraEditors.XtraMessageBox.Show("그리드에서 Grouping 중에 에러가 발생했습니다.")
        End Try
    End Sub
    'Check Bar item 의 check 상태 해제
    Public Sub CheckValueClear()
        Try
            For i = 0 To BarManager.Items.Count - 1
                Dim BarCheckItem As DevExpress.XtraBars.BarCheckItem = Nothing
                Select Case BarManager.Items(i).GetType.FullName
                    Case "DevExpress.XtraBars.BarCheckItem"
                        BarCheckItem = BarManager.Items(i)
                        CType(BarManager.Items(i), DevExpress.XtraBars.BarCheckItem).Checked = False
                    Case Else
                        Continue For
                End Select
            Next
        Catch ex As Exception
            If ClientSessionInfo.UserID = "ADMIN" Then DevExpress.XtraEditors.XtraMessageBox.Show("그리드에서 Grouping 중에 에러가 발생했습니다.")
        End Try
    End Sub

    Private Function PointToForm(ByVal target As Control) As Drawing.Point
        Dim retval As New Drawing.Point
        Dim control As Control = target

        'Me 는 폼 입니다.
        Do While (Not control Is m_Me)
            retval.Offset(control.Left, control.Top)
            control = control.Parent
        Loop
        Return retval
    End Function

#End Region

#Region "== Quick Menu 관련 =="

    Private Sub btnQuickMenuClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        Try
            Dim DataDic As Dictionary(Of String, Boolean) = MenuListBeforeShow()
            For i = 0 To BarManager.Items.Count - 1
                Dim ItemName As String = BarManager.Items(i).Name
                If DataDic.ContainsKey(ItemName) Then
                    If DataDic(ItemName) Then
                        BarManager.Items(i).Enabled = True
                    Else
                        BarManager.Items(i).Enabled = False
                    End If

                    Dim dr() As DataRow = m_DataSource.Select("Key = '" & ItemName & "'")
                    If dr.Length > 0 Then
                        BarManager.Items(i).Caption = dr(0)("Caption")
                    End If
                End If
            Next


            Dim x, y As Integer
            Dim pnt As Point
            Dim parentObj As Control = sender.Parent
            Do While parentObj IsNot sender.FindForm
                x += parentObj.Location.X
                y += parentObj.Location.Y
                parentObj = parentObj.Parent
            Loop

            pnt = CType(m_Me, Windows.Forms.Form).PointToScreen(sender.Location)
            pnt.Offset(x + 5, y + sender.size.Height + 5)

            PopupMenu.ShowPopup(BarManager, pnt)
            sender.Controls.Add(PopupMenu)

        Catch ex As Exception

        End Try
    End Sub

#End Region



End Class

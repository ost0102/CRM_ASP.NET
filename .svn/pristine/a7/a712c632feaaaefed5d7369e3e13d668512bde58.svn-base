Public Class MdmGroupAuth

#Region "=================Data logic actions==========="

    Private Sub PopupInit()
        '그리드 마우스 오른쪽 클릭 팝업 메뉴 설정
        Dim PopUp As New PopupBase

        PopUp.ItemAdd(Action.Other, "SelectAll", "&Select All")
        PopUp.ItemAdd(Action.Other, "UnselectAll", "&Unselect All")
        PopUp.ItemAdd(Action.Excel, "MdmUserAuth", "&Export Excel", True)
        PopUp.PopUpInit(Me, WG2)

    End Sub

    Public Sub PopUpOnAfterClick(ByVal dr As DataRow)

        Dim Key As String = dr("KEY")
        Dim Sender As String = dr("Sender")

        Select Case dr("Action")
            Case Action.Other
                Select Case Key
                    Case "SelectAll"
                        Call SelectUnSelectAll("Y")
                        'Call SelectAll()
                    Case "UnselectAll"
                        Call SelectUnSelectAll("N")
                        'Call UnSelectAll()
                End Select
        End Select

    End Sub

    Private Sub SelectUnSelectAll(ByVal useYN As String)
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = GV2
        Dim rowHandle As Integer = view.FocusedRowHandle

        If view.IsGroupRow(view.FocusedRowHandle) Then 'Group row
            SelectUnSelectGroup(view, rowHandle, useYN)
        Else
            Dim PgmId As String = view.GetRowCellValue(view.FocusedRowHandle, "PGM_ID").ToString
            Dim ddd As DataView = view.DataSource
            For i = 0 To ddd.Table.Rows.Count - 1
                If ddd.Table.Rows(i)("PGM_ID").ToString.Trim.ToUpper = PgmId Then
                    ddd.Table.Rows(i)("USE_YN") = useYN
                End If
            Next
        End If
    End Sub

    Private Sub SelectUnSelectGroup(ByVal View As DevExpress.XtraGrid.Views.Grid.GridView, ByVal GroupRowHandle As Integer, ByVal useYN As String)
        If Not View.IsGroupRow(GroupRowHandle) Then Return
        'Get the number of immediate children 
        Dim childCount As Integer = View.GetChildRowCount(GroupRowHandle)
        Dim i As Integer
        For i = 0 To childCount - 1
            'Get the handle of a child row with the required index 
            Dim childHandle As Integer = View.GetChildRowHandle(GroupRowHandle, i)
            'If the child is a group row Call self
            If View.IsGroupRow(childHandle) Then
                SelectUnSelectGroup(View, childHandle, useYN)
            Else
                View.SetRowCellValue(childHandle, "USE_YN", useYN)
            End If
        Next
    End Sub

    '예전 버전 소스 - 현재 사용하지 않음 (호출 부분에서 주석으로 막혀있음)
    Private Sub SelectAll()
        Dim PgmId As String = GV2.GetRowCellValue(GV2.FocusedRowHandle, "PGM_ID").ToString
        Dim ddd As DataView = GV2.DataSource
        For i = 0 To ddd.Table.Rows.Count - 1
            If ddd.Table.Rows(i)("PGM_ID").ToString.Trim.ToUpper = PgmId Then
                ddd.Table.Rows(i)("USE_YN") = "Y"
            End If
        Next
    End Sub

    Private Sub UnSelectAll()
        Dim PgmId As String = GV2.GetRowCellValue(GV2.FocusedRowHandle, "PGM_ID").ToString
        Dim ddd As DataView = GV2.DataSource
        For i = 0 To ddd.Table.Rows.Count - 1
            If ddd.Table.Rows(i)("PGM_ID").ToString.Trim.ToUpper = PgmId Then
                ddd.Table.Rows(i)("USE_YN") = "N"
            End If
        Next
    End Sub
    '예전 버전 소스 끝 - 현재 사용하지 않음 (호출 부분에서 주석으로 막혀있음)

    Public Sub SearchData()

        If Me.ValidateActionDataLogic(UI.ActionTypes.LoadData) = False Then Exit Sub
        Dim params() As Object = {}

        Dim ds As DataSet
        Dim dr As DataRow

        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MdmGroupAuth", "Search", params)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Confirm", MessageBoxIcon.Information)
            Exit Sub
        End If
        Me.BindToDataset(ds, "Data")
        Me.DataState = UI.DataStates.Retrieved

        GV1.FocusedRowHandle = 0

        SearchGroupAuth()


    End Sub

    Public Sub SearchGroupAuth()
        Dim groupId As String = GV1.GetRowCellValue(GV1.FocusedRowHandle, "GRP_ID")
        If String.IsNullOrEmpty(groupId) Then Exit Sub

        If Me.ValidateActionDataLogic(UI.ActionTypes.LoadData) = False Then Exit Sub

        Dim params() As Object = {groupId}
        Dim ds As DataSet
        Dim dr As DataRow

        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MdmGroupAuth", "SearchGroupAuth", params)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Confirm", MessageBoxIcon.Information)
            Exit Sub
        End If
        Me.BindToDataset(ds, "Data")
        Me.DataState = UI.DataStates.Retrieved

        'Set default grouping
        GV2.Columns("PGM_GRP").GroupIndex = 0
        GV2.Columns("PROGRAM_NAME").GroupIndex = 1

    End Sub

    Public Sub SaveData()

        If Me.ValidateActionDataLogic(UI.ActionTypes.UpdateData) = False Then Exit Sub
        Dim groupId As String = GV1.GetRowCellValue(GV1.FocusedRowHandle, "GRP_ID")

        If String.IsNullOrEmpty(groupId) Then
            MsgBoxLocalized("Please select a group!", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim dsParams As DataSet = Me.ConvertToDataset()
        dsParams.Tables("MAIN").Columns.Add("GRP_ID")
        dsParams.Tables("MAIN").Rows(0)("GRP_ID") = groupId

        Dim ds As DataSet
        Dim dr As DataRow

        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MdmGroupAuth", "Save", dsParams)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If
        Me.BindToDataset(ds, "Data")
        Me.DataState = UI.DataStates.Retrieved
        MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Confirm", MessageBoxIcon.Information)


    End Sub

#End Region

#Region "============Control events============"
    Private Sub MdmGroupAuth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call DrawRowIndicator({GV1, GV2})
        Call SearchData()

    End Sub
    Private Sub WG1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WG1.Click
        Call SearchGroupAuth()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub

    Private Sub MdmGroupAuth_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Call PopupInit()
    End Sub

    Private Sub btnCopy_Click(sender As System.Object, e As System.EventArgs) Handles btnCopy.Click
        Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
        Dim fTarget As Object = frmMain.NavigateTo("MdmGroupAuthCopy", NavigatedWindowModes.Dialog, False)

        Dim dt As DataTable = WG1.DataSource
        If Not IsNothing(fTarget) Then
            fTarget.dt = dt.Copy
            fTarget.focusHandle = GV1.FocusedRowHandle
            fTarget.ShowDialog()
        End If

        Call SearchGroupAuth()

    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub

#End Region


End Class
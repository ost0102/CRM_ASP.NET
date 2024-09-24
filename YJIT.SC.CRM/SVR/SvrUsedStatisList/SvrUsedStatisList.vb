Imports System.Drawing
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraTab
Imports YJIT.SC.UI

Public Class SvrUsedStatisList
#Region "=================GetConvertToDataset Function==========="

    Dim FormLoading As Boolean = True

    Private Function GetConvertToDataSet(ByVal Type As String) As DataSet
        Dim YJSql As New YJQuery
        'Dim IsSingleSearch As Boolean = False

        Select Case Type.ToUpper
            Case "Search".ToUpper
                YJSql.SqlBox("WG1", "SvrUsedStatisList@Search")
                YJSql.Params("DATE_FROM", S_DATE_FROM.Text)
                YJSql.Params("DATE_TO", S_DATE_TO.Text)
                YJSql.Blocks("IP_SEH_DIV_" & S_IP_SEH_DIV.SelectedValue, S_IP_SEH_DIV.SelectedValue)
                YJSql.Params("IP_SEH", S_IP_SEH.Text)

            Case "SearchTerm".ToUpper
                YJSql.SqlBox("WG2", "SvrUsedStatisList@SearchTerm")
                YJSql.Params("DATE_FROM", S_DATE_FROM.Text)
                YJSql.Params("DATE_TO", S_DATE_TO.Text)
                YJSql.Blocks("IP_SEH_DIV_" & S_IP_SEH_DIV.SelectedValue, S_IP_SEH_DIV.SelectedValue)
                YJSql.Params("IP_SEH", S_IP_SEH.Text)

            Case "SearchTime".ToUpper
                YJSql.SqlBox("WG3", "SvrUsedStatisList@SeachTime")
                YJSql.Params("DATE_TIME", S_DATE_TIME.Text)
                YJSql.Blocks("IP_SEH_DIV_" & S_IP_SEH_DIV.SelectedValue, S_IP_SEH_DIV.SelectedValue)
                YJSql.Params("IP_SEH", S_IP_SEH.Text)
        End Select
        Return YJSql.DataSet
    End Function
#End Region
#Region "=================Client Function==========="
    'Client Function : 클라이언트 동작 함수
    Private Sub InitPage()
        S_DATE_FROM.Text = Now.ToString("yyyyMM")
        S_DATE_TO.Text = Now.ToString("yyyyMM")
        S_IP_SEH_DIV.Text = "전체검색"
        S_DATE_TIME.Text = Now.ToString("yyyyMMdd")
    End Sub
    Private Sub InitGrid()
        Call DrawRowIndicator({GV1, GV2, GV3})

    End Sub
    Private Sub GV1_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles GV1.RowCellStyle
        '20230921 김성은, 이지선 컬럼 추가
        Select Case e.Column.FieldName.ToUpper
            Case "CPU_NM", "RAM_NM", "HDD_1_NM", "HDD_2_NM", "HDD_3_NM", "HDD_4_NM", "HDD_5_NM", "HDD_6_NM", "PRC_NM", "SESS_NM", "HDD_1_3_NM", "HDD_2_3_NM", "HDD_3_3_NM", "HDD_4_3_NM", "HDD_5_3_NM", "HDD_6_3_NM"
                e.Appearance.BackColor = Color.FromArgb(204, 230, 255)
                e.Appearance.ForeColor = Color.Black
            Case "HDD_1_USE_RATE"
                If CType(GV1.GetRowCellValue(e.RowHandle, "HDD_1_USE_RATE").ToString, Integer) >= 80 Then
                    e.Appearance.ForeColor = Color.Red
                End If
            Case "HDD_2_USE_RATE"
                If CType(GV1.GetRowCellValue(e.RowHandle, "HDD_2_USE_RATE").ToString, Integer) >= 80 Then
                    e.Appearance.ForeColor = Color.Red
                End If
            Case "HDD_3_USE_RATE"
                If CType(GV1.GetRowCellValue(e.RowHandle, "HDD_3_USE_RATE").ToString, Integer) >= 80 Then
                    e.Appearance.ForeColor = Color.Red
                End If
            Case "HDD_4_USE_RATE"
                If CType(GV1.GetRowCellValue(e.RowHandle, "HDD_4_USE_RATE").ToString, Integer) >= 80 Then
                    e.Appearance.ForeColor = Color.Red
                End If
            Case "HDD_5_USE_RATE"
                If CType(GV1.GetRowCellValue(e.RowHandle, "HDD_5_USE_RATE").ToString, Integer) >= 80 Then
                    e.Appearance.ForeColor = Color.Red
                End If
            Case "HDD_6_USE_RATE"
                If CType(GV1.GetRowCellValue(e.RowHandle, "HDD_6_USE_RATE").ToString, Integer) >= 80 Then
                    e.Appearance.ForeColor = Color.Red
                End If
            Case "HDD_1_USE_RATE_B"
                If CType(GV1.GetRowCellValue(e.RowHandle, "HDD_1_USE_RATE_B").ToString, Integer) >= 80 Then
                    e.Appearance.ForeColor = Color.Red
                End If
            Case "HDD_2_USE_RATE_B"
                If CType(GV1.GetRowCellValue(e.RowHandle, "HDD_2_USE_RATE_B").ToString, Integer) >= 80 Then
                    e.Appearance.ForeColor = Color.Red
                End If
            Case "HDD_3_USE_RATE_B"
                If CType(GV1.GetRowCellValue(e.RowHandle, "HDD_3_USE_RATE_B").ToString, Integer) >= 80 Then
                    e.Appearance.ForeColor = Color.Red
                End If
            Case "HDD_4_USE_RATE_B"
                If CType(GV1.GetRowCellValue(e.RowHandle, "HDD_4_USE_RATE_B").ToString, Integer) >= 80 Then
                    e.Appearance.ForeColor = Color.Red
                End If
            Case "HDD_5_USE_RATE_B"
                If CType(GV1.GetRowCellValue(e.RowHandle, "HDD_5_USE_RATE_B").ToString, Integer) >= 80 Then
                    e.Appearance.ForeColor = Color.Red
                End If
            Case "HDD_6_USE_RATE_B"
                If CType(GV1.GetRowCellValue(e.RowHandle, "HDD_6_USE_RATE_B").ToString, Integer) >= 80 Then
                    e.Appearance.ForeColor = Color.Red
                End If
        End Select

    End Sub
    Private Sub GV2_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles GV2.RowCellStyle
        '20230921 김성은, 이지선 컬럼 추가
        Select Case e.Column.FieldName.ToUpper
            Case "CPU_NM", "RAM_NM", "HDD_1_NM", "HDD_2_NM", "HDD_3_NM", "HDD_4_NM", "HDD_5_NM", "HDD_6_NM", "PRC_NM", "SESS_NM"
                e.Appearance.BackColor = Color.FromArgb(204, 230, 255)
        End Select
    End Sub
    Private Sub GV3_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles GV3.RowCellStyle
        '20230921 김성은, 이지선 컬럼 추가
        Select Case e.Column.FieldName.ToUpper
            Case "CPU_NM", "RAM_NM", "HDD_1_NM", "HDD_2_NM", "HDD_3_NM", "HDD_4_NM", "HDD_5_NM", "HDD_6_NM", "PRC_NM", "SESS_NM"
                e.Appearance.BackColor = Color.FromArgb(204, 230, 255)
        End Select
    End Sub
    Private Sub MainTab_SelectedPageChanged(sender As Object, e As TabPageChangedEventArgs) Handles MainTab.SelectedPageChanged
        If MainTab.SelectedTabPage.Name = TabPage_TIME.Name Then
            S_DATE_TIME.Visible = True
            S_DATE_FROM.Visible = False
            S_DATE_TO.Visible = False
            lbl_S_YEAR_MONTH.Visible = False
            S_DATE_TO.NextFocus = ""
            S_DATE_TIME.NextFocus = "S_IP_SEH_DIV"
        Else
            S_DATE_TIME.Visible = False
            S_DATE_FROM.Visible = True
            S_DATE_TO.Visible = True
            lbl_S_YEAR_MONTH.Visible = True
            S_DATE_TIME.NextFocus = ""
            S_DATE_TO.NextFocus = "S_IP_SEH_DIV"
        End If
    End Sub
#End Region
#Region "=================Data logic actions==========="
    Private Sub SearchData()
        If SearchValidate() = False Then Exit Sub

        Dim ds As DataSet = GetConvertToDataSet("Search")
        ds = Func.MethodCall(Me, "YJIT.Biz.SvrUsedStatisList", "Search", ds)

        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        Select Case dr("TrxCode").ToString
            Case "Y"
                Me.BindToDataset(ds, "Data")
                Me.DataState = UI.DataStates.None
            Case "N"
                ClearView(UI.AppliedRangeTypes.Only, {WG1})
                Me.DataState = UI.DataStates.None
            Case Else
                MsgBoxLocalized(dr("trxMsg").ToString)
                Exit Sub
        End Select
    End Sub
    Private Sub SearchDataTerm()
        If SearchValidate() = False Then Exit Sub

        Dim ds As DataSet = GetConvertToDataSet("SearchTerm")
        ds = Func.MethodCall(Me, "YJIT.Biz.SvrUsedStatisList", "Search", ds)

        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        Select Case dr("TrxCode").ToString
            Case "Y", "N"
                Me.BindToDataset(ds, "Data")
                Me.DataState = UI.DataStates.None
            Case "E"
                MsgBoxLocalized(dr("TrxMsg").ToString)
        End Select
    End Sub
    Private Sub SearchDataTime()
        If SearchValidate() = False Then Exit Sub

        Dim ds As DataSet = GetConvertToDataSet("SearchTime")
        ds = Func.MethodCall(Me, "YJIT.Biz.SvrUsedStatisList", "Search", ds)

        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        Select Case dr("TrxCode").ToString
            Case "Y", "N"
                Me.BindToDataset(ds, "Data")
                Me.DataState = UI.DataStates.None
            Case "E"
                MsgBoxLocalized(dr("TrxMsg").ToString)
        End Select
    End Sub
    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing

        Try
            If String.IsNullOrEmpty(S_DATE_FROM.Text) OrElse String.IsNullOrEmpty(S_DATE_TO.Text) Then
                If String.IsNullOrEmpty(S_DATE_FROM.Text) Then
                    ErrControl = S_DATE_FROM
                Else
                    ErrControl = S_DATE_TO
                End If
                ErrMsg = Func.Msg(Me, "{0}을 입력해주세요.", lbl_S_DATE.Text) & vbNewLine
            End If

            If Not String.IsNullOrEmpty(ErrMsg) Then
                If Not ErrControl Is Nothing Then ErrControl.Focus()
                Throw New Exception(ErrMsg)
            End If
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
        Return True
    End Function
#End Region
#Region "=================Control Events==========="
    Private Sub CrmSvrInfoLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FormLoading = True
        Call InitPage()
        Call InitGrid()

    End Sub
    Private Sub CrmSvrInfoLog_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        S_DATE_FROM.Focus()

        FormLoading = False
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If MainTab.SelectedTabPage.Name = TabPage_TIME.Name Then
            Call SearchDataTime()
        Else
            Call SearchData()
            Call SearchDataTerm()
        End If
    End Sub

    '20230921 김성은, 이지선 조회조건에 따라 컬럼 숨김 기능 추가
    Private LayoutFilePath() As String ' 다른 메서드에서도 사용가능
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LayoutFilePath = New String() {
            System.Windows.Forms.Application.StartupPath & "\GridLayout\SvrUsedStatisListGV1",
            System.Windows.Forms.Application.StartupPath & "\GridLayout\SvrUsedStatisListGV2",
            System.Windows.Forms.Application.StartupPath & "\GridLayout\SvrUsedStatisListGV3"
        }

        ' 각 그리드의 초기 레이아웃을 저장.
        GV1.SaveLayoutToXml(LayoutFilePath(0))
        GV2.SaveLayoutToXml(LayoutFilePath(1))
        GV3.SaveLayoutToXml(LayoutFilePath(2))
    End Sub
    Private Sub HDDColumns(GV1 As AdvBandedGridView, GV2 As AdvBandedGridView, GV3 As AdvBandedGridView, i As Integer, isVisible As Boolean)
        Dim prefix As String = "HDD_" & i.ToString() & "_"
        For j As Integer = 1 To 31

            GV1.Columns(prefix & "NM").Visible = isVisible
            GV1.Columns(prefix & "INFO").Visible = isVisible
            GV1.Columns(prefix & "USE_RATE").Visible = isVisible
            GV1.Columns(prefix & "USE_RATE_G").Visible = isVisible
            GV1.Columns(prefix & "3_NM").Visible = isVisible
            GV1.Columns(prefix & "INFO_B").Visible = isVisible
            GV1.Columns(prefix & "USE_RATE_B").Visible = isVisible
            GV1.Columns(prefix & "USE_RATE_A").Visible = isVisible
            GV1.Columns(prefix & "USE_RATE_A_G").Visible = isVisible

            GV2.Columns(prefix & "NM").Visible = isVisible
            GV2.Columns(prefix & "USE_RATE_" & j.ToString("00")).Visible = isVisible
        Next

        For k As Integer = 1 To 24
            GV3.Columns(prefix & "USE_RATE_" & k.ToString("00")).Visible = isVisible
            GV3.Columns(prefix & "NM").Visible = isVisible
        Next
    End Sub

    Private Sub RowCounts(GV1 As AdvBandedGridView, GV2 As AdvBandedGridView, GV3 As AdvBandedGridView, counts As Integer())

        GV1_SERVER_IP.RowCount = counts(0)
        GV1_SERVER_IP_EXT.RowCount = counts(1)
        GV1_SERVER_DIV.RowCount = counts(2)

        GV2_SERVER_IP.RowCount = counts(3)
        GV2_SERVER_IP_EXT.RowCount = counts(4)
        GV2_SERVER_DIV.RowCount = counts(5)

        GV3_SERVER_IP.RowCount = counts(6)
        GV3_SERVER_IP_EXT.RowCount = counts(7)
        GV3_SERVER_DIV.RowCount = counts(8)
    End Sub

    Private Sub S_SEARCH_HDD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles S_SEARCH_HDD.SelectedIndexChanged
        If FormLoading = True Then Exit Sub

        ' 초기 레이아웃 불러옴
        GV1.RestoreLayoutFromXml(LayoutFilePath(0))
        GV2.RestoreLayoutFromXml(LayoutFilePath(1))
        GV3.RestoreLayoutFromXml(LayoutFilePath(2))

        Select Case S_SEARCH_HDD.SelectedValue
            Case "CPU"
                Dim columnNames() As String = {"CPU_NM", "PRC_NM", "RAM_NM", "SERVER_IP", "SERVER_IP_EXT", "SERVER_DIV", "SESS_NM"}

                For Each gv As AdvBandedGridView In {GV1, GV2, GV3}
                    For Each column As BandedGridColumn In gv.Columns
                        Dim columnName As String = column.FieldName

                        If Not columnNames.Contains(columnName) AndAlso
                             Not (columnName.StartsWith("DB_PROC_USE") Or columnName.StartsWith("DB_SESS_USE") Or columnName.StartsWith("CPU_USE_RATE") Or columnName.StartsWith("RAM_USE_RATE")) Then
                            column.Visible = False
                        Else
                            column.Visible = True
                        End If
                    Next
                Next

                Dim counts() As Integer = {3, 2, 0, 4, 2, 2, 4, 2, 2}
                RowCounts(GV1, GV2, GV3, counts)

            Case "HDD1", "HDD2", "HDD3"
                Dim iValue As Integer

                If S_SEARCH_HDD.SelectedValue = "HDD1" Then
                    iValue = 1
                ElseIf S_SEARCH_HDD.SelectedValue = "HDD2" Then
                    iValue = 2
                ElseIf S_SEARCH_HDD.SelectedValue = "HDD3" Then
                    iValue = 3
                End If

                For i As Integer = 1 To 6
                    HDDColumns(GV1, GV2, GV3, i, (i = iValue))
                Next

                Dim counts() As Integer = {3, 2, 1, 5, 3, 2, 5, 3, 2}
                RowCounts(GV1, GV2, GV3, counts)

            Case "HDD123"
                For i As Integer = 1 To 6
                    If i >= 1 AndAlso i <= 3 Then
                        HDDColumns(GV1, GV2, GV3, i, True)
                    Else
                        HDDColumns(GV1, GV2, GV3, i, False)
                    End If
                Next
                Dim counts() As Integer = {5, 2, 3, 7, 5, 2, 7, 5, 2}
                RowCounts(GV1, GV2, GV3, counts)

            Case "HDD1234"
                For i As Integer = 1 To 6
                    If i >= 1 AndAlso i <= 4 Then
                        HDDColumns(GV1, GV2, GV3, i, True)
                    Else
                        HDDColumns(GV1, GV2, GV3, i, False)
                    End If
                Next

                Dim counts() As Integer = {6, 2, 4, 8, 6, 2, 8, 6, 2}
                RowCounts(GV1, GV2, GV3, counts)

            Case "HDD12345"
                For i As Integer = 1 To 6
                    If i >= 1 AndAlso i <= 5 Then
                        HDDColumns(GV1, GV2, GV3, i, True)
                    Else
                        HDDColumns(GV1, GV2, GV3, i, False)
                    End If
                Next

                Dim counts() As Integer = {7, 2, 5, 9, 7, 2, 9, 7, 2}
                RowCounts(GV1, GV2, GV3, counts)

        End Select
    End Sub
#End Region
End Class
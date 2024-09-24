Imports YJIT.SC.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class EvbSendStatis
    Dim WG1_PopUp As New PopupBase
    Dim WG2_PopUp As New PopupBase
#Region "=================GetConvertToDataset Function==========="
    Private Function GetConvertToDataSet(ByVal Type As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim drMain As DataRow = ds.Tables("MAIN").Rows(0)

        Select Case Type.ToUpper
            Case "SEARCH"
                If MainTab.SelectedTabPage.Name = TabPage_DOC.Name Then
                    YJSql.SqlBox("WG1", "EvbSendStatis@SearchDOC", True)
                    YJSql.Params("SEARCH_KEY", drMain("S_SEARCH_KEY").ToString)
                    YJSql.Params("YEAR_MONTH_FM", drMain("S_YEAR_MONTH_FM").ToString)
                    YJSql.Params("YEAR_MONTH_TO", drMain("S_YEAR_MONTH_TO").ToString)
                ElseIf MainTab.SelectedTabPage.Name = TabPage_YMD.Name Then
                    YJSql.SqlBox("WG2", "EvbSendStatis@SearchYMD", True)
                    YJSql.Params("SEARCH_KEY", drMain("S_SEARCH_KEY").ToString)
                    YJSql.Params("YEAR_MONTH", drMain("YEAR_MONTH").ToString)
                End If
        End Select
        Return YJSql.DataSet
    End Function
#End Region
#Region "=================Client Function==========="
    Private Sub InitGrid()

    End Sub
    Private Sub PopupInit()
        'WG1 우클릭
        WG1_PopUp.ItemAdd(Action.Excel, "WG1_ExcelExport", "&Export Excel", True)
        WG1_PopUp.PopUpInit(Me, WG1)
        'WG2 우클릭
        WG2_PopUp.ItemAdd(Action.Excel, "WG2_ExcelExport", "&Export Excel", True)
        WG2_PopUp.PopUpInit(Me, WG2)
    End Sub
    '''Private Sub PopUpOnAfterClick(ByVal dr As DataRow)
    '''    Dim key As String = dr("key").ToString
    '''    Select Case dr("Sender").ToString
    '''        Case "WG1"
    '''        Case "WG2"
    '''    End Select
    '''End Sub
#End Region
#Region "=================Data logic actions============"
    Public Sub SearchData()
        If SearchValidate() = False Then Exit Sub

        Dim ds As DataSet = GetConvertToDataSet("SEARCH")

        ds = MethodCallEx(Me, "YJIT.Biz.EvbSendStatis", "Search", {ds})
        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case dr("TrxCode")
            Case "Y"
                Me.BindToDataset(ds, "Data")
                If MainTab.SelectedTabPage.Name = TabPage_DOC.Name Then
                    If GV1.RowCount = 0 Then
                        MsgBoxLocalized("Data not found!")
                    End If
                Else
                    If GV2.RowCount = 0 Then
                        MsgBoxLocalized("Data not found!")
                    End If
                End If
                Me.DataState = UI.DataStates.Retrieved
            Case "N"
                MsgBoxLocalized(dr("TrxMsg"))
                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(dr("TrxMsg"))
        End Select
    End Sub
    'SearchValidate
    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing

        Try
            If MainTab.SelectedTabPage.Name = TabPage_DOC.Name Then
                If String.IsNullOrEmpty(S_YEAR_MONTH_FM.Text.ToString) OrElse String.IsNullOrEmpty(S_YEAR_MONTH_TO.Text.ToString) Then
                    ErrMsg = "조회일자을 입력하세요." & vbNewLine
                End If
            Else
                If String.IsNullOrEmpty(YEAR_MONTH.Text.ToString) Then
                    ErrMsg = "조회일자를 입력하세요." & vbNewLine
                End If
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
    Private Sub InitData()
        S_YEAR_MONTH_FM.Text = Now.ToString("yyyyMM") & "01"
        S_YEAR_MONTH_TO.Text = Now.ToString("yyyyMMdd")
        YEAR_MONTH.Text = Now.ToString("yyyyMM")
    End Sub
#End Region
#Region "=================Control Events==========="
    Private Sub EvbSendStatis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call InitData()
        Call DrawRowIndicator(GV1)
        Call DrawRowIndicator(GV2)
    End Sub
    Private Sub EvbSendStatis_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call PopupInit()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub
    Private Sub MainTab_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles MainTab.SelectedPageChanged
        If MainTab.SelectedTabPage.Name = TabPage_DOC.Name Then
            S_YEAR_MONTH_FM.Visible = True
            S_YEAR_MONTH_TO.Visible = True
            lbl_S_YEAR_MONTH.Visible = True
            YEAR_MONTH.Visible = False
        Else
            S_YEAR_MONTH_FM.Visible = False
            S_YEAR_MONTH_TO.Visible = False
            lbl_S_YEAR_MONTH.Visible = False
            YEAR_MONTH.Visible = True
        End If
    End Sub

#End Region
End Class
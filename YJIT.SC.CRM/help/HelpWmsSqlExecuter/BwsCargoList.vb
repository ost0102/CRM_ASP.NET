Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing
Imports YJIT.SC.UI
Imports System.Text
Imports System
Imports System.Collections.Generic
Imports System.Text.RegularExpressions
Imports System.IO
'****************************************************************************
' 작 성 자  : 정윤기
' 작 성 일  : 2021-9-29
' 파일설명  : WMS 보세창고 화물 조회 화면
' 파 일 명  : BwsCargoList.vb
' 사 용 SP  :  
' 수 정 일  | 수 정 차 수(U:Update, I:Insert)  |  수 정 자
'
'****************************************************************************
'****************************************************************************
' 수 정 차 수 :
' 수 정 내 용 :
'****************************************************************************
Public Class BwsCargoList
    Dim selected_DelNo As String = ""
    Public return_Mrn As String = ""
#Region "=================Data logic actions==========="

    Private Function GetConvertToDataSet(ByVal SearchType As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset

        Try
            Select Case SearchType.ToString.ToUpper

                Case "Rcp".ToString.ToUpper
                    Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
                    YJSql.SqlBox("WG_CARGO", "BwsCargoList@SearchRcp", True)
                    YJSql.Params("WHCD", WHCD.Text.ToString.Trim, False)
                    YJSql.Params("FROM_DT", FROM_DT.Text.ToString.Trim, False)
                    YJSql.Params("TO_DT", TO_DT.Text.ToString.Trim, False)
                    Dim refNo As String = REF_NO.Text.Trim
                    Dim refType As String = REF_TYPE.SelectedValue
                    YJSql.Params("REFNO", refNo, False)
                    If refNo <> "" Then
                        If refType = "H" Then
                            YJSql.Blocks("HBLNO", True)
                        ElseIf refType = "R" Then
                            YJSql.Blocks("GRNO", True)
                        ElseIf refType = "S" Then
                            YJSql.Blocks("SEND_NO", True)
                        ElseIf refType = "C" Then
                            YJSql.Blocks("CNTRNO", True)
                        ElseIf refType = "M" Then
                            YJSql.Blocks("MRNNO", True)
                        ElseIf refType = "B" Then
                            YJSql.Blocks("BUYER", True)
                        End If
                    End If
                    Dim dateType As String = DATE_TYPE.SelectedValue
                    If dateType = "O" Then
                        YJSql.Blocks("ORD_YMD", True)
                    ElseIf dateType = "R" Then
                        YJSql.Blocks("GR_YMD", True)
                    End If

                    Dim dtDomain As DataTable = New DataTable()
                    dtDomain.Columns.AddRange({New DataColumn("CUST_NM"), New DataColumn("DB_IP"), New DataColumn("DB_PORT"), New DataColumn("DB_SID"),
                                              New DataColumn("USR_ID"), New DataColumn("USR_PWD"), New DataColumn("DOMAIN"), New DataColumn("CTRY_CD")})
                    dtDomain.Rows.Add(New Object() {CUST_NM.Text, DB_IP.Text, DB_PORT.Text, DB_SID.Text, USR_ID.Text, USR_PWD.Text, DOMAIN.Text, CTRY_CD.Text})

                    Dim dt As DataTable = dtDomain.Copy
                    dt.TableName = "ConnectInfo"
                    YJSql.DataSet.Tables.Add(dt)
                Case "Isu".ToString.ToUpper
                    Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
                    YJSql.SqlBox("WG_ISU", "BwsCargoList@SearchIsu", True)
                    YJSql.Params("WHCD", WHCD.Text.ToString.Trim, False)
                    YJSql.Params("DELNO", selected_DelNo, False)

                    Dim dtDomain As DataTable = New DataTable()
                    dtDomain.Columns.AddRange({New DataColumn("CUST_NM"), New DataColumn("DB_IP"), New DataColumn("DB_PORT"), New DataColumn("DB_SID"),
                                              New DataColumn("USR_ID"), New DataColumn("USR_PWD"), New DataColumn("DOMAIN"), New DataColumn("CTRY_CD")})
                    dtDomain.Rows.Add(New Object() {CUST_NM.Text, DB_IP.Text, DB_PORT.Text, DB_SID.Text, USR_ID.Text, USR_PWD.Text, DOMAIN.Text, CTRY_CD.Text})

                    Dim dt As DataTable = dtDomain.Copy
                    dt.TableName = "ConnectInfo"
                    YJSql.DataSet.Tables.Add(dt)
                Case "Do".ToString.ToUpper
                    Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
                    YJSql.SqlBox("WG_DO", "BwsCargoList@SearchDo", True)
                    YJSql.Params("WHCD", WHCD.Text.ToString.Trim, False)
                    YJSql.Params("DELNO", selected_DelNo, False)

                    Dim dtDomain As DataTable = New DataTable()
                    dtDomain.Columns.AddRange({New DataColumn("CUST_NM"), New DataColumn("DB_IP"), New DataColumn("DB_PORT"), New DataColumn("DB_SID"),
                                              New DataColumn("USR_ID"), New DataColumn("USR_PWD"), New DataColumn("DOMAIN"), New DataColumn("CTRY_CD")})
                    dtDomain.Rows.Add(New Object() {CUST_NM.Text, DB_IP.Text, DB_PORT.Text, DB_SID.Text, USR_ID.Text, USR_PWD.Text, DOMAIN.Text, CTRY_CD.Text})

                    Dim dt As DataTable = dtDomain.Copy
                    dt.TableName = "ConnectInfo"
                    YJSql.DataSet.Tables.Add(dt)
                Case "Cntr".ToString.ToUpper
                    Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
                    YJSql.SqlBox("WG_CNTR", "BwsCargoList@SearchCntr", True)
                    YJSql.Params("WHCD", WHCD.Text.ToString.Trim, False)
                    YJSql.Params("DELNO", selected_DelNo, False)

                    Dim dtDomain As DataTable = New DataTable()
                    dtDomain.Columns.AddRange({New DataColumn("CUST_NM"), New DataColumn("DB_IP"), New DataColumn("DB_PORT"), New DataColumn("DB_SID"),
                                              New DataColumn("USR_ID"), New DataColumn("USR_PWD"), New DataColumn("DOMAIN"), New DataColumn("CTRY_CD")})
                    dtDomain.Rows.Add(New Object() {CUST_NM.Text, DB_IP.Text, DB_PORT.Text, DB_SID.Text, USR_ID.Text, USR_PWD.Text, DOMAIN.Text, CTRY_CD.Text})

                    Dim dt As DataTable = dtDomain.Copy
                    dt.TableName = "ConnectInfo"
                    YJSql.DataSet.Tables.Add(dt)
                Case Else
                    Throw New Exception("등록된 조회 조건이 없습니다. (GetConvertToDataSet)")
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function
    Private Sub SearchRcp()
        If WHCD.Text = "" Then Exit Sub
        If Replace(Trim(FROM_DT.Text), "-", "") = "" Then
            MsgBoxLocalized("날짜는 필수 입력입니다.")
            FROM_DT.Focus()
            Exit Sub
        End If
        If Replace(Trim(TO_DT.Text), "-", "") = "" Then
            MsgBoxLocalized("날짜는 필수 입력입니다.")
            TO_DT.Focus()
            Exit Sub
        End If

        Try
            Dim dsRet As DataSet = GetConvertToDataSet("Rcp")

            dsRet = MethodCallEx(Me, "YJIT.Sys.RuntimeInfo", "SearchReconnect", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Me.ClearView(UI.AppliedRangeTypes.Only, {WG_CARGO})
                    Me.BindToDataset(dsRet, "Data")
                    SearchIsu()
                Case "N"
                    Me.ClearView(UI.AppliedRangeTypes.Only, {WG_CARGO})
                    MsgBoxLocalized(drPairs("TrxMsg"))
                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SearchIsu()
        If WHCD.Text = "" Then Exit Sub
        If selected_DelNo = "" Then Exit Sub
        Try
            Dim dsRet As DataSet = GetConvertToDataSet("Isu")

            dsRet = MethodCallEx(Me, "YJIT.Sys.RuntimeInfo", "SearchReconnect", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Me.ClearView(UI.AppliedRangeTypes.Only, {WG_ISU})
                    Me.BindToDataset(dsRet, "Data")
                Case "N"
                    Me.ClearView(UI.AppliedRangeTypes.Only, {WG_ISU})
                    MsgBoxLocalized(drPairs("TrxMsg"))
                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SearchCntr()
        If WHCD.Text = "" Then Exit Sub
        If selected_DelNo = "" Then Exit Sub
        Try
            Dim dsRet As DataSet = GetConvertToDataSet("Cntr")

            dsRet = MethodCallEx(Me, "YJIT.Sys.RuntimeInfo", "SearchReconnect", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Me.ClearView(UI.AppliedRangeTypes.Only, {WG_CNTR})
                    Me.BindToDataset(dsRet, "Data")
                Case "N"
                    Me.ClearView(UI.AppliedRangeTypes.Only, {WG_CNTR})
                    MsgBoxLocalized(drPairs("TrxMsg"))
                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SearchDo()
        If WHCD.Text = "" Then Exit Sub
        If selected_DelNo = "" Then Exit Sub
        Try
            Dim dsRet As DataSet = GetConvertToDataSet("Do")

            dsRet = MethodCallEx(Me, "YJIT.Sys.RuntimeInfo", "SearchReconnect", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Me.ClearView(UI.AppliedRangeTypes.Only, {WG_DO})
                    Me.BindToDataset(dsRet, "Data")
                Case "N"
                    Me.ClearView(UI.AppliedRangeTypes.Only, {WG_DO})
                    MsgBoxLocalized(drPairs("TrxMsg"))
                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "=================Control Events==========="
    Private Sub BwsCargoList_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load
        FROM_DT.Text = Now.AddMonths(-1).ToString("yyyyMMdd")
        TO_DT.Text = Now.ToString("yyyyMMdd")
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Call SearchRcp()
    End Sub
    Private Sub GV_CARGO_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV_CARGO.FocusedRowChanged
        If GV_CARGO.RowCount = 0 Then Exit Sub
        If GV_CARGO.FocusedRowHandle < 0 Then Exit Sub

        selected_DelNo = GV_CARGO.GetFocusedRowCellValue("DELNO").ToString

        SearchIsu()
        SearchCntr()
        SearchDo()
    End Sub
    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs)
        ClearView(AppliedRangeTypes.All)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If CUST_CD.Text = "" Then Exit Sub

        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing
        frmMain = IMainForm
        fTarget = frmMain.NavigateTo("CrmCustomerMgt")
        If Not IsNothing(fTarget) Then
            Dim SearchType As String = fTarget.SEARCH_TYPE.SelectedValue.ToString
            fTarget.SEARCH_TYPE.SelectedValue = "CUST_CD"
            fTarget.SEARCH_KEY.Text = CUST_CD.Text
            fTarget.SearchData()
            fTarget.SEARCH_TYPE.SelectedValue = SearchType
        End If

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Me.ClearView(AppliedRangeTypes.Only, {DATE_TYPE, FROM_DT, TO_DT, REF_NO, REF_TYPE, WG_CARGO, WG_ISU, WG_DO, WG_CNTR})
        REF_TYPE.SelectedValue = REF_TYPE.DefVal
        DATE_TYPE.SelectedValue = DATE_TYPE.DefVal
    End Sub

    Private Sub WG_CARGO_DoubleClick(sender As Object, e As EventArgs) Handles WG_CARGO.DoubleClick
        If GV_CARGO.RowCount = 0 Then Exit Sub
        return_Mrn = GV_CARGO.GetRowCellValue(GV_CARGO.FocusedRowHandle, "MRN") & GV_CARGO.GetRowCellValue(GV_CARGO.FocusedRowHandle, "MSN") & GV_CARGO.GetRowCellValue(GV_CARGO.FocusedRowHandle, "HSN")
        Me.Close()
    End Sub

#End Region

#Region "=================Helper Methods==========="

#End Region

End Class
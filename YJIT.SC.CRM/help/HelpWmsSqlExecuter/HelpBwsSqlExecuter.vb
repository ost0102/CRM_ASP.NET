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
' 작 성 일  : 2020-12-29
' 파일설명  : WMS 보세창고 유지보수 화면
' 파 일 명  : HelpBwsSqlExecuter.vb
' 사 용 SP  :  
' 수 정 일  | 수 정 차 수(U:Update, I:Insert)  |  수 정 자
'
'****************************************************************************
'****************************************************************************
' 수 정 차 수 :
' 수 정 내 용 :
'****************************************************************************
Public Class HelpBwsSqlExecuter

#Region "=================Data logic actions==========="

    Private Function GetConvertToDataSet(ByVal SearchType As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset

        Try
            Select Case SearchType.ToString.ToUpper
                Case "ExecuteReconnect".ToString.ToUpper
                    Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
                    YJSql.SqlBox("WG_EXECUTE", "SysRuntimeInfo@Search", True)
                    YJSql.Params("SQLEXECUTE", S_EXECUTE.Text.ToString.Trim, False)

                    Dim dtDomain As DataTable = New DataTable()
                    dtDomain.Columns.AddRange({New DataColumn("CUST_NM"), New DataColumn("DB_IP"), New DataColumn("DB_PORT"), New DataColumn("DB_SID"),
                                              New DataColumn("USR_ID"), New DataColumn("USR_PWD"), New DataColumn("DOMAIN"), New DataColumn("CTRY_CD")})
                    dtDomain.Rows.Add(New Object() {CUST_NM.Text, DB_IP.Text, DB_PORT.Text, DB_SID.Text, USR_ID.Text, USR_PWD.Text, DOMAIN.Text, CTRY_CD.TEXT})

                    Dim dt As DataTable = dtDomain.Copy
                    dt.TableName = "ConnectInfo"
                    YJSql.DataSet.Tables.Add(dt)

                Case "Execute".ToString.ToUpper
                    Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
                    YJSql.SqlBox("WG_EXECUTE", "SysRuntimeInfo@Search", True)
                    YJSql.Params("SQLEXECUTE", S_EXECUTE.Text.ToString.Trim, False)
                Case "WH".ToString.ToUpper
                    Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
                    YJSql.SqlBox("WG_WH", "HelpBwsSqlExecuter@SearchWH", True)

                    Dim dtDomain As DataTable = New DataTable()
                    dtDomain.Columns.AddRange({New DataColumn("CUST_NM"), New DataColumn("DB_IP"), New DataColumn("DB_PORT"), New DataColumn("DB_SID"),
                                              New DataColumn("USR_ID"), New DataColumn("USR_PWD"), New DataColumn("DOMAIN"), New DataColumn("CTRY_CD")})
                    dtDomain.Rows.Add(New Object() {CUST_NM.Text, DB_IP.Text, DB_PORT.Text, DB_SID.Text, USR_ID.Text, USR_PWD.Text, DOMAIN.Text, CTRY_CD.Text})

                    Dim dt As DataTable = dtDomain.Copy
                    dt.TableName = "ConnectInfo"
                    YJSql.DataSet.Tables.Add(dt)
                Case "Rcp".ToString.ToUpper
                    Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
                    YJSql.SqlBox("WG_RCP", "HelpBwsSqlExecuter@SearchRcp", True)
                    YJSql.Params("WHCD", WHCD.Text.ToString.Trim, False)
                    YJSql.Params("HBLNO", HBLNO.Text.ToString.Trim, False)
                    YJSql.Params("MRN", Replace(MRN.Text.ToString.Trim, "-", ""), False)

                    Dim dtDomain As DataTable = New DataTable()
                    dtDomain.Columns.AddRange({New DataColumn("CUST_NM"), New DataColumn("DB_IP"), New DataColumn("DB_PORT"), New DataColumn("DB_SID"),
                                              New DataColumn("USR_ID"), New DataColumn("USR_PWD"), New DataColumn("DOMAIN"), New DataColumn("CTRY_CD")})
                    dtDomain.Rows.Add(New Object() {CUST_NM.Text, DB_IP.Text, DB_PORT.Text, DB_SID.Text, USR_ID.Text, USR_PWD.Text, DOMAIN.Text, CTRY_CD.Text})

                    Dim dt As DataTable = dtDomain.Copy
                    dt.TableName = "ConnectInfo"
                    YJSql.DataSet.Tables.Add(dt)
                Case "Isu".ToString.ToUpper
                    Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
                    YJSql.SqlBox("WG_ISU", "HelpBwsSqlExecuter@SearchIsu", True)
                    YJSql.Params("WHCD", WHCD.Text.ToString.Trim, False)
                    YJSql.Params("GRNO", GRNO.Text.ToString.Trim, False)

                    Dim dtDomain As DataTable = New DataTable()
                    dtDomain.Columns.AddRange({New DataColumn("CUST_NM"), New DataColumn("DB_IP"), New DataColumn("DB_PORT"), New DataColumn("DB_SID"),
                                              New DataColumn("USR_ID"), New DataColumn("USR_PWD"), New DataColumn("DOMAIN"), New DataColumn("CTRY_CD")})
                    dtDomain.Rows.Add(New Object() {CUST_NM.Text, DB_IP.Text, DB_PORT.Text, DB_SID.Text, USR_ID.Text, USR_PWD.Text, DOMAIN.Text, CTRY_CD.Text})

                    Dim dt As DataTable = dtDomain.Copy
                    dt.TableName = "ConnectInfo"
                    YJSql.DataSet.Tables.Add(dt)
                Case "Sql".ToString.ToUpper
                    Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
                    YJSql.SqlBox("WG_SQL", "HelpBwsSqlExecuter@SearchSql", True)
                Case "Domain".ToString.ToUpper
                    Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
                    YJSql.SqlBox("MAIN", "HelpBwsSqlExecuter@SearchDomain", True)
                    YJSql.Params("CUST_CD", CUST_CD.Text.ToString.Trim, False)

                Case Else
                    Throw New Exception("등록된 조회 조건이 없습니다. (GetConvertToDataSet)")
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function

    Private Sub SearchSqlData()
        Dim dsRet As DataSet = GetConvertToDataSet("Sql")

        dsRet = MethodCallEx(Me, "YJIT.Sys.RuntimeInfo", "Search", {dsRet})
        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case drPairs("TrxCode")
            Case "Y"
                Me.BindToDataset(dsRet, "Data")
            Case "N"
                MsgBoxLocalized(drPairs("TrxMsg"))
            Case Else
                MsgBoxLocalized(drPairs("TrxMsg"))
        End Select
    End Sub
    Private Sub SearchDomain()
        Dim dsRet As DataSet = GetConvertToDataSet("Domain")

        dsRet = MethodCallEx(Me, "YJIT.Sys.RuntimeInfo", "Search", {dsRet})
        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case drPairs("TrxCode")
            Case "Y"
                Me.ClearView(UI.AppliedRangeTypes.Only, {DOMAIN, DB_IP, USR_ID, USR_PWD, DB_PORT, DB_SID, CTRY_CD})
                Me.BindToDataset(dsRet, "Data")
            Case "N"
                Me.ClearView(UI.AppliedRangeTypes.Only, {DOMAIN, DB_IP, USR_ID, USR_PWD, DB_PORT, DB_SID, CTRY_CD})
                MsgBoxLocalized(drPairs("TrxMsg"))
            Case Else
                Me.ClearView(UI.AppliedRangeTypes.Only, {DOMAIN, DB_IP, USR_ID, USR_PWD, DB_PORT, DB_SID, CTRY_CD})
                MsgBoxLocalized(drPairs("TrxMsg"))
        End Select
    End Sub
    Private Function getParamList(ByVal sqlText As String) As ArrayList
        Dim arlReturn As ArrayList = New ArrayList

        Dim i As Integer = 0
        Dim sParam As String
        Dim nFlagIndex As Integer

        While i < sqlText.Length
            If sqlText(i) = "@" Then    'Start a new param
                sParam = ""
                nFlagIndex = i

                i += 1
                While i < sqlText.Length AndAlso (Char.IsLetterOrDigit(sqlText(i)) OrElse sqlText(i) = "_")
                    i += 1
                End While

                'Harvest a just-found param
                sParam = sqlText.Substring(nFlagIndex, i - nFlagIndex)
                'Put into the pocket if quality is good
                If sParam <> "@" And sParam <> "@_" Then
                    If Not arlReturn.Contains(sParam) Then
                        arlReturn.Add(sParam)
                    End If
                End If
            End If
            'Increase the counter
            i += 1
        End While
        Return arlReturn
    End Function

    Private Function getBlockList(ByVal sqlText As String) As ArrayList
        Dim arlReturn As ArrayList = New ArrayList
        Dim i As Integer = 0
        Dim sBlock As String
        Dim nFlagIndex As Integer

        While i < sqlText.Length
            If sqlText(i) = "[" Then    'Start a new block
                sBlock = ""
                nFlagIndex = i
                i += 1
                While i < sqlText.Length AndAlso (Char.IsLetterOrDigit(sqlText(i)) OrElse sqlText(i) = "_")
                    i += 1
                End While

                'Harvest a just-found param
                sBlock = sqlText.Substring(nFlagIndex, i + 1 - nFlagIndex)
                'Put into the pocket if quality is good
                If sBlock.EndsWith("]") Then
                    arlReturn.Add(sBlock)
                End If
            End If
            'Increase the counter
            i += 1
        End While
        Return arlReturn
    End Function

    Private Sub createSqlSettingControls(ByVal sqlText As String)
        '1. Preparation=====================
        Dim arlParams As ArrayList = getParamList(sqlText)
        Dim arlBlocks As ArrayList = getBlockList(sqlText)

        Dim palSettings As DevExpress.XtraEditors.PanelControl = splSqlSettings

        Dim nParamX As Integer = 5     'Left position of label (for param)
        Dim nParamY As Integer = 5

        Dim nCheckBoxX As Integer = 10  'Left position of Checkbox (for block)
        Dim nBlockY As Integer
        '2. Clear the previous first=====================
        palSettings.Controls.Clear()
        Dim lblNew As Label
        Dim txtNew As TextBox
        Dim chkNew As CheckBox

        If arlParams.Count > 0 Then
            '3. Create the Param settings header=====================
            lblNew = New Label
            lblNew.ForeColor = Color.DarkRed
            lblNew.Text = "*Parameter-Settings-------------------------------------------------------------------------------------------------------"
            'lblNew.Anchor = AnchorStyles.Right
            lblNew.Width = palSettings.Width - 20       '20 is right padding
            lblNew.Left = 0
            lblNew.Top = nParamY
            palSettings.Controls.Add(lblNew)



            '4. Create the param settings' control list=====================
            nParamY = nParamY + lblNew.Height + 5
            For i As Integer = 0 To arlParams.Count - 1
                'Create & add label
                lblNew = New Label
                lblNew.Text = arlParams(i)
                lblNew.TextAlign = ContentAlignment.MiddleRight
                lblNew.Left = nParamX
                lblNew.Top = nParamY
                palSettings.Controls.Add(lblNew)

                'Create & add textbox
                txtNew = New TextBox
                txtNew.Width = 100
                AddHandler txtNew.GotFocus, AddressOf txtParam_GotFocus
                AddHandler txtNew.MouseClick, AddressOf txtParam_GotFocus
                Select Case arlParams(i).Replace("@", "")
                    Case "HBLNO"
                        If Trim(HBLNO.Text) <> "" Then
                            txtNew.Text = Trim(HBLNO.Text)
                        Else
                            txtNew.Text = arlParams(i).Replace("@", "")
                        End If
                    Case "MRN"
                        If Trim(MRN.Text) <> "" Then
                            txtNew.Text = Replace(Trim(MRN.Text), "-", "")
                        Else
                            txtNew.Text = arlParams(i).Replace("@", "")
                        End If
                    Case "GRNO"
                        If Trim(GRNO.Text) <> "" Then
                            txtNew.Text = Trim(GRNO.Text)
                        Else
                            txtNew.Text = arlParams(i).Replace("@", "")
                        End If
                    Case "GINO"
                        If Trim(GINO.Text) <> "" Then
                            txtNew.Text = Trim(GINO.Text)
                        Else
                            txtNew.Text = arlParams(i).Replace("@", "")
                        End If
                    Case "WHCD"
                        If Trim(WHCD.Text) <> "" Then
                            txtNew.Text = Trim(WHCD.Text)
                        Else
                            txtNew.Text = arlParams(i).Replace("@", "")
                        End If
                    Case "RCP_SEND_NO"
                        If Trim(RCP_SEND_NO.Text) <> "" Then
                            txtNew.Text = Trim(RCP_SEND_NO.Text)
                        Else
                            txtNew.Text = arlParams(i).Replace("@", "")
                        End If
                    Case "ISU_SEND_NO"
                        If Trim(ISU_SEND_NO.Text) <> "" Then
                            txtNew.Text = Trim(ISU_SEND_NO.Text)
                        Else
                            txtNew.Text = arlParams(i).Replace("@", "")
                        End If
                    Case "DELNO"
                        If Trim(DELNO.Text) <> "" Then
                            txtNew.Text = Trim(DELNO.Text)
                        Else
                            txtNew.Text = arlParams(i).Replace("@", "")
                        End If
                    Case "RPNO"
                        If Trim(RPNO.Text) <> "" Then
                            txtNew.Text = Trim(RPNO.Text)
                        Else
                            txtNew.Text = arlParams(i).Replace("@", "")
                        End If
                    Case "RCP_SEND_NO"
                        If GV_RCP.RowCount > 0 Then
                            If Trim(GV_RCP.GetRowCellValue(GV_RCP.FocusedRowHandle, "RCP_SEND_NO")) <> "" Then
                                txtNew.Text = Trim(Trim(GV_RCP.GetRowCellValue(GV_RCP.FocusedRowHandle, "RCP_SEND_NO")))
                            Else
                                txtNew.Text = arlParams(i).Replace("@", "")
                            End If
                        End If
                    Case "ISU_SEND_NO"
                        If GV_ISU.RowCount > 0 Then
                            If Trim(GV_ISU.GetRowCellValue(GV_ISU.FocusedRowHandle, "ISU_SEND_NO")) <> "" Then
                                txtNew.Text = Trim(Trim(GV_ISU.GetRowCellValue(GV_ISU.FocusedRowHandle, "ISU_SEND_NO")))
                            Else
                                txtNew.Text = arlParams(i).Replace("@", "")
                            End If
                        End If
                    Case Else
                        txtNew.Text = arlParams(i).Replace("@", "")
                End Select

                txtNew.Name = arlParams(i).ToString.Replace("@", "")
                txtNew.Left = (lblNew.Left + lblNew.Width + 5)     '10 is column distance
                txtNew.Top = nParamY
                palSettings.Controls.Add(txtNew)
                nParamY += txtNew.Height + 5        '5 is row distance
            Next
        End If

        '5. Create the Block settings header=====================
        nParamY += 5
        If arlBlocks.Count > 0 Then
            lblNew = New Label
            lblNew.ForeColor = Color.DarkRed
            lblNew.Text = "*Block-settings-------------------------------------------------------------------------------------------------------"
            lblNew.Width = palSettings.Width - 20       '20 is right padding
            'lblNew.Anchor = AnchorStyles.Right
            lblNew.Left = 0
            lblNew.Top = nParamY
            palSettings.Controls.Add(lblNew)

            nBlockY = nParamY + lblNew.Height + 5

            '6. Create the Block settings header=====================
            For i As Integer = 0 To arlBlocks.Count - 1
                chkNew = New CheckBox
                chkNew.Name = arlBlocks(i).ToString.Replace("[", "").Replace("]", "")
                chkNew.Text = chkNew.Name
                chkNew.Left = nCheckBoxX
                chkNew.Top = nBlockY
                palSettings.Controls.Add(chkNew)

                nBlockY += chkNew.Height + 5            '5 is row distance
            Next
        End If
    End Sub

    Private Sub txtParam_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim txtParam As TextBox = sender
            txtParam.SelectAll()
        Catch ex As Exception
            'Error freee
        End Try
    End Sub
    Private Sub SearchWh()
        If Trim(CUST_CD.Text) = "" Then
            MsgBoxLocalized("접속할 거래처가 입력되지 않았습니다.")
            CUST_CD.Focus()
            Exit Sub
        End If
        If Trim(DOMAIN.Text) = "" Then
            MsgBoxLocalized("접속할 거래처의 도메인이 입력되지 않았습니다.")
            DOMAIN.Focus()
            Exit Sub
        End If

        Try
            Dim dsRet As DataSet = GetConvertToDataSet("WH")

            dsRet = MethodCallEx(Me, "YJIT.Sys.RuntimeInfo", "SearchReconnect", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Me.ClearView(UI.AppliedRangeTypes.Only, {WG_WH})
                    Me.BindToDataset(dsRet, "Data")
                Case "N"
                    Me.ClearView(UI.AppliedRangeTypes.Only, {WG_WH})
                    MsgBoxLocalized(drPairs("TrxMsg"))
                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SearchRcp()
        If WHCD.Text = "" Then Exit Sub
        If Trim(HBLNO.Text) = "" And Replace(Trim(MRN.Text), "-", "") = "" Then
            MsgBoxLocalized("HB/L No. 또는 MRN No.를 입력하세요.")
            HBLNO.Focus()
            Exit Sub
        End If

        Try
            Dim dsRet As DataSet = GetConvertToDataSet("Rcp")

            dsRet = MethodCallEx(Me, "YJIT.Sys.RuntimeInfo", "SearchReconnect", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Me.ClearView(UI.AppliedRangeTypes.Only, {WG_RCP, WG_ISU, GINO, RPNO, ISU_SEND_NO, DELNO, GRNO, RCP_SEND_NO})
                    Me.BindToDataset(dsRet, "Data")
                    SearchIsu()
                Case "N"
                    Me.ClearView(UI.AppliedRangeTypes.Only, {WG_RCP})
                    MsgBoxLocalized(drPairs("TrxMsg"))
                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SearchIsu()
        If WHCD.Text = "" Then Exit Sub
        If GRNO.Text = "" Then Exit Sub
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

#End Region

#Region "=================Control Events==========="
    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Call SearchRcp()
    End Sub

    Private Sub GV_SQL_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV_SQL.FocusedRowChanged
        If GV_SQL.RowCount = 0 Then Exit Sub
        If GV_SQL.FocusedRowHandle < 0 Then Exit Sub

        S_EXECUTE.Text = GV_SQL.GetFocusedRowCellValue("SQL_STR").ToString

        Call createSqlSettingControls(S_EXECUTE.Text)
    End Sub
    Private Sub GV_WH_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV_WH.FocusedRowChanged
        If GV_WH.RowCount = 0 Then Exit Sub
        If GV_WH.FocusedRowHandle < 0 Then Exit Sub

        WHCD.Text = GV_WH.GetFocusedRowCellValue("WHCD").ToString
        WHNM.Text = GV_WH.GetFocusedRowCellValue("WHNM").ToString
        SearchRcp()
    End Sub
    Private Sub GV_RCP_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV_RCP.FocusedRowChanged
        If GV_RCP.RowCount = 0 Then Exit Sub
        If GV_RCP.FocusedRowHandle < 0 Then Exit Sub

        GRNO.Text = GV_RCP.GetFocusedRowCellValue("GRNO").ToString
        DELNO.Text = GV_RCP.GetFocusedRowCellValue("DELNO").ToString
        RCP_SEND_NO.Text = GV_RCP.GetFocusedRowCellValue("RCP_SEND_NO").ToString
        HBLNO.Text = GV_RCP.GetFocusedRowCellValue("HBLNO").ToString
        MRN.Text = GV_RCP.GetFocusedRowCellValue("MRN").ToString
        SearchIsu()
    End Sub
    Private Sub GV_ISU_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV_ISU.FocusedRowChanged
        If GV_ISU.RowCount = 0 Then Exit Sub
        If GV_ISU.FocusedRowHandle < 0 Then Exit Sub

        GINO.Text = GV_ISU.GetFocusedRowCellValue("GINO").ToString
        RPNO.Text = GV_ISU.GetFocusedRowCellValue("RPNO").ToString
        ISU_SEND_NO.Text = GV_ISU.GetFocusedRowCellValue("ISU_SEND_NO").ToString
    End Sub

    Private Sub btnExecuteReconnect_Click(sender As System.Object, e As System.EventArgs) Handles btnExecuteReconnect.Click

        Dim dicParamVals As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
        Dim dicBlockVals As Dictionary(Of String, Boolean) = New Dictionary(Of String, Boolean)


        'Collect the parameters and blocks' settings
        For Each ctrl In splSqlSettings.Controls
            If TypeOf ctrl Is Windows.Forms.TextBox Then
                dicParamVals(ctrl.Name) = ctrl.Text
            ElseIf TypeOf ctrl Is CheckBox Then
                dicBlockVals(ctrl.Name) = ctrl.Checked
            Else
                Continue For
            End If
        Next

        Dim finalSql As String = S_EXECUTE.Text

        'Applying the param settings
        For Each key As String In dicParamVals.Keys
            finalSql = finalSql.Replace("@" & key, dicParamVals(key))
        Next

        'Appplying the block settings
        For Each key As String In dicBlockVals.Keys
            If dicBlockVals(key) = True Then
                'Enabling block
                finalSql = finalSql.Replace("[" & key & "]", "").Replace("[/" & key & "]", "")
            Else
                'Disabling block
                Dim startBlock As Integer = finalSql.IndexOf("[" & key & "]")
                Dim endBlock As Integer = finalSql.IndexOf("[/" & key & "]") + ("[/" & key & "]").Length - 1
                finalSql = finalSql.Remove(startBlock, endBlock - startBlock + 1)
            End If
        Next

        S_EXECUTE.Text = finalSql

        Dim dsRet As DataSet = GetConvertToDataSet("ExecuteReconnect")

        dsRet = MethodCallEx(Me, "YJIT.Sys.RuntimeInfo", "SearchReconnect", {dsRet})
        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case drPairs("TrxCode")
            Case "Y"
                Me.ClearView(UI.AppliedRangeTypes.Only, {WG_EXECUTE})
                GV_EXECUTE.Columns.Clear()
                Me.BindToDataset(dsRet, "Data")
            Case "N"
                Me.ClearView(UI.AppliedRangeTypes.Only, {WG_EXECUTE})
                GV_EXECUTE.Columns.Clear()
                MsgBoxLocalized(drPairs("TrxMsg"))
            Case Else
                MsgBoxLocalized(drPairs("TrxMsg"))
        End Select

    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
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

    Private Sub btnSql_Click_1(sender As Object, e As EventArgs) Handles btnSql.Click
        Call SearchSqlData()
    End Sub

    Private Sub CUST_CD_Leave(sender As Object, e As EventArgs) Handles CUST_CD.Leave
        If Trim(CUST_CD.Text) <> "" Then
            Call SearchDomain()
            Call SearchWh()
        End If
    End Sub

    Private Sub btnUpdateRcp_Click(sender As Object, e As EventArgs) Handles btnUpdateRcp.Click
        Dim P_whCd As String = ""
        Dim P_grNo As String = ""
        If Trim(WHCD.Text) = "" Then
            MsgBoxLocalized("선택된 창고가 없습니다.")
            WHCD.Focus()
            Exit Sub
        Else
            P_whCd = WHCD.Text
        End If
        If Trim(GRNO.Text) = "" Then
            MsgBoxLocalized("선택된 반입정보가 없습니다.")
            GRNO.Focus()
            Exit Sub
        Else
            P_grNo = GRNO.Text
        End If
        splSqlSettings.Controls.Clear()
        ClearView(AppliedRangeTypes.Only, {S_EXECUTE})
        S_EXECUTE.Text &= " Update MTGR_MST " & vbCrLf
        S_EXECUTE.Text &= " Set  " & vbCrLf
        S_EXECUTE.Text &= " EDI_REMARK ='접수통보' " & vbCrLf
        S_EXECUTE.Text &= ",EDI_STATUS = 'Y'	" & vbCrLf
        S_EXECUTE.Text &= ",EDI_SEND_NO = (CASE WHEN (SELECT SEND_NO  " & vbCrLf
        S_EXECUTE.Text &= "                             FROM MTGR_MST  " & vbCrLf
        S_EXECUTE.Text &= "                            WHERE WHCD = '" & P_whCd & "' AND GRNO = '" & P_grNo & "') IS NULL THEN '수작업 변경' " & vbCrLf
        S_EXECUTE.Text &= "                     ELSE (SELECT SEND_NO  " & vbCrLf
        S_EXECUTE.Text &= "                             FROM MTGR_MST  " & vbCrLf
        S_EXECUTE.Text &= "                            WHERE WHCD = '" & P_whCd & "' AND GRNO = '" & P_grNo & "') " & vbCrLf
        S_EXECUTE.Text &= "                 END) " & vbCrLf
        S_EXECUTE.Text &= "Where " & vbCrLf
        S_EXECUTE.Text &= "WHCD = '" & P_whCd & "'  " & vbCrLf
        S_EXECUTE.Text &= " And GRNO = '" & P_grNo & "' " & vbCrLf
    End Sub

    Private Sub btnUpdateIsu_Click(sender As Object, e As EventArgs) Handles btnUpdateIsu.Click
        Dim P_whCd As String = ""
        Dim P_giNo As String = ""
        If Trim(WHCD.Text) = "" Then
            MsgBoxLocalized("선택된 창고가 없습니다.")
            WHCD.Focus()
            Exit Sub
        Else
            P_whCd = WHCD.Text
        End If
        If Trim(GINO.Text) = "" Then
            MsgBoxLocalized("선택된 반출정보가 없습니다.")
            GINO.Focus()
            Exit Sub
        Else
            P_giNo = GINO.Text
        End If
        splSqlSettings.Controls.Clear()
        ClearView(AppliedRangeTypes.Only, {S_EXECUTE})
        S_EXECUTE.Text &= " Update MTGI_MST " & vbCrLf
        S_EXECUTE.Text &= " Set  " & vbCrLf
        S_EXECUTE.Text &= " EDI_REMARK ='접수통보' " & vbCrLf
        S_EXECUTE.Text &= ",EDI_STATUS = 'Y'	" & vbCrLf
        S_EXECUTE.Text &= ",EDI_SEND_NO = (CASE WHEN (SELECT SEND_NO  " & vbCrLf
        S_EXECUTE.Text &= "                             FROM MTGI_MST  " & vbCrLf
        S_EXECUTE.Text &= "                            WHERE WHCD = '" & P_whCd & "' AND GINO = '" & P_giNo & "') IS NULL THEN '수작업 변경' " & vbCrLf
        S_EXECUTE.Text &= "                     ELSE (SELECT SEND_NO  " & vbCrLf
        S_EXECUTE.Text &= "                             FROM MTGI_MST  " & vbCrLf
        S_EXECUTE.Text &= "                            WHERE WHCD = '" & P_whCd & "' AND GINO = '" & P_giNo & "') " & vbCrLf
        S_EXECUTE.Text &= "                 END) " & vbCrLf
        S_EXECUTE.Text &= "Where " & vbCrLf
        S_EXECUTE.Text &= "WHCD = '" & P_whCd & "' " & vbCrLf
        S_EXECUTE.Text &= " And GINO = '" & P_giNo & "' " & vbCrLf
    End Sub

    Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        ClearView(AppliedRangeTypes.Only, {HBLNO, MRN, WHCD, WHNM, WG_WH, GRNO, RCP_SEND_NO, WG_RCP, GINO, ISU_SEND_NO, WG_ISU})
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If GV_SQL.FocusedRowHandle >= 0 Then
            GV_SQL_FocusedRowChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnCargoList_Click(sender As Object, e As EventArgs) Handles btnCargoList.Click
        If GV_WH.RowCount = 0 Then
            MsgBoxLocalized("조회된 창고가 없습니다.", MessageBoxButtons.OK, "", MessageBoxIcon.Warning)
            Exit Sub
        End If
        ' 보세화물 반입 정보 보여주는 팝업
        Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
        Dim fTarget As Object = frmMain.NavigateTo("BwsCargoList", UI.NavigatedWindowModes.Dialog, False)
        fTarget.CUST_CD.Text = CUST_CD.Text
        fTarget.CUST_NM.Text = CUST_NM.Text
        fTarget.DB_IP.Text = DB_IP.Text
        fTarget.DB_PORT.Text = DB_PORT.Text
        fTarget.DB_SID.Text = DB_SID.Text
        fTarget.USR_ID.Text = USR_ID.Text
        fTarget.USR_PWD.Text = USR_PWD.Text
        fTarget.DOMAIN.Text = DOMAIN.Text
        fTarget.CTRY_CD.Text = CTRY_CD.Text
        fTarget.WHCD.Text = GV_WH.GetRowCellValue(GV_WH.FocusedRowHandle, "WHCD")
        fTarget.WHNM.Text = GV_WH.GetRowCellValue(GV_WH.FocusedRowHandle, "WHNM")
        fTarget.ShowDialog()

        If fTarget.return_Mrn <> "" Then
            Me.ClearView(AppliedRangeTypes.Only, {HBLNO, MRN})
            MRN.Text = fTarget.return_Mrn
            SearchRcp()
        End If
    End Sub

    Private Sub btnIsuPopup_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "=================Helper Methods==========="

#End Region

End Class
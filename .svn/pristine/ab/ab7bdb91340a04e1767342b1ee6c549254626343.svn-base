Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing
Imports YJIT.SC.UI
Imports System.Text
Imports System
Imports System.Collections.Generic
Imports System.Text.RegularExpressions
Imports System.IO
Public Class HelpSqlExecuter

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

                    Dim dt As DataTable = ds.Tables("WG_DOMAIN").Copy
                    dt.TableName = "ConnectInfo"
                    YJSql.DataSet.Tables.Add(dt)

                Case "Execute".ToString.ToUpper
                    Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
                    YJSql.SqlBox("WG_EXECUTE", "SysRuntimeInfo@Search", True)
                    YJSql.Params("SQLEXECUTE", S_EXECUTE.Text.ToString.Trim, False)
                Case "Domain".ToString.ToUpper
                    Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
                    YJSql.SqlBox("WG_DOMAIN", "SysRuntimeInfo@SearchDomain", True)
                    YJSql.Params("SVC_CD", drMAIN("S_SVC_CD").ToString, False)
                    If Not String.IsNullOrEmpty(SavedSessionDomain) Then
                        Select Case SavedSessionDomain
                            Case "CRM.ELVIS.COM"
                                '전체검색
                            Case Else
                                YJSql.Params("DOMAIN", SavedSessionDomain.ToString.Trim, True)
                        End Select
                    End If

                    YJSql.SqlBox("WG_SQL", "HelpSqlExecuter@SearchSql", True)
                    'YJSql.Params("SQLEXECUTE", S_EXECUTE.Text.ToString.Trim, False)
                Case Else
                    Throw New Exception("등록된 조회 조건이 없습니다. (GetConvertToDataSet)")
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function

    Private Sub DomainData()
        Dim dsRet As DataSet = GetConvertToDataSet("Domain")

        dsRet = MethodCallEx(Me, "YJIT.Sys.RuntimeInfo", "Search", {dsRet})
        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case drPairs("TrxCode")
            Case "Y"
                Me.ClearView(UI.AppliedRangeTypes.Only, {WG_DOMAIN})
                Me.BindToDataset(dsRet, "Data")
            Case "N"
                Me.ClearView(UI.AppliedRangeTypes.Only, {WG_DOMAIN})
                MsgBoxLocalized(drPairs("TrxMsg"))
            Case Else
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
                    arlReturn.Add(sParam)
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

                txtNew.Text = arlParams(i).Replace("@", "")
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

#End Region

#Region "=================Control Events==========="

    Private Sub GV_DOMAIN_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV_DOMAIN.FocusedRowChanged
        If GV_DOMAIN.RowCount = 0 Then Exit Sub
        If GV_DOMAIN.FocusedRowHandle < 0 Then Exit Sub

        S_DOMAIN.Text = GV_DOMAIN.GetFocusedRowCellValue("DOMAIN").ToString
    End Sub

    Private Sub btnDomain_Click(sender As System.Object, e As System.EventArgs) Handles btnDomain.Click
        Call DomainData()
    End Sub

    Private Sub GV_SQL_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV_SQL.FocusedRowChanged
        If GV_SQL.RowCount = 0 Then Exit Sub
        If GV_SQL.FocusedRowHandle < 0 Then Exit Sub

        S_EXECUTE.Text = GV_SQL.GetFocusedRowCellValue("SQL_STR").ToString

        Call createSqlSettingControls(S_EXECUTE.Text)
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

        For i As Integer = 0 To GV_DOMAIN.RowCount - 1
            GV_DOMAIN.GetDataRow(i).AcceptChanges()
            If GV_DOMAIN.GetDataRow(i)("DOMAIN").ToString = S_DOMAIN.Text.ToString Then
                GV_DOMAIN.GetDataRow(i).SetAdded()
            End If
        Next

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

#End Region

#Region "=================Helper Methods==========="

#End Region

End Class
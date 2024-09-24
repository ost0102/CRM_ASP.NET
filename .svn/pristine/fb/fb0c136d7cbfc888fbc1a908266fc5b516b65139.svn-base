Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing
Imports YJIT.SC.UI
Imports System.Text
Imports System
Imports System.Collections.Generic
Imports System.Text.RegularExpressions
Imports System.IO
Public Class HelpServerInfoMgt

#Region "=================Data logic actions==========="

    Public Sub PopupInit()
        Dim PopUp As New PopupBase

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG1_ADDROW", "Add row", True)
        PopUp.ItemAdd(Action.DeleteRow, "WG1_DELETEROW", "Delete row")
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", Me.Localizer.GetLocalizedString("&Export Excel"), True)
        PopUp.PopUpInit(Me, WG1, "GV1_DOMAIN", "GV1_DATA_CHK")

    End Sub

    Private Function GetConvertToDataSet() As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
            YJSql.SqlBox("WG1", "HelpServerInfoMgt@Search", True)
            YJSql.Params("DB_LINK", drMAIN("S_DB_LINK").ToString.Trim, True)
            YJSql.Params("SEARCH_KEY", drMAIN("SEARCH_KEY").ToString.Trim, True)
            YJSql.Params("SVC_CD", drMAIN("S_SVC_CD").ToString, True)
            YJSql.Blocks("SVC_CD", drMAIN("S_SVC_CD").ToString, True)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function

    Public Sub SearchData()
        Dim dsRet As DataSet = GetConvertToDataSet()

        Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", "잠시만 기다려주세요. 자료조회중입니다.")
            dsRet = MethodCallEx(Me, "YJIT.Biz.HelpServerInfoMgt", "Search", {dsRet})
        End Using
        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case drPairs("TrxCode")
            Case "Y"
                Me.ClearView(UI.AppliedRangeTypes.Only, {WG1})
                Me.BindToDataset(dsRet, "Data")

                GV1.BestFitColumns()

                Me.DataState = UI.DataStates.Retrieved
            Case "N"
                Me.ClearView(UI.AppliedRangeTypes.Only, {WG1})
                MsgBoxLocalized(drPairs("TrxMsg"))
                Call ClearView(AppliedRangeTypes.Only, {WG1})

                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(drPairs("TrxMsg"))
        End Select

    End Sub

    Private Sub AddNewRow(ByVal dt As DataTable, ByVal Code As String, ByVal Name As String)
        dt.Rows.Add()
        dt.Rows(dt.Rows.Count - 1)("CODE") = Code
        dt.Rows(dt.Rows.Count - 1)("NAME") = Name
    End Sub

    Public Sub GridInit()

        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)

        Dim editorCombo As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        Dim dt As New DataTable

        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))
        AddNewRow(dt, "Y", "Yes")
        AddNewRow(dt, "N", "No")
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV1.Columns("NEW_CUST_YN").ColumnEdit = editorCombo
        GV1.Columns("USE_YN").ColumnEdit = editorCombo
        GV1.Columns("TB_CHG_YN").ColumnEdit = editorCombo
        GV1.Columns("DATA_CHK").ColumnEdit = editorCombo
        GV1.Columns("WCF_LOG_YN").ColumnEdit = editorCombo


        ' SVC_CD
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "C01")
        dataParams.Add("NameType", "")
        editorCombo.ShowHeader = False
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV1.Columns("SVC_CD").ColumnEdit = editorCombo

        ' APPLY_SOURCE
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "H01")
        dataParams.Add("NameType", "")
        editorCombo.ShowHeader = False
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV1.Columns("APPLY_SOURCE").ColumnEdit = editorCombo



        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = CType(S_DB_LINK.DataSource, DataTable).Copy
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV1.Columns("DB_LINK").ColumnEdit = editorCombo


    End Sub

    '//Function for Get path of TNS File 
    Public Shared Function GetPathToTNSNamesFile() As String
        Dim systemPath As String = Environment.GetEnvironmentVariable("Path")
        Dim reg As New Regex("[a-zA-Z]:\\[a-zA-Z0-9\\]*(oracle|app)[a-zA-Z0-9_.\\]*(?=bin)")
        Dim col As MatchCollection = reg.Matches(systemPath)

        Dim subpath As String = "network\ADMIN\tnsnames.ora"
        For Each match As Match In col
            Dim path As String = match.ToString() & subpath
            If File.Exists(path) Then
                Return path
            End If
        Next
        Return String.Empty
    End Function

    Private Function GetTnsList()
        Dim RtnDic As New Dictionary(Of String, String)
        Dim DBNamesCollection As New List(Of String)()
        Dim regPattern As String = "[\n][\s]*[^\(][a-zA-Z0-9_.]+[\s]*"
        Dim tnsNamesOraFilePath As String = GetPathToTNSNamesFile()
        Dim TempTnsContents As String = ""
        If Not tnsNamesOraFilePath.Equals("") Then
            ' Verify file exists
            Dim tnsNamesOraFile As New FileInfo(tnsNamesOraFilePath)
            If tnsNamesOraFile.Exists Then
                If tnsNamesOraFile.Length > 0 Then
                    'read tnsnames.ora file                        
                    Dim tnsNamesContents As String = File.ReadAllText(tnsNamesOraFile.FullName)
                    Dim t() As String = File.ReadAllLines(tnsNamesOraFile.FullName)
                    Dim numMatches As Integer = Regex.Matches(tnsNamesContents, regPattern).Count
                    Dim col As MatchCollection = Regex.Matches(tnsNamesContents, regPattern)
                    For Each match As Match In col
                        Dim m As String = match.ToString()
                        m = m.Trim()
                        DBNamesCollection.Add(m.ToUpper())
                    Next
                End If
            End If
        End If
        Return DBNamesCollection
    End Function

    Private Sub CreateTnsnames()
        If String.IsNullOrEmpty(GV1.GetFocusedRowCellValue("DB_IP_EXT").ToString) Then
            MsgBoxLocalized("외부IP를 입력후 사용하세요.")
            Exit Sub
        End If

        Try
            Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", "잠시만 기다려주세요. 자료처리중입니다.")
                Dim FullPath As String = GetPathToTNSNamesFile()
                Dim Path As String = FullPath.Substring(0, FullPath.LastIndexOf("\") + 1)
                Dim FileName As String = FullPath.Remove(0, FullPath.LastIndexOf("\") + 1)
                Dim Files As ObjectModel.ReadOnlyCollection(Of String) = FileIO.FileSystem.GetFiles(FullPath.Substring(0, FullPath.LastIndexOf("\")))

                Dim ti As String = Now.ToString("yyyyMMdd HHmmss")
                Dim backupPath As String = Application.StartupPath & "\System\Tnsname\" & FileName & ".backup " & ti & ".txt"
                Dim BackupRoot As String = Application.StartupPath & "\System\Tnsname\"
                Try
                    If FileIO.FileSystem.DirectoryExists(BackupRoot) = False Then
                        FileIO.FileSystem.CreateDirectory(BackupRoot)
                    End If
                    If FileIO.FileSystem.FileExists(backupPath) = True Then
                        FileIO.FileSystem.DeleteFile(backupPath)
                    End If
                    FileIO.FileSystem.CopyFile(FullPath, backupPath)
                Catch ex As Exception

                End Try

                'Dim Tlist As Object = GetTnsList()

                Dim G_TNSNAME As String = GV1.GetFocusedRowCellValue("TNS_NM").ToString
                Dim G_PROTOCOL As String = "TCP"
                'Dim G_HOST As String = GV1.GetFocusedRowCellValue("DB_IP").ToString
                Dim G_HOST As String = GV1.GetFocusedRowCellValue("DB_IP_EXT").ToString
                Dim G_PORT As String = GV1.GetFocusedRowCellValue("DB_PORT").ToString
                Dim G_SID As String = GV1.GetFocusedRowCellValue("DB_SID").ToString

                Dim Buff_Line As New StreamReader(FullPath, Encoding.Default) '기존 파일내용
                Dim Buff_Str As String = "" '동일내용있을때
                Dim Buff_Str2 As String = "" '새로운 파일

                Do While Buff_Line.Peek() >= 0
                    Buff_Str = Buff_Line.ReadLine   'tnsnames.ora 파일 한줄씩 읽어옴.

                    If Buff_Str.Trim.StartsWith(G_TNSNAME) Then
                        Do While (1)
                            Buff_Str = Buff_Line.ReadLine
                            If Trim(Buff_Str) = ")" Then
                                Exit Do
                            End If
                        Loop
                    Else
                        If Buff_Str <> "" Then
                            Buff_Str2 = Buff_Str2 + Buff_Str + Chr(13) + Chr(10)
                        End If

                    End If
                Loop

                Buff_Line.Close()

                Dim eachTns As String = G_TNSNAME & " =" & vbCrLf & _
                                    "  (DESCRIPTION =" & vbCrLf & _
                                    "    (ADDRESS_LIST =" & vbCrLf & _
                                    "      (ADDRESS = (PROTOCOL = " & G_PROTOCOL & ")(HOST = " & G_HOST & ")(PORT = " & G_PORT & "))" & vbCrLf & _
                                    "    )" & _
                                    "    (CONNECT_DATA =" & vbCrLf & _
                                    "      (SERVICE_NAME = " & G_SID & ")" & vbCrLf & _
                                    "    )" & vbCrLf & _
                                    "  )"
                If Buff_Str2 <> "" Then
                    Buff_Str2 &= vbCrLf
                End If
                Buff_Str2 = Buff_Str2 & eachTns

                'Tnsname.Text
                Buff_Str2 = vbCrLf & Buff_Str2
                FileIO.FileSystem.WriteAllText(FullPath, Buff_Str2, False)
            End Using
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub

    Public Function MandatoryGridValue(ByVal gridView As String) As Boolean
        Dim Param As New Dictionary(Of String, Object)
        Dim checkNull() As String = Nothing

        Select Case gridView
            Case "GV1"
                checkNull = {"SVC_CD", "DB_LINK"}
                Param("SVC_CD") = GV1_SVC_CD.Caption
                Param("DOMAIN") = GV1_DOMAIN.Caption
                Param("TNS_NM") = GV1_TNS_NM.Caption
                Param("DB_IP") = GV1_DB_IP.Caption
                Param("DB_IP_EXT") = GV1_DB_IP_EXT.Caption
                Param("USR_ID") = GV1_USR_ID.Caption
                Param("USR_PWD") = GV1_USR_PWD.Caption
                Param("DB_PORT") = GV1_DB_PORT.Caption
                Param("DB_SID") = GV1_DB_SID.Caption

                Return ValidateGridValue(GV1, Param, checkNull)
        End Select

        Return True

    End Function
    Public Sub PopUpOnAfterClick(ByVal dr As DataRow)
        Debug.Print("PopUpOnAfterClick")
        Dim key As String = dr("Key").ToString
        Dim Sender As String = ""
        If Not dr("Sender") Is System.DBNull.Value Then Sender = dr("Sender")
        Select Case dr("Action")
            Case Action.Addrow, Action.EventKey
                Select Case Sender
                    Case "WG1"
                        If GV1.RowCount = 0 Then
                            GV1.SetFocusedRowCellValue("SVC_CD", S_SVC_CD.SelectedValue)
                            GV1.SetFocusedRowCellValue("DB_PORT", "1521")
                            GV1.SetFocusedRowCellValue("DB_SID", "ORCL")
                            GV1.SetFocusedRowCellValue("DB_LINK", S_DB_LINK.SelectedValue)
                        Else
                            GV1.SetFocusedRowCellValue("SVC_CD", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "SVC_CD").ToString)
                            GV1.SetFocusedRowCellValue("WEB_IP", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "WEB_IP").ToString)
                            GV1.SetFocusedRowCellValue("WEB_IP_EXT", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "WEB_IP_EXT").ToString)
                            GV1.SetFocusedRowCellValue("DB_IP", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "DB_IP").ToString)
                            GV1.SetFocusedRowCellValue("DB_IP_EXT", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "DB_IP_EXT").ToString)
                            GV1.SetFocusedRowCellValue("DB_PORT", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "DB_PORT").ToString)
                            GV1.SetFocusedRowCellValue("DB_SID", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "DB_SID").ToString)
                            GV1.SetFocusedRowCellValue("DB_LINK", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "DB_LINK").ToString)
                        End If
                        GV1.SetFocusedRowCellValue("NEW_CUST_YN", "Y")
                        GV1.SetFocusedRowCellValue("USE_YN", "Y")
                        GV1.SetFocusedRowCellValue("TB_CHG_YN", "Y")
                        GV1.SetFocusedRowCellValue("DATA_CHK", "Y")
                        GV1.SetFocusedRowCellValue("WCF_LOG_YN", "N")
                End Select
        End Select

    End Sub

    Public Sub SaveData()

        If MandatoryGridValue("GV1") Then Exit Sub

        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.YesNo) = MsgBoxResult.No Then Exit Sub


        Dim dsResult As DataSet
        Try
            Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", "잠시만 기다려주세요. 자료처리중입니다.")
                dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.HelpServerInfoMgt", "Save", Me.ConvertToDataset)
            End Using
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow
        dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") = "Y" Then
            Call SearchData()
        Else
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub
#End Region

#Region "=================Control Events==========="

    Private Sub HelpServerInfoMgt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call GridInit()

        'Grid Indicator 설정
        Call DrawRowIndicator(GV1)
    End Sub

    Private Sub HelpServerInfoMgt_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Call PopupInit()

        S_DB_LINK.Focus()
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub

    Private Sub tnsSetting_Click(sender As System.Object, e As System.EventArgs) Handles tnsSetting.Click
        'MsgBoxLocalized("테스트중")
        Call CreateTnsnames()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub

    Private Sub SEARCH_KEY_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles SEARCH_KEY.PreviewKeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Call SearchData()
        End If
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        ClearView(AppliedRangeTypes.All)

        S_DB_LINK.SelectedValue = "ELVIS"
    End Sub
#End Region

#Region "=================Helper Methods==========="

#End Region

End Class
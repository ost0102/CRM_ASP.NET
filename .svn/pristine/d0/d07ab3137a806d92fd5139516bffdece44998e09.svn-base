Imports System.IO
Imports System.Text

Public Class MdmExrateMgt

#Region "=================Data logic actions==========="
    Public Sub SearchData()
        ClearView(UI.AppliedRangeTypes.Only, {FROM_DATE, TO_DATE})

        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.MdmExrateMgt", "Search", Me.ConvertToDataset, AddressOf search_OnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Public Sub search_OnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Try
            If IsNothing(e.Result) Then
                Throw New Exception("Try Again!")
            End If
            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
            If dr("TrxCode") <> "Y" Then
                If dr("TrxCode") = "N" Then
                    ClearView(AppliedRangeTypes.Only, {WG1})
                    S_EXRT_YMD.Focus()
                End If
                If dr("TrxCode") = "E" Then
                    MsgBoxLocalized(dr("TrxMsg"))
                    S_EXRT_YMD.Focus()
                End If
                Exit Sub
            End If
            Me.BindToDataset(ds, "Data")

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Public Function MandatoryGridValue(ByVal gridView As String) As Boolean
        Dim Param As New Dictionary(Of String, Object)
        Dim checkNull() As String = Nothing

        Select Case gridView
            Case "ABGV1"
                checkNull = {"CURR_CD"}
                Param("CURR_CD") = ABGV1_CURR_CD.Caption
                Param("CURR_UNIT") = ABGV1_CURR_UNIT.Caption
                Param("EXCH_BASERT") = ABGV1_EXCH_BASERT.Caption

                Return ValidateGridValue(ABGV1, Param, checkNull)
            Case "GV2"
                checkNull = {"CURR_CD"}
                Param("CURR_CD") = ABGV1_CURR_CD.Caption
                Param("CURR_UNIT") = ABGV1_CURR_UNIT.Caption

                Return ValidateGridValue(ABGV1, Param, checkNull)

        End Select

        Return False

    End Function

    Public Sub SaveData()

        ' Grid DeleteRow Check
        If MandatoryGridValue("ABGV1") Then Exit Sub
        If MandatoryGridValue("GV2") Then Exit Sub


        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.YesNo, "Confirm", MessageBoxIcon.Question) = MsgBoxResult.No Then Exit Sub


        If EX_DATE.Text <> "" And EX_DATE.Text <> S_EXRT_YMD.Text Then
            If MsgBoxLocalized("화면의 환율일자와 업로드 파일의 환율일자가 상이 합니다!" & vbCrLf & vbCrLf & "계속진행하시겠습니까?", MessageBoxButtons.YesNo, "Warning", MessageBoxIcon.Warning) = MsgBoxResult.No Then Exit Sub
        End If

        Dim params As DataSet = Me.ConvertToDataset
        Dim dsRet As DataSet

        Try
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MdmExrateMgt", "Save", params)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
        Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") <> "Y" Then
            Select Case dr("TrxCode")
                Case "N"
                Case "E"
                    Me.BindToDataset(dsRet, "Data")
                    Me.DataState = UI.DataStates.Retrieved
            End Select
            MsgBoxLocalized(dr("TrxMsg"))
        Else
            Me.BindToDataset(dsRet, "Data")
            MsgBoxLocalized(dr("TrxMsg"))
        End If
        Me.DataState = UI.DataStates.Retrieved

    End Sub

    Public Sub DeleteData()

        If MsgBoxLocalized("Do you want to delete?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then Exit Sub

        Dim dsRet As New DataSet
        Try
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MdmExrateMgt", "Delete", Me.ConvertToDataset)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
        Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") <> "Y" Then
            Select Case dr("TrxCode")
                Case "N"
                Case "E"
                    Me.BindToDataset(dsRet, "Data")
                    Me.DataState = UI.DataStates.Retrieved
            End Select
            MsgBoxLocalized(dr("TrxMsg"))
        Else
            Me.BindToDataset(dsRet, "Data")
            ClearView(AppliedRangeTypes.Only, {WG1})
            S_EXRT_YMD.Focus()
            MsgBoxLocalized(dr("TrxMsg"))
        End If
        Me.DataState = UI.DataStates.Retrieved

    End Sub
    Public Sub CopyData()

        If MsgBoxLocalized("Do you want to copy?", MessageBoxButtons.OKCancel) = MsgBoxResult.No Then Exit Sub

        If ABGV1.RowCount = 0 Then Exit Sub

        If S_EXRT_YMD.ToString.Replace("-", "") & "" = "" Then
            MsgBoxLocalized("Please input date.")
            S_EXRT_YMD.Focus()
            Exit Sub
        End If

        If FROM_DATE.ToString.Replace("-", "") & "" = "" Then
            MsgBoxLocalized("Please input date.")
            FROM_DATE.Focus()
            Exit Sub
        End If
        If TO_DATE.ToString.Replace("-", "") & "" = "" Then
            MsgBoxLocalized("Please input date.")
            TO_DATE.Focus()
            Exit Sub
        End If

        Dim params As DataSet = Me.ConvertToDataset

        Dim dsRet As DataSet
        Try
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MdmExrateMgt", "Copy", params)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") <> "Y" Then
            Select Case dr("TrxCode")
                Case "N"
                Case "E"
                    Me.BindToDataset(dsRet, "Data")
                    Me.DataState = UI.DataStates.Retrieved
            End Select
            MsgBoxLocalized(dr("TrxMsg"))
        Else
            Me.BindToDataset(dsRet, "Data")
            MsgBoxLocalized(dr("TrxMsg"))
        End If
        Me.DataState = UI.DataStates.Retrieved

    End Sub
    Public Sub exelUpLoad()

        Dim filePath As String = ""
        Dim ds As DataSet
        Dim Dialog As OpenFileDialog = New OpenFileDialog()
        Dialog.Title = "Excel Import"
        Dialog.InitialDirectory = "c:\"
        Dialog.FilterIndex = 1
        Dialog.RestoreDirectory = True
        Dialog.Multiselect = True
        Dialog.Filter = "Excel Spreadsheets (*.xls)|*.xls|Excel 2007 and later (*.xlsx)|*.xlsx"

        If Dialog.ShowDialog() = DialogResult.OK Then
            FILE_PATH.Text = Dialog.FileName
            Dim tempLeng As New Integer
            ds = ImportExcel(Dialog.FileName)

            Dim dt As DataTable = New DataTable
            dt = ds.Tables(0)
            For i = 0 To dt.Columns.Count - 1
                dt.Columns(i).ColumnName = ABGV1.Columns(i).FieldName
            Next

            ' Table 내용 AddRow
            For row = 0 To dt.Rows.Count - 1
                WG1.AddRow()
                For col = 0 To dt.Columns.Count - 1
                    ABGV1.SetRowCellValue(ABGV1.FocusedRowHandle, dt.Columns(col).ColumnName, dt.Rows(row)(col))
                Next
            Next

            ABGV1.FocusedRowHandle = 0
        End If

    End Sub

    Public Sub FileUpload()
        Dim ds As DataSet
        Dim dt As DataTable
        Dim dr As DataRow
        Dim dlgFile As New OpenFileDialog
        Dim FilePath As String
        Dim strLine As String = String.Empty
        Dim strArr As Array
        Dim EXDT As String = ""
        Dim CURR As String = ""
        With dlgFile
            .Title = "Open exchange rate information file..."
            .FilterIndex = 1
            .CheckFileExists = False
        End With
        If dlgFile.ShowDialog() = DialogResult.OK Then
            FilePath = dlgFile.FileName
        Else
            Exit Sub
        End If
        For i = 0 To ABGV1.RowCount - 1
            If ABGV1.GetDataRow(i).RowState = DataRowState.Unchanged Then
                ABGV1.GetDataRow(i).SetAdded()
            End If
        Next
        dt = GetExrateData(FilePath)
        dt.TableName = "WG1"
        WG1.DataSource = dt
    End Sub

    Public Function GetExrateData(ByVal FilePath As String)
        Dim ds As DataSet
        Dim dt As DataTable = Nothing
        Dim dr As DataRow
        Dim strLine As String = String.Empty
        Dim strArr As Array
        Dim EXDT As String = ""
        Dim CURR As String = ""
        Try
            Dim sr As New StreamReader(FilePath, Encoding.Default)
            ds = Me.ConvertToDataset
            dt = ds.Tables("WG1")
            strLine = sr.ReadLine
            strLine = sr.ReadLine
            strLine = sr.ReadLine
            strLine = sr.ReadLine
            EXDT = strLine.ToString.Substring(strLine.IndexOf(":") + 2, 10).Replace("-", "")
            EX_DATE.Text = EXDT
            strLine = sr.ReadLine
            strLine = sr.ReadLine
            strLine = sr.ReadLine
            Do While sr.Peek() >= 0
                strLine = sr.ReadLine
                If strLine = "" Then
                    Continue Do
                End If
                strArr = strLine.Split(vbTab)
                CURR = strArr(0).ToString.Trim
                If Mid(CURR, Len(CURR) - 2, 3) = "100" Then
                    CURR = Mid(CURR, Len(CURR) - 6, 3)
                Else
                    CURR = Mid(CURR, Len(CURR) - 2, 3)
                End If
                If strArr.Length >= 11 And CURR <> "TZS" Then
                    dr = dt.NewRow()
                    dr("CURR_CD") = CURR
                    If (strArr(0).ToString.IndexOf("100") > 1) Then
                        dr("CURR_UNIT") = 100
                    Else
                        dr("CURR_UNIT") = 1
                    End If
                    dr("CASH_BUYRT") = strArr(1).ToString.Trim.Replace(",", "")
                    dr("CASH_SELLRT") = strArr(3).ToString.Trim.Replace(",", "")
                    dr("WIRE_SEND_EXRT") = strArr(5).ToString.Trim.Replace(",", "")
                    dr("WIRE_RECV_EXRT") = strArr(6).ToString.Trim.Replace(",", "")
                    dr("EXCH_BASERT") = strArr(9).ToString.Trim.Replace(",", "")
                    dr("USD_CONV_RT") = strArr(11).ToString.Trim.Replace(",", "")
                    dt.Rows.Add(dr)

                End If
            Loop

            sr.Close()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

        Return dt
    End Function
#End Region
#Region "=================Control Events==========="
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Call DeleteData()
    End Sub
    Private Sub btnCopyExchangeRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyExchangeRate.Click
        Call CopyData()
    End Sub
    Private Sub MdmExrateMgt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call SetMandatoryLine(Me)
        Call InitGrid()
        Call DrawRowIndicator({ABGV1})
    End Sub
    Private Sub MdmExrateMgt_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Call PopupInit()
        S_EXRT_YMD.Text = Now.ToString("yyyyMMdd")
        Call SearchData()
    End Sub
    Private Sub btnFileUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFileUpload.Click

        Call exelUpLoad()
    End Sub
    Public Sub PopupInit()
        Dim PopUp As New PopupBase
        PopUp.ItemAdd(Action.Other, "SiteLink_KEB", "외환은행 환율조회")
        PopUp.PopUpInit(Me)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG1_Addrow", "&Add Row")
        PopUp.ItemAdd(Action.DeleteRow, "WG1_DeleteRow", "&Delete Row")
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", "&Excel Export", True)
        PopUp.PopUpInit(Me, WG1, "CURR_CD", "USD_CONV_RT")


    End Sub
    Public Sub PopUpOnAfterClick(ByVal Dr As DataRow)
        Dim Key As String = Dr("Key")
        '화면 내에 여러 이벤트가 있을경우 case 문으로 Action 분계

        'Navigato 사용할떄
        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing
        Select Case Dr("Action")
            Case Action.Addrow, Action.EventKey
                Select Case Dr("Sender")
                    Case "WG1"
                        ABGV1.SetFocusedRowCellValue("CURR_UNIT", "1")
                        ABGV1.SetFocusedRowCellValue("CASH_SELLRT", "0")
                        ABGV1.SetFocusedRowCellValue("CASH_BUYRT", "0")
                        ABGV1.SetFocusedRowCellValue("WIRE_SEND_EXRT", "0")
                        ABGV1.SetFocusedRowCellValue("WIRE_RECV_EXRT", "0")
                        ABGV1.SetFocusedRowCellValue("EXCH_BASERT", "0")
                        ABGV1.SetFocusedRowCellValue("USD_CONV_RT", "0")
                End Select
            Case Action.Other
                Select Case Key
                    Case "SiteLink_KEB"
                        System.Diagnostics.Process.Start("http://fx.keb.co.kr/FER1101C.web?schID=fex&mID=FER1101C")
                End Select
        End Select

    End Sub
    Private Sub InitGrid()
        'Currency Unit LookUpEdit
        'Dim LookUp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        'Dim searchParams As Dictionary(Of String, Object)
        'Dim dataParams As Dictionary(Of String, Object)
        'LookUp = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        'LookUp.DisplayMember = "NAME"
        'LookUp.ValueMember = "CODE"
        'LookUp.NullText = "--Select--"
        'searchParams = New Dictionary(Of String, Object)
        'dataParams = New Dictionary(Of String, Object)
        'dataParams.Add("GroupCode", "M27")
        'dataParams.Add("NameType", "")
        'LookUp.ShowHeader = False
        'LookUp.ReadOnly = False
        'LookUp.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        'ABGV1.Columns("CURR_UNIT").ColumnEdit = LookUp
    End Sub
    Private Sub ABGV1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles ABGV1.FocusedRowChanged
        If ABGV1.GetFocusedDataSourceRowIndex() >= 0 Then
            If Not IsNothing(ABGV1.GetFocusedDataRow().RowState) Then
                If ABGV1.GetFocusedDataRow().RowState = DataRowState.Added Then
                    Me.ABGV1_CURR_CD.OptionsColumn.AllowEdit = True
                    Me.ABGV1_CURR_CD.OptionsColumn.ReadOnly = False
                Else
                    Me.ABGV1_CURR_CD.OptionsColumn.AllowEdit = False
                    Me.ABGV1_CURR_CD.OptionsColumn.ReadOnly = True
                End If
            End If
        End If
    End Sub
    Private Sub S_EXRT_YMD_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles S_EXRT_YMD.PreviewKeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Call SearchData()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call FileUpload()
    End Sub
#End Region



End Class
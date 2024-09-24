Imports YJIT.SC.UI
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Windows
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Utils
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Commands
Imports DevExpress.XtraGrid.Views.Grid

Public Class EchAccountExcelUpDown

#Region "=================Data logic actions==========="

    Public Sub AFRExelUpLoad()
        Dim ds As DataSet
        Dim Dialog As OpenFileDialog = New OpenFileDialog()
        Dim intRow As Integer = 0
        Dim strPath As String = Environment.CurrentDirectory()

        Dialog.Title = "Excel Import"
        Dialog.InitialDirectory = strPath
        Dialog.FilterIndex = 2
        Dialog.RestoreDirectory = True
        Dialog.Multiselect = True
        Dialog.Filter = "Excel Spreadsheets (*.xls)|*.xls|Excel 2007 and later (*.xlsx)|*.xlsx"

        Try
            If Dialog.ShowDialog() = DialogResult.OK Then
                FILE_PATH.Text = Dialog.FileName

                ds = PF_ImportExcel(Dialog.FileName)

                Dim dt As DataTable = New DataTable

                dt = ds.Tables(0)

                'MsgBoxLocalized("전송년월:" & GV2.Columns("DOC_YYYYMM").VisibleIndex)
                'MsgBoxLocalized("청구년월:" & GV2.Columns("INV_YM").VisibleIndex)
                'MsgBoxLocalized("CRM 거래처:" & GV2.Columns("CUST_CD").VisibleIndex)
                'MsgBoxLocalized("CRM 거래처명:" & GV2.Columns("CUST_LOC_NM").VisibleIndex)
                'MsgBoxLocalized("EXCEL 거래처명:" & GV2.Columns("KLNET_CUST_NM").VisibleIndex)
                'MsgBoxLocalized("HBL 건수:" & GV2.Columns("KL_HBL_COUNT").VisibleIndex)
                'MsgBoxLocalized("식별자:" & GV2.Columns("KLNET_ID").VisibleIndex)
                'MsgBoxLocalized("4 코드:" & GV2.Columns("CUSTOMS_4CODE").VisibleIndex)
                'MsgBoxLocalized("청구액:" & GV2.Columns("KLNET_ACC_AMT").VisibleIndex)
                'MsgBoxLocalized("수수료:" & GV2.Columns("KLNET_COMMISSION").VisibleIndex)
                'MsgBoxLocalized("CHAIN HBL건수:" & GV2.Columns("CHAIN_HBL_COUNT").VisibleIndex)

                ' 컬럼 명 지정
                'If dt.Columns(0).ColumnName = "구분" Then
                dt.Columns(0).ColumnName = GV2.Columns(0).FieldName '전송년월
                'End If

                dt.Columns(1).ColumnName = GV2.Columns(1).FieldName '청구년월

                'If dt.Columns(1).ColumnName = "업체명" Then
                dt.Columns(2).ColumnName = GV2.Columns(4).FieldName 'KL 거래처명
                'End If

                'If Mid(dt.Columns(2).ColumnName, 1, 3) = "HBL" Then
                dt.Columns(3).ColumnName = GV2.Columns(5).FieldName 'HBL 건수
                'End If

                'If dt.Columns(3).ColumnName = "확인" Then
                dt.Columns(4).ColumnName = GV2.Columns(6).FieldName '식별자
                'End If

                'If dt.Columns(4).ColumnName = "포코드" Then
                dt.Columns(5).ColumnName = GV2.Columns(7).FieldName '4코드
                'Else
                dt.Columns(6).ColumnName = GV2.Columns(8).FieldName '청구액
                'End If
                dt.Columns(7).ColumnName = GV2.Columns(9).FieldName '수수료

                ''If dt.Columns(5).ColumnName = "청구액" Then
                'dt.Columns(5).ColumnName = GV2.Columns(7).FieldName '청구액
                'dt.Columns(6).ColumnName = GV2.Columns(8).FieldName '수수료
                ''Else
                'dt.Columns(5).ColumnName = GV2.Columns(8).FieldName '수수료
                'dt.Columns(6).ColumnName = GV2.Columns(6).FieldName '4코드
                'End If

                'dt.Columns(7).ColumnName = GV2.Columns(1).FieldName 'CRM 거래처코드
                'dt.Columns(8).ColumnName = GV2.Columns(2).FieldName 'CRM 거래처명
                'dt.Columns(9).ColumnName = GV2.Columns(9).FieldName 'CHAIN 건수
                'dt.Columns(10).ColumnName = GV2.Columns(10).FieldName   'CHECK
                dt.Columns.Add("CUST_CD", GetType(String))
                dt.Columns.Add("CUST_LOC_NM", GetType(String))
                dt.Columns.Add("CHAIN_HBL_COUNT", GetType(Double))
                dt.Columns.Add("BL_CNT_CK", GetType(String))

                WG2.DataSource = dt.Copy

                Dim drck As DataRow

                For intRow = 0 To GV2.RowCount - 1
                    drck = GV2.GetDataRow(intRow)
                    drck.AcceptChanges()

                    If GV2.GetDataRow(intRow).RowState = DataRowState.Unchanged Then
                        GV2.GetDataRow(intRow).SetAdded()
                    End If
                Next

                For intRow = GV2.RowCount - 1 To 0 Step -1
                    If GV2.GetRowCellValue(intRow, "DOC_YYYYMM").ToString = "" Then
                        Call GV2.DeleteRow(intRow)
                    Else
                        drck = GV2.GetDataRow(intRow)
                        If GV2.GetRowCellValue(intRow, "CUSTOMS_4CODE").ToString = "" Then
                            drck("CUSTOMS_4CODE") = Mid(drck("KLNET_ID"), 1, 4)
                        End If

                        If Not drck("CUST_LOC_NM").GetType Is GetType(String) Then
                            GV2.Columns("CUST_LOC_NM").DisplayFormat.FormatType = DevExpress.Utils.FormatType.None
                            drck("CUST_LOC_NM") = ""
                        End If
                        drck("CUST_CD") = ""
                        drck("CUST_LOC_NM") = ""
                    End If
                Next

                Call SearchData("AFR", "EXCEL")
            End If
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub

    Public Sub UDFExelUpLoad()
        Dim ds As DataSet
        Dim Dialog As OpenFileDialog = New OpenFileDialog()
        Dim intRow As Integer = 0
        Dim strPath As String = Environment.CurrentDirectory()

        Dialog.Title = "Excel Import"
        Dialog.InitialDirectory = "C:\"
        Dialog.FilterIndex = 2
        Dialog.RestoreDirectory = True
        Dialog.Multiselect = True
        Dialog.Filter = "Excel Spreadsheets (*.xls)|*.xls|Excel 2007 and later (*.xlsx)|*.xlsx"

        GV3.ClearDocument()

        Try
            If Dialog.ShowDialog() = DialogResult.OK Then
                FILE_PATH.Text = Dialog.FileName

                ds = PF_ImportExcel(Dialog.FileName)

                Dim dt As DataTable = New DataTable
                Dim bolTF As Boolean = False

                dt = ds.Tables(0)

                'MsgBoxLocalized("YYYYMM:" & GV3.Columns("DOC_YYYYMM").VisibleIndex)
                'MsgBoxLocalized("4CODE:" & GV3.Columns("CUSTOMS_4CODE").VisibleIndex)
                'MsgBoxLocalized("CUST_CD:" & GV3.Columns("CUST_CD").VisibleIndex)
                'MsgBoxLocalized("CUST_NM:" & GV3.Columns("CUST_LOC_NM").VisibleIndex)
                'MsgBoxLocalized("SND_ID:" & GV3.Columns("SND_ID").VisibleIndex)
                'MsgBoxLocalized("RECV_ID:" & GV3.Columns("RECV_ID").VisibleIndex)
                'MsgBoxLocalized("DOC_NM:" & GV3.Columns("DOC_NM").VisibleIndex)
                'MsgBoxLocalized("THIS IPM:" & GV3.Columns("THIS_IPM").VisibleIndex)
                'MsgBoxLocalized("BGM:" & GV3.Columns("BGM").VisibleIndex)
                'MsgBoxLocalized("S/R:" & GV3.Columns("SND_RECV").VisibleIndex)
                'MsgBoxLocalized("BYTE:" & GV3.Columns("SND_BYTE").VisibleIndex)
                'MsgBoxLocalized("KEY:" & GV3.Columns("KEY_NO").VisibleIndex)
                'MsgBoxLocalized("CHAIN BYTE:" & GV3.Columns("CHAIN_SND_BYTE").VisibleIndex)
                'MsgBoxLocalized("품목:" & GV3.Columns("DOC_ITEM").VisibleIndex)

                ' 컬럼 명 지정
                'For intRow = 0 To 11
                '    bolTF = False

                'If dt.Columns(intRow).ColumnName = "구분" Then
                dt.Columns(0).ColumnName = GV3.Columns(0).FieldName 'YYYYMM
                'End If

                dt.Columns(1).ColumnName = GV3.Columns(1).FieldName '청구년월

                'If dt.Columns(intRow).ColumnName = "포코드" Then
                dt.Columns(2).ColumnName = GV3.Columns(2).FieldName '4코드
                'End If

                'If dt.Columns(intRow).ColumnName = "SND" Then
                dt.Columns(3).ColumnName = GV3.Columns(5).FieldName '송신식별자
                'End If

                'If dt.Columns(intRow).ColumnName = "RCIV" Then
                dt.Columns(4).ColumnName = GV3.Columns(6).FieldName '수신식별자
                'End If

                'If dt.Columns(intRow).ColumnName = "THIS_IPM" Then
                dt.Columns(5).ColumnName = GV3.Columns(8).FieldName 'THIS_IPM
                'End If

                'If dt.Columns(intRow).ColumnName = "DOC" Then
                dt.Columns(6).ColumnName = GV3.Columns(7).FieldName '문서명
                'End If

                'If dt.Columns(intRow).ColumnName = "BGM" Then
                dt.Columns(7).ColumnName = GV3.Columns(9).FieldName 'BGM
                'End If

                'If dt.Columns(intRow).ColumnName = "SR" Then
                dt.Columns(8).ColumnName = GV3.Columns(10).FieldName '송/수신
                'End If

                'If dt.Columns(intRow).ColumnName = "BYTE" Then
                dt.Columns(9).ColumnName = GV3.Columns(11).FieldName 'BYTE
                'End If

                'If dt.Columns(intRow).ColumnName = "KEY1" Then
                dt.Columns(10).ColumnName = GV3.Columns(12).FieldName '품목
                'End If

                'If dt.Columns(intRow).ColumnName = "KEY1" Then
                dt.Columns(11).ColumnName = GV3.Columns(13).FieldName 'KEY
                'End If
                'Next

                'dt.Columns(0).ColumnName = GV3.Columns(0).FieldName 'YYYYMM
                'dt.Columns(1).ColumnName = GV3.Columns(1).FieldName '4코드
                'dt.Columns(3).ColumnName = GV3.Columns(4).FieldName '송신식별자
                'dt.Columns(4).ColumnName = GV3.Columns(5).FieldName '수신식별자
                'dt.Columns(5).ColumnName = GV3.Columns(7).FieldName 'THIS_IPM
                'dt.Columns(6).ColumnName = GV3.Columns(6).FieldName '문서명
                'dt.Columns(7).ColumnName = GV3.Columns(8).FieldName 'BGM
                'dt.Columns(8).ColumnName = GV3.Columns(9).FieldName '송/수신
                'dt.Columns(9).ColumnName = GV3.Columns(10).FieldName 'BYTE
                'dt.Columns(10).ColumnName = GV3.Columns(11).FieldName 'KEY
                'dt.Columns(2).ColumnName = GV3.Columns(2).FieldName '거래처코드
                'dt.Columns(11).ColumnName = GV3.Columns(3).FieldName '거래처명
                'dt.Columns(12).ColumnName = GV3.Columns(12).FieldName 'CHAIN BYTE

                dt.Columns.Add("CUST_CD", GetType(String))
                dt.Columns.Add("CUST_LOC_NM", GetType(String))
                dt.Columns.Add("CHAIN_SND_BYTE", GetType(Double))
                dt.Columns.Add("SND_CK", GetType(String))

                WG3.DataSource = dt.Copy

                Dim drck As DataRow

                For intRow = 0 To GV3.RowCount - 1
                    drck = GV3.GetDataRow(intRow)
                    drck.AcceptChanges()

                    If GV3.GetDataRow(intRow).RowState = DataRowState.Unchanged Then
                        GV3.GetDataRow(intRow).SetAdded()
                    End If
                Next

                For intRow = GV3.RowCount - 1 To 0 Step -1
                    If GV3.GetRowCellValue(intRow, "DOC_YYYYMM").ToString = "" Then
                        Call GV3.DeleteRow(intRow)
                    Else
                        drck = GV3.GetDataRow(intRow)
                        If GV3.GetRowCellValue(intRow, "CUSTOMS_4CODE").ToString = "" Then
                            drck("CUSTOMS_4CODE") = Mid(drck("SND_ID"), 5, 4)
                        End If

                        If Not drck("CUST_LOC_NM").GetType Is GetType(String) Then
                            GV3.Columns("CUST_LOC_NM").DisplayFormat.FormatType = DevExpress.Utils.FormatType.None
                            drck("CUST_LOC_NM") = ""
                        End If
                        drck("CUST_CD") = ""
                        drck("CUST_LOC_NM") = ""
                    End If
                Next

                Call SearchData("UDR", "EXCEL")

                btnApply.Enabled = True
                btnUDRSave.Enabled = False
            End If
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub

    Public Sub MFCSACCExcelUpLoad()
        Dim ds As DataSet
        Dim Dialog As OpenFileDialog = New OpenFileDialog()
        Dim intRow As Integer = 0
        Dim strPath As String = Environment.CurrentDirectory()

        Dialog.Title = "Excel Import"
        Dialog.InitialDirectory = "C:\"
        Dialog.FilterIndex = 2
        Dialog.RestoreDirectory = True
        Dialog.Multiselect = True
        Dialog.Filter = "Excel Spreadsheets (*.xls)|*.xls|Excel 2007 and later (*.xlsx)|*.xlsx"

        Try
            If Dialog.ShowDialog() = DialogResult.OK Then
                FILE_PATH.Text = Dialog.FileName

                ds = PF_ImportExcel(Dialog.FileName)

                Dim dt As DataTable = New DataTable
                Dim bolTF As Boolean = False

                dt = ds.Tables(0)

                'MsgBoxLocalized("전송년월:" & GV1.Columns("DOC_YYYYMM").VisibleIndex)
                'MsgBoxLocalized("청구년월:" & GV1.Columns("INV_YM").VisibleIndex)
                'MsgBoxLocalized("송신식별자:" & GV1.Columns("SND_ID").VisibleIndex)
                'MsgBoxLocalized("수신식별자:" & GV1.Columns("RECV_ID").VisibleIndex)
                'MsgBoxLocalized("문서명:" & GV1.Columns("DOC_NM").VisibleIndex)
                'MsgBoxLocalized("송/수신:" & GV1.Columns("SND_RECV").VisibleIndex)
                'MsgBoxLocalized("실 전송량:" & GV1.Columns("TOT_SND_BYTE").VisibleIndex)
                'MsgBoxLocalized("과금 전송량:" & GV1.Columns("ACC_SND_BYTE").VisibleIndex)
                'MsgBoxLocalized("사용료:" & GV1.Columns("ACC_AMT").VisibleIndex)
                'MsgBoxLocalized("수수료:" & GV1.Columns("COMMISSION").VisibleIndex)
                'MsgBoxLocalized("비고:" & GV1.Columns("REMARK").VisibleIndex)

                '컬럼 명 지정
                dt.Columns(0).ColumnName = GV1.Columns(0).FieldName '전송년월
                dt.Columns(1).ColumnName = GV1.Columns(1).FieldName '청구년월
                dt.Columns(2).ColumnName = GV1.Columns(2).FieldName '송신식별자
                dt.Columns(3).ColumnName = GV1.Columns(3).FieldName '수신식별자
                dt.Columns(4).ColumnName = GV1.Columns(4).FieldName '문서명
                dt.Columns(5).ColumnName = GV1.Columns(5).FieldName '송/수신
                dt.Columns(6).ColumnName = GV1.Columns(6).FieldName '실 전송량
                dt.Columns(7).ColumnName = GV1.Columns(7).FieldName '과금 전송량
                dt.Columns(8).ColumnName = GV1.Columns(8).FieldName '사용료(KB*250)
                dt.Columns(9).ColumnName = GV1.Columns(9).FieldName '수수료
                dt.Columns(10).ColumnName = GV1.Columns(10).FieldName '비고

                dt.Columns.Add("CUSTOMS_4CODE", GetType(String))
                dt.Columns.Add("CUST_CD", GetType(String))
                dt.Columns.Add("CUST_LOC_NM", GetType(String))

                WG1.DataSource = dt.Copy

                Dim drck As DataRow

                For intRow = 0 To GV1.RowCount - 1
                    drck = GV1.GetDataRow(intRow)
                    drck.AcceptChanges()

                    If GV1.GetDataRow(intRow).RowState = DataRowState.Unchanged Then
                        GV1.GetDataRow(intRow).SetAdded()
                    End If
                Next

                For intRow = GV1.RowCount - 1 To 0 Step -1
                    If GV1.GetRowCellValue(intRow, "DOC_YYYYMM").ToString = "" Then
                        Call GV1.DeleteRow(intRow)
                    Else
                        drck = GV1.GetDataRow(intRow)
                        If GV1.GetRowCellValue(intRow, "CUSTOMS_4CODE").ToString = "" Then
                            drck("CUSTOMS_4CODE") = Mid(drck("SND_ID"), 5, 4)
                        End If
                    End If
                Next

                Call SearchData("MFCS", "EXCEL")
            End If
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Public Sub SearchData(ByVal vTab As String, ByVal vJob As String)

        Dim dsRet As DataSet = Me.ConvertToDataset


        If vJob <> "EXCEL" And dsRet.Tables("MAIN").Rows(0)("S_STR_YMD") = "" Then
            MsgBoxLocalized("Please enter start date!")
            Exit Sub
        End If

        If vTab = "AFR" Then
            dsRet = MethodCallEx(Me, "YJIT.Biz.EchAccountExcelUpDown", "SearchAFR", {dsRet, vJob})
        ElseIf vTab = "UDR" Then

            If vJob = "EXCEL" Then
                Dim paramsDs As DataSet = Me.ConvertToDataset

                Try
                    dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.EchAccountExcelUpDown", "SaveUDR", {paramsDs, False})
                Catch ex As Exception
                    MsgBoxLocalized(ex.Message)
                    Exit Sub
                End Try
            Else
                dsRet = MethodCallEx(Me, "YJIT.Biz.EchAccountExcelUpDown", "SearchUDR", {dsRet, vJob})
            End If

        ElseIf vTab = "MFCS" Then
            dsRet = MethodCallEx(Me, "YJIT.Biz.EchAccountExcelUpDown", "SearchMFCS", {dsRet, vJob})
        Else
            dsRet = MethodCallEx(Me, "YJIT.Biz.EchAccountExcelUpDown", "SearchAccount", {dsRet})
        End If

        Try
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
            Select Case drPairs("TrxCode")
                Case "Y"
                    Me.BindToDataset(dsRet, "Data")
                    Me.DataState = UI.DataStates.Retrieved

                    If vJob = "EXCEL" Then
                        Dim Ret As Boolean = False

                        If vTab = "AFR" Then
                            btnSave.Enabled = True
                            Ret = PS_Validation(vTab, GV2)
                        ElseIf vTab = "UDR" Then
                            btnApply.Enabled = True
                        ElseIf vTab = "MFCS" Then
                            btnMFCSSave.Enabled = True
                            Ret = PS_Validation(vTab, GV1)
                        End If
                    End If
                Case "N"
                    MsgBoxLocalized(drPairs("TrxMsg"))
                    Call ClearView(AppliedRangeTypes.Only, {WG2})
                    Me.DataState = UI.DataStates.Retrieved
                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try


    End Sub

    'AFR 세관부호 누락, 사용월, 청구월, CRM 거래처코드 누락 체크
    Public Function PS_Validation(ByVal vTab As String, ByVal vGrid As Object) As Boolean
        Dim iRow As Integer
        Dim dr As DataRow
        Dim errMsg As String = ""

        'Select Case vTab
        '    Case "AFR"
        For iRow = 0 To vGrid.RowCount - 1
            dr = vGrid.GetDataRow(iRow)

            If dr("DOC_YYYYMM").ToString = "" Then
                errMsg = "Line : " & CStr(iRow + 1) & "번의 사용년월이 없습니다." & vbCrLf & errMsg
            End If

            If dr("INV_YM").ToString = "" Then
                errMsg = "Line : " & CStr(iRow + 1) & "번의 청구년월이 없습니다." & vbCrLf & errMsg
            End If

            If dr("CUSTOMS_4CODE").ToString = "" Then
                errMsg = "Line : " & CStr(iRow + 1) & "번의 세관4코드가 없습니다." & vbCrLf & errMsg
            End If

            If dr("CUST_CD").ToString = "" Then
                errMsg = "Line : " & CStr(iRow + 1) & "번에 CRM의 거래처코드를 가져오지 못했습니다." & vbCrLf & errMsg
            End If
        Next
        '    Case "MFCS_UDR"

        '    Case "MFCS_ACC"
        'For iRow = 0 To GV1.RowCount - 1
        '    dr = GV1.GetDataRow(iRow)

        '    If dr("DOC_YYYYMM").ToString = "" Then
        '        errMsg = "Line : " & CStr(iRow + 1) & "번의 사용년월이 없습니다." & vbCrLf & errMsg
        '    End If

        '    If dr("INV_YM").ToString = "" Then
        '        errMsg = "Line : " & CStr(iRow + 1) & "번의 청구년월이 없습니다." & vbCrLf & errMsg
        '    End If

        '    If dr("CUSTOMS_4CODE").ToString = "" Then
        '        errMsg = "Line : " & CStr(iRow + 1) & "번의 세관4코드가 없습니다." & vbCrLf & errMsg
        '    End If

        '    If dr("CUST_CD").ToString = "" Then
        '        errMsg = "Line : " & CStr(iRow + 1) & "번에 CRM의 거래처코드를 가져오지 못했습니다." & vbCrLf & errMsg
        '    End If
        'Next

        'End Select

        If errMsg <> "" Then
            MsgBoxLocalized(errMsg)

            PS_Validation = False
        Else
            PS_Validation = True
        End If
    End Function

    'Grid View Sequence 표시 함수
    Private Sub SetGridViewSequence(ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs)
        Dim rowIndex As Integer = e.RowHandle

        e.Info.DisplayText = "No"

        If rowIndex >= 0 Then
            rowIndex += 1
            e.Info.DisplayText = rowIndex.ToString()
        End If

        e.Info.ImageIndex = -1
    End Sub

    Public Sub ClearData()
        Me.ClearView()

        btnSave.Enabled = False
        btnUDRSave.Enabled = False
        btnApply.Enabled = False
        btnMFCSSave.Enabled = False
    End Sub

    Private Sub SaveData(ByVal vTab As String)
        Dim ds As DataSet = Nothing
        Dim dr As DataRow = Nothing

        If vTab = "AFR" Then
            If Not PS_Validation(vTab, GV2) Then Exit Sub
        ElseIf vTab = "MFCS" Then
            If Not PS_Validation(vTab, GV1) Then Exit Sub
        End If

        Dim paramsDs As DataSet = Me.ConvertToDataset

        Try
            If vTab = "AFR" Then
                ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.EchAccountExcelUpDown", "SaveAFR", {paramsDs})
            ElseIf vTab = "UDR" Then
                ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.EchAccountExcelUpDown", "SaveUDR", {paramsDs, True})
            ElseIf vTab = "UDR_APPLY" Then
                ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.EchAccountExcelUpDown", "SaveUDR_APPLY", {paramsDs})
            Else
                ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.EchAccountExcelUpDown", "SaveMFCS", {paramsDs})
            End If
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") <> "Y" Then
            Select Case dr("TrxCode")
                Case "N"
                Case "E"
                    MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                    Exit Sub
            End Select
        Else
            Me.BindToDataset(ds, "Data")
            Me.DataState = UI.DataStates.Retrieved

            ds = Me.ConvertToDataset

            If vTab = "UDR_APPLY" Then
                btnUDRSave.Enabled = True

                ds = MethodCallEx(Me, "YJIT.Biz.EchAccountExcelUpDown", "SearchUDR", {ds, "EXCEL"})

                Try
                    Dim drPairs As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
                    Select Case drPairs("TrxCode")
                        Case "Y"
                            Me.BindToDataset(ds, "Data")
                            Me.DataState = UI.DataStates.Retrieved

                            btnUDRSave.Enabled = True
                        Case "N"
                            MsgBoxLocalized(drPairs("TrxMsg"))
                            Call ClearView(AppliedRangeTypes.Only, {WG2})
                            Me.DataState = UI.DataStates.Retrieved
                        Case Else
                            MsgBoxLocalized(drPairs("TrxMsg"))
                    End Select
                Catch ex As Exception
                    MsgBoxLocalized(ex.Message)
                End Try
            End If
        End If

        MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Confirm", MessageBoxIcon.Information)
    End Sub

    Private Function PF_ImportExcel(ByVal PrmPathExcelFile As String) As DataSet
        Dim DtSet As DataSet
        Dim strExt As String
        Dim strConn As String

        Try
            ''''''' Fetch Data from Excel

            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            strExt = Mid(PrmPathExcelFile, InStrRev(PrmPathExcelFile, ".") + 1)
            If UCase(strExt) = "XLS" Then
                strConn = "provider=Microsoft.Jet.OLEDB.4.0; " & _
                            "data source='" & PrmPathExcelFile & " '; " & "Extended Properties=Excel 8.0;"
            Else
                strConn = "provider=Microsoft.ACE.OLEDB.12.0; " & _
                            "data source='" & PrmPathExcelFile & " '; " & "Extended Properties=Excel 12.0;"
            End If
            'MyConnection = New System.Data.OleDb.OleDbConnection(strConn)

            ' Select the data from Sheet1 of the workbook.
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", strConn)

            MyCommand.TableMappings.Add("Table", "ExcelData")

            DtSet = New System.Data.DataSet

            MyCommand.Fill(DtSet)
        Catch ex As Exception
            Throw ex
            DtSet = Nothing
        End Try

        '/// return dataset
        Return DtSet

    End Function

    Private Sub PS_SetReloadData(ByVal gridView As Object, ByVal vTab As String)
        Dim strCustoms4CD As String = gridView.GetRowCellValue(gridView.FocusedRowHandle, "CUSTOMS_4CODE").ToString
        Dim strYYYYMM As String = gridView.GetRowCellValue(gridView.FocusedRowHandle, "DOC_YYYYMM").ToString
        Dim strSndID As String = gridView.GetRowCellValue(gridView.FocusedRowHandle, "SND_ID").ToString

        Dim params() As Object = {strCustoms4CD, strYYYYMM, vTab, strSndID}

        Dim rtnDs As DataSet
        Dim rtnDr As DataRow

        Try
            rtnDs = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.EchAccountExcelUpDown", "ReloadCRMInfo", params, False)

            rtnDr = rtnDs.Tables("KEY_VALUE_PAIRS").Rows(0)

            If rtnDr("TrxCode") <> "Y" Then
                MsgBoxLocalized(rtnDr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                Exit Sub
            Else
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "CUST_CD", rtnDs.Tables("Data.ReLoad").Rows(0)("CUST_CD"))
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "CUST_LOC_NM", rtnDs.Tables("Data.ReLoad").Rows(0)("CUST_LOC_NM"))

                If vTab = "AFR" Then
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "CHAIN_HBL_COUNT", rtnDs.Tables("Data.ReLoad").Rows(0)("CHAIN_HBL_COUNT"))
                End If
            End If
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub PopUpInit()

        Dim PopUp As New PopupBase

        PopUp.ItemAdd(Action.Excel, "WG1_Excel", "&Excel Export")
        PopUp.PopUpInit(Me, WG1)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Excel, "WG2_Excel", "&Excel Export")
        PopUp.PopUpInit(Me, WG2)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Excel, "WG3_Excel", "&Excel Export")
        PopUp.PopUpInit(Me, WG3)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Excel, "WG4_Excel", "&Excel Export")
        PopUp.PopUpInit(Me, WG4)
    End Sub

#End Region

#Region "=================Control Events==========="

    Private Sub EchAccountExcelUpDown_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Common.DrawRowIndicator(GV2)
        Common.DrawRowIndicator(GV3)
        Common.DrawRowIndicator(GV1)
        Common.DrawRowIndicator(GV4)

        btnSave.Enabled = False
        btnUDRSave.Enabled = False
        btnApply.Enabled = False
        btnMFCSSave.Enabled = False
    End Sub

    Private Sub EchAccountExcelUpDown_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        PopUpInit()
    End Sub

    Private Sub GV1_CustomDrawRowIndicator(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs)
        Call SetGridViewSequence(e)
    End Sub

    Private Sub btnFile_Click(sender As System.Object, e As System.EventArgs) Handles btnFile.Click
        Call AFRExelUpLoad()
    End Sub

    Private Sub btnSearchAll_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchAll.Click
        If xtcKLNET.SelectedTabPage.Name = "xtpAFR" Then
            Call SearchData("AFR", "FIND")
        ElseIf xtcKLNET.SelectedTabPage.Name = "xtpMFCS" Then
            'MsgBoxLocalized("MFCS 작업중!!!!")
            Call SearchData("UDR", "FIND")
            Call SearchData("MFCS", "FIND")
        Else
            Call SearchData("ACCOUNT", "FIND")
        End If
    End Sub

    Private Sub GV2_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV2.CellValueChanged
        If e.Column.FieldName = "CUSTOMS_4CODE" Then
            If GV2.GetFocusedRowCellValue("CUSTOMS_4CODE") Is DBNull.Value OrElse String.IsNullOrEmpty(GV2.GetFocusedRowCellValue("CUSTOMS_4CODE")) Then Exit Sub

            Call PS_SetReloadData(sender, "AFR")
        End If
    End Sub

    Private Sub GV2_DataSourceChanged(sender As Object, e As System.EventArgs) Handles GV2.DataSourceChanged
        Dim view As GridView = TryCast(sender, GridView)

        If Not view.Columns("CUST_CD").ColumnType Is GetType(String) Then
            view.Columns("CUST_CD").DisplayFormat.FormatType = DevExpress.Utils.FormatType.None
        End If

        If Not view.Columns("CUST_LOC_NM").ColumnType Is GetType(String) Then
            view.Columns("CUST_LOC_NM").DisplayFormat.FormatType = DevExpress.Utils.FormatType.None
        End If

        If Not view.Columns("CHAIN_HBL_COUNT").ColumnType Is GetType(Integer) Then
            view.Columns("CHAIN_HBL_COUNT").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        End If
    End Sub

    Private Sub GV2_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GV2.RowStyle
        If Not GV2.GetRowCellValue(e.RowHandle, "BL_CNT_CK") Is DBNull.Value Then
            If Trim(GV2.GetRowCellValue(e.RowHandle, "BL_CNT_CK") & "") = "Y" Then
                e.Appearance.BackColor = System.Drawing.Color.MediumOrchid
            End If
        End If
    End Sub

    Private Sub btnUDRFile_Click(sender As Object, e As System.EventArgs) Handles btnUDRFile.Click
        Call UDFExelUpLoad()
    End Sub

    Private Sub btnMFCSFile_Click(sender As Object, e As System.EventArgs) Handles btnMFCSFile.Click
        Call MFCSACCExcelUpLoad()
    End Sub

    Private Sub GV3_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GV3.RowStyle
        'If Not GV3.GetRowCellValue(e.RowHandle, "SND_CK") Is DBNull.Value Then
        '    If Trim(GV3.GetRowCellValue(e.RowHandle, "SND_CK") & "") = "N" Then
        '        e.Appearance.BackColor = System.Drawing.Color.MediumOrchid
        '    End If
        'Else
        '    e.Appearance.BackColor = System.Drawing.Color.MediumOrchid
        'End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As System.EventArgs) Handles btnSave.Click
        Call SaveData("AFR")
    End Sub

    Private Sub btnUDRSave_Click(sender As System.Object, e As System.EventArgs) Handles btnUDRSave.Click
        Call SaveData("UDR")
    End Sub

    Private Sub btnMFCSSave_Click(sender As System.Object, e As System.EventArgs) Handles btnMFCSSave.Click
        Call SaveData("MFCS")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As System.EventArgs) Handles btnClear.Click
        Call ClearData()
    End Sub

    Private Sub btnApply_Click(sender As System.Object, e As System.EventArgs) Handles btnApply.Click
        Call SaveData("UDR_APPLY")

        Dim dr As DataRow

        For intRow As Integer = 0 To GV3.RowCount - 1
            dr = GV3.GetDataRow(intRow)
            dr.AcceptChanges()

            If GV3.GetDataRow(intRow).RowState = DataRowState.Unchanged Then
                GV3.GetDataRow(intRow).SetAdded()
            End If
        Next
    End Sub

    Private Sub GV1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV1.CellValueChanged
        If e.Column.FieldName = "CUSTOMS_4CODE" Then
            If GV1.GetFocusedRowCellValue("CUSTOMS_4CODE") Is DBNull.Value OrElse String.IsNullOrEmpty(GV1.GetFocusedRowCellValue("CUSTOMS_4CODE")) Then Exit Sub

            Call PS_SetReloadData(sender, "MFCS")
        End If
    End Sub
#End Region

End Class
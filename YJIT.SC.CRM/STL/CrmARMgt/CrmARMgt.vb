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

Public Class CrmARMgt

#Region "=================Data logic actions==========="
    Private Sub SearchData()
        Dim dsRet As New DataSet
        If INV_YMD.Text = "" Then
            MsgBoxLocalized("청구월은 필수입니다.")
            INV_YMD.Focus()
        End If
        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.CrmARMgt", "Search", Me.ConvertToDataset, AddressOf search_OnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Sub search_OnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)

        Try
            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Warning", MessageBoxIcon.Warning)
                Exit Sub
            End If
            Me.BindToDataset(ds, "Data")
            Me.DataState = UI.DataStates.Retrieved

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub


    Public Sub SendMail()
        'Dim sender As String = ClientSessionInfo.Email
        'Dim receiver As String = GV1.GetFocusedRowCellValue("TANM").ToString
        'Dim receiver As String = "ebkim@yjit.co.kr"

        Dim subject As String = "이메일 공문"
        Dim cc As String = ""
        Dim ds As DataSet

        Dim params As DataSet
        Dim dt As New DataTable

        Try
            params = Me.ConvertToDataset

            dt.Columns.Add("SENDER")

            Dim dr As DataRow = dt.NewRow
            dr("SENDER") = ClientSessionInfo.Email

            dt.Rows.Add(dr)
            dt.TableName = "SINFO"

            params.Tables.Add(dt)

            ' WG1에 선택한 데이터를 기준으로 메일로 보낼 HTML문서들을 만들어옴
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmARMgt", "SendMail", params)

            dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Warning", MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' 받아온 HTML문서를 보냄
            For Each fdr As DataRow In ds.Tables("Data.EMAILS").Rows

                Dim content As String = ""
                content = fdr("EMAIL").ToString

                Dim RtnDic As Dictionary(Of String, Object) = SendEmail(fdr("SENDER"), fdr("RECEIVER"), subject, cc, content)

                If RtnDic("TrxCode").ToString <> "Y" Then
                    MsgBoxLocalized(RtnDic("TrxMsg"))
                    Exit Sub
                End If
            Next
            MsgBoxLocalized("Send E-mail")
            Call SearchData()

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Public Sub InitData()
        INV_YMD.Text = Now.ToString("yyyyMM")
        INV_YMD.Focus()
    End Sub
    Public Sub PopUpInit()
        Dim PopUp As New PopupBase
        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Other, "WG1_SelectAll", "&Select All")
        PopUp.PopUpInit(Me, WG1)
    End Sub

    Public Sub PopUpOnAfterClick(ByVal Dr As DataRow)
        Dim Key As String = Dr("Key")
        Dim Sender As String = ""
        If Not Dr("Sender") Is System.DBNull.Value Then Sender = Dr("Sender")

        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing

        Select Case Dr("Action")
            Case Action.Other
                Select Case Key
                    Case "WG1_SelectAll"
                        'Call SelectAll("GV1")
                End Select

        End Select

    End Sub



    Private Sub GV1_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GV1.RowCellStyle

        If IsNumeric(e.CellValue) Then
            If e.CellValue < 0 Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If
    End Sub

#End Region
#Region "=================Control Events==========="
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub
    Private Sub CrmARMgt_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Call DrawRowIndicator({GV1})
        Call PopUpInit()
        Call InitData()
    End Sub
    Private Sub SEND_EMAIL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEND_EMAIL.Click
        Call SendMail()
    End Sub
#End Region

End Class
Public Class MdmGroupAuthCopy

    Public dt As DataTable = Nothing
    Public focusHandle As Integer = 0

#Region "=================Data logic actions==========="

    Public Sub ApplyData()

        If INS_TYPE.EditValue = "" Then
            MsgBoxLocalized("Select Insert Type", MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim ds As DataSet = Nothing
        Dim dr As DataRow = Nothing

        For i As Integer = 0 To GV2.RowCount - 1
            If GV2.GetRowCellValue(i, "CHK").ToString = "Y" Then
                Dim dataDs As DataSet = Me.ConvertToDataset
                dataDs.Tables("MAIN").Columns.Add("FM_GRP_ID")
                dataDs.Tables("MAIN").Columns.Add("TO_GRP_ID")
                dataDs.Tables("MAIN").Rows(0)("FM_GRP_ID") = GV1.GetFocusedRowCellValue("GRP_ID").ToString
                dataDs.Tables("MAIN").Rows(0)("TO_GRP_ID") = GV2.GetRowCellValue(i, "GRP_ID").ToString

                Try
                    ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MdmGroupAuth", "Apply", dataDs)
                Catch ex As Exception
                    MsgBoxLocalized(ex.Message)
                End Try

                dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

                If dr("TrxCode").ToString <> "Y" Then
                    MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                    Exit Sub
                End If
                MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Inforamtion", MessageBoxIcon.Information)
            End If
        Next

        Me.Close()

    End Sub

    Public Sub popUpInit()
        Dim popUp As New PopupBase
        popUp.ItemAdd(Action.Other, "SelectAll", "&Select All")
        popUp.PopUpInit(Me, WG2)
    End Sub

    Public Sub PopUpOnAfterClick(ByVal dr As DataRow)

        Dim Key As String = dr("KEY")
        Dim Sender As String = dr("Sender")

        Select Case dr("Action")
            Case Action.Other
                Select Case Key
                    Case "SelectAll"
                        Call SelectAll()
                End Select
        End Select

    End Sub

    Public Sub SelectAll()

        Dim firstRowChk As String = GV2.GetRowCellValue(0, "CHK")

        For i As Integer = 0 To GV2.RowCount - 1
            If firstRowChk = "N" Then
                GV2.SetRowCellValue(i, "CHK", "Y")
            Else
                GV2.SetRowCellValue(i, "CHK", "N")
            End If
        Next
    End Sub

#End Region

#Region "============Control events============"

    Private Sub btnApply_Click(sender As System.Object, e As System.EventArgs) Handles btnApply.Click
        Call ApplyData()
    End Sub

    Private Sub MdmGroupAuthCopy_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DrawRowIndicator({GV1, GV2})
        If Not IsNothing(dt) Then
            WG1.DataSource = dt.Copy
            Dim dt2 As DataTable = dt.Copy
            dt2.Columns.Add("CHK", GetType(String))
            For i As Integer = 0 To dt2.Rows.Count - 1
                dt2.Rows(i)("CHK") = "N"
            Next
            WG2.DataSource = dt2
        End If
        GV1.FocusedRowHandle = focusHandle
    End Sub

    Private Sub MdmGroupAuthCopy_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Call popUpInit()
    End Sub

#End Region


 
End Class

Imports DevExpress.XtraGrid.Views.Base

Public Class ComDashboard
    Private Function GetConvertToDataSet() As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)

            YJSql.SqlBox("WG1", "ComDashboard@TotalSearch", True)
            YJSql.Params("FM_YMD", drMAIN("S_FM_YMD").ToString)
            YJSql.Params("TO_YMD", drMAIN("S_TO_YMD").ToString)

            YJSql.SqlBox("WG2", "ComDashboard@SearchWorkType", True)
            YJSql.Params("FM_YMD", drMAIN("S_FM_YMD").ToString)
            YJSql.Params("TO_YMD", drMAIN("S_TO_YMD").ToString)

            YJSql.SqlBox("WG3", "ComDashboard@SearchDev", True)
            YJSql.Params("FM_YMD", drMAIN("S_FM_YMD").ToString)
            YJSql.Params("TO_YMD", drMAIN("S_TO_YMD").ToString)

            YJSql.SqlBox("WG4", "ComDashboard@SearchYear", True)
            YJSql.Params("YEAR", drMAIN("S_YEAR").ToString)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function
    Private Function GetConvertToDataSet2() As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)

            YJSql.SqlBox("WG4", "ComDashboard@SearchYear", True)
            YJSql.Params("YEAR", drMAIN("S_YEAR").ToString)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function
    Public Sub SearchData()
        Try
            If SearchValidate() = False Then Exit Sub

            Dim dsRet As DataSet = GetConvertToDataSet()

            dsRet = MethodCallEx(Me, "YJIT.Biz.ComDashboard", "Search", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"

                    Me.BindToDataset(dsRet, "Data")
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Public Sub SearchData2()
        Try
            If SearchValidate() = False Then Exit Sub

            Dim dsRet As DataSet = GetConvertToDataSet2()

            dsRet = MethodCallEx(Me, "YJIT.Biz.ComDashboard", "Search", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Me.BindToDataset(dsRet, "Data")
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing

        Try
            If String.IsNullOrEmpty(S_FM_YMD.Text.ToString) OrElse String.IsNullOrEmpty(S_TO_YMD.Text.ToString) OrElse String.IsNullOrEmpty(S_YEAR.Text.ToString) Then
                If ErrControl Is Nothing Then
                    If String.IsNullOrEmpty(S_TO_YMD.Text) Then
                        ErrControl = S_TO_YMD
                    ElseIf String.IsNullOrEmpty(S_FM_YMD.Text) Then
                        ErrControl = S_FM_YMD
                    ElseIf String.IsNullOrEmpty(S_YEAR.Text) Then
                        ErrControl = S_YEAR
                    End If
                End If
                ErrMsg &= "Please input Date! " & vbNewLine
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
    Private Sub SetDefault()
        S_FM_YMD.Text = New DateTime(Now.Year, 1, 1).ToString("yyyyMMdd")
        S_FM_YMD.DefVal = S_FM_YMD.Text
        S_TO_YMD.Text = Now.ToString("yyyyMMdd")
        S_TO_YMD.DefVal = S_TO_YMD.Text
        S_YEAR.Text = Now.ToString("yyyy")
    End Sub
    Private Sub ComDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call SetDefault()
        Call SearchData()
        Call SearchData2()
        Call DrawRowIndicator({GV3})
    End Sub

    Private Sub GV1_CustomDrawColumnHeader(sender As Object, e As DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs) Handles GV1.CustomDrawColumnHeader
        If Not e.Column Is Nothing Then
            e.Info.AllowColoring = True
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If Not String.IsNullOrEmpty(S_FM_YMD.Text) Then
            S_YEAR.Text = S_FM_YMD.Text
        End If
        Call SearchData()
    End Sub

    Private Sub btnSearch1_Click(sender As Object, e As EventArgs) Handles btnSearch1.Click
        Call SearchData2()
    End Sub
End Class
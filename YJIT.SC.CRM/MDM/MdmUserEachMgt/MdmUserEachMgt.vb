Imports System.Drawing
Public Class MdmUserEachMgt

#Region "===============Data Logic=================="

    Public Sub SaveData()
        If ValidateOfficeValue(Me) Then Exit Sub
        If Trim(PSWD.Text) <> Trim(PSWD1.Text) Then
            MsgBoxLocalized("New passwords do not match.")
            Exit Sub
        End If
        Try
            Call YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.MdmUserEachMgt", "Save", Me.ConvertToDataset, AddressOf SaveOnCompleted)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub SearchData()
        Dim strUserId As String = YJIT.SC.App.ClientSessionInfo.UserID
        Dim params As Object() = {strUserId}
        Try
            Call YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.MdmUserEachMgt", "Search", params, AddressOf SearchOnCompleted)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub SaveOnCompleted(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)

        Dim dsRet As DataSet = e.Result
        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        If drPairs("TrxCode") = "Y" Then
            Me.BindToDataset(dsRet, "Data")
            MsgBoxLocalized("Operation completed successfully!")
            SearchData()
        Else
            MsgBoxLocalized(drPairs("TrxMsg"))
        End If
    End Sub

    Private Sub SearchOnCompleted(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)

        Dim dsRet As DataSet = e.Result
        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        If drPairs("TrxCode") = "Y" Then
            Me.BindToDataset(dsRet, "Data")
        Else
            MsgBoxLocalized(drPairs("TrxMsg"))
            Exit Sub
        End If

        Me.DataState = UI.DataStates.Retrieved
    End Sub

#End Region

#Region "==================Control Event================="

    Private Sub btn_Save_Click(sender As System.Object, e As System.EventArgs) Handles btn_Save.Click
        SaveData()
    End Sub

    Private Sub MdmUserEachMgt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call SetMandatoryLine(Me)
        Call SearchData()
        If ClientSessionOfficeInfo.CountryCode <> "KR" Then
            Label11.Text = "The password is personal data (social security numbers, etc.) should not be included."
        End If
        If ClientSessionOfficeInfo.HqOfficeCode = "ENCHQ" Or ClientSessionOfficeInfo.HqOfficeCode = "LOHQ" Then
            Dim passStr As String = ""
            passStr = passStr & "암호설정 유의사항" & vbCrLf
            passStr = passStr & "1. 암호의 길이는 10자리여야 합니다." & vbCrLf
            passStr = passStr & "2. 대소문자를 한개 이상 입력 하셔야 합니다." & vbCrLf
            passStr = passStr & "3. 연속되는 문자를 사용 하실 수 없습니다." & vbCrLf
            passStr = passStr & "4. 영문, 숫자를 포함하여야 합니다." & vbCrLf
            passStr = passStr & "5. 개인 신상자료(주민등록번호 등)가 포함되지 않아야 합니다." & vbCrLf

            Label12.Text = passStr
            Label12.Location = New Point(60, 328)
            Label11.Visible = False
            Label12.Visible = True
        End If
    End Sub

#End Region

End Class
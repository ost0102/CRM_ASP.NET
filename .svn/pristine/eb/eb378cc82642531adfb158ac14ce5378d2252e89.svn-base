Public Class CodeServiceConnector
    ''' <summary>
    ''' Get the list code defined on the server CodeService
    ''' </summary>
    ''' <param name="codeId">ID (only) of code definition (e.g: Customer, Package...)</param>
    ''' <param name="searchParams">Collection of search key/value (same to what to be used on code method definition</param>
    ''' <param name="dataParams">Collection of data key/value (same to what to be used on code method definition</param>
    ''' <returns>A datatble of code returned data</returns>
    ''' <remarks>For reuse reason of code, this function is implemented</remarks>
    Public Function GetCodeList(ByVal codeId As String, ByVal searchParams As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object)) As DataTable
        Dim dsResult As DataSet
        Dim dsParams As New DataSet

        '========Check PreLoadCodeList (in order to speedup application)=============
        'Check if there is a Preloaded code list data (this will speedup SCView loading time)
        Dim sFullCodeId As String = codeId.Substring(codeId.LastIndexOf(".") + 1).Trim.ToUpper
        'Code Id must comes with DataParams (if have) to distinguise with others! E.g: Me.CodeType=YJIT.CodeService.CommonCode, Me.DataParams = "GroupCode:'A15',NameType:A"
        Dim sDataParams As String = ""
        For Each sKey As String In dataParams.Keys
            If sDataParams <> "" Then sDataParams &= ","
            sDataParams &= sKey & ":" & dataParams(sKey)
        Next
        sFullCodeId = (sFullCodeId & "@" & sDataParams).ToUpper



        If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing AndAlso _
           YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey(sFullCodeId) Then
            '=====If Preloaded => use directly, no need to connect to server        (=> SPEED UP performance)
            Return YJIT.SC.UI.SCView.PreloadedCodeListData(sFullCodeId).Copy
        Else
            '=====If not preloaded=> Must connect to server                         (=> SLOW performance)
            YJIT.SC.UI.SCControls.CodeBox.AddDict2ParamDataset(searchParams, dsParams, "SEARCH_KEY_VALUES")
            YJIT.SC.UI.SCControls.CodeBox.AddDict2ParamDataset(dataParams, dsParams, "DATA_PARAM_VALUES")
            'Additional
            'YJIT.SC.UI.SCControls.CodeBox.AddArray2ParamDataset({True, 1, 10, 10}, dsParams)
            YJIT.SC.UI.SCControls.CodeBox.AddArray2ParamDataset({True, 1, 20, 20}, dsParams)
            Try
                dsResult = WCF.WCFBiz.Instance.MethodCall("YJIT.CodeService." & codeId, "List", dsParams)
            Catch ex As Exception
                Throw New Exception("GetCodeList failed to call (YJIT.CodeService." & codeId & ")!", ex)
            End Try

            If dsResult Is Nothing Then
                Return Nothing
            Else
                If dsResult.Tables("Data.Table") IsNot Nothing Then             'Paging is not used
                    Return dsResult.Tables("Data.Table")
                ElseIf dsResult.Tables("Data.PAGE") IsNot Nothing Then          'PAGE is name of datable if the enablePaging = true
                    Return dsResult.Tables("Data.PAGE")
                Else
                    Return Nothing
                End If
            End If
        End If
    End Function
    Public Function GetCodeValidate(ByVal codeId As String, ByVal validateKeys As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object)) As DataTable
        Dim dsResult As DataSet
        Dim dsParams As New DataSet

        '========Check PreLoadCodeList (in order to speedup application)=============
        'Check if there is a Preloaded code list data (this will speedup SCView loading time)
        Dim sFullCodeId As String = codeId.Substring(codeId.LastIndexOf(".") + 1).Trim.ToUpper
        'Code Id must comes with DataParams (if have) to distinguise with others! E.g: Me.CodeType=YJIT.CodeService.CommonCode, Me.DataParams = "GroupCode:'A15',NameType:A"
        Dim sDataParams As String = ""
        For Each sKey As String In dataParams.Keys
            If sDataParams <> "" Then sDataParams &= ","
            sDataParams &= sKey & ":" & dataParams(sKey)
        Next
        sFullCodeId = (sFullCodeId & "@" & sDataParams).ToUpper



        If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing AndAlso _
           YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey(sFullCodeId) Then
            '=====If Preloaded => use directly, no need to connect to server        (=> SPEED UP performance)
            Return YJIT.SC.UI.SCView.PreloadedCodeListData(sFullCodeId).Copy
        Else
            '=====If not preloaded=> Must connect to server                         (=> SLOW performance)
            YJIT.SC.UI.SCControls.CodeBox.AddDict2ParamDataset(validateKeys, dsParams, "VALIDATE_KEY_VALUES")
            YJIT.SC.UI.SCControls.CodeBox.AddDict2ParamDataset(dataParams, dsParams, "DATA_PARAM_VALUES")
            Try
                dsResult = WCF.WCFBiz.Instance.MethodCall("YJIT.CodeService." & codeId, "Validate", dsParams)
            Catch ex As Exception
                Throw New Exception("GetCodeList failed to call (YJIT.CodeService." & codeId & ")!", ex)
            End Try

            If dsResult Is Nothing Then
                Return Nothing
            Else
                If dsResult.Tables("Data.Table") IsNot Nothing Then             'Paging is not used
                    Return dsResult.Tables("Data.Table")
                ElseIf dsResult.Tables("Data.PAGE") IsNot Nothing Then          'PAGE is name of datable if the enablePaging = true
                    Return dsResult.Tables("Data.PAGE")
                Else
                    Return Nothing
                End If
            End If
        End If
    End Function
End Class

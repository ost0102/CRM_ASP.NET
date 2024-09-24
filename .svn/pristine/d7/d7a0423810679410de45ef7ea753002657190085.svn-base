'Imports Microsoft.Samples
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports Newtonsoft.Json
'Imports YJIT.SC.App

Public Class Func
    Inherits YJIT.SC.UI.SCView
    '암호화, 복호화에 사용될 KEY
    Public Shared KEY As String = "yjit2020prime135792468101234567891024681013579"" "
    Public Shared KEY_128 As String = KEY.Substring(0, 128 / 8)
    Public Shared KEY_256 As String = KEY.Substring(0, 256 / 8)

    Public Shared KEY_RPA As String = "yjit2021rpa135792468101234567891024681013579"
    Public Shared KEY_128_RPA As String = KEY_RPA.Substring(0, 128 / 8)
    Public Shared KEY_256_RPA As String = KEY_RPA.Substring(0, 256 / 8)

    Public Shared KEY_FRND As String = "yjit2022frnd246810135791098765432197531108642"
    Public Shared KEY_128_FRND As String = KEY_FRND.Substring(0, 128 / 8)
    Public Shared KEY_256_FRND As String = KEY_FRND.Substring(0, 256 / 8)

    Public Shared Function MethodCall(ByRef FormObj As Object, ByRef controllerID As String, ByRef actionID As String, ByRef dsParams As DataSet, Optional ByVal MsgCaption As String = "") As DataSet
        Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm(MsgCaption, "잠시만 기다려주세요. 자료처리중입니다.")
            Try
                FormObj.Cursor = Cursors.WaitCursor
                Return YJIT.SC.WCF.WCFBiz.Instance.MethodCall(controllerID, actionID, dsParams)
            Catch ex As Exception
                FormObj.Cursor = Cursors.Default
                Throw New Exception(ex.Message & " (MethodCall)")
            Finally
                FormObj.Cursor = Cursors.Default
            End Try
        End Using
    End Function
    Public Shared Function MethodCall(ByRef FormObj As Object, ByRef controllerID As String, ByRef actionID As String, ByRef aParams() As Object, Optional ByVal MsgCaption As String = "") As DataSet
        Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm(MsgCaption, "잠시만 기다려주세요. 자료처리중입니다.")
            Try
                FormObj.Cursor = Cursors.WaitCursor
                Return YJIT.SC.WCF.WCFBiz.Instance.MethodCall(controllerID, actionID, aParams)
            Catch ex As Exception
                FormObj.Cursor = Cursors.Default
                Throw New Exception(ex.Message & " (MethodCall)")
            Finally
                FormObj.Cursor = Cursors.Default
            End Try
        End Using
    End Function

    ''' <summary>
    ''' NumericTextBox에 로컬화폐기준 소수점 적용 함수
    ''' </summary>
    ''' <param name="arrNumericTextBox">NumericTextBox를 배열로 입력 Call Func.SetNumericLocAmt({LOC_AMT, CHK_LOC_AMT})</param>
    ''' <remarks></remarks>
    Public Shared Sub SetNumericLocAmt(ByVal arrNumericTextBox() As UI.SCControls.NumericTextBox, Optional ByVal DecimalPoint As Integer = -1)
        Try
            For Each NumericTextBox In arrNumericTextBox
                If DecimalPoint = -1 Then DecimalPoint = ClientSessionOfficeInfo.DecimalPoint

                NumericTextBox.Format = "N" & DecimalPoint
                NumericTextBox.Text = 0
            Next
        Catch ex As Exception
            MsgBox(ex.Message & "(SetNumericLocAmt)")
        End Try
    End Sub


    ''' <summary>
    ''' Localized 적용하여 메세지 반환
    ''' </summary>
    ''' <param name="message">Password will be expired after {0}Days" 형태로 입력</param>
    ''' <param name="params">{0}항목에 표시한 내용을 입력합니다." 형태로 입력</param>
    ''' <remarks></remarks>
    Public Shared Function Msg(ByRef FormObj As Object, ByVal message As String, ByVal ParamArray params As Object()) As String
        Try
            message = FormObj.Localizer1.GetLocalizedString(message)

            For i = 0 To params.Count - 1
                message = message.Replace("{" & i & "}", FormObj.Localizer1.GetLocalizedString(params(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message & "(Msg)")
        End Try

        Return message
    End Function


    ''' <summary>
    ''' GetCodeServiceAPI 검색함수
    ''' </summary>
    ''' <param name="CodeType">"AccountCode"</param>
    ''' <param name="DataParams">"Type:'INS',Office:@OFFICE_CD" </param>
    ''' <param name="validateKeys">"KEY:#ACCT_CD"</param>
    ''' <remarks></remarks>
    Public Shared Function GetCodeValidate(ByVal CodeType As String, Optional ByVal DataParams As String = "", Optional ByVal validateKeys As String = "") As DataTable
        Dim dicValidateKeys As Dictionary(Of String, Object)
        Dim dicDataParams As Dictionary(Of String, Object)

        dicValidateKeys = GridFunc.GetStringToDictionary(validateKeys)
        dicDataParams = GridFunc.GetStringToDictionary(DataParams)

        Return Common.CodeServiceAPI.GetCodeValidate(CodeType, dicValidateKeys, dicDataParams)
    End Function


    ''' <summary>
    ''' Linq 사용시 datatable로 변환용
    ''' </summary>
    ''' <remarks>
    ''' Dim categories As System.Collections.Generic.IEnumerable(Of Object) -> Dim categories  형태로 사용해야함
    ''' </remarks>
    Public Shared Function LinqToDataTable(Of T)(source As IEnumerable(Of T)) As DataTable
        Dim properties As Reflection.PropertyInfo() = GetType(T).GetProperties()

        Dim output As New DataTable()

        For Each prop In properties
            output.Columns.Add(prop.Name, prop.PropertyType)
        Next

        For Each item In source
            Dim row As DataRow = output.NewRow()

            For Each prop In properties
                row(prop.Name) = prop.GetValue(item, Nothing)
            Next

            output.Rows.Add(row)
        Next

        Return output
    End Function

    '암호화 
    Public Shared Function encryptAES256(ByVal rtnStr As String) As String
        Try

            Dim rtnStrBytes() As Byte = Encoding.UTF8.GetBytes(rtnStr)
            Dim rm As RijndaelManaged = New RijndaelManaged()
            rm.Mode = CipherMode.CBC
            rm.Padding = PaddingMode.PKCS7
            rm.KeySize = 256

            Dim ms As MemoryStream = New MemoryStream()
            Dim encryptor As ICryptoTransform = rm.CreateEncryptor(Encoding.UTF8.GetBytes(KEY_256), Encoding.UTF8.GetBytes(KEY_128))
            Dim CryptoStream As CryptoStream = New CryptoStream(ms, encryptor, CryptoStreamMode.Write)
            CryptoStream.Write(rtnStrBytes, 0, rtnStrBytes.Length)
            CryptoStream.FlushFinalBlock()

            Dim encryptBytes() As Byte = ms.ToArray()
            Dim encryptString As String = Convert.ToBase64String(encryptBytes)

            CryptoStream.Close()
            ms.Close()

            Return encryptString
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    '복호화
    Public Shared Function decryptAES256(ByVal encrypt As String) As String
        Try
            Dim encryptBytes() As Byte = Convert.FromBase64String(encrypt)
            Dim rm As RijndaelManaged = New RijndaelManaged()
            rm.Mode = CipherMode.CBC
            rm.Padding = PaddingMode.PKCS7
            rm.KeySize = 256

            Dim ms As MemoryStream = New MemoryStream(encryptBytes)
            Dim decryptor As ICryptoTransform = rm.CreateDecryptor(Encoding.UTF8.GetBytes(KEY_256), Encoding.UTF8.GetBytes(KEY_128))
            Dim cryptoStream As CryptoStream = New CryptoStream(ms, decryptor, CryptoStreamMode.Read)

            Dim rtnStrBytes() As Byte = New Byte(encryptBytes.Length - 1) {}
            Dim rtnStrCount As Integer = cryptoStream.Read(rtnStrBytes, 0, rtnStrBytes.Length)
            Dim rtnStr As String = Encoding.UTF8.GetString(rtnStrBytes, 0, rtnStrCount)
            cryptoStream.Close()
            ms.Close()

            Return rtnStr
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    Public Shared Function encryptAES256_RPA(ByVal rtnStr As String) As String
        Try

            Dim rtnStrBytes() As Byte = Encoding.UTF8.GetBytes(rtnStr)
            Dim rm As RijndaelManaged = New RijndaelManaged()
            rm.Mode = CipherMode.CBC
            rm.Padding = PaddingMode.PKCS7
            rm.KeySize = 256

            Dim ms As MemoryStream = New MemoryStream()
            Dim encryptor As ICryptoTransform = rm.CreateEncryptor(Encoding.UTF8.GetBytes(KEY_256_RPA), Encoding.UTF8.GetBytes(KEY_128_RPA))
            Dim CryptoStream As CryptoStream = New CryptoStream(ms, encryptor, CryptoStreamMode.Write)
            CryptoStream.Write(rtnStrBytes, 0, rtnStrBytes.Length)
            CryptoStream.FlushFinalBlock()

            Dim encryptBytes() As Byte = ms.ToArray()
            Dim encryptString As String = Convert.ToBase64String(encryptBytes)

            CryptoStream.Close()
            ms.Close()

            Return encryptString
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    '복호화
    Public Shared Function decryptAES256_RPA(ByVal encrypt As String) As String
        Try
            Dim encryptBytes() As Byte = Convert.FromBase64String(encrypt)
            Dim rm As RijndaelManaged = New RijndaelManaged()
            rm.Mode = CipherMode.CBC
            rm.Padding = PaddingMode.PKCS7
            rm.KeySize = 256

            Dim ms As MemoryStream = New MemoryStream(encryptBytes)
            Dim decryptor As ICryptoTransform = rm.CreateDecryptor(Encoding.UTF8.GetBytes(KEY_256_RPA), Encoding.UTF8.GetBytes(KEY_128_RPA))
            Dim cryptoStream As CryptoStream = New CryptoStream(ms, decryptor, CryptoStreamMode.Read)

            Dim rtnStrBytes() As Byte = New Byte(encryptBytes.Length - 1) {}
            Dim rtnStrCount As Integer = cryptoStream.Read(rtnStrBytes, 0, rtnStrBytes.Length)
            Dim rtnStr As String = Encoding.UTF8.GetString(rtnStrBytes, 0, rtnStrCount)
            cryptoStream.Close()
            ms.Close()

            Return rtnStr
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function
    Public Shared Function encryptAES256_FRND(ByVal rtnStr As String) As String
        Try

            Dim rtnStrBytes() As Byte = Encoding.UTF8.GetBytes(rtnStr)
            Dim rm As RijndaelManaged = New RijndaelManaged()
            rm.Mode = CipherMode.CBC
            rm.Padding = PaddingMode.PKCS7
            rm.KeySize = 256

            Dim ms As MemoryStream = New MemoryStream()
            Dim encryptor As ICryptoTransform = rm.CreateEncryptor(Encoding.UTF8.GetBytes(KEY_256_FRND), Encoding.UTF8.GetBytes(KEY_128_FRND))
            Dim CryptoStream As CryptoStream = New CryptoStream(ms, encryptor, CryptoStreamMode.Write)
            CryptoStream.Write(rtnStrBytes, 0, rtnStrBytes.Length)
            CryptoStream.FlushFinalBlock()

            Dim encryptBytes() As Byte = ms.ToArray()
            Dim encryptString As String = Convert.ToBase64String(encryptBytes)

            CryptoStream.Close()
            ms.Close()

            Return encryptString
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    '복호화
    Public Shared Function decryptAES256_FRND(ByVal encrypt As String) As String
        Try
            Dim encryptBytes() As Byte = Convert.FromBase64String(encrypt)
            Dim rm As RijndaelManaged = New RijndaelManaged()
            rm.Mode = CipherMode.CBC
            rm.Padding = PaddingMode.PKCS7
            rm.KeySize = 256

            Dim ms As MemoryStream = New MemoryStream(encryptBytes)
            Dim decryptor As ICryptoTransform = rm.CreateDecryptor(Encoding.UTF8.GetBytes(KEY_256_FRND), Encoding.UTF8.GetBytes(KEY_128_FRND))
            Dim cryptoStream As CryptoStream = New CryptoStream(ms, decryptor, CryptoStreamMode.Read)

            Dim rtnStrBytes() As Byte = New Byte(encryptBytes.Length - 1) {}
            Dim rtnStrCount As Integer = cryptoStream.Read(rtnStrBytes, 0, rtnStrBytes.Length)
            Dim rtnStr As String = Encoding.UTF8.GetString(rtnStrBytes, 0, rtnStrCount)
            cryptoStream.Close()
            ms.Close()

            Return rtnStr
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    Public Shared Function JsonConvertSerializeObject(ByVal ht As Hashtable) As String
        Return JsonConvert.SerializeObject(ht)
    End Function

    'Public Shared Function MsgBoxLocalizedEx(ByRef FormObj As Object, _
    '                                  ByVal message As String, _
    '                         Optional ByVal buttons As System.Windows.Forms.MessageBoxButtons = MessageBoxButtons.OK, _
    '                         Optional ByVal caption As Object = "Alert", _
    '                         Optional ByVal icon As System.Windows.Forms.MessageBoxIcon = MessageBoxIcon.Information, _
    '                         Optional ByVal defaultButton As System.Windows.Forms.MessageBoxDefaultButton = MessageBoxDefaultButton.Button1) As Microsoft.VisualBasic.MsgBoxResult

    '    Return FormObj.MsgBoxLocalized(message, buttons, caption, icon, defaultButton) 'Protected -> Public 로 변경해야
    'End Function

    'Public Shared Function MsgBoxLocalizedEx(ByRef FormObj As Object, _
    '                                  ByVal message As String, _
    '                                  ByVal contentMsg As String, _
    '                         Optional ByVal buttons As System.Windows.Forms.MessageBoxButtons = MessageBoxButtons.OK, _
    '                         Optional ByVal caption As Object = "Alert", _
    '                         Optional ByVal icon As System.Windows.Forms.MessageBoxIcon = MessageBoxIcon.Information, _
    '                         Optional ByVal defaultButton As System.Windows.Forms.MessageBoxDefaultButton = MessageBoxDefaultButton.Button1) As Microsoft.VisualBasic.MsgBoxResult

    '    Return MsgBoxTaskDialog(FormObj, message, contentMsg, "", buttons, caption, icon, defaultButton)
    'End Function

    'Public Shared Function MsgBoxLocalizedEx(ByRef FormObj As Object, _
    '                                  ByVal message As String, _
    '                                  ByVal contentMsg As String, _
    '                                  ByVal ExpandedMsg As String, _
    '                         Optional ByVal buttons As System.Windows.Forms.MessageBoxButtons = MessageBoxButtons.OK, _
    '                         Optional ByVal caption As Object = "Alert", _
    '                         Optional ByVal icon As System.Windows.Forms.MessageBoxIcon = MessageBoxIcon.Information, _
    '                         Optional ByVal defaultButton As System.Windows.Forms.MessageBoxDefaultButton = MessageBoxDefaultButton.Button1) As Microsoft.VisualBasic.MsgBoxResult

    '    Return MsgBoxTaskDialog(FormObj, message, contentMsg, ExpandedMsg, buttons, caption, icon, defaultButton)
    'End Function

    'Public Function MsgBoxLocalizedEx(ByVal message As String, ByVal contentMsg As String, Optional ByVal buttons As System.Windows.Forms.MessageBoxButtons = MessageBoxButtons.OK, Optional ByVal caption As Object = "Alert", Optional ByVal icon As System.Windows.Forms.MessageBoxIcon = MessageBoxIcon.Information, Optional ByVal defaultButton As System.Windows.Forms.MessageBoxDefaultButton = MessageBoxDefaultButton.Button1) As Microsoft.VisualBasic.MsgBoxResult
    '    Return MsgBoxTaskDialog(message, contentMsg, "", buttons, caption, icon, defaultButton)
    'End Function

    '' ''' <summary>
    '' ''' Display a message based on the language setting of current running form
    '' ''' </summary>
    '' ''' <param name="message"></param>
    '' ''' <param name="buttons"></param>
    '' ''' <returns>Message box result</returns>
    '' ''' <remarks>If the current form is not localized (not contains any Localizer object), this will show the message ID itself</remarks>
    ''Public Function MsgBoxLocalizedEx(ByVal message As String, _
    ''                                  ByVal contentMsg As String, _
    ''                         Optional ByVal buttons As MessageBoxButtons = MessageBoxButtons.OK, _
    ''                         Optional ByVal caption As Object = Nothing, _
    ''                         Optional ByVal icon As System.Windows.Forms.MessageBoxIcon = MessageBoxIcon.Information, _
    ''                         Optional ByVal defaultButton As MessageBoxDefaultButton = MessageBoxDefaultButton.Button1) As MsgBoxResult

    ''    If caption Is Nothing Then caption = "Alert"
    ''    Dim sLocalizedCaption As String = ""
    ''    Dim sLocalizedMsg As String = ""

    ''    'Try to get localization verion
    ''    If Me.Localizer IsNot Nothing AndAlso Me.Localizer.ResourceManager IsNot Nothing Then
    ''        sLocalizedCaption = Trim("" & Me.Localizer.ResourceManager.GetString(caption))
    ''        sLocalizedMsg = Trim("" & Me.Localizer.ResourceManager.GetString(message))
    ''    End If

    ''    'If no localized version
    ''    If sLocalizedCaption = "" Then sLocalizedCaption = caption
    ''    If sLocalizedMsg = "" Then sLocalizedMsg = message
    ''    sLocalizedMsg &= vbCrLf & vbCrLf & "- " & contentMsg

    ''    Dim dlgResult As DialogResult

    ''    'Auto close msgbox after n seconds
    ''    Dim mySuccessTimer As New System.Windows.Forms.Timer
    ''    If YJIT.SC.UI.SCView.MsgBoxTimeout > 0 AndAlso YJIT.SC.UI.SCView.MsgBoxTimeoutKeyWords <> "" AndAlso buttons = MessageBoxButtons.OK Then
    ''        Dim isKeywordFound As Boolean = False
    ''        For Each sKey As String In YJIT.SC.UI.SCView.MsgBoxTimeoutKeyWords.Split(",")
    ''            If message.ToUpper.Contains(sKey.ToUpper) Then
    ''                isKeywordFound = True
    ''                Exit For
    ''            End If
    ''        Next
    ''        If isKeywordFound Then
    ''            mySuccessTimer.Interval = YJIT.SC.UI.SCView.MsgBoxTimeout * 1000  'mini seconds
    ''            AddHandler mySuccessTimer.Tick, AddressOf mySuccessTimerTick
    ''            mySuccessTimer.Start()
    ''        End If
    ''    End If

    ''    dlgResult = DevExpress.XtraEditors.XtraMessageBox.Show(sLocalizedMsg, sLocalizedCaption, buttons, icon, defaultButton)

    ''    mySuccessTimer.Stop() 'Stop this timer (not use anymore)
    ''    mySuccessTimer.Dispose()

    ''    Return dlgResult
    ''End Function
    ''Private Sub mySuccessTimerTick(ByVal sender As Object, ByVal e As EventArgs)
    ''    Try
    ''        SendKeys.SendWait("{Enter}")
    ''        CType(sender, System.Windows.Forms.Timer).Stop()
    ''    Catch ex As Exception
    ''        'not handle
    ''    End Try

    ''End Sub


    'Private Shared Function MsgBoxTaskDialog(ByRef FormObj As Object, ByVal message As String, ByVal contentMsg As String, ByVal ExpandedMsg As String, Optional ByVal buttons As System.Windows.Forms.MessageBoxButtons = MessageBoxButtons.OK, Optional ByVal caption As Object = "Alert", Optional ByVal icon As System.Windows.Forms.MessageBoxIcon = MessageBoxIcon.Information, Optional ByVal defaultButton As System.Windows.Forms.MessageBoxDefaultButton = MessageBoxDefaultButton.Button1) As Microsoft.VisualBasic.MsgBoxResult
    '    'Return MsgBoxLocalizedEx(message, buttons, caption, icon, defaultButton)

    '    Dim taskDialog As New TaskDialog() 'imports Microsoft.Samples
    '    taskDialog.WindowTitle = caption
    '    taskDialog.MainInstruction = message
    '    taskDialog.Content = contentMsg
    '    'taskDialog.Footer = "footerTextBox"
    '    taskDialog.ExpandedInformation = ExpandedMsg

    '    ' Common buttons
    '    Dim commonButtons As TaskDialogCommonButtons = 0
    '    'If Me.okCheckBox.Checked Then
    '    commonButtons = commonButtons Or TaskDialogCommonButtons.Ok
    '    'End If
    '    'If Me.yesCheckBox.Checked Then
    '    '    commonButtons = commonButtons Or TaskDialogCommonButtons.Yes
    '    'End If
    '    'If Me.NoCheckBox.Checked Then
    '    '    commonButtons = commonButtons Or TaskDialogCommonButtons.No
    '    'End If
    '    'If Me.cancelCheckBox.Checked Then
    '    '    commonButtons = commonButtons Or TaskDialogCommonButtons.Cancel
    '    'End If
    '    'If Me.retryCheckBox.Checked Then
    '    '    commonButtons = commonButtons Or TaskDialogCommonButtons.Retry
    '    'End If
    '    'If Me.closeCheckBox.Checked Then
    '    '    commonButtons = commonButtons Or TaskDialogCommonButtons.Close
    '    'End If
    '    'taskDialog.CommonButtons = commonButtons

    '    '' Custom Buttons
    '    'Dim customButtons As New List(Of TaskDialogButton)()
    '    'If Not String.IsNullOrEmpty(Me.buttonIDTextBox1.Text) AndAlso Not String.IsNullOrEmpty(Me.buttonTextBox1.Text) Then
    '    '    Try
    '    '        Dim button As New TaskDialogButton()
    '    '        button.ButtonId = Convert.ToInt32(Me.buttonIDTextBox1.Text, 10)
    '    '        button.ButtonText = Me.buttonTextBox1.Text
    '    '        customButtons.Add(button)
    '    '    Catch e1 As FormatException
    '    '    End Try
    '    'End If

    '    'If Not String.IsNullOrEmpty(Me.buttonIDTextBox2.Text) AndAlso Not String.IsNullOrEmpty(Me.buttonTextBox2.Text) Then
    '    '    Try
    '    '        Dim button As New TaskDialogButton()
    '    '        button.ButtonId = Convert.ToInt32(Me.buttonIDTextBox2.Text, 10)
    '    '        button.ButtonText = Me.buttonTextBox2.Text
    '    '        customButtons.Add(button)
    '    '    Catch e2 As FormatException
    '    '    End Try
    '    'End If

    '    'If Not String.IsNullOrEmpty(Me.buttonIDTextBox3.Text) AndAlso Not String.IsNullOrEmpty(Me.buttonTextBox3.Text) Then
    '    '    Try
    '    '        Dim button As New TaskDialogButton()
    '    '        button.ButtonId = Convert.ToInt32(Me.buttonIDTextBox3.Text, 10)
    '    '        button.ButtonText = Me.buttonTextBox3.Text
    '    '        customButtons.Add(button)
    '    '    Catch e3 As FormatException
    '    '    End Try
    '    'End If

    '    'If customButtons.Count > 0 Then
    '    '    taskDialog.Buttons = customButtons.ToArray()
    '    'End If

    '    '' DefaultButton
    '    'If Not String.IsNullOrEmpty(Me.defaultButtonTextBox.Text) Then
    '    '    Try
    '    '        taskDialog.DefaultButton = Convert.ToInt32(Me.defaultButtonTextBox.Text, 10)
    '    '    Catch e4 As FormatException
    '    '    End Try
    '    'End If

    '    '' Radio Buttons
    '    'Dim customRadioButtons As New List(Of TaskDialogButton)()
    '    'If Not String.IsNullOrEmpty(Me.radioButtonIDTextBox1.Text) AndAlso Not String.IsNullOrEmpty(Me.radioButtonTextBox1.Text) Then
    '    '    Try
    '    '        Dim button As New TaskDialogButton()
    '    '        button.ButtonId = Convert.ToInt32(Me.radioButtonIDTextBox1.Text, 10)
    '    '        button.ButtonText = Me.radioButtonTextBox1.Text
    '    '        customRadioButtons.Add(button)
    '    '    Catch e5 As FormatException
    '    '    End Try
    '    'End If

    '    'If Not String.IsNullOrEmpty(Me.radioButtonIDTextBox2.Text) AndAlso Not String.IsNullOrEmpty(Me.radioButtonTextBox2.Text) Then
    '    '    Try
    '    '        Dim button As New TaskDialogButton()
    '    '        button.ButtonId = Convert.ToInt32(Me.radioButtonIDTextBox2.Text, 10)
    '    '        button.ButtonText = Me.radioButtonTextBox2.Text
    '    '        customRadioButtons.Add(button)
    '    '    Catch e6 As FormatException
    '    '    End Try
    '    'End If

    '    'If Not String.IsNullOrEmpty(Me.radioButtonIDTextBox3.Text) AndAlso Not String.IsNullOrEmpty(Me.radioButtonTextBox3.Text) Then
    '    '    Try
    '    '        Dim button As New TaskDialogButton()
    '    '        button.ButtonId = Convert.ToInt32(Me.radioButtonIDTextBox3.Text, 10)
    '    '        button.ButtonText = Me.radioButtonTextBox3.Text
    '    '        customRadioButtons.Add(button)
    '    '    Catch e7 As FormatException
    '    '    End Try
    '    'End If

    '    'If customRadioButtons.Count > 0 Then
    '    '    taskDialog.RadioButtons = customRadioButtons.ToArray()
    '    'End If

    '    '' DefaultRadioButton
    '    'If Not String.IsNullOrEmpty(Me.defaultRadioButtonTextBox.Text) Then
    '    '    Try
    '    '        taskDialog.DefaultRadioButton = Convert.ToInt32(Me.defaultRadioButtonTextBox.Text, 10)
    '    '    Catch e8 As FormatException
    '    '    End Try
    '    'End If

    '    ' Main Icon
    '    Select Case icon
    '        Case MessageBoxIcon.Error
    '            taskDialog.MainIcon = TaskDialogIcon.Error
    '        Case MessageBoxIcon.None
    '            taskDialog.MainIcon = TaskDialogIcon.None
    '        Case MessageBoxIcon.Warning
    '            taskDialog.MainIcon = TaskDialogIcon.Warning
    '        Case Else 'MessageBoxIcon.Information, MessageBoxIcon.Stop, MessageBoxIcon.Question, MessageBoxIcon.Hand, MessageBoxIcon.Exclamation, MessageBoxIcon.Asterisk
    '            taskDialog.MainIcon = TaskDialogIcon.Information
    '    End Select





    '    'If Me.informationRadioButton.Checked Then
    '    '    taskDialog.MainIcon = TaskDialogIcon.Information
    '    'End If
    '    'If Me.warningRadioButton.Checked Then
    '    '    taskDialog.MainIcon = TaskDialogIcon.Warning
    '    'End If
    '    'If Me.errorRadioButton.Checked Then
    '    '    taskDialog.MainIcon = TaskDialogIcon.Error
    '    'End If
    '    'If Me.shieldRadioButton.Checked Then
    '    '    taskDialog.MainIcon = TaskDialogIcon.Shield
    '    'End If

    '    '' Footer Icon
    '    'If Me.footerIconInfo.Checked Then
    '    '    taskDialog.FooterIcon = TaskDialogIcon.Information
    '    'End If
    '    'If Me.footerIconWarning.Checked Then
    '    '    taskDialog.FooterIcon = TaskDialogIcon.Warning
    '    'End If
    '    'If Me.footerIconError.Checked Then
    '    '    taskDialog.FooterIcon = TaskDialogIcon.Error
    '    'End If
    '    'If Me.footerIconShield.Checked Then
    '    '    taskDialog.FooterIcon = TaskDialogIcon.Shield
    '    'End If

    '    'taskDialog.EnableHyperlinks = Me.enableHyperlinksCheckBox.Checked
    '    'taskDialog.ShowProgressBar = Me.showProgressBarCheckBox.Checked
    '    'taskDialog.AllowDialogCancellation = Me.allowCancelCheckBox.Checked
    '    'taskDialog.CallbackTimer = Me.progressWithTimerCheckBox.Checked
    '    'taskDialog.ExpandedByDefault = Me.expandedByDefaultCheckBox.Checked
    '    'taskDialog.ExpandFooterArea = Me.expandedFooterCheckBox.Checked
    '    'taskDialog.PositionRelativeToWindow = Me.positionRelativeToWindowCheckBox.Checked
    '    'taskDialog.RightToLeftLayout = Me.RightToLeftLayoutCheckbox.Checked
    '    'taskDialog.NoDefaultRadioButton = Me.NoDefaultRadioButtonCheckBox.Checked
    '    'taskDialog.CanBeMinimized = Me.CanBeMinimizedCheckBox.Checked
    '    'taskDialog.ShowMarqueeProgressBar = Me.showMarqueeCheckBox.Checked
    '    'taskDialog.UseCommandLinks = Me.UseCommandLinksCheckBox.Checked
    '    'taskDialog.UseCommandLinksNoIcon = Me.useCommandLinksNoIconCheckBox.Checked
    '    'taskDialog.VerificationText = Me.verficationFlagTextBox.Text
    '    'taskDialog.VerificationFlagChecked = Me.verifyFlagCheckBox.Checked
    '    'taskDialog.ExpandedControlText = Me.expandedControlTextBox.Text
    '    'taskDialog.CollapsedControlText = Me.collapsedControlTextBox.Text

    '    'taskDialog.Callback = New TaskDialogCallback(AddressOf Me.TaskDialogCallback)

    '    '
    '    ' Show the Dialog
    '    '
    '    Dim verification As Boolean = False
    '    Dim radioButtonResult As Integer = Nothing
    '    Dim result As DialogResult = CType(taskDialog.Show((If(taskDialog.CanBeMinimized, Nothing, FormObj)), verification, radioButtonResult), DialogResult)


    '    'MsgBoxLocalized("Button Selected: " & result.ToString() &
    '    ' "   Verification: " & (If(verification, "checked", "clear")) &
    '    ' "   Radio Button: " & radioButtonResult.ToString())

    '    Return result

    'End Function
End Class



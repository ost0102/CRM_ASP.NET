Module RegistryAPI


    Declare Function RegCreateKey Lib "advapi32.dll" Alias "RegCreateKeyA" (ByVal hKey As Long, ByVal lpSubKey As String, phkResult As Long) As Long
    Private Declare Function RegOpenKey Lib "advapi32.dll" Alias "RegOpenKeyA" (ByVal hKey As Long, ByVal lpSubKey As String, phkResult As Long) As Long
    Private Declare Function RegSetValueEx Lib "advapi32.dll" Alias "RegSetValueExA" (ByVal hKey As Long, ByVal lpValueName As String, ByVal Reserved As Long, ByVal dwType As Long, lpData As IntPtr, ByVal cbData As Long) As Long
    Private Declare Function RegQueryValueEx Lib "advapi32.dll" Alias "RegQueryValueExA" (ByVal hKey As Long, ByVal lpValueName As String, ByVal lpReserved As Long, lpType As Long, lpData As IntPtr, lpcbData As Long) As Long
    Private Declare Function RegCloseKey Lib "advapi32.dll" (ByVal hKey As Long) As Long

    Public Const HKEY_LOCAL_MACHINE = &H80000002
    Public Const HKEY_CURRENT_USER = &H80000001
    Public Const HKEY_CURRENT_CONFIG = &H80000005
    Public Const HKEY_CLASSES_ROOT = &H80000000
    Public Const HKEY_DYN_DATA = &H80000006
    Public Const HKEY_PERFORMANCE_DATA = &H80000004
    Public Const HKEY_USERS = &H80000003

    Public Sub SaveRegSetting(ByVal lKey As Long, ByVal sSubKey As String, ByVal sValue As String, ByVal vData As Object)
        'Save a string/Long Value to the Registry
        Dim lRegKey As Long
        Dim lType As Long
        Dim lData As Long
        Dim sData As String

        'Determine the type of Data being Saved
        lType = IIf(VarType(vData) = vbString, 1, 4)
        If lType = 4 Then
            'Long Data Type
            lData = vData
        Else
            'string Data Type
            sData = vData
        End If
        If RegCreateKey(lKey, sSubKey, lRegKey) = 0 Then
            'Open/Create the Registry Key
            If lType = 1 Then
                'Save the string Value to the Registry
                Call RegSetValueEx(lRegKey, sValue, 0&, lType, sData, Len(sData))
            Else
                'Save the Long Value to the Registry
                Call RegSetValueEx(lRegKey, sValue, 0&, lType, lData, 4)
            End If
            'Close the Registry Key
            Call RegCloseKey(lRegKey)
        End If
    End Sub

    Public Function GetRegSetting(ByVal lKey As Long, ByVal sSubKey As String, ByVal sValue As String) As Object
        'Retrieve a string/Long Value from the Registry
        Dim lRegKey As Long
        Dim lData As Long
        Dim sData As String
        Dim lType As Long

        'Open the Registry Key
        If RegOpenKey(lKey, sSubKey, lRegKey) = 0 Then
            'Find out the Data Type of the Value to Retrieve
            Call RegQueryValueEx(lRegKey, sValue, 0&, lType, 0&, 0&)
            sData = Space(255)
            If lType = 1 Then
                'Return a string Value
                Call RegQueryValueEx(lRegKey, sValue, 0&, lType, sData, Len(sData))
                If InStr(sData, Chr(0)) Then
                    sData = Left$(sData, InStr(sData, Chr(0)) - 1)
                End If
            Else
                'Return a Long Value
                Call RegQueryValueEx(lRegKey, sValue, 0&, lType, lData, 4)
            End If
            GetRegSetting = IIf(lType = 1, sData, lData)
            'Close the Registry Key
            Call RegCloseKey(lRegKey)
        End If
    End Function

End Module

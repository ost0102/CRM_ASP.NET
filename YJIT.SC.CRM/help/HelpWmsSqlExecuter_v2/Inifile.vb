﻿Public Class Inifile
    REM Got this from MattP in this forum
    REM http://www.vbdotnetforums.com/vb-net-general-discussion/45603-read-write-ini-file.html

    Private _Path As String

    Private Declare Ansi Function GetPrivateProfileString Lib "kernel32.dll" Alias "GetPrivateProfileStringA" _
        (ByVal lpApplicationName As String, _
         ByVal lpKeyName As String, _
         ByVal lpDefault As String, _
         ByVal lpReturnedString As System.Text.StringBuilder, _
         ByVal nSize As Integer, _
         ByVal lpFileName As String) _
     As Integer

    Private Declare Ansi Function WritePrivateProfileString Lib "kernel32.dll" Alias "WritePrivateProfileStringA" _
        (ByVal lpApplicationName As String, _
         ByVal lpKeyName As String, _
         ByVal lpString As String, _
         ByVal lpFileName As String) _
    As Integer


    ''' <summary>
    ''' IniFile Constructor
    ''' </summary>
    ''' <param name="IniPath">The path to the INI file.</param>
    Public Sub New(ByVal IniPath As String)

        If FileIO.FileSystem.FileExists(Application.StartupPath & "\SYSTEM\" & IniPath) Then
            _Path = Application.StartupPath & "\SYSTEM\" & IniPath
        Else
            _Path = Application.StartupPath & "\" & IniPath
        End If

        Dim path As String = _Path.Substring(0, _Path.LastIndexOf("\"))
        If Not FileIO.FileSystem.DirectoryExists(path) Then
            FileIO.FileSystem.CreateDirectory(path)
        End If
    End Sub

    ''' <summary>
    ''' Read value from INI file
    ''' </summary>
    ''' <param name="Group">The section of the file to look in</param>
    ''' <param name="key">The key in the section to look for</param>
    Public Function ReadValue(ByVal Group As String, ByVal key As String) As String
        Dim sb As New System.Text.StringBuilder(255)
        Dim i As Integer = GetPrivateProfileString(Group, key, "", sb, 255, _Path)
        Return sb.ToString()
    End Function

    ''' <summary>
    ''' Write value to INI file
    ''' </summary>
    ''' <param name="Group">The section of the file to write in</param>
    ''' <param name="key">The key in the section to write</param>
    ''' <param name="value">The value to write for the key</param>
    Public Sub WriteValue(ByVal Group As String, ByVal key As String, ByVal value As String)
        WritePrivateProfileString(Group, key, value, _Path)
    End Sub

End Class
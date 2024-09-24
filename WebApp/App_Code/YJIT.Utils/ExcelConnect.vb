Imports System
Imports System.Data

Namespace YJIT.Utils
    Public Class ExcelConnection
#Region "Public shared Function(s)"
        ''' <summary>
        ''' Read the Excel data into the dataset 
        ''' </summary>
        ''' <param name="PrmPathExcelFile"></param>
        ''' <param name="sSheetList">List of sheet name separated by comma</param>
        ''' <returns>DataSet which contains sheet data, each sheet is one datatable</returns>
        ''' <remarks></remarks>
        Public Shared Function ImportExcel(ByVal PrmPathExcelFile As String, Optional sSheetList As String = "Sheet1") As DataSet
            Dim dsRet As New DataSet
            Dim strExt As String
            Dim strConn As String
            Dim arrSheets() As String
            Dim sSheetName As String = ""

            Try
                ''''''' Fetch Data from Excel

                Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
                strExt = Mid(PrmPathExcelFile, InStrRev(PrmPathExcelFile, ".") + 1)
                If strExt.ToUpper = "XLS" Then
                    strConn = "provider=Microsoft.Jet.OLEDB.4.0; " & _
                                "data source='" & PrmPathExcelFile & " '; " & "Extended Properties=Excel 8.0;"
                Else  'XLSX
                    strConn = "provider=Microsoft.ACE.OLEDB.12.0; " & _
                                "data source='" & PrmPathExcelFile & " '; " & "Extended Properties=Excel 12.0;"
                End If

                'Get the list of sheets
                arrSheets = sSheetList.Split(",")
                For Each sSheetName In arrSheets
                    ' Select the data from current sheet of the workbook.
                    MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [" & sSheetName & "$]", strConn)
                    MyCommand.TableMappings.Add("Table", sSheetName)        'Name the datatable
                    MyCommand.Fill(dsRet)
                Next
            Catch ex As Exception
                Throw New Exception("Failed to get data from sheet & " & sSheetName & "!", ex)
                dsRet = Nothing
            End Try

            '/// return dataset
            Return dsRet
        End Function

#End Region
    End Class
End Namespace


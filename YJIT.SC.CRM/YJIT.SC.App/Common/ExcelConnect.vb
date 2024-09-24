Imports System
Imports ExcelDataReader
Imports System.IO

Public Class ExcelConnection
#Region "Public shared Function(s)"
    ''' <summary>
    ''' Read the Excel data into the dataset 
    ''' </summary>
    ''' <param name="PrmPathExcelFile"></param>
    ''' <param name="sSheetList">List of sheet name separated by comma</param>
    ''' <returns>DataSet which contains sheet data, each sheet is one datatable</returns>
    ''' <remarks></remarks>
    Public Shared Function ImportExcel(ByVal PrmPathExcelFile As String, Optional sSheetList As String = "") As DataSet
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

            'Get the list of sheet name
            If sSheetList = "" Then
                Dim con As New System.Data.OleDb.OleDbConnection(strConn)
                con.Open()
                Dim dtSheetTalbe = con.GetSchema("Tables")
                For Each dr As DataRow In dtSheetTalbe.Rows
                    If sSheetList <> "" Then sSheetList &= ","
                    sSheetList &= dr(2).ToString
                Next
            End If

            'Get the list of sheets
            arrSheets = sSheetList.Split(",")
            For Each sSheetName In arrSheets
                ' Select the data from current sheet of the workbook.
                MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [" & sSheetName & "]", strConn)
                MyCommand.TableMappings.Add("Table", sSheetName)        'Name the datatable
                Try
                    MyCommand.Fill(dsRet)
                Catch ex As Exception
                    'Some sheet may not be retrieved, we still continue
                End Try
            Next
        Catch ex As Exception
            MsgBox("Failed to get data from sheet & " & sSheetName & "!")
            dsRet = Nothing
        End Try

        '/// return dataset
        Return dsRet
    End Function

    ' 180510/길윤성/ExcelDataReader Open Source 사용 Excel Import 기능
    Public Shared Function ImportExcel2(ByVal PrmPathExcelFile As String, ByVal bUseHeaderRow As Boolean) As DataSet
        Dim DtSet As DataSet
        Dim filePath As String

        filePath = PrmPathExcelFile
        Dim tempLeng As New Integer
        Dim strExt As String

        strExt = Mid(PrmPathExcelFile, InStrRev(PrmPathExcelFile, ".") + 1)

        Using stream As FileStream = File.Open(filePath, FileMode.Open, FileAccess.Read)
            'Dim stream As FileStream = File.Open(filePath, FileMode.Open, FileAccess.Read)

            If UCase(strExt) = "XLS" Then

                Dim excelReader As IExcelDataReader = ExcelReaderFactory.CreateBinaryReader(stream)
                'Dim excelTableConf As ExcelDataTableConfiguration = New ExcelDataTableConfiguration
                'excelTableConf.UseHeaderRow = False
                Dim excelDsConf As ExcelDataSetConfiguration = New ExcelDataSetConfiguration()
                excelDsConf.ConfigureDataTable = Function() New ExcelDataTableConfiguration() With {
                .UseHeaderRow = bUseHeaderRow
                }
                DtSet = excelReader.AsDataSet(excelDsConf)
                'DtSet.Tables(0).TableName = "ExcelData"
            Else
                Dim excelReader As IExcelDataReader = ExcelReaderFactory.CreateOpenXmlReader(stream)
                'Dim excelTableConf As ExcelDataTableConfiguration = New ExcelDataTableConfiguration
                'excelTableConf.UseHeaderRow = False
                Dim excelDsConf As ExcelDataSetConfiguration = New ExcelDataSetConfiguration()
                excelDsConf.ConfigureDataTable = Function() New ExcelDataTableConfiguration() With {
                .UseHeaderRow = bUseHeaderRow
                }
                DtSet = excelReader.AsDataSet(excelDsConf)
                'DtSet.Tables(0).TableName = "ExcelData"
            End If
        End Using


        Return DtSet

    End Function
    ' 180510/길윤성/ExcelDataReader Open Source 사용 Excel Import 기능 (선택한 Sheet Import)
    Public Shared Function ImportExcel2(ByVal PrmPathExcelFile As String, ByVal sSheetList As String, ByVal bUseHeaderRow As Boolean) As DataSet
        Dim DtSet As DataSet
        Dim filePath As String
        Dim arrSheets() As String
        Dim sSheetName As String = ""
        Dim tempDtSet As DataSet

        filePath = PrmPathExcelFile
        Dim tempLeng As New Integer
        Dim strExt As String

        strExt = Mid(PrmPathExcelFile, InStrRev(PrmPathExcelFile, ".") + 1)

        Using stream As FileStream = File.Open(filePath, FileMode.Open, FileAccess.Read)
            'Dim stream As FileStream = File.Open(filePath, FileMode.Open, FileAccess.Read)

            If UCase(strExt) = "XLS" Then

                Dim excelReader As IExcelDataReader = ExcelReaderFactory.CreateBinaryReader(stream)
                'Dim excelTableConf As ExcelDataTableConfiguration = New ExcelDataTableConfiguration
                'excelTableConf.UseHeaderRow = False
                Dim excelDsConf As ExcelDataSetConfiguration = New ExcelDataSetConfiguration()
                excelDsConf.ConfigureDataTable = Function() New ExcelDataTableConfiguration() With {
                .UseHeaderRow = bUseHeaderRow
                }
                DtSet = excelReader.AsDataSet(excelDsConf)
            Else
                Dim excelReader As IExcelDataReader = ExcelReaderFactory.CreateOpenXmlReader(stream)
                'Dim excelTableConf As ExcelDataTableConfiguration = New ExcelDataTableConfiguration
                'excelTableConf.UseHeaderRow = False
                Dim excelDsConf As ExcelDataSetConfiguration = New ExcelDataSetConfiguration()
                excelDsConf.ConfigureDataTable = Function() New ExcelDataTableConfiguration() With {
                .UseHeaderRow = bUseHeaderRow
                }
                DtSet = excelReader.AsDataSet(excelDsConf)
            End If
        End Using

        If sSheetList = "" Then
            Return DtSet
        Else
            arrSheets = sSheetList.Split(",")
            tempDtSet = New DataSet
            For Each sSheetName In arrSheets
                tempDtSet.Tables.Add(DtSet.Tables(sSheetName).Copy)
            Next
            Return tempDtSet
        End If

        Return DtSet

    End Function

#End Region
End Class

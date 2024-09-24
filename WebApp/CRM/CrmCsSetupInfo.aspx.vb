Imports System.Data
Imports YJIT.Data
Imports System.Text
Imports System.Xml
Imports System.Security.Cryptography
Imports System.IO

Partial Class CrmCsSetupInfo
    Inherits System.Web.UI.Page

    Private Const WCF_DOWNLOAD_TEMP As String = "/WCF/UploadFiles/"
    ''암호화, 복호화에 사용될 KEY
    Public Shared KEY As String = "yjit2020prime135792468101234567891024681013579"" "
    Public Shared KEY_128 As String = KEY.Substring(0, 128 / 8)
    Public Shared KEY_256 As String = KEY.Substring(0, 256 / 8)

    Dim vPROC_TYPE As String = ""
    Dim vCUSTOMS_CD As String = ""
    Dim vREQ_USR As String = ""
    Dim vLOCATION As String = ""


    Private Function createDBDataTable(ByVal sUserID As String, ByVal sPassword As String) As DataSet
        Dim dtLoginInfo As DataTable = New DataTable()

        dtLoginInfo.Columns.Add("USERID", GetType(String))
        dtLoginInfo.Columns.Add("PASSWORD", GetType(String))

        dtLoginInfo.TableName = "WCF_CLIENT_INFO"
        dtLoginInfo.Rows.Add(sUserID, sPassword)

        Dim dsParams As DataSet = New DataSet()
        dsParams.Tables.Add(dtLoginInfo)

        Return dsParams
    End Function

    Private Function createDBTableKeyValuePairs(ByVal trxCode As String, ByVal trxMsg As String) As DataTable
        Dim dtKeyValuePairs As DataTable = New DataTable()

        dtKeyValuePairs.Columns.Add("TrxCode", GetType(String))
        dtKeyValuePairs.Columns.Add("TrxMsg", GetType(String))

        dtKeyValuePairs.TableName = "KEY_VALUE_PAIRS"
        dtKeyValuePairs.Rows.Add(trxCode, trxMsg)

        Return dtKeyValuePairs
    End Function

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        Dim BIZ As YJIT.WCF.BizService = New YJIT.WCF.BizService()
        BIZ.ExternalLogin(createDBDataTable("ADMIN", "YJIT"))
        Dim db As New YJIT.Data.DBA()

        vPROC_TYPE = Request("TYPE")
        vCUSTOMS_CD = Request("CUSTOMS")
        vREQ_USR = Request("USER")
        vLOCATION = Request("LOCATION")

        Dim sql As SqlBox
        Dim dt As DataTable = New DataTable
        Dim ResultDs As DataSet = New DataSet

        Try
            sql = New SqlBox("Common@SearchCsSetupInfo")
            sql.Params("CUSTOMS_CD") = vCUSTOMS_CD
            sql.Params("REQ_USR") = vREQ_USR
            sql.Params("CRYPTO_KEY") = "Yjit1!43#2^3"
            dt = db.SqlGet(sql.Text, False)
            dt.TableName = "CS_SETUP"
            ResultDs.Tables.Add(dt)

            If dt.Rows.Count = 0 Then
                ResultDs.Tables.Add(createDBTableKeyValuePairs("N", "Data Not Found!"))
                Exit Try
            End If

            If vPROC_TYPE = "B" Then
                sql = New SqlBox("Common@UpdateCsSetupInfo")
                sql.Params("CUSTOMS_CD") = vCUSTOMS_CD
                db.SqlSet(sql.Text)


                Dim MngtNo As String = String.Empty
                Dim i As Integer = 1
                Do While MngtNo = String.Empty
                    MngtNo = String.Format("{0}{1}", Format(Now, "yyyyMMddHHmmss"), Now.Millisecond)
                    '중복체크
                    sql = New SqlBox("CrmAsMgt_v4@SearchSaveCount")
                    sql.Params("MNGT_NO") = MngtNo
                    dt = db.SqlGet(sql.Text, False)

                    If dt.Rows.Count > 0 Then
                        MngtNo = ""
                        If i = 10 Then Exit Do
                    End If
                Loop

                sql = New SqlBox("CrmAsMgt_v4@Insert")
                sql.Params("MNGT_NO") = MngtNo                sql.Params("UPPER_MNGT_NO") = MngtNo                sql.Params("USR_ID") = "CSC"                sql.Params("SYS_ID") = "WEB" : sql.Blocks("SYS_ID") = True                sql.Params("ONLINE_YN") = "N" : sql.Blocks("ONLINE_YN") = True                sql.Params("REQ_YMD") = Now.Date.ToString("yyyyMMdd") : sql.Blocks("REQ_YMD") = True                sql.Params("REQ_HM") = Now.Date.ToString("HHmmss") : sql.Blocks("REQ_HM") = True                sql.Params("REQ_SVC") = "A" : sql.Blocks("REQ_SVC") = True                sql.Params("REQ_SVC2") = "A001" : sql.Blocks("REQ_SVC2") = True                sql.Params("CONTENT") = "업무프로그램 직접설치" & vbCrLf & "설치위치 : " & IIf(vLOCATION = "I", "본사설치", "외부설치") : sql.Blocks("CONTENT") = True                sql.Params("REQ_USR") = vREQ_USR : sql.Blocks("REQ_USR") = True                sql.Params("PROC_TYPE") = "2" : sql.Blocks("PROC_TYPE") = True                sql.Params("REQ_TYPE2") = "99" : sql.Blocks("REQ_TYPE2") = True                sql.Params("WORK_USR") = "솔루션운영팀" : sql.Blocks("WORK_USR") = True                sql.Params("CMPT_YMD") = Now.Date.ToString("yyyyMMdd") : sql.Blocks("CMPT_YMD") = True                sql.Params("CMPT_HM") = Now.Date.ToString("HHmmss") : sql.Blocks("CMPT_HM") = True                sql.Params("DEPT_CD") = "01" : sql.Blocks("DEPT_CD") = True                If ResultDs.Tables.Contains("CS_SETUP") AndAlso ResultDs.Tables("CS_SETUP").Rows.Count > 0 Then                    sql.Params("CUST_CD") = ResultDs.Tables("CS_SETUP").Rows(0)("CUST_CD").ToString : sql.Blocks("CUST_CD") = True                    sql.Params("TEL_NO") = ResultDs.Tables("CS_SETUP").Rows(0)("TEL_NO").ToString : sql.Blocks("TEL_NO") = True
                Else
                    sql.Params("CUST_CD") = "" : sql.Blocks("CUST_CD") = True                    sql.Params("TEL_NO") = "" : sql.Blocks("TEL_NO") = True
                End If                db.SqlSet(sql.Text)
            End If

            ResultDs.Tables.Add(createDBTableKeyValuePairs("Y", "Success"))
        Catch ex As Exception
            ResultDs.Tables.Add(createDBTableKeyValuePairs("E", ex.Message))
        End Try


        For Each row As DataRow In ResultDs.Tables("CS_SETUP").Rows
            For Each col As DataColumn In row.Table.Columns
                row(col.ColumnName) = encryptAES256(row(col.ColumnName).ToString)
            Next
        Next


        Dim FilePath As String = Server.MapPath(WCF_DOWNLOAD_TEMP)
        Dim FileName As String = ""
        FileName = String.Format("{0}{1}.xml", "CSSETUP_", vCUSTOMS_CD)

        If My.Computer.FileSystem.FileExists(FilePath & FileName) Then
            My.Computer.FileSystem.DeleteFile(FilePath & FileName)
        End If

        'CreateXml(FilePath & FileName, ResultDs)
        ResultDs.WriteXml(FilePath & FileName)

        'Dim DownPath As String = "C:\\ARAPXML\" & FileName
        Response.ClearContent()
        Response.Clear()
        Response.ContentType = FileName
        Response.AddHeader("Content-Disposition", "attachment; filename=" + FileName + ";")
        Response.WriteFile(FilePath & FileName)
        Response.Flush()
        Response.End()
        lblIP.Text = Request.UserHostAddress
    End Sub

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


    'Public Sub CreateXml(ByVal fileName As String, ByVal rtnDs As DataSet)
    '    Dim writer As New XmlTextWriter(fileName, System.Text.Encoding.UTF8)
    '    Dim contents As DataTable = Nothing
    '    Dim contentD As DataTable = Nothing
    '    contents = rtnDs.Tables("CS_SETUP").Copy

    '    writer.WriteStartDocument(True)
    '    writer.Formatting = Formatting.Indented
    '    writer.Indentation = 2
    '    writer.WriteStartElement("Report")
    '    writer.WriteStartAttribute("Crn")
    '    writer.WriteString(vCUSTOMS_CD)
    '    writer.WriteEndAttribute()

    '    writer.WriteStartElement("CsSetupInfo")
    '    writer.WriteStartElement("ArInfo")

    '    writer.WriteStartElement("SequenceNumber")
    '    writer.WriteString("1")
    '    writer.WriteEndElement()

    '    writer.WriteStartElement("Crn")
    '    writer.WriteString(contents.Rows.Item(0)("CRN").ToString)
    '    writer.WriteEndElement()

    '    writer.WriteEndElement()
    '    writer.WriteEndElement()

    '    writer.WriteEndElement()
    '    writer.WriteEndDocument()
    '    writer.Close()
    'End Sub

End Class

Imports System.Data
Imports YJIT.Data
Imports System.Text
Imports System.Xml

Partial Class CrmArInfo
    Inherits System.Web.UI.Page

    Private Const WCF_DOWNLOAD_TEMP As String = "/WCF/UploadFiles/"
    Dim vCRN As String = ""
    Public Function createDBDataTable(ByVal sUserID As String, ByVal sPassword As String) As DataSet

        Dim dtLoginInfo As DataTable = New DataTable()

        dtLoginInfo.Columns.Add("USERID")
        dtLoginInfo.Columns.Add("PASSWORD")

        dtLoginInfo.TableName = "WCF_CLIENT_INFO"
        dtLoginInfo.Rows.Add(sUserID, sPassword)

        Dim dsParams As DataSet = New DataSet()
        dsParams.Tables.Add(dtLoginInfo)

        Return dsParams

    End Function
    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        Dim BIZ As YJIT.WCF.BizService = New YJIT.WCF.BizService()
        BIZ.ExternalLogin(createDBDataTable("ADMIN", "YJIT"))
        Dim db As New YJIT.Data.DBA()

        vCRN = Request("CRN")

        Dim sql As SqlBox
        Dim dt As DataTable
        Dim ResultDs As DataSet = New DataSet

        sql = New SqlBox("CrmArMgt@Search")
        sql.Params("CRN") = vCRN
        sql.Blocks("CRN") = True
        dt = db.SqlGet(sql.Text, False)
        dt.TableName = "ARINFO"
        ResultDs.Tables.Add(dt)


        sql = New SqlBox("CrmArMgt@SearchCsNotice")
        sql.Params("CRN") = vCRN
        sql.Blocks("CRN") = True
        dt = db.SqlGet(sql.Text, False)
        dt.TableName = "CS_NOTICE"
        ResultDs.Tables.Add(dt)


        Dim FilePath As String = Server.MapPath(WCF_DOWNLOAD_TEMP)
        Dim FileName As String = ""
        FileName = String.Format("{0}{1}.xml", "ARINFO_", vCRN)

        If My.Computer.FileSystem.FileExists(FilePath & FileName) Then
            My.Computer.FileSystem.DeleteFile(FilePath & FileName)
        End If

        For Each EachDt As DataTable In ResultDs.Tables
            For Each row As DataRow In EachDt.Rows
                For Each col As DataColumn In row.Table.Columns
                    If String.IsNullOrEmpty(row(col.ColumnName).ToString) Then
                        Select Case col.DataType.ToString
                            Case "System.String"
                                row(col.ColumnName) = String.Empty
                            Case "System.Decimal"
                                row(col.ColumnName) = 0
                        End Select

                    End If
                Next
            Next
        Next


        'If ResultDs.Tables("ARINFO").Rows.Count > 0 Then
        'CreateXml(FilePath & FileName, ResultDs)
        '' CreateXml(FileName, dt, PRT_GB)
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
        'End If
    End Sub

    'Protected Sub btnSubmit_Click(sender As Object, e As System.EventArgs) Handles btnSubmit.Click
    '    ' Response.Redirect("/OMS/XmlARAP.aspx?HBL_NO=" + HBL_NO.Text + "&ETD=" + ETD.Text)
    'End Sub

    'Public Sub CreateXml(ByVal fileName As String, ByVal rtnDs As DataSet)
    '    Dim writer As New XmlTextWriter(fileName, System.Text.Encoding.UTF8)
    '    Dim contents As DataTable = Nothing
    '    Dim contentD As DataTable = Nothing
    '    contents = rtnDs.Tables("ARINFO").Copy

    '    writer.WriteStartDocument(True)
    '    writer.Formatting = Formatting.Indented
    '    writer.Indentation = 2
    '    writer.WriteStartElement("Report")
    '    writer.WriteStartAttribute("Crn")
    '    writer.WriteString(vCRN)
    '    writer.WriteEndAttribute()

    '    writer.WriteStartElement("CrmArInfo")
    '    writer.WriteStartElement("ArInfo")

    '    writer.WriteStartElement("SequenceNumber")
    '    writer.WriteString("1")
    '    writer.WriteEndElement()

    '    writer.WriteStartElement("Crn")
    '    writer.WriteString(contents.Rows.Item(0)("CRN").ToString)
    '    writer.WriteEndElement()

    '    writer.WriteStartElement("CustomerCode")
    '    writer.WriteString(contents.Rows.Item(0)("CUST_CD").ToString)
    '    writer.WriteEndElement()

    '    writer.WriteStartElement("CustomerName")
    '    writer.WriteString(contents.Rows.Item(0)("CUST_NM").ToString)
    '    writer.WriteEndElement()

    '    writer.WriteStartElement("InfoYn")
    '    writer.WriteString(contents.Rows.Item(0)("INFO_YN").ToString)
    '    writer.WriteEndElement()

    '    writer.WriteStartElement("InfoYmd")
    '    writer.WriteString(contents.Rows.Item(0)("INFO_YMD").ToString)
    '    writer.WriteEndElement()

    '    writer.WriteStartElement("StopYn")
    '    writer.WriteString(contents.Rows.Item(0)("STOP_YN").ToString)
    '    writer.WriteEndElement()

    '    writer.WriteStartElement("StopYmd")
    '    writer.WriteString(contents.Rows.Item(0)("STOP_YMD").ToString)
    '    writer.WriteEndElement()

    '    writer.WriteStartElement("OutstandingAmount")
    '    writer.WriteString(contents.Rows.Item(0)("OUTSTAND_AMT").ToString)
    '    writer.WriteEndElement()

    '    writer.WriteStartElement("P_BoardId")
    '    writer.WriteString(contents.Rows.Item(0)("P_BOARD_ID").ToString)
    '    writer.WriteEndElement()

    '    writer.WriteStartElement("P_StartDate")
    '    writer.WriteString(contents.Rows.Item(0)("P_STRT_YMD").ToString)
    '    writer.WriteEndElement()

    '    writer.WriteStartElement("P_EndDate")
    '    writer.WriteString(contents.Rows.Item(0)("P_EXP_YMD").ToString)
    '    writer.WriteEndElement()

    '    writer.WriteStartElement("E_BoardId")
    '    writer.WriteString(contents.Rows.Item(0)("E_BOARD_ID").ToString)
    '    writer.WriteEndElement()

    '    writer.WriteStartElement("E_StartDate")
    '    writer.WriteString(contents.Rows.Item(0)("E_STRT_YMD").ToString)
    '    writer.WriteEndElement()

    '    writer.WriteStartElement("E_EndDate")
    '    writer.WriteString(contents.Rows.Item(0)("E_EXP_YMD").ToString)
    '    writer.WriteEndElement()

    '    writer.WriteEndElement()
    '    writer.WriteEndElement()

    '    writer.WriteEndElement()
    '    writer.WriteEndDocument()
    '    writer.Close()
    'End Sub


    Private Sub createNode(ByVal SEQ As Double, ByVal STOP_YN As String, ByVal EXP_STOP_YMD As String, STOP_DELAY As String, ByVal OUTSTAND_AMT As Double, ByVal writer As XmlTextWriter)

    End Sub
End Class

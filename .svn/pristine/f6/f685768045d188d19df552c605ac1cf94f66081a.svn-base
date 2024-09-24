Imports System.Data
Imports YJIT.Data
Imports System.Text
Imports System.Xml

Partial Class XmlARAP
    Inherits System.Web.UI.Page

    Private Const WCF_DOWNLOAD_TEMP As String = "/WCF/UploadFiles/"
    Dim PRT_GB As String = ""
    Dim b_FM_DT As String = ""
    Dim b_TO_DT As String = ""
    Public Function createDBDataTable(ByVal sUserID As String, ByVal sPassword As String, ByVal sDomain As String) As DataSet

        Dim dtLoginInfo As DataTable = New DataTable()

        dtLoginInfo.Columns.Add("USERID")
        dtLoginInfo.Columns.Add("PASSWORD")
        dtLoginInfo.Columns.Add("DOMAIN")

        dtLoginInfo.TableName = "WCF_CLIENT_INFO"
        dtLoginInfo.Rows.Add(sUserID, sPassword, sDomain)

        Dim dsParams As DataSet = New DataSet()
        dsParams.Tables.Add(dtLoginInfo)

        Return dsParams

    End Function
    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        Dim BIZ As YJIT.WCF.BizService = New YJIT.WCF.BizService()
        BIZ.ExternalLogin(createDBDataTable("ADMIN", "ACTSHA", "ATC.ELVIS.COM"))
        Dim db As New YJIT.Data.DBA()

        PRT_GB = Request("PRT_OPTION")
        b_FM_DT = Request("FM_DT")
        b_TO_DT = Request("TO_DT")

        Dim sql As SqlBox
        Dim dt As DataTable
        Dim ResultDs As DataSet = New DataSet



        If PRT_GB = "S" Then
            sql = New SqlBox("WoSumMgt@Search_ARAP_SUM")
            sql.Params("FM_DT") = b_FM_DT
            sql.Params("TO_DT") = b_TO_DT
            sql.Params("PRT_OPTION") = PRT_GB
            sql.Blocks("SUM") = True
            dt = db.SqlGet(sql.Text, False)
            dt.TableName = "SUM"
            ResultDs.Tables.Add(dt)
        ElseIf PRT_GB = "D" Then
            sql = New SqlBox("WoSumMgt@Search_ARAP_DTL")
            sql.Params("FM_DT") = b_FM_DT
            sql.Params("TO_DT") = b_TO_DT
            sql.Params("PRT_OPTION") = PRT_GB
            sql.Blocks("DTL") = True
            dt = db.SqlGet(sql.Text, False)
            dt.TableName = "DTL"
            ResultDs.Tables.Add(dt)
        ElseIf PRT_GB = "LD" Then
            sql = New SqlBox("WoSumMgt@Search_LOC_ARAP_DTL")
            sql.Params("FM_DT") = b_FM_DT
            sql.Params("TO_DT") = b_TO_DT
            sql.Params("PRT_OPTION") = PRT_GB
            sql.Blocks("DTL") = True
            dt = db.SqlGet(sql.Text, False)
            dt.TableName = "LOCDTL"
            ResultDs.Tables.Add(dt)
        ElseIf PRT_GB = "LS" Then
            sql = New SqlBox("WoSumMgt@Search_LOC_ARAP_SUM")
            sql.Params("FM_DT") = b_FM_DT
            sql.Params("TO_DT") = b_TO_DT
            sql.Params("PRT_OPTION") = PRT_GB
            sql.Blocks("SUM") = True
            dt = db.SqlGet(sql.Text, False)
            dt.TableName = "LOCSUM"
            ResultDs.Tables.Add(dt)
        Else
            sql = New SqlBox("WoSumMgt@Search_ARAP_SUM")
            sql.Params("FM_DT") = b_FM_DT
            sql.Params("TO_DT") = b_TO_DT
            sql.Params("PRT_OPTION") = PRT_GB
            sql.Blocks("SUM") = True
            dt = db.SqlGet(sql.Text, False)
            dt.TableName = "SUM"
            ResultDs.Tables.Add(dt)


            sql = New SqlBox("WoSumMgt@Search_ARAP_DTL")
            sql.Params("FM_DT") = b_FM_DT
            sql.Params("TO_DT") = b_TO_DT
            sql.Params("PRT_OPTION") = PRT_GB
            sql.Blocks("DTL") = True
            dt = db.SqlGet(sql.Text, False)
            dt.TableName = "DTL"
            ResultDs.Tables.Add(dt)
        End If
      



        Dim FilePath As String = Server.MapPath(WCF_DOWNLOAD_TEMP)
        Dim FileName As String = ""
        If PRT_GB = "S" Then
            FileName = "ARAPSummary.xml"
        ElseIf PRT_GB = "D" Then
            FileName = "ARAPDetail.xml"
        ElseIf PRT_GB = "LD" Then
            FileName = "ARAPLocalDetail.xml"
        ElseIf PRT_GB = "LS" Then
            FileName = "ARAPLocalSummary.xml"
        Else
            FileName = "ARAPAll.xml"
        End If

        If My.Computer.FileSystem.FileExists(FilePath & FileName) Then
            My.Computer.FileSystem.DeleteFile(FilePath & FileName)
        End If

        If dt.Rows.Count > 0 Then


            CreateXml(FilePath & FileName, ResultDs, PRT_GB)
            ' CreateXml(FileName, dt, PRT_GB)
            Dim DownPath As String = "C:\\ARAPXML\" & FileName
            Response.ClearContent()
            Response.Clear()
            Response.ContentType = FileName
            Response.AddHeader("Content-Disposition", "attachment; filename=" + FileName + ";")
            Response.WriteFile(FilePath & FileName)
            Response.Flush()
            Response.End()
            lblIP.Text = Request.UserHostAddress
        End If


        'Dim FileName As String = ""
        'Dim Cfilename As String = ""
        'If PRT_GB = "S" Then
        '    FileName = Server.MapPath(WCF_DOWNLOAD_TEMP) & "ARAPSummary.xml"
        '    Cfilename = "ARAPSummary.xml"
        'ElseIf PRT_GB = "D" Then
        '    FileName = Server.MapPath(WCF_DOWNLOAD_TEMP) & "ARAPDetail.xml"
        '    Cfilename = "ARAPDetail.xml"
        'Else
        '    FileName = Server.MapPath(WCF_DOWNLOAD_TEMP) & "ARAPAll.xml"
        '    Cfilename = "ARAPAll.xml"
        'End If
        'If My.Computer.FileSystem.FileExists(FileName) Then
        '    My.Computer.FileSystem.DeleteFile(FileName)
        'End If
        ''Microsoft.VisualBasic.Shell("explorer " & start & FileName, AppWinStyle.NormalFocus)
        'If dt.Rows.Count > 0 Then
        '    CreateXml(FileName, dt, PRT_GB)
        '    Dim DownPath As String = "C:\\ARAPXML\" & Cfilename
        '    My.Computer.Network.DownloadFile _
        '                (FileName, DownPath)

        '    lblIP.Text = Request.UserHostAddress

        'End If

    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As System.EventArgs) Handles btnSubmit.Click
        ' Response.Redirect("/OMS/XmlARAP.aspx?HBL_NO=" + HBL_NO.Text + "&ETD=" + ETD.Text)
    End Sub

    'Public Function Search(ByVal HBL_NO As String, ByVal ETD As String) As DataTable
    '    Dim mainDt As DataTable
    '    Dim db As DBA = New DBA()

    '    Dim sql As New StringBuilder
    '    sql.Append("SELECT HBL_NO, MBL_NO, JOB_NO FROM FMS_HBL_MST WHERE 1 = 1")

    '    If HBL_NO.Trim <> "" Then
    '        sql.Append(" AND HBL_NO = '" & HBL_NO & "'")
    '    End If
    '    If ETD.Trim <> "" Then
    '        sql.Append(" AND ETD = '" & ETD & "'")
    '    End If


    '    If HBL_NO <> "" AndAlso ETD <> "" Then
    '        mainDt = db.SqlGet(sql.ToString, False)
    '    Else
    '        mainDt = New DataTable()
    '    End If

    '    Return mainDt
    'End Function

    Public Sub CreateXml(ByVal fileName As String, ByVal rtnDs As DataSet, ByVal PRT_GB As String)
        Dim writer As New XmlTextWriter(fileName, System.Text.Encoding.UTF8)
        Dim contents As DataTable = Nothing
        Dim contentD As DataTable = Nothing
        If PRT_GB = "S" Then
            contents = rtnDs.Tables("SUM").Copy
        ElseIf PRT_GB = "D" Then
            contentD = rtnDs.Tables("DTL").Copy
        ElseIf PRT_GB = "LD" Then

        ElseIf PRT_GB = "LS" Then

        Else
            contents = rtnDs.Tables("SUM").Copy
            contentD = rtnDs.Tables("DTL").Copy
        End If

        ' Dim contentD As DataTable = rtnDs.Tables("DTL").Copy

        writer.WriteStartDocument(True)
        writer.Formatting = Formatting.Indented
        writer.Indentation = 2
        writer.WriteStartElement("Report")
        writer.WriteStartAttribute("start")
        writer.WriteString(b_FM_DT)
        writer.WriteEndAttribute()
        writer.WriteStartAttribute("end")
        writer.WriteString(b_TO_DT)
        writer.WriteEndAttribute()
        If PRT_GB = "S" Then
            '####### SUMMARY ##################
            writer.WriteStartElement("Summary")
            Dim i As Double = 1
            For Each dr As DataRow In contents.Rows
                createNode_SUM(i, dr("REQ_SVC"), dr("BIZ_TYPE"), dr("WO_CNT"), dr("AR_AMT"), dr("AP_AMT"), writer)
                i = i + 1
            Next
            writer.WriteEndElement()
        ElseIf PRT_GB = "D" Then
            '####### Detail ##################
            writer.WriteStartElement("Detail")
            Dim i As Double = 1
            For Each dd As DataRow In contentD.Rows
                createNode_DTL(i, dd("REQ_SVC"), dd("BIZ_TYPE"), dd("WO_NO"), dd("AR_AMT"), dd("AP_AMT"), writer)
                i = i + 1
            Next
            writer.WriteEndElement()
        Else
            '####### SUMMARY ##################
            writer.WriteStartElement("Summary")
            Dim i As Double = 1
            For Each dr As DataRow In contents.Rows
                createNode_SUM(i, dr("REQ_SVC"), dr("BIZ_TYPE"), dr("WO_CNT"), dr("AR_AMT"), dr("AP_AMT"), writer)
                i = i + 1
            Next
            writer.WriteEndElement()

            '####### Detail ##################
            writer.WriteStartElement("Detail")
            i = 1
            For Each dd As DataRow In contentD.Rows
                createNode_DTL(i, dd("REQ_SVC"), dd("BIZ_TYPE"), dd("WO_NO"), dd("AR_AMT"), dd("AP_AMT"), writer)
                i = i + 1
            Next
            writer.WriteEndElement()
        End If

        writer.WriteEndElement()
        writer.WriteEndDocument()
        writer.Close()
    End Sub


    Private Sub createNode_SUM(ByVal SEQ As Double, ByVal REQ_SVC As String, ByVal BIZ_TYPE As String, WO_CNT As Double, ByVal AR_AMT As Double, ByVal AP_AMT As Double, ByVal writer As XmlTextWriter)
        writer.WriteStartElement("Department")

        writer.WriteStartElement("SequenceNumber")
        writer.WriteString(SEQ)
        writer.WriteEndElement()

        writer.WriteStartElement("TransportationType")
        writer.WriteString(REQ_SVC)
        writer.WriteEndElement()

        writer.WriteStartElement("BusinessType")
        writer.WriteString(BIZ_TYPE)
        writer.WriteEndElement()

        writer.WriteStartElement("WorkorderQuantity")
        writer.WriteString(WO_CNT)
        writer.WriteEndElement()

        writer.WriteStartElement("AccountsReceivable")
        writer.WriteString(AR_AMT)
        writer.WriteEndElement()

        writer.WriteStartElement("AccountsPayable")
        writer.WriteString(AP_AMT)
        writer.WriteEndElement()

        writer.WriteEndElement()
    End Sub
    Private Sub createNode_DTL(ByVal SEQ As Double, ByVal REQ_SVC As String, ByVal BIZ_TYPE As String, WO_NO As String, ByVal AR_AMT As Double, ByVal AP_AMT As Double, ByVal writer As XmlTextWriter)
        writer.WriteStartElement("Workorder")

        writer.WriteStartElement("SequenceNumber")
        writer.WriteString(SEQ)
        writer.WriteEndElement()

        writer.WriteStartElement("WorkorderNumber")
        writer.WriteString(WO_NO)
        writer.WriteEndElement()

        writer.WriteStartElement("TransportationType")
        writer.WriteString(REQ_SVC)
        writer.WriteEndElement()

        writer.WriteStartElement("BusinessType")
        writer.WriteString(BIZ_TYPE)
        writer.WriteEndElement()


        writer.WriteStartElement("AccountsReceivable")
        writer.WriteString(AR_AMT)
        writer.WriteEndElement()

        writer.WriteStartElement("AccountsPayable")
        writer.WriteString(AP_AMT)
        writer.WriteEndElement()

        writer.WriteEndElement()
    End Sub
End Class

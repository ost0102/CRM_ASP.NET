Imports System.Data
Imports YJIT.Data
Imports System.Text
Imports System.Xml

Partial Class UpdateCrm
    Inherits System.Web.UI.Page

    Private Const WCF_DOWNLOAD_TEMP As String = "/WCF/UploadFiles/"
    Dim b_CUST_CD As String = ""
    Dim b_CONTENT As String = ""
    Dim b_FM_YMD As String = ""
    Dim b_TO_YMD As String = ""
    Dim b_USR_NM As String = ""
    Dim b_TEL_NO As String = ""
    Dim b_MNGT_NO As String = ""
    Dim b_SYS_ID As String = ""
    Dim b_FORM_ID As String = ""
    Dim b_OFFICE_CD As String = ""
    Dim b_YMD As String = ""
    Dim b_HM As String = ""

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
        'BIZ.ExternalLogin(createDBDataTable("ADMIN", "ACTSHA", "ATC.ELVIS.COM"))

        Dim conntionString As String = String.Empty
        conntionString = "DATA SOURCE=" &
                                       "(DESCRIPTION=(CID=GTU_APP)" &
                                       "  (ADDRESS_LIST=" &
                                       "    (ADDRESS=" &
                                       "      (PROTOCOL=TCP)(HOST=110.45.209.36)(PORT=1521)" &
                                       "    )" &
                                       "  )" &
                                       "  (CONNECT_DATA=(SERVICE_NAME=ORCL)(SERVER=DEDICATED))" &
                                       ");USER ID=CRM;PASSWORD=CRM1202;"
        Dim db As New YJIT.Data.DBA(conntionString, "ORACLE")

        Try
            db.BeginTransaction()

            If Not String.IsNullOrEmpty(Request("CONTENT")) Then
                b_CUST_CD = Request("CUST_CD")  'CRM 거래처 코드
                b_CONTENT = Request("CONTENT")  '고객요청사항
                b_USR_NM = Request("USR_NM")    '요청자이름
                b_TEL_NO = Request("TEL_NO")    '요청자 연락처
                b_MNGT_NO = String.Format("{0}", Now.ToString("yyyyMMddHHmmssffffff"))  '관리번호 
                b_SYS_ID = "API"    'ELVIS에서 들어가면 ELVIS, 웹에서는 WEB으로 던짐.
                b_FORM_ID = "UpdateCrm"  '파라미터 던지는 화면 명 
                b_OFFICE_CD = Request("OFFICE_CD")  '지사 오피스 코드 (없어도 상관없음)

                Dim sql As String = String.Empty
                Dim dt As DataTable
                Dim ResultDs As DataSet = New DataSet


                sql = "BEGIN " & vbCrLf
                'sql &= " MERGE INTO CRM_AS_MST D " & vbCrLf
                'sql &= "    USING (SELECT '" & b_MNGT_NO & "' AS MNGT_NO " & vbCrLf
                'sql &= "                , '' AS USR_ID " & vbCrLf
                'sql &= "                , '" & b_SYS_ID & "' AS SYS_ID " & vbCrLf
                'sql &= "                , TO_CHAR(SYSDATE,'YYYYMMDD') AS USR_YMD " & vbCrLf
                'sql &= "                , TO_CHAR(SYSDATE,'HH24MISS') AS USR_HM " & vbCrLf
                'sql &= "             FROM DUAL) S " & vbCrLf
                'sql &= "       ON (D.MNGT_NO = S.MNGT_NO) " & vbCrLf
                'sql &= " WHEN MATCHED THEN " & vbCrLf
                'sql &= "      UPDATE SET D.UPD_USR = S.USR_ID" & vbCrLf
                'sql &= "               , D.UPD_YMD = S.USR_YMD" & vbCrLf
                'sql &= "               , D.UPD_HM = S.USR_HM" & vbCrLf
                'sql &= "               , D.CUST_CD = '" & b_CUST_CD & "'" & vbCrLf
                'sql &= "               , D.CONTENT = '" & b_CONTENT & "'" & vbCrLf
                'sql &= "               , D.REQ_USR = '" & b_USR_NM & "'" & vbCrLf
                'sql &= "               , D.TEL_NO = '" & b_TEL_NO & "'" & vbCrLf
                'sql &= " WHEN NOT MATCHED THEN" & vbCrLf
                'sql &= "      INSERT ( D.INS_USR	  , D.INS_YMD		  , D.INS_HM" & vbCrLf
                'sql &= "             , D.UPD_USR	  , D.UPD_YMD		  , D.UPD_HM" & vbCrLf
                'sql &= "             , D.REQ_YMD	  , D.REQ_HM                    " & vbCrLf
                'sql &= "             , D.SYS_ID	      , D.FORM_ID                   " & vbCrLf
                'sql &= "             , D.MNGT_NO	  , D.UPPER_MNGT_NO             " & vbCrLf
                'sql &= "             , D.CUST_CD	  , D.REQ_USR         , D.TEL_NO" & vbCrLf
                'sql &= "             , D.CONTENT                                    )" & vbCrLf
                'sql &= "     VALUES ( S.USR_ID	      , S.USR_YMD         ,	S.USR_HM" & vbCrLf
                'sql &= "            , S.USR_ID	      , S.USR_YMD         ,	S.USR_HM" & vbCrLf
                'sql &= "            , S.USR_YMD	      , S.USR_HM                    " & vbCrLf
                'sql &= "            , S.SYS_ID	      , '" & b_FORM_ID & "'                  " & vbCrLf
                'sql &= "            , '" & b_MNGT_NO & "'	      , '" & b_MNGT_NO & "'   " & vbCrLf
                'sql &= "            , '" & b_CUST_CD & "'	      , '" & b_USR_NM & "'	      , '" & b_TEL_NO & "'   " & vbCrLf
                'sql &= "            , '" & b_CONTENT & "'	);" & vbCrLf
                'sql &= "                                                            " & vbCrLf
                'sql &= " MERGE INTO CRM_AS_CUST D " & vbCrLf
                'sql &= "    USING (SELECT '" & b_OFFICE_CD & "' AS OFFICE_CD " & vbCrLf
                'sql &= "                , '" & b_MNGT_NO & "' AS MNGT_NO " & vbCrLf
                'sql &= "                , '" & b_USR_NM & "' AS USR_ID " & vbCrLf
                'sql &= "                , TO_CHAR(SYSDATE,'YYYYMMDD') AS USR_YMD " & vbCrLf
                'sql &= "                , TO_CHAR(SYSDATE,'HH24MISS') AS USR_HM " & vbCrLf
                'sql &= "             FROM DUAL) S " & vbCrLf
                'sql &= "       ON (D.OFFICE_CD = S.OFFICE_CD AND D.MNGT_NO = S.MNGT_NO)" & vbCrLf
                'sql &= " WHEN MATCHED THEN " & vbCrLf
                'sql &= "      UPDATE SET D.UPD_USR = S.USR_ID" & vbCrLf
                'sql &= "               , D.UPD_YMD = S.USR_YMD" & vbCrLf
                'sql &= "               , D.UPD_HM = S.USR_HM" & vbCrLf
                'sql &= "               , D.MNGT_NO = '" & b_MNGT_NO & "'" & vbCrLf
                'sql &= " WHEN NOT MATCHED THEN" & vbCrLf
                'sql &= "      INSERT ( D.INS_USR	  , D.INS_YMD		  , D.INS_HM" & vbCrLf
                'sql &= "             , D.UPD_USR	  , D.UPD_YMD		  , D.UPD_HM" & vbCrLf
                'sql &= "             , D.MNGT_NO                                    )" & vbCrLf
                'sql &= "     VALUES ( S.USR_ID	      , S.USR_YMD         ,	S.USR_HM" & vbCrLf
                'sql &= "            , S.USR_ID	      , S.USR_YMD         ,	S.USR_HM" & vbCrLf
                'sql &= "            , '" & b_MNGT_NO & "'	);" & vbCrLf

                sql &= "  INSERT INTO CRM_AS_MST D" & vbCrLf
                sql &= "             ( D.INS_USR	  , D.INS_YMD		  , D.INS_HM" & vbCrLf
                sql &= "             , D.UPD_USR	  , D.UPD_YMD		  , D.UPD_HM" & vbCrLf
                sql &= "             , D.REQ_YMD	  , D.REQ_HM                    " & vbCrLf
                sql &= "             , D.SYS_ID	      , D.FORM_ID                   " & vbCrLf
                sql &= "             , D.MNGT_NO	  , D.UPPER_MNGT_NO             " & vbCrLf
                sql &= "             , D.CUST_CD	  , D.REQ_USR         , D.TEL_NO" & vbCrLf
                sql &= "             , D.CONTENT                                    )" & vbCrLf
                sql &= "     VALUES ( '' 	                      , TO_CHAR(SYSDATE,'YYYYMMDD')         , TO_CHAR(SYSDATE,'HH24MISS')" & vbCrLf
                sql &= "            , ''	                      , TO_CHAR(SYSDATE,'YYYYMMDD')         , TO_CHAR(SYSDATE,'HH24MISS')" & vbCrLf
                sql &= "            , TO_CHAR(SYSDATE,'YYYYMMDD') , TO_CHAR(SYSDATE,'HH24MISS')         " & vbCrLf
                sql &= "            , '" & b_SYS_ID & "'	      , '" & b_FORM_ID & "'   " & vbCrLf
                sql &= "            , '" & b_MNGT_NO & "'	      , '" & b_MNGT_NO & "'   " & vbCrLf
                sql &= "            , '" & b_CUST_CD & "'	      , '" & b_USR_NM & "'	                , '" & b_TEL_NO & "'   " & vbCrLf
                sql &= "            , '" & b_CONTENT & "'	);" & vbCrLf

                sql &= " INSERT INTO CRM_AS_CUST D " & vbCrLf
                sql &= "             ( D.INS_USR	              , D.INS_YMD		        , D.INS_HM" & vbCrLf
                sql &= "             , D.UPD_USR	              , D.UPD_YMD		        , D.UPD_HM" & vbCrLf
                sql &= "             , D.MNGT_NO                                    )" & vbCrLf
                sql &= "     VALUES ( '' 	                      , TO_CHAR(SYSDATE,'YYYYMMDD')         , TO_CHAR(SYSDATE,'HH24MISS')" & vbCrLf
                sql &= "            , ''	                      , TO_CHAR(SYSDATE,'YYYYMMDD')         , TO_CHAR(SYSDATE,'HH24MISS')" & vbCrLf
                sql &= "            , '" & b_MNGT_NO & "'	);" & vbCrLf

                sql &= "END; "

                db.SqlSet(sql)

            End If

            db.Commit()
        Catch ex As Exception
            db.Rollback()
            lblMsg.Text = ex.Message
        Finally
            db.EndTransaction()
        End Try

    End Sub
End Class

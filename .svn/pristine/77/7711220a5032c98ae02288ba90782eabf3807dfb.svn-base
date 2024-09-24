Imports YJIT
Imports YJIT.Data
Imports System.Data

Partial Class WCF_Client_Setup
    Inherits YJIT.Web.UI.Page

    Private sServerSetupFile As String = "./Setup.exe"   'File URL on server
    Private sClientSetupFile As String = "SCSetup.exe"   'File name as download to client

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblResult.Text = ""

        If Request("Flag") = "GetSetupDomain" Then
            'If this page called by SmartClient Online Installer for knowing setup Domain => do this stuff
            Response.Write(getSetupDomain())
            Response.End()
        End If

        If IsPostBack Then
            Dim sMessage As String = ""
            DOMAIN.Text = DOMAIN.Text.Trim.ToUpper
            If validateDomain(DOMAIN.Text, sMessage) = False Then
                lblResult.Text = sMessage
            Else
                Dim db As New DBA
                'Domain exist => register a deploy record
                Dim sSql As String = "INSERT INTO SYS_DEPLOY_LOG(DOMAIN,DEPLOY_DATE,CLIENT_HOST_NM,CLIENT_HOST_ADDR,CLIENT_USER_NM) "
                sSql &= " VALUES ('" & DOMAIN.Text.Trim.ToUpper & "',SYSDATE,'" & Request.UserHostName & "','" & Request.UserHostAddress & "','" & Request.LogonUserIdentity.Name & "')"
                Try
                    db.SqlSet(sSql)

                    'Return the setup file
                    Call responseSetupFile()
                Catch ex As Exception
                    lblResult.Text = "ERROR:" & "Could not insert deloy record!" & ex.Message
                End Try
            End If
        End If
    End Sub

    Private Function validateDomain(ByVal sDomain As String, ByRef sMsg As String) As Boolean
        Dim sSql As String = "SELECT DOMAIN,USE_YN FROM SYS_CUST_MST WHERE UPPER(DOMAIN) = '" & sDomain & "'"
        Dim db As New DBA
        Dim dt As DataTable = db.SqlGet(sSql, False)
        If dt.Rows.Count = 0 Then
            sMsg = "Domain is not existed!"
            Return False
        ElseIf dt.Rows(0)("USE_YN") & "" <> "Y" Then
            sMsg = "Domain is not active!"
            Return False
        Else
            Return True
        End If
    End Function

    Private Function getSetupDomain() As String
        Dim sSql As String = "SELECT DOMAIN FROM SYS_DEPLOY_LOG WHERE " & _
                            " CLIENT_HOST_NM='" & Request.UserHostName & "' AND CLIENT_HOST_ADDR='" & Request.UserHostAddress & "' AND CLIENT_USER_NM = '" & Request.LogonUserIdentity.Name & "'" & _
                            " ORDER BY DEPLOY_DATE DESC"
        Dim db As New DBA
        Dim dt As DataTable = db.SqlGet(sSql, False)
        If dt.Rows.Count = 0 Then
            Return String.Empty 'No domain found
        Else
            'Get the most recent setup domain
            Return dt.Rows(0)("DOMAIN")
        End If

    End Function

    Private Sub responseSetupFile()
        If sServerSetupFile <> "" Then
            Dim path As String = Server.MapPath(sServerSetupFile)
            Dim file As New System.IO.FileInfo(path)
            If file.Exists Then
                Response.Clear()
                Response.AddHeader("Content-Disposition", "attachment; filename=" & sClientSetupFile)
                Response.AddHeader("Content-Length", file.Length.ToString())
                Response.ContentType = "application/octet-stream"
                Response.WriteFile(file.FullName)
                Response.End()
            Else
                lblResult.Text = "FAILED! The setup file does not exist! Please contact administrator!"
            End If
        End If
    End Sub

End Class

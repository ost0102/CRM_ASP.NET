#SystemSql@DomainList
    Select DOMAIN  
	,USR_ID 
	,USR_PWD 
	,NEW_CUST_YN   
	,DB_IP 
	,DB_PORT 
	,DB_SID 
	,CUST_NM 
             ,TO_CHAR(SYSDATE,'yy-mm-dd hh24:mi') AS UPDATETIME 
From SYS_CUST_MST  
#SystemSql@OfficeList
SELECT '@DOMAIN'  AS OFFICE_CD
          , '@OFFICE_NM' AS OFFICE_NM
          , '' AS UPPER_OFFICE_CD
FROM DUAL
UNION ALL
SELECT OFFICE_CD     AS OFFICE_CD
     ,   '[ '||ORG_LVL||' ] '||LOC_NM   AS OFFICE_NM 
     ,  CASE WHEN ORG_LVL = 'HQ' 
        THEN '@DOMAIN' 
         ELSE  UPPER_ORG_CD END  AS UPPER_OFFICE_CD
  FROM MDM_OFFICE_MST
 WHERE 1=1
#SystemSql@UserList
   SELECT USR_ID 
     , LOC_NM  
     , TEL_NO 
     , EMAIL
     , OFFICE_CD 
     , USE_YN   
     , LOGIN_FAIL_CNT 
     , CASE WHEN USR_ID  = '@LOGINID' 
                THEN  CASE WHEN PSWD = UNF_MD5_ENCRYPTION('@LOGINPASS')
                         THEN 'S'
                          ELSE 'F'
                          END 
                ELSE 'N'
       END CHK_PASS
  FROM MDM_USER_MST 
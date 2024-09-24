#HelpPswdReset@GetDBInfo
--HelpPswdReset@GetDBInfo
SELECT   DOMAIN          ,USR_ID         ,USR_PWD         ,NEW_CUST_YN           ,DB_IP         ,DB_PORT         ,DB_SID         ,CUST_NM         ,TO_CHAR(SYSDATE,'yy-mm-dd hh24:mi') AS UPDATETIME FROM SYS_CUST_MST@ELVIS

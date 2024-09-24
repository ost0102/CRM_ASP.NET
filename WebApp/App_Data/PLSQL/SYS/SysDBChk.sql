#SysDBChk@SearchDBList
--SysDBChk@SearchDBListSELECT 'N' AS CHK      ,'FALSE' AS ERROR_YN      ,A.USR_ID      ,A.USR_PWD       ,A.DB_IP      ,A.DB_PORT      ,A.DB_SID      ,A.CUST_NM      ,A.DOMAIN      ,'' AS RESULT      ,CASE WHEN B.SQL_ID IS NULL THEN 'N' ELSE 'Y' END AS APPLY_YN  FROM SYS_CUST_MST@@DB_LINK A        LEFT OUTER JOIN SYS_ALTER_TABLE_LOG B          ON B.DOMAIN = A.DOMAIN        AND B.SQL_ID = '@SQL_ID'WHERE 1=1  AND A.DATA_CHK = 'Y'  AND A.USE_YN = 'Y'  AND A.SVC_CD IN ('E','O','S','E21')
  AND A.NEW_CUST_YN = 'N'  [APPLY_SOURCE]  AND A.APPLY_SOURCE = '@APPLY_SOURCE'  [/APPLY_SOURCE]ORDER BY A.CUST_NM
#SysDBChk@SearchSQLList
--SysDBChk@SearchSQLList SELECT 'N' AS CHK      ,SQL_ID,TITLE      ,'' AS SQL_STR       ,APPLY_SOURCE      , (SELECT CD_NM FROM MDM_COM_CODE WHERE GRP_CD = 'H01' AND  COMN_CD =  APPLY_SOURCE) AS APPLY_SOURCE_NM      , '@DB_LINK' AS DB_LINK   FROM SYS_ALTER_TABLE WHERE SQL_TYPE = 'S'  [APPLY_SOURCE]   AND APPLY_SOURCE = '@APPLY_SOURCE' [/APPLY_SOURCE] ORDER BY SQL_ID DESC
#SysDBChk@ViewSQL
--SysDBChk@ViewSQLSELECT SQL_ID      ,TITLE      ,RMK      ,USE_YN      ,APPLY_SOURCE      ,SQL_STR  FROM SYS_ALTER_TABLE  WHERE SQL_TYPE = 'S'    AND SQL_ID = '@SQL_ID'

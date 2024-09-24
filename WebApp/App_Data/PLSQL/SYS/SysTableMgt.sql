#SysTableMgt@CheckLog
--SysTableMgt@CheckLogSELECT SQL_ID   FROM SYS_ALTER_TABLE_LOG WHERE SQL_ID = '@SQL_ID'
#SysTableMgt@CheckSql
--SysTableMgt@CheckSqlSELECT SQL_ID   FROM SYS_ALTER_TABLE WHERE SQL_ID = '@SQL_ID'
#SysTableMgt@CreateKey
-- SysTableMgt@CreateKeySELECT LPAD(NVL(MAX(SQL_ID),0)+1,6,'0') AS SQL_ID  FROM SYS_ALTER_TABLE 
#SysTableMgt@Insert
--SysTableMgt@InsertINSERT INTO SYS_ALTER_TABLE (	 SQL_ID   , SQL_TYPE   , INS_USR   , INS_YMD   , INS_HM) VALUES (     '@SQL_ID'   , 'S'   , '@INS_USR'   , '@INS_YMD'   , '@INS_HM' )
#SysTableMgt@Update
--SysTableMgt@UpdateUPDATE SYS_ALTER_TABLE   SET TITLE = '@TITLE'     , SQL_TYPE = '@SQL_TYPE'     , RMK = '@RMK'     , SQL_STR = :SQL_STR     , USE_YN = NVL('@USE_YN', 'Y')     , UPD_USR = '@UPD_USR'     , UPD_YMD = '@UPD_YMD'     , UPD_HM = '@UPD_HM'
     , APPLY_SOURCE = '@APPLY_SOURCE' WHERE SQL_ID = '@SQL_ID'

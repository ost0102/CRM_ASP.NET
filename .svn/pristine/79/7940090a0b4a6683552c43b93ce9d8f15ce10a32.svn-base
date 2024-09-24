#CrmBigAprMgt@Search
--CrmBigAprMgt@Search
WITH W_PRM_USR_DTL
AS
(
	SELECT * 
	  FROM ( SELECT USR_ID, 'COL_'||PAGE_CD AS PAGE_CD, PAGE_AUTH FROM PRM_USR_DTL )
	 PIVOT
	 (
	    MAX(PAGE_AUTH)
	    FOR PAGE_CD IN ('COL_LAT' AS COL_LAT
	                   ,'COL_SCH' AS COL_SCH
	                   ,'COL_SFI' AS COL_SFI
	                   ,'COL_TER' AS COL_TER
	                   ,'COL_TRK' AS COL_TRK
	                   ,'COL_UNI' AS COL_UNI
	                   )
	 )
)SELECT 'N' AS CHK      , A.CRN      , A.OFFICE_NM      , A.MNGT_NO      , A.OFFICE_ADDR      , A.HP_NO      , A.OFFICE_ADDR2      , A.OFFICE_ADDR_CD      , A.EMAIL      , A.APV_YN      , A.APV_YN AS DB_APV_YN      , TO_CHAR(TO_DATE(A.UPD_YMD,'yyyyMMdd'),'YYYY-MM-DD')||' '||TO_CHAR(TO_DATE(A.UPD_YMD,'yyyymmdd'), 'dd.Mon.YYYY','NLS_DATE_LANGUAGE = American') AS APV_YMD      , A.CRM_CD      , A.CRM_CD AS DB_CRM_CD      , A.EMAIL_MSG      , A.EMAIL_MSG AS DB_EMAIL_MSG      , A.FOR_CRN      , A.USR_ID      , A.PSWD      , A.INS_USR      , TO_CHAR(TO_DATE(A.INS_YMD,'yyyyMMdd'),'YYYY-MM-DD')||' '||TO_CHAR(TO_DATE(A.INS_YMD,'yyyymmdd'), 'dd.Mon.YYYY','NLS_DATE_LANGUAGE = American') AS INS_YMD
      , B.COL_LAT
      , B.COL_SCH
      , B.COL_SFI
      , B.COL_TER
      , B.COL_TRK
      , B.COL_UNI
      , B.COL_LAT AS DB_COL_LAT
      , B.COL_SCH AS DB_COL_SCH
      , B.COL_SFI AS DB_COL_SFI
      , B.COL_TER AS DB_COL_TER
      , B.COL_TRK AS DB_COL_TRK
      , B.COL_UNI AS DB_COL_UNI   FROM PRM_USR_MST A
        INNER JOIN W_PRM_USR_DTL B
                ON A.USR_ID = B.USR_ID  WHERE 1=1      [EMAIL]        AND A.EMAIL LIKE '%@EMAIL%'      [/EMAIL]      [APV_YN]        AND A.APV_YN LIKE '@APV_YN'      [/APV_YN]      [OFFICE_NM]        AND A.OFFICE_NM LIKE '%@OFFICE_NM%'      [/OFFICE_NM]      [CRN]        AND A.CRN LIKE '%@CRN%'      [/CRN] ORDER BY (CASE WHEN A.APV_YN = 'N' THEN 1 ELSE (CASE WHEN A.APV_YN = 'Y' THEN 2 ELSE 3 END) END), A.INS_YMD DESC, A.INS_HM DESC 
#CrmBigAprMgt@SearchEmail
--CrmBigAprMgt@SearchEmailSELECT A.CRN     , A.EMAIL     , A.APV_YN     , A.EMAIL_MSG     , (SELECT Z.CD_NM FROM MDM_COM_CODE Z WHERE Z.GRP_CD = 'R06' AND Z.COMN_CD = A.APV_YN) AS APV_YN_NM     , A.USR_ID     , A.PSWD     , A.OFFICE_NM AS CUST_NM
     , A.FOR_CRN     , '' AS RMK  FROM PRM_USR_MST A WHERE A.EMAIL IN ('@EMAIL')
#CrmBigAprMgt@Update
--CrmBigAprMgt@Update
BEGIN	UPDATE PRM_USR_MST	   SET CRM_CD = '@CRM_CD'	   [APV_YN]	     , APV_YN = '@APV_YN'	     , UPD_USR = '@SSL_USR_ID'	     , UPD_YMD = TO_CHAR(SYSDATE, 'YYYYMMDD')	     , UPD_HM = TO_CHAR(SYSDATE, 'HH24MISS')	   [/APV_YN]	 WHERE EMAIL = '@EMAIL';

	UPDATE PRM_USR_DTL SET PAGE_AUTH = '@COL_LAT' WHERE USR_ID = '@USR_ID' AND PAGE_CD = 'LAT';
	UPDATE PRM_USR_DTL SET PAGE_AUTH = '@COL_SCH' WHERE USR_ID = '@USR_ID' AND PAGE_CD = 'SCH';
	UPDATE PRM_USR_DTL SET PAGE_AUTH = '@COL_SFI' WHERE USR_ID = '@USR_ID' AND PAGE_CD = 'SFI';
	UPDATE PRM_USR_DTL SET PAGE_AUTH = '@COL_TER' WHERE USR_ID = '@USR_ID' AND PAGE_CD = 'TER';
	UPDATE PRM_USR_DTL SET PAGE_AUTH = '@COL_TRK' WHERE USR_ID = '@USR_ID' AND PAGE_CD = 'TRK';
	UPDATE PRM_USR_DTL SET PAGE_AUTH = '@COL_UNI' WHERE USR_ID = '@USR_ID' AND PAGE_CD = 'UNI';
END;

#ElvisChainSendList@Search
-- ElvisChainSendList@SearchSELECT A.M_SSNDRTPCODE      , B.CUST_LOC_NM AS M_SSNDRTPNAME     , TO_CHAR(A.M_DSENDTIME,'yyyy-MM-dd') AS M_DSENDTIME     , A.M_SDOCNAME   -- 문서코드      , A.M_SRCVRTPCODE     , A.M_STXID     , A.M_NTOSIZE     , 0 AS UNIT_PRC     , 0 AS AMOUNT  FROM TTXSTAT@ELVIS_CHAIN A        LEFT OUTER JOIN CRM_CUST_MST B         ON A.M_SSNDRTPCODE = B.CUSTOMS_CD        AND B.USE_YN = 'Y' WHERE A.M_SRCVRTPCODE IN (SELECT COMN_CD FROM MDM_COM_CODE WHERE GRP_CD ='Y03')   AND A.M_BSENDRESULT = 'T'    AND A.M_STXSTATUS = 'TS'   AND A.M_DSENDTIME >= TO_DATE('@FM_YMD','yyyyMMdd')   AND A.M_DSENDTIME < TO_DATE('@TO_YMD','yyyyMMdd')+1   [CUST_CD]      AND A.M_SSNDRTPCODE = '@CUST_CD'   [/CUST_CD]   [CUST_NM]      AND B.CUST_LOC_NME LIKE '@CUST_NM%'   [/CUST_NM]   [DOC_CD]      AND A.M_SDOCNAME = '@DOC_CD'   [/DOC_CD]    ORDER BY A.M_SSNDRTPCODE,A.M_DSENDTIME

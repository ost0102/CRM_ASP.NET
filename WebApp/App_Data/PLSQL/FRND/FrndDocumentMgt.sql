#FrndDocumentMgt@Search
--FrndDocumentMgt@SearchSELECT 'N' AS CHK      , A.MNGT_NO      , A.USR_ID      , A.USR_NM      , A.LOC_NM      , A.CRN      , A.LOC_ADDR      , A.BIZCOND      , A.BIZTYPE      , A.CEO      , A.HP_NO      , A.TEL_NO      , A.ENG_NM      , A.ENG_ADDR      , A.CTRY_CD      , A.CRM_CD      , A.APV_YN      , A.APV_YN AS DB_APV_YN      , A.AUTH_KEY       , A.AUTH_STRT_YMD       , A.AUTH_END_YMD      , A.INS_USR       , UFN_FORMAT(A.INS_YMD, 'DATE') AS INS_YMD      , A.UPD_USR       , UFN_FORMAT(A.UPD_YMD, 'DATE') AS UPD_YMD   FROM FRND_USR_MST A  WHERE 1=1    AND A.MAIN_YN = 'Y'      [S_APV_YN]        AND A.APV_YN LIKE '@S_APV_YN'      [/S_APV_YN]      [S_USR_ID]        AND A.USR_ID LIKE '%@S_USR_ID%'      [/S_USR_ID]      [S_USR_NM]        AND A.USR_NM LIKE '%@S_USR_NM%'      [/S_USR_NM]      [S_LOC_NM]        AND A.LOC_NM LIKE '%@S_LOC_NM%'      [/S_LOC_NM] ORDER BY (CASE WHEN A.APV_YN = 'N' THEN 1 ELSE (CASE WHEN A.APV_YN = 'Y' THEN 2 ELSE 3 END) END), A.INS_YMD DESC, A.INS_HM DESC 
#FrndDocumentMgt@SearchCrm
--FrndDocumentMgt@SearchCrmSELECT CUST_CD AS CRM_CD     , DOMAIN AS DOMAIN     , SETUP_URL AS SETUP_URL  FROM CRM_CUST_MST WHERE CUST_CD = '@CRM_CD'
#FrndDocumentMgt@SearchDoc
--FrndDocumentMgt@SearchDoc
SELECT FILE_NM
#FrndDocumentMgt@SearchEmail
--FrndDocumentMgt@SearchEmailSELECT A.CRN     , A.USR_ID     , A.APV_YN     , '승인 상태가 변경되었습니다' AS EMAIL_MSG     , (SELECT Z.CD_NM FROM MDM_COM_CODE Z WHERE Z.GRP_CD = 'R06' AND Z.COMN_CD = A.APV_YN) AS APV_YN_NM     , A.USR_ID AS ELVIS_USR_ID     , A.PSWD AS ELVIS_PSWD     , A.LOC_NM AS CUST_NM     , '' AS SVC_LIST     , '' AS SVC_TOT_AMT     , '' AS REG_DATE     , '' AS DOMAIN     , '' AS SETUP_URL     , '' AS RMK  FROM FRND_USR_MST A WHERE A.MNGT_NO IN ('@MNGT_NO')
#FrndDocumentMgt@Update
--FrndDocumentMgt@UpdateUPDATE FRND_USR_MST   SET APV_YN = '@APV_YN'
     , AUTH_KEY = '@AUTH_KEY'     , UPD_USR = '@USR_ID'     , UPD_YMD = TO_CHAR(SYSDATE, 'YYYYMMDD')     , UPD_HM = TO_CHAR(SYSDATE, 'HH24MISS') WHERE MNGT_NO = '@MNGT_NO'

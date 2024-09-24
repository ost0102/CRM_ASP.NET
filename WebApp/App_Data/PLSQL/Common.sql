#Common@CheckLayout
SELECT LAYOUT_NM  FROM CRM_LAYOUT_MSTWHERE       OFFICE_CD = '@OFFICE_CD'   AND   FORM_ID = '@FORM_ID'   AND LAYOUT_NM = '@LAYOUT_NM'  
#Common@DeleteLayout
DELETE CRM_LAYOUT_MSTWHERE  	OFFICE_CD = '@OFFICE_CD'	And   FORM_ID = '@FORM_ID'	And LAYOUT_NM = '@LAYOUT_NM'	
#Common@DeleteLayoutFromula
DELETE CRM_LAYOUT_DTLWHERE	    OFFICE_CD = '@OFFICE_CD'	And   FORM_ID = '@FORM_ID'	And LAYOUT_NM = '@LAYOUT_NM' 
#Common@GetBound
--Common@GetBoundSELECT BOUND      ,AUTH   FROM TABLE(UFN_GET_BOUND(                '@P_CTRY_CD'               ,'@P_REF_NO'               ,'@P_MH_TYPE'               ,'@P_POL'               ,'@P_POD'               ,'@P_OFFICE')        )	    
#Common@GetCurrUnit
--Common@GetCurrUnitSELECT NVL(MAX(CURR_UNIT),1)      AS CURR_UNIT   FROM MDM_EX_RATE WHERE OFFICE_CD = '@OFFICE_CD'   AND BASE_CURR = '@BASE_CURR'   AND   CURR_CD = '@CURR_CD' 
#Common@GetCustExRate
-- Common@GetCustExRateSELECT CURR_UNIT     , CASH_BUYRT     , CASH_SELLRT     , WIRE_SEND_EXRT     , WIRE_RECV_EXRT     , EXCH_BASERT  FROM (    -- Customer Ex.Rate    SELECT 'A'                      AS RATE_SEQ          , NVL(A.CURR_UNIT,1)       AS CURR_UNIT         , NVL(A.CASH_BUYRT,1)      AS CASH_BUYRT         , NVL(A.CASH_SELLRT,1)     AS CASH_SELLRT         , NVL(A.WIRE_SEND_EXRT,1)  AS WIRE_SEND_EXRT         , NVL(A.WIRE_RECV_EXRT,1)  AS WIRE_RECV_EXRT         , NVL(A.EXCH_BASERT,1)     AS EXCH_BASERT      FROM MDM_CUST_EX_RATE A     WHERE OFFICE_CD = '@OFFICE_CD'       AND BASE_CURR = '@BASE_CURR'       AND CUST_CD = '@CUST_CD'       AND CURR_CD = '@CURR_CD'       AND EXRT_YMD = '@EXRT_YMD'    UNION    -- Office Ex.Rate    SELECT 'B'                      AS RATE_SEQ          , NVL(A.CURR_UNIT,1)       AS CURR_UNIT         , NVL(A.CASH_BUYRT,1)      AS CASH_BUYRT         , NVL(A.CASH_SELLRT,1)     AS CASH_SELLRT         , NVL(A.WIRE_SEND_EXRT,1)  AS WIRE_SEND_EXRT         , NVL(A.WIRE_RECV_EXRT,1)  AS WIRE_RECV_EXRT         , NVL(A.EXCH_BASERT,1)     AS EXCH_BASERT      FROM MDM_CUST_EX_RATE A     WHERE OFFICE_CD = '@OFFICE_CD'       AND BASE_CURR = '@BASE_CURR'       AND CUST_CD = '@OFFICE_CD'       AND CURR_CD = '@CURR_CD'       AND EXRT_YMD = '@EXRT_YMD') WHERE ROWNUM  = 1
#Common@GetCustPicInfo
--Common@GetCustPicInfoSELECT LINE_NO AS CODE      ,'[' || LINE_NO || ']' || CUST_PIC_NM AS NAME  FROM MDM_CUST_PIC WHERE OFFICE_CD = '@OFFICE_CD'   AND CUST_CD = '@CUST_CD'   [DEPT_CD]      AND DEPT_CD = '@DEPT_CD'   [/DEPT_CD] ORDER BY LINE_NO
#Common@GetExRate
--Common@GetExRateSELECT NVL(A.CURR_UNIT,1)      AS CURR_UNIT      ,NVL(A.CASH_BUYRT,1)     AS CASH_BUYRT      ,NVL(A.CASH_SELLRT,1)    AS CASH_SELLRT      ,NVL(A.WIRE_SEND_EXRT,1) AS WIRE_SEND_EXRT      ,NVL(A.WIRE_RECV_EXRT,1) AS WIRE_RECV_EXRT      ,NVL(A.EXCH_BASERT,1)    AS EXCH_BASERT FROM MDM_EX_RATE AWHERE OFFICE_CD = '@OFFICE_CD'  AND BASE_CURR = '@BASE_CURR'  AND CURR_CD = '@CURR_CD'  AND EXRT_YMD = '@EXRT_YMD'
#Common@GetExRateClass
-- Common@GetExRateClassSELECT CASE WHEN '@SELL_BUY_TYPE' = 'L' THEN B.SELL_BASE            WHEN '@SELL_BUY_TYPE' = 'B' THEN B.BUY_BASE            WHEN '@SELL_BUY_TYPE' = 'F' THEN B.FRGN_BASE            ELSE 'A'       END AS EXRATE_CLASS  FROM MDM_OFFICE_BASE_EXRT B WHERE OFFICE_CD = '@OFFICE_CD'   AND SVC_CD = '@SVC_TYPE'
#Common@GetGroupCustomersInfo
--Common@GetGroupCustomersInfoSELECT CUST_CD AS CODE      ,'[' || CUST_CD || ']' || CUST_NM AS NAME      ,ENG_ADDR  FROM MDM_CUST_MST WHERE CUST_GRP_CD = '@CUST_GRP_CD'   AND USE_YN ='Y' ORDER BY CUST_CD
#Common@GetLayout
SELECT FORM_ID 	  ,LAYOUT_NM 	  ,LAYOUT   FROM CRM_LAYOUT_MSTWHERE       OFFICE_CD = '@OFFICE_CD'   AND   FORM_ID = '@FORM_ID'   AND LAYOUT_NM = '@LAYOUT_NM'
#Common@GetLayoutFormula
SELECT  OFFICE_CD 	   ,FORM_ID 	   ,LAYOUT_NM 	   ,CONTROL 	   ,FORMULA  FROM CRM_LAYOUT_DTLWHERE       OFFICE_CD = '@OFFICE_CD'   AND   FORM_ID = '@FORM_ID'   AND LAYOUT_NM = '@LAYOUT_NM'  
#Common@GetLayoutList
--Common@GetLayoutListSELECT ''                  AS CODE      ,'-- New --'         AS NAME  FROM DUAL  UNION ALLSELECT  CODE       ,NAME  FROM(		SELECT LAYOUT_NM   AS CODE		      ,LAYOUT_NM   AS NAME		  FROM CRM_LAYOUT_MST		 WHERE OFFICE_CD = '@OFFICE_CD'		   AND   FORM_ID = '@FORM_ID'		ORDER BY LAYOUT_NM		)
#Common@GetOfficeConfig
-- Common@GetOfficeConfigSELECT CASE WHEN MAX(ITEM_CD) IS NULL             THEN 'N'            ELSE 'Y'       END KEY_CD     , MAX(KEY_CD) AS KEY_VAL  FROM MDM_OFFICE_CONFIG WHERE OFFICE_CD = '@OFFICE_CD'   AND ITEM_CD = '@ITEM_CD'        
#Common@GetOfficeMandatory
 --Common@GetOfficeMandatory SELECT OFFICE_CD     , PGM_ID     , ITEM_CD     , ITEM_NM     , DFT_DAY FROM MDM_OFFICE_MANDWHERE OFFICE_CD  =  '@OFFICE_CD'  AND PGM_ID  =  '@PGM_ID'  --AND MAND_YN  =  'Y'
#Common@GetReqSvc2List
--Common@GetReqSvc2ListSELECT  COMN_CD AS CODE      , CD_NM AS NAME      , OPT_ITEM1 AS GRP_CD      , SORT  FROM MDM_COM_CODE WHERE GRP_CD = 'Z02'
#Common@GetSimpleCodeName
SELECT @COLNAME  FROM @TABLENAME WHERE @WHERESTR
#Common@InsertLayout
--Common@InsertLayOutINSERT INTO CRM_LAYOUT_MST(     OFFICE_CD     ,FORM_ID     ,LAYOUT_NM      ,INS_USR     ,INS_YMD     ,INS_HM     ,UPD_USR     ,UPD_YMD     ,UPD_HM)VALUES (     '@OFFICE_CD'     ,'@FORM_ID'     ,'@LAYOUT_NM'      ,'@INS_USR'     ,UFN_DATE_FORMAT('DATE')    ,UFN_DATE_FORMAT('TIME')     ,'@UPD_USR'     ,UFN_DATE_FORMAT('DATE')    ,UFN_DATE_FORMAT('TIME')) 
#Common@InsertLayoutFormula
 --Common@InsertLayoutFormula INSERT INTO CRM_LAYOUT_DTL(     OFFICE_CD     ,FORM_ID     ,LAYOUT_NM     ,CONTROL     ,FORMULA     ,INS_USR     ,INS_YMD     ,INS_HM)VALUES (     '@OFFICE_CD'     ,'@FORM_ID'     ,'@LAYOUT_NM'     ,'@CONTROL'     ,'@FORMULA'     ,'@INS_USR'     ,UFN_DATE_FORMAT('DATE')    ,UFN_DATE_FORMAT('TIME')     ) 
#Common@SearchCsSetupInfo
--Common@SearchCsSetupInfo / 암복호와시 TO_CHAR() 필수 SELECT TO_CHAR(A.CS_SETUP_KEY) AS CS_SETUP_KEY     , TO_CHAR(A.CS_SETUP_CNT) AS CS_SETUP_CNT     , TO_CHAR(A.CUST_CD) AS CUST_CD     , TO_CHAR(A.CUST_LOC_NM) AS CUST_LOC_NM     , TO_CHAR((SELECT TEL_NO FROM CRM_CUST_PIC WHERE ROWNUM = 1 AND PIC_NM = '@REQ_USR')) AS TEL_NO      , TO_CHAR(B.TNS_NM) AS TNS_NM     , TO_CHAR(B.USR_ID) AS USR_ID     , TO_CHAR(B.USR_PWD) AS USR_PWD     , TO_CHAR(B.DB_IP) AS DB_IP     , TO_CHAR(B.DB_IP_EXT) AS DB_IP_EXT     , TO_CHAR(B.DB_PORT) AS DB_PORT     , TO_CHAR(B.DB_SID) AS DB_SID  FROM CRM_CUST_MST A       LEFT OUTER JOIN SYS_CUST_MST@ELVIS B               ON A.CUST_CD = B.CUST_CD  WHERE A.CUSTOMS_CD = '@CUSTOMS_CD'
#Common@SearchKeyRule
-- Common@SearchKeyRuleSELECT RULE_CD  FROM MDM_KEY_NO_RULE WHERE OFFICE_CD = '@OFFICE_CD'   AND KEY_TYPE = '@KEY_TYPE'        
#Common@SearchOfficeConfig
--Common@SearchOfficeConfigSELECT *   FROM VT_OFFICE_CONFIG WHERE OFFICE_CD = '@OFFICE_CD'
#Common@SearchOfficeView
--Common@SearchOfficeViewSELECT *   FROM VT_OFFICE_CONFIG WHERE OFFICE_CD = '@OFFICE_CD'
#Common@SplitUpdateLayout
--Common@SplitUpdateLayOutUPDATE CRM_LAYOUT_MST   SET LAYOUT = LAYOUT || '@LAYOUT'  WHERE       OFFICE_CD = '@OFFICE_CD'  AND    FORM_ID = '@FORM_ID'  AND  LAYOUT_NM = '@LAYOUT_NM'   
#Common@UpdateCsSetupInfo
--Common@UpdateCsSetupInfoUPDATE CRM_CUST_MST   SET CS_SETUP_KEY = CASE WHEN CS_SETUP_CNT - 1 > 0                           THEN CS_SETUP_KEY                           ELSE UPPER(DBMS_RANDOM.STRING('A',3))||LPAD(TRUNC(DBMS_RANDOM.VALUE(10,999)),3,0)                      END     , CS_SETUP_CNT = CASE WHEN CS_SETUP_CNT - 1 > 0                           THEN CS_SETUP_CNT - 1                           ELSE USER_QTY                      END WHERE CUSTOMS_CD = '@CUSTOMS_CD'
#Common@UpdatetLayout
--Common@UpdatetLayOutUPDATE CRM_LAYOUT_MST   SET      LAYOUT   = NULL     ,UPD_USR  = '@UPD_USR'     ,UPD_YMD  = UFN_DATE_FORMAT('DATE')    ,UPD_HM   = UFN_DATE_FORMAT('TIME')WHERE        OFFICE_CD = '@OFFICE_CD'    AND   FORM_ID = '@FORM_ID'    AND LAYOUT_NM = '@LAYOUT_NM'      
#Common@UpdatetLayoutFormula
UPDATE CRM_LAYOUT_DTL   SET      FORMULA = '@FORMULA'      ,UPD_USR = '@UPD_USR'     ,UPD_YMD  = UFN_DATE_FORMAT('DATE')    ,UPD_HM   = UFN_DATE_FORMAT('TIME')WHERE          OFFICE_CD = '@OFFICE_CD'    AND     FORM_ID = '@FORM_ID'    AND   LAYOUT_NM = '@LAYOUT_NM'    AND     CONTROL = '@CONTROL'    

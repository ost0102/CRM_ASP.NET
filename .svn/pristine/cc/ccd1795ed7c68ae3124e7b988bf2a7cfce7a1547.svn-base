#AraMemberMgt@CrnValidate
-- AraMemberMgt@CrnValidate

SELECT *  FROM ARA_MEMB_MGT M WHERE M.BUSN_NO = '@BUSN_NO'
#AraMemberMgt@Insert
-- AraMemberMgt@Insert

	INSERT INTO ARA_MEMB_MGT			   ( CRM_CD	        , BUSN_NO	        , CUST_NM		, CEO	        , BIZ_TYPE			   , BIZ_COND		, ZIP_CD			, SUB_BD_NO	    , CUST_ADDR	    , ERP_LINK_SERVICE				   , MEMB_STATE	    , USE_START_DT		, USE_END_DT	, BASE_AMT      , BASE_ISSUE_CNT 
			   , PRICE          , INS_USR	        , INS_YMD       , INS_HM		, UPD_USR		
			   , UPD_YMD		, UPD_HM		) VALUES 
		       ( '@CRM_CD'		, '@BUSN_NO' 	    , '@CUST_NM'    , '@CEO'        , '@BIZ_TYPE'	
			   , '@BIZ_COND'	, '@ZIP_CD'		    , '@SUB_BD_NO'  , '@CUST_ADDR'	, '@ERP_LINK_SERVICE'
			   , '@MEMB_STATE'	, '@USE_START_DT'   , '@USE_END_DT'	, '@BASE_AMT'   , '@BASE_ISSUE_CNT'
			   , '@PRICE'       , '@USR_ID'		    , TO_CHAR(SYSDATE,'YYYYMMDD')	, TO_CHAR(SYSDATE,'HH24MISS')			   , '@USR_ID'		, TO_CHAR(SYSDATE,'YYYYMMDD')		    , TO_CHAR(SYSDATE,'HH24MISS')		)
#AraMemberMgt@SaveValidate
-- AraMemberMgt@SaveValidate

SELECT *  FROM ARA_MEMB_MGT M WHERE M.CRM_CD = '@CRM_CD'   AND M.BUSN_NO = '@BUSN_NO'
#AraMemberMgt@Search
-- AraMemberMgt@Search
SELECT M.CRM_CD
      ,M.CUST_NM
      ,M.BUSN_NO
     FROM ARA_MEMB_MGT M
    WHERE 1=1 
      [SEARCH_KEY]
          AND ( 1=2
          OR M.CRM_CD LIKE '%@SEARCH_KEY%'
          OR M.BUSN_NO LIKE REPLACE('%@SEARCH_KEY%', '-','')
          OR M.CUST_NM LIKE '%@SEARCH_KEY%'
         )
       [/SEARCH_KEY]
       [USE_YN]
          AND M.MEMB_STATE IN ('S','A','E',(CASE WHEN '@USE_YN' = 'Y' THEN 'C' ELSE '' END))
       [/USE_YN]
     ORDER BY M.CUST_NM
#AraMemberMgt@SearchCust
-- AraMemberMgt@SearchCust

SELECT A.CRN AS BUSN_NO
     , A.CUST_LOC_NM AS CUST_NM
     , A.CEO
     , A.BIZ_TYPE
     , A.BIZ_COND
     , A.ZIP_CD
     , A.CUST_ADDR
  FROM CRM_CUST_MST A
 WHERE A.CUST_CD = '@CRM_CD'
#AraMemberMgt@SearchDetail
-- AraMemberMgt@SearchDetail

SELECT M.CRM_CD
	 , M.BUSN_NO
	 , M.CUST_NM
	 , M.CEO
	 , M.BIZ_TYPE
	 , M.BIZ_COND
	 , M.ZIP_CD
	 , M.SUB_BD_NO
	 , M.CUST_ADDR
	 , M.ERP_LINK_SERVICE
	 , M.MEMB_STATE
	 , M.USE_START_DT
	 , M.USE_END_DT
	 , M.BASE_AMT
	 , M.BASE_ISSUE_CNT
	 , M.PRICE
	 , M.RMK
	FROM ARA_MEMB_MGT M
   WHERE M.CRM_CD = '@CRM_CD'
#AraMemberMgt@Update
-- AraMemberMgt@Update

   UPDATE ARA_MEMB_MGT
    SET  CUST_NM = '@CUST_NM'
       , CEO = '@CEO'
       , BIZ_TYPE = '@BIZ_TYPE'
       , BIZ_COND = '@BIZ_COND'
       , ZIP_CD = '@ZIP_CD'
       , SUB_BD_NO = '@SUB_BD_NO'
       , CUST_ADDR = '@CUST_ADDR'
       , ERP_LINK_SERVICE = '@ERP_LINK_SERVICE'
       , MEMB_STATE = '@MEMB_STATE'
       , USE_START_DT = '@USE_START_DT'
       , USE_END_DT = '@USE_END_DT'
       , BASE_AMT = '@BASE_AMT'
       , BASE_ISSUE_CNT = '@BASE_ISSUE_CNT'
       , PRICE = '@PRICE'
       , UPD_USR = '@USR_ID'
       , UPD_YMD = TO_CHAR(SYSDATE,'YYYYMMDD')
       , UPD_HM = TO_CHAR(SYSDATE,'HH24MISS')    	
     WHERE CRM_CD = '@CRM_CD'

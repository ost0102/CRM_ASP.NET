#CrmCustomizing@Delete
--CrmCustomizing@DeleteBEGIN
 
DELETE ELVIS_CUSTOMIZEWHERE CUST_CD = '@CUST_CD'     AND MNGT_NO = '@MNGT_NO';
DELETE ELVIS_CUSTOMIZE_ESTM WHERE CUST_CD = '@CUST_CD'     AND MNGT_NO = '@MNGT_NO';   
DELETE ELVIS_CUSTOMIZE_FUND WHERE CUST_CD = '@CUST_CD'     AND MNGT_NO = '@MNGT_NO';
   
DELETE ELVIS_CUSTOMIZE_ITEM WHERE CUST_CD = '@CUST_CD'     AND MNGT_NO = '@MNGT_NO';	
   END;  
#CrmCustomizing@DeleteEstm
--CrmCustomizing@DeleteEstmDELETE   FROM ELVIS_CUSTOMIZE_ESTM WHERE CUST_CD = '@CUST_CD'   AND SEQ     = '@SEQ'   AND MNGT_NO = '@MNGT_NO'
#CrmCustomizing@DeleteFund
--CrmCustomizing@DeleteFundDELETE   FROM ELVIS_CUSTOMIZE_FUND WHERE CUST_CD = '@CUST_CD'   AND SEQ     = '@SEQ'   AND MNGT_NO = '@MNGT_NO'
#CrmCustomizing@DeleteItem
--CrmCustomizing@DeleteItemDELETE   FROM ELVIS_CUSTOMIZE_ITEM WHERE CUST_CD = '@CUST_CD'   AND SEQ     = '@SEQ'   AND MNGT_NO = '@MNGT_NO'
#CrmCustomizing@DeleteList
--CrmCustomizing@DeleteListDELETE   FROM ELVIS_CUSTOMIZE WHERE CUST_CD = '@CUST_CD'   AND SEQ     = '@SEQ'   AND MNGT_NO = '@MNGT_NO'   
#CrmCustomizing@Insert
--CrmCustomizing@InsertINSERT INTO ELVIS_CUSTOMIZE (			CUST_CD		  , SEQ 		  , MNGT_NO   		  ,	CUSTOM_DTL    		  , CUSTOM_YMD          , REQUESTOR          , DOWN_PAY                  , DEVELOPER          , INS_USR     , INS_YMD     , INS_HM            , UPD_USR     , UPD_YMD     , UPD_HM          ) VALUES  ( 	         '@CUST_CD' 	       ,  (SELECT NVL(MAX(SEQ), 0) + 1 	 	        FROM ELVIS_CUSTOMIZE	 	       WHERE CUST_CD = '@CUST_CD')  	 	   , '@MNGT_NO'                 	       , '@CUSTOM_DTL' 	       , '@CUSTOM_YMD'		   , '@REQUESTOR'		   , '@DOWN_PAY'		 		   , '@DEVELOPER'				   , '@USR_ID'   , UFN_DATE_FORMAT('DATE')	, UFN_DATE_FORMAT('TIME')		   , '@USR_ID'   , UFN_DATE_FORMAT('DATE')	, UFN_DATE_FORMAT('TIME')   	     )
#CrmCustomizing@InsertEstm
--CrmCustomizing@InsertEstmINSERT INTO ELVIS_CUSTOMIZE_ESTM (			CUST_CD		  ,	SEQ		  , MNGT_NO          , ESTM_YMD     	  , ESTM_COST    	  , ESTM_RMK     	  , INS_USR     , INS_YMD     , INS_HM        	  , UPD_USR     , UPD_YMD     , UPD_HM      	 ) VALUES ( 		    '@CUST_CD'		  , (SELECT NVL(MAX(SEQ), 0) + 1 	 	       FROM ELVIS_CUSTOMIZE_ESTM 	 	      WHERE CUST_CD = '@CUST_CD' )  	 	  , '@MNGT_NO'  		  , '@ESTM_YMD'		  , '@ESTM_COST'		  , '@ESTM_RMK'					  , '@USR_ID'	, UFN_DATE_FORMAT('DATE')	, UFN_DATE_FORMAT('TIME')          , '@USR_ID'	, UFN_DATE_FORMAT('DATE')	, UFN_DATE_FORMAT('TIME')        )
#CrmCustomizing@InsertFund
--CrmCustomizing@InsertFundINSERT INTO ELVIS_CUSTOMIZE_FUND (  		    CUST_CD		  ,	SEQ		  , MNGT_NO          , FUND_ITEM           , ISSUED_YMD          , SALES_VAL                    , BUY_VAL 
          , FUND_RMK          , INS_USR		, INS_YMD	  , INS_HM          , UPD_USR     , UPD_YMD     , UPD_HM               		  )  VALUES (   			'@CUST_CD'		  ,  (SELECT NVL(MAX(SEQ), 0) + 1 	 	        FROM ELVIS_CUSTOMIZE_FUND 	 	       WHERE CUST_CD = '@CUST_CD' )	 	  , '@MNGT_NO'  	   	  , '@FUND_ITEM'		   	  ,	'@ISSUED_YMD'	   	  , '@SALES_VAL'		  , '@BUY_VAL'		
		  , '@FUND_RMK'		  , '@USR_ID'		, UFN_DATE_FORMAT('DATE')	, UFN_DATE_FORMAT('TIME')          , '@USR_ID'		, UFN_DATE_FORMAT('DATE')	, UFN_DATE_FORMAT('TIME')	   		)
#CrmCustomizing@InsertItem
--CrmCustomizing@InsertItemINSERT INTO ELVIS_CUSTOMIZE_ITEM (			CUST_CD		  , SEQ 		  , MNGT_NO   		  ,	CUST_ITEM           , CUST_DTL          , CUST_COST                  , INS_USR     , INS_YMD     , INS_HM                   , UPD_USR     , UPD_YMD     , UPD_HM          ) VALUES  ( 	         '@CUST_CD' 	       ,  (SELECT NVL(MAX(SEQ), 0) + 1 	 	        FROM ELVIS_CUSTOMIZE_ITEM 	 	       WHERE CUST_CD = '@CUST_CD')    	 	   , '@MNGT_NO'   	       , '@CUST_ITEM'		   , '@CUST_DTL'		   , '@CUST_COST'		  		   , '@USR_ID'   , UFN_DATE_FORMAT('DATE')	, UFN_DATE_FORMAT('TIME')		   , '@USR_ID'   , UFN_DATE_FORMAT('DATE')	, UFN_DATE_FORMAT('TIME')   	     )
#CrmCustomizing@InsertList
--CrmCustomizing@InsertListINSERT INTO ELVIS_CUSTOMIZE (			CUST_CD		  , SEQ 		  , MNGT_NO   		  ,	CUSTOM_DTL    		  , CUSTOM_YMD          , REQUESTOR          , DOWN_PAY                  , DEVELOPER          , INS_USR     , INS_YMD     , INS_HM            , UPD_USR     , UPD_YMD     , UPD_HM          ) VALUES  ( 	         '@CUST_CD' 	       ,  (SELECT NVL(MAX(SEQ), 0) + 1 	 	        FROM ELVIS_CUSTOMIZE	 	       WHERE CUST_CD = '@CUST_CD')  	 	   , '@MNGT_NO'                 	       , '@CUSTOM_DTL' 	       , '@CUSTOM_YMD'		   , '@REQUESTOR'		   , '@DOWN_PAY'		 		   , '@DEVELOPER'				   , '@USR_ID'   , UFN_DATE_FORMAT('DATE')	, UFN_DATE_FORMAT('TIME')		   , '@USR_ID'   , UFN_DATE_FORMAT('DATE')	, UFN_DATE_FORMAT('TIME')   	     )
#CrmCustomizing@MakeMngtno
--CrmCustomizing@MakeMngtnoSELECT '@CUST_CD' || SUBSTR(UFN_DATE_FORMAT('DATE'),3,4)||LPAD((NVL(MAX(SEQ), 0) + 1 ),3,0) AS MNGT_NO              FROM ELVIS_CUSTOMIZE             WHERE CUST_CD = '@CUST_CD'              AND SUBSTR(CUSTOM_YMD, 3, 4) = SUBSTR(UFN_DATE_FORMAT('DATE'),3,4)  	  
#CrmCustomizing@PrintEstm
--CrmCustomerMgt@PrintEstmSELECT  CUST_CD      , SEQ          , TO_CHAR(TO_DATE(ESTM_YMD,'YYYYMMDD'),'YYYY-MM-DD') AS ESTM_YMD      , ESTM_COST      , ESTM_RMK       FROM ELVIS_CUSTOMIZE_ESTM       WHERE CUST_CD = '@CUST_CD'   AND MNGT_NO = '@MNGT_NO'
#CrmCustomizing@PrintFund
--CrmCustomerMgt@PrintFundSELECT  CUST_CD      , SEQ      , (SELECT CD_NM FROM MDM_COM_CODE WHERE GRP_CD = 'C04' AND COMN_CD = FUND_ITEM) AS FUND_ITEM      , TO_CHAR(TO_DATE(ISSUED_YMD,'YYYYMMDD'),'YYYY-MM-DD') AS ISSUED_YMD      , SALES_VAL      , BUY_VAL      , FUND_RMK          FROM ELVIS_CUSTOMIZE_FUND       WHERE CUST_CD = '@CUST_CD'   AND MNGT_NO = '@MNGT_NO'
#CrmCustomizing@PrintItem
--CrmCustomerMgt@PrintMainSELECT  CUST_CD      , SEQ      , (SELECT CD_NM FROM MDM_COM_CODE WHERE GRP_CD = 'C04' AND COMN_CD = CUST_ITEM) AS CUST_ITEM      , CUST_DTL      , CUST_COST       FROM ELVIS_CUSTOMIZE_ITEM        WHERE CUST_CD = '@CUST_CD'   AND MNGT_NO = '@MNGT_NO'
#CrmCustomizing@PrintList
--CrmCustomizing@PrintListSELECT  CUST_CD           , MAX(CUSTOM_DTL) AS CUSTOM_DTL      , MAX(DOWN_PAY) AS DOWN_PAY      ,(SELECT SUM(CUST_COST) FROM ELVIS_CUSTOMIZE_ITEM WHERE MNGT_NO = A.MNGT_NO) AS TOT_AMT          , MAX(DOWN_PAY) - (SELECT SUM(CUST_COST) FROM ELVIS_CUSTOMIZE_ITEM WHERE MNGT_NO = A.MNGT_NO) AS PROFITS            , MAX(MNGT_NO) AS MNGT_NO         , TO_CHAR(TO_DATE(MAX(CUSTOM_YMD),'YYYYMMDD'),'YYYY-MM-DD') AS CUSTOM_YMD FROM ELVIS_CUSTOMIZE A                  WHERE A.CUST_CD = '@CUST_CD'  AND A.MNGT_NO = '@MNGT_NO'GROUP BY A.CUST_CD, A.MNGT_NO
#CrmCustomizing@SearchEstm
--CrmCustomizing@SearchEstmSELECT CUST_CD     	 , SEQ      , ESTM_YMD           , ESTM_COST     , ESTM_RMK     , MNGT_NO FROM ELVIS_CUSTOMIZE_ESTM             WHERE CUST_CD = '@CUST_CD'   AND MNGT_NO = '@MNGT_NO' ORDER BY ESTM_YMD DESC
#CrmCustomizing@SearchFund
--CrmCustomizing@SearchFundSELECT CUST_CD	 , SEQ      , FUND_ITEM     , ISSUED_YMD     , SALES_VAL     , BUY_VAL     , FUND_RMK       , MNGT_NO FROM ELVIS_CUSTOMIZE_FUND                          WHERE  CUST_CD = '@CUST_CD'   AND MNGT_NO = '@MNGT_NO'ORDER BY ISSUED_YMD DESC  
#CrmCustomizing@SearchItem
--CrmCustomizing@SearchItemSELECT  CUST_CD           , SEQ    	  ,	CUST_ITEM       , CUST_DTL      , CUST_COST             , MNGT_NO FROM ELVIS_CUSTOMIZE_ITEMWHERE CUST_CD = '@CUST_CD'  AND MNGT_NO = '@MNGT_NO'
#CrmCustomizing@SearchList
--CrmCustomizing@SearchListSELECT  CUST_CD          , MAX(SEQ) AS SEQ      , MAX(MNGT_NO) AS MNGT_NO       , MAX(CUSTOM_YMD) AS CUSTOM_YMD       , MAX(CUSTOM_DTL) AS CUSTOM_DTL      , MAX(REQUESTOR) AS REQUESTOR      , MAX(DOWN_PAY) AS DOWN_PAY      ,(SELECT SUM(CUST_COST) FROM ELVIS_CUSTOMIZE_ITEM WHERE MNGT_NO = A.MNGT_NO) AS TOT_AMT          , MAX(DOWN_PAY) - (SELECT SUM(CUST_COST) FROM ELVIS_CUSTOMIZE_ITEM WHERE MNGT_NO = A.MNGT_NO) AS PROFITS      , MAX(DEVELOPER) AS DEVELOPER FROM ELVIS_CUSTOMIZE A                         WHERE A.CUST_CD = '@CUST_CD'  GROUP BY A.CUST_CD , A.MNGT_NOORDER BY MNGT_NO DESC
#CrmCustomizing@SearchMain
--CrmCustomizing@SearchMainSELECT  CUST_CD          , MAX(SEQ) AS SEQ      , MAX(MNGT_NO) AS MNGT_NO       , MAX(CUSTOM_YMD) AS CUSTOM_YMD       , MAX(CUSTOM_DTL) AS CUSTOM_DTL      , MAX(REQUESTOR) AS REQUESTOR      , MAX(DOWN_PAY) AS DOWN_PAY      ,(SELECT SUM(CUST_COST) FROM ELVIS_CUSTOMIZE_ITEM WHERE MNGT_NO = A.MNGT_NO) AS TOT_AMT          , MAX(DOWN_PAY) - (SELECT SUM(CUST_COST) FROM ELVIS_CUSTOMIZE_ITEM WHERE MNGT_NO = A.MNGT_NO) AS PROFITS      , MAX(DEVELOPER) AS DEVELOPER FROM ELVIS_CUSTOMIZE A                         WHERE A.CUST_CD = '@CUST_CD'  
  AND MNGT_NO = '@MNGT_NO'GROUP BY A.CUST_CD , A.MNGT_NOORDER BY MNGT_NO DESC
#CrmCustomizing@Update
--CrmCustomizing@UpdateUPDATE ELVIS_CUSTOMIZE   SET CUSTOM_DTL = '@CUSTOM_DTL'     , CUSTOM_YMD = '@CUSTOM_YMD'     , DOWN_PAY = '@DOWN_PAY'     , TOT_AMT = '@TOT_AMT'            , DEVELOPER = '@DEVELOPER'     , REQUESTOR = '@REQUESTOR'     , MNGT_NO = '@MNGT_NO'     , UPD_USR = '@USR_ID'     , UPD_YMD = UFN_DATE_FORMAT('DATE')     , UPD_HM = UFN_DATE_FORMAT('TIME') WHERE CUST_CD = '@CUST_CD'    AND MNGT_NO = '@MNGT_NO'    
#CrmCustomizing@UpdateEstm
--CrmCustomizing@UpdateEstmUPDATE ELVIS_CUSTOMIZE_ESTM   SET  ESTM_YMD = '@ESTM_YMD'     , ESTM_COST = '@ESTM_COST'     , ESTM_RMK = '@ESTM_RMK'     , UPD_USR = '@USR_ID'     , UPD_YMD = UFN_DATE_FORMAT('DATE')     , UPD_HM = UFN_DATE_FORMAT('TIME') WHERE CUST_CD = '@CUST_CD'   AND SEQ     = '@SEQ'   AND MNGT_NO = '@MNGT_NO'   
#CrmCustomizing@UpdateFund
--CrmCustomizing@UpdateFundUPDATE ELVIS_CUSTOMIZE_FUND   SET  FUND_ITEM = '@FUND_ITEM'
     , FUND_RMK = '@FUND_RMK'     , SALES_VAL = '@SALES_VAL'     , BUY_VAL = '@BUY_VAL'
     , ISSUED_YMD = '@ISSUED_YMD'
     , UPD_USR = '@USR_ID'     , UPD_YMD = UFN_DATE_FORMAT('DATE')     , UPD_HM = UFN_DATE_FORMAT('TIME') WHERE CUST_CD = '@CUST_CD'   AND SEQ     = '@SEQ'   AND MNGT_NO = '@MNGT_NO'
#CrmCustomizing@UpdateItem
--CrmCustomizing@UpdateItemUPDATE ELVIS_CUSTOMIZE_ITEM   SET  CUST_ITEM = '@CUST_ITEM'      , CUST_DTL = '@CUST_DTL'      , CUST_COST = '@CUST_COST'         , UPD_USR = '@USR_ID'      , UPD_YMD = UFN_DATE_FORMAT('DATE')      , UPD_HM = UFN_DATE_FORMAT('TIME') WHERE CUST_CD = '@CUST_CD'  AND  SEQ     = '@SEQ'  AND  MNGT_NO = '@MNGT_NO' 	
#CrmCustomizing@UpdateList
--CrmCustomizing@UpdateListUPDATE ELVIS_CUSTOMIZE   SET CUSTOM_DTL = '@CUSTOM_DTL'     , CUSTOM_YMD = '@CUSTOM_YMD'     , DOWN_PAY = '@DOWN_PAY'     , TOT_AMT = '@TOT_AMT'       , SEQ = '@SEQ'     , DEVELOPER = '@DEVELOPER'     , REQUESTOR = '@REQUESTOR'     , MNGT_NO = '@MNGT_NO'     , UPD_USR = '@USR_ID'     , UPD_YMD = UFN_DATE_FORMAT('DATE')     , UPD_HM = UFN_DATE_FORMAT('TIME') WHERE CUST_CD = '@CUST_CD'   AND SEQ     = '@SEQ'   AND MNGT_NO = '@MNGT_NO'    
#CrmCustomizing@XmlSchema
<HeaderInfo>  SELECT        ''    AS CUST_CD     ,  0     AS PROFITS     ,  0     AS TOT_AMT	 ,  0     AS DOWN_PAY		 ,  ''    AS MNGT_NO	 ,  ''    AS CUSTOM_YMD FROM DUAL;  <Detail1>SELECT       0      AS SEQ	 , ''     AS CUST_ITEM	 , ''     AS CUST_DTL	 , ''     AS CUST_COSTFROM DUAL; <Detail2>   SELECT       0      AS SEQ     , ''     AS FUND_ITEM     , ''     AS ISSUED_YMD     , 0      AS SALES_VAL     , 0      AS BUY_VAL     , ''     AS FUND_RMKFROM DUAL;<Detail3>  SELECT       0      AS SEQ   	 , ''     AS ESTM_YMD      , 0      AS ESTM_COST     , ''     AS ESTM_RMK   FROM DUAL; 

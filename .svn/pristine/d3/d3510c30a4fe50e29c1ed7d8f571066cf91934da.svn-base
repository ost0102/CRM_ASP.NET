#SysBoardMgt@CreateKey
-- SysBoardMgt@CreateKeySELECT '@YYMM'    || (SELECT LPAD(NVL(SUBSTR(MAX(BOARD_ID),5,4),0)+1,4,'0')           FROM CRM_BOARD_MST          WHERE BOARD_ID LIKE '@YYMM%'     ) AS BOARD_ID  FROM DUAL     
#SysBoardMgt@Delete
--SysBoardMgt@DeleteBEGIN	DELETE CRM_BOARD_MST 	 WHERE BOARD_ID = '@BOARD_ID';	DELETE CRM_BOARD_CUST	 WHERE BOARD_ID = '@BOARD_ID';END;
#SysBoardMgt@Insert
-- SysBoardMgt@InsertINSERT INTO CRM_BOARD_MST (		BOARD_ID	  , BOARD_TYPE		  ,	TITLE	  , STRT_YMD	  , EXP_YMD	  , LINK_URL	  , NOTICE_YN	  , CS_NOTICE_YN
	  , EVB_NOTICE_YN	  , INS_USR	  , INS_YMD	  , INS_HM ) VALUES (        '@BOARD_ID'      , '@BOARD_TYPE'      , '@TITLE'      , '@STRT_YMD'      , '@EXP_YMD'      , '@LINK_URL'      , '@NOTICE_YN'      , '@CS_NOTICE_YN'
      , '@EVB_NOTICE_YN'      , '@USR_ID'      , TO_CHAR(SYSDATE,'YYYYMMDD')      , TO_CHAR(SYSDATE,'HH24MISS') )
#SysBoardMgt@Search
-- SysBoardMgt@SearchSELECT BRD.BOARD_ID     , USR.LOC_NM     , BRD.TITLE     , BRD.BOARD_BODY     , TO_CHAR(TO_DATE(BRD.INS_YMD,'yyyyMMdd'),'yyyy-MM-dd')       ||SUBSTR(BRD.INS_HM,1,2)||':'||SUBSTR(BRD.INS_HM,3,2)  AS INS_YMD     , BRD.BOARD_TYPE     , BRD.STRT_YMD     , BRD.EXP_YMD     , BRD.LINK_URL     , BRD.NOTICE_YN     , BRD.CS_NOTICE_YN
     , BRD.EVB_NOTICE_YN  FROM CRM_BOARD_MST BRD  LEFT JOIN CRM_USR_MST USR ON USR.USR_ID = BRD.INS_USR WHERE BOARD_ID = '@BOARD_ID'  
#SysBoardMgt@Update
--SysBoardMgt@UpdateUPDATE CRM_BOARD_MST    SET BOARD_TYPE = '@BOARD_TYPE'	 , TITLE = '@TITLE'	 , STRT_YMD = '@STRT_YMD'	 , EXP_YMD = '@EXP_YMD'	 , LINK_URL = '@LINK_URL'	 , NOTICE_YN = '@NOTICE_YN'	 , CS_NOTICE_YN = '@CS_NOTICE_YN'
	 , EVB_NOTICE_YN = '@EVB_NOTICE_YN'	 , UPD_USR = '@USR_ID'	 , UPD_YMD = TO_CHAR(SYSDATE,'YYYYMMDD')	 , UPD_HM = TO_CHAR(SYSDATE,'HH24MISS') WHERE BOARD_ID = '@BOARD_ID'
#SysBoardMgt@UpdateContent
-- SysBoardMgt@UpdateContentUPDATE CRM_BOARD_MST   SET BOARD_BODY = @CONTENT WHERE BOARD_ID = '@BOARD_ID'

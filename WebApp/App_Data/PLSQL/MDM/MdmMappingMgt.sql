#MdmMappingMgt@Delete
--MdmMappingMgt@DeleteDELETE FROM MDM_MAPPING_MST  WHERE OFFICE_CD = '@OFFICE_CD'   AND TABLE_ID = '@TABLE_ID'   AND FM_CD = '@FM_CD'   AND FM_TYPE = '@FM_TYPE'   AND FIELD_ID = '@FIELD_ID'  [TO_CD]   AND TO_CD = '@TO_CD'  [/TO_CD]
#MdmMappingMgt@Insert
--MdmMappingMgt@InsertINSERT INTO MDM_MAPPING_MST (	  OFFICE_CD      , TABLE_ID 	      , FM_CD    	      , FM_TYPE          , TO_CD        , TO_NM             , RMK       
     , INS_USR        , INS_YMD         , INS_HM     , UPD_USR     , UPD_YMD     , UPD_HM     , FIELD_ID     , FIELD_TYPE
     , UPPER_FM_CD)VALUES (	'@OFFICE_CD'	,'@TABLE_ID'	,'@FM_CD'	,'@FM_TYPE'	,'@TO_CD'	,'@TO_NM'	,'@RMK'	,'@INS_USR'	, TO_CHAR(SYSDATE,'yyyyMMdd')	, TO_CHAR(SYSDATE,'HH24MISS')	,'@INS_USR'	, TO_CHAR(SYSDATE,'yyyyMMdd')	, TO_CHAR(SYSDATE,'HH24MISS')	,'@FIELD_ID'	,'@FIELD_TYPE'
	,'@UPPER_FM_CD')
#MdmMappingMgt@Search
--MdmMappingMgt@Search  SELECT A.OFFICE_CD      , A.TABLE_ID 	      , A.FM_CD    	      , A.FM_TYPE          , A.TO_CD        , A.TO_NM             , A.RMK            , A.FIELD_ID     , A.FIELD_TYPE
     , A.UPPER_FM_CD     , (SELECT B.LOC_NM FROM CRM_USR_MST B WHERE B.USR_ID = A.INS_USR) AS INS_USR     , TO_CHAR(TO_DATE(A.INS_YMD,'YYYYMMDD'),'YYYY-MM-DD') || ' ' ||	   TO_CHAR(TO_DATE(A.INS_HM,'hh24miss'), 'hh24:mi:ss') 	AS INS_YMD     , (SELECT B.LOC_NM FROM CRM_USR_MST B WHERE B.USR_ID = A.INS_USR) AS UPD_USR     , TO_CHAR(TO_DATE(A.UPD_YMD,'YYYYMMDD'),'YYYY-MM-DD') || ' ' ||	   TO_CHAR(TO_DATE(A.UPD_HM,'hh24miss'), 'hh24:mi:ss') 	AS UPD_YMD	 -- UPDAE KEY COLUMN	 , A.TABLE_ID	AS PK_TABLE_ID	 , A.FM_CD		AS PK_FM_CD     , A.FM_TYPE	AS PK_FM_TYPE     , A.TO_CD		AS PK_TO_CD  FROM MDM_MAPPING_MST A  WHERE 1=1  --TABLE_ID는 프라임에서 사용하고 있습니다. 지우지 말아주세요  [TABLE_ID]    AND A.TABLE_ID = '@TABLE_ID'  [/TABLE_ID] [COMN_CD] AND A.FM_TYPE = '@COMN_CD' [/COMN_CD]   [RMK] AND A.RMK   LIKE '%@RMK%' [/RMK] [FM_CD] AND A.FM_CD = '@FM_CD' [/FM_CD] [TO_CD] AND A.TO_CD = '@TO_CD' [/TO_CD] ORDER BY A.OFFICE_CD, A.FM_TYPE, A.FM_CD, A.TO_CD
#MdmMappingMgt@Update
-- MdmMappingMgt@UpdateUPDATE MDM_MAPPING_MST    SET TABLE_ID = '@TABLE_ID'     , FM_TYPE = '@FM_TYPE'     , FM_CD = '@FM_CD'     , TO_CD = '@TO_CD'     , TO_NM = '@TO_NM'     , RMK = '@RMK'            , UPD_USR = '@UPD_USR'   	 , UPD_YMD = TO_CHAR(SYSDATE,'yyyyMMdd')	 , UPD_HM = TO_CHAR(SYSDATE,'HH24MISS')     , FIELD_ID = '@FIELD_ID'     , FIELD_TYPE = '@FIELD_TYPE'
     , UPPER_FM_CD = '@UPPER_FM_CD'
 WHERE OFFICE_CD = '@OFFICE_CD'   AND TABLE_ID = '@PK_TABLE_ID'   AND FM_CD = '@PK_FM_CD'   AND FM_TYPE = '@PK_FM_TYPE'   AND TO_CD = '@PK_TO_CD'	

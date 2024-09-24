#MdmCommonMgt@DeleteCommonCode
--MdmCommonMgt@DeleteCommonCode BEGINDELETE MDM_COM_CODE WHERE GRP_CD	= '@GRP_CD'   AND COMN_CD	= '@COMN_CD';DELETE MDM_LANG_NAME WHERE REQ_CD	= '@COMN_CD'   AND ITEM_CD	= '@GRP_CD';   END ;
#MdmCommonMgt@DeleteLocalLanguage
--MdmCommonMgt@DeleteLocalLanguageDELETE MDM_LANG_NAME WHERE LANG_CD	= '@LANG_CD'   AND REQ_CD	= '@REQ_CD'   AND ITEM_CD	= '@ITEM_CD'
#MdmCommonMgt@Insert
--MdmCommonMgt@InsertINSERT INTO MDM_COM_GRP(			GRP_CD			, GRP_NM		, CD_LEN		, NAME_TITLE	, TITLE1		  ,	TITLE2			, TITLE3		, TITLE4		, TITLE5		, TITLE6		  ,	TITLE7			, TITLE8		, TITLE9		, TITLE10		  ,	MNGT_AUTH_LVL	, INS_USR		, INS_YMD		, INS_HM		, UPD_USR		  , UPD_YMD			, UPD_HM		  )     VALUES (			'@GRP_CD'		, '@GRP_NM'		, NVL(@CD_LEN, 0)				, '@NAME_TITLE'			  , '@TITLE1'	    , '@TITLE2'		, '@TITLE3'		, '@TITLE4'		, '@TITLE5'				  , '@TITLE6'				  , '@TITLE7'		, '@TITLE8' 	, '@TITLE9'		, '@TITLE10'			  , NVL('@MNGT_AUTH_LVL', 'N')	, '@USR_ID'		, UFN_DATE_FORMAT('DATE')		  , UFN_DATE_FORMAT('TIME')			, '@USR_ID'		, UFN_DATE_FORMAT('DATE')	    		  , UFN_DATE_FORMAT('TIME')		  )
#MdmCommonMgt@InsertCommonCode
--MdmCommonMgt@InsertCommonCodeINSERT INTO MDM_COM_CODE(			GRP_CD			, COMN_CD			, CD_NM			, OPT_ITEM1		, OPT_ITEM2		  , OPT_ITEM3		, OPT_ITEM4			, OPT_ITEM5		, OPT_ITEM6				  , OPT_ITEM7		, OPT_ITEM8			, OPT_ITEM9		, OPT_ITEM10		  , RMK		  , SORT			, USE_YN		  , INS_USR			, INS_YMD			, INS_HM				  , UPD_USR			, UPD_YMD   	    , UPD_HM		  )     VALUES (			'@GRP_CD'		, '@COMN_CD'		, '@CD_NM'		, '@OPT_ITEM1'	, '@OPT_ITEM2'		  , '@OPT_ITEM3'	, '@OPT_ITEM4'		, '@OPT_ITEM5'	, '@OPT_ITEM6'			  , '@OPT_ITEM7'	, '@OPT_ITEM8'		, '@OPT_ITEM9'	, '@OPT_ITEM10'			  , '@RMK'		  , '@SORT'			, NVL('@USE_YN','Y')		  , '@USR_ID'		, UFN_DATE_FORMAT('DATE')			, UFN_DATE_FORMAT('TIME')					  , '@USR_ID'		, UFN_DATE_FORMAT('DATE')			, UFN_DATE_FORMAT('TIME')		  )
#MdmCommonMgt@InsertLocalLanguage
--MdmCommonMgt@InsertLocalLanguageINSERT INTO MDM_LANG_NAME(			LANG_CD		, REQ_CD		, ITEM_CD		, LOC_NM		, INS_USR				  , INS_YMD		, INS_HM		, UPD_USR		, UPD_YMD		, UPD_HM		  )     VALUES (			'@LANG_CD'	, '@REQ_CD'		, '@ITEM_CD'	, '@LOC_NM'		, '@USR_ID'		  , UFN_DATE_FORMAT('DATE')		, UFN_DATE_FORMAT('TIME')	 	, '@USR_ID'				  , UFN_DATE_FORMAT('DATE')		, UFN_DATE_FORMAT('TIME')		  )
#MdmCommonMgt@Search
--MdmCommonMgt@SearchSELECT GRP_CD     , GRP_NM	 , MNGT_AUTH_LVL	 , CD_LEN	 , NAME_TITLE	 , TITLE1	 , TITLE2	 , TITLE3	 , TITLE4	 , TITLE5	 , TITLE6	 , TITLE7	 , TITLE8	 , TITLE9	 , TITLE10     , UFN_TABLE_ITEM('USER_NM',A.INS_USR,'L','') AS INS_USR     , TO_CHAR(TO_DATE(A.INS_YMD,'YYYYMMDD'),'YYYY-MM-DD') || ' ' ||	   TO_CHAR(TO_DATE(A.INS_HM,'hh24miss'), 'hh24:mi:ss') AS INS_YMD     , UFN_TABLE_ITEM('USER_NM',A.UPD_USR,'L','') AS UPD_USR     , TO_CHAR(TO_DATE(A.UPD_YMD,'YYYYMMDD'),'YYYY-MM-DD') || ' ' ||	   TO_CHAR(TO_DATE(A.UPD_HM,'hh24miss'), 'hh24:mi:ss') AS UPD_YMD  FROM MDM_COM_GRP A WHERE MNGT_AUTH_LVL  = 'N'  [GRP_CD]    AND UPPER(GRP_CD) LIKE '%' || UPPER('@S_GRP_CD') || '%'  [/GRP_CD] [GRP_NM]   AND UPPER(GRP_NM) LIKE '%' || UPPER('%@S_GRP_NM') || '%'   [/GRP_NM] ORDER BY GRP_CD
#MdmCommonMgt@SearchAdmin
--MdmCommonMgt@SearchAdminSELECT GRP_CD     , GRP_NM	 , MNGT_AUTH_LVL	 , CD_LEN	 , NAME_TITLE	 , TITLE1	 , TITLE2	 , TITLE3	 , TITLE4	 , TITLE5	 , TITLE6	 , TITLE7	 , TITLE8	 , TITLE9	 , TITLE10  FROM MDM_COM_GRP WHERE 1=1  [GRP_CD]    AND UPPER(GRP_CD) LIKE '%' || UPPER('@S_GRP_CD') || '%'  [/GRP_CD] [GRP_NM]   AND UPPER(GRP_NM) LIKE '%' || UPPER('%@S_GRP_NM') || '%'  [/GRP_NM] ORDER BY GRP_CD
#MdmCommonMgt@SearchCommonCode
--MdmCommonMgt@SearchCommonCodeSELECT GRP_CD     , COMN_CD	 , CD_NM	 , RMK	 , OPT_ITEM1	 , OPT_ITEM2	 , OPT_ITEM3	 , OPT_ITEM4	 , OPT_ITEM5	 , OPT_ITEM6	 , OPT_ITEM7	 , OPT_ITEM8	 , OPT_ITEM9	 , OPT_ITEM10	 , SORT     , UFN_TABLE_ITEM('USER_NM',A.INS_USR,'L','') AS INS_USR     , TO_CHAR(TO_DATE(A.INS_YMD,'YYYYMMDD'),'YYYY-MM-DD') || ' ' ||	   TO_CHAR(TO_DATE(A.INS_HM,'hh24miss'), 'hh24:mi:ss') AS INS_YMD     , UFN_TABLE_ITEM('USER_NM',A.UPD_USR,'L','') AS UPD_USR     , TO_CHAR(TO_DATE(A.UPD_YMD,'YYYYMMDD'),'YYYY-MM-DD') || ' ' ||	   TO_CHAR(TO_DATE(A.UPD_HM,'hh24miss'), 'hh24:mi:ss') AS UPD_YMD	 , USE_YN  FROM MDM_COM_CODE A WHERE GRP_CD = '@GRP_CD' [USER_SET_CD]   AND COMN_CD LIKE '%@USER_SET_CD%' [/USER_SET_CD] [USER_SET_NM]   AND CD_NM LIKE '%@USER_SET_NM%' [/USER_SET_NM] ORDER BY SORT        , GRP_CD        , COMN_CD
#MdmCommonMgt@SearchLocalLanguage
--MdmCommonMgt@SearchLocalLanguageSELECT ITEM_CD	 , REQ_CD	 , LANG_CD     , LOC_NM  FROM MDM_LANG_NAME WHERE REQ_CD  = '@REQ_CD'   AND ITEM_CD = '@ITEM_CD' ORDER BY LANG_CD
#MdmCommonMgt@SearchPreloadCommonCode
--MdmCommonMgt@SearchPreloadCommonCodeSELECT GRP_CD     , COMN_CD	 , CD_NM	 , RMK	 , OPT_ITEM1	 , OPT_ITEM2	 , OPT_ITEM3	 , OPT_ITEM4	 , OPT_ITEM5	 , OPT_ITEM6	 , OPT_ITEM7	 , OPT_ITEM8	 , OPT_ITEM9	 , OPT_ITEM10	 , SORT     , UFN_TABLE_ITEM('USER_NM',A.INS_USR,'L','') AS INS_USR     , TO_CHAR(TO_DATE(A.INS_YMD,'YYYYMMDD'),'YYYY-MM-DD') || ' ' ||	   TO_CHAR(TO_DATE(A.INS_HM,'hh24miss'), 'hh24:mi:ss') AS INS_YMD     , UFN_TABLE_ITEM('USER_NM',A.UPD_USR,'L','') AS UPD_USR     , TO_CHAR(TO_DATE(A.UPD_YMD,'YYYYMMDD'),'YYYY-MM-DD') || ' ' ||	   TO_CHAR(TO_DATE(A.UPD_HM,'hh24miss'), 'hh24:mi:ss') AS UPD_YMD	 , USE_YN  FROM MDM_COM_CODE A WHERE GRP_CD IN ('C03','T02','T03','T05','T07','T08','T09','T10','S31','C11','C12') ORDER BY GRP_CD        , SORT        , COMN_CD
#MdmCommonMgt@Update
--MdmCommonMgt@UpdateUPDATE MDM_COM_GRP    SET GRP_NM			= '@GRP_NM'     , CD_LEN			= '@CD_LEN'     , NAME_TITLE		= '@NAME_TITLE'     , TITLE1			= '@TITLE1'     , TITLE2			= '@TITLE2'     , TITLE3			= '@TITLE3'     , TITLE4			= '@TITLE4'     , TITLE5			= '@TITLE5'     , TITLE6			= '@TITLE6'      , TITLE7			= '@TITLE7'      , TITLE8			= '@TITLE8'      , TITLE9			= '@TITLE9'      , TITLE10   		= '@TITLE10'      , MNGT_AUTH_LVL	= '@MNGT_AUTH_LVL'     , UPD_USR			= '@USR_ID'     , UPD_YMD			= UFN_DATE_FORMAT('DATE')     , UPD_HM			= UFN_DATE_FORMAT('TIME') WHERE GRP_CD 		    = '@GRP_CD'
#MdmCommonMgt@UpdateCommonCode
--MdmCommonMgt@UpdateCommonCodeUPDATE MDM_COM_CODE    SET CD_NM		= '@CD_NM'     , OPT_ITEM1	= '@OPT_ITEM1'     , OPT_ITEM2	= '@OPT_ITEM2'     , OPT_ITEM3	= '@OPT_ITEM3'     , OPT_ITEM4	= '@OPT_ITEM4'     , OPT_ITEM5	= '@OPT_ITEM5'     , OPT_ITEM6	= '@OPT_ITEM6'     , OPT_ITEM7	= '@OPT_ITEM7'     , OPT_ITEM8	= '@OPT_ITEM8'     , OPT_ITEM9	= '@OPT_ITEM9'     , OPT_ITEM10	= '@OPT_ITEM10'     , SORT         = '@SORT'     , RMK			= '@RMK'     , USE_YN 		= NVL('@USE_YN','Y')     , UPD_USR		= '@USR_ID'     , UPD_YMD		= UFN_DATE_FORMAT('DATE')     , UPD_HM		= UFN_DATE_FORMAT('TIME') WHERE GRP_CD 		= '@GRP_CD'    AND COMN_CD 		= '@COMN_CD'
#MdmCommonMgt@UpdateLocalLanguage
--MdmCommonMgt@UpdateLocalLanguageUPDATE MDM_LANG_NAME   SET LOC_NM	= '@LOC_NM'     , UPD_USR	= '@USR_ID'     , UPD_YMD	= UFN_DATE_FORMAT('DATE')     , UPD_HM	= UFN_DATE_FORMAT('TIME') WHERE LANG_CD 	= '@LANG_CD'   AND REQ_CD 	= '@REQ_CD'   AND ITEM_CD 	= '@ITEM_CD'

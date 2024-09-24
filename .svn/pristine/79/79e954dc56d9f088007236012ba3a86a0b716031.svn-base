#MdmUserMgt@CheckUserId
--MdmUserMgt@CheckUserIdSELECT USR_ID  FROM CRM_USR_MST WHERE USR_ID = '@USR_ID'
#MdmUserMgt@InitLookUp
-- MdmUserMgt@InitLookUpSELECT A.SYS_ID     , A.PGM_ID     , A.PGM_NM     , A.PGM_GRP  FROM SYS_PROGRAM@DL_SYS A WHERE 1=1   AND PGM_TYPE = 'P'   AND SYS_ID = 'FMS'
#MdmUserMgt@Insert
--MdmUserMgt@InsertINSERT INTO CRM_USR_MST( 	          USR_ID	        , ENG_NM	        , LOC_NM	        , HP_NO	        , TEL_NO	        , FAX_NO	        , PSWD	        , EMAIL	        , DEPT_CD	        , USE_YN	        , RMK	        , AUTH_TYPE
	        , RANK	        , INS_USR	        , INS_YMD	        , INS_HM          [RECVMSG_YN]            , RECVMSG_YN          [/RECVMSG_YN]	      )   VALUES ( '@USR_ID'          , '@ENG_NM'          , '@LOC_NM'          , '@HP_NO'          , '@TEL_NO'          , '@FAX_NO'          , UNF_MD5_ENCRYPTION('@PSWD')          , '@EMAIL'          , '@DEPT_CD'          , NVL('@USE_YN', 'Y')          , '@RMK'          , '@AUTH_TYPE'
          , '@RANK'          , '@INS_USR'          , UFN_DATE_FORMAT('DATE')          , UFN_DATE_FORMAT('TIME')        [RECVMSG_YN]          , '@RECVMSG_YN'        [/RECVMSG_YN]          )
#MdmUserMgt@Search
-- MdmUserMgt@SearchSELECT USR_ID     , ENG_NM     , LOC_NM     , PSWD     , DEPT_CD	 , (SELECT CD_NM FROM MDM_COM_CODE WHERE GRP_CD = 'C03' AND COMN_CD = A.DEPT_CD) AS DEPT_NM     , USE_YN     , USER_CNT_YN     , SORT     , RECVMSG_YN  FROM CRM_USR_MST A WHERE 1=1	[USR_ID]   		AND USR_ID LIKE '%@USR_ID%'	[/USR_ID]	[INS_USR_ID]   		AND USR_ID = '@USR_ID'	[/INS_USR_ID]	[USR_NM]   		AND (LOC_NM LIKE '%@USR_NM%' OR ENG_NM LIKE '%@USR_NM%')	[/USR_NM]	[USE_YN]   		AND USE_YN = '@USE_YN'	[/USE_YN]	[USER_CNT_YN]   		AND USER_CNT_YN = '@USER_CNT_YN'	[/USER_CNT_YN]	 ORDER BY DEPT_CD, LOC_NM
#MdmUserMgt@SearchDetail
-- MdmUserMgt@SearchDetailSELECT USR_ID     , ENG_NM     , LOC_NM     , EMAIL     , DEPT_CD	 , (SELECT CD_NM FROM MDM_COM_CODE WHERE GRP_CD = 'C03' AND COMN_CD = A.DEPT_CD) AS DEPT_NM	 , USE_YN	 , TEL_NO	 , FAX_NO	 , HP_NO	 , RMK	 , AUTH_TYPE
	 , RANK	 , RECVMSG_YN  FROM CRM_USR_MST A WHERE USR_ID = '@USR_ID'
#MdmUserMgt@SearchDetailOffice
-- MdmUserMgt@SearchDetailOfficeSELECT *  FROM CRM_USR_MST A WHERE USR_ID = '@USR_ID'
#MdmUserMgt@Update
-- MdmUserMgt@UpdateUPDATE CRM_USR_MST    SET USR_ID = '@USR_ID'     , ENG_NM = '@ENG_NM'     , LOC_NM = '@LOC_NM'     , HP_NO = '@HP_NO'     , TEL_NO = '@TEL_NO'     , FAX_NO = '@FAX_NO'     [PSWD]   	 , PSWD = UNF_MD5_ENCRYPTION('@PSWD')	 [/PSWD]     , EMAIL = '@EMAIL'     , DEPT_CD = '@DEPT_CD'     , USE_YN = NVL('@USE_YN', 'Y')     , RMK = '@RMK'     , AUTH_TYPE = '@AUTH_TYPE'
     , RANK = '@RANK'     , UPD_USR = '@UPD_USR'	 , UPD_YMD = UFN_DATE_FORMAT('DATE')	 , UPD_HM = UFN_DATE_FORMAT('TIME')   [RECVMSG_YN]     , RECVMSG_YN = '@RECVMSG_YN'   [/RECVMSG_YN] WHERE USR_ID = '@USR_ID'

#ComDocumentList@Search
--ComDocumentList@SearchSELECT A.MNGT_NO     , A.SEQ     , A.FILE_NM     , A.FILE_SIZE     , A.DOC_TYPE     , A.DOC_NO     , A.FILE_PATH     , A.SCREEN     , A.CI_AMT     , A.PO_NO     , A.RMK     , A.SYS_ID     , A.FORM_ID     , A.CLOSE_YN     , A.STORAGE     , A.SERVER_FILE_NM     , A.SERVER_CD     , (SELECT B.LOC_NM FROM CRM_USR_MST B WHERE B.USR_ID = A.INS_USR) AS INS_USR     , TO_CHAR(TO_DATE(A.INS_YMD,'YYYYMMDD'),'YYYY-MM-DD') || ' ' ||       TO_CHAR(TO_DATE(A.INS_HM,'HH24MISS'), 'HH24:MI:SS') AS INS_YMD     , (SELECT B.LOC_NM FROM CRM_USR_MST B WHERE B.USR_ID = A.INS_USR) AS UPD_USR     , TO_CHAR(TO_DATE(A.UPD_YMD,'YYYYMMDD'),'YYYY-MM-DD') || ' ' ||       TO_CHAR(TO_DATE(A.UPD_HM,'HH24MISS'), 'HH24:MI:SS') AS UPD_YMD  FROM COM_DOC_MST A WHERE 1 = 1 [DATE_FM]   AND A.INS_YMD >= '@DATE_FM' [/DATE_FM] [DATE_FM]   AND A.INS_YMD <= '@DATE_TO' [/DATE_FM]
 [DOC_TYPE]   AND A.DOC_TYPE = '@DOC_TYPE' [/DOC_TYPE]
 [SCREEN]   AND A.SCREEN = '@SCREEN' [/SCREEN]
 [SEARCH_KEY]
   [SEARCH_KEY_F]     AND A.FILE_NM LIKE '%@SEARCH_KEY%'
   [/SEARCH_KEY_F]   [SEARCH_KEY_R]     AND A.RMK LIKE '%@SEARCH_KEY%'
   [/SEARCH_KEY_R]
 [/SEARCH_KEY]
#ComDocumentList@Search_20171115
--ComDocumentList@SearchWITH BL_LIST AS(SELECT  H.SR_NO AS SR_NO  		     ,  H.MBL_NO AS MBL_NO  		     ,  H.HBL_NO AS HBL_NO  		     ,  H.ETD AS ETD  		     ,  H.ETA AS ETA  		     ,  HA.EX_IM_TYPE AS EX_IM_TYPE  		     ,  H.VSL AS VSL  		     ,  HA.OP_CD AS OP_CD  		     ,  H.POD_CD AS POD_CD  		     ,  H.POL_CD AS POL_CD  		     ,  H.SHP_CD AS SHP_CD  		     ,  H.CNE_CD AS CNE_CD  		     ,  HA.CUST_CD AS CUST_CD  		     ,  H.REQ_SVC AS REQ_SVC  		     , (SELECT CD_NM   		          FROM MDM_COM_CODE   		         WHERE GRP_CD = 'M33'   		           AND COMN_CD = DOC.DOC_TYPE) AS DOC_TYPE  		     , DOC.DOC_NO  		     , DOC.FILE_NM  		     , DOC.FILE_PATH  		     , DOC.MNGT_NO  		     , DOC.SEQ  		     , DOC.INS_YMD  		     , DOC.OFFICE_CD  		     , DOC.INS_USR  		     , (DOC.INS_YMD || DOC.INS_HM) AS INS_DATE  		     , DOC.UPD_USR  		     , (DOC.UPD_YMD || DOC.UPD_HM) AS UPD_DATE           FROM COM_DOC_MST DOC ,FMS_HBL_MST H , FMS_HBL_AUTH HA          WHERE 1 = 1           AND H.HBL_NO = DOC.MNGT_NO           AND DOC.MNGT_NO = HA.HBL_NO            AND HA.OFFICE_CD = DOC.OFFICE_CD           AND HA.OFFICE_CD = '@OFFICE_CD'           [OFFICE_CD]               AND DOC.OFFICE_CD = '@OFFICE_CD'           [/OFFICE_CD]		   [DOC_TYPE]  		       AND DOC.DOC_TYPE = '@DOC_TYPE'		   [/DOC_TYPE]		   [INS_USR]		      AND DOC.INS_USR = '@INS_USR'		   [/INS_USR] 	UNION         SELECT  H.SR_NO AS SR_NO  		     ,  H.MBL_NO AS MBL_NO  		     ,  ''       AS HBL_NO  		     ,  H.ETD AS ETD  		     ,  H.ETA AS ETA  		     ,  HA.EX_IM_TYPE AS EX_IM_TYPE  		     ,  H.VSL AS VSL  		     ,  HA.OP_CD AS OP_CD  		     ,  H.POD_CD AS POD_CD  		     ,  H.POL_CD AS POL_CD  		     ,  H.SHP_CD AS SHP_CD  		     ,  H.CNE_CD AS CNE_CD  		     ,  ''    AS CUST_CD  		     ,  H.REQ_SVC AS REQ_SVC  		     , (SELECT CD_NM   		          FROM MDM_COM_CODE   		         WHERE GRP_CD = 'M33'   		           AND COMN_CD = DOC.DOC_TYPE) AS DOC_TYPE  		     , DOC.DOC_NO  		     , DOC.FILE_NM  		     , DOC.FILE_PATH  		     , DOC.MNGT_NO  		     , DOC.SEQ  		     , DOC.INS_YMD  		     , DOC.OFFICE_CD  		     , DOC.INS_USR  		     , (DOC.INS_YMD || DOC.INS_HM) AS INS_DATE  		     , DOC.UPD_USR  		     , (DOC.UPD_YMD || DOC.UPD_HM) AS UPD_DATE           FROM COM_DOC_MST DOC ,FMS_MBL_MST H , FMS_MBL_AUTH HA          WHERE 1 = 1        -- 문제가 있는듯 하여 주석         --  AND H.SR_NO = DOC.MNGT_NO         --  AND DOC.MNGT_NO = HA.SR_NO            AND H.SR_NO = HA.SR_NO           AND (  DOC.MNGT_NO = HA.SR_NO OR DOC.MNGT_NO = H.MBL_NO )            AND HA.OFFICE_CD = DOC.OFFICE_CD      --     AND HA.OFFICE_CD = '@OFFICE_CD'           [OFFICE_CD]               AND DOC.OFFICE_CD = '@OFFICE_CD'           [/OFFICE_CD]		   [DOC_TYPE]  		       AND DOC.DOC_TYPE = '@DOC_TYPE'		   [/DOC_TYPE]		   [INS_USR]		      AND DOC.INS_USR = '@INS_USR'		   [/INS_USR] ) SELECT SR_NO,	  	MBL_NO,		HBL_NO, 	  DOC_TYPE, 	FILE_NM,        REQ_SVC,   	ETD, 		ETA, 		  SHP_CD, 		CNE_CD,        POL_CD, 		POD_CD, 	OP_CD, 		  VSL, 			FILE_PATH,        MNGT_NO, 	SEQ, 		EX_IM_TYPE,   DOC_NO, 		OFFICE_CD,              INS_USR,     UFN_FORMAT(INS_DATE, 'DATETIME') AS INS_YMD,       UPD_USR,     UFN_FORMAT(UPD_DATE, 'DATETIME') AS INS_YMD  FROM (          SELECT   SR_NO  		     ,MBL_NO  		     ,HBL_NO  		     ,ETD  		     ,ETA  		     ,EX_IM_TYPE  		     ,VSL  		     ,OP_CD  		      		     ,POD_CD  		     ,POL_CD  		     ,SHP_CD  		     ,CNE_CD  		     ,CUST_CD   		     ,REQ_SVC  		     ,DOC_TYPE  		     ,DOC_NO  		     ,FILE_NM  		     ,FILE_PATH  		     ,MNGT_NO  		     ,SEQ  		     ,INS_YMD  		     ,OFFICE_CD  		     ,INS_USR  		     ,INS_DATE  		     ,UPD_USR  		     ,UPD_DATE      FROM BL_LISTUNION         SELECT  '' AS SR_NO  		     ,  '' AS MBL_NO  		     ,  '' AS HBL_NO  		     ,  '' AS ETD  		     ,  '' AS ETA  		     ,  '' AS EX_IM_TYPE  		     ,  '' AS VSL  		     ,  '' AS OP_CD  		      		     ,  '' AS POD_CD  		     ,  '' AS POL_CD  		     ,  '' AS SHP_CD  		     ,  '' AS CNE_CD  		     ,  DOC.MNGT_NO AS CUST_CD  		       		     ,  '' AS REQ_SVC  		     , (SELECT CD_NM   		          FROM MDM_COM_CODE   		         WHERE GRP_CD = 'M33'   		           AND COMN_CD = DOC.DOC_TYPE) AS DOC_TYPE  		     , DOC.DOC_NO  		     , DOC.FILE_NM  		     , DOC.FILE_PATH  		     , DOC.MNGT_NO  		     , DOC.SEQ  		     , DOC.INS_YMD  		     , DOC.OFFICE_CD  		     , DOC.INS_USR  		     , (DOC.INS_YMD || DOC.INS_HM) AS INS_DATE  		     , DOC.UPD_USR  		     , (DOC.UPD_YMD || DOC.UPD_HM) AS UPD_DATE          FROM COM_DOC_MST DOC         WHERE 1 = 1            AND (  DOC.MNGT_NO , DOC.SEQ )  NOT IN (SELECT MNGT_NO, SEQ FROM BL_LIST )            --AND HA.OFFICE_CD = '@OFFICE_CD'           [OFFICE_CD]               AND DOC.OFFICE_CD = '@OFFICE_CD'           [/OFFICE_CD]		   [DOC_TYPE]  		       AND DOC.DOC_TYPE = '@DOC_TYPE'		   [/DOC_TYPE]		   [INS_USR]		      AND DOC.INS_USR = '@INS_USR'		   [/INS_USR]		       ) WHERE 1 = 1 [REQ_SVC]     AND REQ_SVC = '@REQ_SVC'   [/REQ_SVC] [DATE_ETD]	 [DATE_FM]	    AND ETD >= '@DATE_FM'	 [/DATE_FM]	 [DATE_TO]   		AND ETD <= '@DATE_TO'	 [/DATE_TO] [/DATE_ETD] [DATE_ETA]	 [DATE_FM]	    AND ETA >= '@DATE_FM'	 [/DATE_FM]	 [DATE_TO]   		AND ETA <= '@DATE_TO'	 [/DATE_TO] [/DATE_ETA] [REG_YMD]	 [DATE_FM]	    AND INS_YMD >= '@DATE_FM'	 [/DATE_FM]	 [DATE_TO]   		AND INS_YMD <= '@DATE_TO'	 [/DATE_TO] [/REG_YMD] [SHP_CD]     AND SHP_CD = '@SHP_CD' [/SHP_CD] [CNE_CD]     AND CNE_CD = '@CNE_CD' [/CNE_CD] [CUST_CD]     AND CUST_CD = '@CUST_CD' [/CUST_CD] [POL_CD]     AND POL_CD = '@POL_CD' [/POL_CD] [POD_CD]     AND POD_CD = '@POD_CD' [/POD_CD] [OP_CD]     AND OP_CD = '@OP_CD' [/OP_CD] [VSL]     AND VSL LIKE '%@VSL%' [/VSL] [MBL_NO]     AND MBL_NO LIKE '%' || '@MBL_NO' ||'%' [/MBL_NO] [HBL_NO]     AND HBL_NO LIKE '%' || '@HBL_NO' ||'%' [/HBL_NO] [EX_IM_TYPE]     AND EX_IM_TYPE = '@EX_IM_TYPE' [/EX_IM_TYPE] [DOC_NO]   AND DOC_NO = '@DOC_NO' [/DOC_NO] 

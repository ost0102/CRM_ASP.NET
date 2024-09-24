#SysDict@chkDetail
-- SysDict@chkDetailSELECT *  FROM SYS_DICT_DTL@DL_SYS WHERE UPPER(WORD_ID) = UPPER('@WORD_ID')    AND CTRY_CD = '@CTRY_CD'    AND WORD_TYPE = '@WORD_TYPE' 
#SysDict@chkHeader
-- SysDict@chkHeaderSELECT *  FROM SYS_DICT_MST@DL_SYS WHERE WORD_TYPE = '@WORD_TYPE'    AND UPPER(WORD_ID) = UPPER('@WORD_ID') 
#SysDict@delDetail
-- SysDict@delDetailDELETE SYS_DICT_DTL@DL_SYS WHERE WORD_ID = '@WORD_ID'   AND CTRY_CD = '@CTRY_CD'   AND WORD_TYPE = '@WORD_TYPE'	
#SysDict@delHeader
-- SysDict@delHeader
DELETE SYS_DICT_MST@DL_SYS WHERE WORD_TYPE = '@WORD_TYPE'   AND WORD_ID = '@WORD_ID'
#SysDict@insDetail
-- SysDict@insDetail
INSERT INTO SYS_DICT_DTL@DL_SYS(
         WORD_TYPE
       , WORD_ID
       , CTRY_CD
       , WORD_NM
       , INS_USR
       , INS_DATE
       , UPD_USR
       , UPD_DATE
)VALUES(
         '@WORD_TYPE'
       , '@WORD_ID'
       , '@CTRY_CD'
       , '@WORD_NM'
       , '@INS_USR'
       , SYSDATE
       , '@INS_USR'
       , SYSDATE
)
#SysDict@insHeader
-- SysDict@insHeader
INSERT INTO SYS_DICT_MST@DL_SYS(
         WORD_TYPE
       , WORD_ID
       , WORD_NM
       , WORD_DESC
       , INS_USR
       , INS_DATE
       , UPD_USR
       , UPD_DATE
)VALUES(
         '@WORD_TYPE'
       , '@WORD_ID'
       , '@WORD_NM'
       , '@WORD_DESC'
       , '@INS_USR'
       , SYSDATE
       , '@INS_USR'
       , SYSDATE
)
#SysDict@retWordDetails
-- SysDict@retWordDetailsSELECT WORD_TYPE, WORD_ID, CTRY_CD, WORD_NM   FROM SYS_DICT_DTL@DL_SYS WHERE UPPER(WORD_ID) = UPPER('@WORD_ID')    AND WORD_TYPE = '@WORD_TYPE' 
#SysDict@retWordsForLanguage
-- SysDict@retWordsForLanguageSELECT WORD_TYPE, WORD_ID, WORD_NM   FROM SYS_DICT_DTL@DL_SYS WHERE CTRY_CD = '@CTRY_CD'
#SysDict@searchDictionary
-- SysDict@searchDictionarySELECT WORD_TYPE, WORD_ID, WORD_NM, WORD_DESC  FROM SYS_DICT_MST@DL_SYS WHERE WORD_TYPE = '@WORD_TYPE' [WORD_ID]   AND UPPER(WORD_ID) = UPPER('@WORD_ID')[/WORD_ID][WORD_NM]   AND WORD_NM LIKE '%@WORD_NM%'[/WORD_NM][SCREEN_ID]	AND WORD_DESC LIKE '%@SCREEN_ID%'[/SCREEN_ID]
#SysDict@searchDictionary2
-- SysDict@searchDictionary2SELECT A.WORD_TYPE,A.WORD_ID,A.WORD_NM, B.WORD_NM, B.CTRY_CD  FROM SYS_DICT_MST@DL_SYS A LEFT OUTER JOIN SYS_DICT_DTL@DL_SYS B    ON UPPER(A.WORD_ID) = UPPER(B.WORD_ID)    AND A.WORD_TYPE = B.WORD_TYPE   AND (B.CTRY_CD ='@CTRY' OR B.CTRY_CD IS NULL) WHERE 1=1   [SCR_ID]      AND A.WORD_DESC LIKE '%@SCR_ID%'   [/SCR_ID]ORDER BY A.WORD_ID
#SysDict@SqlId

#SysDict@updDetail
-- SysDict@updDetailUPDATE SYS_DICT_DTL@DL_SYS   SET WORD_NM  = '@WORD_NM'       ,UPD_USR  = '@UPD_USR'       ,UPD_DATE = SYSDATE WHERE WORD_ID = '@WORD_ID'   AND CTRY_CD = '@CTRY_CD'   AND WORD_TYPE = '@WORD_TYPE'	
#SysDict@updHeader
-- SysDict@updHeaderUPDATE SYS_DICT_MST@DL_SYS   SET WORD_NM   = '@WORD_NM'       ,WORD_DESC = '@WORD_DESC'       ,UPD_USR   = '@UPD_USR'       ,UPD_DATE  = SYSDATE WHERE WORD_TYPE = '@WORD_TYPE'   AND WORD_ID   = '@WORD_ID'	
#SysDict@updHeaderDesc
-- SysDict@updHeaderDescUPDATE SYS_DICT_MST@DL_SYS   SET WORD_DESC = WORD_DESC||','||'@WORD_DESC'		      ,UPD_USR   = '@UPD_USR' 
      ,UPD_DATE  = SYSDATE WHERE WORD_TYPE = '@WORD_TYPE'   AND WORD_ID = '@WORD_ID'   AND WORD_DESC NOT LIKE '%@WORD_DESC%'   AND LENGTH(WORD_DESC||','||'@WORD_DESC') <= 1000  --WORD_DESC store referenced forms. NOTE: while update reference, avoid exceed data length (140)

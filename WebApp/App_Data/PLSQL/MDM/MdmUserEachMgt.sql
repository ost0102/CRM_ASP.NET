#MdmUserEachMgt@Search
-- MdmUserEachMgt@SearchSELECT USR_ID	 , ENG_NM	 , LOC_NM	 , HP_NO	 , TEL_NO	 , FAX_NO	 , EMAIL  FROM CRM_USR_MST WHERE USR_ID = '@USR_ID' 
#MdmUserEachMgt@Update
-- MdmUserEachMgt@UpdateUPDATE CRM_USR_MST    SET ENG_NM = '@ENG_NM'     , LOC_NM = '@LOC_NM'    [PSWD]	 , PSWD = UNF_MD5_ENCRYPTION('@PSWD')    [/PSWD]     , HP_NO = '@HP_NO'     , TEL_NO = '@TEL_NO'     , FAX_NO = '@FAX_NO'     , EMAIL = '@EMAIL' WHERE USR_ID = '@USR_ID'

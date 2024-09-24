#CrmCustomerPicList@Search
-- CrmCustomerPicList@SearchSELECT DISTINCT        A.CUST_CD     , A.CUST_LOC_NM      , A.CRN     , B.PIC_NM     , C.CD_NM AS RANK     , B.EMAIL     , B.TEL_NO  FROM CRM_CUST_MST A     , CRM_CUST_PIC B       LEFT OUTER JOIN MDM_COM_CODE C               ON C.COMN_CD = B.RANK              AND C.GRP_CD = 'C10'  WHERE A.CUST_CD = B.CUST_CD         AND B.EMAIL IS NOT NULL
   AND A.USE_YN = 'Y'
   [SEARCH_KEY]
       AND (    (A.CUST_CD = '@SEARCH_KEY')
             OR (A.CUST_LOC_NM LIKE '%@SEARCH_KEY%') 
             OR (A.CRN LIKE '%@SEARCH_KEY%') 
            )  
   [/SEARCH_KEY]
   [SVC_CD]
       AND A.SVC_CD2 = '@SVC_CD'
   [/SVC_CD]
ORDER BY A.CUST_CD,B.PIC_NM

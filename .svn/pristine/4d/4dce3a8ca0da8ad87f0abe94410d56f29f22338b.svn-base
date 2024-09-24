#CrmARMgt@EmailTest
--CrmARMgt@EmailTestSELECT 'N' AS CHK_FLAG	 , RECEIVER	 , TANM	 , AMT	 , CHDATE  FROM TEST_EMAIL
#CrmARMgt@InsertEmailLog
--CrmARMgt@InsertEmailLogINSERT INTO CRM_MAIL_SEND(MAIL, SEQ, SENDER, RECEIVER,CUST_CD)VALUES('@MAIL', '@SEQ', '@SENDER', '@RECEIVER','@CUST_CD')
#CrmArMgt@Search
--CrmArMgt@SearchWITH AA AS (    SELECT TRIM(A.COCD) AS COCD         , SUM (CASE WHEN A.CHDATE < '@INV_YMD' THEN DEBIT ELSE 0 END -                 CASE WHEN A.CHDATE < '@AR_YMD' THEN CREDIT ELSE 0 END) AS AMT         , MAX (CASE WHEN A.CHDATE < '@INV_YMD' THEN CASE WHEN DEBIT = 0 THEN ' '                                                           ELSE CHDATE                                                      END                     ELSE CHDATE                END) AS TAXDT      FROM AC_CHIT2@DL_YJITEXP A     WHERE 1=1       AND A.ACTCD = '1115'       [COCD]       AND COCD = '@COCD'       [/COCD]      GROUP BY A.COCD),BB AS (    SELECT TRIM(CUST) AS CUST         , SUM (BILL_AMT + BILL_VAT) AS TAXAMT      FROM AC_CODE3@DL_YJITEXP     WHERE 1=1       AND SINGLEPUB = 'N'       [COCD]       AND CUST = '@COCD'       [/COCD]      GROUP BY CUST),CC AS (    SELECT CHDATE         , TRIM(COCD) AS COCD         , CREDIT      FROM AC_CHIT2@DL_YJITEXP     WHERE 1=1       AND ACTCD = '1115' AND CREDIT <> 0       AND RFNO || RFSEQ || SEQ IN ( SELECT MAX (RFNO || RFSEQ || SEQ)                                       FROM AC_CHIT2@DL_YJITEXP                                      WHERE ACTCD = '1115'                                        [AR_YMD]                                        AND CHDATE <= '@AR_YMD'                                        [/AR_YMD]                                        AND CREDIT <> 0                                      GROUP BY COCD )),EE AS (    SELECT MAIL         , CUST_CD      FROM CRM_MAIL_SEND      WHERE 1=1       [COCD]      AND CUST_CD = '@COCD'      [/COCD]),FF AS (    SELECT TRIM(CODE) CODE         , TANM         , E_MAIL         , TELNO       FROM CO_CUST2@DL_YJITEXP      WHERE TASEQ = '01')SELECT *		  FROM (		SELECT 'N' AS CHK_FLAG		     , REGNO 		     , AA.COCD 		     , NAME2		     , AMT 		     , TAXDT 		     , TAXAMT 		     , CHDATE 		     , CREDIT 		     , TANM 		     , FF.E_MAIL 		     , FF.TELNO 		     , ENDDT 		     , MAIL		  FROM AA 		       LEFT JOIN BB ON BB.CUST = AA.COCD		       LEFT JOIN CC ON CC.COCD = AA.COCD		       LEFT JOIN CO_CUSTOMER@DL_YJITEXP DD ON TRIM(DD.CODE) = AA.COCD		       LEFT JOIN EE ON EE.CUST_CD = AA.COCD 		       LEFT JOIN FF ON FF.CODE = AA.COCD		 WHERE 1=1		   AND '@FNS_YN' = 'Y'		   AND DD.ENDDT IS NOT NULL		   [SALES_CD]		   AND DD.SALESCD = '@SALES_CD'		   [/SALES_CD]
		   [UP_AMT]
		   AND TAXAMT >= @AR_AMT
		   [/UP_AMT]
		   [DOWN_AMT]
		   AND TAXAMT < @AR_AMT
		   [/DOWN_AMT]		UNION ALL		SELECT 'N' AS CHK_FLAG		     , REGNO 		     , AA.COCD 		     , NAME2		     , AMT 		     , TAXDT 		     , TAXAMT 		     , CHDATE 		     , CREDIT 		     , TANM 		     , FF.E_MAIL 		     , FF.TELNO 		     , ENDDT 		     , MAIL		  FROM AA 		       LEFT JOIN BB ON BB.CUST = AA.COCD		       LEFT JOIN CC ON CC.COCD = AA.COCD		       LEFT JOIN CO_CUSTOMER@DL_YJITEXP DD ON TRIM(DD.CODE) = AA.COCD		       LEFT JOIN EE ON EE.CUST_CD = AA.COCD 		       LEFT JOIN FF ON FF.CODE = AA.COCD		 WHERE '@FNS_YN' = 'N'		   AND DD.ENDDT IS NULL		   [SALES_CD]		   AND DD.SALESCD = '@SALES_CD'		   [/SALES_CD]
		   [UP_AMT]
		   AND TAXAMT >= @AR_AMT
		   [/UP_AMT]
		   [DOWN_AMT]
		   AND TAXAMT < @AR_AMT
		   [/DOWN_AMT]		UNION ALL		SELECT 'N' AS CHK_FLAG		     , REGNO 		     , AA.COCD 		     , NAME2		     , AMT 		     , TAXDT 		     , TAXAMT 		     , CHDATE 		     , CREDIT 		     , TANM 		     , FF.E_MAIL 		     , FF.TELNO  		     , ENDDT 		     , MAIL		  FROM AA 		       LEFT JOIN BB ON BB.CUST = AA.COCD		       LEFT JOIN CC ON CC.COCD = AA.COCD		       LEFT JOIN CO_CUSTOMER@DL_YJITEXP DD ON TRIM(DD.CODE) = AA.COCD		       LEFT JOIN EE ON EE.CUST_CD = AA.COCD 		       LEFT JOIN FF ON FF.CODE = AA.COCD		 WHERE '@FNS_YN' = 'A'		   [SALES_CD]		   AND DD.SALESCD = '@SALES_CD'		   [/SALES_CD]
		   [UP_AMT]
		   AND TAXAMT >= @AR_AMT
		   [/UP_AMT]
		   [DOWN_AMT]
		   AND TAXAMT < @AR_AMT
		   [/DOWN_AMT]		 ) ORDER BY TAXDT DESC
#CrmARMgt@SearchEmaillog
--CrmARMgt@SearchEmaillogSELECT *   FROM CRM_MAIL_SEND WHERE CUST_CD = '@CUST_CD'
#CrmARMgt@SeqMake
--CrmARMgt@SeqMakeSELECT LPAD(NVL(MAX(NVL(SEQ,0)),0) + 1,4,'0') AS SEQ   FROM CRM_MAIL_SEND
#CrmARMgt@UpdateEmailLog
--CrmARMgt@UpdateLogUPDATE CRM_MAIL_SEND   SET MAIL = '@MAIL'       ,SEQ = '@SEQ'        ,RECEIVER = '@RECEIVER' WHERE CUST_CD = '@CUST_CD'

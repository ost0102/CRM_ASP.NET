#CodeService@AdjustmentReason
--CodeService@AdjustmentReason
SELECT CODE	 , NAME  FROM (		SELECT '' AS CODE			 , '--Select--' AS NAME			 , 0 AS SEQ		  FROM DUAL		UNION ALL  		[TYPE]		SELECT OPT_ITEM1 AS CODE			 , OPT_ITEM2 AS NAME		[/TYPE]		[DETAIL]		SELECT COMN_CD AS CODE			 , CD_NM   AS NAME		[/DETAIL]		     , 1 AS SEQ		  FROM MDM_COM_CODE		 WHERE GRP_CD = 'W10'		[TYPE]		 GROUP BY OPT_ITEM1		 		, OPT_ITEM2		[/TYPE]		[DETAIL]		   AND OPT_ITEM1 = '@KEY'		 ORDER BY CODE		[/DETAIL]		)ORDER BY SEQ

/*[TYPE]SELECT OPT_ITEM1 AS CODE	 , OPT_ITEM2 AS NAME[/TYPE][DETAIL]SELECT COMN_CD AS CODE	 , CD_NM   AS NAME[/DETAIL]  FROM MDM_COM_CODE WHERE GRP_CD = 'W10'[TYPE] GROUP BY OPT_ITEM1 		, OPT_ITEM2[/TYPE][DETAIL]   AND OPT_ITEM1 = '@KEY' ORDER BY COMN_CD[/DETAIL]*/
#CodeService@Building
--CodeService@BuildingSELECT BD_CD AS CODE	 , BD_NM AS NAME  FROM WMS_BUILDING WHERE WH_CD = '@KEY' ORDER BY BD_CD	
#CodeService@CustomerByType
--CodeService@CustomerByTypeSELECT A.CODE     , A.NAME     , A.CUST_LOCNM     , A.OFFICE_ADDR     , A.ENG_ADDR     , A.CRN     , A.CUST_GRP_CD     , A.CURR_CD     , A.BL_ADDR     , A.CEO     , A.BIZCOND     , A.BIZTYPE     , NVL(A.JOB_TYPE,'ZZ') AS JOB_TYPE     , A.USE_YN     , A.BL_ADDR_NAME     , A.RMK     , A.LOC_FRGN_TYPE     , A.CTRY_CD     , A.FAX     , A.LOC_AMT_ROUND_RULE     , A.VAT_AMT_ROUND_RULE  FROM (SELECT A.CUST_CD         AS CODE	     	 , A.CUST_NM         AS NAME	     	 , UFN_LOCAL_NAME('@LANG_CD',A.CUST_CD,'C01','',A.CUST_NM,'','','') AS CUST_LOCNM	     	 , UFN_LOCAL_NAME('@LANG_CD',A.CUST_CD,'C02','',A.ENG_ADDR,'','','') AS OFFICE_ADDR	     	 , A.ENG_ADDR        AS ENG_ADDR	     	 , A.CRN             AS CRN	     	 , A.CUST_GRP_CD     AS CUST_GRP_CD	     	 , A.CURR_CD         AS CURR_CD	     	 , A.BL_ADDR         AS BL_ADDR	     	 , A.CEO             AS CEO	     	 , A.BIZCOND         AS BIZCOND	     	 , A.JOB_TYPE        AS JOB_TYPE	     	 , A.BIZTYPE         AS BIZTYPE	     	 , A.USE_YN          AS USE_YN	     	 , A.CUST_NM || CHR(13)|| CHR(10) || NVL(A.BL_ADDR,'') AS BL_ADDR_NAME	     	 , A.RMK             AS RMK	     	 , DECODE(A.CTRY_CD,'@CTRY_CD','L','F') AS LOC_FRGN_TYPE	     	 , A.CTRY_CD         AS CTRY_CD	     	 , A.FAX_NO          AS FAX	     	 , NVL(A.LOC_AMT_ROUND_RULE,'N') AS LOC_AMT_ROUND_RULE	     	 , NVL(A.VAT_AMT_ROUND_RULE,'N') AS VAT_AMT_ROUND_RULE	      FROM MDM_CUST_MST A	  		 , MDM_CUST_TYPE B	 	 WHERE A.USE_YN = 'Y'	  	   AND A.CUST_CD = B.CUST_CD[CUST_TYPE]	  	   AND B.CUST_TYPE = '@TYPE'[/CUST_TYPE][VALIDATE]           AND A.CUST_CD = '@KEY' [/VALIDATE]) A WHERE 1=1 	   [SEARCH]	   AND (A.CODE  LIKE '%@KEY%'     OR A.NAME  LIKE '%@KEY%'        OR A.CUST_LOCNM || A.NAME LIKE '%@KEY%'     OR A.OFFICE_ADDR LIKE '%@KEY%'      OR A.CRN      LIKE '%@KEY%'              OR A.ENG_ADDR LIKE '%@KEY%'             OR A.CEO      LIKE '%@KEY%'             OR A.CTRY_CD  LIKE '%@KEY%'     )[/SEARCH] ORDER BY A.CODE  			
#CodeService@EQ
--CodeService@EQSELECT CODE	 , NAME	 , EQ_SIZE  FROM MDM_EQ[SEARCH]   WHERE CODE || NAME LIKE '%@KEY%'[/SEARCH][VALIDATE]	 WHERE CODE = '@KEY'[/VALIDATE]
#CodeService@Grade
--CodeService@GradeSELECT NVL(GRADE,'')  	  AS CODE     , NVL(GRADE_DESC,'') AS NAME  FROM WMS_WH_GRADE WHERE WH_CD = '@WH_CD'  ORDER BY CODE 
#CodeService@InventoryHistoryType
--CodeService@InventoryHistoryTypeSELECT '00'      AS CODE	 , '--All--' AS NAME  FROM DUAL UNION ALLSELECT COMN_CD   AS CODE	 , OPT_ITEM1 AS NAME  FROM MDM_COM_CODE WHERE GRP_CD = 'W08'
#CodeService@Location
--CodeService@LocationSELECT LOC_CD AS CODE	 , LOC_CD AS NAME   FROM WMS_LOC  WHERE WH_CD = '@WH_CD'[LOCATION_ALL]   AND LOC_CD LIKE '%@LOC_CD%' [/LOCATION_ALL][LOCATION]   AND LOC_CD NOT IN(SELECT NVL(LOC_CD, 'N')     				   FROM WMS_INVENTORY     				  WHERE WH_CD = '@WH_CD')[/LOCATION][VALIDATE]   AND LOC_CD = '@LOC_CD' [/VALIDATE]  ORDER BY LOC_CD ASC   
#CodeService@Shipto
--CodeService@ShiptoSELECT SHIPTO_CD AS CODE	 , SHIPTO_DESC AS NAME	 , SHIPTO_ADDR AS ADDR  FROM MDM_SHIPTO WHERE WHCD = '@WHCD'[SEARCH]    AND SHIPTO_CD || SHIPTO_DESC LIKE '%@KEY%'[/SEARCH]  [VALIDATE]   AND SHIPTO_CD = '@KEY'[/VALIDATE]           
#CodeService@SKU
--CodeService@SKUSELECT SKU_CD AS CODE     , SKU_NM AS NAME     , SKU_ENG_NM AS ENG_NAME  FROM WMS_SKU WHERE 1=1[SEARCH]   AND SKU_CD || SKU_NM LIKE '%@KEY%'[/SEARCH] [VALIDATE]   AND SKU_CD = '@KEY'[/VALIDATE] ORDER BY SKU_CD
#CodeService@SKUByCustomerWarehouse
--CodeService@SKUByCustomerWarehouseSELECT SKU_CD AS CODE     , SKU_NM AS NAME     , SKU_ENG_NM AS ENG_NAME  FROM WMS_SKU WHERE SKU_CD IN (SELECT SKU_CD     				FROM WMS_WH_SKU     			   WHERE WH_CD = '@WH_CD')   AND SKU_CD IN (SELECT SKU_CD     				FROM WMS_CUST_SKU     			   WHERE CUST_CD = '@CUST_CD')[SEARCH]   AND SKU_CD || SKU_NM LIKE '%@KEY%'[/SEARCH]    			   [VALIDATE]   AND SKU_CD = '@KEY'[/VALIDATE]			    ORDER BY SKU_CD      
#CodeService@SKUByPackage
--CodeService@SKUByPackageSELECT COM.COMN_CD AS CODE     , COM.CD_NM   AS NAME  FROM MDM_COM_CODE COM     , WMS_SKU SKU WHERE COM.GRP_CD = '@GRP_CD'   AND (COM.COMN_CD = SKU.M_UNIT OR COM.COMN_CD = SKU.L_UNIT)   AND SKU.SKU_CD = '@SKU_CD'
#CodeService@Truck
--CodeService@TruckSELECT COMN_CD 	 AS CODE	 , CD_NM 	 AS NAME	 , OPT_ITEM1 AS MSRMT	 , OPT_ITEM2 AS GRS_WGT  FROM MDM_COM_CODE WHERE GRP_CD = 'W02'
#CodeService@VersionBySKU
--CodeService@VersionBySKUSELECT VERSION_CD AS CODE     , VERSION_NM AS NAME  FROM WMS_SKU_VERSION WHERE SKU_CD = '@SKU_CD'[SEARCH]   AND VERSION_CD || VERSION_NM LIKE '%@KEY%'[/SEARCH]    			   [VALIDATE]   AND VERSION_CD = '@KEY'[/VALIDATE]			    ORDER BY VERSION_CD
#CodeService@WarehouseAll
--CodeService@WarehouseAll  SELECT WH_CD AS CODE       , WH_NM AS NAME    FROM WMS_WAREHOUSEORDER BY WH_CD
#CodeService@WarehouseByUser
--CodeService@WarehouseByUserSELECT WH_CD AS CODE     , WH_NM AS NAME  FROM WMS_WAREHOUSE WHERE WH_CD IN (SELECT WH_CD                    FROM WMS_USER_WH                   WHERE USR_ID = '@USR_ID')ORDER BY WH_CD
#CodeService@WMSFreight
--CodeService@WMSFreightSELECT FRT_CD AS CODE	 , FRT_NM AS NAME  FROM WMS_FREIGHT_CODE WHERE AIR_SEA_CLS = 'W'[SEARCH]   AND FRT_CD || FRT_NM LIKE '%@KEY%'[/SEARCH][VALIDATE]   AND FRT_CD = '@KEY'[/VALIDATE]	
#CodeService@Zone
--CodeService@ZoneSELECT ZONE_CD AS CODE 	 , ZONE_NM AS NAME  FROM WMS_ZONE WHERE WH_CD = '@KEY'   AND BD_CD = '@BD_CD' ORDER BY ZONE_CD

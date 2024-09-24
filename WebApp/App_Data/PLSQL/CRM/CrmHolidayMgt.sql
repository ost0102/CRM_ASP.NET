#CrmHolidayMgt@Delete
--CrmHolidayMgt@Delete DELETE CRM_HOLIDAYS WHERE HD_YMD ='@HD_YMD'
#CrmHolidayMgt@Insert
-- CrmHolidayMgt@Insert	INSERT INTO CRM_HOLIDAYS (		  HD_YMD		, RMK		, CHANGE_YN		, INS_USR		, INS_YMD		, INS_HM		, UPD_USR		, UPD_YMD		, UPD_HM	) VALUES (	       '@HD_YMD'	     , '@RMK'         , '@CHANGE_YN'         , '@USR_ID'		 , TO_CHAR(SYSDATE,'yyyyMMdd')		 , TO_CHAR(SYSDATE,'HH24MISS')		 , '@USR_ID'		 , TO_CHAR(SYSDATE,'yyyyMMdd')		 , TO_CHAR(SYSDATE,'HH24MISS')	)
#CrmHolidayMgt@Search
--CrmHolidayMgt@SearchSELECT A.HD_YMD     , A.RMK     , A.CHANGE_YN     , (SELECT LOC_NM FROM CRM_USR_MST U WHERE U.USR_ID = A.INS_USR) AS INS_USR     , UFN_FORMAT(A.INS_YMD,'DATE')||' '||UFN_FORMAT(A.INS_HM,'TIME') AS INS_DATE     , (SELECT LOC_NM FROM CRM_USR_MST U WHERE U.USR_ID = A.UPD_USR) AS UPD_USR     , UFN_FORMAT(A.UPD_YMD,'DATE')||' '||UFN_FORMAT(A.UPD_HM,'TIME') AS UPD_DATE  FROM CRM_HOLIDAYS A WHERE 1=1       [HD_FM_YMD] AND HD_YMD >= '@HD_FM_YMD' [/HD_FM_YMD]        [HD_TO_YMD] AND HD_YMD <= '@HD_TO_YMD' [/HD_TO_YMD] 
       [HD_YMD] AND HD_YMD = '@HD_YMD' [/HD_YMD]
#CrmHolidayMgt@Update
--CrmHolidayMgt@UpdateUPDATE CRM_HOLIDAYS   SET UPD_USR   = '@USR_ID'	 , UPD_YMD   = TO_CHAR(SYSDATE,'yyyyMMdd')	 , UPD_HM    = TO_CHAR(SYSDATE,'HH24MISS')     , RMK='@RMK' 	 , CHANGE_YN='@CHANGE_YN'  WHERE HD_YMD   = '@HD_YMD'

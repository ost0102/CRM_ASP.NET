#SysWcfLog@Insert
--SysWcfLog@InsertINSERT INTO SYS_WCF_LOG            (WCF_ID           ,PARAMS_DS           ,PARAMS_STR           ,START_YMDHM           ,END_YMDHM           ,RES_HM           ,RTN_CD           ,RTN_MSG           ,RTN_DATA           ,OFFICE_CD           ,INS_USR
   ) VALUES (
             :WCF_ID            ,:PARAMS_DS            ,SUBSTR(:PARAMS_STR,1,4000)            ,:START_YMDHM            ,:END_YMDHM            ,:RES_HM            ,:RTN_CD            ,:RTN_MSG            ,:RTN_DATA            ,:OFFICE_CD            ,:INS_USR
   )
#SysWcfLog@Insert_20200723
--SysWcfLog@InsertDECLARE  V_CLOB_DS CLOB := TO_CLOB('@PARAMS_DS');  V_CLOB_DATA CLOB := TO_CLOB('@RTN_DATA');BEGININSERT INTO SYS_WCF_LOG            (WCF_ID           ,PARAMS_DS           ,PARAMS_STR           ,START_YMDHM           ,END_YMDHM           ,RES_HM           ,RTN_CD           ,RTN_MSG           ,RTN_DATA           ,OFFICE_CD           ,INS_USR)     VALUES ('@WCF_ID'            ,'<V_CLOB_DS>'||V_CLOB_DS||'</V_CLOB_DS>'            ,SUBSTR('@PARAMS_STR',1,4000)            ,'@START_YMDHM'            ,'@END_YMDHM'            ,@RES_HM            ,'@RTN_CD'            ,'@RTN_MSG'            ,'<V_CLOB_DATA>'||V_CLOB_DATA||'</V_CLOB_DATA>'            ,'@OFFICE_CD'            ,'@INS_USR');  COMMIT;END;

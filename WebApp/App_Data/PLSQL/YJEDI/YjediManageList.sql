#YjediManageList@Search
--YjediManageList@SearchSELECT A.EDI_ID     , A.TRANS_TYPE     , A.CUSTOMS_CD     , A.SYS_ID     , A.SPEC_CD     , A.SPEC_VER     , A.SEND_ID     , A.RECV_ID     , A.FUNC_TYPE     , A.DOC_NO     , A.SEND_CNT     , A.UPPER_EDI_ID     , A.REQ_SVC     , A.MNGT_NO     , A.RMK     , A.FILE_NM     , A.IS_CONFIRMED     , TO_CHAR(TO_DATE(A.CREATE_YMDHM, 'YYYYMMDD hh24:mi:ss'), 'YYYY-MM-DD hh24:mi:ss') AS CREATE_YMDHM     , TO_CHAR(TO_DATE(A.SEND_YMDHM,'YYYYMMDD hh24:mi:ss'), 'YYYY-MM-DD hh24:mi:ss') AS SEND_YMDHM     , A.IS_VALID     , A.ACK_ID     , A.PIC_ACK_ID     , UFN_TABLE_ITEM('USER_NM',A.INS_USR,'L','') AS INS_USR     , TO_CHAR(TO_DATE(A.INS_YMD,'YYYYMMDD'),'YYYY-MM-DD') || ' ' ||       TO_CHAR(TO_DATE(A.INS_HM,'hh24miss'), 'hh24:mi:ss') AS INS_YMD     , UFN_TABLE_ITEM('USER_NM',A.UPD_USR,'L','') AS UPD_USR     , TO_CHAR(TO_DATE(A.UPD_YMD,'YYYYMMDD'),'YYYY-MM-DD') || ' ' ||       TO_CHAR(TO_DATE(A.UPD_HM,'hh24miss'), 'hh24:mi:ss') AS UPD_YMD  FROM YJEDI_MANAGE A WHERE 1 = 1 [EDI_ID]   AND EDI_ID = '@EDI_ID' [/EDI_ID] [FM_YMD]   AND A.SEND_YMDHM >= '@FM_YMD' [/FM_YMD] [TO_YMD]   AND A.SEND_YMDHM <= '@TO_YMD' [/TO_YMD] ORDER BY SEND_YMDHM DESC, EDI_ID DESC
#YjediManageList@SearchChk
--YjediManageList@SearchChkSELECT A.EDI_ID AS EDI_ID  FROM YJEDI_MANAGE A WHERE 1 = 1   AND A.EDI_ID = '@EDI_ID'

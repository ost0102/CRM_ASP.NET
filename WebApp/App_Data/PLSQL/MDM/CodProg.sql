#CodProg@CHK
-- CodProg@CHKSelect *	From SYS_PROGRAMWhere 	SYS_ID = '@SYS_ID' 	And PGM_ID = '@PGM_ID' 	And FUNC_ID = '@FUNC_ID'
#CodProg@DEL
-- CodProg@DELDelete SYS_PROGRAMWhere	SYS_ID = '@SYS_ID'	And PGM_ID = '@PGM_ID'	And FUNC_ID = '@FUNC_ID'	
#CodProg@GET_GRP_ID
-- CodProg@GET_GRP_IDSelect PGM_GRPFrom SYS_PROGRAMWhere SYS_ID = '@SYS_ID'   AND PGM_ID = '@PGM_ID'   AND FUNC_ID = '@FUNC_ID' 
#CodProg@INS
-- CodProg@INSInsert Into SYS_PROGRAM(	SYS_ID,	PGM_ID,	FUNC_ID,	PGM_NM,	PGM_TYPE,	PGM_GRP,	DLL_NAME,	INS_USR,	INS_DATE)Values (	'@SYS_ID',	'@PGM_ID',	'@FUNC_ID',	'@PGM_NM',	'@PGM_TYPE',	'@PGM_GRP',	'@DLL_NAME',	'@INS_USR',	SYSDATE)
#CodProg@SEARCH
-- CodProg@SEARCHSelect SYS_ID, 	PGM_ID, 	FUNC_ID, 	PGM_NM, 	PGM_TYPE, 	PGM_GRP,	DLL_NAMEFrom SYS_PROGRAMWhere 	SYS_ID = '@SYS_ID' 	[PGM_GRP]	AND PGM_GRP LIKE '@PGM_GRP%'	[/PGM_GRP]	[PGM_ID]	AND PGM_ID LIKE '@PGM_ID%'	[/PGM_ID]ORDER BY SYS_ID,PGM_GRP,PGM_ID,DECODE(PGM_TYPE,'P','1','2'),FUNC_ID
#CodProg@UPD
-- CodProg@UPDUpdate SYS_PROGRAMSet 	PGM_NM='@PGM_NM',	PGM_TYPE='@PGM_TYPE',	PGM_GRP='@PGM_GRP',	DLL_NAME='@DLL_NAME',	UPD_USR='@UPD_USR',	UPD_DATE= SYSDATEWhere	SYS_ID = '@SYS_ID'	And PGM_ID = '@PGM_ID'	And FUNC_ID = '@FUNC_ID'	

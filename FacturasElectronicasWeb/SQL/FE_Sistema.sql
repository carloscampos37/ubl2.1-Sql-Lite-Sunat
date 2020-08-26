/*

 Insertando un registro En FE_Sistema

*/
CREATE PROC FE_Sistema_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@CorrelativoComprobImpreso	varchar(20)='0',
@CorrelativoComunicacionBaja	varchar(20)='0',
@Corrrelativodocumentoelectronico	varchar(20)='0',
@CorrrelativoResumenDiario	varchar(20)='0',
@Empresacodigo	varchar(3)='',
@EsquemaInafecto	varchar(1)='0',
@FechaAct	varchar(25)='01/01/1900'

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_Sistema (CorrelativoComprobImpreso,	CorrelativoComunicacionBaja,	Corrrelativodocumentoelectronico,	CorrrelativoResumenDiario,	
	Empresacodigo,	EsquemaInafecto,	FechaAct
 )
	 VALUES('+@CorrelativoComprobImpreso+',	'+@CorrelativoComunicacionBaja+',	'+@Corrrelativodocumentoelectronico+',	'+@CorrrelativoResumenDiario+',	
	'''+@Empresacodigo+''',	'+@EsquemaInafecto+',	'''+@FechaAct+''')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_Sistema SET 
	CorrelativoComprobImpreso='+@CorrelativoComprobImpreso+',
	CorrelativoComunicacionBaja='+@CorrelativoComunicacionBaja+',
	Corrrelativodocumentoelectronico='+@Corrrelativodocumentoelectronico+',
	CorrrelativoResumenDiario='+@CorrrelativoResumenDiario+',
	EsquemaInafecto='+@EsquemaInafecto+',
	FechaAct='''+@FechaAct+'''

	 WHERE Empresacodigo='''+@Empresacodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  CorrelativoComprobImpreso,	CorrelativoComunicacionBaja,	Corrrelativodocumentoelectronico,	CorrrelativoResumenDiario,	
	Empresacodigo,	EsquemaInafecto,	FechaAct

	 FROM '+@base+'.dbo.FE_Sistema'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

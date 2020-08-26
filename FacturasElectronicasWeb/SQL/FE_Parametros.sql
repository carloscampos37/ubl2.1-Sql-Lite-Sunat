/*

 Insertando un registro En FE_Parametros

*/
CREATE PROC FE_Parametros_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@CodigoProductoUnico	varchar(1)='0',
@ConsolidaPtosVtasFE	varchar(1)='0',
@EmpresaCodigo	varchar(3)='',
@ImporteMinimoDni	varchar(20)='0'

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_Parametros (CodigoProductoUnico,	ConsolidaPtosVtasFE,	EmpresaCodigo,	ImporteMinimoDni

	 )
	 VALUES('+@CodigoProductoUnico+',	'+@ConsolidaPtosVtasFE+',	'''+@EmpresaCodigo+''',	'+@ImporteMinimoDni+'	
)  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_Parametros SET 
	CodigoProductoUnico='+@CodigoProductoUnico+',
	ConsolidaPtosVtasFE='+@ConsolidaPtosVtasFE+',
	ImporteMinimoDni='+@ImporteMinimoDni+'

	 WHERE EmpresaCodigo='''+@EmpresaCodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  CodigoProductoUnico,	ConsolidaPtosVtasFE,	EmpresaCodigo,	ImporteMinimoDni

	
	 FROM '+@base+'.dbo.FE_Parametros'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

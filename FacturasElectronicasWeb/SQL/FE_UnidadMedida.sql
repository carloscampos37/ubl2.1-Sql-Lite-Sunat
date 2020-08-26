/*

 Insertando un registro En FE_UnidadMedida

*/
CREATE PROC FE_UnidadMedida_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@EquivalenciaSunat	varchar(10)='',
@EstadoAnulado	varchar(1)='0',
@UnidadDescripcion	varchar(50)='',
@UnidadMedida_id	varchar(10)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_UnidadMedida (EquivalenciaSunat,	EstadoAnulado,	UnidadDescripcion,	UnidadMedida_id

	 )
	 VALUES('''+@EquivalenciaSunat+''',	'+@EstadoAnulado+',	'''+@UnidadDescripcion+''',	'''+@UnidadMedida_id+'''	
)  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_UnidadMedida SET 
	EquivalenciaSunat='''+@EquivalenciaSunat+''',
	EstadoAnulado='+@EstadoAnulado+',
	UnidadDescripcion='''+@UnidadDescripcion+''',
	
	 WHERE UnidadMedida_id='''+@UnidadMedida_id+'''


	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  EquivalenciaSunat,	EstadoAnulado,	UnidadDescripcion,	UnidadMedida_id

	
	 FROM '+@base+'.dbo.FE_UnidadMedida'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

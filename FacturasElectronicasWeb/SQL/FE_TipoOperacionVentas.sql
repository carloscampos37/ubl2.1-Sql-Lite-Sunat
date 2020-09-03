/*

 Insertando un registro En FE_TipoOperacionVentas

*/
CREATE PROC FE_TipoOperacionVentas_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@TipoOperacionCodigo	varchar(2)='',
@TipoOperacionDescripcion	varchar(50)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_TipoOperacionVentas (TipoOperacionCodigo,	TipoOperacionDescripcion
 )
	 VALUES('''+@TipoOperacionCodigo+''',	'''+@TipoOperacionDescripcion+''')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_TipoOperacionVentas SET 
	TipoOperacionDescripcion='''+@TipoOperacionDescripcion+'''

	 WHERE TipoOperacionCodigo='''+@TipoOperacionCodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  TipoOperacionCodigo,	TipoOperacionDescripcion

	 FROM '+@base+'.dbo.FE_TipoOperacionVentas'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

/*

 Insertando un registro En FE_TipoImpuesto

*/
CREATE PROC FE_TipoImpuesto_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@EstadoAnulado	varchar(1)='0',
@TipoImpuestoCodigo	varchar(2)='',
@TipoImpuestoDescripcion	varchar(50)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_TipoImpuesto (EstadoAnulado,	TipoImpuestoCodigo,	TipoImpuestoDescripcion
 )
	 VALUES('+@EstadoAnulado+',	'''+@TipoImpuestoCodigo+''',	'''+@TipoImpuestoDescripcion+''')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_TipoImpuesto SET 
	EstadoAnulado='+@EstadoAnulado+',
	TipoImpuestoDescripcion='''+@TipoImpuestoDescripcion+'''

	 WHERE TipoImpuestoCodigo='''+@TipoImpuestoCodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  EstadoAnulado,	TipoImpuestoCodigo,	TipoImpuestoDescripcion

	 FROM '+@base+'.dbo.FE_TipoImpuesto'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

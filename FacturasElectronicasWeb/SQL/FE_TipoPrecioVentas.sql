/*

 Insertando un registro En FE_TipoPrecioVentas

*/
CREATE PROC FE_TipoPrecioVentas_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@EstadoAnulado	varchar(1)='0',
@TipoPrecioCodigo	varchar(2)='',
@TipoPrecioDescripcion	varchar(100)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_TipoPrecioVentas (EstadoAnulado,	TipoPrecioCodigo,	TipoPrecioDescripcion
 )
	 VALUES('+@EstadoAnulado+',	'''+@TipoPrecioCodigo+''',	'''+@TipoPrecioDescripcion+''')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_TipoPrecioVentas SET 
	EstadoAnulado='+@EstadoAnulado+',
	TipoPrecioCodigo='''+@TipoPrecioCodigo+''',
	TipoPrecioDescripcion='''+@TipoPrecioDescripcion+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  EstadoAnulado,	TipoPrecioCodigo,	TipoPrecioDescripcion

	 FROM '+@base+'.dbo.FE_TipoPrecioVentas'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

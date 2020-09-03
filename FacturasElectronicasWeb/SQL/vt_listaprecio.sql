/*

 Insertando un registro En vt_listaprecio

*/
CREATE PROC vt_listaprecio_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@fechaact	varchar(25)='01/01/1900',
@productocodigo	varchar(8)='',
@productodescripcion	varchar(80)='',
@productoprecvta	varchar(20)='0',
@productoprecvtaofi	varchar(20)='0',
@productoprecvtareparto	varchar(20)='0',
@usuariocodigo	varchar(8)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.vt_listaprecio (fechaact,	productocodigo,	productodescripcion,	productoprecvta,	
	productoprecvtaofi,	productoprecvtareparto,	usuariocodigo
 )
	 VALUES('''+@fechaact+''',	'''+@productocodigo+''',	'''+@productodescripcion+''',	'+@productoprecvta+',	
	'+@productoprecvtaofi+',	'+@productoprecvtareparto+',	'''+@usuariocodigo+''')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.vt_listaprecio SET 
	fechaact='''+@fechaact+''',
	productocodigo='''+@productocodigo+''',
	productodescripcion='''+@productodescripcion+''',
	productoprecvta='+@productoprecvta+',
	productoprecvtaofi='+@productoprecvtaofi+',
	productoprecvtareparto='+@productoprecvtareparto+',
	usuariocodigo='''+@usuariocodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  fechaact,	productocodigo,	productodescripcion,	productoprecvta,	
	productoprecvtaofi,	productoprecvtareparto,	usuariocodigo

	 FROM '+@base+'.dbo.vt_listaprecio'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

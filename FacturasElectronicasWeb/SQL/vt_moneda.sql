/*

 Insertando un registro En vt_moneda

*/
CREATE PROC vt_moneda_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@fechaact	varchar(25)='01/01/1900',
@monedacodigo	varchar(2)='',
@monedadescripcion	varchar(20)='',
@monedasimbolo	varchar(2)='',
@usuariocodigo	varchar(8)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.vt_moneda (fechaact,	monedacodigo,	monedadescripcion,	monedasimbolo,	
	usuariocodigo
 )
	 VALUES('''+@fechaact+''',	'''+@monedacodigo+''',	'''+@monedadescripcion+''',	'''+@monedasimbolo+''',	
	'''+@usuariocodigo+''')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.vt_moneda SET 
	fechaact='''+@fechaact+''',
	monedacodigo='''+@monedacodigo+''',
	monedadescripcion='''+@monedadescripcion+''',
	monedasimbolo='''+@monedasimbolo+''',
	usuariocodigo='''+@usuariocodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  fechaact,	monedacodigo,	monedadescripcion,	monedasimbolo,	
	usuariocodigo

	 FROM '+@base+'.dbo.vt_moneda'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

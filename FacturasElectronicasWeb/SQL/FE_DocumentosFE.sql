/*

 Insertando un registro En FE_DocumentosFE

*/
CREATE PROC FE_DocumentosFE_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@documentocodigo	varchar(2)='',
@documentodescripcion	varchar(30)='',
@EstadoAnulado	varchar(1)='0',
@fechaact	varchar(25)='01/01/1900',
@TipoEnvio_id	varchar(20)='0',
@usuariocodigo	varchar(8)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_DocumentosFE (documentocodigo,	documentodescripcion,	EstadoAnulado,	fechaact,	
	TipoEnvio_id,	usuariocodigo
 )
	 VALUES('''+@documentocodigo+''',	'''+@documentodescripcion+''',	'+@EstadoAnulado+',	'''+@fechaact+''',	
	'+@TipoEnvio_id+',	'''+@usuariocodigo+''')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_DocumentosFE SET 
	documentodescripcion='''+@documentodescripcion+''',
	EstadoAnulado='+@EstadoAnulado+',
	fechaact='''+@fechaact+''',
	TipoEnvio_id='+@TipoEnvio_id+',
	usuariocodigo='''+@usuariocodigo+'''

	 WHERE documentocodigo='''+@documentocodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  documentocodigo,	documentodescripcion,	EstadoAnulado,	fechaact,	
	TipoEnvio_id,	usuariocodigo

	 FROM '+@base+'.dbo.FE_DocumentosFE'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

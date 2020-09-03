/*

 Insertando un registro En VT_Documento

*/
CREATE PROC VT_Documento_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@CodigoSunat	varchar(2)='',
@DocumentoCodigo	varchar(2)='',
@documentodescrcorta	varchar(15)='',
@documentodescripcion	varchar(30)='',
@documentoregventas	varchar(1)='0',
@DocumentoResumenSunat	varchar(1)='0',
@documentotipo	varchar(1)='',
@documentovalidaruc	varchar(1)='0',
@fechaact	varchar(25)='01/01/1900',
@TipoEnvio_Id	varchar(20)='0',
@usuariocodigo	varchar(8)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.VT_Documento (CodigoSunat,	DocumentoCodigo,	documentodescrcorta,	documentodescripcion,	
	documentoregventas,	DocumentoResumenSunat,	documentotipo,	documentovalidaruc,	
	fechaact,	TipoEnvio_Id,	usuariocodigo
 )
	 VALUES('''+@CodigoSunat+''',	'''+@DocumentoCodigo+''',	'''+@documentodescrcorta+''',	'''+@documentodescripcion+''',	
	'+@documentoregventas+',	'+@DocumentoResumenSunat+',	'''+@documentotipo+''',	'+@documentovalidaruc+',	
	'''+@fechaact+''',	'+@TipoEnvio_Id+',	'''+@usuariocodigo+''')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.VT_Documento SET 
	CodigoSunat='''+@CodigoSunat+''',
	documentodescrcorta='''+@documentodescrcorta+''',
	documentodescripcion='''+@documentodescripcion+''',
	documentoregventas='+@documentoregventas+',
	DocumentoResumenSunat='+@DocumentoResumenSunat+',
	documentotipo='''+@documentotipo+''',
	documentovalidaruc='+@documentovalidaruc+',
	fechaact='''+@fechaact+''',
	TipoEnvio_Id='+@TipoEnvio_Id+',
	usuariocodigo='''+@usuariocodigo+'''

	 WHERE DocumentoCodigo='''+@DocumentoCodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  CodigoSunat,	DocumentoCodigo,	documentodescrcorta,	documentodescripcion,	
	documentoregventas,	DocumentoResumenSunat,	documentotipo,	documentovalidaruc,	
	fechaact,	TipoEnvio_Id,	usuariocodigo

	 FROM '+@base+'.dbo.VT_Documento'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

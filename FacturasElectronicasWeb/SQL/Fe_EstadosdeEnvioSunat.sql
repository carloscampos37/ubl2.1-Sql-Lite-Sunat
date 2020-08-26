/*

 Insertando un registro En Fe_EstadosdeEnvioSunat

*/
CREATE PROC Fe_EstadosdeEnvioSunat_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@EstadoAnulado	varchar(1)='0',
@EstadoEnvioCierre	varchar(1)='0',
@EstadoEnvioDescripcion	varchar(30)='',
@EstadoEnvioSunat_id	varchar(20)='0'

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.Fe_EstadosdeEnvioSunat (EstadoAnulado,	EstadoEnvioCierre,	EstadoEnvioDescripcion,	EstadoEnvioSunat_id

	 )
	 VALUES('+@EstadoAnulado+',	'+@EstadoEnvioCierre+',	'''+@EstadoEnvioDescripcion+''',	'+@EstadoEnvioSunat_id+'	
)  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.Fe_EstadosdeEnvioSunat SET 
	EstadoAnulado='+@EstadoAnulado+',
	EstadoEnvioCierre='+@EstadoEnvioCierre+',
	EstadoEnvioDescripcion='''+@EstadoEnvioDescripcion+''',
	
	 WHERE EstadoEnvioSunat_id='+@EstadoEnvioSunat_id+'

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  EstadoAnulado,	EstadoEnvioCierre,	EstadoEnvioDescripcion,	EstadoEnvioSunat_id

	
	 FROM '+@base+'.dbo.Fe_EstadosdeEnvioSunat'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

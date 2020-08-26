/*

 Insertando un registro En FE_TipoEnvioSunat

*/
CREATE PROC FE_TipoEnvioSunat_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@TipoEnvio_Id	varchar(20)='0',
@TipoEnvioDescripcion	varchar(50)='',
@WebService	varchar(50)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_TipoEnvioSunat (TipoEnvio_Id,	TipoEnvioDescripcion,	WebService
 )
	 VALUES('+@TipoEnvio_Id+',	'''+@TipoEnvioDescripcion+''',	'''+@WebService+''')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_TipoEnvioSunat SET 
	TipoEnvioDescripcion='''+@TipoEnvioDescripcion+''',
	WebService='''+@WebService+'''

	 WHERE TipoEnvio_Id='+@TipoEnvio_Id+'

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  TipoEnvio_Id,	TipoEnvioDescripcion,	WebService

	 FROM '+@base+'.dbo.FE_TipoEnvioSunat'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

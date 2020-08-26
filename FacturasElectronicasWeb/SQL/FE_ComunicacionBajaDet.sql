/*

 Insertando un registro En FE_ComunicacionBajaDet

*/
CREATE PROC FE_ComunicacionBajaDet_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@ClienteRazonSocial	varchar(60)='',
@clienteRuc	varchar(11)='',
@ComunicacionBaja_id	varchar(20)='0',
@ComunicacionbajaItem	varchar(20)='0',
@CorrelativoEnvio	varchar(20)='0',
@EmpresaCodigo	varchar(3)='',
@FechaAct	varchar(25)='01/01/1900',
@MotivoBaja_id	varchar(2)='',
@NumeroDocumento	varchar(10)='',
@SerieDocumento	varchar(4)='',
@TipoDocumento	varchar(2)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_ComunicacionBajaDet (ClienteRazonSocial,	clienteRuc,	ComunicacionBaja_id,	ComunicacionbajaItem,	
	CorrelativoEnvio,	EmpresaCodigo,	FechaAct,	MotivoBaja_id,	
	NumeroDocumento,	SerieDocumento,	TipoDocumento
 )
	 VALUES('''+@ClienteRazonSocial+''',	'''+@clienteRuc+''',	'+@ComunicacionBaja_id+',	'+@ComunicacionbajaItem+',	
	'+@CorrelativoEnvio+',	'''+@EmpresaCodigo+''',	'''+@FechaAct+''',	'''+@MotivoBaja_id+''',	
	'''+@NumeroDocumento+''',	'''+@SerieDocumento+''',	'''+@TipoDocumento+''')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_ComunicacionBajaDet SET 
	ClienteRazonSocial='''+@ClienteRazonSocial+''',
	clienteRuc='''+@clienteRuc+''',
	CorrelativoEnvio='+@CorrelativoEnvio+',
	FechaAct='''+@FechaAct+''',
	MotivoBaja_id='''+@MotivoBaja_id+''',
	NumeroDocumento='''+@NumeroDocumento+''',
	SerieDocumento='''+@SerieDocumento+''',
	TipoDocumento='''+@TipoDocumento+'''

	 WHERE ComunicacionBaja_id='+@ComunicacionBaja_id+' AND 
	ComunicacionbajaItem='+@ComunicacionbajaItem+' AND 
	EmpresaCodigo='''+@EmpresaCodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  ClienteRazonSocial,	clienteRuc,	ComunicacionBaja_id,	ComunicacionbajaItem,	
	CorrelativoEnvio,	EmpresaCodigo,	FechaAct,	MotivoBaja_id,	
	NumeroDocumento,	SerieDocumento,	TipoDocumento

	 FROM '+@base+'.dbo.FE_ComunicacionBajaDet'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

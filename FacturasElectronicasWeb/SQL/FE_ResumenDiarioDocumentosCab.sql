/*

 Insertando un registro En FE_ResumenDiarioDocumentosCab

*/
CREATE PROC FE_ResumenDiarioDocumentosCab_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@EmpresaCodigo	varchar(3)='',
@EnvioSedePrincipal	varchar(1)='0',
@Establecimiento_id	varchar(10)='',
@EstadoAnulado	varchar(1)='0',
@fechaAct	varchar(25)='01/01/1900',
@FechaDocumento	varchar(25)='01/01/1900',
@FechaEnvio	varchar(25)='01/01/1900',
@HostName	varchar(30)='',
@IdentificadorEnvio	varchar(30)='',
@Pedido_id	varchar(20)='0',
@Resumendiario_id	varchar(20)='0',
@usuarioCodigo	varchar(10)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_ResumenDiarioDocumentosCab (EmpresaCodigo,	EnvioSedePrincipal,	Establecimiento_id,	EstadoAnulado,	
	fechaAct,	FechaDocumento,	FechaEnvio,	HostName,	
	IdentificadorEnvio,	Pedido_id,	Resumendiario_id,	usuarioCodigo

	 )
	 VALUES('''+@EmpresaCodigo+''',	'+@EnvioSedePrincipal+',	'''+@Establecimiento_id+''',	'+@EstadoAnulado+',	
	'''+@fechaAct+''',	'''+@FechaDocumento+''',	'''+@FechaEnvio+''',	'''+@HostName+''',	
	'''+@IdentificadorEnvio+''',	'+@Pedido_id+',	'+@Resumendiario_id+',	'''+@usuarioCodigo+'''	
)  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_ResumenDiarioDocumentosCab SET 
	EnvioSedePrincipal='+@EnvioSedePrincipal+',
	Establecimiento_id='''+@Establecimiento_id+''',
	EstadoAnulado='+@EstadoAnulado+',
	fechaAct='''+@fechaAct+''',
	FechaDocumento='''+@FechaDocumento+''',
	FechaEnvio='''+@FechaEnvio+''',
	HostName='''+@HostName+''',
	IdentificadorEnvio='''+@IdentificadorEnvio+''',
	Pedido_id='+@Pedido_id+',
	usuarioCodigo='''+@usuarioCodigo+'''

	 WHERE EmpresaCodigo='''+@EmpresaCodigo+''' AND 
	Resumendiario_id='+@Resumendiario_id+'

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  EmpresaCodigo,	EnvioSedePrincipal,	Establecimiento_id,	EstadoAnulado,	
	fechaAct,	FechaDocumento,	FechaEnvio,	HostName,	
	IdentificadorEnvio,	Pedido_id,	Resumendiario_id,	usuarioCodigo

	
	 FROM '+@base+'.dbo.FE_ResumenDiarioDocumentosCab'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

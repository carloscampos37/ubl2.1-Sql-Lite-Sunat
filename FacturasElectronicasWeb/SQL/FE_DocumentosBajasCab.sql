/*

 Insertando un registro En FE_DocumentosBajasCab

*/
CREATE PROC FE_DocumentosBajasCab_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@DocumentosBajas_Id	varchar(20)='0',
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
@usuarioCodigo	varchar(10)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_DocumentosBajasCab (DocumentosBajas_Id,	EmpresaCodigo,	EnvioSedePrincipal,	Establecimiento_id,	
	EstadoAnulado,	fechaAct,	FechaDocumento,	FechaEnvio,	
	HostName,	IdentificadorEnvio,	Pedido_id,	usuarioCodigo

	 )
	 VALUES('+@DocumentosBajas_Id+',	'''+@EmpresaCodigo+''',	'+@EnvioSedePrincipal+',	'''+@Establecimiento_id+''',	
	'+@EstadoAnulado+',	'''+@fechaAct+''',	'''+@FechaDocumento+''',	'''+@FechaEnvio+''',	
	'''+@HostName+''',	'''+@IdentificadorEnvio+''',	'+@Pedido_id+',	'''+@usuarioCodigo+'''	
)  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_DocumentosBajasCab SET 
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

	 WHERE DocumentosBajas_Id='+@DocumentosBajas_Id+' AND 
	EmpresaCodigo='''+@EmpresaCodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  DocumentosBajas_Id,	EmpresaCodigo,	EnvioSedePrincipal,	Establecimiento_id,	
	EstadoAnulado,	fechaAct,	FechaDocumento,	FechaEnvio,	
	HostName,	IdentificadorEnvio,	Pedido_id,	usuarioCodigo

	
	 FROM '+@base+'.dbo.FE_DocumentosBajasCab'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

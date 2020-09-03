/*

 Insertando un registro En FE_ComprobImpresosCab

*/
CREATE PROC FE_ComprobImpresosCab_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@ComprobImpreso_Id	varchar(20)='0',
@EmpresaCodigo	varchar(3)='',
@EnvioSedePrincipal	varchar(1)='0',
@Establecimiento_id	varchar(10)='',
@EstadoAnulado	varchar(1)='0',
@FechaAct	varchar(25)='01/01/1900',
@FechaDocumento	varchar(25)='01/01/1900',
@HostName	varchar(20)='',
@IdentificadorEnvio	varchar(30)='',
@MotivoContigencia	varchar(20)='0',
@Pedido_id	varchar(20)='0',
@UsuarioCodigo	varchar(10)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_ComprobImpresosCab (ComprobImpreso_Id,	EmpresaCodigo,	EnvioSedePrincipal,	Establecimiento_id,	
	EstadoAnulado,	FechaAct,	FechaDocumento,	HostName,	
	IdentificadorEnvio,	MotivoContigencia,	Pedido_id,	UsuarioCodigo

	 )
	 VALUES('+@ComprobImpreso_Id+',	'''+@EmpresaCodigo+''',	'+@EnvioSedePrincipal+',	'''+@Establecimiento_id+''',	
	'+@EstadoAnulado+',	'''+@FechaAct+''',	'''+@FechaDocumento+''',	'''+@HostName+''',	
	'''+@IdentificadorEnvio+''',	'+@MotivoContigencia+',	'+@Pedido_id+',	'''+@UsuarioCodigo+'''	
)  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_ComprobImpresosCab SET 
	EnvioSedePrincipal='+@EnvioSedePrincipal+',
	Establecimiento_id='''+@Establecimiento_id+''',
	EstadoAnulado='+@EstadoAnulado+',
	FechaAct='''+@FechaAct+''',
	FechaDocumento='''+@FechaDocumento+''',
	HostName='''+@HostName+''',
	IdentificadorEnvio='''+@IdentificadorEnvio+''',
	MotivoContigencia='+@MotivoContigencia+',
	Pedido_id='+@Pedido_id+',
	UsuarioCodigo='''+@UsuarioCodigo+'''

	 WHERE ComprobImpreso_Id='+@ComprobImpreso_Id+' AND 
	EmpresaCodigo='''+@EmpresaCodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  ComprobImpreso_Id,	EmpresaCodigo,	EnvioSedePrincipal,	Establecimiento_id,	
	EstadoAnulado,	FechaAct,	FechaDocumento,	HostName,	
	IdentificadorEnvio,	MotivoContigencia,	Pedido_id,	UsuarioCodigo

	
	 FROM '+@base+'.dbo.FE_ComprobImpresosCab'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

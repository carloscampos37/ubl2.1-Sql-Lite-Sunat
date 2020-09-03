/*

 Insertando un registro En FE_DocumentosElectronicosCab

*/
CREATE PROC FE_DocumentosElectronicosCab_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@DocumentosElectronicos_id	varchar(20)='0',
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

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_DocumentosElectronicosCab (DocumentosElectronicos_id,	EmpresaCodigo,	EnvioSedePrincipal,	Establecimiento_id,	
	EstadoAnulado,	fechaAct,	FechaDocumento,	FechaEnvio,	
	HostName,	IdentificadorEnvio,	Pedido_id,	usuarioCodigo

	 )
	 VALUES('+@DocumentosElectronicos_id+',	'''+@EmpresaCodigo+''',	'+@EnvioSedePrincipal+',	'''+@Establecimiento_id+''',	
	'+@EstadoAnulado+',	'''+@fechaAct+''',	'''+@FechaDocumento+''',	'''+@FechaEnvio+''',	
	'''+@HostName+''',	'''+@IdentificadorEnvio+''',	'+@Pedido_id+',	'''+@usuarioCodigo+'''	
)  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_DocumentosElectronicosCab SET 
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

	 WHERE DocumentosElectronicos_id='+@DocumentosElectronicos_id+' AND 
	EmpresaCodigo='''+@EmpresaCodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  DocumentosElectronicos_id,	EmpresaCodigo,	EnvioSedePrincipal,	Establecimiento_id,	
	EstadoAnulado,	fechaAct,	FechaDocumento,	FechaEnvio,	
	HostName,	IdentificadorEnvio,	Pedido_id,	usuarioCodigo

	
	 FROM '+@base+'.dbo.FE_DocumentosElectronicosCab'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

/*

 Insertando un registro En FE_Establecimientos

*/
CREATE PROC FE_Establecimientos_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@AnexoSunat	varchar(4)='',
@EmpresaCodigo	varchar(3)='',
@Establecimiento_id	varchar(10)='',
@EstablecimientoDescripcion	varchar(50)='',
@establecimientoDireccion	varchar(100)='',
@HabilitadoFactDiaria	varchar(1)='0',
@HabilitadoFactPreimpresa	varchar(1)='0',
@HostName	varchar(50)='',
@Microred_id	varchar(3)='',
@UsuarioCodigo	varchar(10)='',
@Vendedor_id	varchar(3)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_Establecimientos (AnexoSunat,	EmpresaCodigo,	Establecimiento_id,	EstablecimientoDescripcion,	
	establecimientoDireccion,	HabilitadoFactDiaria,	HabilitadoFactPreimpresa,	HostName,	
	Microred_id,	UsuarioCodigo,	Vendedor_id
 )
	 VALUES('''+@AnexoSunat+''',	'''+@EmpresaCodigo+''',	'''+@Establecimiento_id+''',	'''+@EstablecimientoDescripcion+''',	
	'''+@establecimientoDireccion+''',	'+@HabilitadoFactDiaria+',	'+@HabilitadoFactPreimpresa+',	'''+@HostName+''',	
	'''+@Microred_id+''',	'''+@UsuarioCodigo+''',	'''+@Vendedor_id+''')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_Establecimientos SET 
	AnexoSunat='''+@AnexoSunat+''',
	EstablecimientoDescripcion='''+@EstablecimientoDescripcion+''',
	establecimientoDireccion='''+@establecimientoDireccion+''',
	HabilitadoFactDiaria='+@HabilitadoFactDiaria+',
	HabilitadoFactPreimpresa='+@HabilitadoFactPreimpresa+',
	HostName='''+@HostName+''',
	Microred_id='''+@Microred_id+''',
	UsuarioCodigo='''+@UsuarioCodigo+''',
	Vendedor_id='''+@Vendedor_id+'''

	 WHERE EmpresaCodigo='''+@EmpresaCodigo+''' AND 
	Establecimiento_id='''+@Establecimiento_id+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  AnexoSunat,	EmpresaCodigo,	Establecimiento_id,	EstablecimientoDescripcion,	
	establecimientoDireccion,	HabilitadoFactDiaria,	HabilitadoFactPreimpresa,	HostName,	
	Microred_id,	UsuarioCodigo,	Vendedor_id

	 FROM '+@base+'.dbo.FE_Establecimientos'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

/*

 Insertando un registro En FE_Empresas

*/
CREATE PROC FE_Empresas_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@EmpresaCodigo	varchar(3)='',
@EmpresaDireccion	varchar(100)='',
@EmpresaDistrito	varchar(50)='',
@EmpresaProvincia	varchar(50)='',
@EmpresaRazonComercial	varchar(50)='',
@EmpresaRazonSocial	varchar(100)='',
@EmpresaRegion	varchar(50)='',
@EmpresaRuc	varchar(11)='',
@EmpresaUrbanizacion	varchar(50)='',
@EstadoAnulado	varchar(1)='0',
@Ubigeo_id	varchar(8)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_Empresas (EmpresaCodigo,	EmpresaDireccion,	EmpresaDistrito,	EmpresaProvincia,	
	EmpresaRazonComercial,	EmpresaRazonSocial,	EmpresaRegion,	EmpresaRuc,	
	EmpresaUrbanizacion,	EstadoAnulado,	Ubigeo_id
 )
	 VALUES('''+@EmpresaCodigo+''',	'''+@EmpresaDireccion+''',	'''+@EmpresaDistrito+''',	'''+@EmpresaProvincia+''',	
	'''+@EmpresaRazonComercial+''',	'''+@EmpresaRazonSocial+''',	'''+@EmpresaRegion+''',	'''+@EmpresaRuc+''',	
	'''+@EmpresaUrbanizacion+''',	'+@EstadoAnulado+',	'''+@Ubigeo_id+''')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_Empresas SET 
	EmpresaDireccion='''+@EmpresaDireccion+''',
	EmpresaDistrito='''+@EmpresaDistrito+''',
	EmpresaProvincia='''+@EmpresaProvincia+''',
	EmpresaRazonComercial='''+@EmpresaRazonComercial+''',
	EmpresaRazonSocial='''+@EmpresaRazonSocial+''',
	EmpresaRegion='''+@EmpresaRegion+''',
	EmpresaRuc='''+@EmpresaRuc+''',
	EmpresaUrbanizacion='''+@EmpresaUrbanizacion+''',
	EstadoAnulado='+@EstadoAnulado+',
	Ubigeo_id='''+@Ubigeo_id+'''

	 WHERE EmpresaCodigo='''+@EmpresaCodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  EmpresaCodigo,	EmpresaDireccion,	EmpresaDistrito,	EmpresaProvincia,	
	EmpresaRazonComercial,	EmpresaRazonSocial,	EmpresaRegion,	EmpresaRuc,	
	EmpresaUrbanizacion,	EstadoAnulado,	Ubigeo_id

	 FROM '+@base+'.dbo.FE_Empresas'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

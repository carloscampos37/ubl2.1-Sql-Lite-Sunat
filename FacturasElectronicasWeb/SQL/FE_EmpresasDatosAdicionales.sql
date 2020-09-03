/*

 Insertando un registro En FE_EmpresasDatosAdicionales

*/
CREATE PROC FE_EmpresasDatosAdicionales_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@CaracteresEspeciales	varchar(1)='0',
@CarpetaBajasXml	varchar(100)='',
@CarpetaCertificadoDigital	varchar(100)='',
@CarpetaEnviosXml	varchar(100)='',
@CarpetaRecepcionBajas	varchar(100)='',
@carpetaRecepcionXml	varchar(100)='',
@EmpresaCodigo	varchar(3)='',
@EmpresaCorreoelectronico	varchar(100)='',
@ListaUrlSunat	varchar(30)='',
@ResolucionSunat	varchar(50)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_EmpresasDatosAdicionales (CaracteresEspeciales,	CarpetaBajasXml,	CarpetaCertificadoDigital,	CarpetaEnviosXml,	
	CarpetaRecepcionBajas,	carpetaRecepcionXml,	EmpresaCodigo,	EmpresaCorreoelectronico,	
	ListaUrlSunat,	ResolucionSunat
 )
	 VALUES('+@CaracteresEspeciales+',	'''+@CarpetaBajasXml+''',	'''+@CarpetaCertificadoDigital+''',	'''+@CarpetaEnviosXml+''',	
	'''+@CarpetaRecepcionBajas+''',	'''+@carpetaRecepcionXml+''',	'''+@EmpresaCodigo+''',	'''+@EmpresaCorreoelectronico+''',	
	'''+@ListaUrlSunat+''',	'''+@ResolucionSunat+''')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_EmpresasDatosAdicionales SET 
	CaracteresEspeciales='+@CaracteresEspeciales+',
	CarpetaBajasXml='''+@CarpetaBajasXml+''',
	CarpetaCertificadoDigital='''+@CarpetaCertificadoDigital+''',
	CarpetaEnviosXml='''+@CarpetaEnviosXml+''',
	CarpetaRecepcionBajas='''+@CarpetaRecepcionBajas+''',
	carpetaRecepcionXml='''+@carpetaRecepcionXml+''',
	EmpresaCorreoelectronico='''+@EmpresaCorreoelectronico+''',
	ListaUrlSunat='''+@ListaUrlSunat+''',
	ResolucionSunat='''+@ResolucionSunat+'''

	 WHERE EmpresaCodigo='''+@EmpresaCodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  CaracteresEspeciales,	CarpetaBajasXml,	CarpetaCertificadoDigital,	CarpetaEnviosXml,	
	CarpetaRecepcionBajas,	carpetaRecepcionXml,	EmpresaCodigo,	EmpresaCorreoelectronico,	
	ListaUrlSunat,	ResolucionSunat

	 FROM '+@base+'.dbo.FE_EmpresasDatosAdicionales'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

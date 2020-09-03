/*

 Insertando un registro En FE_EmpresasSeguridad

*/
CREATE PROC FE_EmpresasSeguridad_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@CorreoElectronicoFactelect	varchar(100)='',
@EmpresaClaveSol	varchar(20)='',
@EmpresaCodigo	varchar(3)='',
@EmpresaUsuarioSol	varchar(20)='',
@EstadoAnulado	varchar(1)='0',
@FechaVigenciaCertificado	varchar(25)='01/01/1900',
@NombreCertificadoDigital	varchar(30)='',
@PasswCertificadoDigital	varchar(30)='',
@PasswCorreoElectronico	varchar(20)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_EmpresasSeguridad (CorreoElectronicoFactelect,	EmpresaClaveSol,	EmpresaCodigo,	EmpresaUsuarioSol,	
	EstadoAnulado,	FechaVigenciaCertificado,	NombreCertificadoDigital,	PasswCertificadoDigital,	
	PasswCorreoElectronico
 )
	 VALUES('''+@CorreoElectronicoFactelect+''',	'''+@EmpresaClaveSol+''',	'''+@EmpresaCodigo+''',	'''+@EmpresaUsuarioSol+''',	
	'+@EstadoAnulado+',	'''+@FechaVigenciaCertificado+''',	'''+@NombreCertificadoDigital+''',	'''+@PasswCertificadoDigital+''',	
	'''+@PasswCorreoElectronico+''')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_EmpresasSeguridad SET 
	CorreoElectronicoFactelect='''+@CorreoElectronicoFactelect+''',
	EmpresaClaveSol='''+@EmpresaClaveSol+''',
	EmpresaUsuarioSol='''+@EmpresaUsuarioSol+''',
	EstadoAnulado='+@EstadoAnulado+',
	FechaVigenciaCertificado='''+@FechaVigenciaCertificado+''',
	NombreCertificadoDigital='''+@NombreCertificadoDigital+''',
	PasswCertificadoDigital='''+@PasswCertificadoDigital+''',
	PasswCorreoElectronico='''+@PasswCorreoElectronico+'''

	 WHERE EmpresaCodigo='''+@EmpresaCodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  CorreoElectronicoFactelect,	EmpresaClaveSol,	EmpresaCodigo,	EmpresaUsuarioSol,	
	EstadoAnulado,	FechaVigenciaCertificado,	NombreCertificadoDigital,	PasswCertificadoDigital,	
	PasswCorreoElectronico

	 FROM '+@base+'.dbo.FE_EmpresasSeguridad'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

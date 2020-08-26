/*

 Insertando un registro En FE_ControldeEnvios

*/
CREATE PROC FE_ControldeEnvios_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@Comunicacionbajas	varchar(1)='0',
@DocumentosElectronicos	varchar(1)='0',
@EmpresaCodigo	varchar(3)='',
@EstadoCierreSunat	varchar(1)='0',
@FechaEmision	varchar(25)='01/01/1900',
@PuntovtaCodigo	varchar(2)='',
@ResumenDiario	varchar(1)='0'

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_ControldeEnvios (Comunicacionbajas,	DocumentosElectronicos,	EmpresaCodigo,	EstadoCierreSunat,	
	FechaEmision,	PuntovtaCodigo,	ResumenDiario
 )
	 VALUES('+@Comunicacionbajas+',	'+@DocumentosElectronicos+',	'''+@EmpresaCodigo+''',	'+@EstadoCierreSunat+',	
	'''+@FechaEmision+''',	'''+@PuntovtaCodigo+''',	'+@ResumenDiario+')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_ControldeEnvios SET 
	Comunicacionbajas='+@Comunicacionbajas+',
	DocumentosElectronicos='+@DocumentosElectronicos+',
	EstadoCierreSunat='+@EstadoCierreSunat+',
	ResumenDiario='+@ResumenDiario+'

	 WHERE EmpresaCodigo='''+@EmpresaCodigo+''' AND 
	FechaEmision='''+@FechaEmision+''' AND 
	PuntovtaCodigo='''+@PuntovtaCodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  Comunicacionbajas,	DocumentosElectronicos,	EmpresaCodigo,	EstadoCierreSunat,	
	FechaEmision,	PuntovtaCodigo,	ResumenDiario

	 FROM '+@base+'.dbo.FE_ControldeEnvios'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

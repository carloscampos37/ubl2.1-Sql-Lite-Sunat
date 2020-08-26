/*

 Insertando un registro En FE_ComprobImpresosDet

*/
CREATE PROC FE_ComprobImpresosDet_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@ComprobImpreso_id	varchar(20)='0',
@ComprobImpresoCorrel	varchar(20)='0',
@EmpresaCodigo	varchar(3)='',
@EstadoEnvioSunat_id	varchar(20)='0',
@MonedaCodigo	varchar(2)='',
@NumerodeAceptacion	varchar(20)='',
@NumerodeDocumentos	varchar(20)='0',
@NumeroDocumento	varchar(20)='0',
@NumeroDocumentoFinal	varchar(20)='0',
@SerieDocumento	varchar(20)='',
@TipoDocumento	varchar(2)='',
@TotalImporteDsctoGlobal	varchar(20)='0',
@TotalImporteExonerado	varchar(20)='0',
@TotalImporteGravado	varchar(20)='0',
@TotalImporteIGV	varchar(20)='0',
@TotalImporteInafecto	varchar(20)='0',
@TotalImporteVenta	varchar(20)='0'

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_ComprobImpresosDet (ComprobImpreso_id,	ComprobImpresoCorrel,	EmpresaCodigo,	EstadoEnvioSunat_id,	
	MonedaCodigo,	NumerodeAceptacion,	NumerodeDocumentos,	NumeroDocumento,	
	NumeroDocumentoFinal,	SerieDocumento,	TipoDocumento,	TotalImporteDsctoGlobal,	
	TotalImporteExonerado,	TotalImporteGravado,	TotalImporteIGV,	TotalImporteInafecto,	
	TotalImporteVenta
 )
	 VALUES('+@ComprobImpreso_id+',	'+@ComprobImpresoCorrel+',	'''+@EmpresaCodigo+''',	'+@EstadoEnvioSunat_id+',	
	'''+@MonedaCodigo+''',	'''+@NumerodeAceptacion+''',	'+@NumerodeDocumentos+',	'+@NumeroDocumento+',	
	'+@NumeroDocumentoFinal+',	'''+@SerieDocumento+''',	'''+@TipoDocumento+''',	'+@TotalImporteDsctoGlobal+',	
	'+@TotalImporteExonerado+',	'+@TotalImporteGravado+',	'+@TotalImporteIGV+',	'+@TotalImporteInafecto+',	
	'+@TotalImporteVenta+')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_ComprobImpresosDet SET 
	EstadoEnvioSunat_id='+@EstadoEnvioSunat_id+',
	MonedaCodigo='''+@MonedaCodigo+''',
	NumerodeAceptacion='''+@NumerodeAceptacion+''',
	NumerodeDocumentos='+@NumerodeDocumentos+',
	NumeroDocumento='+@NumeroDocumento+',
	NumeroDocumentoFinal='+@NumeroDocumentoFinal+',
	SerieDocumento='''+@SerieDocumento+''',
	TipoDocumento='''+@TipoDocumento+''',
	TotalImporteDsctoGlobal='+@TotalImporteDsctoGlobal+',
	TotalImporteExonerado='+@TotalImporteExonerado+',
	TotalImporteGravado='+@TotalImporteGravado+',
	TotalImporteIGV='+@TotalImporteIGV+',
	TotalImporteInafecto='+@TotalImporteInafecto+',
	TotalImporteVenta='+@TotalImporteVenta+'

	 WHERE ComprobImpreso_id='+@ComprobImpreso_id+' AND 
	ComprobImpresoCorrel='+@ComprobImpresoCorrel+' AND 
	EmpresaCodigo='''+@EmpresaCodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  ComprobImpreso_id,	ComprobImpresoCorrel,	EmpresaCodigo,	EstadoEnvioSunat_id,	
	MonedaCodigo,	NumerodeAceptacion,	NumerodeDocumentos,	NumeroDocumento,	
	NumeroDocumentoFinal,	SerieDocumento,	TipoDocumento,	TotalImporteDsctoGlobal,	
	TotalImporteExonerado,	TotalImporteGravado,	TotalImporteIGV,	TotalImporteInafecto,	
	TotalImporteVenta

	 FROM '+@base+'.dbo.FE_ComprobImpresosDet'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

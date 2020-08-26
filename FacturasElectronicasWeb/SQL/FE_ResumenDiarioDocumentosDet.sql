/*

 Insertando un registro En FE_ResumenDiarioDocumentosDet

*/
CREATE PROC FE_ResumenDiarioDocumentosDet_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@ArchivoXmlAceptado	varchar(100)='',
@EmpresaCodigo	varchar(3)='',
@EstadoAnulado	varchar(1)='0',
@EstadoEnvioSunat_id	varchar(20)='0',
@GrupodeEnvioSunat	varchar(20)='0',
@MensajeRecepcion	varchar(60)='',
@MonedaCodigo	varchar(2)='',
@NumerodeAceptacion	varchar(20)='',
@NumerodeDocumentos	varchar(20)='0',
@NumeroDocumento	varchar(20)='0',
@NumeroDocumentoFinal	varchar(20)='0',
@Resumendiario_id	varchar(20)='0',
@ResumendiarioCorrel	varchar(20)='0',
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

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_ResumenDiarioDocumentosDet (ArchivoXmlAceptado,	EmpresaCodigo,	EstadoAnulado,	EstadoEnvioSunat_id,	
	GrupodeEnvioSunat,	MensajeRecepcion,	MonedaCodigo,	NumerodeAceptacion,	
	NumerodeDocumentos,	NumeroDocumento,	NumeroDocumentoFinal,	Resumendiario_id,	
	ResumendiarioCorrel,	SerieDocumento,	TipoDocumento,	TotalImporteDsctoGlobal,	
	TotalImporteExonerado,	TotalImporteGravado,	TotalImporteIGV,	TotalImporteInafecto,	
	TotalImporteVenta
 )
	 VALUES('''+@ArchivoXmlAceptado+''',	'''+@EmpresaCodigo+''',	'+@EstadoAnulado+',	'+@EstadoEnvioSunat_id+',	
	'+@GrupodeEnvioSunat+',	'''+@MensajeRecepcion+''',	'''+@MonedaCodigo+''',	'''+@NumerodeAceptacion+''',	
	'+@NumerodeDocumentos+',	'+@NumeroDocumento+',	'+@NumeroDocumentoFinal+',	'+@Resumendiario_id+',	
	'+@ResumendiarioCorrel+',	'''+@SerieDocumento+''',	'''+@TipoDocumento+''',	'+@TotalImporteDsctoGlobal+',	
	'+@TotalImporteExonerado+',	'+@TotalImporteGravado+',	'+@TotalImporteIGV+',	'+@TotalImporteInafecto+',	
	'+@TotalImporteVenta+')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_ResumenDiarioDocumentosDet SET 
	ArchivoXmlAceptado='''+@ArchivoXmlAceptado+''',
	EstadoAnulado='+@EstadoAnulado+',
	EstadoEnvioSunat_id='+@EstadoEnvioSunat_id+',
	GrupodeEnvioSunat='+@GrupodeEnvioSunat+',
	MensajeRecepcion='''+@MensajeRecepcion+''',
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

	 WHERE EmpresaCodigo='''+@EmpresaCodigo+''' AND 
	Resumendiario_id='+@Resumendiario_id+' AND 
	ResumendiarioCorrel='+@ResumendiarioCorrel+'

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  ArchivoXmlAceptado,	EmpresaCodigo,	EstadoAnulado,	EstadoEnvioSunat_id,	
	GrupodeEnvioSunat,	MensajeRecepcion,	MonedaCodigo,	NumerodeAceptacion,	
	NumerodeDocumentos,	NumeroDocumento,	NumeroDocumentoFinal,	Resumendiario_id,	
	ResumendiarioCorrel,	SerieDocumento,	TipoDocumento,	TotalImporteDsctoGlobal,	
	TotalImporteExonerado,	TotalImporteGravado,	TotalImporteIGV,	TotalImporteInafecto,	
	TotalImporteVenta

	 FROM '+@base+'.dbo.FE_ResumenDiarioDocumentosDet'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

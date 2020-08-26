/*

 Insertando un registro En FE_DocumentosBajasDet

*/
CREATE PROC FE_DocumentosBajasDet_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@ClienteCodigo	varchar(15)='',
@ClienteRazonSocial	varchar(60)='',
@DescripcionMotivoNota	varchar(100)='',
@DocumentosBajas_Id	varchar(20)='0',
@DocumentosBajasCorrel	varchar(20)='0',
@EmpresaCodigo	varchar(3)='',
@EnvioSedePrincipal	varchar(1)='0',
@EstadoAnulado	varchar(1)='0',
@EstadoEnvioSunat_id	varchar(20)='0',
@Identidadcodigo	varchar(20)='0',
@MonedaCodigo	varchar(2)='',
@NumerodeAceptacion	varchar(20)='',
@NumeroDocumento	varchar(20)='0',
@NumeroDocumentoFinal	varchar(20)='0',
@NumeroDocumentoModifica	varchar(20)='',
@PorcentajeIsc	varchar(20)='0',
@SerieDocumento	varchar(20)='',
@SerieDocumentoModifica	varchar(4)='',
@TipoDocumento	varchar(2)='',
@TipoDocumentoModifica	varchar(2)='',
@TipoMotivoNota	varchar(2)='',
@TotalImporteDsctoGlobal	varchar(20)='0',
@TotalImporteDsctoItem	varchar(20)='0',
@TotalImporteExonerado	varchar(20)='0',
@TotalImporteGratuitas	varchar(20)='0',
@TotalImporteGravado	varchar(20)='0',
@TotalImporteIGV	varchar(20)='0',
@TotalImporteInafecto	varchar(20)='0',
@TotalImporteISC	varchar(20)='0',
@TotalImporteOtros	varchar(20)='0',
@TotalImporteVenta	varchar(20)='0'

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_DocumentosBajasDet (ClienteCodigo,	ClienteRazonSocial,	DescripcionMotivoNota,	DocumentosBajas_Id,	
	DocumentosBajasCorrel,	EmpresaCodigo,	EnvioSedePrincipal,	EstadoAnulado,	
	EstadoEnvioSunat_id,	Identidadcodigo,	MonedaCodigo,	NumerodeAceptacion,	
	NumeroDocumento,	NumeroDocumentoFinal,	NumeroDocumentoModifica,	PorcentajeIsc,	
	SerieDocumento,	SerieDocumentoModifica,	TipoDocumento,	TipoDocumentoModifica,	
	TipoMotivoNota,	TotalImporteDsctoGlobal,	TotalImporteDsctoItem,	TotalImporteExonerado,	
	TotalImporteGratuitas,	TotalImporteGravado,	TotalImporteIGV,	TotalImporteInafecto,	
	TotalImporteISC,	TotalImporteOtros,	TotalImporteVenta
 )
	 VALUES('''+@ClienteCodigo+''',	'''+@ClienteRazonSocial+''',	'''+@DescripcionMotivoNota+''',	'+@DocumentosBajas_Id+',	
	'+@DocumentosBajasCorrel+',	'''+@EmpresaCodigo+''',	'+@EnvioSedePrincipal+',	'+@EstadoAnulado+',	
	'+@EstadoEnvioSunat_id+',	'+@Identidadcodigo+',	'''+@MonedaCodigo+''',	'''+@NumerodeAceptacion+''',	
	'+@NumeroDocumento+',	'+@NumeroDocumentoFinal+',	'''+@NumeroDocumentoModifica+''',	'+@PorcentajeIsc+',	
	'''+@SerieDocumento+''',	'''+@SerieDocumentoModifica+''',	'''+@TipoDocumento+''',	'''+@TipoDocumentoModifica+''',	
	'''+@TipoMotivoNota+''',	'+@TotalImporteDsctoGlobal+',	'+@TotalImporteDsctoItem+',	'+@TotalImporteExonerado+',	
	'+@TotalImporteGratuitas+',	'+@TotalImporteGravado+',	'+@TotalImporteIGV+',	'+@TotalImporteInafecto+',	
	'+@TotalImporteISC+',	'+@TotalImporteOtros+',	'+@TotalImporteVenta+')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_DocumentosBajasDet SET 
	ClienteCodigo='''+@ClienteCodigo+''',
	ClienteRazonSocial='''+@ClienteRazonSocial+''',
	DescripcionMotivoNota='''+@DescripcionMotivoNota+''',
	EnvioSedePrincipal='+@EnvioSedePrincipal+',
	EstadoAnulado='+@EstadoAnulado+',
	EstadoEnvioSunat_id='+@EstadoEnvioSunat_id+',
	Identidadcodigo='+@Identidadcodigo+',
	MonedaCodigo='''+@MonedaCodigo+''',
	NumerodeAceptacion='''+@NumerodeAceptacion+''',
	NumeroDocumento='+@NumeroDocumento+',
	NumeroDocumentoFinal='+@NumeroDocumentoFinal+',
	NumeroDocumentoModifica='''+@NumeroDocumentoModifica+''',
	PorcentajeIsc='+@PorcentajeIsc+',
	SerieDocumento='''+@SerieDocumento+''',
	SerieDocumentoModifica='''+@SerieDocumentoModifica+''',
	TipoDocumento='''+@TipoDocumento+''',
	TipoDocumentoModifica='''+@TipoDocumentoModifica+''',
	TipoMotivoNota='''+@TipoMotivoNota+''',
	TotalImporteDsctoGlobal='+@TotalImporteDsctoGlobal+',
	TotalImporteDsctoItem='+@TotalImporteDsctoItem+',
	TotalImporteExonerado='+@TotalImporteExonerado+',
	TotalImporteGratuitas='+@TotalImporteGratuitas+',
	TotalImporteGravado='+@TotalImporteGravado+',
	TotalImporteIGV='+@TotalImporteIGV+',
	TotalImporteInafecto='+@TotalImporteInafecto+',
	TotalImporteISC='+@TotalImporteISC+',
	TotalImporteOtros='+@TotalImporteOtros+',
	TotalImporteVenta='+@TotalImporteVenta+'

	 WHERE DocumentosBajas_Id='+@DocumentosBajas_Id+' AND 
	DocumentosBajasCorrel='+@DocumentosBajasCorrel+' AND 
	EmpresaCodigo='''+@EmpresaCodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  ClienteCodigo,	ClienteRazonSocial,	DescripcionMotivoNota,	DocumentosBajas_Id,	
	DocumentosBajasCorrel,	EmpresaCodigo,	EnvioSedePrincipal,	EstadoAnulado,	
	EstadoEnvioSunat_id,	Identidadcodigo,	MonedaCodigo,	NumerodeAceptacion,	
	NumeroDocumento,	NumeroDocumentoFinal,	NumeroDocumentoModifica,	PorcentajeIsc,	
	SerieDocumento,	SerieDocumentoModifica,	TipoDocumento,	TipoDocumentoModifica,	
	TipoMotivoNota,	TotalImporteDsctoGlobal,	TotalImporteDsctoItem,	TotalImporteExonerado,	
	TotalImporteGratuitas,	TotalImporteGravado,	TotalImporteIGV,	TotalImporteInafecto,	
	TotalImporteISC,	TotalImporteOtros,	TotalImporteVenta

	 FROM '+@base+'.dbo.FE_DocumentosBajasDet'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

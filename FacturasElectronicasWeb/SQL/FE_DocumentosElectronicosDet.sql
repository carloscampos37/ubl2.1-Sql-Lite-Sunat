/*

 Insertando un registro En FE_DocumentosElectronicosDet

*/
CREATE PROC FE_DocumentosElectronicosDet_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@AfectacionIgv	varchar(1)='',
@ClienteCodigo	varchar(15)='',
@ClienteRazonSocial	varchar(60)='',
@DescripcionMotivoNota	varchar(100)='',
@DocumentosElectronicos_id	varchar(20)='0',
@DocumentosElectronicosCorrel	varchar(20)='0',
@EmpresaCodigo	varchar(3)='',
@EnvioSedePrincipal	varchar(1)='0',
@EstadoAnulado	varchar(1)='0',
@EstadoEnvioSunat_id	varchar(20)='0',
@FechaRegistro	varchar(25)='01/01/1900',
@Identidadcodigo	varchar(20)='0',
@MonedaCodigo	varchar(2)='',
@NumerodeAceptacion	varchar(20)='',
@NumeroDocumento	varchar(20)='0',
@NumeroDocumentoModifica	varchar(20)='',
@PedidoNumero	varchar(15)='',
@PorcentajeIgv	varchar(20)='0',
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

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_DocumentosElectronicosDet (AfectacionIgv,	ClienteCodigo,	ClienteRazonSocial,	DescripcionMotivoNota,	
	DocumentosElectronicos_id,	DocumentosElectronicosCorrel,	EmpresaCodigo,	EnvioSedePrincipal,	
	EstadoAnulado,	EstadoEnvioSunat_id,	FechaRegistro,	Identidadcodigo,	
	MonedaCodigo,	NumerodeAceptacion,	NumeroDocumento,	NumeroDocumentoModifica,	
	PedidoNumero,	PorcentajeIgv,	PorcentajeIsc,	SerieDocumento,	
	SerieDocumentoModifica,	TipoDocumento,	TipoDocumentoModifica,	TipoMotivoNota,	
	TotalImporteDsctoGlobal,	TotalImporteDsctoItem,	TotalImporteExonerado,	TotalImporteGratuitas,	
	TotalImporteGravado,	TotalImporteIGV,	TotalImporteInafecto,	TotalImporteISC,	
	TotalImporteOtros,	TotalImporteVenta
 )
	 VALUES('''+@AfectacionIgv+''',	'''+@ClienteCodigo+''',	'''+@ClienteRazonSocial+''',	'''+@DescripcionMotivoNota+''',	
	'+@DocumentosElectronicos_id+',	'+@DocumentosElectronicosCorrel+',	'''+@EmpresaCodigo+''',	'+@EnvioSedePrincipal+',	
	'+@EstadoAnulado+',	'+@EstadoEnvioSunat_id+',	'''+@FechaRegistro+''',	'+@Identidadcodigo+',	
	'''+@MonedaCodigo+''',	'''+@NumerodeAceptacion+''',	'+@NumeroDocumento+',	'''+@NumeroDocumentoModifica+''',	
	'''+@PedidoNumero+''',	'+@PorcentajeIgv+',	'+@PorcentajeIsc+',	'''+@SerieDocumento+''',	
	'''+@SerieDocumentoModifica+''',	'''+@TipoDocumento+''',	'''+@TipoDocumentoModifica+''',	'''+@TipoMotivoNota+''',	
	'+@TotalImporteDsctoGlobal+',	'+@TotalImporteDsctoItem+',	'+@TotalImporteExonerado+',	'+@TotalImporteGratuitas+',	
	'+@TotalImporteGravado+',	'+@TotalImporteIGV+',	'+@TotalImporteInafecto+',	'+@TotalImporteISC+',	
	'+@TotalImporteOtros+',	'+@TotalImporteVenta+')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_DocumentosElectronicosDet SET 
	AfectacionIgv='''+@AfectacionIgv+''',
	ClienteCodigo='''+@ClienteCodigo+''',
	ClienteRazonSocial='''+@ClienteRazonSocial+''',
	DescripcionMotivoNota='''+@DescripcionMotivoNota+''',
	EnvioSedePrincipal='+@EnvioSedePrincipal+',
	EstadoAnulado='+@EstadoAnulado+',
	EstadoEnvioSunat_id='+@EstadoEnvioSunat_id+',
	FechaRegistro='''+@FechaRegistro+''',
	Identidadcodigo='+@Identidadcodigo+',
	MonedaCodigo='''+@MonedaCodigo+''',
	NumerodeAceptacion='''+@NumerodeAceptacion+''',
	NumeroDocumento='+@NumeroDocumento+',
	NumeroDocumentoModifica='''+@NumeroDocumentoModifica+''',
	PedidoNumero='''+@PedidoNumero+''',
	PorcentajeIgv='+@PorcentajeIgv+',
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

	 WHERE DocumentosElectronicos_id='+@DocumentosElectronicos_id+' AND 
	DocumentosElectronicosCorrel='+@DocumentosElectronicosCorrel+' AND 
	EmpresaCodigo='''+@EmpresaCodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  AfectacionIgv,	ClienteCodigo,	ClienteRazonSocial,	DescripcionMotivoNota,	
	DocumentosElectronicos_id,	DocumentosElectronicosCorrel,	EmpresaCodigo,	EnvioSedePrincipal,	
	EstadoAnulado,	EstadoEnvioSunat_id,	FechaRegistro,	Identidadcodigo,	
	MonedaCodigo,	NumerodeAceptacion,	NumeroDocumento,	NumeroDocumentoModifica,	
	PedidoNumero,	PorcentajeIgv,	PorcentajeIsc,	SerieDocumento,	
	SerieDocumentoModifica,	TipoDocumento,	TipoDocumentoModifica,	TipoMotivoNota,	
	TotalImporteDsctoGlobal,	TotalImporteDsctoItem,	TotalImporteExonerado,	TotalImporteGratuitas,	
	TotalImporteGravado,	TotalImporteIGV,	TotalImporteInafecto,	TotalImporteISC,	
	TotalImporteOtros,	TotalImporteVenta

	 FROM '+@base+'.dbo.FE_DocumentosElectronicosDet'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

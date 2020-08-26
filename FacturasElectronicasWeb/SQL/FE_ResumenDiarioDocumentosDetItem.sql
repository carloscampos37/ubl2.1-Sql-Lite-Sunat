/*

 Insertando un registro En FE_ResumenDiarioDocumentosDetItem

*/
CREATE PROC FE_ResumenDiarioDocumentosDetItem_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@ClienteCodigo	varchar(15)='',
@ClienteRazonSocial	varchar(60)='',
@EmpresaCodigo	varchar(3)='',
@EstadoAnulado	varchar(1)='0',
@EstadoEnvioSunat_id	varchar(20)='0',
@IdentidadCodigo	varchar(20)='0',
@MonedaCodigo	varchar(2)='',
@NumeroDocumento	varchar(20)='0',
@NumeroDocumentoModifica	varchar(20)='',
@PedidoNumero	varchar(15)='',
@ResumenDiario_Id	varchar(20)='0',
@ResumenDiarioCorrel	varchar(20)='0',
@ResumenDiarioCorrelItem	varchar(20)='0',
@SerieDocumento	varchar(20)='',
@SerieDocumentoModifica	varchar(20)='',
@TipoDocumento	varchar(2)='',
@TipoDocumentoModifica	varchar(2)='',
@TotalImporteDsctoGlobal	varchar(20)='0',
@TotalImporteExonerado	varchar(20)='0',
@TotalImporteGratuitas	varchar(20)='0',
@TotalImporteGravado	varchar(20)='0',
@totalImporteIGV	varchar(20)='0',
@TotalImporteInafecto	varchar(20)='0',
@TotalImporteISC	varchar(20)='0',
@TotalImporteOtros	varchar(20)='0',
@TotalImporteVenta	varchar(20)='0'

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_ResumenDiarioDocumentosDetItem (ClienteCodigo,	ClienteRazonSocial,	EmpresaCodigo,	EstadoAnulado,	
	EstadoEnvioSunat_id,	IdentidadCodigo,	MonedaCodigo,	NumeroDocumento,	
	NumeroDocumentoModifica,	PedidoNumero,	ResumenDiario_Id,	ResumenDiarioCorrel,	
	ResumenDiarioCorrelItem,	SerieDocumento,	SerieDocumentoModifica,	TipoDocumento,	
	TipoDocumentoModifica,	TotalImporteDsctoGlobal,	TotalImporteExonerado,	TotalImporteGratuitas,	
	TotalImporteGravado,	totalImporteIGV,	TotalImporteInafecto,	TotalImporteISC,	
	TotalImporteOtros,	TotalImporteVenta
 )
	 VALUES('''+@ClienteCodigo+''',	'''+@ClienteRazonSocial+''',	'''+@EmpresaCodigo+''',	'+@EstadoAnulado+',	
	'+@EstadoEnvioSunat_id+',	'+@IdentidadCodigo+',	'''+@MonedaCodigo+''',	'+@NumeroDocumento+',	
	'''+@NumeroDocumentoModifica+''',	'''+@PedidoNumero+''',	'+@ResumenDiario_Id+',	'+@ResumenDiarioCorrel+',	
	'+@ResumenDiarioCorrelItem+',	'''+@SerieDocumento+''',	'''+@SerieDocumentoModifica+''',	'''+@TipoDocumento+''',	
	'''+@TipoDocumentoModifica+''',	'+@TotalImporteDsctoGlobal+',	'+@TotalImporteExonerado+',	'+@TotalImporteGratuitas+',	
	'+@TotalImporteGravado+',	'+@totalImporteIGV+',	'+@TotalImporteInafecto+',	'+@TotalImporteISC+',	
	'+@TotalImporteOtros+',	'+@TotalImporteVenta+')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_ResumenDiarioDocumentosDetItem SET 
	ClienteCodigo='''+@ClienteCodigo+''',
	ClienteRazonSocial='''+@ClienteRazonSocial+''',
	EstadoAnulado='+@EstadoAnulado+',
	EstadoEnvioSunat_id='+@EstadoEnvioSunat_id+',
	IdentidadCodigo='+@IdentidadCodigo+',
	MonedaCodigo='''+@MonedaCodigo+''',
	NumeroDocumento='+@NumeroDocumento+',
	NumeroDocumentoModifica='''+@NumeroDocumentoModifica+''',
	PedidoNumero='''+@PedidoNumero+''',
	SerieDocumento='''+@SerieDocumento+''',
	SerieDocumentoModifica='''+@SerieDocumentoModifica+''',
	TipoDocumento='''+@TipoDocumento+''',
	TipoDocumentoModifica='''+@TipoDocumentoModifica+''',
	TotalImporteDsctoGlobal='+@TotalImporteDsctoGlobal+',
	TotalImporteExonerado='+@TotalImporteExonerado+',
	TotalImporteGratuitas='+@TotalImporteGratuitas+',
	TotalImporteGravado='+@TotalImporteGravado+',
	totalImporteIGV='+@totalImporteIGV+',
	TotalImporteInafecto='+@TotalImporteInafecto+',
	TotalImporteISC='+@TotalImporteISC+',
	TotalImporteOtros='+@TotalImporteOtros+',
	TotalImporteVenta='+@TotalImporteVenta+'

	 WHERE EmpresaCodigo='''+@EmpresaCodigo+''' AND 
	ResumenDiario_Id='+@ResumenDiario_Id+' AND 
	ResumenDiarioCorrel='+@ResumenDiarioCorrel+' AND 
	ResumenDiarioCorrelItem='+@ResumenDiarioCorrelItem+'

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  ClienteCodigo,	ClienteRazonSocial,	EmpresaCodigo,	EstadoAnulado,	
	EstadoEnvioSunat_id,	IdentidadCodigo,	MonedaCodigo,	NumeroDocumento,	
	NumeroDocumentoModifica,	PedidoNumero,	ResumenDiario_Id,	ResumenDiarioCorrel,	
	ResumenDiarioCorrelItem,	SerieDocumento,	SerieDocumentoModifica,	TipoDocumento,	
	TipoDocumentoModifica,	TotalImporteDsctoGlobal,	TotalImporteExonerado,	TotalImporteGratuitas,	
	TotalImporteGravado,	totalImporteIGV,	TotalImporteInafecto,	TotalImporteISC,	
	TotalImporteOtros,	TotalImporteVenta

	 FROM '+@base+'.dbo.FE_ResumenDiarioDocumentosDetItem'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

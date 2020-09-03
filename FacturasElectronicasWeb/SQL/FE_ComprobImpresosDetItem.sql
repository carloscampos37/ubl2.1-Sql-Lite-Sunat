/*

 Insertando un registro En FE_ComprobImpresosDetItem

*/
CREATE PROC FE_ComprobImpresosDetItem_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@ClienteCodigo	varchar(15)='',
@ClienteRazonSocial	varchar(60)='',
@ComprobImpreso_Id	varchar(20)='0',
@ComprobImpresoCorrel	varchar(20)='0',
@ComprobImpresoCorrelItem	varchar(20)='0',
@EmpresaCodigo	varchar(3)='',
@EstadoAnulado	varchar(1)='0',
@EstadoEnvioSunat_id	varchar(20)='0',
@IdentidadCodigo	varchar(20)='0',
@MonedaCodigo	varchar(2)='',
@NumeroDocumento	varchar(20)='0',
@NumeroDocumentoFinal	varchar(20)='0',
@NumeroDocumentoModifica	varchar(20)='',
@SerieDocumento	varchar(20)='',
@SerieDocumentoModifica	varchar(20)='',
@TipoDocumento	varchar(2)='',
@TipoDocumentoModifica	varchar(2)='',
@TotalImporteExonerado	varchar(20)='0',
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

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_ComprobImpresosDetItem (ClienteCodigo,	ClienteRazonSocial,	ComprobImpreso_Id,	ComprobImpresoCorrel,	
	ComprobImpresoCorrelItem,	EmpresaCodigo,	EstadoAnulado,	EstadoEnvioSunat_id,	
	IdentidadCodigo,	MonedaCodigo,	NumeroDocumento,	NumeroDocumentoFinal,	
	NumeroDocumentoModifica,	SerieDocumento,	SerieDocumentoModifica,	TipoDocumento,	
	TipoDocumentoModifica,	TotalImporteExonerado,	TotalImporteGravado,	totalImporteIGV,	
	TotalImporteInafecto,	TotalImporteISC,	TotalImporteOtros,	TotalImporteVenta

	 )
	 VALUES('''+@ClienteCodigo+''',	'''+@ClienteRazonSocial+''',	'+@ComprobImpreso_Id+',	'+@ComprobImpresoCorrel+',	
	'+@ComprobImpresoCorrelItem+',	'''+@EmpresaCodigo+''',	'+@EstadoAnulado+',	'+@EstadoEnvioSunat_id+',	
	'+@IdentidadCodigo+',	'''+@MonedaCodigo+''',	'+@NumeroDocumento+',	'+@NumeroDocumentoFinal+',	
	'''+@NumeroDocumentoModifica+''',	'''+@SerieDocumento+''',	'''+@SerieDocumentoModifica+''',	'''+@TipoDocumento+''',	
	'''+@TipoDocumentoModifica+''',	'+@TotalImporteExonerado+',	'+@TotalImporteGravado+',	'+@totalImporteIGV+',	
	'+@TotalImporteInafecto+',	'+@TotalImporteISC+',	'+@TotalImporteOtros+',	'+@TotalImporteVenta+'	
)  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_ComprobImpresosDetItem SET 
	ClienteCodigo='''+@ClienteCodigo+''',
	ClienteRazonSocial='''+@ClienteRazonSocial+''',
	EstadoAnulado='+@EstadoAnulado+',
	EstadoEnvioSunat_id='+@EstadoEnvioSunat_id+',
	IdentidadCodigo='+@IdentidadCodigo+',
	MonedaCodigo='''+@MonedaCodigo+''',
	NumeroDocumento='+@NumeroDocumento+',
	NumeroDocumentoFinal='+@NumeroDocumentoFinal+',
	NumeroDocumentoModifica='''+@NumeroDocumentoModifica+''',
	SerieDocumento='''+@SerieDocumento+''',
	SerieDocumentoModifica='''+@SerieDocumentoModifica+''',
	TipoDocumento='''+@TipoDocumento+''',
	TipoDocumentoModifica='''+@TipoDocumentoModifica+''',
	TotalImporteExonerado='+@TotalImporteExonerado+',
	TotalImporteGravado='+@TotalImporteGravado+',
	totalImporteIGV='+@totalImporteIGV+',
	TotalImporteInafecto='+@TotalImporteInafecto+',
	TotalImporteISC='+@TotalImporteISC+',
	TotalImporteOtros='+@TotalImporteOtros+',
	TotalImporteVenta='+@TotalImporteVenta+'

	 WHERE ComprobImpreso_Id='+@ComprobImpreso_Id+' AND 
	ComprobImpresoCorrel='+@ComprobImpresoCorrel+' AND 
	ComprobImpresoCorrelItem='+@ComprobImpresoCorrelItem+' AND 
	EmpresaCodigo='''+@EmpresaCodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  ClienteCodigo,	ClienteRazonSocial,	ComprobImpreso_Id,	ComprobImpresoCorrel,	
	ComprobImpresoCorrelItem,	EmpresaCodigo,	EstadoAnulado,	EstadoEnvioSunat_id,	
	IdentidadCodigo,	MonedaCodigo,	NumeroDocumento,	NumeroDocumentoFinal,	
	NumeroDocumentoModifica,	SerieDocumento,	SerieDocumentoModifica,	TipoDocumento,	
	TipoDocumentoModifica,	TotalImporteExonerado,	TotalImporteGravado,	totalImporteIGV,	
	TotalImporteInafecto,	TotalImporteISC,	TotalImporteOtros,	TotalImporteVenta

	
	 FROM '+@base+'.dbo.FE_ComprobImpresosDetItem'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

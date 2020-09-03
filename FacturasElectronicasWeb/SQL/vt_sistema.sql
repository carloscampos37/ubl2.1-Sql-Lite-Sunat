/*

 Insertando un registro En vt_sistema

*/
CREATE PROC vt_sistema_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@AdministratipoPago	varchar(1)='0',
@Administravuelto	varchar(1)='0',
@AdmiteNegativos	varchar(1)='0',
@CarpetaFacturasElectronicas	varchar(50)='',
@CarpetaLibrosElectronicos	varchar(50)='',
@CodigoPetroleo	varchar(20)='',
@codigosduplicados	varchar(20)='0',
@ConsolidaPtosVtasFE	varchar(1)='0',
@ContabilizaFacturacion	varchar(1)='0',
@DefaultClienteEventual	varchar(1)='0',
@empresaasientosautomaticos	varchar(20)='0',
@FacturasElectronicas	varchar(1)='0',
@familiaproyectos	varchar(10)='',
@FechadeTrabajo	varchar(25)='01/01/1900',
@generapedidotemporal	varchar(20)='0',
@id	varchar(20)='0',
@impresionvisual	varchar(20)='0',
@Pagosencaja	varchar(1)='0',
@PedidodelDia	varchar(20)='0',
@pedidotipovena	varchar(20)='',
@PedidotresPasos	varchar(1)='0',
@Preciototalxfraccion	varchar(1)='0',
@PuntoVtxCliente	varchar(1)='0',
@SaldosxLoteSerie	varchar(1)='0',
@temporalpedidos	varchar(20)='0',
@tipoanaliticocodigo	varchar(3)='',
@UtilidadMinima	varchar(1)='0'

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.vt_sistema (AdministratipoPago,	Administravuelto,	AdmiteNegativos,	CarpetaFacturasElectronicas,	
	CarpetaLibrosElectronicos,	CodigoPetroleo,	codigosduplicados,	ConsolidaPtosVtasFE,	
	ContabilizaFacturacion,	DefaultClienteEventual,	empresaasientosautomaticos,	FacturasElectronicas,	
	familiaproyectos,	FechadeTrabajo,	generapedidotemporal,	id,	
	impresionvisual,	Pagosencaja,	PedidodelDia,	pedidotipovena,	
	PedidotresPasos,	Preciototalxfraccion,	PuntoVtxCliente,	SaldosxLoteSerie,	
	temporalpedidos,	tipoanaliticocodigo,	UtilidadMinima
 )
	 VALUES('+@AdministratipoPago+',	'+@Administravuelto+',	'+@AdmiteNegativos+',	'''+@CarpetaFacturasElectronicas+''',	
	'''+@CarpetaLibrosElectronicos+''',	'''+@CodigoPetroleo+''',	'+@codigosduplicados+',	'+@ConsolidaPtosVtasFE+',	
	'+@ContabilizaFacturacion+',	'+@DefaultClienteEventual+',	'+@empresaasientosautomaticos+',	'+@FacturasElectronicas+',	
	'''+@familiaproyectos+''',	'''+@FechadeTrabajo+''',	'+@generapedidotemporal+',	'+@id+',	
	'+@impresionvisual+',	'+@Pagosencaja+',	'+@PedidodelDia+',	'''+@pedidotipovena+''',	
	'+@PedidotresPasos+',	'+@Preciototalxfraccion+',	'+@PuntoVtxCliente+',	'+@SaldosxLoteSerie+',	
	'+@temporalpedidos+',	'''+@tipoanaliticocodigo+''',	'+@UtilidadMinima+')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.vt_sistema SET 
	AdministratipoPago='+@AdministratipoPago+',
	Administravuelto='+@Administravuelto+',
	AdmiteNegativos='+@AdmiteNegativos+',
	CarpetaFacturasElectronicas='''+@CarpetaFacturasElectronicas+''',
	CarpetaLibrosElectronicos='''+@CarpetaLibrosElectronicos+''',
	CodigoPetroleo='''+@CodigoPetroleo+''',
	codigosduplicados='+@codigosduplicados+',
	ConsolidaPtosVtasFE='+@ConsolidaPtosVtasFE+',
	ContabilizaFacturacion='+@ContabilizaFacturacion+',
	DefaultClienteEventual='+@DefaultClienteEventual+',
	empresaasientosautomaticos='+@empresaasientosautomaticos+',
	FacturasElectronicas='+@FacturasElectronicas+',
	familiaproyectos='''+@familiaproyectos+''',
	FechadeTrabajo='''+@FechadeTrabajo+''',
	generapedidotemporal='+@generapedidotemporal+',
	impresionvisual='+@impresionvisual+',
	Pagosencaja='+@Pagosencaja+',
	PedidodelDia='+@PedidodelDia+',
	pedidotipovena='''+@pedidotipovena+''',
	PedidotresPasos='+@PedidotresPasos+',
	Preciototalxfraccion='+@Preciototalxfraccion+',
	PuntoVtxCliente='+@PuntoVtxCliente+',
	SaldosxLoteSerie='+@SaldosxLoteSerie+',
	temporalpedidos='+@temporalpedidos+',
	tipoanaliticocodigo='''+@tipoanaliticocodigo+''',
	UtilidadMinima='+@UtilidadMinima+'

	 WHERE id='+@id+'

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  AdministratipoPago,	Administravuelto,	AdmiteNegativos,	CarpetaFacturasElectronicas,	
	CarpetaLibrosElectronicos,	CodigoPetroleo,	codigosduplicados,	ConsolidaPtosVtasFE,	
	ContabilizaFacturacion,	DefaultClienteEventual,	empresaasientosautomaticos,	FacturasElectronicas,	
	familiaproyectos,	FechadeTrabajo,	generapedidotemporal,	id,	
	impresionvisual,	Pagosencaja,	PedidodelDia,	pedidotipovena,	
	PedidotresPasos,	Preciototalxfraccion,	PuntoVtxCliente,	SaldosxLoteSerie,	
	temporalpedidos,	tipoanaliticocodigo,	UtilidadMinima

	 FROM '+@base+'.dbo.vt_sistema'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

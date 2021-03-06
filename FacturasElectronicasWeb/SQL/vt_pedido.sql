/*

 Insertando un registro En vt_pedido

*/
CREATE PROC vt_pedido_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@almacencodigo	varchar(2)='',
@clientecodigo	varchar(11)='',
@clientedireccion	varchar(80)='',
@clientedistrito	varchar(20)='',
@clienterazonsocial	varchar(80)='',
@clienteruc	varchar(11)='',
@empresacodigo	varchar(2)='',
@EnvioSedePrincipal	varchar(1)='0',
@estadoreg	varchar(1)='0',
@fechaact	varchar(25)='01/01/1900',
@formapagocodigo	varchar(2)='',
@horaentrega	varchar(5)='',
@modovtacodigo	varchar(2)='',
@NumeroDocModifica	varchar(20)='0',
@PEDIDOATENDIDO	varchar(1)='',
@pedidoautorizacion	varchar(1)='',
@pedidocondicionfactura	varchar(2)='',
@PedidodelDia	varchar(20)='0',
@pedidodiaspago	varchar(20)='0',
@PedidoDocumentoNumero	varchar(20)='0',
@PedidoDocumentoNumerofinal	varchar(20)='0',
@PedidoDocumentoSerie	varchar(4)='',
@pedidodsctocliente	varchar(20)='0',
@pedidodsctoglobal	varchar(20)='0',
@pedidodsctoppago	varchar(20)='0',
@pedidodsctovtaoficina	varchar(20)='0',
@pedidoemisionfact	varchar(1)='0',
@pedidoentrega	varchar(70)='',
@pedidoestado	varchar(2)='',
@pedidofecha	varchar(25)='01/01/1900',
@pedidofechaanu	varchar(25)='01/01/1900',
@pedidofechafact	varchar(25)='01/01/1900',
@pedidofechapag	varchar(25)='01/01/1900',
@pedidofechasunat	varchar(25)='01/01/1900',
@pedidolistaprec	varchar(2)='',
@pedidomensaje	varchar(240)='',
@pedidomoneda	varchar(2)='',
@pedidomontodsctocliente	varchar(20)='0',
@pedidomontodsctoglobal	varchar(20)='0',
@pedidomontodsctoppago	varchar(20)='0',
@pedidomontodsctovtaoficina	varchar(20)='0',
@pedidonotaped	varchar(10)='',
@pedidonroboleta	varchar(15)='',
@pedidonrofact	varchar(15)='',
@pedidonrogiarem	varchar(15)='',
@pedidonrorefe	varchar(15)='',
@pedidonumero	varchar(15)='',
@pedidoobserva	varchar(120)='',
@pedidoordencompra	varchar(10)='',
@PedidoPagoCaja	varchar(20)='0',
@pedidoporccomision	varchar(20)='0',
@pedidotarjetacred	varchar(2)='',
@pedidotipcambio	varchar(20)='0',
@pedidotipofac	varchar(2)='',
@pedidotiporefe	varchar(2)='',
@pedidototaldsctoxitem	varchar(20)='0',
@pedidototaldsctoxlinea	varchar(20)='0',
@pedidototaldsctoxprom	varchar(20)='0',
@pedidototalflete	varchar(20)='0',
@pedidototalotros	varchar(20)='0',
@pedidototbruto	varchar(20)='0',
@pedidototimpuesto	varchar(20)='0',
@pedidototinafecto	varchar(20)='0',
@pedidototitem	varchar(20)='0',
@pedidototneto	varchar(20)='0',
@pedidoventadiferida	varchar(20)='0',
@profesionalcodigo	varchar(11)='',
@proyectocodigo	varchar(11)='',
@puntovtacodigo	varchar(2)='',
@SerieDocModifica	varchar(4)='',
@tipocontactocodigo	varchar(2)='',
@TipoDocModifica	varchar(2)='',
@transportecodigo	varchar(11)='',
@usuariocodigo	varchar(8)='',
@vendedorcodigo	varchar(3)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.vt_pedido (almacencodigo,	clientecodigo,	clientedireccion,	clientedistrito,	
	clienterazonsocial,	clienteruc,	empresacodigo,	EnvioSedePrincipal,	
	estadoreg,	fechaact,	formapagocodigo,	horaentrega,	
	modovtacodigo,	NumeroDocModifica,	PEDIDOATENDIDO,	pedidoautorizacion,	
	pedidocondicionfactura,	PedidodelDia,	pedidodiaspago,	PedidoDocumentoNumero,	
	PedidoDocumentoNumerofinal,	PedidoDocumentoSerie,	pedidodsctocliente,	pedidodsctoglobal,	
	pedidodsctoppago,	pedidodsctovtaoficina,	pedidoemisionfact,	pedidoentrega,	
	pedidoestado,	pedidofecha,	pedidofechaanu,	pedidofechafact,	
	pedidofechapag,	pedidofechasunat,	pedidolistaprec,	pedidomensaje,	
	pedidomoneda,	pedidomontodsctocliente,	pedidomontodsctoglobal,	pedidomontodsctoppago,	
	pedidomontodsctovtaoficina,	pedidonotaped,	pedidonroboleta,	pedidonrofact,	
	pedidonrogiarem,	pedidonrorefe,	pedidonumero,	pedidoobserva,	
	pedidoordencompra,	PedidoPagoCaja,	pedidoporccomision,	pedidotarjetacred,	
	pedidotipcambio,	pedidotipofac,	pedidotiporefe,	pedidototaldsctoxitem,	
	pedidototaldsctoxlinea,	pedidototaldsctoxprom,	pedidototalflete,	pedidototalotros,	
	pedidototbruto,	pedidototimpuesto,	pedidototinafecto,	pedidototitem,	
	pedidototneto,	pedidoventadiferida,	profesionalcodigo,	proyectocodigo,	
	puntovtacodigo,	SerieDocModifica,	tipocontactocodigo,	TipoDocModifica,	
	transportecodigo,	usuariocodigo,	vendedorcodigo
 )
	 VALUES('''+@almacencodigo+''',	'''+@clientecodigo+''',	'''+@clientedireccion+''',	'''+@clientedistrito+''',	
	'''+@clienterazonsocial+''',	'''+@clienteruc+''',	'''+@empresacodigo+''',	'+@EnvioSedePrincipal+',	
	'+@estadoreg+',	'''+@fechaact+''',	'''+@formapagocodigo+''',	'''+@horaentrega+''',	
	'''+@modovtacodigo+''',	'+@NumeroDocModifica+',	'''+@PEDIDOATENDIDO+''',	'''+@pedidoautorizacion+''',	
	'''+@pedidocondicionfactura+''',	'+@PedidodelDia+',	'+@pedidodiaspago+',	'+@PedidoDocumentoNumero+',	
	'+@PedidoDocumentoNumerofinal+',	'''+@PedidoDocumentoSerie+''',	'+@pedidodsctocliente+',	'+@pedidodsctoglobal+',	
	'+@pedidodsctoppago+',	'+@pedidodsctovtaoficina+',	'+@pedidoemisionfact+',	'''+@pedidoentrega+''',	
	'''+@pedidoestado+''',	'''+@pedidofecha+''',	'''+@pedidofechaanu+''',	'''+@pedidofechafact+''',	
	'''+@pedidofechapag+''',	'''+@pedidofechasunat+''',	'''+@pedidolistaprec+''',	'''+@pedidomensaje+''',	
	'''+@pedidomoneda+''',	'+@pedidomontodsctocliente+',	'+@pedidomontodsctoglobal+',	'+@pedidomontodsctoppago+',	
	'+@pedidomontodsctovtaoficina+',	'''+@pedidonotaped+''',	'''+@pedidonroboleta+''',	'''+@pedidonrofact+''',	
	'''+@pedidonrogiarem+''',	'''+@pedidonrorefe+''',	'''+@pedidonumero+''',	'''+@pedidoobserva+''',	
	'''+@pedidoordencompra+''',	'+@PedidoPagoCaja+',	'+@pedidoporccomision+',	'''+@pedidotarjetacred+''',	
	'+@pedidotipcambio+',	'''+@pedidotipofac+''',	'''+@pedidotiporefe+''',	'+@pedidototaldsctoxitem+',	
	'+@pedidototaldsctoxlinea+',	'+@pedidototaldsctoxprom+',	'+@pedidototalflete+',	'+@pedidototalotros+',	
	'+@pedidototbruto+',	'+@pedidototimpuesto+',	'+@pedidototinafecto+',	'+@pedidototitem+',	
	'+@pedidototneto+',	'+@pedidoventadiferida+',	'''+@profesionalcodigo+''',	'''+@proyectocodigo+''',	
	'''+@puntovtacodigo+''',	'''+@SerieDocModifica+''',	'''+@tipocontactocodigo+''',	'''+@TipoDocModifica+''',	
	'''+@transportecodigo+''',	'''+@usuariocodigo+''',	'''+@vendedorcodigo+''')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.vt_pedido SET 
	almacencodigo='''+@almacencodigo+''',
	clientecodigo='''+@clientecodigo+''',
	clientedireccion='''+@clientedireccion+''',
	clientedistrito='''+@clientedistrito+''',
	clienterazonsocial='''+@clienterazonsocial+''',
	clienteruc='''+@clienteruc+''',
	EnvioSedePrincipal='+@EnvioSedePrincipal+',
	estadoreg='+@estadoreg+',
	fechaact='''+@fechaact+''',
	formapagocodigo='''+@formapagocodigo+''',
	horaentrega='''+@horaentrega+''',
	modovtacodigo='''+@modovtacodigo+''',
	NumeroDocModifica='+@NumeroDocModifica+',
	PEDIDOATENDIDO='''+@PEDIDOATENDIDO+''',
	pedidoautorizacion='''+@pedidoautorizacion+''',
	pedidocondicionfactura='''+@pedidocondicionfactura+''',
	PedidodelDia='+@PedidodelDia+',
	pedidodiaspago='+@pedidodiaspago+',
	PedidoDocumentoNumero='+@PedidoDocumentoNumero+',
	PedidoDocumentoNumerofinal='+@PedidoDocumentoNumerofinal+',
	PedidoDocumentoSerie='''+@PedidoDocumentoSerie+''',
	pedidodsctocliente='+@pedidodsctocliente+',
	pedidodsctoglobal='+@pedidodsctoglobal+',
	pedidodsctoppago='+@pedidodsctoppago+',
	pedidodsctovtaoficina='+@pedidodsctovtaoficina+',
	pedidoemisionfact='+@pedidoemisionfact+',
	pedidoentrega='''+@pedidoentrega+''',
	pedidoestado='''+@pedidoestado+''',
	pedidofecha='''+@pedidofecha+''',
	pedidofechaanu='''+@pedidofechaanu+''',
	pedidofechafact='''+@pedidofechafact+''',
	pedidofechapag='''+@pedidofechapag+''',
	pedidofechasunat='''+@pedidofechasunat+''',
	pedidolistaprec='''+@pedidolistaprec+''',
	pedidomensaje='''+@pedidomensaje+''',
	pedidomoneda='''+@pedidomoneda+''',
	pedidomontodsctocliente='+@pedidomontodsctocliente+',
	pedidomontodsctoglobal='+@pedidomontodsctoglobal+',
	pedidomontodsctoppago='+@pedidomontodsctoppago+',
	pedidomontodsctovtaoficina='+@pedidomontodsctovtaoficina+',
	pedidonotaped='''+@pedidonotaped+''',
	pedidonroboleta='''+@pedidonroboleta+''',
	pedidonrofact='''+@pedidonrofact+''',
	pedidonrogiarem='''+@pedidonrogiarem+''',
	pedidonrorefe='''+@pedidonrorefe+''',
	pedidoobserva='''+@pedidoobserva+''',
	pedidoordencompra='''+@pedidoordencompra+''',
	PedidoPagoCaja='+@PedidoPagoCaja+',
	pedidoporccomision='+@pedidoporccomision+',
	pedidotarjetacred='''+@pedidotarjetacred+''',
	pedidotipcambio='+@pedidotipcambio+',
	pedidotipofac='''+@pedidotipofac+''',
	pedidotiporefe='''+@pedidotiporefe+''',
	pedidototaldsctoxitem='+@pedidototaldsctoxitem+',
	pedidototaldsctoxlinea='+@pedidototaldsctoxlinea+',
	pedidototaldsctoxprom='+@pedidototaldsctoxprom+',
	pedidototalflete='+@pedidototalflete+',
	pedidototalotros='+@pedidototalotros+',
	pedidototbruto='+@pedidototbruto+',
	pedidototimpuesto='+@pedidototimpuesto+',
	pedidototinafecto='+@pedidototinafecto+',
	pedidototitem='+@pedidototitem+',
	pedidototneto='+@pedidototneto+',
	pedidoventadiferida='+@pedidoventadiferida+',
	profesionalcodigo='''+@profesionalcodigo+''',
	proyectocodigo='''+@proyectocodigo+''',
	puntovtacodigo='''+@puntovtacodigo+''',
	SerieDocModifica='''+@SerieDocModifica+''',
	tipocontactocodigo='''+@tipocontactocodigo+''',
	TipoDocModifica='''+@TipoDocModifica+''',
	transportecodigo='''+@transportecodigo+''',
	usuariocodigo='''+@usuariocodigo+''',
	vendedorcodigo='''+@vendedorcodigo+'''

	 WHERE empresacodigo='''+@empresacodigo+''' AND 
	pedidonumero='''+@pedidonumero+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  almacencodigo,	clientecodigo,	clientedireccion,	clientedistrito,	
	clienterazonsocial,	clienteruc,	empresacodigo,	EnvioSedePrincipal,	
	estadoreg,	fechaact,	formapagocodigo,	horaentrega,	
	modovtacodigo,	NumeroDocModifica,	PEDIDOATENDIDO,	pedidoautorizacion,	
	pedidocondicionfactura,	PedidodelDia,	pedidodiaspago,	PedidoDocumentoNumero,	
	PedidoDocumentoNumerofinal,	PedidoDocumentoSerie,	pedidodsctocliente,	pedidodsctoglobal,	
	pedidodsctoppago,	pedidodsctovtaoficina,	pedidoemisionfact,	pedidoentrega,	
	pedidoestado,	pedidofecha,	pedidofechaanu,	pedidofechafact,	
	pedidofechapag,	pedidofechasunat,	pedidolistaprec,	pedidomensaje,	
	pedidomoneda,	pedidomontodsctocliente,	pedidomontodsctoglobal,	pedidomontodsctoppago,	
	pedidomontodsctovtaoficina,	pedidonotaped,	pedidonroboleta,	pedidonrofact,	
	pedidonrogiarem,	pedidonrorefe,	pedidonumero,	pedidoobserva,	
	pedidoordencompra,	PedidoPagoCaja,	pedidoporccomision,	pedidotarjetacred,	
	pedidotipcambio,	pedidotipofac,	pedidotiporefe,	pedidototaldsctoxitem,	
	pedidototaldsctoxlinea,	pedidototaldsctoxprom,	pedidototalflete,	pedidototalotros,	
	pedidototbruto,	pedidototimpuesto,	pedidototinafecto,	pedidototitem,	
	pedidototneto,	pedidoventadiferida,	profesionalcodigo,	proyectocodigo,	
	puntovtacodigo,	SerieDocModifica,	tipocontactocodigo,	TipoDocModifica,	
	transportecodigo,	usuariocodigo,	vendedorcodigo

	 FROM '+@base+'.dbo.vt_pedido'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

/*

 Insertando un registro En vt_parametroventa

*/
CREATE PROC vt_parametroventa_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@AjustesSolesxDolares	varchar(1)='0',
@almacencodigo	varchar(2)='',
@codigotransaccionventa	varchar(2)='',
@cuentaIgv	varchar(20)='',
@cuentaVtaImporte	varchar(20)='',
@cuentaVtaTotDolares	varchar(20)='',
@cuentaVtaTotSoles	varchar(20)='',
@empresacodigo	varchar(2)='',
@FacturacionenlineaContab	varchar(1)='0',
@fechaact	varchar(25)='01/01/1900',
@kitvirtual	varchar(1)='0',
@minimodetraccion	varchar(20)='0',
@monedacodigo	varchar(2)='',
@paramvtaboleta	varchar(1)='0',
@paramvtacomisionvendedor	varchar(1)='0',
@paramvtadesc	varchar(35)='',
@paramvtadescor	varchar(15)='',
@paramvtadescto	varchar(20)='0',
@paramvtadirec	varchar(30)='',
@paramvtaestdesc	varchar(1)='0',
@paramvtaestigv	varchar(1)='0',
@paramvtafax	varchar(10)='',
@paramvtaformaemision	varchar(1)='0',
@paramvtalistaprec	varchar(1)='0',
@paramvtamasivo	varchar(1)='0',
@paramvtamensaje	varchar(70)='',
@paramvtaporcigv	varchar(20)='0',
@paramvtatelefonos	varchar(25)='',
@paramvtatipcambref	varchar(20)='0',
@paramvtaValorUit	varchar(20)='0',
@PedidosSinfacturar	varchar(1)='0',
@PorcentajeCredito	varchar(20)='0',
@RangodePrecios	varchar(1)='0',
@stockcomp	varchar(1)='0',
@tesoreriaenlinea	varchar(1)='0',
@tiporedondeocobrar	varchar(20)='0',
@usuariocodigo	varchar(8)='',
@ventasBM	varchar(20)='0'

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.vt_parametroventa (AjustesSolesxDolares,	almacencodigo,	codigotransaccionventa,	cuentaIgv,	
	cuentaVtaImporte,	cuentaVtaTotDolares,	cuentaVtaTotSoles,	empresacodigo,	
	FacturacionenlineaContab,	fechaact,	kitvirtual,	minimodetraccion,	
	monedacodigo,	paramvtaboleta,	paramvtacomisionvendedor,	paramvtadesc,	
	paramvtadescor,	paramvtadescto,	paramvtadirec,	paramvtaestdesc,	
	paramvtaestigv,	paramvtafax,	paramvtaformaemision,	paramvtalistaprec,	
	paramvtamasivo,	paramvtamensaje,	paramvtaporcigv,	paramvtatelefonos,	
	paramvtatipcambref,	paramvtaValorUit,	PedidosSinfacturar,	PorcentajeCredito,	
	RangodePrecios,	stockcomp,	tesoreriaenlinea,	tiporedondeocobrar,	
	usuariocodigo,	ventasBM
 )
	 VALUES('+@AjustesSolesxDolares+',	'''+@almacencodigo+''',	'''+@codigotransaccionventa+''',	'''+@cuentaIgv+''',	
	'''+@cuentaVtaImporte+''',	'''+@cuentaVtaTotDolares+''',	'''+@cuentaVtaTotSoles+''',	'''+@empresacodigo+''',	
	'+@FacturacionenlineaContab+',	'''+@fechaact+''',	'+@kitvirtual+',	'+@minimodetraccion+',	
	'''+@monedacodigo+''',	'+@paramvtaboleta+',	'+@paramvtacomisionvendedor+',	'''+@paramvtadesc+''',	
	'''+@paramvtadescor+''',	'+@paramvtadescto+',	'''+@paramvtadirec+''',	'+@paramvtaestdesc+',	
	'+@paramvtaestigv+',	'''+@paramvtafax+''',	'+@paramvtaformaemision+',	'+@paramvtalistaprec+',	
	'+@paramvtamasivo+',	'''+@paramvtamensaje+''',	'+@paramvtaporcigv+',	'''+@paramvtatelefonos+''',	
	'+@paramvtatipcambref+',	'+@paramvtaValorUit+',	'+@PedidosSinfacturar+',	'+@PorcentajeCredito+',	
	'+@RangodePrecios+',	'+@stockcomp+',	'+@tesoreriaenlinea+',	'+@tiporedondeocobrar+',	
	'''+@usuariocodigo+''',	'+@ventasBM+')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.vt_parametroventa SET 
	AjustesSolesxDolares='+@AjustesSolesxDolares+',
	almacencodigo='''+@almacencodigo+''',
	codigotransaccionventa='''+@codigotransaccionventa+''',
	cuentaIgv='''+@cuentaIgv+''',
	cuentaVtaImporte='''+@cuentaVtaImporte+''',
	cuentaVtaTotDolares='''+@cuentaVtaTotDolares+''',
	cuentaVtaTotSoles='''+@cuentaVtaTotSoles+''',
	FacturacionenlineaContab='+@FacturacionenlineaContab+',
	fechaact='''+@fechaact+''',
	kitvirtual='+@kitvirtual+',
	minimodetraccion='+@minimodetraccion+',
	monedacodigo='''+@monedacodigo+''',
	paramvtaboleta='+@paramvtaboleta+',
	paramvtacomisionvendedor='+@paramvtacomisionvendedor+',
	paramvtadesc='''+@paramvtadesc+''',
	paramvtadescor='''+@paramvtadescor+''',
	paramvtadescto='+@paramvtadescto+',
	paramvtadirec='''+@paramvtadirec+''',
	paramvtaestdesc='+@paramvtaestdesc+',
	paramvtaestigv='+@paramvtaestigv+',
	paramvtafax='''+@paramvtafax+''',
	paramvtaformaemision='+@paramvtaformaemision+',
	paramvtalistaprec='+@paramvtalistaprec+',
	paramvtamasivo='+@paramvtamasivo+',
	paramvtamensaje='''+@paramvtamensaje+''',
	paramvtaporcigv='+@paramvtaporcigv+',
	paramvtatelefonos='''+@paramvtatelefonos+''',
	paramvtatipcambref='+@paramvtatipcambref+',
	paramvtaValorUit='+@paramvtaValorUit+',
	PedidosSinfacturar='+@PedidosSinfacturar+',
	PorcentajeCredito='+@PorcentajeCredito+',
	RangodePrecios='+@RangodePrecios+',
	stockcomp='+@stockcomp+',
	tesoreriaenlinea='+@tesoreriaenlinea+',
	tiporedondeocobrar='+@tiporedondeocobrar+',
	usuariocodigo='''+@usuariocodigo+''',
	ventasBM='+@ventasBM+'

	 WHERE empresacodigo='''+@empresacodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  AjustesSolesxDolares,	almacencodigo,	codigotransaccionventa,	cuentaIgv,	
	cuentaVtaImporte,	cuentaVtaTotDolares,	cuentaVtaTotSoles,	empresacodigo,	
	FacturacionenlineaContab,	fechaact,	kitvirtual,	minimodetraccion,	
	monedacodigo,	paramvtaboleta,	paramvtacomisionvendedor,	paramvtadesc,	
	paramvtadescor,	paramvtadescto,	paramvtadirec,	paramvtaestdesc,	
	paramvtaestigv,	paramvtafax,	paramvtaformaemision,	paramvtalistaprec,	
	paramvtamasivo,	paramvtamensaje,	paramvtaporcigv,	paramvtatelefonos,	
	paramvtatipcambref,	paramvtaValorUit,	PedidosSinfacturar,	PorcentajeCredito,	
	RangodePrecios,	stockcomp,	tesoreriaenlinea,	tiporedondeocobrar,	
	usuariocodigo,	ventasBM

	 FROM '+@base+'.dbo.vt_parametroventa'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

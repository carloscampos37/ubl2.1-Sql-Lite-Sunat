/*

 Insertando un registro En vt_detallepedido

*/
CREATE PROC vt_detallepedido_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@detpedcantdespach	varchar(20)='0',
@detpedcantdespachref	varchar(20)='0',
@detpedcantdevol	varchar(20)='0',
@detpedcantdevolref	varchar(20)='0',
@detpedcantentreg	varchar(20)='0',
@detpedcantentregref	varchar(20)='0',
@detpedcantpedida	varchar(20)='0',
@detpedcantpedidaref	varchar(20)='0',
@detpedcostopromed	varchar(20)='0',
@detpeddsctoxitem	varchar(20)='0',
@detpeddsctoxlinea	varchar(20)='0',
@detpeddsctoxprom	varchar(20)='0',
@detpedestado	varchar(1)='',
@detpedfactorconv	varchar(20)='0',
@detpedimpbruto	varchar(20)='0',
@detpeditem	varchar(3)='',
@detpedmetrica	varchar(20)='',
@detpedmontdsctoxitem	varchar(20)='0',
@detpedmontodsctoxlinea	varchar(20)='0',
@detpedmontodsctoxprom	varchar(20)='0',
@DetPedMontoImpInafecto	varchar(20)='0',
@detpedmontoimpto	varchar(20)='0',
@detpedmontoprecvta	varchar(20)='0',
@detpedobservacion	varchar(240)='',
@detpedpartida	varchar(15)='',
@detpedporccomis	varchar(20)='0',
@detpedporcimp	varchar(20)='0',
@detpedpreciocosto	varchar(20)='0',
@detpedpreciopact	varchar(20)='0',
@empresacodigo	varchar(2)='',
@pedidodocumentoNumero	varchar(20)='0',
@pedidonumero	varchar(15)='',
@productocodigo	varchar(20)='',
@unidadcodigo	varchar(5)='',
@unidadreferencial	varchar(3)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.vt_detallepedido (detpedcantdespach,	detpedcantdespachref,	detpedcantdevol,	detpedcantdevolref,	
	detpedcantentreg,	detpedcantentregref,	detpedcantpedida,	detpedcantpedidaref,	
	detpedcostopromed,	detpeddsctoxitem,	detpeddsctoxlinea,	detpeddsctoxprom,	
	detpedestado,	detpedfactorconv,	detpedimpbruto,	detpeditem,	
	detpedmetrica,	detpedmontdsctoxitem,	detpedmontodsctoxlinea,	detpedmontodsctoxprom,	
	DetPedMontoImpInafecto,	detpedmontoimpto,	detpedmontoprecvta,	detpedobservacion,	
	detpedpartida,	detpedporccomis,	detpedporcimp,	detpedpreciocosto,	
	detpedpreciopact,	empresacodigo,	pedidodocumentoNumero,	pedidonumero,	
	productocodigo,	unidadcodigo,	unidadreferencial
 )
	 VALUES('+@detpedcantdespach+',	'+@detpedcantdespachref+',	'+@detpedcantdevol+',	'+@detpedcantdevolref+',	
	'+@detpedcantentreg+',	'+@detpedcantentregref+',	'+@detpedcantpedida+',	'+@detpedcantpedidaref+',	
	'+@detpedcostopromed+',	'+@detpeddsctoxitem+',	'+@detpeddsctoxlinea+',	'+@detpeddsctoxprom+',	
	'''+@detpedestado+''',	'+@detpedfactorconv+',	'+@detpedimpbruto+',	'''+@detpeditem+''',	
	'''+@detpedmetrica+''',	'+@detpedmontdsctoxitem+',	'+@detpedmontodsctoxlinea+',	'+@detpedmontodsctoxprom+',	
	'+@DetPedMontoImpInafecto+',	'+@detpedmontoimpto+',	'+@detpedmontoprecvta+',	'''+@detpedobservacion+''',	
	'''+@detpedpartida+''',	'+@detpedporccomis+',	'+@detpedporcimp+',	'+@detpedpreciocosto+',	
	'+@detpedpreciopact+',	'''+@empresacodigo+''',	'+@pedidodocumentoNumero+',	'''+@pedidonumero+''',	
	'''+@productocodigo+''',	'''+@unidadcodigo+''',	'''+@unidadreferencial+''')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.vt_detallepedido SET 
	detpedcantdespach='+@detpedcantdespach+',
	detpedcantdespachref='+@detpedcantdespachref+',
	detpedcantdevol='+@detpedcantdevol+',
	detpedcantdevolref='+@detpedcantdevolref+',
	detpedcantentreg='+@detpedcantentreg+',
	detpedcantentregref='+@detpedcantentregref+',
	detpedcantpedida='+@detpedcantpedida+',
	detpedcantpedidaref='+@detpedcantpedidaref+',
	detpedcostopromed='+@detpedcostopromed+',
	detpeddsctoxitem='+@detpeddsctoxitem+',
	detpeddsctoxlinea='+@detpeddsctoxlinea+',
	detpeddsctoxprom='+@detpeddsctoxprom+',
	detpedestado='''+@detpedestado+''',
	detpedfactorconv='+@detpedfactorconv+',
	detpedimpbruto='+@detpedimpbruto+',
	detpedmetrica='''+@detpedmetrica+''',
	detpedmontdsctoxitem='+@detpedmontdsctoxitem+',
	detpedmontodsctoxlinea='+@detpedmontodsctoxlinea+',
	detpedmontodsctoxprom='+@detpedmontodsctoxprom+',
	DetPedMontoImpInafecto='+@DetPedMontoImpInafecto+',
	detpedmontoimpto='+@detpedmontoimpto+',
	detpedmontoprecvta='+@detpedmontoprecvta+',
	detpedobservacion='''+@detpedobservacion+''',
	detpedpartida='''+@detpedpartida+''',
	detpedporccomis='+@detpedporccomis+',
	detpedporcimp='+@detpedporcimp+',
	detpedpreciocosto='+@detpedpreciocosto+',
	detpedpreciopact='+@detpedpreciopact+',
	pedidodocumentoNumero='+@pedidodocumentoNumero+',
	productocodigo='''+@productocodigo+''',
	unidadcodigo='''+@unidadcodigo+''',
	unidadreferencial='''+@unidadreferencial+'''

	 WHERE detpeditem='''+@detpeditem+''' AND 
	empresacodigo='''+@empresacodigo+''' AND 
	pedidonumero='''+@pedidonumero+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  detpedcantdespach,	detpedcantdespachref,	detpedcantdevol,	detpedcantdevolref,	
	detpedcantentreg,	detpedcantentregref,	detpedcantpedida,	detpedcantpedidaref,	
	detpedcostopromed,	detpeddsctoxitem,	detpeddsctoxlinea,	detpeddsctoxprom,	
	detpedestado,	detpedfactorconv,	detpedimpbruto,	detpeditem,	
	detpedmetrica,	detpedmontdsctoxitem,	detpedmontodsctoxlinea,	detpedmontodsctoxprom,	
	DetPedMontoImpInafecto,	detpedmontoimpto,	detpedmontoprecvta,	detpedobservacion,	
	detpedpartida,	detpedporccomis,	detpedporcimp,	detpedpreciocosto,	
	detpedpreciopact,	empresacodigo,	pedidodocumentoNumero,	pedidonumero,	
	productocodigo,	unidadcodigo,	unidadreferencial

	 FROM '+@base+'.dbo.vt_detallepedido'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

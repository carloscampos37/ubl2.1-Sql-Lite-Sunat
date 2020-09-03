/*

 Insertando un registro En MAEART

*/
CREATE PROC MAEART_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@ACASILLERO	varchar(12)='',
@ACODIGO	varchar(20)='',
@ACODIGO2	varchar(40)='',
@ACODMON	varchar(2)='',
@ACODMONC	varchar(2)='',
@ACODPRO	varchar(50)='',
@ACOLOR	varchar(20)='',
@ACOMENTA	varchar(20)='',
@ACUENTA	varchar(18)='',
@ADESCRI	varchar(100)='',
@ADESCRI2	varchar(64)='',
@ADESCTO	varchar(20)='0',
@AFACREF	varchar(20)='0',
@AFAMILIA	varchar(10)='',
@AFDECI	varchar(1)='',
@AFECHA	varchar(25)='01/01/1900',
@AFECVEN	varchar(25)='01/01/1900',
@AFLAGIGV	varchar(1)='0',
@AFLOTE	varchar(1)='',
@AFPRELIB	varchar(1)='',
@AFRESTA	varchar(1)='',
@AFSERIE	varchar(1)='',
@AFSTOCK	varchar(50)='',
@AFUNIREF	varchar(1)='',
@AGRUPO	varchar(10)='',
@AHORA	varchar(25)='01/01/1900',
@AIGVPOR	varchar(20)='0',
@AISCPOR	varchar(20)='0',
@ALINEA	varchar(10)='',
@AMARCA	varchar(50)='',
@AMODELO	varchar(8)='',
@APCOM	varchar(20)='0',
@APDIS	varchar(20)='0',
@APESO	varchar(20)='0',
@APRECIO	varchar(20)='0',
@APRECOM	varchar(20)='0',
@ATALLA	varchar(50)='',
@ATIPO	varchar(2)='',
@AUNIART	varchar(20)='0',
@AUNIDAD	varchar(6)='',
@AUNIREF	varchar(2)='',
@AUSER	varchar(8)='',
@codigodebarras	varchar(20)='',
@EstadoAnulado	varchar(1)='0',
@estadodetraccion	varchar(1)='0',
@PA	varchar(30)='',
@ProductoBonificacion	varchar(1)='0',
@ProductoFiscalizado	varchar(1)='0',
@proyectocodigo	varchar(3)='',
@StockMinimo	varchar(20)='0',
@TALLA	varchar(3)='',
@tipodecambio	varchar(20)='0'

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.MAEART (ACASILLERO,	ACODIGO,	ACODIGO2,	ACODMON,	
	ACODMONC,	ACODPRO,	ACOLOR,	ACOMENTA,	
	ACUENTA,	ADESCRI,	ADESCRI2,	ADESCTO,	
	AFACREF,	AFAMILIA,	AFDECI,	AFECHA,	
	AFECVEN,	AFLAGIGV,	AFLOTE,	AFPRELIB,	
	AFRESTA,	AFSERIE,	AFSTOCK,	AFUNIREF,	
	AGRUPO,	AHORA,	AIGVPOR,	AISCPOR,	
	ALINEA,	AMARCA,	AMODELO,	APCOM,	
	APDIS,	APESO,	APRECIO,	APRECOM,	
	ATALLA,	ATIPO,	AUNIART,	AUNIDAD,	
	AUNIREF,	AUSER,	codigodebarras,	EstadoAnulado,	
	estadodetraccion,	PA,	ProductoBonificacion,	ProductoFiscalizado,	
	proyectocodigo,	StockMinimo,	TALLA,	tipodecambio

	 )
	 VALUES('''+@ACASILLERO+''',	'''+@ACODIGO+''',	'''+@ACODIGO2+''',	'''+@ACODMON+''',	
	'''+@ACODMONC+''',	'''+@ACODPRO+''',	'''+@ACOLOR+''',	'''+@ACOMENTA+''',	
	'''+@ACUENTA+''',	'''+@ADESCRI+''',	'''+@ADESCRI2+''',	'+@ADESCTO+',	
	'+@AFACREF+',	'''+@AFAMILIA+''',	'''+@AFDECI+''',	'''+@AFECHA+''',	
	'''+@AFECVEN+''',	'+@AFLAGIGV+',	'''+@AFLOTE+''',	'''+@AFPRELIB+''',	
	'''+@AFRESTA+''',	'''+@AFSERIE+''',	'''+@AFSTOCK+''',	'''+@AFUNIREF+''',	
	'''+@AGRUPO+''',	'''+@AHORA+''',	'+@AIGVPOR+',	'+@AISCPOR+',	
	'''+@ALINEA+''',	'''+@AMARCA+''',	'''+@AMODELO+''',	'+@APCOM+',	
	'+@APDIS+',	'+@APESO+',	'+@APRECIO+',	'+@APRECOM+',	
	'''+@ATALLA+''',	'''+@ATIPO+''',	'+@AUNIART+',	'''+@AUNIDAD+''',	
	'''+@AUNIREF+''',	'''+@AUSER+''',	'''+@codigodebarras+''',	'+@EstadoAnulado+',	
	'+@estadodetraccion+',	'''+@PA+''',	'+@ProductoBonificacion+',	'+@ProductoFiscalizado+',	
	'''+@proyectocodigo+''',	'+@StockMinimo+',	'''+@TALLA+''',	'+@tipodecambio+'	
)  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.MAEART SET 
	ACASILLERO='''+@ACASILLERO+''',
	ACODIGO2='''+@ACODIGO2+''',
	ACODMON='''+@ACODMON+''',
	ACODMONC='''+@ACODMONC+''',
	ACODPRO='''+@ACODPRO+''',
	ACOLOR='''+@ACOLOR+''',
	ACOMENTA='''+@ACOMENTA+''',
	ACUENTA='''+@ACUENTA+''',
	ADESCRI='''+@ADESCRI+''',
	ADESCRI2='''+@ADESCRI2+''',
	ADESCTO='+@ADESCTO+',
	AFACREF='+@AFACREF+',
	AFAMILIA='''+@AFAMILIA+''',
	AFDECI='''+@AFDECI+''',
	AFECHA='''+@AFECHA+''',
	AFECVEN='''+@AFECVEN+''',
	AFLAGIGV='+@AFLAGIGV+',
	AFLOTE='''+@AFLOTE+''',
	AFPRELIB='''+@AFPRELIB+''',
	AFRESTA='''+@AFRESTA+''',
	AFSERIE='''+@AFSERIE+''',
	AFSTOCK='''+@AFSTOCK+''',
	AFUNIREF='''+@AFUNIREF+''',
	AGRUPO='''+@AGRUPO+''',
	AHORA='''+@AHORA+''',
	AIGVPOR='+@AIGVPOR+',
	AISCPOR='+@AISCPOR+',
	ALINEA='''+@ALINEA+''',
	AMARCA='''+@AMARCA+''',
	AMODELO='''+@AMODELO+''',
	APCOM='+@APCOM+',
	APDIS='+@APDIS+',
	APESO='+@APESO+',
	APRECIO='+@APRECIO+',
	APRECOM='+@APRECOM+',
	ATALLA='''+@ATALLA+''',
	ATIPO='''+@ATIPO+''',
	AUNIART='+@AUNIART+',
	AUNIDAD='''+@AUNIDAD+''',
	AUNIREF='''+@AUNIREF+''',
	AUSER='''+@AUSER+''',
	codigodebarras='''+@codigodebarras+''',
	EstadoAnulado='+@EstadoAnulado+',
	estadodetraccion='+@estadodetraccion+',
	PA='''+@PA+''',
	ProductoBonificacion='+@ProductoBonificacion+',
	ProductoFiscalizado='+@ProductoFiscalizado+',
	proyectocodigo='''+@proyectocodigo+''',
	StockMinimo='+@StockMinimo+',
	TALLA='''+@TALLA+''',
	tipodecambio='+@tipodecambio+'

	 WHERE ACODIGO='''+@ACODIGO+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  ACASILLERO,	ACODIGO,	ACODIGO2,	ACODMON,	
	ACODMONC,	ACODPRO,	ACOLOR,	ACOMENTA,	
	ACUENTA,	ADESCRI,	ADESCRI2,	ADESCTO,	
	AFACREF,	AFAMILIA,	AFDECI,	AFECHA,	
	AFECVEN,	AFLAGIGV,	AFLOTE,	AFPRELIB,	
	AFRESTA,	AFSERIE,	AFSTOCK,	AFUNIREF,	
	AGRUPO,	AHORA,	AIGVPOR,	AISCPOR,	
	ALINEA,	AMARCA,	AMODELO,	APCOM,	
	APDIS,	APESO,	APRECIO,	APRECOM,	
	ATALLA,	ATIPO,	AUNIART,	AUNIDAD,	
	AUNIREF,	AUSER,	codigodebarras,	EstadoAnulado,	
	estadodetraccion,	PA,	ProductoBonificacion,	ProductoFiscalizado,	
	proyectocodigo,	StockMinimo,	TALLA,	tipodecambio

	
	 FROM '+@base+'.dbo.MAEART'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

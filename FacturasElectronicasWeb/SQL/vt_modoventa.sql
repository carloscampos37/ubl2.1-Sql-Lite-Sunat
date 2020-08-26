/*

 Insertando un registro En vt_modoventa

*/
CREATE PROC vt_modoventa_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@documentocodigo	varchar(2)='',
@fechaact	varchar(25)='01/01/1900',
@modovtaactctacte	varchar(1)='0',
@modovtaalmacen	varchar(60)='',
@modovtacanje	varchar(1)='',
@modovtacodigo	varchar(2)='',
@modovtacontrolcorr	varchar(1)='0',
@modovtacopiasBO	varchar(20)='0',
@modovtacopiasboleta	varchar(20)='0',
@modovtacopiasfact	varchar(20)='0',
@modovtacopiasguiarem	varchar(20)='0',
@modovtacopiashojatrab	varchar(20)='0',
@modovtacopiasticket	varchar(20)='0',
@modovtacorrguiarem	varchar(1)='0',
@modovtacrtlfact	varchar(20)='0',
@modovtactrlinventario	varchar(1)='0',
@modovtadescrcorta	varchar(15)='',
@modovtadescripcion	varchar(30)='',
@modovtadscto	varchar(1)='',
@modovtaemiteguia	varchar(1)='0',
@modovtaemitehoja	varchar(1)='0',
@modovtaimpuestos	varchar(1)='0',
@modovtaingcodclie	varchar(1)='0',
@modovtaingformapag	varchar(1)='0',
@modovtaingguiarem	varchar(1)='0',
@modovtainghastafact	varchar(1)='0',
@modovtainghastahoja	varchar(1)='0',
@modovtainghojatrab	varchar(1)='0',
@modovtaingpedido	varchar(1)='0',
@modovtaitemxdoc	varchar(20)='0',
@modovtanumautom	varchar(1)='0',
@modovtasolemitfact	varchar(1)='0',
@modovtaunidadmedida	varchar(3)='',
@modovtausafactconv	varchar(1)='0',
@puntovtacodigo	varchar(2)='',
@usuariocodigo	varchar(8)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.vt_modoventa (documentocodigo,	fechaact,	modovtaactctacte,	modovtaalmacen,	
	modovtacanje,	modovtacodigo,	modovtacontrolcorr,	modovtacopiasBO,	
	modovtacopiasboleta,	modovtacopiasfact,	modovtacopiasguiarem,	modovtacopiashojatrab,	
	modovtacopiasticket,	modovtacorrguiarem,	modovtacrtlfact,	modovtactrlinventario,	
	modovtadescrcorta,	modovtadescripcion,	modovtadscto,	modovtaemiteguia,	
	modovtaemitehoja,	modovtaimpuestos,	modovtaingcodclie,	modovtaingformapag,	
	modovtaingguiarem,	modovtainghastafact,	modovtainghastahoja,	modovtainghojatrab,	
	modovtaingpedido,	modovtaitemxdoc,	modovtanumautom,	modovtasolemitfact,	
	modovtaunidadmedida,	modovtausafactconv,	puntovtacodigo,	usuariocodigo

	 )
	 VALUES('''+@documentocodigo+''',	'''+@fechaact+''',	'+@modovtaactctacte+',	'''+@modovtaalmacen+''',	
	'''+@modovtacanje+''',	'''+@modovtacodigo+''',	'+@modovtacontrolcorr+',	'+@modovtacopiasBO+',	
	'+@modovtacopiasboleta+',	'+@modovtacopiasfact+',	'+@modovtacopiasguiarem+',	'+@modovtacopiashojatrab+',	
	'+@modovtacopiasticket+',	'+@modovtacorrguiarem+',	'+@modovtacrtlfact+',	'+@modovtactrlinventario+',	
	'''+@modovtadescrcorta+''',	'''+@modovtadescripcion+''',	'''+@modovtadscto+''',	'+@modovtaemiteguia+',	
	'+@modovtaemitehoja+',	'+@modovtaimpuestos+',	'+@modovtaingcodclie+',	'+@modovtaingformapag+',	
	'+@modovtaingguiarem+',	'+@modovtainghastafact+',	'+@modovtainghastahoja+',	'+@modovtainghojatrab+',	
	'+@modovtaingpedido+',	'+@modovtaitemxdoc+',	'+@modovtanumautom+',	'+@modovtasolemitfact+',	
	'''+@modovtaunidadmedida+''',	'+@modovtausafactconv+',	'''+@puntovtacodigo+''',	'''+@usuariocodigo+'''	
)  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.vt_modoventa SET 
	documentocodigo='''+@documentocodigo+''',
	fechaact='''+@fechaact+''',
	modovtaactctacte='+@modovtaactctacte+',
	modovtaalmacen='''+@modovtaalmacen+''',
	modovtacanje='''+@modovtacanje+''',
	modovtacontrolcorr='+@modovtacontrolcorr+',
	modovtacopiasBO='+@modovtacopiasBO+',
	modovtacopiasboleta='+@modovtacopiasboleta+',
	modovtacopiasfact='+@modovtacopiasfact+',
	modovtacopiasguiarem='+@modovtacopiasguiarem+',
	modovtacopiashojatrab='+@modovtacopiashojatrab+',
	modovtacopiasticket='+@modovtacopiasticket+',
	modovtacorrguiarem='+@modovtacorrguiarem+',
	modovtacrtlfact='+@modovtacrtlfact+',
	modovtactrlinventario='+@modovtactrlinventario+',
	modovtadescrcorta='''+@modovtadescrcorta+''',
	modovtadescripcion='''+@modovtadescripcion+''',
	modovtadscto='''+@modovtadscto+''',
	modovtaemiteguia='+@modovtaemiteguia+',
	modovtaemitehoja='+@modovtaemitehoja+',
	modovtaimpuestos='+@modovtaimpuestos+',
	modovtaingcodclie='+@modovtaingcodclie+',
	modovtaingformapag='+@modovtaingformapag+',
	modovtaingguiarem='+@modovtaingguiarem+',
	modovtainghastafact='+@modovtainghastafact+',
	modovtainghastahoja='+@modovtainghastahoja+',
	modovtainghojatrab='+@modovtainghojatrab+',
	modovtaingpedido='+@modovtaingpedido+',
	modovtaitemxdoc='+@modovtaitemxdoc+',
	modovtanumautom='+@modovtanumautom+',
	modovtasolemitfact='+@modovtasolemitfact+',
	modovtaunidadmedida='''+@modovtaunidadmedida+''',
	modovtausafactconv='+@modovtausafactconv+',
	puntovtacodigo='''+@puntovtacodigo+''',
	usuariocodigo='''+@usuariocodigo+'''

	 WHERE modovtacodigo='''+@modovtacodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  documentocodigo,	fechaact,	modovtaactctacte,	modovtaalmacen,	
	modovtacanje,	modovtacodigo,	modovtacontrolcorr,	modovtacopiasBO,	
	modovtacopiasboleta,	modovtacopiasfact,	modovtacopiasguiarem,	modovtacopiashojatrab,	
	modovtacopiasticket,	modovtacorrguiarem,	modovtacrtlfact,	modovtactrlinventario,	
	modovtadescrcorta,	modovtadescripcion,	modovtadscto,	modovtaemiteguia,	
	modovtaemitehoja,	modovtaimpuestos,	modovtaingcodclie,	modovtaingformapag,	
	modovtaingguiarem,	modovtainghastafact,	modovtainghastahoja,	modovtainghojatrab,	
	modovtaingpedido,	modovtaitemxdoc,	modovtanumautom,	modovtasolemitfact,	
	modovtaunidadmedida,	modovtausafactconv,	puntovtacodigo,	usuariocodigo

	
	 FROM '+@base+'.dbo.vt_modoventa'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

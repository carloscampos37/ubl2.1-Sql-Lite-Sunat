/*

 Insertando un registro En vt_puntoventa

*/
CREATE PROC vt_puntoventa_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@administraproyectos	varchar(20)='0',
@codigocajavtas	varchar(20)='',
@codigocajavtasDol	varchar(2)='',
@codigocajavtassoles	varchar(2)='',
@direccioncomercial	varchar(60)='',
@fechaact	varchar(25)='01/01/1900',
@puntovtaautomat	varchar(1)='0',
@puntovtacodigo	varchar(2)='',
@puntovtadescripcion	varchar(20)='',
@puntovtanotaabono	varchar(1)='0',
@puntovtanotacargo	varchar(1)='0',
@puntovtanroBoleta	varchar(1)='0',
@puntovtanrofact	varchar(1)='0',
@puntovtanroguia	varchar(1)='0',
@puntovtanroguiarem	varchar(1)='0',
@puntovtanropedido	varchar(1)='0',
@puntovtaNumDocumentos	varchar(1)='0',
@puntovtaticket	varchar(1)='0',
@puntovtaventasAuto	varchar(1)='0',
@usuariocodigo	varchar(8)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.vt_puntoventa (administraproyectos,	codigocajavtas,	codigocajavtasDol,	codigocajavtassoles,	
	direccioncomercial,	fechaact,	puntovtaautomat,	puntovtacodigo,	
	puntovtadescripcion,	puntovtanotaabono,	puntovtanotacargo,	puntovtanroBoleta,	
	puntovtanrofact,	puntovtanroguia,	puntovtanroguiarem,	puntovtanropedido,	
	puntovtaNumDocumentos,	puntovtaticket,	puntovtaventasAuto,	usuariocodigo

	 )
	 VALUES('+@administraproyectos+',	'''+@codigocajavtas+''',	'''+@codigocajavtasDol+''',	'''+@codigocajavtassoles+''',	
	'''+@direccioncomercial+''',	'''+@fechaact+''',	'+@puntovtaautomat+',	'''+@puntovtacodigo+''',	
	'''+@puntovtadescripcion+''',	'+@puntovtanotaabono+',	'+@puntovtanotacargo+',	'+@puntovtanroBoleta+',	
	'+@puntovtanrofact+',	'+@puntovtanroguia+',	'+@puntovtanroguiarem+',	'+@puntovtanropedido+',	
	'+@puntovtaNumDocumentos+',	'+@puntovtaticket+',	'+@puntovtaventasAuto+',	'''+@usuariocodigo+'''	
)  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.vt_puntoventa SET 
	administraproyectos='+@administraproyectos+',
	codigocajavtas='''+@codigocajavtas+''',
	codigocajavtasDol='''+@codigocajavtasDol+''',
	codigocajavtassoles='''+@codigocajavtassoles+''',
	direccioncomercial='''+@direccioncomercial+''',
	fechaact='''+@fechaact+''',
	puntovtaautomat='+@puntovtaautomat+',
	puntovtadescripcion='''+@puntovtadescripcion+''',
	puntovtanotaabono='+@puntovtanotaabono+',
	puntovtanotacargo='+@puntovtanotacargo+',
	puntovtanroBoleta='+@puntovtanroBoleta+',
	puntovtanrofact='+@puntovtanrofact+',
	puntovtanroguia='+@puntovtanroguia+',
	puntovtanroguiarem='+@puntovtanroguiarem+',
	puntovtanropedido='+@puntovtanropedido+',
	puntovtaNumDocumentos='+@puntovtaNumDocumentos+',
	puntovtaticket='+@puntovtaticket+',
	puntovtaventasAuto='+@puntovtaventasAuto+',
	usuariocodigo='''+@usuariocodigo+'''

	 WHERE puntovtacodigo='''+@puntovtacodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  administraproyectos,	codigocajavtas,	codigocajavtasDol,	codigocajavtassoles,	
	direccioncomercial,	fechaact,	puntovtaautomat,	puntovtacodigo,	
	puntovtadescripcion,	puntovtanotaabono,	puntovtanotacargo,	puntovtanroBoleta,	
	puntovtanrofact,	puntovtanroguia,	puntovtanroguiarem,	puntovtanropedido,	
	puntovtaNumDocumentos,	puntovtaticket,	puntovtaventasAuto,	usuariocodigo

	
	 FROM '+@base+'.dbo.vt_puntoventa'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

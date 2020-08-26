/*

 Insertando un registro En Listapre1

*/
CREATE PROC Listapre1_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@Descuento1	varchar(20)='0',
@empresacodigo	varchar(2)='',
@grupovtacodigo	varchar(2)='',
@monedacodigo	varchar(2)='',
@productocategoriacodigo	varchar(3)='',
@productocodigo	varchar(20)='',
@productodescrcorta	varchar(30)='',
@productodescripcion	varchar(100)='',
@productoestunidreferencia	varchar(1)='0',
@productofamiliacodigo	varchar(5)='',
@productoporcimpto	varchar(20)='0',
@productoprecvta	varchar(20)='0',
@productoprecvtaEtiqueta03	varchar(20)='0',
@productoprecvtaEtiqueta06	varchar(20)='0',
@productoprecvtaEtiqueta12	varchar(20)='0',
@productoprecvtaMayor	varchar(20)='0',
@productoprecvtaofi	varchar(20)='0',
@productoprecvtaPresentacion	varchar(20)='0',
@productoprecvtareparto	varchar(20)='0',
@productotipo	varchar(1)='',
@unidadcodigo	varchar(5)='',
@unidadfactorconv	varchar(20)='0',
@unidadreferencial	varchar(5)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.Listapre1 (Descuento1,	empresacodigo,	grupovtacodigo,	monedacodigo,	
	productocategoriacodigo,	productocodigo,	productodescrcorta,	productodescripcion,	
	productoestunidreferencia,	productofamiliacodigo,	productoporcimpto,	productoprecvta,	
	productoprecvtaEtiqueta03,	productoprecvtaEtiqueta06,	productoprecvtaEtiqueta12,	productoprecvtaMayor,	
	productoprecvtaofi,	productoprecvtaPresentacion,	productoprecvtareparto,	productotipo,	
	unidadcodigo,	unidadfactorconv,	unidadreferencial
 )
	 VALUES('+@Descuento1+',	'''+@empresacodigo+''',	'''+@grupovtacodigo+''',	'''+@monedacodigo+''',	
	'''+@productocategoriacodigo+''',	'''+@productocodigo+''',	'''+@productodescrcorta+''',	'''+@productodescripcion+''',	
	'+@productoestunidreferencia+',	'''+@productofamiliacodigo+''',	'+@productoporcimpto+',	'+@productoprecvta+',	
	'+@productoprecvtaEtiqueta03+',	'+@productoprecvtaEtiqueta06+',	'+@productoprecvtaEtiqueta12+',	'+@productoprecvtaMayor+',	
	'+@productoprecvtaofi+',	'+@productoprecvtaPresentacion+',	'+@productoprecvtareparto+',	'''+@productotipo+''',	
	'''+@unidadcodigo+''',	'+@unidadfactorconv+',	'''+@unidadreferencial+''')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.Listapre1 SET 
	Descuento1='+@Descuento1+',
	empresacodigo='''+@empresacodigo+''',
	grupovtacodigo='''+@grupovtacodigo+''',
	monedacodigo='''+@monedacodigo+''',
	productocategoriacodigo='''+@productocategoriacodigo+''',
	productodescrcorta='''+@productodescrcorta+''',
	productodescripcion='''+@productodescripcion+''',
	productoestunidreferencia='+@productoestunidreferencia+',
	productofamiliacodigo='''+@productofamiliacodigo+''',
	productoporcimpto='+@productoporcimpto+',
	productoprecvta='+@productoprecvta+',
	productoprecvtaEtiqueta03='+@productoprecvtaEtiqueta03+',
	productoprecvtaEtiqueta06='+@productoprecvtaEtiqueta06+',
	productoprecvtaEtiqueta12='+@productoprecvtaEtiqueta12+',
	productoprecvtaMayor='+@productoprecvtaMayor+',
	productoprecvtaofi='+@productoprecvtaofi+',
	productoprecvtaPresentacion='+@productoprecvtaPresentacion+',
	productoprecvtareparto='+@productoprecvtareparto+',
	productotipo='''+@productotipo+''',
	unidadcodigo='''+@unidadcodigo+''',
	unidadfactorconv='+@unidadfactorconv+',
	unidadreferencial='''+@unidadreferencial+'''

	 WHERE productocodigo='''+@productocodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  Descuento1,	empresacodigo,	grupovtacodigo,	monedacodigo,	
	productocategoriacodigo,	productocodigo,	productodescrcorta,	productodescripcion,	
	productoestunidreferencia,	productofamiliacodigo,	productoporcimpto,	productoprecvta,	
	productoprecvtaEtiqueta03,	productoprecvtaEtiqueta06,	productoprecvtaEtiqueta12,	productoprecvtaMayor,	
	productoprecvtaofi,	productoprecvtaPresentacion,	productoprecvtareparto,	productotipo,	
	unidadcodigo,	unidadfactorconv,	unidadreferencial

	 FROM '+@base+'.dbo.Listapre1'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

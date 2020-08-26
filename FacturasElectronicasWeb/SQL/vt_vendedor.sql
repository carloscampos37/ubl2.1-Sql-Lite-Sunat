/*

 Insertando un registro En vt_vendedor

*/
CREATE PROC vt_vendedor_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@estadoreg	varchar(1)='0',
@fechaact	varchar(25)='01/01/1900',
@usuariocodigo	varchar(8)='',
@vendedorcodigo	varchar(3)='',
@vendedorcomis1	varchar(20)='0',
@vendedorcomis2	varchar(20)='0',
@vendedorcomis3	varchar(20)='0',
@vendedordireccion	varchar(30)='',
@vendedorle	varchar(8)='',
@vendedornombres	varchar(50)='',
@vendedorreferencia	varchar(30)='',
@vendedorruc	varchar(15)='',
@vendedortelefono	varchar(15)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.vt_vendedor (estadoreg,	fechaact,	usuariocodigo,	vendedorcodigo,	
	vendedorcomis1,	vendedorcomis2,	vendedorcomis3,	vendedordireccion,	
	vendedorle,	vendedornombres,	vendedorreferencia,	vendedorruc,	
	vendedortelefono
 )
	 VALUES('+@estadoreg+',	'''+@fechaact+''',	'''+@usuariocodigo+''',	'''+@vendedorcodigo+''',	
	'+@vendedorcomis1+',	'+@vendedorcomis2+',	'+@vendedorcomis3+',	'''+@vendedordireccion+''',	
	'''+@vendedorle+''',	'''+@vendedornombres+''',	'''+@vendedorreferencia+''',	'''+@vendedorruc+''',	
	'''+@vendedortelefono+''')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.vt_vendedor SET 
	estadoreg='+@estadoreg+',
	fechaact='''+@fechaact+''',
	usuariocodigo='''+@usuariocodigo+''',
	vendedorcodigo='''+@vendedorcodigo+''',
	vendedorcomis1='+@vendedorcomis1+',
	vendedorcomis2='+@vendedorcomis2+',
	vendedorcomis3='+@vendedorcomis3+',
	vendedordireccion='''+@vendedordireccion+''',
	vendedorle='''+@vendedorle+''',
	vendedornombres='''+@vendedornombres+''',
	vendedorreferencia='''+@vendedorreferencia+''',
	vendedorruc='''+@vendedorruc+''',
	vendedortelefono='''+@vendedortelefono+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  estadoreg,	fechaact,	usuariocodigo,	vendedorcodigo,	
	vendedorcomis1,	vendedorcomis2,	vendedorcomis3,	vendedordireccion,	
	vendedorle,	vendedornombres,	vendedorreferencia,	vendedorruc,	
	vendedortelefono

	 FROM '+@base+'.dbo.vt_vendedor'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

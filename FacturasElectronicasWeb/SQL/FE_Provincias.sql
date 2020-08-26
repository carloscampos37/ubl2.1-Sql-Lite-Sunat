/*

 Insertando un registro En FE_Provincias

*/
CREATE PROC FE_Provincias_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@ProvinciaCodigo	varchar(10)='',
@ProvinciaDescripcion	varchar(30)='',
@RegionCodigo	varchar(10)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_Provincias (ProvinciaCodigo,	ProvinciaDescripcion,	RegionCodigo
 )
	 VALUES('''+@ProvinciaCodigo+''',	'''+@ProvinciaDescripcion+''',	'''+@RegionCodigo+''')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_Provincias SET 
	ProvinciaDescripcion='''+@ProvinciaDescripcion+''',
	RegionCodigo='''+@RegionCodigo+'''

	 WHERE ProvinciaCodigo='''+@ProvinciaCodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  ProvinciaCodigo,	ProvinciaDescripcion,	RegionCodigo

	 FROM '+@base+'.dbo.FE_Provincias'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

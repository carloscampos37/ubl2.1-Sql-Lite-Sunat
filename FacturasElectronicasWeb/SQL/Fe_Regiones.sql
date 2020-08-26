/*

 Insertando un registro En Fe_Regiones

*/
CREATE PROC Fe_Regiones_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@RegionCodigo	varchar(10)='',
@RegionDescripcion	varchar(30)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.Fe_Regiones (RegionCodigo,	RegionDescripcion
 )
	 VALUES('''+@RegionCodigo+''',	'''+@RegionDescripcion+''')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.Fe_Regiones SET 
	RegionDescripcion='''+@RegionDescripcion+'''

	 WHERE RegionCodigo='''+@RegionCodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  RegionCodigo,	RegionDescripcion

	 FROM '+@base+'.dbo.Fe_Regiones'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

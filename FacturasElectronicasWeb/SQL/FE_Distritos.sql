/*

 Insertando un registro En FE_Distritos

*/
CREATE PROC FE_Distritos_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@DistritoCodigo	varchar(10)='',
@DistritoDescripcion	varchar(40)='',
@ProvinciaCodigo	varchar(10)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_Distritos (DistritoCodigo,	DistritoDescripcion,	ProvinciaCodigo
 )
	 VALUES('''+@DistritoCodigo+''',	'''+@DistritoDescripcion+''',	'''+@ProvinciaCodigo+''')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_Distritos SET 
	DistritoDescripcion='''+@DistritoDescripcion+''',
	ProvinciaCodigo='''+@ProvinciaCodigo+'''

	 WHERE DistritoCodigo='''+@DistritoCodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  DistritoCodigo,	DistritoDescripcion,	ProvinciaCodigo

	 FROM '+@base+'.dbo.FE_Distritos'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

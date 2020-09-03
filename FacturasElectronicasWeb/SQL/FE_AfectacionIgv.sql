/*

 Insertando un registro En FE_AfectacionIgv

*/
CREATE PROC FE_AfectacionIgv_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@Codigo	varchar(4)='',
@Id	varchar(1)='',
@Menotecnico	varchar(10)='',
@Nombre	varchar(10)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_AfectacionIgv (Codigo,	Id,	Menotecnico,	Nombre

	 )
	 VALUES('''+@Codigo+''',	'''+@Id+''',	'''+@Menotecnico+''',	'''+@Nombre+'''	
)  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_AfectacionIgv SET 
	Codigo='''+@Codigo+''',
	Menotecnico='''+@Menotecnico+''',
	Nombre='''+@Nombre+'''

	 WHERE Id='''+@Id+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  Codigo,	Id,	Menotecnico,	Nombre

	
	 FROM '+@base+'.dbo.FE_AfectacionIgv'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

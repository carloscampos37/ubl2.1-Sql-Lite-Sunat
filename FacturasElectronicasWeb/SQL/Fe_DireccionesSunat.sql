/*

 Insertando un registro En Fe_DireccionesSunat

*/
CREATE PROC Fe_DireccionesSunat_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@DireccionSunat_Id	varchar(20)='0',
@DireccionSunatTipo	varchar(50)='',
@DireccionSunatUrl	varchar(120)='',
@EstadoAnulado	varchar(1)='0'

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.Fe_DireccionesSunat (DireccionSunat_Id,	DireccionSunatTipo,	DireccionSunatUrl,	EstadoAnulado

	 )
	 VALUES('+@DireccionSunat_Id+',	'''+@DireccionSunatTipo+''',	'''+@DireccionSunatUrl+''',	'+@EstadoAnulado+'	
)  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.Fe_DireccionesSunat SET 
	DireccionSunatTipo='''+@DireccionSunatTipo+''',
	DireccionSunatUrl='''+@DireccionSunatUrl+''',
	EstadoAnulado='+@EstadoAnulado+'

	 WHERE DireccionSunat_Id='+@DireccionSunat_Id+'

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  DireccionSunat_Id,	DireccionSunatTipo,	DireccionSunatUrl,	EstadoAnulado

	
	 FROM '+@base+'.dbo.Fe_DireccionesSunat'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

/*

 Insertando un registro En FE_TiposMotivoNotasContables

*/
CREATE PROC FE_TiposMotivoNotasContables_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@DocumentoCodigo	varchar(2)='',
@EstadoAnulado	varchar(1)='0',
@TipoMotivoDescripcion	varchar(50)='',
@TipoMotivoNota	varchar(2)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_TiposMotivoNotasContables (DocumentoCodigo,	EstadoAnulado,	TipoMotivoDescripcion,	TipoMotivoNota

	 )
	 VALUES('''+@DocumentoCodigo+''',	'+@EstadoAnulado+',	'''+@TipoMotivoDescripcion+''',	'''+@TipoMotivoNota+'''	
)  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_TiposMotivoNotasContables SET 
	EstadoAnulado='+@EstadoAnulado+',
	TipoMotivoDescripcion='''+@TipoMotivoDescripcion+''',
	
	 WHERE DocumentoCodigo='''+@DocumentoCodigo+''' AND 
	TipoMotivoNota='''+@TipoMotivoNota+'''


	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  DocumentoCodigo,	EstadoAnulado,	TipoMotivoDescripcion,	TipoMotivoNota

	
	 FROM '+@base+'.dbo.FE_TiposMotivoNotasContables'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

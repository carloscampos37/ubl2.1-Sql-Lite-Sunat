/*

 Insertando un registro En FE_DocumentosxEmpresa

*/
CREATE PROC FE_DocumentosxEmpresa_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@DocumentoCodigo	varchar(2)='',
@EmpresaCodigo	varchar(3)='',
@EstadoAnulado	varchar(1)='0'

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_DocumentosxEmpresa (DocumentoCodigo,	EmpresaCodigo,	EstadoAnulado
 )
	 VALUES('''+@DocumentoCodigo+''',	'''+@EmpresaCodigo+''',	'+@EstadoAnulado+')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_DocumentosxEmpresa SET 
	EstadoAnulado='+@EstadoAnulado+'

	 WHERE DocumentoCodigo='''+@DocumentoCodigo+''' AND 
	EmpresaCodigo='''+@EmpresaCodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  DocumentoCodigo,	EmpresaCodigo,	EstadoAnulado

	 FROM '+@base+'.dbo.FE_DocumentosxEmpresa'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

/*

 Insertando un registro En FE_Productos

*/
CREATE PROC FE_Productos_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@EmpresaCodigo	varchar(3)='',
@EstadoAnulado	varchar(1)='0',
@PorcentajeIgv	varchar(20)='0',
@PrecioVta	varchar(20)='0',
@ProductoCodigo	varchar(20)='',
@ProductoDescripcion	varchar(100)='',
@ProductoServicios	varchar(1)='0',
@UnidadMedida_Id	varchar(10)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_Productos (EmpresaCodigo,	EstadoAnulado,	PorcentajeIgv,	PrecioVta,	
	ProductoCodigo,	ProductoDescripcion,	ProductoServicios,	UnidadMedida_Id

	 )
	 VALUES('''+@EmpresaCodigo+''',	'+@EstadoAnulado+',	'+@PorcentajeIgv+',	'+@PrecioVta+',	
	'''+@ProductoCodigo+''',	'''+@ProductoDescripcion+''',	'+@ProductoServicios+',	'''+@UnidadMedida_Id+'''	
)  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_Productos SET 
	EstadoAnulado='+@EstadoAnulado+',
	PorcentajeIgv='+@PorcentajeIgv+',
	PrecioVta='+@PrecioVta+',
	ProductoDescripcion='''+@ProductoDescripcion+''',
	ProductoServicios='+@ProductoServicios+',
	UnidadMedida_Id='''+@UnidadMedida_Id+'''

	 WHERE EmpresaCodigo='''+@EmpresaCodigo+''' AND 
	ProductoCodigo='''+@ProductoCodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  EmpresaCodigo,	EstadoAnulado,	PorcentajeIgv,	PrecioVta,	
	ProductoCodigo,	ProductoDescripcion,	ProductoServicios,	UnidadMedida_Id

	
	 FROM '+@base+'.dbo.FE_Productos'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

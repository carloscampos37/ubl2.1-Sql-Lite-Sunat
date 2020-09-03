/*

 Insertando un registro En FE_DocumentosElectronicosDetItem

*/
CREATE PROC FE_DocumentosElectronicosDetItem_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@DocumentosElectronicos_id	varchar(20)='0',
@DocumentosElectronicosCorrel	varchar(20)='0',
@DocumentosElectronicosCorrelItem	varchar(20)='0',
@EmpresaCodigo	varchar(3)='',
@ItemDescuento	varchar(20)='0',
@ItemExonerado	varchar(20)='0',
@ItemGravado	varchar(20)='0',
@ItemIGV	varchar(20)='0',
@ItemInafecto	varchar(20)='0',
@ItemISC	varchar(20)='0',
@ItemOtros	varchar(20)='0',
@ItemVenta	varchar(20)='0',
@PrecioLista	varchar(20)='0',
@PrecioVta	varchar(20)='0',
@Productocantidad	varchar(20)='0',
@ProductoCodigo	varchar(20)='',
@ProductoDescripcion	varchar(100)='',
@TipodeImpuesto	varchar(2)='',
@TipodeISC	varchar(2)='',
@TipodePrecio	varchar(2)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_DocumentosElectronicosDetItem (DocumentosElectronicos_id,	DocumentosElectronicosCorrel,	DocumentosElectronicosCorrelItem,	EmpresaCodigo,	
	ItemDescuento,	ItemExonerado,	ItemGravado,	ItemIGV,	
	ItemInafecto,	ItemISC,	ItemOtros,	ItemVenta,	
	PrecioLista,	PrecioVta,	Productocantidad,	ProductoCodigo,	
	ProductoDescripcion,	TipodeImpuesto,	TipodeISC,	TipodePrecio

	 )
	 VALUES('+@DocumentosElectronicos_id+',	'+@DocumentosElectronicosCorrel+',	'+@DocumentosElectronicosCorrelItem+',	'''+@EmpresaCodigo+''',	
	'+@ItemDescuento+',	'+@ItemExonerado+',	'+@ItemGravado+',	'+@ItemIGV+',	
	'+@ItemInafecto+',	'+@ItemISC+',	'+@ItemOtros+',	'+@ItemVenta+',	
	'+@PrecioLista+',	'+@PrecioVta+',	'+@Productocantidad+',	'''+@ProductoCodigo+''',	
	'''+@ProductoDescripcion+''',	'''+@TipodeImpuesto+''',	'''+@TipodeISC+''',	'''+@TipodePrecio+'''	
)  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_DocumentosElectronicosDetItem SET 
	ItemDescuento='+@ItemDescuento+',
	ItemExonerado='+@ItemExonerado+',
	ItemGravado='+@ItemGravado+',
	ItemIGV='+@ItemIGV+',
	ItemInafecto='+@ItemInafecto+',
	ItemISC='+@ItemISC+',
	ItemOtros='+@ItemOtros+',
	ItemVenta='+@ItemVenta+',
	PrecioLista='+@PrecioLista+',
	PrecioVta='+@PrecioVta+',
	Productocantidad='+@Productocantidad+',
	ProductoCodigo='''+@ProductoCodigo+''',
	ProductoDescripcion='''+@ProductoDescripcion+''',
	TipodeImpuesto='''+@TipodeImpuesto+''',
	TipodeISC='''+@TipodeISC+''',
	TipodePrecio='''+@TipodePrecio+'''

	 WHERE DocumentosElectronicos_id='+@DocumentosElectronicos_id+' AND 
	DocumentosElectronicosCorrel='+@DocumentosElectronicosCorrel+' AND 
	DocumentosElectronicosCorrelItem='+@DocumentosElectronicosCorrelItem+' AND 
	EmpresaCodigo='''+@EmpresaCodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  DocumentosElectronicos_id,	DocumentosElectronicosCorrel,	DocumentosElectronicosCorrelItem,	EmpresaCodigo,	
	ItemDescuento,	ItemExonerado,	ItemGravado,	ItemIGV,	
	ItemInafecto,	ItemISC,	ItemOtros,	ItemVenta,	
	PrecioLista,	PrecioVta,	Productocantidad,	ProductoCodigo,	
	ProductoDescripcion,	TipodeImpuesto,	TipodeISC,	TipodePrecio

	
	 FROM '+@base+'.dbo.FE_DocumentosElectronicosDetItem'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

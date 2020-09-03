/*

 Insertando un registro En vt_puntovtadocumento

*/
CREATE PROC vt_puntovtadocumento_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@documentocodigo	varchar(2)='',
@empresacodigo	varchar(2)='',
@EstadoAnulado	varchar(1)='0',
@NumeracionAutomatica	varchar(1)='0',
@puntovtacodigo	varchar(2)='',
@puntovtadoccorr	varchar(10)='',
@puntovtadocserie	varchar(4)='',
@puntovtaguia1	varchar(2)='',
@puntovtaguia2	varchar(2)='',
@usuariocodigo	varchar(8)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.vt_puntovtadocumento (documentocodigo,	empresacodigo,	EstadoAnulado,	NumeracionAutomatica,	
	puntovtacodigo,	puntovtadoccorr,	puntovtadocserie,	puntovtaguia1,	
	puntovtaguia2,	usuariocodigo
 )
	 VALUES('''+@documentocodigo+''',	'''+@empresacodigo+''',	'+@EstadoAnulado+',	'+@NumeracionAutomatica+',	
	'''+@puntovtacodigo+''',	'''+@puntovtadoccorr+''',	'''+@puntovtadocserie+''',	'''+@puntovtaguia1+''',	
	'''+@puntovtaguia2+''',	'''+@usuariocodigo+''')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.vt_puntovtadocumento SET 
	EstadoAnulado='+@EstadoAnulado+',
	NumeracionAutomatica='+@NumeracionAutomatica+',
	puntovtadoccorr='''+@puntovtadoccorr+''',
	puntovtadocserie='''+@puntovtadocserie+''',
	puntovtaguia1='''+@puntovtaguia1+''',
	puntovtaguia2='''+@puntovtaguia2+''',
	usuariocodigo='''+@usuariocodigo+'''

	 WHERE documentocodigo='''+@documentocodigo+''' AND 
	empresacodigo='''+@empresacodigo+''' AND 
	puntovtacodigo='''+@puntovtacodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  documentocodigo,	empresacodigo,	EstadoAnulado,	NumeracionAutomatica,	
	puntovtacodigo,	puntovtadoccorr,	puntovtadocserie,	puntovtaguia1,	
	puntovtaguia2,	usuariocodigo

	 FROM '+@base+'.dbo.vt_puntovtadocumento'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

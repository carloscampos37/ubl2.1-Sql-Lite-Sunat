/*

 Insertando un registro En FE_ComunicacionBajaCab

*/
CREATE PROC FE_ComunicacionBajaCab_PRO
(
@base varchar(50) ,
@tipo int ,
@Condicion varchar(250)='' ,
@ArchivoXmlAceptado	varchar(100)='',
@ComunicacionBaja_id	varchar(20)='0',
@EmpresaCodigo	varchar(3)='',
@Establecimiento_id	varchar(10)='',
@EstadoEnvioSunat_id	varchar(20)='0',
@FechaAct	varchar(25)='01/01/1900',
@FechadeBaja	varchar(25)='01/01/1900',
@FechaEnvio	varchar(25)='01/01/1900',
@IdentificadorEnvio	varchar(30)='',
@MensajeRecepcion	varchar(60)='',
@NroDocumentos	varchar(20)='0',
@NumerodeAceptacion	varchar(20)='',
@Usuariocodigo	varchar(10)=''

) 
 AS 

DECLARE @SQL varchar(8000) 

 IF @tipo=1  
BEGIN

	SET @SQL=' INSERT INTO '+@base+'.dbo.FE_ComunicacionBajaCab (ArchivoXmlAceptado,	ComunicacionBaja_id,	EmpresaCodigo,	Establecimiento_id,	
	EstadoEnvioSunat_id,	FechaAct,	FechadeBaja,	FechaEnvio,	
	IdentificadorEnvio,	MensajeRecepcion,	NroDocumentos,	NumerodeAceptacion,	
	Usuariocodigo
 )
	 VALUES('''+@ArchivoXmlAceptado+''',	'+@ComunicacionBaja_id+',	'''+@EmpresaCodigo+''',	'''+@Establecimiento_id+''',	
	'+@EstadoEnvioSunat_id+',	'''+@FechaAct+''',	'''+@FechadeBaja+''',	'''+@FechaEnvio+''',	
	'''+@IdentificadorEnvio+''',	'''+@MensajeRecepcion+''',	'+@NroDocumentos+',	'''+@NumerodeAceptacion+''',	
	'''+@Usuariocodigo+''')  '
END

 IF @tipo=2  
BEGIN

	SET @SQL=' UPDATE '+@base+'.dbo.FE_ComunicacionBajaCab SET 
	ArchivoXmlAceptado='''+@ArchivoXmlAceptado+''',
	Establecimiento_id='''+@Establecimiento_id+''',
	EstadoEnvioSunat_id='+@EstadoEnvioSunat_id+',
	FechaAct='''+@FechaAct+''',
	FechadeBaja='''+@FechadeBaja+''',
	FechaEnvio='''+@FechaEnvio+''',
	IdentificadorEnvio='''+@IdentificadorEnvio+''',
	MensajeRecepcion='''+@MensajeRecepcion+''',
	NroDocumentos='+@NroDocumentos+',
	NumerodeAceptacion='''+@NumerodeAceptacion+''',
	Usuariocodigo='''+@Usuariocodigo+'''

	 WHERE ComunicacionBaja_id='+@ComunicacionBaja_id+' AND 
	EmpresaCodigo='''+@EmpresaCodigo+'''

	'
END

 IF @tipo=3  
BEGIN


	SET @SQL=' SELECT  ArchivoXmlAceptado,	ComunicacionBaja_id,	EmpresaCodigo,	Establecimiento_id,	
	EstadoEnvioSunat_id,	FechaAct,	FechadeBaja,	FechaEnvio,	
	IdentificadorEnvio,	MensajeRecepcion,	NroDocumentos,	NumerodeAceptacion,	
	Usuariocodigo

	 FROM '+@base+'.dbo.FE_ComunicacionBajaCab'
	 IF @condicion<>'' SET @sql=@sql+ ' WHERE '+@condicion + '
	  '
END


execute(@SQl)

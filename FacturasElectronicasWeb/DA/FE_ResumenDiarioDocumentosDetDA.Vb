Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class FE_ResumenDiarioDocumentosDetDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsFE_ResumenDiarioDocumentosDetBE As FE_ResumenDiarioDocumentosDetBE) As Boolean
Dim ColParameters As SqlParameterCollection
Dim lpParameter As SqlParameter
Try
	ColParameters = New SqlCommand().Parameters

	lpParameter = New SqlParameter("@Base", SqlDbType.VarChar, 50)
	lpParameter.Value = vBaseData
	 ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Tipo", SqlDbType.Int)
	lpParameter.Value = vTipo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ArchivoXmlAceptado", SqlDbType.VarChar,100)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetBE.ArchivoXmlAceptado
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaCodigo", SqlDbType.VarChar,3)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetBE.EmpresaCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EstadoAnulado", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_ResumenDiarioDocumentosDetBE.EstadoAnulado=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EstadoEnvioSunat_id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetBE.EstadoEnvioSunat_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@GrupodeEnvioSunat", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetBE.GrupodeEnvioSunat
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@MensajeRecepcion", SqlDbType.VarChar,60)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetBE.MensajeRecepcion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@MonedaCodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetBE.MonedaCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NumerodeAceptacion", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetBE.NumerodeAceptacion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NumerodeDocumentos", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetBE.NumerodeDocumentos
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NumeroDocumento", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetBE.NumeroDocumento
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NumeroDocumentoFinal", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetBE.NumeroDocumentoFinal
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Resumendiario_id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetBE.Resumendiario_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ResumendiarioCorrel", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetBE.ResumendiarioCorrel
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@SerieDocumento", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetBE.SerieDocumento
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TipoDocumento", SqlDbType.VarChar,2)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetBE.TipoDocumento
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteDsctoGlobal", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetBE.TotalImporteDsctoGlobal
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteExonerado", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetBE.TotalImporteExonerado
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteGravado", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetBE.TotalImporteGravado
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteIGV", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetBE.TotalImporteIGV
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteInafecto", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetBE.TotalImporteInafecto
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteVenta", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetBE.TotalImporteVenta
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("FE_ResumenDiarioDocumentosDet_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	MsgBox(objConexionDC.cError)

 End If 
Return True

Catch ex As Exception
	Throw ex
End Try
End Function
Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer, ByVal vCadConexProc As String,Optional ByVal vCondicion As String = "") As DataTable
Dim ColParameters As SqlParameterCollection
Dim lpParameter As SqlParameter
Dim dt As New DataTable
Try
ColParameters = New SqlCommand().Parameters

lpParameter = New SqlParameter("@Base", SqlDbType.VarChar, 50)
lpParameter.Value = vBaseData
 ColParameters.Add(lpParameter)

lpParameter = New SqlParameter("@Tipo", SqlDbType.Int)
lpParameter.Value = vTipo
ColParameters.Add(lpParameter)

lpParameter = New SqlParameter("@Condicion", SqlDbType.VarChar, 250)
lpParameter.Value = vCondicion
 ColParameters.Add(lpParameter)

dt=objConexionDC.ConsultarProc("FE_ResumenDiarioDocumentosDet_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class FE_DocumentosBajasDetDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsFE_DocumentosBajasDetBE As FE_DocumentosBajasDetBE) As Boolean
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

	lpParameter = New SqlParameter("@ClienteCodigo", SqlDbType.VarChar,15)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.ClienteCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ClienteRazonSocial", SqlDbType.VarChar,60)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.ClienteRazonSocial
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@DescripcionMotivoNota", SqlDbType.VarChar,100)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.DescripcionMotivoNota
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@DocumentosBajas_Id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.DocumentosBajas_Id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@DocumentosBajasCorrel", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.DocumentosBajasCorrel
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaCodigo", SqlDbType.VarChar,3)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.EmpresaCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EnvioSedePrincipal", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_DocumentosBajasDetBE.EnvioSedePrincipal=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EstadoAnulado", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_DocumentosBajasDetBE.EstadoAnulado=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EstadoEnvioSunat_id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.EstadoEnvioSunat_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Identidadcodigo", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.Identidadcodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@MonedaCodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.MonedaCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NumerodeAceptacion", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.NumerodeAceptacion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NumeroDocumento", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.NumeroDocumento
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NumeroDocumentoFinal", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.NumeroDocumentoFinal
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NumeroDocumentoModifica", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.NumeroDocumentoModifica
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@PorcentajeIsc", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.PorcentajeIsc
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@SerieDocumento", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.SerieDocumento
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@SerieDocumentoModifica", SqlDbType.VarChar,4)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.SerieDocumentoModifica
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TipoDocumento", SqlDbType.VarChar,2)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.TipoDocumento
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TipoDocumentoModifica", SqlDbType.VarChar,2)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.TipoDocumentoModifica
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TipoMotivoNota", SqlDbType.VarChar,2)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.TipoMotivoNota
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteDsctoGlobal", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.TotalImporteDsctoGlobal
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteDsctoItem", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.TotalImporteDsctoItem
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteExonerado", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.TotalImporteExonerado
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteGratuitas", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.TotalImporteGratuitas
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteGravado", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.TotalImporteGravado
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteIGV", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.TotalImporteIGV
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteInafecto", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.TotalImporteInafecto
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteISC", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.TotalImporteISC
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteOtros", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.TotalImporteOtros
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteVenta", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosBajasDetBE.TotalImporteVenta
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("FE_DocumentosBajasDet_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("FE_DocumentosBajasDet_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

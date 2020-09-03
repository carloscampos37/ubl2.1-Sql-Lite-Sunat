Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class FE_ComprobImpresosDetDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsFE_ComprobImpresosDetBE As FE_ComprobImpresosDetBE) As Boolean
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

	lpParameter = New SqlParameter("@ComprobImpreso_id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComprobImpresosDetBE.ComprobImpreso_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ComprobImpresoCorrel", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComprobImpresosDetBE.ComprobImpresoCorrel
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaCodigo", SqlDbType.VarChar,3)
	lpParameter.Value = objClsFE_ComprobImpresosDetBE.EmpresaCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EstadoEnvioSunat_id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComprobImpresosDetBE.EstadoEnvioSunat_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@MonedaCodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsFE_ComprobImpresosDetBE.MonedaCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NumerodeAceptacion", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ComprobImpresosDetBE.NumerodeAceptacion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NumerodeDocumentos", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComprobImpresosDetBE.NumerodeDocumentos
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NumeroDocumento", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComprobImpresosDetBE.NumeroDocumento
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NumeroDocumentoFinal", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComprobImpresosDetBE.NumeroDocumentoFinal
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@SerieDocumento", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ComprobImpresosDetBE.SerieDocumento
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TipoDocumento", SqlDbType.VarChar,2)
	lpParameter.Value = objClsFE_ComprobImpresosDetBE.TipoDocumento
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteDsctoGlobal", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ComprobImpresosDetBE.TotalImporteDsctoGlobal
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteExonerado", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ComprobImpresosDetBE.TotalImporteExonerado
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteGravado", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ComprobImpresosDetBE.TotalImporteGravado
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteIGV", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ComprobImpresosDetBE.TotalImporteIGV
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteInafecto", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ComprobImpresosDetBE.TotalImporteInafecto
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteVenta", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ComprobImpresosDetBE.TotalImporteVenta
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("FE_ComprobImpresosDet_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("FE_ComprobImpresosDet_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

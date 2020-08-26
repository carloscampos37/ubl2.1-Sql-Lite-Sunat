Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class FE_ComprobImpresosDetItemDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsFE_ComprobImpresosDetItemBE As FE_ComprobImpresosDetItemBE) As Boolean
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
	lpParameter.Value = objClsFE_ComprobImpresosDetItemBE.ClienteCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ClienteRazonSocial", SqlDbType.VarChar,60)
	lpParameter.Value = objClsFE_ComprobImpresosDetItemBE.ClienteRazonSocial
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ComprobImpreso_Id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComprobImpresosDetItemBE.ComprobImpreso_Id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ComprobImpresoCorrel", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComprobImpresosDetItemBE.ComprobImpresoCorrel
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ComprobImpresoCorrelItem", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComprobImpresosDetItemBE.ComprobImpresoCorrelItem
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaCodigo", SqlDbType.VarChar,3)
	lpParameter.Value = objClsFE_ComprobImpresosDetItemBE.EmpresaCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EstadoAnulado", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_ComprobImpresosDetItemBE.EstadoAnulado=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EstadoEnvioSunat_id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComprobImpresosDetItemBE.EstadoEnvioSunat_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@IdentidadCodigo", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComprobImpresosDetItemBE.IdentidadCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@MonedaCodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsFE_ComprobImpresosDetItemBE.MonedaCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NumeroDocumento", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComprobImpresosDetItemBE.NumeroDocumento
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NumeroDocumentoFinal", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComprobImpresosDetItemBE.NumeroDocumentoFinal
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NumeroDocumentoModifica", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ComprobImpresosDetItemBE.NumeroDocumentoModifica
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@SerieDocumento", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ComprobImpresosDetItemBE.SerieDocumento
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@SerieDocumentoModifica", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ComprobImpresosDetItemBE.SerieDocumentoModifica
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TipoDocumento", SqlDbType.VarChar,2)
	lpParameter.Value = objClsFE_ComprobImpresosDetItemBE.TipoDocumento
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TipoDocumentoModifica", SqlDbType.VarChar,2)
	lpParameter.Value = objClsFE_ComprobImpresosDetItemBE.TipoDocumentoModifica
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteExonerado", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ComprobImpresosDetItemBE.TotalImporteExonerado
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteGravado", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ComprobImpresosDetItemBE.TotalImporteGravado
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@totalImporteIGV", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ComprobImpresosDetItemBE.totalImporteIGV
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteInafecto", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ComprobImpresosDetItemBE.TotalImporteInafecto
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteISC", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ComprobImpresosDetItemBE.TotalImporteISC
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteOtros", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ComprobImpresosDetItemBE.TotalImporteOtros
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteVenta", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ComprobImpresosDetItemBE.TotalImporteVenta
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("FE_ComprobImpresosDetItem_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("FE_ComprobImpresosDetItem_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class FE_ResumenDiarioDocumentosDetItemDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsFE_ResumenDiarioDocumentosDetItemBE As FE_ResumenDiarioDocumentosDetItemBE) As Boolean
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
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.ClienteCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ClienteRazonSocial", SqlDbType.VarChar,60)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.ClienteRazonSocial
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaCodigo", SqlDbType.VarChar,3)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.EmpresaCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EstadoAnulado", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_ResumenDiarioDocumentosDetItemBE.EstadoAnulado=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EstadoEnvioSunat_id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.EstadoEnvioSunat_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@IdentidadCodigo", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.IdentidadCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@MonedaCodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.MonedaCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NumeroDocumento", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.NumeroDocumento
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NumeroDocumentoModifica", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.NumeroDocumentoModifica
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@PedidoNumero", SqlDbType.VarChar,15)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.PedidoNumero
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ResumenDiario_Id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.ResumenDiario_Id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ResumenDiarioCorrel", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.ResumenDiarioCorrel
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ResumenDiarioCorrelItem", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.ResumenDiarioCorrelItem
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@SerieDocumento", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.SerieDocumento
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@SerieDocumentoModifica", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.SerieDocumentoModifica
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TipoDocumento", SqlDbType.VarChar,2)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.TipoDocumento
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TipoDocumentoModifica", SqlDbType.VarChar,2)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.TipoDocumentoModifica
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteDsctoGlobal", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.TotalImporteDsctoGlobal
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteExonerado", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.TotalImporteExonerado
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteGratuitas", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.TotalImporteGratuitas
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteGravado", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.TotalImporteGravado
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@totalImporteIGV", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.totalImporteIGV
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteInafecto", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.TotalImporteInafecto
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteISC", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.TotalImporteISC
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteOtros", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.TotalImporteOtros
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteVenta", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosDetItemBE.TotalImporteVenta
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("FE_ResumenDiarioDocumentosDetItem_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("FE_ResumenDiarioDocumentosDetItem_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

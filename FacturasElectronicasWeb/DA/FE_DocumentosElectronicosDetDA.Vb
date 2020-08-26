Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class FE_DocumentosElectronicosDetDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsFE_DocumentosElectronicosDetBE As FE_DocumentosElectronicosDetBE) As Boolean
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

	lpParameter = New SqlParameter("@AfectacionIgv", SqlDbType.VarChar,1)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.AfectacionIgv
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ClienteCodigo", SqlDbType.VarChar,15)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.ClienteCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ClienteRazonSocial", SqlDbType.VarChar,60)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.ClienteRazonSocial
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@DescripcionMotivoNota", SqlDbType.VarChar,100)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.DescripcionMotivoNota
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@DocumentosElectronicos_id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.DocumentosElectronicos_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@DocumentosElectronicosCorrel", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.DocumentosElectronicosCorrel
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaCodigo", SqlDbType.VarChar,3)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.EmpresaCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EnvioSedePrincipal", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_DocumentosElectronicosDetBE.EnvioSedePrincipal=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EstadoAnulado", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_DocumentosElectronicosDetBE.EstadoAnulado=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EstadoEnvioSunat_id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.EstadoEnvioSunat_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@FechaRegistro", SqlDbType.DateTime)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.FechaRegistro
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Identidadcodigo", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.Identidadcodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@MonedaCodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.MonedaCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NumerodeAceptacion", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.NumerodeAceptacion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NumeroDocumento", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.NumeroDocumento
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NumeroDocumentoModifica", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.NumeroDocumentoModifica
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@PedidoNumero", SqlDbType.VarChar,15)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.PedidoNumero
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@PorcentajeIgv", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.PorcentajeIgv
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@PorcentajeIsc", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.PorcentajeIsc
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@SerieDocumento", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.SerieDocumento
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@SerieDocumentoModifica", SqlDbType.VarChar,4)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.SerieDocumentoModifica
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TipoDocumento", SqlDbType.VarChar,2)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.TipoDocumento
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TipoDocumentoModifica", SqlDbType.VarChar,2)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.TipoDocumentoModifica
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TipoMotivoNota", SqlDbType.VarChar,2)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.TipoMotivoNota
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteDsctoGlobal", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.TotalImporteDsctoGlobal
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteDsctoItem", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.TotalImporteDsctoItem
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteExonerado", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.TotalImporteExonerado
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteGratuitas", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.TotalImporteGratuitas
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteGravado", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.TotalImporteGravado
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteIGV", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.TotalImporteIGV
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteInafecto", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.TotalImporteInafecto
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteISC", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.TotalImporteISC
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteOtros", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.TotalImporteOtros
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TotalImporteVenta", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetBE.TotalImporteVenta
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("FE_DocumentosElectronicosDet_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("FE_DocumentosElectronicosDet_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

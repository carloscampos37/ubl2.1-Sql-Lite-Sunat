Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class vt_sistemaDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsvt_sistemaBE As vt_sistemaBE) As Boolean
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

	lpParameter = New SqlParameter("@AdministratipoPago", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_sistemaBE.AdministratipoPago=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Administravuelto", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_sistemaBE.Administravuelto=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@AdmiteNegativos", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_sistemaBE.AdmiteNegativos=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@CarpetaFacturasElectronicas", SqlDbType.VarChar,50)
	lpParameter.Value = objClsvt_sistemaBE.CarpetaFacturasElectronicas
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@CarpetaLibrosElectronicos", SqlDbType.VarChar,50)
	lpParameter.Value = objClsvt_sistemaBE.CarpetaLibrosElectronicos
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@CodigoPetroleo", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_sistemaBE.CodigoPetroleo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@codigosduplicados", SqlDbType.VarChar,10)
	lpParameter.Value = objClsvt_sistemaBE.codigosduplicados
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ConsolidaPtosVtasFE", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_sistemaBE.ConsolidaPtosVtasFE=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ContabilizaFacturacion", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_sistemaBE.ContabilizaFacturacion=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@DefaultClienteEventual", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_sistemaBE.DefaultClienteEventual=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@empresaasientosautomaticos", SqlDbType.VarChar,10)
	lpParameter.Value = objClsvt_sistemaBE.empresaasientosautomaticos
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@FacturasElectronicas", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_sistemaBE.FacturasElectronicas=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@familiaproyectos", SqlDbType.VarChar,10)
	lpParameter.Value = objClsvt_sistemaBE.familiaproyectos
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@FechadeTrabajo", SqlDbType.DateTime)
	lpParameter.Value = objClsvt_sistemaBE.FechadeTrabajo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@generapedidotemporal", SqlDbType.VarChar,10)
	lpParameter.Value = objClsvt_sistemaBE.generapedidotemporal
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsvt_sistemaBE.id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@impresionvisual", SqlDbType.VarChar,10)
	lpParameter.Value = objClsvt_sistemaBE.impresionvisual
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Pagosencaja", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_sistemaBE.Pagosencaja=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@PedidodelDia", SqlDbType.VarChar,10)
	lpParameter.Value = objClsvt_sistemaBE.PedidodelDia
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidotipovena", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_sistemaBE.pedidotipovena
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@PedidotresPasos", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_sistemaBE.PedidotresPasos=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Preciototalxfraccion", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_sistemaBE.Preciototalxfraccion=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@PuntoVtxCliente", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_sistemaBE.PuntoVtxCliente=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@SaldosxLoteSerie", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_sistemaBE.SaldosxLoteSerie=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@temporalpedidos", SqlDbType.VarChar,10)
	lpParameter.Value = objClsvt_sistemaBE.temporalpedidos
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@tipoanaliticocodigo", SqlDbType.VarChar,3)
	lpParameter.Value = objClsvt_sistemaBE.tipoanaliticocodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@UtilidadMinima", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_sistemaBE.UtilidadMinima=true,1,0) 
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("vt_sistema_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("vt_sistema_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

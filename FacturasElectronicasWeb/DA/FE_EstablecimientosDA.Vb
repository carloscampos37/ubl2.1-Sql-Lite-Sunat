Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class FE_EstablecimientosDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsFE_EstablecimientosBE As FE_EstablecimientosBE) As Boolean
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

	lpParameter = New SqlParameter("@AnexoSunat", SqlDbType.VarChar,4)
	lpParameter.Value = objClsFE_EstablecimientosBE.AnexoSunat
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaCodigo", SqlDbType.VarChar,3)
	lpParameter.Value = objClsFE_EstablecimientosBE.EmpresaCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Establecimiento_id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_EstablecimientosBE.Establecimiento_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EstablecimientoDescripcion", SqlDbType.VarChar,50)
	lpParameter.Value = objClsFE_EstablecimientosBE.EstablecimientoDescripcion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@establecimientoDireccion", SqlDbType.VarChar,100)
	lpParameter.Value = objClsFE_EstablecimientosBE.establecimientoDireccion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@HabilitadoFactDiaria", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_EstablecimientosBE.HabilitadoFactDiaria=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@HabilitadoFactPreimpresa", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_EstablecimientosBE.HabilitadoFactPreimpresa=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@HostName", SqlDbType.VarChar,50)
	lpParameter.Value = objClsFE_EstablecimientosBE.HostName
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Microred_id", SqlDbType.VarChar,3)
	lpParameter.Value = objClsFE_EstablecimientosBE.Microred_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@UsuarioCodigo", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_EstablecimientosBE.UsuarioCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Vendedor_id", SqlDbType.VarChar,3)
	lpParameter.Value = objClsFE_EstablecimientosBE.Vendedor_id
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("FE_Establecimientos_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("FE_Establecimientos_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

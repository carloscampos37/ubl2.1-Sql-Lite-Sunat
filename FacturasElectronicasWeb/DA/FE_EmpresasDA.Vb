Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class FE_EmpresasDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsFE_EmpresasBE As FE_EmpresasBE) As Boolean
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

	lpParameter = New SqlParameter("@EmpresaCodigo", SqlDbType.VarChar,3)
	lpParameter.Value = objClsFE_EmpresasBE.EmpresaCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaDireccion", SqlDbType.VarChar,100)
	lpParameter.Value = objClsFE_EmpresasBE.EmpresaDireccion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaDistrito", SqlDbType.VarChar,50)
	lpParameter.Value = objClsFE_EmpresasBE.EmpresaDistrito
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaProvincia", SqlDbType.VarChar,50)
	lpParameter.Value = objClsFE_EmpresasBE.EmpresaProvincia
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaRazonComercial", SqlDbType.VarChar,50)
	lpParameter.Value = objClsFE_EmpresasBE.EmpresaRazonComercial
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaRazonSocial", SqlDbType.VarChar,100)
	lpParameter.Value = objClsFE_EmpresasBE.EmpresaRazonSocial
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaRegion", SqlDbType.VarChar,50)
	lpParameter.Value = objClsFE_EmpresasBE.EmpresaRegion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaRuc", SqlDbType.VarChar,11)
	lpParameter.Value = objClsFE_EmpresasBE.EmpresaRuc
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaUrbanizacion", SqlDbType.VarChar,50)
	lpParameter.Value = objClsFE_EmpresasBE.EmpresaUrbanizacion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EstadoAnulado", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_EmpresasBE.EstadoAnulado=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Ubigeo_id", SqlDbType.VarChar,8)
	lpParameter.Value = objClsFE_EmpresasBE.Ubigeo_id
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("FE_Empresas_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("FE_Empresas_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

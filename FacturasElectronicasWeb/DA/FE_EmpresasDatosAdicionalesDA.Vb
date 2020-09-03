Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class FE_EmpresasDatosAdicionalesDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsFE_EmpresasDatosAdicionalesBE As FE_EmpresasDatosAdicionalesBE) As Boolean
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

	lpParameter = New SqlParameter("@CaracteresEspeciales", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_EmpresasDatosAdicionalesBE.CaracteresEspeciales=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@CarpetaBajasXml", SqlDbType.VarChar,100)
	lpParameter.Value = objClsFE_EmpresasDatosAdicionalesBE.CarpetaBajasXml
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@CarpetaCertificadoDigital", SqlDbType.VarChar,100)
	lpParameter.Value = objClsFE_EmpresasDatosAdicionalesBE.CarpetaCertificadoDigital
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@CarpetaEnviosXml", SqlDbType.VarChar,100)
	lpParameter.Value = objClsFE_EmpresasDatosAdicionalesBE.CarpetaEnviosXml
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@CarpetaRecepcionBajas", SqlDbType.VarChar,100)
	lpParameter.Value = objClsFE_EmpresasDatosAdicionalesBE.CarpetaRecepcionBajas
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@carpetaRecepcionXml", SqlDbType.VarChar,100)
	lpParameter.Value = objClsFE_EmpresasDatosAdicionalesBE.carpetaRecepcionXml
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaCodigo", SqlDbType.VarChar,3)
	lpParameter.Value = objClsFE_EmpresasDatosAdicionalesBE.EmpresaCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaCorreoelectronico", SqlDbType.VarChar,100)
	lpParameter.Value = objClsFE_EmpresasDatosAdicionalesBE.EmpresaCorreoelectronico
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ListaUrlSunat", SqlDbType.VarChar,30)
	lpParameter.Value = objClsFE_EmpresasDatosAdicionalesBE.ListaUrlSunat
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ResolucionSunat", SqlDbType.VarChar,50)
	lpParameter.Value = objClsFE_EmpresasDatosAdicionalesBE.ResolucionSunat
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("FE_EmpresasDatosAdicionales_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("FE_EmpresasDatosAdicionales_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

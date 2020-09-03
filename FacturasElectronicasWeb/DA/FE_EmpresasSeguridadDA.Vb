Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class FE_EmpresasSeguridadDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsFE_EmpresasSeguridadBE As FE_EmpresasSeguridadBE) As Boolean
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

	lpParameter = New SqlParameter("@CorreoElectronicoFactelect", SqlDbType.VarChar,100)
	lpParameter.Value = objClsFE_EmpresasSeguridadBE.CorreoElectronicoFactelect
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaClaveSol", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_EmpresasSeguridadBE.EmpresaClaveSol
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaCodigo", SqlDbType.VarChar,3)
	lpParameter.Value = objClsFE_EmpresasSeguridadBE.EmpresaCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaUsuarioSol", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_EmpresasSeguridadBE.EmpresaUsuarioSol
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EstadoAnulado", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_EmpresasSeguridadBE.EstadoAnulado=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@FechaVigenciaCertificado", SqlDbType.DateTime)
	lpParameter.Value = objClsFE_EmpresasSeguridadBE.FechaVigenciaCertificado
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NombreCertificadoDigital", SqlDbType.VarChar,30)
	lpParameter.Value = objClsFE_EmpresasSeguridadBE.NombreCertificadoDigital
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@PasswCertificadoDigital", SqlDbType.VarChar,30)
	lpParameter.Value = objClsFE_EmpresasSeguridadBE.PasswCertificadoDigital
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@PasswCorreoElectronico", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_EmpresasSeguridadBE.PasswCorreoElectronico
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("FE_EmpresasSeguridad_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("FE_EmpresasSeguridad_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

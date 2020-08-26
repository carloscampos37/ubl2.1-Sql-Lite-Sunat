Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class FE_ControldeEnviosDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsFE_ControldeEnviosBE As FE_ControldeEnviosBE) As Boolean
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

	lpParameter = New SqlParameter("@Comunicacionbajas", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_ControldeEnviosBE.Comunicacionbajas=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@DocumentosElectronicos", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_ControldeEnviosBE.DocumentosElectronicos=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaCodigo", SqlDbType.VarChar,3)
	lpParameter.Value = objClsFE_ControldeEnviosBE.EmpresaCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EstadoCierreSunat", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_ControldeEnviosBE.EstadoCierreSunat=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@FechaEmision", SqlDbType.DateTime)
	lpParameter.Value = objClsFE_ControldeEnviosBE.FechaEmision
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@PuntovtaCodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsFE_ControldeEnviosBE.PuntovtaCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ResumenDiario", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_ControldeEnviosBE.ResumenDiario=true,1,0) 
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("FE_ControldeEnvios_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("FE_ControldeEnvios_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

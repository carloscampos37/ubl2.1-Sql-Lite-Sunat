Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class FE_TipoEnvioSunatDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsFE_TipoEnvioSunatBE As FE_TipoEnvioSunatBE) As Boolean
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

	lpParameter = New SqlParameter("@TipoEnvio_Id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_TipoEnvioSunatBE.TipoEnvio_Id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TipoEnvioDescripcion", SqlDbType.VarChar,50)
	lpParameter.Value = objClsFE_TipoEnvioSunatBE.TipoEnvioDescripcion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@WebService", SqlDbType.VarChar,50)
	lpParameter.Value = objClsFE_TipoEnvioSunatBE.WebService
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("FE_TipoEnvioSunat_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("FE_TipoEnvioSunat_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

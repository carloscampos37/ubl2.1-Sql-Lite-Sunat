Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class FE_UnidadMedidaDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsFE_UnidadMedidaBE As FE_UnidadMedidaBE) As Boolean
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

	lpParameter = New SqlParameter("@EquivalenciaSunat", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_UnidadMedidaBE.EquivalenciaSunat
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EstadoAnulado", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_UnidadMedidaBE.EstadoAnulado=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@UnidadDescripcion", SqlDbType.VarChar,50)
	lpParameter.Value = objClsFE_UnidadMedidaBE.UnidadDescripcion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@UnidadMedida_id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_UnidadMedidaBE.UnidadMedida_id
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("FE_UnidadMedida_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("FE_UnidadMedida_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

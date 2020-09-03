Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class FE_AfectacionIgvDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsFE_AfectacionIgvBE As FE_AfectacionIgvBE) As Boolean
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

	lpParameter = New SqlParameter("@Codigo", SqlDbType.VarChar,4)
	lpParameter.Value = objClsFE_AfectacionIgvBE.Codigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Id", SqlDbType.VarChar,1)
	lpParameter.Value = objClsFE_AfectacionIgvBE.Id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Menotecnico", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_AfectacionIgvBE.Menotecnico
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Nombre", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_AfectacionIgvBE.Nombre
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("FE_AfectacionIgv_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("FE_AfectacionIgv_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

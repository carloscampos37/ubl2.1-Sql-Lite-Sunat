Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class FE_SistemaDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsFE_SistemaBE As FE_SistemaBE) As Boolean
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

	lpParameter = New SqlParameter("@CorrelativoComprobImpreso", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_SistemaBE.CorrelativoComprobImpreso
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@CorrelativoComunicacionBaja", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_SistemaBE.CorrelativoComunicacionBaja
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Corrrelativodocumentoelectronico", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_SistemaBE.Corrrelativodocumentoelectronico
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@CorrrelativoResumenDiario", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_SistemaBE.CorrrelativoResumenDiario
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Empresacodigo", SqlDbType.VarChar,3)
	lpParameter.Value = objClsFE_SistemaBE.Empresacodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EsquemaInafecto", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_SistemaBE.EsquemaInafecto=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@FechaAct", SqlDbType.DateTime)
	lpParameter.Value = objClsFE_SistemaBE.FechaAct
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("FE_Sistema_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("FE_Sistema_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class vt_monedaDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsvt_monedaBE As vt_monedaBE) As Boolean
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

	lpParameter = New SqlParameter("@fechaact", SqlDbType.DateTime)
	lpParameter.Value = objClsvt_monedaBE.fechaact
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@monedacodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_monedaBE.monedacodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@monedadescripcion", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_monedaBE.monedadescripcion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@monedasimbolo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_monedaBE.monedasimbolo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@usuariocodigo", SqlDbType.VarChar,8)
	lpParameter.Value = objClsvt_monedaBE.usuariocodigo
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("vt_moneda_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("vt_moneda_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class vt_listaprecioDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsvt_listaprecioBE As vt_listaprecioBE) As Boolean
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
	lpParameter.Value = objClsvt_listaprecioBE.fechaact
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@productocodigo", SqlDbType.VarChar,8)
	lpParameter.Value = objClsvt_listaprecioBE.productocodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@productodescripcion", SqlDbType.VarChar,80)
	lpParameter.Value = objClsvt_listaprecioBE.productodescripcion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@productoprecvta", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_listaprecioBE.productoprecvta
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@productoprecvtaofi", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_listaprecioBE.productoprecvtaofi
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@productoprecvtareparto", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_listaprecioBE.productoprecvtareparto
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@usuariocodigo", SqlDbType.VarChar,8)
	lpParameter.Value = objClsvt_listaprecioBE.usuariocodigo
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("vt_listaprecio_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("vt_listaprecio_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

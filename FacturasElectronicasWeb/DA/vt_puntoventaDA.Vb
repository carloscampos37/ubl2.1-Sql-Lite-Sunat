Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class vt_puntoventaDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsvt_puntoventaBE As vt_puntoventaBE) As Boolean
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

	lpParameter = New SqlParameter("@administraproyectos", SqlDbType.VarChar,10)
	lpParameter.Value = objClsvt_puntoventaBE.administraproyectos
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@codigocajavtas", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_puntoventaBE.codigocajavtas
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@codigocajavtasDol", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_puntoventaBE.codigocajavtasDol
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@codigocajavtassoles", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_puntoventaBE.codigocajavtassoles
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@direccioncomercial", SqlDbType.VarChar,60)
	lpParameter.Value = objClsvt_puntoventaBE.direccioncomercial
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@fechaact", SqlDbType.DateTime)
	lpParameter.Value = objClsvt_puntoventaBE.fechaact
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@puntovtaautomat", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_puntoventaBE.puntovtaautomat=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@puntovtacodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_puntoventaBE.puntovtacodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@puntovtadescripcion", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_puntoventaBE.puntovtadescripcion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@puntovtanotaabono", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_puntoventaBE.puntovtanotaabono=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@puntovtanotacargo", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_puntoventaBE.puntovtanotacargo=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@puntovtanroBoleta", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_puntoventaBE.puntovtanroBoleta=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@puntovtanrofact", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_puntoventaBE.puntovtanrofact=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@puntovtanroguia", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_puntoventaBE.puntovtanroguia=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@puntovtanroguiarem", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_puntoventaBE.puntovtanroguiarem=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@puntovtanropedido", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_puntoventaBE.puntovtanropedido=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@puntovtaNumDocumentos", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_puntoventaBE.puntovtaNumDocumentos=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@puntovtaticket", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_puntoventaBE.puntovtaticket=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@puntovtaventasAuto", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_puntoventaBE.puntovtaventasAuto=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@usuariocodigo", SqlDbType.VarChar,8)
	lpParameter.Value = objClsvt_puntoventaBE.usuariocodigo
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("vt_puntoventa_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("vt_puntoventa_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

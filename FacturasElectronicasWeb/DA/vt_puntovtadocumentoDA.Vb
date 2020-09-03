Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class vt_puntovtadocumentoDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsvt_puntovtadocumentoBE As vt_puntovtadocumentoBE) As Boolean
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

	lpParameter = New SqlParameter("@documentocodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_puntovtadocumentoBE.documentocodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@empresacodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_puntovtadocumentoBE.empresacodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EstadoAnulado", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_puntovtadocumentoBE.EstadoAnulado=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NumeracionAutomatica", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_puntovtadocumentoBE.NumeracionAutomatica=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@puntovtacodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_puntovtadocumentoBE.puntovtacodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@puntovtadoccorr", SqlDbType.VarChar,10)
	lpParameter.Value = objClsvt_puntovtadocumentoBE.puntovtadoccorr
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@puntovtadocserie", SqlDbType.VarChar,4)
	lpParameter.Value = objClsvt_puntovtadocumentoBE.puntovtadocserie
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@puntovtaguia1", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_puntovtadocumentoBE.puntovtaguia1
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@puntovtaguia2", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_puntovtadocumentoBE.puntovtaguia2
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@usuariocodigo", SqlDbType.VarChar,8)
	lpParameter.Value = objClsvt_puntovtadocumentoBE.usuariocodigo
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("vt_puntovtadocumento_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("vt_puntovtadocumento_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

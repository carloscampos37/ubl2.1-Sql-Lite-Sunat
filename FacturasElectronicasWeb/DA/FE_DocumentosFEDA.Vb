Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class FE_DocumentosFEDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsFE_DocumentosFEBE As FE_DocumentosFEBE) As Boolean
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
	lpParameter.Value = objClsFE_DocumentosFEBE.documentocodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@documentodescripcion", SqlDbType.VarChar,30)
	lpParameter.Value = objClsFE_DocumentosFEBE.documentodescripcion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EstadoAnulado", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_DocumentosFEBE.EstadoAnulado=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@fechaact", SqlDbType.DateTime)
	lpParameter.Value = objClsFE_DocumentosFEBE.fechaact
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TipoEnvio_id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_DocumentosFEBE.TipoEnvio_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@usuariocodigo", SqlDbType.VarChar,8)
	lpParameter.Value = objClsFE_DocumentosFEBE.usuariocodigo
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("FE_DocumentosFE_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("FE_DocumentosFE_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

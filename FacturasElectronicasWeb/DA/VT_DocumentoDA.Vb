Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class VT_DocumentoDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsVT_DocumentoBE As VT_DocumentoBE) As Boolean
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

	lpParameter = New SqlParameter("@CodigoSunat", SqlDbType.VarChar,2)
	lpParameter.Value = objClsVT_DocumentoBE.CodigoSunat
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@DocumentoCodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsVT_DocumentoBE.DocumentoCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@documentodescrcorta", SqlDbType.VarChar,15)
	lpParameter.Value = objClsVT_DocumentoBE.documentodescrcorta
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@documentodescripcion", SqlDbType.VarChar,30)
	lpParameter.Value = objClsVT_DocumentoBE.documentodescripcion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@documentoregventas", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsVT_DocumentoBE.documentoregventas=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@DocumentoResumenSunat", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsVT_DocumentoBE.DocumentoResumenSunat=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@documentotipo", SqlDbType.VarChar,1)
	lpParameter.Value = objClsVT_DocumentoBE.documentotipo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@documentovalidaruc", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsVT_DocumentoBE.documentovalidaruc=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@fechaact", SqlDbType.DateTime)
	lpParameter.Value = objClsVT_DocumentoBE.fechaact
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TipoEnvio_Id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsVT_DocumentoBE.TipoEnvio_Id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@usuariocodigo", SqlDbType.VarChar,8)
	lpParameter.Value = objClsVT_DocumentoBE.usuariocodigo
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("VT_Documento_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("VT_Documento_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

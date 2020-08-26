Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class vt_vendedorDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsvt_vendedorBE As vt_vendedorBE) As Boolean
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

	lpParameter = New SqlParameter("@estadoreg", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_vendedorBE.estadoreg=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@fechaact", SqlDbType.DateTime)
	lpParameter.Value = objClsvt_vendedorBE.fechaact
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@usuariocodigo", SqlDbType.VarChar,8)
	lpParameter.Value = objClsvt_vendedorBE.usuariocodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@vendedorcodigo", SqlDbType.VarChar,3)
	lpParameter.Value = objClsvt_vendedorBE.vendedorcodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@vendedorcomis1", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_vendedorBE.vendedorcomis1
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@vendedorcomis2", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_vendedorBE.vendedorcomis2
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@vendedorcomis3", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_vendedorBE.vendedorcomis3
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@vendedordireccion", SqlDbType.VarChar,30)
	lpParameter.Value = objClsvt_vendedorBE.vendedordireccion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@vendedorle", SqlDbType.VarChar,8)
	lpParameter.Value = objClsvt_vendedorBE.vendedorle
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@vendedornombres", SqlDbType.VarChar,50)
	lpParameter.Value = objClsvt_vendedorBE.vendedornombres
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@vendedorreferencia", SqlDbType.VarChar,30)
	lpParameter.Value = objClsvt_vendedorBE.vendedorreferencia
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@vendedorruc", SqlDbType.VarChar,15)
	lpParameter.Value = objClsvt_vendedorBE.vendedorruc
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@vendedortelefono", SqlDbType.VarChar,15)
	lpParameter.Value = objClsvt_vendedorBE.vendedortelefono
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("vt_vendedor_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("vt_vendedor_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

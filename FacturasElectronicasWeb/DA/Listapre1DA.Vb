Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class Listapre1DA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsListapre1BE As Listapre1BE) As Boolean
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

	lpParameter = New SqlParameter("@Descuento1", SqlDbType.VarChar,20)
	lpParameter.Value = objClsListapre1BE.Descuento1
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@empresacodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsListapre1BE.empresacodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@grupovtacodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsListapre1BE.grupovtacodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@monedacodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsListapre1BE.monedacodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@productocategoriacodigo", SqlDbType.VarChar,3)
	lpParameter.Value = objClsListapre1BE.productocategoriacodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@productocodigo", SqlDbType.VarChar,20)
	lpParameter.Value = objClsListapre1BE.productocodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@productodescrcorta", SqlDbType.VarChar,30)
	lpParameter.Value = objClsListapre1BE.productodescrcorta
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@productodescripcion", SqlDbType.VarChar,100)
	lpParameter.Value = objClsListapre1BE.productodescripcion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@productoestunidreferencia", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsListapre1BE.productoestunidreferencia=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@productofamiliacodigo", SqlDbType.VarChar,5)
	lpParameter.Value = objClsListapre1BE.productofamiliacodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@productoporcimpto", SqlDbType.VarChar,20)
	lpParameter.Value = objClsListapre1BE.productoporcimpto
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@productoprecvta", SqlDbType.VarChar,20)
	lpParameter.Value = objClsListapre1BE.productoprecvta
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@productoprecvtaEtiqueta03", SqlDbType.VarChar,20)
	lpParameter.Value = objClsListapre1BE.productoprecvtaEtiqueta03
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@productoprecvtaEtiqueta06", SqlDbType.VarChar,20)
	lpParameter.Value = objClsListapre1BE.productoprecvtaEtiqueta06
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@productoprecvtaEtiqueta12", SqlDbType.VarChar,20)
	lpParameter.Value = objClsListapre1BE.productoprecvtaEtiqueta12
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@productoprecvtaMayor", SqlDbType.VarChar,20)
	lpParameter.Value = objClsListapre1BE.productoprecvtaMayor
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@productoprecvtaofi", SqlDbType.VarChar,20)
	lpParameter.Value = objClsListapre1BE.productoprecvtaofi
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@productoprecvtaPresentacion", SqlDbType.VarChar,10)
	lpParameter.Value = objClsListapre1BE.productoprecvtaPresentacion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@productoprecvtareparto", SqlDbType.VarChar,20)
	lpParameter.Value = objClsListapre1BE.productoprecvtareparto
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@productotipo", SqlDbType.VarChar,1)
	lpParameter.Value = objClsListapre1BE.productotipo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@unidadcodigo", SqlDbType.VarChar,5)
	lpParameter.Value = objClsListapre1BE.unidadcodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@unidadfactorconv", SqlDbType.VarChar,20)
	lpParameter.Value = objClsListapre1BE.unidadfactorconv
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@unidadreferencial", SqlDbType.VarChar,5)
	lpParameter.Value = objClsListapre1BE.unidadreferencial
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("Listapre1_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("Listapre1_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

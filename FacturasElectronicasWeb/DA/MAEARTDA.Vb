Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class MAEARTDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsMAEARTBE As MAEARTBE) As Boolean
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

	lpParameter = New SqlParameter("@ACASILLERO", SqlDbType.VarChar,12)
	lpParameter.Value = objClsMAEARTBE.ACASILLERO
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ACODIGO", SqlDbType.VarChar,20)
	lpParameter.Value = objClsMAEARTBE.ACODIGO
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ACODIGO2", SqlDbType.VarChar,40)
	lpParameter.Value = objClsMAEARTBE.ACODIGO2
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ACODMON", SqlDbType.VarChar,2)
	lpParameter.Value = objClsMAEARTBE.ACODMON
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ACODMONC", SqlDbType.VarChar,2)
	lpParameter.Value = objClsMAEARTBE.ACODMONC
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ACODPRO", SqlDbType.VarChar,50)
	lpParameter.Value = objClsMAEARTBE.ACODPRO
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ACOLOR", SqlDbType.VarChar,20)
	lpParameter.Value = objClsMAEARTBE.ACOLOR
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ACOMENTA", SqlDbType.VarChar,1073741823)
	lpParameter.Value = objClsMAEARTBE.ACOMENTA
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ACUENTA", SqlDbType.VarChar,18)
	lpParameter.Value = objClsMAEARTBE.ACUENTA
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ADESCRI", SqlDbType.VarChar,100)
	lpParameter.Value = objClsMAEARTBE.ADESCRI
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ADESCRI2", SqlDbType.VarChar,64)
	lpParameter.Value = objClsMAEARTBE.ADESCRI2
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ADESCTO", SqlDbType.VarChar,20)
	lpParameter.Value = objClsMAEARTBE.ADESCTO
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@AFACREF", SqlDbType.VarChar,20)
	lpParameter.Value = objClsMAEARTBE.AFACREF
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@AFAMILIA", SqlDbType.VarChar,10)
	lpParameter.Value = objClsMAEARTBE.AFAMILIA
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@AFDECI", SqlDbType.VarChar,1)
	lpParameter.Value = objClsMAEARTBE.AFDECI
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@AFECHA", SqlDbType.DateTime)
	lpParameter.Value = objClsMAEARTBE.AFECHA
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@AFECVEN", SqlDbType.DateTime)
	lpParameter.Value = objClsMAEARTBE.AFECVEN
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@AFLAGIGV", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsMAEARTBE.AFLAGIGV=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@AFLOTE", SqlDbType.VarChar,1)
	lpParameter.Value = objClsMAEARTBE.AFLOTE
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@AFPRELIB", SqlDbType.VarChar,1)
	lpParameter.Value = objClsMAEARTBE.AFPRELIB
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@AFRESTA", SqlDbType.VarChar,1)
	lpParameter.Value = objClsMAEARTBE.AFRESTA
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@AFSERIE", SqlDbType.VarChar,1)
	lpParameter.Value = objClsMAEARTBE.AFSERIE
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@AFSTOCK", SqlDbType.VarChar,50)
	lpParameter.Value = objClsMAEARTBE.AFSTOCK
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@AFUNIREF", SqlDbType.VarChar,1)
	lpParameter.Value = objClsMAEARTBE.AFUNIREF
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@AGRUPO", SqlDbType.VarChar,10)
	lpParameter.Value = objClsMAEARTBE.AGRUPO
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@AHORA", SqlDbType.DateTime)
	lpParameter.Value = objClsMAEARTBE.AHORA
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@AIGVPOR", SqlDbType.VarChar,20)
	lpParameter.Value = objClsMAEARTBE.AIGVPOR
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@AISCPOR", SqlDbType.VarChar,20)
	lpParameter.Value = objClsMAEARTBE.AISCPOR
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ALINEA", SqlDbType.VarChar,10)
	lpParameter.Value = objClsMAEARTBE.ALINEA
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@AMARCA", SqlDbType.VarChar,50)
	lpParameter.Value = objClsMAEARTBE.AMARCA
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@AMODELO", SqlDbType.VarChar,8)
	lpParameter.Value = objClsMAEARTBE.AMODELO
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@APCOM", SqlDbType.VarChar,20)
	lpParameter.Value = objClsMAEARTBE.APCOM
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@APDIS", SqlDbType.VarChar,20)
	lpParameter.Value = objClsMAEARTBE.APDIS
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@APESO", SqlDbType.VarChar,20)
	lpParameter.Value = objClsMAEARTBE.APESO
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@APRECIO", SqlDbType.VarChar,20)
	lpParameter.Value = objClsMAEARTBE.APRECIO
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@APRECOM", SqlDbType.VarChar,20)
	lpParameter.Value = objClsMAEARTBE.APRECOM
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ATALLA", SqlDbType.VarChar,50)
	lpParameter.Value = objClsMAEARTBE.ATALLA
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ATIPO", SqlDbType.VarChar,2)
	lpParameter.Value = objClsMAEARTBE.ATIPO
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@AUNIART", SqlDbType.VarChar,20)
	lpParameter.Value = objClsMAEARTBE.AUNIART
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@AUNIDAD", SqlDbType.VarChar,6)
	lpParameter.Value = objClsMAEARTBE.AUNIDAD
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@AUNIREF", SqlDbType.VarChar,2)
	lpParameter.Value = objClsMAEARTBE.AUNIREF
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@AUSER", SqlDbType.VarChar,8)
	lpParameter.Value = objClsMAEARTBE.AUSER
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@codigodebarras", SqlDbType.VarChar,20)
	lpParameter.Value = objClsMAEARTBE.codigodebarras
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EstadoAnulado", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsMAEARTBE.EstadoAnulado=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@estadodetraccion", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsMAEARTBE.estadodetraccion=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@PA", SqlDbType.VarChar,30)
	lpParameter.Value = objClsMAEARTBE.PA
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ProductoBonificacion", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsMAEARTBE.ProductoBonificacion=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ProductoFiscalizado", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsMAEARTBE.ProductoFiscalizado=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@proyectocodigo", SqlDbType.VarChar,3)
	lpParameter.Value = objClsMAEARTBE.proyectocodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@StockMinimo", SqlDbType.VarChar,20)
	lpParameter.Value = objClsMAEARTBE.StockMinimo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TALLA", SqlDbType.VarChar,3)
	lpParameter.Value = objClsMAEARTBE.TALLA
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@tipodecambio", SqlDbType.VarChar,20)
	lpParameter.Value = objClsMAEARTBE.tipodecambio
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("MAEART_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("MAEART_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

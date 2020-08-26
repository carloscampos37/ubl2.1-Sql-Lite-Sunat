Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class vt_parametroventaDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsvt_parametroventaBE As vt_parametroventaBE) As Boolean
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

	lpParameter = New SqlParameter("@AjustesSolesxDolares", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_parametroventaBE.AjustesSolesxDolares=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@almacencodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_parametroventaBE.almacencodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@codigotransaccionventa", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_parametroventaBE.codigotransaccionventa
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@cuentaIgv", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_parametroventaBE.cuentaIgv
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@cuentaVtaImporte", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_parametroventaBE.cuentaVtaImporte
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@cuentaVtaTotDolares", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_parametroventaBE.cuentaVtaTotDolares
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@cuentaVtaTotSoles", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_parametroventaBE.cuentaVtaTotSoles
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@empresacodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_parametroventaBE.empresacodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@FacturacionenlineaContab", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_parametroventaBE.FacturacionenlineaContab=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@fechaact", SqlDbType.DateTime)
	lpParameter.Value = objClsvt_parametroventaBE.fechaact
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@kitvirtual", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_parametroventaBE.kitvirtual=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@minimodetraccion", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_parametroventaBE.minimodetraccion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@monedacodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_parametroventaBE.monedacodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@paramvtaboleta", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_parametroventaBE.paramvtaboleta=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@paramvtacomisionvendedor", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_parametroventaBE.paramvtacomisionvendedor=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@paramvtadesc", SqlDbType.VarChar,35)
	lpParameter.Value = objClsvt_parametroventaBE.paramvtadesc
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@paramvtadescor", SqlDbType.VarChar,15)
	lpParameter.Value = objClsvt_parametroventaBE.paramvtadescor
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@paramvtadescto", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_parametroventaBE.paramvtadescto
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@paramvtadirec", SqlDbType.VarChar,30)
	lpParameter.Value = objClsvt_parametroventaBE.paramvtadirec
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@paramvtaestdesc", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_parametroventaBE.paramvtaestdesc=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@paramvtaestigv", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_parametroventaBE.paramvtaestigv=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@paramvtafax", SqlDbType.VarChar,10)
	lpParameter.Value = objClsvt_parametroventaBE.paramvtafax
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@paramvtaformaemision", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_parametroventaBE.paramvtaformaemision=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@paramvtalistaprec", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_parametroventaBE.paramvtalistaprec=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@paramvtamasivo", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_parametroventaBE.paramvtamasivo=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@paramvtamensaje", SqlDbType.VarChar,70)
	lpParameter.Value = objClsvt_parametroventaBE.paramvtamensaje
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@paramvtaporcigv", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_parametroventaBE.paramvtaporcigv
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@paramvtatelefonos", SqlDbType.VarChar,25)
	lpParameter.Value = objClsvt_parametroventaBE.paramvtatelefonos
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@paramvtatipcambref", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_parametroventaBE.paramvtatipcambref
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@paramvtaValorUit", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_parametroventaBE.paramvtaValorUit
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@PedidosSinfacturar", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_parametroventaBE.PedidosSinfacturar=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@PorcentajeCredito", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_parametroventaBE.PorcentajeCredito
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@RangodePrecios", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_parametroventaBE.RangodePrecios=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@stockcomp", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_parametroventaBE.stockcomp=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@tesoreriaenlinea", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_parametroventaBE.tesoreriaenlinea=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@tiporedondeocobrar", SqlDbType.VarChar,10)
	lpParameter.Value = objClsvt_parametroventaBE.tiporedondeocobrar
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@usuariocodigo", SqlDbType.VarChar,8)
	lpParameter.Value = objClsvt_parametroventaBE.usuariocodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ventasBM", SqlDbType.VarChar,10)
	lpParameter.Value = objClsvt_parametroventaBE.ventasBM
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("vt_parametroventa_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("vt_parametroventa_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

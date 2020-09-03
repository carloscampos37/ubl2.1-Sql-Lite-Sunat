Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class vt_modoventaDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsvt_modoventaBE As vt_modoventaBE) As Boolean
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
	lpParameter.Value = objClsvt_modoventaBE.documentocodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@fechaact", SqlDbType.DateTime)
	lpParameter.Value = objClsvt_modoventaBE.fechaact
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtaactctacte", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_modoventaBE.modovtaactctacte=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtaalmacen", SqlDbType.VarChar,60)
	lpParameter.Value = objClsvt_modoventaBE.modovtaalmacen
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtacanje", SqlDbType.VarChar,1)
	lpParameter.Value = objClsvt_modoventaBE.modovtacanje
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtacodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_modoventaBE.modovtacodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtacontrolcorr", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_modoventaBE.modovtacontrolcorr=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtacopiasBO", SqlDbType.VarChar,10)
	lpParameter.Value = objClsvt_modoventaBE.modovtacopiasBO
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtacopiasboleta", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_modoventaBE.modovtacopiasboleta
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtacopiasfact", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_modoventaBE.modovtacopiasfact
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtacopiasguiarem", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_modoventaBE.modovtacopiasguiarem
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtacopiashojatrab", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_modoventaBE.modovtacopiashojatrab
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtacopiasticket", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_modoventaBE.modovtacopiasticket
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtacorrguiarem", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_modoventaBE.modovtacorrguiarem=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtacrtlfact", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_modoventaBE.modovtacrtlfact
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtactrlinventario", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_modoventaBE.modovtactrlinventario=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtadescrcorta", SqlDbType.VarChar,15)
	lpParameter.Value = objClsvt_modoventaBE.modovtadescrcorta
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtadescripcion", SqlDbType.VarChar,30)
	lpParameter.Value = objClsvt_modoventaBE.modovtadescripcion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtadscto", SqlDbType.VarChar,1)
	lpParameter.Value = objClsvt_modoventaBE.modovtadscto
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtaemiteguia", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_modoventaBE.modovtaemiteguia=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtaemitehoja", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_modoventaBE.modovtaemitehoja=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtaimpuestos", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_modoventaBE.modovtaimpuestos=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtaingcodclie", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_modoventaBE.modovtaingcodclie=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtaingformapag", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_modoventaBE.modovtaingformapag=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtaingguiarem", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_modoventaBE.modovtaingguiarem=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtainghastafact", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_modoventaBE.modovtainghastafact=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtainghastahoja", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_modoventaBE.modovtainghastahoja=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtainghojatrab", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_modoventaBE.modovtainghojatrab=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtaingpedido", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_modoventaBE.modovtaingpedido=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtaitemxdoc", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_modoventaBE.modovtaitemxdoc
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtanumautom", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_modoventaBE.modovtanumautom=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtasolemitfact", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_modoventaBE.modovtasolemitfact=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtaunidadmedida", SqlDbType.VarChar,3)
	lpParameter.Value = objClsvt_modoventaBE.modovtaunidadmedida
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtausafactconv", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_modoventaBE.modovtausafactconv=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@puntovtacodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_modoventaBE.puntovtacodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@usuariocodigo", SqlDbType.VarChar,8)
	lpParameter.Value = objClsvt_modoventaBE.usuariocodigo
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("vt_modoventa_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("vt_modoventa_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

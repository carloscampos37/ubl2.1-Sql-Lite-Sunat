Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class vt_detallepedidoDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsvt_detallepedidoBE As vt_detallepedidoBE) As Boolean
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

	lpParameter = New SqlParameter("@detpedcantdespach", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.detpedcantdespach
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpedcantdespachref", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.detpedcantdespachref
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpedcantdevol", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.detpedcantdevol
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpedcantdevolref", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.detpedcantdevolref
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpedcantentreg", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.detpedcantentreg
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpedcantentregref", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.detpedcantentregref
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpedcantpedida", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.detpedcantpedida
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpedcantpedidaref", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.detpedcantpedidaref
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpedcostopromed", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.detpedcostopromed
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpeddsctoxitem", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.detpeddsctoxitem
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpeddsctoxlinea", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.detpeddsctoxlinea
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpeddsctoxprom", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.detpeddsctoxprom
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpedestado", SqlDbType.VarChar,1)
	lpParameter.Value = objClsvt_detallepedidoBE.detpedestado
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpedfactorconv", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.detpedfactorconv
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpedimpbruto", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.detpedimpbruto
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpeditem", SqlDbType.VarChar,3)
	lpParameter.Value = objClsvt_detallepedidoBE.detpeditem
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpedmetrica", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.detpedmetrica
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpedmontdsctoxitem", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.detpedmontdsctoxitem
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpedmontodsctoxlinea", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.detpedmontodsctoxlinea
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpedmontodsctoxprom", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.detpedmontodsctoxprom
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@DetPedMontoImpInafecto", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.DetPedMontoImpInafecto
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpedmontoimpto", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.detpedmontoimpto
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpedmontoprecvta", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.detpedmontoprecvta
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpedobservacion", SqlDbType.VarChar,240)
	lpParameter.Value = objClsvt_detallepedidoBE.detpedobservacion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpedpartida", SqlDbType.VarChar,15)
	lpParameter.Value = objClsvt_detallepedidoBE.detpedpartida
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpedporccomis", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.detpedporccomis
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpedporcimp", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.detpedporcimp
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpedpreciocosto", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.detpedpreciocosto
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@detpedpreciopact", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.detpedpreciopact
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@empresacodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_detallepedidoBE.empresacodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidodocumentoNumero", SqlDbType.VarChar,10)
	lpParameter.Value = objClsvt_detallepedidoBE.pedidodocumentoNumero
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidonumero", SqlDbType.VarChar,15)
	lpParameter.Value = objClsvt_detallepedidoBE.pedidonumero
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@productocodigo", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_detallepedidoBE.productocodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@unidadcodigo", SqlDbType.VarChar,5)
	lpParameter.Value = objClsvt_detallepedidoBE.unidadcodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@unidadreferencial", SqlDbType.VarChar,3)
	lpParameter.Value = objClsvt_detallepedidoBE.unidadreferencial
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("vt_detallepedido_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("vt_detallepedido_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

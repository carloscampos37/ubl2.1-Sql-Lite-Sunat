Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class vt_pedidoDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsvt_pedidoBE As vt_pedidoBE) As Boolean
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

	lpParameter = New SqlParameter("@almacencodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_pedidoBE.almacencodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@clientecodigo", SqlDbType.VarChar,11)
	lpParameter.Value = objClsvt_pedidoBE.clientecodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@clientedireccion", SqlDbType.VarChar,80)
	lpParameter.Value = objClsvt_pedidoBE.clientedireccion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@clientedistrito", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_pedidoBE.clientedistrito
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@clienterazonsocial", SqlDbType.VarChar,80)
	lpParameter.Value = objClsvt_pedidoBE.clienterazonsocial
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@clienteruc", SqlDbType.VarChar,11)
	lpParameter.Value = objClsvt_pedidoBE.clienteruc
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@empresacodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_pedidoBE.empresacodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EnvioSedePrincipal", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_pedidoBE.EnvioSedePrincipal=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@estadoreg", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_pedidoBE.estadoreg=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@fechaact", SqlDbType.DateTime)
	lpParameter.Value = objClsvt_pedidoBE.fechaact
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@formapagocodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_pedidoBE.formapagocodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@horaentrega", SqlDbType.VarChar,5)
	lpParameter.Value = objClsvt_pedidoBE.horaentrega
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@modovtacodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_pedidoBE.modovtacodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NumeroDocModifica", SqlDbType.VarChar,10)
	lpParameter.Value = objClsvt_pedidoBE.NumeroDocModifica
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@PEDIDOATENDIDO", SqlDbType.VarChar,1)
	lpParameter.Value = objClsvt_pedidoBE.PEDIDOATENDIDO
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidoautorizacion", SqlDbType.VarChar,1)
	lpParameter.Value = objClsvt_pedidoBE.pedidoautorizacion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidocondicionfactura", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_pedidoBE.pedidocondicionfactura
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@PedidodelDia", SqlDbType.VarChar,10)
	lpParameter.Value = objClsvt_pedidoBE.PedidodelDia
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidodiaspago", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_pedidoBE.pedidodiaspago
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@PedidoDocumentoNumero", SqlDbType.VarChar,10)
	lpParameter.Value = objClsvt_pedidoBE.PedidoDocumentoNumero
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@PedidoDocumentoNumerofinal", SqlDbType.VarChar,10)
	lpParameter.Value = objClsvt_pedidoBE.PedidoDocumentoNumerofinal
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@PedidoDocumentoSerie", SqlDbType.VarChar,4)
	lpParameter.Value = objClsvt_pedidoBE.PedidoDocumentoSerie
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidodsctocliente", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_pedidoBE.pedidodsctocliente
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidodsctoglobal", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_pedidoBE.pedidodsctoglobal
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidodsctoppago", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_pedidoBE.pedidodsctoppago
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidodsctovtaoficina", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_pedidoBE.pedidodsctovtaoficina
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidoemisionfact", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsvt_pedidoBE.pedidoemisionfact=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidoentrega", SqlDbType.VarChar,70)
	lpParameter.Value = objClsvt_pedidoBE.pedidoentrega
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidoestado", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_pedidoBE.pedidoestado
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidofecha", SqlDbType.DateTime)
	lpParameter.Value = objClsvt_pedidoBE.pedidofecha
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidofechaanu", SqlDbType.DateTime)
	lpParameter.Value = objClsvt_pedidoBE.pedidofechaanu
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidofechafact", SqlDbType.DateTime)
	lpParameter.Value = objClsvt_pedidoBE.pedidofechafact
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidofechapag", SqlDbType.DateTime)
	lpParameter.Value = objClsvt_pedidoBE.pedidofechapag
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidofechasunat", SqlDbType.DateTime)
	lpParameter.Value = objClsvt_pedidoBE.pedidofechasunat
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidolistaprec", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_pedidoBE.pedidolistaprec
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidomensaje", SqlDbType.VarChar,240)
	lpParameter.Value = objClsvt_pedidoBE.pedidomensaje
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidomoneda", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_pedidoBE.pedidomoneda
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidomontodsctocliente", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_pedidoBE.pedidomontodsctocliente
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidomontodsctoglobal", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_pedidoBE.pedidomontodsctoglobal
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidomontodsctoppago", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_pedidoBE.pedidomontodsctoppago
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidomontodsctovtaoficina", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_pedidoBE.pedidomontodsctovtaoficina
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidonotaped", SqlDbType.VarChar,10)
	lpParameter.Value = objClsvt_pedidoBE.pedidonotaped
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidonroboleta", SqlDbType.VarChar,15)
	lpParameter.Value = objClsvt_pedidoBE.pedidonroboleta
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidonrofact", SqlDbType.VarChar,15)
	lpParameter.Value = objClsvt_pedidoBE.pedidonrofact
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidonrogiarem", SqlDbType.VarChar,15)
	lpParameter.Value = objClsvt_pedidoBE.pedidonrogiarem
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidonrorefe", SqlDbType.VarChar,15)
	lpParameter.Value = objClsvt_pedidoBE.pedidonrorefe
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidonumero", SqlDbType.VarChar,15)
	lpParameter.Value = objClsvt_pedidoBE.pedidonumero
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidoobserva", SqlDbType.VarChar,120)
	lpParameter.Value = objClsvt_pedidoBE.pedidoobserva
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidoordencompra", SqlDbType.VarChar,10)
	lpParameter.Value = objClsvt_pedidoBE.pedidoordencompra
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@PedidoPagoCaja", SqlDbType.VarChar,10)
	lpParameter.Value = objClsvt_pedidoBE.PedidoPagoCaja
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidoporccomision", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_pedidoBE.pedidoporccomision
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidotarjetacred", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_pedidoBE.pedidotarjetacred
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidotipcambio", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_pedidoBE.pedidotipcambio
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidotipofac", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_pedidoBE.pedidotipofac
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidotiporefe", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_pedidoBE.pedidotiporefe
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidototaldsctoxitem", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_pedidoBE.pedidototaldsctoxitem
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidototaldsctoxlinea", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_pedidoBE.pedidototaldsctoxlinea
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidototaldsctoxprom", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_pedidoBE.pedidototaldsctoxprom
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidototalflete", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_pedidoBE.pedidototalflete
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidototalotros", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_pedidoBE.pedidototalotros
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidototbruto", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_pedidoBE.pedidototbruto
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidototimpuesto", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_pedidoBE.pedidototimpuesto
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidototinafecto", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_pedidoBE.pedidototinafecto
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidototitem", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_pedidoBE.pedidototitem
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidototneto", SqlDbType.VarChar,20)
	lpParameter.Value = objClsvt_pedidoBE.pedidototneto
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@pedidoventadiferida", SqlDbType.VarChar,10)
	lpParameter.Value = objClsvt_pedidoBE.pedidoventadiferida
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@profesionalcodigo", SqlDbType.VarChar,11)
	lpParameter.Value = objClsvt_pedidoBE.profesionalcodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@proyectocodigo", SqlDbType.VarChar,11)
	lpParameter.Value = objClsvt_pedidoBE.proyectocodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@puntovtacodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_pedidoBE.puntovtacodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@SerieDocModifica", SqlDbType.VarChar,4)
	lpParameter.Value = objClsvt_pedidoBE.SerieDocModifica
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@tipocontactocodigo", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_pedidoBE.tipocontactocodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TipoDocModifica", SqlDbType.VarChar,2)
	lpParameter.Value = objClsvt_pedidoBE.TipoDocModifica
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@transportecodigo", SqlDbType.VarChar,11)
	lpParameter.Value = objClsvt_pedidoBE.transportecodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@usuariocodigo", SqlDbType.VarChar,8)
	lpParameter.Value = objClsvt_pedidoBE.usuariocodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@vendedorcodigo", SqlDbType.VarChar,3)
	lpParameter.Value = objClsvt_pedidoBE.vendedorcodigo
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("vt_pedido_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("vt_pedido_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class

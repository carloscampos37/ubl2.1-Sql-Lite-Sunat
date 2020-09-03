Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New vt_pedidoBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	Txtalmacencodigo.Text = dtx.Rows(i)("almacencodigo").ToString
	Txtclientecodigo.Text = dtx.Rows(i)("clientecodigo").ToString
	Txtclientedireccion.Text = dtx.Rows(i)("clientedireccion").ToString
	Txtclientedistrito.Text = dtx.Rows(i)("clientedistrito").ToString
	Txtclienterazonsocial.Text = dtx.Rows(i)("clienterazonsocial").ToString
	Txtclienteruc.Text = dtx.Rows(i)("clienteruc").ToString
	Txtempresacodigo.Text = dtx.Rows(i)("empresacodigo").ToString
	ChkEnvioSedePrincipal.Checked = dtx.Rows(i)("EnvioSedePrincipal").ToString
	Chkestadoreg.Checked = dtx.Rows(i)("estadoreg").ToString
	Dtpfechaact.Value = dtx.Rows(i)("fechaact").ToString
	Txtformapagocodigo.Text = dtx.Rows(i)("formapagocodigo").ToString
	Txthoraentrega.Text = dtx.Rows(i)("horaentrega").ToString
	Txtmodovtacodigo.Text = dtx.Rows(i)("modovtacodigo").ToString
	NumNumeroDocModifica.Text = dtx.Rows(i)("NumeroDocModifica").ToString
	TxtPEDIDOATENDIDO.Text = dtx.Rows(i)("PEDIDOATENDIDO").ToString
	Txtpedidoautorizacion.Text = dtx.Rows(i)("pedidoautorizacion").ToString
	Txtpedidocondicionfactura.Text = dtx.Rows(i)("pedidocondicionfactura").ToString
	NumPedidodelDia.Text = dtx.Rows(i)("PedidodelDia").ToString
	Numpedidodiaspago.Text = dtx.Rows(i)("pedidodiaspago").ToString
	NumPedidoDocumentoNumero.Text = dtx.Rows(i)("PedidoDocumentoNumero").ToString
	NumPedidoDocumentoNumerofinal.Text = dtx.Rows(i)("PedidoDocumentoNumerofinal").ToString
	TxtPedidoDocumentoSerie.Text = dtx.Rows(i)("PedidoDocumentoSerie").ToString
	Numpedidodsctocliente.Text = dtx.Rows(i)("pedidodsctocliente").ToString
	Numpedidodsctoglobal.Text = dtx.Rows(i)("pedidodsctoglobal").ToString
	Numpedidodsctoppago.Text = dtx.Rows(i)("pedidodsctoppago").ToString
	Numpedidodsctovtaoficina.Text = dtx.Rows(i)("pedidodsctovtaoficina").ToString
	Chkpedidoemisionfact.Checked = dtx.Rows(i)("pedidoemisionfact").ToString
	Txtpedidoentrega.Text = dtx.Rows(i)("pedidoentrega").ToString
	Txtpedidoestado.Text = dtx.Rows(i)("pedidoestado").ToString
	Dtppedidofecha.Value = dtx.Rows(i)("pedidofecha").ToString
	Dtppedidofechaanu.Value = dtx.Rows(i)("pedidofechaanu").ToString
	Dtppedidofechafact.Value = dtx.Rows(i)("pedidofechafact").ToString
	Dtppedidofechapag.Value = dtx.Rows(i)("pedidofechapag").ToString
	Dtppedidofechasunat.Value = dtx.Rows(i)("pedidofechasunat").ToString
	Txtpedidolistaprec.Text = dtx.Rows(i)("pedidolistaprec").ToString
	Txtpedidomensaje.Text = dtx.Rows(i)("pedidomensaje").ToString
	Txtpedidomoneda.Text = dtx.Rows(i)("pedidomoneda").ToString
	Numpedidomontodsctocliente.Text = dtx.Rows(i)("pedidomontodsctocliente").ToString
	Numpedidomontodsctoglobal.Text = dtx.Rows(i)("pedidomontodsctoglobal").ToString
	Numpedidomontodsctoppago.Text = dtx.Rows(i)("pedidomontodsctoppago").ToString
	Numpedidomontodsctovtaoficina.Text = dtx.Rows(i)("pedidomontodsctovtaoficina").ToString
	Txtpedidonotaped.Text = dtx.Rows(i)("pedidonotaped").ToString
	Txtpedidonroboleta.Text = dtx.Rows(i)("pedidonroboleta").ToString
	Txtpedidonrofact.Text = dtx.Rows(i)("pedidonrofact").ToString
	Txtpedidonrogiarem.Text = dtx.Rows(i)("pedidonrogiarem").ToString
	Txtpedidonrorefe.Text = dtx.Rows(i)("pedidonrorefe").ToString
	Txtpedidonumero.Text = dtx.Rows(i)("pedidonumero").ToString
	Txtpedidoobserva.Text = dtx.Rows(i)("pedidoobserva").ToString
	Txtpedidoordencompra.Text = dtx.Rows(i)("pedidoordencompra").ToString
	NumPedidoPagoCaja.Text = dtx.Rows(i)("PedidoPagoCaja").ToString
	Numpedidoporccomision.Text = dtx.Rows(i)("pedidoporccomision").ToString
	Txtpedidotarjetacred.Text = dtx.Rows(i)("pedidotarjetacred").ToString
	Numpedidotipcambio.Text = dtx.Rows(i)("pedidotipcambio").ToString
	Txtpedidotipofac.Text = dtx.Rows(i)("pedidotipofac").ToString
	Txtpedidotiporefe.Text = dtx.Rows(i)("pedidotiporefe").ToString
	Numpedidototaldsctoxitem.Text = dtx.Rows(i)("pedidototaldsctoxitem").ToString
	Numpedidototaldsctoxlinea.Text = dtx.Rows(i)("pedidototaldsctoxlinea").ToString
	Numpedidototaldsctoxprom.Text = dtx.Rows(i)("pedidototaldsctoxprom").ToString
	Numpedidototalflete.Text = dtx.Rows(i)("pedidototalflete").ToString
	Numpedidototalotros.Text = dtx.Rows(i)("pedidototalotros").ToString
	Numpedidototbruto.Text = dtx.Rows(i)("pedidototbruto").ToString
	Numpedidototimpuesto.Text = dtx.Rows(i)("pedidototimpuesto").ToString
	Numpedidototinafecto.Text = dtx.Rows(i)("pedidototinafecto").ToString
	Numpedidototitem.Text = dtx.Rows(i)("pedidototitem").ToString
	Numpedidototneto.Text = dtx.Rows(i)("pedidototneto").ToString
	Numpedidoventadiferida.Text = dtx.Rows(i)("pedidoventadiferida").ToString
	Txtprofesionalcodigo.Text = dtx.Rows(i)("profesionalcodigo").ToString
	Txtproyectocodigo.Text = dtx.Rows(i)("proyectocodigo").ToString
	Txtpuntovtacodigo.Text = dtx.Rows(i)("puntovtacodigo").ToString
	TxtSerieDocModifica.Text = dtx.Rows(i)("SerieDocModifica").ToString
	Txttipocontactocodigo.Text = dtx.Rows(i)("tipocontactocodigo").ToString
	TxtTipoDocModifica.Text = dtx.Rows(i)("TipoDocModifica").ToString
	Txttransportecodigo.Text = dtx.Rows(i)("transportecodigo").ToString
	Txtusuariocodigo.Text = dtx.Rows(i)("usuariocodigo").ToString
	Txtvendedorcodigo.Text = dtx.Rows(i)("vendedorcodigo").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.vt_pedidoBL
Dim objBE As New BusinessEntities.vt_pedidoBE

TRY

	ObjBE.almacencodigo=Txtalmacencodigo.Text
	ObjBE.clientecodigo=Txtclientecodigo.Text
	ObjBE.clientedireccion=Txtclientedireccion.Text
	ObjBE.clientedistrito=Txtclientedistrito.Text
	ObjBE.clienterazonsocial=Txtclienterazonsocial.Text
	ObjBE.clienteruc=Txtclienteruc.Text
	ObjBE.empresacodigo=Txtempresacodigo.Text
	ObjBE.EnvioSedePrincipal=ChkEnvioSedePrincipal.Checked
	ObjBE.estadoreg=Chkestadoreg.Checked
	ObjBE.fechaact=Dtpfechaact.Value
	ObjBE.formapagocodigo=Txtformapagocodigo.Text
	ObjBE.horaentrega=Txthoraentrega.Text
	ObjBE.modovtacodigo=Txtmodovtacodigo.Text
	ObjBE.NumeroDocModifica=NumNumeroDocModifica.Text
	ObjBE.PEDIDOATENDIDO=TxtPEDIDOATENDIDO.Text
	ObjBE.pedidoautorizacion=Txtpedidoautorizacion.Text
	ObjBE.pedidocondicionfactura=Txtpedidocondicionfactura.Text
	ObjBE.PedidodelDia=NumPedidodelDia.Text
	ObjBE.pedidodiaspago=Numpedidodiaspago.Text
	ObjBE.PedidoDocumentoNumero=NumPedidoDocumentoNumero.Text
	ObjBE.PedidoDocumentoNumerofinal=NumPedidoDocumentoNumerofinal.Text
	ObjBE.PedidoDocumentoSerie=TxtPedidoDocumentoSerie.Text
	ObjBE.pedidodsctocliente=Numpedidodsctocliente.Text
	ObjBE.pedidodsctoglobal=Numpedidodsctoglobal.Text
	ObjBE.pedidodsctoppago=Numpedidodsctoppago.Text
	ObjBE.pedidodsctovtaoficina=Numpedidodsctovtaoficina.Text
	ObjBE.pedidoemisionfact=Chkpedidoemisionfact.Checked
	ObjBE.pedidoentrega=Txtpedidoentrega.Text
	ObjBE.pedidoestado=Txtpedidoestado.Text
	ObjBE.pedidofecha=Dtppedidofecha.Value
	ObjBE.pedidofechaanu=Dtppedidofechaanu.Value
	ObjBE.pedidofechafact=Dtppedidofechafact.Value
	ObjBE.pedidofechapag=Dtppedidofechapag.Value
	ObjBE.pedidofechasunat=Dtppedidofechasunat.Value
	ObjBE.pedidolistaprec=Txtpedidolistaprec.Text
	ObjBE.pedidomensaje=Txtpedidomensaje.Text
	ObjBE.pedidomoneda=Txtpedidomoneda.Text
	ObjBE.pedidomontodsctocliente=Numpedidomontodsctocliente.Text
	ObjBE.pedidomontodsctoglobal=Numpedidomontodsctoglobal.Text
	ObjBE.pedidomontodsctoppago=Numpedidomontodsctoppago.Text
	ObjBE.pedidomontodsctovtaoficina=Numpedidomontodsctovtaoficina.Text
	ObjBE.pedidonotaped=Txtpedidonotaped.Text
	ObjBE.pedidonroboleta=Txtpedidonroboleta.Text
	ObjBE.pedidonrofact=Txtpedidonrofact.Text
	ObjBE.pedidonrogiarem=Txtpedidonrogiarem.Text
	ObjBE.pedidonrorefe=Txtpedidonrorefe.Text
	ObjBE.pedidonumero=Txtpedidonumero.Text
	ObjBE.pedidoobserva=Txtpedidoobserva.Text
	ObjBE.pedidoordencompra=Txtpedidoordencompra.Text
	ObjBE.PedidoPagoCaja=NumPedidoPagoCaja.Text
	ObjBE.pedidoporccomision=Numpedidoporccomision.Text
	ObjBE.pedidotarjetacred=Txtpedidotarjetacred.Text
	ObjBE.pedidotipcambio=Numpedidotipcambio.Text
	ObjBE.pedidotipofac=Txtpedidotipofac.Text
	ObjBE.pedidotiporefe=Txtpedidotiporefe.Text
	ObjBE.pedidototaldsctoxitem=Numpedidototaldsctoxitem.Text
	ObjBE.pedidototaldsctoxlinea=Numpedidototaldsctoxlinea.Text
	ObjBE.pedidototaldsctoxprom=Numpedidototaldsctoxprom.Text
	ObjBE.pedidototalflete=Numpedidototalflete.Text
	ObjBE.pedidototalotros=Numpedidototalotros.Text
	ObjBE.pedidototbruto=Numpedidototbruto.Text
	ObjBE.pedidototimpuesto=Numpedidototimpuesto.Text
	ObjBE.pedidototinafecto=Numpedidototinafecto.Text
	ObjBE.pedidototitem=Numpedidototitem.Text
	ObjBE.pedidototneto=Numpedidototneto.Text
	ObjBE.pedidoventadiferida=Numpedidoventadiferida.Text
	ObjBE.profesionalcodigo=Txtprofesionalcodigo.Text
	ObjBE.proyectocodigo=Txtproyectocodigo.Text
	ObjBE.puntovtacodigo=Txtpuntovtacodigo.Text
	ObjBE.SerieDocModifica=TxtSerieDocModifica.Text
	ObjBE.tipocontactocodigo=Txttipocontactocodigo.Text
	ObjBE.TipoDocModifica=TxtTipoDocModifica.Text
	ObjBE.transportecodigo=Txttransportecodigo.Text
	ObjBE.usuariocodigo=Txtusuariocodigo.Text
	ObjBE.vendedorcodigo=Txtvendedorcodigo.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from vt_pedido",VgcnxSql)
If dtx.Rows.Count > 0 Then
	objBl.GrabarProc(VGBase, 2, VGBaseGen, objBE)
Else
	objBl.GrabarProc(VGBase, 1, VGBaseGen, objBE)
End If 
 MsgBox(MsgGraba, MsgBoxStyle.Information, MsgTitle)

Catch ex As Exception
MsgBox("Error de grabacion " + ex.Message)
End TRY

End Sub

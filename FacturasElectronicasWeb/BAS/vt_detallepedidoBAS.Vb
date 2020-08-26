Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New vt_detallepedidoBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	Numdetpedcantdespach.Text = dtx.Rows(i)("detpedcantdespach").ToString
	Numdetpedcantdespachref.Text = dtx.Rows(i)("detpedcantdespachref").ToString
	Numdetpedcantdevol.Text = dtx.Rows(i)("detpedcantdevol").ToString
	Numdetpedcantdevolref.Text = dtx.Rows(i)("detpedcantdevolref").ToString
	Numdetpedcantentreg.Text = dtx.Rows(i)("detpedcantentreg").ToString
	Numdetpedcantentregref.Text = dtx.Rows(i)("detpedcantentregref").ToString
	Numdetpedcantpedida.Text = dtx.Rows(i)("detpedcantpedida").ToString
	Numdetpedcantpedidaref.Text = dtx.Rows(i)("detpedcantpedidaref").ToString
	Numdetpedcostopromed.Text = dtx.Rows(i)("detpedcostopromed").ToString
	Numdetpeddsctoxitem.Text = dtx.Rows(i)("detpeddsctoxitem").ToString
	Numdetpeddsctoxlinea.Text = dtx.Rows(i)("detpeddsctoxlinea").ToString
	Numdetpeddsctoxprom.Text = dtx.Rows(i)("detpeddsctoxprom").ToString
	Txtdetpedestado.Text = dtx.Rows(i)("detpedestado").ToString
	Numdetpedfactorconv.Text = dtx.Rows(i)("detpedfactorconv").ToString
	Numdetpedimpbruto.Text = dtx.Rows(i)("detpedimpbruto").ToString
	Txtdetpeditem.Text = dtx.Rows(i)("detpeditem").ToString
	Txtdetpedmetrica.Text = dtx.Rows(i)("detpedmetrica").ToString
	Numdetpedmontdsctoxitem.Text = dtx.Rows(i)("detpedmontdsctoxitem").ToString
	Numdetpedmontodsctoxlinea.Text = dtx.Rows(i)("detpedmontodsctoxlinea").ToString
	Numdetpedmontodsctoxprom.Text = dtx.Rows(i)("detpedmontodsctoxprom").ToString
	NumDetPedMontoImpInafecto.Text = dtx.Rows(i)("DetPedMontoImpInafecto").ToString
	Numdetpedmontoimpto.Text = dtx.Rows(i)("detpedmontoimpto").ToString
	Numdetpedmontoprecvta.Text = dtx.Rows(i)("detpedmontoprecvta").ToString
	Txtdetpedobservacion.Text = dtx.Rows(i)("detpedobservacion").ToString
	Txtdetpedpartida.Text = dtx.Rows(i)("detpedpartida").ToString
	Numdetpedporccomis.Text = dtx.Rows(i)("detpedporccomis").ToString
	Numdetpedporcimp.Text = dtx.Rows(i)("detpedporcimp").ToString
	Numdetpedpreciocosto.Text = dtx.Rows(i)("detpedpreciocosto").ToString
	Numdetpedpreciopact.Text = dtx.Rows(i)("detpedpreciopact").ToString
	Txtempresacodigo.Text = dtx.Rows(i)("empresacodigo").ToString
	NumpedidodocumentoNumero.Text = dtx.Rows(i)("pedidodocumentoNumero").ToString
	Txtpedidonumero.Text = dtx.Rows(i)("pedidonumero").ToString
	Txtproductocodigo.Text = dtx.Rows(i)("productocodigo").ToString
	Txtunidadcodigo.Text = dtx.Rows(i)("unidadcodigo").ToString
	Txtunidadreferencial.Text = dtx.Rows(i)("unidadreferencial").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.vt_detallepedidoBL
Dim objBE As New BusinessEntities.vt_detallepedidoBE

TRY

	ObjBE.detpedcantdespach=Numdetpedcantdespach.Text
	ObjBE.detpedcantdespachref=Numdetpedcantdespachref.Text
	ObjBE.detpedcantdevol=Numdetpedcantdevol.Text
	ObjBE.detpedcantdevolref=Numdetpedcantdevolref.Text
	ObjBE.detpedcantentreg=Numdetpedcantentreg.Text
	ObjBE.detpedcantentregref=Numdetpedcantentregref.Text
	ObjBE.detpedcantpedida=Numdetpedcantpedida.Text
	ObjBE.detpedcantpedidaref=Numdetpedcantpedidaref.Text
	ObjBE.detpedcostopromed=Numdetpedcostopromed.Text
	ObjBE.detpeddsctoxitem=Numdetpeddsctoxitem.Text
	ObjBE.detpeddsctoxlinea=Numdetpeddsctoxlinea.Text
	ObjBE.detpeddsctoxprom=Numdetpeddsctoxprom.Text
	ObjBE.detpedestado=Txtdetpedestado.Text
	ObjBE.detpedfactorconv=Numdetpedfactorconv.Text
	ObjBE.detpedimpbruto=Numdetpedimpbruto.Text
	ObjBE.detpeditem=Txtdetpeditem.Text
	ObjBE.detpedmetrica=Txtdetpedmetrica.Text
	ObjBE.detpedmontdsctoxitem=Numdetpedmontdsctoxitem.Text
	ObjBE.detpedmontodsctoxlinea=Numdetpedmontodsctoxlinea.Text
	ObjBE.detpedmontodsctoxprom=Numdetpedmontodsctoxprom.Text
	ObjBE.DetPedMontoImpInafecto=NumDetPedMontoImpInafecto.Text
	ObjBE.detpedmontoimpto=Numdetpedmontoimpto.Text
	ObjBE.detpedmontoprecvta=Numdetpedmontoprecvta.Text
	ObjBE.detpedobservacion=Txtdetpedobservacion.Text
	ObjBE.detpedpartida=Txtdetpedpartida.Text
	ObjBE.detpedporccomis=Numdetpedporccomis.Text
	ObjBE.detpedporcimp=Numdetpedporcimp.Text
	ObjBE.detpedpreciocosto=Numdetpedpreciocosto.Text
	ObjBE.detpedpreciopact=Numdetpedpreciopact.Text
	ObjBE.empresacodigo=Txtempresacodigo.Text
	ObjBE.pedidodocumentoNumero=NumpedidodocumentoNumero.Text
	ObjBE.pedidonumero=Txtpedidonumero.Text
	ObjBE.productocodigo=Txtproductocodigo.Text
	ObjBE.unidadcodigo=Txtunidadcodigo.Text
	ObjBE.unidadreferencial=Txtunidadreferencial.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from vt_detallepedido",VgcnxSql)
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

Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New vt_parametroventaBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	ChkAjustesSolesxDolares.Checked = dtx.Rows(i)("AjustesSolesxDolares").ToString
	Txtalmacencodigo.Text = dtx.Rows(i)("almacencodigo").ToString
	Txtcodigotransaccionventa.Text = dtx.Rows(i)("codigotransaccionventa").ToString
	TxtcuentaIgv.Text = dtx.Rows(i)("cuentaIgv").ToString
	TxtcuentaVtaImporte.Text = dtx.Rows(i)("cuentaVtaImporte").ToString
	TxtcuentaVtaTotDolares.Text = dtx.Rows(i)("cuentaVtaTotDolares").ToString
	TxtcuentaVtaTotSoles.Text = dtx.Rows(i)("cuentaVtaTotSoles").ToString
	Txtempresacodigo.Text = dtx.Rows(i)("empresacodigo").ToString
	ChkFacturacionenlineaContab.Checked = dtx.Rows(i)("FacturacionenlineaContab").ToString
	Dtpfechaact.Value = dtx.Rows(i)("fechaact").ToString
	Chkkitvirtual.Checked = dtx.Rows(i)("kitvirtual").ToString
	Numminimodetraccion.Text = dtx.Rows(i)("minimodetraccion").ToString
	Txtmonedacodigo.Text = dtx.Rows(i)("monedacodigo").ToString
	Chkparamvtaboleta.Checked = dtx.Rows(i)("paramvtaboleta").ToString
	Chkparamvtacomisionvendedor.Checked = dtx.Rows(i)("paramvtacomisionvendedor").ToString
	Txtparamvtadesc.Text = dtx.Rows(i)("paramvtadesc").ToString
	Txtparamvtadescor.Text = dtx.Rows(i)("paramvtadescor").ToString
	Numparamvtadescto.Text = dtx.Rows(i)("paramvtadescto").ToString
	Txtparamvtadirec.Text = dtx.Rows(i)("paramvtadirec").ToString
	Chkparamvtaestdesc.Checked = dtx.Rows(i)("paramvtaestdesc").ToString
	Chkparamvtaestigv.Checked = dtx.Rows(i)("paramvtaestigv").ToString
	Txtparamvtafax.Text = dtx.Rows(i)("paramvtafax").ToString
	Chkparamvtaformaemision.Checked = dtx.Rows(i)("paramvtaformaemision").ToString
	Chkparamvtalistaprec.Checked = dtx.Rows(i)("paramvtalistaprec").ToString
	Chkparamvtamasivo.Checked = dtx.Rows(i)("paramvtamasivo").ToString
	Txtparamvtamensaje.Text = dtx.Rows(i)("paramvtamensaje").ToString
	Numparamvtaporcigv.Text = dtx.Rows(i)("paramvtaporcigv").ToString
	Txtparamvtatelefonos.Text = dtx.Rows(i)("paramvtatelefonos").ToString
	Numparamvtatipcambref.Text = dtx.Rows(i)("paramvtatipcambref").ToString
	NumparamvtaValorUit.Text = dtx.Rows(i)("paramvtaValorUit").ToString
	ChkPedidosSinfacturar.Checked = dtx.Rows(i)("PedidosSinfacturar").ToString
	NumPorcentajeCredito.Text = dtx.Rows(i)("PorcentajeCredito").ToString
	ChkRangodePrecios.Checked = dtx.Rows(i)("RangodePrecios").ToString
	Chkstockcomp.Checked = dtx.Rows(i)("stockcomp").ToString
	Chktesoreriaenlinea.Checked = dtx.Rows(i)("tesoreriaenlinea").ToString
	Numtiporedondeocobrar.Text = dtx.Rows(i)("tiporedondeocobrar").ToString
	Txtusuariocodigo.Text = dtx.Rows(i)("usuariocodigo").ToString
	NumventasBM.Text = dtx.Rows(i)("ventasBM").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.vt_parametroventaBL
Dim objBE As New BusinessEntities.vt_parametroventaBE

TRY

	ObjBE.AjustesSolesxDolares=ChkAjustesSolesxDolares.Checked
	ObjBE.almacencodigo=Txtalmacencodigo.Text
	ObjBE.codigotransaccionventa=Txtcodigotransaccionventa.Text
	ObjBE.cuentaIgv=TxtcuentaIgv.Text
	ObjBE.cuentaVtaImporte=TxtcuentaVtaImporte.Text
	ObjBE.cuentaVtaTotDolares=TxtcuentaVtaTotDolares.Text
	ObjBE.cuentaVtaTotSoles=TxtcuentaVtaTotSoles.Text
	ObjBE.empresacodigo=Txtempresacodigo.Text
	ObjBE.FacturacionenlineaContab=ChkFacturacionenlineaContab.Checked
	ObjBE.fechaact=Dtpfechaact.Value
	ObjBE.kitvirtual=Chkkitvirtual.Checked
	ObjBE.minimodetraccion=Numminimodetraccion.Text
	ObjBE.monedacodigo=Txtmonedacodigo.Text
	ObjBE.paramvtaboleta=Chkparamvtaboleta.Checked
	ObjBE.paramvtacomisionvendedor=Chkparamvtacomisionvendedor.Checked
	ObjBE.paramvtadesc=Txtparamvtadesc.Text
	ObjBE.paramvtadescor=Txtparamvtadescor.Text
	ObjBE.paramvtadescto=Numparamvtadescto.Text
	ObjBE.paramvtadirec=Txtparamvtadirec.Text
	ObjBE.paramvtaestdesc=Chkparamvtaestdesc.Checked
	ObjBE.paramvtaestigv=Chkparamvtaestigv.Checked
	ObjBE.paramvtafax=Txtparamvtafax.Text
	ObjBE.paramvtaformaemision=Chkparamvtaformaemision.Checked
	ObjBE.paramvtalistaprec=Chkparamvtalistaprec.Checked
	ObjBE.paramvtamasivo=Chkparamvtamasivo.Checked
	ObjBE.paramvtamensaje=Txtparamvtamensaje.Text
	ObjBE.paramvtaporcigv=Numparamvtaporcigv.Text
	ObjBE.paramvtatelefonos=Txtparamvtatelefonos.Text
	ObjBE.paramvtatipcambref=Numparamvtatipcambref.Text
	ObjBE.paramvtaValorUit=NumparamvtaValorUit.Text
	ObjBE.PedidosSinfacturar=ChkPedidosSinfacturar.Checked
	ObjBE.PorcentajeCredito=NumPorcentajeCredito.Text
	ObjBE.RangodePrecios=ChkRangodePrecios.Checked
	ObjBE.stockcomp=Chkstockcomp.Checked
	ObjBE.tesoreriaenlinea=Chktesoreriaenlinea.Checked
	ObjBE.tiporedondeocobrar=Numtiporedondeocobrar.Text
	ObjBE.usuariocodigo=Txtusuariocodigo.Text
	ObjBE.ventasBM=NumventasBM.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from vt_parametroventa",VgcnxSql)
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

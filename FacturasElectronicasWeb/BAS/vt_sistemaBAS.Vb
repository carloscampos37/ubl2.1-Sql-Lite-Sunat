Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New vt_sistemaBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	ChkAdministratipoPago.Checked = dtx.Rows(i)("AdministratipoPago").ToString
	ChkAdministravuelto.Checked = dtx.Rows(i)("Administravuelto").ToString
	ChkAdmiteNegativos.Checked = dtx.Rows(i)("AdmiteNegativos").ToString
	TxtCarpetaFacturasElectronicas.Text = dtx.Rows(i)("CarpetaFacturasElectronicas").ToString
	TxtCarpetaLibrosElectronicos.Text = dtx.Rows(i)("CarpetaLibrosElectronicos").ToString
	TxtCodigoPetroleo.Text = dtx.Rows(i)("CodigoPetroleo").ToString
	Numcodigosduplicados.Text = dtx.Rows(i)("codigosduplicados").ToString
	ChkConsolidaPtosVtasFE.Checked = dtx.Rows(i)("ConsolidaPtosVtasFE").ToString
	ChkContabilizaFacturacion.Checked = dtx.Rows(i)("ContabilizaFacturacion").ToString
	ChkDefaultClienteEventual.Checked = dtx.Rows(i)("DefaultClienteEventual").ToString
	Numempresaasientosautomaticos.Text = dtx.Rows(i)("empresaasientosautomaticos").ToString
	ChkFacturasElectronicas.Checked = dtx.Rows(i)("FacturasElectronicas").ToString
	Txtfamiliaproyectos.Text = dtx.Rows(i)("familiaproyectos").ToString
	DtpFechadeTrabajo.Value = dtx.Rows(i)("FechadeTrabajo").ToString
	Numgenerapedidotemporal.Text = dtx.Rows(i)("generapedidotemporal").ToString
	Numid.Text = dtx.Rows(i)("id").ToString
	Numimpresionvisual.Text = dtx.Rows(i)("impresionvisual").ToString
	ChkPagosencaja.Checked = dtx.Rows(i)("Pagosencaja").ToString
	NumPedidodelDia.Text = dtx.Rows(i)("PedidodelDia").ToString
	Txtpedidotipovena.Text = dtx.Rows(i)("pedidotipovena").ToString
	ChkPedidotresPasos.Checked = dtx.Rows(i)("PedidotresPasos").ToString
	ChkPreciototalxfraccion.Checked = dtx.Rows(i)("Preciototalxfraccion").ToString
	ChkPuntoVtxCliente.Checked = dtx.Rows(i)("PuntoVtxCliente").ToString
	ChkSaldosxLoteSerie.Checked = dtx.Rows(i)("SaldosxLoteSerie").ToString
	Numtemporalpedidos.Text = dtx.Rows(i)("temporalpedidos").ToString
	Txttipoanaliticocodigo.Text = dtx.Rows(i)("tipoanaliticocodigo").ToString
	ChkUtilidadMinima.Checked = dtx.Rows(i)("UtilidadMinima").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.vt_sistemaBL
Dim objBE As New BusinessEntities.vt_sistemaBE

TRY

	ObjBE.AdministratipoPago=ChkAdministratipoPago.Checked
	ObjBE.Administravuelto=ChkAdministravuelto.Checked
	ObjBE.AdmiteNegativos=ChkAdmiteNegativos.Checked
	ObjBE.CarpetaFacturasElectronicas=TxtCarpetaFacturasElectronicas.Text
	ObjBE.CarpetaLibrosElectronicos=TxtCarpetaLibrosElectronicos.Text
	ObjBE.CodigoPetroleo=TxtCodigoPetroleo.Text
	ObjBE.codigosduplicados=Numcodigosduplicados.Text
	ObjBE.ConsolidaPtosVtasFE=ChkConsolidaPtosVtasFE.Checked
	ObjBE.ContabilizaFacturacion=ChkContabilizaFacturacion.Checked
	ObjBE.DefaultClienteEventual=ChkDefaultClienteEventual.Checked
	ObjBE.empresaasientosautomaticos=Numempresaasientosautomaticos.Text
	ObjBE.FacturasElectronicas=ChkFacturasElectronicas.Checked
	ObjBE.familiaproyectos=Txtfamiliaproyectos.Text
	ObjBE.FechadeTrabajo=DtpFechadeTrabajo.Value
	ObjBE.generapedidotemporal=Numgenerapedidotemporal.Text
	ObjBE.id=Numid.Text
	ObjBE.impresionvisual=Numimpresionvisual.Text
	ObjBE.Pagosencaja=ChkPagosencaja.Checked
	ObjBE.PedidodelDia=NumPedidodelDia.Text
	ObjBE.pedidotipovena=Txtpedidotipovena.Text
	ObjBE.PedidotresPasos=ChkPedidotresPasos.Checked
	ObjBE.Preciototalxfraccion=ChkPreciototalxfraccion.Checked
	ObjBE.PuntoVtxCliente=ChkPuntoVtxCliente.Checked
	ObjBE.SaldosxLoteSerie=ChkSaldosxLoteSerie.Checked
	ObjBE.temporalpedidos=Numtemporalpedidos.Text
	ObjBE.tipoanaliticocodigo=Txttipoanaliticocodigo.Text
	ObjBE.UtilidadMinima=ChkUtilidadMinima.Checked

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from vt_sistema",VgcnxSql)
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

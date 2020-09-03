Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New Listapre1BL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	NumDescuento1.Text = dtx.Rows(i)("Descuento1").ToString
	Txtempresacodigo.Text = dtx.Rows(i)("empresacodigo").ToString
	Txtgrupovtacodigo.Text = dtx.Rows(i)("grupovtacodigo").ToString
	Txtmonedacodigo.Text = dtx.Rows(i)("monedacodigo").ToString
	Txtproductocategoriacodigo.Text = dtx.Rows(i)("productocategoriacodigo").ToString
	Txtproductocodigo.Text = dtx.Rows(i)("productocodigo").ToString
	Txtproductodescrcorta.Text = dtx.Rows(i)("productodescrcorta").ToString
	Txtproductodescripcion.Text = dtx.Rows(i)("productodescripcion").ToString
	Chkproductoestunidreferencia.Checked = dtx.Rows(i)("productoestunidreferencia").ToString
	Txtproductofamiliacodigo.Text = dtx.Rows(i)("productofamiliacodigo").ToString
	Numproductoporcimpto.Text = dtx.Rows(i)("productoporcimpto").ToString
	Numproductoprecvta.Text = dtx.Rows(i)("productoprecvta").ToString
	NumproductoprecvtaEtiqueta03.Text = dtx.Rows(i)("productoprecvtaEtiqueta03").ToString
	NumproductoprecvtaEtiqueta06.Text = dtx.Rows(i)("productoprecvtaEtiqueta06").ToString
	NumproductoprecvtaEtiqueta12.Text = dtx.Rows(i)("productoprecvtaEtiqueta12").ToString
	NumproductoprecvtaMayor.Text = dtx.Rows(i)("productoprecvtaMayor").ToString
	Numproductoprecvtaofi.Text = dtx.Rows(i)("productoprecvtaofi").ToString
	NumproductoprecvtaPresentacion.Text = dtx.Rows(i)("productoprecvtaPresentacion").ToString
	Numproductoprecvtareparto.Text = dtx.Rows(i)("productoprecvtareparto").ToString
	Txtproductotipo.Text = dtx.Rows(i)("productotipo").ToString
	Txtunidadcodigo.Text = dtx.Rows(i)("unidadcodigo").ToString
	Numunidadfactorconv.Text = dtx.Rows(i)("unidadfactorconv").ToString
	Txtunidadreferencial.Text = dtx.Rows(i)("unidadreferencial").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.Listapre1BL
Dim objBE As New BusinessEntities.Listapre1BE

TRY

	ObjBE.Descuento1=NumDescuento1.Text
	ObjBE.empresacodigo=Txtempresacodigo.Text
	ObjBE.grupovtacodigo=Txtgrupovtacodigo.Text
	ObjBE.monedacodigo=Txtmonedacodigo.Text
	ObjBE.productocategoriacodigo=Txtproductocategoriacodigo.Text
	ObjBE.productocodigo=Txtproductocodigo.Text
	ObjBE.productodescrcorta=Txtproductodescrcorta.Text
	ObjBE.productodescripcion=Txtproductodescripcion.Text
	ObjBE.productoestunidreferencia=Chkproductoestunidreferencia.Checked
	ObjBE.productofamiliacodigo=Txtproductofamiliacodigo.Text
	ObjBE.productoporcimpto=Numproductoporcimpto.Text
	ObjBE.productoprecvta=Numproductoprecvta.Text
	ObjBE.productoprecvtaEtiqueta03=NumproductoprecvtaEtiqueta03.Text
	ObjBE.productoprecvtaEtiqueta06=NumproductoprecvtaEtiqueta06.Text
	ObjBE.productoprecvtaEtiqueta12=NumproductoprecvtaEtiqueta12.Text
	ObjBE.productoprecvtaMayor=NumproductoprecvtaMayor.Text
	ObjBE.productoprecvtaofi=Numproductoprecvtaofi.Text
	ObjBE.productoprecvtaPresentacion=NumproductoprecvtaPresentacion.Text
	ObjBE.productoprecvtareparto=Numproductoprecvtareparto.Text
	ObjBE.productotipo=Txtproductotipo.Text
	ObjBE.unidadcodigo=Txtunidadcodigo.Text
	ObjBE.unidadfactorconv=Numunidadfactorconv.Text
	ObjBE.unidadreferencial=Txtunidadreferencial.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from Listapre1",VgcnxSql)
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

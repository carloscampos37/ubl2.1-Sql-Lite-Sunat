Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_DocumentosElectronicosDetItemBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	NumDocumentosElectronicos_id.Text = dtx.Rows(i)("DocumentosElectronicos_id").ToString
	NumDocumentosElectronicosCorrel.Text = dtx.Rows(i)("DocumentosElectronicosCorrel").ToString
	NumDocumentosElectronicosCorrelItem.Text = dtx.Rows(i)("DocumentosElectronicosCorrelItem").ToString
	TxtEmpresaCodigo.Text = dtx.Rows(i)("EmpresaCodigo").ToString
	NumItemDescuento.Text = dtx.Rows(i)("ItemDescuento").ToString
	NumItemExonerado.Text = dtx.Rows(i)("ItemExonerado").ToString
	NumItemGravado.Text = dtx.Rows(i)("ItemGravado").ToString
	NumItemIGV.Text = dtx.Rows(i)("ItemIGV").ToString
	NumItemInafecto.Text = dtx.Rows(i)("ItemInafecto").ToString
	NumItemISC.Text = dtx.Rows(i)("ItemISC").ToString
	NumItemOtros.Text = dtx.Rows(i)("ItemOtros").ToString
	NumItemVenta.Text = dtx.Rows(i)("ItemVenta").ToString
	NumPrecioLista.Text = dtx.Rows(i)("PrecioLista").ToString
	NumPrecioVta.Text = dtx.Rows(i)("PrecioVta").ToString
	NumProductocantidad.Text = dtx.Rows(i)("Productocantidad").ToString
	TxtProductoCodigo.Text = dtx.Rows(i)("ProductoCodigo").ToString
	TxtProductoDescripcion.Text = dtx.Rows(i)("ProductoDescripcion").ToString
	TxtTipodeImpuesto.Text = dtx.Rows(i)("TipodeImpuesto").ToString
	TxtTipodeISC.Text = dtx.Rows(i)("TipodeISC").ToString
	TxtTipodePrecio.Text = dtx.Rows(i)("TipodePrecio").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_DocumentosElectronicosDetItemBL
Dim objBE As New BusinessEntities.FE_DocumentosElectronicosDetItemBE

TRY

	ObjBE.DocumentosElectronicos_id=NumDocumentosElectronicos_id.Text
	ObjBE.DocumentosElectronicosCorrel=NumDocumentosElectronicosCorrel.Text
	ObjBE.DocumentosElectronicosCorrelItem=NumDocumentosElectronicosCorrelItem.Text
	ObjBE.EmpresaCodigo=TxtEmpresaCodigo.Text
	ObjBE.ItemDescuento=NumItemDescuento.Text
	ObjBE.ItemExonerado=NumItemExonerado.Text
	ObjBE.ItemGravado=NumItemGravado.Text
	ObjBE.ItemIGV=NumItemIGV.Text
	ObjBE.ItemInafecto=NumItemInafecto.Text
	ObjBE.ItemISC=NumItemISC.Text
	ObjBE.ItemOtros=NumItemOtros.Text
	ObjBE.ItemVenta=NumItemVenta.Text
	ObjBE.PrecioLista=NumPrecioLista.Text
	ObjBE.PrecioVta=NumPrecioVta.Text
	ObjBE.Productocantidad=NumProductocantidad.Text
	ObjBE.ProductoCodigo=TxtProductoCodigo.Text
	ObjBE.ProductoDescripcion=TxtProductoDescripcion.Text
	ObjBE.TipodeImpuesto=TxtTipodeImpuesto.Text
	ObjBE.TipodeISC=TxtTipodeISC.Text
	ObjBE.TipodePrecio=TxtTipodePrecio.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_DocumentosElectronicosDetItem",VgcnxSql)
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

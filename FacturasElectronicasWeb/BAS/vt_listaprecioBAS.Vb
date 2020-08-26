Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New vt_listaprecioBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	Dtpfechaact.Value = dtx.Rows(i)("fechaact").ToString
	Txtproductocodigo.Text = dtx.Rows(i)("productocodigo").ToString
	Txtproductodescripcion.Text = dtx.Rows(i)("productodescripcion").ToString
	Numproductoprecvta.Text = dtx.Rows(i)("productoprecvta").ToString
	Numproductoprecvtaofi.Text = dtx.Rows(i)("productoprecvtaofi").ToString
	Numproductoprecvtareparto.Text = dtx.Rows(i)("productoprecvtareparto").ToString
	Txtusuariocodigo.Text = dtx.Rows(i)("usuariocodigo").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.vt_listaprecioBL
Dim objBE As New BusinessEntities.vt_listaprecioBE

TRY

	ObjBE.fechaact=Dtpfechaact.Value
	ObjBE.productocodigo=Txtproductocodigo.Text
	ObjBE.productodescripcion=Txtproductodescripcion.Text
	ObjBE.productoprecvta=Numproductoprecvta.Text
	ObjBE.productoprecvtaofi=Numproductoprecvtaofi.Text
	ObjBE.productoprecvtareparto=Numproductoprecvtareparto.Text
	ObjBE.usuariocodigo=Txtusuariocodigo.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from vt_listaprecio",VgcnxSql)
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

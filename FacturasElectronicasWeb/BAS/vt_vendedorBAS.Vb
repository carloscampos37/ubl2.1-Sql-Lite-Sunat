Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New vt_vendedorBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	Chkestadoreg.Checked = dtx.Rows(i)("estadoreg").ToString
	Txtfechaact.Text = dtx.Rows(i)("fechaact").ToString
	Txtusuariocodigo.Text = dtx.Rows(i)("usuariocodigo").ToString
	Txtvendedorcodigo.Text = dtx.Rows(i)("vendedorcodigo").ToString
	Numvendedorcomis1.Text = dtx.Rows(i)("vendedorcomis1").ToString
	Numvendedorcomis2.Text = dtx.Rows(i)("vendedorcomis2").ToString
	Numvendedorcomis3.Text = dtx.Rows(i)("vendedorcomis3").ToString
	Txtvendedordireccion.Text = dtx.Rows(i)("vendedordireccion").ToString
	Txtvendedorle.Text = dtx.Rows(i)("vendedorle").ToString
	Txtvendedornombres.Text = dtx.Rows(i)("vendedornombres").ToString
	Txtvendedorreferencia.Text = dtx.Rows(i)("vendedorreferencia").ToString
	Txtvendedorruc.Text = dtx.Rows(i)("vendedorruc").ToString
	Txtvendedortelefono.Text = dtx.Rows(i)("vendedortelefono").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.vt_vendedorBL
Dim objBE As New BusinessEntities.vt_vendedorBE

TRY

	ObjBE.estadoreg=Chkestadoreg.Checked
	ObjBE.fechaact=Txtfechaact.Text
	ObjBE.usuariocodigo=Txtusuariocodigo.Text
	ObjBE.vendedorcodigo=Txtvendedorcodigo.Text
	ObjBE.vendedorcomis1=Numvendedorcomis1.Text
	ObjBE.vendedorcomis2=Numvendedorcomis2.Text
	ObjBE.vendedorcomis3=Numvendedorcomis3.Text
	ObjBE.vendedordireccion=Txtvendedordireccion.Text
	ObjBE.vendedorle=Txtvendedorle.Text
	ObjBE.vendedornombres=Txtvendedornombres.Text
	ObjBE.vendedorreferencia=Txtvendedorreferencia.Text
	ObjBE.vendedorruc=Txtvendedorruc.Text
	ObjBE.vendedortelefono=Txtvendedortelefono.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from vt_vendedor",VgcnxSql)
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

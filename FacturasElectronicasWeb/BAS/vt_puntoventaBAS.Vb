Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New vt_puntoventaBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	Numadministraproyectos.Text = dtx.Rows(i)("administraproyectos").ToString
	Txtcodigocajavtas.Text = dtx.Rows(i)("codigocajavtas").ToString
	TxtcodigocajavtasDol.Text = dtx.Rows(i)("codigocajavtasDol").ToString
	Txtcodigocajavtassoles.Text = dtx.Rows(i)("codigocajavtassoles").ToString
	Txtdireccioncomercial.Text = dtx.Rows(i)("direccioncomercial").ToString
	Dtpfechaact.Value = dtx.Rows(i)("fechaact").ToString
	Chkpuntovtaautomat.Checked = dtx.Rows(i)("puntovtaautomat").ToString
	Txtpuntovtacodigo.Text = dtx.Rows(i)("puntovtacodigo").ToString
	Txtpuntovtadescripcion.Text = dtx.Rows(i)("puntovtadescripcion").ToString
	Chkpuntovtanotaabono.Checked = dtx.Rows(i)("puntovtanotaabono").ToString
	Chkpuntovtanotacargo.Checked = dtx.Rows(i)("puntovtanotacargo").ToString
	ChkpuntovtanroBoleta.Checked = dtx.Rows(i)("puntovtanroBoleta").ToString
	Chkpuntovtanrofact.Checked = dtx.Rows(i)("puntovtanrofact").ToString
	Chkpuntovtanroguia.Checked = dtx.Rows(i)("puntovtanroguia").ToString
	Chkpuntovtanroguiarem.Checked = dtx.Rows(i)("puntovtanroguiarem").ToString
	Chkpuntovtanropedido.Checked = dtx.Rows(i)("puntovtanropedido").ToString
	ChkpuntovtaNumDocumentos.Checked = dtx.Rows(i)("puntovtaNumDocumentos").ToString
	Chkpuntovtaticket.Checked = dtx.Rows(i)("puntovtaticket").ToString
	ChkpuntovtaventasAuto.Checked = dtx.Rows(i)("puntovtaventasAuto").ToString
	Txtusuariocodigo.Text = dtx.Rows(i)("usuariocodigo").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.vt_puntoventaBL
Dim objBE As New BusinessEntities.vt_puntoventaBE

TRY

	ObjBE.administraproyectos=Numadministraproyectos.Text
	ObjBE.codigocajavtas=Txtcodigocajavtas.Text
	ObjBE.codigocajavtasDol=TxtcodigocajavtasDol.Text
	ObjBE.codigocajavtassoles=Txtcodigocajavtassoles.Text
	ObjBE.direccioncomercial=Txtdireccioncomercial.Text
	ObjBE.fechaact=Dtpfechaact.Value
	ObjBE.puntovtaautomat=Chkpuntovtaautomat.Checked
	ObjBE.puntovtacodigo=Txtpuntovtacodigo.Text
	ObjBE.puntovtadescripcion=Txtpuntovtadescripcion.Text
	ObjBE.puntovtanotaabono=Chkpuntovtanotaabono.Checked
	ObjBE.puntovtanotacargo=Chkpuntovtanotacargo.Checked
	ObjBE.puntovtanroBoleta=ChkpuntovtanroBoleta.Checked
	ObjBE.puntovtanrofact=Chkpuntovtanrofact.Checked
	ObjBE.puntovtanroguia=Chkpuntovtanroguia.Checked
	ObjBE.puntovtanroguiarem=Chkpuntovtanroguiarem.Checked
	ObjBE.puntovtanropedido=Chkpuntovtanropedido.Checked
	ObjBE.puntovtaNumDocumentos=ChkpuntovtaNumDocumentos.Checked
	ObjBE.puntovtaticket=Chkpuntovtaticket.Checked
	ObjBE.puntovtaventasAuto=ChkpuntovtaventasAuto.Checked
	ObjBE.usuariocodigo=Txtusuariocodigo.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from vt_puntoventa",VgcnxSql)
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

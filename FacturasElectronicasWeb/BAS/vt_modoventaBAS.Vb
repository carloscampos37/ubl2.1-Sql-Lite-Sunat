Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New vt_modoventaBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	Txtdocumentocodigo.Text = dtx.Rows(i)("documentocodigo").ToString
	Dtpfechaact.Value = dtx.Rows(i)("fechaact").ToString
	Chkmodovtaactctacte.Checked = dtx.Rows(i)("modovtaactctacte").ToString
	Txtmodovtaalmacen.Text = dtx.Rows(i)("modovtaalmacen").ToString
	Txtmodovtacanje.Text = dtx.Rows(i)("modovtacanje").ToString
	Txtmodovtacodigo.Text = dtx.Rows(i)("modovtacodigo").ToString
	Chkmodovtacontrolcorr.Checked = dtx.Rows(i)("modovtacontrolcorr").ToString
	NummodovtacopiasBO.Text = dtx.Rows(i)("modovtacopiasBO").ToString
	Nummodovtacopiasboleta.Text = dtx.Rows(i)("modovtacopiasboleta").ToString
	Nummodovtacopiasfact.Text = dtx.Rows(i)("modovtacopiasfact").ToString
	Nummodovtacopiasguiarem.Text = dtx.Rows(i)("modovtacopiasguiarem").ToString
	Nummodovtacopiashojatrab.Text = dtx.Rows(i)("modovtacopiashojatrab").ToString
	Nummodovtacopiasticket.Text = dtx.Rows(i)("modovtacopiasticket").ToString
	Chkmodovtacorrguiarem.Checked = dtx.Rows(i)("modovtacorrguiarem").ToString
	Nummodovtacrtlfact.Text = dtx.Rows(i)("modovtacrtlfact").ToString
	Chkmodovtactrlinventario.Checked = dtx.Rows(i)("modovtactrlinventario").ToString
	Txtmodovtadescrcorta.Text = dtx.Rows(i)("modovtadescrcorta").ToString
	Txtmodovtadescripcion.Text = dtx.Rows(i)("modovtadescripcion").ToString
	Txtmodovtadscto.Text = dtx.Rows(i)("modovtadscto").ToString
	Chkmodovtaemiteguia.Checked = dtx.Rows(i)("modovtaemiteguia").ToString
	Chkmodovtaemitehoja.Checked = dtx.Rows(i)("modovtaemitehoja").ToString
	Chkmodovtaimpuestos.Checked = dtx.Rows(i)("modovtaimpuestos").ToString
	Chkmodovtaingcodclie.Checked = dtx.Rows(i)("modovtaingcodclie").ToString
	Chkmodovtaingformapag.Checked = dtx.Rows(i)("modovtaingformapag").ToString
	Chkmodovtaingguiarem.Checked = dtx.Rows(i)("modovtaingguiarem").ToString
	Chkmodovtainghastafact.Checked = dtx.Rows(i)("modovtainghastafact").ToString
	Chkmodovtainghastahoja.Checked = dtx.Rows(i)("modovtainghastahoja").ToString
	Chkmodovtainghojatrab.Checked = dtx.Rows(i)("modovtainghojatrab").ToString
	Chkmodovtaingpedido.Checked = dtx.Rows(i)("modovtaingpedido").ToString
	Nummodovtaitemxdoc.Text = dtx.Rows(i)("modovtaitemxdoc").ToString
	Chkmodovtanumautom.Checked = dtx.Rows(i)("modovtanumautom").ToString
	Chkmodovtasolemitfact.Checked = dtx.Rows(i)("modovtasolemitfact").ToString
	Txtmodovtaunidadmedida.Text = dtx.Rows(i)("modovtaunidadmedida").ToString
	Chkmodovtausafactconv.Checked = dtx.Rows(i)("modovtausafactconv").ToString
	Txtpuntovtacodigo.Text = dtx.Rows(i)("puntovtacodigo").ToString
	Txtusuariocodigo.Text = dtx.Rows(i)("usuariocodigo").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.vt_modoventaBL
Dim objBE As New BusinessEntities.vt_modoventaBE

TRY

	ObjBE.documentocodigo=Txtdocumentocodigo.Text
	ObjBE.fechaact=Dtpfechaact.Value
	ObjBE.modovtaactctacte=Chkmodovtaactctacte.Checked
	ObjBE.modovtaalmacen=Txtmodovtaalmacen.Text
	ObjBE.modovtacanje=Txtmodovtacanje.Text
	ObjBE.modovtacodigo=Txtmodovtacodigo.Text
	ObjBE.modovtacontrolcorr=Chkmodovtacontrolcorr.Checked
	ObjBE.modovtacopiasBO=NummodovtacopiasBO.Text
	ObjBE.modovtacopiasboleta=Nummodovtacopiasboleta.Text
	ObjBE.modovtacopiasfact=Nummodovtacopiasfact.Text
	ObjBE.modovtacopiasguiarem=Nummodovtacopiasguiarem.Text
	ObjBE.modovtacopiashojatrab=Nummodovtacopiashojatrab.Text
	ObjBE.modovtacopiasticket=Nummodovtacopiasticket.Text
	ObjBE.modovtacorrguiarem=Chkmodovtacorrguiarem.Checked
	ObjBE.modovtacrtlfact=Nummodovtacrtlfact.Text
	ObjBE.modovtactrlinventario=Chkmodovtactrlinventario.Checked
	ObjBE.modovtadescrcorta=Txtmodovtadescrcorta.Text
	ObjBE.modovtadescripcion=Txtmodovtadescripcion.Text
	ObjBE.modovtadscto=Txtmodovtadscto.Text
	ObjBE.modovtaemiteguia=Chkmodovtaemiteguia.Checked
	ObjBE.modovtaemitehoja=Chkmodovtaemitehoja.Checked
	ObjBE.modovtaimpuestos=Chkmodovtaimpuestos.Checked
	ObjBE.modovtaingcodclie=Chkmodovtaingcodclie.Checked
	ObjBE.modovtaingformapag=Chkmodovtaingformapag.Checked
	ObjBE.modovtaingguiarem=Chkmodovtaingguiarem.Checked
	ObjBE.modovtainghastafact=Chkmodovtainghastafact.Checked
	ObjBE.modovtainghastahoja=Chkmodovtainghastahoja.Checked
	ObjBE.modovtainghojatrab=Chkmodovtainghojatrab.Checked
	ObjBE.modovtaingpedido=Chkmodovtaingpedido.Checked
	ObjBE.modovtaitemxdoc=Nummodovtaitemxdoc.Text
	ObjBE.modovtanumautom=Chkmodovtanumautom.Checked
	ObjBE.modovtasolemitfact=Chkmodovtasolemitfact.Checked
	ObjBE.modovtaunidadmedida=Txtmodovtaunidadmedida.Text
	ObjBE.modovtausafactconv=Chkmodovtausafactconv.Checked
	ObjBE.puntovtacodigo=Txtpuntovtacodigo.Text
	ObjBE.usuariocodigo=Txtusuariocodigo.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from vt_modoventa",VgcnxSql)
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

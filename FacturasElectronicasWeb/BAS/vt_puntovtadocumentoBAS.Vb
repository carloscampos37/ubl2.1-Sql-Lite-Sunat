Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New vt_puntovtadocumentoBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	Txtdocumentocodigo.Text = dtx.Rows(i)("documentocodigo").ToString
	Txtempresacodigo.Text = dtx.Rows(i)("empresacodigo").ToString
	ChkEstadoAnulado.Checked = dtx.Rows(i)("EstadoAnulado").ToString
	ChkNumeracionAutomatica.Checked = dtx.Rows(i)("NumeracionAutomatica").ToString
	Txtpuntovtacodigo.Text = dtx.Rows(i)("puntovtacodigo").ToString
	Txtpuntovtadoccorr.Text = dtx.Rows(i)("puntovtadoccorr").ToString
	Txtpuntovtadocserie.Text = dtx.Rows(i)("puntovtadocserie").ToString
	Txtpuntovtaguia1.Text = dtx.Rows(i)("puntovtaguia1").ToString
	Txtpuntovtaguia2.Text = dtx.Rows(i)("puntovtaguia2").ToString
	Txtusuariocodigo.Text = dtx.Rows(i)("usuariocodigo").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.vt_puntovtadocumentoBL
Dim objBE As New BusinessEntities.vt_puntovtadocumentoBE

TRY

	ObjBE.documentocodigo=Txtdocumentocodigo.Text
	ObjBE.empresacodigo=Txtempresacodigo.Text
	ObjBE.EstadoAnulado=ChkEstadoAnulado.Checked
	ObjBE.NumeracionAutomatica=ChkNumeracionAutomatica.Checked
	ObjBE.puntovtacodigo=Txtpuntovtacodigo.Text
	ObjBE.puntovtadoccorr=Txtpuntovtadoccorr.Text
	ObjBE.puntovtadocserie=Txtpuntovtadocserie.Text
	ObjBE.puntovtaguia1=Txtpuntovtaguia1.Text
	ObjBE.puntovtaguia2=Txtpuntovtaguia2.Text
	ObjBE.usuariocodigo=Txtusuariocodigo.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from vt_puntovtadocumento",VgcnxSql)
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

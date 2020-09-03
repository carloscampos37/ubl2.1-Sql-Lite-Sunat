Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New VT_DocumentoBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	TxtCodigoSunat.Text = dtx.Rows(i)("CodigoSunat").ToString
	TxtDocumentoCodigo.Text = dtx.Rows(i)("DocumentoCodigo").ToString
	Txtdocumentodescrcorta.Text = dtx.Rows(i)("documentodescrcorta").ToString
	Txtdocumentodescripcion.Text = dtx.Rows(i)("documentodescripcion").ToString
	Chkdocumentoregventas.Checked = dtx.Rows(i)("documentoregventas").ToString
	ChkDocumentoResumenSunat.Checked = dtx.Rows(i)("DocumentoResumenSunat").ToString
	Txtdocumentotipo.Text = dtx.Rows(i)("documentotipo").ToString
	Chkdocumentovalidaruc.Checked = dtx.Rows(i)("documentovalidaruc").ToString
	Dtpfechaact.Value = dtx.Rows(i)("fechaact").ToString
	NumTipoEnvio_Id.Text = dtx.Rows(i)("TipoEnvio_Id").ToString
	Txtusuariocodigo.Text = dtx.Rows(i)("usuariocodigo").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.VT_DocumentoBL
Dim objBE As New BusinessEntities.VT_DocumentoBE

TRY

	ObjBE.CodigoSunat=TxtCodigoSunat.Text
	ObjBE.DocumentoCodigo=TxtDocumentoCodigo.Text
	ObjBE.documentodescrcorta=Txtdocumentodescrcorta.Text
	ObjBE.documentodescripcion=Txtdocumentodescripcion.Text
	ObjBE.documentoregventas=Chkdocumentoregventas.Checked
	ObjBE.DocumentoResumenSunat=ChkDocumentoResumenSunat.Checked
	ObjBE.documentotipo=Txtdocumentotipo.Text
	ObjBE.documentovalidaruc=Chkdocumentovalidaruc.Checked
	ObjBE.fechaact=Dtpfechaact.Value
	ObjBE.TipoEnvio_Id=NumTipoEnvio_Id.Text
	ObjBE.usuariocodigo=Txtusuariocodigo.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from VT_Documento",VgcnxSql)
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

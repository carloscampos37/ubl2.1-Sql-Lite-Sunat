Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_DocumentosFEBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	Txtdocumentocodigo.Text = dtx.Rows(i)("documentocodigo").ToString
	Txtdocumentodescripcion.Text = dtx.Rows(i)("documentodescripcion").ToString
	ChkEstadoAnulado.Checked = dtx.Rows(i)("EstadoAnulado").ToString
	Dtpfechaact.Value = dtx.Rows(i)("fechaact").ToString
	NumTipoEnvio_id.Text = dtx.Rows(i)("TipoEnvio_id").ToString
	Txtusuariocodigo.Text = dtx.Rows(i)("usuariocodigo").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_DocumentosFEBL
Dim objBE As New BusinessEntities.FE_DocumentosFEBE

TRY

	ObjBE.documentocodigo=Txtdocumentocodigo.Text
	ObjBE.documentodescripcion=Txtdocumentodescripcion.Text
	ObjBE.EstadoAnulado=ChkEstadoAnulado.Checked
	ObjBE.fechaact=Dtpfechaact.Value
	ObjBE.TipoEnvio_id=NumTipoEnvio_id.Text
	ObjBE.usuariocodigo=Txtusuariocodigo.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_DocumentosFE",VgcnxSql)
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

Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_TiposMotivoNotasContablesBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	TxtDocumentoCodigo.Text = dtx.Rows(i)("DocumentoCodigo").ToString
	ChkEstadoAnulado.Checked = dtx.Rows(i)("EstadoAnulado").ToString
	TxtTipoMotivoDescripcion.Text = dtx.Rows(i)("TipoMotivoDescripcion").ToString
	TxtTipoMotivoNota.Text = dtx.Rows(i)("TipoMotivoNota").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_TiposMotivoNotasContablesBL
Dim objBE As New BusinessEntities.FE_TiposMotivoNotasContablesBE

TRY

	ObjBE.DocumentoCodigo=TxtDocumentoCodigo.Text
	ObjBE.EstadoAnulado=ChkEstadoAnulado.Checked
	ObjBE.TipoMotivoDescripcion=TxtTipoMotivoDescripcion.Text
	ObjBE.TipoMotivoNota=TxtTipoMotivoNota.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_TiposMotivoNotasContables",VgcnxSql)
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

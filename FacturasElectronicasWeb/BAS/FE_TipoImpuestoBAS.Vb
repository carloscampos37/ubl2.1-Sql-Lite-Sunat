Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_TipoImpuestoBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	ChkEstadoAnulado.Checked = dtx.Rows(i)("EstadoAnulado").ToString
	TxtTipoImpuestoCodigo.Text = dtx.Rows(i)("TipoImpuestoCodigo").ToString
	TxtTipoImpuestoDescripcion.Text = dtx.Rows(i)("TipoImpuestoDescripcion").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_TipoImpuestoBL
Dim objBE As New BusinessEntities.FE_TipoImpuestoBE

TRY

	ObjBE.EstadoAnulado=ChkEstadoAnulado.Checked
	ObjBE.TipoImpuestoCodigo=TxtTipoImpuestoCodigo.Text
	ObjBE.TipoImpuestoDescripcion=TxtTipoImpuestoDescripcion.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_TipoImpuesto",VgcnxSql)
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

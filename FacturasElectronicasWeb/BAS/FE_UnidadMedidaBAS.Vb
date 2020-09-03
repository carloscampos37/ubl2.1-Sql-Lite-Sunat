Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_UnidadMedidaBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	TxtEquivalenciaSunat.Text = dtx.Rows(i)("EquivalenciaSunat").ToString
	ChkEstadoAnulado.Checked = dtx.Rows(i)("EstadoAnulado").ToString
	TxtUnidadDescripcion.Text = dtx.Rows(i)("UnidadDescripcion").ToString
	TxtUnidadMedida_id.Text = dtx.Rows(i)("UnidadMedida_id").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_UnidadMedidaBL
Dim objBE As New BusinessEntities.FE_UnidadMedidaBE

TRY

	ObjBE.EquivalenciaSunat=TxtEquivalenciaSunat.Text
	ObjBE.EstadoAnulado=ChkEstadoAnulado.Checked
	ObjBE.UnidadDescripcion=TxtUnidadDescripcion.Text
	ObjBE.UnidadMedida_id=TxtUnidadMedida_id.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_UnidadMedida",VgcnxSql)
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

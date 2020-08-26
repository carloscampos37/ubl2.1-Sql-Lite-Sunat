Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_TipoOperacionVentasBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	TxtTipoOperacionCodigo.Text = dtx.Rows(i)("TipoOperacionCodigo").ToString
	TxtTipoOperacionDescripcion.Text = dtx.Rows(i)("TipoOperacionDescripcion").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_TipoOperacionVentasBL
Dim objBE As New BusinessEntities.FE_TipoOperacionVentasBE

TRY

	ObjBE.TipoOperacionCodigo=TxtTipoOperacionCodigo.Text
	ObjBE.TipoOperacionDescripcion=TxtTipoOperacionDescripcion.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_TipoOperacionVentas",VgcnxSql)
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

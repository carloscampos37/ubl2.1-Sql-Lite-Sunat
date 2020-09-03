Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_ProductosBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	TxtEmpresaCodigo.Text = dtx.Rows(i)("EmpresaCodigo").ToString
	ChkEstadoAnulado.Checked = dtx.Rows(i)("EstadoAnulado").ToString
	NumPorcentajeIgv.Text = dtx.Rows(i)("PorcentajeIgv").ToString
	NumPrecioVta.Text = dtx.Rows(i)("PrecioVta").ToString
	TxtProductoCodigo.Text = dtx.Rows(i)("ProductoCodigo").ToString
	TxtProductoDescripcion.Text = dtx.Rows(i)("ProductoDescripcion").ToString
	ChkProductoServicios.Checked = dtx.Rows(i)("ProductoServicios").ToString
	TxtUnidadMedida_Id.Text = dtx.Rows(i)("UnidadMedida_Id").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_ProductosBL
Dim objBE As New BusinessEntities.FE_ProductosBE

TRY

	ObjBE.EmpresaCodigo=TxtEmpresaCodigo.Text
	ObjBE.EstadoAnulado=ChkEstadoAnulado.Checked
	ObjBE.PorcentajeIgv=NumPorcentajeIgv.Text
	ObjBE.PrecioVta=NumPrecioVta.Text
	ObjBE.ProductoCodigo=TxtProductoCodigo.Text
	ObjBE.ProductoDescripcion=TxtProductoDescripcion.Text
	ObjBE.ProductoServicios=ChkProductoServicios.Checked
	ObjBE.UnidadMedida_Id=TxtUnidadMedida_Id.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_Productos",VgcnxSql)
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

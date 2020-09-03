Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_EmpresasBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	TxtEmpresaCodigo.Text = dtx.Rows(i)("EmpresaCodigo").ToString
	TxtEmpresaDireccion.Text = dtx.Rows(i)("EmpresaDireccion").ToString
	TxtEmpresaDistrito.Text = dtx.Rows(i)("EmpresaDistrito").ToString
	TxtEmpresaProvincia.Text = dtx.Rows(i)("EmpresaProvincia").ToString
	TxtEmpresaRazonComercial.Text = dtx.Rows(i)("EmpresaRazonComercial").ToString
	TxtEmpresaRazonSocial.Text = dtx.Rows(i)("EmpresaRazonSocial").ToString
	TxtEmpresaRegion.Text = dtx.Rows(i)("EmpresaRegion").ToString
	TxtEmpresaRuc.Text = dtx.Rows(i)("EmpresaRuc").ToString
	TxtEmpresaUrbanizacion.Text = dtx.Rows(i)("EmpresaUrbanizacion").ToString
	ChkEstadoAnulado.Checked = dtx.Rows(i)("EstadoAnulado").ToString
	TxtUbigeo_id.Text = dtx.Rows(i)("Ubigeo_id").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_EmpresasBL
Dim objBE As New BusinessEntities.FE_EmpresasBE

TRY

	ObjBE.EmpresaCodigo=TxtEmpresaCodigo.Text
	ObjBE.EmpresaDireccion=TxtEmpresaDireccion.Text
	ObjBE.EmpresaDistrito=TxtEmpresaDistrito.Text
	ObjBE.EmpresaProvincia=TxtEmpresaProvincia.Text
	ObjBE.EmpresaRazonComercial=TxtEmpresaRazonComercial.Text
	ObjBE.EmpresaRazonSocial=TxtEmpresaRazonSocial.Text
	ObjBE.EmpresaRegion=TxtEmpresaRegion.Text
	ObjBE.EmpresaRuc=TxtEmpresaRuc.Text
	ObjBE.EmpresaUrbanizacion=TxtEmpresaUrbanizacion.Text
	ObjBE.EstadoAnulado=ChkEstadoAnulado.Checked
	ObjBE.Ubigeo_id=TxtUbigeo_id.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_Empresas",VgcnxSql)
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

Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_EstablecimientosBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	TxtAnexoSunat.Text = dtx.Rows(i)("AnexoSunat").ToString
	TxtEmpresaCodigo.Text = dtx.Rows(i)("EmpresaCodigo").ToString
	TxtEstablecimiento_id.Text = dtx.Rows(i)("Establecimiento_id").ToString
	TxtEstablecimientoDescripcion.Text = dtx.Rows(i)("EstablecimientoDescripcion").ToString
	TxtestablecimientoDireccion.Text = dtx.Rows(i)("establecimientoDireccion").ToString
	ChkHabilitadoFactDiaria.Checked = dtx.Rows(i)("HabilitadoFactDiaria").ToString
	ChkHabilitadoFactPreimpresa.Checked = dtx.Rows(i)("HabilitadoFactPreimpresa").ToString
	TxtHostName.Text = dtx.Rows(i)("HostName").ToString
	TxtMicrored_id.Text = dtx.Rows(i)("Microred_id").ToString
	TxtUsuarioCodigo.Text = dtx.Rows(i)("UsuarioCodigo").ToString
	TxtVendedor_id.Text = dtx.Rows(i)("Vendedor_id").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_EstablecimientosBL
Dim objBE As New BusinessEntities.FE_EstablecimientosBE

TRY

	ObjBE.AnexoSunat=TxtAnexoSunat.Text
	ObjBE.EmpresaCodigo=TxtEmpresaCodigo.Text
	ObjBE.Establecimiento_id=TxtEstablecimiento_id.Text
	ObjBE.EstablecimientoDescripcion=TxtEstablecimientoDescripcion.Text
	ObjBE.establecimientoDireccion=TxtestablecimientoDireccion.Text
	ObjBE.HabilitadoFactDiaria=ChkHabilitadoFactDiaria.Checked
	ObjBE.HabilitadoFactPreimpresa=ChkHabilitadoFactPreimpresa.Checked
	ObjBE.HostName=TxtHostName.Text
	ObjBE.Microred_id=TxtMicrored_id.Text
	ObjBE.UsuarioCodigo=TxtUsuarioCodigo.Text
	ObjBE.Vendedor_id=TxtVendedor_id.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_Establecimientos",VgcnxSql)
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

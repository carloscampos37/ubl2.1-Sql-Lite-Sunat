Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_EmpresasDatosAdicionalesBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	ChkCaracteresEspeciales.Checked = dtx.Rows(i)("CaracteresEspeciales").ToString
	TxtCarpetaBajasXml.Text = dtx.Rows(i)("CarpetaBajasXml").ToString
	TxtCarpetaCertificadoDigital.Text = dtx.Rows(i)("CarpetaCertificadoDigital").ToString
	TxtCarpetaEnviosXml.Text = dtx.Rows(i)("CarpetaEnviosXml").ToString
	TxtCarpetaRecepcionBajas.Text = dtx.Rows(i)("CarpetaRecepcionBajas").ToString
	TxtcarpetaRecepcionXml.Text = dtx.Rows(i)("carpetaRecepcionXml").ToString
	TxtEmpresaCodigo.Text = dtx.Rows(i)("EmpresaCodigo").ToString
	TxtEmpresaCorreoelectronico.Text = dtx.Rows(i)("EmpresaCorreoelectronico").ToString
	TxtListaUrlSunat.Text = dtx.Rows(i)("ListaUrlSunat").ToString
	TxtResolucionSunat.Text = dtx.Rows(i)("ResolucionSunat").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_EmpresasDatosAdicionalesBL
Dim objBE As New BusinessEntities.FE_EmpresasDatosAdicionalesBE

TRY

	ObjBE.CaracteresEspeciales=ChkCaracteresEspeciales.Checked
	ObjBE.CarpetaBajasXml=TxtCarpetaBajasXml.Text
	ObjBE.CarpetaCertificadoDigital=TxtCarpetaCertificadoDigital.Text
	ObjBE.CarpetaEnviosXml=TxtCarpetaEnviosXml.Text
	ObjBE.CarpetaRecepcionBajas=TxtCarpetaRecepcionBajas.Text
	ObjBE.carpetaRecepcionXml=TxtcarpetaRecepcionXml.Text
	ObjBE.EmpresaCodigo=TxtEmpresaCodigo.Text
	ObjBE.EmpresaCorreoelectronico=TxtEmpresaCorreoelectronico.Text
	ObjBE.ListaUrlSunat=TxtListaUrlSunat.Text
	ObjBE.ResolucionSunat=TxtResolucionSunat.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_EmpresasDatosAdicionales",VgcnxSql)
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

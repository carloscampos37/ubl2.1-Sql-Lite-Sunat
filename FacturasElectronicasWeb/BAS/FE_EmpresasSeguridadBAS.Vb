Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_EmpresasSeguridadBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	TxtCorreoElectronicoFactelect.Text = dtx.Rows(i)("CorreoElectronicoFactelect").ToString
	TxtEmpresaClaveSol.Text = dtx.Rows(i)("EmpresaClaveSol").ToString
	TxtEmpresaCodigo.Text = dtx.Rows(i)("EmpresaCodigo").ToString
	TxtEmpresaUsuarioSol.Text = dtx.Rows(i)("EmpresaUsuarioSol").ToString
	ChkEstadoAnulado.Checked = dtx.Rows(i)("EstadoAnulado").ToString
	DtpFechaVigenciaCertificado.Value = dtx.Rows(i)("FechaVigenciaCertificado").ToString
	TxtNombreCertificadoDigital.Text = dtx.Rows(i)("NombreCertificadoDigital").ToString
	TxtPasswCertificadoDigital.Text = dtx.Rows(i)("PasswCertificadoDigital").ToString
	TxtPasswCorreoElectronico.Text = dtx.Rows(i)("PasswCorreoElectronico").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_EmpresasSeguridadBL
Dim objBE As New BusinessEntities.FE_EmpresasSeguridadBE

TRY

	ObjBE.CorreoElectronicoFactelect=TxtCorreoElectronicoFactelect.Text
	ObjBE.EmpresaClaveSol=TxtEmpresaClaveSol.Text
	ObjBE.EmpresaCodigo=TxtEmpresaCodigo.Text
	ObjBE.EmpresaUsuarioSol=TxtEmpresaUsuarioSol.Text
	ObjBE.EstadoAnulado=ChkEstadoAnulado.Checked
	ObjBE.FechaVigenciaCertificado=DtpFechaVigenciaCertificado.Value
	ObjBE.NombreCertificadoDigital=TxtNombreCertificadoDigital.Text
	ObjBE.PasswCertificadoDigital=TxtPasswCertificadoDigital.Text
	ObjBE.PasswCorreoElectronico=TxtPasswCorreoElectronico.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_EmpresasSeguridad",VgcnxSql)
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

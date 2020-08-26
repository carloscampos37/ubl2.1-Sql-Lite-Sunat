Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_ControldeEnviosBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	ChkComunicacionbajas.Checked = dtx.Rows(i)("Comunicacionbajas").ToString
	ChkDocumentosElectronicos.Checked = dtx.Rows(i)("DocumentosElectronicos").ToString
	TxtEmpresaCodigo.Text = dtx.Rows(i)("EmpresaCodigo").ToString
	ChkEstadoCierreSunat.Checked = dtx.Rows(i)("EstadoCierreSunat").ToString
	DtpFechaEmision.Value = dtx.Rows(i)("FechaEmision").ToString
	TxtPuntovtaCodigo.Text = dtx.Rows(i)("PuntovtaCodigo").ToString
	ChkResumenDiario.Checked = dtx.Rows(i)("ResumenDiario").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_ControldeEnviosBL
Dim objBE As New BusinessEntities.FE_ControldeEnviosBE

TRY

	ObjBE.Comunicacionbajas=ChkComunicacionbajas.Checked
	ObjBE.DocumentosElectronicos=ChkDocumentosElectronicos.Checked
	ObjBE.EmpresaCodigo=TxtEmpresaCodigo.Text
	ObjBE.EstadoCierreSunat=ChkEstadoCierreSunat.Checked
	ObjBE.FechaEmision=DtpFechaEmision.Value
	ObjBE.PuntovtaCodigo=TxtPuntovtaCodigo.Text
	ObjBE.ResumenDiario=ChkResumenDiario.Checked

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_ControldeEnvios",VgcnxSql)
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

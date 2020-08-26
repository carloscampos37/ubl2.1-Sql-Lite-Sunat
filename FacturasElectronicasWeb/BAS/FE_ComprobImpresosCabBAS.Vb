Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_ComprobImpresosCabBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	NumComprobImpreso_Id.Text = dtx.Rows(i)("ComprobImpreso_Id").ToString
	TxtEmpresaCodigo.Text = dtx.Rows(i)("EmpresaCodigo").ToString
	ChkEnvioSedePrincipal.Checked = dtx.Rows(i)("EnvioSedePrincipal").ToString
	TxtEstablecimiento_id.Text = dtx.Rows(i)("Establecimiento_id").ToString
	ChkEstadoAnulado.Checked = dtx.Rows(i)("EstadoAnulado").ToString
	DtpFechaAct.Value = dtx.Rows(i)("FechaAct").ToString
	DtpFechaDocumento.Value = dtx.Rows(i)("FechaDocumento").ToString
	TxtHostName.Text = dtx.Rows(i)("HostName").ToString
	TxtIdentificadorEnvio.Text = dtx.Rows(i)("IdentificadorEnvio").ToString
	NumMotivoContigencia.Text = dtx.Rows(i)("MotivoContigencia").ToString
	NumPedido_id.Text = dtx.Rows(i)("Pedido_id").ToString
	TxtUsuarioCodigo.Text = dtx.Rows(i)("UsuarioCodigo").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_ComprobImpresosCabBL
Dim objBE As New BusinessEntities.FE_ComprobImpresosCabBE

TRY

	ObjBE.ComprobImpreso_Id=NumComprobImpreso_Id.Text
	ObjBE.EmpresaCodigo=TxtEmpresaCodigo.Text
	ObjBE.EnvioSedePrincipal=ChkEnvioSedePrincipal.Checked
	ObjBE.Establecimiento_id=TxtEstablecimiento_id.Text
	ObjBE.EstadoAnulado=ChkEstadoAnulado.Checked
	ObjBE.FechaAct=DtpFechaAct.Value
	ObjBE.FechaDocumento=DtpFechaDocumento.Value
	ObjBE.HostName=TxtHostName.Text
	ObjBE.IdentificadorEnvio=TxtIdentificadorEnvio.Text
	ObjBE.MotivoContigencia=NumMotivoContigencia.Text
	ObjBE.Pedido_id=NumPedido_id.Text
	ObjBE.UsuarioCodigo=TxtUsuarioCodigo.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_ComprobImpresosCab",VgcnxSql)
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

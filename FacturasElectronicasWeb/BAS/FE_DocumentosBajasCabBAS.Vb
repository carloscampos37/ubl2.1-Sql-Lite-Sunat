Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_DocumentosBajasCabBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	NumDocumentosBajas_Id.Text = dtx.Rows(i)("DocumentosBajas_Id").ToString
	TxtEmpresaCodigo.Text = dtx.Rows(i)("EmpresaCodigo").ToString
	ChkEnvioSedePrincipal.Checked = dtx.Rows(i)("EnvioSedePrincipal").ToString
	TxtEstablecimiento_id.Text = dtx.Rows(i)("Establecimiento_id").ToString
	ChkEstadoAnulado.Checked = dtx.Rows(i)("EstadoAnulado").ToString
	DtpfechaAct.Value = dtx.Rows(i)("fechaAct").ToString
	DtpFechaDocumento.Value = dtx.Rows(i)("FechaDocumento").ToString
	DtpFechaEnvio.Value = dtx.Rows(i)("FechaEnvio").ToString
	TxtHostName.Text = dtx.Rows(i)("HostName").ToString
	TxtIdentificadorEnvio.Text = dtx.Rows(i)("IdentificadorEnvio").ToString
	NumPedido_id.Text = dtx.Rows(i)("Pedido_id").ToString
	TxtusuarioCodigo.Text = dtx.Rows(i)("usuarioCodigo").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_DocumentosBajasCabBL
Dim objBE As New BusinessEntities.FE_DocumentosBajasCabBE

TRY

	ObjBE.DocumentosBajas_Id=NumDocumentosBajas_Id.Text
	ObjBE.EmpresaCodigo=TxtEmpresaCodigo.Text
	ObjBE.EnvioSedePrincipal=ChkEnvioSedePrincipal.Checked
	ObjBE.Establecimiento_id=TxtEstablecimiento_id.Text
	ObjBE.EstadoAnulado=ChkEstadoAnulado.Checked
	ObjBE.fechaAct=DtpfechaAct.Value
	ObjBE.FechaDocumento=DtpFechaDocumento.Value
	ObjBE.FechaEnvio=DtpFechaEnvio.Value
	ObjBE.HostName=TxtHostName.Text
	ObjBE.IdentificadorEnvio=TxtIdentificadorEnvio.Text
	ObjBE.Pedido_id=NumPedido_id.Text
	ObjBE.usuarioCodigo=TxtusuarioCodigo.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_DocumentosBajasCab",VgcnxSql)
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

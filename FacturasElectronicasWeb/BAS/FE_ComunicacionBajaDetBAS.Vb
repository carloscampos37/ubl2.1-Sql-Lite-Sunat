Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_ComunicacionBajaDetBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	TxtClienteRazonSocial.Text = dtx.Rows(i)("ClienteRazonSocial").ToString
	TxtclienteRuc.Text = dtx.Rows(i)("clienteRuc").ToString
	NumComunicacionBaja_id.Text = dtx.Rows(i)("ComunicacionBaja_id").ToString
	NumComunicacionbajaItem.Text = dtx.Rows(i)("ComunicacionbajaItem").ToString
	NumCorrelativoEnvio.Text = dtx.Rows(i)("CorrelativoEnvio").ToString
	TxtEmpresaCodigo.Text = dtx.Rows(i)("EmpresaCodigo").ToString
	DtpFechaAct.Value = dtx.Rows(i)("FechaAct").ToString
	TxtMotivoBaja_id.Text = dtx.Rows(i)("MotivoBaja_id").ToString
	TxtNumeroDocumento.Text = dtx.Rows(i)("NumeroDocumento").ToString
	TxtSerieDocumento.Text = dtx.Rows(i)("SerieDocumento").ToString
	TxtTipoDocumento.Text = dtx.Rows(i)("TipoDocumento").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_ComunicacionBajaDetBL
Dim objBE As New BusinessEntities.FE_ComunicacionBajaDetBE

TRY

	ObjBE.ClienteRazonSocial=TxtClienteRazonSocial.Text
	ObjBE.clienteRuc=TxtclienteRuc.Text
	ObjBE.ComunicacionBaja_id=NumComunicacionBaja_id.Text
	ObjBE.ComunicacionbajaItem=NumComunicacionbajaItem.Text
	ObjBE.CorrelativoEnvio=NumCorrelativoEnvio.Text
	ObjBE.EmpresaCodigo=TxtEmpresaCodigo.Text
	ObjBE.FechaAct=DtpFechaAct.Value
	ObjBE.MotivoBaja_id=TxtMotivoBaja_id.Text
	ObjBE.NumeroDocumento=TxtNumeroDocumento.Text
	ObjBE.SerieDocumento=TxtSerieDocumento.Text
	ObjBE.TipoDocumento=TxtTipoDocumento.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_ComunicacionBajaDet",VgcnxSql)
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

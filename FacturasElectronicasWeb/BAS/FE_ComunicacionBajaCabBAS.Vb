Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_ComunicacionBajaCabBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	TxtArchivoXmlAceptado.Text = dtx.Rows(i)("ArchivoXmlAceptado").ToString
	NumComunicacionBaja_id.Text = dtx.Rows(i)("ComunicacionBaja_id").ToString
	TxtEmpresaCodigo.Text = dtx.Rows(i)("EmpresaCodigo").ToString
	TxtEstablecimiento_id.Text = dtx.Rows(i)("Establecimiento_id").ToString
	NumEstadoEnvioSunat_id.Text = dtx.Rows(i)("EstadoEnvioSunat_id").ToString
	DtpFechaAct.Value = dtx.Rows(i)("FechaAct").ToString
	DtpFechadeBaja.Value = dtx.Rows(i)("FechadeBaja").ToString
	DtpFechaEnvio.Value = dtx.Rows(i)("FechaEnvio").ToString
	TxtIdentificadorEnvio.Text = dtx.Rows(i)("IdentificadorEnvio").ToString
	TxtMensajeRecepcion.Text = dtx.Rows(i)("MensajeRecepcion").ToString
	NumNroDocumentos.Text = dtx.Rows(i)("NroDocumentos").ToString
	TxtNumerodeAceptacion.Text = dtx.Rows(i)("NumerodeAceptacion").ToString
	TxtUsuariocodigo.Text = dtx.Rows(i)("Usuariocodigo").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_ComunicacionBajaCabBL
Dim objBE As New BusinessEntities.FE_ComunicacionBajaCabBE

TRY

	ObjBE.ArchivoXmlAceptado=TxtArchivoXmlAceptado.Text
	ObjBE.ComunicacionBaja_id=NumComunicacionBaja_id.Text
	ObjBE.EmpresaCodigo=TxtEmpresaCodigo.Text
	ObjBE.Establecimiento_id=TxtEstablecimiento_id.Text
	ObjBE.EstadoEnvioSunat_id=NumEstadoEnvioSunat_id.Text
	ObjBE.FechaAct=DtpFechaAct.Value
	ObjBE.FechadeBaja=DtpFechadeBaja.Value
	ObjBE.FechaEnvio=DtpFechaEnvio.Value
	ObjBE.IdentificadorEnvio=TxtIdentificadorEnvio.Text
	ObjBE.MensajeRecepcion=TxtMensajeRecepcion.Text
	ObjBE.NroDocumentos=NumNroDocumentos.Text
	ObjBE.NumerodeAceptacion=TxtNumerodeAceptacion.Text
	ObjBE.Usuariocodigo=TxtUsuariocodigo.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_ComunicacionBajaCab",VgcnxSql)
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

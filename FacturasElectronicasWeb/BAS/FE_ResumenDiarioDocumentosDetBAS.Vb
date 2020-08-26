Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_ResumenDiarioDocumentosDetBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	TxtArchivoXmlAceptado.Text = dtx.Rows(i)("ArchivoXmlAceptado").ToString
	TxtEmpresaCodigo.Text = dtx.Rows(i)("EmpresaCodigo").ToString
	ChkEstadoAnulado.Checked = dtx.Rows(i)("EstadoAnulado").ToString
	NumEstadoEnvioSunat_id.Text = dtx.Rows(i)("EstadoEnvioSunat_id").ToString
	NumGrupodeEnvioSunat.Text = dtx.Rows(i)("GrupodeEnvioSunat").ToString
	TxtMensajeRecepcion.Text = dtx.Rows(i)("MensajeRecepcion").ToString
	TxtMonedaCodigo.Text = dtx.Rows(i)("MonedaCodigo").ToString
	TxtNumerodeAceptacion.Text = dtx.Rows(i)("NumerodeAceptacion").ToString
	NumNumerodeDocumentos.Text = dtx.Rows(i)("NumerodeDocumentos").ToString
	NumNumeroDocumento.Text = dtx.Rows(i)("NumeroDocumento").ToString
	NumNumeroDocumentoFinal.Text = dtx.Rows(i)("NumeroDocumentoFinal").ToString
	NumResumendiario_id.Text = dtx.Rows(i)("Resumendiario_id").ToString
	NumResumendiarioCorrel.Text = dtx.Rows(i)("ResumendiarioCorrel").ToString
	TxtSerieDocumento.Text = dtx.Rows(i)("SerieDocumento").ToString
	TxtTipoDocumento.Text = dtx.Rows(i)("TipoDocumento").ToString
	NumTotalImporteDsctoGlobal.Text = dtx.Rows(i)("TotalImporteDsctoGlobal").ToString
	NumTotalImporteExonerado.Text = dtx.Rows(i)("TotalImporteExonerado").ToString
	NumTotalImporteGravado.Text = dtx.Rows(i)("TotalImporteGravado").ToString
	NumTotalImporteIGV.Text = dtx.Rows(i)("TotalImporteIGV").ToString
	NumTotalImporteInafecto.Text = dtx.Rows(i)("TotalImporteInafecto").ToString
	NumTotalImporteVenta.Text = dtx.Rows(i)("TotalImporteVenta").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_ResumenDiarioDocumentosDetBL
Dim objBE As New BusinessEntities.FE_ResumenDiarioDocumentosDetBE

TRY

	ObjBE.ArchivoXmlAceptado=TxtArchivoXmlAceptado.Text
	ObjBE.EmpresaCodigo=TxtEmpresaCodigo.Text
	ObjBE.EstadoAnulado=ChkEstadoAnulado.Checked
	ObjBE.EstadoEnvioSunat_id=NumEstadoEnvioSunat_id.Text
	ObjBE.GrupodeEnvioSunat=NumGrupodeEnvioSunat.Text
	ObjBE.MensajeRecepcion=TxtMensajeRecepcion.Text
	ObjBE.MonedaCodigo=TxtMonedaCodigo.Text
	ObjBE.NumerodeAceptacion=TxtNumerodeAceptacion.Text
	ObjBE.NumerodeDocumentos=NumNumerodeDocumentos.Text
	ObjBE.NumeroDocumento=NumNumeroDocumento.Text
	ObjBE.NumeroDocumentoFinal=NumNumeroDocumentoFinal.Text
	ObjBE.Resumendiario_id=NumResumendiario_id.Text
	ObjBE.ResumendiarioCorrel=NumResumendiarioCorrel.Text
	ObjBE.SerieDocumento=TxtSerieDocumento.Text
	ObjBE.TipoDocumento=TxtTipoDocumento.Text
	ObjBE.TotalImporteDsctoGlobal=NumTotalImporteDsctoGlobal.Text
	ObjBE.TotalImporteExonerado=NumTotalImporteExonerado.Text
	ObjBE.TotalImporteGravado=NumTotalImporteGravado.Text
	ObjBE.TotalImporteIGV=NumTotalImporteIGV.Text
	ObjBE.TotalImporteInafecto=NumTotalImporteInafecto.Text
	ObjBE.TotalImporteVenta=NumTotalImporteVenta.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_ResumenDiarioDocumentosDet",VgcnxSql)
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

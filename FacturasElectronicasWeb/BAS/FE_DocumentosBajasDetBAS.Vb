Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_DocumentosBajasDetBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	TxtClienteCodigo.Text = dtx.Rows(i)("ClienteCodigo").ToString
	TxtClienteRazonSocial.Text = dtx.Rows(i)("ClienteRazonSocial").ToString
	TxtDescripcionMotivoNota.Text = dtx.Rows(i)("DescripcionMotivoNota").ToString
	NumDocumentosBajas_Id.Text = dtx.Rows(i)("DocumentosBajas_Id").ToString
	NumDocumentosBajasCorrel.Text = dtx.Rows(i)("DocumentosBajasCorrel").ToString
	TxtEmpresaCodigo.Text = dtx.Rows(i)("EmpresaCodigo").ToString
	ChkEnvioSedePrincipal.Checked = dtx.Rows(i)("EnvioSedePrincipal").ToString
	ChkEstadoAnulado.Checked = dtx.Rows(i)("EstadoAnulado").ToString
	NumEstadoEnvioSunat_id.Text = dtx.Rows(i)("EstadoEnvioSunat_id").ToString
	NumIdentidadcodigo.Text = dtx.Rows(i)("Identidadcodigo").ToString
	TxtMonedaCodigo.Text = dtx.Rows(i)("MonedaCodigo").ToString
	TxtNumerodeAceptacion.Text = dtx.Rows(i)("NumerodeAceptacion").ToString
	NumNumeroDocumento.Text = dtx.Rows(i)("NumeroDocumento").ToString
	NumNumeroDocumentoFinal.Text = dtx.Rows(i)("NumeroDocumentoFinal").ToString
	TxtNumeroDocumentoModifica.Text = dtx.Rows(i)("NumeroDocumentoModifica").ToString
	NumPorcentajeIsc.Text = dtx.Rows(i)("PorcentajeIsc").ToString
	TxtSerieDocumento.Text = dtx.Rows(i)("SerieDocumento").ToString
	TxtSerieDocumentoModifica.Text = dtx.Rows(i)("SerieDocumentoModifica").ToString
	TxtTipoDocumento.Text = dtx.Rows(i)("TipoDocumento").ToString
	TxtTipoDocumentoModifica.Text = dtx.Rows(i)("TipoDocumentoModifica").ToString
	TxtTipoMotivoNota.Text = dtx.Rows(i)("TipoMotivoNota").ToString
	NumTotalImporteDsctoGlobal.Text = dtx.Rows(i)("TotalImporteDsctoGlobal").ToString
	NumTotalImporteDsctoItem.Text = dtx.Rows(i)("TotalImporteDsctoItem").ToString
	NumTotalImporteExonerado.Text = dtx.Rows(i)("TotalImporteExonerado").ToString
	NumTotalImporteGratuitas.Text = dtx.Rows(i)("TotalImporteGratuitas").ToString
	NumTotalImporteGravado.Text = dtx.Rows(i)("TotalImporteGravado").ToString
	NumTotalImporteIGV.Text = dtx.Rows(i)("TotalImporteIGV").ToString
	NumTotalImporteInafecto.Text = dtx.Rows(i)("TotalImporteInafecto").ToString
	NumTotalImporteISC.Text = dtx.Rows(i)("TotalImporteISC").ToString
	NumTotalImporteOtros.Text = dtx.Rows(i)("TotalImporteOtros").ToString
	NumTotalImporteVenta.Text = dtx.Rows(i)("TotalImporteVenta").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_DocumentosBajasDetBL
Dim objBE As New BusinessEntities.FE_DocumentosBajasDetBE

TRY

	ObjBE.ClienteCodigo=TxtClienteCodigo.Text
	ObjBE.ClienteRazonSocial=TxtClienteRazonSocial.Text
	ObjBE.DescripcionMotivoNota=TxtDescripcionMotivoNota.Text
	ObjBE.DocumentosBajas_Id=NumDocumentosBajas_Id.Text
	ObjBE.DocumentosBajasCorrel=NumDocumentosBajasCorrel.Text
	ObjBE.EmpresaCodigo=TxtEmpresaCodigo.Text
	ObjBE.EnvioSedePrincipal=ChkEnvioSedePrincipal.Checked
	ObjBE.EstadoAnulado=ChkEstadoAnulado.Checked
	ObjBE.EstadoEnvioSunat_id=NumEstadoEnvioSunat_id.Text
	ObjBE.Identidadcodigo=NumIdentidadcodigo.Text
	ObjBE.MonedaCodigo=TxtMonedaCodigo.Text
	ObjBE.NumerodeAceptacion=TxtNumerodeAceptacion.Text
	ObjBE.NumeroDocumento=NumNumeroDocumento.Text
	ObjBE.NumeroDocumentoFinal=NumNumeroDocumentoFinal.Text
	ObjBE.NumeroDocumentoModifica=TxtNumeroDocumentoModifica.Text
	ObjBE.PorcentajeIsc=NumPorcentajeIsc.Text
	ObjBE.SerieDocumento=TxtSerieDocumento.Text
	ObjBE.SerieDocumentoModifica=TxtSerieDocumentoModifica.Text
	ObjBE.TipoDocumento=TxtTipoDocumento.Text
	ObjBE.TipoDocumentoModifica=TxtTipoDocumentoModifica.Text
	ObjBE.TipoMotivoNota=TxtTipoMotivoNota.Text
	ObjBE.TotalImporteDsctoGlobal=NumTotalImporteDsctoGlobal.Text
	ObjBE.TotalImporteDsctoItem=NumTotalImporteDsctoItem.Text
	ObjBE.TotalImporteExonerado=NumTotalImporteExonerado.Text
	ObjBE.TotalImporteGratuitas=NumTotalImporteGratuitas.Text
	ObjBE.TotalImporteGravado=NumTotalImporteGravado.Text
	ObjBE.TotalImporteIGV=NumTotalImporteIGV.Text
	ObjBE.TotalImporteInafecto=NumTotalImporteInafecto.Text
	ObjBE.TotalImporteISC=NumTotalImporteISC.Text
	ObjBE.TotalImporteOtros=NumTotalImporteOtros.Text
	ObjBE.TotalImporteVenta=NumTotalImporteVenta.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_DocumentosBajasDet",VgcnxSql)
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

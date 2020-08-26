Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_ComprobImpresosDetBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	NumComprobImpreso_id.Text = dtx.Rows(i)("ComprobImpreso_id").ToString
	NumComprobImpresoCorrel.Text = dtx.Rows(i)("ComprobImpresoCorrel").ToString
	TxtEmpresaCodigo.Text = dtx.Rows(i)("EmpresaCodigo").ToString
	NumEstadoEnvioSunat_id.Text = dtx.Rows(i)("EstadoEnvioSunat_id").ToString
	TxtMonedaCodigo.Text = dtx.Rows(i)("MonedaCodigo").ToString
	TxtNumerodeAceptacion.Text = dtx.Rows(i)("NumerodeAceptacion").ToString
	NumNumerodeDocumentos.Text = dtx.Rows(i)("NumerodeDocumentos").ToString
	NumNumeroDocumento.Text = dtx.Rows(i)("NumeroDocumento").ToString
	NumNumeroDocumentoFinal.Text = dtx.Rows(i)("NumeroDocumentoFinal").ToString
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
Dim objBL As New BusinessLogic.FE_ComprobImpresosDetBL
Dim objBE As New BusinessEntities.FE_ComprobImpresosDetBE

TRY

	ObjBE.ComprobImpreso_id=NumComprobImpreso_id.Text
	ObjBE.ComprobImpresoCorrel=NumComprobImpresoCorrel.Text
	ObjBE.EmpresaCodigo=TxtEmpresaCodigo.Text
	ObjBE.EstadoEnvioSunat_id=NumEstadoEnvioSunat_id.Text
	ObjBE.MonedaCodigo=TxtMonedaCodigo.Text
	ObjBE.NumerodeAceptacion=TxtNumerodeAceptacion.Text
	ObjBE.NumerodeDocumentos=NumNumerodeDocumentos.Text
	ObjBE.NumeroDocumento=NumNumeroDocumento.Text
	ObjBE.NumeroDocumentoFinal=NumNumeroDocumentoFinal.Text
	ObjBE.SerieDocumento=TxtSerieDocumento.Text
	ObjBE.TipoDocumento=TxtTipoDocumento.Text
	ObjBE.TotalImporteDsctoGlobal=NumTotalImporteDsctoGlobal.Text
	ObjBE.TotalImporteExonerado=NumTotalImporteExonerado.Text
	ObjBE.TotalImporteGravado=NumTotalImporteGravado.Text
	ObjBE.TotalImporteIGV=NumTotalImporteIGV.Text
	ObjBE.TotalImporteInafecto=NumTotalImporteInafecto.Text
	ObjBE.TotalImporteVenta=NumTotalImporteVenta.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_ComprobImpresosDet",VgcnxSql)
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

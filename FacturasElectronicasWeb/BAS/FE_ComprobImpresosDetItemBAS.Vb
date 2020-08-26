Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_ComprobImpresosDetItemBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	TxtClienteCodigo.Text = dtx.Rows(i)("ClienteCodigo").ToString
	TxtClienteRazonSocial.Text = dtx.Rows(i)("ClienteRazonSocial").ToString
	NumComprobImpreso_Id.Text = dtx.Rows(i)("ComprobImpreso_Id").ToString
	NumComprobImpresoCorrel.Text = dtx.Rows(i)("ComprobImpresoCorrel").ToString
	NumComprobImpresoCorrelItem.Text = dtx.Rows(i)("ComprobImpresoCorrelItem").ToString
	TxtEmpresaCodigo.Text = dtx.Rows(i)("EmpresaCodigo").ToString
	ChkEstadoAnulado.Checked = dtx.Rows(i)("EstadoAnulado").ToString
	NumEstadoEnvioSunat_id.Text = dtx.Rows(i)("EstadoEnvioSunat_id").ToString
	NumIdentidadCodigo.Text = dtx.Rows(i)("IdentidadCodigo").ToString
	TxtMonedaCodigo.Text = dtx.Rows(i)("MonedaCodigo").ToString
	NumNumeroDocumento.Text = dtx.Rows(i)("NumeroDocumento").ToString
	NumNumeroDocumentoFinal.Text = dtx.Rows(i)("NumeroDocumentoFinal").ToString
	TxtNumeroDocumentoModifica.Text = dtx.Rows(i)("NumeroDocumentoModifica").ToString
	TxtSerieDocumento.Text = dtx.Rows(i)("SerieDocumento").ToString
	TxtSerieDocumentoModifica.Text = dtx.Rows(i)("SerieDocumentoModifica").ToString
	TxtTipoDocumento.Text = dtx.Rows(i)("TipoDocumento").ToString
	TxtTipoDocumentoModifica.Text = dtx.Rows(i)("TipoDocumentoModifica").ToString
	NumTotalImporteExonerado.Text = dtx.Rows(i)("TotalImporteExonerado").ToString
	NumTotalImporteGravado.Text = dtx.Rows(i)("TotalImporteGravado").ToString
	NumtotalImporteIGV.Text = dtx.Rows(i)("totalImporteIGV").ToString
	NumTotalImporteInafecto.Text = dtx.Rows(i)("TotalImporteInafecto").ToString
	NumTotalImporteISC.Text = dtx.Rows(i)("TotalImporteISC").ToString
	NumTotalImporteOtros.Text = dtx.Rows(i)("TotalImporteOtros").ToString
	NumTotalImporteVenta.Text = dtx.Rows(i)("TotalImporteVenta").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_ComprobImpresosDetItemBL
Dim objBE As New BusinessEntities.FE_ComprobImpresosDetItemBE

TRY

	ObjBE.ClienteCodigo=TxtClienteCodigo.Text
	ObjBE.ClienteRazonSocial=TxtClienteRazonSocial.Text
	ObjBE.ComprobImpreso_Id=NumComprobImpreso_Id.Text
	ObjBE.ComprobImpresoCorrel=NumComprobImpresoCorrel.Text
	ObjBE.ComprobImpresoCorrelItem=NumComprobImpresoCorrelItem.Text
	ObjBE.EmpresaCodigo=TxtEmpresaCodigo.Text
	ObjBE.EstadoAnulado=ChkEstadoAnulado.Checked
	ObjBE.EstadoEnvioSunat_id=NumEstadoEnvioSunat_id.Text
	ObjBE.IdentidadCodigo=NumIdentidadCodigo.Text
	ObjBE.MonedaCodigo=TxtMonedaCodigo.Text
	ObjBE.NumeroDocumento=NumNumeroDocumento.Text
	ObjBE.NumeroDocumentoFinal=NumNumeroDocumentoFinal.Text
	ObjBE.NumeroDocumentoModifica=TxtNumeroDocumentoModifica.Text
	ObjBE.SerieDocumento=TxtSerieDocumento.Text
	ObjBE.SerieDocumentoModifica=TxtSerieDocumentoModifica.Text
	ObjBE.TipoDocumento=TxtTipoDocumento.Text
	ObjBE.TipoDocumentoModifica=TxtTipoDocumentoModifica.Text
	ObjBE.TotalImporteExonerado=NumTotalImporteExonerado.Text
	ObjBE.TotalImporteGravado=NumTotalImporteGravado.Text
	ObjBE.totalImporteIGV=NumtotalImporteIGV.Text
	ObjBE.TotalImporteInafecto=NumTotalImporteInafecto.Text
	ObjBE.TotalImporteISC=NumTotalImporteISC.Text
	ObjBE.TotalImporteOtros=NumTotalImporteOtros.Text
	ObjBE.TotalImporteVenta=NumTotalImporteVenta.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_ComprobImpresosDetItem",VgcnxSql)
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

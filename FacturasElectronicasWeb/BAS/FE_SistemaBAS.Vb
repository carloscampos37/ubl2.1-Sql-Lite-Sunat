Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_SistemaBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	NumCorrelativoComprobImpreso.Text = dtx.Rows(i)("CorrelativoComprobImpreso").ToString
	NumCorrelativoComunicacionBaja.Text = dtx.Rows(i)("CorrelativoComunicacionBaja").ToString
	NumCorrrelativodocumentoelectronico.Text = dtx.Rows(i)("Corrrelativodocumentoelectronico").ToString
	NumCorrrelativoResumenDiario.Text = dtx.Rows(i)("CorrrelativoResumenDiario").ToString
	TxtEmpresacodigo.Text = dtx.Rows(i)("Empresacodigo").ToString
	ChkEsquemaInafecto.Checked = dtx.Rows(i)("EsquemaInafecto").ToString
	DtpFechaAct.Value = dtx.Rows(i)("FechaAct").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_SistemaBL
Dim objBE As New BusinessEntities.FE_SistemaBE

TRY

	ObjBE.CorrelativoComprobImpreso=NumCorrelativoComprobImpreso.Text
	ObjBE.CorrelativoComunicacionBaja=NumCorrelativoComunicacionBaja.Text
	ObjBE.Corrrelativodocumentoelectronico=NumCorrrelativodocumentoelectronico.Text
	ObjBE.CorrrelativoResumenDiario=NumCorrrelativoResumenDiario.Text
	ObjBE.Empresacodigo=TxtEmpresacodigo.Text
	ObjBE.EsquemaInafecto=ChkEsquemaInafecto.Checked
	ObjBE.FechaAct=DtpFechaAct.Value

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_Sistema",VgcnxSql)
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

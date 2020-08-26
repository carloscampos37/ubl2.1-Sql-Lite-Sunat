Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_ParametrosBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	ChkCodigoProductoUnico.Checked = dtx.Rows(i)("CodigoProductoUnico").ToString
	ChkConsolidaPtosVtasFE.Checked = dtx.Rows(i)("ConsolidaPtosVtasFE").ToString
	TxtEmpresaCodigo.Text = dtx.Rows(i)("EmpresaCodigo").ToString
	NumImporteMinimoDni.Text = dtx.Rows(i)("ImporteMinimoDni").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_ParametrosBL
Dim objBE As New BusinessEntities.FE_ParametrosBE

TRY

	ObjBE.CodigoProductoUnico=ChkCodigoProductoUnico.Checked
	ObjBE.ConsolidaPtosVtasFE=ChkConsolidaPtosVtasFE.Checked
	ObjBE.EmpresaCodigo=TxtEmpresaCodigo.Text
	ObjBE.ImporteMinimoDni=NumImporteMinimoDni.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_Parametros",VgcnxSql)
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

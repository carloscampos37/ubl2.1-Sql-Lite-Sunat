Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New Fe_EstadosdeEnvioSunatBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	ChkEstadoAnulado.Checked = dtx.Rows(i)("EstadoAnulado").ToString
	ChkEstadoEnvioCierre.Checked = dtx.Rows(i)("EstadoEnvioCierre").ToString
	TxtEstadoEnvioDescripcion.Text = dtx.Rows(i)("EstadoEnvioDescripcion").ToString
	NumEstadoEnvioSunat_id.Text = dtx.Rows(i)("EstadoEnvioSunat_id").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.Fe_EstadosdeEnvioSunatBL
Dim objBE As New BusinessEntities.Fe_EstadosdeEnvioSunatBE

TRY

	ObjBE.EstadoAnulado=ChkEstadoAnulado.Checked
	ObjBE.EstadoEnvioCierre=ChkEstadoEnvioCierre.Checked
	ObjBE.EstadoEnvioDescripcion=TxtEstadoEnvioDescripcion.Text
	ObjBE.EstadoEnvioSunat_id=NumEstadoEnvioSunat_id.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from Fe_EstadosdeEnvioSunat",VgcnxSql)
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

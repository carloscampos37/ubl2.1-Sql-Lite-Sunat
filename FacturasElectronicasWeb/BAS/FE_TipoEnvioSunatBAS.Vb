Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_TipoEnvioSunatBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	NumTipoEnvio_Id.Text = dtx.Rows(i)("TipoEnvio_Id").ToString
	TxtTipoEnvioDescripcion.Text = dtx.Rows(i)("TipoEnvioDescripcion").ToString
	TxtWebService.Text = dtx.Rows(i)("WebService").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_TipoEnvioSunatBL
Dim objBE As New BusinessEntities.FE_TipoEnvioSunatBE

TRY

	ObjBE.TipoEnvio_Id=NumTipoEnvio_Id.Text
	ObjBE.TipoEnvioDescripcion=TxtTipoEnvioDescripcion.Text
	ObjBE.WebService=TxtWebService.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_TipoEnvioSunat",VgcnxSql)
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

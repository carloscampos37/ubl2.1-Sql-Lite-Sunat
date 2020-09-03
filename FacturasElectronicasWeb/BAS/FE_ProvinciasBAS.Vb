Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_ProvinciasBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	TxtProvinciaCodigo.Text = dtx.Rows(i)("ProvinciaCodigo").ToString
	TxtProvinciaDescripcion.Text = dtx.Rows(i)("ProvinciaDescripcion").ToString
	TxtRegionCodigo.Text = dtx.Rows(i)("RegionCodigo").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_ProvinciasBL
Dim objBE As New BusinessEntities.FE_ProvinciasBE

TRY

	ObjBE.ProvinciaCodigo=TxtProvinciaCodigo.Text
	ObjBE.ProvinciaDescripcion=TxtProvinciaDescripcion.Text
	ObjBE.RegionCodigo=TxtRegionCodigo.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_Provincias",VgcnxSql)
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

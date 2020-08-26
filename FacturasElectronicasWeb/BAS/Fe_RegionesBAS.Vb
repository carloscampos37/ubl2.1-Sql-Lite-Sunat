Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New Fe_RegionesBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	TxtRegionCodigo.Text = dtx.Rows(i)("RegionCodigo").ToString
	TxtRegionDescripcion.Text = dtx.Rows(i)("RegionDescripcion").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.Fe_RegionesBL
Dim objBE As New BusinessEntities.Fe_RegionesBE

TRY

	ObjBE.RegionCodigo=TxtRegionCodigo.Text
	ObjBE.RegionDescripcion=TxtRegionDescripcion.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from Fe_Regiones",VgcnxSql)
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

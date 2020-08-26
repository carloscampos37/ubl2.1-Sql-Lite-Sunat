Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_DistritosBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	TxtDistritoCodigo.Text = dtx.Rows(i)("DistritoCodigo").ToString
	TxtDistritoDescripcion.Text = dtx.Rows(i)("DistritoDescripcion").ToString
	TxtProvinciaCodigo.Text = dtx.Rows(i)("ProvinciaCodigo").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_DistritosBL
Dim objBE As New BusinessEntities.FE_DistritosBE

TRY

	ObjBE.DistritoCodigo=TxtDistritoCodigo.Text
	ObjBE.DistritoDescripcion=TxtDistritoDescripcion.Text
	ObjBE.ProvinciaCodigo=TxtProvinciaCodigo.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_Distritos",VgcnxSql)
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

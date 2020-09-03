Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_AfectacionIgvBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	TxtCodigo.Text = dtx.Rows(i)("Codigo").ToString
	TxtId.Text = dtx.Rows(i)("Id").ToString
	TxtMenotecnico.Text = dtx.Rows(i)("Menotecnico").ToString
	TxtNombre.Text = dtx.Rows(i)("Nombre").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_AfectacionIgvBL
Dim objBE As New BusinessEntities.FE_AfectacionIgvBE

TRY

	ObjBE.Codigo=TxtCodigo.Text
	ObjBE.Id=TxtId.Text
	ObjBE.Menotecnico=TxtMenotecnico.Text
	ObjBE.Nombre=TxtNombre.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_AfectacionIgv",VgcnxSql)
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

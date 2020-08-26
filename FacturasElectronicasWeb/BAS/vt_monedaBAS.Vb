Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New vt_monedaBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	Dtpfechaact.Value = dtx.Rows(i)("fechaact").ToString
	Txtmonedacodigo.Text = dtx.Rows(i)("monedacodigo").ToString
	Txtmonedadescripcion.Text = dtx.Rows(i)("monedadescripcion").ToString
	Txtmonedasimbolo.Text = dtx.Rows(i)("monedasimbolo").ToString
	Txtusuariocodigo.Text = dtx.Rows(i)("usuariocodigo").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.vt_monedaBL
Dim objBE As New BusinessEntities.vt_monedaBE

TRY

	ObjBE.fechaact=Dtpfechaact.Value
	ObjBE.monedacodigo=Txtmonedacodigo.Text
	ObjBE.monedadescripcion=Txtmonedadescripcion.Text
	ObjBE.monedasimbolo=Txtmonedasimbolo.Text
	ObjBE.usuariocodigo=Txtusuariocodigo.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from vt_moneda",VgcnxSql)
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

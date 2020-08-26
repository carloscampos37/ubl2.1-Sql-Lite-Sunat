Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New FE_DocumentosxEmpresaBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	TxtDocumentoCodigo.Text = dtx.Rows(i)("DocumentoCodigo").ToString
	TxtEmpresaCodigo.Text = dtx.Rows(i)("EmpresaCodigo").ToString
	ChkEstadoAnulado.Checked = dtx.Rows(i)("EstadoAnulado").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.FE_DocumentosxEmpresaBL
Dim objBE As New BusinessEntities.FE_DocumentosxEmpresaBE

TRY

	ObjBE.DocumentoCodigo=TxtDocumentoCodigo.Text
	ObjBE.EmpresaCodigo=TxtEmpresaCodigo.Text
	ObjBE.EstadoAnulado=ChkEstadoAnulado.Checked

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from FE_DocumentosxEmpresa",VgcnxSql)
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

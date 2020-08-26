Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New Fe_DireccionesSunatBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	NumDireccionSunat_Id.Text = dtx.Rows(i)("DireccionSunat_Id").ToString
	TxtDireccionSunatTipo.Text = dtx.Rows(i)("DireccionSunatTipo").ToString
	TxtDireccionSunatUrl.Text = dtx.Rows(i)("DireccionSunatUrl").ToString
	ChkEstadoAnulado.Checked = dtx.Rows(i)("EstadoAnulado").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.Fe_DireccionesSunatBL
Dim objBE As New BusinessEntities.Fe_DireccionesSunatBE

TRY

	ObjBE.DireccionSunat_Id=NumDireccionSunat_Id.Text
	ObjBE.DireccionSunatTipo=TxtDireccionSunatTipo.Text
	ObjBE.DireccionSunatUrl=TxtDireccionSunatUrl.Text
	ObjBE.EstadoAnulado=ChkEstadoAnulado.Checked

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from Fe_DireccionesSunat",VgcnxSql)
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

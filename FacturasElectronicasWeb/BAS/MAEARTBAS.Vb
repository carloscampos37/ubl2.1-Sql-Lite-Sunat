Private Sub TraerData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim Objdt As New MAEARTBL
dtx = Objdt.ConsultarTabla(VGBase, dato )
If dtx.Rows.Count > 0 Then


	TxtACASILLERO.Text = dtx.Rows(i)("ACASILLERO").ToString
	TxtACODIGO.Text = dtx.Rows(i)("ACODIGO").ToString
	TxtACODIGO2.Text = dtx.Rows(i)("ACODIGO2").ToString
	TxtACODMON.Text = dtx.Rows(i)("ACODMON").ToString
	TxtACODMONC.Text = dtx.Rows(i)("ACODMONC").ToString
	TxtACODPRO.Text = dtx.Rows(i)("ACODPRO").ToString
	TxtACOLOR.Text = dtx.Rows(i)("ACOLOR").ToString
	TxtACOMENTA.Text = dtx.Rows(i)("ACOMENTA").ToString
	TxtACUENTA.Text = dtx.Rows(i)("ACUENTA").ToString
	TxtADESCRI.Text = dtx.Rows(i)("ADESCRI").ToString
	TxtADESCRI2.Text = dtx.Rows(i)("ADESCRI2").ToString
	NumADESCTO.Text = dtx.Rows(i)("ADESCTO").ToString
	NumAFACREF.Text = dtx.Rows(i)("AFACREF").ToString
	TxtAFAMILIA.Text = dtx.Rows(i)("AFAMILIA").ToString
	TxtAFDECI.Text = dtx.Rows(i)("AFDECI").ToString
	DtpAFECHA.Value = dtx.Rows(i)("AFECHA").ToString
	TxtAFECVEN.Text = dtx.Rows(i)("AFECVEN").ToString
	ChkAFLAGIGV.Checked = dtx.Rows(i)("AFLAGIGV").ToString
	TxtAFLOTE.Text = dtx.Rows(i)("AFLOTE").ToString
	TxtAFPRELIB.Text = dtx.Rows(i)("AFPRELIB").ToString
	TxtAFRESTA.Text = dtx.Rows(i)("AFRESTA").ToString
	TxtAFSERIE.Text = dtx.Rows(i)("AFSERIE").ToString
	TxtAFSTOCK.Text = dtx.Rows(i)("AFSTOCK").ToString
	TxtAFUNIREF.Text = dtx.Rows(i)("AFUNIREF").ToString
	TxtAGRUPO.Text = dtx.Rows(i)("AGRUPO").ToString
	TxtAHORA.Text = dtx.Rows(i)("AHORA").ToString
	NumAIGVPOR.Text = dtx.Rows(i)("AIGVPOR").ToString
	NumAISCPOR.Text = dtx.Rows(i)("AISCPOR").ToString
	TxtALINEA.Text = dtx.Rows(i)("ALINEA").ToString
	TxtAMARCA.Text = dtx.Rows(i)("AMARCA").ToString
	TxtAMODELO.Text = dtx.Rows(i)("AMODELO").ToString
	NumAPCOM.Text = dtx.Rows(i)("APCOM").ToString
	NumAPDIS.Text = dtx.Rows(i)("APDIS").ToString
	NumAPESO.Text = dtx.Rows(i)("APESO").ToString
	NumAPRECIO.Text = dtx.Rows(i)("APRECIO").ToString
	NumAPRECOM.Text = dtx.Rows(i)("APRECOM").ToString
	TxtATALLA.Text = dtx.Rows(i)("ATALLA").ToString
	TxtATIPO.Text = dtx.Rows(i)("ATIPO").ToString
	NumAUNIART.Text = dtx.Rows(i)("AUNIART").ToString
	TxtAUNIDAD.Text = dtx.Rows(i)("AUNIDAD").ToString
	TxtAUNIREF.Text = dtx.Rows(i)("AUNIREF").ToString
	TxtAUSER.Text = dtx.Rows(i)("AUSER").ToString
	Txtcodigodebarras.Text = dtx.Rows(i)("codigodebarras").ToString
	ChkEstadoAnulado.Checked = dtx.Rows(i)("EstadoAnulado").ToString
	Chkestadodetraccion.Checked = dtx.Rows(i)("estadodetraccion").ToString
	TxtPA.Text = dtx.Rows(i)("PA").ToString
	ChkProductoBonificacion.Checked = dtx.Rows(i)("ProductoBonificacion").ToString
	ChkProductoFiscalizado.Checked = dtx.Rows(i)("ProductoFiscalizado").ToString
	Txtproyectocodigo.Text = dtx.Rows(i)("proyectocodigo").ToString
	NumStockMinimo.Text = dtx.Rows(i)("StockMinimo").ToString
	TxtTALLA.Text = dtx.Rows(i)("TALLA").ToString
	Numtipodecambio.Text = dtx.Rows(i)("tipodecambio").ToString
End if

End Sub
Private Sub GrabarData(dato As String)
Dim dtx As DataTable
Dim i as integer=0
Dim objBL As New BusinessLogic.MAEARTBL
Dim objBE As New BusinessEntities.MAEARTBE

TRY

	ObjBE.ACASILLERO=TxtACASILLERO.Text
	ObjBE.ACODIGO=TxtACODIGO.Text
	ObjBE.ACODIGO2=TxtACODIGO2.Text
	ObjBE.ACODMON=TxtACODMON.Text
	ObjBE.ACODMONC=TxtACODMONC.Text
	ObjBE.ACODPRO=TxtACODPRO.Text
	ObjBE.ACOLOR=TxtACOLOR.Text
	ObjBE.ACOMENTA=TxtACOMENTA.Text
	ObjBE.ACUENTA=TxtACUENTA.Text
	ObjBE.ADESCRI=TxtADESCRI.Text
	ObjBE.ADESCRI2=TxtADESCRI2.Text
	ObjBE.ADESCTO=NumADESCTO.Text
	ObjBE.AFACREF=NumAFACREF.Text
	ObjBE.AFAMILIA=TxtAFAMILIA.Text
	ObjBE.AFDECI=TxtAFDECI.Text
	ObjBE.AFECHA=DtpAFECHA.Value
	ObjBE.AFECVEN=TxtAFECVEN.Text
	ObjBE.AFLAGIGV=ChkAFLAGIGV.Checked
	ObjBE.AFLOTE=TxtAFLOTE.Text
	ObjBE.AFPRELIB=TxtAFPRELIB.Text
	ObjBE.AFRESTA=TxtAFRESTA.Text
	ObjBE.AFSERIE=TxtAFSERIE.Text
	ObjBE.AFSTOCK=TxtAFSTOCK.Text
	ObjBE.AFUNIREF=TxtAFUNIREF.Text
	ObjBE.AGRUPO=TxtAGRUPO.Text
	ObjBE.AHORA=TxtAHORA.Text
	ObjBE.AIGVPOR=NumAIGVPOR.Text
	ObjBE.AISCPOR=NumAISCPOR.Text
	ObjBE.ALINEA=TxtALINEA.Text
	ObjBE.AMARCA=TxtAMARCA.Text
	ObjBE.AMODELO=TxtAMODELO.Text
	ObjBE.APCOM=NumAPCOM.Text
	ObjBE.APDIS=NumAPDIS.Text
	ObjBE.APESO=NumAPESO.Text
	ObjBE.APRECIO=NumAPRECIO.Text
	ObjBE.APRECOM=NumAPRECOM.Text
	ObjBE.ATALLA=TxtATALLA.Text
	ObjBE.ATIPO=TxtATIPO.Text
	ObjBE.AUNIART=NumAUNIART.Text
	ObjBE.AUNIDAD=TxtAUNIDAD.Text
	ObjBE.AUNIREF=TxtAUNIREF.Text
	ObjBE.AUSER=TxtAUSER.Text
	ObjBE.codigodebarras=Txtcodigodebarras.Text
	ObjBE.EstadoAnulado=ChkEstadoAnulado.Checked
	ObjBE.estadodetraccion=Chkestadodetraccion.Checked
	ObjBE.PA=TxtPA.Text
	ObjBE.ProductoBonificacion=ChkProductoBonificacion.Checked
	ObjBE.ProductoFiscalizado=ChkProductoFiscalizado.Checked
	ObjBE.proyectocodigo=Txtproyectocodigo.Text
	ObjBE.StockMinimo=NumStockMinimo.Text
	ObjBE.TALLA=TxtTALLA.Text
	ObjBE.tipodecambio=Numtipodecambio.Text

dtx = OBJCLSBL.ConsultarTabla(VGBase, "select * from MAEART",VgcnxSql)
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

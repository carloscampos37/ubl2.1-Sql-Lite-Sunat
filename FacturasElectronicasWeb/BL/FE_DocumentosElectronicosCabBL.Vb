Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_DocumentosElectronicosCabBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_DocumentosElectronicosCabBE As FE_DocumentosElectronicosCabBE) As Boolean
Dim objFE_DocumentosElectronicosCabDA As New FE_DocumentosElectronicosCabDA
Try
Return objFE_DocumentosElectronicosCabDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_DocumentosElectronicosCabBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_DocumentosElectronicosCabDA As New FE_DocumentosElectronicosCabDA
Try
Return objFE_DocumentosElectronicosCabDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class

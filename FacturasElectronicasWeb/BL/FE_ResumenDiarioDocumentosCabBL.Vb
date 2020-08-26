Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_ResumenDiarioDocumentosCabBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_ResumenDiarioDocumentosCabBE As FE_ResumenDiarioDocumentosCabBE) As Boolean
Dim objFE_ResumenDiarioDocumentosCabDA As New FE_ResumenDiarioDocumentosCabDA
Try
Return objFE_ResumenDiarioDocumentosCabDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_ResumenDiarioDocumentosCabBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_ResumenDiarioDocumentosCabDA As New FE_ResumenDiarioDocumentosCabDA
Try
Return objFE_ResumenDiarioDocumentosCabDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class

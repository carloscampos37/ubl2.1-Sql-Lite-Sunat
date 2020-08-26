Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_ComunicacionBajaCabBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_ComunicacionBajaCabBE As FE_ComunicacionBajaCabBE) As Boolean
Dim objFE_ComunicacionBajaCabDA As New FE_ComunicacionBajaCabDA
Try
Return objFE_ComunicacionBajaCabDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_ComunicacionBajaCabBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_ComunicacionBajaCabDA As New FE_ComunicacionBajaCabDA
Try
Return objFE_ComunicacionBajaCabDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class

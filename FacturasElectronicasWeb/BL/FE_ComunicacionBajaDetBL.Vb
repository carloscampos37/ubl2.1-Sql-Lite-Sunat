Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_ComunicacionBajaDetBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_ComunicacionBajaDetBE As FE_ComunicacionBajaDetBE) As Boolean
Dim objFE_ComunicacionBajaDetDA As New FE_ComunicacionBajaDetDA
Try
Return objFE_ComunicacionBajaDetDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_ComunicacionBajaDetBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_ComunicacionBajaDetDA As New FE_ComunicacionBajaDetDA
Try
Return objFE_ComunicacionBajaDetDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class

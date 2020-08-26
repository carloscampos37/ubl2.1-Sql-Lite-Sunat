Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class vt_puntovtadocumentoBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objvt_puntovtadocumentoBE As vt_puntovtadocumentoBE) As Boolean
Dim objvt_puntovtadocumentoDA As New vt_puntovtadocumentoDA
Try
Return objvt_puntovtadocumentoDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objvt_puntovtadocumentoBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objvt_puntovtadocumentoDA As New vt_puntovtadocumentoDA
Try
Return objvt_puntovtadocumentoDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class

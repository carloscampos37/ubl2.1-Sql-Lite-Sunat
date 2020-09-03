Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class vt_monedaBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objvt_monedaBE As vt_monedaBE) As Boolean
Dim objvt_monedaDA As New vt_monedaDA
Try
Return objvt_monedaDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objvt_monedaBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objvt_monedaDA As New vt_monedaDA
Try
Return objvt_monedaDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class

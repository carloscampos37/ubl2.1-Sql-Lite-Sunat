Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class vt_listaprecioBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objvt_listaprecioBE As vt_listaprecioBE) As Boolean
Dim objvt_listaprecioDA As New vt_listaprecioDA
Try
Return objvt_listaprecioDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objvt_listaprecioBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objvt_listaprecioDA As New vt_listaprecioDA
Try
Return objvt_listaprecioDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class

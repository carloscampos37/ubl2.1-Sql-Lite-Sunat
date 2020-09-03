Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class vt_pedidoBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objvt_pedidoBE As vt_pedidoBE) As Boolean
Dim objvt_pedidoDA As New vt_pedidoDA
Try
Return objvt_pedidoDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objvt_pedidoBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objvt_pedidoDA As New vt_pedidoDA
Try
Return objvt_pedidoDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class

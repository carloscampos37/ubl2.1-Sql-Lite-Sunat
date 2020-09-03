Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class vt_detallepedidoBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objvt_detallepedidoBE As vt_detallepedidoBE) As Boolean
Dim objvt_detallepedidoDA As New vt_detallepedidoDA
Try
Return objvt_detallepedidoDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objvt_detallepedidoBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objvt_detallepedidoDA As New vt_detallepedidoDA
Try
Return objvt_detallepedidoDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class

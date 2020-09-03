Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_TipoOperacionVentasBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_TipoOperacionVentasBE As FE_TipoOperacionVentasBE) As Boolean
Dim objFE_TipoOperacionVentasDA As New FE_TipoOperacionVentasDA
Try
Return objFE_TipoOperacionVentasDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_TipoOperacionVentasBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_TipoOperacionVentasDA As New FE_TipoOperacionVentasDA
Try
Return objFE_TipoOperacionVentasDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class

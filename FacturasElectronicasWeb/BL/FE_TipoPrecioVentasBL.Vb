Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_TipoPrecioVentasBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_TipoPrecioVentasBE As FE_TipoPrecioVentasBE) As Boolean
Dim objFE_TipoPrecioVentasDA As New FE_TipoPrecioVentasDA
Try
Return objFE_TipoPrecioVentasDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_TipoPrecioVentasBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_TipoPrecioVentasDA As New FE_TipoPrecioVentasDA
Try
Return objFE_TipoPrecioVentasDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class

Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class vt_vendedorBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objvt_vendedorBE As vt_vendedorBE) As Boolean
Dim objvt_vendedorDA As New vt_vendedorDA
Try
Return objvt_vendedorDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objvt_vendedorBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objvt_vendedorDA As New vt_vendedorDA
Try
Return objvt_vendedorDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class

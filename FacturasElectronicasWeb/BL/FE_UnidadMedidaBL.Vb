Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_UnidadMedidaBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_UnidadMedidaBE As FE_UnidadMedidaBE) As Boolean
Dim objFE_UnidadMedidaDA As New FE_UnidadMedidaDA
Try
Return objFE_UnidadMedidaDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_UnidadMedidaBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_UnidadMedidaDA As New FE_UnidadMedidaDA
Try
Return objFE_UnidadMedidaDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class

Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_TipoEnvioSunatBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_TipoEnvioSunatBE As FE_TipoEnvioSunatBE) As Boolean
Dim objFE_TipoEnvioSunatDA As New FE_TipoEnvioSunatDA
Try
Return objFE_TipoEnvioSunatDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_TipoEnvioSunatBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_TipoEnvioSunatDA As New FE_TipoEnvioSunatDA
Try
Return objFE_TipoEnvioSunatDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
